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
//-- Sub_System Name   作业指示管理
//-- Program Name      精整作业指示查询界面_CKG2030C
//-- Program ID        CKG2030C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.15
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.25       韩超        精整作业指示查询界面_CKG2030C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CKG2030C : CommonClass.FORMBASE
    {
        public CKG2030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        const int SS2_BLOCK_SEQ = 1;
        const int SS2_SEQ = 2;
        const int SS2_PROD_CD = 3;
        const int SS2_ORD = 8;
        const int SS2_SIZE_KND = 9;
        const int SS2_TRIM_FL = 10;
        const int SS2_UST_FL = 11;
        const int SS2_HTM = 12;
        const int SS2_STDSPEC_YY = 13;
        const int SS2_STLGRD = 14;
        const int SS2_VESSEL_NO = 15;
        const int SS2_COLOR_STROKE = 16;



        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);//0
            p_SetMc("轧制时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq); //1
            p_SetMc("轧制时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq); //2
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq); //3

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("板坯", TXT_SLAB_NO, "P", "", "", "", "", imcseq);//0

            p_ScIni(ss1, Sc1, 0, false, true);
            int iscseq;
            int iheadrow;
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("轧制方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("订单厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("目标厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("厚度下限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("厚度上限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //10
            p_SetSc("订单数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("母板数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("轧制订单", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("轧制结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("板坯规格", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //15

            iheadrow = 0;
            p_spanSpread("轧制实绩", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("板坯号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //8
            p_SetSc("标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("牌号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("探伤", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("船号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("订单备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L"); //17

        }


        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CKG2030NC";
            Form_Define();
            TXT_EMP_CD.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";
            sQuery_load = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS<>'DL' ORDER BY ROLL_NO";

            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
           
            CBO_ROLL_ID.Enabled = true;
        }

        private void CBO_ROLL_ID_Clk()
        {
            string sQuery1;
            string sQuery2;
            string MAXSEQ;
            int MAXSEQ_1;
            string BEF_GRID;

            if (CBO_ROLL_ID.Text != " ")
            {
                sQuery1 = "SELECT ROLL_DIA FROM GP_ROLL3 WHERE ROLL_NO = '" + CBO_ROLL_ID.Text + "' ";
                BEF_GRID = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery1);
                SDB_AFT_GRID_DIA.Text = BEF_GRID;
            }
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_EMP_CD.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";

            }
            return true;
        }

        public override void Form_Ref()
        {
            p_Ref(1, 0, true, true);
            p_Ref(2, 1, true, true);

        }

        public override void Form_Pro()
        {
            p_Pro(1, 0, true, true);
            Form_Ref();
        }

        public override void Form_Del()
        {
            p_del(1, 0, true);
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

        #endregion

        private void CBO_ROLL_ID_TextChanged(object sender, EventArgs e)
        {
            CBO_ROLL_ID_Clk();
        }


    }
}
