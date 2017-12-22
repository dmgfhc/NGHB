namespace CG
{
    partial class WGT3030C
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
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGT3030C));
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.udt_DSC_DATE_MIN = new CommonClass.CeriUDate();
            this.udt_DSC_DATE_MAX = new CommonClass.CeriUDate();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_plt = new CommonClass.F4ETCR();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PROD_CD = new System.Windows.Forms.TextBox();
            this.txt_STDSPEC = new CommonClass.F4ETCR();
            this.txt_GROUP_CD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_THK_MIN = new CommonClass.NumBox();
            this.txt_THK_MAX = new CommonClass.NumBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SMP_NO = new System.Windows.Forms.TextBox();
            this.txt_PROD_NO = new System.Windows.Forms.TextBox();
            this.CHECK_1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 91);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1054, 531);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(390, 55);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(71, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "判定日期";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udt_DSC_DATE_MIN
            // 
            this.udt_DSC_DATE_MIN.Location = new System.Drawing.Point(467, 55);
            this.udt_DSC_DATE_MIN.Name = "udt_DSC_DATE_MIN";
            this.udt_DSC_DATE_MIN.RawDate = "";
            this.udt_DSC_DATE_MIN.Size = new System.Drawing.Size(97, 21);
            this.udt_DSC_DATE_MIN.TabIndex = 4;
            // 
            // udt_DSC_DATE_MAX
            // 
            this.udt_DSC_DATE_MAX.Location = new System.Drawing.Point(570, 55);
            this.udt_DSC_DATE_MAX.Name = "udt_DSC_DATE_MAX";
            this.udt_DSC_DATE_MAX.RawDate = "";
            this.udt_DSC_DATE_MAX.Size = new System.Drawing.Size(97, 21);
            this.udt_DSC_DATE_MAX.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(326, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 134;
            this.label7.Text = "执行标准";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHECK_1);
            this.groupBox1.Controls.Add(this.txt_PROD_NO);
            this.groupBox1.Controls.Add(this.txt_SMP_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_THK_MAX);
            this.groupBox1.Controls.Add(this.txt_THK_MIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_GROUP_CD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_STDSPEC);
            this.groupBox1.Controls.Add(this.txt_PROD_CD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.udt_DSC_DATE_MAX);
            this.groupBox1.Controls.Add(this.udt_DSC_DATE_MIN);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_plt
            // 
            bControlFiledSetting2.ColumnID = "cd";
            bControlFiledSetting2.TargetControl = this.txt_plt;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(102, 17);
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(77, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT cd 代码,cd_short_name 代码简称,cd_name 代码名称,cd_short_eng 代码英文简称,cd_full_eng 代码英文" +
    "名称 FROM ZP_CD WHERE CD_MANA_NO = \'C0001\' ";
            this.txt_plt.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 136;
            this.label1.Tag = "f4";
            this.label1.Text = "工厂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(194, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 138;
            this.label3.Tag = "f4";
            this.label3.Text = "产品";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PROD_CD
            // 
            this.txt_PROD_CD.Enabled = false;
            this.txt_PROD_CD.Location = new System.Drawing.Point(274, 17);
            this.txt_PROD_CD.Name = "txt_PROD_CD";
            this.txt_PROD_CD.Size = new System.Drawing.Size(46, 22);
            this.txt_PROD_CD.TabIndex = 139;
            this.txt_PROD_CD.Text = "PP";
            // 
            // txt_STDSPEC
            // 
            bControlFiledSetting1.ColumnID = "StdSPEC";
            bControlFiledSetting1.TargetControl = this.txt_STDSPEC;
            this.txt_STDSPEC.CustomSetting.Add(bControlFiledSetting1);
            this.txt_STDSPEC.InputControl = this.txt_STDSPEC;
            this.txt_STDSPEC.Location = new System.Drawing.Point(433, 17);
            this.txt_STDSPEC.Name = "txt_STDSPEC";
            this.txt_STDSPEC.Size = new System.Drawing.Size(142, 22);
            this.txt_STDSPEC.sJoin = "";
            this.txt_STDSPEC.sSqletc = resources.GetString("txt_STDSPEC.sSqletc");
            this.txt_STDSPEC.TabIndex = 140;
            // 
            // txt_GROUP_CD
            // 
            this.txt_GROUP_CD.FormattingEnabled = true;
            this.txt_GROUP_CD.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.txt_GROUP_CD.Location = new System.Drawing.Point(102, 55);
            this.txt_GROUP_CD.Name = "txt_GROUP_CD";
            this.txt_GROUP_CD.Size = new System.Drawing.Size(59, 21);
            this.txt_GROUP_CD.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(23, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 141;
            this.label5.Text = "班别";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(194, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 143;
            this.label2.Text = "厚度范围";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_THK_MIN
            // 
            this.txt_THK_MIN.Location = new System.Drawing.Point(274, 55);
            this.txt_THK_MIN.Name = "txt_THK_MIN";
            this.txt_THK_MIN.NumValue = 0D;
            this.txt_THK_MIN.Scale = 2;
            this.txt_THK_MIN.ShowZero = true;
            this.txt_THK_MIN.Size = new System.Drawing.Size(46, 22);
            this.txt_THK_MIN.TabIndex = 146;
            this.txt_THK_MIN.Text = "0.00";
            this.txt_THK_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_THK_MAX
            // 
            this.txt_THK_MAX.Location = new System.Drawing.Point(326, 55);
            this.txt_THK_MAX.Name = "txt_THK_MAX";
            this.txt_THK_MAX.NumValue = 0D;
            this.txt_THK_MAX.Scale = 2;
            this.txt_THK_MAX.ShowZero = true;
            this.txt_THK_MAX.Size = new System.Drawing.Size(46, 22);
            this.txt_THK_MAX.TabIndex = 147;
            this.txt_THK_MAX.Text = "0.00";
            this.txt_THK_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(696, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 148;
            this.label4.Text = "试样号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(696, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 150;
            this.label6.Text = "产品号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SMP_NO
            // 
            this.txt_SMP_NO.Location = new System.Drawing.Point(804, 17);
            this.txt_SMP_NO.MaxLength = 14;
            this.txt_SMP_NO.Name = "txt_SMP_NO";
            this.txt_SMP_NO.Size = new System.Drawing.Size(100, 22);
            this.txt_SMP_NO.TabIndex = 151;
            // 
            // txt_PROD_NO
            // 
            this.txt_PROD_NO.Location = new System.Drawing.Point(804, 55);
            this.txt_PROD_NO.MaxLength = 14;
            this.txt_PROD_NO.Name = "txt_PROD_NO";
            this.txt_PROD_NO.Size = new System.Drawing.Size(100, 22);
            this.txt_PROD_NO.TabIndex = 152;
            // 
            // CHECK_1
            // 
            this.CHECK_1.AutoSize = true;
            this.CHECK_1.Location = new System.Drawing.Point(933, 18);
            this.CHECK_1.Name = "CHECK_1";
            this.CHECK_1.Size = new System.Drawing.Size(104, 17);
            this.CHECK_1.TabIndex = 153;
            this.CHECK_1.Text = "是否替代轧制";
            this.CHECK_1.UseVisualStyleBackColor = true;
            // 
            // WGT3030C
            // 
            this.ClientSize = new System.Drawing.Size(1054, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT3030C";
            this.Text = "钢板性能查询_WGT3030C";
            this.Load += new System.EventHandler(this.WGT3030C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label ULabel5;
        private CommonClass.CeriUDate udt_DSC_DATE_MIN;
        private CommonClass.CeriUDate udt_DSC_DATE_MAX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PROD_CD;
        private System.Windows.Forms.Label label3;
        private CommonClass.F4ETCR txt_STDSPEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_GROUP_CD;
        private System.Windows.Forms.Label label5;
        private CommonClass.NumBox txt_THK_MAX;
        private CommonClass.NumBox txt_THK_MIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PROD_NO;
        private System.Windows.Forms.TextBox txt_SMP_NO;
        private System.Windows.Forms.CheckBox CHECK_1;
    }
}
