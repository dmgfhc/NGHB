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
//-- System Name       中板轧钢作业
//-- Sub_System Name   板坯库管理
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG {
    public partial class CGC2070C: CommonClass.FORMBASE {
        public CGC2070C() {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_SMP_YN = 0;
        const int SS1_MPLATE_NO = 1;
        const int SS1_TRNS_CMPY_CD = 2;
        const int SS1_LINE1 = 13;
        const int SS1_LINE2 = 14;
        const int SS1_LINE3 = 15;
        const int SS1_LINE4 = 16;
        const int SS1_OFFLINE_DATE = 17;
        const int SS1_USERID = 22;
        const int SS1_PLAN_SMP = 23;
        const int SS1_PRC_LINE = 24;
        const int SS1_ORD_CNT = 25;
        //一坯多订单  2011-08-18  by  LiQian
        const int SS1_URGNT_FL = 26;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 27;

        //const int SPD_PLAN_PROD_WGT = 33,

        protected override void p_SubFormInit() {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("查询号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_SEQ, "P", "", "", "", "", imcseq);
            p_SetMc("火切指示", CBO_GAS_FL, "P", "", "", "", "", imcseq);
            p_SetMc("开始时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("结束时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("已分线母板", CBO_NUM, "P", "", "", "", "", imcseq);


            p_ScIni(ss1, Sc1, 22, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("取样", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("母板号", "E", "20", "PI", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("子公司代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("计划切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("是否探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("是否真空", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("1#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("2#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("3#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("4#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("下线时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("计划/实绩", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("母板分段时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //20
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //21
            p_SetSc("作业人员", "E", "20", "IL", "", "", "", iscseq, iheadrow, "L"); //22
            p_SetSc("计划取样", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("作业线", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("订单数量", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //27


            iheadrow = 0;
            p_spanSpread("成品尺寸", 20, 21, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        private void SDT_PROD_DATE_FROM_GotFocus() {
            if (SDT_PROD_DATE_FROM.RawDate == "") {
                SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            }
            if (SDT_PROD_DATE_TO.RawDate == "") {
                SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
            }
        }

        private void SDT_PROD_DATE_TO_GotFocus() {
            if (SDT_PROD_DATE_TO.RawDate == "") {
                SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
            }
        }

        private void ss1_EditMode(int col, int row) {
            if (col == SS1_SMP_YN | col == SS1_LINE1 | col == SS1_LINE2 | col == SS1_LINE3 | col == SS1_LINE4) {
                if (GeneralCommon.Gf_Sc_Authority(base.sAuthority, "U")) {

                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_USERID].Text = GeneralCommon.sUserID;
                    if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE1].Text == "False") {
                        if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE2].Text == "False") {
                            if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE3].Text == "False") {
                                if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE4].Text == "False") {
                                    if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_SMP_YN].Text == "False") {
                                        ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.ActiveRowIndex, 0].Text = "";
                                    }
                                }
                            }
                        }
                    }

                }
            }

        }

        public void Form_Load(object sender, System.EventArgs e) {
            base.sSvrPgmPkgName = "CGC2070NC";
            Form_Define();

            CBO_SHIFT.Items.Add("1");
            CBO_SHIFT.Items.Add("2");
            CBO_SHIFT.Items.Add("3");

            CBO_GROUP.Items.Add("A");
            CBO_GROUP.Items.Add("B");
            CBO_GROUP.Items.Add("C");
            CBO_GROUP.Items.Add("D");

            CBO_NUM.Items.Add("2");
            CBO_NUM.Items.Add("4");
            CBO_NUM.Items.Add("6");
            CBO_NUM.Items.Add("8");

            CBO_GAS_FL.Items.Add("");
            CBO_GAS_FL.Items.Add("Y 有火切指示");
            CBO_GAS_FL.Items.Add("N 无火切指示");

            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SMP_YN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_OFFLINE_DATE, true);

        }


        public override void Form_Ref() {

            string SMESG;
            int lRow;
            string sSmp_color;
            string sCnt_color;

            p_Ref(1, 1, true, true);

            for (lRow = 1; lRow <= ss1.ActiveSheet.RowCount; lRow++) {

                // 一坯多订单,字体显示蓝色  2011-08-18  by  LiQian
                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_ORD_CNT].Text != "") {
                    if (Convert.ToInt32(ss1.ActiveSheet.Cells[lRow - 1, SS1_ORD_CNT].Text) > 1) {
                        sCnt_color = "#0000FF";
                    } else {
                        sCnt_color = "#000000";
                    }

                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, ColorTranslator.FromHtml(sCnt_color), Color.White);
                }

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PRC_LINE].Text != "X") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP2.BackColor);
                }

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text != "") {
                    if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text == "Y") {
                        sSmp_color = "#FF0000";
                    } else {
                        sSmp_color = "#000000";
                    }

                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, ColorTranslator.FromHtml(sSmp_color), SSP3.BackColor);
                }
                //紧急订单绿色标记 2012-08-16  by  LiQian
                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_URGNT_FL].Text == "Y") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_MPLATE_NO, SS1_MPLATE_NO, lRow - 1, lRow - 1, Color.Green, Color.White);
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_TRNS_CMPY_CD, SS1_TRNS_CMPY_CD, lRow - 1, lRow - 1, Color.Green, Color.White);
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_URGNT_FL, SS1_URGNT_FL, lRow - 1, lRow - 1, Color.Green, Color.White);
                }

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_IMP_CONT].Text == "Y") {

                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_MPLATE_NO, SS1_MPLATE_NO, lRow - 1, lRow - 1, SSP4.BackColor, Color.White);
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, lRow - 1, lRow - 1, SSP4.BackColor, Color.White);
                }

            }

        }


        public override void Form_Pro() {

            int iCount;
            string sPlateNo;

            int inum;
            int lRow;
            string sSmp_color;
            string sCnt_color;

            p_pro(1, 1, true, true);

            //    If Gf_Sp_Process(M_CN1, Proc_Sc("SC"), Mc1) Then
            //        Call MDIMain.FormMenuSetting(Me, FormType, "RE", sAuthority)
            //        ss1.ROW = IIf(Val(txt_tmpseq.Text) = 0, 1, Val(txt_tmpseq.Text))
            //        ss1.SetActiveCell ss1.ActiveCol, ss1.ROW
            //    End If

            for (lRow = 1; lRow <= ss1.ActiveSheet.RowCount; lRow++) {

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PRC_LINE].Text != "X") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP2.BackColor);
                }

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text != "") {
                    if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text == "Y") {
                        sSmp_color = "#FF0000";
                    } else {
                        sSmp_color = "#000000";
                    }
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, ColorTranslator.FromHtml(sSmp_color), SSP3.BackColor);
                }

                // 一坯多订单,字体显示蓝色  2011-08-18  by  LiQian

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_ORD_CNT].Text != "") {
                    if (Convert.ToInt32(ss1.ActiveSheet.Cells[lRow - 1, SS1_ORD_CNT].Text) > 1) {
                        sCnt_color = "#0000FF";
                    } else {
                        sCnt_color = "#000000";
                    }

                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, ColorTranslator.FromHtml(sCnt_color), Color.White);
                }

                //紧急订单绿色标记 2012-08-16  by  LiQian

                if (ss1.ActiveSheet.Cells[lRow - 1, SS1_URGNT_FL].Text == "Y") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_MPLATE_NO, SS1_MPLATE_NO, lRow - 1, lRow - 1, Color.Green, Color.White);
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_TRNS_CMPY_CD, SS1_TRNS_CMPY_CD, lRow - 1, lRow - 1, Color.Green, Color.White);
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_URGNT_FL, SS1_URGNT_FL, lRow - 1, lRow - 1, Color.Green, Color.White);
                }

            }
        }



        private void ss1_Clk(int col, int row) {

            if (ss1.ActiveSheet.RowCount <= 0) return;

            if ((col == SS1_SMP_YN | col == SS1_LINE1 | col == SS1_LINE2 | col == SS1_LINE3 | col == SS1_LINE4)) {

                ss1.EditMode = true;

                if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, col].Text == "False") {
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, col].Value = 1;
                } else {
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, col].Value = 0;
                }


                if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, col].Text == "True") {
                    if (col == SS1_LINE1) {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE2].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE3].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE4].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OFFLINE_DATE].Text = "";
                    } else if (col == SS1_LINE2) {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE1].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE3].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE4].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OFFLINE_DATE].Text = "";
                    } else if (col == SS1_LINE3) {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE1].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE2].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE4].Value = 0;
                    } else if (col == SS1_LINE4) {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE1].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE2].Value = 0;
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_LINE3].Value = 0;
                    }
                } else {
                    ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.ActiveRowIndex, 0].Text = "";
                }

                ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_USERID].Text = GeneralCommon.sUserID;

                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, ss1.ActiveSheet.ActiveRowIndex, ss1.ActiveSheet.ActiveRowIndex, Color.Black, SSP1.BackColor);

                //txt_tmpseq.Text = ss1.ActiveSheet.ActiveRowIndex;

            }

        }



        #region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk) {
            sDTChk = "M";
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M") {
                iDateCheck = DateCheck;
            } else {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000) {
                return false;
            }

            switch (iDateCheck.Length) {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 10));
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 16));
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 19));
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 8)) {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE) {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                if (WKDATE != "") {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            Shift_HH = "";
                        } else {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800) {
                    return "1";
                } else if (Convert.ToInt32(Shift_HH) < 1600) {
                    return "2";
                } else {
                    return "3";
                }
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate) {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            group = "";
                        } else {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag) {
            DTCheck = "S";
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck) {
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

            if (DTFlag == "C") {
                if (DTCheck == "T") {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            time = "";
                        } else {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                } else {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e) {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++) {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e) {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++) {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        #endregion

    }
}
