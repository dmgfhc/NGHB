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
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   轧辊管理
//-- Program Name      轧辊磨削实绩查询及修改界面
//-- Program ID        WGF1020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.12.20
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR           DESCRIPTION
//-- 1.00    2012.12.20       李超       轧辊磨削实绩查询及修改
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGF1020C : CommonClass.FORMBASE
    {
        public WGF1020C()
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
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号",CMB_ROLL_ID, "PNRI", "", "", "","", imcseq);
            p_SetMc(SDB_SEQ_NO, "RLI", "", "", "", imcseq, "");
            p_SetMc("工厂",TXT_PLT, "NRI", "", "", "","", imcseq);
            p_SetMc("班次",CMB_SHIFT, "NRI", "", "", "","", imcseq);
            p_SetMc("班别",CMB_GROUP, "NRI", "", "", "","", imcseq);
            p_SetMc(TXT_EMP_CD, "NRI", "", "", "", imcseq, "");
            p_SetMc("磨削开始时间",TXT_GRID_STA_TIME, "RI", "", "", "","", imcseq);
            p_SetMc(NMB_GRID_NUM, "RL", "", "", "", imcseq, "");
            p_SetMc(NMB_D_DIA, "RI", "", "", "", imcseq, "");      //驱动侧辊径(头部)
            p_SetMc(NMB_W_DIA, "RI", "", "", "", imcseq, "");      //工作侧辊径(尾部)
            p_SetMc(NMB_BEF_GRID_DIA, "RI", "", "", "", imcseq, "");
            p_SetMc(NMB_AFT_GRID_DIA, "RI", "", "", "", imcseq, "");
            p_SetMc(NMB_GRID_WGT, "RI", "", "", "", imcseq, "");
            p_SetMc(TXT_GRID_RESON, "RI", "", "", "", imcseq, "");
            p_SetMc(TXT_GRID_POS, "RI", "", "", "", imcseq, "");
            p_SetMc("磨削结束时间",TXT_GRID_END_TIME, "NRI", "", "", "", "",imcseq);
            p_SetMc("辊型曲线",CMB_ROLL_CURVE, "NRI", "", "", ""," ", imcseq);  //辊型曲线
            p_SetMc(NMB_B_ROLL_N_DIA, "R", "", "", "", imcseq, "");
            p_SetMc(NMB_A_ROLL_N_DIA, "R", "", "", "", imcseq, "");
            p_SetMc(NMB_A_ROLL_N_WGT, "R", "", "", "", imcseq, "");
            p_SetMc(NMB_ROLL_IN_AVE_HARD, "RL", "", "", "", imcseq, "");
            p_SetMc(NMB_ROLL_MILL_WGT, "RL", "", "", "", imcseq, "");
            p_SetMc(NMB_ROLL_MILL_LEN, "RL", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, true, true);//第一个true是排序、第二个是否锁定
            iheadrow = 0;
            iscseq = 1;

            //0-8
            p_SetSc("磨削序列号", "N", "3", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("磨削开始时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("磨削结束时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("缺陷原因代码", "E", "2", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("缺陷部位", "E", "3", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("磨削前辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("磨削后辊径", "N", "7,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("辊身磨削量", "N", "7,3", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("辊型曲线", "E", "8", "L", "", "", "", iscseq, iheadrow);//8
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGF2030C";
            Form_Define();

     //       base.sAuthority = "1111";

            //加载轧辊号
            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <> 'DL' ORDER BY ROLL_NO";
            GeneralCommon.Gf_ComboAdd(CMB_ROLL_ID, sQuery);

            TXT_EMP_CD.Text = GeneralCommon.sUserID;
            TXT_PLT.Text = "C2";
            CMB_SHIFT.Text = GeneralCommon.sShift;
        }
        #endregion


        //CMB_ROLL_ID Change事件，显示当前辊径
        private void CMB_ROLL_ID_TextChanged(object sender, EventArgs e)
        {

            if (tt == "1")
            {
                return;
            }
            
            string sq1 = "";
            string BEF_GRID = "";
            sq1 = "SELECT ROLL_DIA FROM GP_ROLLW WHERE ROLL_NO = \'" + CMB_ROLL_ID.Text + "\'";
            BEF_GRID = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sq1);

            if (CMB_ROLL_ID.Text != "")
            {
                NMB_BEF_GRID_DIA.Text = BEF_GRID;
            }
            
        }

        string tt = "";
        public override void Form_Ref()
        {
            tt = "1";
            p_Ref(1, 1, true, true);

        }

        //CMB_ROLL_ID单击事件，显示当前辊径
        private void CMB_ROLL_ID_Click(object sender, EventArgs e)
        {
            string sq1 = "";
            string BEF_GRID = "";
            sq1 = "SELECT ROLL_DIA FROM GP_ROLLW WHERE ROLL_NO = \'" + CMB_ROLL_ID.Text + "\'";
            BEF_GRID = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sq1);

            if (CMB_ROLL_ID.Text != "")
            {
                NMB_BEF_GRID_DIA.Text = BEF_GRID;
            }
        }

        //"中部"单击
        private void chk_c_Click(object sender, EventArgs e)
        {
            if (chk_c.Checked == false)
            {
                if (chk_w.Checked == false && chk_d.Checked == false)
                {
                    TXT_GRID_POS.Text = " ";
                    return;
                }
            }
            TXT_GRID_POS.Text = "C";
            chk_c.ForeColor = Color.Red;
            chk_c.Checked = true;

            chk_w.ForeColor = Color.Black;
            chk_w.Checked = false;
            chk_d.ForeColor = Color.Black;
            chk_d.Checked = false;
        }

        //"驱动侧"单击
        private void chk_d_Click(object sender, EventArgs e)
        {
            if (chk_d.Checked == false)
            {
                if (chk_w.Checked == false && chk_c.Checked == false)
                {
                    TXT_GRID_POS.Text = " ";
                    return;
                }
            }
            TXT_GRID_POS.Text = "D";
            chk_d.ForeColor = Color.Red;
            chk_d.Checked = true;

            chk_w.ForeColor = Color.Black;
            chk_w.Checked = false;
            chk_c.ForeColor = Color.Black;
            chk_c.Checked = false;

        }

        //"工作侧"单击
        private void chk_w_Click(object sender, EventArgs e)
        {
            if (chk_w.Checked == false)
            {
                if (chk_c.Checked == false && chk_d.Checked == false)
                {
                    TXT_GRID_POS.Text = " ";
                    return;
                }
            }
            TXT_GRID_POS.Text = "W";
            chk_w.ForeColor = Color.Red;
            chk_w.Checked = true;

            chk_c.ForeColor = Color.Black;
            chk_c.Checked = false;
            chk_d.ForeColor = Color.Black;
            chk_d.Checked = false;

        }
        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_EMP_CD.Text = GeneralCommon.sUserID;
                CMB_SHIFT.Text = GeneralCommon.sShift;
                CMB_ROLL_ID.Text = "";
                CMB_GROUP.Text = "";
                TXT_PLT.Text = "C2";
                chk_c.Checked = false;
                chk_d.Checked = false;
                chk_w.Checked = false;
                chk_c.ForeColor = Color.Black;
                chk_d.ForeColor = Color.Black;
                chk_w.ForeColor = Color.Black;

                tt = "";
            }
            return true;
        }

        public override void Form_Pro()
        {

            TXT_EMP_CD.Text = GeneralCommon.sUserID;

            string ss = TXT_GRID_STA_TIME.Text;
            ss = ss.Replace(":", "");
            ss = ss.Replace("-", "");
            ss = ss.Replace(" ", "").Trim();


            if (GeneralCommon.Gf_DateTime_Chk(ss) == false)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请正确输入磨削开始时间 ！", "", "");
                return;
            }

            string ss1 = TXT_GRID_END_TIME.Text;
            ss1 = ss1.Replace(":", "");
            ss1 = ss1.Replace("-", "");
            ss1 = ss1.Replace(" ", "").Trim();

            if (ss != "" && ss1 != "")
            {
                if (GeneralCommon.Gf_DateTime_Chk(ss1) == false)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请正确输入磨削结束时间 ！", "", "");
                    return;
                }
                if (double.Parse(ss) - double.Parse(ss1) > 0)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("磨削结束时间应大于磨削开始时间，请正确输入时间信息 ！", "", "");
                    return;
                }
            }

            tt = "1";

            p_pro(1, 0, true, true);
            p_Ref(1, 1, true, true);

        }

        private void NMB_BEF_GRID_DIA_Leave(object sender, EventArgs e)
        {
            NMB_GRID_WGT.NumValue = NMB_BEF_GRID_DIA.NumValue - NMB_AFT_GRID_DIA.NumValue;
        }

        private void NMB_AFT_GRID_DIA_Leave(object sender, EventArgs e)
        {
            NMB_GRID_WGT.NumValue = NMB_BEF_GRID_DIA.NumValue - NMB_AFT_GRID_DIA.NumValue;
        }


    }
}
