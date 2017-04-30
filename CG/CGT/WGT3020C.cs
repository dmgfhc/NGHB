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
//-- Sub_System Name   统计分析管理
//-- Program Name      物料查询界面
//-- Program ID        WGT3020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.12.04
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER        DATE         EDITOR       DESCRIPTION
//-- 1.00    2012.12.04       李超         物料查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
namespace CG
{
    public partial class WGT3020C : CommonClass.FORMBASE
    {
        public WGT3020C()
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
            //p_SetMc(TXT_PLT, "P", "", "", "", imcseq, "");
            p_SetMc("轧制时间",CDT_PROD_DATE_FROM, "PN", "", "", "","", imcseq);
            p_SetMc("轧制时间",CDT_PROD_DATE_TO, "PN", "", "", "","", imcseq);
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CB0_GROUP, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_STDSPEC, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SP_CD, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            //0-86(综合)
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("C", "N", "10", "L", "", "", "", iscseq, iheadrow,"R");//2
            p_SetSc("Mn", "N", "10", "L", "", "", "", iscseq, iheadrow,"R");//3
            p_SetSc("P", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("S", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//5
            p_SetSc("Si", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//6
            p_SetSc("Ni", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//7
            p_SetSc("Cr", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//8
            p_SetSc("Cu", "E", "10", "AL", "", "", "", iscseq, iheadrow,"R");//9
            p_SetSc("Alt", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//10
            p_SetSc("Als", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//11
            p_SetSc("Nb", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//12
            p_SetSc("Mo", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//13
            p_SetSc("V", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//14
            p_SetSc("Ti", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//15
            p_SetSc("Ca", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//16
            p_SetSc("Ceq", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//17
            p_SetSc("Pcm", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//18
            p_SetSc("Pb", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//19
            p_SetSc("Sb", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//20
            p_SetSc("Sn", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//21
            p_SetSc("As", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//22
            p_SetSc("B", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//23
            p_SetSc("W", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//24
            p_SetSc("Co", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//25
            p_SetSc("Se", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//26
            p_SetSc("Te", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//27
            p_SetSc("Zn", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//28
            p_SetSc("Zr", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//29
            p_SetSc("N", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//30
            p_SetSc("O", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//31
            p_SetSc("H", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//32
            p_SetSc("Mg", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//33
            p_SetSc("Bi", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//34
            p_SetSc("点吹次数", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//35
            p_SetSc("点吹时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//36
            p_SetSc("吹炼前温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//37
            p_SetSc("吹练后温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//38
            p_SetSc("出钢开始时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//39
            p_SetSc("出钢结束时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//40
            p_SetSc("开始时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//41
            p_SetSc("开始时温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//42
            p_SetSc("通电时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//43
            p_SetSc("通电量", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//44
            p_SetSc("喂丝种类1", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//45
            p_SetSc("喂丝种类2", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//46
            p_SetSc("喂丝重量1", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//47
            p_SetSc("喂丝重量2", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//48
            p_SetSc("静搅时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//49
            p_SetSc("钢包离开时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//50
            p_SetSc("结束时温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//51
            p_SetSc("开始作业时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//52
            p_SetSc("开始时温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//53
            p_SetSc("真空度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//54
            p_SetSc("真空度保持时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//55
            p_SetSc("喂丝种类1", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//56
            p_SetSc("喂丝种类2", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//57
            p_SetSc("喂丝重量1", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//58
            p_SetSc("喂丝重量2", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//59
            p_SetSc("静搅时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//60
            p_SetSc("钢包离开时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//61
            p_SetSc("结束时温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//62
            p_SetSc("浇铸开始时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//63
            p_SetSc("连浇号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//64
            p_SetSc("炉序号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//65
            p_SetSc("液相线温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//66
            p_SetSc("一次温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//67
            p_SetSc("二次温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//68
            p_SetSc("三次温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//69
            p_SetSc("平均温度", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//70
            p_SetSc("最高液位", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//71
            p_SetSc("最低液位", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//72
            p_SetSc("平均液位", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//73
            p_SetSc("最高拉速", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//74
            p_SetSc("最低拉速", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//75
            p_SetSc("平均拉速", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//76
            p_SetSc("钢包关闭时间", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//77
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//78
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//79
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//80
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow,"R");//81
            p_SetSc("使用工厂", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//82
            p_SetSc("头尾坯", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//83
            p_SetSc("铸坯表面质量", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//84
            p_SetSc("铸坯内部质量", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//85
            p_SetSc("连铸工艺异常", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//86

            //87-130
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//87
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//88
            p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow,"M");//89
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//90
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow,"M");//91
            p_SetSc("订单规格", "E", "30", "L", "", "", "", iscseq, iheadrow,"M");//92
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//93
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//94
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//95
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//96
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//97
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//98
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//99
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//100
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//101
            p_SetSc("实绩", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//102
            p_SetSc("初轧结束温度", "N", "7", "L", "", "", "", iscseq, iheadrow,"R");//103
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//104
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//105
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//106
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//107
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//108
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//109
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//110
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//111
            p_SetSc("目标", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//112
            p_SetSc("实绩", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//113
            p_SetSc("厚", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//114
            p_SetSc("宽", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//115
            p_SetSc("长", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//116
            p_SetSc("矩形度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//117
            p_SetSc("不平度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//118
            p_SetSc("表面等级", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//119
            p_SetSc("取样号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//120
            p_SetSc("取样代码", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//121
            p_SetSc("屈服", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//122
            p_SetSc("抗拉", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//123
            p_SetSc("延伸率", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//124
            p_SetSc("冲击均值", "N", "3", "L", "", "", "", iscseq, iheadrow,"R");//125
            p_SetSc("DWTT", "N", "3", "L", "", "", "", iscseq, iheadrow,"R");//126
            p_SetSc("Z向性能", "N", "3,1", "L", "", "", "", iscseq, iheadrow, "R");//127
            p_SetSc("方式", "E", "6", "L", "", "", "", iscseq, iheadrow,"M");//128
            p_SetSc("加热速率", "E", "6", "L", "", "", "", iscseq, iheadrow,"R");//129
            p_SetSc("加热温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"M");//130
            p_SetSc("保温时间", "N", "9", "L", "", "", "", iscseq, iheadrow,"M");//131
  
            iheadrow = 0;
            p_spanSpread("中间包成分", 2, 34, iscseq, iheadrow, 1);
            p_spanSpread("转炉", 35, 40, iscseq, iheadrow, 1);
            p_spanSpread("LF", 41, 51, iscseq, iheadrow, 1);
            p_spanSpread("RH", 52, 62, iscseq, iheadrow, 1);
            p_spanSpread("连铸工序", 63, 86, iscseq, iheadrow, 1);
            p_spanSpread("入炉温度", 93, 94, iscseq, iheadrow, 1);
            p_spanSpread("出炉温度", 95, 96, iscseq, iheadrow, 1);
            p_spanSpread("在炉时间(分钟)", 97, 98, iscseq, iheadrow, 1);
            p_spanSpread("温度均匀性", 99, 100, iscseq, iheadrow, 1);
            p_spanSpread("均热段时间(分钟)", 101, 102, iscseq, iheadrow, 1);
            p_spanSpread("二阶段开轧温度", 104, 105, iscseq, iheadrow, 1);
            p_spanSpread("二阶段开轧厚度(厚度比)", 106, 107, iscseq, iheadrow, 1);
            p_spanSpread("终轧温度", 108, 109, iscseq, iheadrow, 1);
            p_spanSpread("冷却速率", 110, 111, iscseq, iheadrow, 1);
            p_spanSpread("终冷温度", 112, 113, iscseq, iheadrow, 1);
            p_spanSpread("成品规格", 114, 118, iscseq, iheadrow, 1);
            p_spanSpread("取样", 120, 121, iscseq, iheadrow, 1);
            p_spanSpread("力学性能", 122, 127, iscseq, iheadrow, 1);
            p_spanSpread("热处理实绩", 128, 131, iscseq, iheadrow, 1);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGT1090C";
            Form_Define();
            OPT_MILL.Checked = true;
          //  base.sAuthority = "1111";

            TXT_SP_CD.Text = "M";

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 5, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 8, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 9, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 10, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 11, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 13, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 14, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 15, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 25, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 31, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 32, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 33, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 34, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 35, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 36, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 37, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 38, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 39, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 40, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 41, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 42, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 43, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 44, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 45, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 46, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 47, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 48, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 49, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 50, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 51, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 52, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 53, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 54, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 55, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 56, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 57, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 58, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 59, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 60, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 61, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 62, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 63, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 64, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 65, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 66, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 67, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 68, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 69, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 70, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 71, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 72, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 73, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 74, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 75, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 76, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 77, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 78, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 79, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 80, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 81, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 82, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 83, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 84, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 85, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 86, true);
        }
        #endregion

        //只能查一天
        public override void Form_Ref()
        {
            if (CDT_PROD_DATE_FROM.RawDate != CDT_PROD_DATE_TO.RawDate)
            {
                GeneralCommon.Gp_MsgBoxDisplay("只能查询一天的信息!", "", "");
                return;
            }
            p_Ref(1, 1, true, true);
        }

        //单击轧钢按钮事件
        private void OPT_MILL_Click(object sender, EventArgs e)
        {
            if (OPT_MILL.Checked == true)
            {
                OPT_MILL.ForeColor = Color.Red;
                OPT_SMSMILL.ForeColor = Color.Black;
                TXT_SP_CD.Text = "M";
                ss1.ActiveSheet.RowCount = 0;
            }
            else
            {
                OPT_MILL.ForeColor = Color.Black;
                TXT_SP_CD.Text = "A";
            }

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 5, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 8, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 9, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 10, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 11, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 13, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 14, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 15, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 25, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 31, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 32, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 33, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 34, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 35, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 36, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 37, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 38, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 39, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 40, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 41, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 42, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 43, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 44, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 45, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 46, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 47, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 48, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 49, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 50, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 51, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 52, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 53, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 54, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 55, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 56, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 57, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 58, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 59, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 60, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 61, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 62, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 63, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 64, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 65, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 66, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 67, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 68, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 69, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 70, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 71, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 72, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 73, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 74, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 75, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 76, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 77, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 78, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 79, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 80, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 81, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 82, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 83, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 84, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 85, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 86, true);
        }

        //单击综合按钮事件
        private void OPT_SMSMILL_Click(object sender, EventArgs e)
        {
            if (OPT_SMSMILL.Checked == true)
            {
                OPT_SMSMILL.ForeColor = Color.Red;
                OPT_MILL.ForeColor = Color.Black;
                TXT_SP_CD.Text = "A";
                ss1.ActiveSheet.RowCount = 0;
            }
            else
            {
                OPT_SMSMILL.ForeColor = Color.Black;
                TXT_SP_CD.Text = "M";
            }

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 3, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 4, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 5, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 8, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 9, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 10, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 11, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 13, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 14, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 15, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 24, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 25, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 28, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 29, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 30, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 31, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 32, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 33, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 34, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 35, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 36, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 37, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 38, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 39, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 40, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 41, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 42, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 43, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 44, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 45, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 46, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 47, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 48, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 49, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 50, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 51, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 52, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 53, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 54, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 55, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 56, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 57, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 58, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 59, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 60, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 61, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 62, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 63, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 64, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 65, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 66, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 67, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 68, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 69, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 70, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 71, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 72, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 73, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 74, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 75, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 76, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 77, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 78, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 79, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 80, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 81, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 82, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 83, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 84, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 85, false);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 86, false);
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls()) 
            {
                TXT_PLT.Text = "C1";
            }
            return true;
        }
    }
}
