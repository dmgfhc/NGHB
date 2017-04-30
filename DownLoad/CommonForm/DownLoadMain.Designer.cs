namespace DownLoad
{
    partial class DownLoadMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownLoadMain));
            this.PrgDown = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.Timer_Conut = new System.Windows.Forms.Timer(this.components);
            this.pic_Minsize = new System.Windows.Forms.PictureBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            //this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            //this.menuItem1 = new System.Windows.Forms.MenuItem();
            //this.menuItem2 = new System.Windows.Forms.MenuItem();
            //this.menuItem3 = new System.Windows.Forms.MenuItem();
            //this.menuItem4 = new System.Windows.Forms.MenuItem();
            //this.menuItem5 = new System.Windows.Forms.MenuItem();
            //this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // PrgDown
            // 
            this.PrgDown.Location = new System.Drawing.Point(24, 46);
            this.PrgDown.Name = "PrgDown";
            this.PrgDown.Size = new System.Drawing.Size(552, 16);
            this.PrgDown.TabIndex = 98;
            this.PrgDown.Value = 100;
            this.PrgDown.Visible = false;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label3.Location = new System.Drawing.Point(491, 99);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 24);
            this.Label3.TabIndex = 99;
            this.Label3.Text = "下载中.....";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Conut
            // 
            this.Timer_Conut.Tick += new System.EventHandler(this.Timer_Conut_Tick);
            // 
            // pic_Minsize
            // 
            this.pic_Minsize.Image = ((System.Drawing.Image)(resources.GetObject("pic_Minsize.Image")));
            this.pic_Minsize.Location = new System.Drawing.Point(540, 2);
            this.pic_Minsize.Name = "pic_Minsize";
            this.pic_Minsize.Size = new System.Drawing.Size(16, 16);
            this.pic_Minsize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Minsize.TabIndex = 101;
            this.pic_Minsize.TabStop = false;
            // 
            // pic_Close
            // 
            this.pic_Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_Close.Image")));
            this.pic_Close.Location = new System.Drawing.Point(560, 2);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(16, 16);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Close.TabIndex = 100;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            //// 
            //// contextMenu1
            //// 
            //this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            //this.menuItem1,
            //this.menuItem2,
            //this.menuItem3,
            //this.menuItem4,
            //this.menuItem5});
            //// 
            //// menuItem1
            //// 
            //this.menuItem1.Index = 0;
            //this.menuItem1.Text = "下载更新(&D)";
            //// 
            //// menuItem2
            //// 
            //this.menuItem2.Enabled = false;
            //this.menuItem2.Index = 1;
            //this.menuItem2.Text = "检查更新(&C)";
            //// 
            //// menuItem3
            //// 
            //this.menuItem3.Index = 2;
            //this.menuItem3.Text = "-";
            //// 
            //// menuItem4
            //// 
            //this.menuItem4.Enabled = false;
            //this.menuItem4.Index = 3;
            //this.menuItem4.Text = "还原(&R)";
            //this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            //// 
            //// menuItem5
            //// 
            //this.menuItem5.Index = 4;
            //this.menuItem5.Text = "关闭(&X)";
            //this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(205, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(244, 24);
            this.Label1.TabIndex = 102;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.Visible = false;
            // 
            // DownLoadMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 208);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pic_Minsize);
            this.Controls.Add(this.pic_Close);
            this.Controls.Add(this.PrgDown);
            this.Controls.Add(this.Label3);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownLoadMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainSystem";
            this.Load += new System.EventHandler(this.DownLoadMain_Load);
          //  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownLoadMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.ResumeLayout(false);

        }

      

     

       

        #endregion

        internal System.Windows.Forms.ProgressBar PrgDown;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Timer Timer_Conut;
        internal System.Windows.Forms.PictureBox pic_Minsize;
        internal System.Windows.Forms.PictureBox pic_Close;
        internal System.Windows.Forms.Label Label1;
    }
}

