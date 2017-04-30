namespace CG
{
    partial class CGA2011C
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
            this.chk_htm = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_nolocation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cur_inv = new CommonClass.F4COMR();
            this.txt_prod_cd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mat_no = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_htm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_nolocation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cur_inv);
            this.groupBox1.Controls.Add(this.txt_prod_cd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_mat_no);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chk_htm
            // 
            this.chk_htm.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_htm.Enabled = false;
            this.chk_htm.Location = new System.Drawing.Point(528, 53);
            this.chk_htm.Name = "chk_htm";
            this.chk_htm.Size = new System.Drawing.Size(20, 22);
            this.chk_htm.TabIndex = 474;
            this.chk_htm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_htm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(441, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 473;
            this.label3.Text = "热处理车间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(441, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "物料编号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_nolocation
            // 
            this.chk_nolocation.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_nolocation.Location = new System.Drawing.Point(276, 53);
            this.chk_nolocation.Name = "chk_nolocation";
            this.chk_nolocation.Size = new System.Drawing.Size(20, 22);
            this.chk_nolocation.TabIndex = 471;
            this.chk_nolocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chk_nolocation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(189, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "临时垛位号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(88, 52);
            this.txt_location.MaxLength = 7;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(99, 22);
            this.txt_location.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "垛位号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(189, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 7;
            this.label6.Tag = "f4";
            this.label6.Text = "堆放仓库";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cur_inv
            // 
            this.txt_cur_inv.Location = new System.Drawing.Point(276, 18);
            this.txt_cur_inv.Name = "txt_cur_inv";
            this.txt_cur_inv.Size = new System.Drawing.Size(124, 22);
            this.txt_cur_inv.sJoin = "";
            this.txt_cur_inv.sKey = "C0013";
            this.txt_cur_inv.sMax = 0;
            this.txt_cur_inv.TabIndex = 6;
            // 
            // txt_prod_cd
            // 
            this.txt_prod_cd.Enabled = false;
            this.txt_prod_cd.Location = new System.Drawing.Point(88, 21);
            this.txt_prod_cd.MaxLength = 10;
            this.txt_prod_cd.Name = "txt_prod_cd";
            this.txt_prod_cd.Size = new System.Drawing.Size(30, 22);
            this.txt_prod_cd.TabIndex = 5;
            this.txt_prod_cd.Text = "SL";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "产品";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mat_no
            // 
            this.txt_mat_no.Location = new System.Drawing.Point(528, 18);
            this.txt_mat_no.MaxLength = 12;
            this.txt_mat_no.Name = "txt_mat_no";
            this.txt_mat_no.Size = new System.Drawing.Size(102, 22);
            this.txt_mat_no.TabIndex = 1;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 86);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 536);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2011C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2011C";
            this.Text = "板坯垛位修改及查询界面_CGA2011C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mat_no;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox txt_prod_cd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private CommonClass.F4COMR txt_cur_inv;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk_nolocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_htm;
        private System.Windows.Forms.Label label3;
    }
}
