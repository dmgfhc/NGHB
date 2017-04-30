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
//-- Sub_System Name   统计分析管理
//-- Program Name      钢板标印实绩查询界面
//-- Program ID        WGT1020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.11.28
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER        DATE         EDITOR       DESCRIPTION
//-- 1.00    2012.11.28       李超        钢板标印实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT2011C : CommonClass.FORMBASE
    {
        public WGT2011C()
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
            p_SetMc(CUD_PAINT_DATE, "P", "", "", "", imcseq, "");
            p_SetMc(CUD_PAINT_TO_DATE, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_DPLLT_ID, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-38
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("标印时间", "E", "14", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("是否喷印", "C", "1", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("是否冲印", "C", "1", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("是否侧喷", "C", "1", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("冲印开始距离", "N", "5", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("喷印行1", "E", "60", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("喷印行2", "E", "60", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("喷印行3", "E", "60", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("喷印行4", "E", "60", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("喷印是否旋转", "N", "1", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("喷印到冲印距离", "N", "5", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("压缩比", "N", "1", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("是否加重字体", "N", "1", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("重复喷印数", "N", "1", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("重复喷印间隔距离", "N", "5", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("LOGO标识", "E", "2", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("冲印深度", "N", "5", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("冲印行1", "N", "5", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("冲印行2", "E", "2", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("冲印行3", "E", "7", "L", "", "", "", iscseq, iheadrow);//20
            p_SetSc("冲印行4", "E", "7", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("冲印是否旋转", "E", "7", "L", "", "", "", iscseq, iheadrow);//22
            p_SetSc("侧喷高度", "E", "7", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("条形码", "E", "7", "L", "", "", "", iscseq, iheadrow);//24
            p_SetSc("侧喷内容", "E", "7", "L", "", "", "", iscseq, iheadrow);//25

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGC2038C";
            Form_Define();
    //        base.sAuthority = "1111";
        }
        #endregion
    }
}
