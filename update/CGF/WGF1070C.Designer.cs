namespace CG
{
    partial class WGF1070C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGF1070C));
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBO_ROLL_TYPE = new System.Windows.Forms.ComboBox();
            this.CBO_ROLL_NO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDT_DATE_TO = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.SDT_DATE_FR = new CommonClass.CeriUDate();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 66);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1126, 345);
            this.ss1.TabIndex = 3;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBO_ROLL_TYPE);
            this.groupBox1.Controls.Add(this.CBO_ROLL_NO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDT_DATE_TO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SDT_DATE_FR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CBO_ROLL_TYPE
            // 
            this.CBO_ROLL_TYPE.FormattingEnabled = true;
            this.CBO_ROLL_TYPE.Items.AddRange(new object[] {
            "2：工作辊",
            "3：支撑辊"});
            this.CBO_ROLL_TYPE.Location = new System.Drawing.Point(880, 26);
            this.CBO_ROLL_TYPE.Name = "CBO_ROLL_TYPE";
            this.CBO_ROLL_TYPE.Size = new System.Drawing.Size(110, 21);
            this.CBO_ROLL_TYPE.TabIndex = 3;
            // 
            // CBO_ROLL_NO
            // 
            this.CBO_ROLL_NO.FormattingEnabled = true;
            this.CBO_ROLL_NO.Location = new System.Drawing.Point(576, 26);
            this.CBO_ROLL_NO.Name = "CBO_ROLL_NO";
            this.CBO_ROLL_NO.Size = new System.Drawing.Size(110, 21);
            this.CBO_ROLL_NO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "user";
            this.label2.Text = "~";
            // 
            // SDT_DATE_TO
            // 
            this.SDT_DATE_TO.Location = new System.Drawing.Point(260, 26);
            this.SDT_DATE_TO.Name = "SDT_DATE_TO";
            this.SDT_DATE_TO.RawDate = "";
            this.SDT_DATE_TO.Size = new System.Drawing.Size(110, 25);
            this.SDT_DATE_TO.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(786, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "轧辊辊型";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDT_DATE_FR
            // 
            this.SDT_DATE_FR.Location = new System.Drawing.Point(124, 26);
            this.SDT_DATE_FR.Name = "SDT_DATE_FR";
            this.SDT_DATE_FR.RawDate = "";
            this.SDT_DATE_FR.Size = new System.Drawing.Size(111, 25);
            this.SDT_DATE_FR.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(483, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "轧辊号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "磨削时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WGF1070C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 411);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WGF1070C";
            this.Text = "轧辊磨削实绩查询（按时间）_WGF1070C";
            this.Load += new System.EventHandler(this.WGF1070C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBO_ROLL_NO;
        private System.Windows.Forms.Label label2;
        private CommonClass.CeriUDate SDT_DATE_TO;
        private CommonClass.CeriUDate SDT_DATE_FR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBO_ROLL_TYPE;
        private System.Windows.Forms.Label label4;
    }
}