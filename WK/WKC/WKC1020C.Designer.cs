namespace WK
{
    partial class WKC1020C
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
            this.ss5 = new FarPoint.Win.Spread.FpSpread();
            this.ss5_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss4 = new FarPoint.Win.Spread.FpSpread();
            this.ss4_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.Cmd_Edit = new System.Windows.Forms.Button();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DATE = new CommonClass.CeriUDate();
            this.label9 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ss3 = new FarPoint.Win.Spread.FpSpread();
            this.ss3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss5_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ss5);
            this.panel1.Controls.Add(this.ss4);
            this.panel1.Controls.Add(this.Cmd_Edit);
            this.panel1.Controls.Add(this.CBO_PLT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DATE);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 34);
            this.panel1.TabIndex = 1;
            // 
            // ss5
            // 
            this.ss5.AccessibleDescription = "";
            this.ss5.Location = new System.Drawing.Point(839, 5);
            this.ss5.Name = "ss5";
            this.ss5.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss5_Sheet1});
            this.ss5.Size = new System.Drawing.Size(42, 20);
            this.ss5.TabIndex = 36;
            this.ss5.Visible = false;
            // 
            // ss5_Sheet1
            // 
            this.ss5_Sheet1.Reset();
            this.ss5_Sheet1.SheetName = "Sheet1";
            // 
            // ss4
            // 
            this.ss4.AccessibleDescription = "";
            this.ss4.Location = new System.Drawing.Point(922, 3);
            this.ss4.Name = "ss4";
            this.ss4.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss4_Sheet1});
            this.ss4.Size = new System.Drawing.Size(51, 22);
            this.ss4.TabIndex = 8;
            this.ss4.Visible = false;
            // 
            // ss4_Sheet1
            // 
            this.ss4_Sheet1.Reset();
            this.ss4_Sheet1.SheetName = "Sheet1";
            // 
            // Cmd_Edit
            // 
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
            // CBO_PLT
            // 
            this.CBO_PLT.Enabled = false;
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C2"});
            this.CBO_PLT.Location = new System.Drawing.Point(331, 5);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(36, 21);
            this.CBO_PLT.TabIndex = 34;
            this.CBO_PLT.Text = "C2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(256, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 33;
            this.label1.Tag = "";
            this.label1.Text = "工厂代码";
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
            this.label9.Text = "日期";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(0, 34);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 306);
            this.ss1.TabIndex = 2;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 340);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1018, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(0, 0);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(518, 279);
            this.ss2.TabIndex = 8;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // ss3
            // 
            this.ss3.AccessibleDescription = "";
            this.ss3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss3.Location = new System.Drawing.Point(0, 0);
            this.ss3.Name = "ss3";
            this.ss3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss3_Sheet1});
            this.ss3.Size = new System.Drawing.Size(500, 279);
            this.ss3.TabIndex = 10;
            // 
            // ss3_Sheet1
            // 
            this.ss3_Sheet1.Reset();
            this.ss3_Sheet1.SheetName = "Sheet1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ss2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 279);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ss3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(518, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 279);
            this.panel3.TabIndex = 13;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(518, 343);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 279);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // WKC1020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.panel1);
            this.Name = "WKC1020C";
            this.Text = "宽厚板卷厂生产日报_WKC1020C";
            this.Load += new System.EventHandler(this.WKC1020C_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss5_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cmd_Edit;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.Label label1;
        private CommonClass.CeriUDate txt_DATE;
        private System.Windows.Forms.Label label9;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Splitter splitter1;
        private FarPoint.Win.Spread.FpSpread ss4;
        private FarPoint.Win.Spread.SheetView ss4_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss5;
        private FarPoint.Win.Spread.SheetView ss5_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss3;
        private FarPoint.Win.Spread.SheetView ss3_Sheet1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter2;
    }
}
