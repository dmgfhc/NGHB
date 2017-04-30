namespace FG
{
    partial class FGC1040C
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo_hcl = new System.Windows.Forms.RadioButton();
            this.rdo_ccl = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_mat = new System.Windows.Forms.RadioButton();
            this.rdo_out = new System.Windows.Forms.RadioButton();
            this.SSCommand2 = new System.Windows.Forms.Button();
            this.TXT_CUR = new CommonClass.F4COMR();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.TXT_PRC = new System.Windows.Forms.TextBox();
            this.TXT_LOC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_NO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_PRC_LINE = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SDT_CUR_OUT = new CommonClass.CeriUDate();
            this.SDT_CUR_IN = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SSCommand2);
            this.groupBox1.Controls.Add(this.TXT_CUR);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.TXT_PROD_CD);
            this.groupBox1.Controls.Add(this.TXT_PRC);
            this.groupBox1.Controls.Add(this.TXT_LOC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_NO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_PRC_LINE);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SDT_CUR_OUT);
            this.groupBox1.Controls.Add(this.SDT_CUR_IN);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdo_hcl);
            this.groupBox4.Controls.Add(this.rdo_ccl);
            this.groupBox4.Location = new System.Drawing.Point(878, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(92, 61);
            this.groupBox4.TabIndex = 534;
            this.groupBox4.TabStop = false;
            // 
            // rdo_hcl
            // 
            this.rdo_hcl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_hcl.Location = new System.Drawing.Point(13, 9);
            this.rdo_hcl.Name = "rdo_hcl";
            this.rdo_hcl.Size = new System.Drawing.Size(66, 24);
            this.rdo_hcl.TabIndex = 530;
            this.rdo_hcl.Text = "热矫";
            this.rdo_hcl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_hcl.UseVisualStyleBackColor = true;
            this.rdo_hcl.Click += new System.EventHandler(this.rdo_hcl_Click);
            // 
            // rdo_ccl
            // 
            this.rdo_ccl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_ccl.Location = new System.Drawing.Point(13, 31);
            this.rdo_ccl.Name = "rdo_ccl";
            this.rdo_ccl.Size = new System.Drawing.Size(66, 24);
            this.rdo_ccl.TabIndex = 529;
            this.rdo_ccl.Text = "返矫";
            this.rdo_ccl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_ccl.UseVisualStyleBackColor = true;
            this.rdo_ccl.Click += new System.EventHandler(this.rdo_ccl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_mat);
            this.groupBox2.Controls.Add(this.rdo_out);
            this.groupBox2.Location = new System.Drawing.Point(784, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 62);
            this.groupBox2.TabIndex = 533;
            this.groupBox2.TabStop = false;
            // 
            // rdo_mat
            // 
            this.rdo_mat.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_mat.Location = new System.Drawing.Point(8, 9);
            this.rdo_mat.Name = "rdo_mat";
            this.rdo_mat.Size = new System.Drawing.Size(66, 24);
            this.rdo_mat.TabIndex = 532;
            this.rdo_mat.Text = "物料号";
            this.rdo_mat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_mat.UseVisualStyleBackColor = true;
            this.rdo_mat.Click += new System.EventHandler(this.rdo_mat_Click);
            // 
            // rdo_out
            // 
            this.rdo_out.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_out.Location = new System.Drawing.Point(8, 33);
            this.rdo_out.Name = "rdo_out";
            this.rdo_out.Size = new System.Drawing.Size(66, 24);
            this.rdo_out.TabIndex = 531;
            this.rdo_out.Text = "轧批号";
            this.rdo_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_out.UseVisualStyleBackColor = true;
            this.rdo_out.Click += new System.EventHandler(this.rdo_out_Click);
            // 
            // SSCommand2
            // 
            this.SSCommand2.Location = new System.Drawing.Point(976, 17);
            this.SSCommand2.Name = "SSCommand2";
            this.SSCommand2.Size = new System.Drawing.Size(121, 23);
            this.SSCommand2.TabIndex = 532;
            this.SSCommand2.Text = "堆码报告";
            this.SSCommand2.UseVisualStyleBackColor = true;
            this.SSCommand2.Click += new System.EventHandler(this.SSCommand2_Click);
            // 
            // TXT_CUR
            // 
            this.TXT_CUR.Location = new System.Drawing.Point(395, 47);
            this.TXT_CUR.Name = "TXT_CUR";
            this.TXT_CUR.Size = new System.Drawing.Size(190, 22);
            this.TXT_CUR.sJoin = "";
            this.TXT_CUR.sKey = "C0013";
            this.TXT_CUR.sMax = 0;
            this.TXT_CUR.TabIndex = 531;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(673, 16);
            this.CBO_SHIFT.MaxLength = 1;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(48, 22);
            this.CBO_SHIFT.TabIndex = 508;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(573, 15);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(32, 22);
            this.TXT_PROD_CD.TabIndex = 526;
            this.TXT_PROD_CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PROD_CD.Visible = false;
            // 
            // TXT_PRC
            // 
            this.TXT_PRC.Location = new System.Drawing.Point(535, 18);
            this.TXT_PRC.Name = "TXT_PRC";
            this.TXT_PRC.Size = new System.Drawing.Size(32, 22);
            this.TXT_PRC.TabIndex = 526;
            this.TXT_PRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PRC.Visible = false;
            // 
            // TXT_LOC
            // 
            this.TXT_LOC.Location = new System.Drawing.Point(673, 46);
            this.TXT_LOC.MaxLength = 7;
            this.TXT_LOC.Name = "TXT_LOC";
            this.TXT_LOC.Size = new System.Drawing.Size(98, 22);
            this.TXT_LOC.TabIndex = 526;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(597, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 525;
            this.label6.Tag = "";
            this.label6.Text = "货位";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NO
            // 
            this.TXT_NO.Location = new System.Drawing.Point(1060, 43);
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(49, 22);
            this.TXT_NO.TabIndex = 526;
            this.TXT_NO.Text = "1";
            this.TXT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_NO.Visible = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(984, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 525;
            this.label4.Tag = "";
            this.label4.Text = "炉座号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // TXT_PRC_LINE
            // 
            this.TXT_PRC_LINE.Location = new System.Drawing.Point(1110, 51);
            this.TXT_PRC_LINE.Name = "TXT_PRC_LINE";
            this.TXT_PRC_LINE.Size = new System.Drawing.Size(61, 22);
            this.TXT_PRC_LINE.TabIndex = 526;
            this.TXT_PRC_LINE.Text = "1";
            this.TXT_PRC_LINE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PRC_LINE.Visible = false;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(395, 16);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(134, 22);
            this.TXT_MAT_NO.TabIndex = 526;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(1027, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 525;
            this.label7.Tag = "";
            this.label7.Text = "产线";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(327, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 525;
            this.label3.Tag = "";
            this.label3.Text = "仓库";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(327, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 525;
            this.label2.Tag = "";
            this.label2.Text = "物料号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 511;
            this.label8.Text = "入库时间";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "作业日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_CUR_OUT
            // 
            this.SDT_CUR_OUT.Location = new System.Drawing.Point(194, 47);
            this.SDT_CUR_OUT.Name = "SDT_CUR_OUT";
            this.SDT_CUR_OUT.RawDate = "";
            this.SDT_CUR_OUT.Size = new System.Drawing.Size(95, 22);
            this.SDT_CUR_OUT.TabIndex = 510;
            // 
            // SDT_CUR_IN
            // 
            this.SDT_CUR_IN.Location = new System.Drawing.Point(93, 47);
            this.SDT_CUR_IN.Name = "SDT_CUR_IN";
            this.SDT_CUR_IN.RawDate = "";
            this.SDT_CUR_IN.Size = new System.Drawing.Size(95, 22);
            this.SDT_CUR_IN.TabIndex = 509;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(194, 16);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 510;
            // 
            // SDT_PROD_DATE_FR
            // 
            this.SDT_PROD_DATE_FR.Location = new System.Drawing.Point(93, 16);
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
            this.CBO_GROUP.Location = new System.Drawing.Point(721, 16);
            this.CBO_GROUP.MaxLength = 1;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(50, 22);
            this.CBO_GROUP.TabIndex = 505;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(597, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "班次/班别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1185, 543);
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
            this.ss1.Size = new System.Drawing.Size(1179, 522);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGC1040C
            // 
            this.ClientSize = new System.Drawing.Size(1185, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGC1040C";
            this.Text = "矫直实绩查询界面_FGC1040C";
            this.Load += new System.EventHandler(this.FGC1040C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label5;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.TextBox TXT_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_PRC_LINE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CommonClass.CeriUDate SDT_CUR_OUT;
        private CommonClass.CeriUDate SDT_CUR_IN;
        private System.Windows.Forms.Label label3;
        private CommonClass.F4COMR TXT_CUR;
        private System.Windows.Forms.Button SSCommand2;
        private System.Windows.Forms.TextBox TXT_PRC;
        private System.Windows.Forms.TextBox TXT_LOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PROD_CD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdo_hcl;
        private System.Windows.Forms.RadioButton rdo_ccl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_mat;
        private System.Windows.Forms.RadioButton rdo_out;
    }
}
