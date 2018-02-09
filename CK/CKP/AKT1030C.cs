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
//-- System Name       中板生产管制
//-- Sub_System Name   统计分析管理
//-- Program Name      中板厂订单完成情况简报_CKP1020C
//-- Program ID        CKP1020C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2018.02.08
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2018.02.08       韩超        中板厂订单完成情况简报_CKP1020C
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CK
{
    public partial class AKT1030C : CommonClass.FORMBASE
    {
        public AKT1030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_ORD_ITEM_NUM = 2;
        const int SPD_ORD_TOT_WGT = 3;
        const int SPD_ORD_REM_WGT_U = 4;
        const int SPD_ORD_REM_WGT_D = 5;
        const int SPD_ORD_SMS_WGT = 6;
        const int SPD_ORD_CCM_WGT = 7;
        const int SPD_ORD_MILL_WGT = 8;
        const int SPD_ORD_CUT_WGT = 9;



       // const int SS1_SLAB_NO = 0;
        


        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(CBO_PLT, "P", "", "", "", imcseq, "");

            p_ScIni(ss1, Sc1, 7, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("任务号", "E", "60", "PI", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("启动", "C", "", "I", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("任务名称", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("WHAT", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("下次运行时间", "E", "60", "", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("任务状态", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("BROKEN", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("作业人员", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//7
          
        }

        private void AKT1030C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "AGT1030NC";
            Form_Define();

        }

        public override void Form_Pro()
        {
            p_pro(1, 1, false, true);
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            return true;

        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
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
        public double convertD(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
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
