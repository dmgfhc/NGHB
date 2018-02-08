namespace CK
{
    partial class CKP1311C
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.SDT_PLAN_DATE = new CommonClass.CeriUDate();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.sdb_prod_shifts = new CommonClass.NumBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sdb_Mon_prod_wgt = new CommonClass.NumBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sdb_prod_wgt = new CommonClass.NumBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.SDT_PLAN_DATE);
            this.groupbox1.Controls.Add(this.txt_UserId);
            this.groupbox1.Controls.Add(this.sdb_prod_shifts);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.sdb_Mon_prod_wgt);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.sdb_prod_wgt);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupbox1.Location = new System.Drawing.Point(0, 0);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(1144, 59);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            // 
            // SDT_PLAN_DATE
            // 
            this.SDT_PLAN_DATE.Location = new System.Drawing.Point(127, 18);
            this.SDT_PLAN_DATE.Name = "SDT_PLAN_DATE";
            this.SDT_PLAN_DATE.RawDate = "";
            this.SDT_PLAN_DATE.Size = new System.Drawing.Size(96, 21);
            this.SDT_PLAN_DATE.TabIndex = 772;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(7, 17);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(23, 22);
            this.txt_UserId.TabIndex = 771;
            this.txt_UserId.Visible = false;
            // 
            // sdb_prod_shifts
            // 
            this.sdb_prod_shifts.Location = new System.Drawing.Point(881, 17);
            this.sdb_prod_shifts.Name = "sdb_prod_shifts";
            this.sdb_prod_shifts.NumValue = 0D;
            this.sdb_prod_shifts.Scale = 0;
            this.sdb_prod_shifts.ShowZero = true;
            this.sdb_prod_shifts.Size = new System.Drawing.Size(100, 22);
            this.sdb_prod_shifts.TabIndex = 770;
            this.sdb_prod_shifts.Text = "0";
            this.sdb_prod_shifts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(772, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 769;
            this.label4.Text = "年目标生产量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_Mon_prod_wgt
            // 
            this.sdb_Mon_prod_wgt.Location = new System.Drawing.Point(632, 18);
            this.sdb_Mon_prod_wgt.Name = "sdb_Mon_prod_wgt";
            this.sdb_Mon_prod_wgt.NumValue = 0D;
            this.sdb_Mon_prod_wgt.Scale = 0;
            this.sdb_Mon_prod_wgt.ShowZero = true;
            this.sdb_Mon_prod_wgt.Size = new System.Drawing.Size(100, 22);
            this.sdb_Mon_prod_wgt.TabIndex = 768;
            this.sdb_Mon_prod_wgt.Text = "0";
            this.sdb_Mon_prod_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(523, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 767;
            this.label3.Text = "年目标生产量";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_prod_wgt
            // 
            this.sdb_prod_wgt.Location = new System.Drawing.Point(361, 18);
            this.sdb_prod_wgt.Name = "sdb_prod_wgt";
            this.sdb_prod_wgt.NumValue = 0D;
            this.sdb_prod_wgt.Scale = 0;
            this.sdb_prod_wgt.ShowZero = true;
            this.sdb_prod_wgt.Size = new System.Drawing.Size(100, 22);
            this.sdb_prod_wgt.TabIndex = 766;
            this.sdb_prod_wgt.Text = "0";
            this.sdb_prod_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(252, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 765;
            this.label2.Text = "年目标生产量";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 763;
            this.label1.Text = "计划年月";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // CKP1311C
            // 
            this.ClientSize = new System.Drawing.Size(1144, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupbox1);
            this.Name = "CKP1311C";
            this.Text = "目标产量/作业时间录入界面_CKP1311C";
            this.Load += new System.EventHandler(this.CKP1311C_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private CommonClass.NumBox sdb_prod_wgt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserId;
        private CommonClass.NumBox sdb_prod_shifts;
        private System.Windows.Forms.Label label4;
        private CommonClass.NumBox sdb_Mon_prod_wgt;
        private System.Windows.Forms.Label label3;
        private CommonClass.CeriUDate SDT_PLAN_DATE;
    }
}
