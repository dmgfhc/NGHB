namespace CommonClass
{
    partial class DataDic
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
            this.pnl_button = new System.Windows.Forms.Panel();
            this.cmd_close = new System.Windows.Forms.Button();
            this.cmd_selection = new System.Windows.Forms.Button();
            this.cmd_refresh = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_condition = new System.Windows.Forms.Panel();
            this.ssWhere = new FlexGrid_User();
            this.pnl_result = new System.Windows.Forms.Panel();
            this.ssResult = new FlexGrid_User();
            this.pnl_button.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_condition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere)).BeginInit();
            this.pnl_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_button
            // 
            this.pnl_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_button.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_button.Controls.Add(this.cmd_close);
            this.pnl_button.Controls.Add(this.cmd_selection);
            this.pnl_button.Controls.Add(this.cmd_refresh);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_button.Location = new System.Drawing.Point(0, 0);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(406, 43);
            this.pnl_button.TabIndex = 5;
            // 
            // cmd_close
            // 
            this.cmd_close.Location = new System.Drawing.Point(231, 3);
            this.cmd_close.Name = "cmd_close";
            this.cmd_close.Size = new System.Drawing.Size(104, 32);
            this.cmd_close.TabIndex = 5;
            this.cmd_close.Text = "关闭";
            this.cmd_close.UseVisualStyleBackColor = true;
            this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
            // 
            // cmd_selection
            // 
            this.cmd_selection.Location = new System.Drawing.Point(119, 3);
            this.cmd_selection.Name = "cmd_selection";
            this.cmd_selection.Size = new System.Drawing.Size(104, 32);
            this.cmd_selection.TabIndex = 4;
            this.cmd_selection.Text = "选择";
            this.cmd_selection.UseVisualStyleBackColor = true;
            this.cmd_selection.Click += new System.EventHandler(this.cmd_selection_Click);
            // 
            // cmd_refresh
            // 
            this.cmd_refresh.Location = new System.Drawing.Point(6, 3);
            this.cmd_refresh.Name = "cmd_refresh";
            this.cmd_refresh.Size = new System.Drawing.Size(104, 32);
            this.cmd_refresh.TabIndex = 3;
            this.cmd_refresh.Text = "刷新";
            this.cmd_refresh.UseVisualStyleBackColor = true;
            this.cmd_refresh.Click += new System.EventHandler(this.cmd_refresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_condition);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl_result);
            this.splitContainer1.Size = new System.Drawing.Size(406, 455);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 6;
            // 
            // pnl_condition
            // 
            this.pnl_condition.Controls.Add(this.ssWhere);
            this.pnl_condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_condition.Location = new System.Drawing.Point(0, 0);
            this.pnl_condition.Name = "pnl_condition";
            this.pnl_condition.Size = new System.Drawing.Size(406, 114);
            this.pnl_condition.TabIndex = 0;
            // 
            // ssWhere
            // 
            this.ssWhere.KeyDown+=new System.Windows.Forms.KeyEventHandler(ssWhere_KeyDown);
            this.ssWhere.ColumnInfo = "10,1,0,0,0,0,Columns:";
            this.ssWhere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssWhere.Location = new System.Drawing.Point(0, 0);
            this.ssWhere.Name = "ssWhere";
            this.ssWhere.Rows.DefaultSize = 18;
            this.ssWhere.Size = new System.Drawing.Size(406, 114);
            this.ssWhere.TabIndex = 1;
            // 
            // pnl_result
            // 
            this.pnl_result.Controls.Add(this.ssResult);
            this.pnl_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_result.Location = new System.Drawing.Point(0, 0);
            this.pnl_result.Name = "pnl_result";
            this.pnl_result.Size = new System.Drawing.Size(406, 337);
            this.pnl_result.TabIndex = 0;
            // 
            // ssResult
            // 
            this.ssResult.KeyUp+=new System.Windows.Forms.KeyEventHandler(ssResult_KeyUp);
          //  this.ssResult.
            this.ssResult.ColumnInfo = "10,1,0,0,0,0,Columns:";
            this.ssResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssResult.Location = new System.Drawing.Point(0, 0);
            this.ssResult.Name = "ssResult";
            this.ssResult.Rows.DefaultSize = 18;
            this.ssResult.Size = new System.Drawing.Size(406, 337);
            this.ssResult.TabIndex = 1;
            this.ssResult.DoubleClick += new System.EventHandler(this.ssResult_DoubleClick);
            // 
            // DataDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_button);
            this.Name = "DataDic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据字典";
            this.Resize += new System.EventHandler(this.DataDic_Resize);
            this.Activated += new System.EventHandler(this.DataDic_Activated);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataDic_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataDic_KeyDown);
            this.Load += new System.EventHandler(this.DataDic_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(DataDic_FormClosing);
            this.pnl_button.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnl_condition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere)).EndInit();
            this.pnl_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssResult)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        internal System.Windows.Forms.Panel pnl_button;
        internal System.Windows.Forms.Button cmd_close;
        internal System.Windows.Forms.Button cmd_selection;
        internal System.Windows.Forms.Button cmd_refresh;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_condition;
        internal FlexGrid_User ssWhere;
        private System.Windows.Forms.Panel pnl_result;
        internal FlexGrid_User ssResult;
    }
}