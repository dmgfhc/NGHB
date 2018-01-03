namespace CG
{
    partial class CGT2101C
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
            this.TXT_STDSPEC = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_CD = new System.Windows.Forms.TextBox();
            this.SSP6 = new System.Windows.Forms.Button();
            this.SSP5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OPT_MILL = new System.Windows.Forms.RadioButton();
            this.OPT_SMSMILL = new System.Windows.Forms.RadioButton();
            this.TXT_MILL_DATE_TO = new CommonClass.CeriUDate();
            this.TXT_MILL_DATE = new CommonClass.CeriUDate();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_LEN_TO = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_LEN = new CommonClass.NumBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_TRNS_CMPY_CD = new System.Windows.Forms.TextBox();
            this.TXT_CUST_CD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_WID_TO = new CommonClass.NumBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_WID = new CommonClass.NumBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_SURFGRD = new System.Windows.Forms.ComboBox();
            this.TXT_ORD_ITEM = new System.Windows.Forms.TextBox();
            this.TXT_ORD_NO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_THK_TO = new CommonClass.NumBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_THK = new CommonClass.NumBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_PRODGRD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_STDSPEC
            // 
            bControlFiledSetting1.ColumnID = "StdSPEC";
            bControlFiledSetting1.TargetControl = this.TXT_STDSPEC;
            this.TXT_STDSPEC.CustomSetting.Add(bControlFiledSetting1);
            this.TXT_STDSPEC.InputControl = this.TXT_STDSPEC;
            this.TXT_STDSPEC.Location = new System.Drawing.Point(893, 47);
            this.TXT_STDSPEC.MaxLength = 18;
            this.TXT_STDSPEC.Name = "TXT_STDSPEC";
            this.TXT_STDSPEC.Size = new System.Drawing.Size(132, 22);
            this.TXT_STDSPEC.sJoin = "";
            this.TXT_STDSPEC.sSqletc = "SELECT StdSPEC \"标准代号\", StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind" +
    "(\'Q0025\',STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\", STDSPEC_NAME_CHN \"标准" +
    "中文名\" FROM  NISCO.QP_STD_HEAD";
            this.TXT_STDSPEC.TabIndex = 248;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_CD);
            this.groupBox1.Controls.Add(this.SSP6);
            this.groupBox1.Controls.Add(this.SSP5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TXT_MILL_DATE_TO);
            this.groupBox1.Controls.Add(this.TXT_MILL_DATE);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TXT_STDSPEC);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TXT_LEN_TO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TXT_LEN);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TXT_TRNS_CMPY_CD);
            this.groupBox1.Controls.Add(this.TXT_CUST_CD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TXT_WID_TO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_WID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBO_SURFGRD);
            this.groupBox1.Controls.Add(this.TXT_ORD_ITEM);
            this.groupBox1.Controls.Add(this.TXT_ORD_NO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_THK_TO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_THK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_PRODGRD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1310, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_CD
            // 
            this.TXT_CD.Location = new System.Drawing.Point(1262, 53);
            this.TXT_CD.Name = "TXT_CD";
            this.TXT_CD.Size = new System.Drawing.Size(36, 22);
            this.TXT_CD.TabIndex = 261;
            this.TXT_CD.Visible = false;
            // 
            // SSP6
            // 
            this.SSP6.BackColor = System.Drawing.Color.Fuchsia;
            this.SSP6.FlatAppearance.BorderSize = 0;
            this.SSP6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SSP6.Location = new System.Drawing.Point(1125, 45);
            this.SSP6.Name = "SSP6";
            this.SSP6.Size = new System.Drawing.Size(90, 24);
            this.SSP6.TabIndex = 260;
            this.SSP6.Text = "出口订单";
            this.SSP6.UseVisualStyleBackColor = false;
            // 
            // SSP5
            // 
            this.SSP5.BackColor = System.Drawing.Color.Blue;
            this.SSP5.FlatAppearance.BorderSize = 0;
            this.SSP5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SSP5.Location = new System.Drawing.Point(1125, 14);
            this.SSP5.Name = "SSP5";
            this.SSP5.Size = new System.Drawing.Size(90, 24);
            this.SSP5.TabIndex = 259;
            this.SSP5.Text = "定制配送";
            this.SSP5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OPT_MILL);
            this.panel1.Controls.Add(this.OPT_SMSMILL);
            this.panel1.Location = new System.Drawing.Point(1122, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 36);
            this.panel1.TabIndex = 252;
            // 
            // OPT_MILL
            // 
            this.OPT_MILL.AutoSize = true;
            this.OPT_MILL.Location = new System.Drawing.Point(73, 10);
            this.OPT_MILL.Name = "OPT_MILL";
            this.OPT_MILL.Size = new System.Drawing.Size(51, 17);
            this.OPT_MILL.TabIndex = 1;
            this.OPT_MILL.TabStop = true;
            this.OPT_MILL.Text = "轧钢";
            this.OPT_MILL.UseVisualStyleBackColor = true;
            this.OPT_MILL.Visible = false;
            // 
            // OPT_SMSMILL
            // 
            this.OPT_SMSMILL.AutoSize = true;
            this.OPT_SMSMILL.Location = new System.Drawing.Point(3, 10);
            this.OPT_SMSMILL.Name = "OPT_SMSMILL";
            this.OPT_SMSMILL.Size = new System.Drawing.Size(51, 17);
            this.OPT_SMSMILL.TabIndex = 0;
            this.OPT_SMSMILL.TabStop = true;
            this.OPT_SMSMILL.Text = "综合";
            this.OPT_SMSMILL.UseVisualStyleBackColor = true;
            this.OPT_SMSMILL.Visible = false;
            // 
            // TXT_MILL_DATE_TO
            // 
            this.TXT_MILL_DATE_TO.Location = new System.Drawing.Point(1010, 19);
            this.TXT_MILL_DATE_TO.Name = "TXT_MILL_DATE_TO";
            this.TXT_MILL_DATE_TO.RawDate = "";
            this.TXT_MILL_DATE_TO.Size = new System.Drawing.Size(97, 21);
            this.TXT_MILL_DATE_TO.TabIndex = 251;
            // 
            // TXT_MILL_DATE
            // 
            this.TXT_MILL_DATE.Location = new System.Drawing.Point(893, 19);
            this.TXT_MILL_DATE.Name = "TXT_MILL_DATE";
            this.TXT_MILL_DATE.RawDate = "";
            this.TXT_MILL_DATE.Size = new System.Drawing.Size(97, 21);
            this.TXT_MILL_DATE.TabIndex = 250;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(991, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 249;
            this.label16.Tag = "user";
            this.label16.Text = "~";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(807, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 247;
            this.label15.Text = "班别";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(893, 79);
            this.CBO_GROUP.MaxLength = 32767;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(64, 21);
            this.CBO_GROUP.TabIndex = 246;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(807, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 245;
            this.label14.Text = "标准号";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(807, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 244;
            this.label13.Text = "轧制日期";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LEN_TO
            // 
            this.TXT_LEN_TO.Location = new System.Drawing.Point(715, 81);
            this.TXT_LEN_TO.Name = "TXT_LEN_TO";
            this.TXT_LEN_TO.NumValue = 0D;
            this.TXT_LEN_TO.Scale = 1;
            this.TXT_LEN_TO.ShowZero = true;
            this.TXT_LEN_TO.Size = new System.Drawing.Size(53, 22);
            this.TXT_LEN_TO.TabIndex = 243;
            this.TXT_LEN_TO.Text = "0.0";
            this.TXT_LEN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(695, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 242;
            this.label11.Tag = "user";
            this.label11.Text = "~";
            // 
            // TXT_LEN
            // 
            this.TXT_LEN.Location = new System.Drawing.Point(636, 81);
            this.TXT_LEN.Name = "TXT_LEN";
            this.TXT_LEN.NumValue = 0D;
            this.TXT_LEN.Scale = 1;
            this.TXT_LEN.ShowZero = true;
            this.TXT_LEN.Size = new System.Drawing.Size(53, 22);
            this.TXT_LEN.TabIndex = 241;
            this.TXT_LEN.Text = "0.0";
            this.TXT_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(550, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 240;
            this.label12.Text = "长度";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_TRNS_CMPY_CD
            // 
            this.TXT_TRNS_CMPY_CD.Location = new System.Drawing.Point(636, 48);
            this.TXT_TRNS_CMPY_CD.MaxLength = 4;
            this.TXT_TRNS_CMPY_CD.Name = "TXT_TRNS_CMPY_CD";
            this.TXT_TRNS_CMPY_CD.Size = new System.Drawing.Size(112, 22);
            this.TXT_TRNS_CMPY_CD.TabIndex = 239;
            // 
            // TXT_CUST_CD
            // 
            this.TXT_CUST_CD.Location = new System.Drawing.Point(636, 16);
            this.TXT_CUST_CD.MaxLength = 6;
            this.TXT_CUST_CD.Name = "TXT_CUST_CD";
            this.TXT_CUST_CD.Size = new System.Drawing.Size(112, 22);
            this.TXT_CUST_CD.TabIndex = 238;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(550, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 236;
            this.label10.Text = "分段号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(550, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 235;
            this.label9.Text = "用户代码";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_WID_TO
            // 
            this.TXT_WID_TO.Location = new System.Drawing.Point(441, 81);
            this.TXT_WID_TO.Name = "TXT_WID_TO";
            this.TXT_WID_TO.NumValue = 0D;
            this.TXT_WID_TO.Scale = 2;
            this.TXT_WID_TO.ShowZero = true;
            this.TXT_WID_TO.Size = new System.Drawing.Size(53, 22);
            this.TXT_WID_TO.TabIndex = 234;
            this.TXT_WID_TO.Text = "0.00";
            this.TXT_WID_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 233;
            this.label6.Tag = "user";
            this.label6.Text = "~";
            // 
            // TXT_WID
            // 
            this.TXT_WID.Location = new System.Drawing.Point(362, 81);
            this.TXT_WID.Name = "TXT_WID";
            this.TXT_WID.NumValue = 0D;
            this.TXT_WID.Scale = 2;
            this.TXT_WID.ShowZero = true;
            this.TXT_WID.Size = new System.Drawing.Size(53, 22);
            this.TXT_WID.TabIndex = 232;
            this.TXT_WID.Text = "0.00";
            this.TXT_WID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(276, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 231;
            this.label7.Text = "宽度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(276, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 230;
            this.label4.Text = "表面等级";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            "7：废品"});
            this.CBO_SURFGRD.Location = new System.Drawing.Point(362, 49);
            this.CBO_SURFGRD.MaxLength = 32767;
            this.CBO_SURFGRD.Name = "CBO_SURFGRD";
            this.CBO_SURFGRD.Size = new System.Drawing.Size(64, 21);
            this.CBO_SURFGRD.TabIndex = 229;
            // 
            // TXT_ORD_ITEM
            // 
            this.TXT_ORD_ITEM.Location = new System.Drawing.Point(475, 16);
            this.TXT_ORD_ITEM.MaxLength = 2;
            this.TXT_ORD_ITEM.Name = "TXT_ORD_ITEM";
            this.TXT_ORD_ITEM.Size = new System.Drawing.Size(47, 22);
            this.TXT_ORD_ITEM.TabIndex = 228;
            // 
            // TXT_ORD_NO
            // 
            this.TXT_ORD_NO.Location = new System.Drawing.Point(362, 16);
            this.TXT_ORD_NO.MaxLength = 11;
            this.TXT_ORD_NO.Name = "TXT_ORD_NO";
            this.TXT_ORD_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_ORD_NO.TabIndex = 227;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(276, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 226;
            this.label3.Text = "订单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_THK_TO
            // 
            this.TXT_THK_TO.Location = new System.Drawing.Point(195, 83);
            this.TXT_THK_TO.Name = "TXT_THK_TO";
            this.TXT_THK_TO.NumValue = 0D;
            this.TXT_THK_TO.Scale = 2;
            this.TXT_THK_TO.ShowZero = true;
            this.TXT_THK_TO.Size = new System.Drawing.Size(53, 22);
            this.TXT_THK_TO.TabIndex = 225;
            this.TXT_THK_TO.Text = "0.00";
            this.TXT_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 224;
            this.label5.Tag = "user";
            this.label5.Text = "~";
            // 
            // TXT_THK
            // 
            this.TXT_THK.Location = new System.Drawing.Point(116, 83);
            this.TXT_THK.Name = "TXT_THK";
            this.TXT_THK.NumValue = 0D;
            this.TXT_THK.Scale = 2;
            this.TXT_THK.ShowZero = true;
            this.TXT_THK.Size = new System.Drawing.Size(53, 22);
            this.TXT_THK.TabIndex = 223;
            this.TXT_THK.Text = "0.00";
            this.TXT_THK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 222;
            this.label2.Text = "厚度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 221;
            this.label1.Text = "产品等级";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CBO_PRODGRD.Location = new System.Drawing.Point(116, 51);
            this.CBO_PRODGRD.MaxLength = 32767;
            this.CBO_PRODGRD.Name = "CBO_PRODGRD";
            this.CBO_PRODGRD.Size = new System.Drawing.Size(64, 21);
            this.CBO_PRODGRD.TabIndex = 220;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(30, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 219;
            this.label8.Text = "板坯号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(116, 18);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_SLAB_NO.TabIndex = 218;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 121);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1310, 501);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2101C
            // 
            this.ClientSize = new System.Drawing.Size(1310, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2101C";
            this.Text = "物料全息查询_CGT2101C";
            this.Load += new System.EventHandler(this.CGT2101C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_PRODGRD;
        private System.Windows.Forms.Label label8;
        private CommonClass.NumBox TXT_THK;
        private System.Windows.Forms.Label label2;
        private CommonClass.NumBox TXT_THK_TO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CommonClass.NumBox TXT_WID_TO;
        private System.Windows.Forms.Label label6;
        private CommonClass.NumBox TXT_WID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_SURFGRD;
        private System.Windows.Forms.TextBox TXT_ORD_ITEM;
        private System.Windows.Forms.TextBox TXT_ORD_NO;
        private CommonClass.NumBox TXT_LEN_TO;
        private System.Windows.Forms.Label label11;
        private CommonClass.NumBox TXT_LEN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_TRNS_CMPY_CD;
        private System.Windows.Forms.TextBox TXT_CUST_CD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private CommonClass.F4ETCR TXT_STDSPEC;
        private CommonClass.CeriUDate TXT_MILL_DATE_TO;
        private CommonClass.CeriUDate TXT_MILL_DATE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OPT_MILL;
        private System.Windows.Forms.RadioButton OPT_SMSMILL;
        private System.Windows.Forms.Button SSP6;
        private System.Windows.Forms.Button SSP5;
        private System.Windows.Forms.TextBox TXT_CD;
    }
}
