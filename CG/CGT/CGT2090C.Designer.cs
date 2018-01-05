namespace CG
{
    partial class CGT2090C
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
            this.txt_to_heat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_from_heat = new System.Windows.Forms.TextBox();
            this.udToDate = new CommonClass.CeriUDate();
            this.udFmDate = new CommonClass.CeriUDate();
            this.TXT_CH_CD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_to_heat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_from_heat);
            this.groupBox1.Controls.Add(this.udToDate);
            this.groupBox1.Controls.Add(this.udFmDate);
            this.groupBox1.Controls.Add(this.TXT_CH_CD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_to_heat
            // 
            this.txt_to_heat.Location = new System.Drawing.Point(548, 18);
            this.txt_to_heat.MaxLength = 8;
            this.txt_to_heat.Name = "txt_to_heat";
            this.txt_to_heat.Size = new System.Drawing.Size(83, 22);
            this.txt_to_heat.TabIndex = 223;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 222;
            this.label1.Tag = "user";
            this.label1.Text = "~";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(353, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 221;
            this.label8.Text = "炉号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_from_heat
            // 
            this.txt_from_heat.Location = new System.Drawing.Point(439, 18);
            this.txt_from_heat.MaxLength = 8;
            this.txt_from_heat.Name = "txt_from_heat";
            this.txt_from_heat.Size = new System.Drawing.Size(83, 22);
            this.txt_from_heat.TabIndex = 220;
            // 
            // udToDate
            // 
            this.udToDate.Location = new System.Drawing.Point(220, 18);
            this.udToDate.Name = "udToDate";
            this.udToDate.RawDate = "";
            this.udToDate.Size = new System.Drawing.Size(97, 21);
            this.udToDate.TabIndex = 4;
            // 
            // udFmDate
            // 
            this.udFmDate.Location = new System.Drawing.Point(107, 18);
            this.udFmDate.Name = "udFmDate";
            this.udFmDate.RawDate = "";
            this.udFmDate.Size = new System.Drawing.Size(97, 21);
            this.udFmDate.TabIndex = 4;
            // 
            // TXT_CH_CD
            // 
            this.TXT_CH_CD.Location = new System.Drawing.Point(989, 18);
            this.TXT_CH_CD.Name = "TXT_CH_CD";
            this.TXT_CH_CD.Size = new System.Drawing.Size(18, 22);
            this.TXT_CH_CD.TabIndex = 2;
            this.TXT_CH_CD.Text = "C";
            this.TXT_CH_CD.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "检测时间";
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
            this.ss1.Size = new System.Drawing.Size(1009, 563);
            this.ss1.TabIndex = 1;
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellDoubleClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2090C
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2090C";
            this.Text = "板坯未热装原因查询及录入_CGT2090C";
            this.Load += new System.EventHandler(this.CGT2090C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.Label label2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox TXT_CH_CD;
        private CommonClass.CeriUDate udFmDate;
        private CommonClass.CeriUDate udToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_from_heat;
        private System.Windows.Forms.TextBox txt_to_heat;
        private System.Windows.Forms.Label label1;
    }
}
