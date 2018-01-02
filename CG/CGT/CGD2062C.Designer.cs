namespace CG
{
    partial class CGD2062C
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OPT_ALL = new System.Windows.Forms.RadioButton();
            this.OPT_OVER = new System.Windows.Forms.RadioButton();
            this.OPT_NOT_OVER = new System.Windows.Forms.RadioButton();
            this.OPT_HEAD = new System.Windows.Forms.RadioButton();
            this.OPT_TAIL = new System.Windows.Forms.RadioButton();
            this.chk_Cond_W = new System.Windows.Forms.CheckBox();
            this.chk_Cond_B = new System.Windows.Forms.CheckBox();
            this.TXT_OVER_FL = new System.Windows.Forms.TextBox();
            this.TXT_CO_CD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_CO_CD);
            this.groupBox1.Controls.Add(this.TXT_OVER_FL);
            this.groupBox1.Controls.Add(this.chk_Cond_B);
            this.groupBox1.Controls.Add(this.chk_Cond_W);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 59);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 563);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(227, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 7;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(114, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_FROM.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(37, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 5;
            this.ULabel5.Text = "探伤日期";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OPT_TAIL);
            this.panel1.Controls.Add(this.OPT_HEAD);
            this.panel1.Controls.Add(this.OPT_NOT_OVER);
            this.panel1.Controls.Add(this.OPT_OVER);
            this.panel1.Controls.Add(this.OPT_ALL);
            this.panel1.Location = new System.Drawing.Point(383, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 35);
            this.panel1.TabIndex = 9;
            // 
            // OPT_ALL
            // 
            this.OPT_ALL.AutoSize = true;
            this.OPT_ALL.Location = new System.Drawing.Point(14, 9);
            this.OPT_ALL.Name = "OPT_ALL";
            this.OPT_ALL.Size = new System.Drawing.Size(51, 17);
            this.OPT_ALL.TabIndex = 0;
            this.OPT_ALL.TabStop = true;
            this.OPT_ALL.Text = "全部";
            this.OPT_ALL.UseVisualStyleBackColor = true;
            // 
            // OPT_OVER
            // 
            this.OPT_OVER.AutoSize = true;
            this.OPT_OVER.Location = new System.Drawing.Point(71, 9);
            this.OPT_OVER.Name = "OPT_OVER";
            this.OPT_OVER.Size = new System.Drawing.Size(64, 17);
            this.OPT_OVER.TabIndex = 1;
            this.OPT_OVER.TabStop = true;
            this.OPT_OVER.Text = "异常坯";
            this.OPT_OVER.UseVisualStyleBackColor = true;
            // 
            // OPT_NOT_OVER
            // 
            this.OPT_NOT_OVER.AutoSize = true;
            this.OPT_NOT_OVER.Location = new System.Drawing.Point(141, 9);
            this.OPT_NOT_OVER.Name = "OPT_NOT_OVER";
            this.OPT_NOT_OVER.Size = new System.Drawing.Size(77, 17);
            this.OPT_NOT_OVER.TabIndex = 2;
            this.OPT_NOT_OVER.TabStop = true;
            this.OPT_NOT_OVER.Text = "非异常坯";
            this.OPT_NOT_OVER.UseVisualStyleBackColor = true;
            // 
            // OPT_HEAD
            // 
            this.OPT_HEAD.AutoSize = true;
            this.OPT_HEAD.Location = new System.Drawing.Point(224, 9);
            this.OPT_HEAD.Name = "OPT_HEAD";
            this.OPT_HEAD.Size = new System.Drawing.Size(51, 17);
            this.OPT_HEAD.TabIndex = 3;
            this.OPT_HEAD.TabStop = true;
            this.OPT_HEAD.Text = "头坯";
            this.OPT_HEAD.UseVisualStyleBackColor = true;
            // 
            // OPT_TAIL
            // 
            this.OPT_TAIL.AutoSize = true;
            this.OPT_TAIL.Location = new System.Drawing.Point(281, 9);
            this.OPT_TAIL.Name = "OPT_TAIL";
            this.OPT_TAIL.Size = new System.Drawing.Size(51, 17);
            this.OPT_TAIL.TabIndex = 4;
            this.OPT_TAIL.TabStop = true;
            this.OPT_TAIL.Text = "尾坯";
            this.OPT_TAIL.UseVisualStyleBackColor = true;
            // 
            // chk_Cond_W
            // 
            this.chk_Cond_W.AutoSize = true;
            this.chk_Cond_W.Location = new System.Drawing.Point(846, 13);
            this.chk_Cond_W.Name = "chk_Cond_W";
            this.chk_Cond_W.Size = new System.Drawing.Size(52, 17);
            this.chk_Cond_W.TabIndex = 10;
            this.chk_Cond_W.Text = "协力";
            this.chk_Cond_W.UseVisualStyleBackColor = true;
            this.chk_Cond_W.Visible = false;
            // 
            // chk_Cond_B
            // 
            this.chk_Cond_B.AutoSize = true;
            this.chk_Cond_B.Location = new System.Drawing.Point(846, 36);
            this.chk_Cond_B.Name = "chk_Cond_B";
            this.chk_Cond_B.Size = new System.Drawing.Size(52, 17);
            this.chk_Cond_B.TabIndex = 11;
            this.chk_Cond_B.Text = "板卷";
            this.chk_Cond_B.UseVisualStyleBackColor = true;
            this.chk_Cond_B.Visible = false;
            // 
            // TXT_OVER_FL
            // 
            this.TXT_OVER_FL.Location = new System.Drawing.Point(938, 13);
            this.TXT_OVER_FL.Name = "TXT_OVER_FL";
            this.TXT_OVER_FL.Size = new System.Drawing.Size(32, 22);
            this.TXT_OVER_FL.TabIndex = 12;
            this.TXT_OVER_FL.Visible = false;
            // 
            // TXT_CO_CD
            // 
            this.TXT_CO_CD.Location = new System.Drawing.Point(991, 13);
            this.TXT_CO_CD.Name = "TXT_CO_CD";
            this.TXT_CO_CD.Size = new System.Drawing.Size(32, 22);
            this.TXT_CO_CD.TabIndex = 13;
            this.TXT_CO_CD.Visible = false;
            // 
            // CGD2062C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGD2062C";
            this.Text = "探伤日报表查询_CGD2062C";
            this.Load += new System.EventHandler(this.CGT2020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox TXT_CO_CD;
        private System.Windows.Forms.TextBox TXT_OVER_FL;
        private System.Windows.Forms.CheckBox chk_Cond_B;
        private System.Windows.Forms.CheckBox chk_Cond_W;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OPT_TAIL;
        private System.Windows.Forms.RadioButton OPT_HEAD;
        private System.Windows.Forms.RadioButton OPT_NOT_OVER;
        private System.Windows.Forms.RadioButton OPT_OVER;
        private System.Windows.Forms.RadioButton OPT_ALL;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ULabel5;
    }
}
