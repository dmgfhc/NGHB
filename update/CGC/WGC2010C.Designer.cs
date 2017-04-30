namespace CG
{
    partial class WGC2010C
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
            this.btn_cut = new System.Windows.Forms.Button();
            this.cbo_cut_cnt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mat_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt_prod_date_to = new CommonClass.CeriUDate();
            this.sdt_prod_date_fr = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cut);
            this.groupBox1.Controls.Add(this.cbo_cut_cnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mat_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sdt_prod_date_to);
            this.groupBox1.Controls.Add(this.sdt_prod_date_fr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(890, 12);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(100, 24);
            this.btn_cut.TabIndex = 502;
            this.btn_cut.Text = "分段";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // cbo_cut_cnt
            // 
            this.cbo_cut_cnt.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_cut_cnt.FormattingEnabled = true;
            this.cbo_cut_cnt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbo_cut_cnt.Location = new System.Drawing.Point(814, 14);
            this.cbo_cut_cnt.Name = "cbo_cut_cnt";
            this.cbo_cut_cnt.Size = new System.Drawing.Size(50, 22);
            this.cbo_cut_cnt.TabIndex = 501;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(732, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 500;
            this.label2.Text = "分段数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mat_no
            // 
            this.txt_mat_no.Location = new System.Drawing.Point(589, 14);
            this.txt_mat_no.Name = "txt_mat_no";
            this.txt_mat_no.Size = new System.Drawing.Size(123, 22);
            this.txt_mat_no.TabIndex = 499;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(507, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 498;
            this.label1.Text = "查询号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(437, 14);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(50, 22);
            this.cbo_shift.TabIndex = 497;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(355, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 496;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_prod_date_to
            // 
            this.sdt_prod_date_to.Location = new System.Drawing.Point(241, 14);
            this.sdt_prod_date_to.Name = "sdt_prod_date_to";
            this.sdt_prod_date_to.RawDate = "";
            this.sdt_prod_date_to.Size = new System.Drawing.Size(95, 22);
            this.sdt_prod_date_to.TabIndex = 495;
            // 
            // sdt_prod_date_fr
            // 
            this.sdt_prod_date_fr.Location = new System.Drawing.Point(143, 14);
            this.sdt_prod_date_fr.Name = "sdt_prod_date_fr";
            this.sdt_prod_date_fr.RawDate = "";
            this.sdt_prod_date_fr.Size = new System.Drawing.Size(95, 22);
            this.sdt_prod_date_fr.TabIndex = 494;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 493;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss2);
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1118, 604);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 173);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1112, 428);
            this.ss2.TabIndex = 2;
            this.ss2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss2_CellClick);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1112, 155);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGC2010C
            // 
            this.ClientSize = new System.Drawing.Size(1118, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC2010C";
            this.Text = "母板分段实绩管理界面_WGC2010C";
            this.Load += new System.EventHandler(this.WGC2010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.Label label3;
        private CommonClass.CeriUDate sdt_prod_date_to;
        private CommonClass.CeriUDate sdt_prod_date_fr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mat_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.ComboBox cbo_cut_cnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cut;
    }
}
