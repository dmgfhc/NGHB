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

namespace WG
{
    public partial class WGC2050C : CommonClass.FORMBASE
    {
        public WGC2050C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Gas_Date = 7;  //SS1切割时间
        public const int iSs2_Plate_No = 0;  //SS1钢板号
        public const int SPD_PROD_CD = 2; //SS2产品代码
        public const int iSs1_User_ID = 19; //SS1用户ID

        string s_user_id;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);
            p_SetMc("产品代码", CBO_PROD_CD, "P", "2", "", "", "", imcseq);
            p_SetMc("指示时间", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("指示时间", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_PLATE_NO, "P", "14", "", "", "", imcseq);
            p_SetMc("标准号", F4ETCN_STDSPEC_R, "P", "", "", "", "", imcseq);
            p_SetMc("库", f4ETCN_CUR_INV, "P", "", "", "", "", imcseq);
            p_SetMc("垛位", TXT_LOC, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("物料号", TXT_PLATE_NO, "P", "14", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 19, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow);
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("序列", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("订/余", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("宽度公差", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度公差", "N", "8", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("作业时间", "DT", "19", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("厚度", "N", "6,2", "IL", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "I", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("是否切边", "ON", "10", "I", "WG008", "", "", iscseq, iheadrow);//2      
            p_SetSc("切头", "ON", "10", "I", "WG009", "", "", iscseq, iheadrow);//2      
            p_SetSc("切尾", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            //16-20
            p_SetSc("取样一", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("取样二", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("是否尾板", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("作业人员", "E", "7", "I", "", "", "", iscseq, iheadrow, "M");

            iheadrow = 0;
            p_spanSpread("订单信息", 1, 7, iscseq, iheadrow, 1);
            p_spanSpread("作业实绩", 8, 18, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 17, true, true);
            iheadrow = 1;
            iscseq = 2;
            //0-5
            p_SetSc("物料号", "E", "14", "P", "", "", "", iscseq, iheadrow);
            p_SetSc("工厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("产品代码", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("计划切割时间", "D", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            //11-15
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow);
            //16-17
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("垛位", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("改判原因", "E", "20", "L", "", "", "", iscseq, iheadrow);

            iheadrow = 0;
            p_spanSpread("产品规格", 4, 7, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 11, 15, iscseq, iheadrow, 1);

        }
        private void WGC2050C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
            f4ETCR_PLT.Text = "C2";
            f4ETCN_CUR_INV.Text = "HB";
            CBO_PROD_CD.Text = "PP";
            SDT_PROD_DATE_FR.RawDate = DateTime.Now.Date.ToString();
            s_user_id = GeneralCommon.sUserID;
        }
        #endregion

        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 2, true, true);
            return;
        }
        #endregion

        #region //保存
        public override void Form_Pro()
        {
            base.p_pro(0, 1, true, true);
            return;
        }
        #endregion

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss2_Sheet1.RowCount == 0)
            {
                return;
            }
            //当单击表单时，按照单击行所对应钢板号查询钢板详细信息
            TXT_PLATE_NO.Text = ss2_Sheet1.Cells[e.Row, iSs2_Plate_No].Text;
            base.p_Ref(2, 1, true, false);
            for (int i = 0; i < ss2.ActiveSheet.RowCount; i++)
            {
                ss2.ActiveSheet.Cells[i, SPD_PROD_CD].Text = s_user_id;
                if (ss2.ActiveSheet.Cells[i, SPD_PROD_CD].Text == "MP")
                {
                    GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                    GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                    GeneralCommon.MDIToolBar.Refresh();
                    GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                    GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                    GeneralCommon.MDIToolBar.Refresh();
                    GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
                    GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
                    GeneralCommon.MDIToolBar.Refresh();
                }
            }
             if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                ss1.ActiveSheet.Cells[i, iSs1_User_ID].Text = s_user_id;
            }

            return;
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            string TimeStr;

            //base.ss_CellDoubleClick(sender, e);
            if (e.Column != iSs1_Gas_Date)
            {
                return;
            }

            //重写双击事件
            //声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
            // 新建数据库连接
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            // 检查数据库连接状态
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            // 打开数据库连接
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            // 取得系统时间
            TimeStr = AdoRs.Fields[0].Value.ToString();
            // 对取得系统时间做格式转换
            //TimeStr = DateTime.Now.Date.ToString();
            TimeStr = GeneralCommon.Gf_GetDateStr(TimeStr);
            // 点到活动单元格自动带出系统时间

            ss1.ActiveSheet.Cells.Get(e.Row, iSs1_Gas_Date).Text = TimeStr;
            ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text = "修改";

            //base.i_ScCurrSeq = 1;
        }

        public override void Spread_Ins()
        {
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[i_ScCurrSeq])["Spread"];

            //SpreadCommon.Gp_Sp_Ins(Proc_Sc(i_ScCurrSeq))
            //If Proc_Sc(i_ScCurrSeq)("authority") = 0 Then Exit Sub
            //SpreadCommon.Gp_Sp_InAuthority(Proc_Sc(i_ScCurrSeq), Proc_Sc(i_ScCurrSeq)("authority"))


            if (ss.Sheets[0].RowCount != 0)
            {
                ss.Sheets[0].Rows.Add(ss.ActiveSheet.ActiveRowIndex + 1, 1);
                ss.Sheets[0].ActiveRowIndex++;
                ss.Sheets[0].ActiveColumnIndex = 0;
            }
            else
            {
                ss.Sheets[0].Rows.Add(0, 1);
                ss.Sheets[0].ActiveRowIndex = 0;
            }
            ss.Sheets[0].RowHeader.Cells.Get(ss.ActiveSheet.ActiveRowIndex, 0).Text = "增加";


            for (int i = 0; i <= ss.Sheets[0].ColumnCount - 1; i++)
            {
                ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, i).Locked = false;
            }

            //Added by JIA
            //Lock lColumn
            Collection lColumn = (Collection)((Collection)Proc_Sc[i_ScCurrSeq])["lColumn"];
            for (int l = 1; l <= lColumn.Count; l++)
            {
                int col_i = int.Parse(lColumn[l].ToString());
                ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, col_i).Locked = true;
            }
            //SET EmpID
            int colID = System.Convert.ToInt32(((Collection)Proc_Sc[i_ScCurrSeq])["authority"]);
            if (colID > 0)
            {
                //ss.Sheets(0).Cells.Get(ss.Sheets(0).ActiveRowIndex, colID).Text = GeneralCommon.sUserID
                SpreadCommon.Gp_Sp_InAuthority((Collection)Proc_Sc[i_ScCurrSeq], colID, "");
            }


        }
      
    }
}
