
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
///-- 系统名            中板轧钢作业                                              
///-- 子系统名          钢板库管理                                                  
///-- 程序名            在制品指定垛位                                  
///-- 程序ID            CGE2021C                                                  
///-- 版本              1.1.00                                                    
///-- 文档号            规格书名称                                                
///-- 设计              中板未入库产品垛位管理                                                    
///-- 代码              韩超                                                    
///-- 代码日期          2017.05.25                                                
///-- 处理描述          

///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期          修改人         修改内容                             
///1.1.00    2017.05.26       韩超                                              

///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGE2021C : CommonClass.FORMBASE
    {
        public CGE2021C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        public const int iss1_plate_wgt = 9; //SS1钢板重量
        public const int iss1_is_urgnt  = 5; //SS1紧急订单
        public const int iss1_plate_no  = 0; //SS1钢板号
        public const int iss2_plate_no  = 1; //SS2钢板号
        public const int iss2_upd_emp   = 12; //SS2更新人
        public const int iss2_bed_seq = 0; //SS2垛层
        public const int iss2_yarrd = 14; //SS2垛位
        int iss2showrow = 0;
        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            //查询在制品 
            p_McIni(Mc1, false);
            imcseq = 1;
            //0-5
            p_SetMc("当前库", text_cur_inv_code, "PN", "", "", "", "", imcseq);//0
            p_SetMc("生产时间", SDT_PROD_DATE, "PN", "", "", "", "", imcseq);//1
            p_SetMc("生产时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);//2
            p_SetMc(txt_stdspec_chg, "P", "", "", "", imcseq, "");//3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");//4
            p_SetMc(CBO_SURFGRD, "P", "", "", "", imcseq, "");//5
            p_SetMc(txt_f_addr, "P", "", "", "", imcseq, "");//6
            p_SetMc(txt_t_addr, "P", "", "", "", imcseq, "");//7
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");//8
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, "");//9
            p_SetMc(CBO_PROD_CD, "P", "", "", "", imcseq, "");//10
            //p_SetMc(TXT_CNT, "P", "", "", "", imcseq, "");
            //p_SetMc(TXT_WGT, "P", "", "", "", imcseq, "");

            //当前垛位
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("进程状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("重量", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("垛位", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("外观等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//10          
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("生产时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//15
 
            //合并列头
            //iheadrow = 0;
            //p_spanSpread("规格", 6, 9, iscseq, iheadrow, 1);
            //p_spanSpread("作业指示/实绩", 13, 17, iscseq, iheadrow, 1);
            //钢板号冻结
            //ss1.Sheets[0].FrozenColumnCount = 1;

            //目标垛位情况
            p_ScIni(ss2, Sc2, 0, true, false);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("垛层", "E", "60", "NI", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("钢板号", "E", "14", "I", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("起始垛位", "E", "7", "I", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("重量", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("生产日期", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("作业人员", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");//10
            //合并列头
            //iheadrow = 0;
            //p_spanSpread("规格", 5, 8, iscseq, iheadrow, 1);
            //钢板号冻结
            //ss2.Sheets[0].FrozenColumnCount = 2;

        }
        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
       //     base.sAuthority = "1111";
            txt_cur_inv.Text = "HB";
            txt_prod_cd.Text = "PP";
            return;            
        }
        #endregion
        #region 查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, true);

            if (txt_t_addr.Text.Trim().Length == 7)
            { base.p_Ref(2, 2, true,false); }
            SpreadCommon.Gp_Sp_ColColor(ss2, iss2_plate_no, Color.Black, Color.White);
            SpreadCommon.Gp_Sp_ColColor(ss2, iss2_bed_seq, Color.Black, Color.White);
            SpreadCommon.Gp_Sp_ColColor(ss2, iss2_yarrd, Color.Black, Color.White);
            SpreadCommon.Gp_Sp_ColColor(ss2, iss2_upd_emp, Color.Black, Color.White);
            TXT_CNT.NumValue = 0;
            TXT_WGT.NumValue = 0;   
            return;
        }
        #endregion
        #region 指定垛位
        /// <summary>
/// 单击表单1选中钢板指定垛位
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
    
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            int iRowidx;
            bool bFull = true;//是否到达顶层

            if (ss1_Sheet1.RowCount <= 0 || ss2_Sheet1.RowCount <= 0)//表单1有物料才可以进行指定垛位处理
            {
                return;
            }
            if (ss1.ActiveSheet.RowHeader.Rows[e.Row].Label != "移动")//尚未选中的进行指定垛位处理
            {
                
                if (ss2.ActiveSheet.SelectionCount>0)//指定开始堆放垛层
                {
                    for (int iRow = ss2.Sheets[0].ActiveRowIndex; iRow >= 0; iRow--)//垛层号小的在最后，从底层空垛层开始堆放
                    {
                        if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim() == "")//将钢板移动到空的垛层
                        {
                            iss2showrow = iRow;
                            ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text = ss1.ActiveSheet.Cells[e.Row, iss1_plate_no].Text;
                            ss2.ActiveSheet.Cells[iRow, iss2_upd_emp].Text = GeneralCommon.sUserID;//记录指定垛位人员
                            ss2.ActiveSheet.RowHeader.Rows[iRow].Label = "修改";
                            SpreadCommon.Gp_Sp_RowColor(ss2, iRow, Color.Black, Color.LightPink);//选定行着色
                            ss2.ShowRow(0, iRow, VerticalPosition.Center);
                            bFull = false;
                            break;
                        }                                
                    }   
                }
                else
                {
                  try{    
                          for (int iRow = 0; iRow <= ss2.ActiveSheet.RowCount - 1; iRow++)//未指定垛层从顶层向下开始查找可堆放层
                        {                     
                              if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text.Trim().Length > 1 && ss2.ActiveSheet.Cells[iRow-1, iss2_plate_no].Text.Trim().Length == 0)//查找到有钢板号且上一层垛位为空则可堆放
                             {
                                iss2showrow = iRow - 1;
                                ss2.ActiveSheet.Cells[iRow - 1, iss2_plate_no].Text = ss1.ActiveSheet.Cells[e.Row, iss1_plate_no].Text;
                                ss2.ActiveSheet.Cells[iRow - 1, iss2_upd_emp].Text = GeneralCommon.sUserID;//记录指定垛位人员
                                ss2.ActiveSheet.RowHeader.Rows[iRow-1].Label = "修改";
                                SpreadCommon.Gp_Sp_RowColor(ss2, iRow - 1, Color.Black, Color.LightPink);//选定行着色
                                ss2.ShowRow(0, iRow - 1, VerticalPosition.Center);
                                bFull = false;//垛位未放满允许堆放
                                break;
                             }  
                         }                         
                    }
                    catch (Exception)//顶层有钢板，垛位满
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("可堆放块数不足，请检查垛位信息或开始堆放垛层", "I", this.Text);
                        return;
                    }
                }

                if (bFull)//垛位堆放已到顶层且不允许堆放
                {
                    GeneralCommon.Gp_MsgBoxDisplay("可堆放块数不足，请检查垛位信息或开始堆放垛层", "I", this.Text);
                    return;
                }
         
                ss1.ActiveSheet.RowHeader.Rows[e.Row].Label = "移动";//选定行行头标移动
                SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.LightPink);//选定行着色
                TXT_CNT.NumValue = TXT_CNT.NumValue + 1; //选择钢板件数
                TXT_WGT.NumValue = TXT_WGT.NumValue + Convert.ToDouble(ss1.ActiveSheet.Cells[e.Row, iss1_plate_wgt].Text);//选择钢板累计重量


            }
            else//取消已经指定垛位的操作
            {                
                for (int iRow = ss2.ActiveSheet.RowCount - 1; iRow >= 0; iRow--)
                {
                    if (ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text == ss1.ActiveSheet.Cells[e.Row, iss1_plate_no].Text && ss2.ActiveSheet.RowHeader.Rows[iRow].Label == "修改")//钢板号相同且行头是增加才可以取消
                    {
                        ss2.ActiveSheet.Cells[iRow, iss2_plate_no].Text = "";//清空钢板号
                        ss2.ActiveSheet.Cells[iRow, iss2_upd_emp].Text = "";//清空指定垛位人员
                        iRowidx = iRow + 1;
                        ss2.ActiveSheet.RowHeader.Rows[iRow].Label = iRowidx.ToString();//行头恢复
                        SpreadCommon.Gp_Sp_RowColor(ss2, iRow, Color.Black, Color.White);//背景色恢复
                        break;
                    }

                }                
                iRowidx = e.Row + 1;
                ss1.ActiveSheet.RowHeader.Rows[e.Row].Label = iRowidx.ToString();//行头恢复
                SpreadCommon.Gp_Sp_RowColor(ss1, e.Row, Color.Black, Color.White);//背景色恢复
                TXT_CNT.NumValue = TXT_CNT.NumValue - 1; //选择钢板件数
                TXT_WGT.NumValue = TXT_WGT.NumValue - Convert.ToDouble(ss1.ActiveSheet.Cells[e.Row, iss1_plate_wgt].Text);//选择钢板累计重量
            }           
        }

        //仅表单2可以保存删除修改
        public override void Form_Pro()
        {
            if (ss2_Sheet1.RowCount > 0)
            { 
                base.p_pro(2,2,true,false);
                TXT_CNT.NumValue = 0;//重置选中数量
                TXT_WGT.NumValue = 0;//重置选中重量           
                base.p_Ref(1, 1, true, false);
                ss2.ShowRow(0,iss2showrow, VerticalPosition.Center);
                iss2showrow = 0;
            }            
            return;
        }

        //仅表单2可以做删除
        public override void  Form_Del()
       {
            if (ss2_Sheet1.RowCount > 0)
            { base.p_del(1, 2, true); }
            return;
        }
        #endregion
          
        public override bool Form_Cls()
        {
            // 重写清空
            base.Form_Cls();
            txt_cur_inv.Text = "HB";
            txt_prod_cd.Text = "PP";
            TXT_CNT.NumValue = 0;//重置选中数量
            TXT_WGT.NumValue = 0;//重置选中重量    
            return true;
        }
        #region 整理垛位
        /// <summary>
        /// 点击目标垛位标签整理垛位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label11_DoubleClick(object sender, EventArgs e)
        {
            string[] Para = new string[5];

            //垛位号长度符合才可以进行整理垛位操作
            if (txt_t_addr.Text.Length == 7)
            {
                //判断库别如果为空赋予默认库
                if (txt_cur_inv.Text.Trim() != "")
                {
                    Para[0] = txt_cur_inv.Text;
                }
                else { Para[0] = "HB"; }
                Para[1] = txt_t_addr.Text;
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
    }
       
}
