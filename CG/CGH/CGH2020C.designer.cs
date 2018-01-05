namespace CG
{
    partial class CGH2020C
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
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_DEL_RES_CD = new CommonClass.F4ETCN();
            this.TXT_OCCR_TIME_TO = new CommonClass.CeriUDate();
            this.TXT_OCCR_TIME = new CommonClass.CeriUDate();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.CBO_PRC = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBO_PLT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_DEL_RES_CD);
            this.groupBox1.Controls.Add(this.TXT_OCCR_TIME_TO);
            this.groupBox1.Controls.Add(this.TXT_OCCR_TIME);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.CBO_PRC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.CBO_GROUP.Location = new System.Drawing.Point(1023, 16);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(46, 22);
            this.CBO_GROUP.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(941, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 89;
            this.label6.Text = "班别";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3"});
            this.CBO_PLT.Location = new System.Drawing.Point(100, 15);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(46, 22);
            this.CBO_PLT.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "工厂代码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TXT_DEL_RES_CD
            // 
            this.TXT_DEL_RES_CD.Location = new System.Drawing.Point(732, 16);
            this.TXT_DEL_RES_CD.Name = "TXT_DEL_RES_CD";
            this.TXT_DEL_RES_CD.sFcontrol = "T.CD";
            this.TXT_DEL_RES_CD.Size = new System.Drawing.Size(44, 22);
            this.TXT_DEL_RES_CD.sJoin = "";
            this.TXT_DEL_RES_CD.sSqletc = "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = \'G0013\'";
            this.TXT_DEL_RES_CD.TabIndex = 82;
            // 
            // TXT_OCCR_TIME_TO
            // 
            this.TXT_OCCR_TIME_TO.Location = new System.Drawing.Point(528, 15);
            this.TXT_OCCR_TIME_TO.Name = "TXT_OCCR_TIME_TO";
            this.TXT_OCCR_TIME_TO.RawDate = "";
            this.TXT_OCCR_TIME_TO.Size = new System.Drawing.Size(95, 22);
            this.TXT_OCCR_TIME_TO.TabIndex = 81;
            // 
            // TXT_OCCR_TIME
            // 
            this.TXT_OCCR_TIME.Location = new System.Drawing.Point(430, 15);
            this.TXT_OCCR_TIME.Name = "TXT_OCCR_TIME";
            this.TXT_OCCR_TIME.RawDate = "";
            this.TXT_OCCR_TIME.Size = new System.Drawing.Size(95, 22);
            this.TXT_OCCR_TIME.TabIndex = 80;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(877, 15);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(46, 22);
            this.CBO_SHIFT.TabIndex = 7;
            // 
            // CBO_PRC
            // 
            this.CBO_PRC.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PRC.FormattingEnabled = true;
            this.CBO_PRC.Items.AddRange(new object[] {
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
            this.CBO_PRC.Location = new System.Drawing.Point(266, 14);
            this.CBO_PRC.Name = "CBO_PRC";
            this.CBO_PRC.Size = new System.Drawing.Size(46, 22);
            this.CBO_PRC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(646, 15);
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
            this.label4.Location = new System.Drawing.Point(348, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "发生时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(795, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(184, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "工序代码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 594);
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
            this.ss1.Size = new System.Drawing.Size(1194, 573);
            this.ss1.TabIndex = 0;
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss_CellDoubleClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // CGH2020C
            // 
            this.ClientSize = new System.Drawing.Size(1200, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGH2020C";
            this.Text = "轧钢生产线停机实绩查询及修改界面_CGH2020C";
            this.Load += new System.EventHandler(this.CGH2020C_Load);
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
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.ComboBox CBO_PRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate TXT_OCCR_TIME_TO;
        private CommonClass.CeriUDate TXT_OCCR_TIME;
        private CommonClass.F4ETCN TXT_DEL_RES_CD;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label6;
    }
}
