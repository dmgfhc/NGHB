using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;
using System.Drawing;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace CG
{
    public partial class WGT2012C : CommonClass.FORMBASE
    {
        public WGT2012C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        System.Windows.Forms.TextBox txt_line = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox txt_rec_sts = new System.Windows.Forms.TextBox();

        System.Windows.Forms.TextBox TXT_TO_CUR_INV = new System.Windows.Forms.TextBox();
        System.Windows.Forms.TextBox TXT_CUST_CD = new System.Windows.Forms.TextBox();

        double iF_mm;
        double iT_mm;

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            imcseq = 1;
            p_McIni(Mc1, false);
            p_SetMc("工厂", txt_plt, "P", "", "", "", "", 1);
            p_SetMc(txt_plate_no, "P", "", "", "", 1, "");
            p_SetMc(udt_date_fr, "P", "", "", "", 1, "");
            p_SetMc(udt_date_to, "P", "", "", "", 1, "");
            p_SetMc(txt_line, "P", "", "", "", 1, "");
            p_SetMc(txt_stdspec, "P", "", "", "", 1, "");
            p_SetMc(txt_rec_sts, "P", "", "", "", 1, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", 1, "");
            p_SetMc(txt_loc, "P", "", "", "", 1, "");


            p_ScIni(ss1, Sc1, 0, true, false);

            iheadrow = 1;
            iscseq = 1;
          
            p_SetSc("钢板号", "E", "", "PI", "", "", "", 1, 0, "M");//0
            p_SetSc("进程代码", "E", "", "L", "", "", "", 1, 0, "M");//1
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", 1, 0);//2
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", 1, 0);//3
            p_SetSc("长度", "N", "8,1", "L", "", "", "", 1, 0);//4

            p_SetSc("重量", "N", "15,3", "L", "", "", "", 1, 0);//5
            p_SetSc("标准号", "E", "", "L", "", "", "", 1, 0);//6
            p_SetSc("表面等级", "E", "", "L", "", "", "", 1, 0);//7
            p_SetSc("探伤", "E", "", "L", "", "", "", 1, 0);//8
            p_SetSc("切割", "E", "", "L", "", "", "", 1, 0);//9

            p_SetSc("矫直", "E", "", "L", "", "", "", 1, 0);//10
            p_SetSc("热处理", "E", "", "L", "", "", "", 1, 0);//11   
            p_SetSc("其他", "E", "", "L", "", "", "", 1, 0);//12
            p_SetSc("定尺", "E", "", "L", "", "", "", 1, 0);//13
            p_SetSc("切边", "E", "", "L", "", "", "", 1, 0);//14

            p_SetSc("取样长度", "N", "8,1", "L", "", "", "", 1, 0);//15
            p_SetSc("客户代码", "E", "", "L", "", "", "", 1, 0);//16
            p_SetSc("客户名称", "E", "", "L", "", "", "", 1, 0);//17
            p_SetSc("备注", "E", "", "L", "", "", "", 1, 0);//18
            p_SetSc("钢种", "E", "", "L", "", "", "", 1, 0);//19

            p_SetSc("打印标准", "E", "", "L", "", "", "", 1, 0);//20
            p_SetSc("探伤代码", "E", "", "L", "", "", "", 1, 0);//21
            p_SetSc("加喷内容", "E", "", "L", "", "", "", 1, 0);//22    
            p_SetSc("喷印", "C", "", "L", "", "", "", 1, 0);//23
            p_SetSc("冲印", "C", "", "L", "", "", "", 1, 0);//24

            p_SetSc("侧喷", "C", "", "L", "", "", "", 1, 0);//25       
            p_SetSc("生产日期", "DT", "", "L", "", "", "", 1, 0);//26
            p_SetSc("紧急订单", "E", "", "L", "", "", "", 1, 0, "M");//27
            p_SetSc("作业人员", "E", "", "L", "", "", "", 1, 0, "M");//28
            p_SetSc("厚度上限", "N", "4,2", "L", "", "", "", 1, 0, "M");//29
            p_SetSc("厚度下限", "N", "4,2", "L", "", "", "", 1, 0, "M");//30
            p_SetSc("宽度上限", "N", "3,1", "L", "", "", "", 1, 0, "M");//31
            p_SetSc("宽度下限", "N", "3,1", "L", "", "", "", 1, 0, "M");//32
            p_SetSc("长度上限", "N", "6,1", "L", "", "", "", 1, 0, "M");//33
            p_SetSc("长度下限", "N", "6,1", "L", "", "", "", 1, 0, "M");//34
            p_SetSc("母板备注", "E", "100", "L", "", "", "", 1, 0, "M");//35
            p_SetSc("侧喷加喷", "E", "100", "L", "", "", "", 1, 0, "M");//36
            p_SetSc("认证加喷", "E", "100", "L", "", "", "", 1, 0, "M");//37
            p_SetSc("取样代码", "E", "2", "L", "", "", "", 1, 0, "M");//38
            p_SetSc("轧制异常", "E", "100", "L", "", "", "", 1, 0, "M");//39
            p_SetSc("船徽", "E", "2", "L", "", "", "", 1, 0, "M");//40
            p_SetSc("班次", "E", "10", "L", "", "", "", 1, 0, "M");//41
            p_SetSc("冲印加喷", "E", "100", "L", "", "", "", 1, 0, "M");//42
            p_SetSc("修磨坯", "E", "5", "L", "", "", "", 1, 0, "M");//43
            p_SetSc("表面客户要求", "E", "5", "L", "", "", "", 1, 0, "M");//44
            p_SetSc("钢板不平度1", "E", "10", "L", "", "", "", 1, 0, "M");//45
            p_SetSc("测量长度1", "E", "10", "L", "", "", "", 1, 0, "M");//46
            p_SetSc("钢板不平度2", "E", "10", "L", "", "", "", 1, 0, "M");//47
            p_SetSc("测量长度2", "E", "10", "L", "", "", "", 1, 0, "M");//48
            p_SetSc("船徽代码", "E", "2", "L", "", "", "", 1, 0, "M");//49
            p_SetSc("多船级社船徽代码", "E", "2", "L", "", "", "", 1, 0, "M");//50
            p_SetSc("多船级社钢种", "E", "", "L", "", "", "", 1, 0, "M");//51
            p_SetSc("班别", "E", "10", "L", "", "", "", 1, 0, "M");//52




            //iheadrow = 0;
           // p_spanSpread("厚度", 29, 30, iscseq, iheadrow, 2);
            //p_spanSpread("宽度", 31, 32, iscseq, iheadrow, 1);
            //p_spanSpread("长度", 33, 34, iscseq, iheadrow, 1);
          
         


          
        }

        private void WGT2012C_Load(object sender, EventArgs e)
        {
            Form_Define();
            base.sAuthority = "1111";
            checkBox1.Checked = true;
            txt_plt.Text = "C2";
            this.txt_plt_name.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_NAME FROM ZP_CD WHERE CD_MANA_NO = 'C0001' AND CD ='" + txt_plt.Text + "'");

            txt_line.Text = "1";
            txt_rec_sts.Text = "1";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            udt_date_fr.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD')from dual");
            udt_date_to.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD')from dual");
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            plateNo = "";
            plateIndex = -1;
            txt_plt.Text = "C2";
            this.txt_plt_name.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_NAME FROM ZP_CD WHERE CD_MANA_NO = 'C0001' AND CD ='" + txt_plt.Text + "'");
            txt_line.Text = "1";
         
           // txt_stdspec_chg.Text = "";

            checkBox1.Checked = true;
            checkBox2.Checked = false;
            txt_rec_sts.Text = "1";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            //if (checkBox1.Checked)
            //{
            //    GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
            //    GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
            //}
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
            return false;
        }


        public override void Form_Ref()
        {
            string currentDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMM')from dual");
            p_Ref(1, 1, true, true);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
           // SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[2], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], false);

          
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

            if (this.checkBox2.Checked)
            {
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList1.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "T";
            }


            GeneralCommon.MDIToolBar.Refresh();

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
            if (this.checkBox2.Checked)
            {
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList1.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "T";
            }
            GeneralCommon.MDIToolBar.Refresh();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                txt_rec_sts.Text = "1";
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();
            }
            else
            {
                checkBox2.Checked = true;
                txt_rec_sts.Text = "2";
            }
            this.ss1_Sheet1.RowCount = 0;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                txt_rec_sts.Text = "2";
                GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList1.Images[2];
                GeneralCommon.MDIToolBar.Buttons[4].Tag = "T";
                GeneralCommon.MDIToolBar.Refresh();
            }
            else
            {
                checkBox1.Checked = true;
                txt_rec_sts.Text = "1";
            }
            this.ss1_Sheet1.RowCount = 0;
        }

        string plateNo = "";
        int plateIndex = -1;
        protected override void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
           // base.ss_CellClickEvent(sender, e);
            FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)sender;
            if (e.ColumnHeader) return;
            //if (e.RowHeader) return;
            plateNo = this.ss1_Sheet1.Cells[e.Row, 0].Text.Trim();
            plateIndex = e.Row;

           if(e.RowHeader)
           {
               if(this.ss1_Sheet1.RowHeader.Cells[e.Row,0].Text =="")
               {
                   this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                   SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.Cyan);
                   this.ss1_Sheet1.Cells[e.Row, 28].Text = GeneralCommon.sUserID;
               }
               else
               {
                   this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
                   SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.White);
                   this.ss1_Sheet1.Cells[e.Row, 28].Text = "";
               }
           }

        }



       
        //钢板信息导出
        private void resetExcelName(string currentReportPath, string targetExcelName)
        {        
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\WGT2012C.xls";
            
            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText(string targetExcelName, int plateIndex)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            //导出EXCEL表单，判断是否冲印
            string Punchchk;
            string Punch =this.ss1.ActiveSheet.Cells[plateIndex, 24].Text;
            string Paint = this.ss1.ActiveSheet.Cells[plateIndex, 23].Text;
            string Edge  = this.ss1.ActiveSheet.Cells[plateIndex, 25].Text;


            if (Punch == "True")
            {
                Punchchk = "是";
            }
            else
            {
                Punchchk = "否";
            }
            appExcel.Cells[1, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 26].Text;//生产日期
            appExcel.Cells[1, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 41].Text;//班次
            if (Paint == "True")
            {
                appExcel.Cells[3, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 0].Text;//产品号
                appExcel.Cells[4, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 19].Text;//标识钢种
                appExcel.Cells[5, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 2].Text;//规格
                appExcel.Cells[5, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 3].Text;//规格
                appExcel.Cells[5, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 4].Text;//规格
                appExcel.Cells[6, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 22].Text;//加喷内容
            }
            if (Edge == "True")
            {
                appExcel.Cells[7, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 0].Text;//产品号
                appExcel.Cells[8, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 19].Text;//标识钢种
                appExcel.Cells[9, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 2].Text;//规格
                appExcel.Cells[9, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 3].Text;//规格
                appExcel.Cells[9, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 4].Text;//规格
                appExcel.Cells[10, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 36].Text;//侧喷加喷
                appExcel.Cells[11, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 16].Text;//客户代码
            }

            if (Punch == "True")
            {
                appExcel.Cells[12, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 0].Text;//产品号
                appExcel.Cells[13, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 19].Text;//钢种
                appExcel.Cells[14, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 42].Text;//冲印加喷
                appExcel.Cells[15, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 40].Text;//船徽
            }

            appExcel.Cells[16, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 8].Text;//探伤
            appExcel.Cells[17, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 37].Text;//认证加喷
            appExcel.Cells[17, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 14].Text;//切边
            appExcel.Cells[18, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 15].Text;//取样长度
            appExcel.Cells[18, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 38].Text;//取样项目
            appExcel.Cells[20, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 13].Text;//定尺
            appExcel.Cells[3, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 21].Text;//探伤代码
            appExcel.Cells[6, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 11].Text;//热处理
            appExcel.Cells[22, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 18].Text;//订单备注

            appExcel.Cells[25, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 12].Text;//其它
            appExcel.Cells[16, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 5].Text;//重量
            appExcel.Cells[22, 1] = this.ss1.ActiveSheet.Cells[plateIndex, 30].Text + "~" + this.ss1.ActiveSheet.Cells[plateIndex, 29].Text;//厚度
            appExcel.Cells[22, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 34].Text + "~" + this.ss1.ActiveSheet.Cells[plateIndex, 33].Text;//长度
            appExcel.Cells[22, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 32].Text + "~" + this.ss1.ActiveSheet.Cells[plateIndex, 31].Text;//宽度
            appExcel.Cells[23, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 10].Text;//矫直
            appExcel.Cells[24, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 39].Text;//轧制异常
            
            appExcel.Cells[4, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 20].Text;//标识标准
            appExcel.Cells[24, 4] = this.ss1.ActiveSheet.Cells[plateIndex, 43].Text;//修磨坯
            appExcel.Cells[3, 5] = this.ss1.ActiveSheet.Cells[plateIndex, 44].Text;//表面客户要求

            appExcel.Cells[23, 2] = this.ss1.ActiveSheet.Cells[plateIndex, 45].Text + ";" + this.ss1.ActiveSheet.Cells[plateIndex, 46].Text;//不平度1、长度1
            appExcel.Cells[23, 3] = this.ss1.ActiveSheet.Cells[plateIndex, 47].Text + ";" + this.ss1.ActiveSheet.Cells[plateIndex, 48].Text;//不平度2、长度2



      
        
            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;  
        }

        //表喷信息导出
        private void resetExcelName1(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\WGT2012C_1.xls";//表喷信息EXCEL路径

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText1(string targetExcelName)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            for (int i = 1; i <= ss1_Sheet1.RowCount; i++)
            {

                int j = i - 1;
                int k = i + 1;

                appExcel.Cells[k, 1] = "C2";//喷印厂标
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, 49].Text;//喷印船徽1
                appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, 50].Text;//喷印船徽2
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, 0].Text;//钢板号
                appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, 2].Text;//厚
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, 3].Text;//宽
                appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, 4].Text;//长
                appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, 19].Text;//钢种
                appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, 20].Text;//执行标准
                appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[j, 21].Text;//探伤标志
                appExcel.Cells[k, 11] = this.ss1.ActiveSheet.Cells[j, 26].Text;//日期
                appExcel.Cells[k, 12] = this.ss1.ActiveSheet.Cells[j, 52].Text;//班别
                appExcel.Cells[k, 13] = this.ss1.ActiveSheet.Cells[j, 22].Text;//加喷

            }

            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;
        }

        //侧喷信息导出
        private void resetExcelName2(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\WGT2012C_2.xls";//侧喷信息EXCEL路径

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText2(string targetExcelName)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            for (int i = 1; i <= ss1_Sheet1.RowCount; i++)
            {

                int j = i - 1;
                int k = i + 1;


                appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, 0].Text;//钢板号
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, 19].Text;//钢种
                appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, 2].Text;//厚
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, 3].Text;//宽
                appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, 4].Text;//长
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, 22].Text;//加喷

            }

            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;
        }

        //钢印信息导出
        private void resetExcelName3(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\WGT2012C_3.xls";//钢印信息EXCEL路径

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText3(string targetExcelName)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            for (int i = 1; i <= ss1_Sheet1.RowCount; i++)
            {

                int j = i - 1;
                int k = i + 1;

                appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, 49].Text;//喷印船徽1
                appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, 50].Text;//喷印船徽2
                appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, 0].Text;//钢板号
                appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, 19].Text;//钢种1
                appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, 20].Text;//执行标准

            }

            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (plateNo == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请选择你要导出的钢板号", "W", "警告");
                return;
            }
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + plateNo + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                setExcelText(targetExcelName, plateIndex);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }


            private void button2_Click(object sender, EventArgs e)
            {
                if (ss1_Sheet1.RowCount == 0)
                {
                    return;

                }
                try
                {
                    string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                    string targetExcelName = currentReportPath + "\\"  +"表喷.xls";
                    resetExcelName1(currentReportPath, targetExcelName);
                    setExcelText1(targetExcelName);
                }
                catch (Exception ex)
                {
                    GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
                }


            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (ss1_Sheet1.RowCount == 0)
                {
                    return;

                }
                try
                {
                    string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                    string targetExcelName = currentReportPath + "\\" + "侧喷.xls";
                    resetExcelName2(currentReportPath, targetExcelName);
                    setExcelText2(targetExcelName);
                }
                catch (Exception ex)
                {
                    GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
                }



            }


            private void button4_Click(object sender, EventArgs e)
            {

                if (ss1_Sheet1.RowCount == 0)
                {
                    return;

                }
                try
                {
                    string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                    string targetExcelName = currentReportPath + "\\" + "钢印.xls";
                    resetExcelName3(currentReportPath, targetExcelName);
                    setExcelText3(targetExcelName);
                }
                catch (Exception ex)
                {
                    GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
                }


            }

       

        private void ss1_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss1.ActiveSheet.GetSelection(0);
            int iRowcount = cr.Row + cr.RowCount - 1;
            if (cr.RowCount <= 1) return;

            for (int iRow = cr.Row + 1; iRow <= iRowcount; iRow++)
            {
                if (ss1.ActiveSheet.RowHeader.Rows[iRow].Label != "修改")
                {
                    ss1.ActiveSheet.RowHeader.Rows[iRow].Label = "修改";
                    SpreadCommon.Gp_Sp_RowColor(ss1, iRow, Color.Black, Color.Cyan);
                    this.ss1_Sheet1.Cells[iRow, 28].Text = GeneralCommon.sUserID;
                }
                else
                {
                    ss1.ActiveSheet.RowHeader.Rows[iRow].Label = "";
                    SpreadCommon.Gp_Sp_RowColor(ss1, iRow, Color.Black, Color.White);
                    this.ss1_Sheet1.Cells[iRow, 28].Text = "";
                }
            }
        }
        
    }
}
