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
    public partial class WGC1030C : CommonClass.FORMBASE
    {
        public WGC1030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Plate_No = 0;     //SS1钢板号
        public const int iSs1_Sche_Date = 5;    //SS1计划日期
        public const int iSs1_Sche_Shift = 6;   //SS1计划班次
        public const int iSs1_Emp_Cd = 30;      //SS1作业人员

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            //0-5
            p_SetMc("工厂", f4ETCR_PLT, "PN", "2", "", "", "", imcseq);
            p_SetMc("库", f4ETCR_CUR_INV, "PN", "2", "", "", "", imcseq);
            p_SetMc("垛位", TXT_LOC, "P", "10", "", "", "", imcseq);
            p_SetMc("计划状态", CBO_PRC_STS, "P", "", "", "", "", imcseq);
            p_SetMc("产品代码", CBO_PROD_CD, "PN", "", "", "", "", imcseq);       
            p_SetMc("指示时间", SDT_INS_DATE_FR, "P", "", "", "", "", imcseq);
            //6-10
            p_SetMc("指示时间", SDT_INS_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("计划时间", SDT_PLAN_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("计划时间", SDT_PLAN_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("标准号", F4ETCN_STDSPEC_R, "P", "", "", "", "", imcseq);
            p_SetMc("查询号", TXT_PLATE_NO, "P", "14", "", "", "", imcseq);
            //11-16
            p_SetMc("厚度", SDB_THK_FR, "P", "", "", "", "", imcseq);
            p_SetMc("厚度", SDB_THK_FR, "P", "", "", "", "", imcseq);
            p_SetMc("宽度", SDB_WID_FR, "P", "", "", "", "", imcseq);
            p_SetMc("宽度", SDB_WID_TO, "P", "", "", "", "", imcseq);
            p_SetMc("长度", SDB_LEN_FR, "P", "", "", "", "", imcseq);
            p_SetMc("长度", SDB_LEN_TO, "P", "", "", "", "", imcseq);
            
            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 29, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow);
            p_SetSc("编制时间", "DT", "19", "IL", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("产品代码", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("进程代码", "E", "3", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("状态", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("时间", "D", "10", "IL", "", "", "", iscseq, iheadrow,"L");
            //6-10
            p_SetSc("班次", "E", "1", "IL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("探伤", "E", "4", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);
            //16-20
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("综判", "E", "20", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("表判", "E", "20", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("取样代码", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("试样号", "E", "14", "L", "", "", "", iscseq, iheadrow,"L");
            //21-25
            p_SetSc("生产时间", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("订单材/余材", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("客户", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");
            //26-30
            p_SetSc("交货期", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("垛位", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("入库时间", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("作业人员", "E", "7", "IL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("订单特殊要求", "E", "300", "L", "", "", "", iscseq, iheadrow, "L");

            iheadrow = 0;
            p_spanSpread("切割计划", 4, 6, iscseq, iheadrow, 1);
            p_spanSpread("钢板信息", 7, 11, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 12, 16, iscseq, iheadrow, 1);
            p_spanSpread("等级", 17, 18, iscseq, iheadrow, 1);
            p_spanSpread("订单信息", 22, 26, iscseq, iheadrow, 1);

        }
        private void WGC1030C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
            //工厂/库 初始化
            f4ETCR_PLT.Text = "C2";
            f4ETCR_CUR_INV.Text = "HB";
            SDT_INS_DATE_FR.RawDate = DateTime.Now.Date.ToString();
        }
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            
            string sRowLabel;
            string iType;
            string sScheDate;  //计划日期
            string sScheShift; //计划班次
            if (e.ColumnHeader) return;
            //只有选择行表头才可进行操作
            if (e.Column != 0)
            {
                return;
            }

            sRowLabel = ss1_Sheet1.RowHeader.Rows[e.Row].Label;
            sScheDate = SDT_PLAN_CUT_DATE.RawDate ;
            sScheShift = CBO_SHIFT.Text;

            if (sScheDate != "")
            {
                sScheDate = (string)(sScheDate.Substring(0, 4) + "-" + sScheDate.Substring(4, 2) + "-" + sScheDate.Substring(6, 2));
            }

            if (rdo_add.Checked)
            {
               iType = "修改";
            }
            else
            {
                iType = "删除";
            }

        
            //取消前次操作
            if (sRowLabel == "修改" || sRowLabel == "删除")
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = "";
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Date].Text = "";
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Shift].Text = "";
            }
            else
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = iType;
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Date].Text = sScheDate;
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Shift].Text = sScheShift;
                ss1_Sheet1.Cells[e.Row, iSs1_Emp_Cd].Text = GeneralCommon.sUserID;
            }

        }
    }
}
