namespace CG
{
    partial class CGG2040C
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
            this.tab_bed_cd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_DATE = new CommonClass.CeriUDate();
            this.SCmd2 = new System.Windows.Forms.Button();
            this.udToDate = new CommonClass.CeriUDate();
            this.udFmDate = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ss3 = new FarPoint.Win.Spread.FpSpread();
            this.ss3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SSP4 = new System.Windows.Forms.Button();
            this.SSP3 = new System.Windows.Forms.Button();
            this.SSP1 = new System.Windows.Forms.Button();
            this.SCmd3 = new System.Windows.Forms.Button();
            this.CBO_CUTYN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udToDate2 = new CommonClass.CeriUDate();
            this.udFmDate2 = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_bed_cd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_bed_cd
            // 
            this.tab_bed_cd.Controls.Add(this.tabPage1);
            this.tab_bed_cd.Controls.Add(this.tabPage2);
            this.tab_bed_cd.Controls.Add(this.tabPage3);
            this.tab_bed_cd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_bed_cd.ItemSize = new System.Drawing.Size(400, 18);
            this.tab_bed_cd.Location = new System.Drawing.Point(0, 0);
            this.tab_bed_cd.Name = "tab_bed_cd";
            this.tab_bed_cd.SelectedIndex = 0;
            this.tab_bed_cd.Size = new System.Drawing.Size(1281, 622);
            this.tab_bed_cd.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_bed_cd.TabIndex = 483;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1273, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "轧钢作业计划";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 53);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1267, 540);
            this.ss1.TabIndex = 1;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmd_Edit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Cmd_Edit
            // 
            this.Cmd_Edit.Location = new System.Drawing.Point(488, 17);
            this.Cmd_Edit.Name = "Cmd_Edit";
            this.Cmd_Edit.Size = new System.Drawing.Size(104, 23);
            this.Cmd_Edit.TabIndex = 584;
            this.Cmd_Edit.Text = "更新数据";
            this.Cmd_Edit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(34, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 582;
            this.label7.Text = "起始板坯号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(124, 18);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(117, 22);
            this.TXT_SLAB_NO.TabIndex = 583;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1273, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "轧钢大计划";
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 53);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1267, 540);
            this.ss2.TabIndex = 2;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXT_DATE);
            this.groupBox2.Controls.Add(this.SCmd2);
            this.groupBox2.Controls.Add(this.udToDate);
            this.groupBox2.Controls.Add(this.udFmDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1267, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(758, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 589;
            this.label1.Text = "计划工作日";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.Font = new System.Drawing.Font("宋体", 9.75F);
            this.TXT_DATE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXT_DATE.Location = new System.Drawing.Point(857, 18);
            this.TXT_DATE.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.RawDate = "";
            this.TXT_DATE.Size = new System.Drawing.Size(94, 21);
            this.TXT_DATE.TabIndex = 588;
            this.TXT_DATE.Tag = "结束时间";
            // 
            // SCmd2
            // 
            this.SCmd2.Location = new System.Drawing.Point(547, 18);
            this.SCmd2.Name = "SCmd2";
            this.SCmd2.Size = new System.Drawing.Size(104, 23);
            this.SCmd2.TabIndex = 587;
            this.SCmd2.Text = "上传计划";
            this.SCmd2.UseVisualStyleBackColor = true;
            // 
            // udToDate
            // 
            this.udToDate.Font = new System.Drawing.Font("宋体", 9.75F);
            this.udToDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.udToDate.Location = new System.Drawing.Point(232, 18);
            this.udToDate.Margin = new System.Windows.Forms.Padding(4);
            this.udToDate.Name = "udToDate";
            this.udToDate.RawDate = "";
            this.udToDate.Size = new System.Drawing.Size(94, 21);
            this.udToDate.TabIndex = 586;
            this.udToDate.Tag = "结束时间";
            // 
            // udFmDate
            // 
            this.udFmDate.Font = new System.Drawing.Font("宋体", 9.75F);
            this.udFmDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.udFmDate.Location = new System.Drawing.Point(129, 18);
            this.udFmDate.Margin = new System.Windows.Forms.Padding(4);
            this.udFmDate.Name = "udFmDate";
            this.udFmDate.RawDate = "";
            this.udFmDate.Size = new System.Drawing.Size(95, 21);
            this.udFmDate.TabIndex = 585;
            this.udFmDate.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(37, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 584;
            this.label4.Text = "查询日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ss3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1273, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "余坯切割计划";
            // 
            // ss3
            // 
            this.ss3.AccessibleDescription = "";
            this.ss3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss3.Location = new System.Drawing.Point(0, 50);
            this.ss3.Name = "ss3";
            this.ss3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss3_Sheet1});
            this.ss3.Size = new System.Drawing.Size(1273, 546);
            this.ss3.TabIndex = 3;
            // 
            // ss3_Sheet1
            // 
            this.ss3_Sheet1.Reset();
            this.ss3_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SSP4);
            this.groupBox3.Controls.Add(this.SSP3);
            this.groupBox3.Controls.Add(this.SSP1);
            this.groupBox3.Controls.Add(this.SCmd3);
            this.groupBox3.Controls.Add(this.CBO_CUTYN);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.udToDate2);
            this.groupBox3.Controls.Add(this.udFmDate2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1273, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.Yellow;
            this.SSP4.Location = new System.Drawing.Point(1042, 18);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(85, 23);
            this.SSP4.TabIndex = 595;
            this.SSP4.Text = "可修改项";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // SSP3
            // 
            this.SSP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SSP3.Location = new System.Drawing.Point(951, 18);
            this.SSP3.Name = "SSP3";
            this.SSP3.Size = new System.Drawing.Size(85, 23);
            this.SSP3.TabIndex = 594;
            this.SSP3.Text = "切割计划";
            this.SSP3.UseVisualStyleBackColor = false;
            // 
            // SSP1
            // 
            this.SSP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SSP1.Location = new System.Drawing.Point(860, 18);
            this.SSP1.Name = "SSP1";
            this.SSP1.Size = new System.Drawing.Size(85, 23);
            this.SSP1.TabIndex = 593;
            this.SSP1.Text = "待切割";
            this.SSP1.UseVisualStyleBackColor = false;
            // 
            // SCmd3
            // 
            this.SCmd3.Location = new System.Drawing.Point(671, 18);
            this.SCmd3.Name = "SCmd3";
            this.SCmd3.Size = new System.Drawing.Size(104, 23);
            this.SCmd3.TabIndex = 592;
            this.SCmd3.Text = "上传计划";
            this.SCmd3.UseVisualStyleBackColor = true;
            // 
            // CBO_CUTYN
            // 
            this.CBO_CUTYN.FormattingEnabled = true;
            this.CBO_CUTYN.Items.AddRange(new object[] {
            "",
            "Y",
            "N"});
            this.CBO_CUTYN.Location = new System.Drawing.Point(498, 18);
            this.CBO_CUTYN.Name = "CBO_CUTYN";
            this.CBO_CUTYN.Size = new System.Drawing.Size(44, 21);
            this.CBO_CUTYN.TabIndex = 591;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(395, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 590;
            this.label3.Text = "是否切割完成";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udToDate2
            // 
            this.udToDate2.Font = new System.Drawing.Font("宋体", 9.75F);
            this.udToDate2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.udToDate2.Location = new System.Drawing.Point(230, 18);
            this.udToDate2.Margin = new System.Windows.Forms.Padding(4);
            this.udToDate2.Name = "udToDate2";
            this.udToDate2.RawDate = "";
            this.udToDate2.Size = new System.Drawing.Size(94, 21);
            this.udToDate2.TabIndex = 589;
            this.udToDate2.Tag = "结束时间";
            // 
            // udFmDate2
            // 
            this.udFmDate2.Font = new System.Drawing.Font("宋体", 9.75F);
            this.udFmDate2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.udFmDate2.Location = new System.Drawing.Point(127, 18);
            this.udFmDate2.Margin = new System.Windows.Forms.Padding(4);
            this.udFmDate2.Name = "udFmDate2";
            this.udFmDate2.RawDate = "";
            this.udFmDate2.Size = new System.Drawing.Size(95, 21);
            this.udFmDate2.TabIndex = 588;
            this.udFmDate2.Tag = "开始时间";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 587;
            this.label2.Text = "查询日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CGG2040C
            // 
            this.ClientSize = new System.Drawing.Size(1281, 622);
            this.Controls.Add(this.tab_bed_cd);
            this.Name = "CGG2040C";
            this.Text = "轧钢计划查询界面_CGG2040C";
            this.Load += new System.EventHandler(this.CGG2040C_Load);
            this.tab_bed_cd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_bed_cd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss3;
        private FarPoint.Win.Spread.SheetView ss3_Sheet1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.Button Cmd_Edit;
        private System.Windows.Forms.Label label1;
        public CommonClass.CeriUDate TXT_DATE;
        private System.Windows.Forms.Button SCmd2;
        public CommonClass.CeriUDate udToDate;
        public CommonClass.CeriUDate udFmDate;
        private System.Windows.Forms.Label label4;
        public CommonClass.CeriUDate udToDate2;
        public CommonClass.CeriUDate udFmDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SSP4;
        private System.Windows.Forms.Button SSP3;
        private System.Windows.Forms.Button SSP1;
        private System.Windows.Forms.Button SCmd3;
        private System.Windows.Forms.ComboBox CBO_CUTYN;
        private System.Windows.Forms.Label label3;
    }
}
