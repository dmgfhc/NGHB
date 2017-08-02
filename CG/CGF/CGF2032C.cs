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
//-- Program Name      轧辊磨削实绩查询(按时间)_CGF2032C
//-- Program ID        CGF2032C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.02
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.02       韩超        轧辊磨削实绩查询(按时间)_CGF2032C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2032C : CommonClass.FORMBASE
    {
        public CGF2032C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        string sQuery_load;

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("", SDT_GRIND_DATE_FROM, "P", "", "", "", "", imcseq);//0
            p_SetMc("", SDT_GRIND_DATE_TO, "P", "", "", "", "", imcseq);//1
            p_SetMc("", CBO_ROLL_ID, "P", "", "", "", "", imcseq);//2
            p_SetMc("", CBO_ROLL_TYPE, "P", "", "", "", "", imcseq);//3

            p_ScIni(ss1, Sc1, 0, false, true);
            int iscseq;
            int iheadrow;
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("轧辊号", "E", "7", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("磨削序列号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("磨削开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("磨削结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("磨削原因代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("辊型曲线", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("轧辊探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("磨前温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("轧辊硬度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("材质代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("供货商", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("制造商编号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("磨削次数", "N", "9", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("轧制公里数", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("轧制吨位", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("缺陷部位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("磨削前辊径", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("磨削后辊径", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("辊身磨削量（mm）", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //18
            p_SetSc("入库重量（kg）", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //19
            p_SetSc("消耗重量（kg）", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //20
            p_SetSc("入库价格(元)", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //21
            p_SetSc("消耗金额（元）", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //22
            p_SetSc("轧辊凸度", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R"); //23
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("作业人员1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("作业人员2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("作业人员3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("作业人员4", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //29

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGF2032NC";
            Form_Define();
            string sQuery_Rt = "SELECT ROLL_NO FROM GP_ROLL3 WHERE ROLL_STATUS<>'DL' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,2,1), SUBSTR(ROLL_NO,6,2) ";


            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery_Rt);

            CBO_ROLL_TYPE.Items.Add("2:工作辊");
            CBO_ROLL_TYPE.Items.Add("3:支撑辊");

        }



        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            if (ss1.ActiveSheet.RowCount <= 0) return;
            double TOT_GHT = 0;
            double TOT_WGT = 0;
            double TOT_RMB = 0;
            for (int i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {
                TOT_GHT = TOT_GHT + convertX(ss1.ActiveSheet.Cells[i - 1, 18].Text);
                TOT_WGT = TOT_WGT + convertX(ss1.ActiveSheet.Cells[i - 1, 20].Text);
                TOT_RMB = TOT_RMB + convertX(ss1.ActiveSheet.Cells[i - 1, 22].Text);
            }

            ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.RowCount, 1);
            ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.RowCount - 1, 0].Text = "合计";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 18].Text = TOT_GHT.ToString();
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 20].Text = TOT_WGT.ToString();
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, 22].Text = TOT_RMB.ToString();

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
