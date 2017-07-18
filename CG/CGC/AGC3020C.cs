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
    public partial class AGC3020C : CommonClass.FORMBASE
    {
        public AGC3020C()
        {
            InitializeComponent();
        }
          Collection Mc1 = new Collection();
         Collection Sc1 = new Collection();
         const int SPD_1 = 0;
         const int SPD_PLATE_NO = 1;
         const int SPD_SQ_REASON = 3;
         const int SPD_SQ_DATE = 4;
         const int SPD_CL_DATE = 7;
         const int SPD_SQ_ID = 19;
         const int SPD_USER_ID = 20;

         protected override void p_SubFormInit()
         {
             int imcseq;
             p_McIni(Mc1, false);
             imcseq = 1;
             p_SetMc("工厂", CBO_PLT, "P", "", "", "", "", imcseq);//1 
             p_SetMc("查询号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);//1
             p_SetMc("退判时间", SDT_PROD_DATE, "NP", "", "", "", "", imcseq);
             p_SetMc("退判时间", SDT_PROD_TO_DATE, "NP", "", "", "", "", imcseq);
             p_SetMc("TXT_KND", TXT_KND, "P", "", "", "", "", imcseq);//1 
             int iheadrow;
             int iscseq;
             p_ScIni(ss1, Sc1, 20, true, true);
             iheadrow = 1;
             iscseq = 1;
             p_SetSc("选择", "C", "1", "I", "", "", "", iscseq, iheadrow);//0
             p_SetSc("钢板号", "E", "10", "PI", "", "", "", iscseq, iheadrow);//1
             p_SetSc("生产厂", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
             p_SetSc("退判原因", "E", "50", "I", "", "", "", iscseq, iheadrow);//3
             p_SetSc("退判时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "L");//4
             p_SetSc("入库时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//5
             p_SetSc("订单号序列", "E", "15", "L", "", "", "", iscseq, iheadrow);//6
             p_SetSc("删除时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//7
             p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//8
             p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow);//9
             p_SetSc("厚度*宽度*长度", "E", "18", "L", "", "", "", iscseq, iheadrow);//10
             p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//11
             p_SetSc("产品等级", "E", "1", "L", "", "", "", iscseq, iheadrow);//12
             p_SetSc("表面等级", "E", "1", "L", "", "", "", iscseq, iheadrow);//13
             p_SetSc("订单材/余材", "E", "1", "L", "", "", "", iscseq, iheadrow);//14
             p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow);//15
             p_SetSc("库别", "E", "2", "L", "", "", "", iscseq, iheadrow);//16
             p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//17
             p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//18
             p_SetSc("退判人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//19
             p_SetSc("操作人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "M");//20
             p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow);//21
             p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow);//22
             p_SetSc("厚度*宽度*长度", "E", "18", "L", "", "", "", iscseq, iheadrow);//23
             p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow);//24
             p_SetSc("订单/余材", "E", "1", "L", "", "", "", iscseq, iheadrow);//25
             p_SetSc("产品等级", "E", "1", "L", "", "", "", iscseq, iheadrow);//26
             p_SetSc("表面等级", "E", "1", "L", "", "", "", iscseq, iheadrow);//27
             p_SetSc("表面判定时间", "D", "8", "L", "", "", "", iscseq, iheadrow, "L");//28
             p_SetSc("表判人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//29
             p_SetSc("综判时间", "D", "8", "L", "", "", "", iscseq, iheadrow, "L");//30
             p_SetSc("剁位", "E", "1", "L", "", "", "", iscseq, iheadrow);//31
             p_SetSc("库别", "E", "2", "L", "", "", "", iscseq, iheadrow);//32
             p_SetSc("交货日期", "D", "8", "L", "", "", "", iscseq, iheadrow, "L");//33
             iheadrow = 0;
             p_spanSpread("钢板处理信息", 9, 18, iscseq, iheadrow, 1);
             p_spanSpread("钢板当前信息", 21, 32, iscseq, iheadrow, 1);
         }

         private void AGC3020C_Load(object sender, EventArgs e)
         {
             base.sSvrPgmPkgName = "AGC3020NC";
             Form_Define();
             CBO_KND.Text = "1 钢板退判";
             TXT_KND.Text = "1";
             CBO_PLT.Text = "C3";
             SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
             SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
             SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
         }

         private void CBO_KND_SelectedIndexChanged(object sender, EventArgs e)
         {
             SpreadCommon.Gf_Sp_Cls(Sc1);
             TXT_KND.Text = CBO_KND.Text.Substring(0, 1);
             if (TXT_KND.Text == "1")
             {
                 Ulabel5.Text = "退判时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_REASON).Text = "退判原因";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_DATE).Text = "退判时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_CL_DATE).Text = "删除时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_ID).Text = "退判人员";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_USER_ID).Text = "删除人员";
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_1, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CL_DATE, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_USER_ID, true);
             }
             else if (TXT_KND.Text == "4")
             {
                 Ulabel5.Text = "钢板删除时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_REASON).Text = "申请原因";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_DATE).Text = "申请时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_CL_DATE).Text = "删除时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_ID).Text = "申请人员";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_USER_ID).Text = "删除人员";
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_1, false);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CL_DATE, false);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_USER_ID, false);
             }
             else if (TXT_KND.Text == "6")
             {
                 Ulabel5.Text = "退入库时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_REASON).Text = "退入库原因";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_DATE).Text = "退入库时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_CL_DATE).Text = "删除时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_ID).Text = "退入库人员";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_USER_ID).Text = "删除人员";
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_1, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CL_DATE, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_USER_ID, true);
             }
             else if (TXT_KND.Text == "8")
             {
                 Ulabel5.Text = "强制排产时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_REASON).Text = "强制排产原因";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_DATE).Text = "强制排产时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_CL_DATE).Text = "删除时间";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_SQ_ID).Text = "强制排产人员";
                 ss1.Sheets[0].ColumnHeader.Cells.Get(0, SPD_USER_ID).Text = "删除人员";
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_1, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_CL_DATE, true);
                 SpreadCommon.Gp_Sp_ColHidden(ss1, SPD_USER_ID, true);
             }
         }
         public override void Form_Ref()
         {
             string SMESG = "";

             if (convertX(SDT_PROD_DATE.RawDate) - convertX(SDT_PROD_TO_DATE.RawDate) > 0)
             {
                 SMESG = " 时间范围输入错误，请重新输入时间信息 ！！！";
                 GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                 return;
             }
             p_Ref(1, 1, true, true);
         }
         public override void Form_Pro()
         {
             for (int iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
             {
                 switch (ss1.ActiveSheet.RowHeader.Cells[iCount-1,0].Text)
                 {
                     case "增加":
                         ss1.ActiveSheet.Cells[iCount - 1, SPD_USER_ID].Text =GeneralCommon.sUserID;
                         break;
                     case "修改":
                         ss1.ActiveSheet.Cells[iCount - 1, SPD_USER_ID].Text = GeneralCommon.sUserID;
                         break;
                     case "删除":
                         ss1.ActiveSheet.Cells[iCount - 1, SPD_USER_ID].Text = GeneralCommon.sUserID;
                         break;
                 }
             }
             p_Pro(0, 1, true, true);
         }

         public override bool Form_Cls()
         {
             base.Form_Cls();
             //在这里将序号变动两次，为了能够充分激活事件。
             CBO_KND.SelectedIndex = 1;
             CBO_KND.SelectedIndex = 0;
             CBO_PLT.Text = "C3";

             return true;
         }

         #region 公共方法

         public bool Gp_DateCheck(string DateCheck, string sDTChk)
         {
             sDTChk = "M";
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

             if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
             {
                 return false;
             }

             switch (iDateCheck.Length)
             {
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

             if (iDateMatch != iDateCheck.Substring(0, 8))
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

         public double convertX(string value)
         {
             if (value != "")
             {
                 return Convert.ToDouble(value);
             }
             return 0;
         }

         #endregion
    }
}
