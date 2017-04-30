using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;

namespace CG
{
    public partial class WGT1050C : CommonClass.FORMBASE
    {
        public WGT1050C()
        {
            InitializeComponent();
        }

        public const int iSs1_Emp_Cd = 25;  //用户
        public const int iSs1_Mill_NO = 1;  //轧批号
        public const int iSs1_MP_NO = 0;//母板号
        public const int iSs1_MP_OVER = 6;
        public const int iSs1_Thick_NO = 15;//厚度 
        public const int iSs1_Last_Mill_NO = 2;//最后一块轧批号

        public const int iPlan_wgt = 21;
        public const int iPlan_rat = 23;
        public const int islab_wgt = 27;
        
        string MILL_NO;
        string OVEN_NO;
        string THICK;
        int rowCount;
        int mCount;

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;

            p_SetMc("板坯号", txt_Slab_No, "P", "", "", "", "", 1);//0
            p_SetMc("切割时间开始", sdt_wrk_date_fr, "P", "", "", "", "", 1);//1
            p_SetMc("切割时间结束", sdt_wrk_date_to, "P", "", "", "", "", 1);//2
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", 1);//3
            
            
            p_SetMc("标准号", txt_Std_No, "P", "", "", "", "", 1);//4  
            
            p_SetMc("切割指示", ACT_CUT_PLT, "P", "", "", "", "", 1);//5
            p_SetMc("母板厚开始", text_Mp_Thick, "P", "", "", "", "", 1);//6  
            p_SetMc("母板厚结束", text_Mp_Thick_To, "P", "", "", "", "", 1);//7
            p_SetMc("母板宽开始", txt_Mp_Wide, "P", "", "", "", "", 1);//8
            p_SetMc("母板宽结束", txt_Mp_Wide_To, "P", "", "", "", "", 1);//9
            p_SetMc("母板长开始", txt_Mp_Long, "P", "", "", "", "", 1);//10
            p_SetMc("母板长结束", txt_Mp_Long_To, "P", "", "", "", "", 1);//11
            p_SetMc("母板状态", cbo_Mp_Res, "P", "", "", "", "", 1);//12
            p_SetMc("母板状态", txt_Mill_NO, "", "", "", "", "", 1);

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("母板号", "E", "", "PIL", "", "", "", 1, 1, "M");//0
            p_SetSc("轧批号", "E", "", "I", "", "", "", 1, 1, "R");//1
            p_SetSc("是否最后一块轧批号", "E", "", "", "", "", "", 1, 1, "M");//2
            p_SetSc("订单号", "E", " ", "L", "", "", "", 1, 1, "M");//3
            p_SetSc("订单序列", "E", " ", "L", "", "", "", 1, 1, "M");//4
            p_SetSc("母板状态", "E", "", "L", "", "", "", 1, 1, "M");//5
            p_SetSc("母板结束", "C", "", "I", "", "", "", 1, 1, "M");//6 hanchao 20140127 以下序列号全部加1
            p_SetSc("标准号", "E", " ", "L", "", "", "", 1, 1, "R");//7
            p_SetSc("轧制时间", "DT", " ", "L", "", "", "", 1, 1, "M");//8
            p_SetSc("抛送ERP时间", "DT", "", "L", "", "", "", 1, 1, "M");//9
            p_SetSc("探伤", "E", " ", "L", "", "", "", 1, 1, "M");//10
            p_SetSc("切割", "E", " ", "L", "", "", "", 1, 1, "M");//11
            p_SetSc("抛丸", "E", " ", "L", "", "", "", 1, 1, "M");//12
            p_SetSc("热处理方法1", "E", " ", "L", "", "", "", 1, 1, "M");//13
            p_SetSc("热处理方法2", "E", " ", "L", "", "", "", 1, 1, "M");//14
            p_SetSc("厚", "E", " ", "L", "", "", "", 1, 1, "M");//15
            p_SetSc("宽", "E", " ", "L", "", "", "", 1, 1, "M");//16
            p_SetSc("长", "E", " ", "L", "", "", "", 1, 1, "M");//17
            p_SetSc("重量", "E", " ", "L", "", "", "", 1, 1, "M");//18
            p_SetSc("剪切块数", "E", " ", "L", "", "", "", 1, 1, "M");//19 20140113
            p_SetSc("成材率", "E", " ", "L", "", "", "", 1, 1, "M");//20 20140113
            p_SetSc("计划成品重量", "E", " ", "L", "", "", "", 1, 1, "M");//21
            p_SetSc("实绩成品重量", "E", " ", "L", "", "", "", 1, 1, "M");//22
            p_SetSc("计划成材率", "N", "6,2", "L", "", "", "", 1, 1, "M");//23
            p_SetSc("垛位", "E", " ", "L", "", "", "", 1, 1, "M");//24
            p_SetSc("用户", "E", " ", "IL", "", "", "", 1, 1, "M");//25
            p_SetSc("是否轧废", "E", " ", "L", "", "", "", 1, 1, "M");//26
            p_SetSc("板坯重量", "E", " ", "L", "", "", "", 1, 1, "M");//27
            p_spanSpread("作业指示", 7, 11, 1, 0, 1);
            p_spanSpread("母板实绩", 12, 17, 1, 0, 1);

        //    SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true); //隐藏用户列     
        }

        private void WGT1050C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

        public override bool Form_Cls()
        {
            return base.Form_Cls();
            txt_Mill_NO.Text = "";
        }

        public override void Form_Pro()
        {
            base.Form_Pro();
            txt_Mill_NO.Text = "";

        }

        private void ss1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            mCount = 0;
            if (e.ColumnHeader) return;
            if (e.Column == iSs1_MP_OVER) return;
            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }          
            ss1_Sheet1.Cells[e.Row, iSs1_Emp_Cd].Text = GeneralCommon.sUserID;

            if (ss1_Sheet1.RowHeader.Cells[e.Row,0].Text != "修改")
            {
                if (txt_Mill_NO.Text == "")
                {
                    MILL_NO = ss1_Sheet1.Cells[e.Row, iSs1_MP_NO].Text + "01";
                    txt_Mill_NO.Text = MILL_NO;
                    OVEN_NO = ss1_Sheet1.Cells[e.Row, iSs1_MP_NO].Text.Substring(0, 8);
                    THICK = ss1_Sheet1.Cells[e.Row, iSs1_Thick_NO].Text;
                }
                //相同厚度和相同炉号的母板添加轧批号
                if (ss1_Sheet1.Cells[e.Row, iSs1_MP_NO].Text.Substring(0, 8) == OVEN_NO && ss1_Sheet1.Cells[e.Row, iSs1_Thick_NO].Text == THICK)
                {
                    ss1_Sheet1.Cells[e.Row, iSs1_Mill_NO].Text = txt_Mill_NO.Text;
                    ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("只有具有相同炉号和相同厚度的母板才可以设为同一轧批号，请检查母板间的炉号与厚度！","","");
                }
            }
            else if (ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text == "修改")
            {
                ss1_Sheet1.Cells[e.Row, iSs1_Mill_NO].Text = "";
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
                ss1_Sheet1.Cells[e.Row, iSs1_MP_OVER].Text = "";
  //当表单没有修改存在时，清空MASTER轧批号              
                rowCount = ss1_Sheet1.RowCount;
                for (int i = 0; i < rowCount; i++)
                {
                    if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                    {
                        mCount = mCount + 1;
                    }
                }
                if (mCount == 0)
                {
                    txt_Mill_NO.Text = "";
                }
            }
            //将最后一块轧批号保存到相应字段中
            mCount = -10;
            rowCount = ss1_Sheet1.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                ss1_Sheet1.Cells[i, iSs1_Last_Mill_NO].Text = "";
                if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                {
                    mCount = i;
                }
            }
            if (mCount >= 0)
            {
                ss1_Sheet1.Cells[mCount, iSs1_Last_Mill_NO].Text = "Y";
            }
            return;
        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
            double dMillPlan_Wgt = 0;
            double dMillSlab_Wgt = 0;
            string sValue = "";
            string sValue1 = "";
            string sValue2 = "";


            if (ss1.ActiveSheet.RowCount < 1)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                //计算 计划成品重量 累计
                sValue = ss1.ActiveSheet.Cells[i, iPlan_wgt].Text;
                if (sValue == "")
                {

                }
                else
                {
                    dMillPlan_Wgt = double.Parse(sValue) + dMillPlan_Wgt;
                }

                //计算 板坯重量 累计
                sValue2 = ss1.ActiveSheet.Cells[i, islab_wgt].Text;
                if (sValue2 == "")
                {

                }
                else
                {
                    dMillSlab_Wgt = double.Parse(sValue2) + dMillSlab_Wgt;
                }
                //计划成材率
                ss1.ActiveSheet.Cells[i, iPlan_rat].Text = (double.Parse(sValue) * 100 / double.Parse(sValue2)).ToString();
            }
        }

    }
}
