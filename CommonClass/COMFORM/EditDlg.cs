using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public partial class EditDlg
	{
		FarPoint.Win.Spread.FpSpread ss;
		int row;
		int col;
		public EditDlg(FarPoint.Win.Spread.FpSpread ss, int iRow, int iCol)
		{
			
			// 此调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			// 在 InitializeComponent() 调用之后添加任何初始化。
			this.ss = ss;
			this.row = iRow;
			this.col = iCol;
			this.Text = "编辑:" + ss.Sheets[0].Columns[iCol].Label;
			txt_Editor.Text = ss.Sheets[0].Cells[row, col].Text;
		}
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.SheetView with_1 = ss.Sheets[0];
			if (with_1.Cells[row, col].Text != txt_Editor.Text)
			{
				with_1.Cells[row, col].Text = txt_Editor.Text;
				GeneralCommon.Gf_RowUpdate(ss, row);
			}
			this.Close();
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			txt_Editor.Clear();
		}
		
		public void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
	
}
