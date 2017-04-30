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
///-- 系统名               宽厚板轧钢作业管理系统                                              
///-- 子系统名             精整作业管理                                                 
///-- 程序名               钢板分板实绩管理界面                                
///-- 程序ID               WGC2051C    
///-- 版本                 1.1                                                   
///-- 文档号                                                         
///-- 设计                 李骞                                                    
///-- 代码                 李骞                                                     
///-- 代码日期             2013.01.15                                                
///-- 处理描述             钢板分板实绩管理界面                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.01.15        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGC2052C : CommonClass.FORMBASE
    {
        public WGC2052C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        string sUser_ID;



        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");
            p_SetMc("生产时间", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("生产时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc(f4ETCR_CUR_INV, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;
            //0-47
            p_SetSc("剪切线", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//1  Insert
            p_SetSc("进程状态", "E", "6", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("客户交货期", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//3          
            p_SetSc("生产时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("用户代码", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//7

        }

        private void WGC2052C_Load(object sender, EventArgs e)
        {
            Form_Define();
            sUser_ID = GeneralCommon.sUserID;
        }

        public override void Form_Pro()
        {
            base.Form_Pro();
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.Sheets[0].Rows.Count <= 0)
            {
                return;
            }


            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 7].Text = "";
            }
            else
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                ss1.ActiveSheet.Cells[e.Row, 7].Text = sUser_ID;
            }
        }

    }
}