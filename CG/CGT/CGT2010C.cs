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
//-- Sub_System Name   统计分析管理
//-- Program Name      轧钢实绩查询界面
//-- Program ID        CGT2010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.16
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.16       韩超        轧钢实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2010C : CommonClass.FORMBASE
    {
        public CGT2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_SLAB_NO = 0;
        const int SS1_FIRST_REMARK = 1;
        const int SS1_ORD_NO = 49;
        const int SS1_URGNT_FL = 51;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 52;


        List<RadioButton> OPT_Cm = new List<RadioButton>();


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");//1
            p_SetMc(TXT_MILL_LOT_NO, "P", "", "", "", imcseq, "");//2
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");//3
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");//4
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//5
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");//6
            p_SetMc(txt_stlgrd1, "P", "", "", "", imcseq, "");//7
            p_SetMc(txt_stlgrd, "P", "", "", "", imcseq, "");//8
            p_SetMc(txt_mill_stlgrd, "P", "", "", "", imcseq, "");//9
            p_SetMc(txt_stdspec, "P", "", "", "", imcseq, "");//10
            p_SetMc(TXT_CH_CD, "P", "", "", "", imcseq, "");//11


            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("首件标识", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("坯料来源", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("粗轧开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("粗轧结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("精轧开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("精轧结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("轧废时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("标准钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("板坯厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("板坯宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("板坯长度", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("粗轧厚*宽*长", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("精轧厚*宽*长", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("订单厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("同板差", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("一阶段温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("一阶段厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("二阶段温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("二阶段厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("终轧温度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("粗轧冷却入口温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("粗轧冷却速率", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("粗轧冷却出口温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("精轧冷却入口温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("精轧冷却速率", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("精轧冷却出口温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("矫前返红温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//33
            p_SetSc("计划成品重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("设计成材率（计划）", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("计划板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//36
            p_SetSc("实绩成品重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("轧制间隔（秒）", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//38
            p_SetSc("粗轧班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("粗轧班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("粗轧作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("精轧班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("精轧班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("精轧作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("实设成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("成材率差", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("实绩成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//48
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("是否定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("计划钢板块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("实绩钢板块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("宽度差", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//55
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//56
            p_SetSc("实绩", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//57
            p_SetSc("粗轧机除鳞压力", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//58
            p_SetSc("粗轧机除鳞次数", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//59
            p_SetSc("精轧机除鳞压力", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//60
            p_SetSc("精轧机除鳞次数", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//61
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//62
            p_SetSc("实绩", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//63
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//64
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//65
            p_SetSc("实绩", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//66
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//67
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//68
            p_SetSc("实绩", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//69
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//70
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//71
            p_SetSc("实绩", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//72
            p_SetSc("矫直道次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//73
            p_SetSc("改判", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//74
            p_SetSc("协议", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//75
            p_SetSc("次品", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//76
            p_SetSc("废品", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//77
            

            iheadrow = 0;

            p_spanSpread("粗轧阶段结果", 56, 57, iscseq, iheadrow, 1);
            p_spanSpread("精轧开机温度", 62, 63, iscseq, iheadrow, 1);
            p_spanSpread("终轧温度", 64, 66, iscseq, iheadrow, 1);
            p_spanSpread("入水温度", 67, 69, iscseq, iheadrow, 1);
            p_spanSpread("返红温度", 70, 72, iscseq, iheadrow, 1);

        }

        private void CGT2010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2010NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            OPT_Cm.Add(OPT_Cm1);
            OPT_Cm.Add(OPT_Cm2);
            OPT_Cm.Add(OPT_Cm3);
            OPT_Cm.Add(OPT_Cm4);

            ss1.ActiveSheet.FrozenColumnCount = 2;

        }

        public override void Form_Ref()
        {
            int iCount;
            double dMillCal_Wgt;
            double dMillSlab_Wgt;
            double dMillPlan_Wgt;
            string simpcont;

            if (TXT_MILL_LOT_NO.Text.Trim() != "")
            {
                if (TXT_MILL_LOT_NO.Text.Trim().Length < 12)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("轧批号必须输满12位，才可按轧批号查询！", "I", "系统提示信息");
                    return;
                }
            }

            if (TXT_SLAB_NO.Text.Trim() != "")
            {
                if (TXT_SLAB_NO.Text.Trim().Length < 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("板坯号必须输满8位，才可按板坯号查询！", "I", "系统提示信息");
                    return;
                }
            }

            p_Ref(1, 1, true, true);

            dMillCal_Wgt = 0;
            
                if (ss1.ActiveSheet.RowCount <= 1)
                {
                    return;
                }
                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {
                    //34
                    dMillCal_Wgt = dMillCal_Wgt + convertX(ss1.ActiveSheet.Cells[iCount-1,34].Text);
                    dMillPlan_Wgt = convertX(ss1.ActiveSheet.Cells[iCount - 1, 34].Text);

                    //17
                    dMillSlab_Wgt = convertX(ss1.ActiveSheet.Cells[iCount - 1, 17].Text);
                    if (dMillSlab_Wgt != 0)
                    {
                        //35
                        ss1.ActiveSheet.Cells[iCount - 1, 35].Text = Math.Round(dMillPlan_Wgt * 100 / dMillSlab_Wgt, 2).ToString();
                    }

                    //紧急订单绿色标记 2012-08-16  by  LiQian
                    if (ss1.ActiveSheet.Cells[iCount - 1, SS1_URGNT_FL].Text == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iCount - 1, iCount - 1, Color.Green, Color.White);

                    }

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();

                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);

                        Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                    }
                }
        }

        private void OPT_Cm_Clk(int Index)
        {
            int i;

            for (i = 0; i < 4; i++)
            {
                if (i == Index)
                {
                    OPT_Cm[i].ForeColor = Color.Red;
                }
                else
                {
                    OPT_Cm[i].ForeColor = Color.Black;
                }
            }

            switch (Index)
            {
                case 0:
                    TXT_CH_CD.Text = "C";
                    ULabel5.Text = "粗轧时间";
                    break;
                case 1:
                    TXT_CH_CD.Text = "J";
                    ULabel5.Text = "精轧时间";
                    break;
                case 2:
                    TXT_CH_CD.Text = "S";
                    ULabel5.Text = "轧废时间";
                    break;
                case 3:
                    TXT_CH_CD.Text = "H";
                    ULabel5.Text = "出炉时间";
                    break;
            }
        }

        public override void Form_Pro()
        {
            p_pro(0, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            //激活下事件
            OPT_Cm1.Checked = false;
            OPT_Cm1.Checked = true;

            return true;
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
        public void unlockColumn(FpSpread e,int[] columns)
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

        //解锁并且保存权限并且锁定

        List<bool> spreadPer = new List<bool>();

        public void unlockSpread(FpSpread e, bool locked)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            int rowCount = e.Sheets[0].RowCount;

            if (locked)
            {
                spreadPer.Clear();

                for (int i = 0; i < columnCount; i++)
                {
                    spreadPer.Add(e.ActiveSheet.Columns[i].Locked);
                    e.ActiveSheet.Columns[i].Locked = false;
                }
            }
            if (!locked)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    e.ActiveSheet.Columns[i].Locked = spreadPer[i];
                }
            }

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

        private void OPT_Cm1_CheckedChanged(object sender, EventArgs e)
        {
            if (!OPT_Cm1.Checked) return;
            OPT_Cm_Clk(0);
        }

        private void OPT_Cm2_CheckedChanged(object sender, EventArgs e)
        {
            if (!OPT_Cm2.Checked) return;
            OPT_Cm_Clk(1);
        }

        private void OPT_Cm3_CheckedChanged(object sender, EventArgs e)
        {
            if (!OPT_Cm3.Checked) return;
            OPT_Cm_Clk(2);
        }

        private void OPT_Cm4_CheckedChanged(object sender, EventArgs e)
        {
            if (!OPT_Cm4.Checked) return;
            OPT_Cm_Clk(3);
        }

    }
}
