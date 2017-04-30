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
///-- 程序名            热处理报表查询界面                                
///-- 程序ID            FGC1080C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2014.07.31                                                
///-- 处理描述          热处理报表查询界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.31        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1080C : CommonClass.FORMBASE
    {
        public FGC1080C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
       
       // public const int  SS1_STDSPEC_UPD_FL1 = 20;//订单号
        public const string Ex_File_Name = "FGC1080C";
        public const int	SS1_HTM_METHOD   = 0  ;
        public const int 	SS1_APLY_STDSPEC = 1  ;
        public const int 	SS1_THK          = 2  ;
        public const int 	SS1_DAY_WEIGHT1  = 3  ;
        public const int	SS1_MONTH_WEIGHT1= 4  ;
        public const int	SS1_DAY_CNT1     = 5  ;
        public const int	SS1_MONTH_CNT1   = 6  ;
        public const int	SS1_DAY_WEIGHT2  = 7  ;
        public const int	SS1_MONTH_WEIGHT2= 8  ;
        public const int	SS1_DAY_CNT2     = 9  ;
        public const int	SS1_MONTH_CNT2   = 10 ;
        public const int	SS1_DAY_WEIGHT3  = 15 ;
        public const int	SS1_MONTH_WEIGHT3= 16 ;
        public const int 	SS1_DAY_CNT3     = 17 ;
        public const int	SS1_MONTH_CNT3   = 18 ;
        public const int	SS1_UST_DAY      = 19 ;
        public const int	SS1_UST_MONTH    = 20 ;


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("热处理日期", SDT_PROD_DATE_FR, "PN", "", "", "", "", imcseq);
            p_SetMc("热处理日期", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("产线别", txt_prc_line, "P", "", "", "", "", imcseq);
            p_SetMc("热处理方法", CBO_HTM, "P", "", "", "", "", imcseq);
            p_SetMc("是否分厚度", TXT_CO_CD, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", cbo_chg_no, "P", "", "", "", "", imcseq);    




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("热处理方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("品种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("当日重量（t）", "N", "10,2", "", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("月重量（t）", "N", "10,2", "", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("当日块数", "N", "6,2", "", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("当月块数", "N", "6,2", "", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("当日重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("月重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("当日块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("月块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("当日重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("月重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("当日块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("月块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("当日重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("月重量（t）", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("当日块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("月块数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("当日热处理合格率%", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("当月热处理合格率%", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//20

            iheadrow = 0;
            p_spanSpread("合格品", 3, 6, iscseq, iheadrow, 1);
            p_spanSpread("不合格品", 7, 10, iscseq, iheadrow, 1);
            p_spanSpread("待判", 11, 14, iscseq, iheadrow, 1);
            p_spanSpread("合计", 15, 18, iscseq, iheadrow, 1);

          //  SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
           


        }

        private void FGC1080C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_CO_CD.Text = "Y";
            txt_prc_line.Text = "1";
            cbo_chg_no.Text = "1";
            //TXT_EMP.Text = GeneralCommon.sUserID;
        }

        #endregion


        public override bool Form_Cls()
        {
            base.Form_Cls();
            if (CHK_THK.Checked)
            {
                TXT_CO_CD.Text = "N";
            }
            if (!CHK_THK.Checked)
            {
                TXT_CO_CD.Text = "Y";
            }
            txt_prc_line.Text = "1";
            cbo_chg_no.Text = "1";
            return true;
        }

        private void CHK_THK_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_THK.Checked)
            {
                TXT_CO_CD.Text = "N";
            }
            if (!CHK_THK.Checked)
            {
                TXT_CO_CD.Text = "Y";
            }
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
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\FGC1080C.xls";

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
           	double  DAY_WEIGHT1  = 0;
            double  MONTH_WEIGHT1= 0;
            double  DAY_CNT1     = 0;
            double  MONTH_CNT1   = 0;
            double  DAY_WEIGHT2  = 0;
            double  MONTH_WEIGHT2= 0;
            double  DAY_CNT2     = 0;
            double  MONTH_CNT2   = 0;
            double  DAY_WEIGHT3  = 0;
            double  MONTH_WEIGHT3= 0;
            double  DAY_CNT3     = 0;
            double  MONTH_CNT3   = 0;





         sDate1 = SDT_PROD_DATE_FR.RawDate;
         sDate2 = SDT_PROD_DATE_TO.RawDate;
         sDate = "";
         int STA = 0;
         
        if (sDate1 != "" && sDate2 != "")
        {
            sDate = sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日" + " - " + sDate2.Substring(0, 4) + "年" + sDate2.Substring(4, 2) + "月" + sDate2.Substring(6, 2) +  "日";
        }
        
        if (sDate1 != "" && sDate2 == "")
        {
            sDate = sDate1.Substring(0,4) + "年"+sDate1.Substring(4,2) + "月" + sDate1.Substring(6,2) + "日";
        }
        


        
         
         
        int k = 4;
         for (int i = 0; i < rowCount; i++)
         {
             
                
                    appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells [i,SS1_HTM_METHOD].Text;//   
                    appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[i,SS1_APLY_STDSPEC].Text;//  
                    appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[i,SS1_THK].Text;//           
                    appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_WEIGHT1].Text;//   
                    appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_WEIGHT1].Text;// 
                    appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_CNT1].Text;//      
                    appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_CNT1].Text;//    
                    appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_WEIGHT2].Text;//   
                    appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_WEIGHT2].Text;// 
                    appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_CNT2].Text;//      
                    appExcel.Cells[k, 11] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_CNT2].Text;//    
                    appExcel.Cells[k, 12] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_WEIGHT3].Text;//   
                    appExcel.Cells[k, 13] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_WEIGHT3].Text;// 
                    appExcel.Cells[k, 14] = this.ss1.ActiveSheet.Cells[i,SS1_DAY_CNT3].Text;//      
                    appExcel.Cells[k, 15] = this.ss1.ActiveSheet.Cells[i,SS1_MONTH_CNT3].Text;//    
                    appExcel.Cells[k, 16] = this.ss1.ActiveSheet.Cells[i,SS1_UST_DAY].Text;//       
                    appExcel.Cells[k, 17] = this.ss1.ActiveSheet.Cells[i,SS1_UST_MONTH].Text;//     


                    DAY_WEIGHT1   = DAY_WEIGHT1   + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_WEIGHT1].Text);
                    MONTH_WEIGHT1 = MONTH_WEIGHT1 + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_WEIGHT1].Text);
                    DAY_CNT1      = DAY_CNT1      + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_CNT1     ].Text);
                    MONTH_CNT1    = MONTH_CNT1    + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_CNT1   ].Text);
                    DAY_WEIGHT2   = DAY_WEIGHT2   + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_WEIGHT2  ].Text);
                    MONTH_WEIGHT2 = MONTH_WEIGHT2 + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_WEIGHT2].Text);
                    DAY_CNT2      = DAY_CNT2      + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_CNT2     ].Text);
                    MONTH_CNT2    = MONTH_CNT2    + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_CNT2   ].Text);
                    DAY_WEIGHT3   = DAY_WEIGHT3   + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_WEIGHT3  ].Text);
                    MONTH_WEIGHT3 = MONTH_WEIGHT3 + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_WEIGHT3].Text);
                    DAY_CNT3      = DAY_CNT3      + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_DAY_CNT3     ].Text);
                    MONTH_CNT3    = MONTH_CNT3    + Convert.ToDouble(this.ss1.ActiveSheet.Cells[i, SS1_MONTH_CNT3   ].Text);

                    k = k + 1;
                    STA = k;
                 }
                 STA  = STA + 1;

                  appExcel.Cells[STA, SS1_APLY_STDSPEC] = "合计";
                  appExcel.Cells[STA,4]   =   DAY_WEIGHT1.ToString()  ;
                  appExcel.Cells[STA,5]   =   MONTH_WEIGHT1.ToString();
                  appExcel.Cells[STA,6]   =   DAY_CNT1.ToString()     ;
                  appExcel.Cells[STA,7]   =   MONTH_CNT1.ToString()   ;
                  appExcel.Cells[STA,8]   =   DAY_WEIGHT2.ToString()  ;
                  appExcel.Cells[STA,9]   =   MONTH_WEIGHT2.ToString();
                  appExcel.Cells[STA,10]  =   DAY_CNT2.ToString()     ;
                  appExcel.Cells[STA,11]  =   MONTH_CNT2.ToString()   ;
                  appExcel.Cells[STA,12]  =   DAY_WEIGHT3.ToString()  ;
                  appExcel.Cells[STA,13]  =   MONTH_WEIGHT3.ToString();
                  appExcel.Cells[STA,14]  =   DAY_CNT3.ToString()     ;
                  appExcel.Cells[STA,15]  =   MONTH_CNT3.ToString()   ;
                  appExcel.Cells[1, 2]    =   sDate;

                  appExcel.Visible = true;
                  //  appExcel.Quit();//从内存中退出          
                  appExcel = null;
                  return;                             

                 
             }
         }

        

    }

