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
//-- Sub_System Name   统计分析管理
//-- Program Name      加热炉实绩查询界面
//-- Program ID        CGT2000C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.11.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.11.01       韩超        中板轧钢作业
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKP1010C : CommonClass.FORMBASE
    {
        public CKP1010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
       // const int SS1_SLAB_NO = 0;
        


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_DATE, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("类型", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("计划产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("原料量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("剪切产量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("1#", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("2#", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("合计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("轧制废", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("在线", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("切割", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("待判", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("合格率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("单定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("双定尺", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("设定", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("综合", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("一次合格率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("热装量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("热送量", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("负公差", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("实设成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23

            iheadrow = 0;
            p_spanSpread("剪切块数", 6, 8, iscseq, iheadrow, 1);
            p_spanSpread("废次品", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("成材率", 15, 18, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 1;
            iscseq = 2;
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("当日", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("累计", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("厚板生产", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("厚板生产", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("吨位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("吨位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("块数（厚板）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("吨位（厚板）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("块数（在线）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("吨位（在线）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("块数（厚板）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("吨位（厚板）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("块数（在线）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("吨位（在线）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33

            iheadrow = 0;
            p_spanSpread("日历作业率", 0, 1, iscseq, iheadrow, 1);
            p_spanSpread("有效作业率", 2, 3, iscseq, iheadrow, 1);
            p_spanSpread("机时产量", 4, 5, iscseq, iheadrow, 1);
            p_spanSpread("本部煤气消耗", 6, 7, iscseq, iheadrow, 1);
            p_spanSpread("港池煤气消耗", 8, 9, iscseq, iheadrow, 1);
            p_spanSpread("电消耗", 10, 11, iscseq, iheadrow, 1);
            p_spanSpread("水消耗", 12, 13, iscseq, iheadrow, 1);
            p_spanSpread("蒸汽回收量", 14, 15, iscseq, iheadrow, 1);
            p_spanSpread("管道氧气", 16, 17, iscseq, iheadrow, 1);
            p_spanSpread("氮气", 18, 19, iscseq, iheadrow, 1);
            //p_spanSpread("厚板生产", 20,21, iscseq, iheadrow, 1);
            p_spanSpread("下线", 22, 23, iscseq, iheadrow, 1);
            p_spanSpread("已完成", 24, 25, iscseq, iheadrow, 1);
            p_spanSpread("待处理（本月）", 26, 29, iscseq, iheadrow, 1);
            p_spanSpread("订单（累计）", 30, 33, iscseq, iheadrow, 1);

            
        }

        private void CKP1010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKP1010NC";
            Form_Define();
            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);

            ss1.ActiveSheet.RowCount = 10;
            ss1.ActiveSheet.RowHeader.ColumnCount = 2;//设置两行
            ss1.ActiveSheet.RowHeader.Cells[0, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss1.ActiveSheet.RowHeader.Cells[0, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[1, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[2, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[2, 0].Text = "乙";
            ss1.ActiveSheet.RowHeader.Cells[2, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[3, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[4, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[4, 0].Text = "丙";
            ss1.ActiveSheet.RowHeader.Cells[4, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[5, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[6, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[6, 0].Text = "丁";
            ss1.ActiveSheet.RowHeader.Cells[6, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[7, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[8, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[8, 0].Text = "全厂";
            ss1.ActiveSheet.RowHeader.Cells[8, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[9, 1].Text = "累计";

            ss2.ActiveSheet.RowCount = 6;
            ss2.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss2.ActiveSheet.RowHeader.Cells[1, 0].Text = "乙";
            ss2.ActiveSheet.RowHeader.Cells[2, 0].Text = "丙";
            ss2.ActiveSheet.RowHeader.Cells[3, 0].Text = "丁";
            ss2.ActiveSheet.RowHeader.Cells[4, 0].Text = "全厂";

            ss2.ActiveSheet.ColumnHeader.Cells[0, 20].ColumnSpan = 2;

            ss2.ActiveSheet.Cells[0, 20].Text = "切割";
            ss2.ActiveSheet.Cells[0, 20].RowSpan = 2;
            ss2.ActiveSheet.Cells[2, 20].Text = "探伤";
            ss2.ActiveSheet.Cells[2, 20].RowSpan = 2;
            ss2.ActiveSheet.Cells[4, 20].Text = "热处理";
            ss2.ActiveSheet.Cells[4, 20].RowSpan = 2;
            ss2.ActiveSheet.Cells[0, 21].Text = "当日";
            ss2.ActiveSheet.Cells[1, 21].Text = "累计";
            ss2.ActiveSheet.Cells[2, 21].Text = "当日";
            ss2.ActiveSheet.Cells[3, 21].Text = "累计";
            ss2.ActiveSheet.Cells[4, 21].Text = "当日";
            ss2.ActiveSheet.Cells[5, 21].Text = "累计";
        }

        public override void Form_Pro()
        {
           // p_pro(1, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            if (p_Ref(1, 1, true, true))
            {
                ss1_ref();
                Gf_Sp_Display2(GeneralCommon.M_CN1, ss2, MasterCommon.Gf_Ms_MakeQuery((string)(Sc2["P-R"]), "R", (Collection)Mc1["pControl"]), (Collection)Sc2["pColumn"], false);
                SearchStlGrdData();
            }
        }

        public void ss1_ref()
        {
            string[,] ss1Row = new string[8, 24];
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                if (i == 8)
                {
                    break;
                }
                for (int k = 0; k < ss1.ActiveSheet.ColumnCount; k++)
                {
                    ss1Row[i, k] = ss1.ActiveSheet.Cells[i, k].Text;

                }

            }

            for (int i = 0; i < ss1Row.GetLength(0); i++)
            {
                for (int k = 0; k < ss1Row.GetLength(1); k++)
                {
                    try
                    {
                        if (convertX(ss1Row[i, k]) == 0)
                        {
                            ss1Row[i, k] = "";
                        }
                    }
                    catch
                    {
                    }
                    if (ss1Row[i, 0] == "A0")
                    {
                        ss1.ActiveSheet.Cells[0, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "B0")
                    {
                        ss1.ActiveSheet.Cells[2, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "C0")
                    {
                        ss1.ActiveSheet.Cells[4, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "D0")
                    {
                        ss1.ActiveSheet.Cells[6, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "A1")
                    {
                        ss1.ActiveSheet.Cells[1, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "B1")
                    {
                        ss1.ActiveSheet.Cells[3, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "C1")
                    {
                        ss1.ActiveSheet.Cells[5, k].Text = ss1Row[i, k];
                    }
                    if (ss1Row[i, 0] == "D1")
                    {
                        ss1.ActiveSheet.Cells[7, k].Text = ss1Row[i, k];
                    }
                }
            }
            ss1.ActiveSheet.RowHeader.Cells[0, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[0, 0].Text = "甲";
            ss1.ActiveSheet.RowHeader.Cells[0, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[1, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[2, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[2, 0].Text = "乙";
            ss1.ActiveSheet.RowHeader.Cells[2, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[3, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[4, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[4, 0].Text = "丙";
            ss1.ActiveSheet.RowHeader.Cells[4, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[5, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[6, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[6, 0].Text = "丁";
            ss1.ActiveSheet.RowHeader.Cells[6, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[7, 1].Text = "累计";
            ss1.ActiveSheet.RowHeader.Cells[8, 0].RowSpan = 2;
            ss1.ActiveSheet.RowHeader.Cells[8, 0].Text = "全厂";
            ss1.ActiveSheet.RowHeader.Cells[8, 1].Text = "当日";
            ss1.ActiveSheet.RowHeader.Cells[9, 1].Text = "累计";
        }

        public bool Gf_Sp_Display2(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
        {
            bool returnValue = false;

            int iCount;
            int iRowCount;
            int iColcount;
            object[,] ArrayRecords;
            ADODB.Recordset AdoRs;
            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return false;
                }
            }

            AdoRs = new ADODB.Recordset();
            try
            {
                returnValue = true;

                //if (oSpread.ActiveSheet.RowCount > 0)
                //{
                //    //
                //    //'Hux,修改。
                //    //'解决:Spread有两条数据时，点击列头排序后，再点击Spread插入，Spread行清除时报错。
                //    oSpread.ActiveSheet.AutoSortColumn(0);
                //    oSpread.ActiveSheet.RowCount = 0;
                //}

                //FarPoint.Win.Spread.FpSpread with_1 = oSpread;

                iCount = 0;

                Cursor.Current = Cursors.WaitCursor;
                /////////20130606begin解决保存失败后，第一次查询提示算数运算符溢出的问题
                AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                AdoRs.CursorType = ADODB.CursorTypeEnum.adOpenStatic;
                //AdoRs.CursorType = 
                //AdoRs.CursorLocation = ADODB.CursorLocationEnum.adUseServer;


                //AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, 1);
                AdoRs.Open(sQuery, Conn);
                /////////20130606end


                if (AdoRs.BOF || AdoRs.EOF)
                {

                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料..!!!", "I", "");
                    }

                    returnValue = false;
                    AdoRs.Close();
                    AdoRs = null;

                    Cursor.Current = Cursors.Default;
                    return returnValue;

                }

                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;

                //此处进行表单数据录入

                int ROW = 0;
                if (ArrayRecords.GetLength(0) != 0)
                {
                    for (iRowCount = 0; iRowCount < ArrayRecords.GetLength(0); iRowCount++)
                    {
                        switch (substr(ArrayRecords[iRowCount, 0].ToString(), 0, 1))
                        {
                            case "A":
                                ROW = 0;
                                break;
                            case "B":
                                ROW = 1;
                                break;
                            case "C":
                                ROW = 2;
                                break;
                            case "D":
                                ROW = 3;
                                break;
                            case "T":
                                ROW = 4;
                                break;
                        }

                        //            .ROW = iRowCount + 1
                        int Col = 0;
                        //10 --> 9 by guhf 2011.5.12 删除压力空气
                        for (iColcount = 1; iColcount <= 10; iColcount++)
                        {

                            if (substr(ArrayRecords[iRowCount, 0].ToString(), 1, 1) == "0")
                            {
                                Col = (iColcount - 1) * 2;    //偶数列 
                            }
                            else if (substr(ArrayRecords[iRowCount, 0].ToString(), 1, 1) == "1")
                            {
                                Col = (iColcount - 1) * 2 + 1;    //奇数列
                            }

                            if (ArrayRecords[iRowCount, iColcount].ToString() == "" || ArrayRecords[iRowCount, iColcount].ToString() == "0")
                            {
                                ss2.ActiveSheet.Cells[ROW, Col].Text = "";
                            }
                            else
                            {
                                ss2.ActiveSheet.Cells[ROW, Col].Text = ArrayRecords[iRowCount, iColcount].ToString();
                            }

                        }

                        if (ArrayRecords[iRowCount, 0].ToString() == "A0")
                        {
                            //29 --> 46 by guhf 2011.5.12
                            if (ArrayRecords[iRowCount, 47].ToString() == "" || convertX(ArrayRecords[iRowCount, 47].ToString()) == 0)
                            {
                                ss3.ActiveSheet.Cells[27, 19].Text = "";
                            }
                            else
                            {
                                ss3.ActiveSheet.Cells[27, 19].Text = ArrayRecords[iRowCount, 47].ToString().Trim();
                                //29 --> 46 by guhf 2011.5.12
                            }
                        }
                        else if (ArrayRecords[iRowCount, 0].ToString() == "B0")
                        {
                            //29 --> 46 by guhf 2011.5.12
                            if (ArrayRecords[iRowCount, 47].ToString() == "" | convertX(ArrayRecords[iRowCount, 47].ToString()) == 0)
                            {
                                ss3.ActiveSheet.Cells[27, 20].Text = "";
                            }
                            else
                            {
                                ss3.ActiveSheet.Cells[27, 20].Text = ArrayRecords[iRowCount, 47].ToString().Trim();
                                //29 --> 46 by guhf 2011.5.12
                            }
                        }
                        else if (ArrayRecords[iRowCount, 0].ToString() == "C0")
                        {
                            //29 --> 46 by guhf 2011.5.12
                            if (ArrayRecords[iRowCount, 47].ToString() == "" | convertX(ArrayRecords[iRowCount, 47].ToString()) == 0)
                            {
                                ss3.ActiveSheet.Cells[27, 21].Text = "";
                            }
                            else
                            {
                                ss3.ActiveSheet.Cells[27, 21].Text = ArrayRecords[iRowCount, 47].ToString().Trim();
                                //29 --> 46 by guhf 2011.5.12
                            }
                        }
                        else if (ArrayRecords[iRowCount, 0].ToString() == "D0")
                        {
                            //29 --> 46 by guhf 2011.5.12
                            if (ArrayRecords[iRowCount, 47].ToString() == "" | convertX(ArrayRecords[iRowCount, 47].ToString()) == 0)
                            {
                                ss3.ActiveSheet.Cells[27, 22].Text = "";
                            }
                            else
                            {
                                ss3.ActiveSheet.Cells[27, 22].Text = ArrayRecords[iRowCount, 47].ToString().Trim();
                                //29 --> 46 by guhf 2011.5.12
                            }
                        }

                        if (ArrayRecords[iRowCount, 0].ToString() == "T0")
                        {
                            // 30 --> 47 ,35-->52 by guhf 2011.5.12
                            for (iCount = 48; iCount <= 53; iCount++)
                            {
                                //6 --> 23 by guhf 2011.5.12
                                if (ArrayRecords[iRowCount, iCount].ToString() == "" || convertX(ArrayRecords[iRowCount, iCount].ToString()) == 0)
                                {
                                    ss3.ActiveSheet.Cells[27, iCount - 24].Text = "";
                                }
                                else
                                {
                                    ss3.ActiveSheet.Cells[27, iCount - 24].Text = ArrayRecords[iRowCount, iCount].ToString().Trim();
                                }
                            }
                        }

                        //由于后台SQL不是按照查询顺序写的，所以这段代码的主要含义是将不同的SQL值按照顺序排列到表单之中，需要到后台一列列的去读取顺序并在前台做相应的顺序处理。20161222 ADD HAN
                        if (substr(ArrayRecords[iRowCount, 0].ToString(), 0, 1) == "T")
                        {
                            //11-->10 ,28-->45 by guhf 2011.5.12
                            for (iCount = 11; iCount <= 46; iCount++)
                            {
                                if (ArrayRecords[iRowCount, 0].ToString() == "T0")
                                {
                                    if (iCount <= 18)
                                    {
                                        ROW = 0;
                                        Col = iCount + 11;
                                        //第一行23列开始共8列
                                        //总累计待切割量
                                    }
                                    else if (iCount >= 19 & iCount < 23)
                                    {
                                        ROW = 1;
                                        Col = iCount + 11;
                                        //17-->22 ,23-->30 by guhf
                                    }
                                    else if (iCount >= 23 & iCount < 31)
                                    {
                                        ROW = 2;
                                        Col = iCount - 1;
                                        //+6 --> -1 by guhf 2011.5.12
                                        //add by guhf 2011.5.12 增加总累计待探伤量
                                    }
                                    else if (iCount >= 31 & iCount < 35)
                                    {
                                        ROW = 3;
                                        //add by guhf 2011.5.12
                                        Col = iCount - 1;
                                        //add by guhf 2011.5.12
                                        //'MODIFIED BY GUOLI AT 20100318180800 FOR 避免SS2最后一列不显示数据,原来没有=
                                    }
                                    else if (iCount >= 35 & iCount <= 42)
                                    {
                                        //23-->34, 28-->41 by guhf
                                        ROW = 4;
                                        Col = iCount - 13;
                                        // 又减了12
                                        //add by guhf 2011.5.12 增加总累计待切割两
                                    }
                                    else if (iCount >= 43 & iCount < 47)
                                    {
                                        ROW = 5;
                                        //add by guhf 2011.5.12
                                        Col = iCount - 13;
                                        //add by guhf 2011.5.12
                                    }
                                    //
                                }
                                else if (ArrayRecords[iRowCount, 0].ToString() == "T1")
                                {
                                    //17-->18  by guhf 2011.5.12
                                    if (iCount <= 18)
                                    {
                                        ROW = 1;
                                        Col = iCount + 11;
                                        //12--> 11 by guhf 2011.5.12
                                        //17-->22 ,23-->30 by guhf
                                    }
                                    else if (iCount >= 23 & iCount < 31)
                                    {
                                        ROW = 3;
                                        Col = iCount - 1;
                                        //+6 --> -1 by guhf 2011.5.12
                                        //'MODIFIED BY GUOLI AT 20100318180800 FOR 避免SS2最后一列不显示数据,原来没有=
                                    }
                                    else if (iCount >= 35 & iCount <= 42)
                                    {
                                        //23-->34, 28-->41 by guhf
                                        ROW = 5;
                                        Col = iCount - 13;
                                        // add - 13 by guhf
                                        //                           If iCount < 17 Then
                                        //                              .ROW = 2
                                        //                              .Col = iCount + 12
                                        //                           ElseIf iCount >= 17 And iCount < 23 Then
                                        //                              .ROW = 4
                                        //                              .Col = iCount + 6
                                        //                           ElseIf iCount >= 23 And iCount <= 28 Then  ''MODIFIED BY GUOLI AT 20100318180800 FOR 避免SS2最后一列不显示数据,原来没有=
                                        //                              .ROW = 6
                                        //                              .Col = iCount
                                    }
                                }
                                if (ArrayRecords[iRowCount, iColcount].ToString() == "" || convertX(ArrayRecords[iRowCount, iCount].ToString()) == 0)
                                {
                                    ss2.ActiveSheet.Cells[ROW, Col].Text = "";
                                }
                                else
                                {
                                    ss2.ActiveSheet.Cells[ROW, Col].Text = ArrayRecords[iRowCount, iCount].ToString();
                                }
                            }
                        }

	}

}
                Cursor.Current = Cursors.Default;
                ArrayRecords = null;

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Sp_Display Error : " + ex.Message), "", "");
                Cursor.Current = Cursors.Default;
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }
            }

            return returnValue;
        }

        private void SearchStlGrdData()
        {
            string sQuery;
            object[,] ArrayRecords;

            sQuery = "SELECT 1 FROM DUAL";

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return;

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];

                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;

                //判断是不是需要关闭连接对象，有时候该方法是在查询过程中调用，关闭对象会导致框架查询报错 韩超

                //GeneralCommon.M_CN1.Close();
            }
            catch (Exception ex)
            {
                // if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs.Close();
                AdoRs = null;
            }
        }




        # region 公共方法

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
                try
                {
                    return Convert.ToDouble(value);
                }
                catch
                {
                    return 1;
                }
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
            }
            return 0;
        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion
    }
}
