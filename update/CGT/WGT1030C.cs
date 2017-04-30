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
//-- Program Name      矫直实绩查询界面
//-- Program ID        WGT1030C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.11.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//--  VER       DATE         EDITOR       DESCRIPTION
//-- 1.00    2012.11.22       李超        矫直实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT1030C : CommonClass.FORMBASE
    {
        public WGT1030C()
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
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_JIAOZHI, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SP_CD, "P", "", "", "", imcseq, "");//用于判断预矫直和温矫直

            


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-21
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("数据来源", "E", "5", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("矫直机号", "N", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("轧制厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("轧制宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("轧制长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("矫直模式", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("矫直道次数", "N", "1", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("咬钢速度", "N", "3,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("入口操作侧辊缝", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("入口传动侧辊缝", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("出口操作侧辊缝", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("出口传动侧辊缝", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("入口传动侧设定辊缝", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("出口传动侧设定辊缝", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("入口操作侧设定辊缝", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("出口操作侧设定辊缝", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("入口边辊设定位置", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("出口边辊设定位置", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("弯辊设定位置", "N", "4,1", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("平均扭矩0", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩1", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩2", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩3", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩4", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩5", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩6", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩7", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩8", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩9", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩10", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩11", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩12", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩13", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩14", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("平均扭矩15", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");            
            p_SetSc("最大扭矩0", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("最大扭矩1", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("最大扭矩2", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("最大扭矩3", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩4", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩5", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩6", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩7", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩8", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩9", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩10", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩11", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩12", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩13", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩14", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大扭矩15", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("最大矫直力", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("平均矫直力", "N", "5", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("入口操作侧压下力", "N", "5", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("入口传动侧压下力", "N", "5", "L", "", "", "", iscseq, iheadrow);//24
            p_SetSc("出口操作侧压下力", "N", "5", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("出口传动侧压下力", "N", "5", "L", "", "", "", iscseq, iheadrow);//26
            p_SetSc("塑性变形比", "N", "3", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("矫直入口温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("矫直出口温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("开始矫直时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("结束矫直时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);//32     
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGC2013C";
            Form_Define();
            this.opt_HLR.Checked = true;
            this.opt_HLR.ForeColor = Color.Red;
            this.TXT_SP_CD.Text = "HLR";
        }
        #endregion

        private void opt_HLR_Click(object sender, EventArgs e)
        {
            if (this.opt_HLR.Checked)
            {
                this.opt_HLR.ForeColor = Color.Red;
                this.opt_PLR.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "HLR";
            }
            else
            {
                this.opt_HLR.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "PLR";
            }
        }

        private void opt_PLR_Click(object sender, EventArgs e)
        {
            if (this.opt_PLR.Checked)
            {
                this.opt_PLR.ForeColor = Color.Red;
                this.opt_HLR.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "PLR";
            }
            else
            {
                this.opt_PLR.ForeColor = Color.Black;
                this.TXT_SP_CD.Text = "HLR";
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            this.opt_HLR.Checked = true;
            this.opt_HLR.ForeColor = Color.Red;
            this.opt_PLR.ForeColor = Color.Black;
            this.TXT_SP_CD.Text = "HLR";

            return true;


        }

    }
}
