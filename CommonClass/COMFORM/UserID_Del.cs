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
//'-- 程序名            UserID_Del
//'-- 程序ID            UserID_Del
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
//'1.1.01    2006.08.17               

//'-------------------------------------------------------------------------------
//'-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//'-------------------------------------------------------------------------------
namespace CommonClass
{
	public class UserID_Del : System.Windows.Forms.Form
	{
		
		#region  " Windows 窗体设计器生成的代码 "
		
		public UserID_Del()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Cmd_Cancel;
		internal System.Windows.Forms.Button Cmd_Ok;
		internal System.Windows.Forms.ComboBox cbo_emp_id;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserID_Del));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbo_emp_id = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Cmd_Cancel);
            this.GroupBox1.Controls.Add(this.Cmd_Ok);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cbo_emp_id);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(241, 83);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "[ 请选择要删除的用户名 ]";
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(126, 50);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(92, 24);
            this.Cmd_Cancel.TabIndex = 13;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_ClickEvent);
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(15, 50);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(92, 24);
            this.Cmd_Ok.TabIndex = 12;
            this.Cmd_Ok.Text = "确认";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_OK_ClickEvent);
            // 
            // Label2
            // 
            this.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(12, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(108, 19);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "要删除的用户名";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_emp_id
            // 
            this.cbo_emp_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_emp_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_emp_id.Location = new System.Drawing.Point(126, 19);
            this.cbo_emp_id.Name = "cbo_emp_id";
            this.cbo_emp_id.Size = new System.Drawing.Size(90, 21);
            this.cbo_emp_id.TabIndex = 0;
            // 
            // UserID_Del
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 18);
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(254, 100);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserID_Del";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户信息删除";
            this.Activated += new System.EventHandler(this.UserID_Del_Activated);
            this.Load += new System.EventHandler(this.UserID_Del_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserID_Del_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		
		#endregion
		
		//==============================================================================================
		// Procedure Name : Cmd_OK_ClickEvent
		// Description    :
		//==============================================================================================
		private void Cmd_OK_ClickEvent(object sender, System.EventArgs e)
			{

                object[,] Reg_id = new object[100, 8];
                int intSettings;
			
			try
			{
				
				if (cbo_emp_id.Text == "")
				{
                    GeneralCommon.Gp_MsgBoxDisplay("请输入用户名..!", "W", "");
					return;
				}
				
				//Registry ID Delete
				Interaction.DeleteSetting("NQIS", "LOGIN", cbo_emp_id.Text);

                GeneralCommon.Gp_MsgBoxDisplay("删除用户成功..!!", "I", "");
				
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
			catch (Exception ex)
			{
                GeneralCommon.Gp_MsgBoxDisplay((string)("删除用户名失败..!!" + ex.Message), "", "");
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
		// Procedure Name : UserID_Del_Load
		// Description    :
		//==============================================================================================
		private void UserID_Del_Load(object sender, System.EventArgs e)
			{
			
			object[,] Reg_id=new object[100,100];
			int intSettings;
			
			this.KeyPreview = true;
			
			GeneralCommon.Gp_FormCenter(this);
			
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
		// Procedure Name : UserID_Del_KeyPress
		// Description    :
		//==============================================================================================
		private void UserID_Del_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
			{
			
			if (e.KeyChar == Strings.ChrW(13))
			{
				SendKeys.Send("\t");
			}
			
		}
		
		//==============================================================================================
		// Procedure Name : UserID_Del_Activated
		// Description    :
		//==============================================================================================
		private void UserID_Del_Activated(object sender, System.EventArgs e)
			{
			
			cbo_emp_id.Focus();
			
		}
		
	}
	
}
