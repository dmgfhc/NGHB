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
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   分切指示计划查询
//-- Program Name      分切指示计划查询
//-- Program ID        WGA1031C
//-- Document No       Q-00-0010(Specification)
//-- Designer          王雷
//-- Coder             王雷
//-- Date              2014.06.20
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//--  VER       DATE         EDITOR       DESCRIPTION
//-- 1.00    2014.06.20       王雷        分切指示计划查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGA1031C : CommonClass.FORMBASE
    {
        public WGA1031C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");
           




            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-21
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("切割顺序", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//1

            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//2
            
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("切割指示次数", "N", "1", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("垛位号", "E", "16", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("计划切割结束时间", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("计划切割生成时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("指示人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("指示日期", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("订单材/余材", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//13

            
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGA1031C";
            Form_Define();
        }
        #endregion

       
    }
}
