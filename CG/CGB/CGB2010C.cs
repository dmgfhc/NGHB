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
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            加热炉装炉实绩管理                                
///-- 程序ID            CGB2010C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.04.20                                                
///-- 处理描述          加热炉实绩管理                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.12.03        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGB2010C : CommonClass.FORMBASE
    {
        public CGB2010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        //public const int iSs1_Slab_No = 0;  //SS1钢板号

        const int SS1_SLAB_NO = 0;
        const int SS1_SLAB_SIZE = 6;
        const int SS1_MILL_SIZE = 9;
        const int SS1_DEL_TO_DATE = 17;
        const int SS1_URGNT_FL = 19;
        const int SS1_IMP_CONT = 20;
        const int SS2_IMP_CONT = 15;
        const int SS2_SLAB_NO = 0;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", txt_SlabNo, "PNIR", "", "", "", "", imcseq);
            p_SetMc("板坯规格", TXT_SLAB_SIZE, "R", "", "", "", "", imcseq);
            p_SetMc("轧制规格", txt_RollingSize, "R", "", "", "", "", imcseq);
            p_SetMc("装炉/取消", txt_Status, "NIR", "", "", "", "", imcseq);
            p_SetMc("炉坐号", txt_func, "NIR", "", "", "", "", imcseq);
            p_SetMc("温度", SDB_CHARGE_TEMP, "IR", "", "", "", "", imcseq);
            p_SetMc("布料方式", TXT_RHF_CH_ROW, "NIR", "", "", "", "", imcseq);
            p_SetMc("装炉时间", TXT_RHF_CH_TIME, "NIR", "", "", "", "", imcseq);
            p_SetMc("装炉时间修正", TXT_RHF_CH_TIME_UPD, "NIR", "", "", "", "", imcseq);
            p_SetMc("班次", TXT_SHIFT, "I", "", "", "", "", imcseq);
            p_SetMc("班别", TXT_GROUP, "I", "", "", "", "", imcseq);
            p_SetMc("作业人员", TXT_EMP, "I", "", "", "", "", imcseq);

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("板坯号", txt_SlabNo, "PNI", "", "", "", "", imcseq);
            p_SetMc("缺号时间", TXT_REJ_OCCR_TIME, "NI", "", "", "", "", imcseq);
            p_SetMc("缺号代码", TXT_REASON_CD, "NI", "", "", "", "", imcseq);
            p_SetMc("缺号板坯确定", TXT_COMFRM, "NI", "", "", "", "", imcseq);
            p_SetMc("班次", TXT_SHIFT, "IR", "", "", "", "", imcseq);
            p_SetMc("班别", TXT_GROUP, "IR", "", "", "", "", imcseq);
            p_SetMc("作业人员", TXT_EMP, "IR", "", "", "", "", imcseq);

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("查询状态", txt_RstFormDate, "PNI", "", "", "", "", imcseq);
            p_SetMc("查询状态", txt_RstToDate, "PNI", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("炉坐号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("HCR分类", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("计划板坯长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("实际重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("轧制规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("目标温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("设计成材率", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("实设成材率", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("交货期开始", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("交货期结束", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//23
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//24

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("加热炉号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("装炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("出炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//15
        }

        private void CGB2010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGB2010NC";
            Form_Define();

            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_EMP.Text = GeneralCommon.sUserID;

            SSCheck1_CheckedChanged1();
            opt_rhf0.Checked = true;
            opt_rhf0.ForeColor = Color.Red;
            opt_EntCan0.Checked = true;
            opt_EntCan0.ForeColor = Color.Red;
            opt_RHF_ROW0.Checked = true;
            SSCheck1.Checked = true;
            tabControl1.SelectedIndex = 0;
            txt_Status.Text = "1";
            TXT_RHF_CH_ROW.Text = "0";

            //unlock spread
            unlockSpread(ss1);
            unlockSpread(ss2);

            Form_Ref();
        }

        public override void Spread_Exc()
        {
            if (0 == tabControl1.SelectedIndex)
            {
                if (ss1_Sheet1.RowCount <= 0) { return; }
                SpreadCommon.Gp_Sp_Excel(ss1);
            }
            if (1 == tabControl1.SelectedIndex)
            {
                if (ss2_Sheet1.RowCount <= 0) { return; }
                SpreadCommon.Gp_Sp_Excel(ss2);
            }
        }

        // 重写查询
        public override void Form_Ref()
        {

            //// 板坯查询（1 有计划未装炉 / 2 已入炉未出炉）
            //if (chk_ref.Checked)
            //{
            //    p_Ref(3, 1, true, false);
            //}

            //// 板坯装炉
            //if (SSCheck1.Checked & txt_SlabNo.Text.Trim().Length == 10)
            //{
            //    p_Ref(1, 0, true, false);
            //}

            //// 板坯出炉
            //if (sc3.Checked & txt_SlabNo.Text.Trim().Length == 10)
            //{
            //    p_Ref(2, 0, true, false);
            //}

            int iRow;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            string sUrgnt_Fl;
            string simpcont;
            string simpcont1;

            sCurDate = System.DateTime.Now.ToString("yyyyMM");

            if (0 == tabControl1.SelectedIndex)
            {
                p_Ref(0, 1, true, false);
                opt_EntCan0.Checked = true;
                iCol = 0;
                iRow = txt_tmpseq.Text == "" ? 0 : Convert.ToInt32(txt_tmpseq.Text);
                //ss1.SetActiveCell 1, ss1.ROW

                if (ss1.ActiveSheet.RowCount > 0)
                {
                    if (SSCheck1.Checked & opt_EntCan0.Checked)
                    {
                        txt_SlabNo.Text = ss1.ActiveSheet.Cells[iRow, SS1_SLAB_NO].Value.ToString();
                        TXT_SLAB_SIZE.Text = ss1.ActiveSheet.Cells[iRow, SS1_SLAB_SIZE].Value.ToString();
                        txt_RollingSize.Text = ss1.ActiveSheet.Cells[iRow, SS1_MILL_SIZE].Value.ToString();
                    }
                    else if (sc3.Checked)
                    {
                    }

                }


                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    if (ss1.ActiveSheet.RowCount <= 0)
                    {
                        break;
                    }

                    sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Value.ToString();

                    sDel_To_Date = ss1.ActiveSheet.Cells[iRow - 1, SS1_DEL_TO_DATE].Value.ToString().Substring(0, 6);

                    if (Convert.ToInt32(sDel_To_Date) < Convert.ToInt32(sCurDate))
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                    }
                    //紧急订单绿色显示 add by liqian 2012-08-15
                    if (sUrgnt_Fl == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                    }

                    simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text;

                    if (simpcont == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                    }
                }

                for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++)
                {
                    if (ss2.ActiveSheet.RowCount <= 0)
                    {
                        break;
                    }

                    simpcont = ss2.ActiveSheet.Cells[iRow - 1, SS2_IMP_CONT].Text;
                    if (simpcont == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        SpreadCommon.Gp_Sp_BlockColor(ss1, SS2_IMP_CONT, SS2_IMP_CONT, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                    }
                }
            }
            else if (1 == tabControl1.SelectedIndex)
            {
                p_Ref(3, 2, true, false);
            }
        }

        // 重写保存
        public override void Form_Pro()
        {

            //// 板坯装炉
            //if (SSCheck1.Checked)
            //{
            //    p_Pro(1, 0, true, false);
            //}
            //// 板坯出炉
            //else
            //{
            //    p_Pro(2, 0, true, false);
            //}

            string SMESG;
            string sLoc;
            string Temp_no;
            int i;
            int j;

            if (TXT_RHF_CH_TIME.Text == "")
            {
                SMESG = " 请正确输入装炉时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            if (txt_EntCan.Text == "1")
            {
                if (!p_Pro(1, 0, true, false)) { return; };
            }
            else if (txt_EntCan.Text == "2")
            {
                if (!p_Pro(2, 0, true, false))
                { return; }
            }

            TXT_RHF_CH_TIME.Text = "";
            TXT_REJ_OCCR_TIME.Text = "";

            if (tabControl1.SelectedIndex == 0)
            {
                p_Ref(0, 1, true, false);


                ss1_DblClick(0);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                p_Ref(3, 2, true, false);
                ss2_DblClick(0);
            }

            //'added by guoli at 20100703
            if (txt_func.Text == "")
            {
                if (opt_rhf0.Checked)
                {
                    txt_func.Text = "1";
                }
                else if (opt_rhf1.Checked)
                {
                    txt_func.Text = "2";
                }
                else if (opt_rhf2.Checked)
                {
                    txt_func.Text = "3";
                }
                else if (opt_rhf3.Checked)
                {
                    txt_func.Text = "4";
                }
            }

            if (TXT_RHF_CH_ROW.Text == "")
            {
                if (opt_RHF_ROW0.Checked)
                {
                    TXT_RHF_CH_ROW.Text = "0";
                }
                else if (opt_RHF_ROW1.Checked)
                {
                    TXT_RHF_CH_ROW.Text = "1";
                }
                else if (opt_RHF_ROW2.Checked)
                {
                    TXT_RHF_CH_ROW.Text = "2";
                }
            }

        }

        #endregion


        // 查询条件中板坯号自动带出
        //private void cbo_slab_no_Enter(object sender, EventArgs e)
        //{
        //    string comboxsql;
        //    comboxsql = "SELECT GOODS_ID FROM (SELECT B.GOODS_ID  FROM FP_TRACKIDX A, FP_TRACKDATA B WHERE A.FACT_CD = 'C1' AND A.PRC = 'CA' AND A.PRC_LINE= '1' AND A.FACT_CD=B.FACT_CD AND A.PRC=B.PRC  AND A.PRC_LINE=B.PRC_LINE AND B.SEQ_NO <= A.LAST_SEQ  ORDER BY B.SEQ_NO DESC) WHERE ROWNUM <= 20";

        //    cbo_slab_no.DropDownStyle = ComboBoxStyle.DropDown;
        //    cbo_slab_no.RightToLeft = RightToLeft.No;
        //    DataTable dt = new Query(comboxsql).CreateDataTable(false);
        //    cbo_slab_no.DataSource = dt;

        //    cbo_slab_no.DisplayMember = dt.Columns[0].ToString();
        //    cbo_slab_no.ValueMember = dt.Columns[0].ToString();
        //}

        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_Status.Text = "1";

            opt_rhf0.Checked = true;
            opt_rhf0.ForeColor = Color.Red;
            opt_rhf1.Checked = false;
            opt_rhf1.ForeColor = Color.Black;
            opt_rhf2.Checked = false;
            opt_rhf2.ForeColor = Color.Black;
            opt_rhf3.Checked = false;
            opt_rhf3.ForeColor = Color.Black;

            opt_RHF_ROW0.Checked = true;
            //opt_RHF_ROW0.ForeColor = Color.Red;
            opt_RHF_ROW1.Checked = false;
            opt_RHF_ROW1.ForeColor = Color.Black;
            opt_RHF_ROW2.Checked = false;
            opt_RHF_ROW2.ForeColor = Color.Black;

            opt_EntCan0.Checked = true;
            opt_EntCan0.ForeColor = Color.Red;
            opt_EntCan1.Checked = false;
            opt_EntCan1.ForeColor = Color.Black;

            TXT_EMP.Text = GeneralCommon.sUserID;

            return true;
        }

        private void opt_EntCan0_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_EntCan0.Checked)
            {
                txt_Status.Text = "1";
                opt_EntCan0.ForeColor = Color.Red;//Red color
                opt_EntCan1.ForeColor = Color.Black;//Black color
            }
            else
            {
                txt_Status.Text = "2";
                opt_EntCan1.ForeColor = Color.Red;//Red color
                opt_EntCan0.ForeColor = Color.Black;//Black color
            }

        }

        private void opt_ORDER0_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_ORDER0.Checked)
            {
                TXT_COMFRM.Text = "1";
                opt_ORDER0.ForeColor = Color.Red;//Red color
                opt_ORDER1.ForeColor = Color.Black;//Black color
            }
            else
            {
                TXT_COMFRM.Text = "2";
                opt_ORDER1.ForeColor = Color.Red;//Red color
                opt_ORDER0.ForeColor = Color.Black;//Black color
            }
        }

        private void opt_rhf0_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rhf0.Checked)
            {
                txt_func.Text = "1";
                opt_rhf0.ForeColor = Color.Red;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Black;
            }

        }

        private void opt_rhf1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rhf1.Checked)
            {
                txt_func.Text = "2";
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf1.ForeColor = Color.Red;
                opt_rhf2.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Black;
            }

        }

        private void opt_rhf2_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rhf2.Checked)
            {
                txt_func.Text = "3";
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Red;
                opt_rhf3.ForeColor = Color.Black;
            }

        }

        private void opt_rhf3_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_rhf3.Checked)
            {
                txt_func.Text = "4";
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Red;
            }
        }

        private void sc3_CheckedChanged(object sender, EventArgs e)
        {
            if (sc3.Checked == false)
            {
                if (SSCheck1.Checked == false)
                {
                    sc3.Checked = true;
                    sc3.ForeColor = Color.Red;

                }
                return;
            }

            txt_EntCan.Text = "2";

            //Cancel Data Enbaled is False
            sc3.Checked = true;
            SSCheck1.Checked = false;
            TXT_REJ_OCCR_TIME.Enabled = true;
            TXT_REASON_CD.Enabled = true;
            TXT_REASON_NAME.Enabled = true;
            TXT_COMFRM.Enabled = true;
            TXT_REJ_SHIFT.Enabled = true;
            TXT_REJ_GROUP.Enabled = true;
            TXT_REJ_EMP.Enabled = true;

            //Slab Entriy Data Enbaled is True
            txt_Status.Enabled = false;
            SDB_CHARGE_TEMP.Enabled = false;
            TXT_RHF_CH_ROW.Enabled = false;
            TXT_RHF_CH_TIME.Enabled = false;
            TXT_RHF_CH_TIME_UPD.Enabled = false;
            TXT_SHIFT.Enabled = false;
            TXT_GROUP.Enabled = false;
            TXT_EMP.Enabled = false;

            opt_ORDER0.Checked = true;

            TXT_REJ_SHIFT.Text = Gf_ShiftSet3("");
            TXT_REJ_GROUP.Text = Gf_GroupSet(TXT_REJ_SHIFT.Text, Gf_DTSet("", "X"));

            TXT_REJ_EMP.Text = GeneralCommon.sUserID;


            TXT_REJ_OCCR_TIME.Text = DateTime.Now.ToString();
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount > 0)
            {
                if (SSCheck1.Checked & opt_EntCan0.Checked)
                {

                    txt_SlabNo.Text = ss1.ActiveSheet.Cells[e.Row, SS1_SLAB_NO].Value.ToString();

                    TXT_SLAB_SIZE.Text = ss1.ActiveSheet.Cells[e.Row, SS1_SLAB_SIZE].Value.ToString();

                    txt_RollingSize.Text = ss1.ActiveSheet.Cells[e.Row, SS1_MILL_SIZE].Value.ToString();
                    txt_tmpseq.Text = (e.Row + 1).ToString();

                }
                else if (!sc3.Checked)
                {
                }

            }

        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClick(e.Row);
        }

        public void ss1_DblClick(int Row)
        {
            if (ss1.ActiveSheet.RowCount >= 0)
            {
                if (SSCheck1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss1.ActiveSheet.Cells[Row, SS1_SLAB_NO].Value.ToString();

                    TXT_SLAB_SIZE.Text = ss1.ActiveSheet.Cells[Row, SS1_SLAB_SIZE].Value.ToString();

                    txt_RollingSize.Text = ss1.ActiveSheet.Cells[Row, SS1_MILL_SIZE].Value.ToString();

                }
                else if (sc3.Checked)
                {
                }

            }

        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClick(e.Row);
        }

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClick(e.Row);
        }

        public void ss2_DblClick(int Row)
        {
            if (ss2.ActiveSheet.RowCount >= 0)
            {
                if (SSCheck1.Checked & opt_EntCan1.Checked)
                {
                    txt_SlabNo.Text = ss2.ActiveSheet.Cells[Row, SS2_SLAB_NO].Value.ToString();
                }
                else if (sc3.Checked)
                {

                    TXT_REJ_OCCR_TIME.Text = System.DateTime.Now.ToString();
                }

                if (txt_SlabNo.Text.Trim() != "")
                {

                    p_Ref(1, 0, true, false);

                    //Gf_Ms_Refer(M_CN1, Mc1, , , true);
                }

            }

            if (opt_EntCan0.Checked)
            {
                txt_Status.Text = "1";
            }
            else if (opt_EntCan1.Checked)
            {
                txt_Status.Text = "2";
            }

        }

        private void SSCheck1_CheckedChanged(object sender, EventArgs e)
        {
            SSCheck1_CheckedChanged1();
        }

        public void SSCheck1_CheckedChanged1()
        {
            if (SSCheck1.Checked)
            {
                if (sc3.Checked)
                {
                    SSCheck1.Checked = true;
                    SSCheck1.ForeColor = Color.Red;
                }
                return;
            }
            txt_EntCan.Text = "1";

            //Cancel Data Enbaled is False
            sc3.Checked = false;
            TXT_REJ_OCCR_TIME.Enabled = false;
            TXT_REASON_CD.Enabled = false;
            TXT_REASON_NAME.Enabled = false;
            TXT_COMFRM.Enabled = false;
            TXT_REJ_SHIFT.Enabled = false;
            TXT_REJ_GROUP.Enabled = false;
            TXT_REJ_EMP.Enabled = false;

            //Slab Entriy Data Enbaled is True
            txt_Status.Enabled = true;

            SDB_CHARGE_TEMP.Enabled = true;
            TXT_RHF_CH_ROW.Enabled = true;

            opt_EntCan0.Checked = true;
            opt_RHF_ROW0.Checked = true;

            TXT_RHF_CH_TIME.Enabled = true;
            TXT_RHF_CH_TIME_UPD.Enabled = true;
            TXT_SHIFT.Enabled = true;
            TXT_GROUP.Enabled = true;
            TXT_EMP.Enabled = true;

            //Call TXT_RHF_CH_TIME_DblClick
            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text, Gf_DTSet("", "X"));
            TXT_EMP.Text = GeneralCommon.sUserID;
        }



        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {
            DTCheck = "S";
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 == tabControl1.SelectedIndex)
            {
                TXT_SHIFT.Text = Gf_ShiftSet3("");
                if (TXT_SHIFT.Text == "1")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "000001";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081459";
                }
                else if (TXT_SHIFT.Text == "2")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081500";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "155959";
                }
                else if (TXT_SHIFT.Text == "3")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "160000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "235959";
                }
            }
            Form_Ref();
        }


        private void txt_func_TextChanged(object sender, EventArgs e)
        {
            if (txt_func.Text == "1")
            {
                opt_rhf0.Checked = true;
                opt_rhf0.ForeColor = Color.Red;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Black;
            }
            else if (txt_func.Text == "2")
            {
                opt_rhf1.Checked = true;
                opt_rhf1.ForeColor = Color.Red;
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Black;
            }
            else if (txt_func.Text == "3")
            {
                opt_rhf2.Checked = true;
                opt_rhf2.ForeColor = Color.Red;
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf3.ForeColor = Color.Black;
            }
            else if (txt_func.Text == "4")
            {
                opt_rhf3.Checked = true;
                opt_rhf3.ForeColor = Color.Red;
                opt_rhf0.ForeColor = Color.Black;
                opt_rhf1.ForeColor = Color.Black;
                opt_rhf2.ForeColor = Color.Black;
            }
        }

        private void TXT_REASON_CD_TextChanged(object sender, EventArgs e)
        {
            if (TXT_REASON_CD.Text == "")
            {
                TXT_REASON_NAME.Text = "";
            }
        }

        private void TXT_RHF_CH_ROW_TextChanged(object sender, EventArgs e)
        {
            if (TXT_RHF_CH_ROW.Text == "0")
            {
                opt_RHF_ROW0.Checked = true;
                //opt_RHF_ROW0.ForeColor = Color.Red;
                //opt_RHF_ROW1.ForeColor = Color.Black;
                //opt_RHF_ROW2.ForeColor = Color.Black;
            }
            else if (TXT_RHF_CH_ROW.Text == "1")
            {
                opt_RHF_ROW1.Checked = true;
                //opt_RHF_ROW1.ForeColor = Color.Red;
                //opt_RHF_ROW0.ForeColor = Color.Black;
                //opt_RHF_ROW2.ForeColor = Color.Black;
            }
            else if (TXT_RHF_CH_ROW.Text == "2")
            {
                opt_RHF_ROW2.Checked = true;

            }
            else if (TXT_RHF_CH_ROW.Text == "3")
            {
                opt_RHF_ROW3.Checked = true;

            }
            else if (TXT_RHF_CH_ROW.Text == "4")
            {
                opt_RHF_ROW4.Checked = true;

            }
            else if (TXT_RHF_CH_ROW.Text == "5")
            {
                opt_RHF_ROW5.Checked = true;

            }

        }

        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;

            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;

            }
        }

        private void opt_RHF_ROW0_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW0.Checked)
            {
                TXT_RHF_CH_ROW.Text = "0";
            }
        }

        private void opt_RHF_ROW1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW1.Checked)
            {
                TXT_RHF_CH_ROW.Text = "1";
            }
        }

        private void opt_RHF_ROW2_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW2.Checked)
            {
                TXT_RHF_CH_ROW.Text = "2";
            }
        }

        private void opt_RHF_ROW3_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW3.Checked)
            {
                TXT_RHF_CH_ROW.Text = "3";
            }
        }

        private void opt_RHF_ROW4_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW4.Checked)
            {
                TXT_RHF_CH_ROW.Text = "4";
            }
        }

        private void opt_RHF_ROW5_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_RHF_ROW5.Checked)
            {
                TXT_RHF_CH_ROW.Text = "5";
            }
        }

        private void TXT_REJ_OCCR_TIME_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
