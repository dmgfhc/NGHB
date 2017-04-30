using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class PopupForm : System.Windows.Forms.Form
		{
		
		//Form 重写 Dispose，以清理组件列表。
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupForm));
                this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
                this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
                this.Button1 = new System.Windows.Forms.Button();
                this.Button2 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
                this.SplitContainer1.Panel2.SuspendLayout();
                this.SplitContainer1.SuspendLayout();
                this.FlowLayoutPanel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // SplitContainer1
                // 
                this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
                this.SplitContainer1.Name = "SplitContainer1";
                this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                // 
                // SplitContainer1.Panel2
                // 
                this.SplitContainer1.Panel2.Controls.Add(this.FlowLayoutPanel1);
                this.SplitContainer1.Size = new System.Drawing.Size(630, 405);
                this.SplitContainer1.SplitterDistance = 349;
                this.SplitContainer1.TabIndex = 0;
                // 
                // FlowLayoutPanel1
                // 
                this.FlowLayoutPanel1.Controls.Add(this.Button1);
                this.FlowLayoutPanel1.Controls.Add(this.Button2);
                this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
                this.FlowLayoutPanel1.Size = new System.Drawing.Size(630, 52);
                this.FlowLayoutPanel1.TabIndex = 0;
                // 
                // Button1
                // 
                this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Button1.Location = new System.Drawing.Point(3, 3);
                this.Button1.Name = "Button1";
                this.Button1.Size = new System.Drawing.Size(118, 35);
                this.Button1.TabIndex = 0;
                this.Button1.Text = "确定";
                this.Button1.UseVisualStyleBackColor = true;
                // 
                // Button2
                // 
                this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Button2.Location = new System.Drawing.Point(127, 3);
                this.Button2.Name = "Button2";
                this.Button2.Size = new System.Drawing.Size(127, 32);
                this.Button2.TabIndex = 1;
                this.Button2.Text = "取消";
                this.Button2.UseVisualStyleBackColor = true;
                // 
                // PopupForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoSize = true;
                this.ClientSize = new System.Drawing.Size(630, 405);
                this.Controls.Add(this.SplitContainer1);
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "PopupForm";
                this.ShowInTaskbar = false;
                this.Text = "详细信息";
                this.TopMost = true;
                this.Activated += new System.EventHandler(this.PopupForm_Activated);
                this.Load += new System.EventHandler(this.PopupForm_Load);
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PopupForm_KeyUp);
                this.SplitContainer1.Panel2.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
                this.SplitContainer1.ResumeLayout(false);
                this.FlowLayoutPanel1.ResumeLayout(false);
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.SplitContainer SplitContainer1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
		
	}
	
}
