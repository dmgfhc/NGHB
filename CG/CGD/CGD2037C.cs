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
//-- Sub_System Name   板坯库管理
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG {
    public partial class CGD2037C: CommonClass.FORMBASE {
        public CGD2037C() {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_PLATE_NO = 0;
        const int SPD_OCCR_TIME = 1;
        const int SPD_LOT_NO = 2;
        const int SPD_SEQ = 3;
        const int SPD_LINE_DATE = 8;
        const int SPD_OFF_PRC = 9;
        const int SPD_OFF_DATE = 10;
        const int SPD_OFF_REASON = 11;
        const int SPD_OFF_LOC = 12;
        const int SPD_OFF_EMP = 13;
        const int SPD_ON_PRC = 14;
        const int SPD_ON_DATE = 15;
        const int SPD_ON_REASON = 16;
        const int SPD_ON_EMP = 17;
        const int SPD_ONOFF_CD = 18;

        //const int SPD_PLAN_PROD_WGT = 33,


        #region 界面初始化

        protected override void p_SubFormInit() {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SEQ, "P", "", "", "", imcseq, "");
            p_SetMc(txt_line, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");
            p_SetMc(txt_m_r, "P", "", "", "", imcseq, "");
            p_SetMc(txt_onoff, "P", "", "", "", imcseq, "");
            p_SetMc(txt_prc, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("物料号", "E", "14", "PI", "", "", "", iscseq, iheadrow, "L"); //0 
            p_SetSc("发生时间", "DT", "", "PI", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("分段号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("分线时间", "DT", "", "", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("工序", "E", "20", "IL", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("时间", "DT", "", "IL", "", "", "", iscseq, iheadrow, "M"); //10

            p_SetSc("原因", "E", "20", "I", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("位置", "E", "10", "I", "", "", "", iscseq, iheadrow, "L"); //12
            p_SetSc("人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("工序", "E", "20", "IL", "", "", "", iscseq, iheadrow, "L"); //14

            p_SetSc("时间", "DT", "", "IL", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("原因", "E", "20", "IL", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("上下线标志", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M"); //18

            iheadrow = 0;
            p_spanSpread("规格", 4, 6, iscseq, iheadrow, 1);
            p_spanSpread("物料下线", 9, 13, iscseq, iheadrow, 1);
            p_spanSpread("物料上线", 14, 17, iscseq, iheadrow, 1);


            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_OCCR_TIME, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE_DATE, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_OFF_REASON, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_OFF_LOC, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ON_REASON, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_ONOFF_CD, true);
        }

        public void Form_Load(object sender, System.EventArgs e) {
            base.sSvrPgmPkgName = "CGD2037NC";
            Form_Define();
            ss1.ActiveSheet.FrozenColumnCount = 3;
            CBO_SHIFT.Items.Add("1");
            CBO_SHIFT.Items.Add("2");
            CBO_SHIFT.Items.Add("3");

            CBO_GROUP.Items.Add("A");
            CBO_GROUP.Items.Add("B");
            CBO_GROUP.Items.Add("C");
            CBO_GROUP.Items.Add("D");
            opt_offline.Checked = true;
            opt_OnPosition0.Checked = true;

        }
        #endregion

        # region 重写查询
        public override void Form_Ref() {
            p_Ref(1, 1, true, true);
        }

        public override void Form_Pro() {
            p_pro(1, 1, true, true);
        }

        private void opt_line1_Clk() {
            txt_line.Text = "1";
            if (ss1.ActiveSheet.RowCount > 0)
                Form_Ref();
        }

        private void opt_line2_Clk() {
            txt_line.Text = "2";
            if (ss1.ActiveSheet.RowCount > 0)
                Form_Ref();
        }

        private void opt_offline_Clk() {
            if (opt_offline.Checked) {
                txt_onoff.Text = "F";
                opt_offline.ForeColor = Color.Red;
                opt_online.ForeColor = Color.Black;

                if (ss1.ActiveSheet.RowCount > 0) {
                    Form_Ref();
                }

                //        Call Gf_Sp_Cls(sc1)

                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_PRC, True)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_DATE, True)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_REASON, True)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_EMP, True)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_PRC, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_DATE, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_REASON, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_LOC, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_EMP, False)

            }
        }

        private void opt_online_Clk() {
            if (opt_online.Checked) {
                txt_onoff.Text = "N";
                opt_online.ForeColor = Color.Red;
                opt_offline.ForeColor = Color.Black;
                if (ss1.ActiveSheet.RowCount > 0) {
                    Form_Ref();
                }
                //        Call Gf_Sp_Cls(sc1)

                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_PRC, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_DATE, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_REASON, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_ON_EMP, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_PRC, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_DATE, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_REASON, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_LOC, False)
                //        Call Gp_Sp_ColHidden(ss1, SPD_OFF_EMP, False)
            }
        }

        private void opt_OnPosition_Click(string tag) {

            txt_prc.Text = tag; //opt_OnPosition(Index).Tag;
            if (opt_OnPosition0.Checked) {
                opt_OnPosition0.ForeColor = Color.Red;
                //red
                opt_OnPosition1.ForeColor = Color.Black;
                //black
                opt_OnPosition2.ForeColor = Color.Black;
                //black
                opt_OnPosition3.ForeColor = Color.Black;
                //black
                opt_OnPosition4.ForeColor = Color.Black;
                //black

            } else if (opt_OnPosition1.Checked) {
                opt_OnPosition0.ForeColor = Color.Black;
                //red
                opt_OnPosition1.ForeColor = Color.Red;
                //black
                opt_OnPosition2.ForeColor = Color.Black;
                //black
                opt_OnPosition3.ForeColor = Color.Black;
                //black
                opt_OnPosition4.ForeColor = Color.Black;
                //black

            } else if (opt_OnPosition2.Checked) {
                opt_OnPosition0.ForeColor = Color.Black;
                //red
                opt_OnPosition1.ForeColor = Color.Black;
                //black
                opt_OnPosition2.ForeColor = Color.Red;
                //black
                opt_OnPosition3.ForeColor = Color.Black;
                //black
                opt_OnPosition4.ForeColor = Color.Black;
                //black

            } else if (opt_OnPosition3.Checked) {
                opt_OnPosition0.ForeColor = Color.Black;
                //red
                opt_OnPosition1.ForeColor = Color.Black;
                //black
                opt_OnPosition2.ForeColor = Color.Black;
                //black
                opt_OnPosition3.ForeColor = Color.Red;
                //black
                opt_OnPosition4.ForeColor = Color.Black;
                //black

            } else if (opt_OnPosition4.Checked) {
                opt_OnPosition0.ForeColor = Color.Black;
                //red
                opt_OnPosition1.ForeColor = Color.Black;
                //black
                opt_OnPosition2.ForeColor = Color.Black;
                //black
                opt_OnPosition3.ForeColor = Color.Black;
                //black
                opt_OnPosition4.ForeColor = Color.Red;
                //black

            }
        }


        //下面内容在VB中已经取消，如有需要参考VB代码
        //private void opt_p_m_Click(int Value)
        //{
        //    if (opt_p_m)
        //    {
        //        txt_m_r = "M";
        //        opt_p_m.ForeColor = 0xffL;
        //        opt_p_r.ForeColor = 0x80000012;
        //        Gf_Sp_Cls(sc1);
        //    }
        //}
        //private void opt_p_r_Click(int Value)
        //{
        //    if (opt_p_r)
        //    {
        //        txt_m_r = "R";
        //        opt_p_r.ForeColor = 0xffL;
        //        opt_p_m.ForeColor = 0x80000012;
        //        Gf_Sp_Cls(sc1);
        //    }
        //}

        private void ss1_Clk(int col, int row) {

            if (ss1.ActiveSheet.RowCount <= 0)
                return;
            if (col == 0) {
                ss1_row_Clk(col, row);
                if (txt_onoff.Text == "F") {
                    ss1.ActiveSheet.Cells[row, SPD_OFF_PRC].Text = txt_prc.Text;
                    ss1.ActiveSheet.Cells[row, SPD_OFF_EMP].Text = GeneralCommon.sUserID;
                } else {
                    ss1.ActiveSheet.Cells[row, SPD_ON_PRC].Text = txt_prc.Text;
                    ss1.ActiveSheet.Cells[row, SPD_ON_EMP].Text = GeneralCommon.sUserID;
                }
                ss1.ActiveSheet.Cells[row, SPD_ONOFF_CD].Text = txt_onoff.Text;
            }
        }

        private void ss1_edit(int col, int row) {
            int iCol;
            int iRow;
            int iMode;

            int iRowNum;

            iCol = col;
            iRow = row;
            // iMode = Mode;

            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            if (GeneralCommon.Gf_Sc_Authority(base.sAuthority, "U")) {

                //SpreadCommon.Gp_Sp_UpdateMake(Proc_Sc("SC")("Spread"), iMode);

                //ss1.ROW = iRow;
                if (txt_onoff.Text == "F") {
                    ss1.ActiveSheet.Cells[iRow, SPD_OFF_PRC].Text = txt_prc.Text;
                    ss1.ActiveSheet.Cells[row, SPD_OFF_EMP].Text = GeneralCommon.sUserID;
                } else {
                    ss1.ActiveSheet.Cells[iRow, SPD_ON_PRC].Text = txt_prc.Text;
                    ss1.ActiveSheet.Cells[row, SPD_ON_EMP].Text = GeneralCommon.sUserID;
                }

                ss1.ActiveSheet.Cells[row, SPD_ONOFF_CD].Text = txt_onoff.Text;

            }

        }

        private void ss1_row_Clk(int col, int row) {

            lBlkcol1 = 0;
            lBlkcol2 = 0;
            lBlkrow1 = 0;
            lBlkrow2 = 0;

            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            //ss1.ReDraw = false;
            unlockSpread(ss1);

            if (ss1.ActiveSheet.RowHeader.Cells[row, 0].Text != "修改") {

                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "修改";

                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, ColorTranslator.FromHtml("#80ffff"));

            } else {

                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "";

                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, Color.White);

            }

            lockSpread(ss1);

        }

        public override bool Form_Cls() {

            string line = txt_line.Text;
            string m_r = txt_m_r.Text;
            string onoff = txt_onoff.Text;
            string prc = txt_prc.Text;

            base.Form_Cls();
            txt_line.Text = line;
            txt_m_r.Text = m_r;
            txt_onoff.Text = onoff;
            txt_prc.Text = prc;

            return true;

        }
        #endregion

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
            DTCheck = "S";
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

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            
            if (!e.RowHeader) return; //点击行头才执行事件

            ss1_Clk(e.Column, e.Row);

        }

        private void opt_line1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_line1.Checked)
            {
                opt_line1_Clk();
            }
            else if (opt_line2.Checked)
            {
                opt_line2_Clk();
            }
        }

        private void opt_offline_CheckedChanged(object sender, EventArgs e)
        {
            opt_offline_Clk();
        }

        private void opt_online_CheckedChanged(object sender, EventArgs e)
        {
            opt_online_Clk();
        }

        private void opt_OnPosition0_CheckedChanged(object sender, EventArgs e)
        {
            opt_OnPosition_Click(((RadioButton)sender).Tag.ToString());
        }

        private void opt_OnPosition1_CheckedChanged(object sender, EventArgs e)
        {
            opt_OnPosition_Click(((RadioButton)sender).Tag.ToString());
        }

        private void opt_OnPosition2_CheckedChanged(object sender, EventArgs e)
        {
            opt_OnPosition_Click(((RadioButton)sender).Tag.ToString());
        }

        private void opt_OnPosition3_CheckedChanged(object sender, EventArgs e)
        {
            opt_OnPosition_Click(((RadioButton)sender).Tag.ToString());
        }

        private void opt_OnPosition4_CheckedChanged(object sender, EventArgs e)
        {
            opt_OnPosition_Click(((RadioButton)sender).Tag.ToString());
        }

    }
}
