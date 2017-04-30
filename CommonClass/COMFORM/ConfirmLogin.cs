using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using CommonClass;

//-------------------------------------------------------------------------------
//-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- 系统名            系统管理
//-- 子系统名          公共管理
//-- 程序名            输入新密码
//-- 程序ID            CONFIRMLOGIN
//-- 版本              1.1.01
//-- 文档号
//-- 设计
//-- 代码
//-- 代码日期          2006.08.17
//-- 处理描述          更改密码

//-------------------------------------------------------------------------------
//-- 更新历史  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- 版本      日期          修改人         修改内容
//1.1.01    2006.08.17       ashen

//-------------------------------------------------------------------------------
//-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
namespace CommonClass
{
	public class ConfirmLogin : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public ConfirmLogin()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
		}
		
		//窗体重写 dispose 以清理组件列表。
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
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txt_confirm;
		internal System.Windows.Forms.Button Cmd_Ok;
		internal System.Windows.Forms.Button Cmd_Cancel;
		internal System.Windows.Forms.TextBox txt_newpassword;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmLogin));
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(8, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "请确认新密码";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_confirm.Location = new System.Drawing.Point(110, 36);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(89, 22);
            this.txt_confirm.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(8, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "请输入新密码";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_newpassword.Location = new System.Drawing.Point(110, 8);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(89, 22);
            this.txt_newpassword.TabIndex = 0;
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(12, 68);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Ok.TabIndex = 13;
            this.Cmd_Ok.Text = "确认";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_OK_ClickEvent);
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(110, 68);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancel.TabIndex = 14;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_ClickEvent);
            // 
            // ConfirmLogin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(214, 100);
            this.Controls.Add(this.Cmd_Cancel);
            this.Controls.Add(this.Cmd_Ok);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更改密码";
            this.Activated += new System.EventHandler(this.ConfirmLogin_Activated);
            this.Load += new System.EventHandler(this.ConfirmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmLogin_KeyPress);
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
			
			Login Login = new Login();
			
			string sQuery;
			ADODB.Recordset AdoRs;
			
			AdoRs = new ADODB.Recordset();
			
			try
			{
				
				if (txt_newpassword.Text.Trim() == "")
				{
					GeneralCommon.Gp_MsgBoxDisplay("请输入新密码..!!", "I", "");
					return;
				}
				
				if (txt_confirm.Text.Trim() == "")
				{
					GeneralCommon.Gp_MsgBoxDisplay("请再次输入新密码..!!", "I", "");
					return;
				}
				
				if (txt_newpassword.Text.Trim() == txt_confirm.Text.Trim())
				{
					
					Login.txt_password.Text = "";
					
					//Db Connection Check

                    if (GeneralCommon.GF_DbConnect() == false) return;

                    sQuery = "Update zp_EMPLOYEE set PASSWORD = gf_md5_pwd('" + txt_confirm.Text.Trim() + "') ";
					sQuery = sQuery + " where EMP_ID = '" + GeneralCommon.sUserID + "' ";
					
					//Ado Execute
					AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenKeyset,ADODB.LockTypeEnum.adLockReadOnly, -1);
					
					//AdoRs.Close()
					AdoRs = null;
					this.Close();
					
				}
				else
				{
					GeneralCommon.Gp_MsgBoxDisplay("输入的密码不一致..!!", "I", "");
				}
				
				AdoRs = null;
				
			}
			catch (Exception ex)
			{
				AdoRs = null;
				GeneralCommon.Gp_MsgBoxDisplay((string) ("修改密码失败..!!" + ex.Message), "", "");
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : Cmd_Cancel_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_Cancel_ClickEvent(object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		//==============================================================================================
		// Procedure Name : ConfirmLogin_Load
		// Description    :
		//==============================================================================================
		private void ConfirmLogin_Load(object sender, System.EventArgs e)
		{
			
			this.KeyPreview = true;
			GeneralCommon.Gp_FormCenter(this);
			
		}
		
		//==============================================================================================
		// Procedure Name : ConfirmLogin_KeyPress
		// Description    :
		//==============================================================================================
		private void ConfirmLogin_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			if (e.KeyChar == Strings.ChrW(13))
			{
				SendKeys.Send("\t");
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : ConfirmLogin_Activated
		// Description    :
		//==============================================================================================
		private void ConfirmLogin_Activated(object sender, System.EventArgs e)
		{
			
			txt_newpassword.Focus();
			
		}
		
	}
	
}
