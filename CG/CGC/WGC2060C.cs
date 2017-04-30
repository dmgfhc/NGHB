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
    public partial class WGC2060C : CommonClass.FORMBASE
    {
        public WGC2060C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("母板", radioButton1, "P", "", "", "", "", imcseq);
            p_SetMc("在离线", textBox14, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", textBox14, "P", "12", "", "", "", imcseq);
            p_SetMc("生产日期", ceriUDate1, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", ceriUDate2, "P", "", "", "", "", imcseq);
            p_SetMc("班次", comboBox4, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 13, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("物料号", "E", "50", "P", "", "", "", iscseq, iheadrow);//0
            p_SetSc("物料代码", "E", "50", "R", "", "", "", iscseq, iheadrow);//1
            p_SetSc("进程代码", "E", "50", "R", "", "", "", iscseq, iheadrow);//2
            p_SetSc("厚度", "N", "6,2", "R", "", "", "", iscseq, iheadrow);//3
            p_SetSc("宽度", "N", "6,2", "R", "", "", "", iscseq, iheadrow);//4
            p_SetSc("长度", "N", "6,2", "R", "", "", "", iscseq, iheadrow);//5
            p_SetSc("重量", "N", "15,3", "R", "", "", "", iscseq, iheadrow);//6
            p_SetSc("标准号", "E", "30", "R", "", "", "", iscseq, iheadrow);//7
            p_SetSc("订单号", "E", "14", "R", "", "", "", iscseq, iheadrow);//8
            p_SetSc("生产日期", "D", "19", "R", "", "", "", iscseq, iheadrow);//9
            p_SetSc("班次", "E", "1", "", "", "", "", iscseq, iheadrow);//10
            p_SetSc("位置", "E", "10", "R", "", "", "", iscseq, iheadrow);//11
            p_SetSc("是否紧急订单", "E", "1", "R", "", "", "", iscseq, iheadrow);//12

        }
        private void WGC2060C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
        }
        #endregion
    }
}
