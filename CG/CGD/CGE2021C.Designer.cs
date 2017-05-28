namespace CG
{
    partial class CGE2021C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CGE2021C));
            this.text_cur_inv_code = new CommonClass.F4ETCR();
            this.text_cur_inv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_MAX_WGT = new CommonClass.NumBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_LOC_WGT = new CommonClass.NumBox();
            this.TXT_LOC_CNT = new CommonClass.NumBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.TXT_WGT = new CommonClass.NumBox();
            this.TXT_CNT = new CommonClass.NumBox();
            this.SDB_THK = new CommonClass.NumBox();
            this.txt_stdspec_chg = new CommonClass.F4ETCN();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.txt_f_addr = new CommonClass.F4COMN();
            this.txt_t_addr = new CommonClass.F4COMN();
            this.CBO_PROD_CD = new System.Windows.Forms.ComboBox();
            this.CBO_SURFGRD = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_cur_inv_code
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.text_cur_inv_code;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.text_cur_inv;
            this.text_cur_inv_code.CustomSetting.Add(bControlFiledSetting1);
            this.text_cur_inv_code.CustomSetting.Add(bControlFiledSetting2);
            this.text_cur_inv_code.InputControl = this.text_cur_inv_code;
            this.text_cur_inv_code.Location = new System.Drawing.Point(81, 17);
            this.text_cur_inv_code.MaxLength = 2;
            this.text_cur_inv_code.Name = "text_cur_inv_code";
            this.text_cur_inv_code.Size = new System.Drawing.Size(33, 22);
            this.text_cur_inv_code.sJoin = "";
            this.text_cur_inv_code.sSqletc = resources.GetString("text_cur_inv_code.sSqletc");
            this.text_cur_inv_code.TabIndex = 131;
            this.text_cur_inv_code.TextChanged += new System.EventHandler(this.text_cur_inv_code_TextChanged);
            // 
            // text_cur_inv
            // 
            this.text_cur_inv.Location = new System.Drawing.Point(112, 17);
            this.text_cur_inv.Name = "text_cur_inv";
            this.text_cur_inv.Size = new System.Drawing.Size(82, 22);
            this.text_cur_inv.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_MAX_WGT);
            this.groupBox1.Controls.Add(this.text_cur_inv_code);
            this.groupBox1.Controls.Add(this.text_cur_inv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_LOC_WGT);
            this.groupBox1.Controls.Add(this.TXT_LOC_CNT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.TXT_WGT);
            this.groupBox1.Controls.Add(this.TXT_CNT);
            this.groupBox1.Controls.Add(this.SDB_THK);
            this.groupBox1.Controls.Add(this.txt_stdspec_chg);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.txt_f_addr);
            this.groupBox1.Controls.Add(this.txt_t_addr);
            this.groupBox1.Controls.Add(this.CBO_PROD_CD);
            this.groupBox1.Controls.Add(this.CBO_SURFGRD);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 110);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // TXT_MAX_WGT
            // 
            this.TXT_MAX_WGT.BackColor = System.Drawing.Color.White;
            this.TXT_MAX_WGT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MAX_WGT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_MAX_WGT.Location = new System.Drawing.Point(1035, 79);
            this.TXT_MAX_WGT.Name = "TXT_MAX_WGT";
            this.TXT_MAX_WGT.NumValue = 0D;
            this.TXT_MAX_WGT.Scale = 3;
            this.TXT_MAX_WGT.ShowZero = false;
            this.TXT_MAX_WGT.Size = new System.Drawing.Size(102, 22);
            this.TXT_MAX_WGT.TabIndex = 132;
            this.TXT_MAX_WGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(955, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 128;
            this.label5.Text = "最大量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LOC_WGT
            // 
            this.TXT_LOC_WGT.BackColor = System.Drawing.Color.White;
            this.TXT_LOC_WGT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_LOC_WGT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_LOC_WGT.Location = new System.Drawing.Point(867, 79);
            this.TXT_LOC_WGT.Name = "TXT_LOC_WGT";
            this.TXT_LOC_WGT.NumValue = 0D;
            this.TXT_LOC_WGT.Scale = 3;
            this.TXT_LOC_WGT.ShowZero = false;
            this.TXT_LOC_WGT.Size = new System.Drawing.Size(82, 22);
            this.TXT_LOC_WGT.TabIndex = 127;
            this.TXT_LOC_WGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_LOC_CNT
            // 
            this.TXT_LOC_CNT.BackColor = System.Drawing.Color.White;
            this.TXT_LOC_CNT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_LOC_CNT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_LOC_CNT.Location = new System.Drawing.Point(822, 79);
            this.TXT_LOC_CNT.Name = "TXT_LOC_CNT";
            this.TXT_LOC_CNT.NumValue = 0D;
            this.TXT_LOC_CNT.Scale = 0;
            this.TXT_LOC_CNT.ShowZero = false;
            this.TXT_LOC_CNT.Size = new System.Drawing.Size(44, 22);
            this.TXT_LOC_CNT.TabIndex = 126;
            this.TXT_LOC_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(711, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 125;
            this.label4.Text = "件数/重量(吨)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE
            // 
            this.SDT_PROD_DATE.Location = new System.Drawing.Point(293, 17);
            this.SDT_PROD_DATE.Name = "SDT_PROD_DATE";
            this.SDT_PROD_DATE.RawDate = "";
            this.SDT_PROD_DATE.Size = new System.Drawing.Size(95, 24);
            this.SDT_PROD_DATE.TabIndex = 124;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(408, 17);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 24);
            this.SDT_PROD_DATE_TO.TabIndex = 123;
            // 
            // TXT_WGT
            // 
            this.TXT_WGT.BackColor = System.Drawing.Color.White;
            this.TXT_WGT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_WGT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_WGT.Location = new System.Drawing.Point(396, 79);
            this.TXT_WGT.Name = "TXT_WGT";
            this.TXT_WGT.NumValue = 0D;
            this.TXT_WGT.Scale = 3;
            this.TXT_WGT.ShowZero = false;
            this.TXT_WGT.Size = new System.Drawing.Size(82, 22);
            this.TXT_WGT.TabIndex = 122;
            this.TXT_WGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_CNT
            // 
            this.TXT_CNT.BackColor = System.Drawing.Color.White;
            this.TXT_CNT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_CNT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_CNT.Location = new System.Drawing.Point(351, 79);
            this.TXT_CNT.Name = "TXT_CNT";
            this.TXT_CNT.NumValue = 0D;
            this.TXT_CNT.Scale = 0;
            this.TXT_CNT.ShowZero = false;
            this.TXT_CNT.Size = new System.Drawing.Size(44, 22);
            this.TXT_CNT.TabIndex = 121;
            this.TXT_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK
            // 
            this.SDB_THK.Location = new System.Drawing.Point(781, 47);
            this.SDB_THK.Name = "SDB_THK";
            this.SDB_THK.NumValue = 0D;
            this.SDB_THK.Scale = 2;
            this.SDB_THK.ShowZero = false;
            this.SDB_THK.Size = new System.Drawing.Size(43, 22);
            this.SDB_THK.TabIndex = 13;
            this.SDB_THK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_stdspec_chg
            // 
            this.txt_stdspec_chg.Location = new System.Drawing.Point(293, 47);
            this.txt_stdspec_chg.MaxLength = 18;
            this.txt_stdspec_chg.Name = "txt_stdspec_chg";
            this.txt_stdspec_chg.sFcontrol = "StdSPEC";
            this.txt_stdspec_chg.Size = new System.Drawing.Size(210, 22);
            this.txt_stdspec_chg.sJoin = "";
            this.txt_stdspec_chg.sSqletc = "SELECT StdSPEC 标准代号, StdSPEC_YY 发布年度, STDSPEC_CHR_CD 标准特性代码, Gf_ComnNameFind(\'Q00" +
    "25\',STDSPEC_CHR_CD) 标准特性名称,  STDSPEC_NAME_ENG 标准英文名, STDSPEC_NAME_CHN 标准中文名 FROM" +
    "  NISCO.QP_STD_HEAD";
            this.txt_stdspec_chg.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(526, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "表面等级";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(81, 79);
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(113, 22);
            this.TXT_PLATE_NO.TabIndex = 3;
            // 
            // txt_f_addr
            // 
            this.txt_f_addr.Location = new System.Drawing.Point(80, 47);
            this.txt_f_addr.MaxLength = 7;
            this.txt_f_addr.Name = "txt_f_addr";
            this.txt_f_addr.Size = new System.Drawing.Size(114, 22);
            this.txt_f_addr.sJoin = "";
            this.txt_f_addr.sKey = "F0037";
            this.txt_f_addr.TabIndex = 7;
            // 
            // txt_t_addr
            // 
            this.txt_t_addr.Location = new System.Drawing.Point(596, 79);
            this.txt_t_addr.MaxLength = 7;
            this.txt_t_addr.Name = "txt_t_addr";
            this.txt_t_addr.Size = new System.Drawing.Size(106, 22);
            this.txt_t_addr.sJoin = "";
            this.txt_t_addr.sKey = "F0037";
            this.txt_t_addr.TabIndex = 8;
            this.txt_t_addr.TextChanged += new System.EventHandler(this.txt_t_addr_TextChanged);
            // 
            // CBO_PROD_CD
            // 
            this.CBO_PROD_CD.Font = new System.Drawing.Font("宋体", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_PROD_CD.FormattingEnabled = true;
            this.CBO_PROD_CD.Items.AddRange(new object[] {
            "PP",
            "MP"});
            this.CBO_PROD_CD.Location = new System.Drawing.Point(781, 17);
            this.CBO_PROD_CD.Name = "CBO_PROD_CD";
            this.CBO_PROD_CD.Size = new System.Drawing.Size(43, 22);
            this.CBO_PROD_CD.TabIndex = 11;
            // 
            // CBO_SURFGRD
            // 
            this.CBO_SURFGRD.Font = new System.Drawing.Font("宋体", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_SURFGRD.FormattingEnabled = true;
            this.CBO_SURFGRD.Items.AddRange(new object[] {
            "1：正品",
            "2：改判",
            "3：协议",
            "4：待判",
            "5：次品",
            "7：废品"});
            this.CBO_SURFGRD.Location = new System.Drawing.Point(597, 47);
            this.CBO_SURFGRD.Name = "CBO_SURFGRD";
            this.CBO_SURFGRD.Size = new System.Drawing.Size(105, 22);
            this.CBO_SURFGRD.TabIndex = 12;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(570, 17);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(43, 22);
            this.CBO_SHIFT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(391, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "～";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(711, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "产品分类";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(223, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "移动件数/重量(吨)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(10, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "物料号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(526, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(10, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 22);
            this.label16.TabIndex = 3;
            this.label16.Tag = "f4";
            this.label16.Text = "起始垛位";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(711, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "厚 度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(526, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 3;
            this.label11.Tag = "f4";
            this.label11.Text = "目标垛位";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(10, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 3;
            this.label12.Tag = "f4";
            this.label12.Text = "当前库";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(223, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 3;
            this.label7.Tag = "f4";
            this.label7.Text = "标准号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(223, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "生产时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 512);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ss1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ss2);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 491);
            this.splitContainer1.SplitterDistance = 612;
            this.splitContainer1.TabIndex = 5;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 0);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(612, 491);
            this.ss1.TabIndex = 14;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            this.ss1.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellDoubleClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(0, 0);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(539, 491);
            this.ss2.TabIndex = 15;
            this.ss2.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss2_CellDoubleClick);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // CGE2021C
            // 
            this.ClientSize = new System.Drawing.Size(1161, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGE2021C";
            this.Text = "中板未入库产品垛位管理界面_CGE2021C";
            this.Load += new System.EventHandler(this.CGE2021C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private CommonClass.F4COMN txt_t_addr;
        private System.Windows.Forms.ComboBox CBO_PROD_CD;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBO_SURFGRD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private CommonClass.F4ETCN txt_stdspec_chg;
        private CommonClass.F4COMN txt_f_addr;
        private CommonClass.NumBox SDB_THK;
        private CommonClass.NumBox TXT_CNT;
        private CommonClass.NumBox TXT_WGT;
        private CommonClass.CeriUDate SDT_PROD_DATE;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.NumBox TXT_LOC_WGT;
        private CommonClass.NumBox TXT_LOC_CNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCR text_cur_inv_code;
        private System.Windows.Forms.TextBox text_cur_inv;
        private CommonClass.NumBox TXT_MAX_WGT;
    }
}
