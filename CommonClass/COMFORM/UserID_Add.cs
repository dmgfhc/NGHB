using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using CommonClass;
using System.Windows.Forms;

//'-------------------------------------------------------------------------------
//'-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
//'-- 系统名            系统管理
//'-- 子系统名          公共管理
//'-- 程序名            UserID Add
//'-- 程序ID            UserID_Add
//'-- 版本              1.1.01
//'-- 文档号                 
//'-- 设计               
//'-- 代码               
//'-- 代码日期          2012.05.15
//'-- 处理描述          

//'-------------------------------------------------------------------------------
//'-- 更新历史  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
//'-- 版本      日期          修改人         修改内容
//'1.1.01    2012.05.15               

//'-------------------------------------------------------------------------------
//'-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
namespace CommonClass
{
	public class UserID_Add : System.Windows.Forms.Form
	{
		
		#region  " Windows 窗体设计器生成的代码 "
		
		public UserID_Add()
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
		
	
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txt_password;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txt_emp_id;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button Cmd_Cancel;
		internal System.Windows.Forms.Button Cmd_Ok;
		internal System.Windows.Forms.Button cmd_Del;
		internal System.Windows.Forms.Label Label3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserID_Add));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmd_Del = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Cmd_Cancel);
            this.GroupBox1.Controls.Add(this.Cmd_Ok);
            this.GroupBox1.Controls.Add(this.txt_password);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txt_emp_id);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(297, 88);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "[ 用户添加 ]";
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(196, 52);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(92, 24);
            this.Cmd_Cancel.TabIndex = 26;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_ClickEvent);
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(196, 26);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(92, 24);
            this.Cmd_Ok.TabIndex = 25;
            this.Cmd_Ok.Text = "确认";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_OK_ClickEvent);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(91, 52);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(91, 22);
            this.txt_password.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(11, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 19);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "用户名";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_emp_id.Location = new System.Drawing.Point(91, 26);
            this.txt_emp_id.MaxLength = 7;
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(91, 22);
            this.txt_emp_id.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(11, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 19);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "密  码";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cmd_Del);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox2.Location = new System.Drawing.Point(7, 104);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(297, 85);
            this.GroupBox2.TabIndex = 20;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "[ 用户删除 ]";
            // 
            // cmd_Del
            // 
            this.cmd_Del.Location = new System.Drawing.Point(196, 46);
            this.cmd_Del.Name = "cmd_Del";
            this.cmd_Del.Size = new System.Drawing.Size(92, 24);
            this.cmd_Del.TabIndex = 26;
            this.cmd_Del.Text = "用户删除";
            this.cmd_Del.UseVisualStyleBackColor = true;
            this.cmd_Del.Click += new System.EventHandler(this.cmd_Del_ClickEvent);
            // 
            // Label3
            // 
            this.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(11, 15);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(269, 27);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "如果您想删除用户信息时,请选择[用户删除]按钮";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserID_Add
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 18);
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(310, 196);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserID_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户信息设定";
            this.Activated += new System.EventHandler(this.UserID_Add_Activated);
            this.Load += new System.EventHandler(this.UserID_Add_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserID_Add_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		
		#endregion
		
		//==============================================================================================
		// Procedure Name : cmd_Del_ClickEvent
		// Description    :
		//==============================================================================================
		private void cmd_Del_ClickEvent(System.Object sender, System.EventArgs e)
			{
			
			UserID_Del UserID_Del = new UserID_Del();
			
			UserID_Del.ShowDialog();
			
		}
		
		//==============================================================================================
		// Procedure Name : Cmd_OK_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_OK_ClickEvent(System.Object sender, System.EventArgs e)
			{
			
			string sQuery;
			GeneralCommon GeneralCommon = new GeneralCommon();
			SecuritySet Security = new SecuritySet();
			try
			{
				
				if (txt_emp_id.Text == "")
				{
                    GeneralCommon.Gp_MsgBoxDisplay("请输入用户名..!!", "W", "");
					return;
				}
				
				if (txt_password.Text == "")
				{
                    GeneralCommon.Gp_MsgBoxDisplay("请输入密码..!!", "W", "");
					return;
				}
				
				//ID Check
				sQuery = "SELECT EMP_ID FROM zp_EMPLOYEE WHERE EMP_ID = \'" + txt_emp_id.Text.Trim() + "\'";
				if (txt_emp_id.Text.Trim() != GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery))
				{
                    GeneralCommon.Gp_MsgBoxDisplay("输入的用户名不存在..!!", "I", "");
					return;
				}
				
			
				
				//Password(check)
				sQuery = "SELECT PASSWORD FROM zp_EMPLOYEE WHERE EMP_ID = \'" + txt_emp_id.Text.Trim() + "\'";

                string s_md5_pwd = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1,
                "select gf_md5_pwd('" + txt_password.Text.Trim() + "') from dual");

                if (s_md5_pwd != GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery))
				{
                    GeneralCommon.Gp_MsgBoxDisplay("输入的密码不正确..!!", "I", "");
					return;
				}
				
				//Registry ID Insert
				Interaction.SaveSetting("NQIS", "LOGIN", txt_emp_id.Text, "1");
				
				this.Close();
				
			}
			catch (Exception ex)
			{
                GeneralCommon.Gp_MsgBoxDisplay((string)("输入密码失败..!!" + ex.Message), "", "");
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : Cmd_Cancel_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_Cancel_ClickEvent(System.Object sender, System.EventArgs e)
			{
			
			this.Close();
			
		}
		
		//==============================================================================================
		// Procedure Name : UserID_Add_Load
		// Description    :
		//==============================================================================================
		private void UserID_Add_Load(object sender, System.EventArgs e)
			{
			
			this.KeyPreview = true;
			GeneralCommon.Gp_FormCenter(this);
			
		}
		
		//==============================================================================================
		// Procedure Name : UserID_Add_KeyPress
		// Description    :
		//==============================================================================================
		private void UserID_Add_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
			{
			
			if (e.KeyChar == Strings.ChrW(13))
			{
				SendKeys.Send("\t");
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : UserID_Add_Activated
		// Description    :
		//==============================================================================================
		private void UserID_Add_Activated(object sender, System.EventArgs e)
			{
			
			txt_emp_id.Focus();
			
		}
		
	}
	
}
