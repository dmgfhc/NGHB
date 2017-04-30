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
///-- 程序头注释 +++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板热处理系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            宽厚板热处理作业指示调整下达界面                              
///-- 程序ID            FKA1010C    
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              李超                                                    
///-- 代码              李超                                                    
///-- 代码日期          2014.07.28                                               
///-- 处理描述          宽厚板热处理指示调整下达
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.28         李超                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace FG
{
    public partial class FKA1010C : CommonClass.FORMBASE
    {
        public FKA1010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_DEL_TO_DATE = 22,
                  SPD_LEND = 20,
                  SPD_PRC_STS = 21,
                  SPD_STATUE = 0;

                  

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLT, "PR", "", "", "", imcseq, "");  // 轧制序号
            p_SetMc(cbo_PrcLine, "PR", "", "", "", imcseq, "");      // 起始板坯号
            p_SetMc(TXT_SB, "PR", "", "", "", imcseq, "");        // 抛丸
            p_SetMc(TXT_HTM_METH1, "PR", "", "", "", imcseq, "");    // 热处理方法
            p_SetMc(COB_HTM_COND, "PR", "", "", "", imcseq, "");    // 热处理条件
            p_SetMc(TXT_MAT_NO, "PR", "", "", "", imcseq, "");    // 物料号


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("作业种类", "E", "1", "IL", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("edt_seq", "N", "8", "IL", "", "", "", iscseq, iheadrow, "R");//1
            p_SetSc("物料号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产线别", "E", "1", "IL", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("期限日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("标准号", "E", "20", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("当前位置", "E", "10", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("抛丸指示", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("抛丸状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("热处理指示", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("热处理状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("产品代码", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("宽厚", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("UST", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("取样", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("热处理方法(生产部)", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("热处理方法", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("备注", "E", "50", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("指示状态", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//20
            p_SetSc("进程状态", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("交货日期", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("指示分类", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("计划人", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//24

            iheadrow = 0;
            p_spanSpread("产品规格",12,14, iscseq, iheadrow, 1);
           // p_spanSpread("钢板规格", 3, 6, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
        }
        private void FKA1010C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_PLT.Text = "C2";
            cbo_PrcLine.Text = "1";
      
            string sQuery = "";
            sQuery = "SELECT HTM_COND,HTM_COND_TXT, HTM_TEMP_TGT,HTM_TIME_1F_AIM,HTM_TIME_2F_AIM,HTM_COOL_TYP, HTM_COOL_TMP FROM NISCO.QP_HEAT_COND";
            Gf_ComboAdd(COB_HTM_COND, sQuery);
            rdo_send.Checked = true;
            rdo_send.ForeColor = Color.Red;
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            TXT_PLT.Text = "C2";
            cbo_PrcLine.Text = "1";
            TXT_PLT_NAME.Text = "宽厚板厂";
            return true;
        }

        public override void Form_Ref()
        {
            //this.TXT_TOT_SHEETS.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT SUM(CASE WHEN PRC_STS = 'A' THEN 1 ELSE 0 END) || '/' ||SUM(CASE WHEN PRC_STS = 'B' THEN 1 ELSE 0 END) FROM EP_HTM_INS  WHERE PRC_STS IN ('A','B') AND INS_LOC = 'H' AND PLT = 'C2'");

            base.p_Ref(1, 1, true, false);
            //SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[1], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], true);
            if (ss1.ActiveSheet.RowCount < 1)
            {
                return;
            }
            this.TXT_TOT_SHEETS.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT SUM(CASE WHEN PRC_STS = 'A' THEN 1 ELSE 0 END) || '/' ||SUM(CASE WHEN PRC_STS = 'B' THEN 1 ELSE 0 END) FROM EP_HTM_INS  WHERE PRC_STS IN ('A','B') AND PLT = 'C2'");
            int XX = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL"));

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (int.Parse(ss1.ActiveSheet.Cells[lRow, SPD_DEL_TO_DATE].Text.Replace("-", "")) < XX)
                {
                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Red, Color.White);
                }

                if ( ss1.ActiveSheet.Cells[lRow, SPD_LEND].Text == "B")
                {
                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label6.BackColor);
                }
                else if (ss1.ActiveSheet.Cells[lRow, SPD_LEND].Text == "Y")
                {
                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label7.BackColor);
                }

                if ( ss1.ActiveSheet.Cells[lRow, SPD_PRC_STS].Text == "B")
                {
                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label6.BackColor);
                }
            }

            /////////
            for (int i = 0; i < this.ss1.ActiveSheet.RowCount;i++ )
            {
                if (this.ss1.ActiveSheet.Cells[i, 20].Text != "Y")
                    this.ss1.ActiveSheet.Rows.Get(i).BackColor = Color.White;
            }
            /////////


        }

        public override void Form_Pro()
        {
            if (p_pro(0, 1, true, true))
            {
                SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[1], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], true);
                if (ss1.ActiveSheet.RowCount < 1)
                {
                    return;
                }

                int XX = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL"));

                for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                {
                    if (int.Parse(ss1.ActiveSheet.Cells[lRow, SPD_DEL_TO_DATE].Text.Replace("-", "")) < XX)
                    {
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Red, Color.White);
                    }

                    if (ss1.ActiveSheet.Cells[lRow, SPD_LEND].Text == "B")
                    {
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label6.BackColor);
                    }
                    else if (ss1.ActiveSheet.Cells[lRow, SPD_LEND].Text == "Y")
                    {
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label7.BackColor);
                    }

                    if (ss1.ActiveSheet.Cells[lRow, SPD_PRC_STS].Text == "B")
                    {
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, label6.BackColor);
                    }

                    /////////
                    for (int i = 0; i < this.ss1.ActiveSheet.RowCount; i++)
                    {
                        if (this.ss1.ActiveSheet.Cells[i, 20].Text != "Y")
                            this.ss1.ActiveSheet.Rows.Get(i).BackColor = Color.White;
                    }
                    /////////

                }
            }
           // Form_Ref();
           //
          
            return;
            //Form_Ref();
        }

        private void rdo_cancel_Click(object sender, EventArgs e)
        {
            if (rdo_cancel.Checked)
            {
                rdo_cancel.ForeColor = System.Drawing.Color.Red;
                rdo_send.ForeColor = System.Drawing.Color.Black;
                rdo_delete.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rdo_cancel.ForeColor = System.Drawing.Color.Black;
            }

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                ss1.ActiveSheet.Cells[lRow, SPD_STATUE].Text = "C";
            }
        }

        private void rdo_delete_Click(object sender, EventArgs e)
        {
            if(rdo_delete.Checked)
            {
                rdo_delete.ForeColor = System.Drawing.Color.Red;
                rdo_cancel.ForeColor = System.Drawing.Color.Black;
                rdo_send.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rdo_delete.ForeColor = System.Drawing.Color.Black;
            }

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                ss1.ActiveSheet.Cells[lRow, SPD_STATUE].Text = "D";
            }
        }

        private void rdo_send_Click(object sender, EventArgs e)
        {
            if(rdo_send.Checked)
            {
                rdo_send.ForeColor = System.Drawing.Color.Red;
                rdo_cancel.ForeColor = System.Drawing.Color.Black;
                rdo_delete.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                rdo_send.ForeColor = System.Drawing.Color.Black;
            }
            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                ss1.ActiveSheet.Cells[lRow, SPD_STATUE].Text = "S";
            }
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (this.ss1.ActiveSheet.RowCount == 0) return;
            string sRowLabel;
            sRowLabel = ss1.ActiveSheet.RowHeader.Rows[e.Row].Label;

            if(rdo_send.Checked == false & rdo_cancel.Checked == false & rdo_delete.Checked == false)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请先确认作业功能...!", "", "");
                return;
            }

            if (GeneralCommon.Gf_Sc_Authority(base.sAuthority, "U"))
            {
                if (rdo_send.Checked == true)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_STATUE].Text = "S";
                }
                if (rdo_cancel.Checked == true)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_STATUE].Text = "C";
                }
                if (rdo_delete.Checked == true)
                {
                    ss1.ActiveSheet.Cells[e.Row, SPD_STATUE].Text = "D";
                }
                   if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
                   {
                      
                       ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                       return;

                       if (ss1.ActiveSheet.Cells[e.Row, SPD_LEND].Text == "B")
                       {
                           for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                           {
                               SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, label6.BackColor);
                           }
                           
                       }
                       else if (ss1.ActiveSheet.Cells[e.Row, SPD_LEND].Text == "Y")
                       {
                           //for (int lCol = 0; lCol <= ss1.ActiveSheet.ColumnCount - 1; lCol++)
                           //{
                           //    SpreadCommon.Gp_Sp_ColColor(ss1, lCol, Color.Black, label7.BackColor);
                           //}
                           for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                           {
                               SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, label7.BackColor);
                           }
                       }
                       if (ss1.ActiveSheet.Cells[e.Row, SPD_PRC_STS].Text == "B")
                       {
                           for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
                           {
                               SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, e.Row, e.Row, Color.Black, label6.BackColor);
                           }
                       }
                   }
                   else
                   {
                       ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                   }
            }
        }

        private void ss1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss1.ActiveSheet.GetSelection(0);

            int iRowcount = cr.Row + cr.RowCount - 1;

            if (cr.RowCount <= 1) return;

            for (int iRow = cr.Row + 1; iRow <= iRowcount; iRow++)
            {
                if (rdo_send.Checked == true)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_STATUE].Text = "S";
                }
                if (rdo_cancel.Checked == true)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_STATUE].Text = "C";
                }
                if (rdo_delete.Checked == true)
                {
                    ss1.ActiveSheet.Cells[iRow, SPD_STATUE].Text = "D";
                }

                if (ss1.ActiveSheet.RowHeader.Rows[iRow].Label != "修改")
                {
                    ss1.ActiveSheet.RowHeader.Rows[iRow].Label = "修改";
                    //SpreadCommon.Gp_Sp_RowColor(ss1, iRow, Color.Black, Color.Cyan);
                }
                else
                {
                    ss1.ActiveSheet.RowHeader.Rows[iRow].Label = "";
                    //SpreadCommon.Gp_Sp_RowColor(ss1, iRow, Color.Black, Color.White);
                }
            }
        }

        //private void COB_HTM_COND_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (COB_HTM_COND.Text.Length == 4)
        //    {
        //        if (TXT_HTM_METH1.Text != COB_HTM_COND.Text.Substring(0,1))
        //        {
        //            GeneralCommon.Gp_MsgBoxDisplay("热处理方法与热处理条件不一样!", "", "");
        //            COB_HTM_COND.Items.Clear();
        //            return;
        //        }
        //    }

        //}

        public static bool Gf_ComboAdd(ComboBox Cbo, string sQuery)
        {

            bool RltValue = false;
            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return false;

            try
            {
                Cbo.Items.Clear();
                Cbo.Items.Add("");
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);//执行sql语句。

                if (Cbo.DropDownStyle == ComboBoxStyle.Simple) Cbo.Items.Add(" ");
                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    RltValue = true;

                    while (!AdoRs.EOF)
                    {
                        if (Cbo.DropDownStyle == ComboBoxStyle.Simple)
                        {
                            if (AdoRs.Fields[0].Value != null)
                            {
                                Cbo.Items.Add(AdoRs.Fields[1].Value.ToString() + AdoRs.Fields[1].Value.ToString());
                            }
                        }
                        else
                        {
                            if (AdoRs.Fields[0].Value != null)
                            {
                                Cbo.Items.Add(AdoRs.Fields[0].Value);
                            }
                        }
                        AdoRs.MoveNext();
                    }
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                GeneralCommon.AdoRs = null;
                RltValue = false;
                GeneralCommon.Gp_MsgBoxDisplay("Gf_ComboAdd Error : " + ex.Message, "", "");
            }

            GeneralCommon.AdoRs = null;
            if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
            return RltValue;
        }

        private void COB_HTM_COND_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COB_HTM_COND.Text == "") return;
            if (TXT_HTM_METH1.Text != COB_HTM_COND.Text.Substring(0, 1))
            {
                GeneralCommon.Gp_MsgBoxDisplay("热处理方法与热处理条件不一样!", "", "");
                COB_HTM_COND.Text = "";
                return;
            }
        }

    }
}

#endregion