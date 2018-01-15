namespace CK
{
    partial class CKG2010C
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
            this.TXT_PLT = new CommonClass.F4ETCR();
            this.TXT_PLT_NAME = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_MPLATE_NO = new System.Windows.Forms.TextBox();
            this.target_y = new System.Windows.Forms.TextBox();
            this.to_y = new System.Windows.Forms.TextBox();
            this.from_y = new System.Windows.Forms.TextBox();
            this.SDB_MPLATE_EDT_SEQ = new System.Windows.Forms.TextBox();
            this.SDB_SLAB_EDT_SEQ = new System.Windows.Forms.TextBox();
            this.cmd_roll_mana = new System.Windows.Forms.Button();
            this.cmd_abnormal_send = new System.Windows.Forms.Button();
            this.opt_target = new System.Windows.Forms.RadioButton();
            this.opt_to = new System.Windows.Forms.RadioButton();
            this.opt_from = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opt_return = new System.Windows.Forms.RadioButton();
            this.opt_delete = new System.Windows.Forms.RadioButton();
            this.opt_move = new System.Windows.Forms.RadioButton();
            this.opt_cancel = new System.Windows.Forms.RadioButton();
            this.opt_sent = new System.Windows.Forms.RadioButton();
            this.SSPpdt = new System.Windows.Forms.Label();
            this.SSPsend = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_slabno = new System.Windows.Forms.TextBox();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.SSTab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ss1 = new FarPoint.Win.Spread.FpSpread();
            this.ss1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ss4 = new FarPoint.Win.Spread.FpSpread();
            this.ss4_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ss3 = new FarPoint.Win.Spread.FpSpread();
            this.ss3_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.SSOrd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SSTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_PLT
            // 
            bControlFiledSetting1.ColumnID = "CD";
            bControlFiledSetting1.TargetControl = this.TXT_PLT;
            bControlFiledSetting2.ColumnID = "CD_SHORT_NAME";
            bControlFiledSetting2.TargetControl = this.TXT_PLT_NAME;
            this.TXT_PLT.CustomSetting.Add(bControlFiledSetting1);
            this.TXT_PLT.CustomSetting.Add(bControlFiledSetting2);
            this.TXT_PLT.InputControl = this.TXT_PLT;
            this.TXT_PLT.Location = new System.Drawing.Point(120, 14);
            this.TXT_PLT.MaxLength = 2;
            this.TXT_PLT.Name = "TXT_PLT";
            this.TXT_PLT.Size = new System.Drawing.Size(40, 22);
            this.TXT_PLT.sJoin = "";
            this.TXT_PLT.sSqletc = "SELECT CD \"代码\", CD_SHORT_NAME \"代码简称\", CD_NAME \"代码名称\",        CD_SHORT_ENG \"代码英文简称" +
    "\", CD_FULL_ENG \"代码英文名称\" FROM NISCO.ZP_CD  WHERE CD_MANA_NO =    \'C0001\'    AND C" +
    "D         like \'%\'  ORDER  BY  CD  ASC ";
            this.TXT_PLT.TabIndex = 555;
            this.TXT_PLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PLT_NAME
            // 
            this.TXT_PLT_NAME.Enabled = false;
            this.TXT_PLT_NAME.Location = new System.Drawing.Point(166, 14);
            this.TXT_PLT_NAME.Name = "TXT_PLT_NAME";
            this.TXT_PLT_NAME.Size = new System.Drawing.Size(98, 22);
            this.TXT_PLT_NAME.TabIndex = 556;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_MPLATE_NO);
            this.groupBox1.Controls.Add(this.target_y);
            this.groupBox1.Controls.Add(this.to_y);
            this.groupBox1.Controls.Add(this.from_y);
            this.groupBox1.Controls.Add(this.SDB_MPLATE_EDT_SEQ);
            this.groupBox1.Controls.Add(this.SDB_SLAB_EDT_SEQ);
            this.groupBox1.Controls.Add(this.cmd_roll_mana);
            this.groupBox1.Controls.Add(this.cmd_abnormal_send);
            this.groupBox1.Controls.Add(this.opt_target);
            this.groupBox1.Controls.Add(this.opt_to);
            this.groupBox1.Controls.Add(this.opt_from);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_MPLATE_NO
            // 
            this.TXT_MPLATE_NO.Location = new System.Drawing.Point(889, 12);
            this.TXT_MPLATE_NO.Name = "TXT_MPLATE_NO";
            this.TXT_MPLATE_NO.Size = new System.Drawing.Size(22, 22);
            this.TXT_MPLATE_NO.TabIndex = 25;
            this.TXT_MPLATE_NO.Visible = false;
            // 
            // target_y
            // 
            this.target_y.Location = new System.Drawing.Point(861, 12);
            this.target_y.Name = "target_y";
            this.target_y.Size = new System.Drawing.Size(22, 22);
            this.target_y.TabIndex = 24;
            this.target_y.Visible = false;
            // 
            // to_y
            // 
            this.to_y.Location = new System.Drawing.Point(833, 12);
            this.to_y.Name = "to_y";
            this.to_y.Size = new System.Drawing.Size(22, 22);
            this.to_y.TabIndex = 23;
            this.to_y.Visible = false;
            // 
            // from_y
            // 
            this.from_y.Location = new System.Drawing.Point(803, 12);
            this.from_y.Name = "from_y";
            this.from_y.Size = new System.Drawing.Size(24, 22);
            this.from_y.TabIndex = 22;
            this.from_y.Visible = false;
            // 
            // SDB_MPLATE_EDT_SEQ
            // 
            this.SDB_MPLATE_EDT_SEQ.Location = new System.Drawing.Point(589, 15);
            this.SDB_MPLATE_EDT_SEQ.Name = "SDB_MPLATE_EDT_SEQ";
            this.SDB_MPLATE_EDT_SEQ.Size = new System.Drawing.Size(46, 22);
            this.SDB_MPLATE_EDT_SEQ.TabIndex = 21;
            this.SDB_MPLATE_EDT_SEQ.Visible = false;
            // 
            // SDB_SLAB_EDT_SEQ
            // 
            this.SDB_SLAB_EDT_SEQ.Location = new System.Drawing.Point(535, 15);
            this.SDB_SLAB_EDT_SEQ.Name = "SDB_SLAB_EDT_SEQ";
            this.SDB_SLAB_EDT_SEQ.Size = new System.Drawing.Size(46, 22);
            this.SDB_SLAB_EDT_SEQ.TabIndex = 20;
            this.SDB_SLAB_EDT_SEQ.Visible = false;
            // 
            // cmd_roll_mana
            // 
            this.cmd_roll_mana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_roll_mana.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_roll_mana.ForeColor = System.Drawing.Color.Blue;
            this.cmd_roll_mana.Location = new System.Drawing.Point(1092, 15);
            this.cmd_roll_mana.Name = "cmd_roll_mana";
            this.cmd_roll_mana.Size = new System.Drawing.Size(124, 26);
            this.cmd_roll_mana.TabIndex = 4;
            this.cmd_roll_mana.Text = "辊期编制";
            this.cmd_roll_mana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_roll_mana.UseVisualStyleBackColor = true;
            this.cmd_roll_mana.Visible = false;
            this.cmd_roll_mana.Click += new System.EventHandler(this.btn_roll_mana_Click);
            // 
            // cmd_abnormal_send
            // 
            this.cmd_abnormal_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_abnormal_send.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_abnormal_send.ForeColor = System.Drawing.Color.Red;
            this.cmd_abnormal_send.Location = new System.Drawing.Point(968, 15);
            this.cmd_abnormal_send.Name = "cmd_abnormal_send";
            this.cmd_abnormal_send.Size = new System.Drawing.Size(124, 26);
            this.cmd_abnormal_send.TabIndex = 3;
            this.cmd_abnormal_send.Text = "强制发送";
            this.cmd_abnormal_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_abnormal_send.UseVisualStyleBackColor = true;
            this.cmd_abnormal_send.Click += new System.EventHandler(this.cmd_abnormal_send_Click);
            // 
            // opt_target
            // 
            this.opt_target.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.opt_target.Enabled = false;
            this.opt_target.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.opt_target.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_target.Location = new System.Drawing.Point(698, 15);
            this.opt_target.Name = "opt_target";
            this.opt_target.Size = new System.Drawing.Size(99, 22);
            this.opt_target.TabIndex = 19;
            this.opt_target.Text = "目标板坯号";
            this.opt_target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt_target.UseVisualStyleBackColor = true;
            // 
            // opt_to
            // 
            this.opt_to.Cursor = System.Windows.Forms.Cursors.Default;
            this.opt_to.Enabled = false;
            this.opt_to.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_to.Location = new System.Drawing.Point(463, 15);
            this.opt_to.Name = "opt_to";
            this.opt_to.Size = new System.Drawing.Size(51, 22);
            this.opt_to.TabIndex = 18;
            this.opt_to.Text = "->";
            this.opt_to.UseVisualStyleBackColor = true;
            // 
            // opt_from
            // 
            this.opt_from.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.opt_from.Enabled = false;
            this.opt_from.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.opt_from.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_from.Location = new System.Drawing.Point(366, 15);
            this.opt_from.Name = "opt_from";
            this.opt_from.Size = new System.Drawing.Size(99, 22);
            this.opt_from.TabIndex = 17;
            this.opt_from.Text = "起始板坯号";
            this.opt_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt_from.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opt_return);
            this.panel1.Controls.Add(this.opt_delete);
            this.panel1.Controls.Add(this.opt_move);
            this.panel1.Controls.Add(this.opt_cancel);
            this.panel1.Controls.Add(this.opt_sent);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 33);
            this.panel1.TabIndex = 16;
            // 
            // opt_return
            // 
            this.opt_return.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_return.Location = new System.Drawing.Point(235, 3);
            this.opt_return.Name = "opt_return";
            this.opt_return.Size = new System.Drawing.Size(51, 22);
            this.opt_return.TabIndex = 9;
            this.opt_return.Text = "返送";
            this.opt_return.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_return.UseVisualStyleBackColor = true;
            // 
            // opt_delete
            // 
            this.opt_delete.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_delete.Location = new System.Drawing.Point(174, 3);
            this.opt_delete.Name = "opt_delete";
            this.opt_delete.Size = new System.Drawing.Size(51, 22);
            this.opt_delete.TabIndex = 8;
            this.opt_delete.Text = "删除";
            this.opt_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_delete.UseVisualStyleBackColor = true;
            // 
            // opt_move
            // 
            this.opt_move.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_move.Location = new System.Drawing.Point(117, 3);
            this.opt_move.Name = "opt_move";
            this.opt_move.Size = new System.Drawing.Size(51, 22);
            this.opt_move.TabIndex = 7;
            this.opt_move.Text = "调整";
            this.opt_move.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_move.UseVisualStyleBackColor = true;
            // 
            // opt_cancel
            // 
            this.opt_cancel.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_cancel.Location = new System.Drawing.Point(60, 3);
            this.opt_cancel.Name = "opt_cancel";
            this.opt_cancel.Size = new System.Drawing.Size(51, 22);
            this.opt_cancel.TabIndex = 6;
            this.opt_cancel.Text = "取消";
            this.opt_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_cancel.UseVisualStyleBackColor = true;
            // 
            // opt_sent
            // 
            this.opt_sent.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.opt_sent.Location = new System.Drawing.Point(3, 3);
            this.opt_sent.Name = "opt_sent";
            this.opt_sent.Size = new System.Drawing.Size(51, 22);
            this.opt_sent.TabIndex = 5;
            this.opt_sent.Text = "发送";
            this.opt_sent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.opt_sent.UseVisualStyleBackColor = true;
            // 
            // SSPpdt
            // 
            this.SSPpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SSPpdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSPpdt.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPpdt.ForeColor = System.Drawing.Color.Blue;
            this.SSPpdt.Location = new System.Drawing.Point(1098, 14);
            this.SSPpdt.Name = "SSPpdt";
            this.SSPpdt.Size = new System.Drawing.Size(124, 22);
            this.SSPpdt.TabIndex = 15;
            this.SSPpdt.Tag = "USER";
            this.SSPpdt.Text = "生产中";
            this.SSPpdt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SSPsend
            // 
            this.SSPsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SSPsend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSPsend.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSPsend.ForeColor = System.Drawing.Color.Blue;
            this.SSPsend.Location = new System.Drawing.Point(968, 14);
            this.SSPsend.Name = "SSPsend";
            this.SSPsend.Size = new System.Drawing.Size(124, 22);
            this.SSPsend.TabIndex = 14;
            this.SSPsend.Tag = "USER";
            this.SSPsend.Text = "已下达";
            this.SSPsend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SSOrd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TXT_PLT_NAME);
            this.groupBox2.Controls.Add(this.TXT_PLT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_search_slabno);
            this.groupBox2.Controls.Add(this.txt_target);
            this.groupBox2.Controls.Add(this.txt_to);
            this.groupBox2.Controls.Add(this.txt_from);
            this.groupBox2.Controls.Add(this.SSPpdt);
            this.groupBox2.Controls.Add(this.SSPsend);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(666, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 558;
            this.label4.Text = "目的板坯号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(288, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 557;
            this.label2.Text = "起始板坯号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(28, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "工厂";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "->";
            // 
            // txt_search_slabno
            // 
            this.txt_search_slabno.Location = new System.Drawing.Point(847, 14);
            this.txt_search_slabno.MaxLength = 9999;
            this.txt_search_slabno.Name = "txt_search_slabno";
            this.txt_search_slabno.Size = new System.Drawing.Size(85, 22);
            this.txt_search_slabno.TabIndex = 18;
            this.txt_search_slabno.Visible = false;
            // 
            // txt_target
            // 
            this.txt_target.Location = new System.Drawing.Point(756, 14);
            this.txt_target.MaxLength = 9999;
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(85, 22);
            this.txt_target.TabIndex = 8;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(496, 14);
            this.txt_to.MaxLength = 9999;
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(85, 22);
            this.txt_to.TabIndex = 6;
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(378, 14);
            this.txt_from.MaxLength = 9999;
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(85, 22);
            this.txt_from.TabIndex = 5;
            // 
            // SSTab1
            // 
            this.SSTab1.Controls.Add(this.tabPage1);
            this.SSTab1.Controls.Add(this.tabPage2);
            this.SSTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSTab1.ItemSize = new System.Drawing.Size(484, 19);
            this.SSTab1.Location = new System.Drawing.Point(0, 94);
            this.SSTab1.Name = "SSTab1";
            this.SSTab1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SSTab1.SelectedIndex = 0;
            this.SSTab1.Size = new System.Drawing.Size(1362, 528);
            this.SSTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.SSTab1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.ss1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1354, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "轧制指示";
            // 
            // ss1
            // 
            this.ss1.AccessibleDescription = "";
            this.ss1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ss1.Location = new System.Drawing.Point(3, 3);
            this.ss1.Name = "ss1";
            this.ss1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss1_Sheet1});
            this.ss1.Size = new System.Drawing.Size(1348, 495);
            this.ss1.TabIndex = 1;
            // 
            // ss1_Sheet1
            // 
            this.ss1_Sheet1.Reset();
            this.ss1_Sheet1.SheetName = "Sheet1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.ss4);
            this.tabPage2.Controls.Add(this.splitter1);
            this.tabPage2.Controls.Add(this.ss3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "母板、钢板指示";
            // 
            // ss4
            // 
            this.ss4.AccessibleDescription = "";
            this.ss4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ss4.Location = new System.Drawing.Point(613, 3);
            this.ss4.Name = "ss4";
            this.ss4.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss4_Sheet1});
            this.ss4.Size = new System.Drawing.Size(726, 495);
            this.ss4.TabIndex = 3;
            // 
            // ss4_Sheet1
            // 
            this.ss4_Sheet1.Reset();
            this.ss4_Sheet1.SheetName = "Sheet1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(610, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 495);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // ss3
            // 
            this.ss3.AccessibleDescription = "";
            this.ss3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ss3.Location = new System.Drawing.Point(3, 3);
            this.ss3.Name = "ss3";
            this.ss3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ss3_Sheet1});
            this.ss3.Size = new System.Drawing.Size(607, 495);
            this.ss3.TabIndex = 1;
            // 
            // ss3_Sheet1
            // 
            this.ss3_Sheet1.Reset();
            this.ss3_Sheet1.SheetName = "Sheet1";
            // 
            // SSOrd
            // 
            this.SSOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SSOrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SSOrd.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SSOrd.ForeColor = System.Drawing.Color.White;
            this.SSOrd.Location = new System.Drawing.Point(1228, 14);
            this.SSOrd.Name = "SSOrd";
            this.SSOrd.Size = new System.Drawing.Size(124, 22);
            this.SSOrd.TabIndex = 26;
            this.SSOrd.Tag = "USER";
            this.SSOrd.Text = "多订单";
            this.SSOrd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CKG2010C
            // 
            this.ClientSize = new System.Drawing.Size(1362, 622);
            this.Controls.Add(this.SSTab1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CKG2010C";
            this.Text = "指示调整_CKG2010C";
            this.Load += new System.EventHandler(this.CKG2010C_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SSTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1_Sheet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmd_roll_mana;
        private System.Windows.Forms.Button cmd_abnormal_send;
        private System.Windows.Forms.Label SSPpdt;
        private System.Windows.Forms.Label SSPsend;
        private System.Windows.Forms.TextBox txt_search_slabno;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.RadioButton opt_target;
        private System.Windows.Forms.RadioButton opt_to;
        private System.Windows.Forms.RadioButton opt_from;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt_return;
        private System.Windows.Forms.RadioButton opt_delete;
        private System.Windows.Forms.RadioButton opt_move;
        private System.Windows.Forms.RadioButton opt_cancel;
        private System.Windows.Forms.RadioButton opt_sent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TXT_PLT_NAME;
        public CommonClass.F4ETCR TXT_PLT;
        private System.Windows.Forms.TabControl SSTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FarPoint.Win.Spread.FpSpread ss1;
        private FarPoint.Win.Spread.SheetView ss1_Sheet1;
        private FarPoint.Win.Spread.FpSpread ss4;
        private FarPoint.Win.Spread.SheetView ss4_Sheet1;
        private System.Windows.Forms.Splitter splitter1;
        private FarPoint.Win.Spread.FpSpread ss3;
        private FarPoint.Win.Spread.SheetView ss3_Sheet1;
        private System.Windows.Forms.TextBox SDB_SLAB_EDT_SEQ;
        private System.Windows.Forms.TextBox SDB_MPLATE_EDT_SEQ;
        private System.Windows.Forms.TextBox from_y;
        private System.Windows.Forms.TextBox target_y;
        private System.Windows.Forms.TextBox to_y;
        private System.Windows.Forms.TextBox TXT_MPLATE_NO;
        private System.Windows.Forms.Label SSOrd;


    }
}
