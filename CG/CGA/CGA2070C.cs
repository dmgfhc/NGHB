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
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2011C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2070C : CommonClass.FORMBASE
    {
        public CGA2070C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        //const int SPD_PLAN_PROD_WGT = 33,
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始时间",sdt_in_plt_date, "PN", "", "", "", "",imcseq);
            p_SetMc("结束时间",sdt_out_plt_date, "PN", "", "", "", "",imcseq);
            p_SetMc(txt_plt, "P", "", "", "", imcseq, "");
            p_SetMc(txt_act_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("母板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("原板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//4
            p_SetSc("母板坯重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//9
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10

            p_SetSc("板坯重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("指示日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("板坯切割时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("班别", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//14
 
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("定尺类别", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("垛位号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//20
           
            iheadrow = 0;
            p_spanSpread("母板坯尺寸", 2, 4, iscseq, iheadrow, 1);
            p_spanSpread("板坯尺寸", 8, 10, iscseq, iheadrow, 1);
            p_spanSpread("订单尺寸", 17, 19, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2070NC";
            Form_Define();

            sdt_in_plt_date.RawDate = System.DateTime.Now.ToString();
            sdt_out_plt_date.RawDate = System.DateTime.Now.ToString();

            txt_MoCnt.Text = "";
            txt_MoWgt.Text = "";
            txt_DoCnt.Text = "";
            txt_DoWgt.Text = "";
           
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);

            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }

            int MoCnt = 0,
                DoCnt = 0,
                row = 0,
                col = 0;

            double MoWgt = 0,
                    DoWgt = 0;

            string mSlab,
                    lSlab = "";

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    lockColor(ss1, i, "#F2F2F2");//修改背景色

                }
                if (i == 0)
                {
                    lSlab = ss1.ActiveSheet.Cells[i, 0].Value.ToString();
                    mSlab = ss1.ActiveSheet.Cells[i, 0].Value.ToString();

                }
                else
                {
                    lSlab = ss1.ActiveSheet.Cells[i - 1, 0].Value.ToString() == "" ? lSlab : ss1.ActiveSheet.Cells[i - 1, 0].Value.ToString();
                    mSlab = ss1.ActiveSheet.Cells[i, 0].Value.ToString();

                    if (mSlab == lSlab)
                    {
                        ss1.ActiveSheet.Cells[i, 0].Value = "";
                        ss1.ActiveSheet.Cells[i, 5].Value = "";

                    }
                }

            }

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                if(ss1.ActiveSheet.Cells[i,0].Value !="")
                {
                    if (ss1.ActiveSheet.Cells[i, 0].Value.ToString().Substring(0, 1) == "0" || ss1.ActiveSheet.Cells[i, 0].Value.ToString().Substring(0, 1) == "1" || ss1.ActiveSheet.Cells[i, 0].Value.ToString().Substring(0, 1) == "2")
                    {
                        MoCnt = MoCnt + 1;
                        MoWgt = MoWgt + Convert.ToDouble(ss1.ActiveSheet.Cells[i, 5].Value);
                    }
                }

                if (ss1.ActiveSheet.Cells[i, 7].Value != "")
                {
                    if (ss1.ActiveSheet.Cells[i, 7].Value.ToString().Substring(0, 1) == "0" || ss1.ActiveSheet.Cells[i, 7].Value.ToString().Substring(0, 1) == "1" || ss1.ActiveSheet.Cells[i, 7].Value.ToString().Substring(0, 1) == "2")
                    {
                        DoCnt = DoCnt + 1;
                        DoWgt = DoWgt + Convert.ToDouble(ss1.ActiveSheet.Cells[i, 11].Value);
                    }
                }
            }

            row = ss1.ActiveSheet.RowCount;
            ss1.ActiveSheet.Rows.Add(row, 1);
            lockColor(ss1, row, "#FFE6E6");//修改背景色

            if (MoCnt > 0)
            {
                 row = ss1.ActiveSheet.RowCount-1;
                 col = 4;
                //ss.Sheets[0].ActiveRowIndex++;
                //ss.Sheets[0].ActiveColumnIndex = 0;

                ss1.ActiveSheet.Cells[row, 0].Value = "合计";
                ss1.ActiveSheet.Cells[row,col].Value = MoCnt + "块";
                txt_MoCnt.Text = MoCnt.ToString();
                col = 5;
                ss1.ActiveSheet.Cells[row, col].Value = MoWgt;
                txt_MoWgt.Text = ss1.ActiveSheet.Cells[row, col].Value.ToString();
            }

            if (DoCnt > 0)
            {
                row = ss1.ActiveSheet.RowCount - 1;
                col = 10;
                ss1.ActiveSheet.Cells[row, col].Value = DoCnt + "块";
                txt_DoCnt.Text = DoCnt.ToString();
                col = 11;
                ss1.ActiveSheet.Cells[row, col].Value = DoWgt;
                txt_DoWgt.Text = ss1.ActiveSheet.Cells[row, col].Value.ToString(); ;
            }
        }

        //public override void Form_Pro()
        //{
        //    p_pro(1, 1, true, true);
        //}

        public override bool Form_Cls()
        {
            base.Form_Cls();
            return true;

        }

        //修改锁定颜色方法
        public void lockColor(FpSpread e, int rowNo, String BackColor)
        {
            int columnCount = e.Sheets[0].ColumnCount;

            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;

                e.ActiveSheet.Cells[rowNo, i].BackColor = ColorTranslator.FromHtml(BackColor);
            }
        }
        #endregion


    }
}