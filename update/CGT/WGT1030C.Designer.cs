namespace CG
{
    partial class WGT1030C
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
            this.SDT_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_DATE_FROM = new CommonClass.CeriUDate();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.CBO_JIAOZHI = new System.Windows.Forms.ComboBox();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.opt_PLR = new System.Windows.Forms.RadioButton();
            this.opt_HLR = new System.Windows.Forms.RadioButton();
            this.TXT_SP_CD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SP_CD);
            this.groupBox1.Controls.Add(this.opt_PLR);
            this.groupBox1.Controls.Add(this.opt_HLR);
            this.groupBox1.Controls.Add(this.SDT_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_DATE_FROM);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.CBO_JIAOZHI);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDT_DATE_TO
            // 
            this.SDT_DATE_TO.Location = new System.Drawing.Point(244, 23);
            this.SDT_DATE_TO.Name = "SDT_DATE_TO";
            this.SDT_DATE_TO.RawDate = "";
            this.SDT_DATE_TO.Size = new System.Drawing.Size(102, 21);
            this.SDT_DATE_TO.TabIndex = 6;
            // 
            // SDT_DATE_FROM
            // 
            this.SDT_DATE_FROM.Location = new System.Drawing.Point(129, 23);
            this.SDT_DATE_FROM.Name = "SDT_DATE_FROM";
            this.SDT_DATE_FROM.RawDate = "";
            this.SDT_DATE_FROM.Size = new System.Drawing.Size(100, 21);
            this.SDT_DATE_FROM.TabIndex = 6;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(129, 58);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(103, 22);
            this.TXT_SLAB_NO.TabIndex = 5;
            // 
            // CBO_JIAOZHI
            // 
            this.CBO_JIAOZHI.FormattingEnabled = true;
            this.CBO_JIAOZHI.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CBO_JIAOZHI.Location = new System.Drawing.Point(748, 22);
            this.CBO_JIAOZHI.Name = "CBO_JIAOZHI";
            this.CBO_JIAOZHI.Size = new System.Drawing.Size(47, 21);
            this.CBO_JIAOZHI.TabIndex = 3;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(589, 23);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(54, 21);
            this.CBO_GROUP.TabIndex = 3;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(454, 23);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(54, 21);
            this.CBO_SHIFT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(529, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "班别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(679, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "矫直机号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(42, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "板坯号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(394, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 88);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 534);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // opt_PLR
            // 
            this.opt_PLR.Location = new System.Drawing.Point(866, 50);
            this.opt_PLR.Name = "opt_PLR";
            this.opt_PLR.Size = new System.Drawing.Size(74, 28);
            this.opt_PLR.TabIndex = 10;
            this.opt_PLR.TabStop = true;
            this.opt_PLR.Text = "预矫直";
            this.opt_PLR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt_PLR.UseVisualStyleBackColor = true;
            this.opt_PLR.Click += new System.EventHandler(this.opt_PLR_Click);
            // 
            // opt_HLR
            // 
            this.opt_HLR.Location = new System.Drawing.Point(793, 50);
            this.opt_HLR.Name = "opt_HLR";
            this.opt_HLR.Size = new System.Drawing.Size(67, 28);
            this.opt_HLR.TabIndex = 9;
            this.opt_HLR.TabStop = true;
            this.opt_HLR.Text = "温矫直";
            this.opt_HLR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt_HLR.UseVisualStyleBackColor = true;
            this.opt_HLR.Click += new System.EventHandler(this.opt_HLR_Click);
            // 
            // TXT_SP_CD
            // 
            this.TXT_SP_CD.Location = new System.Drawing.Point(834, 24);
            this.TXT_SP_CD.Name = "TXT_SP_CD";
            this.TXT_SP_CD.Size = new System.Drawing.Size(11, 22);
            this.TXT_SP_CD.TabIndex = 11;
            this.TXT_SP_CD.Visible = false;
            // 
            // WGT1030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT1030C";
            this.Text = "矫直实绩查询_WGT1030C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.CeriUDate SDT_DATE_TO;
        private CommonClass.CeriUDate SDT_DATE_FROM;
        private System.Windows.Forms.ComboBox CBO_JIAOZHI;
        private System.Windows.Forms.RadioButton opt_PLR;
        private System.Windows.Forms.RadioButton opt_HLR;
        private System.Windows.Forms.TextBox TXT_SP_CD;

    }
}
