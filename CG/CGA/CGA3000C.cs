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
//-- Program Name      板坯检验录入界面_CGA3000C
//-- Program ID        CGA3000C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯检验录入界面_CGA3000C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA3000C : CommonClass.FORMBASE
    {
        public CGA3000C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        //const int SPD_PLAN_PROD_WGT = 33,

       // string s1 = "SELECT '9无','0手写号','1标识不清','2毛刺','3尺寸不符','4接坯','5裂纹','6凹坑','7角裂','8割缝' FROM DUAL";
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_slab_no, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(txt_OCCR_TS, "P", "", "", "", imcseq, "");
            p_SetMc(txt_OCCR_TS2, "P", "", "", "", imcseq, "");
            p_SetMc(txt_CUT_TS, "P", "", "", "", imcseq, "");
            p_SetMc(txt_CUT_TS2, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_FLAG, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 18, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "NIL", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("H/C", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯厚度", "N", "8", "IL", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("板坯宽度", "N", "8", "IL", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("板坯长度", "N", "8", "IL", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("检验厚度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("检验宽度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//10

            p_SetSc("检验长度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("缺陷记录", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("处理结果", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("判定结果", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//14

            p_SetSc("班次", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("班别", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("作业日期", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("作业人员", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("修改日期", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("修改人员", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//20
           
            //iheadrow = 0;
            //p_spanSpread("当垛位号", 3, 5, iscseq, iheadrow, 1);
            //p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA3000C";
            Form_Define();
            txt_OCCR_TS.RawDate = System.DateTime.Now.ToString();
            txt_OCCR_TS2.RawDate = System.DateTime.Now.ToString();
            OPT_SCRAP_WAIT.Checked = true;
            label3.Visible = false;
            CBO_SHIFT.Visible = false;
            label4.Text = "转库日期";
            label3.Visible = false;
            CBO_SHIFT.Visible = false;
            TXT_FLAG.Text = "1";

            FarPoint.Win.Spread.CellType.ComboBoxCellType cb4 = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            //cb4.ListWidth = 96;
            //cb4.Editable = true;
            //cb4.MaxDrop = 10;
            //cb4.MaxLength = 1;
            //添加选项代码
            string[] priceTagList = new string[] { "9无","0手写号","1标识不清","2毛刺","3尺寸不符","4接坯","5裂纹","6凹坑","7角裂","8割缝" };
            cb4.Items = priceTagList;
            ss1.ActiveSheet.Columns[12].CellType = cb4;
            priceTagList = new string[] {"0:合格","1:不合格"};
            cb4.Items = priceTagList;
            ss1.ActiveSheet.Columns[14].CellType = cb4;

            //txt_cur_inv.Text = "ZB";
            //txt_prod_cd.Text = "SL";
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            if ((txt_OCCR_TS.RawDate != "" | txt_OCCR_TS2.RawDate != "") & (txt_CUT_TS.RawDate != "" | txt_CUT_TS2.RawDate != ""))
            {
                GeneralCommon.Gp_MsgBoxDisplay("转库日期和切割日期不能同时输入 ！！！", "I", "");
                return;

            }

            if ((txt_OCCR_TS.RawDate == "" | txt_OCCR_TS2.RawDate == "") & (txt_CUT_TS.RawDate == "" | txt_CUT_TS2.RawDate == "") & txt_slab_no.Text == "" & CBO_SHIFT.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入查询条件 ！！！", "I", "");

            }
            
            p_Ref(1, 1, true, true);

            if (TXT_FLAG.Text == "1")
            {

                GeneralCommon.MDIToolBar.Buttons[6].Enabled = false;
                GeneralCommon.MDIToolBar.Buttons[7].Enabled = false;

            }
            else if (TXT_FLAG.Text == "2")
            {

                GeneralCommon.MDIToolBar.Buttons[6].Enabled = false;
                GeneralCommon.MDIToolBar.Buttons[7].Enabled = true;
            }
        }

        public override void Form_Pro()
        {
            p_pro(1, 1, true, true);

            if (TXT_FLAG.Text == "1")
            {

                GeneralCommon.MDIToolBar.Buttons[6].Enabled = false;
                GeneralCommon.MDIToolBar.Buttons[7].Enabled = false;

            }
            else if (TXT_FLAG.Text == "2")
            {

                GeneralCommon.MDIToolBar.Buttons[6].Enabled = false;
                GeneralCommon.MDIToolBar.Buttons[7].Enabled = true;
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_OCCR_TS.RawDate = System.DateTime.Now.ToString();
            txt_OCCR_TS2.RawDate = System.DateTime.Now.ToString();
            OPT_SCRAP_WAIT.Checked = true;
            TXT_FLAG.Text = "1";
            label4.Text = "转库日期";
            label3.Visible = false;
            CBO_SHIFT.Visible = false;
            return true;

        }
        #endregion

        private void OPT_SCRAP_WAIT_CheckedChanged(object sender, EventArgs e)
        {
            if (OPT_SCRAP_WAIT.Checked)
            {
                TXT_FLAG.Text = "1";
                label4.Text = "转库日期";
                label3.Visible = false;
                CBO_SHIFT.Visible = false;
            }
            else
            {
                TXT_FLAG.Text = "2";
                label4.Text = "检验日期";
                label3.Visible = true;
                CBO_SHIFT.Visible = true;
            }
        }


    }
}