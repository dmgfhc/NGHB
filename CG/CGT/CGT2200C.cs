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
//-- Sub_System Name   统计分析管理
//-- Program Name      加热炉实绩查询界面
//-- Program ID        CGT2000C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.11.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.11.01       韩超        中板轧钢作业
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2200C : CommonClass.FORMBASE
    {
        public CGT2200C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

       // const int SS1_SLAB_NO = 0;
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("产线", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
           

            iheadrow = 0;
            p_spanSpread("圆盘剪", 2, 3, iscseq, iheadrow, 1);
            p_spanSpread("切头剪", 4, 5, iscseq, iheadrow, 1);
            p_spanSpread("切尾剪", 6, 7, iscseq, iheadrow, 1);
            p_spanSpread("检验", 8, 9, iscseq, iheadrow, 1);
            p_spanSpread("标印", 10, 11, iscseq, iheadrow, 1);
            
        }

        private void CGT2200C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2200C";
            Form_Define();
        }

        public override void Form_Pro()
        {
           // p_pro(1, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

    }
}
