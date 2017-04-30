namespace CG
{
    partial class CGA2081C
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
            this.SDB_TOT_WGT = new CommonClass.NumBox();
            this.TXT_FLAG = new System.Windows.Forms.TextBox();
            this.CBO_SHIFT_REF = new System.Windows.Forms.ComboBox();
            this.ULabel13 = new System.Windows.Forms.Label();
            this.OPT_SCRAP = new System.Windows.Forms.RadioButton();
            this.OPT_SCRAP_WAIT = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.TXT_To_Date = new CommonClass.CeriUDate();
            this.TXT_From_Date = new CommonClass.CeriUDate();
            this.ULabel10 = new System.Windows.Forms.Label();
            this.ULabel1 = new System.Windows.Forms.Label();
            this.txt_mat_no = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDB_TOT_WGT);
            this.groupBox1.Controls.Add(this.TXT_FLAG);
            this.groupBox1.Controls.Add(this.CBO_SHIFT_REF);
            this.groupBox1.Controls.Add(this.ULabel13);
            this.groupBox1.Controls.Add(this.OPT_SCRAP);
            this.groupBox1.Controls.Add(this.OPT_SCRAP_WAIT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Controls.Add(this.TXT_To_Date);
            this.groupBox1.Controls.Add(this.TXT_From_Date);
            this.groupBox1.Controls.Add(this.ULabel10);
            this.groupBox1.Controls.Add(this.ULabel1);
            this.groupBox1.Controls.Add(this.txt_mat_no);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDB_TOT_WGT
            // 
            this.SDB_TOT_WGT.Location = new System.Drawing.Point(712, 18);
            this.SDB_TOT_WGT.Name = "SDB_TOT_WGT";
            this.SDB_TOT_WGT.NumValue = 0D;
            this.SDB_TOT_WGT.Scale = 0;
            this.SDB_TOT_WGT.ShowZero = true;
            this.SDB_TOT_WGT.Size = new System.Drawing.Size(102, 22);
            this.SDB_TOT_WGT.TabIndex = 523;
            this.SDB_TOT_WGT.Text = "0";
            this.SDB_TOT_WGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_FLAG
            // 
            this.TXT_FLAG.Location = new System.Drawing.Point(990, 16);
            this.TXT_FLAG.MaxLength = 12;
            this.TXT_FLAG.Name = "TXT_FLAG";
            this.TXT_FLAG.Size = new System.Drawing.Size(22, 22);
            this.TXT_FLAG.TabIndex = 522;
            this.TXT_FLAG.Visible = false;
            // 
            // CBO_SHIFT_REF
            // 
            this.CBO_SHIFT_REF.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT_REF.FormattingEnabled = true;
            this.CBO_SHIFT_REF.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.CBO_SHIFT_REF.Location = new System.Drawing.Point(394, 18);
            this.CBO_SHIFT_REF.Name = "CBO_SHIFT_REF";
            this.CBO_SHIFT_REF.Size = new System.Drawing.Size(50, 22);
            this.CBO_SHIFT_REF.TabIndex = 521;
            this.CBO_SHIFT_REF.Tag = "跨号";
            // 
            // ULabel13
            // 
            this.ULabel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel13.Location = new System.Drawing.Point(313, 18);
            this.ULabel13.Name = "ULabel13";
            this.ULabel13.Size = new System.Drawing.Size(75, 22);
            this.ULabel13.TabIndex = 520;
            this.ULabel13.Text = "判废班次";
            this.ULabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OPT_SCRAP
            // 
            this.OPT_SCRAP.AutoSize = true;
            this.OPT_SCRAP.Location = new System.Drawing.Point(934, 21);
            this.OPT_SCRAP.Name = "OPT_SCRAP";
            this.OPT_SCRAP.Size = new System.Drawing.Size(64, 17);
            this.OPT_SCRAP.TabIndex = 519;
            this.OPT_SCRAP.TabStop = true;
            this.OPT_SCRAP.Text = "已判废";
            this.OPT_SCRAP.UseVisualStyleBackColor = true;
            this.OPT_SCRAP.Click += new System.EventHandler(this.OPT_SCRAP_Click);
            // 
            // OPT_SCRAP_WAIT
            // 
            this.OPT_SCRAP_WAIT.AutoSize = true;
            this.OPT_SCRAP_WAIT.Location = new System.Drawing.Point(864, 21);
            this.OPT_SCRAP_WAIT.Name = "OPT_SCRAP_WAIT";
            this.OPT_SCRAP_WAIT.Size = new System.Drawing.Size(64, 17);
            this.OPT_SCRAP_WAIT.TabIndex = 518;
            this.OPT_SCRAP_WAIT.TabStop = true;
            this.OPT_SCRAP_WAIT.Text = "待判废";
            this.OPT_SCRAP_WAIT.UseVisualStyleBackColor = true;
            this.OPT_SCRAP_WAIT.Click += new System.EventHandler(this.OPT_SCRAP_WAIT_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(820, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 517;
            this.label5.Tag = "f4";
            this.label5.Text = "ton";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(645, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(61, 22);
            this.ULabel5.TabIndex = 516;
            this.ULabel5.Tag = "f4";
            this.ULabel5.Text = "总量";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_To_Date
            // 
            this.TXT_To_Date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXT_To_Date.Location = new System.Drawing.Point(195, 18);
            this.TXT_To_Date.Name = "TXT_To_Date";
            this.TXT_To_Date.RawDate = "";
            this.TXT_To_Date.Size = new System.Drawing.Size(112, 24);
            this.TXT_To_Date.TabIndex = 514;
            this.TXT_To_Date.Tag = "结束日期";
            // 
            // TXT_From_Date
            // 
            this.TXT_From_Date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXT_From_Date.Location = new System.Drawing.Point(82, 18);
            this.TXT_From_Date.Name = "TXT_From_Date";
            this.TXT_From_Date.RawDate = "";
            this.TXT_From_Date.Size = new System.Drawing.Size(112, 24);
            this.TXT_From_Date.TabIndex = 513;
            this.TXT_From_Date.Tag = "开始日期";
            // 
            // ULabel10
            // 
            this.ULabel10.BackColor = System.Drawing.SystemColors.Control;
            this.ULabel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ULabel10.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ULabel10.ForeColor = System.Drawing.Color.Black;
            this.ULabel10.Location = new System.Drawing.Point(6, 18);
            this.ULabel10.Name = "ULabel10";
            this.ULabel10.Size = new System.Drawing.Size(75, 24);
            this.ULabel10.TabIndex = 512;
            this.ULabel10.Text = "生产日期";
            this.ULabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel1
            // 
            this.ULabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel1.Location = new System.Drawing.Point(450, 18);
            this.ULabel1.Name = "ULabel1";
            this.ULabel1.Size = new System.Drawing.Size(81, 22);
            this.ULabel1.TabIndex = 472;
            this.ULabel1.Tag = "f4";
            this.ULabel1.Text = "板坯号";
            this.ULabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mat_no
            // 
            this.txt_mat_no.Location = new System.Drawing.Point(537, 18);
            this.txt_mat_no.MaxLength = 10;
            this.txt_mat_no.Name = "txt_mat_no";
            this.txt_mat_no.Size = new System.Drawing.Size(102, 22);
            this.txt_mat_no.TabIndex = 1;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 60);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 562);
            this.ss1.TabIndex = 1;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2081C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2081C";
            this.Text = "板坯判废实绩录入界面_CGA2081C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mat_no;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label ULabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ULabel5;
        private CommonClass.CeriUDate TXT_To_Date;
        private CommonClass.CeriUDate TXT_From_Date;
        private System.Windows.Forms.Label ULabel10;
        private System.Windows.Forms.RadioButton OPT_SCRAP;
        private System.Windows.Forms.RadioButton OPT_SCRAP_WAIT;
        private System.Windows.Forms.ComboBox CBO_SHIFT_REF;
        private System.Windows.Forms.Label ULabel13;
        private System.Windows.Forms.TextBox TXT_FLAG;
        private CommonClass.NumBox SDB_TOT_WGT;
    }
}
