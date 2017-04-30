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
//-- Program Name      板坯入库规格修改界面_CGA2110C
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
//   1.00     2017.03.01       韩超        板坯入库规格修改界面_CGA2110C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2110C : CommonClass.FORMBASE
    {
        public CGA2110C()
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
            p_SetMc(txt_act_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(txt_MOSLAB, "P", "", "", "", imcseq, "");
            p_SetMc(txt_LOC, "P", "", "", "", imcseq, "");
            p_SetMc(txt_plt, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len_to, "P", "", "", "", imcseq, "");



            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "PIL", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("厚度", "N", "8,2", "NI", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("宽度", "N", "8", "NI", "", "", "", iscseq, iheadrow,"R");//2
            p_SetSc("长度", "N", "8", "NI", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("重量", "N", "8,3", "", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("理论重量", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("钢种", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("切割指示", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("切割块数", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("订单号", "E", "60", "", "", "", "", iscseq, iheadrow,"M");//9
            p_SetSc("订单材/余材代码", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("进程状态", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("进程代码", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("垛位号", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("入库日期", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("生产日期", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//15
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2110NC";
            Form_Define();
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            if (txt_MOSLAB.Text.Trim().Length != 0)
            {
                if (txt_MOSLAB.Text.Trim().Length < 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认Heat-no", "I", "");
                    txt_MOSLAB.Focus();
                    return;
                }
            }

            if (txt_MOSLAB.Text.Trim().Length != 8)
            {
                if (txt_plt.Text.Trim().Length == 0)
                {
                    //MsgBox "请确认工厂大码"
                    GeneralCommon.Gp_MsgBoxDisplay("请确认工厂代码", "I", "");
                    txt_plt.Focus();
                    return;
                }
            }

            if (txt_len.NumValue <= 0)
            {

                GeneralCommon.Gp_MsgBoxDisplay("请确认长度", "I", "");
                txt_len.Focus();
                return;
                //MsgBox "请确认从长度"
                //txt_len.SetFocus
                //Exit Sub
            }
            
            
            p_Ref(1, 1, true, true);
        }

        public override void Form_Pro()
        {
            p_pro(1, 1, true, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            
            return true;

        }
        #endregion


    }
}