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

namespace CG
{
    public partial class CGD2081C : CommonClass.FORMBASE
    {
        public CGD2081C()
        {
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

        protected override void p_SubFormInit()
        {

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

        public override bool Form_Cls()
        {

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

        public override void Form_Ref()
        {
            int iCount;
            string sPlateNo;
            int iRow;
            int sord_cnt;
            string sFlag;
            string sexport;

            int inum;
            int lRow;

            string sCurDate;
            string sDel_To_Date;

            sCurDate = System.DateTime.Now.ToString("yyyyMM");

            //    If Gf_Sp_ProceExist(sc1.Item("Spread")) Then Exit Sub

            p_Ref(1, 1, true, true);

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                sPlateNo = ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text;
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text.Substring(0, 12) == sPlateNo.Substring(0, 12)) { }
                else
                {
                    ss1.ActiveSheet.Cells[iCount - 2, SPD_LAST_YN].Text = "1";
                }
            }
            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {

                sord_cnt = Convert.ToInt32(ss1.ActiveSheet.Cells[iRow - 1, SPD_ORD_CNT].Text);

                if (sord_cnt > 1)
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP1.BackColor);
                }
            }

            //超交货期用红色显示 add by liqian 2012-07-23
            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                sDel_To_Date = ss1.ActiveSheet.Cells[iRow - 1, SPD_DEL_DATE_TO].Text.Substring(0, 6);
                if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate))
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                }
            }

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                //是否定制配送
                sFlag = ss1.ActiveSheet.Cells[iRow - 1, SPD_FLAG_FL].Text;
                if (sFlag == "Y")
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SPD_PLATE_NO, SPD_PLATE_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                }
                //是否出口订单
                sexport = ss1.ActiveSheet.Cells[iRow - 1, SPD_EXPORT].Text;
                if (sexport == "Y")
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SPD_PLATE_NO, SPD_PLATE_NO, iRow - 1, iRow - 1, SSP5.BackColor, Color.White);
                }
            }

        }

        private void SSCHK_GRID_YN_Clk()
        {
            if (SSCHK_GRID_YN.Checked == false)
            {
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
                TXT_GRID_TIME.Enabled = false;
                TXT_GRID_TIME.Text = "";

                //        CHK_NEXT_PRC(1).Enabled = True
            }
            else
            {
                CHK_TOP_GRD0.Enabled = true;
                CHK_TOP_GRD1.Enabled = true;
                CHK_BOT_GRD0.Enabled = true;
                CHK_BOT_GRD1.Enabled = true;
                SDB_TOP_GRID_YRD.Enabled = true;
                SDB_BOT_GRID_YRD.Enabled = true;
                SDB_TOP_GRID_DEEP.Enabled = true;
                SDB_BOT_GRID_DEEP.Enabled = true;
                TXT_GRID_TIME.Enabled = true;

                TXT_GRID_TIME.Text = Gf_DTSet("", "X");

                CHK_TOP_GRD0.Checked = true;
                //CHK_TOP_GRD_Click0);
                CHK_BOT_GRD0.Checked = true;
                //CHK_BOT_GRD_Click(0);

            }
        }

        private void CHK_TOP_GRD_Clk()
        {

            if (sCheck != "")
                return;

            sCheck = "**";

            if (!CHK_TOP_GRD0.Checked &&!CHK_TOP_GRD1.Checked)
            {
                TXT_TOP_GRID_GRD.Text = "";
                this.ForeColor = ColorTranslator.FromHtml("#808080");
                sCheck = "";
                return;
            }

            if (CHK_TOP_GRD0.Checked)
            {
                CHK_TOP_GRD0.ForeColor = Color.Red;
                CHK_TOP_GRD1.ForeColor = ColorTranslator.FromHtml("#808080");
            }
            else
            {
                CHK_TOP_GRD1.ForeColor = Color.Red;
                CHK_TOP_GRD0.ForeColor = ColorTranslator.FromHtml("#808080");
            }

            TXT_TOP_GRID_GRD.Text = this.Tag.ToString();
            
            sCheck = "";

        }

        private void CHK_BOT_GRD_Clk()
        {

            if (sCheck != "")
                return;

            sCheck = "**";

            if (!CHK_BOT_GRD0.Checked && !CHK_BOT_GRD1.Checked)
            {
                TXT_TOP_GRID_GRD.Text = "";
                this.ForeColor = ColorTranslator.FromHtml("#808080");
                sCheck = "";
                return;
            }

            if (CHK_BOT_GRD0.Checked)
            {
                CHK_BOT_GRD0.ForeColor = Color.Red;
                CHK_BOT_GRD1.ForeColor = ColorTranslator.FromHtml("#808080");
            }
            else
            {
                CHK_BOT_GRD1.ForeColor = Color.Red;
                CHK_BOT_GRD0.ForeColor = ColorTranslator.FromHtml("#808080");
            }

            TXT_BOT_GRID_GRD.Text = this.Tag.ToString();

            sCheck = "";

        }

        public override void Form_Pro()
        {

            int iRow;
            string SMESG;

            string sMark_no;
            string sPlate_no;
            string sThk;
            string sWid;
            string sLen;
            string sWgt;
            string sSpec;
            string sStdspec_YY;

            if (SSCHK_GRID_YN.Checked)
            {
                if (!Gp_DateCheck(TXT_GRID_TIME.Text, ""))
                {
                    SMESG = " 请正确输入修磨时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
                if (TXT_TOP_GRID_GRD.Text == "")
                {
                    SMESG = " 请正确输入上表面修磨后判定 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
                if (TXT_BOT_GRID_GRD.Text == "")
                {
                    SMESG = " 请正确输入下表面修磨后判定 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }

            if (ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.ActiveRowIndex, 0].Text != "修改")
            {
                SMESG = "请选择钢板号";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            int rowIndex = ss1.ActiveSheet.ActiveRowIndex;

            ss1.ActiveSheet.Cells[rowIndex, SPD_THK].Text = SDB_THK.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_WID].Text = SDB_WID.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_LEN].Text = SDB_LEN.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_ACT_THK].Text = SDB_ACT_THK.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_ACT_WID].Text = SDB_ACT_WID.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_ACT_LEN].Text = SDB_ACT_LEN.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK_MIN].Text = SDB_INSP_THK_MN.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK_MAX].Text = SDB_INSP_THK_MX.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_WID_MIN].Text = SDB_INSP_WID_MN.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_WID_MAX].Text = SDB_INSP_WID_MX.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_LEN_MIN].Text = SDB_INSP_LEN_MN.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_LEN_MAX].Text = SDB_INSP_LEN_MX.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_CD].Text = TXT_INSP_FLAW5.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_CD1].Text = TXT_INSP_FLAW0.Text;
            //ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_CD2].Text = TXT_INSP_FLAW1.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_CD3].Text = TXT_INSP_FLAW3.Text;
            //ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_CD4].Text = TXT_INSP_FLAW4.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_APLY_STDSPEC_NEW].Text = txt_stdspec_chg.Text;
            if (SSCHK_LAST_YN.Checked)
            {
                ss1.ActiveSheet.Cells[rowIndex, SPD_LAST_YN].Text = "True";
            }
            else
            {
                ss1.ActiveSheet.Cells[rowIndex, SPD_LAST_YN].Text = "False";
            }
            ss1.ActiveSheet.Cells[rowIndex, SPD_SIZE_KND].Text = TXT_SIZE_KND.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_TRIM_FL].Text = TXT_TRIM_FL.Text;
            if (SSCHK_GRID_YN.Checked)
            {
                ss1.ActiveSheet.Cells[rowIndex, SPD_GRID_YN].Text = "Y";
            }
            else
            {
                ss1.ActiveSheet.Cells[rowIndex, SPD_GRID_YN].Text = "N";
            }
            ss1.ActiveSheet.Cells[rowIndex, SPD_PROD_REMARK].Text = TXT_REMARK.Text;

            ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text = TXT_INSP_MAIN_GRD.Text;
            if (ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "1" & ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "2" & ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "3" & ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "4" & ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "5" & ss1.ActiveSheet.Cells[rowIndex, SPD_SURF_GRD].Text != "7")
            {
                GeneralCommon.Gp_MsgBoxDisplay("表面等级输入错误，请确认", "I", "");
                return;
            }
            ss1.ActiveSheet.Cells[rowIndex, SPD_TOP_GRID_GRD].Text = TXT_TOP_GRID_GRD.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_TOP_GRID_YRD].Text = SDB_TOP_GRID_YRD.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_TOP_GRID_DEEP].Text = SDB_TOP_GRID_DEEP.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_BOT_GRID_GRD].Text = TXT_BOT_GRID_GRD.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_BOT_GRID_YRD].Text = SDB_BOT_GRID_YRD.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_BOT_GRID_DEEP].Text = SDB_BOT_GRID_DEEP.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_GRID_TIME].Text = TXT_GRID_TIME.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_DIAGONAL1].Text = SDB_INSP_DIAGONAL1.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_DIAGONAL2].Text = SDB_INSP_DIAGONAL2.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_LOC].Text = TXT_LOC.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_INSP_WAVE1].Text = TXT_WAVE1.Text;
            ss1.ActiveSheet.Cells[rowIndex, SPD_PLATE_COLOR].Text = txt_Color_code.Text;

            ss1.ActiveSheet.Cells[rowIndex, SPD_THK1].Text = SDB_HD1.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK2].Text = SDB_HD2.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK3].Text = SDB_HD3.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK4].Text = SDB_HD4.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK5].Text = SDB_HD5.NumValue.ToString();
            ss1.ActiveSheet.Cells[rowIndex, SPD_THK6].Text = SDB_HD6.NumValue.ToString();
            // .Col = SPD_FLAW_YN:             If CHK_FLAW_YN.Value = -1 Then .Text = "Y" Else .Text = "N"

            if (txt_rec_sts.Text == "1")
            {

                p_pro(1, 1, true, true);
            }

        }

        public override void Spread_Ins()
        {
            double dThk =0;
            double dWid = 0;
            double dLen = 0;
            double dWgt = 0;
            int lRow = 0;
            string sPlateNo;
            string sLotNo = "";
            string sCutNo = "";
            string sClipText;

            string sSize_knd = "";
            string sTrim_fl = "";
            string sAply_stdspec = "";
            string sEmp_cd = "";
            string sStdspec_YY;
            string sStdspec;
            int iCount;

            sPlateNo = "";

            if (ss1.ActiveSheet.RowCount == 0)
            {
                if (txt_plate_no.Text.Length == 12)
                {
                    base.Spread_Ins();
                    ss1.ActiveSheet.Cells[0, SPD_PLATE_NO].Text = txt_plate_no.Text + "01";
                    ss1.ActiveSheet.Cells[0, SPD_THK].Text = "0";
                    ss1.ActiveSheet.Cells[0, SPD_WID].Text = "0";
                    ss1.ActiveSheet.Cells[0, SPD_LEN].Text = "0";
                    ss1.ActiveSheet.Cells[0, SPD_APLY_STDSPEC].Text = "GB-XXX";
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请正确输入母板号 ！", "I", "");
                }
                return;
            }


            for (iCount = ss1.ActiveSheet.ActiveRowIndex; iCount < ss1.ActiveSheet.RowCount; iCount++)
            {
                if (sPlateNo == "" || ss1.ActiveSheet.Cells[iCount, SPD_PLATE_NO].Text.Substring(0, 12) == sPlateNo.Substring(0, 12))
                {
                    sPlateNo = ss1.ActiveSheet.Cells[iCount, SPD_PLATE_NO].Text;
                    lRow = iCount;
                }
                else
                {
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            sPlateNo = "";

            ss1.ActiveSheet.SetActiveCell(0, lRow);
            base.Spread_Ins();
            if (lRow >= 0)
            {
                sPlateNo = ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text;
                sLotNo = ss1.ActiveSheet.Cells[lRow, SPD_LOT_NO].Text;
                sCutNo = ss1.ActiveSheet.Cells[lRow, SPD_CUT_NO].Text;
                dThk = Convert.ToDouble(ss1.ActiveSheet.Cells[lRow, SPD_THK].Text);
                dWid = Convert.ToDouble(ss1.ActiveSheet.Cells[lRow, SPD_WID].Text);
                dLen = Convert.ToDouble(ss1.ActiveSheet.Cells[lRow, SPD_LEN].Text);
                dWgt = Convert.ToDouble(ss1.ActiveSheet.Cells[lRow, SPD_WGT].Text);
                sSize_knd = ss1.ActiveSheet.Cells[lRow, SPD_SIZE_KND].Text;
                sTrim_fl = ss1.ActiveSheet.Cells[lRow, SPD_TRIM_FL].Text;
                sAply_stdspec = ss1.ActiveSheet.Cells[lRow, SPD_APLY_STDSPEC].Text;
                sEmp_cd = ss1.ActiveSheet.Cells[lRow, SPD_EMP_CD].Text;
            }
            else
            {
                sPlateNo = txt_plate_no.Text + "00";
            }

            ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text = sPlateNo;
            ss1.ActiveSheet.Cells[lRow, SPD_LOT_NO].Text = sLotNo;
            ss1.ActiveSheet.Cells[lRow, SPD_CUT_NO].Text = sCutNo;
            ss1.ActiveSheet.Cells[lRow, SPD_THK].Text = dThk.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_WID].Text = dWid.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_LEN].Text = dLen.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_WGT].Text = dWgt.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_SIZE_KND].Text = sSize_knd;
            ss1.ActiveSheet.Cells[lRow, SPD_TRIM_FL].Text = sTrim_fl;
            ss1.ActiveSheet.Cells[lRow, SPD_APLY_STDSPEC].Text = sAply_stdspec;
            ss1.ActiveSheet.Cells[lRow, SPD_EMP_CD].Text = sEmp_cd;
            //ss1.Col = 0;
            //ss1.Text = "Input";
            ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text = ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text.Substring(0, 12) + string.Format((Convert.ToInt32(ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text.Substring(12, 2)) + 1).ToString());
            ss1.ActiveSheet.Cells[lRow, SPD_SURF_GRD].Text = "1";

        }

        private void opt_CHK_PRD_GRD_Clk()
        {
            if (opt_CHK_PRD_GRD0.Checked)
            {
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

            
            }
            else if (opt_CHK_PRD_GRD1.Checked)
            {
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
                label29.Text = "改判原因";
            
            }
            else if (opt_CHK_PRD_GRD2.Checked)
            {
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
                label29.Text = "协议原因";
              
            }
            else if (opt_CHK_PRD_GRD3.Checked)
            {
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
                label29.Text = "待判原因";
             
            }
            else if (opt_CHK_PRD_GRD4.Checked)
            {
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
                label29.Text = "次品原因";
            }
        }

        private void opt_line1_Clk()
        {

            if (opt_line1.Checked)
            {
                opt_line1.ForeColor = Color.Red;
                opt_line2.ForeColor = Color.Black;
                opt_line5.ForeColor = Color.Black;
                txt_line.Text = "1";
                if (ss1.ActiveSheet.RowCount > 0) Form_Ref();
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);
            }

        }


        private void opt_line2_Clk(int Value)
        {
            if (opt_line2.Checked)
            {
                opt_line2.ForeColor = Color.Red;
                opt_line1.ForeColor = Color.Black;
                opt_line5.ForeColor = Color.Black;
                txt_line.Text = "2";
                if (ss1.ActiveSheet.RowCount > 0) Form_Ref();
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, true);
            }

        }


        private void opt_line5_Clk(int Value)
        {
            if (opt_line5.Checked)
            {
                opt_line5.ForeColor = Color.Red;
                opt_line1.ForeColor = Color.Black;
                opt_line2.ForeColor = Color.Black;
                txt_line.Text = "";
                if (ss1.ActiveSheet.RowCount > 0) Form_Ref();
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, false);
            }

        }

        private void opt_line3_Clk(int Value)
        {
            if (opt_line3.Checked)
            {
                opt_line3.ForeColor = Color.Red;
                opt_line4.ForeColor = Color.Black;
                txt_rec_sts.Text = "1";
            }
        }

        private void opt_line4_Clk(int Value)
        {
            if (opt_line4.Checked)
            {
                opt_line4.ForeColor = Color.Red;
                opt_line3.ForeColor = Color.Black;
                txt_rec_sts.Text = "2";
            }
        }

        //add by liqian at 2012-03-14 根据实测长度值计算公称长度
        private void SDB_ACT_LEN_Chg()
        {
            double iLen;
            if (TXT_SIZE_KND.Text != "01")
            {
                if (SDB_ACT_LEN.NumValue > 0)
                {
                    iLen = (SDB_ACT_LEN.NumValue / 50) * 50;
                    SDB_LEN.NumValue = iLen;
                }
            }
        }

        private void ss1_ButtonClicked(int Col, int ROW)
{
	int sCheck1;
	int sCheck2;

	int iCol;
	int iRow;
	int iMode;

	int iRowNum;
	int iRowfr;
	int iRowto;

	string SMESG;

	iCol = Col;
	iRow = ROW;

	if (ss1.ActiveSheet.RowCount<=0) return;
	if (Col != SPD_LINE1 & Col != SPD_LINE2 & Col != SPD_SURF_YN) return;
	if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U")) return;

	SSCHK_GRID_YN.Checked = false;

	iRowto = iRow - 1;
	iRowfr = iRow + 1;

	if (iRowto >= 0) {
		for (iRowNum = 0; iRowNum <= iRowto; iRowNum++) {

			if (ss1.ActiveSheet.RowHeader.Cells[iRowNum,0].Text != "") {
				ss1.ActiveSheet.RowHeader.Cells[iRowNum,0].Text = "";
				ss1.ActiveSheet.Cells[iRowNum,SPD_LINE1].Text = "False";
				ss1.ActiveSheet.Cells[iRowNum,SPD_LINE2].Text = "False";

				break; // TODO: might not be correct. Was : Exit For
			}
		}
	}

	if (iRowfr <= ss1.ActiveSheet.RowCount) {
		for (iRowNum = iRowfr; iRowNum < ss1.ActiveSheet.RowCount; iRowNum++) {

			if (ss1.ActiveSheet.RowHeader.Cells[iRowNum,0].Text != "") {
				ss1.ActiveSheet.RowHeader.Cells[iRowNum,0].Text = "";
				ss1.ActiveSheet.Cells[iRowNum,SPD_LINE1].Text = "False";
				ss1.ActiveSheet.Cells[iRowNum,SPD_LINE2].Text = "False";

				break; // TODO: might not be correct. Was : Exit For
			}
		}
	}


	if (ss1.ActiveSheet.Cells[iRow,SPD_LINE1].Text == "True") {;
		ss1.ActiveSheet.Cells[iRow,SPD_LINE2].Text = "False";
	} else if (ss1.ActiveSheet.Cells[iRow,SPD_LINE2].Text == "True") {
		ss1.ActiveSheet.Cells[iRow,SPD_LINE1].Text = "False";
	}

	if (Col == SPD_SURF_YN) {
		if (ss1.ActiveSheet.Cells[iRow,SPD_SURF_YN].Text == "True") {
			ss1.ActiveSheet.Cells[iRow,SPD_SURF_GRD].Text = "1";
		} else {
			ss1.ActiveSheet.Cells[iRow,SPD_SURF_GRD].Text = "4";
		}
	}


	ss1.Col = 0;
	ss1.Text = "Update";

	TXT_INSP_FLAW(0).Text = "";
	TXT_INSP_FLAW(1).Text = "";
	TXT_INSP_FLAW(3).Text = "";
	TXT_INSP_FLAW(4).Text = "";
	TXT_INSP_FLAW(5).Text = "";

	ss1.Col = SPD_LINE1;
	sCheck1 = ss1.Value;
	ss1.Col = SPD_LINE2;
	sCheck2 = ss1.Value;

	if (sCheck1 == 0 & sCheck2 == 0) {
		ss1.Col = 0;
		ss1.Text = "";
		Gp_Sp_BlockColor(ss1, 1, -1, iRow, iRow);
	} else {
		Gp_Sp_BlockColor(ss1, 1, -1, iRow, iRow, , SSP2.BackColor);
		//        TXT_INSP_FLAW(0).Text = ""
		//        TXT_INSP_FLAW(1).Text = ""
		//        TXT_INSP_FLAW(3).Text = ""
		//        TXT_INSP_FLAW(4).Text = ""
		//        TXT_INSP_FLAW(5).Text = ""
		opt_CHK_PRD_GRD(0).Value = true;

		// add by liqian at 2012-03-29  改判标准到下一块时自动清空
		txt_stdspec_chg.Text = "";
		TXT_INSP_FLAW_NAME(5).Text = "";
		TXT_INSP_FLAW(5).Text = "";
		// add by liqian at 2012-04-18 留样下一块自动清空
		SSCHK_LY_YN.Value = 0;
		SSCHK_LAST_YN.Value = 0;
		CHK_FLAW_YN.Value = 0;

		ss1.ROW = iRow;
		ss1.Col = SPD_THK;
		SDB_THK.Value = ss1.Value;
		ss1.Col = SPD_WID;
		SDB_WID.Value = ss1.Value;
		ss1.Col = SPD_LEN;
		SDB_LEN.Value = ss1.Value;
		ss1.Col = SPD_THK_MIN;
		if (ss1.Value == "")
			SDB_INSP_THK_MN.Value = 0;
		else
			SDB_INSP_THK_MN.Value = ss1.Value;
		ss1.Col = SPD_THK_MAX;
		if (ss1.Value == "")
			SDB_INSP_THK_MX.Value = 0;
		else
			SDB_INSP_THK_MX.Value = ss1.Value;
		ss1.Col = SPD_WID_MIN;
		if (ss1.Value == "")
			SDB_INSP_WID_MN.Value = 0;
		else
			SDB_INSP_WID_MN.Value = ss1.Value;
		ss1.Col = SPD_WID_MAX;
		if (ss1.Value == "")
			SDB_INSP_WID_MX.Value = 0;
		else
			SDB_INSP_WID_MX.Value = ss1.Value;
		ss1.Col = SPD_LEN_MIN;
		if (ss1.Value == "")
			SDB_INSP_LEN_MN.Value = 0;
		else
			SDB_INSP_LEN_MN.Value = ss1.Value;
		ss1.Col = SPD_LEN_MAX;
		if (ss1.Value == "")
			SDB_INSP_LEN_MX.Value = 0;
		else
			SDB_INSP_LEN_MX.Value = ss1.Value;
		ss1.Col = SPD_ACT_THK;
		if (ss1.Value == "")
			SDB_ACT_THK.Value = 0;
		else
			SDB_ACT_THK.Value = ss1.Value;
		ss1.Col = SPD_ACT_WID;
		if (ss1.Value == "")
			SDB_ACT_WID.Value = 0;
		else
			SDB_ACT_WID.Value = ss1.Value;
		ss1.Col = SPD_ACT_LEN;
		if (ss1.Value == "")
			SDB_ACT_LEN.Value = 0;
		else
			SDB_ACT_LEN.Value = ss1.Value;
		//2012-3-20 Modify by LiChao
		ss1.Col = SPD_INSP_WAVE;
		if (ss1.Value == "")
			TXT_WAVE.Text = "";
		else
			TXT_WAVE.Text = ss1.Value;
		ss1.Col = SPD_INSP_VERT_DEG;
		if (ss1.Value == "")
			TXT_VERT_DEG.Text = "";
		else
			TXT_VERT_DEG.Text = ss1.Value;
		ss1.Col = SPD_INSP_RECT_DEG;
		if (ss1.Value == "")
			TXT_RECT_DEG.Text = "";
		else
			TXT_RECT_DEG.Text = ss1.Value;
		// add by liqian at 2012-04-18 留样下一块自动清空,备注重查
		ss1.Col = SPD_PROD_REMARK;
		if (ss1.Value == "")
			TXT_REMARK.Text = "";
		else
			TXT_REMARK.Text = ss1.Value;
		ss1.Col = SPD_TOP_GRID_GRD;
		if (ss1.Value == "")
			TXT_TOP_GRID_GRD.Text = "";
		else
			TXT_TOP_GRID_GRD.Text = ss1.Value;
		ss1.Col = SPD_TOP_GRID_YRD;
		if (ss1.Value == "")
			SDB_TOP_GRID_YRD.Value = 0;
		else
			SDB_TOP_GRID_YRD.Value = ss1.Value;
		ss1.Col = SPD_TOP_GRID_DEEP;
		if (ss1.Value == "")
			SDB_TOP_GRID_DEEP.Value = 0;
		else
			SDB_TOP_GRID_DEEP.Value = ss1.Value;
		ss1.Col = SPD_BOT_GRID_GRD;
		if (ss1.Value == "")
			TXT_BOT_GRID_GRD.Text = "";
		else
			TXT_BOT_GRID_GRD.Text = ss1.Value;
		ss1.Col = SPD_BOT_GRID_YRD;
		if (ss1.Value == "")
			SDB_BOT_GRID_YRD.Value = 0;
		else
			SDB_BOT_GRID_YRD.Value = ss1.Value;
		ss1.Col = SPD_BOT_GRID_DEEP;
		if (ss1.Value == "")
			SDB_BOT_GRID_DEEP.Value = 0;
		else
			SDB_BOT_GRID_DEEP.Value = ss1.Value;
		ss1.Col = SPD_GRID_TIME;
		if (ss1.Value == "")
			TXT_GRID_TIME.Text = "";
		else
			TXT_GRID_TIME.Text = ss1.Value;
		ss1.Col = SPD_INSP_DIAGONAL1;
		if (ss1.Value == "")
			SDB_INSP_DIAGONAL1.Value = 0;
		else
			SDB_INSP_DIAGONAL1.Value = ss1.Value;
		ss1.Col = SPD_INSP_DIAGONAL2;
		if (ss1.Value == "")
			SDB_INSP_DIAGONAL2.Value = 0;
		else
			SDB_INSP_DIAGONAL2.Value = ss1.Value;
		ss1.Col = SPD_LOC;
		if (ss1.Value == "")
			txt_loc.Text = "";
		else
			txt_loc.Text = ss1.Value;
		ss1.Col = SPD_INSP_WAVE1;
		if (ss1.Value == "")
			TXT_WAVE1.Text = "";
		else
			TXT_WAVE1.Text = ss1.Value;

		ss1.Col = SPD_THK1;
		if (ss1.Value == "")
			SDB_HD1.Value = 0;
		else
			SDB_HD1.Value = ss1.Value;
		ss1.Col = SPD_THK2;
		if (ss1.Value == "")
			SDB_HD2.Value = 0;
		else
			SDB_HD2.Value = ss1.Value;
		ss1.Col = SPD_THK3;
		if (ss1.Value == "")
			SDB_HD3.Value = 0;
		else
			SDB_HD3.Value = ss1.Value;
		ss1.Col = SPD_THK4;
		if (ss1.Value == "")
			SDB_HD4.Value = 0;
		else
			SDB_HD4.Value = ss1.Value;
		ss1.Col = SPD_THK5;
		if (ss1.Value == "")
			SDB_HD5.Value = 0;
		else
			SDB_HD5.Value = ss1.Value;
		ss1.Col = SPD_THK6;
		if (ss1.Value == "")
			SDB_HD6.Value = 0;
		else
			SDB_HD6.Value = ss1.Value;

		ss1.Col = SPD_INSP_CD1;
		if (ss1.Text == "")
			TXT_INSP_FLAW(0).Text = "";
		else
			TXT_INSP_FLAW(0).Text = ss1.Text;
		ss1.Col = SPD_INSP_CD3;
		if (ss1.Text == "")
			TXT_INSP_FLAW(3).Text = "";
		else
			TXT_INSP_FLAW(3).Text = ss1.Text;


		//2011-08-29   modified by liqian for 画面显示定尺改为汉字,双击时对应栏位还原回代码表示,保证定尺保存为01,02,06,08,..类型
		ss1.Col = SPD_SIZE_KND;
		switch (ss1.Text) {
			case "定尺":
				TXT_SIZE_KND.Text = "01";
				break;
			case "单定尺":
				TXT_SIZE_KND.Text = "02";
				break;
			case "非尺":
				TXT_SIZE_KND.Text = "06";
				break;
			case "小尺板":
				TXT_SIZE_KND.Text = "08";
				break;
			default:
				TXT_SIZE_KND.Text = "";
				break;
		}
		ss1.Col = SPD_TRIM_FL;
		TXT_TRIM_FL.Text = ss1.Text;

	}

	ss1.Col = SPD_EMP_CD;
	ss1.Text = sUserID;

	TXT_CUT_TIME.RawData = Gf_DTSet(M_CN1, , "X");
	ss1.Col = SPD_PROD_DATE;
	ss1.Text = TXT_CUT_TIME.Text;

	ss1.Col = SPD_INS_MAN;
	ss1.Text = TXT_sUserID.Text;
	ss1.Col = SPD_INS_MAN_TAIL;
	ss1.Text = TXT_sUserID_Tail.Text;

	ss1.Col = SPD_PLATE_COLOR;
	ss1.Text = txt_Color_code.Text;

}



        #region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            sDTChk = "M";
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

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
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

            if (iDateMatch != iDateCheck.Substring(0, 8))
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
