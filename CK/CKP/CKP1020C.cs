using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
//using FarPoint.PluginCalendar;
//using InDate;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
//using FarPoint.CalcEngine;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
//using FarPoint.Excel;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
//using FarPoint.PluginCalendar.WinForms;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       中板生产管制
//-- Sub_System Name   统计分析管理
//-- Program Name      中板厂订单完成情况简报_CKP1020C
//-- Program ID        CKP1020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.02.08
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.02.08       韩超        中板厂订单完成情况简报_CKP1020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKP1020C : CommonClass.FORMBASE
    {
        public CKP1020C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_ORD_ITEM_NUM = 2;
        const int SPD_ORD_TOT_WGT = 3;
        const int SPD_ORD_REM_WGT_U = 4;
        const int SPD_ORD_REM_WGT_D = 5;
        const int SPD_ORD_SMS_WGT = 6;
        const int SPD_ORD_CCM_WGT = 7;
        const int SPD_ORD_MILL_WGT = 8;
        const int SPD_ORD_CUT_WGT = 9;



       // const int SS1_SLAB_NO = 0;
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(UDA_DEL_FR, "PN", "", "", "", imcseq, "");
            p_SetMc(UDA_DEL_TO, "PN", "", "", "", imcseq, "");
            p_SetMc(txt_ord_knd, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ORD_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ORD_ITEM, "P", "", "", "", imcseq, "");
            p_SetMc(ORD_OK, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("客户", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("序列总数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("订单量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("欠量（上限）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("欠量（下限）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("炼钢", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("连铸", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("轧钢等待", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("精整等待", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            
        }

        private void CKP1020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKP1020NC";
            Form_Define();

            DateTime now = DateTime.Now;
            DateTime d1 = new DateTime(now.Year, now.Month, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);

            txt_ord_knd.Text = "A";
            UDA_DEL_FR.RawDate = d1.ToString("yyyyMMdd");//第一天
            UDA_DEL_TO.RawDate = d2.ToString("yyyyMMdd");//最后一天

        }

        public override void Form_Pro()
        {
           // p_pro(1, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            DateTime now = DateTime.Now;
            DateTime d1 = new DateTime(now.Year, now.Month, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);

            txt_ord_knd.Text = "A";
            UDA_DEL_FR.RawDate = d1.ToString("yyyyMMdd");//第一天
            UDA_DEL_TO.RawDate = d2.ToString("yyyyMMdd");//最后一天

            ORD_NO_Y.Checked = true;
            ORD_OK.Text = "Y";

            return true;

        }

        public override void Form_Ref()
        {
            int iCount;
            double dOrd_item_Num = 0;
            double dOrd_Tot_Wgt = 0;
            double dOrd_Rem_Wgt_U = 0;
            double dOrd_Rem_Wgt_D = 0;
            double dOrd_Sms_Wgt = 0;
            double dOrd_Ccm_Wgt = 0;
            double dOrd_Mill_Wgt = 0;
            double dOrd_Cut_Wgt = 0;

            p_Ref(1, 1, true, true);

            if (ss1.ActiveSheet.RowCount <= 0) return;
            ss1.ActiveSheet.AddRows(ss1.ActiveSheet.RowCount, 1);


            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount - 1; iCount++)
            {

                //订单序列总数
                dOrd_item_Num = dOrd_item_Num + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_ITEM_NUM].Text);
                //订单总重量
                dOrd_Tot_Wgt = dOrd_Tot_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_TOT_WGT].Text);
                //订单欠量（上限）
                dOrd_Rem_Wgt_U = dOrd_Rem_Wgt_U + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_REM_WGT_U].Text);
                //订单欠量（下限）
                dOrd_Rem_Wgt_D = dOrd_Rem_Wgt_D + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_REM_WGT_D].Text);
                //炼钢
                dOrd_Sms_Wgt = dOrd_Sms_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_SMS_WGT].Text);
                //连铸
                dOrd_Ccm_Wgt = dOrd_Ccm_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_CCM_WGT].Text);
                //轧钢等待
                dOrd_Mill_Wgt = dOrd_Mill_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_MILL_WGT].Text);
                //精整等待
                dOrd_Cut_Wgt = dOrd_Cut_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_CUT_WGT].Text);


            }
            int lastRow = ss1.ActiveSheet.RowCount - 1;
            ss1.ActiveSheet.Cells[lastRow, 0].Text = "合计";

            //订单序列总数
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_ITEM_NUM].Text = dOrd_item_Num.ToString();
            //订单总重量
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_TOT_WGT].Text = dOrd_Tot_Wgt.ToString();
            //订单欠量（上限）
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_REM_WGT_U].Text = dOrd_Rem_Wgt_U.ToString();
            //订单欠量（下限）
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_REM_WGT_D].Text = dOrd_Rem_Wgt_D.ToString();
            //炼钢
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_SMS_WGT].Text = dOrd_Sms_Wgt.ToString();
            //连铸
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_CCM_WGT].Text = dOrd_Ccm_Wgt.ToString();
            //轧钢等待
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_MILL_WGT].Text = dOrd_Mill_Wgt.ToString();
            //精整等待
            ss1.ActiveSheet.Cells[lastRow, SPD_ORD_CUT_WGT].Text = dOrd_Cut_Wgt.ToString();


            Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lastRow, lastRow, Color.Black, Color.Pink);

        }


        # region 公共方法

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {
                try
                {
                    return Convert.ToDouble(value);
                }
                catch
                {
                    return 1;
                }
            }
            return 0;
        }
        public double convertD(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
            }
            return 0;
        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion

        private void ORD_NO_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (ORD_NO_Y.Checked)
            {
                ORD_OK.Text = "Y";
            }
        }

        private void ORD_NO_N_CheckedChanged(object sender, EventArgs e)
        {
            if (ORD_NO_N.Checked)
            {
                ORD_OK.Text = "N";
            }
        }



    }
}
