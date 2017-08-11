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
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   轧辊管理
//-- Program Name      轧辊使用实绩查询及修改界面_CGF2060C
//-- Program ID        CGF2060C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.11
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.11       韩超        轧辊使用实绩查询及修改界面_CGF2060C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2060C : CommonClass.FORMBASE
    {
        public CGF2060C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        string sQuery_load;



        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号", CBO_ROLL_ID, "PNIRL", "", "", "", "", imcseq);//0
            p_SetMc("工厂代码", CBO_PLT, "NIR", "", "", "", "", imcseq); //1
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq); //2
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq); //3
            p_SetMc("作业人员", TXT_UPD_EMP, "NI", "", "", "", "", imcseq); //4
            p_SetMc("配辊号", CBO_PIAR_ROLL_ID, "NIR", "", "", "", "", imcseq); //5
            p_SetMc("", SDB_ROLL_SHLD_DIA, "R", "", "", "", "", imcseq); //6
            p_SetMc("", SDB_ROLL_NECK_DIA, "R", "", "", "", "", imcseq); //7
            p_SetMc("开始使用时间", TXT_MILL_STA_TIME, "NIR", "", "", "", "", imcseq); //8
            p_SetMc("", TXT_MILL_END_TIME, "IR", "", "", "", "", imcseq); //9
            p_SetMc("", TXT_ROLL_MATERIAL, "R", "", "", "", "", imcseq); //10
            p_SetMc("", SDB_ROLL_MILL_WGT, "IR", "", "", "", "", imcseq); //11
            p_SetMc("", SDB_TOT_MILL_WGT, "RL", "", "", "", "", imcseq); //12
            p_SetMc("", SDB_ROLL_MILL_CNT, "IR", "", "", "", "", imcseq); //13
            p_SetMc("", SDB_TOT_MILL_CNT, "RL", "", "", "", "", imcseq); //14
            p_SetMc("", SDB_ROLL_MILL_LEN, "IR", "", "", "", "", imcseq); //15
            p_SetMc("", SDB_TOT_MILL_LEN, "RL", "", "", "", "", imcseq); //16
            p_SetMc("", SDB_ROLL_CROWN, "R", "", "", "", "", imcseq); //17
            p_SetMc("", SDB_ROLL_USE_TM, "RL", "", "", "", "", imcseq); //18
            p_SetMc("", TXT_PIAR_SHIFT, "RL", "", "", "", "", imcseq); //19
            p_SetMc("", TXT_PIAR_GROUP, "RL", "", "", "", "", imcseq); //20
            p_SetMc("", TXT_PIAR_EMP, "RL", "", "", "", "", imcseq); //21
            p_SetMc("", TXT_ROLL_MAKER, "RL", "", "", "", "", imcseq); //22
            p_SetMc("", TXT_MAKER_NO, "RL", "", "", "", "", imcseq); //23
            p_SetMc("", SDB_TOT_ROLL_CNT, "RL", "", "", "", "", imcseq); //24


            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("轧辊号", CBO_ROLL_ID, "PNR", "", "", "", "", imcseq); //0
            p_SetMc("", CBO_PIAR_ROLL_ID, "R", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_CROWN, "R", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_ROLL_MATERIAL, "R", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_ROLL_MAKER, "R", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_MAKER_NO, "R", "", "", "", "", imcseq); //0

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("轧辊号", CBO_ROLL_ID, "PN", "", "", "", "", imcseq); //0
            p_ScIni(ss1, Sc1, 0, false, true);
            int iscseq;
            int iheadrow;
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("使用序号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("开始使用时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("结束使用时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("使用持续时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("辊身直径", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("辊颈直径", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("轧制重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("轧制板坯数", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("轧制公里数", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("轧辊凸度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("配辊号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //10


        }

        private void CBO_ROLL_ID_Chg()
        {
            string SMESG;
            if (CBO_ROLL_ID.Text.Trim().Length > 7)
            {
                SMESG = "轧辊号长度不能超过7位，请确认轧辊号 ！！！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                return;
            }
            if (CBO_ROLL_ID.Text.Trim().Length == 7)
            {
                p_Ref(2, 0, true, true);
            }
            else
            {
                CBO_PIAR_ROLL_ID.Text = "";
                TXT_ROLL_MATERIAL.Text = "";
                TXT_MAKER_NO.Text = "";
                TXT_ROLL_MAKER.Text = "";
            }

        }

        private void CBO_ROLL_ID_Clk()
        {
            if (CBO_ROLL_ID.Text.Trim().Length == 7)
            {
                p_Ref(2, 0, true, true);
            }
            else
            {
                CBO_PIAR_ROLL_ID.Text = "";
                TXT_ROLL_MATERIAL.Text = "";
                TXT_MAKER_NO.Text = "";
                TXT_ROLL_MAKER.Text = "";
            }
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2060NC";
            Form_Define();
            TXT_UPD_EMP.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";
            sQuery_load = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS <> 'DL' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,6,2)  ";

            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
            GeneralCommon.Gf_ComboAdd(CBO_PIAR_ROLL_ID, sQuery_load);

            CBO_ROLL_ID.Enabled = true;


        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_UPD_EMP.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";

            }
            return true;
        }

        public override void Form_Ref()
        {
            p_Ref(1, 0, true, true);
            p_Ref(3, 1, true, true);
            TXT_UPD_EMP.Text = GeneralCommon.sUserID;

        }

        public override void Form_Pro()
        {
            string SMESG;
            TXT_UPD_EMP.Text = GeneralCommon.sUserID;
            if (!Gp_DateCheck(TXT_MILL_STA_TIME.Text, ""))
            {
                SMESG = " 请正确输入开始使用时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                return;
            }

            if (TXT_MILL_STA_TIME.Text != "    -  -     :  :" & TXT_MILL_END_TIME.Text != "    -  -     :  :")
            {
                if (!Gp_DateCheck(TXT_MILL_END_TIME.Text, ""))
                {
                    SMESG = " 请正确输入结束使用时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
                if (convertX(TXT_MILL_STA_TIME.Text.Replace("-", "").Replace(" ", "").Replace(":", "")) - convertX(TXT_MILL_END_TIME.Text.Replace("-", "").Replace(" ", "").Replace(":", "")) > 0)
                {
                    SMESG = " 结束使用时间应大于开始使用时间，请正确输入时间信息 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }
            p_Pro(1, 0, true, true);
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
            CBO_ROLL_ID_Chg();
        }

    }
}
