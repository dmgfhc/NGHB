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
///-- 程序名            冷床实绩管理界面                                
///-- 程序ID            WGB1050C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2013.01.06                                                
///-- 处理描述          冷床实绩管理界面                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.01.06        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGG2040C : CommonClass.FORMBASE
    {
        public CGG2040C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Slab_No = 0;  //SS1物料号
        public const int iSs2_Slab_No = 0;  //SS2物料号
        public const int iSs2_Bed_Fl = 4;  //SS2物料号

        #region 界面初始化

        protected override void p_SubFormInit()
        {
 
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("物料号", txt_mill_no, "P", "", "", "", "", imcseq);
            p_SetMc("轧制日期", udt_prod_date, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);
            p_SetMc("冷床", txt_bed_fl, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("物料号", txt_mill_no, "PNIR", "", "", "", "", imcseq);
            p_SetMc("冷床", txt_bed_fl, "PNIR", "", "", "", "", imcseq);
            p_SetMc("冷床代码", txt_bed_cd, "PNI", "", "", "", "", imcseq);
            p_SetMc("上/下冷床时间", mdt_cb_time, "NIR", "", "", "", "", imcseq);
            p_SetMc("上/下冷床温度", sdb_cb_temp, "IR", "", "", "", "", imcseq);
            p_SetMc("作业人员", txt_emp_cd, "NIR", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            //0-6
            p_SetSc("物料号", "E", "12", "P", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板数量", "N", "3", "L", "", "", "", iscseq, iheadrow);
            //6-7
            p_SetSc("生产日期", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");

            p_ScIni(ss2, Sc2, 0, true, true);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("物料号", "E", "12", "L", "", "", "", iscseq, iheadrow);            
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("冷床", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);
            //6-8
            p_SetSc("温度", "N", "4", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow);
            iheadrow = 0;
            p_spanSpread("上冷床", 5, 8, iscseq, iheadrow, 1);

        }
        private void WGB1050C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
         //   base.sAuthority = "1111";
            base.i_ScCurrSeq = 1;
            txt_bed_cd.Text = "1";
        }
        #endregion

        // 分别点选上/下冷床操作
        private void tab_bed_cd_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                base.i_ScCurrSeq = 1;
                txt_bed_cd.Text = "1";
                lab_bed_time.Text = "上冷床时间";
                lab_bed_temp.Text = "上冷床温度";
            }
            else
            {
                base.i_ScCurrSeq = 2;
                txt_bed_cd.Text = "2";
                lab_bed_time.Text = "下冷床时间";
                lab_bed_temp.Text = "下冷床温度";
            }
        }

        // 重写查询
        public override void Form_Ref()
        {
            // 上冷床
            if (base.i_ScCurrSeq==1)
            {
                p_Ref(1, 1, true, false);
            }
            // 下冷床
            else
            {
                p_Ref(1, 2, true, false);
            }
        }

        // 重写保存
        public override void Form_Pro()
        {
            txt_emp_cd.Text = GeneralCommon.sUserID;
            p_Pro(2, 0, true, false);
        }

        private void listb_bed_fl_Click(object sender, EventArgs e)
        {
            txt_bed_fl.Text = Convert.ToString(listb_bed_fl.SelectedItem).Substring(0, 1);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }
            txt_mill_no.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
        }

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss2.ActiveSheet.RowCount == 0)
            {
                return;
            }
            txt_bed_fl.Text = ss2.ActiveSheet.Cells[e.Row, iSs2_Bed_Fl].Text;
            txt_mill_no.Text = ss2.ActiveSheet.Cells[e.Row, iSs2_Slab_No].Text;
        }
    }
}
