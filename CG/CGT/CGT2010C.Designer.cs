namespace CG
{
    partial class CGT2010C
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
            this.txt_stlgrd1 = new CommonClass.F4ETCR();
            this.txt_stlgrd = new CommonClass.F4ETCR();
            this.txt_mill_stlgrd = new CommonClass.F4ETCR();
            this.txt_stdspec = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSP4 = new System.Windows.Forms.Button();
            this.TXT_CH_CD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_MILL_LOT_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OPT_Cm4 = new System.Windows.Forms.RadioButton();
            this.OPT_Cm1 = new System.Windows.Forms.RadioButton();
            this.OPT_Cm2 = new System.Windows.Forms.RadioButton();
            this.OPT_Cm3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.TXT_SLAB_NO = new System.Windows.Forms.TextBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stlgrd1
            // 
            bControlFiledSetting1.ColumnID = "STLGRD";
            bControlFiledSetting1.TargetControl = this.txt_stlgrd1;
            this.txt_stlgrd1.CustomSetting.Add(bControlFiledSetting1);
            this.txt_stlgrd1.InputControl = this.txt_stlgrd1;
            this.txt_stlgrd1.Location = new System.Drawing.Point(323, 50);
            this.txt_stlgrd1.MaxLength = 12;
            this.txt_stlgrd1.Name = "txt_stlgrd1";
            this.txt_stlgrd1.Size = new System.Drawing.Size(102, 22);
            this.txt_stlgrd1.sJoin = "";
            this.txt_stlgrd1.sSqletc = "SELECT STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM  NISCO.QP_NISCO_CHMC  WHERE STLG" +
    "RD like \'%\'  ORDER  BY  STLGRD  ASC";
            this.txt_stlgrd1.TabIndex = 133;
            // 
            // txt_stlgrd
            // 
            bControlFiledSetting2.ColumnID = "STLGRD";
            bControlFiledSetting2.TargetControl = this.txt_stlgrd;
            this.txt_stlgrd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_stlgrd.InputControl = this.txt_stlgrd;
            this.txt_stlgrd.Location = new System.Drawing.Point(107, 50);
            this.txt_stlgrd.MaxLength = 9999;
            this.txt_stlgrd.Name = "txt_stlgrd";
            this.txt_stlgrd.Size = new System.Drawing.Size(97, 22);
            this.txt_stlgrd.sJoin = "";
            this.txt_stlgrd.sSqletc = "SELECT STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM  NISCO.QP_NISCO_CHMC  WHERE STLG" +
    "RD like \'%\' AND STLGRD_FL <> \'H\'   ORDER  BY  STLGRD  ASC";
            this.txt_stlgrd.TabIndex = 141;
            // 
            // txt_mill_stlgrd
            // 
            bControlFiledSetting3.ColumnID = "STLGRD";
            bControlFiledSetting3.TargetControl = this.txt_mill_stlgrd;
            this.txt_mill_stlgrd.CustomSetting.Add(bControlFiledSetting3);
            this.txt_mill_stlgrd.InputControl = this.txt_mill_stlgrd;
            this.txt_mill_stlgrd.Location = new System.Drawing.Point(605, 50);
            this.txt_mill_stlgrd.MaxLength = 9999;
            this.txt_mill_stlgrd.Name = "txt_mill_stlgrd";
            this.txt_mill_stlgrd.Size = new System.Drawing.Size(123, 22);
            this.txt_mill_stlgrd.sJoin = "";
            this.txt_mill_stlgrd.sSqletc = "SELECT STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM  NISCO.QP_NISCO_CHMC  WHERE STLG" +
    "RD like \'%\' AND STLGRD_FL <> \'H\'   ORDER  BY  STLGRD  ASC";
            this.txt_mill_stlgrd.TabIndex = 143;
            // 
            // txt_stdspec
            // 
            bControlFiledSetting4.ColumnID = "StdSPEC ";
            bControlFiledSetting4.TargetControl = this.txt_stdspec;
            this.txt_stdspec.CustomSetting.Add(bControlFiledSetting4);
            this.txt_stdspec.InputControl = this.txt_stdspec;
            this.txt_stdspec.Location = new System.Drawing.Point(810, 50);
            this.txt_stdspec.MaxLength = 9999;
            this.txt_stdspec.Name = "txt_stdspec";
            this.txt_stdspec.Size = new System.Drawing.Size(112, 22);
            this.txt_stdspec.sJoin = "";
            this.txt_stdspec.sSqletc = "SELECT StdSPEC \"标准代号\", StdSPEC_YY \"发布年度\", STDSPEC_CHR_CD \"标准特性代码\",Gf_ComnNameFind" +
    "(\'Q0025\',STDSPEC_CHR_CD) \"标准特性名称\",STDSPEC_NAME_ENG \"标准英文名\", STDSPEC_NAME_CHN \"标准" +
    "中文名\" FROM  NISCO.QP_STD_HEAD";
            this.txt_stdspec.TabIndex = 148;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.TXT_CH_CD);
            this.groupBox1.Controls.Add(this.txt_stdspec);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXT_MILL_LOT_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_mill_stlgrd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_stlgrd);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_stlgrd1);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.TXT_SLAB_NO);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SSP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSP4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSP4.Location = new System.Drawing.Point(1147, 27);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(86, 34);
            this.SSP4.TabIndex = 150;
            this.SSP4.Text = "重点订单";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // TXT_CH_CD
            // 
            this.TXT_CH_CD.Location = new System.Drawing.Point(928, 31);
            this.TXT_CH_CD.MaxLength = 9999;
            this.TXT_CH_CD.Name = "TXT_CH_CD";
            this.TXT_CH_CD.Size = new System.Drawing.Size(26, 22);
            this.TXT_CH_CD.TabIndex = 149;
            this.TXT_CH_CD.Text = "C";
            this.TXT_CH_CD.Visible = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(734, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 147;
            this.label8.Text = "标准号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MILL_LOT_NO
            // 
            this.TXT_MILL_LOT_NO.Location = new System.Drawing.Point(810, 18);
            this.TXT_MILL_LOT_NO.MaxLength = 14;
            this.TXT_MILL_LOT_NO.Name = "TXT_MILL_LOT_NO";
            this.TXT_MILL_LOT_NO.Size = new System.Drawing.Size(112, 22);
            this.TXT_MILL_LOT_NO.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(734, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 145;
            this.label6.Text = "轧批号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(528, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 144;
            this.label5.Text = "轧制钢种";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "板坯钢种";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OPT_Cm4);
            this.panel1.Controls.Add(this.OPT_Cm1);
            this.panel1.Controls.Add(this.OPT_Cm2);
            this.panel1.Controls.Add(this.OPT_Cm3);
            this.panel1.Location = new System.Drawing.Point(969, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 64);
            this.panel1.TabIndex = 139;
            // 
            // OPT_Cm4
            // 
            this.OPT_Cm4.Location = new System.Drawing.Point(75, 30);
            this.OPT_Cm4.Name = "OPT_Cm4";
            this.OPT_Cm4.Size = new System.Drawing.Size(51, 23);
            this.OPT_Cm4.TabIndex = 2;
            this.OPT_Cm4.Text = "出炉";
            this.OPT_Cm4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Cm4.UseVisualStyleBackColor = true;
            this.OPT_Cm4.CheckedChanged += new System.EventHandler(this.OPT_Cm4_CheckedChanged);
            // 
            // OPT_Cm1
            // 
            this.OPT_Cm1.Checked = true;
            this.OPT_Cm1.ForeColor = System.Drawing.Color.Red;
            this.OPT_Cm1.Location = new System.Drawing.Point(6, 5);
            this.OPT_Cm1.Name = "OPT_Cm1";
            this.OPT_Cm1.Size = new System.Drawing.Size(51, 23);
            this.OPT_Cm1.TabIndex = 1;
            this.OPT_Cm1.TabStop = true;
            this.OPT_Cm1.Text = "粗轧";
            this.OPT_Cm1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Cm1.UseVisualStyleBackColor = true;
            this.OPT_Cm1.CheckedChanged += new System.EventHandler(this.OPT_Cm1_CheckedChanged);
            // 
            // OPT_Cm2
            // 
            this.OPT_Cm2.Location = new System.Drawing.Point(75, 5);
            this.OPT_Cm2.Name = "OPT_Cm2";
            this.OPT_Cm2.Size = new System.Drawing.Size(51, 23);
            this.OPT_Cm2.TabIndex = 1;
            this.OPT_Cm2.Text = "精轧";
            this.OPT_Cm2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Cm2.UseVisualStyleBackColor = true;
            this.OPT_Cm2.CheckedChanged += new System.EventHandler(this.OPT_Cm2_CheckedChanged);
            // 
            // OPT_Cm3
            // 
            this.OPT_Cm3.Location = new System.Drawing.Point(6, 30);
            this.OPT_Cm3.Name = "OPT_Cm3";
            this.OPT_Cm3.Size = new System.Drawing.Size(51, 23);
            this.OPT_Cm3.TabIndex = 1;
            this.OPT_Cm3.Text = "轧废";
            this.OPT_Cm3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Cm3.UseVisualStyleBackColor = true;
            this.OPT_Cm3.CheckedChanged += new System.EventHandler(this.OPT_Cm3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(220, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 134;
            this.label7.Text = "原始坯料钢种";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(476, 18);
            this.CBO_GROUP.MaxLength = 32767;
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(46, 21);
            this.CBO_GROUP.TabIndex = 5;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(220, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_TO.TabIndex = 4;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(107, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(97, 21);
            this.SDT_PROD_DATE_FROM.TabIndex = 4;
            // 
            // TXT_SLAB_NO
            // 
            this.TXT_SLAB_NO.Location = new System.Drawing.Point(605, 18);
            this.TXT_SLAB_NO.MaxLength = 10;
            this.TXT_SLAB_NO.Name = "TXT_SLAB_NO";
            this.TXT_SLAB_NO.Size = new System.Drawing.Size(123, 22);
            this.TXT_SLAB_NO.TabIndex = 3;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(406, 18);
            this.CBO_SHIFT.MaxLength = 32767;
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(64, 21);
            this.CBO_SHIFT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(528, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "板坯号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(338, 18);
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
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "粗轧时间";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 91);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1269, 531);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGT2010C
            // 
            this.ClientSize = new System.Drawing.Size(1269, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGT2010C";
            this.Text = "轧钢实绩查询_CGT2010C";
            this.Load += new System.EventHandler(this.CGT2010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.RadioButton OPT_Cm3;
        private System.Windows.Forms.RadioButton OPT_Cm2;
        private System.Windows.Forms.RadioButton OPT_Cm1;
        private System.Windows.Forms.TextBox TXT_SLAB_NO;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label7;
        private CommonClass.F4ETCR txt_stlgrd1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4ETCR txt_stlgrd;
        private CommonClass.F4ETCR txt_stdspec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_MILL_LOT_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCR txt_mill_stlgrd;
        private System.Windows.Forms.RadioButton OPT_Cm4;
        private System.Windows.Forms.TextBox TXT_CH_CD;
        private System.Windows.Forms.Button SSP4;
    }
}
