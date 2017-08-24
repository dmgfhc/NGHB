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
//-- Program ID        WKA1050C
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

namespace WK
{
    public partial class WKA1050C : CommonClass.FORMBASE
    {
        public WKA1050C()
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
            p_SetMc(txt_slab_no, "PR", "", "", "", imcseq, "");  // 板坯号

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("轧制序号", "E", "10", "IRL", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("辊期", "E", "5", "RL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("辊期内板坯顺序", "E", "10", "RL", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("辊期内累计公里数", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);//3
            p_SetSc("板坯状态", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯号", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("坯料生产时间", "D", "15", "RL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("头尾坯标记", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("坯料冶炼钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("轧制钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow);//9
            p_SetSc("订单种类", "E", "8", "RL", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("订单号", "E", "11", "RL", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("订单序列", "E", "8", "RL", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("产品钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow);//13
            p_SetSc("坯料规格", "E", "20", "RL", "", "", "", iscseq, iheadrow);//14
            p_SetSc("板坯重量", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);//15
            p_SetSc("当前位置", "E", "20", "RL", "", "", "", iscseq, iheadrow);//16
            p_SetSc("铸机号", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("HCR分类", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("产品类型", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("出炉温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//20
            p_SetSc("轧制代码", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("目标厚度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);//22
            p_SetSc("目标宽度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);//23
            p_SetSc("轧件长度", "N", "8,1", "RL", "", "", "", iscseq, iheadrow);//24
            p_SetSc("设计成材率", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("欠量（上限）", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("欠量（下限）", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("UST", "E", "20", "RL", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("坯料是否走真空", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("热处理方法", "E", "50", "RL", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("控轧代码", "E", "20", "RL", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("控轧厚度比", "N", "3", "RL", "", "", "", iscseq, iheadrow);//32
            p_SetSc("控轧温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//33
            p_SetSc("终轧温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//34
            p_SetSc("冷却方式", "E", "20", "RL", "", "", "", iscseq, iheadrow);//35
            p_SetSc("开冷温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//36
            p_SetSc("冷却率", "N", "3", "RL", "", "", "", iscseq, iheadrow);//37
            p_SetSc("指示状态", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("进程状态", "E", "3", "RL", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("编制时间", "DT", "19", "RL", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("板坯编制号", "E", "8", "RL", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("交货期", "D", "8", "RL", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("计划板坯缓冷时间", "N", "4", "RL", "", "", "", iscseq, iheadrow, "M");//43

        }
        private void WKA1050C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)sender;
            if (e.ColumnHeader) return;

            if (e.RowHeader)
            {
                if (this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text == "")
                {
                    this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                    SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.Cyan);
                    this.ss1_Sheet1.Cells[e.Row, 28].Text = GeneralCommon.sUserID;
                }
                else
                {
                    this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
                    SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.White);
                    this.ss1_Sheet1.Cells[e.Row, 28].Text = "";
                }
            }
        }
       
        #endregion

       

    
    }
}
