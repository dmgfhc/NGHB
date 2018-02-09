namespace CK
{
    partial class AKW2080C
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
            this.Chk_ss2 = new System.Windows.Forms.CheckBox();
            this.TXT_OCCR_TIME = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_PRC = new System.Windows.Forms.ComboBox();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.Chk_ss2);
            this.groupbox1.Controls.Add(this.TXT_OCCR_TIME);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.CBO_SHIFT);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.CBO_PRC);
            this.groupbox1.Controls.Add(this.ULabel5);
            this.groupbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox1.Location = new System.Drawing.Point(0, 0);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(1144, 59);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            // 
            // Chk_ss2
            // 
            this.Chk_ss2.AutoSize = true;
            this.Chk_ss2.Location = new System.Drawing.Point(707, 22);
            this.Chk_ss2.Name = "Chk_ss2";
            this.Chk_ss2.Size = new System.Drawing.Size(78, 17);
            this.Chk_ss2.TabIndex = 6;
            this.Chk_ss2.Text = "班别查询";
            this.Chk_ss2.UseVisualStyleBackColor = true;
            // 
            // TXT_OCCR_TIME
            // 
            this.TXT_OCCR_TIME.Location = new System.Drawing.Point(518, 18);
            this.TXT_OCCR_TIME.Name = "TXT_OCCR_TIME";
            this.TXT_OCCR_TIME.RawDate = "";
            this.TXT_OCCR_TIME.Size = new System.Drawing.Size(95, 21);
            this.TXT_OCCR_TIME.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(427, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "查询时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(307, 18);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(69, 21);
            this.CBO_SHIFT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "班次";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_PRC
            // 
            this.CBO_PRC.FormattingEnabled = true;
            this.CBO_PRC.Items.AddRange(new object[] {
            "B1",
            "C1",
            "C3"});
            this.CBO_PRC.Location = new System.Drawing.Point(121, 18);
            this.CBO_PRC.Name = "CBO_PRC";
            this.CBO_PRC.Size = new System.Drawing.Size(69, 21);
            this.CBO_PRC.TabIndex = 1;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(84, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "工序";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(0, 59);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1144, 203);
            this.ss1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 262);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1144, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss2.Location = new System.Drawing.Point(0, 265);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1144, 203);
            this.ss2.TabIndex = 3;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // AKW2080C
            // 
            this.ClientSize = new System.Drawing.Size(1144, 622);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupbox1);
            this.Name = "AKW2080C";
            this.Text = "班别管理_AKW2080C";
            this.Load += new System.EventHandler(this.AKW2080C_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label ULabel5;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private System.Windows.Forms.Splitter splitter1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.ComboBox CBO_PRC;
        private CommonClass.CeriUDate TXT_OCCR_TIME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Chk_ss2;
    }
}
