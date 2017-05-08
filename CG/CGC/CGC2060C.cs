﻿using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            矫直作业实绩查询及修改界面                               
///-- 程序ID            CGC2060C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.05.05                                                
///-- 处理描述          矫直作业实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.05.05        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG {
    public partial class CGC2060C: CommonClass.FORMBASE {
        public CGC2060C() {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();

        const int SS1_URGNT_FL = 14;
        const int SS1_IMP_CONT = 15;
        const int SS1_FLAG = 16;
        const int SS1_EXPORT = 17;
        const int SS1_MILL_NO = 0;



        protected override void p_SubFormInit() {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧件号",txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间",txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
            p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
            p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
            p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
            p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
            p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
            p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_MOTHER_PLATE_LEN6, "IR", "", "", "", imcseq, ""); //39
            p_SetMc(SDB_MOTHER_SCH_LEN6, "R", "", "", "", imcseq, ""); //40
            p_SetMc(txt_Shift, "IR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_Group, "IR", "", "", "", imcseq, ""); //42
            p_SetMc(txt_Emp, "IR", "", "", "", imcseq, ""); //43
            p_SetMc(txt_pdt_inf, "R", "", "", "", imcseq, ""); //44
            p_SetMc(TXT_SEQ, "R", "", "", "", imcseq, ""); //45

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("切割实绩开始时间", txt_RstFormDate, "PN", "", "", "", "", imcseq);
            p_SetMc("切割实绩结束时间", txt_RstToDate, "PN", "", "", "", "", imcseq);

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("轧件号",txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间",txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
            p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
            p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
            p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
            p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
            p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
            p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_MOTHER_PLATE_LEN6, "IR", "", "", "", imcseq, ""); //39
            p_SetMc(SDB_MOTHER_SCH_LEN6, "R", "", "", "", imcseq, ""); //40
            p_SetMc(txt_Shift, "IR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_Group, "IR", "", "", "", imcseq, ""); //42
            p_SetMc(txt_Emp, "IR", "", "", "", imcseq, ""); //43


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("轧件号", "E", "12", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("钢板不平度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("测量长度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("钢板不平度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("测量长度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("轧制规格", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("切边代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("UST", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("母板块", "N", "12", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("产品块", "N", "12", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //19
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //20
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //21
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //22
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //23

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("轧件号", "E", "12", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("矫直时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("轧制规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("入口", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //4
            p_SetSc("出口", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //5
            p_SetSc("前", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("后", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("矫直力", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //8
            p_SetSc("矫直速度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("出口辊高度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //13

            iheadrow = 0;
            p_spanSpread("矫直机辊缝", 4, 5, iscseq, iheadrow, 1);
            p_spanSpread("矫直温度", 6, 7, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("炉座号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //3

        }

        private void CGC2020C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGC2020NC";

            Form_Define();

            Tab1.SelectedIndex = 0;

            Form_Ref();

            txt_Shift.Text = Gf_ShiftSet3("");
            txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
            txt_Emp.Text = GeneralCommon.sUserID;

            unlockSpread(ss1);
            unlockSpread(ss1);
            unlockSpread(ss2);
            unlockSpread(ss3);
        }

        public override bool Form_Cls() {
            base.Form_Cls();
            Check1.Checked = false;
            CHK_B.Checked = false;
            CHK_C.Checked = false;

            TXT_EXCEPTION.Text = "";
            return true;
        }

        public override void Form_Ref() {
            int iRow;
            int iCol;
            string sUrgnt_Fl;
            string simpcont;
            string sFlag;
            string sexport;

            if (Tab1.SelectedIndex == 0) {
                p_Ref(0, 1, true, false);
                p_Ref(0, 3, true, false);
                if (ss1.ActiveSheet.RowCount <= 0) return;
                if (ss1.ActiveSheet.Cells[0, 0].Text.ToString() != "") {
                    ss1_DblClk(0, 0);
                }
                //紧急订单绿色显示 add by liqian 2012-08-15
                {
                    for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++) {

                        sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text.ToString().Trim();
                        simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text.ToString().Trim();

                        if (sUrgnt_Fl == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        if (simpcont == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP4.BackColor);
                        }
                        //是否定制配送
                        sFlag = ss1.ActiveSheet.Cells[iRow - 1, SS1_FLAG].Text.ToString().Trim();
                        if (sFlag == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_MILL_NO, SS1_MILL_NO, iRow - 1, iRow - 1, SSP5.BackColor, Color.White);

                        }
                        //是否出口订单
                        sexport = ss1.ActiveSheet.Cells[iRow - 1, SS1_EXPORT].Text.ToString().Trim();
                        if (sexport == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_MILL_NO, SS1_MILL_NO, iRow - 1, iRow - 1, SSP1.BackColor, Color.White);

                        }
                    }
                }
            } else if (Tab1.SelectedIndex == 1) {
                p_Ref(2, 2, true, false);
            }

        }

        public override void Form_Pro() {

            String SMESG;

            if (!Gp_DateCheck(txt_CutDate.Text, "")) {
                SMESG = " 请正确输入矫直时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            p_Pro(1, 0, true, true);
            Form_Ref();
            txt_CutDate.Text = "";
        }

        private void ss1_DblClk(int col, int row) {
            if (ss1.ActiveSheet.RowCount > 0) {
                txt_RollingNo.Text = ss1.ActiveSheet.Cells[row, 0].Text.ToString();
                if (txt_RollingNo.Text.Trim() != "") {
                    p_Ref(1, 0, true, false);
                    p_Ref(2, 1, true, false);
                }

                if (txt_Shift.Text == "") {
                    txt_Shift.Text = Gf_ShiftSet3("");
                    txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
                    txt_Emp.Text = GeneralCommon.sUserID;
                }

            }

        }


        private void ss2_DblClk(int col, int row) {
            if (ss2.ActiveSheet.RowCount > 0) {
                txt_RollingNo.Text = ss2.ActiveSheet.Cells[row, 0].Text.ToString();
                if (txt_RollingNo.Text.Trim() != "") {
                    p_Ref(1, 0, true, false);
                    //Call Gf_Sp_Refer(M_CN1, sc2, Mc2, Mc2("nControl"), Mc2("mControl"))
                }
            }
        }

        private void tab1_Clk() {
            if (Tab1.SelectedIndex == 1) {
                txt_Shift.Text = Gf_ShiftSet3("");
                if (txt_Shift.Text == "1") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "000001";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081459";
                } else if (txt_Shift.Text == "2") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081500";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "155959";
                } else if (txt_Shift.Text == "3") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "160000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "235959";
                }
            }
        }


        private void TXT_HL_WORK_DAT_DblClk() {
            txt_CutDate.Text = Gf_DTSet("", "X");

        }

        private void txt_RstFormDate_DblClk() {
            txt_RstFormDate.Text = Gf_DTSet("", "X");
            txt_RstToDate.Text = Gf_DTSet("", "X");
        }

        private void CHK_A_Clk() {
            if (Check1.Checked) {
                TXT_EXCEPTION.Text = "A";
                CHK_B.Checked = false;
                CHK_C.Checked = false;
                Check1.ForeColor = Color.Red;
                CHK_B.ForeColor = Color.Black;
                CHK_C.ForeColor = Color.Black;
            }
            if (!Check1.Checked & !CHK_B.Checked & !CHK_C.Checked) {
                Check1.ForeColor = Color.Black;
                CHK_B.ForeColor = Color.Black;
                CHK_C.ForeColor = Color.Black;
                TXT_EXCEPTION.Text = "";
            }
        }

        private void CHK_B_Clk() {
            if (CHK_B.Checked) {
                TXT_EXCEPTION.Text = "B";
                Check1.Checked = false;
                CHK_C.Checked = false;
                CHK_B.ForeColor = Color.Red;
                Check1.ForeColor = Color.Black;
                CHK_C.ForeColor = Color.Black;
            }
            if (!Check1.Checked & !CHK_B.Checked & !CHK_C.Checked) {
                Check1.ForeColor = Color.Black;
                CHK_B.ForeColor = Color.Black;
                CHK_C.ForeColor = Color.Black;
                TXT_EXCEPTION.Text = "";
            }
        }

        private void CHK_C_Clk() {
            if (CHK_C.Checked) {
                TXT_EXCEPTION.Text = "C";
                Check1.Checked = false;
                CHK_B.Checked = false;
                CHK_C.ForeColor = Color.Red;
                Check1.ForeColor = Color.Black;
                CHK_B.ForeColor = Color.Black;
            }
            if (!Check1.Checked & !CHK_B.Checked & !CHK_C.Checked) {
                Check1.ForeColor = Color.Black;
                CHK_B.ForeColor = Color.Black;
                CHK_C.ForeColor = Color.Black;
                TXT_EXCEPTION.Text = "";
            }
        }

        #
        region 公共方法

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

        #
        endregion

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e) {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e) {
            ss2_DblClk(e.Column, e.Row);
        }

        private void Tab1_SelectedIndexChanged(object sender, EventArgs e) {
            tab1_Clk();
        }

        private void TXT_HL_WORK_DAT_DoubleClick(object sender, EventArgs e) {
            TXT_HL_WORK_DAT_DblClk();
        }

        private void txt_RstFormDate_DoubleClick(object sender, EventArgs e) {
            txt_RstFormDate_DblClk();
        }

        private void CHK_A_CheckedChanged(object sender, EventArgs e) {
            CHK_A_Clk();
        }

        private void CHK_B_CheckedChanged(object sender, EventArgs e) {
            CHK_B_Clk();
        }

        private void CHK_C_CheckedChanged(object sender, EventArgs e) {
            CHK_C_Clk();
        }

    }
}