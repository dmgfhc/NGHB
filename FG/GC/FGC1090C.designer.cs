namespace FG
{
    partial class FGC1090C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGC1090C));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_NO = new System.Windows.Forms.TextBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_STDSPEC = new CommonClass.F4ETCN();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_LOC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CBO_SURF_GRD = new System.Windows.Forms.ComboBox();
            this.CBO_PROD_GRD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_ORD_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1185, 499);
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
            this.ss1.Size = new System.Drawing.Size(1179, 478);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(401, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "班次/班别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CBO_GROUP.Location = new System.Drawing.Point(526, 18);
            this.CBO_GROUP.MaxLength = 1;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(50, 22);
            this.CBO_GROUP.TabIndex = 505;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "热处理时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 525;
            this.label2.Tag = "";
            this.label2.Text = "物料号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(92, 45);
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(134, 22);
            this.TXT_MAT_NO.TabIndex = 526;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(401, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 525;
            this.label4.Tag = "";
            this.label4.Text = "炉座号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NO
            // 
            this.TXT_NO.Location = new System.Drawing.Point(477, 45);
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(49, 22);
            this.TXT_NO.TabIndex = 526;
            this.TXT_NO.Text = "1";
            this.TXT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(478, 18);
            this.CBO_SHIFT.MaxLength = 1;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(48, 22);
            this.CBO_SHIFT.TabIndex = 508;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 529;
            this.label8.Tag = "F4";
            this.label8.Text = "标准号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_STDSPEC
            // 
            this.TXT_STDSPEC.Location = new System.Drawing.Point(92, 71);
            this.TXT_STDSPEC.Name = "TXT_STDSPEC";
            this.TXT_STDSPEC.sFcontrol = "STDSPEC";
            this.TXT_STDSPEC.Size = new System.Drawing.Size(134, 22);
            this.TXT_STDSPEC.sJoin = "";
            this.TXT_STDSPEC.sSqletc = resources.GetString("TXT_STDSPEC.sSqletc");
            this.TXT_STDSPEC.TabIndex = 530;
            // 
            // SDT_PROD_DATE_FR
            // 
            this.SDT_PROD_DATE_FR.Location = new System.Drawing.Point(92, 17);
            this.SDT_PROD_DATE_FR.Name = "SDT_PROD_DATE_FR";
            this.SDT_PROD_DATE_FR.RawDate = "";
            this.SDT_PROD_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FR.TabIndex = 547;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(193, 17);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 548;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_LOC);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.CBO_SURF_GRD);
            this.groupBox1.Controls.Add(this.CBO_PROD_GRD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_ORD_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.TXT_STDSPEC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.TXT_NO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_LOC
            // 
            this.TXT_LOC.Location = new System.Drawing.Point(696, 45);
            this.TXT_LOC.MaxLength = 7;
            this.TXT_LOC.Name = "TXT_LOC";
            this.TXT_LOC.Size = new System.Drawing.Size(99, 22);
            this.TXT_LOC.TabIndex = 555;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(620, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 21);
            this.label19.TabIndex = 554;
            this.label19.Text = "垛位";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SURF_GRD
            // 
            this.CBO_SURF_GRD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SURF_GRD.FormattingEnabled = true;
            this.CBO_SURF_GRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CBO_SURF_GRD.Location = new System.Drawing.Point(697, 18);
            this.CBO_SURF_GRD.MaxLength = 1;
            this.CBO_SURF_GRD.Name = "CBO_SURF_GRD";
            this.CBO_SURF_GRD.Size = new System.Drawing.Size(48, 22);
            this.CBO_SURF_GRD.TabIndex = 553;
            // 
            // CBO_PROD_GRD
            // 
            this.CBO_PROD_GRD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PROD_GRD.FormattingEnabled = true;
            this.CBO_PROD_GRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CBO_PROD_GRD.Location = new System.Drawing.Point(745, 18);
            this.CBO_PROD_GRD.MaxLength = 1;
            this.CBO_PROD_GRD.Name = "CBO_PROD_GRD";
            this.CBO_PROD_GRD.Size = new System.Drawing.Size(50, 22);
            this.CBO_PROD_GRD.TabIndex = 552;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(620, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 551;
            this.label3.Tag = "";
            this.label3.Text = "表面/综合";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_ORD_NO
            // 
            this.TXT_ORD_NO.Location = new System.Drawing.Point(477, 68);
            this.TXT_ORD_NO.Name = "TXT_ORD_NO";
            this.TXT_ORD_NO.Size = new System.Drawing.Size(99, 22);
            this.TXT_ORD_NO.TabIndex = 550;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(401, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 549;
            this.label6.Text = "订单号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FGC1090C
            // 
            this.ClientSize = new System.Drawing.Size(1185, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGC1090C";
            this.Text = "钢板硬度查询及修改界面_FGC1090C";
            this.Load += new System.EventHandler(this.FGC1090C_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_NO;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label8;
        private CommonClass.F4ETCN TXT_STDSPEC;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_ORD_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBO_SURF_GRD;
        private System.Windows.Forms.ComboBox CBO_PROD_GRD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_LOC;
        private System.Windows.Forms.Label label19;
    }
}
