namespace CG
{
    partial class CGT2020C
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
            this.txt_stlgrd = new CommonClass.F4ETCR();
            this.txt_STLGRD_Name = new System.Windows.Forms.TextBox();
            this.txt_stdspec = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSPpdt = new System.Windows.Forms.Button();
            this.SSP1 = new System.Windows.Forms.Button();
            this.SSPanel1 = new System.Windows.Forms.Button();
            this.CMD_CARD = new System.Windows.Forms.Button();
            this.SSP4 = new System.Windows.Forms.Button();
            this.SSPanel2 = new System.Windows.Forms.Button();
            this.SDB_LEN_PLAN_TO = new CommonClass.NumBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SDB_LEN_PLAN = new CommonClass.NumBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SDB_WID_PLAN_TO = new CommonClass.NumBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SDB_WID_PLAN = new CommonClass.NumBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SDB_THK_PLAN_TO = new CommonClass.NumBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SDB_THK_PLAN = new CommonClass.NumBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TXT_TRNS_CMPY_CD_TO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_TRNS_CMPY_CD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SDB_LEN_TO = new CommonClass.NumBox();
            this.SDB_WID_TO = new CommonClass.NumBox();
            this.SDB_THK_TO = new CommonClass.NumBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SDB_LEN = new CommonClass.NumBox();
            this.SDB_WID = new CommonClass.NumBox();
            this.SDB_THK = new CommonClass.NumBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_scrap = new System.Windows.Forms.ComboBox();
            this.cbo_plate_yn = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_gas_fl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_MILL_LOT_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stlgrd
            // 
            bControlFiledSetting1.ColumnID = "STLGRD";
            bControlFiledSetting1.TargetControl = this.txt_stlgrd;
            bControlFiledSetting2.ColumnID = "STEEL_GRD_DETAIL";
            bControlFiledSetting2.TargetControl = this.txt_STLGRD_Name;
            this.txt_stlgrd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_stlgrd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_stlgrd.InputControl = this.txt_stlgrd;
            this.txt_stlgrd.Location = new System.Drawing.Point(136, 145);
            this.txt_stlgrd.MaxLength = 12;
            this.txt_stlgrd.Name = "txt_stlgrd";
            this.txt_stlgrd.Size = new System.Drawing.Size(112, 22);
            this.txt_stlgrd.sJoin = "";
            this.txt_stlgrd.sSqletc = "SELECT STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM  NISCO.QP_NISCO_CHMC  WHERE STLG" +
    "RD like \'%\'  AND NVL(STEEL_GRD_DETAIL,\'%\')   like \'%\'  ORDER  BY  STLGRD  ASC";
            this.txt_stlgrd.TabIndex = 141;
            // 
            // txt_STLGRD_Name
            // 
            this.txt_STLGRD_Name.Location = new System.Drawing.Point(253, 145);
            this.txt_STLGRD_Name.MaxLength = 50;
            this.txt_STLGRD_Name.Name = "txt_STLGRD_Name";
            this.txt_STLGRD_Name.Size = new System.Drawing.Size(112, 22);
            this.txt_STLGRD_Name.TabIndex = 195;
            // 
            // txt_stdspec
            // 
            bControlFiledSetting3.ColumnID = "StdSPEC";
            bControlFiledSetting3.TargetControl = this.txt_stdspec;
            this.txt_stdspec.CustomSetting.Add(bControlFiledSetting3);
            this.txt_stdspec.InputControl = this.txt_stdspec;
            this.txt_stdspec.Location = new System.Drawing.Point(136, 114);
            this.txt_stdspec.MaxLength = 18;
            this.txt_stdspec.Name = "txt_stdspec";
            this.txt_stdspec.Size = new System.Drawing.Size(112, 22);
            this.txt_stdspec.sJoin = "";
            this.txt_stdspec.sSqletc = "SELECT StdSPEC \"标准代号\", StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind" +
    "(\'Q0025\',STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\", STDSPEC_NAME_CHN \"标准" +
    "中文名\" FROM  NISCO.QP_STD_HEAD";
            this.txt_stdspec.TabIndex = 153;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_STLGRD_Name);
            this.groupBox1.Controls.Add(this.SSPpdt);
            this.groupBox1.Controls.Add(this.SSP1);
            this.groupBox1.Controls.Add(this.SSPanel1);
            this.groupBox1.Controls.Add(this.CMD_CARD);
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.SSPanel2);
            this.groupBox1.Controls.Add(this.SDB_LEN_PLAN_TO);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.SDB_LEN_PLAN);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.SDB_WID_PLAN_TO);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.SDB_WID_PLAN);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.SDB_THK_PLAN_TO);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.SDB_THK_PLAN);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.TXT_TRNS_CMPY_CD_TO);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TXT_TRNS_CMPY_CD);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.SDB_LEN_TO);
            this.groupBox1.Controls.Add(this.SDB_WID_TO);
            this.groupBox1.Controls.Add(this.SDB_THK_TO);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.SDB_LEN);
            this.groupBox1.Controls.Add(this.SDB_WID);
            this.groupBox1.Controls.Add(this.SDB_THK);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbo_scrap);
            this.groupBox1.Controls.Add(this.cbo_plate_yn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbo_gas_fl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.txt_stdspec);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_MILL_LOT_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_stlgrd);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SSPpdt
            // 
            this.SSPpdt.BackColor = System.Drawing.Color.White;
            this.SSPpdt.FlatAppearance.BorderSize = 0;
            this.SSPpdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSPpdt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPpdt.ForeColor = System.Drawing.Color.Red;
            this.SSPpdt.Location = new System.Drawing.Point(781, 145);
            this.SSPpdt.Name = "SSPpdt";
            this.SSPpdt.Size = new System.Drawing.Size(118, 22);
            this.SSPpdt.TabIndex = 194;
            this.SSPpdt.Text = "当月以前交货订单";
            this.SSPpdt.UseVisualStyleBackColor = false;
            // 
            // SSP1
            // 
            this.SSP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SSP1.FlatAppearance.BorderSize = 0;
            this.SSP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP1.Location = new System.Drawing.Point(680, 145);
            this.SSP1.Name = "SSP1";
            this.SSP1.Size = new System.Drawing.Size(82, 22);
            this.SSP1.TabIndex = 193;
            this.SSP1.Text = "一坯多订单";
            this.SSP1.UseVisualStyleBackColor = false;
            // 
            // SSPanel1
            // 
            this.SSPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SSPanel1.FlatAppearance.BorderSize = 0;
            this.SSPanel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSPanel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPanel1.Location = new System.Drawing.Point(577, 145);
            this.SSPanel1.Name = "SSPanel1";
            this.SSPanel1.Size = new System.Drawing.Size(82, 22);
            this.SSPanel1.TabIndex = 192;
            this.SSPanel1.Text = "热处理指示";
            this.SSPanel1.UseVisualStyleBackColor = false;
            // 
            // CMD_CARD
            // 
            this.CMD_CARD.ForeColor = System.Drawing.Color.Red;
            this.CMD_CARD.Location = new System.Drawing.Point(470, 145);
            this.CMD_CARD.Name = "CMD_CARD";
            this.CMD_CARD.Size = new System.Drawing.Size(91, 23);
            this.CMD_CARD.TabIndex = 191;
            this.CMD_CARD.Text = "取样单导出";
            this.CMD_CARD.UseVisualStyleBackColor = true;
            this.CMD_CARD.Click += new System.EventHandler(this.CMD_CARD_Click);
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SSP4.FlatAppearance.BorderSize = 0;
            this.SSP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP4.Location = new System.Drawing.Point(379, 145);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(71, 22);
            this.SSP4.TabIndex = 190;
            this.SSP4.Text = "重点订单";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // SSPanel2
            // 
            this.SSPanel2.BackColor = System.Drawing.Color.Yellow;
            this.SSPanel2.FlatAppearance.BorderSize = 0;
            this.SSPanel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSPanel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPanel2.Location = new System.Drawing.Point(849, 114);
            this.SSPanel2.Name = "SSPanel2";
            this.SSPanel2.Size = new System.Drawing.Size(71, 22);
            this.SSPanel2.TabIndex = 189;
            this.SSPanel2.Text = "堆冷标识";
            this.SSPanel2.UseVisualStyleBackColor = false;
            // 
            // SDB_LEN_PLAN_TO
            // 
            this.SDB_LEN_PLAN_TO.Location = new System.Drawing.Point(1025, 82);
            this.SDB_LEN_PLAN_TO.Name = "SDB_LEN_PLAN_TO";
            this.SDB_LEN_PLAN_TO.NumValue = 0D;
            this.SDB_LEN_PLAN_TO.Scale = 1;
            this.SDB_LEN_PLAN_TO.ShowZero = true;
            this.SDB_LEN_PLAN_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_LEN_PLAN_TO.TabIndex = 188;
            this.SDB_LEN_PLAN_TO.Text = "0.0";
            this.SDB_LEN_PLAN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1005, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 187;
            this.label22.Tag = "user";
            this.label22.Text = "~";
            // 
            // SDB_LEN_PLAN
            // 
            this.SDB_LEN_PLAN.Location = new System.Drawing.Point(926, 82);
            this.SDB_LEN_PLAN.Name = "SDB_LEN_PLAN";
            this.SDB_LEN_PLAN.NumValue = 0D;
            this.SDB_LEN_PLAN.Scale = 1;
            this.SDB_LEN_PLAN.ShowZero = true;
            this.SDB_LEN_PLAN.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN_PLAN.TabIndex = 186;
            this.SDB_LEN_PLAN.Text = "0.0";
            this.SDB_LEN_PLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(849, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 22);
            this.label23.TabIndex = 185;
            this.label23.Text = "订单长度";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDB_WID_PLAN_TO
            // 
            this.SDB_WID_PLAN_TO.Location = new System.Drawing.Point(1025, 51);
            this.SDB_WID_PLAN_TO.Name = "SDB_WID_PLAN_TO";
            this.SDB_WID_PLAN_TO.NumValue = 0D;
            this.SDB_WID_PLAN_TO.Scale = 2;
            this.SDB_WID_PLAN_TO.ShowZero = true;
            this.SDB_WID_PLAN_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_WID_PLAN_TO.TabIndex = 184;
            this.SDB_WID_PLAN_TO.Text = "0.00";
            this.SDB_WID_PLAN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1005, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 183;
            this.label20.Tag = "user";
            this.label20.Text = "~";
            // 
            // SDB_WID_PLAN
            // 
            this.SDB_WID_PLAN.Location = new System.Drawing.Point(926, 51);
            this.SDB_WID_PLAN.Name = "SDB_WID_PLAN";
            this.SDB_WID_PLAN.NumValue = 0D;
            this.SDB_WID_PLAN.Scale = 2;
            this.SDB_WID_PLAN.ShowZero = true;
            this.SDB_WID_PLAN.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID_PLAN.TabIndex = 182;
            this.SDB_WID_PLAN.Text = "0.00";
            this.SDB_WID_PLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(849, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 22);
            this.label21.TabIndex = 181;
            this.label21.Text = "订单宽度";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDB_THK_PLAN_TO
            // 
            this.SDB_THK_PLAN_TO.Location = new System.Drawing.Point(1025, 18);
            this.SDB_THK_PLAN_TO.Name = "SDB_THK_PLAN_TO";
            this.SDB_THK_PLAN_TO.NumValue = 0D;
            this.SDB_THK_PLAN_TO.Scale = 2;
            this.SDB_THK_PLAN_TO.ShowZero = true;
            this.SDB_THK_PLAN_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_THK_PLAN_TO.TabIndex = 180;
            this.SDB_THK_PLAN_TO.Text = "0.00";
            this.SDB_THK_PLAN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1005, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 179;
            this.label18.Tag = "user";
            this.label18.Text = "~";
            // 
            // SDB_THK_PLAN
            // 
            this.SDB_THK_PLAN.Location = new System.Drawing.Point(926, 18);
            this.SDB_THK_PLAN.Name = "SDB_THK_PLAN";
            this.SDB_THK_PLAN.NumValue = 0D;
            this.SDB_THK_PLAN.Scale = 2;
            this.SDB_THK_PLAN.ShowZero = true;
            this.SDB_THK_PLAN.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK_PLAN.TabIndex = 178;
            this.SDB_THK_PLAN.Text = "0.00";
            this.SDB_THK_PLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(849, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 22);
            this.label19.TabIndex = 177;
            this.label19.Text = "订单厚度";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_TRNS_CMPY_CD_TO
            // 
            this.TXT_TRNS_CMPY_CD_TO.Location = new System.Drawing.Point(715, 114);
            this.TXT_TRNS_CMPY_CD_TO.MaxLength = 3;
            this.TXT_TRNS_CMPY_CD_TO.Name = "TXT_TRNS_CMPY_CD_TO";
            this.TXT_TRNS_CMPY_CD_TO.Size = new System.Drawing.Size(84, 22);
            this.TXT_TRNS_CMPY_CD_TO.TabIndex = 176;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(695, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 175;
            this.label17.Tag = "user";
            this.label17.Text = "~";
            // 
            // TXT_TRNS_CMPY_CD
            // 
            this.TXT_TRNS_CMPY_CD.Location = new System.Drawing.Point(616, 114);
            this.TXT_TRNS_CMPY_CD.MaxLength = 3;
            this.TXT_TRNS_CMPY_CD.Name = "TXT_TRNS_CMPY_CD";
            this.TXT_TRNS_CMPY_CD.Size = new System.Drawing.Size(73, 22);
            this.TXT_TRNS_CMPY_CD.TabIndex = 174;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(695, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 173;
            this.label16.Tag = "user";
            this.label16.Text = "~";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(695, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 172;
            this.label15.Tag = "user";
            this.label15.Text = "~";
            // 
            // SDB_LEN_TO
            // 
            this.SDB_LEN_TO.Location = new System.Drawing.Point(715, 82);
            this.SDB_LEN_TO.Name = "SDB_LEN_TO";
            this.SDB_LEN_TO.NumValue = 0D;
            this.SDB_LEN_TO.Scale = 1;
            this.SDB_LEN_TO.ShowZero = true;
            this.SDB_LEN_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_LEN_TO.TabIndex = 171;
            this.SDB_LEN_TO.Text = "0.0";
            this.SDB_LEN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID_TO
            // 
            this.SDB_WID_TO.Location = new System.Drawing.Point(715, 51);
            this.SDB_WID_TO.Name = "SDB_WID_TO";
            this.SDB_WID_TO.NumValue = 0D;
            this.SDB_WID_TO.Scale = 2;
            this.SDB_WID_TO.ShowZero = true;
            this.SDB_WID_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_WID_TO.TabIndex = 170;
            this.SDB_WID_TO.Text = "0.00";
            this.SDB_WID_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK_TO
            // 
            this.SDB_THK_TO.Location = new System.Drawing.Point(715, 18);
            this.SDB_THK_TO.Name = "SDB_THK_TO";
            this.SDB_THK_TO.NumValue = 0D;
            this.SDB_THK_TO.Scale = 2;
            this.SDB_THK_TO.ShowZero = true;
            this.SDB_THK_TO.Size = new System.Drawing.Size(84, 22);
            this.SDB_THK_TO.TabIndex = 169;
            this.SDB_THK_TO.Text = "0.00";
            this.SDB_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(695, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 168;
            this.label14.Tag = "user";
            this.label14.Text = "~";
            // 
            // SDB_LEN
            // 
            this.SDB_LEN.Location = new System.Drawing.Point(617, 82);
            this.SDB_LEN.Name = "SDB_LEN";
            this.SDB_LEN.NumValue = 0D;
            this.SDB_LEN.Scale = 1;
            this.SDB_LEN.ShowZero = true;
            this.SDB_LEN.Size = new System.Drawing.Size(72, 22);
            this.SDB_LEN.TabIndex = 167;
            this.SDB_LEN.Text = "0.0";
            this.SDB_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID
            // 
            this.SDB_WID.Location = new System.Drawing.Point(617, 51);
            this.SDB_WID.Name = "SDB_WID";
            this.SDB_WID.NumValue = 0D;
            this.SDB_WID.Scale = 2;
            this.SDB_WID.ShowZero = true;
            this.SDB_WID.Size = new System.Drawing.Size(72, 22);
            this.SDB_WID.TabIndex = 166;
            this.SDB_WID.Text = "0.00";
            this.SDB_WID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK
            // 
            this.SDB_THK.Location = new System.Drawing.Point(617, 18);
            this.SDB_THK.Name = "SDB_THK";
            this.SDB_THK.NumValue = 0D;
            this.SDB_THK.Scale = 2;
            this.SDB_THK.ShowZero = true;
            this.SDB_THK.Size = new System.Drawing.Size(72, 22);
            this.SDB_THK.TabIndex = 165;
            this.SDB_THK.Text = "0.00";
            this.SDB_THK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(539, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 164;
            this.label13.Text = "分段号";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(539, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 22);
            this.label12.TabIndex = 163;
            this.label12.Text = "母板长";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(539, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 162;
            this.label11.Text = "母板宽";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_scrap
            // 
            this.cbo_scrap.FormattingEnabled = true;
            this.cbo_scrap.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_scrap.Location = new System.Drawing.Point(447, 114);
            this.cbo_scrap.MaxLength = 32767;
            this.cbo_scrap.Name = "cbo_scrap";
            this.cbo_scrap.Size = new System.Drawing.Size(64, 21);
            this.cbo_scrap.TabIndex = 161;
            // 
            // cbo_plate_yn
            // 
            this.cbo_plate_yn.FormattingEnabled = true;
            this.cbo_plate_yn.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_plate_yn.Location = new System.Drawing.Point(447, 82);
            this.cbo_plate_yn.MaxLength = 32767;
            this.cbo_plate_yn.Name = "cbo_plate_yn";
            this.cbo_plate_yn.Size = new System.Drawing.Size(64, 21);
            this.cbo_plate_yn.TabIndex = 160;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(379, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 159;
            this.label10.Text = "是否判废";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(379, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 158;
            this.label9.Text = "已切钢板";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_gas_fl
            // 
            this.cbo_gas_fl.FormattingEnabled = true;
            this.cbo_gas_fl.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_gas_fl.Location = new System.Drawing.Point(447, 51);
            this.cbo_gas_fl.MaxLength = 32767;
            this.cbo_gas_fl.Name = "cbo_gas_fl";
            this.cbo_gas_fl.Size = new System.Drawing.Size(64, 21);
            this.cbo_gas_fl.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(379, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 156;
            this.label7.Text = "切割指示";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(136, 82);
            this.TXT_SLAB_NO.MaxLength = 12;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_SLAB_NO.TabIndex = 154;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(30, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 152;
            this.label8.Text = "标准号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(30, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 151;
            this.label5.Text = "板坯号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MILL_LOT_NO
            // 
            this.TXT_MILL_LOT_NO.Location = new System.Drawing.Point(136, 51);
            this.TXT_MILL_LOT_NO.MaxLength = 14;
            this.TXT_MILL_LOT_NO.Name = "TXT_MILL_LOT_NO";
            this.TXT_MILL_LOT_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_MILL_LOT_NO.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(30, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 145;
            this.label6.Text = "轧批号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "原始坯料钢种";
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
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(447, 18);
            this.CBO_SHIFT.MaxLength = 32767;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(64, 21);
            this.CBO_SHIFT.TabIndex = 2;
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
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(539, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "母板厚";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(379, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次/别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(100, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "切割时间";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 178);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 444);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2020C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2020C";
            this.Text = "母板分段实绩查询_CGT2020C";
            this.Load += new System.EventHandler(this.CGT2020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4ETCR txt_stlgrd;
        private System.Windows.Forms.TextBox TXT_MILL_LOT_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private CommonClass.F4ETCR txt_stdspec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private CommonClass.NumBox SDB_LEN_TO;
        private CommonClass.NumBox SDB_WID_TO;
        private CommonClass.NumBox SDB_THK_TO;
        private System.Windows.Forms.Label label14;
        private CommonClass.NumBox SDB_LEN;
        private CommonClass.NumBox SDB_WID;
        private CommonClass.NumBox SDB_THK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_scrap;
        private System.Windows.Forms.ComboBox cbo_plate_yn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_gas_fl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_TRNS_CMPY_CD_TO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_TRNS_CMPY_CD;
        private CommonClass.NumBox SDB_THK_PLAN_TO;
        private System.Windows.Forms.Label label18;
        private CommonClass.NumBox SDB_THK_PLAN;
        private System.Windows.Forms.Label label19;
        private CommonClass.NumBox SDB_LEN_PLAN_TO;
        private System.Windows.Forms.Label label22;
        private CommonClass.NumBox SDB_LEN_PLAN;
        private System.Windows.Forms.Label label23;
        private CommonClass.NumBox SDB_WID_PLAN_TO;
        private System.Windows.Forms.Label label20;
        private CommonClass.NumBox SDB_WID_PLAN;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button SSPanel2;
        private System.Windows.Forms.Button SSP1;
        private System.Windows.Forms.Button SSPanel1;
        private System.Windows.Forms.Button CMD_CARD;
        private System.Windows.Forms.Button SSP4;
        private System.Windows.Forms.Button SSPpdt;
        private System.Windows.Forms.TextBox txt_STLGRD_Name;
    }
}
