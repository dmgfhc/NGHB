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
    public partial class WGF1060C : CommonClass.FORMBASE
    {
        public WGF1060C()
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
            p_SetMc(SDT_DATE_FR, "P", "", "", "",imcseq, "");
            p_SetMc(SDT_DATE_TO, "P", "", "", "",imcseq, "");
            p_SetMc(CBO_ROLL_NO,"P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            //0-25
            p_SetSc("发送标记", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("装配时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧辊号", "E", "7", "IL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧辊位置", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("头部辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("辊身直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//5  
            p_SetSc("尾部辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("辊颈直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("材质", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("供货商", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("辊型曲线", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("工作侧轴承座", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("驱动侧轴承座", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("配辊号", "E", "7", "IL", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("配辊位置", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//14           
            p_SetSc("头部辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("辊身直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("尾部辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("辊径直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("材质", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("供货商", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("辊型曲线", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("工作侧轴承座", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("驱动侧轴承座", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("轧辊装配次数", "N", "7", "IL", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("配辊装配次数", "N", "7", "IL", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("发送时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//29

            iheadrow = 0;
            p_spanSpread("轧辊", 4, 12, iscseq, iheadrow, 1);
            p_spanSpread("配辊", 15, 23, iscseq, iheadrow, 1);

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
            //轧辊号栏显示轧辊号
            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS<>'DL' AND PLT='C2' ORDER BY SUBSTR(ROLL_NO,1,1) DESC, SUBSTR(ROLL_NO,2,1), SUBSTR(ROLL_NO,6,2)";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery);
        }
        #endregion

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        public override void Form_Pro()
        {
            p_pro(0, 1, true, true);
        }

    }
}
