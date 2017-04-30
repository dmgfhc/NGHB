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

using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;

namespace CG
{
    public partial class WGC1020C : CommonClass.FORMBASE
    {
        public WGC1020C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Plate_No = 0;  //SS1钢板号
        public const int iSs1_Prod_Cd = 1;   //SS1产品代码
        public const int iSs1_Upd_Emp = 15;  //SS1更新人员
        public const int iSs1_Sche_Sts = 16; //SS1指示操作

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产日期", sdt_date_fr, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", sdt_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("钢板号", txt_slab_no, "P", "14", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 15, false, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "PNIRL", "", "", "", iscseq, iheadrow);    
            p_SetSc("产品代码", "E", "2", "ANIRL", "", "", "", iscseq, iheadrow, "M");  
            p_SetSc("厚度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "RL", "", "", "", iscseq, iheadrow);            
            p_SetSc("重量", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("宽度上下限", "E", "100", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("长度上下限", "E", "100", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "D", "19", "RL", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("位置", "E", "50", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "RL", "", "", "", iscseq, iheadrow);
            //11-16
            p_SetSc("订单号", "E", "14", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("订单材/余材", "E", "1", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("客户", "E", "50", "RL", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("是否紧急订单", "E", "50", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("作业人员", "E", "7", "NIRL", "", "", "", iscseq, iheadrow);
            p_SetSc("指示操作", "E", "1", "ANIRL", "", "", "", iscseq, iheadrow, "M");

            iheadrow = 0;
            p_spanSpread("订单", 6, 7, iscseq, iheadrow, 1);

        }

        private void WGC1020C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_AGB3011C_LQ";
            Form_Define();
       //     base.sAuthority = "1111"; 

        }
        #endregion

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, false);
            //SpreadCommon.Gp_Sp_EvenRowBackcolor(ss1, 10);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            string sRowLabel;
            string sScheFl;  //计划状态( Y:已下达 N:未下达)
            string sScheSts; //接口标识（A:下达   D:取消）
            if (e.ColumnHeader) return;
            //只有选择行表头才可进行操作
            if (e.Column != 0)
            {
                return;
            }

            sRowLabel = ss1_Sheet1.RowHeader.Rows[e.Row].Label;
            //取消前次操作
            if (sRowLabel == "修改")
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = "";
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Sts].Text = "";
                return;
            }
            //初始化指示操作标识
            if (sche_sent.Checked)
            {
                sScheFl = "Y";
                sScheSts = "A";
            }
            else
            {
                sScheFl = "N";
                sScheSts = "D";
            }
            //指示操作
            ss1_Sheet1.RowHeader.Rows[e.Row].Label = "修改";
            ss1_Sheet1.Cells[e.Row, iSs1_Sche_Sts].Text = sScheSts;
            ss1_Sheet1.Cells[e.Row, iSs1_Upd_Emp].Text = GeneralCommon.sUserID;
        }

    }
}
