
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
namespace CG
{
    public partial class WGA1050C : CommonClass.FORMBASE
    {
        public WGA1050C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        protected override void p_SubFormInit()
        {
            p_McIni(Mc1, false);
            p_SetMc("入库日(生产)", txt_DateFrom, "P", "", "", "", "", 1);//0
            p_SetMc("入库日(生产)", txt_DateTo, "P", "", "", "", "", 1);//1
            p_SetMc("板坯号", txt_slab_no, "P", "", "", "", "", 1);//2
            p_SetMc("板坯号", txt_slab_no_to, "P", "", "", "", "", 1);//3
            p_SetMc("炉座号", cbo_prc_line, "P", "", "", "", "", 1);//4
            p_SetMc("连铸机号", cbo_ccm_line, "P", "", "", "", "", 1);//4
            p_SetMc("堆放仓库", txt_cur_inv_code, "P", "", "", "", "", 1);//4
            p_SetMc("隐藏1", txt_cond, "P", "", "", "", "", 1);//4
            p_SetMc("隐藏2", txt_Order, "P", "", "", "", "", 1);//4
         

            p_ScIni(ss1, Sc1, 0, false, true);
            p_SetSc("块数", "N", "6", "L", "", "", "", 1, 0);//0
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 1, 0, "M");//1
            p_SetSc("定尺量", "N", "8,3", "L", "", "", "", 1, 0, "M");//2
            p_SetSc("非定尺量", "N", "8,3", "L", "", "", "", 1, 0, "M");//3
            p_SetSc("锥坯量(t)", "N", "8,3", "L", "", "", "", 1, 0);//4
            p_SetSc("异常坯量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//5
            p_SetSc("裂纹量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//6
            p_SetSc("接坯量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//7
            p_SetSc("钢种改判(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//8
            p_SetSc("非计划(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//9
        

            p_ScIni(ss2, Sc2, 0, false, true);
            p_SetSc("板坯号", "E", "", "L", "", "", "", 2, 1,"M");//0
            p_SetSc("板坯类型", "E", "10", "L", "", "", "", 2, 1, "M");//1
            p_SetSc("产品代码", "E", "", "L", "", "", "", 2, 1, "M");//2
            p_SetSc("订单材\\余材", "E", "", "L", "", "", "", 2, 1, "M");//3
            p_SetSc("紧急订单", "E", "", "L", "", "", "", 2, 1,"M");//4

            p_SetSc("进程代码", "E", "", "L", "", "", "", 2, 1, "M");//5
            p_SetSc("炼钢计划钢种", "E", "", "L", "", "", "", 2, 1, "M");//6
            p_SetSc("炼钢计划钢种说明", "E", "", "L", "", "", "", 2, 1, "M");//7
            p_SetSc("冶炼钢种", "E", "", "L", "", "", "", 2, 1, "M");//8
            p_SetSc("冶炼钢种说明", "E", "", "L", "", "", "", 2, 1, "M");//9

            p_SetSc("板坯钢种", "E", "", "L", "", "", "", 2, 1, "M");//10
            p_SetSc("板坯钢种说明", "E", "", "L", "", "", "", 2, 1, "M");//11
            p_SetSc("锁定原因", "E", "", "L", "", "", "", 2, 1, "M");//12
            p_SetSc("处置措施", "E", "", "L", "", "", "", 2, 1, "M");//13
            p_SetSc("去向", "E", "", "L", "", "", "", 2, 1,"M");//14

            p_SetSc("堆放仓库", "E", "", "L", "", "", "", 2, 1, "M");//15
            p_SetSc("垛位号", "E", "", "L", "", "", "", 2, 1, "M");//16
            p_SetSc("连铸机号", "E", "", "L", "", "", "", 2, 1, "M");//17
            p_SetSc("厚度", "N", "8", "L", "", "", "", 2, 1, "M");//18
            p_SetSc("宽度", "N", "8", "L", "", "", "", 2, 1);//19

            p_SetSc("长度", "N", "8", "L", "", "", "", 2, 1, "M");//20
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 2, 1, "M");//21
            p_SetSc("正尺量", "N", "8,3", "L", "", "", "", 2, 1);//22
            p_SetSc("非正尺量", "N", "8,3", "L", "", "", "", 2, 1, "M");//23
            p_SetSc("锥坯量(t)", "N", "8,3", "L", "", "", "", 2, 1, "M");//24

            p_SetSc("异常坯", "E", "", "L", "", "", "", 2, 1, "M");//25
            p_SetSc("接坯(t)", "E", "", "L", "", "", "", 2, 1);//26
            p_SetSc("钢种改判", "N", "8,3", "L", "", "", "", 2, 1, "M");//27
            p_SetSc("非计划", "E", "", "L", "", "", "", 2, 1, "M");//28
            p_SetSc("是否回炉", "C", "", "L", "", "", "", 2, 1, "M");//29

            p_SetSc("质量等级", "E", "", "L", "", "", "", 2, 1, "M");//30
            p_SetSc("化学成份", "E", "", "L", "", "", "", 2, 1, "M");//31
            p_SetSc("表面缺陷", "E", "", "L", "", "", "", 2, 1, "M");//32
            p_SetSc("转炉出钢日", "E", "", "L", "", "", "", 2, 1, "M");//33
            p_SetSc("班次", "E", "", "L", "", "", "", 2, 1, "M");//34

            p_SetSc("班别", "E", "", "L", "", "", "", 2, 1, "M");//35
            p_SetSc("生产日", "E", "", "L", "", "", "", 2, 1);//36
            p_SetSc("班次", "E", "", "L", "", "", "", 2, 1, "M");//37
            p_SetSc("班别", "E", "", "L", "", "", "", 2, 1, "M");//38
            p_SetSc("日期", "E", "", "L", "", "", "", 2, 1, "M");//39

            p_SetSc("时间", "E", "", "L", "", "", "", 2, 1, "M");//40
            p_SetSc("出库(轧制)日", "E", "", "L", "", "", "", 2, 1,"M");//41
            p_SetSc("班次", "E", "", "L", "", "", "", 2, 1, "M");//42
            p_SetSc("班别", "E", "", "L", "", "", "", 2, 1, "M");//43
            p_SetSc("转库日", "E", "", "L", "", "", "", 2, 1,"M");//44

            p_SetSc("班次", "E", "", "L", "", "", "", 2, 1, "M");//45
            p_SetSc("班别", "E", "", "L", "", "", "", 2, 1, "M");//46
            p_SetSc("日期", "E", "", "L", "", "", "", 2, 1, "M");//47
            p_SetSc("时间", "E", "", "L", "", "", "", 2, 1, "M");//48
            p_SetSc("订单号", "E", "", "L", "", "", "", 2, 1, "M");//49

            p_SetSc("序列", "E", "", "L", "", "", "", 2, 1, "M");//50
            p_SetSc("UST", "E", "", "L", "", "", "", 2, 1, "M");//51
            p_SetSc("用途别", "E", "", "L", "", "", "", 2, 1, "M");//52
            p_SetSc("是否分切", "E", "", "L", "", "", "", 2, 1, "M");//53

            p_spanSpread("规格(MM)", 18, 20, 2, 0, 1);
            p_spanSpread("是否正尺", 22, 23, 2, 0, 1);
            p_spanSpread("转炉出钢", 33, 35, 2, 0, 1);
            p_spanSpread("生产", 36, 38, 2, 0, 1);
            p_spanSpread("轧钢计划编制", 39, 40, 2, 0, 1);
            p_spanSpread("出库(轧制)", 41,43, 2, 0, 1);
            p_spanSpread("转库", 44, 46, 2, 0, 1);
            p_spanSpread("发货", 47, 48, 2, 0, 1);  
        }

        private void WGA1070C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGA1050C";
            Form_Define();
            txt_cond.Text = "0";
            opt_Search0.Checked = true;
            txt_DateFrom.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1,"select to_char(sysdate,'YYYYMMDD') from dual");
            txt_DateTo.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD') from dual");
            base.i_ScCurrSeq = 1;
            this.SSTab1.SelectedIndex = 0;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            setCheckbox();
            txt_Disp_Order.Text = "";
            txt_Order.Text = "";
            txt_Disp.Text = "";
            txt_DateFrom.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD') from dual");
            txt_DateTo.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD') from dual");
            base.i_ScCurrSeq = 1;
            this.SSTab1.SelectedIndex = 0;
            list.Clear();
            sqlList.Clear();
            txt_cond.Text = "0";
            opt_Search0.Checked = true;
            return false;
        }

        private void setCheckbox()
        {
            chk_Cond0.Checked = false;
            chk_Cond1.Checked = false;
            chk_Cond2.Checked = false;
            chk_Cond3.Checked = false;
            chk_Cond4.Checked = false;
            chk_Cond5.Checked = false;
            chk_Cond6.Checked = false;
            chk_Cond7.Checked = false;
            chk_Cond8.Checked = false;
            chk_Cond9.Checked = false;
            chk_Cond10.Checked = false;
            chk_Cond11.Checked = false;
            chk_Cond12.Checked = false;
            chk_Cond13.Checked = false;
            chk_Cond14.Checked = false;
        }

        private void opt_Search0_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            txt_cond.Text = rb.Name.Substring(10, 1);

            if (txt_cond.Text == "5")
            {
                txt_DateFrom.Enabled = false;
                txt_DateTo.Enabled = false;
                txt_cur_inv_code.Text = "HB";
                txt_cur_inv.Text = "宽厚板厂";
                //Call Gp_Sp_ColHidden(ss2, SS2_INGOT_FL, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_PLAN_STLGRD, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_PLAN_STLGRD_DET, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_CC_STLGRD, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_CC_STLGRD_DET, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_REASON_CD, False)
                //Call Gp_Sp_ColHidden(ss2, SS2_EST_CD, False)
            }
            else
            {
                   txt_DateFrom.Enabled = true;
                   txt_DateTo.Enabled = true;
                   txt_cur_inv_code.Text = "";
                   txt_cur_inv.Text = "";
                //   Call Gp_Sp_ColHidden(ss2, SS2_INGOT_FL, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_PLAN_STLGRD, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_PLAN_STLGRD_DET, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_CC_STLGRD, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_CC_STLGRD_DET, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_REASON_CD, True)
                //   Call Gp_Sp_ColHidden(ss2, SS2_EST_CD, True)
            }
        }


        public override void Form_Ref()
        {
            double slabWeightSum = 0;
            double slabQualified = 0;
            double slabProtocolWeight = 0;
            double slabChangeWeight = 0;
            double slabCopingWeight = 0;
            double slabWasteWeight = 0;
            double slabUnqualifiedWeight = 0;

            double sTemp = 0;
            double sTemp1 = 0;
            double sTemp2 = 0;

            isAddColumn();
            if (base.i_ScCurrSeq == 1)
            {
                base.p_Ref(1, 1, true, true);
                for (int i = 0; i < ss1.ActiveSheet.Columns.Count; i++)
                {
                    FontFamily myFontFamily = new FontFamily("Arial");
                    Font myFont = new Font(myFontFamily, (float)9, FontStyle.Regular);
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
                    slabWasteWeight += ss1.ActiveSheet.Cells[i, list.Count + 8].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 8].Text);
                    slabUnqualifiedWeight += ss1.ActiveSheet.Cells[i, list.Count + 9].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 9].Text);

                    sTemp += ss1.ActiveSheet.Cells[i, list.Count + 2].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 2].Text);
                    sTemp1 += ss1.ActiveSheet.Cells[i, list.Count + 6].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 6].Text);
                    sTemp2 += ss1.ActiveSheet.Cells[i, list.Count + 7].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, list.Count + 7].Text);




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
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count].Text = slabWeightSum.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 1].Text = slabQualified.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 3].Text = slabProtocolWeight.ToString(); 
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 4].Text = slabChangeWeight.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 5].Text = slabCopingWeight.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 8].Text = slabWasteWeight.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 9].Text = slabUnqualifiedWeight.ToString();


                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 2].Text = sTemp.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 6].Text = sTemp1.ToString();
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.Rows.Count - 1, list.Count + 7].Text = sTemp2.ToString();


               // base.form_Activated(sender, e);
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
                GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
                GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
                GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
                GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();

            }
            else
            {
                base.p_Ref(1, 2, true, true);
                if (ss2.ActiveSheet.Rows.Count == 0) return;
                for (int i = 0; i < ss2.ActiveSheet.Rows.Count; i++)
                {
                    for (int j = 0; j < ss2.ActiveSheet.Columns.Count; j++)
                    {
                        if (ss2.ActiveSheet.Cells[i, j].Text == "0.000")
                        {
                            ss2.ActiveSheet.Cells[i, j].Text = "";
                        }
                        if (ss2.ActiveSheet.Cells[i, j].Text == "0.0")
                        {
                            ss2.ActiveSheet.Cells[i, j].Text = "";
                        }
                        if (ss2.ActiveSheet.Cells[i, j].Text == "0")
                        {
                            ss2.ActiveSheet.Cells[i, j].Text = "";
                        }
                    }
                }
                ss2.ActiveSheet.Rows.Add(ss2.ActiveSheet.Rows.Count, 1);
                ss2.ActiveSheet.RowHeader.Cells[ss2.ActiveSheet.Rows.Count - 1, 0].Text = "合计";
                double tempDouble1 = 0;
                double tempDouble2 = 0;
                double tempDouble3 = 0;
                double tempDouble4 = 0;
                for (int i = 0; i < ss2.ActiveSheet.Rows.Count; i++)
                {
                    tempDouble1 += ss2.ActiveSheet.Cells[i, 21].Text.Replace(",", "") == "" ? 0 : double.Parse(ss2.ActiveSheet.Cells[i, 21].Text.Replace(",", ""));
                    tempDouble2 += ss2.ActiveSheet.Cells[i, 22].Text.Replace(",", "") == "" ? 0 : double.Parse(ss2.ActiveSheet.Cells[i, 22].Text.Replace(",", ""));
                    tempDouble3 += ss2.ActiveSheet.Cells[i, 23].Text.Replace(",", "") == "" ? 0 : double.Parse(ss2.ActiveSheet.Cells[i, 23].Text.Replace(",", ""));
                    tempDouble4 += ss2.ActiveSheet.Cells[i, 27].Text.Replace(",", "") == "" ? 0 : double.Parse(ss2.ActiveSheet.Cells[i, 27].Text.Replace(",", ""));
                }

                ss2.ActiveSheet.Cells[ss2.ActiveSheet.Rows.Count - 1, 21].Text = tempDouble1.ToString();
                ss2.ActiveSheet.Cells[ss2.ActiveSheet.Rows.Count - 1, 22].Text = tempDouble2.ToString();
                ss2.ActiveSheet.Cells[ss2.ActiveSheet.Rows.Count - 1, 23].Text = tempDouble3.ToString();
                ss2.ActiveSheet.Cells[ss2.ActiveSheet.Rows.Count - 1, 27].Text = tempDouble4.ToString();

               // base.form_Activated(sender, e);
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
                GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
                GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
                GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
                GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();

            }

        }
        ArrayList list = new ArrayList();//用于存放checkbox的名称
        ArrayList sqlList = new ArrayList();//用于存放选择的checkbox所对应的sql条件。
        private void chk_Cond0_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string checkBoxName = checkBox.Name.Trim();
            switch (checkBoxName)
            {
                case "chk_Cond0":
                    if (this.chk_Cond0.Checked)
                    {
                        list.Add("炉号");
                        sqlList.Add(",SUBSTR(A.SLAB_NO,1,8)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("炉号");
                        sqlList.Remove(",SUBSTR(A.SLAB_NO,1,8)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond1":
                    if (this.chk_Cond1.Checked)
                    {
                        list.Add("钢种");
                        sqlList.Add(",Gf_Stlgrd_Detail(A.STLGRD)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("钢种");
                        sqlList.Remove(",Gf_Stlgrd_Detail(A.STLGRD)");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond2":
                    if (this.chk_Cond2.Checked)
                    {
                        list.Add("厚度");
                        sqlList.Add(",A.THK");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("厚度");
                        sqlList.Remove(",A.THK");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond3":
                    if (this.chk_Cond3.Checked)
                    {
                        list.Add("宽度");
                        sqlList.Add(",A.WID");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("宽度");
                        sqlList.Remove(",A.WID");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond4":
                    if (this.chk_Cond4.Checked)
                    {
                        list.Add("长度");
                        sqlList.Add(",A.LEN");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("长度");
                        sqlList.Remove(",A.LEN");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond5":
                    if (this.chk_Cond5.Checked)
                    {
                        list.Add("切割日期");      
                        sqlList.Add(",A.PROD_DATE");          
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("切割日期");
                        sqlList.Remove(",A.PROD_DATE");        
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond6":
                    if (this.chk_Cond6.Checked)
                    {
                        list.Add("堆放仓库");
                        sqlList.Add(",A.CUR_INV");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("堆放仓库");
                        sqlList.Remove(",A.CUR_INV");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond7":
                    if (this.chk_Cond7.Checked)
                    {
                        list.Add("去向");
                        sqlList.Add(",A.OUT_PLT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("去向");
                        sqlList.Remove(",A.OUT_PLT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond8":
                    if (this.chk_Cond8.Checked)
                    {
                        list.Add("轧制日期");
                        sqlList.Add(",A.OUT_PLT_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("轧制日期");
                        sqlList.Remove(",A.OUT_PLT_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond9":
                    if (this.chk_Cond9.Checked)
                    {
                        list.Add("班次");
                        sqlList.Add(",SHIFT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("班次");
                        sqlList.Remove(",SHIFT");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond10":
                    if (this.chk_Cond10.Checked)
                    {
                        list.Add("班别");
                        sqlList.Add(",GROUP_CD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("班别");
                        sqlList.Remove(",GROUP_CD");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond11":
                    if (this.chk_Cond11.Checked)
                    {
                        list.Add("转库日");
                        sqlList.Add(",Gf_AFL2100C_DATE(A.SLAB_NO,''MOVE'')");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("转库日");
                        sqlList.Remove(",Gf_AFL2100C_DATE(A.SLAB_NO,''MOVE'')");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond12":
                    if (this.chk_Cond12.Checked)
                    {
                        list.Add("转炉出钢日");
                        sqlList.Add(",Gf_AFL2100C_DATE(A.SLAB_NO,''BOF'')");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("转炉出钢日");
                        sqlList.Remove(",Gf_AFL2100C_DATE(A.SLAB_NO,''BOF'')");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond13":
                    if (this.chk_Cond13.Checked)
                    {
                        list.Add("发货日");
                        sqlList.Add(",A.SHP_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("发货日");
                        sqlList.Remove(",A.SHP_DATE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
                case "chk_Cond14":
                    if (this.chk_Cond14.Checked)
                    {
                        list.Add("连铸机号");
                        sqlList.Add(",A.PRC_LINE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    else
                    {
                        list.Remove("连铸机号");
                        sqlList.Remove(",A.PRC_LINE");
                        input_Txt_Disp_Order();
                        sqlInputPlSql();
                    }
                    break;
            }
        }

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

        public void sqlInputPlSql()
        {
            string sqlInputPlSql = "";
            for (int i = 0; i < sqlList.Count; i++)
            {
                sqlInputPlSql += sqlList[i].ToString() + " ";
            }
            txt_Order.Text = sqlInputPlSql;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                base.i_ScCurrSeq = 1;
            }
            else
            {
                base.i_ScCurrSeq = 2;
            }
        }

        public void resetSpreadColumnHeaderName()
        {
          //  p_ScIni(ss1, Sc1, 0, false, true);
            p_SetSc("块数", "N", "6", "L", "", "", "", 1, 0);//0
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 1, 0, "M");//1
            p_SetSc("定尺量", "N", "8,3", "L", "", "", "", 1, 0, "M");//2
            p_SetSc("非定尺量", "N", "8,3", "L", "", "", "", 1, 0, "M");//3
            p_SetSc("锥坯量(t)", "N", "8,3", "L", "", "", "", 1, 0);//4
            p_SetSc("异常坯量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//5
            p_SetSc("裂纹量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//6
            p_SetSc("接坯量(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//7
            p_SetSc("钢种改判(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//8
            p_SetSc("非计划(t)", "N", "8,3", "L", "", "", "", 1, 0, "M");//9
        }

        public void isAddColumn()
        {
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
                    //if (list[i].ToString() == "厚度")
                    //{
                    //    p_SetSc(list[i].ToString(), "N", "8,1", "L", "", "", "", 1, 0);//0
                    //}
                    //else if (list[i].ToString() == "宽度")
                    //{
                    //    p_SetSc(list[i].ToString(), "N", "8", "L", "", "", "", 1, 0);//0
                    //}
                    //else if (list[i].ToString() == "长度")
                    //{
                    //    p_SetSc(list[i].ToString(), "N", "8", "L", "", "", "", 1, 0);//0
                    //}
                    //else
                    //{
                        p_SetSc(list[i].ToString(), "E", "", "L", "", "", "", 1, 0);//0
                    //}
                }
                resetSpreadColumnHeaderName();
            }
        }

        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);
            GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
            GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
            GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
            GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
            GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";
            GeneralCommon.MDIToolBar.Refresh();
        }


    }
}
