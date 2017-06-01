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
    public partial class CGC2070C : CommonClass.FORMBASE
    {
        public CGC2070C()
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
            p_SetMc("查询号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_SEQ, "P", "", "", "", "", imcseq);
            p_SetMc("火切指示", CBO_GAS_FL, "P", "", "", "", "", imcseq);
            p_SetMc("开始时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("结束时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("已分线母板", CBO_NUM, "P", "", "", "", "", imcseq);


            p_ScIni(ss1, Sc1, 22, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("取样", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("母板号", "E", "20", "PI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("子公司代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("计划切边", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("是否探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("是否真空", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("1#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("2#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("3#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("4#线", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("下线时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("计划/实绩", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("母板分段时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("作业人员", "E", "20", "IL", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("计划取样", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("作业线", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("订单数量", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
          
           
            iheadrow = 0;
            p_spanSpread("成品尺寸", 20, 21, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
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