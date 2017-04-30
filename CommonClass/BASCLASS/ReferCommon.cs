using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CommonClass
{
	public class ReferCommon
	{
		//---------------------------------------------------------------------------------------
		//   1.ID           : Gp_Ms_RefCollection
		//   2.Input  Value : Name Object, rctl String, rControl Collection
		//   3.Return Value :
		//   4.Create Date  :
		//   5.Modify Date  :
		//   6.Comment      : Master Refer Collection Setting
		//---------------------------------------------------------------------------------------
		public void Gp_Ms_RefCollection(object Name, string rctl, Collection rControl)
		{
			
			if (rctl.Trim().ToLower() == "r") //Refer Control
			{
				rControl.Add(Name, null, null, null);
			}
			
		}
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : Gf_Only_Display
		//   2.Input  Value : Conn Connection, Sc Collection, sQuery String,
		//                    {iDupCnt Long}, {nCheckControl Collection}, {mCheckControl Collection},
		//                    {MsgChk Boolean},  {EvenRowChk Boolean}
		//   3.Return Value : Boolean
		//   4.Create Date  :
		//   5.Modify Date  :
		//   6.Comment      : Only Display
		//---------------------------------------------------------------------------------------
		public bool Gf_Only_Display(ADODB.Connection Conn, Collection Sc, string sQuery, int iDupCnt, Collection nCheckControl, Collection mCheckControl, bool MsgChk, bool EvenRowChk)
			{
				bool returnValue=false;
			
			SpreadCommon SpreadCommon = new SpreadCommon();
			MasterCommon MasterCommon = new MasterCommon();
			
			int JJ;
			int j;
			
			int lRowCount;
			int lColCount;
			string sMsg;
			string[] sTemp;
			string sSpreadClip;
			
			ADODB.Recordset AdoRs;
			object ArrayRecords;
			
			//Db Connection Check
			if (Conn.State == 0)
			{
				if (GeneralCommon.GF_DbConnect() == false)
				{
					returnValue = false;
				}
				return returnValue;
			}
			
			try
			{
				
				if (nCheckControl != null)
				{
					sMsg = MasterCommon.Gf_Ms_NeceCheck(nCheckControl);
					if (sMsg != "OK")
					{
						sMsg = "必须输入 " + sMsg.Trim() + " ...!!!";
						GeneralCommon.Gp_MsgBoxDisplay(sMsg, "", "");
						returnValue = false;
						return returnValue;
					}
				}
				
				if (mCheckControl != null)
				{
					sMsg = MasterCommon.Gf_Ms_NeceCheck2(mCheckControl);
					if (sMsg != "OK")
					{
						sMsg = "输入的项目必须符合 " + sMsg.Trim() + " 的长度...!!!";
						GeneralCommon.Gp_MsgBoxDisplay(sMsg, "", "");
						returnValue = false;
						return returnValue;
					}
				}
				
				AdoRs = new ADODB.Recordset();

                FarPoint.Win.Spread.FpSpread with_1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];

                
				
				returnValue = true;

                with_1.Sheets[0].RowCount = 0;
             

                //with_1.ReDraw = false;
                with_1.Sheets[0].RowCount = 0;
				
				Cursor.Current = Cursors.WaitCursor;
				
				//Ado Execute
				AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);
				
				if (AdoRs.BOF || AdoRs.EOF)
				{
					
					if (MsgChk)
					{
						GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I", "");
					}
					
					returnValue = false;
                    //with_1.ReDraw = true;
					
					AdoRs.Close();
					AdoRs = null;
					Cursor.Current = Cursors.Default;
					return returnValue;
					
				}
				
				ArrayRecords = AdoRs.GetRows();
				AdoRs.Close();
				AdoRs = null;
				
				if (iDupCnt > 0)
				{
					sTemp = new string[iDupCnt + 1];
				}



                if ((AdoRs.RecordCount - 1) >= 0)
				{

                    with_1.Sheets[0].RowCount = AdoRs.RecordCount;
                    for (lRowCount = 0; lRowCount <= AdoRs.RecordCount - 1; lRowCount++)
					{
						
						sSpreadClip = "";

                        for (lColCount = iDupCnt; lColCount <= AdoRs.Fields.Count; lColCount++)
						{

                            sSpreadClip = sSpreadClip + AdoRs.Fields[lColCount].Value.ToString() + '\t';
							
						}
						
						with_1.Sheets[0].SetClip(lRowCount,0,lRowCount,lColCount, sSpreadClip);
						
					}
				}
				
				if (EvenRowChk)
				{
					SpreadCommon.Gp_Sp_EvenRowBackcolor((FarPoint.Win.Spread.FpSpread)Sc["Spread"], 0);
				}
				
				//.OperationMode = FPSpread.OperationModeConstants.OperationModeRow
                //with_1.ReDraw = true;
				
				
				returnValue = true;
				Cursor.Current = Cursors.Default;
				return returnValue;
				
			}
			catch (Exception ex)
			{
				AdoRs = null;
				returnValue = false;
				Cursor.Current = Cursors.Default;
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Only_Display Error : " + ex.Message), "", "");
			}
			
			return returnValue;
		}
		
		
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : Gf_Sonly_Display
		//   2.Input  Value : Conn Connection, Sc Collection, sQuery String,
		//                    {iDupCnt Long}, {iSumCnt Long}, {iSumCol Object},
		//                    {nCheckControl Collection}, {mCheckControl Collection},
		//                    {MsgChk Boolean},  {EvenRowChk Boolean}
		//   3.Return Value : Boolean
		//   4.Create Date  :
		//   5.Modify Date  :
		//   6.Comment      : SubTotal Display
		//---------------------------------------------------------------------------------------
        //public bool Gf_Sonly_Display(ADODB.Connection Conn, Collection Sc, string sQuery, long iDupCnt, long iSumCnt, object iSumCol, Collection nCheckControl, Collection mCheckControl, bool MsgChk, bool EvenRowChk)
        //{
        //    bool returnValue;
			
        //    SpreadCommon SpreadCommon = new SpreadCommon();
        //    MasterCommon MasterCommon = new MasterCommon();
			
        //    long k;
        //    long j;
			
        //    int iBas;
        //    int iCot;
        //    int iOld_Row;
			
        //    //Dim Sw As Boolean
			
        //    long lRowCount;
        //    long lColCount;
			
        //    string sCol_a;
        //    string sCol_b;
        //    string[] sTemp;
        //    string sMsg;
			
        //    string sDupString;
        //    string sSpreadClip;
			
        //    double[] dTotal;
			
        //    ADODB.Recordset AdoRs;
        //    object ArrayRecords;
			
        //    //Db Connection Check
        //    if (Conn.State == 0)
        //    {
        //        if (GeneralCommon.GF_DbConnect() == false)
        //        {
        //            returnValue = false;
        //        }
        //        return returnValue;
        //    }
			
        //    if (iSumCnt != iSumCol.Count)
        //    {
        //        GeneralCommon.Gp_MsgBoxDisplay("列和iSumCol数量不一致...!!!", "I", "");
        //        returnValue = false;
        //        return returnValue;
        //    }
			
        //    sTemp = new string[iDupCnt + 1];
        //    dTotal = new double[iSumCnt + 1];
			
        //    try
        //    {
				
        //        if (nCheckControl != null)
        //        {
        //            sMsg = MasterCommon.Gf_Ms_NeceCheck(nCheckControl);
        //            if (sMsg != "OK")
        //            {
        //                sMsg = "必须输入 " + sMsg.Trim() + " ...!!!";
        //                GeneralCommon.Gp_MsgBoxDisplay(sMsg, "", "");
        //                returnValue = false;
        //                return returnValue;
        //            }
        //        }
				
        //        if (mCheckControl != null)
        //        {
        //            sMsg = MasterCommon.Gf_Ms_NeceCheck2(mCheckControl);
        //            if (sMsg != "OK")
        //            {
        //                sMsg = "输入的项目必须符合 " + sMsg.Trim() + " 的长度...!!!";
        //                GeneralCommon.Gp_MsgBoxDisplay(sMsg, "", "");
        //                returnValue = false;
        //                return returnValue;
        //            }
        //        }
				
        //        AdoRs = new ADODB.Recordset();
				
        //        System.Object with_1 = Sc["Spread"];
				
        //        returnValue = true;
				
        //        with_1.ReDraw = false;
        //        with_1.MaxRows = 0;
        //        iOld_Row = 1;
				
        //        Cursor.Current = Cursors.WaitCursor;
				
        //        //Ado Execute
        //        AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset, -1, -1);
				
        //        if (AdoRs.BOF || AdoRs.EOF)
        //        {
					
        //            if (MsgChk)
        //            {
        //                GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I", "");
        //            }
					
        //            returnValue = false;
        //            with_1.ReDraw = true;
					
        //            AdoRs.Close();
        //            AdoRs = null;
        //            Cursor.Current = Cursors.Default;
        //            return returnValue;
					
        //        }
				
        //        ArrayRecords = AdoRs.GetRows();
				
        //        AdoRs.Close();
        //        AdoRs = null;
				
        //        if ((ArrayRecords.Length - 1) != 0)
        //        {
					
        //            for (lRowCount = 0; lRowCount <= Information.UBound(ArrayRecords, 2); lRowCount++)
        //            {
						
        //                with_1.MaxRows++;
        //                with_1.Row = with_1.MaxRows;
						
        //                //Duplicate Process
        //                for (j = 1; j <= iDupCnt; j++)
        //                {
							
        //                    if (Information.IsDBNull(ArrayRecords(j - 1, lRowCount)))
        //                    {
        //                        sDupString = "";
        //                    }
        //                    else
        //                    {
        //                        sDupString = Strings.Trim((string) (ArrayRecords(j - 1, lRowCount)));
        //                    }
							
        //                    if (sTemp[j - 1] != sDupString)
        //                    {
								
        //                        //Sub Total
        //                        //--------------------------------------------------------------------------
        //                        if (with_1.Row != 1 && j == 1)
        //                        {
        //                            with_1.Col = 1;
									
        //                            SpreadCommon.Gp_Sp_BlockColor(Sc["Spread"], 1, with_1.MaxCols, with_1.Row, with_1.Row, SpreadCommon.VbBlack, SpreadCommon.vbSTotal);
									
        //                            for (k = 1; k <= iDupCnt; k++)
        //                            {
        //                                with_1.Col = k;
        //                                if (with_1.ColHidden == false)
        //                                {
        //                                    with_1.Text = "SubTotal";
        //                                    k = iDupCnt;
        //                                }
        //                            }
									
        //                            for (k = 1; k <= iSumCnt; k++)
        //                            {
        //                                with_1.Col = iSumCol(k);
										
        //                                if (iSumCol(k) <= 26)
        //                                {
        //                                    sCol_a = Strings.Chr(System.Convert.ToInt32(iSumCol(k) + 64));
        //                                    with_1.Formula = "sum(" + sCol_a + iOld_Row + (":" + sCol_a) + (with_1.Row - 1) + ")";
        //                                }
        //                                else
        //                                {
        //                                    iCot = System.Convert.ToInt32(Conversion.Int((iSumCol(k) - 1) / 26));
        //                                    iBas = System.Convert.ToInt32(26 * iCot);
											
        //                                    sCol_a = Strings.Chr(System.Convert.ToInt32((iSumCol(k) - iBas) + 64));
        //                                    sCol_b = Strings.Chr(iCot + 64);
											
        //                                    with_1.Formula = "sum(" + sCol_b + sCol_a + iOld_Row + (":" + sCol_b + sCol_a) + (with_1.Row - 1) + ")";
        //                                }
										
        //                                if (Strings.Trim((string) with_1.Text) == "")
        //                                {
        //                                    dTotal[k - 1] = System.Convert.ToDouble(dTotal[k - 1] + 0);
        //                                }
        //                                else
        //                                {
        //                                    dTotal[k - 1] = System.Convert.ToDouble(dTotal[k - 1] + with_1.Value);
        //                                }
										
        //                            }
									
        //                            with_1.MaxRows++;
        //                            with_1.Row = with_1.MaxRows;
        //                            iOld_Row = System.Convert.ToInt32(with_1.Row);
									
        //                        }
        //                        //--------------------------------------------------------------------------
        //                        with_1.Col = j;
								
        //                        with_1.Text = sDupString;
        //                        sTemp[j - 1] = sDupString;
								
        //                        for (k = j + 1; k <= iDupCnt; k++)
        //                        {
        //                            sTemp[k - 1] = "";
        //                        }
								
        //                    }
							
        //                }
						
        //                with_1.Row2 = with_1.Row;
						
        //                with_1.Col = iDupCnt + 1;
        //                with_1.Col2 = with_1.Maxcols;
						
        //                sSpreadClip = "";
						
        //                //Duplicate Process
        //                for (lColCount = iDupCnt; lColCount <= with_1.MaxCols - 1; lColCount++)
        //                {
							
        //                    sSpreadClip = sSpreadClip + ArrayRecords(lColCount, lRowCount) + '\t';
							
        //                }
						
        //                with_1.clip = sSpreadClip;
						
        //            }
					
        //        }
				
        //        //Last Sub Total
        //        //--------------------------------------------------------------------------
        //        if (with_1.MaxRows > 0)
        //        {
					
        //            with_1.MaxRows++;
        //            with_1.Row = with_1.MaxRows;
        //            with_1.Col = 1;
					
        //            SpreadCommon.Gp_Sp_BlockColor(Sc["Spread"], 1, with_1.MaxCols, with_1.MaxRows, with_1.MaxRows, SpreadCommon.VbBlack, SpreadCommon.vbSTotal);
					
        //            for (k = 1; k <= iDupCnt; k++)
        //            {
        //                with_1.Col = k;
        //                if (with_1.ColHidden == false)
        //                {
        //                    with_1.Text = "SubTotal";
        //                    k = iDupCnt;
        //                }
        //            }
					
        //            for (k = 1; k <= iSumCnt; k++)
        //            {
        //                with_1.Col = iSumCol(k);
						
        //                if (iSumCol(k) <= 26)
        //                {
        //                    sCol_a = Strings.Chr(System.Convert.ToInt32(iSumCol(k) + 64));
        //                    with_1.Formula = "sum(" + sCol_a + iOld_Row + (":" + sCol_a) + (with_1.Row - 1) + ")";
        //                }
        //                else
        //                {
        //                    iCot = System.Convert.ToInt32(Conversion.Int((iSumCol(k) - 1) / 26));
        //                    iBas = System.Convert.ToInt32(26 * iCot);
							
        //                    sCol_a = Strings.Chr(System.Convert.ToInt32((iSumCol(k) - iBas) + 64));
        //                    sCol_b = Strings.Chr(iCot + 64);
							
        //                    with_1.Formula = "sum(" + sCol_b + sCol_a + iOld_Row + (":" + sCol_b + sCol_a) + (with_1.Row - 1) + ")";
        //                }
						
        //                if (Strings.Trim((string) with_1.Text) == "")
        //                {
        //                    dTotal[k - 1] += 0;
        //                }
        //                else
        //                {
        //                    dTotal[k - 1] += System.Convert.ToDouble(with_1.Value);
        //                }
						
        //            }
					
        //        }
				
        //        //.OperationMode = FPSpread.OperationModeConstants.OperationModeRow
        //        with_1.ReDraw = true;
				
				
        //        returnValue = true;
        //        Cursor.Current = Cursors.Default;
				
        //    }
        //    catch (Exception ex)
        //    {
        //        AdoRs = null;
        //        returnValue = false;
        //        Cursor.Current = Cursors.Default;
        //        GeneralCommon.Gp_MsgBoxDisplay((string) ("Gf_Sonly_Display Error : " + ex.Message), "", "");
        //    }
			
        //    return returnValue;
        //}
		
		
		
	}
	
}
