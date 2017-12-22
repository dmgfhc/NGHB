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
//-- Program Name      加热炉实绩查询界面
//-- Program ID        CGT2000C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.11.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.11.01       韩超        中板轧钢作业
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT3030C : CommonClass.FORMBASE
    {
        public WGT3030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_SLAB_NO = 0;
        const int SS1_FIRST_REMARK = 1;
        const int SS1_RHF_CH_ROW = 5;
        const int SS1_SLAB_STLGRD = 7;
        const int SS1_MILL_STLGRD = 8;
        const int SS1_APLY_STDSPEC = 9;
        //20130314 标准号 LICHAO
        const int SS1_SLAB_WGT = 17;
        const int SS1_CHARGE_DATE = 20;
        const int SS1_DISCHARGE_DATE = 22;
        const int SS1_DELAY_DATE = 23;
        const int SS1_ZAILU_DATE = 24;
        const int SS1_CHARGE_TEMP = 25;
        const int SS1_EXT_TEMP = 26;
        const int SS1_ORD_FL = 29;
        const int SS1_ORD_NO = 37;
        const int SS1_CUST_CD = 42;
        const int SS1_URGNT_FL = 46;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 50;


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_PROD_CD, "P", "", "", "", imcseq, "");//0
            p_SetMc(txt_STDSPEC, "P", "", "", "", imcseq, "");//1
            p_SetMc(txt_THK_MIN, "P", "", "", "", imcseq, "");//2
            p_SetMc(txt_THK_MAX, "P", "", "", "", imcseq, "");//3
            p_SetMc(udt_DSC_DATE_MIN, "P", "", "", "", imcseq, "");//4
            p_SetMc(udt_DSC_DATE_MAX, "P", "", "", "", imcseq, "");//5
            p_SetMc(txt_plt, "P", "", "", "", imcseq, "");//6
            p_SetMc(txt_GROUP_CD, "P", "", "", "", imcseq, "");//7
            p_SetMc(txt_SMP_NO, "P", "", "", "", imcseq, "");//8
            p_SetMc(txt_PROD_NO, "P", "", "", "", imcseq, "");//9
            p_SetMc(CHECK_1, "P", "", "", "", imcseq, "");//10


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("产品号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("试样号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("表面等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("材质等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("性能改判等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("综判等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("订单钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("原始订单标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("改判后标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("板坯厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("钢板厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("坯料切割班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("轧制班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("改判原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("入加热炉", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("终轧温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("返红温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("C", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("Mn", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("P", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("S", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//23
            p_SetSc("Si", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("Cu", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//25
            p_SetSc("Ni", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("Cr", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("V", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("Ti", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("Nb", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("Mo", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//31
            p_SetSc("B", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("Pb", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//33
            p_SetSc("Ca", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//34
            p_SetSc("N", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//35
            p_SetSc("O", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//36
            p_SetSc("H", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//37
            p_SetSc("Als", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//38
            p_SetSc("Alt", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//39
            p_SetSc("Mq", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//40
            p_SetSc("Sn", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//41
            p_SetSc("As", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//42
            p_SetSc("Sb", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//43
            p_SetSc("Ceq", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//44
            p_SetSc("Pcm", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//45
            p_SetSc("W", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//46
            p_SetSc("Zr", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//47
            p_SetSc("Co", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//48
            p_SetSc("Te", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//49
            p_SetSc("Bi", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//50
            p_SetSc("Zn", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//51
            p_SetSc("Re", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("Se", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//53
            p_SetSc("Ta", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("单值1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//55
            p_SetSc("单值2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//56
            p_SetSc("单值3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//57
            p_SetSc("平均值", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("屈服强度(Mpa)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//59
            p_SetSc("抗拉强度(Mpa)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//60
            p_SetSc("延升率(%)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//61
            p_SetSc("冷弯", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//62
            p_SetSc("单值1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//63
            p_SetSc("单值2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//64
            p_SetSc("单值3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//65
            p_SetSc("单值4", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//66
            p_SetSc("单值5", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//67
            p_SetSc("单值6", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//68
            p_SetSc("冲击值_平均", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//69
            p_SetSc("单值1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//70
            p_SetSc("单值2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//71
            p_SetSc("单值3", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//72
            p_SetSc("单值4", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//73
            p_SetSc("单值5", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//74
            p_SetSc("单值6", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//75
            p_SetSc("时效冲击_平均", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//76
            p_SetSc("落锤实验1", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//77
            p_SetSc("落锤实验2", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//78
            p_SetSc("落锤实验_平均", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//79
            p_SetSc("屈强比", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//80
            p_SetSc("晶粒度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//81
            p_SetSc("硬度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//82
            
            
            iheadrow = 0;
            p_spanSpread("工艺", 17, 19, iscseq, iheadrow, 1);
            p_spanSpread("成分", 20, 54, iscseq, iheadrow, 1);
            p_spanSpread("断面收缩率", 55, 58, iscseq, iheadrow, 1);
            p_spanSpread("冲击值", 63, 69, iscseq, iheadrow, 1);
            p_spanSpread("时效冲击", 70, 76, iscseq, iheadrow, 1);
            p_spanSpread("落锤实验", 77, 79, iscseq, iheadrow, 1);
           

        }

        //private void CGT2000C_Load(object sender, EventArgs e)
        //{
        //    base.sSvrPgmPkgName = "CGT2000NC";
        //    Form_Define();

        //    SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
        //    SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");

        //    SSPpdt.BackColor = Color.Fuchsia;

        //}


        private void WGT3030C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGT3030C";
            Form_Define();
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

    }
}
