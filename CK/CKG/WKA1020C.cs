using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
//using FarPoint.PluginCalendar;
//using InDate;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
//using FarPoint.CalcEngine;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
//using FarPoint.Excel;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
//using FarPoint.PluginCalendar.WinForms;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       Nisco Production Management System
//-- Sub_System Name   Mill System
//-- Program Name      轧钢作业指示查询界面
//-- Program ID        WKA1020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          LiQian
//-- Coder             LiQian
//-- Date              2012.11.12
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER   DATE     EDITOR       DESCRIPTION
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class WKA1020C : CommonClass.FORMBASE
    {
        public WKA1020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Mc2 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("板坯号", cbo_slab_no, "P", "10", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("板坯状态", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"R");//2
            p_SetSc("产品钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"R");//3
            p_SetSc("厚度*宽度*长度", "E", "20", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("辊期", "E", "5", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("出炉温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("轧制代码", "E", "20", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("厚度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("厚度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("宽度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("宽度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("终轧温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("代码", "E", "10", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("一阶段厚度比", "N", "5", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("一阶段温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("二阶段厚度比", "N", "5", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("二阶段温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//20
            p_SetSc("冷却方法", "E", "10", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("开冷温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//22
            p_SetSc("目标冷却温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("目标冷却速率", "N", "4", "L", "", "", "", iscseq, iheadrow);//24
            p_SetSc("是否使用", "E", "1", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("内容", "E", "50", "L", "", "", "", iscseq, iheadrow);//26
            p_SetSc("缓冷类型", "N", "4", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("头部厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("尾部厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("长度1", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("长度2", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("长度3", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//32
            p_SetSc("长度4", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//33
            p_SetSc("长度5", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//34

            iheadrow = 0;
            p_spanSpread("目标规格", 9, 14, iscseq, iheadrow, 1);
            p_spanSpread("控轧", 16, 20, iscseq, iheadrow, 1);
            p_spanSpread("热喷", 25, 26, iscseq, iheadrow, 1);
            p_spanSpread("LP板规格", 28, 34, iscseq, iheadrow, 1);


            int imcseq1;
            p_McIni(Mc2, true);
            imcseq1 = 2;
            p_SetMc("板坯号", txt_slab_num, "P", "", "", "", "", imcseq1);//0
            p_SetMc("产品类型", txt_prod_cd, "R", "", "", "", "", imcseq1);//0
            p_SetMc("板坯来源", txt_slab_src, "R", "", "", "", "", imcseq1);//1
            p_SetMc("板坯头宽", sdb_head_slab_wid, "R", "", "", "", "", imcseq1);//2
            p_SetMc("板坯尾宽", sdb_tail_slab_wid, "R", "", "", "", "", imcseq1);//3
            p_SetMc("板坯厚度", sdb_slab_thk, "R", "", "", "", "", imcseq1);//4
            p_SetMc("板坯重量", sdb_slab_wgt, "R", "", "", "", "", imcseq1);//5
            p_SetMc("板坯长度", sdb_slab_len, "R", "", "", "", "", imcseq1);//6
            p_SetMc("轧制钢种", txt_mill_stlgrd, "R", "", "", "", "", imcseq1);//7
            p_SetMc("轧制代码", txt_rolling_mode, "R", "", "", "", "", imcseq1);//8
            p_SetMc("产品钢种", txt_stlgrd, "R", "", "", "", "", imcseq1);//9
            p_SetMc("辊期", sdb_rolling_stage, "R", "", "", "", "", imcseq1);//10
            p_SetMc("RHF目标温度", sdb_aim_temp, "R", "", "", "", "", imcseq1);//11
            p_SetMc("出炉温度", sdb_ext_temp, "R", "", "", "", "", imcseq1);//12
            p_SetMc("目标厚度", sdb_aim_thk, "R", "", "", "", "", imcseq1);//13
            p_SetMc("目标厚度下限", sdb_aim_thk_min, "R", "", "", "", "", imcseq1);//14
            p_SetMc("目标厚度上限", sdb_aim_thk_max, "R", "", "", "", "", imcseq1);//15
            p_SetMc("目标宽度", sdb_aim_wid, "R", "", "", "", "", imcseq1);//16
            p_SetMc("目标宽度下限", sdb_aim_wid_min, "R", "", "", "", "", imcseq1);//17
            p_SetMc("目标宽度上限", sdb_aim_wid_max, "R", "", "", "", "", imcseq1);//18
            p_SetMc("目标凸度", sdb_crown, "R", "", "", "", "", imcseq1);//19
            p_SetMc("目标凸度下限", sdb_crown_min, "R", "", "", "", "", imcseq1);//20
            p_SetMc("目标凸度上限", sdb_crown_max, "R", "", "", "", "", imcseq1);//21
            p_SetMc("目标终轧温度", sdb_aim_fin_temp, "R", "", "", "", "", imcseq1);//22
            p_SetMc("目标终轧温度下限", sdb_low_fin_temp_tol, "R", "", "", "", "", imcseq1);//23
            p_SetMc("目标终轧温度上限", sdb_up_fin_temp_tol, "R", "", "", "", "", imcseq1);//24
            p_SetMc("目标冷却温度", sdb_aim_cool_temp_acc, "R", "", "", "", "", imcseq1);//25
            p_SetMc("目标冷却温度下限", sdb_up_cool_temp_tol_acc, "R", "", "", "", "", imcseq1);//26
            p_SetMc("目标冷却温度上限", sdb_low_cool_temp_acc, "R", "", "", "", "", imcseq1);//27
            p_SetMc("开冷温度", sdb_cool_str_temp, "R", "", "", "", "", imcseq1);//28
            p_SetMc("冷却方法", txt_method_acc, "R", "", "", "", "", imcseq1);//29
            p_SetMc("冷却速率", sdb_cool_rate, "R", "", "", "", "", imcseq1);//30
            p_SetMc("LP板长度1", sdb_taper_l1_len, "R", "", "", "", "", imcseq1);//31
            p_SetMc("LP板长度2", sdb_taper_l2_len, "R", "", "", "", "", imcseq1);//32
            p_SetMc("LP板长度3", sdb_taper_l3_len, "R", "", "", "", "", imcseq1);//33
            p_SetMc("LP板长度4", sdb_taper_l4_len, "R", "", "", "", "", imcseq1);//34
            p_SetMc("LP板长度5", sdb_taper_l5_len, "R", "", "", "", "", imcseq1);//35
            p_SetMc("LP头部厚度", sdb_taper_hd_thk, "R", "", "", "", "", imcseq1);//36
            p_SetMc("LP尾部厚度", sdb_taper_tl_thk, "R", "", "", "", "", imcseq1);//37
            p_SetMc("一阶段控轧厚度比", sdb_cr1_red_ga_pct, "R", "", "", "", "", imcseq1);//38
            p_SetMc("一阶段控轧温度", sdb_cr1_reduct_temp, "R", "", "", "", "", imcseq1);//39
            p_SetMc("二阶段控轧厚度比", sdb_cr2_red_ga_pct, "R", "", "", "", "", imcseq1);//40
            p_SetMc("二阶段控轧温度", sdb_cr2_reduct_temp, "R", "", "", "", "", imcseq1);//41
            p_SetMc("是否热喷", txt_hot_marker_yn, "R", "", "", "", "", imcseq1);//42
            p_SetMc("热喷内容", txt_hot_marker_text, "R", "", "", "", "", imcseq1);//43

        }
        private void WKA1020C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            txt_slab_num.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text;
            cbo_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text;
            p_Ref(2, 0, true, false);
        }
        #endregion

    
    }
}
