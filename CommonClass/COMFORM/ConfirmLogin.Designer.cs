namespace CommonClass
{
    partial class ConfirmLogin
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
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(114, 69);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Cancel.TabIndex = 20;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_Click);
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(16, 69);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(75, 23);
            this.Cmd_Ok.TabIndex = 19;
            this.Cmd_Ok.Text = "确认";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_Ok_Click);
            // 
            // Label2
            // 
            this.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(12, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 20);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "请输入新密码";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_newpassword.Location = new System.Drawing.Point(114, 9);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(89, 22);
            this.txt_newpassword.TabIndex = 15;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_confirm.Location = new System.Drawing.Point(114, 37);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar ='*';
            this.txt_confirm.Size = new System.Drawing.Size(89, 22);
            this.txt_confirm.TabIndex = 16;
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(12, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "请确认新密码";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmLogin
            // 
            this.KeyPress+=new System.Windows.Forms.KeyPressEventHandler(ConfirmLogin_KeyPress);
            this.Activated+=new System.EventHandler(ConfirmLogin_Activated);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(214, 100);
            this.Controls.Add(this.Cmd_Cancel);
            this.Controls.Add(this.Cmd_Ok);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("宋体", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Cancel;
        internal System.Windows.Forms.Button Cmd_Ok;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_newpassword;
        internal System.Windows.Forms.TextBox txt_confirm;
        internal System.Windows.Forms.Label Label1;

    }
}