namespace CG
{
    partial class CGT2050C
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
            this.txt_stdspec_chg = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SDB_LEN_TO = new CommonClass.NumBox();
            this.SDB_WID_TO = new CommonClass.NumBox();
            this.SDB_THK_TO = new CommonClass.NumBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SDB_LEN = new CommonClass.NumBox();
            this.SDB_WID = new CommonClass.NumBox();
            this.SDB_THK = new CommonClass.NumBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_PRODGRD = new System.Windows.Forms.ComboBox();
            this.CBO_SURFGRD = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SSP4 = new System.Windows.Forms.Button();
            this.txt_trns_cmpy_cd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_prc_line = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ord_no = new System.Windows.Forms.TextBox();
            this.txt_ord_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stdspec_chg
            // 
            bControlFiledSetting1.ColumnID = "StdSPEC";
            bControlFiledSetting1.TargetControl = this.txt_stdspec_chg;
            this.txt_stdspec_chg.CustomSetting.Add(bControlFiledSetting1);
            this.txt_stdspec_chg.InputControl = this.txt_stdspec_chg;
            this.txt_stdspec_chg.Location = new System.Drawing.Point(136, 77);
            this.txt_stdspec_chg.MaxLength = 18;
            this.txt_stdspec_chg.Name = "txt_stdspec_chg";
            this.txt_stdspec_chg.Size = new System.Drawing.Size(214, 22);
            this.txt_stdspec_chg.sJoin = "";
            this.txt_stdspec_chg.sSqletc = "SELECT StdSPEC \"标准代号\", StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind" +
    "(\'Q0025\',STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\", STDSPEC_NAME_CHN \"标准" +
    "中文名\" FROM  NISCO.QP_STD_HEAD";
            this.txt_stdspec_chg.TabIndex = 199;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.SDB_LEN_TO);
            this.groupBox1.Controls.Add(this.SDB_WID_TO);
            this.groupBox1.Controls.Add(this.SDB_THK_TO);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.SDB_LEN);
            this.groupBox1.Controls.Add(this.SDB_WID);
            this.groupBox1.Controls.Add(this.SDB_THK);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBO_PRODGRD);
            this.groupBox1.Controls.Add(this.CBO_SURFGRD);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.txt_trns_cmpy_cd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_prc_line);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_stdspec_chg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ord_no);
            this.groupBox1.Controls.Add(this.txt_ord_item);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(982, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 278;
            this.label18.Tag = "user";
            this.label18.Text = "~";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(982, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 277;
            this.label19.Tag = "user";
            this.label19.Text = "~";
            // 
            // SDB_LEN_TO
            // 
            this.SDB_LEN_TO.Location = new System.Drawing.Point(1002, 73);
            this.SDB_LEN_TO.Name = "SDB_LEN_TO";
            this.SDB_LEN_TO.NumValue = 0D;
            this.SDB_LEN_TO.Scale = 1;
            this.SDB_LEN_TO.ShowZero = true;
            this.SDB_LEN_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN_TO.TabIndex = 276;
            this.SDB_LEN_TO.Text = "0.0";
            this.SDB_LEN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID_TO
            // 
            this.SDB_WID_TO.Location = new System.Drawing.Point(1002, 44);
            this.SDB_WID_TO.Name = "SDB_WID_TO";
            this.SDB_WID_TO.NumValue = 0D;
            this.SDB_WID_TO.Scale = 2;
            this.SDB_WID_TO.ShowZero = true;
            this.SDB_WID_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID_TO.TabIndex = 275;
            this.SDB_WID_TO.Text = "0.00";
            this.SDB_WID_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK_TO
            // 
            this.SDB_THK_TO.Location = new System.Drawing.Point(1002, 15);
            this.SDB_THK_TO.Name = "SDB_THK_TO";
            this.SDB_THK_TO.NumValue = 0D;
            this.SDB_THK_TO.Scale = 2;
            this.SDB_THK_TO.ShowZero = true;
            this.SDB_THK_TO.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK_TO.TabIndex = 274;
            this.SDB_THK_TO.Text = "0.00";
            this.SDB_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(982, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 273;
            this.label20.Tag = "user";
            this.label20.Text = "~";
            // 
            // SDB_LEN
            // 
            this.SDB_LEN.Location = new System.Drawing.Point(904, 73);
            this.SDB_LEN.Name = "SDB_LEN";
            this.SDB_LEN.NumValue = 0D;
            this.SDB_LEN.Scale = 1;
            this.SDB_LEN.ShowZero = true;
            this.SDB_LEN.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN.TabIndex = 272;
            this.SDB_LEN.Text = "0.0";
            this.SDB_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID
            // 
            this.SDB_WID.Location = new System.Drawing.Point(904, 44);
            this.SDB_WID.Name = "SDB_WID";
            this.SDB_WID.NumValue = 0D;
            this.SDB_WID.Scale = 2;
            this.SDB_WID.ShowZero = true;
            this.SDB_WID.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID.TabIndex = 271;
            this.SDB_WID.Text = "0.00";
            this.SDB_WID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK
            // 
            this.SDB_THK.Location = new System.Drawing.Point(904, 15);
            this.SDB_THK.Name = "SDB_THK";
            this.SDB_THK.NumValue = 0D;
            this.SDB_THK.Scale = 2;
            this.SDB_THK.ShowZero = true;
            this.SDB_THK.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK.TabIndex = 270;
            this.SDB_THK.Text = "0.00";
            this.SDB_THK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(826, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 22);
            this.label21.TabIndex = 269;
            this.label21.Text = "长度";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(826, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 22);
            this.label22.TabIndex = 268;
            this.label22.Text = "宽度";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(826, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 22);
            this.label23.TabIndex = 267;
            this.label23.Text = "厚度";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(661, 75);
            this.TXT_PLATE_NO.MaxLength = 10;
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(130, 22);
            this.TXT_PLATE_NO.TabIndex = 266;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(575, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 265;
            this.label4.Text = "查询号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CBO_PRODGRD.Location = new System.Drawing.Point(731, 48);
            this.CBO_PRODGRD.MaxLength = 32767;
            this.CBO_PRODGRD.Name = "CBO_PRODGRD";
            this.CBO_PRODGRD.Size = new System.Drawing.Size(60, 21);
            this.CBO_PRODGRD.TabIndex = 264;
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
            this.CBO_SURFGRD.Location = new System.Drawing.Point(661, 48);
            this.CBO_SURFGRD.MaxLength = 32767;
            this.CBO_SURFGRD.Name = "CBO_SURFGRD";
            this.CBO_SURFGRD.Size = new System.Drawing.Size(64, 21);
            this.CBO_SURFGRD.TabIndex = 263;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(575, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 262;
            this.label12.Text = "表面/综合";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(731, 17);
            this.CBO_GROUP.MaxLength = 32767;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(60, 21);
            this.CBO_GROUP.TabIndex = 261;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(661, 17);
            this.CBO_SHIFT.MaxLength = 32767;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(64, 21);
            this.CBO_SHIFT.TabIndex = 260;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(575, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 259;
            this.label8.Text = "班次/别";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.Red;
            this.SSP4.FlatAppearance.BorderSize = 0;
            this.SSP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP4.ForeColor = System.Drawing.Color.Blue;
            this.SSP4.Location = new System.Drawing.Point(392, 46);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(90, 24);
            this.SSP4.TabIndex = 258;
            this.SSP4.Text = "重点订单";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // txt_trns_cmpy_cd
            // 
            this.txt_trns_cmpy_cd.Location = new System.Drawing.Point(478, 76);
            this.txt_trns_cmpy_cd.MaxLength = 4;
            this.txt_trns_cmpy_cd.Name = "txt_trns_cmpy_cd";
            this.txt_trns_cmpy_cd.Size = new System.Drawing.Size(64, 22);
            this.txt_trns_cmpy_cd.TabIndex = 210;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(392, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 209;
            this.label5.Text = "分段号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_prc_line
            // 
            this.cbo_prc_line.FormattingEnabled = true;
            this.cbo_prc_line.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_prc_line.Location = new System.Drawing.Point(478, 17);
            this.cbo_prc_line.MaxLength = 32767;
            this.cbo_prc_line.Name = "cbo_prc_line";
            this.cbo_prc_line.Size = new System.Drawing.Size(64, 21);
            this.cbo_prc_line.TabIndex = 208;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(392, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 207;
            this.label9.Text = "产线";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 198;
            this.label3.Text = "标准号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ord_no
            // 
            this.txt_ord_no.Location = new System.Drawing.Point(254, 47);
            this.txt_ord_no.MaxLength = 3;
            this.txt_ord_no.Name = "txt_ord_no";
            this.txt_ord_no.Size = new System.Drawing.Size(47, 22);
            this.txt_ord_no.TabIndex = 197;
            // 
            // txt_ord_item
            // 
            this.txt_ord_item.Location = new System.Drawing.Point(136, 47);
            this.txt_ord_item.MaxLength = 11;
            this.txt_ord_item.Name = "txt_ord_item";
            this.txt_ord_item.Size = new System.Drawing.Size(112, 22);
            this.txt_ord_item.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 195;
            this.label1.Text = "订单/序列";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(253, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 4;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(136, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_FROM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(100, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "生产日期";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 110);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 512);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2050C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2050C";
            this.Text = "中板厂产品检验实绩_CGT2050C";
            this.Load += new System.EventHandler(this.CGT2050C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.Label label2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.TextBox txt_ord_no;
        private System.Windows.Forms.TextBox txt_ord_item;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4ETCR txt_stdspec_chg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_prc_line;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_trns_cmpy_cd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SSP4;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBO_PRODGRD;
        private System.Windows.Forms.ComboBox CBO_SURFGRD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private CommonClass.NumBox SDB_LEN_TO;
        private CommonClass.NumBox SDB_WID_TO;
        private CommonClass.NumBox SDB_THK_TO;
        private System.Windows.Forms.Label label20;
        private CommonClass.NumBox SDB_LEN;
        private CommonClass.NumBox SDB_WID;
        private CommonClass.NumBox SDB_THK;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}
