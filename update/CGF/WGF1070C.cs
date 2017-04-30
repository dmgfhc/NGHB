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
    public partial class WGF1070C : CommonClass.FORMBASE
    {
        public WGF1070C()
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
            p_SetMc(SDT_DATE_FR, "P", "", "", "", imcseq, "");
            p_SetMc(SDT_DATE_TO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_ROLL_NO, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_ROLL_TYPE, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-17
            p_SetSc("轧辊号", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("磨削序列号", "N", "5", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("磨削开始时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("磨削结束时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("磨削原因", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("磨削位置", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("磨削前辊径", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("磨削后辊径", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("辊身磨削量(mm)", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("入库重量(kg)", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("消耗重量(kg)", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("入库价格(元)", "N", "10", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("消耗金额(元)", "N", "10,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//15
        }

        private void WGF1070C_Load(object sender, EventArgs e)
        {
            Form_Define();

            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <> 'DL' ORDER BY ROLL_NO";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery);
        }

        #endregion

        
    }
}
