namespace CG
{
    partial class WGT3020C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGT3020C));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_STDSPEC = new CommonClass.F4ETCN();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.OPT_MILL = new System.Windows.Forms.RadioButton();
            this.OPT_SMSMILL = new System.Windows.Forms.RadioButton();
            this.TXT_SP_CD = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.CB0_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_STDSPEC);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.OPT_MILL);
            this.groupBox1.Controls.Add(this.OPT_SMSMILL);
            this.groupBox1.Controls.Add(this.TXT_SP_CD);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.CB0_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_STDSPEC
            // 
            this.TXT_STDSPEC.Location = new System.Drawing.Point(518, 52);
            this.TXT_STDSPEC.Name = "TXT_STDSPEC";
            this.TXT_STDSPEC.sFcontrol = "STDSPEC";
            this.TXT_STDSPEC.Size = new System.Drawing.Size(183, 22);
            this.TXT_STDSPEC.sJoin = "";
            this.TXT_STDSPEC.sSqletc = resources.GetString("TXT_STDSPEC.sSqletc");
            this.TXT_STDSPEC.TabIndex = 7;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(851, 19);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.ReadOnly = true;
            this.TXT_PLT.Size = new System.Drawing.Size(37, 22);
            this.TXT_PLT.TabIndex = 6;
            this.TXT_PLT.Text = "C2";
            this.TXT_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OPT_MILL
            // 
            this.OPT_MILL.Location = new System.Drawing.Point(853, 47);
            this.OPT_MILL.Name = "OPT_MILL";
            this.OPT_MILL.Size = new System.Drawing.Size(51, 25);
            this.OPT_MILL.TabIndex = 5;
            this.OPT_MILL.TabStop = true;
            this.OPT_MILL.Text = "轧钢";
            this.OPT_MILL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_MILL.UseVisualStyleBackColor = true;
            this.OPT_MILL.Click += new System.EventHandler(this.OPT_MILL_Click);
            // 
            // OPT_SMSMILL
            // 
            this.OPT_SMSMILL.Location = new System.Drawing.Point(783, 47);
            this.OPT_SMSMILL.Name = "OPT_SMSMILL";
            this.OPT_SMSMILL.Size = new System.Drawing.Size(51, 25);
            this.OPT_SMSMILL.TabIndex = 5;
            this.OPT_SMSMILL.TabStop = true;
            this.OPT_SMSMILL.Text = "综合";
            this.OPT_SMSMILL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_SMSMILL.UseVisualStyleBackColor = true;
            this.OPT_SMSMILL.Click += new System.EventHandler(this.OPT_SMSMILL_Click);
            // 
            // TXT_SP_CD
            // 
            this.TXT_SP_CD.Location = new System.Drawing.Point(961, 51);
            this.TXT_SP_CD.Name = "TXT_SP_CD";
            this.TXT_SP_CD.Size = new System.Drawing.Size(26, 22);
            this.TXT_SP_CD.TabIndex = 4;
            this.TXT_SP_CD.Visible = false;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(130, 52);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(131, 22);
            this.TXT_MAT_NO.TabIndex = 4;
            // 
            // CB0_GROUP
            // 
            this.CB0_GROUP.FormattingEnabled = true;
            this.CB0_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CB0_GROUP.Location = new System.Drawing.Point(648, 20);
            this.CB0_GROUP.Name = "CB0_GROUP";
            this.CB0_GROUP.Size = new System.Drawing.Size(53, 21);
            this.CB0_GROUP.TabIndex = 3;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(486, 19);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(51, 21);
            this.CBO_SHIFT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // CDT_PROD_DATE_TO
            // 
            this.CDT_PROD_DATE_TO.Location = new System.Drawing.Point(244, 18);
            this.CDT_PROD_DATE_TO.Name = "CDT_PROD_DATE_TO";
            this.CDT_PROD_DATE_TO.RawDate = "";
            this.CDT_PROD_DATE_TO.Size = new System.Drawing.Size(100, 21);
            this.CDT_PROD_DATE_TO.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(783, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(417, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(579, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "班别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDT_PROD_DATE_FROM
            // 
            this.CDT_PROD_DATE_FROM.Location = new System.Drawing.Point(129, 18);
            this.CDT_PROD_DATE_FROM.Name = "CDT_PROD_DATE_FROM";
            this.CDT_PROD_DATE_FROM.RawDate = "";
            this.CDT_PROD_DATE_FROM.Size = new System.Drawing.Size(98, 21);
            this.CDT_PROD_DATE_FROM.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(417, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 0;
            this.label7.Tag = "F4";
            this.label7.Text = "标准号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(29, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "查询号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "轧制时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 81);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 541);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT3020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT3020C";
            this.Text = "物料全息查询界面_WGT3020C";
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
        private System.Windows.Forms.RadioButton OPT_MILL;
        private System.Windows.Forms.RadioButton OPT_SMSMILL;
        private System.Windows.Forms.TextBox TXT_SP_CD;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.ComboBox CB0_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate CDT_PROD_DATE_TO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CommonClass.CeriUDate CDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCN TXT_STDSPEC;
    }
}
