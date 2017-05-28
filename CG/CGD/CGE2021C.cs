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

namespace CG {
    public partial class CGE2021C: CommonClass.FORMBASE {
        public CGE2021C() {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        //#region 界面初始化
        protected override void p_SubFormInit() {
            int iheadrow;
            int imcseq;
            int iscseq;
            //查询在制品 
            p_McIni(Mc1, false);
            imcseq = 1;
            //0-5
            p_SetMc("当前库", text_cur_inv_code, "PN", "", "", "", "", imcseq); //0
            p_SetMc("生产时间", SDT_PROD_DATE, "PN", "", "", "", "", imcseq); //1
            p_SetMc("生产时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq); //2
            p_SetMc(txt_stdspec_chg, "P", "", "", "", imcseq, ""); //3
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, ""); //4
            p_SetMc(CBO_SURFGRD, "P", "", "", "", imcseq, ""); //5
            p_SetMc(txt_f_addr, "P", "", "", "", imcseq, ""); //6
            p_SetMc(txt_t_addr, "P", "", "", "", imcseq, ""); //7
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_THK, "P", "", "", "", imcseq, ""); //9
            p_SetMc(CBO_PROD_CD, "P", "", "", "", imcseq, ""); //10
            //p_SetMc(TXT_CNT, "P", "", "", "", imcseq, "");
            //p_SetMc(TXT_WGT, "P", "", "", "", imcseq, "");

            //当前垛位
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("进程状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("重量", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("垛位", "E", "10", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("外观等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //10          
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("生产时间", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //15

            //合并列头
            //iheadrow = 0;
            //p_spanSpread("规格", 6, 9, iscseq, iheadrow, 1);
            //p_spanSpread("作业指示/实绩", 13, 17, iscseq, iheadrow, 1);
            //钢板号冻结
            //ss1.Sheets[0].FrozenColumnCount = 1;

            //目标垛位情况
            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("垛层", "E", "60", "NI", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("钢板号", "E", "14", "I", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("起始垛位", "E", "7", "I", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("重量", "N", "10,3", "L", "", "", "", iscseq, iheadrow, "R"); //8
            p_SetSc("生产日期", "D", "", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("作业人员", "E", "10", "I", "", "", "", iscseq, iheadrow, "M"); //10
            //合并列头
            //iheadrow = 0;
            //p_spanSpread("规格", 5, 8, iscseq, iheadrow, 1);
            //钢板号冻结
            //ss2.Sheets[0].FrozenColumnCount = 2;

        }


        private void CGE2021C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGE2021NC";
            Form_Define();
            SpreadCommon.Gp_Sp_ColHidden(ss2, 2, true);
            TXT_CNT.Text = "";
            TXT_WGT.Text = "";

            text_cur_inv_code.Text = "ZB";
            text_cur_inv.Text = "中板";
            CBO_PROD_CD.SelectedIndex = 0;
            SDT_PROD_DATE_GotFocus();
        }

        private void SDT_PROD_DATE_GotFocus() {
            if (SDT_PROD_DATE.RawDate == "") {
                SDT_PROD_DATE.RawDate = Gf_DTSet("D", "");
            }
            if (SDT_PROD_DATE_TO.RawDate == "") {
                SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
            }
        }

        private void SDT_PROD_DATE_TO_GotFocus() {
            if (SDT_PROD_DATE_TO.RawDate == "") {
                SDT_PROD_DATE_TO.RawDate = Gf_DTSet("D", "");
            }
        }

        //列头单击
        private void ss1_Clk(int col, int row) {
            if (col == 0) {
                ss1_DblClk(col, row);
            }
        }


        //ss1列头双击
        private void ss1_DblClk(int col, int row) {
            string plate_no;
            int iCnt;
            int iPlate_cnt;
            double iPlate_wgt;

            int tRow;

            iPlate_cnt = 0;
            iPlate_wgt = 0;

            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            if (ss1.ActiveSheet.RowHeader.Cells[row, 0].Text == "增加") {
                plate_no = ss1.ActiveSheet.Cells[row, 0].Text;
                for (iCnt = ss2.ActiveSheet.RowCount; iCnt >= 1; iCnt += -1) {
                    if (ss2.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text == "增加") {
                        if (ss2.ActiveSheet.Cells[iCnt - 1, 1].Text == plate_no) {
                            ss2.ActiveSheet.Cells[iCnt - 1, 1].Text = "";
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iCnt - 1, iCnt - 1, Color.Black, Color.White);
                            ss2.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text = "";
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                }
                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "";

                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, Color.White);


                for (iCnt = 1; iCnt <= ss1.ActiveSheet.RowCount; iCnt += 1) {
                    if (ss1.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text != "") {
                        iPlate_cnt = iPlate_cnt + 1;
                        iPlate_wgt = iPlate_wgt + Convert.ToDouble(ss1.ActiveSheet.Cells[iCnt - 1, 6].Text);
                    }
                }

                TXT_CNT.Text = iPlate_cnt.ToString();
                TXT_WGT.Text = iPlate_wgt.ToString();
                return;
            }

            plate_no = ss1.ActiveSheet.Cells[row, 0].Text;

            if (ss2.ActiveSheet.RowCount <= 0) {
                return;
            }

            ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "增加";

            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, ColorTranslator.FromHtml("#FFC0FF"));


            for (iCnt = 1; iCnt <= ss1.ActiveSheet.RowCount; iCnt += 1) {
                if (ss1.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text != "") {
                    iPlate_cnt = iPlate_cnt + 1;
                    iPlate_wgt = iPlate_wgt + Convert.ToDouble(ss1.ActiveSheet.Cells[iCnt - 1, 6].Text);
                }
            }

            TXT_CNT.Text = iPlate_cnt.ToString();
            TXT_WGT.Text = iPlate_wgt.ToString();

            tRow = ss2.ActiveSheet.ActiveRowIndex;

            if (ss2.ActiveSheet.Cells[tRow, 1].Text.Length == 14) {

                for (iCnt = ss2.ActiveSheet.RowCount; iCnt >= 1; iCnt += -1) {
                    //ss2.Col = 2;
                    //ss2.ROW = iCnt;
                    if (ss2.ActiveSheet.Cells[iCnt - 1, 1].Text == "") {
                        ss2.ActiveSheet.Cells[iCnt - 1, 1].Text = plate_no;
                        ss2.ActiveSheet.RowHeader.Cells[iCnt - 1, 0].Text = "增加";
                        ss2.ActiveSheet.Cells[iCnt - 1, 10].Text = GeneralCommon.sUserID;
                        return;
                    }
                }

            } else {

                if (ss2.ActiveSheet.Cells[tRow, 1].Text == "") {
                    ss2.ActiveSheet.Cells[tRow, 1].Text = plate_no;
                    ss2.ActiveSheet.RowHeader.Cells[tRow, 0].Text = "增加";
                    ss2.ActiveSheet.Cells[tRow, 10].Text = GeneralCommon.sUserID;
                    if (tRow >= 0) {
                        ss2.ActiveSheet.SetActiveCell(tRow - 1, 0);
                    }
                    return;
                }
            }
        }

        public override bool Form_Cls() {
            TXT_CNT.Text = "";
            TXT_WGT.Text = "";
            base.Form_Cls();
            text_cur_inv_code.Text = "ZB";
            text_cur_inv.Text = "中板";
            CBO_PROD_CD.SelectedIndex = 0;
            SDT_PROD_DATE_GotFocus();
            return true;
        }

        public override void Form_Ref() {
            int iRow;
            int sRow = 0;
            int tRow;

            int iCnt = 0;
            double iWGT = 0;

            //if (SpreadCommon.Gf_Sp_ProceExist(ss2, true)) return;

            p_Ref(1, 1, true, false);

            if (txt_t_addr.Text.Length > 2) {
                p_Ref(1, 2, true, false);
            }

            TXT_CNT.Text = "";
            TXT_WGT.Text = "";

            if (ss2.ActiveSheet.RowCount <= 0) return;

            for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++) {
                //ss2.ROW = iRow;
                //ss2.Col = 2;
                if (ss2.ActiveSheet.Cells[iRow - 1, 1].Text != "") {
                    iCnt = iCnt + 1;
                    //ss2.Col = 9;
                    iWGT = iWGT + Convert.ToDouble(ss2.ActiveSheet.Cells[iRow - 1, 8].Text);
                }
                sRow = ss2.ActiveSheet.RowCount - 1;
            }

            TXT_LOC_CNT.Text = iCnt.ToString();
            TXT_LOC_WGT.Text = iWGT.ToString();


            for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++) {
                //ss2.ROW = iRow;
                //ss2.Col = 2;
                if (ss2.ActiveSheet.Cells[iRow - 1, 1].Text != "") {
                    sRow = iRow - 1;
                    break;
                }
                sRow = ss2.ActiveSheet.RowCount - 1;
            }

            tRow = sRow + 15;
            if (tRow > ss2.ActiveSheet.RowCount - 1) {
                tRow = ss2.ActiveSheet.RowCount - 1;
            }

            ss2.ActiveSheet.SetActiveCell(tRow, 0);
            //将光标移动到选择的行
            ss2.ShowActiveCell(FarPoint.Win.Spread.VerticalPosition.Bottom, FarPoint.Win.Spread.HorizontalPosition.Nearest);

            return;
        }

        public override void Form_Pro() {
            int iRow;
            int sRow = 0;
            int tRow;

            if (p_Pro(1, 2, true, false)) {
                p_Ref(1, 1, true, false);
            }

            if (ss2.ActiveSheet.RowCount <= 0) return;
            for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++) {
                //ss2.ROW = iRow;
                //ss2.Col = 2;
                if (ss2.ActiveSheet.Cells[iRow - 1, 1].Text != "") {
                    sRow = iRow;
                    break;
                }
                sRow = ss2.ActiveSheet.RowCount - 1;
            }

            tRow = sRow + 15;
            if (tRow > ss2.ActiveSheet.RowCount - 1) {
                tRow = ss2.ActiveSheet.RowCount - 1;
            }

            ss2.ActiveSheet.SetActiveCell(tRow, 0);
            ss2.ShowActiveCell(FarPoint.Win.Spread.VerticalPosition.Bottom, FarPoint.Win.Spread.HorizontalPosition.Nearest);

            TXT_CNT.Text = "";
            TXT_WGT.Text = "";
        }

        public override void Form_Del() {
            if (ss2.ActiveSheet.RowCount > 0) { base.p_del(1, 2, true); }
            return;
        }

        private void ss2_DblClk(int col, int row) {
            if (ss2.ActiveSheet.RowCount <= 0) return;

            if (col == 1) {
                //ss2.ROW = ROW + 1;
                //ss2.Col = 2;
                if (ss2.ActiveSheet.Cells[row + 1, col].Text == "" & row != ss2.ActiveSheet.RowCount - 1)
                    return;
                //ss2.ROW = ROW;
                if (ss2.ActiveSheet.Cells[row, col].Text == "") {
                    //ss2.Col = 0;
                    ss2.ActiveSheet.RowHeader.Cells[row, 0].Text = "增加";
                } else {
                    //ss2.Col = 0;
                    ss2.ActiveSheet.RowHeader.Cells[row, 0].Text = "修改";
                }
            }
        }

        public override void Spread_Can() {
            int ss1Row;
            int ss2Row;
            int iCnt;
            int iCnt1;
            string iPlate_no;


            //ss2.Col = 0;
            //ss2.ROW = ss2.ActiveSheet.ActiveRowIndex;
            if (ss2.ActiveSheet.RowHeader.Cells[ss2.ActiveSheet.ActiveRowIndex, 0].Text == "增加") {
                for (ss2Row = ss2.ActiveSheet.ActiveRowIndex; ss2Row >= 0; ss2Row += -1) {
                    //ss2.Col = 2;
                    //ss2.ROW = ss2Row;
                    if (ss2.ActiveSheet.Cells[ss2Row, 1].Text.Length == 14) {
                        iPlate_no = ss2.ActiveSheet.Cells[ss2Row, 1].Text;
                        ss2.ActiveSheet.Cells[ss2Row, 1].Text = "";
                        //ss2.Col = 0;
                        ss2.ActiveSheet.RowHeader.Cells[ss2Row, 0].Text = "";
                        for (ss1Row = 1; ss1Row <= ss1.ActiveSheet.RowCount; ss1Row++) {
                            //ss1.ROW = ss1Row;
                            //ss1.Col = 0;
                            if (ss1.ActiveSheet.RowHeader.Cells[ss1Row - 1, 0].Text == "增加") {
                                //ss1.Col = 1;
                                if (ss1.ActiveSheet.Cells[ss1Row - 1, 0].Text == iPlate_no) {
                                    //ss1.Col = 0;
                                    ss1.ActiveSheet.RowHeader.Cells[ss1Row - 1, 0].Text = "";


                                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, ss1Row - 1, ss1Row - 1, Color.Black, ColorTranslator.FromHtml("#FFFFFF"));

                                    //ss1.Col = 7;
                                    TXT_CNT.Text = (Convert.ToInt32(TXT_CNT.Text) - 1).ToString();
                                    TXT_WGT.Text = (Convert.ToDouble(TXT_WGT.Text) - Convert.ToDouble(ss1.ActiveSheet.Cells[ss1Row - 1, 6].Text)).ToString();
                                    if (TXT_CNT.Text == "0") {
                                        TXT_CNT.Text = "";
                                        TXT_WGT.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public string Gf_CarInfFind(string Car_no, string Car_knd, string nameType)
        {
            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "FAIL";
            string sQuery;
            string Gf_CarInfFind = "";
            switch (nameType)
            {
                case "1":
                    //最大装载量
                    sQuery = "SELECT H.CAR_WGT_MAX    FROM HP_CAR_IMF H WHERE H.CAR_NO = '" + Car_no + "' AND H.CAR_KND = '" + Car_knd + "' ";
                    break;
                case "2":
                    //装载量(适量)
                    sQuery = "SELECT H.CAR_WGT_AVE    FROM HP_CAR_IMF H WHERE H.CAR_NO = '" + Car_no + "' AND H.CAR_KND = '" + Car_knd + "' ";
                    break;
                default:
                    //可装车长度
                    sQuery = "SELECT H.CAR_LEN        FROM HP_CAR_IMF H WHERE H.CAR_NO = '" + Car_no + "' AND H.CAR_KND = '" + Car_knd + "' ";
                    break;
            }
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
                            Gf_CarInfFind = "";
                        }
                        else
                        {
                            Gf_CarInfFind = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                return Gf_CarInfFind;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }




        # region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk) {
            sDTChk = "M";
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M") {
                iDateCheck = DateCheck;
            } else {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000) {
                return false;
            }

            switch (iDateCheck.Length) {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 10));
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 16));
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 19));
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 8)) {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE) {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                if (WKDATE != "") {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            Shift_HH = "";
                        } else {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800) {
                    return "1";
                } else if (Convert.ToInt32(Shift_HH) < 1600) {
                    return "2";
                } else {
                    return "3";
                }
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate) {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            group = "";
                        } else {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag) {

            if (DTCheck == "D") {
                DTCheck = "D";
            } else {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck) {
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

            if (DTFlag == "C") {
                if (DTCheck == "T") {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        if (AdoRs.Fields[0].Value.ToString() == "") {
                            time = "";
                        } else {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                } else {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e) {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++) {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e) {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++) {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            ss1_Clk(e.Column, e.Row);
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

        private void text_cur_inv_code_TextChanged(object sender, EventArgs e)
        {
            if (text_cur_inv_code.Text == "ZB")
            {
                txt_f_addr.sKey = "F0037";
                txt_t_addr.sKey = "F0037";
            }
            else if (text_cur_inv_code.Text == "WG")
            {
                txt_f_addr.sKey = "F0036";
                txt_t_addr.sKey = "F0036";
            }
            else if (text_cur_inv_code.Text == "52")
            {
                txt_f_addr.sKey = "F0038";
                txt_t_addr.sKey = "F0038";
            }
            else
            {
                txt_f_addr.sKey = "X";
                txt_t_addr.sKey = "X";
            }
        }

        private void txt_t_addr_TextChanged(object sender, EventArgs e)
        {
            if (txt_t_addr.Text.Length == txt_t_addr.MaxLength)
            {
                TXT_MAX_WGT.Text = Gf_CarInfFind(txt_t_addr.Text, "R", "1");
            }
            else
            {
                TXT_MAX_WGT.Text = "";
            }
        }

    }

}
