namespace CG
{
    partial class AGC3020C
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
            this.TXT_KND = new System.Windows.Forms.TextBox();
            this.CBO_KND = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SDT_PROD_TO_DATE = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE = new CommonClass.CeriUDate();
            this.Ulabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_KND);
            this.groupBox1.Controls.Add(this.CBO_KND);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.CBO_PLT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SDT_PROD_TO_DATE);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE);
            this.groupBox1.Controls.Add(this.Ulabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TXT_KND
            // 
            this.TXT_KND.Location = new System.Drawing.Point(966, 17);
            this.TXT_KND.Name = "TXT_KND";
            this.TXT_KND.Size = new System.Drawing.Size(18, 22);
            this.TXT_KND.TabIndex = 448;
            this.TXT_KND.Visible = false;
            // 
            // CBO_KND
            // 
            this.CBO_KND.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_KND.FormattingEnabled = true;
            this.CBO_KND.Items.AddRange(new object[] {
            "1 钢板退判",
            "6 退入库",
            "8 强制排产",
            "4 钢板删除"});
            this.CBO_KND.Location = new System.Drawing.Point(777, 18);
            this.CBO_KND.Name = "CBO_KND";
            this.CBO_KND.Size = new System.Drawing.Size(118, 22);
            this.CBO_KND.TabIndex = 447;
            this.CBO_KND.SelectedIndexChanged += new System.EventHandler(this.CBO_KND_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(711, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 446;
            this.label5.Text = "分类";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(586, 18);
            this.TXT_PLATE_NO.MaxLength = 14;
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(84, 22);
            this.TXT_PLATE_NO.TabIndex = 445;
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "B1",
            "B3",
            "C1",
            "C2",
            "C3"});
            this.CBO_PLT.Location = new System.Drawing.Point(104, 18);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(46, 22);
            this.CBO_PLT.TabIndex = 443;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 442;
            this.label1.Text = "生产厂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SDT_PROD_TO_DATE
            // 
            this.SDT_PROD_TO_DATE.Location = new System.Drawing.Point(388, 18);
            this.SDT_PROD_TO_DATE.Name = "SDT_PROD_TO_DATE";
            this.SDT_PROD_TO_DATE.RawDate = "";
            this.SDT_PROD_TO_DATE.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_TO_DATE.TabIndex = 441;
            // 
            // SDT_PROD_DATE
            // 
            this.SDT_PROD_DATE.Location = new System.Drawing.Point(290, 18);
            this.SDT_PROD_DATE.Name = "SDT_PROD_DATE";
            this.SDT_PROD_DATE.RawDate = "";
            this.SDT_PROD_DATE.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE.TabIndex = 440;
            // 
            // Ulabel5
            // 
            this.Ulabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ulabel5.Location = new System.Drawing.Point(187, 18);
            this.Ulabel5.Name = "Ulabel5";
            this.Ulabel5.Size = new System.Drawing.Size(101, 22);
            this.Ulabel5.TabIndex = 439;
            this.Ulabel5.Text = "退判时间";
            this.Ulabel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 57);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 565);
            this.ss1.TabIndex = 5;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(518, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 449;
            this.label2.Text = "查询号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AGC3020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AGC3020C";
            this.Text = "产品退判查询-AGC3020C";
            this.Load += new System.EventHandler(this.AGC3020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_KND;
        private System.Windows.Forms.ComboBox CBO_KND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate SDT_PROD_TO_DATE;
        private CommonClass.CeriUDate SDT_PROD_DATE;
        private System.Windows.Forms.Label Ulabel5;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label2;

    }
}
