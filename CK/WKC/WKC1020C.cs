using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace CK
{
    public partial class WKC1020C : CommonClass.FORMBASE
    {
        public WKC1020C()
        {
            InitializeComponent();
            myFontFamily = new FontFamily("宋体");
            myFont = new System.Drawing.Font(myFontFamily, (float)12.5, FontStyle.Bold);
            myFontSpread4 = new System.Drawing.Font(myFontFamily, (float)9.5, FontStyle.Bold);
            myFontSpread6 = new System.Drawing.Font(myFontFamily, (float)20.5, FontStyle.Bold);
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();


        Collection Sc5 = new Collection();

        FontFamily myFontFamily = null;
        System.Drawing.Font myFont = null;
        System.Drawing.Font myFontSpread4 = null;
        System.Drawing.Font myFontSpread6 = null;
        object[,] ArrayRecordsSpread4ColumnHeaderName = null;
        object[,] ArrayRecordsSpread4 = null;
        object[,] ArrayRecordsSpread4Retail = null;
        object[,] ArrayRecordsSpread4HC = null;
        object[,] ArrayRecordsSpread4RetailHC = null;

        protected override void p_SubFormInit()
        {
            int imcseq;
            imcseq = 1;
            p_McIni(Mc1, false);
            p_SetMc("日期", txt_DATE, "PN", "", "", "", "", 1);
            p_SetMc(CBO_PLT, "PN", "", "", "", 1, "");


            p_ScIni(ss1, Sc1, 0, false, false);

            p_SetSc("计划产量", "N", "10", "L", "", "", "", 1, 1);//0
            p_SetSc("轧制产量", "N", "10,3", "L", "", "", "", 1, 1);//1
            p_SetSc("原料量", "N", "10,3", "L", "", "", "", 1, 1);//2
            p_SetSc("轧制块数", "N", "10", "L", "", "", "", 1, 1);//3
            p_SetSc("剪切产量", "N", "10,3", "L", "", "", "", 1, 1);//4

            p_SetSc("剪切块数", "N", "10", "L", "", "", "", 1, 1);//5
            p_SetSc("轧制未剪切量", "N", "10,3", "L", "", "", "", 1, 1);//6
            p_SetSc("中废", "N", "10,3", "L", "", "", "", 1, 1);//7
            p_SetSc("检验废", "N", "10,3", "L", "", "", "", 1, 1);//8
            p_SetSc("性能判废", "N", "10,3", "L", "", "", "", 1, 1);//9

            p_SetSc("待判", "N", "10,3", "L", "", "", "", 1, 1);//10
            p_SetSc("设计成材率", "N", "10,2", "L", "", "", "", 1, 1);//11
            p_SetSc("实际成材率", "N", "10,2", "L", "", "", "", 1, 1);//12  
            p_SetSc("热装量", "N", "10,3", "L", "", "", "", 1, 1);//13
            p_SetSc("热送量", "N", "10,3", "L", "", "", "", 1, 1);//14

            p_SetSc("负公差", "N", "10,3", "L", "", "", "", 1, 1);//15
            p_SetSc("其他协议", "N", "10,3", "L", "", "", "", 1, 1);//16
            p_SetSc("改判", "N", "10,3", "L", "", "", "", 1, 1);//17
            p_SetSc("总量", "N", "10,3", "L", "", "", "", 1, 1);//18
            p_SetSc("已判ERP非计划", "N", "10,3", "L", "", "", "", 1, 1);//19

            p_SetSc("重量", "N", "10,3", "L", "", "", "", 1, 1);//20
            p_SetSc("块数", "N", "10", "L", "", "", "", 1, 1);//21

            p_spanSpread("废次品", 7, 9, 1, 0, 1);
            // p_spanSpread("成材率", 13, 15, 1, 0, 1);
            p_spanSpread("非计划", 16, 19, 1, 0, 1);
            p_spanSpread("回炉", 20, 21, 1, 0, 1);



            p_ScIni(ss2, Sc2, 0, false, false);

            p_SetSc("日历作业率", "N", "6,2", "L", "", "", "", 2, 1);//0
            p_SetSc("有效作业率", "N", "6,2", "L", "", "", "", 2, 1);//1
            p_SetSc("机时产量", "N", "10,3", "L", "", "", "", 2, 1);//2
            p_SetSc("煤气消耗", "N", "10,3", "L", "", "", "", 2, 1);//3
            p_SetSc("电消耗", "N", "6,3", "L", "", "", "", 2, 1);//4

            p_SetSc("水消耗", "N", "10,3", "L", "", "", "", 2, 1);//5
            p_SetSc("蒸汽回收量", "N", "10,3", "L", "", "", "", 2, 1);//6
            p_SetSc("氮气", "N", "10,3", "L", "", "", "", 2, 1);//7
            p_SetSc("管道氧气", "N", "6", "L", "", "", "", 2, 1);//8
            p_SetSc("计划", "N", "10", "L", "", "", "", 2, 1);//9

            p_SetSc("机械", "N", "10", "L", "", "", "", 2, 1);//10
            p_SetSc("电气", "N", "10", "L", "", "", "", 2, 1);//11
            p_SetSc("操作", "N", "6", "L", "", "", "", 2, 1);//12 
            p_SetSc("外部", "N", "10,3", "L", "", "", "", 2, 1);//13

            p_spanSpread("轧钢故障停时", 9, 13, 2, 0, 1);


            p_ScIni(ss3, Sc3, 0, false, false);
            p_ScIni(ss4, Sc4, 0, false, false);


            p_ScIni(ss5, Sc5, 0, false, false);

            p_SetSc("块数", "N", "8", "L", "", "", "", 5, 1);//0
            p_SetSc("吨位", "N", "10,3", "L", "", "", "", 5, 1);//1
            p_SetSc("块数", "N", "8", "L", "", "", "", 5, 1);//2
            p_SetSc("吨位", "N", "10,3", "L", "", "", "", 5, 1);//3
            p_SetSc("块数(厚板)", "N", "8", "L", "", "", "", 5, 1);//4

            p_SetSc("吨位(厚板)", "N", "10,3", "L", "", "", "", 5, 1);//5
            p_SetSc("块数(在线)", "N", "8", "L", "", "", "", 5, 1);//6
            p_SetSc("吨位(在线)", "N", "10,3", "L", "", "", "", 5, 1);//7
            p_SetSc("块数(厚板)", "N", "8", "L", "", "", "", 5, 1);//8
            p_SetSc("吨位(厚板)", "N", "10,3", "L", "", "", "", 5, 1);//9

            p_SetSc("块数(在线)", "N", "8", "L", "", "", "", 5, 1);//10
            p_SetSc("吨位(在线)", "N", "10,3", "L", "", "", "", 5, 1);//11

            p_spanSpread("下线", 0, 1, 5, 0, 1);
            p_spanSpread("已完成", 2, 3, 5, 0, 1);
            p_spanSpread("待处理(本月)", 4, 7, 5, 0, 1);
            p_spanSpread("待处理(累计)", 8, 11, 5, 0, 1);

        }



        private void WKC1020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WKC1020C";
            Form_Define();
            txt_DATE.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate-1,'YYYYMMDD') from dual");
            CBO_PLT.Text = "C2";
            setSpreadColumnAndRow(ss1);
            setSpreadColumnAndRow(ss2);
            setSpread3ColumnAndRow();
            setSpread5ColumnAndRow(ss5);
            setMdiWindowsBar();
        }
        public override bool Form_Cls()
        {
            //txt_DATE.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate-1,'YYYYMMDD') from dual");
            CBO_PLT.Text = "C2";
            this.ss1_Sheet1.RowCount = 0;
            this.ss2_Sheet1.RowCount = 0;
            this.ss3_Sheet1.RowCount = 0;
            this.ss5_Sheet1.RowCount = 0;

            setSpreadColumnAndRow(ss1);
            setSpreadColumnAndRow(ss2);
            setSpread3ColumnAndRow();
            setSpread5ColumnAndRow(ss5);
            setMdiWindowsBar();
            return true;
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
            GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList1.Images[9];
            GeneralCommon.MDIToolBar.Buttons[13].Tag = "T";
            GeneralCommon.MDIToolBar.Refresh();
        }
        private void setSpreadColumnAndRow(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.ActiveSheet.RowCount = 10;
            spread.ActiveSheet.RowHeader.ColumnCount = 2;
            spread.ActiveSheet.RowHeader.Cells[0, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[1, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[2, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[3, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[4, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[5, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[6, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[7, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[8, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[9, 1].Text = "累计";
            spread.ActiveSheet.AddRowHeaderSpanCell(0, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            spread.ActiveSheet.AddRowHeaderSpanCell(2, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[2, 0].Text = "乙";
            spread.ActiveSheet.AddRowHeaderSpanCell(4, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[4, 0].Text = "丙";
            spread.ActiveSheet.AddRowHeaderSpanCell(6, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[6, 0].Text = "丁";
            spread.ActiveSheet.AddRowHeaderSpanCell(8, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[8, 0].Text = "全厂";
            //spread.ActiveSheet.RowHeader.Cells[8, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[6, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[4, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[2, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[0, 0].Font = myFont;

            for (int i = 0; i < spread.ActiveSheet.Rows.Count; i++)
            {
                spread.ActiveSheet.Rows[i].Resizable = false;
            }
        }
        private void setSpread3ColumnAndRow()
        {
            this.ss3_Sheet1.RowHeader.Visible = false;
            this.ss3_Sheet1.RowCount = 10;
            this.ss3_Sheet1.Columns.Count = 13;
            this.ss3_Sheet1.ColumnHeader.RowCount = 2;
            this.ss3_Sheet1.ColumnHeader.Rows[0].Height = 22;
            for (int i = 0; i < this.ss3_Sheet1.Columns.Count; i++)
            {
                this.ss3_Sheet1.Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                this.ss3_Sheet1.Columns[i].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                this.ss3_Sheet1.Columns[i].Resizable = false;
            }
            ss3.ActiveSheet.AddColumnHeaderSpanCell(0, 0, 2, 7);
            ss3.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "综合情况";
            ss3.ActiveSheet.ColumnHeader.Cells[0, 0].BackColor = Color.PowderBlue;
            ss3.ActiveSheet.AddColumnHeaderSpanCell(0, 7, 2, 13);
            ss3.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "自产废钢";
            ss3.ActiveSheet.ColumnHeader.Cells[0, 7].BackColor = Color.PowderBlue;
            ss3.ActiveSheet.ColumnHeader.Cells[0, 0].Font = myFont;
            ss3.ActiveSheet.ColumnHeader.Cells[0, 7].Font = myFont;

            this.ss3_Sheet1.Columns[0].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Columns[0].Width = 110;
            this.ss3_Sheet1.Columns[0].Locked = true;
            this.ss3_Sheet1.Cells[0, 0].Text = "月计划材产量";
            this.ss3_Sheet1.Cells[1, 0].Text = "已完成材产量";
            this.ss3_Sheet1.Cells[2, 0].Text = "月平均日产";
            this.ss3_Sheet1.Cells[3, 0].Text = "月预计产量";
            this.ss3_Sheet1.Cells[4, 0].Text = "月剩余天数";
            this.ss3_Sheet1.Cells[5, 0].Text = "日需均产";
            this.ss3_Sheet1.Cells[6, 0].Text = "日历进度";
            this.ss3_Sheet1.Cells[7, 0].Text = "产量进度";
            this.ss3_Sheet1.Cells[8, 0].Text = "当日经销入库";
            this.ss3_Sheet1.Cells[9, 0].Text = "当月经销入库";

            this.ss3_Sheet1.Columns[1].Width = 100;

            this.ss3_Sheet1.Columns[2].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Columns[2].Width = 110;
            this.ss3_Sheet1.Columns[2].Locked = true;
            this.ss3_Sheet1.Cells[0, 2].Text = "年计划材产量";
            this.ss3_Sheet1.Cells[1, 2].Text = "已完成材产量";
            this.ss3_Sheet1.Cells[2, 2].Text = "年平均日产";
            this.ss3_Sheet1.Cells[3, 2].Text = "年预计产量";
            this.ss3_Sheet1.Cells[4, 2].Text = "年剩余天数";
            this.ss3_Sheet1.Cells[5, 2].Text = "日需均产";
            this.ss3_Sheet1.Cells[6, 2].Text = "日历进度";
            this.ss3_Sheet1.Cells[7, 2].Text = "产量进度";
            this.ss3_Sheet1.Cells[8, 2].Text = "当日毛利";
            this.ss3_Sheet1.Cells[9, 2].Text = "当月毛利";

            this.ss3_Sheet1.Columns[3].Width = 110;

            this.ss3_Sheet1.Columns[4].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Columns[4].Width = 90;
            this.ss3_Sheet1.Columns[4].Locked = true;
            this.ss3_Sheet1.Cells[0, 4].Text = "滚动非计划";
            this.ss3_Sheet1.Cells[1, 4].Text = "改判";
            this.ss3_Sheet1.Cells[2, 4].Text = "协议";
            this.ss3_Sheet1.Cells[3, 4].Text = "正品";
            this.ss3_Sheet1.Cells[4, 4].Text = "合计";
            this.ss3_Sheet1.Cells[5, 4].Text = "待切割总量";
            this.ss3_Sheet1.Cells[6, 4].Text = "待矫直总量";
            this.ss3_Sheet1.Cells[7, 4].Text = "待正火总量";
            this.ss3_Sheet1.Cells[8, 4].Text = "待回火总量";
            this.ss3_Sheet1.Cells[9, 4].Text = "待淬火总量";

            this.ss3_Sheet1.Columns[5].Width = 90;
            this.ss3_Sheet1.Cells[0, 5].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 5].Text = "当日";
            this.ss3_Sheet1.Cells[0, 5].Locked = true;

            this.ss3_Sheet1.Columns[6].Width = 90;
            this.ss3_Sheet1.Cells[0, 6].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 6].Text = "累计";
            this.ss3_Sheet1.Cells[0, 6].Locked = true;

            this.ss3_Sheet1.Columns[7].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Columns[7].Width = 120;
            this.ss3_Sheet1.Columns[7].Locked = true;
            this.ss3_Sheet1.Cells[0, 7].Text = "种类";
            this.ss3_Sheet1.Cells[1, 7].Text = "边丝场地边丝";
            this.ss3_Sheet1.Cells[2, 7].Text = "边丝场地板切头";
            this.ss3_Sheet1.Cells[3, 7].Text = "热轧飞剪板切头";
            this.ss3_Sheet1.Cells[4, 7].Text = "热轧中废";

            this.ss3_Sheet1.Cells[5, 7].Text = "精整分段剪板切头";
            this.ss3_Sheet1.Cells[6, 7].Text = "精整检验废";
            this.ss3_Sheet1.Cells[7, 7].Text = "精整中废";
            this.ss3_Sheet1.Cells[8, 7].Text = "热处理板切头";

            this.ss3_Sheet1.Columns[8].Width = 70;
            this.ss3_Sheet1.Cells[0, 8].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 8].Text = "当日";
            this.ss3_Sheet1.Cells[0, 8].Locked = true;

            this.ss3_Sheet1.Columns[9].Width = 90;
            this.ss3_Sheet1.Cells[0, 9].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 9].Text = "累计";
            this.ss3_Sheet1.Cells[0, 9].Locked = true;

            this.ss3_Sheet1.Columns[10].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Columns[10].Width = 120;
            this.ss3_Sheet1.Columns[10].Locked = true;
            this.ss3_Sheet1.Cells[0, 10].Text = "种类";
            this.ss3_Sheet1.Cells[1, 10].Text = "热处理检验废";
            this.ss3_Sheet1.Cells[2, 10].Text = "外销次品";
            //this.ss3_Sheet1.Cells[2, 10].Text = "钢制报废备件";
            //this.ss3_Sheet1.Cells[3, 10].Text = "切割渣";
            this.ss3_Sheet1.Cells[3, 10].Text = "合计";
            //this.ss3_Sheet1.Cells[5, 10].Text = "判废量";


            this.ss3_Sheet1.Columns[11].Width = 70;
            this.ss3_Sheet1.Cells[0, 11].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 11].Text = "当日";
            this.ss3_Sheet1.Cells[0, 11].Locked = true;

            this.ss3_Sheet1.Columns[12].Width = 90;
            this.ss3_Sheet1.Cells[0, 12].BackColor = Color.PowderBlue;
            this.ss3_Sheet1.Cells[0, 12].Text = "累计";
            this.ss3_Sheet1.Cells[0, 12].Locked = true;
        }

        private void setSpread5ColumnAndRow(FarPoint.Win.Spread.FpSpread spread)
        {

            spread.ActiveSheet.RowCount = 6;
            spread.ActiveSheet.RowHeader.ColumnCount = 2;
            spread.ActiveSheet.RowHeader.Cells[0, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[1, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[2, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[3, 1].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[4, 1].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[5, 1].Text = "累计";

            spread.ActiveSheet.AddRowHeaderSpanCell(0, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[0, 0].Text = "切割";
            spread.ActiveSheet.AddRowHeaderSpanCell(2, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[2, 0].Text = "探伤";
            spread.ActiveSheet.AddRowHeaderSpanCell(4, 0, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[4, 0].Text = "热处理";

            //spread.ActiveSheet.RowHeader.Cells[4, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[2, 0].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[0, 0].Font = myFont;


            for (int i = 0; i < spread.ActiveSheet.Rows.Count; i++)
            {
                spread.ActiveSheet.Rows[i].Resizable = false;
            }
        }

        private void setSpread6ColumnAndRow(FarPoint.Win.Spread.FpSpread spread)
        {

            spread.ActiveSheet.RowCount = 10;
            spread.ActiveSheet.RowHeader.ColumnCount = 3;
            spread.ActiveSheet.RowHeader.Cells[0, 2].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[1, 2].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[2, 2].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[3, 2].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[4, 2].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[5, 2].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[6, 2].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[7, 2].Text = "累计";
            spread.ActiveSheet.RowHeader.Cells[8, 2].Text = "当日";
            spread.ActiveSheet.RowHeader.Cells[9, 2].Text = "累计";


            spread.ActiveSheet.AddRowHeaderSpanCell(0, 1, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[0, 1].Text = "甲";
            spread.ActiveSheet.AddRowHeaderSpanCell(2, 1, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[2, 1].Text = "乙";
            spread.ActiveSheet.AddRowHeaderSpanCell(4, 1, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[4, 1].Text = "丙";
            spread.ActiveSheet.AddRowHeaderSpanCell(6, 1, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[6, 1].Text = "丁";
            spread.ActiveSheet.AddRowHeaderSpanCell(8, 1, 2, 1);
            spread.ActiveSheet.RowHeader.Cells[8, 1].Text = "全厂";

            spread.ActiveSheet.AddRowHeaderSpanCell(0, 0, 10, 1);
            spread.ActiveSheet.RowHeader.Cells[0, 0].Text = "库存总况";

            //spread.ActiveSheet.RowHeader.Cells[8, 1].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[6, 1].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[4, 1].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[2, 1].Font = myFont;
            //spread.ActiveSheet.RowHeader.Cells[0, 1].Font = myFont;

            spread.ActiveSheet.RowHeader.Cells[0, 0].Font = myFont;

            for (int i = 0; i < spread.ActiveSheet.Rows.Count; i++)
            {
                spread.ActiveSheet.Rows[i].Resizable = false;
            }
        }

      

        public override void Form_Ref()
        {
            Form_Cls();
            SearchSpreadData("{CALL WKC1020C.SearchSpread1Data('" + this.txt_DATE.RawDate + "','" + this.CBO_PLT.Text + "'}", this.ss1);//Spread1表单查询

            SearchSpreadData("{CALL WKC1020C.SearchSpread2Data('" + this.txt_DATE.RawDate + "','" + this.CBO_PLT.Text + "'}", this.ss2);//Spread2表单查询
            SearchSpread3Data();//Spread3表单查询
            //    SearchSpreadData("{CALL WKC1020C.SearchSpread5Data('" + this.txt_DATE.RawDate + "','" + this.CBO_PLT.Text + "'}", this.ss5);//Spread5表单查询
            setMdiWindowsBar();
        }






        private bool SearchSpreadData(string sQuery, FarPoint.Win.Spread.FpSpread sPread)
        {
            bool isHaveData = false;

            if (GeneralCommon.M_CN1.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return isHaveData;
                }
            }

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (AdoRs.EOF || AdoRs.BOF)
                {
                    AdoRs.Close();
                    GeneralCommon.M_CN1.Close();
                    return isHaveData;
                }
                while (!AdoRs.EOF)
                {
                    if (sPread.Name == "ss1" || sPread.Name == "ss2" || sPread.Name == "ss6")
                    {
                        int i = -1;
                        switch (AdoRs.Fields[0].Value.ToString())
                        {
                            case "A0":
                                i = 1;
                                break;
                            case "A1":
                                i = 2;
                                break;
                            case "B0":
                                i = 3;
                                break;
                            case "B1":
                                i = 4;
                                break;
                            case "C0":
                                i = 5;
                                break;
                            case "C1":
                                i = 6;
                                break;
                            case "D0":
                                i = 7;
                                break;
                            case "D1":
                                i = 8;
                                break;
                            case "T0":
                                i = 9;
                                break;
                            case "T1":
                                i = 10;
                                break;
                            default:
                                i = -1;
                                break;
                        }
                        for (int j = 1; j < AdoRs.Fields.Count; j++)
                        {
                            sPread.ActiveSheet.Cells[i - 1, j - 1].Text = AdoRs.Fields[j].Value.ToString() == "0" ? "" : AdoRs.Fields[j].Value.ToString();
                        }
                    }
                    /////
                    else if (sPread.Name == "ss5")
                    {
                        for (int j = 1; j < AdoRs.Fields.Count; j++)
                        {
                            sPread.ActiveSheet.Cells[int.Parse(AdoRs.Fields[0].Value.ToString()) - 1, j - 1].Text = AdoRs.Fields[j].Value.ToString() == "0" ? "" : AdoRs.Fields[j].Value.ToString();
                        }
                    }
                    else if (sPread.Name == "ss7")
                    {
                        int i = -1;
                        switch (AdoRs.Fields[0].Value.ToString())
                        {
                            case "A0":
                                i = 1;
                                break;
                            case "A1":
                                i = 2;
                                break;
                            case "B0":
                                i = 3;
                                break;
                            case "B1":
                                i = 4;
                                break;
                            case "C0":
                                i = 5;
                                break;
                            case "C1":
                                i = 6;
                                break;
                            case "D0":
                                i = 7;
                                break;
                            case "D1":
                                i = 8;
                                break;
                            case "T0":
                                i = 9;
                                break;
                            case "T1":
                                i = 10;
                                break;
                            default:
                                i = -1;
                                break;
                        }

                        int j = (int.Parse(AdoRs.Fields[1].Value.ToString()) - 1) * 4;
                        sPread.ActiveSheet.Cells[i - 1, j].Text = AdoRs.Fields[2].Value.ToString() == "0" ? "" : AdoRs.Fields[2].Value.ToString();
                        sPread.ActiveSheet.Cells[i - 1, j + 1].Text = AdoRs.Fields[3].Value.ToString() == "0" ? "" : AdoRs.Fields[3].Value.ToString();
                        sPread.ActiveSheet.Cells[i - 1, j + 2].Text = AdoRs.Fields[4].Value.ToString() == "0" ? "" : AdoRs.Fields[4].Value.ToString();
                        sPread.ActiveSheet.Cells[i - 1, j + 3].Text = AdoRs.Fields[5].Value.ToString() == "0" ? "" : AdoRs.Fields[5].Value.ToString();
                    }
                    ////



                    AdoRs.MoveNext();
                }
                isHaveData = true;
                AdoRs.Close();
                AdoRs = null;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
            catch (Exception ex)
            {
                AdoRs.Close();
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay("数据错误，请检查是否有异常数据...!!", "W", "警告");
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
        }

        private bool SearchSpread3Data()
        {
            bool isHaveData = false;
            string sQuery;

            if (GeneralCommon.M_CN1.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return isHaveData;
                }
            }
            sQuery = "{CALL WKC1020C.SearchSpread3Data('" + this.txt_DATE.RawDate + "','" + this.CBO_PLT.Text + "'}";
            // sQuery = "{CALL WKC1020C.SearchSpread3Data('" + this.txt_DATE.RawDate + "','" + "C1" + "'}";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (AdoRs.EOF || AdoRs.BOF)
                {
                    AdoRs.Close();
                    GeneralCommon.M_CN1.Close();
                    return isHaveData;
                }
                while (!AdoRs.EOF)
                {
                    this.ss3_Sheet1.Cells[0, 1].Text = AdoRs.Fields[8].Value.ToString() == "0.000" ? "" : AdoRs.Fields[8].Value.ToString();
                    this.ss3_Sheet1.Cells[1, 1].Text = AdoRs.Fields[9].Value.ToString() == "0.000" ? "" : AdoRs.Fields[9].Value.ToString();
                    this.ss3_Sheet1.Cells[2, 1].Text = AdoRs.Fields[18].Value.ToString() == "0.000" ? "" : AdoRs.Fields[18].Value.ToString();
                    this.ss3_Sheet1.Cells[3, 1].Text = AdoRs.Fields[19].Value.ToString() == "0.000" ? "" : AdoRs.Fields[19].Value.ToString();
                    this.ss3_Sheet1.Cells[4, 1].Text = AdoRs.Fields[10].Value.ToString() == "0.000" ? "" : AdoRs.Fields[10].Value.ToString();
                    this.ss3_Sheet1.Cells[5, 1].Text = AdoRs.Fields[11].Value.ToString() == "0.000" ? "" : AdoRs.Fields[11].Value.ToString();
                    this.ss3_Sheet1.Cells[6, 1].Text = AdoRs.Fields[12].Value.ToString() == "0.000" ? "" : AdoRs.Fields[12].Value.ToString();
                    this.ss3_Sheet1.Cells[7, 1].Text = AdoRs.Fields[13].Value.ToString() == "0.000" ? "" : AdoRs.Fields[13].Value.ToString();
                    this.ss3_Sheet1.Cells[8, 1].Text = AdoRs.Fields[20].Value.ToString() == "0.000" ? "" : AdoRs.Fields[20].Value.ToString();
                    this.ss3_Sheet1.Cells[9, 1].Text = AdoRs.Fields[21].Value.ToString() == "0.000" ? "" : AdoRs.Fields[21].Value.ToString();
                    this.ss3_Sheet1.Cells[0, 3].Text = AdoRs.Fields[2].Value.ToString() == "0.000" ? "" : AdoRs.Fields[2].Value.ToString();
                    this.ss3_Sheet1.Cells[1, 3].Text = AdoRs.Fields[3].Value.ToString() == "0.000" ? "" : AdoRs.Fields[3].Value.ToString();
                    this.ss3_Sheet1.Cells[2, 3].Text = AdoRs.Fields[16].Value.ToString() == "0.000" ? "" : AdoRs.Fields[16].Value.ToString();
                    this.ss3_Sheet1.Cells[3, 3].Text = AdoRs.Fields[17].Value.ToString() == "0.000" ? "" : AdoRs.Fields[17].Value.ToString();
                    this.ss3_Sheet1.Cells[4, 3].Text = AdoRs.Fields[4].Value.ToString() == "0.000" ? "" : AdoRs.Fields[4].Value.ToString();
                    this.ss3_Sheet1.Cells[5, 3].Text = AdoRs.Fields[5].Value.ToString() == "0.000" ? "" : AdoRs.Fields[5].Value.ToString();
                    this.ss3_Sheet1.Cells[6, 3].Text = AdoRs.Fields[6].Value.ToString() == "0.000" ? "" : AdoRs.Fields[6].Value.ToString();
                    this.ss3_Sheet1.Cells[7, 3].Text = AdoRs.Fields[7].Value.ToString() == "0.000" ? "" : AdoRs.Fields[7].Value.ToString();
                    this.ss3_Sheet1.Cells[8, 3].Text = AdoRs.Fields[14].Value.ToString() == "0.00" ? "" : AdoRs.Fields[14].Value.ToString();
                    this.ss3_Sheet1.Cells[9, 3].Text = AdoRs.Fields[15].Value.ToString() == "0.00" ? "" : AdoRs.Fields[15].Value.ToString();
                    double dNoPlanWgt_d = 0;
                    this.ss3_Sheet1.Cells[1, 5].Text = AdoRs.Fields[54].Value.ToString() == "0.000" ? "" : AdoRs.Fields[54].Value.ToString();
                    dNoPlanWgt_d = double.Parse(AdoRs.Fields[54].Value.ToString());
                    this.ss3_Sheet1.Cells[2, 5].Text = AdoRs.Fields[56].Value.ToString() == "0.000" ? "" : AdoRs.Fields[56].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[56].Value.ToString());
                    this.ss3_Sheet1.Cells[3, 5].Text = AdoRs.Fields[52].Value.ToString() == "0.000" ? "" : AdoRs.Fields[52].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[52].Value.ToString());
                    this.ss3_Sheet1.Cells[4, 5].Text = dNoPlanWgt_d.ToString();
                    double dNoPlanWgt_m = 0;
                    this.ss3_Sheet1.Cells[1, 6].Text = AdoRs.Fields[55].Value.ToString() == "0.000" ? "" : AdoRs.Fields[55].Value.ToString();
                    dNoPlanWgt_m = double.Parse(AdoRs.Fields[55].Value.ToString());
                    this.ss3_Sheet1.Cells[2, 6].Text = AdoRs.Fields[57].Value.ToString() == "0.000" ? "" : AdoRs.Fields[57].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[57].Value.ToString());
                    this.ss3_Sheet1.Cells[3, 6].Text = AdoRs.Fields[53].Value.ToString() == "0.000" ? "" : AdoRs.Fields[53].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[53].Value.ToString());
                    this.ss3_Sheet1.Cells[4, 6].Text = dNoPlanWgt_m.ToString();
                    this.ss3_Sheet1.Cells[5, 6].Text = AdoRs.Fields[71].Value.ToString() == "0.000" ? "" : AdoRs.Fields[71].Value.ToString();
                    this.ss3_Sheet1.Cells[6, 6].Text = AdoRs.Fields[72].Value.ToString() == "0.000" ? "" : AdoRs.Fields[72].Value.ToString();
                    this.ss3_Sheet1.Cells[7, 6].Text = AdoRs.Fields[73].Value.ToString() == "0.000" ? "" : AdoRs.Fields[73].Value.ToString();
                    this.ss3_Sheet1.Cells[8, 6].Text = AdoRs.Fields[75].Value.ToString() == "0.000" ? "" : AdoRs.Fields[75].Value.ToString();
                    this.ss3_Sheet1.Cells[9, 6].Text = AdoRs.Fields[74].Value.ToString() == "0.000" ? "" : AdoRs.Fields[74].Value.ToString();
                    this.ss3_Sheet1.Cells[1, 8].Text = AdoRs.Fields[22].Value.ToString() == "0.000" ? "" : AdoRs.Fields[22].Value.ToString();
                    dNoPlanWgt_d = double.Parse(AdoRs.Fields[22].Value.ToString());
                    this.ss3_Sheet1.Cells[2, 8].Text = AdoRs.Fields[24].Value.ToString() == "0.000" ? "" : AdoRs.Fields[24].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[24].Value.ToString());
                    this.ss3_Sheet1.Cells[3, 8].Text = AdoRs.Fields[26].Value.ToString() == "0.000" ? "" : AdoRs.Fields[26].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[26].Value.ToString());
                    this.ss3_Sheet1.Cells[4, 8].Text = AdoRs.Fields[28].Value.ToString() == "0.000" ? "" : AdoRs.Fields[28].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[28].Value.ToString());
                    //this.ss3_Sheet1.Cells[5, 8].Text = AdoRs.Fields[32].Value.ToString() == "0.000" ? "" : AdoRs.Fields[32].Value.ToString();
                    //dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[32].Value.ToString());
                    //this.ss3_Sheet1.Cells[6, 8].Text = AdoRs.Fields[34].Value.ToString() == "0.000" ? "" : AdoRs.Fields[34].Value.ToString();
                    //dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[34].Value.ToString());
                    //this.ss3_Sheet1.Cells[7, 8].Text = AdoRs.Fields[36].Value.ToString() == "0.000" ? "" : AdoRs.Fields[36].Value.ToString();
                    //dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[36].Value.ToString());
                    //this.ss3_Sheet1.Cells[8, 8].Text = AdoRs.Fields[38].Value.ToString() == "0.000" ? "" : AdoRs.Fields[38].Value.ToString();
                    //dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[38].Value.ToString());
                    //this.ss3_Sheet1.Cells[9, 8].Text = AdoRs.Fields[40].Value.ToString() == "0.000" ? "" : AdoRs.Fields[40].Value.ToString();
                    //dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[40].Value.ToString());
                    this.ss3_Sheet1.Cells[5, 8].Text = AdoRs.Fields[32].Value.ToString() == "0.000" ? "" : AdoRs.Fields[32].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[32].Value.ToString());
                    this.ss3_Sheet1.Cells[6, 8].Text = AdoRs.Fields[34].Value.ToString() == "0.000" ? "" : AdoRs.Fields[34].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[34].Value.ToString());
                    this.ss3_Sheet1.Cells[7, 8].Text = AdoRs.Fields[36].Value.ToString() == "0.000" ? "" : AdoRs.Fields[36].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[36].Value.ToString());
                    this.ss3_Sheet1.Cells[8, 8].Text = AdoRs.Fields[38].Value.ToString() == "0.000" ? "" : AdoRs.Fields[38].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[38].Value.ToString());

                    this.ss3_Sheet1.Cells[1, 9].Text = AdoRs.Fields[23].Value.ToString() == "0.000" ? "" : AdoRs.Fields[23].Value.ToString();
                    dNoPlanWgt_m = double.Parse(AdoRs.Fields[23].Value.ToString());
                    this.ss3_Sheet1.Cells[2, 9].Text = AdoRs.Fields[25].Value.ToString() == "0.000" ? "" : AdoRs.Fields[25].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[25].Value.ToString());
                    this.ss3_Sheet1.Cells[3, 9].Text = AdoRs.Fields[27].Value.ToString() == "0.000" ? "" : AdoRs.Fields[27].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[27].Value.ToString());
                    this.ss3_Sheet1.Cells[4, 9].Text = AdoRs.Fields[29].Value.ToString() == "0.000" ? "" : AdoRs.Fields[29].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[29].Value.ToString());
                    //this.ss3_Sheet1.Cells[5, 9].Text = AdoRs.Fields[33].Value.ToString() == "0.000" ? "" : AdoRs.Fields[33].Value.ToString();
                    //dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[33].Value.ToString());
                    //this.ss3_Sheet1.Cells[6, 9].Text = AdoRs.Fields[35].Value.ToString() == "0.000" ? "" : AdoRs.Fields[35].Value.ToString();
                    //dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[35].Value.ToString());
                    //this.ss3_Sheet1.Cells[7, 9].Text = AdoRs.Fields[37].Value.ToString() == "0.000" ? "" : AdoRs.Fields[37].Value.ToString();
                    //dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[37].Value.ToString());
                    //this.ss3_Sheet1.Cells[8, 9].Text = AdoRs.Fields[39].Value.ToString() == "0.000" ? "" : AdoRs.Fields[39].Value.ToString();
                    //dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[39].Value.ToString());
                    //this.ss3_Sheet1.Cells[9, 9].Text = AdoRs.Fields[41].Value.ToString() == "0.000" ? "" : AdoRs.Fields[41].Value.ToString();
                    //dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[41].Value.ToString());
                    this.ss3_Sheet1.Cells[5, 9].Text = AdoRs.Fields[33].Value.ToString() == "0.000" ? "" : AdoRs.Fields[33].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[33].Value.ToString());
                    this.ss3_Sheet1.Cells[6, 9].Text = AdoRs.Fields[35].Value.ToString() == "0.000" ? "" : AdoRs.Fields[35].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[35].Value.ToString());
                    this.ss3_Sheet1.Cells[7, 9].Text = AdoRs.Fields[37].Value.ToString() == "0.000" ? "" : AdoRs.Fields[37].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[37].Value.ToString());
                    this.ss3_Sheet1.Cells[8, 9].Text = AdoRs.Fields[39].Value.ToString() == "0.000" ? "" : AdoRs.Fields[39].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[39].Value.ToString());


                    //热处理检验废
                    this.ss3_Sheet1.Cells[1, 11].Text = AdoRs.Fields[40].Value.ToString() == "0.000" ? "" : AdoRs.Fields[40].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[40].Value.ToString());
                    //外销次品
                    this.ss3_Sheet1.Cells[2, 11].Text = "";

                    ////钢制报废备件
                    //this.ss3_Sheet1.Cells[2, 11].Text = AdoRs.Fields[48].Value.ToString() == "0.000" ? "" : AdoRs.Fields[48].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[48].Value.ToString());
                    ////切割渣
                    //this.ss3_Sheet1.Cells[3, 11].Text = AdoRs.Fields[50].Value.ToString() == "0.000" ? "" : AdoRs.Fields[50].Value.ToString();
                    dNoPlanWgt_d = dNoPlanWgt_d + double.Parse(AdoRs.Fields[50].Value.ToString());
                    //合计
                    this.ss3_Sheet1.Cells[3, 11].Text = dNoPlanWgt_d.ToString();


                    ////判废量
                    //this.ss3_Sheet1.Cells[5, 11].Text = AdoRs.Fields[68].Value.ToString() == "0.000" ? "" : AdoRs.Fields[68].Value.ToString();

                    //热处理检验废
                    this.ss3_Sheet1.Cells[1, 12].Text = AdoRs.Fields[41].Value.ToString() == "0.000" ? "" : AdoRs.Fields[41].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[41].Value.ToString());

                    //外销次品
                    this.ss3_Sheet1.Cells[2, 12].Text = "";

                    ////钢制报废备件
                    //this.ss3_Sheet1.Cells[2, 12].Text = AdoRs.Fields[49].Value.ToString() == "0.000" ? "" : AdoRs.Fields[49].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[49].Value.ToString());
                    ////切割渣
                    //this.ss3_Sheet1.Cells[3, 12].Text = AdoRs.Fields[51].Value.ToString() == "0.000" ? "" : AdoRs.Fields[51].Value.ToString();
                    dNoPlanWgt_m = dNoPlanWgt_m + double.Parse(AdoRs.Fields[51].Value.ToString());
                    //合计
                    this.ss3_Sheet1.Cells[3, 12].Text = dNoPlanWgt_m.ToString();
                    ////判废量
                    //this.ss3_Sheet1.Cells[5, 12].Text = AdoRs.Fields[69].Value.ToString() == "0.000" ? "" : AdoRs.Fields[69].Value.ToString();

                    AdoRs.MoveNext();
                }
                isHaveData = true;
                AdoRs.Close();
                AdoRs = null;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
            catch (Exception ex)
            {
                AdoRs.Close();
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay("数据错误，请检查是否有异常数据...!!", "W", "警告");
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
        }

        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            string sDate = txt_DATE.RawDate;
            string plt = this.CBO_PLT.Text;
            string ret_Result_ErrMsg;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "WKC1020P";
                GeneralCommon.M_CN1.BeginTrans();
                adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));

                adoCmd.Parameters[0].Value = sDate;
                adoCmd.Parameters[1].Value = plt;
                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "")
                {
                    ret_Result_ErrMsg = adoCmd.Parameters["arg_e_code"].Value.ToString();
                    GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrMsg);
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();
                }
                else
                {
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                    GeneralCommon.Gp_MsgBoxDisplay("数据更新成功！", "I", this.Text);
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "W", "警告");
            }
        }

        public override void Spread_Exc()
        {
            try
            {
                setExcel();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("导出数据错误...!!" + ex.Message, "W", "警告");
            }
        }

        private void setExcel()
        {
            if (this.CBO_PLT.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("工厂代码不能为空...!!", "W", "警告");
                return;
            }
            if (this.txt_DATE.RawDate == "" || this.txt_DATE.RawDate.Length != 8)
            {
                GeneralCommon.Gp_MsgBoxDisplay("日期输入不正确...!!", "W", "警告");
                return;
            }
            string modelName = "WKC1020C.xls";
            GeneralCommon.Gp_CopyModel(modelName);
            string fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + "report" + "\\" + modelName;
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            Microsoft.Office.Interop.Excel.Range range = null;
            Worksheet worksheet1 = null;
            worksheet1 = (Worksheet)workbook.Sheets[1];
            appExcel.Cells[2, 1] = "报表日期：" + this.txt_DATE.RawDate.Substring(0, 4) + "年" + this.txt_DATE.RawDate.Substring(4, 2) + "月" + this.txt_DATE.RawDate.Substring(6, 2) + "日";


            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[5 + i, 3] = ss1.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[5 + i, 4] = ss1.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[5 + i, 5] = ss1.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[5 + i, 6] = ss1.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[5 + i, 7] = ss1.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[5 + i, 8] = ss1.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[5 + i, 9] = ss1.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[5 + i, 10] = ss1.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[5 + i, 11] = ss1.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[5 + i, 12] = ss1.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[5 + i, 13] = ss1.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[5 + i, 14] = ss1.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[5 + i, 15] = ss1.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[5 + i, 16] = ss1.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[5 + i, 17] = ss1.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[5 + i, 18] = ss1.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[5 + i, 19] = ss1.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[5 + i, 20] = ss1.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[5 + i, 21] = ss1.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[5 + i, 22] = ss1.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[5 + i, 23] = ss1.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[5 + i, 24] = ss1.ActiveSheet.Cells[i, 21].Text;
                //appExcel.Cells[5 + i, 25] = ss1.ActiveSheet.Cells[i, 22].Text;
                //appExcel.Cells[5 + i, 26] = ss1.ActiveSheet.Cells[i, 23].Text;
                //appExcel.Cells[5 + i, 27] = ss1.ActiveSheet.Cells[i, 24].Text;
                //appExcel.Cells[5 + i, 28] = ss1.ActiveSheet.Cells[i, 25].Text;
            }

            for (int i = 0; i < ss2.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[17 + i, 3] = ss2.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[17 + i, 4] = ss2.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[17 + i, 5] = ss2.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[17 + i, 6] = ss2.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[17 + i, 7] = ss2.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[17 + i, 8] = ss2.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[17 + i, 9] = ss2.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[17 + i, 10] = ss2.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[17 + i, 11] = ss2.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[17 + i, 12] = ss2.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[17 + i, 13] = ss2.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[17 + i, 14] = ss2.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[17 + i, 15] = ss2.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[17 + i, 16] = ss2.ActiveSheet.Cells[i, 13].Text;
            }

            for (int i = 0; i < ss3.ActiveSheet.RowCount; i++)
            {
                if (i == 0)
                {
                    appExcel.Cells[17 + i, 18] = ss3.ActiveSheet.Cells[i, 1].Text;
                    appExcel.Cells[17 + i, 20] = ss3.ActiveSheet.Cells[i, 3].Text;
                }
                else if (i <= 3)
                {
                    appExcel.Cells[17 + i, 18] = ss3.ActiveSheet.Cells[i, 1].Text;
                    appExcel.Cells[17 + i, 20] = ss3.ActiveSheet.Cells[i, 3].Text;
                    appExcel.Cells[17 + i, 22] = ss3.ActiveSheet.Cells[i, 5].Text;
                    appExcel.Cells[17 + i, 23] = ss3.ActiveSheet.Cells[i, 6].Text;
                    appExcel.Cells[17 + i, 25] = ss3.ActiveSheet.Cells[i, 8].Text;
                    appExcel.Cells[17 + i, 26] = ss3.ActiveSheet.Cells[i, 9].Text;
                    appExcel.Cells[17 + i, 28] = ss3.ActiveSheet.Cells[i, 11].Text;
                    appExcel.Cells[17 + i, 29] = ss3.ActiveSheet.Cells[i, 12].Text;
                }
                else if (i <= 8)
                {
                    appExcel.Cells[17 + i, 18] = ss3.ActiveSheet.Cells[i, 1].Text;
                    appExcel.Cells[17 + i, 20] = ss3.ActiveSheet.Cells[i, 3].Text;
                    appExcel.Cells[17 + i, 22] = ss3.ActiveSheet.Cells[i, 5].Text;
                    appExcel.Cells[17 + i, 23] = ss3.ActiveSheet.Cells[i, 6].Text;
                    appExcel.Cells[17 + i, 25] = ss3.ActiveSheet.Cells[i, 8].Text;
                    appExcel.Cells[17 + i, 26] = ss3.ActiveSheet.Cells[i, 9].Text;
                }
                else
                {
                    appExcel.Cells[17 + i, 18] = ss3.ActiveSheet.Cells[i, 1].Text;
                    appExcel.Cells[17 + i, 20] = ss3.ActiveSheet.Cells[i, 3].Text;
                    appExcel.Cells[17 + i, 22] = ss3.ActiveSheet.Cells[i, 5].Text;
                    appExcel.Cells[17 + i, 23] = ss3.ActiveSheet.Cells[i, 6].Text;
                }
            }


            //for (int i = 0; i < ss5.ActiveSheet.RowCount; i++)
            //{
            //    appExcel.Cells[29 + i, 3] = ss5.ActiveSheet.Cells[i, 0].Text;
            //    appExcel.Cells[29 + i, 4] = ss5.ActiveSheet.Cells[i, 1].Text;
            //    appExcel.Cells[29 + i, 5] = ss5.ActiveSheet.Cells[i, 2].Text;
            //    appExcel.Cells[29 + i, 6] = ss5.ActiveSheet.Cells[i, 3].Text;
            //    appExcel.Cells[29 + i, 7] = ss5.ActiveSheet.Cells[i, 4].Text;
            //    appExcel.Cells[29 + i, 8] = ss5.ActiveSheet.Cells[i, 5].Text;
            //    appExcel.Cells[29 + i, 9] = ss5.ActiveSheet.Cells[i, 6].Text;
            //    appExcel.Cells[29 + i, 10] = ss5.ActiveSheet.Cells[i, 7].Text;
            //    appExcel.Cells[29 + i, 11] = ss5.ActiveSheet.Cells[i, 8].Text;
            //    appExcel.Cells[29 + i, 12] = ss5.ActiveSheet.Cells[i, 9].Text;
            //    appExcel.Cells[29 + i, 13] = ss5.ActiveSheet.Cells[i, 10].Text;
            //    appExcel.Cells[29 + i, 14] = ss5.ActiveSheet.Cells[i, 11].Text;
            //}

            appExcel.Cells[75, 3] = "制表日期: " + GeneralCommon.Gf_GetDateStr(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL"));
            // appExcel.Cells[83, 12] = "制表人：" + GeneralCommon.sUserID;
            appExcel.Cells[75, 12] = "制表人：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select emp_name from zp_employee where emp_id='" + GeneralCommon.sUserID + "'");
            appExcel.Visible = true;
            appExcel = null;

        }


        protected override void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

    }
}