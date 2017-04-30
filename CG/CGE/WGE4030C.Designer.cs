namespace CG
{
    partial class WGE4030C
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
            this.txt_yard_knd = new CommonClass.F4ETCR();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1018, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pan_show_window
            // 
            this.pan_show_window.AutoScroll = true;
            this.pan_show_window.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(566, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 581);
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
            this.ss1.Size = new System.Drawing.Size(189, 560);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(761, 41);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 581);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(764, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 581);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // WGE40100C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGE40100C";
            this.Text = "宽厚板库区垛位图形化显示_WGE4030C";
            this.Load += new System.EventHandler(this.WGE40100C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pan_show_window;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
    }
}
