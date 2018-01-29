namespace CK
{
    partial class CKG2040C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CKG2040C));
            CommonClass.BControlFiledSetting bControlFiledSetting3 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting4 = new CommonClass.BControlFiledSetting();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_dec = new System.Windows.Forms.TextBox();
            this.txt_InPlt = new CommonClass.F4ETCR();
            this.txt_INplt_dec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SSPpdt = new System.Windows.Forms.Button();
            this.chk_all_ord = new System.Windows.Forms.CheckBox();
            this.txt_all_ord = new System.Windows.Forms.TextBox();
            this.txt_DATE = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_HeatNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opt_bz2 = new System.Windows.Forms.CheckBox();
            this.opt_bz1 = new System.Windows.Forms.CheckBox();
            this.TXT_WGT = new System.Windows.Forms.TextBox();
            this.TXT_CNT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.TextBox();
            this.cmd_mill_exc = new System.Windows.Forms.Button();
            this.txt_OutSeq = new System.Windows.Forms.TextBox();
            this.txt_InSeq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LotNo = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_plt
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_plt;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_plt_dec;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting1);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(354, 18);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(46, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = resources.GetString("txt_plt.sSqletc");
            this.txt_plt.TabIndex = 223;
            // 
            // txt_plt_dec
            // 
            this.txt_plt_dec.Location = new System.Drawing.Point(406, 18);
            this.txt_plt_dec.MaxLength = 11;
            this.txt_plt_dec.Name = "txt_plt_dec";
            this.txt_plt_dec.Size = new System.Drawing.Size(87, 22);
            this.txt_plt_dec.TabIndex = 222;
            // 
            // txt_InPlt
            // 
            bControlFiledSetting3.ColumnID = "CD";
            bControlFiledSetting3.TargetControl = this.txt_InPlt;
            bControlFiledSetting4.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.txt_INplt_dec;
            this.txt_InPlt.CustomSetting.Add(bControlFiledSetting3);
            this.txt_InPlt.CustomSetting.Add(bControlFiledSetting4);
            this.txt_InPlt.InputControl = this.txt_InPlt;
            this.txt_InPlt.Location = new System.Drawing.Point(354, 18);
            this.txt_InPlt.MaxLength = 2;
            this.txt_InPlt.Name = "txt_InPlt";
            this.txt_InPlt.Size = new System.Drawing.Size(46, 22);
            this.txt_InPlt.sJoin = "";
            this.txt_InPlt.sSqletc = resources.GetString("txt_InPlt.sSqletc");
            this.txt_InPlt.TabIndex = 757;
            this.txt_InPlt.TextChanged += new System.EventHandler(this.txt_InPlt_TextChanged);
            // 
            // txt_INplt_dec
            // 
            this.txt_INplt_dec.Location = new System.Drawing.Point(406, 18);
            this.txt_INplt_dec.MaxLength = 11;
            this.txt_INplt_dec.Name = "txt_INplt_dec";
            this.txt_INplt_dec.Size = new System.Drawing.Size(87, 22);
            this.txt_INplt_dec.TabIndex = 756;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SSPpdt);
            this.groupBox1.Controls.Add(this.chk_all_ord);
            this.groupBox1.Controls.Add(this.txt_all_ord);
            this.groupBox1.Controls.Add(this.txt_DATE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.txt_plt_dec);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_HeatNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SSPpdt
            // 
            this.SSPpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SSPpdt.FlatAppearance.BorderSize = 0;
            this.SSPpdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSPpdt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPpdt.ForeColor = System.Drawing.Color.Blue;
            this.SSPpdt.Location = new System.Drawing.Point(865, 14);
            this.SSPpdt.Name = "SSPpdt";
            this.SSPpdt.Size = new System.Drawing.Size(106, 24);
            this.SSPpdt.TabIndex = 755;
            this.SSPpdt.Text = "一坯多订单";
            this.SSPpdt.UseVisualStyleBackColor = false;
            // 
            // chk_all_ord
            // 
            this.chk_all_ord.AutoSize = true;
            this.chk_all_ord.Location = new System.Drawing.Point(752, 18);
            this.chk_all_ord.Name = "chk_all_ord";
            this.chk_all_ord.Size = new System.Drawing.Size(91, 17);
            this.chk_all_ord.TabIndex = 228;
            this.chk_all_ord.Text = "多订单查询";
            this.chk_all_ord.UseVisualStyleBackColor = true;
            // 
            // txt_all_ord
            // 
            this.txt_all_ord.Location = new System.Drawing.Point(689, 18);
            this.txt_all_ord.Name = "txt_all_ord";
            this.txt_all_ord.Size = new System.Drawing.Size(37, 22);
            this.txt_all_ord.TabIndex = 227;
            this.txt_all_ord.Text = "N";
            this.txt_all_ord.Visible = false;
            // 
            // txt_DATE
            // 
            this.txt_DATE.Location = new System.Drawing.Point(585, 18);
            this.txt_DATE.Name = "txt_DATE";
            this.txt_DATE.RawDate = "";
            this.txt_DATE.Size = new System.Drawing.Size(97, 21);
            this.txt_DATE.TabIndex = 226;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(499, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 225;
            this.label2.Text = "批号日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 224;
            this.label1.Text = "板坯来源";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(32, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 22);
            this.label8.TabIndex = 221;
            this.label8.Text = "炉号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_HeatNo
            // 
            this.txt_HeatNo.Location = new System.Drawing.Point(150, 18);
            this.txt_HeatNo.MaxLength = 10;
            this.txt_HeatNo.Name = "txt_HeatNo";
            this.txt_HeatNo.Size = new System.Drawing.Size(112, 22);
            this.txt_HeatNo.TabIndex = 220;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt_bz2);
            this.groupBox2.Controls.Add(this.opt_bz1);
            this.groupBox2.Controls.Add(this.TXT_WGT);
            this.groupBox2.Controls.Add(this.TXT_CNT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Temp);
            this.groupBox2.Controls.Add(this.cmd_mill_exc);
            this.groupBox2.Controls.Add(this.txt_OutSeq);
            this.groupBox2.Controls.Add(this.txt_InSeq);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_InPlt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_INplt_dec);
            this.groupBox2.Controls.Add(this.txt_LotNo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // opt_bz2
            // 
            this.opt_bz2.AutoSize = true;
            this.opt_bz2.Location = new System.Drawing.Point(477, 57);
            this.opt_bz2.Name = "opt_bz2";
            this.opt_bz2.Size = new System.Drawing.Size(78, 17);
            this.opt_bz2.TabIndex = 768;
            this.opt_bz2.Text = "来料加工";
            this.opt_bz2.UseVisualStyleBackColor = true;
            this.opt_bz2.Visible = false;
            // 
            // opt_bz1
            // 
            this.opt_bz1.AutoSize = true;
            this.opt_bz1.Location = new System.Drawing.Point(406, 57);
            this.opt_bz1.Name = "opt_bz1";
            this.opt_bz1.Size = new System.Drawing.Size(65, 17);
            this.opt_bz1.TabIndex = 767;
            this.opt_bz1.Text = "外购坯";
            this.opt_bz1.UseVisualStyleBackColor = true;
            this.opt_bz1.Visible = false;
            // 
            // TXT_WGT
            // 
            this.TXT_WGT.Location = new System.Drawing.Point(194, 52);
            this.TXT_WGT.MaxLength = 11;
            this.TXT_WGT.Name = "TXT_WGT";
            this.TXT_WGT.Size = new System.Drawing.Size(68, 22);
            this.TXT_WGT.TabIndex = 766;
            // 
            // TXT_CNT
            // 
            this.TXT_CNT.Location = new System.Drawing.Point(150, 52);
            this.TXT_CNT.MaxLength = 5;
            this.TXT_CNT.Name = "TXT_CNT";
            this.TXT_CNT.Size = new System.Drawing.Size(38, 22);
            this.TXT_CNT.TabIndex = 765;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(32, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 764;
            this.label6.Text = "件数/重量（吨）";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(862, 18);
            this.Temp.MaxLength = 14;
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(100, 22);
            this.Temp.TabIndex = 763;
            // 
            // cmd_mill_exc
            // 
            this.cmd_mill_exc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_mill_exc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_mill_exc.ForeColor = System.Drawing.Color.Red;
            this.cmd_mill_exc.Location = new System.Drawing.Point(752, 18);
            this.cmd_mill_exc.Name = "cmd_mill_exc";
            this.cmd_mill_exc.Size = new System.Drawing.Size(106, 32);
            this.cmd_mill_exc.TabIndex = 762;
            this.cmd_mill_exc.Text = "轧制单导出";
            this.cmd_mill_exc.UseVisualStyleBackColor = true;
            this.cmd_mill_exc.Click += new System.EventHandler(this.cmd_mill_exc_Click);
            // 
            // txt_OutSeq
            // 
            this.txt_OutSeq.Location = new System.Drawing.Point(635, 18);
            this.txt_OutSeq.MaxLength = 14;
            this.txt_OutSeq.Name = "txt_OutSeq";
            this.txt_OutSeq.Size = new System.Drawing.Size(43, 22);
            this.txt_OutSeq.TabIndex = 761;
            // 
            // txt_InSeq
            // 
            this.txt_InSeq.Location = new System.Drawing.Point(586, 18);
            this.txt_InSeq.MaxLength = 4;
            this.txt_InSeq.Name = "txt_InSeq";
            this.txt_InSeq.Size = new System.Drawing.Size(43, 22);
            this.txt_InSeq.TabIndex = 760;
            this.txt_InSeq.TextChanged += new System.EventHandler(this.txt_InSeq_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(499, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 759;
            this.label5.Text = "当月顺序";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(268, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 758;
            this.label4.Text = "板坯来源";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(32, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 223;
            this.label3.Text = "轧制批号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_LotNo
            // 
            this.txt_LotNo.Location = new System.Drawing.Point(150, 18);
            this.txt_LotNo.MaxLength = 14;
            this.txt_LotNo.Name = "txt_LotNo";
            this.txt_LotNo.Size = new System.Drawing.Size(112, 22);
            this.txt_LotNo.TabIndex = 222;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 140);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1009, 482);
            this.ss1.TabIndex = 2;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CKG2040C
            // 
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CKG2040C";
            this.Text = "批号查询及修改_CKG2040C";
            this.Load += new System.EventHandler(this.CKG2040C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_HeatNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.TextBox txt_plt_dec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_all_ord;
        private System.Windows.Forms.TextBox txt_all_ord;
        private CommonClass.CeriUDate txt_DATE;
        private System.Windows.Forms.Button SSPpdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LotNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.Button cmd_mill_exc;
        private System.Windows.Forms.TextBox txt_OutSeq;
        private System.Windows.Forms.TextBox txt_InSeq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CommonClass.F4ETCR txt_InPlt;
        private System.Windows.Forms.TextBox txt_INplt_dec;
        private System.Windows.Forms.TextBox TXT_WGT;
        private System.Windows.Forms.TextBox TXT_CNT;
        private System.Windows.Forms.CheckBox opt_bz2;
        private System.Windows.Forms.CheckBox opt_bz1;
    }
}
