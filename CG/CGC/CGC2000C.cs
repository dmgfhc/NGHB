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
///-- 程序名            粗轧制作业实绩查询及修改界面                               
///-- 程序ID            CGC2000C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.04.28                                                
///-- 处理描述          粗轧制作业实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.04.28        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG {
    public partial class CGC2000C: CommonClass.FORMBASE {
        public CGC2000C() {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();

        const int SS2_SLAB_NO = 0;
        const int SS2_UST_FL = 13;
        //是否探伤  add by liqian 2013-04-08
        const int SS2_DEL_TO_DATE = 24;
        //超交货期用红色显示 add by liqian 2012-06-11
        const int SS2_URGNT_FL = 25;
        //紧急订单绿色显示 add by liqian 2012-08-15
        const int SS2_FLAG = 26;
        const int SS2_EXPORT = 27;
        const int SS2_ORD_CNT = 28;



        protected override void p_SubFormInit() {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", txt_SlabNo, "PNIRL", "", "", "", "", imcseq); //0
            p_SetMc(txt_SlabSize, "RL", "", "", "", imcseq, ""); //1
            p_SetMc(txt_RollingSize, "RL", "", "", "", imcseq, ""); //2
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //3
            p_SetMc(txt_HTM, "RL", "", "", "", imcseq, ""); //4
            p_SetMc(txt_CrCd, "RL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_TrimFl, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_CrMillRatet3, "RL", "", "", "", imcseq, ""); //7
            p_SetMc(txt_CrMillRatet4, "RL", "", "", "", imcseq, ""); //8
            p_SetMc(txt_CrMillRatet5, "RL", "", "", "", imcseq, ""); //9
            p_SetMc(txt_CrMillTmpt3, "RL", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CrMillTmpt4, "RL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_CrMillTmpt5, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_CoolMth, "RL", "", "", "", imcseq, ""); //13
            p_SetMc(txt_CoolSpeed, "RL", "", "", "", imcseq, ""); //14
            p_SetMc(txt_CoolTemp, "RL", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_COOL_AVE_TEMP, "IR", "", "", "", imcseq, ""); //16
            p_SetMc(SDB_COOL_EXT_TEMP, "IR", "", "", "", imcseq, ""); //17
            p_SetMc(SDB_COOL_ENT_TEMP, "IR", "", "", "", imcseq, ""); //18
            p_SetMc(SDB_COOL_WGT, "IR", "", "", "", imcseq, ""); //19
            p_SetMc(TXT_CR_CD, "IR", "", "", "", imcseq, ""); //20
            p_SetMc(TXT_ROLLING_METHOD, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_CR_STAGE1_THK, "IR", "", "", "", imcseq, ""); //22
            p_SetMc(SDB_CR_STAGE1_TEMP, "IR", "", "", "", imcseq, ""); //23
            p_SetMc(SDB_CR_STAGE2_THK, "IR", "", "", "", imcseq, ""); //24
            p_SetMc(SDB_CR_STAGE2_TEMP, "IR", "", "", "", imcseq, ""); //25
            p_SetMc(SDB_CR_STAGE3_THK, "IR", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_CR_STAGE3_TEMP, "IR", "", "", "", imcseq, ""); //27
            p_SetMc("开轧时间", TXT_MILL_STA_TIME, "NIR", "", "", "", "", imcseq); //28
            p_SetMc("终轧时间", TXT_MILL_END_TIME, "NIR", "", "", "", "", imcseq); //29
            p_SetMc("厚度", txt_thk, "NIR", "", "", "", "", imcseq); //30
            p_SetMc("宽度", txt_wid, "NIR", "", "", "", "", imcseq); //31
            p_SetMc("长度", txt_len, "NIR", "", "", "", "", imcseq); //32
            p_SetMc("终轧温度", txt_LastTemp, "IR", "", "", "", "", imcseq); //33
            p_SetMc("班次", TXT_SHIFT, "NIR", "", "", "", "", imcseq); //34
            p_SetMc("班别", TXT_GROUP, "NIR", "", "", "", "", imcseq); //35
            p_SetMc("作业人员", TXT_EMP1, "NIR", "", "", "", "", imcseq); //36
            p_SetMc(TXT_EMP2, "IR", "", "", "", imcseq, ""); //37
            p_SetMc(txt_Roll_Stlgrd, "R", "", "", "", imcseq, ""); //38
            p_SetMc(cal_thk, "LR", "", "", "", imcseq, ""); //39
            p_SetMc(cal_thk2, "LR", "", "", "", imcseq, ""); //40
            p_SetMc(txt_ORD_LEN_MIN, "LR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_ORD_LEN_MAX, "LR", "", "", "", imcseq, ""); //42

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("板坯号", txt_SlabNo, "PNL", "", "", "", "", imcseq);

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("粗轧实绩开始时间", txt_RstFormDate, "PN", "", "", "", "", imcseq);
            p_SetMc("粗轧实绩结束时间", txt_RstToDate, "PN", "", "", "", "", imcseq);

            p_McIni(Mc4, true);
            imcseq = 4;
            p_SetMc("板坯号", txt_SlabNo, "PNIRL", "", "", "", "", imcseq); //0
            p_SetMc(txt_SlabSize, "RL", "", "", "", imcseq, ""); //1
            p_SetMc(txt_RollingSize, "RL", "", "", "", imcseq, ""); //2
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //3
            p_SetMc(txt_HTM, "RL", "", "", "", imcseq, ""); //4
            p_SetMc(txt_CrCd, "RL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_TrimFl, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_CrMillRatet3, "RL", "", "", "", imcseq, ""); //7
            p_SetMc(txt_CrMillRatet4, "RL", "", "", "", imcseq, ""); //8
            p_SetMc(txt_CrMillRatet5, "RL", "", "", "", imcseq, ""); //9
            p_SetMc(txt_CrMillTmpt3, "RL", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CrMillTmpt4, "RL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_CrMillTmpt5, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_CoolMth, "RL", "", "", "", imcseq, ""); //13
            p_SetMc(txt_CoolSpeed, "RL", "", "", "", imcseq, ""); //14
            p_SetMc(txt_CoolTemp, "RL", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_COOL_AVE_TEMP, "IR", "", "", "", imcseq, ""); //16
            p_SetMc(SDB_COOL_EXT_TEMP, "IR", "", "", "", imcseq, ""); //17
            p_SetMc(SDB_COOL_ENT_TEMP, "IR", "", "", "", imcseq, ""); //18
            p_SetMc(SDB_COOL_WGT, "IR", "", "", "", imcseq, ""); //19
            p_SetMc(TXT_CR_CD, "IR", "", "", "", imcseq, ""); //20
            p_SetMc(TXT_ROLLING_METHOD, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_CR_STAGE1_THK, "IR", "", "", "", imcseq, ""); //22
            p_SetMc(SDB_CR_STAGE1_TEMP, "IR", "", "", "", imcseq, ""); //23
            p_SetMc(SDB_CR_STAGE2_THK, "IR", "", "", "", imcseq, ""); //24
            p_SetMc(SDB_CR_STAGE2_TEMP, "IR", "", "", "", imcseq, ""); //25
            p_SetMc(SDB_CR_STAGE3_THK, "IR", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_CR_STAGE3_TEMP, "IR", "", "", "", imcseq, ""); //27
            p_SetMc("开轧时间", TXT_MILL_STA_TIME, "NIR", "", "", "", "", imcseq); //28
            p_SetMc("终轧时间", TXT_MILL_END_TIME, "NIR", "", "", "", "", imcseq); //29
            p_SetMc("厚度", txt_thk, "NIR", "", "", "", "", imcseq); //30
            p_SetMc("宽度", txt_wid, "NIR", "", "", "", "", imcseq); //31
            p_SetMc("长度", txt_len, "NIR", "", "", "", "", imcseq); //32
            p_SetMc("终轧温度", txt_LastTemp, "IR", "", "", "", "", imcseq); //33
            p_SetMc("班次", TXT_SHIFT, "NIR", "", "", "", "", imcseq); //34
            p_SetMc("班别", TXT_GROUP, "NIR", "", "", "", "", imcseq); //35
            p_SetMc("作业人员", TXT_EMP1, "NIR", "", "", "", "", imcseq); //36
            p_SetMc(TXT_EMP2, "NIR", "", "", "", imcseq, ""); //37
            p_SetMc(txt_Roll_Stlgrd, "R", "", "", "", imcseq, ""); //38
            p_SetMc(cal_thk, "LR", "", "", "", imcseq, ""); //39
            p_SetMc(cal_thk2, "LR", "", "", "", imcseq, ""); //40
            p_SetMc(txt_ORD_LEN_MIN, "LR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_ORD_LEN_MAX, "LR", "", "", "", imcseq, ""); //42


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("厚度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("宽度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("母板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("母板规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("钢板号码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("钢板规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //5

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("炉分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("HCR分类", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //5
            p_SetSc("钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("理论调头厚度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("板坯调头厚度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //10
            p_SetSc("轧制规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("定尺类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("是否探伤", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("出炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("在炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("装炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("序列号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //20
            p_SetSc("实设成材率", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //21
            p_SetSc("成材率差", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //22
            p_SetSc("交货期开始", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("交货期结束", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //28
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //29
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //30
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //31
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //32
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //33

            p_ScIni(ss3, Sc3, 0, false, false);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("开轧时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("终轧时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("理论调头厚度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("板坯调头厚度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("粗轧制实绩规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("粗轧制结束温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("控轧代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("轧制方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("作业人员1", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("作业人员2", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //13



            p_ScIni(ss4, Sc4, 0, false, false);
            iheadrow = 0;
            iscseq = 4;
            p_SetSc("炉座号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("成品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //3

        }

        private void CHK_CR_CD_Clk() {
            if (!CHK_CR_CD.Checked) {
                if (!CHK_NON_CR_CD.Checked) {
                    //          CHK_CR_CD.Value = ssCBChecked
                    TXT_CR_CD.Text = "";
                    CHK_CR_CD.ForeColor = Color.Black;
                    CHK_NON_CR_CD.ForeColor = Color.Black;
                }
                return;
            }

            TXT_CR_CD.Text = "1";
            CHK_CR_CD.ForeColor = Color.Red;
            CHK_CR_CD.Checked = true;
            CHK_NON_CR_CD.ForeColor = Color.Gray;
            CHK_NON_CR_CD.Checked = false;
        }


        private void CHK_NON_CR_CD_Clk() {
            if (!CHK_NON_CR_CD.Checked) {
                if (!CHK_CR_CD.Checked) {
                    //          CHK_NON_CR_CD.Value = ssCBChecked
                    TXT_CR_CD.Text = "";
                    CHK_NON_CR_CD.ForeColor = Color.Black;
                    CHK_CR_CD.ForeColor = Color.Black;
                }
                return;
            }

            TXT_CR_CD.Text = "0";

            CHK_NON_CR_CD.ForeColor = Color.Red;
            CHK_NON_CR_CD.Checked = true;

            CHK_CR_CD.ForeColor = Color.Gray;
            CHK_CR_CD.Checked = false;
        }

        private void Chk_Rolling_Auto_Clk() {

            if (!CHK_ROLLING_AUTO.Checked) {
                if (!CHK_ROLLING_OP.Checked) {
                    TXT_ROLLING_METHOD.Text = "";
                    CHK_ROLLING_AUTO.ForeColor = Color.Black;
                    CHK_ROLLING_OP.ForeColor = Color.Black;
                }
                return;
            }

            TXT_ROLLING_METHOD.Text = "0";

            CHK_ROLLING_AUTO.ForeColor = Color.Red;
            CHK_ROLLING_AUTO.Checked = true;

            CHK_ROLLING_OP.ForeColor = Color.Gray;
            CHK_ROLLING_OP.Checked = false;

        }

        private void Chk_Rolling_Op_Clk() {

            if (!CHK_ROLLING_OP.Checked) {
                if (!CHK_ROLLING_AUTO.Checked) {
                    TXT_ROLLING_METHOD.Text = "";
                    CHK_ROLLING_OP.ForeColor = Color.Black;
                    CHK_ROLLING_AUTO.ForeColor = Color.Black;
                }
                return;
            }

            TXT_ROLLING_METHOD.Text = "1";

            CHK_ROLLING_OP.ForeColor = Color.Red;
            CHK_ROLLING_OP.Checked = true;

            CHK_ROLLING_AUTO.ForeColor = Color.Gray;
            CHK_ROLLING_AUTO.Checked = false;

        }

        private void cmd_LPass_Clk() {

            if (GeneralCommon.Gf_MessConfirm("您确定板坯号 " + txt_SlabNo.Text + "仅通过粗轧机吗？", "Q", "空过指示确定")) {
                if (Gp_Process_Exec("A") == "") {
                    GeneralCommon.Gp_MsgBoxDisplay("空过处理完成 ！", "I", "空过");
                    Form_Ref();
                } else {
                    GeneralCommon.Gp_MsgBoxDisplay("空过处理失败，请确认 ！", "I", "空过");
                }
            }

        }

        private void cmd_Pass_Clk()
        {
            if (GeneralCommon.Gf_MessConfirm("您确定要对板坯号" + txt_SlabNo.Text + "做轧废处理吗？", "Q", "轧废指示确定"))
            {
                if (Gp_Process_Exec("B") == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("轧废处理完成 ！", "I", "空过");
                    Form_Ref();
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("轧废处理失败，请确认 ！", "I", "空过");
                }
            }
        }

        //调用后台包程序
        private string Gp_Process_Exec(string Process_Type) {

            string[] Para1 = new string[2];
            string[] Para2 = new string[5];

            // 发送
            Para1[0] = txt_SlabNo.Text.Trim();
            Para1[1] = TXT_CB.Text.Trim();
            if (Process_Type == "A") {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGc2000C.P_PASS", Para1)) {
                    return "";
                } else {
                    return "空过处理失败";
                }
            }

            // 取消
            Para2[0] = txt_SlabNo.Text.Trim();
            Para2[1] = TXT_SHIFT.Text.Trim();
            Para2[2] = TXT_GROUP.Text.Trim();
            Para2[3] = TXT_EMP1.Text.Trim();
            Para2[4] = TXT_CB.Text.Trim();

            if (Process_Type == "B") {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGC2010C.P_SCRAP", Para2)) {
                    return "";
                } else {
                    return "轧废处理失败";
                }
            }

            return "";
        }


        private void CGC2000C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGC2000NC";
            Form_Define();

            tab1.SelectedIndex = 0;

            Form_Ref();

            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_EMP1.Text = GeneralCommon.sUserID;

            if (base.sAuthority.Substring(0, 3) == "111") {
                cmd_Pass.Enabled = true;
                //SSCommand1.Enabled = true;
                cmd_LPass.Enabled = true;
            } else {
                cmd_Pass.Enabled = false;
                //SSCommand1.Enabled = false;
                cmd_LPass.Enabled = false;
            }
        }

        public override void Form_Ref() {

            int iRow;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            string sUrgnt_Fl;
            string sUst_Fl;
            string sFlag;
            string sexport;
            string sOrdcnt;


            unlockSpread(ss2);


            sCurDate = DateTime.Now.ToString("yyyyMM");

            if (tab1.SelectedIndex == 0) {

                p_Ref(0, 2, true, false);
                p_Ref(0, 4, true, false);

                if (ss2.ActiveSheet.RowCount <= 0) return;//防止报错 VB没有这段代码

                if (ss2.ActiveSheet.Cells[0, 0].Text.ToString() != "") {
                    txt_SlabNo.Text = ss2.ActiveSheet.Cells[0, 0].Text.ToString();

                    if (p_Ref(1, 0, true, false) & p_Ref(2, 1, true, false)) {

                        TXT_MILL_STA_TIME.Text = Gf_DTSet("", "X");
                        TXT_SHIFT.Text = Gf_ShiftSet3("");
                        TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text, Gf_DTSet("", "X"));
                        TXT_EMP1.Text = GeneralCommon.sUserID;

                    }

                } else {
                    txt_SlabNo.Text = "";
                }
                //超交货期用红色显示 add by liqian 2012-06-11
                {
                    for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++) {
                        sDel_To_Date = ss2.ActiveSheet.Cells[iRow - 1, SS2_DEL_TO_DATE].Text.ToString().Substring(0, 6);
                        sUrgnt_Fl = ss2.ActiveSheet.Cells[iRow-1, SS2_URGNT_FL].Text.ToString().Trim();
                        if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate)) {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        //紧急订单绿色显示 add by liqian 2012-08-15
                        if (sUrgnt_Fl == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);

                        }
                        //是否探伤 add by liqian 2013-04-08
                        sUst_Fl = ss2.ActiveSheet.Cells[iRow - 1, SS2_UST_FL].Text.ToString().Trim();
                        if (sUst_Fl == "是") {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_UST_FL, SS2_UST_FL, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                        }
                        //是否定制配送
                        sFlag = ss2.ActiveSheet.Cells[iRow - 1, SS2_FLAG].Text.ToString().Trim();
                        if (sFlag == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        //是否出口订单
                        sexport = ss2.ActiveSheet.Cells[iRow - 1, SS2_EXPORT].Text.ToString().Trim();
                        if (sexport == "Y") {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, SSP1.BackColor, Color.White);
                        }
                        //是否一坯多订单
                        //ss2.ActiveSheet.Cells[iRow - 1, SS2_ORD_CNT].Value.ToString();
                        sOrdcnt = ss2.ActiveSheet.Cells[iRow - 1, SS2_ORD_CNT].Text.ToString();
                        if (sOrdcnt!=""&&Convert.ToInt32(sOrdcnt) > 1)//解决为空导致无法转换报错的问题
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP2.BackColor);

                        }
                    }
                }

            } else if (tab1.SelectedIndex == 1) {

                p_Ref(3, 3, true, false);
                if (ss3.ActiveSheet.RowCount <= 0) return;//防止报错 VB版本没有这段代码
                if (ss3.ActiveSheet.Cells[0, 0].Text.ToString() != "") {

                    txt_SlabNo.Text = ss3.ActiveSheet.Cells[0, 0].Text.ToString();

                    if (p_Ref(4, 0, true, false) & p_Ref(2, 1, true, false)) {}

                }

            }

            lockSpread(ss2);

            //    Call MDIMain.FormMenuSetting(Me, FormType, "RE", sAuthority)
        }


        public override void Form_Pro() {

            String SMESG;

            if (!Gp_DateCheck(TXT_MILL_STA_TIME.Text, "")) {
                SMESG = " 请正确输入开轧时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            if (!Gp_DateCheck(TXT_MILL_END_TIME.Text, "")) {
                SMESG = " 请正确输入终轧时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            p_Pro(1, 0, true, true);
            Form_Ref();
            TXT_MILL_END_TIME.Text = "";
            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text, Gf_DTSet("", "X"));
            TXT_EMP1.Text = GeneralCommon.sUserID;
            //    Dim sMesg As String
            //    Dim Temp_no As String
            //
            //    Temp_no = CBO_SLAB_NO.Text
            //
            //    TXT_UPD_EMP = sUserID
            //
            //    Select Case SSTab1.Tab
            //
            //          Case 0
            //
            //                 If Not Gp_DateCheck(TXT_MILL_STA_TIME) Then
            //                      sMesg = " 请正确输入开轧时间 ！"
            //                      Call Gp_MsgBoxDisplay(sMesg)
            //                      Exit Sub
            //                 End If
            //
            //                 If TXT_MILL_STA_TIME.RawData = "" And TXT_MILL_END_TIME.RawData = "" Then
            //                      sMesg = " 请输入开轧时间 ！"
            //                      Call Gp_MsgBoxDisplay(sMesg)
            //                      Exit Sub
            //                 ElseIf TXT_MILL_STA_TIME.RawData = "" And TXT_MILL_END_TIME.RawData <> "" Then
            //                      sMesg = " 请首先输入开轧时间 ！"
            //                      Call Gp_MsgBoxDisplay(sMesg)
            //                      Exit Sub
            //                 ElseIf TXT_MILL_STA_TIME.RawData <> "" And TXT_MILL_END_TIME.RawData <> "" Then
            //                        If Not Gp_DateCheck(TXT_MILL_END_TIME) Then
            //                             sMesg = " 请正确输入终轧时间 ！"
            //                             Call Gp_MsgBoxDisplay(sMesg)
            //                             Exit Sub
            //                        End If
            //                        If Val(TXT_MILL_STA_TIME.RawData) - Val(TXT_MILL_END_TIME.RawData) > 0 Then
            //                             sMesg = " 终轧时间应大于开轧时间，请正确输入时间信息 ！"
            //                             Call Gp_MsgBoxDisplay(sMesg)
            //                             Exit Sub
            //                        End If
            //                 End If
            //
            //                 If Trim(TXT_CR_CD) = "1" Then
            //                    If Trim(SDB_CR_STAGE1_THK) = "" And Trim(SDB_CR_STAGE1_TEMP) = "" And Trim(SDB_CR_STAGE1_TIME) = "" Then
            //                        sMesg = " 请输入控轧一阶段厚度，温度，待轧时间 ！"
            //                        Call Gp_MsgBoxDisplay(sMesg)
            //                        Exit Sub
            //                    End If
            //                 Else
            //                    SDB_CR_STAGE1_THK = ""
            //                    SDB_CR_STAGE1_TEMP = ""
            //                    SDB_CR_STAGE1_TIME = ""
            //                    SDB_CR_STAGE2_THK = ""
            //                    SDB_CR_STAGE2_TEMP = ""
            //                    SDB_CR_STAGE2_TIME = ""
            //                    SDB_CR_STAGE3_THK = ""
            //                    SDB_CR_STAGE3_TEMP = ""
            //                    SDB_CR_STAGE3_TIME = ""
            //                 End If
            //                 If Gf_Mc_Authority(sAuthority, Mc1) Then
            //                   ' txt_ins_emp.Text = sUserID
            //                   If Gf_Ms_Process(M_CN1, Mc1, sAuthority) Then Call MDIMain.FormMenuSetting(Me, FormType, "SE", sAuthority)
            //                 End If
            //'                 Call Gf_Mill_ComboAdd(M_CN1, CBO_SLAB_NO, "CB")
            //                ' Call Gf_Common_ComboSet(M_CN1, CBO_SLAB_NO, "CA")
            //                 CBO_SLAB_NO.Text = Temp_no
            //          Case 1
            //                 If TXT_CUTEND_CD.Text = "Y" And TXT_COMFRM.Text = "2" Then
            //                    sMesg = " （缺号母板确定） 与 （母板剪切结束确定）不能同时操作 ！"
            //                    Call Gp_MsgBoxDisplay(sMesg)
            //                    Exit Sub
            //                 End If
            //
            //                 If TXT_CUTEND_CD.Text = "Y" Then
            //                    sMesg = " 确定此轧件剪切母板结束 ？ "
            //                 ElseIf TXT_COMFRM.Text = "2" Then
            //                    sMesg = " 确定以下母板缺号 ？ "
            //                 Else
            //                    If Gf_Mc_Authority(sAuthority, Mc1) Then
            //                       If Gf_Ms_Process(M_CN1, Mc2, sAuthority) Then Call MDIMain.FormMenuSetting(Me, FormType, "SE", sAuthority)
            //                    End If
            //                    Exit Sub
            //                 End If
            //                 If Gp_MsgBox(sMesg, "C") = 6 Then
            //                    If Gf_Mc_Authority(sAuthority, Mc1) Then
            //                       If Gf_Ms_Process(M_CN1, Mc2, sAuthority) Then Call MDIMain.FormMenuSetting(Me, FormType, "SE", sAuthority)
            //                    End If
            //                 End If

            //   End Select

        }

        private void ss2_Clk(int col, int row) {
            if (ss2.ActiveSheet.RowCount > 0) {
                txt_SlabNo.Text = ss2.ActiveSheet.Cells[row, 0].Text.ToString();
                p_Ref(1, 0, true, false);
                p_Ref(2, 1, true, false);
                TXT_MILL_STA_TIME.Text = Gf_DTSet("", "X");
                //TXT_MILL_END_TIME.RawData = Gf_DTSet(M_CN1, , "X")

                TXT_SHIFT.Text = Gf_ShiftSet3("");
                TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text, Gf_DTSet("", "X"));
                TXT_EMP1.Text = GeneralCommon.sUserID;

            }
        }

        private void ss2_DblClk(int col, int row) {
            if (ss2.ActiveSheet.RowCount > 0) {
                txt_SlabNo.Text = ss2.ActiveSheet.Cells[row, 0].Text.ToString();
                p_Ref(1, 0, true, false);
                p_Ref(2, 1, true, false);
                TXT_MILL_STA_TIME.Text = Gf_DTSet("", "X");
                //TXT_MILL_END_TIME.RawData = Gf_DTSet(M_CN1, , "X")

                TXT_SHIFT.Text = Gf_ShiftSet3("");
                TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text, Gf_DTSet("", "X"));
                TXT_EMP1.Text = GeneralCommon.sUserID;

            }
        }

        private void ss3_DblClk(int col, int row) {
            if (ss3.ActiveSheet.RowCount > 0) {
                txt_SlabNo.Text = ss3.ActiveSheet.Cells[row, 0].Text.ToString();
                p_Ref(4, 0, true, false);
                p_Ref(2, 1, true, false);

            }
        }

        //Private void SSCommand1_Click(){}
        //发现控件被移出，该功能不实现，具体实现方式请参考VB CGC2000C该事件内容

        private void tab1_Clk() {
            if (tab1.SelectedIndex == 1) {
                TXT_SHIFT.Text = Gf_ShiftSet3("");
                if (TXT_SHIFT.Text == "1") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "000001";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081459";
                } else if (TXT_SHIFT.Text == "2") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081500";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "155959";
                } else if (TXT_SHIFT.Text == "3") {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "160000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "235959";
                }
            } else if (tab1.SelectedIndex == 0) {
                TXT_MILL_STA_TIME.Text = Gf_DTSet("", "X");
                //Format(Now, "YYYYMMDDHHMMSS")
            }
        }


        private void TXT_MILL_STA_TIME_DblClk() {
            TXT_MILL_STA_TIME.Text = Gf_DTSet("", "X");
            //Format(Now, "YYYYMMDDHHMMSS")
        }

        private void TXT_MILL_END_TIME_DblClk() {
            TXT_MILL_END_TIME.Text = Gf_DTSet("", "X");
            //Format(Now, "YYYYMMDDHHMMSS")
        }

        private void txt_RstFormDate_DblClk() {
            txt_RstFormDate.Text = Gf_DTSet("", "X");
            txt_RstToDate.Text = Gf_DTSet("", "X");
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

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        #endregion

        private void CHK_CR_CD_CheckedChanged(object sender, EventArgs e)
        {
            CHK_CR_CD_Clk();
        }

        private void CHK_NON_CR_CD_CheckedChanged(object sender, EventArgs e)
        {
            CHK_NON_CR_CD_Clk();
        }

        private void CHK_ROLLING_AUTO_CheckedChanged(object sender, EventArgs e)
        {
            Chk_Rolling_Auto_Clk();
        }

        private void CHK_ROLLING_OP_CheckedChanged(object sender, EventArgs e)
        {
            Chk_Rolling_Op_Clk();
        }

        private void cmd_LPass_Click(object sender, EventArgs e)
        {
            cmd_LPass_Clk();
        }

        private void cmd_Pass_Click(object sender, EventArgs e)
        {
            cmd_Pass_Clk();

        }

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            ss2_Clk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

        private void ss3_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss3_DblClk(e.Column, e.Row);
        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab1_Clk();
        }

        private void TXT_MILL_STA_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_MILL_STA_TIME_DblClk();
        }

        private void TXT_MILL_END_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_MILL_END_TIME_DblClk();
        }

        private void txt_RstFormDate_DoubleClick(object sender, EventArgs e)
        {
            txt_RstFormDate_DblClk();
        }


    }
}
