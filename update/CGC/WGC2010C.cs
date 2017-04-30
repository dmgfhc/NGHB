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
    public partial class WGC2010C : CommonClass.FORMBASE
    {
        public WGC2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Len = 3;       //SS1母板长度
        public const int iSs1_Org_Len = 14;  //SS1母板原始长度
        public const int iSs2_Plate_No = 0;  //SS2钢板号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产日期", sdt_prod_date_fr, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", sdt_prod_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("轧制号", txt_mat_no, "P", "12", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("轧制号", txt_mat_no, "P", "12", "", "", "", imcseq);
            p_SetMc("分段数", cbo_cut_cnt, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 12, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("母板号", "E", "12", "PI", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("序列", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("UST", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("热处理", "E", "50", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            //11-14
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("母板号", "E", "12", "AI", "", "", "", iscseq, iheadrow);
            p_SetSc("原始长度", "N", "8", "L", "", "", "", iscseq, iheadrow);

            iheadrow = 0;
            p_spanSpread("规格", 1, 4, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 6, 9, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, true, true);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("序列", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("是否紧急", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("钢板数量", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("UST", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");
            //11-13
            p_SetSc("热处理", "E", "50", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");
            iheadrow = 0;
            p_spanSpread("规格", 1, 4, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 6, 11, iscseq, iheadrow, 1);

        }
        private void WGC2010C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
        }
        #endregion

        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 2, true, true);
            return;
        }
        #endregion

        #region //保存
        public override void Form_Pro()
        {
            double sPlateLen = 0;     //母板长度
            double sOrgPlateLen = 0;  //原始母板长度
            double sStdLen = 2000;    //分板长度和与原始长度标准差（mm）

            //计算分板长度和
            for (int iRow = 0; iRow <= ss1.ActiveSheet.RowCount - 1; iRow++)
            {
                if (iRow == 0)
                {
                    sOrgPlateLen = Convert.ToDouble(ss1_Sheet1.Cells[iRow, iSs1_Org_Len].Text);
                }
                sPlateLen = sPlateLen + Convert.ToDouble(ss1_Sheet1.Cells[iRow, iSs1_Len].Text);
            }

            //分板长度之和不能大于原始母板长度
            if ( sPlateLen > sOrgPlateLen )
            {
                GeneralCommon.Gp_MsgBoxDisplay("分板长度之和大于原始母板长度,请确认", "I", this.Text);
                return;
            }

            //分板长度之和小于原始母板长度不能超过标准量 sStdLen
            if (sPlateLen + sStdLen < sOrgPlateLen)
            {
                GeneralCommon.Gp_MsgBoxDisplay("分板长度之和小于原始母板长度" + sStdLen + "mm 以上，请确认", "I", this.Text);
                return;
            }

            base.p_pro(0, 1, true, true);
            txt_mat_no.Text = "";
            ss1.ActiveSheet.RowCount = 0;
            base.p_Ref(1, 2, true, true);
            return;
        }
        #endregion

        private void ss2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (ss2_Sheet1.RowCount == 0)
            {
                return;
            }

            txt_mat_no.Text = ss2_Sheet1.Cells[e.Row, iSs2_Plate_No].Text;
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            base.p_Ref(2, 1, true, true);
            return;
        }
   
    }
}
