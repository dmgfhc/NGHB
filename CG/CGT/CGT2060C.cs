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
//-- Program Name      火切实绩查询界面_CGT2060C
//-- Program ID        CGT2060C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.28
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.28       韩超        火切实绩查询界面_CGT2060C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2060C : CommonClass.FORMBASE
    {
        public CGT2060C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_PLATE_NO = 0;
        const int SS1_PROC_CD = 3;
        const int SS1_STDSPEC = 4;
        const int SS1_AFER_SIZE = 7;
        const int SS1_AFER_WGT = 8;
        const int SS1_EMP_NO = 22;
        const int SS1_LOC = 23;
        const int SS1_REMARK = 25;
        const int SS1_CUST_CD = 32;
        const int SS1_ORD = 30;
        const int SS1_SIZE = 33;
        const int SS1_URGNT_FL = 34;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 35;

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_LOT_NO, "P", "", "", "", imcseq, "");//1
            p_SetMc(SDT_PROD_DATE, "P", "", "", "", imcseq, "");//2
            p_SetMc(SDT_PROD_TO_DATE, "P", "", "", "", imcseq, "");//3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//4
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");//5
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");//6
            p_SetMc(CHK_FROM_DATE, "P", "", "", "", imcseq, "");//7
            p_SetMc(CHK_TO_DATE, "P", "", "", "", imcseq, "");//8
            p_SetMc(CBO_SURFGRD, "P", "", "", "", imcseq, "");//9
            p_SetMc(CBO_PRODGRD, "P", "", "", "", imcseq, "");//10
            p_SetMc(txt_stdspec, "P", "", "", "", imcseq, "");//11
            p_SetMc(txt_loc, "P", "", "", "", imcseq, "");//12
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, "");//13
            p_SetMc(SDB_THK_TO, "P", "", "", "", imcseq, "");//14
            p_SetMc(SDB_WID, "P", "", "", "", imcseq, "");//15
            p_SetMc(SDB_WID_TO, "P", "", "", "", imcseq, "");//16
            p_SetMc(SDB_LEN, "P", "", "", "", imcseq, "");//17
            p_SetMc(SDB_LEN_TO, "P", "", "", "", imcseq, "");//18
            p_SetMc(CBO_MILLGROUP, "P", "", "", "", imcseq, "");//19
            p_SetMc(cbo_cut_place, "P", "", "", "", imcseq, "");//20

            
            p_ScIni(ss1, Sc1, 22, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("序号", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("进程状态", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度*宽度*长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("来料重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("厚度*宽度*长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("切后重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("原料量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("切割时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("检查时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("取样代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("试样号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("切边", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("切头", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("切尾", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("取样次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("垛位号", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//23
            p_SetSc("探伤实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//25
            p_SetSc("轧制班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("入库日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("切割场地", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("改判前标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("定尺区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("精轧厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//36

            iheadrow = 0;

            p_spanSpread("来料规格", 5, 5, iscseq, iheadrow, 1);
            p_spanSpread("切后规格", 7, 7, iscseq, iheadrow, 1);

        }

        private void CGT2060C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2060NC";
            Form_Define();

            SDT_PROD_DATE.RawDate = Gf_DTSet("D", "");
            SDT_PROD_TO_DATE.RawDate = Gf_DTSet("D", "");

            ss1.ActiveSheet.FrozenColumnCount = 2;

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;
        }

        public override void Form_Pro()
        {
            p_Pro(1, 1, true, true);
        }

        public override void Form_Ref()
        {
            int iRow;
            int iCol;
            string sUrgnt_Fl;
            string SMESG;
            string simpcont;

            if (SDT_PROD_DATE.RawDate == "" | SDT_PROD_TO_DATE.RawDate == "")
            {
                SDT_PROD_DATE.RawDate = Gf_DTSet("D","");
                SDT_PROD_TO_DATE.RawDate = Gf_DTSet("D","");
            }

            if (convertX(SDT_PROD_DATE.RawDate) - convertX(SDT_PROD_TO_DATE.RawDate) > 0)
            {
                SMESG = " 时间范围输入错误，请重新输入时间信息 ！！！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "错误提示");
                return;
            }

            p_Ref(1, 1, true, true);

            //紧急订单绿色显示 add by liqian 2012-08-15
                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text.Trim();
                    simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text.Trim();

                    if (sUrgnt_Fl == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount-1, iRow-1, iRow-1, Color.Green,Color.White);
                    }

                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iRow-1, iRow-1, SSP4.BackColor,Color.White);
                        Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iRow-1, iRow-1, SSP4.BackColor,Color.White);
                    }
                }

        }

        //取样单导出
        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\CGT2060C.xls";//切割码堆报告路径

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

            string sShift;
            string sDate1;
            string sDate2;
            string sDate;
            int sPage_Num = 31;
            int sPage_X = 32;
            int sPage;
            int sLastPage;
            double Weight;
            int sRow1;
            int sRow2;
            int sRow3;

            int rowCount = ss1.ActiveSheet.RowCount;

            sDate1 = SDT_PROD_DATE.RawDate;
            sDate2 = SDT_PROD_TO_DATE.RawDate;
            sDate = "日期：";

            if (sDate1 != "" && sDate2 != "")
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日" + " - " + sDate2.Substring(0, 4) + "年" + sDate2.Substring(4, 2) + "月" + sDate2.Substring(6, 2) + "日";
            }

            if (sDate1 == sDate2)
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日";
            }



            sShift = "";
            if (CBO_SHIFT.Text == "1")
            {
                sShift = "大夜班";
            }
            else if (CBO_SHIFT.Text == "2")
            {
                sShift = "白班";
            }
            else if (CBO_SHIFT.Text == "3")
            {
                sShift = "小夜班";
            }

            //堆码员
            string codeName = "select EMP_NAME from zp_employee t where t.emp_id =" + "'" + GeneralCommon.sUserID + "'";
            appExcel.Cells[2, 4] = "码堆员：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, codeName);
            //班次
            appExcel.Cells[2, 3] = "班次：" + sShift;
            sPage = Convert.ToInt32(rowCount / sPage_Num) + 1;
            sLastPage = rowCount - Convert.ToInt32(rowCount / sPage_Num) * sPage_Num;
            sPage = sPage - 1;
            //日期
            appExcel.Cells[2, 1] = sDate;
            for (int i = 0; i <= sPage; i++)
            {
                int k = 4 + i * sPage_X;
                sRow1 = 35 + sPage_X * i;
                sRow3 = 35 + sPage_X * i;
                Weight = 0;
                if (i == sPage)
                {
                    sRow2 = sPage_Num * i + sLastPage;

                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//钢种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_AFER_SIZE].Text;//切割后规格尺寸（mm）
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_AFER_WGT].Text;//切后重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_ORD].Text;//订单-项次
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE].Text;//定尺区分
                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_AFER_WGT].Text);
                        k = k + 1;
                    }
                    appExcel.Cells[sRow1, 7] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sLastPage.ToString();
                    appExcel.Visible = true;
                    //  appExcel.Quit();//从内存中退出
                    appExcel = null;
                    return;
                }
                else
                {
                    sRow2 = sPage_Num * i + sPage_Num;
                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//钢种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_AFER_SIZE].Text;//切割后规格尺寸（mm）
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_AFER_WGT].Text;//切后重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_ORD].Text;//订单-项次
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE].Text;//定尺区分

                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_AFER_WGT].Text);

                        k = k + 1;
                    }

                    appExcel.Cells[sRow1, 7] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sPage_Num.ToString();
                }
            }
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
            if (SDT_PROD_DATE.RawDate == "" || SDT_PROD_TO_DATE.RawDate == "" || CBO_SHIFT.Text.Trim() == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("切割时间和班次必须输入！！", "I", "错误提示");
                return;
            }
            
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;

            }
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + "CGT2060C.xls";
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
