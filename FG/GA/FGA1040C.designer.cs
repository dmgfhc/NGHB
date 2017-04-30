namespace FG
{
    partial class FGA1040C
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
            this.TXT_PRCLINE = new System.Windows.Forms.TextBox();
            this.TXT_LOC = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.rdo_hcl = new System.Windows.Forms.RadioButton();
            this.rdo_ccl = new System.Windows.Forms.RadioButton();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_PRC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.COB_SHIFT = new System.Windows.Forms.ComboBox();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.TXT_NO = new System.Windows.Forms.TextBox();
            this.TXT_HL_TMP = new CommonClass.NumBox();
            this.TXT_HL_SPD = new CommonClass.NumBox();
            this.TXT_PRS_OT_PRS_DW_RTO = new CommonClass.NumBox();
            this.TXT_PASS_CNT = new CommonClass.NumBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_LEV_SPLT = new CommonClass.NumBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_RETE_PRS_DW_RTO = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PRCLINE);
            this.groupBox1.Controls.Add(this.TXT_LOC);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.rdo_hcl);
            this.groupBox1.Controls.Add(this.rdo_ccl);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_PRC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_PRCLINE
            // 
            this.TXT_PRCLINE.Location = new System.Drawing.Point(86, 13);
            this.TXT_PRCLINE.Name = "TXT_PRCLINE";
            this.TXT_PRCLINE.Size = new System.Drawing.Size(46, 22);
            this.TXT_PRCLINE.TabIndex = 516;
            this.TXT_PRCLINE.Text = "1";
            this.TXT_PRCLINE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_LOC
            // 
            this.TXT_LOC.Location = new System.Drawing.Point(786, 14);
            this.TXT_LOC.Name = "TXT_LOC";
            this.TXT_LOC.Size = new System.Drawing.Size(65, 22);
            this.TXT_LOC.TabIndex = 516;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(564, 13);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(107, 22);
            this.TXT_MAT_NO.TabIndex = 516;
            // 
            // rdo_hcl
            // 
            this.rdo_hcl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_hcl.Location = new System.Drawing.Point(870, 13);
            this.rdo_hcl.Name = "rdo_hcl";
            this.rdo_hcl.Size = new System.Drawing.Size(75, 24);
            this.rdo_hcl.TabIndex = 515;
            this.rdo_hcl.Text = "热矫直";
            this.rdo_hcl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_hcl.UseVisualStyleBackColor = true;
            this.rdo_hcl.Click += new System.EventHandler(this.rdo_hcl_Click);
            // 
            // rdo_ccl
            // 
            this.rdo_ccl.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_ccl.Location = new System.Drawing.Point(954, 13);
            this.rdo_ccl.Name = "rdo_ccl";
            this.rdo_ccl.Size = new System.Drawing.Size(66, 24);
            this.rdo_ccl.TabIndex = 514;
            this.rdo_ccl.Text = "返矫";
            this.rdo_ccl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_ccl.UseVisualStyleBackColor = true;
            this.rdo_ccl.Click += new System.EventHandler(this.rdo_ccl_Click);
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(364, 12);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(104, 25);
            this.SDT_PROD_DATE_TO.TabIndex = 512;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(243, 12);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(101, 25);
            this.SDT_PROD_DATE_FROM.TabIndex = 513;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 511;
            this.label3.Tag = "user";
            this.label3.Text = "~";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(138, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 510;
            this.label10.Text = "生产时间";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "产线别";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(717, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "垛位号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PRC
            // 
            this.TXT_PRC.Location = new System.Drawing.Point(474, 21);
            this.TXT_PRC.Name = "TXT_PRC";
            this.TXT_PRC.Size = new System.Drawing.Size(14, 22);
            this.TXT_PRC.TabIndex = 199;
            this.TXT_PRC.Visible = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(479, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "查询号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.COB_SHIFT);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.TXT_NO);
            this.groupBox2.Controls.Add(this.TXT_HL_TMP);
            this.groupBox2.Controls.Add(this.TXT_HL_SPD);
            this.groupBox2.Controls.Add(this.TXT_PRS_OT_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.TXT_PASS_CNT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXT_LEV_SPLT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_RETE_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // COB_SHIFT
            // 
            this.COB_SHIFT.FormattingEnabled = true;
            this.COB_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COB_SHIFT.Location = new System.Drawing.Point(870, 88);
            this.COB_SHIFT.Name = "COB_SHIFT";
            this.COB_SHIFT.Size = new System.Drawing.Size(63, 21);
            this.COB_SHIFT.TabIndex = 524;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(86, 56);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(141, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 523;
            // 
            // TXT_NO
            // 
            this.TXT_NO.Location = new System.Drawing.Point(90, 89);
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(46, 22);
            this.TXT_NO.TabIndex = 516;
            this.TXT_NO.Text = "1";
            this.TXT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_HL_TMP
            // 
            this.TXT_HL_TMP.Location = new System.Drawing.Point(716, 88);
            this.TXT_HL_TMP.MaxLength = 4;
            this.TXT_HL_TMP.Name = "TXT_HL_TMP";
            this.TXT_HL_TMP.NumValue = 0D;
            this.TXT_HL_TMP.Scale = 0;
            this.TXT_HL_TMP.ShowZero = true;
            this.TXT_HL_TMP.Size = new System.Drawing.Size(64, 22);
            this.TXT_HL_TMP.TabIndex = 517;
            this.TXT_HL_TMP.Text = "0";
            this.TXT_HL_TMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_HL_SPD
            // 
            this.TXT_HL_SPD.Location = new System.Drawing.Point(535, 88);
            this.TXT_HL_SPD.MaxLength = 9;
            this.TXT_HL_SPD.Name = "TXT_HL_SPD";
            this.TXT_HL_SPD.NumValue = 0D;
            this.TXT_HL_SPD.Scale = 4;
            this.TXT_HL_SPD.ShowZero = true;
            this.TXT_HL_SPD.Size = new System.Drawing.Size(72, 22);
            this.TXT_HL_SPD.TabIndex = 520;
            this.TXT_HL_SPD.Text = "0.0000";
            this.TXT_HL_SPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_HL_SPD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_HL_SPD_KeyUp);
            // 
            // TXT_PRS_OT_PRS_DW_RTO
            // 
            this.TXT_PRS_OT_PRS_DW_RTO.Location = new System.Drawing.Point(352, 88);
            this.TXT_PRS_OT_PRS_DW_RTO.MaxLength = 3;
            this.TXT_PRS_OT_PRS_DW_RTO.Name = "TXT_PRS_OT_PRS_DW_RTO";
            this.TXT_PRS_OT_PRS_DW_RTO.NumValue = 0D;
            this.TXT_PRS_OT_PRS_DW_RTO.Scale = 0;
            this.TXT_PRS_OT_PRS_DW_RTO.ShowZero = true;
            this.TXT_PRS_OT_PRS_DW_RTO.Size = new System.Drawing.Size(77, 22);
            this.TXT_PRS_OT_PRS_DW_RTO.TabIndex = 519;
            this.TXT_PRS_OT_PRS_DW_RTO.Text = "0";
            this.TXT_PRS_OT_PRS_DW_RTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_PASS_CNT
            // 
            this.TXT_PASS_CNT.Location = new System.Drawing.Point(716, 56);
            this.TXT_PASS_CNT.MaxLength = 1;
            this.TXT_PASS_CNT.Name = "TXT_PASS_CNT";
            this.TXT_PASS_CNT.NumValue = 0D;
            this.TXT_PASS_CNT.Scale = 0;
            this.TXT_PASS_CNT.ShowZero = true;
            this.TXT_PASS_CNT.Size = new System.Drawing.Size(64, 22);
            this.TXT_PASS_CNT.TabIndex = 522;
            this.TXT_PASS_CNT.Text = "0";
            this.TXT_PASS_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(628, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 511;
            this.label5.Text = "矫直温度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LEV_SPLT
            // 
            this.TXT_LEV_SPLT.Location = new System.Drawing.Point(535, 58);
            this.TXT_LEV_SPLT.MaxLength = 3;
            this.TXT_LEV_SPLT.Name = "TXT_LEV_SPLT";
            this.TXT_LEV_SPLT.NumValue = 0D;
            this.TXT_LEV_SPLT.Scale = 0;
            this.TXT_LEV_SPLT.ShowZero = true;
            this.TXT_LEV_SPLT.Size = new System.Drawing.Size(72, 22);
            this.TXT_LEV_SPLT.TabIndex = 521;
            this.TXT_LEV_SPLT.Text = "0";
            this.TXT_LEV_SPLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(442, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 513;
            this.label6.Text = "矫直速度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_RETE_PRS_DW_RTO
            // 
            this.TXT_RETE_PRS_DW_RTO.Location = new System.Drawing.Point(352, 56);
            this.TXT_RETE_PRS_DW_RTO.MaxLength = 3;
            this.TXT_RETE_PRS_DW_RTO.Name = "TXT_RETE_PRS_DW_RTO";
            this.TXT_RETE_PRS_DW_RTO.NumValue = 0D;
            this.TXT_RETE_PRS_DW_RTO.Scale = 0;
            this.TXT_RETE_PRS_DW_RTO.ShowZero = true;
            this.TXT_RETE_PRS_DW_RTO.Size = new System.Drawing.Size(77, 22);
            this.TXT_RETE_PRS_DW_RTO.TabIndex = 518;
            this.TXT_RETE_PRS_DW_RTO.Text = "0";
            this.TXT_RETE_PRS_DW_RTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(628, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 512;
            this.label11.Text = "矫直道次";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(810, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 22);
            this.label14.TabIndex = 82;
            this.label14.Text = "班次";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(237, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 514;
            this.label8.Text = "出口测压下量";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(442, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 516;
            this.label9.Text = "倾斜度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(237, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 515;
            this.label13.Text = "入口测压下量";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(12, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 386;
            this.label12.Text = "矫直时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 473;
            this.label7.Text = "机座号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 507);
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
            this.ss1.Size = new System.Drawing.Size(1026, 486);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGA1040C
            // 
            this.ClientSize = new System.Drawing.Size(1032, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGA1040C";
            this.Text = "矫直实绩查询及修改界面_FGA1040C";
            this.Load += new System.EventHandler(this.FGA1040C_Load);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_PRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_hcl;
        private System.Windows.Forms.RadioButton rdo_ccl;
        private CommonClass.NumBox TXT_HL_TMP;
        private CommonClass.NumBox TXT_HL_SPD;
        private CommonClass.NumBox TXT_PRS_OT_PRS_DW_RTO;
        private CommonClass.NumBox TXT_PASS_CNT;
        private System.Windows.Forms.Label label5;
        private CommonClass.NumBox TXT_LEV_SPLT;
        private System.Windows.Forms.Label label6;
        private CommonClass.NumBox TXT_RETE_PRS_DW_RTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_PRCLINE;
        private System.Windows.Forms.TextBox TXT_LOC;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.TextBox TXT_NO;
        private CommonClass.MaskedDate TXT_DISCHARGE_TIME;
        private System.Windows.Forms.ComboBox COB_SHIFT;
    }
}
