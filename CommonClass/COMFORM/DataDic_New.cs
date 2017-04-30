using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class DataDic_New : Form
    {
        public DataDic_New()
        {
            InitializeComponent();
        }

        private void DataDic_Load(object sender, EventArgs e)
        {
            GeneralCommon.Gp_FormLoc_Get(this, GeneralCommon.DD.DataDicType);          
            this.KeyPreview = true;           
        }

        private void DataDic_Activated(object sender, EventArgs e)
        {
            if (ssWhere.Cols.Count < 2)
            { 
                this.Close();
                return;
            }
            ssWhere_setting();
            ssResult_setting();        
                    
            if (GeneralCommon.DD_New.sWitch == "CUS" || GeneralCommon.DD_New.sWitch == "MS")
            {  
                if(GeneralCommon.DD_New.DicRefType=="C" )
                for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                {
                     if (GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("R") || GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("P"))
                        ssWhere[1, Convert.ToInt32(GeneralCommon.DD_New.siCol[i])] = MasterCommon.GetControlValue(GeneralCommon.DD_New.sContrl[i]);
                }
            }
            else if (GeneralCommon.DD_New.sWitch == "SP")
            {//待检查
                FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD_New.sPname;
                if (GeneralCommon.DD_New.DicRefType == "C")
                    for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                    {
                        if (GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("R") || GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("P"))
                            ssWhere[1, Convert.ToInt32(GeneralCommon.DD_New.siCol[i])] = SpreadCommon.GetCellValue((FlexGrid_User)GeneralCommon.DD_New.sPname, ((FlexGrid_User)GeneralCommon.DD_New.sPname).RowSel, ((C1.Win.C1FlexGrid.Column)GeneralCommon.DD_New.sContrl[i]).Index).ToString().Trim();
                    }
                // ssWhere[1,1] = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0].ToString())].ToString();
            }
            ssWhere.Select(1, 1);
          
            this.BackColor = GeneralCommon.VbFormBKColor;
        }

        private void DataDic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void DataDic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void DataDic_Resize(object sender, EventArgs e)
        {
            /* 对最上面的panel的大小作设置. */
            if (this.Width - pnl_button.Left > 1)
            {
                pnl_button.Width = this.Width - 16;
            }

            /* 设置当前窗口的宽度 */
            if (this.Width - pnl_condition.Left > 1)
            {
                pnl_condition.Width = this.Width - 16;
            }

            if (this.Width - pnl_result.Left > 1)
            {
                pnl_result.Width = this.Width - 16;
            }

            // Panel Height Setting 
            if (this.Height - 120 > 1)
            {
                pnl_result.Height = this.Height - 168;
            }

            // Spread Width Setting (ssWhere) 
            if (this.Width - ssWhere.Left > 1)
            {
                ssWhere.Width = this.Width - 28;
            }

            // Spread Width Setting (ssResult) 
            if (this.Width - ssResult.Left > 1)
            {
                ssResult.Width = this.Width - 28;
            }

            if (pnl_result.Height - 100 > 1)
            {
                ssResult.Height = pnl_result.Height - 12;
            }
        }

        private void DataDic_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {          

           // GeneralCommon.Gp_FormLoc_Set(this, GeneralCommon.DD_New.DataDicType);
            GeneralCommon.Gp_DD_New_Clear();       
        }

        #region "Spread Setting.."
        public void ssWhere_setting()
        {            
            ssWhere.Height = 15;
            ssWhere.Rows[0].Height = 20;
            ssWhere.Rows.Count = 2;
            ssWhere.Cols[0].Width = 50;         
        }

        public void ssResult_setting()
        {           
            ssResult.Height = 15;            
            ssResult.Rows[0].Height = 20;
            ssResult.Cols[0].Width = 50;
        }

        #endregion

        #region "Button Click..."
        public virtual void cmd_refresh_Click(object sender, EventArgs e)
        {                 
            string sQuery = "";
            GeneralCommon.DD_New.DicRefType = "R";
            string sOrder_Temp = " ";
            if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sPrcoCode))
            {
                string callSql = "{call " + GeneralCommon.DD_New.sPrcoCode + "(";
                string Par = "";
                for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                {
                    object obj = ssWhere.Rows[1][Convert.ToInt32(GeneralCommon.DD_New.siCol[i])];
                    if (obj == null)
                        obj = "";
                    if (GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("P") || GeneralCommon.DD_New.sCtlAttr[i].ToString().Contains("R"))
                        Par += "'" + obj.ToString().Trim().Replace("'", "''") + "',";
                }               
                if (Par.Length > 0)
                    Par = Par.Substring(0, Par.Length - 1);
              
                callSql = callSql + Par + ")}";

                GeneralCommon.DD_New.sQuery = callSql;
                GeneralCommon.DD_New.sWhere = "";
                sQuery = "";
            }
            else
            {
                for (int i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                {
                    object obj = ssWhere.Rows[1][Convert.ToInt32(GeneralCommon.DD_New.siCol[i])];
                    if (obj == null)
                        obj = "";
                        if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("R") && !GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                            sQuery += "and    nvl(" + GeneralCommon.DD_New.sBackName[i].ToString().Trim() +  ",f_nullvalue('"+GeneralCommon.DD_New.sBackTableName+"','"+ GeneralCommon.DD_New.sBackName[i].ToString().Trim()+"'))       LIKE '%" + obj.ToString().Trim().Replace("'", "''") + "%'  ";
                        else if (GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper().Contains("P"))
                        {
                            sQuery += "and    " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + "       LIKE '%" + obj.ToString().Trim().Replace("'", "''") + "%'  ";
                            sOrder_Temp += " " + GeneralCommon.DD_New.sBackName[i].ToString().Trim() + " Asc ,";
                        }
                }             
                    
                sQuery += "    " + GeneralCommon.DD_New.sJoin;

                if (!string.IsNullOrEmpty(GeneralCommon.DD_New.sOrderBy))
                {
                    sQuery += "     " + GeneralCommon.DD_New.sOrderBy;
                }
                else
                {
                    sQuery += "     order by " + sOrder_Temp.Substring(0, sOrder_Temp.Length - 1);
                }
                //sQuery += "    " + GeneralCommon.DD_New.sOrderBy;
              
               // if (GeneralCommon.DD_New.sQuery.ToUpper().Trim().EndsWith("WHERE"))
                {
                    sQuery = sQuery.Substring(4);
                }
            }
                Gf_DD_ReSelctDisp(GeneralCommon.DD_New.sQuery + sQuery,false);

            //GeneralCommon.Gp_FormLoc_Get(this, GeneralCommon.DD.DataDicType);           
        }

        private void cmd_selection_Click(object sender, EventArgs e)
        {
            ssResult2Ctl();          
            this.Close();
        }

        #region "Spread ReDisplay..."
        public bool Gf_DD_ReSelctDisp( string sQuery, bool MsgChk) // ERROR: Optional parameters aren't supported in C# bool MsgChk) 
        {
            bool functionReturnValue = false;           
          
            try
            {
                System.Data.DataTable DataTab = GeneralCommon.Gf_ExecProc2Ref(sQuery);

                ssResult.Cols.Count = DataTab.Columns.Count + 1;
                ssWhere.Cols.Count = DataTab.Columns.Count + 1;

                ssResult.DataSource = DataTab;
                ssResult.AllowEditing = false;
                ssResult.Cols.MinSize = 30;
                ssWhere.Cols.MinSize = 30;  
                if (DataTab.Rows.Count == 0)
                {
                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I");
                    }                   

                    functionReturnValue = false;
                    return functionReturnValue;
                }
               
                functionReturnValue = true;
             
                for (int iColcount = 1; iColcount < ssResult.Cols.Count ; iColcount++)
                {                  
                   ssResult.Cols[iColcount].Width = 80;
                   ssWhere.Cols[iColcount].Width = 80;   
                }              
                
            }
            catch (Exception ex)
            {
                functionReturnValue = false;
                GeneralCommon.Gp_DD_Clear();
                GeneralCommon.Gp_MsgBoxDisplay("DD_Display Error : " + ex.Message);
                Cursor.Current = Cursors.Default;
            }

            return functionReturnValue;         
        }

        #endregion

        /* 点击关闭按钮. */
        private void cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion



        #region "Spread Event.."


        /* 查询记录的选择对应的双击操作. */
        private void ssResult_DoubleClick(object sender, EventArgs e)
        {           
            ssResult2Ctl();          

            this.Close();
        }

        private void ssResult2Ctl()
        {
  
            if (ssResult.Rows.Count > 1)
                if (GeneralCommon.DD_New.sWitch == "MS" || GeneralCommon.DD_New.sWitch == "CUS")
                {
                    /* 控件F4涉及到两个信息 CD/CD_NAME两个信息分别填写在TextBox的两个部分. */
                    /* rControl[1] 保存CD, rControl[2] 保存CD_NAME.   
                     * */
                    int i=0;
                    string CtlAtt = "";
                    for ( i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                    {
                        CtlAtt = GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper();
                        if ( CtlAtt.Contains("I"))
                        {
                            Control Ctr = (Control)GeneralCommon.DD_New.sContrl[i];
                            MasterCommon.SetControlValue(Ctr,ssResult[ssResult.RowSel, Convert.ToInt32(GeneralCommon.DD_New.siCol[i])].ToString());                  
                        }
                    }            
                }               
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD_New.sPname;
                    /* 只将代码赋值给原来的F4列上. */
                  //  oFlexGrid[oFlexGrid.RowSel, oFlexGrid.ColSel] = ssResult[ssResult.RowSel, 1].ToString();
                    int i = 0;
                    string CtlAtt = "";
                    for (i = 0; i < GeneralCommon.DD_New.sContrl.Count; i++)
                    {
                        CtlAtt = GeneralCommon.DD_New.sCtlAttr[i].ToString().ToUpper();
                        if (CtlAtt.Contains("I"))
                        {
                           // Control Ctr = (Control)GeneralCommon.DD_New.sContrl[i];
                            SpreadCommon.SetCellValue(oFlexGrid, oFlexGrid.RowSel, ((C1.Win.C1FlexGrid.Column)GeneralCommon.DD_New.sContrl[i]).Index, ssResult[ssResult.RowSel, Convert.ToInt32(GeneralCommon.DD_New.siCol[i])].ToString());
                        }
                    }            
                }

        }
 
        #endregion
               

        private void ssWhere_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.EventArgs x;
                x = new System.EventArgs();
                cmd_refresh_Click(this.cmd_refresh, x);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            for (int iCol = 0; iCol < ssWhere.Cols.Count; iCol++)
            {
                ssWhere[1, iCol] = "";
            }
        }


    }
}