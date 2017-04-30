namespace CG
{
    partial class WGT3010C
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
            this.txt_Defect = new CommonClass.F4ETCR();
            this.txt_Defect_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SP_CD = new System.Windows.Forms.TextBox();
            this.OPT_SLAB = new System.Windows.Forms.RadioButton();
            this.OPT_PLATE = new System.Windows.Forms.RadioButton();
            this.txt_Group_CD = new System.Windows.Forms.ComboBox();
            this.txt_Shift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DateTo = new CommonClass.CeriUDate();
            this.txt_DateFrom = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_PROD_CD = new System.Windows.Forms.TextBox();
            this.opt_Product2 = new System.Windows.Forms.RadioButton();
            this.opt_Product1 = new System.Windows.Forms.RadioButton();
            this.opt_Product = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Disp = new System.Windows.Forms.TextBox();
            this.txt_Disp_Order = new System.Windows.Forms.TextBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Defect
            // 
            bControlFiledSetting1.ColumnID = "cd";
            bControlFiledSetting1.TargetControl = this.txt_Defect;
            bControlFiledSetting2.ColumnID = "cd_name";
            bControlFiledSetting2.TargetControl = this.txt_Defect_name;
            this.txt_Defect.CustomSetting.Add(bControlFiledSetting1);
            this.txt_Defect.CustomSetting.Add(bControlFiledSetting2);
            this.txt_Defect.InputControl = this.txt_Defect;
            this.txt_Defect.Location = new System.Drawing.Point(727, 66);
            this.txt_Defect.Name = "txt_Defect";
            this.txt_Defect.Size = new System.Drawing.Size(45, 22);
            this.txt_Defect.sJoin = "";
            this.txt_Defect.sSqletc = "select cd 代码,cd_name 代码名称,cd_short_name 代码简称,cd_short_eng 英文简称 from zp_cd where c" +
                "d_mana_no = \'G0002\'";
            this.txt_Defect.TabIndex = 20;
            // 
            // txt_Defect_name
            // 
            this.txt_Defect_name.Location = new System.Drawing.Point(772, 66);
            this.txt_Defect_name.Name = "txt_Defect_name";
            this.txt_Defect_name.Size = new System.Drawing.Size(153, 22);
            this.txt_Defect_name.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SP_CD);
            this.groupBox1.Controls.Add(this.OPT_SLAB);
            this.groupBox1.Controls.Add(this.OPT_PLATE);
            this.groupBox1.Controls.Add(this.txt_Group_CD);
            this.groupBox1.Controls.Add(this.txt_Shift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_DateTo);
            this.groupBox1.Controls.Add(this.txt_DateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_SP_CD
            // 
            this.TXT_SP_CD.Location = new System.Drawing.Point(6, 17);
            this.TXT_SP_CD.Name = "TXT_SP_CD";
            this.TXT_SP_CD.Size = new System.Drawing.Size(11, 22);
            this.TXT_SP_CD.TabIndex = 9;
            this.TXT_SP_CD.Visible = false;
            // 
            // OPT_SLAB
            // 
            this.OPT_SLAB.Location = new System.Drawing.Point(672, 13);
            this.OPT_SLAB.Name = "OPT_SLAB";
            this.OPT_SLAB.Size = new System.Drawing.Size(51, 25);
            this.OPT_SLAB.TabIndex = 8;
            this.OPT_SLAB.TabStop = true;
            this.OPT_SLAB.Text = "轧制";
            this.OPT_SLAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_SLAB.UseVisualStyleBackColor = true;
            this.OPT_SLAB.Click += new System.EventHandler(this.OPT_SLAB_Click);
            // 
            // OPT_PLATE
            // 
            this.OPT_PLATE.Location = new System.Drawing.Point(600, 13);
            this.OPT_PLATE.Name = "OPT_PLATE";
            this.OPT_PLATE.Size = new System.Drawing.Size(51, 25);
            this.OPT_PLATE.TabIndex = 7;
            this.OPT_PLATE.TabStop = true;
            this.OPT_PLATE.Text = "剪切";
            this.OPT_PLATE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OPT_PLATE.UseVisualStyleBackColor = true;
            this.OPT_PLATE.Click += new System.EventHandler(this.OPT_PLATE_Click);
            // 
            // txt_Group_CD
            // 
            this.txt_Group_CD.FormattingEnabled = true;
            this.txt_Group_CD.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.txt_Group_CD.Location = new System.Drawing.Point(529, 15);
            this.txt_Group_CD.Name = "txt_Group_CD";
            this.txt_Group_CD.Size = new System.Drawing.Size(44, 21);
            this.txt_Group_CD.TabIndex = 6;
            // 
            // txt_Shift
            // 
            this.txt_Shift.FormattingEnabled = true;
            this.txt_Shift.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.txt_Shift.Location = new System.Drawing.Point(407, 15);
            this.txt_Shift.Name = "txt_Shift";
            this.txt_Shift.Size = new System.Drawing.Size(44, 21);
            this.txt_Shift.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(475, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "班别";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(352, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "班次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.Location = new System.Drawing.Point(211, 15);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.RawDate = "";
            this.txt_DateTo.Size = new System.Drawing.Size(97, 21);
            this.txt_DateTo.TabIndex = 2;
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.Location = new System.Drawing.Point(113, 15);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.RawDate = "";
            this.txt_DateFrom.Size = new System.Drawing.Size(98, 21);
            this.txt_DateFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_PROD_CD);
            this.groupBox2.Controls.Add(this.opt_Product2);
            this.groupBox2.Controls.Add(this.opt_Product1);
            this.groupBox2.Controls.Add(this.opt_Product);
            this.groupBox2.Location = new System.Drawing.Point(746, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TXT_PROD_CD
            // 
            this.TXT_PROD_CD.Location = new System.Drawing.Point(12, 13);
            this.TXT_PROD_CD.Name = "TXT_PROD_CD";
            this.TXT_PROD_CD.Size = new System.Drawing.Size(10, 22);
            this.TXT_PROD_CD.TabIndex = 7;
            this.TXT_PROD_CD.Visible = false;
            // 
            // opt_Product2
            // 
            this.opt_Product2.Location = new System.Drawing.Point(180, 14);
            this.opt_Product2.Name = "opt_Product2";
            this.opt_Product2.Size = new System.Drawing.Size(51, 26);
            this.opt_Product2.TabIndex = 6;
            this.opt_Product2.TabStop = true;
            this.opt_Product2.Text = "LP";
            this.opt_Product2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt_Product2.UseVisualStyleBackColor = true;
            this.opt_Product2.Click += new System.EventHandler(this.opt_Product2_Click);
            // 
            // opt_Product1
            // 
            this.opt_Product1.Location = new System.Drawing.Point(115, 13);
            this.opt_Product1.Name = "opt_Product1";
            this.opt_Product1.Size = new System.Drawing.Size(51, 25);
            this.opt_Product1.TabIndex = 5;
            this.opt_Product1.TabStop = true;
            this.opt_Product1.Text = "钢板";
            this.opt_Product1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_Product1.UseVisualStyleBackColor = true;
            this.opt_Product1.Click += new System.EventHandler(this.opt_Product1_Click);
            // 
            // opt_Product
            // 
            this.opt_Product.Location = new System.Drawing.Point(45, 13);
            this.opt_Product.Name = "opt_Product";
            this.opt_Product.Size = new System.Drawing.Size(51, 25);
            this.opt_Product.TabIndex = 4;
            this.opt_Product.TabStop = true;
            this.opt_Product.Text = "全部";
            this.opt_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_Product.UseVisualStyleBackColor = true;
            this.opt_Product.Click += new System.EventHandler(this.opt_Product_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox17);
            this.groupBox3.Controls.Add(this.txt_Defect);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_Defect_name);
            this.groupBox3.Controls.Add(this.txt_Disp);
            this.groupBox3.Controls.Add(this.txt_Disp_Order);
            this.groupBox3.Controls.Add(this.checkBox15);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox16);
            this.groupBox3.Controls.Add(this.checkBox14);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox12);
            this.groupBox3.Controls.Add(this.checkBox13);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1354, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(102, 71);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(78, 17);
            this.checkBox17.TabIndex = 21;
            this.checkBox17.Tag = ",O.STLGRD";
            this.checkBox17.Text = "轧制钢种";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(651, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 19;
            this.label4.Tag = "F4";
            this.label4.Text = "缺陷";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Disp
            // 
            this.txt_Disp.Location = new System.Drawing.Point(993, 21);
            this.txt_Disp.Name = "txt_Disp";
            this.txt_Disp.Size = new System.Drawing.Size(10, 22);
            this.txt_Disp.TabIndex = 17;
            this.txt_Disp.Visible = false;
            // 
            // txt_Disp_Order
            // 
            this.txt_Disp_Order.ForeColor = System.Drawing.Color.Red;
            this.txt_Disp_Order.Location = new System.Drawing.Point(651, 15);
            this.txt_Disp_Order.Multiline = true;
            this.txt_Disp_Order.Name = "txt_Disp_Order";
            this.txt_Disp_Order.Size = new System.Drawing.Size(337, 45);
            this.txt_Disp_Order.TabIndex = 16;
            this.txt_Disp_Order.Tag = "USER";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(15, 71);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(78, 17);
            this.checkBox15.TabIndex = 15;
            this.checkBox15.Tag = ",O.STLGRD";
            this.checkBox15.Text = "成品钢种";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(281, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Tag = ",B.WID";
            this.checkBox4.Text = "成品宽度";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(102, 46);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(65, 17);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Tag = ",SUBSTR(B.BED_PILE_DATE,1,8)";
            this.checkBox9.Text = "入库日";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(186, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Tag = ",B.THK";
            this.checkBox3.Text = "成品厚度";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(540, 18);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(91, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Tag = ",B.ORD_FL";
            this.checkBox7.Text = "订单材号码";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(15, 46);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(65, 17);
            this.checkBox8.TabIndex = 10;
            this.checkBox8.Tag = ",B.PROD_DATE";
            this.checkBox8.Text = "生产日";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(376, 18);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Tag = ",B.LEN";
            this.checkBox5.Text = "成品长度";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(102, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Tag = ",B.APLY_STDSPEC";
            this.checkBox2.Text = "成品标准";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(187, 71);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(91, 17);
            this.checkBox16.TabIndex = 7;
            this.checkBox16.Tag = ",B.ORD_ITEM";
            this.checkBox16.Text = "订单序列号";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.Visible = false;
            this.checkBox16.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(540, 46);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(52, 17);
            this.checkBox14.TabIndex = 6;
            this.checkBox14.Tag = ",B.TRIM_FL";
            this.checkBox14.Text = "切边";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(186, 46);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(78, 17);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Tag = ",B.DSC_DATE";
            this.checkBox10.Text = "综判日期";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(281, 46);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(65, 17);
            this.checkBox11.TabIndex = 4;
            this.checkBox11.Tag = ",substr(B.plate_no,1,10)";
            this.checkBox11.Text = "板坯号";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(376, 46);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(52, 17);
            this.checkBox12.TabIndex = 3;
            this.checkBox12.Tag = ",B.GROUP_CD";
            this.checkBox12.Text = "班别";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(460, 46);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(52, 17);
            this.checkBox13.TabIndex = 2;
            this.checkBox13.Tag = ",B.SIZE_KND";
            this.checkBox13.Text = "定尺";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(460, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(65, 17);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Tag = ",B.ORD_NO";
            this.checkBox6.Text = "订单号";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = ",B.STLGRD";
            this.checkBox1.Text = "板坯钢种";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(3, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1354, 467);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 446);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "汇总信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1334, 413);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1340, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "详细信息";
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
            this.ss2.Size = new System.Drawing.Size(1334, 413);
            this.ss2.TabIndex = 0;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // WGT3010C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 646);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGT3010C";
            this.Text = "综合查询_WGT3010C";
            this.Load += new System.EventHandler(this.WGY1205C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate txt_DateTo;
        private CommonClass.CeriUDate txt_DateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_Group_CD;
        private System.Windows.Forms.ComboBox txt_Shift;
        private System.Windows.Forms.RadioButton OPT_PLATE;
        private System.Windows.Forms.RadioButton OPT_SLAB;
        private System.Windows.Forms.RadioButton opt_Product2;
        private System.Windows.Forms.RadioButton opt_Product1;
        private System.Windows.Forms.RadioButton opt_Product;
        private System.Windows.Forms.TextBox TXT_SP_CD;
        private System.Windows.Forms.TextBox TXT_PROD_CD;
        private System.Windows.Forms.GroupBox groupBox3;
        private CommonClass.F4ETCR txt_Defect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Defect_name;
        private System.Windows.Forms.TextBox txt_Disp;
        private System.Windows.Forms.TextBox txt_Disp_Order;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.CheckBox checkBox17;
    }
}
