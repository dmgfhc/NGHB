namespace CG
{
    partial class CGC2070C
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SDT_PROD_DATE_FROM = new CommonClass.CeriUDate();
            this.SDT_PROD_DATE_TO = new CommonClass.CeriUDate();
            this.label1 = new System.Windows.Forms.Label();
            this.ULabel40 = new System.Windows.Forms.Label();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_SEQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBO_NUM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBO_GAS_FL = new System.Windows.Forms.ComboBox();
            this.SSP4 = new System.Windows.Forms.Button();
            this.SSP1 = new System.Windows.Forms.Button();
            this.SSP2 = new System.Windows.Forms.Button();
            this.SSP3 = new System.Windows.Forms.Button();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SSP3);
            this.groupBox1.Controls.Add(this.SSP2);
            this.groupBox1.Controls.Add(this.SSP1);
            this.groupBox1.Controls.Add(this.SSP4);
            this.groupBox1.Controls.Add(this.CBO_GAS_FL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBO_NUM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_SEQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.ULabel40);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_FROM);
            this.groupBox1.Controls.Add(this.SDT_PROD_DATE_TO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDT_PROD_DATE_FROM
            // 
            this.SDT_PROD_DATE_FROM.Location = new System.Drawing.Point(90, 14);
            this.SDT_PROD_DATE_FROM.Name = "SDT_PROD_DATE_FROM";
            this.SDT_PROD_DATE_FROM.RawDate = "";
            this.SDT_PROD_DATE_FROM.Size = new System.Drawing.Size(95, 24);
            this.SDT_PROD_DATE_FROM.TabIndex = 127;
            // 
            // SDT_PROD_DATE_TO
            // 
            this.SDT_PROD_DATE_TO.Location = new System.Drawing.Point(191, 14);
            this.SDT_PROD_DATE_TO.Name = "SDT_PROD_DATE_TO";
            this.SDT_PROD_DATE_TO.RawDate = "";
            this.SDT_PROD_DATE_TO.Size = new System.Drawing.Size(95, 24);
            this.SDT_PROD_DATE_TO.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 125;
            this.label1.Text = "生产日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel40
            // 
            this.ULabel40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel40.Location = new System.Drawing.Point(331, 14);
            this.ULabel40.Name = "ULabel40";
            this.ULabel40.Size = new System.Drawing.Size(59, 22);
            this.ULabel40.TabIndex = 576;
            this.ULabel40.Text = "班次/别";
            this.ULabel40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(396, 14);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(42, 21);
            this.CBO_SHIFT.TabIndex = 577;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(444, 14);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(42, 21);
            this.CBO_GROUP.TabIndex = 578;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(90, 40);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(145, 22);
            this.TXT_MAT_NO.TabIndex = 580;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 579;
            this.label5.Text = "查询号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(331, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 581;
            this.label2.Text = "分段号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SEQ
            // 
            this.TXT_SEQ.Location = new System.Drawing.Point(396, 40);
            this.TXT_SEQ.MaxLength = 12;
            this.TXT_SEQ.Name = "TXT_SEQ";
            this.TXT_SEQ.Size = new System.Drawing.Size(90, 22);
            this.TXT_SEQ.TabIndex = 582;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(514, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 583;
            this.label3.Text = "已分线母板";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_NUM
            // 
            this.CBO_NUM.FormattingEnabled = true;
            this.CBO_NUM.Location = new System.Drawing.Point(514, 40);
            this.CBO_NUM.Name = "CBO_NUM";
            this.CBO_NUM.Size = new System.Drawing.Size(54, 21);
            this.CBO_NUM.TabIndex = 584;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(574, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 585;
            this.label4.Text = "块内";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(662, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 586;
            this.label6.Text = "是否有火切指示";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_GAS_FL
            // 
            this.CBO_GAS_FL.FormattingEnabled = true;
            this.CBO_GAS_FL.Location = new System.Drawing.Point(787, 14);
            this.CBO_GAS_FL.Name = "CBO_GAS_FL";
            this.CBO_GAS_FL.Size = new System.Drawing.Size(137, 21);
            this.CBO_GAS_FL.TabIndex = 587;
            // 
            // SSP4
            // 
            this.SSP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SSP4.Location = new System.Drawing.Point(662, 40);
            this.SSP4.Name = "SSP4";
            this.SSP4.Size = new System.Drawing.Size(75, 23);
            this.SSP4.TabIndex = 588;
            this.SSP4.Text = "重点订单";
            this.SSP4.UseVisualStyleBackColor = false;
            // 
            // SSP1
            // 
            this.SSP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SSP1.Location = new System.Drawing.Point(743, 40);
            this.SSP1.Name = "SSP1";
            this.SSP1.Size = new System.Drawing.Size(75, 23);
            this.SSP1.TabIndex = 589;
            this.SSP1.Text = "已选择";
            this.SSP1.UseVisualStyleBackColor = false;
            // 
            // SSP2
            // 
            this.SSP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SSP2.Location = new System.Drawing.Point(824, 40);
            this.SSP2.Name = "SSP2";
            this.SSP2.Size = new System.Drawing.Size(75, 23);
            this.SSP2.TabIndex = 590;
            this.SSP2.Text = "已分线";
            this.SSP2.UseVisualStyleBackColor = false;
            // 
            // SSP3
            // 
            this.SSP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SSP3.Location = new System.Drawing.Point(905, 40);
            this.SSP3.Name = "SSP3";
            this.SSP3.Size = new System.Drawing.Size(75, 23);
            this.SSP3.TabIndex = 591;
            this.SSP3.Text = "计划取样";
            this.SSP3.UseVisualStyleBackColor = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 73);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 549);
            this.ss1.TabIndex = 15;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ss1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ss1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // CGC2070C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGC2070C";
            this.Text = "母板分产线处理作业_CGC2070C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CommonClass.CeriUDate SDT_PROD_DATE_FROM;
        private CommonClass.CeriUDate SDT_PROD_DATE_TO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ULabel40;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SSP2;
        private System.Windows.Forms.Button SSP1;
        private System.Windows.Forms.Button SSP4;
        private System.Windows.Forms.ComboBox CBO_GAS_FL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_NUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_SEQ;
        private System.Windows.Forms.Button SSP3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
    }
}
