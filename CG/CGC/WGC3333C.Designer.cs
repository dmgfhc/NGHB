namespace WG
{
    partial class WGC3333C
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
            this.txt_smp_loc = new CommonClass.F4ETCR();
            this.txt_smp_loc_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_chg_stdspec = new CommonClass.F4ETCN();
            this.txt_smp_len = new CommonClass.NumBox();
            this.txt_chg_smp_no = new System.Windows.Forms.TextBox();
            this.txt_smp_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmd_Set_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_smp_loc
            // 
            this.txt_smp_loc.conLength = 0;
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_smp_loc;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_smp_loc_name;
            this.txt_smp_loc.CustomSetting.Add(bControlFiledSetting1);
            this.txt_smp_loc.CustomSetting.Add(bControlFiledSetting2);
            this.txt_smp_loc.InputControl = this.txt_smp_loc;
            this.txt_smp_loc.Location = new System.Drawing.Point(765, 10);
            this.txt_smp_loc.MaxLength = 1;
            this.txt_smp_loc.Name = "txt_smp_loc";
            this.txt_smp_loc.Size = new System.Drawing.Size(25, 22);
            this.txt_smp_loc.sJoin = "";
            this.txt_smp_loc.sSqletc = "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称, CD_SHORT_ENG 代码英文简称, CD_FULL_ENG " +
                "代码英文名称 FROM NISCO.ZP_CD  WHERE CD_MANA_NO = \'Q0021\'  ORDER BY CD ASC ";
            this.txt_smp_loc.TabIndex = 34;
            // 
            // txt_smp_loc_name
            // 
            this.txt_smp_loc_name.Location = new System.Drawing.Point(790, 10);
            this.txt_smp_loc_name.Name = "txt_smp_loc_name";
            this.txt_smp_loc_name.Size = new System.Drawing.Size(69, 22);
            this.txt_smp_loc_name.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_smp_loc);
            this.groupBox1.Controls.Add(this.txt_smp_loc_name);
            this.groupBox1.Controls.Add(this.txt_chg_stdspec);
            this.groupBox1.Controls.Add(this.txt_smp_len);
            this.groupBox1.Controls.Add(this.txt_chg_smp_no);
            this.groupBox1.Controls.Add(this.txt_smp_no);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Cmd_Set_Save);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_chg_stdspec
            // 
            this.txt_chg_stdspec.Location = new System.Drawing.Point(646, 34);
            this.txt_chg_stdspec.Name = "txt_chg_stdspec";
            this.txt_chg_stdspec.sFcontrol = "";
            this.txt_chg_stdspec.Size = new System.Drawing.Size(213, 22);
            this.txt_chg_stdspec.sJoin = "";
            this.txt_chg_stdspec.sSqletc = "";
            this.txt_chg_stdspec.TabIndex = 32;
            // 
            // txt_smp_len
            // 
            this.txt_smp_len.Location = new System.Drawing.Point(646, 10);
            this.txt_smp_len.MaxLength = 3;
            this.txt_smp_len.Name = "txt_smp_len";
            this.txt_smp_len.NumValue = 0D;
            this.txt_smp_len.Scale = 0;
            this.txt_smp_len.ShowZero = false;
            this.txt_smp_len.Size = new System.Drawing.Size(37, 22);
            this.txt_smp_len.TabIndex = 31;
            this.txt_smp_len.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_chg_smp_no
            // 
            this.txt_chg_smp_no.Location = new System.Drawing.Point(451, 34);
            this.txt_chg_smp_no.Name = "txt_chg_smp_no";
            this.txt_chg_smp_no.Size = new System.Drawing.Size(107, 22);
            this.txt_chg_smp_no.TabIndex = 30;
            // 
            // txt_smp_no
            // 
            this.txt_smp_no.Location = new System.Drawing.Point(451, 10);
            this.txt_smp_no.MaxLength = 14;
            this.txt_smp_no.Name = "txt_smp_no";
            this.txt_smp_no.Size = new System.Drawing.Size(107, 22);
            this.txt_smp_no.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(866, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 28;
            this.label10.Tag = "USER";
            this.label10.Text = "<< 出口板, 船板, 锅炉板, 压力容器板必须输入>>";
            // 
            // Cmd_Set_Save
            // 
            this.Cmd_Set_Save.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_Set_Save.Location = new System.Drawing.Point(868, 8);
            this.Cmd_Set_Save.Name = "Cmd_Set_Save";
            this.Cmd_Set_Save.Size = new System.Drawing.Size(143, 23);
            this.Cmd_Set_Save.TabIndex = 27;
            this.Cmd_Set_Save.Text = "多行设定";
            this.Cmd_Set_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cmd_Set_Save.UseVisualStyleBackColor = true;
            this.Cmd_Set_Save.Click += new System.EventHandler(this.Cmd_Set_Save_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(568, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "试样长度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(568, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 25;
            this.label7.Tag = "F4";
            this.label7.Text = "改判时标准";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(685, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 24;
            this.label6.Tag = "F4";
            this.label6.Text = "取样位置";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(372, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "改判试样号";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(372, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "试样号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_prod_date
            // 
            this.sdt_prod_date.Location = new System.Drawing.Point(76, 9);
            this.sdt_prod_date.Name = "sdt_prod_date";
            this.sdt_prod_date.RawDate = "";
            this.sdt_prod_date.Size = new System.Drawing.Size(97, 21);
            this.sdt_prod_date.TabIndex = 21;
            // 
            // txt_charge_no
            // 
            this.txt_charge_no.Location = new System.Drawing.Point(76, 33);
            this.txt_charge_no.Name = "txt_charge_no";
            this.txt_charge_no.Size = new System.Drawing.Size(97, 22);
            this.txt_charge_no.TabIndex = 20;
            // 
            // opt_Product
            // 
            this.opt_Product.AutoSize = true;
            this.opt_Product.Location = new System.Drawing.Point(304, 35);
            this.opt_Product.Name = "opt_Product";
            this.opt_Product.Size = new System.Drawing.Size(59, 16);
            this.opt_Product.TabIndex = 19;
            this.opt_Product.TabStop = true;
            this.opt_Product.Text = "楔形板";
            this.opt_Product.UseVisualStyleBackColor = true;
            // 
            // opt_Product1
            // 
            this.opt_Product1.AutoSize = true;
            this.opt_Product1.Location = new System.Drawing.Point(304, 11);
            this.opt_Product1.Name = "opt_Product1";
            this.opt_Product1.Size = new System.Drawing.Size(47, 16);
            this.opt_Product1.TabIndex = 18;
            this.opt_Product1.TabStop = true;
            this.opt_Product1.Text = "钢板";
            this.opt_Product1.UseVisualStyleBackColor = true;
            // 
            // cbo_group
            // 
            this.cbo_group.FormattingEnabled = true;
            this.cbo_group.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbo_group.Location = new System.Drawing.Point(251, 34);
            this.cbo_group.Name = "cbo_group";
            this.cbo_group.Size = new System.Drawing.Size(42, 21);
            this.cbo_group.TabIndex = 16;
            // 
            // cbo_shift
            // 
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_shift.Location = new System.Drawing.Point(251, 10);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(42, 21);
            this.cbo_shift.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "查询号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(191, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1012, 307);
            this.ss1.TabIndex = 3;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 386);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1018, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 233);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1012, 212);
            this.ss2.TabIndex = 0;
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
            // WGC3333C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC3333C";
            this.Text = "钢板取样实绩管理画面_WGC3020C";
            this.Load += new System.EventHandler(this.WGC3333C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CommonClass.CeriUDate sdt_prod_date;
        private System.Windows.Forms.TextBox txt_charge_no;
        private System.Windows.Forms.RadioButton opt_Product;
        private System.Windows.Forms.RadioButton opt_Product1;
        private System.Windows.Forms.ComboBox cbo_group;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CommonClass.F4ETCR txt_smp_loc;
        private System.Windows.Forms.TextBox txt_smp_loc_name;
        private CommonClass.F4ETCN txt_chg_stdspec;
        private CommonClass.NumBox txt_smp_len;
        private System.Windows.Forms.TextBox txt_chg_smp_no;
        private System.Windows.Forms.TextBox txt_smp_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Cmd_Set_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
    }
}
