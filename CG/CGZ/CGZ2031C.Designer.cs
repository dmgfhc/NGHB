namespace CG
{
    partial class CGZ2031C
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
            this.TXT_SEARCH_FL = new System.Windows.Forms.TextBox();
            this.opt_all = new System.Windows.Forms.RadioButton();
            this.TXT_CUT_TIME = new CommonClass.MaskedDate();
            this.label7 = new System.Windows.Forms.Label();
            this.CBO_LINE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SEQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MPLATE_NO = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXT_WGT_MIN = new System.Windows.Forms.TextBox();
            this.TXT_WGT_MAX = new System.Windows.Forms.TextBox();
            this.TXT_UST = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_SPEC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_DEL_TO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_DEL_FROM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_CUST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_MARKING = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_WGT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_SIZE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_ORD_NO = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SEARCH_FL);
            this.groupBox1.Controls.Add(this.opt_all);
            this.groupBox1.Controls.Add(this.TXT_CUT_TIME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CBO_LINE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBO_PLT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_SEQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_MPLATE_NO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_SEARCH_FL
            // 
            this.TXT_SEARCH_FL.Location = new System.Drawing.Point(974, 27);
            this.TXT_SEARCH_FL.MaxLength = 1;
            this.TXT_SEARCH_FL.Name = "TXT_SEARCH_FL";
            this.TXT_SEARCH_FL.Size = new System.Drawing.Size(24, 22);
            this.TXT_SEARCH_FL.TabIndex = 482;
            this.TXT_SEARCH_FL.Text = "1";
            this.TXT_SEARCH_FL.Visible = false;
            // 
            // opt_all
            // 
            this.opt_all.AutoSize = true;
            this.opt_all.Checked = true;
            this.opt_all.Location = new System.Drawing.Point(947, 18);
            this.opt_all.Name = "opt_all";
            this.opt_all.Size = new System.Drawing.Size(51, 17);
            this.opt_all.TabIndex = 481;
            this.opt_all.TabStop = true;
            this.opt_all.Text = "全部";
            this.opt_all.UseVisualStyleBackColor = true;
            this.opt_all.Visible = false;
            // 
            // TXT_CUT_TIME
            // 
            this.TXT_CUT_TIME.Location = new System.Drawing.Point(805, 18);
            this.TXT_CUT_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_CUT_TIME.Name = "TXT_CUT_TIME";
            this.TXT_CUT_TIME.Size = new System.Drawing.Size(144, 22);
            this.TXT_CUT_TIME.TabIndex = 5;
            this.TXT_CUT_TIME.TextChanged += new System.EventHandler(this.TXT_CUT_TIME_TextChanged);
            this.TXT_CUT_TIME.DoubleClick += new System.EventHandler(this.TXT_CUT_TIME_DoubleClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(720, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 479;
            this.label7.Text = "切割时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_LINE
            // 
            this.CBO_LINE.FormattingEnabled = true;
            this.CBO_LINE.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CBO_LINE.Location = new System.Drawing.Point(651, 18);
            this.CBO_LINE.Name = "CBO_LINE";
            this.CBO_LINE.Size = new System.Drawing.Size(45, 21);
            this.CBO_LINE.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(580, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 477;
            this.label6.Tag = "f4";
            this.label6.Text = "剪切线";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C3"});
            this.CBO_PLT.Location = new System.Drawing.Point(506, 18);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(47, 21);
            this.CBO_PLT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(418, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 475;
            this.label3.Tag = "f4";
            this.label3.Text = "工厂代码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 474;
            this.label1.Tag = "f4";
            this.label1.Text = "分段号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SEQ
            // 
            this.TXT_SEQ.Location = new System.Drawing.Point(300, 18);
            this.TXT_SEQ.MaxLength = 12;
            this.TXT_SEQ.Name = "TXT_SEQ";
            this.TXT_SEQ.Size = new System.Drawing.Size(102, 22);
            this.TXT_SEQ.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "查询号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MPLATE_NO
            // 
            this.TXT_MPLATE_NO.Location = new System.Drawing.Point(93, 18);
            this.TXT_MPLATE_NO.MaxLength = 12;
            this.TXT_MPLATE_NO.Name = "TXT_MPLATE_NO";
            this.TXT_MPLATE_NO.Size = new System.Drawing.Size(102, 22);
            this.TXT_MPLATE_NO.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1012, 169);
            this.ss1.TabIndex = 2;
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellDoubleClick);
            this.ss1.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss1_EditChange);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 245);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1018, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 239);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1012, 218);
            this.ss2.TabIndex = 3;
            this.ss2.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss2_CellDoubleClick);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 487);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1018, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TXT_WGT_MIN);
            this.groupBox4.Controls.Add(this.TXT_WGT_MAX);
            this.groupBox4.Controls.Add(this.TXT_UST);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TXT_SPEC);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TXT_DEL_TO);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TXT_DEL_FROM);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TXT_CUST);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TXT_MARKING);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TXT_WGT);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TXT_SIZE);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TXT_ORD_NO);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 490);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 132);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // TXT_WGT_MIN
            // 
            this.TXT_WGT_MIN.Location = new System.Drawing.Point(224, 74);
            this.TXT_WGT_MIN.Name = "TXT_WGT_MIN";
            this.TXT_WGT_MIN.Size = new System.Drawing.Size(29, 22);
            this.TXT_WGT_MIN.TabIndex = 29;
            this.TXT_WGT_MIN.Visible = false;
            // 
            // TXT_WGT_MAX
            // 
            this.TXT_WGT_MAX.Location = new System.Drawing.Point(189, 74);
            this.TXT_WGT_MAX.Name = "TXT_WGT_MAX";
            this.TXT_WGT_MAX.Size = new System.Drawing.Size(29, 22);
            this.TXT_WGT_MAX.TabIndex = 28;
            this.TXT_WGT_MAX.Visible = false;
            // 
            // TXT_UST
            // 
            this.TXT_UST.Location = new System.Drawing.Point(791, 49);
            this.TXT_UST.Name = "TXT_UST";
            this.TXT_UST.Size = new System.Drawing.Size(112, 22);
            this.TXT_UST.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(715, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 21);
            this.label15.TabIndex = 26;
            this.label15.Text = "是否UST";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SPEC
            // 
            this.TXT_SPEC.Location = new System.Drawing.Point(591, 49);
            this.TXT_SPEC.Name = "TXT_SPEC";
            this.TXT_SPEC.Size = new System.Drawing.Size(99, 22);
            this.TXT_SPEC.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(515, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "标准";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DEL_TO
            // 
            this.TXT_DEL_TO.Location = new System.Drawing.Point(414, 49);
            this.TXT_DEL_TO.Name = "TXT_DEL_TO";
            this.TXT_DEL_TO.Size = new System.Drawing.Size(88, 22);
            this.TXT_DEL_TO.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "~";
            // 
            // TXT_DEL_FROM
            // 
            this.TXT_DEL_FROM.Location = new System.Drawing.Point(300, 49);
            this.TXT_DEL_FROM.Name = "TXT_DEL_FROM";
            this.TXT_DEL_FROM.Size = new System.Drawing.Size(88, 22);
            this.TXT_DEL_FROM.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(224, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "交货期";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "客户";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_CUST
            // 
            this.TXT_CUST.Location = new System.Drawing.Point(88, 50);
            this.TXT_CUST.Name = "TXT_CUST";
            this.TXT_CUST.Size = new System.Drawing.Size(130, 22);
            this.TXT_CUST.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(715, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "标识方法";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MARKING
            // 
            this.TXT_MARKING.Location = new System.Drawing.Point(791, 17);
            this.TXT_MARKING.Name = "TXT_MARKING";
            this.TXT_MARKING.Size = new System.Drawing.Size(112, 22);
            this.TXT_MARKING.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(515, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "重量";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_WGT
            // 
            this.TXT_WGT.Location = new System.Drawing.Point(591, 17);
            this.TXT_WGT.Name = "TXT_WGT";
            this.TXT_WGT.Size = new System.Drawing.Size(99, 22);
            this.TXT_WGT.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(224, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "规格";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SIZE
            // 
            this.TXT_SIZE.Location = new System.Drawing.Point(300, 17);
            this.TXT_SIZE.Name = "TXT_SIZE";
            this.TXT_SIZE.Size = new System.Drawing.Size(202, 22);
            this.TXT_SIZE.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "订单号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_ORD_NO
            // 
            this.TXT_ORD_NO.Location = new System.Drawing.Point(88, 18);
            this.TXT_ORD_NO.Name = "TXT_ORD_NO";
            this.TXT_ORD_NO.Size = new System.Drawing.Size(130, 22);
            this.TXT_ORD_NO.TabIndex = 10;
            // 
            // CGZ2031C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGZ2031C";
            this.Text = "钢板剪切实绩查询及修改界面_CGZ2031C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_MPLATE_NO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TXT_UST;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXT_SPEC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_DEL_TO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_DEL_FROM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_CUST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_MARKING;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_WGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_SIZE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_ORD_NO;
        private System.Windows.Forms.TextBox TXT_WGT_MIN;
        private System.Windows.Forms.TextBox TXT_WGT_MAX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SEQ;
        private System.Windows.Forms.ComboBox CBO_LINE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_SEARCH_FL;
        private System.Windows.Forms.RadioButton opt_all;
        private CommonClass.MaskedDate TXT_CUT_TIME;
        private System.Windows.Forms.Label label7;
    }
}
