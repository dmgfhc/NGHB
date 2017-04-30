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
///-- 系统名            宽厚板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            加热炉实绩管理                                
///-- 程序ID            WGB1010C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.12.03                                                
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
    public partial class WGB1010C : CommonClass.FORMBASE
    {
        public WGB1010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Slab_No = 0;  //SS1钢板号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", cbo_slab_no, "PNI", "", "", "", "", imcseq);
            p_SetMc("装炉次数", txt_rhf_ch_num_ref, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", cbo_proc_line, "PNI", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_upd_emp, "NI", "", "", "", "", imcseq);
            p_SetMc("装炉时间", mdt_rhf_ch_time, "NIR", "19", "", "", "", imcseq);
            p_SetMc("修正时间", mdt_rhf_ch_time_upd, "I", "19", "", "", "", imcseq);
            p_SetMc("装炉次数", sdb_rhf_ch_num, "R", "", "", "", "", imcseq);
            p_SetMc("检测温度", sdb_test_temp, "NIR", "", "", "", "", imcseq);
            p_SetMc("重量", sdb_rhf_slab_wgt, "R", "", "", "", "", imcseq);
            p_SetMc("装炉代码", txt_cha_uncha_ind, "NIR", "", "", "", "", imcseq);
            p_SetMc("布料方式", txt_rhf_ch_row, "NIR", "", "", "", "", imcseq);
            p_SetMc("板坯规格", txt_slab_size, "R", "", "", "", "", imcseq);
            p_SetMc("班次", txt_ch_shift, "R", "", "", "", "", imcseq);
            p_SetMc("班别", txt_ch_group, "R", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_ch_emp, "R", "", "", "", "", imcseq);

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("板坯号", cbo_slab_no, "PNI", "", "", "", "", imcseq);
            p_SetMc("装炉次数", txt_rhf_ch_num_ref, "P", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_upd_emp, "PNI", "", "", "", "", imcseq);
            p_SetMc("出炉时间", mdt_discharge_time, "NIR", "19", "", "", "", imcseq);
            p_SetMc("出炉温度", sdb_exp_temp, "NIR", "", "", "", "", imcseq);
            p_SetMc("出炉代码", txt_dis_undis_ind, "NIR", "", "", "", "", imcseq);
            p_SetMc("温度均匀性", sdb_pdt_uni_temp, "NIR", "", "", "", "", imcseq);
            p_SetMc("预热区T", sdb_pre_top_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("预热区B", sdb_pre_bot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("预热区驻留", sdb_pre_zone_time, "IR", "", "", "", "", imcseq);
            p_SetMc("加热1区T", sdb_ht1_top_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热1区B", sdb_ht1_bot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热1区驻留", sdb_ht1_zone_time, "IR", "", "", "", "", imcseq);
            p_SetMc("加热2区T", sdb_ht2_top_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热2区B", sdb_ht2_bot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热2区驻留", sdb_ht2_zone_time, "IR", "", "", "", "", imcseq);
            p_SetMc("加热3区T", sdb_ht3_top_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热3区B", sdb_ht3_bot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("加热3区驻留", sdb_ht3_zone_time, "IR", "", "", "", "", imcseq);
            p_SetMc("均热区T", sdb_sok_hot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("均热区B", sdb_sok_bot_slab_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("均热区驻留", sdb_sok_zone_time, "IR", "", "", "", "", imcseq);
            p_SetMc("班次", txt_discharge_shift, "R", "", "", "", "", imcseq);
            p_SetMc("班别", txt_discharge_group, "R", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_discharge_emp, "R", "", "", "", "", imcseq);

            p_McIni(Mc3,false);
            imcseq = 3;
            p_SetMc("查询状态", txt_sts, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 10, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("布料方式", "E", "20", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("装炉时间", "DT", "19", "L", "", "", "", iscseq, iheadrow,"L");//4
            p_SetSc("出炉时间", "DT", "19", "L", "", "", "", iscseq, iheadrow,"L");//5
            p_SetSc("出炉温度", "N", "4", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//7
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//8
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow);//9

        }
        private void WGB1010C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
        //    base.sAuthority = "1111";
            cbo_proc_line.Text = "1";
            txt_upd_emp.Text = GeneralCommon.sUserID;

            chk_chg.Checked = true;

            //设定表单查询对象为有计划未入炉
            listb_sts.SetSelected(0,true);
            txt_sts.Text = "1";
        }

        // 重写查询
        public override void Form_Ref()
        {

            // 板坯查询（1 有计划未装炉 / 2 已入炉未出炉）
            if (chk_ref.Checked)
            {
                p_Ref(3, 1, true, false);
            }

            // 板坯装炉
            if (chk_chg.Checked & cbo_slab_no.Text.Trim().Length == 10)
            {
                p_Ref(1, 0, true, false);
            }

            // 板坯出炉
            if (chk_dischg.Checked & cbo_slab_no.Text.Trim().Length == 10)
            {
                p_Ref(2, 0, true, false);
            }

        }

        // 重写保存
        public override void Form_Pro()
        {
            //操作人员自动赋登陆用户名值，不许修改
            txt_upd_emp.Text = GeneralCommon.sUserID;
            // 板坯装炉
            if (chk_chg.Checked)
            {
                p_Pro(1, 0, true, false);
            }
            // 板坯出炉
            else
            {
                p_Pro(2, 0, true, false);
            }
        }

        #endregion

        // 板坯装炉
        private void chk_chg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chg.Checked) 
            {
                chk_dischg.Checked = false; 
            }
        }

        // 板坯出炉
        private void chk_dischg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_dischg.Checked) 
            {
                chk_chg.Checked = false;                
            }
        }

        // 装炉代码选择
        private void listb_cha_cd_Click(object sender, EventArgs e)
        {
            txt_cha_uncha_ind.Text = Convert.ToString(listb_cha_cd.SelectedItem).Substring(0, 1);
        }

        //布料方式选择
        private void listb_rhf_row_Click(object sender, EventArgs e)
        {
            txt_rhf_ch_row.Text = Convert.ToString(listb_rhf_row.SelectedItem).Substring(0, 1);
        }

        // 出炉代码选择
        private void listb_discha_cd_Click(object sender, EventArgs e)
        {
            txt_dis_undis_ind.Text = Convert.ToString(listb_discha_cd.SelectedItem).Substring(0, 1);
        }

        // 板坯查询选择
        private void listb_sts_Click(object sender, EventArgs e)
        {
            txt_sts.Text = Convert.ToString(listb_sts.SelectedItem).Substring(0, 1);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {

            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }

            //只有选择行表头才可进行操作
            if (e.Column > 0)
            {
                return;
            }

            //当单击表单时，按照单击行所对应板坯号查询装、出炉信息
            cbo_slab_no.Text = ss1_Sheet1.Cells[e.Row, iSs1_Slab_No].Text;
            Form_Ref();
            cbo_slab_no.Enabled = true;
        }

        private void listb_cha_cd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            cbo_proc_line.Text = "1";
            txt_upd_emp.Text = GeneralCommon.sUserID;
            return true;
        } 

    }
}
