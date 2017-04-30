namespace FG
{
    partial class FGA1030C
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
            this.f4ETCR_PLT = new CommonClass.F4ETCR();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_iType = new System.Windows.Forms.TextBox();
            this.cbo_chg_no = new System.Windows.Forms.ComboBox();
            this.TXT_MAT_NO = new CommonClass.F4ETCN();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PrcLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_SHIFT = new System.Windows.Forms.ComboBox();
            this.TXT_GROUP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_ColEndTemp = new CommonClass.NumBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_HEAT_RATIO = new CommonClass.NumBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SDB_WAT_TEMP = new CommonClass.NumBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_SP_DISCHARGE = new CommonClass.NumBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_ColStaTemp = new CommonClass.NumBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_HeatTemp = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DisCharTemp = new CommonClass.NumBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SP_CAL = new CommonClass.NumBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.TXT_EMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SP_CHARGE = new CommonClass.NumBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // f4ETCR_PLT
            // 
            bControlFiledSetting1.ColumnID = "T.CD";
            bControlFiledSetting1.TargetControl = this.f4ETCR_PLT;
            bControlFiledSetting2.ColumnID = "T.CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.TXT_PLT;
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting1);
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting2);
            this.f4ETCR_PLT.Enabled = false;
            this.f4ETCR_PLT.InputControl = this.f4ETCR_PLT;
            this.f4ETCR_PLT.Location = new System.Drawing.Point(293, 16);
            this.f4ETCR_PLT.MaxLength = 4;
            this.f4ETCR_PLT.Name = "f4ETCR_PLT";
            this.f4ETCR_PLT.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_PLT.sJoin = "";
            this.f4ETCR_PLT.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'B0033\'";
            this.f4ETCR_PLT.TabIndex = 503;
            this.f4ETCR_PLT.Text = "C2";
            this.f4ETCR_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.f4ETCR_PLT.TextChanged += new System.EventHandler(this.f4ETCR_PLT_TextChanged);
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Enabled = false;
            this.TXT_PLT.Location = new System.Drawing.Point(337, 16);
            this.TXT_PLT.MaxLength = 8;
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(92, 22);
            this.TXT_PLT.TabIndex = 504;
            this.TXT_PLT.Text = "宽厚板厂";
            this.TXT_PLT.TextChanged += new System.EventHandler(this.TXT_PLT_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_iType);
            this.groupBox1.Controls.Add(this.cbo_chg_no);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PrcLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_iType
            // 
            this.txt_iType.Location = new System.Drawing.Point(21, 17);
            this.txt_iType.Name = "txt_iType";
            this.txt_iType.Size = new System.Drawing.Size(14, 22);
            this.txt_iType.TabIndex = 509;
            this.txt_iType.Visible = false;
            // 
            // cbo_chg_no
            // 
            this.cbo_chg_no.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_chg_no.FormattingEnabled = true;
            this.cbo_chg_no.Items.AddRange(new object[] {
            "1"});
            this.cbo_chg_no.Location = new System.Drawing.Point(690, 16);
            this.cbo_chg_no.MaxLength = 1;
            this.cbo_chg_no.Name = "cbo_chg_no";
            this.cbo_chg_no.Size = new System.Drawing.Size(49, 22);
            this.cbo_chg_no.TabIndex = 508;
            this.cbo_chg_no.Text = "1";
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(90, 16);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.sFcontrol = "T.CD";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(141, 22);
            this.TXT_MAT_NO.sJoin = "";
            this.TXT_MAT_NO.sSqletc = "SELECT T.CD ,T.CD_SHORT_NAME  FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO = \'Q0073\' ORD" +
                "ER BY T.CD";
            this.TXT_MAT_NO.TabIndex = 506;
            this.TXT_MAT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(569, 16);
            this.cbo_PrcLine.MaxLength = 1;
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(43, 22);
            this.cbo_PrcLine.TabIndex = 505;
            this.cbo_PrcLine.Text = "1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(237, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "工厂";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_PrcLine
            // 
            this.txt_PrcLine.Location = new System.Drawing.Point(458, 17);
            this.txt_PrcLine.Name = "txt_PrcLine";
            this.txt_PrcLine.Size = new System.Drawing.Size(14, 22);
            this.txt_PrcLine.TabIndex = 199;
            this.txt_PrcLine.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(618, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "炉座号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(491, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "机号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "查询号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SHIFT
            // 
            this.TXT_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.TXT_SHIFT.FormattingEnabled = true;
            this.TXT_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.TXT_SHIFT.Location = new System.Drawing.Point(895, 87);
            this.TXT_SHIFT.Name = "TXT_SHIFT";
            this.TXT_SHIFT.Size = new System.Drawing.Size(28, 22);
            this.TXT_SHIFT.TabIndex = 510;
            this.TXT_SHIFT.Text = "1";
            this.TXT_SHIFT.Visible = false;
            // 
            // TXT_GROUP
            // 
            this.TXT_GROUP.Font = new System.Drawing.Font("宋体", 10.25F);
            this.TXT_GROUP.FormattingEnabled = true;
            this.TXT_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.TXT_GROUP.Location = new System.Drawing.Point(870, 87);
            this.TXT_GROUP.Name = "TXT_GROUP";
            this.TXT_GROUP.Size = new System.Drawing.Size(19, 22);
            this.TXT_GROUP.TabIndex = 524;
            this.TXT_GROUP.Text = "1";
            this.TXT_GROUP.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_SHIFT);
            this.groupBox2.Controls.Add(this.TXT_ColEndTemp);
            this.groupBox2.Controls.Add(this.TXT_GROUP);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_HEAT_RATIO);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.SDB_WAT_TEMP);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_SP_DISCHARGE);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TXT_ColStaTemp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_HeatTemp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_DisCharTemp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_SP_CAL);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.TXT_EMP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_SP_CHARGE);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TXT_ColEndTemp
            // 
            this.TXT_ColEndTemp.Location = new System.Drawing.Point(798, 88);
            this.TXT_ColEndTemp.MaxLength = 4;
            this.TXT_ColEndTemp.Name = "TXT_ColEndTemp";
            this.TXT_ColEndTemp.NumValue = 0D;
            this.TXT_ColEndTemp.Scale = 0;
            this.TXT_ColEndTemp.ShowZero = true;
            this.TXT_ColEndTemp.Size = new System.Drawing.Size(42, 22);
            this.TXT_ColEndTemp.TabIndex = 523;
            this.TXT_ColEndTemp.Text = "0";
            this.TXT_ColEndTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(364, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 22);
            this.label17.TabIndex = 521;
            this.label17.Text = "加热速率";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_HEAT_RATIO
            // 
            this.txt_HEAT_RATIO.Location = new System.Drawing.Point(435, 88);
            this.txt_HEAT_RATIO.MaxLength = 8;
            this.txt_HEAT_RATIO.Name = "txt_HEAT_RATIO";
            this.txt_HEAT_RATIO.NumValue = 0D;
            this.txt_HEAT_RATIO.Scale = 2;
            this.txt_HEAT_RATIO.ShowZero = true;
            this.txt_HEAT_RATIO.Size = new System.Drawing.Size(47, 22);
            this.txt_HEAT_RATIO.TabIndex = 522;
            this.txt_HEAT_RATIO.Text = "0.00";
            this.txt_HEAT_RATIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(12, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 22);
            this.label16.TabIndex = 519;
            this.label16.Text = "驻留时间";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // SDB_WAT_TEMP
            // 
            this.SDB_WAT_TEMP.Location = new System.Drawing.Point(90, 90);
            this.SDB_WAT_TEMP.MaxLength = 3;
            this.SDB_WAT_TEMP.Name = "SDB_WAT_TEMP";
            this.SDB_WAT_TEMP.NumValue = 0D;
            this.SDB_WAT_TEMP.Scale = 0;
            this.SDB_WAT_TEMP.ShowZero = true;
            this.SDB_WAT_TEMP.Size = new System.Drawing.Size(43, 22);
            this.SDB_WAT_TEMP.TabIndex = 520;
            this.SDB_WAT_TEMP.Text = "0";
            this.SDB_WAT_TEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SDB_WAT_TEMP.Visible = false;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(488, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 22);
            this.label14.TabIndex = 515;
            this.label14.Text = "出炉速度";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SP_DISCHARGE
            // 
            this.txt_SP_DISCHARGE.Location = new System.Drawing.Point(569, 88);
            this.txt_SP_DISCHARGE.MaxLength = 8;
            this.txt_SP_DISCHARGE.Name = "txt_SP_DISCHARGE";
            this.txt_SP_DISCHARGE.NumValue = 0D;
            this.txt_SP_DISCHARGE.Scale = 2;
            this.txt_SP_DISCHARGE.ShowZero = true;
            this.txt_SP_DISCHARGE.Size = new System.Drawing.Size(43, 22);
            this.txt_SP_DISCHARGE.TabIndex = 516;
            this.txt_SP_DISCHARGE.Text = "0.00";
            this.txt_SP_DISCHARGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(618, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 22);
            this.label15.TabIndex = 517;
            this.label15.Text = "冷却温度（开/完）";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_ColStaTemp
            // 
            this.TXT_ColStaTemp.Location = new System.Drawing.Point(745, 88);
            this.TXT_ColStaTemp.MaxLength = 4;
            this.TXT_ColStaTemp.Name = "TXT_ColStaTemp";
            this.TXT_ColStaTemp.NumValue = 0D;
            this.TXT_ColStaTemp.Scale = 0;
            this.TXT_ColStaTemp.ShowZero = true;
            this.TXT_ColStaTemp.Size = new System.Drawing.Size(47, 22);
            this.TXT_ColStaTemp.TabIndex = 518;
            this.TXT_ColStaTemp.Text = "0";
            this.TXT_ColStaTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(237, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 513;
            this.label13.Text = "加热温度";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_HeatTemp
            // 
            this.txt_HeatTemp.Location = new System.Drawing.Point(315, 56);
            this.txt_HeatTemp.MaxLength = 4;
            this.txt_HeatTemp.Name = "txt_HeatTemp";
            this.txt_HeatTemp.NumValue = 0D;
            this.txt_HeatTemp.Scale = 0;
            this.txt_HeatTemp.ShowZero = true;
            this.txt_HeatTemp.Size = new System.Drawing.Size(43, 22);
            this.txt_HeatTemp.TabIndex = 514;
            this.txt_HeatTemp.Text = "0";
            this.txt_HeatTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(237, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 511;
            this.label11.Text = "出炉温度";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DisCharTemp
            // 
            this.txt_DisCharTemp.Location = new System.Drawing.Point(315, 88);
            this.txt_DisCharTemp.MaxLength = 4;
            this.txt_DisCharTemp.Name = "txt_DisCharTemp";
            this.txt_DisCharTemp.NumValue = 0D;
            this.txt_DisCharTemp.Scale = 0;
            this.txt_DisCharTemp.ShowZero = true;
            this.txt_DisCharTemp.Size = new System.Drawing.Size(43, 22);
            this.txt_DisCharTemp.TabIndex = 512;
            this.txt_DisCharTemp.Text = "0";
            this.txt_DisCharTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(491, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 509;
            this.label5.Text = "工艺速度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SP_CAL
            // 
            this.txt_SP_CAL.Location = new System.Drawing.Point(569, 56);
            this.txt_SP_CAL.MaxLength = 8;
            this.txt_SP_CAL.Name = "txt_SP_CAL";
            this.txt_SP_CAL.NumValue = 0D;
            this.txt_SP_CAL.Scale = 2;
            this.txt_SP_CAL.ShowZero = true;
            this.txt_SP_CAL.Size = new System.Drawing.Size(43, 22);
            this.txt_SP_CAL.TabIndex = 510;
            this.txt_SP_CAL.Text = "0.00";
            this.txt_SP_CAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(12, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 386;
            this.label12.Text = "出炉时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(90, 56);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(141, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 388;
            // 
            // TXT_EMP
            // 
            this.TXT_EMP.Enabled = false;
            this.TXT_EMP.Location = new System.Drawing.Point(745, 56);
            this.TXT_EMP.Name = "TXT_EMP";
            this.TXT_EMP.Size = new System.Drawing.Size(95, 22);
            this.TXT_EMP.TabIndex = 501;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(364, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 471;
            this.label6.Text = "入炉速度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SP_CHARGE
            // 
            this.txt_SP_CHARGE.Location = new System.Drawing.Point(435, 56);
            this.txt_SP_CHARGE.MaxLength = 8;
            this.txt_SP_CHARGE.Name = "txt_SP_CHARGE";
            this.txt_SP_CHARGE.NumValue = 0D;
            this.txt_SP_CHARGE.Scale = 2;
            this.txt_SP_CHARGE.ShowZero = true;
            this.txt_SP_CHARGE.Size = new System.Drawing.Size(47, 22);
            this.txt_SP_CHARGE.TabIndex = 472;
            this.txt_SP_CHARGE.Text = "0.00";
            this.txt_SP_CHARGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(618, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 477;
            this.label9.Text = "作业人员";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 504);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(982, 483);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGA1030C
            // 
            this.ClientSize = new System.Drawing.Size(988, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGA1030C";
            this.Text = "出炉作业实绩查询及修改界面_FGA1030C";
            this.Load += new System.EventHandler(this.FGA1030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private CommonClass.MaskedDate TXT_DISCHARGE_TIME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_PrcLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private CommonClass.NumBox txt_SP_CHARGE;
        private System.Windows.Forms.TextBox TXT_EMP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private CommonClass.F4ETCN TXT_MAT_NO;
        private System.Windows.Forms.ComboBox cbo_chg_no;
        private System.Windows.Forms.TextBox txt_iType;
        private System.Windows.Forms.Label label16;
        private CommonClass.NumBox SDB_WAT_TEMP;
        private System.Windows.Forms.Label label15;
        private CommonClass.NumBox TXT_ColStaTemp;
        private System.Windows.Forms.Label label14;
        private CommonClass.NumBox txt_SP_DISCHARGE;
        private System.Windows.Forms.Label label13;
        private CommonClass.NumBox txt_HeatTemp;
        private System.Windows.Forms.Label label11;
        private CommonClass.NumBox txt_DisCharTemp;
        private System.Windows.Forms.Label label5;
        private CommonClass.NumBox txt_SP_CAL;
        private CommonClass.NumBox TXT_ColEndTemp;
        private System.Windows.Forms.Label label17;
        private CommonClass.NumBox txt_HEAT_RATIO;
        private System.Windows.Forms.ComboBox TXT_GROUP;
        private System.Windows.Forms.ComboBox TXT_SHIFT;
    }
}
