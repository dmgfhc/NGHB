namespace CG
{
    partial class WGC2020C
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
            this.cmb_Shift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_moplate_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listb_trim_fl = new System.Windows.Forms.ListBox();
            this.txt_emp_cd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sdb_cut_speed = new CommonClass.NumBox();
            this.sdb_move_gap = new CommonClass.NumBox();
            this.sdb_fix_gap = new CommonClass.NumBox();
            this.sdb_wid = new CommonClass.NumBox();
            this.txt_trim_fl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.udt_cut_time = new CommonClass.MaskedDate();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.sdb_bef_thk = new CommonClass.NumBox();
            this.sdb_bef_wid = new CommonClass.NumBox();
            this.sdb_bef_len = new CommonClass.NumBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udt_prod_date);
            this.groupBox1.Controls.Add(this.cmb_Shift);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_moplate_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // udt_prod_date
            // 
            this.udt_prod_date.Location = new System.Drawing.Point(102, 14);
            this.udt_prod_date.Name = "udt_prod_date";
            this.udt_prod_date.RawDate = "";
            this.udt_prod_date.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date.TabIndex = 97;
            // 
            // cmb_Shift
            // 
            this.cmb_Shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cmb_Shift.FormattingEnabled = true;
            this.cmb_Shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_Shift.Location = new System.Drawing.Point(333, 14);
            this.cmb_Shift.Name = "cmb_Shift";
            this.cmb_Shift.Size = new System.Drawing.Size(53, 22);
            this.cmb_Shift.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(251, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "班次";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 94;
            this.label3.Text = "生产日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_moplate_no
            // 
            this.txt_moplate_no.Location = new System.Drawing.Point(508, 14);
            this.txt_moplate_no.Name = "txt_moplate_no";
            this.txt_moplate_no.Size = new System.Drawing.Size(100, 22);
            this.txt_moplate_no.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(426, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "母板号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sdb_bef_len);
            this.groupBox2.Controls.Add(this.sdb_bef_wid);
            this.groupBox2.Controls.Add(this.sdb_bef_thk);
            this.groupBox2.Controls.Add(this.listb_trim_fl);
            this.groupBox2.Controls.Add(this.txt_emp_cd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sdb_cut_speed);
            this.groupBox2.Controls.Add(this.sdb_move_gap);
            this.groupBox2.Controls.Add(this.sdb_fix_gap);
            this.groupBox2.Controls.Add(this.sdb_wid);
            this.groupBox2.Controls.Add(this.txt_trim_fl);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.udt_cut_time);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // listb_trim_fl
            // 
            this.listb_trim_fl.BackColor = System.Drawing.SystemColors.Control;
            this.listb_trim_fl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listb_trim_fl.FormattingEnabled = true;
            this.listb_trim_fl.Items.AddRange(new object[] {
            "Y 切边",
            "N 不切边"});
            this.listb_trim_fl.Location = new System.Drawing.Point(408, 14);
            this.listb_trim_fl.Name = "listb_trim_fl";
            this.listb_trim_fl.Size = new System.Drawing.Size(81, 28);
            this.listb_trim_fl.TabIndex = 483;
            this.listb_trim_fl.Click += new System.EventHandler(this.listb_trim_fl_Click);
            this.listb_trim_fl.SelectedIndexChanged += new System.EventHandler(this.listb_trim_fl_SelectedIndexChanged);
            // 
            // txt_emp_cd
            // 
            this.txt_emp_cd.Enabled = false;
            this.txt_emp_cd.Location = new System.Drawing.Point(813, 68);
            this.txt_emp_cd.Name = "txt_emp_cd";
            this.txt_emp_cd.Size = new System.Drawing.Size(66, 22);
            this.txt_emp_cd.TabIndex = 482;
            this.txt_emp_cd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(724, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 481;
            this.label1.Text = "作业人员";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_cut_speed
            // 
            this.sdb_cut_speed.Location = new System.Drawing.Point(625, 68);
            this.sdb_cut_speed.MaxLength = 4;
            this.sdb_cut_speed.Name = "sdb_cut_speed";
            this.sdb_cut_speed.NumValue = 0D;
            this.sdb_cut_speed.Scale = 0;
            this.sdb_cut_speed.ShowZero = true;
            this.sdb_cut_speed.Size = new System.Drawing.Size(69, 22);
            this.sdb_cut_speed.TabIndex = 466;
            this.sdb_cut_speed.Text = "0";
            this.sdb_cut_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_move_gap
            // 
            this.sdb_move_gap.Location = new System.Drawing.Point(625, 41);
            this.sdb_move_gap.MaxLength = 4;
            this.sdb_move_gap.Name = "sdb_move_gap";
            this.sdb_move_gap.NumValue = 0D;
            this.sdb_move_gap.Scale = 0;
            this.sdb_move_gap.ShowZero = true;
            this.sdb_move_gap.Size = new System.Drawing.Size(69, 22);
            this.sdb_move_gap.TabIndex = 465;
            this.sdb_move_gap.Text = "0";
            this.sdb_move_gap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_fix_gap
            // 
            this.sdb_fix_gap.Location = new System.Drawing.Point(625, 14);
            this.sdb_fix_gap.MaxLength = 4;
            this.sdb_fix_gap.Name = "sdb_fix_gap";
            this.sdb_fix_gap.NumValue = 0D;
            this.sdb_fix_gap.Scale = 0;
            this.sdb_fix_gap.ShowZero = true;
            this.sdb_fix_gap.Size = new System.Drawing.Size(69, 22);
            this.sdb_fix_gap.TabIndex = 464;
            this.sdb_fix_gap.Text = "0";
            this.sdb_fix_gap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_wid
            // 
            this.sdb_wid.Location = new System.Drawing.Point(333, 41);
            this.sdb_wid.MaxLength = 4;
            this.sdb_wid.Name = "sdb_wid";
            this.sdb_wid.NumValue = 0D;
            this.sdb_wid.Scale = 0;
            this.sdb_wid.ShowZero = true;
            this.sdb_wid.Size = new System.Drawing.Size(69, 22);
            this.sdb_wid.TabIndex = 463;
            this.sdb_wid.Text = "0";
            this.sdb_wid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_trim_fl
            // 
            this.txt_trim_fl.Enabled = false;
            this.txt_trim_fl.Location = new System.Drawing.Point(333, 14);
            this.txt_trim_fl.Name = "txt_trim_fl";
            this.txt_trim_fl.Size = new System.Drawing.Size(69, 22);
            this.txt_trim_fl.TabIndex = 219;
            this.txt_trim_fl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(543, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 22);
            this.label17.TabIndex = 215;
            this.label17.Text = "剪切速度";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(543, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 22);
            this.label16.TabIndex = 214;
            this.label16.Text = "固定剪刀缝";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(543, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 213;
            this.label15.Text = "移动剪刀缝";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(251, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 211;
            this.label14.Text = "切边后板宽";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // udt_cut_time
            // 
            this.udt_cut_time.Location = new System.Drawing.Point(333, 68);
            this.udt_cut_time.Mask = "0000-00-00 90:00:00";
            this.udt_cut_time.Name = "udt_cut_time";
            this.udt_cut_time.Size = new System.Drawing.Size(142, 22);
            this.udt_cut_time.TabIndex = 210;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(251, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 22);
            this.label18.TabIndex = 209;
            this.label18.Text = "结束时间";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(251, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 205;
            this.label13.Text = "实绩切边";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(21, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 199;
            this.label9.Text = "长度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(21, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 197;
            this.label7.Text = "宽度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(21, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 195;
            this.label5.Text = "厚度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ss1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 483);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1012, 462);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // sdb_bef_thk
            // 
            this.sdb_bef_thk.Location = new System.Drawing.Point(103, 15);
            this.sdb_bef_thk.MaxLength = 8;
            this.sdb_bef_thk.Name = "sdb_bef_thk";
            this.sdb_bef_thk.NumValue = 4D;
            this.sdb_bef_thk.Scale = 2;
            this.sdb_bef_thk.ShowZero = true;
            this.sdb_bef_thk.Size = new System.Drawing.Size(84, 22);
            this.sdb_bef_thk.TabIndex = 484;
            this.sdb_bef_thk.Text = "4.00";
            this.sdb_bef_thk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_bef_wid
            // 
            this.sdb_bef_wid.Location = new System.Drawing.Point(103, 42);
            this.sdb_bef_wid.MaxLength = 8;
            this.sdb_bef_wid.Name = "sdb_bef_wid";
            this.sdb_bef_wid.NumValue = 4D;
            this.sdb_bef_wid.Scale = 2;
            this.sdb_bef_wid.ShowZero = true;
            this.sdb_bef_wid.Size = new System.Drawing.Size(84, 22);
            this.sdb_bef_wid.TabIndex = 484;
            this.sdb_bef_wid.Text = "4.00";
            this.sdb_bef_wid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_bef_len
            // 
            this.sdb_bef_len.Location = new System.Drawing.Point(102, 68);
            this.sdb_bef_len.MaxLength = 9;
            this.sdb_bef_len.Name = "sdb_bef_len";
            this.sdb_bef_len.NumValue = 7D;
            this.sdb_bef_len.Scale = 1;
            this.sdb_bef_len.ShowZero = true;
            this.sdb_bef_len.Size = new System.Drawing.Size(84, 22);
            this.sdb_bef_len.TabIndex = 484;
            this.sdb_bef_len.Text = "7.0";
            this.sdb_bef_len.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WGC2020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC2020C";
            this.Text = "双边剪实绩管理界面_WGC2020C";
            this.Load += new System.EventHandler(this.WGC2020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CommonClass.CeriUDate udt_prod_date;
        private System.Windows.Forms.ComboBox cmb_Shift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_moplate_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox txt_trim_fl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private CommonClass.MaskedDate udt_cut_time;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private CommonClass.NumBox sdb_wid;
        private CommonClass.NumBox sdb_cut_speed;
        private CommonClass.NumBox sdb_move_gap;
        private CommonClass.NumBox sdb_fix_gap;
        private System.Windows.Forms.TextBox txt_emp_cd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listb_trim_fl;
        private CommonClass.NumBox sdb_bef_len;
        private CommonClass.NumBox sdb_bef_wid;
        private CommonClass.NumBox sdb_bef_thk;
    }
}
