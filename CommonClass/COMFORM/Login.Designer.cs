namespace CommonClass
{
    partial class Login
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
            this.Cmd_Setup = new System.Windows.Forms.Button();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbl_Change = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbo_emp_id = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmd_Setup
            // 
            this.Cmd_Setup.Location = new System.Drawing.Point(252, 230);
            this.Cmd_Setup.Name = "Cmd_Setup";
            this.Cmd_Setup.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Setup.TabIndex = 20;
            this.Cmd_Setup.Text = "设定";
            this.Cmd_Setup.UseVisualStyleBackColor = true;
            this.Cmd_Setup.Click += new System.EventHandler(this.Cmd_Setup_Click);
            // 
            // Cmd_Cancel
            // 
            this.Cmd_Cancel.Location = new System.Drawing.Point(252, 201);
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Cancel.TabIndex = 19;
            this.Cmd_Cancel.Text = "取消";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_Click);
            // 
            // Cmd_Ok
            // 
            this.Cmd_Ok.Location = new System.Drawing.Point(252, 172);
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.Size = new System.Drawing.Size(92, 23);
            this.Cmd_Ok.TabIndex = 18;
            this.Cmd_Ok.Text = "确定";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_Ok_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 153);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(239, 39);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "帐户密码均为员工号.如果选项里没有您的工号,请点设定添加!";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Change
            // 
            this.lbl_Change.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Change.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Change.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Change.LinkColor = System.Drawing.Color.Gray;
            this.lbl_Change.Location = new System.Drawing.Point(188, 233);
            this.lbl_Change.Name = "lbl_Change";
            this.lbl_Change.Size = new System.Drawing.Size(60, 16);
            this.lbl_Change.TabIndex = 16;
            this.lbl_Change.TabStop = true;
            this.lbl_Change.Text = "修改密码";
            this.lbl_Change.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_Change.Click += new System.EventHandler(this.lbl_Change_Click);
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 229);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "密   码";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_emp_id
            // 
            this.cbo_emp_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_emp_id.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_emp_id.Location = new System.Drawing.Point(77, 201);
            this.cbo_emp_id.MaxDropDownItems = 10;
            this.cbo_emp_id.Name = "cbo_emp_id";
            this.cbo_emp_id.Size = new System.Drawing.Size(111, 23);
            this.cbo_emp_id.TabIndex = 13;
            this.cbo_emp_id.DropDown += new System.EventHandler(this.cbo_emp_id_DropDown);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(77, 229);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(111, 21);
            this.txt_password.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(6, 201);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "用户名";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.Cmd_Setup);
            this.Controls.Add(this.Cmd_Cancel);
            this.Controls.Add(this.Cmd_Ok);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbl_Change);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbo_emp_id);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.Label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cmd_Setup;
        internal System.Windows.Forms.Button Cmd_Cancel;
        internal System.Windows.Forms.Button Cmd_Ok;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.LinkLabel lbl_Change;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbo_emp_id;
        internal System.Windows.Forms.TextBox txt_password;
        internal System.Windows.Forms.Label Label5;
    }
}