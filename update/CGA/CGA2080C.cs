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
            p_SetSc("指示日期", "DT", "", "L", "", "", "", 1, 0, "M");//17
            p_SetSc("订单材/余材", "E", "", "L", "", "", "", 1, 0, "M");//18
            p_SetSc("定尺类别", "E", "", "L", "", "", "", 1, 0, "M");//19
            p_SetSc("订单号", "E", "", "L", "", "", "", 1, 0, "M");//20
            p_SetSc("订单规格", "E", "", "L", "", "", "", 1, 0,"M");//21
            p_SetSc("订单标准号", "E", "", "L", "", "", "", 1, 0, "M");//22
            p_SetSc("最早日期", "D", "", "L", "", "", "", 1, 0);//23
            p_SetSc("是否紧急订单", "E", "", "L", "", "", "", 1, 0, "M");//24


            p_McIni(Mc2, false);
            p_SetMc("隐藏1", txt_tmpPLT, "P", "", "", "", "", 2);
            p_SetMc("隐藏2", txt_IST_DATE, "P", "", "", "", "", 2);
            p_SetMc("板坯号", TXT_SLABNO, "P", "", "", "", "", 2);
            
    

            p_ScIni(ss2, Sc2, 0, true, true);

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

            p_ScIni(ss3, Sc3, 0, true, true);

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

            p_ScIni(ss4, Sc4, 0, true, true);

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
            opt_prc_status1.Checked = true;
            opt_prc_status1.ForeColor = Color.Red;
            txt_total_len.Enabled = false;
            txt_total_wgt.Enabled = false;
            txt_scrap_wgt.Enabled = false;
            txt_plt.Text = "B3";
            txt_plt_dec.Text = "老炼钢";
            txt_thk.Text = "150";
            txt_thk_to.Text = "320";
            txt_wid.Text = "1000";
            txt_wid_to.Text = "4000";
            txt_len.Text = "1000";
            txt_len_to.Text = "99999";
            U_FROM_DATE.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(TRUNC(ADD_MONTHS(LAST_DAY(SYSDATE), -1) + 1), 'YYYYMMDD')FROM DUAL");
            U_TO_DATE.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL");


            txt_Status.Text = "1";
        }


        public override void Form_Ref()
        {
            if (this.txt_MOSLAB.Text != "")
            {
                if (!(this.txt_MOSLAB.Text.Length == 10 || this.txt_MOSLAB.Text.Length == 8))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认母板坯号...!!", "W", "警告");
                    return;
                }
            }
            if (this.txt_len.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请确认长度...!!", "W", "警告");
                return;
            }

            TXT_SLABNO.Text = "";
            txt_total_len.Text = "";
            txt_total_wgt.Text = "";
            txt_scrap_wgt.Text = "";
            p_Ref(1, 1, true, true);
            for (int i = 0; i < ss1_Sheet1.RowCount; i++)
            {
                if (this.ss1_Sheet1.Cells[i, 31].Text == "Y")
                {
                    this.ss1_Sheet1.Rows.Get(i).ForeColor = Color.Blue;
                }
                if (this.ss1_Sheet1.Cells[i, 32].Text == "Y" || this.ss1_Sheet1.Cells[i, 32].Text == "A")
                {
                    this.ss1_Sheet1.Rows.Get(i).ForeColor = Color.Orange;
                }

            }
            this.ss2_Sheet1.RowCount = 0;


            string nowTime = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL");
            for (int i = 0; i < this.ss1_Sheet1.RowCount; i++)
            {
                if (this.ss1_Sheet1.Cells[i, 24].Text.Replace("-", "") == "" || (int.Parse(this.ss1_Sheet1.Cells[i, 24].Text.Replace("-", "")) < int.Parse(nowTime)))
                    this.ss1_Sheet1.Rows.Get(i).ForeColor = Color.Red;
            }

            if (txt_Status.Text == "1")
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList1.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "T";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList1.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "T";
            }
            GeneralCommon.MDIToolBar.Refresh();


        }

        //private void txt_ord_no_KeyUp(object sender, KeyEventArgs e)
        //{
        //    cbo_ord_item.Text = "";
        //    if (this.txt_ord_no.Text != "" && this.txt_ord_no.Text.Trim().Length == this.txt_ord_no.MaxLength)
        //        GeneralCommon.Gf_ComboAdd(this.cbo_ord_item, "SELECT ORD_ITEM FROM CP_PRC WHERE ORD_NO = '" + txt_ord_no.Text.Trim() + "'");
        //    else
        //        this.cbo_ord_item.Items.Clear();
        //}

        private void opt_prc_status1_Click(object sender, EventArgs e)
        {
            cmd_Cancel.Visible = true;
            this.ss1_Sheet1.RowCount = 0;
            this.ss2_Sheet1.RowCount = 0;
            opt_prc_status1.ForeColor = Color.Red;
            opt_prc_status2.ForeColor = Color.Black;
            txt_Status.Text = "1";
            txt_act_stlgrd_dec.Text = "";
            txt_act_stlgrd.Text = "";
            txt_MOSLAB.Text = "";
            TXT_SLABNO.Text = "";
            txt_thk.Text = "150";
            txt_thk_to.Text = "999";
            txt_wid.Text = "1800";
            txt_wid_to.Text = "9999";
            txt_len.Text = "2600";
            txt_len_to.Text = "99999";
            txt_total_len.Text = "";
            txt_total_wgt.Text = "";
            txt_scrap_wgt.Text = "";
            txt_plt.Text = "B1";
            txt_plt_dec.Text = "#1 炼钢";
            base.i_ScCurrSeq = 2;
            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            GeneralCommon.MDIToolBar.Refresh();
        }

        private void opt_prc_status2_Click(object sender, EventArgs e)
        {
            cmd_Cancel.Visible = false;
            this.ss1_Sheet1.RowCount = 0;
            this.ss2_Sheet1.RowCount = 0;
            opt_prc_status1.ForeColor = Color.Black;
            opt_prc_status2.ForeColor = Color.Red;
            txt_Status.Text = "2";
            txt_act_stlgrd_dec.Text = "";
            txt_act_stlgrd.Text = "";
            txt_MOSLAB.Text = "";
            TXT_SLABNO.Text = "";
            txt_thk.Text = "150";
            txt_thk_to.Text = "999";
            txt_wid.Text = "1800";
            txt_wid_to.Text = "9999";
            txt_len.Text = "2600";
            txt_len_to.Text = "99999";
            txt_total_len.Text = "";
            txt_total_wgt.Text = "";
            txt_scrap_wgt.Text = "";
            txt_plt.Text = "B1";
            txt_plt_dec.Text = "#1 炼钢";
            base.i_ScCurrSeq = 2;
            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList1.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "T";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList1.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "T";
            GeneralCommon.MDIToolBar.Refresh();
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            opt_prc_status1_Click(this.opt_prc_status1, new EventArgs());
            return true;
        }

        protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        {
            //base.ss_CellClickEvent(sender, e);
            FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)sender;
            if (oSpread.Name != "ss1") return;
            if (e.ColumnHeader) return;
            if (oSpread.ActiveSheet.RowCount <= 0) return;
            for (int i = 0; i < oSpread.ActiveSheet.Rows.Count; i++)
            {

                oSpread.ActiveSheet.Rows.Get(i).BackColor = Color.White;
                oSpread.ActiveSheet.RowHeader.Cells[i, 0].Text = "";

            }
            oSpread.ActiveSheet.Rows.Get(e.Row).BackColor = Color.LawnGreen;
            oSpread.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "切割";
            TXT_SLABNO.Text = oSpread.ActiveSheet.Cells[e.Row, 0].Text;
            TXT_INGOT_FL.Text = oSpread.ActiveSheet.Cells[e.Row, 2].Text;
            txt_tmpPLT.Text = oSpread.ActiveSheet.Cells[e.Row, 19].Text;
            string temp = oSpread.ActiveSheet.Cells[e.Row, 20].Text.Replace(":", "").Replace(" ", "").Replace("-", "");
            if (temp.Length != 14)
                temp = temp.Substring(0, 8) + "0" + temp.Substring(8);
            txt_IST_DATE.Text = temp;//oSpread.ActiveSheet.Cells[e.Row, 20].Text.Replace(":","").Replace(" ","").Replace("-","");
            string tmpSlabNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT MAX(SLAB_NO) FROM NISCO.FP_SLAB WHERE SLAB_NO LIKE '" + TXT_SLABNO.Text.Substring(0, 8) + "%'");
            if (int.Parse(tmpSlabNo.Substring(8, 2)) < 30)
                tmpSlabNo = tmpSlabNo.Substring(0, 8) + "30";
            if (this.opt_prc_status2.Checked)
            {

                SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[2], (Collection)Proc_Mc[2], (Collection)((Collection)Proc_Mc[2])["npControl"], (Collection)((Collection)Proc_Mc[2])["mControl"], false);
                this.cbo_cutcnt.Text = this.ss2_Sheet1.RowCount.ToString();
                for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
                {
                    this.ss2_Sheet1.Cells[i, 9].Text = "0";
                }
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList1.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "T";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList1.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "T";
                GeneralCommon.MDIToolBar.Refresh();
                return;
            }

            SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[2], (Collection)Proc_Mc[2], (Collection)((Collection)Proc_Mc[2])["npControl"], (Collection)((Collection)Proc_Mc[2])["mControl"], false);
            if (this.ss2_Sheet1.RowCount <= 0) return;
            this.cbo_cutcnt.Text = this.ss2_Sheet1.RowCount.ToString();
            int newLong = 0;
            double newWgt = 0;
            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            {


                string temp1 = tmpSlabNo.Substring(0, 8);
                string temp2 = tmpSlabNo.Substring(8);

                string newSlabNo = temp1 + (int.Parse(temp2) + 1 + i);


                this.ss2_Sheet1.Cells[i, 0].Text = newSlabNo;
                this.ss2_Sheet1.Cells[i, 1].Text = TXT_INGOT_FL.Text;


                this.ss2_Sheet1.Cells[i, 11].Text = GeneralCommon.sUserID;
                this.ss2_Sheet1.Cells[i, 12].Text = TXT_SLABNO.Text;
                this.ss2_Sheet1.Cells[i, 13].Text = i == this.ss2_Sheet1.RowCount - 1 ? "Y" : "";
                newLong += int.Parse(this.ss2_Sheet1.Cells[i, 4].Text.Replace(",", ""));
                newWgt += Math.Round(double.Parse(this.ss2_Sheet1.Cells[i, 5].Text.Replace(",", "")), 3);
                this.ss2_Sheet1.RowHeader.Cells[i, 0].Text = "增加";
                this.ss2_Sheet1.Cells[i, 9].Text = "0";

                this.ss2_Sheet1.Cells[i, 7].Locked = false;
                this.ss2_Sheet1.Cells[i, 8].Locked = false;
                this.ss2_Sheet1.Cells[i, 7].BackColor = Color.Yellow;
                this.ss2_Sheet1.Cells[i, 8].BackColor = Color.Yellow;

                if (this.ss2_Sheet1.Cells[i, 15].Text == "余材")
                {
                    this.ss2_Sheet1.Cells[i, 3].Locked = false;
                    this.ss2_Sheet1.Cells[i, 4].Locked = false;
                    this.ss2_Sheet1.Cells[i, 3].BackColor = Color.Yellow;
                    this.ss2_Sheet1.Cells[i, 4].BackColor = Color.Yellow;
                }





            }
            if (newLong == int.Parse(oSpread.ActiveSheet.Cells[e.Row, 8].Text.Replace(",", "")))
                txt_total_len.ForeColor = Color.Black;
            else
                txt_total_len.ForeColor = Color.Red;
            txt_total_len.Text = newLong.ToString();

            newWgt = Math.Round(newWgt, 3);
            txt_total_wgt.Text = newWgt.ToString();
            if (newWgt == double.Parse(oSpread.ActiveSheet.Cells[e.Row, 9].Text.Replace(",", "")))
                txt_total_wgt.ForeColor = Color.Black;
            else
                txt_total_wgt.ForeColor = Color.Red;

            txt_scrap_wgt.Text = (double.Parse(oSpread.ActiveSheet.Cells[e.Row, 9].Text.Replace(",", "")) - newWgt).ToString();
            if (txt_scrap_wgt.Text == "0")
                txt_scrap_wgt.ForeColor = Color.Black;
            else
                txt_scrap_wgt.ForeColor = Color.Black;
            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";


            if (this.ss2_Sheet1.RowCount == 1)
            {
                this.ss2_Sheet1.Cells[0, 5].Text = this.ss2_Sheet1.Cells[e.Row, 5].Text.Replace(",", "");
            }
            else
            {
                double newWgt1 = 0;
                for (int ii = 0; ii < this.ss2_Sheet1.RowCount - 1; ii++)
                {
                    newWgt1 += double.Parse(this.ss2_Sheet1.Cells[ii, 5].Text.Replace(",", ""));
                }
                this.ss2_Sheet1.Cells[this.ss2_Sheet1.RowCount - 1, 5].Text = (double.Parse(oSpread.ActiveSheet.Cells[e.Row, 9].Text.Replace(",", "")) - newWgt1).ToString();
            }
            txt_scrap_wgt.Text = "0";

        }

        public override void Form_Pro()
        {
            if (txt_Status.Text == "1")
            {
                if (txt_scrap_wgt.Text != "0")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("板坯分切前后重量不守恒，请确认分切数据!", "W", "系统提示信息");
                    return;
                }
                if (p_Pro(2, 2, true, false))
                {
                    this.ss2_Sheet1.RowCount = 0;
                    p_Ref(1, 1, true, true);
                }
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();
            }
            else
            {
                if (p_Pro(2, 2, true, false))
                {
                    this.ss2_Sheet1.RowCount = 0;
                    Pro_ACB3020P();
                    p_Ref(1, 1, true, true);
                }
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList1.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "T";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList1.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "T";
                GeneralCommon.MDIToolBar.Refresh();
            }
        }

        private string Pro_ACB3020P()
        {
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return "ERROR";
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "ACB3020P";
                GeneralCommon.M_CN1.BeginTrans();

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));

                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_msg"].Value.ToString() == "")
                {
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                    return "";
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();

                }
                return "ERROR";
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)(ex.Message), "W", "警告");
                return ex.Message + "ERROR";
            }
        }

        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);
            if (txt_Status.Text == "1")
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList1.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "T";
                GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList1.Images[6];
                GeneralCommon.MDIToolBar.Buttons[8].Tag = "T";
            }
            GeneralCommon.MDIToolBar.Refresh();
        }


        public override void Spread_Del()
        {
            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            {
                this.ss2_Sheet1.RowHeader.Cells[i, 0].Text = "删除";
            }
        }

        public override void Spread_Can()
        {
            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            {
                this.ss2_Sheet1.RowHeader.Cells[i, 0].Text = "";
            }
        }


        protected override void ss_EditChange(object sender, EditorNotifyEventArgs e)
        {

            if (e.Column == 3 || e.Column == 4)
            {
                txt_total_wgt.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT WGT FROM FP_SLAB WHERE SLAB_NO = '" + TXT_SLABNO.Text + "'");
                txt_scrap_wgt.Text = "0";
                int noFL = 0;

                for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
                {
                    if (this.ss2_Sheet1.Cells[i, 15].Text == "余材")
                        noFL++;
                }
                if (noFL == 1)
                {
                    string tmThk = this.ss2_Sheet1.Cells[e.Row, 2].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 2].Text.Replace(",", "");
                    string tmWid = this.ss2_Sheet1.Cells[e.Row, 3].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 3].Text.Replace(",", "");
                    string tmLen = this.ss2_Sheet1.Cells[e.Row, 4].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 4].Text.Replace(",", "");
                    this.ss2_Sheet1.Cells[e.Row, 6].Text = (((long.Parse(tmThk) * long.Parse(tmWid) * long.Parse(tmLen)) * 7.85) / 1000000000).ToString();
                }
                else
                {
                    if (e.Row < this.ss2_Sheet1.RowCount - 1)
                    {
                        string tmThk = this.ss2_Sheet1.Cells[e.Row, 2].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 2].Text.Replace(",", "");
                        string tmWid = this.ss2_Sheet1.Cells[e.Row, 3].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 3].Text.Replace(",", "");
                        string tmLen = this.ss2_Sheet1.Cells[e.Row, 4].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 4].Text.Replace(",", "");
                        this.ss2_Sheet1.Cells[e.Row, 6].Text = (((long.Parse(tmThk) * long.Parse(tmWid) * long.Parse(tmLen)) * 7.85) / 1000000000).ToString();
                        this.ss2_Sheet1.Cells[e.Row, 5].Text = (((long.Parse(tmThk) * long.Parse(tmWid) * long.Parse(tmLen)) * 7.85) / 1000000000).ToString();
                        double actWgt = 0;
                        double caclWgt = 0;
                        for (int i = 0; i < this.ss2_Sheet1.RowCount - 1; i++)
                        {
                            actWgt += double.Parse(this.ss2_Sheet1.Cells[i, 5].Text.Replace(",", ""));
                            caclWgt += Math.Round(double.Parse(this.ss2_Sheet1.Cells[i, 6].Text.Replace(",", "")), 3);
                            this.ss2_Sheet1.Cells[this.ss2_Sheet1.RowCount - 1, 5].Text = (double.Parse(txt_total_wgt.Text) - actWgt).ToString();
                        }
                    }
                    else
                    {
                        string tmThk = this.ss2_Sheet1.Cells[e.Row, 2].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 2].Text.Replace(",", "");
                        string tmWid = this.ss2_Sheet1.Cells[e.Row, 3].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 3].Text.Replace(",", "");
                        string tmLen = this.ss2_Sheet1.Cells[e.Row, 4].Text == "" ? "0" : this.ss2_Sheet1.Cells[e.Row, 4].Text.Replace(",", "");
                        this.ss2_Sheet1.Cells[e.Row, 6].Text = (((long.Parse(tmThk) * long.Parse(tmWid) * long.Parse(tmLen)) * 7.85) / 1000000000).ToString();
                    }
                }

            }

        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            if (TXT_SLABNO.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请选择取消分切的板坯...!!", "W", "警告");
                return;
            }

            if (!GeneralCommon.Gf_MessConfirm("请确认是否取消分板", "I", ""))
                return;

            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "WGA1030C.P_ORDCANCEL";
                GeneralCommon.M_CN1.BeginTrans();

                for (int i = 1; i <= 3; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));


                adoCmd.Parameters[0].Value = TXT_SLABNO.Text;
                adoCmd.Parameters[1].Value = GeneralCommon.sUserID;

                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_msg"].Value.ToString() != "")
                {
                    ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);
                    GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();
                }
                else
                {
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                    Form_Ref();
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)(ex.Message), "W", "警告");
            }
        }


        private void txt_MOSLAB_KeyUp(object sender, KeyEventArgs e)
        {
            return;


        }

    }
}
