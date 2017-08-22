using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;
using Microsoft.Office.Interop.Excel;
using System.IO;


///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            轧钢计划查询界面_CGG2040C                                
///-- 程序ID            _CGG2040C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.08.16                                                
///-- 处理描述          轧钢计划查询界面_CGG2040C                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.08.16        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGG2040C : CommonClass.FORMBASE
    {
        public CGG2040C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();

        const int SS2_EMP_NO = 20;
        const int SS2_INS_DATE = 21;

        const int SS3_RST_CUT = 9;
        const int SS3_CUT_SEQ = 14;
        const int SS3_REMARK = 15;
        //导出ExcelPrn2中用到
        // Add by liqian at 2012-03-02
        const int SS3_UPD_EMP = 18;

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("起始板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);


            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("查询日期", udFmDate, "P", "", "", "", "", imcseq);
            p_SetMc("查询日期", udToDate, "P", "", "", "", "", imcseq);

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("查询日期", udFmDate2, "P", "", "", "", "", imcseq);
            p_SetMc("查询日期", udToDate2, "P", "", "", "", "", imcseq);
            p_SetMc("是否切割完成", CBO_CUTYN, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("轧制钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("订单标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("断面排钢", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("轧制方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("坯厚", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("坯宽", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("坯长", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("坯实重", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("坯料堆放位置", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("成品厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("成品宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("成品长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("分段剪", "E", "50", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("子板块数", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("厚度公差上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("厚度公差下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("定尺区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("是否控轧", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("是否切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("探伤区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("取样号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//23
            p_SetSc("INS_DATE", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//24


            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 1;
            iscseq = 2;
            p_SetSc("计划日期", "E", "50", "I", "", "", "", iscseq, iheadrow, "L");//0  
            p_SetSc("序列", "E", "14", "PI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("钢种名称", "E", "30", "I", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("厚度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//5  
            p_SetSc("H/C", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("块数", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "10,3", "I", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("订单号", "E", "20", "I", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("序列", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("代码", "E", "6", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("标准号", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("厚度", "N", "4,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("宽度", "E", "4", "I", "", "", "", iscseq, iheadrow, "R");//15 
            p_SetSc("长度", "E", "4", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("备注", "E", "500", "I", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("编辑人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "L");//20  
            p_SetSc("计划时间", "D", "", "IL", "", "", "", iscseq, iheadrow, "M");//21

            iheadrow = 0;
            p_spanSpread("板坯", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("客户", 11, 12, iscseq, iheadrow, 1);
            p_spanSpread("产品", 14, 16, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 1;
            iscseq = 3;
            p_SetSc("计划日期", "E", "50", "I", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("序列", "E", "14", "PI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("订单号", "E", "30", "I", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("序列", "E", "20", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种/标准", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "N", "10,1", "I", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("计划", "N", "10", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("实绩", "N", "10", "I", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("剩余", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("厚度", "N", "10,1", "I", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("宽度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("长度", "N", "10", "I", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("倍尺", "N", "10", "I", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("备注", "E", "500", "I", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("编辑人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("编辑时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("切割人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("切割时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//19

            iheadrow = 0;
            p_spanSpread("板坯", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("切割块数", 8, 10, iscseq, iheadrow, 1);
            p_spanSpread("产品", 11, 14, iscseq, iheadrow, 1);
        }

        private void CGG2040C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGG2040NC";
            Form_Define();
        }



        // 重写查询
        public override void Form_Ref()
        {
            if (0 == tab_bed_cd.SelectedIndex)
            {
                p_Ref(1, 1, true, true);
            }
            else if (1 == tab_bed_cd.SelectedIndex)
            {
                p_Ref(2, 2, true, true);
            }
            else if (2 == tab_bed_cd.SelectedIndex)
            {
                p_Ref(3, 3, true, true);
            }
        }

        // 重写保存
        public override void Form_Pro()
        {
            int iCount;

            switch (tab_bed_cd.SelectedIndex)
            {
                case 1:
                    for (iCount = 1; iCount <= ss2.ActiveSheet.RowCount; iCount++)
                    {
                        if (ss2.ActiveSheet.RowHeader.Cells[iCount - 1, 0].Text == "增加")
                        {
                            ss2.ActiveSheet.Cells[iCount - 1, SS2_INS_DATE].Text = TXT_DATE.Text;
                        }
                    }
                    p_Pro(0, 2, true, true);
                    break;
                case 2:
                    p_Pro(0


                        , 3, true, true);
                    SS3_Format();
                    break;
            }
        }

        public void SS3_Format()
        {
            int iRow;
            int iCol;
            double iCUT_SEQ;

            if (ss3.ActiveSheet.RowCount > 0)
            {

                for (iRow = 1; iRow <= ss3.ActiveSheet.RowCount; iRow++)
                {

                    for (iCol = 6; iCol <= 15; iCol++)
                    {

                        if (iCol == SS3_CUT_SEQ)
                        {

                            iCUT_SEQ = convertX(ss3.ActiveSheet.Cells[iRow - 1, iCol - 1].Text);

                            if (iCUT_SEQ == 0)
                            {
                                Gp_Sp_BlockColor(ss3, 2, ss3.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP1.BackColor);
                            }
                            else
                            {
                                Gp_Sp_BlockColor(ss3, 2, ss3.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP3.BackColor);
                            }
                        }
                    }
                }
            }
            Gp_Sp_BlockColor(ss3, SS3_RST_CUT, SS3_RST_CUT, 0, ss3.ActiveSheet.RowCount - 1, Color.Black, SSP4.BackColor);
            Gp_Sp_BlockColor(ss3, SS3_REMARK, SS3_REMARK, 0, ss3.ActiveSheet.RowCount - 1, Color.Black, SSP4.BackColor);

        }

        public override void Form_Del()
        {
            switch (tab_bed_cd.SelectedIndex)
            {
                case 1:
                    p_del(0, 2, true);
                    break;
                case 2:
                    p_del(0, 3, true);
                    break;
            }
        }

        //EXCEL功能实现
        /// <summary>
        /// 轧钢作业计划打印
        /// </summary>
        /// <param name="Ex_File_Name"></param>
        /// <param name="e"></param>
        private void ExcelPrn(string Ex_File_Name, FpSpread e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板轧钢计划查询导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                if (!Directory.Exists(currentReportPath))
                {
                    Directory.CreateDirectory(currentReportPath);
                }
                string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\" + Ex_File_Name + ".xls";

                if (File.Exists(targetExcelName))
                {
                    File.Delete(targetExcelName);
                }
                File.Copy(sourceExcelName, targetExcelName);
                int rowCount = e.ActiveSheet.RowCount;
                setExcelText(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void setExcelText(string targetExcelName, int rowCount)
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

            int i;
            int k;
            string sDateText;
            string sDate;
            string sDateNext;
            sDate = DateTime.Now.ToString("yyyyMMddHHmm");
            sDateText = sDate.Substring(0, 4) + "年" + sDate.Substring(4, 2) + "月" + sDate.Substring(6, 2) + "日 " + sDate.Substring(8, 2) + "点" + sDate.Substring(10, 2) + "分";
            appExcel.Cells[2, 1] = sDateText;
            for (i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[i + 4, 1] = i + 1;
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 0; k <= 8; k++)
                {
                    appExcel.Cells[i + 4, k + 2] = ss1.ActiveSheet.Cells[i, k].Text;
                }
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 11; k <= 22; k++)
                {
                    appExcel.Cells[i + 4, k] = ss1.ActiveSheet.Cells[i, k].Text;
                }
            }
            appExcel.Visible = true;
            //  appExcel.Quit();//从内存中退出
            appExcel = null;
            return;
        }
        /// <summary>
        /// 轧钢大计划打印
        /// </summary>
        /// <param name="Ex_File_Name"></param>
        /// <param name="e"></param>
        private void ExcelPrn1(string Ex_File_Name, FpSpread e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板轧钢计划查询导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                if (!Directory.Exists(currentReportPath))
                {
                    Directory.CreateDirectory(currentReportPath);
                }
                string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\" + Ex_File_Name + ".xls";

                if (File.Exists(targetExcelName))
                {
                    File.Delete(targetExcelName);
                }
                File.Copy(sourceExcelName, targetExcelName);
                int rowCount = e.ActiveSheet.RowCount;
                setExcelText1(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void setExcelText1(string targetExcelName, int rowCount)
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

            int i;
            int k;
            //string sDateText;
            //string sDate;
            //string sDateNext;
            //sDate = DateTime.Now.ToString("yyyyMMddHHmm");
            //sDateText = sDate.Substring(0, 4) + "年" + sDate.Substring(4, 2) + "月" + sDate.Substring(6, 2) + "日 " + sDate.Substring(8, 2) + "点" + sDate.Substring(10, 2) + "分";
            //appExcel.Cells[2, 1] = sDateText;
            for (i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                //appExcel.Cells[i + 4, 1] = i + 1;
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 0; k <= 0; k++)
                {
                    appExcel.Cells[i + 4, k + 1] = ss1.ActiveSheet.Cells[i, k].Text;
                }
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 2; k <= 19; k++)
                {
                    appExcel.Cells[i + 4, k] = ss1.ActiveSheet.Cells[i, k].Text;
                }
            }
            appExcel.Visible = true;
            //  appExcel.Quit();//从内存中退出
            appExcel = null;
            return;
        }
        /// <summary>
        /// 余坯切割计划打印
        /// </summary>
        /// <param name="Ex_File_Name"></param>
        /// <param name="e"></param>
        private void ExcelPrn2(string Ex_File_Name, FpSpread e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板轧钢计划查询导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                if (!Directory.Exists(currentReportPath))
                {
                    Directory.CreateDirectory(currentReportPath);
                }
                string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\" + Ex_File_Name + ".xls";

                if (File.Exists(targetExcelName))
                {
                    File.Delete(targetExcelName);
                }
                File.Copy(sourceExcelName, targetExcelName);
                int rowCount = e.ActiveSheet.RowCount;
                setExcelText2(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void setExcelText2(string targetExcelName, int rowCount)
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

            int i;
            int k;
            //string sDateText;
            //string sDate;
            //string sDateNext;
            //sDate = DateTime.Now.ToString("yyyyMMddHHmm");
            //sDateText = sDate.Substring(0, 4) + "年" + sDate.Substring(4, 2) + "月" + sDate.Substring(6, 2) + "日 " + sDate.Substring(8, 2) + "点" + sDate.Substring(10, 2) + "分";
            //appExcel.Cells[2, 1] = sDateText;
            for (i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                //appExcel.Cells[i + 4, 1] = i + 1;
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 0; k <= 0; k++)
                {
                    appExcel.Cells[i + 4, k + 1] = ss1.ActiveSheet.Cells[i, k].Text;
                }
                //EXCEL里面数组从1开始，SPREAD从0开始，注意循环赋值的时候索引值需要错开，也就是让EXCEL的顺序和SPREAD的顺序保持一致
                for (k = 2; k <= 15; k++)
                {
                    appExcel.Cells[i + 4, k] = ss1.ActiveSheet.Cells[i, k].Text;
                }
            }
            appExcel.Visible = true;
            //  appExcel.Quit();//从内存中退出
            appExcel = null;
            return;
        }

        public override void Spread_Exc()
        {
            switch (tab_bed_cd.SelectedIndex)
            {
                case 0:
                    ExcelPrn("CGG2040C", ss1);
                    break;
                case 1:
                    ExcelPrn1("CGG2041C", ss2);
                    break;
                case 2:
                    ExcelPrn2("CGG2042C", ss3);
                    break;
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

        private void SCmd2_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("LoadExcel"))
            {
                LoadExcel LoadExcel = new LoadExcel();
                LoadExcel.MdiParent = GeneralCommon.MDIMain;
                LoadExcel.Show();
                LoadExcel.WindowState = FormWindowState.Normal;
            }
        }

        private void SCmd3_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("LoadExcel"))
            {
                LoadExcel LoadExcel = new LoadExcel();
                LoadExcel.MdiParent = GeneralCommon.MDIMain;
                LoadExcel.Show();
                LoadExcel.WindowState = FormWindowState.Normal;
            }
        }

        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_MessConfirm("您确定要更新轧钢作业计划数据吗？", "Q", "更新数据"))
            {
                return;
            }

            string[] Para1 = new string[1];

            Para1[0] = "C3";


            //在这里调用Gf_ExecProcedure这个函数要特别注意后台包传出值得问题，后台包out必须传出两项，否则会报错，因为在该函数中，默认接受两个值。
            // P_RTN_CODE            OUT   NUMBER,
            //P_RTN_MSG             OUT   VARCHAR2
            //根据该函数的逻辑定义，包运行正常P_RTN_CODE:=0 包运行不正常P_RTN_CODE:=1/EDIT BY HANCHAO 20170821
            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGG2040NP", Para1))
            {

                GeneralCommon.Gp_MsgBoxDisplay("数据更新成功", "I", "系统提示信息");

            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("数据更新失败", "I", "系统提示信息");
            }
        }


    }
}
