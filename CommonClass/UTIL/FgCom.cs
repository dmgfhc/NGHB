using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public enum RowType
    {
        Normal  ,
        Input ,
        Update,
        Delete
    }

    public class FgCom
    {
        public const string InsertMask = "插入";
        public const string UpdateMask = "修改";
        public const string DeleteMask = "删除";


        //***************penglei***************//
        //return :0:普通行,1:Input行,2:Update行,3:Delete行
       public static int GF_RowType(FlexGrid_User fg , int iRow) 
       {
         try
           {
               switch (fg.Rows[iRow].Caption)
               {
                   case "插入":
                       return 1; // return RowType.Input;
                   case "修改":
                       return 2; //return RowType.Update;
                   case "删除":
                       return 3; //return RowType.Delete;
                   default:
                       return 4; //return RowType.Normal;
               }

           }
        catch// (OverflowException ex)
            {
              //Throw New Exception("GF_RowType error:" & ex.Message)
                return 4; // RowType.Normal;
            }
        }

        public static void Gp_Sp_SendData(FlexGrid_User oFlexGrid, string Indata,int iRow, string iColName)
        {
            Gp_Sp_SendData(oFlexGrid, Indata,  iRow,FG_ColIndexFind(oFlexGrid, iColName));
        }
        public static void Gp_Sp_SendData(FlexGrid_User oFlexGrid, string Indata, int iRow, int iCol)
        {
            
            oFlexGrid.Rows[iRow][iCol] = Indata;
        }
        //public static void Gp_Sp_SendData(FlexGrid_User oFlexGrid, string Indata, int iRow, int iCol)
        //{
        //    oFlexGrid.Rows[iRow][iCol] = Indata;
        //}
        //***************penglei***************//


        public static int FG_ColIndexFind(FlexGrid_User oFlexGrid, string sColName)
        {
            try
            {
                foreach (C1.Win.C1FlexGrid.Column col in oFlexGrid.Cols)
                {
                    if (sColName == col.Caption)
                    {
                        return col.Index;
                    }
                }

                GeneralCommon.Gp_MsgBoxDisplay("未找到指定列名！");
                return -1;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public static C1.Win.C1FlexGrid.Column FG_ColObjectFind(FlexGrid_User oFlexGrid, string sColName)
        {
            try
            {
                foreach (C1.Win.C1FlexGrid.Column col in oFlexGrid.Cols)
                {
                    if (sColName == col.Caption)
                    {
                        return col;
                    }
                }

                GeneralCommon.Gp_MsgBoxDisplay("未找到指定列名！");
                return null;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static string FG_ColName(FlexGrid_User oFlexGrid, int ColIndex)
        {
            try
            {
                return oFlexGrid.Cols[ColIndex].Caption;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static string GF_CellFind(FlexGrid_User oFlexGrid, string iColName)
        {
         
            try
            {
                if (oFlexGrid.Rows.Count>0&&oFlexGrid.RowSel<1)
                {
                    oFlexGrid.RowSel = 0;
                }
                int icol = FG_ColIndexFind(oFlexGrid, iColName);
                if (icol > 0)
                {

                    return oFlexGrid.Rows[oFlexGrid.RowSel][icol].ToString();
                }
                else
                {
                    return string.Empty;
                }
             
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
        }
    }
}
