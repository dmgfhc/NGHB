namespace CG
{
    partial class WGT2012C
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
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_name = new System.Windows.Forms.TextBox();
            this.txt_stdspec = new CommonClass.F4ETCN();
            this.cbo_group = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_loc = new CommonClass.F4COMN();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.udt_date_to = new CommonClass.CeriUDate();
            this.udt_date_fr = new CommonClass.CeriUDate();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_plate_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_plt
            // 
            bControlFiledSetting1.ColumnID = "cd";
            bControlFiledSetting1.TargetControl = this.txt_plt;
            bControlFiledSetting2.ColumnID = "cd_name";
            bControlFiledSetting2.TargetControl = this.txt_plt_name;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting1);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.Enabled = false;
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(86, 14);
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(43, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT cd 代码,cd_short_name 代码简称,cd_name 代码名称,cd_short_eng 代码英文简称,cd_full_eng 代码英文" +
    "名称 FROM ZP_CD WHERE CD_MANA_NO = \'C0001\' ";
            this.txt_plt.TabIndex = 11;
            // 
            // txt_plt_name
            // 
            this.txt_plt_name.Location = new System.Drawing.Point(129, 14);
            this.txt_plt_name.Name = "txt_plt_name";
            this.txt_plt_name.Size = new System.Drawing.Size(102, 22);
            this.txt_plt_name.TabIndex = 12;
            // 
            // txt_stdspec
            // 
            this.txt_stdspec.Location = new System.Drawing.Point(368, 40);
            this.txt_stdspec.Name = "txt_stdspec";
            this.txt_stdspec.sFcontrol = "StdSPEC";
            this.txt_stdspec.Size = new System.Drawing.Size(195, 22);
            this.txt_stdspec.sJoin = "";
            this.txt_stdspec.sSqletc = "SELECT StdSPEC \"标准代号\",StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind(" +
    "\'Q0025\', STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\",STDSPEC_NAME_CHN \"标准中" +
    "文名\" FROM NISCO.QP_STD_HEAD";
            this.txt_stdspec.TabIndex = 26;
            // 
            // cbo_group
            // 
            this.cbo_group.FormattingEnabled = true;
            this.cbo_group.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.cbo_group.Location = new System.Drawing.Point(751, 14);
            this.cbo_group.Name = "cbo_group";
            this.cbo_group.Size = new System.Drawing.Size(52, 21);
            this.cbo_group.TabIndex = 23;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(698, 14);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(52, 21);
            this.CBO_SHIFT.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(590, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 21;
            this.label5.Tag = "";
            this.label5.Text = "班次 / 班别";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(258, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 18;
            this.label4.Tag = "f4";
            this.label4.Text = "标准号 ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_loc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txt_stdspec);
            this.groupBox1.Controls.Add(this.cbo_group);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.udt_date_to);
            this.groupBox1.Controls.Add(this.udt_date_fr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_plate_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_plt_name);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1040, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "钢印";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(967, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "侧喷";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(967, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "表喷";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_loc
            // 
            this.txt_loc.Location = new System.Drawing.Point(698, 40);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(106, 22);
            this.txt_loc.sJoin = "";
            this.txt_loc.sKey = "F0044";
            this.txt_loc.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(590, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 31;
            this.label11.Tag = "f4";
            this.label11.Text = "目标垛位";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "钢板信息导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(910, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "实绩";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(840, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "计划";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // udt_date_to
            // 
            this.udt_date_to.Location = new System.Drawing.Point(466, 14);
            this.udt_date_to.Name = "udt_date_to";
            this.udt_date_to.RawDate = "";
            this.udt_date_to.Size = new System.Drawing.Size(97, 21);
            this.udt_date_to.TabIndex = 17;
            // 
            // udt_date_fr
            // 
            this.udt_date_fr.Location = new System.Drawing.Point(368, 14);
            this.udt_date_fr.Name = "udt_date_fr";
            this.udt_date_fr.RawDate = "";
            this.udt_date_fr.Size = new System.Drawing.Size(97, 21);
            this.udt_date_fr.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(258, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 15;
            this.label3.Tag = "";
            this.label3.Text = "生产日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_plate_no
            // 
            this.txt_plate_no.Location = new System.Drawing.Point(86, 40);
            this.txt_plate_no.MaxLength = 14;
            this.txt_plate_no.Name = "txt_plate_no";
            this.txt_plate_no.Size = new System.Drawing.Size(145, 22);
            this.txt_plate_no.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 13;
            this.label2.Tag = "";
            this.label2.Text = "钢板号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 10;
            this.label1.Tag = "f4";
            this.label1.Text = "生产工厂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 71);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1123, 551);
            this.ss1.TabIndex = 2;
            this.ss1.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.ss1_SelectionChanged);
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGT2012C
            // 
            this.ClientSize = new System.Drawing.Size(1123, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT2012C";
            this.Text = "钢板标印信息查询界面_WGT2012C";
            this.Load += new System.EventHandler(this.WGT2012C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CommonClass.F4ETCN txt_stdspec;
        private System.Windows.Forms.ComboBox cbo_group;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private CommonClass.CeriUDate udt_date_to;
        private CommonClass.CeriUDate udt_date_fr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_plate_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_plt_name;
        private CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private CommonClass.F4COMN txt_loc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}
