namespace CG
{
    partial class WGB1050C
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
            this.udt_prod_date = new CommonClass.CeriUDate();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.txt_mill_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_bed_cd = new System.Windows.Forms.TextBox();
            this.txt_emp_cd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bed_fl = new System.Windows.Forms.TextBox();
            this.listb_bed_fl = new System.Windows.Forms.ListBox();
            this.sdb_cb_temp = new CommonClass.NumBox();
            this.mdt_cb_time = new CommonClass.MaskedDate();
            this.lab_bed_temp = new System.Windows.Forms.Label();
            this.lab_bed_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_bed_cd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_bed_cd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udt_prod_date);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.txt_mill_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // udt_prod_date
            // 
            this.udt_prod_date.Location = new System.Drawing.Point(132, 14);
            this.udt_prod_date.Name = "udt_prod_date";
            this.udt_prod_date.RawDate = "";
            this.udt_prod_date.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date.TabIndex = 65;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(459, 14);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(53, 22);
            this.cbo_shift.TabIndex = 64;
            // 
            // txt_mill_no
            // 
            this.txt_mill_no.Location = new System.Drawing.Point(645, 14);
            this.txt_mill_no.MaxLength = 12;
            this.txt_mill_no.Name = "txt_mill_no";
            this.txt_mill_no.Size = new System.Drawing.Size(100, 22);
            this.txt_mill_no.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(363, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "班次";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "生产日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(549, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "物料号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_bed_cd);
            this.groupBox2.Controls.Add(this.txt_emp_cd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_bed_fl);
            this.groupBox2.Controls.Add(this.listb_bed_fl);
            this.groupBox2.Controls.Add(this.sdb_cb_temp);
            this.groupBox2.Controls.Add(this.mdt_cb_time);
            this.groupBox2.Controls.Add(this.lab_bed_temp);
            this.groupBox2.Controls.Add(this.lab_bed_time);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1281, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_bed_cd
            // 
            this.txt_bed_cd.Location = new System.Drawing.Point(33, 39);
            this.txt_bed_cd.Name = "txt_bed_cd";
            this.txt_bed_cd.Size = new System.Drawing.Size(94, 22);
            this.txt_bed_cd.TabIndex = 492;
            this.txt_bed_cd.Visible = false;
            // 
            // txt_emp_cd
            // 
            this.txt_emp_cd.Enabled = false;
            this.txt_emp_cd.Location = new System.Drawing.Point(903, 14);
            this.txt_emp_cd.Name = "txt_emp_cd";
            this.txt_emp_cd.Size = new System.Drawing.Size(66, 22);
            this.txt_emp_cd.TabIndex = 491;
            this.txt_emp_cd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(814, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 490;
            this.label1.Text = "作业人员";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_bed_fl
            // 
            this.txt_bed_fl.Location = new System.Drawing.Point(129, 14);
            this.txt_bed_fl.Name = "txt_bed_fl";
            this.txt_bed_fl.Size = new System.Drawing.Size(49, 22);
            this.txt_bed_fl.TabIndex = 489;
            this.txt_bed_fl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listb_bed_fl
            // 
            this.listb_bed_fl.BackColor = System.Drawing.SystemColors.Control;
            this.listb_bed_fl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listb_bed_fl.FormattingEnabled = true;
            this.listb_bed_fl.Items.AddRange(new object[] {
            "1# 冷床",
            "2# 冷床",
            "3# 冷床"});
            this.listb_bed_fl.Location = new System.Drawing.Point(184, 14);
            this.listb_bed_fl.Name = "listb_bed_fl";
            this.listb_bed_fl.Size = new System.Drawing.Size(100, 41);
            this.listb_bed_fl.TabIndex = 488;
            // 
            // sdb_cb_temp
            // 
            this.sdb_cb_temp.Location = new System.Drawing.Point(738, 14);
            this.sdb_cb_temp.MaxLength = 4;
            this.sdb_cb_temp.Name = "sdb_cb_temp";
            this.sdb_cb_temp.NumValue = 0D;
            this.sdb_cb_temp.Scale = 0;
            this.sdb_cb_temp.ShowZero = true;
            this.sdb_cb_temp.Size = new System.Drawing.Size(52, 22);
            this.sdb_cb_temp.TabIndex = 487;
            this.sdb_cb_temp.Text = "0";
            this.sdb_cb_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mdt_cb_time
            // 
            this.mdt_cb_time.Location = new System.Drawing.Point(456, 14);
            this.mdt_cb_time.Mask = "0000-00-00 90:00:00";
            this.mdt_cb_time.Name = "mdt_cb_time";
            this.mdt_cb_time.Size = new System.Drawing.Size(146, 22);
            this.mdt_cb_time.TabIndex = 486;
            // 
            // lab_bed_temp
            // 
            this.lab_bed_temp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_bed_temp.Location = new System.Drawing.Point(642, 14);
            this.lab_bed_temp.Name = "lab_bed_temp";
            this.lab_bed_temp.Size = new System.Drawing.Size(94, 22);
            this.lab_bed_temp.TabIndex = 485;
            this.lab_bed_temp.Text = "上冷床温度";
            this.lab_bed_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_bed_time
            // 
            this.lab_bed_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_bed_time.Location = new System.Drawing.Point(360, 14);
            this.lab_bed_time.Name = "lab_bed_time";
            this.lab_bed_time.Size = new System.Drawing.Size(94, 22);
            this.lab_bed_time.TabIndex = 484;
            this.lab_bed_time.Text = "上冷床时间";
            this.lab_bed_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(33, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 483;
            this.label5.Text = "冷床";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_bed_cd
            // 
            this.tab_bed_cd.Controls.Add(this.tabPage1);
            this.tab_bed_cd.Controls.Add(this.tabPage2);
            this.tab_bed_cd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_bed_cd.ItemSize = new System.Drawing.Size(484, 18);
            this.tab_bed_cd.Location = new System.Drawing.Point(0, 111);
            this.tab_bed_cd.Name = "tab_bed_cd";
            this.tab_bed_cd.SelectedIndex = 0;
            this.tab_bed_cd.Size = new System.Drawing.Size(1281, 511);
            this.tab_bed_cd.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_bed_cd.TabIndex = 483;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1273, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上冷床";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1267, 479);
            this.ss1.TabIndex = 1;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "下冷床";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 3);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(998, 479);
            this.ss2.TabIndex = 0;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // WGB1050C
            // 
            this.ClientSize = new System.Drawing.Size(1281, 622);
            this.Controls.Add(this.tab_bed_cd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGB1050C";
            this.Text = "冷床实绩管理界面_WGB1050C";
            this.Load += new System.EventHandler(this.WGB1050C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_bed_cd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mill_no;
        private System.Windows.Forms.ComboBox cbo_shift;
        private CommonClass.CeriUDate udt_prod_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_bed_cd;
        private System.Windows.Forms.TextBox txt_emp_cd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bed_fl;
        private System.Windows.Forms.ListBox listb_bed_fl;
        private CommonClass.NumBox sdb_cb_temp;
        private CommonClass.MaskedDate mdt_cb_time;
        private System.Windows.Forms.Label lab_bed_temp;
        private System.Windows.Forms.Label lab_bed_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tab_bed_cd;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
    }
}
