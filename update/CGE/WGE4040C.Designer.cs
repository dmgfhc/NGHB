namespace CG
{
    partial class WGE4040C
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
            this.components = new System.ComponentModel.Container();
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            this.txt_yard_knd = new CommonClass.F4ETCR();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HeiAndWid = new System.Windows.Forms.Label();
            this.stdzone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.com_zone_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.com_yard_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.com_prod_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pan_show_window = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updatelocation = new System.Windows.Forms.Button();
            this.delocation = new System.Windows.Forms.Button();
            this.addlocation = new System.Windows.Forms.Button();
            this.txt_location_len = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_yard_column = new System.Windows.Forms.TextBox();
            this.txt_max_cnt = new System.Windows.Forms.TextBox();
            this.txt_location_type = new System.Windows.Forms.TextBox();
            this.txt_location_wid = new System.Windows.Forms.TextBox();
            this.txt_location_y = new System.Windows.Forms.TextBox();
            this.txt_location_x = new System.Windows.Forms.TextBox();
            this.txt_yard_row = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_yard_knd
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_yard_knd;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.textBox1;
            this.txt_yard_knd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_yard_knd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_yard_knd.InputControl = this.txt_yard_knd;
            this.txt_yard_knd.Location = new System.Drawing.Point(74, 13);
            this.txt_yard_knd.Name = "txt_yard_knd";
            this.txt_yard_knd.Size = new System.Drawing.Size(31, 22);
            this.txt_yard_knd.sJoin = "";
            this.txt_yard_knd.sSqletc = "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称,CD_SHORT_ENG 代码英文简称, CD_FULL_ENG 代" +
                "码英文名称 FROM NISCO.ZP_CD WHERE CD_MANA_NO = \'C0013\' ";
            this.txt_yard_knd.TabIndex = 64;
            this.txt_yard_knd.TextChanged += new System.EventHandler(this.txt_yard_knd_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.HeiAndWid);
            this.groupBox1.Controls.Add(this.stdzone);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_yard_knd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.com_zone_type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.com_yard_type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.com_prod_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // HeiAndWid
            // 
            this.HeiAndWid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeiAndWid.Location = new System.Drawing.Point(1282, 14);
            this.HeiAndWid.Name = "HeiAndWid";
            this.HeiAndWid.Size = new System.Drawing.Size(78, 21);
            this.HeiAndWid.TabIndex = 67;
            this.HeiAndWid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeiAndWid.Visible = false;
            // 
            // stdzone
            // 
            this.stdzone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stdzone.Location = new System.Drawing.Point(1181, 14);
            this.stdzone.Name = "stdzone";
            this.stdzone.Size = new System.Drawing.Size(101, 21);
            this.stdzone.TabIndex = 66;
            this.stdzone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stdzone.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 63;
            this.label1.Tag = "F4";
            this.label1.Text = "库代码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_zone_type
            // 
            this.com_zone_type.FormattingEnabled = true;
            this.com_zone_type.Location = new System.Drawing.Point(606, 13);
            this.com_zone_type.Name = "com_zone_type";
            this.com_zone_type.Size = new System.Drawing.Size(43, 21);
            this.com_zone_type.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(542, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "区号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_yard_type
            // 
            this.com_yard_type.FormattingEnabled = true;
            this.com_yard_type.Location = new System.Drawing.Point(462, 13);
            this.com_yard_type.Name = "com_yard_type";
            this.com_yard_type.Size = new System.Drawing.Size(43, 21);
            this.com_yard_type.TabIndex = 60;
            this.com_yard_type.TextChanged += new System.EventHandler(this.com_yard_type_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(398, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "跨号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_prod_type
            // 
            this.com_prod_type.FormattingEnabled = true;
            this.com_prod_type.Items.AddRange(new object[] {
            "",
            "P",
            "C",
            "S"});
            this.com_prod_type.Location = new System.Drawing.Point(318, 13);
            this.com_prod_type.Name = "com_prod_type";
            this.com_prod_type.Size = new System.Drawing.Size(43, 21);
            this.com_prod_type.TabIndex = 58;
            this.com_prod_type.TextChanged += new System.EventHandler(this.com_prod_type_TextChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(254, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "库类型";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pan_show_window);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 581);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pan_show_window
            // 
            this.pan_show_window.AutoScroll = true;
            this.pan_show_window.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pan_show_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_show_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_show_window.Location = new System.Drawing.Point(3, 18);
            this.pan_show_window.Name = "pan_show_window";
            this.pan_show_window.Size = new System.Drawing.Size(560, 560);
            this.pan_show_window.TabIndex = 2;
            this.pan_show_window.Tag = "USER";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updatelocation);
            this.groupBox3.Controls.Add(this.delocation);
            this.groupBox3.Controls.Add(this.addlocation);
            this.groupBox3.Controls.Add(this.txt_location_len);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_yard_column);
            this.groupBox3.Controls.Add(this.txt_max_cnt);
            this.groupBox3.Controls.Add(this.txt_location_type);
            this.groupBox3.Controls.Add(this.txt_location_wid);
            this.groupBox3.Controls.Add(this.txt_location_y);
            this.groupBox3.Controls.Add(this.txt_location_x);
            this.groupBox3.Controls.Add(this.txt_yard_row);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(566, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 581);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // updatelocation
            // 
            this.updatelocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updatelocation.Location = new System.Drawing.Point(7, 489);
            this.updatelocation.Name = "updatelocation";
            this.updatelocation.Size = new System.Drawing.Size(144, 36);
            this.updatelocation.TabIndex = 82;
            this.updatelocation.Text = "修改垛位";
            this.updatelocation.UseVisualStyleBackColor = true;
            this.updatelocation.Click += new System.EventHandler(this.updatelocation_Click);
            // 
            // delocation
            // 
            this.delocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delocation.Location = new System.Drawing.Point(7, 538);
            this.delocation.Name = "delocation";
            this.delocation.Size = new System.Drawing.Size(145, 36);
            this.delocation.TabIndex = 81;
            this.delocation.Text = "删除垛位";
            this.delocation.UseVisualStyleBackColor = true;
            this.delocation.Click += new System.EventHandler(this.delocation_Click);
            // 
            // addlocation
            // 
            this.addlocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addlocation.Location = new System.Drawing.Point(7, 439);
            this.addlocation.Name = "addlocation";
            this.addlocation.Size = new System.Drawing.Size(144, 36);
            this.addlocation.TabIndex = 80;
            this.addlocation.Text = "新增垛位";
            this.addlocation.UseVisualStyleBackColor = true;
            this.addlocation.Click += new System.EventHandler(this.addlocation_Click);
            // 
            // txt_location_len
            // 
            this.txt_location_len.Location = new System.Drawing.Point(73, 405);
            this.txt_location_len.Name = "txt_location_len";
            this.txt_location_len.Size = new System.Drawing.Size(77, 22);
            this.txt_location_len.TabIndex = 79;
            this.txt_location_len.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_location_len.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(7, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 78;
            this.label13.Text = "垛位长度";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_yard_column
            // 
            this.txt_yard_column.Location = new System.Drawing.Point(72, 75);
            this.txt_yard_column.Name = "txt_yard_column";
            this.txt_yard_column.Size = new System.Drawing.Size(77, 22);
            this.txt_yard_column.TabIndex = 77;
            this.txt_yard_column.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_yard_column.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_max_cnt
            // 
            this.txt_max_cnt.Location = new System.Drawing.Point(72, 130);
            this.txt_max_cnt.Name = "txt_max_cnt";
            this.txt_max_cnt.Size = new System.Drawing.Size(77, 22);
            this.txt_max_cnt.TabIndex = 75;
            this.txt_max_cnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_max_cnt_KeyPress);
            this.txt_max_cnt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_location_type
            // 
            this.txt_location_type.Location = new System.Drawing.Point(72, 185);
            this.txt_location_type.Name = "txt_location_type";
            this.txt_location_type.Size = new System.Drawing.Size(77, 22);
            this.txt_location_type.TabIndex = 74;
            this.txt_location_type.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_location_type_MouseClick);
            this.txt_location_type.TextChanged += new System.EventHandler(this.txt_location_type_TextChanged);
            this.txt_location_type.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_location_wid
            // 
            this.txt_location_wid.Location = new System.Drawing.Point(72, 350);
            this.txt_location_wid.Name = "txt_location_wid";
            this.txt_location_wid.Size = new System.Drawing.Size(77, 22);
            this.txt_location_wid.TabIndex = 73;
            this.txt_location_wid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_location_wid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_location_y
            // 
            this.txt_location_y.Location = new System.Drawing.Point(72, 295);
            this.txt_location_y.Name = "txt_location_y";
            this.txt_location_y.Size = new System.Drawing.Size(77, 22);
            this.txt_location_y.TabIndex = 72;
            this.txt_location_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_location_y.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_location_x
            // 
            this.txt_location_x.Location = new System.Drawing.Point(72, 240);
            this.txt_location_x.Name = "txt_location_x";
            this.txt_location_x.Size = new System.Drawing.Size(77, 22);
            this.txt_location_x.TabIndex = 71;
            this.txt_location_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_location_x.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // txt_yard_row
            // 
            this.txt_yard_row.Location = new System.Drawing.Point(72, 24);
            this.txt_yard_row.Name = "txt_yard_row";
            this.txt_yard_row.Size = new System.Drawing.Size(77, 22);
            this.txt_yard_row.TabIndex = 70;
            this.txt_yard_row.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yard_row_KeyPress);
            this.txt_yard_row.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yard_row_KeyUp);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(7, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 69;
            this.label12.Text = "列号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(7, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 67;
            this.label10.Text = "堆放数量";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(7, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 66;
            this.label9.Text = "垛位类型";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(7, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "垛位宽度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(7, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "坐标_Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(7, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "坐标_X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "行号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ss1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(727, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 581);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(637, 560);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1097, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "垛位修改";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // WGE4040C
            // 
            this.ClientSize = new System.Drawing.Size(1370, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGE4040C";
            this.Text = "钢板库库图管理_WGE4040C";
            this.Load += new System.EventHandler(this.WGE40200C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private CommonClass.F4ETCR txt_yard_knd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_zone_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_yard_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_prod_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delocation;
        private System.Windows.Forms.Button addlocation;
        private System.Windows.Forms.TextBox txt_location_len;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_yard_column;
        private System.Windows.Forms.TextBox txt_max_cnt;
        private System.Windows.Forms.TextBox txt_location_type;
        private System.Windows.Forms.TextBox txt_location_wid;
        private System.Windows.Forms.TextBox txt_location_y;
        private System.Windows.Forms.TextBox txt_location_x;
        private System.Windows.Forms.TextBox txt_yard_row;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button updatelocation;
        private System.Windows.Forms.Label HeiAndWid;
        private System.Windows.Forms.Label stdzone;
        private System.Windows.Forms.Panel pan_show_window;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
