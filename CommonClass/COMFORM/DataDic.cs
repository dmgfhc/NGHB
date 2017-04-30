using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class DataDic : Form
    {
        public DataDic()
        {
            InitializeComponent();
        }

        private void DataDic_Load(object sender, EventArgs e)
        {
            GeneralCommon.Gp_FormLoc_Get(this, GeneralCommon.DD.DataDicType);
            // PrevRow = 0;
            this.KeyPreview = true;
            /* 允许自动调整列大小.  */
           // ssWhere.AutoResize = true;
           // ssResult.AutoResize = true;
        }

        private void DataDic_Activated(object sender, EventArgs e)
        {
            int iColCount = 0;
            SpreadCommon SpreadCommon = new SpreadCommon();
            ssWhere_setting();
            ssResult_setting();

            if (GeneralCommon.DD.DataDicType == "ETC")
            {
                // Control F4 Call
                if (GeneralCommon.DD.sWitch == "MS")
                {
                    for (iColCount = 0; iColCount < GeneralCommon.rControl.Count ; iColCount++)
                    {
                        ssWhere[0, iColCount] = GeneralCommon.rControl[iColCount].ToString();
                    }
                }
                //SpreadSheet F4 Call
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;

                    for (iColCount = 0; iColCount < GeneralCommon.rControl.Count ; iColCount++)
                    {
                        ssWhere[0, 0] = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[iColCount ].ToString())].ToString();
                    }
                }
            }

            else
            {
                if (GeneralCommon.DD.sWitch == "MS")
                {
                    ssWhere[1, 1] = ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[0])).Text;
                }
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;
                    ssWhere[1,1] = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0].ToString())].ToString();
                }

                switch (GeneralCommon.DD.DataDicType)
                {

                    case "M":
                        //Common Code 
                        switch (GeneralCommon.DD.nameType)
                        {
                            case "1":
                                ssWhere.ColSel = 1;
                                break;

                            case "2":
                                ssWhere.ColSel = 2;
                                break;

                            case "3":
                                ssWhere.ColSel = 3;
                                break;

                            case "4":
                                ssWhere.ColSel = 4;
                                break;
                        }
                        break;

                    case "A":
                        ssWhere.ColSel = 1;
                        break;

                    case "EMP":
                        ssWhere.ColSel = 1;
                        break;

                    case "PGM":
                        ssWhere.ColSel = 1;
                        break;

                    case "CUST":
                        ssWhere.ColSel = 1;
                        break;

                    case "MAT":
                        ssWhere.ColSel = 1;
                        break;
                }

                if (GeneralCommon.DD.sWitch == "MS")
                {
                    if (GeneralCommon.rControl.Count > 0)
                    {
                        ssWhere[1, 2] = ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text;
                    }
                }
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;

                    if (GeneralCommon.rControl.Count > 0)
                    {
                        ssWhere[1, 2] = oFlexGrid[oFlexGrid.RowSel, Convert.ToInt32(GeneralCommon.rControl[0].ToString())].ToString();
                    }
                }
            }

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
            //SpreadCommon SpreadCommon = new SpreadCommon();

            //Dim iCollCnt As Integer 

            GeneralCommon.Gp_FormLoc_Set(this, GeneralCommon.DD.DataDicType);

            //Call SpreadCommon.Gp_Sp_ColSet(ssWhere, Me.Name, GeneralCommon.DD.DataDicType) 
            //Call SpreadCommon.Gp_Sp_ColSet(ssResult, Me.Name, GeneralCommon.DD.DataDicType) 

            GeneralCommon.DD.DataDicType = "";
            GeneralCommon.DD.DicRefType = "";
            GeneralCommon.DD.nameType = "";
            GeneralCommon.DD.sQuery = "";
            GeneralCommon.DD.sWhere = "";
            GeneralCommon.DD.sKey = "";
            GeneralCommon.DD.sWitch = "";
            GeneralCommon.DD.sSelect = false;
            GeneralCommon.DD.sCusCode = "";
            GeneralCommon.DD.sJoin = "";
            GeneralCommon.DD.sParameters = new System.Collections.ArrayList();
            GeneralCommon.DD.sPrcoCode = "";

        }

        #region "Spread Setting.."
        public void ssWhere_setting()
        {
            // SpreadCommon SpreadCommon = new SpreadCommon();
            ssWhere.Height = 15;
            ssWhere.Rows[0].Height = 20;
            ssWhere.Rows.Count = 2;
            ssWhere.Cols[0].Width = 80;
            ssWhere.AutoResize = true;
        }

        public void ssResult_setting()
        {
            //SpreadCommon SpreadCommon = new SpreadCommon();
            ssResult.Height = 15;
            ssResult.Rows[0].Height = 20;
            ssResult.AutoResize = true;
        }

        #endregion

        #region "Button Click..."
        public virtual void cmd_refresh_Click(object sender, EventArgs e)
        {
            GeneralCommon.Gp_FormLoc_Get(this, GeneralCommon.DD.DataDicType);
            this.KeyPreview = true;
        }

        private void cmd_selection_Click(object sender, EventArgs e)
        {
           // int iColCount = 0;

            if (ssResult.Rows.Count >= 1)
            {
                if (GeneralCommon.DD.sWitch == "MS")
                {
                    /* 控件F4涉及到两个信息 CD/CD_NAME两个信息分别填写在TextBox的两个部分. */
                    /* rControl[1] 保存CD, rControl[2] 保存CD_NAME.                        */
                    ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[0])).Text = ssResult[ssResult.RowSel, 1].ToString();
                    ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text = ssResult[ssResult.RowSel, 2].ToString();
                }
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;
                    /* 只将代码赋值给原来的F4列上. */
                    oFlexGrid[oFlexGrid.RowSel, oFlexGrid.ColSel] = ssResult[ssResult.RowSel, 1].ToString();
                }
            }
            this.Close();
        }

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
            //int iColCount = 0;

            if (ssResult.Rows.Count >= 1)
            {
                if (GeneralCommon.DD.sWitch == "MS")
                {
                    /* 控件F4涉及到两个信息 CD/CD_NAME两个信息分别填写在TextBox的两个部分. */
                    /* rControl[1] 保存CD, rControl[2] 保存CD_NAME.                        */
                    ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[0])).Text = ssResult[ssResult.RowSel, 1].ToString();
                    ((System.Windows.Forms.TextBox)(GeneralCommon.rControl[1])).Text = ssResult[ssResult.RowSel, 2].ToString();
                }
                else
                {
                    FlexGrid_User oFlexGrid = (FlexGrid_User)GeneralCommon.DD.sPname;
                    /* 只将代码赋值给原来的F4列上. */
                    oFlexGrid[oFlexGrid.RowSel, oFlexGrid.ColSel] = ssResult[ssResult.RowSel, 1].ToString();
                }
            }

            this.Close();
        }

       

    
        private void ssResult_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //int iColCount = 0;

            //if (e.KeyCode == Keys.Escape) this.Close();

            //if (e.KeyCode == Keys.Enter)
            //{
            //    int iRow = 0;
            //    int iCol = 0;
            //    {
            //        iRow = ssResult.ActiveSheet.ActiveRowIndex;
            //        iCol = 0;
            //        //ssResult.Row = ssResult.ActiveRow : ssResult.Col = 1 

            //        if (GeneralCommon.DD.DataDicType != "ETC")
            //        {

            //            if (GeneralCommon.DD.sWitch == "MS")
            //            {
            //                GeneralCommon.rControl[0] = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //            }
            //            else
            //            {
            //                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)GeneralCommon.DD.sPname;
            //                //GeneralCommon.DD.sPname.Col = GeneralCommon.rControl.Item(1) 
            //                ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, Convert.ToInt32(GeneralCommon.rControl[0].ToString())).Text = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //            }

            //            switch (GeneralCommon.DD.DataDicType)
            //            {

            //                case "M":
            //                    //Common Code 
            //                    switch (GeneralCommon.DD.nameType)
            //                    {
            //                        case "1":
            //                            //Short Name 
            //                            iCol = 1;
            //                            break;
            //                        case "2":
            //                            //Full Name 
            //                            iCol = 2;
            //                            break;
            //                        case "3":
            //                            //Short Eng Name 
            //                            iCol = 3;
            //                            break;
            //                        case "4":
            //                            //Full Eng Name 
            //                            iCol = 4;
            //                            break;
            //                    }
            //                    break;
            //                case "A":
            //                    //Apply_Item Code 
            //                    iCol = 1;
            //                    break;

            //                case "EMP":
            //                    //EMP Code 
            //                    iCol = 1;
            //                    break;

            //                case "PGM":
            //                    //Program ID 
            //                    iCol = 1;
            //                    break;

            //                case "CUST":
            //                    //Customer CODE 
            //                    iCol = 1;
            //                    break;

            //                case "MAT":
            //                    //Material CODE 
            //                    iCol = 1;
            //                    break;

            //            }

            //            if (GeneralCommon.DD.sWitch == "MS")
            //            {
            //                if (GeneralCommon.rControl.Count > 1)
            //                {
            //                    GeneralCommon.rControl[2] = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //                }
            //            }
            //            else
            //            {
            //                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)GeneralCommon.DD.sPname;
            //                if (GeneralCommon.rControl.Count > 1)
            //                {
            //                    //GeneralCommon.DD.sPname.Col = GeneralCommon.rControl.Item(2) 
            //                    ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, Convert.ToInt32(GeneralCommon.rControl[2].ToString())).Text = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //                }
            //                GeneralCommon.DD.sSelect = true;
            //            }
            //        }

            //        else
            //        {

            //            //Control F4 Call 
            //            if (GeneralCommon.DD.sWitch == "MS")
            //            {

            //                for (iColCount = 0; iColCount <= ssResult.ActiveSheet.ColumnCount - 1; iColCount++)
            //                {

            //                    iCol = iColCount;

            //                    if (GeneralCommon.rControl[iColCount + 1] is CheckBox)
            //                    {

            //                        GeneralCommon.rControl[iColCount + 1] = bool.Parse(ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text);
            //                    }

            //                        //ElseIf TypeOf GeneralCommon.rControl.Item(iColCount + 1) Is AxThreed.AxSSCheck Then 

            //                        // GeneralCommon.rControl.Item(iColCount + 1).Value = .ActiveSheet.Cells.Get(iRow, iCol).Text 

            //                    else if (GeneralCommon.rControl[iColCount + 1] is ComboBox)
            //                    {

            //                        GeneralCommon.rControl[iColCount + 1] = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //                    }

            //                    //ElseIf TypeOf GeneralCommon.rControl.Item(iColCount + 1) Is AxCSTextLib.AxsitxEdit Then 

            //                    // GeneralCommon.rControl.Item(iColCount + 1).RawData = .ActiveSheet.Cells.Get(iRow, iCol).Text 

            //                    //ElseIf TypeOf GeneralCommon.rControl.Item(iColCount + 1) Is Alfredo.aMaskEdit.aDatePiker Then 

            //                    // GeneralCommon.rControl.Item(iColCount + 1).Value = .ActiveSheet.Cells.Get(iRow, iCol).Text 

            //                    else
            //                    {

            //                        GeneralCommon.rControl[iColCount + 1] = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //                    }

            //                }

            //            }

            //            //SpreadSheet F4 Call 
            //            else
            //            {
            //                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)GeneralCommon.DD.sPname;
            //                for (iColCount = 0; iColCount <= ssResult.ActiveSheet.ColumnCount - 1; iColCount++)
            //                {

            //                    iCol = iColCount;
            //                    //GeneralCommon.DD.sPname.Col = GeneralCommon.rControl.Item(iColCount + 1) 
            //                    ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, Convert.ToInt32(GeneralCommon.rControl[iColCount + 1].ToString())).Text = ssResult.ActiveSheet.Cells.Get(iRow, iCol).Text;
            //                }

            //            }

            //        }

            //    }


            //    this.Close();
            //}

        }

        //private void ssWhere_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        //{
        //    int iCol = 0;

        //    for (iCol = 0; iCol <= ssWhere.ActiveSheet.ColumnCount - 1; iCol++)
        //    {
        //        ssResult.ActiveSheet.Columns.Get(iCol).Width = ssWhere.ActiveSheet.Columns.Get(iCol).Width;
        //    }
        //    //ssResult.set_ColWidth(iCol, ssWhere.get_ColWidth(iCol)) 
        //}

      
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

  

    }
}