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
///-- 程序头注释 +++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板生产管制系统                                              
///-- 子系统名          其它                                                 
///-- 程序名            钢种组维护                              
///-- 程序ID            WKD1010C    
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              李超                                                    
///-- 代码              李超                                                    
///-- 代码日期          2013.11.20                                               
///-- 处理描述          钢种组维护
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.11.20        李超                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace WK
{
    public partial class WKD1010C : CommonClass.FORMBASE
    {
        public WKD1010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_plt = 0;        //工厂
        public const int iSs1_line = 1;       //作业线
        public const int iSs1_typ = 2;        //类型

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂代码", txt_plt, "P", "", "", "", "", imcseq);
            p_SetMc("类型", cbo_grp_type, "PN", "", "", "", "", imcseq);
            p_SetMc("钢种组", txt_stl_group, "P", "", "", "", "", imcseq);
            p_SetMc("钢种", txt_stlgrd, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 6, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("工厂", "E", "3", "IL", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("作业线", "E", "1", "IL", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("类型", "E", "1", "IL", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("钢种组", "E", "18", "I", "", "", "", iscseq, iheadrow,"L");//3
            p_SetSc("钢种", "E", "50", "I", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("适用", "C", "1", "I", "", "", "", iscseq, iheadrow);//5
            p_SetSc("录入人员", "E", "8", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("录入时间", "DT", "14", "IL", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("修改人员", "E", "8", "IL", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("修改时间", "DT", "14", "IL", "", "", "", iscseq, iheadrow,"M");//9
        }

        private void WKD1010C_Load(object sender, EventArgs e)
        {
            Form_Define();
        //    base.sAuthority = "1111";
        }


        public override bool Form_Cls()
        {
            // 重写清空
            if (base.Form_Cls())
            {
                txt_plt.Text = "";
            }
            return true;
        }

        public override void Spread_Ins()
        {
            base.Spread_Ins();

            ss1.ActiveSheet.ActiveCell.Text = txt_plt.Text;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, iSs1_line].Text = "1";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, iSs1_typ].Text = cbo_grp_type.Text;

        }
        #endregion
    }
}
