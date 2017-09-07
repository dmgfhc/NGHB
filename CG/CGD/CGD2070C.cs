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
//-- Sub_System Name   指示下达
//-- Program Name      录入精整作业指示_CGD2070C
//-- Program ID        _CGD2070C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.08.15
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.08.15       韩超        录入精整作业指示_CGD2070C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGD2070C : CommonClass.FORMBASE
    {
        public CGD2070C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SS1_CONF_TIME = 0;
        const int SS1_LINE = 1;
        const int SS1_PLATE_NO = 2;
        const int SS1_PROD_CD = 3;
        const int SS1_PROC_CD = 4;
        const int SS1_SPEC_FL = 5;
        const int SS1_SPEC_NAME = 6;
        const int SS1_DEL_DATE_TO = 8;
        const int SS1_GAS_FL = 12;
        const int SS1_GRID_FL = 15;
        const int SS1_CL_FL = 17;
        const int SS1_UST_FL = 19;
        const int SS1_UST_M = 20;
        const int SS1_SB_FL = 24;
        const int SS1_SB_M = 25;
        const int SS1_HTM_FL = 27;
        const int SS1_HTM_M1 = 30;
        const int SS1_HTM_C1 = 31;
        const int SS1_HTM_M2 = 32;
        const int SS1_HTM_C2 = 33;
        const int SS1_HTM_M3 = 34;
        const int SS1_HTM_C3 = 35;
        const int SS1_REMARK = 37;
        const int SS1_USERID = 45;
        const int SPD_URGNT_FL = 51;

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("", txt_PrcLine, "PA", "", "", "", "", imcseq);//0
            p_SetMc("", TXT_PLATE_NO, "P", "", "", "", "", imcseq);//1
            p_SetMc("", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);//2
            p_SetMc("", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);//3
            p_SetMc("", cbo_shift, "P", "", "", "", "", imcseq);//4
            p_SetMc("生产工厂", txt_plt, "PN", "", "", "", "", imcseq);//5
            p_SetMc("当前库", txt_cur_inv_code, "PN", "", "", "", "", imcseq);//6
            p_SetMc("", txt_stdspec_chg, "P", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_THK, "P", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_WID, "P", "", "", "", "", imcseq);//9
            p_SetMc("", txt_lot_no, "P", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_LOC, "P", "", "", "", "", imcseq);//11
            p_SetMc("", SDB_THK_TO, "P", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_WID_TO, "P", "", "", "", "", imcseq);//13
            p_SetMc("", cbo_prod_cd, "P", "", "", "", "", imcseq);//14

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("钢板号", Text1_PLATE_NO, "PI", "", "", "", "", imcseq);//0
            p_SetMc("备注", txt_REMARKS, "IR", "", "", "", "", imcseq);//0

            p_ScIni(ss1, Sc1, 45, false, true);
            int iscseq;
            int iheadrow;
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("确认时间", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("Line", "E", "60", "IA", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("钢板号", "E", "14", "PI", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("产品代码", "E", "14", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("进程代码", "E", "14", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("名称", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("入库日期", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("交货期", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("厚度*宽度*长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("重量", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //11
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("切割", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("切割块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("修磨", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("冷矫直", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("新指示", "E", "60", "I", "", "", "", iscseq, iheadrow, "L"); //20
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("压平", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //23
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("新指示", "E", "60", "I", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("抛丸", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("指定", "C", "", "I", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("热处理实绩", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("方法一", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //30
            p_SetSc("条件一", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //31
            p_SetSc("方法二", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //32
            p_SetSc("条件二", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //33
            p_SetSc("方法三", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //34
            p_SetSc("条件三", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //35
            p_SetSc("定单备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "L"); //36
            p_SetSc("生产备注", "E", "100", "I", "", "", "", iscseq, iheadrow, "L"); //37
            p_SetSc("产品等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //38
            p_SetSc("表面等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //39
            p_SetSc("取样代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //40
            p_SetSc("试样号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //41
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //42
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //43
            p_SetSc("客户", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //44
            p_SetSc("作业人", "E", "60", "I", "", "", "", iscseq, iheadrow, "M"); //45
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //46
            p_SetSc("库", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //47
            p_SetSc("垛位", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //48
            p_SetSc("修改作业人员", "E", "12", "L", "", "", "", iscseq, iheadrow, "M"); //49
            p_SetSc("修改时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //50
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //51

            iheadrow = 0;
            p_spanSpread("特殊工序", 5, 6, iscseq, iheadrow, 1);
            p_spanSpread("钢板信息", 9, 11, iscseq, iheadrow, 1);
            p_spanSpread("精整指示及实绩", 12, 23, iscseq, iheadrow, 1);
            p_spanSpread("热处理指示及实绩", 24, 35, iscseq, iheadrow, 1);

        }

        private void chk_can_Clk()
        {
            if (chk_can0.Checked == true)
            {
                chk_can0.ForeColor = Color.Red;
                chk_can1.ForeColor = Color.Black;
                chk_can2.ForeColor = Color.Black;
                chk_can1.Checked = false;
                chk_can2.Checked = false;
            }
            else if (chk_can1.Checked == true)
            {
                chk_can0.ForeColor = Color.Black;
                chk_can1.ForeColor = Color.Red;
                chk_can2.ForeColor = Color.Black;
                chk_can0.Checked = false;
                chk_can2.Checked = false;
            }
            else if (chk_can2.Checked == true)
            {
                chk_can0.ForeColor = Color.Black;
                chk_can1.ForeColor = Color.Black;
                chk_can2.ForeColor = Color.Red;
                chk_can0.Checked = false;
                chk_can1.Checked = false;
            }
        }

        private void opt_LineFlag_Clk()
        {
            List<RadioButton> opt_LineFlag = new List<RadioButton>();

            opt_LineFlag.Add(opt_LineFlag0);
            opt_LineFlag.Add(opt_LineFlag2);

            foreach (var LineFlag in opt_LineFlag)
            {
                if (LineFlag.Checked == true)
                {
                    LineFlag.ForeColor = Color.Red;
                    txt_PrcLine.Text = "1";
                }
                else
                {
                    LineFlag.ForeColor = Color.Black;
                    txt_PrcLine.Text = "3";
                }
            }
        }

        private void txt_HTM_COND1_Chg()
        {
            if (txt_HTM_COND1.Text.Trim().Length == 4)
            {
                if (txt_HTM_METH1.Text.Trim() != substr(txt_HTM_COND1.Text, 0, 1))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("热处理方法与热处理条件不一样", "I", "");
                    txt_HTM_COND1.Text = "";
                }
            }
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2070NC";
            Form_Define();
            txt_plt.Text = "C3";
            txt_cur_inv_code.Text = "ZB";
            SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
            SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
            opt_LineFlag0.Checked = true;
            txt_PrcLine.Text = "1";
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                txt_plt.Text = "C3";
                txt_cur_inv_code.Text = "ZB";
                SDT_PROD_DATE_FROM.RawDate = Gf_DTSet("D", "");
                SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
                Text1_PLATE_NO.Text = "";
                opt_LineFlag0.Checked = true;
                txt_PrcLine.Text = "1";
            }
            return true;
        }

        public override void Form_Ref()
        {
            string SMESG;

            int iRow;
            string sCurDate;
            string sDel_To_Date;
            string sURGNT;

            sCurDate = DateTime.Now.ToString("yyyyMMdd");

            if (!opt_LineFlag0.Checked & !opt_LineFlag2.Checked)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请选择精整等待或精整保留...!", "I", "");
                return;
            }

            p_Ref(1, 1, true, true);


            //超交货期用红色显示 add by liqian 2012-07-23
            {
                for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                {
                    sDel_To_Date = substr(ss1.ActiveSheet.Cells[iRow - 1, SS1_DEL_DATE_TO].Text, 0, 6);
                    if (convertX(sDel_To_Date) < convertX(sCurDate))
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                    }

                    //是否紧急订单警示
                    sURGNT = ss1.ActiveSheet.Cells[iRow - 1, SPD_URGNT_FL].Text;
                    if (sURGNT == "Y")
                    {
                        SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                    }
                }

                Text1_PLATE_NO.Text = ss1.ActiveSheet.Cells[0, SS1_PLATE_NO].Text;

                p_Ref(2, 0, true, true);
            }

        }

        public override void Form_Pro()
        {
            p_Pro(1, 1, true, true);

            p_Pro(2, 0, true, true);
        }


        private void ss1_Clk(int Col, int ROW)
        {
            int ForCnt;
            string chkFL;
            string chkOrd;
            int ORGCOL;

            if (ss1.ActiveSheet.RowCount < 0) return;

            lBlkcol1 = 0;
            lBlkcol2 = 0;
            lBlkrow1 = 0;
            lBlkrow2 = 0;

            ORGCOL = Col;

            if (txt_PrcLine.Text == "1" | txt_PrcLine.Text == "3")
            {

                ss1.ActiveSheet.Cells[ROW, SS1_USERID].Text = GeneralCommon.sUserID;


                if (ORGCOL == SS1_GAS_FL | ORGCOL == SS1_GRID_FL | ORGCOL == SS1_CL_FL)
                {
                    ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                }

                if (ORGCOL == SS1_SPEC_FL)
                {
                    if (txt_PrcLine.Text == "1")
                    {
                        if (TXT_SPEC_PROC.Text.Length != 1)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认特殊工序", "I", "");
                            return;
                        }
                        ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_SPEC_NAME].Text = TXT_SPEC_PROC.Text;
                    }
                }

                if (ORGCOL == SS1_UST_FL)
                {
                    if (txt_PrcLine.Text == "1")
                    {
                        if (txt_UST.Text.Length != 4)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认探伤方法", "I", "");
                            return;
                        }
                        ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_UST_M].Text = txt_UST.Text;
                    }
                }

                if (ORGCOL == SS1_SB_FL)
                {
                    if (txt_PrcLine.Text == "1")
                    {
                        if (txt_SB.Text.Trim() == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认抛丸方法", "I", "");
                            return;
                        }
                        ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_SB_M].Text = txt_SB.Text;
                    }
                }

                if (ORGCOL == SS1_HTM_FL)
                {

                    if (txt_PrcLine.Text == "1")
                    {

                        if (txt_HTM_METH1.Text == "" && txt_HTM_METH2.Text == "" && txt_HTM_METH3.Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理方法", "I", "");
                            return;
                        }

                        if (txt_HTM_METH1.Text == "" && txt_HTM_METH2.Text != "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理方法一", "I", "");
                            return;
                        }

                        if (txt_HTM_METH2.Text == "" && txt_HTM_METH3.Text != "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理方法二", "I", "");
                            return;
                        }

                        if (txt_HTM_METH1.Text != "" && txt_HTM_COND1.Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理条件一", "I", "");
                            return;
                        }

                        if (txt_HTM_METH2.Text != "" && txt_HTM_COND2.Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理条件二", "I", "");
                            return;
                        }

                        if (txt_HTM_METH3.Text != "" && txt_HTM_COND3.Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请确认热处理条件三", "I", "");
                            return;
                        }

                        ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_M1].Text = txt_HTM_METH1.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_C1].Text = txt_HTM_COND1.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_M2].Text = txt_HTM_METH2.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_C2].Text = txt_HTM_COND2.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_M3].Text = txt_HTM_METH3.Text;
                        ss1.ActiveSheet.Cells[ROW, SS1_HTM_C3].Text = txt_HTM_COND3.Text;

                    }
                    else
                    {

                        if (!chk_can0.Checked & !chk_can1.Checked & !chk_can2.Checked)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请选择取消方法", "I", "");
                            return;
                        }

                        if (chk_can0.Checked & !chk_can1.Checked & chk_can2.Checked)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请按顺序选择取消方法", "I", "");
                            return;
                        }

                        if (chk_can0.Checked)
                        {
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_M1].Text = "";
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_C1].Text = "";
                        }

                        if (chk_can1.Checked)
                        {
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_M2].Text = "";
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_C2].Text = "";
                        }

                        if (chk_can2.Checked)
                        {
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_M3].Text = "";
                            ss1.ActiveSheet.Cells[ROW, SS1_HTM_C3].Text = "";
                        }

                    }

                }

                if (ORGCOL == SS1_REMARK)
                {

                    //            If txt_PrcLine = "1" Then
                    //                If Trim(txt_REMARKS) = "" Then
                    //                   MsgBox "请确认备注内容", vbOKOnly + vbQuestion, "提示"
                    //                   Exit Sub
                    //                End If
                    //            End If

                    ss1.ActiveSheet.RowHeader.Cells[ROW, 0].Text = "修改";
                    ss1.ActiveSheet.Cells[ROW, SS1_LINE].Text = txt_PrcLine.Text;
                    ss1.ActiveSheet.Cells[ROW, SS1_REMARK].Text = ss1.ActiveSheet.Cells[ROW, SS1_REMARK].Text;
                    //ss1.Text = txt_REMARKS

                }
            }

            Text1_PLATE_NO.Text = "";

            txt_REMARKS.Text = "";


            Text1_PLATE_NO.Text = ss1.ActiveSheet.Cells[ROW, SS1_PLATE_NO].Text;
            //ss1.Text = txt_REMARKS

            p_Ref(2, 0, true, true);

        }

        # region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }
            if (iDateCheck == "")
            {
                return false;
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 6))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {

            if (DTCheck == "D")
            {
                DTCheck = "D";
            }
            else
            {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            ss1_Clk(e.Column, e.Row);
        }

        private void chk_can0_CheckedChanged(object sender, EventArgs e)
        {
            chk_can_Clk();
        }

        private void chk_can1_CheckedChanged(object sender, EventArgs e)
        {
            chk_can_Clk();
        }

        private void chk_can2_CheckedChanged(object sender, EventArgs e)
        {
            chk_can_Clk();
        }

        private void opt_LineFlag0_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void opt_LineFlag2_CheckedChanged(object sender, EventArgs e)
        {
            opt_LineFlag_Clk();
        }

        private void txt_HTM_COND1_TextChanged(object sender, EventArgs e)
        {
            txt_HTM_COND1_Chg();
        }


    }
}
