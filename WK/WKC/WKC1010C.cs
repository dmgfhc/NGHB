using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;

namespace WK
{
    public partial class WKC1010C : CommonClass.FORMBASE
    {
        public WKC1010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        //Collection Sc2 = new Collection();

        TextBox txt_UserId = new TextBox();

        protected override void p_SubFormInit()
        {
            p_McIni(Mc1, true);

            p_SetMc("计划年月", SDT_PLAN_DATE, "PIN", "7", "", "", "", 1);


            p_SetMc("轧钢产品成材率", sdb_Prod_Rate, "IR", "", "", "", "", 1);


            p_SetMc("轧钢机械", sdb_MILL_MACH, "IR", "", "", "", "", 1);
          
            p_SetMc("轧钢电气", sdb_MILL_ELECT, "IR", "", "", "", "", 1);
           
            p_SetMc("轧钢操作", sdb_MILL_OPER, "IR", "", "", "", "", 1);
         
            p_SetMc("轧钢", sdb_MILL_PLAN, "IR", "", "", "", "", 1);
        
            p_SetMc("轧钢2", sdb_MILL_NON_PLAN, "IR", "", "", "", "", 1);
      
    
            //p_SetMc("年计划钢产量", sdb_sms_wgt, "R", "", "", "", "", 1);
            //p_SetMc("月计划钢产量", sdb_Mon_sms_wgt, "R", "", "", "", "", 1);
            p_SetMc("年目标生产量", sdb_prod_wgt, "IR", "", "", "", "", 1);
            p_SetMc("月目标生产量", sdb_Mon_prod_wgt, "IR", "", "", "", "", 1);

            p_SetMc("录入人员", txt_UserId, "IR", "", "", "", "", 1);

            p_ScIni(ss1, Sc1, 0, false, true);

            p_SetSc("日程", "E", "", "L", "", "", "", 1, 1, "M");//0
            p_SetSc("星期", "E", "", "L", "", "", "", 1, 1, "M");//1
            p_SetSc("A", "N", "8", "I", "", "", "", 1, 1);//2
            p_SetSc("B", "N", "8", "I", "", "", "", 1, 1);//3
            p_SetSc("C", "N", "8", "I", "", "", "", 1, 1);//4     
            p_SetSc("D", "N", "8", "I", "", "", "", 1, 1);//5
            p_SetSc("小计", "N", "10", "L", "", "", "", 1, 1, "M");//6

            p_SetSc("A", "N", "8", "I", "", "", "", 1, 1);//7
            p_SetSc("B", "N", "8", "I", "", "", "", 1, 1);//8
            p_SetSc("C", "N", "8", "I", "", "", "", 1, 1);//9     
            p_SetSc("D", "N", "8", "I", "", "", "", 1, 1);//10
            p_SetSc("小计", "N", "10", "L", "", "", "", 1, 1, "M");//11

            p_SetSc("A", "N", "8", "I", "", "", "", 1, 1);//12
            p_SetSc("B", "N", "8", "I", "", "", "", 1, 1);//13
            p_SetSc("C", "N", "8", "I", "", "", "", 1, 1);//14     
            p_SetSc("D", "N", "8", "I", "", "", "", 1, 1);//15
            p_SetSc("小计", "N", "10", "L", "", "", "", 1, 1, "M");//16

            p_SetSc("记录人", "E", "8", "ILA", "", "", "", 1, 1);//17
            p_SetSc("操作日期", "E", "", "ILA", "", "", "", 1, 1);//18

            p_spanSpread("班次(Min)", 2, 6, 1, 0, 1);
            p_spanSpread("热处理量(吨)", 7, 11, 1, 0, 1);
            p_spanSpread("产量(吨)", 12, 16, 1, 0, 1);
          
          
        }

        private void WKC1010C_Load(object sender, EventArgs e)
        {
            Form_Define();

            this.ss1_Sheet1.Columns[0].Width = 40;
            this.ss1_Sheet1.Columns[0].Resizable = false;
            this.ss1_Sheet1.Columns[1].Width = 50;
            this.ss1_Sheet1.Columns[1].Resizable = false;

            txt_UserId.Text = GeneralCommon.sUserID;
           
        }

        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);
            setMdiWindowsBar();
            GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList2.Images[9];
            GeneralCommon.MDIToolBar.Buttons[13].Tag = "F";
            GeneralCommon.MDIToolBar.Refresh();
        }


        public override void Form_Ref()
        {
            if (this.SDT_PLAN_DATE.Text.Replace("-", "").Trim() == "" || this.SDT_PLAN_DATE.Text.Replace("-", "").Trim().Length != 6)
            {
                GeneralCommon.Gp_MsgBoxDisplay("日期不正确...!!","W","警告");
                return;
            }
            MasterCommon.Gp_Ms_Cls((Collection)((Collection)Proc_Mc[1])["rControl"]);
            MasterCommon.Gf_Ms_Refer(GeneralCommon.M_CN1, (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], false);
            if (SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[1], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], true))
            {
                this.ss1_Sheet1.Rows.Add(this.ss1_Sheet1.Rows.Count, 1);
                this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 0].Text = "合计";

                setSumCountLastRow();

                setZeroSpread();

                setWeekSpread();

                setMdiWindowsBar();
            }
            else
            {
                string YearAndMon = this.SDT_PLAN_DATE.Text;
                string[] YserMon = YearAndMon.Split('-');
                int dateCount = DateTime.DaysInMonth(int.Parse(YserMon[0]), int.Parse(YserMon[1]));
                this.ss1_Sheet1.RowCount = dateCount;
                this.ss1_Sheet1.Rows.Add(this.ss1_Sheet1.Rows.Count, 1);
                this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 0].Text = "合计";
                int j = 1;
                for (int i = 0; i < this.ss1_Sheet1.RowCount - 1; i++,j++)
                {
                    this.ss1_Sheet1.Cells[i, 0].Text = (j < 10 ? (0 + j.ToString()) : j.ToString());
                }
                setWeekSpread();
                setMdiWindowsBar();
            }
        }

        public override bool Form_Cls()
        {
             base.Form_Cls();
             setMdiWindowsBar();
             GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList2.Images[9];
             GeneralCommon.MDIToolBar.Buttons[13].Tag = "F";
             GeneralCommon.MDIToolBar.Refresh();
             return true;
        }

        public override void Form_Pro()
        {
            if (this.ss1_Sheet1.RowCount <= 0) return;
            int j = 1;
            for (int i = 0; i < this.ss1_Sheet1.Rows.Count - 1;i++ )
            {
                this.ss1_Sheet1.RowHeader.Cells[i, 0].Text = "修改";
                this.ss1_Sheet1.Cells[i, 17].Text = GeneralCommon.sUserID;
                this.ss1_Sheet1.Cells[i, 18].Text = this.SDT_PLAN_DATE.Text.Replace("-","") + (j < 10 ? (0 + j.ToString()) : j.ToString());
                j++;
            }
            if (p_Pro(1, 1, true, false))
                Form_Ref();
        }

        private void setSumCountLastRow()
        {
            if (this.ss1_Sheet1.RowCount <= 0) return;
            for (int i = 0; i < this.ss1_Sheet1.Columns.Count; i++)
            {
                int temp = 0;
                if (i == 0 || i == 1 || i == 17 || i == 18) continue;
                for (int j = 0; j < this.ss1_Sheet1.Rows.Count - 1; j++)
                {                 
                    temp = temp + int.Parse(this.ss1_Sheet1.Cells[j, i].Text.Replace(",","") == "" ? "0" : this.ss1_Sheet1.Cells[j, i].Text.Replace(",",""));
                }
                this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, i].Text = temp.ToString();
            }
        }

        private void setZeroSpread()
        {
            if (this.ss1_Sheet1.RowCount <= 0) return;
            for (int i = 0; i < this.ss1_Sheet1.Rows.Count;i++ )
            {
                for (int j = 0; j < this.ss1_Sheet1.Columns.Count; j++)
                {
                    this.ss1_Sheet1.Cells[i, j].Text = this.ss1_Sheet1.Cells[i, j].Text == "0" ? "" : this.ss1_Sheet1.Cells[i, j].Text;
                }
            }
        }

        private void setWeekSpread()
        {
            string YearAndMon = this.SDT_PLAN_DATE.Text;
            string[] YserMon = YearAndMon.Split('-');
            for (int i = 0; i < this.ss1_Sheet1.RowCount - 1; i++)
            {
                DateTime DT = new DateTime(Int32.Parse(YserMon[0]), Int32.Parse(YserMon[1]), Int32.Parse(this.ss1_Sheet1.Cells[i,0].Text.ToString()));
                DayOfWeek DW = DT.DayOfWeek;
                this.ss1_Sheet1.Cells[i, 1].Text = Week(DW);
            }
        }


        private string Week(DayOfWeek dw)
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(dw)];
            return week;
        }

        protected override void ss_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            int SumIndex = -1;
            if (e.Column >= 2 && e.Column <= 5)
                SumIndex = 6;
            else if (e.Column >= 7 && e.Column <= 10)
                SumIndex = 11;
            else
                SumIndex = 16;
            this.ss1_Sheet1.Cells[e.Row, SumIndex].Text = (int.Parse(this.ss1_Sheet1.Cells[e.Row, SumIndex - 1].Text == "" ? "0" : this.ss1_Sheet1.Cells[e.Row, SumIndex - 1].Text.Replace(",", "")) + int.Parse(this.ss1_Sheet1.Cells[e.Row, SumIndex - 2].Text == "" ? "0" : this.ss1_Sheet1.Cells[e.Row, SumIndex - 2].Text.Replace(",", "")) + int.Parse(this.ss1_Sheet1.Cells[e.Row, SumIndex - 3].Text == "" ? "0" : this.ss1_Sheet1.Cells[e.Row, SumIndex - 3].Text.Replace(",", "")) + int.Parse(this.ss1_Sheet1.Cells[e.Row, SumIndex - 4].Text == "" ? "0" : this.ss1_Sheet1.Cells[e.Row, SumIndex - 4].Text.Replace(",", ""))).ToString();
            setSumCountLastRow();
        }


        private void setMdiWindowsBar()
        {
            GeneralCommon.ImageList0.Images[3] = GeneralCommon.ImageList2.Images[3];
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
            GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList1.Images[9];
            GeneralCommon.MDIToolBar.Buttons[13].Tag = "T";
            GeneralCommon.MDIToolBar.Refresh();
        }

        


    }
}
