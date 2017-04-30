namespace CG
{
    partial class WGT1010C
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
            CommonClass.BControlFiledSetting bControlFiledSetting3 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting4 = new CommonClass.BControlFiledSetting();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.TXT_CH_CD = new System.Windows.Forms.TextBox();
            this.OPT_REJECT = new System.Windows.Forms.RadioButton();
            this.OPT_DISCH = new System.Windows.Forms.RadioButton();
            this.OPT_CH = new System.Windows.Forms.RadioButton();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.CBO_PROC_LINE = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.txt_reason_name = new System.Windows.Forms.TextBox();
            this.f4ETCR1 = new CommonClass.F4ETCR();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_reason_name);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.f4ETCR1);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.TXT_CH_CD);
            this.groupBox1.Controls.Add(this.OPT_REJECT);
            this.groupBox1.Controls.Add(this.OPT_DISCH);
            this.groupBox1.Controls.Add(this.OPT_CH);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.CBO_PROC_LINE);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(220, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 4;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(107, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_FROM.TabIndex = 4;
            // 
            // TXT_CH_CD
            // 
            this.TXT_CH_CD.Location = new System.Drawing.Point(989, 19);
            this.TXT_CH_CD.Name = "TXT_CH_CD";
            this.TXT_CH_CD.Size = new System.Drawing.Size(18, 22);
            this.TXT_CH_CD.TabIndex = 2;
            this.TXT_CH_CD.Visible = false;
            // 
            // OPT_REJECT
            // 
            this.OPT_REJECT.Location = new System.Drawing.Point(932, 18);
            this.OPT_REJECT.Name = "OPT_REJECT";
            this.OPT_REJECT.Size = new System.Drawing.Size(51, 23);
            this.OPT_REJECT.TabIndex = 1;
            this.OPT_REJECT.Text = "回炉";
            this.OPT_REJECT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_REJECT.UseVisualStyleBackColor = true;
            this.OPT_REJECT.Click += new System.EventHandler(this.OPT_REJECT_Click);
            // 
            // OPT_DISCH
            // 
            this.OPT_DISCH.Location = new System.Drawing.Point(870, 18);
            this.OPT_DISCH.Name = "OPT_DISCH";
            this.OPT_DISCH.Size = new System.Drawing.Size(51, 23);
            this.OPT_DISCH.TabIndex = 1;
            this.OPT_DISCH.Text = "出炉";
            this.OPT_DISCH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_DISCH.UseVisualStyleBackColor = true;
            this.OPT_DISCH.Click += new System.EventHandler(this.OPT_DISCH_Click);
            // 
            // OPT_CH
            // 
            this.OPT_CH.Location = new System.Drawing.Point(808, 18);
            this.OPT_CH.Name = "OPT_CH";
            this.OPT_CH.Size = new System.Drawing.Size(51, 23);
            this.OPT_CH.TabIndex = 1;
            this.OPT_CH.Text = "装炉";
            this.OPT_CH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_CH.UseVisualStyleBackColor = true;
            this.OPT_CH.Click += new System.EventHandler(this.OPT_CH_Click);
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(571, 20);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(106, 22);
            this.TXT_SLAB_NO.TabIndex = 3;
            // 
            // CBO_PROC_LINE
            // 
            this.CBO_PROC_LINE.FormattingEnabled = true;
            this.CBO_PROC_LINE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBO_PROC_LINE.Location = new System.Drawing.Point(746, 20);
            this.CBO_PROC_LINE.Name = "CBO_PROC_LINE";
            this.CBO_PROC_LINE.Size = new System.Drawing.Size(37, 21);
            this.CBO_PROC_LINE.TabIndex = 2;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(430, 20);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(64, 21);
            this.CBO_SHIFT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(501, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "板坯号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(689, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "炉座号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(373, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 91);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1009, 531);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // txt_reason_name
            // 
            this.txt_reason_name.Location = new System.Drawing.Point(153, 53);
            this.txt_reason_name.Name = "txt_reason_name";
            this.txt_reason_name.Size = new System.Drawing.Size(101, 22);
            this.txt_reason_name.TabIndex = 15;
            // 
            // f4ETCR1
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.f4ETCR1;
            bControlFiledSetting4.ColumnID = "CD_NAME";
            bControlFiledSetting4.TargetControl = this.txt_reason_name;
            this.f4ETCR1.CustomSetting.Add(bControlFiledSetting3);
            this.f4ETCR1.CustomSetting.Add(bControlFiledSetting4);
            this.f4ETCR1.InputControl = this.f4ETCR1;
            this.f4ETCR1.Location = new System.Drawing.Point(112, 53);
            this.f4ETCR1.Name = "f4ETCR1";
            this.f4ETCR1.Size = new System.Drawing.Size(39, 22);
            this.f4ETCR1.sJoin = "";
            this.f4ETCR1.sSqletc = "select T.CD,T.CD_NAME from ZP_CD t WHERE T.CD_MANA_NO=\'G0001\'";
            this.f4ETCR1.TabIndex = 14;
            this.f4ETCR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(30, 53);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 22);
            this.label32.TabIndex = 13;
            this.label32.Tag = "F4";
            this.label32.Text = "回炉原因";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WGT1010C
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT1010C";
            this.Text = "加热炉实绩查询_WGT1010C";
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
        private System.Windows.Forms.RadioButton OPT_REJECT;
        private System.Windows.Forms.RadioButton OPT_DISCH;
        private System.Windows.Forms.RadioButton OPT_CH;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.ComboBox CBO_PROC_LINE;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox TXT_CH_CD;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.TextBox txt_reason_name;
        private CommonClass.F4ETCR f4ETCR1;
        private System.Windows.Forms.Label label32;
    }
}
