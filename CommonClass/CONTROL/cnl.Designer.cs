using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class cnl : System.Windows.Forms.UserControl
		{
			
		
		//UserControl 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
			this.lbl = new System.Windows.Forms.Label();
			this.nud = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize) this.nud).BeginInit();
			this.SuspendLayout();
			//
			//lbl
			//
			this.lbl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.lbl.Location = new System.Drawing.Point(0, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(59, 22);
			this.lbl.TabIndex = 0;
			this.lbl.Text = "Label1";
			//
			//nud
			//
			this.nud.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.nud.Location = new System.Drawing.Point(70, 0);
			this.nud.Name = "nud";
			this.nud.Size = new System.Drawing.Size(119, 22);
			this.nud.TabIndex = 1;
			//
			//cnl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nud);
			this.Controls.Add(this.lbl);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Name = "cnl";
			this.Size = new System.Drawing.Size(190, 24);
			((System.ComponentModel.ISupportInitialize) this.nud).EndInit();
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.Label lbl;
		public System.Windows.Forms.NumericUpDown nud;
		
	}
	
}
