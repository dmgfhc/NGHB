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
//-- System Name       中板生产管制
//-- Sub_System Name   轧钢作业
//-- Program Name      轧钢计划查询界面_CKG2070C
//-- Program ID        CKG2070C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.22       韩超        轧钢计划查询界面_CKG2070C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2070C : CommonClass.FORMBASE
    {
        public CKG2070C()
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
            p_SetMc("", TXT_SLAB_NO, "P", "", "", "", "", imcseq);//0
            p_SetMc("", TXT_STLGRD, "P", "", "", "", "", imcseq);//1
            p_SetMc("", TXT_ORD_NO, "P", "", "", "", "", imcseq);//2
            p_SetMc("", CBO_ORD_ITEM, "P", "", "", "", "", imcseq);//3
            p_SetMc("", SDT_IN_DATE_FROM, "P", "", "", "", "", imcseq);//4
            p_SetMc("", SDT_IN_DATE_TO, "P", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_MILL_STLGRD, "P", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_SIZE, "P", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_SLAB_THK, "P", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_SLAB_THK_TO, "P", "", "", "", "", imcseq);//9
            p_SetMc("", SDB_SLAB_WID, "P", "", "", "", "", imcseq);//0
            p_SetMc("", SDB_SLAB_WID_TO, "P", "", "", "", "", imcseq);//11
            p_SetMc("", SDB_SLAB_LEN, "P", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_SLAB_LEN_TO, "P", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_THK, "P", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_THK_TO, "P", "", "", "", "", imcseq);//15
            p_SetMc("", SDB_WID, "P", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_WID_TO, "P", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_LEN, "P", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_LEN_TO, "P", "", "", "", "", imcseq);//19
            p_SetMc("", COB_FL, "P", "", "", "", "", imcseq);//20

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("辊期", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("辊期内板坯顺序", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("辊期内累计公里数", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("标记", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("备料", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("板坯类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("指示状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("板坯重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("订单号-序列", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当前位置", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("轧件长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("产品厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("产品宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("产品长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("控轧代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("实绩成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("计划编制时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("交货期结束", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("是否紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("备料", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("备料时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//29
          
           

            //iheadrow = 0;
            
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

        private void CKG2070C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKG2070NC";
            Form_Define();
        }

    }
}
