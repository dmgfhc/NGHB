namespace CK
{
    partial class WKB1010C
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_del_res_reson = new System.Windows.Forms.TextBox();
            this.txt_del_res_cd = new System.Windows.Forms.TextBox();
            this.txt_del_res_cd4 = new CommonClass.F4ETCN();
            this.txt_del_res_cd3 = new CommonClass.F4ETCN();
            this.txt_del_res_cd2 = new CommonClass.F4ETCN();
            this.txt_del_res_cd1 = new CommonClass.F4ETCN();
            this.udt_prod_date_to = new CommonClass.CeriUDate();
            this.udt_prod_date_from = new CommonClass.CeriUDate();
            this.btn_cmd_edit = new System.Windows.Forms.Button();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.cbo_prc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_del_res_reson);
            this.groupBox1.Controls.Add(this.txt_del_res_cd);
            this.groupBox1.Controls.Add(this.txt_del_res_cd4);
            this.groupBox1.Controls.Add(this.txt_del_res_cd3);
            this.groupBox1.Controls.Add(this.txt_del_res_cd2);
            this.groupBox1.Controls.Add(this.txt_del_res_cd1);
            this.groupBox1.Controls.Add(this.udt_prod_date_to);
            this.groupBox1.Controls.Add(this.udt_prod_date_from);
            this.groupBox1.Controls.Add(this.btn_cmd_edit);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.cbo_prc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 88;
            this.label1.Tag = "F4";
            this.label1.Text = "停机原因";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_del_res_reson
            // 
            this.txt_del_res_reson.Location = new System.Drawing.Point(94, 45);
            this.txt_del_res_reson.Name = "txt_del_res_reson";
            this.txt_del_res_reson.Size = new System.Drawing.Size(341, 22);
            this.txt_del_res_reson.TabIndex = 87;
            // 
            // txt_del_res_cd
            // 
            this.txt_del_res_cd.Location = new System.Drawing.Point(648, 16);
            this.txt_del_res_cd.Name = "txt_del_res_cd";
            this.txt_del_res_cd.Size = new System.Drawing.Size(19, 22);
            this.txt_del_res_cd.TabIndex = 86;
            this.txt_del_res_cd.Visible = false;
            // 
            // txt_del_res_cd4
            // 
            this.txt_del_res_cd4.Location = new System.Drawing.Point(876, 14);
            this.txt_del_res_cd4.Name = "txt_del_res_cd4";
            this.txt_del_res_cd4.sFcontrol = "T.CD";
            this.txt_del_res_cd4.Size = new System.Drawing.Size(33, 22);
            this.txt_del_res_cd4.sJoin = "";
            this.txt_del_res_cd4.sSqletc = "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = \'WG007\'";
            this.txt_del_res_cd4.TabIndex = 85;
            this.txt_del_res_cd4.TextChanged += new System.EventHandler(this.txt_del_res_cd4_TextChanged);
            // 
            // txt_del_res_cd3
            // 
            this.txt_del_res_cd3.Location = new System.Drawing.Point(837, 14);
            this.txt_del_res_cd3.Name = "txt_del_res_cd3";
            this.txt_del_res_cd3.sFcontrol = "T.CD";
            this.txt_del_res_cd3.Size = new System.Drawing.Size(33, 22);
            this.txt_del_res_cd3.sJoin = "";
            this.txt_del_res_cd3.sSqletc = "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = \'WG005\'";
            this.txt_del_res_cd3.TabIndex = 84;
            this.txt_del_res_cd3.TextChanged += new System.EventHandler(this.txt_del_res_cd3_TextChanged);
            // 
            // txt_del_res_cd2
            // 
            this.txt_del_res_cd2.Enabled = false;
            this.txt_del_res_cd2.Location = new System.Drawing.Point(798, 14);
            this.txt_del_res_cd2.Name = "txt_del_res_cd2";
            this.txt_del_res_cd2.sFcontrol = "T.CD";
            this.txt_del_res_cd2.Size = new System.Drawing.Size(33, 22);
            this.txt_del_res_cd2.sJoin = "";
            this.txt_del_res_cd2.sSqletc = "SELECT cd,cd_short_name,cd_name FROM zp_cd t WHERE t.cd_mana_no = \'WG004\'";
            this.txt_del_res_cd2.TabIndex = 83;
            this.txt_del_res_cd2.TextChanged += new System.EventHandler(this.txt_del_res_cd2_TextChanged);
            // 
            // txt_del_res_cd1
            // 
            this.txt_del_res_cd1.Location = new System.Drawing.Point(755, 14);
            this.txt_del_res_cd1.Name = "txt_del_res_cd1";
            this.txt_del_res_cd1.sFcontrol = "T.CD";
            this.txt_del_res_cd1.Size = new System.Drawing.Size(33, 22);
            this.txt_del_res_cd1.sJoin = "";
            this.txt_del_res_cd1.sSqletc = "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = \'WG003\'";
            this.txt_del_res_cd1.TabIndex = 82;
            this.txt_del_res_cd1.TextChanged += new System.EventHandler(this.txt_del_res_cd1_TextChanged);
            // 
            // udt_prod_date_to
            // 
            this.udt_prod_date_to.Location = new System.Drawing.Point(535, 14);
            this.udt_prod_date_to.Name = "udt_prod_date_to";
            this.udt_prod_date_to.RawDate = "";
            this.udt_prod_date_to.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date_to.TabIndex = 81;
            // 
            // udt_prod_date_from
            // 
            this.udt_prod_date_from.Location = new System.Drawing.Point(437, 14);
            this.udt_prod_date_from.Name = "udt_prod_date_from";
            this.udt_prod_date_from.RawDate = "";
            this.udt_prod_date_from.Size = new System.Drawing.Size(95, 22);
            this.udt_prod_date_from.TabIndex = 80;
            // 
            // btn_cmd_edit
            // 
            this.btn_cmd_edit.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cmd_edit.Location = new System.Drawing.Point(915, 12);
            this.btn_cmd_edit.Name = "btn_cmd_edit";
            this.btn_cmd_edit.Size = new System.Drawing.Size(89, 26);
            this.btn_cmd_edit.TabIndex = 12;
            this.btn_cmd_edit.Text = "更新数据";
            this.btn_cmd_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cmd_edit.UseVisualStyleBackColor = true;
            this.btn_cmd_edit.Click += new System.EventHandler(this.btn_cmd_edit_Click);
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(266, 14);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(46, 22);
            this.cbo_shift.TabIndex = 7;
            // 
            // cbo_prc
            // 
            this.cbo_prc.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_prc.FormattingEnabled = true;
            this.cbo_prc.Items.AddRange(new object[] {
            "CA",
            "CB",
            "CC",
            "CD",
            "CE",
            "CF",
            "CG",
            "CH",
            "CI",
            "CJ",
            "CK"});
            this.cbo_prc.Location = new System.Drawing.Point(94, 14);
            this.cbo_prc.Name = "cbo_prc";
            this.cbo_prc.Size = new System.Drawing.Size(46, 22);
            this.cbo_prc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(673, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 4;
            this.label5.Tag = "F4";
            this.label5.Text = "停机代码";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(355, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "发生时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(184, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "工序";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 573);
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
            this.ss1.Size = new System.Drawing.Size(1194, 552);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss_CellDoubleClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WKB1010C
            // 
            this.ClientSize = new System.Drawing.Size(1200, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WKB1010C";
            this.Text = "生产线停机实绩管理画面_WKB1010C";
            this.Load += new System.EventHandler(this.WKB1010C_Load);
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
        private System.Windows.Forms.Button btn_cmd_edit;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.ComboBox cbo_prc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate udt_prod_date_to;
        private CommonClass.CeriUDate udt_prod_date_from;
        private CommonClass.F4ETCN txt_del_res_cd1;
        private CommonClass.F4ETCN txt_del_res_cd2;
        private CommonClass.F4ETCN txt_del_res_cd4;
        private CommonClass.F4ETCN txt_del_res_cd3;
        private System.Windows.Forms.TextBox txt_del_res_cd;
        private System.Windows.Forms.TextBox txt_del_res_reson;
        private System.Windows.Forms.Label label1;
    }
}
