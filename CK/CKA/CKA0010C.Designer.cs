using System.Windows.Forms;


namespace CK
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CKA0010C : CommonClass.FORMBASE
		{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                this.f4ETCR1 = new CommonClass.F4ETCR();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.f4ETCR2 = new CommonClass.F4ETCR();
                this.GroupBox1 = new System.Windows.Forms.GroupBox();
                this.txt_EmpId2 = new System.Windows.Forms.TextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.cmb_dept1 = new System.Windows.Forms.ComboBox();
                this.label2 = new System.Windows.Forms.Label();
                this.txt_EmpId1 = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.txt_EmpId = new System.Windows.Forms.TextBox();
                this.cmb_dept = new System.Windows.Forms.ComboBox();
                this.lbl_DEPT = new System.Windows.Forms.Label();
                this.lbl_EMP = new System.Windows.Forms.Label();
                this.Splitter2 = new System.Windows.Forms.Splitter();
                this.ss1 = new FarPoint.Win.Spread.FpSpread();
                this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
                this.GroupBox1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
                this.SuspendLayout();
                // 
                // f4ETCR1
                // 
                this.f4ETCR1.InputControl = this.f4ETCR1;
                this.f4ETCR1.Location = new System.Drawing.Point(615, 30);
                this.f4ETCR1.Name = "f4ETCR1";
                this.f4ETCR1.Size = new System.Drawing.Size(100, 21);
                this.f4ETCR1.sJoin = "";
                this.f4ETCR1.sSqletc = "select cd_mana_no, cd_mana_name from bbb_cd_master";
                this.f4ETCR1.TabIndex = 52;
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(721, 31);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(65, 21);
                this.textBox1.TabIndex = 51;
                // 
                // f4ETCR2
                // 
                this.f4ETCR2.InputControl = this.f4ETCR2;
                this.f4ETCR2.Location = new System.Drawing.Point(615, 3);
                this.f4ETCR2.Name = "f4ETCR2";
                this.f4ETCR2.Size = new System.Drawing.Size(126, 21);
                this.f4ETCR2.sJoin = "";
                this.f4ETCR2.sSqletc = "SELECT CD_MANA_NO AS 代码管理号,CD_MANA_NAME AS 代码管理名  FROM BBB_CD_MASTER";
                this.f4ETCR2.TabIndex = 57;
                // 
                // GroupBox1
                // 
                this.GroupBox1.Controls.Add(this.txt_EmpId2);
                this.GroupBox1.Controls.Add(this.label3);
                this.GroupBox1.Controls.Add(this.cmb_dept1);
                this.GroupBox1.Controls.Add(this.label2);
                this.GroupBox1.Controls.Add(this.txt_EmpId1);
                this.GroupBox1.Controls.Add(this.label1);
                this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
                this.GroupBox1.Location = new System.Drawing.Point(0, 0);
                this.GroupBox1.Name = "GroupBox1";
                this.GroupBox1.Size = new System.Drawing.Size(1024, 56);
                this.GroupBox1.TabIndex = 3;
                this.GroupBox1.TabStop = false;
                this.GroupBox1.Tag = "SYS";
                // 
                // txt_EmpId2
                // 
                this.txt_EmpId2.Location = new System.Drawing.Point(404, 20);
                this.txt_EmpId2.Name = "txt_EmpId2";
                this.txt_EmpId2.Size = new System.Drawing.Size(134, 22);
                this.txt_EmpId2.TabIndex = 56;
                // 
                // label3
                // 
                this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.label3.Location = new System.Drawing.Point(268, 20);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(130, 22);
                this.label3.TabIndex = 55;
                this.label3.Tag = "";
                this.label3.Text = "用  户  姓  名";
                this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // cmb_dept1
                // 
                this.cmb_dept1.FormattingEnabled = true;
                this.cmb_dept1.Location = new System.Drawing.Point(722, 20);
                this.cmb_dept1.Name = "cmb_dept1";
                this.cmb_dept1.Size = new System.Drawing.Size(131, 21);
                this.cmb_dept1.TabIndex = 54;
                // 
                // label2
                // 
                this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.label2.Location = new System.Drawing.Point(620, 20);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(96, 22);
                this.label2.TabIndex = 53;
                this.label2.Text = "部　　门";
                this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // txt_EmpId1
                // 
                this.txt_EmpId1.Location = new System.Drawing.Point(114, 20);
                this.txt_EmpId1.Name = "txt_EmpId1";
                this.txt_EmpId1.Size = new System.Drawing.Size(134, 22);
                this.txt_EmpId1.TabIndex = 52;
                // 
                // label1
                // 
                this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.label1.Location = new System.Drawing.Point(12, 20);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(96, 22);
                this.label1.TabIndex = 49;
                this.label1.Tag = "";
                this.label1.Text = "用  户";
                this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // txt_EmpId
                // 
                this.txt_EmpId.Location = new System.Drawing.Point(131, 31);
                this.txt_EmpId.Name = "txt_EmpId";
                this.txt_EmpId.Size = new System.Drawing.Size(154, 21);
                this.txt_EmpId.TabIndex = 51;
                // 
                // cmb_dept
                // 
                this.cmb_dept.FormattingEnabled = true;
                this.cmb_dept.Location = new System.Drawing.Point(460, 31);
                this.cmb_dept.Name = "cmb_dept";
                this.cmb_dept.Size = new System.Drawing.Size(131, 20);
                this.cmb_dept.TabIndex = 50;
                // 
                // lbl_DEPT
                // 
                this.lbl_DEPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.lbl_DEPT.Location = new System.Drawing.Point(355, 31);
                this.lbl_DEPT.Name = "lbl_DEPT";
                this.lbl_DEPT.Size = new System.Drawing.Size(96, 22);
                this.lbl_DEPT.TabIndex = 48;
                this.lbl_DEPT.Text = "部　　门";
                this.lbl_DEPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // lbl_EMP
                // 
                this.lbl_EMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.lbl_EMP.Location = new System.Drawing.Point(29, 31);
                this.lbl_EMP.Name = "lbl_EMP";
                this.lbl_EMP.Size = new System.Drawing.Size(96, 22);
                this.lbl_EMP.TabIndex = 48;
                this.lbl_EMP.Tag = "";
                this.lbl_EMP.Text = "用  户";
                this.lbl_EMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Splitter2
                // 
                this.Splitter2.BackColor = System.Drawing.Color.CornflowerBlue;
                this.Splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
                this.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Splitter2.Location = new System.Drawing.Point(3, 79);
                this.Splitter2.Name = "Splitter2";
                this.Splitter2.Size = new System.Drawing.Size(1018, 1);
                this.Splitter2.TabIndex = 46;
                this.Splitter2.TabStop = false;
                // 
                // ss1
                // 
                this.ss1.AccessibleDescription = "";
                this.ss1.AllowColumnMove = true;
                this.ss1.AllowDragDrop = true;
                this.ss1.AllowDragFill = true;
                this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ss1.Location = new System.Drawing.Point(0, 56);
                this.ss1.Name = "ss1";
                this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
                this.ss1.Size = new System.Drawing.Size(1024, 566);
                this.ss1.TabIndex = 115;
                // 
                // ss1_Sheet1
                // 
                this.ss1_Sheet1.Reset();
                this.ss1_Sheet1.SheetName = "Sheet1";
                // 
                // CGA0010C
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1024, 622);
                this.Controls.Add(this.ss1);
                this.Controls.Add(this.GroupBox1);
                this.Name = "CGA0010C";
                this.Text = "[用户管理]-[WZA0010C]";
                this.Load += new System.EventHandler(this.Form_Load);
                this.GroupBox1.ResumeLayout(false);
                this.GroupBox1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Splitter Splitter2;
		internal System.Windows.Forms.Label lbl_EMP;
		internal System.Windows.Forms.Label lbl_DEPT;
		internal System.Windows.Forms.ComboBox cmb_dept;
		internal System.Windows.Forms.TextBox txt_EmpId;
		internal FarPoint.Win.Spread.FpSpread ss1;
        internal FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private CommonClass.F4ETCR f4ETCR1;
        internal TextBox textBox1;
        internal CommonClass.F4ETCR f4ETCR2;
        internal TextBox txt_EmpId1;
        internal Label label1;
        internal ComboBox cmb_dept1;
        internal Label label2;
        internal TextBox txt_EmpId2;
        internal Label label3;
	}
	
}
