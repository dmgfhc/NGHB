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
    public partial class CGA2030C : CommonClass.FORMBASE
    {
        public CGA2030C()
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
            p_SetMc("产品", cbo_PROD_TYPE, "PN", "", "", "", "", imcseq);
            p_SetMc("堆放仓库", txt_cur_inv, "PN", "", "", "", "", imcseq);
            p_SetMc("跨号", cbo_YARD_TYPE, "P", "", "", "", "", imcseq);


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("库种类", "E", "20", "NI", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("跨号", "E", "10", "NI", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("区号", "E", "10", "NI", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("行", "E", "10", "NI", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("列", "E", "10", "NI", "", "", "", iscseq, iheadrow,"M");//4
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("每层最大块数", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("垛位最大层数", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("库", "E", "10", "I", "", "", "", iscseq, iheadrow,"M");//8
       
            //iheadrow = 0;
            //p_spanSpread("当垛位号", 3, 5, iscseq, iheadrow, 1);
            //p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2030NC";
            Form_Define();
            txt_cur_inv.Text = "ZB";
            GeneralCommon.Gf_ComboAdd(cbo_PROD_TYPE, "SELECT DISTINCT PROD_TYPE FROM FP_STDYARD");

        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        public override void Form_Pro()
        {
            p_pro(0, 1, true, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_cur_inv.Text = "ZB";
            return true;
            cbo_YARD_TYPE.Enabled = false;
        }

        public override void Spread_Can()
        {
            p_Ref(1, 1, true, true);
        }

        #endregion

        private void cbo_PROD_TYPE_SelectedValueChanged(object sender, EventArgs e)
        {

            string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDYARD WHERE PROD_TYPE = '" + cbo_PROD_TYPE.Text + "' AND YARD_KND = 'ZB'";
            GeneralCommon.Gf_ComboAdd(cbo_YARD_TYPE, sql);
            cbo_YARD_TYPE.Enabled = true;
        }
    }
}