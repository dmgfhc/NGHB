namespace CG
{
    partial class WGT2040C
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBO_PRC_LINE = new System.Windows.Forms.ComboBox();
            this.SDT_DATE_END = new CommonClass.CeriUDate();
            this.SDT_DATE_BEGIN = new CommonClass.CeriUDate();
            this.TXT_SLABNO = new System.Windows.Forms.TextBox();
            this.CBO_CLASSTYPE = new System.Windows.Forms.ComboBox();
            this.CBO_CLASSNUM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1018, 1);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CBO_PRC_LINE);
            this.groupBox1.Controls.Add(this.SDT_DATE_END);
            this.groupBox1.Controls.Add(this.SDT_DATE_BEGIN);
            this.groupBox1.Controls.Add(this.TXT_SLABNO);
            this.groupBox1.Controls.Add(this.CBO_CLASSTYPE);
            this.groupBox1.Controls.Add(this.CBO_CLASSNUM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 45);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "热处理线";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_PRC_LINE
            // 
            this.CBO_PRC_LINE.FormattingEnabled = true;
            this.CBO_PRC_LINE.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CBO_PRC_LINE.Location = new System.Drawing.Point(103, 14);
            this.CBO_PRC_LINE.Name = "CBO_PRC_LINE";
            this.CBO_PRC_LINE.Size = new System.Drawing.Size(82, 21);
            this.CBO_PRC_LINE.TabIndex = 20;
            // 
            // SDT_DATE_END
            // 
            this.SDT_DATE_END.Location = new System.Drawing.Point(406, 15);
            this.SDT_DATE_END.Name = "SDT_DATE_END";
            this.SDT_DATE_END.RawDate = "";
            this.SDT_DATE_END.Size = new System.Drawing.Size(100, 21);
            this.SDT_DATE_END.TabIndex = 19;
            // 
            // SDT_DATE_BEGIN
            // 
            this.SDT_DATE_BEGIN.Location = new System.Drawing.Point(285, 15);
            this.SDT_DATE_BEGIN.Name = "SDT_DATE_BEGIN";
            this.SDT_DATE_BEGIN.RawDate = "";
            this.SDT_DATE_BEGIN.Size = new System.Drawing.Size(100, 21);
            this.SDT_DATE_BEGIN.TabIndex = 18;
            // 
            // TXT_SLABNO
            // 
            this.TXT_SLABNO.Location = new System.Drawing.Point(879, 17);
            this.TXT_SLABNO.MaxLength = 14;
            this.TXT_SLABNO.Name = "TXT_SLABNO";
            this.TXT_SLABNO.Size = new System.Drawing.Size(127, 22);
            this.TXT_SLABNO.TabIndex = 16;
            // 
            // CBO_CLASSTYPE
            // 
            this.CBO_CLASSTYPE.FormattingEnabled = true;
            this.CBO_CLASSTYPE.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_CLASSTYPE.Location = new System.Drawing.Point(729, 16);
            this.CBO_CLASSTYPE.Name = "CBO_CLASSTYPE";
            this.CBO_CLASSTYPE.Size = new System.Drawing.Size(54, 21);
            this.CBO_CLASSTYPE.TabIndex = 14;
            // 
            // CBO_CLASSNUM
            // 
            this.CBO_CLASSNUM.FormattingEnabled = true;
            this.CBO_CLASSNUM.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_CLASSNUM.Location = new System.Drawing.Point(594, 16);
            this.CBO_CLASSNUM.Name = "CBO_CLASSNUM";
            this.CBO_CLASSNUM.Size = new System.Drawing.Size(54, 21);
            this.CBO_CLASSNUM.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Tag = "user";
            this.label7.Text = "~";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(669, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "班别";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(792, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "板坯号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(534, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "班次";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(198, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "生产日期";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 46);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 576);
            this.ss1.TabIndex = 24;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT2040C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "WGT2040C";
            this.Text = "返矫板实绩查询界面_WGT2040C";
            this.Load += new System.EventHandler(this.WGT2040C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBO_PRC_LINE;
        private CommonClass.CeriUDate SDT_DATE_END;
        private CommonClass.CeriUDate SDT_DATE_BEGIN;
        private System.Windows.Forms.TextBox TXT_SLABNO;
        private System.Windows.Forms.ComboBox CBO_CLASSTYPE;
        private System.Windows.Forms.ComboBox CBO_CLASSNUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
    }
}
