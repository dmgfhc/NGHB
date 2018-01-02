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
//-- System Name       中板轧钢作业
//-- Sub_System Name   统计分析管理
//-- Program Name      母板分段实绩查询_CGT2020C
//-- Program ID        CGT2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.22       韩超        母板分段实绩查询_CGT2020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGD2062C : CommonClass.FORMBASE
    {
        public CGD2062C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始日期", SDT_PROD_DATE_FROM, "PN", " ", "", "", "", imcseq);
            p_SetMc("结束日期", SDT_PROD_DATE_TO, "PN", " ", "", "", "", imcseq);
            p_SetMc("", TXT_CO_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("", TXT_OVER_FL, "P", " ", "", "", "", imcseq);
            
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("品种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("当日块", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("当月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("当日重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("当日块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("当日重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("当日块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("当日探伤合格率%", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("当月探伤合格率%", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
           
            iheadrow = 0;
            p_spanSpread("合格品", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("不合格品", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("合计", 10, 13, iscseq, iheadrow, 1);

        }

        private void CGT2020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2062NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            ss1.ActiveSheet.FrozenColumnCount = 2;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;
        }

        public override void Form_Ref()
        {
           

        }

        //取样单导出
        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\CGT2020C.xls";//表喷信息EXCEL路径

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText(string targetExcelName)
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

            for (int i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {

                int j = i - 1;
                int k = i + 2;

                appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_TRNS_CMPY_CD].Text;//
                appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_MILL_LOT_NO].Text;//
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_APLY_STDSPEC].Text;//
                appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_THK].Text;//
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_THK].Text;//
                appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_WID].Text;//
                appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_LEN].Text;//
                appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_CAL_UNIT_WGT].Text;//
                appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[j, SS1_TRIM_FL].Text;//
                appExcel.Cells[k, 11] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE_KND].Text;//
                appExcel.Cells[k, 12] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_DATE].Text;//
                appExcel.Cells[k, 13] = this.ss1.ActiveSheet.Cells[j, SS1_SHIFT].Text;//
                appExcel.Cells[k, 14] = this.ss1.ActiveSheet.Cells[j, SS1_GROUP_CD].Text;//
                appExcel.Cells[k, 15] = this.ss1.ActiveSheet.Cells[j, SS1_LEN_TOL].Text;//

            }

            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;
        }


        # region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }
            if (iDateCheck == "")
            {
                return false;
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 6))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {

            if (DTCheck == "D")
            {
                DTCheck = "D";
            }
            else
            {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        //解锁指定列
        public void unlockColumn(FpSpread e,int[] columns)
        {
            FarPoint.Win.Spread.SheetView with_1 = e.ActiveSheet;

            foreach (int i in columns)
            {
                with_1.Columns[i].Locked = false;

            }
        }

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

        private void CMD_CARD_Click(object sender, EventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;

            }
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + "CGT2020C.xls";
                resetExcelName(currentReportPath, targetExcelName);
                setExcelText(targetExcelName);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

    }
}
