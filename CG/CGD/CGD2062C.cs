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
//-- Program Name      母板分段实绩查询_CGT2020C
//-- Program ID        CGT2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.22       韩超        母板分段实绩查询_CGT2020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGD2062C : CommonClass.FORMBASE
    {
        public CGD2062C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始日期", SDT_PROD_DATE_FROM, "PN", " ", "", "", "", imcseq);
            p_SetMc("结束日期", SDT_PROD_DATE_TO, "PN", " ", "", "", "", imcseq);
            p_SetMc("", TXT_CO_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("", TXT_OVER_FL, "P", " ", "", "", "", imcseq);
            
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("品种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("当日块", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("当月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("当日重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("当日块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("当日重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("月重量（t）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("当日块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("月块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("当日探伤合格率%", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("当月探伤合格率%", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
           
            iheadrow = 0;
            p_spanSpread("合格品", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("不合格品", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("合计", 10, 13, iscseq, iheadrow, 1);

        }

        private void CGD2062C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2062NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            //ss1.ActiveSheet.FrozenColumnCount = 2;

            OPT_ALL.Checked = true;

            if (OPT_ALL.Checked)
            {
                TXT_OVER_FL.Text = "1";
            }

            if (OPT_OVER.Checked)
            {
                TXT_OVER_FL.Text = "2";
            }

            if (OPT_NOT_OVER.Checked)
            {
                TXT_OVER_FL.Text = "3";
            }

            if (OPT_HEAD.Checked)
            {
                TXT_OVER_FL.Text = "4";
            }

            if (OPT_TAIL.Checked)
            {
                TXT_OVER_FL.Text = "5";
            }



        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

             OPT_ALL.Checked = true;

             TXT_OVER_FL.Text = "1"; 

            return true;
        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);

            if (ss1.ActiveSheet.RowCount <= 0) return;

            Data_Sum_Edit();

        }

        private void Data_Sum_Edit()
        {
            double[] cSum = new double[15];
            double[] cSumTotal = new double[15]; ;
            string sSpecTemp = "";
            double dThkTemp;
            string sSpec;
            double dThk;
            int iIdr;
            int iIdc;
            int iRow;

            iRow = 0;

                for (iIdr = 1; iIdr <= ss1.ActiveSheet.RowCount; iIdr++)
                {
                    iRow = iRow + 1;

                    sSpec = ss1.ActiveSheet.Cells[iRow-1,0].Text;
                    dThk = convertX(ss1.ActiveSheet.Cells[iRow-1,1].Text);

                    if (sSpecTemp != sSpec && iRow != 1)
                    {
                        //ss1.MaxRows = ss1.MaxRows + 1;
                        //.InsertRows iRow, 1
                        //添加一行
                        ss1.ActiveSheet.Rows.Add(iRow-1, 1);

                        ss1.ActiveSheet.Cells[iRow-1,0].Text = sSpecTemp;
                        ss1.ActiveSheet.Cells[iRow-1,1].Text = "小计";

                        for (iIdc = 3; iIdc <= 14; iIdc++)
                        {
                            ss1.ActiveSheet.Cells[iRow - 1, iIdc-1].Text = cSum[iIdc-1].ToString();
                            cSum[iIdc-1] = 0;
                        }

                        //iIdr = iIdr - 1;
                        //iRow = iRow - 1;
                    }
                    else
                    {
                        for (iIdc = 3; iIdc <= 14; iIdc++)
                        {
                            cSum[iIdc - 1] = cSum[iIdc - 1] + convertX(ss1.ActiveSheet.Cells[iRow - 1, iIdc-1].Text);
                            cSumTotal[iIdc - 1] = cSumTotal[iIdc - 1] + convertX(ss1.ActiveSheet.Cells[iRow - 1, iIdc - 1].Text);
                        }
                    }

                    sSpecTemp = sSpec;
                    dThkTemp = dThk;
                }
                ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.RowCount, 1);
                for (iIdc = 3; iIdc <= 14; iIdc++)
                {
                    
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 0].Text = sSpecTemp;
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 1].Text = "小计";
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, iIdc - 1].Text = cSum[iIdc - 1].ToString();

                }

                ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.RowCount, 1);
                for (iIdc = 3; iIdc <= 14; iIdc++)
                {

                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 0].Text = "合计";
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, iIdc - 1].Text = cSumTotal[iIdc - 1].ToString();
                }



                //// ReDim cSum(1 To 6)

                for (iIdr = 1; iIdr <= ss1.ActiveSheet.RowCount; iIdr++)
                {
                    cSum[1] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 2].Text);
                    cSum[2] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 3].Text);
                    cSum[3] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 6].Text);
                    cSum[4] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 7].Text);
                    cSum[5] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 10].Text);
                    cSum[6] = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 11].Text);
                    if (cSum[5] > 0 && cSum[1] > 0) { ss1.ActiveSheet.Cells[iIdr - 1, 14].Text = (cSum[1] / cSum[5] * 100).ToString(); }
                    if (cSum[6] > 0 && cSum[2] > 0) { ss1.ActiveSheet.Cells[iIdr - 1, 15].Text = (cSum[2] / cSum[6] * 100).ToString(); }
                    //If cSum(6) > 0 Then .Col = 17:   .Text = cSum(3) / cSum(6) * 100
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

        private void CMD_CARD_Click(object sender, EventArgs e)
        {


           
        }

        private void OPT_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_ALL.Checked)
            {
                TXT_OVER_FL.Text = "1";
            }

        }

        private void OPT_OVER_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_OVER.Checked)
            {
                TXT_OVER_FL.Text = "2";
            }

        }

        private void OPT_NOT_OVER_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_NOT_OVER.Checked)
            {
                TXT_OVER_FL.Text = "3";
            }

        }

        private void OPT_HEAD_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_HEAD.Checked)
            {
                TXT_OVER_FL.Text = "4";
            }

        }

        private void OPT_TAIL_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_TAIL.Checked)
            {
                TXT_OVER_FL.Text = "5";
            }

        }


    }
}
