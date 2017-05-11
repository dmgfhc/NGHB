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
///-- 程序ID            WGC3010C    
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


        #region 界面初始化

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
            p_SetMc(SDB_INSP_LTH3 , "IR", "", "", "", imcseq, ""); //18
            p_SetMc(SDB_INSP_LTH4 , "IR", "", "", "", imcseq, ""); //19
            p_SetMc(SDB_INSP_LTH5 , "IR", "", "", "", imcseq, ""); //20
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
        #endregion

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
