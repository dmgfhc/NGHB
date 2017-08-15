namespace CG
{
    partial class CGF2090C
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
            this.SDB_SEQ_NO = new System.Windows.Forms.TextBox();
            this.TXT_EMP_CD = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.CBO_ROLL_ID = new System.Windows.Forms.ComboBox();
            this.CBO_PLT = new System.Windows.Forms.ComboBox();
            this.CBO_GROUP = new System.Windows.Forms.ComboBox();
            this.CBO_SHIFT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ULabel26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ROLL_PRICE = new CommonClass.NumBox();
            this.SDB_AFT_GRID_DIA = new CommonClass.NumBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MTRLNO = new System.Windows.Forms.TextBox();
            this.txt_ISSUETALLYNO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SDB_ROLL_WGT = new CommonClass.NumBox();
            this.SDB_ROLL_DIA = new CommonClass.NumBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_ROLL_DH_DATE = new CommonClass.MaskedDate();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SDB_SEQ_NO);
            this.groupBox1.Controls.Add(this.TXT_EMP_CD);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.CBO_ROLL_ID);
            this.groupBox1.Controls.Add(this.CBO_PLT);
            this.groupBox1.Controls.Add(this.CBO_GROUP);
            this.groupBox1.Controls.Add(this.CBO_SHIFT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ULabel26);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SDB_SEQ_NO
            // 
            this.SDB_SEQ_NO.Location = new System.Drawing.Point(227, 18);
            this.SDB_SEQ_NO.MaxLength = 20;
            this.SDB_SEQ_NO.Name = "SDB_SEQ_NO";
            this.SDB_SEQ_NO.Size = new System.Drawing.Size(50, 22);
            this.SDB_SEQ_NO.TabIndex = 728;
            // 
            // TXT_EMP_CD
            // 
            this.TXT_EMP_CD.Location = new System.Drawing.Point(815, 18);
            this.TXT_EMP_CD.MaxLength = 7;
            this.TXT_EMP_CD.Name = "TXT_EMP_CD";
            this.TXT_EMP_CD.Size = new System.Drawing.Size(100, 22);
            this.TXT_EMP_CD.TabIndex = 727;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label40.Location = new System.Drawing.Point(734, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(75, 19);
            this.label40.TabIndex = 624;
            this.label40.Text = "作业人员";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBO_ROLL_ID
            // 
            this.CBO_ROLL_ID.FormattingEnabled = true;
            this.CBO_ROLL_ID.Location = new System.Drawing.Point(116, 18);
            this.CBO_ROLL_ID.MaxLength = 7;
            this.CBO_ROLL_ID.Name = "CBO_ROLL_ID";
            this.CBO_ROLL_ID.Size = new System.Drawing.Size(105, 21);
            this.CBO_ROLL_ID.TabIndex = 622;
            this.CBO_ROLL_ID.TextChanged += new System.EventHandler(this.CBO_ROLL_ID_TextChanged);
            // 
            // CBO_PLT
            // 
            this.CBO_PLT.FormattingEnabled = true;
            this.CBO_PLT.Items.AddRange(new object[] {
            "C3"});
            this.CBO_PLT.Location = new System.Drawing.Point(388, 18);
            this.CBO_PLT.Name = "CBO_PLT";
            this.CBO_PLT.Size = new System.Drawing.Size(43, 21);
            this.CBO_PLT.TabIndex = 3;
            // 
            // CBO_GROUP
            // 
            this.CBO_GROUP.FormattingEnabled = true;
            this.CBO_GROUP.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CBO_GROUP.Location = new System.Drawing.Point(665, 18);
            this.CBO_GROUP.Name = "CBO_GROUP";
            this.CBO_GROUP.Size = new System.Drawing.Size(46, 21);
            this.CBO_GROUP.TabIndex = 1;
            // 
            // CBO_SHIFT
            // 
            this.CBO_SHIFT.FormattingEnabled = true;
            this.CBO_SHIFT.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBO_SHIFT.Location = new System.Drawing.Point(521, 18);
            this.CBO_SHIFT.Name = "CBO_SHIFT";
            this.CBO_SHIFT.Size = new System.Drawing.Size(49, 21);
            this.CBO_SHIFT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(599, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "班别";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(455, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(298, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "工厂代码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel26
            // 
            this.ULabel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel26.Location = new System.Drawing.Point(26, 18);
            this.ULabel26.Name = "ULabel26";
            this.ULabel26.Size = new System.Drawing.Size(84, 19);
            this.ULabel26.TabIndex = 0;
            this.ULabel26.Text = "轧辊号";
            this.ULabel26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ROLL_PRICE);
            this.groupBox2.Controls.Add(this.SDB_AFT_GRID_DIA);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_MTRLNO);
            this.groupBox2.Controls.Add(this.txt_ISSUETALLYNO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SDB_ROLL_WGT);
            this.groupBox2.Controls.Add(this.SDB_ROLL_DIA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXT_ROLL_DH_DATE);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1243, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 轧辊堆焊实绩";
            // 
            // txt_ROLL_PRICE
            // 
            this.txt_ROLL_PRICE.Location = new System.Drawing.Point(116, 49);
            this.txt_ROLL_PRICE.MaxLength = 10;
            this.txt_ROLL_PRICE.Name = "txt_ROLL_PRICE";
            this.txt_ROLL_PRICE.NumValue = 0D;
            this.txt_ROLL_PRICE.Scale = 2;
            this.txt_ROLL_PRICE.ShowZero = false;
            this.txt_ROLL_PRICE.Size = new System.Drawing.Size(144, 22);
            this.txt_ROLL_PRICE.TabIndex = 734;
            this.txt_ROLL_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_AFT_GRID_DIA
            // 
            this.SDB_AFT_GRID_DIA.Location = new System.Drawing.Point(886, 18);
            this.SDB_AFT_GRID_DIA.MaxLength = 10;
            this.SDB_AFT_GRID_DIA.Name = "SDB_AFT_GRID_DIA";
            this.SDB_AFT_GRID_DIA.NumValue = 0D;
            this.SDB_AFT_GRID_DIA.Scale = 3;
            this.SDB_AFT_GRID_DIA.ShowZero = false;
            this.SDB_AFT_GRID_DIA.Size = new System.Drawing.Size(132, 22);
            this.SDB_AFT_GRID_DIA.TabIndex = 733;
            this.SDB_AFT_GRID_DIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1024, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 732;
            this.label11.Text = "mm";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(796, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 731;
            this.label9.Text = "堆焊前辊径";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MTRLNO
            // 
            this.txt_MTRLNO.Location = new System.Drawing.Point(654, 49);
            this.txt_MTRLNO.MaxLength = 20;
            this.txt_MTRLNO.Name = "txt_MTRLNO";
            this.txt_MTRLNO.Size = new System.Drawing.Size(126, 22);
            this.txt_MTRLNO.TabIndex = 730;
            // 
            // txt_ISSUETALLYNO
            // 
            this.txt_ISSUETALLYNO.Location = new System.Drawing.Point(654, 18);
            this.txt_ISSUETALLYNO.MaxLength = 15;
            this.txt_ISSUETALLYNO.Name = "txt_ISSUETALLYNO";
            this.txt_ISSUETALLYNO.Size = new System.Drawing.Size(126, 22);
            this.txt_ISSUETALLYNO.TabIndex = 729;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(564, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 727;
            this.label8.Text = "料号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(564, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 726;
            this.label7.Text = "验收单号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SDB_ROLL_WGT
            // 
            this.SDB_ROLL_WGT.Location = new System.Drawing.Point(388, 49);
            this.SDB_ROLL_WGT.MaxLength = 10;
            this.SDB_ROLL_WGT.Name = "SDB_ROLL_WGT";
            this.SDB_ROLL_WGT.NumValue = 0D;
            this.SDB_ROLL_WGT.Scale = 3;
            this.SDB_ROLL_WGT.ShowZero = false;
            this.SDB_ROLL_WGT.Size = new System.Drawing.Size(132, 22);
            this.SDB_ROLL_WGT.TabIndex = 725;
            this.SDB_ROLL_WGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SDB_ROLL_DIA
            // 
            this.SDB_ROLL_DIA.Location = new System.Drawing.Point(388, 18);
            this.SDB_ROLL_DIA.MaxLength = 10;
            this.SDB_ROLL_DIA.Name = "SDB_ROLL_DIA";
            this.SDB_ROLL_DIA.NumValue = 0D;
            this.SDB_ROLL_DIA.Scale = 3;
            this.SDB_ROLL_DIA.ShowZero = false;
            this.SDB_ROLL_DIA.Size = new System.Drawing.Size(132, 22);
            this.SDB_ROLL_DIA.TabIndex = 724;
            this.SDB_ROLL_DIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(298, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 723;
            this.label6.Text = "堆焊辊径";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 722;
            this.label1.Text = "堆焊辊径";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_ROLL_DH_DATE
            // 
            this.TXT_ROLL_DH_DATE.Location = new System.Drawing.Point(116, 18);
            this.TXT_ROLL_DH_DATE.Mask = "0000-00-00 90:00:00";
            this.TXT_ROLL_DH_DATE.Name = "TXT_ROLL_DH_DATE";
            this.TXT_ROLL_DH_DATE.Size = new System.Drawing.Size(144, 22);
            this.TXT_ROLL_DH_DATE.TabIndex = 721;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(526, 46);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(21, 13);
            this.label37.TabIndex = 688;
            this.label37.Text = "kg";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(526, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 13);
            this.label36.TabIndex = 687;
            this.label36.Text = "mm";
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Location = new System.Drawing.Point(26, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 19);
            this.label34.TabIndex = 683;
            this.label34.Text = "堆焊金额";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(26, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 19);
            this.label35.TabIndex = 677;
            this.label35.Text = "堆焊时间";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 138);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1243, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ss1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1243, 435);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1237, 414);
            this.ss1.TabIndex = 2;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGF2090C
            // 
            this.ClientSize = new System.Drawing.Size(1243, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGF2090C";
            this.Text = "轧辊堆焊实绩查询及修改界面_CGF2090C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBO_GROUP;
        private System.Windows.Forms.ComboBox CBO_SHIFT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ULabel26;
        private System.Windows.Forms.ComboBox CBO_PLT;
        private System.Windows.Forms.ComboBox CBO_ROLL_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox TXT_EMP_CD;
        private System.Windows.Forms.TextBox SDB_SEQ_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CommonClass.MaskedDate TXT_ROLL_DH_DATE;
        private CommonClass.NumBox txt_ROLL_PRICE;
        private CommonClass.NumBox SDB_AFT_GRID_DIA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MTRLNO;
        private System.Windows.Forms.TextBox txt_ISSUETALLYNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CommonClass.NumBox SDB_ROLL_WGT;
        private CommonClass.NumBox SDB_ROLL_DIA;
    }
}
