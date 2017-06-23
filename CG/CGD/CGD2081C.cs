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
    public partial class CGD2081C: CommonClass.FORMBASE {
        public CGD2081C() {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        string sCheck;

        const int SPD_LINE1 = 0;
        const int SPD_LINE2 = 1;
        const int SPD_PLATE_NO = 2;
        const int SPD_LOT_NO = 3;
        const int SPD_CUT_NO = 4;
        const int SPD_THK = 5;
        const int SPD_WID = 6;
        const int SPD_LEN = 7;
        const int SPD_WGT = 8;
        const int SPD_ACT_THK = 9;
        const int SPD_ACT_WID = 10;
        const int SPD_ACT_LEN = 11;
        const int SPD_LAST_YN = 12;
        const int SPD_SIZE_KND = 13;
        const int SPD_TRIM_FL = 14;
        const int SPD_UST_FL = 15;
        const int SPD_APLY_STDSPEC = 16;
        const int SPD_APLY_STDSPEC_NEW = 17;
        const int SPD_INSP_CD = 18;
        const int SPD_GRID_YN = 19;
        const int SPD_INSP_CD1 = 20;
        const int SPD_INSP_CD2 = 21;
        const int SPD_INSP_CD3 = 22;
        const int SPD_INSP_CD4 = 23;
        const int SPD_SURF_YN = 24;
        const int SPD_SURF_GRD = 26;
        const int SPD_SURF_GRD_DET = 27;
        const int SPD_PROD_DATE = 28;
        const int SPD_EMP_CD = 29;
        const int SPD_THK_MIN = 30;
        const int SPD_THK_MAX = 31;
        const int SPD_WID_MIN = 33;
        const int SPD_WID_MAX = 34;
        const int SPD_LEN_MIN = 35;
        const int SPD_LEN_MAX = 36;
        const int SPD_DEL_DATE_FR = 49;
        const int SPD_DEL_DATE_TO = 50;
        const int SPD_ORD_CNT = 51;
        const int SPD_ORD_REMARK = 52;
        const int SPD_PROD_REMARK = 53;
        const int SPD_INS_MAN = 54;
        const int SPD_INSP_WAVE = 55;
        const int SPD_INSP_VERT_DEG = 56;
        const int SPD_INSP_RECT_DEG = 57;
        const int SPD_INS_MAN_TAIL = 58;
        const int SPD_TOP_GRID_GRD = 59;
        const int SPD_TOP_GRID_YRD = 60;
        const int SPD_TOP_GRID_DEEP = 61;
        const int SPD_BOT_GRID_GRD = 62;
        const int SPD_BOT_GRID_YRD = 63;
        const int SPD_BOT_GRID_DEEP = 64;
        const int SPD_GRID_TIME = 65;
        const int SPD_INSP_DIAGONAL1 = 66;
        const int SPD_INSP_DIAGONAL2 = 67;
        const int SPD_CL_FL = 68;
        const int SPD_LOC = 69;
        const int SPD_INSP_WAVE1 = 70;
        const int SPD_FLAG_FL = 71;
        const int SPD_EXPORT = 72;
        const int SPD_PLATE_COLOR = 73;
        const int SPD_THK1 = 79;
        const int SPD_THK2 = 80;
        const int SPD_THK3 = 81;
        const int SPD_THK4 = 82;
        const int SPD_THK5 = 83;
        const int SPD_THK6 = 84;
        const int SPD_FLAW_YN = 85;

        protected override void p_SubFormInit() {

            int imcseq;

            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("工厂代码", txt_plt, "PNL", "", "", "", "", imcseq); //0
            //p_SetMc("作业线", txt_plt_name, "I", "", "", "", "", imcseq); //1
            p_SetMc("钢板号", txt_plate_no, "P", "", "", "", "", imcseq); //1
            p_SetMc("开始时间", udt_date_fr, "P", "", "", "", "", imcseq); //2
            p_SetMc("结束时间", udt_date_to, "P", "", "", "", "", imcseq); //3
            p_SetMc("产线", txt_line, "P", "", "", "", "", imcseq); //4
            p_SetMc("标准号", txt_stdspec, "P", "", "", "", "", imcseq); //5
            p_SetMc("轧批号", txt_lot_no, "P", "", "", "", "", imcseq); //6
            p_SetMc("钢板状态", txt_rec_sts, "", "", "", "", "", imcseq); //7
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq); //8
           
            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("#1", "C", "", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("#2", "C", "", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //10
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //11
            p_SetSc("尾板", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("切边", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("改判标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("改判缺陷", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("修磨", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("1", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("2", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("1", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("2", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("合格", "C", "", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("等级", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("内部等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("生产日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("检查人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("厚度下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //30
            p_SetSc("厚度上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //31
            p_SetSc("同板差", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //32
            p_SetSc("宽度下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //33
            p_SetSc("宽度上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //34
            p_SetSc("长度下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //35
            p_SetSc("长度上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //36
            p_SetSc("镰刀弯总最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //37
            p_SetSc("镰刀弯每最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //38
            p_SetSc("镰刀弯类型", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //39
            p_SetSc("不平度总最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //40
            p_SetSc("不平度每单位最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //41
            p_SetSc("不平度类型", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //42
            p_SetSc("直角度类型", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //43
            p_SetSc("直角度最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //44
            p_SetSc("长边切斜度最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //45
            p_SetSc("宽边切斜度最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //46
            p_SetSc("厚度切斜度最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //47
            p_SetSc("同板差最大值", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //48
            p_SetSc("开始", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //49
            p_SetSc("结束", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //50
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //51
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow, "L"); //52
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L"); //53
            p_SetSc("检验工（头部）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //54
            p_SetSc("不平度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //55
            p_SetSc("镰刀弯", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //56
            p_SetSc("切斜", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //57
            p_SetSc("检验工（尾部）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //58
            p_SetSc("判定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //59
            p_SetSc("面积比", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //60
            p_SetSc("深度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //61
            p_SetSc("判定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //62
            p_SetSc("面积比", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //63
            p_SetSc("深度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //64
            p_SetSc("修磨时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //65
            p_SetSc("对角线1", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //66
            p_SetSc("对角线2", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //67
            p_SetSc("矫直指示", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //68
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //69
            p_SetSc("不平度1", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //70
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //71
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //72
            p_SetSc("钢板颜色", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //73
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //74
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //75
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //76
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //77
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //78
            p_SetSc("厚度1", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //79
            p_SetSc("厚度2", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //80
            p_SetSc("厚度3", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //81
            p_SetSc("厚度4", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //82
            p_SetSc("厚度5", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //83
            p_SetSc("厚度6", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //84
            p_SetSc("下表是否检验", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //85

            iheadrow = 0;
            p_spanSpread("公称尺寸", 5, 8, iscseq, iheadrow, 1);
            p_spanSpread("实测尺寸", 9, 11, iscseq, iheadrow, 1);
            p_spanSpread("上表面缺陷", 20, 21, iscseq, iheadrow, 1);
            p_spanSpread("下表面缺陷", 22, 23, iscseq, iheadrow, 1);
            p_spanSpread("订单交付条件", 30, 47, iscseq, iheadrow, 1);
            p_spanSpread("交货期", 49, 50, iscseq, iheadrow, 1);
            p_spanSpread("上表面修磨", 59, 61, iscseq, iheadrow, 1);
            p_spanSpread("下表面修磨", 62, 64, iscseq, iheadrow, 1);

        }

        private void CGD2081C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2081NC";
            Form_Define();
           
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LOT_NO, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ACT_THK, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ACT_WID, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ACT_LEN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_UST_FL, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LAST_YN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_GRID_YN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_APLY_STDSPEC_NEW, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_CD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_CD1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_CD2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_CD3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_CD4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_SURF_YN, true);
            //Call Gp_Sp_ColHidden(ss1, SPD_SURF_GRD, True)
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_SURF_GRD_DET, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_PROD_DATE, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_EMP_CD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_WAVE, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_VERT_DEG, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_RECT_DEG, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_TOP_GRID_GRD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_TOP_GRID_YRD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_TOP_GRID_DEEP, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_BOT_GRID_GRD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_BOT_GRID_YRD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_BOT_GRID_DEEP, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_GRID_TIME, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_DIAGONAL1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_DIAGONAL2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LOC, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_INSP_WAVE1, true);

            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK5, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_THK6, true);

            txt_plt.Text = "C3";

            txt_line.Text = "1";
            txt_rec_sts.Text = "1";
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);
            opt_line1.Checked = true;
            opt_line3.Checked = true;
            opt_CHK_PRD_GRD0.Checked = true;

        }

        public override bool Form_Cls() {
            
             base.Form_Cls();
             txt_plt.Text = "C3";
             //        Call txt_plt_KeyUp(0, 0)
             txt_line.Text = "1";
             txt_rec_sts.Text = "1";
             opt_line3.Checked = true;
             txt_stdspec_chg.Text = "";
             TXT_REMARK.Text = "";
             //2012-3-14 Modify by LiChao
             TXT_sUserID.Text = "";
             TXT_sUserID_Tail.Text = "";
             txt_Color_code.Text = "";
             return true;
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

           

            p_Ref(2, 1, true, false);

            if (ss1.ActiveSheet.RowCount > 0)
            {

                txt_plate_no.Text = ss1.ActiveSheet.Cells[0, 0].Text;

                //for (i = 0; i <= 17; i++) {
                //CHK_PART = Type.GetType("CHK_PART"+i);
                //PropertyInfo CHK_PART_TEXT =   CHK_PART.GetProperty("Text");
                //CHK_PART_TEXT.SetValue(obj, "zhx", null);
                //}
            }

            if (txt_plate_no.Text.Length == 14)
            {
                if (p_Ref(1, 0, true, false))
                {

                    if (TXT_SURF_GRD.Text == "Y")
                    {
                        opt_CHK_SUR_GRD0.Checked = true;
                    }
                    else
                    {
                        opt_CHK_SUR_GRD1.Checked = true;
                    }


                    if (TXT_INSP_MAIN_GRD.Text.Length == 1)
                    {
                        if (TXT_INSP_MAIN_GRD.Text == "7")
                        {
                            opt_CHK_PRD_GRD5.Checked = true;
                        }
                        else if (TXT_INSP_MAIN_GRD.Text == "5")
                        {
                            opt_CHK_PRD_GRD4.Checked = true;
                        }
                        else if (TXT_INSP_MAIN_GRD.Text == "4")
                        {
                            opt_CHK_PRD_GRD3.Checked = true;
                        }
                        else if (TXT_INSP_MAIN_GRD.Text == "3")
                        {
                            opt_CHK_PRD_GRD2.Checked = true;
                        }
                        else if (TXT_INSP_MAIN_GRD.Text == "2")
                        {
                            opt_CHK_PRD_GRD1.Checked = true;
                        }
                        else if (TXT_INSP_MAIN_GRD.Text == "1")
                        {
                            opt_CHK_PRD_GRD0.Checked = true;
                        }
                    }
                    if (TXT_INSP_OCCR_TIME.Text == "")
                    {
                        TXT_INSP_OCCR_TIME.Text = Gf_DTSet("", "X");
                    }
                    //TXT_INSP_MAN = sUserID
                    //ADD BY LIQIAN AT 20120322

                    TXT_EMP_CD1.Text = GeneralCommon.sUserID;

                    //Call Display_Data_Edit
                }
            }

            {
                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();
                    sFlag = ss1.ActiveSheet.Cells[iCount - 1, SS1_FLAG].Text.Trim();
                    sexport = ss1.ActiveSheet.Cells[iCount - 1, SS1_EXPORT].Text.Trim();
                    if (simpcont == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP1.BackColor, Color.White);
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP1.BackColor, Color.White);
                    }

                    //是否定制配送
                    if (sFlag == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                    }
                    //是否出口订单

                    if (sexport == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount - 1, iCount - 1, SSP5.BackColor, Color.White);
                    }
                }
            }

            lockSpread(ss1);

            CHK_CL_FL.Checked = false;

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

            if (SSCHK_GRID_YN.Checked) {
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
                        AdoRs.MoveNext();
                    }
                }

                //在这里不需要关闭对象，因为该方法是在查询过程中调用，关闭对象会导致框架查询报错 韩超

                //GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return Plate_Wgt;
            } catch (Exception ex) {
               // if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return 0;
            }

        }

        private void SDT_PROD_DATE_DblClk() {
            udt_date_fr.Text = Gf_DTSet("D", "");
            udt_date_to.Text = Gf_DTSet("D", "");
        }
        private void SDT_PROD_TO_DATE_DblClk() {
            udt_date_to.Text = Gf_DTSet("D", "");
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
            if (!SSCHK_GRID_YN.Checked) {
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
                SSCHK_GRID_YN.Checked = true;

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
            { return; }

            // THICK GRAND CHECK
            if (SDB_THK.NumValue >= SDB_MS_THK.NumValue + SDB_INSP_THK_MN.NumValue & SDB_THK.NumValue <= SDB_MS_THK.NumValue + SDB_INSP_THK_MX.NumValue) {
                TXT_INSP_THK_GRD.Text = "Y";
                SDB_THK.ForeColor = Color.Black;
            } else {
                TXT_INSP_THK_GRD.Text = "N";
                SDB_THK.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // WIDTH GRAND CHECK
            if (SDB_WID.NumValue >= SDB_MS_WID.NumValue + SDB_INSP_WID_MN.NumValue & SDB_WID.NumValue <= SDB_MS_WID.NumValue + SDB_INSP_WID_MX.NumValue) {
                TXT_INSP_WID_GRD.Text = "Y";
                SDB_WID.ForeColor = Color.Black;
            } else {
                TXT_INSP_WID_GRD.Text = "N";
                SDB_WID.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // LENGTH GRAND CHECK
            if (SDB_LEN.NumValue >= SDB_MS_LEN.NumValue + SDB_INSP_LEN_MN.NumValue & SDB_LEN.NumValue <= SDB_MS_LEN.NumValue + SDB_INSP_LEN_MX.NumValue) {
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

            txt_plate_no.Text = ss1.ActiveSheet.Cells[row, 0].Text;
            SSCHK_GRID_YN.Checked = false;

            if (txt_plate_no.Text.Length == 14) {

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
