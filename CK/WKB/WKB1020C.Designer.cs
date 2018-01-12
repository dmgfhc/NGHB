namespace CK
{
    partial class WKB1020C
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
            this.udt_prod_date_to = new CommonClass.CeriUDate();
            this.udt_prod_date_from = new CommonClass.CeriUDate();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.cbo_prc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udt_prod_date_to);
            this.groupBox1.Controls.Add(this.udt_prod_date_from);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.cbo_prc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // udt_prod_date_to
            // 
            this.udt_prod_date_to.Location = new System.Drawing.Point(533, 14);
            this.udt_prod_date_to.Name = "udt_prod_date_to";
            this.udt_prod_date_to.RawDate = "";
            this.udt_prod_date_to.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date_to.TabIndex = 81;
            // 
            // udt_prod_date_from
            // 
            this.udt_prod_date_from.Location = new System.Drawing.Point(435, 14);
            this.udt_prod_date_from.Name = "udt_prod_date_from";
            this.udt_prod_date_from.RawDate = "";
            this.udt_prod_date_from.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date_from.TabIndex = 80;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(266, 14);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(46, 22);
            this.cbo_shift.TabIndex = 7;
            // 
            // cbo_prc
            // 
            this.cbo_prc.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_prc.FormattingEnabled = true;
            this.cbo_prc.Items.AddRange(new object[] {
            "BA",
            "BB",
            "BC",
            "BD",
            "BE",
            "BF",
            "BG",
            "BH",
            "CA",
            "CB",
            "CC",
            "CD",
            "CE",
            "CF",
            "CG",
            "CH",
            "CI",
            "CJ",
            "CK",
            "DA",
            "DB",
            "DN",
            "DQ",
            "DT",
            "DZ",
            "QA",
            "XA"});
            this.cbo_prc.Location = new System.Drawing.Point(94, 14);
            this.cbo_prc.Name = "cbo_prc";
            this.cbo_prc.Size = new System.Drawing.Size(46, 22);
            this.cbo_prc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(353, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "发生时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(184, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "工序";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 579);
            this.groupBox2.TabIndex = 2;
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
            this.ss1.Size = new System.Drawing.Size(1012, 558);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WKB1020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WKB1020C";
            this.Text = "生产线公辅材料使用实绩管理界面_WKB1020C";
            this.Load += new System.EventHandler(this.WKB1020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CommonClass.CeriUDate udt_prod_date_to;
        private CommonClass.CeriUDate udt_prod_date_from;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.ComboBox cbo_prc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;

    }
}
