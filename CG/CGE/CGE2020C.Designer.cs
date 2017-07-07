namespace CG
{
    partial class CGE2020C
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
            CommonClass.BControlFiledSetting bControlFiledSetting3 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting4 = new CommonClass.BControlFiledSetting();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CGE2020C));
            this.CBO_CUR_INV = new CommonClass.F4ETCR();
            this.text_cur_inv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_PrcLine = new System.Windows.Forms.TextBox();
            this.opt_LineFlag2 = new System.Windows.Forms.RadioButton();
            this.opt_LineFlag1 = new System.Windows.Forms.RadioButton();
            this.opt_LineFlag0 = new System.Windows.Forms.RadioButton();
            this.TXT_MAX_WGT = new CommonClass.NumBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.TXT_WGT = new CommonClass.NumBox();
            this.TXT_CNT = new CommonClass.NumBox();
            this.SDB_THK = new CommonClass.NumBox();
            this.txt_stdspec_chg = new CommonClass.F4ETCN();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.txt_f_addr = new CommonClass.F4COMN();
            this.txt_t_addr = new CommonClass.F4COMN();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ULabel6 = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
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
            // CBO_CUR_INV
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.CBO_CUR_INV;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.text_cur_inv;
            this.CBO_CUR_INV.CustomSetting.Add(bControlFiledSetting3);
            this.CBO_CUR_INV.CustomSetting.Add(bControlFiledSetting4);
            this.CBO_CUR_INV.InputControl = this.CBO_CUR_INV;
            this.CBO_CUR_INV.Location = new System.Drawing.Point(197, 15);
            this.CBO_CUR_INV.MaxLength = 2;
            this.CBO_CUR_INV.Name = "CBO_CUR_INV";
            this.CBO_CUR_INV.Size = new System.Drawing.Size(33, 22);
            this.CBO_CUR_INV.sJoin = "";
            this.CBO_CUR_INV.sSqletc = resources.GetString("CBO_CUR_INV.sSqletc");
            this.CBO_CUR_INV.TabIndex = 131;
            // 
            // text_cur_inv
            // 
            this.text_cur_inv.Location = new System.Drawing.Point(228, 15);
            this.text_cur_inv.Name = "text_cur_inv";
            this.text_cur_inv.Size = new System.Drawing.Size(82, 22);
            this.text_cur_inv.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TXT_MAX_WGT);
            this.groupBox1.Controls.Add(this.CBO_CUR_INV);
            this.groupBox1.Controls.Add(this.text_cur_inv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.TXT_WGT);
            this.groupBox1.Controls.Add(this.TXT_CNT);
            this.groupBox1.Controls.Add(this.SDB_THK);
            this.groupBox1.Controls.Add(this.txt_stdspec_chg);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.txt_f_addr);
            this.groupBox1.Controls.Add(this.txt_t_addr);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ULabel6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 110);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_PrcLine);
            this.groupBox3.Controls.Add(this.opt_LineFlag2);
            this.groupBox3.Controls.Add(this.opt_LineFlag1);
            this.groupBox3.Controls.Add(this.opt_LineFlag0);
            this.groupBox3.Location = new System.Drawing.Point(13, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 89);
            this.groupBox3.TabIndex = 133;
            this.groupBox3.TabStop = false;
            // 
            // txt_PrcLine
            // 
            this.txt_PrcLine.Location = new System.Drawing.Point(73, 21);
            this.txt_PrcLine.Name = "txt_PrcLine";
            this.txt_PrcLine.Size = new System.Drawing.Size(21, 22);
            this.txt_PrcLine.TabIndex = 3;
            this.txt_PrcLine.Visible = false;
            // 
            // opt_LineFlag2
            // 
            this.opt_LineFlag2.AutoSize = true;
            this.opt_LineFlag2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_LineFlag2.ForeColor = System.Drawing.Color.Red;
            this.opt_LineFlag2.Location = new System.Drawing.Point(21, 58);
            this.opt_LineFlag2.Name = "opt_LineFlag2";
            this.opt_LineFlag2.Size = new System.Drawing.Size(53, 17);
            this.opt_LineFlag2.TabIndex = 2;
            this.opt_LineFlag2.TabStop = true;
            this.opt_LineFlag2.Text = "全线";
            this.opt_LineFlag2.UseVisualStyleBackColor = true;
            this.opt_LineFlag2.CheckedChanged += new System.EventHandler(this.opt_LineFlag2_CheckedChanged);
            // 
            // opt_LineFlag1
            // 
            this.opt_LineFlag1.AutoSize = true;
            this.opt_LineFlag1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_LineFlag1.ForeColor = System.Drawing.Color.Red;
            this.opt_LineFlag1.Location = new System.Drawing.Point(21, 35);
            this.opt_LineFlag1.Name = "opt_LineFlag1";
            this.opt_LineFlag1.Size = new System.Drawing.Size(67, 17);
            this.opt_LineFlag1.TabIndex = 1;
            this.opt_LineFlag1.TabStop = true;
            this.opt_LineFlag1.Text = "二号线";
            this.opt_LineFlag1.UseVisualStyleBackColor = true;
            this.opt_LineFlag1.CheckedChanged += new System.EventHandler(this.opt_LineFlag1_CheckedChanged);
            // 
            // opt_LineFlag0
            // 
            this.opt_LineFlag0.AutoSize = true;
            this.opt_LineFlag0.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_LineFlag0.Location = new System.Drawing.Point(21, 10);
            this.opt_LineFlag0.Name = "opt_LineFlag0";
            this.opt_LineFlag0.Size = new System.Drawing.Size(67, 17);
            this.opt_LineFlag0.TabIndex = 0;
            this.opt_LineFlag0.TabStop = true;
            this.opt_LineFlag0.Text = "一号线";
            this.opt_LineFlag0.UseVisualStyleBackColor = true;
            this.opt_LineFlag0.CheckedChanged += new System.EventHandler(this.opt_LineFlag0_CheckedChanged);
            // 
            // TXT_MAX_WGT
            // 
            this.TXT_MAX_WGT.BackColor = System.Drawing.Color.White;
            this.TXT_MAX_WGT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXT_MAX_WGT.ForeColor = System.Drawing.Color.Crimson;
            this.TXT_MAX_WGT.Location = new System.Drawing.Point(920, 77);
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
            this.label5.Location = new System.Drawing.Point(840, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 128;
            this.label5.Text = "最大量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(409, 15);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 24);
            this.SDT_PROD_DATE_FROM.TabIndex = 124;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(524, 15);
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
            this.TXT_WGT.Location = new System.Drawing.Point(512, 77);
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
            this.TXT_CNT.Location = new System.Drawing.Point(467, 77);
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
            this.SDB_THK.Location = new System.Drawing.Point(712, 45);
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
            this.txt_stdspec_chg.Location = new System.Drawing.Point(409, 45);
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
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(197, 77);
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(113, 22);
            this.TXT_PLATE_NO.TabIndex = 3;
            // 
            // txt_f_addr
            // 
            this.txt_f_addr.Location = new System.Drawing.Point(196, 45);
            this.txt_f_addr.MaxLength = 7;
            this.txt_f_addr.Name = "txt_f_addr";
            this.txt_f_addr.Size = new System.Drawing.Size(114, 22);
            this.txt_f_addr.sJoin = "";
            this.txt_f_addr.sKey = "F0037";
            this.txt_f_addr.TabIndex = 7;
            // 
            // txt_t_addr
            // 
            this.txt_t_addr.Location = new System.Drawing.Point(712, 77);
            this.txt_t_addr.MaxLength = 7;
            this.txt_t_addr.Name = "txt_t_addr";
            this.txt_t_addr.Size = new System.Drawing.Size(106, 22);
            this.txt_t_addr.sJoin = "";
            this.txt_t_addr.sKey = "F0037";
            this.txt_t_addr.TabIndex = 8;
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
            this.CBO_SHIFT.Location = new System.Drawing.Point(686, 15);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(43, 22);
            this.CBO_SHIFT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(507, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "～";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(339, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "件数/重量(吨)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(126, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "物料号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(642, 15);
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
            this.label16.Location = new System.Drawing.Point(126, 45);
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
            this.label9.Location = new System.Drawing.Point(642, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "厚 度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel6
            // 
            this.ULabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel6.ForeColor = System.Drawing.Color.Blue;
            this.ULabel6.Location = new System.Drawing.Point(642, 77);
            this.ULabel6.Name = "ULabel6";
            this.ULabel6.Size = new System.Drawing.Size(69, 22);
            this.ULabel6.TabIndex = 3;
            this.ULabel6.Tag = "f4";
            this.ULabel6.Text = "目标垛位";
            this.ULabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULabel6.DoubleClick += new System.EventHandler(this.ULabel6_DoubleClick);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(126, 15);
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
            this.label7.Location = new System.Drawing.Point(339, 45);
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
            this.label1.Location = new System.Drawing.Point(339, 15);
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
            this.groupBox2.Size = new System.Drawing.Size(1262, 512);
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
            this.splitContainer1.Size = new System.Drawing.Size(1256, 491);
            this.splitContainer1.SplitterDistance = 665;
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
            this.ss1.Size = new System.Drawing.Size(665, 491);
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
            this.ss2.Size = new System.Drawing.Size(587, 491);
            this.ss2.TabIndex = 15;
            this.ss2.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss2_CellDoubleClick);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // CGE2020C
            // 
            this.ClientSize = new System.Drawing.Size(1262, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGE2020C";
            this.Text = "在线钢板入库界面_CGE2020C";
            this.Load += new System.EventHandler(this.CGE2020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ULabel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
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
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCR CBO_CUR_INV;
        private System.Windows.Forms.TextBox text_cur_inv;
        private CommonClass.NumBox TXT_MAX_WGT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton opt_LineFlag0;
        private System.Windows.Forms.TextBox txt_PrcLine;
        private System.Windows.Forms.RadioButton opt_LineFlag2;
        private System.Windows.Forms.RadioButton opt_LineFlag1;
    }
}
