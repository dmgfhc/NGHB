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
//-- Program Name      钢板剪切实绩查询界面_CGT2040C
//-- Program ID        CGT2040C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.27
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.27       韩超        钢板剪切实绩查询界面_CGT2040C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2040C : CommonClass.FORMBASE
    {
        public CGT2040C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_SLAB_NO = 0;
        const int SPD_FIRST_REMARK = 1;
        const int SPD_PROD_GRD = 18;
        const int SPD_SURF_GRD = 19;
        const int SPD_WGT = 15;
        const int SPD_EDT1 = 22;
        const int SPD_EDT2 = 23;
        const int SPD_EDT3 = 25;
        const int SPD_EDT4 = 26;
        const int SPD_ORD_NO = 40;
        const int SPD_USERID = 44;
        const int SPD_PRC_LINE = 71;
        //加热炉座号  2012.10.30 lichao
        const int SPD_DISCHARGE_DATE = 73;
        //出炉时间  2012.10.30 lichao
        const int SPD_DEL_TO_DATE = 77;
        const int SPD_ORD_CNT = 82;
        const int SPD_URGNT_FL = 84;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SPD_TURN_FL = 85;
        //是否翻板 20121127 李超
        const int SS1_IMP_CONT = 92;

        List<RadioButton> list = new List<RadioButton>();

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "p", "", "", "", imcseq, "");//1
            p_SetMc(SDT_PROD_DATE_FROM, "pn", "", "", "", imcseq, "");//2
            p_SetMc(SDT_PROD_DATE_TO, "pn", "", "", "", imcseq, "");//3
            p_SetMc(CBO_SHIFT, "p", "", "", "", imcseq, "");//4
            p_SetMc(CBO_GROUP, "p", "", "", "", imcseq, "");//5
            p_SetMc(CBO_SURFGRD, "p", "", "", "", imcseq, "");//6
            p_SetMc(CBO_PRODGRD, "p", "", "", "", imcseq, "");//7
            p_SetMc(txt_stdspec_chg, "p", "", "", "", imcseq, "");//8
            p_SetMc(TXT_SP_CD, "p", "", "", "", imcseq, "");//9
            p_SetMc(SDB_THK, "p", "", "", "", imcseq, "");//10
            p_SetMc(SDB_WID, "p", "", "", "", imcseq, "");//11
            p_SetMc(SDB_THK_TO, "p", "", "", "", imcseq, "");//12
            p_SetMc(SDB_WID_TO, "p", "", "", "", imcseq, "");//13
            p_SetMc(TXT_PLATE_NUM, "r", "", "", "", imcseq, "");//14
            p_SetMc(TXT_PLATE_WGT, "r", "", "", "", imcseq, "");//15
            p_SetMc(TXT_ZP_NUM, "r", "", "", "", imcseq, "");//16
            p_SetMc(TXT_ZP_WGT, "r", "", "", "", imcseq, "");//17
            p_SetMc(TXT_GP_NUM, "r", "", "", "", imcseq, "");//18
            p_SetMc(TXT_GP_WGT, "r", "", "", "", imcseq, "");//19
            p_SetMc(TXT_XY_NUM, "r", "", "", "", imcseq, "");//20
            p_SetMc(TXT_XY_WGT, "r", "", "", "", imcseq, "");//21
            p_SetMc(TXT_NO_NUM, "r", "", "", "", imcseq, "");//22
            p_SetMc(TXT_NO_WGT, "r", "", "", "", imcseq, "");//23
            p_SetMc(TXT_FG_NUM, "r", "", "", "", imcseq, "");//24
            p_SetMc(TXT_FG_WGT, "r", "", "", "", imcseq, "");//25
            p_SetMc(TXT_XS_WGT, "r", "", "", "", imcseq, "");//26
            p_SetMc(cbo_prc_line, "p", "", "", "", imcseq, "");//27
            p_SetMc(CBO_MILLGROUP, "p", "", "", "", imcseq, "");//28
            p_SetMc(SDB_LEN, "p", "", "", "", imcseq, "");//29
            p_SetMc(SDB_LEN_TO, "p", "", "", "", imcseq, "");//30
            p_SetMc(SLAB_THK, "p", "", "", "", imcseq, "");//31
            p_SetMc(txt_stlgrd, "p", "", "", "", imcseq, "");//32
            p_SetMc(txt_trns_cmpy_cd, "p", "", "", "", imcseq, "");//33
            p_SetMc(txt_ord_item, "p", "", "", "", imcseq, "");//34
            p_SetMc(txt_ord_no, "p", "", "", "", imcseq, "");//35
            p_SetMc(txt_stlgrd1, "p", "", "", "", imcseq, "");//36
            p_SetMc(txt_org_ord_no, "p", "", "", "", imcseq, "");//37
            p_SetMc(txt_org_ord_item, "p", "", "", "", imcseq, "");//38
            p_SetMc(TXT_PROC_CD, "p", "", "", "", imcseq, "");//39
            p_SetMc(txt_mill_stdspec, "p", "", "", "", imcseq, "");//40
            p_SetMc(TXT_SMP_NO, "p", "", "", "", imcseq, "");//41

            p_ScIni(ss1, Sc1, 44, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0  
            p_SetSc("首件标识", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//1  
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2  
            p_SetSc("分段号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3  
            p_SetSc("剪切线", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");//4  
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//5  
            p_SetSc("进程状态", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//6  
            p_SetSc("特殊工序", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//7  
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8  
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9  
            p_SetSc("轧制标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10 
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//11 
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//12 
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//13 
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//14 
            p_SetSc("重量", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//15 
            p_SetSc("系数重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "M");//16 
            p_SetSc("综判时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//17 
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//18 
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//19 
            p_SetSc("取样代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//20 
            p_SetSc("试样号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//21 
            p_SetSc("喷印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//22 
            p_SetSc("冲印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//23 
            p_SetSc("侧喷", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//24 
            p_SetSc("切边", "E", "20", "I", "", "", "", iscseq, iheadrow, "L");//25 
            p_SetSc("定尺", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//26 
            p_SetSc("修磨", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//27 
            p_SetSc("尾板", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//28 
            p_SetSc("责任单位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29 
            p_SetSc("缺陷类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30 
            p_SetSc("上表缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//31 
            p_SetSc("下表缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//32 
            p_SetSc("改判缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//33 
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//34 
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//35 
            p_SetSc("生产时间", "DT", "", "IL", "", "", "", iscseq, iheadrow, "M");//36 
            p_SetSc("剪切时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//37 
            p_SetSc("火切时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//38 
            p_SetSc("热处理出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//39 
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//40 
            p_SetSc("订单材/余材", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//41 
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//42 
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//43 
            p_SetSc("作业人员", "E", "8", "IL", "", "", "", iscseq, iheadrow, "M");//44 
            p_SetSc("修改人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//45 
            p_SetSc("是否经RH", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//46 
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//47 
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//48 
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//49 
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//50 
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//51 
            p_SetSc("喷涂交货", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//52 
            p_SetSc("其它", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//53 
            p_SetSc("修改时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//54 
            p_SetSc("判废原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//55 
            p_SetSc("轧制班别", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//56 
            p_SetSc("实设成材率", "N", "3,2", "L", "", "", "", iscseq, iheadrow, "R");//57 
            p_SetSc("原料量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "M");//58 
            p_SetSc("库", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//59 
            p_SetSc("入库时间", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//60 
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//61 
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//62 
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//63 
            p_SetSc("计划板坯长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//64 
            p_SetSc("分段剪", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//65 
            p_SetSc("粗轧机", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//66 
            p_SetSc("精轧机", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//67 
            p_SetSc("客户要求编号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//68 
            p_SetSc("订单备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L");//69 
            p_SetSc("板坯厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//70 
            p_SetSc("加热炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//71 
            p_SetSc("布料方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//72 
            p_SetSc("出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//73 
            p_SetSc("加热时间", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//74 
            p_SetSc("堆冷时间", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "M");//75 
            p_SetSc("开始时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//76 
            p_SetSc("结束时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//77 
            p_SetSc("钢板标印时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//78 
            p_SetSc("母板分段时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//79 
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//80 
            p_SetSc("异常坯", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//81 
            p_SetSc("订单数量", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//82 
            p_SetSc("原始订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//83 
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//84 
            p_SetSc("是否翻板", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//85 
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//86 
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//87 
            p_SetSc("长度", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//88 
            p_SetSc("重量", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//89 
            p_SetSc("重量差", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//90 
            p_SetSc("标印人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//91 
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//92 
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//93 
            p_SetSc("试验进程", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//94 
            p_SetSc("性能等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//95 
            p_SetSc("产品备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//96 
            p_SetSc("试样号状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//97 
            p_SetSc("委托单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//98 
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//99 
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//100
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//101
            p_SetSc("表面客户要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//102
            p_SetSc("缺陷责任人", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//103
            p_SetSc("钢板不平度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//104
            p_SetSc("测量长度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//105
            p_SetSc("钢板不平度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//106
            p_SetSc("测量长度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//107
            p_SetSc("热喷号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//108
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//109
            p_SetSc("精轧厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//110


            iheadrow = 0;

            p_spanSpread("缺陷", 31, 34, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 48, 53, iscseq, iheadrow, 1);
            p_spanSpread("板坯尺寸", 61, 63, iscseq, iheadrow, 1);
            p_spanSpread("操作工", 65, 67, iscseq, iheadrow, 1);
            p_spanSpread("客户交货期", 76, 77, iscseq, iheadrow, 1);
            p_spanSpread("原订单尺寸", 86, 89, iscseq, iheadrow, 1);

        }

        private void CGT2040C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2040NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            OPT_PLATE.Checked = true;
            SSC1.Checked = false;

            ss1.ActiveSheet.FrozenColumnCount = 2;

            list.Add(OPT_PLATE);
            list.Add(OPT_SLAB);
            list.Add(OPT_CUT);
            list.Add(OPT_CUR);
            list.Add(OPT_GAS);

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            OPT_PLATE.Checked = true;
            SSC1.Checked = false;

            return true;
        }

        public override void Form_Pro()
        {
            p_Pro(1, 1, true, true);
        }

        public override void Form_Ref()
        {
            string SMESG;
            int iCount;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            Color sBackColor;

            double sTotnum = 0;
            double sTotwgt = 0;
            double s1num = 0;
            double s1wgt = 0;
            double s2num = 0;
            double s2wgt = 0;
            double s3num = 0;
            double s3wgt = 0;
            double s4num = 0;
            double s4wgt = 0;
            double s5num = 0;
            double s5wgt = 0;
            double s7num = 0;
            double s7wgt = 0;
            double sord_cnt = 0;
            string simpcont;

            double sWgt;

            sCurDate = DateTime.Now.ToString("yyyyMMdd");

            if (convertX(SDT_PROD_DATE_FROM.RawDate) - convertX(SDT_PROD_DATE_TO.RawDate) > 0)
            {
                SMESG = " 时间范围输入错误，请重新输入时间信息 ！！！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "系统提示信息");
                return;
            }

            p_Ref(1, 1, true, true);

            {

                if (ss1.ActiveSheet.RowCount <= 0) return;

                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {

                    sWgt = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_WGT].Text);
                    sTotnum = sTotnum + 1;
                    sTotwgt = sTotwgt + sWgt;
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s1num = s1num + 1;
                        s1wgt = s1wgt + sWgt;
                    }
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s2num = s2num + 1;
                        s2wgt = s2wgt + sWgt;
                    }
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s3num = s3num + 1;
                        s3wgt = s3wgt + sWgt;
                    }
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s4num = s4num + 1;
                        s4wgt = s4wgt + sWgt;
                    }
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s5num = s5num + 1;
                        s5wgt = s5wgt + sWgt;
                    }
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_SURF_GRD].Text == "正品")
                    {
                        s7num = s7num + 1;
                        s7wgt = s7wgt + sWgt;
                    }

                    sord_cnt = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_CNT].Text);
                    if (sord_cnt > 1)
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Black, SSP1.BackColor);
                    }

                    sDel_To_Date = ss1.ActiveSheet.Cells[iCount - 1, SPD_DEL_TO_DATE].Text.Substring(0, 6);
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
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Red, sBackColor);
                    }

                    //紧急订单绿色标记 2012-08-16  by  LiQian
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_URGNT_FL].Text == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SPD_SLAB_NO, SPD_SLAB_NO, iCount - 1, iCount - 1, Color.Green, Color.White);
                        Gp_Sp_BlockColor(ss1, SPD_ORD_NO, SPD_ORD_NO, iCount - 1, iCount - 1, Color.Green, Color.White);
                        Gp_Sp_BlockColor(ss1, SPD_URGNT_FL, SPD_URGNT_FL, iCount - 1, iCount - 1, Color.Green, Color.White);
                    }

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();
                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SPD_SLAB_NO, SPD_SLAB_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                        Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                    }
                }

            }

            TXT_TOT_NUM.Text = sTotnum.ToString();
            TXT_TOT_WGT.Text = sTotwgt.ToString();
            TXT_1_NUM.Text = s1num.ToString();
            TXT_1_WGT.Text = s1wgt.ToString();
            TXT_2_NUM.Text = s2num.ToString();
            TXT_2_WGT.Text = s2wgt.ToString();
            TXT_3_NUM.Text = s3num.ToString();
            TXT_3_WGT.Text = s3wgt.ToString();
            TXT_4_NUM.Text = s4num.ToString();
            TXT_4_WGT.Text = s4wgt.ToString();
            TXT_5_NUM.Text = s5num.ToString();
            TXT_5_WGT.Text = s5wgt.ToString();
            TXT_7_NUM.Text = s7num.ToString();
            TXT_7_WGT.Text = s7wgt.ToString();

        }

        public void radioColor()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Checked)
                {
                    list[i].ForeColor = Color.Red;
                }
                else
                {
                    list[i].ForeColor = Color.Black;
                }

            }
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
        public void unlockColumn(FpSpread e, int[] columns)
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

        private void OPT_PLATE_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            radioColor();
        }

        private void OPT_SLAB_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            radioColor();
        }

        private void OPT_CUT_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            radioColor();
        }

        private void OPT_CUR_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            radioColor();
        }

        private void OPT_GAS_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            radioColor();
        }


    }
}
