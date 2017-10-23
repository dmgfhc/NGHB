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
//-- Program Name      加热炉实绩查询界面
//-- Program ID        WGT1010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.11.13
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2012.11.13       李超        加热炉实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2000C : CommonClass.FORMBASE
    {
        public CGT2000C()
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
            p_SetMc(CBO_PRC_LINE, "P", "", "", "", imcseq, "");
            p_SetMc(txt_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_CH_CD, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("首件标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("布料方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("轧制钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("计划板坯长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("板坯重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("板坯浇铸时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("入库时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("装炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("板坯来源", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("出炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("出炉间隔", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("在炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("出炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("温度均匀性", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("计划成品厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("订单/余材", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("堆冷时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("实设成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("成材率差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("是否定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("计划编制时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("订单数量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("是否紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("订单探伤要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("加热段驻段时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("均热段驻段时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("交货期结束", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("宽度差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//56
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//57
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//58
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//60
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//61
            p_SetSc("除鳞箱前路压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//62
            p_SetSc("除鳞箱厚度压力", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//63
            p_SetSc("粗除鳞道次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//64
            p_SetSc("下限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//65
            p_SetSc("上限", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//66
            p_SetSc("实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//67

            iheadrow = 0;
            p_spanSpread("预热区", 40, 42, iscseq, iheadrow, 1);
            p_spanSpread("加热1区", 43, 45, iscseq, iheadrow, 1);
            p_spanSpread("加热2区", 46, 48, iscseq, iheadrow, 1);
            p_spanSpread("加热3区", 49, 51, iscseq, iheadrow, 1);
            p_spanSpread("均热区", 52,54, iscseq, iheadrow, 1);
            p_spanSpread("轧制计划", 62, 64, iscseq, iheadrow, 1);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGT1010C";
            Form_Define();
            OPT_CH.Checked = true;
        }      
        
        #endregion

        //装炉
        private void OPT_CH_Click(object sender, EventArgs e)
        {
            //base.Form_Cls();

            ss1.ActiveSheet.RowCount = 0;

            //SpreadCommon.Gp_Sp_ColHidden(ss1,3,true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1,5,true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1,9,true);

          //  ss1.ActiveSheet.ColumnHeader.Cells[0,8].Text = "装炉时间";

            if (OPT_CH.Checked)
            {
                OPT_CH.ForeColor = Color.Red;
                OPT_DISCH.ForeColor = Color.Black;
                OPT_REJECT.ForeColor = Color.Black;
                TXT_CH_CD.Text = "C";
            }
            else
                OPT_CH.ForeColor = Color.Black;
        }

        //出炉
        private void OPT_DISCH_Click(object sender, EventArgs e)
        {
            //base.Form_Cls();

            ss1.ActiveSheet.RowCount = 0;

          //  ss1.ActiveSheet.ColumnHeader.Cells[0,8].Text = "装炉时间";

            if (OPT_DISCH.Checked)
            {
                OPT_DISCH.ForeColor = Color.Red;
                OPT_CH.ForeColor = Color.Black;
                OPT_REJECT.ForeColor = Color.Black;
                TXT_CH_CD.Text = "D";
            }
            else
                OPT_DISCH.ForeColor = Color.Black;
        }

        //缺号
        private void OPT_REJECT_Click(object sender, EventArgs e)
        {
            //base.Form_Cls();

            ss1.ActiveSheet.RowCount = 0;
           
           // ss1.ActiveSheet.ColumnHeader.Cells[0,8].Text= "缺号发生时间";

            if (OPT_REJECT.Checked)
            {
                OPT_REJECT.ForeColor = Color.Red;
                OPT_CH.ForeColor = Color.Black;
                OPT_DISCH.ForeColor = Color.Black;
                TXT_CH_CD.Text = "R";
            }
            else
                OPT_REJECT.ForeColor = Color.Black;
        }

    }
}
