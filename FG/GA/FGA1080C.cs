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
    public partial class FGA1080C : CommonClass.FORMBASE
    {
        public FGA1080C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        ////    public const int iSs1_Slab_No = 0;  //SS1板坯号

        public const string Ex_File_Name = "FGA1080C";
        public  const  int  SPD_PLATE_NO = 0											;
        public  const  int  SPD_CHARGE_FUR_LINE = 1               ;
        public  const  int  SPD_DIS_CHARGE_DATE = 2               ;
        public  const  int  SPD_PROC_CD = 3                       ;
        public  const  int  SPD_APLY_STDSPEC = 4                  ;
        public  const  int  SPD_THK = 5                           ;
        public  const  int  SPD_WID = 6                           ;
        public  const  int  SPD_LEN = 7                           ;
        public  const  int  SPD_WGT = 8                           ;
        public  const  int  SPD_INSP_AVE_WID = 9                 ;
        public  const  int  SPD_INSP_AVE_LEN = 10                 ;
        public  const  int  SPD_THICKNESS1 = 11                   ;
        public  const  int  SPD_THICKNESS2 = 12                   ;
        public  const  int  SPD_THICKNESS3 = 13                   ;
        public  const  int  SPD_THICKNESS4 = 14                   ;
        public  const  int  SPD_THICKNESS5 = 15                   ;
        public  const  int  SPD_THICKNESS6 = 16                   ;
        public  const  int  SPD_THICKNESS7 = 17                   ;
        public  const  int  SPD_THICKNESS8 = 18                   ;
        public  const  int  SPD_PROD_GRD = 21                     ;
        public  const  int  SPD_SURF_GRD = 22                     ;
        public  const  int  SPD_MAGNET_MIN = 23                   ;
        public  const  int  SPD_MAGNET_MAX = 24                   ;
        public  const  int  SPD_MAGNET_GRD = 25                   ;
        public  const  int  SPD_MAGNET1 = 26                      ;
        public  const  int  SPD_MAGNET2 = 27                      ;
        public  const  int  SPD_MAGNET3 = 28                      ;
        public  const  int  SPD_MAGNET4 = 29                      ;
        public  const  int  SPD_MAGNET5 = 30                      ;
        public  const  int  SPD_MAGNET6 = 31                      ;
        public  const  int  SPD_MAGNET7 = 32                      ;
        public  const  int  SPD_MAGNET8 = 33                      ;
        public  const  int  SPD_INSP_WAVE = 36                    ;
        public  const  int  SPD_INSP_T_FLAW = 37                  ;
        public  const  int  SPD_INSP_B_FLAW = 38                  ;
        public  const  int  SPD_AXIS_X = 39                       ;
        public  const  int  SPD_AXIS_Y = 40                       ;
        public  const  int  SPD_REMAIN_THK = 41                   ;
        public  const  int  SPD_ROUGHNESS = 42        ;            //表面粗糙度
        public  const  int  SPD_ROUGHNESS_NAME = 43               ;
        public  const  int  SPD_ISREVERSE = 44                    ;
        public  const  int  SPD_ISREVERSE1 = 45                   ;
        public  const  int  SPD_DISPOSE = 46            ;           //处置方式 
        public  const  int  SPD_DISPOSE_NAME = 47                 ;
        public  const  int  SPD_CUR_INV = 48                      ;
        public  const  int  SPD_LOC = 49                          ;
        public  const  int  SPD_BED_PILE_DATE = 50                ;
        public  const  int  SPD_PROD_DATE = 51                    ;
        public  const  int  SPD_GROUP = 52                        ;
        public  const  int  SPD_SHIFT = 53                        ;
        public  const  int  SPD_INSP_DATE = 54                    ;
        public  const  int  SPD_INSP_MAN = 55                    ;
        public  const  int  SPD_PROD_REMARK = 56                  ;
        public  const  int  SPD_ORD = 57                          ;
        public  const  int  SPD_UST_FL = 58                       ;
        public  const  int  SPD_GAS_FL = 59                       ;
        public  const  int  SPD_CL_FL = 60                        ;
        public  const  int  SPD_HTM_METH = 61                     ;
        public  const  int  SPD_MAGNET_DATE = 62                  ;
        public  const  int  SPD_USERID = 63                       ;



        #region 界面初始化

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
			p_SetMc("钢板号",		TXT_PLATE_NO				, "P", "", "", "", "", imcseq);
            p_SetMc("开始日期",     SDT_PROD_DATE_FROM          , "PN", "", "", "", "", imcseq);
            p_SetMc("结束日期",	    SDT_PROD_DATE_TO		    , "PN", "", "", "", "", imcseq);
            p_SetMc("班次",			CBO_SHIFT					, "P", "", "", "", "", imcseq);
            p_SetMc("班别",			CBO_GROUP					, "P", "", "", "", "", imcseq);
            p_SetMc("表面等级",	    CBO_SURFGRD					, "P", "", "", "", "", imcseq);
            p_SetMc("产品等级",	    CBO_PRODGRD					, "P", "", "", "", "", imcseq);
            p_SetMc("标准号",       F4ETCN_STDSPEC_R            , "P", "", "", "", "", imcseq);
            p_SetMc("垛位号",		txt_f_addr					, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号",		cbo_chg_no					, "P", "", "", "", "", imcseq);
            p_SetMc("订单号",		TXT_ORD_NO					, "P", "", "", "", "", imcseq);




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("热处理时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("进程状态", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("测量宽度", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("测量长度", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("厚度1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("厚度2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("厚度3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("厚度4", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("厚度5", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("厚度6", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("厚度7", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("厚度8", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("厚度最大值", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("厚度最小值", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("最小值", "N", "3,2", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("最大值", "N", "3,2", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("判定", "E", "20", "", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("1", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("2", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("3", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("4", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("5", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("6", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("7", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("8", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("9", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("10", "E", "3", "I", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("不平度（mm/2m）", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("上表缺陷", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("下表缺陷", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//38
            p_SetSc("X轴", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//39
            p_SetSc("Y轴", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("剩余厚度", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("表面粗糙度", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("表面粗糙度", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//43
            p_SetSc("是否翻板", "E", "10", "", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("是否翻板", "C", "1", "I", "", "", "", iscseq, iheadrow);//45
            p_SetSc("处置方式", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("处置方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("库", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//49
            p_SetSc("入库时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//51
            p_SetSc("班别", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("班次", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("检验日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("检验人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("订单号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//57
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//59
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//60
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//61
            p_SetSc("检测时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//62
            p_SetSc("作业人员", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//63
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//64

            //iheadrow = 0;
            //p_spanSpread("作业实绩", 5, 13, iscseq, iheadrow, 1);

          //  SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
           


        }

        private void FGA1080C_Load(object sender, EventArgs e)
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
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\FGA1080C.xls";

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
         
        int k = 5;
         for (int i = 0; i < rowCount; i++)
         {                                
             appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[i, SPD_PLATE_NO].Text;//                 
             appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[i, SPD_APLY_STDSPEC].Text;//             
             appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[i, SPD_THK].Text;//                      
             appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[i, SPD_WID].Text;//                      
             appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[i, SPD_LEN].Text;//                      
             appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[i, SPD_WGT].Text;//                      
             appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_AVE_WID].Text;//             
             appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_AVE_LEN].Text;//             
             appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS1].Text;//               
             appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS2].Text;//               
             appExcel.Cells[k, 11] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS3].Text;//               
             appExcel.Cells[k, 12] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS4].Text;//               
             appExcel.Cells[k, 13] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS5].Text;//               
             appExcel.Cells[k, 14] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS6].Text;//               
             appExcel.Cells[k, 15] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS7].Text;//               
             appExcel.Cells[k, 16] = this.ss1.ActiveSheet.Cells[i, SPD_THICKNESS8].Text;//               
             appExcel.Cells[k, 17] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET1].Text;//                  
             appExcel.Cells[k, 18] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET2].Text;//                  
             appExcel.Cells[k, 19] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET3].Text;//                  
             appExcel.Cells[k, 20] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET4].Text;//                  
             appExcel.Cells[k, 21] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET5].Text;//                  
             appExcel.Cells[k, 22] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET6].Text;//                  
             appExcel.Cells[k, 23] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET7].Text;//                  
             appExcel.Cells[k, 24] = this.ss1.ActiveSheet.Cells[i, SPD_MAGNET8].Text;//                  
             appExcel.Cells[k, 25] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_WAVE].Text;//                
             appExcel.Cells[k, 26] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_T_FLAW].Text;//              
             appExcel.Cells[k, 27] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_B_FLAW].Text;//              
             appExcel.Cells[k, 28] = this.ss1.ActiveSheet.Cells[i, SPD_AXIS_X].Text;//                   
             appExcel.Cells[k, 29] = this.ss1.ActiveSheet.Cells[i, SPD_AXIS_Y].Text;//                   
             appExcel.Cells[k, 30] = this.ss1.ActiveSheet.Cells[i, SPD_REMAIN_THK].Text;//               
             appExcel.Cells[k, 31] = this.ss1.ActiveSheet.Cells[i, SPD_ROUGHNESS_NAME].Text;//           
             appExcel.Cells[k, 32] = this.ss1.ActiveSheet.Cells[i, SPD_ISREVERSE].Text;//   
             appExcel.Cells[k, 33] = this.ss1.ActiveSheet.Cells[i, SPD_SURF_GRD].Text;//
             appExcel.Cells[k, 34] = this.ss1.ActiveSheet.Cells[i, SPD_DISPOSE_NAME].Text;//
             appExcel.Cells[k, 35] = this.ss1.ActiveSheet.Cells[i, SPD_GROUP].Text;//                    
             appExcel.Cells[k, 36] = this.ss1.ActiveSheet.Cells[i, SPD_SHIFT].Text;//                    
             appExcel.Cells[k, 37] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_DATE].Text;//                
             appExcel.Cells[k, 38] = this.ss1.ActiveSheet.Cells[i, SPD_INSP_MAN].Text;//                 
             appExcel.Cells[k, 39] = this.ss1.ActiveSheet.Cells[i, SPD_PROD_REMARK].Text;//                              
                    k = k + 1;
                 }
                  appExcel.Visible = true;
                  //  appExcel.Quit();//从内存中退出          
                  appExcel = null;
                  return;         
             }
         }

        }
