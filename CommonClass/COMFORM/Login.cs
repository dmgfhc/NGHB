using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using CommonClass;

//'-------------------------------------------------------------------------------
//'-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
//'-- 系统名            公共管理
//'-- 子系统名          公共管理
//'-- 程序名            登陆
//'-- 程序ID            login
//'-- 版本              1.1.01
//'-- 文档号                 
//'-- 设计               
//'-- 代码               
//'-- 代码日期          2006.08.17
//'-- 处理描述          

//'-------------------------------------------------------------------------------
//'-- 更新历史  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
//'-- 版本      日期          修改人         修改内容
//'1.1.01    2006.08.17       ashen       

//'-------------------------------------------------------------------------------
//'-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
namespace CommonClass
{
	public class Login : System.Windows.Forms.Form
	{
		
		public int PassCnt; //PassWord Input Count
		
		#region  Windows 绐椾綋璁捐鍣ㄧ敓鎴愮殑浠ｇ爜
		
		public Login()
		{
			
			
			InitializeComponent();
			
		}
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private System.ComponentModel.Container components = null;
		
		
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txt_password;
		internal System.Windows.Forms.ComboBox cbo_emp_id;
		internal System.Windows.Forms.LinkLabel lbl_Change;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Cmd_Ok;
		internal System.Windows.Forms.Button Cmd_Cancel;
		internal System.Windows.Forms.Button Cmd_Setup;
		internal System.Windows.Forms.Label Label5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbo_emp_id = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbl_Change = new System.Windows.Forms.LinkLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Setup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(77, 236);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(111, 21);
            this.txt_password.TabIndex = 3;
            // 
            // cbo_emp_id
            // 
            this.cbo_emp_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_emp_id.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_emp_id.Location = new System.Drawing.Point(77, 208);
            this.cbo_emp_id.MaxDropDownItems = 10;
            this.cbo_emp_id.Name = "cbo_emp_id";
            this.cbo_emp_id.Size = new System.Drawing.Size(111, 23);
            this.cbo_emp_id.TabIndex = 1;
            this.cbo_emp_id.DropDown += new System.EventHandler(this.cbo_emp_id_DropDown);
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 236);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "密   码";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Change
            // 
            this.lbl_Change.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Change.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Change.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Change.LinkColor = System.Drawing.Color.Gray;
            this.lbl_Change.Location = new System.Drawing.Point(188, 240);
            this.lbl_Change.Name = "lbl_Change";
            this.lbl_Change.Size = new System.Drawing.Size(60, 16);
            this.lbl_Change.TabIndex = 4;
            this.lbl_Change.TabStop = true;
            this.lbl_Change.Text = "修改密码";
            this.lbl_Change.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_Change.Click += new System.EventHandler(this.lbl_Change_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 160);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(239, 39);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "帐户密码均为员工号.如果选项里没有您的工号,请点设定添加!!";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(6, 208);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "用户名";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(252, 176);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Ok.TabIndex = 9;
            this.Cmd_Ok.Text = "确定";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_OK_ClickEvent);
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(252, 205);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Cancel.TabIndex = 10;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_ClickEvent);
            // 
            // Cmd_Setup
            // 
            this.Cmd_Setup.Location = new System.Drawing.Point(252, 234);
            this.Cmd_Setup.Name = "Cmd_Setup";
            this.Cmd_Setup.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Setup.TabIndex = 11;
            this.Cmd_Setup.Text = "设定";
            this.Cmd_Setup.UseVisualStyleBackColor = true;
            this.Cmd_Setup.Click += new System.EventHandler(this.Cmd_Setting_ClickEvent);
            // 
            // Login
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.Cmd_Setup);
            this.Controls.Add(this.Cmd_Cancel);
            this.Controls.Add(this.Cmd_Ok);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbl_Change);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbo_emp_id);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.Label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户登录";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//==============================================================================================
		// Procedure Name : Cmd_OK_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_OK_ClickEvent(object sender, System.EventArgs e)
			{
			
			string sQuery;
			
			if (cbo_emp_id.Text == "")
			{
                GeneralCommon.Gp_MsgBoxDisplay("请输入用户名..!!", "W", "");
				return;
			}
			
            //if (txt_password.Text == "")
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("请输入密码..!!", "W", "");
            //    return;
            //}
			
			//ID Check
			sQuery = "SELECT EMP_NAME FROM zp_EMPLOYEE WHERE EMP_ID = \'" + cbo_emp_id.Text.Trim() + "\'";
			GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			if (GeneralCommon.sUsername == "FAIL")
			{
				return;
			}
			
			if (GeneralCommon.sUsername == "")
			{
                GeneralCommon.Gp_MsgBoxDisplay("输入的用户名不存在..!!", "I", "");
				return;
			}
			
			//Password check
			sQuery = "SELECT PASSWORD FROM zp_EMPLOYEE WHERE EMP_ID = \'" + cbo_emp_id.Text.Trim() + "\'";

            string s_md5_pwd = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1,
               "select gf_md5_pwd('" + txt_password.Text.Trim() + "') from dual");

            if (s_md5_pwd != GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery))
			{
				
				PassCnt++;
				
				if (PassCnt > 2)
				{
					GeneralCommon.Gp_MsgBoxDisplay("Input Hoes possibility excess,onfirm information..!!", "", "");
					GeneralCommon.bPassCheck = false;
					this.Close();
					return;
				}

                GeneralCommon.Gp_MsgBoxDisplay("输入的密码不正确..!!", "I", "");
				
			}
			else
			{
				//User department id
				sQuery = "SELECT DEPT FROM zp_EMPLOYEE WHERE EMP_ID = \'" + cbo_emp_id.Text.Trim() + "\'";
				GeneralCommon.sDeptid = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
				
				//User department name
				sQuery = "SELECT CD_NAME FROM zp_CD WHERE CD LIKE \'" + GeneralCommon.sDeptid + "\' AND CD_MANA_NO = \'B0025\'";
				GeneralCommon.sDeptname = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
				
				GeneralCommon.sUserID = cbo_emp_id.Text.Trim();
				
				//Current User Registry Setting
                Interaction.SaveSetting("NGKHBMES", "AUTHORITY", "sUserID0", GeneralCommon.sUserID);
				Interaction.SaveSetting("NGKHBMES", "AUTHORITY", "sUsername", GeneralCommon.sUsername);
				
				GeneralCommon.Gp_DateSetting();
				GeneralCommon.bPassCheck = true;
				this.Close();
				
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : Cmd_Cancel_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_Cancel_ClickEvent(object sender, System.EventArgs e)
		{
			
			GeneralCommon.bPassCheck = false;
			this.Close();
			
		}
		
		//==============================================================================================
		// Procedure Name : Cmd_Setting_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_Setting_ClickEvent(object sender, System.EventArgs e)
		{
			
			object[,] Reg_id=new object[100,100];
			int intSettings;
			UserID_Add UserID_Add = new UserID_Add();
			
			UserID_Add.ShowDialog();
			
			//Registry ID Setting
			Reg_id = Interaction.GetAllSettings("NQIS", "LOGIN");
			
			cbo_emp_id.Items.Clear();
			
			for (intSettings = 0; intSettings <= (Reg_id.Length/2 - 1); intSettings++)
			{
				
				//If Reg_id(intSettings, 0) <> "SAMPLE" Then
				cbo_emp_id.Items.Add(Reg_id[intSettings, 0]);
				//End If
				
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : Login_Load
		// Description    :
		//==============================================================================================
		private void Login_Load(object sender, System.EventArgs e)
		{
			
			//Dim WshShell As Object
			//Dim Reg_id As Object
			
			GeneralCommon.bPassCheck = false;
			
			this.KeyPreview = true;
			//Me.BackColor = &HE0E0E0
			
			//CapsLock On
			//If GetKeyState(KEY_CAPITAL) <> 1 Then
			//    Call keybd_event(KEY_CAPITAL, 0, 0, 0)
			//End If
			
			//Set WshShell = CreateObject("WScript.Shell")
			//WshShell.SendKeys "{CAPSLOCK}"
			
			GeneralCommon.Gp_FormCenter(this);
			
			//Registry ID Setting
			Interaction.SaveSetting("NQIS", "LOGIN", "SAMPLE", "1");
			
		}
		
		//==============================================================================================
		// Procedure Name : Login_KeyPress
		// Description    :
		//==============================================================================================
		private void Login_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			if (e.KeyChar == Strings.ChrW(13))
			{
				//SendKeys.Send(vbTab)
				Cmd_OK_ClickEvent("", EventArgs.Empty);
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : cbo_emp_id_DropDown
		// Description    :
		//==============================================================================================
		private void cbo_emp_id_DropDown(object sender, System.EventArgs e)
		{
			
			object[,] Reg_id=new object[100,100];
			int intSettings;
			
			//Registry ID Setting
			Reg_id = Interaction.GetAllSettings("NQIS", "LOGIN");
			
			cbo_emp_id.Items.Clear();
			
			for (intSettings = 0; intSettings <= (Reg_id.Length/2 - 1); intSettings++)
			{
				
				if (Reg_id[intSettings, 0] != "SAMPLE")
				{
					cbo_emp_id.Items.Add(Reg_id[intSettings, 0]);
				}
				
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : lbl_Change_Click
		// Description    :
		//==============================================================================================
		private void lbl_Change_Click(object sender, System.EventArgs e)
		{
			
			string sQuery;
			ConfirmLogin ConfirmLogin = new ConfirmLogin();
			
			//ID Check
			sQuery = "SELECT EMP_NAME FROM ZP_EMPLOYEE WHERE EMP_ID = \'" + cbo_emp_id.Text.Trim() + "\'";
			GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			if (GeneralCommon.sUsername == "")
			{
				GeneralCommon.Gp_MsgBoxDisplay("User ID Not Found..!!", "I", "");
				return;
			}
			
			//Password check
			sQuery = "SELECT PASSWORD FROM ZP_EMPLOYEE WHERE EMP_ID = \'" + cbo_emp_id.Text.Trim() + "\'";

            string s_md5_pwd = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1,
            "select gf_md5_pwd('" + txt_password.Text.Trim() + "') from dual");

            if (s_md5_pwd != GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery))
			{
				GeneralCommon.Gp_MsgBoxDisplay("User Password Not Found..!!", "I", "");
				PassCnt++;
				return;
			}
			else
			{
				GeneralCommon.sUserID = cbo_emp_id.Text.Trim();
				GeneralCommon.sPassWord = txt_password.Text.Trim();
			}
			
			ConfirmLogin.ShowDialog();
			
			txt_password.Text = "";
			
		}
		
		//==============================================================================================
		// Procedure Name : Login_Activated
		// Description    :
		//==============================================================================================
		private void Login_Activated(object sender, System.EventArgs e)
		{
			
			cbo_emp_id.Focus();
			
		}
		
	}
	
}
