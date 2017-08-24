namespace CG
{
    partial class CKG2030C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OPT_EP_SLAB_DES = new System.Windows.Forms.RadioButton();
            this.OPT_FP_SLAB_DES1 = new System.Windows.Forms.RadioButton();
            this.OPT_FP_SLAB_DES = new System.Windows.Forms.RadioButton();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label5 = new System.Windows.Forms.Label();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SSP3 = new System.Windows.Forms.Label();
            this.SSP2 = new System.Windows.Forms.Label();
            this.SSP1 = new System.Windows.Forms.Label();
            this.chk_detail = new System.Windows.Forms.CheckBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OPT_EP_SLAB_DES);
            this.panel1.Controls.Add(this.OPT_FP_SLAB_DES1);
            this.panel1.Controls.Add(this.OPT_FP_SLAB_DES);
            this.panel1.Location = new System.Drawing.Point(719, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 31);
            this.panel1.TabIndex = 733;
            // 
            // OPT_EP_SLAB_DES
            // 
            this.OPT_EP_SLAB_DES.AutoSize = true;
            this.OPT_EP_SLAB_DES.Location = new System.Drawing.Point(196, 8);
            this.OPT_EP_SLAB_DES.Name = "OPT_EP_SLAB_DES";
            this.OPT_EP_SLAB_DES.Size = new System.Drawing.Size(77, 17);
            this.OPT_EP_SLAB_DES.TabIndex = 2;
            this.OPT_EP_SLAB_DES.TabStop = true;
            this.OPT_EP_SLAB_DES.Text = "炼钢计划";
            this.OPT_EP_SLAB_DES.UseVisualStyleBackColor = true;
            // 
            // OPT_FP_SLAB_DES1
            // 
            this.OPT_FP_SLAB_DES1.AutoSize = true;
            this.OPT_FP_SLAB_DES1.Location = new System.Drawing.Point(110, 8);
            this.OPT_FP_SLAB_DES1.Name = "OPT_FP_SLAB_DES1";
            this.OPT_FP_SLAB_DES1.Size = new System.Drawing.Size(64, 17);
            this.OPT_FP_SLAB_DES1.TabIndex = 1;
            this.OPT_FP_SLAB_DES1.TabStop = true;
            this.OPT_FP_SLAB_DES1.Text = "订单材";
            this.OPT_FP_SLAB_DES1.UseVisualStyleBackColor = true;
            // 
            // OPT_FP_SLAB_DES
            // 
            this.OPT_FP_SLAB_DES.AutoSize = true;
            this.OPT_FP_SLAB_DES.Location = new System.Drawing.Point(17, 8);
            this.OPT_FP_SLAB_DES.Name = "OPT_FP_SLAB_DES";
            this.OPT_FP_SLAB_DES.Size = new System.Drawing.Size(77, 17);
            this.OPT_FP_SLAB_DES.TabIndex = 0;
            this.OPT_FP_SLAB_DES.TabStop = true;
            this.OPT_FP_SLAB_DES.Text = "轧制实绩";
            this.OPT_FP_SLAB_DES.UseVisualStyleBackColor = true;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(561, 17);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(89, 22);
            this.TXT_SLAB_NO.TabIndex = 732;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(480, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 731;
            this.label2.Text = "板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Font = new System.Drawing.Font("宋体", 9.75F);
            this.SDT_PROD_DATE_TO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(221, 17);
            this.SDT_PROD_DATE_TO.Margin = new System.Windows.Forms.Padding(4);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(94, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 730;
            this.SDT_PROD_DATE_TO.Tag = "结束时间";
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Font = new System.Drawing.Font("宋体", 9.75F);
            this.SDT_PROD_DATE_FROM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(118, 17);
            this.SDT_PROD_DATE_FROM.Margin = new System.Windows.Forms.Padding(4);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 21);
            this.SDT_PROD_DATE_FROM.TabIndex = 729;
            this.SDT_PROD_DATE_FROM.Tag = "开始时间";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(26, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 728;
            this.label5.Text = "轧制时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(406, 17);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(49, 21);
            this.CBO_SHIFT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(340, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1243, 184);
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
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1237, 163);
            this.ss1.TabIndex = 2;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 241);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1243, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SSP3);
            this.groupBox2.Controls.Add(this.SSP2);
            this.groupBox2.Controls.Add(this.SSP1);
            this.groupBox2.Controls.Add(this.chk_detail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1243, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // SSP3
            // 
            this.SSP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SSP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSP3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP3.ForeColor = System.Drawing.Color.Blue;
            this.SSP3.Location = new System.Drawing.Point(786, 16);
            this.SSP3.Name = "SSP3";
            this.SSP3.Size = new System.Drawing.Size(104, 22);
            this.SSP3.TabIndex = 6;
            this.SSP3.Tag = "USER";
            this.SSP3.Text = "钢板";
            this.SSP3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SSP2
            // 
            this.SSP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SSP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSP2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP2.ForeColor = System.Drawing.Color.Blue;
            this.SSP2.Location = new System.Drawing.Point(682, 16);
            this.SSP2.Name = "SSP2";
            this.SSP2.Size = new System.Drawing.Size(104, 22);
            this.SSP2.TabIndex = 5;
            this.SSP2.Tag = "USER";
            this.SSP2.Text = "母板";
            this.SSP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SSP1
            // 
            this.SSP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SSP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSP1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP1.ForeColor = System.Drawing.Color.Blue;
            this.SSP1.Location = new System.Drawing.Point(578, 16);
            this.SSP1.Name = "SSP1";
            this.SSP1.Size = new System.Drawing.Size(104, 22);
            this.SSP1.TabIndex = 4;
            this.SSP1.Tag = "USER";
            this.SSP1.Text = "轧件";
            this.SSP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chk_detail
            // 
            this.chk_detail.AutoSize = true;
            this.chk_detail.Location = new System.Drawing.Point(38, 21);
            this.chk_detail.Name = "chk_detail";
            this.chk_detail.Size = new System.Drawing.Size(78, 17);
            this.chk_detail.TabIndex = 0;
            this.chk_detail.Text = "明细导出";
            this.chk_detail.UseVisualStyleBackColor = true;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(0, 290);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1243, 3);
            this.splitter4.TabIndex = 8;
            this.splitter4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ss2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1243, 283);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1237, 262);
            this.ss2.TabIndex = 3;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // CKG2030C
            // 
            this.ClientSize = new System.Drawing.Size(1243, 576);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CKG2030C";
            this.Text = "精整作业指示查询界面_CKG2030C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        public CommonClass.CeriUDate SDT_PROD_DATE_TO;
        public CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OPT_EP_SLAB_DES;
        private System.Windows.Forms.RadioButton OPT_FP_SLAB_DES1;
        private System.Windows.Forms.RadioButton OPT_FP_SLAB_DES;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_detail;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.GroupBox groupBox5;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Label SSP3;
        private System.Windows.Forms.Label SSP2;
        private System.Windows.Forms.Label SSP1;
    }
}
