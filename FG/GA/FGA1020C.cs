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
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            装炉作业实绩查询及修改界面                                
///-- 程序ID            FGA1020C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2014.07.24                                                
///-- 处理描述          装炉作业实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.24        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGA1020C : CommonClass.FORMBASE
    {
        public FGA1020C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        ////    public const int iSs1_Slab_No = 0;  //SS1板坯号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);
            p_SetMc("产线别", cbo_PrcLine, "PN", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("指示方法", txt_Htm, "P", "", "", "", "", imcseq);
            p_SetMc("指示条件", txt_HtmCond, "P", "", "", "", "", imcseq);
            p_SetMc("物料号或者轧坯号", TXT_PROD_CD, "P", "", "", "", "", imcseq);


                    p_McIni(Mc2, false);
                    imcseq = 2;
                    p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("作业种类", "E", "60", "", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("物料号", "E", "60", "PI", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("抛丸", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("热处理", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("炉坐号", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("热处理方法", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("装炉温度", "N", "6,2", "I", "", "", "", iscseq, iheadrow, "R");//6;   
            p_SetSc("班次", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//7 
            p_SetSc("班别", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("作业人", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("装炉时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("重量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("货位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("试样", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("EDT_SEQ", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("SEQ_NO", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("PLT", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("PRC_LINE", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("len", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("chg_dischg", "N", "8,2", "I", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("轧坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("期限日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27

            iheadrow = 0;
            p_spanSpread("装炉实绩", 4, 10, iscseq, iheadrow, 1);
            p_spanSpread("产品", 11, 14, iscseq, iheadrow, 1);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 8, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);


        }


        private void FGA1020C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_PLT.Enabled = false;
            f4ETCR_PLT.Enabled = false;
            TXT_PLT.Text = "宽厚板厂";
            f4ETCR_PLT.Text = "C2";
            TXT_EMP.Text = GeneralCommon.sUserID;

        }
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.Sheets[0].Rows.Count <= 0)
            {
                return;
            }


           

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
             //   ss1.ActiveSheet.Cells[e.Row, 0].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 6].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 7].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 8].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 9].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 10].Text = "";
            }
            else
            {
                if (cbo_chg_no.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认炉座号....!", "I", "");
                    return;
                }

                if (txt_ChargeTemp.Text == "" || txt_ChargeTemp.Text == "0" )
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认装炉温度....!", "I", "");
                    return;
                }

                if (TXT_DISCHARGE_TIME.Text.Substring(0, 1) != "2")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认装炉时间....!", "I", "");
                    return;
                }


             //   ss1.ActiveSheet.Cells[e.Row, 0].Text = "1";
                ss1.ActiveSheet.Cells[e.Row, 4].Text = cbo_chg_no.Text;

                if (txt_ChargeTemp.Text != "")
                {
                    ss1.ActiveSheet.Cells[e.Row, 6].Text = txt_ChargeTemp.Text;
                }

                ss1.ActiveSheet.Cells[e.Row, 7].Text = TXT_SHIFT.Text;
                ss1.ActiveSheet.Cells[e.Row, 8].Text = TXT_GROUP.Text;
                ss1.ActiveSheet.Cells[e.Row, 9].Text = GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[e.Row, 10].Text = TXT_DISCHARGE_TIME.Text;
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

            }
        }


        private void OPT_SLAB_Click(object sender, EventArgs e)
        {
            if (OPT_SLAB.Checked == true)
            {
                TXT_PROD_CD.Text = "LO";
            }
            else
            {
                TXT_PROD_CD.Text = "SL";
            }
        }


        private void OPT_Mat_Click_1(object sender, EventArgs e)
        {
            if (OPT_Mat.Checked == true)
            {
                TXT_PROD_CD.Text = "SL";
            }
            else
            {
                TXT_PROD_CD.Text = "LO";
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            OPT_Mat.Checked = true;
            TXT_PLT.Enabled = false;
            f4ETCR_PLT.Enabled = false;
            TXT_PLT.Text = "宽厚板厂";
            f4ETCR_PLT.Text = "C2";
            return true;
        }

    }
}
