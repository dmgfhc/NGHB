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
//-- System Name       中板生产管制
//-- Sub_System Name   轧钢作业
//-- Program Name      批号查询及修改_CKG2040C
//-- Program ID        CKG2040C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.18
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.18       韩超        批号查询及修改_CKG2040C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2040C : CommonClass.FORMBASE
    {
        public CKG2040C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

       // const int SS1_SLAB_NO = 0;
        const int SS1_LOT_NO = 0;
        const int SS1_LOT_NO_TEMP = 1;
        const int SS1_PLT = 2;
        const int SS1_SLAB_NO = 3;
        const int SS1_STDSPEC = 4;
        const int SS1_STLGRD = 5;
        const int SS1_THK = 6;
        const int SS1_WID = 7;
        const int SS1_LEN = 8;
        const int SS1_LEN_L = 9;
        const int SS1_THK_L = 10;
        const int SS1_TRIM_FL = 11;
        const int SS1_SIZE_KND = 12;
        const int SS1_ASROLL_LEN = 21;
        const int SS1_ORD_CNT = 27;
        const int SS1_PLATE_CNT = 28;
        const int SS1_PLATE_WGT = 24;
        const int SS1_TEST_TYPE = 25;
        const int SS1_TEST_WGT = 26;
        const int SS1_ORD_NO = 22;
        const int SS1_ORD_ITEM = 23;

        const string Ex_File_Name = "CKG2040C";
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("炉号", txt_HeatNo, "P", "", "", "", "", imcseq);
            p_SetMc("板坯来源", txt_plt, "P", "", "", "", "", imcseq);
            p_SetMc("订单查询种类", txt_all_ord, "P", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("轧制批号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("临时轧批号", "E", "60", "AL", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("板坯来源", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("板坯号", "E", "60", "IL", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("长度范围", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("厚度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("切边", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("定尺", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("计划板坯长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("指示状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("进程状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("轧件长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("订单项次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("钢板重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("取样方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("取样重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("订单数量", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("块数", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
           
            iheadrow = 0;
            p_spanSpread("订单",6, 10, iscseq, iheadrow, 1);
            p_spanSpread("板坯", 15, 17, iscseq, iheadrow, 1);
        }

        private void CKG2040C_Load(object sender, EventArgs e)
        {
            string sQuery;
            string sCurDate;
            string sLotDate;
            string sInsDate;
            string sOutSeq;

            base.sSvrPgmPkgName = "CKG2040NC";
            Form_Define();

            txt_InPlt.Text = "B1";
            txt_INplt_dec.Text = "#1 炼钢";

            sCurDate = Gf_DTSet("D", "X");
            txt_DATE.RawDate = sCurDate;
            sLotDate = "____" + substr(sCurDate, 2, 4) + "%";
            DateTime dt = DateTime.ParseExact(sCurDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            sInsDate = dt.AddDays(-10).ToString("yyyyMMdd");

            //    sQuery = "SELECT NVL(MAX(SUBSTR(MILL_LOT_NO,11,4)),0) FROM EP_MILL_INS3 WHERE MILL_LOT_NO LIKE '" & sLotDate & "' AND INS_DATE >  '" & sInsDate & "'"
            sQuery = "SELECT NVL(MAX(SUBSTR(MILL_LOT_NO,9,6)),'000000') FROM EP_MILL_INS3 WHERE MILL_LOT_NO LIKE '" + sLotDate + "' AND INS_DATE >  '" + sInsDate + "'";
            sOutSeq = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
            txt_OutSeq.Text = substr(sOutSeq, 2, 4);
            sOutSeq = (convertI(sOutSeq) + 1).ToString();
            sOutSeq = sOutSeq.PadLeft(6, '0');
            txt_InSeq.Text = substr(sOutSeq, 2, 4);
        }

        public override void Form_Pro()
        {
            string sQuery;
            string sCurDate;
            string sLotDate;
            string sInsDate;

            string sOutSeq;


            if (txt_all_ord.Text != "N")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请先取消多订单查询选项", "I", "提示");
                return;
            }

            p_Pro(1, 1, true, true);

            sCurDate = Gf_DTSet("D", "X");
            sLotDate = "____" + substr(sCurDate, 2, 4) + "%";

            DateTime dt = DateTime.ParseExact(sCurDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);

            sInsDate = dt.AddDays(-10).ToString("yyyyMMdd");

            //    sQuery = "SELECT NVL(MAX(SUBSTR(MILL_LOT_NO,11,4)),0) FROM EP_MILL_INS3 WHERE MILL_LOT_NO LIKE '" & sLotDate & "' AND INS_DATE >  '" & sInsDate & "'"
            sQuery = "SELECT NVL(MAX(SUBSTR(MILL_LOT_NO,9,6)),'000000') FROM EP_MILL_INS3 WHERE MILL_LOT_NO LIKE '" + sLotDate + "' AND INS_DATE >  '" + sInsDate + "'";
            sOutSeq = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
            txt_OutSeq.Text = substr(sOutSeq, 2, 4);
            sOutSeq = (convertI(sOutSeq) + 1).ToString();
            sOutSeq = sOutSeq.PadLeft(6,'0') ;
            txt_InSeq.Text = substr(sOutSeq, 2, 4);
            TXT_CNT.Text = "";
            TXT_WGT.Text = "";

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            TXT_CNT.Text = "";
            TXT_WGT.Text = "";
            chk_all_ord.Checked = false;
            txt_all_ord.Text = "N";

            return true;

        }

        public override void Form_Ref()
        {
            int iRow;
            int iCol;

            p_Ref(1, 1, true, true);

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                if ( convertX(ss1.ActiveSheet.Cells[iRow - 1, SS1_ORD_CNT].Text) > 1)
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSPpdt.BackColor);
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
            try
            {
                if (value != "")
                {
                    return Convert.ToDouble(value);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public int convertI(string value)
        {
            try
            {
                if (value != "")
                {
                    return Convert.ToInt32(value);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public short convertS(string value)
        {
            try
            {
                if (value != "")
                {
                    return Convert.ToInt16(value);
                }
                return 0;
            }
            catch
            {
                return 0;
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

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            int iDR;
            string sStlgrd;
            string dPthk;

            if (ss1.ActiveSheet.RowCount <= 0) return;

            if (!e.RowHeader) return;

            sStlgrd = ss1.ActiveSheet.Cells[e.Row, SS1_STDSPEC].Text.Trim();
            dPthk = ss1.ActiveSheet.Cells[e.Row, SS1_THK].Text.Trim();

            for (iDR = 1; iDR <= ss1.ActiveSheet.RowCount; iDR++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iDR - 1, 0].Text == "修改")
                {
                    if (sStlgrd != ss1.ActiveSheet.Cells[iDR - 1, SS1_STDSPEC].Text)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("不一样标准", "I", "提示");
                        return;
                    }

                }
            }

            string plate_no;
            int iCnt;
            int iPlate_cnt;
            double iPlate_wgt;

            int tRow;

            iPlate_cnt = 0;
            iPlate_wgt = 0;

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text == "")
            {
                plate_no = ss1.ActiveSheet.Cells[e.Row, 2].Text;

                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

                for (iCnt = 1; iCnt <= ss1.ActiveSheet.RowCount; iCnt += 1)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text.Trim() != "")
                    {
                        iPlate_cnt = iPlate_cnt + 1;
                        iPlate_wgt = iPlate_wgt + convertX(ss1.ActiveSheet.Cells[iCnt - 1, 24].Text);
                    }
                }

                TXT_CNT.Text = iPlate_cnt.ToString();
                TXT_WGT.Text = iPlate_wgt.ToString();
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
            }

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text != "")
            {
                plate_no = ss1.ActiveSheet.Cells[e.Row, 2].Text;

                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";

                for (iCnt = 1; iCnt <= ss1.ActiveSheet.RowCount; iCnt += 1)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text != "")
                    {
                        iPlate_cnt = iPlate_cnt + 1;
                        iPlate_wgt = iPlate_wgt + convertX(ss1.ActiveSheet.Cells[iCnt - 1, 24].Text);
                    }
                }

                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

                TXT_CNT.Text = iPlate_cnt.ToString();
                TXT_WGT.Text = iPlate_wgt.ToString();

            }

            string tmpLOTNO;

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text == "修改")
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SS1_LOT_NO].Text = "";
                tmpLOTNO = ss1.ActiveSheet.Cells[e.Row, SS1_LOT_NO_TEMP].Text;
                ss1.ActiveSheet.Cells[e.Row, SS1_LOT_NO].Text = tmpLOTNO;

                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, Color.White);

            }
            else
            {
                if (ss1.ActiveSheet.Cells[e.Row, SS1_PLT].Text == txt_InPlt.Text)
                {
                    ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                    ss1.ActiveSheet.Cells[e.Row, SS1_LOT_NO].Text = txt_LotNo.Text;
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, ColorTranslator.FromHtml("#C0FFFF"));
                }
            }

        }

        private void txt_InPlt_TextChanged(object sender, EventArgs e)
        {
            string lot_no;

            if (txt_InPlt.Text.Length == 2)
            {
                if (txt_InPlt.Text == "B1")
                {
                    txt_LotNo.Text = "74" + "50" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
                    opt_bz1.Visible = false;
                    opt_bz2.Visible = false;
                    opt_bz1.Checked = false;
                    opt_bz2.Checked = false;
                }
                else if (txt_InPlt.Text == "B3")
                {
                    txt_LotNo.Text = "74" + "01" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
                    opt_bz1.Visible = false;
                    opt_bz2.Visible = false;
                    opt_bz1.Checked = false;
                    opt_bz2.Checked = false;
                }
                else if (txt_InPlt.Text == "BZ")
                {
                    txt_LotNo.Text = "74" + "10" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
                    opt_bz1.Visible = true;
                    opt_bz2.Visible = true;
                    opt_bz1.Checked = true;
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认板坏生产工厂...!", "I", "提示");
                    return;
                }
            }
        }

        private void txt_InSeq_TextChanged(object sender, EventArgs e)
        {
            if (txt_InPlt.Text == "B1")
            {
                txt_LotNo.Text = "74" + "50" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
            }
            else if (txt_InPlt.Text == "B3")
            {
                txt_LotNo.Text = "74" + "01" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
            }
            else if (txt_InPlt.Text == "BZ")
            {
                if (opt_bz1.Checked == true)
                {
                    txt_LotNo.Text = "74" + "10" + substr(txt_DATE.RawDate, 2, 6) + txt_InSeq.Text;
                }
                else if (opt_bz2.Checked == true)
                {
                    txt_LotNo.Text = "74" + "30" + substr(txt_DATE.RawDate, 3, 6) + txt_InSeq.Text;
                }
            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认板坏生产工厂...!", "I", "提示");
                return;
            }
        }

        private void cmd_mill_exc_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                int rowCount = ss1.ActiveSheet.RowCount;
                setExcelText(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\CKG2040C.xls";

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText(string targetExcelName, int rowCount)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            int k;
            for (int j = 0; j < ss1.ActiveSheet.RowCount; j++)
            {
                k = j + 3;
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_SLAB_NO].Text;//
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_LOT_NO].Text;//
                appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_THK].Text;//
                appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_WID].Text;//
                appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_LEN].Text;//
                appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_TRIM_FL].Text;//
                appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE_KND].Text;//
                appExcel.Cells[k, 11] = this.ss1.ActiveSheet.Cells[j, SS1_LEN_L].Text;//
                appExcel.Cells[k, 12] = this.ss1.ActiveSheet.Cells[j, SS1_THK_L].Text;//
                appExcel.Cells[k, 13] = this.ss1.ActiveSheet.Cells[j, SS1_ASROLL_LEN].Text;//
                appExcel.Cells[k, 14] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_NO].Text;//
                appExcel.Cells[k, 15] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_ITEM].Text;//
                appExcel.Cells[k, 16] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_WGT].Text;//
                appExcel.Cells[k, 17] = this.ss1.ActiveSheet.Cells[j, SS1_TEST_TYPE].Text;//
                appExcel.Cells[k, 18] = this.ss1.ActiveSheet.Cells[j, SS1_TEST_WGT].Text;//
                appExcel.Cells[k, 19] = this.ss1.ActiveSheet.Cells[j, SS1_ORD_CNT].Text;//
            }

            appExcel.Visible = true;
            //  appExcel.Quit();//从内存中退出
            appExcel = null;



        }
           
    }
}
