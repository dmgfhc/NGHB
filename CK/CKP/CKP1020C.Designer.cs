namespace CK
{
    partial class CKP1020C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CKP1020C));
            this.txt_ord_knd = new CommonClass.F4ETCR();
            this.txt_ord_kndname = new System.Windows.Forms.TextBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.ORD_NO_N = new System.Windows.Forms.RadioButton();
            this.ORD_NO_Y = new System.Windows.Forms.RadioButton();
            this.TXT_ORD_ITEM = new System.Windows.Forms.ComboBox();
            this.TXT_ORD_NO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UDA_DEL_TO = new CommonClass.CeriUDate();
            this.UDA_DEL_FR = new CommonClass.CeriUDate();
            this.ORD_OK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ord_knd
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_ord_knd;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_ord_kndname;
            this.txt_ord_knd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_ord_knd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_ord_knd.InputControl = this.txt_ord_knd;
            this.txt_ord_knd.Location = new System.Drawing.Point(461, 18);
            this.txt_ord_knd.MaxLength = 10;
            this.txt_ord_knd.Name = "txt_ord_knd";
            this.txt_ord_knd.Size = new System.Drawing.Size(46, 22);
            this.txt_ord_knd.sJoin = "";
            this.txt_ord_knd.sSqletc = resources.GetString("txt_ord_knd.sSqletc");
            this.txt_ord_knd.TabIndex = 760;
            // 
            // txt_ord_kndname
            // 
            this.txt_ord_kndname.Location = new System.Drawing.Point(513, 18);
            this.txt_ord_kndname.MaxLength = 11;
            this.txt_ord_kndname.Name = "txt_ord_kndname";
            this.txt_ord_kndname.Size = new System.Drawing.Size(87, 22);
            this.txt_ord_kndname.TabIndex = 759;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.ORD_NO_N);
            this.groupbox1.Controls.Add(this.ORD_NO_Y);
            this.groupbox1.Controls.Add(this.TXT_ORD_ITEM);
            this.groupbox1.Controls.Add(this.TXT_ORD_NO);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.txt_ord_knd);
            this.groupbox1.Controls.Add(this.txt_ord_kndname);
            this.groupbox1.Controls.Add(this.UDA_DEL_TO);
            this.groupbox1.Controls.Add(this.UDA_DEL_FR);
            this.groupbox1.Controls.Add(this.ORD_OK);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.ULabel5);
            this.groupbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox1.Location = new System.Drawing.Point(0, 0);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(1144, 59);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            // 
            // ORD_NO_N
            // 
            this.ORD_NO_N.AutoSize = true;
            this.ORD_NO_N.Location = new System.Drawing.Point(1000, 19);
            this.ORD_NO_N.Name = "ORD_NO_N";
            this.ORD_NO_N.Size = new System.Drawing.Size(64, 17);
            this.ORD_NO_N.TabIndex = 766;
            this.ORD_NO_N.Text = "未完成";
            this.ORD_NO_N.UseVisualStyleBackColor = true;
            this.ORD_NO_N.CheckedChanged += new System.EventHandler(this.ORD_NO_N_CheckedChanged);
            // 
            // ORD_NO_Y
            // 
            this.ORD_NO_Y.AutoSize = true;
            this.ORD_NO_Y.Checked = true;
            this.ORD_NO_Y.Location = new System.Drawing.Point(934, 19);
            this.ORD_NO_Y.Name = "ORD_NO_Y";
            this.ORD_NO_Y.Size = new System.Drawing.Size(51, 17);
            this.ORD_NO_Y.TabIndex = 765;
            this.ORD_NO_Y.TabStop = true;
            this.ORD_NO_Y.Text = "完成";
            this.ORD_NO_Y.UseVisualStyleBackColor = true;
            this.ORD_NO_Y.CheckedChanged += new System.EventHandler(this.ORD_NO_Y_CheckedChanged);
            // 
            // TXT_ORD_ITEM
            // 
            this.TXT_ORD_ITEM.FormattingEnabled = true;
            this.TXT_ORD_ITEM.Location = new System.Drawing.Point(867, 18);
            this.TXT_ORD_ITEM.Name = "TXT_ORD_ITEM";
            this.TXT_ORD_ITEM.Size = new System.Drawing.Size(46, 21);
            this.TXT_ORD_ITEM.TabIndex = 764;
            // 
            // TXT_ORD_NO
            // 
            this.TXT_ORD_NO.Location = new System.Drawing.Point(759, 18);
            this.TXT_ORD_NO.MaxLength = 11;
            this.TXT_ORD_NO.Name = "TXT_ORD_NO";
            this.TXT_ORD_NO.Size = new System.Drawing.Size(100, 22);
            this.TXT_ORD_NO.TabIndex = 763;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(669, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 762;
            this.label1.Text = "订单号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(375, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 761;
            this.label4.Text = "订单种类";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UDA_DEL_TO
            // 
            this.UDA_DEL_TO.Location = new System.Drawing.Point(233, 18);
            this.UDA_DEL_TO.Name = "UDA_DEL_TO";
            this.UDA_DEL_TO.RawDate = "";
            this.UDA_DEL_TO.Size = new System.Drawing.Size(97, 21);
            this.UDA_DEL_TO.TabIndex = 4;
            // 
            // UDA_DEL_FR
            // 
            this.UDA_DEL_FR.Location = new System.Drawing.Point(120, 18);
            this.UDA_DEL_FR.Name = "UDA_DEL_FR";
            this.UDA_DEL_FR.RawDate = "";
            this.UDA_DEL_FR.Size = new System.Drawing.Size(97, 21);
            this.UDA_DEL_FR.TabIndex = 4;
            // 
            // ORD_OK
            // 
            this.ORD_OK.Location = new System.Drawing.Point(1120, 19);
            this.ORD_OK.Name = "ORD_OK";
            this.ORD_OK.Size = new System.Drawing.Size(18, 22);
            this.ORD_OK.TabIndex = 2;
            this.ORD_OK.Text = "Y";
            this.ORD_OK.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(30, 18);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(84, 21);
            this.ULabel5.TabIndex = 0;
            this.ULabel5.Text = "用户交货期";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 59);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1144, 563);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CKP1020C
            // 
            this.ClientSize = new System.Drawing.Size(1144, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupbox1);
            this.Name = "CKP1020C";
            this.Text = "中板厂订单完成情况简报_CKP1020C";
            this.Load += new System.EventHandler(this.CKP1020C_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.Label label2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.TextBox ORD_OK;
        private CommonClass.CeriUDate UDA_DEL_FR;
        private CommonClass.CeriUDate UDA_DEL_TO;
        private System.Windows.Forms.Label label4;
        private CommonClass.F4ETCR txt_ord_knd;
        private System.Windows.Forms.TextBox txt_ord_kndname;
        private System.Windows.Forms.RadioButton ORD_NO_Y;
        private System.Windows.Forms.ComboBox TXT_ORD_ITEM;
        private System.Windows.Forms.TextBox TXT_ORD_NO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ORD_NO_N;
    }
}
