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
//-- Program Name      堆冷时间统计报表_CGT2001C
//-- Program ID        CGT2001C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.28
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.28       韩超        堆冷时间统计报表_CGT2001C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2001C : CommonClass.FORMBASE
    {
        public CGT2001C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        TextBox txt_Order = new TextBox();
        int count = 0;

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(ud_ch_date1, "P", "", "", "", imcseq, "");//1
            p_SetMc(ud_ch_date2, "P", "", "", "", imcseq, "");//2
            p_SetMc(txt_cool1, "PN", "", "", "", imcseq, "");//3
            p_SetMc(txt_cool2, "P", "", "", "", imcseq, "");//4
            p_SetMc(txt_cool3, "P", "", "", "", imcseq, "");//5
            p_SetMc("sql语句", txt_Order, "P", " ", "", "", "", imcseq);

        }

        private void CGT2001C_Load(object sender, EventArgs e)
        {

            base.sSvrPgmPkgName = "CGT2001NC";
            Form_Define();

            ud_ch_date1.RawDate = Gf_DTSet("D", "");
            ud_ch_date2.RawDate = Gf_DTSet("D", "");

        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;
        }

        public override void Form_Ref()
        {
            txtReset(txt_cool1);
            txtReset(txt_cool2);
            txtReset(txt_cool3);

            if (txt_cool1.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("必须输入堆冷时间范围", "I", "提示");
                return;
            }

            isAddColumn();

            sqlList.Sort();

            sqlInputPlSql();

            p_Ref(1, 1, true, true);

            GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList1.Images[9];
            GeneralCommon.MDIToolBar.Buttons[13].Tag = "T";

            string s;
            for (int i = 0; i < ss1.ActiveSheet.ColumnCount; i++)
            {
                s = ss1.ActiveSheet.ColumnHeader.Cells[0,i].Text.Substring(0,1);
                if(s == ">" || s == "<"){
                    ss1.ActiveSheet.ColumnHeader.Cells[0, i + 1].Text = ss1.ActiveSheet.ColumnHeader.Cells[0, i].Text;
                    i = i + 1;
                }
            }
        }

        ArrayList list = new ArrayList();//用于存放checkbox的名称
        ArrayList sqlList = new ArrayList();//用于存放选择的checkbox所对应的sql条件。

        //将选择的checkbox的名字放入list中，并将选择的sql语句放入sqlList中。否则将对应的名字以及sql语句从集合中删除。
        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string checkBoxName = checkBox.Name.Trim();
            switch (checkBoxName)
            {
                case "chk_Cond1":
                    if (this.chk_Cond1.Checked)
                    {
                        list.Add("板坯钢种");
                        sqlList.Add("1");
                    }
                    else
                    {
                        list.Remove("板坯钢种");
                        sqlList.Remove("1");
                    }
                    break;
                case "chk_Cond2":
                    if (this.chk_Cond2.Checked)
                    {
                        list.Add("板坯厚度");
                        sqlList.Add("2");
                    }
                    else
                    {
                        list.Remove("板坯厚度");
                        sqlList.Remove("2");
                    }
                    break;
                case "chk_Cond3":
                    if (this.chk_Cond3.Checked)
                    {
                        list.Add("板坯宽度");
                        sqlList.Add("3");
                    }
                    else
                    {
                        list.Remove("板坯宽度");
                        sqlList.Remove("3");
                    }
                    break;
                case "chk_Cond4":
                    if (this.chk_Cond4.Checked)
                    {
                        list.Add("板坯长度");
                        sqlList.Add("4");
                    }
                    else
                    {
                        list.Remove("板坯长度");
                        sqlList.Remove("4");
                    }
                    break;
                case "chk_Cond5":
                    if (this.chk_Cond5.Checked)
                    {
                        list.Add("订单标准");
                        sqlList.Add("5");
                    }
                    else
                    {
                        list.Remove("订单标准");
                        sqlList.Remove("5");
                    }
                    break;
            }
        }

        ////根据选择的checkbox得到checkbox的名字，并且写入到txt_Disp_Order，用于显示在页面中
        //public void input_Txt_Disp_Order()
        //{
        //    this.txt_Disp_Order.Text = "";
        //    string Txt_Disp_OrderText = "";
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Txt_Disp_OrderText += list[i].ToString() + " ";
        //    }
        //    this.txt_Disp_Order.Text = Txt_Disp_OrderText;
        //}

        //根据选择的checkbox得到sql语句，用于传入PLSQL中
        public void sqlInputPlSql()
        {
            string sqlInputPlSql = "";
            for (int i = 0; i < sqlList.Count; i++)
            {
                sqlInputPlSql += sqlList[i].ToString() + " ";
            }
            txt_Order.Text = sqlInputPlSql;
        }

        //根据是否有checkbox选中，重新设置ss1的列。
        public void isAddColumn()
        {
            int iheadrow = 1;
            int iscseq = 1;
            int colCount = 0;
            Sc1 = new Collection();
            p_ScIni(ss1, Sc1, 0, false, false);

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "板坯钢种")
                    {
                        p_SetSc(list[i].ToString(), "E", "", "L", "", "", "", iscseq, iheadrow);//0
                        p_SetSc("钢种名称", "E", "", "L", "", "", "", iscseq, iheadrow);//0
                        colCount++;
                        colCount++;
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "板坯厚度")
                    {
                        p_SetSc(list[i].ToString(), "N", "9", "L", "", "", "", iscseq, iheadrow);//0
                        colCount++;
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "板坯宽度")
                    {
                        p_SetSc(list[i].ToString(), "N", "9", "L", "", "", "", iscseq, iheadrow);//0
                        colCount++;
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "板坯长度")
                    {
                        p_SetSc(list[i].ToString(), "N", "9", "L", "", "", "", iscseq, iheadrow);//0
                        colCount++;
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "订单标准")
                    {
                        p_SetSc(list[i].ToString(), "E", "", "L", "", "", "", iscseq, iheadrow);//0
                        colCount++;
                    }
                }

                //此长度用于查询
                count = colCount;
            }
                string s1 = "";
                string s2 = "";
                iheadrow = 0;
                if (txt_cool1.Text != "")
                {
                    s1 = "<" + txt_cool1.Text;
                    s2 = ">=" + txt_cool1.Text;

                    p_SetSc("数量", "E", "", "L", "", "", "", 1, 1);//
                    p_SetSc("重量", "E", "", "L", "", "", "", 1, 1);//
                    p_SetSc("数量", "E", "", "L", "", "", "", 1, 1);//
                    p_SetSc("重量", "E", "", "L", "", "", "", 1, 1);//
                    p_spanSpread(s1, colCount, colCount + 1, iscseq, iheadrow, 1);
                    colCount = colCount + 2;
                    p_spanSpread(s2, colCount, colCount + 1, iscseq, iheadrow, 1);
                }
                if (txt_cool1.Text != "" && txt_cool2.Text != "")
                {
                    s1 = s2 + "  " + "<" + txt_cool2.Text;
                    s2 = ">=" + txt_cool2.Text;

                    p_spanSpread(s1, colCount, colCount + 1, iscseq, iheadrow, 1);

                    colCount = colCount + 2;

                    p_SetSc("数量", "E", "", "L", "", "", "", 1, 1);//
                    p_SetSc("重量", "E", "", "L", "", "", "", 1, 1);//

                    p_spanSpread(s2, colCount, colCount + 1, iscseq, iheadrow, 1);
                }
                if (txt_cool1.Text != "" && txt_cool2.Text != "" && txt_cool3.Text != "")
                {
                    s1 = s2 + "  " + "<" + txt_cool3.Text;
                    s2 = ">=" + txt_cool3.Text;

                    p_spanSpread(s1, colCount, colCount + 1, iscseq, iheadrow, 1);
                    colCount = colCount + 2;
                    p_SetSc("数量", "E", "", "L", "", "", "", 1, 1);//
                    p_SetSc("重量", "E", "", "L", "", "", "", 1, 1);//
                    p_spanSpread(s2, colCount, colCount + 1, iscseq, iheadrow, 1);
                }

                resetSpreadColumnHeaderName();
            
        }

        //重置ss1的初始化状态
        public void resetSpreadColumnHeaderName()
        {
            //int iheadrow = 1;
            //int iscseq = 1;
            //p_SetSc("板坯重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//0
           
        }

        public void txtReset(TextBox textBox)
        {
            try
            {
                int.Parse(textBox.Text.ToString());
            }
            catch
            {
                try
                {
                    double.Parse(txt_cool1.Text.ToString());
                }
                catch
                {
                    textBox.Text = "";
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

        private void txt_cool1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txt_cool1.Text.ToString());
            }
            catch
            {
                try
                {
                    double.Parse(txt_cool1.Text.ToString());
                }
                catch
                {
                    ((TextBox)sender).Text = "";
                }
            }
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount <= 0) return;
            
            CGT2001C_POP CGT2001C_POP = new CGT2001C_POP();
            CGT2001C_POP.MdiParent = GeneralCommon.MDIMain;
            CGT2001C_POP.Show();
            CGT2001C_POP.txt_date1.RawDate = ud_ch_date1.RawDate;
            CGT2001C_POP.txt_date2.RawDate = ud_ch_date2.RawDate;

            int i;
            int tmp;
            int cur_row;

            cur_row = e.Row;

            for (i = 1; i <= count; i++)
            {
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, i-1].Text == chk_Cond1.Text)
                {
                    CGT2001C_POP.txt_stlgrd.Text = ss1.ActiveSheet.Cells[cur_row, i - 1].Text;
                    continue;
                }

                if (ss1.ActiveSheet.ColumnHeader.Cells[0, i - 1].Text == chk_Cond2.Text)
                {
                    CGT2001C_POP.txt_thk.Text = ss1.ActiveSheet.Cells[cur_row, i - 1].Text.Replace(",","");
                    continue;
                }

                if (ss1.ActiveSheet.ColumnHeader.Cells[0, i - 1].Text == chk_Cond3.Text)
                {
                    CGT2001C_POP.txt_wid.Text = ss1.ActiveSheet.Cells[cur_row, i - 1].Text.Replace(",", "");
                    continue;
                }

                if (ss1.ActiveSheet.ColumnHeader.Cells[0, i - 1].Text == chk_Cond4.Text)
                {
                    CGT2001C_POP.txt_len.Text = ss1.ActiveSheet.Cells[cur_row, i - 1].Text.Replace(",", "");
                    continue;
                }

                if (ss1.ActiveSheet.ColumnHeader.Cells[0, i - 1].Text == chk_Cond5.Text)
                {
                    CGT2001C_POP.txt_spec.Text = ss1.ActiveSheet.Cells[cur_row, i - 1].Text;
                    continue;
                }
            }

            tmp = ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.IndexOf(" ");

            if (ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.IndexOf(">=") >= 0)
            {
                if (tmp == -1)
                {
                    CGT2001C_POP.txt_cool1.Text = ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Substring(2, ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Length - 2);
                }
                else
                {
                    CGT2001C_POP.txt_cool1.Text = ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Substring(2, tmp - 2);
                }
            }
            else
            {
                CGT2001C_POP.txt_cool1.Text = "0";
            }

            if (ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.IndexOf("<") >= 0)
            {
                if (tmp == -1)
                {
                    CGT2001C_POP.txt_cool2.Text = ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Substring(1, ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Length - 1);
                }
                else
                {
                    CGT2001C_POP.txt_cool2.Text = ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Substring(tmp + 3, ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text.Length - tmp-3);
                }
            }
            else
            {
                CGT2001C_POP.txt_cool2.Text = "99999";
            }

            CGT2001C_POP.Form_Ref();
            CGT2001C_POP.WindowState = FormWindowState.Maximized;

        }




    }
}
