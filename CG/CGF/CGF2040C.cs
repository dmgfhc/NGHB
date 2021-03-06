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
//-- Program Name      轧辊/轴承座和轴承的库存管理界面_CGF2040C
//-- Program ID        CGF2040C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.02
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.15       韩超        轧辊/轴承座和轴承的库存管理界面_CGF2040C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2040C : CommonClass.FORMBASE
    {
        public CGF2040C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        string sQuery_load;

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("", CBO_ROLL_ID, "P", "", "", "", "", imcseq);//0
            p_SetMc("", CBO_PLT, "P", "", "", "", "", imcseq);//1
            p_SetMc("", txt_roll_sts, "P", "", "", "", "", imcseq);//2
            p_SetMc("", TXT_ROLL_MAKER, "P", "", "", "", "", imcseq);//3

            int iscseq;
            int iheadrow;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("轧辊号", "E", "7", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("入库辊径", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("当前直径", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("限位辊径", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("轧辊单价(元)", "N", "10", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("剩余金额(元)", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("入库辊重(Kg)", "N", "10", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("剩余辊重(Kg)", "N", "10", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("平均硬度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("轧辊材质", "E", "4", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("制造编号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("供货商", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("轧辊状态", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("入库时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("报废时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("使用次数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //15
            p_SetSc("轧制重量", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //16
            p_SetSc("毫米轧制量", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //17
            p_SetSc("轧制公里", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //18
            p_SetSc("磨辊次数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //19
           

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("轴承座号", "E", "7", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("内径", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("外径", "N", "4", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("材质", "E", "2", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("状态", "E", "2", "L", "", "", "", iscseq, iheadrow, "L"); //4
            p_SetSc("入库时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("报废时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("报废原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("供货商", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //8

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 0;
            iscseq = 3;

            p_SetSc("轴承座号", "E", "7", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("内径", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("外径", "N", "4", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("宽度", "E", "2", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("状态", "E", "2", "L", "", "", "", iscseq, iheadrow, "L"); //4
            p_SetSc("入库时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("报废时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("报废原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("供货商", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //8

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2040NC";
            Form_Define();
            string sQuery_Rt = "SELECT ROLL_NO FROM GP_ROLL3 ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,2,1),SUBSTR(ROLL_NO,6,2)";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_Rt);


        }



        public override void Form_Ref()
        {
            string SMESG = "";
            if (substr(CBO_ROLL_ID.Text, 0, 1) == "J" || substr(CBO_ROLL_ID.Text, 1, 1) == "C")
            {
                p_Ref(1, 1, true, true);
            }
            else if (substr(CBO_ROLL_ID.Text, 0, 1) == "B")
            {
                p_Ref(1, 3, true, true);
            }
            else if (substr(CBO_ROLL_ID.Text, 0, 1) == "C")
            {
                p_Ref(1, 2, true, true);
            }
            else
            {
                SMESG = SMESG + " 必须输入 'R' or 'B' or 'C' ";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "提示");

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
