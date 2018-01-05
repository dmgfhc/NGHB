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
//-- Program Name      板坯未热装原因查询及录入_CGT2090C
//-- Program ID        CGT2090C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.05
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.05       韩超        板坯未热装原因查询及录入_CGT2090C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2090C : CommonClass.FORMBASE
    {
        public CGT2090C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_REHEAT = 15;
        const int SS1_REHEATNAME = 16;
        const int SS1_REMARK = 17;
        const int SS1_USER = 18;
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(udFmDate, "P", "", "", "", imcseq, "");
            p_SetMc(udToDate, "P", "", "", "", imcseq, "");
            p_SetMc(txt_from_heat, "P", "", "", "", imcseq, "");
            p_SetMc(txt_to_heat, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("进程状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("状态代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种说明", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("板坯厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("板坯宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("板坯长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("订单厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("切割时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("卸车时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("装炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("堆冷时间（小时）", "N", "9,1", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("当前仓库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("未热装原因代码", "ETCR", "2", "I", "CD", "15;16", "SELECT T.CD,T.CD_NAME FROM ZP_CD T WHERE T.CD_MANA_NO = 'G0045'", iscseq, iheadrow, "M");//15
            p_SetSc("未热装原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("备注", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("录入人员", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//18

            //iheadrow = 0;
            //p_spanSpread("圆盘剪", 2, 3, iscseq, iheadrow, 1);

            
        }

        private void CGT2090C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2090NC";
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

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == SS1_REMARK || e.Column == SS1_REHEAT)
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                ss1.ActiveSheet.Cells[e.Row, SS1_USER].Text = GeneralCommon.sUserID;
            }
        }

    }
}
