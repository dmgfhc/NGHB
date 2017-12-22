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
//-- Program Name      钢板性能查询
//-- Program ID        WGT3030C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.11.28
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.11.28       韩超        钢板性能查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT1020C : CommonClass.FORMBASE
    {
        public WGT1020C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_PLAN_PROD_WGT = 33,
                  SPD_RST_PROD_WGT = 35,
                  SPD_RST_PROD_RAT = 36,
                  SPD_SLAB_WGT = 14,
                  SPD_PLAN_PROD_RAT = 34,
                  SPD_MILLSTR_DATE = 76,
                  SPD_MILLEND_DATE = 78,
                  SPD_DUR_DATE = 79,
                  SPD_MILL_DATE = 77,
                  SPD_DISCHARGE_DATE = 73,
                  SPD_RHFMILL_DATE = 75,
                  SPD_THK_AVE = 23,
                  SPD_THK_MIN = 17,
                  SPD_THK_MAX = 16,
                  SPD_SLAB_NO = 0,
                  SPD_PROD_STATUS = 4,
                  SPD_DISCHARGE_DUR = 74;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "10", "IL", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("首件标识", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("炉座号", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("轧制模式", "E", "4", "L", "", "", "", iscseq, iheadrow,"M");//4
            p_SetSc("控轧代码", "N", "1", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("原始坯料钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//7
            p_SetSc("是否替代轧制", "E", "5", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//9
            p_SetSc("标准钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//10
            //板坯规格 厚度-重量
            p_SetSc("厚度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//14
            //轧制计划 订单厚度-目标宽度
            p_SetSc("订单厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("厚度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("厚度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("目标厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("目标宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("目标长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("订单宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//21

            
            //轧制实绩
            p_SetSc("DS厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("CL厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("OS厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("厚度是否超限", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("轧制异常", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("热卡量厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//27    
            p_SetSc("轧制宽度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("最小宽度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("最大宽度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("宽度是否超限", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("轧制长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//32

            p_SetSc("计划成品重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("计划成材率", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("实际成品重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("实际成材率", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//36
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("控轧时间(s)", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("道次数", "N", "3", "L", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("除磷后上表面测量温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("除磷后下表面测量温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//42
            p_SetSc("开轧温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//43

            //一阶段控轧
            p_SetSc("开始温度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//44
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("厚度比", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");//46
            p_SetSc("设定开轧温度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("实际开轧温度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//48
            //二阶段控轧
            p_SetSc("开始温度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//49
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("厚度比", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");//51
            p_SetSc("设定开轧温度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//52
            p_SetSc("实绩开轧温度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//53

            //终轧温度
            p_SetSc("计算值", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//54
            p_SetSc("测量值Ave", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//55
            p_SetSc("标准偏差", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//56
            p_SetSc("测量值MAX", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//57
            p_SetSc("测量值MIN", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//58


            p_SetSc("目标返红温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//59
            p_SetSc("实际返红温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//60             
            p_SetSc("板凸度（计算值）", "NUMBER(3,2)", "8", "L", "", "", "", iscseq, iheadrow, "R");//61
            p_SetSc("板凸度（测量值）", "NUMBER(3,2)", "8", "L", "", "", "", iscseq, iheadrow, "R");//62


            //头部厚度测量值
            p_SetSc("左", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//63
            p_SetSc("中", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//64
            p_SetSc("右", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//65
            //中部厚度测量值
            p_SetSc("左", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//66
            p_SetSc("中", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//67
            p_SetSc("右", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//68
            //尾部厚度测量值
            p_SetSc("左", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//69
            p_SetSc("中", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//70
            p_SetSc("右", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//71

            p_SetSc("在炉时间(分)", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//72
            p_SetSc("出炉时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "R");//73
            p_SetSc("出炉间隔(秒)", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//74
            p_SetSc("出炉待轧时间(s)", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//73
            p_SetSc("轧制开始时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "R");//74
            p_SetSc("纯轧时间(秒)", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//75
            p_SetSc("轧制结束时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "R");//76
            p_SetSc("轧制间隔(秒)", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//77
            p_SetSc("轧制订单", "E", "11", "L", "", "", "", iscseq, iheadrow, "M");//78
            p_SetSc("轧制序列", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//79
            p_SetSc("轧制公里数(m)", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "M");//80
            p_SetSc("计划钢板块数", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//81
            p_SetSc("实际钢板块数", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//82

            //软件头部计算
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//83
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//84
            p_SetSc("温度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//85
            //软件中部计算
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//86
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//87
            p_SetSc("温度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//88
            //软件尾部计算
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//89
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//90
            p_SetSc("温度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//91

            //楔型板(LP)规格
            p_SetSc("头部厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");//92
            p_SetSc("尾部厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");//93
            p_SetSc("长度1", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//94
            p_SetSc("长度2", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//95
            p_SetSc("长度3", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//96
            p_SetSc("长度4", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//97
            p_SetSc("长度5", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//98
                    
            p_SetSc("班次", "N", "1", "L", "", "", "", iscseq, iheadrow,"M");//99
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//100
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//101
            p_SetSc("是否轧废", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//102
            p_SetSc("是否缺号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//103
            p_SetSc("缺号原因", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//104
            p_SetSc("缺号描述", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//105
            p_SetSc("氧化铁皮颜色", "E", "30", "L", "", "", "", iscseq, iheadrow, "M"); //106
            p_SetSc("氧化铁皮完整性", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//107
            p_SetSc("轧制异常", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//108
            p_SetSc("热处理", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//109
            p_SetSc("取样长度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//110
            p_SetSc("配置形状", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//111




            iheadrow = 0;
            p_spanSpread("终轧温度", 54, 58, iscseq, iheadrow, 1);
            p_spanSpread("头部厚度测量值", 63, 65, iscseq, iheadrow, 1);
            p_spanSpread("中部厚度测量值", 66, 68, iscseq, iheadrow, 1);
            p_spanSpread("尾部厚度测量值", 69, 71, iscseq, iheadrow, 1);
            p_spanSpread("软件头部计算", 84, 86, iscseq, iheadrow, 1);
            p_spanSpread("软件中部计算", 87, 89, iscseq, iheadrow, 1);
            p_spanSpread("软件尾部计算", 90, 92, iscseq, iheadrow, 1);


            p_spanSpread("一阶段控轧", 43, 48, iscseq, iheadrow, 1);
            p_spanSpread("二阶段控轧", 49, 53, iscseq, iheadrow, 1);
            p_spanSpread("板坯规格", 11, 14, iscseq, iheadrow, 1);
            p_spanSpread("轧制计划", 15, 21, iscseq, iheadrow, 1);
            p_spanSpread("轧制实绩", 22, 31, iscseq, iheadrow, 1);
            p_spanSpread("楔型板(LP)规格", 93, 99, iscseq, iheadrow, 1);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGB2011C";
            Form_Define();
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            double dMillCal_Wgt = 0;
            double dMillSlab_Cnt = 0;
            double dMillPlan_Wgt = 0;
            double dMillRst_Wgt = 0;
            double dMillSlab_Wgt = 0;
            double dMillRstSlab_SumWgt = 0;
            double dThk_Ave = 0;
            double dThk_Min = 0;
            double dThk_Max = 0;
            string sValue = "";
            string sValue1 = "";
            string sValue2 = "";
            string sValue5 = "";
            string sValue6 = "";
            string sValue9 = "";
            string sValue11 = "";
            string sValue12 = "";
            string sValue13 = "";
            string dMill_date = "";
            string dMillstr_date = "";
            string dMill_dur = "";    //轧制间隔
            string dMill_dtmin = "";  //纯轧时间
            string dDischarge_date = "";
            string dRhfMill_dtmin = "";  //出炉到开轧时间


            if (ss1.ActiveSheet.RowCount < 1)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                //轧制块数
                dMillSlab_Cnt = dMillSlab_Cnt + 1;


                //计算 计划成品重量 累计
                sValue = ss1.ActiveSheet.Cells[i, SPD_PLAN_PROD_WGT].Text;
                if (sValue == "")
                {

                }
                else
                {
                    dMillPlan_Wgt = double.Parse(sValue) + dMillPlan_Wgt;
                }

                //计算 板坯重量 累计
                sValue2 = ss1.ActiveSheet.Cells[i, SPD_SLAB_WGT].Text;
                if (sValue == "")
                {

                }
                else
                {
                    dMillSlab_Wgt = double.Parse(sValue2) + dMillSlab_Wgt;
                }

                //计算 实绩成品重量 累计
                sValue1 = ss1.ActiveSheet.Cells[i, SPD_RST_PROD_WGT].Text;
                if (sValue1 == "")
                {

                }
                else
                {
                    dMillRst_Wgt = double.Parse(sValue1) + dMillRst_Wgt;
                }

                //实绩成品重量对应板坯量(累计)
                if (double.Parse(sValue1) > 0)
                {
                    dMillRstSlab_SumWgt = dMillRstSlab_SumWgt + double.Parse(sValue2);
                }

                //计划成材率
                ss1.ActiveSheet.Cells[i, SPD_PLAN_PROD_RAT].Text = (double.Parse(sValue) * 100 / double.Parse(sValue2)).ToString();

                //实绩成材率
                ss1.ActiveSheet.Cells[i, SPD_RST_PROD_RAT].Text = (double.Parse(sValue1) * 100 / double.Parse(sValue2)).ToString();


                //开轧时间    
                sValue5 = ss1.ActiveSheet.Cells[i, SPD_MILLSTR_DATE].Text;
                if (sValue5 == "")
                {

                }
                else
                {
                    dMillstr_date = sValue5;
                }

                //终轧时间
                sValue6 = ss1.ActiveSheet.Cells[i, SPD_MILLEND_DATE].Text;
                if (sValue6 == "")
                {

                }
                else
                {
                    dMill_date = sValue6;
                }

                //计算“轧制间隔(秒)”
                if (i == 0)
                {
                }
                else
                {
                    string beginItmeValue1 = ss1.ActiveSheet.Cells[i - 1, SPD_MILLEND_DATE].Text.Trim();
                    string endTimeValue1 = ss1.ActiveSheet.Cells[i, SPD_MILLSTR_DATE].Text.Trim();
                   
                   DateTime begintime = Convert.ToDateTime(beginItmeValue1);
                   DateTime endtime = Convert.ToDateTime(endTimeValue1);
                   string time1 = (endtime - begintime).TotalSeconds.ToString();
                   ss1.ActiveSheet.Cells[i, SPD_DUR_DATE].Text = time1;
                }
                // 计算“轧制间隔(秒)”结束

                //计算纯轧时间(分)
                if (dMillstr_date == "" || dMill_date == "")
                {
                    dMill_dtmin = "";
                }
                else
                {
                    //注意点
                    DateTime dt1 = Convert.ToDateTime(dMillstr_date);
                    DateTime dt2 = Convert.ToDateTime(dMill_date);
                    TimeSpan ts1 = dt2 - dt1;
                    string ss = ts1.TotalSeconds.ToString();
                    dMill_dtmin = (Math.Round(double.Parse(ss), 1)).ToString();
                }

                //纯轧时间
                ss1.ActiveSheet.Cells[i, SPD_MILL_DATE].Text = dMill_dtmin;

                //出炉时间     
                sValue9 = ss1.ActiveSheet.Cells[i, SPD_DISCHARGE_DATE].Text;
                if (sValue9 == "")
                {

                }
                else
                {
                    dDischarge_date = sValue9;
                }

                if (dMillstr_date == "" || dDischarge_date == "")
                {
                    dRhfMill_dtmin = "";
                }
                else
                {
                    TimeSpan ts1 = DateTime.Parse(dMillstr_date) - DateTime.Parse(dDischarge_date);
                    string t1 = ts1.Seconds.ToString();
                    dRhfMill_dtmin = (Math.Round(double.Parse(t1), 1)).ToString();
                }


                //计算“出炉间隔(秒)”
                if (i == 0)
                {
                }
                else
                {
                    string beginItmeValue1 = ss1.ActiveSheet.Cells[i - 1, SPD_DISCHARGE_DATE].Text.Trim();
                    string endTimeValue1 = ss1.ActiveSheet.Cells[i, SPD_DISCHARGE_DATE].Text.Trim();

                    DateTime begintime = Convert.ToDateTime(beginItmeValue1);
                    DateTime endtime = Convert.ToDateTime(endTimeValue1);
                    string time1 = (endtime - begintime).TotalSeconds.ToString();
                    ss1.ActiveSheet.Cells[i, SPD_DISCHARGE_DUR].Text = time1;
                }
                // 计算“出炉间隔(秒)”结束

                //出炉待轧时间(分)
                ss1.ActiveSheet.Cells[i, SPD_RHFMILL_DATE].Text = dRhfMill_dtmin;

                //轧制厚度
                sValue11 = ss1.ActiveSheet.Cells[i, SPD_THK_AVE].Text;
                if (sValue11 == "")
                {

                }
                else
                {
                    dThk_Ave = double.Parse(sValue11);
                }

                //厚度下限
                sValue12 = ss1.ActiveSheet.Cells[i, SPD_THK_MIN].Text;
                if (sValue12 == "")
                {

                }
                else
                {
                    dThk_Min = double.Parse(sValue12);
                }

                //厚度上限
                sValue13 = ss1.ActiveSheet.Cells[i, SPD_THK_MAX].Text;
                if (sValue13 == "")
                {

                }
                else
                {
                    dThk_Max = double.Parse(sValue13);
                }

                if (dThk_Ave < dThk_Min || dThk_Ave > dThk_Max)
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, SPD_THK_AVE, SPD_THK_AVE, i, i, Color.Black, SSP2.BackColor);
                }




                if (ss1.ActiveSheet.RowCount == i + 1)
                {
                    ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.RowCount, 1);
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_SLAB_NO].Text = "轧制块数";
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PROD_STATUS].Text = (dMillSlab_Cnt).ToString(); //累计轧制块数

                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_SLAB_WGT].Text = (dMillSlab_Wgt).ToString();//累计板坯重量

                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PLAN_PROD_WGT].Text = (Math.Round(dMillPlan_Wgt, 3)).ToString(); //累计计划成品重量

                    //累计计划成材率
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PLAN_PROD_RAT].Text = (dMillPlan_Wgt * 100 / dMillSlab_Wgt).ToString();

                    //累计实际产品重量
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_RST_PROD_WGT].Text = (dMillRst_Wgt).ToString();

                    //累计实际成材率
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_RST_PROD_RAT].Text = (dMillRst_Wgt * 100 / dMillSlab_Wgt).ToString();

                    break;
                }
            }
            SpreadCommon.Gp_Sp_ActiveCell(ss1, 1, ss1.ActiveSheet.RowCount - 1);
        }
        #endregion
    }
}