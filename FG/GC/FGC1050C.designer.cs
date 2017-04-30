namespace FG
{
    partial class FGC1050C
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
            this.text_cur_inv_code = new CommonClass.F4ETCR();
            this.text_cur_inv = new System.Windows.Forms.TextBox();
            this.txt_cust_cd = new CommonClass.F4ETCR();
            this.txt_cust_cd_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_prc_line = new System.Windows.Forms.TextBox();
            this.txt_Loc = new System.Windows.Forms.TextBox();
            this.txt_mat_no = new System.Windows.Forms.TextBox();
            this.SSCommand2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sdt_wrk_date_to = new CommonClass.CeriUDate();
            this.sdt_wrk_date_fr = new CommonClass.CeriUDate();
            this.cbo_group = new System.Windows.Forms.ComboBox();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_cur_inv_code
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.text_cur_inv_code;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.text_cur_inv;
            this.text_cur_inv_code.CustomSetting.Add(bControlFiledSetting1);
            this.text_cur_inv_code.CustomSetting.Add(bControlFiledSetting2);
            this.text_cur_inv_code.InputControl = this.text_cur_inv_code;
            this.text_cur_inv_code.Location = new System.Drawing.Point(363, 13);
            this.text_cur_inv_code.Name = "text_cur_inv_code";
            this.text_cur_inv_code.Size = new System.Drawing.Size(38, 22);
            this.text_cur_inv_code.sJoin = "";
            this.text_cur_inv_code.sSqletc = "SELECT CD , CD_SHORT_NAME FROM ZP_CD WHERE CD_MANA_NO = \'C0013\'";
            this.text_cur_inv_code.TabIndex = 503;
            this.text_cur_inv_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_cur_inv
            // 
            this.text_cur_inv.Location = new System.Drawing.Point(403, 13);
            this.text_cur_inv.Name = "text_cur_inv";
            this.text_cur_inv.Size = new System.Drawing.Size(83, 22);
            this.text_cur_inv.TabIndex = 504;
            // 
            // txt_cust_cd
            // 
            bControlFiledSetting3.ColumnID = "CUST_CD";
            bControlFiledSetting3.TargetControl = this.txt_cust_cd;
            bControlFiledSetting4.ColumnID = "CUST_NM";
            bControlFiledSetting4.TargetControl = this.txt_cust_cd_name;
            this.txt_cust_cd.CustomSetting.Add(bControlFiledSetting3);
            this.txt_cust_cd.CustomSetting.Add(bControlFiledSetting4);
            this.txt_cust_cd.InputControl = this.txt_cust_cd;
            this.txt_cust_cd.Location = new System.Drawing.Point(577, 13);
            this.txt_cust_cd.Name = "txt_cust_cd";
            this.txt_cust_cd.Size = new System.Drawing.Size(61, 22);
            this.txt_cust_cd.sJoin = "";
            this.txt_cust_cd.sSqletc = "SELECT CUST_CD,CUST_NM FROM BP_CUST_CD";
            this.txt_cust_cd.TabIndex = 516;
            this.txt_cust_cd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cust_cd_name
            // 
            this.txt_cust_cd_name.Location = new System.Drawing.Point(644, 12);
            this.txt_cust_cd_name.Name = "txt_cust_cd_name";
            this.txt_cust_cd_name.Size = new System.Drawing.Size(148, 22);
            this.txt_cust_cd_name.TabIndex = 517;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_prc_line);
            this.groupBox1.Controls.Add(this.txt_Loc);
            this.groupBox1.Controls.Add(this.txt_mat_no);
            this.groupBox1.Controls.Add(this.SSCommand2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_cust_cd_name);
            this.groupBox1.Controls.Add(this.txt_cust_cd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sdt_wrk_date_to);
            this.groupBox1.Controls.Add(this.sdt_wrk_date_fr);
            this.groupBox1.Controls.Add(this.cbo_group);
            this.groupBox1.Controls.Add(this.cbo_shift);
            this.groupBox1.Controls.Add(this.text_cur_inv);
            this.groupBox1.Controls.Add(this.text_cur_inv_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_prc_line
            // 
            this.txt_prc_line.Location = new System.Drawing.Point(25, 13);
            this.txt_prc_line.Name = "txt_prc_line";
            this.txt_prc_line.Size = new System.Drawing.Size(13, 22);
            this.txt_prc_line.TabIndex = 524;
            this.txt_prc_line.Text = "1";
            this.txt_prc_line.Visible = false;
            // 
            // txt_Loc
            // 
            this.txt_Loc.Location = new System.Drawing.Point(577, 46);
            this.txt_Loc.Name = "txt_Loc";
            this.txt_Loc.Size = new System.Drawing.Size(92, 22);
            this.txt_Loc.TabIndex = 523;
            // 
            // txt_mat_no
            // 
            this.txt_mat_no.Location = new System.Drawing.Point(363, 46);
            this.txt_mat_no.Name = "txt_mat_no";
            this.txt_mat_no.Size = new System.Drawing.Size(123, 22);
            this.txt_mat_no.TabIndex = 522;
            // 
            // SSCommand2
            // 
            this.SSCommand2.Location = new System.Drawing.Point(798, 12);
            this.SSCommand2.Name = "SSCommand2";
            this.SSCommand2.Size = new System.Drawing.Size(121, 23);
            this.SSCommand2.TabIndex = 520;
            this.SSCommand2.Text = "堆码报告";
            this.SSCommand2.UseVisualStyleBackColor = true;
            this.SSCommand2.Click += new System.EventHandler(this.SSCommand2_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(500, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 518;
            this.label8.Text = "垛位";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(500, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 515;
            this.label7.Text = "客户";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(185, 46);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 514;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(84, 46);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FROM.TabIndex = 513;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 512;
            this.label6.Text = "入库时间";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 511;
            this.label5.Text = "作业日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_wrk_date_to
            // 
            this.sdt_wrk_date_to.Location = new System.Drawing.Point(185, 13);
            this.sdt_wrk_date_to.Name = "sdt_wrk_date_to";
            this.sdt_wrk_date_to.RawDate = "";
            this.sdt_wrk_date_to.Size = new System.Drawing.Size(95, 22);
            this.sdt_wrk_date_to.TabIndex = 510;
            // 
            // sdt_wrk_date_fr
            // 
            this.sdt_wrk_date_fr.Location = new System.Drawing.Point(84, 13);
            this.sdt_wrk_date_fr.Name = "sdt_wrk_date_fr";
            this.sdt_wrk_date_fr.RawDate = "";
            this.sdt_wrk_date_fr.Size = new System.Drawing.Size(95, 22);
            this.sdt_wrk_date_fr.TabIndex = 509;
            // 
            // cbo_group
            // 
            this.cbo_group.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_group.FormattingEnabled = true;
            this.cbo_group.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbo_group.Location = new System.Drawing.Point(849, 45);
            this.cbo_group.MaxLength = 1;
            this.cbo_group.Name = "cbo_group";
            this.cbo_group.Size = new System.Drawing.Size(43, 22);
            this.cbo_group.TabIndex = 508;
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbo_shift.Location = new System.Drawing.Point(734, 47);
            this.cbo_shift.MaxLength = 1;
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(50, 22);
            this.cbo_shift.TabIndex = 505;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "堆放仓库";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(675, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "班次";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(790, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(286, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "物料号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 541);
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
            this.ss1.Size = new System.Drawing.Size(1026, 520);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGC1050C
            // 
            this.ClientSize = new System.Drawing.Size(1032, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGC1050C";
            this.Text = "压平机实绩查询界面_FGC1050C";
            this.Load += new System.EventHandler(this.FGA1030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_cur_inv;
        private CommonClass.F4ETCR text_cur_inv_code;
        private System.Windows.Forms.ComboBox cbo_shift;
        private System.Windows.Forms.ComboBox cbo_group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CommonClass.CeriUDate sdt_wrk_date_to;
        private CommonClass.CeriUDate sdt_wrk_date_fr;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.TextBox txt_cust_cd_name;
        private CommonClass.F4ETCR txt_cust_cd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SSCommand2;
        private System.Windows.Forms.TextBox txt_Loc;
        private System.Windows.Forms.TextBox txt_mat_no;
        private System.Windows.Forms.TextBox txt_prc_line;
    }
}
