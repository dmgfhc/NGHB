namespace FG
{
    partial class FGA1020C
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
            this.txt_HtmCond = new CommonClass.F4ETCN();
            this.txt_Htm = new CommonClass.F4ETCN();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.OPT_SLAB = new System.Windows.Forms.RadioButton();
            this.OPT_Mat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.txt_PrcLine = new System.Windows.Forms.TextBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_chg_no = new System.Windows.Forms.ComboBox();
            this.TXT_GROUP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_SHIFT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_DISCHARGE_TIME = new CommonClass.MaskedDate();
            this.TXT_EMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ChargeTemp = new CommonClass.NumBox();
            this.label9 = new System.Windows.Forms.Label();
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
            // f4ETCR_PLT
            // 
            bControlFiledSetting1.ColumnID = "T.CD";
            bControlFiledSetting1.TargetControl = this.f4ETCR_PLT;
            bControlFiledSetting2.ColumnID = "T.CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.TXT_PLT;
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting1);
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting2);
            this.f4ETCR_PLT.InputControl = this.f4ETCR_PLT;
            this.f4ETCR_PLT.Location = new System.Drawing.Point(68, 17);
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
            this.TXT_PLT.Location = new System.Drawing.Point(108, 17);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(83, 22);
            this.TXT_PLT.TabIndex = 504;
            this.TXT_PLT.Text = "宽厚板厂";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_HtmCond);
            this.groupBox1.Controls.Add(this.txt_Htm);
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.OPT_SLAB);
            this.groupBox1.Controls.Add(this.OPT_Mat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_PROD_CD);
            this.groupBox1.Controls.Add(this.txt_PrcLine);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_HtmCond
            // 
            this.txt_HtmCond.Location = new System.Drawing.Point(790, 17);
            this.txt_HtmCond.Name = "txt_HtmCond";
            this.txt_HtmCond.sFcontrol = "HTM_COND";
            this.txt_HtmCond.Size = new System.Drawing.Size(71, 22);
            this.txt_HtmCond.sJoin = "";
            this.txt_HtmCond.sSqletc = "SELECT HTM_COND 热处理条件,HTM_COND_TXT 热处理条件说明,HTM_TEMP_TGT  均热段温度,HTM_TIME_1F_AIM 均热" +
                "段驻留时间1,HTM_TIME_2F_AIM 均热段驻留时间2,HTM_COOL_TYP 冷却方式,HTM_COOL_TMP 下冷床温度 FROM  QP_HE" +
                "AT_COND ";
            this.txt_HtmCond.TabIndex = 507;
            // 
            // txt_Htm
            // 
            this.txt_Htm.Location = new System.Drawing.Point(635, 17);
            this.txt_Htm.Name = "txt_Htm";
            this.txt_Htm.sFcontrol = "T.CD";
            this.txt_Htm.Size = new System.Drawing.Size(70, 22);
            this.txt_Htm.sJoin = "";
            this.txt_Htm.sSqletc = "SELECT T.CD ,T.CD_SHORT_NAME  FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO = \'Q0073\' ORD" +
                "ER BY T.CD";
            this.txt_Htm.TabIndex = 506;
            this.txt_Htm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(275, 17);
            this.cbo_PrcLine.MaxLength = 1;
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(50, 22);
            this.cbo_PrcLine.TabIndex = 505;
            this.cbo_PrcLine.Text = "1";
            // 
            // OPT_SLAB
            // 
            this.OPT_SLAB.Location = new System.Drawing.Point(944, 11);
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
            this.OPT_Mat.Location = new System.Drawing.Point(878, 11);
            this.OPT_Mat.Name = "OPT_Mat";
            this.OPT_Mat.Size = new System.Drawing.Size(68, 26);
            this.OPT_Mat.TabIndex = 500;
            this.OPT_Mat.TabStop = true;
            this.OPT_Mat.Text = "物料号";
            this.OPT_Mat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_Mat.UseVisualStyleBackColor = true;
            this.OPT_Mat.Click += new System.EventHandler(this.OPT_Mat_Click_1);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(711, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 202;
            this.label5.Text = "指示条件";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 201;
            this.label2.Text = "工厂";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(1013, 18);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(16, 22);
            this.TXT_PROD_CD.TabIndex = 200;
            this.TXT_PROD_CD.Text = "SL";
            this.TXT_PROD_CD.Visible = false;
            // 
            // txt_PrcLine
            // 
            this.txt_PrcLine.Location = new System.Drawing.Point(255, 21);
            this.txt_PrcLine.Name = "txt_PrcLine";
            this.txt_PrcLine.Size = new System.Drawing.Size(14, 22);
            this.txt_PrcLine.TabIndex = 199;
            this.txt_PrcLine.Visible = false;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(409, 17);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(141, 22);
            this.TXT_MAT_NO.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(331, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 195;
            this.label1.Tag = "";
            this.label1.Text = "物料号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(197, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 85;
            this.label3.Text = "产线别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(556, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "指示方法";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_chg_no);
            this.groupBox2.Controls.Add(this.TXT_GROUP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TXT_SHIFT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TXT_DISCHARGE_TIME);
            this.groupBox2.Controls.Add(this.TXT_EMP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ChargeTemp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(0, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cbo_chg_no
            // 
            this.cbo_chg_no.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_chg_no.FormattingEnabled = true;
            this.cbo_chg_no.Items.AddRange(new object[] {
            "1"});
            this.cbo_chg_no.Location = new System.Drawing.Point(108, 20);
            this.cbo_chg_no.MaxLength = 1;
            this.cbo_chg_no.Name = "cbo_chg_no";
            this.cbo_chg_no.Size = new System.Drawing.Size(83, 22);
            this.cbo_chg_no.TabIndex = 508;
            this.cbo_chg_no.Text = "1";
            // 
            // TXT_GROUP
            // 
            this.TXT_GROUP.Location = new System.Drawing.Point(367, 18);
            this.TXT_GROUP.Name = "TXT_GROUP";
            this.TXT_GROUP.Size = new System.Drawing.Size(10, 22);
            this.TXT_GROUP.TabIndex = 505;
            this.TXT_GROUP.Visible = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 384;
            this.label10.Text = "炉座号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SHIFT
            // 
            this.TXT_SHIFT.Location = new System.Drawing.Point(346, 17);
            this.TXT_SHIFT.Name = "TXT_SHIFT";
            this.TXT_SHIFT.Size = new System.Drawing.Size(15, 22);
            this.TXT_SHIFT.TabIndex = 504;
            this.TXT_SHIFT.Visible = false;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(331, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 386;
            this.label12.Text = "装炉时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DISCHARGE_TIME
            // 
            this.TXT_DISCHARGE_TIME.Location = new System.Drawing.Point(409, 20);
            this.TXT_DISCHARGE_TIME.Mask = "0000-00-00 90:00:00";
            this.TXT_DISCHARGE_TIME.Name = "TXT_DISCHARGE_TIME";
            this.TXT_DISCHARGE_TIME.Size = new System.Drawing.Size(141, 22);
            this.TXT_DISCHARGE_TIME.TabIndex = 388;
            // 
            // TXT_EMP
            // 
            this.TXT_EMP.Enabled = false;
            this.TXT_EMP.Location = new System.Drawing.Point(635, 20);
            this.TXT_EMP.Name = "TXT_EMP";
            this.TXT_EMP.Size = new System.Drawing.Size(71, 22);
            this.TXT_EMP.TabIndex = 501;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(197, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 471;
            this.label6.Text = "装炉温度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ChargeTemp
            // 
            this.txt_ChargeTemp.Location = new System.Drawing.Point(275, 20);
            this.txt_ChargeTemp.MaxLength = 4;
            this.txt_ChargeTemp.Name = "txt_ChargeTemp";
            this.txt_ChargeTemp.NumValue = 0D;
            this.txt_ChargeTemp.Scale = 0;
            this.txt_ChargeTemp.ShowZero = true;
            this.txt_ChargeTemp.Size = new System.Drawing.Size(50, 22);
            this.txt_ChargeTemp.TabIndex = 472;
            this.txt_ChargeTemp.Text = "0";
            this.txt_ChargeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(556, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 477;
            this.label9.Text = "作业人员";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Location = new System.Drawing.Point(0, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1032, 544);
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
            this.ss1.Size = new System.Drawing.Size(1026, 523);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // FGA1020C
            // 
            this.ClientSize = new System.Drawing.Size(1042, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FGA1020C";
            this.Text = "装炉作业实绩查询及修改界面_FGA1020C";
            this.Load += new System.EventHandler(this.FGA1020C_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
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
        private CommonClass.NumBox txt_ChargeTemp;
        private System.Windows.Forms.TextBox TXT_EMP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_GROUP;
        private System.Windows.Forms.TextBox TXT_SHIFT;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
        private CommonClass.F4ETCN txt_Htm;
        private CommonClass.F4ETCN txt_HtmCond;
        private System.Windows.Forms.ComboBox cbo_chg_no;
    }
}
