
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
    public partial class WGE2010C : CommonClass.FORMBASE
    {
        public WGE2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();     
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Plate_No = 0;  //SS1钢板号
        public const int iSs1_Plate_Wgt = 9; //SS1钢板重量
        public const int iSs2_Plate_No = 1;  //SS2钢板号
        public const int iSs2_Upd_Emp = 15;  //SS2更新人员
        public int iSs2CurRow = 0;

        #region //界面初始化
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1,false);
            imcseq = 1;
            p_SetMc("产品代码", CBO_PROD_CD, "P", "2", "", "", "", imcseq);
            p_SetMc("当前库", TXT_CUR_INV, "P", "2", "", "", "", imcseq);
            p_SetMc("生产日期1", SDT_PROD_DATE_FROM, "PN", "10", "", "", "", imcseq);
            p_SetMc("生产日期2", SDT_PROD_DATE_TO, "PN", "10", "", "", "", imcseq);
            p_SetMc("标准", TXT_STDSPEC_CHG, "P", "30", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "1", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "1", "", "", "", imcseq);
            p_SetMc("物料号", TXT_PLATE_NO, "P", "14", "", "", "", imcseq);
            p_SetMc("探伤日期1", SDT_UST_FROM_DATE, "P", "10", "", "", "", imcseq);
            p_SetMc("探伤日期2", SDT_UST_TO_DATE, "P", "10", "", "", "", imcseq);
            p_SetMc("探伤班次", CBO_UST_SHIFT, "P", "1", "", "", "", imcseq);
            p_SetMc("厚度", SDB_THK, "P", "", "", "", "", imcseq);
            p_SetMc("起始垛位", TXT_FROM_LOC, "P", "", "", "", "", imcseq);
            p_SetMc("件数", SDB_CNT, "R", "", "", "", "", imcseq);
            p_SetMc("重量", SDB_WGT, "R", "", "", "", "", imcseq);

            p_McIni(Mc2,false);
            imcseq = 2;
            p_SetMc("当前库", TXT_CUR_INV, "P", "2", "", "", "", imcseq);
            p_SetMc("目标垛位", TXT_TO_LOC, "P", "", "", "", "", imcseq);
                    
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            //0-5
            p_SetSc("钢板号", "E", "14", "P", "", "", "", iscseq, iheadrow);

            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("客户代码", "E", "8", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("紧急订单", "E", "8", "L", "", "", "", iscseq, iheadrow,"M");
            //6-10
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "4", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            //11-15
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M"); 
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("探伤", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "10", "L", "", "", "", iscseq, iheadrow);
            //16
            p_SetSc("矫直", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("班别", "E", "4", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("探伤日期", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            iheadrow = 0;
            p_spanSpread("规格", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 14, 17, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 14, false, false);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("垛层", "E", "6", "I", "", "", "", iscseq, iheadrow);

            p_SetSc("钢板号", "E", "14", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("起始垛位", "E", "7", "ILA", "", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("进程代码", "E", "20", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow);
            //11-15            
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("生产日期", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("入库日期", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("更新人", "E", "7", "IL", "", "", "", iscseq, iheadrow);

            iheadrow = 0;
            p_spanSpread("规格", 6, 9, iscseq, iheadrow, 1);

            TXT_CUR_INV.Text = "HB";
            CBO_PROD_CD.Text = "PP";
            return;  
           
        }
        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
        //    base.sAuthority = "1111";           
        }
        #endregion

        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, true);

            if (TXT_TO_LOC.Text.Trim().Length == 7) 
            { base.p_Ref(2, 2, true, false); }
            SDB_CNT.NumValue = 0;//重置选中数量
            SDB_WGT.NumValue = 0;//重置选中重量
            return;
        }
        #endregion

        #region //保存：仅针对表单2
        public override void Form_Pro()
        {
            if (ss2_Sheet1.RowCount > 0)
            {
                if (base.p_pro(2, 2, true, false))
                {
                    SDB_CNT.NumValue = 0;//重置选中数量
                    SDB_WGT.NumValue = 0;//重置选中重量           
                    base.p_Ref(1, 1, true, false);
                    ss2.ShowRow(0, iSs2CurRow, VerticalPosition.Center);
                }
            }            
            return;
        }
        #endregion

        #region //删除：仅针对表单2
        public override void  Form_Del()
       {
            if (ss2_Sheet1.RowCount > 0)            
            { base.p_del(2, 2, true); }
            return;
        }
        #endregion

        #region //清空
        public override bool Form_Cls()
        {
            // 重写清空
            base.Form_Cls();
            SDB_CNT.NumValue = 0;//重置选中数量
            SDB_WGT.NumValue = 0;//重置选中重量
            return true;
        }
        #endregion

        #region //入库钢板指定
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            string sRowLabel;
            string sPlateNo;   //待移动钢板号
            double sPlateWgt;  //待移动钢板重量
            int iToRow = 0;    //目标位置行号 
            //ss1有符合条件内容才可以进行指定垛位（入库）处理
            if (ss1.ActiveSheet.RowCount <= 0 )
            {
                GeneralCommon.Gp_MsgBoxDisplay("请首先查询待入库钢板信息", "I", this.Text);
                return;
            }
            if (ss2.ActiveSheet.RowCount <= 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请首先查询目标垛位信息", "I", this.Text);
                return;
            }
            
            sRowLabel = ss1.ActiveSheet.RowHeader.Rows[e.Row].Label ;
            sPlateNo = ss1.ActiveSheet.Cells[e.Row, iSs1_Plate_No].Text;
            sPlateWgt = Convert.ToDouble(ss1.ActiveSheet.Cells[e.Row, iSs1_Plate_Wgt].Text);

            //入库钢板指定
            if (sRowLabel != "移动")
            {
                //从ss2的最上层向下遍历，在最上层钢板上面摆放钢板
                for (int iRow = 0; iRow <= ss2.ActiveSheet.RowCount - 1; iRow++)
                {
                    if (ss2.ActiveSheet.Cells[iRow, iSs2_Plate_No].Text != "")
                    {
                        //如果最上层已有钢板则不能移动
                        if (iRow == 0)
                        {
                            return;
                        }
                        sRowLabel = "移动";
                        //如果找到有钢板的垛层，则目标位置在此位置之上（行号-1）
                        iToRow = iRow - 1;
                        break;
                    }
                }
                //如果整个垛位遍历结束后，整个垛位没有钢板则从最底层放置钢板
                if (sRowLabel != "移动")
                {
                    sRowLabel = "移动";
                    iToRow = ss2.ActiveSheet.RowCount - 1;
                }
                //指定位置赋值
                iSs2CurRow = iToRow;  //设定当前垛位位置
                ss1.ActiveSheet.RowHeader.Rows[e.Row].Label = "移动";
                ss2.ActiveSheet.RowHeader.Rows[iToRow].Label = "增加";
                ss2.ActiveSheet.Cells[iToRow, iSs2_Plate_No].Text = sPlateNo;
                ss2.ActiveSheet.Cells[iToRow, iSs2_Upd_Emp].Text = GeneralCommon.sUserID;
                //计算选中数量，重量
                SDB_CNT.NumValue = SDB_CNT.NumValue + 1;
                SDB_WGT.NumValue = SDB_WGT.NumValue + sPlateWgt;
            }
            else  //取消入库钢板指定
            {
                //从ss2的最上层向下遍历，在钢板号与要取消钢板号相同则退出，记录当前位置
                for (int iRow = 0; iRow <= ss2.ActiveSheet.RowCount - 1; iRow++)
                {
                    if (ss2.ActiveSheet.Cells[iRow, iSs2_Plate_No].Text == sPlateNo)
                    {
                        iToRow = iRow ;
                        break;
                    }
                }
                //取消位置初始化
                ss1.ActiveSheet.RowHeader.Rows[e.Row].Label = "";
                ss2.ActiveSheet.RowHeader.Rows[iToRow].Label = "";
                ss2.ActiveSheet.Cells[iToRow, iSs2_Plate_No].Text = "";
                ss2.ActiveSheet.Cells[iToRow, iSs2_Upd_Emp].Text = "";
                //重新计算选中数量，重量
                SDB_CNT.NumValue = SDB_CNT.NumValue - 1;
                SDB_WGT.NumValue = SDB_WGT.NumValue - sPlateWgt;
            }
        }
        #endregion

        #region //整理垛位
        /// <summary>
        /// 点击目标垛位标签整理垛位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LAB_TO_LOC_DoubleClick(object sender, EventArgs e)
        {
            string[] Para = new string[5];

            if (ss2_Sheet1.RowCount == 0)
            { return; }

            if (GeneralCommon.Gf_MessConfirm("您确认对 " + TXT_CUR_INV.Text + " 库的 " + TXT_TO_LOC.Text + " 垛位进行整理么", "Q", this.Text))
            {
                //垛位号长度符合才可以进行整理垛位操作
                if (TXT_TO_LOC.Text.Length == 7)
                {
                    //输入参数初始化
                    Para[0] = TXT_CUR_INV.Text;
                    Para[1] = TXT_TO_LOC.Text;
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
            }
            return;
        }
        #endregion

    }
}
