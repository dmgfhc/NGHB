namespace CG
{
    partial class CGA2030C
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
            this.cbo_YARD_TYPE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_PROD_TYPE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cur_inv = new CommonClass.F4COMR();
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
            this.groupBox1.Controls.Add(this.cbo_YARD_TYPE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_PROD_TYPE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cur_inv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbo_YARD_TYPE
            // 
            this.cbo_YARD_TYPE.Enabled = false;
            this.cbo_YARD_TYPE.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_YARD_TYPE.FormattingEnabled = true;
            this.cbo_YARD_TYPE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbo_YARD_TYPE.Location = new System.Drawing.Point(507, 18);
            this.cbo_YARD_TYPE.Name = "cbo_YARD_TYPE";
            this.cbo_YARD_TYPE.Size = new System.Drawing.Size(50, 22);
            this.cbo_YARD_TYPE.TabIndex = 477;
            this.cbo_YARD_TYPE.Tag = "跨号";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(426, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 476;
            this.label2.Text = "跨号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_PROD_TYPE
            // 
            this.cbo_PROD_TYPE.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PROD_TYPE.FormattingEnabled = true;
            this.cbo_PROD_TYPE.Location = new System.Drawing.Point(93, 20);
            this.cbo_PROD_TYPE.Name = "cbo_PROD_TYPE";
            this.cbo_PROD_TYPE.Size = new System.Drawing.Size(50, 22);
            this.cbo_PROD_TYPE.TabIndex = 475;
            this.cbo_PROD_TYPE.Tag = "产品";
            this.cbo_PROD_TYPE.SelectedValueChanged += new System.EventHandler(this.cbo_PROD_TYPE_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(177, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 7;
            this.label6.Tag = "f4";
            this.label6.Text = "堆放仓库";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cur_inv
            // 
            this.txt_cur_inv.Location = new System.Drawing.Point(264, 18);
            this.txt_cur_inv.Name = "txt_cur_inv";
            this.txt_cur_inv.Size = new System.Drawing.Size(124, 22);
            this.txt_cur_inv.sJoin = "";
            this.txt_cur_inv.sKey = "C0013";
            this.txt_cur_inv.sMax = 0;
            this.txt_cur_inv.TabIndex = 6;
            this.txt_cur_inv.Tag = "堆放仓库";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "产品";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 70);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 552);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2030C";
            this.Text = "标准垛位管理界面_CGA2030C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private CommonClass.F4COMR txt_cur_inv;
        private System.Windows.Forms.ComboBox cbo_YARD_TYPE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_PROD_TYPE;
    }
}
