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
//-- Program Name      中板厂质量日报_CKP1312C
//-- Program ID        CKP1312C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.02.05
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.02.05       韩超        中板厂质量日报_CKP1312C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKP1313C : CommonClass.FORMBASE
    {
        public CKP1313C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();
        Collection Sc6 = new Collection();
        // const int SS1_SLAB_NO = 0;



        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_DATE, "PN", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("计划产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("轧制产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("原料量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("剪切产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("1#", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("2#", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("轧制废", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("单定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("双定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("设定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("综合", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("板坯切割损失量含切头", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("成本成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("改判量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("协议量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("小尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("轧废", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("原料废", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("待判率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("待判量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("待判率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("一次表判合格率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("一次合格率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("不含挽救", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("含挽救", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27

            iheadrow = 0;
            p_spanSpread("剪切块数", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("成材率", 9, 12, iscseq, iheadrow, 1);
            p_spanSpread("不合格量", 15, 19, iscseq, iheadrow, 1);
            p_spanSpread("待判块数", 20, 21, iscseq, iheadrow, 1);
            p_spanSpread("待判重量", 22, 23, iscseq, iheadrow, 1);
            p_spanSpread("非计划率", 26, 27, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("本部", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("港南", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("累计吨钢消耗", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("累计吨钢消耗", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("累计吨钢消耗", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
           

            iheadrow = 0;
            p_spanSpread("当日煤气消耗", 0, 2, iscseq, iheadrow, 1);
            p_spanSpread("累计煤气消耗", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("当日电消耗", 6, 8, iscseq, iheadrow, 1);
            p_spanSpread("累计电消耗", 9, 11, iscseq, iheadrow, 1);
            p_spanSpread("当日水消耗", 12, 14, iscseq, iheadrow, 1);
            p_spanSpread("累计水消耗", 15, 17, iscseq, iheadrow, 1);
            p_spanSpread("热处理燃耗", 18, 19, iscseq, iheadrow, 1);
            p_spanSpread("热处理电耗", 20, 21, iscseq, iheadrow, 1);
            p_spanSpread("蒸汽回收量", 22, 24, iscseq, iheadrow, 1);
            p_spanSpread("管道氧气", 25, 27, iscseq, iheadrow, 1);
            p_spanSpread("氮气", 28, 30, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, false);
            iheadrow = 1;
            iscseq = 3;

            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            

            iheadrow = 0;
            p_spanSpread("在线改判量", 0, 1, iscseq, iheadrow, 1);//0
            p_spanSpread("切割改判量", 2, 3, iscseq, iheadrow, 1);//1
            p_spanSpread("探伤改判量", 4, 5, iscseq, iheadrow, 1);//2
            p_spanSpread("总计", 6, 7, iscseq, iheadrow, 1);//3
            p_spanSpread("热轧原因", 8, 9, iscseq, iheadrow, 1);//4
            p_spanSpread("精整原因", 10, 11, iscseq, iheadrow, 1);//5
            p_spanSpread("产品原因", 12, 13, iscseq, iheadrow, 1);//6
            p_spanSpread("设备原因", 14, 15, iscseq, iheadrow, 1);//7
            p_spanSpread("表面麻坑", 16, 17, iscseq, iheadrow, 1);//8
            p_spanSpread("重皮凹坑", 18, 19, iscseq, iheadrow, 1);//9
            p_spanSpread("飘曲", 20, 21, iscseq, iheadrow, 1);//10
            p_spanSpread("尺寸", 22, 23, iscseq, iheadrow, 1);//11
            p_spanSpread("划伤", 24, 25, iscseq, iheadrow, 1);//12
            p_spanSpread("剪切", 26, 27, iscseq, iheadrow, 1);//13
            p_spanSpread("坯料", 28, 29, iscseq, iheadrow, 1);//14
           
            p_ScIni(ss4, Sc4, 0, false, false);
            iheadrow = 1;
            iscseq = 4;

            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29


            iheadrow = 0;
            p_spanSpread("在线改判率", 0, 1, iscseq, iheadrow, 1);//0
            p_spanSpread("切割改判率", 2, 3, iscseq, iheadrow, 1);//1
            p_spanSpread("探伤改判率", 4, 5, iscseq, iheadrow, 1);//2
            p_spanSpread("全厂", 6, 7, iscseq, iheadrow, 1);//3
            p_spanSpread("热轧原因", 8, 9, iscseq, iheadrow, 1);//4
            p_spanSpread("精整原因", 10, 11, iscseq, iheadrow, 1);//5
            p_spanSpread("产品原因", 12, 13, iscseq, iheadrow, 1);//6
            p_spanSpread("设备原因", 14, 15, iscseq, iheadrow, 1);//7
            p_spanSpread("麻面麻坑", 16, 17, iscseq, iheadrow, 1);//8
            p_spanSpread("重皮凹坑", 18, 19, iscseq, iheadrow, 1);//9
            p_spanSpread("飘曲", 20, 21, iscseq, iheadrow, 1);//10
            p_spanSpread("尺寸", 22, 23, iscseq, iheadrow, 1);//11
            p_spanSpread("划伤", 24, 25, iscseq, iheadrow, 1);//12
            p_spanSpread("剪切", 26, 27, iscseq, iheadrow, 1);//13
            p_spanSpread("坯料", 28, 29, iscseq, iheadrow, 1);//14

            p_ScIni(ss5, Sc5, 0, false, false);
            iheadrow = 1;
            iscseq = 5;

            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29


            iheadrow = 0;
            p_spanSpread("本部挽救成功块数", 0, 1, iscseq, iheadrow, 1);//0
            p_spanSpread("港南挽救成功块数", 2, 3, iscseq, iheadrow, 1);//1
            p_spanSpread("全厂挽救成功块数", 4, 5, iscseq, iheadrow, 1);//2
            p_spanSpread("本部挽救成功量(重量)", 6, 7, iscseq, iheadrow, 1);//3
            p_spanSpread("港南挽救成功量(重量)", 8, 9, iscseq, iheadrow, 1);//4
            p_spanSpread("全厂挽救成功量(重量)", 10, 11, iscseq, iheadrow, 1);//5
            p_spanSpread("本部挽救成功率(重量)", 12, 13, iscseq, iheadrow, 1);//6
            p_spanSpread("港南挽救成功率(重量)", 14, 15, iscseq, iheadrow, 1);//7
            p_spanSpread("全厂挽救成功率(重量)", 16, 17, iscseq, iheadrow, 1);//8
            p_spanSpread("本部替代量(ZB)", 18, 19, iscseq, iheadrow, 1);//9
            p_spanSpread("本部替损失(ZB)", 20, 21, iscseq, iheadrow, 1);//10
            p_spanSpread("港南替代量(WG)", 22, 23, iscseq, iheadrow, 1);//11
            p_spanSpread("港南替代损失(WG)", 24, 25, iscseq, iheadrow, 1);//12
            p_spanSpread("合计替代量", 26, 27, iscseq, iheadrow, 1);//13
            p_spanSpread("合计替代损失", 28, 29, iscseq, iheadrow, 1);//14

            p_ScIni(ss6, Sc6, 0, false, false);
            iheadrow = 1;
            iscseq = 6;

            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23

            iheadrow = 0;
            p_spanSpread("飘曲发生本部(块数)", 0, 1, iscseq, iheadrow, 1);//0
            p_spanSpread("飘曲发生本部(重量)", 2, 3, iscseq, iheadrow, 1);//1
            p_spanSpread("本部飘曲发生率", 4, 5, iscseq, iheadrow, 1);//2
            p_spanSpread("港南(块数)", 6, 7, iscseq, iheadrow, 1);//3
            p_spanSpread("港南(重量)", 8, 9, iscseq, iheadrow, 1);//4
            p_spanSpread("港南飘曲发生率", 10, 11, iscseq, iheadrow, 1);//5
            p_spanSpread("全厂(块数)", 12, 13, iscseq, iheadrow, 1);//6
            p_spanSpread("全厂(重量)", 14, 15, iscseq, iheadrow, 1);//7
            p_spanSpread("全厂飘曲发生率", 16, 17, iscseq, iheadrow, 1);//8
            p_spanSpread("飘曲挽救(块数)", 18, 19, iscseq, iheadrow, 1);//9
            p_spanSpread("飘曲挽救(重量)", 20, 21, iscseq, iheadrow, 1);//10
            p_spanSpread("挽救成功率(重量)", 22, 23, iscseq, iheadrow, 1);//11
        }

        private void CKP1313C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKP1313NC";
            Form_Define();
            txt_DATE.RawDate = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            rowSet();

            //GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList2.Images[9];
            //GeneralCommon.MDIToolBar.Buttons[13].Tag = "F";
            //GeneralCommon.MDIToolBar.Buttons[13].Enabled = true;
            //GeneralCommon.MDIToolBar.Refresh();

            //GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList1.Images[9];//     'Excel
            //GeneralCommon.MDIToolBar.Buttons[13].Tag = "T";
            //GeneralCommon.MDIToolBar.Refresh();


            GeneralCommon.Gp_FormMenuSetting(FormType, "RE", sAuthority);


        }

        //初始化表单
        private void rowSet()
        {
            ss1.ActiveSheet.RowCount = 10;
            ss1.ActiveSheet.RowHeader.ColumnCount = 2;//设置两行
            ss1.ActiveSheet.RowHeader.Cells[0, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss1.ActiveSheet.RowHeader.Cells[0, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[1, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[2, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[2, 0].Text = "乙";
            ss1.ActiveSheet.RowHeader.Cells[2, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[3, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[4, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[4, 0].Text = "丙";
            ss1.ActiveSheet.RowHeader.Cells[4, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[5, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[6, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[6, 0].Text = "丁";
            ss1.ActiveSheet.RowHeader.Cells[6, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[7, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[8, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[8, 0].Text = "合计";
            ss1.ActiveSheet.RowHeader.Cells[8, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[9, 1].Text = "累计";

            ss2.ActiveSheet.RowCount = 5;
            ss2.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss2.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss2.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss2.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss2.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";

            ss3.ActiveSheet.RowCount = 5;
            ss3.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss3.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss3.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss3.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss3.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";

            ss4.ActiveSheet.RowCount = 5;
            ss4.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss4.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss4.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss4.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss4.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";

            ss5.ActiveSheet.RowCount = 5;
            ss5.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss5.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss5.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss5.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss5.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";

            ss6.ActiveSheet.RowCount = 5;
            ss6.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss6.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss6.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss6.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss6.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";



        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_DATE.RawDate = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");

            return true;

        }

        public override void Form_Ref()
        {
            if (Gf_Sp_Display(GeneralCommon.M_CN1, ss1, MasterCommon.Gf_Ms_MakeQuery((string)(Sc1["P-R"]), "R", (Collection)Mc1["pControl"]), (Collection)Sc1["pColumn"], false))
            {
                Gf_Sp_Display2(GeneralCommon.M_CN1, ss2, MasterCommon.Gf_Ms_MakeQuery((string)(Sc2["P-R"]), "R", (Collection)Mc1["pControl"]), (Collection)Sc2["pColumn"], false);
                Gf_Sp_Display2(GeneralCommon.M_CN1, ss3, MasterCommon.Gf_Ms_MakeQuery((string)(Sc3["P-R"]), "R", (Collection)Mc1["pControl"]), (Collection)Sc3["pColumn"], false);
            }
        }

        public override void Form_Pro()
        {

            //保存功能未使用 暂不使用代码
            //string sQuery;
            //string sComments;
            //string sDate;

            //sComments = ss3.ActiveSheet.Cells[48,1].Text;
            //if (txt_DATE.RawDate.Length != 8)
            //{
            //    return;
            //}
            //sDate = txt_DATE.RawDate;

            //sQuery = "";
            //sQuery = "         UPDATE  gp_zbrpt_mon                                 ";
            //sQuery = sQuery + "   SET  COMMENT1         = '" + sComments + "'       ";
            //sQuery = sQuery + " WHERE  PLT              = 'C3'                      ";
            //sQuery = sQuery + "   AND  PROD_DATE        = '" + sDate + "'           ";

            //GeneralCommon.Gf_ExecSql(GeneralCommon.M_CN1, sQuery);

        }

        public bool Gf_Sp_Display(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
        {
            bool returnValue = false;

            int iCount;
            int iRowCount;
            int iColcount;

            object[,] ArrayRecords;
            ADODB.Recordset AdoRs;
            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return false;
                }
            }

            AdoRs = new ADODB.Recordset();
            try
            {
                returnValue = true;

                //if (oSpread.ActiveSheet.RowCount > 0)
                //{
                //    //
                //    //'Hux,修改。
                //    //'解决:Spread有两条数据时，点击列头排序后，再点击Spread插入，Spread行清除时报错。
                //    oSpread.ActiveSheet.AutoSortColumn(0);
                //    oSpread.ActiveSheet.RowCount = 0;
                //}

                //FarPoint.Win.Spread.FpSpread with_1 = oSpread;

                iCount = 0;

                Cursor.Current = Cursors.WaitCursor;
                /////////20130606begin解决保存失败后，第一次查询提示算数运算符溢出的问题
                AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                AdoRs.CursorType = ADODB.CursorTypeEnum.adOpenStatic;
                //AdoRs.CursorType = 
                //AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseServer;


                //AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, 1);
                AdoRs.Open(sQuery, Conn);
                /////////20130606end


                if (AdoRs.BOF || AdoRs.EOF)
                {

                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料..!!!", "I", "");
                    }

                    returnValue = false;
                    AdoRs.Close();
                    AdoRs = null;

                    Cursor.Current = Cursors.Default;
                    return returnValue;

                }

                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;

                //此处进行表单数据录入

                int ROW = 0;
                if (ArrayRecords.GetLength(0) != 0)
                {
                    for (iRowCount = 0; iRowCount < ArrayRecords.GetLength(0); iRowCount++)
                    {
                        switch (ArrayRecords[iRowCount, 0].ToString().Trim())
                        {
                            case "A0":
                                ROW = 0;
                                break;
                            case "A1":
                                ROW = 1;
                                break;
                            case "B0":
                                ROW = 2;
                                break;
                            case "B1":
                                ROW = 3;
                                break;
                            case "C0":
                                ROW = 4;
                                break;
                            case "C1":
                                ROW = 5;
                                break;
                            case "D0":
                                ROW = 6;
                                break;
                            case "D1":
                                ROW = 7;
                                break;
                            case "T0":
                                ROW = 8;
                                break;
                            case "T1":
                                ROW = 9;
                                break;
                        }

                        for (iColcount = 1; iColcount <= oSpread.ActiveSheet.ColumnCount; iColcount++)
                        {

                            if (ArrayRecords[iRowCount, iColcount].ToString() == "" || ArrayRecords[iRowCount, iColcount].ToString() == "0")
                            {
                                oSpread.ActiveSheet.Cells[ROW, iColcount - 1].Text = "";
                            }
                            else
                            {
                                oSpread.ActiveSheet.Cells[ROW, iColcount - 1].Text = ArrayRecords[iRowCount, iColcount].ToString();
                            }
                        }

                    }

                }
                Cursor.Current = Cursors.Default;
                ArrayRecords = null;

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Sp_Display Error : " + ex.Message), "", "");
                Cursor.Current = Cursors.Default;
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }
            }

            return returnValue;
        }

        public bool Gf_Sp_Display2(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
        {
            bool returnValue = false;

            int iCount;
            int iRowCount;
            int iColcount;
            object[,] ArrayRecords;
            ADODB.Recordset AdoRs;
            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return false;
                }
            }

            AdoRs = new ADODB.Recordset();
            try
            {
                returnValue = true;

                //if (oSpread.ActiveSheet.RowCount > 0)
                //{
                //    //
                //    //'Hux,修改。
                //    //'解决:Spread有两条数据时，点击列头排序后，再点击Spread插入，Spread行清除时报错。
                //    oSpread.ActiveSheet.AutoSortColumn(0);
                //    oSpread.ActiveSheet.RowCount = 0;
                //}

                //FarPoint.Win.Spread.FpSpread with_1 = oSpread;

                iCount = 0;

                Cursor.Current = Cursors.WaitCursor;
                /////////20130606begin解决保存失败后，第一次查询提示算数运算符溢出的问题
                AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                AdoRs.CursorType = ADODB.CursorTypeEnum.adOpenStatic;
                //AdoRs.CursorType = 
                //AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseServer;


                //AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, 1);
                AdoRs.Open(sQuery, Conn);
                /////////20130606end


                if (AdoRs.BOF || AdoRs.EOF)
                {

                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料..!!!", "I", "");
                    }

                    returnValue = false;
                    AdoRs.Close();
                    AdoRs = null;

                    Cursor.Current = Cursors.Default;
                    return returnValue;

                }

                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;

                //此处进行表单数据录入

                int ROW = 0;
                if (ArrayRecords.GetLength(0) != 0)
                {
                    for (iRowCount = 0; iRowCount < ArrayRecords.GetLength(0); iRowCount++)
                    {
                        switch (substr(ArrayRecords[iRowCount, 0].ToString(), 0, 1))
                        {
                            case "A":
                                ROW = 0;
                                break;
                            case "B":
                                ROW = 1;
                                break;
                            case "C":
                                ROW = 2;
                                break;
                            case "D":
                                ROW = 3;
                                break;
                            case "T":
                                ROW = 4;
                                break;
                        }

                        int Col = 0;
                        for (iColcount = 1; iColcount <= oSpread.ActiveSheet.ColumnCount/2; iColcount++)
                        {

                            if (substr(ArrayRecords[iRowCount, 0].ToString(), 1, 1) == "0")
                            {
                                Col = (iColcount - 1) * 2;    //偶数列 
                            }
                            else if (substr(ArrayRecords[iRowCount, 0].ToString(), 1, 1) == "1")
                            {
                                Col = (iColcount - 1) * 2 + 1;    //奇数列
                            }

                            if (ArrayRecords[iRowCount, iColcount].ToString() == "" || ArrayRecords[iRowCount, iColcount].ToString() == "0")
                            {
                                oSpread.ActiveSheet.Cells[ROW, Col].Text = "";
                            }
                            else
                            {
                                oSpread.ActiveSheet.Cells[ROW, Col].Text = ArrayRecords[iRowCount, iColcount].ToString();
                            }

                        }

                    }
                }
                Cursor.Current = Cursors.Default;
                ArrayRecords = null;

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Sp_Display2 Error : " + ex.Message), "", "");
                Cursor.Current = Cursors.Default;
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }
            }

            return returnValue;
        }

        public bool Gf_Sp_Display3(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
        {
            bool returnValue = false;

            int iCount;
            int iRowCount;
            int iColcount;
            object[,] ArrayRecords;
            ADODB.Recordset AdoRs;
            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return false;
                }
            }

            AdoRs = new ADODB.Recordset();
            try
            {
                returnValue = true;

                //if (oSpread.ActiveSheet.RowCount > 0)
                //{
                //    //
                //    //'Hux,修改。
                //    //'解决:Spread有两条数据时，点击列头排序后，再点击Spread插入，Spread行清除时报错。
                //    oSpread.ActiveSheet.AutoSortColumn(0);
                //    oSpread.ActiveSheet.RowCount = 0;
                //}

                //FarPoint.Win.Spread.FpSpread with_1 = oSpread;

                iCount = 0;

                Cursor.Current = Cursors.WaitCursor;
                /////////20130606begin解决保存失败后，第一次查询提示算数运算符溢出的问题
                AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                AdoRs.CursorType = ADODB.CursorTypeEnum.adOpenStatic;
                //AdoRs.CursorType = 
                //AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseServer;


                //AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, 1);
                AdoRs.Open(sQuery, Conn);
                /////////20130606end


                if (AdoRs.BOF || AdoRs.EOF)
                {

                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料..!!!", "I", "");
                    }

                    returnValue = false;
                    AdoRs.Close();
                    AdoRs = null;

                    Cursor.Current = Cursors.Default;
                    return returnValue;

                }

                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;

                //此处进行表单数据录入

                int ROW = 0;
                if (ArrayRecords.GetLength(0) != 0)
                {
                    for (iRowCount = 0; iRowCount < ArrayRecords.GetLength(0); iRowCount++)
                    {
                        ROW = 0;
                        int Col = 0;
                        for (iColcount = 1; iColcount <= 9; iColcount++)
                        {

                            if (ArrayRecords[iRowCount, 0].ToString().Trim() == "T0")
                            {
                                Col = (iColcount - 1) * 2;    //偶数列 
                            }
                            else if (ArrayRecords[iRowCount, 0].ToString().Trim() == "T1")
                            {
                                Col = (iColcount - 1) * 2 + 1;    //奇数列
                            }

                            if (ArrayRecords[iRowCount, iColcount].ToString() == "" || ArrayRecords[iRowCount, iColcount].ToString() == "0")
                            {
                                oSpread.ActiveSheet.Cells[ROW, Col].Text = "";
                            }
                            else
                            {
                                oSpread.ActiveSheet.Cells[ROW, Col].Text = ArrayRecords[iRowCount, iColcount].ToString();
                            }

                        }

                    }
                }
                Cursor.Current = Cursors.Default;
                ArrayRecords = null;

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Sp_Display3 Error : " + ex.Message), "", "");
                Cursor.Current = Cursors.Default;
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }
            }

            return returnValue;
        }

        public override void Spread_Exc()
        {
            try
            {
                setExcel();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("导出数据错误...!!" + ex.Message, "W", "警告");
            }
        }

        private void setExcel()
        {
            if (ss1.ActiveSheet.RowCount <= 0) return;
            string modelName = "CKP1312C.xls";
            GeneralCommon.Gp_CopyModel(modelName);
            string fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + "report" + "\\" + modelName;
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            Microsoft.Office.Interop.Excel.Range range = null;

            appExcel.Cells[2, 1] = "报表日期：" + txt_DATE.RawDate.Substring(0, 4) + "年" + txt_DATE.RawDate.Substring(4, 2) + "月" + txt_DATE.RawDate.Substring(6, 2) + "日";
            appExcel.Cells[40, 2] = "制表日期: " + DateTime.Now.ToString("yyyy") + "年" + DateTime.Now.ToString("MM") + "月" + DateTime.Now.ToString("dd") + "日";
            appExcel.Cells[40, 17] = "制表人：" + GeneralCommon.sUserID;

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[6 + i, 3] = ss1.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[6 + i, 4] = ss1.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[6 + i, 5] = ss1.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[6 + i, 6] = ss1.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[6 + i, 7] = ss1.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[6 + i, 8] = ss1.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[6 + i, 9] = ss1.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[6 + i, 10] = ss1.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[6 + i, 11] = ss1.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[6 + i, 12] = ss1.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[6 + i, 13] = ss1.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[6 + i, 14] = ss1.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[6 + i, 15] = ss1.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[6 + i, 16] = ss1.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[6 + i, 17] = ss1.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[6 + i, 18] = ss1.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[6 + i, 19] = ss1.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[6 + i, 20] = ss1.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[6 + i, 21] = ss1.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[6 + i, 22] = ss1.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[6 + i, 23] = ss1.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[6 + i, 24] = ss1.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[6 + i, 25] = ss1.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[6 + i, 26] = ss1.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[6 + i, 27] = ss1.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[6 + i, 28] = ss1.ActiveSheet.Cells[i, 25].Text;
                appExcel.Cells[6 + i, 29] = ss1.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[6 + i, 30] = ss1.ActiveSheet.Cells[i, 27].Text;
            }

            for (int i = 0; i < ss2.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[18 + i, 2] = ss2.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[18 + i, 3] = ss2.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[18 + i, 4] = ss2.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[18 + i, 5] = ss2.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[18 + i, 6] = ss2.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[18 + i, 7] = ss2.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[18 + i, 8] = ss2.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[18 + i, 9] = ss2.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[18 + i, 10] = ss2.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[18 + i, 11] = ss2.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[18 + i, 12] = ss2.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[18 + i, 13] = ss2.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[18 + i, 14] = ss2.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[18 + i, 15] = ss2.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[18 + i, 16] = ss2.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[18 + i, 17] = ss2.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[18 + i, 18] = ss2.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[18 + i, 19] = ss2.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[18 + i, 20] = ss2.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[18 + i, 21] = ss2.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[18 + i, 22] = ss2.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[18 + i, 23] = ss2.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[18 + i, 24] = ss2.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[18 + i, 25] = ss2.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[18 + i, 26] = ss2.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[18 + i, 27] = ss2.ActiveSheet.Cells[i, 25].Text;
                appExcel.Cells[18 + i, 28] = ss2.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[18 + i, 29] = ss2.ActiveSheet.Cells[i, 27].Text;
                appExcel.Cells[18 + i, 30] = ss2.ActiveSheet.Cells[i, 28].Text;
                appExcel.Cells[18 + i, 31] = ss2.ActiveSheet.Cells[i, 29].Text;
                appExcel.Cells[18 + i, 32] = ss2.ActiveSheet.Cells[i, 30].Text;
            }

            for (int i = 0; i < ss3.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[25 + i, 2] = ss3.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[25 + i, 3] = ss3.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[25 + i, 4] = ss3.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[25 + i, 5] = ss3.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[25 + i, 6] = ss3.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[25 + i, 7] = ss3.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[25 + i, 8] = ss3.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[25 + i, 9] = ss3.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[25 + i, 10] = ss3.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[25 + i, 11] = ss3.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[25 + i, 12] = ss3.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[25 + i, 13] = ss3.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[25 + i, 14] = ss3.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[25 + i, 15] = ss3.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[25 + i, 16] = ss3.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[25 + i, 17] = ss3.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[25 + i, 18] = ss3.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[25 + i, 19] = ss3.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[25 + i, 20] = ss3.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[25 + i, 21] = ss3.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[25 + i, 22] = ss3.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[25 + i, 23] = ss3.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[25 + i, 24] = ss3.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[25 + i, 25] = ss3.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[25 + i, 26] = ss3.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[25 + i, 27] = ss3.ActiveSheet.Cells[i, 25].Text;
                appExcel.Cells[25 + i, 28] = ss3.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[25 + i, 29] = ss3.ActiveSheet.Cells[i, 27].Text;
                appExcel.Cells[25 + i, 30] = ss3.ActiveSheet.Cells[i, 28].Text;
                appExcel.Cells[25 + i, 31] = ss3.ActiveSheet.Cells[i, 29].Text;

            }

            for (int i = 0; i < ss4.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[32 + i, 2] = ss4.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[32 + i, 3] = ss4.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[32 + i, 4] = ss4.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[32 + i, 5] = ss4.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[32 + i, 6] = ss4.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[32 + i, 7] = ss4.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[32 + i, 8] = ss4.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[32 + i, 9] = ss4.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[32 + i, 10] = ss4.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[32 + i, 11] = ss4.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[32 + i, 12] = ss4.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[32 + i, 13] = ss4.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[32 + i, 14] = ss4.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[32 + i, 15] = ss4.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[32 + i, 16] = ss4.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[32 + i, 17] = ss4.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[32 + i, 18] = ss4.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[32 + i, 19] = ss4.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[32 + i, 20] = ss4.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[32 + i, 21] = ss4.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[32 + i, 22] = ss4.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[32 + i, 23] = ss4.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[32 + i, 24] = ss4.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[32 + i, 25] = ss4.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[32 + i, 26] = ss4.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[32 + i, 27] = ss4.ActiveSheet.Cells[i, 25].Text;
                appExcel.Cells[32 + i, 28] = ss4.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[32 + i, 29] = ss4.ActiveSheet.Cells[i, 27].Text;
                appExcel.Cells[32 + i, 30] = ss4.ActiveSheet.Cells[i, 28].Text;
                appExcel.Cells[32 + i, 31] = ss4.ActiveSheet.Cells[i, 29].Text;

            }

            for (int i = 0; i < ss5.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[39 + i, 2] = ss5.ActiveSheet.Cells[i, 0].Text;
                appExcel.Cells[39 + i, 3] = ss5.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[39 + i, 4] = ss5.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[39 + i, 5] = ss5.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[39 + i, 6] = ss5.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[39 + i, 7] = ss5.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[39 + i, 8] = ss5.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[39 + i, 9] = ss5.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[39 + i, 10] = ss5.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[39 + i, 11] = ss5.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[39 + i, 12] = ss5.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[39 + i, 13] = ss5.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[39 + i, 14] = ss5.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[39 + i, 15] = ss5.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[39 + i, 16] = ss5.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[39 + i, 17] = ss5.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[39 + i, 18] = ss5.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[39 + i, 19] = ss5.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[39 + i, 20] = ss5.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[39 + i, 21] = ss5.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[39 + i, 22] = ss5.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[39 + i, 23] = ss5.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[39 + i, 24] = ss5.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[39 + i, 25] = ss5.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[39 + i, 26] = ss5.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[39 + i, 27] = ss5.ActiveSheet.Cells[i, 25].Text;
                appExcel.Cells[39 + i, 28] = ss5.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[39 + i, 29] = ss5.ActiveSheet.Cells[i, 27].Text;
                appExcel.Cells[39 + i, 30] = ss5.ActiveSheet.Cells[i, 28].Text;
                appExcel.Cells[39 + i, 31] = ss5.ActiveSheet.Cells[i, 29].Text;

            }

            appExcel.Visible = true;
            appExcel = null;

        }




        # region 公共方法

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
                try
                {
                    return Convert.ToDouble(value);
                }
                catch
                {
                    return 1;
                }
            }
            return 0;
        }
        public double convertD(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
            }
            return 0;
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

        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            string sDate;

            if (txt_DATE.RawDate == "")
            {
                sDate = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            }
            else
            {
                sDate = txt_DATE.RawDate;
            }

            string[] Para1 = new string[1];

            Para1[0] = sDate;


            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CKP1312NP", Para1))
            {

                GeneralCommon.Gp_MsgBoxDisplay("更新成功", "I", "系统提示信息");
                Form_Ref();

            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("更新失败", "I", "系统提示信息");
            }
        }

    }
}
