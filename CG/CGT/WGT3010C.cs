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
//-- Sub_System Name   轧钢作业
//-- Program Name      综合查询界面
//-- Program ID        WGT3010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          袁登科
//-- Coder             袁登科
//-- Date              2012.12.10
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER           DATE                 EDITOR            DESCRIPTION
//   1.0         2012.12.10             袁登科             综合查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT3010C : CommonClass.FORMBASE
    {
        public WGT3010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        TextBox txt_Order = new TextBox();
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
            p_SetMc("剪切or轧制",TXT_SP_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("钢板orLP板or全部",TXT_PROD_CD, "P", " ", "", "", "", imcseq);
            p_SetMc("sql语句", txt_Order, "P", " ", "", "", "", imcseq);
            p_SetMc("缺陷",txt_Defect_name, "P", " ", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;

            //0-14
            p_SetSc("板坯重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("理论计算合格量", "N", "12,3", "LA", "", "", "", iscseq, iheadrow);//2
            p_SetSc("协议量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("改判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("修磨量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("待判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("次品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("废品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("不合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("探伤量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("合格率(%)", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("成才率(%)", "N", "8,3", "LA", "", "", "", iscseq, iheadrow);//12
            p_SetSc("下料成材率(%)", "N", "8,3", "LA", "", "", "", iscseq, iheadrow);//13           
            p_SetSc("剪切重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//14

            p_ScIni(ss2, Sc2, 0, true, false);
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
            p_SetSc("订单号", "E", "16", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("订单序列号", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("订单材/余材", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("是否合格", "C", "1", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("是否协议", "C", "1", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("是否待判", "C", "1", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("是否修磨", "C", "1", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("是否改判", "C", "1", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("单", "C", "1", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("双", "C", "1", "L", "", "", "", iscseq, iheadrow);//20
            p_SetSc("是否切边", "C", "1", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("是否探伤", "C", "1", "L", "", "", "", iscseq, iheadrow);//22
            p_SetSc("生产日期", "D", "8", "L", "", "", "", iscseq, iheadrow,"L");//23
            p_SetSc("入库日期", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("综判日期", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("发货日期", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("板坯切割时间", "DT", "14", "LA", "", "", "", iscseq, iheadrow,"L");//27
            p_SetSc("板坯入炉时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("板坯厚度", "N", "8", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//31
          
            iheadrow = 0;
            p_spanSpread("成品规格(MM)", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("定尺", 19, 20, iscseq, iheadrow, 1);

        }

        private void WGY1205C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGT3010C";
            Form_Define();
            this.OPT_PLATE.Checked = true;
            this.opt_Product1.Checked = true;
            this.OPT_PLATE.ForeColor = Color.Red;
            this.TXT_SP_CD.Text = "P";
            this.opt_Product1.ForeColor = Color.Red;
            this.TXT_PROD_CD.Text = "PP";
            txt_DateFrom.RawDate = (DateTime.Now.ToShortDateString()).Replace("-", "");
            txt_DateTo.RawDate = (DateTime.Now.ToShortDateString()).Replace("-", "");
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            list.Clear();
            sqlList.Clear();
            resetSpreadColumnHeaderName();
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;
            this.checkBox11.Checked = false;
            this.checkBox12.Checked = false;
            this.checkBox13.Checked = false;
            this.checkBox14.Checked = false;
            this.checkBox15.Checked = false;
            this.checkBox16.Checked = false;
            this.checkBox17.Checked = false;
            this.txt_Shift.Text = "";
            this.txt_Group_CD.Text = "";
            this.txt_Disp_Order.Text = "";
            return true;
        }

        private void OPT_PLATE_Click(object sender, EventArgs e)
        {
            if (this.OPT_PLATE.Checked)
            {
                this.OPT_PLATE.ForeColor = Color.Red;
                this.OPT_SLAB.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "P";
            }
            else
            {
                this.OPT_PLATE.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "S";
            }
        }

        private void OPT_SLAB_Click(object sender, EventArgs e)
        {
            if(this.OPT_SLAB.Checked)
            {
                this.OPT_SLAB.ForeColor = Color.Red;
                this.OPT_PLATE.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "S";
            }
            else
            {
                this.OPT_SLAB.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "P";
            }
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
            isAddColumn();
            if (base.i_ScCurrSeq == 1)
            {
                base.p_Ref(1, 1, true, true);
                for (int i = 0; i < ss1.ActiveSheet.Columns.Count;i++)
                {
                    FontFamily myFontFamily = new FontFamily("宋体"); 
                    Font myFont = new Font(myFontFamily, (float)9.75, FontStyle.Bold);
                    ss1.ActiveSheet.ColumnHeader.Cells[0, i].Font = myFont;
                }
                if (ss1.ActiveSheet.Rows.Count == 0) return;
                for (int i = 0; i < ss1.ActiveSheet.Rows.Count; i++)
                {
                    for(int j=0;j<ss1.ActiveSheet.Columns.Count;j++)
                    {
                        if(ss1.ActiveSheet.Cells[i,j].Text == "0.000")
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
                    slabWasteWeight += ss1.ActiveSheet.Cells[i, list.Count + 8].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 8].Text);
                    slabUnqualifiedWeight += ss1.ActiveSheet.Cells[i, list.Count + 9].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 9].Text);
                }
                ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.Rows.Count, 1);
                if (list.Count == 0)
                {
                    ss1.ActiveSheet.RowHeader.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].Text = "合计";
                }
                else
                {
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].Text = "合计";
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, 0].BackColor = Color.Pink;
                }
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count].Text = slabWeightSum.ToString();//板坯重量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 1].Text = slabQualified.ToString();//合格量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 3].Text = slabProtocolWeight.ToString();//协议量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 4].Text = slabChangeWeight.ToString();//改判量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 5].Text = slabCopingWeight.ToString();//改判量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 8].Text = slabWasteWeight.ToString();//废品量  合计
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 9].Text = slabUnqualifiedWeight.ToString();//废品量  合计
            }
            else
            {
                base.p_Ref(1, 2, true, true);
                ss2.ActiveSheet.FrozenColumnCount = 2;
            }
        }

        private void opt_Product_Click(object sender, EventArgs e)
        {
            this.opt_Product.Checked = true;
            this.opt_Product1.Checked = false;
            this.opt_Product2.Checked = false;
            this.opt_Product.ForeColor = Color.Red;
            this.opt_Product1.ForeColor = Color.Black;
            this.opt_Product2.ForeColor = Color.Black;
            this.TXT_PROD_CD.Text = "AL";
        }

        private void opt_Product1_Click(object sender, EventArgs e)
        {
            this.opt_Product1.Checked = true;
            this.opt_Product.Checked = false;
            this.opt_Product2.Checked = false;
            this.opt_Product1.ForeColor = Color.Red;
            this.opt_Product.ForeColor = Color.Black;
            this.opt_Product2.ForeColor = Color.Black;
            this.TXT_PROD_CD.Text = "PP";
        }

        private void opt_Product2_Click(object sender, EventArgs e)
        {
            this.opt_Product2.Checked = true;
            this.opt_Product1.Checked = false;
            this.opt_Product.Checked = false;
            this.opt_Product2.ForeColor = Color.Red;
            this.opt_Product1.ForeColor = Color.Black;
            this.opt_Product.ForeColor = Color.Black;
            this.TXT_PROD_CD.Text = "HC";
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
                case "checkBox1" :
                    if(this.checkBox1.Checked)
                    {
                        list.Add("板坯钢种");
                        sqlList.Add(",B.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("板坯钢种");
                        sqlList.Remove(",B.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox2":
                    if (this.checkBox2.Checked)
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
                case "checkBox3":
                    if (this.checkBox3.Checked)
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
                case "checkBox4":
                    if (this.checkBox4.Checked)
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
                case "checkBox5":
                    if (this.checkBox5.Checked)
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
                case "checkBox6":
                    if (this.checkBox6.Checked)
                    {
                        list.Add("订单号");
                        list.Add("订单序列号");
                        sqlList.Add(",B.ORD_NO");
                        sqlList.Add(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("订单号");
                        list.Remove("订单序列号");
                        sqlList.Remove(",B.ORD_NO");
                        sqlList.Remove(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox7":
                    if (this.checkBox7.Checked)
                    {
                        list.Add("订单材号码");
                        sqlList.Add(",B.ORD_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("订单材号码");
                        sqlList.Remove(",B.ORD_FL");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox8":
                    if (this.checkBox8.Checked)
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
                case "checkBox9":
                    if (this.checkBox9.Checked)
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
                case "checkBox10":
                    if (this.checkBox10.Checked)
                    {
                        list.Add("综判日期");
                        sqlList.Add(",B.DSC_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("综判日期");
                        sqlList.Remove(",B.DSC_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox11":
                    if (this.checkBox11.Checked)
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
                case "checkBox12":
                    if (this.checkBox12.Checked)
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
                case "checkBox13":
                    if (this.checkBox13.Checked)
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
                case "checkBox14":
                    if (this.checkBox14.Checked)
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
                case "checkBox15":
                    if (this.checkBox15.Checked)
                    {
                        list.Add("成品钢种");
                        sqlList.Add(",O.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("成品钢种");
                        sqlList.Remove(",O.STLGRD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox16"://“订单序列号”隐藏
                    if (this.checkBox16.Checked)
                    {
                        list.Add("订单序列号");
                        sqlList.Add(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("订单序列号");
                        sqlList.Remove(",B.ORD_ITEM");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "checkBox17":
                    if (this.checkBox17.Checked)
                    {
                        list.Add("轧制钢种");
                        sqlList.Add(",O.STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("轧制钢种");
                        sqlList.Remove(",O.STDSPEC");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
            }
        }

        //根据选择的checkbox得到checkbox的名字，并且写入到txt_Disp_Order，用于显示在页面中
        public void input_Txt_Disp_Order()
        {
            this.txt_Disp_Order.Text = "";
            string Txt_Disp_OrderText = "";
            for (int i = 0; i < list.Count;i++)
            {    
                Txt_Disp_OrderText += list[i].ToString() + " ";
            }
            this.txt_Disp_Order.Text = Txt_Disp_OrderText;
        }

        //根据选择的checkbox得到sql语句，用于传入PLSQL中
        public void sqlInputPlSql()
        {
            string sqlInputPlSql = "";
            for (int i = 0; i < sqlList.Count;i++)
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
            p_SetSc("理论计算合格量", "N", "12,3", "AL", "", "", "", iscseq, iheadrow);//2
            p_SetSc("协议量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("改判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("修磨量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("待判量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("次品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("废品量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("不合格量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("探伤量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("合格率(%)", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("成才率(%)", "N", "8,1", "LA", "", "", "", iscseq, iheadrow);//12
            p_SetSc("下料成材率(%)", "N", "8,1", "LA", "", "", "", iscseq, iheadrow);//13           
            p_SetSc("剪切重量", "N", "12,3", "L", "", "", "", iscseq, iheadrow);//14
        }

        //点击tabControl控件，判断当前Spread
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
                if( e.TabPage == tabPage1)
                {
                    base.i_ScCurrSeq = 1;
                }
                else
                {
                    base.i_ScCurrSeq = 2;
                }
        }


    }
}
