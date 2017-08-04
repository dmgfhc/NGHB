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
//-- Program Name      轴承座、轴承保养的管理界面_CGF2031C
//-- Program ID        CGF2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.03
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.03       韩超        轴承座、轴承保养的管理界面_CGF2031C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2050C : CommonClass.FORMBASE
    {
        public CGF2050C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        string sQuery_load;



        protected override void p_SubFormInit()
        {
            int imcseq;
           
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号", CBO_ROLL_ID, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("轧辊号", CBO_ROLL_TOP_BOT, "NIR", "", "", "", "", imcseq);//1
            p_SetMc("工厂代码", CBO_PLT, "NIR", "", "", "", "", imcseq);//2
            p_SetMc("班次", CBO_SHIFT, "NIR", "", "", "", "", imcseq);//3
            p_SetMc("班别", CBO_GROUP, "IR", "", "", "", "", imcseq);//4
            p_SetMc("作业人员", CBO_EMP1, "NIR", "", "", "", "", imcseq);//5
            p_SetMc("", CBO_EMP2, "IR", "", "", "", "", imcseq);//6
            p_SetMc("", CBO_EMP3, "IR", "", "", "", "", imcseq);//7
            p_SetMc("", CBO_EMP4, "IR", "", "", "", "", imcseq);//8
            p_SetMc("装辊时间", TXT_MILL_STA_TIME, "NIR", "", "", "", "", imcseq);//9
            p_SetMc("辊身直径", SDB_ROLL_SHLD_DIA, "NIR", "", "", "", "", imcseq);//10
            p_SetMc("", SDB_ROLL_NECK_DIA, "IR", "", "", "", "", imcseq);//11
            p_SetMc("供货商", TXT_ROLL_MATERIAL, "NIR", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_ROLL_CROWN, "IR", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_PLANK_VAL, "IR", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_DZB_VAL, "IR", "", "", "", "", imcseq);//15
            p_SetMc("", CBO_WK_CHOCK, "IR", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_WK_CHOCK_VAL, "IR", "", "", "", "", imcseq);//17
            p_SetMc("", CBO_DS_CHOCK, "IR", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_DS_CHOCK_VAL, "IR", "", "", "", "", imcseq);//19
            p_SetMc("配辊号", CBO_PIAR_ROLL_ID, "NIR", "", "", "", "", imcseq);//20
            p_SetMc("辊身直径", SDB_ROLL_SHLD_DIA1, "NIR", "", "", "", "", imcseq);//21
            p_SetMc("", SDB_ROLL_NECK_DIA1, "IR", "", "", "", "", imcseq);//22
            p_SetMc("供货商", TXT_ROLL_MATERIAL1, "NIR", "", "", "", "", imcseq);//23
            p_SetMc("", SDB_ROLL_CROWN1, "IR", "", "", "", "", imcseq);//24
            p_SetMc("", CBO_PIAR_WK_CHOCK, "IR", "", "", "", "", imcseq);//25
            p_SetMc("", SDB_PIAR_WK_CHOCK_VAL, "IR", "", "", "", "", imcseq);//26
            p_SetMc("", CBO_PIAR_DS_CHOCK, "IR", "", "", "", "", imcseq);//27
            p_SetMc("", SDB_PIAR_DS_CHOCK_VAL, "IR", "", "", "", "", imcseq);//28
            p_SetMc("", TXT_MAKER_NO, "R", "", "", "", "", imcseq);//29
            p_SetMc("", TXT_MAKER_NO1, "R", "", "", "", "", imcseq);//30



            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("", CBO_ROLL_ID, "PR", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_SHLD_DIA, "R", "", "", "", "", imcseq); //1
            p_SetMc("", TXT_ROLL_MATERIAL, "R", "", "", "", "", imcseq); //2
            p_SetMc("", SDB_ROLL_CROWN, "R", "", "", "", "", imcseq); //3
            p_SetMc("", TXT_ROLL_MAKER, "R", "", "", "", "", imcseq); //4
            p_SetMc("", TXT_MAKER_NO, "R", "", "", "", "", imcseq); //5
          


            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("", CBO_PIAR_ROLL_ID, "PR", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_SHLD_DIA1, "R", "", "", "", "", imcseq); //1
            p_SetMc("", TXT_ROLL_MATERIAL1, "R", "", "", "", "", imcseq); //2
            p_SetMc("", SDB_ROLL_CROWN1, "R", "", "", "", "", imcseq); //3
            p_SetMc("", TXT_ROLL_MAKER1, "R", "", "", "", "", imcseq); //4
            p_SetMc("", TXT_MAKER_NO1, "R", "", "", "", "", imcseq); //5
           


        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2020NC";
            Form_Define();
            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";


            sc2.ForeColor = Color.Red;
            sc3.ForeColor = Color.Black;
            sc4.ForeColor = Color.Black;
            sc2.Checked = true;
            sc3.Checked = false;
            sc4.Checked = false;
            //sf1.Enabled = true;
            //sf2.Enabled = false;
            //sf3.Enabled = false;
            //sf4.Enabled = false;

           // string sQuery_load = "";
            sQuery_load = "SELECT CHOCK_ID FROM GP_CHOCK3";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
            ULabel16.Text = "轴承座号";
        }
        

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";


                sc2.ForeColor = Color.Red;
                sc3.ForeColor = Color.Black;
                sc4.ForeColor = Color.Black;
                sc2.Checked = true;
                sc3.Checked = false;
                sc4.Checked = false;
                //sf1.Enabled = true;
                //sf2.Enabled = false;
                //sf3.Enabled = false;
                //sf4.Enabled = false;

                // string sQuery_load = "";
                sQuery_load = "SELECT CHOCK_ID FROM GP_CHOCK3";
                GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
                ULabel16.Text = "轴承座号";

                CBO_ROLL_ID.Text = "";
                CBO_GROUP.Text = "";
            }
            return true;
        }

        public override void Form_Ref()
        {
            switch (substr(CBO_ROLL_ID.Text.Trim(),0,1))
            {
                case "B":
                    p_Ref(3, 0, true, true);
                    break;
                case "C":
                    p_Ref(2, 0, true, true);
                    break;
                case "P":
                    p_Ref(4, 0, true, true);
                    break;
            }
        }

        public override void Form_Pro()
        {
            string SMESG;
            int i;
            bool mResult;

            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;

            switch (substr(CBO_ROLL_ID.Text, 0, 1))
            {
                case "B":

                    if (!Gp_DateCheck(UTP_B_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入轴承座入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    p_pro(3, 0, true, true);
                    break;
                case "C":
                    if (!Gp_DateCheck(UTP_C_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入轴承入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    p_pro(2, 0, true, true);
                    break;
                case "P":
                     if (!Gp_DateCheck(UTP_P_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入护板入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }

                    p_pro(4, 0, true, true);
                    break;
            }
        }

        public override void Form_Del()
        {
            switch (substr(CBO_ROLL_ID.Text, 0, 1))
            {
                case "B":
                    p_del(3, 0, true);
                    break;
                case "C":
                    p_del(2, 0, true);
                    break;
                case "P":
                    p_del(4, 0, true);
                    break;
            }
        }

        private void sc2_Clk()
        {

            CBO_ROLL_ID.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc1["rControl"]);

            if (!sc2.Checked)
            {
                if (!sc3.Checked & !sc4.Checked)
                {
                    sc2.Checked = true;

                }
                return;
            }

            sc2.ForeColor = Color.Red;
            sc3.ForeColor = Color.Black;
            sc3.Checked = false;
            sc4.ForeColor = Color.Black;
            sc4.Checked = false;
            //sf2.Enabled = true;
            //sf1.Enabled = false;
            //sf3.Enabled = false;
            //sf4.Enabled = false;
            ULabel16.Text = "轴承座号";
            sQuery_load = "SELECT CHOCK_ID FROM GP_CHOCK3    ";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
        }


        private void sc3_Clk()
        {

            CBO_ROLL_ID.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc2["rControl"]);

            if (!sc3.Checked)
            {
                if (!sc2.Checked & !sc4.Checked)
                {
                    sc3.Checked = true;

                }
                return;
            }

            //  If sc2.Value = -1 Then    '-1: ssCBChecked
            sc3.ForeColor = Color.Red;
            sc2.ForeColor = Color.Black;
            sc2.Checked = false;
            sc4.ForeColor = Color.Black;
            sc4.Checked = false;
            //sf3.Enabled = true;
            //sf1.Enabled = false;
            //sf2.Enabled = false;
            //sf4.Enabled = false;
            ULabel16.Text = "轴承号";
            sQuery_load = "SELECT BEARING_ID FROM GP_BEARING3    ";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);

        }

        private void sc4_Clk()
        {

            CBO_ROLL_ID.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc3["rControl"]);

            if (!sc4.Checked)
            {
                if (!sc2.Checked & !sc3.Checked)
                {
                    sc4.Checked = true;

                }
                return;
            }

            sc4.ForeColor = Color.Red;
            sc2.ForeColor = Color.Black;
            sc2.Checked = false;
            sc3.ForeColor = Color.Black;
            sc3.Checked = false;
            //sf4.Enabled = true;
            //sf1.Enabled = false;
            //sf2.Enabled = false;
            //sf3.Enabled = false;
            ULabel16.Text = "护板号";
            sQuery_load = "SELECT PLANK_NO FROM GP_PLANK3    ";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);

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

        #endregion

        private void sc2_CheckedChanged(object sender, EventArgs e)
        {
            sc2_Clk();
        }

        private void sc3_CheckedChanged(object sender, EventArgs e)
        {
            sc3_Clk();
        }

        private void sc4_CheckedChanged(object sender, EventArgs e)
        {
            sc4_Clk();
        }



    }
}
