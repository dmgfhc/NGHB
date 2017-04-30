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
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            热处理实绩查询(装炉时间)界面                               
///-- 程序ID            FGC1020C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              李超                                                    
///-- 代码              李超                                                     
///-- 代码日期          2014.08.14                                                
///-- 处理描述          热处理实绩查询(装炉时间)界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.08.14        李超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1030C : CommonClass.FORMBASE
    {
        public FGC1030C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_LOC = 5,
                  SPD_STDSPEC = 1,
                  SPD_PROC_CD = 6,
                  SPD_PLATE_NO = 2,
                  SPD_PROD_SIZE = 12,
                  SPD_WGT = 24,
                  SPD_MARK = 42,
                  SPD_SIZE = 48;

        public const string Ex_File_Name = "FGC1030C";


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("产线", cbo_PrcLine, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("厚度", NMB_THK, "P", "", "", "", "", imcseq);
            p_SetMc("宽度", NMB_WID, "P", "", "", "", "", imcseq);
            p_SetMc("标准", TXT_STDSPEC, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("表面等级", CBO_SURF_CD, "P", "", "", "", "", imcseq);
            p_SetMc("工厂", TXT_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("厚度", NMB_THK_TO, "P", "", "", "", "", imcseq);
            p_SetMc("宽度", NMB_WID_TO, "P", "", "", "", "", imcseq);
            p_SetMc("长度", NMB_LEN, "P", "", "", "", "", imcseq);
            p_SetMc("长度", NMB_LEN_TO, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", TXT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("热处理方法", CBO_METEND, "P", "", "", "", "", imcseq);
            p_SetMc("垛位号", TXT_LOC, "P", "", "", "", "", imcseq);



            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("钢板号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("首件标识", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("客户交货期", "D", " ", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧批号", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("物料状态", "E", "30", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("切割", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("抛丸", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("热处理", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("探伤", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("产品等级", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("外观等级", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("材质等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("取样代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("试样号", "E", "18", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("试样号状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("委托单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("实测长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("改判前标准", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("宽厚", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("喷印", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("冲印", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("侧喷", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("切边", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("修磨", "C", "", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("缺陷", "E", "50", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("热处理装炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("炉内停留时间(分钟)", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("热处理出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("客户", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("入库时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("喷涂交货", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//41
            p_SetSc("表面客户要求", "E", "100", "L", "", "", "", iscseq, iheadrow, "L");//42
            p_SetSc("堆放仓库", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//44
            p_SetSc("打印标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("长度范围", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("规格", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("特殊工序", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//48

            iheadrow = 0;
            p_spanSpread("作业指示/实绩", 7, 11, iscseq, iheadrow, 1);
            p_spanSpread("钢板实绩信息", 21, 31, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 47, true);


             }

        private void FGC1030C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

        public override void Form_Ref()
        {
            string strWgt = "";
            double sTotwgt = 0;

            p_Ref(1, 1, true, true);
            if (ss1.ActiveSheet.RowCount < 1)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, SPD_WGT].Text == "重量")
                {
                    strWgt = ss1.ActiveSheet.Cells[i, SPD_WGT].Text;
                    if (strWgt == "")
                    {

                    }
                    else
                    {
                        sTotwgt = sTotwgt + double.Parse(strWgt);
                    }
                }
                TXT_ALL_WGT.Text = sTotwgt.ToString();
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            cbo_PrcLine.Text = "1";
            return true;
        }

        private void TXT_STDSPEC_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSCommand2_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                int rowCount = ss1.ActiveSheet.RowCount;
                setExcelText(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\FGC1030C.xls";

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
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

            string sShift;
            string sDate1;
            string sDate2;
            string sDate;
            int sPage_Num = 30;
            int sPage_X = 32;
            int sPage;
            int sLastPage;
            double Weight;
            int sRow1;
            int sRow2;
            int sRow3;
            sDate1 = SDT_PROD_DATE_FR.Text;
            sDate2 = SDT_PROD_DATE_TO.Text;
            sDate = "日期：";

            if (sDate1 != "" && sDate2 != "")
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日" + " - " + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日";
            }

            if (sDate1 != "" && sDate2 == "")
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日";
            }



            sShift = "";
            if (CBO_SHIFT.Text == "1")
            {
                sShift = "大夜班";
            }
            else if (CBO_SHIFT.Text == "2")
            {
                sShift = "白班";
            }
            else if (CBO_SHIFT.Text == "3")
            {
                sShift = "小夜班";
            }

            //堆码员
            string codeName = "select EMP_NAME from zp_employee t where t.emp_id =" + "'" + GeneralCommon.sUserID + "'";
            appExcel.Cells[2, 5] = "码堆员：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, codeName);
            //班次
            appExcel.Cells[2, 3] = "班次：" + sShift;
            sPage = Convert.ToInt32(rowCount / sPage_Num) + 1;
            sLastPage = rowCount - Convert.ToInt32(rowCount / sPage_Num) * sPage_Num;
            sPage = sPage - 1;
            //日期
            appExcel.Cells[2, 1] = sDate;
            for (int i = 0; i <= sPage; i++)
            {
                int k = 4 + i * sPage_X;
                sRow1 = 35 + sPage_X * i;
                sRow3 = 34 + sPage_X * i;
                Weight = 0;
                if (i == sPage)
                {
                    sRow2 = sPage_Num * i + sLastPage;

                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SPD_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SPD_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SPD_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SPD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SPD_MARK].Text;//备注
                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text);
                        k = k + 1;
                    }
                    appExcel.Cells[sRow1, 3] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sLastPage.ToString();
                    appExcel.Visible = true;
                    //  appExcel.Quit();//从内存中退出
                    appExcel = null;
                    return;
                }
                else
                {
                    sRow2 = sPage_Num * i + sPage_Num;
                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SPD_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SPD_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SPD_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SPD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SPD_MARK].Text;//定尺区分

                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text);

                        k = k + 1;
                    }

                    appExcel.Cells[sRow1, 3] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sPage_Num.ToString();
                }
            }

        }

      }
   }

#endregion