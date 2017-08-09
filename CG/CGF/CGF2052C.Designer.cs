namespace CG
{
    partial class CGF2052C
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBO_ROLL_ID = new System.Windows.Forms.ComboBox();
            this.ULabel16 = new System.Windows.Forms.Label();
            this.SDT_IN_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_IN_DATE_FROM = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBO_ROLL_ID);
            this.groupBox1.Controls.Add(this.ULabel16);
            this.groupBox1.Controls.Add(this.SDT_IN_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_IN_DATE_FROM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CBO_ROLL_ID
            // 
            this.CBO_ROLL_ID.FormattingEnabled = true;
            this.CBO_ROLL_ID.Location = new System.Drawing.Point(469, 18);
            this.CBO_ROLL_ID.MaxLength = 7;
            this.CBO_ROLL_ID.Name = "CBO_ROLL_ID";
            this.CBO_ROLL_ID.Size = new System.Drawing.Size(81, 21);
            this.CBO_ROLL_ID.TabIndex = 624;
            // 
            // ULabel16
            // 
            this.ULabel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel16.Location = new System.Drawing.Point(371, 18);
            this.ULabel16.Name = "ULabel16";
            this.ULabel16.Size = new System.Drawing.Size(92, 21);
            this.ULabel16.TabIndex = 623;
            this.ULabel16.Text = "轧辊号";
            this.ULabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_IN_DATE_TO
            // 
            this.SDT_IN_DATE_TO.Font = new System.Drawing.Font("宋体", 9.75F);
            this.SDT_IN_DATE_TO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_IN_DATE_TO.Location = new System.Drawing.Point(231, 18);
            this.SDT_IN_DATE_TO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SDT_IN_DATE_TO.Name = "SDT_IN_DATE_TO";
            this.SDT_IN_DATE_TO.RawDate = "";
            this.SDT_IN_DATE_TO.Size = new System.Drawing.Size(94, 21);
            this.SDT_IN_DATE_TO.TabIndex = 583;
            this.SDT_IN_DATE_TO.Tag = "结束时间";
            // 
            // SDT_IN_DATE_FROM
            // 
            this.SDT_IN_DATE_FROM.Font = new System.Drawing.Font("宋体", 9.75F);
            this.SDT_IN_DATE_FROM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_IN_DATE_FROM.Location = new System.Drawing.Point(128, 18);
            this.SDT_IN_DATE_FROM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SDT_IN_DATE_FROM.Name = "SDT_IN_DATE_FROM";
            this.SDT_IN_DATE_FROM.RawDate = "";
            this.SDT_IN_DATE_FROM.Size = new System.Drawing.Size(95, 21);
            this.SDT_IN_DATE_FROM.TabIndex = 582;
            this.SDT_IN_DATE_FROM.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(36, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 581;
            this.label4.Text = "装配时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 56);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1129, 566);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGF2052C
            // 
            this.ClientSize = new System.Drawing.Size(1129, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGF2052C";
            this.Text = "轧辊装配实绩查询及发送_CGF2052C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        public CommonClass.CeriUDate SDT_IN_DATE_TO;
        public CommonClass.CeriUDate SDT_IN_DATE_FROM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_ROLL_ID;
        private System.Windows.Forms.Label ULabel16;
    }
}
