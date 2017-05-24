namespace CG
{
    partial class AGC2440C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGC2440C));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_HEAT = new System.Windows.Forms.TextBox();
            this.txt_HTM_PLT = new System.Windows.Forms.TextBox();
            this.opt_HTM_PLT1 = new System.Windows.Forms.RadioButton();
            this.opt_HTM_PLT0 = new System.Windows.Forms.RadioButton();
            this.txt_STDSPEC = new CommonClass.F4ETCN();
            this.dtp_TIME_TO = new CommonClass.MaskedDate();
            this.dtp_TIME_FR = new CommonClass.MaskedDate();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PLT = new CommonClass.F4COMN();
            this.txt_OUT_SHEET_NO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_LINE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DH_FL = new System.Windows.Forms.CheckBox();
            this.txt_THK_TO = new CommonClass.NumBox();
            this.txt_THK_FR = new CommonClass.NumBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DATE_TO = new CommonClass.CeriUDate();
            this.dtp_DATE_FR = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_HTM_PLT1);
            this.groupBox1.Controls.Add(this.txt_HEAT);
            this.groupBox1.Controls.Add(this.opt_HTM_PLT0);
            this.groupBox1.Controls.Add(this.txt_HTM_PLT);
            this.groupBox1.Controls.Add(this.txt_STDSPEC);
            this.groupBox1.Controls.Add(this.dtp_TIME_TO);
            this.groupBox1.Controls.Add(this.dtp_TIME_FR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_PLT);
            this.groupBox1.Controls.Add(this.txt_OUT_SHEET_NO);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_PLATE_NO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_THK_TO);
            this.groupBox1.Controls.Add(this.txt_THK_FR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_DATE_TO);
            this.groupBox1.Controls.Add(this.dtp_DATE_FR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_HEAT
            // 
            this.txt_HEAT.Location = new System.Drawing.Point(908, 18);
            this.txt_HEAT.MaxLength = 14;
            this.txt_HEAT.Name = "txt_HEAT";
            this.txt_HEAT.Size = new System.Drawing.Size(24, 22);
            this.txt_HEAT.TabIndex = 537;
            this.txt_HEAT.Visible = false;
            // 
            // txt_HTM_PLT
            // 
            this.txt_HTM_PLT.Location = new System.Drawing.Point(938, 18);
            this.txt_HTM_PLT.MaxLength = 14;
            this.txt_HTM_PLT.Name = "txt_HTM_PLT";
            this.txt_HTM_PLT.Size = new System.Drawing.Size(31, 22);
            this.txt_HTM_PLT.TabIndex = 536;
            this.txt_HTM_PLT.Visible = false;
            // 
            // opt_HTM_PLT1
            // 
            this.opt_HTM_PLT1.Checked = true;
            this.opt_HTM_PLT1.Location = new System.Drawing.Point(368, 57);
            this.opt_HTM_PLT1.Name = "opt_HTM_PLT1";
            this.opt_HTM_PLT1.Size = new System.Drawing.Size(55, 22);
            this.opt_HTM_PLT1.TabIndex = 74;
            this.opt_HTM_PLT1.TabStop = true;
            this.opt_HTM_PLT1.Text = "中板";
            this.opt_HTM_PLT1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_HTM_PLT1.UseVisualStyleBackColor = true;
            this.opt_HTM_PLT1.CheckedChanged += new System.EventHandler(this.opt_HTM_PLT1_CheckedChanged);
            // 
            // opt_HTM_PLT0
            // 
            this.opt_HTM_PLT0.Location = new System.Drawing.Point(284, 57);
            this.opt_HTM_PLT0.Name = "opt_HTM_PLT0";
            this.opt_HTM_PLT0.Size = new System.Drawing.Size(55, 22);
            this.opt_HTM_PLT0.TabIndex = 73;
            this.opt_HTM_PLT0.Text = "板卷";
            this.opt_HTM_PLT0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_HTM_PLT0.UseVisualStyleBackColor = true;
            // 
            // txt_STDSPEC
            // 
            this.txt_STDSPEC.Location = new System.Drawing.Point(573, 18);
            this.txt_STDSPEC.MaxLength = 14;
            this.txt_STDSPEC.Name = "txt_STDSPEC";
            this.txt_STDSPEC.sFcontrol = "STDSPEC";
            this.txt_STDSPEC.Size = new System.Drawing.Size(100, 22);
            this.txt_STDSPEC.sJoin = "";
            this.txt_STDSPEC.sSqletc = resources.GetString("txt_STDSPEC.sSqletc");
            this.txt_STDSPEC.TabIndex = 535;
            // 
            // dtp_TIME_TO
            // 
            this.dtp_TIME_TO.Location = new System.Drawing.Point(646, 57);
            this.dtp_TIME_TO.Mask = "0000-00-00 90:00:00";
            this.dtp_TIME_TO.Name = "dtp_TIME_TO";
            this.dtp_TIME_TO.Size = new System.Drawing.Size(72, 22);
            this.dtp_TIME_TO.TabIndex = 534;
            // 
            // dtp_TIME_FR
            // 
            this.dtp_TIME_FR.Location = new System.Drawing.Point(568, 57);
            this.dtp_TIME_FR.Mask = "0000-00-00 90:00:00";
            this.dtp_TIME_FR.Name = "dtp_TIME_FR";
            this.dtp_TIME_FR.Size = new System.Drawing.Size(72, 22);
            this.dtp_TIME_FR.TabIndex = 533;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(487, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 532;
            this.label7.Text = "时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PLT
            // 
            this.txt_PLT.Location = new System.Drawing.Point(80, 18);
            this.txt_PLT.Name = "txt_PLT";
            this.txt_PLT.Size = new System.Drawing.Size(97, 22);
            this.txt_PLT.sJoin = "";
            this.txt_PLT.sKey = "C0001";
            this.txt_PLT.TabIndex = 531;
            // 
            // txt_OUT_SHEET_NO
            // 
            this.txt_OUT_SHEET_NO.Location = new System.Drawing.Point(978, 57);
            this.txt_OUT_SHEET_NO.MaxLength = 14;
            this.txt_OUT_SHEET_NO.Name = "txt_OUT_SHEET_NO";
            this.txt_OUT_SHEET_NO.Size = new System.Drawing.Size(102, 22);
            this.txt_OUT_SHEET_NO.TabIndex = 530;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(908, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 529;
            this.label9.Text = "轧批号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PLATE_NO
            // 
            this.txt_PLATE_NO.Location = new System.Drawing.Point(795, 57);
            this.txt_PLATE_NO.MaxLength = 14;
            this.txt_PLATE_NO.Name = "txt_PLATE_NO";
            this.txt_PLATE_NO.Size = new System.Drawing.Size(102, 22);
            this.txt_PLATE_NO.TabIndex = 523;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(727, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 522;
            this.label8.Text = "钢板号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(188, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 518;
            this.label6.Text = "热处理工厂";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_LINE);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_DH_FL);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 31);
            this.panel1.TabIndex = 516;
            // 
            // txt_LINE
            // 
            this.txt_LINE.Location = new System.Drawing.Point(123, 2);
            this.txt_LINE.MaxLength = 14;
            this.txt_LINE.Name = "txt_LINE";
            this.txt_LINE.Size = new System.Drawing.Size(31, 22);
            this.txt_LINE.TabIndex = 498;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(71, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 374;
            this.label5.Text = "产线";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DH_FL
            // 
            this.txt_DH_FL.AutoSize = true;
            this.txt_DH_FL.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txt_DH_FL.Location = new System.Drawing.Point(3, 5);
            this.txt_DH_FL.Name = "txt_DH_FL";
            this.txt_DH_FL.Size = new System.Drawing.Size(65, 17);
            this.txt_DH_FL.TabIndex = 373;
            this.txt_DH_FL.Text = "热处理";
            this.txt_DH_FL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txt_DH_FL.UseVisualStyleBackColor = true;
            this.txt_DH_FL.CheckedChanged += new System.EventHandler(this.txt_DH_FL_CheckedChanged);
            // 
            // txt_THK_TO
            // 
            this.txt_THK_TO.Location = new System.Drawing.Point(849, 18);
            this.txt_THK_TO.MaxLength = 10;
            this.txt_THK_TO.Name = "txt_THK_TO";
            this.txt_THK_TO.NumValue = 0D;
            this.txt_THK_TO.Scale = 0;
            this.txt_THK_TO.ShowZero = true;
            this.txt_THK_TO.Size = new System.Drawing.Size(48, 22);
            this.txt_THK_TO.TabIndex = 513;
            this.txt_THK_TO.Text = "0";
            this.txt_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_THK_FR
            // 
            this.txt_THK_FR.Location = new System.Drawing.Point(795, 18);
            this.txt_THK_FR.MaxLength = 10;
            this.txt_THK_FR.Name = "txt_THK_FR";
            this.txt_THK_FR.NumValue = 0D;
            this.txt_THK_FR.Scale = 0;
            this.txt_THK_FR.ShowZero = true;
            this.txt_THK_FR.Size = new System.Drawing.Size(48, 22);
            this.txt_THK_FR.TabIndex = 512;
            this.txt_THK_FR.Text = "0";
            this.txt_THK_FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(727, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 500;
            this.label3.Text = "厚度";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(487, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 498;
            this.label2.Text = "标准号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DATE_TO
            // 
            this.dtp_DATE_TO.Location = new System.Drawing.Point(368, 18);
            this.dtp_DATE_TO.Name = "dtp_DATE_TO";
            this.dtp_DATE_TO.RawDate = "";
            this.dtp_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.dtp_DATE_TO.TabIndex = 93;
            // 
            // dtp_DATE_FR
            // 
            this.dtp_DATE_FR.Location = new System.Drawing.Point(270, 18);
            this.dtp_DATE_FR.Name = "dtp_DATE_FR";
            this.dtp_DATE_FR.RawDate = "";
            this.dtp_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.dtp_DATE_FR.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(188, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "工厂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 534);
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
            this.ss1.Size = new System.Drawing.Size(1114, 513);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // AGC2440C
            // 
            this.ClientSize = new System.Drawing.Size(1120, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AGC2440C";
            this.Text = "剪切前当班取样项目查询界面_AGC2440C";
            this.Load += new System.EventHandler(this.AGC2440C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate dtp_DATE_TO;
        private CommonClass.CeriUDate dtp_DATE_FR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CommonClass.NumBox txt_THK_FR;
        private CommonClass.NumBox txt_THK_TO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox txt_DH_FL;
        private System.Windows.Forms.TextBox txt_LINE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton opt_HTM_PLT1;
        private System.Windows.Forms.RadioButton opt_HTM_PLT0;
        private System.Windows.Forms.TextBox txt_PLATE_NO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_OUT_SHEET_NO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private CommonClass.F4COMN txt_PLT;
        private CommonClass.MaskedDate dtp_TIME_TO;
        private CommonClass.MaskedDate dtp_TIME_FR;
        private System.Windows.Forms.Label label7;
        private CommonClass.F4ETCN txt_STDSPEC;
        private System.Windows.Forms.TextBox txt_HTM_PLT;
        private System.Windows.Forms.TextBox txt_HEAT;
    }
}
