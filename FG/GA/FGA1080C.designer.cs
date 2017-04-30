namespace FG
{
    partial class FGA1080C
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
            this.F4ETCN_STDSPEC_R = new CommonClass.F4ETCN();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.txt_f_addr = new System.Windows.Forms.TextBox();
            this.TXT_ORD_NO = new System.Windows.Forms.TextBox();
            this.CBO_PRODGRD = new System.Windows.Forms.ComboBox();
            this.CBO_SURFGRD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_chg_no = new System.Windows.Forms.ComboBox();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.cmd_Exc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F4ETCN_STDSPEC_R);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.txt_f_addr);
            this.groupBox1.Controls.Add(this.TXT_ORD_NO);
            this.groupBox1.Controls.Add(this.CBO_PRODGRD);
            this.groupBox1.Controls.Add(this.CBO_SURFGRD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_chg_no);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.cmd_Exc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // F4ETCN_STDSPEC_R
            // 
            this.F4ETCN_STDSPEC_R.Location = new System.Drawing.Point(107, 41);
            this.F4ETCN_STDSPEC_R.Name = "F4ETCN_STDSPEC_R";
            this.F4ETCN_STDSPEC_R.sFcontrol = "T.STDSPEC";
            this.F4ETCN_STDSPEC_R.Size = new System.Drawing.Size(193, 22);
            this.F4ETCN_STDSPEC_R.sJoin = "";
            this.F4ETCN_STDSPEC_R.sSqletc = "SELECT T.STDSPEC AS 标准号,T.STDSPEC_YY AS 发布年度,STDSPEC_CHR_CD FROM NISCO.QP_STD_HEA" +
                "D T WHERE NVL(T.STDSPEC_CHR_CD,\'Y\') <>\'N\' ORDER BY STDSPEC ASC";
            this.F4ETCN_STDSPEC_R.TabIndex = 538;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(208, 13);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 537;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(107, 13);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FROM.TabIndex = 536;
            // 
            // txt_f_addr
            // 
            this.txt_f_addr.Location = new System.Drawing.Point(732, 41);
            this.txt_f_addr.Name = "txt_f_addr";
            this.txt_f_addr.Size = new System.Drawing.Size(71, 22);
            this.txt_f_addr.TabIndex = 535;
            // 
            // TXT_ORD_NO
            // 
            this.TXT_ORD_NO.Location = new System.Drawing.Point(472, 69);
            this.TXT_ORD_NO.Name = "TXT_ORD_NO";
            this.TXT_ORD_NO.Size = new System.Drawing.Size(99, 22);
            this.TXT_ORD_NO.TabIndex = 534;
            // 
            // CBO_PRODGRD
            // 
            this.CBO_PRODGRD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PRODGRD.FormattingEnabled = true;
            this.CBO_PRODGRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "7"});
            this.CBO_PRODGRD.Location = new System.Drawing.Point(809, 13);
            this.CBO_PRODGRD.MaxLength = 1;
            this.CBO_PRODGRD.Name = "CBO_PRODGRD";
            this.CBO_PRODGRD.Size = new System.Drawing.Size(71, 22);
            this.CBO_PRODGRD.TabIndex = 532;
            // 
            // CBO_SURFGRD
            // 
            this.CBO_SURFGRD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SURFGRD.FormattingEnabled = true;
            this.CBO_SURFGRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "0"});
            this.CBO_SURFGRD.Location = new System.Drawing.Point(732, 13);
            this.CBO_SURFGRD.MaxLength = 1;
            this.CBO_SURFGRD.Name = "CBO_SURFGRD";
            this.CBO_SURFGRD.Size = new System.Drawing.Size(71, 22);
            this.CBO_SURFGRD.TabIndex = 531;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(655, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 530;
            this.label9.Text = "垛位号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(403, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 529;
            this.label6.Text = "订单号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_chg_no
            // 
            this.cbo_chg_no.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_chg_no.FormattingEnabled = true;
            this.cbo_chg_no.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_chg_no.Location = new System.Drawing.Point(472, 41);
            this.cbo_chg_no.MaxLength = 1;
            this.cbo_chg_no.Name = "cbo_chg_no";
            this.cbo_chg_no.Size = new System.Drawing.Size(50, 22);
            this.cbo_chg_no.TabIndex = 528;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(107, 72);
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(142, 22);
            this.TXT_PLATE_NO.TabIndex = 522;
            // 
            // cmd_Exc
            // 
            this.cmd_Exc.Location = new System.Drawing.Point(655, 67);
            this.cmd_Exc.Name = "cmd_Exc";
            this.cmd_Exc.Size = new System.Drawing.Size(71, 23);
            this.cmd_Exc.TabIndex = 520;
            this.cmd_Exc.Text = "记录导出";
            this.cmd_Exc.UseVisualStyleBackColor = true;
            this.cmd_Exc.Click += new System.EventHandler(this.SSCommand2_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 518;
            this.label8.Text = "标准号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(655, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 515;
            this.label7.Text = "表面/综合";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "热处理时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(528, 11);
            this.CBO_GROUP.MaxLength = 1;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(43, 22);
            this.CBO_GROUP.TabIndex = 508;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(472, 11);
            this.CBO_SHIFT.MaxLength = 1;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(50, 22);
            this.CBO_SHIFT.TabIndex = 505;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "查询号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(403, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "班次/别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(403, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "炉座号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 522);
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
            this.ss1.Size = new System.Drawing.Size(1026, 501);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGA1080C
            // 
            this.ClientSize = new System.Drawing.Size(1032, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGA1080C";
            this.Text = "钢板剩磁检查实绩查询及修改_FGA1080C";
            this.Load += new System.EventHandler(this.FGA1080C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmd_Exc;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.ComboBox CBO_PRODGRD;
        private System.Windows.Forms.ComboBox CBO_SURFGRD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_chg_no;
        private System.Windows.Forms.TextBox txt_f_addr;
        private System.Windows.Forms.TextBox TXT_ORD_NO;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.F4ETCN F4ETCN_STDSPEC_R;
    }
}
