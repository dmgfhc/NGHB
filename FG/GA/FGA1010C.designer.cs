namespace FG
{
    partial class FGA1010C
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
            this.f4ETCR_PLT = new CommonClass.F4ETCR();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_GROUP = new System.Windows.Forms.TextBox();
            this.txt_SB = new CommonClass.F4ETCN();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.TXT_SHIFT = new System.Windows.Forms.TextBox();
            this.SDT_SCH_DATE = new CommonClass.CeriUDate();
            this.OPT_SLAB = new System.Windows.Forms.RadioButton();
            this.OPT_Mat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.txt_PrcLine = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_RsltSb = new CommonClass.F4ETCN();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.TXT_EMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SHOT_BLAST_CLEA = new CommonClass.NumBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_SPEED = new CommonClass.NumBox();
            this.TXT_SHOT_BLAST_AREA = new CommonClass.NumBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // f4ETCR_PLT
            // 
            bControlFiledSetting1.ColumnID = "T.CD";
            bControlFiledSetting1.TargetControl = this.f4ETCR_PLT;
            bControlFiledSetting2.ColumnID = "T.CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.TXT_PLT;
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting1);
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting2);
            this.f4ETCR_PLT.InputControl = this.f4ETCR_PLT;
            this.f4ETCR_PLT.Location = new System.Drawing.Point(62, 18);
            this.f4ETCR_PLT.Name = "f4ETCR_PLT";
            this.f4ETCR_PLT.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_PLT.sJoin = "";
            this.f4ETCR_PLT.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'B0033\'";
            this.f4ETCR_PLT.TabIndex = 503;
            this.f4ETCR_PLT.Text = "C2";
            this.f4ETCR_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(102, 18);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(83, 22);
            this.TXT_PLT.TabIndex = 504;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TXT_GROUP);
            this.groupBox1.Controls.Add(this.txt_SB);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_SHIFT);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.SDT_SCH_DATE);
            this.groupBox1.Controls.Add(this.OPT_SLAB);
            this.groupBox1.Controls.Add(this.OPT_Mat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_PROD_CD);
            this.groupBox1.Controls.Add(this.txt_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.txt_Status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_GROUP
            // 
            this.TXT_GROUP.Location = new System.Drawing.Point(236, 21);
            this.TXT_GROUP.Name = "TXT_GROUP";
            this.TXT_GROUP.Size = new System.Drawing.Size(14, 22);
            this.TXT_GROUP.TabIndex = 505;
            this.TXT_GROUP.Visible = false;
            // 
            // txt_SB
            // 
            this.txt_SB.Location = new System.Drawing.Point(671, 18);
            this.txt_SB.Name = "txt_SB";
            this.txt_SB.sFcontrol = "T.CD";
            this.txt_SB.Size = new System.Drawing.Size(60, 22);
            this.txt_SB.sJoin = "";
            this.txt_SB.sSqletc = "SELECT T.CD AS 抛丸代码,T.CD_SHORT_NAME AS 抛丸名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'Q0074\' ORDER BY T.CD";
            this.txt_SB.TabIndex = 506;
            this.txt_SB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "1"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(527, 18);
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(60, 22);
            this.cbo_PrcLine.TabIndex = 505;
            this.cbo_PrcLine.Text = "1";
            // 
            // TXT_SHIFT
            // 
            this.TXT_SHIFT.Location = new System.Drawing.Point(217, 19);
            this.TXT_SHIFT.Name = "TXT_SHIFT";
            this.TXT_SHIFT.Size = new System.Drawing.Size(13, 22);
            this.TXT_SHIFT.TabIndex = 504;
            this.TXT_SHIFT.Visible = false;
            // 
            // SDT_SCH_DATE
            // 
            this.SDT_SCH_DATE.Location = new System.Drawing.Point(811, 18);
            this.SDT_SCH_DATE.Name = "SDT_SCH_DATE";
            this.SDT_SCH_DATE.RawDate = "";
            this.SDT_SCH_DATE.Size = new System.Drawing.Size(95, 22);
            this.SDT_SCH_DATE.TabIndex = 501;
            // 
            // OPT_SLAB
            // 
            this.OPT_SLAB.Location = new System.Drawing.Point(1000, 14);
            this.OPT_SLAB.Name = "OPT_SLAB";
            this.OPT_SLAB.Size = new System.Drawing.Size(68, 26);
            this.OPT_SLAB.TabIndex = 499;
            this.OPT_SLAB.TabStop = true;
            this.OPT_SLAB.Text = "轧坯号";
            this.OPT_SLAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_SLAB.UseVisualStyleBackColor = true;
            this.OPT_SLAB.Click += new System.EventHandler(this.OPT_SLAB_Click);
            // 
            // OPT_Mat
            // 
            this.OPT_Mat.Checked = true;
            this.OPT_Mat.Location = new System.Drawing.Point(934, 14);
            this.OPT_Mat.Name = "OPT_Mat";
            this.OPT_Mat.Size = new System.Drawing.Size(68, 26);
            this.OPT_Mat.TabIndex = 500;
            this.OPT_Mat.TabStop = true;
            this.OPT_Mat.Text = "物料号";
            this.OPT_Mat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Mat.UseVisualStyleBackColor = true;
            this.OPT_Mat.Click += new System.EventHandler(this.opt_Mat_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(197, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 202;
            this.label5.Text = "物料号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "工厂";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(1074, 11);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(16, 22);
            this.TXT_PROD_CD.TabIndex = 200;
            this.TXT_PROD_CD.Text = "SL";
            this.TXT_PROD_CD.Visible = false;
            // 
            // txt_PrcLine
            // 
            this.txt_PrcLine.Location = new System.Drawing.Point(487, 21);
            this.txt_PrcLine.Name = "txt_PrcLine";
            this.txt_PrcLine.Size = new System.Drawing.Size(14, 22);
            this.txt_PrcLine.TabIndex = 199;
            this.txt_PrcLine.Visible = false;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(286, 18);
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(142, 22);
            this.TXT_MAT_NO.TabIndex = 197;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(12, 21);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(12, 22);
            this.txt_Status.TabIndex = 196;
            this.txt_Status.Text = "1";
            this.txt_Status.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(593, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "抛丸";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(445, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "机号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(737, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "生产日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_RsltSb);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.TXT_EMP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_SHOT_BLAST_CLEA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXT_SPEED);
            this.groupBox2.Controls.Add(this.TXT_SHOT_BLAST_AREA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 384;
            this.label10.Text = "抛丸代码";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_RsltSb
            // 
            this.txt_RsltSb.Location = new System.Drawing.Point(102, 20);
            this.txt_RsltSb.Name = "txt_RsltSb";
            this.txt_RsltSb.sFcontrol = "T.CD";
            this.txt_RsltSb.Size = new System.Drawing.Size(83, 22);
            this.txt_RsltSb.sJoin = "";
            this.txt_RsltSb.sSqletc = "SELECT T.CD AS 抛丸代码,T.CD_SHORT_NAME AS 抛丸名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'Q0074\' ORDER BY T.CD";
            this.txt_RsltSb.TabIndex = 470;
            this.txt_RsltSb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(197, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 386;
            this.label12.Text = "作业日期";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(286, 20);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(142, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 388;
            // 
            // TXT_EMP
            // 
            this.TXT_EMP.Enabled = false;
            this.TXT_EMP.Location = new System.Drawing.Point(1005, 20);
            this.TXT_EMP.Name = "TXT_EMP";
            this.TXT_EMP.Size = new System.Drawing.Size(69, 22);
            this.TXT_EMP.TabIndex = 501;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(445, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 471;
            this.label6.Text = "清洁度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SHOT_BLAST_CLEA
            // 
            this.txt_SHOT_BLAST_CLEA.Location = new System.Drawing.Point(527, 20);
            this.txt_SHOT_BLAST_CLEA.MaxLength = 3;
            this.txt_SHOT_BLAST_CLEA.Name = "txt_SHOT_BLAST_CLEA";
            this.txt_SHOT_BLAST_CLEA.NumValue = 0D;
            this.txt_SHOT_BLAST_CLEA.Scale = 0;
            this.txt_SHOT_BLAST_CLEA.ShowZero = true;
            this.txt_SHOT_BLAST_CLEA.Size = new System.Drawing.Size(60, 22);
            this.txt_SHOT_BLAST_CLEA.TabIndex = 472;
            this.txt_SHOT_BLAST_CLEA.Text = "0";
            this.txt_SHOT_BLAST_CLEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(934, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 22);
            this.label9.TabIndex = 477;
            this.label9.Text = "作业人员";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(593, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 473;
            this.label7.Text = "进程速度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SPEED
            // 
            this.TXT_SPEED.Location = new System.Drawing.Point(671, 20);
            this.TXT_SPEED.MaxLength = 4;
            this.TXT_SPEED.Name = "TXT_SPEED";
            this.TXT_SPEED.NumValue = 0D;
            this.TXT_SPEED.Scale = 0;
            this.TXT_SPEED.ShowZero = true;
            this.TXT_SPEED.Size = new System.Drawing.Size(60, 22);
            this.TXT_SPEED.TabIndex = 474;
            this.TXT_SPEED.Text = "0";
            this.TXT_SPEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_SHOT_BLAST_AREA
            // 
            this.TXT_SHOT_BLAST_AREA.Location = new System.Drawing.Point(811, 20);
            this.TXT_SHOT_BLAST_AREA.MaxLength = 4;
            this.TXT_SHOT_BLAST_AREA.Name = "TXT_SHOT_BLAST_AREA";
            this.TXT_SHOT_BLAST_AREA.NumValue = 0D;
            this.TXT_SHOT_BLAST_AREA.Scale = 0;
            this.TXT_SHOT_BLAST_AREA.ShowZero = true;
            this.TXT_SHOT_BLAST_AREA.Size = new System.Drawing.Size(95, 22);
            this.TXT_SHOT_BLAST_AREA.TabIndex = 476;
            this.TXT_SHOT_BLAST_AREA.Text = "0";
            this.TXT_SHOT_BLAST_AREA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(737, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 475;
            this.label8.Text = "面积";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1113, 522);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Location = new System.Drawing.Point(0, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1119, 543);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // FGA1010C
            // 
            this.ClientSize = new System.Drawing.Size(1125, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGA1010C";
            this.Text = "抛丸实绩查询及修改界面_FGA1010C";
            this.Load += new System.EventHandler(this.FGA1010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private CommonClass.MaskedDate TXT_DISCHARGE_TIME;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_PROD_CD;
        private System.Windows.Forms.TextBox txt_PrcLine;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OPT_SLAB;
        private System.Windows.Forms.RadioButton OPT_Mat;
        private System.Windows.Forms.Label label6;
        private CommonClass.F4ETCN txt_RsltSb;
        private CommonClass.NumBox TXT_SHOT_BLAST_AREA;
        private System.Windows.Forms.Label label8;
        private CommonClass.NumBox TXT_SPEED;
        private System.Windows.Forms.Label label7;
        private CommonClass.NumBox txt_SHOT_BLAST_CLEA;
        private System.Windows.Forms.TextBox TXT_EMP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_GROUP;
        private System.Windows.Forms.TextBox TXT_SHIFT;
        private CommonClass.CeriUDate SDT_SCH_DATE;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private CommonClass.F4ETCN txt_SB;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
