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

        string strState;
        string strState2;

        public byte LoByte(short Word)
        {
            return (byte)(Word & 0xff);
        }

        public byte HiByte(short Word)
        {
            return (byte)(Word >> 8);
        }

        public byte HLByte(int Word,int num)
        {
            if (num == 0)
            {
                return (byte)(Word & 0xff);
            }
            if (num == 1)
            {
                return (byte)((Word >> 8) & 0xff);
            }
            if (num == 2)
            {
                return (byte)((Word >> 16) & 0xff);
            }
            if (num == 3)
            {
                return (byte)((Word >> 24) & 0xff);
            }
            
            return 0;
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
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("厚度", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("分段号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("日期", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("班次", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//12
            

            

            //iheadrow = 0;
            //p_spanSpread("板坯规格", 10, 12, iscseq, iheadrow, 1);
            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("板坯号", "E", "14", "I", "", "", "", iscseq, iheadrow, "L");//0
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
            p_SetSc("喷印号", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("加喷信息", "E", "30", "", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("客户代码", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("用户交货期", "E", "", "", "", "", "", iscseq, iheadrow, "M");//18
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

        private void CGC2021C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGC2021NC";
            Form_Define();

            Winsock1.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "03", 1);
            Winsock1.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0034", "03", 2));
            Winsock2.RemoteHost = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0047", "01", 1);
            Winsock2.RemotePort = convertI(GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "G0047", "01", 2));

            TXT_RL.Text = "1";
            TXT_COM.Text = "5";
            TXT_TOP.Text = "1";
            //LiQian 2012-08-23 底部选择默认不选,界面上TXT_BOT默认也设为0和不选择
            TXT_BOT.Text = "0";
        }

        public override void Form_Pro()
        {
            int iRow;

            string sMark_no;
            string sPlate_no;
            string sThk;
            string sWid;
            string sLen;
            string sSpec;
            string sStdspec_YY;

            if (TXT_SLAB_NO.Text.Trim() == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay(" 板坯号为空，请确认 ", "I", "");
                return;
            }

            if (convertX(TXT_THK.Text) < 5 || convertX(TXT_THK.Text) > 150 || convertX(TXT_WID.Text) < 1500 || convertX(TXT_WID.Text) > 2650 || convertX(TXT_LEN.Text) < 1700 || convertX(TXT_LEN.Text) > 50000)
            {
                GeneralCommon.Gp_MsgBoxDisplay(" 轧件规格超出热喷设备工作范围，请确认 ", "I", "");
                return;
            }

            if (convertX(TXT_ROLL_TEMP.Text) < 250 | convertX(TXT_ROLL_TEMP.Text) > 1000)
            {
                GeneralCommon.Gp_MsgBoxDisplay(" 轧件温度超出热喷设备工作范围，请确认 ", "I", "");
                return;
            }

            if (convertX(TXT_PAINT_CNT.Text) < 1 | convertX(TXT_PAINT_CNT.Text) > 10)
            {
                GeneralCommon.Gp_MsgBoxDisplay(" 喷印数量超出热喷设备工作范围，请确认 ", "I", "");
                return;
            }

            if (convertX(TXT_PAINT_POS.Text) < 1700 | convertX(TXT_PAINT_POS.Text) > 49300)
            {
                GeneralCommon.Gp_MsgBoxDisplay(" 喷印开始位置超出热喷设备工作范围，请确认 ", "I", "");
                return;
            }

            if (chk_Cond0.Checked)
            {
                Cmd_SEND();

                p_Pro(1, 2, true, true);

            }

            if (chk_Cond3.Checked)
            {
                Cmd_SEND_Surf();
            }

            Form_Ref();

            //以下代码用于清空SS2
            ((FpSpread)Sc2["Spread"]).ActiveSheet.AutoSortColumn(0);
            //使用AutoSortColumn方法对显示区域进行排序操作。
            ((FpSpread)Sc2["Spread"]).ActiveSheet.RowCount = 0;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            int iCount;
            string sPlateNo;

            int inum;
            int lRow;
            int iRow;
            int iCol;
            string simpcont;
            string sFlag;
            string sexport;

            p_Ref(1, 1, true, true);

            if (ss2.ActiveSheet.RowCount <= 0) return;

                for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++)
                {
                    simpcont = ss2.ActiveSheet.Cells[iRow - 1, SS2_IMP_CONT].Text.Trim();

                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount-1, iRow-1, iRow-1, SSP4.BackColor,Color.White);
                    }

                    //是否定制配送
                    sFlag = ss2.ActiveSheet.Cells[iRow - 1, SS2_JIT_FLAG].Text.Trim();
                    if (sFlag == "Y")
                    {
                        Gp_Sp_BlockColor(ss2, SS2_FLAB_NO, SS2_FLAB_NO, iRow, iRow, SSP5.BackColor,Color.White);
                    }
                    //是否出口订单
                    sexport = ss2.ActiveSheet.Cells[iRow - 1, SS2_ERPORT].Text.Trim();
                    if (sexport == "Y")
                    {
                        Gp_Sp_BlockColor(ss2, SS2_FLAB_NO, SS2_FLAB_NO, iRow, iRow, SSP6.BackColor,Color.White);
                    }
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
            try
            {
                if (value != "")
                {
                    return Convert.ToDouble(value);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public int convertI(string value)
        {
            try
            {
                if (value != "")
                {
                    return Convert.ToInt32(value);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public short convertS(string value)
        {
            try
            {
                if (value != "")
                {
                    return Convert.ToInt16(value);
                }
                return 0;
            }
            catch
            {
                return 0;
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


        #endregion

        private void ss1_ButtonClicked(object sender, EditorNotifyEventArgs e)
        {
            lBlkcol1 = 0;
            lBlkcol2 = 0;
            lBlkrow1 = 0;
            lBlkrow2 = 0;

            int lRow;
            string sBlockSeq;
            string sSeq;

            int iCol;
            int iRow;
            int iRowNum;
            int iRowfr;
            int iRowto;

            int iPaint_cnt;
            int iPaint_Len;
            string sDate;
            string sShift;
            string sCut_no;

            string sCurDate;
            string sOrderNo;
            string sDel_To_Date;

            string sAdd_W = "";
            string sAdd_S = "";
            string sAdd_T = "";
            string sAdd_H = "";
            string sAdd_B = "";
            string sAdd_D = "";
            //定制配送订单，末尾加字母D  add by lichao 20140709
            string sAdd_E;
            //一批多订单，末尾加字母P  add by lichao 20150317
            string sAdd_F;
            //异常坯，末尾加字母X  add by lichao 20150317
            string sAdd_G;
            //是否切边加M
            string iPaint_Add;

            string sSthk;
            string sSord;

            string sXm;
            string sClasscd;
            string sClasslvl;

            string sEXCEPTION;
            string sEXCEPTIONFH;

            sCurDate = DateTime.Now.ToString("yyyyMM");

            iCol = e.Column;
            iRow = e.Row;

            if (ss1.ActiveSheet.RowCount <= 0) return;
            if (e.Column > 0) return;

            iRowto = iRow - 1;
            iRowfr = iRow + 1;

            if (iRowto > 0)
            {
                for (iRowNum = 0; iRowNum <= iRowto; iRowNum++)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text != "")
                    {
                        ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                        ss1.ActiveSheet.Cells[iRowNum, SS1_LINE1].Text = "False";
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

            if (iRowfr <= ss1.ActiveSheet.RowCount - 1)
            {
                for (iRowNum = iRowfr; iRowNum <= ss1.ActiveSheet.RowCount - 1; iRowNum++)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text != "")
                    {
                        ss1.ActiveSheet.RowHeader.Cells[iRowNum, 0].Text = "";
                        ss1.ActiveSheet.Cells[iRowNum, SS1_LINE1].Text = "False";
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

            if (e.Column == SS1_LINE1 && ss1.ActiveSheet.Cells[iRow, SS1_LINE1].Text == "True")
            {
                ss1.ActiveSheet.RowHeader.Cells[iRow, 0].Text = "修改";
            }
            else
            {
                ss1.ActiveSheet.RowHeader.Cells[iRow, 0].Text = "";
            }

            TXT_SLAB_NO.Text = ss1.ActiveSheet.Cells[iRow, SS1_SLAB_NO].Text;
            TXT_CUT_NO.Text = ss1.ActiveSheet.Cells[iRow, SS1_CUT_NO].Text;
            sCut_no = TXT_CUT_NO.Text.Replace("-", " ");
            sDate = ss1.ActiveSheet.Cells[iRow, SS1_DATE].Text;
            sShift = ss1.ActiveSheet.Cells[iRow, SS1_SHIFT].Text;
            TXT_THK.Text = ss1.ActiveSheet.Cells[iRow, SS1_ROLL_THK].Text.Replace(",","");
            TXT_WID.Text = ss1.ActiveSheet.Cells[iRow, SS1_ROLL_WID].Text.Replace(",", "");
            TXT_LEN.Text = ss1.ActiveSheet.Cells[iRow, SS1_ROLL_LEN].Text.Replace(",", "");
            TXT_WGT.Text = ss1.ActiveSheet.Cells[iRow, SS1_ROLL_WGT].Text.Replace(",", "");
            TXT_STLGRD.Text = ss1.ActiveSheet.Cells[iRow, SS1_STLGRD].Text;

            //Gp_Sp_BlockColor(ss1, 1, ss1.MaxCols, 1, ss1.MaxRows);
            Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, SSP1.BackColor);

            if (ss1.ActiveSheet.Cells[iRow, SS1_LINE1].Text == "True" & e.Column == SS1_LINE1)
            {
                p_Ref(1, 2, true, true);
            }

            //TXT_SLAB_NO.Text = ""
            iPaint_cnt = 0;
            iPaint_Len = 0;

            for (lRow = 1; lRow <= ss2.ActiveSheet.RowCount; lRow++)
            {
                sBlockSeq = ss2.ActiveSheet.Cells[lRow - 1, SS2_BLOCK_SEQ].Text;
                sSeq = ss2.ActiveSheet.Cells[lRow - 1, SS2_SEQ].Text;

                if (sBlockSeq + sSeq == "0000")
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP1.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "轧件";
                }
                else if (sSeq == "00")
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP2.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "母板" + sBlockSeq;
                }
                else
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP3.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "钢板";
                    ss2.ActiveSheet.RowHeader.Cells[lRow - 1, 0].Text = "修改";

                    iPaint_cnt = iPaint_cnt + 1;
                    if (iPaint_cnt == 1)
                    {
                        TXT_PAINT_POS.Text = (Math.Round(convertX(ss2.ActiveSheet.Cells[lRow - 1, SS2_LEN].Text.Replace(",", "")) / 3)).ToString();
                        if (convertX(TXT_PAINT_POS.Text) < 1700)
                        {
                            TXT_PAINT_POS.Text = "1700";
                        }
                    }

                    ss2.ActiveSheet.Cells[lRow - 1, SS2_POS].Text = TXT_PAINT_POS.Text + iPaint_Len + TXT_PAINT_POS_EDIT.Text;
                    iPaint_Len = iPaint_Len + convertI(ss2.ActiveSheet.Cells[lRow - 1, SS2_LEN].Text.Replace(",", ""));

                    //订单厚度≥24mm当月以前订单加喷S，探伤加喷T，热处理加喷N （正火）或Q（淬火） （以下简称特殊热喷）
                    //订单厚度＜24mm只加喷当月以前订单S，探伤、热处理不喷
                    //所需特殊热喷位置：第9-11位，顺序分别为S T N或Q ；如（21B002-1STN或Q）
                    //若没有特殊热喷指示则第9-11位分别不喷

                    //20110514 修改
                    //订单号OB5/OM8开头加喷W,当月以前订单加喷S，探伤加喷T，热处理加喷N （正火）或Q（淬火） （以下简称特殊热喷）

                    //20110519 修改
                    //订单号OB5/OM8开头加喷W,当月以前订单加喷S，探伤加喷T，热处理加喷N （正火）或Q（淬火） （以下简称特殊热喷）
                    //例如：（21B002-1WSTN或Q）
                    sOrderNo = substr(ss2.ActiveSheet.Cells[lRow - 1, SS2_ORD_NO].Text, 0, 3);
                    if (sOrderNo == "OB5" | sOrderNo == "OM8")
                    {
                        sAdd_W = "C";
                    }

                    sDel_To_Date = substr(ss2.ActiveSheet.Cells[lRow - 1, SS2_DEL_TO_DATE].Text, 0, 6);
                    if (convertX(sDel_To_Date) < convertX(sCurDate))
                    {
                        sAdd_S = "S";
                    }

                    if (ss2.ActiveSheet.Cells[lRow - 1, SS2_UST_FL].Text == "探伤")
                    {
                        sAdd_T = "T";
                    }
                    // Add by liqian at 2012-07-30 紧急订单
                    if (ss2.ActiveSheet.Cells[lRow - 1, SS2_URGNT_FL].Text == "Y")
                    {
                        sAdd_B = "B";
                    }
                    else
                    {
                        sAdd_B = "";
                    }
                    // Add by lichao at 2014-07-09 定制配送订单
                    if (ss2.ActiveSheet.Cells[lRow - 1, SS2_JIT_FLAG].Text == "Y")
                    {
                        sAdd_D = "D";
                    }
                    else
                    {
                        sAdd_D = "";
                    }

                    // Add by lichao at 2015-03-17 订单数量
                    sSord = ss2.ActiveSheet.Cells[lRow - 1, SS2_ORD_CNT].Text;
                    sSthk = ss2.ActiveSheet.Cells[lRow - 1, SS2_THK].Text.Trim().Replace(",", "");
                    if (convertX(sSord) > 1 & convertX(sSthk) < 25)
                    {
                        sAdd_E = "P";
                    }
                    else
                    {
                        sAdd_E = "";
                    }

                    // Add by lichao at 2015-03-17 异常坯
                    if (ss2.ActiveSheet.Cells[lRow - 1, SS2_OVER_FL].Text != "" && ss2.ActiveSheet.Cells[lRow - 1, SS2_OVER_FL].Text != "0")
                    {
                        sAdd_F = "X";
                    }
                    else
                    {
                        sAdd_F = "";
                    }

                    //ss2.Col = SS2_JIT_FLAG:      sAdd_D = ss2.Text
                    if (ss2.ActiveSheet.Cells[lRow - 1, SS2_HTM].Text != "")
                    {
                        sAdd_H = "N";
                    }
                    else
                    {
                        sAdd_H = "";
                    }

                    sXm = ss2.ActiveSheet.Cells[lRow - 1, SS2_SURFACE_REQUESTS].Text;
                    sClasscd = ss2.ActiveSheet.Cells[lRow - 1, SS2_CLASS_CD].Text;
                    sClasslvl = ss2.ActiveSheet.Cells[lRow - 1, SS2_CLASS_LVL].Text;
                    sAdd_G = ss2.ActiveSheet.Cells[lRow - 1, SS2_TRIM_FL].Text;

                    //            ss2.Col = SS2_PAINT_ADD:     ss2.Text = sAdd_W & sAdd_S & sAdd_T & sAdd_H & sAdd_B & sAdd_D & sAdd_F & sAdd_G & sAdd_E & sXm

                    if (sXm != "" & sClasscd != "")
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text = sAdd_W + sAdd_S + sAdd_T + sAdd_H + sAdd_B + sAdd_D + sAdd_F + sAdd_G + sAdd_E + sClasslvl;
                    }
                    else if (sXm == "" & sClasscd != "")
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text = sAdd_W + sAdd_S + sAdd_T + sAdd_H + sAdd_B + sAdd_D + sAdd_F + sAdd_G + sAdd_E + sClasslvl;
                    }
                    else if (sXm != "" & sClasscd == "")
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text = sAdd_W + sAdd_S + sAdd_T + sAdd_H + sAdd_B + sAdd_D + sAdd_F + sAdd_G + sAdd_E + sXm;
                    }
                    else
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text = sAdd_W + sAdd_S + sAdd_T + sAdd_H + sAdd_B + sAdd_D + sAdd_F + sAdd_G + sAdd_E;
                    }

                    sEXCEPTION = ss2.ActiveSheet.Cells[lRow - 1, SS2_MILL_EXCEPTION].Text;
                    sEXCEPTIONFH = ss2.ActiveSheet.Cells[lRow - 1, SS2_MILL_EXCEPTION_FH].Text;

                    if (sEXCEPTION == "B" | sEXCEPTION == "C" | sEXCEPTIONFH == "B" | sEXCEPTIONFH == "C")
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text = ss2.Text + "Y";
                    }

                    iPaint_Add = ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_ADD].Text;

                    if (opt_cut_no.Checked)
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_NO].Text = sDate + sShift + sCut_no + "-" + iPaint_cnt + iPaint_Add;
                    }
                    else
                    {
                        ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_NO].Text = TXT_SLAB_NO.Text + "-" + iPaint_cnt + iPaint_Add;
                    }
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_NO].Text = ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_NO].Text.Trim();

                }

            }

            TXT_PAINT_CNT.Text = iPaint_cnt.ToString();
        }

        private void Cmd_SEND()
        {
            string SMESG;

            string Header;//2
            string sPlate_no;//18
            int iThk;
            int iWid;
            int iLen;
            short iTemp;
            short iRL;
            short iCOM;
            short iPaint_cnt;
            short iTop;
            short iBot;

            string sSeq;
            int[] sPaint_Pos = new int[10];
            string[] sPaint_Str = new string[10];//16
            string[] StrSend = new string[2];
            string sCtrl;//2

            int lRow;

            Header = "MD";
            Header = Header.PadRight(2, ' ');
            sPlate_no = TXT_SLAB_NO.Text.Trim();
            sPlate_no = sPlate_no.PadRight(18, ' ');
            iThk = convertI(TXT_THK.Text);
            iWid = convertI(TXT_WID.Text);
            iLen = convertI(TXT_LEN.Text);
            iTemp = convertS(TXT_ROLL_TEMP.Text);
            iRL = convertS(TXT_RL.Text);
            iCOM = convertS(TXT_COM.Text);
            iPaint_cnt = convertS(TXT_PAINT_CNT.Text);
            iTop = convertS(TXT_TOP.Text);
            iBot = convertS(TXT_BOT.Text);

            StrSend[0] = Chr(16);
            StrSend[1] = Chr(16);
            sCtrl = StrSend[0] + StrSend[1];
            sCtrl = sCtrl.PadRight(2, ' ');

            iPaint_cnt = 0;
            for (lRow = 1; lRow <= ss2.ActiveSheet.RowCount; lRow++)
            {

                sSeq = ss2.ActiveSheet.Cells[lRow - 1, SS2_SEQ].Text;
                if (sSeq != "00")
                {
                    sPaint_Pos[iPaint_cnt] = convertI(ss2.ActiveSheet.Cells[lRow - 1, SS2_POS].Text);
                    sPaint_Str[iPaint_cnt] = ss2.ActiveSheet.Cells[lRow - 1, SS2_PAINT_NO].Text;
                    sPaint_Str[iPaint_cnt] = sPaint_Str[iPaint_cnt].PadRight(16, ' ');
                    iPaint_cnt =  (short)(iPaint_cnt + 1);
                }
            }

            Winsock1.SendData(Header + "  ");
            Winsock1.SendData(Chr(18) + Chr(10) + sPlate_no);
            Winsock1.SendData(HLByte(iLen, 3));
            Winsock1.SendData(HLByte(iLen, 2));
            Winsock1.SendData(HLByte(iLen, 1));
            Winsock1.SendData(HLByte(iLen, 0));
            Winsock1.SendData(HLByte(iWid, 3));
            Winsock1.SendData(HLByte(iWid, 2));
            Winsock1.SendData(HLByte(iWid, 1));
            Winsock1.SendData(HLByte(iWid, 0));
            Winsock1.SendData(HLByte(iThk, 3));
            Winsock1.SendData(HLByte(iThk, 2));
            Winsock1.SendData(HLByte(iThk, 1));
            Winsock1.SendData(HLByte(iThk, 0));
            Winsock1.SendData(HiByte(iTemp));
            Winsock1.SendData(LoByte(iTemp));
            Winsock1.SendData(HiByte(iRL));
            Winsock1.SendData(LoByte(iRL));
            Winsock1.SendData(HiByte(iCOM));
            Winsock1.SendData(LoByte(iCOM));
            Winsock1.SendData(HiByte(iPaint_cnt));
            Winsock1.SendData(LoByte(iPaint_cnt));
            Winsock1.SendData(HiByte(iTop));
            Winsock1.SendData(LoByte(iTop));
            Winsock1.SendData(HiByte(iBot));
            Winsock1.SendData(LoByte(iBot));



            for (lRow = 1; lRow <= 10; lRow++)
            {
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 3));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 2));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 1));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 0));
                Winsock1.SendData(sCtrl + sPaint_Str[lRow - 1]);
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 3));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 2));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 1));
                Winsock1.SendData(HLByte(sPaint_Pos[lRow - 1], 0));
                Winsock1.SendData(sCtrl + sPaint_Str[lRow - 1]);

            }

        }

        private void Cmd_SEND_Surf()
        {
            string SMESG;

            string Header;
            //* 12
            string sPlate_no;
            //* 20
            string sWgt;
            //* 5
            string sWid;
            //* 5
            string sThk;
            //* 5
            string sLen;
            //* 10
            string sStlgrd;
            //* 30

            int iWid;
            int iLen;
            int iThk;
            int iWGT;

            iWGT = (int)(convertX(TXT_WGT.Text) * 1000);
            iWid = (int)(convertX(TXT_WID.Text));
            iThk = (int)(convertX(TXT_THK.Text) * 1000);
            iLen = (int)(convertX(TXT_LEN.Text));

            Header = "GPDIMCD 0077";
            Header = Header.PadRight(12, ' ');
            sPlate_no = TXT_SLAB_NO.Text.Trim();
            sPlate_no = sPlate_no.PadRight(20, ' ');

            sWgt = iWGT.ToString();
            sWid = iWid.ToString();
            sThk = iThk.ToString();
            sLen = iLen.ToString();

            sWgt = sWgt.PadLeft(5, '0');
            sWid = sWid.PadLeft(5, '0');
            sThk = sThk.PadLeft(5, '0');
            sLen = sLen.PadLeft(10, '0');

            sStlgrd = TXT_STLGRD.Text;
            sStlgrd = sStlgrd.PadRight(30, ' ');

            Winsock2.SendData(Header + sPlate_no + sWgt + sWid + sThk + sLen + sStlgrd);

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
                //if (strCharacter == "\r" || strCharacter == "\t" || strCharacter == "\n")
                //{
                //    strCharacter = "";
                //}

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

                if (!chk_Cond0.Checked & !chk_Cond3.Checked)
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
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            case 9:
                                strState = "连接错误";
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                            default:
                                strState = "StateNum:" + Winsock1.State;
                                tcpStatus.BackColor = Color.Red;
                                chk_Cond0.ForeColor = Color.Red;
                                break;
                        }

                        tcpMsg.Text = "热喷状态 : " + strState;

                    }


                    if (chk_Cond3.Checked)
                    {
                        switch (Winsock2.State)
                        {
                            case 0:
                                strState2 = "连接关闭";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond3.ForeColor = Color.Red;
                                break;
                            case 1:
                                strState2 = "连接打开";
                                break;
                            case 2:
                                strState2 = "连接保留";
                                break;
                            case 3:
                                strState2 = "Close";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond3.ForeColor = Color.Red;
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
                                chk_Cond3.ForeColor = Color.Green;
                                break;
                            case 8:
                                strState2 = "连接断线";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond3.ForeColor = Color.Red;
                                break;
                            case 9:
                                strState2 = "连接错误";
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond3.ForeColor = Color.Red;
                                break;
                            default:
                                strState2 = "StateNum:" + Winsock2.State;
                                tcpStatus2.BackColor = Color.Red;
                                chk_Cond3.ForeColor = Color.Red;
                                break;
                        }

                        tcpMsg2.Text = "表面检测状态 : " + strState2;

                    }

                }
        }

        private void chk_Cond0_CheckedChanged(object sender, EventArgs e)
        {
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
                tcpMsg.Text = "热喷状态 : " + strState;
            }

        }

        private void chk_Cond3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cond3.Checked)
            {
                Winsock2.Connect();
            }
            else
            {
                Winsock2.Close();
                strState2 = "连接断线";
                tcpStatus2.BackColor = Color.Red;
                chk_Cond3.ForeColor = Color.Red;
                tcpMsg2.Text = "表面检测状态 : " + strState2;
            }
        }

        private void chk_Cond1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cond1.Checked)
            {
                TXT_TOP.Text = "1";
            }
            else
            {
                TXT_TOP.Text = "0";
            }
        }

        private void chk_Cond2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Cond2.Checked)
            {
                TXT_BOT.Text = "1";
            }
            else
            {
                TXT_BOT.Text = "0";
            }
        }

        private void opt_cut_no_Click(object sender, EventArgs e)
        {
            Form_Ref();
        }

        private void opt_line1_Click(object sender, EventArgs e)
        {
            if (opt_line1.Checked)
            {
                TXT_RL.Text = "1";
            }
        }

        private void opt_line10_Click(object sender, EventArgs e)
        {
            if (opt_line10.Checked)
            {
                TXT_COM.Text = "5";
            }
        }

        private void opt_line2_Click(object sender, EventArgs e)
        {
            if (opt_line2.Checked)
            {
                TXT_RL.Text = "2";
            }
        }

        private void opt_line3_Click(object sender, EventArgs e)
        {
            if (opt_line3.Checked)
            {
                TXT_COM.Text = "2";
            }
        }

        private void opt_line4_Click(object sender, EventArgs e)
        {
            if (opt_line4.Checked)
            {
                TXT_COM.Text = "3";
            }
        }

        private void opt_line5_Click(object sender, EventArgs e)
        {
            if (opt_line5.Checked)
            {
                TXT_COM.Text = "4";
            }
        }

        private void opt_line6_Click(object sender, EventArgs e)
        {
            if (opt_line6.Checked)
            {
                TXT_COM.Text = "6";
            }
        }

        private void opt_line7_Click(object sender, EventArgs e)
        {
            if (opt_line7.Checked)
            {
                TXT_COM.Text = "7";
            }
        }

        private void opt_line8_Click(object sender, EventArgs e)
        {
            if (opt_line8.Checked)
            {
                TXT_COM.Text = "8";
            }
        }

        private void opt_line9_Click(object sender, EventArgs e)
        {
            if (opt_line9.Checked)
            {
                TXT_COM.Text = "9";
            }
        }

        private void opt_slab_no_Click(object sender, EventArgs e)
        {
            Form_Ref();
        }

    }
}
