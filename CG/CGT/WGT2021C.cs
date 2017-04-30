using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;

namespace CG
{
    public partial class WGT2021C : CommonClass.FORMBASE
    {
        public WGT2021C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        protected override void p_SubFormInit()
        {
            p_McIni(Mc1, false);
            p_SetMc("探伤时间", SDT_PROD_DATE_FR, "PN", "", "", "", "", 1);//0
            p_SetMc("钢种", SDT_PROD_DATE_TO, "PN", "", "", "", "", 1);//1
            p_SetMc("隐藏1", TXT_CO_CD, "P", "", "", "", "", 1);//2
            p_SetMc("CBO_GROUP", CBO_GROUP, "P", "", "", "", "", 1);//3
           

            p_ScIni(ss1, Sc1, 0, false, true);

            p_SetSc("品种", "E", "", "L", "", "", "", 1, 1,"M");//0
            p_SetSc("厚度", "E", "", "L", "", "", "", 1, 1, "M");//1
            p_SetSc("宽度", "N", "6", "L", "", "", "", 1, 1);//2
            p_SetSc("当日重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//3
            p_SetSc("月重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//4
            p_SetSc("当日块数", "N", "8", "L", "", "", "", 1, 1);//5
            p_SetSc("当月块数", "N", "8", "L", "", "", "", 1, 1);//6
            p_SetSc("当日重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//7
            p_SetSc("月重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//8
            p_SetSc("当日块数", "N", "8", "L", "", "", "", 1, 1);//9
            p_SetSc("月块数", "N", "8", "L", "", "", "", 1, 1);//10
            p_SetSc("当日重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//11
            p_SetSc("月重量(t)", "N", "8,3", "L", "", "", "", 1, 1);//12
            p_SetSc("当日块数", "N", "8", "L", "", "", "", 1, 1);//13
            p_SetSc("月块数", "N", "8", "L", "", "", "", 1, 1);//14
            p_SetSc("当日探伤合格率%", "N", "6,2", "L", "", "", "", 1, 1);//15
            p_SetSc("当月探伤合格率%", "N", "6,2", "L", "", "", "", 1, 1);//16

            p_spanSpread("合格品", 3, 6, 1, 0, 1);
            p_spanSpread("不合格品", 7, 10, 1, 0, 1);
            p_spanSpread("合计", 11, 14, 1, 0, 1);
              
        }


        private void WGT3060C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGT2021C";
            Form_Define();
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

        public override void Form_Ref()
        {
            if (p_Ref(1, 1, true, true))
            {
                Data_Sum_Edit();
                Data_Sum_Edit1();
            }
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
                    if (ss1.ActiveSheet.Cells[i, j].Text == "0")
                    {
                        ss1.ActiveSheet.Cells[i, j].Text = "";
                    }
                }
            }
        }

        private void chk_Cond_B_Click(object sender, EventArgs e)
        {
            if (this.chk_Cond_B.Checked)
            {
                TXT_CO_CD.Text = chk_Cond_B.Tag.ToString();
                chk_Cond_W.Checked = false;
                chk_Cond_N.Checked = false;
            }
            if (!chk_Cond_B.Checked && !chk_Cond_W.Checked && !chk_Cond_N.Checked)
            {
                TXT_CO_CD.Text = "";
            }
        }

        private void chk_Cond_W_Click(object sender, EventArgs e)
        {
            if (this.chk_Cond_W.Checked)
            {
                TXT_CO_CD.Text = chk_Cond_W.Tag.ToString();
                chk_Cond_B.Checked = false;
                chk_Cond_N.Checked = false;
            }
            if (!chk_Cond_B.Checked && !chk_Cond_W.Checked && !chk_Cond_N.Checked)
            {
                TXT_CO_CD.Text = "";
            }
        }

        //private void SDT_PROD_DATE_FR_DoubleClick(object sender, EventArgs e)
        //{
        //    this.SDT_PROD_DATE_FR.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(TRUNC(ADD_MONTHS(LAST_DAY(SYSDATE), -1) + 1), 'YYYYMMDD')FROM DUAL");
        //}

        private void Data_Sum_Edit()
        {
            this.ss1_Sheet1.Rows.Add(this.ss1_Sheet1.Rows.Count,1);
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 0].Text = "合计";

            double col3Count = 0;
            double col4Count = 0;
            double col5Count = 0;
            double col6Count = 0;
            double col7Count = 0;
            double col8Count = 0;
            double col9Count = 0;
            double col10Count = 0;
            double col11Count = 0;
            double col12Count = 0;
            double col13Count = 0;
            double col14Count = 0;
            double col15Count = 0;
            double col16Count = 0;
           
            for (int i = 0; i < this.ss1_Sheet1.Rows.Count;i++ )
            {
                col3Count += ss1.ActiveSheet.Cells[i, 3].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 3].Text.Replace(",", ""));
                col4Count += ss1.ActiveSheet.Cells[i, 4].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 4].Text.Replace(",", ""));
                col5Count += ss1.ActiveSheet.Cells[i, 5].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 5].Text.Replace(",", ""));
                col6Count += ss1.ActiveSheet.Cells[i, 6].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 6].Text.Replace(",", ""));
                col7Count += ss1.ActiveSheet.Cells[i, 7].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 7].Text.Replace(",", ""));
                col8Count += ss1.ActiveSheet.Cells[i, 8].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 8].Text.Replace(",", ""));
                col9Count += ss1.ActiveSheet.Cells[i, 9].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 9].Text.Replace(",", ""));
                col10Count += ss1.ActiveSheet.Cells[i, 10].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 10].Text.Replace(",", ""));
                col11Count += ss1.ActiveSheet.Cells[i, 11].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 11].Text.Replace(",", ""));
                col12Count += ss1.ActiveSheet.Cells[i, 12].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 12].Text.Replace(",", ""));
                col13Count += ss1.ActiveSheet.Cells[i, 13].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 13].Text.Replace(",", ""));
                col14Count += ss1.ActiveSheet.Cells[i, 14].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 14].Text.Replace(",", ""));
                col15Count += ss1.ActiveSheet.Cells[i, 15].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 15].Text.Replace(",", ""));
                col16Count += ss1.ActiveSheet.Cells[i, 16].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 16].Text.Replace(",", ""));
            }

            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 3].Text = col3Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 4].Text = col4Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 5].Text = col5Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 6].Text = col6Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 7].Text = col7Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 8].Text = col8Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 9].Text = col9Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 10].Text = col10Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 11].Text = col11Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 12].Text = col12Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 13].Text = col13Count.ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 14].Text = col14Count.ToString();
            //this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 15].Text = (col15Count / (this.ss1_Sheet1.Rows.Count - 1)).ToString();
            //this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 16].Text = (col16Count / (this.ss1_Sheet1.Rows.Count - 1)).ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 15].Text = col3Count / col11Count * 100 + "";//(col15Count / (this.ss1_Sheet1.Rows.Count - 1)).ToString();
            this.ss1_Sheet1.Cells[this.ss1_Sheet1.Rows.Count - 1, 16].Text = col4Count / col12Count * 100 + "";//(col16Count / (this.ss1_Sheet1.Rows.Count - 1)).ToString();
        }

        private void Data_Sum_Edit1()
        {
            double col3Count = 0;
            double col4Count = 0;
            double col5Count = 0;
            double col6Count = 0;
            double col7Count = 0;
            double col8Count = 0;
            double col9Count = 0;
            double col10Count = 0;
            double col11Count = 0;
            double col12Count = 0;
            double col13Count = 0;
            double col14Count = 0;
            double col15Count = 0;
            double col16Count = 0;
            string temp = "";
            int count = 1;
            for (int i = 0; i < this.ss1_Sheet1.Rows.Count - 1; i++)
            {
                temp = this.ss1_Sheet1.Cells[i, 0].Text;
                if (this.ss1_Sheet1.Rows.Get(i).Tag == "new") continue;
                col3Count += ss1.ActiveSheet.Cells[i, 3].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 3].Text.Replace(",", ""));
                col4Count += ss1.ActiveSheet.Cells[i, 4].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 4].Text.Replace(",", ""));
                col5Count += ss1.ActiveSheet.Cells[i, 5].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 5].Text.Replace(",", ""));
                col6Count += ss1.ActiveSheet.Cells[i, 6].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 6].Text.Replace(",", ""));
                col7Count += ss1.ActiveSheet.Cells[i, 7].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 7].Text.Replace(",", ""));
                col8Count += ss1.ActiveSheet.Cells[i, 8].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 8].Text.Replace(",", ""));
                col9Count += ss1.ActiveSheet.Cells[i, 9].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 9].Text.Replace(",", ""));
                col10Count += ss1.ActiveSheet.Cells[i, 10].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 10].Text.Replace(",", ""));
                col11Count += ss1.ActiveSheet.Cells[i, 11].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 11].Text.Replace(",", ""));
                col12Count += ss1.ActiveSheet.Cells[i, 12].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 12].Text.Replace(",", ""));
                col13Count += ss1.ActiveSheet.Cells[i, 13].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 13].Text.Replace(",", ""));
                col14Count += ss1.ActiveSheet.Cells[i, 14].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 14].Text.Replace(",", ""));
                col15Count += ss1.ActiveSheet.Cells[i, 15].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 15].Text.Replace(",", ""));
                col16Count += ss1.ActiveSheet.Cells[i, 16].Text.Replace(",", "") == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 16].Text.Replace(",", ""));

                if (temp == this.ss1_Sheet1.Cells[i + 1, 0].Text)
                {
                    count++;
                }
                else
                {
                    this.ss1_Sheet1.Rows.Add(i + 1, 1);
                    this.ss1_Sheet1.Rows.Get(i + 1).Tag = "new";
                    this.ss1_Sheet1.Cells[i + 1, 0].Text = temp;
                    this.ss1_Sheet1.Cells[i + 1, 1].Text = "小计";
                    this.ss1_Sheet1.Cells[i + 1, 3].Text = col3Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 4].Text = col4Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 5].Text = col5Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 6].Text = col6Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 7].Text = col7Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 8].Text = col8Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 9].Text = col9Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 10].Text = col10Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 11].Text = col11Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 12].Text = col12Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 13].Text = col13Count.ToString();
                    this.ss1_Sheet1.Cells[i + 1, 14].Text = col14Count.ToString();

                    float TEMP1 = 0; float TEMP2 = 0;
                    if (col11Count == 0.0)
                        TEMP1 = 0;
                    else
                        TEMP1 = (float)(col3Count / col11Count);

                    if (col12Count == 0.0)
                        TEMP2 = 0;
                    else
                        TEMP2 = (float)(col4Count / col12Count);      
                    
                    this.ss1_Sheet1.Cells[i + 1, 15].Text = (TEMP1*100).ToString();
                    this.ss1_Sheet1.Cells[i + 1, 16].Text = (TEMP2*100).ToString();
                 
                    count = 1;
                    col3Count = 0;
                    col4Count = 0;
                    col5Count = 0;
                    col6Count = 0;
                    col7Count = 0;
                    col8Count = 0;
                    col9Count = 0;
                    col10Count = 0;
                    col11Count = 0;
                    col12Count = 0;
                    col13Count = 0;
                    col14Count = 0;
                    col15Count = 0;
                    col16Count = 0;
                }
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
