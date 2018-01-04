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
//-- Program Name      订单工序作业时间查询_CGT2102C
//-- Program ID        CGT2102C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.01.04
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.01.04       韩超        订单工序作业时间查询_CGT2102C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGT2110C : CommonClass.FORMBASE
    {
        public CGT2110C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();

        const int SS1_GROUP_CD = 0;
        const int SS1_EMP_CD = 1;
        const int SS1_STAND = 2;
        const int SS1_MILL_COUNT = 3;
        const int SS1_MILL_PASS_COUNT = 4;
        const int SS1_MILL_PASS_RATE = 5;
        const int SS1_MILL_RANKING = 6;

        const int SS2_GROUP_CD = 0;
        const int SS2_EMP_CD = 1;
        const int SS2_STAND = 2;
        const int SS2_MILL_COUNT = 3;
        const int SS2_MILL_PASS_COUNT = 4;
        const int SS2_MILL_PASS_RATE = 5;
        const int SS2_MILL_RANKING = 6;



        const int SS3_GROUP_CD = 0;
        const int SS3_EMP_CD = 1;
        const int SS3_MILL_COUNT_Q345 = 2;
        const int SS3_MILL_PASS_COUNT_Q345 = 3;
        const int SS3_MILL_PASS_RATE_Q345 = 4;
        const int SS3_MILL_RAKING_Q345 = 5;
        const int SS3_MILL_COUNT_Q390 = 6;
        const int SS3_MILL_PASS_COUNT_Q390 = 7;
        const int SS3_MILL_PASS_RATE_Q390 = 8;
        const int SS3_MILL_RAKING_Q390 = 9;
        const int SS3_MILL_COUNT_Q460 = 10;
        const int SS3_MILL_PASS_COUNT_Q460 = 11;
        const int SS3_MILL_PASS_RATE_Q460 = 12;
        const int SS3_MILL_RAKING_Q460 = 13;
        const int SS3_MILL_COUNT_AD = 14;
        const int SS3_MILL_PASS_COUNT_AD = 15;
        const int SS3_MILL_PASS_RATE_AD = 16;
        const int SS3_MILL_RAKING_AD = 17;
        const int SS3_MILL_COUNT_R = 18;
        const int SS3_MILL_PASS_COUNT_R = 19;
        const int SS3_MILL_PASS_RATE_R = 20;
        const int SS3_MILL_RAKING_R = 21;
        const int SS3_MILL_COUNT_X = 22;
        const int SS3_MILL_PASS_COUNT_X = 23;
        const int SS3_MILL_PASS_RATE_X = 24;
        const int SS3_MILL_RAKING_X = 25;
        const int SS3_MILL_COUNT_Q235 = 26;
        const int SS3_MILL_PASS_COUNT_Q235 = 27;
        const int SS3_MILL_PASS_RATE_Q235 = 28;
        const int SS3_MILL_RAKING_Q235 = 29;
        const int SS3_MILL_COUNT_A36 = 30;
        const int SS3_MILL_PASS_COUNT_A36 = 31;
        const int SS3_MILL_PASS_RATE_A36 = 32;
        const int SS3_MILL_RAKING_A36 = 33;

        const int SS4_GROUP_CD = 0;
        const int SS4_EMP_CD = 1;
        const int SS4_MILL_COUNT_Q345 = 2;
        const int SS4_MILL_PASS_COUNT_Q345 = 3;
        const int SS4_MILL_PASS_RATE_Q345 = 4;
        const int SS4_MILL_RAKING_Q345 = 5;
        const int SS4_MILL_COUNT_Q390 = 6;
        const int SS4_MILL_PASS_COUNT_Q390 = 7;
        const int SS4_MILL_PASS_RATE_Q390 = 8;
        const int SS4_MILL_RAKING_Q390 = 9;
        const int SS4_MILL_COUNT_Q460 = 10;
        const int SS4_MILL_PASS_COUNT_Q460 = 11;
        const int SS4_MILL_PASS_RATE_Q460 = 12;
        const int SS4_MILL_RAKING_Q460 = 13;
        const int SS4_MILL_COUNT_AD = 14;
        const int SS4_MILL_PASS_COUNT_AD = 15;
        const int SS4_MILL_PASS_RATE_AD = 16;
        const int SS4_MILL_RAKING_AD = 17;
        const int SS4_MILL_COUNT_R = 18;
        const int SS4_MILL_PASS_COUNT_R = 19;
        const int SS4_MILL_PASS_RATE_R = 20;
        const int SS4_MILL_RAKING_R = 21;
        const int SS4_MILL_COUNT_X = 22;
        const int SS4_MILL_PASS_COUNT_X = 23;
        const int SS4_MILL_PASS_RATE_X = 24;
        const int SS4_MILL_RAKING_X = 25;
        const int SS4_MILL_COUNT_Q235 = 26;
        const int SS4_MILL_PASS_COUNT_Q235 = 27;
        const int SS4_MILL_PASS_RATE_Q235 = 28;
        const int SS4_MILL_RAKING_Q235 = 29;
        const int SS4_MILL_COUNT_A36 = 30;
        const int SS4_MILL_PASS_COUNT_A36 = 31;
        const int SS4_MILL_PASS_RATE_A36 = 32;
        const int SS4_MILL_RAKING_A36 = 33;

       


        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_DATE, "P", "", "", "", imcseq, "");
         

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("精轧机压下工", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("达标块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("达标率", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("排名", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//6

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("精轧机压下工", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("达标块数", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("达标率", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("排名", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//6

            p_ScIni(ss3, Sc3, 0, false, false);
            iheadrow = 1;
            iscseq = 3;

            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33

            iheadrow = 0;
            p_spanSpread("Q345A-Q345D", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("Q390-Q420", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("Q460以上", 10, 13, iscseq, iheadrow, 1);
            p_spanSpread("普通船板（A-D)", 14, 17, iscseq, iheadrow, 1);
            p_spanSpread("管线", 18, 21, iscseq, iheadrow, 1);
            p_spanSpread("容器板（Q245R-345R、112MnNiVR）", 22, 25, iscseq, iheadrow, 1);
            p_spanSpread("普板（Q235A-Q235D)", 26, 29, iscseq, iheadrow, 1);
            p_spanSpread("容器板（Q245R-345R、112MnNiVR）", 30, 33, iscseq, iheadrow, 1);


            p_ScIni(ss4, Sc4, 0, false, false);
            iheadrow = 1;
            iscseq = 4;

            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("轧制块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("达标块数", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("达标率", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("排名", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//33

            iheadrow = 0;
            p_spanSpread("Q345A-Q345D", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("Q390-Q420", 6, 9, iscseq, iheadrow, 1);
            p_spanSpread("Q460以上", 10, 13, iscseq, iheadrow, 1);
            p_spanSpread("普通船板（A-D)", 14, 17, iscseq, iheadrow, 1);
            p_spanSpread("管线", 18, 21, iscseq, iheadrow, 1);
            p_spanSpread("容器板（Q245R-345R、112MnNiVR）", 22, 25, iscseq, iheadrow, 1);
            p_spanSpread("普板（Q235A-Q235D)", 26, 29, iscseq, iheadrow, 1);
            p_spanSpread("容器板（Q245R-345R、112MnNiVR）", 30, 33, iscseq, iheadrow, 1);
          
          

           // iheadrow = 0;

           

        }

        private void CGT2102C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGT2110NC";
            Form_Define();
        }

        public override void Form_Pro()
        {
            
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            

            p_Ref(1, 1, false, false);
            p_Ref(1, 2, false, false);
            //p_Ref(1, 3, false, false);
            //p_Ref(1, 4, false, false);

            ss1_order(ss1);
            ss1_order(ss2);

        }

        public void ss1_order(FpSpread oSpread)
        {
            string GROUP_CD;
            string GROUP_T = "";
            string MILL_STAND;
            string EMP_CD;
            int iCount;
            int iRow;
            int mRow;
            string T_GROUP_CD;
            string T_EMP_CD;
            string T_MILL_STAND;
            double MILL_COUNT = 0;
            double MILL_PASS_COUNT = 0;
            double MILL_COUNT_1 = 0;
            double MILL_PASS_COUNT_1 = 0;
            double MILL_COUNT_2 = 0;
            double MILL_PASS_COUNT_2 = 0;
            double MILL_COUNT_ALL_1 = 0;
            double MILL_PASS_COUNT_ALL_1 = 0;
            double MILL_COUNT_ALL_2 = 0;
            double MILL_PASS_COUNT_ALL_2 = 0;
            double MILL_PASS_RATE = 0;
            double[] EMP1 = new double[100];
            double[] EMP2 = new double[100];
            double[] EMP3 = new double[100];
            double[] EMP4 = new double[100];
            double[] EMP5 = new double[100];
            double[] EMP6 = new double[100];
            double[] EMP7 = new double[100];
            double[] EMP8 = new double[100];
            int i;
            int j;
            double temp1;
            double temp2;
            double temp3;
            double temp4;
            double temp5;
            double temp6;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int n6 = 0;
            int n7 = 0;
            int n8 = 0;
            double STLGRT_WGT_Q345;
            double STLGRT_PASS_WGT_Q345;
            double STLGRT_WGT_Q390;
            double STLGRT_PASS_WGT_Q390;
            double STLGRT_WGT_Q460;
            double STLGRT_PASS_WGT_Q460;
            double STLGRT_WGT_AD;
            double STLGRT_PASS_WGT_AD;
            double STLGRT_WGT_R;
            double STLGRT_PASS_WGT_R;
            double STLGRT_WGT_X;
            double STLGRT_PASS_WGT_X;
            double STLGRT_WGT_Q235;
            double STLGRT_PASS_WGT_Q235;
            double STLGRT_WGT_A36;
            double STLGRT_PASS_WGT_A36;
            double MILL_PASS_RATE_Q345;
            double MILL_PASS_RATE_Q390;
            double MILL_PASS_RATE_Q460;
            double MILL_PASS_RATE_AD;
            double MILL_PASS_RATE_R;
            double MILL_PASS_RATE_X;
            double MILL_PASS_RATE_Q235;
            double MILL_PASS_RATE_A36;

            if (oSpread.ActiveSheet.RowCount <= 0) return;

            T_EMP_CD = "当日";
            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {
                //第一行的时候取出班组用于比较不同的时候添加
                if (iCount == 1)
                {
                    GROUP_CD = oSpread.ActiveSheet.Cells[iCount - 1, 0].Text;
                    GROUP_T = oSpread.ActiveSheet.Cells[iCount - 1, 0].Text;
                }
                else
                {
                    GROUP_CD = oSpread.ActiveSheet.Cells[iCount - 1, 0].Text;
                    if (GROUP_CD != GROUP_T)
                    {
                        GROUP_T = GROUP_CD;
                        iRow = iCount - 1;
                        oSpread.ActiveSheet.Rows.Add(iRow, 1);
                        T_GROUP_CD = oSpread.ActiveSheet.Cells[iRow - 1, SS1_GROUP_CD].Text;//添加了一行，取出上一行班别
                        oSpread.ActiveSheet.Cells[iRow, SS1_GROUP_CD].Text = T_GROUP_CD;
                        oSpread.ActiveSheet.Cells[iRow, SS1_EMP_CD].Text = T_EMP_CD;
                        oSpread.ActiveSheet.Cells[iRow, SS1_STAND].Text = "<23";

                        oSpread.ActiveSheet.Rows.Add(iRow + 1, 1);
                        oSpread.ActiveSheet.Cells[iRow + 1, SS1_GROUP_CD].Text = T_GROUP_CD;
                        oSpread.ActiveSheet.Cells[iRow + 1, SS1_EMP_CD].Text = T_EMP_CD;
                        oSpread.ActiveSheet.Cells[iRow + 1, SS1_STAND].Text = ">=23";

                        iCount = iCount + 2;
                    }
                }
            }


            iRow = oSpread.ActiveSheet.RowCount;

            T_GROUP_CD = oSpread.ActiveSheet.Cells[iRow - 1, SS1_GROUP_CD].Text;

            oSpread.ActiveSheet.Rows.Add(iRow, 1);
            oSpread.ActiveSheet.Cells[iRow, SS1_GROUP_CD].Text = T_GROUP_CD;
            oSpread.ActiveSheet.Cells[iRow, SS1_EMP_CD].Text = T_EMP_CD;
            oSpread.ActiveSheet.Cells[iRow, SS1_STAND].Text = "<23";

            oSpread.ActiveSheet.Rows.Add(iRow + 1, 1);
            oSpread.ActiveSheet.Cells[iRow + 1, SS1_GROUP_CD].Text = T_GROUP_CD;
            oSpread.ActiveSheet.Cells[iRow + 1, SS1_EMP_CD].Text = T_EMP_CD;
            oSpread.ActiveSheet.Cells[iRow + 1, SS1_STAND].Text = ">=23";

            oSpread.ActiveSheet.Rows.Add(iRow + 2, 1);
            oSpread.ActiveSheet.Cells[iRow + 2, SS1_GROUP_CD].Text = "全厂";
            oSpread.ActiveSheet.Cells[iRow + 2, SS1_EMP_CD].Text = "全厂";
            oSpread.ActiveSheet.Cells[iRow + 2, SS1_STAND].Text = "<23";

            oSpread.ActiveSheet.Rows.Add(iRow + 3, 1);
            oSpread.ActiveSheet.Cells[iRow + 3, SS1_GROUP_CD].Text = "全厂";
            oSpread.ActiveSheet.Cells[iRow + 3, SS1_EMP_CD].Text = "全厂";
            oSpread.ActiveSheet.Cells[iRow + 3, SS1_STAND].Text = ">=23";

            //下面代码用于添加当日累计内容
            //执行循环添加列
            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {
                if (iCount == 1)
                {
                    EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                    T_EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                }
                else
                {
                    EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                    T_EMP_CD = oSpread.ActiveSheet.Cells[iCount - 2, SS1_EMP_CD].Text;
                    if (EMP_CD != T_EMP_CD)
                    {
                        GROUP_CD = oSpread.ActiveSheet.Cells[iCount - 2, SS1_GROUP_CD].Text;
                        EMP_CD = oSpread.ActiveSheet.Cells[iCount - 2, SS1_EMP_CD].Text;
                        MILL_STAND = "当日累计";

                        oSpread.ActiveSheet.Rows.Add(iCount - 1, 1);
                        oSpread.ActiveSheet.Cells[iCount - 1, SS1_GROUP_CD].Text = GROUP_CD;
                        oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text = EMP_CD;
                        oSpread.ActiveSheet.Cells[iCount - 1, SS1_STAND].Text = MILL_STAND;

                        iCount = iCount + 1;
                    }
                }
            }

            GROUP_CD = oSpread.ActiveSheet.Cells[oSpread.ActiveSheet.RowCount - 1, SS1_GROUP_CD].Text;
            EMP_CD = oSpread.ActiveSheet.Cells[oSpread.ActiveSheet.RowCount - 1, SS1_EMP_CD].Text;
            MILL_STAND = "当日累计";

            oSpread.ActiveSheet.Rows.Add(oSpread.ActiveSheet.RowCount, 1);
            oSpread.ActiveSheet.Cells[oSpread.ActiveSheet.RowCount - 1, SS1_GROUP_CD].Text = GROUP_CD;
            oSpread.ActiveSheet.Cells[oSpread.ActiveSheet.RowCount - 1, SS1_EMP_CD].Text = EMP_CD;
            oSpread.ActiveSheet.Cells[oSpread.ActiveSheet.RowCount - 1, SS1_STAND].Text = MILL_STAND;

            MILL_COUNT_1 = 0;
            MILL_COUNT_2 = 0;
            MILL_PASS_COUNT_1 = 0;
            MILL_PASS_COUNT_2 = 0;


            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {

                MILL_STAND = oSpread.ActiveSheet.Cells[iCount - 1, SS1_STAND].Text;
                EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                MILL_COUNT = convertI(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text);
                MILL_PASS_COUNT = convertI(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text);

                if (MILL_STAND == "<23" & EMP_CD != "当日" & EMP_CD != "全厂")
                {

                    MILL_COUNT_1 = MILL_COUNT_1 + MILL_COUNT;

                    MILL_PASS_COUNT_1 = MILL_PASS_COUNT_1 + MILL_PASS_COUNT;

                }
                else if (MILL_STAND == ">=23" & EMP_CD != "当日" & EMP_CD != "全厂")
                {

                    MILL_COUNT_2 = MILL_COUNT_2 + MILL_COUNT;

                    MILL_PASS_COUNT_2 = MILL_PASS_COUNT_2 + MILL_PASS_COUNT;

                }
                else if (MILL_STAND == "<23" & EMP_CD == "当日")
                {
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text = MILL_COUNT_1.ToString();
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text = MILL_PASS_COUNT_1.ToString();
                    MILL_COUNT_ALL_1 = MILL_COUNT_ALL_1 + MILL_COUNT_1;
                    MILL_PASS_COUNT_ALL_1 = MILL_PASS_COUNT_ALL_1 + MILL_PASS_COUNT_1;

                    MILL_COUNT_1 = 0;
                    MILL_PASS_COUNT_1 = 0;

                }
                else if (MILL_STAND == ">=23" & EMP_CD == "当日")
                {

                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text = MILL_COUNT_2.ToString();
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text = MILL_PASS_COUNT_2.ToString();
                    MILL_COUNT_ALL_2 = MILL_COUNT_ALL_2 + MILL_COUNT_2;
                    MILL_PASS_COUNT_ALL_2 = MILL_PASS_COUNT_ALL_2 + MILL_PASS_COUNT_2;
                    MILL_COUNT_2 = 0;
                    MILL_PASS_COUNT_2 = 0;

                }
                else if (MILL_STAND == "<23" & EMP_CD == "全厂")
                {

                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text = MILL_COUNT_ALL_1.ToString();
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text = MILL_PASS_COUNT_ALL_1.ToString();

                }
                else if (MILL_STAND == ">=23" & EMP_CD == "全厂")
                {

                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text = MILL_COUNT_ALL_2.ToString();
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text = MILL_PASS_COUNT_ALL_2.ToString();
                }
            }

            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {
                MILL_STAND = oSpread.ActiveSheet.Cells[iCount - 1, SS1_STAND].Text;
                if (MILL_STAND == "当日累计")
                {
                    MILL_COUNT_1 = convertI(oSpread.ActiveSheet.Cells[iCount - 2, SS1_MILL_COUNT].Text);
                    MILL_PASS_COUNT_1 = convertI(oSpread.ActiveSheet.Cells[iCount - 2, SS1_MILL_PASS_COUNT].Text);
                    MILL_COUNT_2 = convertI(oSpread.ActiveSheet.Cells[iCount - 3, SS1_MILL_COUNT].Text);
                    MILL_PASS_COUNT_2 = convertI(oSpread.ActiveSheet.Cells[iCount - 3, SS1_MILL_PASS_COUNT].Text);

                    MILL_COUNT = MILL_COUNT_1 + MILL_COUNT_2;
                    MILL_PASS_COUNT = MILL_PASS_COUNT_1 + MILL_PASS_COUNT_2;

                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text = MILL_COUNT.ToString();
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text = MILL_PASS_COUNT.ToString();
                }
            }

            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {
                MILL_COUNT = convertI(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_COUNT].Text);
                MILL_PASS_COUNT = convertI(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_COUNT].Text);

                if (MILL_COUNT > 0)
                {
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_RATE].Text = (MILL_PASS_COUNT / MILL_COUNT * 100).ToString();
                }
                else
                {
                    oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_RATE].Text = "0";
                }
            }

            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {
                GROUP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_GROUP_CD].Text;
                EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                MILL_STAND = oSpread.ActiveSheet.Cells[iCount - 1, SS1_STAND].Text;
                MILL_PASS_RATE = convertX(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_RATE].Text);

                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == "<23")
                {
                    EMP1[n1] = MILL_PASS_RATE;
                    n1 = n1 + 1;
                }

                //2

                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == ">=23")
                {
                    EMP2[n2] = MILL_PASS_RATE;
                    n2 = n2 + 1;
                }


                //3

                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == "当日累计")
                {
                    EMP3[n3] = MILL_PASS_RATE;
                    n3 = n3 + 1;
                }

                //4

                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == "<23")
                {
                    EMP4[n4] = MILL_PASS_RATE;
                    n4 = n4 + 1;
                }

                //5

                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == ">=23")
                {
                    EMP5[n5] = MILL_PASS_RATE;
                    n5 = n5 + 1;
                }


                //6

                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == "当日累计")
                {
                    EMP6[n6] = MILL_PASS_RATE;
                    n6 = n6 + 1;
                }
            }
            //个人排序

            for (i = 0; i <= n1 - 2; i++)
            {
                for (j = 0; j <= n1 - 2 - i; j++)
                {
                    if (EMP1[j] < EMP1[j + 1])
                    {
                        temp1 = EMP1[j + 1];
                        EMP1[j + 1] = EMP1[j];
                        EMP1[j] = temp1;
                    }
                }
            }

            for (i = 0; i <= n2 - 2; i++)
            {
                for (j = 0; j <= n2 - 2 - i; j++)
                {
                    if (EMP2[j] < EMP2[j + 1])
                    {
                        temp2 = EMP2[j + 1];
                        EMP2[j + 1] = EMP2[j];
                        EMP2[j] = temp2;
                    }
                }
            }

            for (i = 0; i <= n3 - 2; i++)
            {
                for (j = 0; j <= n3 - 2 - i; j++)
                {
                    if (EMP3[j] < EMP3[j + 1])
                    {
                        temp3 = EMP3[j + 1];
                        EMP3[j + 1] = EMP3[j];
                        EMP3[j] = temp3;
                    }
                }
            }

            //当日统计排序
            for (i = 0; i <= n6 - 2; i++)
            {
                for (j = 0; j <= n6 - 2 - i; j++)
                {
                    if (EMP4[j] < EMP4[j + 1])
                    {
                        temp4 = EMP4[j + 1];
                        EMP4[j + 1] = EMP4[j];
                        EMP4[j] = temp4;
                    }

                    if (EMP5[j] < EMP5[j + 1])
                    {
                        temp5 = EMP5[j + 1];
                        EMP5[j + 1] = EMP5[j];
                        EMP5[j] = temp5;
                    }

                    if (EMP6[j] < EMP6[j + 1])
                    {
                        temp6 = EMP6[j + 1];
                        EMP6[j + 1] = EMP6[j];
                        EMP6[j] = temp6;
                    }
                }
            }

            //表单名次赋值
            for (iCount = 1; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
            {

                GROUP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_GROUP_CD].Text;
                EMP_CD = oSpread.ActiveSheet.Cells[iCount - 1, SS1_EMP_CD].Text;
                MILL_STAND = oSpread.ActiveSheet.Cells[iCount - 1, SS1_STAND].Text;
                MILL_PASS_RATE = convertX(oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_PASS_RATE].Text);
                //条件1
                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == "<23")
                {


                    for (i = n1; i >= 0; i += -1)
                    {
                        if (MILL_PASS_RATE == EMP1[i])
                        {
                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();
                        }
                    }
                }

                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == ">=23")
                {


                    for (i = n2; i >= 0; i += -1)
                    {
                        if (MILL_PASS_RATE == EMP2[i])
                        {

                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();

                        }

                    }

                }

                //3
                if (GROUP_CD != "全厂" & EMP_CD != "当日" & MILL_STAND == "当日累计")
                {


                    for (i = n3; i >= 0; i += -1)
                    {

                        if (MILL_PASS_RATE == EMP3[i])
                        {
                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();

                        }
                    }
                }

                //4
                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == "<23" & MILL_PASS_RATE > 0)
                {
                    for (i = n4; i >= 0; i += -1)
                    {
                        if (MILL_PASS_RATE == EMP4[i])
                        {
                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();
                        }
                    }
                }
                //5

                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == ">=23" & MILL_PASS_RATE > 0)
                {
                    for (i = n5; i >= 0; i += -1)
                    {
                        if (MILL_PASS_RATE == EMP5[i])
                        {
                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();
                        }
                    }
                }
                //6
                if (GROUP_CD != "全厂" & EMP_CD == "当日" & MILL_STAND == "当日累计" & MILL_PASS_RATE > 0)
                {
                    for (i = n6; i >= 0; i += -1)
                    {
                        if (MILL_PASS_RATE == EMP6[i])
                        {
                            oSpread.ActiveSheet.Cells[iCount - 1, SS1_MILL_RANKING].Text = (i + 1).ToString();
                        }
                    }
                }
            }

            //EMP1 = null;
            //EMP2 = null;
            //EMP3 = null;
            //EMP4 = null;
            //EMP5 = null;
            //EMP6 = null;
            //n1 = 0;
            //n2 = 0;
            //n3 = 0;
            //n4 = 0;
            //n5 = 0;
            //n6 = 0

        }




        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value.Replace(",",""));
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value.Replace(",", ""));
            }
            return 0;
        }    
           




    }
}
