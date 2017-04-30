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
///-- 程序名            硬度                               
///-- 程序ID            FGA1090C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2015.12.15                                                
///-- 处理描述          硬度                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2015.12.15        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGA1090C : CommonClass.FORMBASE
    {
        public FGA1090C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        ////    public const int iSs1_Slab_No = 0;  //SS1板坯号

        //public const string Ex_File_Name = "FGA1090C";
        //public const int SPD_PLATE_NO = 0;
       



        #region 界面初始化

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("开始日期", SDT_PROD_DATE_FROM, "PN", "", "", "", "", imcseq);
            p_SetMc("结束日期", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("表面等级", CBO_SURFGRD, "P", "", "", "", "", imcseq);
            p_SetMc("产品等级", CBO_PRODGRD, "P", "", "", "", "", imcseq);
            p_SetMc("标准号", F4ETCN_STDSPEC_R, "P", "", "", "", "", imcseq);
            p_SetMc("垛位号", txt_f_addr, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", cbo_chg_no, "P", "", "", "", "", imcseq);
            p_SetMc("订单号", TXT_ORD_NO, "P", "", "", "", "", imcseq);




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 48, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("热处理装炉", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("热处理出炉", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("进程状态", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("平均值1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("平均值2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("平均值3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("平均值4", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("1", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("2", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("3", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("平均值5", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("判定", "C", "1", "I", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("库", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("垛位号", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("入库时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("班别", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("班次", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("检测日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//39
            p_SetSc("检验人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//41
            p_SetSc("订单号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//42
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//43
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//44
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//45
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("检测日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//47
            p_SetSc("检验人员", "E", "60", "IL", "", "", "", iscseq, iheadrow, "L");//48
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//49

            iheadrow = 0;
            p_spanSpread("硬度1", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("硬度2", 14, 16, iscseq, iheadrow, 1);
            p_spanSpread("硬度3", 18, 20, iscseq, iheadrow, 1);
            p_spanSpread("硬度4", 22, 24, iscseq, iheadrow, 1);
            p_spanSpread("硬度5", 26, 28, iscseq, iheadrow, 1);


            //  SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);



        }

        private void FGA1090C_Load(object sender, EventArgs e)
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

    }
}
