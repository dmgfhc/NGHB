using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;

namespace BG
{
    public partial class BGC2432C : CommonClass.FORMBASE
    {
        public BGC2432C()
        {
            InitializeComponent();
            curDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD') from dual");
        }
        string curDate = "";
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
            p_SetMc("开始日期", dtp_prod_fr, "PN", "", "", "", "", imcseq);//0
            p_SetMc("结束日期", dtp_prod_to, "PN", "", "", "", "", imcseq);//1
            p_SetMc("工厂", txt_plt, "PN", "8", "", "", "", imcseq);//2
            p_SetMc("产线", txt_line, "P", "8", "", "", "", imcseq);//3
            p_SetMc("委托单号", txt_smp_sent_no, "P", "", "", "", "", imcseq);//4
            p_SetMc("已处理对象", txt_check, "P", "", "", "", "", imcseq);//5
            p_SetMc("热处理", txt_DH_FL, "P", "", "", "", "", imcseq);//6
            p_SetMc("试样号", txt_smp_no, "P", "", "", "", "", imcseq);//7
            p_SetMc("复样", txt_smp_fl, "P", "", "", "", "", imcseq);//8
            p_SetMc("热处理方式", txt_HTM_METH, "P", "", "", "", "", imcseq);//9
            p_SetMc("出口", Txt_OutOrder, "P", "", "", "", "", imcseq);//10

            p_ScIni(ss1, Sc1, 48, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("选择", "C", "", "I", "", "", "", iscseq, iheadrow);//0
            p_SetSc("试样号", "E", "", "IL", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("委托单号", "E", "", "PIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("钢种", "E", "", "IL", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("规格", "E", "", "IL", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("试样数量", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("拉伸a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("拉伸b", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("拉伸c", "E", " ", "IL", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("拉伸d", "E", "","IL", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("拉伸e", "E", "","IL", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("拉伸f", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("高低温拉伸g", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("高低温拉伸h", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("高低温拉伸i", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("高低温拉伸j", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("高低温拉伸k", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("高低温拉伸l", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("弯曲a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("冲击a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("冲击b", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("冲击c", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("冲击d", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("冲击e ", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("冲击f", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("时效冲击g", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("时效冲击h", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("时效冲击i", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//27  
            p_SetSc("时效冲击j", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("时效冲击k", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//29   
            p_SetSc("时效冲击l", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//30   
            p_SetSc("硬度a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("Z向a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("Z向b", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("Z向c", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("Z向d", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("Z向e", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("Z向f", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("高温Z向g", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("高温Z向h", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("高温Z向i", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("高温Z向j", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("高温Z向k", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("高温Z向l", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("金相a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("夹杂a", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("备注", "E", "", "IL", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("要求完成时间", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("录入人id", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("录入人", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("工厂", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("是否已处理", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("取样位置", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("试验条件", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//53
            p_SetSc("LA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("LB", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//55
            p_SetSc("LC", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("LD", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//57
            p_SetSc("LE", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("LF", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//59
            p_SetSc("LG", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//60
            p_SetSc("LH", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//61
            p_SetSc("LI", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//62
            p_SetSc("LJ", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//63
            p_SetSc("LK", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//64
            p_SetSc("LL", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//65
            p_SetSc("WA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//66
            p_SetSc("CA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//67
            p_SetSc("CB", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//68
            p_SetSc("CC", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//69
            p_SetSc("CD", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//70
            p_SetSc("CE", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//71
            p_SetSc("CF", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//72
            p_SetSc("CG", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//73
            p_SetSc("CH", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//74
            p_SetSc("CI", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//75
            p_SetSc("CJ", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//76
            p_SetSc("CK", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//77
            p_SetSc("CL", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//78
            p_SetSc("YD", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//79
            p_SetSc("ZA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//80
            p_SetSc("ZB", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//81
            p_SetSc("ZC", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//82
            p_SetSc("ZD", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//83
            p_SetSc("ZE", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//84
            p_SetSc("ZF", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//85
            p_SetSc("ZG", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//86
            p_SetSc("ZH", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//87
            p_SetSc("ZI", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//88
            p_SetSc("ZJ", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//89
            p_SetSc("ZK", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//90
            p_SetSc("ZL", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//91
            p_SetSc("XA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//92
            p_SetSc("JA", "E", "", "L", "", "", "", iscseq, iheadrow, "L");//93
           
        }


        private void BGC2432C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CSQ9020C";
            Form_Define();
        //    base.sAuthority = "1111";
            txt_plt.Text = "C2";
            this.dtp_prod_fr.RawDate = curDate;//取当前时间
            this.dtp_prod_to.RawDate = curDate;  
        
            txt_smp_fl.Checked = false;
            txt_check.Checked = false;
            subButtonHide();//设置画面形式。
            txt_smp_sent_no.Text = "";
            TXT_CUT_PLT.Text = "";
            PLT_NAME.Text = "宽厚板厂";

            SpreadCommon.Gp_Sp_ColHidden(ss1, 54, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 55, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 56, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 57, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 58, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 59, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 60, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 61, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 62, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 63, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 64, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 65, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 66, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 67, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 68, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 69, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 70, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 71, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 72, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 73, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 74, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 75, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 76, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 77, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 78, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 79, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 80, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 81, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 82, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 83, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 84, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 85, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 86, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 87, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 88, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 89, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 90, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 91, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 92, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 93, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_smp_fl.Checked = false;
            txt_check.Checked = false;
            subButtonHide();
            txt_smp_sent_no.Text = "";
            TXT_CUT_PLT.Text = "";
            txt_plt.Text = "C2";
            dtp_prod_fr.RawDate = curDate;
            dtp_prod_to.RawDate = curDate;
            return true;
        }

        public override void Form_Ref()
        {
            p_Ref(1,1,true,true);
            if (ss1_Sheet1.RowCount <= 0) return;
            subButtonHide();
            TXT_CUT_PLT.Text = ss1_Sheet1.Cells[0, 50].Text;
            reSetToolbarImages();//重置Toolbar的画面。
        }

        //设置画面形式。
        private void subButtonHide()
        {
            if (txt_check.Checked)
            {           
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F"; cmdReport.Visible = true;
                GeneralCommon.MDIToolBar.Refresh();
                CmdSEND.Visible = true;
                label6.Visible = true;
                txt_smp_sent_no.Visible = true;
                label2.Visible = false;
                dtp_end_date.Visible = false;
                label8.Visible = false;
                SpreadCommon.Gp_Sp_ColHidden(ss1,2,false);
                for (int i = 0; i < ss1_Sheet1.RowCount;i++)
                {
                    ss1_Sheet1.Rows.Get(i).Locked = true;
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.White;
                }
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();
                cmdReport.Visible = false;
                CmdSEND.Visible = false;
                label6.Visible = false;
                txt_smp_sent_no.Visible = false;
                label2.Visible = true;
                dtp_end_date.Visible = true;
                label8.Visible = true;
                SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);
            }
        }

        //重置Toolbar的画面。
        private void reSetToolbarImages()
        {
            if (txt_check.Checked)
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            }
            GeneralCommon.MDIToolBar.Refresh();
        }

        //点击“复样”选择按钮，进行查询
        private void txt_smp_fl_Click(object sender, EventArgs e)
        {
            Form_Ref();
        }

        //点击“已处理对象”选择按钮，进行查询
        private void txt_check_Click(object sender, EventArgs e)
        {
            subButtonHide();
            Form_Ref();
            txt_smp_sent_no.Text = "";
        }

        //Spread单元格双击事件。
        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
           // base.ss_CellDoubleClick(sender, e);
            if (e.ColumnHeader) return;
            if (e.RowHeader) return;
            if (txt_check.Checked)
            {
                txt_smp_sent_no.Text = ss1_Sheet1.Cells[e.Row, 2].Text;
                TXT_CUT_PLT.Text = ss1_Sheet1.Cells[e.Row, 50].Text;
            }           
        }

        object[,] ArrayRecords;//存储从后台得到的数据，保存在二维数组中。
        string curDateExcel = "";
        ArrayList list = null;//定义一个集合，保存向后台传入的值。

        //“打印委托单”点击事件，1、打印委托单；2、式样号信息更新。
        private void cmdReport_Click(object sender, EventArgs e)
        {
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_smp_sent_no.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入委托单号，再打印！", "W", "提示");
                return;
            }
            string modelName = "AGC2432C.xlsx";
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

            appExcel.Cells[2, 1] = "委托单号：" + txt_smp_sent_no.Text + "                     工厂：" + PLT_NAME.Text;
            //appExcel.Cells[2, 4] = "工厂：" + PLT_NAME.Text;

            appExcel.Cells[4, 1]  = ss1.ActiveSheet.Cells[0, 1].Text;  //试样号
            appExcel.Cells[4, 2]  = ss1.ActiveSheet.Cells[0, 3].Text;  //钢种
            //appExcel.Cells[4, 3]  = ss1.ActiveSheet.Cells[0, 4].Text;  //规格
            appExcel.Cells[4, 3] = ss1.ActiveSheet.Cells[0, 4].Text + ",数量：" + ss1.ActiveSheet.Cells[0, 5].Text;
            appExcel.Cells[4, 4]  = ss1.ActiveSheet.Cells[0, 6].Text; //位置
            appExcel.Cells[4, 5]  = ss1.ActiveSheet.Cells[0, 54].Text;  //拉伸a
            appExcel.Cells[4, 6]  = ss1.ActiveSheet.Cells[0, 7].Text; //位置
            appExcel.Cells[4, 7]  = ss1.ActiveSheet.Cells[0, 55].Text;  //拉伸b
            appExcel.Cells[4, 8]  = ss1.ActiveSheet.Cells[0, 8].Text; //位置
            appExcel.Cells[4, 9]  = ss1.ActiveSheet.Cells[0, 56].Text;  //拉伸c
            appExcel.Cells[4, 10] = ss1.ActiveSheet.Cells[0, 9].Text; //位置
            appExcel.Cells[4, 11] = ss1.ActiveSheet.Cells[0, 57].Text;  //拉伸d
            appExcel.Cells[4, 12] = ss1.ActiveSheet.Cells[0, 10].Text; //位置
            appExcel.Cells[4, 13] = ss1.ActiveSheet.Cells[0, 58].Text; //拉伸e
            appExcel.Cells[4, 14] = ss1.ActiveSheet.Cells[0, 11].Text; //位置
            appExcel.Cells[4, 15] = ss1.ActiveSheet.Cells[0, 59].Text; //拉伸f
            appExcel.Cells[4, 16] = ss1.ActiveSheet.Cells[0, 12].Text; //位置
            appExcel.Cells[4, 17] = ss1.ActiveSheet.Cells[0, 60].Text; //高温拉伸g
            appExcel.Cells[4, 18] = ss1.ActiveSheet.Cells[0, 13].Text; //位置
            appExcel.Cells[4, 19] = ss1.ActiveSheet.Cells[0, 61].Text; //高温拉伸h
            appExcel.Cells[4, 20] = ss1.ActiveSheet.Cells[0, 14].Text; //位置
            appExcel.Cells[4, 21] = ss1.ActiveSheet.Cells[0, 62].Text; //高温拉伸i
            appExcel.Cells[4, 22] = ss1.ActiveSheet.Cells[0, 15].Text; //位置
            appExcel.Cells[4, 23] = ss1.ActiveSheet.Cells[0, 63].Text; //高温拉伸j
            appExcel.Cells[4, 24] = ss1.ActiveSheet.Cells[0, 16].Text; //位置
            appExcel.Cells[4, 25] = ss1.ActiveSheet.Cells[0, 64].Text; //高温拉伸k
            appExcel.Cells[4, 26] = ss1.ActiveSheet.Cells[0, 17].Text; //位置
            appExcel.Cells[4, 27] = ss1.ActiveSheet.Cells[0, 65].Text; //高温拉伸l

            appExcel.Cells[6, 4]  = ss1.ActiveSheet.Cells[0, 19].Text; //冲击a
            appExcel.Cells[6, 5]  = ss1.ActiveSheet.Cells[0, 67].Text; //位置
            appExcel.Cells[6, 6]  = ss1.ActiveSheet.Cells[0, 20].Text; //位置
            appExcel.Cells[6, 7]  = ss1.ActiveSheet.Cells[0, 68].Text; //冲击b
            appExcel.Cells[6, 8]  = ss1.ActiveSheet.Cells[0, 21].Text; //位置
            appExcel.Cells[6, 9]  = ss1.ActiveSheet.Cells[0, 69].Text; //冲击c
            appExcel.Cells[6, 10] = ss1.ActiveSheet.Cells[0, 22].Text; //位置
            appExcel.Cells[6, 11] = ss1.ActiveSheet.Cells[0, 70].Text; //冲击d
            appExcel.Cells[6, 12] = ss1.ActiveSheet.Cells[0, 23].Text; //位置
            appExcel.Cells[6, 13] = ss1.ActiveSheet.Cells[0, 71].Text; //冲击e
            appExcel.Cells[6, 14] = ss1.ActiveSheet.Cells[0, 24].Text; //位置
            appExcel.Cells[6, 15] = ss1.ActiveSheet.Cells[0, 72].Text; //冲击f
            appExcel.Cells[6, 16] = ss1.ActiveSheet.Cells[0, 25].Text; //位置
            appExcel.Cells[6, 17] = ss1.ActiveSheet.Cells[0, 73].Text; //时效冲击g
            appExcel.Cells[6, 18] = ss1.ActiveSheet.Cells[0, 26].Text; //位置
            appExcel.Cells[6, 19] = ss1.ActiveSheet.Cells[0, 74].Text; //时效冲击h
            appExcel.Cells[6, 20] = ss1.ActiveSheet.Cells[0, 27].Text; //位置
            appExcel.Cells[6, 21] = ss1.ActiveSheet.Cells[0, 75].Text; //时效冲击i
            appExcel.Cells[6, 22] = ss1.ActiveSheet.Cells[0, 28].Text; //位置
            appExcel.Cells[6, 23] = ss1.ActiveSheet.Cells[0, 76].Text; //时效冲击j
            appExcel.Cells[6, 24] = ss1.ActiveSheet.Cells[0, 29].Text; //位置
            appExcel.Cells[6, 25] = ss1.ActiveSheet.Cells[0, 77].Text; //时效冲击k
            appExcel.Cells[6, 26] = ss1.ActiveSheet.Cells[0, 30].Text; //位置
            appExcel.Cells[6, 27] = ss1.ActiveSheet.Cells[0, 78].Text; //时效冲击l

            appExcel.Cells[8, 4]  = ss1.ActiveSheet.Cells[0, 32].Text; //位置
            appExcel.Cells[8, 5]  = ss1.ActiveSheet.Cells[0, 80].Text; //Z向a
            appExcel.Cells[8, 6]  = ss1.ActiveSheet.Cells[0, 33].Text; //位置
            appExcel.Cells[8, 7]  = ss1.ActiveSheet.Cells[0, 81].Text; //Z向b
            appExcel.Cells[8, 8]  = ss1.ActiveSheet.Cells[0, 34].Text; //位置
            appExcel.Cells[8, 9]  = ss1.ActiveSheet.Cells[0, 82].Text; //Z向c
            appExcel.Cells[8, 10] = ss1.ActiveSheet.Cells[0, 35].Text; //位置
            appExcel.Cells[8, 11] = ss1.ActiveSheet.Cells[0, 83].Text; //Z向d
            appExcel.Cells[8, 12] = ss1.ActiveSheet.Cells[0, 36].Text; //位置
            appExcel.Cells[8, 13] = ss1.ActiveSheet.Cells[0, 84].Text; //Z向e
            appExcel.Cells[8, 14] = ss1.ActiveSheet.Cells[0, 37].Text; //位置
            appExcel.Cells[8, 15] = ss1.ActiveSheet.Cells[0, 85].Text; //Z向f

            appExcel.Cells[8, 16] = ss1.ActiveSheet.Cells[0, 18].Text; //位置
            appExcel.Cells[8, 17] = ss1.ActiveSheet.Cells[0, 66].Text; //弯曲a
            appExcel.Cells[8, 18] = ss1.ActiveSheet.Cells[0, 31].Text; //位置
            appExcel.Cells[8, 19] = ss1.ActiveSheet.Cells[0, 79].Text; //硬度a          
            appExcel.Cells[8, 20] = ss1.ActiveSheet.Cells[0, 44].Text; //位置
            appExcel.Cells[8, 21] = ss1.ActiveSheet.Cells[0, 92].Text; //金相a
            appExcel.Cells[8, 22] = ss1.ActiveSheet.Cells[0, 45].Text; //位置
            appExcel.Cells[8, 23] = ss1.ActiveSheet.Cells[0, 93].Text; //夹杂a

            appExcel.Cells[9, 1] = "备注：" + ss1.ActiveSheet.Cells[0, 46].Text;

            if (ss1_Sheet1.RowCount > 1)
            {
                appExcel.Cells[11, 1] = ss1.ActiveSheet.Cells[1, 1].Text;  //试样号
                appExcel.Cells[11, 2] = ss1.ActiveSheet.Cells[1, 3].Text;  //钢种
                appExcel.Cells[11, 3] = ss1.ActiveSheet.Cells[1, 4].Text + ",数量：" + ss1.ActiveSheet.Cells[0, 5].Text;  //规格
                appExcel.Cells[11, 4] = ss1.ActiveSheet.Cells[1, 6].Text; //位置
                appExcel.Cells[11, 5] = ss1.ActiveSheet.Cells[1, 54].Text;  //拉伸a
                appExcel.Cells[11, 6] = ss1.ActiveSheet.Cells[1, 7].Text; //位置
                appExcel.Cells[11, 7] = ss1.ActiveSheet.Cells[1, 55].Text;  //拉伸b
                appExcel.Cells[11, 8] = ss1.ActiveSheet.Cells[1, 8].Text; //位置
                appExcel.Cells[11, 9] = ss1.ActiveSheet.Cells[1, 56].Text;  //拉伸c
                appExcel.Cells[11, 10] = ss1.ActiveSheet.Cells[1, 9].Text; //位置
                appExcel.Cells[11, 11] = ss1.ActiveSheet.Cells[1, 57].Text;  //拉伸d
                appExcel.Cells[11, 12] = ss1.ActiveSheet.Cells[1, 10].Text; //位置
                appExcel.Cells[11, 13] = ss1.ActiveSheet.Cells[1, 58].Text; //拉伸e
                appExcel.Cells[11, 14] = ss1.ActiveSheet.Cells[1, 11].Text; //位置
                appExcel.Cells[11, 15] = ss1.ActiveSheet.Cells[1, 59].Text; //拉伸f
                appExcel.Cells[11, 16] = ss1.ActiveSheet.Cells[1, 12].Text; //位置
                appExcel.Cells[11, 17] = ss1.ActiveSheet.Cells[1, 60].Text; //高温拉伸g
                appExcel.Cells[11, 18] = ss1.ActiveSheet.Cells[1, 13].Text; //位置
                appExcel.Cells[11, 19] = ss1.ActiveSheet.Cells[1, 61].Text; //高温拉伸h
                appExcel.Cells[11, 20] = ss1.ActiveSheet.Cells[1, 14].Text; //位置
                appExcel.Cells[11, 21] = ss1.ActiveSheet.Cells[1, 62].Text; //高温拉伸i
                appExcel.Cells[11, 22] = ss1.ActiveSheet.Cells[1, 15].Text; //位置
                appExcel.Cells[11, 23] = ss1.ActiveSheet.Cells[1, 63].Text; //高温拉伸j
                appExcel.Cells[11, 24] = ss1.ActiveSheet.Cells[1, 16].Text; //位置
                appExcel.Cells[11, 25] = ss1.ActiveSheet.Cells[1, 64].Text; //高温拉伸k
                appExcel.Cells[11, 26] = ss1.ActiveSheet.Cells[1, 17].Text; //位置
                appExcel.Cells[11, 27] = ss1.ActiveSheet.Cells[1, 65].Text; //高温拉伸l

                appExcel.Cells[13, 4] = ss1.ActiveSheet.Cells[1, 19].Text; //位置
                appExcel.Cells[13, 5] = ss1.ActiveSheet.Cells[1, 67].Text; //冲击a
                appExcel.Cells[13, 6] = ss1.ActiveSheet.Cells[1, 20].Text; //位置
                appExcel.Cells[13, 7] = ss1.ActiveSheet.Cells[1, 68].Text; //冲击b
                appExcel.Cells[13, 8] = ss1.ActiveSheet.Cells[1, 21].Text; //位置
                appExcel.Cells[13, 9] = ss1.ActiveSheet.Cells[1, 69].Text; //冲击c
                appExcel.Cells[13, 10] = ss1.ActiveSheet.Cells[1, 22].Text; //位置
                appExcel.Cells[13, 11] = ss1.ActiveSheet.Cells[1, 70].Text; //冲击d
                appExcel.Cells[13, 12] = ss1.ActiveSheet.Cells[1, 23].Text; //位置
                appExcel.Cells[13, 13] = ss1.ActiveSheet.Cells[1, 71].Text; //冲击e
                appExcel.Cells[13, 14] = ss1.ActiveSheet.Cells[1, 24].Text; //位置
                appExcel.Cells[13, 15] = ss1.ActiveSheet.Cells[1, 72].Text; //冲击f
                appExcel.Cells[13, 16] = ss1.ActiveSheet.Cells[1, 25].Text; //位置
                appExcel.Cells[13, 17] = ss1.ActiveSheet.Cells[1, 73].Text; //时效冲击g
                appExcel.Cells[13, 18] = ss1.ActiveSheet.Cells[1, 26].Text; //位置
                appExcel.Cells[13, 19] = ss1.ActiveSheet.Cells[1, 74].Text; //时效冲击h
                appExcel.Cells[13, 20] = ss1.ActiveSheet.Cells[1, 27].Text; //位置
                appExcel.Cells[13, 21] = ss1.ActiveSheet.Cells[1, 75].Text; //时效冲击i
                appExcel.Cells[13, 22] = ss1.ActiveSheet.Cells[1, 28].Text; //位置
                appExcel.Cells[13, 23] = ss1.ActiveSheet.Cells[1, 76].Text; //时效冲击j
                appExcel.Cells[13, 24] = ss1.ActiveSheet.Cells[1, 29].Text; //位置
                appExcel.Cells[13, 25] = ss1.ActiveSheet.Cells[1, 77].Text; //时效冲击k
                appExcel.Cells[13, 26] = ss1.ActiveSheet.Cells[1, 30].Text; //位置
                appExcel.Cells[13, 27] = ss1.ActiveSheet.Cells[1, 78].Text; //时效冲击l

                
                appExcel.Cells[15, 4] = ss1.ActiveSheet.Cells[1, 32].Text; //位置
                appExcel.Cells[15, 5] = ss1.ActiveSheet.Cells[1, 80].Text; //Z向a
                appExcel.Cells[15, 6] = ss1.ActiveSheet.Cells[1, 33].Text; //位置
                appExcel.Cells[15, 7] = ss1.ActiveSheet.Cells[1, 81].Text; //Z向b
                appExcel.Cells[15, 8] = ss1.ActiveSheet.Cells[1, 34].Text; //位置
                appExcel.Cells[15, 9] = ss1.ActiveSheet.Cells[1, 82].Text; //Z向c
                appExcel.Cells[15, 10] = ss1.ActiveSheet.Cells[1, 35].Text; //位置
                appExcel.Cells[15, 11] = ss1.ActiveSheet.Cells[1, 83].Text; //Z向d
                appExcel.Cells[15, 12] = ss1.ActiveSheet.Cells[1, 36].Text; //位置
                appExcel.Cells[15, 13] = ss1.ActiveSheet.Cells[1, 84].Text; //Z向e
                appExcel.Cells[15, 14] = ss1.ActiveSheet.Cells[1, 37].Text; //位置
                appExcel.Cells[15, 15] = ss1.ActiveSheet.Cells[1, 85].Text; //Z向f

                appExcel.Cells[15, 16] = ss1.ActiveSheet.Cells[1, 18].Text; //位置
                appExcel.Cells[15, 17] = ss1.ActiveSheet.Cells[1, 66].Text; //弯曲a
                appExcel.Cells[15, 18] = ss1.ActiveSheet.Cells[1, 31].Text; //位置
                appExcel.Cells[15, 19] = ss1.ActiveSheet.Cells[1, 79].Text; //硬度a
                appExcel.Cells[15, 20] = ss1.ActiveSheet.Cells[1, 44].Text; //位置
                appExcel.Cells[15, 21] = ss1.ActiveSheet.Cells[1, 92].Text; //金相a
                appExcel.Cells[15, 22] = ss1.ActiveSheet.Cells[1, 45].Text; //位置
                appExcel.Cells[15, 23] = ss1.ActiveSheet.Cells[1, 93].Text; //夹杂a

                appExcel.Cells[16, 1] = "备注：" + ss1.ActiveSheet.Cells[1, 46].Text;
            }
            
            workbook.PrintOut();
            appExcel.Visible = true;
            appExcel = null;
            
            string plsqlPackageName = "WGC3031C.P_SMODIFY1";
            string informationText = "提示信息：试样号信息已更新...!!!";
            list = new ArrayList();//初始集合。
            list.Add(txt_smp_sent_no.Text);//集合中添加值。
            PRINT_Click2(plsqlPackageName, list, informationText);//式样号信息更新
        }

        
        private void PRINT_Click2(string plsqlPackageName, ArrayList list, string informationText)
        {
            GeneralCommon.GStatusBar.Panels[0].Text = "提示信息：操作未能成功...!!";
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
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
                adoCmd.CommandText = plsqlPackageName;
                GeneralCommon.M_CN1.BeginTrans();
                for (int i = 1; i <= list.Count; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    adoCmd.Parameters[i].Value = list[i].ToString() == "" ? "" : list[i].ToString();
                }

                adoCmd.Execute(out value);
                if (plsqlPackageName == "AQC1061P")
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "YY")
                    {
                        ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                    {
                        ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
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


        //式样号信息更新或者委托信息发送。
        private void PRINT_Click(string plsqlPackageName, ArrayList list,string informationText)
        {
            GeneralCommon.GStatusBar.Panels[0].Text = "提示信息：操作未能成功...!!";
            string ret_Result_ErrMsg;
            //int ret_Result_ErrCode = 0;
            string ret_Result_ErrCode;
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
                adoCmd.CommandText = plsqlPackageName;
                GeneralCommon.M_CN1.BeginTrans(); 
                for (int i = 1; i <= list.Count; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    adoCmd.Parameters[i].Value = list[i].ToString() == "" ? "" : list[i].ToString();
                }

                adoCmd.Execute(out value);
                if (plsqlPackageName == "AQC1061P")
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "YY")
                    {
                        //ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrCode = (string)(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                    {
                        //ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrCode = (string)(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
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

        //委托信息发送事件。
        private void CmdSEND_Click(object sender, EventArgs e)
        {
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_smp_sent_no.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入委托单号，再发送委托信息...！", "W", "警告");
                return;
            }
            string plsqlPackageName = "AQC1061P";
            string informationText = "提示信息：委托信息已成功发送...!!!";
            list = new ArrayList();
            list.Add(txt_smp_sent_no.Text);
            list.Add("");
            PRINT_Click(plsqlPackageName, list, informationText);
            base.Form_Cls();
        }

        //spread的ButtonClicked事件，用于第一列checkbox的点击。
        private void ss1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (ss1_Sheet1.Cells[e.Row, 0].Text == "True" && e.Column == 0)
            {
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                ss1_Sheet1.Cells[e.Row, 48].Text = GeneralCommon.sUserID;
                ss1_Sheet1.Cells[e.Row, 49].Text = GeneralCommon.sUsername;
            }
            else if (e.Column == 0)
            {        
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
                ss1_Sheet1.Cells[e.Row, 48].Text = "";
                ss1_Sheet1.Cells[e.Row, 49].Text = "";
            }
        }

        //Spread保存事件。
        public override void Form_Pro()
        {
            int checkTrueCount = 0;
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_check.Checked)
            {
                bool isDelete = false;
                for (int i = 0; i < ss1_Sheet1.RowCount;i++)
                {
                    if(ss1_Sheet1.RowHeader.Cells[i,0].Text == "删除")
                    {
                        isDelete = true;
                        break;
                    }
                }
                if (isDelete)
                {
                    if (GeneralCommon.Gf_MessConfirm("确定删除状态为【删除】的数据吗?", "I", "提示"))
                    {
                        base.p_Pro(1, 1, true, false);
                        reSetToolbarImages();
                    }
                    else
                    { 
                    }
                }
                
            }
            else
            {
                string sQuery = "";
                sQuery = "SELECT Gf_SMP_SEND_NO('"+txt_plt.Text.Trim()+"') FROM DUAL";
                string sampleNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
                if (sampleNo == "") return;

                for (int i = 0; i < ss1_Sheet1.RowCount; i++)
                {
                    if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                    {
                        checkTrueCount++;
                        ss1_Sheet1.Cells[i, 2].Text = sampleNo;
                        if (ss1_Sheet1.Cells[i, 47].Text == "")
                        {
                            ss1_Sheet1.Cells[i, 47].Text = dtp_end_date.RawDate;
                        }
                    }
                }
                if (checkTrueCount > 24)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("一张委托单不能超过24个试样...!!", "W", "警告");
                    return;
                }
                if (checkTrueCount > 2)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("一张委托单不能超过2个试样号！", "W", "警告");
                    return;
                }
                base.p_Pro(1, 1, true, false);
                reSetToolbarImages();
            }
        }

        private void txt_plt_TextChanged(object sender, EventArgs e)
        {
            if (txt_plt.Text == "C1")
            {
                PLT_NAME.Text = "板卷厂";
            }
            else if (txt_plt.Text == "C3")
            {
                PLT_NAME.Text = "中板厂";
            }
            else if (txt_plt.Text == "C2")
            {
                PLT_NAME.Text = "宽厚板厂";
            }
        }



    }
}
