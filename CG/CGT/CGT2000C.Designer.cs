namespace CG
{
    partial class CGT2000C
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
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            this.txt_stlgrd = new CommonClass.F4ETCR();
            this.txt_STLGRD_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SDB_WGT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OPT_CH = new System.Windows.Forms.RadioButton();
            this.OPT_DISCH = new System.Windows.Forms.RadioButton();
            this.OPT_REJECT = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SSP4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SSPpdt = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.TXT_CH_CD = new System.Windows.Forms.TextBox();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.CBO_PRC_LINE = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stlgrd
            // 
            bControlFiledSetting1.ColumnID = "STLGRD";
            bControlFiledSetting1.TargetControl = this.txt_stlgrd;
            bControlFiledSetting2.ColumnID = "STEEL_GRD_DETAIL";
            bControlFiledSetting2.TargetControl = this.txt_STLGRD_Name;
            this.txt_stlgrd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_stlgrd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_stlgrd.InputControl = this.txt_stlgrd;
            this.txt_stlgrd.Location = new System.Drawing.Point(445, 52);
            this.txt_stlgrd.MaxLength = 12;
            this.txt_stlgrd.Name = "txt_stlgrd";
            this.txt_stlgrd.Size = new System.Drawing.Size(96, 22);
            this.txt_stlgrd.sJoin = "";
            this.txt_stlgrd.sSqletc = "SELECT STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM  NISCO.QP_NISCO_CHMC  WHERE STLG" +
    "RD like \'%\'  AND NVL(STEEL_GRD_DETAIL,\'%\')   like \'%\'  ORDER  BY  STLGRD  ASC";
            this.txt_stlgrd.TabIndex = 133;
            // 
            // txt_STLGRD_Name
            // 
            this.txt_STLGRD_Name.Location = new System.Drawing.Point(547, 52);
            this.txt_STLGRD_Name.MaxLength = 50;
            this.txt_STLGRD_Name.Name = "txt_STLGRD_Name";
            this.txt_STLGRD_Name.Size = new System.Drawing.Size(139, 22);
            this.txt_STLGRD_Name.TabIndex = 132;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDB_WGT);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_stlgrd);
            this.groupBox1.Controls.Add(this.txt_STLGRD_Name);
            this.groupBox1.Controls.Add(this.SSPpdt);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.TXT_CH_CD);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.CBO_PRC_LINE);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDB_WGT
            // 
            this.SDB_WGT.Location = new System.Drawing.Point(869, 57);
            this.SDB_WGT.MaxLength = 10;
            this.SDB_WGT.Name = "SDB_WGT";
            this.SDB_WGT.Size = new System.Drawing.Size(63, 22);
            this.SDB_WGT.TabIndex = 140;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OPT_CH);
            this.panel1.Controls.Add(this.OPT_DISCH);
            this.panel1.Controls.Add(this.OPT_REJECT);
            this.panel1.Location = new System.Drawing.Point(806, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 34);
            this.panel1.TabIndex = 139;
            // 
            // OPT_CH
            // 
            this.OPT_CH.Checked = true;
            this.OPT_CH.ForeColor = System.Drawing.Color.Red;
            this.OPT_CH.Location = new System.Drawing.Point(6, 5);
            this.OPT_CH.Name = "OPT_CH";
            this.OPT_CH.Size = new System.Drawing.Size(51, 23);
            this.OPT_CH.TabIndex = 1;
            this.OPT_CH.TabStop = true;
            this.OPT_CH.Text = "装炉";
            this.OPT_CH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_CH.UseVisualStyleBackColor = true;
            this.OPT_CH.CheckedChanged += new System.EventHandler(this.OPT_CH_CheckedChanged);
            // 
            // OPT_DISCH
            // 
            this.OPT_DISCH.Location = new System.Drawing.Point(63, 5);
            this.OPT_DISCH.Name = "OPT_DISCH";
            this.OPT_DISCH.Size = new System.Drawing.Size(51, 23);
            this.OPT_DISCH.TabIndex = 1;
            this.OPT_DISCH.Text = "出炉";
            this.OPT_DISCH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_DISCH.UseVisualStyleBackColor = true;
            this.OPT_DISCH.CheckedChanged += new System.EventHandler(this.OPT_DISCH_CheckedChanged);
            // 
            // OPT_REJECT
            // 
            this.OPT_REJECT.Location = new System.Drawing.Point(116, 5);
            this.OPT_REJECT.Name = "OPT_REJECT";
            this.OPT_REJECT.Size = new System.Drawing.Size(51, 23);
            this.OPT_REJECT.TabIndex = 1;
            this.OPT_REJECT.Text = "回炉";
            this.OPT_REJECT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_REJECT.UseVisualStyleBackColor = true;
            this.OPT_REJECT.CheckedChanged += new System.EventHandler(this.OPT_REJECT_CheckedChanged);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(938, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 138;
            this.label11.Text = "吨";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(822, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 136;
            this.label9.Text = "重量";
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SSP4.Location = new System.Drawing.Point(692, 52);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(91, 22);
            this.SSP4.TabIndex = 135;
            this.SSP4.Text = "重点订单";
            this.SSP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(338, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 134;
            this.label7.Text = "原始坯料钢种";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSPpdt
            // 
            this.SSPpdt.BackColor = System.Drawing.Color.Fuchsia;
            this.SSPpdt.Location = new System.Drawing.Point(226, 52);
            this.SSPpdt.Name = "SSPpdt";
            this.SSPpdt.Size = new System.Drawing.Size(91, 22);
            this.SSPpdt.TabIndex = 6;
            this.SSPpdt.Text = "子公司订单";
            this.SSPpdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(476, 18);
            this.CBO_GROUP.MaxLength = 32767;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(46, 21);
            this.CBO_GROUP.TabIndex = 5;
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
            this.TXT_CH_CD.Location = new System.Drawing.Point(989, 18);
            this.TXT_CH_CD.Name = "TXT_CH_CD";
            this.TXT_CH_CD.Size = new System.Drawing.Size(18, 22);
            this.TXT_CH_CD.TabIndex = 2;
            this.TXT_CH_CD.Text = "C";
            this.TXT_CH_CD.Visible = false;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(107, 52);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_SLAB_NO.TabIndex = 3;
            // 
            // CBO_PRC_LINE
            // 
            this.CBO_PRC_LINE.FormattingEnabled = true;
            this.CBO_PRC_LINE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBO_PRC_LINE.Location = new System.Drawing.Point(611, 18);
            this.CBO_PRC_LINE.Name = "CBO_PRC_LINE";
            this.CBO_PRC_LINE.Size = new System.Drawing.Size(37, 21);
            this.CBO_PRC_LINE.TabIndex = 2;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(406, 18);
            this.CBO_SHIFT.MaxLength = 32767;
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
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "板坯号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(554, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "炉座号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(338, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次/别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "装炉时间";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // CGT2000C
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2000C";
            this.Text = "加热炉实绩查询_CGT2000C";
            this.Load += new System.EventHandler(this.CGT2000C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.RadioButton OPT_REJECT;
        private System.Windows.Forms.RadioButton OPT_DISCH;
        private System.Windows.Forms.RadioButton OPT_CH;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.ComboBox CBO_PRC_LINE;
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
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label SSPpdt;
        private System.Windows.Forms.Label label7;
        private CommonClass.F4ETCR txt_stlgrd;
        private System.Windows.Forms.TextBox txt_STLGRD_Name;
        private System.Windows.Forms.Label SSP4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SDB_WGT;
    }
}
