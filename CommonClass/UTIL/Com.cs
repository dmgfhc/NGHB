using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public enum RowType
	{
		normal,
		Input,
		Update,
		Delete
	}
	
	public class Com
	{
		
		public const string BasicSmp = "000a";
		public const string VirSmp = "v";
		public const string UpdateMark = "Update";
		public const string InsertMark = "Insert";
		public const string DeleteMark = "Delete";
		
		public const string SmpMat = "物料小类";
		public const string SmpMatCd = "X0001";
		
		public static int GF_ColFind(FarPoint.Win.Spread.FpSpread ss, string colName)
		{
			try
			{
				foreach (FarPoint.Win.Spread.Column col in ss.ActiveSheet.Columns)
				{
					if (colName == col.Label)
					{
						return col.Index;
					}
				}
				GeneralCommon.Gp_MsgBoxDisplay("未找到列名!", "", "");
				return -1;
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_ColFind error:" + ex.Message));
			}
		}
		public static FarPoint.Win.Spread.Column GF_ColumnFind(FarPoint.Win.Spread.FpSpread ss, string colName)
		{
			try
			{
				foreach (FarPoint.Win.Spread.Column col in ss.ActiveSheet.Columns)
				{
					if (colName == col.Label)
					{
						return col;
					}
				}
				GeneralCommon.Gp_MsgBoxDisplay("未找到列名", "", "");
				return null;
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_ColFind error:" + ex.Message));
			}
		}
		public static string GF_ColNameFind(FarPoint.Win.Spread.FpSpread ss, int iCol)
		{
			return ss.ActiveSheet.Columns[iCol].Label;
		}
		public static FarPoint.Win.Spread.Cell GF_CellFind(FarPoint.Win.Spread.FpSpread ss, int iRow, int iCol)
		{
			try
			{
				return ss.ActiveSheet.Cells[iRow, iCol];
				
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_CellFind error:" + ex.Message));
			}
		}
		public static FarPoint.Win.Spread.Cell GF_CellFind(FarPoint.Win.Spread.FpSpread ss, int iRow, string colName)
		{
			try
			{
				return ss.ActiveSheet.Cells[iRow, GF_ColFind(ss, colName)];
				
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_CellFind error:" + ex.Message));
			}
		}
		public static FarPoint.Win.Spread.Cell GF_CellFind(FarPoint.Win.Spread.FpSpread ss, string colName)
		{
			try
			{
				return ss.ActiveSheet.Cells[ss.ActiveSheet.ActiveRowIndex, GF_ColFind(ss, colName)];
				
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_CellFind error:" + ex.Message));
			}
		}
		
		// 'return :0:普通行,1:Input行,2:Update行,3:Delete行
        public static RowType GF_RowType(FarPoint.Win.Spread.FpSpread ss, int iRow)
		{
			try
			{
				switch (ss.ActiveSheet.RowHeader.Cells[iRow, 0].Text)
				{
					case "Input":
						
						return RowType.Input;
					case "Update":
						
						return RowType.Update;
					case "Delete":
						
						return RowType.Delete;
					default:
						
						return RowType.normal;
				}
			}
			catch (Exception ex)
			{
				throw (new Exception("GF_RowType error:" + ex.Message));
			}
		}
		
		public static void ClearSpread(FarPoint.Win.Spread.FpSpread ss)
		{
			if (ss.Sheets[0].RowCount > 0)
			{
				ss.Sheets[0].RemoveRows(0, ss.Sheets[0].RowCount);
			}
		}
		
		public static bool idCheck(string sID, string sPwd, object sForm)
		{
			string sQuery;
			
			if (sID == "")
			{
				GeneralCommon.Gp_MsgBoxDisplay("请输入员工号..!!", "W", "");
				return false;
			}
			
			if (sPwd == "")
			{
				GeneralCommon.Gp_MsgBoxDisplay("请输入密码..!!", "W", "");
				return false;
			}
			
			//ID Check
			sQuery = "SELECT EMP_NAME FROM BBA_EMPLOYEE WHERE EMP_ID = \'" + sID.Trim() + "\'";
			GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			if (GeneralCommon.sUsername == "FAIL")
			{
				return false;
			}
			
			if (GeneralCommon.sUsername == "")
			{
				GeneralCommon.Gp_MsgBoxDisplay("输入的员工号不存在..!!", "I", "");
				return false;
			}
			
			//Password check
			sQuery = "SELECT PASSWORD FROM BBA_EMPLOYEE WHERE EMP_ID = \'" + sID.Trim() + "\'";
			
			if (sPwd.Trim() != GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery))
			{
				GeneralCommon.Gp_MsgBoxDisplay("输入的密码不正确..!!", "I", "");
			}
			else
			{
				//User department id
				sQuery = "SELECT DEPT FROM BBA_EMPLOYEE WHERE EMP_ID = \'" + sID.Trim() + "\'";
				GeneralCommon.sDeptid = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
				
				//User department name
				sQuery = "SELECT CD_NAME FROM ZP_CD WHERE CD LIKE \'" + GeneralCommon.sDeptid + "\' AND CD_MANA_NO = \'B0025\'";
				GeneralCommon.sDeptname = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
				
				GeneralCommon.sUserID = sID.Trim();
				GeneralCommon.bPassCheck = true;
				
                //sForm.sAuthority = GeneralCommon.Gf_Pgm_Authority((string) sForm.Name);
				return true;
			}
            return true;
		}
		
        //#region "报表打印"
        //public static void Spread_Exc_Col(FarPoint.Win.Spread.FpSpread ss, object xlApp, int sCol, int xlRow, int xlCol)
        //{
        //    System.Windows.Forms.Clipboard.Clear();
        //    if (sCol == -1)
        //    {
        //        xlApp.cells(xlRow, xlCol).value = "序号";
        //        for (int i = 1; i <= ss.Sheets[0].RowCount; i++)
        //        {
        //            xlApp.cells(xlRow + i, xlCol).value = i.ToString();
        //        }
				
        //    }
        //    else if (ss.Sheets[0].Columns[sCol].Tag == "C")
        //    {
        //        ss.Sheets[0].AddSelection(-1, sCol, 0, 1);
        //        ss.Sheets[0].ClipboardCopy();
        //        ss.Sheets[0].RemoveSelection(-1, sCol, 0, 1);
        //        xlApp.cells(xlRow, xlCol).Select();
        //        xlApp.ActiveSheet.Paste();
        //        for (int i = 0; i <= ss.Sheets[0].RowCount - 1; i++)
        //        {
        //            if (ss.Sheets[0].Cells[i, sCol].Value == 1)
        //            {
        //                xlApp.cells(xlRow + i + 1, xlCol).value = "√";
        //            }
        //            else
        //            {
        //                xlApp.cells(xlRow + i + 1, xlCol).value = "";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        ss.Sheets[0].AddSelection(-1, sCol, ss.Sheets[0].RowCount, 1);
        //        ss.Sheets[0].ClipboardCopy();
        //        ss.Sheets[0].RemoveSelection(-1, sCol, ss.Sheets[0].RowCount, 1);
        //        xlApp.cells(xlRow, xlCol).Select();
        //        xlApp.ActiveSheet.Paste();
        //    }
			
        //}
        //public static void Spread_Exc_Model(FarPoint.Win.Spread.FpSpread ss, object xlApp, int[] sCols, int xlRow, int xlCol)
        //{
        //    System.Windows.Forms.Clipboard.Clear();
        //    for (int i = 0; i <= sCols.Length - 1; i++)
        //    {
        //        ss.Sheets[0].AddSelection(0, sCols[i], ss.Sheets[0].RowCount, 1);
        //        ss.Sheets[0].ClipboardCopy();
        //        ss.Sheets[0].RemoveSelection(0, sCols[i], ss.Sheets[0].RowCount, 1);
        //        xlApp.cells(xlRow, xlCol + i).Select();
        //        xlApp.ActiveSheet.Paste();
        //    }
        //    System.Windows.Forms.Clipboard.Clear();
        //}
		
        //public static void Spread_Exc_All(FarPoint.Win.Spread.FpSpread ss, object xlApp, int xlRow, int xlCol)
        //{
        //    if (ss.Sheets[0].RowCount == 0)
        //    {
        //        return;
        //    }
        //    System.Windows.Forms.Clipboard.Clear();
        //    FarPoint.Win.Spread.FpSpread with_1 = ss;
        //    with_1.Sheets[0].AddSelection(0, 0, with_1.Sheets[0].RowCount, with_1.Sheets[0].ColumnCount);
        //    with_1.Sheets[0].ClipboardCopyShape();
        //    with_1.Sheets[0].ClipboardCopy();
        //    with_1.Sheets[0].RemoveSelection(0, 0, with_1.Sheets[0].RowCount, with_1.Sheets[0].ColumnCount);
        //    xlApp.ActiveSheet.cells(xlRow, xlCol).Select();
        //    xlApp.ActiveSheet.Paste();
        //    System.Windows.Forms.Clipboard.Clear();
        //}
		
        //public static void Spread_Exc_Auto(ref FarPoint.Win.Spread.FpSpread ss, object xlApp, int xlRow, int xlCol)
        //{
        //    int j = 0;
        //    System.Windows.Forms.Clipboard.Clear();
        //    for (int i = 0; i <= ss.Sheets[0].ColumnCount - 1; i++)
        //    {
        //        if (colNeedDis(ss, i, true))
        //        {
        //            ss.Sheets[0].AddSelection(-1, i, ss.Sheets[0].RowCount, 1);
        //            ss.Sheets[0].ClipboardCopy();
        //            ss.Sheets[0].RemoveSelection(-1, i, ss.Sheets[0].RowCount, 1);
        //            xlApp.cells(xlRow, xlCol + j).Select();
        //            xlApp.ActiveSheet.Paste();
        //            j++;
        //        }
        //    }
        //    System.Windows.Forms.Clipboard.Clear();
        //}
        //public static bool colNeedDis(FarPoint.Win.Spread.FpSpread ss, int Col, bool bCheckVisible)
        //{
        //    bool colDis = false;
        //    FarPoint.Win.Spread.SheetView with_1 = ss.Sheets[0];
        //    if (with_1.RowCount > 0)
        //    {
        //        for (int i = 0; i <= with_1.RowCount - 1; i++)
        //        {
        //            if ((with_1.Cells.Get(i, Col).Text.Trim().Length != 0) && (with_1.Cells.Get(i, Col).Text != "False") && (with_1.Columns[Col].Visible == true || bCheckVisible == false))
        //            {
        //                colDis = true;
        //                break;
        //            }
        //        }
        //    }
        //    return colDis;
        //    //Return True
        //}

        //// '给选定区域加边框
        //public static void Exc_Border(object xlRange, int iLineStyle, bool bLeft, bool bRight, bool bTop, bool bBottom)
        //{
        //    object with_1 = xlRange;
        //    if (bLeft)
        //    {
				
        //        with_1.Borders(1).LineStyle = iLineStyle;
        //    }
        //    if (bRight)
        //    {
				
        //        with_1.Borders(2).LineStyle = iLineStyle;
        //    }
        //    if (bTop)
        //    {
				
        //        with_1.Borders(3).LineStyle = iLineStyle;
        //    }
        //    if (bBottom)
        //    {
				
        //        with_1.Borders(4).LineStyle = iLineStyle;
        //    }
        //}
		
		
        //#endregion
		
		
		public static void NAR(object o)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(o);
			}
			catch (Exception)
			{
			}
			finally
			{
				
				o = null;
			}
		}
        //public static void ReComboNullRow(System.Windows.Forms.ComboBox cmbBox)
        //{
        //    DataTable dt = cmbBox.DataSource.;
        //    dt.Rows.RemoveAt(dt.Rows.Count - 1);
        //    cmbBox.DataSource = dt.DefaultView;
        //}
	}
	
	public class Pair
	{
		
		private string myCd;
		private string myName;
		
		public Pair(string strName, string strCd)
		{
			this.myCd = strCd;
			this.myName = strName;
		} //New
		
		public string Name
		{
			get
			{
				return myName;
			}
		}
		
		public string Cd
		{
			get
			{
				return myCd;
			}
		}
		
		public override string ToString()
		{
			return this.Cd + " - " + this.Name;
		} //ToString
		
	}
	
}
