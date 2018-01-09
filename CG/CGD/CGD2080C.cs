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
//-- Program Name      标识（标印、标签）打印信息发送界面_CGD2080C
//-- Program ID        CGD2080C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.08   
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.08       韩超        标识（标印、标签）打印信息发送界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGD2080C : CommonClass.FORMBASE
    {
        public CGD2080C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        MSWinsockLib.WinsockClass Winsock1 = new MSWinsockLib.WinsockClass();
        MSWinsockLib.WinsockClass Winsock2 = new MSWinsockLib.WinsockClass();

        List<CheckBox> chk_Cond = new List<CheckBox>();

        const int SPD_LINE1 = 0;
        const int SPD_LINE2 = 1;
        const int SPD_PLATE_NO = 2;
        const int SPD_LOT_NO = 4;
        const int SPD_CUT_NO = 5;
        const int SPD_THK = 6;
        const int SPD_WID = 7;
        const int SPD_LEN = 8;
        const int SPD_WGT = 9;
        const int SPD_LAST_YN = 10;
        const int SPD_SIZE_KND = 11;
        const int SPD_TRIM_FL = 12;
        const int SPD_APLY_STDSPEC = 13;
        const int SPD_APLY_STDSPEC_NEW = 14;
        const int SPD_SURF_GRD = 15;
        const int SPD_MARK_YN = 16;
        const int SPD_STAMP_YN = 17;
        const int SPD_BAR_YN = 18;
        const int SPD_PROD_DATE = 19;
        const int SPD_EMP_CD = 20;
        const int SPD_PAINT = 21;
        const int SPD_LABEL = 22;
        const int SPD_LOTCD = 23;
        const int SPD_STDSPEC_YY = 24;
        const int SPD_STLGRD = 25;
        const int SPD_ORD_REMARK = 26;
        const int SPD_UST = 27;
        const int SPD_CUR_UST = 28;
        const int SPD_VESSEL_NO = 29;
        const int SPD_DEL_TO_DATE = 37;
        const int SPD_CUST_CD = 38;
        const int SPD_TO_CUR_INV = 39;
        const int SPD_CUST_CD_SHORT = 40;
        const int SPD_URGNT_FL = 41;
        const int SPD_IMP_CONT = 43;
        const int SPD_SIDE_MARK = 44;
        const int SPD_JIT_FLAG = 45;

        const int SS2_PRODSPECNOA_STD = 50;
        //多船级社标准一
        const int SS2_PRODSPECNOB_STD = 51;
        //多船级社标准二
        const int SS2_PRODSPECNOC_STD = 52;
        //多船级社标准三
        const int SS2_PRODSPECNOA = 53;
        //多船级社牌号一
        const int SS2_PRODSPECNOB = 54;
        //多船级社牌号二
        const int SS2_PRODSPECNOC = 55;
        //多船级社牌号三
        const int SS2_PRODSPECNOA1 = 56;
        //多船级社牌号一
        const int SS2_PRODSPECNOB1 = 57;
        //多船级社牌号二
        const int SS2_PRODSPECNOC1 = 58;
        //多船级社牌号三

        int PRODSPECNOA;
        //牌号一
        int PRODSPECNOB;
        //牌号二
        int PRODSPECNOC;
        //牌号三
        int PRODSPECNOA1;
        //牌号一
        int PRODSPECNOB1;
        //牌号二
        //牌号三
        int PRODSPECNOC1;

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
            p_SetMc(txt_plt, "PN", "", "", "", imcseq, "");//1
            //p_SetMc(txt_plt_name, "P", "", "", "", imcseq, "");//2
            p_SetMc(txt_plate_no, "P", "", "", "", imcseq, "");//3
            p_SetMc(udt_date_fr, "P", "", "", "", imcseq, "");//4
            p_SetMc(udt_date_to, "P", "", "", "", imcseq, "");//5
            p_SetMc(txt_line, "P", "", "", "", imcseq, "");//6
            p_SetMc(txt_stdspec, "P", "", "", "", imcseq, "");//7
            p_SetMc(txt_lot_no, "P", "", "", "", imcseq, "");//8
            p_SetMc(txt_rec_sts, "P", "", "", "", imcseq, "");//9
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//10

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("#1", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("#2", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("厚度", "N", "9,2", "I", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("宽度", "N", "9", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("长度", "N", "9", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("尾板", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("定尺", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切边", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("标准号", "E", "30", "IL", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("改判标准号", "E", "30", "I", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("合格", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("喷印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("冲印", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("侧喷", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("生产日期", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("作业人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("标印", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("标签", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("轧批", "C", "", "IL", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("打印标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("钢种", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//25
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("CUR_UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("加喷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("厚度下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("厚度上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("宽度下限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("宽度上限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("长度下限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("长度上限", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("交货期开始", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("交货期结束", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("客户代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("目的库", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("子公司代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("轧制班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("侧喷加喷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//44
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//47
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//48
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//49
            p_SetSc("多认证1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//50
            p_SetSc("多认证2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//51
            p_SetSc("多认证3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("牌号1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//53
            p_SetSc("牌号2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("牌号3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//55
            p_SetSc("牌号一", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("牌号二", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//57
            p_SetSc("牌号三", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("订单项次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
           

            //iheadrow = 0;
            //p_spanSpread("板坯规格", 10, 12, iscseq, iheadrow, 1);
            

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



        private void CGD2080C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2080NC";
            Form_Define();

            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_PAINT, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LABEL, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LOTCD, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);
            txt_plt.Text = "C3";

            txt_line.Text = "1";
            txt_rec_sts.Text = "1";
            
            opt_line1.Checked = true;
            opt_line3.Checked = true;

            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE1, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_LINE2, true);

            TXT_ORD_REMARK.Width = 598;
            TXT_ORD_REMARK.Height = 48;

            chk_Cond.Add(chk_Cond0);
            chk_Cond.Add(chk_Cond1);
            chk_Cond.Add(chk_Cond2);
            chk_Cond.Add(chk_Cond3); 
            chk_Cond.Add(chk_Cond4);
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

            if (txt_rec_sts.Text == "1")
            {
              //  p_Pro(1, 1, true, false);
            }

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "修改" || ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "增加" | ss1.ActiveSheet.RowHeader.Cells[iRow - 1, 0].Text == "删除")
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
                    if ((chk_Cond0.Checked || chk_Cond8.Checked) & ss1.ActiveSheet.RowHeader.Cells[iRow-1,0].Text!= "删除")
                    {
                        Cmd_SEND(iRow-1,sMark_no, sThk, sWid, sLen, sWgt, sSpec, sStdspec_YY, sPlate_no);
                    }
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            Form_Ref();

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
            txt_rec_sts.Text = "1";

            opt_line1.Checked = true;
            opt_line3.Checked = true;

            txt_stdspec_chg.Text = "";

            return true;

        }

        public override void Form_Ref()
        {
            int iCount;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            string sPlateNo;
            string sUrgnt_Fl;
            string simpcont;

            //    If Gf_Sp_ProceExist(sc1.Item("Spread")) Then Exit Sub

            sCurDate = DateTime.Now.ToString("yyyyMM");

            p_Ref(1, 1, true, true);

                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {
                    sPlateNo = ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text;
                    if (substr(ss1.ActiveSheet.Cells[iCount - 1, SPD_PLATE_NO].Text, 0, 12) == substr(sPlateNo, 0,12))
                    {
                    }
                    else
                    {
                        ss1.ActiveSheet.Cells[iCount - 2, SPD_LAST_YN].Text = "True";
                    }
                    sDel_To_Date = substr(ss1.ActiveSheet.Cells[iCount-1,SPD_DEL_TO_DATE].Text,0,6) ;
                    if (convertX(sDel_To_Date) < convertX(sCurDate))
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount-1, iCount-1, iCount-1, Color.Red,Color.White);
                    }
                    //紧急订单绿色显示 add by liqian 2012-08-16
                    sUrgnt_Fl = ss1.ActiveSheet.Cells[iCount - 1, SPD_URGNT_FL].Text.Trim();
                    if (sUrgnt_Fl == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount-1, iCount-1, iCount-1, Color.DarkGreen,Color.White);
                    }

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SPD_IMP_CONT].Text.Trim();
                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SPD_PLATE_NO, SPD_PLATE_NO, iCount-1, iCount-1, SSP4.BackColor,Color.White);
                        Gp_Sp_BlockColor(ss1, SPD_IMP_CONT, SPD_IMP_CONT, iCount-1, iCount-1, SSP4.BackColor,Color.White);
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

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            //  Dim sStdspec As String
            //  Dim sStdspec_YY As String

            if (ss1.ActiveSheet.RowCount <= 0) return;

            if (e.Column == SPD_APLY_STDSPEC_NEW)
            {
                if (ss1.ActiveSheet.Cells[e.Row, e.Column].Text == "")
                {
                    ss1.ActiveSheet.Cells[e.Row, e.Column].Text = txt_stdspec_chg.Text;
                    if (txt_stdspec_chg.Text != "")
                    {
                        //            sStdspec = txt_stdspec_chg
                        //            sStdspec_YY = "%"
                        ss1.ActiveSheet.Cells[e.Row, SPD_SURF_GRD].Text = "False";
                        //            ss1.Col = SPD_STDSPEC_YY:          ss1.Text = Gf_qp_std_headFind(M_CN1, sStdspec, sStdspec_YY, 1)
                        //            ss1.Col = SPD_STLGRD:              ss1.Text = Gf_qp_std_headFind(M_CN1, sStdspec, sStdspec_YY, 2)
                        ss1.ActiveSheet.Cells[e.Row, SPD_CUR_UST].Text = "X";
                    }
                }
                else
                {
                    //            sStdspec = ss1.Text
                    //            sStdspec_YY = "%"
                    ss1.ActiveSheet.Cells[e.Row, SPD_APLY_STDSPEC_NEW].Text = "";
                    ss1.ActiveSheet.Cells[e.Row, SPD_SURF_GRD].Text = "True";
                    //            ss1.Col = SPD_STDSPEC_YY:          ss1.Text = Gf_qp_std_headFind(M_CN1, sStdspec, sStdspec_YY, 1)
                    //            ss1.Col = SPD_STLGRD:              ss1.Text = Gf_qp_std_headFind(M_CN1, sStdspec, sStdspec_YY, 2)
                    ss1.ActiveSheet.Cells[e.Row, SPD_CUR_UST].Text = "";
                }
            }

            if (e.Column == SPD_PROD_DATE)
            {
                TXT_CUT_TIME.RawDate = Gf_DTSet("", "X");
                ss1.ActiveSheet.Cells[e.Row, SPD_PROD_DATE].Text = TXT_CUT_TIME.RawDate;
            }
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
            string sSpec_ALL;
            string sSpec1;
            string sSpec2;
            string sSpec_Str;
            string sStdspec_YY;
            int sNum;
            string sNumFL;
            string sUST;
            string sCUST_CD_SHORT;

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
            sSpec_ALL = ss1.ActiveSheet.Cells[ROW, SPD_APLY_STDSPEC_NEW].Text;
            sUST = ss1.ActiveSheet.Cells[ROW, SPD_UST].Text;
            TXT_CUST_CD.Text = ss1.ActiveSheet.Cells[ROW, SPD_CUST_CD].Text;
            TXT_TO_CUR_INV.Text = ss1.ActiveSheet.Cells[ROW, SPD_TO_CUR_INV].Text;
            sCUST_CD_SHORT = ss1.ActiveSheet.Cells[ROW, SPD_CUST_CD_SHORT].Text;
            if (sSpec_ALL == "")
            {
                sSpec_ALL = ss1.ActiveSheet.Cells[ROW, SPD_APLY_STDSPEC].Text;
            }

            if (sUST == "" | sUST == "X")
            {
                sUST = "";
            }
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

            sSpec_Str = substr(sSpec_ALL, 0, (sNum - 1));

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
            TXT_Paint4.Text = sUST + sNull + TXT_VESSEL_NO.Text;
            TXT_Paint4.Text = TXT_Paint4.Text.Trim();
            TXT_Paint4.Text = sCUST_CD_SHORT + "  " + TXT_Paint4.Text;
            TXT_Paint4.Text = TXT_Paint4.Text.Trim();

            TXT_Punch1.Text = sSpec2 + sNull + sPlate_no;
            TXT_Punch2.Text = sPlate_no;

            //TXT_Edge = sPlate_no & sNull & sThk & sFlag & sWid & sFlag & sLen & sNull & sSpec2 & sNull & TXT_VESSEL_NO & sNull & TXT_CUST_CD & TXT_TO_CUR_INV
            TXT_Edge.Text = sPlate_no + sNull + sSpec2 + sNull + sThk + sFlag + sWid + sFlag + sLen + sNull + TXT_VESSEL_NO.Text + sNull + TXT_CUST_CD.Text + TXT_TO_CUR_INV.Text;
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
            string sUser;//10个字符
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
            string sSpec_Logo;
            string sSpec_IRS_Logo = "";
            string sProd_Date;
            string sGroup;
            int sNum;
            string sNumFL;

            string PaintStr;
            short PaintStr_CD;
            string[] Paint = new string[4];//48个字符

            string PunchStr;
            string[] Punch = new string[2];//32个字符

            string EdgeStr;
            short EdgeStr_CD;
            string Edge;//48个字符
            string Bar;//18个字符
            string sNisco;

            string[] StrSend = new string[10];

            string sUST;

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

            sUST = "T";

            sMark_no = iMark_no;
            sPlate_no = iPlate_no;
            sThk = iThk;
            sWid = iWid;
            sLen = iLen;
            sWgt = iWGT;
            sSpec = iSpec;
            sSpec1 = iSpec;
            sSpec2 = iSpec;
            sStdspec_YY = iStdspec_yy;
            sUser = GeneralCommon.sUserID;

            Header = "MD";
            Nisco_Logo = Chr(127);
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

            sSpec_ALL = ss1.ActiveSheet.Cells[row,SPD_APLY_STDSPEC_NEW].Text;
            if (sSpec_ALL == "")
            {
                sSpec_ALL = ss1.ActiveSheet.Cells[row,SPD_APLY_STDSPEC].Text;
            }

            PRODSPECNOA = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOA].Text);
            PRODSPECNOB = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOB].Text);
            PRODSPECNOC = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOC].Text);
            PRODSPECNOA1 = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOA1].Text);
            PRODSPECNOB1 = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOB1].Text);
            PRODSPECNOC1 = convertI(ss1.ActiveSheet.Cells[row,SS2_PRODSPECNOC1].Text);

            sNum = sSpec_ALL.IndexOf("-");
            if (sNum == -1)
            {
                sNumFL = "Y";
                sNum = sSpec_ALL.Length;
            }
            sSpec_Str = substr(sSpec_ALL, 0, sNum);

            sSpec1 = sStdspec_YY + " " + PRODSPECNOA1 + " " + PRODSPECNOB1 + " " + PRODSPECNOC1;
            sSpec2 = sStdspec_YY + " " + PRODSPECNOA1 + " " + PRODSPECNOB1 + " " + PRODSPECNOC1;

            switch (sSpec_Str)
            {
                case "BV":
                    sSpec_Logo = Chr(44);
                    //ChrW(174)
                    break;
                case "CCS":
                    sSpec_Logo = Chr(33);
                    //ChrW(151)
                    break;
                case "DNV":
                    sSpec_Logo = Chr(39);
                    //ChrW(155)
                    break;
                case "VL":
                    sSpec_Logo = Chr(39);
                    //ChrW(155)
                    break;
                case "GL":
                    sSpec_Logo = Chr(39);
                    //ChrW(171) 36->39 20160127 LICHAO
                    break;
                case "KR":
                    sSpec_Logo = Chr(94);
                    //ChrW(176)
                    break;
                case "LR":
                    sSpec_Logo = Chr(96);
                    //ChrW(172)
                    break;
                case "NK":
                    sSpec_Logo = Chr(95);
                    //ChrW(224)
                    break;
                case "RINA":
                    sSpec_Logo = Chr(63);
                    //ChrW(166)
                    break;
                case "ABS":
                    sSpec_Logo = Chr(34);
                    //ChrW(225)    'CE 126
                    break;
                case "RS":
                    //俄罗斯船级社
                    sSpec_Logo = Chr(36);
                    //" "-> 36 20161118 LICHAO
                    break;
                case "IRS":
                    sSpec_Logo = " ";
                    sSpec_IRS_Logo = " ";
                    break;
                default:
                    sSpec_Logo = " ";
                    sSpec_IRS_Logo = " ";
                    sSpec1 = sSpec + " " + sStdspec_YY + " " + PRODSPECNOA1 + " " + PRODSPECNOB1 + " " + PRODSPECNOC1;
                    sSpec2 = sSpec + " " + PRODSPECNOA1 + " " + PRODSPECNOB1 + " " + PRODSPECNOC1;
                    break;
            }

            sSpec1 = sSpec1.Trim();
            sSpec2 = sSpec2.Trim();

            StrSend[0] = Chr(46);
            StrSend[1] = Chr(46);
            sNull = StrSend[0] + StrSend[1];
            sNullstr = " ";

            //2012-10-22  modify by liqian 标印第一行加 NISCO
            sNisco = sNullstr + "NISCO";

            //有重量标识要求的编辑重量信息
            if (iStdspec_yy == "GB 713-2008" | iStdspec_yy == "GB 3531-2008" | iStdspec_yy == "GB 19189-2011" | iStdspec_yy == "GB 713-2014" | iStdspec_yy == "GB 3531-2014")
            {
                sWgt = "  T.W. " + sWgt + " t";
            }
            else
            {
                sWgt = "";
            }

            //ss1.ROW = ss1.ActiveRow;
            //编辑探伤信息
            //如果钢板要求探伤，喷印第一行末尾加探伤内容
            sUST = ss1.ActiveSheet.Cells[row,SPD_CUR_UST].Text;
            if (sUST == "")
            {
                sUST = ss1.ActiveSheet.Cells[row,SPD_UST].Text;
            }

            //    Paint(0) = sNull & Nisco_Logo & sNullstr & sMark_no & sNisco & sWgt
            Paint[0] = sNull + Nisco_Logo + sNullstr + sMark_no + sWgt + " " + sUST;
            Paint[1] = sNull + Nisco_Logo + sSpec_Logo + PRODSPECNOA + PRODSPECNOB + PRODSPECNOC + sSpec1;
            Paint[2] = sNull + sNisco + "  " + sThk + sFlag + sWid + sFlag + sLen + sNullstr + sProd_Date + sNullstr + sGroup;

            //    ss1.ROW = ss1.ActiveRow
            //    '编辑探伤信息
            //    '如果钢板要求探伤，喷印第四行加喷 T
            //    ss1.Col = SPD_CUR_UST:    sUST = ss1.Text
            //    If sUST = "" Then
            //       ss1.Col = SPD_UST:    sUST = ss1.Text
            //    End If
            //
            //    If sUST = "" Or sUST = "X" Then
            //       sUST = ""
            //    Else
            //       sUST = "T"
            //    End If

            if (ss1.ActiveSheet.Cells[row,SPD_JIT_FLAG].Text == "Y")
            {
                sJIT_FLAG = "DZ";
                // 17-DZ
            }
            else
            {
                sJIT_FLAG = "";
            }

            sVESSEL_NO = ss1.ActiveSheet.Cells[row,SPD_VESSEL_NO].Text;
            sideMark = ss1.ActiveSheet.Cells[row,SPD_SIDE_MARK].Text;
            sCUST_CD = ss1.ActiveSheet.Cells[row,SPD_CUST_CD].Text;
            sTO_CUR_INV = ss1.ActiveSheet.Cells[row,SPD_TO_CUR_INV].Text;
            sCUST_CD_SHORT = ss1.ActiveSheet.Cells[row,SPD_CUST_CD_SHORT].Text;

            //编辑喷印第四行
            //如果钢板为子公司产品，喷印第四行首位喷子公司简码+（探伤标识）+（用户加喷信息）
            if (opt_line5.Checked)
            {
                //            Paint(3) = sCUST_CD_SHORT & "  " & sUST & " " & sVESSEL_NO
                Paint[3] = sCUST_CD_SHORT + " " + sVESSEL_NO;
            }
            else
            {
                //            Paint(3) = sPlate_no & " " & sCUST_CD_SHORT & "  " & sUST & " " & sVESSEL_NO
                Paint[3] = sPlate_no + " " + sCUST_CD_SHORT + " " + sVESSEL_NO;
            }

            if (sJIT_FLAG == "")
            {
                Paint[3] = sNull + "        " + Paint[3];
            }
            else
            {
                Paint[3] = sNull + "        " + sJIT_FLAG + "  " + Paint[3];
            }

            PaintStr = Paint[0] + Paint[1] + Paint[2] + Paint[3];

            StrSend[2] = Chr(30);
            StrSend[3] = Chr(30);
            sNull = StrSend[2] + StrSend[3];

            PaintStr_CD = convertS(TXT_P.Text);
            Punch[0] = sNull + sSpec_Logo + sSpec_IRS_Logo + sSpec2 + sNullstr + sMark_no;
            Punch[1] = sNull;
            //& sMark_no
            PunchStr = Punch[0] + Punch[1];

            StrSend[4] = Chr(46);
            StrSend[5] = Chr(46);
            sNull = StrSend[4] + StrSend[5];
            EdgeStr_CD = convertS(TXT_H.Text);
            Edge = sNull + sSpec2 + sNullstr + sMark_no + sThk + sFlag + sWid + sFlag + sLen;

            StrSend[6] = Chr(16);
            StrSend[7] = Chr(16);
            sNull = StrSend[6] + StrSend[7];
            Bar = sNull + sMark_no;
            EdgeStr = Bar + Edge;

            //编辑侧喷信息
            //钢板号 + 尺寸 + 钢种 + （用户加喷信息） + （客户代码）+（目的库）

            //编辑侧喷信息
            //钢板号 + 尺寸 + 钢种 + （用户加喷信息） + （客户代码）+（目的库）

            
                if (chk_Cond8.Checked && sEdge == 1)
                {

                    //            sEdgeStr = sMark_no & " " & sThk & "X" & sWid & "X" & sLen & " " & sSpec2 & "  " & TXT_Paint4.Text & " " & TXT_CUST_CD.Text & " " & TXT_TO_CUR_INV.Text
                    sEdgeString = sMark_no;
                    //sEdgeString = Trim(sEdgeString) & " " & Trim(sThk) & "X" & Trim(sWid) & "X" & Trim(sLen) & " " & Trim(sSpec2)
                    sEdgeString = sEdgeString.Trim() + " " + sSpec2.Trim() + " " + sThk.Trim() + "X" + sWid.Trim() + "X" + sLen.Trim();
                    sEdgeString = sEdgeString + " " + sideMark;
                    sEdgeString = sEdgeString.Trim() + " " + sCUST_CD + " " + sTO_CUR_INV;
                    sEdgeStr = sEdgeString.Trim();
                    Winsock2.SendData(sEdgeStr);
                }

                if (chk_Cond0.Checked)
                {
                                Winsock1.SendData(Header + "  " + Chr(16) + Chr(14) + sMark_no + Chr(10) + Chr(10) + sUser);
                                Winsock1.SendData(HiByte(convertS(sWid)));
                                Winsock1.SendData(LoByte(convertS(sWid)));
                                Winsock1.SendData(HiByte(sPaint));
                                Winsock1.SendData(LoByte(sPaint));
                                Winsock1.SendData(HiByte(sPunch));
                                Winsock1.SendData(LoByte(sPunch));
                                Winsock1.SendData(HiByte(sEdge));
                                Winsock1.SendData(LoByte(sEdge));
                            
                                Winsock1.SendData(PaintStr);
                                
                                Winsock1.SendData(HiByte(PaintStr_CD));
                                Winsock1.SendData(LoByte(PaintStr_CD));
                                Winsock1.SendData(PunchStr);
                                
                                Winsock1.SendData(HiByte(EdgeStr_CD));
                                Winsock1.SendData(LoByte(EdgeStr_CD));
                                Winsock1.SendData(EdgeStr);

                }

        }

        public static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
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

       




    }
}
