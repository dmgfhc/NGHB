namespace CK
{
    partial class AKT1030C
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.CBO_PRC = new System.Windows.Forms.ComboBox();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.CBO_PRC);
            this.groupbox1.Controls.Add(this.CBO_PLT);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.ULabel5);
            this.groupbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox1.Location = new System.Drawing.Point(0, 0);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(1144, 59);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            // 
            // CBO_PRC
            // 
            this.CBO_PRC.FormattingEnabled = true;
            this.CBO_PRC.Items.AddRange(new object[] {
            "CA",
            "CB",
            "CC",
            "CD",
            "CE",
            "CF",
            "CG"});
            this.CBO_PRC.Location = new System.Drawing.Point(341, 18);
            this.CBO_PRC.Name = "CBO_PRC";
            this.CBO_PRC.Size = new System.Drawing.Size(70, 21);
            this.CBO_PRC.TabIndex = 3;
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C1",
            "B1"});
            this.CBO_PLT.Location = new System.Drawing.Point(120, 18);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(78, 21);
            this.CBO_PLT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "工序代码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(84, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "区域代码";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 59);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1144, 563);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // AKT1030C
            // 
            this.ClientSize = new System.Drawing.Size(1144, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupbox1);
            this.Name = "AKT1030C";
            this.Text = "JOBS 运行状态_AKT1030C";
            this.Load += new System.EventHandler(this.AKT1030C_Load);
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label ULabel5;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_PRC;
    }
}
