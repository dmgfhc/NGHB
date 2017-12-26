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

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       中板轧钢作业
//-- Sub_System Name   板坯库管理
//-- Program Name      板坯判废实绩录入界面
//-- Program ID        CGA2081C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.04.05
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.04.05       韩超        板坯判废实绩录入界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2081C : CommonClass.FORMBASE
    {
        public CGA2081C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int ss1UserId = 20,
                  ss1ScrapDate = 3,
                  ss1Shift = 4;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始时间",TXT_From_Date, "NP", "", "", "", "",imcseq);
            p_SetMc("结束时间", TXT_To_Date, "NP", "", "", "", "", imcseq);
            p_SetMc(CBO_SHIFT_REF, "P", "", "", "", imcseq, "");
            p_SetMc(txt_mat_no, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_FLAG, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 20, true, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("工厂", "E", "60", "I", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("工序", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("机号", "E", "60", "I", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("判废日期", "D", "", "I", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("班次", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("班别", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("废钢种类", "2", "7", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("板坯号", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("生产日期", "D", "", "", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("判废原因", "E", "1", "I", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("原因描述", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("进程状态", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("厚度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("宽度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("长度", "N", "8,2", "", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("重量", "N", "15,3", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("增减", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("增减量", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("计划使用工厂", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("录入时间", "DT", "", "", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("录入人员", "E", "8", "I", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("FLAG", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("END DATE", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("END CD", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("备注", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//24

            //iheadrow = 0;
            //p_spanSpread("当垛位号", 3, 5, iscseq, iheadrow, 1);
            //p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 9, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 10, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2081NC";
            Form_Define();
            TXT_FLAG.Text = "1";
            ULabel10.Text = "产生日期";
            ULabel10.ForeColor = Color.Red;
            OPT_SCRAP_WAIT.Checked = true;

            TXT_To_Date.RawDate = DateTime.Now.ToString("yyyyMMdd");
            TXT_From_Date.RawDate = DateTime.Now.ToString("yyyyMMdd").Substring(0, 6) + "01";

            //txt_cur_inv.Text = "ZB";
            //txt_prod_cd.Text = "SL";
       //     base.sAuthority = "1111";
        }
        #endregion


        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            
            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }
            else
            {
                SDB_TOT_WGT.Text = "";
                //查询重量计算
                double totWgt=0;
                    for (int iRow = 0; iRow < ss1.ActiveSheet.RowCount; iRow++)
                    {                
                        totWgt +=  Convert.ToDouble(ss1.ActiveSheet.Cells[iRow,15].Value); 
                       
                    }
                    SDB_TOT_WGT.Text = totWgt.ToString();
            }
        }

        public override void Form_Pro()
        {
            p_pro(0, 1, true, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            SDB_TOT_WGT.Text = "";
            TXT_FLAG.Text = "1";
            ULabel10.Text = "产生日期";
            ULabel10.ForeColor = Color.Red;
            OPT_SCRAP_WAIT.Checked = true;
            return true;

        }

        private void OPT_SCRAP_WAIT_Click(object sender, EventArgs e)
        {
            TXT_FLAG.Text = "1";
            ULabel10.Text = "产生日期";
            OPT_SCRAP_WAIT.Checked = true;
        }

        private void OPT_SCRAP_Click(object sender, EventArgs e)
        {
            TXT_FLAG.Text = "2";
            ULabel10.Text = "判废日期";
            OPT_SCRAP.Checked = true;
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }
            else
            {
                if ("" == CBO_SHIFT_REF.Text)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请正确输入判废班次", "W", "");
                }
                else
                {
                    ss1.ActiveSheet.Cells[e.Row, ss1ScrapDate].Text = System.DateTime.Now.ToString();
                    ss1.ActiveSheet.Cells[e.Row, ss1Shift].Text = CBO_SHIFT_REF.Text;
                    ss1.ActiveSheet.Cells[e.Row, ss1UserId].Text = GeneralCommon.sUserID;
                    ss1.ActiveSheet.RowHeader.Rows[e.Row].Label = "修改";
                }
            }

        }


    }
}