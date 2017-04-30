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
//-- Sub_System Name   轧辊管理
//-- Program Name      轧辊库存管理界面
//-- Program ID        WGF1080C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.12.27
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2012.12.27       李超        轧辊库存管理
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGF1080C : CommonClass.FORMBASE
    {
        public WGF1080C()
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
            p_SetMc(TXT_ROLL_ID, "PR", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-17
            p_SetSc("轧辊号", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("入库辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("当前辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("限位辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("轧辊单价(元)", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("剩余金额(元)", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("入库辊重", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("剩余辊重(kg)", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("平均硬度", "N", "2", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("材质", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("轧辊状态", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("入库时间", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("报废时间", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("使用次数", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("轧制重量", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("轧制公里", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("供应商", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("磨辊次数", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//17
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGF1080C";
            Form_Define();
        }
        #endregion
    }
}
