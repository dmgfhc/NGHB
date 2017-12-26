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
    public partial class CGT2020C : CommonClass.FORMBASE
    {
        public CGT2020C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_PLATE_NO = 0;
        const int SS1_TRNS_CMPY_CD = 3;
        const int SS1_MILL_LOT_NO = 5;
        const int SS1_APLY_STDSPEC = 15;
        const int SS1_PROD_THK = 16;
        const int SS1_ORD_THK = 21;
        const int SS1_ORD_WID = 22;
        const int SS1_ORD_LEN = 23;
        const int SS1_PROD_CAL_UNIT_WGT = 24;
        const int SS1_TRIM_FL = 25;
        const int SS1_SIZE_KND = 26;
        const int SS1_HTM_METH1 = 29;
        //是否热处理标记蓝色 2013-05-28  by  LiQian
        const int SS1_PROD_DATE = 32;
        const int SS1_SHIFT = 36;
        const int SS1_GROUP_CD = 37;
        const int SS1_LEN_TOL = 47;
        const int SS1_DEL_TO_DATE = 50;
        const int SS1_ORD_CNT = 52;
        const int SS1_URGNT_FL = 53;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 56;
        const int SS1_PILECOOL = 57;

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");//1
            p_SetMc(TXT_MILL_LOT_NO, "P", "", "", "", imcseq, "");//2
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");//3
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");//4
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//5
            p_SetMc(txt_stdspec, "P", "", "", "", imcseq, "");//6
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, "");//7
            p_SetMc(SDB_THK_TO, "P", "", "", "", imcseq, "");//8
            p_SetMc(SDB_WID, "P", "", "", "", imcseq, "");//9
            p_SetMc(SDB_WID_TO, "P", "", "", "", imcseq, "");//10
            p_SetMc(SDB_LEN, "P", "", "", "", imcseq, "");//11
            p_SetMc(SDB_LEN_TO, "P", "", "", "", imcseq, "");//12
            p_SetMc(cbo_gas_fl, "P", "", "", "", imcseq, "");//13
            p_SetMc(SDB_THK_PLAN, "P", "", "", "", imcseq, "");//14
            p_SetMc(SDB_THK_PLAN_TO, "P", "", "", "", imcseq, "");//15
            p_SetMc(SDB_WID_PLAN, "P", "", "", "", imcseq, "");//16
            p_SetMc(SDB_WID_PLAN_TO, "P", "", "", "", imcseq, "");//17
            p_SetMc(SDB_LEN_PLAN, "P", "", "", "", imcseq, "");//18
            p_SetMc(SDB_LEN_PLAN_TO, "P", "", "", "", imcseq, "");//19
            p_SetMc(cbo_plate_yn, "P", "", "", "", imcseq, "");//20
            p_SetMc(cbo_scrap, "P", "", "", "", imcseq, "");//21
            p_SetMc(TXT_TRNS_CMPY_CD, "P", "", "", "", imcseq, "");//22
            p_SetMc(TXT_TRNS_CMPY_CD_TO, "P", "", "", "", imcseq, "");//23
            p_SetMc(txt_stlgrd, "P", "", "", "", imcseq, "");//24
            
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("母板号", "E", "60", "PL", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("喷印号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("标准钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("长度", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("取样方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("取样长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("产品标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("厚度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("钢板不平度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("测量长度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("钢板不平度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("测量长度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("长度", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("抛丸", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("热处理方法1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("热处理方法2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("喷涂交货", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("母板切割日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("实际成品量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("是否剪切", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("原料量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("作业人", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//39
            p_SetSc("订单序列号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//40
            p_SetSc("是否判废", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("订单备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//42
            p_SetSc("当前库", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("垛位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("打印标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//45
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("长度范围", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//47
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//48
            p_SetSc("开始时间", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("结束时间", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("订单数量", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("是否翻板", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("经RH", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//56
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//57
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//58
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//59
            p_SetSc("客户代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//61
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//62
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//63
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//64
            p_SetSc("转库日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//65
            p_SetSc("到达日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//66
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//67

            iheadrow = 0;

            p_spanSpread("母板实绩", 9, 12, iscseq, iheadrow, 1);
            p_spanSpread("产品计划", 16, 22, iscseq, iheadrow, 1);
            p_spanSpread("作业指示", 27, 30, iscseq, iheadrow, 1);
            p_spanSpread("标识", 45, 46, iscseq, iheadrow, 1);
            p_spanSpread("客户交货期", 49, 50, iscseq, iheadrow, 1);
            p_spanSpread("厚度公差", 58, 59, iscseq, iheadrow, 1);

        }

        private void CGT2010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2020NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            ss1.ActiveSheet.FrozenColumnCount = 2;

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            //激活下事件
            TXT_TRNS_CMPY_CD.Text = "";
            TXT_TRNS_CMPY_CD_TO.Text = "";

            return true;
        }

        public override void Form_Ref()
        {
            int iRow;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            double sord_cnt;
            Color sBackColor;
            string sHtm_Meth;
            string simpcont;
            string PILECOOL;

            sCurDate = DateTime.Now.ToString("yyyyMMdd");

            if (TXT_TRNS_CMPY_CD.Text != "" | TXT_TRNS_CMPY_CD_TO.Text != "")
            {
                if (SDT_PROD_DATE_FROM.RawDate == SDT_PROD_DATE_TO.RawDate)
                {
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("切割时间必须为同一天", "I", "系统提示信息");
                    return;
                }
            }

            p_Ref(1, 1, true, true);

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                sord_cnt = convertX(ss1.ActiveSheet.Cells[iRow - 1, SS1_ORD_CNT].Text);

                if (sord_cnt > 1)
                {
                 Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP1.BackColor);
                }

                sDel_To_Date = ss1.ActiveSheet.Cells[iRow - 1, SS1_DEL_TO_DATE].Text.Substring(0, 6);
                if (convertX(sDel_To_Date) < convertX(sCurDate))
                {
                    if (sord_cnt > 1)
                    {
                        sBackColor = SSP1.BackColor;
                    }
                    else
                    {
                        sBackColor = Color.White;
                    }
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, sBackColor);
                }

                sHtm_Meth = ss1.ActiveSheet.Cells[iRow - 1, SS1_HTM_METH1].Text;
                if (sHtm_Meth != "")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSPanel1.BackColor);
                }

                //紧急订单绿色标记 2012-08-16  by  LiQian
                if (ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text == "Y")
                {
                    Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iRow - 1, iRow - 1, Color.Green, Color.White);
                }

                simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text;
                if (simpcont == "Y")
                {
                    Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                }

                PILECOOL = ss1.ActiveSheet.Cells[iRow - 1, SS1_PILECOOL].Text;
                simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text;

                if (PILECOOL == "Y" & simpcont != "Y")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, Color.Yellow);
                }

            }

           // checkBox1.Checked = ss1.ActiveSheet.Columns[0].Locked;

           // ss1.ActiveSheet.Cells[0, 0].BackColor = Color.RoyalBlue;



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
