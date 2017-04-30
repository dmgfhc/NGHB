namespace FG
{
    partial class FKA1010C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_PrcLine = new System.Windows.Forms.ComboBox();
            this.COB_HTM_COND = new System.Windows.Forms.ComboBox();
            this.TXT_HTM_METH1 = new CommonClass.F4ETCN();
            this.TXT_SB = new CommonClass.F4ETCN();
            this.TXT_MAT_NO = new System.Windows.Forms.TextBox();
            this.TXT_PLT_NAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_PLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdo_delete = new System.Windows.Forms.RadioButton();
            this.rdo_cancel = new System.Windows.Forms.RadioButton();
            this.TXT_TOT_SHEETS = new System.Windows.Forms.TextBox();
            this.rdo_send = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_PrcLine);
            this.groupBox1.Controls.Add(this.COB_HTM_COND);
            this.groupBox1.Controls.Add(this.TXT_HTM_METH1);
            this.groupBox1.Controls.Add(this.TXT_SB);
            this.groupBox1.Controls.Add(this.TXT_MAT_NO);
            this.groupBox1.Controls.Add(this.TXT_PLT_NAME);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_PLT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbo_PrcLine
            // 
            this.cbo_PrcLine.Font = new System.Drawing.Font("宋体", 10.25F);
            this.cbo_PrcLine.FormattingEnabled = true;
            this.cbo_PrcLine.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbo_PrcLine.Location = new System.Drawing.Point(1019, 21);
            this.cbo_PrcLine.Name = "cbo_PrcLine";
            this.cbo_PrcLine.Size = new System.Drawing.Size(56, 22);
            this.cbo_PrcLine.TabIndex = 506;
            this.cbo_PrcLine.Text = "1";
            this.cbo_PrcLine.SelectedIndexChanged += new System.EventHandler(this.COB_HTM_COND_SelectedIndexChanged);
            // 
            // COB_HTM_COND
            // 
            this.COB_HTM_COND.Font = new System.Drawing.Font("宋体", 10.25F);
            this.COB_HTM_COND.FormattingEnabled = true;
            this.COB_HTM_COND.Location = new System.Drawing.Point(865, 20);
            this.COB_HTM_COND.Name = "COB_HTM_COND";
            this.COB_HTM_COND.Size = new System.Drawing.Size(56, 22);
            this.COB_HTM_COND.TabIndex = 506;
            this.COB_HTM_COND.SelectedIndexChanged += new System.EventHandler(this.COB_HTM_COND_SelectedIndexChanged);
            // 
            // TXT_HTM_METH1
            // 
            this.TXT_HTM_METH1.Location = new System.Drawing.Point(814, 20);
            this.TXT_HTM_METH1.Name = "TXT_HTM_METH1";
            this.TXT_HTM_METH1.sFcontrol = "CD";
            this.TXT_HTM_METH1.Size = new System.Drawing.Size(49, 22);
            this.TXT_HTM_METH1.sJoin = "";
            this.TXT_HTM_METH1.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\", CD_SHORT_ENG \"代码英文简称\", CD_F" +
                "ULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'Q0073\'";
            this.TXT_HTM_METH1.TabIndex = 3;
            // 
            // TXT_SB
            // 
            this.TXT_SB.Location = new System.Drawing.Point(601, 18);
            this.TXT_SB.Name = "TXT_SB";
            this.TXT_SB.sFcontrol = "CD";
            this.TXT_SB.Size = new System.Drawing.Size(73, 22);
            this.TXT_SB.sJoin = "";
            this.TXT_SB.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\", CD_SHORT_ENG \"代码英文简称\", CD_F" +
                "ULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'Q0074\'";
            this.TXT_SB.TabIndex = 3;
            // 
            // TXT_MAT_NO
            // 
            this.TXT_MAT_NO.Location = new System.Drawing.Point(355, 18);
            this.TXT_MAT_NO.MaxLength = 14;
            this.TXT_MAT_NO.Name = "TXT_MAT_NO";
            this.TXT_MAT_NO.Size = new System.Drawing.Size(144, 22);
            this.TXT_MAT_NO.TabIndex = 1;
            // 
            // TXT_PLT_NAME
            // 
            this.TXT_PLT_NAME.Location = new System.Drawing.Point(157, 18);
            this.TXT_PLT_NAME.Name = "TXT_PLT_NAME";
            this.TXT_PLT_NAME.ReadOnly = true;
            this.TXT_PLT_NAME.Size = new System.Drawing.Size(100, 22);
            this.TXT_PLT_NAME.TabIndex = 1;
            this.TXT_PLT_NAME.Text = "宽厚板厂";
            this.TXT_PLT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(692, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "热处理方法/条件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PLT
            // 
            this.TXT_PLT.Location = new System.Drawing.Point(100, 18);
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.ReadOnly = true;
            this.TXT_PLT.Size = new System.Drawing.Size(55, 22);
            this.TXT_PLT.TabIndex = 1;
            this.TXT_PLT.Text = "C2";
            this.TXT_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(512, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "抛丸";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(268, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "物料号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(932, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "产线别";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "工厂";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rdo_delete);
            this.groupBox2.Controls.Add(this.rdo_cancel);
            this.groupBox2.Controls.Add(this.TXT_TOT_SHEETS);
            this.groupBox2.Controls.Add(this.rdo_send);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(994, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 23);
            this.label35.TabIndex = 35;
            this.label35.Tag = "USER";
            this.label35.Text = "个";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(510, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 17;
            this.label6.Tag = "USER";
            this.label6.Text = "生产中";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(365, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 16;
            this.label7.Tag = "USER";
            this.label7.Text = "已下达";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rdo_delete
            // 
            this.rdo_delete.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_delete.Location = new System.Drawing.Point(223, 16);
            this.rdo_delete.Name = "rdo_delete";
            this.rdo_delete.Size = new System.Drawing.Size(59, 24);
            this.rdo_delete.TabIndex = 6;
            this.rdo_delete.Text = "删除";
            this.rdo_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_delete.UseVisualStyleBackColor = true;
            this.rdo_delete.Click += new System.EventHandler(this.rdo_delete_Click);
            // 
            // rdo_cancel
            // 
            this.rdo_cancel.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_cancel.Location = new System.Drawing.Point(133, 16);
            this.rdo_cancel.Name = "rdo_cancel";
            this.rdo_cancel.Size = new System.Drawing.Size(59, 24);
            this.rdo_cancel.TabIndex = 5;
            this.rdo_cancel.Text = "取消";
            this.rdo_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_cancel.UseVisualStyleBackColor = true;
            this.rdo_cancel.Click += new System.EventHandler(this.rdo_cancel_Click);
            // 
            // TXT_TOT_SHEETS
            // 
            this.TXT_TOT_SHEETS.Location = new System.Drawing.Point(929, 17);
            this.TXT_TOT_SHEETS.MaxLength = 14;
            this.TXT_TOT_SHEETS.Name = "TXT_TOT_SHEETS";
            this.TXT_TOT_SHEETS.Size = new System.Drawing.Size(67, 22);
            this.TXT_TOT_SHEETS.TabIndex = 1;
            this.TXT_TOT_SHEETS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdo_send
            // 
            this.rdo_send.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_send.Location = new System.Drawing.Point(40, 16);
            this.rdo_send.Name = "rdo_send";
            this.rdo_send.Size = new System.Drawing.Size(59, 24);
            this.rdo_send.TabIndex = 4;
            this.rdo_send.Text = "发送";
            this.rdo_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdo_send.UseVisualStyleBackColor = true;
            this.rdo_send.Click += new System.EventHandler(this.rdo_send_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(730, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "宽厚板热处理（等待/生产）";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 104);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1136, 346);
            this.ss1.TabIndex = 2;
            this.ss1.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.ss1_SelectionChanged);
            this.ss1.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ss1_CellClick);
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // FKA1010C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FKA1010C";
            this.Text = "热处理作业指示下达及调整界面_FKA1010C";
            this.Load += new System.EventHandler(this.FKA1010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_PLT_NAME;
        private System.Windows.Forms.TextBox TXT_PLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CommonClass.F4ETCN TXT_SB;
        private CommonClass.F4ETCN TXT_HTM_METH1;
        private System.Windows.Forms.TextBox TXT_MAT_NO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_delete;
        private System.Windows.Forms.RadioButton rdo_cancel;
        private System.Windows.Forms.RadioButton rdo_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_TOT_SHEETS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label35;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.ComboBox COB_HTM_COND;
        private System.Windows.Forms.ComboBox cbo_PrcLine;
    }
}