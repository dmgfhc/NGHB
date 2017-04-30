namespace CG
{
    partial class CGA2070C
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
            this.txt_act_stlgrd = new CommonClass.F4ETCR();
            this.txt_act_stlgrd_dec = new System.Windows.Forms.TextBox();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DoWgt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MoWgt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DoCnt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MoCnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt_out_plt_date = new CommonClass.CeriUDate();
            this.sdt_in_plt_date = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_act_stlgrd
            // 
            bControlFiledSetting1.ColumnID = "STLGRD";
            bControlFiledSetting1.TargetControl = this.txt_act_stlgrd;
            bControlFiledSetting2.ColumnID = "STEEL_GRD_DETAIL";
            bControlFiledSetting2.TargetControl = this.txt_act_stlgrd_dec;
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_act_stlgrd.InputControl = this.txt_act_stlgrd;
            this.txt_act_stlgrd.Location = new System.Drawing.Point(104, 49);
            this.txt_act_stlgrd.Name = "txt_act_stlgrd";
            this.txt_act_stlgrd.Size = new System.Drawing.Size(108, 22);
            this.txt_act_stlgrd.sJoin = "";
            this.txt_act_stlgrd.sSqletc = "SELECT  STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM NISCO.QP_NISCO_CHMC  WHERE STLG" +
                "RD LIKE \'%\' AND NVL(STEEL_GRD_DETAIL,\'%\') LIKE \'%\'   ORDER  BY  STLGRD  ASC ";
            this.txt_act_stlgrd.TabIndex = 572;
            this.txt_act_stlgrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_act_stlgrd_dec
            // 
            this.txt_act_stlgrd_dec.Enabled = false;
            this.txt_act_stlgrd_dec.Location = new System.Drawing.Point(218, 49);
            this.txt_act_stlgrd_dec.Name = "txt_act_stlgrd_dec";
            this.txt_act_stlgrd_dec.Size = new System.Drawing.Size(112, 22);
            this.txt_act_stlgrd_dec.TabIndex = 573;
            // 
            // txt_plt
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_plt;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_plt_name;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting3);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting4);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(421, 13);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(35, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
                "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
                "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_plt.TabIndex = 576;
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt_name
            // 
            this.txt_plt_name.Enabled = false;
            this.txt_plt_name.Location = new System.Drawing.Point(458, 13);
            this.txt_plt_name.Name = "txt_plt_name";
            this.txt_plt_name.Size = new System.Drawing.Size(98, 22);
            this.txt_plt_name.TabIndex = 577;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DoWgt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_MoWgt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_DoCnt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_MoCnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_plt_name);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd_dec);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd);
            this.groupBox1.Controls.Add(this.sdt_out_plt_date);
            this.groupBox1.Controls.Add(this.sdt_in_plt_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(905, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 589;
            this.label10.Text = "吨";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DoWgt
            // 
            this.txt_DoWgt.Location = new System.Drawing.Point(824, 49);
            this.txt_DoWgt.MaxLength = 11;
            this.txt_DoWgt.Name = "txt_DoWgt";
            this.txt_DoWgt.Size = new System.Drawing.Size(75, 22);
            this.txt_DoWgt.TabIndex = 588;
            this.txt_DoWgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(905, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 587;
            this.label9.Text = "吨";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MoWgt
            // 
            this.txt_MoWgt.Location = new System.Drawing.Point(824, 13);
            this.txt_MoWgt.MaxLength = 11;
            this.txt_MoWgt.Name = "txt_MoWgt";
            this.txt_MoWgt.Size = new System.Drawing.Size(75, 22);
            this.txt_MoWgt.TabIndex = 586;
            this.txt_MoWgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(776, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 585;
            this.label8.Text = "块";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(776, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 584;
            this.label7.Text = "块";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DoCnt
            // 
            this.txt_DoCnt.Location = new System.Drawing.Point(716, 49);
            this.txt_DoCnt.MaxLength = 11;
            this.txt_DoCnt.Name = "txt_DoCnt";
            this.txt_DoCnt.Size = new System.Drawing.Size(54, 22);
            this.txt_DoCnt.TabIndex = 583;
            this.txt_DoCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(629, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 582;
            this.label6.Text = "子板坯切割";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MoCnt
            // 
            this.txt_MoCnt.Location = new System.Drawing.Point(716, 13);
            this.txt_MoCnt.MaxLength = 11;
            this.txt_MoCnt.Name = "txt_MoCnt";
            this.txt_MoCnt.Size = new System.Drawing.Size(54, 22);
            this.txt_MoCnt.TabIndex = 581;
            this.txt_MoCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(629, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 580;
            this.label2.Text = "母板坯切割";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(421, 49);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(46, 22);
            this.CBO_SHIFT.TabIndex = 579;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(346, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 578;
            this.label1.Text = "班次";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(346, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 575;
            this.label5.Text = "生产工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 574;
            this.label3.Text = "钢种";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_out_plt_date
            // 
            this.sdt_out_plt_date.Font = new System.Drawing.Font("宋体", 11F);
            this.sdt_out_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_out_plt_date.Location = new System.Drawing.Point(218, 13);
            this.sdt_out_plt_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdt_out_plt_date.Name = "sdt_out_plt_date";
            this.sdt_out_plt_date.RawDate = "";
            this.sdt_out_plt_date.Size = new System.Drawing.Size(112, 24);
            this.sdt_out_plt_date.TabIndex = 521;
            this.sdt_out_plt_date.Tag = "结束时间";
            // 
            // sdt_in_plt_date
            // 
            this.sdt_in_plt_date.Font = new System.Drawing.Font("宋体", 11F);
            this.sdt_in_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_in_plt_date.Location = new System.Drawing.Point(104, 13);
            this.sdt_in_plt_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdt_in_plt_date.Name = "sdt_in_plt_date";
            this.sdt_in_plt_date.RawDate = "";
            this.sdt_in_plt_date.Size = new System.Drawing.Size(108, 24);
            this.sdt_in_plt_date.TabIndex = 520;
            this.sdt_in_plt_date.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 519;
            this.label4.Text = "板坯切割日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 86);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 536);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2070C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2070C";
            this.Text = "板坯切割实绩查询界面_CGA2070C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        public CommonClass.CeriUDate sdt_out_plt_date;
        public CommonClass.CeriUDate sdt_in_plt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_act_stlgrd_dec;
        public CommonClass.F4ETCR txt_act_stlgrd;
        public System.Windows.Forms.TextBox txt_plt_name;
        public CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DoWgt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MoWgt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DoCnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MoCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label1;
    }
}
