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
//-- Sub_System Name   统计分析管理
//-- Program Name      热喷信息发送界面_CGC2021C
//-- Program ID        CGC2021C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.10   
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.10       韩超        热喷信息发送界面_CGC2021C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGC2021C : CommonClass.FORMBASE
    {
        public CGC2021C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        MSWinsockLib.WinsockClass Winsock1 = new MSWinsockLib.WinsockClass();
        MSWinsockLib.WinsockClass Winsock2 = new MSWinsockLib.WinsockClass();

        const int SS1_LINE1 = 0;
        const int SS1_SLAB_NO = 1;
        const int SS1_LOT_NO = 2;
        const int SS1_ROLL_THK = 3;
        const int SS1_ROLL_WID = 4;
        const int SS1_ROLL_LEN = 5;
        const int SS1_SIZE_KND = 6;
        const int SS1_CUT_NO = 8;
        const int SS1_DATE = 9;
        const int SS1_SHIFT = 10;
        const int SS1_ROLL_WGT = 11;
        const int SS1_STLGRD = 12;

        const int SS2_BLOCK_SEQ = 1;
        const int SS2_SEQ = 2;
        const int SS2_PROD_CD = 3;
        const int SS2_THK = 4;
        const int SS2_WID = 5;
        const int SS2_LEN = 6;
        const int SS2_ORD_NO = 8;
        const int SS2_UST_FL = 12;
        const int SS2_HTM = 13;
        const int SS2_POS = 14;
        const int SS2_PAINT_NO = 15;
        const int SS2_PAINT_ADD = 16;
        const int SS2_DEL_TO_DATE = 18;
        const int SS2_URGNT_FL = 19;
        const int SS2_IMP_CONT = 20;
        const int SS2_JIT_FLAG = 21;
        const int SS2_ERPORT = 22;
        const int SS2_ORD_CNT = 23;
        //一批多订单
        const int SS2_OVER_FL = 24;
        //异常坯
        const int SS2_TRIM_FL = 25;
        //是否切边
        const int SS2_FLAB_NO = 0;
        const int SS2_SURFACE_REQUESTS = 29;
        const int SS2_CLASS_CD = 30;
        const int SS2_CLASS_LVL = 31;
        const int SS2_MILL_EXCEPTION = 32;
        const int SS2_MILL_EXCEPTION_FH = 33;

        public byte LoByte(short Word)
        {
            return (byte)(Word & 0xff);
        }

        public byte HiByte(short Word)
        {
            return (byte)(Word >> 8);
        }


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "PL", "", "", "", imcseq, "");//1
            p_SetMc(TXT_CUT_NO, "PL", "", "", "", imcseq, "");//3
          

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("#1", "C", "", "", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("板坯号", "E", "10", "", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("轧批号", "E", "20", "", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("厚度", "N", "9", "", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("宽度", "N", "9", "", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("长度", "N", "9", "", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("定尺", "C", "", "", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("标准号", "E", "30", "", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("分段号", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("日期", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("班次", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("重量", "N", "9,3", "", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("钢种", "E", "30", "", "", "", "", iscseq, iheadrow, "L");//12
            

            

            //iheadrow = 0;
            //p_spanSpread("板坯规格", 10, 12, iscseq, iheadrow, 1);
            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("板坯号", "E", "14", "", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("母板顺序", "E", "2", "", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "N", "9,2", "", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("宽度", "N", "9", "", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("长度", "N", "9", "", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("重量", "N", "9,3", "", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("订单号", "E", "20", "", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("标准号", "E", "40", "", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("定尺", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("切边", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("探伤", "E", "40", "", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("热处理", "E", "20", "", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("喷印开始位置", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("喷印号", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("加喷信息", "E", "30", "", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("客户代码", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("用户交货期", "D", "", "", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("是否紧急订单", "E", "1", "", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("重点订单", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("是否定制配送", "E", "20", "", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("是否出口订单", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("订单数量", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("异常坯", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("M(不是切边)", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("试样备注", "E", "200", "", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("尺寸备注", "E", "200", "", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("打包备注", "E", "200", "", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("表面客户要求", "E", "200", "", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("是否机械用钢", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("机械等级", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("工艺异常", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("返红工艺异常", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//33
            

        }

        private void chk_Cond_Clk(int Index)
        {
            string strState;
            string strState2;

            if (Index == 0)
            {
                if (chk_Cond[Index].Checked)
                {
                    Winsock1.Connect();
                }
                else
                {
                    Winsock1.Close();
                    strState = "连接断线";
                    tcpStatus.BackColor = Color.Red;
                    chk_Cond[0].ForeColor = Color.Red;
                    tcpMsg.Text = "标印机状态 : " + strState;
                }
            }

            if (Index == 8)
            {
                if (chk_Cond[Index].Checked)
                {
                    Winsock2.Connect();
                }
                else
                {
                    Winsock2.Close();
                    strState2 = "连接断线";
                    tcpStatus2.BackColor = Color.Red;
                    chk_Cond[Index].ForeColor = Color.Red;
                    tcpMsg2.Text = "侧喷机状态 : " + strState2;
                }
            }

        }

        private void CGD2082C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2082NC";
            Form_Define();

            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LAST_YN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_TRIM_FL, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_PAINT, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LABEL, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LOTCD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CE, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);
            txt_plt.Text = "C3";

            txt_line.Text = "1";
            txt_rec_sts.Text = "2";

            opt_line1.Checked = true;
            opt_line4.Checked = true;

            TXT_ORD_REMARK.Width = 598;
            TXT_ORD_REMARK.Height = 48;

            chk_Cond.Add(chk_Cond0);
            chk_Cond.Add(chk_Cond1);
            chk_Cond.Add(chk_Cond2);
            chk_Cond.Add(chk_Cond3);
            chk_Cond.Add(chk_Cond4);

            udt_date_fr.RawDate = DateTime.Now.ToString("yyyyMMdd");
            udt_date_to.RawDate = DateTime.Now.ToString("yyyyMMdd");

            Winsock1.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "01", 1);
            Winsock1.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "01", 2));
            Winsock2.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "01", 1);
            Winsock2.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "01", 2));
        }

        public override void Form_Pro()
        {
            int iRow;

            string sMark_no;
            string sPlate_no;
            string sThk;
            string sWid;
            string sLen;
            string sWgt;
            string sSpec;
            string sStdspec_YY;

            int iCount;

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "修改" || ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "增加" || ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "删除")
                {
                    sPlate_no = ss1.ActiveSheet.Cells[iRow - 1, SPD_PLATE_NO].Text;
                    if (opt_line5.Checked)
                    {
                        sMark_no = ss1.ActiveSheet.Cells[iRow - 1, SPD_PLATE_NO].Text;
                    }
                    else
                    {
                        sMark_no = ss1.ActiveSheet.Cells[iRow - 1, SPD_LOT_NO].Text;
                    }
                    sThk = ss1.ActiveSheet.Cells[iRow - 1, SPD_THK].Text.Trim().Replace(",", "");
                    sThk = substr(sThk, 0, sThk.IndexOf("."));
                    sWid = ss1.ActiveSheet.Cells[iRow - 1, SPD_WID].Text.Trim().Replace(",", "");
                    sLen = ss1.ActiveSheet.Cells[iRow - 1, SPD_LEN].Text.Trim().Replace(",", "");
                    sWgt = ss1.ActiveSheet.Cells[iRow - 1, SPD_WGT].Text.Trim().Replace(",", "");
                    if (substr(sWgt, 0, 1) == ".")
                    {
                        sWgt = "0" + sWgt;
                    }
                    sStdspec_YY = ss1.ActiveSheet.Cells[iRow - 1, SPD_STDSPEC_YY].Text;
                    sSpec = ss1.ActiveSheet.Cells[iRow - 1, SPD_STLGRD].Text;
                    //if ((chk_Cond0.Checked || chk_Cond8.Checked) & ss1.ActiveSheet.RowHeader.Cells[iRow-1,0].Text!= "删除")
                    //{
                    Cmd_SEND(iRow - 1, sMark_no, sThk, sWid, sLen, sWgt, sSpec, sStdspec_YY, sPlate_no);
                    //}
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            //p_Pro(1, 1, true, false);

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_MARK_YN].Text == "True")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Black, SSCmd_cnn.BackColor);
                }
            }

            iRow = iRow + 10;
            if (iRow > ss1.ActiveSheet.RowCount)
            {
                iRow = ss1.ActiveSheet.RowCount;
            }
            ss1.ActiveSheet.SetActiveCell(iRow - 1, SPD_LEN);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_plt.Text = "C3";

            txt_line.Text = "1";
            txt_rec_sts.Text = "2";

            opt_line1.Checked = true;
            opt_line4.Checked = true;

            return true;

        }

        public override void Form_Ref()
        {
            int iCount;
            string sPlateNo;
            Color sCnt_color;
            string sUrgnt_Fl;

            int inum;
            int lRow;

            //    If Gf_Sp_ProceExist(sc1.Item("Spread")) Then Exit Sub

            p_Ref(1, 1, true, true);

            for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
            {
                // 一坯多订单,字体显示红色  2011-08-23  by  LiQian
                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_CNT].Text != "")
                {
                    if (ss1.ActiveSheet.Cells[iCount - 1, SPD_ORD_CNT].Text == "2")
                    {
                        sCnt_color = Color.Red;
                    }
                    else
                    {
                        sCnt_color = Color.Black;
                    }
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, sCnt_color, Color.White);
                }

                if (ss1.ActiveSheet.Cells[iCount - 1, SPD_MARK_YN].Text == "True")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount-1, iCount-1, iCount-1, Color.Black, SSCmd_cnn.BackColor);
                }

                //紧急订单绿色显示 add by liqian 2012-08-16
                sUrgnt_Fl = ss1.ActiveSheet.Cells[iCount - 1, SPD_URGNT_FL].Text;
                if (sUrgnt_Fl == "Y")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iCount - 1, iCount - 1, Color.Green, Color.White);
                }
            }
        }

        public override void Spread_Ins()
        {
            double dThk =0;
            double dWid = 0;
            double dLen = 0;
            double dWgt = 0;
            int lRow = -1;
            string sPlateNo = "";
            string sLotNo = "";
            string sCutNo = "";
            string sClipText = "";

            string sSize_knd = "";
            string sTrim_fl = "";
            string sAply_stdspec = "";
            string sEmp_cd = "";
            string sStdspec_YY = "";
            string sStdspec = "";
            int iCount =0;

            sPlateNo = "";

                if (ss1.ActiveSheet.RowCount <= 0)
                {
                    if (txt_plate_no.Text.Length == 12)
                    {
                        base.Spread_Ins();
                        ss1.ActiveSheet.Cells[0, SPD_PLATE_NO].Text = txt_plate_no.Text + "01";
                        ss1.ActiveSheet.Cells[0, SPD_THK].Text = "0";
                        ss1.ActiveSheet.Cells[0, SPD_WID].Text = "0";
                        ss1.ActiveSheet.Cells[0, SPD_LEN].Text = "0";
                        ss1.ActiveSheet.Cells[0, SPD_APLY_STDSPEC].Text = "GB-XXX";
                    }
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("请正确输入母板号 ！", "I", "提示");
                    }
                    return;
                }
                for (iCount = ss1.ActiveSheet.ActiveRowIndex ; iCount < ss1.ActiveSheet.RowCount; iCount++)
                {
                    if (substr(ss1.ActiveSheet.Cells[iCount, SPD_PLATE_NO].Text, 0,12) == substr(sPlateNo,0,12) || sPlateNo == "")
                    {
                        sPlateNo = ss1.ActiveSheet.Cells[iCount, SPD_PLATE_NO].Text;
                        lRow = iCount;
                    }
                    else
                    {
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }

            sPlateNo = "";

            if (lRow >= 0)
            {
                ss1.ActiveSheet.SetActiveCell(lRow, 0);
            }

            base.Spread_Ins();

                if (lRow >= 0)
                {
                    sPlateNo = ss1.ActiveSheet.Cells[lRow, SPD_PLATE_NO].Text;
                    sLotNo = ss1.ActiveSheet.Cells[lRow, SPD_LOT_NO].Text;
                    sCutNo = ss1.ActiveSheet.Cells[lRow, SPD_CUT_NO].Text;
                    dThk = convertX(ss1.ActiveSheet.Cells[lRow, SPD_THK].Text);
                    //Val(.Text & "")
                    dWid = convertX(ss1.ActiveSheet.Cells[lRow, SPD_WID].Text);
                    //Val(.Text & "")
                    dLen = convertX(ss1.ActiveSheet.Cells[lRow, SPD_LEN].Text);
                    //Val(.Text & "")
                    dWgt = convertX(ss1.ActiveSheet.Cells[lRow, SPD_WGT].Text);
                    //Val(.Text & "")
                    sSize_knd = ss1.ActiveSheet.Cells[lRow, SPD_SIZE_KND].Text;
                    sTrim_fl = ss1.ActiveSheet.Cells[lRow, SPD_TRIM_FL].Text;
                    sAply_stdspec = ss1.ActiveSheet.Cells[lRow, SPD_APLY_STDSPEC].Text;
                    sStdspec_YY = ss1.ActiveSheet.Cells[lRow, SPD_STDSPEC_YY].Text;
                    sEmp_cd = ss1.ActiveSheet.Cells[lRow, SPD_EMP_CD].Text;
                    sStdspec = ss1.ActiveSheet.Cells[lRow, SPD_STLGRD].Text;
                }
                else
                {
                    sPlateNo = txt_plate_no.Text + "00";
                }

                ss1.ActiveSheet.Cells[lRow + 1, SPD_PLATE_NO].Text = sPlateNo;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_LOT_NO].Text = sLotNo;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_CUT_NO].Text = sCutNo;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_THK].Text = dThk.ToString();
                ss1.ActiveSheet.Cells[lRow + 1, SPD_WID].Text = dWid.ToString();
                ss1.ActiveSheet.Cells[lRow + 1, SPD_LEN].Text = dLen.ToString();
                ss1.ActiveSheet.Cells[lRow + 1, SPD_WGT].Text = dWgt.ToString();
                ss1.ActiveSheet.Cells[lRow + 1, SPD_SIZE_KND].Text = sSize_knd;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_TRIM_FL].Text = sTrim_fl;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_APLY_STDSPEC].Text = sAply_stdspec;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_EMP_CD].Text = sEmp_cd;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_STDSPEC_YY].Text = sStdspec_YY;
                ss1.ActiveSheet.Cells[lRow + 1, SPD_STLGRD].Text = sStdspec;
                ss1.ActiveSheet.RowHeader.Cells[lRow + 1, 0].Text = "增加";
                ss1.ActiveSheet.Cells[lRow + 1, SPD_PLATE_NO].Text = substr(ss1.ActiveSheet.Cells[lRow + 1, SPD_PLATE_NO].Text, 0, 12) + String.Format("{0:D2}", (convertI(substr(ss1.ActiveSheet.Cells[lRow + 1, SPD_PLATE_NO].Text, 12, 2)) + 1));
                ss1.ActiveSheet.Cells[lRow + 1, SPD_SURF_GRD].Text = "True";
                ss1.ActiveSheet.Cells[lRow + 1, SPD_MARK_YN].Text = "True";
                ss1.ActiveSheet.Cells[lRow + 1, SPD_STAMP_YN].Text = "True";
                ss1.ActiveSheet.Cells[lRow + 1, SPD_BAR_YN].Text = "True";
                //        .Col = SPD_LINE1:         .Value = 1
                ss1.ActiveSheet.RowHeader.Cells[lRow + 1, 0].Text = "增加";

                ss1.ActiveSheet.SetActiveCell(lRow + 1, 0);
        }


        private void opt_line1_Click(object sender, EventArgs e)
        {

            if (opt_line1.Checked)
            {
                opt_line1.ForeColor = Color.Red;
                opt_line2.ForeColor = Color.Black;
                txt_line.Text = "1";
                if (ss1.ActiveSheet.RowCount > 0) Form_Ref();
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);
                //        Winsock1.RemoteHost = "172.18.43.98" 'Gf_ComnNameFind(M_CN1, "G0034", "01", 1)
                //        Winsock1.RemotePort = "2121" 'Gf_ComnNameFind(M_CN1, "G0034", "01", 2)
                //        Winsock2.RemoteHost = "172.18.43.98" 'Gf_ComnNameFind(M_CN1, "G0034", "01", 1)
                //        Winsock2.RemotePort = "25298" 'Gf_ComnNameFind(M_CN1, "G0034", "01", 2)
                Winsock1.RemoteHost =GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "01", 1);
                Winsock1.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "01", 2));
                Winsock2.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "01", 1);
                Winsock2.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "01", 2));
            }

        }


        private void opt_line2_Click(object sender, EventArgs e)
        {
            if (opt_line2.Checked)
            {
                opt_line2.ForeColor = Color.Red;
                opt_line1.ForeColor = Color.Black;
                txt_line.Text = "2";
                if (ss1.ActiveSheet.RowCount > 0) Form_Ref();
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, false);
                SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, true);
                Winsock1.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "02", 1);
                Winsock1.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "02", 2));
                Winsock2.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "02", 1);
                Winsock2.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0040", "02", 2));
            }

        }

        private void opt_line3_Click(object sender, EventArgs e)
        {
            if (opt_line3.Checked)
            {
                opt_line3.ForeColor = Color.Red;
                opt_line4.ForeColor = Color.Black;
                txt_rec_sts.Text = "1";
            }
        }

        private void opt_line4_Click(object sender, EventArgs e)
        {
            if (opt_line4.Checked)
            {
                opt_line4.ForeColor = Color.Red;
                opt_line3.ForeColor = Color.Black;
                txt_rec_sts.Text = "2";
            }
        }

        private void opt_line5_Click(object sender, EventArgs e)
        {
            if (opt_line5.Checked)
            {
                opt_line5.ForeColor = Color.Red;
                opt_line6.ForeColor = Color.Black;
            }

        }


        private void opt_line6_Click(object sender, EventArgs e)
        {
            if (opt_line6.Checked)
            {
                opt_line6.ForeColor = Color.Red;
                opt_line5.ForeColor = Color.Black;
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

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
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

        private void ss1_ButtonClicked(object sender, EditorNotifyEventArgs e)
        {
            string sCheck1;
            string sCheck2;

            int iCol;
            int iRow;
            int iMode;

            int iRowNum;
            int iRowfr;
            int iRowto;

            iCol = e.Column;
            iRow = e.Row;

            if (ss1.ActiveSheet.RowCount <= 0) return;
            if (e.Column != SPD_LINE1 & e.Column != SPD_LINE2) return;
            if (!GeneralCommon.Gf_Sc_Authority(sAuthority, "U")) return;

            iRowto = iRow - 1;
            iRowfr = iRow + 1;

            if (iRowto >= 0)
            {
                for (iRowNum = 0; iRowNum <= iRowto; iRowNum++)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iRowNum,0].Text != "")
                    {
                        ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                        ss1.ActiveSheet.Cells[iRowNum, SPD_LINE1].Text = "False";
                        ss1.ActiveSheet.Cells[iRowNum, SPD_LINE2].Text = "False";
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

            if (iRowfr <= ss1.ActiveSheet.RowCount-1)
            {
                for (iRowNum = iRowfr; iRowNum <= ss1.ActiveSheet.RowCount-1; iRowNum++)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text != "")
                    {
                        ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                        ss1.ActiveSheet.Cells[iRowNum, SPD_LINE1].Text = "False";
                        ss1.ActiveSheet.Cells[iRowNum, SPD_LINE2].Text = "False";
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

            if (e.Column == SPD_LINE1 & ss1.ActiveSheet.Cells[iRow, e.Column].Text == "True")
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LINE2].Text = "False";
            }
            else if (e.Column == SPD_LINE2 & ss1.ActiveSheet.Cells[iRow, e.Column].Text == "True")
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LINE1].Text = "False";
            }

            ss1.ActiveSheet.RowHeader.Cells[iRow, 0].Text = "修改";

            sCheck1 = ss1.ActiveSheet.Cells[iRow, SPD_LINE1].Text;
            sCheck2 = ss1.ActiveSheet.Cells[iRow, SPD_LINE2].Text;

            if (sCheck1 == "False" & sCheck2 == "False")
            {
                ss1.ActiveSheet.RowHeader.Cells[iRow, 0].Text = "";
            }

            ss1.ActiveSheet.Cells[iRow, SPD_EMP_CD].Text = GeneralCommon.sUserID;

            if (chk_Cond[1].Checked)
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LABEL].Text = "True";
            }
            else
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LABEL].Text = "False";
            }

            if (chk_Cond[0].Checked)
            {
                ss1.ActiveSheet.Cells[iRow, SPD_PAINT].Text = "True";
            }
            else
            {
                ss1.ActiveSheet.Cells[iRow, SPD_PAINT].Text = "False";
            }

            if (opt_line6.Checked)
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LOTCD].Text = "True";
            }
            else
            {
                ss1.ActiveSheet.Cells[iRow, SPD_LOTCD].Text = "False";
            }

            //        ss1.Col = SPD_MARK_YN
            //        If ss1.Value Then                'chk_Cond(2) hanchao 20140325
            //           ss1.Value = 1
            //        Else
            //           ss1.Value = 0
            //        End If
            //        ss1.Col = SPD_STAMP_YN
            //        If ss1.Value Then               'chk_Cond(3) hanchao 20140325
            //           ss1.Value = 1
            //        Else
            //           ss1.Value = 0
            //        End If
            //        ss1.Col = SPD_BAR_YN
            //        If ss1.Value Then             'chk_Cond(4) hanchao 20140325
            //           ss1.Value = 1
            //        Else
            //           ss1.Value = 0
            //        End If

            Cmd_SEND_SET(e.Row);
        }

        private void ss1_EditModeOn(object sender, EventArgs e)
        {
            int iCol;
            int iRow;
            int iMode;

            int iRowNum;
            int iRowfr;
            int iRowto;

            if (ss1.ActiveSheet.RowCount <= 0) return;

            iCol = ss1.ActiveSheet.ActiveColumnIndex;
            iRow = ss1.ActiveSheet.ActiveRowIndex;


            if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U") && ss1.ActiveSheet.ActiveColumnIndex > SPD_LINE2)
            {
                iRowto = iRow - 1;
                iRowfr = iRow + 1;

                if (iRowto >= 0)
                {

                    for (iRowNum = 0; iRowNum <= iRowto; iRowNum++)
                    {
                        if (ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text != "")
                        {
                            ss1.ActiveSheet.Cells[iRowNum, SPD_LINE1].Text = "False";
                            ss1.ActiveSheet.Cells[iRowNum, SPD_LINE2].Text = "False";
                            ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                            //break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                }

                if (iRowfr <= ss1.ActiveSheet.RowCount - 1)
                {

                    for (iRowNum = iRowfr; iRowNum <= ss1.ActiveSheet.RowCount - 1; iRowNum++)
                    {
                        if (ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text != "")
                        {
                            ss1.ActiveSheet.Cells[iRowNum, SPD_LINE1].Text = "False";
                            ss1.ActiveSheet.Cells[iRowNum, SPD_LINE2].Text = "False";
                            ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                            //break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                }

                if (iCol == SPD_THK | iCol == SPD_WID | iCol == SPD_LEN)
                {
                    ss1.ActiveSheet.Cells[iRow, iCol].Text = "0";
                }

                //SpreadCommon.Gp_Sp_UpdateMake(Proc_Sc("SC")("Spread"), iMode);

                ss1.ActiveSheet.RowHeader.Cells[iRow, 0].Text = "修改";

                //ss1.ActiveRow
                ss1.ActiveSheet.Cells[iRow, SPD_EMP_CD].Text = GeneralCommon.sUserID;

                if (chk_Cond[1].Checked)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LABEL].Text = "True";
                }
                else
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LABEL].Text = "False";
                }

                if (chk_Cond[0].Checked)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_PAINT].Text = "True";
                }
                else
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_PAINT].Text = "False";
                }

                if (opt_line6.Checked)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LOTCD].Text = "True";
                }
                else
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LOTCD].Text = "False";
                }

                if (opt_line1.Checked)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LINE1].Text = "True";
                }
                else
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LINE1].Text = "False";
                }
                if (opt_line2.Checked)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LINE2].Text = "True";
                }
                else
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_LINE2].Text = "False";
                }

                //        ss1.Col = SPD_MARK_YN
                //        If chk_Cond(2) Then
                //           ss1.Value = 1
                //        Else
                //           ss1.Value = 0
                //        End If
                //        ss1.Col = SPD_STAMP_YN
                //        If chk_Cond(3) Then
                //           ss1.Value = 1
                //        Else
                //           ss1.Value = 0
                //        End If
                //        ss1.Col = SPD_BAR_YN
                //        If chk_Cond(4) Then
                //           ss1.Value = 1
                //        Else
                //           ss1.Value = 0
                //        End If

                Cmd_SEND_SET(iRow);

            }
        }

        private void Cmd_SEND_SET(int ROW)
        {
            //Dim Header As String * 2
            string[] Header = new string[2];
            string Nisco;
            string sFlag;
            string sNull;

            string sPlate_no;
            string sThk;
            string sWid;
            string sLen;
            string sSpec;
            string sSpec_ALL = "";
            string sSpec1;
            string sSpec2;
            string sSpec_Str;
            string sStdspec_YY;
            int sNum;
            string sNumFL;

            string sCurDate;
            string sOrderNo;
            string sDel_To_Date;

            string sAdd_W = "";
            string sAdd_S = "";
            string sAdd_T;
            string sAdd_H;
            string iPaint_Add;

            string sCUST_CD_SHORT;
            string sideMark;

            sCurDate = DateTime.Now.ToString("yyyyMM");

            if (opt_line5.Checked)
            {
                TXT_MAT_NO.Text = ss1.ActiveSheet.Cells[ROW, SPD_PLATE_NO].Text;
            }
            else
            {
                TXT_MAT_NO.Text = ss1.ActiveSheet.Cells[ROW, SPD_LOT_NO].Text;
            }
            TXT_THK.Text = ss1.ActiveSheet.Cells[ROW, SPD_THK].Text.Replace(",","");
            TXT_THK.Text = substr(TXT_THK.Text, 0, TXT_THK.Text.IndexOf("."));
            TXT_WID.Text = ss1.ActiveSheet.Cells[ROW, SPD_WID].Text.Replace(",", "");
            TXT_LEN.Text = ss1.ActiveSheet.Cells[ROW, SPD_LEN].Text.Replace(",", "");
            TXT_WGT.Text = ss1.ActiveSheet.Cells[ROW, SPD_WGT].Text.Replace(",", "");
            if (substr(TXT_WGT.Text, 0, 1) == ".")
            {
                TXT_WGT.Text = "0" + TXT_WGT.Text;
            }
            TXT_SPEC.Text = ss1.ActiveSheet.Cells[ROW, SPD_STDSPEC_YY].Text;
            TXT_SPEC_DATE.Text = ss1.ActiveSheet.Cells[ROW, SPD_STLGRD].Text;
            TXT_ORD_REMARK.Text = ss1.ActiveSheet.Cells[ROW, SPD_ORD_REMARK].Text;
            TXT_VESSEL_NO.Text = ss1.ActiveSheet.Cells[ROW, SPD_VESSEL_NO].Text.Trim();
            sAdd_T = ss1.ActiveSheet.Cells[ROW, SPD_UST].Text;
            TXT_CUST_CD.Text = ss1.ActiveSheet.Cells[ROW, SPD_CUST_CD].Text.Trim();
            TXT_TO_CUR_INV.Text = ss1.ActiveSheet.Cells[ROW, SPD_TO_CUR_INV].Text;
            sCUST_CD_SHORT = ss1.ActiveSheet.Cells[ROW, SPD_CUST_CD_SHORT].Text;
            TXT_PAINTNUM.Text = ss1.ActiveSheet.Cells[ROW, SPD_PAINTNUM].Text;
            sideMark = ss1.ActiveSheet.Cells[ROW, SPD_SIDE_MARK].Text;
            TXT_CE.Text = ss1.ActiveSheet.Cells[ROW, SPD_CE].Text;

            if (sSpec_ALL == "")
            {
                sSpec_ALL = ss1.ActiveSheet.Cells[ROW, SPD_APLY_STDSPEC].Text;
            }

            sOrderNo = substr(ss1.ActiveSheet.Cells[ROW, SPD_ORD_NO].Text,0,3);

            if (sOrderNo == "OB5")
            {
                sAdd_W = "W";
            }

            sDel_To_Date = substr(ss1.ActiveSheet.Cells[ROW, SPD_DEL_TO_DATE].Text, 0, 6);

            if (convertX(sDel_To_Date) < convertX(sCurDate))
            {
                sAdd_S = "S";
            }

            sAdd_T = ss1.ActiveSheet.Cells[ROW, SPD_CUR_UST].Text;

            if (sAdd_T == "")
            {
                sAdd_T = ss1.ActiveSheet.Cells[ROW, SPD_UST].Text;
            }

            if (sAdd_T == "" | sAdd_T == "X")
            {
                sAdd_T = "";
            }

            sAdd_H = ss1.ActiveSheet.Cells[ROW, SPD_HTM_METH].Text;

            iPaint_Add = sAdd_W + sAdd_S + sAdd_T + sAdd_H;


            //ss1.Col = 0;

            Nisco = "NG";
            sFlag = "X";
            sNull = " ";

            sPlate_no = TXT_MAT_NO.Text;
            sThk = TXT_THK.Text;
            sWid = TXT_WID.Text;
            sLen = TXT_LEN.Text;
            sSpec = TXT_SPEC_DATE.Text;
            sSpec1 = sSpec;
            sSpec2 = sSpec;
            sStdspec_YY = TXT_SPEC.Text;

            sNum = sSpec_ALL.IndexOf("-");
            if (sNum == -1)
            {
                sNumFL = "Y";
                sNum = sSpec_ALL.Length;
            }

            sSpec_Str = substr(sSpec_ALL, 0, sNum);

            sSpec1 = sStdspec_YY;
            sSpec2 = sStdspec_YY;

            switch (sSpec_Str)
            {

                case "BV":

                    break;
                case "CCS":

                    break;
                case "DNV":
                    break;

                case "VL":

                    break;
                case "GL":

                    break;
                case "KR":

                    break;
                case "LR":

                    break;
                case "NK":
                    break;

                case "RINA":

                    break;
                case "ABS":
                    break;

                case "RS":
                    break;

                default:
                    sSpec1 = sSpec + " " + sStdspec_YY;
                    sSpec2 = sSpec;
                    break;
            }

            //TXT_Paint1 = Nisco & sNull & sPlate_no
            TXT_Paint1.Text = sPlate_no;
            TXT_Paint2.Text = sSpec1;
            TXT_Paint3.Text = sThk + sFlag + sWid + sFlag + sLen;
            TXT_Paint4.Text = iPaint_Add + sNull + TXT_VESSEL_NO.Text;
            TXT_Paint4.Text = TXT_Paint4.Text.Trim();
            TXT_Paint4.Text = sCUST_CD_SHORT + "  " + TXT_Paint4.Text;
            TXT_Paint4.Text = TXT_Paint4.Text.Trim();

            TXT_Punch1.Text = sSpec2 + sNull + sPlate_no;
            TXT_Punch2.Text = sPlate_no;

            //TXT_Edge = sPlate_no & sNull & sThk & sFlag & sWid & sFlag & sLen & sNull & sSpec2 & sNull & TXT_VESSEL_NO & sNull & TXT_CUST_CD & TXT_TO_CUR_INV
            TXT_Edge.Text = sPlate_no + sNull + sSpec2 + sNull + sThk + sFlag + sWid + sFlag + sLen + sNull + sideMark + sNull + TXT_CUST_CD.Text + TXT_TO_CUR_INV.Text;
            TXT_Bar.Text = TXT_MAT_NO.Text;

        }

        private void Cmd_SEND(int row,string iMark_no, string iThk, string iWid, string iLen, string iWGT, string iSpec, string iStdspec_yy, string iPlate_no)
        {
            string SMESG;

            int i;

            string sMark_no;//16个字符
            string sPlate_no;//16个字符
            string sThk;
            string sWid;
            string sLen;
            string sWgt;
            string sSpec;
            string sSpec_ALL;
            string sSpec1;
            string sSpec2;
            string sStdspec_YY;
            string sUser;//6个字符
            string Header;//2个字符
            string Nisco_Logo;
            string Nisco;
            string sFlag;
            byte sPaint;
            byte sPunch;
            byte sEdge;
            string sNull;
            string sNullstr;

            string sSpec_Str;
            string sSpec_Logo = "";
            string sPaint_Logo1;
            string sPaint_Logo2;
            string sPaint_Logo3;
            string sPaint_Logo4;
            string sPunch_Logo1;
            string sPunch_Logo2;
            string sPunch_Logo3;
            string sPunch_Logo4;
            string sSpec_IRS_Logo;
            string sProd_Date;
            string sGroup;
            int sNum;
            string sNumFL;

            string PaintStr;
            short PaintStr_CD;
            string[] Paint = new string[4];//78个字符

            string PunchStr;
            string[] Punch = new string[2];//32个字符

            string EdgeStr;
            short EdgeStr_CD;
            string Edge;//48个字符
            string Bar;//18个字符

            string[] StrSend = new string[10];

            string sCurDate;
            string sOrderNo;
            string sDel_To_Date;

            string sAdd_W = "";
            string sAdd_S = "";
            string sAdd_T = "";
            string sAdd_H = "";
            string iPaint_Add;

            string sNisco;

            string sEdgeString;
            //2012-03-01  modify by liqian 侧标位数扩展50->65
            //2012-07-16  modify by liqian 侧标位数扩展65->90
            //Dim sEdgeStr As String * 90
            string sEdgeStr;//90
            string sVESSEL_NO;
            string sideMark;
            string sCUST_CD;
            string sCUST_CD_SHORT;
            string sTO_CUR_INV;

            string sJIT_FLAG;
            string sEALMEMO;

            string sPAINTNUM;

            string sSce_Str;
            string sSce_Logo;
            int sStr_Len;

            string sSinspunita;
            string sSinspunitb;
            string sSinspunitc;


            int PRODSPECNOA;
            int PRODSPECNOB;
            int PRODSPECNOC;

            string sSpec_Punch_Logo;

            string sClasscd;
            string sClasslvl;

            string sClass;


            sCurDate = DateTime.Now.ToString("yyyyMM");
            sAdd_T = "T";

            sMark_no = iMark_no;
            sMark_no = sMark_no.PadRight(16, ' ');

            sPlate_no = iPlate_no;
            sPlate_no = sPlate_no.PadRight(16, ' ');
            sThk = iThk;
            sWid = iWid;
            sLen = iLen;
            sWgt = iWGT;
            sSpec = iSpec;
            sSpec1 = iSpec;
            sSpec2 = iSpec;
            sStdspec_YY = iStdspec_yy;
            sUser = GeneralCommon.sUserID;
            sUser = sUser.PadRight(6, ' ');

            Header = "MD";
            Nisco_Logo = Chr(1);
            Nisco = "NG";
            sFlag = "X";
            sNumFL = "N";
           

            //    sPaint = 1
            //    sPunch = 1
            //    sEdge = 1

            sProd_Date = udt_date_fr.RawDate;
            sGroup = cbo_group.Text.Trim();

            if (sGroup != "A" & sGroup != "B" & sGroup != "C" & sGroup != "D")
            {
                SMESG = " 班别错误，请确认是否正确输入班别";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            sPaint = ss1.ActiveSheet.Cells[row,SPD_MARK_YN].Text == "True"?(byte)1:(byte)0;
            sPunch = ss1.ActiveSheet.Cells[row,SPD_STAMP_YN].Text == "True"?(byte)1:(byte)0;
            sEdge = ss1.ActiveSheet.Cells[row,SPD_BAR_YN].Text == "True"?(byte)1:(byte)0;

            sPAINTNUM = ss1.ActiveSheet.Cells[row, SPD_PAINTNUM].Text;
            if (sPAINTNUM == "" || sPAINTNUM == "0")
            {
                sPAINTNUM = "1";
            }

            sSpec_ALL = ss1.ActiveSheet.Cells[row, SPD_APLY_STDSPEC].Text;

            PRODSPECNOA = convertI(ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOA_STD].Text);
            PRODSPECNOB = convertI(ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOB_STD].Text);
            PRODSPECNOC = convertI(ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOC_STD].Text);
            sSinspunita = ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOA].Text;
            sSinspunitb = ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOB].Text;
            sSinspunitc = ss1.ActiveSheet.Cells[row, SPD_PRODSPECNOC].Text;

            sClasscd = ss1.ActiveSheet.Cells[row, SPD_CLASS_CD].Text;
            sClasslvl = ss1.ActiveSheet.Cells[row, SPD_CLASS_LVL].Text;
            if (sClasscd == "Y")
            {
                sClass = sClasslvl;
            }
            else
            {
                sClass = "";
            }


            sNum = sSpec_ALL.IndexOf("-");
            if (sNum == -1)
            {
                sNumFL = "Y";
                sNum = sSpec_ALL.Length;
            }
            sSpec_Str = substr(sSpec_ALL, 0, sNum);

            sSpec1 = sStdspec_YY;
            sSpec2 = sStdspec_YY;

            sSce_Str = TXT_CE.Text;

            //喷印logo、冲印logo初始化。喷印logo1为双锤给1，logo2为船徽，logo3、4给0；冲印logo1为船徽，logo2、3、4给0
            sPaint_Logo1 = Chr(1);
            sPaint_Logo2 = Chr(0);
            sPaint_Logo3 = Chr(0);
            sPaint_Logo4 = Chr(0);
            sPunch_Logo1 = Chr(0);
            sPunch_Logo2 = Chr(0);
            sPunch_Logo3 = Chr(0);
            sPunch_Logo4 = Chr(0);

            switch (sSpec_Str)
            {
                case "BV":
                    sPaint_Logo2 = Chr(134 - 126);
                    //44--134
                    sPunch_Logo1 = Chr(134 - 126);
                    //44--134
                    sSpec_IRS_Logo = "  ";
                    break;
                case "CCS":
                    sPaint_Logo2 = Chr(140 - 126);
                    //33--140
                    sPunch_Logo1 = Chr(140 - 126);
                    //33--140
                    sSpec_IRS_Logo = "  ";
                    break;
                case "DNV":
                    sPaint_Logo2 = Chr(159 - 126);
                    //39--159
                    sPunch_Logo1 = Chr(159 - 126);
                    //39--159
                    sSpec_IRS_Logo = "  ";
                    break;
                case "VL":
                    sPaint_Logo2 = Chr(159 - 126);
                    //39--159
                    sPunch_Logo1 = Chr(159 - 126);
                    //39--159
                    sSpec_IRS_Logo = "  ";
                    break;
                case "GL":
                    sPaint_Logo2 = Chr(159 - 126);
                    //39--159
                    sPunch_Logo1 = Chr(159 - 126);
                    //39--159
                    sSpec_IRS_Logo = "  ";
                    break;
                case "KR":
                    sPaint_Logo2 = Chr(146 - 126);
                    //94--146
                    sPunch_Logo1 = Chr(146 - 126);
                    //94--146
                    sSpec_IRS_Logo = "  ";
                    break;
                case "LR":
                    sPaint_Logo2 = Chr(145 - 126);
                    //96--145
                    sPunch_Logo1 = Chr(145 - 126);
                    //96--145
                    sSpec_IRS_Logo = "  ";
                    break;
                case "NK":
                    sPaint_Logo2 = Chr(133 - 126);
                    //95--133
                    sPunch_Logo1 = Chr(133 - 126);
                    //95--133
                    sSpec_IRS_Logo = "  ";
                    break;
                case "RINA":
                    sPaint_Logo2 = Chr(161 - 126);
                    //63--161
                    sPunch_Logo1 = Chr(161 - 126);
                    //63--161
                    sSpec_IRS_Logo = "  ";
                    break;
                case "ABS":
                    sPaint_Logo2 = Chr(158 - 126);
                    //34--158
                    sPunch_Logo1 = Chr(158 - 126);
                    //34--158
                    sSpec_IRS_Logo = "  ";
                    break;
                case "RS":
                    //俄罗斯船级社
                    sPaint_Logo2 = Chr(142 - 126);
                    //36--142
                    sPunch_Logo1 = Chr(142 - 126);
                    //36--142
                    sSpec_IRS_Logo = "  ";
                    break;
                case "IRS":
                    sPaint_Logo2 = Chr(148 - 126);
                    //""--148
                    sPunch_Logo1 = Chr(148 - 126);
                    //""--148
                    sSpec_IRS_Logo = "  ";
                    break;
                default:
                    sSpec_IRS_Logo = "";
                    sSpec1 = sSpec + " " + sStdspec_YY;
                    sSpec2 = sSpec;
                    break;
            }

            sPaint_Logo3 = Chr(PRODSPECNOA);
            sPaint_Logo4 = Chr(PRODSPECNOB);

            sPunch_Logo2 = Chr(PRODSPECNOA);
            sPunch_Logo3 = Chr(PRODSPECNOB);

            if (sSinspunita != "")
            {
                sSpec_Punch_Logo = "  ";
            }
            else
            {
                sSpec_Punch_Logo = "";
            }

            if (sSce_Str == "是")
            {
                sPaint_Logo2 = Chr(137 - 126);
            }
            else
            {
                sSce_Logo = "";
            }

            StrSend[0] = Chr(75);
            //46-->75
            StrSend[1] = Chr(75);
            //46-->75
            sNull = StrSend[0] + StrSend[1];
            sNullstr = " ";

            //2012-10-22  modify by liqian 标印第一行加 NISCO
            sNisco = sNullstr + "NISCO ";
            //      sNisco = Chr(128)

            //有重量标识要求的编辑重量信息
            if (iStdspec_yy == "GB 713-2008" | iStdspec_yy == "GB 3531-2008" | iStdspec_yy == "GB 19189-2011" | iStdspec_yy == "GB 713-2014" | iStdspec_yy == "GB 3531-2014" | iStdspec_yy == "GB/T 713-2014" | iStdspec_yy == "GB/T 3531-2014" | iStdspec_yy == "GB/T 19189-2011")
            {
                sWgt = "  T.W." + sWgt + "t";
            }
            else
            {
                sWgt = "";
            }

            //编辑探伤信息
            //如果钢板要求探伤，喷印第四行加喷 T

            sAdd_T = ss1.ActiveSheet.Cells[row, SPD_CUR_UST].Text;
            if (sAdd_T == "")
            {
                sAdd_T = ss1.ActiveSheet.Cells[row, SPD_UST].Text;
            }

            sStr_Len = ("   " + sMark_no + sWgt + " " + sAdd_T + " " + sClass).Length;
            Paint[0] = Chr(75) + Chr(sStr_Len) + "   " + sMark_no + sWgt + " " + sAdd_T + " " + sClass;
            Paint[0] = Paint[0].PadRight(78, ' ');

            sStr_Len = ("   " + sSpec1 + " " + sSinspunita).Length;
            Paint[1] = Chr(75) + Chr(sStr_Len) + "   " + sSpec1 + " " + sSinspunita;
            Paint[1] = Paint[1].PadRight(78, ' ');

            sStr_Len = ("   " + sThk + sFlag + sWid + sFlag + sLen + sNullstr + sProd_Date + sNullstr + sGroup).Length;
            Paint[2] = Chr(75) + Chr(sStr_Len) + "   " + sThk + sFlag + sWid + sFlag + sLen + sNullstr + sProd_Date + sNullstr + sGroup;
            Paint[2] = Paint[2].PadRight(78, ' ');

            sOrderNo = substr(ss1.ActiveSheet.Cells[row, SPD_ORD_NO].Text, 0, 3);

            if (sOrderNo == "OB5")
            {
                sAdd_W = "W";
            }

            sDel_To_Date = substr(ss1.ActiveSheet.Cells[row, SPD_DEL_TO_DATE].Text, 0, 6);

            if (convertX(sDel_To_Date) < convertX(sCurDate))
            {
                sAdd_S = "S";
            }

            if (ss1.ActiveSheet.Cells[row, SPD_JIT_FLAG].Text == "Y")
            {
                sJIT_FLAG = "DZ";
                // 17-DZ
            }
            else
            {
                sJIT_FLAG = "";
            }

            sAdd_H = ss1.ActiveSheet.Cells[row, SPD_HTM_METH].Text.Trim();

            iPaint_Add = sAdd_W + sAdd_S + sAdd_H;

            sVESSEL_NO = ss1.ActiveSheet.Cells[row,SPD_VESSEL_NO].Text.Trim();
            sideMark = ss1.ActiveSheet.Cells[row,SPD_SIDE_MARK].Text.Trim();
            sCUST_CD = ss1.ActiveSheet.Cells[row,SPD_CUST_CD].Text.Trim();
            sTO_CUR_INV = ss1.ActiveSheet.Cells[row,SPD_TO_CUR_INV].Text.Trim();
            sCUST_CD_SHORT = ss1.ActiveSheet.Cells[row,SPD_CUST_CD_SHORT].Text.Trim();
            sEALMEMO = ss1.ActiveSheet.Cells[row, SPD_SEALMEMO].Text.Trim();

            //编辑喷印第四行
            //如果钢板为子公司产品，喷印第四行首位喷子公司简码+（探伤标识）+（用户加喷信息）
            if (opt_line5.Checked)
            {
                Paint[3] = sCUST_CD_SHORT + "  " + iPaint_Add + " " + sVESSEL_NO;
                sStr_Len = (sCUST_CD_SHORT + "  " + iPaint_Add + " " + sVESSEL_NO).Length;
            }
            else
            {
                Paint[3] = sPlate_no + " " + sCUST_CD_SHORT + "  " + iPaint_Add + " " + sVESSEL_NO;
                sStr_Len = (sPlate_no + " " + sCUST_CD_SHORT + "  " + iPaint_Add + " " + sVESSEL_NO).Length;
            }

            if (sJIT_FLAG == "")
            {
                Paint[3] = Chr(75) + Chr(sStr_Len) + Paint[3];
            }
            else
            {
                Paint[3] = Chr(75) + Chr(sStr_Len + 4) + sJIT_FLAG + "  " + Paint[3];
            }

            Paint[3] = Paint[3].PadRight(78, ' ');

            PaintStr = Paint[0] + Paint[1] + Paint[2] + Paint[3];

            StrSend[2] = Chr(30);
            StrSend[3] = Chr(30);
            sNull = StrSend[2] + StrSend[3];

            PaintStr_CD = convertS(TXT_P.Text);

            if ((sSpec_IRS_Logo + sSpec2 + sNullstr + sMark_no + sNullstr).Length > 30)
            {
                sStr_Len = (sSpec_IRS_Logo + sSpec2 + sNullstr).Length;
                Punch[0] = Chr(30) + Chr(sStr_Len) + sSpec_IRS_Logo + sSpec2 + sNullstr;

                sStr_Len = (sSpec_Punch_Logo + sSinspunita + sMark_no + sNullstr + sEALMEMO).Length;
                Punch[1] = Chr(30) + Chr(sStr_Len) + sSpec_Punch_Logo + sSinspunita + sMark_no + sNullstr + sEALMEMO;

                //       sStr_Len = Len(sMark_no & sNullstr & sEALMEMO)
                //       Punch(1) = Chr(30) & Chr(sStr_Len) & sMark_no & sNullstr & sEALMEMO
            }
            else
            {
                sStr_Len = (sSpec_IRS_Logo + sSpec2 + sNullstr + sMark_no + sNullstr).Length;
                Punch[0] = Chr(30) + Chr(sStr_Len) + sSpec_IRS_Logo + sSpec2 + sNullstr + sMark_no + sNullstr;

                sStr_Len = (sSpec_Punch_Logo + sSinspunita + sEALMEMO).Length;
                Punch[1] = Chr(30) + Chr(sStr_Len) + sSpec_Punch_Logo + sSinspunita + sEALMEMO;

                //       sStr_Len = Len(sEALMEMO)
                //       Punch(1) = Chr(30) & Chr(sStr_Len) & sEALMEMO
            }

            Punch[0] = Punch[0].PadRight(32, ' ');
            Punch[1] = Punch[1].PadRight(32, ' ');
            PunchStr = Punch[0] + Punch[1];

            StrSend[4] = Chr(46);
            StrSend[5] = Chr(46);
            sNull = StrSend[4] + StrSend[5];
            EdgeStr_CD = convertS(TXT_H.Text);
            Edge = sNull + sSpec2 + sNullstr + sMark_no + sThk + sFlag + sWid + sFlag + sLen;
            Edge = Edge.PadRight(48, ' ');

            StrSend[6] = Chr(16);
            StrSend[7] = Chr(16);
            sNull = StrSend[6] + StrSend[7];
            Bar = sNull + sMark_no;
            Bar = Bar.PadRight(18, ' ');
            EdgeStr = Bar + Edge;

            
                if (chk_Cond8.Checked && sEdge == 1)
                {
                    sEdgeString = sMark_no;
                    sEdgeString = sEdgeString.Trim() + " " + sSpec2.Trim() + " " + sSinspunita + " " + sThk.Trim() + "X" + sWid.Trim() + "X" + sLen.Trim();
                    //            sEdgeString = Trim(sEdgeString) & " " & Trim(sSpec2) & " " & Trim(sThk) & "X" & Trim(sWid) & "X" & Trim(sLen)
                    //            sEdgeString = Trim(sEdgeString) & " " & Trim(sSpec2) & " " & Trim(sThk) & "X" & Trim(sWid) & "X" & Trim(sLen)
                    sEdgeString = sEdgeString + " " + sideMark;
                    sEdgeString = sEdgeString.Trim() + " " + sCUST_CD + " " + sTO_CUR_INV + " " + sClass;
                    sEdgeStr = sEdgeString.Trim();

                    Winsock2.SendData(sEdgeStr);
                }

                if (chk_Cond0.Checked)
                {
                    Winsock1.SendData(Header + "  " + Chr(16) + Chr(14) + sMark_no);
                    Winsock1.SendData(sPaint_Logo1 + sPaint_Logo2 + sPaint_Logo3 + sPaint_Logo4 + sPunch_Logo1 + sPunch_Logo2 + sPunch_Logo3 + sPunch_Logo4);
                    Winsock1.SendData(HiByte(convertS(sPAINTNUM)));
                    Winsock1.SendData(LoByte(convertS(sPAINTNUM)));
                    Winsock1.SendData(HiByte(0));
                    Winsock1.SendData(LoByte(0));
                    Winsock1.SendData(HiByte(convertS(sWid)));
                    Winsock1.SendData(LoByte(convertS(sWid)));
                    Winsock1.SendData(HiByte(convertS(sLen)));
                    Winsock1.SendData(LoByte(convertS(sLen)));

                    Winsock1.SendData(HiByte(sPaint));
                    Winsock1.SendData(LoByte(sPaint));
                    Winsock1.SendData(HiByte(sPunch));
                    Winsock1.SendData(LoByte(sPunch));
                            
                    Winsock1.SendData(PaintStr);
                                
                    Winsock1.SendData(HiByte(PaintStr_CD));
                    Winsock1.SendData(LoByte(PaintStr_CD));
                    Winsock1.SendData(PunchStr);

                }

        }

        public static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                if (asciiCode == 0)
                {
                    return "";
                }
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                if (strCharacter == "\r" || strCharacter == "\t" || strCharacter == "\n")
                {
                    strCharacter = "";
                }

                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //sckClosed            0 缺省的。--关闭 没有的
            //sckOpen              1 打开 --打开的
            //sckListening         2 侦听 --察看有没有请求进入的
            //sckConnectionPending 3 连接挂起
            //sckResolvingHost     4 识别主机
            //sckHostResolved      5 已识别主机
            //sckConnecting        6 正在连接
            //sckConnected         7 已连接
            //sckClosing           8 同级人员正在关闭连接 -说明对方关闭了你连接
            //sckError             9 错误

                string strState;
                string strState2;

                if (!chk_Cond0.Checked && !chk_Cond8.Checked)
                {
                    return;
                }
                else
                {

                    if (chk_Cond0.Checked)
                    {

                        switch (Winsock1.State)
                        {
                            case 0:
                                strState = "连接关闭";
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            //                    Winsock1.Connect
                            case 1:
                                strState = "连接打开";
                                break;
                            case 2:
                                strState = "连接保留";
                                break;
                            case 3:
                                strState = "Close";
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            case 4:
                                strState = "Find Host....";
                                break;
                            case 5:
                                strState = "Finded Host";
                                break;
                            case 6:
                                strState = "正在连接";
                                break;
                            case 7:
                                strState = "连接正常";
                                tcpStatus.BackColor = Color.Green;
                                chk_Cond0.ForeColor = Color.Green;
                                break;
                            case 8:
                                strState = "连接断线";
                                //                    Winsock1.Close
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            case 9:
                                strState = "连接错误";
                                //                    Winsock1.Close
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            //        '            Winsock1.Connect
                            default:
                                strState = "StateNum:" + Winsock1.State;
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                        }

                        tcpMsg.Text = "标印机状态 : " + strState;

                    }


                    if (chk_Cond8.Checked)
                    {
                        switch (Winsock2.State)
                        {
                            case 0:
                                strState2 = "连接关闭";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond8.ForeColor = Color.Red;
                                break;
                            //            Winsock2.Close
                            //                    Winsock2.Connect
                            case 1:
                                strState2 = "连接打开";
                                break;
                            case 2:
                                strState2 = "连接保留";
                                break;
                            case 3:
                                strState2 = "Close";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond8.ForeColor = Color.Red;
                                break;
                            case 4:
                                strState2 = "Find Host....";
                                break;
                            case 5:
                                strState2 = "找到主机";
                                break;
                            case 6:
                                strState2 = "正在连接";
                                break;
                            case 7:
                                strState2 = "连接正常";
                                tcpStatus2.BackColor = Color.Green;
                                chk_Cond8.ForeColor = Color.Green;
                                break;
                            case 8:
                                strState2 = "连接断线";
                                //                    Winsock2.Close
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond8.ForeColor = Color.Red;
                                break;
                            case 9:
                                strState2 = "连接错误";
                                //                    Winsock2.Close
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond8.ForeColor = Color.Red;
                                break;
                            //        '            Winsock2.Connect
                            default:
                                strState2 = "StateNum:" + Winsock2.State;
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond8.ForeColor = Color.Red;
                                break;
                        }

                        tcpMsg2.Text = "侧喷机状态 : " + strState2;

                    }

                }

        }

        private void chk_Cond0_CheckedChanged(object sender, EventArgs e)
        {
            string strState;
            string strState2;

                if (chk_Cond0.Checked)
                {
                    Winsock1.Connect();
                }
                else
                {
                    Winsock1.Close();
                    strState = "连接断线";
                    tcpStatus.BackColor = Color.Red;
                    chk_Cond0.ForeColor = Color.Red;
                    tcpMsg.Text = "标印机状态 : " + strState;
                }
        }

        private void chk_Cond8_CheckedChanged(object sender, EventArgs e)
        {
            string strState;
            string strState2;

                if (chk_Cond8.Checked)
                {
                    Winsock2.Connect();
                }
                else
                {
                    Winsock2.Close();
                    strState2 = "连接断线";
                    tcpStatus2.BackColor = Color.Red;
                    chk_Cond8.ForeColor = Color.Red;
                    tcpMsg2.Text = "侧喷机状态 : " + strState2;
                }

        }


    }
}
