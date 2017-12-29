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
//-- Sub_System Name   统计分析管理
//-- Program Name      母板分段实绩查询_CGT2020C
//-- Program ID        CGT2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.22       韩超        母板分段实绩查询_CGT2020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2050C : CommonClass.FORMBASE
    {
        public CGT2050C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_PLATE_NO = 0;
        const int SS1_IMP_CONT = 60;

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");//1
            p_SetMc(SDT_PROD_DATE_FROM, "PN", "", "", "", imcseq, "");//2
            p_SetMc(SDT_PROD_DATE_TO, "PN", "", "", "", imcseq, "");//3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//4
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");//5
            p_SetMc(CBO_SURFGRD, "P", "", "", "", imcseq, "");//6
            p_SetMc(CBO_PRODGRD, "P", "", "", "", imcseq, "");//7
            p_SetMc(txt_stdspec_chg, "P", "", "", "", imcseq, "");//8
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, "");//9
            p_SetMc(SDB_WID, "P", "", "", "", imcseq, "");//10
            p_SetMc(SDB_THK_TO, "P", "", "", "", imcseq, "");//11
            p_SetMc(SDB_WID_TO, "P", "", "", "", imcseq, "");//12
            p_SetMc(cbo_prc_line, "P", "", "", "", imcseq, "");//13
            p_SetMc(SDB_LEN, "P", "", "", "", imcseq, "");//14
            p_SetMc(SDB_LEN_TO, "P", "", "", "", imcseq, "");//15
            p_SetMc(txt_trns_cmpy_cd, "P", "", "", "", imcseq, "");//16
            p_SetMc(txt_ord_item, "P", "", "", "", imcseq, "");//17
            p_SetMc(txt_ord_no, "P", "", "", "", imcseq, "");//18  

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("剪切线", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("进程状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("特殊工序", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("标准钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("厚度公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("钢板不平度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("测量长度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("钢板不平度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("测量长度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("不平度(/m)", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("不平度(/2m)", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("镰刀弯", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("切斜", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("表面", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("厚度1", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("厚度2", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("厚度3", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("厚度4", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("厚度5", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("厚度6", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("判定结果", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("上表面缺陷名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("下表面缺陷名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("改判缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("修磨", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("返剪", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("矫直", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("判定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("面积比", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//44
            p_SetSc("深度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("判定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("面积比", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("深度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//48
            p_SetSc("对角线1", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//49
            p_SetSc("对角线2", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("对角线差", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//51
            p_SetSc("检查时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("检查人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//53
            p_SetSc("检验工（头部）", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("检验工（尾部）", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//55
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//57
            p_SetSc("轧制班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//58
            p_SetSc("检验次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
            p_SetSc("钢板颜色", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//61
            p_SetSc("粗轧作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//62
            p_SetSc("精轧作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//63
            p_SetSc("下表是否检验", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//64
            p_SetSc("是否定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//65
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//66

            iheadrow = 0;

            p_spanSpread("订单规格", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("产品规格", 13, 16, iscseq, iheadrow, 1);
            p_spanSpread("检验实绩", 22, 29, iscseq, iheadrow, 1);
            p_spanSpread("缺陷名称", 37, 38, iscseq, iheadrow, 1);
            p_spanSpread("处置方式", 40, 42, iscseq, iheadrow, 1);
            p_spanSpread("上表面修磨", 43, 45, iscseq, iheadrow, 1);
            p_spanSpread("下表面修磨", 46, 48, iscseq, iheadrow, 1);

        }

        private void CGT2050C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2050NC";
            Form_Define();

            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

            ss1.ActiveSheet.FrozenColumnCount = 2;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;
        }

        public override void Form_Ref()
        {
            string SMESG;
            int iCount;
            int iCol;
            string sCurDate;
            string sDel_To_Date;

            int lRow;
            int iColor = 0;
            string iPlate_no = "";
            string simpcont;

            double sWgt;

            sCurDate = DateTime.Now.ToString("yyyyMM");

            if (convertX(SDT_PROD_DATE_FROM.RawDate) - convertX(SDT_PROD_DATE_TO.RawDate) > 0)
            {
                SMESG = " 时间范围输入错误，请重新输入时间信息 ！！！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "系统提示信息");
                return;
            }

            p_Ref(1, 1, true, true);

            //Add by LiQian at 2012.09.14 两次以上检验记录区分

                for (lRow = 1; lRow <= ss1.ActiveSheet.RowCount; lRow++)
                {

                    if (iPlate_no == "")
                    {
                        iColor = 1;
                    }
                    else
                    {
                        if (ss1.ActiveSheet.Cells[lRow - 1, SS1_PLATE_NO].Text != iPlate_no)
                        {
                            if (iColor == 1)
                            {
                                iColor = 2;
                            }
                            else
                            {
                                iColor = 1;
                            }
                        }
                    }

                    if (iColor == 1)
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, Color.White);
                        //白
                    }
                    else
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, Color.Gray);
                        //浅灰色
                    }

                    iPlate_no = ss1.ActiveSheet.Cells[lRow - 1, SS1_PLATE_NO].Text;

                    simpcont = ss1.ActiveSheet.Cells[lRow - 1, SS1_IMP_CONT].Text;
                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, lRow - 1, lRow-1, SSP4.BackColor, Color.White);
                        Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, lRow - 1, lRow-1, SSP4.BackColor, Color.White);
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
        public void unlockColumn(FpSpread e, int[] columns)
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



    }
}
