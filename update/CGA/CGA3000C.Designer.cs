namespace CG
{
    partial class CGA3000C
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
            this.TXT_FLAG = new System.Windows.Forms.TextBox();
            this.OPT_SCRAP = new System.Windows.Forms.RadioButton();
            this.OPT_SCRAP_WAIT = new System.Windows.Forms.RadioButton();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CUT_TS2 = new CommonClass.CeriUDate();
            this.txt_CUT_TS = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OCCR_TS2 = new CommonClass.CeriUDate();
            this.txt_OCCR_TS = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_slab_no = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_FLAG);
            this.groupBox1.Controls.Add(this.OPT_SCRAP);
            this.groupBox1.Controls.Add(this.OPT_SCRAP_WAIT);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CUT_TS2);
            this.groupBox1.Controls.Add(this.txt_CUT_TS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_OCCR_TS2);
            this.groupBox1.Controls.Add(this.txt_OCCR_TS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_slab_no);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_FLAG
            // 
            this.TXT_FLAG.Location = new System.Drawing.Point(590, 18);
            this.TXT_FLAG.Name = "TXT_FLAG";
            this.TXT_FLAG.Size = new System.Drawing.Size(42, 22);
            this.TXT_FLAG.TabIndex = 605;
            this.TXT_FLAG.Visible = false;
            // 
            // OPT_SCRAP
            // 
            this.OPT_SCRAP.AutoSize = true;
            this.OPT_SCRAP.Location = new System.Drawing.Point(1047, 20);
            this.OPT_SCRAP.Name = "OPT_SCRAP";
            this.OPT_SCRAP.Size = new System.Drawing.Size(77, 17);
            this.OPT_SCRAP.TabIndex = 604;
            this.OPT_SCRAP.Text = "检验实绩";
            this.OPT_SCRAP.UseVisualStyleBackColor = true;
            // 
            // OPT_SCRAP_WAIT
            // 
            this.OPT_SCRAP_WAIT.AutoSize = true;
            this.OPT_SCRAP_WAIT.Checked = true;
            this.OPT_SCRAP_WAIT.Location = new System.Drawing.Point(977, 20);
            this.OPT_SCRAP_WAIT.Name = "OPT_SCRAP_WAIT";
            this.OPT_SCRAP_WAIT.Size = new System.Drawing.Size(51, 17);
            this.OPT_SCRAP_WAIT.TabIndex = 603;
            this.OPT_SCRAP_WAIT.TabStop = true;
            this.OPT_SCRAP_WAIT.Text = "检验";
            this.OPT_SCRAP_WAIT.UseVisualStyleBackColor = true;
            this.OPT_SCRAP_WAIT.CheckedChanged += new System.EventHandler(this.OPT_SCRAP_WAIT_CheckedChanged);
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(920, 18);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(51, 21);
            this.CBO_SHIFT.TabIndex = 602;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(851, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 599;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CUT_TS2
            // 
            this.txt_CUT_TS2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_CUT_TS2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CUT_TS2.Location = new System.Drawing.Point(732, 18);
            this.txt_CUT_TS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CUT_TS2.Name = "txt_CUT_TS2";
            this.txt_CUT_TS2.RawDate = "";
            this.txt_CUT_TS2.Size = new System.Drawing.Size(112, 24);
            this.txt_CUT_TS2.TabIndex = 598;
            this.txt_CUT_TS2.Tag = "结束时间";
            // 
            // txt_CUT_TS
            // 
            this.txt_CUT_TS.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_CUT_TS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CUT_TS.Location = new System.Drawing.Point(618, 18);
            this.txt_CUT_TS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CUT_TS.Name = "txt_CUT_TS";
            this.txt_CUT_TS.RawDate = "";
            this.txt_CUT_TS.Size = new System.Drawing.Size(108, 24);
            this.txt_CUT_TS.TabIndex = 597;
            this.txt_CUT_TS.Tag = "开始时间";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(526, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 596;
            this.label1.Text = "轧制时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OCCR_TS2
            // 
            this.txt_OCCR_TS2.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_OCCR_TS2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_OCCR_TS2.Location = new System.Drawing.Point(407, 18);
            this.txt_OCCR_TS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OCCR_TS2.Name = "txt_OCCR_TS2";
            this.txt_OCCR_TS2.RawDate = "";
            this.txt_OCCR_TS2.Size = new System.Drawing.Size(112, 24);
            this.txt_OCCR_TS2.TabIndex = 595;
            this.txt_OCCR_TS2.Tag = "结束时间";
            // 
            // txt_OCCR_TS
            // 
            this.txt_OCCR_TS.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_OCCR_TS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_OCCR_TS.Location = new System.Drawing.Point(293, 18);
            this.txt_OCCR_TS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OCCR_TS.Name = "txt_OCCR_TS";
            this.txt_OCCR_TS.RawDate = "";
            this.txt_OCCR_TS.Size = new System.Drawing.Size(108, 24);
            this.txt_OCCR_TS.TabIndex = 594;
            this.txt_OCCR_TS.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 593;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 592;
            this.label2.Tag = "f4";
            this.label2.Text = "板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_slab_no
            // 
            this.txt_slab_no.Location = new System.Drawing.Point(93, 18);
            this.txt_slab_no.MaxLength = 10;
            this.txt_slab_no.Name = "txt_slab_no";
            this.txt_slab_no.Size = new System.Drawing.Size(102, 22);
            this.txt_slab_no.TabIndex = 591;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 58);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1222, 564);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA3000C
            // 
            this.ClientSize = new System.Drawing.Size(1222, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA3000C";
            this.Text = "板坯检验录入界面_CGA3000C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label3;
        public CommonClass.CeriUDate txt_CUT_TS2;
        public CommonClass.CeriUDate txt_CUT_TS;
        private System.Windows.Forms.Label label1;
        public CommonClass.CeriUDate txt_OCCR_TS2;
        public CommonClass.CeriUDate txt_OCCR_TS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_slab_no;
        private System.Windows.Forms.RadioButton OPT_SCRAP;
        private System.Windows.Forms.RadioButton OPT_SCRAP_WAIT;
        private System.Windows.Forms.TextBox TXT_FLAG;
    }
}
