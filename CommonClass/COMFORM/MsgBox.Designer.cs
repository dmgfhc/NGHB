namespace CommonClass
{
    partial class MsgBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chk_timer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Location = new System.Drawing.Point(1, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(226, 89);
            this.lbl.TabIndex = 0;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.AutoSize = true;
            this.btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn.Location = new System.Drawing.Point(81, 92);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(76, 25);
            this.btn.TabIndex = 1;
            this.btn.Text = "确定";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chk_timer
            // 
            this.chk_timer.AutoSize = true;
            this.chk_timer.Checked = true;
            this.chk_timer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_timer.Location = new System.Drawing.Point(149, 70);
            this.chk_timer.Name = "chk_timer";
            this.chk_timer.Size = new System.Drawing.Size(15, 14);
            this.chk_timer.TabIndex = 2;
            this.chk_timer.UseVisualStyleBackColor = true;
            this.chk_timer.Visible = false;
            this.chk_timer.CheckedChanged += new System.EventHandler(this.chk_timer_CheckedChanged);
            // 
            // MsgBox
            // 
            this.AcceptButton = this.btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn;
            this.ClientSize = new System.Drawing.Size(232, 122);
            this.Controls.Add(this.chk_timer);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowInTaskbar = false;
            this.Text = "信息提示";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn;
        public System.Windows.Forms.CheckBox chk_timer;
        public System.Windows.Forms.Timer timer1;
    }
}