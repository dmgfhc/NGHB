namespace WK
{
    partial class WKB1030C
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
            CommonClass.BControlFiledSetting bControlFiledSetting5 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting6 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting7 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting8 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            this.f4ETCR2 = new CommonClass.F4ETCR();
            this.TXT_PRC_INPUT_NAME = new System.Windows.Forms.TextBox();
            this.f4ETCR3 = new CommonClass.F4ETCR();
            this.txt_main_res_cd = new System.Windows.Forms.TextBox();
            this.f4ETCR1 = new CommonClass.F4ETCR();
            this.TXT_PRC_NAME = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Flag = new System.Windows.Forms.TextBox();
            this.TXT_SCRAP_CD = new System.Windows.Forms.TextBox();
            this.SDB_TOT_WGT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBO_SCRAP_CD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.CBO_SHIFT_REF = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_END_CD = new System.Windows.Forms.TextBox();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.TXT_SCRAP_INPUT = new System.Windows.Forms.TextBox();
            this.CBO_LINE = new System.Windows.Forms.ComboBox();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.CBO_END_CD = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TXT_END_TIME = new CommonClass.CeriUDate();
            this.label19 = new System.Windows.Forms.Label();
            this.TXT_SCRAP_NO = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sdb_ths_d_mat_var = new System.Windows.Forms.TextBox();
            this.cbo_ths_d_mat_var = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_OCCR_TIME = new CommonClass.CeriUDate();
            this.label13 = new System.Windows.Forms.Label();
            this.SDB_SCRAP_WGT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBO_SCRAP_INPUT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // f4ETCR2
            // 
            bControlFiledSetting5.ColumnID = "CD";
            bControlFiledSetting5.TargetControl = this.f4ETCR2;
            bControlFiledSetting6.ColumnID = "cd_name";
            bControlFiledSetting6.TargetControl = this.TXT_PRC_INPUT_NAME;
            this.f4ETCR2.CustomSetting.Add(bControlFiledSetting5);
            this.f4ETCR2.CustomSetting.Add(bControlFiledSetting6);
            this.f4ETCR2.InputControl = this.f4ETCR2;
            this.f4ETCR2.Location = new System.Drawing.Point(75, 20);
            this.f4ETCR2.Name = "f4ETCR2";
            this.f4ETCR2.Size = new System.Drawing.Size(46, 22);
            this.f4ETCR2.sJoin = "";
            this.f4ETCR2.sSqletc = "select t.CD,t.cd_name from ZP_CD t where cd_mana_no = \'C0002\'";
            this.f4ETCR2.TabIndex = 411;
            // 
            // TXT_PRC_INPUT_NAME
            // 
            this.TXT_PRC_INPUT_NAME.Location = new System.Drawing.Point(125, 20);
            this.TXT_PRC_INPUT_NAME.Name = "TXT_PRC_INPUT_NAME";
            this.TXT_PRC_INPUT_NAME.Size = new System.Drawing.Size(95, 22);
            this.TXT_PRC_INPUT_NAME.TabIndex = 412;
            // 
            // f4ETCR3
            // 
            bControlFiledSetting7.ColumnID = "CD";
            bControlFiledSetting7.TargetControl = this.f4ETCR3;
            bControlFiledSetting8.ColumnID = "cd_name";
            bControlFiledSetting8.TargetControl = this.txt_main_res_cd;
            this.f4ETCR3.CustomSetting.Add(bControlFiledSetting7);
            this.f4ETCR3.CustomSetting.Add(bControlFiledSetting8);
            this.f4ETCR3.InputControl = this.f4ETCR3;
            this.f4ETCR3.Location = new System.Drawing.Point(641, 20);
            this.f4ETCR3.Name = "f4ETCR3";
            this.f4ETCR3.Size = new System.Drawing.Size(33, 22);
            this.f4ETCR3.sJoin = "";
            this.f4ETCR3.sSqletc = "select t.CD,t.cd_name from ZP_CD t where cd_mana_no = \'G0017\'";
            this.f4ETCR3.TabIndex = 416;
            // 
            // txt_main_res_cd
            // 
            this.txt_main_res_cd.Location = new System.Drawing.Point(678, 20);
            this.txt_main_res_cd.Name = "txt_main_res_cd";
            this.txt_main_res_cd.Size = new System.Drawing.Size(99, 22);
            this.txt_main_res_cd.TabIndex = 417;
            // 
            // f4ETCR1
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.f4ETCR1;
            bControlFiledSetting2.ColumnID = "cd_name";
            bControlFiledSetting2.TargetControl = this.TXT_PRC_NAME;
            this.f4ETCR1.CustomSetting.Add(bControlFiledSetting1);
            this.f4ETCR1.CustomSetting.Add(bControlFiledSetting2);
            this.f4ETCR1.InputControl = this.f4ETCR1;
            this.f4ETCR1.Location = new System.Drawing.Point(641, 20);
            this.f4ETCR1.Name = "f4ETCR1";
            this.f4ETCR1.Size = new System.Drawing.Size(33, 22);
            this.f4ETCR1.sJoin = "";
            this.f4ETCR1.sSqletc = "select t.CD,t.cd_name from ZP_CD t where cd_mana_no = \'C0002\'";
            this.f4ETCR1.TabIndex = 412;
            // 
            // TXT_PRC_NAME
            // 
            this.TXT_PRC_NAME.Location = new System.Drawing.Point(678, 20);
            this.TXT_PRC_NAME.Name = "TXT_PRC_NAME";
            this.TXT_PRC_NAME.Size = new System.Drawing.Size(99, 22);
            this.TXT_PRC_NAME.TabIndex = 196;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Flag);
            this.groupBox1.Controls.Add(this.TXT_SCRAP_CD);
            this.groupBox1.Controls.Add(this.f4ETCR1);
            this.groupBox1.Controls.Add(this.SDB_TOT_WGT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_SCRAP_CD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.TXT_PRC_NAME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBO_SHIFT_REF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_Flag
            // 
            this.txt_Flag.Location = new System.Drawing.Point(640, 52);
            this.txt_Flag.Name = "txt_Flag";
            this.txt_Flag.Size = new System.Drawing.Size(49, 22);
            this.txt_Flag.TabIndex = 414;
            this.txt_Flag.Text = "C2";
            this.txt_Flag.Visible = false;
            // 
            // TXT_SCRAP_CD
            // 
            this.TXT_SCRAP_CD.Location = new System.Drawing.Point(577, 52);
            this.TXT_SCRAP_CD.Name = "TXT_SCRAP_CD";
            this.TXT_SCRAP_CD.Size = new System.Drawing.Size(49, 22);
            this.TXT_SCRAP_CD.TabIndex = 413;
            this.TXT_SCRAP_CD.Visible = false;
            // 
            // SDB_TOT_WGT
            // 
            this.SDB_TOT_WGT.Location = new System.Drawing.Point(896, 50);
            this.SDB_TOT_WGT.Name = "SDB_TOT_WGT";
            this.SDB_TOT_WGT.Size = new System.Drawing.Size(106, 22);
            this.SDB_TOT_WGT.TabIndex = 203;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(803, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 202;
            this.label7.Text = "废钢总量";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(125, 48);
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(95, 22);
            this.TXT_MAT_NO.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 200;
            this.label5.Text = "查询废钢号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SCRAP_CD
            // 
            this.CBO_SCRAP_CD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SCRAP_CD.FormattingEnabled = true;
            this.CBO_SCRAP_CD.Items.AddRange(new object[] {
            "PP:钢板",
            "MP:母板",
            "SL:板坯"});
            this.CBO_SCRAP_CD.Location = new System.Drawing.Point(896, 20);
            this.CBO_SCRAP_CD.Name = "CBO_SCRAP_CD";
            this.CBO_SCRAP_CD.Size = new System.Drawing.Size(106, 22);
            this.CBO_SCRAP_CD.TabIndex = 199;
            this.CBO_SCRAP_CD.TextChanged += new System.EventHandler(this.CBO_SCRAP_CD_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(803, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 198;
            this.label2.Text = "种类";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(223, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(540, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "工序";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT_REF
            // 
            this.CBO_SHIFT_REF.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT_REF.FormattingEnabled = true;
            this.CBO_SHIFT_REF.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT_REF.Location = new System.Drawing.Point(458, 19);
            this.CBO_SHIFT_REF.Name = "CBO_SHIFT_REF";
            this.CBO_SHIFT_REF.Size = new System.Drawing.Size(62, 22);
            this.CBO_SHIFT_REF.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(360, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(125, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FROM.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "发生日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_END_CD);
            this.groupBox2.Controls.Add(this.txt_UserId);
            this.groupBox2.Controls.Add(this.TXT_SCRAP_INPUT);
            this.groupBox2.Controls.Add(this.CBO_LINE);
            this.groupBox2.Controls.Add(this.CBO_PLT);
            this.groupBox2.Controls.Add(this.CBO_END_CD);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TXT_END_TIME);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TXT_SCRAP_NO);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.sdb_ths_d_mat_var);
            this.groupBox2.Controls.Add(this.cbo_ths_d_mat_var);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.CBO_GROUP);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.CBO_SHIFT);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TXT_OCCR_TIME);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.SDB_SCRAP_WGT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_main_res_cd);
            this.groupBox2.Controls.Add(this.f4ETCR3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CBO_SCRAP_INPUT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_PRC_INPUT_NAME);
            this.groupBox2.Controls.Add(this.f4ETCR2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // TXT_END_CD
            // 
            this.TXT_END_CD.Location = new System.Drawing.Point(1011, 76);
            this.TXT_END_CD.Name = "TXT_END_CD";
            this.TXT_END_CD.Size = new System.Drawing.Size(25, 22);
            this.TXT_END_CD.TabIndex = 440;
            this.TXT_END_CD.Visible = false;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(228, 72);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(25, 22);
            this.txt_UserId.TabIndex = 439;
            this.txt_UserId.Visible = false;
            // 
            // TXT_SCRAP_INPUT
            // 
            this.TXT_SCRAP_INPUT.Location = new System.Drawing.Point(259, 72);
            this.TXT_SCRAP_INPUT.Name = "TXT_SCRAP_INPUT";
            this.TXT_SCRAP_INPUT.Size = new System.Drawing.Size(25, 22);
            this.TXT_SCRAP_INPUT.TabIndex = 415;
            this.TXT_SCRAP_INPUT.Visible = false;
            // 
            // CBO_LINE
            // 
            this.CBO_LINE.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_LINE.FormattingEnabled = true;
            this.CBO_LINE.Items.AddRange(new object[] {
            "1"});
            this.CBO_LINE.Location = new System.Drawing.Point(273, 46);
            this.CBO_LINE.Name = "CBO_LINE";
            this.CBO_LINE.Size = new System.Drawing.Size(60, 22);
            this.CBO_LINE.TabIndex = 438;
            this.CBO_LINE.Text = "1";
            this.CBO_LINE.Visible = false;
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C2"});
            this.CBO_PLT.Location = new System.Drawing.Point(228, 46);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(39, 22);
            this.CBO_PLT.TabIndex = 437;
            this.CBO_PLT.Text = "C2";
            this.CBO_PLT.Visible = false;
            // 
            // CBO_END_CD
            // 
            this.CBO_END_CD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_END_CD.FormattingEnabled = true;
            this.CBO_END_CD.Items.AddRange(new object[] {
            "01 自用",
            "02 回炉"});
            this.CBO_END_CD.Location = new System.Drawing.Point(896, 70);
            this.CBO_END_CD.Name = "CBO_END_CD";
            this.CBO_END_CD.Size = new System.Drawing.Size(106, 22);
            this.CBO_END_CD.TabIndex = 436;
            this.CBO_END_CD.TextChanged += new System.EventHandler(this.CBO_END_CD_TextChanged);
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(803, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 22);
            this.label20.TabIndex = 435;
            this.label20.Text = "去向";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_END_TIME
            // 
            this.TXT_END_TIME.Location = new System.Drawing.Point(641, 70);
            this.TXT_END_TIME.Name = "TXT_END_TIME";
            this.TXT_END_TIME.RawDate = "";
            this.TXT_END_TIME.Size = new System.Drawing.Size(105, 22);
            this.TXT_END_TIME.TabIndex = 434;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(540, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 22);
            this.label19.TabIndex = 433;
            this.label19.Text = "结束时间";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SCRAP_NO
            // 
            this.TXT_SCRAP_NO.Location = new System.Drawing.Point(125, 70);
            this.TXT_SCRAP_NO.Name = "TXT_SCRAP_NO";
            this.TXT_SCRAP_NO.Size = new System.Drawing.Size(95, 22);
            this.TXT_SCRAP_NO.TabIndex = 432;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(27, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 22);
            this.label18.TabIndex = 431;
            this.label18.Text = "废钢号";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_ths_d_mat_var
            // 
            this.sdb_ths_d_mat_var.Location = new System.Drawing.Point(947, 45);
            this.sdb_ths_d_mat_var.Name = "sdb_ths_d_mat_var";
            this.sdb_ths_d_mat_var.Size = new System.Drawing.Size(55, 22);
            this.sdb_ths_d_mat_var.TabIndex = 429;
            // 
            // cbo_ths_d_mat_var
            // 
            this.cbo_ths_d_mat_var.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_ths_d_mat_var.FormattingEnabled = true;
            this.cbo_ths_d_mat_var.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbo_ths_d_mat_var.Location = new System.Drawing.Point(896, 45);
            this.cbo_ths_d_mat_var.Name = "cbo_ths_d_mat_var";
            this.cbo_ths_d_mat_var.Size = new System.Drawing.Size(45, 22);
            this.cbo_ths_d_mat_var.TabIndex = 428;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(803, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 22);
            this.label16.TabIndex = 427;
            this.label16.Text = "增减量";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CBO_GROUP.Location = new System.Drawing.Point(641, 45);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(37, 22);
            this.CBO_GROUP.TabIndex = 426;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(540, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 425;
            this.label15.Text = "班别";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(459, 70);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(61, 22);
            this.CBO_SHIFT.TabIndex = 424;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(360, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 423;
            this.label14.Text = "班次";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_OCCR_TIME
            // 
            this.TXT_OCCR_TIME.Location = new System.Drawing.Point(125, 45);
            this.TXT_OCCR_TIME.Name = "TXT_OCCR_TIME";
            this.TXT_OCCR_TIME.RawDate = "";
            this.TXT_OCCR_TIME.Size = new System.Drawing.Size(95, 22);
            this.TXT_OCCR_TIME.TabIndex = 422;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(27, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 421;
            this.label13.Text = "发生日期";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDB_SCRAP_WGT
            // 
            this.SDB_SCRAP_WGT.Location = new System.Drawing.Point(896, 20);
            this.SDB_SCRAP_WGT.Name = "SDB_SCRAP_WGT";
            this.SDB_SCRAP_WGT.Size = new System.Drawing.Size(106, 22);
            this.SDB_SCRAP_WGT.TabIndex = 419;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(803, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 418;
            this.label12.Text = "废钢重量";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(540, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 415;
            this.label9.Text = "原因";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SCRAP_INPUT
            // 
            this.CBO_SCRAP_INPUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CBO_SCRAP_INPUT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SCRAP_INPUT.FormattingEnabled = true;
            this.CBO_SCRAP_INPUT.Items.AddRange(new object[] {
            "MP:母板",
            "PP:钢板",
            "SL:板坯"});
            this.CBO_SCRAP_INPUT.Location = new System.Drawing.Point(459, 20);
            this.CBO_SCRAP_INPUT.Name = "CBO_SCRAP_INPUT";
            this.CBO_SCRAP_INPUT.Size = new System.Drawing.Size(61, 22);
            this.CBO_SCRAP_INPUT.TabIndex = 414;
            this.CBO_SCRAP_INPUT.TextChanged += new System.EventHandler(this.CBO_SCRAP_INPUT_TextChanged);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(360, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 413;
            this.label6.Text = "种类";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(27, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 384;
            this.label10.Text = "工序";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 192);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 430);
            this.ss1.TabIndex = 3;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WKB1030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WKB1030C";
            this.Text = "废钢实绩查询及修改界面_WKB1030C";
            this.Load += new System.EventHandler(this.WKB1030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_PRC_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_SHIFT_REF;
        private System.Windows.Forms.Label label3;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SDB_TOT_WGT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBO_SCRAP_CD;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.TextBox TXT_PRC_INPUT_NAME;
        private CommonClass.F4ETCR f4ETCR2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox SDB_SCRAP_WGT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_main_res_cd;
        private CommonClass.F4ETCR f4ETCR3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBO_SCRAP_INPUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBO_END_CD;
        private System.Windows.Forms.Label label20;
        private CommonClass.CeriUDate TXT_END_TIME;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXT_SCRAP_NO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sdb_ths_d_mat_var;
        private System.Windows.Forms.ComboBox cbo_ths_d_mat_var;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label14;
        private CommonClass.CeriUDate TXT_OCCR_TIME;
        private System.Windows.Forms.Label label13;
        private CommonClass.F4ETCR f4ETCR1;
        private System.Windows.Forms.TextBox TXT_SCRAP_CD;
        private System.Windows.Forms.TextBox txt_Flag;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.ComboBox CBO_LINE;
        private System.Windows.Forms.TextBox TXT_SCRAP_INPUT;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox TXT_END_CD;
    }
}
