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

            /* 如果退出F4窗口. */
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

                        //拼Where 后面的限制条件 和 Select 后的字段
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
                {//带检查
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

                        //拼Where 后面的限制条件 和 Select 后的字段
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

                    ///* 取出当前单元格编辑的内容. */
                    //sOld_Code = "";//oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0])].ToString();

                    //GeneralCommon.DD_New.sQuery = "            SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\",    CD_NAME \"代码名称\", ";
                    //GeneralCommon.DD_New.sQuery += "                               CD_SHORT_ENG \"代码英文简称\", CD_FULL_ENG \"代码英文名称\" FROM TZ_CD ";
                    //GeneralCommon.DD_New.sQuery += "            WHERE CD_MANA_NO =    '" + GeneralCommon.DD.sKey.Trim() + "' ";
                    //GeneralCommon.DD_New.sWhere += "              and  CD         LIKE '" + sOld_Code.Trim() + "%' ";

                    ///* 判断当前传入查询参数的个数. */
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
                    /* F4 窗口退出处理程序 [FlexGrid中的F4功能] */
                    if (GeneralCommon.DD_New.sWitch == "SP")
                    {
                        /* 如果当前为 Spread F4 控件. */
                        FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD_New.sPname;
                        sNew_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32((GeneralCommon.rControl[0]))].ToString();

                        if (GeneralCommon.rControl.Count > 0)
                        {
                            sNew_Name = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32((GeneralCommon.rControl[0]))].ToString();
                        }

                        switch (oFlexGrid.Rows[oFlexGrid.RowSel].Caption)
                        {
                            case "插入":
                                break;
                            case "删除":
                                break;
                            case "修改":
                                break;
                            default:
                                {
                                    //ss.ActiveSheet.RowHeader.Cells[ss.ActiveSheet.ActiveRowIndex, 0].Text = "Update";
                                    oFlexGrid.Rows[oFlexGrid.RowSel].Caption = "修改";
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
                GeneralCommon.Gp_MsgBoxDisplay("DataDic 查询出错啦...!!!" + ex.Message, "I");
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
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I");
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

                        //拼Where 后面的限制条件 和 Select 后的字段
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

                        //拼Where 后面的限制条件 和 Select 后的字段
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
                throw new System.Exception("Gp_DD_Collection没有找到控件" + F4.Name);
            }

        }
              

        /// <summary>
        /// 添加控件至F4的集合
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="Ctr">数据字典包括的控件</param>
        /// <param name="sAttr">控件属性。P:主键;R;查询条件;I:需F4查出来后返回值;B:往后台传的参数</param>
        /// <param name="sBackname">对应后台字段名</param>
        /// <param name="sColName">前台显示列名</param>
        /// <param name="siCol">前台对应的列号。从1开始</param>  
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
                throw new System.Exception("Gp_DD_Collection没有找到控件" + F4.Name);                
            }

             
        }
        /// <summary>
        /// 设置F4控件的相关属性
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="sBackTableName">对应的后台表名</param>
        /// <param name="sKeyName">代码对应的列名</param>
        /// <param name="sKeyValue">代码值</param>       
        /// <param name="sJoin">限制条件</param>
        /// <param name="sOrderBy">排序顺序</param>
        /// <param name="sCusSql">自定义SQL语句</param>
        /// <param name="sPrcoCode">自定义后台包名.过程名。eg:PKG_QZA1010C.P_AMODIFY1</param>         
        public static void Gp_DD_Set(Control F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode)
        {
            Gp_DD_Set(F4, sBackTableName, sKeyName, sKeyValue, sJoin, sOrderBy, sCusSql, sPrcoCode, 9999);
        }
        /// <summary>
        /// 设置F4控件的相关属性
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="sBackTableName">对应的后台表名</param>
        /// <param name="sKeyName">代码对应的列名</param>
        /// <param name="sKeyValue">代码值</param>       
        /// <param name="sJoin">限制条件</param>
        /// <param name="sOrderBy">排序顺序</param>
        /// <param name="sCusSql">自定义SQL语句</param>
        /// <param name="sPrcoCode">自定义后台包名.过程名。eg:PKG_QZA1010C.P_AMODIFY1</param>   
        /// <param name="iMaxLength">F4COMR的长度</param>
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
                throw new System.Exception("Gp_DD_Set没有找到控件" + F4.Name);
            }
             
        }


        /// <summary>
        /// 添加控件至F4的集合
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="Ctr">数据字典包括的控件</param>
        /// <param name="sAttr">控件属性。P:主键;R;查询条件;I:需F4查出来后返回值;B:往后台传的参数</param>
        /// <param name="sBackname">对应后台字段名</param>
        /// <param name="sColName">前台显示列名</param>
        /// <param name="siCol">前台对应的列号。从1开始</param>  
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
            //    throw new System.Exception("Gp_DD_Collection没有找到控件" + F4.Name);
            //}


        }

        /// <summary>
        /// 设置F4控件的相关属性
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="sBackTableName">对应的后台表名</param>
        /// <param name="sKeyName">代码对应的列名</param>
        /// <param name="sKeyValue">代码值</param>       
        /// <param name="sJoin">限制条件</param>
        /// <param name="sOrderBy">排序顺序</param>
        /// <param name="sCusSql">自定义SQL语句</param>
        /// <param name="sPrcoCode">自定义后台包名.过程名。eg:PKG_QZA1010C.P_AMODIFY1</param>         
        public static void Gp_DD_Set(C1.Win.C1FlexGrid.Column F4, string sBackTableName, string sKeyName, string sKeyValue, string sJoin, string sOrderBy, string sCusSql, string sPrcoCode)
        {
            Gp_DD_Set(F4, sBackTableName, sKeyName, sKeyValue, sJoin, sOrderBy, sCusSql, sPrcoCode, 9999);
        }
        /// <summary>
        /// 设置F4控件的相关属性
        /// </summary>
        /// <param name="F4">F4控件</param>
        /// <param name="sBackTableName">对应的后台表名</param>
        /// <param name="sKeyName">代码对应的列名</param>
        /// <param name="sKeyValue">代码值</param>       
        /// <param name="sJoin">限制条件</param>
        /// <param name="sOrderBy">排序顺序</param>
        /// <param name="sCusSql">自定义SQL语句</param>
        /// <param name="sPrcoCode">自定义后台包名.过程名。eg:PKG_QZA1010C.P_AMODIFY1</param>   
        /// <param name="iMaxLength">F4COMR的长度</param>
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
            //    throw new System.Exception("Gp_DD_Set没有找到控件" + F4.Name);
            //}

        }

    }
}
