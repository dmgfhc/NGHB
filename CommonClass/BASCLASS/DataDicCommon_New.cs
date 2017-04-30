using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public class DataDicCommon_New
    {
        //---------------------------------------------------------------------------------------
        //  1.ID           : Gf_DD_Display
        //  2.Input  Value : Conn Connection, sQuery String, [MsgChk Boolean]
        //  3.Return Value : Boolean
        //  4.Create Date  :  
        //  5.Modify Date  : 
        //  6.Comment      : Data Dictionary Result Data Display
        //---------------------------------------------------------------------------------------
        public static bool Gf_Common_DD(Keys KeyCode)
        {
            SpreadCommon SpreadCommon = new SpreadCommon();
            string sOld_Code = "";
            string sNew_Code = "";
            // string sOld_Name = "";
            string sNew_Name = "";

            /* ����˳�F4����. */
            if (KeyCode == Keys.Return || KeyCode == Keys.Escape|| GeneralCommon.GF_DbConnect() == false )
            {
                GeneralCommon.Gp_DD_New_Clear();
                return false;
            }

            GeneralCommon.DD_New.DicRefType = "C";      //Active Form DataDic Call

            try
            {
                if (GeneralCommon.DD_New.sWitch == "MS" || GeneralCommon.DD_New.sWitch == "CUS")
                {
                    if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sCusCode))
                    {
                        GeneralCommon.DD_New.sQuery = GeneralCommon.DD_New.sCusCode;
                        GeneralCommon.DD_New.sWhere = "";
                    }
                    else if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sPrcoCode))
                    {
                        string callSql = "{call " + GeneralCommon.DD_New.sPrcoCode + "(";
                        string Par = "";
                        for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                        {
                            if(GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("R"))
                                Par += "'" + MasterCommon.GetControlValue(GeneralCommon.DD_New.sContrl[i]).ToString().Replace("'", "''") + "',";
                        }                      
                        if (Par.Length > 0)
                            Par = Par.Substring(0, Par.Length - 1);
                        callSql = callSql + Par + ")}";

                        GeneralCommon.DD_New.sQuery = callSql;
                        GeneralCommon.DD_New.sWhere = "";
                    }
                    else
                    {
                        string sQuery_temp = " ";
                        string sWhere_after = "";
                        string sWhere_before = "";
                        string sOrder_Temp = " ";
                        if (GeneralCommon.DD_New.sKeyName.Trim().Length > 0 && GeneralCommon.DD_New.sKey.Trim().Length > 0)
                        {
                            sWhere_before = "where " + GeneralCommon.DD_New.sKeyName.Trim() + "='" + GeneralCommon.DD_New.sKey.Trim() + "' and ";
                        }
                        else
                        {
                            sWhere_before = "where ";
                        }
                        GeneralCommon.DD_New.sQuery = " SELECT ";

                        //ƴWhere ������������� �� Select ����ֶ�
                        for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(GeneralCommon.DD_New.sBackName[i])))
                            {
                                if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("R") && !GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                                    sWhere_after += "and    nvl(" + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + ",f_nullvalue('"+GeneralCommon.DD_New.sBackTableName+"','"+ GeneralCommon.DD_New.sBackName[i].ToString().Trim()+"'))        LIKE '%" + MasterCommon.GetControlValue(GeneralCommon.DD_New.sContrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                else if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                                {
                                    sWhere_after += "and    " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + "       LIKE '%" + MasterCommon.GetControlValue(GeneralCommon.DD_New.sContrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                    sOrder_Temp += " " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + " Asc ,";
                                }

                                if (string.IsNullOrEmpty(Convert.ToString(GeneralCommon.DD_New.sColName[i])))
                                    sQuery_temp += " " + GeneralCommon.DD_New.sBackName[i] + " \" " + GeneralCommon.DD_New.sBackName[i] + " \",";                            
                                sQuery_temp += " " + GeneralCommon.DD_New.sBackName[i] + " \" " + GeneralCommon.DD_New.sColName[i] + " \",";
                            }
                        }
                     
                        GeneralCommon.DD_New.sQuery +=sQuery_temp.Substring(0,sQuery_temp.Length-1)+ "    FROM "+ GeneralCommon.DD_New.sBackTableName +" ";
                        GeneralCommon.DD_New.sQuery += sWhere_before;

                         sWhere_after += "    ";
                       
                         //  if (!sWhere_before.Contains("="))
                        {
                            sWhere_after = sWhere_after.Substring(4);
                        }

                        GeneralCommon.DD_New.sWhere += sWhere_after + " ";
                   
                        GeneralCommon.DD_New.sWhere += "   " + GeneralCommon.DD_New.sJoin ;
                        if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sOrderBy))
                        {
                            GeneralCommon.DD_New.sWhere += "  " + GeneralCommon.DD_New.sOrderBy;
                        }
                        else
                        {
                            GeneralCommon.DD_New.sWhere += " order by " + sOrder_Temp.Substring(0, sOrder_Temp.Length - 1);
                        }
                    }
                }
                else
                {//�����
                    if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sCusCode))
                    {
                        GeneralCommon.DD_New.sQuery = GeneralCommon.DD_New.sCusCode;
                        GeneralCommon.DD_New.sWhere = "";
                    }
                    else if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sPrcoCode))
                    {
                        string callSql = "{call " + GeneralCommon.DD_New.sPrcoCode + "(";
                        string Par = "";
                        for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                        {
                            if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("R"))
                                Par += "'" + SpreadCommon.GetColValue((C1.Win.C1FlexGrid.Column)GeneralCommon.DD_New.sContrl[i]).ToString().Replace("'", "''") + "',";
                        }
                        if (Par.Length > 0)
                            Par = Par.Substring(0, Par.Length - 1);
                        callSql = callSql + Par + ")}";

                        GeneralCommon.DD_New.sQuery = callSql;
                        GeneralCommon.DD_New.sWhere = "";
                    }
                    else
                    {
                        string sQuery_temp = " ";
                        string sWhere_after = "";
                        string sWhere_before = "";
                        string sOrder_Temp = " ";
                        if (GeneralCommon.DD_New.sKeyName.Trim().Length > 0 && GeneralCommon.DD_New.sKey.Trim().Length > 0)
                        {
                            sWhere_before = "where " + GeneralCommon.DD_New.sKeyName.Trim() + "='" + GeneralCommon.DD_New.sKey.Trim() + "' ";
                        }
                        else
                        {
                            sWhere_before = "where ";
                        }
                        GeneralCommon.DD_New.sQuery = " SELECT ";

                        //ƴWhere ������������� �� Select ����ֶ�
                        for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(GeneralCommon.DD_New.sBackName[i])))
                            {
                                if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("R") && !GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                                    sWhere_after += "and    nvl(" + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + ",'%')        LIKE '%" + SpreadCommon.GetCellValue((FlexGrid_User)GeneralCommon.DD_New.sPname, ((FlexGrid_User)GeneralCommon.DD_New.sPname).RowSel, ((C1.Win.C1FlexGrid.Column)GeneralCommon.DD_New.sContrl[i]).Index).ToString().Trim().Replace("'", "''") + "%' ";
                                else if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                                {
                                    sWhere_after += "and    " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + "       LIKE '%" + SpreadCommon.GetCellValue((FlexGrid_User)GeneralCommon.DD_New.sPname, ((FlexGrid_User)GeneralCommon.DD_New.sPname).RowSel, ((C1.Win.C1FlexGrid.Column)GeneralCommon.DD_New.sContrl[i]).Index).ToString().Trim().Replace("'", "''") + "%' ";
                                    sOrder_Temp += " " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + " Asc ,";
                                }

                                if (string.IsNullOrEmpty(Convert.ToString(GeneralCommon.DD_New.sColName[i])))
                                    sQuery_temp += " " + GeneralCommon.DD_New.sBackName[i] + " \" " + GeneralCommon.DD_New.sBackName[i] + " \",";
                                sQuery_temp += " " + GeneralCommon.DD_New.sBackName[i] + " \" " + GeneralCommon.DD_New.sColName[i] + " \",";
                            }
                        }

                        GeneralCommon.DD_New.sQuery += sQuery_temp.Substring(0, sQuery_temp.Length - 1) + "    FROM " + GeneralCommon.DD_New.sBackTableName + " ";
                        GeneralCommon.DD_New.sQuery += sWhere_before;

                        sWhere_after += "    ";

                        //  if (!sWhere_before.Contains("="))
                        {
                            sWhere_after = sWhere_after.Substring(4);
                        }

                        GeneralCommon.DD_New.sWhere += sWhere_after + " ";

                        GeneralCommon.DD_New.sWhere += "   " + GeneralCommon.DD_New.sJoin;
                        if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sOrderBy))
                        {
                            GeneralCommon.DD_New.sWhere += "  " + GeneralCommon.DD_New.sOrderBy;
                        }
                        else
                        {
                            GeneralCommon.DD_New.sWhere += " order by " + sOrder_Temp.Substring(0, sOrder_Temp.Length - 1);
                        }
                    }

                    //FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD_New.sPname;

                    ///* ȡ����ǰ��Ԫ��༭������. */
                    //sOld_Code = "";//oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0])].ToString();

                    //GeneralCommon.DD_New.sQuery = "            SELECT CD \"����\", CD_SHORT_NAME \"������\",    CD_NAME \"��������\", ";
                    //GeneralCommon.DD_New.sQuery += "                               CD_SHORT_ENG \"����Ӣ�ļ��\", CD_FULL_ENG \"����Ӣ������\" FROM TZ_CD ";
                    //GeneralCommon.DD_New.sQuery += "            WHERE CD_MANA_NO =    '" + GeneralCommon.DD.sKey.Trim() + "' ";
                    //GeneralCommon.DD_New.sWhere += "              and  CD         LIKE '" + sOld_Code.Trim() + "%' ";

                    ///* �жϵ�ǰ�����ѯ�����ĸ���. */
                    //if (GeneralCommon.rControl.Count > 0)
                    //{
                    //    //sOld_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(((System.Windows.Forms.TextBox)(GeneralCommon.rControl[2])).Text)].ToString();
                    //    sOld_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0])].ToString();

                      
                    //    //}
                    //    GeneralCommon.DD_New.sWhere += "  and NVL(CD_NAME,'%')       LIKE '" + sOld_Name.Trim() + "%' ";
                    //    GeneralCommon.DD_New.sWhere += " AND CD !=  ' ' ";
                    //    GeneralCommon.DD_New.sWhere += " AND APLY_STD = '1' ";

                    //    if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sJoin))
                    //    {
                    //        GeneralCommon.DD_New.sWhere += " and " + GeneralCommon.DD_New.sJoin + "Order by CD";
                    //    }
                    //}
                }              

                if (Gf_DD_Display(GeneralCommon.DD_New.sQuery + GeneralCommon.DD_New.sWhere, false))
                {
                    /* F4 �����˳�������� [FlexGrid�е�F4����] */
                    if (GeneralCommon.DD_New.sWitch == "SP")
                    {
                        /* �����ǰΪ Spread F4 �ؼ�. */
                        FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD_New.sPname;
                        sNew_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32((GeneralCommon.rControl[0]))].ToString();

                        if (GeneralCommon.rControl.Count > 0)
                        {
                            sNew_Name = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32((GeneralCommon.rControl[0]))].ToString();
                        }

                        switch (oFlexGrid.Rows[oFlexGrid.RowSel].Caption)
                        {
                            case "����":
                                break;
                            case "ɾ��":
                                break;
                            case "�޸�":
                                break;
                            default:
                                {
                                    //ss.ActiveSheet.RowHeader.Cells[ss.ActiveSheet.ActiveRowIndex, 0].Text = "Update";
                                    oFlexGrid.Rows[oFlexGrid.RowSel].Caption = "�޸�";
                                    break;
                                }
                        }

                        if (GeneralCommon.DD_New.sSelect)
                        {
                            if (sOld_Code != sNew_Code)
                                SpreadCommon.Gp_Sp_UpdateMark(oFlexGrid, true);
                        }
                    }
                }
                 
                GeneralCommon.Gp_DD_New_Clear();        

                return true;
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_DD_Clear();              
                GeneralCommon.Gp_MsgBoxDisplay("DataDic ��ѯ������...!!!" + ex.Message, "I");
                return false;
            }
        }

        public static bool Gf_DD_Display(string sQuery)
        {
            return Gf_DD_Display(sQuery, true);
        }
        public static bool Gf_DD_Display(string sQuery, bool MsgChk)
        {
            bool functionReturnValue = false;
           
           
            try
            {
                DataDic_New DataDic = new DataDic_New();
                int iColcount = 0;          

                System.Data.DataTable DataTab = GeneralCommon.Gf_ExecProc2Ref(sQuery);
                
                DataDic.ssResult.Cols.Count = DataTab.Columns.Count + 1;
                DataDic.ssWhere.Cols.Count = DataTab.Columns.Count + 1;
                DataDic.ssResult.DataSource = DataTab;
                DataDic.ssResult.AllowEditing = false;
                DataDic.ssResult.Cols.MinSize = 30;
                DataDic.ssWhere.Cols.MinSize = 30;

                if (DataTab.Rows.Count == 0)
                {
                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("�޷��ҵ�������...!!!", "I");
                    }

                   
                    for (iColcount =1; iColcount < DataDic.ssResult.Cols.Count; iColcount++)
                    {
                        DataDic.ssWhere.Cols[iColcount].Caption = DataTab.Columns[iColcount-1].ColumnName;
                        DataDic.ssResult.Cols[iColcount].Width = 80;
                        DataDic.ssWhere.Cols[iColcount].Width = 80;          
                    }
                    if (DataDic.ssWhere.Cols.Count < 2)
                        DataDic.Close();
                    else if (GeneralCommon.DD_New.DicRefType == "C")
                    {
                        DataDic.ShowDialog();
                    }

                    functionReturnValue = false;
                    return functionReturnValue;
                }

                Cursor.Current = Cursors.WaitCursor;
                functionReturnValue = true;              
             
                for (iColcount = 1; iColcount < DataDic.ssResult.Cols.Count ; iColcount++)
                {
                    DataDic.ssWhere.Cols[iColcount].Caption = DataTab.Columns[iColcount-1].ColumnName;
                    DataDic.ssResult.Cols[iColcount].Width = 80;
                    DataDic.ssWhere.Cols[iColcount ].Width = 80;                 

                    //if (GeneralCommon.DD_New.DataDicType == "E")
                    //{
                    //    DataDic.ssWhere.Cols[iColcount].Caption = GeneralCommon.rControl[iColcount].ToString();
                    //}
                }

                Cursor.Current = Cursors.Default;

                 if (DataDic.ssWhere.Cols.Count < 2)
                        DataDic.Close();
                 else if (GeneralCommon.DD_New.DicRefType == "C")
                {
                    DataDic.ShowDialog();
                }
            }
            catch (Exception ex)
            {              
                GeneralCommon.Gp_DD_Clear();            
                functionReturnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay("DD_Display Error : " + ex.Message);
                Cursor.Current = Cursors.Default;
            }

            return functionReturnValue;
        }

        public static void Gp_F4Find(Control F4)
        {        
            string sWhere = "";
            string sQuery = "";
            if (F4 is F4COMN)
            {
                F4COMN f4_temp = (F4COMN)F4;
            

                if (f4_temp.Get_Witch() == "MS" || f4_temp.Get_Witch() == "CUS")
                {
                    if (!string.IsNullOrEmpty(f4_temp.CusSql))
                    {
                        sQuery = f4_temp.CusSql;
                        sWhere = "";
                    }
                    else if (!string.IsNullOrEmpty(f4_temp.PrcoCode))
                    {
                        string callSql = "{call " + f4_temp.PrcoCode + "(";
                        string Par = "";
                        for (int i = 0; i < f4_temp.Contrl.Count; i++)
                        {
                            if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("R"))
                                Par += "'" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Replace("'", "''") + "',";
                        }
                        if (Par.Length > 0)
                            Par = Par.Substring(0, Par.Length - 1);
                        callSql = callSql + Par + ")}";

                        sQuery = callSql;
                        sWhere = "";
                    }
                    else
                    {
                        string sQuery_temp = " ";
                        string sWhere_after = "";
                        string sWhere_before = "";
                        string sOrder_Temp = " ";
                        if (f4_temp.KeyName.Trim().Length > 0 && f4_temp.Key.Trim().Length > 0)
                        {
                            sWhere_before = "where " + f4_temp.KeyName.Trim() + "='" + f4_temp.Key.Trim() + "' and ";
                        }
                        else
                        {
                            sWhere_before = "where ";
                        }
                        sQuery = " SELECT ";

                        //ƴWhere ������������� �� Select ����ֶ�
                        for (int i = 0; i < f4_temp.Contrl.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(f4_temp.BackName[i])))
                            {
                                if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("R") && !f4_temp.CtlAttr[i].ToString().ToUpper().Contains("P"))
                                    sWhere_after += "and    nvl(" + f4_temp.BackName[i].ToString().Trim() + ",'')        LIKE '%" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                else if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("P"))
                                {
                                    sWhere_after += "and    " + f4_temp.BackName[i].ToString().Trim() + "       LIKE '%" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                    sOrder_Temp += " " + f4_temp.BackName[i].ToString().Trim() + " Asc ,";
                                }

                                if (string.IsNullOrEmpty(Convert.ToString(f4_temp.ColName[i])))
                                    sQuery_temp += " " + f4_temp.BackName[i] + " \" " + f4_temp.BackName[i] + " \",";
                                sQuery_temp += " " + f4_temp.BackName[i] + " \" " + f4_temp.ColName[i] + " \",";
                            }
                        }

                       sQuery += sQuery_temp.Substring(0, sQuery_temp.Length - 1) + "    FROM " + f4_temp.BackTableName + " ";
                       sQuery += sWhere_before;

                        sWhere_after += "    ";

                        //  if (!sWhere_before.Contains("="))
                        {
                            sWhere_after = sWhere_after.Substring(4);
                        }

                        sWhere += sWhere_after + " ";

                        sWhere += "   " + f4_temp.Join;
                        if (!string.IsNullOrEmpty(f4_temp.OrderBy))
                        {
                            sWhere += "  " + f4_temp.OrderBy;
                        }
                        else
                        {
                            sWhere += " order by " + sOrder_Temp.Substring(0, sOrder_Temp.Length - 1);
                        }
                    }
                }

                 System.Data.DataTable DataTab = GeneralCommon.Gf_ExecProc2Ref(sQuery+sWhere );

                 if (DataTab.Rows.Count == 1)
                 {
                     int i = 0;
                     string CtlAtt = "";
                     for (i = 0; i < f4_temp.Contrl.Count; i++)
                     {
                         CtlAtt = f4_temp.CtlAttr[i].ToString().ToUpper();
                         if (CtlAtt.Contains("I"))
                         {
                             Control Ctr = (Control)f4_temp.Contrl[i];
                             MasterCommon.SetControlValue(Ctr, DataTab.Rows[0][Convert.ToInt32(f4_temp.iCol[i])-1]);
                         }
                     }            
                 }
               
            }
            else if (F4 is F4COMR)
            {
                F4COMR f4_temp = (F4COMR)F4;
                if (f4_temp.Get_Witch() == "MS" || f4_temp.Get_Witch() == "CUS")
                {
                    if (!string.IsNullOrEmpty(f4_temp.CusSql))
                    {
                        sQuery = f4_temp.CusSql;
                        sWhere = "";
                    }
                    else if (!string.IsNullOrEmpty(f4_temp.PrcoCode))
                    {
                        string callSql = "{call " + f4_temp.PrcoCode + "(";
                        string Par = "";
                        for (int i = 0; i < f4_temp.Contrl.Count; i++)
                        {
                            if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("R"))
                                Par += "'" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Replace("'", "''") + "',";
                        }
                        if (Par.Length > 0)
                            Par = Par.Substring(0, Par.Length - 1);
                        callSql = callSql + Par + ")}";

                        sQuery = callSql;
                        sWhere = "";
                    }
                    else
                    {
                        string sQuery_temp = " ";
                        string sWhere_after = "";
                        string sWhere_before = "";
                        string sOrder_Temp = " ";
                        if (f4_temp.KeyName.Trim().Length > 0 && f4_temp.Key.Trim().Length > 0)
                        {
                            sWhere_before = "where " + f4_temp.KeyName.Trim() + "='" + f4_temp.Key.Trim() + "' and ";
                        }
                        else
                        {
                            sWhere_before = "where ";
                        }
                        sQuery = " SELECT ";

                        //ƴWhere ������������� �� Select ����ֶ�
                        for (int i = 0; i < f4_temp.Contrl.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(f4_temp.BackName[i])))
                            {
                                if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("R") && !f4_temp.CtlAttr[i].ToString().ToUpper().Contains("P"))
                                    sWhere_after += "and    nvl(" + f4_temp.BackName[i].ToString().Trim() + ",'')        LIKE '%" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                else if (f4_temp.CtlAttr[i].ToString().ToUpper().Contains("P"))
                                {
                                    sWhere_after += "and    " + f4_temp.BackName[i].ToString().Trim() + "       LIKE '%" + MasterCommon.GetControlValue(f4_temp.Contrl[i]).ToString().Trim().Replace("'", "''") + "%' ";
                                    sOrder_Temp += " " + f4_temp.BackName[i].ToString().Trim() + " Asc ,";
                                }

                                if (string.IsNullOrEmpty(Convert.ToString(f4_temp.ColName[i])))
                                    sQuery_temp += " " + f4_temp.BackName[i] + " \" " + f4_temp.BackName[i] + " \",";
                                sQuery_temp += " " + f4_temp.BackName[i] + " \" " + f4_temp.ColName[i] + " \",";
                            }
                        }

                        sQuery += sQuery_temp.Substring(0, sQuery_temp.Length - 1) + "    FROM " + f4_temp.BackTableName + " ";
                        sQuery += sWhere_before;

                        sWhere_after += "    ";

                        //  if (!sWhere_before.Contains("="))
                        {
                            sWhere_after = sWhere_after.Substring(4);
                        }

                        sWhere += sWhere_after + " ";

                        sWhere += "   " + f4_temp.Join;
                        if (!string.IsNullOrEmpty(f4_temp.OrderBy))
                        {
                            sWhere += "  " + f4_temp.OrderBy;
                        }
                        else
                        {
                            sWhere += " order by " + sOrder_Temp.Substring(0, sOrder_Temp.Length - 1);
                        }
                    }
                }

                System.Data.DataTable DataTab = GeneralCommon.Gf_ExecProc2Ref(sQuery + sWhere);

                if (DataTab.Rows.Count == 1)
                {
                    int i = 0;
                    string CtlAtt = "";
                    for (i = 0; i < f4_temp.Contrl.Count; i++)
                    {
                        CtlAtt = f4_temp.CtlAttr[i].ToString().ToUpper();
                        if (CtlAtt.Contains("I"))
                        {
                            Control Ctr = (Control)f4_temp.Contrl[i];
                            MasterCommon.SetControlValue(Ctr, DataTab.Rows[0][Convert.ToInt32(f4_temp.iCol[i]) - 1]);
                        }
                    }
                }
            }
            else
            {
                throw new System.Exception("Gp_DD_Collectionû���ҵ��ؼ�" + F4.Name);
            }

        }
              

        /// <summary>
        /// ��ӿؼ���F4�ļ���
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="Ctr">�����ֵ�����Ŀؼ�</param>
        /// <param name="sAttr">�ؼ����ԡ�P:����;R;��ѯ����;I:��F4������󷵻�ֵ;B:����̨���Ĳ���</param>
        /// <param name="sBackname">��Ӧ��̨�ֶ���</param>
        /// <param name="sColName">ǰ̨��ʾ����</param>
        /// <param name="siCol">ǰ̨��Ӧ���кš���1��ʼ</param>  
        public static void Gp_DD_Collection(Control F4, object Ctr, string sAttr, string sBackname,string sColName, int siCol)
        {
            if (F4 is F4COMN)
            {
                F4COMN f4_temp = (F4COMN)F4;
                f4_temp.Contrl.Add(Ctr);
                f4_temp.CtlAttr.Add(sAttr == null ? "" : sAttr.ToUpper());
                f4_temp.ColName.Add(sColName == null ? "" : sColName);
                f4_temp.BackName.Add(sBackname == null ? "" : sBackname);
                f4_temp.iCol.Add(siCol < 1 ? 1 : siCol);
            }
            else if (F4 is F4COMR)
            {
                F4COMR f4_temp = (F4COMR)F4;
                f4_temp.Contrl.Add(Ctr);
                f4_temp.CtlAttr.Add(sAttr == null ? "" : sAttr.ToUpper());
                f4_temp.ColName.Add(sColName == null ? "" : sColName);
                f4_temp.BackName.Add(sBackname == null ? "" : sBackname);
                f4_temp.iCol.Add(siCol < 1 ? 1 : siCol);
            }
            else  
            {
                throw new System.Exception("Gp_DD_Collectionû���ҵ��ؼ�" + F4.Name);                
            }

             
        }
        /// <summary>
        /// ����F4�ؼ����������
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="sBackTableName">��Ӧ�ĺ�̨����</param>
        /// <param name="sKeyName">�����Ӧ������</param>
        /// <param name="sKeyValue">����ֵ</param>       
        /// <param name="sJoin">��������</param>
        /// <param name="sOrderBy">����˳��</param>
        /// <param name="sCusSql">�Զ���SQL���</param>
        /// <param name="sPrcoCode">�Զ����̨����.��������eg:PKG_QZA1010C.P_AMODIFY1</param>         
        public static void Gp_DD_Set(Control F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode)
        {
            Gp_DD_Set(F4, sBackTableName, sKeyName, sKeyValue, sJoin, sOrderBy, sCusSql, sPrcoCode, 9999);
        }
        /// <summary>
        /// ����F4�ؼ����������
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="sBackTableName">��Ӧ�ĺ�̨����</param>
        /// <param name="sKeyName">�����Ӧ������</param>
        /// <param name="sKeyValue">����ֵ</param>       
        /// <param name="sJoin">��������</param>
        /// <param name="sOrderBy">����˳��</param>
        /// <param name="sCusSql">�Զ���SQL���</param>
        /// <param name="sPrcoCode">�Զ����̨����.��������eg:PKG_QZA1010C.P_AMODIFY1</param>   
        /// <param name="iMaxLength">F4COMR�ĳ���</param>
        public static void Gp_DD_Set(Control F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode,int iMaxLength)
        {
            if (F4 is F4COMN)
            {
                F4COMN f4_temp = (F4COMN)F4;
                f4_temp.BackTableName = sBackTableName==null?"TZ_CD":sBackTableName;
                f4_temp.KeyName = sKeyName==null?"":sKeyName;
                f4_temp.Key = sKeyValue==null?"":sKeyValue;              
                f4_temp.OrderBy = sOrderBy==null?"":sOrderBy;
                f4_temp.Join = sJoin==null?"":sJoin;
                f4_temp.CusSql = sCusSql==null?"":sCusSql;
                f4_temp.PrcoCode = sPrcoCode==null?"":sPrcoCode;
                if (sPrcoCode!=null &&sPrcoCode.Length > 0)
                    f4_temp.Set_Witch2Cus();
            }
            else if (F4 is F4COMR)
            {
                F4COMR f4_temp = (F4COMR)F4;
                f4_temp.BackTableName = sBackTableName == null ? "TZ_CD" : sBackTableName;
                f4_temp.KeyName = sKeyName == null ? "" : sKeyName;
                f4_temp.Key = sKeyValue == null ? "" : sKeyValue;
                f4_temp.OrderBy = sOrderBy == null ? "" : sOrderBy;
                f4_temp.Join = sJoin == null ? "" : sJoin;
                f4_temp.CusSql = sCusSql == null ? "" : sCusSql;
                f4_temp.PrcoCode = sPrcoCode == null ? "" : sPrcoCode;
                f4_temp.MaxLength = iMaxLength <1 ? 9999 : iMaxLength;
                if (sPrcoCode != null && sPrcoCode.Length > 0)
                    f4_temp.Set_Witch2Cus();              
            }
            else 
            {
                throw new System.Exception("Gp_DD_Setû���ҵ��ؼ�" + F4.Name);
            }
             
        }


        /// <summary>
        /// ��ӿؼ���F4�ļ���
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="Ctr">�����ֵ�����Ŀؼ�</param>
        /// <param name="sAttr">�ؼ����ԡ�P:����;R;��ѯ����;I:��F4������󷵻�ֵ;B:����̨���Ĳ���</param>
        /// <param name="sBackname">��Ӧ��̨�ֶ���</param>
        /// <param name="sColName">ǰ̨��ʾ����</param>
        /// <param name="siCol">ǰ̨��Ӧ���кš���1��ʼ</param>  
        public static void Gp_DD_Collection(C1.Win.C1FlexGrid.Column F4, C1.Win.C1FlexGrid.Column Ctr, string sAttr, string sBackname, string sColName, int siCol)
        {
           // if (F4 is F4COMN)
           // {
                F4COMN f4_temp = (F4COMN)F4.Editor;
                f4_temp.Contrl.Add(Ctr);
                f4_temp.CtlAttr.Add(sAttr == null ? "" : sAttr.ToUpper());
                f4_temp.ColName.Add(sColName == null ? "" : sColName);
                f4_temp.BackName.Add(sBackname == null ? "" : sBackname);
                f4_temp.iCol.Add(siCol < 1 ? 1 : siCol);
          //  }
           // else if (F4 is F4COMR)
           // {
            //    F4COMR f4_temp = (F4COMR)F4;
            //    f4_temp.Contrl.Add(Ctr);
            //    f4_temp.CtlAttr.Add(sAttr == null ? "" : sAttr.ToUpper());
            //    f4_temp.ColName.Add(sColName == null ? "" : sColName);
            //    f4_temp.BackName.Add(sBackname == null ? "" : sBackname);
            //    f4_temp.iCol.Add(siCol < 1 ? 1 : siCol);
            //}
            //else
            //{
            //    throw new System.Exception("Gp_DD_Collectionû���ҵ��ؼ�" + F4.Name);
            //}


        }

        /// <summary>
        /// ����F4�ؼ����������
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="sBackTableName">��Ӧ�ĺ�̨����</param>
        /// <param name="sKeyName">�����Ӧ������</param>
        /// <param name="sKeyValue">����ֵ</param>       
        /// <param name="sJoin">��������</param>
        /// <param name="sOrderBy">����˳��</param>
        /// <param name="sCusSql">�Զ���SQL���</param>
        /// <param name="sPrcoCode">�Զ����̨����.��������eg:PKG_QZA1010C.P_AMODIFY1</param>         
        public static void Gp_DD_Set(C1.Win.C1FlexGrid.Column F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode)
        {
            Gp_DD_Set(F4, sBackTableName, sKeyName, sKeyValue, sJoin, sOrderBy, sCusSql, sPrcoCode, 9999);
        }
        /// <summary>
        /// ����F4�ؼ����������
        /// </summary>
        /// <param name="F4">F4�ؼ�</param>
        /// <param name="sBackTableName">��Ӧ�ĺ�̨����</param>
        /// <param name="sKeyName">�����Ӧ������</param>
        /// <param name="sKeyValue">����ֵ</param>       
        /// <param name="sJoin">��������</param>
        /// <param name="sOrderBy">����˳��</param>
        /// <param name="sCusSql">�Զ���SQL���</param>
        /// <param name="sPrcoCode">�Զ����̨����.��������eg:PKG_QZA1010C.P_AMODIFY1</param>   
        /// <param name="iMaxLength">F4COMR�ĳ���</param>
        public static void Gp_DD_Set(C1.Win.C1FlexGrid.Column F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode, int iMaxLength)
        {
            F4COMN f4_temp =new F4COMN();
            f4_temp.BackTableName = sBackTableName == null ? "TZ_CD" : sBackTableName;
            f4_temp.KeyName = sKeyName == null ? "" : sKeyName;
            f4_temp.Key = sKeyValue == null ? "" : sKeyValue;
            f4_temp.OrderBy = sOrderBy == null ? "" : sOrderBy;
            f4_temp.Join = sJoin == null ? "" : sJoin;
            f4_temp.CusSql = sCusSql == null ? "" : sCusSql;
            f4_temp.PrcoCode = sPrcoCode == null ? "" : sPrcoCode;
            if (sPrcoCode != null && sPrcoCode.Length > 0)
                f4_temp.Set_Witch2Cus();
            F4.Editor = f4_temp;
            //if (F4 is F4COMN)
            //{
            //    F4COMN f4_temp = (F4COMN)F4;
            //    f4_temp.BackTableName = sBackTableName == null ? "TZ_CD" : sBackTableName;
            //    f4_temp.KeyName = sKeyName == null ? "" : sKeyName;
            //    f4_temp.Key = sKeyValue == null ? "" : sKeyValue;
            //    f4_temp.OrderBy = sOrderBy == null ? "" : sOrderBy;
            //    f4_temp.Join = sJoin == null ? "" : sJoin;
            //    f4_temp.CusSql = sCusSql == null ? "" : sCusSql;
            //    f4_temp.PrcoCode = sPrcoCode == null ? "" : sPrcoCode;
            //    if (sPrcoCode != null && sPrcoCode.Length > 0)
            //        f4_temp.Set_Witch2Cus();
            //}
            //else if (F4 is F4COMR)
            //{
            //    F4COMR f4_temp = (F4COMR)F4;
            //    f4_temp.BackTableName = sBackTableName == null ? "TZ_CD" : sBackTableName;
            //    f4_temp.KeyName = sKeyName == null ? "" : sKeyName;
            //    f4_temp.Key = sKeyValue == null ? "" : sKeyValue;
            //    f4_temp.OrderBy = sOrderBy == null ? "" : sOrderBy;
            //    f4_temp.Join = sJoin == null ? "" : sJoin;
            //    f4_temp.CusSql = sCusSql == null ? "" : sCusSql;
            //    f4_temp.PrcoCode = sPrcoCode == null ? "" : sPrcoCode;
            //    f4_temp.MaxLength = iMaxLength < 1 ? 9999 : iMaxLength;
            //    if (sPrcoCode != null && sPrcoCode.Length > 0)
            //        f4_temp.Set_Witch2Cus();
            //}
            //else
            //{
            //    throw new System.Exception("Gp_DD_Setû���ҵ��ؼ�" + F4.Name);
            //}

        }

    }
}
