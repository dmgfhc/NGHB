namespace CG
{
    partial class CGT2001C_POP
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.txt_thk = new System.Windows.Forms.TextBox();
            this.txt_wid = new System.Windows.Forms.TextBox();
            this.txt_len = new System.Windows.Forms.TextBox();
            this.txt_stlgrd = new System.Windows.Forms.TextBox();
            this.txt_spec = new System.Windows.Forms.TextBox();
            this.txt_cool1 = new System.Windows.Forms.TextBox();
            this.txt_cool2 = new System.Windows.Forms.TextBox();
            this.txt_date1 = new CommonClass.CeriUDate();
            this.txt_date2 = new CommonClass.CeriUDate();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 0);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1009, 622);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // txt_thk
            // 
            this.txt_thk.Location = new System.Drawing.Point(125, 13);
            this.txt_thk.Name = "txt_thk";
            this.txt_thk.Size = new System.Drawing.Size(30, 22);
            this.txt_thk.TabIndex = 4;
            // 
            // txt_wid
            // 
            this.txt_wid.Location = new System.Drawing.Point(161, 13);
            this.txt_wid.Name = "txt_wid";
            this.txt_wid.Size = new System.Drawing.Size(28, 22);
            this.txt_wid.TabIndex = 5;
            // 
            // txt_len
            // 
            this.txt_len.Location = new System.Drawing.Point(195, 13);
            this.txt_len.Name = "txt_len";
            this.txt_len.Size = new System.Drawing.Size(27, 22);
            this.txt_len.TabIndex = 6;
            // 
            // txt_stlgrd
            // 
            this.txt_stlgrd.Location = new System.Drawing.Point(228, 13);
            this.txt_stlgrd.Name = "txt_stlgrd";
            this.txt_stlgrd.Size = new System.Drawing.Size(24, 22);
            this.txt_stlgrd.TabIndex = 7;
            // 
            // txt_spec
            // 
            this.txt_spec.Location = new System.Drawing.Point(258, 13);
            this.txt_spec.Name = "txt_spec";
            this.txt_spec.Size = new System.Drawing.Size(27, 22);
            this.txt_spec.TabIndex = 8;
            // 
            // txt_cool1
            // 
            this.txt_cool1.Location = new System.Drawing.Point(291, 13);
            this.txt_cool1.Name = "txt_cool1";
            this.txt_cool1.Size = new System.Drawing.Size(27, 22);
            this.txt_cool1.TabIndex = 9;
            // 
            // txt_cool2
            // 
            this.txt_cool2.Location = new System.Drawing.Point(324, 13);
            this.txt_cool2.Name = "txt_cool2";
            this.txt_cool2.Size = new System.Drawing.Size(27, 22);
            this.txt_cool2.TabIndex = 10;
            // 
            // txt_date1
            // 
            this.txt_date1.Location = new System.Drawing.Point(12, 12);
            this.txt_date1.Name = "txt_date1";
            this.txt_date1.RawDate = "";
            this.txt_date1.Size = new System.Drawing.Size(45, 21);
            this.txt_date1.TabIndex = 11;
            // 
            // txt_date2
            // 
            this.txt_date2.Location = new System.Drawing.Point(63, 14);
            this.txt_date2.Name = "txt_date2";
            this.txt_date2.RawDate = "";
            this.txt_date2.Size = new System.Drawing.Size(45, 21);
            this.txt_date2.TabIndex = 12;
            // 
            // CGT2001C_POP
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.txt_date2);
            this.Controls.Add(this.txt_date1);
            this.Controls.Add(this.txt_cool2);
            this.Controls.Add(this.txt_cool1);
            this.Controls.Add(this.txt_spec);
            this.Controls.Add(this.txt_stlgrd);
            this.Controls.Add(this.txt_len);
            this.Controls.Add(this.txt_wid);
            this.Controls.Add(this.txt_thk);
            this.Name = "CGT2001C_POP";
            this.Text = "堆冷板坯详细信息_CGT2001C_POP";
            this.Load += new System.EventHandler(this.CGT2001C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
         public System.Windows.Forms.TextBox txt_thk;
         public System.Windows.Forms.TextBox txt_wid;
         public System.Windows.Forms.TextBox txt_len;
         public System.Windows.Forms.TextBox txt_stlgrd;
         public System.Windows.Forms.TextBox txt_spec;
         public System.Windows.Forms.TextBox txt_cool1;
         public System.Windows.Forms.TextBox txt_cool2;
         public CommonClass.CeriUDate txt_date1;
         public CommonClass.CeriUDate txt_date2;
    }
}
