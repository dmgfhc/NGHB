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
//-- Program Name      加热炉实绩查询界面
//-- Program ID        CGT2000C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.11.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.11.01       韩超        中板轧钢作业
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2001C_POP : CommonClass.FORMBASE
    {
        public CGT2001C_POP()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_date1, "P", "", "", "", imcseq, "");
            p_SetMc(txt_date2, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len, "P", "", "", "", imcseq, "");
            p_SetMc(txt_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(txt_spec, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cool1, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cool2, "P", "", "", "", imcseq, "");

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc(txt_date1, "P", "", "", "", imcseq, "");
            p_SetMc(txt_date2, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len, "P", "", "", "", imcseq, "");
            p_SetMc(txt_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(txt_spec, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cool1, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cool2, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("生产工厂", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢种代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("钢种名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("入中板时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("入炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("堆冷时间（小时）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("订单材/余材", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("当前订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当前订单厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14

            p_ScIni(ss1, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("生产工厂", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢种代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("钢种名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("入中板时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("入炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("堆冷时间（小时）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("订单材/余材", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("当前订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当前订单厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14

            //iheadrow = 0;
            
        }

        private void CGT2001C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2001NC";
            Form_Define();
        }

        //public override void Form_Pro()
        //{
        //    p_pro(1, 1, false, true);
        //}

        //public override bool Form_Cls()
        //{
        //    base.Form_Cls();

        //    //激活下事件
        //    OPT_CH.Checked = false;
        //    OPT_CH.Checked = true;

        //    return true;

        //}

        public override void Form_Ref()
        {
            p_Ref(2, 2, true, true);
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
