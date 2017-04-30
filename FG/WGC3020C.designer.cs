namespace WG
{
    partial class WGC3020C
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
            this.txt_SMP_LOC = new CommonClass.F4ETCR();
            this.txt_SMP_LOC_NAME = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sdt_prod_date = new CommonClass.CeriUDate();
            this.txt_charge_no = new System.Windows.Forms.TextBox();
            this.opt_Product = new System.Windows.Forms.RadioButton();
            this.opt_Product1 = new System.Windows.Forms.RadioButton();
            this.cbo_group = new System.Windows.Forms.ComboBox();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SMP_LOC
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_SMP_LOC;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_SMP_LOC_NAME;
            this.txt_SMP_LOC.CustomSetting.Add(bControlFiledSetting1);
            this.txt_SMP_LOC.CustomSetting.Add(bControlFiledSetting2);
            this.txt_SMP_LOC.InputControl = this.txt_SMP_LOC;
            this.txt_SMP_LOC.Location = new System.Drawing.Point(473, 13);
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
            this.txt_SMP_LOC_NAME.Location = new System.Drawing.Point(498, 13);
            this.txt_SMP_LOC_NAME.Name = "txt_SMP_LOC_NAME";
            this.txt_SMP_LOC_NAME.Size = new System.Drawing.Size(69, 22);
            this.txt_SMP_LOC_NAME.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sdt_prod_date);
            this.groupBox1.Controls.Add(this.txt_charge_no);
            this.groupBox1.Controls.Add(this.opt_Product);
            this.groupBox1.Controls.Add(this.opt_Product1);
            this.groupBox1.Controls.Add(this.cbo_group);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sdt_prod_date
            // 
            this.sdt_prod_date.Location = new System.Drawing.Point(110, 12);
            this.sdt_prod_date.Name = "sdt_prod_date";
            this.sdt_prod_date.RawDate = "";
            this.sdt_prod_date.Size = new System.Drawing.Size(97, 21);
            this.sdt_prod_date.TabIndex = 11;
            // 
            // txt_charge_no
            // 
            this.txt_charge_no.Location = new System.Drawing.Point(110, 36);
            this.txt_charge_no.Name = "txt_charge_no";
            this.txt_charge_no.Size = new System.Drawing.Size(97, 22);
            this.txt_charge_no.TabIndex = 10;
            // 
            // opt_Product
            // 
            this.opt_Product.AutoSize = true;
            this.opt_Product.Location = new System.Drawing.Point(405, 38);
            this.opt_Product.Name = "opt_Product";
            this.opt_Product.Size = new System.Drawing.Size(59, 16);
            this.opt_Product.TabIndex = 8;
            this.opt_Product.TabStop = true;
            this.opt_Product.Text = "楔形板";
            this.opt_Product.UseVisualStyleBackColor = true;
            this.opt_Product.Click += new System.EventHandler(this.opt_Product_Click);
            // 
            // opt_Product1
            // 
            this.opt_Product1.AutoSize = true;
            this.opt_Product1.Location = new System.Drawing.Point(405, 14);
            this.opt_Product1.Name = "opt_Product1";
            this.opt_Product1.Size = new System.Drawing.Size(47, 16);
            this.opt_Product1.TabIndex = 7;
            this.opt_Product1.TabStop = true;
            this.opt_Product1.Text = "钢板";
            this.opt_Product1.UseVisualStyleBackColor = true;
            this.opt_Product1.Click += new System.EventHandler(this.opt_Product1_Click);
            // 
            // cbo_group
            // 
            this.cbo_group.FormattingEnabled = true;
            this.cbo_group.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbo_group.Location = new System.Drawing.Point(322, 37);
            this.cbo_group.Name = "cbo_group";
            this.cbo_group.Size = new System.Drawing.Size(42, 21);
            this.cbo_group.TabIndex = 5;
            // 
            // cbo_shift
            // 
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(322, 13);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(42, 21);
            this.cbo_shift.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "板坯号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(262, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(40, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(262, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SMP_LOC);
            this.groupBox2.Controls.Add(this.txt_SMP_LOC_NAME);
            this.groupBox2.Controls.Add(this.txt_CHG_STDSPEC);
            this.groupBox2.Controls.Add(this.txt_SMP_LEN);
            this.groupBox2.Controls.Add(this.txt_CHG_SMP_NO);
            this.groupBox2.Controls.Add(this.txt_SMP_NO);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Cmd_Set_Save);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(514, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_CHG_STDSPEC
            // 
            this.txt_CHG_STDSPEC.Location = new System.Drawing.Point(354, 37);
            this.txt_CHG_STDSPEC.Name = "txt_CHG_STDSPEC";
            this.txt_CHG_STDSPEC.sFcontrol = "StdSPEC";
            this.txt_CHG_STDSPEC.Size = new System.Drawing.Size(213, 22);
            this.txt_CHG_STDSPEC.sJoin = "";
            this.txt_CHG_STDSPEC.sSqletc = "SELECT StdSPEC 标准代号, StdSPEC_YY 发布年度, STDSPEC_CHR_CD 标准特性代码,        Gf_ComnNameFi" +
                "nd(\'Q0025\',STDSPEC_CHR_CD) 标准特性名称, STDSPEC_NAME_ENG 标准英文名, STDSPEC_NAME_CHN 标准中文" +
                "名 FROM  NISCO.QP_STD_HEAD   ";
            this.txt_CHG_STDSPEC.TabIndex = 18;
            // 
            // txt_SMP_LEN
            // 
            this.txt_SMP_LEN.Location = new System.Drawing.Point(354, 13);
            this.txt_SMP_LEN.MaxLength = 3;
            this.txt_SMP_LEN.Name = "txt_SMP_LEN";
            this.txt_SMP_LEN.NumValue = 0D;
            this.txt_SMP_LEN.Scale = 0;
            this.txt_SMP_LEN.ShowZero = false;
            this.txt_SMP_LEN.Size = new System.Drawing.Size(37, 22);
            this.txt_SMP_LEN.TabIndex = 17;
            this.txt_SMP_LEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CHG_SMP_NO
            // 
            this.txt_CHG_SMP_NO.Location = new System.Drawing.Point(118, 37);
            this.txt_CHG_SMP_NO.Name = "txt_CHG_SMP_NO";
            this.txt_CHG_SMP_NO.Size = new System.Drawing.Size(107, 22);
            this.txt_CHG_SMP_NO.TabIndex = 16;
            // 
            // txt_SMP_NO
            // 
            this.txt_SMP_NO.Location = new System.Drawing.Point(118, 13);
            this.txt_SMP_NO.MaxLength = 14;
            this.txt_SMP_NO.Name = "txt_SMP_NO";
            this.txt_SMP_NO.Size = new System.Drawing.Size(107, 22);
            this.txt_SMP_NO.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(618, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 14;
            this.label10.Tag = "USER";
            this.label10.Text = "<< 出口板, 船板, 锅炉板, 压力容器板必须输入>>";
            // 
            // Cmd_Set_Save
            // 
            this.Cmd_Set_Save.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_Set_Save.Location = new System.Drawing.Point(620, 11);
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
            this.label8.Location = new System.Drawing.Point(276, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "试样长度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(276, 37);
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
            this.label6.Location = new System.Drawing.Point(393, 13);
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
            this.label9.Location = new System.Drawing.Point(39, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "改判试样号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(39, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "试样号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Location = new System.Drawing.Point(9, 63);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1349, 303);
            this.ss1.TabIndex = 2;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Location = new System.Drawing.Point(9, 370);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1349, 252);
            this.ss2.TabIndex = 3;
            this.ss2.EditModeOn += new System.EventHandler(this.ss2_EditModeOn);
            this.ss2.LeaveCell += new FarPoint.Win.Spread.LeaveCellEventHandler(this.ss2_LeaveCell);
            this.ss2.EnterCell += new FarPoint.Win.Spread.EnterCellEventHandler(this.ss2_EnterCell);
            this.ss2.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss2_ButtonClicked);
            this.ss2.EditorFocused += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss2_EditorFocused);
            this.ss2.Enter += new System.EventHandler(this.ss2_Enter);
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // WGC3020C
            // 
            this.ClientSize = new System.Drawing.Size(1370, 622);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC3020C";
            this.Text = "钢板取样实绩管理画面_WGC3020C";
            this.Load += new System.EventHandler(this.WGC3020C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt_Product;
        private System.Windows.Forms.RadioButton opt_Product1;
        private System.Windows.Forms.ComboBox cbo_group;
        private System.Windows.Forms.ComboBox cbo_shift;
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
        private CommonClass.CeriUDate sdt_prod_date;
        private System.Windows.Forms.TextBox txt_SMP_LOC_NAME;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private CommonClass.F4ETCR txt_SMP_LOC;
    }
}
