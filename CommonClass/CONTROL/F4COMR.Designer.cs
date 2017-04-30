namespace CommonClass
{
    partial class F4COMR
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CD = new System.Windows.Forms.TextBox();
            this.CD_NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CD
            // 
            this.CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CD.Font = new System.Drawing.Font("宋体", 9.75F);
            this.CD.Location = new System.Drawing.Point(0, -1);
            this.CD.Name = "CD";
            this.CD.Size = new System.Drawing.Size(96, 22);
            this.CD.TabIndex = 0;
            this.CD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CD_KeyUp);
            // 
            // CD_NAME
            // 
            this.CD_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.CD_NAME.Font = new System.Drawing.Font("宋体", 9.75F);
            this.CD_NAME.Location = new System.Drawing.Point(97, -1);
            this.CD_NAME.Name = "CD_NAME";
            this.CD_NAME.Size = new System.Drawing.Size(136, 22);
            this.CD_NAME.TabIndex = 0;
            this.CD_NAME.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CD_KeyUp);
            // 
            // F4COMR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.CD);
            this.Controls.Add(this.CD_NAME);
            this.Name = "F4COMR";
            this.Size = new System.Drawing.Size(208, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox CD;
        public System.Windows.Forms.TextBox CD_NAME;
    }
}
