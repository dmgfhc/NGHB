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
///-- 程序名            抛丸实绩查询界面                                
///-- 程序ID            FGC1010C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              李超                                                    
///-- 代码              李超                                                     
///-- 代码日期          2014.08.14                                                
///-- 处理描述          抛丸实绩查询界面                                                                          
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
    public partial class FGC1010C : CommonClass.FORMBASE
    {
        public FGC1010C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();



        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("产线", txt_prc_line, "PN", "", "", "", "", imcseq);
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "PN", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("方式", TXT_PROD_CD, "P", "", "", "", "", imcseq);




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("作业日期", "D", "", "IN", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("作业时间", "T", "", "IN", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("物料号", "E", "60", "PIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("顺序", "E", "10", "PI", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("工厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("进程代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("标准号", "E", "40", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("钢种", "E", "40", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("重量", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("抛丸", "COMR", "5", "I", "Q0074", "", "1", iscseq, iheadrow, "R");//12
            p_SetSc("抛丸名称", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("清洁度", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("面积", "N", "10,2", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("钢板运行速度", "N", "10,2", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("班次", "E", "1", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("班别", "E", "1", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("操作人员", "E", "10", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("操作员", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("垛位号", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//22

            iheadrow = 0;
            p_spanSpread("产品", 8, 11, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);



             }

        private void FGC1010C_Load(object sender, EventArgs e)
        {
            Form_Define();
            txt_prc_line.Text = "1";
            rdo_mat.Checked = true;
            rdo_mat.ForeColor = System.Drawing.Color.Red;
            if (rdo_mat.Checked == true)
            {
                TXT_PROD_CD.Text = "SL";
            }
        }
        private void rdo_mat_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "SL";
            rdo_mat.ForeColor = System.Drawing.Color.Red;
            rdo_out.ForeColor = System.Drawing.Color.Black;
        }

        private void rdo_out_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "LO";
            rdo_out.ForeColor = System.Drawing.Color.Red;
            rdo_mat.ForeColor = System.Drawing.Color.Black;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            rdo_mat.Checked = true;
            return true;
        }

      }
   }

#endregion