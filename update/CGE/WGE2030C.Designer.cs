namespace CG
{
    partial class WGE2030C
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
            this.sdb_plate_cnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBO_YARD_TYPE = new System.Windows.Forms.ComboBox();
            this.CBO_ZONE_TYPE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_CUR_INV = new CommonClass.F4COMR();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sdb_plate_cnt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CBO_YARD_TYPE);
            this.groupBox1.Controls.Add(this.CBO_ZONE_TYPE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_CUR_INV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // sdb_plate_cnt
            // 
            this.sdb_plate_cnt.Location = new System.Drawing.Point(910, 20);
            this.sdb_plate_cnt.Name = "sdb_plate_cnt";
            this.sdb_plate_cnt.Size = new System.Drawing.Size(55, 22);
            this.sdb_plate_cnt.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(839, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "钢板总数";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_YARD_TYPE
            // 
            this.CBO_YARD_TYPE.Font = new System.Drawing.Font("宋体", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBO_YARD_TYPE.FormattingEnabled = true;
            this.CBO_YARD_TYPE.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.CBO_YARD_TYPE.Location = new System.Drawing.Point(491, 20);
            this.CBO_YARD_TYPE.Name = "CBO_YARD_TYPE";
            this.CBO_YARD_TYPE.Size = new System.Drawing.Size(43, 22);
            this.CBO_YARD_TYPE.TabIndex = 8;
            // 
            // CBO_ZONE_TYPE
            // 
            this.CBO_ZONE_TYPE.Font = new System.Drawing.Font("宋体", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_ZONE_TYPE.FormattingEnabled = true;
            this.CBO_ZONE_TYPE.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_ZONE_TYPE.Location = new System.Drawing.Point(535, 20);
            this.CBO_ZONE_TYPE.Name = "CBO_ZONE_TYPE";
            this.CBO_ZONE_TYPE.Size = new System.Drawing.Size(43, 22);
            this.CBO_ZONE_TYPE.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(420, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 4;
            this.label2.Tag = "f4";
            this.label2.Text = "跨/区";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Tag = "f4";
            this.label1.Text = "当前库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_CUR_INV
            // 
            this.CBO_CUR_INV.Location = new System.Drawing.Point(90, 20);
            this.CBO_CUR_INV.Name = "CBO_CUR_INV";
            this.CBO_CUR_INV.Size = new System.Drawing.Size(158, 22);
            this.CBO_CUR_INV.sJoin = "";
            this.CBO_CUR_INV.sKey = "";
            this.CBO_CUR_INV.sMax = 0;
            this.CBO_CUR_INV.TabIndex = 0;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 53);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 569);
            this.ss1.TabIndex = 3;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ss1_Sheet1.ColumnCount = 0;
            this.ss1_Sheet1.ColumnHeader.RowCount = 0;
            this.ss1_Sheet1.RowCount = 0;
            this.ss1_Sheet1.ActiveColumnIndex = -1;
            this.ss1_Sheet1.ActiveRowIndex = -1;
            this.ss1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // WGE2030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGE2030C";
            this.Text = "钢板库库图现状查询_WGE2030C";
            this.Load += new System.EventHandler(this.WGE2030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4COMR CBO_CUR_INV;
        private System.Windows.Forms.ComboBox CBO_YARD_TYPE;
        private System.Windows.Forms.ComboBox CBO_ZONE_TYPE;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox sdb_plate_cnt;
        private System.Windows.Forms.Label label13;
    }
}
