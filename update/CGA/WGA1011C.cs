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
//-- Sub_System Name   板坯修磨指示查询
//-- Program Name      板坯修磨指示查询
//-- Program ID        WGA1011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          王雷
//-- Coder             王雷
//-- Date              2014.08.17
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//--  VER       DATE         EDITOR       DESCRIPTION
//-- 1.00    2014.08.17       王雷        板坯修磨指示查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGA1011C : CommonClass.FORMBASE
    {
        public WGA1011C()
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
            p_SetMc(txt_Status, "PI", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(txt_MOSLAB, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_CUR_INV, "P", "", "", "", imcseq, "");
            p_SetMc(txt_slab_status, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_plt, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP_CD, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("状态", "E", "10", "PILA", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("板坯号", "E", "10", "PNIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("碳", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("连铸机号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("订单序列号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("垛位号", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("库别", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("板坯状态", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("订单材/余材", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("实际轧制工厂", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("最早交货期", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("坯料生产日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("修磨指示", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("实绩标识", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("下达班次", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("下达班别", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("下达人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("下达时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("录入班次", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("录入班别", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("录入人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("录入时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("修磨工艺", "E", "100", "I", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("修磨原因", "E", "100", "I", "", "", "", iscseq, iheadrow, "M");//32

            p_spanSpread("板坯信息", 11, 14, 1, 0, 1);
            p_spanSpread("订单信息", 15, 17, 1, 0, 1);
            p_spanSpread("备注", 31, 32, 1, 0, 1);

            

        }

        private void WGA1011C_Load(object sender, EventArgs e)
        {
            Form_Define();
            opt_prc_status1.Checked = true;
            opt_prc_status1.ForeColor = Color.Red;
            txt_Status.Text = "1";
            SDT_PROD_DATE_FROM.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(TRUNC(ADD_MONTHS(LAST_DAY(SYSDATE), -1) + 1), 'YYYYMMDD')FROM DUAL");
            SDT_PROD_DATE_TO.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL");
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";           
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";          
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            CBO_CUR_INV.Text = "HB";
            text_cur_inv.Text = "宽厚板厂";
            txt_thk.Text = "60";
            txt_thk_to.Text = "225";
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, true);

           

        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            for (int i = 0; i < this.ss1_Sheet1.RowCount; i++)
            {
                if (ss1.ActiveSheet.Cells[i, 25].Text != "")
                {
                    ss1.ActiveSheet.Cells[i, 25].Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "Q0077", ss1.ActiveSheet.Cells[i, 25].Text, 1);
                }
                if (ss1.ActiveSheet.Cells[i, 29].Text != "")
                {
                    ss1.ActiveSheet.Cells[i, 29].Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "Q0077", ss1.ActiveSheet.Cells[i, 29].Text, 1);
                }
 
            }
           
        }
        #endregion


        public override bool Form_Cls()
        {
            base.Form_Cls();
            opt_prc_status1_CheckedChanged(this.opt_prc_status1, new EventArgs());
            return true;
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column<=30)
            {


                if (this.opt_prc_status1.Checked)
                {

                    if (ss1.ActiveSheet.Cells[e.Row, 21].Text == "Y")
                    {
                        ss1.ActiveSheet.Cells[e.Row, 21].Text = "";
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                        ss1.ActiveSheet.Cells[e.Row, 25].Text = "";


                    }
                    else
                    {
                        ss1.ActiveSheet.Cells[e.Row, 21].Text = "Y";
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss1.ActiveSheet.Cells[e.Row, 0].Text = "1";
                        ss1.ActiveSheet.Cells[e.Row, 25].Text = GeneralCommon.sUserID;

                    }

                }
                if (this.opt_prc_status2.Checked)
                {

                    //ss1.ActiveSheet.Cells[0, 24].Text = "录入人员";
                    if (ss1.ActiveSheet.Cells[e.Row, 22].Text == "Y")
                    {
                        ss1.ActiveSheet.Cells[e.Row, 22].Text = "";
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                        ss1.ActiveSheet.Cells[e.Row, 29].Text = "";
                    }
                    else
                    {
                        ss1.ActiveSheet.Cells[e.Row, 22].Text = "Y";
                        ss1.ActiveSheet.Cells[e.Row, 0].Text = "2";
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss1.ActiveSheet.Cells[e.Row, 29].Text = GeneralCommon.sUserID;

                    }
                }

                if (this.opt_prc_status3.Checked)
                {

                    ss1.ActiveSheet.Cells[e.Row, 0].Text = "3";

                }

            }
            if (e.Column> 30)
            {
                ss1.EditMode = true;
            }
        }
        public override void Form_Pro()
        {
            p_pro(1, 1, true, false);
           
        }

        private void opt_prc_status1_CheckedChanged(object sender, EventArgs e)
        {
            this.ss1_Sheet1.RowCount = 0;
            opt_prc_status1.ForeColor = Color.Red;
            opt_prc_status2.ForeColor = Color.Black;
            opt_prc_status3.ForeColor = Color.Black;
            txt_MOSLAB.Text = "";
            txt_Status.Text = "1";

            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, true);
        }

        private void opt_prc_status2_CheckedChanged(object sender, EventArgs e)
        {
            this.ss1_Sheet1.RowCount = 0;
            opt_prc_status2.ForeColor = Color.Red;
            opt_prc_status1.ForeColor = Color.Black;
            opt_prc_status3.ForeColor = Color.Black;
            txt_MOSLAB.Text = "";
            txt_Status.Text = "2";

            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, false);
        }

        private void opt_prc_status3_CheckedChanged(object sender, EventArgs e)
        {
            this.ss1_Sheet1.RowCount = 0;
            opt_prc_status3.ForeColor = Color.Red;
            opt_prc_status2.ForeColor = Color.Black;
            opt_prc_status1.ForeColor = Color.Black;
            txt_MOSLAB.Text = "";
            txt_Status.Text = "3";

            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, false);
        }

     

    }
}
