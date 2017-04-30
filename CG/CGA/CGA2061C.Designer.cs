namespace CG
{
    partial class CGA2061C
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
            CommonClass.BControlFiledSetting bControlFiledSetting5 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting6 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting7 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting8 = new CommonClass.BControlFiledSetting();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_name = new System.Windows.Forms.TextBox();
            this.txt_InPltCo = new CommonClass.F4ETCR();
            this.txt_InPltCoDesc = new System.Windows.Forms.TextBox();
            this.txt_act_stlgrd = new CommonClass.F4ETCR();
            this.txt_act_stlgrd_dec = new System.Windows.Forms.TextBox();
            this.txt_cur_inv_code = new CommonClass.F4ETCR();
            this.txt_cur_inv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_wid_to = new System.Windows.Forms.TextBox();
            this.txt_wid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_len_to = new System.Windows.Forms.TextBox();
            this.txt_len = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_thk_to = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sdt_out_plt_date = new CommonClass.CeriUDate();
            this.sdt_in_plt_date = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_thk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_heatno = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ss3 = new FarPoint.Win.Spread.FpSpread();
            this.ss3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ss4 = new FarPoint.Win.Spread.FpSpread();
            this.ss4_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ss5 = new FarPoint.Win.Spread.FpSpread();
            this.ss5_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss5_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_plt
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_plt;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_plt_name;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting1);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(399, 18);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(25, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
                "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
                "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_plt.TabIndex = 553;
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt_name
            // 
            this.txt_plt_name.Enabled = false;
            this.txt_plt_name.Location = new System.Drawing.Point(424, 18);
            this.txt_plt_name.Name = "txt_plt_name";
            this.txt_plt_name.Size = new System.Drawing.Size(98, 22);
            this.txt_plt_name.TabIndex = 554;
            // 
            // txt_InPltCo
            // 
            bControlFiledSetting3.ColumnID = "CUST_CD";
            bControlFiledSetting3.TargetControl = this.txt_InPltCo;
            bControlFiledSetting4.ColumnID = "CUST_NM";
            bControlFiledSetting4.TargetControl = this.txt_InPltCoDesc;
            this.txt_InPltCo.CustomSetting.Add(bControlFiledSetting3);
            this.txt_InPltCo.CustomSetting.Add(bControlFiledSetting4);
            this.txt_InPltCo.InputControl = this.txt_InPltCo;
            this.txt_InPltCo.Location = new System.Drawing.Point(603, 18);
            this.txt_InPltCo.MaxLength = 2;
            this.txt_InPltCo.Name = "txt_InPltCo";
            this.txt_InPltCo.Size = new System.Drawing.Size(58, 22);
            this.txt_InPltCo.sJoin = "";
            this.txt_InPltCo.sSqletc = "SELECT  CUST_CD \"客户代码\", CUST_NM \"客户名称\", CUST_NM_ENG \"客户英文名称\" FROM NISCO.BP_CUST_C" +
                "D  WHERE CUST_CD LIKE \'%\' AND CUST_TYP  IN (\'Z\',\'P\')";
            this.txt_InPltCo.TabIndex = 556;
            this.txt_InPltCo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_InPltCoDesc
            // 
            this.txt_InPltCoDesc.Enabled = false;
            this.txt_InPltCoDesc.Location = new System.Drawing.Point(667, 18);
            this.txt_InPltCoDesc.Name = "txt_InPltCoDesc";
            this.txt_InPltCoDesc.Size = new System.Drawing.Size(139, 22);
            this.txt_InPltCoDesc.TabIndex = 557;
            // 
            // txt_act_stlgrd
            // 
            bControlFiledSetting5.ColumnID = "STLGRD";
            bControlFiledSetting5.TargetControl = this.txt_act_stlgrd;
            bControlFiledSetting6.ColumnID = "STEEL_GRD_DETAIL";
            bControlFiledSetting6.TargetControl = this.txt_act_stlgrd_dec;
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting5);
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting6);
            this.txt_act_stlgrd.InputControl = this.txt_act_stlgrd;
            this.txt_act_stlgrd.Location = new System.Drawing.Point(88, 48);
            this.txt_act_stlgrd.Name = "txt_act_stlgrd";
            this.txt_act_stlgrd.Size = new System.Drawing.Size(112, 22);
            this.txt_act_stlgrd.sJoin = "";
            this.txt_act_stlgrd.sSqletc = "SELECT  STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM NISCO.QP_NISCO_CHMC  WHERE STLG" +
                "RD LIKE \'%\' AND NVL(STEEL_GRD_DETAIL,\'%\') LIKE \'%\'   ORDER  BY  STLGRD  ASC ";
            this.txt_act_stlgrd.TabIndex = 563;
            this.txt_act_stlgrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_act_stlgrd_dec
            // 
            this.txt_act_stlgrd_dec.Enabled = false;
            this.txt_act_stlgrd_dec.Location = new System.Drawing.Point(206, 48);
            this.txt_act_stlgrd_dec.Name = "txt_act_stlgrd_dec";
            this.txt_act_stlgrd_dec.Size = new System.Drawing.Size(112, 22);
            this.txt_act_stlgrd_dec.TabIndex = 564;
            // 
            // txt_cur_inv_code
            // 
            bControlFiledSetting7.ColumnID = "CD";
            bControlFiledSetting7.TargetControl = this.txt_cur_inv_code;
            bControlFiledSetting8.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting8.TargetControl = this.txt_cur_inv;
            this.txt_cur_inv_code.CustomSetting.Add(bControlFiledSetting7);
            this.txt_cur_inv_code.CustomSetting.Add(bControlFiledSetting8);
            this.txt_cur_inv_code.InputControl = this.txt_cur_inv_code;
            this.txt_cur_inv_code.Location = new System.Drawing.Point(399, 49);
            this.txt_cur_inv_code.MaxLength = 2;
            this.txt_cur_inv_code.Name = "txt_cur_inv_code";
            this.txt_cur_inv_code.Size = new System.Drawing.Size(25, 22);
            this.txt_cur_inv_code.sJoin = "";
            this.txt_cur_inv_code.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
                "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0013\'    AND C" +
                "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_cur_inv_code.TabIndex = 566;
            this.txt_cur_inv_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cur_inv
            // 
            this.txt_cur_inv.Enabled = false;
            this.txt_cur_inv.Location = new System.Drawing.Point(424, 49);
            this.txt_cur_inv.Name = "txt_cur_inv";
            this.txt_cur_inv.Size = new System.Drawing.Size(98, 22);
            this.txt_cur_inv.TabIndex = 567;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_wid_to);
            this.groupBox1.Controls.Add(this.txt_wid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_cur_inv);
            this.groupBox1.Controls.Add(this.txt_cur_inv_code);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd_dec);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd);
            this.groupBox1.Controls.Add(this.txt_len_to);
            this.groupBox1.Controls.Add(this.txt_len);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_thk_to);
            this.groupBox1.Controls.Add(this.txt_InPltCoDesc);
            this.groupBox1.Controls.Add(this.txt_InPltCo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_plt_name);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sdt_out_plt_date);
            this.groupBox1.Controls.Add(this.sdt_in_plt_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_thk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_heatno);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 571;
            this.label3.Text = "钢种";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_wid_to
            // 
            this.txt_wid_to.Location = new System.Drawing.Point(650, 49);
            this.txt_wid_to.MaxLength = 4;
            this.txt_wid_to.Name = "txt_wid_to";
            this.txt_wid_to.Size = new System.Drawing.Size(41, 22);
            this.txt_wid_to.TabIndex = 570;
            this.txt_wid_to.Text = "0";
            // 
            // txt_wid
            // 
            this.txt_wid.Location = new System.Drawing.Point(603, 49);
            this.txt_wid.MaxLength = 4;
            this.txt_wid.Name = "txt_wid";
            this.txt_wid.Size = new System.Drawing.Size(41, 22);
            this.txt_wid.TabIndex = 569;
            this.txt_wid.Text = "0";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(528, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 568;
            this.label8.Text = "宽度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(324, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 565;
            this.label7.Text = "来仓库";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_len_to
            // 
            this.txt_len_to.Location = new System.Drawing.Point(920, 52);
            this.txt_len_to.MaxLength = 5;
            this.txt_len_to.Name = "txt_len_to";
            this.txt_len_to.Size = new System.Drawing.Size(41, 22);
            this.txt_len_to.TabIndex = 561;
            this.txt_len_to.Text = "0";
            // 
            // txt_len
            // 
            this.txt_len.Location = new System.Drawing.Point(873, 52);
            this.txt_len.MaxLength = 5;
            this.txt_len.Name = "txt_len";
            this.txt_len.Size = new System.Drawing.Size(41, 22);
            this.txt_len.TabIndex = 560;
            this.txt_len.Text = "0";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(812, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 22);
            this.label10.TabIndex = 559;
            this.label10.Text = "长度";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_thk_to
            // 
            this.txt_thk_to.Location = new System.Drawing.Point(920, 18);
            this.txt_thk_to.MaxLength = 3;
            this.txt_thk_to.Name = "txt_thk_to";
            this.txt_thk_to.Size = new System.Drawing.Size(41, 22);
            this.txt_thk_to.TabIndex = 558;
            this.txt_thk_to.Text = "0";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(528, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 555;
            this.label9.Text = "外购公司";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(324, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 552;
            this.label5.Text = "生产工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdt_out_plt_date
            // 
            this.sdt_out_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_out_plt_date.Location = new System.Drawing.Point(206, 18);
            this.sdt_out_plt_date.Name = "sdt_out_plt_date";
            this.sdt_out_plt_date.RawDate = "";
            this.sdt_out_plt_date.Size = new System.Drawing.Size(112, 24);
            this.sdt_out_plt_date.TabIndex = 518;
            this.sdt_out_plt_date.Tag = "结束时间";
            // 
            // sdt_in_plt_date
            // 
            this.sdt_in_plt_date.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_in_plt_date.Location = new System.Drawing.Point(88, 18);
            this.sdt_in_plt_date.Name = "sdt_in_plt_date";
            this.sdt_in_plt_date.RawDate = "";
            this.sdt_in_plt_date.Size = new System.Drawing.Size(112, 24);
            this.sdt_in_plt_date.TabIndex = 517;
            this.sdt_in_plt_date.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 516;
            this.label4.Text = "日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(967, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "炉号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_thk
            // 
            this.txt_thk.Location = new System.Drawing.Point(873, 18);
            this.txt_thk.MaxLength = 3;
            this.txt_thk.Name = "txt_thk";
            this.txt_thk.Size = new System.Drawing.Size(41, 22);
            this.txt_thk.TabIndex = 5;
            this.txt_thk.Text = "0";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(812, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "厚度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_heatno
            // 
            this.txt_heatno.Location = new System.Drawing.Point(1036, 18);
            this.txt_heatno.MaxLength = 8;
            this.txt_heatno.Name = "txt_heatno";
            this.txt_heatno.Size = new System.Drawing.Size(93, 22);
            this.txt_heatno.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 530);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入库详细查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1130, 497);
            this.ss1.TabIndex = 2;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1136, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出库详细查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 3);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1130, 497);
            this.ss2.TabIndex = 4;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ss3);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1136, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "使用详细查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ss3
            // 
            this.ss3.AccessibleDescription = "";
            this.ss3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss3.Location = new System.Drawing.Point(3, 3);
            this.ss3.Name = "ss3";
            this.ss3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss3_Sheet1});
            this.ss3.Size = new System.Drawing.Size(1130, 497);
            this.ss3.TabIndex = 3;
            // 
            // ss3_Sheet1
            // 
            this.ss3_Sheet1.Reset();
            this.ss3_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ss4);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1136, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "库存详细查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ss4
            // 
            this.ss4.AccessibleDescription = "";
            this.ss4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss4.Location = new System.Drawing.Point(3, 3);
            this.ss4.Name = "ss4";
            this.ss4.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss4_Sheet1});
            this.ss4.Size = new System.Drawing.Size(1130, 497);
            this.ss4.TabIndex = 3;
            // 
            // ss4_Sheet1
            // 
            this.ss4_Sheet1.Reset();
            this.ss4_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ss5);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1136, 503);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "在途明细查询";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ss5
            // 
            this.ss5.AccessibleDescription = "";
            this.ss5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss5.Location = new System.Drawing.Point(3, 3);
            this.ss5.Name = "ss5";
            this.ss5.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss5_Sheet1});
            this.ss5.Size = new System.Drawing.Size(1130, 497);
            this.ss5.TabIndex = 3;
            // 
            // ss5_Sheet1
            // 
            this.ss5_Sheet1.Reset();
            this.ss5_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2061C
            // 
            this.ClientSize = new System.Drawing.Size(1144, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2061C";
            this.Text = "库详细情况查询界面_CGA2061C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss5_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_heatno;
        public System.Windows.Forms.TextBox txt_thk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public CommonClass.CeriUDate sdt_out_plt_date;
        public CommonClass.CeriUDate sdt_in_plt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cur_inv;
        private CommonClass.F4ETCR txt_cur_inv_code;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_act_stlgrd_dec;
        public CommonClass.F4ETCR txt_act_stlgrd;
        private System.Windows.Forms.TextBox txt_len_to;
        private System.Windows.Forms.TextBox txt_len;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_thk_to;
        private System.Windows.Forms.TextBox txt_InPltCoDesc;
        private CommonClass.F4ETCR txt_InPltCo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_plt_name;
        public CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_wid_to;
        public System.Windows.Forms.TextBox txt_wid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.TabPage tabPage3;
        private FarPoint.Win.Spread.FpSpread ss3;
        private FarPoint.Win.Spread.SheetView ss3_Sheet1;
        private System.Windows.Forms.TabPage tabPage4;
        private FarPoint.Win.Spread.FpSpread ss4;
        private FarPoint.Win.Spread.SheetView ss4_Sheet1;
        private System.Windows.Forms.TabPage tabPage5;
        private FarPoint.Win.Spread.FpSpread ss5;
        private FarPoint.Win.Spread.SheetView ss5_Sheet1;
    }
}
