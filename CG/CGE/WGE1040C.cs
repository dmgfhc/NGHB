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
    public partial class WGE1040C : CommonClass.FORMBASE
    {
        public WGE1040C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        
        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("生产厂",txt_prod_cd, "PN", "2", "", "", "", imcseq);
            p_SetMc("生产日期1", txt_cur_from, "PN", "10", "", "", "", imcseq);
            p_SetMc("生产日期2", txt_cur_to, "P", "10", "", "", "", imcseq);
            p_SetMc("标准", txt_mov_date_from, "PN", "10", "", "", "", imcseq);
            p_SetMc("班次", txt_mov_date_to, "PN", "10", "", "", "", imcseq);
            p_SetMc("班别", txt_mv_list_no, "P", "1", "", "", "", imcseq);
          

            p_ScIni(ss1, Sc1, 12, true, false);
            iheadrow = 0;
            iscseq = 1;
            //0-5
            p_SetSc("移拨码单号", "E", "13", "", "", "", "", iscseq, iheadrow);

            p_SetSc("产品类型", "E", "4", "", "", "", "", iscseq, iheadrow);
            p_SetSc("起始库", "E", "2", "", "", "", "", iscseq, iheadrow);
            p_SetSc("起始库名", "E", "12", "", "", "", "", iscseq, iheadrow);            
            p_SetSc("目标库", "E", "2", "", "", "", "", iscseq, iheadrow);
            p_SetSc("目标库名", "E", "12", "", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("车辆号", "E", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("移送数量", "E", "3", "", "", "", "", iscseq, iheadrow);
            p_SetSc("移送重量", "E", "13", "", "", "", "", iscseq, iheadrow);
            p_SetSc("转库日期", "D", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("转库录入人", "E", "6", "", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("到达日期", "D", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("到达录入人", "E", "7", "", "", "", "", iscseq, iheadrow);
            

            p_ScIni(ss2, Sc2, 13, true, false);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("目标库", "E", "2", "", "", "", "", iscseq, iheadrow);

            p_SetSc("移拨码单号", "E", "15", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("产品号", "E", "14", "", "I", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "4", "", "", "", "", iscseq, iheadrow);
            p_SetSc("进程代码", "E", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("堆放位置", "E", "6", "", "", "", "", iscseq, iheadrow);

            //6-10
            p_SetSc("厚度", "E", "7", "", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "E", "7", "", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "E", "9", "", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "E", "16", "", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "", "", "", "", iscseq, iheadrow);

            //11-15     
            p_SetSc("表面等级", "E", "6", "", "", "", "", iscseq, iheadrow);
            p_SetSc("订单号", "E", "14", "", "", "", "", iscseq, iheadrow);
            p_SetSc("客户代码", "E", "8", "", "", "", "", iscseq, iheadrow);
            p_SetSc("客户名称", "E", "30", "", "", "", "", iscseq, iheadrow);
            p_SetSc("切边类型", "E", "6", "", "", "", "", iscseq, iheadrow);
            //16-20
            p_SetSc("定尺类型", "E", "6", "", "", "", "", iscseq, iheadrow);
            p_SetSc("转库日期", "D", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("目标库", "E", "2", "", "", "", "", iscseq, iheadrow);
            p_SetSc("到达日期", "D", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("到达录入人", "E", "7", "", "", "", "", iscseq, iheadrow);            
            //21
            p_SetSc("探伤", "E", "5", "", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "5", "", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "5", "", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "15", "", "", "", "", iscseq, iheadrow);  
            p_SetSc("其他", "E", "15", "", "", "", "", iscseq, iheadrow);

            //26  
            p_SetSc("备注", "E", "30", "", "", "", "", iscseq, iheadrow);
            p_SetSc("运输方式", "E", "6", "", "", "", "", iscseq, iheadrow);
            p_SetSc("运输公司", "E", "60", "", "", "", "", iscseq, iheadrow);
            p_SetSc("运输车型", "E", "10", "", "", "", "", iscseq, iheadrow);
            p_SetSc("生产工厂", "E", "8", "", "", "", "", iscseq, iheadrow);
           

            iheadrow = 0;
            p_spanSpread("规格", 7, 10, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 12,14, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 21, 25, iscseq, iheadrow, 1);
            p_spanSpread("运输信息", 27, 29, iscseq, iheadrow, 1);
           
            
           

        }
        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
        }
        #endregion
    }
}
