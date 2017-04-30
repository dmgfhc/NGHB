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
    public partial class WGE1030C : CommonClass.FORMBASE
    {
        public WGE1030C()
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
            p_SetMc("产品类型", txt_prod_cd, "PN", "2", "", "", "", imcseq);
            p_SetMc("生产日期从", SDT_PROD_DATE_FROM, "PN", "10", "", "", "", imcseq);
            p_SetMc("生产日期至", SDT_PROD_DATE_TO, "PN", "10", "", "", "", imcseq);
            p_SetMc("标准", TXT_STDSPEC_CHG, "P", "30", "", "", "", imcseq);           
            p_SetMc("起始库", txt_cur_from, "PN", "2", "", "", "", imcseq);
            p_SetMc("当前垛位", txt_loc, "P", "7", "", "", "", imcseq);
            p_SetMc("物料号", TXT_PLATE_NO, "P", "14", "", "", "", imcseq);
            p_SetMc("热处理", txt_htm_ord_cd, "P", "", "", "", "", imcseq);
            p_SetMc("厚度下限", txt_thk_min, "P", "", "", "", "", imcseq);
            p_SetMc("厚度上限", txt_thk_max, "P", "", "", "", "", imcseq);
            p_SetMc("宽度下限", txt_wid_min, "P", "", "", "", "", imcseq);
            p_SetMc("宽度上限", txt_wid_max, "P", "", "", "", "", imcseq);
            p_SetMc("长度下限", txt_thk_min, "P", "", "", "", "", imcseq);
            p_SetMc("长度上限", txt_thk_max, "P", "", "", "", "", imcseq);
            p_SetMc("定尺区分", txt_sizeknd, "P", "", "", "", "", imcseq);
            p_SetMc("切边", txt_trim_fl, "P", "", "", "", "", imcseq);
            p_SetMc("目标库", txt_cur_to, "", "", "", "", "", imcseq);
            p_SetMc("转库时间", sdt_move_date, "", "14", "", "", "", imcseq);
            p_SetMc("件数", TXT_CNT, "", "", "", "", "", imcseq);
            p_SetMc("重量", TXT_WGT, "", "", "", "", "", imcseq);
 

            

            p_ScIni(ss1, Sc1, 26, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("转库提单号", "E", "13", "AIL", "", "", "", iscseq, iheadrow);

            p_SetSc("转库发货号", "E", "15", "AIL", "", "", "", iscseq, iheadrow);
            p_SetSc("产品号", "E", "14", "", "IL", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "4", "", "IL", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "D", "10", "", "L", "", "", iscseq, iheadrow);
            p_SetSc("堆放位置", "E", "10", "", "IL", "", "", iscseq, iheadrow);

            //6-10           
            p_SetSc("转库日期", "D", "10", "AIL", "", "", "", iscseq, iheadrow);
            p_SetSc("转库时间", "T", "8", "AIL", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);            
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);            
            p_SetSc("重量", "E", "16", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切边类型", "E", "6", "L", "", "", "", iscseq, iheadrow);            
            p_SetSc("定尺类型", "E", "6", "L", "", "", "", iscseq, iheadrow); 
            p_SetSc("订单材/余材", "E", "6", "L", "", "", "", iscseq, iheadrow);
            //16-20
            p_SetSc("客户代码", "E", "15", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("客户名称", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow); 
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow);            
             p_SetSc("探伤", "E", "3", "L", "", "", "", iscseq, iheadrow);
            //21
            p_SetSc("切割", "E", "3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("其他", "E", "10", "L", "", "", "", iscseq, iheadrow);    
            p_SetSc("车辆号", "E", "10", "IL", "", "", "", iscseq, iheadrow);
                   
            //26
            
            p_SetSc("操作人", "E", "10", "IL", "", "", "", iscseq, iheadrow);
       
            iheadrow = 0;
            p_spanSpread("规格", 8, 11, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 20, 24, iscseq, iheadrow, 1);
           
        }
        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();

        }
        #endregion

       
      

    }
}
