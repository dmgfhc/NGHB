namespace CG
{
    partial class WGT2030C
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
            this.ACT_PRODUCE_PLT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ACT_CUT_PLT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mat_no = new System.Windows.Forms.TextBox();
            this.cbo_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.物料号 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdt_wrk_date_to = new CommonClass.CeriUDate();
            this.sdt_wrk_date_fr = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ACT_PRODUCE_PLT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ACT_CUT_PLT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mat_no);
            this.groupBox1.Controls.Add(this.cbo_group);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.物料号);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sdt_wrk_date_to);
            this.groupBox1.Controls.Add(this.sdt_wrk_date_fr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ACT_PRODUCE_PLT
            // 
            this.ACT_PRODUCE_PLT.FormattingEnabled = true;
            this.ACT_PRODUCE_PLT.Items.AddRange(new object[] {
            "",
            "C1",
            "C2",
            "C3"});
            this.ACT_PRODUCE_PLT.Location = new System.Drawing.Point(811, 19);
            this.ACT_PRODUCE_PLT.Name = "ACT_PRODUCE_PLT";
            this.ACT_PRODUCE_PLT.Size = new System.Drawing.Size(57, 21);
            this.ACT_PRODUCE_PLT.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(730, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "生产工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACT_CUT_PLT
            // 
            this.ACT_CUT_PLT.FormattingEnabled = true;
            this.ACT_CUT_PLT.Items.AddRange(new object[] {
            "",
            "C1",
            "C2",
            "C3"});
            this.ACT_CUT_PLT.Location = new System.Drawing.Point(648, 18);
            this.ACT_CUT_PLT.Name = "ACT_CUT_PLT";
            this.ACT_CUT_PLT.Size = new System.Drawing.Size(57, 21);
            this.ACT_CUT_PLT.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(568, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "切割工厂";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mat_no
            // 
            this.txt_mat_no.Location = new System.Drawing.Point(426, 18);
            this.txt_mat_no.Name = "txt_mat_no";
            this.txt_mat_no.Size = new System.Drawing.Size(112, 22);
            this.txt_mat_no.TabIndex = 19;
            // 
            // cbo_group
            // 
            this.cbo_group.FormattingEnabled = true;
            this.cbo_group.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.cbo_group.Location = new System.Drawing.Point(1134, 19);
            this.cbo_group.Name = "cbo_group";
            this.cbo_group.Size = new System.Drawing.Size(57, 21);
            this.cbo_group.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1054, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_shift
            // 
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(978, 19);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(57, 21);
            this.cbo_shift.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(898, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "班次";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 物料号
            // 
            this.物料号.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.物料号.Location = new System.Drawing.Point(345, 18);
            this.物料号.Name = "物料号";
            this.物料号.Size = new System.Drawing.Size(79, 21);
            this.物料号.TabIndex = 13;
            this.物料号.Tag = "";
            this.物料号.Text = "物料号";
            this.物料号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // sdt_wrk_date_to
            // 
            this.sdt_wrk_date_to.Location = new System.Drawing.Point(221, 18);
            this.sdt_wrk_date_to.Name = "sdt_wrk_date_to";
            this.sdt_wrk_date_to.RawDate = "";
            this.sdt_wrk_date_to.Size = new System.Drawing.Size(98, 21);
            this.sdt_wrk_date_to.TabIndex = 3;
            // 
            // sdt_wrk_date_fr
            // 
            this.sdt_wrk_date_fr.Location = new System.Drawing.Point(99, 18);
            this.sdt_wrk_date_fr.Name = "sdt_wrk_date_fr";
            this.sdt_wrk_date_fr.RawDate = "";
            this.sdt_wrk_date_fr.Size = new System.Drawing.Size(98, 21);
            this.sdt_wrk_date_fr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "作业日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 572);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.AllowCellOverflow = true;
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1356, 551);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT2030C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT2030C";
            this.Text = "火剪切实绩查询及修改界面_WGT2030C";
            this.Load += new System.EventHandler(this.WGT2030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate sdt_wrk_date_to;
        private CommonClass.CeriUDate sdt_wrk_date_fr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 物料号;
        private System.Windows.Forms.ComboBox cbo_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mat_no;
        private System.Windows.Forms.ComboBox ACT_PRODUCE_PLT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ACT_CUT_PLT;
        private System.Windows.Forms.Label label4;
    }
}
