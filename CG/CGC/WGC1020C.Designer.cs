namespace CG
{
    partial class WGC1020C
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sche_can = new System.Windows.Forms.RadioButton();
            this.sche_sent = new System.Windows.Forms.RadioButton();
            this.sdt_date_to = new CommonClass.CeriUDate();
            this.sdt_date_fr = new CommonClass.CeriUDate();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.txt_slab_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 579);
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
            this.ss1.Size = new System.Drawing.Size(1012, 558);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.sdt_date_to);
            this.groupBox1.Controls.Add(this.sdt_date_fr);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.txt_slab_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sche_can);
            this.panel1.Controls.Add(this.sche_sent);
            this.panel1.Location = new System.Drawing.Point(19, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 31);
            this.panel1.TabIndex = 93;
            // 
            // sche_can
            // 
            this.sche_can.Location = new System.Drawing.Point(113, 4);
            this.sche_can.Name = "sche_can";
            this.sche_can.Size = new System.Drawing.Size(89, 22);
            this.sche_can.TabIndex = 76;
            this.sche_can.Text = "指示取消";
            this.sche_can.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sche_can.UseVisualStyleBackColor = true;
            // 
            // sche_sent
            // 
            this.sche_sent.Checked = true;
            this.sche_sent.Location = new System.Drawing.Point(17, 4);
            this.sche_sent.Name = "sche_sent";
            this.sche_sent.Size = new System.Drawing.Size(89, 22);
            this.sche_sent.TabIndex = 75;
            this.sche_sent.TabStop = true;
            this.sche_sent.Text = "指示下达";
            this.sche_sent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sche_sent.UseVisualStyleBackColor = true;
            // 
            // sdt_date_to
            // 
            this.sdt_date_to.Location = new System.Drawing.Point(419, 13);
            this.sdt_date_to.Name = "sdt_date_to";
            this.sdt_date_to.RawDate = "";
            this.sdt_date_to.Size = new System.Drawing.Size(95, 22);
            this.sdt_date_to.TabIndex = 92;
            // 
            // sdt_date_fr
            // 
            this.sdt_date_fr.Location = new System.Drawing.Point(321, 13);
            this.sdt_date_fr.Name = "sdt_date_fr";
            this.sdt_date_fr.RawDate = "";
            this.sdt_date_fr.Size = new System.Drawing.Size(95, 22);
            this.sdt_date_fr.TabIndex = 91;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(785, 13);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(53, 22);
            this.cbo_shift.TabIndex = 90;
            // 
            // txt_slab_no
            // 
            this.txt_slab_no.Location = new System.Drawing.Point(612, 13);
            this.txt_slab_no.Name = "txt_slab_no";
            this.txt_slab_no.Size = new System.Drawing.Size(100, 22);
            this.txt_slab_no.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(731, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 88;
            this.label4.Text = "班次";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(239, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "生产日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(530, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "钢板号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WGC1020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC1020C";
            this.Text = "钢板作业指示管理界面_WGC1020C";
            this.Load += new System.EventHandler(this.WGC1020C_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sche_can;
        private System.Windows.Forms.RadioButton sche_sent;
        private CommonClass.CeriUDate sdt_date_to;
        private CommonClass.CeriUDate sdt_date_fr;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.TextBox txt_slab_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
