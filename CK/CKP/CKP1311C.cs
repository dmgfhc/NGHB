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
using System.Globalization;

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       中板生产管制
//-- Sub_System Name   统计分析管理
//-- Program Name      月作业计划查询及修改界面
//-- Program ID        CKP1311C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.02.08
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.02.08       韩超        月作业计划查询及修改界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKP1311C : CommonClass.FORMBASE
    {
        public CKP1311C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_EMP_CD = 26;
        const int SPD_PLAN_DATE = 27;

        List<string> aDayWeek = new List<string>();

       // const int SS1_SLAB_NO = 0;
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(sdb_prod_wgt, "IR", "", "", "", imcseq, "");
            p_SetMc(sdb_Mon_prod_wgt, "IR", "", "", "", imcseq, "");
            p_SetMc(sdb_prod_shifts, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_UserId, "IRL", "", "", "", imcseq, "");
            p_SetMc(SDT_PLAN_DATE, "PI", "", "", "", imcseq, "");

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc(sdb_prod_wgt, "IR", "", "", "", imcseq, "");
            p_SetMc(sdb_Mon_prod_wgt, "IR", "", "", "", imcseq, "");
            p_SetMc(sdb_prod_shifts, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_UserId, "IRL", "", "", "", imcseq, "");
            p_SetMc(SDT_PLAN_DATE, "PI", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("日程", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("星期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("甲", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("乙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("丙", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("丁", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("录入人员", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("计划时间", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//27

            iheadrow = 0;
            p_spanSpread("4#炉单炉生产时间(分钟)", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("2/3#炉单炉生产时间(分钟)", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("1#炉单炉生产时间(分钟)", 10, 13, iscseq, iheadrow, 1);
            p_spanSpread("单机生产时间(分钟)", 14, 17, iscseq, iheadrow, 1);
            p_spanSpread("检修时间(分钟)", 18, 21, iscseq, iheadrow, 1);
            p_spanSpread("故障停时(分钟)", 22, 25, iscseq, iheadrow, 1);

                  
        }

        private void CKP1311C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKP1311NC";
            Form_Define();

            SDT_PLAN_DATE.RawDate = DateTime.Now.ToString("yyyyMMdd");

            aDayWeek.Add("日");
            aDayWeek.Add("一");
            aDayWeek.Add("二");
            aDayWeek.Add("三");
            aDayWeek.Add("四");
            aDayWeek.Add("五");
            aDayWeek.Add("六");

        }

        public override void Form_Pro()
        {
            if (ss1.ActiveSheet.RowCount <= 0) return;
            for (int iDR = 1; iDR <= ss1.ActiveSheet.RowCount-1; iDR++)
            {
                ss1.ActiveSheet.RowHeader.Cells[iDR-1,0].Text = "修改";;
                ss1.ActiveSheet.Cells[iDR-1, SPD_EMP_CD].Text =GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[iDR - 1, SPD_PLAN_DATE].Text = SDT_PLAN_DATE.RawDate + iDR.ToString().PadLeft(2, '0');
            }

            if (p_Pro(1, 1, true, false))
            {
                p_Pro(2, 0, true, true);
            }

            S_Sub_Date_Display();
            S_Spread_Edit();
            Zero_Cls();
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            p_Ref(2, 0, true, true);
            if (ss1.ActiveSheet.RowCount <= 0) return;
            ss1.ActiveSheet.AddRows(ss1.ActiveSheet.RowCount, 1);
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 0].Text = "计";
            S_Sub_Date_Display();
            S_Spread_Edit();
            Zero_Cls();


            SDT_PLAN_DATE.Enabled = true;

        }

        private void S_Sub_Date_Display()
        {
            string date;

            if (SDT_PLAN_DATE.RawDate.Length != 8)
            {
                date = DateTime.Now.ToString("yyyyMMdd").Substring(0, 6);
            }
            else
            {
                date = SDT_PLAN_DATE.RawDate.Substring(0, 6);
            }

            string dateString;

            DateTime dt;

            for (int i = 0; i < ss1.ActiveSheet.RowCount-1; i++)
            {
                dateString = date + ss1.ActiveSheet.Cells[i, 0].Text;

                dt = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);

                ss1.ActiveSheet.Cells[i, 1].Text = aDayWeek[Convert.ToInt32(dt.DayOfWeek)];

            }
        }

        private void S_Spread_Edit()
        {
            double[] cWgt = new double[27];

            for (int iDR = 0; iDR < ss1.ActiveSheet.RowCount - 1; iDR++)
            {
                for (int IDc = 2; IDc < ss1.ActiveSheet.ColumnCount - 2; IDc++)
                {
                    cWgt[IDc] = cWgt[IDc] + convertX(ss1.ActiveSheet.Cells[iDR, IDc].Text);
                }
            }

            for (int IDc = 2; IDc < ss1.ActiveSheet.ColumnCount - 2; IDc++)
            {
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, IDc].Text = cWgt[IDc].ToString();
            }
        }

        public void Zero_Cls()
        {
                for (int iDR = 1; iDR <= ss1.ActiveSheet.RowCount; iDR++)
                {
                    for (int IDc = 3; IDc <= ss1.ActiveSheet.ColumnCount; IDc++)
                    {
                        if (ss1.ActiveSheet.Cells[iDR - 1, IDc-1].Text == "0")
                            ss1.ActiveSheet.Cells[iDR - 1, IDc - 1].Text = "";
                    }
                }
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

      

    }
}
