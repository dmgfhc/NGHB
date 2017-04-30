namespace FG
{
    partial class FGC1080C
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
            this.SSCommand2 = new System.Windows.Forms.Button();
            this.opt_htn_plt2 = new System.Windows.Forms.RadioButton();
            this.opt_htn_plt1 = new System.Windows.Forms.RadioButton();
            this.TXT_CO_CD = new System.Windows.Forms.TextBox();
            this.CHK_THK = new System.Windows.Forms.CheckBox();
            this.cbo_chg_no = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prc_line = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_HTM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SSCommand2);
            this.groupBox1.Controls.Add(this.opt_htn_plt2);
            this.groupBox1.Controls.Add(this.opt_htn_plt1);
            this.groupBox1.Controls.Add(this.TXT_CO_CD);
            this.groupBox1.Controls.Add(this.CHK_THK);
            this.groupBox1.Controls.Add(this.cbo_chg_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_prc_line);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_HTM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SSCommand2
            // 
            this.SSCommand2.Location = new System.Drawing.Point(801, 13);
            this.SSCommand2.Name = "SSCommand2";
            this.SSCommand2.Size = new System.Drawing.Size(87, 23);
            this.SSCommand2.TabIndex = 531;
            this.SSCommand2.Text = "报表导出";
            this.SSCommand2.UseVisualStyleBackColor = true;
            this.SSCommand2.Click += new System.EventHandler(this.SSCommand2_Click);
            // 
            // opt_htn_plt2
            // 
            this.opt_htn_plt2.Location = new System.Drawing.Point(926, 8);
            this.opt_htn_plt2.Name = "opt_htn_plt2";
            this.opt_htn_plt2.Size = new System.Drawing.Size(106, 28);
            this.opt_htn_plt2.TabIndex = 530;
            this.opt_htn_plt2.TabStop = true;
            this.opt_htn_plt2.Text = "二号热处理线";
            this.opt_htn_plt2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_htn_plt2.UseVisualStyleBackColor = true;
            this.opt_htn_plt2.Visible = false;
            // 
            // opt_htn_plt1
            // 
            this.opt_htn_plt1.Location = new System.Drawing.Point(816, 9);
            this.opt_htn_plt1.Name = "opt_htn_plt1";
            this.opt_htn_plt1.Size = new System.Drawing.Size(104, 28);
            this.opt_htn_plt1.TabIndex = 529;
            this.opt_htn_plt1.TabStop = true;
            this.opt_htn_plt1.Text = "一号热处理线";
            this.opt_htn_plt1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_htn_plt1.UseVisualStyleBackColor = true;
            this.opt_htn_plt1.Visible = false;
            // 
            // TXT_CO_CD
            // 
            this.TXT_CO_CD.Location = new System.Drawing.Point(457, 16);
            this.TXT_CO_CD.Name = "TXT_CO_CD";
            this.TXT_CO_CD.Size = new System.Drawing.Size(13, 22);
            this.TXT_CO_CD.TabIndex = 528;
            this.TXT_CO_CD.Text = "Y";
            this.TXT_CO_CD.Visible = false;
            // 
            // CHK_THK
            // 
            this.CHK_THK.AutoSize = true;
            this.CHK_THK.Location = new System.Drawing.Point(717, 18);
            this.CHK_THK.Name = "CHK_THK";
            this.CHK_THK.Size = new System.Drawing.Size(78, 17);
            this.CHK_THK.TabIndex = 527;
            this.CHK_THK.Text = "不分厚度";
            this.CHK_THK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CHK_THK.UseVisualStyleBackColor = true;
            this.CHK_THK.CheckedChanged += new System.EventHandler(this.CHK_THK_CheckedChanged);
            // 
            // cbo_chg_no
            // 
            this.cbo_chg_no.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_chg_no.FormattingEnabled = true;
            this.cbo_chg_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_chg_no.Location = new System.Drawing.Point(661, 13);
            this.cbo_chg_no.MaxLength = 1;
            this.cbo_chg_no.Name = "cbo_chg_no";
            this.cbo_chg_no.Size = new System.Drawing.Size(50, 22);
            this.cbo_chg_no.TabIndex = 526;
            this.cbo_chg_no.Text = "1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(573, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 525;
            this.label2.Tag = "";
            this.label2.Text = "炉座号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_prc_line
            // 
            this.txt_prc_line.Location = new System.Drawing.Point(438, 17);
            this.txt_prc_line.Name = "txt_prc_line";
            this.txt_prc_line.Size = new System.Drawing.Size(13, 22);
            this.txt_prc_line.TabIndex = 524;
            this.txt_prc_line.Text = "1";
            this.txt_prc_line.Visible = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "热处理日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(198, 13);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 510;
            // 
            // SDT_PROD_DATE_FR
            // 
            this.SDT_PROD_DATE_FR.Location = new System.Drawing.Point(97, 12);
            this.SDT_PROD_DATE_FR.Name = "SDT_PROD_DATE_FR";
            this.SDT_PROD_DATE_FR.RawDate = "";
            this.SDT_PROD_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FR.TabIndex = 509;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(358, 14);
            this.CBO_GROUP.MaxLength = 1;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(43, 22);
            this.CBO_GROUP.TabIndex = 508;
            // 
            // CBO_HTM
            // 
            this.CBO_HTM.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_HTM.FormattingEnabled = true;
            this.CBO_HTM.Items.AddRange(new object[] {
            "N 正火",
            "T 回火",
            "Q 淬火",
            "A 退火"});
            this.CBO_HTM.Location = new System.Drawing.Point(517, 12);
            this.CBO_HTM.MaxLength = 1;
            this.CBO_HTM.Name = "CBO_HTM";
            this.CBO_HTM.Size = new System.Drawing.Size(50, 22);
            this.CBO_HTM.TabIndex = 505;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(429, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "热处理方法";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(299, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1185, 574);
            this.groupBox3.TabIndex = 2;
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
            this.ss1.Size = new System.Drawing.Size(1179, 553);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGC1080C
            // 
            this.ClientSize = new System.Drawing.Size(1185, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGC1080C";
            this.Text = "热处理报表查询界面_FGC1080C";
            this.Load += new System.EventHandler(this.FGC1080C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.ComboBox CBO_HTM;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label5;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private System.Windows.Forms.TextBox txt_prc_line;
        private System.Windows.Forms.TextBox TXT_CO_CD;
        private System.Windows.Forms.CheckBox CHK_THK;
        private System.Windows.Forms.ComboBox cbo_chg_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton opt_htn_plt2;
        private System.Windows.Forms.RadioButton opt_htn_plt1;
        private System.Windows.Forms.Button SSCommand2;
    }
}
