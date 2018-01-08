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
//-- Program Name      标识（标印、标签）打印信息发送界面_CGD2080C
//-- Program ID        CGD2080C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.08   
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.08       韩超        标识（标印、标签）打印信息发送界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGD2080C : CommonClass.FORMBASE
    {
        public CGD2080C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_LINE1 = 0;
        const int SPD_LINE2 = 1;
        const int SPD_PLATE_NO = 2;
        const int SPD_LOT_NO = 4;
        const int SPD_CUT_NO = 5;
        const int SPD_THK = 6;
        const int SPD_WID = 7;
        const int SPD_LEN = 8;
        const int SPD_WGT = 9;
        const int SPD_LAST_YN = 10;
        const int SPD_SIZE_KND = 11;
        const int SPD_TRIM_FL = 12;
        const int SPD_APLY_STDSPEC = 13;
        const int SPD_APLY_STDSPEC_NEW = 14;
        const int SPD_SURF_GRD = 15;
        const int SPD_MARK_YN = 16;
        const int SPD_STAMP_YN = 17;
        const int SPD_BAR_YN = 18;
        const int SPD_PROD_DATE = 19;
        const int SPD_EMP_CD = 20;
        const int SPD_PAINT = 21;
        const int SPD_LABEL = 22;
        const int SPD_LOTCD = 23;
        const int SPD_STDSPEC_YY = 24;
        const int SPD_STLGRD = 25;
        const int SPD_ORD_REMARK = 26;
        const int SPD_UST = 27;
        const int SPD_CUR_UST = 28;
        const int SPD_VESSEL_NO = 29;
        const int SPD_DEL_TO_DATE = 37;
        const int SPD_CUST_CD = 38;
        const int SPD_TO_CUR_INV = 39;
        const int SPD_CUST_CD_SHORT = 40;
        const int SPD_URGNT_FL = 41;
        const int SPD_IMP_CONT = 43;
        const int SPD_SIDE_MARK = 44;
        const int SPD_JIT_FLAG = 45;

        const int SS2_PRODSPECNOA_STD = 50;
        //多船级社标准一
        const int SS2_PRODSPECNOB_STD = 51;
        //多船级社标准二
        const int SS2_PRODSPECNOC_STD = 52;
        //多船级社标准三
        const int SS2_PRODSPECNOA = 53;
        //多船级社牌号一
        const int SS2_PRODSPECNOB = 54;
        //多船级社牌号二
        const int SS2_PRODSPECNOC = 55;
        //多船级社牌号三
        const int SS2_PRODSPECNOA1 = 56;
        //多船级社牌号一
        const int SS2_PRODSPECNOB1 = 57;
        //多船级社牌号二
        const int SS2_PRODSPECNOC1 = 58;
        //多船级社牌号三

        int PRODSPECNOA;
        //牌号一
        int PRODSPECNOB;
        //牌号二
        int PRODSPECNOC;
        //牌号三
        int PRODSPECNOA1;
        //牌号一
        int PRODSPECNOB1;
        //牌号二
        //牌号三
        int PRODSPECNOC1;


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_plt, "PN", "", "", "", imcseq, "");//1
            //p_SetMc(txt_plt_name, "P", "", "", "", imcseq, "");//2
            p_SetMc(txt_plate_no, "P", "", "", "", imcseq, "");//3
            p_SetMc(udt_date_fr, "P", "", "", "", imcseq, "");//4
            p_SetMc(udt_date_to, "P", "", "", "", imcseq, "");//5
            p_SetMc(txt_line, "P", "", "", "", imcseq, "");//6
            p_SetMc(txt_stdspec, "P", "", "", "", imcseq, "");//7
            p_SetMc(txt_lot_no, "P", "", "", "", imcseq, "");//8
            p_SetMc(txt_rec_sts, "P", "", "", "", imcseq, "");//9
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//10

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("#1", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("#2", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("厚度", "N", "9,2", "I", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("宽度", "N", "9", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("长度", "N", "9", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("尾板", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("定尺", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切边", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("标准号", "E", "30", "IL", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("改判标准号", "E", "30", "I", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("合格", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("喷印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("冲印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("侧喷", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("生产日期", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("作业人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("标印", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("标签", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("轧批", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("打印标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("钢种", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//25
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("CUR_UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("加喷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("厚度下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("厚度上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("宽度下限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("宽度上限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("长度下限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("长度上限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("交货期开始", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("交货期结束", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("客户代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("目的库", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("子公司代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("轧制班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("侧喷加喷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//44
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//47
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//48
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//49
            p_SetSc("多认证1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//50
            p_SetSc("多认证2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//51
            p_SetSc("多认证3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("牌号1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//53
            p_SetSc("牌号2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("牌号3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//55
            p_SetSc("牌号一", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("牌号二", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//57
            p_SetSc("牌号三", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("订单项次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
           

            //iheadrow = 0;
            //p_spanSpread("板坯规格", 10, 12, iscseq, iheadrow, 1);
            

        }

        private void CGT2000C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2000NC";
            Form_Define();

            udt_date_fr.RawDate = Gf_DTSet("D", "");
            udt_date_to.RawDate = Gf_DTSet("D", "");

            SSPpdt.BackColor = Color.Fuchsia;

        }

        public override void Form_Pro()
        {
            p_pro(1, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            //激活下事件
            OPT_CH.Checked = false;
            OPT_CH.Checked = true;

            return true;

        }

        public override void Form_Ref()
        {
            int iCount;
            double dMillCal_Wgt;

            string dReheat_I_date;
            string dReheat_O_date;

            string dReheat_Ir_date = "";
            string dReheat_Or_date = "";

            string dReheat_I_dur;
            string dReheat_O_dur;

            string simpcont;


            p_Ref(1, 1, true, true);

            SDB_WGT.Text = "0";
            if (ss1.ActiveSheet.RowCount == 0)
            {
                SDB_WGT.Text = "0";
            }
            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {

                dReheat_I_date = ss1.ActiveSheet.Cells[iCount - 1, SS1_CHARGE_DATE].Text;

                if (dReheat_I_date == "" || dReheat_Ir_date == "")
                {
                    dReheat_I_dur = "";
                }
                else
                {
                    dReheat_I_dur = Convert.ToString(Math.Round((Convert.ToDateTime(dReheat_I_date) - Convert.ToDateTime(dReheat_Ir_date)).TotalMinutes, 1));
                }

                dReheat_Ir_date = dReheat_I_date;

                dReheat_O_date = ss1.ActiveSheet.Cells[iCount - 1, SS1_DISCHARGE_DATE].Text;

                if (dReheat_O_date == "" | dReheat_Or_date == "")
                {
                    dReheat_O_dur = "";
                }
                else
                {
                    dReheat_O_dur = Convert.ToString(Math.Round(((Convert.ToDateTime(dReheat_O_date) - Convert.ToDateTime(dReheat_Or_date)).TotalMinutes), 1));
                }

                dReheat_Or_date = dReheat_O_date;

                ss1.ActiveSheet.Cells[iCount - 1, SS1_DELAY_DATE].Text = dReheat_O_dur;
                SDB_WGT.Text = (convertX(SDB_WGT.Text) + convertX(ss1.ActiveSheet.Cells[iCount - 1, SS1_SLAB_WGT].Text)).ToString();
                if (ss1.ActiveSheet.Cells[iCount - 1, SS1_CUST_CD].Text.Length == 2)
                {
                   Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Black, SSPpdt.BackColor);

                }

                if (OPT_REJECT.Checked)
                {
                    if (Convert.ToDateTime(dReheat_I_date) > Convert.ToDateTime(dReheat_O_date))
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Black, Color.Yellow);
                    }
                }

                //紧急订单绿色标记 2012-08-16  by  LiQian
                if (ss1.ActiveSheet.Cells[iCount - 1, SS1_URGNT_FL].Text == "Y")
                {
                    Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iCount - 1, iCount - 1, Color.Green, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_ORD_NO, SS1_ORD_NO, iCount - 1, iCount - 1, Color.Green, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_URGNT_FL, SS1_URGNT_FL, iCount - 1, iCount - 1, Color.Green, Color.White);
                }


                simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text.Trim();
                if (simpcont == "Y")
                {
                    Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount - 1, iCount - 1, SSP4.BackColor, Color.White);
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

        private void OPT_CH_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_CH.Checked)
            {
                OPT_CH.ForeColor = Color.Red;
                OPT_DISCH.ForeColor = Color.Black;
                OPT_REJECT.ForeColor = Color.Black;

                int iRow;
                string sTemp;

                base.Form_Cls();

                TXT_CH_CD.Text = "C";

                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RHF_CH_ROW, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_MILL_STLGRD, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DISCHARGE_DATE, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DELAY_DATE, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ZAILU_DATE, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CHARGE_TEMP, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_TEMP, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_FL, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_APLY_STDSPEC, true);
                //隐藏标准号

                ss1.ActiveSheet.ColumnHeader.Cells[0, SS1_CHARGE_DATE].Text = "装炉时间";
                ULabel5.Text = "装炉时间";

                ss1.ActiveSheet.ColumnHeader.Cells[0, SS1_DISCHARGE_DATE].Text = "出炉时间";
            }
            else
            {
                OPT_CH.ForeColor = Color.Black;
            }

        }

        private void OPT_DISCH_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_DISCH.Checked)
            {
                OPT_DISCH.ForeColor = Color.Red;
                OPT_CH.ForeColor = Color.Black;
                OPT_REJECT.ForeColor = Color.Black;

                int iRow;
                string sTemp;

                base.Form_Cls();

                TXT_CH_CD.Text = "D";

                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RHF_CH_ROW, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SLAB_STLGRD, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DISCHARGE_DATE, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DELAY_DATE, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ZAILU_DATE, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CHARGE_TEMP, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_TEMP, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_FL, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_APLY_STDSPEC, false);
                //隐藏标准号

                ss1.ActiveSheet.ColumnHeader.Cells[0, SS1_CHARGE_DATE].Text = "装炉时间";
                ULabel5.Text = "出炉时间";

            }
            else
            {
                OPT_DISCH.ForeColor = Color.Black;
            }

        }

        private void OPT_REJECT_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_REJECT.Checked)
            {
                OPT_REJECT.ForeColor = Color.Red;
                OPT_CH.ForeColor = Color.Black;
                OPT_DISCH.ForeColor = Color.Black;

                int iRow;
                string sTemp;

                base.Form_Cls();

                TXT_CH_CD.Text = "R";

                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RHF_CH_ROW, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SLAB_STLGRD, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DELAY_DATE, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ZAILU_DATE, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CHARGE_TEMP, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_TEMP, true);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_FL, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_APLY_STDSPEC, true);
                //隐藏标准号

                ss1.ActiveSheet.ColumnHeader.Cells[0, SS1_CHARGE_DATE].Text = "缺号发生时间";
                ULabel5.Text = "缺号时间";

                ss1.ActiveSheet.ColumnHeader.Cells[0, SS1_DISCHARGE_DATE].Text = "最后装炉时间";
            }
            else
            {
                OPT_REJECT.ForeColor = Color.Black;
            }

        }

    }
}
