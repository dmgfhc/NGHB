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
//-- Program Name      板坯垛位修改及查询
//-- Program ID        CGA2060C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        板坯垛位修改及查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2060C : CommonClass.FORMBASE
    {
        public CGA2060C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        //const int SPD_PLAN_PROD_WGT = 33,
        const int SPD_STLGRD = 0,
                  SPD_THK = 1;
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始时间",sdt_in_plt_date, "NP", "", "", "", "", imcseq);
            p_SetMc("结束时间",sdt_out_plt_date, "NP", "", "", "", "",imcseq);

            p_ScIni(ss1, Sc1, 0, true, true);
            
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("其它", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27

            iheadrow = 0;

            p_spanSpread("钢种", 0, 0, iscseq, iheadrow, 2);
            p_spanSpread("厚度", 1, 1, iscseq, iheadrow, 2);
            p_spanSpread("宽度", 2, 2, iscseq, iheadrow, 2);

            p_spanSpread("入库现状-板卷厂", 3, 4, iscseq, iheadrow, 1);
            p_spanSpread("入库现状-老炼钢", 5, 6, iscseq, iheadrow, 1);
            p_spanSpread("入库现状-其他", 7, 8, iscseq, iheadrow, 1);
            p_spanSpread("出库现状-板卷厂", 9, 10, iscseq, iheadrow, 1);
            p_spanSpread("出库现状-老炼钢", 11, 12, iscseq, iheadrow, 1);
            p_spanSpread("出库现状-其他", 13, 14, iscseq, iheadrow, 1);
            p_spanSpread("使用现状-板卷厂", 15, 16, iscseq, iheadrow, 1);
            p_spanSpread("使用现状-老炼钢", 17, 18, iscseq, iheadrow, 1);
            p_spanSpread("使用现状-其他", 19, 20, iscseq, iheadrow, 1);
            p_spanSpread("库存现状-板卷厂", 21, 22, iscseq, iheadrow, 1);
            p_spanSpread("库存现状-老炼钢", 23, 24, iscseq, iheadrow, 1);
            p_spanSpread("库存现状-其他", 25, 26, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2060NC";
            Form_Define();
            sdt_in_plt_date.RawDate = DateTime.Today.ToString();
            sdt_out_plt_date.RawDate = DateTime.Today.ToString();

       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);

            setStlgrd(ss1); //钢种统计

            setThk(ss1);//厚度统计

            setAll(ss1);//综合统计

        }


        //设置 spread钢种的统计效果
        protected void setStlgrd(FpSpread e)
        {
            //表单无数据返回
            if (e.Sheets[0].RowCount == 0)
            {
                return;
            }
            else
            {
                int rowCount = e.Sheets[0].RowCount;
                int columnCount = e.Sheets[0].ColumnCount;

                //记录用于计算的开始和结束的行号
                int rowStart = 0;
                int rowEnd = 0;
                double sumStlgrd = 0;

                //需要添加钢种小计 和厚度小计，最大不可能超过行数的3倍，在程序中判断执行到最后一行退出
                rowCount = rowCount * 2;

                //通过当前行号和之前行号的记录来判断是否进行汇总
                String spread_stlgrd_bf = e.Sheets[0].Cells.Get(0, SPD_STLGRD).Value.ToString();
                String spread_stlgrd = e.Sheets[0].Cells.Get(0, SPD_STLGRD).Value.ToString();

                //遍历所有行，判断需要进行汇总的行
                for (int i = 0; i <= rowCount; i++)
                {

                    spread_stlgrd = e.Sheets[0].Cells.Get(i, SPD_STLGRD).Value.ToString();

                    //记录前一个行号
                    if (i - 1 >= 0)
                    {
                        spread_stlgrd_bf = e.Sheets[0].Cells.Get(i - 1, SPD_STLGRD).Value.ToString();
                    }

                    //添加钢种
                    if (spread_stlgrd_bf != spread_stlgrd)
                    {
                        rowEnd = i - 1; //之前一行作为后面计算的最后一行;

                        e.Sheets[0].Rows.Add(i, 1);//添加一行

                        e.Sheets[0].Cells[i, 0].Value = "钢种：" + spread_stlgrd_bf;

                        lockColor(e, i, "#E6E6FF");//修改背景色

                        for (int j = 3; j < columnCount - 1; j++)
                        {
                            for (int k = rowStart; k <= rowEnd; k++)
                            {
                                sumStlgrd += Convert.ToDouble(e.Sheets[0].Cells[k, j].Value);
                            }
                            e.Sheets[0].Cells[i, j].Value = sumStlgrd;
                            sumStlgrd = 0;
                        }
                        rowStart = i + 1; //将添加之后的下一列作为新的计算行;

                        i = i + 1;//跳过当前添加的行
                    }


                    //最后一列添加完之后退出 行数减1等于行索引
                    if (e.Sheets[0].RowCount - 1 == i)
                    {
                        rowEnd = i; //如果是最后一行直接计算就可以了

                        e.Sheets[0].Rows.Add(i + 1, 1);//添加一行

                        spread_stlgrd = e.Sheets[0].Cells.Get(i, SPD_STLGRD).Value.ToString();

                        e.Sheets[0].Cells[i + 1, 0].Value = "钢种：" + spread_stlgrd;

                        lockColor(e, i+1, "#E6E6FF");//修改背景色

                        for (int j = 3; j < columnCount - 1; j++)
                        {
                            for (int k = rowStart; k <= rowEnd; k++)
                            {
                                sumStlgrd += Convert.ToDouble(e.Sheets[0].Cells[k, j].Value);
                            }
                            e.Sheets[0].Cells[i + 1, j].Value = sumStlgrd;
                            sumStlgrd = 0;
                        }

                        return;
                    }
                }
            }
        }



        //设置 spread厚度的统计效果
        protected void setThk(FpSpread e)
        {
            //表单无数据返回
            if (e.Sheets[0].RowCount == 0)
            {
                return;
            }
            else
            {
                int rowCount = e.Sheets[0].RowCount;
                int columnCount = e.Sheets[0].ColumnCount;

                //记录用于计算的开始和结束的行号
                int rowStart = 0;
                int rowEnd = 0;
                double sumThk = 0;

                //需要添加钢种小计 和厚度小计，最大不可能超过行数的3倍，在程序中判断执行到最后一行退出
                rowCount = rowCount * 2;

                //通过当前行号和之前行号的记录来判断是否进行汇总
                String spread_thk_bf = e.Sheets[0].Cells[0, SPD_THK].Text;
                
                String spread_thk = e.Sheets[0].Cells[0, SPD_THK].Text;

                 String spread_stlgrd = e.Sheets[0].Cells[0, SPD_STLGRD].Text;

                //遍历所有行，判断需要进行汇总的行
                for (int i = 0; i <= rowCount; i++)
                {

                    spread_thk = e.Sheets[0].Cells[i,SPD_THK].Text;

                    spread_stlgrd = e.Sheets[0].Cells[i, SPD_STLGRD].Text;

                    //记录前一个行号
                    if (i - 1 >= 0 && spread_stlgrd.Substring(0, 1) != "钢" && ""!=e.Sheets[0].Cells[i - 1, SPD_THK].Text)
                    {
                        spread_thk_bf = e.Sheets[0].Cells[i - 1, SPD_THK].Text;
                    }


                    if (spread_stlgrd.Substring(0, 1) == "钢")
                    {
                        rowEnd = i-1; //如果是钢种就直接将前面的汇总

                        e.Sheets[0].Rows.Add(i, 1);//添加一行

                        lockColor(e, i, "#E6E6FF");//修改背景色

                        spread_thk = e.Sheets[0].Cells[i-1, SPD_THK].Text;

                        e.Sheets[0].Cells[i, SPD_THK].Value = "厚度：" + spread_thk;

                        for (int j = 3; j < columnCount - 1; j++)
                        {
                            for (int k = rowStart; k <= rowEnd; k++)
                            {
                                sumThk += Convert.ToDouble(e.Sheets[0].Cells[k, j].Value);
                            }
                            
                            e.Sheets[0].Cells[i, j].Value = sumThk;
                            
                            sumThk = 0;
                        }

                        if (i + 1 != e.Sheets[0].RowCount - 1)
                        {

                            rowStart = i + 2;//去除厚度小计及钢种小计

                            spread_thk_bf = e.Sheets[0].Cells[i + 2, SPD_THK].Text;//保持前后厚度一致避免触发下一个条件

                            spread_thk = e.Sheets[0].Cells[i + 2, SPD_THK].Text;//保持前后厚度一致避免触发下一个条件

                            i = i + 1;//跳过当前添加行
                        }
                        else
                        {
                            return;
                        }
                    }

                    //添加厚度
                    if (spread_thk_bf != spread_thk)
                    {
                        rowEnd = i - 1; //之前一行作为后面计算的最后一行;

                        e.Sheets[0].Rows.Add(i, 1);//添加一行

                        lockColor(e, i, "#E6E6FF");//修改背景色

                        e.Sheets[0].Cells[i, SPD_THK].Value = "厚度：" + spread_thk_bf;

                        for (int j = 3; j < columnCount - 1; j++)
                        {
                            for (int k = rowStart; k <= rowEnd; k++)
                            {
                                sumThk += Convert.ToDouble(e.Sheets[0].Cells[k, j].Value);
                            }
                            e.Sheets[0].Cells[i, j].Value = sumThk;
                            sumThk = 0;
                        }
                        rowStart = i + 1; //将添加之后的下一列作为新的计算行;

                        i = i + 1;//跳过当前添加的行
                    }
                }
            }
        }


        protected void setAll(FpSpread e)
        {
            //表单无数据返回
            if (e.Sheets[0].RowCount == 0)
            {
                return;
            }
            else
            {
                int rowStart = 0;
                int rowEnd = 0;
                double sumAll = 0;

                int rowCount = e.Sheets[0].RowCount;

                int columnCount = e.Sheets[0].ColumnCount;
                
                String spread_stlgrd;

                e.Sheets[0].Rows.Add(rowCount, 1);//末尾添加一行
                e.Sheets[0].Cells[rowCount,0].Value = "合计";

                //SpreadCommon.Gp_Sp_ColLock

                lockColor(e, rowCount, "#FFE6E6");//修改背景色


                for (int i = 0; i < rowCount; i++)
                {
                    spread_stlgrd = e.Sheets[0].Cells[i, SPD_STLGRD].Text;

                    if (""!=spread_stlgrd && "钢"==spread_stlgrd.Substring(0, 1))
                    {
                        for (int j = 3; j < columnCount - 1; j++)
                        {
                            e.Sheets[0].Cells[rowCount, j].Value = Convert.ToDouble(e.Sheets[0].Cells[i, j].Value) + Convert.ToDouble(e.Sheets[0].Cells[rowCount, j].Value);
                        }
                    }
                }
            }
        }

        //修改锁定颜色方法
        public void lockColor(FpSpread e,int rowNo,String BackColor)
        {
            int columnCount = e.Sheets[0].ColumnCount;

            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;

                e.ActiveSheet.Cells[rowNo, i].BackColor = ColorTranslator.FromHtml(BackColor);
            }
        }

        
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }


            Color rowColor = ss1.ActiveSheet.Cells[e.Row, e.Column].BackColor;
            Color color1 = ColorTranslator.FromHtml("#FFE6E6");
            Color color2 = ColorTranslator.FromHtml("#E6E6FF");

            if (!rowColor.Equals(color1) && !rowColor.Equals(color2))
            {
            Gf_IsFormLoad("CGA2061C");
            CGA2061C CGA2061C = new CGA2061C();
            CGA2061C.MdiParent = GeneralCommon.MDIMain;
            CGA2061C.Show();
            CGA2061C.sdt_in_plt_date.RawDate = this.sdt_in_plt_date.RawDate;
            CGA2061C.sdt_out_plt_date.RawDate = this.sdt_out_plt_date.RawDate;
            CGA2061C.txt_plt.Text = "B1";
            CGA2061C.txt_act_stlgrd.Text = this.ss1.ActiveSheet.Cells[e.Row, 27].Value.ToString();
            CGA2061C.txt_thk.Text = this.ss1.ActiveSheet.Cells[e.Row, 1].Value.ToString();
            CGA2061C.txt_thk_to.Text = this.ss1.ActiveSheet.Cells[e.Row, 1].Value.ToString();
            CGA2061C.txt_wid.Text = this.ss1.ActiveSheet.Cells[e.Row, 2].Value.ToString();
            CGA2061C.txt_wid_to.Text = this.ss1.ActiveSheet.Cells[e.Row, 2].Value.ToString();
            CGA2061C.Form_Ref();
            CGA2061C.WindowState = FormWindowState.Maximized;
            }
        }


        public void Gf_IsFormLoad(string sFormID)
        {
            if (!(GeneralCommon.MDIMain.MdiChildren == null))
            {
                foreach (Form frm in GeneralCommon.MDIMain.MdiChildren)
                {
                    if ("CGA2061C" == frm.Name)
                    {
                        frm.Close();
                    }
                }
            }
        }


    }
}