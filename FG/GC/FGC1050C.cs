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
///-- 程序名            压平机实绩查询界面                                
///-- 程序ID            FGC1050C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2014.07.29                                                
///-- 处理描述          压平机实绩查询界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.29        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1050C : CommonClass.FORMBASE
    {
        public FGC1050C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        ////    public const int iSs1_Slab_No = 0;  //SS1板坯号

        public const int  SS1_STDSPEC = 8;   //标准号      
        public const int  SS1_LOC = 12;      //货位      
        public const int  SS1_PROC_CD = 7;   //进程代码      
        public const int  SS1_PLATE_NO = 0;  //钢板号      
        public const int  SS1_PROD_SIZE = 10; //规格尺寸
        public const int  SS1_WGT = 11;//重量     
        public const int  SS1_S = 13; //定尺区分          
        public const int  SS1_CUST_CD = 21;//客户名称
        public const int  SS1_STDSPEC_UPD_FL1 = 20;//订单号
        public const string Ex_File_Name = "FGC1050C";


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
			p_SetMc("产线",txt_prc_line	, "P", "", "", "", "", imcseq);
            p_SetMc("作业日期", sdt_wrk_date_fr, "PN", "", "", "", "", imcseq);
			p_SetMc("作业日期",sdt_wrk_date_to, "P", "", "", "", "", imcseq);
			p_SetMc("班次",cbo_shift, "P", "", "", "", "", imcseq);    
		    p_SetMc("班别",cbo_group, "P", "", "", "", "", imcseq);    
			p_SetMc("物料号",txt_mat_no, "P", "", "", "", "", imcseq);  
			p_SetMc("堆放仓库",text_cur_inv_code, "P", "", "", "", "", imcseq);
		    p_SetMc("垛位",txt_Loc, "P", "", "", "", "", imcseq);    
		    p_SetMc("客户代码",txt_cust_cd, "P", "", "", "", "", imcseq);
			p_SetMc("入库时间",SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
			p_SetMc("入库时间",SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);



            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("物料号", "E", "60", "PI", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("压平时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("压平序号", "N", "10,2", "PIL", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("压平种类", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("产线别", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("机座号", "E", "1", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("进程代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("尺寸规格（mm）", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("重量", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("定尺区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("入口压下量", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("出口压下量", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("倾斜度", "N", "6,2", "", "I", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("压平速度", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("压平温度", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("道次数", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("入库日期", "DT", "L", "", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("作业人员", "E", "7", "NIL", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("热处理指示", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("探伤指示", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("产品等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("表面等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("不平度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32

            //iheadrow = 0;
            //p_spanSpread("作业实绩", 5, 13, iscseq, iheadrow, 1);

          //  SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
           


        }

        private void FGA1030C_Load(object sender, EventArgs e)
        {
            Form_Define();
            //TXT_EMP.Text = GeneralCommon.sUserID;
        }
        
        #endregion


        public override bool Form_Cls()
        {
            base.Form_Cls();
            return true;
        }

        private void SSCommand2_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                int rowCount = ss1.ActiveSheet.RowCount;
                setExcelText(targetExcelName,rowCount);
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
            string sourceExcelName = System.Windows.Forms.Application.StartupPath  + "\\FGC1050C.xls";

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
         int sPage_Num = 30 ;
         int sPage_X = 32;
         int sPage;
         int sLastPage;
         double Weight;
         int sRow1;
         int sRow2;
         int sRow3;
         sDate1 = sdt_wrk_date_fr.RawDate;
         sDate2 = sdt_wrk_date_to.RawDate;
         sDate = "日期：";
         
        if (sDate1 != "" && sDate2 != "")
        {
            sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日" + " - " + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) +  "日";
        }
        
        if (sDate1 != "" && sDate2 == "")
        {
            sDate = "日期："+sDate1.Substring(0,4) + "年"+sDate1.Substring(4,2) + "月" + sDate1.Substring(6,2) + "日";
        }
        


         sShift = "";
         if (cbo_shift.Text == "1")
         {
             sShift = "大夜班";
         }
         else if (cbo_shift.Text == "2")
         {
             sShift = "白班";
         }
         else if (cbo_shift.Text == "3")
         {
             sShift = "小夜班";
         }
         
        //堆码员
          string codeName = "select EMP_NAME from zp_employee t where t.emp_id =" + "'" + GeneralCommon.sUserID + "'";
          appExcel.Cells[2, 5] = "码堆员：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, codeName);
        //班次
          appExcel.Cells[2, 3] = "班次：" + sShift;
         sPage = Convert.ToInt32(rowCount/sPage_Num) + 1;
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
                     appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                     appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//品种
                     appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                     appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                     appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_SIZE].Text;//规格尺寸
                     appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text;//重量
                     appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_S].Text;//定尺区分
                     appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                     appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC_UPD_FL1].Text;//订单号
                     Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text);
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
                     appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                     appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//品种
                     appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                     appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                     appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_SIZE].Text;//规格尺寸
                     appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text;//重量
                     appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_S].Text;//定尺区分
                     appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                     appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC_UPD_FL1].Text;//订单号

                     Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text);

                     k = k + 1;
                 }

                 appExcel.Cells[sRow1, 3] = Weight.ToString();
                 appExcel.Cells[sRow3, 3] = sPage_Num.ToString();
             }
         }

         

        }

    }
}
