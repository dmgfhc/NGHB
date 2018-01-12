namespace CK
{
    partial class WKC1010C
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SDT_PLAN_DATE = new CommonClass.MaskedDate();
            this.sdb_Mon_prod_wgt = new CommonClass.NumBox();
            this.sdb_prod_wgt = new CommonClass.NumBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdb_MILL_ELECT = new CommonClass.NumBox();
            this.label19 = new System.Windows.Forms.Label();
            this.sdb_MILL_OPER = new CommonClass.NumBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sdb_MILL_PLAN = new CommonClass.NumBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sdb_MILL_NON_PLAN = new CommonClass.NumBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sdb_MILL_MACH = new CommonClass.NumBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sdb_Prod_Rate = new CommonClass.NumBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sdb_Mon_sms_wgt = new CommonClass.NumBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sdb_sms_wgt = new CommonClass.NumBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SDT_PLAN_DATE);
            this.panel1.Controls.Add(this.sdb_Mon_prod_wgt);
            this.panel1.Controls.Add(this.sdb_prod_wgt);
            this.panel1.Controls.Add(this.sdb_Mon_sms_wgt);
            this.panel1.Controls.Add(this.sdb_sms_wgt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 40);
            this.panel1.TabIndex = 0;
            // 
            // SDT_PLAN_DATE
            // 
            this.SDT_PLAN_DATE.Location = new System.Drawing.Point(132, 9);
            this.SDT_PLAN_DATE.Mask = "0000-00-00 90:00:00";
            this.SDT_PLAN_DATE.Name = "SDT_PLAN_DATE";
            this.SDT_PLAN_DATE.Size = new System.Drawing.Size(54, 22);
            this.SDT_PLAN_DATE.TabIndex = 14;
            // 
            // sdb_Mon_prod_wgt
            // 
            this.sdb_Mon_prod_wgt.Location = new System.Drawing.Point(536, 9);
            this.sdb_Mon_prod_wgt.Name = "sdb_Mon_prod_wgt";
            this.sdb_Mon_prod_wgt.NumValue = 0D;
            this.sdb_Mon_prod_wgt.Scale = 0;
            this.sdb_Mon_prod_wgt.ShowZero = true;
            this.sdb_Mon_prod_wgt.Size = new System.Drawing.Size(83, 22);
            this.sdb_Mon_prod_wgt.TabIndex = 13;
            this.sdb_Mon_prod_wgt.Text = "0";
            this.sdb_Mon_prod_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sdb_prod_wgt
            // 
            this.sdb_prod_wgt.Location = new System.Drawing.Point(324, 9);
            this.sdb_prod_wgt.Name = "sdb_prod_wgt";
            this.sdb_prod_wgt.NumValue = 0D;
            this.sdb_prod_wgt.Scale = 0;
            this.sdb_prod_wgt.ShowZero = true;
            this.sdb_prod_wgt.Size = new System.Drawing.Size(83, 22);
            this.sdb_prod_wgt.TabIndex = 12;
            this.sdb_prod_wgt.Text = "0";
            this.sdb_prod_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(420, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "月目标生产量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "年目标生产量";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "计划年月";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss1.Location = new System.Drawing.Point(0, 40);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1303, 527);
            this.ss1.TabIndex = 1;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.sdb_MILL_ELECT);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.sdb_MILL_OPER);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.sdb_MILL_PLAN);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.sdb_MILL_NON_PLAN);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.sdb_MILL_MACH);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.sdb_Prod_Rate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 55);
            this.panel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(479, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 48);
            this.label8.TabIndex = 48;
            this.label8.Tag = "USER";
            this.label8.Text = "计划停时";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(171, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 48);
            this.label7.TabIndex = 47;
            this.label7.Tag = "USER";
            this.label7.Text = "故障停时";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_MILL_ELECT
            // 
            this.sdb_MILL_ELECT.Location = new System.Drawing.Point(313, 30);
            this.sdb_MILL_ELECT.Name = "sdb_MILL_ELECT";
            this.sdb_MILL_ELECT.NumValue = 0D;
            this.sdb_MILL_ELECT.Scale = 0;
            this.sdb_MILL_ELECT.ShowZero = true;
            this.sdb_MILL_ELECT.Size = new System.Drawing.Size(71, 22);
            this.sdb_MILL_ELECT.TabIndex = 44;
            this.sdb_MILL_ELECT.Text = "0";
            this.sdb_MILL_ELECT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(313, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 22);
            this.label19.TabIndex = 43;
            this.label19.Text = "轧钢电气";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_MILL_OPER
            // 
            this.sdb_MILL_OPER.Location = new System.Drawing.Point(387, 30);
            this.sdb_MILL_OPER.Name = "sdb_MILL_OPER";
            this.sdb_MILL_OPER.NumValue = 0D;
            this.sdb_MILL_OPER.Scale = 0;
            this.sdb_MILL_OPER.ShowZero = true;
            this.sdb_MILL_OPER.Size = new System.Drawing.Size(71, 22);
            this.sdb_MILL_OPER.TabIndex = 40;
            this.sdb_MILL_OPER.Text = "0";
            this.sdb_MILL_OPER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(387, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 22);
            this.label17.TabIndex = 39;
            this.label17.Text = "轧钢操作";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_MILL_PLAN
            // 
            this.sdb_MILL_PLAN.Location = new System.Drawing.Point(547, 29);
            this.sdb_MILL_PLAN.Name = "sdb_MILL_PLAN";
            this.sdb_MILL_PLAN.NumValue = 0D;
            this.sdb_MILL_PLAN.Scale = 0;
            this.sdb_MILL_PLAN.ShowZero = true;
            this.sdb_MILL_PLAN.Size = new System.Drawing.Size(71, 22);
            this.sdb_MILL_PLAN.TabIndex = 38;
            this.sdb_MILL_PLAN.Text = "0";
            this.sdb_MILL_PLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(547, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 22);
            this.label16.TabIndex = 37;
            this.label16.Text = "轧钢";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_MILL_NON_PLAN
            // 
            this.sdb_MILL_NON_PLAN.Location = new System.Drawing.Point(707, 28);
            this.sdb_MILL_NON_PLAN.Name = "sdb_MILL_NON_PLAN";
            this.sdb_MILL_NON_PLAN.NumValue = 0D;
            this.sdb_MILL_NON_PLAN.Scale = 0;
            this.sdb_MILL_NON_PLAN.ShowZero = true;
            this.sdb_MILL_NON_PLAN.Size = new System.Drawing.Size(71, 22);
            this.sdb_MILL_NON_PLAN.TabIndex = 34;
            this.sdb_MILL_NON_PLAN.Text = "0";
            this.sdb_MILL_NON_PLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(707, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "轧钢";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_MILL_MACH
            // 
            this.sdb_MILL_MACH.Location = new System.Drawing.Point(239, 30);
            this.sdb_MILL_MACH.Name = "sdb_MILL_MACH";
            this.sdb_MILL_MACH.NumValue = 0D;
            this.sdb_MILL_MACH.Scale = 0;
            this.sdb_MILL_MACH.ShowZero = true;
            this.sdb_MILL_MACH.Size = new System.Drawing.Size(71, 22);
            this.sdb_MILL_MACH.TabIndex = 26;
            this.sdb_MILL_MACH.Text = "0";
            this.sdb_MILL_MACH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(239, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 22);
            this.label15.TabIndex = 25;
            this.label15.Text = "轧钢机械";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(639, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 48);
            this.label9.TabIndex = 14;
            this.label9.Tag = "USER";
            this.label9.Text = "外部停时";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_Prod_Rate
            // 
            this.sdb_Prod_Rate.Location = new System.Drawing.Point(35, 30);
            this.sdb_Prod_Rate.Name = "sdb_Prod_Rate";
            this.sdb_Prod_Rate.NumValue = 0D;
            this.sdb_Prod_Rate.Scale = 0;
            this.sdb_Prod_Rate.ShowZero = true;
            this.sdb_Prod_Rate.Size = new System.Drawing.Size(114, 22);
            this.sdb_Prod_Rate.TabIndex = 11;
            this.sdb_Prod_Rate.Text = "0";
            this.sdb_Prod_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(35, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "轧钢产品成材率";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdb_Mon_sms_wgt
            // 
            this.sdb_Mon_sms_wgt.Location = new System.Drawing.Point(1192, 12);
            this.sdb_Mon_sms_wgt.Name = "sdb_Mon_sms_wgt";
            this.sdb_Mon_sms_wgt.NumValue = 0D;
            this.sdb_Mon_sms_wgt.Scale = 0;
            this.sdb_Mon_sms_wgt.ShowZero = true;
            this.sdb_Mon_sms_wgt.Size = new System.Drawing.Size(10, 22);
            this.sdb_Mon_sms_wgt.TabIndex = 11;
            this.sdb_Mon_sms_wgt.Text = "0";
            this.sdb_Mon_sms_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sdb_Mon_sms_wgt.Visible = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1173, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "月计划钢产量";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1137, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "年计划钢产量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // sdb_sms_wgt
            // 
            this.sdb_sms_wgt.Location = new System.Drawing.Point(1157, 12);
            this.sdb_sms_wgt.Name = "sdb_sms_wgt";
            this.sdb_sms_wgt.NumValue = 0D;
            this.sdb_sms_wgt.Scale = 0;
            this.sdb_sms_wgt.ShowZero = true;
            this.sdb_sms_wgt.Size = new System.Drawing.Size(10, 22);
            this.sdb_sms_wgt.TabIndex = 10;
            this.sdb_sms_wgt.Text = "0";
            this.sdb_sms_wgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sdb_sms_wgt.Visible = false;
            // 
            // WKC1010C
            // 
            this.ClientSize = new System.Drawing.Size(1303, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.panel1);
            this.Name = "WKC1010C";
            this.Text = "宽厚板厂月作业计划查询及修改界面_WKC1010C";
            this.Load += new System.EventHandler(this.WKC1010C_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private CommonClass.NumBox sdb_Mon_prod_wgt;
        private CommonClass.NumBox sdb_prod_wgt;
        private CommonClass.MaskedDate SDT_PLAN_DATE;
        private System.Windows.Forms.Panel panel2;
        private CommonClass.NumBox sdb_MILL_MACH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private CommonClass.NumBox sdb_Prod_Rate;
        private System.Windows.Forms.Label label6;
        private CommonClass.NumBox sdb_MILL_ELECT;
        private System.Windows.Forms.Label label19;
        private CommonClass.NumBox sdb_MILL_OPER;
        private System.Windows.Forms.Label label17;
        private CommonClass.NumBox sdb_MILL_PLAN;
        private System.Windows.Forms.Label label16;
        private CommonClass.NumBox sdb_MILL_NON_PLAN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CommonClass.NumBox sdb_Mon_sms_wgt;
        private CommonClass.NumBox sdb_sms_wgt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
