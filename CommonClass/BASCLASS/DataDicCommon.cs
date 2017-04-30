using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public class DataDicCommon
    {
        //---------------------------------------------------------------------------------------
        //  1.ID           : Gf_DD_Display
        //  2.Input  Value : Conn Connection, sQuery String, [MsgChk Boolean]
        //  3.Return Value : Boolean
        //  4.Create Date  :  
        //  5.Modify Date  : 
        //  6.Comment      : Data Dictionary Result Data Display
        //---------------------------------------------------------------------------------------
        public static bool Gf_DD_Display(System.Data.OleDb.OleDbConnection Conn, string sQuery, bool MsgChk)
        {
            bool functionReturnValue = false;
            DataDic DataDic = new DataDic();
            int iCollCnt = 0;
            int iColcount = 0;

            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    functionReturnValue = false;
                    GeneralCommon.Gp_DD_Clear();
                    int rCount = GeneralCommon.rControl.Count;

                    for (iCollCnt = 0; iCollCnt < rCount; iCollCnt++)
                    {
                        GeneralCommon.rControl.Remove(0);
                    }

                    GeneralCommon.DD.sPname = "";
                    return functionReturnValue;
                }
            }

            System.Data.DataSet DS = new System.Data.DataSet();

            try
            {
                System.Data.OleDb.OleDbDataAdapter OleDA = new System.Data.OleDb.OleDbDataAdapter(sQuery, Conn);
                OleDA.Fill(DS);

                if (DS.Tables[0].Rows.Count == 0)
                {
                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I");
                    }

                    DataDic.ssResult.Cols.Count = DS.Tables[0].Columns.Count;
                    DataDic.ssWhere.Cols.Count = DS.Tables[0].Columns.Count;
                    //DataDic.ssResult.Sheets[0].ColumnCount = DS.Tables[0].Columns.Count;// AdoRs.Fields.Count; 
                    //DataDic.ssWhere.Sheets[0].ColumnCount = DS.Tables[0].Columns.Count;//AdoRs.Fields.Count; 

                    DataDic.ssResult.Rows.Count = 0;
                    DataDic.ssWhere.Rows.Count = 1;
                    //DataDic.ssResult.Sheets[0].RowCount = 0;
                    //DataDic.ssWhere.Sheets[0].RowCount = 1;

                    DataDic.ssResult.DataSource = DS;
                    DataDic.ssWhere_setting();
                    //DataDic.ssResult.DataSource = DS;
                    //DataDic.ssWhere_setting();

                    for (iColcount = 0; iColcount < DataDic.ssResult.Cols.Count; iColcount++)
                    {
                        DataDic.ssResult.Cols.MinSize = 80;
                        DataDic.ssWhere.Cols.MinSize = 80;
                        DataDic.ssResult.AllowEditing = false;

                        if (GeneralCommon.DD.DataDicType == "E")
                        {
                            DataDic.ssWhere[0, iColcount] = GeneralCommon.rControl[iColcount ].ToString();
                        }
                    }

                    if (GeneralCommon.DD.DicRefType == "C")
                    {
                        DataDic.ShowDialog();
                    }

                    functionReturnValue = false;
                    return functionReturnValue;
                }

                Cursor.Current = Cursors.WaitCursor;
                functionReturnValue = true;
                //DataDic.ssResult.Cols.Count = DS.Tables[0].Columns.Count;
                DataDic.ssWhere.Cols.Count = DS.Tables[0].Columns.Count+1;
               // DataDic.ssWhere.Cols[0].Width = 80;
               // DataDic.ssResult.Rows.Count = 1;
                DataDic.ssWhere.Rows.Count = 2;
                DataDic.ssResult.DataSource = DS.Tables[0];
                DataDic.ssResult.Cols.Count = DS.Tables[0].Columns.Count+1;
                DataDic.ssWhere_setting();

                for (iColcount = 0; iColcount < DataDic.ssResult.Cols.Count-1; iColcount++)
                {
                    DataDic.ssWhere.Cols[iColcount+1].Caption = DS.Tables[0].Columns[iColcount].ColumnName;
                    DataDic.ssResult.Cols[iColcount].Width = 80;
                    DataDic.ssWhere.Cols[iColcount+1].Width = 80;

                    DataDic.ssResult.Cols[iColcount].AllowEditing = false;

                    if (GeneralCommon.DD.DataDicType == "E")
                    {
                        DataDic.ssWhere.Cols[iColcount].Caption = GeneralCommon.rControl[iColcount].ToString();
                    }
                }

                Cursor.Current = Cursors.Default;

                if (GeneralCommon.DD.DicRefType == "C")
                {
                    DataDic.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                functionReturnValue = false;
                GeneralCommon.Gp_DD_Clear();
                GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);
                GeneralCommon.DD.sPname = "";
                functionReturnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay("DD_Display Error : " + ex.Message);
                Cursor.Current = Cursors.Default;
            }

            return functionReturnValue;
        }

        public static bool Gf_Common_DD(System.Data.OleDb.OleDbConnection Conn, Keys KeyCode)
        {
            SpreadCommon SpreadCommon = new SpreadCommon();
          //  int iCollCnt;
            string sOld_Code = "";
            string sNew_Code = "";
            string sOld_Name = string.Empty, sNew_Name = string.Empty;
          

            /* 如果退出F4窗口. */
            if (GeneralCommon.GF_DbConnect()==false ||KeyCode == Keys.Return || KeyCode == Keys.Escape)
            {
                GeneralCommon.Gp_DD_Clear();
              //  int rCount = GeneralCommon.rControl.Count;
                GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);

               
                GeneralCommon.DD.sPname = null;
                

                return false;
            }

            if (GeneralCommon.rControl.Count == 0 || GeneralCommon.DD.nameType == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("DataDic 参数有错误...!!!", "I");
                GeneralCommon.Gp_DD_Clear();
               // int rCount = GeneralCommon.rControl.Count;
                GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);
                //for (iCollCnt = 1; iCollCnt <= rCount; iCollCnt++)
                //{
                //    GeneralCommon.rControl.Remove(1);
                //}

                GeneralCommon.DD.sPname = null;
           

                return false;
            }

            GeneralCommon.DD.DataDicType = "M";     //Common Code
            GeneralCommon.DD.DicRefType = "C";      //Active Form DataDic Call
            
            try
            {
                if (GeneralCommon.DD.sWitch == "MS" || GeneralCommon.DD.sWitch == "CUS")
                {
                    if (!string.IsNullOrEmpty( GeneralCommon.DD.sCusCode))
                    {
                        GeneralCommon.DD.sQuery = GeneralCommon.DD.sCusCode;
                        GeneralCommon.DD.sWhere = "";
                    }
                    else if (!string.IsNullOrEmpty(GeneralCommon.DD.sPrcoCode))
                    {
                        string callSql = "{call " + GeneralCommon.DD.sPrcoCode + "(";// +iType + "',";
                        string Par = "";
                        for (int i = 0; i < GeneralCommon.DD.sParameters.Count; i++)
                        {
                            Par+="'"+GeneralCommon.DD.sParameters[i].ToString().Replace("'","''")+"',";
                        }
                        if (Par.Length > 0)
                            Par = Par.Substring(0, Par.Length - 1);
                        callSql = callSql + Par + ")}";

                        GeneralCommon.DD.sQuery = callSql;
                        GeneralCommon.DD.sWhere = "";
                    }
                    else
                    {
                        GeneralCommon.DD.sQuery = "            SELECT CD \"代码\"  ";
                        switch (GeneralCommon.DD.nameType)
                        {
                            case "1":
                                { GeneralCommon.DD.sQuery += "  ,CD_SHORT_NAME \"代码简称\""; break; }
                            case "2":
                                { GeneralCommon.DD.sQuery += "  ,  CD_NAME \"代码名称\""; break; }
                            case "3":
                                { GeneralCommon.DD.sQuery += " ,CD_SHORT_ENG \"代码英文简称\""; break; }
                            case "4":
                                { GeneralCommon.DD.sQuery += "  ,  CD_FULL_ENG \"代码英文名称\""; break; }
                        }
                      //  GeneralCommon.DD.sQuery = "            SELECT CD \"代码\"  ";//CD_SHORT_NAME \"代码简称\",     CD_NAME \"代码名称\", ";
                        GeneralCommon.DD.sQuery += "    FROM TZ_CD ";
                        GeneralCommon.DD.sQuery += "            WHERE CD_MANA_NO =   '" + GeneralCommon.DD.sKey.Trim() + "' ";
                        /* 选择查询条件, 公共代码. */
                        GeneralCommon.DD.sWhere += "              and CD         LIKE '" + ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[0])).Text.Trim() + "%' ";

                        if (GeneralCommon.rControl.Count > 0)
                        {
                            /* 选择查询的内容 CD_NAME显示的内容. */
                            switch (GeneralCommon.DD.nameType)
                            {
                                case "1":
                                    { GeneralCommon.DD.sWhere += "  and NVL(CD_SHORT_NAME,'%') LIKE '%" + ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text + "%'"; break; }
                                case "2":
                                    { GeneralCommon.DD.sWhere += "  and NVL(CD_NAME,'%')       LIKE '%" + ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text + "%'"; break; }
                                case "3":
                                    { GeneralCommon.DD.sWhere += "  and NVL(CD_SHORT_ENG,'%')  LIKE '%" + ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text + "%'"; break; }
                                case "4":
                                    { GeneralCommon.DD.sWhere += "  and NVL(CD_FULL_ENG,'%')   LIKE '%" + ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text + "%'"; break; }
                            }
                        }

                        GeneralCommon.DD.sWhere += " and CD        <>  ' ' ";
                        GeneralCommon.DD.sWhere += " and APLY_STD  =   '1' ";

                        if (!string.IsNullOrEmpty(GeneralCommon.DD.sJoin))
                        {
                            GeneralCommon.DD.sWhere += " and " + GeneralCommon.DD.sJoin + "Order by CD";
                        }
                    }
                }
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;
   
                    /* 取出当前单元格编辑的内容. */
                    sOld_Code = "";//oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0])].ToString();

                    GeneralCommon.DD.sQuery = "            SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\",    CD_NAME \"代码名称\", ";
                    GeneralCommon.DD.sQuery += "                               CD_SHORT_ENG \"代码英文简称\", CD_FULL_ENG \"代码英文名称\" FROM TZ_CD ";
                    GeneralCommon.DD.sQuery += "            WHERE CD_MANA_NO =    '" + GeneralCommon.DD.sKey.Trim() + "' ";
                    GeneralCommon.DD.sWhere += "              and  CD         LIKE '" + sOld_Code.Trim() + "%' ";

                    /* 判断当前传入查询参数的个数. */
                    if (GeneralCommon.rControl.Count > 0)
                    {
                        //sOld_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(((System.Windows.Forms.TextBox)(GeneralCommon.rControl[2])).Text)].ToString();
                        sOld_Code = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0])].ToString();

                        switch (GeneralCommon.DD.nameType)
                        {
                            case "1":
                                {
                                    GeneralCommon.DD.sWhere += "  and NVL(CD_SHORT_NAME,'%') LIKE '" + sOld_Name.Trim() + "%' ";
                                    break;
                                }
                            case "2":
                                {
                                    GeneralCommon.DD.sWhere += "  and NVL(CD_NAME,'%')       LIKE '" + sOld_Name.Trim() + "%' ";
                                    break;
                                }
                            case "3":
                                {
                                    GeneralCommon.DD.sWhere += "  and NVL(CD_SHORT_ENG,'%')  LIKE '" + sOld_Name.Trim() + "%' ";
                                    break;
                                }
                            case "4":
                                {
                                    GeneralCommon.DD.sWhere += "  and NVL(CD_FULL_ENG,'%')   LIKE '" + sOld_Name.Trim() + "%' ";
                                    break;
                                }
                            /* 如果没有当前的附加条件. */
                            default:
                                break;
                        }

                        GeneralCommon.DD.sWhere += " AND CD !=  ' ' ";
                        GeneralCommon.DD.sWhere += " AND APLY_STD = '1' ";

                        if (!string.IsNullOrEmpty(GeneralCommon.DD.sJoin))
                        {
                            GeneralCommon.DD.sWhere += " and " + GeneralCommon.DD.sJoin + "Order by CD";
                        }
                    }
                }

                //Join
                //if (GeneralCommon.DD.sJoin != "")
                //{
                //    if (GeneralCommon.DD.sJoin != null)
                //    {
                       
                //    }
                //}

                if (Gf_DD_Display(Conn, GeneralCommon.DD.sQuery + GeneralCommon.DD.sWhere, false))
                {
                    /* F4 窗口退出处理程序 [FlexGrid中的F4功能] */
                    if (GeneralCommon.DD.sWitch == "SP")
                    {
                        /* 如果当前为 Spread F4 控件. */
                        FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;
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

                        if (GeneralCommon.DD.sSelect)
                        {
                            if (sOld_Code != sNew_Code)
                                SpreadCommon.Gp_Sp_UpdateMark(oFlexGrid, true);
                        }
                    }
                }

                #region /* 清空变量. */
                GeneralCommon.Gp_DD_Clear();
                // int rCount = GeneralCommon.rControl.Count;
                GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);
                //for (iCollCnt = 1; iCollCnt <= rCount; iCollCnt++)
                //{
                //    GeneralCommon.rControl.Remove(1);
                //}

                GeneralCommon.DD.sPname = null;
               
               // GeneralCommon.DD.sWitch = "";
               // GeneralCommon.DD.sSelect = false;
               // GeneralCommon.DD.sPname = "";
               // GeneralCommon.DD.sWhere = "";
               #endregion

               //// int rCount1 = GeneralCommon.rControl.Count;
               // GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);

                return true;
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_DD_Clear();
                // int rCount = GeneralCommon.rControl.Count;
                GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);
                //for (iCollCnt = 1; iCollCnt <= rCount; iCollCnt++)
                //{
                //    GeneralCommon.rControl.Remove(1);
                //}

                GeneralCommon.DD.sPname = null;
             
             //   GeneralCommon.rControl.RemoveRange(0, GeneralCommon.rControl.Count);
                //MessageBox.Show(ex.ToString());
                GeneralCommon.Gp_MsgBoxDisplay("DataDic 查询出错啦...!!!" + ex.Message, "I");
                return false;
            }
        }

        public static string Gf_CommNameFind(System.Data.OleDb.OleDbConnection Conn, string Cd_Mana_No, string Code, string nameType)
        {
            string functionReturnValue = "";
            string sQuery = null;

            try
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    functionReturnValue = "";
                    return functionReturnValue;
                }

                switch (nameType)
                {
                    case "1":
                        //Short Name 
                        sQuery = "SELECT CD_SHORT_NAME FROM TZ_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                        break;
                    case "2":
                        //Full Name 
                        sQuery = "SELECT CD_NAME FROM TZ_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                        break;
                    case "3":
                        //Short Eng Name 
                        sQuery = "SELECT CD_SHORT_ENG FROM TZ_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                        break;
                    case "4":
                        //Full Eng Name 
                        sQuery = "SELECT CD_FULL_ENG FROM TZ_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                        break;
                    default:
                        //Full Name 
                        sQuery = "SELECT CD_NAME FROM TZ_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                        break;
                }

                System.Data.OleDb.OleDbCommand Oc = new System.Data.OleDb.OleDbCommand(sQuery, Conn);
                //Ado Execute 
                if (Oc.ExecuteScalar() == null)
                    functionReturnValue = "";
                else
                    functionReturnValue = Oc.ExecuteScalar().ToString();
            }

            catch (Exception ex)
            {
                // AdoRs = null;
                functionReturnValue = "";
                GeneralCommon.Gp_MsgBoxDisplay("Gf_CommNameFind Error : " + ex.Message);
            }
            return functionReturnValue;

        }

    }
}
