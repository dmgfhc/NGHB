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
//-- Sub_System Name   轧钢作业
//-- Program Name      综合查询界面
//-- Program ID        CGT2100C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.02
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER           DATE                 EDITOR            DESCRIPTION
//   1.0         2018.01.02             韩超             综合查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2100C : CommonClass.FORMBASE
    {
        public CGT2100C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public int stlgrd_col = -1;
        public int slab_plt_col = -1;
        public int col = 0;

        List<CheckBox> chk_Cond = new List<CheckBox>();


        protected override void p_SubFormInit()
        {
           
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产时间(开始)", txt_DateFrom, "PN", " ", "", "", "", imcseq);
            p_SetMc("生产时间(结束)", txt_DateTo, "PN", " ", "", "", "", imcseq);        
            p_SetMc("班次", txt_Shift, "P", " ", "", "", "", imcseq);
            p_SetMc("班别", txt_Group_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("班别", TXT_SLAB_NO, "P", " ", "", "", "", imcseq);
            p_SetMc("钢板orLP板or全部", TXT_SP_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("sql语句", txt_Order, "P", " ", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            //0-14
            p_SetSc("板坯重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("理论计算合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("协议量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("改判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("修磨量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("待判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("废品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("不合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("探伤量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("合格率(%)", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("成材率(%)", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("下料成材率(%)", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//12           
            p_SetSc("剪切重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//13

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 1;
            iscseq = 2;
         
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("钢板号", "E", "12", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("连铸机号", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("厚度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("成品重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//10
            p_SetSc("是否合格", "C", "1", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("是否协议", "C", "1", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("是否待判", "C", "1", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("是否修磨", "C", "1", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("是否改判", "C", "1", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("单", "C", "1", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("双", "C", "1", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("是否切边", "C", "1", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("是否探伤", "C", "1", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("是否热处理", "C", "1", "L", "", "", "", iscseq, iheadrow);//20
            p_SetSc("生产日期", "D", "8", "L", "", "", "", iscseq, iheadrow,"L");//21
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("入库日", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("综合判定日", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("发货日", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("订单号", "E", "16", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("订单序列号", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("板坯切割时间", "DT", "14", "LA", "", "", "", iscseq, iheadrow,"L");//29
            p_SetSc("入炉时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("板坯厚度", "N", "8", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("经RH", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
          
            iheadrow = 0;
            p_spanSpread("成品规格(MM)", 6, 8, iscseq, iheadrow, 1);
            p_spanSpread("是否正尺", 16, 17, iscseq, iheadrow, 1);

        }

        private void Check1_Clk()
        {
            int i;
            int j;
            string stlgrd;
            string plt;
            string back_mon;
            string SQL;
            double BACK_WGT;
            back_mon = txt_DateFrom.RawDate.Substring(0,6);

            if (SSTab1.SelectedIndex == 0)
            {
                {
                    if (ss1.ActiveSheet.RowCount > 1 & stlgrd_col >= 0 & slab_plt_col >= 0 & Check1.Checked)
                    {
                        for (i = 1; i <= ss1.ActiveSheet.RowCount - 1; i++)
                        {
                            stlgrd = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select gf_stlgrd_code('" + ss1.ActiveSheet.Cells[i - 1, stlgrd_col].Text + "') from dual");
                            if (ss1.ActiveSheet.Cells[i - 1, slab_plt_col].Text == "板卷")
                            {
                                plt = "B1";
                            }
                            else if (ss1.ActiveSheet.Cells[i - 1, slab_plt_col].Text == "转炉")
                            {
                                plt = "B3";
                            }
                            else if (ss1.ActiveSheet.Cells[i - 1, slab_plt_col].Text == "外购" | ss1.ActiveSheet.Cells[i - 1, slab_plt_col].Text == "来料")
                            {
                                plt = "BZ";
                            }
                            plt = ss1.ActiveSheet.Cells[i - 1, slab_plt_col].Text;
                            SQL = "select GF_SLAB_BACK_WGT('" + back_mon + "','" + plt + "','" + stlgrd + "') from dual";
                            BACK_WGT = convertX(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, SQL));
                            ss1.ActiveSheet.Cells[i - 1, 2].Text = (convertX(ss1.ActiveSheet.Cells[i - 1, 2].Text) + BACK_WGT).ToString();
                        }
                        //            Else
                        //               For I = 1 To ss1.MaxRows - 1
                        //                   .Row = I
                        //                   .Col = stlgrd_col
                        //                   stlgrd = Gf_CodeFind(M_CN1, "select gf_stlgrd_code('" + .Text + "') from dual")
                        //                   .Col = slab_plt_col
                        //                   plt = .Text
                        //                   SQL = "select GF_SLAB_BACK_WGT('" & back_mon & "','" & plt & "','" & stlgrd & "') from dual"
                        //                   BACK_WGT = Gf_CodeFind(M_CN1, SQL)
                        //                   .Col = 3
                        //                   .Text = CDbl(.Text) - BACK_WGT
                        //               Next
                    }
                }
            }
            else
            {
                return;
            }
        }



        private void CGT2100C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2100NC";
            Form_Define();
            this.OPT_PLATE.Checked = true;
            this.TXT_SP_CD.Text = "P";
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
        }




        public override bool Form_Cls()
        {
            base.Form_Cls();
            list.Clear();
            sqlList.Clear();
            resetSpreadColumnHeaderName();
            this.chk_Cond0.Checked = false;
            this.chk_Cond1.Checked = false;
            this.chk_Cond2.Checked = false;
            this.chk_Cond3.Checked = false;
            this.chk_Cond4.Checked = false;
            this.chk_Cond5.Checked = false;
            this.chk_Cond6.Checked = false;
            this.chk_Cond7.Checked = false;
            this.chk_Cond8.Checked = false;
            this.chk_Cond9.Checked = false;
            this.chk_Cond10.Checked = false;
            this.chk_Cond11.Checked = false;
            this.chk_Cond12.Checked = false;
            this.chk_Cond13.Checked = false;
            this.chk_Cond14.Checked = false;
            this.chk_Cond15.Checked = false;
            this.chk_Cond16.Checked = false;
            this.chk_Cond17.Checked = false;

            this.txt_Shift.Text = "";
            this.txt_Group_CD.Text = "";
            this.txt_Disp_Order.Text = "";

            TXT_SP_CD.Text = "P";
            OPT_PLATE.Checked = true;

            return true;
        }

        //重写查询函数，根据当前页面的Spread进行查询。主要用于ss1的列合计。
        public override void Form_Ref()
        {
            double slabWeightSum = 0;//板坯重量  合计
            double slabQualified = 0;//合格量  合计
            double slabProtocolWeight = 0;//协议量  合计
            double slabChangeWeight = 0;//改判量  合计
            double slabCopingWeight = 0;//修磨量  合计
            double slabWasteWeight = 0;//废品量  合计
            double slabUnqualifiedWeight = 0;//不合格量  合计

            double waitWeight = 0;//待判量  合计
            double ustWeight = 0;//探伤量  合计
            double cutWeight = 0;//剪切重量  合计

            isAddColumn();
            if (base.i_ScCurrSeq == 1)
            {
                base.p_Ref(1, 1, true, true);
                for (int i = 0; i < ss1.ActiveSheet.Columns.Count; i++)
                {
                    FontFamily myFontFamily = new FontFamily("宋体");
                    Font myFont = new Font(myFontFamily, (float)9.75, FontStyle.Bold);
                    ss1.ActiveSheet.ColumnHeader.Cells[0, i].Font = myFont;
                }
                if (ss1.ActiveSheet.Rows.Count == 0) return;
                for (int i = 0; i < ss1.ActiveSheet.Rows.Count; i++)
                {
                    for (int j = 0; j < ss1.ActiveSheet.Columns.Count; j++)
                    {
                        if (ss1.ActiveSheet.Cells[i, j].Text == "0.000")
                        {
                            ss1.ActiveSheet.Cells[i, j].Text = "";
                        }
                        if (ss1.ActiveSheet.Cells[i, j].Text == "0.0")
                        {
                            ss1.ActiveSheet.Cells[i, j].Text = "";
                        }
                    }
                }
                for (int i = 0; i < ss1.ActiveSheet.Rows.Count; i++)
                {
                    slabWeightSum += ss1.ActiveSheet.Cells[i, list.Count].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count].Text);
                    slabQualified += ss1.ActiveSheet.Cells[i, list.Count + 1].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 1].Text);
                    slabProtocolWeight += ss1.ActiveSheet.Cells[i, list.Count + 3].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 3].Text);
                    slabChangeWeight += ss1.ActiveSheet.Cells[i, list.Count + 4].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 4].Text);
                    slabCopingWeight += ss1.ActiveSheet.Cells[i, list.Count + 5].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 5].Text);
                    slabWasteWeight += ss1.ActiveSheet.Cells[i, list.Count + 7].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 7].Text);
                    slabUnqualifiedWeight += ss1.ActiveSheet.Cells[i, list.Count + 8].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 8].Text);

                    waitWeight += ss1.ActiveSheet.Cells[i, list.Count + 6].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 6].Text);
                    ustWeight += ss1.ActiveSheet.Cells[i, list.Count + 9].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 9].Text);
                    cutWeight += ss1.ActiveSheet.Cells[i, list.Count + 13].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 13].Text);

                }
                ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.Rows.Count, 1);
                //if (list.Count == 0)
                //{
                //    ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].Text = "合计";
                //}
                //else
                //{
                //    ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].Text = "合计";
                //    ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].BackColor = Color.Green;
                //}
                ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].Text = "合计";

                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count].Text = slabWeightSum.ToString();//板坯重量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 1].Text = slabQualified.ToString();//合格量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 3].Text = slabProtocolWeight.ToString();//协议量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 4].Text = slabChangeWeight.ToString();//改判量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 5].Text = slabCopingWeight.ToString();//改判量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 7].Text = slabWasteWeight.ToString();//废品量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 8].Text = slabUnqualifiedWeight.ToString();//废品量  合计

                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 6].Text = waitWeight.ToString();//待判量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 9].Text = ustWeight.ToString();//探伤量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 13].Text = cutWeight.ToString();//剪切量  合计
            }
            else
            {
                base.p_Ref(1, 2, true, true);
                ss2.ActiveSheet.FrozenColumnCount = 2;
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
                case "chk_Cond0":
                    if (this.chk_Cond0.Checked)
                    {
                        list.Add("板坯钢种");
                        sqlList.Add(",C.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("板坯钢种");
                        sqlList.Remove(",C.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond1":
                    if (this.chk_Cond1.Checked)
                    {
                        list.Add("成品标准");
                        sqlList.Add(",B.APLY_STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("成品标准");
                        sqlList.Remove(",B.APLY_STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond2":
                    if (this.chk_Cond2.Checked)
                    {
                        list.Add("成品厚度");
                        sqlList.Add(",B.THK");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("成品厚度");
                        sqlList.Remove(",B.THK");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond3":
                    if (this.chk_Cond3.Checked)
                    {
                        list.Add("成品宽度");
                        sqlList.Add(",B.WID");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("成品宽度");
                        sqlList.Remove(",B.WID");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond4":
                    if (this.chk_Cond4.Checked)
                    {
                        list.Add("成品长度");
                        sqlList.Add(",B.LEN");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("成品长度");
                        sqlList.Remove(",B.LEN");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond5":
                    if (this.chk_Cond5.Checked)
                    {
                        list.Add("生产日");
                        sqlList.Add(",B.PROD_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("生产日");
                        sqlList.Remove(",B.PROD_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond6":
                    if (this.chk_Cond6.Checked)
                    {
                        list.Add("入库日");
                        sqlList.Add(",SUBSTR(B.BED_PILE_DATE,1,8)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("入库日");
                        sqlList.Remove(",SUBSTR(B.BED_PILE_DATE,1,8)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond7":
                    if (this.chk_Cond7.Checked)
                    {
                        list.Add("终判日");
                        sqlList.Add(",B.DSC_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("终判日");
                        sqlList.Remove(",B.DSC_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond8":
                    if (this.chk_Cond8.Checked)
                    {
                        list.Add("板坯号");
                        sqlList.Add(",substr(B.plate_no,1,10)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("板坯号");
                        sqlList.Remove(",substr(B.plate_no,1,10)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond9":
                    if (this.chk_Cond9.Checked)
                    {
                        list.Add("班别");
                        sqlList.Add(",B.GROUP_CD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("班别");
                        sqlList.Remove(",B.GROUP_CD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond10":
                    if (this.chk_Cond10.Checked)
                    {
                        list.Add("定尺");
                        sqlList.Add(",B.SIZE_KND");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("定尺");
                        sqlList.Remove(",B.SIZE_KND");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond11":
                    if (this.chk_Cond11.Checked)
                    {
                        list.Add("切边");
                        sqlList.Add(",B.TRIM_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("切边");
                        sqlList.Remove(",B.TRIM_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond12":
                    if (this.chk_Cond12.Checked)
                    {
                        list.Add("订单号");
                        list.Add("订单项次");
                        sqlList.Add(",B.ORD_NO");
                        sqlList.Add(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("订单号");
                        list.Remove("订单项次");
                        sqlList.Remove(",B.ORD_NO");
                        sqlList.Remove(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond13":
                    if (this.chk_Cond13.Checked)
                    {
                        list.Add("订单材代码");
                        sqlList.Add(",B.ORD_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("订单材代码");
                        sqlList.Remove(",B.ORD_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond14":
                    if (this.chk_Cond14.Checked)
                    {
                        list.Add("坯料来源");
                        sqlList.Add(",C.PLT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                        slab_plt_col = col;
                    }
                    else
                    {
                        list.Remove("坯料来源");
                        sqlList.Remove(",C.PLT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                        slab_plt_col = -1;
                    }
                    break;
                case "chk_Cond15"://“订单序列号”隐藏
                    if (this.chk_Cond15.Checked)
                    {
                        list.Add("轧制钢种");
                        sqlList.Add(",B.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                        stlgrd_col = col;
                    }
                    else
                    {
                        list.Remove("轧制钢种");
                        sqlList.Remove(",B.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                        stlgrd_col = -1;
                    }
                    break;
                case "chk_Cond16":
                    if (this.chk_Cond16.Checked)
                    {
                        list.Add("库别");
                        sqlList.Add(",H.INF_CUR_INV");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("库别");
                        sqlList.Remove(",H.INF_CUR_INV");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond17":
                    if (this.chk_Cond17.Checked)
                    {
                        list.Add("轧制标准");
                        sqlList.Add(",O.STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("轧制标准");
                        sqlList.Remove(",O.STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
            }
            col = col + 1;
        }

        //根据选择的checkbox得到checkbox的名字，并且写入到txt_Disp_Order，用于显示在页面中
        public void input_Txt_Disp_Order()
        {
            this.txt_Disp_Order.Text = "";
            string Txt_Disp_OrderText = "";
            for (int i = 0; i < list.Count; i++)
            {
                Txt_Disp_OrderText += list[i].ToString() + " ";
            }
            this.txt_Disp_Order.Text = Txt_Disp_OrderText;
        }

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
            int iheadrow = 0;
            int iscseq = 1;
            Sc1 = new Collection();
            p_ScIni(ss1, Sc1, 0, false, true);

            if (list.Count == 0)
            {
                resetSpreadColumnHeaderName();
                return;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == "成品厚度")
                    {
                        p_SetSc(list[i].ToString(), "N", "8,1", "L", "", "", "", 1, 0);//0
                    }
                    else if (list[i].ToString() == "成品宽度")
                    {
                        p_SetSc(list[i].ToString(), "N", "8", "L", "", "", "", 1, 0);//0
                    }
                    else if (list[i].ToString() == "成品长度")
                    {
                        p_SetSc(list[i].ToString(), "N", "8", "L", "", "", "", 1, 0);//0
                    }
                    else
                    {
                        p_SetSc(list[i].ToString(), "E", "", "L", "", "", "", 1, 0);//0
                    }
                }
                resetSpreadColumnHeaderName();
            }
        }

        //重置ss1的初始化状态
        public void resetSpreadColumnHeaderName()
        {
            int iheadrow = 0;
            int iscseq = 1;
            p_SetSc("板坯重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("理论计算合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("协议量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("改判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("修磨量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("待判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("废品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("不合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("探伤量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("合格率(%)", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("成材率(%)", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("下料成材率(%)", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//12           
            p_SetSc("剪切重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//13

            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
        }




        private void OPT_PLATE_Click(object sender, EventArgs e)
        {
            if (this.OPT_PLATE.Checked)
            {
                this.TXT_SP_CD.Text = "P";
            }
            else if (OPT_SLAB.Checked)
            {
                this.TXT_SP_CD.Text = "S";
            }
            else
            {
                this.TXT_SP_CD.Text = "B";
            }
        }

        private void OPT_SLAB_Click(object sender, EventArgs e)
        {
            if (this.OPT_PLATE.Checked)
            {
                this.TXT_SP_CD.Text = "P";
            }
            else if (OPT_SLAB.Checked)
            {
                this.TXT_SP_CD.Text = "S";
            }
            else
            {
                this.TXT_SP_CD.Text = "B";
            }
        }

        private void OPT_PILE_Click(object sender, EventArgs e)
        {
            if (this.OPT_PLATE.Checked)
            {
                this.TXT_SP_CD.Text = "P";
            }
            else if (OPT_SLAB.Checked)
            {
                this.TXT_SP_CD.Text = "S";
            }
            else
            {
                this.TXT_SP_CD.Text = "B";
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

        private void SSTab1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex ==0)
            {
                base.i_ScCurrSeq = 1;
            }
            else
            {
                base.i_ScCurrSeq = 2;
            }
        }

        private void Check1_Click(object sender, EventArgs e)
        {
            Check1_Clk();
        }




    }
}
