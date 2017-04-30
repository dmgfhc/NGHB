namespace CG
{
    partial class WGT1060C
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
            this.txt_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_OUT_SHEET_NO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_THK_TO = new System.Windows.Forms.TextBox();
            this.txt_THK_FR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_STDSPEC = new System.Windows.Forms.TextBox();
            this.lab_Std_No = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DATE_TO = new CommonClass.CeriUDate();
            this.dtp_DATE_FR = new CommonClass.CeriUDate();
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
            this.groupBox1.Controls.Add(this.txt_PLATE_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_OUT_SHEET_NO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_THK_TO);
            this.groupBox1.Controls.Add(this.txt_THK_FR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_STDSPEC);
            this.groupBox1.Controls.Add(this.lab_Std_No);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_DATE_TO);
            this.groupBox1.Controls.Add(this.dtp_DATE_FR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_PLATE_NO
            // 
            this.txt_PLATE_NO.Location = new System.Drawing.Point(99, 55);
            this.txt_PLATE_NO.MaxLength = 14;
            this.txt_PLATE_NO.Name = "txt_PLATE_NO";
            this.txt_PLATE_NO.Size = new System.Drawing.Size(98, 22);
            this.txt_PLATE_NO.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 45;
            this.label5.Tag = "";
            this.label5.Text = "钢板号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_OUT_SHEET_NO
            // 
            this.txt_OUT_SHEET_NO.Location = new System.Drawing.Point(411, 19);
            this.txt_OUT_SHEET_NO.MaxLength = 14;
            this.txt_OUT_SHEET_NO.Name = "txt_OUT_SHEET_NO";
            this.txt_OUT_SHEET_NO.Size = new System.Drawing.Size(98, 22);
            this.txt_OUT_SHEET_NO.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(325, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 43;
            this.label4.Tag = "";
            this.label4.Text = "轧批号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 42;
            this.label3.Tag = "user";
            this.label3.Text = "~";
            // 
            // txt_THK_TO
            // 
            this.txt_THK_TO.Location = new System.Drawing.Point(915, 19);
            this.txt_THK_TO.MaxLength = 3;
            this.txt_THK_TO.Name = "txt_THK_TO";
            this.txt_THK_TO.Size = new System.Drawing.Size(82, 22);
            this.txt_THK_TO.TabIndex = 39;
            // 
            // txt_THK_FR
            // 
            this.txt_THK_FR.Location = new System.Drawing.Point(807, 19);
            this.txt_THK_FR.MaxLength = 3;
            this.txt_THK_FR.Name = "txt_THK_FR";
            this.txt_THK_FR.Size = new System.Drawing.Size(82, 22);
            this.txt_THK_FR.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(722, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "厚度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_STDSPEC
            // 
            this.txt_STDSPEC.Location = new System.Drawing.Point(610, 20);
            this.txt_STDSPEC.MaxLength = 50;
            this.txt_STDSPEC.Name = "txt_STDSPEC";
            this.txt_STDSPEC.Size = new System.Drawing.Size(98, 22);
            this.txt_STDSPEC.TabIndex = 31;
            // 
            // lab_Std_No
            // 
            this.lab_Std_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Std_No.Location = new System.Drawing.Point(524, 19);
            this.lab_Std_No.Name = "lab_Std_No";
            this.lab_Std_No.Size = new System.Drawing.Size(82, 21);
            this.lab_Std_No.TabIndex = 30;
            this.lab_Std_No.Tag = "";
            this.lab_Std_No.Text = "标准号";
            this.lab_Std_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // dtp_DATE_TO
            // 
            this.dtp_DATE_TO.Location = new System.Drawing.Point(221, 18);
            this.dtp_DATE_TO.Name = "dtp_DATE_TO";
            this.dtp_DATE_TO.RawDate = "";
            this.dtp_DATE_TO.Size = new System.Drawing.Size(98, 21);
            this.dtp_DATE_TO.TabIndex = 3;
            // 
            // dtp_DATE_FR
            // 
            this.dtp_DATE_FR.Location = new System.Drawing.Point(99, 18);
            this.dtp_DATE_FR.Name = "dtp_DATE_FR";
            this.dtp_DATE_FR.RawDate = "";
            this.dtp_DATE_FR.Size = new System.Drawing.Size(98, 21);
            this.dtp_DATE_FR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 532);
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
            this.ss1.Size = new System.Drawing.Size(1356, 511);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT1060C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT1060C";
            this.Text = "剪切前当班取样项目查询界面_WGT1060C";
            this.Load += new System.EventHandler(this.WGT1060C_Load);
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
        private CommonClass.CeriUDate dtp_DATE_TO;
        private CommonClass.CeriUDate dtp_DATE_FR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_THK_FR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_STDSPEC;
        private System.Windows.Forms.Label lab_Std_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_THK_TO;
        private System.Windows.Forms.TextBox txt_OUT_SHEET_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PLATE_NO;
        private System.Windows.Forms.Label label5;
    }
}
