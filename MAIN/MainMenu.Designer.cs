namespace MAIN
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblscript = new System.Windows.Forms.LinkLabel();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.cmd_z = new System.Windows.Forms.Button();
            this.cmd_f = new System.Windows.Forms.Button();
            this.cmd_btn8 = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.fg1 = new CommonClass.FlexGrid_User(this.components);
            this.cmd_d = new System.Windows.Forms.Button();
            this.cmd_a = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(844, 7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 16);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 114;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox3.BackgroundImage")));
            this.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox3.Location = new System.Drawing.Point(0, 90);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(1024, 435);
            this.PictureBox3.TabIndex = 119;
            this.PictureBox3.TabStop = false;
            // 
            // lblscript
            // 
            this.lblscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblscript.ForeColor = System.Drawing.Color.Red;
            this.lblscript.LinkColor = System.Drawing.Color.IndianRed;
            this.lblscript.Location = new System.Drawing.Point(172, 596);
            this.lblscript.Name = "lblscript";
            this.lblscript.Size = new System.Drawing.Size(100, 21);
            this.lblscript.TabIndex = 113;
            this.lblscript.TabStop = true;
            this.lblscript.Text = "通知信息";
            this.lblscript.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblscript.Visible = false;
            this.lblscript.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblscript.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblscript_LinkClicked);
            // 
            // Picture1
            // 
            this.Picture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
            this.Picture1.Location = new System.Drawing.Point(27, 549);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(120, 120);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture1.TabIndex = 102;
            this.Picture1.TabStop = false;
            this.Picture1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture1_MouseMove);
            // 
            // Picture2
            // 
            this.Picture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture2.Image = ((System.Drawing.Image)(resources.GetObject("Picture2.Image")));
            this.Picture2.Location = new System.Drawing.Point(27, 550);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(120, 120);
            this.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture2.TabIndex = 103;
            this.Picture2.TabStop = false;
            this.Picture2.MouseLeave += new System.EventHandler(this.Picture2_MouseLeave);
            this.Picture2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // cmd_z
            // 
            this.cmd_z.BackColor = System.Drawing.Color.White;
            this.cmd_z.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd_z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_z.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_z.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmd_z.Image = ((System.Drawing.Image)(resources.GetObject("cmd_z.Image")));
            this.cmd_z.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_z.Location = new System.Drawing.Point(548, 549);
            this.cmd_z.Name = "cmd_z";
            this.cmd_z.Size = new System.Drawing.Size(124, 36);
            this.cmd_z.TabIndex = 105;
            this.cmd_z.Text = "公共";
            this.cmd_z.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_z.UseVisualStyleBackColor = false;
            this.cmd_z.Visible = false;
            this.cmd_z.Click += new System.EventHandler(this.cmd_z_Click);
            // 
            // cmd_f
            // 
            this.cmd_f.BackColor = System.Drawing.Color.White;
            this.cmd_f.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd_f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_f.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_f.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmd_f.Image = ((System.Drawing.Image)(resources.GetObject("cmd_f.Image")));
            this.cmd_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_f.Location = new System.Drawing.Point(424, 549);
            this.cmd_f.Name = "cmd_f";
            this.cmd_f.Size = new System.Drawing.Size(124, 36);
            this.cmd_f.TabIndex = 101;
            this.cmd_f.Tag = "";
            this.cmd_f.Text = "中心实验室";
            this.cmd_f.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_f.UseVisualStyleBackColor = false;
            this.cmd_f.Visible = false;
            this.cmd_f.Click += new System.EventHandler(this.cmd_f_Click);
            // 
            // cmd_btn8
            // 
            this.cmd_btn8.BackColor = System.Drawing.Color.White;
            this.cmd_btn8.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd_btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_btn8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_btn8.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmd_btn8.Image = ((System.Drawing.Image)(resources.GetObject("cmd_btn8.Image")));
            this.cmd_btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_btn8.Location = new System.Drawing.Point(672, 549);
            this.cmd_btn8.Name = "cmd_btn8";
            this.cmd_btn8.Size = new System.Drawing.Size(124, 36);
            this.cmd_btn8.TabIndex = 110;
            this.cmd_btn8.Text = "注销";
            this.cmd_btn8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_btn8.UseVisualStyleBackColor = false;
            this.cmd_btn8.Visible = false;
            this.cmd_btn8.Click += new System.EventHandler(this.cmd_btn8_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(864, 7);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(16, 16);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 115;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // fg1
            // 
            this.fg1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fg1.ColumnInfo = "10,0,0,0,0,0,Columns:";
            this.fg1.EnableCellChange = true;
            this.fg1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fg1.Location = new System.Drawing.Point(176, 620);
            this.fg1.Name = "fg1";
            this.fg1.Rows.DefaultSize = 18;
            this.fg1.Size = new System.Drawing.Size(620, 107);
            this.fg1.TabIndex = 121;
            this.fg1.Visible = false;
            this.fg1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            // 
            // cmd_d
            // 
            this.cmd_d.BackColor = System.Drawing.Color.White;
            this.cmd_d.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_d.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_d.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmd_d.Image = ((System.Drawing.Image)(resources.GetObject("cmd_d.Image")));
            this.cmd_d.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_d.Location = new System.Drawing.Point(300, 549);
            this.cmd_d.Name = "cmd_d";
            this.cmd_d.Size = new System.Drawing.Size(124, 36);
            this.cmd_d.TabIndex = 128;
            this.cmd_d.Text = "金属检验站";
            this.cmd_d.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_d.UseVisualStyleBackColor = false;
            this.cmd_d.Visible = false;
            this.cmd_d.Click += new System.EventHandler(this.cmd_d_Click);
            // 
            // cmd_a
            // 
            this.cmd_a.BackColor = System.Drawing.Color.White;
            this.cmd_a.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmd_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_a.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_a.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmd_a.Image = ((System.Drawing.Image)(resources.GetObject("cmd_a.Image")));
            this.cmd_a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmd_a.Location = new System.Drawing.Point(176, 549);
            this.cmd_a.Name = "cmd_a";
            this.cmd_a.Size = new System.Drawing.Size(124, 36);
            this.cmd_a.TabIndex = 127;
            this.cmd_a.Text = "原料室";
            this.cmd_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_a.UseVisualStyleBackColor = false;
            this.cmd_a.Visible = false;
            this.cmd_a.Click += new System.EventHandler(this.cmd_a_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.cmd_d);
            this.Controls.Add(this.cmd_a);
            this.Controls.Add(this.fg1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.lblscript);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.Picture2);
            this.Controls.Add(this.cmd_z);
            this.Controls.Add(this.cmd_btn8);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.cmd_f);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主程序";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg1)).EndInit();
            this.ResumeLayout(false);

        }



     
       
        
        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.LinkLabel lblscript;
        internal System.Windows.Forms.PictureBox Picture1;
        internal System.Windows.Forms.PictureBox Picture2;
        internal System.Windows.Forms.Button cmd_z;
        internal System.Windows.Forms.Button cmd_f;
        internal System.Windows.Forms.Button cmd_btn8;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private CommonClass.FlexGrid_User fg1;
        internal System.Windows.Forms.Button cmd_d;
        internal System.Windows.Forms.Button cmd_a;
    }
}

