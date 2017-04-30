using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class EditDlg : System.Windows.Forms.Form
		{
		
		//Form 重写 Dispose，以清理组件列表�?
		
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Windows 窗体设计器所必需�?
		
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程�?Windows 窗体设计器所必需�?
		
		//可以使用 Windows 窗体设计器修改它�?
		
		//不要使用代码编辑器修改它�?
		
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
			this.pnl_button = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.txt_Editor = new System.Windows.Forms.RichTextBox();
			this.pnl_button.SuspendLayout();
			this.SuspendLayout();
			//
			//pnl_button
			//
			this.pnl_button.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte) (224)), System.Convert.ToInt32((byte) (224)), System.Convert.ToInt32((byte) (224)));
			this.pnl_button.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnl_button.Controls.Add(this.btnClose);
			this.pnl_button.Controls.Add(this.btnClear);
			this.pnl_button.Controls.Add(this.btnSave);
			this.pnl_button.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.pnl_button.Location = new System.Drawing.Point(12, 12);
			this.pnl_button.Name = "pnl_button";
			this.pnl_button.Size = new System.Drawing.Size(336, 44);
			this.pnl_button.TabIndex = 2;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(221, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(104, 32);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭(&X)";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(113, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(104, 32);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "清除(&C)";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(6, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 32);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "保存(&S)";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//txt_Editor
			//
			this.txt_Editor.Location = new System.Drawing.Point(12, 62);
			this.txt_Editor.Name = "txt_Editor";
			this.txt_Editor.Size = new System.Drawing.Size(336, 192);
			this.txt_Editor.TabIndex = 1;
			this.txt_Editor.Text = "";
			//
			//EditDlg
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 12.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 266);
			this.ControlBox = false;
			this.Controls.Add(this.txt_Editor);
			this.Controls.Add(this.pnl_button);
			this.MaximizeBox = false;
			this.Name = "EditDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Editor";
			this.pnl_button.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Panel pnl_button;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.RichTextBox txt_Editor;
	}
	
}
