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

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板生产管制系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            精整作业指示查询界面                                
///-- 程序ID            WKB1030C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.11.26                                                
///-- 处理描述          精整作业指示查询                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.11.26        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2030C : CommonClass.FORMBASE
    {
        public CKG2030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();
        Collection Mc5 = new Collection();
        Collection Mc6 = new Collection(); 
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();
        Collection Sc6= new Collection();

        const int SS2_BLOCK_SEQ = 1;
        const int SS2_SEQ = 2;
        const int SS2_PROD_CD = 3;
        const int SS2_ORD = 8;
        const int SS2_SIZE_KND = 9;
        const int SS2_TRIM_FL = 10;
        const int SS2_UST_FL = 11;
        const int SS2_HTM = 12;
        const int SS2_STDSPEC_YY = 13;
        const int SS2_STLGRD = 14;
        const int SS2_VESSEL_NO = 15;
        const int SS2_COLOR_STROKE = 16;


        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "1", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("订单厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("目标厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("厚度下限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("厚度上限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("订单数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("母板数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧制订单", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("轧制结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("板坯规格", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15

            iheadrow = 0;
            p_spanSpread("轧制实绩", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            imcseq = 2;
            iscseq = 2;
            p_McIni(Mc2, false);
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");  // 板坯号

            p_SetSc("板坯号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("牌号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("探伤", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("船号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("订单备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L");//17
           
            
            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "1", "", "", "", imcseq);

            p_ScIni(ss1, Sc3, 0, false, false);
            iheadrow = 1;
            iscseq = 3;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("订单厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("目标厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("厚度下限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("厚度上限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("订单数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("母板数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧制订单", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("轧制结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("板坯规格", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15

            iheadrow = 0;
            p_spanSpread("轧制实绩", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc4, 0, false, false);
            iheadrow = 0;
            imcseq = 4;
            iscseq = 4;
            p_McIni(Mc4, false);
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq); // 板坯号

            p_SetSc("板坯号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("牌号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("探伤", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("船号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("订单备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L");//17



            p_McIni(Mc5, false);
            imcseq = 5;
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "1", "", "", "", imcseq);

            p_ScIni(ss1, Sc5, 0, false, false);
            iheadrow = 1;
            iscseq = 5;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("订单厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("目标厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("厚度下限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("厚度上限", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("订单数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("母板数量", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧制订单", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("轧制结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("板坯规格", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15

            iheadrow = 0;
            p_spanSpread("轧制实绩", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc6, 0, false, false);
            iheadrow = 0;
            imcseq = 6;
            iscseq = 6;
            p_McIni(Mc6, false);
            p_SetMc("板坯号", TXT_SLAB_NO, "P", "", "", "", "", imcseq);  // 板坯号

            p_SetSc("板坯号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("标准", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("牌号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("探伤", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("船号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("订单备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("生产备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L");//17
        }

        private void CKG2030C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKG2030NC";
            Form_Define();
        }

        // 重写查询
        public override void Form_Ref()
        {
            if (OPT_FP_SLAB_DES.Checked)
            {
                p_Ref(1,1,false,false);
            }
            else if (OPT_FP_SLAB_DES1.Checked)
            {
                p_Ref(3, 3, false, false);
            }
            else
            {
                p_Ref(5, 5, false, false);
            } 
        }

            // 重写导出方法
        public override void Spread_Exc()
        {
            // 选择明细导出
            if (this.chk_detail.Checked)
                SpreadCommon.Gp_Sp_Excel(ss2);
            else
                SpreadCommon.Gp_Sp_Excel(ss1);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            int lRow;
            string sBlockSeq;
            string sSeq;

            if (ss1.ActiveSheet.RowCount <= 0) return;


            TXT_SLAB_NO.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text;
            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, 0, ss1.ActiveSheet.RowCount-1, Color.Black, Color.White);
            Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, SSP1.BackColor);
            if (OPT_FP_SLAB_DES.Checked)
            {
                p_Ref(2, 2, false, false);
            }
            else if (OPT_FP_SLAB_DES1.Checked)
            {
                p_Ref(4, 4, false, false);
            }
            else
            {
                p_Ref(6, 6, false, false);
            }
            TXT_SLAB_NO.Text = "";

            for (lRow = 1; lRow <= ss2.ActiveSheet.RowCount; lRow++)
            {

                sBlockSeq = ss2.ActiveSheet.Cells[lRow - 1, SS2_BLOCK_SEQ].Text;
                sSeq = ss2.ActiveSheet.Cells[lRow - 1, SS2_SEQ].Text;

                if (sBlockSeq + sSeq == "0000")
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP1.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "轧件";
                }
                else if (sSeq == "00")
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP2.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "母板" + sBlockSeq;
                }
                else
                {
                    Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, lRow - 1, lRow - 1, Color.Black, SSP3.BackColor);
                    ss2.ActiveSheet.Cells[lRow - 1, SS2_PROD_CD].Text = "钢板";
                }

            }
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

    }
}
