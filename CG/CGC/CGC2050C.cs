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
//-- Sub_System Name   板坯库管理
//-- Program Name      火切实绩查询及修改界面
//-- Program ID        CGC2050C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.07.03
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.07.03       韩超        火切实绩查询及修改界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG {
    public partial class CGC2050C: CommonClass.FORMBASE {
        public CGC2050C() {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc2 = new Collection();

        const int SPD_PLATE_NO = 0;
        const int SPD_DS_CUT_END_DATE = 11;
        const int SPD_THK = 13;
        const int SPD_WID = 14;
        const int SPD_LEN = 15;
        const int SPD_WGT = 16;
        const int SPD_DS_LAST_YN = 17;
        const int SPD_SURF_GRD = 15;
        const int SPD_TRIM_FL = 16;
        const int SPD_DS_KNIFE_GAP = 17;
        const int SPD_EMP_CD = 20;


        const int SPD_PROC_CD = 22;
        const int SPD_END_USE = 23;
        const int SPD_STLGRD = 24;

        string sQuery;
        string sLoopFl;

        bool Screen_Fl;

        //const int SPD_PLAN_PROD_WGT = 33,



        protected override void p_SubFormInit() {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_WkPlt, "P", "", "", "", imcseq, "");
            p_SetMc(txt_PrcLine, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_INQNO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_MILL_LOT_NO, "P", "", "", "", imcseq, "");

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc(TXT_MPLATE_NO, "PNR", "", "", "", imcseq, "");
            p_SetMc(TXT_PRODCD, "PNR", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 25, false, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PNIL", "", "", "", iscseq, iheadrow, "M"); //0 
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("订/余", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("宽度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("长度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("UST", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("取样长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("作业时间", "DT", "", "NI", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("厚度", "N", "9,2", "NI", "", "", "", iscseq, iheadrow, "R"); //13
            p_SetSc("宽度", "N", "9", "NI", "", "", "", iscseq, iheadrow, "R"); //14
            p_SetSc("长度", "N", "9", "NI", "", "", "", iscseq, iheadrow, "R"); //15
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R"); //16
            p_SetSc("尾板", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("切边是否", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("切头是否", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("切尾是否", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("取样一", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("取样二", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("操作人", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("PLT", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("Prc_Line", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("垛位", "E", "60", "I", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L"); //29
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //30
            p_SetSc("订单序列号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //31

            iheadrow = 0;
            p_spanSpread("作业指示", 1, 11, iscseq, iheadrow, 1);
            p_spanSpread("作业实绩", 12, 27, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 25, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, true);

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("材料号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //2 
            p_SetSc("工厂代码", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //3 
            p_SetSc("产品代码", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //4 
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //5 
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //6 
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7 
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //8 
            p_SetSc("钢板数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //9 
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10 
            p_SetSc("热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("火切割", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("UST", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("切边代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("切边日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("货位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("订单序列号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //19
            p_SetSc("保性能", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //20
           

            //SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_OCCR_TIME, true);

        }

        public void Form_Load(object sender, System.EventArgs e) {
            base.sSvrPgmPkgName = "CGC2050NC";
            Form_Define();
            ss1.ActiveSheet.FrozenColumnCount = 1;

        }

        public override void Form_Ref() {

            p_Ref(1, 2, true, true);

            if (ss2.ActiveSheet.RowCount > 0)
            {
                ss2_DblClk(0, 0);
            }
        }

        public override void Form_Pro()
        {
            int iCount;
            int START_FOR =0;
            string sDateFrom;
            string sDateTo;
            string sPlateNo;

            int inum;
            int lRow;

            for (iCount = 0; iCount < ss1.ActiveSheet.RowCount; iCount++)
            {
                //        ss1.Col = 0
                //        ss1.Text = "Update"
                if (ss1.ActiveSheet.Cells[iCount,17].Text == "True")
                {
                    START_FOR = iCount;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            if (START_FOR < ss1.ActiveSheet.RowCount-1)
            {
                START_FOR = START_FOR + 1;
                for (iCount = START_FOR; iCount < ss1.ActiveSheet.RowCount; iCount++)
                {
                    ss1.ActiveSheet.RowHeader.Cells[iCount,0].Text = "";
                }
            }

            p_Pro(1, 1, true, true);

        }

        private void PlateWgtEdit()
        {
            double dThk;
            double dWid;
            double dLen;
            double dWgt;
            double sProcCode;
            string sEndUseCd = "";
            string sStlgrd = "";
            int iCount;

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {

                dThk = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_THK].Text);
                dWid = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_WID].Text);
                dLen = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_LEN].Text);
                dWgt = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_WGT].Text);
               
                //lbl_moplate_wgt.Caption = Val(lbl_moplate_wgt.Caption + "") + dWgt;
                //Val(.Text & "")
                if (dWgt == 0 & dThk > 0 & dWid > 0 & dLen > 0)
                {
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_WGT].Text = Cal_Plate_Wgt("WGT", sEndUseCd, sStlgrd, dThk, dWid, dLen).ToString();
                }
            }
        }



        private double Cal_Plate_Wgt(string sMode, string sEndUseCd, string sStlgrd, double dThk, double dWid, double dLen)
        {

            double Plate_Wgt = 0;

            sQuery = "SELECT  Gf_Cal_Plate_Wgt('" + sMode + "'";
            sQuery = sQuery + "             ,'" + sEndUseCd + "'";
            sQuery = sQuery + "             ,'" + sStlgrd + "'";
            sQuery = sQuery + "             ," + dThk;
            sQuery = sQuery + "             ," + dWid;
            sQuery = sQuery + "             ," + dLen;
            sQuery = sQuery + "             ,0 )";
            sQuery = sQuery + "       FROM  DUAL ";

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return Plate_Wgt;


            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        Plate_Wgt = Convert.ToDouble(AdoRs.Fields[0].Value);
                        AdoRs.MoveNext();
                    }
                }

                //判断是不是需要关闭连接对象，有时候该方法是在查询过程中调用，关闭对象会导致框架查询报错 韩超

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return Plate_Wgt;
            }
            catch (Exception ex)
            {
                // if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return 0;
            }

        }

        private void ss1_DblClk(int Col, int ROW)
        {
            string sDate;
            string sDateTo;
            int FOR_CNT;
            string tmpYYMMDD;

            if (ss1.ActiveSheet.RowCount <= 0) return;
            if (Col < 10) return;

            tmpYYMMDD = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYY-MM-DD HH24:MI:SS') FROM DUAL");


            //For FOR_CNT = 1 To ss1.MaxRows


            if (Col == 13)
            {
                ss1.ActiveSheet.Cells[ROW, 12].Text = tmpYYMMDD;
            }
            ss1.ActiveSheet.Cells[ROW, 28].Text = txt_Loc.Text;
            ss1.ActiveSheet.Cells[ROW, 27].Text = txt_PrcLine.Text;
            ss1.ActiveSheet.Cells[ROW, 26].Text = txt_WkPlt.Text;
            ss1.ActiveSheet.Cells[ROW, 25].Text = GeneralCommon.sUserID;
            ss1_Row_Edit(ROW);
            //Next
        }

        private void ss1_EditChange(int Col, int ROW)
        {

            double dThk;
            double dWid;
            double dLen;
            string sEndUseCd;
            string sStlgrd;

            if (ss1.ActiveSheet.RowCount <= 0) return;


            if (Col == SPD_THK | Col == SPD_WID | Col == SPD_LEN)
            {
                dThk = convertX(ss1.ActiveSheet.Cells[ROW, SPD_THK].Text);
                dWid = convertX(ss1.ActiveSheet.Cells[ROW, SPD_WID].Text);
                dLen = convertX(ss1.ActiveSheet.Cells[ROW, SPD_LEN].Text);
                sEndUseCd = ss1.ActiveSheet.Cells[ROW, SPD_END_USE].Text;
                sStlgrd = ss1.ActiveSheet.Cells[ROW, SPD_STLGRD].Text;
                if (dThk > 0 & dWid > 0 & dLen > 0)
                {
                    ss1.ActiveSheet.Cells[ROW, SPD_WGT].Text = Cal_Plate_Wgt("WGT", sEndUseCd, sStlgrd, dThk, dWid, dLen).ToString();
                }
            }

            ss1_Row_Edit(ROW);
        }

        private void ss1_Change(int Col, int ROW)
        {
            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            ss1_Row_Edit(ROW);

        }

        private void ss1_Data_Edit()
        {
            int iIdr;
            double iThk;
            double iWid;
            double iLen;
            double iWGT;
            int ROW;
            string sDate;
            string sDateTo;

            for (iIdr = 1; iIdr <= ss1.ActiveSheet.RowCount; iIdr++)
            {
                if (ss1.ActiveSheet.Cells[iIdr - 1, 1].Text == "")
                {
                    iThk = 0;
                }
                else
                {
                    iThk = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 1].Text);
                }
                if (ss1.ActiveSheet.Cells[iIdr - 1, 2].Text == "")
                {
                    iWid = 0;
                }
                else
                {
                    iWid = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 2].Text);
                }
                if (ss1.ActiveSheet.Cells[iIdr - 1, 3].Text == "")
                {
                    iLen = 0;
                }
                else
                {
                    iLen = convertX(ss1.ActiveSheet.Cells[iIdr - 1, 3].Text);
                }

                ss1.ActiveSheet.Cells[iIdr - 1, 23].Text = Gf_ShiftSet3("");
                ss1.ActiveSheet.Cells[iIdr - 1, 24].Text = Gf_GroupSet(Gf_ShiftSet3(""), Gf_DTSet("", "X"));
                ss1.ActiveSheet.Cells[iIdr - 1, 25].Text = GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[iIdr - 1, 26].Text = txt_WkPlt.Text;
                ss1.ActiveSheet.Cells[iIdr - 1, 27].Text = txt_PrcLine.Text;

            }


        }

        private void ss1_Row_Edit(int ROW)
        {
            int iIdr;
            string sLastFlag;


            switch (ss1.ActiveSheet.RowHeader.Cells[ROW,0].Text)
            {
                case "增加":
                case "修改":
                case "删除":
                    break;
                default:
                    ss1.ActiveSheet.RowHeader.Cells[ROW, 0].Text = "修改";
                    break;
            }

            sLastFlag = "";
            //lbl_moplate_wgt.Caption = "";
            //for (iIdr = 1; iIdr <= ss1.MaxRows; iIdr++)
            //{
               // ss1.Col = 17;
              //  lbl_moplate_wgt.Caption = Val(lbl_moplate_wgt.Caption + "") + Val(ss1.Text + "");
            //}

        }

        private void ss2_DblClk(int Col, int ROW)
        {

            int iCount;

            if (ss2.ActiveSheet.RowCount <= 0) return;

            if (ss2.ActiveSheet.Cells[ROW, 0].Text != "")
            {
                TXT_MPLATE_NO.Text = ss2.Text;
            }
            TXT_PRODCD.Text = ss2.ActiveSheet.Cells[ROW, 4].Text;

            if (TXT_MPLATE_NO.Text != "")
            {
                p_Ref(2, 1, true, true);

                ss1_Data_Edit();
                PlateWgtEdit();

                ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 19].Text = "True";
                if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 12].Text == "")
                {
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 17].Text = "True";
                }

            }

            //ss2.ROW = ROW;
            //ss2.Col = 5;
            //if (ss2.Text == "MP")
            //{
            //    MDIMain.MenuTool.Buttons(7).Enabled = true;
            //    MDIMain.MenuTool.Buttons(8).Enabled = true;
            //    MDIMain.MenuTool.Buttons(9).Enabled = true;
            //    MDIMain.MenuTool.Buttons(11).Enabled = true;
            //    MDIMain.MenuTool.Buttons(12).Enabled = true;
            //}
            //else if (ss2.Text == "PP")
            //{
            //    MDIMain.MenuTool.Buttons(7).Enabled = false;
            //    MDIMain.MenuTool.Buttons(8).Enabled = false;
            //    MDIMain.MenuTool.Buttons(9).Enabled = false;
            //    MDIMain.MenuTool.Buttons(11).Enabled = false;
            //    MDIMain.MenuTool.Buttons(12).Enabled = false;
            //}

        }



        

        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_PrcLine.Text = "3";
            txt_WkPlt.Text = "C3";
          
            return true;

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

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss1_EditChange(object sender, EditorNotifyEventArgs e)
        {
            ss1_EditChange(e.Column, e.Row);
        }

        private void ss1_Change(object sender, ChangeEventArgs e)
        {
            ss1_Change(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

    }
}
