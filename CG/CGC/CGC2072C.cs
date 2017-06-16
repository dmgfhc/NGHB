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
//-- Sub_System Name   板坯库管理
//-- Program Name      实物取样录入界面
//-- Program ID        CGC2072C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.06.16
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.06.16       韩超        实物取样录入界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG {
    public partial class CGC2072C: CommonClass.FORMBASE {
        public CGC2072C() {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc2 = new Collection();

        const int SS1_PLAN_SMP = 0;
        //取样
        const int SS1_ORD_CNT = 1;
        const int SS1_MOTHER_NO = 2;
        const int SS1_MV_DATE = 3;
        const int SS1_SHIFT = 4;
        const int SS1_TRNS_CMPY_CD = 5;
        const int SS1_OUT_SHEET_NO = 6;
        const int SS1_TRIM_FL = 8;
        const int SS1_PLATE_NO = 9;
        const int SS1_ORD_THK = 10;
        const int SS1_ORD_WID = 11;
        const int SS1_ORD_LEN = 12;
        const int SS1_SIZE_KND = 13;
        const int SS1_LEN_LIM = 14;
        const int SS1_THK_LIM = 15;
        const int SS1_APLY_STDSPEC = 17;
        const int SS1_LEN = 21;
        const int SS1_UST_STATUS = 23;
        const int SS1_GAS_STATUS = 24;
        const int SS1_CL_STATUS = 25;
        const int SS1_HTM_METH = 26;
        const int SS1_QT = 27;
        const int SS1_ORD_NO = 28;
        const int SS1_CUST_CD = 30;
        const int SS1_CUST_NAME = 31;
        const int SS1_ORD_REMARK = 32;
        const int SS1_STDSPEC_STLGRD = 33;
        const int SS1_STDSPEC_ORG_KND = 34;
        const int SS1_CD_MANA_NO = 35;
        const int SS1_SUSERID = 36;
        const int SS1_IN_CAR_NO = 37;
        const int SS1_MILL_EXCEPTION = 38;
        const int SS1_MILL_EXCEPTION_FH = 39;

        string mOplate_No;

        //const int SPD_PLAN_PROD_WGT = 33,



        protected override void p_SubFormInit() {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SEQ, "P", "", "", "", imcseq, "");
            p_SetMc(txt_place, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_LINE, "P", "", "", "", imcseq, "");
            p_SetMc(txt_in_car_no, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, "");
            p_SetMc(SDB_THK_TO, "P", "", "", "", imcseq, "");

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 36, false, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("取样", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("母板号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("日期", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("分段号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("喷印号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("切边代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("钢板号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //10
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //11
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //12
            p_SetSc("是否定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("长度范围", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("厚度范围", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //19
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //20
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //21
            p_SetSc("取样长度", "E", "", "L", "", "", "", iscseq, iheadrow, "R"); //22
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //23
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //24
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("其他", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "M"); //28
            p_SetSc("序列", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("客户代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //30
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //31
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //32
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //33
            p_SetSc("执行标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //34
            p_SetSc("子公司代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //35
            p_SetSc("操作人员", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //36
            p_SetSc("已取样", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //37
            p_SetSc("工艺异常", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //38
            p_SetSc("返红工艺异常", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //39

            iheadrow = 0;
            p_spanSpread("分段信息", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("钢板计划", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("母板规格", 19, 21, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 23, 27, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 28, 32, iscseq, iheadrow, 1);
            p_spanSpread("标识", 33, 34, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_CNT, true);

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("钢板号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //0 
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("重量", "E", "14", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //10

            p_SetSc("订单备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L"); //12

            //SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_OCCR_TIME, true);

        }
        private void CBO_CAR_NO_Clk() {
            if (CBO_CAR_NO.Text == "已取样") {
                txt_in_car_no.Text = "Y";
            } else if (CBO_CAR_NO.Text == "未取样") {
                txt_in_car_no.Text = "N";
            }
        }

        private void opt_on_Clk() {
            txt_place.Text = "1";
            if (opt_on.Checked) {
                opt_on.ForeColor = Color.Red;
                opt_trk.ForeColor = Color.Black;
            } else {
                opt_on.ForeColor = Color.Black;
            }
        }

        private void opt_trk_Clk() {
            txt_place.Text = "2";
            if (opt_trk.Checked) {
                opt_trk.ForeColor = Color.Red;
                opt_on.ForeColor = Color.Black;
            } else {
                opt_trk.ForeColor = Color.Black;
            }
        }

        public void Form_Load(object sender, System.EventArgs e) {
            base.sSvrPgmPkgName = "CGC2072NC";
            Form_Define();
            ss1.ActiveSheet.FrozenColumnCount = 1;
            CBO_SHIFT.Items.Add("1");
            CBO_SHIFT.Items.Add("2");
            CBO_SHIFT.Items.Add("3");

            CBO_GROUP.Items.Add("A");
            CBO_GROUP.Items.Add("B");
            CBO_GROUP.Items.Add("C");
            CBO_GROUP.Items.Add("D");

            opt_on.Checked = true;
            txt_place.Text = "1";

        }

        public override void Form_Ref() {

            string SMESG;
            int lRow;
            //定义一个变量标记，用来控制颜色显示
            int iColor = 0;
            int sord_cnt;
            string sHtm_Meth;
            string sIncarno;

            string sEXCEPTION;
            string sEXCEPTIONFH;

            p_Ref(1, 1, true, true);
            
            unlockSpread(ss1);

            for (lRow = 1; lRow <= ss1.ActiveSheet.RowCount; lRow++) {
                //取母板号，初始值为空，把颜色标记置为1
                if (mOplate_No == "") {
                    iColor = 1;
                } else {
                    //母板号不为空时，检查与上一母板号是否为相同母板号
                    if (ss1.ActiveSheet.Cells[lRow - 1, SS1_MOTHER_NO].Text != mOplate_No) {
                        //如果是不同母板号，而且颜色标记为1，那么颜色标记改为2，表示改变颜色
                        if (iColor == 1) {
                            iColor = 2;
                            //如果母板号相同，那么颜色标记还为1，表示颜色不变
                        } else {
                            iColor = 1;
                        }
                    }
                }
                //用1表示颜色置为浅灰色，用2表示颜色置为白色
                //每次循环结束，如果iColor为1，则颜色为浅灰色，否则颜色为白色
                if (iColor == 1) {
                    //取样颜色改变，如果为Y表示取样，则该行字体颜色变红色
                    if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Red, ColorTranslator.FromHtml("#e0e0e0"));

                        //浅灰色
                    } else {
                        //浅灰色
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, ColorTranslator.FromHtml("#e0e0e0"));
                    }
                } else {
                    //取样颜色改变，如果为Y表示取样，则该行字体颜色变红色
                    if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLAN_SMP].Text == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Red, ColorTranslator.FromHtml("#ffffff"));
                        //白
                    } else {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, ColorTranslator.FromHtml("#ffffff"));
                        //白
                    }
                }
                //把值还原为for循环中母板号的取值
                mOplate_No = ss1.ActiveSheet.Cells[lRow - 1, SS1_MOTHER_NO].Text;
                sord_cnt = Convert.ToInt32(ss1.ActiveSheet.Cells[lRow - 1, SS1_ORD_CNT].Text);

                if (sord_cnt > 1) {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP1.BackColor);
                }

                sIncarno = ss1.ActiveSheet.Cells[lRow - 1, SS1_IN_CAR_NO].Text;
                if (txt_place.Text == "2") {
                    if (sIncarno == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP4.BackColor);
                    }
                } else {
                    if (sIncarno != "") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP4.BackColor);
                    }
                }

                sEXCEPTION = ss1.ActiveSheet.Cells[lRow - 1, SS1_MILL_EXCEPTION].Text;
                sEXCEPTIONFH = ss1.ActiveSheet.Cells[lRow - 1, SS1_MILL_EXCEPTION_FH].Text;

                if (sEXCEPTION == "B" | sEXCEPTION == "C" | sEXCEPTIONFH == "B" | sEXCEPTIONFH == "C") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP5.BackColor);
                }

                //热处理指示蓝色显示
                sHtm_Meth = ss1.ActiveSheet.Cells[lRow - 1, SS1_HTM_METH].Text;
                if (sHtm_Meth.Substring(0, 1) == "N" & sHtm_Meth.Substring(0, 1) != "/") {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, ColorTranslator.FromHtml("#0000ff"));
                }

            }

            lockSpread(ss1);
            ss1.ActiveSheet.Columns[0].Locked = false;
            ss1.ActiveSheet.Columns[SS1_SUSERID].Locked = false;
        }

        public override void Form_Pro() {
            p_Pro(0, 1, true, true);
        }

        public override bool Form_Cls() {

            base.Form_Cls();
            opt_on.Checked = true;
            txt_place.Text = "1";
            CBO_CAR_NO.Text = "";
            return true;
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



        private void ss1_CellClick(object sender, CellClickEventArgs e) {
            if (e.RowHeader) return;
            if (ss1.ActiveSheet.RowCount <= 0) return;
            TXT_MAT_NO.Text = ss1.ActiveSheet.Cells[e.Row, 2].Text;
            //if (e.RowHeader) return;
            p_Ref(2, 2, true, true);
            TXT_MAT_NO.Text = "";
        }

        private void opt_on_CheckedChanged(object sender, EventArgs e)
        {
            if (!opt_on.Checked) return;
            opt_on_Clk();
        }

        private void opt_trk_CheckedChanged(object sender, EventArgs e)
        {
            if (!opt_trk.Checked) return;
            opt_trk_Clk();
        }

        private void CBO_CAR_NO_TextChanged(object sender, EventArgs e)
        {
            CBO_CAR_NO_Clk();
        }

    }
}
