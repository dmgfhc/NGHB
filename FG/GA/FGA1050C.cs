using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;

///-------------------------------------------------------------------------------
///-- 程序头注释 +++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板热处理系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            淬火机作业实绩查询及修改界面                              
///-- 程序ID            FGA1050C
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              李超                                                    
///-- 代码              李超                                                    
///-- 代码日期          2014.07.30                                               
///-- 处理描述          淬火机作业实绩查询及修改界面
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.30        李超                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace FG
{
    public partial class FGA1050C : CommonClass.FORMBASE
    {
        public FGA1050C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_URGNT_FL = 23,
                  SPD_STA_TIME = 1,
                  SPD_END_TIME = 2,
                  SPD_STA_TEMP = 4,
                  SPD_END_TEMP = 5,
                  SPD_AVE_TEMP = 6,
                  SPD_COOL_RATIO = 7,
                  SPD_COOL_TYPE = 8,
                  SPD_PW_TIME = 9,
                  SPD_TOT_WAT = 10,
                  SPD_SPEED = 11,
                  SPD_SHIFT = 12,
                  SPD_EMP = 14,
                  SPD_CHG_NO = 19,
                  SPD_PLT = 20,
                  SPD_PRCLINE = 21;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLT, "P", "", "", "", imcseq, "");  // 工序
            p_SetMc(TXT_PRCLINE, "P", "", "", "", imcseq, "");      // 产线1
            p_SetMc(TXT_CHG_NO, "P", "", "", "", imcseq, "");        // 开始时间
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");    // 结束时间

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("开始时间", TXT_STA_TIME, "", "", "", "", "", imcseq);
            p_SetMc("结束时间", TXT_END_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("物料号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("开始时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("结束时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("热处理方法", "E", "1", "I", "", "", "", iscseq, iheadrow,"M");//3
            p_SetSc("开始温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("结束温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("平均温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("冷却速率", "N", "5,1", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("冷却模式", "N", "1", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("摆动时间", "N", "4", "I", "", "", "", iscseq, iheadrow);//9
            p_SetSc("总水耗", "N", "7,3", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("钢板运行速度", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("班次", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("班别", "E", "1", "", "", "", "", iscseq, iheadrow);//13
            p_SetSc("作业人员", "E", "8", "IL", "", "", "", iscseq, iheadrow);//14
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("宽厚", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("炉座号", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("PLT", "E", "2", "IL", "", "", "", iscseq, iheadrow,"M");//20
            p_SetSc("PRC_LINE", "E", "1", "IL", "", "", "", iscseq, iheadrow,"M");//21
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//22
            p_SetSc("A", "N", "5,3", "IL", "", "", "", iscseq, iheadrow);//23
            p_SetSc("B", "N", "5,3", "IL", "", "", "", iscseq, iheadrow);//24
            p_SetSc("C", "N", "5,3", "IL", "", "", "", iscseq, iheadrow);//25
            p_SetSc("D", "N", "5,3", "IL", "", "", "", iscseq, iheadrow);//26
            p_SetSc("E", "N", "5,3", "IL", "", "", "", iscseq, iheadrow);//27
            p_SetSc("摆动次数", "E", "4", "IL", "", "", "", iscseq, iheadrow);//28
            p_SetSc("返红温度", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//29
            p_SetSc("流量_1_1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//30
            p_SetSc("流量_1_2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//31
            p_SetSc("水比_1_1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//32
            p_SetSc("水比_1_2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//33
            p_SetSc("集管2中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//34
            p_SetSc("集管3中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//35
            p_SetSc("集管4中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//36
            p_SetSc("集管5中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//37
            p_SetSc("集管6中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//38
            p_SetSc("集管7中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//39
            p_SetSc("集管8中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//40
            p_SetSc("集管9中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//41
            p_SetSc("集管10中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//42
            p_SetSc("集管11中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//43
            p_SetSc("集管12中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//44
            p_SetSc("集管13中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//45
            p_SetSc("集管14中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//46
            p_SetSc("集管15中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//47
            p_SetSc("集管16中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//48
            p_SetSc("集管17中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//49
            p_SetSc("集管18中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//50
            p_SetSc("集管19中部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//51
            p_SetSc("集管2下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//52
            p_SetSc("集管3下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//53
            p_SetSc("集管4下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//54
            p_SetSc("集管5下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//55
            p_SetSc("集管6下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//56
            p_SetSc("集管7下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//57
            p_SetSc("集管8下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//58
            p_SetSc("集管9下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//59
            p_SetSc("集管10下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//60
            p_SetSc("集管11下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//61
            p_SetSc("集管12下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//62
            p_SetSc("集管13下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//63
            p_SetSc("集管14下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//64
            p_SetSc("集管15下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//65
            p_SetSc("集管16下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//66
            p_SetSc("集管17下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//67
            p_SetSc("集管18下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//68
            p_SetSc("集管19下流量1", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//69
            p_SetSc("集管2边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//70
            p_SetSc("集管3边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//71
            p_SetSc("集管4边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//72
            p_SetSc("集管5边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//73
            p_SetSc("集管6边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//74
            p_SetSc("集管7边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//75
            p_SetSc("集管8边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//76
            p_SetSc("集管9边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//77
            p_SetSc("集管10边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//78
            p_SetSc("集管11边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//79
            p_SetSc("集管12边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//80
            p_SetSc("集管13边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//81
            p_SetSc("集管14边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//82
            p_SetSc("集管15边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//83
            p_SetSc("集管16边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//84
            p_SetSc("集管17边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//85
            p_SetSc("集管18边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//86
            p_SetSc("集管19边部流量", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//87
            p_SetSc("集管2下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//88
            p_SetSc("集管3下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//89
            p_SetSc("集管4下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//90
            p_SetSc("集管5下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//91
            p_SetSc("集管6下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//92
            p_SetSc("集管7下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//93
            p_SetSc("集管8下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//94
            p_SetSc("集管9下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//95
            p_SetSc("集管10下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//96
            p_SetSc("集管11下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//97
            p_SetSc("集管12下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//98
            p_SetSc("集管13下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//99
            p_SetSc("集管14下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//100
            p_SetSc("集管15下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//101
            p_SetSc("集管16下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//102
            p_SetSc("集管17下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//103
            p_SetSc("集管18下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//104
            p_SetSc("集管19下流量2", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);//105

            iheadrow = 0;
            p_spanSpread("作业实绩", 4, 14, iscseq, iheadrow, 1);
            p_spanSpread("产品", 15, 18, iscseq, iheadrow, 1);

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
            SpreadCommon.Gp_Sp_ColHidden(ss1, 87, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 88, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 89, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 90, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 91, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 92, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 93, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 94, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 95, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 96, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 97, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 98, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 99, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 100, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 101, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 102, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 103, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 104, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 105, true);
        }

        private void FGA1050C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_PRCLINE.Text = "1";
            COB_SHIFT.Text = "1";
            TXT_EMP.Text = GeneralCommon.sUserID;
        }

        public override void Form_Ref()
        {
            base.Form_Ref();

            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (ss1.ActiveSheet.Cells[lRow, SPD_URGNT_FL].Text == "Y")
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow, lRow, Color.Black, Color.Green);
                }
            }
        }

        public override void Form_Pro()
        {
            if (p_pro(0, 1, true, true))
            {
                if (TXT_PLT.Text != "C2")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("工厂必须为C2!", "", "");
                }

                //for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                //{
                //    if (ss1.ActiveSheet.Cells[lRow, SPD_URGNT_FL].Text == "Y")
                //    {
                //        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow, lRow, Color.Black, Color.Green);
                //    }
                //}

                SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[1], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], true);
                if (ss1.ActiveSheet.RowCount < 1)
                {
                    return;
                }

                for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                {
                    if (ss1.ActiveSheet.Cells[lRow, SPD_URGNT_FL].Text == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow, lRow, Color.Black, Color.Green);
                    }
                }

            }  

        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }
            string ss = TXT_STA_TIME.Text;
            ss = ss.Replace(":", "");
            ss = ss.Replace("-", "");
            ss = ss.Replace(" ", "").Trim();
            string ssend = TXT_END_TIME.Text;
            ssend = ssend.Replace(":", "");
            ssend = ssend.Replace("-", "");
            ssend = ssend.Replace(" ", "").Trim();

            if (ss == "" || ssend == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认开始时间和结束时间!", "", "");
                return;
            }
            if (TXT_END_TEMP.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认结束温度....!", "", "");
                return;
            }

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text == "修改")
            {
                //SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, Color.White);
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_STA_TIME].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_END_TIME].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_STA_TEMP].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_END_TEMP].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_AVE_TEMP].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_COOL_RATIO].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_COOL_TYPE].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_PW_TIME].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_TOT_WAT].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_SPEED].Text = "";
                ss1.ActiveSheet.Cells[e.Row, SPD_SHIFT].Text = "";
            }
            else
            { 
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                //SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, Color.Cyan);

                ss1.ActiveSheet.Cells[e.Row, SPD_STA_TIME].Text = TXT_STA_TIME.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_END_TIME].Text = TXT_END_TIME.Text;
                if (TXT_STA_TEMP.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_STA_TEMP].Text = TXT_STA_TEMP.Text;
                }
                if (TXT_END_TEMP.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_END_TEMP].Text = TXT_END_TEMP.Text;
                }
                if (TXT_AVE_TEMP.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_AVE_TEMP].Text = TXT_AVE_TEMP.Text;
                }
                if (TXT_COOL_RATIO.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_COOL_RATIO].Text = TXT_COOL_RATIO.Text;
                }
                ss1.ActiveSheet.Cells[e.Row, SPD_COOL_TYPE].Text = CBO_COOL_TYPE.Text;
                if (TXT_PW_TIME.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_PW_TIME].Text = TXT_PW_TIME.Text;
                }
                if (TXT_TOT_WAT.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_TOT_WAT].Text = TXT_TOT_WAT.Text;
                }
                if (TXT_SPEED.NumValue > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_SPEED].Text = TXT_SPEED.Text;
                }
                ss1.ActiveSheet.Cells[e.Row, SPD_SHIFT].Text = COB_SHIFT.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_EMP].Text = GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[e.Row, SPD_CHG_NO].Text = TXT_CHG_NO.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_PLT].Text = TXT_PLT.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_PRCLINE].Text = TXT_PRCLINE.Text;

            }

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (ss1.ActiveSheet.Cells[lRow, SPD_URGNT_FL].Text == "Y")
                {
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, lRow, lRow, Color.Green, Color.White);
                }
            }
        }

        public override bool Form_Cls()
        {
            return base.Form_Cls();
            TXT_EMP.Text = GeneralCommon.sUserID;
            TXT_PLT.Text = "C2";
        }

        private void TXT_STA_TIME_TextChanged(object sender, EventArgs e)
        {
            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[lRow, 0].Text.Trim() == "增加" || ss1.ActiveSheet.RowHeader.Cells[lRow, 0].Text.Trim() == "修改")
                {
                    ss1.ActiveSheet.Cells[lRow, SPD_STA_TIME].Text = TXT_STA_TIME.Text;
                    ss1.ActiveSheet.Cells[lRow, SPD_SHIFT].Text = COB_SHIFT.Text;
                    ss1.ActiveSheet.Cells[lRow, SPD_EMP].Text = GeneralCommon.sUserID;
                }
            }
        }

        private void COB_SHIFT_TextChanged(object sender, EventArgs e)
        {
            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[lRow, 0].Text == "修改")
                {
                    ss1.ActiveSheet.Cells[lRow, SPD_SHIFT].Text = COB_SHIFT.Text;
                }
            }
        }

        private void TXT_SPEED_KeyUp(object sender, KeyEventArgs e)
        {
            if (TXT_SPEED.Text == "") return;
            if (TXT_SPEED.NumValue >= 100)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入2位整数!", "", "");
                TXT_SPEED.Text = "";
            }

        }

    }
}
#endregion