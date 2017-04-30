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
///-- 程序名            轧制实绩管理                                
///-- 程序ID            WGB1020C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.12.19                                                
///-- 处理描述          轧制实绩管理                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.12.19        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///
namespace CG
{
    public partial class WGB1020C : CommonClass.FORMBASE
    {
        public WGB1020C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Slab_No = 0;  //SS1钢板号
        public int iMinNum = 0;

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;
            //1-5
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);   
            p_SetSc("出炉时间", "DT", "19", "L", "", "", "", iscseq, iheadrow,"L");  
            p_SetSc("轧钢时间", "DT", "19", "L", "", "", "", iscseq, iheadrow,"L");  
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");    
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");   
            //6-10
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);   
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");   
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");   
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R"); 
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow,"R");

            iheadrow = 0;
            p_spanSpread("轧制指示", 3, 4, iscseq, iheadrow, 1);
            p_spanSpread("板坯规格", 6, 9, iscseq, iheadrow, 1);

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("是否有轧制信息", chk_mill_fl, "P", "", "", "", "", imcseq);
            p_SetMc("出炉时间范围", sdb_rht_time, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, true);
            imcseq = 2;
            //1-5
            p_SetMc("板坯号", txt_slab_no, "PNIR", "10", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "I", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_emp, "NIL", "", "", "", "", imcseq);
            p_SetMc("开轧时间", mdt_mill_sta_time, "NIR", "", "", "", "", imcseq);
            p_SetMc("终轧时间", mdt_mill_end_time, "NIR", "", "", "", "", imcseq);
            //6-10
            p_SetMc("控轧代码", txt_cr_setup, "IR", "", "", "", "", imcseq);
            p_SetMc("1#开始温度", sdb_cr1_str_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("1#厚度比", sdb_cr1_red_ga_pct, "IR", "", "", "", "", imcseq);
            p_SetMc("1#开轧温度(测量)", sdb_cr1_reduct_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("2#厚度比", sdb_cr2_red_ga_pct, "IR", "", "", "", "", imcseq);
            //11-15
            p_SetMc("2#开轧温度(测量)", sdb_cr2_reduct_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("平均厚度", sdb_ave_thk, "NIR", "", "", "", "", imcseq);
            p_SetMc("平均宽度", sdb_ave_wid, "NIR", "", "", "", "", imcseq);
            p_SetMc("头部厚度", sdb_head_gauge, "IR", "", "", "", "", imcseq);
            p_SetMc("中部厚度", sdb_body_gauge, "IR", "", "", "", "", imcseq);
            //16-20
            p_SetMc("尾部厚度", sdb_tail_gauge, "IR", "", "", "", "", imcseq);
            p_SetMc("轧制长度", sdb_slab_len, "NIR", "", "", "", "", imcseq);
            p_SetMc("轧制模式", txt_rolling_mode, "IR", "", "", "", "", imcseq);
            p_SetMc("产品类型", cbo_prod_cd, "NIR", "", "", "", "", imcseq);
            p_SetMc("LP头部厚度", sdb_taper_hd_thk, "IR", "", "", "", "", imcseq);
            //21-25
            p_SetMc("LP尾部厚度", sdb_taper_tl_thk, "IR", "", "", "", "", imcseq);
            p_SetMc("LP长度1", sdb_taper_l1_len, "IR", "", "", "", "", imcseq);
            p_SetMc("LP长度2", sdb_taper_l2_len, "IR", "", "", "", "", imcseq);
            p_SetMc("LP长度3", sdb_taper_l3_len, "IR", "", "", "", "", imcseq);
            p_SetMc("LP长度4", sdb_taper_l4_len, "IR", "", "", "", "", imcseq);
            //26-32
            p_SetMc("LP长度5", sdb_taper_l5_len, "IR", "", "", "", "", imcseq);
            p_SetMc("终轧温度", sdb_mill_end_ave_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("终轧道次", sdb_rolling_pass, "IR", "", "", "", "", imcseq);
            p_SetMc("班次", txt_mill_shift, "R", "", "", "", "", imcseq);
            p_SetMc("班别", txt_mill_group, "R", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_mill_emp, "R", "", "", "", "", imcseq);
            p_SetMc("卡量厚度", sdb_insp_thk, "IR", "", "", "", "", imcseq);
            p_SetMc("氧化铁皮颜色", TXT_COLOR, "IR", "", "", "", "", imcseq);
            p_SetMc("氧化铁皮完整性", TXT_COMPLETE, "IR", "", "", "", "", imcseq);
            p_SetMc("轧制异常", TXT_EXCEPTION, "IR", "", "", "", "", imcseq);

            p_McIni(Mc3, true);
            imcseq = 3;
            //1-5
            p_SetMc("板坯号", txt_slab_no, "PNI", "10", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "I", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_emp, "NI", "", "", "", "", imcseq);
            p_SetMc("缺号时间", mdt_rej_occr_time, "NIR", "", "", "", "", imcseq);
            p_SetMc("缺号代码", f4ETCR1, "NIR", "", "", "", "", imcseq);
            //6-10
            p_SetMc("班次", txt_rej_shift, "R", "", "", "", "", imcseq);
            p_SetMc("班别", txt_rej_group, "R", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_rej_emp, "R", "", "", "", "", imcseq);

        }

        private void WGB1020C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
            txt_emp.Text = GeneralCommon.sUserID;
            rdo_manual.Checked = true;
        }
        #endregion


        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, true);
            if (txt_slab_no.Text.Trim().Length == 10)
            {
                base.p_Ref(2, 0, true, true);
            }

            chk_rej_fl.Checked = false;
            //else if (txt_slab_no.Text.Trim().Length == 10 && chk_rej_fl.Checked == true)
            //{
            //    base.p_Ref(2, 0, true, true);
            //    base.p_Ref(3, 0, true, true);
            //}
            return;
        }
        #endregion

        #region //保存
        public override void Form_Pro()
        {
            if (cbo_prod_cd.Text == "LP")
            {
                if (sdb_taper_hd_thk.Text == "" || sdb_taper_tl_thk.Text == "" || sdb_taper_l1_len.Text == "" || sdb_taper_l2_len.Text == "" || sdb_taper_l3_len.Text == "" || sdb_taper_l4_len.Text == "" || sdb_taper_l5_len.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("产品为LP板，必须录入LP板相关实绩信息！", "", "");
                    return;
                }
            }

            //操作人员赋值
            txt_emp.Text = GeneralCommon.sUserID;
            //轧制实绩保存
            if (chk_rej_fl.Checked == false)
            {
                base.p_pro(2, 0, true, false);
            }
            else  //缺号实绩保存
            {
                base.p_pro(3, 0, true, false);
            }

            return;
        }
        #endregion

        #region //选择操作控制
        private void listb_rolling_mode_Click(object sender, EventArgs e)
        {
            txt_rolling_mode.Text = Convert.ToString(listb_rolling_mode.SelectedItem).Substring(0, 1);
        }

        private void listb_cr_cd_Click(object sender, EventArgs e)
        {
            txt_cr_setup.Text = Convert.ToString(listb_cr_cd.SelectedItem).Substring(0, 1);
        }
        #endregion

        #region // 时钟控制
        private void rdo_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_manual.Checked)
            {
                timer_ref.Enabled = false;
            }
        }
        private void rdo_automatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_automatic.Checked)
            {
                timer_ref.Enabled = true;
            }
        }
        //时钟初始化为1分钟；刷新频率单位为分钟；
        private void timer_ref_Tick(object sender, EventArgs e)
        {
            iMinNum = iMinNum + 1;
            if (iMinNum == sdb_time.NumValue)
            {
                base.p_Ref(1, 1, true, true);
                iMinNum = 0;
            }
        }
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }
            txt_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
            base.p_Ref(2, 0, true,false);

            if (ss1.ActiveSheet.Cells[e.Row,2].Text.Length > 0)
            {
                mdt_mill_sta_time.Enabled = false;
                mdt_mill_end_time.Enabled = false;
            }
            else
            {
                mdt_mill_sta_time.Enabled = true;
                mdt_mill_end_time.Enabled = true;
            }

            chk_rej_fl.Checked = false;
        }
        public override bool Form_Cls()
        {
            base.Form_Cls();
            //mdt_mill_sta_time.Enabled = true;
            //mdt_mill_end_time.Enabled = true;
            chk_rej_fl.Checked = false;
            return true;
        }

        private void OPT_A_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_A.Checked)
            {
                OPT_A.ForeColor = Color.Red;
                OPT_B.ForeColor = Color.Black;
                OPT_C.ForeColor = Color.Black;
                TXT_COLOR.Text = "A级";
                if (OPT_B.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
                if (OPT_C.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
            }
            else
                OPT_A.ForeColor = Color.Black;
        }

        private void OPT_B_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_B.Checked)
            {
                OPT_B.ForeColor = Color.Red;
                OPT_A.ForeColor = Color.Black;
                OPT_C.ForeColor = Color.Black;
                TXT_COLOR.Text = "B级";
                if (OPT_A.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
                if (OPT_C.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
            }
            else
                OPT_B.ForeColor = Color.Black;
        }

        private void OPT_C_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_C.Checked)
            {
                OPT_C.ForeColor = Color.Red;
                OPT_A.ForeColor = Color.Black;
                OPT_B.ForeColor = Color.Black;
                TXT_COLOR.Text = "C级";
                if (OPT_A.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
                if (OPT_B.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮颜色", "", "");
                    return;
                }
            }
            else
                OPT_C.ForeColor = Color.Black;
        }

        private void OPT_1_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_1.Checked)
            {
                OPT_1.ForeColor = Color.Red;
                OPT_2.ForeColor = Color.Black;
                OPT_3.ForeColor = Color.Black;
                TXT_COMPLETE.Text = "1级";
                if (OPT_2.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
                if (OPT_3.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
            }
            else
                OPT_1.ForeColor = Color.Black;
        }

        private void OPT_2_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_2.Checked)
            {
                OPT_2.ForeColor = Color.Red;
                OPT_1.ForeColor = Color.Black;
                OPT_3.ForeColor = Color.Black;
                TXT_COMPLETE.Text = "2级";
                if (OPT_1.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
                if (OPT_3.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
            }
            else
                OPT_2.ForeColor = Color.Black;
        }

        private void OPT_3_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_3.Checked)
            {
                OPT_3.ForeColor = Color.Red;
                OPT_1.ForeColor = Color.Black;
                OPT_2.ForeColor = Color.Black;
                TXT_COMPLETE.Text = "3级";
                if (OPT_1.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
                if (OPT_2.Checked)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只能选择一种氧化铁皮完整性", "", "");
                    return;
                }
            }
            else
                OPT_3.ForeColor = Color.Black;
        }

    }
}