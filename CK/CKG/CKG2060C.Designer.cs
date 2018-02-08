namespace CK
{
    partial class CKG2060C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cmd_Edit = new System.Windows.Forms.Button();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DATE = new CommonClass.CeriUDate();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_commect1 = new System.Windows.Forms.TextBox();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.txt_commect0 = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_commect4 = new System.Windows.Forms.TextBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.txt_commect3 = new System.Windows.Forms.TextBox();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_commect2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Cmd_Edit);
            this.panel1.Controls.Add(this.CBO_SHIFT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DATE);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 34);
            this.panel1.TabIndex = 2;
            // 
            // Cmd_Edit
            // 
            this.Cmd_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmd_Edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cmd_Edit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_Edit.Location = new System.Drawing.Point(484, 2);
            this.Cmd_Edit.Name = "Cmd_Edit";
            this.Cmd_Edit.Size = new System.Drawing.Size(116, 28);
            this.Cmd_Edit.TabIndex = 35;
            this.Cmd_Edit.Text = "更新数据";
            this.Cmd_Edit.UseVisualStyleBackColor = true;
            this.Cmd_Edit.Click += new System.EventHandler(this.Cmd_Edit_Click);
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(331, 5);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(36, 21);
            this.CBO_SHIFT.TabIndex = 34;
            this.CBO_SHIFT.Text = "1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(256, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 33;
            this.label1.Tag = "";
            this.label1.Text = "班次";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DATE
            // 
            this.txt_DATE.Location = new System.Drawing.Point(116, 5);
            this.txt_DATE.Name = "txt_DATE";
            this.txt_DATE.RawDate = "";
            this.txt_DATE.Size = new System.Drawing.Size(93, 21);
            this.txt_DATE.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(41, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 31;
            this.label9.Tag = "";
            this.label9.Text = "记录日期";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ss2);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.ss1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 136);
            this.panel2.TabIndex = 3;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(548, 0);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(470, 136);
            this.ss2.TabIndex = 2;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(545, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 136);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ss1.Location = new System.Drawing.Point(0, 0);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(545, 136);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 170);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1018, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_commect1);
            this.panel3.Controls.Add(this.splitter4);
            this.panel3.Controls.Add(this.txt_commect0);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 449);
            this.panel3.TabIndex = 5;
            // 
            // txt_commect1
            // 
            this.txt_commect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_commect1.Location = new System.Drawing.Point(0, 186);
            this.txt_commect1.Multiline = true;
            this.txt_commect1.Name = "txt_commect1";
            this.txt_commect1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_commect1.Size = new System.Drawing.Size(531, 263);
            this.txt_commect1.TabIndex = 2;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(0, 183);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(531, 3);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // txt_commect0
            // 
            this.txt_commect0.AllowDrop = true;
            this.txt_commect0.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_commect0.Location = new System.Drawing.Point(0, 0);
            this.txt_commect0.Multiline = true;
            this.txt_commect0.Name = "txt_commect0";
            this.txt_commect0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_commect0.Size = new System.Drawing.Size(531, 183);
            this.txt_commect0.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(531, 173);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 449);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.splitter5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(534, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 449);
            this.panel4.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_commect4);
            this.panel6.Controls.Add(this.splitter6);
            this.panel6.Controls.Add(this.txt_commect3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 306);
            this.panel6.TabIndex = 2;
            // 
            // txt_commect4
            // 
            this.txt_commect4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_commect4.Location = new System.Drawing.Point(0, 143);
            this.txt_commect4.Multiline = true;
            this.txt_commect4.Name = "txt_commect4";
            this.txt_commect4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_commect4.Size = new System.Drawing.Size(484, 163);
            this.txt_commect4.TabIndex = 2;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Location = new System.Drawing.Point(0, 140);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(484, 3);
            this.splitter6.TabIndex = 1;
            this.splitter6.TabStop = false;
            // 
            // txt_commect3
            // 
            this.txt_commect3.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_commect3.Location = new System.Drawing.Point(0, 0);
            this.txt_commect3.Multiline = true;
            this.txt_commect3.Name = "txt_commect3";
            this.txt_commect3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_commect3.Size = new System.Drawing.Size(484, 140);
            this.txt_commect3.TabIndex = 0;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(0, 140);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(484, 3);
            this.splitter5.TabIndex = 1;
            this.splitter5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_commect2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(484, 140);
            this.panel5.TabIndex = 0;
            // 
            // txt_commect2
            // 
            this.txt_commect2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_commect2.Location = new System.Drawing.Point(0, 0);
            this.txt_commect2.Multiline = true;
            this.txt_commect2.Name = "txt_commect2";
            this.txt_commect2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_commect2.Size = new System.Drawing.Size(484, 140);
            this.txt_commect2.TabIndex = 0;
            // 
            // CKG2060C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CKG2060C";
            this.Text = "中板厂生产工作记录表_CKG2060C";
            this.Load += new System.EventHandler(this.CKG2060C_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cmd_Edit;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate txt_DATE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Splitter splitter2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_commect1;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.TextBox txt_commect0;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_commect4;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.TextBox txt_commect3;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_commect2;
    }
}
