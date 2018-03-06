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
//-- Program Name      轧辊入库管理界面
//-- Program ID        CGF2010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.07.24
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.07.24       韩超        轧辊入库管理
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2010C : CommonClass.FORMBASE
    {
        public CGF2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();
        string sQuery_load;



        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("工厂代码", CBO_PLT, "NIR", "", "", "", "", imcseq); //1
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq); //2
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq); //3
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq); //4
            p_SetMc("入库时间", UTP_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq); //5
            p_SetMc("轧辊标识号", TXT_ROLL_NO, "NIR", "", "", "", "", imcseq); //6
            p_SetMc("", TXT_ROLL_MAKER, "IR", "", "", "", "", imcseq); //7
            p_SetMc("入库辊径", SDB_ROLL_DIA, "NIR", "", "", "", "", imcseq); //8
            p_SetMc("", SDB_ROLL_DIA_Y, "RL", "", "", "", "", imcseq); //9
            p_SetMc("", SDB_ROLL_SHLD_DIA, "IR", "", "", "", "", imcseq); //10
            p_SetMc("", SDB_ROLL_NECK_DIA, "IR", "", "", "", "", imcseq); //11
            p_SetMc("轧辊重量", SDB_ROLL_WGT, "NIR", "", "", "", "", imcseq); //12
            p_SetMc("", SDB_ROLL_IN_W_HARD, "IR", "", "", "", "", imcseq); //13
            p_SetMc("", SDB_ROLL_W_DIA2, "IR", "", "", "", "", imcseq); //14

            p_SetMc("", SDB_ROLL_IN_C_HARD, "IR", "", "", "", "", imcseq); //15
            p_SetMc("", SDB_ROLL_IN_D_HARD, "IR", "", "", "", "", imcseq); //16
            p_SetMc("", SDB_ROLL_D_DIA2, "IR", "", "", "", "", imcseq); //17
            p_SetMc("", SDB_ROLL_IN_AVE_HARD, "RL", "", "", "", "", imcseq); //18
            p_SetMc("", TXT_ROLL_MATERIAL, "IR", "", "", "", "", imcseq); //19
            p_SetMc("", TXT_MAKER_NO, "IR", "", "", "", "", imcseq); //20
            p_SetMc("", TXT_R_SHIFT, "RL", "", "", "", "", imcseq); //21
            p_SetMc("", TXT_R_GROUP, "RL", "", "", "", "", imcseq); //22
            p_SetMc("", TXT_R_IN_EMP, "RL", "", "", "", "", imcseq); //23
            p_SetMc("", TXT_LOC, "IR", "", "", "", "", imcseq); //24
            p_SetMc("", txt_sec_treat_mtd, "IR", "", "", "", "", imcseq); //25
            p_SetMc("", txt_ISSUETALLYNO, "IR", "", "", "", "", imcseq); //26
            p_SetMc("料号", txt_MTRLNO, "NIR", "", "", "", "", imcseq); //27
            p_SetMc("", txt_ROLL_PRICE, "IR", "", "", "", "", imcseq); //28
            p_SetMc("限位辊径", txt_PLAN_DIA, "NIR", "", "", "", "", imcseq); //29

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq); //1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq); //2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq); //3
            p_SetMc("入库时间", UTP_B_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq); //4
            p_SetMc("", UTP_B_ROLL_USE_TIME, "IR", "", "", "", "", imcseq); //5
            p_SetMc("轴承座标识号", TXT_CHOCK_NO, "NIR", "", "", "", "", imcseq); //6
            p_SetMc("", TXT_B_ROLL_MAKER, "IR", "", "", "", "", imcseq); //7
            p_SetMc("", SDB_B_IN_DIA, "IR", "", "", "", "", imcseq); //8
            p_SetMc("", SDB_B_OUT_DIA, "IR", "", "", "", "", imcseq); //9
            p_SetMc("", TXT_B_ROLL_MATERIAL, "IR", "", "", "", "", imcseq); //10
            p_SetMc("", TXT_B_SHIFT, "RL", "", "", "", "", imcseq); //11
            p_SetMc("", TXT_B_GROUP, "RL", "", "", "", "", imcseq); //12
            p_SetMc("", TXT_B_IN_EMP, "RL", "", "", "", "", imcseq); //13

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq); //1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq); //2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq); //3
            p_SetMc("入库时间", UTP_C_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq); //4
            p_SetMc("轴承标识号", TXT_BEAR_NO, "NIR", "", "", "", "", imcseq); //5
            p_SetMc("", TXT_C_ROLL_MAKER, "IR", "", "", "", "", imcseq); //6
            p_SetMc("", SDB_C_IN_DIA, "IR", "", "", "", "", imcseq); //7
            p_SetMc("", SDB_C_OUT_DIA, "IR", "", "", "", "", imcseq); //8
            p_SetMc("", SDB_C_ROLL_WID, "IR", "", "", "", "", imcseq); //9
            p_SetMc("", TXT_C_SHIFT, "RL", "", "", "", "", imcseq); //10
            p_SetMc("", TXT_C_GROUP, "RL", "", "", "", "", imcseq); //11
            p_SetMc("", TXT_C_IN_EMP, "RL", "", "", "", "", imcseq); //12

            p_McIni(Mc4, true);
            imcseq = 4;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq); //1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq); //2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq); //3
            p_SetMc("入库时间", UTP_P_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq); //4
            p_SetMc("护板标识号", TXT_PLANK_NO, "NIR", "", "", "", "", imcseq); //5
            p_SetMc("", TXT_P_ROLL_MAKER, "IR", "", "", "", "", imcseq); //6
            p_SetMc("", TXT_P_SHIFT, "RL", "", "", "", "", imcseq); //7
            p_SetMc("", TXT_P_GROUP, "RL", "", "", "", "", imcseq); //8
            p_SetMc("", TXT_P_IN_EMP, "RL", "", "", "", "", imcseq); //9

        }

        private void CBO_ROLL_NO_Chg()
        {
            if (CBO_ROLL_NO.Text.Trim().Length == 7)
            {
                TXT_ROLL_NO.Text = substr(CBO_ROLL_NO.Text, 5, 2);
            }
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2010NC";
            Form_Define();
            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;
            CBO_PLT.Text = "C3";

            sc1.ForeColor = Color.Red;
            sc2.ForeColor = Color.Black;
            sc3.ForeColor = Color.Black;
            sc4.ForeColor = Color.Black;
            sc1.Checked = true;
            sc2.Checked = false;
            sc3.Checked = false;
            sc4.Checked = false;
            //sf1.Enabled = true;
            //sf2.Enabled = false;
            //sf3.Enabled = false;
            //sf4.Enabled = false;
            ULabel16.Text = "轧辊号";
            //轧辊号栏显示轧辊号
            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS<>'DL' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,6,2) ";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery);
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;
                CBO_PLT.Text = "C3";

                sc1.ForeColor = Color.Red;
                sc2.ForeColor = Color.Black;
                sc3.ForeColor = Color.Black;
                sc4.ForeColor = Color.Black;
                sc1.Checked = true;
                sc2.Checked = false;
                sc3.Checked = false;
                sc4.Checked = false;
                //sf1.Enabled = true;
                //sf2.Enabled = false;
                //sf3.Enabled = false;
                //sf4.Enabled = false;

                CBO_ROLL_NO.Text = "";
                CBO_GROUP.Text = "";
            }
            return true;
        }

        public override void Form_Ref()
        {
            string sQuery_Rt;
            int i;

            if (substr(CBO_ROLL_NO.Text, 0, 1) == "J" || substr(CBO_ROLL_NO.Text, 0, 1) == "C")
            {
                if (p_Ref(1, 0, true, true))
                {
                    ArrayList SSC = new ArrayList();
                    SSC.Add(SSC0);
                    SSC.Add(SSC1);
                    SSC.Add(SSC2);
                    SSC.Add(SSC3);
                    if (txt_sec_treat_mtd.Text != "")
                    {
                        for (i = 1; i <= txt_sec_treat_mtd.Text.Length; i++)
                        {
                            ((CheckBox)SSC[Convert.ToInt32(substr(txt_sec_treat_mtd.Text, i - 1, 1)) - 1]).Checked = true;
                            ((CheckBox)SSC[Convert.ToInt32(substr(txt_sec_treat_mtd.Text, i - 1, 1)) - 1]).ForeColor = Color.Red;
                            //red
                        }
                    }
                }
            }

            switch (substr(CBO_ROLL_NO.Text.Trim(),0,1))
            {

                case "B":
                    p_Ref(3, 0, true, true);
                    break;
                //           Case "C"
                //              If Gf_Ms_Refer(M_CN1, Mc2, Mc2("pControl"), Mc2("pControl")) Then
                //                 Call MDIMain.FormMenuSetting(Me, FormType, "RE", sAuthority)
                //'                 Call Gp_Ms_ControlLock(Mc1("pControl"), True)
                //              End If
                case "P":
                    p_Ref(4, 0, true, true);
                    break;
            }
            CBO_ROLL_NO.Enabled = true;
        }

        public override void Form_Pro()
        {
            string SMESG;
            int i;

            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;


            //    If sc1.ForeColor = &HFF& Then
            //
            //       If Mid(CBO_ROLL_NO.Text, 1, 1) <> "J" Then
            //          sMesg = " 请输入正确的轧辊号 ！"
            //          Call Gp_MsgBoxDisplay(sMesg)
            //          Exit Sub
            //       End If
            //    End If

            if (sc2.Checked)
            {

                if (substr(CBO_ROLL_NO.Text, 0, 1) != "C")
                {
                    SMESG = " 请输入正确的轴承座号 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }


            if (sc3.Checked)
            {

                if (substr(CBO_ROLL_NO.Text, 0, 1) != "B")
                {
                    SMESG = " 请输入正确的轴承号 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }


            if (sc4.Checked)
            {

                if (substr(CBO_ROLL_NO.Text, 0, 1) != "P")
                {
                    SMESG = " 请输入正确的护板号 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
            }

            switch (substr(CBO_ROLL_NO.Text, 0, 1))
            {

                case "J":
                    if (!Gp_DateCheck(UTP_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入轧辊入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    ///'added by guoli at 20081229 103600 for ERP'''''
                    if (txt_ISSUETALLYNO.Text.Trim() == "" && txt_ROLL_PRICE.Text.Trim() == "")
                    {
                        SMESG = "领料单号和单价不能同时为空!";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }

                    if (SDB_ROLL_WGT.NumValue == 0)
                    {
                        SMESG = "轧辊重量不能为空!";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    ///'''''''''''''''''''''''''''''''''''''''''''''''

                    txt_sec_treat_mtd.Text = "";

                    if (SSC0.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(0 + 1);
                    }
                    if (SSC1.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(1 + 1);
                    }
                    if (SSC2.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(2 + 1);
                    }
                    if (SSC3.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(3 + 1);
                    }

                    p_pro(1, 0, true, true);
                    break;
                case "C":
                    if (!Gp_DateCheck(UTP_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入轧辊入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    ///'added by guoli at 20081229 103600 for ERP
                    if (txt_ISSUETALLYNO.Text.Trim() == "" && txt_ROLL_PRICE.Text.Trim() == "")
                    {
                        SMESG = "领料单号和单价不能同时为空!";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }

                    txt_sec_treat_mtd.Text = "";

                    if (SSC0.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(0 + 1);
                    }
                    if (SSC1.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(1 + 1);
                    }
                    if (SSC2.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(2 + 1);
                    }
                    if (SSC3.Checked)
                    {
                        txt_sec_treat_mtd.Text = txt_sec_treat_mtd.Text + Convert.ToString(3 + 1);
                    }

                    p_pro(1, 0, true, true);

                    break;

                case "B":
                    if (!Gp_DateCheck(UTP_B_ROLL_IN_TIME.Text, ""))
                    {
                        SMESG = " 请正确输入轴承座入库时间 ！";
                        GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                        return;
                    }
                    p_pro(3, 0, true, true);
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

            if (substr(CBO_ROLL_NO.Text, 0, 1) == "C")
            {
                if (!Gp_DateCheck(UTP_C_ROLL_IN_TIME.Text, ""))
                {
                    SMESG = " 请正确输入轴承入库时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");
                    return;
                }
                p_pro(2, 0, true, true);
            }

        }

        public override void Form_Del()
        {
            switch (substr(CBO_ROLL_NO.Text, 0, 1))
            {
                case "J":
                    CBO_ROLL_NO.Enabled = false;
                    p_del(1, 0, true);
                    CBO_ROLL_NO.Enabled = true;
                    break;
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

        private void sc1_Clk()
        {

            CBO_ROLL_NO.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc1["rControl"]);

            if (!sc1.Checked)
            {
                if (!sc2.Checked & !sc3.Checked & !sc4.Checked)
                {
                    sc1.Checked = true;

                }
                return;
            }
            sc1.ForeColor = Color.Red;
            sc2.ForeColor = Color.Black;
            sc2.Checked = false;
            sc3.ForeColor = Color.Black;
            sc3.Checked = false;
            sc4.ForeColor = Color.Black;
            sc4.Checked = false;
            //sf1.Enabled = true;
            //sf2.Enabled = false;
            //sf3.Enabled = false;
            //sf4.Enabled = false;
            ULabel16.Text = "轧辊号";
            sQuery_load = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS<>'DL'  ";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery_load);
        }


        private void sc2_Clk()
        {

            CBO_ROLL_NO.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc2["rControl"]);

            if (!sc2.Checked)
            {
                if (!sc1.Checked & !sc3.Checked & !sc4.Checked)
                {
                    sc2.Checked = true;

                }
                return;
            }

            sc2.ForeColor = Color.Red;
            sc1.ForeColor = Color.Black;
            sc1.Checked = false;
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
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery_load);
            
        }


        private void sc3_Clk()
        {

            CBO_ROLL_NO.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc3["rControl"]);

            if (!sc3.Checked)
            {
                if (!sc1.Checked & !sc2.Checked & !sc4.Checked)
                {
                    sc3.Checked = true;

                }
                return;
            }

            //  If sc2.Value = -1 Then    '-1: ssCBChecked
            sc3.ForeColor = Color.Red;
            sc1.ForeColor = Color.Black;
            sc1.Checked = false;
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
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery_load);


        }

        private void sc4_Clk()
        {

            CBO_ROLL_NO.Enabled = true;
            MasterCommon.Gp_Ms_Cls((Collection)Mc4["rControl"]);

            if (!sc4.Checked)
            {
                if (!sc1.Checked & !sc2.Checked & !sc3.Checked)
                {
                    sc4.Checked = true;

                }
                return;
            }

            sc4.ForeColor = Color.Red;
            sc1.ForeColor = Color.Black;
            sc1.Checked = false;
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
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery_load);

        }



        private void SSC_Clk(object sender)
        {
            int i;
            int CNT = 0;
            ArrayList SSC = new ArrayList();
            SSC.Add(SSC0);
            SSC.Add(SSC1);
            SSC.Add(SSC2);
            SSC.Add(SSC3);


            for (i = 0; i <= 3; i++)
            {
                if (((CheckBox)SSC[i]).Checked)
                {
                    CNT = CNT + 1;
                    if (CNT > 3)
                    {
                        ((CheckBox)sender).Checked = false;
                        GeneralCommon.Gp_MsgBoxDisplay("最多只能选择3种二次处理方式！", "I", "提示");
                        return;
                    }
                }
            }

            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).ForeColor = Color.Red;
                //red
            }
            else
            {
                ((CheckBox)sender).ForeColor = Color.Black;
                //black
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

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        #endregion

        private void CBO_ROLL_NO_TextChanged(object sender, EventArgs e)
        {
            CBO_ROLL_NO_Chg();
        }

        private void sc1_CheckedChanged(object sender, EventArgs e)
        {
            sc1_Clk();
        }

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

        private void SSC0_CheckedChanged(object sender, EventArgs e)
        {
            SSC_Clk(sender);
        }

        private void SSC1_CheckedChanged(object sender, EventArgs e)
        {
            SSC_Clk(sender);
        }

        private void SSC2_CheckedChanged(object sender, EventArgs e)
        {
            SSC_Clk(sender);
        }

        private void SSC3_CheckedChanged(object sender, EventArgs e)
        {
            SSC_Clk(sender);
        }






    }
}
