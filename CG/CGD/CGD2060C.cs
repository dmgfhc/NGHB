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

namespace CG
{
    public partial class CGD2060C : CommonClass.FORMBASE
    {
        public CGD2060C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        string sCheck;
        string sQuery;

        public const int iSs1_Plate_No = 0;  //SS1钢板号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("钢板号", TXT_PLATE_NO, "PI ", "", "", "", "", imcseq);//0
            p_SetMc("生产日期", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);//1
            p_SetMc("生产日期", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);//2
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);//3
            p_SetMc("", TXT_PROC_FLAG, "RL", "", "", "", "", imcseq);//4
            p_SetMc("", TXT_APLY_ENDUSE_CD, "RL", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_STLGRD, "RL", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_KIND_NO, "R", "", "", "", "", imcseq);//7
            p_SetMc("", TXT_UST_HEAD, "R", "", "", "", "", imcseq);//8
            p_SetMc("", TXT_UST_METHOD, "R", "", "", "", "", imcseq);//9
            p_SetMc("", TXT_UST_PREC, "R", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_UST_STAND_NO, "NIR", "", "", "", "", imcseq);//11
            p_SetMc("", TXT_UST_GRADE, "IR", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_THK, "NIR", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_INSP_THK_MX, "RL", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_INSP_THK_MN, "RL", "", "", "", "", imcseq);//15
            p_SetMc("", SDB_WID, "NIR", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_INSP_WID_MX, "RL", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_INSP_WID_MN, "RL", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_LEN, "NIR", "", "", "", "", imcseq);//19
            p_SetMc("", SDB_INSP_LEN_MX, "RL", "", "", "", "", imcseq);//20
            p_SetMc("", SDB_INSP_LEN_MN, "RL", "", "", "", "", imcseq);//21
            p_SetMc("", SDB_WGT, "NIR", "", "", "", "", imcseq);//22
            p_SetMc("", SDB_PWGT_MX, "RL", "", "", "", "", imcseq);//23
            p_SetMc("", SDB_PWGT_MN, "RL", "", "", "", "", imcseq);//24
            p_SetMc("", SDB_THK_ORG, "RL", "", "", "", "", imcseq);//25
            p_SetMc("", SDB_WID_ORG, "IRL", "", "", "", "", imcseq);//26
            p_SetMc("", SDB_LEN_ORG, "IRL", "", "", "", "", imcseq);//27
            p_SetMc("", SDB_WGT_ORG, "IRL", "", "", "", "", imcseq);//28
            p_SetMc("", SDB_ORD_THK, "RL", "", "", "", "", imcseq);//29
            p_SetMc("", SDB_ORD_WID, "RL", "", "", "", "", imcseq);//30
            p_SetMc("", SDB_ORD_LEN, "RL", "", "", "", "", imcseq);//31
            p_SetMc("", SDB_WGT_ORD, "RL", "", "", "", "", imcseq);//32
            p_SetMc("", TXT_UST_GRD, "NIR", "", "", "", "", imcseq);//33
            p_SetMc("", TXT_PRD_GRD, "NIR", "", "", "", "", imcseq);//34
            p_SetMc("", TXT_INSP_MAN, "NIR", "", "", "", "", imcseq);//35
            p_SetMc("", TXT_INSP_OCCR_TIME, "NIR", "", "", "", "", imcseq);//36
            p_SetMc("", TXT_ADD_THK, "IR", "", "", "", "", imcseq);//37
            p_SetMc("", TXT_LOC, "IR", "", "", "", "", imcseq);//38
            p_SetMc("", TXT_REMARK, "IR", "", "", "", "", imcseq);//39
            p_SetMc("", txt_stdspec, "IR", "", "", "", "", imcseq);//40
            p_SetMc("", txt_stdspec_chg, "I", "", "", "", "", imcseq);//41
            p_SetMc("", TXT_REASON_FL0, "IR", "", "", "", "", imcseq);//42
            p_SetMc("", TXT_REASON_FL1, "IR", "", "", "", "", imcseq);//43
            p_SetMc("", TXT_REASON_FL2, "IR", "", "", "", "", imcseq);//44
            p_SetMc("", TXT_ADDR0, "R", "", "", "", "", imcseq);//45
            p_SetMc("", TXT_ADDR1, "R", "", "", "", "", imcseq);//46
            p_SetMc("", TXT_ADDR2, "R", "", "", "", "", imcseq);//47
            p_SetMc("", txt_Scrap_code, "I", "", "", "", "", imcseq);//48
            p_SetMc("", txt_Scrap_name, "L", "", "", "", "", imcseq);//49
            p_SetMc("", TXT_NEXT_PROC, "IRL", "", "", "", "", imcseq);//50
            p_SetMc("", TXT_INSP_MAN1, "NIR", "", "", "", "", imcseq);//51
            p_SetMc("", TXT_INSP_MAN2, "IR", "", "", "", "", imcseq);//52
            p_SetMc("", TXT_EQPM, "NI", "", "", "", "", imcseq);//53

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("扎批号", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");//1
            p_SetSc("分段号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("规格尺寸(mm)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("返剪宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("返剪长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("返剪重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("合格", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("探伤日期", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("改判标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("改判原因1", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("改判原因2", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("返剪原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("仪器型号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("探头", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("探伤方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("探伤灵敏度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("检查标准", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("探伤人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22

            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 5, true);

        }
        private void CGD2060C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2060NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D","");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D","");

            if (base.sAuthority == "111")
            {
                Cmd_Edit.Enabled = true;
                Cmd_Edit_Date.Enabled = true;
            }
            else
            {
                Cmd_Edit.Enabled = false;
                Cmd_Edit_Date.Enabled = false;
            }

        }
        #endregion


        private void CHK_NEXT_PRC_Clk()
        {
            

            if (sCheck != "")
                return;

            
            sCheck = "**";

            if (CHK_NEXT_PRC0.Checked)
            {
                TXT_NEXT_PROC.Text = CHK_NEXT_PRC0.Tag.ToString();
                CHK_NEXT_PRC0.ForeColor = Color.Red;
                CHK_NEXT_PRC1.ForeColor = ColorTranslator.FromHtml("#808080");
                CHK_NEXT_PRC1.Checked = false;

            }
            else if (CHK_NEXT_PRC1.Checked)
            {
                TXT_NEXT_PROC.Text = CHK_NEXT_PRC1.Tag.ToString();
                CHK_NEXT_PRC1.ForeColor = Color.Red;
                CHK_NEXT_PRC0.ForeColor = ColorTranslator.FromHtml("#808080");
                CHK_NEXT_PRC0.Checked = false;
            }

            sCheck = "";

        }

        private void Cmd_Edit_Clk()
        {
            string sQuery;
            string sLoc;
            string sComments;
            
            sLoc = TXT_LOC.Text.Trim();
            sComments = TXT_REMARK.Text.Trim();

            sQuery = "         UPDATE  GP_USTRESULT                                      ";
            sQuery = sQuery + "   SET  UST_LOC       = '" + sLoc + "'                    ";
            sQuery = sQuery + "       ,UST_REMARTS   = '" + sComments + "'               ";
            sQuery = sQuery + " WHERE  PLATE_NO      = '" + TXT_PLATE_NO.Text.Trim() + "' ";
            
            GeneralCommon.Gf_ExecSql(GeneralCommon.M_CN1,sQuery);
        }

        private void Cmd_Edit_Date_Clk()
        {
            string sQuery;
            string sUST_END_DATE;
            string sShift;
            string sGroup_cd;

            string SMESG;

            sUST_END_DATE = TXT_INSP_OCCR_TIME.Text;

            sQuery = "         UPDATE  GP_USTRESULT                                      ";
            sQuery = sQuery + "   SET  UST_END_DATE       = '" + sUST_END_DATE + "'      ";
            sQuery = sQuery + "       ,SHIFT              = Gf_Shiftset3('" + sUST_END_DATE + "')             ";
            sQuery = sQuery + "       ,GROUP_CD           = Gf_Groupset('C1',Gf_Shiftset3('" + sUST_END_DATE + "'),'" + sUST_END_DATE.Substring(0,8) + "')           ";
            sQuery = sQuery + " WHERE  PLATE_NO           = '" + TXT_PLATE_NO.Text.Trim() + "' ";

            GeneralCommon.Gf_ExecSql(GeneralCommon.M_CN1, sQuery);

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            TXT_INSP_THK_GRD.Text = "";
            TXT_INSP_WID_GRD.Text = "";
            TXT_INSP_LEN_GRD.Text = "";
            TXT_INSP_WGT_GRD.Text = "";

            CHK_NEXT_PRC0.Checked = false;
            CHK_NEXT_PRC1.Checked = false;

            return true;
        }

        public override void Form_Ref()
        {
            string iAddr;
            string iAddr1;
            string iAddr2;

            string iSTAND_NO;
            string iDATETIME;
            string iTXT_REMARK;

            string SMESG;

            iAddr = TXT_ADDR0.Text;
            iAddr1 = TXT_ADDR1.Text;
            iAddr2 = TXT_ADDR2.Text;

            iSTAND_NO = TXT_UST_STAND_NO.Text;
            iDATETIME = TXT_INSP_OCCR_TIME.Text;
            iTXT_REMARK = TXT_REMARK.Text;

            if (TXT_PLATE_NO.Text != "" && TXT_PLATE_NO.Text.Length < 10)
            {
                SMESG = "物料号必须大于9位 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            p_Ref(1, 1, true, true);

            if (TXT_PLATE_NO.Text.Length == 14 && TXT_PLATE_NO.Text.Substring(0, 2) != "74")
            {
                p_Ref(1, 0, true, true);
            }
            else
            {
                ss1_DblClk(0, 0);
            }

            if (TXT_NEXT_PROC.Text == "" || TXT_NEXT_PROC.Text == "U")
            {
                CHK_NEXT_PRC0.Checked = true;
                TXT_NEXT_PROC.Text = "P";
            }

            if (iAddr.Length == 3 && iAddr1.Length == 4 && iAddr2.Length > 0)
            {
                TXT_LOC.Text = iAddr + iAddr1 + string.Format("{0:D3}", iAddr2);
            }

            if (TXT_UST_STAND_NO.Text == "")
                TXT_UST_STAND_NO.Text = iSTAND_NO;
            if (TXT_INSP_OCCR_TIME.Text == "")
                TXT_INSP_OCCR_TIME.Text = iDATETIME;
            TXT_REMARK.Text = iTXT_REMARK;

            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 5, true);

        }



        public override void Form_Pro()
        {
            string SMESG;
            int iCount;

            string iAddr;
            string iAddr1;
            string iAddr2;

            iAddr = TXT_ADDR0.Text;
            iAddr1 = TXT_ADDR1.Text;
            iAddr2 = TXT_ADDR2.Text;

            if (txt_stdspec_chg.Text != "" && TXT_REASON_FL0.Text.Trim() == "" && TXT_REASON_FL1.Text.Trim() == "")
            {
                SMESG = " 请输入改判原因 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            if (!CHK_PRD_GRD1.Checked)
            {
                if (SDB_WGT_ORG.NumValue > 0 && SDB_WGT.NumValue != SDB_WGT_ORG.NumValue && TXT_REASON_FL2.Text.Trim() == "")
                {
                    SMESG = " 请输入返剪原因 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }

            if (!Gp_DateCheck(TXT_INSP_OCCR_TIME.Text,""))
            {
                SMESG = " 请正确输入检查时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            if (CHK_PRD_GRD4.Checked)
            {
                if (txt_Scrap_code.Text == "")
                {
                    SMESG = " 请正确输入废钢原因 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }

                TXT_INSP_MAN.Text = GeneralCommon.sUserID;
                TXT_INSP_MAN1.Text = CBO_EMP1.Text;
                TXT_INSP_MAN2.Text = CBO_EMP2.Text;

                if (p_Pro(1, 0, true, true))
                {
                    TXT_PLATE_NO.Enabled = true;
                }
        }

        private void SDB_THK_Chg()
        {
            PRD_WEIGHT_CALC();
        }

        private void SDB_WID_Chg()
        {
            PRD_WEIGHT_CALC();
        }

        private void SDB_LEN_Chg()
        {
            PRD_WEIGHT_CALC();
        }
        private void PRD_WEIGHT_CALC()
        {
            double dThk;
            double dWid;
            double dLen;
            string sQuery;
            ADODB.Recordset RS = new ADODB.Recordset();

            dThk = SDB_THK.NumValue;
            dWid = SDB_WID.NumValue;
            dLen = SDB_LEN.NumValue;

            if (dThk > 0 & dWid > 0 & dLen > 0)
            {
                SDB_WGT.Text = Cal_Plate_Wgt("WGT", dThk, dWid, dLen);
                TXT_ADD_THK.Text = Cal_Plate_Wgt("VAT", dThk, dWid, dLen);
            }

            Size_Grade_Edit();
        }

        private void TXT_INSP_MAN_DblClk()
        {
            TXT_INSP_MAN.Text =GeneralCommon.sUserID;
        }

        private void CHK_UST_GRD_Clk(int Index)
        {
            int iNext;

            if (sCheck != "")
                return;

            sCheck = "**";

            ArrayList CHK_UST_GRD = new ArrayList();

            CHK_UST_GRD.Add(CHK_UST_GRD0);
            CHK_UST_GRD.Add(CHK_UST_GRD1);

            if (Index == 0)
            {
                iNext = 1;
            }
            else
            {
                iNext = 0;
            }

            if (!((CheckBox)CHK_UST_GRD[Index]).Checked)
            {
                if (!((CheckBox)CHK_UST_GRD[iNext]).Checked)
                {
                    TXT_UST_GRD.Text = "";
                    ((CheckBox)CHK_UST_GRD[Index]).ForeColor = ColorTranslator.FromHtml("#808080");
                    sCheck = "";
                    return;
                }
            }
            else
            {
                ((CheckBox)CHK_UST_GRD[iNext]).Checked = false;
            }

            ((CheckBox)CHK_UST_GRD[Index]).ForeColor = Color.Red;
            ((CheckBox)CHK_UST_GRD[Index]).Checked = true;

            ((CheckBox)CHK_UST_GRD[iNext]).ForeColor = ColorTranslator.FromHtml("#808080");
            ((CheckBox)CHK_UST_GRD[iNext]).Checked = false;

            TXT_UST_GRD.Text = ((CheckBox)CHK_UST_GRD[Index]).Tag.ToString();
            sCheck = "";

        }

        private void CHK_PRD_GRD_Clk(int Index)
        {
            int iCount;
            int iIndexStr;

            if (sCheck != "")
                return;

            iCount = 0;
            sCheck = "**";

            ArrayList CHK_PRD_GRD = new ArrayList();
            CHK_PRD_GRD.Add(CHK_PRD_GRD0);
            CHK_PRD_GRD.Add(CHK_PRD_GRD1);
            CHK_PRD_GRD.Add(CHK_PRD_GRD2);
            CHK_PRD_GRD.Add(CHK_PRD_GRD3);
            CHK_PRD_GRD.Add(CHK_PRD_GRD4);
            CHK_PRD_GRD.Add(CHK_PRD_GRD5);

            if (!((CheckBox)CHK_PRD_GRD[Index]).Checked)
            {
                for (iIndexStr = 0; iIndexStr <= 5; iIndexStr++)
                {
                    if (((CheckBox)CHK_PRD_GRD[iIndexStr]).Checked)
                    {
                        iCount = iCount + 1;
                    }
                }
                if (iCount == 0)
                {
                    TXT_PRD_GRD.Text = "";
                    ((CheckBox)CHK_PRD_GRD[Index]).ForeColor = ColorTranslator.FromHtml("#808080");
                    sCheck = "";
                    return;
                }
            }
            else
            {
                for (iIndexStr = 0; iIndexStr <= 5; iIndexStr++)
                {
                    ((CheckBox)CHK_PRD_GRD[iIndexStr]).ForeColor = ColorTranslator.FromHtml("#808080");
                    ((CheckBox)CHK_PRD_GRD[iIndexStr]).Checked = false;
                }
            }

            ((CheckBox)CHK_PRD_GRD[Index]).ForeColor = Color.Red;
            ((CheckBox)CHK_PRD_GRD[Index]).Checked = true;

            TXT_PRD_GRD.Text = ((CheckBox)CHK_PRD_GRD[Index]).Tag.ToString();

            txt_stdspec_chg.Text = "";
            txt_stdspec_name_chg.Text = "";
            if (((CheckBox)CHK_PRD_GRD[1]).Checked || ((CheckBox)CHK_PRD_GRD[2]).Checked || ((CheckBox)CHK_PRD_GRD[5]).Checked)
            {
                txt_stdspec_chg.Enabled = true;
            }
            else
            {
                txt_stdspec_chg.Enabled = false;
            }

            if (((CheckBox)CHK_PRD_GRD[4]).Checked)
            {
                txt_Scrap_code.Enabled = true;
            }
            else
            {
                txt_Scrap_code.Enabled = false;
            }

            sCheck = "";

        }

        private void Display_Data_Edit()
        {
            int iIndexChk;
            int iIndexStr;

            sCheck = "**";

            ArrayList CHK_UST_GRD = new ArrayList();
            CHK_UST_GRD.Add(CHK_UST_GRD0);
            CHK_UST_GRD.Add(CHK_UST_GRD1);

            ArrayList CHK_PRD_GRD = new ArrayList();
            CHK_PRD_GRD.Add(CHK_PRD_GRD0);
            CHK_PRD_GRD.Add(CHK_PRD_GRD1);
            CHK_PRD_GRD.Add(CHK_PRD_GRD2);
            CHK_PRD_GRD.Add(CHK_PRD_GRD3);
            CHK_PRD_GRD.Add(CHK_PRD_GRD4);
            CHK_PRD_GRD.Add(CHK_PRD_GRD5);

            for (iIndexChk = 0; iIndexChk <= 1; iIndexChk++)
            {
                if (TXT_UST_GRD.Text == ((CheckBox)CHK_UST_GRD[iIndexChk]).Tag.ToString())
                {
                    ((CheckBox)CHK_UST_GRD[iIndexChk]).ForeColor = Color.Red;
                    ((CheckBox)CHK_UST_GRD[iIndexChk]).Checked = true;
                }
                else
                {
                    ((CheckBox)CHK_UST_GRD[iIndexChk]).ForeColor = ColorTranslator.FromHtml("#808080");
                    ((CheckBox)CHK_UST_GRD[iIndexChk]).Checked = false;
                }
            }

            for (iIndexChk = 0; iIndexChk <= 5; iIndexChk++)
            {
                if (TXT_PRD_GRD.Text == ((CheckBox)CHK_PRD_GRD[iIndexChk]).Tag.ToString())
                {
                    ((CheckBox)CHK_PRD_GRD[iIndexChk]).ForeColor = Color.Red;
                    ((CheckBox)CHK_PRD_GRD[iIndexChk]).Checked = true;
                }
                else
                {
                    ((CheckBox)CHK_PRD_GRD[iIndexChk]).ForeColor = ColorTranslator.FromHtml("#808080");
                    ((CheckBox)CHK_PRD_GRD[iIndexChk]).Checked = false;
                }
            }

            sCheck = "";

            if (TXT_PROC_FLAG.Text.Substring(0,1) != "Q")
            {
                if (TXT_INSP_MAN.Text == "")
                    TXT_INSP_MAN.Text = GeneralCommon.sUserID;
                if (TXT_INSP_OCCR_TIME.Text == "")
                    TXT_INSP_OCCR_TIME.Text = Gf_DTSet("","");
            }

            Size_Grade_Edit();
        }

        private void Size_Grade_Edit()
        {
            string sGradeFlag;

            sGradeFlag = "";

            // THICK GRAND CHECK
            if (SDB_THK.NumValue >= SDB_ORD_THK.NumValue +convertX(SDB_INSP_THK_MN.Text) && SDB_THK.NumValue <= SDB_ORD_THK.NumValue + convertX(SDB_INSP_THK_MX.Text))
            {
                TXT_INSP_THK_GRD.Text = "Y";
                SDB_THK.ForeColor = Color.Black;
            }
            else
            {
                TXT_INSP_THK_GRD.Text = "N";
                SDB_THK.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // WIDTH GRAND CHECK
            if (SDB_WID.NumValue >= SDB_ORD_WID.NumValue + convertX(SDB_INSP_WID_MN.Text) && SDB_WID.NumValue <= SDB_ORD_WID.NumValue + convertX(SDB_INSP_WID_MX.Text))
            {
                TXT_INSP_WID_GRD.Text = "Y";
                SDB_WID.ForeColor = Color.Black;
            }
            else
            {
                TXT_INSP_WID_GRD.Text = "N";
                SDB_WID.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // LENGTH GRAND CHECK
            if (SDB_LEN.NumValue >= SDB_ORD_LEN.NumValue + convertX(SDB_INSP_LEN_MN.Text) && SDB_LEN.NumValue <= SDB_ORD_LEN.NumValue + convertX(SDB_INSP_LEN_MX.Text))
            {
                TXT_INSP_LEN_GRD.Text = "Y";
                SDB_LEN.ForeColor = Color.Black;
            }
            else
            {
                TXT_INSP_LEN_GRD.Text = "N";
                SDB_LEN.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            // WEIGHT GRAND CHECK
            if (SDB_WGT.NumValue >= SDB_WGT_ORD.NumValue + convertX(SDB_PWGT_MN.Text) && SDB_WGT.NumValue <= SDB_WGT_ORD.NumValue + convertX(SDB_PWGT_MX.Text))
            {
                TXT_INSP_WGT_GRD.Text = "Y";
                SDB_WGT.ForeColor = Color.Black;
            }
            else
            {
                TXT_INSP_WGT_GRD.Text = "N";
                SDB_WGT.ForeColor = Color.Red;
                sGradeFlag = "N";
            }

            if (TXT_UST_GRD.Text == "")
            {
                CHK_UST_GRD0.Checked = true;
                CHK_UST_GRD_Clk(0);
            }

            //    If TXT_PRD_GRD = "" Then
            //        If sGradeFlag = "N" Then
            //            CHK_PRD_GRD(1).Value = CHECKED
            //            Call CHK_PRD_GRD_Click(1)
            //    '        CHK_PRD_GRD(0).Enabled = False
            //        Else
            //            CHK_PRD_GRD(0).Value = CHECKED
            //            Call CHK_PRD_GRD_Click(0)
            //    '        CHK_PRD_GRD(0).Enabled = True
            //        End If
            //    End If

        }



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

        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        #endregion



        

    }
}
