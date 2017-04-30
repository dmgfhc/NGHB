namespace CG
{
    partial class WGT2021C
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
            this.TXT_CO_CD = new System.Windows.Forms.TextBox();
            this.chk_Cond_W = new System.Windows.Forms.CheckBox();
            this.chk_Cond_N = new System.Windows.Forms.CheckBox();
            this.chk_Cond_B = new System.Windows.Forms.CheckBox();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_CO_CD);
            this.groupBox1.Controls.Add(this.chk_Cond_W);
            this.groupBox1.Controls.Add(this.chk_Cond_N);
            this.groupBox1.Controls.Add(this.chk_Cond_B);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_CO_CD
            // 
            this.TXT_CO_CD.Location = new System.Drawing.Point(938, 10);
            this.TXT_CO_CD.Name = "TXT_CO_CD";
            this.TXT_CO_CD.Size = new System.Drawing.Size(60, 22);
            this.TXT_CO_CD.TabIndex = 15;
            this.TXT_CO_CD.Visible = false;
            // 
            // chk_Cond_W
            // 
            this.chk_Cond_W.AutoSize = true;
            this.chk_Cond_W.Location = new System.Drawing.Point(677, 14);
            this.chk_Cond_W.Name = "chk_Cond_W";
            this.chk_Cond_W.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond_W.TabIndex = 14;
            this.chk_Cond_W.Tag = "W";
            this.chk_Cond_W.Text = "在线探伤";
            this.chk_Cond_W.UseVisualStyleBackColor = true;
            this.chk_Cond_W.Click += new System.EventHandler(this.chk_Cond_W_Click);
            // 
            // chk_Cond_N
            // 
            this.chk_Cond_N.AutoSize = true;
            this.chk_Cond_N.Location = new System.Drawing.Point(802, 13);
            this.chk_Cond_N.Name = "chk_Cond_N";
            this.chk_Cond_N.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond_N.TabIndex = 13;
            this.chk_Cond_N.Tag = "N";
            this.chk_Cond_N.Text = "配送";
            this.chk_Cond_N.UseVisualStyleBackColor = true;
            this.chk_Cond_N.Visible = false;
            // 
            // chk_Cond_B
            // 
            this.chk_Cond_B.AutoSize = true;
            this.chk_Cond_B.Location = new System.Drawing.Point(543, 14);
            this.chk_Cond_B.Name = "chk_Cond_B";
            this.chk_Cond_B.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond_B.TabIndex = 12;
            this.chk_Cond_B.Tag = "B";
            this.chk_Cond_B.Text = "离线探伤";
            this.chk_Cond_B.UseVisualStyleBackColor = true;
            this.chk_Cond_B.Click += new System.EventHandler(this.chk_Cond_B_Click);
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(433, 10);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(54, 21);
            this.CBO_GROUP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(373, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "班别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(230, 10);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 5;
            // 
            // SDT_PROD_DATE_FR
            // 
            this.SDT_PROD_DATE_FR.Location = new System.Drawing.Point(112, 10);
            this.SDT_PROD_DATE_FR.Name = "SDT_PROD_DATE_FR";
            this.SDT_PROD_DATE_FR.RawDate = "";
            this.SDT_PROD_DATE_FR.Size = new System.Drawing.Size(96, 21);
            this.SDT_PROD_DATE_FR.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "探伤时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 37);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1119, 585);
            this.ss1.TabIndex = 1;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT2021C
            // 
            this.ClientSize = new System.Drawing.Size(1119, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT2021C";
            this.Text = "宽厚板探伤日报表查询界面_WGT2021C";
            this.Load += new System.EventHandler(this.WGT3060C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Cond_W;
        private System.Windows.Forms.CheckBox chk_Cond_N;
        private System.Windows.Forms.CheckBox chk_Cond_B;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_CO_CD;
    }
}
