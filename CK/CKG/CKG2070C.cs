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
using System.IO;

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       中板生产管制
//-- Sub_System Name   轧钢作业
//-- Program Name      轧钢计划查询界面_CKG2070C
//-- Program ID        CKG2070C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.22       韩超        轧钢计划查询界面_CKG2070C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2070C : CommonClass.FORMBASE
    {
        public CKG2070C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

       // const int SS1_SLAB_NO = 0;

        const int SPD_ROLL_MANA_NO = 0;
        const int SPD_ROLL_SLAB_SEQ = 1;
        const int SPD_ACTUAL_ROLLING_LEN = 2;
        //const int SPD_SEQ_NO = 34;
        //const int SPD_SLAB_EDT_SEQ = 35;
        const int SPD_FL = 3;
        const int SPD_URGNT_FL = 27;
        const int SPD_SLAB_NO = 5;
        const int SPD_FL1 = 4;
        const int SPD_CHOSE_FL = 28;
        const int SPD_LOC = 14;
        const int SPD_SIZE = 8;
        const int SPD_STLGRD = 10;
        const int SPD_MILL_STLGRD = 11;
        const int SPD_PROD_THK = 16;
        const int SPD_PROD_WID = 17;
        const int SPD_ORD_CNT = 27;
        const int SPD_DATE = 29;

        private string Ex_File_Name = "CKG2070C";
        
        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("", TXT_SLAB_NO, "P", "", "", "", "", imcseq);//0
            p_SetMc("", TXT_STLGRD, "P", "", "", "", "", imcseq);//1
            p_SetMc("", TXT_ORD_NO, "P", "", "", "", "", imcseq);//2
            p_SetMc("", CBO_ORD_ITEM, "P", "", "", "", "", imcseq);//3
            p_SetMc("", SDT_IN_DATE_FROM, "P", "", "", "", "", imcseq);//4
            p_SetMc("", SDT_IN_DATE_TO, "P", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_MILL_STLGRD, "P", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_SIZE, "P", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_SLAB_THK, "P", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_SLAB_THK_TO, "P", "", "", "", "", imcseq);//9
            p_SetMc("", SDB_SLAB_WID, "P", "", "", "", "", imcseq);//0
            p_SetMc("", SDB_SLAB_WID_TO, "P", "", "", "", "", imcseq);//11
            p_SetMc("", SDB_SLAB_LEN, "P", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_SLAB_LEN_TO, "P", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_THK, "P", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_THK_TO, "P", "", "", "", "", imcseq);//15
            p_SetMc("", SDB_WID, "P", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_WID_TO, "P", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_LEN, "P", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_LEN_TO, "P", "", "", "", "", imcseq);//19
            p_SetMc("", COB_FL, "P", "", "", "", "", imcseq);//20

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("辊期", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("辊期内板坯顺序", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("辊期内累计公里数", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("标记", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("备料", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯号", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("板坯类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("指示状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("板坯重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("订单号-序列", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当前位置", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("轧件长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("产品厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("产品宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("产品长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("控轧代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("实绩成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("计划编制时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("交货期结束", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("是否紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("备料", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("备料时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//29
          
           

            //iheadrow = 0;
            
        }

        public override void Form_Pro()
        {
            p_pro(1, 1, false, false);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            int lRow;
            int sFl;
            string urgnt;
            int CNT;

            //     If Not Gp_DateCheck(SDT_PROD_DATE_FROM.Text, "S") Or Not Gp_DateCheck(SDT_PROD_DATE_TO.Text, "S") Then
            //        Call Gp_MsgBoxDisplay("请输入生产时间")
            //        Exit Sub
            //     End If

            p_Ref(1, 1, true, true);

            int iRow;
            int s1num =0;

                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    ss1.ActiveSheet.RowHeader.Cells[iRow-1,0].Text = "修改";
                    urgnt = ss1.ActiveSheet.Cells[iRow - 1, SPD_URGNT_FL].Text.Trim();
                    if (urgnt == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SPD_SLAB_NO, ss1.ActiveSheet.ColumnCount-1, iRow-1, iRow-1, SSP1.BackColor,Color.White);
                    }

                    if (ss1.ActiveSheet.Cells[iRow - 1, SPD_FL1].Text == "True")
                    {
                        s1num = s1num + 1;
                    }

                    if (opt_fl.Checked == true)
                    {
                        ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = "1";
                    }
                    else if (opt_cancel_fl.Checked == true)
                    {
                        ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = "2";
                    }
                    else if (opt_no_fl.Checked == true)
                    {
                        ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = "2";
                    }

                }

            TXT_FL_DATE.Text = ss1.ActiveSheet.Cells[0, SPD_DATE].Text.Trim();


            CNT = ss1.ActiveSheet.RowCount;
            TXT_ALL_COUNT.Text = CNT.ToString();
            TXT_COUNT.Text = s1num.ToString();
        }

        private void CKG2070C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKG2080NC";
            Form_Define();

            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ROLL_MANA_NO, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ROLL_SLAB_SEQ, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ACTUAL_ROLLING_LEN, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_SEQ_NO, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_SLAB_EDT_SEQ, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_FL1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CHOSE_FL, true);
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

        private void opt_fl_Click(object sender, EventArgs e)
        {
            int iRow;
            if (opt_fl.Checked == true)
            {
                opt_fl.ForeColor = Color.Red;
                opt_cancel_fl.ForeColor = Color.Black;
                opt_no_fl.ForeColor = Color.Black;
                TXT_FL.Text = "1";
            }
            else
            {
                opt_fl.ForeColor = Color.Black;
            }

            if (ss1.ActiveSheet.RowCount <= 0) return;
            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = TXT_FL.Text;
                }
        }

        private void opt_cancel_fl_Click(object sender, EventArgs e)
        {
            int iRow;
            if (opt_cancel_fl.Checked == true)
            {
                opt_cancel_fl.ForeColor = Color.Red;
                opt_fl.ForeColor = Color.Black;
                opt_no_fl.ForeColor = Color.Black;
                TXT_FL.Text = "2";
            }
            else
            {
                opt_cancel_fl.ForeColor = Color.Black;
            }

            if (ss1.ActiveSheet.RowCount <= 0) return;
                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = TXT_FL.Text;
                }
        }

        private void opt_no_fl_Click(object sender, EventArgs e)
        {
            int iRow;
            if (opt_no_fl.Checked == true)
            {
                opt_no_fl.ForeColor = Color.Red;
                opt_cancel_fl.ForeColor = Color.Black;
                opt_fl.ForeColor = Color.Black;
                TXT_FL.Text = "3";
            }
            else
            {
                opt_no_fl.ForeColor = Color.Black;
            }

            if (ss1.ActiveSheet.RowCount <= 0) return;
                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    ss1.ActiveSheet.Cells[iRow - 1, SPD_CHOSE_FL].Text = TXT_FL.Text;
                }
        }

        private void CMD_CARD_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                int rowCount = ss1.ActiveSheet.RowCount;
                setExcelText(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model\\" + Ex_File_Name + ".xls";

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText(string targetExcelName, int rowCount)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            appExcel.Cells[2, 7] = "备料日期：" + DateTime.Now.ToString("yyyy") + "年" + DateTime.Now.ToString("MM") + "月" + DateTime.Now.ToString("dd") + "日" + DateTime.Now.ToString("hh") + "时" + DateTime.Now.ToString("mm") + "分" + DateTime.Now.ToString("ss") + "秒";

            int k;
            for (int j = 0; j < ss1.ActiveSheet.RowCount; j++)
            {
                k = j + 4;
                appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SPD_SLAB_NO].Text;//
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SPD_LOC].Text;//
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SPD_SIZE].Text;//
                appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SPD_STLGRD].Text;//
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SPD_MILL_STLGRD].Text;//
                appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SPD_PROD_THK].Text;//
                appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SPD_PROD_WID].Text;//
                appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SPD_ORD_CNT].Text;//
            }

            appExcel.Visible = true;
            //  appExcel.Quit();//从内存中退出
            appExcel = null;



        }

    }
}
