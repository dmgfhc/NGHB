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
//-- System Name       中板轧钢作业
//-- Sub_System Name   板坯库管理
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2011C : CommonClass.FORMBASE
    {
        public CGA2011C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        //const int SPD_PLAN_PROD_WGT = 33,
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("产品代码",txt_prod_cd, "P", "", "", "", "", imcseq);
            p_SetMc("堆放仓库", txt_cur_inv, "P", "", "", "", "", imcseq);
            p_SetMc("物料编号", txt_mat_no, "P", "", "", "", "", imcseq);
            p_SetMc("垛位号", txt_location, "P", "", "", "", "", imcseq);
            p_SetMc("临时垛位号", chk_nolocation, "P", "", "", "", "", imcseq);
            p_SetMc("热处理车间", chk_htm, "P", "", "", "", "", imcseq);


            p_ScIni(ss1, Sc1, 16, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("产品", "E", "60", "AIL", "", "", "", iscseq, iheadrow,"L");//0 
            p_SetSc("库代码", "E", "60", "AI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("物料编号", "E", "60", "IL", "", "", "", iscseq, iheadrow,"L");//2
            p_SetSc("垛位号", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("垛层", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("列", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("垛位号", "E", "7", "NI", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("垛层", "N", "4", "NI", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("列", "E", "2", "NI", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");//9
            p_SetSc("钢种说明", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//10

            p_SetSc("厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("宽度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("长度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//14
 
            p_SetSc("生产工厂", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("作业人", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("作业人员", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("铸机号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//18
           
            iheadrow = 0;
            p_spanSpread("当垛位号", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2011NC";
            Form_Define();
            txt_cur_inv.Text = "ZB";
            txt_prod_cd.Text = "SL";
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        public override void Form_Pro()
        {
            p_pro(1, 1, true, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_cur_inv.Text = "ZB";
            txt_prod_cd.Text = "SL";
            return true;

        }
        #endregion


    }
}