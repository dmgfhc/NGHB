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
//-- Sub_System Name   轧钢作业实绩管理
//-- Program Name      质量设计现状详细查询 
//-- Program ID        CGA2021C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.04.27
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        质量设计现状详细查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGB2021C : CommonClass.FORMBASE
    {
        public CGB2021C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();


        //const int SPD_PLAN_PROD_WGT = 33,
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1,true);
            imcseq = 1;
            p_SetMc("板坯号", txt_SLAB_NO, "PNR", "", "", "", "", imcseq);
            p_SetMc("冷/热装", txt_HCR_KND, "R", "", "", "", "", imcseq);
            p_SetMc("加热二段温度工艺范围", txt_HEATTWO_TEMP_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("加热二段温度工艺范围", txt_HEATTWO_TEMP_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("均热段温度工艺范围", txt_AVE_TEMP_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("均热段温度工艺范围", txt_AVE_TEMP_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("均热时间工艺范围", txt_AVE_RATE_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("均热时间工艺范围", txt_AVE_RATE_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("总加热时间范围", txt_TOTAL_RATE_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("总加热时间范围", txt_TOTAL_RATE_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("中间坯厚度范围", txt_CR_MILL_RATET1_2, "R", "", "", "", "", imcseq);
            p_SetMc("精轧机开轧温度", txt_CR_MILL_TMPT1_2, "R", "", "", "", "", imcseq);
            p_SetMc("入水温度最大值", txt_ROLL_TEMP_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("入水温度最小值", txt_ROLL_TEMP_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("入水温度目标值", txt_ROLL_TEMP_TGT_2, "R", "", "", "", "", imcseq);
            p_SetMc("返红温度最大值", txt_COOL_TMP_MAX_2, "R", "", "", "", "", imcseq);
            p_SetMc("返红温度最小值", txt_COOL_TMP_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("返红温度目标值", txt_COOL_TMP_TGT_2, "R", "", "", "", "", imcseq);
            p_SetMc("轧件目标厚度", txt_MILL_THK, "R", "", "", "", "", imcseq);
            p_SetMc("订单厚度最小值", txt_ORD_THK_MIN, "R", "", "", "", "", imcseq);
            p_SetMc("订单厚度最大值", txt_ORD_THK_MAX, "R", "", "", "", "", imcseq);
            p_SetMc("订单长度", txt_ORD_LEN, "R", "", "", "", "", imcseq);
            p_SetMc("订单长度最小值", txt_ORD_LEN_MIN, "R", "", "", "", "", imcseq);
            p_SetMc("订单长度最大值", txt_ORD_LEN_MAX, "R", "", "", "", "", imcseq);
            p_SetMc("终轧温度目标值", txt_MILL_TMP_TGT_2, "R", "", "", "", "", imcseq);
            p_SetMc("终轧温度最小值", txt_MILL_TMP_MIN_2, "R", "", "", "", "", imcseq);
            p_SetMc("终轧温度最大值", txt_MILL_TMP_MAX_2, "R", "", "", "", "", imcseq);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGB2021NC";
            Form_Define();
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 0, true, false);
        }

        //public override void Form_Pro()
        //{
        //    p_pro(1, 1, true, true);
        //}

        public override bool Form_Cls()
        {
            base.Form_Cls();
            return true;

        }
        #endregion


    }
}