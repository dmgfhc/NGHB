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
//-- Program Name      外来板坯实绩录入
//-- Program ID        CGA2090C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.04.05
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.04.05       韩超        外来板坯实绩录入界面
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2090C : CommonClass.FORMBASE
    {
        public CGA2090C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        //const int ss1UserId = 20,
        //          ss1ScrapDate = 3,
        //          ss1Shift = 4;

        string bySlabNo;
        string firstFL;
        string SALENO;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("转炉号(新)",txt_new_slab_no, "NPIR", "", "", "", "",imcseq);
            p_SetMc(txt_InPltCo, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_InPltCoDesc, "R", "", "", "", imcseq, "");
            p_SetMc(txt_OldSlabNo2, "R", "", "", "", imcseq, "");
            p_SetMc("厚度", txt_thk, "NIR", "", "", "", "", imcseq);
            p_SetMc("宽度", txt_wid, "NIR", "", "", "", "", imcseq);
            p_SetMc("长度", txt_len, "NIR", "", "", "", "", imcseq);
            p_SetMc("重量", txt_wgt, "NIR", "", "", "", "", imcseq);
            p_SetMc("车号", txt_car_no, "NIR", "", "", "", "", imcseq);
            p_SetMc("钢种", txt_act_stlgrd, "NIR", "", "", "", "", imcseq);
            p_SetMc(txt_act_stlgrd_dec, "RL", "", "", "", imcseq, "");
            p_SetMc("入库块数", txt_slabcnt, "NIR", "", "", "", "", imcseq);
            p_SetMc(txt_mon, "R", "", "", "", imcseq, "");
            p_SetMc(txt_heat, "R", "", "", "", imcseq, "");
            p_SetMc(txt_seq, "R", "", "", "", imcseq, "");
            p_SetMc("C", txt_c, "NIR", "", "", "", "", imcseq);
            p_SetMc("MN", txt_mn, "NIR", "", "", "", "", imcseq);
            p_SetMc("P", txt_p, "NIR", "", "", "", "", imcseq);
            p_SetMc("S", txt_s, "NIR", "", "", "", "", imcseq);
            p_SetMc("SI", txt_si, "NIR", "", "", "", "", imcseq);
            p_SetMc(txt_ceq, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_nb, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_cu, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_v, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_cr, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_ni, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_alt, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_mo, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_ti, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_w, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_b, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_re, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_pb, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_ca, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_n, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_h, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_o, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_als, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_zr, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_mg, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_sn, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_as, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_co, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_te, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_bi, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_sb, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_zn, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_se, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_ta, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_pcm, "IR", "", "", "", imcseq, "");
            p_SetMc(txt_inyard_time, "R", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 10, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "PIL", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("外来板坯号", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("厚度", "N", "8", "I", "", "", "", iscseq, iheadrow,"R");//2
            p_SetSc("宽度", "N", "8", "I", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("长度", "N", "8", "I", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("板坯重量", "N", "8,3", "I", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("理论重量", "N", "8,3", "IL", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("钢种", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("垛位号", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("操作员", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("车辆号", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("买公司", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//12

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 2, 4, iscseq, iheadrow, 1);
            //p_spanSpread("转垛位号", 6, 8, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 9, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 9, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 10, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
        }

        private void cmd_get_info_Click()
        {
            string Mon;
            string HeatNo;
            string sQuery;


            if (txt_new_slab_no.Text.Trim().Length == 8)
            {

                sQuery = "          SELECT MAX(SLAB_NO) ";
                sQuery = sQuery + "   FROM NISCO.FP_SLAB ";
                sQuery = sQuery + "  WHERE SLAB_NO LIKE '" + txt_new_slab_no.Text.Trim() + "%' AND MOTHER_SLAB IS NULL";

                bySlabNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
                if (bySlabNo.Length == 0)
                {
                    bySlabNo = txt_new_slab_no.Text + "00";
                }

                Get_OldSms_Info();

                comm_slab.Enabled = true;

            }
        }

        private void comm_slab_test()
        {
            int i = 0;
            int j;

            int row = i;
            int col = 1;
            string NEWSLABNO;
            string tmThk;
            string tmWid;
            string tmLen;
            double tmWgt = 0;



            if (txt_act_stlgrd.Text.Length == 0)
            {

                GeneralCommon.Gp_MsgBoxDisplay("请输入钢种..!", "G", "");
                return;
            }

            if (txt_thk.NumValue == 0 | txt_wid.NumValue == 0 | txt_len.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入板坯尺寸..!", "G", "");
                return;
            }

            if (txt_wgt.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入板坯重量..!", "G", "");
                return;
            }

            if (txt_slabcnt.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入板坯切割块数 ..!", "G", "");
                return;
            }

            if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
            {
                if (txt_OldSlabNo2.Text.Trim() == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请输入原来板坯号码..!", "G", "");
                    return;
                }

                if (txt_new_slab_no.Text.Trim().Length != 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请输入新板坯号码..!", "G", "");
                    return;
                }

                if (txt_new_slab_no.Text.Trim().Substring(2, 1) != "A" && txt_new_slab_no.Text.Trim().Substring(2, 1) != "B")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请输入新板坯号码..!", "G", "");
                    return;
                }

                if (txt_InPltCo.Text.Trim().Length != 6)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请输入外购公司代吗..!", "G", "");
                    return;
                }


            }

            //ss1.ActiveSheet.RowCount = txt_slabcnt;

            if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
            {
                bySlabNo = "00";
            }

            for (i = 1; i <= txt_slabcnt.NumValue; i++)
            {
                row = i-1;
                col = 0;

                if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
                {
                    if (i < 10)
                    {
                        bySlabNo = "0" + bySlabNo + 1;
                    }
                    else
                    {
                        bySlabNo = bySlabNo + 1;
                    }

                    NEWSLABNO = SALENO + bySlabNo;

                }
                else
                {
                    NEWSLABNO = bySlabNo.Substring(0, 4) + bySlabNo.Substring(4, 6) + i;

                    //考虑到字符截取超过范围会报错的问题，此处采用字符串长度来判断拼接
                    if (NEWSLABNO.Length == 9)
                    {
                        NEWSLABNO = NEWSLABNO.Substring(0, 4) + "0" + NEWSLABNO.Substring(4, 5);
                    }
                    else if (NEWSLABNO.Length == 8)
                    {
                        NEWSLABNO = NEWSLABNO.Substring(0, 4) + "00" + NEWSLABNO.Substring(4, 4);
                    }
                    else if (NEWSLABNO.Length == 6)
                    {
                        NEWSLABNO = NEWSLABNO.Substring(0, 4) + "000" + NEWSLABNO.Substring(4, 3);
                    }
                }
                ///''MODIFIED BY GUOLI AT 20080301
                if (txt_new_slab_no.Enabled)
                {
                    ss1.ActiveSheet.Cells[row, col].Value = NEWSLABNO;
                }

                col = 1;
                ss1.ActiveSheet.Cells[row, col].Value = txt_old_slabno.Text;

                col = 2;
                ss1.ActiveSheet.Cells[row, col].Value = txt_thk.NumValue;
                tmThk = txt_thk.Text;

                col = 3;
                ss1.ActiveSheet.Cells[row, col].Value = txt_wid.NumValue;
                tmWid = txt_wid.Text;

                col = 4;
                ss1.ActiveSheet.Cells[row, col].Value = txt_len.NumValue;
                tmLen = txt_len.Text;

                col = 5;
                ss1.ActiveSheet.Cells[row, col].Value = txt_wgt.NumValue / txt_slabcnt.NumValue;
                tmWgt = tmWgt + Convert.ToDouble(ss1.ActiveSheet.Cells[row, col].Value);

                col = 6;
                ss1.ActiveSheet.Cells[row, col].Value = Convert.ToDouble(tmThk) * Convert.ToDouble(tmWid) * Convert.ToDouble(tmLen) * 7.85 / 1000000000;

                col = 7;
                ss1.ActiveSheet.Cells[row, col].Value = "";

                col = 8;
                ss1.ActiveSheet.Cells[row, col].Value = txt_act_stlgrd.Text;

                col = 9;
                ss1.ActiveSheet.Cells[row, col].Value = "";

                col = 10;
                ss1.ActiveSheet.Cells[row, col].Value = GeneralCommon.sUserID;

                col = 11;
                ss1.ActiveSheet.Cells[row, col].Value = txt_car_no.Text;

                col = 12;
                ss1.ActiveSheet.Cells[row, col].Value = txt_InPltCo.Text;


                if (txt_new_slab_no.Enabled)
                {
                    ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value = "新增";
                }
                else
                {
                    ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value = "删除";
                }
            }

        }

        private void comm_slab_Click(object sender, EventArgs e)
        {
            comm_slab_test();
            WGT_CAL();
        }


        private void NewKey_Creation()
        {
            string Mon;
            string HeatNo = "";
            string sQuery;
            string HeatSeq;


            if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
            {

                if (txt_cen.Text.Length == 2)
                {

                    if (txt_cen.Text != "07" && txt_cen.Text != "08" && txt_cen.Text != "09" && txt_cen.Text != "10" && txt_cen.Text != "11" && txt_cen.Text != "12")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("请输入年..!", "I", "");

                        txt_cen.Focus();

                        return;
                    }

                }

                sQuery = "          SELECT MAX(SUBSTR(SLAB_NO,1,8)) ";
                sQuery = sQuery + "   FROM NISCO.FP_SLAB ";

                if (opt_BuyCo1.Checked)
                {
                    sQuery = sQuery + "  WHERE SUBSTR(SLAB_NO,3,1)= 'A'";
                }
                else
                {
                    sQuery = sQuery + "  WHERE SUBSTR(SLAB_NO,3,1)= 'B'";
                }

                SALENO = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);


                if (SALENO.Length == 0)
                {
                    if (opt_BuyCo1.Checked)
                    {
                        SALENO = txt_cen.Text + "A" + "00001";
                    }
                    else
                    {
                        SALENO = txt_cen.Text + "B" + "00001";
                    }
                }
                else
                {
                    if (SALENO.Length >= 8)
                    {

                        HeatSeq = SALENO.Substring(3, 5) + 1;

                    }
                    else if (SALENO.Length >= 4)
                    {
                        HeatSeq = SALENO.Substring(3, SALENO.Length - 3) + 1;

                    }
                    else
                    {
                        HeatSeq = "1";

                    }
                    if (HeatSeq.Length == 1)
                    {
                        HeatSeq = "0000" + HeatSeq;
                    }
                    else if (HeatSeq.Length == 2)
                    {
                        HeatSeq = "000" + HeatSeq;
                    }
                    else if (HeatSeq.Length == 3)
                    {
                        HeatSeq = "00" + HeatSeq;
                    }
                    else if (HeatSeq.Length == 4)
                    {
                        HeatSeq = "0" + HeatSeq;
                    }

                    if (opt_BuyCo1.Checked)
                    {
                        SALENO = txt_cen.Text + "A" + HeatSeq;
                    }
                    else
                    {
                        SALENO = txt_cen.Text + "B" + HeatSeq;
                    }
                }

                txt_new_slab_no.Text = SALENO;

                return;

            }

            if (txt_cen.Text.Length == 2)
            {
                if (txt_cen.Text != "07" & txt_cen.Text != "08" & txt_cen.Text != "09" & txt_cen.Text != "10" & txt_cen.Text != "11" & txt_cen.Text != "12")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认年..!", "I", "");
                    txt_cen.Focus();
                    return;
                }
            }

            if (txt_mon.Text.Length == 2)
            {
                if (txt_mon.Text == "01" | txt_mon.Text == "02" | txt_mon.Text == "03" | txt_mon.Text == "04" | txt_mon.Text == "05" | txt_mon.Text == "06" | txt_mon.Text == "07" | txt_mon.Text == "08" | txt_mon.Text == "09" | txt_mon.Text == "10" | txt_mon.Text == "11" | txt_mon.Text == "12")
                {
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认月..!", "I", "");
                    txt_mon.Focus();
                    return;
                }
            }

            if (txt_heat.Text.Length == 1)
            {
                if (txt_heat.Text == "1" | txt_heat.Text == "2" | txt_heat.Text == "3")
                {
                }
                else
                {

                    GeneralCommon.Gp_MsgBoxDisplay("请确认转炉号(不是 1,2,3) ...!", "I", "");
                    txt_heat.Focus();

                    return;
                }
            }

            //Month check
            if (txt_mon.Text == "10")
            {
                Mon = "A";
            }
            else if (txt_mon.Text == "11")
            {
                Mon = "B";
            }
            else if (txt_mon.Text == "12")
            {
                Mon = "C";
            }
            else
            {
                Mon = txt_mon.Text.Substring(1, 1);
            }

            //Heat no check
            if (txt_heat.Text == "1")
            {
                HeatNo = "4";
            }
            else if (txt_heat.Text == "2")
            {
                HeatNo = "5";
            }
            else if (txt_heat.Text == "3")
            {
                HeatNo = "6";
            }

            txt_old_slabno.Text = txt_mon.Text + "-" + txt_heat.Text + "-" + txt_seq.Text;
            txt_new_slab_no.Text = txt_cen.Text + HeatNo + Mon + txt_seq.Text;

            if (txt_new_slab_no.Text.Trim().Length == 8)
            {
                cmd_get_info_Click();
            }

        }



        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2090NC";
            Form_Define();

            opt_BuyCo0.Checked = true;
            label52.Visible = false;
            txt_InPltCo.Visible = false;
            txt_InPltCoDesc.Visible = false;
            txt_OldSlabNo2.Visible = false;
            label6.Visible = false;
            txt_seq.Visible = false;
            txt_InPltCo.sSqletc = "SELECT  CUST_CD \"客户代码\", CUST_NM \"客户名称\", CUST_NM_ENG \"客户英文名称\" FROM NISCO.BP_CUST_CD  WHERE CUST_CD LIKE '%' AND CUST_TYP  IN ('Z','P')";

            txt_cen.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT SUBSTR(TO_CHAR(SYSDATE,'YYYY'),3,2) FROM DUAL");


        }
        #endregion


        public override void Form_Ref()
        {
            int ForCnt;
            int ChkVal;

            firstFL = "";
            
            if (txt_new_slab_no.Text.Trim().Length < 8)
            {
                GeneralCommon.Gp_MsgBoxDisplay("确认Heat_no 不够8位", "I", "");
                return;
            }

            if (p_Ref(1, 0, true, true))
            {

                //firstFL = "Y";
                comm_slab.Enabled = false;

            }

            CHEMISTRY_DISP();

            if (p_Ref(1, 1, true, true))
            {

                firstFL = "Y";
                comm_slab.Enabled = false;

            }

            ChkVal = 0;
            for (ForCnt = 1; ForCnt <= ss1.ActiveSheet.RowCount; ForCnt++)
            {
                if (ss1.ActiveSheet.Cells[ForCnt-1,7].Value == "使用完")
                {
                    ChkVal = ChkVal + 1;
                }
            }

            if (ChkVal > 0)
            {
                SpreadCommon.Gp_Sp_BlockLock(ss1, 0, ss1.ActiveSheet.ColumnCount-1, 0, ss1.ActiveSheet.RowCount-1, true);
            }

            if (ss1.ActiveSheet.RowCount > 0)
            {
                txt_slabcnt.NumValue = ss1.ActiveSheet.RowCount;
            }    
           
        }


        public void WGT_CAL()
        {
            double tmThk;
            double tmWid;
            double tmLen;
            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double sub_wgt;
            double tmp_rat;
            double tot_rate;

            int i;

            cal_wgt = 0;
            sub_wgt = 0;

            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }
            //1
            for (i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {

                tmThk = Convert.ToDouble(ss1.ActiveSheet.Cells[i-1, 2].Value);

                tmWid = Convert.ToDouble(ss1.ActiveSheet.Cells[i-1, 3].Value);

                tmLen = Convert.ToDouble(ss1.ActiveSheet.Cells[i-1, 4].Value); ;

                ss1.ActiveSheet.Cells[i-1, 6].Value = Math.Round((tmThk * tmWid * tmLen * 7.85) / 1000000000, 3);
                cal_wgt = cal_wgt + Math.Round((tmThk * tmWid * tmLen * 7.85) / 1000000000, 3);
            }

            sub_wgt = Convert.ToDouble(txt_wgt.NumValue);
            tot_rate = 0;
            //2
            for (i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {

                if (ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value.ToString() != "删除")
                {
                    tmp_rat = Convert.ToDouble(ss1.ActiveSheet.Cells[i-1, 6].Value) / cal_wgt;

                    tot_rate = tot_rate + tmp_rat;

                    ss1.ActiveSheet.Cells[i-1, 5].Value = Math.Round(txt_wgt.NumValue * tmp_rat, 3);
                }
            }
            //3
            for (i = 1; i <= ss1.ActiveSheet.RowCount-1; i++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value.ToString() != "删除")
                {
                    tmp_rat = Convert.ToDouble(ss1.ActiveSheet.Cells[i-1, 6].Value) / cal_wgt;

                    ss1.ActiveSheet.Cells[i-1, 5].Value = Math.Round(txt_wgt.NumValue * tmp_rat / tot_rate, 3);
                    sub_wgt = sub_wgt - Math.Round(txt_wgt.NumValue * tmp_rat / tot_rate, 3);
                }
            }


            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount-1, 5].Value = sub_wgt;
            //4
            for (i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {

                if (ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value.ToString() == "")
                {
                    ss1.ActiveSheet.RowHeader.Cells[i-1, 0].Value = "修改";
                }
            }
        }

        public override void Form_Pro()
        {
            int ForCnt;
            int ChkVal;
            int i;
            string NEWSLABNO;

            if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
            {
                NewKey_Creation();
                bySlabNo = "00";
            }



            for (i = 1; i <= txt_slabcnt.NumValue; i++)
            {

                if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
                {
                    if (i < 10)
                    {
                        bySlabNo = "0" + Convert.ToString((bySlabNo + 1));
                    }
                    else
                    {
                        bySlabNo = bySlabNo + 1;
                    }

                    NEWSLABNO = SALENO + bySlabNo;

                }

            }

            if (ss1.ActiveSheet.RowCount <= 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认子板坯号....!", "I", "");
                return;
            }
            if (txt_car_no.Text.Length == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入车辆号..!", "I", "");
                txt_car_no.Focus();
                return;
            }

            if (txt_act_stlgrd.Text.Trim().Length < 10)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认钢种代吗....!", "I", "");
                return;
            }

            if (txt_c.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认成分(C)....!", "I", "");
                return;
            }

            if (txt_mn.NumValue == 0)
            {

                GeneralCommon.Gp_MsgBoxDisplay("请确认成分(MN)....!", "I", "");
                return;
            }

            if (txt_p.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认成分(P)....!", "I", "");
                return;
            }

            if (txt_s.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认成分(S)....!", "I", "");
                return;
            }

            if (txt_si.NumValue == 0)
            {

                GeneralCommon.Gp_MsgBoxDisplay("请确认成分(SI)....!", "I", "");
                return;
            }

            p_pro(1, 1, true, true);

            ChkVal = 0;
            for (ForCnt = 1; ForCnt <= ss1.ActiveSheet.RowCount; ForCnt++)
            {
                if (ss1.ActiveSheet.Cells[ForCnt-1, 7].Value == "使用完")
                {
                    ChkVal = ChkVal + 1;
                }
            }

            if (ChkVal > 0)
            {
                SpreadCommon.Gp_Sp_BlockLock(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, 0, ss1.ActiveSheet.RowCount - 1, true);
            }

        }

        private void txt_act_stlgrd_TextChanged(object sender, EventArgs e)
        {
            if (txt_act_stlgrd.Text.Trim().Length < 10)
            {

                txt_act_stlgrd_dec.Text = "";
            }

            if (txt_act_stlgrd_dec.Text != "")
            {

                if (opt_BuyCo2.Checked)
                {

                    txt_c.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT CHEM_COMP_TGT FROM QP_NISCO_CHEM WHERE STLGRD = '" + txt_act_stlgrd.Text + "' AND CHEM_COMP_CD = 'C' ");
                    txt_mn.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT CHEM_COMP_TGT FROM QP_NISCO_CHEM WHERE STLGRD = '" + txt_act_stlgrd.Text + "' AND CHEM_COMP_CD = 'Mn' ");
                    txt_p.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT CHEM_COMP_TGT FROM QP_NISCO_CHEM WHERE STLGRD = '" + txt_act_stlgrd.Text + "' AND CHEM_COMP_CD = 'P' ");
                    txt_s.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT CHEM_COMP_TGT FROM QP_NISCO_CHEM WHERE STLGRD = '" + txt_act_stlgrd.Text + "' AND CHEM_COMP_CD = 'S' ");
                    txt_si.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT CHEM_COMP_TGT FROM QP_NISCO_CHEM WHERE STLGRD = '" + txt_act_stlgrd.Text + "' AND CHEM_COMP_CD = 'Si' ");

                }

            }

        }


      

        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_cen.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT SUBSTR(TO_CHAR(SYSDATE,'YYYY'),3,2) FROM DUAL");
            txt_act_stlgrd_dec.Text = "";
            comm_slab.Enabled = true;
            opt_BuyCo0.Checked = true;
            return true;

        }

        public override void Spread_Del()
        {
            base.Spread_Del();

            WGT_CAL();


        }

        private void opt_BuyCo2_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_BuyCo2.Checked)
            {
                txt_InPltCo.sSqletc = "SELECT  CUST_CD \"客户代码\", CUST_NM \"客户名称\", CUST_NM_ENG \"客户英文名称\" FROM NISCO.BP_CUST_CD  WHERE CUST_CD LIKE '%' AND CUST_TYP  IN ('Z','B')";

            }
            else
            {
                txt_InPltCo.sSqletc = "SELECT  CUST_CD \"客户代码\", CUST_NM \"客户名称\", CUST_NM_ENG \"客户英文名称\" FROM NISCO.BP_CUST_CD  WHERE CUST_CD LIKE '%' AND CUST_TYP  IN ('Z','P')";

            }
        }

        private void opt_BuyCo0_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_BuyCo0.Checked)
            {
                label52.Visible = false;
                txt_InPltCo.Visible = false;
                txt_InPltCoDesc.Visible = false;
                txt_OldSlabNo2.Visible = false;
                label6.Visible = false;
                txt_seq.Visible = false;
            }
            else
            {
                label52.Visible = true;
                txt_InPltCo.Visible = true;
                txt_InPltCoDesc.Visible = true;
                txt_OldSlabNo2.Visible = true;
                label6.Visible = true;
                txt_seq.Visible = true;

            }
        }

        public void Get_OldSms_Info()
        {
            string tmHeatNo;
            string sQuery;
            sQuery = "          SELECT HEAT_NO ";
            sQuery = sQuery + "   FROM NISCO.FP_CHARGE ";
            sQuery = sQuery + "  WHERE HEAT_NO LIKE '" + txt_new_slab_no.Text.Trim() + "%'";

            tmHeatNo = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, sQuery).ToString();
            if (tmHeatNo.Trim() != "0")
            {
                return;
            }

            sQuery = "SELECT * FROM NISCO.GP_OLDSMSCHEMIF  WHERE NEW_HEAT_NO = '" + txt_new_slab_no.Text.Trim() + "'";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            //bool RltValue = false;

            try
            {
                
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                //bool RltValue = false;

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        txt_act_stlgrd_dec.Text = AdoRs.Fields[5].Value.ToString();
                        txt_thk.NumValue = Convert.ToDouble(AdoRs.Fields[6].Value);
                        txt_wid.NumValue = Convert.ToDouble(AdoRs.Fields[7].Value);
                        txt_len.NumValue = Convert.ToDouble(AdoRs.Fields[8].Value);
                        txt_wgt.NumValue = Convert.ToDouble(AdoRs.Fields[9].Value);
                        txt_slabcnt.NumValue = Convert.ToDouble(AdoRs.Fields[10].Value);

                        txt_car_no.Text = AdoRs.Fields[13].Value == "" ? "0" : AdoRs.Fields[13].Value.ToString();
                        txt_c.NumValue = AdoRs.Fields[14].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[14].Value);
                        txt_si.NumValue = AdoRs.Fields[15].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[15].Value);
                        txt_mn.NumValue = AdoRs.Fields[16].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[16].Value);
                        txt_p.NumValue = AdoRs.Fields[17].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[17].Value);
                        txt_s.NumValue = AdoRs.Fields[18].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[18].Value);
                        txt_cu.NumValue = AdoRs.Fields[19].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[19].Value);
                        txt_alt.NumValue = AdoRs.Fields[20].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[20].Value);
                        txt_als.NumValue = AdoRs.Fields[21].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[21].Value);
                        txt_b.NumValue = AdoRs.Fields[22].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[22].Value);
                        txt_ni.NumValue = AdoRs.Fields[23].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[23].Value);
                        txt_cr.NumValue = AdoRs.Fields[24].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[24].Value);
                        txt_mo.NumValue = AdoRs.Fields[25].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[25].Value);
                        txt_w.NumValue = AdoRs.Fields[26].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[26].Value);
                        txt_ti.NumValue = AdoRs.Fields[27].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[27].Value);
                        txt_v.NumValue = AdoRs.Fields[28].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[28].Value);
                        txt_zr.NumValue = AdoRs.Fields[29].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[29].Value);
                        txt_pb.NumValue = AdoRs.Fields[30].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[30].Value);
                        txt_sn.NumValue = AdoRs.Fields[31].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[31].Value);
                        txt_as.NumValue = AdoRs.Fields[32].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[32].Value);
                        txt_ca.NumValue = AdoRs.Fields[33].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[33].Value);
                        txt_co.NumValue = AdoRs.Fields[34].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[34].Value);
                        txt_mg.NumValue = AdoRs.Fields[35].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[35].Value);
                        txt_te.NumValue = AdoRs.Fields[36].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[36].Value);
                        txt_bi.NumValue = AdoRs.Fields[37].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[37].Value);
                        txt_sb.NumValue = AdoRs.Fields[38].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[38].Value);
                        txt_zn.NumValue = AdoRs.Fields[39].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[39].Value);
                        txt_nb.NumValue = AdoRs.Fields[40].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[40].Value);
                        txt_ceq.NumValue = AdoRs.Fields[41].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[41].Value);
                        txt_re.NumValue = AdoRs.Fields[42].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[42].Value);
                        txt_ta.NumValue = AdoRs.Fields[43].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[43].Value);
                        txt_n.NumValue = AdoRs.Fields[44].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[44].Value);
                        txt_h.NumValue = AdoRs.Fields[45].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[45].Value);
                        txt_o.NumValue = AdoRs.Fields[46].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[46].Value);
                        txt_se.NumValue = AdoRs.Fields[47].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[47].Value);
                        txt_pcm.NumValue = AdoRs.Fields[48].Value == "" ? 0 : Convert.ToDouble(AdoRs.Fields[48].Value);

                        AdoRs.MoveNext();
                    }

                    comm_slab_test();
                }

            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                //RltValue = false;
                GeneralCommon.Gp_MsgBoxDisplay("数据读取失败" + ex.Message, "", "");
            }


        }

        private void CHEMISTRY_DISP()
        {
            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return;

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            string sQuery;
            sQuery = "SELECT ELEMENT_CD, ELEMENT_VAL FROM NISCO.FP_CHEMISTRY WHERE HEAT_NO = '" + txt_new_slab_no.Text + "' ORDER BY SEQ_NO ";
            try
            {

                
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                //bool RltValue = false;

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {

                        switch (AdoRs.Fields[0].Value.ToString())
                        {

                            case "C":
                                txt_c.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Mn":
                                txt_mn.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "P":
                                txt_p.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "S":
                                txt_s.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Si":
                                txt_si.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Ceq":
                                txt_ceq.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Nb":
                                txt_nb.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Cu":
                                txt_cu.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "V":
                                txt_v.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Cr":
                                txt_cr.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Ni":
                                txt_ni.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Alt":
                                txt_alt.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Mo":
                                txt_mo.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Ti":
                                txt_ti.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "W":
                                txt_w.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "B":
                                txt_b.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Re":
                                txt_re.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Pb":
                                txt_pb.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Ca":
                                txt_ca.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "N":
                                txt_n.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "H":
                                txt_h.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "O":
                                txt_o.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Als":
                                txt_als.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Zr":
                                txt_zr.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Mg":
                                txt_mg.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Sn":
                                txt_sn.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "As":
                                txt_as.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Co":
                                txt_co.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Te":
                                txt_te.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Bi":
                                txt_bi.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Sb":
                                txt_sb.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Zn":
                                txt_zn.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Se":
                                txt_se.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Ta":
                                txt_ta.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                            case "Pcm":
                                txt_pcm.NumValue = Convert.ToDouble(AdoRs.Fields[1].Value);
                                break;
                        }

                        AdoRs.MoveNext();
                    }


                }

                sQuery = "          SELECT STEEL_NET_WGT ";
                sQuery = sQuery + "   FROM NISCO.FP_CHARGE ";
                sQuery = sQuery + "  WHERE HEAT_NO LIKE '" + txt_new_slab_no.Text.Trim() + "%'";

                txt_wgt.NumValue = 0;
                txt_wgt.NumValue = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, sQuery);
                txt_slabcnt.Text = ss1.ActiveSheet.RowCount.ToString();

            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                //RltValue = false;
                GeneralCommon.Gp_MsgBoxDisplay("数据读取失败" + ex.Message, "", "");
            }
        }

        private void txt_car_no_KeyUp(object sender, KeyEventArgs e)
        {
            int i;
            for (i = 1; i <= txt_slabcnt.NumValue; i++)
            {
                //ss1.ROW = i;
                //ss1.Col = 12;
                ss1.ActiveSheet.Cells[i - 1, 11].Value = txt_car_no.Text;
            }
        }

        private void txt_cen_TextChanged(object sender, EventArgs e)
        {
            if (txt_cen.Text.Length == 2 & (opt_BuyCo1.Checked | opt_BuyCo2.Checked))
            {
                NewKey_Creation();
                //txt_mon.SetFocus
            }
        }


        private void txt_heat_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_heat.Text.Length == 1)
            {

                txt_seq.Focus();
                NewKey_Creation();
            }
        }

        private void txt_mon_TextChanged(object sender, EventArgs e)
        {
            if (txt_mon.Text.Length == 2)
            {
                NewKey_Creation();
                txt_heat.Focus();
            }
        }

        private void txt_OldSlabNo2_TextChanged(object sender, EventArgs e)
        {
            txt_old_slabno.Text = txt_OldSlabNo2.Text;
        }

        private void txt_seq_TextChanged(object sender, EventArgs e)
        {
            if (txt_seq.Text.Length == 4)
            {
                NewKey_Creation();
                txt_act_stlgrd.Focus();
            }
        }

        private void txt_seq_Leave(object sender, EventArgs e)
        {
            if (txt_mon.Text.Length == 2 & txt_heat.Text.Length == 1)
            {
                if (txt_seq.Text.Length < 4)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认顺序号码 ...!", "", "");
                    txt_seq.Focus();
                    
                }
            }
        }

        private void txt_slabcnt_TextChanged(object sender, EventArgs e)
        {
            if (opt_BuyCo1.Checked || opt_BuyCo2.Checked)
            {
                txt_wgt.Text = (txt_thk.NumValue * txt_wid.NumValue * txt_len.NumValue * txt_slabcnt.NumValue * 7.85 / 1000000000).ToString();
            }
        }


    }
}