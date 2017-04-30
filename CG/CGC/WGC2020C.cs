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
///-- 系统名               宽厚板轧钢作业管理系统                                              
///-- 子系统名             精整作业管理                                                 
///-- 程序名               双边剪实绩管理界面                                
///-- 程序ID               WGC2020C    
///-- 版本                 1.1                                                   
///-- 文档号                                                         
///-- 设计                 李骞                                                    
///-- 代码                 李骞                                                     
///-- 代码日期             2013.02.16                                                
///-- 处理描述             双边剪实绩管理界面                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.02.16        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGC2020C : CommonClass.FORMBASE
    {
        public WGC2020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Mplate_No = 0;  //SS1钢板号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("母板号", txt_moplate_no, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", udt_prod_date, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cmb_Shift, "P", "", "", "", "", imcseq);

            int imcseq1;
            p_McIni(Mc2, true);
            imcseq = 2;
            //0-6
            p_SetMc("母板号", txt_moplate_no, "PNI", "", "", "", "", imcseq);
            p_SetMc("厚度", sdb_bef_thk, "R", "", "", "", "", imcseq);
            p_SetMc("宽度", sdb_bef_wid, "R", "", "", "", "", imcseq);
            p_SetMc("长度", sdb_bef_len, "R", "", "", "", "", imcseq);
            p_SetMc("是否切边", txt_trim_fl, "NIR", "", "", "", "", imcseq);
            p_SetMc("切边后板宽", sdb_wid, "NIR", "", "", "", "", imcseq);
            //6-10
            p_SetMc("切边结束时间", udt_cut_time, "NIR", "", "", "", "", imcseq);
            p_SetMc("移动剪刀缝", sdb_move_gap, "IR", "", "", "", "", imcseq);
            p_SetMc("固定剪刀缝", sdb_fix_gap, "IR", "", "", "", "", imcseq);
            p_SetMc("剪切速度", sdb_cut_speed, "IR", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_emp_cd, "NIR", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("轧制日期", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("下冷床时间", "D", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("是否切边", "E", "1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("剪切宽度", "E", "4", "L", "", "", "", iscseq, iheadrow);

            iheadrow = 0;
            p_spanSpread("轧制规格", 1, 4, iscseq, iheadrow, 1);
            p_spanSpread("切边指示", 9, 10, iscseq, iheadrow, 1);

        }

        private void WGC2020C_Load(object sender, EventArgs e) 
        {
            base.sSvrPgmPkgName = "WGC2020C";
            Form_Define();
     //       base.sAuthority = "1111";
        }
        #endregion

        // 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, false);
        }

        public override void Form_Pro()
        {
            txt_emp_cd.Text = GeneralCommon.sUserID;
            p_pro(2, 0, true, true);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }
            txt_moplate_no.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Mplate_No].Text;
            base.p_Ref(2, 0, true, true);
        }

        private void listb_trim_fl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listb_trim_fl_Click(object sender, EventArgs e)
        {
            txt_trim_fl.Text = Convert.ToString(listb_trim_fl.SelectedItem).Substring(0, 1);
        }

    }
}
