namespace CG
{
    partial class WGA1011C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting3 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting4 = new CommonClass.BControlFiledSetting();
            this.CBO_CUR_INV = new CommonClass.F4ETCR();
            this.text_cur_inv = new System.Windows.Forms.TextBox();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_dec = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_GROUP_CD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_thk_to = new CommonClass.NumBox();
            this.txt_thk = new CommonClass.NumBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_slab_status = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.opt_prc_status3 = new System.Windows.Forms.RadioButton();
            this.opt_prc_status2 = new System.Windows.Forms.RadioButton();
            this.txt_MOSLAB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label21 = new System.Windows.Forms.Label();
            this.opt_prc_status1 = new System.Windows.Forms.RadioButton();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
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
            this.CBO_CUR_INV.Location = new System.Drawing.Point(604, 51);
            this.CBO_CUR_INV.MaxLength = 2;
            this.CBO_CUR_INV.Name = "CBO_CUR_INV";
            this.CBO_CUR_INV.Size = new System.Drawing.Size(25, 22);
            this.CBO_CUR_INV.sJoin = "";
            this.CBO_CUR_INV.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
    "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0013\'    AND C" +
    "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.CBO_CUR_INV.TabIndex = 553;
            this.CBO_CUR_INV.Text = "00";
            this.CBO_CUR_INV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_cur_inv
            // 
            this.text_cur_inv.Enabled = false;
            this.text_cur_inv.Location = new System.Drawing.Point(629, 51);
            this.text_cur_inv.Name = "text_cur_inv";
            this.text_cur_inv.Size = new System.Drawing.Size(89, 22);
            this.text_cur_inv.TabIndex = 554;
            this.text_cur_inv.Text = "中厚板卷厂";
            // 
            // txt_plt
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_plt;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_plt_dec;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting3);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting4);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(416, 51);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(38, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
    "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
    "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_plt.TabIndex = 561;
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt_dec
            // 
            this.txt_plt_dec.Enabled = false;
            this.txt_plt_dec.Location = new System.Drawing.Point(454, 51);
            this.txt_plt_dec.Name = "txt_plt_dec";
            this.txt_plt_dec.Size = new System.Drawing.Size(80, 22);
            this.txt_plt_dec.TabIndex = 562;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBO_SHIFT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBO_GROUP_CD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_plt_dec);
            this.panel1.Controls.Add(this.txt_plt);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.txt_thk_to);
            this.panel1.Controls.Add(this.txt_thk);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_slab_status);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.text_cur_inv);
            this.panel1.Controls.Add(this.CBO_CUR_INV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Status);
            this.panel1.Controls.Add(this.opt_prc_status3);
            this.panel1.Controls.Add(this.opt_prc_status2);
            this.panel1.Controls.Add(this.txt_MOSLAB);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.panel1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.opt_prc_status1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 92);
            this.panel1.TabIndex = 0;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(1001, 14);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(50, 22);
            this.CBO_SHIFT.TabIndex = 566;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(925, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 565;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GROUP_CD
            // 
            this.CBO_GROUP_CD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_GROUP_CD.FormattingEnabled = true;
            this.CBO_GROUP_CD.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP_CD.Location = new System.Drawing.Point(856, 51);
            this.CBO_GROUP_CD.Name = "CBO_GROUP_CD";
            this.CBO_GROUP_CD.Size = new System.Drawing.Size(50, 22);
            this.CBO_GROUP_CD.TabIndex = 564;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(780, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 563;
            this.label1.Text = "班别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(340, 51);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 24);
            this.label35.TabIndex = 560;
            this.label35.Tag = "f4";
            this.label35.Text = "生产工厂";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_thk_to
            // 
            this.txt_thk_to.Location = new System.Drawing.Point(686, 14);
            this.txt_thk_to.Name = "txt_thk_to";
            this.txt_thk_to.NumValue = 0D;
            this.txt_thk_to.Scale = 0;
            this.txt_thk_to.ShowZero = true;
            this.txt_thk_to.Size = new System.Drawing.Size(60, 22);
            this.txt_thk_to.TabIndex = 559;
            this.txt_thk_to.Text = "0";
            this.txt_thk_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_thk
            // 
            this.txt_thk.Location = new System.Drawing.Point(626, 14);
            this.txt_thk.Name = "txt_thk";
            this.txt_thk.NumValue = 0D;
            this.txt_thk.Scale = 0;
            this.txt_thk.ShowZero = true;
            this.txt_thk.Size = new System.Drawing.Size(60, 22);
            this.txt_thk.TabIndex = 558;
            this.txt_thk.Text = "0";
            this.txt_thk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(550, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 24);
            this.label14.TabIndex = 557;
            this.label14.Text = "厚度";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_slab_status
            // 
            this.txt_slab_status.FormattingEnabled = true;
            this.txt_slab_status.Items.AddRange(new object[] {
            "",
            "CAA",
            "CAB",
            "CAC",
            "CAD"});
            this.txt_slab_status.Location = new System.Drawing.Point(855, 14);
            this.txt_slab_status.Name = "txt_slab_status";
            this.txt_slab_status.Size = new System.Drawing.Size(50, 21);
            this.txt_slab_status.TabIndex = 556;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(779, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 24);
            this.label22.TabIndex = 555;
            this.label22.Tag = "f4";
            this.label22.Text = "进程状态";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(550, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 552;
            this.label3.Text = "当前库";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(490, 14);
            this.txt_Status.MaxLength = 3;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(23, 22);
            this.txt_Status.TabIndex = 524;
            this.txt_Status.Visible = false;
            // 
            // opt_prc_status3
            // 
            this.opt_prc_status3.AutoSize = true;
            this.opt_prc_status3.Location = new System.Drawing.Point(215, 52);
            this.opt_prc_status3.Name = "opt_prc_status3";
            this.opt_prc_status3.Size = new System.Drawing.Size(77, 17);
            this.opt_prc_status3.TabIndex = 515;
            this.opt_prc_status3.TabStop = true;
            this.opt_prc_status3.Text = "实绩查询";
            this.opt_prc_status3.UseVisualStyleBackColor = true;
            this.opt_prc_status3.CheckedChanged += new System.EventHandler(this.opt_prc_status3_CheckedChanged);
            // 
            // opt_prc_status2
            // 
            this.opt_prc_status2.AutoSize = true;
            this.opt_prc_status2.Location = new System.Drawing.Point(118, 52);
            this.opt_prc_status2.Name = "opt_prc_status2";
            this.opt_prc_status2.Size = new System.Drawing.Size(77, 17);
            this.opt_prc_status2.TabIndex = 514;
            this.opt_prc_status2.TabStop = true;
            this.opt_prc_status2.Text = "实绩录入";
            this.opt_prc_status2.UseVisualStyleBackColor = true;
            this.opt_prc_status2.CheckedChanged += new System.EventHandler(this.opt_prc_status2_CheckedChanged);
            // 
            // txt_MOSLAB
            // 
            this.txt_MOSLAB.Location = new System.Drawing.Point(394, 14);
            this.txt_MOSLAB.MaxLength = 10;
            this.txt_MOSLAB.Name = "txt_MOSLAB";
            this.txt_MOSLAB.Size = new System.Drawing.Size(92, 22);
            this.txt_MOSLAB.TabIndex = 513;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(340, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 24);
            this.label17.TabIndex = 512;
            this.label17.Text = "板坯号";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(206, 14);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(112, 24);
            this.SDT_PROD_DATE_TO.TabIndex = 511;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(93, 14);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(112, 24);
            this.SDT_PROD_DATE_FROM.TabIndex = 510;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(17, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 24);
            this.label21.TabIndex = 509;
            this.label21.Text = "生产日期";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opt_prc_status1
            // 
            this.opt_prc_status1.AutoSize = true;
            this.opt_prc_status1.Location = new System.Drawing.Point(21, 52);
            this.opt_prc_status1.Name = "opt_prc_status1";
            this.opt_prc_status1.Size = new System.Drawing.Size(77, 17);
            this.opt_prc_status1.TabIndex = 3;
            this.opt_prc_status1.TabStop = true;
            this.opt_prc_status1.Text = "指示下达";
            this.opt_prc_status1.UseVisualStyleBackColor = true;
            this.opt_prc_status1.CheckedChanged += new System.EventHandler(this.opt_prc_status1_CheckedChanged);
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 92);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1126, 337);
            this.ss1.TabIndex = 1;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ss1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // WGA1011C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 429);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.panel1);
            this.Name = "WGA1011C";
            this.Text = "指示下达";
            this.Load += new System.EventHandler(this.WGA1011C_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt_prc_status1;
        private System.Windows.Forms.Label label21;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.TextBox txt_MOSLAB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton opt_prc_status3;
        private System.Windows.Forms.RadioButton opt_prc_status2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox text_cur_inv;
        private CommonClass.F4ETCR CBO_CUR_INV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_slab_status;
        private System.Windows.Forms.Label label22;
        private CommonClass.NumBox txt_thk_to;
        private CommonClass.NumBox txt_thk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_plt_dec;
        private CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox CBO_GROUP_CD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label2;
    }
}