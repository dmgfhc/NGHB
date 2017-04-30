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
    public partial class WGT1010C : CommonClass.FORMBASE
    {
        public WGT1010C()
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
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");
            p_SetMc("生产时间",SDT_PROD_DATE_FROM, "PN", "", "", "","", imcseq);
            p_SetMc("生产时间",SDT_PROD_DATE_TO, "PN", "", "", "","", imcseq);
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_CH_CD, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_PROC_LINE, "P", "", "", "", imcseq, "");
            p_SetMc("缺号代码",f4ETCR1, "P", "", "", "", imcseq,"");

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            //0-34
            p_SetSc("板坯号", "E", "10", "IL", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("首件标识", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("板坯类型", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("炉座号", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("布料方式", "N", "1", "L", "", "", "", iscseq, iheadrow,"M");//3 隐藏
            p_SetSc("头尾坯标记", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//4 
            p_SetSc("是否走真空", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//5 
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("修磨指示", "E", "20", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("修磨实绩", "E", "20", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("原始坯料钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//10
            p_SetSc("是否替代轧制", "E", "5", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//11 隐藏
            p_SetSc("板坯规格", "E", "27", "L", "", "", "", iscseq, iheadrow,"M");//12
            p_SetSc("板坯重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow,"R");//13
            p_SetSc("试样备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("尺寸备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("打包备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("装炉时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//18
            p_SetSc("出炉时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//19 隐藏
            p_SetSc("在炉时间", "N", "16", "L", "", "", "", iscseq, iheadrow,"R");//20隐藏
            p_SetSc("装炉温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//21 隐藏
            p_SetSc("出炉温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//22 隐藏
            p_SetSc("温度均匀性", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//23
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("计划成品厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("测量宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//
            p_SetSc("测量长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow,"R");//
            p_SetSc("同板差", "N", "3,2", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("下限厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//28 20150108
            p_SetSc("上限厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//29 20150108
            p_SetSc("计划成品长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//30 20150108
            p_SetSc("目标长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("目标轧制宽度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//32 add by hanchao 20131218
            p_SetSc("展宽比", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("是否回炉", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//34
            p_SetSc("堆冷时间(小时)", "N", "6,1", "L", "", "", "", iscseq, iheadrow,"R");//35
            p_SetSc("TOP温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//36
            p_SetSc("BOT温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//37
            p_SetSc("驻留时间(M)", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//38
            p_SetSc("TOP温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//39
            p_SetSc("BOT温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//40
            p_SetSc("驻留时间(M)", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//41
            p_SetSc("TOP温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//42
            p_SetSc("BOT温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//43
            p_SetSc("驻留时间(M)", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//44
            p_SetSc("TOP温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//45
            p_SetSc("BOT温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//46
            p_SetSc("驻留时间(M)", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//47
            p_SetSc("TOP温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//48
            p_SetSc("BOT温度", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//49
            p_SetSc("驻留时间(M)", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//50
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//51
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//52
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "M");//54

            p_SetSc("是否探伤", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("回炉原因代码", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//56
            p_SetSc("回炉原因", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//57
            p_SetSc("订单厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//58
            p_SetSc("目标宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//59
            p_SetSc("目标长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "M");//60

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
