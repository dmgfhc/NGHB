using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using CommonClass;

//-------------------------------------------------------------------------------
//-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- 系统名            系统管理
//-- 子系统名          公共管理
//-- 程序名            SPREAD 列排序
//-- 程序ID            Spread_ColSort
//-- 版本              1.1.01
//-- 文档号
//-- 设计
//-- 代码
//-- 代码日期          2006.08.17
//-- 处理描述

//-------------------------------------------------------------------------------
//-- 更新历史  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- 版本      日期          修改人         修改内容
//1.1.01    2006.08.17

//-------------------------------------------------------------------------------
//-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CommonClass
{
	public class Spread_ColSort : System.Windows.Forms.Form
	{
		public static FarPoint.Win.Spread.FpSpread Active_Spread = new FarPoint.Win.Spread.FpSpread(); //Active Spread Sheet Object
		
		#region  Windows 窗体设计器生成的代码
		
		public Spread_ColSort()
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label3;
		
		internal System.Windows.Forms.RadioButton opt_first_a;
		internal System.Windows.Forms.RadioButton opt_second_a;
		internal System.Windows.Forms.RadioButton opt_third_a;
		internal System.Windows.Forms.RadioButton opt_first_d;
		internal System.Windows.Forms.RadioButton opt_second_d;
		internal System.Windows.Forms.RadioButton opt_third_d;
		public System.Windows.Forms.ComboBox cbo_second;
		public System.Windows.Forms.ComboBox cbo_third;
		internal System.Windows.Forms.Button Cmd_Ok;
		internal System.Windows.Forms.Button Cmd_Cancel;
		public System.Windows.Forms.ComboBox cbo_first;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spread_ColSort));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbo_first = new System.Windows.Forms.ComboBox();
            this.opt_first_d = new System.Windows.Forms.RadioButton();
            this.opt_first_a = new System.Windows.Forms.RadioButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbo_second = new System.Windows.Forms.ComboBox();
            this.opt_second_d = new System.Windows.Forms.RadioButton();
            this.opt_second_a = new System.Windows.Forms.RadioButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbo_third = new System.Windows.Forms.ComboBox();
            this.opt_third_d = new System.Windows.Forms.RadioButton();
            this.opt_third_a = new System.Windows.Forms.RadioButton();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.cbo_first);
            this.Panel1.Controls.Add(this.opt_first_d);
            this.Panel1.Controls.Add(this.opt_first_a);
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(317, 56);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label1.Location = new System.Drawing.Point(7, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "第一排序";
            // 
            // cbo_first
            // 
            this.cbo_first.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbo_first.Location = new System.Drawing.Point(7, 24);
            this.cbo_first.Name = "cbo_first";
            this.cbo_first.Size = new System.Drawing.Size(171, 25);
            this.cbo_first.TabIndex = 2;
            this.cbo_first.SelectedIndexChanged += new System.EventHandler(this.cbo_first_SelectedIndexChanged);
            // 
            // opt_first_d
            // 
            this.opt_first_d.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_first_d.ForeColor = System.Drawing.Color.DarkGray;
            this.opt_first_d.Location = new System.Drawing.Point(192, 29);
            this.opt_first_d.Name = "opt_first_d";
            this.opt_first_d.Size = new System.Drawing.Size(108, 20);
            this.opt_first_d.TabIndex = 1;
            this.opt_first_d.Text = "降序";
            this.opt_first_d.Click += new System.EventHandler(this.opt_first_d_Click);
            // 
            // opt_first_a
            // 
            this.opt_first_a.Checked = true;
            this.opt_first_a.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_first_a.ForeColor = System.Drawing.Color.Red;
            this.opt_first_a.Location = new System.Drawing.Point(192, 9);
            this.opt_first_a.Name = "opt_first_a";
            this.opt_first_a.Size = new System.Drawing.Size(100, 20);
            this.opt_first_a.TabIndex = 0;
            this.opt_first_a.TabStop = true;
            this.opt_first_a.Text = "升序";
            this.opt_first_a.Click += new System.EventHandler(this.opt_first_a_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.cbo_second);
            this.Panel2.Controls.Add(this.opt_second_d);
            this.Panel2.Controls.Add(this.opt_second_a);
            this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel2.Location = new System.Drawing.Point(3, 63);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(317, 56);
            this.Panel2.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Location = new System.Drawing.Point(7, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "第二排序";
            // 
            // cbo_second
            // 
            this.cbo_second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbo_second.Location = new System.Drawing.Point(7, 24);
            this.cbo_second.Name = "cbo_second";
            this.cbo_second.Size = new System.Drawing.Size(171, 25);
            this.cbo_second.TabIndex = 2;
            this.cbo_second.SelectedIndexChanged += new System.EventHandler(this.cbo_second_SelectedIndexChanged);
            // 
            // opt_second_d
            // 
            this.opt_second_d.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_second_d.ForeColor = System.Drawing.Color.DarkGray;
            this.opt_second_d.Location = new System.Drawing.Point(192, 29);
            this.opt_second_d.Name = "opt_second_d";
            this.opt_second_d.Size = new System.Drawing.Size(108, 20);
            this.opt_second_d.TabIndex = 1;
            this.opt_second_d.Text = "降序";
            this.opt_second_d.Click += new System.EventHandler(this.opt_second_d_Click);
            // 
            // opt_second_a
            // 
            this.opt_second_a.Checked = true;
            this.opt_second_a.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_second_a.ForeColor = System.Drawing.Color.Red;
            this.opt_second_a.Location = new System.Drawing.Point(192, 9);
            this.opt_second_a.Name = "opt_second_a";
            this.opt_second_a.Size = new System.Drawing.Size(104, 20);
            this.opt_second_a.TabIndex = 0;
            this.opt_second_a.TabStop = true;
            this.opt_second_a.Text = "升序";
            this.opt_second_a.Click += new System.EventHandler(this.opt_second_a_Click);
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.cbo_third);
            this.Panel3.Controls.Add(this.opt_third_d);
            this.Panel3.Controls.Add(this.opt_third_a);
            this.Panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel3.Location = new System.Drawing.Point(2, 123);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(318, 73);
            this.Panel3.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Location = new System.Drawing.Point(7, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "第三排序";
            // 
            // cbo_third
            // 
            this.cbo_third.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_third.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbo_third.Location = new System.Drawing.Point(7, 24);
            this.cbo_third.Name = "cbo_third";
            this.cbo_third.Size = new System.Drawing.Size(171, 25);
            this.cbo_third.TabIndex = 2;
            this.cbo_third.SelectedIndexChanged += new System.EventHandler(this.cbo_third_SelectedIndexChanged);
            // 
            // opt_third_d
            // 
            this.opt_third_d.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_third_d.ForeColor = System.Drawing.Color.DarkGray;
            this.opt_third_d.Location = new System.Drawing.Point(192, 40);
            this.opt_third_d.Name = "opt_third_d";
            this.opt_third_d.Size = new System.Drawing.Size(120, 20);
            this.opt_third_d.TabIndex = 1;
            this.opt_third_d.Text = "降序";
            this.opt_third_d.Click += new System.EventHandler(this.opt_third_d_Click);
            // 
            // opt_third_a
            // 
            this.opt_third_a.Checked = true;
            this.opt_third_a.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt_third_a.ForeColor = System.Drawing.Color.Red;
            this.opt_third_a.Location = new System.Drawing.Point(192, 16);
            this.opt_third_a.Name = "opt_third_a";
            this.opt_third_a.Size = new System.Drawing.Size(104, 20);
            this.opt_third_a.TabIndex = 0;
            this.opt_third_a.TabStop = true;
            this.opt_third_a.Text = "升序";
            this.opt_third_a.Click += new System.EventHandler(this.opt_third_a_Click);
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(11, 212);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(100, 25);
            this.Cmd_Ok.TabIndex = 3;
            this.Cmd_Ok.Text = "确定";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.cmd_ok_ClickEvent);
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(126, 212);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(100, 25);
            this.Cmd_Cancel.TabIndex = 4;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.cmd_cancel_ClickEvent);
            // 
            // Spread_ColSort
            // 
            this.ClientSize = new System.Drawing.Size(322, 259);
            this.Controls.Add(this.Cmd_Cancel);
            this.Controls.Add(this.Cmd_Ok);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spread_ColSort";
            this.Text = "按列排序";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Spread_ColSort_Closing);
            this.Load += new System.EventHandler(this.Spread_ColSort_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Spread_ColSort_KeyPress);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		
		#endregion
		
		#region Form Load...
		
		private void Spread_ColSort_Load(object sender, System.EventArgs e)
		{
			
			SpreadCommon SpreadCommon = new SpreadCommon();
			
			GeneralCommon.Gp_FormCenter(this);
			SpreadCommon.Gp_Sp_ColSort(Active_Spread, cbo_first,ref cbo_second,ref cbo_third);
			
			cbo_second.Enabled = false;
			cbo_third.Enabled = false;
			
			opt_second_a.Enabled = false;
			opt_second_d.Enabled = false;
			opt_third_a.Enabled = false;
			opt_third_d.Enabled = false;
			
			this.BackColor = GeneralCommon.VbFormBKColor;
			
		}
		
		private void Spread_ColSort_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			short KeyAscii = (short) (Strings.Asc(e.KeyChar));
			
			if (e.KeyChar == Microsoft.VisualBasic.Strings.ChrW(13))
			{
				SendKeys.Send("{tab}");
				KeyAscii = (short) 0;
				e.Handled = true;
			}
			
		}
		
		private void Spread_ColSort_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			Active_Spread = null;
			
		}
		
		#endregion
		
		#region ComboBox Select Data Check...
		
		private void cbo_first_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			if (cbo_first.Text == "")
			{
				cbo_second.SelectedIndex = 0;
				cbo_third.SelectedIndex = 0;
				cbo_second.Enabled = false;
				cbo_third.Enabled = false;
				opt_second_a.Enabled = false;
				opt_second_d.Enabled = false;
				opt_third_a.Enabled = false;
				opt_third_d.Enabled = false;
				return;
			}
			else
			{
				cbo_second.Enabled = true;
				opt_second_a.Enabled = true;
				opt_second_d.Enabled = true;
			}
			
			if (cbo_first.Text == cbo_second.Text || cbo_first.Text == cbo_third.Text)
			{
				GeneralCommon.Gp_MsgBoxDisplay("Selected already from other condition", "I", "");
				cbo_first.SelectedIndex = 0;
				
			}
		}
		
		private void cbo_second_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			if (cbo_second.Text == "")
			{
				cbo_third.SelectedIndex = 0;
				cbo_third.Enabled = false;
				opt_third_a.Enabled = false;
				opt_third_d.Enabled = false;
				return;
			}
			else
			{
				cbo_third.Enabled = true;
				opt_third_a.Enabled = true;
				opt_third_d.Enabled = true;
			}
			
			if (cbo_second.Text == cbo_first.Text || cbo_second.Text == cbo_third.Text)
			{
				GeneralCommon.Gp_MsgBoxDisplay("Selected already from other condition", "I", "");
				cbo_second.SelectedIndex = 0;
				
			}
		}
		
		private void cbo_third_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			if (cbo_third.Text == "")
			{
				return;
			}
			
			if (cbo_third.Text == cbo_first.Text || cbo_third.Text == cbo_second.Text)
			{
				GeneralCommon.Gp_MsgBoxDisplay("Selected already from other condition", "I", "");
				cbo_third.SelectedIndex = 0;
			}
			
		}
		
		#endregion
		
		#region Button Click...
		
		private void cmd_cancel_ClickEvent(object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		private void cmd_ok_ClickEvent(object sender, System.EventArgs e)
		{
			
			
			if (cbo_first.Text != "")
			{
				
				//(1, CInt(Microsoft.VisualBasic.Right(cbo_first.Text, 2)))        'col
				//If opt_first_a.Checked = True Then
				//    .set_SortKeyOrder(1, FPSpread.SortKeyOrderConstants.SortKeyOrderAscending)
				//Else
				//    .set_SortKeyOrder(1, FPSpread.SortKeyOrderConstants.SortKeyOrderDescending)
				//End If
			}
			
			if (cbo_second.Text != "")
			{
				//.set_SortKey(2, CInt(Microsoft.VisualBasic.Right(cbo_second.Text, 2)))       'col
				//If opt_second_a.Checked = True Then
				//    .set_SortKeyOrder(2, FPSpread.SortKeyOrderConstants.SortKeyOrderAscending)
				//Else
				//    .set_SortKeyOrder(2, FPSpread.SortKeyOrderConstants.SortKeyOrderDescending)
				//End If
			}
			
			if (cbo_third.Text != "")
			{
				//.set_SortKey(3, CInt(Microsoft.VisualBasic.Right(cbo_third.Text, 2)))       'col
				//If opt_third_a.Checked = True Then
				//    .set_SortKeyOrder(3, FPSpread.SortKeyOrderConstants.SortKeyOrderAscending)
				//Else
				//    .set_SortKeyOrder(3, FPSpread.SortKeyOrderConstants.SortKeyOrderDescending)
				//End If
			}
			
			//.Col = 1
			//.Col2 = .MaxCols
			
			//.Row = .RowsFrozen + 1
			//.Row2 = .MaxRows
			//.Action = FPSpread.ActionConstants.ActionSort
			
			
			this.Dispose();
			
		}
		
		#endregion
		
		#region Option Button Click...
		
		private void opt_first_a_Click(object sender, System.EventArgs e)
		{
			
			if (opt_first_a.Checked == true)
			{
				opt_first_a.ForeColor = Color.Red;
				opt_first_d.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_first_d.ForeColor = Color.Red;
				opt_first_a.ForeColor = Color.DarkGray;
			}
			
		}
		
		private void opt_first_d_Click(System.Object sender, System.EventArgs e)
		{
			
			if (opt_first_d.Checked == true)
			{
				opt_first_d.ForeColor = Color.Red;
				opt_first_a.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_first_a.ForeColor = Color.Red;
				opt_first_d.ForeColor = Color.DarkGray;
			}
			
		}
		
		private void opt_second_a_Click(object sender, System.EventArgs e)
		{
			
			if (opt_second_a.Checked == true)
			{
				opt_second_a.ForeColor = Color.Red;
				opt_second_d.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_second_d.ForeColor = Color.Red;
				opt_second_a.ForeColor = Color.DarkGray;
			}
			
		}
		
		private void opt_second_d_Click(System.Object sender, System.EventArgs e)
		{
			
			if (opt_second_d.Checked == true)
			{
				opt_second_d.ForeColor = Color.Red;
				opt_second_a.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_second_a.ForeColor = Color.Red;
				opt_second_d.ForeColor = Color.DarkGray;
			}
			
		}
		
		private void opt_third_a_Click(object sender, System.EventArgs e)
		{
			
			if (opt_third_a.Checked == true)
			{
				opt_third_a.ForeColor = Color.Red;
				opt_third_d.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_third_d.ForeColor = Color.Red;
				opt_third_a.ForeColor = Color.DarkGray;
			}
			
		}
		
		private void opt_third_d_Click(System.Object sender, System.EventArgs e)
		{
			
			if (opt_third_d.Checked == true)
			{
				opt_third_d.ForeColor = Color.Red;
				opt_third_a.ForeColor = Color.DarkGray;
			}
			else
			{
				opt_third_a.ForeColor = Color.Red;
				opt_third_d.ForeColor = Color.DarkGray;
			}
			
		}
		
		#endregion
		
	}
	
}
