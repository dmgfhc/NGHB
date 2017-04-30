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
    public partial class WGE2020C : CommonClass.FORMBASE
    {
        public WGE2020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        public const int iss1_plate_no = 1; //SS1钢板号
        public const int iss2_plate_no = 1; //SS2钢板号
        public const int iss2_bed_seq = 0; //SS2垛层
        public const int iss2_yarrd = 3; //SS2垛位
        public const int iss2_upd_emp = 17; //SS2更新人
        bool bFull = true;

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("当前库", txt_cur_inv, "PN", "2", "", "", "", imcseq);
            p_SetMc("起始垛位", txt_loc_fr, "P", "7", "", "", "", imcseq);
            p_SetMc("物料号", txt_plate_no, "P", "14", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("当前库", txt_cur_inv, "PN", "2", "", "", "", imcseq);
            p_SetMc("目标垛位", txt_loc_to, "P", "7", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 18, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("垛层", "N", "3", "PL", "", "", "", iscseq, iheadrow, "L");

            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("起始垛位", "E", "7", "PL", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("进程代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); 
            //6-10
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("订单序列", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("切割", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("矫直", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("热处理", "E", "15", "L", "", "", "", iscseq, iheadrow, "L"); 

            //16-20 
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板修改时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("作业人员", "E", "7", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("库", "E", "2", "PLA", "", "", "", iscseq, iheadrow, "L");  

            iheadrow = 0;
            p_spanSpread("规格", 8, 11, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 12, 15, iscseq, iheadrow, 1);
            ss1.Sheets[0].FrozenColumnCount = 2;

            p_ScIni(ss2, Sc2, 16, true, false);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("垛层", "N", "3", "PIL", "", "", "", iscseq, iheadrow, "L");

            p_SetSc("钢板号", "E", "14", "IL", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("目标垛位", "E", "7", "PIL", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("进程代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");
            //6-10
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("订单序列", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("切割", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("矫直", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("热处理", "E", "15", "L", "", "", "", iscseq, iheadrow, "L");
            //16-20   
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow);   
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow);
            p_SetSc("库", "E", "2", "PILA", "", "", "", iscseq, iheadrow, "L");  
            iheadrow = 0;
            p_spanSpread("规格", 8, 11, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 12, 15, iscseq, iheadrow, 1);
            ss2.Sheets[0].FrozenColumnCount = 2;
   
        }
        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
        //    base.sAuthority = "1111";
            txt_cur_inv.Text = "HB";
        }
        #endregion
        #region 整理垛位
        private void label2_DoubleClick(object sender, EventArgs e)
        {
            string[] Para = new string[5];

            //垛位号长度符合才可以进行整理垛位操作
            if (txt_loc_fr.Text.Length == 7)
            {
                //判断库别如果为空赋予默认库
                if (txt_cur_inv.Text.Trim() != "")
                {
                    Para[0] = txt_cur_inv.Text;
                }
                else { Para[0] = "00"; }
                Para[1] = txt_loc_fr.Text;
                Para[2] = GeneralCommon.sUserID;
                Para[3] = this.Name;
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "GP_RESET_YARD", Para))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("垛位整理完毕", "I", this.Text);
                    base.p_Ref(1, 1, true, true);
                }
            }
            else
            { GeneralCommon.Gp_MsgBoxDisplay("请输入正确垛位号", "I", this.Text); }
            return;
        }
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            string[] Para = new string[5];

            //垛位号长度符合才可以进行整理垛位操作
            if (txt_loc_to.Text.Length == 7)
            {
                //判断库别如果为空赋予默认库
                if (txt_cur_inv.Text.Trim() != "")
                {
                    Para[0] = txt_cur_inv.Text;
                }
                else { Para[0] = "00"; }
                Para[1] = txt_loc_to.Text;
                Para[2] = GeneralCommon.sUserID;
                Para[3] = this.Name;
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "GP_RESET_YARD", Para))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("垛位整理完毕", "I", this.Text);
                    base.p_Ref(2, 2, true, true);
                }
            }
            else
            { GeneralCommon.Gp_MsgBoxDisplay("请输入正确垛位号", "I", this.Text); }
            return;
        }

        #endregion
        #region 查询
        public override void Form_Ref()
        {
            
            if (txt_loc_fr.Text.Trim().Length != 7 && txt_plate_no.Text.Trim().Length != 14)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入起始垛位", "I", this.Text);
                return;
            }
            btn_move.Enabled = true;
            base.p_Ref(1, 1, true, false);            
            //如果是按钢板号查询，将该钢板号所在垛位情况同时显示，并且自动滚动到该钢板所在垛层
            if (txt_plate_no.Text.Trim().Length == 14 && ss1.ActiveSheet.RowCount > 0)
            {
                for (int iRow = ss1.Sheets[0].RowCount - 1; iRow >= 0; iRow--)
                {
                    if (ss1.ActiveSheet.Cells[iRow, iss1_plate_no].Text.Trim() == txt_plate_no.Text.Trim())
                    {
                        ss1.ShowRow(0, iRow, VerticalPosition.Center);      //跳转到钢板所在行
                        ss1.ActiveSheet.Rows.Get(iRow).BackColor = Color.LightSkyBlue;  //亮色显示所要查找钢板
                        break;
                    }
                }
            }
  
            if (txt_loc_to.Text.Trim().Length == 7)
            { 
                base.p_Ref(2, 2, true, false);
                SpreadCommon.Gp_Sp_ColColor(ss2, iss2_plate_no, Color.Black, Color.White);
                SpreadCommon.Gp_Sp_ColColor(ss2, iss2_bed_seq, Color.Black, Color.White);
                SpreadCommon.Gp_Sp_ColColor(ss2, iss2_yarrd, Color.Black, Color.White);
                SpreadCommon.Gp_Sp_ColColor(ss2, iss2_upd_emp, Color.Black, Color.White);
            }
            sxt_select_cnt.NumValue = 0;
            return;
        }
        #endregion
        #region 移动
        protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        {

        }
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            int iPlatecnt = 0;

            if (ss1_Sheet1.RowCount > 0 && ss2_Sheet1.RowCount > 0 && e.RowHeader.ToString() != "删除")
            {
                btn_cancel_Click(btn_cancel, e);
                if (ss1_Sheet1.Cells[e.Row, iss1_plate_no].Text.Trim().Length < 10)
                {
                    sxt_select_cnt.NumValue = iPlatecnt;
                    return;
                }
                else
                {
                    for (int iRow = e.Row; iRow >= 0; iRow--)
                    {

                        if (ss1.ActiveSheet.Cells[iRow, iss1_plate_no].Text.Trim() == "" || ss1.ActiveSheet.RowHeader.Rows[iRow].Label == "删除")//将钢板移动到空的垛层
                        {
                            sxt_select_cnt.NumValue = iPlatecnt;
                            break;
                        }
                        iPlatecnt++;
                    }

                }
            }

        }
        private void btn_move_Click(object sender, EventArgs e)
        {
            int iRowidx;
            int iss2nullcnt = 0;
            if ((int)sxt_select_cnt.NumValue == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请选择起始移动垛层", "I", this.Text);
                return;
            }
            if (txt_loc_fr.Text == txt_loc_to.Text)
            {
                GeneralCommon.Gp_MsgBoxDisplay("同垛位不可移垛", "I", this.Text);
                return;
            }
            if (ss1_Sheet1.SelectionCount <= 0 || ss2_Sheet1.RowCount <= 0)
            {
                if (ss1_Sheet1.SelectionCount == 0)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请指定移动钢板", "I", this.Text);
                    return;
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("须有目标垛位信息", "I", this.Text);
                    return;
                }
            }

            if (ss2.ActiveSheet.SelectionCount > 0)//指定开始堆放垛层
            {
                for (int iRow = ss2.Sheets[0].ActiveRowIndex; iRow >= 0; iRow--)//垛层号小的在最后，从指定垛层开始堆放
                {
                    bFull = true;
                    if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim() == "")//将钢板移动到空的垛层
                    {
                        iss2nullcnt++;//累计可堆放数量
                        if (iss2nullcnt == (int)sxt_select_cnt.NumValue)//满足条件则进行移垛操作
                        {
                            bFull = false;
                            move_mark(iRow + (int)sxt_select_cnt.NumValue - 1);
                            // spreadshow用法（第几个表单，指定行，显示位置[上、中、下]）
                            ss2.ShowRow(0, iRow, VerticalPosition.Center);//显示移垛后将所在垛层                           
                            break;
                        }
                    }
                    else
                    {
                        iss2nullcnt = 0;//不满足连续堆放要求，重置累计可堆放数量
                    }
                }
            }
            else
            {
                for (int iRow = 0; iRow <= ss2.ActiveSheet.RowCount - 1; iRow++)//从顶层向下检查可堆放直到有钢板
                {
                    bFull = true;
                    if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim().Length > 1 && iRow < (int)sxt_select_cnt.NumValue)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("可堆放块数不足，请检查垛位信息或开始堆放垛层", "I", this.Text);
                        return;

                    }
                    else
                    {
                        if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim().Length > 1 && ss2.ActiveSheet.Cells[iRow - 1, iss2_plate_no].Text.Trim().Length == 0 && iRow >= (int)sxt_select_cnt.NumValue - 1)
                        {
                            bFull = false;
                            move_mark(iRow - 1);
                            ss2.ShowRow(0, iRow - 1, VerticalPosition.Center);
                            break;
                        }
                        else if (iRow == ss2.ActiveSheet.RowCount - 1 && ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim().Length == 0)
                        {
                            bFull = false;
                            move_mark(iRow);
                            ss2.ShowRow(0, iRow - 1, VerticalPosition.Center);
                            break;
                        }
                    }

                }
            }
            if (bFull)//垛位堆放已到顶层且不允许堆放
            {
                GeneralCommon.Gp_MsgBoxDisplay("可堆放块数不足，请检查垛位信息或开始堆放垛层", "I", this.Text);
                return;
            }
            else
            { 
                btn_move.Enabled = false;
                return;
            }


        }
        private void move_mark(int startrow)
        {
            for (int icnt = 0; icnt < (int)sxt_select_cnt.NumValue; icnt++)
            {
                ss1.ActiveSheet.RowHeader.Rows[ss1.ActiveSheet.ActiveRowIndex - icnt].Label = "删除";
                ss2.ActiveSheet.RowHeader.Rows[startrow - icnt].Label = "修改";
                ss2.ActiveSheet.Cells[startrow - icnt, iss2_plate_no].Text = ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex - icnt, iss1_plate_no].Text;
                SpreadCommon.Gp_Sp_RowColor(ss1, ss1.ActiveSheet.ActiveRowIndex - icnt, Color.Black, Color.LightPink);//选定行着色
                SpreadCommon.Gp_Sp_RowColor(ss2, startrow - icnt, Color.Black, Color.LightPink);//选定行着色
            }
        }
        #endregion
        #region 取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            int iRowidx;
            btn_move.Enabled = true;
            if (ss1.ActiveSheet.SelectionCount > 0)
            {
                for (int iRow = ss1.ActiveSheet.RowCount - 1; iRow >= 0; iRow--)
                {
                    if (ss1.ActiveSheet.RowHeader.Rows[iRow].Label == "删除")//钢板号相同且行头是增加才可以取消
                    {
                        iRowidx = iRow + 1;
                        ss1.ActiveSheet.RowHeader.Rows[iRow].Label = iRowidx.ToString();//行头恢复
                        SpreadCommon.Gp_Sp_RowColor(ss1, iRow, Color.Black, Color.White);//背景色恢复                       
                    }
                }


            }
            if (ss2.ActiveSheet.RowCount > 0)
            {
                for (int iRow = ss2.ActiveSheet.RowCount - 1; iRow >= 0; iRow--)
                {
                    if (ss2.ActiveSheet.RowHeader.Rows[iRow].Label == "修改")//钢板号相同且行头是增加才可以取消
                    {
                        ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text = "";//清空钢板号
                        ss2.ActiveSheet.Cells[iRow, iss2_upd_emp].Text = "";//清空指定垛位人员
                        iRowidx = iRow + 1;
                        ss2.ActiveSheet.RowHeader.Rows[iRow].Label = iRowidx.ToString();//行头恢复
                        SpreadCommon.Gp_Sp_RowColor(ss2, iRow, Color.Black, Color.White);//背景色恢复                       
                    }
                }
                sxt_select_cnt.NumValue = 0;
            }
        }

        #endregion 
        #region 保存
        public override void Form_Pro()
        {
            if (ss2_Sheet1.RowCount > 0)
            {
                btn_move.Enabled = true;
                if (base.p_pro(2, 2, true, false))
                {
                    sxt_select_cnt.NumValue = 0;
                    if (ss1.ActiveSheet.SelectionCount > 0)
                    {
                        for (int iRow = ss1.ActiveSheet.RowCount - 1; iRow >= 0; iRow--)
                        {
                            if (ss1.ActiveSheet.RowHeader.Rows[iRow].Label == "删除")//钢板号相同且行头是增加才可以取消
                            {
                                ss1.ActiveSheet.RowHeader.Rows[iRow].Label = (iRow + 1).ToString();//行头恢复                    
                            }
                        }
                    }
                    base.p_Ref(1, 1, true, false);
                }
                else 
                {
                    base.p_Ref(1, 1, true, false);
                    base.p_Ref(2, 2, true, false);
                }
            }

            return;
        }
        #endregion
        #region reset
        public override bool Form_Cls()
        {
            // 重写清空
            base.Form_Cls();
            txt_cur_inv.Text = "HB";
            sxt_select_cnt.NumValue = 0;
            btn_move.Enabled = true;
            return true;
        }
        #endregion

    }

}
