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

namespace CG
{
    public partial class WGT2040C : CommonClass.FORMBASE
    {
        public WGT2040C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(CBO_PRC_LINE, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_DATE_BEGIN, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_DATE_END, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_CLASSNUM, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_CLASSTYPE, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_SLABNO, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;
            
            
            //0-21
            p_SetSc("实绩矫直日期", "D", "", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("实绩矫直时间", "T", "", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("物料号", "E", "", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("顺序", "N", "5", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("切割工厂", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//4   
            p_SetSc("进程代码", "E", "", "L", "", "", "", iscseq, iheadrow,"M");//5
            p_SetSc("轧制标准", "E", "20", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("标准号", "E", "14", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("钢种", "E", "14", "L", "", "", "", iscseq, iheadrow);//8

            p_SetSc("厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("长度", "N", "6", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//12

            p_SetSc("表面等级", "E", "14", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("产品等级", "E", "14", "L", "", "", "", iscseq, iheadrow);//14

            p_SetSc("入口测压下", "N", "3", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("出口测压下", "N", "3", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("倾斜", "N", "3", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("速度", "N", "8,4", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("道次数", "N", "1", "L", "", "", "", iscseq, iheadrow);//20

            p_SetSc("班次", "N", "14", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("班别", "E", "14", "L", "", "", "", iscseq, iheadrow);//22
            p_SetSc("操作人员1", "N", "14", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("操作员1", "E", "14", "L", "", "", "", iscseq, iheadrow);//24
            p_SetSc("操作人员2", "N", "14", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("操作员2", "E", "14", "L", "", "", "", iscseq, iheadrow);//26
            p_SetSc("操作人员3", "N", "14", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("操作员3", "E", "14", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("扎批号", "N", "14", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("垛位", "E", "14", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("缺陷", "E", "14", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("改判缺陷", "E", "14", "L", "", "", "", iscseq, iheadrow);//32
            p_SetSc("特殊工序", "E", "14", "L", "", "", "", iscseq, iheadrow);//33
            
            p_SetSc("探伤", "E", "14", "L", "", "", "", iscseq, iheadrow);//34
            p_SetSc("切割", "E", "14", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("矫直", "E", "14", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("抛丸", "E", "14", "L", "", "", "", iscseq, iheadrow);//37
            p_SetSc("热处理", "E", "14", "L", "", "", "", iscseq, iheadrow);//38
            
            p_SetSc("客户", "E", "14", "L", "", "", "", iscseq, iheadrow);//39
            p_SetSc("入库时间", "DT", "", "L", "", "", "", iscseq, iheadrow);//40
            p_SetSc("库别", "E", "10", "M", "", "", "", iscseq, iheadrow);//41
            p_SetSc("订单材/余材代码", "E", "1", "M", "", "", "", iscseq, iheadrow);//42
            p_SetSc("定尺", "C", "", "L", "", "", "", iscseq, iheadrow);//43
            p_SetSc("紧急订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//44

            p_spanSpread("产品", 9, 12, 1, 0, 1);
            p_spanSpread("冷矫直", 15, 20, 1, 0, 1);
            p_spanSpread("作业指示/实绩", 34, 38, 1, 0, 1);
        }

        private void WGT2040C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }
    }
}
