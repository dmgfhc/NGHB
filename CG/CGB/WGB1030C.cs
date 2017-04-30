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
///-- 系统名            宽厚板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                  
///-- 程序名            矫直实绩查询及修改界面                                
///-- 程序ID            WGB1030C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.12.24                                                
///-- 处理描述          矫直实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.12.24       李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace CG
{
    public partial class WGB1030C : CommonClass.FORMBASE
    {
        public WGB1030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Slab_No = 0;  //SS1板坯号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", txt_slab_no, "PI", "", "", "", "", imcseq);
            p_SetMc("矫直机号", cbo_hl_no, "NIR", "", "", "", "", imcseq);
            p_SetMc("矫直开始时间", mdt_hl_sta_date, "NIR", "", "", "", "", imcseq);
            p_SetMc("矫直结束时间", mdt_hl_end_date, "NIR", "", "", "", "", imcseq);
            p_SetMc("入口右侧压下力", sdb_lev_inw_force, "IR", "", "", "", "", imcseq);
            p_SetMc("入口左侧压下力", sdb_lev_ind_force, "IR", "", "", "", "", imcseq);
            p_SetMc("出口右侧压下力", sdb_lev_ouw_force, "IR", "", "", "", "", imcseq);
            p_SetMc("出口左侧压下力", sdb_lev_oud_force, "IR", "", "", "", "", imcseq);
            p_SetMc("矫直入口温度", sdb_lev_in_tmp, "IR", "", "", "", "", imcseq);
            p_SetMc("矫直出口温度", sdb_lev_lst_tmp, "IR", "", "", "", "", imcseq);
            p_SetMc("塑性变形比", sdb_lev_p_pe, "IR", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_upd_emp, "IL", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("生产时间", udt_prod_date, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("轧制结束时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("板坯规格", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R"); 
            //6-10
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");   
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R"); 
            p_SetSc("矫直机号", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");

            iheadrow = 0;
            p_spanSpread("轧制实绩", 5, 7, iscseq, iheadrow, 1);

        }
        private void WGB1030C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";

            Form_Define();
         //   base.sAuthority = "1111";
            txt_upd_emp.Text = GeneralCommon.sUserID;
            
            
        }
        #endregion

        // 重写查询
        public override void Form_Ref()
        {

            //查询轧制信息
            p_Ref(2, 1, true, true);          

        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }

            //只有选择行表头才可进行操作
            if (e.Column > 0 & e.Row < 1)
            {
                return;
            }

            txt_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
            base.p_Ref(1,0, true, true);
        }
    }
}
