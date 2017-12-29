namespace CG
{
    partial class CGT2001C
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_Cond5 = new System.Windows.Forms.CheckBox();
            this.chk_Cond4 = new System.Windows.Forms.CheckBox();
            this.chk_Cond3 = new System.Windows.Forms.CheckBox();
            this.chk_Cond2 = new System.Windows.Forms.CheckBox();
            this.chk_Cond1 = new System.Windows.Forms.CheckBox();
            this.txt_cool3 = new System.Windows.Forms.TextBox();
            this.txt_cool2 = new System.Windows.Forms.TextBox();
            this.txt_cool1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ud_ch_date2 = new CommonClass.CeriUDate();
            this.ud_ch_date1 = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_cool3);
            this.groupBox1.Controls.Add(this.txt_cool2);
            this.groupBox1.Controls.Add(this.txt_cool1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ud_ch_date2);
            this.groupBox1.Controls.Add(this.ud_ch_date1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Cond5);
            this.groupBox2.Controls.Add(this.chk_Cond4);
            this.groupBox2.Controls.Add(this.chk_Cond3);
            this.groupBox2.Controls.Add(this.chk_Cond2);
            this.groupBox2.Controls.Add(this.chk_Cond1);
            this.groupBox2.Location = new System.Drawing.Point(686, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "汇总字段";
            // 
            // chk_Cond5
            // 
            this.chk_Cond5.AutoSize = true;
            this.chk_Cond5.Location = new System.Drawing.Point(386, 21);
            this.chk_Cond5.Name = "chk_Cond5";
            this.chk_Cond5.Size = new System.Drawing.Size(78, 17);
            this.chk_Cond5.TabIndex = 4;
            this.chk_Cond5.Text = "订单标准";
            this.chk_Cond5.UseVisualStyleBackColor = true;
            this.chk_Cond5.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chk_Cond4
            // 
            this.chk_Cond4.AutoSize = true;
            this.chk_Cond4.Location = new System.Drawing.Point(291, 21);
            this.chk_Cond4.Name = "chk_Cond4";
            this.chk_Cond4.Size = new System.Drawing.Size(78, 17);
            this.chk_Cond4.TabIndex = 3;
            this.chk_Cond4.Text = "板坯长度";
            this.chk_Cond4.UseVisualStyleBackColor = true;
            this.chk_Cond4.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chk_Cond3
            // 
            this.chk_Cond3.AutoSize = true;
            this.chk_Cond3.Location = new System.Drawing.Point(196, 21);
            this.chk_Cond3.Name = "chk_Cond3";
            this.chk_Cond3.Size = new System.Drawing.Size(78, 17);
            this.chk_Cond3.TabIndex = 2;
            this.chk_Cond3.Text = "板坯宽度";
            this.chk_Cond3.UseVisualStyleBackColor = true;
            this.chk_Cond3.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chk_Cond2
            // 
            this.chk_Cond2.AutoSize = true;
            this.chk_Cond2.Location = new System.Drawing.Point(101, 21);
            this.chk_Cond2.Name = "chk_Cond2";
            this.chk_Cond2.Size = new System.Drawing.Size(78, 17);
            this.chk_Cond2.TabIndex = 1;
            this.chk_Cond2.Text = "板坯厚度";
            this.chk_Cond2.UseVisualStyleBackColor = true;
            this.chk_Cond2.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // chk_Cond1
            // 
            this.chk_Cond1.AutoSize = true;
            this.chk_Cond1.Location = new System.Drawing.Point(6, 21);
            this.chk_Cond1.Name = "chk_Cond1";
            this.chk_Cond1.Size = new System.Drawing.Size(78, 17);
            this.chk_Cond1.TabIndex = 0;
            this.chk_Cond1.Text = "板坯钢种";
            this.chk_Cond1.UseVisualStyleBackColor = true;
            this.chk_Cond1.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // txt_cool3
            // 
            this.txt_cool3.Location = new System.Drawing.Point(353, 48);
            this.txt_cool3.Name = "txt_cool3";
            this.txt_cool3.Size = new System.Drawing.Size(96, 22);
            this.txt_cool3.TabIndex = 12;
            this.txt_cool3.TextChanged += new System.EventHandler(this.txt_cool1_TextChanged);
            // 
            // txt_cool2
            // 
            this.txt_cool2.Location = new System.Drawing.Point(234, 48);
            this.txt_cool2.Name = "txt_cool2";
            this.txt_cool2.Size = new System.Drawing.Size(96, 22);
            this.txt_cool2.TabIndex = 11;
            this.txt_cool2.TextChanged += new System.EventHandler(this.txt_cool1_TextChanged);
            // 
            // txt_cool1
            // 
            this.txt_cool1.Location = new System.Drawing.Point(121, 49);
            this.txt_cool1.Name = "txt_cool1";
            this.txt_cool1.Size = new System.Drawing.Size(96, 22);
            this.txt_cool1.TabIndex = 10;
            this.txt_cool1.TextChanged += new System.EventHandler(this.txt_cool1_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "堆冷时间范围";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ud_ch_date2
            // 
            this.ud_ch_date2.Location = new System.Drawing.Point(233, 18);
            this.ud_ch_date2.Name = "ud_ch_date2";
            this.ud_ch_date2.RawDate = "";
            this.ud_ch_date2.Size = new System.Drawing.Size(97, 21);
            this.ud_ch_date2.TabIndex = 7;
            // 
            // ud_ch_date1
            // 
            this.ud_ch_date1.Location = new System.Drawing.Point(120, 18);
            this.ud_ch_date1.Name = "ud_ch_date1";
            this.ud_ch_date1.RawDate = "";
            this.ud_ch_date1.Size = new System.Drawing.Size(97, 21);
            this.ud_ch_date1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(24, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(90, 21);
            this.ULabel5.TabIndex = 5;
            this.ULabel5.Text = "装炉时间";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 84);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 538);
            this.ss1.TabIndex = 1;
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellDoubleClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2001C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2001C";
            this.Text = "堆冷时间统计报表_CGT2001C";
            this.Load += new System.EventHandler(this.CGT2001C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox txt_cool3;
        private System.Windows.Forms.TextBox txt_cool2;
        private System.Windows.Forms.TextBox txt_cool1;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate ud_ch_date2;
        private CommonClass.CeriUDate ud_ch_date1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Cond5;
        private System.Windows.Forms.CheckBox chk_Cond4;
        private System.Windows.Forms.CheckBox chk_Cond3;
        private System.Windows.Forms.CheckBox chk_Cond2;
        private System.Windows.Forms.CheckBox chk_Cond1;
    }
}
