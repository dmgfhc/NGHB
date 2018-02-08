namespace CK
{
    partial class CKP1310C
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
            this.Cmd_Edit = new System.Windows.Forms.Button();
            this.txt_DATE = new CommonClass.CeriUDate();
            this.TXT_CH_CD = new System.Windows.Forms.TextBox();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ss3 = new FarPoint.Win.Spread.FpSpread();
            this.ss3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmd_Edit);
            this.groupBox1.Controls.Add(this.txt_DATE);
            this.groupBox1.Controls.Add(this.TXT_CH_CD);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Cmd_Edit
            // 
            this.Cmd_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmd_Edit.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_Edit.Location = new System.Drawing.Point(526, 18);
            this.Cmd_Edit.Name = "Cmd_Edit";
            this.Cmd_Edit.Size = new System.Drawing.Size(87, 28);
            this.Cmd_Edit.TabIndex = 5;
            this.Cmd_Edit.Text = "更新数据";
            this.Cmd_Edit.UseVisualStyleBackColor = true;
            this.Cmd_Edit.Click += new System.EventHandler(this.Cmd_Edit_Click);
            // 
            // txt_DATE
            // 
            this.txt_DATE.Location = new System.Drawing.Point(107, 18);
            this.txt_DATE.Name = "txt_DATE";
            this.txt_DATE.RawDate = "";
            this.txt_DATE.Size = new System.Drawing.Size(97, 21);
            this.txt_DATE.TabIndex = 4;
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
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "日期";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1003, 167);
            this.ss1.TabIndex = 3;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ss1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.White;
            this.ss1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ss1_Sheet1.DefaultStyle.Parent = "DataAreaDefault";
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 235);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1009, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 198);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "ss2, Sheet1, Row 0, Column 0, ";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1003, 177);
            this.ss2.TabIndex = 3;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 436);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1009, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ss3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1009, 183);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // ss3
            // 
            this.ss3.AccessibleDescription = "ss2, Sheet1, Row 0, Column 0, ";
            this.ss3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss3.Location = new System.Drawing.Point(3, 18);
            this.ss3.Name = "ss3";
            this.ss3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss3_Sheet1});
            this.ss3.Size = new System.Drawing.Size(1003, 162);
            this.ss3.TabIndex = 4;
            // 
            // ss3_Sheet1
            // 
            this.ss3_Sheet1.Reset();
            this.ss3_Sheet1.SheetName = "Sheet1";
            // 
            // CKP1310C
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CKP1310C";
            this.Text = "中板厂生产日报_CKP1310C";
            this.Load += new System.EventHandler(this.CKP1310C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.TextBox TXT_CH_CD;
        private CommonClass.CeriUDate txt_DATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox4;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Button Cmd_Edit;
        private FarPoint.Win.Spread.FpSpread ss3;
        private FarPoint.Win.Spread.SheetView ss3_Sheet1;
    }
}
