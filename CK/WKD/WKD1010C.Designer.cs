namespace CK
{
    partial class WKD1010C
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
            this.txt_plt = new System.Windows.Forms.TextBox();
            this.txt_stlgrd = new System.Windows.Forms.TextBox();
            this.cbo_grp_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.txt_stl_group = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.txt_stl_group);
            this.groupBox1.Controls.Add(this.txt_stlgrd);
            this.groupBox1.Controls.Add(this.cbo_grp_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_plt
            // 
            this.txt_plt.Location = new System.Drawing.Point(94, 14);
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.ReadOnly = true;
            this.txt_plt.Size = new System.Drawing.Size(46, 22);
            this.txt_plt.TabIndex = 8;
            this.txt_plt.Text = "C2";
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_stlgrd
            // 
            this.txt_stlgrd.Location = new System.Drawing.Point(664, 14);
            this.txt_stlgrd.Name = "txt_stlgrd";
            this.txt_stlgrd.Size = new System.Drawing.Size(207, 22);
            this.txt_stlgrd.TabIndex = 8;
            // 
            // cbo_grp_type
            // 
            this.cbo_grp_type.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_grp_type.FormattingEnabled = true;
            this.cbo_grp_type.Items.AddRange(new object[] {
            "T",
            "M"});
            this.cbo_grp_type.Location = new System.Drawing.Point(246, 14);
            this.cbo_grp_type.Name = "cbo_grp_type";
            this.cbo_grp_type.Size = new System.Drawing.Size(46, 22);
            this.cbo_grp_type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(570, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "钢种";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(164, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(332, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "钢种组";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "工厂代码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 603);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1080, 582);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // txt_stl_group
            // 
            this.txt_stl_group.Location = new System.Drawing.Point(414, 14);
            this.txt_stl_group.Name = "txt_stl_group";
            this.txt_stl_group.Size = new System.Drawing.Size(133, 22);
            this.txt_stl_group.TabIndex = 8;
            // 
            // WKD1010C
            // 
            this.ClientSize = new System.Drawing.Size(1086, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WKD1010C";
            this.Text = "钢种组维护_WKD1010C";
            this.Load += new System.EventHandler(this.WKD1010C_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stlgrd;
        private System.Windows.Forms.ComboBox cbo_grp_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_plt;
        private System.Windows.Forms.TextBox txt_stl_group;
    }
}
