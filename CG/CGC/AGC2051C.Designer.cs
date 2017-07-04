namespace CG
{
    partial class AGC2051C
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
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting3 = new CommonClass.BControlFiledSetting();
            this.txt_WkPlt = new CommonClass.F4ETCR();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PrcLine = new System.Windows.Forms.TextBox();
            this.TXT_MPLATE_NO = new System.Windows.Forms.TextBox();
            this.TXT_PRODCD = new System.Windows.Forms.TextBox();
            this.txt_Loc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TXT_INQNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_WkPlt
            // 
            bControlFiledSetting1.ColumnID = "T.CD";
            bControlFiledSetting1.TargetControl = this.txt_WkPlt;
            this.txt_WkPlt.CustomSetting.Add(bControlFiledSetting1);
            this.txt_WkPlt.Enabled = false;
            this.txt_WkPlt.InputControl = this.txt_WkPlt;
            this.txt_WkPlt.Location = new System.Drawing.Point(109, 14);
            this.txt_WkPlt.Name = "txt_WkPlt";
            this.txt_WkPlt.Size = new System.Drawing.Size(38, 22);
            this.txt_WkPlt.sJoin = "";
            this.txt_WkPlt.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
    " = \'B0033\'";
            this.txt_WkPlt.TabIndex = 106;
            this.txt_WkPlt.Text = "C3";
            this.txt_WkPlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt
            // 
            bControlFiledSetting2.ColumnID = "CD";
            bControlFiledSetting2.TargetControl = this.txt_plt;
            bControlFiledSetting3.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting3.TargetControl = this.txt_plt_name;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting3);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(109, 42);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(25, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
    "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
    "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_plt.TabIndex = 556;
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt_name
            // 
            this.txt_plt_name.Enabled = false;
            this.txt_plt_name.Location = new System.Drawing.Point(134, 42);
            this.txt_plt_name.Name = "txt_plt_name";
            this.txt_plt_name.Size = new System.Drawing.Size(98, 22);
            this.txt_plt_name.TabIndex = 557;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_MPLATE_NO);
            this.groupBox1.Controls.Add(this.TXT_PRODCD);
            this.groupBox1.Controls.Add(this.txt_Loc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_plt_name);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_WkPlt);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.TXT_INQNO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_PrcLine
            // 
            this.txt_PrcLine.Location = new System.Drawing.Point(446, 14);
            this.txt_PrcLine.Name = "txt_PrcLine";
            this.txt_PrcLine.Size = new System.Drawing.Size(32, 22);
            this.txt_PrcLine.TabIndex = 564;
            this.txt_PrcLine.Text = "C";
            this.txt_PrcLine.Visible = false;
            // 
            // TXT_MPLATE_NO
            // 
            this.TXT_MPLATE_NO.Location = new System.Drawing.Point(800, 22);
            this.TXT_MPLATE_NO.Name = "TXT_MPLATE_NO";
            this.TXT_MPLATE_NO.Size = new System.Drawing.Size(32, 22);
            this.TXT_MPLATE_NO.TabIndex = 563;
            this.TXT_MPLATE_NO.Visible = false;
            // 
            // TXT_PRODCD
            // 
            this.TXT_PRODCD.Location = new System.Drawing.Point(762, 22);
            this.TXT_PRODCD.Name = "TXT_PRODCD";
            this.TXT_PRODCD.Size = new System.Drawing.Size(32, 22);
            this.TXT_PRODCD.TabIndex = 562;
            this.TXT_PRODCD.Visible = false;
            // 
            // txt_Loc
            // 
            this.txt_Loc.Location = new System.Drawing.Point(589, 42);
            this.txt_Loc.MaxLength = 7;
            this.txt_Loc.Name = "txt_Loc";
            this.txt_Loc.Size = new System.Drawing.Size(124, 22);
            this.txt_Loc.TabIndex = 561;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(503, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 560;
            this.label2.Text = "垛位号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Location = new System.Drawing.Point(336, 14);
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(86, 21);
            this.cbo_PrcLine.TabIndex = 559;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(249, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 558;
            this.label1.Text = "产线分类";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(27, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 555;
            this.label5.Text = "生产工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(27, 14);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 22);
            this.label35.TabIndex = 104;
            this.label35.Text = "作业工厂";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_INQNO
            // 
            this.TXT_INQNO.Location = new System.Drawing.Point(335, 42);
            this.TXT_INQNO.MaxLength = 14;
            this.TXT_INQNO.Name = "TXT_INQNO";
            this.TXT_INQNO.Size = new System.Drawing.Size(124, 22);
            this.TXT_INQNO.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(249, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 102;
            this.label6.Text = "材料号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss2);
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 552);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 196);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1051, 353);
            this.ss2.TabIndex = 2;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1051, 178);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // AGC2051C
            // 
            this.ClientSize = new System.Drawing.Size(1057, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AGC2051C";
            this.Text = "钢板分板实绩修改界面_AGC2051C";
            this.Load += new System.EventHandler(this.AGC2051C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private CommonClass.F4ETCR txt_WkPlt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox TXT_INQNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PrcLine;
        private System.Windows.Forms.TextBox TXT_MPLATE_NO;
        private System.Windows.Forms.TextBox TXT_PRODCD;
        private System.Windows.Forms.TextBox txt_Loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_plt_name;
        public CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label5;
    }
}
