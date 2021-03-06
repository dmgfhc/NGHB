﻿using System.Collections;
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
//-- Program Name      轧辊、轴承座和轴承的报废、查询及修改界面_CGF2020C
//-- Program ID        CGF2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.07.31
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.07.31       韩超        轧辊、轴承座和轴承的报废、查询及修改界面_CGF2020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2030C : CommonClass.FORMBASE
    {
        public CGF2030C()
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
            p_SetMc("轧辊号", CBO_ROLL_ID, "PNIR", "", "", "", "", imcseq);//0
            p_SetMc("", SDB_SEQ_NO, "IRL", "", "", "", "", imcseq);//1
            p_SetMc("工厂代码", CBO_PLT, "NIR", "", "", "", "", imcseq);//2
            p_SetMc("班次", CBO_SHIFT, "NIR", "", "", "", "", imcseq);//3
            p_SetMc("", CBO_GROUP, "IR", "", "", "", "", imcseq);//4
            p_SetMc("作业人员1", CBO_EMP1, "NIR", "", "", "", "", imcseq);//5
            p_SetMc("", CBO_EMP2, "IR", "", "", "", "", imcseq);//6
            p_SetMc("", CBO_EMP3, "IR", "", "", "", "", imcseq);//7
            p_SetMc("", CBO_EMP4, "IR", "", "", "", "", imcseq);//8
            p_SetMc("磨削开始时间", TXT_GRID_STA_TIME, "NIR", "", "", "", "", imcseq);//9
            p_SetMc("", SDB_GRID_NUM, "RL", "", "", "", "", imcseq);//10
            p_SetMc("磨削前辊径 中部", SDB_BEF_GRID_DIA, "NIR", "", "", "", "", imcseq);//11
            p_SetMc("磨削后辊径 中部", SDB_AFT_GRID_DIA, "NIR", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_GRID_WGT, "IR", "", "", "", "", imcseq);//13
            p_SetMc("", TXT_GRID_RESON, "IR", "", "", "", "", imcseq);//14
            p_SetMc("", TXT_GRID_POS, "IR", "", "", "", "", imcseq);//15
            p_SetMc("磨削结束时间", TXT_GRID_END_TIME, "NIR", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_ROLL_CROWN, "IR", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_ROLL_TEMP, "IR", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_BEF_GRID_DA_DIA, "IR", "", "", "", "", imcseq);//19
            p_SetMc("", SDB_BEF_GRID_DB_DIA, "IR", "", "", "", "", imcseq);//20
            p_SetMc("", SDB_BEF_GRID_OA_DIA, "IR", "", "", "", "", imcseq);//21
            p_SetMc("", SDB_BEF_GRID_OB_DIA, "IR", "", "", "", "", imcseq);//22
            p_SetMc("磨削后辊径 驱动侧A", SDB_AFT_GRID_DA_DIA, "NIR", "", "", "", "", imcseq);//23
            p_SetMc("磨削后辊径 驱动侧B", SDB_AFT_GRID_DB_DIA, "NIR", "", "", "", "", imcseq);//24
            p_SetMc("磨削后辊径 工作侧A", SDB_AFT_GRID_OA_DIA, "NIR", "", "", "", "", imcseq);//25
            p_SetMc("磨削后辊径 工作侧B", SDB_AFT_GRID_OB_DIA, "NIR", "", "", "", "", imcseq);//26
            p_SetMc("", SDB_AFT_GRID_DN_DIA, "IR", "", "", "", "", imcseq);//27
            p_SetMc("", SDB_AFT_GRID_ON_DIA, "IR", "", "", "", "", imcseq);//28
            p_SetMc("", SDB_ROLL_HARD, "IR", "", "", "", "", imcseq);//29
            p_SetMc("", SDB_ROLL_MILL_WGT, "RL", "", "", "", "", imcseq);//30
            p_SetMc("", SDB_ROLL_MILL_LEN, "RL", "", "", "", "", imcseq);//31
            p_SetMc("", TXT_ROLL_QX, "IR", "", "", "", "", imcseq);//32
            p_SetMc("", TXT_ROLL_UST, "IR", "", "", "", "", imcseq);//33


            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("轧辊号", CBO_ROLL_ID, "PR", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_ROLL_MAKER, "RL", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_ROLL_MATERIAL, "RL", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_MAKER_NO, "RL", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_ROLL_CROWN_LAST, "RL", "", "", "", "", imcseq); //0
            p_SetMc("", SDB_AFT_GRID_DIA_LAST, "RL", "", "", "", "", imcseq); //0
            p_SetMc("", TXT_ROLL_QX_LAST, "RL", "", "", "", "", imcseq); //0

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("轧辊号", CBO_ROLL_ID, "P", "", "", "", "", imcseq);//0

            p_ScIni(ss1, Sc1, 0, false, true);
            int iscseq;
            int iheadrow;
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("磨削序列号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("磨削开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("磨削结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("磨削原因代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("辊型曲线", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //4
            p_SetSc("轧辊探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //5
            p_SetSc("磨前温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("轧辊硬度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("材质代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //8
            p_SetSc("供货商", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("制造商编号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("磨削次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("轧制公里数", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //12
            p_SetSc("轧制吨位", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("缺陷部位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("磨削前辊径", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //15
            p_SetSc("磨削后辊径", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //16
            p_SetSc("辊身磨削量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //17
            p_SetSc("轧辊凸度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //18

            sQuery_load = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS<>'DL' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,2,1), SUBSTR(ROLL_NO,6,2) ";

        }

        private void CBO_ROLL_ID_Chg()
        {
            if (CBO_ROLL_ID.Text.Trim().Length == 7)
            {
                p_Ref(2, 0, true, true);
            }
            else
            {
                TXT_ROLL_MAKER.Text = "";
                TXT_ROLL_MATERIAL.Text = "";
                TXT_MAKER_NO.Text = "";
                SDB_ROLL_CROWN_LAST.Text = "";
                SDB_AFT_GRID_DIA_LAST.Text = "";
                TXT_ROLL_QX_LAST.Text = "";
            }
        }

        private void CBO_ROLL_ID_Clk()
        {
            if (CBO_ROLL_ID.Text.Trim().Length == 7)
            {
                p_Ref(2, 0, true, true);
            }
        }

        private void chk_c_Click()
        {
            if (!chk_c.Checked)
            {
                if (!chk_w.Checked && !chk_d.Checked)
                {
                    //  CHK_T_T_PART.Value = ssCBChecked
                    TXT_GRID_POS.Text = " ";
                }
                return;
            }

            TXT_GRID_POS.Text = "C";

            chk_c.ForeColor = Color.Red;
            chk_c.Checked = true;

            chk_w.ForeColor = Color.Black;
            chk_w.Checked = false;
            chk_d.ForeColor = Color.Black;
            chk_d.Checked = false;
        }

        private void chk_d_Click()
        {
            if (!chk_d.Checked)
            {
                if (!chk_w.Checked && !chk_c.Checked)
                {
                    //  CHK_T_T_PART.Value = ssCBChecked
                    TXT_GRID_POS.Text = " ";
                }
                return;
            }

            TXT_GRID_POS.Text = "D";

            chk_d.ForeColor = Color.Red;
            chk_d.Checked = true;

            chk_w.ForeColor = Color.Black;
            chk_w.Checked = false;
            chk_c.ForeColor = Color.Black;
            chk_c.Checked = false;
        }

        private void chk_w_Click()
        {
            if (!chk_w.Checked)
            {
                if (!chk_c.Checked&&!chk_d.Checked)
                {
                    //  CHK_T_T_PART.Value = ssCBChecked
                    TXT_GRID_POS.Text = " ";
                }
                return;
            }

            TXT_GRID_POS.Text = "W";

            chk_w.ForeColor = Color.Red;
            chk_w.Checked = true;

            chk_c.ForeColor = Color.Black;
            chk_c.Checked = false;
            chk_d.ForeColor = Color.Black;
            chk_d.Checked = false;
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2030NC";
            Form_Define();
            CBO_EMP1.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";

            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_load);
            GeneralCommon.Gf_ComboAdd(CBO_EMP2, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");
            GeneralCommon.Gf_ComboAdd(CBO_EMP3, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");
            GeneralCommon.Gf_ComboAdd(CBO_EMP4, "SELECT EMP_ID  FROM ZP_EMPLOYEE WHERE EMP_ID LIKE '1ZBR%' ");
          
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                CBO_EMP1.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";

            }
            return true;
        }

        public override void Form_Ref()
        {
            if (p_Ref(1, 0, true, true))
            {
                p_Ref(3, 1, true, true);
            }
        }

        public override void Form_Pro()
        {
            string SMESG;
            bool mResult;

            CBO_EMP1.Text = GeneralCommon.sUserID;

            if (!Gp_DateCheck(TXT_GRID_STA_TIME.Text,""))
            {
                SMESG = " 请正确输入磨削开始时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                return;
            }

            if (TXT_GRID_STA_TIME.Text != "    -  -     :  :" & TXT_GRID_END_TIME.Text != "    -  -     :  :")
            {
                if (!Gp_DateCheck(TXT_GRID_END_TIME.Text,""))
                {
                    SMESG = " 请正确输入磨削结束时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
                if (convertX(TXT_GRID_STA_TIME.Text.Replace("-", "").Replace(" ", "").Replace(":", "")) - convertX(TXT_GRID_END_TIME.Text.Replace("-", "").Replace(" ", "").Replace(":", "")) > 0)
                {
                    SMESG = " 磨削结束时间应大于磨削开始时间，请正确输入时间信息 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }

            ///ADDED BY GUOLI AT 20090401201200 FOR 杨海涛''''''''
            if (CBO_ROLL_ID.Enabled == true)
            {
                SMESG = "请您确定是否保存";
                mResult = GeneralCommon.Gf_MessConfirm(SMESG, "I", "提示");
                if (!mResult)
                {
                    return;
                }
            }
            else if (CBO_ROLL_ID.Enabled == false)
            {
                SMESG = "请您确定是修改内容还是第二次保存内容，若是第二次保存相同内容，将影响ERP计算轧辊辊耗成本，系统将记住您的操作并考核";
                mResult = GeneralCommon.Gf_MessConfirm(SMESG, "I", "提示");
                if (!mResult)
                {
                    return;
                }
            }
            ///'''''''''''''''''''''''''''''''''''''''''''''''''''

            if (p_Pro(1, 0, true, true))
            {
                Form_Ref();
            }
            else
            {
                return;
            }
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

        private void chk_c_CheckedChanged(object sender, EventArgs e)
        {
            chk_c_Click();
        }

        private void chk_d_CheckedChanged(object sender, EventArgs e)
        {
            chk_d_Click();
        }

        private void chk_w_CheckedChanged(object sender, EventArgs e)
        {
            chk_w_Click();
        }







    }
}
