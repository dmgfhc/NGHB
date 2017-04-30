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
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   统计分析管理
//-- Program Name      钢板实绩查询界面
//-- Program ID        WGT2010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李超
//-- Coder             李超
//-- Date              2012.11.23
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER        DATE         EDITOR       DESCRIPTION
//-- 1.00    2012.11.23       李超        钢板实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT2010C : CommonClass.FORMBASE
    {
        public WGT2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_USERID = 75,
                  SPD_WGT = 15,
                  SPD_SURF_GRD = 17,
                  SPD_DEL_TO_DATE = 4,
                  SPD_PROC_CD = 3,
                  SPD_JIT_FLAG = 80,
                  SPD_DATE_YN = 68,
                  SPD_ORD_LEN = 82,
                  SPD_PLT_LEN = 14,
                  SPD_PLAN_WGT = 84,
                  SPD_RST_WGT = 85,
                  SPD_SLAB_WGT = 86,
                  SPD_PLAN_RAT = 87,
                  SPD_RST_RAT = 88;
                   
                

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "PR", "", "", "",imcseq,"");
            p_SetMc("生产时间",CUD_PROD_DATE_FROM, "PR", "", "", "","", imcseq);
            p_SetMc("生产时间",CUD_PROD_DATE_TO, "P", "", "", "","", imcseq);
            p_SetMc(CBO_SHIFT, "PR", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "PR", "", "", "", imcseq, "");
            p_SetMc(CBO_SURFGRD, "PR", "", "", "", imcseq, "");
            p_SetMc(CBO_PRODGRD, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_STDSPEC_CHG, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_SP_CD, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_THK, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_WID, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_THK_TO, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_WID_TO, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_LEN, "PR", "", "", "", imcseq, "");
            p_SetMc(NMB_LEN_TO, "PR", "", "", "", imcseq, "");
            p_SetMc(SLAB_THK, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_STLGRD, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_SMP_NO, "PR", "", "", "", imcseq, "");
            p_SetMc(CBO_PRC_LINE, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_PROC_CD, "PR", "", "", "", imcseq, "");
            p_SetMc(TXT_ORG_ORD_NO, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ORG_ORD_ITEM, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_LOC, "P", "", "", "", imcseq, "");
            p_SetMc(TXT_ENDUSE_CD, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_HL_GROUP_CD, "P", "", "", "", imcseq, "");
            

            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            //0-47
            p_SetSc("剪切线", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow,"M");//1  Insert
            p_SetSc("首件标识", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("进程状态", "E", "6", "L", "", "", "", iscseq, iheadrow,"M");//3
            p_SetSc("客户交货期", "D", "8", "L", "", "", "", iscseq, iheadrow,"M");//4
            p_SetSc("铸机号", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//5
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//6
            p_SetSc("轧制标准", "E", "30", "L", "", "", "", iscseq, iheadrow,"L");//7
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow,"L");//8
            p_SetSc("目标宽度", "E", "8", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("轧制宽度", "E", "8", "L", "", "", "", iscseq, iheadrow, "R");//10  --20141127 
            p_SetSc("订单厚度", "E", "8", "L", "", "", "", iscseq, iheadrow,"R");//11
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow,"R");//12
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//13
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//14
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow,"R");//15
            p_SetSc("产品等级", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");//16
            p_SetSc("表面等级", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");//17
            p_SetSc("取样代码", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//18
            p_SetSc("试样号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//19
            p_SetSc("钢种", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("执行标准", "E", "50", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("喷印", "C", "1", "I", "", "", "", iscseq, iheadrow);//22   Insert
            p_SetSc("冲印", "C", "1", "I", "", "", "", iscseq, iheadrow);//23   Insert
            p_SetSc("侧喷", "C", "1", "I", "", "", "", iscseq, iheadrow);//24   Insert
            p_SetSc("切边", "C", "1", "I", "", "", "", iscseq, iheadrow);//25   Insert
            p_SetSc("定尺", "C", "1", "I", "", "", "", iscseq, iheadrow);//26   Insert
            p_SetSc("修磨", "C", "1", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("缺陷", "E", "40", "L", "", "", "", iscseq, iheadrow,"L");//28
            p_SetSc("改判缺陷", "E", "40", "L", "", "", "", iscseq, iheadrow,"L");//29
            p_SetSc("钢板不平度1", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//30
            p_SetSc("测量长度1", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//31
            p_SetSc("钢板不平度2", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("测量长度2", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//33
            p_SetSc("轧制异常", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//34
            p_SetSc("修磨坯", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//35
            p_SetSc("轧制时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("轧制班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("生产时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//38
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");//39
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//40
            p_SetSc("入库时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"R");//41
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//42
            p_SetSc("是否紧急订单", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("试样备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("尺寸备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("打包备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("探伤", "E", "8", "L", "", "", "", iscseq, iheadrow,"L");//48
            p_SetSc("切割", "E", "3", "L", "", "", "", iscseq, iheadrow,"L");//49
            p_SetSc("矫直", "E", "3", "L", "", "", "", iscseq, iheadrow,"L");//50---
            p_SetSc("压平", "E", "3", "L", "", "", "", iscseq, iheadrow, "L");//51

            p_SetSc("抛丸指示", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("热处理", "E", "14", "L", "", "", "", iscseq, iheadrow,"L");//53
            p_SetSc("喷涂交货", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("其它", "E", "140", "L", "", "", "", iscseq, iheadrow,"L");//55
            p_SetSc("修改时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//56 ADD BY 20140210 LICHAO
            p_SetSc("钢板剪切时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//57
            p_SetSc("剪切班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//58
            p_SetSc("厚度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//59
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow,"R");//60
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow,"R");//61
            p_SetSc("异常坯", "E", "3", "L", "", "", "", iscseq, iheadrow, "R");//62 2014
            p_SetSc("堆冷时间(小时)", "E", "8", "L", "", "", "", iscseq, iheadrow,"R");//63
            p_SetSc("订单用途", "E", "4", "L", "", "", "", iscseq, iheadrow,"M");//64
            p_SetSc("订单材/余材代码", "N", "1", "L", "", "", "", iscseq, iheadrow,"M");//65
            p_SetSc("订单种类", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//66
            p_SetSc("原因", "E", "20", "L", "", "", "", iscseq, iheadrow,"L");//67
            p_SetSc("是否超交货期", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//68
            p_SetSc("原始订单号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//69
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//70
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//71
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");//72
            p_SetSc("温矫班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//73
            p_SetSc("温矫时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//74
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow,"M");//75   Insert
            p_SetSc("钢板性能", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//76 add 20140311
            p_SetSc("矫直机号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//77 add 20140421
            p_SetSc("矫直入库温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//78 add 20140421
            p_SetSc("矫直出口温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//79 add 20140421
            p_SetSc("定制配送", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//80
            p_SetSc("订单用途", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//81
            p_SetSc("订单长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//82
            p_SetSc("是否修磨", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//83
            p_SetSc("计划成品重量", "E", "20", "AL", "", "", "", iscseq, iheadrow, "R");//84
            p_SetSc("实绩成品重量", "E", "20", "AL", "", "", "", iscseq, iheadrow, "R");//85
            p_SetSc("板坯重量", "E", "20", "AL", "", "", "", iscseq, iheadrow, "R");//86
            p_SetSc("计划成材率", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//87
            p_SetSc("实绩成材率", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//88
            p_SetSc("上限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//89
            p_SetSc("下限", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//90
            p_SetSc("订单特殊要求", "E", "300", "L", "", "", "", iscseq, iheadrow, "L");//91
            


            iheadrow = 0;
            p_spanSpread("作业指示/实绩", 48, 53, iscseq, iheadrow, 1);
            p_spanSpread("钢板剪切", 57, 58, iscseq, iheadrow, 1);
            p_spanSpread("板坯规格", 59, 61, iscseq, iheadrow, 1);
            p_spanSpread("标识", 20, 21, iscseq, iheadrow, 1);
            p_spanSpread("长度公差", 89, 90, iscseq, iheadrow, 1);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGC2200C";
            Form_Define();
            OPT_PLATE.Checked = true;
       //     base.sAuthority = "1111";
        }
        #endregion

        //检查查询号长度
        private void TXT_PLATE_NO_TextChanged(object sender, EventArgs e)
        {
            string SMESG = "";
            if (TXT_PLATE_NO.TextLength > 14)
            {
                SMESG = "查询号长度不能超过14位，请确认查询号 ！！！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG,"","");
            }
        }

        //通过回车查询
        private void WGT2010C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Strings.ChrW((int)Keys.Enter))
            {
                if (TXT_PLATE_NO.TextLength > 8)
                {
                    Form_Ref();
                }  
            }
        }

        //轧制
        private void OPT_SLAB_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_SLAB.Checked)
            {
                OPT_SLAB.ForeColor = Color.Red;
                OPT_PLATE.ForeColor = Color.Black;
                OPT_CUT.ForeColor = Color.Black;
                TXT_SP_CD.Text = "S";
            }
        }

        //生产
        private void OPT_PLATE_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_PLATE.Checked)
            {
                OPT_PLATE.ForeColor = Color.Red;
                OPT_SLAB.ForeColor = Color.Black;
                OPT_CUT.ForeColor = Color.Black;
                TXT_SP_CD.Text = "P";
            }
        }

        //剪切
        private void OPT_CUT_Click(object sender, EventArgs e)
        {
            ss1.ActiveSheet.RowCount = 0;

            if (OPT_CUT.Checked)
            {
                OPT_CUT.ForeColor = Color.Red;
                OPT_SLAB.ForeColor = Color.Black;
                OPT_PLATE.ForeColor = Color.Black;
                TXT_SP_CD.Text = "C";
            }
        }

        //重写ss1
        protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        {
            base.ss_CellClickEvent(sender, e);
            if (ss1.ActiveSheet.RowCount < 1)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text == "喷印" || ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text == "冲印" || ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text == "侧喷" || ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text == "切边" || ss1.ActiveSheet.ColumnHeader.Cells[0, e.Column].Text == "定尺")
                {
                    //ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "Update";
                    ss1.ActiveSheet.Cells[e.Row, SPD_USERID].Text = GeneralCommon.sUserID;
                }
            }
        }

        private void TXT_STLGRD_TextChanged(object sender, EventArgs e)
        {
            if (TXT_STLGRD.TextLength != 11)
            {
                TXT_STLGRD_NAME.Text = "";
            }
        }

        #region 重写查询
        public override void Form_Ref()
        {
            string strWgt = "";
            string SURF = "";
            double sTotnum = 0;
            double sTotwgt = 0;
            double s1num = 0;
            double s2num = 0;
            double s3num = 0;
            double s4num = 0;
            double s5num = 0;
            double s7num = 0;
            double s1Wgt = 0;
            double s2Wgt = 0;
            double s3Wgt = 0;
            double s4Wgt = 0;
            double s5Wgt = 0;
            double s7Wgt = 0;

            string sCurDate = "";
            string sDel_To_Date = "";
            string sproc_cd = "";

            string sValue = "";
            string sValue1 = "";
            string sValue2 = "";

            p_Ref(1, 1, true, true);
            if (ss1.ActiveSheet.RowCount <= 1)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                // 总重量数
                sTotnum = sTotnum + 1;
                strWgt = ss1.ActiveSheet.Cells[i, SPD_WGT].Text;

                //钢板长度与订单长度不符合，绿色显示
                if (fpSpread1_Sheet1.Cells[i, SPD_PLT_LEN].Text != fpSpread1_Sheet1.Cells[i, SPD_ORD_LEN].Text)
                {
                    fpSpread1_Sheet1.Rows.Get(i).BackColor = Color.Green;
                }

                //定制配送钢板，褐色显示
                if (fpSpread1_Sheet1.Cells[i, SPD_JIT_FLAG].Text == "Y")
                {
                    fpSpread1_Sheet1.Rows.Get(i).BackColor = Color.Brown;
                }

                //重量（累计）
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, SPD_WGT].Text == "重量")
                {
                    strWgt = ss1.ActiveSheet.Cells[i, SPD_WGT].Text;
                    if (strWgt == "")
                    {

                    }
                    else
                    {
                        sTotwgt = sTotwgt + double.Parse(strWgt);
                    }
                }
                TXT_TOT_NUM.Text = sTotnum.ToString();
                TXT_TOT_WGT.Text = (Math.Round(sTotwgt, 3)).ToString();

                sValue = ss1.ActiveSheet.Cells[i, SPD_PLAN_WGT].Text;
                sValue1 = ss1.ActiveSheet.Cells[i, SPD_RST_WGT].Text;
                sValue2 = ss1.ActiveSheet.Cells[i, SPD_SLAB_WGT].Text;

                ss1.ActiveSheet.Cells[i, SPD_PLAN_RAT].Text = (double.Parse(sValue) * 100 / double.Parse(sValue2)).ToString();

                ss1.ActiveSheet.Cells[i, SPD_RST_RAT].Text = (double.Parse(sValue1) * 100 / double.Parse(sValue2)).ToString();

                //正品（累计）
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, SPD_SURF_GRD].Text == "表面等级")
                {
                    SURF = ss1.ActiveSheet.Cells[i, SPD_SURF_GRD].Text;
                    if (SURF == "正品")
                    {
                        s1num = s1num + 1;
                        s1Wgt = s1Wgt + double.Parse(strWgt);
                    }
                    if (SURF == "改判")
                    {
                        s2num = s2num + 1;
                        s2Wgt = s2Wgt + double.Parse(strWgt);
                    }
                    if (SURF == "协议")
                    {
                        s3num = s3num + 1;
                        s3Wgt = s3Wgt + double.Parse(strWgt);
                    }
                    if (SURF == "待判")
                    {
                        s4num = s4num + 1;
                        s4Wgt = s4Wgt + double.Parse(strWgt);
                    }
                    if (SURF == "次品")
                    {
                        s5num = s5num + 1;
                        s5Wgt = s5Wgt + double.Parse(strWgt);
                    }
                    if (SURF == "废品")
                    {
                        s7num = s7num + 1;
                        s7Wgt = s7Wgt + double.Parse(strWgt);
                    }
                }
                TXT_1_NUM.Text = (Math.Round(s1num, 3)).ToString();
                TXT_1_WGT.Text = (Math.Round(s1Wgt, 3)).ToString();
                TXT_2_NUM.Text = (Math.Round(s2num, 3)).ToString();
                TXT_2_WGT.Text = (Math.Round(s2Wgt, 3)).ToString();
                TXT_3_NUM.Text = (Math.Round(s3num, 3)).ToString();
                TXT_3_WGT.Text = (Math.Round(s3Wgt, 3)).ToString();
                TXT_4_NUM.Text = (Math.Round(s4num, 3)).ToString();
                TXT_4_WGT.Text = (Math.Round(s4Wgt, 3)).ToString();
                TXT_5_NUM.Text = (Math.Round(s5num, 3)).ToString();
                TXT_5_WGT.Text = (Math.Round(s5Wgt, 3)).ToString();
                TXT_7_NUM.Text = (Math.Round(s7num, 3)).ToString();
                TXT_7_WGT.Text = (Math.Round(s7Wgt, 3)).ToString();


                DateTime currentTime = System.DateTime.Now;
                string strYM = currentTime.ToString("y");
                if (ss1.ActiveSheet.ColumnHeader.Cells[0, SPD_DEL_TO_DATE].Text == "客户交货期")
                {
                    string sdate = "";
                    sdate = ss1.ActiveSheet.Cells[i, SPD_DEL_TO_DATE].Text;
                    sDel_To_Date = sdate.Substring(0, 7);
                    if (DateTime.Parse(sDel_To_Date) < DateTime.Parse(strYM))
                    {
                        if (ss1.ActiveSheet.ColumnHeader.Cells[0, SPD_PROC_CD].Text == "进程状态")
                        {
                            string proc = "";
                            proc = ss1.ActiveSheet.Cells[i, SPD_PROC_CD].Text;
                            sproc_cd = proc.Substring(1, 1);
                        }
                        if (sproc_cd != "X")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount -1, i, i, Color.Red, Color.White);
                            ss1.ActiveSheet.Cells[i, SPD_DATE_YN].Text = "Y";
                        }
                    }
                }

            }

        }
        #endregion

        
    }
}
