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
///-- 程序ID            FGC1090C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2015.12.02                                                
///-- 处理描述          钢板硬度查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2015.12.02        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1090C : CommonClass.FORMBASE
    {
        public FGC1090C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_LOC = 3,
                  SPD_STDSPEC = 0,
                  SPD_PROC_CD = 4,
                  SPD_PLATE_NO = 1,
                  SPD_PROD_SIZE = 10,
                  SPD_WGT = 22,
                  SPD_MARK = 39,
                  SPD_SIZE = 44;

        //public const string Ex_File_Name = "FGC1090C";


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("标准号", TXT_STDSPEC, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", TXT_LOC, "P", "", "", "", "", imcseq);
            p_SetMc("垛位号", TXT_LOC, "P", "", "", "", "", imcseq);
            p_SetMc("订单号", TXT_ORD_NO, "P", "", "", "", "", imcseq);
            p_SetMc("表面等级", CBO_SURF_GRD, "P", "", "", "", "", imcseq);
            p_SetMc("综合等级", CBO_PROD_GRD, "P", "", "", "", "", imcseq);
            p_SetMc("垛位", TXT_LOC, "P", "", "", "", "", imcseq);



            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("炉座号", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("热处理装炉", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("热处理出炉", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("进程状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("标准号", "E", "40", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("长度", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("重量", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("1", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("2", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("3", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("平均值1", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("1", "E", "18", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("2", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("3", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("平均值2", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("1", "E", "18", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("2", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("3", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("平均值3", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("1", "E", "18", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("2", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("3", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("平均值4", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("1", "E", "18", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("2", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("3", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("平均值5", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("产品等级", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("表面等级", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("库", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("垛位号", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("入库时间", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("生产时间", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("班别", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("班次", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("检验日期", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("检验人员", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("备注", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("订单号", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("探伤", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("切割", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("矫直", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("热处理", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("检测时间", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("作业人员", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("紧急订单", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//48

            iheadrow = 0;
            p_spanSpread("硬度1", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("硬度2", 14, 16, iscseq, iheadrow, 1);
            p_spanSpread("硬度3", 18, 20, iscseq, iheadrow, 1);
            p_spanSpread("硬度4", 22, 24, iscseq, iheadrow, 1);
            p_spanSpread("硬度5", 26, 28, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 44, true);


             }

        private void FGC1090C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

      }
   }

#endregion