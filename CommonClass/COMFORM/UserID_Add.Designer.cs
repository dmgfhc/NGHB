namespace CommonClass
{
    partial class UserID_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserID_Add));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmd_Cancel = new System.Windows.Forms.Button();
            this.Cmd_Ok = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmd_Del = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Cmd_Cancel);
            this.GroupBox1.Controls.Add(this.Cmd_Ok);
            this.GroupBox1.Controls.Add(this.txt_password);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txt_emp_id);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // Cmd_Cancel
            // 
            resources.ApplyResources(this.Cmd_Cancel, "Cmd_Cancel");
            this.Cmd_Cancel.Name = "Cmd_Cancel";
            this.Cmd_Cancel.UseVisualStyleBackColor = true;
            this.Cmd_Cancel.Click += new System.EventHandler(this.Cmd_Cancel_Click);
            // 
            // Cmd_Ok
            // 
            resources.ApplyResources(this.Cmd_Ok, "Cmd_Ok");
            this.Cmd_Ok.Name = "Cmd_Ok";
            this.Cmd_Ok.UseVisualStyleBackColor = true;
            this.Cmd_Ok.Click += new System.EventHandler(this.Cmd_Ok_Click);
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // Label2
            // 
            this.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // txt_emp_id
            // 
            resources.ApplyResources(this.txt_emp_id, "txt_emp_id");
            this.txt_emp_id.Name = "txt_emp_id";
            // 
            // Label1
            // 
            this.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // cmd_Del
            // 
            resources.ApplyResources(this.cmd_Del, "cmd_Del");
            this.cmd_Del.Name = "cmd_Del";
            this.cmd_Del.UseVisualStyleBackColor = true;
            this.cmd_Del.Click += new System.EventHandler(this.cmd_Del_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cmd_Del);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.GroupBox2, "GroupBox2");
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // UserID_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserID_Add";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.UserID_Add_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserID_Add_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Cmd_Cancel;
        internal System.Windows.Forms.Button Cmd_Ok;
        internal System.Windows.Forms.TextBox txt_password;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_emp_id;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmd_Del;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
    }
}