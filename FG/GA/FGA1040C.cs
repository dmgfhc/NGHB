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

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            装炉作业实绩查询及修改界面                                
///-- 程序ID            FGA1020C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2014.07.24                                                
///-- 处理描述          装炉作业实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.24        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGA1040C : CommonClass.FORMBASE
    {
        public FGA1040C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_PRC = 20,
                  SPD_PRCLNE = 21,
                  SPD_NO = 22,
                  SPD_TIME = 5,
                  SPD_SHIFT = 8,
                  SPD_EMP = 9,
                  SPD_RETE_PRS_DW_RTO = 1,
                  SPD_OT_PRS_DW_RTO = 2,
                  SPD_LEV_SPLT = 3,
                  SPD_PASS_CNT = 4,
                  SPD_DISCHARGE_TIME = 5,
                  SPD_HL_SPD = 6,
                  SPD_HL_TMP = 7;


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PRC, "P", "", "", "", imcseq, "");  // 工序
            p_SetMc(TXT_PRCLINE, "P", "", "", "", imcseq, "");      // 产线1
            p_SetMc(SDT_PROD_DATE_FROM, "P", "", "", "", imcseq, "");        // 开始时间
            p_SetMc(SDT_PROD_DATE_TO, "P", "", "", "", imcseq, "");    // 结束时间
            p_SetMc(TXT_MAT_NO, "P", "", "", "", imcseq, "");    // 物料号
            p_SetMc(TXT_LOC, "P", "", "", "", imcseq, "");    // 垛位号

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("物料号", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("入口测压下量", "N", "3", "PI", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("出口测压下量", "N", "3", "I", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("倾斜度", "N", "3", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("矫直道次", "N", "1", "I", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("矫直时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("矫直速度", "N", "8,4", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("矫直温度", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("班次", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("作业人员", "E", "8", "I", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("矫直次数", "E", "3", "", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("最后矫直时间", "DT", " ", "", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("热处理指示/实绩", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("标准号", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("重量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("垛位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("探伤指示/实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("PRC", "E", "5", "I", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("PRC_LINE", "E", "2", "I", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("机座号", "E", "1", "I", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("备注", "E", "60", "", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//24
            

            iheadrow = 0;
            p_spanSpread("产品", 14, 17, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);


        }

        private void rdo_ccl_Click(object sender, EventArgs e)
        {

            TXT_PRC.Text = "F";
            rdo_hcl.ForeColor = System.Drawing.Color.Black;
            rdo_ccl.ForeColor = System.Drawing.Color.Red;


            if (this.ss1_Sheet1.RowCount == 0) return;
            for (int i = 0; i < this.ss1_Sheet1.RowHeader.ColumnCount;i++ )
            {
                if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                {
                    ss1.ActiveSheet.Cells[i, SPD_PRC].Text = TXT_PRC.Text;
                }
            }
        }

        private void rdo_hcl_Click(object sender, EventArgs e)
        {
            TXT_PRC.Text = "H";
            rdo_hcl.ForeColor = System.Drawing.Color.Red;
            rdo_ccl.ForeColor = System.Drawing.Color.Black;

            if (this.ss1_Sheet1.RowCount == 0) return;
            for (int i = 0; i < this.ss1_Sheet1.RowHeader.ColumnCount; i++)
            {
                if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                {
                    ss1.ActiveSheet.Cells[i, SPD_PRC].Text = TXT_PRC.Text;
                }
            }
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.Sheets[0].Rows.Count <= 0)
            {
                return;
            }

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                //  ss1.ActiveSheet.Cells[e.Row, 1].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 1].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 2].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 3].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 4].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 5].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 6].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 7].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 8].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 9].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 20].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 21].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 22].Text = "";

            }
            else
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

                if (Convert.ToInt32(TXT_RETE_PRS_DW_RTO.Text) > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_RETE_PRS_DW_RTO].Text = TXT_RETE_PRS_DW_RTO.Text;
                }

                if (Convert.ToInt32(TXT_PRS_OT_PRS_DW_RTO.Text) > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_OT_PRS_DW_RTO].Text = TXT_PRS_OT_PRS_DW_RTO.Text;
                }

                if (Convert.ToInt32(TXT_LEV_SPLT.Text) > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_LEV_SPLT].Text = TXT_LEV_SPLT.Text;
                }
                if (Convert.ToInt32(TXT_PASS_CNT.Text) > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_PASS_CNT].Text = TXT_PASS_CNT.Text;
                }
                if (TXT_DISCHARGE_TIME.Text != "")
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_DISCHARGE_TIME].Text = TXT_DISCHARGE_TIME.Text;
                }
                if (TXT_HL_SPD.Text != "")
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_HL_SPD].Text = TXT_HL_SPD.Text;
                }
                if (Convert.ToInt32(TXT_HL_TMP.NumValue) > 0)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_HL_TMP].Text = TXT_HL_TMP.Text;
                }

                ss1.ActiveSheet.Cells[e.Row, SPD_SHIFT].Text = COB_SHIFT.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_EMP].Text = GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[e.Row, SPD_PRC].Text = TXT_PRC.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_PRCLNE].Text = TXT_PRCLINE.Text;
                ss1.ActiveSheet.Cells[e.Row, SPD_NO].Text = TXT_NO.Text;

            }
        }

        private void TXT_DISCHARGE_TIME_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.ss1_Sheet1.RowHeader.ColumnCount; i++)
            {
                if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改" || this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "新增")
                {
                    ss1.ActiveSheet.Cells[i, SPD_TIME].Text = TXT_DISCHARGE_TIME.Text;
                    ss1.ActiveSheet.Cells[i, SPD_SHIFT].Text = COB_SHIFT.Text;
                    ss1.ActiveSheet.Cells[i, SPD_EMP].Text = GeneralCommon.sUserID;
                }
            }
        }

        private void FGA1040C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_PRCLINE.Text = "1";
            COB_SHIFT.Text = "1";
            rdo_hcl.Checked = true;
            rdo_hcl.ForeColor = System.Drawing.Color.Red;
            TXT_PRC.Text = "H";
            if (rdo_hcl.Checked == true)
            {
                TXT_PRC.Text = "H";
                if (this.ss1_Sheet1.RowCount == 0) return;
                for (int i = 0; i < this.ss1_Sheet1.RowHeader.ColumnCount; i++)
                {
                    if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                    {
                        ss1.ActiveSheet.Cells[i, SPD_PRC].Text = TXT_PRC.Text;
                    }
                }
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            rdo_hcl.Checked = true;
            return true;
        }

        private void TXT_HL_SPD_KeyUp(object sender, KeyEventArgs e)
        {
            if (TXT_HL_SPD.Text == "") return;
            if (TXT_HL_SPD.NumValue >= 10000)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入4位整数!", "", "");
                TXT_HL_SPD.Text = "";
            }
        }

    }
}
#endregion