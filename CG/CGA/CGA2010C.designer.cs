namespace CG
{
    partial class CGA2010C
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
            CommonClass.BControlFiledSetting bControlFiledSetting4 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting5 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting6 = new CommonClass.BControlFiledSetting();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CGA2010C));
            this.CBO_CUR_INV = new CommonClass.F4ETCR();
            this.text_cur_inv = new System.Windows.Forms.TextBox();
            this.txt_o_t_addr = new CommonClass.F4ETCR();
            this.txt_o_t_addr_nm = new System.Windows.Forms.TextBox();
            this.txt_o_f_addr = new CommonClass.F4ETCR();
            this.txt_o_f_addr_nm = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ssc_can = new System.Windows.Forms.Button();
            this.ssc_move = new System.Windows.Forms.Button();
            this.txt_p_row = new System.Windows.Forms.TextBox();
            this.txt_slab_cnt = new System.Windows.Forms.TextBox();
            this.opt_Right_Left = new System.Windows.Forms.RadioButton();
            this.opt_Left_Right = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_t_addr = new CommonClass.F4ETCN();
            this.txt_f_addr = new CommonClass.F4ETCN();
            this.cbo_ccm_line = new System.Windows.Forms.ComboBox();
            this.txt_location1 = new System.Windows.Forms.TextBox();
            this.txt_location2 = new System.Windows.Forms.TextBox();
            this.txt_location3 = new System.Windows.Forms.TextBox();
            this.cmd_Loc_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_slab_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBO_CUR_INV
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.CBO_CUR_INV;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.text_cur_inv;
            this.CBO_CUR_INV.CustomSetting.Add(bControlFiledSetting1);
            this.CBO_CUR_INV.CustomSetting.Add(bControlFiledSetting2);
            this.CBO_CUR_INV.InputControl = this.CBO_CUR_INV;
            this.CBO_CUR_INV.Location = new System.Drawing.Point(793, 13);
            this.CBO_CUR_INV.MaxLength = 2;
            this.CBO_CUR_INV.Name = "CBO_CUR_INV";
            this.CBO_CUR_INV.Size = new System.Drawing.Size(25, 22);
            this.CBO_CUR_INV.sJoin = "";
            this.CBO_CUR_INV.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
    "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0013\'    AND C" +
    "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.CBO_CUR_INV.TabIndex = 550;
            this.CBO_CUR_INV.Text = "ZB";
            this.CBO_CUR_INV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBO_CUR_INV.TextChanged += new System.EventHandler(this.CBO_CUR_INV_TextChanged);
            // 
            // text_cur_inv
            // 
            this.text_cur_inv.Enabled = false;
            this.text_cur_inv.Location = new System.Drawing.Point(818, 13);
            this.text_cur_inv.Name = "text_cur_inv";
            this.text_cur_inv.Size = new System.Drawing.Size(98, 22);
            this.text_cur_inv.TabIndex = 551;
            this.text_cur_inv.Text = "中板厂";
            // 
            // txt_o_t_addr
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_o_t_addr;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_o_t_addr_nm;
            this.txt_o_t_addr.CustomSetting.Add(bControlFiledSetting3);
            this.txt_o_t_addr.CustomSetting.Add(bControlFiledSetting4);
            this.txt_o_t_addr.Enabled = false;
            this.txt_o_t_addr.InputControl = this.txt_o_t_addr;
            this.txt_o_t_addr.Location = new System.Drawing.Point(1051, 11);
            this.txt_o_t_addr.MaxLength = 2;
            this.txt_o_t_addr.Name = "txt_o_t_addr";
            this.txt_o_t_addr.Size = new System.Drawing.Size(85, 22);
            this.txt_o_t_addr.sJoin = "";
            this.txt_o_t_addr.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",  CD_SHORT_ENG \"代码英文简称\", CD_" +
    "FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO = \'C0002\' AND CD  like \'%\' " +
    " ORDER  BY  CD  ASC ";
            this.txt_o_t_addr.TabIndex = 555;
            this.txt_o_t_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_o_t_addr_nm
            // 
            this.txt_o_t_addr_nm.Enabled = false;
            this.txt_o_t_addr_nm.Location = new System.Drawing.Point(1136, 11);
            this.txt_o_t_addr_nm.Name = "txt_o_t_addr_nm";
            this.txt_o_t_addr_nm.Size = new System.Drawing.Size(224, 22);
            this.txt_o_t_addr_nm.TabIndex = 556;
            // 
            // txt_o_f_addr
            // 
            bControlFiledSetting5.ColumnID = "CD";
            bControlFiledSetting5.TargetControl = this.txt_o_f_addr;
            bControlFiledSetting6.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting6.TargetControl = this.txt_o_f_addr_nm;
            this.txt_o_f_addr.CustomSetting.Add(bControlFiledSetting5);
            this.txt_o_f_addr.CustomSetting.Add(bControlFiledSetting6);
            this.txt_o_f_addr.Enabled = false;
            this.txt_o_f_addr.InputControl = this.txt_o_f_addr;
            this.txt_o_f_addr.Location = new System.Drawing.Point(81, 11);
            this.txt_o_f_addr.MaxLength = 2;
            this.txt_o_f_addr.Name = "txt_o_f_addr";
            this.txt_o_f_addr.Size = new System.Drawing.Size(85, 22);
            this.txt_o_f_addr.sJoin = "";
            this.txt_o_f_addr.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",  CD_SHORT_ENG \"代码英文简称\", CD_" +
    "FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO = \'C0002\' AND CD  like \'%\' " +
    " ORDER  BY  CD  ASC ";
            this.txt_o_f_addr.TabIndex = 552;
            this.txt_o_f_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_o_f_addr_nm
            // 
            this.txt_o_f_addr_nm.Enabled = false;
            this.txt_o_f_addr_nm.Location = new System.Drawing.Point(166, 11);
            this.txt_o_f_addr_nm.Name = "txt_o_f_addr_nm";
            this.txt_o_f_addr_nm.Size = new System.Drawing.Size(224, 22);
            this.txt_o_f_addr_nm.TabIndex = 553;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1362, 622);
            this.panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.splitter1);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1362, 517);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ss2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(614, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 496);
            this.panel2.TabIndex = 2;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(0, 0);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(745, 496);
            this.ss2.TabIndex = 0;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(611, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 496);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ss1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 496);
            this.panel1.TabIndex = 0;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 0);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(608, 496);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.ssc_can);
            this.groupBox2.Controls.Add(this.ssc_move);
            this.groupBox2.Controls.Add(this.txt_p_row);
            this.groupBox2.Controls.Add(this.txt_slab_cnt);
            this.groupBox2.Controls.Add(this.opt_Right_Left);
            this.groupBox2.Controls.Add(this.opt_Left_Right);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_o_t_addr_nm);
            this.groupBox2.Controls.Add(this.txt_o_t_addr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_o_f_addr_nm);
            this.groupBox2.Controls.Add(this.txt_o_f_addr);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 564;
            // 
            // ssc_can
            // 
            this.ssc_can.Location = new System.Drawing.Point(687, 37);
            this.ssc_can.Name = "ssc_can";
            this.ssc_can.Size = new System.Drawing.Size(53, 23);
            this.ssc_can.TabIndex = 563;
            this.ssc_can.Text = "取消";
            this.ssc_can.UseVisualStyleBackColor = true;
            this.ssc_can.Click += new System.EventHandler(this.ssc_can_Click);
            // 
            // ssc_move
            // 
            this.ssc_move.Location = new System.Drawing.Point(635, 37);
            this.ssc_move.Name = "ssc_move";
            this.ssc_move.Size = new System.Drawing.Size(53, 23);
            this.ssc_move.TabIndex = 562;
            this.ssc_move.Text = "移动";
            this.ssc_move.UseVisualStyleBackColor = true;
            this.ssc_move.Click += new System.EventHandler(this.ssc_move_Click);
            // 
            // txt_p_row
            // 
            this.txt_p_row.Location = new System.Drawing.Point(740, 37);
            this.txt_p_row.Name = "txt_p_row";
            this.txt_p_row.Size = new System.Drawing.Size(34, 22);
            this.txt_p_row.TabIndex = 561;
            // 
            // txt_slab_cnt
            // 
            this.txt_slab_cnt.Location = new System.Drawing.Point(601, 37);
            this.txt_slab_cnt.MaxLength = 2;
            this.txt_slab_cnt.Name = "txt_slab_cnt";
            this.txt_slab_cnt.Size = new System.Drawing.Size(34, 22);
            this.txt_slab_cnt.TabIndex = 560;
            // 
            // opt_Right_Left
            // 
            this.opt_Right_Left.AutoSize = true;
            this.opt_Right_Left.Location = new System.Drawing.Point(1268, 43);
            this.opt_Right_Left.Name = "opt_Right_Left";
            this.opt_Right_Left.Size = new System.Drawing.Size(98, 17);
            this.opt_Right_Left.TabIndex = 559;
            this.opt_Right_Left.TabStop = true;
            this.opt_Right_Left.Text = "左边<-右边 ";
            this.opt_Right_Left.UseVisualStyleBackColor = true;
            this.opt_Right_Left.Click += new System.EventHandler(this.opt_Right_Left_Click);
            // 
            // opt_Left_Right
            // 
            this.opt_Left_Right.AutoSize = true;
            this.opt_Left_Right.Location = new System.Drawing.Point(5, 43);
            this.opt_Left_Right.Name = "opt_Left_Right";
            this.opt_Left_Right.Size = new System.Drawing.Size(91, 17);
            this.opt_Left_Right.TabIndex = 558;
            this.opt_Left_Right.TabStop = true;
            this.opt_Left_Right.Text = "左边->右边";
            this.opt_Left_Right.UseVisualStyleBackColor = true;
            this.opt_Left_Right.Click += new System.EventHandler(this.opt_Left_Right_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(975, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 557;
            this.label5.Text = "目的垛位号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 554;
            this.label4.Text = "起始垛位号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_t_addr);
            this.groupBox1.Controls.Add(this.txt_f_addr);
            this.groupBox1.Controls.Add(this.text_cur_inv);
            this.groupBox1.Controls.Add(this.CBO_CUR_INV);
            this.groupBox1.Controls.Add(this.cbo_ccm_line);
            this.groupBox1.Controls.Add(this.txt_location1);
            this.groupBox1.Controls.Add(this.txt_location2);
            this.groupBox1.Controls.Add(this.txt_location3);
            this.groupBox1.Controls.Add(this.cmd_Loc_Search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_slab_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_t_addr
            // 
            this.txt_t_addr.Location = new System.Drawing.Point(355, 13);
            this.txt_t_addr.Name = "txt_t_addr";
            this.txt_t_addr.sFcontrol = "CD";
            this.txt_t_addr.Size = new System.Drawing.Size(71, 22);
            this.txt_t_addr.sJoin = "";
            this.txt_t_addr.sSqletc = resources.GetString("txt_t_addr.sSqletc");
            this.txt_t_addr.TabIndex = 553;
            this.txt_t_addr.TextChanged += new System.EventHandler(this.txt_t_addr_TextChanged);
            // 
            // txt_f_addr
            // 
            this.txt_f_addr.Location = new System.Drawing.Point(81, 13);
            this.txt_f_addr.Name = "txt_f_addr";
            this.txt_f_addr.sFcontrol = "CD";
            this.txt_f_addr.Size = new System.Drawing.Size(71, 22);
            this.txt_f_addr.sJoin = "";
            this.txt_f_addr.sSqletc = "SELECT CD            \"代码\", CD_SHORT_NAME \"代码简称\",  CD_NAME       \"代码名称\", CD_SHORT_" +
    "ENG  \"代码英文简称\", CD_FULL_ENG   \"代码英文名称\" FROM NISCO.ZP_CD WHERE CD_MANA_NO = \'F0033" +
    "\' AND CD like \'S%\'ORDER BY CD ASC";
            this.txt_f_addr.TabIndex = 552;
            this.txt_f_addr.TextChanged += new System.EventHandler(this.txt_f_addr_TextChanged);
            // 
            // cbo_ccm_line
            // 
            this.cbo_ccm_line.FormattingEnabled = true;
            this.cbo_ccm_line.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_ccm_line.Location = new System.Drawing.Point(152, 13);
            this.cbo_ccm_line.Name = "cbo_ccm_line";
            this.cbo_ccm_line.Size = new System.Drawing.Size(33, 21);
            this.cbo_ccm_line.TabIndex = 549;
            this.cbo_ccm_line.Visible = false;
            // 
            // txt_location1
            // 
            this.txt_location1.Location = new System.Drawing.Point(1051, 13);
            this.txt_location1.Name = "txt_location1";
            this.txt_location1.Size = new System.Drawing.Size(100, 22);
            this.txt_location1.TabIndex = 548;
            this.txt_location1.DoubleClick += new System.EventHandler(this.txt_location1_DoubleClick);
            // 
            // txt_location2
            // 
            this.txt_location2.Location = new System.Drawing.Point(1152, 13);
            this.txt_location2.Name = "txt_location2";
            this.txt_location2.Size = new System.Drawing.Size(100, 22);
            this.txt_location2.TabIndex = 547;
            this.txt_location2.DoubleClick += new System.EventHandler(this.txt_location2_DoubleClick);
            // 
            // txt_location3
            // 
            this.txt_location3.Location = new System.Drawing.Point(1253, 13);
            this.txt_location3.Name = "txt_location3";
            this.txt_location3.Size = new System.Drawing.Size(100, 22);
            this.txt_location3.TabIndex = 546;
            this.txt_location3.DoubleClick += new System.EventHandler(this.txt_location3_DoubleClick);
            // 
            // cmd_Loc_Search
            // 
            this.cmd_Loc_Search.Location = new System.Drawing.Point(975, 13);
            this.cmd_Loc_Search.Name = "cmd_Loc_Search";
            this.cmd_Loc_Search.Size = new System.Drawing.Size(75, 23);
            this.cmd_Loc_Search.TabIndex = 545;
            this.cmd_Loc_Search.Text = "垛位查询";
            this.cmd_Loc_Search.UseVisualStyleBackColor = true;
            this.cmd_Loc_Search.Click += new System.EventHandler(this.cmd_Loc_Search_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(740, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 544;
            this.label3.Text = "当前库";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(522, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 543;
            this.label2.Text = "板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_slab_no
            // 
            this.txt_slab_no.Location = new System.Drawing.Point(575, 13);
            this.txt_slab_no.MaxLength = 10;
            this.txt_slab_no.Name = "txt_slab_no";
            this.txt_slab_no.Size = new System.Drawing.Size(100, 22);
            this.txt_slab_no.TabIndex = 542;
            this.txt_slab_no.TextChanged += new System.EventHandler(this.txt_slab_no_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 541;
            this.label1.Tag = "F4";
            this.label1.Text = "目的垛位号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(6, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 22);
            this.label13.TabIndex = 539;
            this.label13.Tag = "F4";
            this.label13.Text = "起始垛位号";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.DoubleClick += new System.EventHandler(this.label13_DoubleClick);
            // 
            // CGA2010C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 622);
            this.Controls.Add(this.panel4);
            this.Name = "CGA2010C";
            this.Text = "板坯库库存修改及查询界面_CGA2010C";
            this.Load += new System.EventHandler(this.WGA1010C_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ssc_can;
        private System.Windows.Forms.Button ssc_move;
        private System.Windows.Forms.TextBox txt_p_row;
        private System.Windows.Forms.TextBox txt_slab_cnt;
        private System.Windows.Forms.RadioButton opt_Right_Left;
        private System.Windows.Forms.RadioButton opt_Left_Right;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_o_t_addr_nm;
        private CommonClass.F4ETCR txt_o_t_addr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_o_f_addr_nm;
        private CommonClass.F4ETCR txt_o_f_addr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_cur_inv;
        private CommonClass.F4ETCR CBO_CUR_INV;
        private System.Windows.Forms.ComboBox cbo_ccm_line;
        private System.Windows.Forms.TextBox txt_location1;
        private System.Windows.Forms.TextBox txt_location2;
        private System.Windows.Forms.TextBox txt_location3;
        private System.Windows.Forms.Button cmd_Loc_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_slab_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private CommonClass.F4ETCN txt_t_addr;
        public CommonClass.F4ETCN txt_f_addr;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
