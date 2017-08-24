namespace WK
{
    partial class WKA1010C
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_return = new System.Windows.Forms.RadioButton();
            this.rdo_delete = new System.Windows.Forms.RadioButton();
            this.rdo_move = new System.Windows.Forms.RadioButton();
            this.rdo_cancel = new System.Windows.Forms.RadioButton();
            this.rdo_send = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_slab_edt_seq = new System.Windows.Forms.TextBox();
            this.txt_slab_target = new System.Windows.Forms.TextBox();
            this.txt_slab_to = new System.Windows.Forms.TextBox();
            this.txt_slab_from = new System.Windows.Forms.TextBox();
            this.btn_roll_mana = new System.Windows.Forms.Button();
            this.btn_abnormal_send = new System.Windows.Forms.Button();
            this.rdo_target = new System.Windows.Forms.RadioButton();
            this.rdo_to = new System.Windows.Forms.RadioButton();
            this.rdo_from = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ss2 = new FarPoint.Win.Spread.FpSpread();
            this.ss2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdo_return);
            this.groupBox1.Controls.Add(this.rdo_delete);
            this.groupBox1.Controls.Add(this.rdo_move);
            this.groupBox1.Controls.Add(this.rdo_cancel);
            this.groupBox1.Controls.Add(this.rdo_send);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(788, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 15;
            this.label6.Tag = "USER";
            this.label6.Text = "生产中";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(664, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 14;
            this.label5.Tag = "USER";
            this.label5.Text = "已下达";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rdo_return
            // 
            this.rdo_return.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_return.Location = new System.Drawing.Point(403, 13);
            this.rdo_return.Name = "rdo_return";
            this.rdo_return.Size = new System.Drawing.Size(51, 22);
            this.rdo_return.TabIndex = 4;
            this.rdo_return.Text = "返送";
            this.rdo_return.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_return.UseVisualStyleBackColor = true;
            this.rdo_return.Click += new System.EventHandler(this.rdo_return_Click);
            // 
            // rdo_delete
            // 
            this.rdo_delete.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_delete.Location = new System.Drawing.Point(314, 13);
            this.rdo_delete.Name = "rdo_delete";
            this.rdo_delete.Size = new System.Drawing.Size(51, 22);
            this.rdo_delete.TabIndex = 3;
            this.rdo_delete.Text = "删除";
            this.rdo_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_delete.UseVisualStyleBackColor = true;
            this.rdo_delete.Click += new System.EventHandler(this.rdo_delete_Click);
            // 
            // rdo_move
            // 
            this.rdo_move.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_move.Location = new System.Drawing.Point(225, 13);
            this.rdo_move.Name = "rdo_move";
            this.rdo_move.Size = new System.Drawing.Size(51, 22);
            this.rdo_move.TabIndex = 2;
            this.rdo_move.Text = "调整";
            this.rdo_move.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_move.UseVisualStyleBackColor = true;
            this.rdo_move.Click += new System.EventHandler(this.rdo_move_Click);
            // 
            // rdo_cancel
            // 
            this.rdo_cancel.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_cancel.Location = new System.Drawing.Point(136, 13);
            this.rdo_cancel.Name = "rdo_cancel";
            this.rdo_cancel.Size = new System.Drawing.Size(51, 22);
            this.rdo_cancel.TabIndex = 1;
            this.rdo_cancel.Text = "取消";
            this.rdo_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_cancel.UseVisualStyleBackColor = true;
            this.rdo_cancel.Click += new System.EventHandler(this.rdo_cancel_Click);
            // 
            // rdo_send
            // 
            this.rdo_send.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_send.Location = new System.Drawing.Point(47, 13);
            this.rdo_send.Name = "rdo_send";
            this.rdo_send.Size = new System.Drawing.Size(51, 22);
            this.rdo_send.TabIndex = 0;
            this.rdo_send.Text = "发送";
            this.rdo_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_send.UseVisualStyleBackColor = true;
            this.rdo_send.Click += new System.EventHandler(this.rdo_send_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_slab_edt_seq);
            this.groupBox2.Controls.Add(this.txt_slab_target);
            this.groupBox2.Controls.Add(this.txt_slab_to);
            this.groupBox2.Controls.Add(this.txt_slab_from);
            this.groupBox2.Controls.Add(this.btn_roll_mana);
            this.groupBox2.Controls.Add(this.btn_abnormal_send);
            this.groupBox2.Controls.Add(this.rdo_target);
            this.groupBox2.Controls.Add(this.rdo_to);
            this.groupBox2.Controls.Add(this.rdo_from);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_slab_edt_seq
            // 
            this.txt_slab_edt_seq.Location = new System.Drawing.Point(583, 14);
            this.txt_slab_edt_seq.MaxLength = 10;
            this.txt_slab_edt_seq.Name = "txt_slab_edt_seq";
            this.txt_slab_edt_seq.Size = new System.Drawing.Size(23, 22);
            this.txt_slab_edt_seq.TabIndex = 18;
            this.txt_slab_edt_seq.Visible = false;
            // 
            // txt_slab_target
            // 
            this.txt_slab_target.Location = new System.Drawing.Point(458, 16);
            this.txt_slab_target.MaxLength = 10;
            this.txt_slab_target.Name = "txt_slab_target";
            this.txt_slab_target.Size = new System.Drawing.Size(85, 22);
            this.txt_slab_target.TabIndex = 8;
            // 
            // txt_slab_to
            // 
            this.txt_slab_to.Location = new System.Drawing.Point(279, 16);
            this.txt_slab_to.MaxLength = 10;
            this.txt_slab_to.Name = "txt_slab_to";
            this.txt_slab_to.Size = new System.Drawing.Size(85, 22);
            this.txt_slab_to.TabIndex = 6;
            // 
            // txt_slab_from
            // 
            this.txt_slab_from.Location = new System.Drawing.Point(100, 16);
            this.txt_slab_from.MaxLength = 10;
            this.txt_slab_from.Name = "txt_slab_from";
            this.txt_slab_from.Size = new System.Drawing.Size(85, 22);
            this.txt_slab_from.TabIndex = 5;
            // 
            // btn_roll_mana
            // 
            this.btn_roll_mana.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_roll_mana.ForeColor = System.Drawing.Color.Blue;
            this.btn_roll_mana.Location = new System.Drawing.Point(788, 12);
            this.btn_roll_mana.Name = "btn_roll_mana";
            this.btn_roll_mana.Size = new System.Drawing.Size(124, 26);
            this.btn_roll_mana.TabIndex = 4;
            this.btn_roll_mana.Text = "辊期编制";
            this.btn_roll_mana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_roll_mana.UseVisualStyleBackColor = true;
            this.btn_roll_mana.Visible = false;
            this.btn_roll_mana.Click += new System.EventHandler(this.btn_roll_mana_Click);
            // 
            // btn_abnormal_send
            // 
            this.btn_abnormal_send.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_abnormal_send.ForeColor = System.Drawing.Color.Red;
            this.btn_abnormal_send.Location = new System.Drawing.Point(664, 12);
            this.btn_abnormal_send.Name = "btn_abnormal_send";
            this.btn_abnormal_send.Size = new System.Drawing.Size(124, 26);
            this.btn_abnormal_send.TabIndex = 3;
            this.btn_abnormal_send.Text = "强制发送";
            this.btn_abnormal_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_abnormal_send.UseVisualStyleBackColor = true;
            this.btn_abnormal_send.Click += new System.EventHandler(this.btn_abnormal_send_Click);
            // 
            // rdo_target
            // 
            this.rdo_target.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_target.Location = new System.Drawing.Point(403, 16);
            this.rdo_target.Name = "rdo_target";
            this.rdo_target.Size = new System.Drawing.Size(51, 22);
            this.rdo_target.TabIndex = 2;
            this.rdo_target.Text = "目标板坯号";
            this.rdo_target.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_target.UseVisualStyleBackColor = true;
            this.rdo_target.Click += new System.EventHandler(this.rdo_target_Click);
            // 
            // rdo_to
            // 
            this.rdo_to.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdo_to.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_to.Location = new System.Drawing.Point(225, 16);
            this.rdo_to.Name = "rdo_to";
            this.rdo_to.Size = new System.Drawing.Size(51, 22);
            this.rdo_to.TabIndex = 1;
            this.rdo_to.Text = "->";
            this.rdo_to.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_to.UseVisualStyleBackColor = true;
            this.rdo_to.Click += new System.EventHandler(this.rdo_to_Click);
            // 
            // rdo_from
            // 
            this.rdo_from.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdo_from.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdo_from.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_from.Location = new System.Drawing.Point(47, 16);
            this.rdo_from.Name = "rdo_from";
            this.rdo_from.Size = new System.Drawing.Size(51, 22);
            this.rdo_from.TabIndex = 0;
            this.rdo_from.Text = "起始";
            this.rdo_from.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_from.UseVisualStyleBackColor = true;
            this.rdo_from.Click += new System.EventHandler(this.rdo_from_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ss2);
            this.groupBox4.Controls.Add(this.splitter1);
            this.groupBox4.Controls.Add(this.ss1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 528);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // ss2
            // 
            this.ss2.AccessibleDescription = "ss2, Sheet1, Row 0, Column 0, ";
            this.ss2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss2.Location = new System.Drawing.Point(518, 18);
            this.ss2.Name = "ss2";
            this.ss2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss2_Sheet1});
            this.ss2.Size = new System.Drawing.Size(497, 507);
            this.ss2.TabIndex = 5;
            // 
            // ss2_Sheet1
            // 
            this.ss2_Sheet1.Reset();
            this.ss2_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(514, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 507);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "ss1, Sheet1, Row 0, Column 0, ";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ss1.Location = new System.Drawing.Point(3, 18);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(511, 507);
            this.ss1.TabIndex = 0;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(534, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 16;
            this.label1.Tag = "USER";
            this.label1.Text = "超交货期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WKA1010C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "WKA1010C";
            this.Text = "指示调整_WKA1010C";
            this.Load += new System.EventHandler(this.WKA1010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_return;
        private System.Windows.Forms.RadioButton rdo_delete;
        private System.Windows.Forms.RadioButton rdo_move;
        private System.Windows.Forms.RadioButton rdo_cancel;
        private System.Windows.Forms.RadioButton rdo_send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_roll_mana;
        private System.Windows.Forms.Button btn_abnormal_send;
        private System.Windows.Forms.RadioButton rdo_target;
        private System.Windows.Forms.RadioButton rdo_from;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_slab_edt_seq;
        private System.Windows.Forms.TextBox txt_slab_target;
        private System.Windows.Forms.TextBox txt_slab_to;
        private System.Windows.Forms.TextBox txt_slab_from;
        private System.Windows.Forms.RadioButton rdo_to;
        private FarPoint.Win.Spread.FpSpread ss2;
        private FarPoint.Win.Spread.SheetView ss2_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private System.Windows.Forms.Label label1;


    }
}
