namespace CG
{
    partial class CGT2060C
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
            this.txt_stdspec = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHK_TO_DATE = new CommonClass.CeriUDate();
            this.CHK_FROM_DATE = new CommonClass.CeriUDate();
            this.CMD_CARD = new System.Windows.Forms.Button();
            this.SSP4 = new System.Windows.Forms.Button();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SDB_LEN_TO = new CommonClass.NumBox();
            this.SDB_LEN = new CommonClass.NumBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SDB_WID_TO = new CommonClass.NumBox();
            this.SDB_WID = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SDB_THK_TO = new CommonClass.NumBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SDB_THK = new CommonClass.NumBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_cut_place = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBO_PRODGRD = new System.Windows.Forms.ComboBox();
            this.CBO_SURFGRD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBO_MILLGROUP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_LOT_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SDT_PROD_TO_DATE = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stdspec
            // 
            bControlFiledSetting1.ColumnID = "StdSPEC";
            bControlFiledSetting1.TargetControl = this.txt_stdspec;
            this.txt_stdspec.CustomSetting.Add(bControlFiledSetting1);
            this.txt_stdspec.InputControl = this.txt_stdspec;
            this.txt_stdspec.Location = new System.Drawing.Point(580, 49);
            this.txt_stdspec.MaxLength = 18;
            this.txt_stdspec.Name = "txt_stdspec";
            this.txt_stdspec.Size = new System.Drawing.Size(207, 22);
            this.txt_stdspec.sJoin = "";
            this.txt_stdspec.sSqletc = "SELECT StdSPEC \"标准代号\", StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind" +
    "(\'Q0025\',STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\", STDSPEC_NAME_CHN \"标准" +
    "中文名\" FROM  NISCO.QP_STD_HEAD";
            this.txt_stdspec.TabIndex = 217;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHK_TO_DATE);
            this.groupBox1.Controls.Add(this.CHK_FROM_DATE);
            this.groupBox1.Controls.Add(this.CMD_CARD);
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.txt_loc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.SDB_LEN_TO);
            this.groupBox1.Controls.Add(this.SDB_LEN);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.SDB_WID_TO);
            this.groupBox1.Controls.Add(this.SDB_WID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.SDB_THK_TO);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.SDB_THK);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbo_cut_place);
            this.groupBox1.Controls.Add(this.txt_stdspec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_PRODGRD);
            this.groupBox1.Controls.Add(this.CBO_SURFGRD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBO_MILLGROUP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXT_LOT_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SDT_PROD_TO_DATE);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CHK_TO_DATE
            // 
            this.CHK_TO_DATE.Location = new System.Drawing.Point(281, 43);
            this.CHK_TO_DATE.Name = "CHK_TO_DATE";
            this.CHK_TO_DATE.RawDate = "";
            this.CHK_TO_DATE.Size = new System.Drawing.Size(25, 21);
            this.CHK_TO_DATE.TabIndex = 261;
            this.CHK_TO_DATE.Visible = false;
            // 
            // CHK_FROM_DATE
            // 
            this.CHK_FROM_DATE.Location = new System.Drawing.Point(250, 45);
            this.CHK_FROM_DATE.Name = "CHK_FROM_DATE";
            this.CHK_FROM_DATE.RawDate = "";
            this.CHK_FROM_DATE.Size = new System.Drawing.Size(25, 21);
            this.CHK_FROM_DATE.TabIndex = 260;
            this.CHK_FROM_DATE.Visible = false;
            // 
            // CMD_CARD
            // 
            this.CMD_CARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_CARD.ForeColor = System.Drawing.Color.Red;
            this.CMD_CARD.Location = new System.Drawing.Point(1080, 43);
            this.CMD_CARD.Name = "CMD_CARD";
            this.CMD_CARD.Size = new System.Drawing.Size(91, 28);
            this.CMD_CARD.TabIndex = 259;
            this.CMD_CARD.Text = "码堆报告";
            this.CMD_CARD.UseVisualStyleBackColor = true;
            this.CMD_CARD.Click += new System.EventHandler(this.CMD_CARD_Click);
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SSP4.FlatAppearance.BorderSize = 0;
            this.SSP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP4.ForeColor = System.Drawing.Color.Blue;
            this.SSP4.Location = new System.Drawing.Point(1081, 78);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(90, 24);
            this.SSP4.TabIndex = 258;
            this.SSP4.Text = "重点订单";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // txt_loc
            // 
            this.txt_loc.Location = new System.Drawing.Point(942, 78);
            this.txt_loc.MaxLength = 9999;
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(112, 22);
            this.txt_loc.TabIndex = 233;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(857, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 22);
            this.label13.TabIndex = 232;
            this.label13.Text = "垛位";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(736, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 231;
            this.label16.Tag = "user";
            this.label16.Text = "~";
            // 
            // SDB_LEN_TO
            // 
            this.SDB_LEN_TO.Location = new System.Drawing.Point(756, 78);
            this.SDB_LEN_TO.Name = "SDB_LEN_TO";
            this.SDB_LEN_TO.NumValue = 0D;
            this.SDB_LEN_TO.Scale = 1;
            this.SDB_LEN_TO.ShowZero = true;
            this.SDB_LEN_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN_TO.TabIndex = 230;
            this.SDB_LEN_TO.Text = "0.0";
            this.SDB_LEN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_LEN
            // 
            this.SDB_LEN.Location = new System.Drawing.Point(658, 78);
            this.SDB_LEN.Name = "SDB_LEN";
            this.SDB_LEN.NumValue = 0D;
            this.SDB_LEN.Scale = 1;
            this.SDB_LEN.ShowZero = true;
            this.SDB_LEN.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN.TabIndex = 229;
            this.SDB_LEN.Text = "0.0";
            this.SDB_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(580, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 22);
            this.label12.TabIndex = 228;
            this.label12.Text = "长度";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(461, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 227;
            this.label15.Tag = "user";
            this.label15.Text = "~";
            // 
            // SDB_WID_TO
            // 
            this.SDB_WID_TO.Location = new System.Drawing.Point(481, 80);
            this.SDB_WID_TO.Name = "SDB_WID_TO";
            this.SDB_WID_TO.NumValue = 0D;
            this.SDB_WID_TO.Scale = 2;
            this.SDB_WID_TO.ShowZero = true;
            this.SDB_WID_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID_TO.TabIndex = 226;
            this.SDB_WID_TO.Text = "0.00";
            this.SDB_WID_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID
            // 
            this.SDB_WID.Location = new System.Drawing.Point(383, 80);
            this.SDB_WID.Name = "SDB_WID";
            this.SDB_WID.NumValue = 0D;
            this.SDB_WID.Scale = 2;
            this.SDB_WID.ShowZero = true;
            this.SDB_WID.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID.TabIndex = 225;
            this.SDB_WID.Text = "0.00";
            this.SDB_WID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(305, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 224;
            this.label11.Text = "宽度";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDB_THK_TO
            // 
            this.SDB_THK_TO.Location = new System.Drawing.Point(202, 80);
            this.SDB_THK_TO.Name = "SDB_THK_TO";
            this.SDB_THK_TO.NumValue = 0D;
            this.SDB_THK_TO.Scale = 2;
            this.SDB_THK_TO.ShowZero = true;
            this.SDB_THK_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK_TO.TabIndex = 223;
            this.SDB_THK_TO.Text = "0.00";
            this.SDB_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 222;
            this.label14.Tag = "user";
            this.label14.Text = "~";
            // 
            // SDB_THK
            // 
            this.SDB_THK.Location = new System.Drawing.Point(104, 80);
            this.SDB_THK.Name = "SDB_THK";
            this.SDB_THK.NumValue = 0D;
            this.SDB_THK.Scale = 2;
            this.SDB_THK.ShowZero = true;
            this.SDB_THK.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK.TabIndex = 221;
            this.SDB_THK.Text = "0.00";
            this.SDB_THK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(26, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 220;
            this.label10.Text = "厚度";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(793, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 219;
            this.label9.Text = "切割场地";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_cut_place
            // 
            this.cbo_cut_place.FormattingEnabled = true;
            this.cbo_cut_place.Items.AddRange(new object[] {
            "中板厂",
            "修建部"});
            this.cbo_cut_place.Location = new System.Drawing.Point(879, 48);
            this.cbo_cut_place.MaxLength = 32767;
            this.cbo_cut_place.Name = "cbo_cut_place";
            this.cbo_cut_place.Size = new System.Drawing.Size(78, 21);
            this.cbo_cut_place.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(474, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 216;
            this.label7.Text = "标准号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(356, 49);
            this.TXT_PLATE_NO.MaxLength = 9999;
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_PLATE_NO.TabIndex = 215;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(250, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 214;
            this.label5.Text = "查询号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_PRODGRD
            // 
            this.CBO_PRODGRD.FormattingEnabled = true;
            this.CBO_PRODGRD.Items.AddRange(new object[] {
            "1：正品",
            "2：改判",
            "3：协议",
            "4：待判",
            "5：次品",
            "7：废品"});
            this.CBO_PRODGRD.Location = new System.Drawing.Point(1033, 16);
            this.CBO_PRODGRD.MaxLength = 32767;
            this.CBO_PRODGRD.Name = "CBO_PRODGRD";
            this.CBO_PRODGRD.Size = new System.Drawing.Size(64, 21);
            this.CBO_PRODGRD.TabIndex = 213;
            // 
            // CBO_SURFGRD
            // 
            this.CBO_SURFGRD.FormattingEnabled = true;
            this.CBO_SURFGRD.Items.AddRange(new object[] {
            "1：正品",
            "2：改判",
            "3：协议",
            "4：待判",
            "5：次品",
            "7：废品",
            "0：修磨"});
            this.CBO_SURFGRD.Location = new System.Drawing.Point(963, 16);
            this.CBO_SURFGRD.MaxLength = 32767;
            this.CBO_SURFGRD.Name = "CBO_SURFGRD";
            this.CBO_SURFGRD.Size = new System.Drawing.Size(64, 21);
            this.CBO_SURFGRD.TabIndex = 212;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(877, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 211;
            this.label4.Text = "表面/综合";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(707, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 210;
            this.label3.Text = "轧制班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_MILLGROUP
            // 
            this.CBO_MILLGROUP.FormattingEnabled = true;
            this.CBO_MILLGROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_MILLGROUP.Location = new System.Drawing.Point(793, 17);
            this.CBO_MILLGROUP.MaxLength = 32767;
            this.CBO_MILLGROUP.Name = "CBO_MILLGROUP";
            this.CBO_MILLGROUP.Size = new System.Drawing.Size(64, 21);
            this.CBO_MILLGROUP.TabIndex = 209;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(542, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 208;
            this.label1.Text = "班别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(628, 18);
            this.CBO_GROUP.MaxLength = 32767;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(64, 21);
            this.CBO_GROUP.TabIndex = 207;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(459, 18);
            this.CBO_SHIFT.MaxLength = 32767;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(64, 21);
            this.CBO_SHIFT.TabIndex = 206;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(373, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 205;
            this.label8.Text = "班次";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LOT_NO
            // 
            this.TXT_LOT_NO.Location = new System.Drawing.Point(132, 49);
            this.TXT_LOT_NO.MaxLength = 14;
            this.TXT_LOT_NO.Name = "TXT_LOT_NO";
            this.TXT_LOT_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_LOT_NO.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 147;
            this.label6.Text = "轧批号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_TO_DATE
            // 
            this.SDT_PROD_TO_DATE.Location = new System.Drawing.Point(249, 18);
            this.SDT_PROD_TO_DATE.Name = "SDT_PROD_TO_DATE";
            this.SDT_PROD_TO_DATE.RawDate = "";
            this.SDT_PROD_TO_DATE.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_TO_DATE.TabIndex = 7;
            // 
            // SDT_PROD_DATE
            // 
            this.SDT_PROD_DATE.Location = new System.Drawing.Point(132, 18);
            this.SDT_PROD_DATE.Name = "SDT_PROD_DATE";
            this.SDT_PROD_DATE.RawDate = "";
            this.SDT_PROD_DATE.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(26, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(100, 21);
            this.ULabel5.TabIndex = 5;
            this.ULabel5.Text = "切割时间";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 115);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 507);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2060C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2060C";
            this.Text = "火切实绩查询界面_CGT2060C";
            this.Load += new System.EventHandler(this.CGT2060C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.CeriUDate SDT_PROD_TO_DATE;
        private CommonClass.CeriUDate SDT_PROD_DATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.TextBox TXT_LOT_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBO_MILLGROUP;
        private System.Windows.Forms.ComboBox CBO_PRODGRD;
        private System.Windows.Forms.ComboBox CBO_SURFGRD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCR txt_stdspec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_cut_place;
        private CommonClass.NumBox SDB_THK_TO;
        private System.Windows.Forms.Label label14;
        private CommonClass.NumBox SDB_THK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private CommonClass.NumBox SDB_WID_TO;
        private CommonClass.NumBox SDB_WID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private CommonClass.NumBox SDB_LEN_TO;
        private CommonClass.NumBox SDB_LEN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_loc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CMD_CARD;
        private System.Windows.Forms.Button SSP4;
        private CommonClass.CeriUDate CHK_TO_DATE;
        private CommonClass.CeriUDate CHK_FROM_DATE;
    }
}
