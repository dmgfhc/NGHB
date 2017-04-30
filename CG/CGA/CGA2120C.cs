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
    public partial class CGA2120C : CommonClass.FORMBASE
    {
        public CGA2120C()
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
            p_SetMc(txt_SlabNo, "P", "", "", "", imcseq, "");
            p_SetMc(txt_Occr_Time, "P", "", "", "", imcseq, "");
            p_SetMc(txt_Occr_Time_To, "P", "", "", "", imcseq, "");
            p_SetMc(cbo_Shift, "P", "", "", "", imcseq, "");
            p_SetMc(cbo_Group, "P", "", "", "", imcseq, "");
            p_SetMc(txt_mill_Time, "P", "", "", "", imcseq, "");
            p_SetMc(txt_mill_to_Time, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("炉号", "E", "60", "", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("板坯号", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("板坯钢种", "E", "60", "", "", "", "", iscseq, iheadrow,"L");//2
            p_SetSc("轧制钢种", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("标准号", "E", "60", "", "", "", "", iscseq, iheadrow,"L");//4
            p_SetSc("厚度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("厚度", "N", "8,2", "", "", "", "", iscseq, iheadrow,"R");//9
            p_SetSc("宽度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("长度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("厚度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("宽度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("长度", "N", "15,3", "", "", "", "", iscseq, iheadrow, "R");//14
 
            p_SetSc("轧件内计划子板数", "E", "60", "", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("轧件内实际子板数", "E", "60", "", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("出炉时间", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("生产时间", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("废次品块数", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("成品计划重量", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("成品实际重量", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("实设成材率", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("实绩成材率", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("实绩成材率与实设成材率差值", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("轧制班别", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//25
            p_SetSc("定尺", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("宽度差", "E", "60", "", "", "", "", iscseq, iheadrow, "R");//27
           
            iheadrow = 0;
            p_spanSpread("板坯规格", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("计划轧制规格", 9, 11, iscseq, iheadrow, 1);
            p_spanSpread("轧制实绩尺寸", 12, 14, iscseq, iheadrow, 1);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2120NC";
            Form_Define();

            txt_Occr_Time.RawDate = System.DateTime.Now.ToString();
            txt_Occr_Time_To.RawDate = System.DateTime.Now.ToString();

       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        //public override void Form_Pro()
        //{
        //    p_pro(1, 1, true, true);
        //}

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_Occr_Time.RawDate = System.DateTime.Now.ToString();
            txt_Occr_Time_To.RawDate = System.DateTime.Now.ToString();
            return true;

        }
        #endregion


    }
}