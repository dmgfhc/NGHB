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
//-- Program Name      轧辊装配查询及修改界面_CGF2050C
//-- Program ID        CGF2050C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.07
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.07       韩超        轧辊装配查询及修改界面_CGF2050C
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
        string control = "*";



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
            p_SetMc("轧辊号", CBO_ROLL_ID, "PNR", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_SHLD_DIA, "R", "", "", "", "", imcseq); //1
            p_SetMc("", TXT_ROLL_MATERIAL, "R", "", "", "", "", imcseq); //2
            p_SetMc("", SDB_ROLL_CROWN, "R", "", "", "", "", imcseq); //3
            p_SetMc("", TXT_ROLL_MAKER, "R", "", "", "", "", imcseq); //4
            p_SetMc("", TXT_MAKER_NO, "R", "", "", "", "", imcseq); //5



            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("配辊号", CBO_PIAR_ROLL_ID, "PNR", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_SHLD_DIA1, "R", "", "", "", "", imcseq); //1
            p_SetMc("", TXT_ROLL_MATERIAL1, "R", "", "", "", "", imcseq); //2
            p_SetMc("", SDB_ROLL_CROWN1, "R", "", "", "", "", imcseq); //3
            p_SetMc("", TXT_ROLL_MAKER1, "R", "", "", "", "", imcseq); //4
            p_SetMc("", TXT_MAKER_NO1, "R", "", "", "", "", imcseq); //5



        }

        private void CBO_PIAR_ROLL_ID_Clk()
        {
            if (control == "*")
            {
                p_Ref(3, 0, true, true);
            }
                CBO_PIAR_ROLL_ID.Enabled = true;
        }

        private void CBO_ROLL_ID_Clk()
        {   
            p_Ref(2, 0, true, true);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2050NC";
            Form_Define();
            CBO_EMP1.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";
            CBO_ROLL_TOP_BOT.Text = "T:上";
            GeneralCommon.Gf_ComboAdd(CBO_EMP2, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");
            GeneralCommon.Gf_ComboAdd(CBO_EMP3, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");
            GeneralCommon.Gf_ComboAdd(CBO_EMP4, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");

            Gf_ComboAdd1();
        }


        public override bool Form_Cls()
        {
            control = "";
            if (base.Form_Cls())
            {
                CBO_EMP1.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";
                CBO_ROLL_TOP_BOT.Text = "T:上";

            }
            return true;
        }

        public override void Form_Ref()
        {
            control = "";
            p_Ref(1, 0, true, true);
            control = "*";
            CBO_PIAR_ROLL_ID_Clk();
            
        }

        public override void Form_Pro()
        {
            string SMESG;
            control = "";

            if (!Gp_DateCheck(TXT_MILL_STA_TIME.Text, ""))
            {
                SMESG = " 请正确输入装辊时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                return;
            }
            if (substr(CBO_ROLL_ID.Text, 1, 1) == "1")
            {
                if (CBO_ROLL_TOP_BOT.Text != "O" && CBO_ROLL_TOP_BOT.Text != "D")
                {
                    SMESG = " 请正确输入轧辊位置 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }
            else
            {
                if (substr(CBO_ROLL_TOP_BOT.Text, 0, 1) != "T" && substr(CBO_ROLL_TOP_BOT.Text, 0, 1) != "B")
                {
                    SMESG = " 请正确输入轧辊位置 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }
            p_pro(1, 0, true, true);

        }

        public override void Form_Del()
        {
            control = "";
            p_del(1, 0, true);
        }

        public void Gf_ComboAdd1()
        {
            string squery1 = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS <> 'DL' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,6,2)  ";
            string squery2 = "SELECT CHOCK_ID FROM GP_CHOCK3 WHERE STATUS<>'DL' OR STATUS IS NULL   ";

            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, squery1);
            GeneralCommon.Gf_ComboAdd(CBO_PIAR_ROLL_ID, squery1);

            GeneralCommon.Gf_ComboAdd(CBO_WK_CHOCK, squery2);
            GeneralCommon.Gf_ComboAdd(CBO_DS_CHOCK, squery2);
            GeneralCommon.Gf_ComboAdd(CBO_PIAR_WK_CHOCK, squery2);
            GeneralCommon.Gf_ComboAdd(CBO_PIAR_DS_CHOCK, squery2);
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


        private void CBO_ROLL_ID_TextChanged(object sender, EventArgs e)
        {
            CBO_ROLL_ID_Clk();
        }

        private void CBO_PIAR_ROLL_ID_TextChanged(object sender, EventArgs e)
        {
            CBO_PIAR_ROLL_ID_Clk();
        }

        private void CBO_PIAR_ROLL_ID_Click(object sender, EventArgs e)
        {
            control = "*";
        }



    }
}
