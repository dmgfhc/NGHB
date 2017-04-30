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

namespace CG
{
    public partial class WGC2030C : CommonClass.FORMBASE
    {
        public WGC2030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Plate_No = 0;  //SS1钢板号
        public const int iSs2_Stdspec_Chg = 12;  //SS2改判标准号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", TXT_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("标准号", F4ETCN_STDSPEC_R, "P", "", "", "", "", imcseq);
            p_SetMc("改判标准号", F4ETCN_STDSPEC, "", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("订单号", "E", "12", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("总块数", "N", "3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("剪切块数", "N", "3", "L", "", "", "", iscseq, iheadrow);
            //11-13
            p_SetSc("生产日期", "DT", "19", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            iheadrow = 0;
            p_spanSpread("母板规格", 1, 4, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 6, 8, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 18, true, false);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("钢板号", "E", "14", "PI", "", "", "", iscseq, iheadrow);
            p_SetSc("状态", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("宽度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "I", "", "", "", iscseq, iheadrow);
            
            //6-10
            p_SetSc("长度", "N", "8", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("尾板", "C", "1", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("定尺", "C", "1", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("切边", "C", "1", "I", "", "", "", iscseq, iheadrow);
            
            //11-15
            p_SetSc("标准号", "E", "30", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("改判标准号", "E", "30", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("合格", "C", "1", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("冲印", "C", "1", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("喷印", "C", "1", "I", "", "", "", iscseq, iheadrow);
            
            //16-20
            p_SetSc("侧喷", "C", "1", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "DT", "19", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            
            //21-24
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("UST", "E", "50", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("热处理", "E", "50", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("用户代码", "E", "50", "L", "", "", "", iscseq, iheadrow,"M");
            //p_SetSc("状态", "E", "50", "L", "", "", "", iscseq, iheadrow,"M");

            iheadrow = 0;
            p_spanSpread("订单", 5, 6, iscseq, iheadrow, 1);
            p_spanSpread("实绩", 9, 12, iscseq, iheadrow, 1);
            p_spanSpread("标印指示", 19, 21, iscseq, iheadrow, 1);
        }

        private void WGC2030C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_AGC2030C_LQ";
            Form_Define();
        }

        #endregion


        #region //新增
        public override void Spread_Ins()
        {
            int c_Number; //列序号
             int r_Count;//行号
             i_ScCurrSeq = 2;
            Collection proc_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)proc_sc_i["Spread"];
            switch (FormType)
            {
                case "Master":
                    return;
                default:
                    
                    //if (ss1.Sheets[0].RowCount > 0)        //ss1页面，并且在页面有数据情况下
                    //{
                        ss = ss2;                       
                        if (ss.Sheets[0].RowCount != 0)
                        {
                            ss.Sheets[0].Rows.Add(ss.ActiveSheet.RowCount, 1);//ss.ActiveSheet.ActiveRowIndex
                            ss.Sheets[0].ActiveRowIndex++;
                            ss.Sheets[0].ActiveColumnIndex = 0;
                            ss.Sheets[0].ActiveRowIndex = ss.Sheets[0].RowCount - 1;
                        }
                        else
                        {
                            ss.Sheets[0].Rows.Add(0, 1);
                            ss.Sheets[0].ActiveRowIndex = 0;
                        }
                        ss.Sheets[0].RowHeader.Cells.Get(ss.ActiveSheet.ActiveRowIndex, 0).Text = "增加";
                        

                        if (ss2.Sheets[0].RowCount > 1)
                        {
                            for (int i = 0; i < ss.Sheets[0].ColumnCount - 1; i++)
                            {

                                c_Number = i + 1;
                                ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, i).Locked = false;
                                ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, c_Number).Value = ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex - 1, c_Number).Value;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < ss.Sheets[0].ColumnCount - 1; i++)
                            {
                               // GeneralCommon.Gp_MsgBoxDisplay(ss2.Sheets[0].RowCount.ToString(), "", "");
                                ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, i).Locked = false;
                               
                            }

                        }
                        if ((ss2.Sheets[0].RowCount - 2) >= 0)
                        {
                            string s2 = ss2.ActiveSheet.Cells[(ss2.Sheets[0].RowCount - 2), 0].Text;

                            if (ss.Sheets[0].RowCount > 0 && s2 != "")
                            {

                                int p_Number = Convert.ToInt32(s2.Substring(12, 2));
                                if (p_Number < 9)
                                {
                                    ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, 0).Value = s2.Substring(0, 12) + "0" + (p_Number + 1).ToString();
                                }

                                else
                                {
                                    ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, 0).Value = s2.Substring(0, 12) + (p_Number + 1).ToString();
                                }
                            }
                        }
                        if (ss.Sheets[0].RowCount == 1)
                        {
                            // GeneralCommon.Gp_MsgBoxDisplay(ss2.Sheets[0].RowCount.ToString(), "", "");
                            //string s1 = ss1.Sheets[0].Cells.Get(ss1.Sheets[0].ActiveRowIndex, 0).Text;
                            string s1 = TXT_PLATE_NO.Text;
                            ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, 0).Value = s1 + "01";
                        }

                        Collection Proc_Sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
                        Collection lColumn = (Collection)Proc_Sc_i["lColumn"];
                        for (int l = 1; l <= lColumn.Count; l++)
                        {
                            ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, (int)lColumn[l]).Locked = true;
                        }

                        int colID = System.Convert.ToInt32(Proc_Sc_i["authority"]);
                        if (colID > 0)
                        {
                            SpreadCommon.Gp_Sp_InAuthority(Proc_Sc_i, (int)Proc_Sc_i["authority"], "");
                        }
                    //}
                
                    break;
                    }
            }
        #endregion
        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, true);
            if (ss1.Sheets[0].RowCount > 0)
            {
                TXT_PLATE_NO.Text = ss1_Sheet1.Cells[0, iSs1_Plate_No].Text;
                base.p_Ref(2, 2, true, false);
            }
            return;
        }
        #endregion

        #region //保存
        public override void Form_Pro()
        {
            base.p_pro(2, 2, true, false);
            return;
        }
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.ColumnHeader) return;
            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }
            //当单击表单时，按照单击行所对应钢板号查询钢板详细信息
            TXT_PLATE_NO.Text = ss1_Sheet1.Cells[e.Row, iSs1_Plate_No].Text;
            base.p_Ref(2, 2, true, false);
            return;
        }

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {

            if (e.ColumnHeader) return;
            string sRowLabel;

            //if (ss2_Sheet1.RowCount == 0)
            //{
            //    return;
            //}

            //只有选择行表头才可进行操作
            //if (e.Column != 0)
            //{
            //    return;
            //}

            sRowLabel = ss2_Sheet1.RowHeader.Rows[e.Row].Label;
            //取消前次操作
            if (e.Column == 0)
            {
                if (sRowLabel == "修改" && e.Column != iSs2_Stdspec_Chg)
                {
                    ss2_Sheet1.RowHeader.Rows[e.Row].Label = "";
                }
                else if (sRowLabel != "修改" && e.Column != iSs2_Stdspec_Chg)
                {
                    ss2_Sheet1.RowHeader.Rows[e.Row].Label = "修改";
                }
            }
            //当单击表单时，如果改判标准号有值，则表单选中行改判标准项自动赋值，再次单击则清空
            if (F4ETCN_STDSPEC.Text != "" && e.Column == iSs2_Stdspec_Chg)
            {
                if (ss2_Sheet1.Cells[e.Row, iSs2_Stdspec_Chg].Text == "")
                {
                    ss2_Sheet1.Cells[e.Row, iSs2_Stdspec_Chg].Text = F4ETCN_STDSPEC.Text;
                }
                else
                {
                    ss2_Sheet1.Cells[e.Row, iSs2_Stdspec_Chg].Text = "";
                }                 
            }
            else if (e.Column == 0) //点击首列，表单改判标准项自动清空
            {
                ss2_Sheet1.Cells[e.Row, iSs2_Stdspec_Chg].Text = "";
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            TXT_PLT.Text = "C2";
            return true;
        }

    }
}
