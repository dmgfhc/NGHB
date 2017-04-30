namespace CG
{
    partial class WGE3010C
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
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_yard_knd
            // 
//            this.txt_yard_knd.conLength = 0;
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_yard_knd;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.textBox1;
            this.txt_yard_knd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_yard_knd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_yard_knd.InputControl = this.txt_yard_knd;
            this.txt_yard_knd.Location = new System.Drawing.Point(77, 13);
            this.txt_yard_knd.Name = "txt_yard_knd";
            this.txt_yard_knd.Size = new System.Drawing.Size(31, 22);
            this.txt_yard_knd.sJoin = "";
            this.txt_yard_knd.sSqletc = "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称,CD_SHORT_ENG 代码英文简称, CD_FULL_ENG 代" +
                "码英文名称 FROM NISCO.ZP_CD WHERE CD_MANA_NO = \'C0013\' ";
            this.txt_yard_knd.TabIndex = 28;
            this.txt_yard_knd.TextChanged += new System.EventHandler(this.txt_yard_knd_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 29;
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
            this.groupBox1.Size = new System.Drawing.Size(1018, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "库类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_zone_type
            // 
            this.com_zone_type.FormattingEnabled = true;
            this.com_zone_type.Location = new System.Drawing.Point(592, 13);
            this.com_zone_type.Name = "com_zone_type";
            this.com_zone_type.Size = new System.Drawing.Size(43, 21);
            this.com_zone_type.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(528, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "区号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_yard_type
            // 
            this.com_yard_type.FormattingEnabled = true;
            this.com_yard_type.Location = new System.Drawing.Point(454, 13);
            this.com_yard_type.Name = "com_yard_type";
            this.com_yard_type.Size = new System.Drawing.Size(43, 21);
            this.com_yard_type.TabIndex = 22;
            this.com_yard_type.SelectedIndexChanged += new System.EventHandler(this.com_yard_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(390, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 21;
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
            this.com_prod_type.Location = new System.Drawing.Point(316, 13);
            this.com_prod_type.Name = "com_prod_type";
            this.com_prod_type.Size = new System.Drawing.Size(43, 21);
            this.com_prod_type.TabIndex = 20;
            this.com_prod_type.SelectedIndexChanged += new System.EventHandler(this.com_prod_type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(252, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "库种类";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 582);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1012, 561);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // WGE4010C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGE4010C";
            this.Text = "宽厚板库区区位查询和维护界面_WGE3010C";
            this.Load += new System.EventHandler(this.WGE4010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_zone_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_yard_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_prod_type;
        private System.Windows.Forms.Label label4;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TextBox textBox1;
        private CommonClass.F4ETCR txt_yard_knd;
    }
}
