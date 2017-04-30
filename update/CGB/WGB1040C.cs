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
///-- 程序名            DQ/ACC实绩管理界面                                
///-- 程序ID            WGB1040C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.12.20                                                
///-- 处理描述          DQ/ACC实绩管理界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.12.20       李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace CG
{
    public partial class WGB1040C : CommonClass.FORMBASE
    {
        public WGB1040C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Slab_No = 0;  //SS1板坯号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", txt_slab_no, "PIR", "", "", "", "", imcseq);
            p_SetMc("是否投用", txt_use_cd, "NIR", "", "", "", "", imcseq);
            p_SetMc("开冷时间", mdt_start_cooling, "NIR", "", "", "", "", imcseq);
            p_SetMc("终冷时间", mdt_stop_cooling, "NIR", "", "", "", "", imcseq);
            p_SetMc("水温实际值", sdb_temp_water, "IR", "", "", "", "", imcseq);
            p_SetMc("水压实际值", sdb_pressure, "IR", "", "", "", "", imcseq);
            p_SetMc("冷却模式", cbo_cool_mode, "NIR", "", "", "", "", imcseq);
            p_SetMc("头部遮蔽系数", sdb_coe_head, "IR", "", "", "", "", imcseq);
            p_SetMc("尾部遮蔽系数", sdb_coe_tail, "IR", "", "", "", "", imcseq);
            p_SetMc("头部遮蔽长度", sdb_length_head, "IR", "", "", "", "", imcseq);
            p_SetMc("尾部遮蔽长度", sdb_length_tail, "IR", "", "", "", "", imcseq);
            p_SetMc("实际冷却速率", sdb_cooling_rate, "IR", "", "", "", "", imcseq);
            p_SetMc("侧喷开闭状态", txt_side_status, "IR", "", "", "", "", imcseq);
            p_SetMc("钢板运行速度", sdb_speed, "IR", "", "", "", "", imcseq);
            p_SetMc("钢板运行加速度", sdb_acceleration, "IR", "", "", "", "", imcseq);
            p_SetMc("冷却方法", cbo_cool_method, "NIR", "", "", "", "", imcseq);
            p_SetMc("入口钢板上表温度", sdb_temp_entry_surf_up, "IR", "", "", "", "", imcseq);
            p_SetMc("入口钢板下表温度", sdb_temp_entry_surf_down, "IR", "", "", "", "", imcseq);
            p_SetMc("出口钢板上表温度", sdb_temp_exit_up, "IR", "", "", "", "", imcseq);
            p_SetMc("出口钢板下表温度", sdb_temp_exit_surf_down, "IR", "", "", "", "", imcseq);
            p_SetMc("返红钢板表面平均温度", sdb_temp_exit_avg, "IR", "", "", "", "", imcseq);
            p_SetMc("一阶段冷却温度", sdb_part1_temp_cal, "IR", "", "", "", "", imcseq);
            p_SetMc("一阶段冷却速率", sdb_part1_cooling_rate_cal, "IR", "", "", "", "", imcseq);
            p_SetMc("二阶段冷却速率", sdb_part2_cooling_rate_cal, "IR", "", "", "", "", imcseq);
            p_SetMc("终轧弛豫时间", sdb_aft_rolling_time, "IR", "", "", "", "", imcseq);
            p_SetMc("操作模式", txt_opr_mode, "NIR", "", "", "", "", imcseq);
            p_SetMc("通过模式", txt_thr_mode, "NIR", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_empid, "NILR", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("生产时间", udt_prod_date, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);
            p_SetMc("板坯号", txt_slab_no, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("轧制结束时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("板坯规格", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");
            //6-10
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");
            p_SetSc("DQ/ACC 是否投用", "E", "10", "L", "", "", "", iscseq, iheadrow);

            iheadrow = 0;
            p_spanSpread("轧制实绩", 5, 7, iscseq, iheadrow, 1);

        }
        private void WGB1040C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
          //  base.sAuthority = "1111";
            txt_empid.Text = GeneralCommon.sUserID;
        }
        #endregion

        // 重写查询
        public override void Form_Ref()
        {

            //查询轧制信息
            if (txt_slab_no.Text == "")
            {
                p_Ref(2, 1, true, false);
            }
            else
            {
                p_Ref(1, 0, true, true);
            }

        }

        #region 选择项目定义
        //是否投用
        private void listb_use_cd_Click(object sender, EventArgs e)
        {
            txt_use_cd.Text = Convert.ToString(listb_use_cd.SelectedItem).Substring(0, 1);
        }

        //操作模式
        private void listb_opr_mode_Click(object sender, EventArgs e)
        {
            txt_opr_mode.Text = Convert.ToString(listb_opr_mode.SelectedItem).Substring(0, 1);
        }

        //通过模式
        private void listb_thr_mode_Click(object sender, EventArgs e)
        {
            txt_thr_mode.Text = Convert.ToString(listb_thr_mode.SelectedItem).Substring(0, 1);
        }  
        #endregion      

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }

            //只有选择行表头才可进行操作
            if (e.Column > 0 & e.Row < 1)
            {
                return;
            }

            txt_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
            //base.p_Ref(1, 0, true, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_empid.Text = GeneralCommon.sUserID;
            return true;
        }

    }
}
