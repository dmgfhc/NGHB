using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using System.Collections;

namespace CommonClass
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MAINBASE :Form
    {
        public string Toolbar_St;

        public string[] UserInfo;
        public string sAuthority;
        public MAINBASE(string[] args)
        {
            UserInfo = args;
          
            InitializeComponent();
            //this.tabSideBar.AutoHiding = true;
            //tabSideBar.SlideHidePage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MAINBASE"/> class.
        /// </summary>
        public MAINBASE()
        {
            //UserInfo = args;
       
            //tabSideBar.SlideHidePage();
            InitializeComponent();
            //this.tabSideBar.AutoHiding = true;
            //tabSideBar.SlideHidePage();
           
        }

        #region "Main Form Load/Close"
        protected void MAINBASE_Load(object sender, EventArgs e)
        {
            //GeneralCommon.Gp_LogTxt("MAINBASE_Load");
            //this.tabSideBar.AutoHiding = true;
            //tabSideBar.SlideHidePage();
            //if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.IndexOf(".") != System.Diagnostics.Process.GetCurrentProcess().ProcessName.Length-3)
            // return;
            //string Active_YN = string.Empty;
            //string separators = string.Empty;
            //space = "";
            //GeneralCommon Conn = new GeneralCommon();

            //if (!GeneralCommon.GF_DbConnect())
            //{
            //    MessageBox.Show("数据库连接失败！");
            //    return;
            //}

            //// 在这里需要判断当前的用户信息, 也就是当前用户名密码不为空.
            //GeneralCommon.bPassCheck = true;
            ////try
            ////{
            ////    if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToString()).Length > 0)
            ////    {
            ////        //GeneralCommon.Gp_MsgBoxDisplay("Upload Program already running ... !!! " & vbCrLf & vbCrLf & "Program will terminate !!!", "W");
            ////        MessageBox.Show("Upload Program already running ... !!! ");
            ////        return;
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    ex.ToString();
            ////}

            //if (UserInfo.Length < 1)
            //{
            //    MessageBox.Show("用户名/密码为空！");
            //    return;
            //}

            //if (GeneralCommon.bPassCheck == false)
            //{
            //    this.Dispose();
            //    return;
            //}
            //else
            //{
            //    if (GeneralCommon.OleDbConn.State != ConnectionState.Open)
            //    {
            //        this.Dispose();
            //        return;
            //    }

            //    /* Use static values directly. */
            //    GeneralCommon.sUserID = UserInfo[0].ToString();
            //    GeneralCommon.sUsername = UserInfo[1].ToString();
            //}

            //string sQuery = string.Empty;
            //sQuery = "SELECT EMP_NAME FROM TZ_EMPLOYEE WHERE EMP_ID = '" + GeneralCommon.sUserID + "'";
            //GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(Conn, sQuery);

            //sQuery = "SELECT DEPT FROM TZ_EMPLOYEE WHERE EMP_ID = '" + GeneralCommon.sUserID + "'";
            //GeneralCommon.sDeptid = GeneralCommon.Gf_CodeFind(Conn, sQuery);

            //sQuery = "SELECT CD_NAME FROM TZ_CD WHERE CD_MANA_NO = 'Z0002' AND CD = '" + GeneralCommon.sDeptid + "'";
            //GeneralCommon.sDeptname = GeneralCommon.Gf_CodeFind(Conn, sQuery);

            //StatusBar1.Panels[1].Text = GeneralCommon.sDeptname + " " + GeneralCommon.sUserID + " " + GeneralCommon.sUsername;
            ////this.Text = Application.ProductName + " Ver." + GetSetting("NQIS", "VERSION", Application.ProductName + ".exe", "1.0.0");

            //this.KeyPreview = true;

            ///* 出始过程应该是按照权限显示页面菜单, 也有可能有插入, 保存, 删除权限. */
            ////Gp_FormMenuSetting(this, "Start", "", "1000");
            ////FORMBASE.MDIMain = this;

            //   string  Active_YN;
            //   string  separators  = " ";
            // Dim commands As String = Microsoft.VisualBasic.Command()
            // string commands=
            //      Microsoft.VisualBasic.com
            // Dim args() As String = commands.Split(separators.ToCharArray)
            //  SiderbarHide();
            Login Login = new Login();

            // checking program is running
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).GetUpperBound(0) > 0)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("Upload Program already running ... !!! " + this.Name + "Program will terminate !!!", "W","");
                    this.Close();

                    return;
                }
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.Message,"","");
            }

            if (UserInfo == null || UserInfo.Length < 1)
            {


                Login.ShowDialog();
                if (GeneralCommon.bPassCheck == false)
                { this.Close(); return; }
            }
            else
            {
                if (!GeneralCommon.GF_DbConnect())
                { this.Close(); return; }

                GeneralCommon.sUserID = UserInfo[0];
                GeneralCommon.sUsername = UserInfo[1];

            }

            //GeneralCommon.Gp_LogData(GeneralCommon.sUserID + "," + GeneralCommon.sUsername + "在" + DateTime.Now.ToString() + "于" + GeneralCommon.Gf_GetIP() + ",登入" +this.Name);
            //Login.ShowDialog();
            //if (GeneralCommon.bPassCheck == false)
            //{ this.Close(); return; }

            //if UBound(args) < 1 Then
            //    Login.ShowDialog()
            //    If GeneralCommon.bPassCheck = False Then
            //        Me.Dispose()
            //        Exit Sub
            //    End If
            //Else
            //    If GeneralCommon.GF_DbConnect = False Then
            //        Me.Dispose()
            //        Exit Sub
            //    End If

            //    GeneralCommon.sUserID = args(0)
            //    GeneralCommon.sUsername = args(1)


            //End If

            //If Not GeneralCommon.Gp_GetGravity() Then
            //    Me.Dispose()
            //    Exit Sub
            //End If
            string sQuery;
            sQuery = "SELECT EMP_NAME FROM TZ_EMPLOYEE WHERE EMP_ID = '" + GeneralCommon.sUserID + "'";
            GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);

            sQuery = "SELECT DEPT FROM TZ_EMPLOYEE WHERE EMP_ID ='" + GeneralCommon.sUserID + "'";
            GeneralCommon.sDeptid = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);

            sQuery = "SELECT CD_NAME FROM TZ_CD WHERE CD_MANA_NO = 'Z0002' AND CD = '" + GeneralCommon.sDeptid + "'";
            GeneralCommon.sDeptname = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);

            this.StatusBar_Bottom.Panels[1].Text = GeneralCommon.sDeptname + " " + GeneralCommon.sUserID + " " + GeneralCommon.sUsername + " \0";
            // this.Text = Application.ProductName + " Ver." + GetSetting("NQIS", "VERSION", Application.ProductName + ".exe", "1.0.0");
            this.Text = Application.ProductName + " Ver." + Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\"  + @"\VERSION").GetValue(Application.ProductName, "1.0.0") + ".exe";
            //Create by  nanjianxing 2008.01.24
            //遍历左侧按钮组，读取其受否展开的记录
            //Dim Ctrl As DevExpress.XtraNavBar.NavBarGroup
            //For i As Integer = 1 To Me.NavBarControl1.Groups.Count
            //    Ctrl = Me.NavBarControl1.Groups(i - 1)
            //    Ctrl.Expanded = CBool(CommonClass.Win32ApiClass.GetPrivateProfileInt(Application.ProductName, Ctrl.Name, IIf(Ctrl.Expanded, 1, 0), GeneralCommon.FileName))
            //Next
            //end
            this.KeyPreview = true;

            // DataDicCommon.Gf_EmpNameFind(GeneralCommon.OleDc, "123");
            GeneralCommon.MDIMain = this;

            GeneralCommon.Gp_DateSetting();
            //GeneralCommon.Gp_FormMenuSetting(this, "Start", Toolbar_St, "0000");
            GeneralCommon.Gp_FormMenuSetting("Start", Toolbar_St, "0000");
            this.WindowState = FormWindowState.Maximized;

        }


        private void MAINBASE_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form CurrentForm in this.MdiChildren)
            {
                if (CurrentForm.Name != this.Name)
                {
                    CurrentForm.Close();
                }
            }
            //GeneralCommon.Gp_LogData(GeneralCommon.sUserID + "," + GeneralCommon.sUsername + "在" + DateTime.Now.ToString() + "于" + GeneralCommon.Gf_GetIP() + ",登出" + this.Name);


        }

        private void MAINBASE_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool FormLD = false;
            foreach (Form CurrentForm in this.MdiChildren)
            {
                if (CurrentForm.Name != this.Name)
                {
                    FormLD = true;
                    break; // TODO: might not be correct. Was : Exit For 
                }
            }

            if (FormLD)
            {

                if (!GeneralCommon.Gf_MessConfirm("存在没有结束的界面 还是结束吗..?", "Q", this.Text))
                {
                    e.Cancel = true;
                }
            }

        }

        #endregion

        private void MenuTool_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

            Form frmActive = this.ActiveMdiChild;
            //frmActive.Focus();
            //StatusBar_Bottom.Select();
            //frmActive.Select();
            //frmActive.Capture=true;
            try
            {
                StatusBar_Bottom.Panels[StatusBarPanel_Msg.Name].Text = "Message : ";

                if (e.Button.Name == Btn_Exit.Name)
                {
                    if (frmActive == null)
                    {
                        if (MessageBox.Show("你确定要退出整个系统吗？", "退出系统通知", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            this.Close();
                            System.Environment.Exit(0);
                        }
                        else { return; }
                    }
                    else
                    {
                        this.ActiveMdiChild.Close();
                        return;
                    }
                }
                //  MenuTool.Buttons[e.Button.Name.ToString()].Tag = "";
                /* 当前没有用到. */
                //If TypeOf frmActive.ActiveControl Is FarPoint.Win.Spread.FpSpread Then
                //    Call SpreadCommon.Gp_Sp_EventMark(frmActive.ActiveControl)
                //End If

                if (e.Button.Tag == null || e.Button.Tag.ToString() == "F")
                    return;

                GeneralCommon.GF_DbConnect();
                switch (e.Button.Name)
                {
                    case "Btn_Clear":
                        Mnu_Clear_Click("", e);
                        break;
                    case "Btn_Refer":
                        Mnu_Refer_Click("", e);
                        break;
                    case "Btn_Save":
                        Mnu_Save_Click("", e);
                        break;
                    case "Btn_Delete":
                        Mnu_Delete_Click("", e);
                        break;
                    case "Btn_RowIns":
                        Mnu_RowIns_Click("", e);
                        break;
                    case "Btn_RowDel":
                        Mnu_RowDel_Click("", e);
                        break;
                    case "Btn_RowCan":
                        Mnu_RowCan_Click("", e);
                        break;
                    case "Btn_Excel":
                        Mnu_Excel_Click("", e);
                        break;
                    case "Btn_Print":
                        Mnu_Print_Click("", e);
                        break;
                    case "Btn_Help":
                        Mnu_Help_Click("", e);
                        break;
                    case "Btn_Exit":
                        frmActive.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //ex.ToString();
                // return;
                GeneralCommon.Gp_MsgBoxDisplay("菜单按钮点击错误: " + e.Button + ex.Message,"","");
                GC.Collect();
            }
        }

        #region "Screen, Master, Spread Copy And Paste Process"

        private void Mnu_Acopy_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Cpy();
            StatusBar_Bottom.Panels[StatusBarPanel_Msg.Name].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Acopy", "");
            GeneralCommon.Gp_FormMenuSetting( "", "Acopy", "");

        }

        private void Mnu_Mcopy_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Master_Cpy();
            StatusBar_Bottom.Panels[StatusBarPanel_Msg.Name].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Mcopy", "");
            GeneralCommon.Gp_FormMenuSetting( "", "Mcopy", "");

        }

        private void Mnu_Scopy_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Cpy();
            StatusBar_Bottom.Panels[StatusBarPanel_Msg.Name].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Scopy", "");
            GeneralCommon.Gp_FormMenuSetting( "", "Scopy", "");

        }

        private void Mnu_Apaste_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Pst();

        }

        private void Mnu_Mpaste_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Master_Pst();

        }

        private void Mnu_Spaste_Click(object sender, System.EventArgs e)
        {

            object frmActive = null;

            frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Pst();

        }

        #endregion

        #region "Spread Cloumn Sort/ColsFrozenSetting/ColsFrozenCancel"

        private void Mnu_ColumnSort_Click(object sender, System.EventArgs e)
        {

            //object frmActive = null;

            //try
            //{

            //    //If Spread_ColSort.Active_Spread Is Nothing Then Exit Sub 

            //    frmActive = this.ActiveMdiChild;
            //     ((FORMBASE)frmActive).Spread_ColumnsSort(); 
            //    StatusBar1.Panels[0].Text = " Message : ";
            //}

            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay(" ColumnSort Error : " + ex.Message);
            //}

        }

        private void Mnu_FrozenSetting_Click(object sender, System.EventArgs e)
        {

            //object frmActive = null;

            //try
            //{

            //    //If Spread_ColSort.Active_Spread Is Nothing Then Exit Sub 

            //    frmActive = this.ActiveMdiChild;
            //    ((FORMBASE)frmActive).Spread_Frozens_Setting();
            //    StatusBar1.Panels[0].Text = " Message : ";
            //}

            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay(" FrozenSetting Error : " + ex.Message);
            //}

        }

        private void Mnu_FrozenCancel_Click(object sender, System.EventArgs e)
        {

            //object frmActive = null;

            //try
            //{

            //    //If Spread_ColSort.Active_Spread Is Nothing Then Exit Sub 

            //    frmActive = this.ActiveMdiChild;
            //    ((FORMBASE)frmActive).Spread_Frozens_Cancel();
            //    StatusBar1.Panels[0].Text = " Message : ";
            //}

            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay(" FrozenCancel Error : " + ex.Message);
            //}

        }

        #endregion

        #region "Windows Menu Click"
        /// <summary>
        /// Handles the Click event of the Mnu_Clear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Mnu_Clear_Click(object sender, System.EventArgs e)
        {
            //FORMBASE frmActive = (FORMBASE)this.ActiveMdiChild;
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                frmActive.Form_Cls();
                //frmActive.oFlexGrid_Clear();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_Clear_Click is running.");
            //}
        }

        private void Mnu_Refer_Click(object sender, System.EventArgs e)
        {
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                frmActive.Form_Ref();
                //frmActive.oFlexGrid_Clear();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_Clear_Click is running.");
            //}
        }

        private void Mnu_Save_Click(object sender, System.EventArgs e)
        {
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                if (frmActive.i_ScCurrSeq > 0)
                {
                    Dictionary<object, object> Scx = (Dictionary<object, object>)frmActive.Proc_Sc[frmActive.i_ScCurrSeq - 1];
                    //FlexGrid_User oFlexGrid = (FlexGrid_User)Scx["Spread"];

                    //if (oFlexGrid.Rows.Count > 0)
                    //{
                    //    //oFlexGrid.Focused;
                    //    oFlexGrid.Focus();
                    //    // 重新获取当前焦点.
                    //}
                }
                frmActive.Form_Pro();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_Clear_Click is running.");
            //}
        }

        private void Mnu_Delete_Click(object sender, System.EventArgs e)
        {
            FORMBASE frmActive = (FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                //frmActive.Form_Del();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_Delete_Click is running.");
            //}
        }

        private void Mnu_RowIns_Click(object sender, System.EventArgs e)
        {
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                /* 这里需要重新设计. */
                frmActive.Spread_Ins();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_RowIns_Click is running.");
            //}
        }

        private void Mnu_RowDel_Click(object sender, System.EventArgs e)
        {
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                /* 这里需要重新设计. */
                frmActive.Spread_Del();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_RowIns_Click is running.");
            //}
        }

        private void Mnu_RowCan_Click(object sender, System.EventArgs e)
        {
            CommonClass.FORMBASE frmActive = (CommonClass.FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                /* 这里需要重新设计. */
                frmActive.Spread_Can();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_RowCan_Click is running.");
            //}
        }

        private void Mnu_Excel_Click(object sender, System.EventArgs e)
        {
            FORMBASE frmActive = (FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                /* 这里需要重新设计. */
                frmActive.Spread_Exc();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_RowCan_Click is running.");
            //}
        }

        private void Mnu_Print_Click(object sender, System.EventArgs e)
        {
            FORMBASE frmActive = (FORMBASE)this.ActiveMdiChild;

            if (frmActive != null)
            {
                /* 这里需要重新设计. */
                //frmActive.Form_Pri();
            }
            //else
            //{
            //    MessageBox.Show("Mnu_RowCan_Click is running.");
            //}
        }

        private void Mnu_Help_Click(object sender, System.EventArgs e)
        {

        }

        private void Mnu_Exit_Click(object sender, System.EventArgs e)
        {

            Application.Exit();

        }



        private void Mnu_Horiz_Click(object sender, System.EventArgs e)
        {

            switch (((MenuItem)sender).Index)
            {

                case 0:
                    //Mnu_Horiz 
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;

                case 1:
                    //Mnu_Vertical 
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;

                case 2:
                    //Mnu_Cascade 
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;

            }

        }

        #endregion

        #region "Form Execute"

        private void Mnu_Windows_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

   

        private void tme_current_Tick(object sender, EventArgs e)
        {
            StatusBar_Bottom.Panels[StatusBarPanel_DateTime.Name.Trim()].Text = " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " \0";
            //if (DateTime.Now.Minute%5==0&&DateTime.Now.Second<5)
            //{
            //    System.Data.OleDb.OleDbCommand tc = new System.Data.OleDb.OleDbCommand();
            //    try
            //    {
            //         tc = new System.Data.OleDb.OleDbCommand("select 1 from dual", GeneralCommon.OleDbConn_Log);
            //        tc.ExecuteNonQuery();
            //        tc.Connection.Close();
            //    }
            //    catch
            //    {

            //    }
            //    finally
            //    {
            //        tc.Dispose();
            //    }
            //}
            // tme_current.Enabled = false;
        }



    }
}