namespace CG
{
    partial class CGA2110C
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
            CommonClass.BControlFiledSetting bControlFiledSetting1 = new CommonClass.BControlFiledSetting();
            CommonClass.BControlFiledSetting bControlFiledSetting2 = new CommonClass.BControlFiledSetting();
            this.txt_plt = new CommonClass.F4ETCR();
            this.txt_plt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_len_to = new CommonClass.NumBox();
            this.txt_len = new CommonClass.NumBox();
            this.txt_wid_to = new CommonClass.NumBox();
            this.txt_wid = new CommonClass.NumBox();
            this.txt_thk_to = new CommonClass.NumBox();
            this.txt_thk = new CommonClass.NumBox();
            this.ULabel8 = new System.Windows.Forms.Label();
            this.ULabel5 = new System.Windows.Forms.Label();
            this.ULabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LOC = new System.Windows.Forms.TextBox();
            this.txt_act_stlgrd = new CommonClass.F4ETCR();
            this.txt_act_stlgrd_dec = new System.Windows.Forms.TextBox();
            this.ULabel3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MOSLAB = new System.Windows.Forms.TextBox();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_plt
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.txt_plt;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.txt_plt_name;
            this.txt_plt.CustomSetting.Add(bControlFiledSetting1);
            this.txt_plt.CustomSetting.Add(bControlFiledSetting2);
            this.txt_plt.InputControl = this.txt_plt;
            this.txt_plt.Location = new System.Drawing.Point(99, 50);
            this.txt_plt.MaxLength = 2;
            this.txt_plt.Name = "txt_plt";
            this.txt_plt.Size = new System.Drawing.Size(40, 22);
            this.txt_plt.sJoin = "";
            this.txt_plt.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
                "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
                "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.txt_plt.TabIndex = 556;
            this.txt_plt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plt_name
            // 
            this.txt_plt_name.Enabled = false;
            this.txt_plt_name.Location = new System.Drawing.Point(145, 50);
            this.txt_plt_name.Name = "txt_plt_name";
            this.txt_plt_name.Size = new System.Drawing.Size(71, 22);
            this.txt_plt_name.TabIndex = 557;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_len_to);
            this.groupBox1.Controls.Add(this.txt_len);
            this.groupBox1.Controls.Add(this.txt_wid_to);
            this.groupBox1.Controls.Add(this.txt_wid);
            this.groupBox1.Controls.Add(this.txt_thk_to);
            this.groupBox1.Controls.Add(this.txt_thk);
            this.groupBox1.Controls.Add(this.ULabel8);
            this.groupBox1.Controls.Add(this.ULabel5);
            this.groupBox1.Controls.Add(this.ULabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_LOC);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd);
            this.groupBox1.Controls.Add(this.txt_act_stlgrd_dec);
            this.groupBox1.Controls.Add(this.ULabel3);
            this.groupBox1.Controls.Add(this.txt_plt_name);
            this.groupBox1.Controls.Add(this.txt_plt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MOSLAB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_len_to
            // 
            this.txt_len_to.Location = new System.Drawing.Point(629, 86);
            this.txt_len_to.Name = "txt_len_to";
            this.txt_len_to.NumValue = 0D;
            this.txt_len_to.Scale = 0;
            this.txt_len_to.ShowZero = true;
            this.txt_len_to.Size = new System.Drawing.Size(60, 22);
            this.txt_len_to.TabIndex = 571;
            this.txt_len_to.Text = "0";
            this.txt_len_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_len
            // 
            this.txt_len.Location = new System.Drawing.Point(563, 86);
            this.txt_len.Name = "txt_len";
            this.txt_len.NumValue = 0D;
            this.txt_len.Scale = 0;
            this.txt_len.ShowZero = true;
            this.txt_len.Size = new System.Drawing.Size(60, 22);
            this.txt_len.TabIndex = 570;
            this.txt_len.Text = "0";
            this.txt_len.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_wid_to
            // 
            this.txt_wid_to.Location = new System.Drawing.Point(392, 86);
            this.txt_wid_to.Name = "txt_wid_to";
            this.txt_wid_to.NumValue = 0D;
            this.txt_wid_to.Scale = 0;
            this.txt_wid_to.ShowZero = true;
            this.txt_wid_to.Size = new System.Drawing.Size(60, 22);
            this.txt_wid_to.TabIndex = 569;
            this.txt_wid_to.Text = "0";
            this.txt_wid_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_wid
            // 
            this.txt_wid.Location = new System.Drawing.Point(320, 86);
            this.txt_wid.Name = "txt_wid";
            this.txt_wid.NumValue = 0D;
            this.txt_wid.Scale = 0;
            this.txt_wid.ShowZero = true;
            this.txt_wid.Size = new System.Drawing.Size(66, 22);
            this.txt_wid.TabIndex = 568;
            this.txt_wid.Text = "0";
            this.txt_wid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_thk_to
            // 
            this.txt_thk_to.Location = new System.Drawing.Point(156, 86);
            this.txt_thk_to.Name = "txt_thk_to";
            this.txt_thk_to.NumValue = 0D;
            this.txt_thk_to.Scale = 0;
            this.txt_thk_to.ShowZero = true;
            this.txt_thk_to.Size = new System.Drawing.Size(49, 22);
            this.txt_thk_to.TabIndex = 567;
            this.txt_thk_to.Text = "0";
            this.txt_thk_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_thk
            // 
            this.txt_thk.Location = new System.Drawing.Point(99, 86);
            this.txt_thk.Name = "txt_thk";
            this.txt_thk.NumValue = 0D;
            this.txt_thk.Scale = 0;
            this.txt_thk.ShowZero = true;
            this.txt_thk.Size = new System.Drawing.Size(51, 22);
            this.txt_thk.TabIndex = 566;
            this.txt_thk.Text = "0";
            this.txt_thk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ULabel8
            // 
            this.ULabel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel8.Location = new System.Drawing.Point(477, 86);
            this.ULabel8.Name = "ULabel8";
            this.ULabel8.Size = new System.Drawing.Size(80, 22);
            this.ULabel8.TabIndex = 565;
            this.ULabel8.Text = "长度";
            this.ULabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel5
            // 
            this.ULabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel5.Location = new System.Drawing.Point(235, 86);
            this.ULabel5.Name = "ULabel5";
            this.ULabel5.Size = new System.Drawing.Size(84, 22);
            this.ULabel5.TabIndex = 564;
            this.ULabel5.Text = "宽度";
            this.ULabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ULabel2
            // 
            this.ULabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel2.Location = new System.Drawing.Point(12, 86);
            this.ULabel2.Name = "ULabel2";
            this.ULabel2.Size = new System.Drawing.Size(81, 22);
            this.ULabel2.TabIndex = 563;
            this.ULabel2.Text = "厚度";
            this.ULabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(553, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 562;
            this.label1.Tag = "f4";
            this.label1.Text = "垛位号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_LOC
            // 
            this.txt_LOC.Location = new System.Drawing.Point(640, 50);
            this.txt_LOC.MaxLength = 11;
            this.txt_LOC.Name = "txt_LOC";
            this.txt_LOC.Size = new System.Drawing.Size(102, 22);
            this.txt_LOC.TabIndex = 561;
            // 
            // txt_act_stlgrd
            // 
            this.txt_act_stlgrd.InputControl = this.txt_act_stlgrd;
            this.txt_act_stlgrd.Location = new System.Drawing.Point(320, 50);
            this.txt_act_stlgrd.MaxLength = 11;
            this.txt_act_stlgrd.Name = "txt_act_stlgrd";
            this.txt_act_stlgrd.Size = new System.Drawing.Size(86, 22);
            this.txt_act_stlgrd.sJoin = "";
            this.txt_act_stlgrd.sSqletc = "SELECT STLGRD 钢种, STEEL_GRD_DETAIL 目标说明 FROM  NISCO.QP_NISCO_CHMC WHERE STLGRD_FL" +
                " =  \'N\' ORDER BY STEEL_GRD_DETAIL";
            this.txt_act_stlgrd.TabIndex = 560;
            // 
            // txt_act_stlgrd_dec
            // 
            this.txt_act_stlgrd_dec.Location = new System.Drawing.Point(403, 50);
            this.txt_act_stlgrd_dec.Name = "txt_act_stlgrd_dec";
            this.txt_act_stlgrd_dec.Size = new System.Drawing.Size(106, 22);
            this.txt_act_stlgrd_dec.TabIndex = 559;
            // 
            // ULabel3
            // 
            this.ULabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ULabel3.Location = new System.Drawing.Point(235, 50);
            this.ULabel3.Name = "ULabel3";
            this.ULabel3.Size = new System.Drawing.Size(84, 22);
            this.ULabel3.TabIndex = 558;
            this.ULabel3.Tag = "f4";
            this.ULabel3.Text = "钢种";
            this.ULabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 555;
            this.label5.Text = "生产工厂";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 472;
            this.label2.Tag = "f4";
            this.label2.Text = "母板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MOSLAB
            // 
            this.txt_MOSLAB.Location = new System.Drawing.Point(99, 18);
            this.txt_MOSLAB.MaxLength = 10;
            this.txt_MOSLAB.Name = "txt_MOSLAB";
            this.txt_MOSLAB.Size = new System.Drawing.Size(117, 22);
            this.txt_MOSLAB.TabIndex = 1;
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(0, 124);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1018, 498);
            this.ss1.TabIndex = 1;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // CGA2110C
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CGA2110C";
            this.Text = "板坯入库规格修改界面_CGA2110C";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MOSLAB;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_plt_name;
        public CommonClass.F4ETCR txt_plt;
        private System.Windows.Forms.Label label5;
        private CommonClass.F4ETCR txt_act_stlgrd;
        private System.Windows.Forms.TextBox txt_act_stlgrd_dec;
        private System.Windows.Forms.Label ULabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LOC;
        private CommonClass.NumBox txt_len_to;
        private CommonClass.NumBox txt_len;
        private CommonClass.NumBox txt_wid_to;
        private CommonClass.NumBox txt_wid;
        private CommonClass.NumBox txt_thk_to;
        private CommonClass.NumBox txt_thk;
        private System.Windows.Forms.Label ULabel8;
        private System.Windows.Forms.Label ULabel5;
        private System.Windows.Forms.Label ULabel2;
    }
}
