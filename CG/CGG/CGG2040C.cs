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

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");//0
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
            p_SetSc("计划日期", "E", "50", "L", "", "", "", iscseq, iheadrow, "L");//0  
            p_SetSc("序列", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("钢种名称", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("厚度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//5  
            p_SetSc("H/C", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("块数", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("序列", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("代码", "E", "6", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("厚度", "N", "4,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("宽度", "E", "4", "L", "", "", "", iscseq, iheadrow, "R");//15 
            p_SetSc("长度", "E", "4", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("编辑人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//20  
            p_SetSc("计划时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//21

            iheadrow = 0;
            p_spanSpread("板坯", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("客户", 11, 12, iscseq, iheadrow, 1);
            p_spanSpread("产品", 14, 16, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 1;
            iscseq = 3;
            p_SetSc("计划日期", "E", "50", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("序列", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("订单号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("序列", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("钢种/标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚度", "N", "10,1", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("宽度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("长度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("计划", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("实绩", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("剩余", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("厚度", "N", "10,1", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("宽度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("长度", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("倍尺", "N", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("编辑人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("编辑时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("切割人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("切割时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//0



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
            // 上冷床
            if (base.i_ScCurrSeq==1)
            {
                p_Ref(1, 1, true, false);
            }
            // 下冷床
            else
            {
                p_Ref(1, 2, true, false);
            }
        }

        // 重写保存
        public override void Form_Pro()
        {
            txt_emp_cd.Text = GeneralCommon.sUserID;
            p_Pro(2, 0, true, false);
        }



      
    }
}
