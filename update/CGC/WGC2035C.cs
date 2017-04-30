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
//-- Program Name      标印实绩
//-- Program ID        WGC2035C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2016.01.05
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2016.01.05       韩超        标印实绩
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGC2035C : CommonClass.FORMBASE
    {
        public WGC2035C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_CUT_DATE = 5;
        const int SPD_PIL_OCCR_DATE = 7;
          


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_MARK_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_MARK_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_STDSPEC_CHG, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SMP_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ORG_ORD_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ORG_ORD_ITEM, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_PROC_CD, "P", "", "", "", imcseq, "");
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("班别", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("标印时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("是否反剪", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("反剪时间", "DT", "14", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("入库时间", "DT", "14", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("进程状态", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("轧制标准", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("标准号", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("宽度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("长度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("重量", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("取样代码", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("试样号", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("钢种", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("执行标准", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("喷印", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("冲印", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("侧喷", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("切边", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("定尺", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("修磨", "C", "1", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("缺陷", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("改判缺陷", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("轧制异常", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("轧制时间", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("轧制班别", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("库", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("垛位号", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("探伤", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("切割", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("矫直", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("抛丸指示", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("热处理", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("其它", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("钢板剪切时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("剪切班别", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("原始订单号", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("订单号", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("钢板性能", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//42


            iheadrow = 0;
            p_spanSpread("钢板标印", 0, 2, iscseq, iheadrow, 1);
            p_spanSpread("在线反剪", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("火切板在线入库", 6, 7, iscseq, iheadrow, 1);
            p_spanSpread("作业实绩", 32, 36, iscseq, iheadrow, 1);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGB2011C";
            Form_Define();
            //     base.sAuthority = "1111";
        }
        #endregion

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }

            if (e.Column == SPD_CUT_DATE)
            {
                ss1.ActiveSheet.Cells[e.Row, e.Column].Text = System.DateTime.Now.ToString();
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";


            }
            if (e.Column == SPD_PIL_OCCR_DATE)
            {
                ss1.ActiveSheet.Cells[e.Row, e.Column].Text = System.DateTime.Now.ToString();
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

            }
        }

      
    }
}