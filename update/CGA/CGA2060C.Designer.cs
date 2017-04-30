namespace CG
{
    partial class CGA2060C
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label1 = new System.Windows.Forms.Label();
            this.sdt_in_plt_date = new CommonClass.CeriUDate();
            this.sdt_out_plt_date = new CommonClass.CeriUDate();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 59);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 563);
            this.ss1.TabIndex = 1;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_in_plt_date
            // 
            this.sdt_in_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_in_plt_date.Location = new System.Drawing.Point(103, 21);
            this.sdt_in_plt_date.Name = "sdt_in_plt_date";
            this.sdt_in_plt_date.RawDate = "";
            this.sdt_in_plt_date.Size = new System.Drawing.Size(112, 24);
            this.sdt_in_plt_date.TabIndex = 514;
            this.sdt_in_plt_date.Tag = "开始时间";
            // 
            // sdt_out_plt_date
            // 
            this.sdt_out_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_out_plt_date.Location = new System.Drawing.Point(215, 21);
            this.sdt_out_plt_date.Name = "sdt_out_plt_date";
            this.sdt_out_plt_date.RawDate = "";
            this.sdt_out_plt_date.Size = new System.Drawing.Size(112, 24);
            this.sdt_out_plt_date.TabIndex = 515;
            this.sdt_out_plt_date.Tag = "结束时间";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sdt_out_plt_date);
            this.groupBox1.Controls.Add(this.sdt_in_plt_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CGA2060C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2060C";
            this.Text = "库情况查询界面_CGA2060C";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate sdt_in_plt_date;
        private CommonClass.CeriUDate sdt_out_plt_date;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
