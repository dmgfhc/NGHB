namespace CG
{
    partial class CGF2032C
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBO_ROLL_TYPE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_ROLL_ID = new System.Windows.Forms.ComboBox();
            this.ULabel16 = new System.Windows.Forms.Label();
            this.SDT_GRIND_DATE_TO = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.SDT_GRIND_DATE_FROM = new CommonClass.CeriUDate();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1243, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1243, 519);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1237, 498);
            this.ss1.TabIndex = 2;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBO_ROLL_TYPE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_ROLL_ID);
            this.groupBox1.Controls.Add(this.ULabel16);
            this.groupBox1.Controls.Add(this.SDT_GRIND_DATE_TO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SDT_GRIND_DATE_FROM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CBO_ROLL_TYPE
            // 
            this.CBO_ROLL_TYPE.FormattingEnabled = true;
            this.CBO_ROLL_TYPE.Location = new System.Drawing.Point(660, 22);
            this.CBO_ROLL_TYPE.MaxLength = 7;
            this.CBO_ROLL_TYPE.Name = "CBO_ROLL_TYPE";
            this.CBO_ROLL_TYPE.Size = new System.Drawing.Size(105, 21);
            this.CBO_ROLL_TYPE.TabIndex = 632;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(570, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 631;
            this.label1.Text = "轧辊类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_ROLL_ID
            // 
            this.CBO_ROLL_ID.FormattingEnabled = true;
            this.CBO_ROLL_ID.Location = new System.Drawing.Point(459, 22);
            this.CBO_ROLL_ID.MaxLength = 7;
            this.CBO_ROLL_ID.Name = "CBO_ROLL_ID";
            this.CBO_ROLL_ID.Size = new System.Drawing.Size(105, 21);
            this.CBO_ROLL_ID.TabIndex = 630;
            // 
            // ULabel16
            // 
            this.ULabel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel16.Location = new System.Drawing.Point(369, 22);
            this.ULabel16.Name = "ULabel16";
            this.ULabel16.Size = new System.Drawing.Size(84, 19);
            this.ULabel16.TabIndex = 629;
            this.ULabel16.Text = "轧辊号";
            this.ULabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_GRIND_DATE_TO
            // 
            this.SDT_GRIND_DATE_TO.Font = new System.Drawing.Font("宋体", 11F);
            this.SDT_GRIND_DATE_TO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_GRIND_DATE_TO.Location = new System.Drawing.Point(254, 22);
            this.SDT_GRIND_DATE_TO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SDT_GRIND_DATE_TO.Name = "SDT_GRIND_DATE_TO";
            this.SDT_GRIND_DATE_TO.RawDate = "";
            this.SDT_GRIND_DATE_TO.Size = new System.Drawing.Size(108, 25);
            this.SDT_GRIND_DATE_TO.TabIndex = 628;
            this.SDT_GRIND_DATE_TO.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(39, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 627;
            this.label4.Text = "磨削时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_GRIND_DATE_FROM
            // 
            this.SDT_GRIND_DATE_FROM.Font = new System.Drawing.Font("宋体", 11F);
            this.SDT_GRIND_DATE_FROM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_GRIND_DATE_FROM.Location = new System.Drawing.Point(138, 22);
            this.SDT_GRIND_DATE_FROM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SDT_GRIND_DATE_FROM.Name = "SDT_GRIND_DATE_FROM";
            this.SDT_GRIND_DATE_FROM.RawDate = "";
            this.SDT_GRIND_DATE_FROM.Size = new System.Drawing.Size(108, 25);
            this.SDT_GRIND_DATE_FROM.TabIndex = 626;
            this.SDT_GRIND_DATE_FROM.Tag = "开始时间";
            // 
            // CGF2032C
            // 
            this.ClientSize = new System.Drawing.Size(1243, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGF2032C";
            this.Text = "轧辊磨削实绩查询(按时间)_CGF2032C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        public CommonClass.CeriUDate SDT_GRIND_DATE_FROM;
        public CommonClass.CeriUDate SDT_GRIND_DATE_TO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_ROLL_TYPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_ROLL_ID;
        private System.Windows.Forms.Label ULabel16;
    }
}
