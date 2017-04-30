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
    public partial class CGA2100C : CommonClass.FORMBASE
    {
        public CGA2100C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        string sql = "SELECT CD '代码', CD_SHORT_NAME '代码简称', CD_NAME '代码名称',CD_SHORT_ENG '代码英文简称', CD_FULL_ENG '代码英文名称' FROM NISCO.ZP_CD  WHERE CD_MANA_NO = 'F0031' AND CD like '%'  ORDER  BY  CD  ASC ";

        //const int SPD_PLAN_PROD_WGT = 33,
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_heat_no, "P", "", "", "", imcseq, "");
            p_SetMc(txt_slab_fl, "P", "", "", "", imcseq, "");
            p_SetMc(txt_act_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(sdt_prod_date_from, "P", "", "", "", imcseq, "");
            p_SetMc(sdt_prod_date_to, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "PNIL", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("计划钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("实际钢种", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");//2
            p_SetSc("厚度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "N", "8,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("是否成分合格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("是否翻板", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("代表缺陷", "COMN", "2", "I", "F0031", "", "", iscseq, iheadrow,"M");//9
            p_SetSc("横裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//10

            p_SetSc("纵裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("网状裂", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("皮下气", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("皮下夹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//14
 
            p_SetSc("振痕", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("凹凸", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("其他", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("横裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("纵裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("网状裂", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("皮下气", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("皮下夹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("振痕", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("凹凸", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("其他", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("横裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("纵裂纹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("网状裂", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("皮下气", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//29

            p_SetSc("皮下夹", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("振痕", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("凹凸", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("其他", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//33

            p_SetSc("EMP_CD", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("EMP_NAME", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//35


           
            iheadrow = 0;
            p_spanSpread("宽面", 10, 17, iscseq, iheadrow, 1);
            p_spanSpread("窄面", 18, 25, iscseq, iheadrow, 1);
            p_spanSpread("角面", 26, 33, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 34, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 35, true);

            p_ScIni(ss2, Sc2, 0, true, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("板坯号", "E", "12", "PNIL", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("钢种", "E", "11", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("钢种说明", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("厚度", "N", "4,2", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("产品等级", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("是否修磨", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("退回原因", "COMN", "1", "I", "F0031", "", "", iscseq, iheadrow, "M");//10

            p_SetSc("退回原因名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("作业人", "E", "7", "IL", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("作业人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("IN_DATE", "E", "60", "IL", "", "", "", iscseq, iheadrow, "L");//14

            //iheadrow = 0;
            //p_spanSpread("当垛位号", 3, 5, iscseq, iheadrow, 1);
            //p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss2, 13, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, 14, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2100NC";
            Form_Define();
            //ss1.ActiveSheet.RowHeader.Cells[0, 9].ForeColor = Color.Blue;
            //ss2.ActiveSheet.RowHeader.Cells[0, 10].ForeColor = Color.Blue;
            sdt_prod_date_from.RawDate = System.DateTime.Now.ToString();
            sdt_prod_date_to.RawDate = System.DateTime.Now.ToString();
            opt_fault.Checked = true;
            opt_fault.ForeColor = Color.Red;
            opt_nuse.ForeColor = Color.Black;
            opt_fault.Visible = false;
            opt_nuse.Visible = false;
            label4.Text = "入库日期";
            txt_slab_fl.Text = "1";
            tabControl1.SelectedIndex = 0;
        }
        #endregion


        public override void Form_Ref()
        {
            if (0 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 1, true, true);
            }
            if (1 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 2, true, true);
            }
            return;
            
        }

        public override void Form_Pro()
        {
            if (0 == tabControl1.SelectedIndex)
            {
                p_pro(1, 1, true, true);
            }
            if (1 == tabControl1.SelectedIndex)
            {
                p_pro(1, 2, true, true);
            }
            return;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            //txt_cur_inv.Text = "ZB";
            //txt_prod_cd.Text = "SL";
            sdt_prod_date_from.RawDate = System.DateTime.Now.ToString();
            sdt_prod_date_to.RawDate = System.DateTime.Now.ToString();
            sdt_prod_date_from.RawDate = System.DateTime.Now.ToString();
            sdt_prod_date_to.RawDate = System.DateTime.Now.ToString();
            opt_fault.Checked = true;
            opt_fault.ForeColor = Color.Red;
            opt_nuse.ForeColor = Color.Black;
            opt_fault.Visible = false;
            opt_nuse.Visible = false;
            label4.Text = "入库日期";
            tabControl1.SelectedIndex = 0;
            txt_slab_fl.Text = "1";
            return true;
        }


        private void opt_fault_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_fault.Checked)
            {
                label4.Visible = true;
                sdt_prod_date_from.Visible = true;
                sdt_prod_date_to.Visible = true;
                opt_fault.ForeColor = Color.Red;
                opt_nuse.ForeColor = Color.Black;
                txt_slab_fl.Text = "1";
            }
            else
            {
                label4.Visible = false;
                txt_slab_fl.Text = "2";
                sdt_prod_date_from.Visible = false;
                sdt_prod_date_to.Visible = false;
                opt_fault.ForeColor = Color.Black;
                opt_nuse.ForeColor = Color.Red;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 == tabControl1.SelectedIndex)
            {
                opt_fault.Visible = false;
                opt_nuse.Visible = false;
                label4.Text = "入库日期";
                opt_fault.Checked = true;
            }
            if (1 == tabControl1.SelectedIndex)
            {
                opt_fault.Visible = true;
                opt_nuse.Visible = true;
                label4.Text = "检查日期";
                opt_fault.Checked = true;
            }

        }


    }
}