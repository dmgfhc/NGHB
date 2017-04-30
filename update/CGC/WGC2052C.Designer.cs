namespace CG
{
    partial class WGC2052C
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
            this.f4ETCR_PLT = new CommonClass.F4ETCR();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.f4ETCR_CUR_INV = new CommonClass.F4ETCR();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TXT_PLATE_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_FR = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.f4ETCR_PLT.Location = new System.Drawing.Point(109, 14);
            this.f4ETCR_PLT.Name = "f4ETCR_PLT";
            this.f4ETCR_PLT.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_PLT.sJoin = "";
            this.f4ETCR_PLT.sSqletc = "SELECT T.CD AS 工厂代码,T.CD_SHORT_NAME AS 工厂名称 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO" +
                " = \'B0033\'";
            this.f4ETCR_PLT.TabIndex = 106;
            this.f4ETCR_PLT.Text = "C2";
            this.f4ETCR_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(149, 14);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.ReadOnly = true;
            this.TXT_PLT.Size = new System.Drawing.Size(83, 22);
            this.TXT_PLT.TabIndex = 108;
            this.TXT_PLT.Text = "宽厚板厂";
            this.TXT_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // f4ETCR_CUR_INV
            // 
            bControlFiledSetting3.ColumnID = "T.CD";
            bControlFiledSetting3.TargetControl = this.f4ETCR_CUR_INV;
            this.f4ETCR_CUR_INV.CustomSetting.Add(bControlFiledSetting3);
            this.f4ETCR_CUR_INV.InputControl = this.f4ETCR_CUR_INV;
            this.f4ETCR_CUR_INV.Location = new System.Drawing.Point(109, 40);
            this.f4ETCR_CUR_INV.Name = "f4ETCR_CUR_INV";
            this.f4ETCR_CUR_INV.Size = new System.Drawing.Size(38, 22);
            this.f4ETCR_CUR_INV.sJoin = "";
            this.f4ETCR_CUR_INV.sSqletc = "SELECT T.CD AS 仓库代码 FROM NISCO.ZP_CD T WHERE T.CD_MANA_NO = \'C0021\'";
            this.f4ETCR_CUR_INV.TabIndex = 107;
            this.f4ETCR_CUR_INV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_PLT);
            this.groupBox1.Controls.Add(this.f4ETCR_CUR_INV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.TXT_PLATE_NO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 105;
            this.label1.Text = "当前库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(27, 14);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 22);
            this.label35.TabIndex = 104;
            this.label35.Text = "工厂";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLATE_NO
            // 
            this.TXT_PLATE_NO.Location = new System.Drawing.Point(646, 14);
            this.TXT_PLATE_NO.MaxLength = 14;
            this.TXT_PLATE_NO.Name = "TXT_PLATE_NO";
            this.TXT_PLATE_NO.Size = new System.Drawing.Size(124, 22);
            this.TXT_PLATE_NO.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(564, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 102;
            this.label6.Text = "钢板号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(446, 14);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_TO.TabIndex = 101;
            // 
            // SDT_PROD_DATE_FR
            // 
            this.SDT_PROD_DATE_FR.Location = new System.Drawing.Point(348, 14);
            this.SDT_PROD_DATE_FR.Name = "SDT_PROD_DATE_FR";
            this.SDT_PROD_DATE_FR.RawDate = "";
            this.SDT_PROD_DATE_FR.Size = new System.Drawing.Size(95, 22);
            this.SDT_PROD_DATE_FR.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(255, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 99;
            this.label4.Text = "生产时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ss1.Size = new System.Drawing.Size(1051, 531);
            this.ss1.TabIndex = 0;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 552);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // WGC2052C
            // 
            this.ClientSize = new System.Drawing.Size(1057, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGC2052C";
            this.Text = "钢板取消分板管理界面_WGC2052C";
            this.Load += new System.EventHandler(this.WGC2052C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_PLT;
        private CommonClass.F4ETCR f4ETCR_PLT;
        private CommonClass.F4ETCR f4ETCR_CUR_INV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox TXT_PLATE_NO;
        private System.Windows.Forms.Label label6;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private CommonClass.CeriUDate SDT_PROD_DATE_FR;
        private System.Windows.Forms.Label label4;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
