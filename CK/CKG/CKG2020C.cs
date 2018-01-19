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
//-- Program Name      轧钢作业指示查询界面_CKG2020C
//-- Program ID        CKG2020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          HANCHAO
//-- Coder             HANCHAO
//-- Date              2018.01.19
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER   DATE     EDITOR       DESCRIPTION
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2020C : CommonClass.FORMBASE
    {
        public CKG2020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();


        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("板坯号", CBO_SLAB_NO, "P", "", "", "", "", imcseq);
            p_SetMc("工厂代码", CBO_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", CBO_PRC_LINE, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow,"L");//0
            p_SetSc("板坯状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("工厂代码", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度*宽度*长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("板坯去向", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("轧辊单位", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("出炉温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("轧制方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("控轧代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//11

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc(CBO_SLAB_NO, "PR", "", "", "", imcseq, "");//0
            p_SetMc(CBO_PLT, "PR", "", "", "", imcseq, "");//1 
            p_SetMc(CBO_PRC_LINE, "PR", "", "", "", imcseq, "");//2 
            p_SetMc(SDB_HEAD_SLAB_WID, "R", "", "", "", imcseq, "");//3 
            p_SetMc(SDB_TAIL_SLAB_WID, "R", "", "", "", imcseq, "");//4 
            p_SetMc(SDB_SLAB_THK, "R", "", "", "", imcseq, "");//5 
            p_SetMc(SDB_SLAB_LEN, "R", "", "", "", imcseq, "");//6 
            p_SetMc(SDB_SLAB_WGT, "R", "", "", "", imcseq, "");//7 
            p_SetMc(SDB_STLGRD, "R", "", "", "", imcseq, "");//8 
            p_SetMc(SDB_ROLL_UNIT, "R", "", "", "", imcseq, "");//9 
            p_SetMc(TXT_SLAB_WAY, "R", "", "", "", imcseq, "");//10
            p_SetMc(SDB_MILL_END_AIM_TEMP, "R", "", "", "", imcseq, "");//11
            p_SetMc(SDB_COILING_2_TEMP, "R", "", "", "", imcseq, "");//12
            p_SetMc(SDB_MP_THK, "R", "", "", "", imcseq, "");//13
            p_SetMc(SDB_MP_THK_TOL_MAX, "R", "", "", "", imcseq, "");//14
            p_SetMc(SDB_MP_THK_TOL_MIN, "R", "", "", "", imcseq, "");//15
            p_SetMc(SDB_MP_WID, "R", "", "", "", imcseq, "");//16
            p_SetMc(SDB_MP_WID_TOL_MAX, "R", "", "", "", imcseq, "");//17
            p_SetMc(SDB_MP_WID_TOL_MIN, "R", "", "", "", imcseq, "");//18
            p_SetMc(SDB_CROWN_WID, "R", "", "", "", imcseq, "");//19
            p_SetMc(SDB_CROWN_TOL_MAX, "R", "", "", "", imcseq, "");//20
            p_SetMc(SDB_CROWN_TOL_MIN, "R", "", "", "", imcseq, "");//21
            p_SetMc(SDB_MILL_TMP_TGT, "R", "", "", "", imcseq, "");//22
            p_SetMc(SDB_MILL_TMP_MAX, "R", "", "", "", imcseq, "");//23
            p_SetMc(SDB_MILL_TMP_MIN, "R", "", "", "", imcseq, "");//24
            p_SetMc(SDB_UPD_DEL_FL, "R", "", "", "", imcseq, "");//25
            p_SetMc(SDB_COOL_TEMP_MAX, "R", "", "", "", imcseq, "");//26
            p_SetMc(SDB_COOL_TEMP_MIN, "R", "", "", "", imcseq, "");//27
            p_SetMc(TXT_COOL_MTH, "R", "", "", "", imcseq, "");//28
            p_SetMc(SDB_COOL_SPEED, "R", "", "", "", imcseq, "");//29
            p_SetMc(SDB_PROD_CD, "R", "", "", "", imcseq, "");//30
            p_SetMc(TXT_TRIM_FL, "R", "", "", "", imcseq, "");//31
            p_SetMc(TXT_CR_CD, "R", "", "", "", imcseq, "");//32
            p_SetMc(TXT_HL_CD, "R", "", "", "", imcseq, "");//33
            p_SetMc(SDB_CR_MILL_RATET1, "R", "", "", "", imcseq, "");//34
            p_SetMc(SDB_CR_MILL_TMPT1, "R", "", "", "", imcseq, "");//35
            p_SetMc(SDB_MP_CUT, "R", "", "", "", imcseq, "");//36
            p_SetMc(SDB_CR_MILL_TMPT2, "R", "", "", "", imcseq, "");//37
            p_SetMc(SDB_CR_MILL_RATET3, "R", "", "", "", imcseq, "");//38
            p_SetMc(SDB_CR_MILL_TMPT3, "R", "", "", "", imcseq, "");//39
            p_SetMc(TXT_COIL_NO, "R", "", "", "", imcseq, "");//40
            p_SetMc(SDB_HEAD_CUT_LEN, "R", "", "", "", imcseq, "");//41
            p_SetMc(SDB_TAIL_CUT_LEN, "R", "", "", "", imcseq, "");//42
            p_SetMc(TXT_SMP_FL, "R", "", "", "", imcseq, "");//43
            p_SetMc(TXT_BAND_CD, "R", "", "", "", imcseq, "");//44
            p_SetMc(TXT_SMP_NO, "R", "", "", "", imcseq, "");//45
            p_SetMc(TXT_SMP_LOC, "R", "", "", "", imcseq, "");//46
            p_SetMc(SDB_SMP_LEN, "R", "", "", "", imcseq, "");//47
            p_SetMc(TXT_MARK_DATA1, "R", "", "", "", imcseq, "");//48
            p_SetMc(TXT_MARK_DATA2, "R", "", "", "", imcseq, "");//49
            p_SetMc(TXT_MARK_DATA3, "R", "", "", "", imcseq, "");//50

        }

        private void CKG2020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKG2020NC";
            Form_Define();
        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            CBO_SLAB_NO.Text = ss1.ActiveSheet.Cells[e.Row,0].Text;
            CBO_PLT.Text = ss1.ActiveSheet.Cells[e.Row, 1].Text;
            CBO_PRC_LINE.Text = ss1.ActiveSheet.Cells[e.Row, 2].Text;
            p_Ref(2, 0, false, false);
            CBO_SLAB_NO.Enabled = true;
            CBO_PLT.Enabled = true;
            CBO_PRC_LINE.Enabled = true;
        }


    
    }
}
