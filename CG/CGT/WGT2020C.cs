using System.Collections;
//using FarPoint.PluginCalendar;
//using InDate;
//using FarPoint.CalcEngine;
//using FarPoint.Excel;[
using System;
using Microsoft.VisualBasic;
//using FarPoint.PluginCalendar.WinForms;
using CommonClass;
//using Microsoft.Office.Interop.Excel;
//using Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;


//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   轧钢作业
//-- Program Name      探伤实绩查询界面
//-- Program ID        WGT2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李超
//-- Coder             袁登科
//-- Date              2012.12.03
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER           DATE                 EDITOR            DESCRIPTION
//   1.0         2012.12.03             袁登科            探伤实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
namespace CG
{
    public partial class WGT2020C : CommonClass.FORMBASE
    {
        public WGT2020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
          
            p_SetMc("探伤日期", CUD_PROD_DATE_FR, "PN", "", "", "", "", imcseq);//0
            p_SetMc("探伤日期", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);//1
            p_SetMc("UST标准", TXT_UST_STAND_NO, "P", "", "", "", "", imcseq);//2
            p_SetMc("生产日期", CUD_PROD_DATE, "P", "", "", "", "", imcseq);//3
            p_SetMc("生产日期", CUD_PROD_DATETO, "P", "", "", "", "", imcseq);//4
            p_SetMc("订单号", TXT_ORD_NO, "P", "", "", "", "", imcseq);//5
            p_SetMc("订单号", CMB_ORD_ITEM, "P", "", "", "", "", imcseq);//6
            p_SetMc("班次", CMB_SHIFT, "P", "", "", "", "", imcseq);//7
            p_SetMc("结论", CMB_UST_DEC, "P", "", "", "", "", imcseq);//8
            p_SetMc("标准号", TXT_STDSPEC, "P", "", "", "", "", imcseq);//9
            p_SetMc("查询号", TXT_MAT_NO, "P", "", "", "", "", imcseq);//10
            p_SetMc("垛位", TXT_F_ADDR, "P", "", "", "", "", imcseq);//11
            p_SetMc("厚度", NMB_UST_THK, "P", "", "", "", "", imcseq);//12
            p_SetMc("宽度", NMB_UST_WID, "P", "", "", "", "", imcseq);//13
            p_SetMc("表面", CMB_SURFGRD, "P", "", "", "", "", imcseq);//14

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;            
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("探伤垛位", "E", "20", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("进程代码", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("尺寸", "E", " ", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("块数", "N", "8", "L", "", "", "", iscseq, iheadrow,"M");//5         
            p_SetSc("改判标准号", "E", "14", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("改判原因", "E", "20", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("结论", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("产品等级", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("表面等级", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("仪器型号", "E", "50", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("探头", "E", "50", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("探伤方式", "E", "50", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("探伤灵敏度", "E", "30", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("检查标准", "E", " ", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("探伤时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"L");//16
            p_SetSc("探伤班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("探伤人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("轧制时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("生产时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"L");//20
            p_SetSc("备注", "E", " ", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("切割", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("矫直", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//23         
            p_SetSc("热处理", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("定尺区分", "E", " ", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("取样代码", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("库", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("垛位", "E", "10", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("入库时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("缺陷", "E", "18", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("厚度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//31
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//32
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//33
            p_SetSc("实绩重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//34     
            p_SetSc("订单号", "E", " ", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("原始订单号", "E", " ", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("板坯厚度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("连铸机号", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("板坯钢种代码", "E", "11", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("板坯钢种名称", "E", "11", "L", "", "", "", iscseq, iheadrow);//40
            p_SetSc("堆冷时间(小时)", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("经RH", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("异常坯", "E", " ", "L", "", "", "", iscseq, iheadrow);//43
            p_SetSc("炉座号", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("在炉时间", "E", " ", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("出炉温度", "E", " ", "L", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("板坯切割时间", "DT", " ", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("矫直机号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("矫直入口温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//49
            p_SetSc("矫直出口温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("订单探伤要求", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("钢板堆冷时间", "N", "5,1", "L", "", "", "", iscseq, iheadrow, "R");//52
            p_SetSc("轧制至探伤间隔", "N", "5,1", "L", "", "", "", iscseq, iheadrow, "R");//53
            
            iheadrow = 0;
            p_spanSpread("作业指示/实绩", 31, 33, iscseq, iheadrow, 1);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
            //ss1.ActiveSheet.RowCount = 205;
            //ss1.ActiveSheet.ColumnCount = 44;
            //for (int i = 0; i < 205; i++)
            //{
            //    for (int j = 0; j < 44; j++)
            //    {
            //        ss1.ActiveSheet.Cells[i, j].Text = "2";
            //    }
            //}
        }
        #endregion

        public override void Form_Ref()
        {
            this.NMB_WGT.Text = "";
            double sumSlabWeight = 0;//实绩重量合计
            base.p_Ref(1,1,true,true);
            for (int i = 0; i < ss1.ActiveSheet.RowCount;i++ )
            {
                sumSlabWeight += (ss1.ActiveSheet.Cells[i, 34].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 34].Text));
                this.NMB_WGT.Text = sumSlabWeight.ToString();
            }
        }
        ///探伤报告
        private void SSCommand1_Click(object sender, EventArgs e)
        {
            if (this.TXT_UST_STAND_NO.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("检查标准必须输入...!", "W", "提示");
                return;
            }
            else if (ss1.ActiveSheet.RowCount == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("没有数据不可导出探伤报告...!", "W", "提示");
                return;
            }
            string modelName = "WGT2020C.xls";
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
            //日期写入
            if (this.CUD_PROD_DATE_FR.RawDate == this.SDT_PROD_DATE_TO.RawDate)
            {

                string dateInputExcel = "日期: " + (this.CUD_PROD_DATE_FR.RawDate).Substring(0, 4) + "年" + (this.CUD_PROD_DATE_FR.RawDate).Substring(4, 2) + "月" + (this.CUD_PROD_DATE_FR.RawDate).Substring(6, 2) + "日";
                appExcel.Cells[2, 4] = dateInputExcel;
            }
            else if (this.CUD_PROD_DATE_FR.RawDate != this.SDT_PROD_DATE_TO.RawDate)
            {
                string dateBeginInputExcel = "日期: " + (this.CUD_PROD_DATE_FR.RawDate).Substring(0, 4) + "年" + (this.CUD_PROD_DATE_FR.RawDate).Substring(4, 2) + "月" + (this.CUD_PROD_DATE_FR.RawDate).Substring(6, 2) + "日";
                string dateEndInputExcel = (this.SDT_PROD_DATE_TO.RawDate).Substring(0, 4) + "年" + (this.SDT_PROD_DATE_TO.RawDate).Substring(4, 2) + "月" + (this.SDT_PROD_DATE_TO.RawDate).Substring(6, 2) + "日";
                string dateInputExcel = dateBeginInputExcel + "--" + dateEndInputExcel;
                appExcel.Cells[2, 4] = dateInputExcel;
            }
            //日期写入完毕
            appExcel.Cells[4, 1] = ss1.ActiveSheet.Cells[0, 11].Text;//仪器型号写入
            appExcel.Cells[4, 2] = ss1.ActiveSheet.Cells[0, 12].Text;//探头写入
            appExcel.Cells[4, 3] = ss1.ActiveSheet.Cells[0, 13].Text;//探伤方式写入
            appExcel.Cells[4, 4] = ss1.ActiveSheet.Cells[0, 14].Text;//探伤灵敏度写入
            //appExcel.Cells[4, 5] = "";//检查标准清空
            //appExcel.Cells[4, 5] = ss1.ActiveSheet.Cells[0,15].Text;//检查标准写入
            appExcel.Cells[4, 7] = TXT_UST_STAND_NO.CD_NAME.Text;//检查标准写入
            for (int i = 0; i < ss1.ActiveSheet.RowCount;i++)
            {
                appExcel.Cells[7 + i, 1] = ss1.ActiveSheet.Cells[i, 0].Text;//标准号      写入
                appExcel.Cells[7 + i, 2] = ss1.ActiveSheet.Cells[i, 1].Text;//垛位        写入
                appExcel.Cells[7 + i, 3] = ss1.ActiveSheet.Cells[i, 2].Text;//钢板号      写入
                appExcel.Cells[7 + i, 4] = ss1.ActiveSheet.Cells[i, 4].Text;//尺寸        写入
                appExcel.Cells[7 + i, 5] = ss1.ActiveSheet.Cells[i, 5].Text;//块数        写入
                appExcel.Cells[7 + i, 6] = ss1.ActiveSheet.Cells[i, 6].Text;//改判标准号  写入
                appExcel.Cells[7 + i, 7] = ss1.ActiveSheet.Cells[i, 7].Text;//改判原因    写入
                appExcel.Cells[7 + i, 8] = ss1.ActiveSheet.Cells[i, 8].Text;//结论        写入
            }
            appExcel.Visible = true;
           // appExcel.Quit();//从内存中退出
            appExcel = null;  
        }

        ///码堆报告
        private void SSCommand2_Click(object sender, EventArgs e)
        {
            if (this.TXT_UST_STAND_NO.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("检查标准必须输入...!", "W", "提示");
                return;
            }
            else if (ss1.ActiveSheet.RowCount == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("没有数据不可导出码堆报告...!", "W", "提示");
                return;
            }
            string modelName = "WGT2222C.xls";
            GeneralCommon.Gp_CopyModel(modelName);//将模板（WGT2222C.xls）导入report文件夹中
            string fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + "report" + "\\" + modelName;//文件的路径，用于打开excel。
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            //关闭excel时提示是否保存保存
            Worksheet worksheet1 = null;/////
                                      
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;//false:关闭时，自动保存excel，不弹出保存框。
            //打开excel
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);  
            //得到excel文件第一页（Sheet1）


            worksheet1 = (Worksheet)workbook.Sheets[1];

          //  Excel.Worksheet worksheet1 = (Excel.Worksheet)workbook.Sheets["Sheet1"];//"Sheet1"为report文件夹下WGT2222C.xls第一个Sheet的名字。
            Microsoft.Office.Interop.Excel.Range range = null;//定义一个区域对象range，以后range随时赋值，用于合并单元格、文本左右对齐等操作。
            range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A2", "K3");  //Range赋值。
            range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();//Range区域内背景色设置。
            //日期写入
            if (this.CUD_PROD_DATE_FR.RawDate == this.SDT_PROD_DATE_TO.RawDate)
            {
                string dateInputExcel = "日期: " + (this.CUD_PROD_DATE_FR.RawDate).Substring(0, 4) + "年" + (this.CUD_PROD_DATE_FR.RawDate).Substring(4, 2) + "月" + (this.CUD_PROD_DATE_FR.RawDate).Substring(6, 2) + "日";
                appExcel.Cells[2, 1] = dateInputExcel;
            }
            else if (this.CUD_PROD_DATE_FR.RawDate != this.SDT_PROD_DATE_TO.RawDate)
            {
                string dateBeginInputExcel = "日期: " + (this.CUD_PROD_DATE_FR.RawDate).Substring(0, 4) + "年" + (this.CUD_PROD_DATE_FR.RawDate).Substring(4, 2) + "月" + (this.CUD_PROD_DATE_FR.RawDate).Substring(6, 2) + "日";
                string dateEndInputExcel = (this.SDT_PROD_DATE_TO.RawDate).Substring(0, 4) + "年" + (this.SDT_PROD_DATE_TO.RawDate).Substring(4, 2) + "月" + (this.SDT_PROD_DATE_TO.RawDate).Substring(6, 2) + "日";
                string dateInputExcel = dateBeginInputExcel + "--" + dateEndInputExcel;
                appExcel.Cells[2, 1] = dateInputExcel;
            }
            //日期写入完毕
            if (ss1.ActiveSheet.RowCount < 30)//当前数据是否有30条。假如没有30条记录，那么直接写入到excel中，不必考虑每隔30条记录一个列小计。
            {
                for (int i = 0; i < ss1.ActiveSheet.RowCount;i++)
                {
                    appExcel.Cells[4 + i, 1] = ss1.ActiveSheet.Cells[i, 1].Text;//货位      写入
                    appExcel.Cells[4 + i, 2] = ss1.ActiveSheet.Cells[i, 0].Text;//品种        写入
                    appExcel.Cells[4 + i, 3] = ss1.ActiveSheet.Cells[i, 2].Text;//钢板号      写入
                    appExcel.Cells[4 + i, 4] = ss1.ActiveSheet.Cells[i, 4].Text;//规格尺寸    写入
                    appExcel.Cells[4 + i, 5] = ss1.ActiveSheet.Cells[i, 34].Text;//重量        写入
                    appExcel.Cells[4 + i, 6] = ss1.ActiveSheet.Cells[i, 8].Text;//结论        写入
                    appExcel.Cells[4 + i, 7] = ss1.ActiveSheet.Cells[i, 17].Text;//探伤人      写入
                    appExcel.Cells[4 + i, 8] = ss1.ActiveSheet.Cells[i, 29].Text;//缺陷记录        写入
                    appExcel.Cells[4 + i, 9] = ss1.ActiveSheet.Cells[i, 3].Text;//进程状态       写入
                    appExcel.Cells[4 + i, 10] = ss1.ActiveSheet.Cells[i, 35].Text;//订单号      写入
                    appExcel.Cells[4 + i,11] = ss1.ActiveSheet.Cells[i, 20].Text;//备注        写入
                }
                //在导入数据的excel文件后直接添加列小计
                //设置Range区域内的背景色以及合并单元格。
                range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A" + (ss1.ActiveSheet.RowCount + 4), "A" + (ss1.ActiveSheet.RowCount + 5));
                range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
                range.Merge(0);
                //设置excel结果栏
                appExcel.Cells[ss1.ActiveSheet.RowCount + 4, 1] = "合计";
                appExcel.Cells[ss1.ActiveSheet.RowCount + 4, 2] = "块数";
                appExcel.Cells[ss1.ActiveSheet.RowCount + 5, 2] = "重量";
                appExcel.Cells[ss1.ActiveSheet.RowCount + 4, 3] = ss1.ActiveSheet.RowCount;
                appExcel.Cells[ss1.ActiveSheet.RowCount + 5, 3] = NMB_WGT.Text;

                range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("D" + (ss1.ActiveSheet.RowCount + 4), "K" + (ss1.ActiveSheet.RowCount + 5));
                range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
                //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;//设置Range区域内文本居左
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;//Excel.XlHAlign.xlHAlignLeft;//设置Range区域内文本居左
                range.Merge(0);
                appExcel.Cells[ss1.ActiveSheet.RowCount + 4, 4] = "验收标准:" + ss1.ActiveSheet.Cells[0, 15].Text;
            }
            else//当前Spread拥有的记录大于30条，那么每30条进行一个列小结。
            {
                int slabSumCount = 0;//当前数据共有多少个30条记录
                int slabSumCount30 = 0;//取余
                slabSumCount = ss1.ActiveSheet.RowCount / 30;
                slabSumCount30 = ss1.ActiveSheet.RowCount % 30;
                ArrayList array = new ArrayList();//定义集合，内为每三十条记录的总重量。用于每30条记录得到其重量。
                double sumSlabInteverWeight = 0;
                for (int i = 1; i <= ss1.ActiveSheet.RowCount;i++)
                {
                    sumSlabInteverWeight += (ss1.ActiveSheet.Cells[i - 1, 34].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i - 1, 34].Text));
                    if (i % 30 == 0)//每循环三十条记录时将重量放入集合array中，并将变量清空
                    {
                        array.Add(sumSlabInteverWeight);
                        sumSlabInteverWeight = 0;
                    }
                }
                double slabC = 0;//集合中各个数据的总和。用于最后得到余数的重量：总重量-slabC。
                for(int i=0;i<array.Count;i++)
                {             
                    slabC += double.Parse(array[i].ToString());               
                }
                object misValue = Type.Missing;
                //先将数据全部写入excel中
                for (int i = 0; i < ss1.ActiveSheet.RowCount;i++)
                {                   
                    appExcel.Cells[4 + i, 1] = ss1.ActiveSheet.Cells[i, 1].Text;//货位      写入
                    appExcel.Cells[4 + i, 2] = ss1.ActiveSheet.Cells[i, 0].Text;//品种        写入
                    appExcel.Cells[4 + i, 3] = ss1.ActiveSheet.Cells[i, 2].Text;//钢板号      写入
                    appExcel.Cells[4 + i, 4] = ss1.ActiveSheet.Cells[i, 4].Text;//规格尺寸    写入
                    appExcel.Cells[4 + i, 5] = ss1.ActiveSheet.Cells[i, 34].Text;//重量        写入
                    appExcel.Cells[4 + i, 6] = ss1.ActiveSheet.Cells[i, 8].Text;//结论        写入
                    appExcel.Cells[4 + i, 7] = ss1.ActiveSheet.Cells[i, 18].Text;//探伤人      写入
                    appExcel.Cells[4 + i, 8] = ss1.ActiveSheet.Cells[i, 30].Text;//缺陷记录        写入
                    appExcel.Cells[4 + i, 9] = ss1.ActiveSheet.Cells[i, 3].Text;//进程状态       写入
                    appExcel.Cells[4 + i,10] = ss1.ActiveSheet.Cells[i, 35].Text;//订单号      写入
                    appExcel.Cells[4 + i,11] = ss1.ActiveSheet.Cells[i, 21].Text;//备注        写入 
                }
                //写入完毕

                //每隔30条数据插入两行，并在新插入的两行上写入数据设置总结栏（即列小结）
                int j = 0;
                int seq = 0;
                for (int i = 1; i <= slabSumCount;i++)
                { 
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.Rows[30 * i + 4 + j, misValue];                 
                    range.Insert(XlInsertShiftDirection.xlShiftDown);//插入一行
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.Rows[30 * i + 4 + j, misValue];
                    range.Insert(XlInsertShiftDirection.xlShiftDown);//插入一行

                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A" + (30 * i + 4 + j), "A" + (30 * i + 4 + 1 + j));
                    range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
                    range.Merge(0);//合并为一个单元格,内容为“合计”。

                    appExcel.Cells[30 * i + 4 + j, 1] = "合计";
                    appExcel.Cells[30 * i + 4 + j, 2] = "块数";
                    appExcel.Cells[30 * i + 4 + 1 + j, 2] = "重量";
                    appExcel.Cells[30 * i + 4 + j, 3] = "30";                   
                    appExcel.Cells[30 * i + 4 + 1 + j, 3] = array[seq++].ToString();//重量：
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("D" + (30 * i + 4 + j), "K" + (30 * i + 4 + 1 + j));
                    range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
                    //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;//Excel.XlHAlign.xlHAlignLeft;
                    range.Merge(0);//合并为一个单元格，内容为“验收标准”。
                    appExcel.Cells[30 * i + 4 + j, 4] = "验收标准:" + ss1.ActiveSheet.Cells[0, 15].Text;  
                    j += 2;
                }
                //每隔30条数据插入两行，并设置总结栏 完毕
                //Spread中记录不为30的整数倍，取余的记录在excel末尾再添加一个总结栏（即列小计）
                if(slabSumCount30 != 0)
                {
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A" + (ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2), "A" + (ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1));
                    range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
                    range.Merge(0);

                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2, 1] = "合计";
                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2, 2] = "块数";
                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1, 2] = "重量";
                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2, 3] = ss1.ActiveSheet.RowCount - slabSumCount * 30;
                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1, 3] = double.Parse(NMB_WGT.Text) - slabC;
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("D" + (ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2), "K" + (ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1));
                    range.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 255, 0).ToArgb();
               //   range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    range.Merge(0);
                    appExcel.Cells[ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2, 4] = "验收标准:" + ss1.ActiveSheet.Cells[0, 15].Text; 
                }
                //先将excel中每个单元格的内容居中
                range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A4", "K" + (ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1 - 2));
                //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                // 遍历excel，每隔30行，设置“验收标准”栏内容据左。
                slabSumCount = 1;
                for (int i = 0; i <= ss1.ActiveSheet.RowCount + 4 + slabSumCount * 2 + 1;i++ )
                {
                    if(i>=34&&((i-34)%32==0))
                    {
                        int excelIndex = ((32 * slabSumCount++) + 2);
                        range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("D" + excelIndex, "K" + (++excelIndex));
                        //range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;//内容居左。
                        range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;//内容居左。
                    }
                }
                
            }
            appExcel.Visible = true; //excel可见
           // appExcel.Quit();//从内存中退出。
            appExcel = null;//释放资源。
        }

        private void TXT_ORD_NO_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string sQuery;
            sQuery = " SELECT  ORD_ITEM FROM CP_PRC WHERE ORD_NO = '" + TXT_ORD_NO.Text.Trim() + "' ";
            GeneralCommon.Gf_ComboAdd(CMB_ORD_ITEM, sQuery);
        }

       
       


    }
}
