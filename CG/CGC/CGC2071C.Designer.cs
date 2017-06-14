namespace CG
{
    partial class CGC2071C
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
            this.CMD_EXCEL = new System.Windows.Forms.Button();
            this.SSP1 = new System.Windows.Forms.Button();
            this.SSP2 = new System.Windows.Forms.Button();
            this.SSP3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opt_line4 = new System.Windows.Forms.RadioButton();
            this.opt_line3 = new System.Windows.Forms.RadioButton();
            this.opt_line2 = new System.Windows.Forms.RadioButton();
            this.opt_line1 = new System.Windows.Forms.RadioButton();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.ULabel40 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_SEQ = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMD_EXCEL);
            this.groupBox1.Controls.Add(this.SSP1);
            this.groupBox1.Controls.Add(this.SSP2);
            this.groupBox1.Controls.Add(this.SSP3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_line);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.ULabel40);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_SEQ);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CMD_EXCEL
            // 
            this.CMD_EXCEL.ForeColor = System.Drawing.Color.Red;
            this.CMD_EXCEL.Location = new System.Drawing.Point(522, 52);
            this.CMD_EXCEL.Name = "CMD_EXCEL";
            this.CMD_EXCEL.Size = new System.Drawing.Size(111, 23);
            this.CMD_EXCEL.TabIndex = 594;
            this.CMD_EXCEL.Text = "Excel导出";
            this.CMD_EXCEL.UseVisualStyleBackColor = true;
            this.CMD_EXCEL.Click += new System.EventHandler(this.CMD_EXCEL_Click);
            // 
            // SSP1
            // 
            this.SSP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SSP1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP1.ForeColor = System.Drawing.Color.Blue;
            this.SSP1.Location = new System.Drawing.Point(912, 51);
            this.SSP1.Name = "SSP1";
            this.SSP1.Size = new System.Drawing.Size(94, 28);
            this.SSP1.TabIndex = 593;
            this.SSP1.Text = "一坯多订单";
            this.SSP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SSP1.UseVisualStyleBackColor = false;
            // 
            // SSP2
            // 
            this.SSP2.BackColor = System.Drawing.Color.Blue;
            this.SSP2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP2.ForeColor = System.Drawing.Color.Black;
            this.SSP2.Location = new System.Drawing.Point(812, 51);
            this.SSP2.Name = "SSP2";
            this.SSP2.Size = new System.Drawing.Size(94, 28);
            this.SSP2.TabIndex = 592;
            this.SSP2.Text = "热处理指示";
            this.SSP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SSP2.UseVisualStyleBackColor = false;
            // 
            // SSP3
            // 
            this.SSP3.BackColor = System.Drawing.Color.White;
            this.SSP3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP3.ForeColor = System.Drawing.Color.Red;
            this.SSP3.Location = new System.Drawing.Point(912, 18);
            this.SSP3.Name = "SSP3";
            this.SSP3.Size = new System.Drawing.Size(94, 28);
            this.SSP3.TabIndex = 591;
            this.SSP3.Text = "计划取样";
            this.SSP3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SSP3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.opt_line4);
            this.panel1.Controls.Add(this.opt_line3);
            this.panel1.Controls.Add(this.opt_line2);
            this.panel1.Controls.Add(this.opt_line1);
            this.panel1.Location = new System.Drawing.Point(639, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 47);
            this.panel1.TabIndex = 584;
            // 
            // opt_line4
            // 
            this.opt_line4.AutoSize = true;
            this.opt_line4.ForeColor = System.Drawing.Color.Red;
            this.opt_line4.Location = new System.Drawing.Point(69, 25);
            this.opt_line4.Name = "opt_line4";
            this.opt_line4.Size = new System.Drawing.Size(39, 17);
            this.opt_line4.TabIndex = 3;
            this.opt_line4.Text = "#4";
            this.opt_line4.UseVisualStyleBackColor = true;
            // 
            // opt_line3
            // 
            this.opt_line3.AutoSize = true;
            this.opt_line3.ForeColor = System.Drawing.Color.Red;
            this.opt_line3.Location = new System.Drawing.Point(13, 24);
            this.opt_line3.Name = "opt_line3";
            this.opt_line3.Size = new System.Drawing.Size(39, 17);
            this.opt_line3.TabIndex = 2;
            this.opt_line3.Text = "#3";
            this.opt_line3.UseVisualStyleBackColor = true;
            // 
            // opt_line2
            // 
            this.opt_line2.AutoSize = true;
            this.opt_line2.Location = new System.Drawing.Point(69, 2);
            this.opt_line2.Name = "opt_line2";
            this.opt_line2.Size = new System.Drawing.Size(39, 17);
            this.opt_line2.TabIndex = 1;
            this.opt_line2.Text = "#2";
            this.opt_line2.UseVisualStyleBackColor = true;
            // 
            // opt_line1
            // 
            this.opt_line1.AutoSize = true;
            this.opt_line1.Checked = true;
            this.opt_line1.ForeColor = System.Drawing.Color.Red;
            this.opt_line1.Location = new System.Drawing.Point(13, 2);
            this.opt_line1.Name = "opt_line1";
            this.opt_line1.Size = new System.Drawing.Size(39, 17);
            this.opt_line1.TabIndex = 0;
            this.opt_line1.TabStop = true;
            this.opt_line1.Text = "#1";
            this.opt_line1.UseVisualStyleBackColor = true;
            // 
            // txt_line
            // 
            this.txt_line.Location = new System.Drawing.Point(598, 16);
            this.txt_line.MaxLength = 1;
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(35, 22);
            this.txt_line.TabIndex = 583;
            this.txt_line.Text = "1";
            this.txt_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(522, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 582;
            this.label1.Text = "剪切线";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Location = new System.Drawing.Point(437, 16);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(42, 21);
            this.CBO_GROUP.TabIndex = 581;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Location = new System.Drawing.Point(389, 16);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(42, 21);
            this.CBO_SHIFT.TabIndex = 580;
            // 
            // ULabel40
            // 
            this.ULabel40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel40.Location = new System.Drawing.Point(302, 16);
            this.ULabel40.Name = "ULabel40";
            this.ULabel40.Size = new System.Drawing.Size(81, 22);
            this.ULabel40.TabIndex = 579;
            this.ULabel40.Text = "班次/别";
            this.ULabel40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(192, 16);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 477;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(94, 16);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FROM.TabIndex = 476;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 475;
            this.label4.Text = "生产日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(302, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "分段号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(94, 52);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(119, 22);
            this.TXT_MAT_NO.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "查询号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SEQ
            // 
            this.TXT_SEQ.Location = new System.Drawing.Point(389, 52);
            this.TXT_SEQ.MaxLength = 12;
            this.TXT_SEQ.Name = "TXT_SEQ";
            this.TXT_SEQ.Size = new System.Drawing.Size(102, 22);
            this.TXT_SEQ.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 145);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1012, 124);
            this.ss1.TabIndex = 16;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 230);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1018, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 389);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1012, 368);
            this.ss2.TabIndex = 16;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // CGC2071C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGC2071C";
            this.Text = "精整线在线查询_CGC2071C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_SEQ;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt_line2;
        private System.Windows.Forms.RadioButton opt_line1;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label ULabel40;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt_line4;
        private System.Windows.Forms.RadioButton opt_line3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Button SSP1;
        private System.Windows.Forms.Button SSP2;
        private System.Windows.Forms.Button SSP3;
        private System.Windows.Forms.Button CMD_EXCEL;
    }
}
