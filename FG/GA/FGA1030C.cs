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
    public partial class FGA1030C : CommonClass.FORMBASE
    {
        public FGA1030C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);
            p_SetMc("产线别", cbo_PrcLine, "PN", "", "", "", "", imcseq);
            p_SetMc("炉座号", cbo_chg_no, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);


            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("作业种类", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("物料号", "E", "60", "PI", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("热处理方法", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("装炉时间", "DT", "L", "", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当前热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("驻留时间", "N", "5", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("出炉时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("加热温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("出炉温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("冷却开始", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("冷却结束", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("班次", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("班别", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("作业人", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("长度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("重量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("试样", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("炉坐号", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("SEQ_NO", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("PLT", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("PRC_LINE", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("轧坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("加热段时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("均热段时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("加热速率", "N", "4,2", "I", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("入炉速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("工艺速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("出炉速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("平均温度", "N", "4", "AIL", "", "", "", iscseq, iheadrow, "M");//33

            iheadrow = 0;
            p_spanSpread("作业实绩", 5, 13, iscseq, iheadrow, 1);
            p_spanSpread("产品", 14, 17, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 11, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 22, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 23, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 26, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 27, true);


        }

        private void FGA1030C_Load(object sender, EventArgs e)
        {
            Form_Define();
            TXT_PLT.Enabled = false;
            f4ETCR_PLT.Enabled = false;
            TXT_PLT.Text = "宽厚板厂";
            f4ETCR_PLT.Text = "C2";
            TXT_EMP.Text = GeneralCommon.sUserID;
        }
        
        #endregion


        public override bool Form_Cls()
        {
            base.Form_Cls();
            TXT_PLT.Enabled = false;
            f4ETCR_PLT.Enabled = false;
            TXT_PLT.Text = "宽厚板厂";
            f4ETCR_PLT.Text = "C2";
            SDB_WAT_TEMP.Text = "0";
            return true;
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            DateTime CHARGE_DATE;
            DateTime WRK_DATE;
            
            if (ss1.Sheets[0].Rows.Count <= 0)
            {
                return;
            }

            if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
            {
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "1";
              //  ss1.ActiveSheet.Cells[e.Row, 1].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 5].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 6].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 7].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 8].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 9].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 10].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 11].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 12].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 13].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 28].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 29].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 30].Text = "";
                ss1.ActiveSheet.Cells[e.Row, 31].Text = "";


            }
            else
            {
                if (TXT_DISCHARGE_TIME.Text.Substring(0, 1) != "2")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请先确认出炉时间......!", "I", "");
                    return;
                }



                if (txt_DisCharTemp.Text == "" || txt_DisCharTemp.Text == "0")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认出炉温度....!", "I", "");
                    return;
                }
                if (txt_HeatTemp.Text == "" || txt_HeatTemp.Text == "0")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请确认加热温度....!", "I", "");
                    return;
                }

                ss1.ActiveSheet.Cells[e.Row, 0].Text = "1";

                if (SDB_WAT_TEMP.Text != "" && SDB_WAT_TEMP.Text != "0")
                {
                    ss1.ActiveSheet.Cells[e.Row, 5].Text = SDB_WAT_TEMP.Text;
                }
              
                ss1.ActiveSheet.Cells[e.Row, 6].Text = TXT_DISCHARGE_TIME.Text;

                if (txt_HeatTemp.Text != "" && txt_HeatTemp.Text != "0" )
                {
                    ss1.ActiveSheet.Cells[e.Row, 7].Text = txt_HeatTemp.Text;
                }

                if (txt_DisCharTemp.Text != "" && txt_DisCharTemp.Text != "0")
                {
                    ss1.ActiveSheet.Cells[e.Row, 8].Text = txt_DisCharTemp.Text;
                }
                if (TXT_ColStaTemp.Text != ""&&TXT_ColStaTemp.Text != "0")
                {
                    ss1.ActiveSheet.Cells[e.Row, 9].Text = TXT_ColStaTemp.Text;
                }
                if (TXT_ColEndTemp.Text != "" && TXT_ColEndTemp.Text != "0")
                {
                    ss1.ActiveSheet.Cells[e.Row, 10].Text = TXT_ColEndTemp.Text;
                }

                ss1.ActiveSheet.Cells[e.Row, 11].Text = TXT_SHIFT.Text;
                ss1.ActiveSheet.Cells[e.Row, 12].Text = TXT_GROUP.Text;
                ss1.ActiveSheet.Cells[e.Row, 13].Text = GeneralCommon.sUserID;
                ss1.ActiveSheet.Cells[e.Row, 20].Text = cbo_chg_no.Text;


                if (txt_HEAT_RATIO.Text != "" && txt_HEAT_RATIO.Text != "0.00")
                {
                    ss1.ActiveSheet.Cells[e.Row, 28].Text = txt_HEAT_RATIO.Text;
                }
                if (txt_SP_CHARGE.Text != "" && txt_SP_CHARGE.Text != "0.00")
                {
                    ss1.ActiveSheet.Cells[e.Row, 29].Text = txt_SP_CHARGE.Text;
                }
                if (txt_SP_CAL.Text != "" && txt_SP_CAL.Text != "0.00")
                {
                    ss1.ActiveSheet.Cells[e.Row, 30].Text = txt_SP_CAL.Text;
                }
                if (txt_SP_DISCHARGE.Text != "" && txt_SP_DISCHARGE.Text != "0.00")
                {
                    ss1.ActiveSheet.Cells[e.Row, 31].Text = txt_SP_DISCHARGE.Text;
                }
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

            }

           

        }

        private void f4ETCR_PLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
