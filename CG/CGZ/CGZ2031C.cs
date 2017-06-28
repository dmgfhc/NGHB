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
//-- Sub_System Name   板坯库管理
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGZ2031C : CommonClass.FORMBASE
    {
        public CGZ2031C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        const int SPD_PLATE_NO = 0;
        const int SPD_DS_CUT_STA_DATE = 8;
        const int SPD_DS_CUT_END_DATE = 9;
        const int SPD_THK = 10;
        const int SPD_WID = 11;
        const int SPD_LEN = 12;
        const int SPD_WGT = 13;
        const int SPD_DS_LAST_YN = 14;
        const int SPD_SURF_GRD = 15;
        const int SPD_TRIM_FL = 16;
        const int SPD_SMP_LEN = 17;
        const int SPD_DS_KNIFE_GAP = 18;
        const int SPD_DS_H_CROP_YN = 19;
        const int SPD_DS_T_CROP_YN = 20;
        const int SPD_MARK_YN = 21;
        const int SPD_STAMP_YN = 22;
        const int SPD_BAR_YN = 23;
        const int SPD_LEN_FLAG = 24;
        const int SPD_SF_ORNOT = 25;
        const int SPD_PLT = 26;
        const int SPD_PRC_LINE = 27;
        const int SPD_EMP_CD = 28;
        const int SPD_PROC_CD = 29;
        const int SPD_END_USE = 30;
        const int SPD_STLGRD = 31;

        string sQuery;
        string sLoopFl;
        double Mplate_thk;

        //const int SPD_PLAN_PROD_WGT = 33,


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("查询号", TXT_MPLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("", TXT_SEQ, "P", "", "", "", "", imcseq);
            p_SetMc("", CBO_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("", CBO_LINE, "P", "", "", "", "", imcseq);
            p_SetMc("", TXT_SEARCH_FL, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("查询号", TXT_MPLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("", TXT_ORD_NO, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_SIZE, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_WGT, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_DEL_FROM, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_DEL_TO, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_CUST, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_SPEC, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_UST, "R", "", "", "", "", imcseq);
            p_SetMc("", TXT_MARKING, "R", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 28, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PNIL", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("UST", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("开始时间", "DT", "", "NI", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("结束时间", "DT", "", "NI", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("厚度", "N", "8,2", "NI", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("宽度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("长度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("重量", "N", "15,3", "NIL", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("尾板", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("合格", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("切边", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("取样长度", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("刀缝", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("切头", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("切尾", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("喷印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("冲印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("侧喷", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("定尺", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("修磨", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("工厂代码", "E", "60", "NI", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("机号", "E", "60", "NI", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("作业人员", "E", "60", "NI", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("进程代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("订单用途", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//31
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("订单序列号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//33

            iheadrow = 0;
            p_spanSpread("作业指示", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("作业实绩", 9, 16, iscseq, iheadrow, 1);


            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 8, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 31, true);

            SpreadCommon.Gp_Sp_ColHidden(ss2, 9, true);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);


            p_ScIni(ss2, Sc2, 0, true, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("计划/实绩", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("切边代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("切边开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("母板分段时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("上冷床时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("下冷床时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("冷床代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGZ2031NC";
            Form_Define();

            CBO_PLT.SelectedItem = "C3";
            CBO_LINE.SelectedItem = "1";

            TXT_CUT_TIME_DblClk();
            TXT_MPLATE_NO.Focus();

        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            int iCount;

            if (TXT_SEARCH_FL.Text == "")
                TXT_SEARCH_FL.Text = "1";

            if (TXT_MPLATE_NO.Text.Length > 9)
            {

                //        If TXT_SEQ <> "" Then
                //           TXT_MPLATE_NO.Text = Mid(TXT_MPLATE_NO.Text, 1, 10)
                //        End If

                if (p_Ref(1, 1, true, true))
                {
                    PlateWgtEdit();
                    p_Ref(2, 0, true, true);
                    ///'''ADDED BY GUOLI AT 20080718200300'''''''''
                    if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 9].Text == "")
                    {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 14].Text = "True";
                    }
                    ///'''''''''''''''''''''''''''''''''''''''''''
                }

            }
            else
            {
                if (p_Ref(1, 2, true, true))
                {
                    ss2_DblClk(0, 0);
                }
            }

            if (ss1.ActiveSheet.RowCount < 1) return;

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_PROC_CD].Text == "CGB")
                {
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_MARK_YN].Text = "True";
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_STAMP_YN].Text = "True";
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_BAR_YN].Text = "True";
                }
            }

            //    For iCount = 1 To ss1.MaxRows
            //        ss1.ROW = iCount
            //        ss1.Col = 0
            //        ss1.Text = "Update"
            //        ss1.Col = SPD_DS_CUT_STA_DATE
            //        ss1.Text = TXT_CUT_TIME
            //        ss1.Col = SPD_DS_CUT_END_DATE
            //        ss1.Text = TXT_CUT_TIME
            //        ss1.Col = SPD_PLT
            //        ss1.Text = Trim(CBO_PLT.Text)
            //        ss1.Col = SPD_PRC_LINE
            //        ss1.Text = Trim(CBO_LINE.Text)
            //        ss1.Col = SPD_EMP_CD
            //        ss1.Text = sUserID
            //    Next
            TXT_MPLATE_NO.Enabled = true;
        }

        public override void Form_Pro()
        {
            int iCount;
            string sDateFrom;
            string sDateTo;
            string sPlateNo = "";

            int inum = 0;
            int lRow = 0;
            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "修改")
                {
                    if (!Gp_DateCheck(ss1.ActiveSheet.Cells[iCount - 1, 9].Text, "X"))
                    {

                        GeneralCommon.Gp_MsgBoxDisplay(" 请正确输入结束时间 ！", "I", "");
                        return;
                    }
                }
            }

            if (TXT_SEARCH_FL.Text == "")
                TXT_SEARCH_FL.Text = "1";

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "修改" | ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "新增" | ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "删除")
                {
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_PLT].Text = CBO_PLT.Text.Trim();
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_PRC_LINE].Text = CBO_LINE.Text.Trim();
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_EMP_CD].Text = GeneralCommon.sUserID;
                }
            }


            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text.Substring(0, 12) == sPlateNo.Substring(0, 12) || sPlateNo == "")
                {
                    sPlateNo = ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text;
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_LAST_YN].Text == "True")
                    {
                        lRow = iCount;
                        inum = inum + 1;
                        if (inum > 1)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("一块母板只能有一块尾板.." + sPlateNo.Substring(0, 12), "I", "");
                            return;
                        }
                    }
                    if (inum == 1)
                    {
                        if (iCount > lRow)
                        {
                            if (ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text != "删除")
                            {
                                ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text = "";
                            }
                        }
                    }
                }
                else
                {
                    inum = 0;
                    sPlateNo = ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text;
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_LAST_YN].Text == "True")
                    {
                        lRow = iCount;
                        inum = inum + 1;
                        if (inum > 1)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("一块母板只能有一块尾板.." + sPlateNo.Substring(0, 12), "I", "");
                            return;
                        }
                    }
                    if (inum == 1)
                    {
                        if (iCount > lRow)
                        {
                            ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text = "";
                        }
                    }
                }
            }


            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                {
                    switch (ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text)
                    {

                        case "增加":
                        case "修改":
                            sPlateNo = ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text;
                            sDateFrom = ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_STA_DATE].Text;
                            if (!Gp_DateCheck(ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_STA_DATE].Text, "S"))
                            {
                                GeneralCommon.Gp_MsgBoxDisplay("请正确输入开始时间.." + sPlateNo, "I", "");
                                return;
                            }

                            sDateTo = ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_END_DATE].Text;
                            if (!Gp_DateCheck(ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_END_DATE].Text, "S"))
                            {
                                GeneralCommon.Gp_MsgBoxDisplay("请正确输入结束时间.." + sPlateNo, "I", "");
                                return;
                            }

                            if (convertX(sDateFrom) > convertX(sDateTo))
                            {
                                GeneralCommon.Gp_MsgBoxDisplay("请正确输入开始时间还是结束时间.." + sPlateNo, "I", "");
                                return;
                            }
                            break;

                    }
                }
            }
            p_pro(1, 1, true, true);
        }

        public override void Spread_Ins()
        {
            double dThk = 0;
            double dWid = 0;
            double dLen = 0;
            double dWgt = 0;
            int lRow = 0;
            string sPlateNo = "";
            string sClipText = "";

            string sPlt = "";
            string sPRC_LINE = "";
            string sEmp_cd = "";

            int iCount;

            sPlateNo = "";

            {
                if (ss1.ActiveSheet.RowCount == 0)
                {
                    if (TXT_MPLATE_NO.Text.Length == 12)
                    {
                        base.Spread_Ins();
                        ss1.ActiveSheet.Cells[0, 0].Text = TXT_MPLATE_NO.Text + "01";
                    }
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("请正确输入母板号 ！", "I", "");
                    }
                    return;
                }
                for (iCount = ss1.ActiveSheet.ActiveRowIndex; iCount < ss1.ActiveSheet.RowCount; iCount++)
                {
                    if (sPlateNo == "" || ss1.ActiveSheet.Cells[iCount, 0].Text.Substring(0, 12) == sPlateNo.Substring(0, 12))
                    {
                        sPlateNo = ss1.ActiveSheet.Cells[iCount, 0].Text;
                        lRow = iCount;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            sPlateNo = "";

            //ss1.SetActiveCell(1, lRow);
            ss1.ActiveSheet.SetActiveCell(lRow, 0);
            
            //Gp_Sp_Ins(Proc_Sc("Sc"));
            base.Spread_Ins();

            if (lRow >= 0)
            {
                sPlateNo = ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text;
                dThk = convertX(ss1.ActiveSheet.Cells[lRow, SPD_THK].Text);
                dWid = convertX(ss1.ActiveSheet.Cells[lRow, SPD_WID].Text);
                dLen = convertX(ss1.ActiveSheet.Cells[lRow, SPD_LEN].Text);
                dWgt = convertX(ss1.ActiveSheet.Cells[lRow, SPD_WGT].Text);
                sPlt = ss1.ActiveSheet.Cells[lRow, SPD_PLT].Text;
                sPRC_LINE = ss1.ActiveSheet.Cells[lRow, SPD_PRC_LINE].Text;
                sEmp_cd = ss1.ActiveSheet.Cells[lRow, SPD_EMP_CD].Text;
            }
            else
            {
                sPlateNo = TXT_MPLATE_NO.Text + "00";
            }

            lRow = lRow + 1;
            ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text = sPlateNo;
            ss1.ActiveSheet.Cells[lRow, SPD_THK].Text = dThk.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_WID].Text = dWid.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_LEN].Text = dLen.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_WGT].Text = dWgt.ToString();
            ss1.ActiveSheet.Cells[lRow, SPD_PLT].Text = sPlt;
            ss1.ActiveSheet.Cells[lRow, SPD_PRC_LINE].Text = sPRC_LINE;
            ss1.ActiveSheet.Cells[lRow, SPD_EMP_CD].Text = sEmp_cd;
            ss1.ActiveSheet.RowHeader.Cells[lRow, 0].Text = "增加";
            ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text = ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text.Substring(0, 12) + string.Format("{0:D2}", Convert.ToInt32(ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text.Substring(12, 2)) + 1);
            ss1.ActiveSheet.Cells[lRow, SPD_SURF_GRD].Text = "True";
            ss1.ActiveSheet.Cells[lRow, SPD_MARK_YN].Text = "True";
            ss1.ActiveSheet.Cells[lRow, SPD_STAMP_YN].Text = "True";
            ss1.ActiveSheet.Cells[lRow, SPD_BAR_YN].Text = "True";

            //ss1.SetActiveCell(1, ss1.ROW);
            //ss1.ReDraw = true;


            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 14].Text = "True";

        }

        private void PlateWgtEdit()
        {
            double dThk;
            double dWid;
            double dLen;
            double dWgt;
            double sProcCode;
            string sEndUseCd;
            string sStlgrd;
            int iCount;

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {

                dThk = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_THK].Text);
                dWid = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_WID].Text);
                dLen = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_LEN].Text);
                dWgt = convertX(ss1.ActiveSheet.Cells[iCount - 1, SPD_WGT].Text);
                sEndUseCd = ss1.ActiveSheet.Cells[iCount - 1, SPD_END_USE].Text;
                sStlgrd = ss1.ActiveSheet.Cells[iCount - 1, SPD_STLGRD].Text;
                ss1.ActiveSheet.Cells[iCount - 1, 27].Text = CBO_LINE.Text;
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

        //该方法在VB中发现已不使用
        //private void opt_wait_product_Click()
        //{
        //    opt_wait_product.ForeColor = 0xffL;
        //    opt_wait_inspect.ForeColor = 0x808080;
        //    opt_all.ForeColor = 0x808080;
        //    TXT_SEARCH_FL.Text = "1";
        //    TXT_MPLATE_NO.Text = "";
        //}

        //该方法在VB中发现已不使用
        //private void opt_wait_inspect_Click()
        //{
        //    opt_wait_inspect.ForeColor = 0xffL;
        //    opt_wait_product.ForeColor = 0x808080;
        //    opt_all.ForeColor = 0x808080;
        //    TXT_SEARCH_FL.Text = "2";
        //    TXT_MPLATE_NO.Text = "";
        //}


        private void ss1_DblClk(int Col, int ROW)
        {
            string sDate;
            string sDateTo;

            if (ss1.ActiveSheet.RowCount <= 0) return;

            ss1.ActiveSheet.Cells[ROW, SPD_PLT].Text = CBO_PLT.Text.Trim();
            ss1.ActiveSheet.Cells[ROW, SPD_PRC_LINE].Text = CBO_LINE.Text.Trim();
            ss1.ActiveSheet.Cells[ROW, SPD_EMP_CD].Text = GeneralCommon.sUserID;

            ss1.ActiveSheet.Cells[ROW, SPD_DS_CUT_STA_DATE].Text = TXT_CUT_TIME.Text;
            ss1.ActiveSheet.Cells[ROW, SPD_DS_CUT_END_DATE].Text = TXT_CUT_TIME.Text;

            //ss1_Row_Edit(ROW);
        }

        private void opt_all_Clk()
        {
            opt_all.ForeColor = Color.Red;
            //opt_wait_inspect.ForeColor = 0x808080;//该控件在VB中已不使用
            //opt_wait_product.ForeColor = 0x808080;//该控件在VB中已不使用
            TXT_SEARCH_FL.Text = "3";
            TXT_MPLATE_NO.Text = "";
        }

        private void ss1_EditChange(int Col, int ROW)
        {

            double dThk;
            double dWid;
            double dLen;
            string sEndUseCd;
            string sStlgrd;

            if (ss1.ActiveSheet.RowCount <= 0) return;


            if (Col == SPD_THK || Col == SPD_WID || Col == SPD_LEN)
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

            //ss1_Row_Edit(ROW);

        }

        private void ss2_DblClk(int Col, int ROW)
        {

            int iCount;

            if (ss2.ActiveSheet.RowCount <= 0) return;

            TXT_MPLATE_NO.Text = ss2.ActiveSheet.Cells[ROW, 0].Text;
            if (ss2.ActiveSheet.Cells[ROW, 1].Text == "")
                ss2.ActiveSheet.Cells[ROW, 1].Text = "0";
            Mplate_thk = convertX(ss2.ActiveSheet.Cells[ROW, 1].Text);
            if (TXT_MPLATE_NO.Text.Length == 12)
            {

                if (TXT_SEQ.Text != "")
                {
                    //           TXT_MPLATE_NO.Text = Mid(TXT_MPLATE_NO.Text, 1, 10)
                    if (ss2.ActiveSheet.Cells[ROW, 1].Text != "")
                        TXT_SEQ.Text = ss2.ActiveSheet.Cells[ROW, 1].Text;
                }
                if (p_Ref(1, 1, true, false))
                {

                    PlateWgtEdit();
                    p_Ref(2, 0, true, false);
                    if (ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 9].Text == "")
                    {
                        ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 14].Text = "True";
                    }
                }

            }

            if (ss1.ActiveSheet.RowCount <= 0) return;


            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.Cells[iCount - 1, 1].Text == "")
                {
                    ss1.ActiveSheet.Cells[iCount - 1, 1].Text = Mplate_thk.ToString();
                    ss1.ActiveSheet.Cells[iCount - 1, 10].Text = Mplate_thk.ToString();
                }
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_PROC_CD].Text == "CGB")
                {
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_MARK_YN].Text = "True";
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_STAMP_YN].Text = "True";
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_BAR_YN].Text = "True";
                }
                //         Call .SetActiveCell(1, .ROW)
            }


            //    For iCount = 1 To ss1.MaxRows
            //        ss1.ROW = iCount
            //        ss1.Col = 0
            //        ss1.Text = "Update"
            //        ss1.Col = SPD_DS_CUT_STA_DATE
            //        ss1.Text = TXT_CUT_TIME
            //        ss1.Col = SPD_DS_CUT_END_DATE
            //        ss1.Text = TXT_CUT_TIME
            //        ss1.Col = SPD_PLT
            //        ss1.Text = Trim(CBO_PLT.Text)
            //        ss1.Col = SPD_PRC_LINE
            //        ss1.Text = Trim(CBO_LINE.Text)
            //        ss1.Col = SPD_EMP_CD
            //        ss1.Text = sUserID
            //    Next

        }

        private void TXT_CUT_TIME_Chg()
        {
            if (ss1.ActiveSheet.RowCount <= 0) return;
            int iCount;
            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "修改" | ss1.Text == "增加" | ss1.Text == "删除")
                {
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_STA_DATE].Text = TXT_CUT_TIME.Text;
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_DS_CUT_END_DATE].Text = TXT_CUT_TIME.Text;
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_PLT].Text = CBO_PLT.Text.Trim();
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_PRC_LINE].Text = CBO_LINE.Text.Trim();
                    ss1.ActiveSheet.Cells[iCount - 1, SPD_EMP_CD].Text = GeneralCommon.sUserID;
                }
            }
        }

        private void TXT_CUT_TIME_DblClk()
        {
            TXT_CUT_TIME.Text = Gf_DTSet("", "X");
        }

        public override bool Form_Cls()
        {
            CBO_PLT.SelectedItem = "C3";
            CBO_LINE.SelectedItem = "1";
            base.Form_Cls();
            return true;

        }
        #endregion


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

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

        private void TXT_CUT_TIME_TextChanged(object sender, EventArgs e)
        {
            
            TXT_CUT_TIME_Chg();
        }

        private void TXT_CUT_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_CUT_TIME_DblClk();
        }

    }
}