namespace CG
{
    partial class CGA2120C
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
            this.cbo_Group = new System.Windows.Forms.ComboBox();
            this.cbo_Shift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mill_to_Time = new CommonClass.CeriUDate();
            this.txt_mill_Time = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Occr_Time_To = new CommonClass.CeriUDate();
            this.txt_Occr_Time = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SlabNo = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Group);
            this.groupBox1.Controls.Add(this.cbo_Shift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_mill_to_Time);
            this.groupBox1.Controls.Add(this.txt_mill_Time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Occr_Time_To);
            this.groupBox1.Controls.Add(this.txt_Occr_Time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SlabNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbo_Group
            // 
            this.cbo_Group.FormattingEnabled = true;
            this.cbo_Group.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbo_Group.Location = new System.Drawing.Point(1046, 18);
            this.cbo_Group.Name = "cbo_Group";
            this.cbo_Group.Size = new System.Drawing.Size(53, 21);
            this.cbo_Group.TabIndex = 589;
            // 
            // cbo_Shift
            // 
            this.cbo_Shift.FormattingEnabled = true;
            this.cbo_Shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_Shift.Location = new System.Drawing.Point(920, 18);
            this.cbo_Shift.Name = "cbo_Shift";
            this.cbo_Shift.Size = new System.Drawing.Size(51, 21);
            this.cbo_Shift.TabIndex = 590;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(851, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 587;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(977, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 588;
            this.label5.Text = "班别";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mill_to_Time
            // 
            this.txt_mill_to_Time.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_mill_to_Time.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_mill_to_Time.Location = new System.Drawing.Point(732, 18);
            this.txt_mill_to_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mill_to_Time.Name = "txt_mill_to_Time";
            this.txt_mill_to_Time.RawDate = "";
            this.txt_mill_to_Time.Size = new System.Drawing.Size(112, 24);
            this.txt_mill_to_Time.TabIndex = 586;
            this.txt_mill_to_Time.Tag = "结束时间";
            // 
            // txt_mill_Time
            // 
            this.txt_mill_Time.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_mill_Time.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_mill_Time.Location = new System.Drawing.Point(618, 18);
            this.txt_mill_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mill_Time.Name = "txt_mill_Time";
            this.txt_mill_Time.RawDate = "";
            this.txt_mill_Time.Size = new System.Drawing.Size(108, 24);
            this.txt_mill_Time.TabIndex = 585;
            this.txt_mill_Time.Tag = "开始时间";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(526, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 584;
            this.label1.Text = "轧制时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Occr_Time_To
            // 
            this.txt_Occr_Time_To.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_Occr_Time_To.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Occr_Time_To.Location = new System.Drawing.Point(407, 18);
            this.txt_Occr_Time_To.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Occr_Time_To.Name = "txt_Occr_Time_To";
            this.txt_Occr_Time_To.RawDate = "";
            this.txt_Occr_Time_To.Size = new System.Drawing.Size(112, 24);
            this.txt_Occr_Time_To.TabIndex = 583;
            this.txt_Occr_Time_To.Tag = "结束时间";
            // 
            // txt_Occr_Time
            // 
            this.txt_Occr_Time.Font = new System.Drawing.Font("宋体", 11F);
            this.txt_Occr_Time.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Occr_Time.Location = new System.Drawing.Point(293, 18);
            this.txt_Occr_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Occr_Time.Name = "txt_Occr_Time";
            this.txt_Occr_Time.RawDate = "";
            this.txt_Occr_Time.Size = new System.Drawing.Size(108, 24);
            this.txt_Occr_Time.TabIndex = 582;
            this.txt_Occr_Time.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 581;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SlabNo
            // 
            this.txt_SlabNo.Location = new System.Drawing.Point(93, 18);
            this.txt_SlabNo.MaxLength = 10;
            this.txt_SlabNo.Name = "txt_SlabNo";
            this.txt_SlabNo.Size = new System.Drawing.Size(102, 22);
            this.txt_SlabNo.TabIndex = 1;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 56);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1129, 566);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2120C
            // 
            this.ClientSize = new System.Drawing.Size(1129, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2120C";
            this.Text = "板坯产出实绩查询界面_CGA2120C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SlabNo;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label2;
        public CommonClass.CeriUDate txt_mill_to_Time;
        public CommonClass.CeriUDate txt_mill_Time;
        private System.Windows.Forms.Label label1;
        public CommonClass.CeriUDate txt_Occr_Time_To;
        public CommonClass.CeriUDate txt_Occr_Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Group;
        private System.Windows.Forms.ComboBox cbo_Shift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
