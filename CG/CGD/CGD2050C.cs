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


        #
        region 界面初始化

        protected override void p_SubFormInit() {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("钢板号", TXT_PLATE_NO, "PI", "", "", "", "", imcseq); //0
            p_SetMc("作业线", txt_PrcLine, "PI", "", "", "", "", imcseq); //1
            p_SetMc(SDT_PROD_DATE, "P", "", "", "", imcseq, ""); //2
            p_SetMc(SDT_PROD_TO_DATE, "P", "", "", "", imcseq, ""); //3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, ""); //4
            p_SetMc(txt_stdspec_chg_ref, "P", "", "", "", imcseq, ""); //5
            p_SetMc(SDB_THK_REF, "P", "", "", "", imcseq, ""); //6
            p_SetMc(SDB_WID_REF, "P", "", "", "", imcseq, ""); //7
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
            p_SetMc(SDB_INSP_LEN_MX, "RL", "", "", "", imcseq, ""); //37
            p_SetMc(SDB_INSP_LEN_MN, "RL", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_WGT_ORD, "RL", "", "", "", imcseq, ""); //39
            p_SetMc("实绩重量", SDB_WGT, "NIR", "", "", "", "", imcseq); //40
            p_SetMc(SDB_PWGT_MX, "RL", "", "", "", imcseq, ""); //41
            p_SetMc(SDB_PWGT_MN, "RL", "", "", "", imcseq, ""); //42
            p_SetMc(TXT_INSP_THK_GRD, "IRL", "", "", "", imcseq, ""); //43
            p_SetMc(TXT_INSP_WID_GRD, "IRL", "", "", "", imcseq, ""); //44
            p_SetMc(TXT_INSP_LEN_GRD, "IRL", "", "", "", imcseq, ""); //45
            p_SetMc(TXT_INSP_WGT_GRD, "IRL", "", "", "", imcseq, ""); //46
            p_SetMc(TXT_SURF_GRD, "IR", "", "", "", imcseq, ""); //47
            p_SetMc(TXT_INSP_MAIN_GRD, "IR", "", "", "", imcseq, ""); //48
            p_SetMc(txtGas, "IR", "", "", "", imcseq, ""); //49
            p_SetMc(txtGrid, "IR", "", "", "", imcseq, ""); //50
            p_SetMc(TXT_CL, "IR", "", "", "", imcseq, ""); //51
            p_SetMc("头部检验工", TXT_INSP_MAN, "NIR", "", "", "", "", imcseq); //52
            p_SetMc(TXT_INSP_MAN_TAIL, "IR", "", "", "", imcseq, ""); //53
            p_SetMc("检查时间", TXT_INSP_OCCR_TIME, "NIR", "", "", "", "", imcseq); //54
            p_SetMc(SDB_ORD_WID, "R", "", "", "", imcseq, ""); //55
            p_SetMc(SDB_ORD_THK, "R", "", "", "", imcseq, ""); //56
            p_SetMc(SDB_ORD_LEN, "R", "", "", "", imcseq, ""); //57
            p_SetMc(TXT_GRID_EMP_CD, "IR", "", "", "", imcseq, ""); //58
            p_SetMc(TXT_GRID_TIME, "IR", "", "", "", imcseq, ""); //59
            p_SetMc(TXT_TOP_GRID_GRD, "IRL", "", "", "", imcseq, ""); //60
            p_SetMc(SDB_TOP_GRID_YRD, "IR", "", "", "", imcseq, ""); //61
            p_SetMc(SDB_TOP_GRID_DEEP, "IR", "", "", "", imcseq, ""); //62
            p_SetMc(TXT_BOT_GRID_GRD, "IRL", "", "", "", imcseq, ""); //63
            p_SetMc(SDB_BOT_GRID_YRD, "IR", "", "", "", imcseq, ""); //64
            p_SetMc(SDB_BOT_GRID_DEEP, "IR", "", "", "", imcseq, ""); //65
            p_SetMc(txt_stdspec, "R", "", "", "", imcseq, ""); //66
            p_SetMc(txt_stdspec_name, "R", "", "", "", imcseq, ""); //67
            p_SetMc(txt_stdspec_chg, "I", "", "", "", imcseq, ""); //68
            p_SetMc(txt_stdspec_name_chg, "L", "", "", "", imcseq, ""); //69
            p_SetMc(txt_Scrap_code, "IR", "", "", "", imcseq, ""); //70
            p_SetMc(txt_Scrap_name, "L", "", "", "", imcseq, ""); //71
            p_SetMc(SDB_Mn, "R", "", "", "", imcseq, ""); //72
            p_SetMc(TXT_PROC_CD, "R", "", "", "", imcseq, ""); //73
            p_SetMc(SDB_THK_R, "IR", "", "", "", imcseq, ""); //74
            p_SetMc(SDB_WID_R, "IR", "", "", "", imcseq, ""); //75
            p_SetMc(SDB_LEN_R, "IR", "", "", "", imcseq, ""); //76
            p_SetMc(TXT_EMP_CD1, "IR", "", "", "", imcseq, ""); //77
            p_SetMc(TXT_WAVE, "IR", "", "", "", imcseq, ""); //78
            p_SetMc(TXT_VERT_DEG, "IR", "", "", "", imcseq, ""); //79
            p_SetMc(TXT_RECT_DEG, "IR", "", "", "", imcseq, ""); //80
            p_SetMc(SDB_INSP_DIAGONAL1, "IR", "", "", "", imcseq, ""); //81
            p_SetMc(SDB_INSP_DIAGONAL2, "IR", "", "", "", imcseq, ""); //82
            p_SetMc("定尺", TXT_SIZE_KND, "NIR", "", "", "", "", imcseq); //83
            p_SetMc(TXT_WAVE1, "IR", "", "", "", imcseq, ""); //84
            p_SetMc(txt_Color_code, "IR", "", "", "", imcseq, ""); //85
            p_SetMc(SDB_HD1, "IR", "", "", "", imcseq, ""); //86
            p_SetMc(SDB_HD2, "IR", "", "", "", imcseq, ""); //87
            p_SetMc(SDB_HD3, "IR", "", "", "", imcseq, ""); //88
            p_SetMc(SDB_HD4, "IR", "", "", "", imcseq, ""); //89
            p_SetMc(SDB_HD5, "IR", "", "", "", imcseq, ""); //90
            p_SetMc(SDB_HD6, "IR", "", "", "", imcseq, ""); //91
            p_SetMc(CHK_FLAW_YN, "I", "", "", "", imcseq, ""); //92
            p_SetMc(TXT_EMP_CD5, "I", "", "", "", imcseq, ""); //93
            p_SetMc(COM_PF, "I", "", "", "", imcseq, ""); //94


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
                txt_ResonCd = cbo_ResonDesc.Text.Substring(0, 0);
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
                txtCl = "Y";
                chkCl.ForeColor = Color.Red;
                //red
            } else {
                txtCl = "N";
                chkCl.ForeColor = Color.Black;
                //black
            }
        }

        private void chkGas_Clk() {
            if (chkGas.Checked) {
                txtGas = "Y";
                chkGas.ForeColor = Color.Red;
                //red
            } else {
                txtGas = "N";
                chkGas.ForeColor = Color.Black;
                //red
            }
        }

        private void chkGrid_Clk() {
            if (chkGrid.Checked) {
                txtGrid = "Y";
                chkGrid.ForeColor = Color.Red;
                //red
            } else {
                txtGrid = "N";
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

            Gf_Sp_Refer(M_CN1, Proc_Sc("Sc"), Mc1);

            p_Ref(1, 1, true, false);

            if (ss1.ActiveSheet.RowCount > 0) {
                ss1.ROW = 1;
                ss1.Col = 1;
                TXT_PLATE_NO.Text = ss1.ActiveSheet.Cells[0, 0].Text;
                // for (i = 0; i <= 17; i++) {
                //     CHK_PART(i).Value = 0;
                // }
            }

            if (TXT_PLATE_NO.Text.Length == 14) {
                if (p_Ref(1, 0, true, false)) {


                    if (TXT_SURF_GRD.Text == "Y") {
                        opt_CHK_SUR_GRD0.Checked = true;
                    } else {
                        opt_CHK_SUR_GRD1.Checked = true;
                    }


                    if (TXT_INSP_MAIN_GRD.Length == 1) {
                        if (TXT_INSP_MAIN_GRD.Text == "7") {
                            opt_CHK_PRD_GRD5.Checked = true;
                        } else {

                            opt_CHK_PRD_GRD(TXT_INSP_MAIN_GRD - 1).Value = true;
                        }
                    }
                    if (TXT_INSP_OCCR_TIME.Text == "") {
                        TXT_INSP_OCCR_TIME.Text = Gf_DTSet("", "X");
                    }
                    //TXT_INSP_MAN = sUserID
                    //ADD BY LIQIAN AT 20120322

                    TXT_EMP_CD1 = GeneralCommon.sUserID;

                    //Call Display_Data_Edit
                }
            }

            {
                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++) {

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();
                    sFlag = ss1.ActiveSheet.Cells[iCount - 1, SS1_FLAG].Text.Trim();
                    sexport = ss1.ActiveSheet.Cells[iCount - 1, SS1_EXPORT].Text.Trim();
                    if (simpcont == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                    }

                    //是否定制配送
                    if (sFlag == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP5.BackColor, Color.White);
                    }
                    //是否出口订单

                    if (sexport == "Y") {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP6.BackColor, Color.White);
                    }
                }
            }

            CHK_CL_FL.Checked = false;

        }




















        private void WGC3010C_Load(object sender, EventArgs e) {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
            f4ETCR_CUR_INV.Text = "HB";
            TXT_TOP_GRID_GRD.Enabled = false;
            SDB_TOP_GRID_YRD.Enabled = false;
            SDB_TOP_GRID_DEEP.Enabled = false;
            TXT_BOT_GRID_GRD.Enabled = false;
            SDB_BOT_GRID_YRD.Enabled = false;
            SDB_BOT_GRID_DEEP.Enabled = false;
            TXT_GRID_TIME.Enabled = false;
            LISTB_T_GRID_GRD.Enabled = false;
            LISTB_B_GRID_GRD.Enabled = false;
            TXT_GRID_TIME.Enabled = false;

            label41.Visible = false;

        }

        #
        endregion

        # region //查询
        public override void Form_Ref() {
            base.p_Ref(1, 1, true, true);
            if (TXT_PLATE_NO.Text != "") {
                TXT_PLATE_NO_EDT.Text = TXT_PLATE_NO.Text;
                base.p_Ref(2, 0, true, false);
            }
            return;
        }#
        endregion

        # region //保存
        public override void Form_Pro() {
            f4ETCR_PLT.Text = "C2";
            TXT_EMP_CD.Text = GeneralCommon.sUserID;

            //确保修磨时间已经输入
            if (TXT_GRID_TIME.Text == "    -  -     :  :" && CHK_CL_FL.Checked == true) {
                GeneralCommon.Gp_MsgBoxDisplay("请输入修磨时间", "I", "");

                return;
            }

            if (TXT_SURF_GRD.Text == "1") {
                if (CHK_CL_FL.Checked == true) {
                    if (TXT_TOP_GRID_GRD.Text == "N" || TXT_BOT_GRID_GRD.Text == "N") {
                        GeneralCommon.Gp_MsgBoxDisplay("修磨不合格不允许判定正品！", "I", "");
                        return;
                    }
                }
            }

            base.p_pro(2, 0, true, false);

            return;
        }#
        endregion

        # region //列表选择（判定结果）
        private void LISTB_T_GRID_GRD_Click(object sender, EventArgs e) {
            TXT_TOP_GRID_GRD.Text = Convert.ToString(LISTB_T_GRID_GRD.SelectedItem).Substring(0, 1);
        }

        private void LISTB_B_GRID_GRD_Click(object sender, EventArgs e) {
            TXT_BOT_GRID_GRD.Text = Convert.ToString(LISTB_B_GRID_GRD.SelectedItem).Substring(0, 1);
        }

        private void LISTB_SURF_GRD13_Click(object sender, EventArgs e) {
            TXT_SURF_GRD.Text = Convert.ToString(LISTB_SURF_GRD13.SelectedItem).Substring(0, 1);
            //点击等级1~3时取消等级4~7的选择
            LISTB_SURF_GRD47.SetSelected(0, false);
        }

        private void LISTB_SURF_GRD47_Click(object sender, EventArgs e) {
            TXT_SURF_GRD.Text = Convert.ToString(LISTB_SURF_GRD47.SelectedItem).Substring(0, 1);
            //点击等级4~7时取消等级1~3的选择
            LISTB_SURF_GRD13.SetSelected(0, false);
        }





        #
        endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e) {
            if (ss1_Sheet1.RowCount == 0) {
                return;

            }

            //在点击单元格的时候，先将以下F4控件项置为空 
            TXT_B_FLAW_NAME.Text = "";
            TXT_B_FLAW_NAME1.Text = "";
            TXT_T_FLAW_NAME.Text = "";
            TXT_T_FLAW_NAME1.Text = "";
            txt_Scrap_name.Text = "";
            TXT_INSP_FLAW2.Text = "";
            TXT_ENDUSE_CD.Text = "";
            f4ETCR_B_FLAW_CD.Text = "";
            f4ETCR_B_FLAW_CD1.Text = "";
            f4ETCR_T_FLAW_CD.Text = "";
            f4ETCR_T_FLAW_CD1.Text = "";
            txt_Scrap_code.Text = "";
            TXT_INSP_FLAW_NAME2.Text = "";

            //当单击表单时，按照单击行所对应钢板号查询钢板探伤详细信息
            TXT_PLATE_NO_EDT.Text = ss1_Sheet1.Cells[e.Row, iSs1_Plate_No].Text;
            base.p_Ref(2, 0, true, false);
            f4ETCR_PLT.Enabled = true;
            TXT_PLATE_NO.Enabled = true;

            //为了解决用户修改公共代码导致查询文本数据不能同步变化的问题，
            //以下程序，判断F4项是否存在公共代码，如果存在则调用Gf_CodeFind函数使用相应的SQL对第二项的值，进行查询
            //再将对应的值存在F4控件的第二项中
            if (f4ETCR_B_FLAW_CD.Text != "")
                TXT_B_FLAW_NAME.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_B_FLAW_CD.Text + "'");

            if (f4ETCR_B_FLAW_CD1.Text != "")
                TXT_B_FLAW_NAME1.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_B_FLAW_CD1.Text + "'");

            if (f4ETCR_T_FLAW_CD.Text != "")
                TXT_T_FLAW_NAME.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_T_FLAW_CD.Text + "'");

            if (f4ETCR_T_FLAW_CD1.Text != "")
                TXT_T_FLAW_NAME1.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_T_FLAW_CD1.Text + "'");


            if (txt_Scrap_code.Text != "")
                txt_Scrap_name.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0017' AND T.CD =" + "'" + txt_Scrap_code.Text + "'");

            if (TXT_INSP_FLAW_NAME2.Text != "")
                TXT_INSP_FLAW2.Text =
                GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + TXT_INSP_FLAW_NAME2.Text + "'");

        }

        #
        region //精整指示处理
        private void CHK_GAS_FL_CheckedChanged(object sender, EventArgs e) {
            if (CHK_GAS_FL.Checked) {
                TXT_GAS_FL.Text = "Y";
            } else {
                TXT_GAS_FL.Text = "";
            }
        }

        private void CHK_CL_FL_CheckedChanged(object sender, EventArgs e) {
                if (CHK_CL_FL.Checked) {
                    TXT_CL_FL.Text = "Y";
                } else {
                    TXT_CL_FL.Text = "";
                }
            }
            //留样指示
        private void CHK_SMP_FL_CheckedChanged(object sender, EventArgs e) {
            if (CHK_SMP_FL.Checked) {
                TXT_SMP_FL.Text = "Y";
            } else {
                TXT_SMP_FL.Text = "";
            }
        }

        #
        endregion

        private void TEXT_STDSPEC_DoubleClick(object sender, EventArgs e) {
            Collection rControl = new Collection();
            Collection fControl = new Collection();
            rControl.Add((TextBox) sender, null, null, null);
            fControl.Add("CD_SHORT_NAME", null, null, null);
            DataDicCommon.Gf_Master_DD(rControl, fControl, "SELECT CD_SHORT_NAME AS 标准代号, CD_NAME AS 标准中文名 FROM ZP_CD WHERE CD_MANA_NO = 'G0035'", "", 0, "", 1);



        }

        private void TEXT_STDSPEC_KeyUp(object sender, KeyEventArgs e) {
                Collection rControl = new Collection();
                Collection fControl = new Collection();
                if (e.KeyCode == Keys.F4) {
                    rControl.Add((TextBox) sender, null, null, null);
                    fControl.Add("STDSPEC", null, null, null);
                    DataDicCommon.Gf_Master_DD(rControl, fControl, "SELECT T.STDSPEC AS 标准号,T.STDSPEC_YY AS 发布年度,STDSPEC_CHR_CD FROM NISCO.QP_STD_HEAD T WHERE NVL(T.STDSPEC_CHR_CD,'Y') <>'N' ORDER BY STDSPEC ASC ", "", 0, "", 1);
                }



            }
            //以下事件用于将F4控件代码小写转换成大写
        private void f4ETCR_B_FLAW_CD_KeyUp(object sender, KeyEventArgs e) {
            f4ETCR_B_FLAW_CD.Text = f4ETCR_B_FLAW_CD.Text.ToUpper();
            f4ETCR_B_FLAW_CD.SelectionStart = f4ETCR_B_FLAW_CD.Text.Length;
        }
        private void f4ETCR_B_FLAW_CD1_KeyUp(object sender, KeyEventArgs e) {
            f4ETCR_B_FLAW_CD1.Text = f4ETCR_B_FLAW_CD1.Text.ToUpper();
            f4ETCR_B_FLAW_CD1.SelectionStart = f4ETCR_B_FLAW_CD1.Text.Length;

        }

        private void f4ETCR_T_FLAW_CD_KeyUp(object sender, KeyEventArgs e) {

            f4ETCR_T_FLAW_CD.Text = f4ETCR_T_FLAW_CD.Text.ToUpper();
            f4ETCR_T_FLAW_CD.SelectionStart = f4ETCR_T_FLAW_CD.Text.Length;
        }


        private void f4ETCR_T_FLAW_CD1_KeyUp(object sender, KeyEventArgs e) {
            f4ETCR_T_FLAW_CD1.Text = f4ETCR_T_FLAW_CD1.Text.ToUpper();
            f4ETCR_T_FLAW_CD1.SelectionStart = f4ETCR_T_FLAW_CD1.Text.Length;
        }

        private void f4ETCN_WOO_RSN_KeyUp(object sender, KeyEventArgs e) {
            f4ETCN_WOO_RSN.Text = f4ETCN_WOO_RSN.Text.ToUpper();
            f4ETCN_WOO_RSN.SelectionStart = f4ETCN_WOO_RSN.Text.Length;
        }

        private void f4ETCR_SCRAP_KeyUp(object sender, KeyEventArgs e) {
            txt_Scrap_code.Text = txt_Scrap_code.Text.ToUpper();
            txt_Scrap_code.SelectionStart = txt_Scrap_code.Text.Length;
        }

        private void f4ETCR_CHG_GRD_RES_KeyUp(object sender, KeyEventArgs e) {
            TXT_INSP_FLAW_NAME2.Text = TXT_INSP_FLAW_NAME2.Text.ToUpper();
            TXT_INSP_FLAW_NAME2.SelectionStart = TXT_INSP_FLAW_NAME2.Text.Length;
        }

        private void f4ETCR_ENDUSE_CD_KeyUp(object sender, KeyEventArgs e) {
            f4ETCR_ENDUSE_CD.Text = f4ETCR_ENDUSE_CD.Text.ToUpper();
            f4ETCR_ENDUSE_CD.SelectionStart = f4ETCR_ENDUSE_CD.Text.Length;
        }

        private void f4ETCR_CHG_GRD_DEP_KeyUp(object sender, KeyEventArgs e) {
            f4ETCR_CHG_GRD_DEP.Text = f4ETCR_CHG_GRD_DEP.Text.ToUpper();
            f4ETCR_CHG_GRD_DEP.SelectionStart = f4ETCR_CHG_GRD_DEP.Text.Length;
        }

        private void TXT_SMP_FL_TextChanged(object sender, EventArgs e) {
            if (TXT_SMP_FL.Text == "Y") {
                label41.Visible = true;
                label41.ForeColor = Color.Red;

            } else {
                label41.Visible = false;
            }
        }

        private void numBox4_TextChanged(object sender, EventArgs e) {

        }


    }
}



//1AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

using System.Collections;
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

        string CUT_SEQ;

        const int SS1_URGNT_FL = 19; //紧急订单绿色标记显示 add by liqian 2012-08-16
        const int SS1_IMP_CONT = 20;
        const int SS1_PILECOOL = 21;
        const int SS1_FLAG = 22;
        const int SS1_EXPORT = 23;
        const int SS1_SLAB_NO = 0;

        const int SS2_DUILENG = 12;
        const int SS2_MPLATE_NO = 0;


        protected override void p_SubFormInit() {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧件号", txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间", txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
            //p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
            //p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
            //p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
            //p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
            //p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
            //p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
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
            p_SetMc("轧件号", txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间", txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
            // p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
            // p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
            // p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
            // p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
            // p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
            // p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_MOTHER_PLATE_LEN6, "IR", "", "", "", imcseq, ""); //39
            p_SetMc(SDB_MOTHER_SCH_LEN6, "R", "", "", "", imcseq, ""); //40
            p_SetMc(txt_Shift, "IR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_Group, "IR", "", "", "", imcseq, ""); //42
            p_SetMc(txt_Emp, "IR", "", "", "", imcseq, ""); //43


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("轧件号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("取样方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("取样长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("母板块数", "E", "9", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("母板切割长度1", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("母板切割长度2", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("母板切割长度3", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //12
            p_SetSc("母板切割长度4", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("母板切割长度5", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("母板切割长度6", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("定尺", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("订单长度范围", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //24
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //28

            iheadrow = 0;
            p_spanSpread("轧件后尺寸", 5, 7, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("母板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("母板切割日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("作业人", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("经RH", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12


            iheadrow = 0;
            p_spanSpread("母板尺寸", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("定尺", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("标准号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //5

            CUT_SEQ = "SELECT NVL(SEQ_NO,0) FROM NISCO.GP_MP_IDX WHERE PLT='C3'";

        }

        private void Check1_Clk() {
            if (SDB_MOTHER_PLATE_LEN1.Text == "0") { Check1.Checked = false; }
            if (Check1.Checked) {
                txt_CutYN1.Text = "Y";
            } else {
                txt_CutYN1.Text = "";
            }
        }

        private void Check2_Clk() {
            if (SDB_MOTHER_PLATE_LEN2.Text == "0") { Check2.Checked = false; }
            if (Check2.Checked) {
                txt_CutYN2.Text = "Y";
            } else {
                txt_CutYN2.Text = "";
            }
        }

        private void Check3_Clk() {

            if (SDB_MOTHER_PLATE_LEN3.Text == "0") { Check3.Checked = false; }
            if (Check3.Checked) {
                txt_CutYN3.Text = "Y";
            } else {
                txt_CutYN3.Text = "";
            }
        }

        private void Check4_Clk() {
            if (SDB_MOTHER_PLATE_LEN4.Text == "0") { Check4.Checked = false; }
            if (Check4.Checked) {
                txt_CutYN4.Text = "Y";
            } else {
                txt_CutYN4.Text = "";
            }
        }

        private void Check5_Clk() {
            if (SDB_MOTHER_PLATE_LEN5.Text == "0") { Check5.Checked = false; }
            if (Check5.Checked) {
                txt_CutYN5.Text = "Y";
            } else {
                txt_CutYN5.Text = "";
            }
        }

        private void Check6_Clk() {
            if (SDB_MOTHER_PLATE_LEN6.Text == "0") { Check6.Checked = false; }
            if (Check6.Checked) {
                txt_CutYN6.Text = "Y";
            } else {
                txt_CutYN6.Text = "";
            }
        }

        private void cmd_Pass_Clk() {

            long CNT;
            string SMESG;
            if (txt_CutDate.Text != "" && txt_CutDate.Text.Substring(0, 1) != "2") {
                SMESG = " 请输入切割时间...！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            CNT = 0;
            if (Check1.Checked) {
                CNT = CNT + 1;
            }

            if (Check2.Checked) {
                CNT = CNT + 1;
            }

            if (Check3.Checked) {
                CNT = CNT + 1;
            }

            if (Check4.Checked) {
                CNT = CNT + 1;
            }

            if (Check5.Checked) {
                CNT = CNT + 1;
            }

            if (Check6.Checked) {
                CNT = CNT + 1;
            }

            if (CNT > 1) {
                SMESG = "一个以上母板不能空过.......！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            } else {
                Form_Pro();
            }

            txt_CutDate.Text = "";
        }

        private void cmd_scrap_Clk() {

            if (!GeneralCommon.Gf_MessConfirm("您确定要对母板号" + txt_RollingNo.Text + "做废钢处理吗？", "Q", "废钢指示确定")) {
                return;
            }

            string[] Para1 = new string[5];

            Para1[0] = txt_RollingNo.Text.Trim();
            Para1[1] = txt_Shift.Text.Trim();
            Para1[2] = txt_Group.Text.Trim();
            Para1[3] = GeneralCommon.sUserID;
            Para1[4] = TXT_CB.Text.Trim();

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGC2060NC.P_SCRAP", Para1)) {

                GeneralCommon.Gp_MsgBoxDisplay("废钢处理成功=> " + txt_RollingNo.Text, "I", "系统提示信息");

            } else {
                GeneralCommon.Gp_MsgBoxDisplay("实绩处理失败，请确认" + txt_RollingNo.Text, "I", "系统提示信息");
            }

            txt_CutDate.Text = "";

        }


        //vb上发现本条代码已经移出，暂时不考虑实现，如果后期要实现，请查询CGC2060C VB画面
        // private void cmd_Seq_Clk() {

        // }

        private void CGC2060C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGC2060NC";

            Form_Define();

            Tab1.SelectedIndex = 0;

            Form_Ref();

            unlockSpread(ss1);
            unlockSpread(ss2);
            unlockSpread(ss3);

            txt_Shift.Text = Gf_ShiftSet3("");
            txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
            txt_Emp.Text = GeneralCommon.sUserID;

            if (base.sAuthority.Substring(0, 3) == "111") {
                cmd_Pass.Enabled = true;
                //cmd_Seq.Enabled = True
                cmd_scrap.Enabled = true;

            } else {
                cmd_Pass.Enabled = false;
                //cmd_Seq.Enabled = False
                cmd_scrap.Enabled = false;
            }

            lockSpread(ss1);
            lockSpread(ss2);
            lockSpread(ss3);

        }



        public override void Form_Ref() {
            int iRow;
            int iCol;
            string sUrgnt_Fl;
            string simpcont;
            string PILECOOL;
            string sFlag;
            string sexport;

            string sDuileng;

            if (Tab1.SelectedIndex == 0) {
                p_Ref(0, 1, true, false);
                //        TXT_SEQ = Gf_FloatFind(M_CN1, CUT_SEQ)
                ss1_DblClk(0, 0);

                unlockSpread(ss1);

                //紧急订单绿色显示 add by liqian 2012-08-16
                {
                    for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++) {
                        sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text.ToString().Trim();
                        simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text.ToString().Trim();
                        PILECOOL = ss1.ActiveSheet.Cells[iRow - 1, SS1_PILECOOL].Text.ToString().Trim();
                        sFlag = ss1.ActiveSheet.Cells[iRow - 1, SS1_FLAG].Text.ToString().Trim();
                        sexport = ss1.ActiveSheet.Cells[iRow - 1, SS1_EXPORT].Text.ToString().Trim();

                        if (sUrgnt_Fl == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);

                        }
                        if (simpcont == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        if (PILECOOL == "Y" & simpcont != "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, Color.Yellow);

                        }

                        //是否定制配送

                        if (sFlag == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, SSP5.BackColor, Color.White);

                        }
                        //是否出口订单
                        if (sexport == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, SSP6.BackColor, Color.White);
                        }
                    }
                }

                lockSpread(ss1);
                unlockSpread(ss2);

                {
                    for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++) {
                        sDuileng = ss2.ActiveSheet.Cells[iRow - 1, SS2_DUILENG].Text.ToString().Trim();;

                        if (sDuileng == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_MPLATE_NO, SS2_MPLATE_NO, iRow - 1, iRow - 1, SSPanel1.BackColor, Color.White);
                        }
                    }
                }
                lockSpread(ss2);

            } else if (Tab1.SelectedIndex == 1) {
                p_Ref(2, 2, true, false);
                //        TXT_SEQ = Gf_FloatFind(M_CN1, CUT_SEQ)

            }


        }

        public override void Form_Pro() {

            string SMESG;

            if (!Gp_DateCheck(txt_CutDate.Text, "")) {
                SMESG = " 请正确输入切割时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");

                return;
            }

            p_Pro(1, 0, true, true);

            Form_Ref();

            txt_Shift.Text = Gf_ShiftSet3("");
            txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
            txt_Emp.Text = GeneralCommon.sUserID;

            txt_CutDate.Text = "";

        }

        private void SDB_MOTHER_PLATE_LEN1_Chg() {
            if (SDB_MOTHER_PLATE_LEN1.NumValue > 0) {
                Check1.Checked = true;
                txt_CutYN1.Text = "Y";
            } else {
                Check1.Checked = false;
                txt_CutYN1.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN1_DblClk() {
            if (SDB_MOTHER_PLATE_LEN1.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN1.Text = SDB_MOTHER_SCH_LEN1.Text;
            } else {
                SDB_MOTHER_PLATE_LEN1.Text = "";
            }
        }


        private void SDB_MOTHER_PLATE_LEN2_Chg() {
            if (SDB_MOTHER_PLATE_LEN2.NumValue > 0) {
                Check2.Checked = true;
                txt_CutYN2.Text = "Y";
            } else {
                Check2.Checked = false;
                txt_CutYN2.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN2_DblClk() {
            if (SDB_MOTHER_PLATE_LEN2.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN2.Text = SDB_MOTHER_SCH_LEN2.Text;
            } else {
                SDB_MOTHER_PLATE_LEN2.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN3_Chg() {
            if (SDB_MOTHER_PLATE_LEN3.NumValue > 0) {
                Check3.Checked = true;
                txt_CutYN3.Text = "Y";
            } else {
                Check3.Checked = false;
                txt_CutYN3.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN3_DblClk() {
            if (SDB_MOTHER_PLATE_LEN3.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN3.Text = SDB_MOTHER_SCH_LEN3.Text;
            } else {
                SDB_MOTHER_PLATE_LEN3.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN4_Chg() {
            if (SDB_MOTHER_PLATE_LEN4.NumValue > 0) {
                Check4.Checked = true;
                txt_CutYN4.Text = "Y";
            } else {
                Check4.Checked = false;
                txt_CutYN4.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN4_DblClk() {
            if (SDB_MOTHER_PLATE_LEN4.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN4.Text = SDB_MOTHER_SCH_LEN4.Text;
            } else {
                SDB_MOTHER_PLATE_LEN4.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN5_Chg() {
            if (SDB_MOTHER_PLATE_LEN5.NumValue > 0) {
                Check5.Checked = true;
                txt_CutYN5.Text = "Y";
            } else {
                Check5.Checked = false;
                txt_CutYN5.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN5_DblClk() {
            if (SDB_MOTHER_PLATE_LEN5.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN5.Text = SDB_MOTHER_SCH_LEN5.Text;
            } else {
                SDB_MOTHER_PLATE_LEN5.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN6_Chg() {
            if (SDB_MOTHER_PLATE_LEN6.NumValue > 0) {
                Check6.Checked = true;
                txt_CutYN6.Text = "Y";
            } else {
                Check6.Checked = false;
                txt_CutYN6.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN6_DblClk() {
            if (SDB_MOTHER_PLATE_LEN6.NumValue == 0) {
                SDB_MOTHER_PLATE_LEN6.Text = SDB_MOTHER_SCH_LEN6.Text;
            } else {
                SDB_MOTHER_PLATE_LEN6.Text = "";
            }
        }

        private void ss1_DblClk(int col, int row) {
            if (ss1.ActiveSheet.RowCount > 0) {
                txt_RollingNo.Text = ss1.ActiveSheet.Cells[row, 0].Text;

                if (txt_RollingNo.Text.Trim() != "") {

                    p_Ref(1, 0, true, false);
                    p_Ref(1, 3, true, false);

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN1.Text) < 500) {
                        txt_Thk1.Text = "";
                        txt_Wid1.Text = "";
                        Check1.Checked = false;
                    } else {
                        Check1.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN2.Text) < 500) {
                        txt_Thk2.Text = "";
                        txt_Wid2.Text = "";
                        Check2.Checked = false;
                    } else {
                        Check2.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN3.Text) < 500) {
                        txt_Thk3.Text = "";
                        txt_Wid3.Text = "";
                        Check3.Checked = false;
                    } else {
                        Check3.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN4.Text) < 500) {
                        txt_Thk4.Text = "";
                        txt_Wid4.Text = "";
                        Check4.Checked = false;
                    } else {
                        Check4.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN5.Text) < 500) {
                        txt_Thk5.Text = "";
                        txt_Wid5.Text = "";
                        Check5.Checked = false;
                    } else {
                        Check5.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN6.Text) < 500) {
                        txt_Thk6.Text = "";
                        txt_Wid6.Text = "";
                        Check6.Checked = false;
                    } else {
                        Check6.Checked = true;
                    }

                    txt_CutDate.Text = "";
                }

                txt_Shift.Text = Gf_ShiftSet3("");
                txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
                txt_Emp.Text = GeneralCommon.sUserID;

                //txt_CutDate.RawData = Gf_DTSet(M_CN1, , "X")

            }
        }


        private void ss2_DblClk(int col, int row) {
            if (ss2.ActiveSheet.RowCount > 0) {
                txt_RollingNo.Text = ss2.ActiveSheet.Cells[row, 0].Text;;
                if (txt_RollingNo.Text.Trim() != "") {
                    p_Ref(3, 0, true, false);
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

        private void txt_CutDate_Clk() {
            txt_CutDate.Text = Gf_DTSet("", "X");
        }

        private void txt_RstFormDate_DblClk() {
            txt_RstFormDate.Text = Gf_DTSet("", "X");
            txt_RstToDate.Text = Gf_DTSet("", "X");
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

        public void lockSpread(FpSpread e) {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++) {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        #
        endregion

        private void Check1_CheckedChanged(object sender, EventArgs e) {
            Check1_Clk();
        }

        private void Check2_CheckedChanged(object sender, EventArgs e) {
            Check2_Clk();
        }

        private void Check3_CheckedChanged(object sender, EventArgs e) {
            Check3_Clk();
        }

        private void Check4_CheckedChanged(object sender, EventArgs e) {
            Check4_Clk();
        }

        private void Check5_CheckedChanged(object sender, EventArgs e) {
            Check5_Clk();
        }

        private void Check6_CheckedChanged(object sender, EventArgs e) {
            Check6_Clk();
        }

        private void cmd_Pass_Click(object sender, EventArgs e) {
            cmd_Pass_Clk();
        }

        private void cmd_scrap_Click(object sender, EventArgs e) {
            cmd_scrap_Clk();
        }

        private void SDB_MOTHER_PLATE_LEN1_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN1_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN1_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN1_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN2_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN2_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN2_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN2_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN3_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN3_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN3_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN3_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN4_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN4_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN4_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN4_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN5_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN5_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN5_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN5_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN6_TextChanged(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN6_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN6_DoubleClick(object sender, EventArgs e) {
            SDB_MOTHER_PLATE_LEN6_DblClk();
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e) {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e) {
            ss2_DblClk(e.Column, e.Row);
        }

        private void Tab1_SelectedIndexChanged(object sender, EventArgs e) {
            tab1_Clk();
        }

        private void txt_CutDate_Click(object sender, EventArgs e) {
            txt_CutDate_Clk();
        }

        private void txt_RstFormDate_DoubleClick(object sender, EventArgs e) {
            txt_RstFormDate_DblClk();
        }




    }
}
//-------ASDDDDDDDDDSADADAD---
