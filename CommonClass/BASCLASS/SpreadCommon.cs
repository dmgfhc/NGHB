using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using FarPoint.Win.Spread;
using System.Drawing;
using System.IO;

namespace CommonClass
{
	public class SpreadCommon
	{
		public SpreadCommon()
		{
			VbBlue = Color.Blue;
			VbWhite = Color.White;
			VbBlack = Color.Black;
			vbTotal = Color.Khaki;
			vbSTotal = Color.LightCyan;
			VbEven = Color.FromArgb(255, 241, 236, 255);
			VbTitle = Color.FromArgb(255, 205, 228, 225);
			VbYellow = Color.FromArgb(255, 255, 255, 192);
			VbSelect = Color.FromArgb(255, 255, 236, 206);
			VbGridColor = Color.FromArgb(255, 64, 128, 128);
			VbLockBackColor = Color.FromArgb(255, 255, 255, 255);
			VbGrayAreaBackColor = Color.FromArgb(255, 224, 224, 224);
			
		}
		
		const int ssRowHeight = 25;
		const int ssHeadHeight = 35;
		
		const int SS_Cell_Type_Date = 0;
		const int SS_Cell_Type_Edit = 1;
		const int SS_Cell_Type_Float = 2;
		const int SS_Cell_Type_Integer = 3;
		const int SS_Cell_Type_Pic = 4;
		const int SS_Cell_Type_StaticText = 5;
		const int SS_Cell_Type_Time = 6;
		const int SS_Cell_Type_Button = 7;
		const int SS_Cell_Type_ComboBox = 8;
		const int SS_Cell_Type_Picture = 9;
		const int SS_Cell_Type_CheckBox = 10;
		const int SS_Cell_Type_OwnerDrawn = 11;
		const int SS_Cell_Type_Currency = 12;
		const int SS_Cell_Type_Number = 13;
		const int SS_Cell_Type_Percent = 14;
		
		FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
		FarPoint.Win.Spread.CellType.NumberCellType ncell = new FarPoint.Win.Spread.CellType.NumberCellType();
		FarPoint.Win.Spread.CellType.CheckBoxCellType ccell = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
		FarPoint.Win.Spread.CellType.DateTimeCellType dcell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
		FarPoint.Win.Spread.CellType.ComboBoxCellType ocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
		
		// Spread Sheet Design Color Setting
		public Color VbBlue;
		public Color VbWhite;
		public Color VbBlack;
		public Color vbTotal;
		public Color vbSTotal;
		public Color VbEven;
		public Color VbTitle;
		public Color VbYellow;
		public Color VbSelect;
		public Color VbGridColor;
		public Color VbLockBackColor;
		public Color VbGrayAreaBackColor;
		// SortKeyOrder property settings

		public const int SS_SORT_ORDER_NONE = 0;
		public const int SS_SORT_ORDER_ASCENDING = 1;
		public const int SS_SORT_ORDER_DESCENDING = 2;
		public const int SS_ACTION_SORT = 25;
		// SortBy property settings
		public const int SS_SORT_BY_ROW = 0;
		public const int SS_SORT_BY_COL = 1;
        public bool iRecord = true;//�Ƿ��¼ǰ̨����
		
		
		public void Gp_Sp_Grouping(FpSpread oSpread)
		{
			
			oSpread.AllowColumnMove = true;
			oSpread.ActiveSheet.GroupBarVisible = true;
			oSpread.ActiveSheet.GroupBarBackColor = Color.Aquamarine;
			oSpread.ActiveSheet.GroupBarHeight = 75;
			oSpread.ActiveSheet.GroupMaximumLevel = 3;
			oSpread.ActiveSheet.GroupVerticalIndent = 20;
			oSpread.ActiveSheet.AllowGroup = true;
			
			FarPoint.Win.Spread.GroupInfo gi = new FarPoint.Win.Spread.GroupInfo();
			gi.BackColor = Color.Yellow;
			
			FarPoint.Win.Spread.GroupInfo gi2 = new FarPoint.Win.Spread.GroupInfo();
			gi2.BackColor = Color.Green;
			
			FarPoint.Win.Spread.GroupInfoCollection gic = new FarPoint.Win.Spread.GroupInfoCollection();
			gic.AddRange(new FarPoint.Win.Spread.GroupInfo[] {gi, gi2});
			
			oSpread.ActiveSheet.GroupInfos.Add(gic[0]);
		}
		
        /// <summary>
        /// ����spread��ͷ�߶ȣ��п�ȣ������ı���ɫ��ɾ��
        /// oSpread��Spread����
        /// LocColChk���Ƿ�����
        /// SortColChk���Ƿ�����
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="LocColChk"></param>
        /// <param name="SortColChk"></param>
        public void Gp_Sp_Setting(FpSpread oSpread, bool LocColChk, bool SortColChk)
        {

            int lHeadRow;
            oSpread.AllowColumnMove = false;
            //'JIA �и�           
            oSpread.ActiveSheet.Rows.Default.Height = float.Parse("22");
            //'JIA ��ͷ�߶�
            if (oSpread.ActiveSheet.ColumnHeader.RowCount > 1)
            {
                for (lHeadRow = 0; lHeadRow <= oSpread.ActiveSheet.ColumnHeaderRowCount - 1; lHeadRow++)
                {
                    oSpread.ActiveSheet.ColumnHeader.Rows.Get(lHeadRow).Height = float.Parse("21");
                }
            }
            else
            {
                oSpread.ActiveSheet.ColumnHeader.Rows.Get(0).Height = float.Parse("42");
            }


            //'JIA ScrollBar
            oSpread.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            oSpread.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;

            //'JIA �����������Զ������п��
            oSpread.ActiveSheet.DataAutoSizeColumns = false;
            oSpread.ActiveSheet.Columns.Default.Width = 50;
            oSpread.ActiveSheet.GrayAreaBackColor = VbGrayAreaBackColor;          
            oSpread.ActiveSheet.SelectionBackColor = VbSelect;
            oSpread.BorderStyle = BorderStyle.FixedSingle;      
            oSpread.ActiveSheet.RowHeader.Columns.Default.Resizable = true;    
            oSpread.RetainSelectionBlock = true;          
            oSpread.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.Always;
            //0 - Always

           // oSpread.AutoClipboard = false;
            ///////////////20130502

            oSpread.TabStop = false;
            if (LocColChk)
            {
                oSpread.ActiveSheet.LockBackColor = VbLockBackColor;
            }
            if (SortColChk)
            {
                for (int i = 0; i <= oSpread.ActiveSheet.ColumnCount - 1; i++)
                {
                    oSpread.ActiveSheet.SortRows(i, true, true);
                }
            }


        }
		
		
        /// <summary>
        /// δ�á�
        /// </summary>
        /// <param name="oSpread"></param>
		public void Gp_Sp_ReadOnlySet(FpSpread oSpread)
		{
            oSpread.Sheets[0].Protect = true;			
		}
		
		
        /// <summary>
        /// spread�п���书�ܣ����ļ��ж�ȡ��ǰ�еĿ�ȡ�
        /// oSpread��Spread����
        /// sEcname����ǰҳ�����ơ�
        /// sType��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="sEcname"></param>
        /// <param name="sType"></param>
		public void Gp_Sp_ColGet(FpSpread oSpread, string sEcname, string sType)
		{
			
			Win32ApiClass Win32ApiClass = new Win32ApiClass();
			
			int i;
			string sKey;
			string tPtext;

            for (i = 0; i <= oSpread.Sheets[0].ColumnCount - 1; i++)
			{
                if (oSpread.Sheets[0].Columns.Get(i).Visible == true)
				{
                    string xx = oSpread.Sheets[0].ColumnHeader.Cells.Get(oSpread.Sheets[0].ColumnHeader.RowCount - 1, i).Text;

                    if (sType != null) sType = sType.Trim();

                    sKey = sType + oSpread.Name.Trim() + "." + xx;// Strings.Trim(with_1.Sheets[0].ColumnHeader.Cells.Get(System.Convert.ToInt32(with_1.Sheets[0].ColumnHeader.RowCount - 1), i).Text));

                    int Save_Width = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, (int)oSpread.Sheets[0].Columns.Get(i).Width, GeneralCommon.FileName);                 
                    if (Save_Width != (int)oSpread.Sheets[0].Columns.Get(i).Width)
                        oSpread.Sheets[0].Columns.Get(i).Width = Save_Width;

                    //oSpread.Sheets[0].Columns.Get(i).Width = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, (int)oSpread.Sheets[0].Columns.Get(i).Width, GeneralCommon.FileName);
                    //if (oSpread.Sheets[0].Columns.Get(i).Width < 50)
                    //{
                    //    oSpread.Sheets[0].Columns.Get(i).Width = 50;
                    //}
				}
			}
		}
        
		
        /// <summary>
        /// ���еĿ�����õ��ļ���
        /// oSpread��Spread����
        /// sEcname����ǰҳ������
        /// sType��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="sEcname"></param>
        /// <param name="sType"></param>
		public void Gp_Sp_ColSet(FpSpread oSpread, string sEcname, string sType)
		{
			Win32ApiClass Win32ApiClass = new Win32ApiClass();
			
			int i;
			string sKey;
			string sValue;

            for (i = 0; i <= oSpread.Sheets[0].ColumnCount - 1; i++)
			{
                sValue = System.Convert.ToString(oSpread.Sheets[0].Columns.Get(i).Width);
                if (oSpread.Sheets[0].Columns.Get(i).Visible == true)
				{
                    try
                    {
                        if (sType != null) sType = sType.Trim();
                        sKey = (string)(sType + oSpread.Name.Trim() + "." + Strings.Trim(oSpread.Sheets[0].ColumnHeader.Cells.Get(System.Convert.ToInt32(oSpread.Sheets[0].ColumnHeader.RowCount - 1), i).Text));
                        Win32ApiClass.WritePrivateProfileString(sEcname, sKey, sValue, GeneralCommon.FileName);
                    }
                    catch { }
					
				}
			}
		}
		
		
        /// <summary>
        /// spread������
        /// oSpread��Spread����
        /// ColNum��������λ�á�
        /// HiddenType���Ƿ����ء�
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="ColNum"></param>
        /// <param name="HiddenType"></param>
		public void Gp_Sp_ColHidden(FpSpread oSpread, int ColNum, bool HiddenType)
		{			
            oSpread.Sheets[0].Columns[ColNum].Visible = !HiddenType;//System.Convert.ToBoolean(!HiddenType);			
		}
		
        /// <summary>
        ///  δ��
        /// </summary>
        /// <param name="Sc"></param>
		public void Gp_Sp_AutoInsert(Collection Sc)
		{
			
			FpSpread oSpread =(FarPoint.Win.Spread.FpSpread) Sc["Spread"];

            if (oSpread.ActiveSheet.RowCount < 1)
			{
				return;
			}

            if (oSpread.ActiveSheet.ActiveColumnIndex != (((int)Sc["Last"] == oSpread.ActiveSheet.ColumnCount) ? oSpread.ActiveSheet.ColumnCount : ((int)Sc["Last"])))
			{
				return;
			}
            if (oSpread.ActiveSheet.ActiveRowIndex != oSpread.ActiveSheet.RowCount)
			{
				return;
			}

            oSpread.ActiveSheet.RowCount++;
            oSpread.ActiveSheet.Rows.Add(oSpread.ActiveSheet.RowCount, 1);
            oSpread.ActiveSheet.ActiveRowIndex = oSpread.ActiveSheet.RowCount - 1;
            oSpread.ActiveSheet.RowHeader.Cells.Get(oSpread.ActiveSheet.ActiveRowIndex, 0).Text = "����";
		}
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sc"></param>
        /// <param name="Auth_Col"></param>
        /// <param name="iType"></param>
		public void Gp_Sp_InAuthority(Collection Sc, int Auth_Col, string iType)
		{
			
			int iCount;
			
			if (Auth_Col == 0)
			{
				return;
			}


            FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
			
			if (iType == "")
			{

                oSpread.Sheets[0].SetText(oSpread.ActiveSheet.ActiveRowIndex, Auth_Col, GeneralCommon.sUserID);
				
			}
			else
			{
                for (iCount = 0; iCount <= oSpread.ActiveSheet.RowCount; iCount++)
				{
                    oSpread.Sheets[0].SetText(iCount, Auth_Col, GeneralCommon.sUserID);
				}
			}
			
			
		}
		
		
        /// <summary>
        /// δ��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iRow"></param>
        /// <param name="RowHeader"></param>
		public void Gp_Sp_InsertRow(FpSpread oSpread, long iRow, string RowHeader)
		{
						
		}
		
		
        /// <summary>
        /// ���Spread��ǰ�Ƿ��С����ӡ����޸ġ���ɾ�����Ĳ���
        /// ��������ϲ���������TfΪtrueʱ����ִ�С���ѯ������������ʱ��ϵͳ�����ն��û�����һ����Ϣ����ʾ������Ŀǰ���е��е����ϣ�����������
        /// ���ѡ��yes������ô��ִ�С���ѯ������������������᲻���в�����
        /// ���TfΪfalseʱ�������ն��û�����һ����Ϣ��
        /// oSpread��Spread����
        /// Tf���Ƿ����û���ʾ��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="Tf"></param>
        /// <returns></returns>
		public bool Gf_Sp_ProceExist(FpSpread oSpread, bool Tf)
		{
			bool returnValue;
			
			string sMessg;
			int lCount;
			long Proc = 0;
            for (lCount = 0; lCount <= oSpread.ActiveSheet.RowCount - 1; lCount++)
			{
                if (oSpread.ActiveSheet.RowHeader.Cells[lCount, 0].Text.Trim() == "����" || 
                    oSpread.ActiveSheet.RowHeader.Cells[lCount, 0].Text.Trim() == "�޸�" || 
                    oSpread.ActiveSheet.RowHeader.Cells[lCount, 0].Text.Trim() == "ɾ��")
				{
					Proc++;
					break;
				}
			}
			
			if (Proc > 0)
			{
				if (Tf)
				{
                    sMessg = "����Ŀǰ���е��е�����" + "\r\n";
                    sMessg = sMessg + "����������...???";
					
					if (GeneralCommon.Gf_MessConfirm(sMessg, "Q", ""))
					{
						returnValue = false;
					}
					else
					{
						returnValue = true;
					}
				}
				else
				{
					returnValue = true;
				}
				
			}
			else
			{
				returnValue = false;
			}
			
			return returnValue;
		}
		
        /// <summary>
        /// ���õ�Ԫ��ı�����ɫ��������ɫ
        /// oSpread��Spread����
        /// iCol���к�
        /// iRow������
        /// fColor��������ɫ
        /// bColor��������ɫ
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iCol"></param>
        /// <param name="iRow"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
		public void Gp_Sp_CellColor(FpSpread oSpread, int iCol, int iRow, Color fColor, Color bColor)
		{		
            oSpread.ActiveSheet.Cells[iRow, iCol].BackColor = bColor;   //������ɫ
            oSpread.ActiveSheet.Cells[iRow, iCol].ForeColor = fColor;	//������ɫ		
		}
		
		
        /// <summary>
        /// ����Spread��ǰ�е����弰������ɫ��
        /// oSpread��Spread����
        /// iCol������
        /// fColor��������ɫ
        /// bColor��������ɫ
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iCol"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
		public void Gp_Sp_ColColor(FpSpread oSpread, int iCol, Color fColor, Color bColor)
		{
            oSpread.ActiveSheet.Columns.Get(iCol).BackColor = bColor;
            oSpread.ActiveSheet.Columns.Get(iCol).ForeColor = fColor;			
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="oSpread"></param>
		/// <param name="iCol"></param>
        public void Gp_Sp_HdColColor(FpSpread oSpread, long iCol)
		{
			
		}
		
        /// <summary>
        /// ����Gp_Sp_BlockColor��������������Spread���е����弰������ɫ��
        /// oSpread��Spread����
        /// iRow������
        /// fColor��������ɫ
        /// bColor��������ɫ
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iRow"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
		public void Gp_Sp_RowColor(FpSpread oSpread, int iRow, Color fColor, Color bColor)
		{
			
			SheetView with_1 = oSpread.ActiveSheet;
			Gp_Sp_BlockColor(oSpread, 0, with_1.ColumnCount - 1, iRow, iRow, fColor, bColor);
			
		}
		
        /// <summary>
        /// ����Spreadָ����������弰������ɫ
        /// iCol1:��ʼ����
        /// iCol2:��������
        /// iRow1����ʼ����
        /// iRow2����������
        /// fColor:������ɫ
        /// bColor:������ɫ
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iCol1"></param>
        /// <param name="iCol2"></param>
        /// <param name="iRow1"></param>
        /// <param name="iRow2"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
		public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
		{
			
			FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
			for (int row = iRow1; row <= iRow2; row++)
			{
				for (int col = iCol1; col <= iCol2; col++)
				{					
					bool locked = with_1.Columns[col].Locked;
					with_1.Cells[row, col].Locked = false;
					with_1.Cells[row, col].BackColor = bColor;
					with_1.Cells[row, col].ForeColor = fColor;
                    with_1.Cells[row, col].Locked = locked;
				}
			}
			
		}
		
        /// <summary>
        /// ��Spread��ǰ�������������
        /// oSpread��Spread����
        /// iCol1����ʼ����
        /// iCol2����������
        /// iRow1����ʼ����
        /// iRow2����������
        /// LockType��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iCol1"></param>
        /// <param name="iCol2"></param>
        /// <param name="iRow1"></param>
        /// <param name="iRow2"></param>
        /// <param name="LockType"></param>
        public void Gp_Sp_BlockLock(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, bool LockType)
		{
			for (int i = iRow1; i <= iRow2; i++)
			{
				for (int j = iCol1; j <= iCol2; j++)
				{
                    oSpread.ActiveSheet.Cells.Get(i, j).Locked = true;
				}
			}
		}
		
        /// <summary>
        /// ���ǰ��Ԫ��
        /// oSpread����ǰSpread����
        /// iCol������
        /// iRow������
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iCol"></param>
        /// <param name="iRow"></param>
        public void Gp_Sp_ActiveCell(FpSpread oSpread, long iCol, long iRow)
		{						
            oSpread.ActiveSheet.ActiveRowIndex = (int)iRow;
            oSpread.ActiveSheet.ActiveColumnIndex = (int)iCol;			
		}
		
        /// <summary>
        /// ����Spread���б����ȡ���������к�
        /// oSpread����ǰSpread����
        /// columnName��Spread��ͷ�б��⡣
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
		public int Gp_Sp_getColumnindex(FpSpread oSpread, string columnName)
		{
			int k;
			for (k = 0; k <= oSpread.ActiveSheet.ColumnHeader.Columns.Count - 1; k++)
			{
				if (oSpread.ActiveSheet.ColumnHeader.Cells[0, k].Text.Equals(columnName))
				{
					return k;
				}
			}
            return k;			
		}
		
        /// <summary>
        /// ��MC��a�ؼ���ֵд���Ӧ��Spread��������iCount�����С�
        /// </summary>
        /// <param name="iCount"></param>
        /// <param name="Sc"></param>
        /// <param name="Mc"></param>
		public void Gp_Sp_Move(int iCount, Collection Sc, Collection Mc)
		{			
			int i;
			string sTemp;
			
			try
			{				
				for (i = 1; i <= ((Collection)Mc["aControl"]).Count; i++)
				{					
					if (((Collection)Mc["aControl"])[i] is ComboBox) //ComboBox
					{						
						if (((ComboBox)((Collection)Mc["aControl"])[i]).DropDownStyle ==  ComboBoxStyle.DropDownList)
						{							
							if (((ComboBox)((Collection)Mc["aControl"])[i]).SelectedIndex == -1)
							{
								Gp_Sp_SendData((FarPoint.Win.Spread.FpSpread)Sc["Spread"], " ",int.Parse( ((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
							}
							else
							{								
                                sTemp = (string)(((ComboBox)((Collection)Mc["aControl"])[i]).SelectedValue);
                                Gp_Sp_SendData((FarPoint.Win.Spread.FpSpread)Sc["Spread"], sTemp, int.Parse(((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
							}							
						}
						else
						{
                            Gp_Sp_SendData((FarPoint.Win.Spread.FpSpread)Sc["Spread"], (string)(((Control)((Collection)Mc["aControl"])[i]).Text),int.Parse( ((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
						}
						
					}
					else if ((Control)((Collection)Mc["aControl"])[i] is CheckBox) //CheckBox
					{

                        Gp_Sp_SendData((FpSpread)Sc["Spread"], (string)(((Collection)Mc["aControl"])[i]),int.Parse(((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
						
					}
					else if (((Collection)Mc["aControl"])[i] is NumericUpDown)
					{

                        Gp_Sp_SendData((FpSpread)Sc["Spread"], (string)(((Collection)Mc["aControl"])[i]), int.Parse(((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
						
					}
					else
					{
                        Gp_Sp_SendData((FpSpread)Sc["Spread"], (((Control)((Collection)Mc["aControl"])[i]).Text), int.Parse(((Collection)Sc["aColumn"])[i].ToString()), iCount, 0);
						
					}
					
				}
				
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_Move Error : " + ex.Message), "", "");
			}
			
		}
		
        /// <summary>
        /// δ��
        /// </summary>
        /// <param name="Sc"></param>
		public void Gp_Sp_Ins(Collection Sc)
		{
			int iCount;
            FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            FarPoint.Win.Spread.CellType.ComboBoxCellType cc = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
			
			try
			{

                oSpread.Focus();
                Gp_Sp_InsertRow(oSpread, oSpread.Sheets[0].ActiveRowIndex, "Input");
         
                int iRow = oSpread.Sheets[0].ActiveRowIndex;
				
				for (iCount = 1; iCount <= ((Collection)Sc["iColumn"]).Count; iCount++)
				{	
					
                    if (oSpread.Sheets[0].GetCellType(iRow,iCount) ==cc)// SS_Cell_Type_ComboBox)
					{
                        cc = (FarPoint.Win.Spread.CellType.ComboBoxCellType)oSpread.Sheets[0].GetCellType(iRow, iCount);
                        if (cc.Editable)
						{
                            oSpread.Sheets[0].Cells[iRow,iCount].Text = "";
						}
						else
						{
                            oSpread.Sheets[0].Cells[iRow, iCount].Text = " ";
						}
					}
					
				}

                int spread_first = int.Parse(Sc["First"].ToString());
                Gp_Sp_ActiveCell(oSpread, (spread_first > 1) ? spread_first : 1, -1);
			
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_Ins Error : " + ex.Message), "", "");
			}
			
		}
		
        /// <summary>
        /// ����ǰSc��Spread�������
        /// Sc��Sc���ϡ�
        /// </summary>
        /// <param name="Sc"></param>
        /// <returns></returns>
		public bool Gf_Sp_Cls(Collection Sc)
		{
			bool returnValue;
			
			try
			{						
                if (Gf_Sp_ProceExist((FpSpread)Sc["Spread"], true))
				{
                    return false;
				}
                //'Hux,�޸ġ�
                //'���:Spread����������ʱ�������ͷ������ٵ��Spread���룬Spread�����ʱ����
                ((FpSpread)Sc["Spread"]).ActiveSheet.AutoSortColumn(0);
                //ʹ��AutoSortColumn��������ʾ����������������
                ((FpSpread)Sc["Spread"]).ActiveSheet.RowCount = 0;
				returnValue = true;		
				
			}
			catch (Exception)
			{
				returnValue = false;
			}
			
			return returnValue;
		}
		
		
         /// <summary>
         /// ����pctl�ȵ�ֵ��oSpread����num�����Ӧ��Collection�С�
         /// </summary>
         /// <param name="oSpread"></param>
         /// <param name="Num"></param>
         /// <param name="pcol"></param>
         /// <param name="ncol"></param>
         /// <param name="mcol"></param>
         /// <param name="iCol"></param>
         /// <param name="acol"></param>
         /// <param name="lCol"></param>
         /// <param name="pColumn"></param>
         /// <param name="nColumn"></param>
         /// <param name="mColumn"></param>
         /// <param name="iColumn"></param>
         /// <param name="aColumn"></param>
         /// <param name="lColumn"></param>
		public void Gp_Sp_Collection(FpSpread oSpread, int Num, string pcol, string ncol, string mcol, string iCol, string acol, string lCol, 
                         Collection pColumn, Collection nColumn, Collection mColumn, Collection iColumn, Collection aColumn, Collection lColumn)
		{
			
			Color color;
			color = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte) (255)), System.Convert.ToInt32((byte) (255)), System.Convert.ToInt32((byte) (192)));
			
			
			if (pcol.Trim().ToLower() == "p") //PK Column
			{
				pColumn.Add(Num, null, null, null);
				Gp_Sp_ColLock(oSpread, Num, true);
			}
			
			if (ncol.Trim().ToLower() == "n") //Necessary Column
			{
				nColumn.Add(Num, null, null, null);
                Gp_Sp_ColColor(oSpread, Num, VbBlack, color);
			}
			
			if (mcol.Trim().ToLower() == "m") //Spread Maxlength check Column
			{
				mColumn.Add(Num, null, null, null);
			}
			
			if (iCol.Trim().ToLower() == "i") //Spread Insert Column
			{
				iColumn.Add(Num, null, null, null);
                Gp_Sp_ColColor(oSpread, Num, VbBlack, color);
			}
			
			if (acol.Trim().ToLower() == "a") //Master -> Spread Column
			{
				aColumn.Add(Num, null, null, null);
				Gp_Sp_ColHidden(oSpread, Num, true);
			}
			
			if (lCol.Trim().ToLower() == "l") //Spread Lock Column
			{
				lColumn.Add(Num, null, null, null);
				Gp_Sp_ColLock(oSpread, Num, true);
			}
			
			if (lCol.Trim().ToLower() == "o") //Spread other Column
			{
                Gp_Sp_ColColor(oSpread, Num, VbBlack, color);
			}
		}
		
		
        /// <summary>
        /// δ��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="Cbo_First"></param>
        /// <param name="Cbo_Second"></param>
        /// <param name="Cbo_Third"></param>
        public void Gp_Sp_ColSort(FpSpread oSpread, ComboBox Cbo_First, ref ComboBox Cbo_Second,ref ComboBox Cbo_Third)
		{
			
			int iCol;
			string tPtext;
			
			try
			{
				Cbo_First.Items.Add("");
				Cbo_Second.Items.Add("");
				Cbo_Third.Items.Add("");

                for (iCol = 0; iCol <= oSpread.ActiveSheet.ColumnCount - 1; iCol++)
				{
                    if (oSpread.ActiveSheet.Columns.Get(iCol).Visible == true)
					{
                        Cbo_First.Items.Add(oSpread.ActiveSheet.ColumnHeader.Cells.Get(0, iCol).Text + Strings.Space(100) + iCol);
                        Cbo_Second.Items.Add(oSpread.ActiveSheet.ColumnHeader.Cells.Get(0, iCol).Text + Strings.Space(100) + iCol);
                        Cbo_Third.Items.Add(oSpread.ActiveSheet.ColumnHeader.Cells.Get(0, iCol).Text + Strings.Space(100) + iCol);
					}					
				}		
				
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_ColSort Error : " + ex.Message), "", "");
			}
			
		}
		
        /// <summary>
        /// ����LockType����Spread����������
        /// oSpread��Spread����
        /// ColNum��������
        /// LockType���Ƿ�������true/false��
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="ColNum"></param>
        /// <param name="LockType"></param>
		public void Gp_Sp_ColLock(FpSpread oSpread, int ColNum, bool LockType)
		{
            oSpread.ActiveSheet.Columns[ColNum].Locked = LockType;
		}
		
	
        /// <summary>
        /// δ�á�
        /// </summary>
        /// <param name="Proc_Sc"></param>
        /// <param name="Sc"></param>
        /// <returns></returns>
        public bool Gf_Sp_Change(Collection Proc_Sc, Collection Sc)
        {
            bool returnValue = false;
            FpSpread Proc_Spread = (FpSpread)((Collection)Proc_Sc["Sc"])["Spread"];
            FpSpread Sc_Spread = (FpSpread)(Sc["Spread"]);
            string sMesg;
            if (Proc_Spread.Name == Sc_Spread.Name)
            {
                returnValue = true;
            }
            return returnValue;
        }
			

            /// <summary>
            /// δ��
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="iRow"></param>
			public void Gp_Sp_ClipCopy(FarPoint.Win.Spread.FpSpread oSpread, int iRow)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;				
				if (with_1.ActiveSheet.RowCount < 1)
				{
					return;
				}
				else
				{				
					oSpread.Sheets[0].CopyRange(iRow, 0, iRow, oSpread.ActiveSheet.ColumnCount - 1, 1, oSpread.ActiveSheet.ColumnCount, true);					
				}
				
			}
			
			
            /// <summary>
            /// δ�á�
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="iRow"></param>
			public void Gp_Sp_ClipPaste(object oSpread, long iRow)
			{								
				
			}
			
			
            /// <summary>
            /// δ�á�
            /// </summary>
            /// <param name="Sc"></param>
			public void Gp_Sp_Copy(Collection Sc)
			{
                FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
                Gp_Sp_ClipCopy(oSpread, oSpread.ActiveSheet.ActiveRowIndex);				
			}
			
		
            /// <summary>
            /// δ�á�
            /// </summary>
            /// <param name="Sc"></param>
			public void Gp_Sp_Paste(Collection Sc)
			{
                FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];

                if (oSpread.ActiveSheet.RowCount > 0)
				{

                    Gp_Sp_InsertRow(oSpread, oSpread.ActiveSheet.ActiveRowIndex, "Input");
					for (int i = 1; i <= ((Collection)Sc["lColumn"]).Count; i++)
					{
                        Gp_Sp_ColLock(oSpread,int.Parse( ((Collection)Sc["lColumn"])[i].ToString()), false);
					}

                    Gp_Sp_ClipPaste(oSpread, oSpread.ActiveSheet.ActiveRowIndex + 1);
					for (int i = 1; i <= ((Collection)Sc["lColumn"]).Count; i++)
					{
                        Gp_Sp_ColLock(oSpread,int.Parse( ((Collection)Sc["lColumn"])[i].ToString()), true);
					}
                    oSpread.ActiveSheet.SetRowHeight(oSpread.ActiveSheet.ActiveRowIndex, ssRowHeight);
					//Call Gp_Sp_ActiveCell(Sc.Item("Spread"), Sc.Item("First"))
                    Gp_Sp_ActiveCell(oSpread, oSpread.ActiveSheet.ActiveColumnIndex, oSpread.ActiveSheet.ActiveRowIndex);
				}
				
			}
			
            /// <summary>
            /// ���������ɾ����ťʱ���ڵ�ǰSc��Spread�ĵ�ǰ�б�ʾ��ɾ������־��
            /// Sc��Sc���ϡ�
            /// </summary>
            /// <param name="Sc"></param>
			public void Gp_Sp_Del(Collection Sc)
			{

                FarPoint.Win.Spread.FpSpread xx = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				
				if (xx.ActiveSheet.Rows.Count == 0)
				{
					return;
				}
				if (xx.ActiveSheet.SelectionCount == 0)
				{
					if (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text) == "")
					{
                        xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text = "ɾ��";
						
					}
                    else if (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text) == "����")
					{
						xx.ActiveSheet.Rows.Get(xx.ActiveSheet.ActiveRowIndex).Remove();
					}
					
				}
				else
				{
					FarPoint.Win.Spread.Model.CellRange cr;
					cr = xx.ActiveSheet.GetSelection(0);
					int iRowcount = cr.Row + cr.RowCount - 1;
					if (xx.ActiveSheet.RowCount < 1)
					{
						return;
					}
					
					for (int i = cr.Row; i <= iRowcount; i++)
					{
						
						if (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text) == "")
						{
                            xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = "ɾ��";
							
						}
                        else if (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text) == "����")
						{
							xx.ActiveSheet.Rows.Remove(i, 1);
							i--;							
							iRowcount--;
						}
						else
						{
							
						}
						if (i == iRowcount)
						{
							break;
						}
					}
					
				}
				
				
				
			}
			
	
            /// <summary>
            ///  δ��
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="Mode"></param>
			public void Gp_Sp_UpdateMark(FarPoint.Win.Spread.FpSpread oSpread, bool Mode)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				
				if (with_1.ActiveSheet.RowCount < 0)
				{
					return;
				}
				
				if (Mode)
				{
					if (Strings.Trim((string) (with_1.ActiveSheet.Cells.Get(with_1.ActiveSheet.ActiveRowIndex, with_1.ActiveSheet.ActiveColumnIndex).Tag)) != Strings.Trim(with_1.ActiveSheet.Cells.Get(with_1.ActiveSheet.ActiveRowIndex, with_1.ActiveSheet.ActiveColumnIndex).Text))
					{
						//.Col = 0
						switch (Strings.Trim(with_1.ActiveSheet.RowHeader.Cells.Get(with_1.ActiveSheet.ActiveRowIndex, 0).Text))
						{
                            case "����":
                            case "�޸�":
                            case "ɾ��":
								break;
							default:
                                with_1.Text = "�޸�";
								break;
						}
					}
				}
				else
				{
					with_1.Tag = with_1.Text;
				}				
			}
			

            /// <summary>
            /// δ��
            /// </summary>
            /// <param name="oSpread"></param>
			public void Gp_Sp_EventMark(object oSpread)
			{
				
			}
			
            /// <summary>
            /// ����ǰ��Spread�������������޸ġ�ɾ����ȡ��
            /// ������ȡ����ǰ��
            /// �޸ģ����²�ѯ
            /// ɾ����ɾ��
            /// </summary>
            /// <param name="Conn"></param>
            /// <param name="Sc"></param>
			public void Gp_Sp_Cancel(ADODB.Connection Conn, Collection Sc)
			{
				
				string sQuery;
                FarPoint.Win.Spread.FpSpread xx = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				try
				{
					if (xx.ActiveSheet.RowCount == 0)
					{
						return;
					}
					
					Cursor.Current = Cursors.WaitCursor;
					
					
					if (xx.ActiveSheet.RowCount < 0)
					{
						Cursor.Current = Cursors.Default;
						return;
					}
					
					if (xx.ActiveSheet.SelectionCount == 0)
					{
						
						
						switch (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text))
						{

                            case "����":
								Gp_Sp_DeleteRow(xx, xx.ActiveSheet.ActiveRowIndex);
								break;

                            case "ɾ��":
								//.ActiveSheet.RowHeader.Cells.Get(.ActiveSheet.ActiveRowIndex, 0).Text = .ActiveSheet.ActiveRowIndex + 1
								xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text = "";
								break;
                            case "�޸�":
								sQuery = Gf_Sp_MakeQuery(xx, (string) (Sc["P-O"]), "O", (Collection)Sc["pColumn"], xx.ActiveSheet.ActiveRowIndex);
								Gp_Sp_OneRowDisplay(Conn, sQuery, xx, xx.ActiveSheet.ActiveRowIndex);
								//.ActiveSheet.RowHeader.Cells.Get(.ActiveSheet.ActiveRowIndex, 0).Text = .ActiveSheet.ActiveRowIndex + 1
								xx.ActiveSheet.RowHeader.Cells.Get(xx.ActiveSheet.ActiveRowIndex, 0).Text = "";
								break;
							default:
								break;
								
						}
						
					}
					else
					{
						FarPoint.Win.Spread.Model.CellRange cr;
						cr = xx.ActiveSheet.GetSelection(0);
						int iRowcount = cr.Row + cr.RowCount - 1;
						for (int i = cr.Row; i <= iRowcount; i++)
						{
							switch (Strings.Trim(xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text))
							{

                                case "����":
									Gp_Sp_DeleteRow(xx, i);
									i--;
									
									iRowcount--;
									break;
                                case "ɾ��":
									//.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = i + 1
									xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = "";
									break;
                                case "�޸�":
									sQuery = Gf_Sp_MakeQuery(xx, (string) (Sc["P-O"]), "O",(Collection)Sc["pColumn"], i);
									Gp_Sp_OneRowDisplay(Conn, sQuery, xx, i);
									//.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = i + 1
									xx.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = "";
									break;
								default:
									break;
									
							}
							if (i == iRowcount)
							{
								break;
							}
						}
					}
					
					
					
					
					Cursor.Current = Cursors.Default;
					
				}
				catch (Exception ex)
				{
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_Cancel Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
				}
				
			}
			
			
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Conn"></param>
			/// <param name="Sc"></param>
			/// <param name="rowid"></param>
			public void Gp_Sp_Cancel(ADODB.Connection Conn, Collection Sc, int rowid)
			{
				
				string sQuery;
				int iRow;
                FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				
				try
				{
					Collection with_1 = Sc;
                    if (oSpread.Sheets[0].RowCount == 0)
					{
						return;
					}
					iRow = rowid;
					Cursor.Current = Cursors.WaitCursor;
                    if (oSpread.ActiveSheet.RowCount < 0)
					{
						Cursor.Current = Cursors.Default;
						return;
					}

                    switch (Strings.Trim((string)(oSpread.ActiveSheet.RowHeader.Cells.Get(iRow, 0).Text)))
					{

                        case "����":
                            Gp_Sp_DeleteRow(oSpread, iRow);
							break;							
                        case "ɾ��":
                            oSpread.ActiveSheet.RowHeader.Cells.Get(iRow, 0).Text = (iRow + 1).ToString();
							break;
                        case "�޸�":
                            sQuery = Gf_Sp_MakeQuery(oSpread, (string)(with_1["P-O"]), "O", (Collection)Sc["pColumn"], iRow);
                            Gp_Sp_OneRowDisplay(Conn, sQuery, oSpread, iRow);
                            oSpread.ActiveSheet.RowHeader.Cells.Get(iRow, 0).Text = (iRow + 1).ToString();
							break;							
						default:
							break;
					}
										
					Cursor.Current = Cursors.Default;					
				}
				catch (Exception ex)
				{
					GeneralCommon.Gp_MsgBoxDisplay((string)("Gp_Sp_Cancel Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
				}
				
			}
			
			
            /// <summary>
            ///  ���������ַ���sQuery��sQuery����Gf_Sp_ExecQuery��Gf_Ms_Display������ʵ����ɾ�Ĳ顣
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="ProcedureName"></param>
            /// <param name="iType"></param>
            /// <param name="QueryColumn"></param>
            /// <param name="iRow"></param>
            /// <returns></returns>
			public string Gf_Sp_MakeQuery(FarPoint.Win.Spread.FpSpread oSpread, string ProcedureName, string iType, Collection QueryColumn, int iRow)
			{
				string returnValue;
				
				int iCount;
				string sQuery;
				string sTemp;
				double dTempFloat;
				double dTempInt;
				int iCol;
				
				try
				{
					FarPoint.Win.Spread.FpSpread with_1 = oSpread;
					
					if (iType == "R" || iType == "O")
					{
						sQuery = "{call " + ProcedureName + " ( ";
					}
					else
					{
						sQuery = "{call " + ProcedureName + " ( \'" + iType + "\',";
					}
					
					for (iCount = 1; iCount <= QueryColumn.Count; iCount++)
					{
						
						iCol = System.Convert.ToInt32(QueryColumn[iCount]);

                        string sCellText = "";
                        string sValue = "";
                        try
                        {
                          sCellText = with_1.ActiveSheet.Cells.Get(iRow, iCol).Tag.ToString();
                        }
                        catch { }
                        
                        try
                        {
                          sValue = with_1.ActiveSheet.Cells.Get(iRow, iCol).Value.ToString();
                        }
                        catch { }
						if ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "N")
						{
							if (sCellText.Trim() == "")
							{
								sQuery += "0,";
							}
							else
							{
								dTempFloat = double.Parse(sCellText);
                                sQuery += dTempFloat.ToString() + ",";
							}
						}
						else if ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "C")
						{
							if (sCellText == "1")
							{
								sQuery += "\'1\',";
							}
							else
							{
								sQuery += "\'0\',";
							}
						}
						else if ((((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "ON") || ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "OM")) || ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "OE"))
						{
							try
							{
								sQuery += "\'" + sValue.Trim() + "\',";
							}
							catch (Exception)
							{
								sQuery += "\'" + sCellText.Trim() + "\',";
							}
						}
						else if ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "T")
						{
							if (sCellText.Trim() == "")
							{
								sQuery += "\'\',";
							}
							else
							{
								sQuery += (string) ("\'" + sCellText.Trim().Substring(0, 2) + sCellText.Trim().Substring(3, 2) + (sCellText.Trim().Substring(6, 2) + "\',"));
							}
						}
						else if ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "D")
						{
							if (sCellText.Trim() == "")
							{
								sQuery += "\'\',";
							}
							else
							{
								sQuery += (string) ("\'" + sCellText.Trim().Substring(0, 4) + sCellText.Trim().Substring(5, 2) + (sCellText.Trim().Substring(8, 2) + "\',"));
							}
						}
						else if ((string) (with_1.ActiveSheet.Columns.Get(iCol).Tag) == "DT")
						{
							if (sCellText.Trim() == "")
							{
								sQuery += "\'\',";
							}
							else
							{
								sQuery += (string) ("\'" + sCellText.Trim().Substring(0, 4) + sCellText.Trim().Substring(5, 2) + sCellText.Trim().Substring(8, 2) + sCellText.Trim().Substring(11, 2) + sCellText.Trim().Substring(14, 2) + (sCellText.Trim().Substring(17, 2) + "\',"));
							}
						}
						else
						{
							sTemp = sCellText.Replace("\'", "\'\'");
							sQuery += "\'" + sTemp.Trim() + "\',";
						}
						
					}
					
					if (iType == "R" || iType == "O")
					{
						sQuery = (string) (sQuery.Substring(0, sQuery.Length - 1) + ")}");
					}
					else
					{
						sQuery += "?,?)}";
					}
										
					returnValue = sQuery;					
					Debug.WriteLine(sQuery);					
				}
				catch (Exception ex)
				{
					returnValue = "FAIL";
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_MakeQuery Error : " + ex.Message), "", "");
				}
				
				return returnValue;
			}
			

            /// <summary>
            /// ����sQuery�ַ��������ú�̨�����������в�ѯ��
            /// </summary>
            /// <param name="Conn"></param>
            /// <param name="sQuery"></param>
            /// <param name="oSpread"></param>
            /// <param name="iRow"></param>
			public void Gp_Sp_OneRowDisplay(ADODB.Connection Conn, string sQuery, FarPoint.Win.Spread.FpSpread oSpread, int iRow)
			{
				
				long lCount;
				int iColcount;
				string sSpreadClip;
				ADODB.Recordset AdoRs;				
				AdoRs = new ADODB.Recordset();
				if (Conn.State == 0)
				{
					if (GeneralCommon.GF_DbConnect() == false)
					{
						return;
					}
				}
				
				try
				{
					FarPoint.Win.Spread.FpSpread with_1 = oSpread;
					
					if (iRow == -1)
					{
						lCount = with_1.ActiveSheet.ActiveRowIndex;
					}
					else
					{
						lCount = iRow;
					}
															
					for (int i = 0; i <= with_1.ActiveSheet.ColumnCount - 1; i++)
					{
						with_1.ActiveSheet.Cells.Get(iRow, i).Text = "";
						with_1.ActiveSheet.Cells.Get(iRow, i).Tag = "";
						with_1.ActiveSheet.Cells.Get(iRow, i).Value = "";
					}
					AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset,ADODB.LockTypeEnum.adLockReadOnly, -1);
					
					if (! AdoRs.BOF && ! AdoRs.EOF)
					{
						
						if (! AdoRs.EOF)
						{							
							sSpreadClip = "";
												
							for (iColcount = 0; iColcount <= with_1.ActiveSheet.ColumnCount - 1; iColcount++)
							{
								sSpreadClip = (string) (AdoRs.Fields[iColcount].Value.ToString());
								switch (with_1.ActiveSheet.Columns[iColcount].Tag.ToString().Trim())
								{
									case "ON":
									case "OM":
									case "OE":
										with_1.ActiveSheet.Cells[iRow, iColcount].CellType = null;
										with_1.ActiveSheet.Cells[iRow, iColcount].Tag = sSpreadClip;
										with_1.ActiveSheet.Cells[iRow, iColcount].Value = sSpreadClip;
										break;
									case "D":
										string day = sSpreadClip;
										if (day.Length == 8)
										{
											day = (string) (day.Substring(0, 4) + "-" + day.Substring(4, 2) + "-" + day.Substring(6, 2));
										}
										with_1.ActiveSheet.Cells[iRow, iColcount].Tag = day;
										with_1.ActiveSheet.Cells[iRow, iColcount].Value = day;
										with_1.ActiveSheet.Cells[iRow, iColcount].Text = day;
										break;
									case "T":
										string time = sSpreadClip;
										with_1.ActiveSheet.Cells[iRow, iColcount].Tag = time;
										with_1.ActiveSheet.Cells[iRow, iColcount].Value = time;
										with_1.ActiveSheet.Cells[iRow, iColcount].Text = time;
										break;
									case "DT":
										string datetime = sSpreadClip;
										if (datetime.Length == 14)
										{
											datetime = (string) (datetime.Substring(0, 4) + "-" + datetime.Substring(4, 2) + "-" + datetime.Substring(6, 2) + " " + datetime.Substring(8, 2) + ":" + datetime.Substring(10, 2) + ":" + datetime.Substring(12, 2));
										}
										with_1.ActiveSheet.Cells[iRow, iColcount].Tag = datetime;
										with_1.ActiveSheet.Cells[iRow, iColcount].Value = datetime;
										with_1.ActiveSheet.Cells[iRow, iColcount].Text = datetime;
										break;
									default:
										with_1.ActiveSheet.Cells[iRow, iColcount].Tag = sSpreadClip;
										with_1.ActiveSheet.Cells[iRow, iColcount].Value = sSpreadClip;
										with_1.ActiveSheet.Cells[iRow, iColcount].Text = sSpreadClip;
										break;
										
								}								
							}							
						}						
					}
										
					AdoRs.Close();
					AdoRs = null;
					
				}
				catch (Exception ex)
				{
					AdoRs = null;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_OneRowDisplay Error : " + ex.Message), "", "");
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}					
				}				
			}

            /// <summary>
            /// δ��
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="StartRow"></param>
            /// <param name="EndRow"></param>
            /// <param name="StartCol"></param>
            /// <param name="EndCol"></param>
            /// <param name="color"></param>
            public void SetLockColor(FarPoint.Win.Spread.FpSpread oSpread, int StartRow, int EndRow, int StartCol, int EndCol, Color color)
            {
                for (int i = StartRow; i <= EndRow; i++)
                    for (int j = StartCol; j <= EndCol; j++)
                    {
                        oSpread.ActiveSheet.Cells[i, j].Locked = false;
                        oSpread.ActiveSheet.Cells[i, j].BackColor = color;
                        oSpread.ActiveSheet.Cells[i, j].Locked = true;
                    }            
            }

            //'JIA
            /// <summary>
            /// δ��
            /// </summary>
            /// <param name="oSpread"></param>
            /// <param name="sQuery"></param>
            /// <param name="lColumn"></param>
            /// <param name="MsgChk"></param>
            /// <returns></returns>
            public object Gf_Sp_DoQuery(FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
			{
				object returnValue;
				System.Windows.Forms.Cursor cur = System.Windows.Forms.Cursor.Current;
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				
				DataSet ds = new Query(sQuery).CreateDataSet(false);
				
				oSpread.ActiveSheet.DataSource = ds.Tables[0];
				
				returnValue = true;
				
				System.Windows.Forms.Cursor.Current = cur;
				return returnValue;
			}
           
		
            /// <summary>
            /// ���ô���Ĳ���sQuery���в�ѯ����
            /// </summary>
            /// <param name="Conn"></param>
            /// <param name="oSpread"></param>
            /// <param name="sQuery"></param>
            /// <param name="lColumn"></param>
            /// <param name="MsgChk"></param>
            /// <returns></returns>
			public bool Gf_Sp_Display(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
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
					
					if (oSpread.ActiveSheet.RowCount > 0)
					{
						//
                        //'Hux,�޸ġ�
                        //'���:Spread����������ʱ�������ͷ������ٵ��Spread���룬Spread�����ʱ����
						oSpread.ActiveSheet.AutoSortColumn(0);
						oSpread.ActiveSheet.RowCount = 0;
					}
					
					FarPoint.Win.Spread.FpSpread with_1 = oSpread;
					
					iCount = 0;
					
					Cursor.Current = Cursors.WaitCursor;
                    /////////20130606begin�������ʧ�ܺ󣬵�һ�β�ѯ��ʾ������������������
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
                            GeneralCommon.Gp_MsgBoxDisplay("�޷��ҵ�������..!!!", "I", "");
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
                    with_1.ActiveSheet.RowCount = RsRowCount;
                   
                  
					for (iRowCount = 0; iRowCount <= with_1.ActiveSheet.RowCount - 1; iRowCount++)
					{
                        with_1.ActiveSheet.Rows[iRowCount].Resizable = false;
						
						for (iColcount = 0; iColcount <= with_1.ActiveSheet.ColumnCount - 1; iColcount++)
						{
							switch (with_1.ActiveSheet.Columns[iColcount].Tag.ToString().Trim())
							{
								case "ON":
								case "OM":
								case "OE":
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Tag = ArrayRecords[iRowCount,iColcount].ToString();
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Value = ArrayRecords[iRowCount,iColcount].ToString();
									break;
								case "D":
									string day = "";
									if (ArrayRecords[iRowCount,iColcount] == null)
									{
									}
									else
									{
										day = ArrayRecords[iRowCount,iColcount].ToString();
									}
									if (day.Length == 8)
									{
										day = (string) (day.Substring(0, 4) + "-" + day.Substring(4, 2) + "-" + day.Substring(6, 2));
									}
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Tag = day;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Value = day;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Text = day;
									break;
								case "T":
									string time = (string) (ArrayRecords[iRowCount,iColcount].ToString());
									if (time.Length == 6)
									{
										time = (string) (time.Substring(0, 2) + ":" + time.Substring(2, 2) + ":" + time.Substring(4, 2));
									}
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Tag = time;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Value = time;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Text = time;
									break;
								case "DT":
									string datetime = ArrayRecords[iRowCount,iColcount].ToString();
									if (datetime.Length == 14)
									{
										datetime = (string) (datetime.Substring(0, 4) + "-" + datetime.Substring(4, 2) + "-" + datetime.Substring(6, 2) + " " + datetime.Substring(8, 2) + ":" + datetime.Substring(10, 2) + ":" + datetime.Substring(12, 2));
									}
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Tag = datetime;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Value = datetime;
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Text = datetime;
									break;
								default:
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Tag = ArrayRecords[iRowCount,iColcount].ToString();
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Value = ArrayRecords[iRowCount,iColcount].ToString();
									with_1.ActiveSheet.Cells[iRowCount, iColcount].Text = ArrayRecords[iRowCount,iColcount].ToString();
									break;
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
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_Display Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
				}
				
				return returnValue;
			}
			
			
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Conn"></param>
            /// <param name="Sc"></param>
            /// <param name="Mc"></param>
            /// <param name="nCheckControl"></param>
            /// <param name="mCheckControl"></param>
            /// <param name="MsgChk"></param>
            /// <returns></returns>
			public bool Gf_Sp_Refer(ADODB.Connection Conn, Collection Sc, Collection Mc, Collection nCheckControl, Collection mCheckControl, bool MsgChk)
			{
				bool returnValue;
                FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				
				MasterCommon MasterCommon = new MasterCommon();

				string sMsg;
				
				try
				{
					if (Mc != null)
					{
						
						if (nCheckControl != null)
						{
							sMsg = MasterCommon.Gf_Ms_NeceCheck(nCheckControl);
							if (sMsg != "OK")
							{
                                sMsg = "�������� " + sMsg.Trim() + "...!!!";
								GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "");
								returnValue = false;
								return returnValue;
							}
						}
						
						if (mCheckControl != null)
						{
							sMsg = MasterCommon.Gf_Ms_NeceCheck2(mCheckControl);
							if (sMsg != "OK")
							{
                                sMsg = "�������Ŀ������� " + sMsg.Trim() + " �ĳ���..!!!";
								GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "");
								returnValue = false;
								return returnValue;
							}
						}
						
					}
					
					if (Mc != null)
					{
                        
                        returnValue = Gf_Sp_Display(Conn, oSpread, MasterCommon.Gf_Ms_MakeQuery((string)(Sc["P-R"]), "R", (Collection)Mc["pControl"]), (Collection)Sc["pColumn"], MsgChk);
						
						if (returnValue)
						{
							MasterCommon.Gp_Ms_ControlLock((Collection)Mc["lControl"], true);
						}
					}
					else
					{
                        returnValue = Gf_Sp_Display(Conn, oSpread, Gf_Sp_MakeQuery(oSpread, (string)(Sc["P-R"]), "R", (Collection)Sc["aColumn"], 0), (Collection)Sc["pColumn"], MsgChk);
					}
					
					if (returnValue)
					{

					}
					
				}
				catch (Exception ex)
				{
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_Refer Error : " + ex.Message), "", "");
				}
				
				return returnValue;
			}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Conn"></param>
		/// <param name="oSpread"></param>
		/// <param name="sQuery"></param>
		/// <param name="lColumn"></param>
		/// <param name="MsgChk"></param>
		/// <returns></returns>
			public bool test(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, Collection lColumn, bool MsgChk)
			{
				bool returnValue=false;
				
				int iCount;
				int iRowCount;
				int iColcount;
				string sSpreadClip;
				object ArrayRecords;
				ADODB.Recordset AdoRs;
				
				if (Conn.State == 0)
				{
					if (GeneralCommon.GF_DbConnect() == false)
					{
						returnValue = false;
					}
					return returnValue;
				}
				
				AdoRs = new ADODB.Recordset();
				
				string x = oSpread.Name;
				
				try
				{
					
					returnValue = true;
					
					if (oSpread.ActiveSheet.RowCount > 0)
					{
						oSpread.ActiveSheet.RowCount = 0;
					}
										
				}
				catch (Exception ex)
				{
					AdoRs = null;
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_Display Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
				}
				
				return returnValue;
			}
			
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Sc"></param>
        /// <param name="Mc"></param>
        /// <param name="RefChek"></param>
        /// <returns></returns>
			public bool Gf_Sp_Process(ADODB.Connection Conn, Collection Sc, Collection Mc, bool RefChek)
			{
                /////////////////////////20130516
                bool isMessage = true;
                /////////////////////////20130516
                bool returnValue = false;
				
				MasterCommon MasterCommon = new MasterCommon();
				
				int iCol;
				int iCount;
                int iProcessCount = 0;
				int ret_Result_ErrCode;
				string ret_Result_ErrMsg;
				
				double dTempInt;
				double dTempFloat;
				
				string sMesg;
				string sTemp;
				string ProcessChk;
				
				ADODB.Command adoCmd;
				FarPoint.Win.Spread.FpSpread ss;
				string stestsql = "";
                ss = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				
				returnValue = true;

				if (ss.ActiveSheet.RowCount < 1 || ss.ActiveSheet.ColumnCount == 0)
				{
					returnValue = false;
					return returnValue;
				}
				
				Cursor.Current = Cursors.WaitCursor;
				
				try
				{
					for (iCount = 0; iCount <= ss.ActiveSheet.RowCount - 1; iCount++)
					{
						
						switch (Strings.Trim(ss.ActiveSheet.RowHeader.Cells.Get(iCount, 0).Text))
						{
                            case "����":
                            case "�޸�":
								
								if (Mc != null)
								{
									Gp_Sp_Move(iCount, Sc, Mc);
								}
								
								sMesg = Gf_Sp_NeceCheck2(ss, (Collection)Sc["mColumn"], iCount, (Collection)Sc["nColumn"]);
								
								if (sMesg.Trim() == "OK")
								{
									
								}
								else if(sMesg.Length>=5)
								{
                                    if (sMesg.Substring(0, 5) == "FALSE")
                                    {
                                        ss.ActiveSheet.ActiveRowIndex = iCount;
                                        sMesg = sMesg.Substring(5, sMesg.Length);
                                        sMesg = "�������Ŀ������� " + sMesg.Trim() + " �ĳ���..!!!";
                                        GeneralCommon.Gp_MsgBoxDisplay(sMesg, "I", "");
                                        Cursor.Current = Cursors.Default;
                                        adoCmd = null;
                                        returnValue = false;
                                        return returnValue;
                                    }
								}
								else
								{
									ss.ActiveSheet.ActiveRowIndex = iCount;
                                    sMesg = "�������� " + sMesg.Trim() + " ...!!!";
									GeneralCommon.Gp_MsgBoxDisplay(sMesg, "I", "");
									Cursor.Current = Cursors.Default;
									adoCmd = null;
									returnValue = false;
									return returnValue;
								}
								break;
								
						}
						
					}
					if (Conn.State == 0)
					{
						if (GeneralCommon.GF_DbConnect() == false)
						{
                            return false;
						}
						
					}
					
					Conn.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
					adoCmd = new ADODB.Command();
					
					adoCmd.ActiveConnection = Conn;
					adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
					adoCmd.CommandText = (string) (Sc["P-M"]);
					
					Conn.BeginTrans();
					for (iCount = 0; iCount <= ((Collection)Sc["iColumn"]).Count; iCount++)
					{
						adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput));
					}
					adoCmd.Parameters.Append(adoCmd.CreateParameter("Error", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamOutput, 0, null));
					adoCmd.Parameters.Append(adoCmd.CreateParameter("Messg", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamOutput, 0, null));
					
					for (iCount = 0; iCount <= ss.ActiveSheet.RowCount - 1; iCount++)
					{
						
						ProcessChk = "NO";
						
						switch (Strings.Trim(ss.ActiveSheet.RowHeader.Cells.Get(iCount, 0).Text))
						{

                            case "����":
								adoCmd.Parameters[0].Value = "I";
								ProcessChk = "YES";
								break;

                            case "�޸�":
								adoCmd.Parameters[0].Value = "U";
								ProcessChk = "YES";
								break;

                            case "ɾ��":
								adoCmd.Parameters[0].Value = "D";
								ProcessChk = "YES";
								break;
								
						}
						
						if (ProcessChk == "YES")
						{
                            //////////////////////////
                            /////////////////////////////20130516
                            if ((adoCmd.Parameters[0].Value.ToString() == "I") && isMessage)
                            {
                                if (!GeneralCommon.Gf_MessConfirm("�Ƿ��������ݣ�", "I", "��ʾ"))
                                {
                                    isMessage = false;

                                    adoCmd = null;
                                    Conn.RollbackTrans();
                                    returnValue = false;

                                    return false;
                                }
                                else
                                {
                                    isMessage = false;
                                }
                            }
                            if ((adoCmd.Parameters[0].Value.ToString() == "U") && isMessage)
                            {
                                if (!GeneralCommon.Gf_MessConfirm("�Ƿ��޸����ݣ�", "I", "��ʾ"))
                                {
                                    isMessage = false;

                                    adoCmd = null;
                                    Conn.RollbackTrans();
                                    returnValue = false;

                                    return false;
                                }
                                else
                                {
                                    isMessage = false;
                                }
                            }
                            if ((adoCmd.Parameters[0].Value.ToString() == "D") && isMessage)
                            {
                                if (!GeneralCommon.Gf_MessConfirm("�Ƿ�ɾ�����ݣ�", "I", "��ʾ"))
                                {
                                    isMessage = false;

                                    adoCmd = null;
                                    Conn.RollbackTrans();
                                    returnValue = false;

                                    return false;
                                }
                                else
                                {
                                    isMessage = false;
                                }
                            }
                            /////////////////////////////
                            //////////////////////////
							for (iCol = 1; iCol <= ((Collection)Sc["iColumn"]).Count; iCol++)
							{
								int iColumn = System.Convert.ToInt32(((Collection)Sc["iColumn"])[iCol]);
								string sText = ss.ActiveSheet.Cells.Get(iCount, iColumn).Text;
                                string sValue = "";
                                if (ss.ActiveSheet.Cells.Get(iCount, iColumn).Value != null)
                                {
                                    sValue = ss.ActiveSheet.Cells.Get(iCount, iColumn).Value.ToString();
                                }
								
								switch (Strings.Trim((string) (ss.ActiveSheet.Columns[iColumn].Tag)))
								{
									
									case "N":
										if (sText == "")
										{
											adoCmd.Parameters[iCol].Value = sText;
										}
										else
										{
											dTempInt = double.Parse(sText);
											adoCmd.Parameters[iCol].Value = (dTempInt).ToString();
										}
										break;
										
									case "C":
                                        if (sValue == "True" || sValue == "1")
										{
											adoCmd.Parameters[iCol].Value = "1";
										}
										else
										{
											adoCmd.Parameters[iCol].Value = "0";
										}
										break;
										
									case "ON":
									case "OE":
									case "OM":
										
										if (sValue == null)
										{
											adoCmd.Parameters[iCol].Value = "";
										}
										else
										{
											adoCmd.Parameters[iCol].Value = sValue;
										}
										break;
										
                                    //case "T":
                                    //    if (sText == "")
                                    //    {
                                    //        adoCmd.Parameters[iCol].Value = "";
                                    //    }
                                    //    else
                                    //    {
                                    //        adoCmd.Parameters[iCol].Value = sText.Substring(0, 2) + sText.Substring(3, 2) + sText.Substring(6, 2);
                                    //    }
                                    //    break;
                                    /////20130620YDK
                                    case "T":
                                        if (sText == "")
                                        {
                                            adoCmd.Parameters[iCol].Value = "";
                                        }
                                        else
                                        {
                                            sText = sText.Replace("-", "").Replace(" ", "").Replace(":", "");
                                            if (sText.Length != 6)
                                            {
                                                sText = "0" + sText;
                                            }
                                            adoCmd.Parameters[iCol].Value = sText;
                                        }
                                        break;
										
									case "D":
										if (sText == "")
										{
											adoCmd.Parameters[iCol].Value = "";
										}
										else
										{
											adoCmd.Parameters[iCol].Value = sText.Substring(0, 4) + sText.Substring(5, 2) + sText.Substring(8, 2);
										}
										break;
                                    //case "DT":
                                    //    if (sText == "")
                                    //    {
                                    //        adoCmd.Parameters[iCol].Value = "";
                                    //    }
                                    //    else
                                    //    {
                                    //        adoCmd.Parameters[iCol].Value = sText.Substring(0, 4) + sText.Substring(5, 2) + sText.Substring(8, 2) + sText.Substring(11, 2) + sText.Substring(14, 2) + sText.Substring(17, 2);
                                    //    }
                                    //    break;
                                    ////////////////////////20130508
                                    case "DT":
                                        if (sText == "")
                                        {
                                            adoCmd.Parameters[iCol].Value = "";
                                        }
                                        else
                                        {
                                            sText = sText.Replace("-", "").Replace(" ", "").Replace(":", "");
                                            if (sText.Length == 13)
                                            {
                                                string temp = sText.Substring(0, 8);
                                                string temp2 = sText.Substring(8, 5);
                                                sText = temp + "0" + temp2;
                                            }
                                            adoCmd.Parameters[iCol].Value = sText;
                                            //adoCmd.Parameters[iCol].Value = sText.Substring(0, 4) + sText.Substring(5, 2) + sText.Substring(8, 2) + sText.Substring(11, 2) + sText.Substring(14, 2) + sText.Substring(17, 2);
                                        }
                                        break;
                                        ////////////////////////20130508
										
									case "P":
										adoCmd.Parameters[iCol].Value = sValue;
										break;
									default:
										sTemp = sText.Trim().Replace("\'", "\'\'");
										adoCmd.Parameters[iCol].Value = sTemp.Trim();
										break;
										
								}
								
							}
							
							iProcessCount++;
                            ////1019
                            stestsql = "";
                            if (iRecord)
                            {
                                for (int II = 0; II <= adoCmd.Parameters.Count - 1; II++)
                                {
                                    stestsql += (string)((II == 0 ? "(" : "") + adoCmd.Parameters[II].Value + (II == adoCmd.Parameters.Count - 1 ? ")" : ","));
                                }
                                stestsql = (string)(Sc["P-M"] + stestsql);
                            }
							
                            ///1019
							object null_object = null;

                            adoCmd.Execute(out null_object);



                            if (adoCmd.Parameters["Error"].Value.ToString() != "0")
                            {
                                ////////1019
                                string OP_TYPE = adoCmd.Parameters[0].Value.ToString();
                                ////////1019
                                ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["Error"].Value);
                                ret_Result_ErrMsg = (string)(adoCmd.Parameters["Messg"].Value);

                                GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);

                                ss.ActiveSheet.ActiveRowIndex = iCount;
                                GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");

                                Cursor.Current = Cursors.Default;
                                adoCmd = null;

                                Conn.RollbackTrans();
                                //////////////////1018
                                if (iRecord)
                                {
                                    //Gf_Sp_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Sc["P-M"]), adoCmd.Parameters[0].Value.ToString(), stestsql, "1", "", ret_Result_ErrMsg);
                                    Gf_Sp_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Sc["P-M"]), OP_TYPE, stestsql, "1", "", ret_Result_ErrMsg);
                                }
                                ////////////////1018
                                returnValue = false;
                                return returnValue;

                            }
                            else
                            {
                                if (iRecord)
                                {
                                    Gf_Sp_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Sc["P-M"]), adoCmd.Parameters[0].Value.ToString(), stestsql, "0", "", "");
                                }
                            }
						}						
					}
					
					Conn.CommitTrans();
                    Conn.Close();
					
					
					
					if (iProcessCount > 0)
					{
						if (Mc != null)
						{
							if (RefChek == false)
							{
                                //2012-7-23 ������ ע�ͣ�Ϊ�����޸ĺ󣬱���ɹ�����ѯ���Ϊ��ʱ������true
                                //returnValue = Gf_Sp_Display(Conn, ss, MasterCommon.Gf_Ms_MakeQuery((string) (Sc["P-R"]), "R", (Collection)Mc["pControl"]), 
                                //    (Collection)Sc["pColumn"], false);
                                Gf_Sp_Display(Conn, ss, MasterCommon.Gf_Ms_MakeQuery((string)(Sc["P-R"]), "R", (Collection)Mc["pControl"]),
                                    (Collection)Sc["pColumn"], false);
							}
						}
						else
						{
							if (RefChek == false)
							{
                                //2012-7-23 ������ ע�ͣ�Ϊ�����޸ĺ󣬱���ɹ�����ѯ���Ϊ��ʱ������true
                                //returnValue = Gf_Sp_Display(Conn, ss, Gf_Sp_MakeQuery(ss, (string) (Sc["P-R"]), 
                                //    "R", (Collection)Sc["aColumn"], 0), (Collection)Sc["pColumn"], false);
                                Gf_Sp_Display(Conn, ss, Gf_Sp_MakeQuery(ss, (string)(Sc["P-R"]),
                                    "R", (Collection)Sc["aColumn"], 0), (Collection)Sc["pColumn"], false);
							}
						}
                        GeneralCommon.GStatusBar.Panels[0].Text = " Message : " + iProcessCount + " �������Ѿ�����..!!!";
					}
					
					if (iProcessCount > 0)
					{
						if (Mc != null)
						{
							MasterCommon.Gp_Ms_ControlLock((Collection)Mc["lControl"], true);
						}
					}
					else
					{
						returnValue = false;
					}
					Cursor.Current = Cursors.Default;
				}
				catch (Exception ex)
				{
					adoCmd = null;
					Conn.RollbackTrans();
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_Process Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
				}
				
				return returnValue;
			}

  
            /// <summary>
            /// ����в��������¼��
            /// </summary>
            /// <param name="IP_ADDRESS"></param>
            /// <param name="USERID"></param>
            /// <param name="PGMID"></param>
            /// <param name="OP_TYPE"></param>
            /// <param name="OP_CONTENT"></param>
            /// <param name="OP_RLT"></param>
            /// <param name="INS_TIME"></param>
            /// <param name="ERR_DESC"></param>
            public void Gf_Sp_InsertRecord(string IP_ADDRESS, string USERID, string PGMID, string OP_TYPE, string OP_CONTENT, string OP_RLT, string INS_TIME, string ERR_DESC)
            {
                try
                {
                    string SQL = "insert into ZP_LOG (IP_ADDRESS,USERID,PGMID,OP_TYPE,OP_CONTENT,OP_RLT,ERR_DESC) values (" + "\'" + IP_ADDRESS + "\'," + "\'" + USERID + "\'," + "\'" + PGMID + "\'," + "\'" + OP_TYPE + "\'," + "\'" + OP_CONTENT + "\'," + "\'" + OP_RLT + "\'," + "\'" + ERR_DESC + "\'" + ")";
                    ADODB.Recordset AdoRs = new ADODB.Recordset();
                    if (GeneralCommon.M_CN1.State == 0)
                        if (GeneralCommon.GF_DbConnect() == false) return;
                    AdoRs.Open(SQL, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                    // GeneralCommon.Gf_ExecSql(GeneralCommon.M_CN1, SQL);
                }
                catch
                {

                }
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oSpread"></param>
        /// <param name="iRow"></param>
        /// <param name="iCol"></param>
        /// <returns></returns>
			public string Gf_Sp_NeceCheck(FarPoint.Win.Spread.FpSpread oSpread, int iRow, Collection iCol)
			{
				string returnValue="";
				
				int iCount;
				     
                oSpread.ActiveSheet.ActiveRowIndex = iRow;
				
				for (iCount = 1; iCount <= iCol.Count; iCount++)
				{
                    oSpread.ActiveSheet.ActiveColumnIndex = int.Parse(iCol[iCount].ToString());
                    string CurColCellType = oSpread.Sheets[0].Columns[iCount].CellType.ToString();

                    switch (CurColCellType)
					{
                        case "ComboBoxCellType":
                            FarPoint.Win.Spread.CellType.ComboBoxCellType ComboBoxCellType = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
                            ComboBoxCellType = (FarPoint.Win.Spread.CellType.ComboBoxCellType)oSpread.Sheets[0].Columns[iCount].CellType;
                            if (ComboBoxCellType.Editable)
							{
                                if (oSpread.Text.Trim() == "")
								{
                                    returnValue = oSpread.Text;
									return returnValue;
								}
							}
							else
							{
                                if (oSpread.Text == " ")
								{
                                    returnValue = oSpread.Text;
									return returnValue;
								}
							}
							break;
							
						case "TextCellType":
                             FarPoint.Win.Spread.CellType.TextCellType TextCellType = new FarPoint.Win.Spread.CellType.TextCellType();
                             TextCellType = (FarPoint.Win.Spread.CellType.TextCellType)oSpread.Sheets[0].Columns[iCount].CellType;
                             if (oSpread.Text.Trim().Length < TextCellType.MaxLength)
							{
                                oSpread.ActiveSheet.ActiveRowIndex = 0;
                                returnValue = oSpread.Text;
								return returnValue;
							}
							break;
                        case "DateTimeCellType":
                          
							break;
							
						default:
                            if (oSpread.Text == "")
							{
                                if (oSpread.Text.Trim() == "")
								{
                                    oSpread.ActiveSheet.ActiveRowIndex = 0;
                                    returnValue = oSpread.Text;
									return returnValue;
								}
							}
							break;
					}
				}
				
				returnValue = "OK";
				
				
				return returnValue;
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="mColumn"></param>
			/// <param name="iRow"></param>
			/// <param name="iCol"></param>
			/// <returns></returns>
			public string Gf_Sp_NeceCheck2(FarPoint.Win.Spread.FpSpread oSpread, Collection mColumn, int iRow, Collection iCol)
			{
				string returnValue;
				
				int iCount;
				int iLeng;
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				
				
				for (iCount = 1; iCount <= iCol.Count; iCount++)
				{
					int iColumn = System.Convert.ToInt32(iCol[iCount]);
					string sText = with_1.ActiveSheet.Cells[iRow, iColumn].Text;
					if ((string) (with_1.ActiveSheet.Columns.Get(iColumn).Tag) == "ON")
					{
						if (sText.Trim() == "")
						{
							returnValue = with_1.ActiveSheet.ColumnHeader.Cells.Get(0, iColumn).Text;
							
							return returnValue;
						}
					}
					else if ((((string) (with_1.ActiveSheet.Columns.Get(iColumn).Tag) == "E") || ((string) (with_1.ActiveSheet.Columns.Get(iColumn).Tag) == "D")) || ((string) (with_1.ActiveSheet.Columns.Get(iColumn).Tag) == "T"))
					{
						if (sText.Trim() == "")
						{
							returnValue = with_1.ActiveSheet.ColumnHeader.Cells.Get(0, iColumn).Text;
							
							return returnValue;
						}
					}
					else
					{
						if (sText.Trim() == "")
						{
							if (sText.Trim() == "")
							{
								returnValue = with_1.ActiveSheet.ColumnHeader.Cells.Get(0, iColumn).Text;
								
								return returnValue;
							}
						}
					}
					
				}

				for (iCount = 1; iCount <= mColumn.Count; iCount++)
				{
					
					int iColumn = System.Convert.ToInt32(mColumn[iCount]);
					string sText = with_1.ActiveSheet.Cells.Get(iRow, iColumn).Text;
                    if(sText=="TextCellType")
                    {
                        FarPoint.Win.Spread.CellType.TextCellType TextCellType= new FarPoint.Win.Spread.CellType.TextCellType();
                        TextCellType=(FarPoint.Win.Spread.CellType.TextCellType)with_1.ActiveSheet.Columns[iColumn].CellType;
                        iLeng = TextCellType.MaxLength;
                        if (sText.Trim() != "" && sText.Trim().Length < iLeng)
						{
                            if (sText.Trim() != "" && sText.Trim().Length < iLeng)
						{

							returnValue = "FALSE" + "\'" + with_1.ActiveSheet.ColumnHeader.Cells.Get(0, iColumn).Text + "\'";
							return returnValue;
						}
                        }
                    }       
					
				}
				
				
				returnValue = "OK";
				
				return returnValue;
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
            public void Gp_Sp_Excel(FarPoint.Win.Spread.FpSpread oSpread)
            {
                //List<bool> list = new List<bool>();
                ////string sSaveExcelName = "C:\\" + DateTime.Now.ToShortDateString().Replace("-", "") + DateTime.Now.ToLongTimeString().Replace(":", "") + ".xls";
                ////oSpread.SaveExcel(sSaveExcelName,FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                ////System.Diagnostics.Process.Start(sSaveExcelName);      
                //try
                //{
                //    ////////////////////////////////////////////////////20130520BEGIN
                    
                //    for (int i = 0; i < oSpread.ActiveSheet.Columns.Count; i++)
                //    {
                //        list.Add(oSpread.ActiveSheet.Columns.Get(i).Locked);
                //    }
                //    for (int i = 0; i < oSpread.ActiveSheet.Columns.Count; i++)
                //    {
                //        oSpread.ActiveSheet.Columns.Get(i).Locked = false;
                //    }
                //    ////////////////////////////////////////////////////20130520END
                //   // string sSaveExcelName = "C:\\" + DateTime.Now.ToShortDateString().Replace("-", "") + DateTime.Now.ToLongTimeString().Replace(":", "") + ".xls";
                //    string currentPath = Application.StartupPath;

                //    string currentReportPath = currentPath + "\\�ϸֿ��嵼��Excel�ļ���";
                //    if (!Directory.Exists(currentReportPath))
                //    {
                //        Directory.CreateDirectory(currentReportPath);
                //    }

                //   // string sSaveExcelName = currentReportPath + "\\" + GeneralCommon.sUsername + DateTime.Now.ToShortDateString().Replace("-", "") + DateTime.Now.ToLongTimeString().Replace(":", "") + ".xls";
                //    string temp = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'yyyymmddhh24miss') from dual");
                //    string sSaveExcelName = currentReportPath + "\\" + GeneralCommon.sUsername + temp + ".xls";
                //    oSpread.SaveExcel(sSaveExcelName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                //    ////////////////////////////////////////////////////20130520BEGIN
                //    for (int i = 0; i < oSpread.ActiveSheet.Columns.Count; i++)
                //    {
                //        oSpread.ActiveSheet.Columns.Get(i).Locked = (bool)list[i];
                //    }
                //    ////////////////////////////////////////////////////20130520END
                //    System.Diagnostics.Process.Start(sSaveExcelName);
                //}
                //catch (Exception ex)
                //{
                //    for (int i = 0; i < oSpread.ActiveSheet.Columns.Count; i++)
                //    {
                //        oSpread.ActiveSheet.Columns.Get(i).Locked = (bool)list[i];
                //    }
                //    GeneralCommon.Gp_MsgBoxDisplay(ex.Message,"W","����");
                //}    

                //////////////////////////////////////////////////////////////20131228
                bool spreadProtectType = oSpread.ActiveSheet.Protect;
                try
                {
                    oSpread.ActiveSheet.Protect = false;

                    string currentPath = Application.StartupPath;
                    string currentReportPath = currentPath + "\\�ϸֿ��嵼��Excel�ļ���";
                    if (!Directory.Exists(currentReportPath))
                    {
                        Directory.CreateDirectory(currentReportPath);
                    }
                    string temp = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'yyyymmddhh24miss') from dual");
                    string sSaveExcelName = currentReportPath + "\\" + GeneralCommon.sUsername + temp + ".xls";
                    oSpread.SaveExcel(sSaveExcelName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
                    System.Diagnostics.Process.Start(sSaveExcelName);
                }
                catch(Exception ex)
                {
                    oSpread.ActiveSheet.Protect = spreadProtectType;
                    GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(),"W","����");
                }
                /////////////////////////////////////////////////////////////20131228




            }
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="MaxCnt"></param>
            public void Gp_Sp_EvenRowBackcolor(FarPoint.Win.Spread.FpSpread oSpread, int MaxCnt)
			{
                oSpread.ActiveSheet.AlternatingRows.Count = 2;
                oSpread.ActiveSheet.AlternatingRows[0].BackColor = System.Drawing.Color.LightGreen;
                oSpread.ActiveSheet.AlternatingRows[1].BackColor = Color.FromArgb(255, 255, 255, 192);												
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="iCol"></param>
			/// <param name="Start_Row"></param>
			/// <param name="End_Row"></param>
			/// <returns></returns>
            //public int Gf_Sp_ColSum(FarPoint.Win.Spread.FpSpread oSpread, int iCol, int Start_Row, int End_Row)
            //{
            //    int returnValue=0;
				
				
            //    int dSum = 0;
            //    FarPoint.Win.Spread.SheetView with_1 = oSpread.Sheets[0];
            //    int end_row2 = End_Row;
            //    if (end_row2 == 0)
            //    {
            //        end_row2 = with_1.RowCount - 1;
            //    }
				
            //    for (int row = Start_Row; row <= end_row2; row++)
            //    {
            //        if (with_1.Cells[row, iCol].Text != "")
            //        {
            //            dSum += System.Convert.ToInt32(with_1.Cells[row, iCol].Value);
            //        }
            //    }
            //    returnValue = dSum;
            //    return returnValue;
            //}


            public double Gf_Sp_ColSum(FarPoint.Win.Spread.FpSpread oSpread, int iCol, int Start_Row, int End_Row)
            {
                double returnValue = 0;


                double dSum = 0;
                FarPoint.Win.Spread.SheetView with_1 = oSpread.Sheets[0];
                int end_row2 = End_Row;
                if (end_row2 == 0)
                {
                    end_row2 = with_1.RowCount - 1;
                }

                for (int row = Start_Row; row <= end_row2; row++)
                {
                    if (with_1.Cells[row, iCol].Text != "")
                    {
                        dSum += System.Convert.ToDouble(with_1.Cells[row, iCol].Value);
                    }
                }
                returnValue = dSum;
                return returnValue;
            }

			
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="iRow"></param>
			/// <param name="Start_Col"></param>
			/// <param name="End_Col"></param>
			/// <returns></returns>
			public int Gf_Sp_RowSum(FarPoint.Win.Spread.FpSpread oSpread, int iRow, int Start_Col, int End_Col)
			{
				int returnValue=0;
				
				int lCount=0;
				int dSum=0;

                FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				
				if (End_Col > with_1.ActiveSheet.RowCount || End_Col == 0)
				{
					End_Col = with_1.ActiveSheet.ColumnCount;
				}
				
				with_1.ActiveSheet.ActiveRowIndex = iRow;
				
				for (lCount = Start_Col; lCount <= End_Col; lCount++)
				{
					with_1.ActiveSheet.ActiveColumnIndex = lCount;
					if (with_1.Text != "")
					{
						dSum += System.Convert.ToInt32(with_1.ActiveSheet.Cells[iRow,lCount].Value);
					}
				}
				
				
				returnValue = dSum;
				
				return returnValue;
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="lColumn"></param>
			/// <param name="LockType"></param>
			public void Gp_Sp_CollectionLock(object oSpread, Collection lColumn, bool LockType)
			{
			
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Conn"></param>
			/// <param name="Sc"></param>
			/// <returns></returns>
			public bool Gf_Sp_DelProcess(ADODB.Connection Conn, Collection Sc)
			{
				bool returnValue;
				
				int iCol;
				int iCount;
				int iProcessCount;
				int ret_Result_ErrCode;
				string ret_Result_ErrMsg;
				string ProcessChk;
				double dTempFloat;
				double dTempInt;
				string sTemp;

				
				ADODB.Command adoCmd;
                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)Sc["Spread"]; 				
				returnValue = true;
				iProcessCount = 0;
				if (ss.ActiveSheet.RowCount < 1 || ss.ActiveSheet.ColumnCount == 0)
				{
					returnValue = false;
					return returnValue;
				}				
				Cursor.Current = Cursors.WaitCursor;				
				try
				{
					if (Conn.State == 0)
					{
						if (GeneralCommon.GF_DbConnect() == false)
						{
							returnValue = false;
						}
						return returnValue;
					}
					Conn.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
					adoCmd = new ADODB.Command();
					
					adoCmd.ActiveConnection = Conn;
					adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
					adoCmd.CommandText = Sc["P-M"].ToString();
					
					Conn.BeginTrans();

					for (iCount = 0; iCount <= ((Collection)Sc["iColumn"]).Count; iCount++)
					{
						adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
					}

					adoCmd.Parameters.Append(adoCmd.CreateParameter("Error", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamOutput, 0, null));
					adoCmd.Parameters.Append(adoCmd.CreateParameter("Messg", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamOutput, 0, null));
					for (iCount = 0; iCount <= ss.ActiveSheet.RowCount - 1; iCount++)
					{
						
						ProcessChk = "NO";
						
						switch (Strings.Trim(ss.ActiveSheet.RowHeader.Cells.Get(iCount, 0).Text))
						{
							
							case "Input":
								adoCmd.Parameters[0].Value = "I";
								ProcessChk = "YES";
								break;
								
						}
						
						if (ProcessChk == "YES")
						{

							for (iCol = 1; iCol <= ((Collection)Sc["iColumn"]).Count; iCol++)
							{
								int iColumn = System.Convert.ToInt32(((Collection)Sc["iColumn"])[iCol]);
								string sText = ss.ActiveSheet.Cells.Get(iCount, iColumn).Text;
								string sValue = (string) (ss.ActiveSheet.Cells.Get(iCount, iColumn).Value);
								
								switch (Strings.Trim((string) (ss.ActiveSheet.Columns[iColumn].Tag)))
								{
									
									case "N":
										if (sText == "")
										{
											adoCmd.Parameters[iCol].Value = sText;
										}
										else
										{
											dTempInt = double.Parse(sText);
											adoCmd.Parameters[iCol].Value = (dTempInt).ToString();
										}
										break;
										
									case "C":
										if (sValue == "True")
										{
											adoCmd.Parameters[iCol].Value = "1";
										}
										else
										{
											adoCmd.Parameters[iCol].Value = "0";
										}
										break;
										
									case "ON":
									case "OE":
									case "OM":
							
										if (sValue == null)
										{
											adoCmd.Parameters[iCol].Value = "";
										}
										else
										{
											adoCmd.Parameters[iCol].Value = sValue;
										}
										break;
		
									case "T":
										if (sText == "")
										{
                                            adoCmd.Parameters[iCol].Value = "";
										}
										else
										{
                                            adoCmd.Parameters[iCol].Value = sText.Substring(0, 2) + sText.Substring(3, 2) + sText.Substring(6, 2);
										}
										break;
										
									case "D":
										if (sText == "")
										{
                                            adoCmd.Parameters[iCol].Value = "";
										}
										else
										{

                                            adoCmd.Parameters[iCol].Value = sText.Substring(0, 4) + sText.Substring(5, 2) + sText.Substring(8, 2);
										}
										break;
									case "DT":
										if (sText == "")
										{
                                            adoCmd.Parameters[iCol].Value = "";
										}
										else
										{
                                            adoCmd.Parameters[iCol].Value = sText.Substring(0, 4) + sText.Substring(5, 2) + sText.Substring(8, 2) + sText.Substring(11, 2) + sText.Substring(14, 2) + sText.Substring(17, 2);
										}
										break;
										
									default:
										sTemp = sText.Trim().Replace("\'", "\'\'");
                                        adoCmd.Parameters[iCol].Value = sTemp.Trim();
										break;
										
								}

							}
							
							iProcessCount++;
                            object null_obj1 = null;
                            object null_obj2 = null;
							adoCmd.Execute(out null_obj1, ref null_obj2,-1);							
							if (adoCmd.Parameters["Error"].Value != "0")
							{								
								ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["Error"].Value);
								ret_Result_ErrMsg = (string) (adoCmd.Parameters["Messg"].Value);
								
								GeneralCommon.sErrMessg = (string) ("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
								
								ss.ActiveSheet.ActiveRowIndex = iCount;
								GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");
								
								Cursor.Current = Cursors.Default;
								adoCmd = null;
								
								Conn.RollbackTrans();
								returnValue = false;
								return returnValue;
								
							}							
						}						
					}					
					Conn.CommitTrans();
					
					Cursor.Current = Cursors.Default;
				}
				catch (Exception ex)
				{
					adoCmd = null;
					Conn.RollbackTrans();
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sp_DelProcess Error : " + ex.Message), "", "");
					Cursor.Current = Cursors.Default;
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
					
				}
				
				return returnValue;
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="iCol"></param>
			/// <param name="iRow"></param>
			/// <param name="iSheetIndex"></param>
			/// <returns></returns>
			public string Gf_Sp_RcvData(FarPoint.Win.Spread.FpSpread oSpread, int iCol, int iRow, int iSheetIndex)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				return with_1.Sheets[iSheetIndex].Cells[iRow, iCol].Text;
				
			}
			
					
	       /// <summary>
            /// ����oSpread��iCol�е����ͣ���Indataд��oSpread��Cell��iRow��iCol��
	       /// </summary>
	       /// <param name="oSpread"></param>
	       /// <param name="Indata"></param>
	       /// <param name="iCol"></param>
	       /// <param name="iRow"></param>
	       /// <param name="iSheetIndex"></param>
			public void Gp_Sp_SendData(FarPoint.Win.Spread.FpSpread oSpread, string Indata, int iCol, int iRow, int iSheetIndex)
			{
				
				switch (Strings.Trim((string) (oSpread.Sheets[iSheetIndex].Columns.Get(iCol).Tag)))
				{
					
					case "N":
						oSpread.Sheets[iSheetIndex].Cells.Get(iRow, iCol).Value = double.Parse(Indata);
						break;
					case "ON":
                        oSpread.Sheets[iSheetIndex].Cells.Get(iRow, iCol).Value = Indata;
						break;
					default:
						oSpread.Sheets[iSheetIndex].Cells.Get(iRow, iCol).Text = Indata;
						break;
				}
				
			}
			
			
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="iRow"></param>
			public void Gp_Sp_DeleteRow(FarPoint.Win.Spread.FpSpread oSpread, int iRow)
			{
			
				if (iRow < 0)
				{
					
				}
				else
				{
                    oSpread.ActiveSheet.Rows[iRow].Remove();
				}
				
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Conn"></param>
			/// <param name="oSpread"></param>
			/// <param name="sQuery"></param>
			/// <param name="iCol"></param>
			/// <returns></returns>
			public static bool Gf_Sp_ComboAdd(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, int iCol)
			{
				bool returnValue=false;
				
				ADODB.Recordset AdoRs;
				string sList = "";
				
				try
				{
					if (Conn.State == 0)
					{
						if (GeneralCommon.GF_DbConnect() == false)
						{
							returnValue = false;
						}
						return returnValue;
					}
					
					AdoRs = new ADODB.Recordset();
					AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset,ADODB.LockTypeEnum.adLockReadOnly, -1);					
					FarPoint.Win.Spread.FpSpread with_1 = oSpread;					
					if (! AdoRs.BOF && ! AdoRs.EOF)
					{						
						while (! AdoRs.EOF)
						{
							
							if (Information.VarType(AdoRs.Fields[0].Value) != Constants.vbNull)
							{
								if (sList != "")
								{
									sList += "\t";
								}
								sList += (string) (AdoRs.Fields[0].Value.ToString().Trim());
							}
							
							AdoRs.MoveNext();							
						}
						FarPoint.Win.Spread.CellType.ComboBoxCellType ocell;
                        ocell = (FarPoint.Win.Spread.CellType.ComboBoxCellType)oSpread.Sheets[0].Columns[iCol].CellType;
                        ocell.Items = sList.Split('\t');
                        ocell.Editable = false;
						
						oSpread.Sheets[0].Columns.Get(iCol).CellType = ocell;
						
						returnValue = true;
					}
					else
					{
						returnValue = false;
					}										
					AdoRs.Close();
					AdoRs = null;										
				}
				catch (Exception ex)
				{
					AdoRs = null;
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_ComboAdd Error : " + ex.Message), "", "");
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
					
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
					
				}
				
				return returnValue;
			}
			
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="oSpread"></param>
        /// <param name="sQuery"></param>
        /// <param name="iCol"></param>
        /// <returns></returns>
			public static bool Gf_Sp_ComboAddNew(ADODB.Connection Conn, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, int iCol)
			{
				bool returnValue;
				
				returnValue = false;
				FarPoint.Win.Spread.FpSpread ss1;
				ss1 = oSpread;
				
				FarPoint.Win.Spread.CellType.ComboBoxCellType ocell;
                ocell = (FarPoint.Win.Spread.CellType.ComboBoxCellType)oSpread.Sheets[0].Columns.Get(iCol).CellType;
				int index = iCol;
				int row = System.Convert.ToInt32(ss1.Sheets[0].ColumnHeader.RowCount - 1);
				try
				{
					FarPoint.Win.Spread.SheetView with_1 = ss1.Sheets[0];
					
					DataTable dt;
					CdQuery cdq;
					string ssql;
					
					ocell.Editable = true;

					dt = new Query(sQuery).CreateDataTable(true);
					ssql = sQuery + "@" + "";
					ocell.AutoCompleteMode = AutoCompleteMode.Suggest;
					ocell.AutoCompleteSource = AutoCompleteSource.ListItems;
					ocell.MaxLength = 200;
					ocell.MaxDrop = 30;
					
					if (dt != null)
					{
						int c = dt.Rows.Count;
						string[] items = new string[c - 1 + 1];
						string[] values = new string[c - 1 + 1];
						if (dt.Columns.Count == 2)
						{
							for (int i = 0; i <= c - 1; i++)
							{
								items[i] = (string) (dt.Rows[i][0].ToString());
								values[i] = (string) (dt.Rows[i][1].ToString());
							}
						}
						else if (dt.Columns.Count == 1)
						{
							for (int i = 0; i <= c - 1; i++)
							{
								items[i] = (string) (dt.Rows[i][0].ToString());
								values[i] = (string) (dt.Rows[i][0].ToString());
							}
						}
						
						
						ocell.Items = items;
						ocell.ItemData = values;
						ocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
					}					
					with_1.Columns.Get(index).CellType = ocell;
					with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
					with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;																			
				}
				catch (Exception ex)
				{
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_ComboAdd Error : " + ex.Message), "", "");
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
					
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn.Close();
					}
					
				}
				
				return returnValue;
			}
			
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ospread"></param>
        /// <param name="colID"></param>
        /// <param name="iRow"></param>
        /// <returns></returns>
			public static string Gf_Sp_RcvDataById(FarPoint.Win.Spread.FpSpread ospread, string colID, int iRow)
			{
				string returnValue="";
				
				return returnValue;
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="sPname"></param>
			/// <param name="Col"></param>
			/// <param name="Row"></param>
			/// <param name="CL"></param>
			/// <param name="Key_Col"></param>
			public void Gp_Sp_Sort(FarPoint.Win.Spread.FpSpread sPname, int Col, int Row, bool CL, int Key_Col)
			{				
				int I=0;
				int j=0;
				int k=0;
				string[] sKey_Value;

                FarPoint.Win.Spread.FpSpread with_1 = sPname;				
				if (with_1.ActiveSheet.RowCount < 1)
				{
					return;
				}				
				if (Row == 0 && Col > 0)
				{					
					if (CL && Key_Col != 0)
					{						
						sKey_Value = new string[with_1.ActiveSheet.RowCount + 1];
						
						for (I = 1; I <= with_1.ActiveSheet.RowCount; I++)
						{
							with_1.ActiveSheet.ActiveRowIndex = I;
							with_1.ActiveSheet.ActiveColumnIndex = 0;
							
							if (with_1.Text != "")
							{
								j++;
								with_1.ActiveSheet.ActiveColumnIndex = Key_Col;
								sKey_Value[j] = (string) with_1.Text;
								with_1.ActiveSheet.ActiveColumnIndex = 0;
								with_1.Text = "";								
								Gp_Sp_BlockColor(sPname, 1, with_1.ActiveSheet.RowCount, I, I, Color.Black, Color.White);
							}
						}						
					}
					else
					{						
						for (I = 1; I <= with_1.ActiveSheet.RowCount; I++)
						{
							with_1.ActiveSheet.ActiveRowIndex = I;
							with_1.ActiveSheet.ActiveColumnIndex = 0;
							if (with_1.Text != "")
							{
								return;
							}
						}						
					}
                }				
			}
			
			~SpreadCommon()
			{
               
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="iRow"></param>
			/// <param name="iCow"></param>
			public void Gp_Sp_UpdateMark(FarPoint.Win.Spread.FpSpread oSpread, int iRow, int iCow)
			{
                if (oSpread.ActiveSheet.Cells[iRow, iCow].Locked) return;

                if (oSpread.ActiveSheet.RowCount < 1)
				{
					return;
				}               
                
				string sText = oSpread.ActiveSheet.Cells.Get(iRow, iCow).Text;
                string sTag = oSpread.ActiveSheet.Cells.Get(iRow, iCow).Tag.ToString();
                if (sTag != null) sTag = sTag.Trim();
                string cur_cellType = oSpread.ActiveSheet.Columns[iCow].CellType.ToString();
                if (cur_cellType == "NumberCellType")
                {
                    double nText = double.Parse(sText);
                    sText = nText.ToString();
                    double nTag = double.Parse(sTag);
                    sTag = nTag.ToString();
                }
				if (sText.Trim() != sTag)
				{
					switch (Strings.Trim(oSpread.ActiveSheet.RowHeader.Cells.Get(iRow, 0).Text))
					{
                        case "����":
                        case "�޸�":
							break;
						default:
                            oSpread.ActiveSheet.RowHeader.Cells.Get(iRow, 0).Text = "�޸�";
							break;
					}
				}				
			}
			
/// <summary>
/// 
/// </summary>
/// <param name="oSpread"></param>
/// <param name="mark"></param>
	
			public void Gp_Sp_UpdateMarkAll(FarPoint.Win.Spread.FpSpread oSpread, bool mark)
			{
				for (int i = 0; i <= oSpread.Sheets[0].RowCount - 1; i++)
				{
					if (oSpread.ActiveSheet.RowHeader.Cells.Get(i, 0).Text == "")
					{
                        oSpread.ActiveSheet.RowHeader.Cells.Get(i, 0).Text = "�޸�";
					}
				}
				
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Sc"></param>
			/// <param name="Auth_Col"></param>
			/// <param name="iType"></param>
			/// <param name="iRow"></param>
			public void Gp_Sp_InAuthority2(Collection Sc, int Auth_Col, string iType, int iRow)
			{				
				int iCount;
				
				if (Auth_Col == 0)
				{
					return;
				}

                FarPoint.Win.Spread.FpSpread with_1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
				
				if (iType == "")
				{
					with_1.ActiveSheet.ActiveRowIndex = iRow == 0 ? with_1.ActiveSheet.ActiveRowIndex : iRow;
					with_1.ActiveSheet.ActiveColumnIndex = 0;

                    if (with_1.Text == "����" || with_1.Text == "�޸�")
					{
						with_1.ActiveSheet.ActiveColumnIndex = Auth_Col;
						with_1.Text = GeneralCommon.sUserID;
						with_1.ActiveSheet.ActiveColumnIndex = Auth_Col + 1;
						with_1.Text = GeneralCommon.sUsername;
					}
				}
				else
				{
					for (iCount = 1; iCount <= with_1.ActiveSheet.RowCount; iCount++)
					{
						with_1.ActiveSheet.ActiveRowIndex = iCount;
						with_1.ActiveSheet.ActiveColumnIndex = Auth_Col;
						with_1.Text = GeneralCommon.sUserID;
						with_1.ActiveSheet.ActiveColumnIndex = Auth_Col + 1;
						with_1.Text = GeneralCommon.sUsername;
					}
				}				
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="RowNum"></param>
			/// <param name="LockType"></param>
			public void Gp_Sp_RowLock(FarPoint.Win.Spread.FpSpread oSpread, int RowNum, bool LockType)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				with_1.ActiveSheet.Rows.Get(RowNum).Locked = true;
				
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="RowNum"></param>
			/// <param name="RowNum2"></param>
			/// <param name="LockType"></param>
			public void Gp_Sp_RowLock(FarPoint.Win.Spread.FpSpread oSpread, int RowNum, long RowNum2, bool LockType)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				for (int i = RowNum; i <= RowNum2; i++)
				{
					with_1.ActiveSheet.Rows.Get(i).Locked = LockType;
				}
				
			}
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="oSpread"></param>
			/// <param name="ColNum"></param>
			/// <param name="RowNum"></param>
			/// <param name="LockType"></param>
			public void Gp_Sp_CellLock(FarPoint.Win.Spread.FpSpread oSpread, int ColNum, int RowNum, bool LockType)
			{
				
				FarPoint.Win.Spread.FpSpread with_1 = oSpread;
				with_1.ActiveSheet.Cells.Get(ColNum, RowNum).Locked = LockType;
				
			}
			
			#region new by wangyong
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Conn1"></param>
			/// <param name="oSpread"></param>
			/// <param name="sQuery"></param>
			/// <param name="iCol"></param>
			/// <returns></returns>
			public static bool Gf_Sp_MutiComboAdd(ADODB.Connection Conn1, FarPoint.Win.Spread.FpSpread oSpread, string sQuery, int iCol)
			{
				bool returnValue=false;
				
				try
				{
					
					//Db Connection Check
					if (Conn1.State == 0)
					{
						if (GeneralCommon.GF_DbConnect() == false)
						{
							returnValue = false;
						}
						return returnValue;
					}
					
					string connString = Conn1.ConnectionString;

					DataSet ds = new DataSet();
					OleDbConnection conn = new OleDbConnection(connString);
					OleDbCommand cmd = conn.CreateCommand();
					cmd.CommandText = sQuery;
					OleDbDataAdapter da = new OleDbDataAdapter(cmd);
					da.Fill(ds);
					
					//Dim omcell As New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType()
                    FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType omcell = (FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType)oSpread.ActiveSheet.Columns[iCol].CellType;
					omcell.DataSourceList = ds;
					oSpread.Sheets[0].Columns.Get(iCol).CellType = omcell;
					returnValue = true;
					
				}
				catch (Exception ex)
				{
					
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_MutiComboAdd Error : " + ex.Message), "", "");
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn1.Close();
					}
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn1.Close();
					}
					
				}
				
				return returnValue;
			}
			/// <summary>
			/// 
			/// </summary>
			/// <param name="Conn1"></param>
			/// <param name="oSpread"></param>
			/// <param name="sCusCode"></param>
			/// <param name="iRow"></param>
			/// <param name="iCol"></param>
			/// <returns></returns>
			public static bool Gf_Sp_MutiComboAdd(ADODB.Connection Conn1, FarPoint.Win.Spread.FpSpread oSpread, string sCusCode, int iRow, int iCol)
			{
				bool returnValue=false;
				
				try
				{
					if (Conn1.State == 0)
					{
						if (GeneralCommon.GF_DbConnect() == false)
						{
							returnValue = false;
						}
						return returnValue;
					}
					
					string[] split = sCusCode.Split(",".ToCharArray());
					string sQuery = "{call pkg_mcombo." + split[0] + "(";
					string sTemp = "";
					for (int i = 1; i <= split.GetLength(0) - 1; i++)
					{
						sTemp = (string) (oSpread.ActiveSheet.Cells[iRow, int.Parse(split[i])].Value);
						sTemp = "\'" + sTemp + "\',";
						sQuery += sTemp;
					}
					sQuery = (string) (sQuery.TrimEnd(",".ToCharArray()) + ")}");
					
					DataSet ds = new DataSet();
					System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(Conn1.ConnectionString);
					System.Data.OleDb.OleDbCommand cmd = conn.CreateCommand();
					//cmd.CommandText = "{call pkg_mcombo.A2('H','030')}"
					cmd.CommandText = sQuery;
					cmd.CommandType = CommandType.Text;
					System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(cmd);
					
					da.Fill(ds);
					FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType omcell = new FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType();
					omcell.DataSourceList = ds;
					oSpread.Sheets[0].Cells[iRow, iCol].CellType = omcell;
					returnValue = true;
					
				}
				catch (Exception ex)
				{
					
					returnValue = false;
					GeneralCommon.Gp_MsgBoxDisplay((string) ("Gp_Sp_MutiComboAdd Error : " + ex.Message), "", "");
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn1.Close();
					}
					if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
					{
						Conn1.Close();
					}
					
				}
				
				return returnValue;
			}
			
			#endregion

            //������ű�ɶ�ӦA,B,C��
            private string GetColStr(int Col)
            {
                string sCol_a = "";
                if (Col <= 26)
                {
                    sCol_a = (Strings.Chr(Col + 64)).ToString();
                }
                else
                {
                    int col1 = Col / 26;
                    int col2 = Col - (col1 * 26);
                    sCol_a = (Strings.Chr(col1 + 64)).ToString() + (Strings.Chr(col2 + 64)).ToString();
                }
                return sCol_a;
            }

            private string GetSumCol(FarPoint.Win.Spread.FpSpread oSpread, int Col, int row1, int row2)
            {
                double sum = 0;
                for (int i = row1; i <= row2; i++)
                {
                    try
                    {
                        sum += double.Parse(oSpread.ActiveSheet.Cells[i, Col].Text);
                    }
                    catch { }
                }
                return sum.ToString();
            }

            private string GetSumRow(FarPoint.Win.Spread.FpSpread oSpread, int row, string Cols)
            {
                double sum = 0;
                string[] Cols_Arr = Cols.Split(',');
                for (int i = 0; i < Cols_Arr.Length; i++)
                {
                    try
                    {
                        sum += double.Parse(oSpread.ActiveSheet.Cells[row, int.Parse(Cols_Arr[i])].Text);
                    }
                    catch { }
                }
                return sum.ToString();
            }


            //---------------------------------------------------------------------------------------
            //   1.ID           : Gp_Sp_Total
            //  ʵ��spreadС�ƹ���
            //1.����С�ƣ�
            //ÿ����С�Ʊ���ָ����������ż��ϼƵĸ��е���š���ע��spread�е���Ŵ�0��ʼ
            // ��С�ƵĲ������ݷ�ʽ�磺2:0,1��6:3,4,5�������ڵڶ��ж�0��1�н�����С�ƣ��ڵ����ж�3��4��5�н���С�ơ�
            //2.��С�ƣ�
            //��С��ֻ���Ե��н���С�ƣ���������С����������ţ���С�ƶ�ָ�����н��У�
            //���ݵ�����źͺϼƵ�������á������������ϼƵ�������á������ָ
            // �磺3��0,5�������ݵ����ж�0��5�н�����С�ơ�
            //3.�кϼƣ�
            //һ��SPREADֻ����һ���кϼƣ��ҷ���SPREAD�����һ�У��кϼƶ�ָ�����н���,��������á������ָ
            //�磺0,1,3���Ƕ�0��1��3�н����кϼ�
            //�������ڣ�2012-7-20
            //������Ա��������
            //---------------------------------------------------------------------------------------
            public void Gp_Sp_Total(Collection Sc, string RowAllTotal, string RowSubTotal,
                string ColSubTotal)
            {
                FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
                if (oSpread.ActiveSheet.Rows.Count == 0) return;
                int oSpreadRows = 0;
                string sCol_a = "";


                //��С�� 3��0,5
                oSpreadRows = oSpread.ActiveSheet.Rows.Count;
                string cur_Total_Text = "";
                double cur_Sum = 0;
                int Total_Row1 = 0;
                int Total_Row2 = 0;
                if (RowSubTotal != "")
                {
                    string[] RowSubTotal_Arr = RowSubTotal.Split(':');
                    bool Total_End = false;
                    int Total_Col = int.Parse(RowSubTotal_Arr[0]);
                    oSpread.ActiveSheet.SortRows(Total_Col, true, true);
                    for (int iCount = 0; iCount < oSpreadRows; iCount++)
                    {
                        //������ʼ��
                        Total_Row1 = iCount;
                        cur_Total_Text = oSpread.ActiveSheet.Cells[Total_Row1, Total_Col].Text;
                        while (cur_Total_Text == oSpread.ActiveSheet.Cells[iCount, Total_Col].Text && iCount < oSpreadRows - 1)
                        {
                            iCount++;
                        }
                        if (iCount == oSpreadRows - 1 && cur_Total_Text == oSpread.ActiveSheet.Cells[iCount, Total_Col].Text)
                        {
                            Total_End = true;
                            Total_Row2 = iCount;
                        }
                        else
                            Total_Row2 = iCount - 1;

                        //����С����
                        oSpread.ActiveSheet.Rows.Add(Total_Row2 + 1, 1);
                        oSpread.ActiveSheet.RowHeader.Cells.Get(Total_Row2 + 1, 0).Text = cur_Total_Text + "С��";
                        oSpreadRows++;

                        //��С�������
                        string[] Total_Cols_Arr = RowSubTotal_Arr[1].Split(',');
                        for (int lCount = 0; lCount < Total_Cols_Arr.Length; lCount++)
                        {
                            int cur_Col = int.Parse(Total_Cols_Arr[lCount]);
                            //sCol_a = GetColStr(cur_Col + 1);
                            //string Formula_Str = "sum(" + sCol_a + (Total_Row1 + 1).ToString() + ":" + sCol_a + (Total_Row2 + 1).ToString() + ")";
                            oSpread.ActiveSheet.Cells[Total_Row2 + 1, cur_Col].Text = GetSumCol(oSpread, cur_Col, Total_Row1, Total_Row2);// Formula_Str;
                        }
                        if (Total_End) break;
                    }
                }



                //�кϼ�
                oSpreadRows = oSpread.ActiveSheet.Rows.Count + 1;
                sCol_a = "";
                if (RowAllTotal != "")
                {
                    oSpread.ActiveSheet.Rows.Add(oSpreadRows - 1, 1);
                    oSpread.ActiveSheet.RowHeader.Cells.Get(oSpreadRows - 1, 0).Text = "�ϼ�";
                    string[] RowAllTotal_Arr = RowAllTotal.Split(',');
                    for (int i = 0; i < RowAllTotal_Arr.Length; i++)
                    {
                        int RowAllTotal_Col = int.Parse(RowAllTotal_Arr[i]) + 1;
                        sCol_a = GetColStr(RowAllTotal_Col);
                        if (RowSubTotal != "")
                            oSpread.ActiveSheet.Cells[oSpreadRows - 1, RowAllTotal_Col - 1].Formula =
                                "sum(" + sCol_a + "1" + ":" + sCol_a + (oSpreadRows - 1).ToString() + ")/2";
                        else
                            oSpread.ActiveSheet.Cells[oSpreadRows - 1, RowAllTotal_Col - 1].Formula =
                           "sum(" + sCol_a + "1" + ":" + sCol_a + (oSpreadRows - 1).ToString() + ")";
                    }
                }


                //return;

                //��С��  2:0,1��6:3,4,5 ColSubTotal
                if (ColSubTotal != "")
                {
                    string[] ColSubTotal_Arr = ColSubTotal.Split(';');
                    for (int i = 0; i < ColSubTotal_Arr.Length; i++)
                    {
                        int cur_TotalCol = int.Parse(ColSubTotal_Arr[i].Split(':')[0]);
                        string cur_SubCols = ColSubTotal_Arr[i].Split(':')[1];
                        for (int j = 0; j < oSpread.ActiveSheet.Rows.Count; j++)
                        {
                            oSpread.ActiveSheet.Cells[j, cur_TotalCol].Text = GetSumRow(oSpread, j, cur_SubCols);
                        }
                    }
                }
                if ((RowAllTotal != "" || RowSubTotal!="")&&(bool)Sc["sort"])
                {
                    Sc.Remove("sort");
                    Sc.Add(false,"sort",null,null);
                }

            }
			
		}
		
	}
