﻿namespace CG
{
    partial class CGD2042C
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
            this.txt_SMP_LOC = new CommonClass.F4ETCR();
            this.txt_SMP_LOC_NAME = new System.Windows.Forms.TextBox();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.SDT_PROD_DATE = new CommonClass.CeriUDate();
            this.txt_charge_no = new System.Windows.Forms.TextBox();
            this.opt_Product2 = new System.Windows.Forms.RadioButton();
            this.opt_Product1 = new System.Windows.Forms.RadioButton();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SLAB_NO = new System.Windows.Forms.TextBox();
            this.txt_CHG_STDSPEC = new CommonClass.F4ETCN();
            this.txt_SMP_LEN = new CommonClass.NumBox();
            this.txt_CHG_SMP_NO = new System.Windows.Forms.TextBox();
            this.txt_SMP_NO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmd_Set_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.opt_LineFlag2 = new System.Windows.Forms.RadioButton();
            this.opt_LineFlag3 = new System.Windows.Forms.RadioButton();
            this.opt_LineFlag0 = new System.Windows.Forms.RadioButton();
            this.TXT_PRCLINE = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SMP_LOC
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_SMP_LOC;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_SMP_LOC_NAME;
            this.txt_SMP_LOC.CustomSetting.Add(bControlFiledSetting3);
            this.txt_SMP_LOC.CustomSetting.Add(bControlFiledSetting4);
            this.txt_SMP_LOC.InputControl = this.txt_SMP_LOC;
            this.txt_SMP_LOC.Location = new System.Drawing.Point(882, 11);
            this.txt_SMP_LOC.MaxLength = 1;
            this.txt_SMP_LOC.Name = "txt_SMP_LOC";
            this.txt_SMP_LOC.Size = new System.Drawing.Size(25, 22);
            this.txt_SMP_LOC.sJoin = "";
            this.txt_SMP_LOC.sSqletc = "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称, CD_SHORT_ENG 代码英文简称, CD_FULL_ENG " +
    "代码英文名称 FROM NISCO.ZP_CD  WHERE CD_MANA_NO = \'Q0021\'  ORDER BY CD ASC ";
            this.txt_SMP_LOC.TabIndex = 21;
            this.txt_SMP_LOC.TextChanged += new System.EventHandler(this.txt_SMP_LOC_TextChanged);
            // 
            // txt_SMP_LOC_NAME
            // 
            this.txt_SMP_LOC_NAME.Location = new System.Drawing.Point(909, 11);
            this.txt_SMP_LOC_NAME.Name = "txt_SMP_LOC_NAME";
            this.txt_SMP_LOC_NAME.Size = new System.Drawing.Size(69, 22);
            this.txt_SMP_LOC_NAME.TabIndex = 20;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(263, 17);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(25, 22);
            this.TXT_PROD_CD.TabIndex = 22;
            this.TXT_PROD_CD.Visible = false;
            // 
            // SDT_PROD_DATE
            // 
            this.SDT_PROD_DATE.Location = new System.Drawing.Point(92, 15);
            this.SDT_PROD_DATE.Name = "SDT_PROD_DATE";
            this.SDT_PROD_DATE.RawDate = "";
            this.SDT_PROD_DATE.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE.TabIndex = 11;
            this.SDT_PROD_DATE.Click += new System.EventHandler(this.SDT_PROD_DATE_Click);
            // 
            // txt_charge_no
            // 
            this.txt_charge_no.Location = new System.Drawing.Point(92, 39);
            this.txt_charge_no.Name = "txt_charge_no";
            this.txt_charge_no.Size = new System.Drawing.Size(131, 22);
            this.txt_charge_no.TabIndex = 10;
            // 
            // opt_Product2
            // 
            this.opt_Product2.AutoSize = true;
            this.opt_Product2.Location = new System.Drawing.Point(73, 3);
            this.opt_Product2.Name = "opt_Product2";
            this.opt_Product2.Size = new System.Drawing.Size(64, 17);
            this.opt_Product2.TabIndex = 8;
            this.opt_Product2.TabStop = true;
            this.opt_Product2.Text = "轧批号";
            this.opt_Product2.UseVisualStyleBackColor = true;
            // 
            // opt_Product1
            // 
            this.opt_Product1.AutoSize = true;
            this.opt_Product1.Location = new System.Drawing.Point(3, 3);
            this.opt_Product1.Name = "opt_Product1";
            this.opt_Product1.Size = new System.Drawing.Size(64, 17);
            this.opt_Product1.TabIndex = 7;
            this.opt_Product1.TabStop = true;
            this.opt_Product1.Text = "板坯号";
            this.opt_Product1.UseVisualStyleBackColor = true;
            this.opt_Product1.TextChanged += new System.EventHandler(this.opt_Product1_TextChanged);
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(294, 40);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(42, 21);
            this.CBO_GROUP.TabIndex = 5;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(294, 16);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(42, 21);
            this.CBO_SHIFT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "板坯号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(229, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SLAB_NO
            // 
            this.txt_SLAB_NO.Location = new System.Drawing.Point(469, 15);
            this.txt_SLAB_NO.Name = "txt_SLAB_NO";
            this.txt_SLAB_NO.Size = new System.Drawing.Size(76, 22);
            this.txt_SLAB_NO.TabIndex = 23;
            this.txt_SLAB_NO.Visible = false;
            // 
            // txt_CHG_STDSPEC
            // 
            this.txt_CHG_STDSPEC.Location = new System.Drawing.Point(763, 35);
            this.txt_CHG_STDSPEC.Name = "txt_CHG_STDSPEC";
            this.txt_CHG_STDSPEC.sFcontrol = "StdSPEC";
            this.txt_CHG_STDSPEC.Size = new System.Drawing.Size(215, 22);
            this.txt_CHG_STDSPEC.sJoin = "";
            this.txt_CHG_STDSPEC.sSqletc = "SELECT StdSPEC 标准代号, StdSPEC_YY 发布年度, STDSPEC_CHR_CD 标准特性代码,        Gf_ComnNameFi" +
    "nd(\'Q0025\',STDSPEC_CHR_CD) 标准特性名称, STDSPEC_NAME_ENG 标准英文名, STDSPEC_NAME_CHN 标准中文" +
    "名 FROM  NISCO.QP_STD_HEAD   ";
            this.txt_CHG_STDSPEC.TabIndex = 18;
            this.txt_CHG_STDSPEC.Tag = "改判时适用标准";
            // 
            // txt_SMP_LEN
            // 
            this.txt_SMP_LEN.Location = new System.Drawing.Point(763, 11);
            this.txt_SMP_LEN.MaxLength = 8;
            this.txt_SMP_LEN.Name = "txt_SMP_LEN";
            this.txt_SMP_LEN.NumValue = 0D;
            this.txt_SMP_LEN.Scale = 0;
            this.txt_SMP_LEN.ShowZero = false;
            this.txt_SMP_LEN.Size = new System.Drawing.Size(37, 22);
            this.txt_SMP_LEN.TabIndex = 17;
            this.txt_SMP_LEN.Tag = "试样长度";
            this.txt_SMP_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CHG_SMP_NO
            // 
            this.txt_CHG_SMP_NO.Location = new System.Drawing.Point(572, 35);
            this.txt_CHG_SMP_NO.MaxLength = 14;
            this.txt_CHG_SMP_NO.Name = "txt_CHG_SMP_NO";
            this.txt_CHG_SMP_NO.Size = new System.Drawing.Size(107, 22);
            this.txt_CHG_SMP_NO.TabIndex = 16;
            this.txt_CHG_SMP_NO.Tag = "改判时试样号";
            // 
            // txt_SMP_NO
            // 
            this.txt_SMP_NO.Location = new System.Drawing.Point(572, 11);
            this.txt_SMP_NO.MaxLength = 14;
            this.txt_SMP_NO.Name = "txt_SMP_NO";
            this.txt_SMP_NO.Size = new System.Drawing.Size(107, 22);
            this.txt_SMP_NO.TabIndex = 15;
            this.txt_SMP_NO.TextChanged += new System.EventHandler(this.txt_SMP_NO_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1100, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 14;
            this.label10.Tag = "USER";
            this.label10.Text = "<< 出口板, 船板, 锅炉板, 压力容器板必须输入>>";
            // 
            // Cmd_Set_Save
            // 
            this.Cmd_Set_Save.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_Set_Save.Location = new System.Drawing.Point(1102, 11);
            this.Cmd_Set_Save.Name = "Cmd_Set_Save";
            this.Cmd_Set_Save.Size = new System.Drawing.Size(143, 23);
            this.Cmd_Set_Save.TabIndex = 13;
            this.Cmd_Set_Save.Text = "多行设定";
            this.Cmd_Set_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cmd_Set_Save.UseVisualStyleBackColor = true;
            this.Cmd_Set_Save.Click += new System.EventHandler(this.Cmd_Set_Save_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(685, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "试样长度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(685, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 11;
            this.label7.Tag = "F4";
            this.label7.Text = "改判时标准";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(802, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 10;
            this.label6.Tag = "F4";
            this.label6.Text = "取样位置";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(488, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "改判试样号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(488, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "试样号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(0, 112);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1362, 212);
            this.ss1.TabIndex = 2;
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
            this.ss2.Location = new System.Drawing.Point(0, 327);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1362, 295);
            this.ss2.TabIndex = 3;
            this.ss2.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss2_CellDoubleClick);
            this.ss2.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss2_ButtonClicked);
            this.ss2.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss2_EditChange);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // opt_LineFlag2
            // 
            this.opt_LineFlag2.AutoSize = true;
            this.opt_LineFlag2.Location = new System.Drawing.Point(3, 3);
            this.opt_LineFlag2.Name = "opt_LineFlag2";
            this.opt_LineFlag2.Size = new System.Drawing.Size(39, 17);
            this.opt_LineFlag2.TabIndex = 0;
            this.opt_LineFlag2.TabStop = true;
            this.opt_LineFlag2.Text = "#3";
            this.opt_LineFlag2.UseVisualStyleBackColor = true;
            this.opt_LineFlag2.CheckedChanged += new System.EventHandler(this.opt_LineFlag2_CheckedChanged);
            // 
            // opt_LineFlag3
            // 
            this.opt_LineFlag3.AutoSize = true;
            this.opt_LineFlag3.Location = new System.Drawing.Point(64, 3);
            this.opt_LineFlag3.Name = "opt_LineFlag3";
            this.opt_LineFlag3.Size = new System.Drawing.Size(39, 17);
            this.opt_LineFlag3.TabIndex = 1;
            this.opt_LineFlag3.TabStop = true;
            this.opt_LineFlag3.Text = "#4";
            this.opt_LineFlag3.UseVisualStyleBackColor = true;
            this.opt_LineFlag3.CheckedChanged += new System.EventHandler(this.opt_LineFlag3_CheckedChanged);
            // 
            // opt_LineFlag0
            // 
            this.opt_LineFlag0.AutoSize = true;
            this.opt_LineFlag0.Location = new System.Drawing.Point(122, 3);
            this.opt_LineFlag0.Name = "opt_LineFlag0";
            this.opt_LineFlag0.Size = new System.Drawing.Size(39, 17);
            this.opt_LineFlag0.TabIndex = 2;
            this.opt_LineFlag0.TabStop = true;
            this.opt_LineFlag0.Text = "#5";
            this.opt_LineFlag0.UseVisualStyleBackColor = true;
            // 
            // TXT_PRCLINE
            // 
            this.TXT_PRCLINE.Location = new System.Drawing.Point(200, 14);
            this.TXT_PRCLINE.Name = "TXT_PRCLINE";
            this.TXT_PRCLINE.Size = new System.Drawing.Size(25, 22);
            this.TXT_PRCLINE.TabIndex = 23;
            this.TXT_PRCLINE.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TXT_PROD_CD);
            this.groupBox5.Controls.Add(this.txt_SMP_LOC);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_SMP_LOC_NAME);
            this.groupBox5.Controls.Add(this.SDT_PROD_DATE);
            this.groupBox5.Controls.Add(this.txt_CHG_STDSPEC);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txt_SMP_LEN);
            this.groupBox5.Controls.Add(this.txt_charge_no);
            this.groupBox5.Controls.Add(this.txt_CHG_SMP_NO);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txt_SMP_NO);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.Cmd_Set_Save);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.CBO_SHIFT);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.CBO_GROUP);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1362, 63);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SLAB_NO);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.TXT_PRCLINE);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.opt_Product1);
            this.panel3.Controls.Add(this.opt_Product2);
            this.panel3.Location = new System.Drawing.Point(250, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 31);
            this.panel3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opt_LineFlag2);
            this.panel1.Controls.Add(this.opt_LineFlag0);
            this.panel1.Controls.Add(this.opt_LineFlag3);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 29);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 324);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1362, 3);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // CGD2042C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 622);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "CGD2042C";
            this.Text = "火切钢板取样信息查询及修改界面_CGD2042C";
            this.Load += new System.EventHandler(this.CGD2042C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton opt_Product2;
        private System.Windows.Forms.RadioButton opt_Product1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_charge_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CHG_SMP_NO;
        private System.Windows.Forms.TextBox txt_SMP_NO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Cmd_Set_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCN txt_CHG_STDSPEC;
        private CommonClass.NumBox txt_SMP_LEN;
        private CommonClass.CeriUDate SDT_PROD_DATE;
        private System.Windows.Forms.TextBox txt_SMP_LOC_NAME;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private CommonClass.F4ETCR txt_SMP_LOC;
        private System.Windows.Forms.TextBox TXT_PROD_CD;
        private System.Windows.Forms.TextBox txt_SLAB_NO;
        private System.Windows.Forms.TextBox TXT_PRCLINE;
        private System.Windows.Forms.RadioButton opt_LineFlag0;
        private System.Windows.Forms.RadioButton opt_LineFlag3;
        private System.Windows.Forms.RadioButton opt_LineFlag2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
    }
}
