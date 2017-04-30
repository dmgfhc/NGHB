namespace CG
{
    partial class WGC2070C
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
            this.txt_Prc = new System.Windows.Forms.TextBox();
            this.txt_RsltHtm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.udt_date_to = new CommonClass.CeriUDate();
            this.udt_date_fr = new CommonClass.CeriUDate();
            this.label7 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_EMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.TXT_PASS_CNT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_LEV_SPLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PRS_OT_PRS_DW_RTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_END_CD = new System.Windows.Forms.TextBox();
            this.txt_RETE_PRS_DW_RTO = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
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
            this.f4ETCR_PLT.Location = new System.Drawing.Point(92, 18);
            this.f4ETCR_PLT.Name = "f4ETCR_PLT";
            this.f4ETCR_PLT.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_PLT.sJoin = "";
            this.f4ETCR_PLT.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'B0033\'";
            this.f4ETCR_PLT.TabIndex = 423;
            this.f4ETCR_PLT.Text = "C2";
            this.f4ETCR_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(132, 18);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(83, 22);
            this.TXT_PLT.TabIndex = 422;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.txt_Prc);
            this.groupBox1.Controls.Add(this.txt_RsltHtm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.udt_date_to);
            this.groupBox1.Controls.Add(this.udt_date_fr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_Prc
            // 
            this.txt_Prc.Location = new System.Drawing.Point(390, 21);
            this.txt_Prc.Name = "txt_Prc";
            this.txt_Prc.Size = new System.Drawing.Size(25, 22);
            this.txt_Prc.TabIndex = 421;
            this.txt_Prc.Text = "C";
            this.txt_Prc.Visible = false;
            // 
            // txt_RsltHtm
            // 
            this.txt_RsltHtm.Location = new System.Drawing.Point(632, 18);
            this.txt_RsltHtm.Name = "txt_RsltHtm";
            this.txt_RsltHtm.Size = new System.Drawing.Size(76, 22);
            this.txt_RsltHtm.TabIndex = 420;
            this.txt_RsltHtm.Visible = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(548, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 419;
            this.label8.Text = "热处理方法";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // udt_date_to
            // 
            this.udt_date_to.Location = new System.Drawing.Point(905, 18);
            this.udt_date_to.Name = "udt_date_to";
            this.udt_date_to.RawDate = "";
            this.udt_date_to.Size = new System.Drawing.Size(95, 22);
            this.udt_date_to.TabIndex = 418;
            this.udt_date_to.Visible = false;
            // 
            // udt_date_fr
            // 
            this.udt_date_fr.Location = new System.Drawing.Point(804, 18);
            this.udt_date_fr.Name = "udt_date_fr";
            this.udt_date_fr.RawDate = "";
            this.udt_date_fr.Size = new System.Drawing.Size(95, 22);
            this.udt_date_fr.TabIndex = 417;
            this.udt_date_fr.Visible = false;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(714, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 416;
            this.label7.Text = "生产日期";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Visible = false;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(12, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 22);
            this.label35.TabIndex = 413;
            this.label35.Text = "工厂";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(468, 18);
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(143, 22);
            this.TXT_MAT_NO.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(384, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 200;
            this.label5.Text = "查询号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "一号线",
            "二号线"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(300, 18);
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(78, 22);
            this.cbo_PrcLine.TabIndex = 199;
            this.cbo_PrcLine.Text = "一号线";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(228, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 198;
            this.label2.Text = "机号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_EMP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.TXT_PASS_CNT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_LEV_SPLT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PRS_OT_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXT_END_CD);
            this.groupBox2.Controls.Add(this.txt_RETE_PRS_DW_RTO);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // TXT_EMP
            // 
            this.TXT_EMP.Location = new System.Drawing.Point(936, 18);
            this.TXT_EMP.Name = "TXT_EMP";
            this.TXT_EMP.Size = new System.Drawing.Size(64, 22);
            this.TXT_EMP.TabIndex = 449;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(863, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 448;
            this.label6.Text = "作业人员";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(717, 18);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(140, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 447;
            // 
            // TXT_PASS_CNT
            // 
            this.TXT_PASS_CNT.Location = new System.Drawing.Point(569, 18);
            this.TXT_PASS_CNT.Name = "TXT_PASS_CNT";
            this.TXT_PASS_CNT.Size = new System.Drawing.Size(42, 22);
            this.TXT_PASS_CNT.TabIndex = 446;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(475, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 445;
            this.label4.Text = "次数";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_LEV_SPLT
            // 
            this.TXT_LEV_SPLT.Location = new System.Drawing.Point(421, 18);
            this.TXT_LEV_SPLT.Name = "TXT_LEV_SPLT";
            this.TXT_LEV_SPLT.Size = new System.Drawing.Size(48, 22);
            this.TXT_LEV_SPLT.TabIndex = 444;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(321, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 443;
            this.label3.Text = "倾斜度";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PRS_OT_PRS_DW_RTO
            // 
            this.PRS_OT_PRS_DW_RTO.Location = new System.Drawing.Point(264, 18);
            this.PRS_OT_PRS_DW_RTO.Name = "PRS_OT_PRS_DW_RTO";
            this.PRS_OT_PRS_DW_RTO.Size = new System.Drawing.Size(48, 22);
            this.PRS_OT_PRS_DW_RTO.TabIndex = 442;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 441;
            this.label1.Text = "出口测压下量";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_END_CD
            // 
            this.TXT_END_CD.Location = new System.Drawing.Point(1011, 76);
            this.TXT_END_CD.Name = "TXT_END_CD";
            this.TXT_END_CD.Size = new System.Drawing.Size(25, 22);
            this.TXT_END_CD.TabIndex = 440;
            this.TXT_END_CD.Visible = false;
            // 
            // txt_RETE_PRS_DW_RTO
            // 
            this.txt_RETE_PRS_DW_RTO.Location = new System.Drawing.Point(110, 18);
            this.txt_RETE_PRS_DW_RTO.Name = "txt_RETE_PRS_DW_RTO";
            this.txt_RETE_PRS_DW_RTO.Size = new System.Drawing.Size(48, 22);
            this.txt_RETE_PRS_DW_RTO.TabIndex = 432;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(12, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 22);
            this.label18.TabIndex = 431;
            this.label18.Text = "入口测压下量";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(617, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 421;
            this.label13.Text = "作业时间";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 97);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 525);
            this.ss1.TabIndex = 3;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGC2070C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC2070C";
            this.Text = "钢板矫直实绩管理界面_WGC2070C";
            this.Load += new System.EventHandler(this.WGC2070C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private System.Windows.Forms.Label label2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox txt_RETE_PRS_DW_RTO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_END_CD;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox TXT_PASS_CNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_LEV_SPLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PRS_OT_PRS_DW_RTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_EMP;
        private System.Windows.Forms.Label label6;
        private CommonClass.MaskedDate TXT_DISCHARGE_TIME;
        private System.Windows.Forms.TextBox txt_RsltHtm;
        private System.Windows.Forms.Label label8;
        private CommonClass.CeriUDate udt_date_to;
        private CommonClass.CeriUDate udt_date_fr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Prc;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
    }
}
