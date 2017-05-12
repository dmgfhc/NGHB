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
///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          中板作业管理                                                 
///-- 程序名            表面检查实绩查询及修改_CGD2050C                                
///-- 程序ID            CGD2050C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.05.11                                                
///-- 处理描述          表面检查实绩查询及修改_CGD2050C                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.05.11        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace CG {
    public partial class CGD2050C: CommonClass.FORMBASE {
        public CGD2050C() {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        string sCheck = "";
        string sQuery;

        const int SS1_PLATE_NO = 0;
        const int SS1_IMP_CONT = 23;
        const int SS1_FLAG = 24;
        const int SS1_EXPORT = 25;




        protected override void p_SubFormInit() {

            int imcseq;

            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("钢板号", TXT_PLATE_NO, "PI", "", "", "", "", imcseq); //0
            p_SetMc("作业线", txt_PrcLine, "I", "", "", "", "", imcseq); //1
            //p_SetMc(SDT_PROD_DATE, "P", "", "", "", imcseq, ""); //2
            //p_SetMc(SDT_PROD_TO_DATE, "P", "", "", "", imcseq, ""); //3
            //p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, ""); //4
            //p_SetMc(txt_stdspec_chg_ref, "P", "", "", "", imcseq, ""); //5
            //p_SetMc(SDB_THK_REF, "P", "", "", "", imcseq, ""); //6
            //p_SetMc(SDB_WID_REF, "P", "", "", "", imcseq, ""); //7
            p_SetMc(TXT_UST_FLAG, "RL", "", "", "", imcseq, ""); //8
            p_SetMc(TXT_PROC_FLAG, "RL", "", "", "", imcseq, ""); //9
            p_SetMc(TXT_APLY_ENDUSE_CD, "RL", "", "", "", imcseq, ""); //10
            p_SetMc(TXT_STLGRD, "RL", "", "", "", imcseq, ""); //11
            p_SetMc(TXT_INSP_FLAW3, "IR", "", "", "", imcseq, ""); //12
            p_SetMc(TXT_INSP_FLAW4, "IR", "", "", "", imcseq, ""); //13
            p_SetMc(TXT_INSP_FLAW5, "IR", "", "", "", imcseq, ""); //14
            p_SetMc(TXT_INSP_PART3, "IRL", "", "", "", imcseq, ""); //15
            p_SetMc(TXT_INSP_PART4, "IRL", "", "", "", imcseq, ""); //16
            p_SetMc(TXT_INSP_PART5, "IRL", "", "", "", imcseq, ""); //17
            p_SetMc(SDB_INSP_LTH3, "IR", "", "", "", imcseq, ""); //18
            p_SetMc(SDB_INSP_LTH4, "IR", "", "", "", imcseq, ""); //19
            p_SetMc(SDB_INSP_LTH5, "IR", "", "", "", imcseq, ""); //20
            p_SetMc(TXT_INSP_FLAW0, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(TXT_INSP_FLAW1, "IR", "", "", "", imcseq, ""); //22
            p_SetMc(TXT_INSP_FLAW2, "IR", "", "", "", imcseq, ""); //23
            p_SetMc(TXT_INSP_PART0, "IRL", "", "", "", imcseq, ""); //24
            p_SetMc(TXT_INSP_PART1, "IRL", "", "", "", imcseq, ""); //25
            p_SetMc(TXT_INSP_PART2, "IRL", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_INSP_LTH0, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_INSP_LTH1, "IR", "", "", "", imcseq, ""); //28
            p_SetMc(SDB_INSP_LTH2, "IR", "", "", "", imcseq, ""); //29
            p_SetMc("实绩厚度", SDB_THK, "NIR", "", "", "", "", imcseq); //30
            p_SetMc(SDB_INSP_THK_MX, "RL", "", "", "", imcseq, ""); //31
            p_SetMc(SDB_INSP_THK_MN, "RL", "", "", "", imcseq, ""); //32
            p_SetMc("实绩宽度", SDB_WID, "NIR", "", "", "", "", imcseq); //33
            p_SetMc(SDB_INSP_WID_MX, "RL", "", "", "", imcseq, ""); //34
            p_SetMc(SDB_INSP_WID_MN, "RL", "", "", "", imcseq, ""); //35
            p_SetMc("实绩长度", SDB_LEN, "NIR", "", "", "", "", imcseq); //36
            //p_SetMc(SDB_INSP_LEN_MX, "RL", "", "", "", imcseq, ""); //37
            //p_SetMc(SDB_INSP_LEN_MN, "RL", "", "", "", imcseq, ""); //38
            //p_SetMc(SDB_WGT_ORD, "RL", "", "", "", imcseq, ""); //39
            //p_SetMc("实绩重量", SDB_WGT, "NIR", "", "", "", "", imcseq); //40
            //p_SetMc(SDB_PWGT_MX, "RL", "", "", "", imcseq, ""); //41
            //p_SetMc(SDB_PWGT_MN, "RL", "", "", "", imcseq, ""); //42
            //p_SetMc(TXT_INSP_THK_GRD, "IRL", "", "", "", imcseq, ""); //43
            //p_SetMc(TXT_INSP_WID_GRD, "IRL", "", "", "", imcseq, ""); //44
            //p_SetMc(TXT_INSP_LEN_GRD, "IRL", "", "", "", imcseq, ""); //45
            //p_SetMc(TXT_INSP_WGT_GRD, "IRL", "", "", "", imcseq, ""); //46
            //p_SetMc(TXT_SURF_GRD, "IR", "", "", "", imcseq, ""); //47
            //p_SetMc(TXT_INSP_MAIN_GRD, "IR", "", "", "", imcseq, ""); //48
            //p_SetMc(txtGas, "IR", "", "", "", imcseq, ""); //49
            //p_SetMc(txtGrid, "IR", "", "", "", imcseq, ""); //50
            //p_SetMc(TXT_CL, "IR", "", "", "", imcseq, ""); //51
            //p_SetMc("头部检验工", TXT_INSP_MAN, "NIR", "", "", "", "", imcseq); //52
            //p_SetMc(TXT_INSP_MAN_TAIL, "IR", "", "", "", imcseq, ""); //53
            //p_SetMc("检查时间", TXT_INSP_OCCR_TIME, "NIR", "", "", "", "", imcseq); //54
            //p_SetMc(SDB_ORD_WID, "R", "", "", "", imcseq, ""); //55
            //p_SetMc(SDB_ORD_THK, "R", "", "", "", imcseq, ""); //56
            //p_SetMc(SDB_ORD_LEN, "R", "", "", "", imcseq, ""); //57
            //p_SetMc(TXT_GRID_EMP_CD, "IR", "", "", "", imcseq, ""); //58
            //p_SetMc(TXT_GRID_TIME, "IR", "", "", "", imcseq, ""); //59
            //p_SetMc(TXT_TOP_GRID_GRD, "IRL", "", "", "", imcseq, ""); //60
            //p_SetMc(SDB_TOP_GRID_YRD, "IR", "", "", "", imcseq, ""); //61
            //p_SetMc(SDB_TOP_GRID_DEEP, "IR", "", "", "", imcseq, ""); //62
            //p_SetMc(TXT_BOT_GRID_GRD, "IRL", "", "", "", imcseq, ""); //63
            //p_SetMc(SDB_BOT_GRID_YRD, "IR", "", "", "", imcseq, ""); //64
            //p_SetMc(SDB_BOT_GRID_DEEP, "IR", "", "", "", imcseq, ""); //65
            //p_SetMc(txt_stdspec, "R", "", "", "", imcseq, ""); //66
            //p_SetMc(txt_stdspec_name, "R", "", "", "", imcseq, ""); //67
            //p_SetMc(txt_stdspec_chg, "I", "", "", "", imcseq, ""); //68
            //p_SetMc(txt_stdspec_name_chg, "L", "", "", "", imcseq, ""); //69
            //p_SetMc(txt_Scrap_code, "IR", "", "", "", imcseq, ""); //70
            //p_SetMc(txt_Scrap_name, "L", "", "", "", imcseq, ""); //71
            //p_SetMc(SDB_Mn, "R", "", "", "", imcseq, ""); //72
            //p_SetMc(TXT_PROC_CD, "R", "", "", "", imcseq, ""); //73
            //p_SetMc(SDB_THK_R, "IR", "", "", "", imcseq, ""); //74
            //p_SetMc(SDB_WID_R, "IR", "", "", "", imcseq, ""); //75
            //p_SetMc(SDB_LEN_R, "IR", "", "", "", imcseq, ""); //76
            //p_SetMc(TXT_EMP_CD1, "IR", "", "", "", imcseq, ""); //77
            //p_SetMc(TXT_WAVE, "IR", "", "", "", imcseq, ""); //78
            //p_SetMc(TXT_VERT_DEG, "IR", "", "", "", imcseq, ""); //79
            //p_SetMc(TXT_RECT_DEG, "IR", "", "", "", imcseq, ""); //80
            //p_SetMc(SDB_INSP_DIAGONAL1, "IR", "", "", "", imcseq, ""); //81
            //p_SetMc(SDB_INSP_DIAGONAL2, "IR", "", "", "", imcseq, ""); //82
            //p_SetMc("定尺", TXT_SIZE_KND, "NIR", "", "", "", "", imcseq); //83
            //p_SetMc(TXT_WAVE1, "IR", "", "", "", imcseq, ""); //84
            //p_SetMc(txt_Color_code, "IR", "", "", "", imcseq, ""); //85
            //p_SetMc(SDB_HD1, "IR", "", "", "", imcseq, ""); //86
            //p_SetMc(SDB_HD2, "IR", "", "", "", imcseq, ""); //87
            //p_SetMc(SDB_HD3, "IR", "", "", "", imcseq, ""); //88
            //p_SetMc(SDB_HD4, "IR", "", "", "", imcseq, ""); //89
            //p_SetMc(SDB_HD5, "IR", "", "", "", imcseq, ""); //90
            //p_SetMc(SDB_HD6, "IR", "", "", "", imcseq, ""); //91
            //p_SetMc(CHK_FLAW_YN, "I", "", "", "", imcseq, ""); //92
            //p_SetMc(TXT_EMP_CD5, "I", "", "", "", imcseq, ""); //93
            //p_SetMc(COM_PF, "I", "", "", "", imcseq, ""); //94

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("钢板号", TXT_PLATE_NO, "PI", "", "", "", "", imcseq); //0
            p_SetMc("作业线", txt_PrcLine, "PI", "", "", "", "", imcseq); //1
            p_SetMc(SDT_PROD_DATE, "P", "", "", "", imcseq, ""); //2
            p_SetMc(SDT_PROD_TO_DATE, "P", "", "", "", imcseq, ""); //3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, ""); //4
            p_SetMc(txt_stdspec_chg_ref, "P", "", "", "", imcseq, ""); //5
            p_SetMc(SDB_THK_REF, "P", "", "", "", imcseq, ""); //6
            p_SetMc(SDB_WID_REF, "P", "", "", "", imcseq, ""); //7


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L"); //0 
            p_SetSc("生产日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //1 
            p_SetSc("班次", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //2 
            p_SetSc("分段号", "E", "30", "L", "", "", "", iscseq, iheadrow, "M"); //3 
            p_SetSc("厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R"); //4 
            p_SetSc("宽度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R"); //5 
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R"); //6 
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R"); //7 
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //8 
            p_SetSc("取样", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //9 
            p_SetSc("取样长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("热处理/实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("UST/实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("切割/实绩", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("矫直/实绩", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("外观等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("检验工", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("订单厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("订单宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //19
            p_SetSc("订单长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //20
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //21
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //29

        }


        private void cbo_ResonDesc_Clk() {

            if (cbo_ResonDesc.Text != "") {
                txt_ResonCd.Text = cbo_ResonDesc.Text.Substring(0, 0);
            }
        }


        private void CHK_CL_FL_Clk() {
            if (CHK_CL_FL.Checked) {
                TXT_CL.Text = "Y";
            } else {
                TXT_CL.Text = "N";
            }
        }

        private void chkCl_Clk() {
            if (chkCl.Checked) {
                txtCl.Text = "Y";
                chkCl.ForeColor = Color.Red;
                //red
            } else {
                txtCl.Text = "N";
                chkCl.ForeColor = Color.Black;
                //black
            }
        }

        private void chkGas_Clk() {
            if (chkGas.Checked) {
                txtGas.Text = "Y";
                chkGas.ForeColor = Color.Red;
                //red
            } else {
                txtGas.Text = "N";
                chkGas.ForeColor = Color.Black;
                //red
            }
        }

        private void chkGrid_Clk() {
            if (chkGrid.Checked) {
                txtGrid.Text = "Y";
                chkGrid.ForeColor = Color.Red;
                //red
            } else {
                txtGrid.Text = "N";
                chkGrid.ForeColor = Color.Black;
                //red
            }
        }

        //该功能已经不存在暂时不考虑实现，如需实现请参考VB代码
        //Private Sub cmd_Off_Click()

        private void CGD2050C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGD2050NC";
            Form_Define();
            if (TXT_PLATE_NO.Text != "") {
                Form_Ref();
            }
            opt_LineFlag0.Checked = true;
            cbo_ResonDesc.Items.Add("1:设备异常");
            cbo_ResonDesc.Items.Add("2:线过负荷");
            cbo_ResonDesc.Items.Add("3:产品异常");
            if (base.sAuthority.Substring(0, 3) == "111") {
                cmd_Off.Enabled = true;
            } else {
                cmd_Off.Enabled = false;
            }
            CHK_CL_FL.Checked = false;
            COM_PF.Enabled = false;
        }

        public override bool Form_Cls() {
            TXT_PLATE_NO.Text = "";
            TXT_INSP_MAN.Text = "";
            TXT_EMP_CD1.Text = GeneralCommon.sUserID;
            TXT_INSP_FLAW_NAME0.Text = "";
            TXT_INSP_FLAW_NAME1.Text = "";
            TXT_INSP_FLAW_NAME2.Text = "";
            TXT_INSP_FLAW_NAME3.Text = "";
            TXT_INSP_FLAW_NAME4.Text = "";
            CHK_CL_FL.Checked = false;
            CHK_FLAW_YN.Checked = false;
            return base.Form_Cls();
        }

        public override void Form_Ref() {
            int i;
            //
            //    Call Form_Cls
            string simpcont;
            int iCount;
            string sFlag;
            string sexport;
            Type CHK_PART;

            unlockSpread(ss1);

            p_Ref(1, 0, true, false);

            //p_Ref(2, 1, true, false);

            //if (ss1.ActiveSheet.RowCount > 0)
            //{

            //    TXT_PLATE_NO.Text = ss1.ActiveSheet.Cells[0, 0].Text;
            //    TXT_PLATE_NO1.Text = ss1.ActiveSheet.Cells[0, 0].Text;

            //    //for (i = 0; i <= 17; i++) {
            //    //CHK_PART = Type.GetType("CHK_PART"+i);
            //    //PropertyInfo CHK_PART_TEXT =   CHK_PART.GetProperty("Text");
            //    //CHK_PART_TEXT.SetValue(obj, "zhx", null);
            //    //}
            //}

            //if (TXT_PLATE_NO.Text.Length == 14)
            //{
            //    if (p_Ref(1, 0, true, false))
            //    {

            //        if (TXT_SURF_GRD.Text == "Y")
            //        {
            //            opt_CHK_SUR_GRD0.Checked = true;
            //        }
            //        else
            //        {
            //            opt_CHK_SUR_GRD1.Checked = true;
            //        }


            //        if (TXT_INSP_MAIN_GRD.Text.Length == 1)
            //        {
            //            if (TXT_INSP_MAIN_GRD.Text == "7")
            //            {
            //                opt_CHK_PRD_GRD5.Checked = true;
            //            }
            //            else if (TXT_INSP_MAIN_GRD.Text == "5")
            //            {
            //                opt_CHK_PRD_GRD4.Checked = true;
            //            }
            //            else if (TXT_INSP_MAIN_GRD.Text == "4")
            //            {
            //                opt_CHK_PRD_GRD3.Checked = true;
            //            }
            //            else if (TXT_INSP_MAIN_GRD.Text == "3")
            //            {
            //                opt_CHK_PRD_GRD2.Checked = true;
            //            }
            //            else if (TXT_INSP_MAIN_GRD.Text == "2")
            //            {
            //                opt_CHK_PRD_GRD1.Checked = true;
            //            }
            //            else if (TXT_INSP_MAIN_GRD.Text == "1")
            //            {
            //                opt_CHK_PRD_GRD0.Checked = true;
            //            }
            //        }
            //        if (TXT_INSP_OCCR_TIME.Text == "")
            //        {
            //            TXT_INSP_OCCR_TIME.Text = Gf_DTSet("", "X");
            //        }
            //        //TXT_INSP_MAN = sUserID
            //        //ADD BY LIQIAN AT 20120322

            //        TXT_EMP_CD1.Text = GeneralCommon.sUserID;

            //        //Call Display_Data_Edit
            //    }
            //}

            //{
            //    for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            //    {

            //        simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();
            //        sFlag = ss1.ActiveSheet.Cells[iCount - 1, SS1_FLAG].Text.Trim();
            //        sexport = ss1.ActiveSheet.Cells[iCount - 1, SS1_EXPORT].Text.Trim();
            //        if (simpcont == "Y")
            //        {
            //            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
            //            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
            //        }

            //        //是否定制配送
            //        if (sFlag == "Y")
            //        {
            //            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP5.BackColor, Color.White);
            //        }
            //        //是否出口订单

            //        if (sexport == "Y")
            //        {
            //            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP6.BackColor, Color.White);
            //        }
            //    }
            //}

            //lockSpread(ss1);

            //CHK_CL_FL.Checked = false;

        }

        public override void Form_Pro() {
            string SMESG;
            int iCount;

            if (TXT_INSP_MAIN_GRD.Text.Trim() != "4") {
                if (TXT_SURF_GRD.Text.Trim() == "") {
                    SMESG = " 请输入表面判定 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }


            if (!Gp_DateCheck(TXT_INSP_OCCR_TIME.Text, "")) {
                SMESG = " 请正确输入检查时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            if (CHK_GRID_FLAG.Checked) {
                if (!Gp_DateCheck(TXT_GRID_TIME.Text, "")) {
                    SMESG = " 请正确输入修磨时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
                if (TXT_GRID_EMP_CD.Text.Trim() == "") {
                    TXT_GRID_EMP_CD.Text = GeneralCommon.sUserID;
                }
                if (TXT_TOP_GRID_GRD.Text == "") {
                    SMESG = " 请正确输入上表面修磨后判定 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
                if (TXT_BOT_GRID_GRD.Text == "") {
                    SMESG = " 请正确输入下表面修磨后判定 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }


            //TXT_INSP_MAN.Text = sUserID
            //ADD BY LIQIAN AT 20120322
            TXT_EMP_CD1.Text = GeneralCommon.sUserID;
            if (TXT_INSP_MAN.Text == "") {
                SMESG = " 请选择检验人员！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }
            p_Pro(1, 0, true, true);

            CHK_CL_FL.Checked = false;
        }


        private void opt_CHK_PRD_GRD_Clk() {
            if (opt_CHK_PRD_GRD0.Checked) {
                TXT_INSP_MAIN_GRD.Text = "1";
                opt_CHK_PRD_GRD0.ForeColor = Color.Red;
                //red
                opt_CHK_PRD_GRD1.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD2.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD3.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD4.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD5.ForeColor = Color.Black;
                //black
                COM_PF.Enabled = false;
                COM_PF.Text = "";
            } else if (opt_CHK_PRD_GRD1.Checked) {
                TXT_INSP_MAIN_GRD.Text = "2";
                opt_CHK_PRD_GRD0.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD1.ForeColor = Color.Red;
                //red
                opt_CHK_PRD_GRD2.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD3.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD4.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD5.ForeColor = Color.Black;
                //black
                COM_PF.Enabled = false;
                COM_PF.Text = "";
            } else if (opt_CHK_PRD_GRD2.Checked) {
                TXT_INSP_MAIN_GRD.Text = "3";
                opt_CHK_PRD_GRD0.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD1.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD2.ForeColor = Color.Red;
                //red
                opt_CHK_PRD_GRD3.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD4.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD5.ForeColor = Color.Black;
                //black
                COM_PF.Enabled = false;
                COM_PF.Text = "";
            } else if (opt_CHK_PRD_GRD3.Checked) {
                TXT_INSP_MAIN_GRD.Text = "4";
                opt_CHK_PRD_GRD0.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD1.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD2.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD3.ForeColor = Color.Red;
                //red
                opt_CHK_PRD_GRD4.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD5.ForeColor = Color.Black;
                //black
                COM_PF.Enabled = false;
                COM_PF.Text = "";
            } else if (opt_CHK_PRD_GRD4.Checked) {
                TXT_INSP_MAIN_GRD.Text = "5";
                opt_CHK_PRD_GRD0.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD1.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD2.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD3.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD4.ForeColor = Color.Red;
                //red
                opt_CHK_PRD_GRD5.ForeColor = Color.Black;
                //black
                COM_PF.Enabled = false;
                COM_PF.Text = "";
            } else if (opt_CHK_PRD_GRD5.Checked) {
                TXT_INSP_MAIN_GRD.Text = "7";
                opt_CHK_PRD_GRD0.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD1.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD2.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD3.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD4.ForeColor = Color.Black;
                //black
                opt_CHK_PRD_GRD5.ForeColor = Color.Red;
                //red
                txt_Scrap_code.Enabled = true;
                COM_PF.Enabled = true;
            }
        }

        private void opt_CHK_SUR_GRD_Clk() {
            if (opt_CHK_SUR_GRD0.Checked) {
                opt_CHK_SUR_GRD0.ForeColor = Color.Red;
                //red
                opt_CHK_SUR_GRD1.ForeColor = Color.Black;
                //black
                TXT_SURF_GRD.Text = "Y";
            } else {
                TXT_SURF_GRD.Text = "N";
                opt_CHK_SUR_GRD1.ForeColor = Color.Red;
                //red
                opt_CHK_SUR_GRD0.ForeColor = Color.Black;
                //black
            }
        }

        private void opt_LineFlag_Clk() {
            //    Call Form_Cls
            //    TXT_PLATE_NO = ""
            if (opt_LineFlag0.Checked) {
                txt_PrcLine.Text = "1";
                opt_LineFlag0.ForeColor = Color.Red;
                //red
                opt_LineFlag1.ForeColor = Color.Black;
                //black
                opt_LineFlag2.ForeColor = Color.Black;
                //black
                opt_LineFlag3.ForeColor = Color.Black;
                //black
            } else if (opt_LineFlag1.Checked) {
                txt_PrcLine.Text = "2";
                opt_LineFlag0.ForeColor = Color.Black;
                //black
                opt_LineFlag1.ForeColor = Color.Red;
                //red
                opt_LineFlag2.ForeColor = Color.Black;
                //black
                opt_LineFlag3.ForeColor = Color.Black;
                //black
            } else if (opt_LineFlag2.Checked) {
                txt_PrcLine.Text = "3";
                opt_LineFlag0.ForeColor = Color.Black;
                //black
                opt_LineFlag1.ForeColor = Color.Black;
                //black
                opt_LineFlag2.ForeColor = Color.Red;
                //red
                opt_LineFlag3.ForeColor = Color.Black;
                //black
            } else if (opt_LineFlag3.Checked) {
                txt_PrcLine.Text = "4";
                opt_LineFlag0.ForeColor = Color.Black;
                //black
                opt_LineFlag1.ForeColor = Color.Black;
                //black
                opt_LineFlag2.ForeColor = Color.Black;
                //black
                opt_LineFlag3.ForeColor = Color.Red;
                //red
            }
        }


        private void SDB_THK_Change() {
            PRD_WEIGHT_CALC();
        }

        private void SDB_WID_Change() {
            PRD_WEIGHT_CALC();
        }

        private void SDB_LEN_Change() {
            PRD_WEIGHT_CALC();
        }

        private void PRD_WEIGHT_CALC() {
            double dThk;
            double dWid;
            double dLen;

            dThk = SDB_THK.NumValue;
            dWid = SDB_WID.NumValue;
            dLen = SDB_LEN.NumValue;
            if (dThk > 0 & dWid > 0 & dLen > 0) {
                SDB_WGT.NumValue = Cal_Plate_Wgt("WGT", dThk, dWid, dLen);
            }

            Size_Grade_Edit();
        }


        private double Cal_Plate_Wgt(string sMode, double dThk, double dWid, double dLen) {

            double Plate_Wgt = 0;

            sQuery = "SELECT  Gf_Cal_Plate_Wgt('" + sMode + "'";
            sQuery = sQuery + ",'" + TXT_APLY_ENDUSE_CD.Text + "'";
            sQuery = sQuery + ",'" + TXT_STLGRD.Text + "'";
            sQuery = sQuery + "," + dThk;
            sQuery = sQuery + "," + dWid;
            sQuery = sQuery + "," + dLen;
            sQuery = sQuery + ",0 )";
            sQuery = sQuery + "FROM  DUAL";

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return Plate_Wgt;


            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        Plate_Wgt = Convert.ToDouble(AdoRs.Fields[0].Value);
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return Plate_Wgt;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return 0;
            }

        }

        private void SDT_PROD_DATE_DblClk() {
            SDT_PROD_DATE.Text = Gf_DTSet("D", "");
            SDT_PROD_TO_DATE.Text = Gf_DTSet("D", "");
        }
        private void SDT_PROD_TO_DATE_DblClk() {
            SDT_PROD_TO_DATE.Text = Gf_DTSet("D", "");
        }

        private void txt_Color_code_Change() {
            if (txt_Color_code.Text.Length == txt_Color_code.MaxLength) {
                txt_Color_name.Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "CG002", txt_Color_code.Text, 1);
            } else {
                txt_Color_name.Text = "";
            }
        }

        private void TXT_GRID_EMP_CD_DblClk() {
            TXT_GRID_EMP_CD.Text = GeneralCommon.sUserID;
        }

        private void TXT_GRID_TIME_DblClick() {
            TXT_GRID_TIME.Text = Gf_DTSet("", "X");
        }

        private void TXT_INSP_OCCR_TIME_DblClk() {
            TXT_INSP_OCCR_TIME.Text = Gf_DTSet("", "X");
        }

        private void CHK_TOP_GRD0_Clk() {

            if (sCheck != "") {
                return;
            }

            sCheck = "**";

            if (!CHK_TOP_GRD0.Checked) {
                if (!CHK_TOP_GRD1.Checked) {
                    TXT_TOP_GRID_GRD.Text = "";
                    CHK_TOP_GRD0.ForeColor = Color.Black;
                    CHK_TOP_GRD1.ForeColor = Color.Black;
                    sCheck = "";
                    return;
                }
            }

            if (CHK_TOP_GRD0.Checked) {
                CHK_TOP_GRD0.ForeColor = Color.Red;
                CHK_TOP_GRD0.Checked = true;

                CHK_TOP_GRD1.ForeColor = Color.Black;
                CHK_TOP_GRD1.Checked = false;

                TXT_TOP_GRID_GRD.Text = CHK_TOP_GRD0.Tag.ToString();
                sCheck = "";

            }
        }

        private void CHK_TOP_GRD1_Clk()
        {

            if (sCheck != "")
            {
                return;
            }

            sCheck = "**";

            if (!CHK_TOP_GRD0.Checked)
            {
                if (!CHK_TOP_GRD1.Checked)
                {
                    TXT_TOP_GRID_GRD.Text = "";
                    CHK_TOP_GRD0.ForeColor = Color.Black;
                    CHK_TOP_GRD1.ForeColor = Color.Black;
                    sCheck = "";
                    return;
                }
            }

            if (CHK_TOP_GRD1.Checked)
            {
                CHK_TOP_GRD1.ForeColor = Color.Red;
                CHK_TOP_GRD1.Checked = true;

                CHK_TOP_GRD0.ForeColor = Color.Black;
                CHK_TOP_GRD0.Checked = false;

                TXT_TOP_GRID_GRD.Text = CHK_TOP_GRD1.Tag.ToString();
                sCheck = "";

            }
        }

        private void CHK_BOT_GRD0_Clk() {

            if (sCheck != "")
                return;

            sCheck = "**";

            if (!CHK_BOT_GRD0.Checked) {
                if (!CHK_BOT_GRD1.Checked) {
                    TXT_BOT_GRID_GRD.Text = "";
                    CHK_BOT_GRD0.ForeColor = Color.Black;
                    CHK_BOT_GRD1.ForeColor = Color.Black;
                    sCheck = "";
                    return;
                }
            }

            if (CHK_BOT_GRD0.Checked) {
                CHK_BOT_GRD0.ForeColor = Color.Red;
                CHK_BOT_GRD0.Checked = true;

                CHK_BOT_GRD1.ForeColor = Color.Black;
                CHK_BOT_GRD1.Checked = false;

                TXT_BOT_GRID_GRD.Text = CHK_BOT_GRD0.Tag.ToString();
                sCheck = "";

            }

        }

        private void CHK_BOT_GRD1_Clk()
        {

            if (sCheck != "")
                return;

            sCheck = "**";

            if (!CHK_BOT_GRD0.Checked)
            {
                if (!CHK_BOT_GRD1.Checked)
                {
                    TXT_BOT_GRID_GRD.Text = "";
                    CHK_BOT_GRD0.ForeColor = Color.Black;
                    CHK_BOT_GRD1.ForeColor = Color.Black;
                    sCheck = "";
                    return;
                }
            }

            if (CHK_BOT_GRD1.Checked)
            {
                CHK_BOT_GRD1.ForeColor = Color.Red;
                CHK_BOT_GRD1.Checked = true;

                CHK_BOT_GRD0.ForeColor = Color.Black;
                CHK_BOT_GRD0.Checked = false;

                TXT_BOT_GRID_GRD.Text = CHK_BOT_GRD1.Tag.ToString();
                sCheck = "";
            }
           
        }

        private void CHK_GRID_FLAG_Click() {
            if (!CHK_GRID_FLAG.Checked) {
                CHK_TOP_GRD0.Enabled = false;
                CHK_TOP_GRD0.Checked = false;
                CHK_TOP_GRD1.Enabled = false;
                CHK_TOP_GRD1.Checked = false;
                CHK_BOT_GRD0.Enabled = false;
                CHK_BOT_GRD0.Checked = false;
                CHK_BOT_GRD1.Enabled = false;
                CHK_BOT_GRD1.Checked = false;
                SDB_TOP_GRID_YRD.Enabled = false;
                SDB_TOP_GRID_YRD.Text = "";
                SDB_BOT_GRID_YRD.Enabled = false;
                SDB_BOT_GRID_YRD.Text = "";
                SDB_TOP_GRID_DEEP.Enabled = false;
                SDB_TOP_GRID_DEEP.Text = "";
                SDB_BOT_GRID_DEEP.Enabled = false;
                SDB_BOT_GRID_DEEP.Text = "";
                TXT_GRID_EMP_CD.Enabled = false;
                TXT_GRID_EMP_CD.Text = "";
                TXT_GRID_TIME.Enabled = false;
                TXT_GRID_TIME.Text = "";

                //        CHK_NEXT_PRC(1).Enabled = True
            } else {
                CHK_TOP_GRD0.Enabled = true;
                CHK_TOP_GRD1.Enabled = true;
                CHK_BOT_GRD0.Enabled = true;
                CHK_BOT_GRD1.Enabled = true;
                SDB_TOP_GRID_YRD.Enabled = true;
                SDB_BOT_GRID_YRD.Enabled = true;
                SDB_TOP_GRID_DEEP.Enabled = true;
                SDB_BOT_GRID_DEEP.Enabled = true;
                TXT_GRID_EMP_CD.Enabled = true;
                TXT_GRID_TIME.Enabled = true;

                TXT_GRID_EMP_CD.Text = GeneralCommon.sUserID;
                TXT_GRID_TIME.Text = Gf_DTSet("", "X");

                CHK_TOP_GRD0.Checked = true;
                CHK_TOP_GRD0_Clk();
                CHK_BOT_GRD0.Checked = true;
                CHK_BOT_GRD0_Clk();
            }
        }

        private void Display_Data_Edit() {
            int iIndexChk;
            int iIndexStr;

            sCheck = "**";


            if (TXT_TOP_GRID_GRD.Text != "")
                CHK_GRID_FLAG.Checked = true;

            if (TXT_TOP_GRID_GRD.Text == "Y") {
                CHK_TOP_GRD0.Checked = true;
                CHK_TOP_GRD1.Checked = false;
            } else if (TXT_TOP_GRID_GRD.Text == "N") {
                CHK_TOP_GRD0.Checked = false;
                CHK_TOP_GRD1.Checked = true;
            }

            if (TXT_BOT_GRID_GRD.Text == "Y") {
                CHK_BOT_GRD0.Checked = true;
                CHK_BOT_GRD1.Checked = false;
            } else if (TXT_BOT_GRID_GRD.Text == "N") {
                CHK_BOT_GRD0.Checked = false;
                CHK_BOT_GRD1.Checked = true;
            }

            if (txtGas.Text == "Y") {
                chkGas.Checked = true;
            }
            if (txtGrid.Text == "Y") {
                chkGrid.Checked = true;
            }
            if (txtCl.Text == "Y") {
                chkCl.Checked = true;
            }

            if (TXT_INSP_MAIN_GRD.Text == "1") {
                opt_CHK_PRD_GRD0.Checked = true;
            } else if (TXT_INSP_MAIN_GRD.Text == "2") {
                opt_CHK_PRD_GRD1.Checked = true;
            } else if (TXT_INSP_MAIN_GRD.Text == "3") {
                opt_CHK_PRD_GRD2.Checked = true;
            } else if (TXT_INSP_MAIN_GRD.Text == "4") {
                opt_CHK_PRD_GRD3.Checked = true;
            } else if (TXT_INSP_MAIN_GRD.Text == "5") {
                opt_CHK_PRD_GRD4.Checked = true;
            } else if (TXT_INSP_MAIN_GRD.Text == "7") {
                opt_CHK_PRD_GRD5.Checked = true;
            }

            if (TXT_SURF_GRD.Text == "Y") {
                opt_CHK_SUR_GRD0.Checked = true;
            } else if (TXT_SURF_GRD.Text == "N") {
                opt_CHK_SUR_GRD1.Checked = true;
            }

            ///''''''ADD BY GUOLI AT 200712071330''''''''''
            if (opt_CHK_SUR_GRD0.Checked == true) {
                TXT_SURF_GRD.Text = "Y";
            } else if (opt_CHK_SUR_GRD1.Checked == true) {
                TXT_SURF_GRD.Text = "N";
            }
            ///''''''''''''''''''''''''''''''''''''''''''''

        }


        private void Size_Grade_Edit() {
            string sGradeFlag;

            sGradeFlag = "";

            if (TXT_PROC_FLAG.Text != "CGD")
                return;

            // THICK GRAND CHECK
            if (SDB_THK.NumValue >= SDB_ORD_THK.NumValue + SDB_INSP_THK_MN.NumValue & SDB_THK.NumValue <= SDB_ORD_THK.NumValue + SDB_INSP_THK_MX.NumValue) {
                TXT_INSP_THK_GRD.Text = "Y";
                SDB_THK.ForeColor = Color.Black;
            } else {
                TXT_INSP_THK_GRD.Text = "N";
                SDB_THK.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // WIDTH GRAND CHECK
            if (SDB_WID.NumValue >= SDB_ORD_WID.NumValue + SDB_INSP_WID_MN.NumValue & SDB_WID.NumValue <= SDB_ORD_WID.NumValue + SDB_INSP_WID_MX.NumValue) {
                TXT_INSP_WID_GRD.Text = "Y";
                SDB_WID.ForeColor = Color.Black;
            } else {
                TXT_INSP_WID_GRD.Text = "N";
                SDB_WID.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // LENGTH GRAND CHECK
            if (SDB_LEN.NumValue >= SDB_ORD_LEN.NumValue + SDB_INSP_LEN_MN.NumValue & SDB_LEN.NumValue <= SDB_ORD_LEN.NumValue + SDB_INSP_LEN_MX.NumValue) {
                TXT_INSP_LEN_GRD.Text = "Y";
                SDB_LEN.ForeColor = Color.Black;
            } else {
                TXT_INSP_LEN_GRD.Text = "N";
                SDB_LEN.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // WEIGHT GRAND CHECK
            if (SDB_WGT.NumValue >= SDB_WGT_ORD.NumValue + SDB_PWGT_MN.NumValue & SDB_WGT.NumValue <= SDB_WGT_ORD.NumValue + SDB_PWGT_MX.NumValue) {
                TXT_INSP_WGT_GRD.Text = "Y";
                SDB_WGT.ForeColor = Color.Black;
            } else {
                TXT_INSP_WGT_GRD.Text = "N";
                SDB_WGT.ForeColor = Color.Red;
                sGradeFlag = "N";
            }
        }

        private void ss1_DblClk(int col, int row) {
            //If Row < 1 Or SDB_DIVIDE_CNT.Value > 0 Then Exit Sub

            TXT_PLATE_NO.Text = ss1.ActiveSheet.Cells[row, 0].Text;
            CHK_GRID_FLAG.Checked = false;

            if (TXT_PLATE_NO.Text.Length == 14) {

                if (p_Ref(1, 0, true, false)) {
                    ///'''''''''''''''ADD BY GUOLI AT 200712071330''''''''''
                    if (opt_CHK_SUR_GRD0.Checked) {
                        TXT_SURF_GRD.Text = "Y";
                    } else if (opt_CHK_SUR_GRD1.Checked) {
                        TXT_SURF_GRD.Text = "N";
                    }
                    ///'''''''''''''''''''''''''''''''''''''''''''''''''''''

                    if (TXT_INSP_MAIN_GRD.Text.Length == 1) {
                        if (TXT_INSP_MAIN_GRD.Text == "7") {
                            opt_CHK_PRD_GRD5.Checked = true;
                        } else if (TXT_INSP_MAIN_GRD.Text == "5") {
                            opt_CHK_PRD_GRD4.Checked = true;
                        } else if (TXT_INSP_MAIN_GRD.Text == "4") {
                            opt_CHK_PRD_GRD3.Checked = true;
                        } else if (TXT_INSP_MAIN_GRD.Text == "3") {
                            opt_CHK_PRD_GRD2.Checked = true;
                        } else if (TXT_INSP_MAIN_GRD.Text == "2") {
                            opt_CHK_PRD_GRD1.Checked = true;
                        } else if (TXT_INSP_MAIN_GRD.Text == "1") {
                            opt_CHK_PRD_GRD0.Checked = true;
                        }
                    }

                    //Call Display_Data_Edit
                }
                if (TXT_INSP_OCCR_TIME.Text == "") {
                    TXT_INSP_OCCR_TIME.Text = Gf_DTSet("", "X");
                }

                // add by liqian at 2012-04-12  下一块时改判标准到自动清空
                txt_stdspec_chg.Text = "";
                txt_stdspec_name_chg.Text = "";

                //TXT_INSP_MAN = sUserID
                //MODIFY BY LIQIAN AT 20120322
                TXT_EMP_CD1.Text = GeneralCommon.sUserID;
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

            if (DTCheck == "D") {
                DTCheck = "D";
            } else {
                DTCheck = "S";
            }
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

        private void cbo_ResonDesc_Click(object sender, EventArgs e)
        {
            cbo_ResonDesc_Clk();
        }

        private void CHK_CL_FL_CheckedChanged(object sender, EventArgs e)
        {
            CHK_CL_FL_Clk();
        }

        private void chkCl_CheckedChanged(object sender, EventArgs e)
        {
            CHK_CL_FL_Clk();
        }

        private void chkGas_CheckedChanged(object sender, EventArgs e)
        {
            chkGas_Clk();
        }


        private void chkGrid_CheckedChanged(object sender, EventArgs e)
        {
            chkGrid_Clk();
        }

        private void opt_CHK_PRD_GRD0_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_PRD_GRD3_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_PRD_GRD1_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_PRD_GRD4_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_PRD_GRD2_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_PRD_GRD5_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_PRD_GRD_Clk();
        }

        private void opt_CHK_SUR_GRD0_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_SUR_GRD_Clk();
        }

        private void opt_CHK_SUR_GRD1_CheckedChanged(object sender, EventArgs e)
        {
            opt_CHK_SUR_GRD_Clk();
        }

        private void opt_LineFlag0_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void opt_LineFlag1_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void opt_LineFlag2_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void opt_LineFlag3_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void SDB_THK_TextChanged(object sender, EventArgs e)
        {
            PRD_WEIGHT_CALC();
        }

        private void SDB_WID_TextChanged(object sender, EventArgs e)
        {
            PRD_WEIGHT_CALC();
        }

        private void SDB_LEN_TextChanged(object sender, EventArgs e)
        {
            PRD_WEIGHT_CALC();
        }

        private void SDT_PROD_DATE_DoubleClick(object sender, EventArgs e)
        {
            SDT_PROD_DATE_DblClk();
        }

        private void SDT_PROD_TO_DATE_Load(object sender, EventArgs e)
        {
            SDT_PROD_TO_DATE_DblClk();
        }

        private void TXT_GRID_EMP_CD_DoubleClick(object sender, EventArgs e)
        {
            TXT_GRID_EMP_CD_DblClk();
        }

        private void TXT_GRID_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_GRID_TIME_DblClick();
        }

        private void TXT_INSP_OCCR_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_INSP_OCCR_TIME_DblClk();
        }

        private void CHK_TOP_GRD0_CheckedChanged(object sender, EventArgs e)
        {
            CHK_TOP_GRD0_Clk();
        }

        private void CHK_TOP_GRD1_CheckedChanged(object sender, EventArgs e)
        {
            CHK_TOP_GRD1_Clk();
        }

        private void CHK_BOT_GRD0_CheckedChanged(object sender, EventArgs e)
        {
            CHK_BOT_GRD0_Clk();
        }

        private void CHK_BOT_GRD1_CheckedChanged(object sender, EventArgs e)
        {
            CHK_BOT_GRD1_Clk();
        }

        private void CHK_GRID_FLAG_CheckedChanged(object sender, EventArgs e)
        {
            CHK_GRID_FLAG_Click();
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }



    }
}
