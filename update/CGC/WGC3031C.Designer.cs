namespace CG
{
    partial class WGC3031C
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdReport = new System.Windows.Forms.Button();
            this.CmdSEND = new System.Windows.Forms.Button();
            this.txt_HTM_METH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_OutOrder = new System.Windows.Forms.TextBox();
            this.TXT_CUT_PLT = new System.Windows.Forms.TextBox();
            this.txt_smp_sent_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end_date = new CommonClass.CeriUDate();
            this.txt_smp_no = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_smp_fl = new System.Windows.Forms.CheckBox();
            this.txt_check = new System.Windows.Forms.CheckBox();
            this.txt_DH_FL = new System.Windows.Forms.CheckBox();
            this.dtp_prod_to = new CommonClass.CeriUDate();
            this.dtp_prod_fr = new CommonClass.CeriUDate();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PLT_NAME = new System.Windows.Forms.TextBox();
            this.txt_plt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmdReport);
            this.groupBox1.Controls.Add(this.CmdSEND);
            this.groupBox1.Controls.Add(this.txt_HTM_METH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_OutOrder);
            this.groupBox1.Controls.Add(this.TXT_CUT_PLT);
            this.groupBox1.Controls.Add(this.txt_smp_sent_no);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_end_date);
            this.groupBox1.Controls.Add(this.txt_smp_no);
            this.groupBox1.Controls.Add(this.txt_line);
            this.groupBox1.Controls.Add(this.txt_smp_fl);
            this.groupBox1.Controls.Add(this.txt_check);
            this.groupBox1.Controls.Add(this.txt_DH_FL);
            this.groupBox1.Controls.Add(this.dtp_prod_to);
            this.groupBox1.Controls.Add(this.dtp_prod_fr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PLT_NAME);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(524, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "每炉成分委托数量系统自动管控，请勿再人工勾选";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdReport
            // 
            this.cmdReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReport.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdReport.Location = new System.Drawing.Point(875, 34);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.Size = new System.Drawing.Size(107, 27);
            this.cmdReport.TabIndex = 31;
            this.cmdReport.Text = "打印委托单";
            this.cmdReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReport.UseVisualStyleBackColor = true;
            this.cmdReport.Visible = false;
            this.cmdReport.Click += new System.EventHandler(this.cmdReport_Click);
            // 
            // CmdSEND
            // 
            this.CmdSEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSEND.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmdSEND.Location = new System.Drawing.Point(762, 34);
            this.CmdSEND.Name = "CmdSEND";
            this.CmdSEND.Size = new System.Drawing.Size(103, 27);
            this.CmdSEND.TabIndex = 30;
            this.CmdSEND.Tag = "user";
            this.CmdSEND.Text = "发送委托信息";
            this.CmdSEND.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdSEND.UseVisualStyleBackColor = true;
            this.CmdSEND.Visible = false;
            this.CmdSEND.Click += new System.EventHandler(this.CmdSEND_Click);
            // 
            // txt_HTM_METH
            // 
            this.txt_HTM_METH.FormattingEnabled = true;
            this.txt_HTM_METH.Items.AddRange(new object[] {
            "",
            "N",
            "T",
            "Q"});
            this.txt_HTM_METH.Location = new System.Drawing.Point(850, 12);
            this.txt_HTM_METH.Name = "txt_HTM_METH";
            this.txt_HTM_METH.Size = new System.Drawing.Size(73, 21);
            this.txt_HTM_METH.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(762, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "热处理方式";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_OutOrder
            // 
            this.Txt_OutOrder.Location = new System.Drawing.Point(964, 11);
            this.Txt_OutOrder.Name = "Txt_OutOrder";
            this.Txt_OutOrder.Size = new System.Drawing.Size(19, 22);
            this.Txt_OutOrder.TabIndex = 27;
            this.Txt_OutOrder.Text = "0";
            this.Txt_OutOrder.Visible = false;
            // 
            // TXT_CUT_PLT
            // 
            this.TXT_CUT_PLT.Location = new System.Drawing.Point(939, 11);
            this.TXT_CUT_PLT.Name = "TXT_CUT_PLT";
            this.TXT_CUT_PLT.Size = new System.Drawing.Size(19, 22);
            this.TXT_CUT_PLT.TabIndex = 27;
            this.TXT_CUT_PLT.Visible = false;
            // 
            // txt_smp_sent_no
            // 
            this.txt_smp_sent_no.Location = new System.Drawing.Point(614, 36);
            this.txt_smp_sent_no.Name = "txt_smp_sent_no";
            this.txt_smp_sent_no.Size = new System.Drawing.Size(114, 22);
            this.txt_smp_sent_no.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(524, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "委托单号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.Location = new System.Drawing.Point(614, 13);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.RawDate = "";
            this.dtp_end_date.Size = new System.Drawing.Size(94, 21);
            this.dtp_end_date.TabIndex = 24;
            // 
            // txt_smp_no
            // 
            this.txt_smp_no.Location = new System.Drawing.Point(375, 36);
            this.txt_smp_no.MaxLength = 14;
            this.txt_smp_no.Name = "txt_smp_no";
            this.txt_smp_no.Size = new System.Drawing.Size(109, 22);
            this.txt_smp_no.TabIndex = 23;
            // 
            // txt_line
            // 
            this.txt_line.Location = new System.Drawing.Point(227, 36);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(39, 22);
            this.txt_line.TabIndex = 22;
            // 
            // txt_smp_fl
            // 
            this.txt_smp_fl.AutoSize = true;
            this.txt_smp_fl.Location = new System.Drawing.Point(305, 15);
            this.txt_smp_fl.Name = "txt_smp_fl";
            this.txt_smp_fl.Size = new System.Drawing.Size(48, 16);
            this.txt_smp_fl.TabIndex = 21;
            this.txt_smp_fl.Text = "复样";
            this.txt_smp_fl.UseVisualStyleBackColor = true;
            this.txt_smp_fl.Click += new System.EventHandler(this.txt_smp_fl_Click);
            // 
            // txt_check
            // 
            this.txt_check.AutoSize = true;
            this.txt_check.Location = new System.Drawing.Point(375, 15);
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(84, 16);
            this.txt_check.TabIndex = 20;
            this.txt_check.Text = "已处理对象";
            this.txt_check.UseVisualStyleBackColor = true;
            this.txt_check.Click += new System.EventHandler(this.txt_check_Click);
            // 
            // txt_DH_FL
            // 
            this.txt_DH_FL.AutoSize = true;
            this.txt_DH_FL.Location = new System.Drawing.Point(112, 39);
            this.txt_DH_FL.Name = "txt_DH_FL";
            this.txt_DH_FL.Size = new System.Drawing.Size(60, 16);
            this.txt_DH_FL.TabIndex = 19;
            this.txt_DH_FL.Text = "热处理";
            this.txt_DH_FL.UseVisualStyleBackColor = true;
            // 
            // dtp_prod_to
            // 
            this.dtp_prod_to.Location = new System.Drawing.Point(172, 13);
            this.dtp_prod_to.Name = "dtp_prod_to";
            this.dtp_prod_to.RawDate = "";
            this.dtp_prod_to.Size = new System.Drawing.Size(94, 21);
            this.dtp_prod_to.TabIndex = 18;
            // 
            // dtp_prod_fr
            // 
            this.dtp_prod_fr.Location = new System.Drawing.Point(77, 13);
            this.dtp_prod_fr.Name = "dtp_prod_fr";
            this.dtp_prod_fr.RawDate = "";
            this.dtp_prod_fr.Size = new System.Drawing.Size(94, 21);
            this.dtp_prod_fr.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(177, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "产线";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(305, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "试样号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(524, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "要求完成时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PLT_NAME
            // 
            this.PLT_NAME.Location = new System.Drawing.Point(472, 13);
            this.PLT_NAME.Name = "PLT_NAME";
            this.PLT_NAME.Size = new System.Drawing.Size(111, 22);
            this.PLT_NAME.TabIndex = 12;
            this.PLT_NAME.Visible = false;
            this.PLT_NAME.TextChanged += new System.EventHandler(this.txt_plt_TextChanged);
            // 
            // txt_plt
            // 
            this.txt_plt.Location = new System.Drawing.Point(77, 36);
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(32, 22);
            this.txt_plt.TabIndex = 12;
            this.txt_plt.TextChanged += new System.EventHandler(this.txt_plt_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Location = new System.Drawing.Point(5, 61);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1013, 548);
            this.ss1.TabIndex = 1;
            this.ss1.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.ss1_ButtonClicked);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGC3031C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC3031C";
            this.Text = "钢板取样委托管理画面-PWHT_WGC3031C";
            this.Load += new System.EventHandler(this.WGC3031C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_plt;
        private System.Windows.Forms.Label label1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_HTM_METH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_CUT_PLT;
        private System.Windows.Forms.TextBox txt_smp_sent_no;
        private System.Windows.Forms.Label label6;
        private CommonClass.CeriUDate dtp_end_date;
        private System.Windows.Forms.TextBox txt_smp_no;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.CheckBox txt_smp_fl;
        private System.Windows.Forms.CheckBox txt_check;
        private System.Windows.Forms.CheckBox txt_DH_FL;
        private CommonClass.CeriUDate dtp_prod_to;
        private CommonClass.CeriUDate dtp_prod_fr;
        private System.Windows.Forms.Button cmdReport;
        private System.Windows.Forms.Button CmdSEND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_OutOrder;
        private System.Windows.Forms.TextBox PLT_NAME;

    }
}
