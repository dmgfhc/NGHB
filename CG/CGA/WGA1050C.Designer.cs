namespace CG
{
    partial class WGA1050C
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
            this.txt_cur_inv_code = new CommonClass.F4ETCR();
            this.txt_cur_inv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_Search5 = new System.Windows.Forms.RadioButton();
            this.opt_Search3 = new System.Windows.Forms.RadioButton();
            this.opt_Search1 = new System.Windows.Forms.RadioButton();
            this.opt_Search4 = new System.Windows.Forms.RadioButton();
            this.opt_Search2 = new System.Windows.Forms.RadioButton();
            this.opt_Search0 = new System.Windows.Forms.RadioButton();
            this.txt_cond = new System.Windows.Forms.TextBox();
            this.txt_slab_no_to = new System.Windows.Forms.TextBox();
            this.txt_slab_no = new System.Windows.Forms.TextBox();
            this.cbo_prc_line = new System.Windows.Forms.ComboBox();
            this.cbo_ccm_line = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DateTo = new CommonClass.CeriUDate();
            this.txt_DateFrom = new CommonClass.CeriUDate();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Order = new System.Windows.Forms.TextBox();
            this.txt_Disp = new System.Windows.Forms.TextBox();
            this.txt_Disp_Order = new System.Windows.Forms.TextBox();
            this.chk_Cond14 = new System.Windows.Forms.CheckBox();
            this.chk_Cond6 = new System.Windows.Forms.CheckBox();
            this.chk_Cond13 = new System.Windows.Forms.CheckBox();
            this.chk_Cond10 = new System.Windows.Forms.CheckBox();
            this.chk_Cond11 = new System.Windows.Forms.CheckBox();
            this.chk_Cond12 = new System.Windows.Forms.CheckBox();
            this.chk_Cond5 = new System.Windows.Forms.CheckBox();
            this.chk_Cond7 = new System.Windows.Forms.CheckBox();
            this.chk_Cond8 = new System.Windows.Forms.CheckBox();
            this.chk_Cond9 = new System.Windows.Forms.CheckBox();
            this.chk_Cond1 = new System.Windows.Forms.CheckBox();
            this.chk_Cond2 = new System.Windows.Forms.CheckBox();
            this.chk_Cond3 = new System.Windows.Forms.CheckBox();
            this.chk_Cond4 = new System.Windows.Forms.CheckBox();
            this.chk_Cond0 = new System.Windows.Forms.CheckBox();
            this.SSTab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SSTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cur_inv_code
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_cur_inv_code;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_cur_inv;
            this.txt_cur_inv_code.CustomSetting.Add(bControlFiledSetting3);
            this.txt_cur_inv_code.CustomSetting.Add(bControlFiledSetting4);
            this.txt_cur_inv_code.InputControl = this.txt_cur_inv_code;
            this.txt_cur_inv_code.Location = new System.Drawing.Point(456, 35);
            this.txt_cur_inv_code.MaxLength = 2;
            this.txt_cur_inv_code.Name = "txt_cur_inv_code";
            this.txt_cur_inv_code.Size = new System.Drawing.Size(38, 22);
            this.txt_cur_inv_code.sJoin = "";
            this.txt_cur_inv_code.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
                "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0013\'    AND C" +
                "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_cur_inv_code.TabIndex = 551;
            this.txt_cur_inv_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cur_inv
            // 
            this.txt_cur_inv.Enabled = false;
            this.txt_cur_inv.Location = new System.Drawing.Point(494, 35);
            this.txt_cur_inv.Name = "txt_cur_inv";
            this.txt_cur_inv.Size = new System.Drawing.Size(163, 22);
            this.txt_cur_inv.TabIndex = 552;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_Search5);
            this.groupBox1.Controls.Add(this.opt_Search3);
            this.groupBox1.Controls.Add(this.opt_Search1);
            this.groupBox1.Controls.Add(this.opt_Search4);
            this.groupBox1.Controls.Add(this.opt_Search2);
            this.groupBox1.Controls.Add(this.opt_Search0);
            this.groupBox1.Controls.Add(this.txt_cond);
            this.groupBox1.Controls.Add(this.txt_cur_inv);
            this.groupBox1.Controls.Add(this.txt_cur_inv_code);
            this.groupBox1.Controls.Add(this.txt_slab_no_to);
            this.groupBox1.Controls.Add(this.txt_slab_no);
            this.groupBox1.Controls.Add(this.cbo_prc_line);
            this.groupBox1.Controls.Add(this.cbo_ccm_line);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_DateTo);
            this.groupBox1.Controls.Add(this.txt_DateFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // opt_Search5
            // 
            this.opt_Search5.AutoSize = true;
            this.opt_Search5.Location = new System.Drawing.Point(923, 34);
            this.opt_Search5.Name = "opt_Search5";
            this.opt_Search5.Size = new System.Drawing.Size(71, 16);
            this.opt_Search5.TabIndex = 559;
            this.opt_Search5.TabStop = true;
            this.opt_Search5.Text = "当前库存";
            this.opt_Search5.UseVisualStyleBackColor = true;
            this.opt_Search5.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // opt_Search3
            // 
            this.opt_Search3.AutoSize = true;
            this.opt_Search3.Location = new System.Drawing.Point(712, 35);
            this.opt_Search3.Name = "opt_Search3";
            this.opt_Search3.Size = new System.Drawing.Size(83, 16);
            this.opt_Search3.TabIndex = 558;
            this.opt_Search3.TabStop = true;
            this.opt_Search3.Text = "转炉出钢日";
            this.opt_Search3.UseVisualStyleBackColor = true;
            this.opt_Search3.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // opt_Search1
            // 
            this.opt_Search1.AutoSize = true;
            this.opt_Search1.Location = new System.Drawing.Point(829, 12);
            this.opt_Search1.Name = "opt_Search1";
            this.opt_Search1.Size = new System.Drawing.Size(59, 16);
            this.opt_Search1.TabIndex = 557;
            this.opt_Search1.TabStop = true;
            this.opt_Search1.Text = "轧制日";
            this.opt_Search1.UseVisualStyleBackColor = true;
            this.opt_Search1.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // opt_Search4
            // 
            this.opt_Search4.AutoSize = true;
            this.opt_Search4.Location = new System.Drawing.Point(829, 35);
            this.opt_Search4.Name = "opt_Search4";
            this.opt_Search4.Size = new System.Drawing.Size(59, 16);
            this.opt_Search4.TabIndex = 556;
            this.opt_Search4.TabStop = true;
            this.opt_Search4.Text = "发货日";
            this.opt_Search4.UseVisualStyleBackColor = true;
            this.opt_Search4.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // opt_Search2
            // 
            this.opt_Search2.AutoSize = true;
            this.opt_Search2.Location = new System.Drawing.Point(923, 11);
            this.opt_Search2.Name = "opt_Search2";
            this.opt_Search2.Size = new System.Drawing.Size(59, 16);
            this.opt_Search2.TabIndex = 555;
            this.opt_Search2.TabStop = true;
            this.opt_Search2.Text = "转库日";
            this.opt_Search2.UseVisualStyleBackColor = true;
            this.opt_Search2.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // opt_Search0
            // 
            this.opt_Search0.AutoSize = true;
            this.opt_Search0.Location = new System.Drawing.Point(712, 13);
            this.opt_Search0.Name = "opt_Search0";
            this.opt_Search0.Size = new System.Drawing.Size(83, 16);
            this.opt_Search0.TabIndex = 554;
            this.opt_Search0.TabStop = true;
            this.opt_Search0.Text = "连铸开浇日";
            this.opt_Search0.UseVisualStyleBackColor = true;
            this.opt_Search0.Click += new System.EventHandler(this.opt_Search0_Click);
            // 
            // txt_cond
            // 
            this.txt_cond.Location = new System.Drawing.Point(663, 11);
            this.txt_cond.Name = "txt_cond";
            this.txt_cond.Size = new System.Drawing.Size(16, 22);
            this.txt_cond.TabIndex = 553;
            this.txt_cond.Visible = false;
            // 
            // txt_slab_no_to
            // 
            this.txt_slab_no_to.Location = new System.Drawing.Point(557, 11);
            this.txt_slab_no_to.Name = "txt_slab_no_to";
            this.txt_slab_no_to.Size = new System.Drawing.Size(100, 22);
            this.txt_slab_no_to.TabIndex = 550;
            // 
            // txt_slab_no
            // 
            this.txt_slab_no.Location = new System.Drawing.Point(456, 11);
            this.txt_slab_no.Name = "txt_slab_no";
            this.txt_slab_no.Size = new System.Drawing.Size(100, 22);
            this.txt_slab_no.TabIndex = 549;
            // 
            // cbo_prc_line
            // 
            this.cbo_prc_line.FormattingEnabled = true;
            this.cbo_prc_line.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_prc_line.Location = new System.Drawing.Point(109, 35);
            this.cbo_prc_line.Name = "cbo_prc_line";
            this.cbo_prc_line.Size = new System.Drawing.Size(40, 21);
            this.cbo_prc_line.TabIndex = 548;
            // 
            // cbo_ccm_line
            // 
            this.cbo_ccm_line.FormattingEnabled = true;
            this.cbo_ccm_line.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_ccm_line.Location = new System.Drawing.Point(255, 35);
            this.cbo_ccm_line.Name = "cbo_ccm_line";
            this.cbo_ccm_line.Size = new System.Drawing.Size(40, 21);
            this.cbo_ccm_line.TabIndex = 547;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(157, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 546;
            this.label4.Tag = "";
            this.label4.Text = "连铸机号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.Location = new System.Drawing.Point(202, 12);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.RawDate = "";
            this.txt_DateTo.Size = new System.Drawing.Size(93, 21);
            this.txt_DateTo.TabIndex = 545;
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.Location = new System.Drawing.Point(109, 12);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.RawDate = "";
            this.txt_DateFrom.Size = new System.Drawing.Size(93, 21);
            this.txt_DateFrom.TabIndex = 544;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(358, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 543;
            this.label3.Tag = "";
            this.label3.Text = "板坯号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(358, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 542;
            this.label2.Tag = "F4";
            this.label2.Text = "堆放仓库";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 541;
            this.label1.Tag = "";
            this.label1.Text = "炉座号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(11, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 22);
            this.label13.TabIndex = 540;
            this.label13.Tag = "";
            this.label13.Text = "入库日(生产)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Order);
            this.groupBox2.Controls.Add(this.txt_Disp);
            this.groupBox2.Controls.Add(this.txt_Disp_Order);
            this.groupBox2.Controls.Add(this.chk_Cond14);
            this.groupBox2.Controls.Add(this.chk_Cond6);
            this.groupBox2.Controls.Add(this.chk_Cond13);
            this.groupBox2.Controls.Add(this.chk_Cond10);
            this.groupBox2.Controls.Add(this.chk_Cond11);
            this.groupBox2.Controls.Add(this.chk_Cond12);
            this.groupBox2.Controls.Add(this.chk_Cond5);
            this.groupBox2.Controls.Add(this.chk_Cond7);
            this.groupBox2.Controls.Add(this.chk_Cond8);
            this.groupBox2.Controls.Add(this.chk_Cond9);
            this.groupBox2.Controls.Add(this.chk_Cond1);
            this.groupBox2.Controls.Add(this.chk_Cond2);
            this.groupBox2.Controls.Add(this.chk_Cond3);
            this.groupBox2.Controls.Add(this.chk_Cond4);
            this.groupBox2.Controls.Add(this.chk_Cond0);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1320, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(1078, 13);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Size = new System.Drawing.Size(33, 22);
            this.txt_Order.TabIndex = 555;
            this.txt_Order.Visible = false;
            // 
            // txt_Disp
            // 
            this.txt_Disp.Location = new System.Drawing.Point(676, 36);
            this.txt_Disp.Name = "txt_Disp";
            this.txt_Disp.Size = new System.Drawing.Size(82, 22);
            this.txt_Disp.TabIndex = 554;
            this.txt_Disp.Visible = false;
            // 
            // txt_Disp_Order
            // 
            this.txt_Disp_Order.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Disp_Order.ForeColor = System.Drawing.Color.Red;
            this.txt_Disp_Order.Location = new System.Drawing.Point(763, 13);
            this.txt_Disp_Order.Multiline = true;
            this.txt_Disp_Order.Name = "txt_Disp_Order";
            this.txt_Disp_Order.Size = new System.Drawing.Size(309, 44);
            this.txt_Disp_Order.TabIndex = 15;
            this.txt_Disp_Order.Tag = "user";
            // 
            // chk_Cond14
            // 
            this.chk_Cond14.AutoSize = true;
            this.chk_Cond14.Location = new System.Drawing.Point(674, 15);
            this.chk_Cond14.Name = "chk_Cond14";
            this.chk_Cond14.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond14.TabIndex = 14;
            this.chk_Cond14.Tag = ",A.PRC_LINE";
            this.chk_Cond14.Text = "连铸机号";
            this.chk_Cond14.UseVisualStyleBackColor = true;
            this.chk_Cond14.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond6
            // 
            this.chk_Cond6.AutoSize = true;
            this.chk_Cond6.Location = new System.Drawing.Point(571, 15);
            this.chk_Cond6.Name = "chk_Cond6";
            this.chk_Cond6.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond6.TabIndex = 13;
            this.chk_Cond6.Tag = ",A.CUR_INV";
            this.chk_Cond6.Text = "堆放仓库";
            this.chk_Cond6.UseVisualStyleBackColor = true;
            this.chk_Cond6.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond13
            // 
            this.chk_Cond13.AutoSize = true;
            this.chk_Cond13.Location = new System.Drawing.Point(571, 38);
            this.chk_Cond13.Name = "chk_Cond13";
            this.chk_Cond13.Size = new System.Drawing.Size(60, 16);
            this.chk_Cond13.TabIndex = 12;
            this.chk_Cond13.Tag = ",A.SHP_DATE";
            this.chk_Cond13.Text = "发货日";
            this.chk_Cond13.UseVisualStyleBackColor = true;
            this.chk_Cond13.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond10
            // 
            this.chk_Cond10.AutoSize = true;
            this.chk_Cond10.Location = new System.Drawing.Point(285, 38);
            this.chk_Cond10.Name = "chk_Cond10";
            this.chk_Cond10.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond10.TabIndex = 11;
            this.chk_Cond10.Tag = ",GROUP_CD";
            this.chk_Cond10.Text = "班别";
            this.chk_Cond10.UseVisualStyleBackColor = true;
            this.chk_Cond10.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond11
            // 
            this.chk_Cond11.AutoSize = true;
            this.chk_Cond11.Location = new System.Drawing.Point(361, 38);
            this.chk_Cond11.Name = "chk_Cond11";
            this.chk_Cond11.Size = new System.Drawing.Size(60, 16);
            this.chk_Cond11.TabIndex = 10;
            this.chk_Cond11.Tag = ",Gf_AFL2100C_DATE(A.SLAB_NO,\'MOVE\')";
            this.chk_Cond11.Text = "转库日";
            this.chk_Cond11.UseVisualStyleBackColor = true;
            this.chk_Cond11.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond12
            // 
            this.chk_Cond12.AutoSize = true;
            this.chk_Cond12.Location = new System.Drawing.Point(451, 38);
            this.chk_Cond12.Name = "chk_Cond12";
            this.chk_Cond12.Size = new System.Drawing.Size(84, 16);
            this.chk_Cond12.TabIndex = 9;
            this.chk_Cond12.Tag = ",Gf_AFL2100C_DATE(A.SLAB_NO,\'BOF\')";
            this.chk_Cond12.Text = "转炉出钢日";
            this.chk_Cond12.UseVisualStyleBackColor = true;
            this.chk_Cond12.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond5
            // 
            this.chk_Cond5.AutoSize = true;
            this.chk_Cond5.Location = new System.Drawing.Point(451, 15);
            this.chk_Cond5.Name = "chk_Cond5";
            this.chk_Cond5.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond5.TabIndex = 8;
            this.chk_Cond5.Tag = ",A.PROD_DATE";
            this.chk_Cond5.Text = "切割日期";
            this.chk_Cond5.UseVisualStyleBackColor = true;
            this.chk_Cond5.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond7
            // 
            this.chk_Cond7.AutoSize = true;
            this.chk_Cond7.Location = new System.Drawing.Point(32, 38);
            this.chk_Cond7.Name = "chk_Cond7";
            this.chk_Cond7.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond7.TabIndex = 7;
            this.chk_Cond7.Tag = ",A.OUT_PLT";
            this.chk_Cond7.Text = "去向";
            this.chk_Cond7.UseVisualStyleBackColor = true;
            this.chk_Cond7.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond8
            // 
            this.chk_Cond8.AutoSize = true;
            this.chk_Cond8.Location = new System.Drawing.Point(109, 38);
            this.chk_Cond8.Name = "chk_Cond8";
            this.chk_Cond8.Size = new System.Drawing.Size(72, 16);
            this.chk_Cond8.TabIndex = 6;
            this.chk_Cond8.Tag = ",A.OUT_PLT_DATE";
            this.chk_Cond8.Text = "轧制日期";
            this.chk_Cond8.UseVisualStyleBackColor = true;
            this.chk_Cond8.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond9
            // 
            this.chk_Cond9.AutoSize = true;
            this.chk_Cond9.Location = new System.Drawing.Point(210, 38);
            this.chk_Cond9.Name = "chk_Cond9";
            this.chk_Cond9.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond9.TabIndex = 5;
            this.chk_Cond9.Tag = ",SHIFT";
            this.chk_Cond9.Text = "班次";
            this.chk_Cond9.UseVisualStyleBackColor = true;
            this.chk_Cond9.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond1
            // 
            this.chk_Cond1.AutoSize = true;
            this.chk_Cond1.Location = new System.Drawing.Point(109, 15);
            this.chk_Cond1.Name = "chk_Cond1";
            this.chk_Cond1.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond1.TabIndex = 4;
            this.chk_Cond1.Tag = ",Gf_Stlgrd_Detail(A.STLGRD)";
            this.chk_Cond1.Text = "钢种";
            this.chk_Cond1.UseVisualStyleBackColor = true;
            this.chk_Cond1.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond2
            // 
            this.chk_Cond2.AutoSize = true;
            this.chk_Cond2.Location = new System.Drawing.Point(210, 15);
            this.chk_Cond2.Name = "chk_Cond2";
            this.chk_Cond2.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond2.TabIndex = 3;
            this.chk_Cond2.Tag = ",A.THK";
            this.chk_Cond2.Text = "厚度";
            this.chk_Cond2.UseVisualStyleBackColor = true;
            this.chk_Cond2.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond3
            // 
            this.chk_Cond3.AutoSize = true;
            this.chk_Cond3.Location = new System.Drawing.Point(285, 15);
            this.chk_Cond3.Name = "chk_Cond3";
            this.chk_Cond3.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond3.TabIndex = 2;
            this.chk_Cond3.Tag = ",A.WID";
            this.chk_Cond3.Text = "宽度";
            this.chk_Cond3.UseVisualStyleBackColor = true;
            this.chk_Cond3.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond4
            // 
            this.chk_Cond4.AutoSize = true;
            this.chk_Cond4.Location = new System.Drawing.Point(361, 15);
            this.chk_Cond4.Name = "chk_Cond4";
            this.chk_Cond4.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond4.TabIndex = 1;
            this.chk_Cond4.Tag = ",A.LEN";
            this.chk_Cond4.Text = "长度";
            this.chk_Cond4.UseVisualStyleBackColor = true;
            this.chk_Cond4.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // chk_Cond0
            // 
            this.chk_Cond0.AutoSize = true;
            this.chk_Cond0.Location = new System.Drawing.Point(32, 15);
            this.chk_Cond0.Name = "chk_Cond0";
            this.chk_Cond0.Size = new System.Drawing.Size(48, 16);
            this.chk_Cond0.TabIndex = 0;
            this.chk_Cond0.Tag = ",SUBSTR(A.SLAB_NO,1,8)";
            this.chk_Cond0.Text = "炉号";
            this.chk_Cond0.UseVisualStyleBackColor = true;
            this.chk_Cond0.Click += new System.EventHandler(this.chk_Cond0_Click);
            // 
            // SSTab1
            // 
            this.SSTab1.Controls.Add(this.tabPage1);
            this.SSTab1.Controls.Add(this.tabPage2);
            this.SSTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSTab1.Location = new System.Drawing.Point(0, 125);
            this.SSTab1.Name = "SSTab1";
            this.SSTab1.SelectedIndex = 0;
            this.SSTab1.Size = new System.Drawing.Size(1320, 497);
            this.SSTab1.TabIndex = 2;
            this.SSTab1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1312, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "汇总信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1306, 465);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1312, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "详细信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 3);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1306, 465);
            this.ss2.TabIndex = 0;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // WGA1050C
            // 
            this.ClientSize = new System.Drawing.Size(1320, 622);
            this.Controls.Add(this.SSTab1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGA1050C";
            this.Text = "板坯统计情况综合查询界面_WGA1050C";
            this.Load += new System.EventHandler(this.WGA1070C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SSTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_prc_line;
        private System.Windows.Forms.ComboBox cbo_ccm_line;
        private System.Windows.Forms.Label label4;
        private CommonClass.CeriUDate txt_DateTo;
        private CommonClass.CeriUDate txt_DateFrom;
        private System.Windows.Forms.TextBox txt_slab_no_to;
        private System.Windows.Forms.TextBox txt_slab_no;
        private System.Windows.Forms.TextBox txt_cur_inv;
        private CommonClass.F4ETCR txt_cur_inv_code;
        private System.Windows.Forms.TextBox txt_cond;
        private System.Windows.Forms.RadioButton opt_Search5;
        private System.Windows.Forms.RadioButton opt_Search3;
        private System.Windows.Forms.RadioButton opt_Search1;
        private System.Windows.Forms.RadioButton opt_Search4;
        private System.Windows.Forms.RadioButton opt_Search2;
        private System.Windows.Forms.RadioButton opt_Search0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Cond14;
        private System.Windows.Forms.CheckBox chk_Cond6;
        private System.Windows.Forms.CheckBox chk_Cond13;
        private System.Windows.Forms.CheckBox chk_Cond10;
        private System.Windows.Forms.CheckBox chk_Cond11;
        private System.Windows.Forms.CheckBox chk_Cond12;
        private System.Windows.Forms.CheckBox chk_Cond5;
        private System.Windows.Forms.CheckBox chk_Cond7;
        private System.Windows.Forms.CheckBox chk_Cond8;
        private System.Windows.Forms.CheckBox chk_Cond9;
        private System.Windows.Forms.CheckBox chk_Cond1;
        private System.Windows.Forms.CheckBox chk_Cond2;
        private System.Windows.Forms.CheckBox chk_Cond3;
        private System.Windows.Forms.CheckBox chk_Cond4;
        private System.Windows.Forms.CheckBox chk_Cond0;
        private System.Windows.Forms.TextBox txt_Disp_Order;
        private System.Windows.Forms.TextBox txt_Order;
        private System.Windows.Forms.TextBox txt_Disp;
        private System.Windows.Forms.TabControl SSTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
    }
}
