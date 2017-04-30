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
    public partial class WGC2070C : CommonClass.FORMBASE
    {
        public WGC2070C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        int ss1_RETE_PRS_DW_RTO = 1;
        int ss1_PRS_OT_PRS_DW_RTO = 2;
        int ss1_LEV_SPLT = 3;
        int ss1_PASS_CNT = 4;
        int ss1_DISCHARGE_TIME = 5;
        int ss1_EMP = 8;


        #region 界面初始化
        protected override void p_SubFormInit()
        {        
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);//1
            p_SetMc("PRC", txt_Prc, "P", "", "", "", "", imcseq);//2
            p_SetMc("机号", cbo_PrcLine, "PN", "", "", "", "", imcseq);//3
            p_SetMc("热处理方法", txt_RsltHtm, "P", "", "", "", "", imcseq);//4
            p_SetMc("开始生产日期", udt_date_fr, "P", "", "", "", "", imcseq);//5
            p_SetMc("结束生产日期", udt_date_to, "P", "", "", "", "", imcseq);//6
            p_SetMc("查询号", TXT_MAT_NO, "P", "", "", "", "", imcseq);//7
            p_SetMc("作业时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);//8
      

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("物料号", "E", "", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("入口测压下量", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("出口测压下量", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("倾斜度", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("次数", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("作业日期", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("班次", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("班别", "E", "", "I", "", "", "", iscseq, iheadrow);//7
            p_SetSc("作业人", "E", "", "I", "", "", "", iscseq, iheadrow);//8
            p_SetSc("矫直次数", "E", "", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("热处理", "E", "", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("标准号", "E", "", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("厚度", "N", "6,2", "", "", "", "", iscseq, iheadrow);//12
            p_SetSc("宽度", "N", "6,2", "", "", "", "", iscseq, iheadrow);//13
            p_SetSc("长度", "N", "6,2", "", "", "", "", iscseq, iheadrow);//14
            p_SetSc("重量", "N", "15,3", "", "", "", "", iscseq, iheadrow);//15
            p_SetSc("剁位", "E", "", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("探伤", "E", "", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("取样", "E", "", "L", "", "", "", iscseq, iheadrow);//18
            p_SetSc("PLT", "E", "", "PIL", "", "", "", iscseq, iheadrow);//19
            p_SetSc("PRC", "E", "", "PIL", "", "", "", iscseq, iheadrow);//20
            p_SetSc("PRC_LINE", "E", "", "PIL", "", "", "", iscseq, iheadrow);//21
            p_SetSc("", "E", "", "IL", "", "", "", iscseq, iheadrow);//22
            p_SetSc("", "E", "", "IL", "", "", "", iscseq, iheadrow);//23
            p_SetSc("备注", "E", "", "L", "", "", "", iscseq, iheadrow);//24
            p_SetSc("轧批号", "E", "", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("紧急订单", "E", "", "L", "", "", "", iscseq, iheadrow);//26

            iheadrow = 0;
            p_spanSpread("产品", 12, 15, iscseq, iheadrow, 1);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
        }

        private void WGC2070C_Load(object sender, EventArgs e)
        {            
            Form_Define();
            TXT_EMP.Text = GeneralCommon.sUserID;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            TXT_EMP.Text = GeneralCommon.sUserID;
            txt_Prc.Text = "C";
            return true;
        }
        //private void WKB1030C_Load(object sender, EventArgs e)
        //{
        //    Form_Define();
        //    //txt_UserId.Text = GeneralCommon.sUserID;
        //    //CBO_LINE.Text = "1";
        //    //txt_Flag.Text = "C2";
        //    //CBO_PLT.Text = "C2";
           
        //}
        //自定义查询方法

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {

            if (e.ColumnHeader) return;
            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }
            TXT_MAT_NO.Text = ss1_Sheet1.Cells[e.Row, 0].Text;
            if (ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text != "修改")
            {
                ss1_Sheet1.Cells[e.Row, ss1_RETE_PRS_DW_RTO].Text = txt_RETE_PRS_DW_RTO.Text;
                ss1_Sheet1.Cells[e.Row, ss1_PRS_OT_PRS_DW_RTO].Text = PRS_OT_PRS_DW_RTO.Text;
                ss1_Sheet1.Cells[e.Row, ss1_LEV_SPLT].Text = TXT_LEV_SPLT.Text;
                ss1_Sheet1.Cells[e.Row, ss1_PASS_CNT].Text = TXT_PASS_CNT.Text;
                ss1_Sheet1.Cells[e.Row, ss1_DISCHARGE_TIME].Text = DateTime.Now.ToString()/*TXT_DISCHARGE_TIME.Text*/;
                ss1_Sheet1.Cells[e.Row, ss1_EMP].Text = TXT_EMP.Text;
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
            }
            else
            {
                ss1_Sheet1.Cells[e.Row, ss1_RETE_PRS_DW_RTO].Text = "";
                ss1_Sheet1.Cells[e.Row, ss1_PRS_OT_PRS_DW_RTO].Text = "";
                ss1_Sheet1.Cells[e.Row, ss1_LEV_SPLT].Text = "";
                ss1_Sheet1.Cells[e.Row, ss1_PASS_CNT].Text = "";
                ss1_Sheet1.Cells[e.Row, ss1_DISCHARGE_TIME].Text = "";
                ss1_Sheet1.Cells[e.Row, ss1_EMP].Text = "";
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
            }
        }

        #endregion       

      

     
    }
}
