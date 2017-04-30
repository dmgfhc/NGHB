namespace FG
{
    partial class FGA1060C
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_PRCLINE = new System.Windows.Forms.TextBox();
            this.TXT_PRC = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.COB_SHIFT = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_HL_TMP = new CommonClass.NumBox();
            this.TXT_HL_SPD = new CommonClass.NumBox();
            this.TXT_PRS_OT_PRS_DW_RTO = new CommonClass.NumBox();
            this.TXT_PASS_CNT = new CommonClass.NumBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_LEV_SPLT = new CommonClass.NumBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_RETE_PRS_DW_RTO = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_NO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.label6 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PRCLINE);
            this.groupBox1.Controls.Add(this.TXT_PRC);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_PRCLINE
            // 
            this.TXT_PRCLINE.Location = new System.Drawing.Point(128, 20);
            this.TXT_PRCLINE.MaxLength = 14;
            this.TXT_PRCLINE.Name = "TXT_PRCLINE";
            this.TXT_PRCLINE.Size = new System.Drawing.Size(37, 22);
            this.TXT_PRCLINE.TabIndex = 16;
            this.TXT_PRCLINE.Text = "1";
            this.TXT_PRCLINE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PRC
            // 
            this.TXT_PRC.Location = new System.Drawing.Point(966, 18);
            this.TXT_PRC.MaxLength = 14;
            this.TXT_PRC.Name = "TXT_PRC";
            this.TXT_PRC.Size = new System.Drawing.Size(24, 22);
            this.TXT_PRC.TabIndex = 16;
            this.TXT_PRC.Text = "P";
            this.TXT_PRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PRC.Visible = false;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(766, 18);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(156, 22);
            this.TXT_MAT_NO.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(675, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "查询号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(527, 18);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(104, 25);
            this.SDT_PROD_DATE_TO.TabIndex = 13;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(406, 18);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(101, 25);
            this.SDT_PROD_DATE_FROM.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Tag = "user";
            this.label1.Text = "~";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(301, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "生产时间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "产线别";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.COB_SHIFT);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.TXT_HL_TMP);
            this.groupBox2.Controls.Add(this.TXT_HL_SPD);
            this.groupBox2.Controls.Add(this.TXT_PRS_OT_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.TXT_PASS_CNT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TXT_LEV_SPLT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TXT_RETE_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXT_NO);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 88);
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
            this.COB_SHIFT.Location = new System.Drawing.Point(1068, 53);
            this.COB_SHIFT.Name = "COB_SHIFT";
            this.COB_SHIFT.Size = new System.Drawing.Size(63, 21);
            this.COB_SHIFT.TabIndex = 525;
            this.COB_SHIFT.Visible = false;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(995, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "班次";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // TXT_HL_TMP
            // 
            this.TXT_HL_TMP.Location = new System.Drawing.Point(870, 53);
            this.TXT_HL_TMP.MaxLength = 4;
            this.TXT_HL_TMP.Name = "TXT_HL_TMP";
            this.TXT_HL_TMP.NumValue = 0D;
            this.TXT_HL_TMP.Scale = 0;
            this.TXT_HL_TMP.ShowZero = true;
            this.TXT_HL_TMP.Size = new System.Drawing.Size(107, 22);
            this.TXT_HL_TMP.TabIndex = 23;
            this.TXT_HL_TMP.Text = "0";
            this.TXT_HL_TMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_HL_SPD
            // 
            this.TXT_HL_SPD.Location = new System.Drawing.Point(634, 54);
            this.TXT_HL_SPD.MaxLength = 9;
            this.TXT_HL_SPD.Name = "TXT_HL_SPD";
            this.TXT_HL_SPD.NumValue = 0D;
            this.TXT_HL_SPD.Scale = 4;
            this.TXT_HL_SPD.ShowZero = true;
            this.TXT_HL_SPD.Size = new System.Drawing.Size(105, 22);
            this.TXT_HL_SPD.TabIndex = 26;
            this.TXT_HL_SPD.Text = "0.0000";
            this.TXT_HL_SPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_HL_SPD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_HL_SPD_KeyUp);
            // 
            // TXT_PRS_OT_PRS_DW_RTO
            // 
            this.TXT_PRS_OT_PRS_DW_RTO.Location = new System.Drawing.Point(416, 53);
            this.TXT_PRS_OT_PRS_DW_RTO.MaxLength = 3;
            this.TXT_PRS_OT_PRS_DW_RTO.Name = "TXT_PRS_OT_PRS_DW_RTO";
            this.TXT_PRS_OT_PRS_DW_RTO.NumValue = 0D;
            this.TXT_PRS_OT_PRS_DW_RTO.Scale = 0;
            this.TXT_PRS_OT_PRS_DW_RTO.ShowZero = true;
            this.TXT_PRS_OT_PRS_DW_RTO.Size = new System.Drawing.Size(101, 22);
            this.TXT_PRS_OT_PRS_DW_RTO.TabIndex = 25;
            this.TXT_PRS_OT_PRS_DW_RTO.Text = "0";
            this.TXT_PRS_OT_PRS_DW_RTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_PASS_CNT
            // 
            this.TXT_PASS_CNT.Location = new System.Drawing.Point(870, 21);
            this.TXT_PASS_CNT.MaxLength = 1;
            this.TXT_PASS_CNT.Name = "TXT_PASS_CNT";
            this.TXT_PASS_CNT.NumValue = 0D;
            this.TXT_PASS_CNT.Scale = 0;
            this.TXT_PASS_CNT.ShowZero = true;
            this.TXT_PASS_CNT.Size = new System.Drawing.Size(52, 22);
            this.TXT_PASS_CNT.TabIndex = 28;
            this.TXT_PASS_CNT.Text = "0";
            this.TXT_PASS_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(782, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "压平温度";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LEV_SPLT
            // 
            this.TXT_LEV_SPLT.Location = new System.Drawing.Point(634, 24);
            this.TXT_LEV_SPLT.MaxLength = 3;
            this.TXT_LEV_SPLT.Name = "TXT_LEV_SPLT";
            this.TXT_LEV_SPLT.NumValue = 0D;
            this.TXT_LEV_SPLT.Scale = 0;
            this.TXT_LEV_SPLT.ShowZero = true;
            this.TXT_LEV_SPLT.Size = new System.Drawing.Size(105, 22);
            this.TXT_LEV_SPLT.TabIndex = 27;
            this.TXT_LEV_SPLT.Text = "0";
            this.TXT_LEV_SPLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(541, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "压平速度";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_RETE_PRS_DW_RTO
            // 
            this.TXT_RETE_PRS_DW_RTO.Location = new System.Drawing.Point(416, 21);
            this.TXT_RETE_PRS_DW_RTO.MaxLength = 3;
            this.TXT_RETE_PRS_DW_RTO.Name = "TXT_RETE_PRS_DW_RTO";
            this.TXT_RETE_PRS_DW_RTO.NumValue = 0D;
            this.TXT_RETE_PRS_DW_RTO.Scale = 0;
            this.TXT_RETE_PRS_DW_RTO.ShowZero = true;
            this.TXT_RETE_PRS_DW_RTO.Size = new System.Drawing.Size(101, 22);
            this.TXT_RETE_PRS_DW_RTO.TabIndex = 24;
            this.TXT_RETE_PRS_DW_RTO.Text = "0";
            this.TXT_RETE_PRS_DW_RTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(782, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "压平道次";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(301, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "出口测压下量";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(541, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "倾斜度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(301, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "入口测压下量";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NO
            // 
            this.TXT_NO.Location = new System.Drawing.Point(121, 50);
            this.TXT_NO.MaxLength = 14;
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(60, 22);
            this.TXT_NO.TabIndex = 16;
            this.TXT_NO.Text = "1";
            this.TXT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "机座号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(121, 21);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(144, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 10;
            this.TXT_DISCHARGE_TIME.TextChanged += new System.EventHandler(this.TXT_DISCHARGE_TIME_TextChanged);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(28, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "压平时间";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 144);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1177, 376);
            this.ss1.TabIndex = 2;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // FGA1060C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 520);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FGA1060C";
            this.Text = "压平机实绩查询及修改界面_FGA1060C";
            this.Load += new System.EventHandler(this.FGA1060C_Load);
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
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_NO;
        private System.Windows.Forms.Label label4;
        private CommonClass.MaskedDate TXT_DISCHARGE_TIME;
        private System.Windows.Forms.Label label6;
        private CommonClass.NumBox TXT_HL_TMP;
        private CommonClass.NumBox TXT_HL_SPD;
        private CommonClass.NumBox TXT_PRS_OT_PRS_DW_RTO;
        private CommonClass.NumBox TXT_PASS_CNT;
        private System.Windows.Forms.Label label12;
        private CommonClass.NumBox TXT_LEV_SPLT;
        private System.Windows.Forms.Label label10;
        private CommonClass.NumBox TXT_RETE_PRS_DW_RTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox TXT_PRCLINE;
        private System.Windows.Forms.TextBox TXT_PRC;
        private System.Windows.Forms.ComboBox COB_SHIFT;
    }
}