﻿using System.Collections;
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
//-- Program Name      轧钢实绩查询界面
//-- Program ID        CGT2010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.16
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.12.16       韩超        轧钢实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2101C : CommonClass.FORMBASE
    {
        public CGT2101C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_SLENP = 8;//计划长度
        const int SS1_RM_CR_STAGE3_TIME = 12;//订单数量
        const int SS1_ORD_NO = 16;//订单号
        const int SS1_ORD_ITEM = 17;//订单序号
        const int SS1_CUST_CD_CODE = 18;//用户名称
        const int SS1_COOLING_TIME = 23;//堆冷时间
        const int SS1_CHA_UNCHA_IND = 24;//再装炉指示
        const int SS1_PRE_TOP_SLAB_TEMP = 29;//预热段温度上表
        const int SS1_PRE_BOT_SLAB_TEMP = 30;//预热段温度下表
        const int SS1_HT_TOP_SLAB_TEMP = 31;//加热段温度下限
        const int SS1_HT_BOT_SLAB_TEMP_TEG = 32;//加热段温度上限
        const int SS1_HT_BOT_SLAB_TEMP = 33;//加热段温度实绩
        const int SS1_HT_ZONE_TIME = 34;//加热段温度驻段时间
        const int SS1_EXT_TEMP_TEG = 44;//出炉温度目标
        const int SS1_EXT_TEMP = 45;//出炉温度实绩
        const int SS1_PDT_UNI_TEMP_TEG = 54;//温度均匀性目标
        const int SS1_PDT_UNI_TEMP = 55;//温度均匀性实绩
        const int SS1_DISCHARGE_DATE = 56;//出炉时间
        const int SS1_GAS = 57;//煤气热值
        const int SS1_O2 = 58;//炉内残氧
        const int SS1_HT_TEMP1 = 59;//除鳞压力开始
        const int SS1_TEMP2 = 60;//除鳞压力终了
        const int SS1_T1 = 61;//除鳞出口温度
        const int SS1_RM_MILL_END_AIM_TEMP = 64;//粗轧终轧温度目标
        const int SS1_RM_MILL_END_AVE_TEMP = 65;//粗轧终轧温度实绩
        const int SS1_CR_STAGE3_TIME = 67;//粗轧机轧制模式
        const int SS1_RM_AVE_WID = 71;//宽度(平均测宽)
        const int SS1_RM_SLAB_MILL_LEN = 72;//长度(计算)
        const int SS1_T12 = 73;//气雾冷却开冷温度目标
        const int SS1_T13 = 74;//气雾冷却开冷温度实绩
        const int SS1_T14 = 75;//气雾冷却终冷温度目标
        const int SS1_T15 = 76;//气雾冷却终冷温度实绩
        const int SS1_T16 = 77;//气雾冷却速度目标
        const int SS1_RM_COOL_RATE = 78;//气雾冷却速度实绩
        const int SS1_T20 = 81;//精轧开轧厚度比目标
        const int SS1_T21 = 82;//精轧开轧厚度比实绩
        const int SS1_ROLLING_METHOD = 87;//精轧机轧制模式
        const int SS1_AIM_THK = 90;//目标厚度
        const int SS1_T32 = 97;//ACC冷却终冷温度目标
        const int SS1_EXT_STK_TEMP = 98;//ACC冷却终冷温度实绩
        const int SS1_ACC_UD_QT_RT = 99;//上下流量比
        const int SS1_HT_T35 = 100;//ACC冷却速度目标
        const int SS1_COOL_RATE = 101;//ACC冷却速度实绩

        const int SS1_T40 = 112;//矩形度
        const int SS1_T41 = 113;//不平度
        const int SS1_SIZE_KND = 115;//定尺
        const int SS1_PROD_GRD = 116;//产品等级
        const int SS1_SURF_GRD = 117;//表面等级
        const int SS1_T42 = 118;//缺陷
        const int SS1_SLAB_NO1 = 119;//设计成材率
        const int SS1_SLAB_NO2 = 120;//实设成材率
        const int SS1_T43 = 121;//实际成材率
        const int SS1_YP_RST = 122;//力学性能屈服
        const int SS1_TS_RST = 123;//力学性能抗拉
        const int SS1_EL_RST = 124;//力学性能延伸率
        const int SS1_IMPACT_RST_AVE = 125;//力学性能冲击均值
        const int SS1_DWTT_YP_RST = 126;//力学性能DWTT
        const int SS1_HTM_METHOD = 127;//热处理实绩热处理方式
        const int SS1_HEAT_RATIO = 128;//热处理实绩加热速率
        const int SS1_HT_TEMP = 129;//热处理实绩加热温度
        const int SS1_UNIFORM_DT = 130;//热处理实绩保温时间
        const int SS1_COL_OUT_TEMP = 131;//热处理实绩出炉温度

        const int SS1_HT_BOT_SLAB_AIM_TEMP2 = 35;
        const int SS1_HT_BOT_SLAB_TEMP2 = 36;
        const int SS1_HT_ZONE_TIME2 = 37;

        const int SS1_FLAG = 137;
        const int SS1_EXPORT = 138;

        const int SS1_PLATE_NO = 0;

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "PI", "", "", "", imcseq, "");//1
            p_SetMc(TXT_ORD_NO, "P", "", "", "", imcseq, "");//2
            p_SetMc(TXT_ORD_ITEM, "P", "", "", "", imcseq, "");//3
            p_SetMc(TXT_CUST_CD, "P", "", "", "", imcseq, "");//4
            p_SetMc(TXT_MILL_DATE, "P", "", "", "", imcseq, "");//5
            p_SetMc(TXT_MILL_DATE_TO, "P", "", "", "", imcseq, "");//6
            p_SetMc(TXT_STDSPEC, "P", "", "", "", imcseq, "");//7
            p_SetMc(CBO_PRODGRD, "P", "", "", "", imcseq, "");//8
            p_SetMc(CBO_SURFGRD, "P", "", "", "", imcseq, "");//9
            p_SetMc(TXT_TRNS_CMPY_CD, "P", "", "", "", imcseq, "");//10
            p_SetMc(TXT_THK, "P", "", "", "", imcseq, "");//11
            p_SetMc(TXT_THK_TO, "P", "", "", "", imcseq, "");//12
            p_SetMc(TXT_WID, "P", "", "", "", imcseq, "");//13
            p_SetMc(TXT_WID_TO, "P", "", "", "", imcseq, "");//14
            p_SetMc(TXT_LEN, "P", "", "", "", imcseq, "");//15
            p_SetMc(TXT_LEN_TO, "P", "", "", "", imcseq, "");//16
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");//17

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc(TXT_SLAB_NO, "I", "", "", "", imcseq, "");//1

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            //0-86(综合)
            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("数据来源", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("钢板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("进程状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("实际长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("计划长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("原料重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("坯料来源", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("轧制钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("订单序号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("用户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("再装炉指示", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("上表", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("下表", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("驻段时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("驻段时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("温度下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("温度上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("均热时间下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("均热时间上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("加热炉作业时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("除鳞箱前路压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("除鳞箱后路压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("粗除鳞压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("精除鳞压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("出炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//56
            p_SetSc("煤气热值", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//57
            p_SetSc("炉内残氧", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//58
            p_SetSc("开始", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("终了", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
            p_SetSc("除鳞出口温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//61
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//62
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//63
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//64
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//65
            p_SetSc("粗除鳞次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//66
            p_SetSc("粗轧机轧制模式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//67
            p_SetSc("粗轧道次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//68
            p_SetSc("目标厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//69
            p_SetSc("厚度（实绩计算）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//70
            p_SetSc("宽度（平均测宽）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//71
            p_SetSc("长度（计算）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//72
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//73
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//74
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//75
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//76
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//77
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//78
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//79
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//80
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//81
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//82
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//83
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//84
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//85
            p_SetSc("精除鳞次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//86
            p_SetSc("精轧机轧制模式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//87
            p_SetSc("精轧道次数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//88
            p_SetSc("同板差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//89
            p_SetSc("目标厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//90
            p_SetSc("厚度（IMS或测量）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//91
            p_SetSc("宽度（平均测宽）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//92
            p_SetSc("长度（板型仪测量）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//93
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//94
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//95
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//96
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//97
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//98
            p_SetSc("上下流量比", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//99
            p_SetSc("目标", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//100
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//101
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//102
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//103
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//104
            p_SetSc("喷印号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//105
            p_SetSc("工艺异常标注", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//106
            p_SetSc("试样号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//107
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//108
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//109
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//110
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//111
            p_SetSc("矩形度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//112
            p_SetSc("不平度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//113
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//114
            p_SetSc("定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//115
            p_SetSc("产品等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//116
            p_SetSc("表面等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//117
            p_SetSc("缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//118
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//119
            p_SetSc("实设成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//120
            p_SetSc("实际成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//121
            p_SetSc("屈服", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//122
            p_SetSc("抗拉", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//123
            p_SetSc("延伸率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//124
            p_SetSc("冲击均值", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//125
            p_SetSc("DWTT", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//126
            p_SetSc("方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//127
            p_SetSc("加热速率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//128
            p_SetSc("加热温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//129
            p_SetSc("保温时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//130
            p_SetSc("出炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//131
            p_SetSc("轧制班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//132
            p_SetSc("剪切班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//133
            p_SetSc("粗轧操作工", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//134
            p_SetSc("精轧操作工", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//135
            p_SetSc("生产备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//136
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//137
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//138
           


            iheadrow = 0;

            p_spanSpread("板坯规格", 5, 8, iscseq, iheadrow, 1);
            p_spanSpread("订单规格", 19, 21, iscseq, iheadrow, 1);
            p_spanSpread("堆冷时间", 23, 24, iscseq, iheadrow, 1);
            p_spanSpread("入炉温度", 27, 28, iscseq, iheadrow, 1);
            p_spanSpread("预热段温度", 29, 30, iscseq, iheadrow, 1);
            p_spanSpread("加热段温度", 31, 34, iscseq, iheadrow, 1);
            p_spanSpread("加热2段温度", 35, 37, iscseq, iheadrow, 1);
            p_spanSpread("均热段", 38, 43, iscseq, iheadrow, 1);
            p_spanSpread("出炉温度", 44, 45, iscseq, iheadrow, 1);
            p_spanSpread("总加热时间", 46, 48, iscseq, iheadrow, 1);
            p_spanSpread("温度均匀性", 54, 55, iscseq, iheadrow, 1);
            p_spanSpread("处鳞压力", 59, 60, iscseq, iheadrow, 1);
            p_spanSpread("粗轧开轧温度", 62, 63, iscseq, iheadrow, 1);
            p_spanSpread("粗轧终轧温度", 64, 65, iscseq, iheadrow, 1);
            p_spanSpread("粗轧阶段结果", 69, 72, iscseq, iheadrow, 1);
            p_spanSpread("气雾冷却开冷温度", 73, 74, iscseq, iheadrow, 1);
            p_spanSpread("气雾冷却终冷温度", 75, 76, iscseq, iheadrow, 1);
            p_spanSpread("气雾冷却速度", 77, 78, iscseq, iheadrow, 1);
            p_spanSpread("精轧开轧温度", 79, 80, iscseq, iheadrow, 1);
            p_spanSpread("精轧开轧厚度比", 81, 82, iscseq, iheadrow, 1);
            p_spanSpread("精轧终轧温度", 83, 85, iscseq, iheadrow, 1);
            p_spanSpread("精轧结果", 90, 93, iscseq, iheadrow, 1);
            p_spanSpread("入水温度", 94, 96, iscseq, iheadrow, 1);
            p_spanSpread("ACC终冷温度", 97, 98, iscseq, iheadrow, 1);
            p_spanSpread("ACC冷却速度", 100, 101, iscseq, iheadrow, 1);
            p_spanSpread("返红温度", 102, 104, iscseq, iheadrow, 1);
            p_spanSpread("成品实绩尺寸", 109, 114, iscseq, iheadrow, 1);
            p_spanSpread("力学性能", 122, 126, iscseq, iheadrow, 1);
            p_spanSpread("热处理实绩", 127, 131, iscseq, iheadrow, 1);
           

        }

        private void CGT2101C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2101NC";
            Form_Define();

            TXT_MILL_DATE.RawDate = Gf_DTSet("D", "");
            TXT_MILL_DATE_TO.RawDate = Gf_DTSet("D", "");

            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_BOT_SLAB_AIM_TEMP2, true);  //modify by LiQian at 2012.09.17 加热二段无数据,不显示
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_BOT_SLAB_TEMP2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_ZONE_TIME2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SLENP, true);                       //计划长度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_CR_STAGE3_TIME, true);           //订单数量
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_NO, true);                      //订单号
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ORD_ITEM, true);                    //订单序号
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CUST_CD_CODE, true);                //用户名称
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_COOLING_TIME, true);                //堆冷时间
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CHA_UNCHA_IND, true);               //再装炉指示
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_PRE_TOP_SLAB_TEMP, true);           //预热段温度上表
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_PRE_BOT_SLAB_TEMP, true);           //预热段温度下表
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_TEMP_TEG, true);                //出炉温度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_TEMP, true);                    //出炉温度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_PDT_UNI_TEMP_TEG, true);            //温度均匀性目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_PDT_UNI_TEMP, true);                //温度均匀性目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DISCHARGE_DATE, true);              //出炉时间
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_GAS, true);                         //煤气热值
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_O2, true);                          //炉内残氧
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_MILL_END_AIM_TEMP, true);        //粗轧终轧温度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_MILL_END_AVE_TEMP, true);        //粗轧终轧温度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_CR_STAGE3_TIME, true);              //粗轧机轧制模式
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_AVE_WID, true);                  //宽度(平均测宽)
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_SLAB_MILL_LEN, true);            //长度(计算)
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ROLLING_METHOD, true);              //精轧机轧制模式
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_AIM_THK, true);                     //目标厚度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T32, true);                         //ACC冷却终冷温度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EXT_STK_TEMP, true);                //ACC冷却终冷温度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_ACC_UD_QT_RT, true);                //上下流量比
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_T35, true);                      //ACC冷却速度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_COOL_RATE, true);                   //ACC冷却速度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_TEMP1, true);                    //除鳞压力开始
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_TEMP2, true);                       //除鳞压力终了
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T1, true);                          //除鳞出口温度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T12, true);                         //气雾冷却开冷温度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T13, true);                         //气雾冷却开冷温度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T14, true);                         //气雾冷却终冷温度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T15, true);                         //气雾冷却终冷温度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T16, true);                         //气雾冷却速度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_RM_COOL_RATE, true);                //气雾冷却速度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T20, true);                         //精轧开轧厚度比目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T21, true);                         //精轧开轧厚度比实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_T35, true);                      //ACC冷却速度目标
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_COOL_RATE, true);                   //ACC冷却速度实绩
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T40, true);                         //矩形度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T41, true);                         //不平度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SIZE_KND, true);                    //定尺
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_PROD_GRD, true);                    //产品等级
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SURF_GRD, true);                    //表面等级
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T42, true);                         //缺陷
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SLAB_NO1, true);                    //设计成材率
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_SLAB_NO2, true);                    //实设成材率
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_T43, true);                         //实际成材率
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_YP_RST, true);                      //力学性能屈服
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_TS_RST, true);                      //力学性能抗拉
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_EL_RST, true);                      //力学性能延伸率
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_IMPACT_RST_AVE, true);              //力学性能冲击均值
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_DWTT_YP_RST, true);                 //力学性能DWTT
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HTM_METHOD, true);                  //热处理实绩热处理方式
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HEAT_RATIO, true);                  //热处理实绩加热速率
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_HT_TEMP, true);                     //热处理实绩加热温度
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_UNIFORM_DT, true);                  //热处理实绩保温时间
            SpreadCommon.Gp_Sp_ColHidden(ss1, SS1_COL_OUT_TEMP, true);                //热处理实绩出炉温度

            ss1.ActiveSheet.FrozenColumnCount = 2;
        }

        public override void Form_Ref()
        {

            string sFlag;
            string sexport;
            int iCount;

            if (TXT_SLAB_NO.Text.Length <= 8)
            {
                if (TXT_MILL_DATE.RawDate.Trim() == "" || TXT_MILL_DATE_TO.RawDate.Trim() == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("查询日期未输入!", "I", "系统提示信息");
                    return;
                }

                if (TXT_MILL_DATE.RawDate != TXT_MILL_DATE_TO.RawDate)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能查询一天内信息!", "I", "系统提示信息");
                    return;
                }
            }

            p_Ref(1, 1, true, true);

            {
                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {
                    sFlag = ss1.ActiveSheet.Cells[iCount - 1, SS1_FLAG].Text;
                    sexport = ss1.ActiveSheet.Cells[iCount - 1, SS1_EXPORT].Text;

                    //是否定制配送
                    if (sFlag == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount-1, iCount-1, SSP5.BackColor,Color.White);
                    }
                    //是否出口订单

                    if (sexport == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount-1, iCount-1, SSP6.BackColor, Color.White);
                    }
                }
            }

        }



        public override void Form_Pro()
        {
            p_Pro(2, 0, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;
        }

        # region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }
            if (iDateCheck == "")
            {
                return false;
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 6))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {

            if (DTCheck == "D")
            {
                DTCheck = "D";
            }
            else
            {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        //解锁指定列
        public void unlockColumn(FpSpread e, int[] columns)
        {
            FarPoint.Win.Spread.SheetView with_1 = e.ActiveSheet;

            foreach (int i in columns)
            {
                with_1.Columns[i].Locked = false;

            }
        }

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        //解锁并且保存权限并且锁定

        List<bool> spreadPer = new List<bool>();

        public void unlockSpread(FpSpread e, bool locked)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            int rowCount = e.Sheets[0].RowCount;

            if (locked)
            {
                spreadPer.Clear();

                for (int i = 0; i < columnCount; i++)
                {
                    spreadPer.Add(e.ActiveSheet.Columns[i].Locked);
                    e.ActiveSheet.Columns[i].Locked = false;
                }
            }
            if (!locked)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    e.ActiveSheet.Columns[i].Locked = spreadPer[i];
                }
            }

        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion


    }
}
