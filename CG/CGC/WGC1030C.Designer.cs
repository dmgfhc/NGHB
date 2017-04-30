namespace CG
{
    partial class WGC1030C
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
            this.f4ETCR_CUR_INV = new CommonClass.F4ETCR();
            this.TXT_CUR_INV = new System.Windows.Forms.TextBox();
            this.f4ETCR_PLT = new CommonClass.F4ETCR();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SDB_LEN_TO = new CommonClass.NumBox();
            this.SDB_LEN_FR = new CommonClass.NumBox();
            this.SDB_WID_TO = new CommonClass.NumBox();
            this.SDB_WID_FR = new CommonClass.NumBox();
            this.SDB_THK_TO = new CommonClass.NumBox();
            this.SDB_THK_FR = new CommonClass.NumBox();
            this.CBO_PROD_CD = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_LOC = new System.Windows.Forms.TextBox();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F4ETCN_STDSPEC_R = new CommonClass.F4ETCN();
            this.label31 = new System.Windows.Forms.Label();
            this.SDT_PLAN_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PLAN_DATE_FR = new CommonClass.CeriUDate();
            this.label2 = new System.Windows.Forms.Label();
            this.SDT_INS_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_INS_DATE_FR = new CommonClass.CeriUDate();
            this.label3 = new System.Windows.Forms.Label();
            this.CBO_PRC_STS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SDT_PLAN_CUT_DATE = new CommonClass.CeriUDate();
            this.label12 = new System.Windows.Forms.Label();
            this.rdo_del = new System.Windows.Forms.RadioButton();
            this.rdo_add = new System.Windows.Forms.RadioButton();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // f4ETCR_CUR_INV
            // 
            bControlFiledSetting1.ColumnID = "T.CD";
            bControlFiledSetting1.TargetControl = this.f4ETCR_CUR_INV;
            bControlFiledSetting2.ColumnID = "T.CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.TXT_CUR_INV;
            this.f4ETCR_CUR_INV.CustomSetting.Add(bControlFiledSetting1);
            this.f4ETCR_CUR_INV.CustomSetting.Add(bControlFiledSetting2);
            this.f4ETCR_CUR_INV.InputControl = this.f4ETCR_CUR_INV;
            this.f4ETCR_CUR_INV.Location = new System.Drawing.Point(94, 40);
            this.f4ETCR_CUR_INV.Name = "f4ETCR_CUR_INV";
            this.f4ETCR_CUR_INV.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_CUR_INV.sJoin = "";
            this.f4ETCR_CUR_INV.sSqletc = "SELECT T.CD AS 仓库代码,T.CD_SHORT_NAME AS 仓库名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'C0021\'";
            this.f4ETCR_CUR_INV.TabIndex = 17;
            this.f4ETCR_CUR_INV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_CUR_INV
            // 
            this.TXT_CUR_INV.Location = new System.Drawing.Point(134, 40);
            this.TXT_CUR_INV.Name = "TXT_CUR_INV";
            this.TXT_CUR_INV.Size = new System.Drawing.Size(85, 22);
            this.TXT_CUR_INV.TabIndex = 18;
            // 
            // f4ETCR_PLT
            // 
            bControlFiledSetting3.ColumnID = "T.CD";
            bControlFiledSetting3.TargetControl = this.f4ETCR_PLT;
            bControlFiledSetting4.ColumnID = "T.CD_SHORT_NAME";
            bControlFiledSetting4.TargetControl = this.TXT_PLT;
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting3);
            this.f4ETCR_PLT.CustomSetting.Add(bControlFiledSetting4);
            this.f4ETCR_PLT.InputControl = this.f4ETCR_PLT;
            this.f4ETCR_PLT.Location = new System.Drawing.Point(94, 14);
            this.f4ETCR_PLT.MaxLength = 2;
            this.f4ETCR_PLT.Name = "f4ETCR_PLT";
            this.f4ETCR_PLT.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_PLT.sJoin = "";
            this.f4ETCR_PLT.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'B0033\'";
            this.f4ETCR_PLT.TabIndex = 495;
            this.f4ETCR_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(134, 14);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(83, 22);
            this.TXT_PLT.TabIndex = 496;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDB_LEN_TO);
            this.groupBox1.Controls.Add(this.SDB_LEN_FR);
            this.groupBox1.Controls.Add(this.SDB_WID_TO);
            this.groupBox1.Controls.Add(this.SDB_WID_FR);
            this.groupBox1.Controls.Add(this.SDB_THK_TO);
            this.groupBox1.Controls.Add(this.SDB_THK_FR);
            this.groupBox1.Controls.Add(this.CBO_PROD_CD);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_LOC);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.F4ETCN_STDSPEC_R);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.SDT_PLAN_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PLAN_DATE_FR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDT_INS_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_INS_DATE_FR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBO_PRC_STS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_CUR_INV);
            this.groupBox1.Controls.Add(this.f4ETCR_CUR_INV);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDB_LEN_TO
            // 
            this.SDB_LEN_TO.Location = new System.Drawing.Point(912, 65);
            this.SDB_LEN_TO.MaxLength = 9;
            this.SDB_LEN_TO.Name = "SDB_LEN_TO";
            this.SDB_LEN_TO.NumValue = 0D;
            this.SDB_LEN_TO.Scale = 1;
            this.SDB_LEN_TO.ShowZero = false;
            this.SDB_LEN_TO.Size = new System.Drawing.Size(63, 22);
            this.SDB_LEN_TO.TabIndex = 500;
            this.SDB_LEN_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_LEN_FR
            // 
            this.SDB_LEN_FR.Location = new System.Drawing.Point(824, 66);
            this.SDB_LEN_FR.MaxLength = 9;
            this.SDB_LEN_FR.Name = "SDB_LEN_FR";
            this.SDB_LEN_FR.NumValue = 0D;
            this.SDB_LEN_FR.Scale = 1;
            this.SDB_LEN_FR.ShowZero = false;
            this.SDB_LEN_FR.Size = new System.Drawing.Size(63, 22);
            this.SDB_LEN_FR.TabIndex = 500;
            this.SDB_LEN_FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID_TO
            // 
            this.SDB_WID_TO.Location = new System.Drawing.Point(912, 40);
            this.SDB_WID_TO.MaxLength = 6;
            this.SDB_WID_TO.Name = "SDB_WID_TO";
            this.SDB_WID_TO.NumValue = 0D;
            this.SDB_WID_TO.Scale = 2;
            this.SDB_WID_TO.ShowZero = false;
            this.SDB_WID_TO.Size = new System.Drawing.Size(63, 22);
            this.SDB_WID_TO.TabIndex = 500;
            this.SDB_WID_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_WID_FR
            // 
            this.SDB_WID_FR.Location = new System.Drawing.Point(824, 41);
            this.SDB_WID_FR.MaxLength = 6;
            this.SDB_WID_FR.Name = "SDB_WID_FR";
            this.SDB_WID_FR.NumValue = 0D;
            this.SDB_WID_FR.Scale = 2;
            this.SDB_WID_FR.ShowZero = false;
            this.SDB_WID_FR.Size = new System.Drawing.Size(63, 22);
            this.SDB_WID_FR.TabIndex = 500;
            this.SDB_WID_FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK_TO
            // 
            this.SDB_THK_TO.Location = new System.Drawing.Point(912, 13);
            this.SDB_THK_TO.MaxLength = 6;
            this.SDB_THK_TO.Name = "SDB_THK_TO";
            this.SDB_THK_TO.NumValue = 0D;
            this.SDB_THK_TO.Scale = 2;
            this.SDB_THK_TO.ShowZero = false;
            this.SDB_THK_TO.Size = new System.Drawing.Size(63, 22);
            this.SDB_THK_TO.TabIndex = 500;
            this.SDB_THK_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_THK_FR
            // 
            this.SDB_THK_FR.Location = new System.Drawing.Point(824, 14);
            this.SDB_THK_FR.MaxLength = 6;
            this.SDB_THK_FR.Name = "SDB_THK_FR";
            this.SDB_THK_FR.NumValue = 0D;
            this.SDB_THK_FR.Scale = 2;
            this.SDB_THK_FR.ShowZero = false;
            this.SDB_THK_FR.Size = new System.Drawing.Size(63, 22);
            this.SDB_THK_FR.TabIndex = 500;
            this.SDB_THK_FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CBO_PROD_CD
            // 
            this.CBO_PROD_CD.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PROD_CD.FormattingEnabled = true;
            this.CBO_PROD_CD.Items.AddRange(new object[] {
            "MP",
            "PP"});
            this.CBO_PROD_CD.Location = new System.Drawing.Point(624, 14);
            this.CBO_PROD_CD.Name = "CBO_PROD_CD";
            this.CBO_PROD_CD.Size = new System.Drawing.Size(50, 22);
            this.CBO_PROD_CD.TabIndex = 498;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(542, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 497;
            this.label15.Tag = "";
            this.label15.Text = "产品代码";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(894, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 22);
            this.label10.TabIndex = 199;
            this.label10.Tag = "USER";
            this.label10.Text = "~";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(752, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 197;
            this.label11.Tag = "";
            this.label11.Text = "长度";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(894, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 22);
            this.label8.TabIndex = 195;
            this.label8.Tag = "USER";
            this.label8.Text = "~";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(752, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 193;
            this.label9.Tag = "";
            this.label9.Text = "宽度";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(894, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 22);
            this.label7.TabIndex = 191;
            this.label7.Tag = "USER";
            this.label7.Text = "~";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(752, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 189;
            this.label6.Tag = "";
            this.label6.Text = "厚度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TXT_LOC
            // 
            this.TXT_LOC.Location = new System.Drawing.Point(94, 66);
            this.TXT_LOC.Name = "TXT_LOC";
            this.TXT_LOC.Size = new System.Drawing.Size(82, 22);
            this.TXT_LOC.TabIndex = 188;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(624, 66);
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(104, 22);
            this.TXT_PLATE_NO.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(542, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 187;
            this.label5.Tag = "";
            this.label5.Text = "查询号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // F4ETCN_STDSPEC_R
            // 
            this.F4ETCN_STDSPEC_R.Location = new System.Drawing.Point(325, 66);
            this.F4ETCN_STDSPEC_R.Name = "F4ETCN_STDSPEC_R";
            this.F4ETCN_STDSPEC_R.sFcontrol = "T.STDSPEC";
            this.F4ETCN_STDSPEC_R.Size = new System.Drawing.Size(193, 22);
            this.F4ETCN_STDSPEC_R.sJoin = "";
            this.F4ETCN_STDSPEC_R.sSqletc = "SELECT T.STDSPEC AS 标准号,T.STDSPEC_YY AS 发布年度,STDSPEC_CHR_CD FROM NISCO.QP_STD_HEA" +
                "D T WHERE NVL(T.STDSPEC_CHR_CD,\'Y\') <>\'N\' ORDER BY STDSPEC ASC";
            this.F4ETCN_STDSPEC_R.TabIndex = 186;
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.Location = new System.Drawing.Point(243, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 22);
            this.label31.TabIndex = 185;
            this.label31.Tag = "F4";
            this.label31.Text = "标准号";
            this.label31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SDT_PLAN_DATE_TO
            // 
            this.SDT_PLAN_DATE_TO.Location = new System.Drawing.Point(423, 40);
            this.SDT_PLAN_DATE_TO.Name = "SDT_PLAN_DATE_TO";
            this.SDT_PLAN_DATE_TO.RawDate = "";
            this.SDT_PLAN_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PLAN_DATE_TO.TabIndex = 72;
            // 
            // SDT_PLAN_DATE_FR
            // 
            this.SDT_PLAN_DATE_FR.Location = new System.Drawing.Point(325, 40);
            this.SDT_PLAN_DATE_FR.Name = "SDT_PLAN_DATE_FR";
            this.SDT_PLAN_DATE_FR.RawDate = "";
            this.SDT_PLAN_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.SDT_PLAN_DATE_FR.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(243, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "计划日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SDT_INS_DATE_TO
            // 
            this.SDT_INS_DATE_TO.Location = new System.Drawing.Point(423, 14);
            this.SDT_INS_DATE_TO.Name = "SDT_INS_DATE_TO";
            this.SDT_INS_DATE_TO.RawDate = "";
            this.SDT_INS_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_INS_DATE_TO.TabIndex = 69;
            // 
            // SDT_INS_DATE_FR
            // 
            this.SDT_INS_DATE_FR.Location = new System.Drawing.Point(325, 14);
            this.SDT_INS_DATE_FR.Name = "SDT_INS_DATE_FR";
            this.SDT_INS_DATE_FR.RawDate = "";
            this.SDT_INS_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.SDT_INS_DATE_FR.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(243, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "指示日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CBO_PRC_STS
            // 
            this.CBO_PRC_STS.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_PRC_STS.FormattingEnabled = true;
            this.CBO_PRC_STS.Items.AddRange(new object[] {
            "1 计划对象",
            "A 计划",
            "C 计划完成"});
            this.CBO_PRC_STS.Location = new System.Drawing.Point(624, 40);
            this.CBO_PRC_STS.Name = "CBO_PRC_STS";
            this.CBO_PRC_STS.Size = new System.Drawing.Size(104, 22);
            this.CBO_PRC_STS.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(542, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "计划状态";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(12, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 16;
            this.label14.Tag = "F4";
            this.label14.Text = "垛位";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 16;
            this.label1.Tag = "F4";
            this.label1.Text = "库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(12, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 22);
            this.label32.TabIndex = 13;
            this.label32.Tag = "F4";
            this.label32.Text = "工厂";
            this.label32.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBO_SHIFT);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.SDT_PLAN_CUT_DATE);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.rdo_del);
            this.groupBox3.Controls.Add(this.rdo_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 44);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.Font = new System.Drawing.Font("宋体", 10.25F);
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(623, 14);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(53, 22);
            this.CBO_SHIFT.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(541, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 80;
            this.label13.Text = "切割班次";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SDT_PLAN_CUT_DATE
            // 
            this.SDT_PLAN_CUT_DATE.Location = new System.Drawing.Point(360, 14);
            this.SDT_PLAN_CUT_DATE.Name = "SDT_PLAN_CUT_DATE";
            this.SDT_PLAN_CUT_DATE.RawDate = "";
            this.SDT_PLAN_CUT_DATE.Size = new System.Drawing.Size(95, 22);
            this.SDT_PLAN_CUT_DATE.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(242, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 22);
            this.label12.TabIndex = 78;
            this.label12.Text = "切割计划时间";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rdo_del
            // 
            this.rdo_del.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_del.Location = new System.Drawing.Point(116, 14);
            this.rdo_del.Name = "rdo_del";
            this.rdo_del.Size = new System.Drawing.Size(92, 22);
            this.rdo_del.TabIndex = 77;
            this.rdo_del.TabStop = true;
            this.rdo_del.Text = "计划取消";
            this.rdo_del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_del.UseVisualStyleBackColor = true;
            // 
            // rdo_add
            // 
            this.rdo_add.Checked = true;
            this.rdo_add.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_add.Location = new System.Drawing.Point(8, 14);
            this.rdo_add.Name = "rdo_add";
            this.rdo_add.Size = new System.Drawing.Size(92, 22);
            this.rdo_add.TabIndex = 76;
            this.rdo_add.TabStop = true;
            this.rdo_add.Text = "计划编辑";
            this.rdo_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_add.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 141);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 481);
            this.ss1.TabIndex = 4;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGC1030C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC1030C";
            this.Text = "钢板火切作业指示管理界面_WGC1030C";
            this.Load += new System.EventHandler(this.WGC1030C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_CUR_INV;
        private CommonClass.F4ETCR f4ETCR_CUR_INV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox CBO_PRC_STS;
        private System.Windows.Forms.Label label4;
        private CommonClass.CeriUDate SDT_PLAN_DATE_TO;
        private CommonClass.CeriUDate SDT_PLAN_DATE_FR;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_INS_DATE_TO;
        private CommonClass.CeriUDate SDT_INS_DATE_FR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCN F4ETCN_STDSPEC_R;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TXT_LOC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
        private System.Windows.Forms.ComboBox CBO_PROD_CD;
        private System.Windows.Forms.Label label15;
        private CommonClass.NumBox SDB_LEN_TO;
        private CommonClass.NumBox SDB_LEN_FR;
        private CommonClass.NumBox SDB_WID_TO;
        private CommonClass.NumBox SDB_WID_FR;
        private CommonClass.NumBox SDB_THK_TO;
        private CommonClass.NumBox SDB_THK_FR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label13;
        private CommonClass.CeriUDate SDT_PLAN_CUT_DATE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdo_del;
        private System.Windows.Forms.RadioButton rdo_add;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
    }
}
