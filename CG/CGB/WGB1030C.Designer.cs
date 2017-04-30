namespace CG
{
    partial class WGB1030C
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
            this.txt_slab_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udt_prod_date = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_upd_emp = new System.Windows.Forms.TextBox();
            this.cbo_hl_no = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sdb_lev_p_pe = new CommonClass.NumBox();
            this.sdb_lev_lst_tmp = new CommonClass.NumBox();
            this.sdb_lev_in_tmp = new CommonClass.NumBox();
            this.sdb_lev_oud_force = new CommonClass.NumBox();
            this.sdb_lev_ouw_force = new CommonClass.NumBox();
            this.sdb_lev_ind_force = new CommonClass.NumBox();
            this.sdb_lev_inw_force = new CommonClass.NumBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mdt_hl_end_date = new CommonClass.MaskedDate();
            this.mdt_hl_sta_date = new CommonClass.MaskedDate();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_slab_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.udt_prod_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_slab_no
            // 
            this.txt_slab_no.Location = new System.Drawing.Point(636, 14);
            this.txt_slab_no.Name = "txt_slab_no";
            this.txt_slab_no.Size = new System.Drawing.Size(105, 22);
            this.txt_slab_no.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(547, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "板坯号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(407, 14);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(46, 22);
            this.cbo_shift.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(318, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udt_prod_date
            // 
            this.udt_prod_date.Location = new System.Drawing.Point(127, 14);
            this.udt_prod_date.Name = "udt_prod_date";
            this.udt_prod_date.RawDate = "";
            this.udt_prod_date.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(31, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_upd_emp);
            this.groupBox2.Controls.Add(this.cbo_hl_no);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sdb_lev_p_pe);
            this.groupBox2.Controls.Add(this.sdb_lev_lst_tmp);
            this.groupBox2.Controls.Add(this.sdb_lev_in_tmp);
            this.groupBox2.Controls.Add(this.sdb_lev_oud_force);
            this.groupBox2.Controls.Add(this.sdb_lev_ouw_force);
            this.groupBox2.Controls.Add(this.sdb_lev_ind_force);
            this.groupBox2.Controls.Add(this.sdb_lev_inw_force);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.mdt_hl_end_date);
            this.groupBox2.Controls.Add(this.mdt_hl_sta_date);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(0, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_upd_emp
            // 
            this.txt_upd_emp.Location = new System.Drawing.Point(849, 16);
            this.txt_upd_emp.Name = "txt_upd_emp";
            this.txt_upd_emp.Size = new System.Drawing.Size(68, 22);
            this.txt_upd_emp.TabIndex = 198;
            // 
            // cbo_hl_no
            // 
            this.cbo_hl_no.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_hl_no.FormattingEnabled = true;
            this.cbo_hl_no.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_hl_no.Location = new System.Drawing.Point(127, 18);
            this.cbo_hl_no.Name = "cbo_hl_no";
            this.cbo_hl_no.Size = new System.Drawing.Size(46, 22);
            this.cbo_hl_no.TabIndex = 411;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(760, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 197;
            this.label6.Text = "作业人员";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_lev_p_pe
            // 
            this.sdb_lev_p_pe.Location = new System.Drawing.Point(432, 18);
            this.sdb_lev_p_pe.MaxLength = 3;
            this.sdb_lev_p_pe.Name = "sdb_lev_p_pe";
            this.sdb_lev_p_pe.NumValue = 0D;
            this.sdb_lev_p_pe.Scale = 0;
            this.sdb_lev_p_pe.ShowZero = true;
            this.sdb_lev_p_pe.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_p_pe.TabIndex = 410;
            this.sdb_lev_p_pe.Text = "0";
            this.sdb_lev_p_pe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_lst_tmp
            // 
            this.sdb_lev_lst_tmp.Location = new System.Drawing.Point(849, 71);
            this.sdb_lev_lst_tmp.MaxLength = 4;
            this.sdb_lev_lst_tmp.Name = "sdb_lev_lst_tmp";
            this.sdb_lev_lst_tmp.NumValue = 0D;
            this.sdb_lev_lst_tmp.Scale = 0;
            this.sdb_lev_lst_tmp.ShowZero = true;
            this.sdb_lev_lst_tmp.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_lst_tmp.TabIndex = 409;
            this.sdb_lev_lst_tmp.Text = "0";
            this.sdb_lev_lst_tmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_in_tmp
            // 
            this.sdb_lev_in_tmp.Location = new System.Drawing.Point(849, 47);
            this.sdb_lev_in_tmp.MaxLength = 4;
            this.sdb_lev_in_tmp.Name = "sdb_lev_in_tmp";
            this.sdb_lev_in_tmp.NumValue = 0D;
            this.sdb_lev_in_tmp.Scale = 0;
            this.sdb_lev_in_tmp.ShowZero = true;
            this.sdb_lev_in_tmp.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_in_tmp.TabIndex = 408;
            this.sdb_lev_in_tmp.Text = "0";
            this.sdb_lev_in_tmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_oud_force
            // 
            this.sdb_lev_oud_force.Location = new System.Drawing.Point(654, 71);
            this.sdb_lev_oud_force.MaxLength = 5;
            this.sdb_lev_oud_force.Name = "sdb_lev_oud_force";
            this.sdb_lev_oud_force.NumValue = 0D;
            this.sdb_lev_oud_force.Scale = 0;
            this.sdb_lev_oud_force.ShowZero = true;
            this.sdb_lev_oud_force.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_oud_force.TabIndex = 407;
            this.sdb_lev_oud_force.Text = "0";
            this.sdb_lev_oud_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_ouw_force
            // 
            this.sdb_lev_ouw_force.Location = new System.Drawing.Point(654, 47);
            this.sdb_lev_ouw_force.MaxLength = 5;
            this.sdb_lev_ouw_force.Name = "sdb_lev_ouw_force";
            this.sdb_lev_ouw_force.NumValue = 0D;
            this.sdb_lev_ouw_force.Scale = 0;
            this.sdb_lev_ouw_force.ShowZero = true;
            this.sdb_lev_ouw_force.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_ouw_force.TabIndex = 406;
            this.sdb_lev_ouw_force.Text = "0";
            this.sdb_lev_ouw_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_ind_force
            // 
            this.sdb_lev_ind_force.Location = new System.Drawing.Point(432, 71);
            this.sdb_lev_ind_force.MaxLength = 5;
            this.sdb_lev_ind_force.Name = "sdb_lev_ind_force";
            this.sdb_lev_ind_force.NumValue = 0D;
            this.sdb_lev_ind_force.Scale = 0;
            this.sdb_lev_ind_force.ShowZero = true;
            this.sdb_lev_ind_force.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_ind_force.TabIndex = 405;
            this.sdb_lev_ind_force.Text = "0";
            this.sdb_lev_ind_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_lev_inw_force
            // 
            this.sdb_lev_inw_force.Location = new System.Drawing.Point(432, 47);
            this.sdb_lev_inw_force.MaxLength = 5;
            this.sdb_lev_inw_force.Name = "sdb_lev_inw_force";
            this.sdb_lev_inw_force.NumValue = 0D;
            this.sdb_lev_inw_force.Scale = 0;
            this.sdb_lev_inw_force.ShowZero = true;
            this.sdb_lev_inw_force.Size = new System.Drawing.Size(72, 22);
            this.sdb_lev_inw_force.TabIndex = 404;
            this.sdb_lev_inw_force.Text = "0";
            this.sdb_lev_inw_force.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(318, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 22);
            this.label17.TabIndex = 402;
            this.label17.Text = "塑性变形比";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(760, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 22);
            this.label19.TabIndex = 399;
            this.label19.Text = "矫直出口温度";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(760, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 22);
            this.label16.TabIndex = 398;
            this.label16.Text = "矫直入口温度";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(540, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 22);
            this.label15.TabIndex = 396;
            this.label15.Text = "出口左侧压下力";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(540, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 22);
            this.label14.TabIndex = 394;
            this.label14.Text = "出口右侧压下力";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(318, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 22);
            this.label13.TabIndex = 392;
            this.label13.Text = "入口左侧压下力";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(318, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 22);
            this.label18.TabIndex = 390;
            this.label18.Text = "入口右侧压下力";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mdt_hl_end_date
            // 
            this.mdt_hl_end_date.Location = new System.Drawing.Point(127, 71);
            this.mdt_hl_end_date.Mask = "0000-00-00 90:00:00";
            this.mdt_hl_end_date.Name = "mdt_hl_end_date";
            this.mdt_hl_end_date.Size = new System.Drawing.Size(142, 22);
            this.mdt_hl_end_date.TabIndex = 389;
            // 
            // mdt_hl_sta_date
            // 
            this.mdt_hl_sta_date.Location = new System.Drawing.Point(127, 47);
            this.mdt_hl_sta_date.Mask = "0000-00-00 90:00:00";
            this.mdt_hl_sta_date.Name = "mdt_hl_sta_date";
            this.mdt_hl_sta_date.Size = new System.Drawing.Size(142, 22);
            this.mdt_hl_sta_date.TabIndex = 388;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(31, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 387;
            this.label11.Text = "终矫时间";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(31, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 386;
            this.label12.Text = "开矫时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(31, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 384;
            this.label10.Text = "矫直机号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Location = new System.Drawing.Point(0, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(977, 464);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(971, 443);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGB1030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "WGB1030C";
            this.Text = "矫直实绩查询及修改界面_WGB1030C";
            this.Load += new System.EventHandler(this.WGB1030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CommonClass.CeriUDate udt_prod_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_slab_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label10;
        private CommonClass.MaskedDate mdt_hl_end_date;
        private CommonClass.MaskedDate mdt_hl_sta_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private CommonClass.NumBox sdb_lev_oud_force;
        private CommonClass.NumBox sdb_lev_ouw_force;
        private CommonClass.NumBox sdb_lev_ind_force;
        private CommonClass.NumBox sdb_lev_inw_force;
        private CommonClass.NumBox sdb_lev_p_pe;
        private CommonClass.NumBox sdb_lev_lst_tmp;
        private CommonClass.NumBox sdb_lev_in_tmp;
        private System.Windows.Forms.ComboBox cbo_hl_no;
        private System.Windows.Forms.TextBox txt_upd_emp;
        private System.Windows.Forms.Label label6;
    }
}
