namespace CG
{
    partial class WGE1020C
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_loc_to = new CommonClass.F4COMN();
            this.txt_loc_fr = new CommonClass.F4COMN();
            this.txt_plate_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cur_inv = new CommonClass.F4COMR();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sxt_select_cnt = new CommonClass.NumBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_loc_to);
            this.groupBox1.Controls.Add(this.txt_loc_fr);
            this.groupBox1.Controls.Add(this.txt_plate_no);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cur_inv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(517, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 14;
            this.label4.Tag = "user";
            this.label4.Text = "=====>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_loc_to
            // 
            this.txt_loc_to.Location = new System.Drawing.Point(645, 20);
            this.txt_loc_to.Name = "txt_loc_to";
            this.txt_loc_to.Size = new System.Drawing.Size(98, 22);
            this.txt_loc_to.sJoin = "";
            this.txt_loc_to.sKey = "F0044";
            this.txt_loc_to.TabIndex = 2;
            // 
            // txt_loc_fr
            // 
            this.txt_loc_fr.Location = new System.Drawing.Point(416, 20);
            this.txt_loc_fr.Name = "txt_loc_fr";
            this.txt_loc_fr.Size = new System.Drawing.Size(98, 22);
            this.txt_loc_fr.sJoin = "";
            this.txt_loc_fr.sKey = "F0044";
            this.txt_loc_fr.TabIndex = 1;
            // 
            // txt_plate_no
            // 
            this.txt_plate_no.Location = new System.Drawing.Point(893, 20);
            this.txt_plate_no.Name = "txt_plate_no";
            this.txt_plate_no.Size = new System.Drawing.Size(113, 22);
            this.txt_plate_no.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(822, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "钢板号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(575, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 4;
            this.label3.Tag = "f4";
            this.label3.Text = "目标垛位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(345, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 4;
            this.label2.Tag = "f4";
            this.label2.Text = "起始垛位";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Tag = "f4";
            this.label1.Text = "当前库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cur_inv
            // 
            this.txt_cur_inv.Location = new System.Drawing.Point(90, 20);
            this.txt_cur_inv.Name = "txt_cur_inv";
            this.txt_cur_inv.Size = new System.Drawing.Size(124, 22);
            this.txt_cur_inv.sJoin = "";
            this.txt_cur_inv.sKey = "C0013";
            this.txt_cur_inv.sMax = 0;
            this.txt_cur_inv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ss1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 569);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "起始垛位";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(508, 548);
            this.ss1.TabIndex = 11;
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sxt_select_cnt);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_move);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(522, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 569);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // sxt_select_cnt
            // 
            this.sxt_select_cnt.BackColor = System.Drawing.Color.White;
            this.sxt_select_cnt.Enabled = false;
            this.sxt_select_cnt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sxt_select_cnt.ForeColor = System.Drawing.Color.Crimson;
            this.sxt_select_cnt.Location = new System.Drawing.Point(15, 46);
            this.sxt_select_cnt.Name = "sxt_select_cnt";
            this.sxt_select_cnt.NumValue = 0D;
            this.sxt_select_cnt.Scale = 0;
            this.sxt_select_cnt.ShowZero = false;
            this.sxt_select_cnt.Size = new System.Drawing.Size(51, 30);
            this.sxt_select_cnt.TabIndex = 122;
            this.sxt_select_cnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(15, 268);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(51, 35);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(15, 184);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(51, 35);
            this.btn_move.TabIndex = 1;
            this.btn_move.Text = "移动";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(514, 53);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 569);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ss2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox4.Location = new System.Drawing.Point(612, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 569);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "目标垛位";
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(3, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(400, 548);
            this.ss2.TabIndex = 15;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter2
            // 
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(604, 53);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(8, 569);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
            // 
            // WGE1020C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WGE1020C";
            this.Text = "钢板在制品垛位管理_WGE1020C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private CommonClass.F4COMN txt_loc_to;
        private CommonClass.F4COMN txt_loc_fr;
        private System.Windows.Forms.TextBox txt_plate_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CommonClass.F4COMR txt_cur_inv;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox4;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private CommonClass.NumBox sxt_select_cnt;
        private System.Windows.Forms.Splitter splitter2;
    }
}
