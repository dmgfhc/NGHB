namespace FG
{
    partial class FGC1020C
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
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.rdo_mat = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_out = new System.Windows.Forms.RadioButton();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_HTM_PLT = new System.Windows.Forms.TextBox();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.TXT_PRC_LINE = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PRC_LINE);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.rdo_mat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdo_out);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.TXT_PROD_CD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_HTM_PLT);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(791, 42);
            this.cbo_PrcLine.MaxLength = 1;
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(50, 22);
            this.cbo_PrcLine.TabIndex = 529;
            this.cbo_PrcLine.Text = "1";
            this.cbo_PrcLine.Visible = false;
            // 
            // rdo_mat
            // 
            this.rdo_mat.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_mat.Location = new System.Drawing.Point(878, 11);
            this.rdo_mat.Name = "rdo_mat";
            this.rdo_mat.Size = new System.Drawing.Size(75, 24);
            this.rdo_mat.TabIndex = 528;
            this.rdo_mat.Text = "物料号";
            this.rdo_mat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_mat.UseVisualStyleBackColor = true;
            this.rdo_mat.CheckedChanged += new System.EventHandler(this.rdo_mat_CheckedChanged);
            this.rdo_mat.Click += new System.EventHandler(this.rdo_mat_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdo_out
            // 
            this.rdo_out.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_out.Location = new System.Drawing.Point(878, 41);
            this.rdo_out.Name = "rdo_out";
            this.rdo_out.Size = new System.Drawing.Size(66, 24);
            this.rdo_out.TabIndex = 527;
            this.rdo_out.Text = "轧批号";
            this.rdo_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_out.UseVisualStyleBackColor = true;
            this.rdo_out.CheckedChanged += new System.EventHandler(this.rdo_out_CheckedChanged);
            this.rdo_out.Click += new System.EventHandler(this.rdo_out_Click);
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(93, 42);
            this.CBO_SHIFT.MaxLength = 1;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(57, 22);
            this.CBO_SHIFT.TabIndex = 508;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(974, 17);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(26, 22);
            this.TXT_PROD_CD.TabIndex = 526;
            this.TXT_PROD_CD.Visible = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(726, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 525;
            this.label4.Tag = "";
            this.label4.Text = "炉座号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // TXT_HTM_PLT
            // 
            this.TXT_HTM_PLT.Location = new System.Drawing.Point(974, 46);
            this.TXT_HTM_PLT.Name = "TXT_HTM_PLT";
            this.TXT_HTM_PLT.Size = new System.Drawing.Size(60, 22);
            this.TXT_HTM_PLT.TabIndex = 526;
            this.TXT_HTM_PLT.Text = "C2";
            this.TXT_HTM_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_HTM_PLT.Visible = false;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(590, 43);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(60, 22);
            this.TXT_PLT.TabIndex = 526;
            this.TXT_PLT.Text = "C2";
            this.TXT_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(590, 16);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(134, 22);
            this.TXT_MAT_NO.TabIndex = 526;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(319, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 525;
            this.label7.Tag = "";
            this.label7.Text = "产线";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(507, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 525;
            this.label6.Tag = "";
            this.label6.Text = "生产厂";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(507, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 525;
            this.label2.Tag = "";
            this.label2.Text = "物料号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "装炉日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CBO_GROUP.Location = new System.Drawing.Point(384, 44);
            this.CBO_GROUP.MaxLength = 1;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(50, 22);
            this.CBO_GROUP.TabIndex = 505;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(319, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "班别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1185, 550);
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
            this.ss1.Size = new System.Drawing.Size(1179, 529);
            this.ss1.TabIndex = 0;
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellDoubleClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // TXT_PRC_LINE
            // 
            this.TXT_PRC_LINE.Font = new System.Drawing.Font("宋体", 10.25F);
            this.TXT_PRC_LINE.FormattingEnabled = true;
            this.TXT_PRC_LINE.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TXT_PRC_LINE.Location = new System.Drawing.Point(384, 14);
            this.TXT_PRC_LINE.MaxLength = 1;
            this.TXT_PRC_LINE.Name = "TXT_PRC_LINE";
            this.TXT_PRC_LINE.Size = new System.Drawing.Size(50, 22);
            this.TXT_PRC_LINE.TabIndex = 530;
            this.TXT_PRC_LINE.Text = "1";
            // 
            // FGC1020C
            // 
            this.ClientSize = new System.Drawing.Size(1185, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGC1020C";
            this.Text = "热处理实绩查询(装炉时间)界面_FGC1020C";
            this.Load += new System.EventHandler(this.FGC1020C_Load);
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
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label5;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.RadioButton rdo_mat;
        private System.Windows.Forms.RadioButton rdo_out;
        private System.Windows.Forms.TextBox TXT_PROD_CD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_PLT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_HTM_PLT;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private System.Windows.Forms.ComboBox TXT_PRC_LINE;
    }
}
