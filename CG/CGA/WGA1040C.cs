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
    public partial class WGA1040C : CommonClass.FORMBASE
    {
        public WGA1040C()
        {
            InitializeComponent();
           
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        
        
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        

        TextBox TX00 = new TextBox(); TextBox TX01 = new TextBox(); TextBox TX02 = new TextBox(); TextBox TX03 = new TextBox(); TextBox TX04 = new TextBox(); TextBox TX05 = new TextBox(); TextBox TX06 = new TextBox(); TextBox TX07 = new TextBox();
        TextBox TX10 = new TextBox(); TextBox TX11 = new TextBox(); TextBox TX12 = new TextBox(); TextBox TX13 = new TextBox(); TextBox TX14 = new TextBox(); TextBox TX15 = new TextBox(); TextBox TX16 = new TextBox(); TextBox TX17 = new TextBox();
        TextBox TX20 = new TextBox(); TextBox TX21 = new TextBox(); TextBox TX22 = new TextBox(); TextBox TX23 = new TextBox(); TextBox TX24 = new TextBox(); TextBox TX25 = new TextBox(); TextBox TX26 = new TextBox(); TextBox TX27 = new TextBox();


        protected override void p_SubFormInit()
        {

            p_McIni(Mc1, true);
            p_SetMc("板坯号", cbo_slab_no, "PNIR", "", "", "", "", 1);//0
            p_SetMc("班次", cbo_shift, "NIR", "", "", "", "", 1);//1
            p_SetMc("班别", cbo_group, "NIR", "", "", "", "", 1);//2
            p_SetMc("作业人员", cbo_emp_cd, "NIL", "", "", "", "", 1);//3
            p_SetMc("作业时间", txt_work_date, "NIR", "", "", "", "", 1);//4

            p_SetMc("宽面", TX00, "IR", "", "", "", "", 1);//5
            p_SetMc("宽面", TX01, "IR", "", "", "", "", 1);//6
            p_SetMc("宽面", TX02, "IR", "", "", "", "", 1);//7
            p_SetMc("宽面", TX03, "IR", "", "", "", "", 1);//8
            p_SetMc("宽面", TX04, "IR", "", "", "", "", 1);//9
            p_SetMc("宽面", TX05, "IR", "", "", "", "", 1);//10
            p_SetMc("宽面", TX06, "IR", "", "", "", "", 1);//11
            p_SetMc("宽面", TX07, "IR", "", "", "", "", 1);//12

            p_SetMc("窄面", TX10, "IR", "", "", "", "", 1);//13
            p_SetMc("窄面", TX11, "IR", "", "", "", "", 1);//14
            p_SetMc("窄面", TX12, "IR", "", "", "", "", 1);//15
            p_SetMc("窄面", TX13, "IR", "", "", "", "", 1);//16
            p_SetMc("窄面", TX14, "IR", "", "", "", "", 1);//17
            p_SetMc("窄面", TX15, "IR", "", "", "", "", 1);//18
            p_SetMc("窄面", TX16, "IR", "", "", "", "", 1);//19
            p_SetMc("窄面", TX17, "IR", "", "", "", "", 1);//20

            p_SetMc("角面", TX20, "IR", "", "", "", "", 1);//21
            p_SetMc("角面", TX21, "IR", "", "", "", "", 1);//22
            p_SetMc("角面", TX22, "IR", "", "", "", "", 1);//23
            p_SetMc("角面", TX23, "IR", "", "", "", "", 1);//24
            p_SetMc("角面", TX24, "IR", "", "", "", "", 1);//25
            p_SetMc("角面", TX25, "IR", "", "", "", "", 1);//26
            p_SetMc("角面", TX26, "IR", "", "", "", "", 1);//27
            p_SetMc("角面", TX27, "IR", "", "", "", "", 1);//28
        
            p_SetMc("质量代码", txt_quality_id, "LR", "", "", "", "", 1);//29
            p_SetMc("修磨面积比(%)", txt_sf_yield, "IR", "", "", "", "", 1);//30
            p_SetMc("判定等级", txt_grd, "IRL", "", "", "", "", 1);//31
            p_SetMc("评审原因代码", txt_det_code, "IR", "", "", "", "", 1);//32
            p_SetMc("评审原因代码2", txt_det_name, "R", "", "", "", "", 1);//33
            p_SetMc("隐藏1", txt_proc_cd, "R", "", "", "", "", 1);//34
            p_SetMc("隐藏2", txt_rec_sts, "R", "", "", "", "", 1);//35
            p_SetMc("板坯类型", TXT_CN, "R", "", "", "", "", 1);//36



            p_McIni(Mc2, true);
            p_SetMc("隐藏3", CBO_PLT, "PNIR", "", "", "", "", 2);//0
            p_SetMc("工序22", TXT_PRC_INPUT, "PNIR", "", "", "", "", 2);//1
            p_SetMc("隐藏4", CBO_LINE, "PNIR", "", "", "", "", 2);//2
            p_SetMc("发生日", TXT_OCCR_TIME, "NIR", "", "", "", "", 2);//3
            p_SetMc("班次", cbo_shift1, "PIR", "", "", "", "", 2);//4

            p_SetMc("班别", cbo_group1, "PIR", "", "", "", "", 2);//5
            p_SetMc("种类", CBO_SCRAP_INPUT, "N", "", "", "", "", 2);//6
            p_SetMc("隐藏5", TXT_SCRAP_INPUT, "PNIR", "", "", "", "", 2);//7
            p_SetMc("废钢号", TXT_SCRAP_NO, "PIR", "", "", "", "", 2);//8
            p_SetMc("原因", txt_code, "PNIR", "", "", "", "", 2);//9

            p_SetMc("废钢总量", SDB_SCRAP_WGT, "NIR", "", "", "", "", 2);//10
            p_SetMc("增减量", cbo_ths_d_mat_var, "I", "", "", "", "", 2);//11
            p_SetMc("增减量2", sdb_ths_d_mat_var, "I", "", "", "", "", 2);//12
            p_SetMc("用户", txt_UserId, "I", "", "", "", "", 2);//13
            p_SetMc("隐藏6", TXT_END_TIME, "I", "", "", "", "", 2);//14

            p_SetMc("隐藏7", TXT_END_CD, "I", "", "", "", "", 2);//15
         


            p_ScIni(ss1, Sc1, 0, false, false);

            p_SetSc("横裂纹", "C", "", "", "", "", "", 1, 0, "M");//0
            p_SetSc("纵裂纹", "C", "", "", "", "", "", 1, 0, "M");//1
            p_SetSc("网状裂纹", "C", "", "", "", "", "", 1, 0, "M");//2
            p_SetSc("皮下裂泡", "C", "", "", "", "", "", 1, 0, "M");//3
            p_SetSc("皮下夹渣", "C", "", "", "", "", "", 1, 0, "M");//4
            p_SetSc("振痕", "C", "", "", "", "", "", 1, 0, "M");//5
            p_SetSc("凹凸", "C", "", "", "", "", "", 1, 0, "M");//6
            p_SetSc("其他", "C", "", "", "", "", "", 1, 0, "M");//7

            p_McIni(Mc3, false);

            p_SetMc("发生日期1", TXT_From_Date, "PN", "", "", "", "", 3);//0
            p_SetMc("发生日期2", TXT_To_Date, "PN", "", "", "", "", 3);//1
            p_SetMc("班次2", cbo_shift1, "P", "", "", "", "", 3);//2
            p_SetMc("工序2", TXT_PRC, "P", "", "", "", "", 3);//3
            p_SetMc("隐藏2", TXT_SCRAP_CD, "P", "", "", "", "", 3);//4
            p_SetMc("隐藏1", txt_Flag, "P", "", "", "", "", 3);//5
            p_SetMc("废钢号", TXT_SCRAP_NO_1, "P", "", "", "", "", 3);//6
           


            p_ScIni(ss2, Sc2, 0, false, false);

            p_SetSc("发生时间", "D", "", "L", "", "", "", 2, 0, "M");//0
            p_SetSc("班次", "E", "", "L", "", "", "", 2, 0, "M");//1
            p_SetSc("班别", "E", "", "L", "", "", "", 2, 0, "M");//2
            p_SetSc("工序代码", "E", "", "L", "", "", "", 2, 0, "M");//3
            p_SetSc("工序名", "E", "", "L", "", "", "", 2, 0, "M");//4
            p_SetSc("废钢种类", "E", "", "L", "", "", "", 2, 0, "M");//5
            p_SetSc("废钢号", "E", "", "L", "", "", "", 2, 0, "M");//6
            p_SetSc("废钢重量", "N", "8,3", "L", "", "", "", 2, 0, "M");//7
            p_SetSc("原因", "E", "", "L", "", "", "", 2, 0, "M");//8
            p_SetSc("原因描述", "E", "", "L", "", "", "", 2, 0, "M");//9
            p_SetSc("结束时间", "E", "", "L", "", "", "", 2, 0, "M");//10
            p_SetSc("结束去向", "E", "", "L", "", "", "", 2, 0, "M");//11
            p_SetSc("垛位号", "E", "", "L", "", "", "", 2, 0, "M");//12
            p_SetSc("PLT", "E", "", "L", "", "", "", 2, 0, "M");//13
            p_SetSc("板坯厚度", "N", "8", "L", "", "", "", 2, 0, "M");
            p_SetSc("板坯宽度", "N", "8", "L", "", "", "", 2, 0, "M");
            p_SetSc("板坯长度", "N", "8", "L", "", "", "", 2, 0, "M");
            p_SetSc("转炉出钢时间", "E", "", "L", "", "", "", 2, 0, "M");//17
            p_SetSc("连铸开浇时间", "E", "", "L", "", "", "", 2, 0, "M");//18
            p_SetSc("板坯切割时间", "E", "", "L", "", "", "", 2, 0, "M");//19
            p_SetSc("板坯钢种", "E", "", "L", "", "", "", 2, 0, "M");//20

          
         
            
        }


        private void WGA1050C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGA1040C";
            Form_Define();
            setSpread1ColumnAndRow();
            this.Chk_ss1.Checked = true;
            this.Chk_ss1.ForeColor = Color.Red;
            txt_oper.Text = "1";
            txt_UserId.Text = GeneralCommon.sUserID;
            this.CBO_PLT.Text = "C2";
            this.groupBox4.Enabled = false;
            this.cbo_emp_cd.Text = GeneralCommon.sUserID;

            setTextbox();
            txt_code.Enabled = false;
        }

        private void setTextbox()
        {
            TX00.Text = "N";
            TX01.Text = "N";
            TX02.Text = "N";
            TX03.Text = "N";
            TX04.Text = "N";
            TX05.Text = "N";
            TX06.Text = "N";
            TX07.Text = "N";

            TX10.Text = "N";
            TX11.Text = "N";
            TX12.Text = "N";
            TX13.Text = "N";
            TX14.Text = "N";
            TX15.Text = "N";
            TX16.Text = "N";
            TX17.Text = "N";

            TX20.Text = "N";
            TX21.Text = "N";
            TX22.Text = "N";
            TX23.Text = "N";
            TX24.Text = "N";
            TX25.Text = "N";
            TX26.Text = "N";
            TX27.Text = "N";
        
        }
        public override bool Form_Cls()
        {
            
            base.Form_Cls();
            setSpread1ColumnAndRow();
            this.Chk_ss1.Checked = true;
            this.Chk_ss1.ForeColor = Color.Red;
            txt_oper.Text = "1";
            txt_UserId.Text = GeneralCommon.sUserID;
            this.CBO_PLT.Text = "B1";
            this.groupBox4.Enabled = false;
            this.cbo_emp_cd.Text = GeneralCommon.sUserID;

            this.Chk_ss2.ForeColor = Color.Black;
        
            this.Chk_ss2.Checked = false;
            txt_main_res_cd.Text = "";
            cbo_ths_d_mat_var.Text = "";
            sdb_ths_d_mat_var.Text = "";
            CBO_SCRAP_INPUT.Text = "";

            TXT_From_Date.RawDate = "";
            TXT_To_Date.RawDate = "";
            TXT_OCCR_TIME.RawDate = "";

            setTextbox();
            txt_code.Enabled = false;
            return true;
        }

        private void setSpread1ColumnAndRow()
        {
            this.ss1.ActiveSheet.RowCount = 3;
            ss1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            ss1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            for (int i = 0; i < this.ss1.ActiveSheet.ColumnCount;i++ )
            {
                this.ss1.ActiveSheet.Columns.Get(i).Width = 69;
                this.ss1.ActiveSheet.Columns.Get(i).Resizable = false;
            }
            for (int i = 0; i < this.ss1.ActiveSheet.RowCount; i++)
            {    
                this.ss1.ActiveSheet.Rows.Get(i).Resizable = false;
                this.ss1.ActiveSheet.Rows.Get(i).Height = 30;
            }
            this.ss1.ActiveSheet.RowHeader.Cells[0, 0].Text = "宽面";
            this.ss1.ActiveSheet.RowHeader.Cells[1, 0].Text = "窄面";
            this.ss1.ActiveSheet.RowHeader.Cells[2, 0].Text = "角面";
        }

        private void CBO_SCRAP_CD_TextChanged(object sender, EventArgs e)
        {
            if (CBO_SCRAP_CD.Text != "" && CBO_SCRAP_CD.Text.Length >= 2)
                this.TXT_SCRAP_CD.Text = CBO_SCRAP_CD.Text.Substring(0, 2);
        }

        private void cbo_slab_no_TextChanged(object sender, EventArgs e)
        {
            if (cbo_slab_no.Text != "" && cbo_slab_no.Text.Length == 10)
            {
                string sQuery = "SELECT SLAB_NO FROM FP_SLAB WHERE SLAB_NO = '" + cbo_slab_no.Text + "'";
                if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery) == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("该板坯不存在，板坯号无效！请重新输入板坯号！", "W", "");
                }
            }
        }



        private void CHK_MAIN_GRD1_Click(object sender, EventArgs e)
        {
            if (CHK_MAIN_GRD1.Checked)
            {
                CHK_MAIN_GRD1.ForeColor = Color.Red; ;
                CHK_MAIN_GRD2.ForeColor = Color.Black; ;
                CHK_MAIN_GRD3.ForeColor = Color.Black; ;
                CHK_MAIN_GRD5.ForeColor = Color.Black; ;
                CHK_MAIN_GRD7.ForeColor = Color.Black; ;
                CHK_MAIN_GRD2.Checked = false;
                CHK_MAIN_GRD3.Checked = false;
                CHK_MAIN_GRD5.Checked = false;
                CHK_MAIN_GRD7.Checked = false;
                txt_grd.Text = "1";
            }
            else
            {
                txt_grd.Text = "";
                CHK_MAIN_GRD1.ForeColor = Color.Black; 
            }
        }

        private void CHK_MAIN_GRD2_Click(object sender, EventArgs e)
        {
            if (CHK_MAIN_GRD2.Checked)
            {
                CHK_MAIN_GRD2.ForeColor = Color.Red; ;
                CHK_MAIN_GRD1.ForeColor = Color.Black; ;
                CHK_MAIN_GRD3.ForeColor = Color.Black; ;
                CHK_MAIN_GRD5.ForeColor = Color.Black; ;
                CHK_MAIN_GRD7.ForeColor = Color.Black; ;
                CHK_MAIN_GRD1.Checked = false;
                CHK_MAIN_GRD3.Checked = false;
                CHK_MAIN_GRD5.Checked = false;
                CHK_MAIN_GRD7.Checked = false;
                txt_grd.Text = "2";
            }
            else
            {
                txt_grd.Text = "";
                CHK_MAIN_GRD2.ForeColor = Color.Black;
            }
        }

        private void CHK_MAIN_GRD3_Click(object sender, EventArgs e)
        {
            if (CHK_MAIN_GRD3.Checked)
            {
                CHK_MAIN_GRD3.ForeColor = Color.Red; ;
                CHK_MAIN_GRD2.ForeColor = Color.Black; ;
                CHK_MAIN_GRD1.ForeColor = Color.Black; ;
                CHK_MAIN_GRD5.ForeColor = Color.Black; ;
                CHK_MAIN_GRD7.ForeColor = Color.Black; ;
                CHK_MAIN_GRD2.Checked = false;
                CHK_MAIN_GRD1.Checked = false;
                CHK_MAIN_GRD5.Checked = false;
                CHK_MAIN_GRD7.Checked = false;
                txt_grd.Text = "3";
            }
            else
            {
                txt_grd.Text = "";
                CHK_MAIN_GRD3.ForeColor = Color.Black; 
            }
        }

        private void CHK_MAIN_GRD5_Click(object sender, EventArgs e)
        {
            if (CHK_MAIN_GRD5.Checked)
            {
                CHK_MAIN_GRD5.ForeColor = Color.Red; ;
                CHK_MAIN_GRD2.ForeColor = Color.Black; ;
                CHK_MAIN_GRD3.ForeColor = Color.Black; ;
                CHK_MAIN_GRD1.ForeColor = Color.Black; ;
                CHK_MAIN_GRD7.ForeColor = Color.Black; ;
                CHK_MAIN_GRD2.Checked = false;
                CHK_MAIN_GRD3.Checked = false;
                CHK_MAIN_GRD1.Checked = false;
                CHK_MAIN_GRD7.Checked = false;
                txt_grd.Text = "5";
            }
            else
            {
                txt_grd.Text = "";
                CHK_MAIN_GRD5.ForeColor = Color.Black;
            }
        }

        private void CHK_MAIN_GRD7_Click(object sender, EventArgs e)
        {
            if (CHK_MAIN_GRD7.Checked)
            {
                CHK_MAIN_GRD7.ForeColor = Color.Red; ;
                CHK_MAIN_GRD2.ForeColor = Color.Black; ;
                CHK_MAIN_GRD3.ForeColor = Color.Black; ;
                CHK_MAIN_GRD5.ForeColor = Color.Black; ;
                CHK_MAIN_GRD1.ForeColor = Color.Black; ;
                CHK_MAIN_GRD2.Checked = false;
                CHK_MAIN_GRD3.Checked = false;
                CHK_MAIN_GRD5.Checked = false;
                CHK_MAIN_GRD1.Checked = false;
                txt_grd.Text = "7";
                CHK_MAIN_GRD3.ForeColor = Color.Black;
            }
            else
            {
                txt_grd.Text = "";
                CHK_MAIN_GRD7.ForeColor = Color.Black;
            }
        }

        private void CBO_SCRAP_CD_Click(object sender, EventArgs e)
        {
            if (CBO_SCRAP_CD.Text != "" && CBO_SCRAP_CD.Text.Length >= 2)
                this.TXT_SCRAP_CD.Text = CBO_SCRAP_CD.Text.Substring(0, 2);
        }

        private void CBO_SCRAP_INPUT_Click(object sender, EventArgs e)
        {
            if (CBO_SCRAP_INPUT.Text != "" && CBO_SCRAP_INPUT.Text.Length >= 2)
                this.TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text.Substring(0, 2);
            cbo_ths_d_mat_var.Text = "";
            sdb_ths_d_mat_var.Text = "";
        }

        private void Chk_ss1_Click(object sender, EventArgs e)
        {
            if(this.Chk_ss1.Checked)
            {
                this.Chk_ss1.ForeColor = Color.Red;
                this.groupBox2.Enabled = true;
                this.Chk_ss2.ForeColor = Color.Black;
                this.groupBox4.Enabled = false;
                this.Chk_ss2.Checked = false;
                txt_oper.Text = "1";
            }
            else
            {
                this.Chk_ss1.ForeColor = Color.Black;
                this.groupBox2.Enabled = false;
                this.Chk_ss2.ForeColor = Color.Red;
                this.groupBox4.Enabled = true;
                TXT_From_Date.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(TRUNC(ADD_MONTHS(LAST_DAY(SYSDATE), -1) + 1), 'YYYYMMDD')FROM DUAL");
                TXT_To_Date.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL");
            }
            base.i_ScCurrSeq = 2;
        }

        private void Chk_ss2_Click(object sender, EventArgs e)
        {
            if (this.Chk_ss2.Checked)
            {
                this.Chk_ss2.ForeColor = Color.Red;
                this.groupBox4.Enabled = true;
                this.Chk_ss1.ForeColor = Color.Black;
                this.groupBox2.Enabled = false;
                this.Chk_ss1.Checked = false;
                txt_oper.Text = "2";
                TXT_From_Date.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(TRUNC(ADD_MONTHS(LAST_DAY(SYSDATE), -1) + 1), 'YYYYMMDD')FROM DUAL");
                TXT_To_Date.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL");
            }
            else
            {
                this.Chk_ss2.ForeColor = Color.Black;
                this.groupBox4.Enabled = false;
                this.Chk_ss1.ForeColor = Color.Red;
                this.groupBox2.Enabled = true;
            }
            base.i_ScCurrSeq = 2;
        }

        private void CBO_SCRAP_INPUT_TextChanged(object sender, EventArgs e)
        {
            if (CBO_SCRAP_INPUT.Text != "" && CBO_SCRAP_INPUT.Text.Length >= 2)
                this.TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text.Substring(0, 2);
            cbo_ths_d_mat_var.Text = "";
            sdb_ths_d_mat_var.Text = "";
        }

        public override void Form_Ref()
        {
           // GeneralCommon.Gp_MsgBoxDisplay(TX00.Text + TX01.Text + TX02.Text + TX03.Text + TX04.Text + TX05.Text + TX06.Text + TX07.Text + TX10.Text + TX11.Text + TX12.Text + TX13.Text + TX14.Text + TX15.Text + TX16.Text + TX17.Text + TX20.Text + TX21.Text + TX22.Text + TX23.Text + TX24.Text + TX25.Text + TX26.Text + TX27.Text, "", "");
            //return;
           
            
            if (Chk_ss1.Checked)
            {
                if (p_Ref(1, 0, true, true))
                {
                    this.ss1.ActiveSheet.Cells[0, 0].Value = this.TX00.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 1].Value = this.TX01.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 2].Value = this.TX02.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 3].Value = this.TX03.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 4].Value = this.TX04.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 5].Value = this.TX05.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 6].Value = this.TX06.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[0, 7].Value = this.TX07.Text == "Y" ? true : false;
                  
                    this.ss1.ActiveSheet.Cells[1, 0].Value = this.TX10.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 1].Value = this.TX11.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 2].Value = this.TX12.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 3].Value = this.TX13.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 4].Value = this.TX14.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 5].Value = this.TX15.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 6].Value = this.TX16.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[1, 7].Value = this.TX17.Text == "Y" ? true : false;
                  
                    this.ss1.ActiveSheet.Cells[2, 0].Value = this.TX20.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 1].Value = this.TX21.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 2].Value = this.TX22.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 3].Value = this.TX23.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 4].Value = this.TX24.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 5].Value = this.TX25.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 6].Value = this.TX26.Text == "Y" ? true : false;
                    this.ss1.ActiveSheet.Cells[2, 7].Value = this.TX27.Text == "Y" ? true : false;

                    if (txt_grd.Text == "1")
                    {
                        CHK_MAIN_GRD1.ForeColor = Color.Red;
                        CHK_MAIN_GRD1.Checked = true;

                        CHK_MAIN_GRD2.ForeColor = Color.Black;
                        CHK_MAIN_GRD2.Checked = false;
                        CHK_MAIN_GRD3.ForeColor = Color.Black;
                        CHK_MAIN_GRD3.Checked = false;
                        CHK_MAIN_GRD5.ForeColor = Color.Black;
                        CHK_MAIN_GRD5.Checked = false;
                        CHK_MAIN_GRD7.ForeColor = Color.Black;
                        CHK_MAIN_GRD7.Checked = false;
                    }
                    else if (txt_grd.Text == "2")
                    {
                        CHK_MAIN_GRD2.ForeColor = Color.Red;
                        CHK_MAIN_GRD2.Checked = true;

                        CHK_MAIN_GRD1.ForeColor = Color.Black;
                        CHK_MAIN_GRD1.Checked = false;
                        CHK_MAIN_GRD3.ForeColor = Color.Black;
                        CHK_MAIN_GRD3.Checked = false;
                        CHK_MAIN_GRD5.ForeColor = Color.Black;
                        CHK_MAIN_GRD5.Checked = false;
                        CHK_MAIN_GRD7.ForeColor = Color.Black;
                        CHK_MAIN_GRD7.Checked = false;
                    }
                    else if (txt_grd.Text == "3")
                    {
                        CHK_MAIN_GRD3.ForeColor = Color.Red;
                        CHK_MAIN_GRD3.Checked = true;

                        CHK_MAIN_GRD1.ForeColor = Color.Black;
                        CHK_MAIN_GRD1.Checked = false;
                        CHK_MAIN_GRD2.ForeColor = Color.Black;
                        CHK_MAIN_GRD2.Checked = false;
                        CHK_MAIN_GRD5.ForeColor = Color.Black;
                        CHK_MAIN_GRD5.Checked = false;
                        CHK_MAIN_GRD7.ForeColor = Color.Black;
                        CHK_MAIN_GRD7.Checked = false;
                    }
                    else if (txt_grd.Text == "5")
                    {
                        CHK_MAIN_GRD5.ForeColor = Color.Red;
                        CHK_MAIN_GRD5.Checked = true;

                        CHK_MAIN_GRD1.ForeColor = Color.Black;
                        CHK_MAIN_GRD1.Checked = false;
                        CHK_MAIN_GRD3.ForeColor = Color.Black;
                        CHK_MAIN_GRD3.Checked = false;
                        CHK_MAIN_GRD2.ForeColor = Color.Black;
                        CHK_MAIN_GRD2.Checked = false;
                        CHK_MAIN_GRD7.ForeColor = Color.Black;
                        CHK_MAIN_GRD7.Checked = false;
                    }
                    else if (txt_grd.Text == "7")
                    {
                        CHK_MAIN_GRD7.ForeColor = Color.Red;
                        CHK_MAIN_GRD7.Checked = true;

                        CHK_MAIN_GRD1.ForeColor = Color.Black;
                        CHK_MAIN_GRD1.Checked = false;
                        CHK_MAIN_GRD3.ForeColor = Color.Black;
                        CHK_MAIN_GRD3.Checked = false;
                        CHK_MAIN_GRD5.ForeColor = Color.Black;
                        CHK_MAIN_GRD5.Checked = false;
                        CHK_MAIN_GRD2.ForeColor = Color.Black;
                        CHK_MAIN_GRD2.Checked = false;
                    }
                  
                }
            }
            else
            {
                if (TXT_From_Date.RawDate.Replace(":", "") == "" || TXT_From_Date.RawDate.Replace(":", "").Length != 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("发生时间输入错误...!!", "W", "");
                    return;
                }

                SDB_TOT_WGT.Text = "";
        
                if (TXT_PRC.Text != "" && TXT_PRC.Text.Length > 1)
                {
                    if (this.TXT_PRC.Text.Substring(0, 1) == "B")
                    {
                        txt_Flag.Text = "C2";
                    }
                    if (this.TXT_PRC.Text.Substring(0, 1) == "C")
                    {
                        txt_Flag.Text = "C2";
                    }
                }
                if (p_Ref(3, 2, true, true))
                {
                    if (this.ss2_Sheet1.RowCount <= 0) return;
                    double temp = 0;
                    for (int i = 0; i < this.ss2_Sheet1.RowCount;i++ )
                    {
                        if (this.ss2_Sheet1.Cells[i, 7].Text != "")
                            temp += double.Parse(this.ss2_Sheet1.Cells[i, 7].Text.Replace(",", ""));     
                    }
                    SDB_TOT_WGT.Text = temp.ToString();
                }
                cbo_ths_d_mat_var.Text = "";
                sdb_ths_d_mat_var.Text = "";
            }

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";

            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";



            GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
            GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
            //GeneralCommon.MDIToolBar.Buttons[10].Visible = false;
            GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
            //GeneralCommon.MDIToolBar.Buttons[11].Visible = false;
            GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";

            GeneralCommon.MDIToolBar.Refresh();


        }

        public override void Form_Pro()
        {
            
           
            if (txt_oper.Text == "1")
            {
                if (this.cbo_slab_no.Text == "" || this.cbo_slab_no.Text.Length != 10)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("板坯号不正确", "W", "系统提示信息");
                    return;
                }
                //if (this.txt_work_date.Text.Replace("-", "").Replace(":", "").Replace(" ","") == "" || this.txt_work_date.Text.Replace("-", "").Replace(":", "").Replace(" ","").Length != 14)
                //{
                //    GeneralCommon.Gp_MsgBoxDisplay("作业日期必须输入", "W", "系统提示信息");
                //    return;
                //}
                //if (this.txt_det_code.Text == "" )
                //{
                //    GeneralCommon.Gp_MsgBoxDisplay("评审原因代码不正确", "W", "系统提示信息");
                //    return;
                //}
                if (txt_proc_cd.Text == "CAD" && txt_det_code.Text != "")
                {
                    if (!GeneralCommon.Gf_MessConfirm("板坯号" + cbo_slab_no.Text + "已处于评审中，确定要再次录入评审原因吗？", "I", "系统提示信息")) return;       
                }
                p_Pro(1, 0, true, false);
            }
            else
            {
                if (this.TXT_OCCR_TIME.RawDate.Replace("-", "") == "" || this.TXT_OCCR_TIME.RawDate.Replace("-", "").Length != 8)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("作业日期必须输入", "W", "系统提示信息");
                    return;
                }
                               
                if (TXT_PRC_INPUT.Text == "" || (TXT_PRC_INPUT.Text.Substring(0, 1) != "B" && TXT_PRC_INPUT.Text.Substring(0, 1) != "C"))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("工序代码错误", "W", "系统提示信息");
                    return;
                }
                if (SDB_SCRAP_WGT.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("废钢重量不能为空", "W", "系统提示信息");
                    return;
                }
                txt_UserId.Text = GeneralCommon.sUserID;

                if (TXT_PRC_INPUT.Text != "" && TXT_PRC_INPUT.Text.Length > 1)
                {
                    if (this.TXT_PRC_INPUT.Text.Substring(0, 1) == "B")
                    {
                        CBO_PLT.Text = "C2";
                    }
                    if (this.TXT_PRC_INPUT.Text.Substring(0, 1) == "C")
                    {
                        CBO_PLT.Text = "C2";
                    }
                }
                CBO_LINE.Text = "1";
                txt_Flag.Text = "C2";

                //if (p_Pro(2, 0, true, true))
                //{
                //    Form_Ref();
                //}
             //   string tteemmpp = MasterCommon.Gf_Ms_MakeQuery((string)(Mc3["P-M"]), "U", (Collection)Mc3["iControl"]);
                if (MasterCommon.Gf_Ms_ExecQuery(GeneralCommon.M_CN1, MasterCommon.Gf_Ms_MakeQuery((string)(Mc2["P-M"]), "U", (Collection)Mc2["iControl"]), Mc2))
                {
                    Form_Ref();
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", "");
                }
            }

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";

            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";



            GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
            GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
            //GeneralCommon.MDIToolBar.Buttons[10].Visible = false;
            GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
            //GeneralCommon.MDIToolBar.Buttons[11].Visible = false;
            GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";

            GeneralCommon.MDIToolBar.Refresh();


            
        }

        public override void Form_Del()
        {

            if (MasterCommon.Gf_Ms_ExecQuery(GeneralCommon.M_CN1, MasterCommon.Gf_Ms_MakeQuery((string)(Mc2["P-M"]), "D", (Collection)Mc2["iControl"]), Mc2))
            {
                Form_Ref();
            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", "");
            }
        }

        protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)sender;
            if (ss.Name != "ss1") return;
            if (e.ColumnHeader) return;
            if (e.RowHeader) return;
            if (this.ss1.ActiveSheet.Cells[e.Row, e.Column].Text != "True")
            {
                if (e.Row == 0)
                {
                    if (e.Column == 0)
                    {
                        TX00.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX00" + TX00.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                        TX01.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX01" + TX01.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX02.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX02" + TX02.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX03.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX03" + TX03.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX04.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX04" + TX04.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX05.Text = "Y";
                    //    GeneralCommon.Gp_MsgBoxDisplay("TX05" + TX05.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX06.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX06" + TX06.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX07.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX07" + TX07.Text, "", "");
                    }
                }
                else if (e.Row == 1)
                {
                    if (e.Column == 0)
                    {
                        TX10.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX10" + TX10.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                        TX11.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX11" + TX11.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX12.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX12" + TX12.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX13.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX13" + TX13.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX14.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX14" + TX14.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX15.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX15" + TX15.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX16.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX16" + TX16.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX17.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX17" + TX17.Text, "", "");
                    }
                }
                else
                {
                    if (e.Column == 0)
                    {
                        TX20.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX20" + TX20.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                        TX21.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX21" + TX21.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX22.Text = "Y";
                     //   GeneralCommon.Gp_MsgBoxDisplay("TX22" + TX22.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX23.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX23" + TX23.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX24.Text = "Y";
                     //   GeneralCommon.Gp_MsgBoxDisplay("TX24" + TX24.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX25.Text = "Y";
                       // GeneralCommon.Gp_MsgBoxDisplay("TX25" + TX25.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX26.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX26" + TX26.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX27.Text = "Y";
                      //  GeneralCommon.Gp_MsgBoxDisplay("TX27" + TX27.Text, "", "");
                    }
                }
            }
            else
            {
                if (e.Row == 0)
                {
                    if (e.Column == 0)
                    {
                        TX00.Text = "N";
                    //    GeneralCommon.Gp_MsgBoxDisplay("TX00" + TX00.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                      TX01.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX01" + TX01.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX02.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX02" + TX02.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX03.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX03" + TX03.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX04.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX04" + TX04.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX05.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX05" + TX05.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX06.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX06" + TX06.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX07.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX07" + TX07.Text, "", "");
                    }
                }
                else if (e.Row == 1)
                {
                    if (e.Column == 0)
                    {
                        TX10.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX10" + TX10.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                        TX11.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX11" + TX11.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX12.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX12" + TX12.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX13.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX13" + TX13.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX14.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX14" + TX14.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX15.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX15" + TX15.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX16.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX16" + TX16.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX17.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX17" + TX17.Text, "", "");
                    }
                }
                else
                {
                    if (e.Column == 0)
                    {
                        TX20.Text = "N";// GeneralCommon.Gp_MsgBoxDisplay("TX20" + TX20.Text, "", "");
                    }
                    else if (e.Column == 1)
                    {
                        TX21.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX21" + TX21.Text, "", "");
                    }
                    else if (e.Column == 2)
                    {
                        TX22.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX22" + TX22.Text, "", "");
                    }
                    else if (e.Column == 3)
                    {
                        TX23.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX23" + TX23.Text, "", "");
                    }
                    else if (e.Column == 4)
                    {
                        TX24.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX24" + TX24.Text, "", "");
                    }
                    else if (e.Column == 5)
                    {
                        TX25.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX25" + TX25.Text, "", "");
                    }
                    else if (e.Column == 6)
                    {
                        TX26.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX26" + TX26.Text, "", "");
                    }
                    else if (e.Column == 7)
                    {
                        TX27.Text = "N"; //GeneralCommon.Gp_MsgBoxDisplay("TX27" + TX27.Text, "", "");
                    }
                }
            }

        }

        //protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        //{
        //    //base.ss_CellClickEvent(sender, e);
        //}

        protected override void ss_EditChange(object sender, EditorNotifyEventArgs e)
        {
            //base.ss_EditChange(sender, e);
        }
        protected override void ss_KeyDownEvent(object sender, KeyEventArgs e)
        {
            //base.ss_KeyDownEvent(sender, e);
        }
        public override void ss_UpdateMark()
        {
            //base.ss_UpdateMark();
        }

        protected override void ss_LeaveCell(object sender, LeaveCellEventArgs e)
        {
            //base.ss_LeaveCell(sender, e);
        }

        protected override void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        {  
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)sender;
            
            if (ss.Name != "ss2") return;
            if (e.ColumnHeader) return;
           // if (e.RowHeader) return;
            
            if(ss.ActiveSheet.RowCount<=0)return;
            TXT_OCCR_TIME.RawDate = ss.ActiveSheet.Cells[e.Row, 0].Text;
            cbo_shift1.Text = ss.ActiveSheet.Cells[e.Row, 1].Text;
            cbo_group1.Text = ss.ActiveSheet.Cells[e.Row, 2].Text;
            TXT_PRC_INPUT.Text = ss.ActiveSheet.Cells[e.Row, 3].Text;
            CBO_SCRAP_INPUT.Text = ss.ActiveSheet.Cells[e.Row, 5].Text;
            TXT_SCRAP_INPUT.Text = ss.ActiveSheet.Cells[e.Row, 5].Text;
            TXT_SCRAP_NO.Text = ss.ActiveSheet.Cells[e.Row, 6].Text;
            SDB_SCRAP_WGT.Text = ss.ActiveSheet.Cells[e.Row, 7].Text;
            txt_code.Text = ss.ActiveSheet.Cells[e.Row, 8].Text;
            txt_main_res_cd.Text = ss.ActiveSheet.Cells[e.Row, 9].Text;
            CBO_PLT.Text = ss.ActiveSheet.Cells[e.Row, 13].Text;

            if (TXT_PRC_INPUT.Text != "")
            {
                TXT_PRC_INPUT_NAME.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, " SELECT CD_SHORT_NAME FROM NISCO.ZP_CD  WHERE CD_MANA_NO = 'C0002' AND CD  ='" + TXT_PRC_INPUT.Text + "'");
                if (TXT_PRC_INPUT.Text.StartsWith("B"))
                {
                    txt_code.Enabled = true;
                    txt_code.sSqletc = "SELECT CD  " + "代码" + ",CD_SHORT_NAME " + "代码简称" + ", CD_NAME  " + "代码名称" + ",CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0011' AND CD like '%' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC";
                }
                if (TXT_PRC_INPUT.Text.StartsWith("C"))
                {
                    txt_code.Enabled = true;
                    txt_code.sSqletc = "SELECT CD  " + "代码" + ",CD_SHORT_NAME " + "代码简称" + ", CD_NAME  " + "代码名称" + ",CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'G0043' AND CD like '%' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC";
                }
            }
            if (txt_code.Text != "")
            {
                if (TXT_PRC_INPUT.Text != "")
                {
                    if (TXT_PRC_INPUT.Text.StartsWith("B"))
                    {
                        txt_main_res_cd.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME  FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0011' AND CD = '" + txt_code.Text + "' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC");
                    }
                    if (TXT_PRC_INPUT.Text.StartsWith("C"))
                    {
                        txt_main_res_cd.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME  FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'G0043' AND CD = '" + txt_code.Text + "' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC");
                    }
                }
            }
        }

        private void TXT_PRC_INPUT_NAME_TextChanged(object sender, EventArgs e)
        {
            if (TXT_PRC_INPUT.Text == "" || TXT_PRC_INPUT_NAME.Text == "")
            {
                txt_code.Enabled = false;
                return;
            }
            if (TXT_PRC_INPUT.Text.StartsWith("B") ) 
            {
                txt_code.Enabled = true;
                txt_code.sSqletc = "SELECT CD  " + "代码" + ",CD_SHORT_NAME " + "代码简称" + ", CD_NAME  " + "代码名称" + ",CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0011' AND CD like '%' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC";
                return;
            }
            if (TXT_PRC_INPUT.Text.StartsWith("C"))
            {
                txt_code.Enabled = true;
                txt_code.sSqletc = "SELECT CD  " + "代码" + ",CD_SHORT_NAME " + "代码简称" + ", CD_NAME  " + "代码名称" + ",CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'G0043' AND CD like '%' AND NVL(CD_SHORT_NAME, '%') like '%' ORDER BY CD ASC";
                return;
            }
            txt_code.Enabled = false;
        }


        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);

            //GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
            //GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";

            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";

            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";



            GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
            GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
            //GeneralCommon.MDIToolBar.Buttons[10].Visible = false;
            GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
            //GeneralCommon.MDIToolBar.Buttons[11].Visible = false;
            GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";

            GeneralCommon.MDIToolBar.Refresh();

           
        }
      
        private void TXT_SCRAP_NO_TextChanged(object sender, EventArgs e)
        {
            //if (flag == 1) return;                                                                                 // 判断变量等于1的时候跳出，否则不等于1的时候调用第三个查询
            //if (porFlag == 1) return;
            //p_Ref(4, 0, true, false);
            SDB_SCRAP_WGT.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT WGT FROM NISCO.FP_SLAB WHERE SLAB_NO='"+ TXT_SCRAP_NO.Text +"'");
            TXT_SCRAP_NO.Enabled = true;
        }

       
      



    }
}
