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


namespace CG
{
    public partial class CGH2030C : CommonClass.FORMBASE
    {
        public CGH2030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        // 定义列变量
        public const int SS1_USER_ID = 8;

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", CBO_PLT, "P", "", "", "", "", imcseq);//1   
            p_SetMc("工序", CBO_PRC, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("发生时间", TXT_OCCR_TIME, "P", "", "", "", "", imcseq);


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("工厂", "E", "2", "PNI", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("工序", "E", "2", "PI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("发生时间", "D", "", "PI", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("班次", "E", "1", "PI", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("公辅材料代码", "E", "3", "PI", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("公辅材料名称", "E", "60", "IL", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("消耗量", "N", "9,2", "I", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("作业人员", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//8
           
        }

        private void CGH2030C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGH2030NC";
            Form_Define();
            CBO_PLT.Text = "C3";
        }

        //protected override void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        //{
           
        //}

        public override void Spread_Ins()
        {
            base.Spread_Ins();

            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, 0].Text = "C3";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_USER_ID].Text = GeneralCommon.sUserID;
           
        }

        public override bool Form_Cls()
        {
            // 重写清空
            if (base.Form_Cls())
            {
                CBO_PRC.Text = "";
                CBO_SHIFT.Text = "";
                CBO_PLT.Text = "C3";
            }
            return true;
        }
        #endregion

        
    }
}
