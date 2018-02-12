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
    public partial class CGA2080C : CommonClass.FORMBASE
    {
        public CGA2080C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();

        //dother slab no
        public string cSlabno;
        public double cSlabthk;
        public double cSlabwid;
        //Mother Slab Length
        public double cSlabLen;
        //Mother Slab Wgt
        public double cSlabWgt;
        //Mother Slab Cal Wgt
        public double cSlabCalWgt;
        public string cStlgrd;
        public string cOrdno;
        public string cProddate;
        public string cLoc;
        public string cRcvDate;
        public double tmWgt;
        public string tmpSlabNo;
        public string NEWSLABNO;
        public double cfLen;
        public double cfWgt;
        public double cfCalWgt;
        public string addSlabNo;
        public long lCurrRow;
        public string SCRAP_NO;

        string sQuery;

        const int SS2_BLOCK_SEQ = 1;
        const int SS1_URGNT_FL = 24;
        //Add by LiQian at 2012-08-30 是否紧急订单
        const int SS3_IMP_CONT = 19;
        const int SS3_SLAB_NO = 0;

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            p_SetMc("标志", txt_Status, "P", "", "", "", "", 1);//0
            p_SetMc("钢种", txt_act_stlgrd, "P", "", "", "", "", 1);//1
            p_SetMc("母板坯号", txt_MOSLAB, "P", "", "", "", "", 1);//2
            p_SetMc("垛位号", txt_LOC, "P", "", "", "", "", 1);//3
            p_SetMc("工厂", txt_plt, "P", "", "", "", "", 1);//4
          //  p_SetMc("工厂详细", txt_plt_dec, "", "", "", "", "", 1);
            p_SetMc("厚度", txt_thk, "P", "", "", "", "", 1);//5
            p_SetMc("厚度2", txt_thk_to, "P", "", "", "", "", 1);//6
            p_SetMc("宽度", txt_wid, "P", "", "", "", "", 1);//7
            p_SetMc("宽度2", txt_wid_to, "P", "", "", "", "", 1);//8
            p_SetMc("长度", txt_len, "P", "", "", "", "", 1);//9
            p_SetMc("长度2", txt_len_to, "P", "", "", "", "", 1);//10
            p_SetMc("交货期开始", U_FROM_DATE, "P", "", "", "", "", 1);//11
            p_SetMc("交货期结束", U_TO_DATE, "P", "", "", "", "", 1);//12

            

            p_ScIni(ss1, Sc1, 0, true, false);

            p_SetSc("板坯号", "E", "", "L", "", "", "", 1, 0, "M");//0
            p_SetSc("坯料类别", "E", "", "L", "", "", "", 1, 0, "M");//1
            p_SetSc("母板坯号", "E", "", "L", "", "", "", 1, 0);//2
            p_SetSc("坯料生产厂", "E", "", "L", "", "", "", 1, 0,"M");//3
            p_SetSc("钢种", "E", "", "L", "", "", "", 1, 0);//4
            p_SetSc("厚度", "N", "6", "L", "", "", "", 1, 0);//5
            p_SetSc("宽度", "N", "6", "L", "", "", "", 1, 0);//6
            p_SetSc("长度", "N", "10", "L", "", "", "", 1, 0);//7
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 1, 0);//8
            p_SetSc("理论重量", "N", "8,3", "L", "", "", "", 1, 0);//9
            p_SetSc("切割指示数量", "E", "", "L", "", "", "", 1, 0, "M");//10
            p_SetSc("垛位号", "E", "", "L", "", "", "", 1, 0, "M");//11
            p_SetSc("计划切割结束时间", "DT", "", "L", "", "", "", 1, 0, "M");//12
            p_SetSc("切割计划生成结束时间", "DT", "", "L", "", "", "", 1, 0, "M");//13
            p_SetSc("指示人员", "E", "", "L", "", "", "", 1, 0);//14
            p_SetSc("状态", "E", "", "L", "", "", "", 1, 0, "M");//15
            p_SetSc("切割工厂", "E", "", "L", "", "", "", 1, 0, "M");//16
            p_SetSc("指示日期", "E", "", "L", "", "", "", 1, 0, "M");//17
            p_SetSc("订单材/余材", "E", "", "L", "", "", "", 1, 0, "M");//18
            p_SetSc("定尺类别", "E", "", "L", "", "", "", 1, 0, "M");//19
            p_SetSc("订单号", "E", "", "L", "", "", "", 1, 0, "M");//20
            p_SetSc("订单规格", "E", "", "L", "", "", "", 1, 0,"M");//21
            p_SetSc("订单标准号", "E", "", "L", "", "", "", 1, 0, "M");//22
            p_SetSc("最早日期", "E", "", "L", "", "", "", 1, 0);//23
            p_SetSc("是否紧急订单", "E", "", "L", "", "", "", 1, 0, "M");//24


            p_McIni(Mc2, false);
            p_SetMc("隐藏1", txt_tmpPLT, "P", "", "", "", "", 2);
            p_SetMc("隐藏2", txt_IST_DATE, "P", "", "", "", "", 2);
            p_SetMc("板坯号", TXT_SLABNO, "P", "", "", "", "", 2);
            
    

            p_ScIni(ss2, Sc2, 0, true, false);

            p_SetSc("子板坯号", "E", "", "PNIL", "", "", "", 2, 0);//0
            p_SetSc("厚度", "N", "6", "IL", "", "", "", 2, 0);//1
            p_SetSc("宽度", "N", "6", "IN", "", "", "", 2, 0);//2
            p_SetSc("长度", "N", "8", "IN", "", "", "", 2, 0);//3
            p_SetSc("重量", "N", "8,3", "INL", "", "", "", 2, 0);//4
            p_SetSc("理论重量", "N", "16,3", "IL", "", "", "", 2, 0);//5
            p_SetSc("切割日期", "D", "", "IN", "", "", "", 2, 0, "M");//6
            p_SetSc("切割时间", "T", "", "IN", "", "", "", 2, 0, "M");//7
            p_SetSc("表面等级", "E", "", "I", "", "", "", 2, 0);//8
            p_SetSc("垛位号", "E", "", "IL", "", "", "", 2, 0, "M");//9
            p_SetSc("作业人", "E", "", "INL", "", "", "", 2, 0, "M");//10
            p_SetSc("MoSlabNo", "E", "", "IL", "", "", "", 2, 0, "M");//11
            p_SetSc("LastStatus", "E", "", "IL", "", "", "", 2, 0, "M");//12
            p_SetSc("切割顺序", "E", "", "IL", "", "", "", 2, 0);//13
            p_SetSc("订单材/余材", "E", "10", "L", "", "", "", 2, 0);//14
            p_SetSc("订单信息", "E", "", "L", "", "", "", 2, 0);//15

            SpreadCommon.Gp_Sp_ColHidden(ss2, 5, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, 11, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, 12, true);

            p_ScIni(ss3, Sc3, 0, true, false);

            p_SetSc("板坯号", "E", "", "L", "", "", "", 3, 0, "M");//0
            p_SetSc("切割顺序", "E", "", "L", "", "", "", 3, 0, "M");//1
            p_SetSc("坯料生产厂", "E", "", "L", "", "", "", 3, 0, "M");//2
            p_SetSc("钢种", "E", "", "L", "", "", "", 3, 0, "L");//3
            p_SetSc("厚度", "E", "", "L", "", "", "", 3, 0, "R");//4
            p_SetSc("宽度", "E", "", "L", "", "", "", 3, 0, "R");//5
            p_SetSc("长度", "E", "", "L", "", "", "", 3, 0, "R");//6
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 3, 0, "R");//7
            p_SetSc("理论重量", "N", "8,3", "L", "", "", "", 3, 0, "R");//8
            p_SetSc("切割指示数量", "E", "", "L", "", "", "", 3, 0, "M");//9
            p_SetSc("垛位号", "E", "", "L", "", "", "", 3, 0, "L");//10
            p_SetSc("切割结束时间", "D", "", "L", "", "", "", 3, 0, "L");//11
            p_SetSc("切割计划生成时间", "DT", "", "L", "", "", "", 3, 0, "L");//12
            p_SetSc("指示人员", "E", "", "L", "", "", "", 3, 0, "L");//13
            p_SetSc("指示日期", "DT", "", "L", "", "", "", 3, 0, "L");//14
            p_SetSc("订单材/余材", "E", "", "L", "", "", "", 3, 0, "L");//15
            p_SetSc("订单号", "E", "", "L", "", "", "", 3, 0, "L");//16
            p_SetSc("订单规格", "E", "", "L", "", "", "", 3, 0, "L");//17
            p_SetSc("订单标准号", "E", "", "L", "", "", "", 3, 0, "L");//18
            p_SetSc("重点订单", "E", "", "L", "", "", "", 3, 0, "M");//19

            p_ScIni(ss4, Sc4, 0, true, false);

            p_SetSc("钢种", "E", "", "L", "", "", "", 4, 0, "L");//0
            p_SetSc("厚度", "E", "", "L", "", "", "", 4, 0, "R");//1
            p_SetSc("宽度", "E", "", "L", "", "", "", 4, 0, "R");//2
            p_SetSc("长度", "E", "", "L", "", "", "", 4, 0, "R");//3
            p_SetSc("H/C", "E", "", "L", "", "", "", 4, 0, "M");//4
            p_SetSc("块数", "N", "8", "L", "", "", "", 4, 0, "R");//5
            p_SetSc("板坯重量", "N", "8,3", "L", "", "", "", 4, 0, "R");//6
            p_SetSc("订单号", "E", "", "L", "", "", "", 4, 0, "L");//7
            p_SetSc("序列", "E", "", "L", "", "", "", 4, 0, "M");//8
            p_SetSc("订单标准号", "E", "", "L", "", "", "", 4, 0, "L");//9
            p_SetSc("订单重量", "N", "8,3", "L", "", "", "", 4, 0, "R");//10
            p_SetSc("订单厚度", "N", "8,3", "L", "", "", "", 4, 0, "R");//11
            p_SetSc("订单宽度", "N", "8,3", "L", "", "", "", 4, 0, "R");//12
            p_SetSc("订单长度", "N", "8,3", "L", "", "", "", 4, 0, "R");//13
            p_SetSc("备注", "E", "", "L", "", "", "", 4, 0, "L");//14
        
        }

        private void CGA2080C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2080NC";
            Form_Define();

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            txt_plt.Text = "B3";
            txt_plt_dec.Text = "老炼钢厂";
            txt_thk.NumValue = 150;
            txt_thk_to.NumValue = 320;
            txt_wid.NumValue = 1000;
            txt_wid_to.NumValue = 4000;
            txt_len.NumValue = 1000;
            txt_len_to.NumValue = 99999;

            U_FROM_DATE.RawDate = DateTime.Now.ToString("yyyyMM") + "01";
            U_TO_DATE.RawDate = DateTime.Now.ToString("yyyyMMdd");

            txt_Status.Text = "1";

            if (substr(sAuthority, 0, 3) == "111")
            {
                cmd_Cancel.Enabled = true;
            }
            else
            {
                cmd_Cancel.Enabled = false;
            }
        }

        public override void Spread_Ins()
        {
            if (ss2.ActiveSheet.ActiveRowIndex == ss2.ActiveSheet.RowCount-1)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[ss2.ActiveSheet.RowCount-1,0].Text != "删除")
                {

                    base.Spread_Ins();

                    INS_WGT_CAL();
                }
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
            double tmp_rat;
            double tmTotalLen = 0;
            double tmpLen;
            double sub_wgt = 0;
            double sub_len;
            double tmCalCut = 0;
            double tmCalMo;
            double tmCalCutOne;

            int i;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            tmCalMo = cSlabthk * cSlabwid * cSlabLen;

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmThk = convertX(ss2.ActiveSheet.Cells[i,1].Text);
                    tmWid = convertX(ss2.ActiveSheet.Cells[i,2].Text);
                    tmLen = convertX(ss2.ActiveSheet.Cells[i,3].Text);
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i, 3].Text);

                    tmCalCut = tmCalCut + (tmThk * tmWid * tmLen);
                }
            }

            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);
                    tmWid = convertX(ss2.ActiveSheet.Cells[i - 1, 2].Text);
                    tmLen = convertX(ss2.ActiveSheet.Cells[i - 1, 3].Text);

                    tmCalCutOne = tmThk * tmWid * tmLen;

                    if (tmCalCut <= tmCalMo)
                    {
                        tempWgt = tempWgt + Math.Round((cSlabWgt * (tmCalCutOne / tmCalMo)), 3);
                        sub_wgt = sub_wgt - Math.Round((cSlabWgt * (tmCalCutOne / tmCalMo)), 3);
                        ss2.ActiveSheet.Cells[i-1,4].Text = Math.Round((cSlabWgt * (tmCalCutOne / tmCalMo)), 3).ToString();
                    }
                    else
                    {
                        tempWgt = tempWgt + Math.Round((cSlabWgt * (tmCalCutOne / tmCalCut)), 3);
                        sub_wgt = sub_wgt - Math.Round((cSlabWgt * (tmCalCutOne / tmCalCut)), 3);
                        ss2.ActiveSheet.Cells[i-1,4].Text = Math.Round((cSlabWgt * (tmCalCutOne / tmCalCut)), 3).ToString();
                    }

                    ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();
                }
            }

            if (tmCalCut == tmCalMo)
            {
                sub_len = cSlabLen;
                sub_wgt = cSlabWgt;
                for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
                {
                    if (i < ss2.ActiveSheet.RowCount)
                    {
                        sub_wgt = sub_wgt - convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                    }
                }

                ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,4].Text = sub_wgt.ToString();
            }


            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);
                    tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                }

            }

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text == "")
                {
                    ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text = "修改";
                }
            }


            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if (convertX(txt_total_wgt.Text) - cSlabWgt == 0)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }

            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }
        }

        public void INS_WGT_CAL()
        {
            double tmThk;
            double tmWid;
            double tmLen;
            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double tmp_rat;
            double tmTotalLen;
            double tmpLen;
            double sub_wgt =0;
            double sub_len;
            string S1;
            double S2;
            double S3;
            double S4;
            double S5;
            double S6;
            string S7;
            string S8;
            string S9;
            string S10;
            string S11;
            string S12;

            int i;
            int delete_cnt;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            delete_cnt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    delete_cnt = delete_cnt + 1;
                }
            }

            cfLen = cSlabLen / ss2.ActiveSheet.RowCount;
            cfWgt = Math.Round(cSlabWgt / ss2.ActiveSheet.RowCount, 3);
            cfCalWgt = Math.Round(cSlabCalWgt / ss2.ActiveSheet.RowCount, 3);

            // DATA COPY

            S1 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-2,0].Text;

            S2 = convertX(ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 1].Text);

            S3 = convertX(ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 2].Text);

            S4 = convertX(ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 3].Text);

            S5 = convertX(ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 4].Text);

            S6 = convertX(ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 5].Text);

            S7 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 6].Text;

            S8 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 7].Text;

            S9 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 8].Text;

            S10 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 9].Text;

            S11 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 10].Text;

            S12 = ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 2, 11].Text;

            // DATA PAST
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,0].Text = addSlabNo;
            addSlabNo = substr(addSlabNo, 0, 8) + Convert.ToString(Convert.ToInt32(substr(addSlabNo, 8, 2)) + 1);
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,1].Text = S2.ToString();
            tmThk = S2;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 2].Text = S3.ToString();
            tmWid = S3;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 3].Text = S4.ToString();
            tmLen = S4;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 4].Text = S5.ToString();
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 5].Text = S6.ToString();
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 6].Text = S7;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 7].Text = S8;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 8].Text = S9;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 9].Text = S10;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 10].Text = S11;
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 11].Text = S12;

            tmp_rat = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                ss2.ActiveSheet.Cells[i-1,3].Text = (cSlabLen / ss2.ActiveSheet.RowCount).ToString();
                ss2.ActiveSheet.Cells[i-1,4].Text = Math.Round(cSlabWgt * ((cSlabLen / ss2.ActiveSheet.RowCount) / cSlabLen), 3).ToString();
                tempWgt = tempWgt + Math.Round(cSlabWgt * ((cSlabLen / ss2.ActiveSheet.RowCount) / cSlabLen), 3);
                sub_wgt = sub_wgt - Math.Round(cSlabWgt * ((cSlabLen / ss2.ActiveSheet.RowCount) / cSlabLen), 3);

                ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();
            }

            sub_len = cSlabLen;
            sub_wgt = cSlabWgt;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (i != ss2.ActiveSheet.RowCount)
                {
                    sub_len = sub_len - convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                    sub_wgt = sub_wgt -  convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                }
            }
            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,3].Text = sub_len.ToString();

            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount - 1, 4].Text = sub_wgt.ToString();

            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                tmTotalLen = convertX(tmTotalLen + ss2.ActiveSheet.Cells[i-1,3].Text);

                tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

            }

            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if (Convert.ToDouble(txt_total_wgt) == cSlabWgt)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }


            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }



            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text == "")
                {
                    ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text = "修改";
                }
            }

        }

        public void DEL_WGT_CAL()
        {
            double tmThk;
            double tmWid;
            double tmLen;
            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double tmp_rat;
            double tmTotalLen = 0;
            double tmpLen;
            double sub_wgt;
            double sub_len;


            int i;
            int delete_cnt;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            delete_cnt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    delete_cnt = delete_cnt + 1;
                }
            }

            cfLen = cSlabLen / delete_cnt;
            cfWgt = Math.Round(cSlabWgt / delete_cnt, 3);
            cfCalWgt = Math.Round(cSlabCalWgt / delete_cnt, 3);


            tempWgt = 0;
            for (i = 1; i <= delete_cnt; i++)
            {
                tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);

                tmWid = convertX(ss2.ActiveSheet.Cells[i-1,2].Text);

                ss2.ActiveSheet.Cells[i-1,3].Text = cfLen.ToString();
                tmLen = cfLen;

                if (i == ss2.ActiveSheet.RowCount)
                {
                    ss2.ActiveSheet.Cells[i-1,3].Text = (cSlabLen - tmTotalLen).ToString();
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);
                }
                else
                {
                    ss2.ActiveSheet.Cells[i-1,3].Text = cfLen.ToString();
                    tmLen = cfLen;
                    tmTotalLen = tmTotalLen + cfLen;
                }

                ss2.ActiveSheet.Cells[i-1,4].Text = cfWgt.ToString();
                tmWgt = tmWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

                ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();
            }

            sub_len = cSlabLen;
            sub_wgt = cSlabWgt;
            for (i = 1; i <= delete_cnt; i++)
            {
                if (i != delete_cnt)
                {
                    sub_len = sub_len - convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                    sub_wgt = sub_wgt - convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                }
            }
            ss2.ActiveSheet.Cells[delete_cnt-1,3].Text = sub_len.ToString();

            ss2.ActiveSheet.Cells[delete_cnt - 1, 4].Text = sub_wgt.ToString();

            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= delete_cnt; i++)
            {
                tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

            }

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text == "")
                {
                    ss2.ActiveSheet.RowHeader.Cells[i - 1, 0].Text = "修改";
                }
            }

            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if ( convertX(txt_total_wgt.Text) == cSlabWgt)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }

            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }
        }

        public void CANCEL_WGT_CAL()
        {
            double tmThk;
            double tmWid;
            double tmLen;
            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double tmp_rat;
            double tmTotalLen;
            double tmpLen;
            double sub_wgt;
            double sub_len;
            int i;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            tmTotalLen = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                ss2.ActiveSheet.Cells[i-1,3].Text = (cSlabLen / ss2.ActiveSheet.RowCount).ToString();
                tmLen = cSlabLen / ss2.ActiveSheet.RowCount;
                tmTotalLen = tmTotalLen + tmLen;

            }

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);

                tmWid = convertX(ss2.ActiveSheet.Cells[i-1,2].Text);

                tmLen = convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                ss2.ActiveSheet.Cells[i-1,4].Text =Math.Round(cSlabWgt * (tmLen / tmTotalLen), 3).ToString();

                ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();
            }

            sub_len = cSlabLen;
            sub_wgt = cSlabWgt;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (i != ss2.ActiveSheet.RowCount)
                {
                    sub_len = sub_len - convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                    sub_wgt = sub_wgt - convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                }
            }

            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,3].Text = sub_len.ToString();

            ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,4].Text = sub_wgt.ToString();

            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

            }
            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if (Convert.ToDouble(txt_total_wgt) == cSlabWgt)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }

            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }

        }

        public void LENMODIFY_WGT_CAL(long Col, long ROW)
        {
            double tmThk;
            double tmWid;
            double tmLen;
            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double tmp_rat;
            double tmTotalLen = 0;
            double tmpLen;
            double sub_wgt = 0;
            double sub_len;
            int i;

            double tmCalCut = 0;
            double tmCalMo;
            double tmCalCutOne;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            tmCalMo = cSlabthk * cSlabwid * cSlabLen;

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);
                }
            }

            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);
                    tmWid = convertX(ss2.ActiveSheet.Cells[i-1,2].Text);
                    tmLen = convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                    tmCalCut = tmCalCut + (tmThk * tmWid * tmLen);
                }
            }

            tmp_rat = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);
                tmWid = convertX(ss2.ActiveSheet.Cells[i-1,2].Text);
                tmLen = convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                tmCalCutOne = tmThk * tmWid * tmLen;

                if (tmCalCut <= tmCalMo)
                {
                    tempWgt = tempWgt + Math.Round((cSlabWgt * (tmCalCutOne / tmCalMo)), 3);
                    sub_wgt = sub_wgt - Math.Round((cSlabWgt * (cfLen / cSlabLen)), 3);
                    ss2.ActiveSheet.Cells[i-1,4].Text = Math.Round((cSlabWgt * (tmCalCutOne / tmCalMo)), 3).ToString();
                }
                else
                {
                    tempWgt = tempWgt + Math.Round((cSlabWgt * (tmCalCutOne / tmCalCut)), 3);
                    sub_wgt = sub_wgt - Math.Round((cSlabWgt * (cfLen / tmTotalLen)), 3);
                    ss2.ActiveSheet.Cells[i - 1, 4].Text = Math.Round((cSlabWgt * (tmCalCutOne / tmCalCut)), 3).ToString();
                }

                ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();
            }


            if (tmCalCut >= tmCalMo)
            {
                sub_len = cSlabLen;
                sub_wgt = cSlabWgt;
                for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
                {
                    if (i != ss2.ActiveSheet.RowCount)
                    {
                        sub_wgt = sub_wgt - convertX(ss2.ActiveSheet.Cells[i-1,4].Text);
                    }
                }

                ss2.ActiveSheet.Cells[ss2.ActiveSheet.RowCount-1,4].Text = sub_wgt.ToString();
            }


            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

            }

            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if (Convert.ToDouble(txt_total_wgt) == cSlabWgt)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }

            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }

        }



        public override void Form_Ref()
        {
            int ForCnt;
            long tmWgt;
            long tmLen;

            int lRow;
            string sBlockSeq;
            int iRow;
            int i;
            string TIME;

            string sUrgnt_Fl;
            string simpcont;

            if (txt_MOSLAB.Text.Trim().Length != 0)
            {
                if (txt_MOSLAB.Text.Length < 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认母板坯号", "I", "提示");
                    txt_MOSLAB.Focus();
                    return;
                }
            }

            if (txt_MOSLAB.Text.Trim().Length != 8)
            {
                if (txt_plt.Text.Trim().Length == 0)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认工厂", "I", "提示");
                    txt_plt.Focus();
                    return;
                }
            }

            if (txt_len.NumValue <= 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认长度范围", "I", "提示");
                txt_len.Focus();
                return;
            }

            TXT_SLABNO.Text = "";
            cbo_cutcnt.SelectedIndex = 0;
            txt_total_len.NumValue = 0;
            txt_total_wgt.NumValue = 0;
            txt_scrap_wgt.NumValue = 0;

            if (SSTab1.SelectedIndex == 0)
            {
                p_Ref(1, 1, true, true);
                SpreadCommon.Gf_Sp_Cls(Sc3);
                SpreadCommon.Gf_Sp_Cls(Sc4);

            }
            else if (SSTab1.SelectedIndex == 1)
            {

                if (txt_Status.Text == "2")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请正确选择处理分类", "I", "提示");
                    return;
                }

                p_Ref(1, 3, true, true);
                SpreadCommon.Gf_Sp_Cls(Sc1);
                SpreadCommon.Gf_Sp_Cls(Sc2);

                if (ss3.ActiveSheet.RowCount > 0)
                {

                    for (lRow = 1; lRow <= ss3.ActiveSheet.RowCount; lRow++)
                    {

                        sBlockSeq = ss3.ActiveSheet.Cells[lRow - 1, SS2_BLOCK_SEQ].Text;
                        simpcont = ss3.ActiveSheet.Cells[lRow - 1, SS3_IMP_CONT].Text;

                        if (sBlockSeq == "00")
                        {
                            Gp_Sp_BlockColor(ss3, 0, ss3.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP3.BackColor);
                        }
                        else
                        {
                            Gp_Sp_BlockColor(ss3, 0, ss3.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP1.BackColor);
                        }
                        //重点订单
                        if (simpcont == "Y")
                        {
                            Gp_Sp_BlockColor(ss3, SS3_SLAB_NO, SS3_SLAB_NO, lRow - 1, lRow - 1, SSP4.BackColor, Color.White);
                            Gp_Sp_BlockColor(ss3, SS3_IMP_CONT, SS3_IMP_CONT, lRow - 1, lRow - 1, SSP4.BackColor, Color.White);
                        }
                    }

                }

            }
            else if (SSTab1.SelectedIndex == 2)
            {

                if (txt_Status.Text == "2")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请正确选择处理分类", "I", "提示");
                    return;
                }

                p_Ref(1, 4, true, true);

                SpreadCommon.Gf_Sp_Cls(Sc1);
                SpreadCommon.Gf_Sp_Cls(Sc2);

            }

            TIME = DateTime.Now.ToString("yyyyMM");


            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {

                if (convertX(substr(ss1.ActiveSheet.Cells[iRow - 1, 23].Text, 0, 6)) < convertX(TIME))
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, Color.Red);
                }

                if (ss1.ActiveSheet.Cells[iRow - 1, 23].Text == "")
                {
                    break; // TODO: might not be correct. Was : Exit For
                }

                sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text;

                //紧急订单绿色显示 add by liqian 2012-08-30
                if (sUrgnt_Fl == "Y")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                }

            }
        }



        public override bool Form_Cls()
        {
            base.Form_Cls();

            txt_act_stlgrd_dec.Text = "";
            TXT_SLABNO.Text = "";
            txt_Status.Text = "1";
            cbo_cutcnt.SelectedIndex = 0;
            txt_total_len.NumValue = 0;
            txt_total_wgt.NumValue = 0;
            txt_scrap_wgt.NumValue = 0;

            opt_prc_status1_Click();

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            return true;
        }

        public override void Form_Pro()
        {
            int i;

            if (SSTab1.SelectedIndex == 0)
            {

                //ADD BY YIDUJUN AT 2010-12-21 检查子板坯号，为负则提示错误
                for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
                {
                    if (convertX(ss2.ActiveSheet.Cells[i-1,4].Text) < 0)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("请确认子板坯号 " + ss2.ActiveSheet.Cells[i-1,0].Text + " 的重量", "W", "错误提示");
                        return;
                    }

                }
                p_Pro(1, 2, true, true);
                //    Call Scrap_Pro   '''COMMENT BY GUOLI AT 20081026

                if (opt_prc_status1.Checked == true)
                {
                    Form_Ref();
                }
                if (opt_prc_status2.Checked == true)
                {
                    if (ss2.ActiveSheet.RowCount <= 0)
                    {
                        Form_Ref();
                    }
                }
            }
            else
            {
            }
        }

        public void Scrap_Pro()
        {
            string iType;
            if (txt_scrap_wgt.NumValue == 0)
            {
                iType = "D";
            }
            else
            {
                iType = "I";
            }

            string[] Para1 = new string[4];

            Para1[0] = iType;
            Para1[1] = SCRAP_NO;
            Para1[2] = txt_scrap_wgt.NumValue.ToString();
            Para1[3] = GeneralCommon.sUserID;

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGA2080NC.P_SCRAP", Para1))
            {

                GeneralCommon.Gp_MsgBoxDisplay("更新成功", "I", "系统提示信息");

            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("实绩处理失败，请确认", "I", "系统提示信息");
            }

        }



        # region 公共方法

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {   
                return Convert.ToDouble(value.Replace(",","."));
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
            }
            return 0;
        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion

        private void cbo_cutcnt_Click(object sender, EventArgs e)
        {
            int i;
            int j;

            double tmThk;
            double tmWid;
            double tmLen;
            double tmTotalLen = 0;
            double tmpLen;


            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double sub_wgt;
            double tmp_rat;

            if (TXT_SLABNO.Text == "")return;

            if (cbo_cutcnt.SelectedIndex == 0)return;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

            ss2.ActiveSheet.RowCount = convertI(cbo_cutcnt.Text);

            sQuery = "          SELECT MAX(SLAB_NO) ";
            sQuery = sQuery + "   FROM NISCO.FP_SLAB ";
            sQuery = sQuery + "  WHERE SLAB_NO LIKE '" + substr(cSlabno, 0, 8) + "%'";

            tmpSlabNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
            if (convertI(substr(tmpSlabNo, 8, 2)) < 30)
            {
                tmpSlabNo = substr(tmpSlabNo, 0, 8) + "30";
            }


            cfLen = cSlabLen / convertX(cbo_cutcnt.Text);
            cfWgt = Math.Round(cSlabWgt /convertX(cbo_cutcnt.Text), 3);
            cfCalWgt = Math.Round(cSlabCalWgt / convertX(cbo_cutcnt.Text), 3);

            for (i = 1; i <= convertX(cbo_cutcnt.Text); i++)
            {

                NEWSLABNO = substr(tmpSlabNo, 0, 4) + substr(tmpSlabNo, 4, 6) + i;
                if (substr(NEWSLABNO, 4, 6).Length == 5)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "0" + substr(NEWSLABNO, 4, 5);
                }
                else if (substr(NEWSLABNO, 4, 6).Length == 4)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "00" + substr(NEWSLABNO, 4, 5);
                }
                else if (substr(NEWSLABNO, 4, 6).Length == 3)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "000" + substr(NEWSLABNO, 4, 5);
                }

                ss2.ActiveSheet.Cells[i-1,0].Text = NEWSLABNO;

                ss2.ActiveSheet.Cells[i-1,1].Text = cSlabthk.ToString();
                tmThk = cSlabthk;

                ss2.ActiveSheet.Cells[i-1,2].Text = cSlabwid.ToString();
                tmWid = cSlabwid;

                if (i == ss2.ActiveSheet.RowCount)
                {
                    ss2.ActiveSheet.Cells[i-1,3].Text = (cSlabLen - tmTotalLen).ToString();
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i-1,3].Text);
                }
                else
                {
                    ss2.ActiveSheet.Cells[i-1,3].Text = cfLen.ToString();
                    tmLen = cfLen;
                    tmTotalLen = tmTotalLen + cfLen;
                }

                ss2.ActiveSheet.Cells[i-1,4].Text = cfWgt.ToString();
                tmWgt = tmWgt + convertX(ss2.ActiveSheet.Cells[i-1,4].Text);

                ss2.ActiveSheet.Cells[i-1,5].Text = cfCalWgt.ToString();

                ss2.ActiveSheet.Cells[i-1,6].Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYY-MM-DD') FROM DUAL");

                ss2.ActiveSheet.Cells[i-1,7].Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'HH24:MI') FROM DUAL");


                ss2.ActiveSheet.Cells[i-1,8].Text = cLoc;

                ss2.ActiveSheet.Cells[i-1,9].Text = GeneralCommon.sUserID;

                ss2.ActiveSheet.Cells[i-1,10].Text = TXT_SLABNO.Text;

                if (i == convertI(cbo_cutcnt.Text))
                {
                    ss2.ActiveSheet.Cells[i-1,11].Text = "Y";
                }
                else
                {
                    ss2.ActiveSheet.Cells[i-1,11].Text = "";
                }

                ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text = "增加";

            }
            SCRAP_NO = TXT_SLABNO.Text;

            WGT_CAL();

         
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {

            string[] Para1 = new string[2];

            Para1[0] = TXT_SLABNO.Text;
            Para1[1] = GeneralCommon.sUserID;

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGA2080NC.P_ORDCANCEL", Para1))
            {

                GeneralCommon.Gp_MsgBoxDisplay("更新成功", "I", "系统提示信息");

            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("实绩处理失败，请确认", "I", "系统提示信息");
            }
        }

        private void opt_prc_status1_Click()
        {
            if (opt_prc_status1.Checked == true)
            {
                cmd_Cancel.Visible = true;
            }

            if (opt_prc_status1.Tag != "")
            {
                opt_prc_status1.Tag = "";
                return;
            }

            if (SpreadCommon.Gf_Sp_Cls(Sc2) == false)
            {
                opt_prc_status2.Tag = "A";
                opt_prc_status2.Checked = true;
                txt_Status.Text = "2";
                return;
            }

            opt_prc_status1.Checked = true;

            opt_prc_status1.ForeColor = Color.Red;
            opt_prc_status2.ForeColor = Color.Black;

            SpreadCommon.Gf_Sp_Cls(Sc1);

            txt_Status.Text = "1";

            txt_act_stlgrd_dec.Text = "";
            txt_MOSLAB.Text = "";
            TXT_SLABNO.Text = "";
            cbo_cutcnt.Items.Clear();
            cbo_cutcnt.Items.Add("0");
            cbo_cutcnt.Items.Add("1");
            cbo_cutcnt.Items.Add("2");
            cbo_cutcnt.Items.Add("3");
            cbo_cutcnt.Items.Add("4");
            cbo_cutcnt.Items.Add("5");
            cbo_cutcnt.Items.Add("6");
            cbo_cutcnt.Items.Add("7");
            cbo_cutcnt.Items.Add("8");
            cbo_cutcnt.Items.Add("9");
            cbo_cutcnt.Items.Add("10");

            cbo_cutcnt.SelectedIndex = 0;
            txt_total_len.NumValue = 0;
            txt_total_wgt.NumValue = 0;
            txt_scrap_wgt.NumValue = 0;

            txt_plt.Text = "B3";
            txt_plt_dec.Text = "老炼钢厂";
            txt_thk.NumValue = 150;
            txt_thk_to.NumValue = 320;
            txt_wid.NumValue = 1000;
            txt_wid_to.NumValue = 4000;
            txt_len.NumValue = 1000;
            txt_len_to.NumValue = 99999;

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;

        }

        private void opt_prc_status1_Click(object sender, EventArgs e)
        {
            opt_prc_status1_Click();

        }

        private void opt_prc_status2_Click(object sender, EventArgs e)
        {
            if (opt_prc_status2.Checked == true)
            {
                cmd_Cancel.Visible = false;
            }
            if (opt_prc_status2.Tag != "")
            {
                opt_prc_status2.Tag = "";
                return;
            }

            if (SpreadCommon.Gf_Sp_Cls(Sc2) == false)
            {
                opt_prc_status1.Tag = "A";
                opt_prc_status1.Checked = true;
                txt_Status.Text = "1";
                return;
            }

            opt_prc_status2.Checked = true;

            opt_prc_status2.ForeColor = Color.Red;
            opt_prc_status1.ForeColor = Color.Black;

            SpreadCommon.Gf_Sp_Cls(Sc1);
            SpreadCommon.Gf_Sp_Cls(Sc2);

            //Gp_Ms_Cls(Mc1("rControl"));
            //Gp_Ms_ControlLock(Mc1("pControl"), false);
            txt_Status.Text = "2";

            txt_act_stlgrd_dec.Text = "";
            txt_MOSLAB.Text = "";
            TXT_SLABNO.Text = "";

            cbo_cutcnt.Enabled = false;
            cbo_cutcnt.SelectedIndex = 0;
            txt_total_len.NumValue = 0;
            txt_total_wgt.NumValue = 0;
            txt_scrap_wgt.NumValue = 0;

            txt_plt.Text = "B3";
            txt_plt_dec.Text = "老炼钢厂";
            txt_thk.NumValue = 150;
            txt_thk_to.NumValue = 320;
            txt_wid.NumValue = 1000;
            txt_wid_to.NumValue = 4000;
            txt_len.NumValue = 1000;
            txt_len_to.NumValue = 99999;

            U_FROM_DATE.RawDate = DateTime.Now.ToString("yyyyMM") + "01";

            txt_total_len.ForeColor = Color.Black;
            txt_total_wgt.ForeColor = Color.Black;
            txt_scrap_wgt.ForeColor = Color.Black;
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            //Dim cSlabLen As Long
            int iRow1;
            int iRow2;
            int iCol;
            string sColor;
            string sHeat;
            string sTemp;
            string sChgPrcLine;
            string sL2SendFL;
            int i;
            int ForCnt;
            double tmLen;
            double tmWgt;
            string TIME;

            double tmThk;
            double tmWid;

            double tempWgt;
            double tot_cal_total;
            double cal_wgt;
            double tmp_rat;
            double tmTotalLen;
            double tmpLen;
            double sub_wgt;
            double sub_len;
            double tmCalCut;
            double tmCalMo;
            double tmCalCutOne;
            int iRow;

            Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount -1, e.Row, e.Row, Color.Black,  ColorTranslator.FromHtml("#80FFFF"));

            for (i = 1; i <= ss1.ActiveSheet.RowCount; i++)
            {
                if (i-1 != e.Row)
                {
                   SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount-1, i-1, i-1,Color.Black,Color.White);


                }
            }

            TIME = DateTime.Now.ToString("yyyyMM");


            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {
                if (convertX(substr(ss1.ActiveSheet.Cells[iRow-1,23].Text, 0, 6)) < convertX(TIME))
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, Color.Red);
                }

                if (ss1.ActiveSheet.Cells[iRow - 1, 23].Text == "")
                {
                    break; // TODO: might not be correct. Was : Exit For
                }

            }


            if (e.Row >= 0)
            {
                TXT_SLABNO.Text = ss1.ActiveSheet.Cells[e.Row,0].Text;
                SCRAP_NO = ss1.ActiveSheet.Cells[e.Row, 0].Text;
                cSlabno = ss1.ActiveSheet.Cells[e.Row, 0].Text;
                cSlabLen = convertX(ss1.ActiveSheet.Cells[e.Row, 7].Text);
                cSlabWgt = convertX(ss1.ActiveSheet.Cells[e.Row, 8].Text);
                txt_tmpPLT.Text = ss1.ActiveSheet.Cells[e.Row, 16].Text;
                txt_IST_DATE.Text = ss1.ActiveSheet.Cells[e.Row, 17].Text;
            }

            sQuery = "          SELECT MAX(SLAB_NO) ";
            sQuery = sQuery + "   FROM NISCO.FP_SLAB ";
            sQuery = sQuery + "  WHERE SLAB_NO LIKE '" + substr(cSlabno, 0, 8) + "%'";

            tmpSlabNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
            //modified by guoli at 20080418
            if (Convert.ToInt32(substr(tmpSlabNo, 8, 2)) < 30 | Convert.ToInt32(substr(tmpSlabNo, 8, 2)) >= 97)
            {
                tmpSlabNo = substr(tmpSlabNo, 0, 8) + "30";
            }

            //ss1.ROW = ROW;
            //ss1.Col = 1;

            //lBlkrow1 = ROW;
            //lBlkrow2 = ROW;
            //sc1.Item("Spread").Col = 0;
            //sc1.Item("Spread").ROW = 0;
            //sc1.Item("Spread").Text = "◎";
            //sc2.Item("Spread").Col = 0;
            //sc2.Item("Spread").ROW = 0;
            //sc2.Item("Spread").Text = "";

            if (e.Row < 0) return;

            if (opt_prc_status2.Checked)
            {
                p_Ref(2, 2, true, true);
                for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
                {
                    if (ss2.ActiveSheet.Cells[i-1,14].Text == "订单材")
                    {
                        SpreadCommon.Gp_Sp_BlockLock(ss2, 2, 3, i-1, i-1,true);
                    }
                }
                return;
            }

            p_Ref(2, 2, true, false);


            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {

                NEWSLABNO = substr(tmpSlabNo, 0, 8) + substr(tmpSlabNo, 8, 2) + i;
                if (substr(NEWSLABNO, 4, 6).Length == 5)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "0" + substr(NEWSLABNO, 4, 5);
                }
                else if (substr(NEWSLABNO, 4, 6).Length == 4)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "00" + substr(NEWSLABNO, 4, 5);
                }
                else if (substr(NEWSLABNO, 4, 6).Length == 3)
                {
                    NEWSLABNO = substr(NEWSLABNO, 0, 4) + "000" + substr(NEWSLABNO, 4, 5);
                }

                ss2.ActiveSheet.Cells[i-1,0].Text = NEWSLABNO;

                tmThk = convertX(ss2.ActiveSheet.Cells[i-1,1].Text);

                tmWid = convertX(ss2.ActiveSheet.Cells[i-1,2].Text);

                tmLen = convertX(ss2.ActiveSheet.Cells[i-1,3].Text);

                ss2.ActiveSheet.Cells[i-1,5].Text = (((tmThk * tmWid * tmLen) * 7.85) / 1000000000).ToString();

                ss2.ActiveSheet.Cells[i-1,10].Text = GeneralCommon.sUserID;

                ss2.ActiveSheet.Cells[i-1,11].Text = TXT_SLABNO.Text;

                if (i == ss2.ActiveSheet.RowCount)
                {
                    ss2.ActiveSheet.Cells[i-1,12].Text = "Y";
                }
                else
                {
                    ss2.ActiveSheet.Cells[i-1,12].Text = "";
                }
            }

            tmTotalLen = 0;
            tempWgt = 0;
            for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
            {
                if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text != "删除")
                {
                    tmTotalLen = tmTotalLen + convertX(ss2.ActiveSheet.Cells[i - 1, 3].Text);

                    tempWgt = tempWgt + convertX(ss2.ActiveSheet.Cells[i - 1, 4].Text);
                }

            }

            if (txt_Status.Text == "1")
            {
                for (i = 1; i <= ss2.ActiveSheet.RowCount; i++)
                {
                    if (ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text == "")
                    {
                        ss2.ActiveSheet.RowHeader.Cells[i-1,0].Text = "增加";
                    }
                    if (ss2.ActiveSheet.Cells[i-1,14].Text == "订单材")
                    {
                        SpreadCommon.Gp_Sp_BlockLock(ss2, 2, 3, i-1, i-1,true);
                    }

                }
            }

            if (tmTotalLen == cSlabLen)
            {
                txt_total_len.ForeColor = Color.Black;
            }
            else
            {
                txt_total_len.ForeColor = Color.Red;
            }
            txt_total_len.Text = tmTotalLen.ToString();

            txt_total_wgt.Text = tempWgt.ToString();
            if (convertX(txt_total_wgt.Text) - cSlabWgt == 0)
            {
                txt_total_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_total_wgt.ForeColor = Color.Red;
            }

            txt_scrap_wgt.Text = (cSlabWgt - tempWgt).ToString();
            if (cSlabWgt - tempWgt == 0)
            {
                txt_scrap_wgt.ForeColor = Color.Black;
            }
            else
            {
                txt_scrap_wgt.ForeColor = Color.Red;
            }
        }




    }
}
