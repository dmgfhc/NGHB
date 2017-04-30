namespace CG
{
    partial class CGA2100C
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
            this.txt_act_stlgrd = new CommonClass.F4ETCR();
            this.txt_act_stlgrd_dec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_slab_fl = new System.Windows.Forms.TextBox();
            this.opt_nuse = new System.Windows.Forms.RadioButton();
            this.opt_fault = new System.Windows.Forms.RadioButton();
            this.sdt_prod_date_to = new CommonClass.CeriUDate();
            this.sdt_prod_date_from = new CommonClass.CeriUDate();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_heat_no = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_act_stlgrd
            // 
            bControlFiledSetting1.ColumnID = "STLGRD";
            bControlFiledSetting1.TargetControl = this.txt_act_stlgrd;
            bControlFiledSetting2.ColumnID = "STEEL_GRD_DETAIL";
            bControlFiledSetting2.TargetControl = this.txt_act_stlgrd_dec;
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting1);
            this.txt_act_stlgrd.CustomSetting.Add(bControlFiledSetting2);
            this.txt_act_stlgrd.InputControl = this.txt_act_stlgrd;
            this.txt_act_stlgrd.Location = new System.Drawing.Point(93, 52);
            this.txt_act_stlgrd.Name = "txt_act_stlgrd";
            this.txt_act_stlgrd.Size = new System.Drawing.Size(108, 22);
            this.txt_act_stlgrd.sJoin = "";
            this.txt_act_stlgrd.sSqletc = "SELECT  STLGRD \"钢种\", STEEL_GRD_DETAIL \"目标说明\" FROM NISCO.QP_NISCO_CHMC  WHERE STLG" +
                "RD LIKE \'%\' AND NVL(STEEL_GRD_DETAIL,\'%\') LIKE \'%\'   ORDER  BY  STLGRD  ASC ";
            this.txt_act_stlgrd.TabIndex = 575;
            this.txt_act_stlgrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_act_stlgrd_dec
            // 
            this.txt_act_stlgrd_dec.Enabled = false;
            this.txt_act_stlgrd_dec.Location = new System.Drawing.Point(207, 52);
            this.txt_act_stlgrd_dec.Name = "txt_act_stlgrd_dec";
            this.txt_act_stlgrd_dec.Size = new System.Drawing.Size(112, 22);
            this.txt_act_stlgrd_dec.TabIndex = 576;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_slab_fl);
            this.groupBox1.Controls.Add(this.opt_nuse);
            this.groupBox1.Controls.Add(this.opt_fault);
            this.groupBox1.Controls.Add(this.sdt_prod_date_to);
            this.groupBox1.Controls.Add(this.sdt_prod_date_from);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd_dec);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_heat_no);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_slab_fl
            // 
            this.txt_slab_fl.Location = new System.Drawing.Point(549, 12);
            this.txt_slab_fl.MaxLength = 11;
            this.txt_slab_fl.Name = "txt_slab_fl";
            this.txt_slab_fl.Size = new System.Drawing.Size(39, 22);
            this.txt_slab_fl.TabIndex = 583;
            this.txt_slab_fl.Visible = false;
            // 
            // opt_nuse
            // 
            this.opt_nuse.AutoSize = true;
            this.opt_nuse.Location = new System.Drawing.Point(413, 18);
            this.opt_nuse.Name = "opt_nuse";
            this.opt_nuse.Size = new System.Drawing.Size(90, 17);
            this.opt_nuse.TabIndex = 582;
            this.opt_nuse.Text = "保留使用板";
            this.opt_nuse.UseVisualStyleBackColor = true;
            this.opt_nuse.Visible = false;
            // 
            // opt_fault
            // 
            this.opt_fault.AutoSize = true;
            this.opt_fault.Checked = true;
            this.opt_fault.Location = new System.Drawing.Point(343, 18);
            this.opt_fault.Name = "opt_fault";
            this.opt_fault.Size = new System.Drawing.Size(64, 17);
            this.opt_fault.TabIndex = 581;
            this.opt_fault.TabStop = true;
            this.opt_fault.Text = "缺陷板";
            this.opt_fault.UseVisualStyleBackColor = true;
            this.opt_fault.Visible = false;
            this.opt_fault.CheckedChanged += new System.EventHandler(this.opt_fault_CheckedChanged);
            // 
            // sdt_prod_date_to
            // 
            this.sdt_prod_date_to.Font = new System.Drawing.Font("宋体", 11F);
            this.sdt_prod_date_to.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_prod_date_to.Location = new System.Drawing.Point(549, 49);
            this.sdt_prod_date_to.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdt_prod_date_to.Name = "sdt_prod_date_to";
            this.sdt_prod_date_to.RawDate = "";
            this.sdt_prod_date_to.Size = new System.Drawing.Size(112, 24);
            this.sdt_prod_date_to.TabIndex = 580;
            this.sdt_prod_date_to.Tag = "结束时间";
            // 
            // sdt_prod_date_from
            // 
            this.sdt_prod_date_from.Font = new System.Drawing.Font("宋体", 11F);
            this.sdt_prod_date_from.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sdt_prod_date_from.Location = new System.Drawing.Point(435, 49);
            this.sdt_prod_date_from.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdt_prod_date_from.Name = "sdt_prod_date_from";
            this.sdt_prod_date_from.RawDate = "";
            this.sdt_prod_date_from.Size = new System.Drawing.Size(108, 24);
            this.sdt_prod_date_from.TabIndex = 579;
            this.sdt_prod_date_from.Tag = "开始时间";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(343, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 578;
            this.label4.Text = "入库日期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 577;
            this.label3.Text = "钢种";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 474;
            this.label2.Tag = "f4";
            this.label2.Text = "转炉号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_heat_no
            // 
            this.txt_heat_no.Location = new System.Drawing.Point(93, 18);
            this.txt_heat_no.MaxLength = 8;
            this.txt_heat_no.Name = "txt_heat_no";
            this.txt_heat_no.Size = new System.Drawing.Size(102, 22);
            this.txt_heat_no.TabIndex = 473;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 536);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "板坯检验";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1004, 503);
            this.ss1.TabIndex = 2;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ss2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "板坯退判";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 3);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(1004, 503);
            this.ss2.TabIndex = 4;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2100C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2100C";
            this.Text = "板坯检验及退判实绩_CGA2100C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_heat_no;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_act_stlgrd_dec;
        public CommonClass.F4ETCR txt_act_stlgrd;
        public CommonClass.CeriUDate sdt_prod_date_to;
        public CommonClass.CeriUDate sdt_prod_date_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_slab_fl;
        private System.Windows.Forms.RadioButton opt_nuse;
        private System.Windows.Forms.RadioButton opt_fault;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
    }
}
