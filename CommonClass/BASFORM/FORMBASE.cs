using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using CommonClass;
using System.Runtime.InteropServices;
//using CSTextLib;

///'1 子窗体有几个mc，sc就new几个
//'2 子窗体load事件要做的工作

//'(1) 设定 FormType
//'   Form Type : Start , Hdetail, Master, Sheet, Hsheet, PopSheet, ReferNoPr, ReferPr, Print'
//'   如果是sheet，hsheet或者master,hdetail就不用设置
//'(2) 调用父类 form_define
//'         form_define中
//'      调用子类p_SubFormInit
//'3 子窗体 p_SubFormInit中调用父类：p_McIni，p_ScIni，p_SetMc，p_SetSc
//'4 form_ref:Sheet，Master不需要重写，Hsheet，Hdetail默认为根据第一个mc查询当前的sc
//'-----------------如果不同请重写form_ref：请用p_ref实现，用第几个mc查询第几个sc
//'5 Form_Pro:Sheet，Master不需要重写,Hsheet默认为保存当前的sc，并根据第一个mc再查询一次当前的sc，
//'           Hdetail默认为保存第一个mc和当前的sc，并根据第一个mc再查询一次mc及当前的sc
//'------------------如果不同请重写Form_Pro:请用p_pro实现，根据第几个mc保存第几个sc
//'6 Form_Del:Sheet，Hsheet不存在该函数,master不需要重写
//'           Hdetail默认为删除第一个mc和当前的sc
//'------------------如果不同请重写Form_Del：请用p_del实现，删除


namespace CommonClass
{
    public partial class FORMBASE : System.Windows.Forms.Form
    {
        //  FORMBASE类中增加变量：
        private static ComboBox TextBoxComboBox;//0809
        private static string TextBoxSql = "";//0809


        public Collection Proc_Sc = new Collection();
        protected Collection Proc_Mc = new Collection();


        protected FarPoint.Win.Spread.FpSpread ss;
        protected FarPoint.Win.Spread.SheetView sh;
        protected System.Windows.Forms.Control ctrl;

        public string sSvrPgmPkgName = ""; // '对应后台程序包包名

        public int i_ScCurrSeq = 0; //当前活动sc顺序

        protected bool isRefer = false; //当前是否在执行查询或行取消或保存函数
        protected bool bSortCol;

        public string FormType; //Form Type
        public string Toolbar_St; //Active Form ToolBar Setting
        public static string init_Toolbar_St = ""; //Active Form ToolBar Setting
        public string sAuthority; //Active Form Authority Setting


        public string Pre_Toolbar_St;
        public string Pre_FormName = "";
        public string Pre_sAuthority;
        public string Pre_FormType;


        protected long lBlkcol1; //To Excel Block Col1
        protected long lBlkcol2; //To Excel Block Col2
        protected long lBlkrow1; //To Excel Block Row1
        protected long lBlkrow2; //To Excel Block Row2
        protected SpreadCommon SpreadCommon = new SpreadCommon();
        protected MasterCommon MasterCommon = new MasterCommon();
        protected int tabindex_count;

        protected int iCopyRowcnt;

        /// //////////////1022
        public string sAuthority_btn;
        private int Btn_I = 0;
        /// ///////////////1022
        private int[] ss_default_width;

        [DllImport("kernel32.dll", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        
        private static extern int SetProcessWorkingSetSize(IntPtr hProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        #region  " Windows 窗体设计器生成的代码 "

        public FORMBASE()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);

            if (disposing)
            {
                if (!(components == null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);

        }

        //'Windows 窗体设计器所必需的
        private System.ComponentModel.Container components = null;
        //Container :封裝零個或多個元件。

        //     '注意: 以下过程是 Windows 窗体设计器所必需的
        //'可以使用 Windows 窗体设计器修改此过程。
        //'不要使用代码编辑器修改它。
        public System.Windows.Forms.ContextMenu sCMenu;
        public System.Windows.Forms.MenuItem Mnu_ColumnSort;
        internal System.Windows.Forms.MenuItem MenuItem11;
        public System.Windows.Forms.MenuItem Mnu_FrozenSetting;
        public System.Windows.Forms.MenuItem Mnu_FrozenCancel;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMBASE));
            this.sCMenu = new System.Windows.Forms.ContextMenu();
            this.Mnu_ColumnSort = new System.Windows.Forms.MenuItem();
            this.MenuItem11 = new System.Windows.Forms.MenuItem();
            this.Mnu_FrozenSetting = new System.Windows.Forms.MenuItem();
            this.Mnu_FrozenCancel = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // sCMenu
            // 
            this.sCMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_ColumnSort,
            this.MenuItem11,
            this.Mnu_FrozenSetting,
            this.Mnu_FrozenCancel});
            // 
            // Mnu_ColumnSort
            // 
            this.Mnu_ColumnSort.Index = 0;
            this.Mnu_ColumnSort.Text = "列排序";
            this.Mnu_ColumnSort.Click += new System.EventHandler(this.Mnu_ColumnSort_Click);
            // 
            // MenuItem11
            // 
            this.MenuItem11.Index = 1;
            this.MenuItem11.Text = "-";
            // 
            // Mnu_FrozenSetting
            // 
            this.Mnu_FrozenSetting.Index = 2;
            this.Mnu_FrozenSetting.Text = "列锁定";
            this.Mnu_FrozenSetting.Click += new System.EventHandler(this.Mnu_FrozenSetting_Click);
            // 
            // Mnu_FrozenCancel
            // 
            this.Mnu_FrozenCancel.Index = 3;
            this.Mnu_FrozenCancel.Text = "列解锁";
            this.Mnu_FrozenCancel.Click += new System.EventHandler(this.Mnu_FrozenCancel_Click);
            // 
            // FORMBASE
            // 
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORMBASE";
            this.Text = "FORMBASE";
            this.Activated += new System.EventHandler(this.form_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.form_Closing);
            this.Closed += new System.EventHandler(this.form_Closed);
            this.Deactivate += new System.EventHandler(this.FORMBASE_Deactivate);
            this.Load += new System.EventHandler(this.form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        #region Form Start and Close
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void form_Load(object sender, System.EventArgs e)
        {
            GeneralCommon.cur_Frm = this;
           // GeneralCommon.FileName = Application.StartupPath + "\\STEELPIA.INI";
            //////////////////////1022
            if (!DesignMode)
            sAuthority_btn = GeneralCommon.Gf_Pgm_Authoritybtn(this.Name);
            //sAuthority_btn = "1";    //ADD BY CAOLEI 20121119

            //////////////////////1022
            tabindex_count = 0;
            foreach (System.Windows.Forms.Control Ctrl in this.Controls)
            {
                p_ConFormat(Ctrl, this);
            }

        }


        /// <summary>
        /// 格式化页面中的各种控件
        /// Ctrl：页面中的控件
        /// frm：当前页面
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="frm"></param>
        protected virtual void p_ConFormat(System.Windows.Forms.Control Ctrl, Form frm)
        {
            int ControlHeight = 22;
            try
            {
                if (Ctrl.Controls.Count == 0)
                {
                    if (Ctrl is Label) //设置LABEL风格
                    {

                        Label lbltemplabel;
                        lbltemplabel = (Label)Ctrl;
                        string label_tag = "";
                        try
                        {
                            label_tag = lbltemplabel.Tag.ToString().ToUpper();
                        }
                        catch { label_tag = ""; }
                        if (label_tag == "F4")
                        {
                            lbltemplabel.Height = ControlHeight;
                            lbltemplabel.BorderStyle = BorderStyle.Fixed3D;
                            lbltemplabel.BackColor = System.Drawing.Color.PowderBlue;
                            lbltemplabel.TextAlign = ContentAlignment.BottomCenter;
                            lbltemplabel.ForeColor = Color.Blue;
                        }
                        else if (label_tag != "USER")
                        {
                            lbltemplabel.Height = ControlHeight;
                            lbltemplabel.BorderStyle = BorderStyle.Fixed3D;
                            lbltemplabel.BackColor = System.Drawing.Color.PowderBlue;
                            lbltemplabel.TextAlign = ContentAlignment.BottomCenter;
                        }
                    }

                   
                    else if (Ctrl is TextBox) //设置textbox风格
                    {
                        TextBox txtTempTextBox;
                        txtTempTextBox = (TextBox)Ctrl;
                        string tagStr = "";
                        try
                        {
                            tagStr = txtTempTextBox.Tag.ToString().Trim();
                        }
                        catch { tagStr = ""; }
                        if (tagStr == "")
                            txtTempTextBox.Height = ControlHeight;
                    }
                    
                    else if (Ctrl is ComboBox) //设置combobox风格
                    {
                        ComboBox drpTempComboBox;
                        drpTempComboBox = (ComboBox)Ctrl;
                        drpTempComboBox.Height = ControlHeight;
                    }
                    else if (Ctrl is DateTimePicker) //设置DateTimePicker风格
                    {
                        DateTimePicker adt;
                        adt = (DateTimePicker)Ctrl;
                        adt.Height = ControlHeight;
                        switch (adt.Format)
                        {
                            case DateTimePickerFormat.Custom:
                                adt.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                                break;
                            case DateTimePickerFormat.Long:
                                adt.Format = DateTimePickerFormat.Custom;
                                adt.CustomFormat = "yyyy-MM-dd";
                                break;
                            case DateTimePickerFormat.Short:
                                adt.Format = DateTimePickerFormat.Custom;
                                adt.CustomFormat = "yyyy-MM-dd";
                                break;
                            case DateTimePickerFormat.Time:
                                adt.Format = DateTimePickerFormat.Custom;
                                adt.CustomFormat = "HH:mm:ss";
                                break;
                        }
                    }

                    ///////////////////////1022
                    else if (Ctrl is Button)
                    {
                        Btn_I++;
                        //Btn_I = (int)GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1,
                        //   "SELECT ABC0050C.F_GET_BTN_SEQ('" + frm.Name + "','" + Ctrl.Name + "') FROM DUAL");
                        string btn_seq_sqlstr = "select btn_seq from zp_pgmid_buttons where pgmid ='" + this.Name + "'  and button_id = '" + Ctrl.Name + "' ";
                        try
                        {
                            Btn_I = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, btn_seq_sqlstr));
                        }
                        catch { Btn_I = 0; }

                        if (sAuthority_btn == "1") Ctrl.Enabled = true;
                        else if (sAuthority_btn == "0") Ctrl.Enabled = false;
                        else
                        {
                            if (Btn_I == 0) Ctrl.Enabled = false;
                            else
                            {
                                if (sAuthority_btn.Length < Btn_I) Ctrl.Enabled = false;
                                else
                                {
                                    if (sAuthority_btn.Substring(Btn_I - 1, 1) == "1")
                                        Ctrl.Enabled = true;
                                    else
                                        Ctrl.Enabled = false;
                                }
                            }
                        }
                    }
                    ////////////////////////1022

                    else if (Ctrl is FarPoint.Win.Spread.FpSpread)
                    {
                        FarPoint.Win.Spread.FpSpread ss1;
                        ss1 = (FarPoint.Win.Spread.FpSpread)Ctrl;
                    }
                    else if (Ctrl is Splitter)
                    {
                        Splitter xx = (Splitter)Ctrl;
                        int y = Win32ApiClass.GetPrivateProfileInt(frm.Name, xx.Name, xx.SplitPosition, GeneralCommon.FileName);
                        xx.SplitPosition = y;
                    }
                }
                else
                {
                    for (int i = 1; i <= Ctrl.Controls.Count; i++)
                    {
                        p_ConFormat(Ctrl.Controls[i - 1], frm);
                    }
                }
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("p_ConFormat Error :" + Ctrl.Name + ex.Message), "", "");
            }
        }

        protected virtual void form_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
          //  if (e.KeyChar == Strings.ChrW((int)Keys.ControlKey)) return;//1227
        }
        /// <summary>
        /// 窗体关闭前的事件：
        //1、获取spliter位置，并保存
        //2、检查当前窗体spread是否有增、删、改的操作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {           
            GeneralCommon.SetSplitPos((Form)sender);
            for (int i = 1; i <= Proc_Sc.Count; i++)
            {
                Collection proc_sc_i = (Collection)Proc_Sc[i];
                if (SpreadCommon.Gf_Sp_ProceExist((FarPoint.Win.Spread.FpSpread)proc_sc_i["Spread"], true)) //   [i]("Spread"), true))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        /// <summary>
        /// "窗体关闭事件：
        //1、获取当前窗体spread各列宽度并保存。
        //2、根据余下的窗体设置工具栏状态。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void form_Closed(object sender, System.EventArgs e)
        {

            for (int i = 1; i <= Proc_Sc.Count; i++)
            {
                Collection proc_sc_i = (Collection)Proc_Sc[i];
                SpreadCommon.Gp_Sp_ColSet((FarPoint.Win.Spread.FpSpread)proc_sc_i["Spread"], this.Name, "");
            }

            Proc_Sc = null;
            Proc_Mc = null;
            MasterCommon = null;
            SpreadCommon = null;
            GeneralCommon.cur_Frm = this;
            GeneralCommon.Gp_FormMenuSetting("Start", Toolbar_St, "");

        }

        private void CeriUDateDbClick(object sender, MouseEventArgs e)
        {
            string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            string TimeStr = AdoRs.Fields[0].Value.ToString();
            CeriUDate curCeriUDate = (CeriUDate)((MaskedTextBox)sender).Parent;
            curCeriUDate.RawDate = TimeStr.Substring(0, 8);
        }

        /// <summary>
        /// 窗体激活事件：根据激活窗体设置工具栏状态。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void form_Activated(object sender, System.EventArgs e)
        {
            GeneralCommon.cur_Frm = this;
            Toolbar_St = ((FORMBASE)sender).Toolbar_St;
            GeneralCommon.Gp_FormMenuSetting(FormType, Toolbar_St, sAuthority);
            GeneralCommon.GStatusBar.Panels[0].Text = "NGMES" + "  提示信息  : ";
        }

        #endregion

        #region Form Collection Define
        /// <summary>
        /// 1、初始化窗体对应的包名称。
        //2、将窗体中的控件加载至对应的MC中。
        //3、将窗体中各SPREAD列加载至各SC中。
        //4、读取当前窗体的权限。
        //5、初始化窗体类型。
        /// </summary>
        protected void Form_Define()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            if (sSvrPgmPkgName == "")
                sSvrPgmPkgName = this.Name;
            p_SubFormInit();

            for (int i = 1; i <= Proc_Mc.Count; i++)
            {
                p_McFor((Collection)Proc_Mc[i]);
            }

            for (int i = 1; i <= Proc_Sc.Count; i++)
            {
                p_ScFor((Collection)Proc_Sc[i]);
            }

            sAuthority = GeneralCommon.Gf_Pgm_Authority(this.Name);
            //sAuthority = "1111";

            this.KeyPreview = true;
            this.BackColor = GeneralCommon.VbFormBKColor;



            if (GeneralCommon.M_CN1.State != 0)
            {
                GeneralCommon.M_CN1.Close();
            }

            // 如果有sc，设置当前sc顺序为1
            if (Proc_Sc.Count > 0)
            {
                i_ScCurrSeq = 1;
                ///新增代码，设置SPREAD列头字体 2012-7-25 耿朝雷   BEGIN
                for (int i_Sc = 1; i_Sc <= Proc_Sc.Count; i_Sc++)
                {
                    Collection Sc = (Collection)Proc_Sc[i_Sc];
                    FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
                    int head_Cnt = oSpread.ActiveSheet.ColumnHeader.RowCount;
                    for (int i = 0; i < oSpread.ActiveSheet.Columns.Count; i++)
                    {
                        for (int j = 0; j < head_Cnt; j++)
                        {
                            FontFamily myFontFamily = new FontFamily("Arial"); //采用哪种字体
                            Font myFont = new Font(myFontFamily, (float)9.75, FontStyle.Regular);
                            oSpread.ActiveSheet.ColumnHeader.Cells[j, i].Font = myFont;
                        }
                    }
                }
                ///新增代码，设置SPREAD列头字体 2012-7-25 耿朝雷   END
            }

            // 根据mc，sc数目设定FormType
            if (Proc_Sc.Count == 1 && Proc_Mc.Count == 0)
            {
                FormType = "Sheet";
            }
            else if (Proc_Sc.Count == 0 && Proc_Mc.Count == 1)
            {
                FormType = "Master";
            }
            else
            {
                bool bhsheetyn = true;
                for (int i = 1; i <= Proc_Mc.Count; i++)
                {
                    try
                    {
                        if ((bool)(((Collection)(Proc_Mc[i]))["pro"]) == true)
                        {
                            bhsheetyn = false;
                            break;
                        }
                    }
                    catch { }
                }
                if (bhsheetyn == true)
                {
                    FormType = "Hsheet";
                }
                else
                {
                    FormType = "Hdetail";
                }
            }
            GeneralCommon.Gp_FormMenuSetting(FormType, "FS", sAuthority);
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        protected virtual void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)sender;
            if (ss.ActiveSheet.ActiveRowIndex < 0) return;
            string sTag = ss.ActiveSheet.Columns[ss.ActiveSheet.ActiveColumnIndex].Tag.ToString().ToUpper();
            if (sTag != "COMR" && sTag != "COMN" && sTag != "ETCR" && sTag != "ETCN") return;
            System.Windows.Forms.KeyEventArgs ke = new KeyEventArgs(Keys.F4);
            f4set(ke);
        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            GeneralCommon.Gf_ComboAdd(TextBoxComboBox, GetQuery(TextBoxSql, ((TextBox)sender).Text));
        }
        protected void p_SetMc(string sname, TextBox Ctrl, string sAttr, string sLenth, string sComboComText, string sComboxJoin, string sComboCusText, int McSeq,
            ComboBox Cbo, string sQurey)
        {
            TextBoxComboBox = Cbo;
            TextBoxSql = sQurey;
            Ctrl.KeyUp += new KeyEventHandler(TextBoxKeyUp);
            p_SetMc(sname, Ctrl, sAttr, sLenth, sComboComText, sComboxJoin, sComboCusText, McSeq);
        }
        private string GetQuery(string sSql, string textBoxText)
        {
            string sqlRlt = sSql.ToUpper();
            string s_flds = "";
            string[] s_flds_arr = new string[2];
            int select_pos = 0;
            int from_pos = 0;
            try
            {
                select_pos = sqlRlt.IndexOf("SELECT");
                from_pos = sqlRlt.IndexOf("FROM");
                s_flds = sqlRlt.Substring(select_pos + 6, from_pos - select_pos - 6);
                s_flds_arr = s_flds.Split(',');

                if (sqlRlt.Contains("WHERE"))
                {
                    sqlRlt = sSql + " AND " + s_flds_arr[0] + " LIKE '" + textBoxText + "%'";
                }
                else
                {
                    sqlRlt = sSql + " WHERE " + s_flds_arr[0] + " LIKE  '" + textBoxText + "%'";
                }
            }
            catch { GeneralCommon.Gp_MsgBoxDisplay("自定义SQL语句有问题:" + sSql, "", ""); }

            return sqlRlt;
        }


        /// <summary>
        /// 格式化Mc
        /// Mc：Mc集合
        /// </summary>
        /// <param name="Mc"></param>
        protected void p_McFor(Collection Mc)
        {

            MasterCommon.Gp_Ms_Cls((Collection)Mc["rControl"]);

            MasterCommon.Gp_Ms_ControlLock((Collection)Mc["lControl"], true);

            MasterCommon.Gp_Ms_NeceColor((Collection)Mc["nControl"]);

            foreach (Control c in (Collection)Mc["pControl"])
            {
                Control ct = c;
                ct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctrl_KeyPress);
            }

        }

      
        /// <summary>
        /// 格式化Sc
        /// Sc：Sc集合
        /// </summary>
        /// <param name="Sc"></param>
        protected void p_ScFor(Collection Sc)
        {
            SpreadCommon.Gp_Sp_Setting((FarPoint.Win.Spread.FpSpread)Sc["Spread"], (bool)Sc["lock"], (bool)Sc["sort"]);

            SpreadCommon.Gf_Sp_Cls(Sc);

            SpreadCommon.Gp_Sp_ColGet((FarPoint.Win.Spread.FpSpread)Sc["Spread"], this.Name, "");
        }


        /// <summary>
        /// 未用
        /// </summary>
        /// <param name="ospread"></param>
        /// <param name="rowCount"></param>
        protected void p_SetColumnRowCount(FarPoint.Win.Spread.FpSpread ospread, int rowCount)
        {
            ospread.Sheets[0].ColumnHeader.RowCount = rowCount;
        }
        #endregion

        #region Main Menu Click Process

        /// <summary>
        /// 页面清空函数。
        /// </summary>
        /// <returns></returns>
        public virtual bool Form_Cls()
        {
            for (int i = 1; i <= Proc_Sc.Count; i++)
            {
                if (SpreadCommon.Gf_Sp_Cls((Collection)Proc_Sc[i]) == false)
                {
                    return false;
                }
            }

            for (int i = 1; i <= Proc_Mc.Count; i++)
            {
                try
                {
                    MasterCommon.Gp_Ms_Cls((Collection)((Collection)Proc_Mc[i])["rControl"]);
                    MasterCommon.Gp_Ms_Cls((Collection)((Collection)Proc_Mc[i])["pControl"]);
                }
                catch { return false; }
                if (FormType.Trim() == "Master" || FormType.Trim() == "Hdetail")
                {
                    try
                    {
                        MasterCommon.Gp_Ms_ControlLock((Collection)((Collection)Proc_Mc[i])["pControl"], false);
                    }
                    catch { return false; }
                }
            }

            if (Proc_Mc.Count > 0)
            {
                ((Control)((Collection)((Collection)Proc_Mc[1])["pControl"])[1]).Focus();
            }

            GeneralCommon.Gp_FormMenuSetting(FormType, "CLS", sAuthority);
            return true;
        }

        /// <summary>
        /// 查询函数，根据页面不同类型调用p_ref进行相应的查询动作
        /// </summary>
        public virtual void Form_Ref()
        {
            switch (FormType)
            {
                case "Sheet":
                    p_Ref(0, 1, true, true);
                    break;
                case "Master":
                    p_Ref(1, 0, true, true);
                    break;
                case "Hsheet":
                    p_Ref(1, i_ScCurrSeq, true, true);
                    break;
                case "Hdetail":
                    p_Ref(1, i_ScCurrSeq, true, true);
                    break;
            }
        }


        /// <summary>
        /// 保存函数，根据页面不同类型调用p_pro进行相应的保存动作。
        /// </summary>
        public virtual void Form_Pro()
        {

            switch (FormType)
            {
                case "Sheet":
                    p_pro(0, 1, true, false);
                    break;
                case "Master":
                    p_pro(1, 0, true, false);
                    break;
                case "Hsheet":
                    p_pro(1, i_ScCurrSeq, true, false);
                    break;
                case "Hdetail":
                    p_pro(1, i_ScCurrSeq, true, false);
                    break;
            }
        }

        /// <summary>
        /// 删除函数，根据页面不同类型调用p_del进行相应的删除动作。
        /// </summary>
        public virtual void Form_Del()
        {
            switch (FormType)
            {
                case "Sheet":
                    return;
                case "Master":
                    p_del(1, 0, true);
                    break;
                case "Hsheet":
                    return;
                case "Hdetail":
                    p_del(1, i_ScCurrSeq, true);
                    break;
            }

        }

        /// <summary>
        /// Spread行插入操作，对非lock列解锁，对lock列进行锁定，并根据"authority"列的值，将操作者的UserId写入新插入行的相应位置上。
        /// </summary>
        public virtual void Spread_Ins()
        {
            Collection proc_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)proc_sc_i["Spread"];
            switch (FormType)
            {
                case "Master":
                    return;
                default:

                    if (ss.Sheets[0].RowCount != 0)
                    {
                        ss.Sheets[0].Rows.Add(ss.ActiveSheet.ActiveRowIndex + 1, 1);
                        ss.Sheets[0].ActiveRowIndex++;
                        ss.Sheets[0].ActiveColumnIndex = 0;
                    }
                    else
                    {
                        ss.Sheets[0].Rows.Add(0, 1);
                        ss.Sheets[0].ActiveRowIndex = 0;
                    }
                    ss.Sheets[0].RowHeader.Cells.Get(ss.ActiveSheet.ActiveRowIndex, 0).Text = "增加";

                    for (int i = 0; i <= ss.Sheets[0].ColumnCount - 1; i++)
                    {
                        ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, i).Locked = false;
                    }

                    Collection Proc_Sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
                    Collection lColumn = (Collection)Proc_Sc_i["lColumn"];
                    for (int l = 1; l <= lColumn.Count; l++)
                    {
                        ss.Sheets[0].Cells.Get(ss.Sheets[0].ActiveRowIndex, (int)lColumn[l]).Locked = true;
                    }

                    int colID = System.Convert.ToInt32(Proc_Sc_i["authority"]);
                    if (colID > 0)
                    {
                        SpreadCommon.Gp_Sp_InAuthority(Proc_Sc_i, (int)Proc_Sc_i["authority"], "");
                    }
                    break;
            }
        }

        /// <summary>
        /// Spread行删除：点击工具栏删除按钮时，在当前Sc的Spread的当前行标识“删除”标志。
        /// </summary>
        public virtual void Spread_Del()
        {

            SpreadCommon.Gp_Sp_Del((Collection)Proc_Sc[i_ScCurrSeq]);
        }

        /// <summary>
        /// Spread行取消操作：将当前的Spread操作（新增、修改、删除）取消
        /// </summary>
        public virtual void Spread_Can()
        {
            isRefer = true;
            SpreadCommon.Gp_Sp_Cancel(GeneralCommon.M_CN1, (Collection)Proc_Sc[i_ScCurrSeq]);
            isRefer = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Form_Cpy()
        {

        }

        public virtual void Master_Cpy()
        {
            MasterCommon.Gf_Ms_Copy((Collection)Proc_Mc[1]);

        }

        /// <summary>
        /// 将所要复制的Spread内容黏贴在剪贴板上，并记录所要复制内容的行数。
        /// </summary>
        public virtual void Spread_Cpy()
        {
            Collection proc_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)proc_sc_i["Spread"];
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss.Sheets[0].GetSelection(0);
            if (cr == null)
            {
                iCopyRowcnt = 0;
            }
            else
            {
                iCopyRowcnt = ss.Sheets[0].GetSelection(0).RowCount;
            }
            ss.Sheets[0].ClipboardCopy(cr);
        }


        /// <summary>
        /// 未用
        /// </summary>
        public virtual void Form_Pst()
        {

            if (MasterCommon.Gf_Ms_FormPaste((Collection)Proc_Mc[1], (Collection)Proc_Sc[i_ScCurrSeq]))
            {
                GeneralCommon.Gp_FormMenuSetting(FormType, "CLS", sAuthority);
                Collection proc_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
                if ((int)proc_sc_i["authority"] == 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_InAuthority((Collection)Proc_Sc[i_ScCurrSeq], (int)proc_sc_i["authority"], "P");
            }

        }

        /// <summary>
        /// 判断当前页面是否具有进行“黏贴”的条件，并设置画面的权限
        /// </summary>
        public virtual void Master_Pst()
        {

            if (MasterCommon.Gf_Ms_Paste(GeneralCommon.M_CN1, (Collection)Proc_Mc[1], null))
            {
                GeneralCommon.Gp_FormMenuSetting(FormType, "CLS", sAuthority);
            }

        }
        /// <summary>
        /// 将所要复制的Spread内容从剪贴板复制到Spread相应的行中，并记录所要复制内容的行数。
        /// </summary>
        public virtual void Spread_Pst()
        {
            Collection prod_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)prod_sc_i["Spread"];
            int index = ss.ActiveSheet.ActiveRowIndex;
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss.ActiveSheet.GetSelection(0);
            int rowcount;
            if (cr == null)
            {
                rowcount = 0;
            }
            else
            {
                rowcount = ss.ActiveSheet.GetSelection(0).RowCount;
            }

            ss.ActiveSheet.ActiveRowIndex = index + rowcount - 1;

            for (int i = 1; i <= iCopyRowcnt; i++)
            {
                Spread_Ins();
            }
            iCopyRowcnt = 0;
            ss.ActiveSheet.ActiveRowIndex = index + rowcount;
            ss.ActiveSheet.ClipboardPaste();
        }

        /// <summary>
        /// 调用 SpreadCommon.Gp_Sp_Excel，将将Spread表单内容导出到客户端Excel表格中。
        /// </summary>
        public virtual void Spread_Exc()
        {
            Collection prod_sc_i = (Collection)Proc_Sc[i_ScCurrSeq];
            SpreadCommon.Gp_Sp_Excel((FarPoint.Win.Spread.FpSpread)prod_sc_i["Spread"]);
        }

        public virtual void Form_Pri()
        {

        }

        public virtual void Form_Exit()
        {

            this.Close();

        }

      

        #endregion

        #region Spread Event Process

        /// <summary>
        /// Spread单元格单击事件。单击列头根据(bool)Sc["sort"]是否为true对Spread列进行排序;点击CheckBox控件时，根据当前单元格是否被锁定及当前操作者的权限设置行头添加“修改”标志。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)sender;
            string spreadname;
            spreadname = oSpread.Name.ToString();
            i_ScCurrSeq = int.Parse(spreadname.Substring(2));
            Collection Sc = (Collection)Proc_Sc[i_ScCurrSeq];

            // 2009-7-6 耿朝雷增加，为解决列类型为数字的排序问题
            int I_COLLEN_MAX = 0;

            if (e.ColumnHeader == true)
            {
                try
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if ((bool)Sc["sort"])
                        {
                            //'下面的语句块由  If ss1.ActiveSheet.Columns.Get(e.Column).Tag = "N" Then   到   End If  '对应 If ss1.ActiveSheet.Columns.Get(e.Column).Tag = "N" Then
                            //'原语句块为 ss1.ActiveSheet.AutoSortColumn(e.Column)
                            //'由耿朝雷修改，时间为：2009-7-6 10：06 目的：为解决列类型为数字的排序问题
                            if (oSpread.ActiveSheet.Columns.Get(e.Column).Tag == "N")
                            {
                                for (int I = 0; I <= oSpread.ActiveSheet.RowCount - 1; I++)
                                {
                                    if (I_COLLEN_MAX < oSpread.ActiveSheet.Cells[I, e.Column].Text.Length)
                                    {
                                        I_COLLEN_MAX = oSpread.ActiveSheet.Cells[I, e.Column].Text.Length;
                                    }
                                }

                                for (int I = 0; I <= oSpread.ActiveSheet.RowCount - 1; I++)
                                {
                                    oSpread.ActiveSheet.Cells[I, e.Column].Text = (string)(oSpread.ActiveSheet.Cells[I, e.Column].Text.PadRight(I_COLLEN_MAX, ' '));
                                }
                                oSpread.ActiveSheet.AutoSortColumn(e.Column);
                                for (int I = 0; I <= oSpread.ActiveSheet.RowCount - 1; I++)
                                {
                                    oSpread.ActiveSheet.Cells[I, e.Column].Text = (string)(oSpread.ActiveSheet.Cells[I, e.Column].Text.Trim());
                                }
                            }
                            else
                            {
                                oSpread.ActiveSheet.AutoSortColumn(e.Column);

                            } // 对应 If ss1.ActiveSheet.Columns.Get(e.Column).Tag = "N" Then

                        }
                    }
                    else
                    {
                        sCMenu.Show(oSpread, new Point(e.X, e.Y));
                    }
                }
                catch (Exception ex)
                {
                    GeneralCommon.Gp_MsgBoxDisplay(ex.Message, "", "");
                }
            }
            else if (e.RowHeader == true)
            {
               
            }
            else
            {
                if (oSpread.ActiveSheet.Columns.Get(e.Column).Tag.ToString() == "C" &&
                    (oSpread.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text.Trim() == "" || oSpread.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text.Trim() == (e.Row + 1).ToString()) &&
                    oSpread.ActiveSheet.Columns.Get(e.Column).Locked == false &&
                    oSpread.ActiveSheet.Rows.Get(e.Row).Locked == false &&
                    oSpread.ActiveSheet.Cells.Get(e.Row, e.Column).Locked == false &&
                    sAuthority.Substring(2, 1) == "1")
                {
                    oSpread.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text = "修改";
                    //SET EmpID
                    int colID = System.Convert.ToInt32(((Collection)Proc_Sc[i_ScCurrSeq])["authority"]);
                    if (colID > 0)
                    {
                        oSpread.Sheets[0].ActiveRowIndex = e.Row;
                        SpreadCommon.Gp_Sp_InAuthority((Collection)Proc_Sc[i_ScCurrSeq], int.Parse(((Collection)Proc_Sc[i_ScCurrSeq])["authority"].ToString()), "");
                    }
                }

                //'20090901,AShen,修改
                //'解决右键点击不变颜色的问题
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    oSpread.ActiveSheet.ActiveRowIndex = e.Row;
                }
            }

            //'如果点击行头或者列头则不进行下面步骤
            //'Added by ZZ@20091113
            if (oSpread.ActiveSheet.RowCount <= 0)
            {
                return;
            }

            if (oSpread.ActiveSheet.ActiveRowIndex <= 0)
            {
                return;
            }

            Collection cColumn = (Collection)Sc["cColumn"];
            string[] sCombinecol;
            string sCombinename;
            DataTable dt = null;
            FarPoint.Win.Spread.CellType.ComboBoxCellType ocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            ArrayList parr = new ArrayList();

            if (cColumn.Contains(e.Column.ToString()) && oSpread.ActiveSheet.Cells[e.Row, e.Column].Locked == false)
            {
                sCombinecol = ((Collection)Sc["cColumnB"])[e.Column.ToString()].ToString().Split(';');// split[Sc["cColumnB"][e.Column.ToString()], ";"];
                sCombinename = (string)(((Collection)Sc["cName"])[e.Column.ToString()]);

                for (int i = 0; i <= sCombinecol.Length - 1; i++)
                {
                    if (oSpread.ActiveSheet.Cells[e.Row, int.Parse(sCombinecol[i])] == null)
                    {
                        parr.Add("");
                    }
                    else
                    {
                        parr.Add(oSpread.ActiveSheet.Cells[e.Row, int.Parse(sCombinecol[i].Trim())]);
                    }
                }

                if (oSpread.ActiveSheet.Columns[e.Column].Tag == "OE")
                {
                    ocell.Editable = true;
                    ocell.AutoCompleteSource = AutoCompleteSource.ListItems;
                    ocell.AutoCompleteMode = AutoCompleteMode.Suggest;
                    dt = new ProcQuery(sCombinename, parr).CreateDataTable(false);
                }
                else if (oSpread.ActiveSheet.Columns[e.Column].Tag == "ON")
                {
                    ocell.Editable = false;
                    dt = new ProcQuery(sCombinename, parr).CreateDataTable(true);
                }

                if (dt != null)
                {
                    int c = dt.Rows.Count;
                    string[] items = new string[c - 1 + 1];
                    string[] values = new string[c - 1 + 1];
                    for (int i = 0; i <= c - 1; i++)
                    {
                        items[i] = (string)(dt.Rows[i][0].ToString());
                        values[i] = (string)(dt.Rows[i][1].ToString());
                    }
                    ocell.Items = items;
                    ocell.ItemData = values;
                    ocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
                    ocell.MaxDrop = 30;
                    oSpread.ActiveSheet.Cells[e.Row, e.Column].CellType = ocell;


                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ss1"></param>20130502BEGIN
        protected void copyDoMySelf(FarPoint.Win.Spread.FpSpread ss1)
        {
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss1.ActiveSheet.GetSelection(0);
            ss1.Sheets[0].ClipboardCopy(cr);           

        }
        //20130502BEGIN

        /// <summary>
        /// Spread单元格KeyUp事件，按下“Enter”键，当前活动单元格右移、换行或自动新增一行；同时按住“control-v"时进行粘贴。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected virtual void ss_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    FarPoint.Win.Spread.FpSpread ss1;
        //    ss1 = (FarPoint.Win.Spread.FpSpread)sender;
        //    ///////////////////////////////////20130502BEGIN
        //    if ((e.KeyCode == Keys.C) && e.Control)
        //    {
        //        e.Handled = true; // prevent clipboard copy
        //        //Clipboard.Clear();
        //        //copyDoMySelf(ss1);
        //        return;
        //    }
        //    /////////////////////////////////20130502END

        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (ss1.ActiveSheet.ActiveColumnIndex < ss1.ActiveSheet.ColumnCount - 1 &&
        //            ss1.ActiveSheet.ActiveRowIndex <= ss1.ActiveSheet.RowCount - 1)
        //        {
        //            ss1.ActiveSheet.ActiveColumnIndex = ss1.ActiveSheet.ActiveColumnIndex + 1;
        //        }
        //        else if (ss1.ActiveSheet.ActiveColumnIndex == ss1.ActiveSheet.ColumnCount - 1 &&
        //            ss1.ActiveSheet.ActiveRowIndex < ss1.ActiveSheet.RowCount - 1)
        //        {
        //            ss1.ActiveSheet.ActiveColumnIndex = 0;
        //            ss1.ActiveSheet.ActiveRowIndex = ss1.ActiveSheet.ActiveRowIndex + 1;
        //        }
        //        else if (ss1.ActiveSheet.ActiveColumnIndex == ss1.ActiveSheet.ColumnCount - 1 &&
        //            ss1.ActiveSheet.ActiveRowIndex == ss1.ActiveSheet.RowCount - 1)
        //        {
        //            Spread_Ins();
        //        }
        //    }

        //    if (e.Control == true && e.KeyCode == Keys.V)
        //    {
        //        if (ss1.Sheets[0].RowCount == 0)
        //        {
        //            return;
        //        }
        //        Debug.WriteLine(System.Convert.ToString("keyup时获取的selection" + ss1.Sheets[0].GetSelection(System.Convert.ToInt32(ss1.Sheets[0].SelectionCount - 1)).RowCount));
        //        for (int i = 0; i <= ss1.Sheets[0].GetSelection(System.Convert.ToInt32(ss1.Sheets[0].SelectionCount - 1)).RowCount - 1; i++)
        //        {
        //            if (ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text == "")
        //            {
        //                ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text = "修改";
        //                //SET EmpID
        //                int colID = System.Convert.ToInt32(((Collection)Proc_Sc[i_ScCurrSeq])["authority"]);
        //                if (colID > 0)
        //                {
        //                    ss1.Sheets[0].Cells.Get(ss1.Sheets[0].ActiveRowIndex, colID).Text = GeneralCommon.sUserID;
        //                }
        //            }
        //        }
        //    }

        //}
        protected virtual void ss_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss1;
            ss1 = (FarPoint.Win.Spread.FpSpread)sender;
            ///////////////////////////////////20130502BEGIN
            //if ((e.Control) && e.KeyCode == Keys.C)
            //{
            //    copyDoMySelf(ss1);
            //    return;
            //}
            //if ((e.Control))
            //{
            //    if (e.KeyCode == Keys.C)
            //    {
            //        copyDoMySelf(ss1);
            //        return;
            //    }
            //}
            //if (e.KeyCode == Keys.C)
            //{
            //    if ((e.Control))
            //    {
            //        copyDoMySelf(ss1);
            //        return;
            //    }
            //}
            /////////////////////////////////20130502END

            if (e.KeyCode == Keys.Enter)
            {
                if (ss1.ActiveSheet.ActiveColumnIndex < ss1.ActiveSheet.ColumnCount - 1 &&
                    ss1.ActiveSheet.ActiveRowIndex <= ss1.ActiveSheet.RowCount - 1)
                {
                    ss1.ActiveSheet.ActiveColumnIndex = ss1.ActiveSheet.ActiveColumnIndex + 1;
                }
                else if (ss1.ActiveSheet.ActiveColumnIndex == ss1.ActiveSheet.ColumnCount - 1 &&
                    ss1.ActiveSheet.ActiveRowIndex < ss1.ActiveSheet.RowCount - 1)
                {
                    ss1.ActiveSheet.ActiveColumnIndex = 0;
                    ss1.ActiveSheet.ActiveRowIndex = ss1.ActiveSheet.ActiveRowIndex + 1;
                }
                else if (ss1.ActiveSheet.ActiveColumnIndex == ss1.ActiveSheet.ColumnCount - 1 &&
                    ss1.ActiveSheet.ActiveRowIndex == ss1.ActiveSheet.RowCount - 1)
                {
                    Spread_Ins();
                }
            }

            if (e.Control == true && e.KeyCode == Keys.V)
            {
                if (ss1.Sheets[0].RowCount == 0)
                {
                    return;
                }
                Debug.WriteLine(System.Convert.ToString("keyup时获取的selection" + ss1.Sheets[0].GetSelection(System.Convert.ToInt32(ss1.Sheets[0].SelectionCount - 1)).RowCount));
                for (int i = 0; i <= ss1.Sheets[0].GetSelection(System.Convert.ToInt32(ss1.Sheets[0].SelectionCount - 1)).RowCount - 1; i++)
                {
                    if (ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text == "")
                    {
                        ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text = "修改";
                        //SET EmpID
                        int colID = System.Convert.ToInt32(((Collection)Proc_Sc[i_ScCurrSeq])["authority"]);
                        if (colID > 0)
                        {
                            ss1.Sheets[0].Cells.Get(ss1.Sheets[0].ActiveRowIndex, colID).Text = GeneralCommon.sUserID;
                        }
                    }
                }
            }

        }
     
        private void maskedDateMouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            string TimeStr = AdoRs.Fields[0].Value.ToString();
            if (((MaskedDate)sender).Mask == "90:00:00") ((MaskedDate)sender).Text = TimeStr.Substring(8, 6);
            else ((MaskedDate)sender).Text = TimeStr;

        }

       
        /// <summary>
        /// 页面自定义快捷键。
        //F2：查询；F3：保存；
        //F4：F4弹出事件；F6：Spread插入行；
        //F7：Spread行删除；F8:Spread行取消。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected virtual void ss_KeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if ((e.KeyCode == Keys.C) && e.Control)
        //    {
        //        e.Handled = true;
        //        Clipboard.Clear();
        //        copyDoMySelf((FarPoint.Win.Spread.FpSpread)sender);
        //        return;
        //    }
        //    if (e.Control) return;//1224
        //    switch (e.KeyCode)
        //    {
        //        case Keys.F2:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_Refer"].Tag == "T") //refer
        //            {
        //                Form_Ref();
        //            }
        //            break;
        //        case Keys.F3:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_Save"].Tag == "T") //pro
        //            {
        //                Form_Pro();
        //            }
        //            break;
        //        case Keys.F6:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowIns"].Tag == "T") //input
        //            {
        //                Spread_Ins();
        //            }
        //            break;
        //        case Keys.F7:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowDel"].Tag == "T") //delete
        //            {
        //                Spread_Del();
        //            }
        //            break;
        //        case Keys.F8:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowCan"].Tag == "T") //onerow
        //            {
        //                Spread_Can();
        //            }
        //            break;
        //    }
        //    f4set(e);
        //}
        //protected virtual void ss_KeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    ////////////////20130521BEGIN
        //    FarPoint.Win.Spread.FpSpread ss1;
        //    ss1 = (FarPoint.Win.Spread.FpSpread)sender;
        //    if ((e.KeyCode == Keys.C) && e.Control) //Ctrl+C
        //    {
        //        e.Handled = true; // prevent clipboard copy
        //        Clipboard.Clear();
        //        ss1.ActiveSheet.ClipboardCopy();
        //        return;
        //    }


        //    ////////////////20130521END
        //    //if (e.Control) return;//1224
        //    switch (e.KeyCode)
        //    {
        //        case Keys.F2:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_Refer"].Tag == "T") //refer
        //            {
        //                Form_Ref();
        //            }
        //            break;
        //        case Keys.F3:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_Save"].Tag == "T") //pro
        //            {
        //                Form_Pro();
        //            }
        //            break;
        //        case Keys.F6:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowIns"].Tag == "T") //input
        //            {
        //                Spread_Ins();
        //            }
        //            break;
        //        case Keys.F7:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowDel"].Tag == "T") //delete
        //            {
        //                Spread_Del();
        //            }
        //            break;
        //        case Keys.F8:
        //            if (GeneralCommon.MDIToolBar.Buttons["Btn_RowCan"].Tag == "T") //onerow
        //            {
        //                Spread_Can();
        //            }
        //            break;
        //    }
        //    f4set(e);
        //}
        protected virtual void ss_KeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ////////////////20130521BEGIN
            FarPoint.Win.Spread.FpSpread ss1;
            ss1 = (FarPoint.Win.Spread.FpSpread)sender;
            if ((e.KeyCode == Keys.C) && e.Control) //Ctrl+C
            {
                e.Handled = true; // prevent clipboard copy
                Clipboard.Clear();
                ss1.ActiveSheet.ClipboardCopy();
                return;
            }

            if (e.Control) return;
            ////////////////20130521END
            //if (e.Control) return;//1224
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (GeneralCommon.MDIToolBar.Buttons["Btn_Refer"].Tag == "T") //refer
                    {
                        Form_Ref();
                    }
                    break;
                case Keys.F3:
                    if (GeneralCommon.MDIToolBar.Buttons["Btn_Save"].Tag == "T") //pro
                    {
                        Form_Pro();
                    }
                    break;
                case Keys.F6:
                    if (GeneralCommon.MDIToolBar.Buttons["Btn_RowIns"].Tag == "T") //input
                    {
                        Spread_Ins();
                    }
                    break;
                case Keys.F7:
                    if (GeneralCommon.MDIToolBar.Buttons["Btn_RowDel"].Tag == "T") //delete
                    {
                        Spread_Del();
                    }
                    break;
                case Keys.F8:
                    if (GeneralCommon.MDIToolBar.Buttons["Btn_RowCan"].Tag == "T") //onerow
                    {
                        Spread_Can();
                    }
                    break;
            }
            if (e.KeyCode == Keys.F4)
                f4set(e);
        }


        private void f4set(System.Windows.Forms.KeyEventArgs e)
        {
            if (GeneralCommon.Gf_IsFormLodeN("DataDic")) return;

            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Escape)
            {
                return;
            }

            string sTemp_Code = "";
            string sCode = "";
            string f4Type = "";

            FarPoint.Win.Spread.FpSpread ss1;
            Collection Sc;
            string[] sCombinecol;
            string[] sCombinename;
            string[] Ass = new string[3];

            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];

            if (ss1.ActiveSheet.RowCount <= 0)
            {
                return;
            }
            if (ss1.ActiveSheet.ActiveRowIndex < 0)
            {
                return;
            }



            int cRI = ss1.ActiveSheet.ActiveRowIndex;
            int cCI = ss1.ActiveSheet.ActiveColumnIndex;

            //'当为主键时，只有插入时才能弹出
            for (int i = 1; i <= ((Collection)Sc["pColumn"]).Count; i++)
            {
                Collection sc_p = (Collection)Sc["pColumn"];
                if (ss1.ActiveSheet.ActiveColumnIndex == (int)sc_p[i])
                {
                    if (ss1.ActiveSheet.RowHeader.Cells.Get(cRI, 0).Text.Trim() != "增加")
                    {
                        return;
                    }
                }
            }

            Collection fColumn = (Collection)Sc["fColumn"];
            Collection cColumn = (Collection)Sc["cColumn"];

            try
            {
                if (fColumn.Contains(cCI.ToString()))
                {

                    f4Type = ss1.ActiveSheet.Columns[cCI].Tag.ToString();
                    string fcode_s = ((Collection)Sc["fcode"])[cCI.ToString()].ToString();
                    Ass = fcode_s.Split('@');// split[Sc["fcode"][cCI.ToString()], "@"];
                    string sKey = Ass[0];
                    string sJoin = Ass[1];
                    string sCusCode = Ass[2];

                    switch (f4Type)
                    {
                        case "COMR":
                            if (e.KeyCode == Keys.F4)
                            {
                               // DataDicCommon.Gf_CommonCode_DD_SP(ss1, cCI, cCI + 1, sKey, sJoin);
                                DataDicCommon.Gf_CommonCode_DD_SP(ss1, cCI, cCI + 1, sKey, sJoin, sAuthority, Sc);//1023
                            }
                            else
                            {

                                sTemp_Code = ss1.ActiveSheet.Cells[cRI, cCI].Text.Trim().ToUpper();
                                FarPoint.Win.Spread.CellType.TextCellType celltype = (FarPoint.Win.Spread.CellType.TextCellType)ss1.ActiveSheet.Columns[cCI].CellType;


                                if (sTemp_Code.Length == celltype.MaxLength)
                                {
                                    ss1.ActiveSheet.Cells[cRI, cCI + 1].Text = DataDicCommon.Gf_CommNameFind(GeneralCommon.M_CN1, sCode.Substring(0, 5), sTemp_Code.Trim(), "2");
                                }
                                else
                                {
                                    ss1.ActiveSheet.Cells[cRI, cCI + 1].Text = "";
                                }

                            }
                            break;
                        case "COMN":
                            if (e.KeyCode == Keys.F4)
                            {
                               // DataDicCommon.Gf_CommonCode_DD_SP(ss1, cCI, -1, sKey, sJoin);
                                DataDicCommon.Gf_CommonCode_DD_SP(ss1, cCI, -1, sKey, sJoin, sAuthority, Sc);//1023
                            }
                            break;

                        case "ETCR":
                            if (e.KeyCode == Keys.F4)
                            {
                                string[] fc = sKey.Split(';');
                                string[] rc = sJoin.Split(';');
                                Collection fcc = new Collection();
                                Collection rcc = new Collection();
                                int i;
                                for (i = 0; i <= fc.Length - 1; i++)
                                {
                                    fcc.Add(fc[i], null, null, null);
                                }
                                for (i = 0; i <= rc.Length - 1; i++)
                                {
                                    rcc.Add(rc[i], null, null, null);
                                }
                               // DataDicCommon.Gf_EtcCommon_DD_SP(ss1, rcc, fcc, sCusCode, "");
                                DataDicCommon.Gf_EtcCommon_DD_SP(ss1, rcc, fcc, sCusCode, "", sAuthority, Sc);//1023
                            }
                            break;

                        case "ETCN":
                            if (e.KeyCode == Keys.F4)
                            {
                                Collection fcc = new Collection();
                                Collection rcc = new Collection();
                                fcc.Add(sKey, null, null, null);
                                rcc.Add(cCI, null, null, null);
                                //DataDicCommon.Gf_EtcCommon_DD_SP(ss1, rcc, fcc, sCusCode, "");
                                DataDicCommon.Gf_EtcCommon_DD_SP(ss1, rcc, fcc, sCusCode, "", sAuthority, Sc);//1023
                            }
                            break;
                    }

                }

             //   ss_UpdateMark();//1023
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }

                GeneralCommon.Gp_MsgBoxDisplay((string)("f4set Error : " + ex.Message), "", "");
            }

        }


        /// <summary>
        /// Spread单元格LeaveCell事件，当Spread单元格光标离开时，判断内容是否改变，如果改变，在行头添加“修改”标志。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ss_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            Collection Sc;
            FarPoint.Win.Spread.FpSpread ss1;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];

            string xx;
            for (int i = 1; i <= ((Collection)Sc["fColumn"]).Count; i++)
            {
                Collection Sc_fcode_collection = (Collection)Sc["fcode"];
                Collection sc_fcode_fcol = (Collection)Sc_fcode_collection["fColumn"];
                string sc_fcode_fcol_i = sc_fcode_fcol[i].ToString();
                //if (Sc["fcode"].[Sc["fColumn"]].Item(i).ToString().Substring(3, 1) == "R")
                if (sc_fcode_fcol_i.Substring(3, 1) == "R")
                {
                    xx = ss1.ActiveSheet.RowHeader.Cells.Get(ss1.ActiveSheet.ActiveRowIndex, 0).Text.Trim();
                    if (xx == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay(System.Convert.ToString(ss1.ActiveSheet.ActiveColumnIndex + "输入不符合要求，请检查！"), "W", "");
                        return;
                    }
                }
            }
            if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U"))
            {
                SpreadCommon.Gp_Sp_UpdateMark((FarPoint.Win.Spread.FpSpread)Sc["Spread"], ss1.ActiveSheet.ActiveRowIndex, ss1.ActiveSheet.ActiveColumnIndex);
            }
        }
        /// <summary>
        /// Spread单元格EditChange事件，当修改单元格内容时在行头添加“修改”标志。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ss_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {

            if (isRefer)
            {
                return;
            }
            Collection Sc;
            FarPoint.Win.Spread.FpSpread ss1;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U"))
            {
                if (ss1.ActiveSheet.RowHeader.Cells.Get(ss1.ActiveSheet.ActiveRowIndex, 0).Text.Trim() != "增加")
                {
                    ss1.ActiveSheet.RowHeader.Cells.Get(ss1.ActiveSheet.ActiveRowIndex, 0).Text = "修改";
                    ss1.Refresh(); // 2009-7-6耿朝雷增加，为解决修改后行头不能出现“修改”字样
                    //SET EmpID
                    int colID = System.Convert.ToInt32(Sc["authority"].ToString());
                    if (colID > 0)
                    {
                        SpreadCommon.Gp_Sp_InAuthority(Sc, (int)Sc["authority"], "");
                    }
                }
            }
        }


        //create by wangyong 20071210
        /// <summary>
        /// 未用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void ss_DragDropBlockCompleted(object sender, FarPoint.Win.Spread.DragDropBlockCompletedEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss1;
            Collection Sc;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            for (int i = e.DestinationRowBegin; i <= e.DestinationRowEnd; i++)
            {
                GeneralCommon.Gf_RowUpdate(ss1, i);
            }
            if (e.Action == 0)
            {
                for (int i = e.RowBegin; i <= e.RowEnd; i++)
                {
                    GeneralCommon.Gf_RowUpdate(ss1, i);
                }
            }
        }

        //create by wangyong 20071210
        /// <summary>
        /// 未用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void ss_DragFillBlockCompleted(object sender, FarPoint.Win.Spread.DragFillBlockCompletedEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss1;
            Collection Sc;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            switch (e.Direction)
            {
                case FarPoint.Win.Spread.FillDirection.Left:
                case FarPoint.Win.Spread.FillDirection.Right:
                    for (int i = e.RowBegin; i <= e.RowEnd; i++)
                    {
                        GeneralCommon.Gf_RowUpdate(ss1, i);
                    }
                    break;
                case FarPoint.Win.Spread.FillDirection.Up:
                    for (int i = e.RowBegin - e.NumberToCopy; i <= e.RowEnd - 1; i++)
                    {
                        GeneralCommon.Gf_RowUpdate(ss1, i);
                    }
                    break;
                case FarPoint.Win.Spread.FillDirection.Down:
                    for (int i = e.RowEnd + 1; i <= e.RowEnd + e.NumberToCopy; i++)
                    {
                        GeneralCommon.Gf_RowUpdate(ss1, i);
                    }
                    break;
            }

        }

        protected void ReLoadF4CusCode(string sComCode, string sJoin, string sCusCode, int index)
        {
            Collection Sc;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ((Collection)Sc["fcode"]).Remove(index.ToString());
            ((Collection)Sc["fcode"]).Add(sComCode.Trim().ToUpper() + "@" + sJoin.Trim() + "@" + sCusCode, index.ToString());
        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void ss_ComboDropDown(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {

        }

        /////////////////////////////////////1023
        public virtual void ss_UpdateMark()
        {
            Collection Sc;
            Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            FarPoint.Win.Spread.FpSpread ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U"))
            {
                if (ss1.ActiveSheet.RowHeader.Cells.Get(ss1.ActiveSheet.ActiveRowIndex, 0).Text.Trim() != "增加")
                {
                    ss1.ActiveSheet.RowHeader.Cells.Get(ss1.ActiveSheet.ActiveRowIndex, 0).Text = "修改";
                    ss1.Refresh();
                    int colID = System.Convert.ToInt32(Sc["authority"].ToString());
                    if (colID > 0)
                    {
                        SpreadCommon.Gp_Sp_InAuthority(Sc, (int)Sc["authority"], "");
                    }
                }
            }
        }
        /////////////////////////////////////1023
        /// <summary>
        /// 未用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ss_ClipboardPasting(object sender, FarPoint.Win.Spread.ClipboardPastingEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss1;
            Collection Sc = (Collection)Proc_Sc[i_ScCurrSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            if (ss1.Sheets[0].RowCount == 0)
            {
                return;
            }
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = ss1.Sheets[0].GetSelection(System.Convert.ToInt32(ss1.Sheets[0].SelectionCount - 1));
            int rowcount;
            if (cr == null)
            {
                rowcount = 0;
            }
            else
            {
                rowcount = cr.RowCount;
            }
            Debug.WriteLine("pastion时获取的selection" + rowcount);

            for (int i = 0; i <= rowcount; i++)
            {
                if (ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text == "")
                {
                    ss1.Sheets[0].RowHeader.Cells.Get(System.Convert.ToInt32(ss1.Sheets[0].ActiveRowIndex + i), 0).Text = "修改";
                    ss1.Refresh(); //2009-7-6
                    int colID = int.Parse(Sc["authority"].ToString());// System.Convert.ToInt32((string)Sc["authority"]);
                    if (colID > 0)
                    {
                        ss1.Sheets[0].Cells.Get(ss1.Sheets[0].ActiveRowIndex, colID).Text = GeneralCommon.sUserID;
                    }
                }
            }

        }

        #endregion

        #region Etc Event Process...

       /// <summary>
       /// 
       /// </summary>
        protected virtual void p_SubFormInit()
        {

        }

        
        /// <summary>
        //初始化Mc。将pControl等集合放入Mc中，假如Master有
        //增删改查，那么也将对应的后台放入集合Mc中。
        //Mc:Mc集合
        //bproflag：Mc是否只做查询条件。true：不仅做查询条件，还对Master进行增删改查。false：Mc只做查询条件
        /// </summary>
        /// <param name="Mc"></param>
        /// <param name="bproflag"></param>
       
        protected void p_McIni(Collection Mc, bool bproflag)
        {
            Collection pControl = new Collection(); //Master Primary Key Collection
            Collection nControl = new Collection(); //Master Necessary Collection
            Collection mControl = new Collection(); //Master Maxlength check Collection
            Collection iControl = new Collection(); //Master Insert Collection
            Collection rControl = new Collection(); //Master Refer Collection
            Collection cControl = new Collection(); //Master Copy Collection
            Collection aControl = new Collection(); //Master -> Spread Collection
            Collection lControl = new Collection(); //Master Lock Collection
            Collection npControl = new Collection(); //

            try
            {
                //MASTER Collection
                Mc.Add(pControl, "pControl", null, null);
                Mc.Add(nControl, "nControl", null, null);
                Mc.Add(mControl, "mControl", null, null);
                Mc.Add(iControl, "iControl", null, null);
                Mc.Add(rControl, "rControl", null, null);
                Mc.Add(cControl, "cControl", null, null);
                Mc.Add(aControl, "aControl", null, null);
                Mc.Add(lControl, "lControl", null, null);
                Mc.Add(npControl, "npControl", null, null);

                if (bproflag)
                {
                    Mc.Add(sSvrPgmPkgName + ".P_MREFER" + (Proc_Mc.Count == 0 ? "" : Proc_Mc.Count.ToString()), "P-R", null, null);
                    Mc.Add(sSvrPgmPkgName + ".P_MMODIFY" + (Proc_Mc.Count == 0 ? "" : Proc_Mc.Count.ToString()), "P-M", null, null);
                    Mc.Add(sSvrPgmPkgName + ".P_MONEROW" + (Proc_Mc.Count == 0 ? "" : Proc_Mc.Count.ToString()), "P-O", null, null);
                    MasterCommon.iMcRecord = bproflag;//20130228
                }

                Mc.Add(bproflag, "pro", null, null);
                Proc_Mc.Add(Mc, null, null, null);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("p_McIni Error : " + ex.Message), "", "");
            }
        }

        
        /// <summary>
        /// 初始化Sc
        /// ospread:Spread对象
        /// Sc：Sc集合。
        /// iAuthority：记录当前操作者在当前Spread的列号。
        /// bSort：Spread是否具有排序功能。
        /// bLock：Spread是否锁定
        /// </summary>
        /// <param name="ospread"></param>
        /// <param name="Sc"></param>
        /// <param name="iAuthority"></param>
        /// <param name="bSort"></param>
        /// <param name="bLock"></param>
        protected void p_ScIni(FarPoint.Win.Spread.FpSpread ospread, Collection Sc, int iAuthority, bool bSort, bool bLock)
        {
            //ospread.ActiveSheet.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default;//20131220
            
            Collection pColumn1 = new Collection(); //Spread Primary Key Collection
            Collection nColumn1 = new Collection(); //Spread Necessary Column Collection
            Collection mColumn1 = new Collection(); //Spread Maxlength check Column Collection
            Collection iColumn1 = new Collection(); //Spread Insert Column Collection
            Collection aColumn1 = new Collection(); //Master -> Spread Column Collection
            Collection lColumn1 = new Collection(); //Spread Lock Column Collection
            Collection fColumn1 = new Collection(); //提供F4功能的列
            Collection fcode = new Collection();
            Collection combineColumn1 = new Collection(); //联动更新的主列
            Collection combineColumnB = new Collection(); //联动更新的关联列
            Collection combineName = new Collection(); //联动更新的关联列所对应的字段名
            Collection sqlC = new Collection(); //存储f4或者combox的sql语句


         
            ospread.EditModeReplace = true;
            ospread.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;
            bSortCol = bSort;

            try
            {
                ospread.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.ColumnHeaders;

                //Spread_Collection
                Sc.Add(ospread, "Spread", null, null);
                Sc.Add(sSvrPgmPkgName + ".P_SMODIFY" + (Proc_Sc.Count == 0 ? "" : Proc_Sc.Count.ToString()), "P-M", null, null);
                Sc.Add(sSvrPgmPkgName + ".P_SREFER" + (Proc_Sc.Count == 0 ? "" : Proc_Sc.Count.ToString()), "P-R", null, null);
                Sc.Add(sSvrPgmPkgName + ".P_SONEROW" + (Proc_Sc.Count == 0 ? "" : Proc_Sc.Count.ToString()), "P-O", null, null);

                Sc.Add(pColumn1, "pColumn", null, null);
                Sc.Add(nColumn1, "nColumn", null, null);
                Sc.Add(aColumn1, "aColumn", null, null);
                Sc.Add(mColumn1, "mColumn", null, null);
                Sc.Add(iColumn1, "iColumn", null, null);
                Sc.Add(lColumn1, "lColumn", null, null);
                Sc.Add(fColumn1, "fColumn", null, null);
                Sc.Add(fcode, "fcode", null, null);
                Sc.Add(combineColumn1, "cColumn", null, null);//联动更新的主列
                Sc.Add(combineColumnB, "cColumnB", null, null);//联动更新的关联列
                Sc.Add(combineName, "cName", null, null);//联动更新的关联列所对应的字段名
                Sc.Add(sqlC, "sql", null, null);//存储f4或者combox的sql语句

                Sc.Add(bSort, "sort", null, null);
                Sc.Add(iAuthority, "authority", null, null);
                Sc.Add(bLock, "lock", null, null);

                //'供PopupSheet用 JIA
                Sc.Add(new Collection(), "CHTitle", null, null);
                Sc.Add(new Collection(), "ColType", null, null);
                Sc.Add(new Collection(), "ColLength", null, null);
                Sc.Add(new Collection(), "Filter", null, null);
                Sc.Add(new Collection(), "CustQuery", null, null);
                Sc.Add(new Collection(), "ComCode", null, null);
                Sc.Add(new Collection(), "ColAttr", null, null);

                //'供DataSet用 JIA
                Sc.Add(new Collection(), "ColumnCaption", null, null);

                ss_default_width = new int[500];
                for (int i = 0; i < ospread.ActiveSheet.ColumnCount; i++)
                {
                    ss_default_width[i] = (int)ospread.ActiveSheet.Columns[i].Width;
                }

                ospread.Sheets[0].ColumnCount = 0;
                ospread.Sheets[0].RowCount = 0;
                ospread.Sheets[0].RowHeader.Columns.Get(0).Width = 50;
                //20131220
                FarPoint.Win.Spread.StyleInfo darkstyle = new FarPoint.Win.Spread.StyleInfo();
                darkstyle.BackColor = Color.PowderBlue;
                ospread.Sheets[0].ColumnHeader.DefaultStyle = darkstyle;
                //20131220
                //ospread.Sheets[0].Columns.Default.Width = 50;

                Sc.Add(0, "First", null, null);
                Sc.Add(ospread.Sheets[0].ColumnCount - 1, "Last", null, null);

                //modify by wangyong 2007-12-09
                ospread.AllowDragDrop = true;
                ospread.AllowDragFill = true;
                Proc_Sc.Add(Sc, null, null, null);

                ospread.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(ss_CellClickEvent);
                ospread.KeyUp += new System.Windows.Forms.KeyEventHandler(ss_KeyUp);

                ospread.KeyDown += new System.Windows.Forms.KeyEventHandler(ss_KeyDownEvent);
                ospread.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(ss_EditChange);
                ospread.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(ss_CellDoubleClick);
                //wangyong
                ospread.DragDropBlockCompleted += new FarPoint.Win.Spread.DragDropBlockCompletedEventHandler(ss_DragDropBlockCompleted);
                ospread.DragFillBlockCompleted += new FarPoint.Win.Spread.DragFillBlockCompletedEventHandler(ss_DragFillBlockCompleted);

                //20130220
                ospread.SubEditorOpening += new FarPoint.Win.Spread.SubEditorOpeningEventHandler(ospread_SubEditorOpening);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("p_ScIni Error : " + ex.Message), "", "");
            }

        }

        //20130220添加ydk
        protected virtual void ospread_SubEditorOpening(object sender, FarPoint.Win.Spread.SubEditorOpeningEventArgs e)
        {
            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)sender;
            FarPoint.Win.Spread.CellType.DateTimeCellType ccell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            try
            {
                ccell = (FarPoint.Win.Spread.CellType.DateTimeCellType)ss.ActiveSheet.Columns.Get(ss.ActiveSheet.ActiveCell.Column.Index).CellType;
                if (ccell.DateTimeFormat.CompareTo(FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDateWithTime) == 0)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                e.Cancel = false;
            }       
        }
        //20130220添加完成ydk

        /// <summary>
        /// 根据控件类型初始化控件，并且定义属性，调用
        /// Gp_Ms_Collection（）将控件放入Mc中。
        /// sname：控件代表的字段名
        /// Ctrl：控件
        /// sAttr：控件属性
        /// sLenth：控件长度
        /// sComboComText:combox的公共代码的代码管理号
        /// sComboxJoin：combox的公共代码的筛选条件
        /// sComboCusText：combox的自定义查询语句
        /// McSeq：Mc的序列号
        /// </summary>
        /// <param name="sname"></param>
        /// <param name="Ctrl"></param>
        /// <param name="sAttr"></param>
        /// <param name="sLenth"></param>
        /// <param name="sComboComText"></param>
        /// <param name="sComboxJoin"></param>
        /// <param name="sComboCusText"></param>
        /// <param name="McSeq"></param>
        protected void p_SetMc(string sname, Control Ctrl, string sAttr, string sLenth, string sComboComText, string sComboxJoin, string sComboCusText, int McSeq)
        {

            string pFlag = "";
            string rFlag = "";
            string nFlag = "";
            string mFlag = "";
            string iFlag = "";
            string aFlag = "";
            string lFlag = "";
            string sna = sname.Trim();

            tabindex_count++;
            Ctrl.TabIndex = tabindex_count;
            Ctrl.Tag = sna;
            try
            {
                if (Ctrl is FarPoint.Win.Spread.FpSpread)
                {
                }
               
                else if (Ctrl is CeriUDate)
                {
                    ((CeriUDate)Ctrl).maskedTextBox1.MouseDoubleClick += new MouseEventHandler(CeriUDateDbClick);
                }

                else if (Ctrl is MaskedDate)
                {
                    MaskedDate dtpTemp = (MaskedDate)Ctrl;
                    dtpTemp.MouseDoubleClick += new MouseEventHandler(maskedDateMouseDoubleClick);
                    switch (sLenth)
                    {
                        //日期+时间
                        case "19":
                            dtpTemp.Mask = "0000-00-00 90:00:00";
                            break;
                        //日期+小时+分钟
                        case "16":
                            dtpTemp.Mask = "0000-00-00 90:00";
                            break;
                        //日期
                        case "10":
                            dtpTemp.Mask = "0000-00-00";
                            break;
                        //时间
                        case "8":
                            dtpTemp.Mask = "90:00:00";
                            break;
                        case "7"://0116
                            dtpTemp.Mask = "0000-00";
                            break;
                        case "4":
                            dtpTemp.Mask = "0000";
                            break;//0116
                        default:
                            dtpTemp.Mask = "0000-00-00 90:00:00";
                            break;
                    }
                }


                else if (Ctrl is TextBox) 
                {
                    TextBox txtTemp = (TextBox)Ctrl;
                    txtTemp.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? txtTemp.MaxLength.ToString() : sLenth.Trim());//0108
                }
                else if (Ctrl is ComboBox) 
                {
                    ComboBox cboTemp = (ComboBox)Ctrl;
                    if (cboTemp.DropDownStyle == ComboBoxStyle.DropDown)
                    {
                        cboTemp.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? cboTemp.MaxLength.ToString() : sLenth.Trim());//0108
                    }

                    if (sComboComText.Trim().Length != 0 && sComboCusText.Trim().Length != 0)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("P_SETM错误 控件<" + ctrl.Tag + ">不能同时取公共代码和自定义语句", "W", "");
                        return;
                    }
                    else if (sComboComText.Trim().Length != 0)
                    {
                        cboTemp.DropDownStyle = ComboBoxStyle.DropDownList;
                        cboTemp.RightToLeft = RightToLeft.No;
                        Query qu = new CdQuery(sComboComText, sComboxJoin);
                        DataTable dt = qu.CreateDataTable(true);
                        cboTemp.DataSource = dt;
                        cboTemp.DisplayMember = dt.Columns[0].ToString();
                        cboTemp.ValueMember = dt.Columns[1].ToString();
                        cboTemp.SelectedIndex = 0;

                    }
                    else if (sComboCusText.Trim().Length != 0)
                    {
                        cboTemp.DropDownStyle = ComboBoxStyle.DropDown;
                        cboTemp.RightToLeft = RightToLeft.No;
                        DataTable dt = new Query(sComboCusText.Trim() + " " + sComboxJoin.Trim()).CreateDataTable(false);
                        cboTemp.DataSource = dt;
                        if (dt.Columns.Count > 1)
                        {
                            cboTemp.DisplayMember = dt.Columns[0].ToString();
                            cboTemp.ValueMember = dt.Columns[1].ToString();
                        }
                        else
                        {
                            cboTemp.DisplayMember = dt.Columns[0].ToString();
                            cboTemp.ValueMember = dt.Columns[0].ToString();
                        }
                        cboTemp.SelectedValue = "";
                        cboTemp.AutoCompleteMode = AutoCompleteMode.Suggest;
                        cboTemp.AutoCompleteSource = AutoCompleteSource.ListItems;
                    }

                }
                else if (Ctrl is DateTimePicker)
                {
                    DateTimePicker dtpTemp = (DateTimePicker)Ctrl;
                    switch (sLenth)
                    {
                        case "19":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                            break;
                        case "10":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "yyyy-MM-dd";
                            break;
                        case "8":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "HH:mm:ss";
                            break;
                    }
                }
                else if (Ctrl is NumericUpDown) 
                {
                    NumericUpDown nudTemp = (NumericUpDown)Ctrl;
                    int precision;
                    int Scale;
                    if (sLenth.IndexOf(",") != -1)
                    {
                        Scale = (int.Parse(sLenth.Substring(0, sLenth.IndexOf(",")))) - int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                        precision = int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                    }
                    else
                    {
                        Scale = int.Parse(sLenth);
                        precision = 0;
                    }
                    nudTemp.DecimalPlaces = precision;
                    nudTemp.Maximum = long.Parse((string)("9".PadLeft(Scale, '9')));
                    nudTemp.Minimum = System.Convert.ToDecimal(-long.Parse((string)("9".PadLeft(Scale, '9'))));

                }
                    
                //默认为r
                if (sAttr.Trim() == "")
                {
                    rFlag = "r";
                }
                else
                {
                    if (sAttr.ToUpper().IndexOf("P") != -1)
                    {
                        pFlag = "p";
                    }
                    if (sAttr.ToUpper().IndexOf("A") != -1)
                    {
                        aFlag = "a";
                    }
                    if (sAttr.ToUpper().IndexOf("M") != -1)
                    {
                        mFlag = "m";
                    }
                    if (sAttr.ToUpper().IndexOf("N") != -1)
                    {
                        nFlag = "n";
                    }
                    if (sAttr.ToUpper().IndexOf("I") != -1)
                    {
                        iFlag = "i";
                    }
                    if (sAttr.ToUpper().IndexOf("L") != -1)
                    {
                        lFlag = "l";
                    }
                    if (sAttr.ToUpper().IndexOf("R") != -1 && !(Ctrl is MixComboBox))
                    {
                        rFlag = "r";
                    }
                }

                // 处理该控件的集插入
                MasterCommon.Gp_Ms_Collection(Ctrl, pFlag, nFlag, mFlag, iFlag, rFlag, aFlag, lFlag,
                    (Collection)((Collection)Proc_Mc[McSeq])["pControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["nControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["mControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["iControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["rControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["aControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["lControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["npControl"]
                    );
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("p_SetMc Error : " + ctrl.Name + ex.Message), "", "");
            }

        }


        /// <summary>
        ///初始化当前Spread，将spread各列加载到初始化的Sc中
        ///sColName：spread当前列列头显示的文字
        ///sType：Spread当前列的类型
        ///sLenth：Spread当前列的长度
        ///sAttr：属性
        ///sComCode：ON或OE列的公共代码的代码管理号
        ///sJoin：ON或OE列的公共代码的筛选条件
        ///sCusCode：ON或OE列的自定义查询语句
        ///ScSeq：Sc的序列号
        ///iHeaderRow：Spread列头行数。
        /// </summary>
        /// <param name="sColName"></param>
        /// <param name="sType"></param>
        /// <param name="sLenth"></param>
        /// <param name="sAttr"></param>
        /// <param name="sComCode"></param>
        /// <param name="sJoin"></param>
        /// <param name="sCusCode"></param>
        /// <param name="sCombineCol"></param>
        /// <param name="sCombineName"></param>
        /// <param name="ScSeq"></param>
        /// <param name="iHeaderRow"></param>
        protected void p_SetSc(string sColName, string sType, string sLenth, string sAttr, string sComCode, string sJoin, string sCusCode, string sCombineCol, string sCombineName, int ScSeq, int iHeaderRow)
        {


            Collection Sc;
            FarPoint.Win.Spread.FpSpread ss1;
            Sc = (Collection)Proc_Sc[ScSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            sColName = sColName.Trim();

            //供PopupSheet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["CHTitle"]).Add(sColName, null, null, null); //Column Header Title
                ((Collection)Sc["ColType"]).Add(sType, null, null, null); //Column Type
                ((Collection)Sc["ColLength"]).Add(sLenth, null, null, null); //Column Length
                ((Collection)Sc["Filter"]).Add(sJoin, null, null, null);
                ((Collection)Sc["CustQuery"]).Add(sCusCode, null, null, null);
                ((Collection)Sc["ComCode"]).Add(sComCode, null, null, null);
                ((Collection)Sc["ColAttr"]).Add(sAttr, null, null, null);
            }

            //供DataSet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["ColumnCaption"]).Add(sColName, null, null, null); //Column Header Title
            }

            FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.NumberCellType ncell = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.CheckBoxCellType ccell = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.DateTimeCellType dcell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            FarPoint.Win.Spread.CellType.ComboBoxCellType ocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType omcell = new FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType pcell = new FarPoint.Win.Spread.CellType.TextCellType();
            pcell.PasswordChar = '*';

            int index = 0;
            ss1.Sheets[0].ColumnHeader.RowCount = iHeaderRow + 1;
            int row = System.Convert.ToInt32(ss1.Sheets[0].ColumnHeader.RowCount - 1);
            try
            {
                FarPoint.Win.Spread.SheetView with_1 = ss1.Sheets[0];

                //设置列头名称
                with_1.ColumnCount++;
                index = with_1.ColumnCount - 1;
               // with_1.Columns.Get(index).Width = 50;

                if (ss_default_width[index] > 0)
                    with_1.Columns.Get(index).Width = ss_default_width[index];
                else
                    with_1.Columns.Get(index).Width = 50;

                with_1.ColumnHeader.Cells.Get(row, index).Value = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Text = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Tag = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.PowderBlue;
              //  with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.Blue;
                with_1.ColumnHeader.Cells.Get(row, index).ForeColor = Color.Black;

                with_1.Columns.Get(index).ForeColor = System.Drawing.Color.Black;
                with_1.Columns.Get(index).Tag = sType.Trim().ToUpper();

                //with_1.Columns[index].Border = new FarPoint.Win.LineBorder(Color.White,1);//20131225
               // with_1.ColumnHeader.DefaultStyle = //FarPoint.Win.Spread.DefaultSkins.Simple3;
               // FarPoint.Win.Spread.DefaultSkins.Simple3

                //设置列类型，列长度，对齐方式及下拉框的选项初始化
                //P-----password
                //E-----edit
                //N-----number
                //ON----combox,not editble
                //OE----combox,editble
                //C-----checkbox
                //D-----date
                //T-----time
                //DT----datetime
                //COMR,ETCR,PGMR,APLR,ETCN
                switch (sType.Trim().ToUpper())
                {
                    case "P":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "20" : sLenth.Trim());
                        tcell.Multiline = false;
                        with_1.Columns.Get(index).CellType = pcell;

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "E":

                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        tcell.Multiline = false;
                        with_1.Columns.Get(index).CellType = tcell;

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "N":
                        int precision;
                        int Scale;
                        if (sLenth.IndexOf(",") != -1)
                        {
                            Scale = (int.Parse(sLenth.Substring(0, sLenth.IndexOf(",")))) - int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                            precision = int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                        }
                        else
                        {
                            Scale = int.Parse(sLenth);
                            precision = 0;
                        }
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ncell;

                        ncell.DecimalPlaces = precision;
                        ncell.MaximumValue = System.Convert.ToDouble((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9')))));
                        ncell.MinimumValue = System.Convert.ToDouble(-((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9'))))));
                        break;

                    case "ON":
                    case "OE":
                        DataTable dt;
                        CdQuery cdq;
                        string ssql;

                        if (sType.Trim().ToUpper() == "ON")
                        {
                            ocell.Editable = false;
                            cdq = new CdQuery(sComCode, sJoin);
                            dt = cdq.CreateDataTable(true);
                            ssql = cdq.sQuery.Replace("ORDER BY CD", "");
                        }
                        else
                        {
                            ocell.Editable = true;
                            dt = new Query(sCusCode + " " + sJoin).CreateDataTable(false);
                            ssql = sCusCode + "@" + sJoin;
                            ocell.AutoCompleteMode = AutoCompleteMode.Suggest;
                            ocell.AutoCompleteSource = AutoCompleteSource.ListItems;
                            ocell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        }
                        ocell.MaxDrop = 30;

                        if (dt != null)
                        {
                            int c = dt.Rows.Count;
                            string[] items = new string[c - 1 + 1];
                            string[] values = new string[c - 1 + 1];
                            if (dt.Columns.Count == 2)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][1].ToString());
                                }
                            }
                            else if (dt.Columns.Count == 1)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][0].ToString());
                                }
                            }


                            ocell.Items = items;
                            ocell.ItemData = values;
                            ocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
                        }

                        with_1.Columns.Get(index).CellType = ocell;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        if (sCombineCol.Trim().Length != 0)
                        {
                            //添加需要联动更新的列索引号
                            ((Collection)Sc["cColumn"]).Add(index, index.ToString());
                            //添加需要联动更新的关联列的索引号
                            ((Collection)Sc["cColumnB"]).Add(sCombineCol, index.ToString());
                            ((Collection)Sc["cName"]).Add(sCombineName, index.ToString());
                            ((Collection)Sc["sql"]).Add(ssql, index.ToString());
                        }
                        break;

                    case "C":

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ccell;
                        break;
                    case "D":
                        dcell.DateSeparator = "-";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate;
                        dcell.EditorValue = FarPoint.Win.Spread.CellType.DateTimeEditorValue.String;

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "T":
                        dcell.TimeSeparator = ":";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.TimeOnly;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "DT":

                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDateWithTime;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;


                    case "COMR":
                    case "COMN":
                    case "ETCR":
                    case "ETCN":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = tcell;

                        tcell.CharacterCasing = CharacterCasing.Upper;

                        //with_1.ColumnHeader.Cells.Get(iHeaderRow, index).ForeColor = Color.PowderBlue;

                        //add collection
                        ((Collection)Sc["fColumn"]).Add(index, index.ToString());
                        ((Collection)Sc["fcode"]).Add(sComCode.Trim().ToUpper() + "@" + sJoin.Trim() + "@" + sCusCode, index.ToString());
                        break;

                }

                // 处理列属性
                string pFlag = "";
                string nFlag = "";
                string mFlag = "";
                string iFlag = "";
                string aFlag = "";
                string lFlag = "";
                if (sAttr.Trim() == "")
                {
                    lFlag = "o"; //other column
                }
                else
                {
                    if (sAttr.ToUpper().IndexOf("P") != -1)
                    {
                        pFlag = "p";
                    }
                    if (sAttr.ToUpper().IndexOf("A") != -1)
                    {
                        aFlag = "a";
                    }
                    if (sAttr.ToUpper().IndexOf("M") != -1)
                    {
                        mFlag = "m";
                    }
                    if (sAttr.ToUpper().IndexOf("N") != -1)
                    {
                        nFlag = "n";
                    }
                    if (sAttr.ToUpper().IndexOf("I") != -1)
                    {
                        iFlag = "i";
                    }
                    if (sAttr.ToUpper().IndexOf("L") != -1)
                    {
                        lFlag = "l";
                    }
                }

                SpreadCommon.Gp_Sp_Collection(ss1, index, pFlag, nFlag, mFlag, iFlag, aFlag, lFlag, (Collection)Sc["pColumn"], (Collection)Sc["nColumn"], (Collection)Sc["mColumn"], (Collection)Sc["iColumn"], (Collection)Sc["aColumn"], (Collection)Sc["lColumn"]);


            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("初始化列：p_SetSc 错误 : " + "列名" + sColName + ";" + ex.Message), "", "");
            }
        }

        
        /// <summary>
        /// Spread合并列头，并设置列名.
        /// sColName：列头名称;
        /// sStartCol：起始列;
        /// sEndCol：结束列;
        /// ScSeq:Spread序列号;
        /// iHeaderRow:开始合并处的单元格行索引;
        /// iSpanRows:合并的行数;
        /// </summary>
        /// <param name="sColName"></param>
        /// <param name="sStartCol"></param>
        /// <param name="sEndCol"></param>
        /// <param name="ScSeq"></param>
        /// <param name="iHeaderRow"></param>
        /// <param name="iSpanRows"></param>
        protected void p_spanSpread(string sColName, int sStartCol, int sEndCol, int ScSeq, int iHeaderRow, int iSpanRows)
        {
            FarPoint.Win.Spread.FpSpread ss;
            ss = (FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[ScSeq])["Spread"];

            int MaxHeadRow;
            if (sStartCol == 0)
            {
                MaxHeadRow = System.Convert.ToInt32(ss.Sheets[0].ColumnHeader.RowCount + 1);
                ss.Sheets[0].ColumnHeader.RowCount = MaxHeadRow;
                ss.Sheets[0].ColumnHeader.Rows[MaxHeadRow - 1].Visible = false;
            }
            else
            {
                MaxHeadRow = ss.Sheets[0].ColumnHeader.RowCount;
            }


            if (iSpanRows == -1)
            {
                if (sStartCol != sEndCol)
                {
                    ss.Sheets[0].AddColumnHeaderSpanCell(iHeaderRow, sStartCol, 1, sEndCol - sStartCol + 1);
                    ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).Text = sColName;
                    ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).ForeColor = Color.Black;
                    //ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).BackColor = Color.PowderBlue;//20131220
                }
                else
                {
                    ss.Sheets[0].AddColumnHeaderSpanCell(0, sStartCol, 2, 1);
                    ss.Sheets[0].ColumnHeader.Cells[iHeaderRow, sStartCol].Text = sColName;
                    ss.Sheets[0].ColumnHeader.Cells[MaxHeadRow - 1, sStartCol].Text = sColName;
                    //20090428修改，颜色样式同最小列头
                    ss.Sheets[0].ColumnHeader.Cells.Get(0, sStartCol).ForeColor = ss.Sheets[0].ColumnHeader.Cells.Get(1, sStartCol).ForeColor;
                    //ss.Sheets[0].ColumnHeader.Cells.Get(0, sStartCol).BackColor = Color.PowderBlue;//20131220

                }
            }
            else
            {
                ss.Sheets[0].AddColumnHeaderSpanCell(iHeaderRow, sStartCol, iSpanRows, sEndCol - sStartCol + 1);
                ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).Text = sColName;
                ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).ForeColor = Color.Black;
                //ss.Sheets[0].ColumnHeader.Cells.Get(iHeaderRow, sStartCol).BackColor = Color.PowderBlue;//20131220
            }

            for (int i = 0; i < ss.ActiveSheet.ColumnCount; i++)
            {
                try
                {
                    string xxx = ss.ActiveSheet.GetColumnHeaderSpanCell(iHeaderRow, i).ToString();
                }
                catch
                {
                    ss.Sheets[0].AddColumnHeaderSpanCell(0, i, 2, 1);
                    ss.Sheets[0].ColumnHeader.Cells[iHeaderRow, i].Text = ss.Sheets[0].ColumnHeader.Cells.Get(1, i).Text;
                    ss.Sheets[0].ColumnHeader.Cells.Get(0, i).ForeColor = ss.Sheets[0].ColumnHeader.Cells.Get(1, i).ForeColor;
                    //ss.Sheets[0].ColumnHeader.Cells.Get(0, i).BackColor = Color.PowderBlue;//20131220
                   
                }

            }

        }


        /// <summary>
        ///根据mc查询sc，假如mc有返回值，那么还对mc进行查询
        ///iMcSeq：Mc集合序列号 
        ///iScSeq：Sc集合顺序序列号
        ///menu：查询完成后，是否设置画面的权限
        ///MsgChk：无数据时，是否提示“无数据”。
        /// </summary>
        /// <param name="iMcSeq"></param>
        /// <param name="iScSeq"></param>
        /// <param name="menu"></param>
        /// <param name="msgchk"></param>
        /// <returns></returns>
        protected bool p_Ref(int iMcSeq, int iScSeq, bool menu, bool msgchk)
        {
            bool rltValue = false;
            isRefer = true;
            if (iMcSeq == 0 && iScSeq == 0)
            {
                return false;
            }

            //判断是否为单个mc或者sc
            if (iMcSeq == 0)
            {
                if (SpreadCommon.Gf_Sp_ProceExist((FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[iScSeq])["Spread"], true))
                {
                    return false;
                }
                ///Spread查询
                if (SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], null, null, null, msgchk))
                {
                    rltValue = true;
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "RE", sAuthority);
                    }
                }
            }
            else if (iScSeq == 0)
            {
                if (MasterCommon.Gf_Ms_Refer(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], (Collection)((Collection)Proc_Mc[iMcSeq])["npControl"], (Collection)((Collection)Proc_Mc[iMcSeq])["mControl"], msgchk))
                {
                    rltValue = true;
                    //20090429
                    MasterCommon.Gp_Ms_ControlLock((Collection)((Collection)Proc_Mc[iMcSeq])["pControl"], true);
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "RE", sAuthority);
                    }
                }
            }
            else
            {
                if (SpreadCommon.Gf_Sp_ProceExist((FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[iScSeq])["Spread"], true))
                {
                    return false;
                }

                //'根据mc查询sc
                //'判断mc是否有返回值，如果有需要对mc进行查询
                if ((bool)((Collection)Proc_Mc[iMcSeq])["pro"] == true)
                {
                    if (MasterCommon.Gf_Ms_Refer(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], (Collection)((Collection)Proc_Mc[iMcSeq])["npControl"], (Collection)((Collection)Proc_Mc[iMcSeq])["mControl"], msgchk))
                    {
                        rltValue = SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], (Collection)((Collection)Proc_Mc[iMcSeq])["npControl"], (Collection)((Collection)Proc_Mc[iMcSeq])["mControl"], msgchk);
                        MasterCommon.Gp_Ms_ControlLock((Collection)((Collection)Proc_Mc[iMcSeq])["pControl"], true);
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "RE", sAuthority);
                        }
                    }
                }
                else
                {
                    if (SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], (Collection)((Collection)Proc_Mc[iMcSeq])["npControl"], (Collection)((Collection)Proc_Mc[iMcSeq])["mControl"], msgchk))
                    {
                        rltValue = true;
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "RE", sAuthority);
                        }
                    }
                }
            }

            if (GeneralCommon.M_CN1.State != 0)
            {
                GeneralCommon.M_CN1.Close();
            }
            isRefer = false;
            return rltValue;
        }

        /// <summary>
        ///根据mc保存sc,并判断mc是否有返回值,如果有需要对mc进行保存。
        ///iMcSeq:Mc集合序列号
        ///iScSeq:Sc集合序列号
        ///menu:保存完成后，是否进行权限设置
        ///RefChek：数据保存后是否刷新，true：不刷新。false：刷新。
        /// </summary>
        /// <param name="iMcSeq"></param>
        /// <param name="iScSeq"></param>
        /// <param name="menu"></param>
        /// <param name="refchk"></param>
        /// <returns></returns>
        protected bool p_pro(int iMcSeq, int iScSeq, bool menu, bool refchk)
        {
            bool returnValue = false;
            isRefer = true;
            if (iMcSeq == 0 && iScSeq == 0)
            {
                return returnValue;
            }

            //判断是否为单个mc或者sc
            if (iMcSeq == 0)
            {
                if (SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], null, refchk))
                {
                    returnValue = true;
                    if (menu)
                    {
                        //GeneralCommon.Gp_FormMenuSetting(this, FormType, "SE", sAuthority);
                        GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                    }
                }

                return returnValue;
            }
            else if (iScSeq == 0)
            {
                if (GeneralCommon.Gf_Mc_Authority(sAuthority, (Collection)Proc_Mc[iMcSeq], null))
                {
                    if (MasterCommon.Gf_Ms_Process(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], sAuthority))
                    {
                        returnValue = true;
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                        }
                    }
                }
                return returnValue;
            }

            // 判断mc是否有返回值,如果有需要对mc进行保存
            if ((bool)((Collection)Proc_Mc[iMcSeq])["pro"] == true)
            {
                if (GeneralCommon.Gf_Mc_Authority(sAuthority, (Collection)Proc_Mc[iMcSeq], (Collection)Proc_Sc[iScSeq]))
                {
                    if (MasterCommon.Gf_Ms_Process(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], sAuthority))
                    {
                        returnValue = true;
                        SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], refchk);
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                        }
                    }
                }
            }
            else
            {
                if (SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], refchk))
                {
                    returnValue = true;
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                    }
                }
            }

            if (GeneralCommon.M_CN1.State != 0)
            {
                GeneralCommon.M_CN1.Close();
            }
            isRefer = false;
            return returnValue;
        }


        /// <summary>
        ///根据mc保存sc,并判断mc是否有返回值,如果有需要对mc进行保存。
        ///iMcSeq:Mc集合序列号
        ///iScSeq:Sc集合序列号
        ///menu:保存完成后，是否进行权限设置
        ///RefChek：数据保存后是否刷新，true：不刷新。false：刷新。
        /// </summary>
        /// <param name="iMcSeq"></param>
        /// <param name="iScSeq"></param>
        /// <param name="menu"></param>
        /// <param name="refchk"></param>
        /// <returns></returns>
        protected bool p_Pro(int iMcSeq, int iScSeq, bool menu, bool refchk)
        {
            bool returnValue;
            returnValue = false;
            isRefer = true;
            if (iMcSeq == 0 && iScSeq == 0)
            {
                return returnValue;
            }
            //判断是否为单个mc或者sc
            if (iMcSeq == 0)
            {
                if (SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], null, refchk))
                {
                    returnValue = true;
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                    }
                }

                return returnValue;
            }
            else if (iScSeq == 0)
            {
                if (GeneralCommon.Gf_Mc_Authority(sAuthority, (Collection)Proc_Mc[iMcSeq], null))
                {
                    if (MasterCommon.Gf_Ms_Process(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], sAuthority))
                    {
                        returnValue = true;
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                        }
                    }
                }
                return returnValue;
            }

            // 判断mc是否有返回值,如果有需要对mc进行保存
            if ((bool)((Collection)Proc_Mc[iMcSeq])["pro"] == true)
            {
                if (GeneralCommon.Gf_Mc_Authority(sAuthority, (Collection)Proc_Mc[iMcSeq], (Collection)Proc_Sc[iScSeq]))
                {
                    if (MasterCommon.Gf_Ms_Process(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq], sAuthority))
                    {
                        returnValue = true;
                        SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], refchk);
                        if (menu)
                        {
                            GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                        }
                    }
                }
            }
            else
            {
                if (SpreadCommon.Gf_Sp_Process(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq], refchk))
                {
                    returnValue = true;
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "SE", sAuthority);
                    }
                }
            }

            if (GeneralCommon.M_CN1.State != 0)
            {
                GeneralCommon.M_CN1.Close();
            }
            isRefer = false;
            return returnValue;
        }


        /// <summary>
        /// 对mc，sc进行删除删除
        /// iMcSeq:Mc 序号
        /// iScSeq：Sc序号
        /// menu：删除完成后，重新设置当前页面的权限。
        /// </summary>
        /// <param name="iMcSeq"></param>
        /// <param name="iScSeq"></param>
        /// <param name="menu"></param>
        protected void p_del(int iMcSeq, int iScSeq, bool menu)
        {

            if (iMcSeq == 0 && iScSeq == 0)
            {
                return;
            }

            // 判断单个sc
            if (iMcSeq == 0)
            {
                return;
            }
            //判断是否是Mc
            else if (iScSeq == 0)
            {
                // 如果mc没有返回值，即如若mc只是单纯的查询条件，退出
                if ((bool)((Collection)Proc_Mc[iMcSeq])["pro"] == false)
                {
                    return;
                }

                if (MasterCommon.Gf_Ms_Del(GeneralCommon.M_CN1, (Collection)Proc_Mc[iMcSeq]))
                {
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "FS", sAuthority);
                    }
                }
                return;
            }

            // 判断mc是否有返回值,即如果mc只是单纯的查询条件，退出
            if ((bool)((Collection)Proc_Mc[iMcSeq])["pro"] == true)
            {
                if (MasterCommon.Gf_Ms_AllDel(GeneralCommon.M_CN1, (Collection)Proc_Sc[iScSeq], (Collection)Proc_Mc[iMcSeq]))
                {
                    if (menu)
                    {
                        GeneralCommon.Gp_FormMenuSetting(FormType, "FS", sAuthority);
                    }
                }
            }
            else
            {
                return;
            }

            if (GeneralCommon.M_CN1.State != 0)
            {
                GeneralCommon.M_CN1.Close();
            }

        }

       
        /// <summary>
        /// 未用
        /// </summary>
        /// <param name="ospread"></param>
        /// <param name="sMaxid"></param>
        /// <param name="sMinId"></param>
        /// <returns></returns>
        public static bool Gf_Sp_CheckMaxMin(FarPoint.Win.Spread.FpSpread ospread, string sMaxid, string sMinId)
        {
            return true;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sKey"></param>
       /// <param name="oSpread"></param>
       /// <param name="sColId"></param>
        public static void Gf_Sp_ColColorSet(string sKey, FarPoint.Win.Spread.FpSpread oSpread, string sColId)
        {

        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="oSpread"></param>
       /// <returns></returns>
        public static bool Gf_Sp_Openexcel(FarPoint.Win.Spread.FpSpread oSpread)
        {
            return false;
        }
        #endregion

        #region Spread Cloumn Sort/ColsFrozenSetting/ColsFrozenCancel

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mnu_ColumnSort_Click(object sender, System.EventArgs e)
        {
            Spread_ColSort Spread_ColSort = new Spread_ColSort();
            try
            {
                Spread_ColSort.Active_Spread = (FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[i_ScCurrSeq])["Spread"];
                Spread_ColSort.ShowDialog();
                Spread_ColSort.Dispose();
                GeneralCommon.GStatusBar.Panels[0].Text = " Message : ";
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)(" ColumnSort Error : " + ex.Message), "", "");
            }
        }

        /// <summary>
        ///  设置Spread列锁定以及锁定的位置。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mnu_FrozenSetting_Click(object sender, System.EventArgs e)
        {

            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[i_ScCurrSeq])["Spread"];
            ss.Sheets[0].FrozenColumnCount = ss.ActiveSheet.ActiveColumnIndex + 1;

        }

        /// <summary>
        /// 解除列锁定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mnu_FrozenCancel_Click(object sender, System.EventArgs e)
        {

            FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)((Collection)Proc_Sc[i_ScCurrSeq])["Spread"];
            ss.Sheets[0].FrozenColumnCount = 0;
        }

        #endregion

        #region new
        //wangyong 071223
        /// <summary>
        /// 定义快捷键处理查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctrl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            return;
          //  if (e.KeyChar == Strings.ChrW((int)Keys.Control)) return;//1227
            if (e.KeyChar == Strings.ChrW((int)Keys.Enter))
            {
                Form_Ref();
            }
        }

        protected void p_SetSc(string sColName, string sType, string sLenth, string sAttr, string sComCode, string sJoin, string sCusCode, int ScSeq, int iHeaderRow)
        {
            Collection Sc;
            FarPoint.Win.Spread.FpSpread ss1;
            Sc = (Collection)Proc_Sc[ScSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            sColName = sColName.Trim();
            // 供PopupSheet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["CHTitle"]).Add(sColName); //Column Header Title
                ((Collection)Sc["ColType"]).Add(sType); //Column Type
                ((Collection)Sc["ColLength"]).Add(sLenth); //Column Length
                ((Collection)Sc["Filter"]).Add(sJoin);
                ((Collection)Sc["CustQuery"]).Add(sCusCode);
                ((Collection)Sc["ComCode"]).Add(sComCode);
                ((Collection)Sc["ColAttr"]).Add(sAttr);
            }

            // 供DataSet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["ColumnCaption"]).Add(sColName); //Column Header Title
            }

            FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.NumberCellType ncell = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.CheckBoxCellType ccell = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.DateTimeCellType dcell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            FarPoint.Win.Spread.CellType.ComboBoxCellType ocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType omcell = new FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType pcell = new FarPoint.Win.Spread.CellType.TextCellType();
            pcell.PasswordChar = '*';

            int index = 0;
            ss1.Sheets[0].ColumnHeader.RowCount = iHeaderRow + 1;
            int row = System.Convert.ToInt32(ss1.Sheets[0].ColumnHeader.RowCount - 1);
            try
            {
                FarPoint.Win.Spread.SheetView with_1 = ss1.ActiveSheet;
                with_1.ColumnCount++;
                index = with_1.ColumnCount - 1;
               // with_1.Columns.Get(index).Width = 50;
                if (ss_default_width[index] > 0)
                    with_1.Columns.Get(index).Width = ss_default_width[index];
                else
                    with_1.Columns.Get(index).Width = 50;

                with_1.ColumnHeader.Cells.Get(row, index).Value = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Text = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Tag = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.PowderBlue;
               // with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.Blue;
                with_1.ColumnHeader.Cells.Get(row, index).ForeColor = Color.Black;

                with_1.Columns.Get(index).ForeColor = System.Drawing.Color.Black;
                with_1.Columns.Get(index).Tag = sType.Trim().ToUpper();

             //   with_1.Columns[index].Border = new FarPoint.Win.LineBorder(Color.PowderBlue,1);//20131225

                // 设置列类型，列长度，对齐方式及下拉框的选项初始化
                //P-----password
                //E-----edit
                //N-----number
                //ON----combox,not editble
                //OE----combox,editble
                //C-----checkbox
                //D-----date
                //T-----time
                //DT----datetime
                //COMR,ETCR,PGMR,APLR,ETCN
                switch (sType.Trim().ToUpper())
                {
                    case "P":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "20" : sLenth.Trim());
                        tcell.Multiline = false;
                        with_1.Columns.Get(index).CellType = pcell;

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "E":

                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());                    
                        tcell.Multiline = false;
                        with_1.Columns.Get(index).CellType = tcell;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "N":
                        int precision;
                        int Scale;
                        if (sLenth.IndexOf(",") != -1)
                        {
                            Scale = (int.Parse(sLenth.Substring(0, sLenth.IndexOf(",")))) - int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                            precision = int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                        }
                        else
                        {
                            Scale = int.Parse(sLenth);
                            precision = 0;
                        }
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ncell;

                        ncell.DecimalPlaces = precision;
                        ncell.MaximumValue = System.Convert.ToDouble((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9')))));
                        ncell.MinimumValue = System.Convert.ToDouble(-((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9'))))));

                        ncell.Separator = ",";
                        ncell.ShowSeparator = true;
                        break;

                    case "ON":
                    case "OE":
                        DataTable dt;
                        CdQuery cdq;
                        string ssql;

                        if (sType.Trim().ToUpper() == "ON")
                        {
                            ocell.Editable = false;
                            cdq = new CdQuery(sComCode, sJoin);
                            dt = cdq.CreateDataTable(true);
                            ssql = cdq.sQuery.Replace("ORDER BY CD", "");
                        }
                        else
                        {
                            ocell.Editable = true;                        
                            dt = new Query(sCusCode + " " + sJoin).CreateDataTable(true);
                            ssql = sCusCode + "@" + sJoin;
                            ocell.AutoCompleteMode = AutoCompleteMode.Suggest;
                            ocell.AutoCompleteSource = AutoCompleteSource.ListItems;
                            ocell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        }
                        ocell.MaxDrop = 30;

                        if (dt != null)
                        {
                            int c = dt.Rows.Count;
                            string[] items = new string[c - 1 + 1];
                            string[] values = new string[c - 1 + 1];
                            if (dt.Columns.Count == 2)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][1].ToString());
                                }
                            }
                            else if (dt.Columns.Count == 1)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][0].ToString());
                                }
                            }
                            ocell.Items = items;
                            ocell.ItemData = values;
                            ocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
                        }

                        with_1.Columns.Get(index).CellType = ocell;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "C":

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ccell;
                        break;
                    case "D":
                        dcell.DateSeparator = "-";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate;
                        dcell.EditorValue = FarPoint.Win.Spread.CellType.DateTimeEditorValue.String;

                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "T":
                        dcell.TimeSeparator = ":";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.TimeOnly;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "DT":

                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDateWithTime;
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;

                    case "COMR":
                    case "COMN":
                    case "ETCR":
                    case "ETCN":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = tcell;

                        //with_1.ColumnHeader.Cells.Get(iHeaderRow, index).ForeColor = Color.PowderBlue;

                        //add collection
                        ((Collection)Sc["fColumn"]).Add(index, index.ToString());
                        ((Collection)Sc["fcode"]).Add(sComCode.Trim().ToUpper() + "@" + sJoin.Trim() + "@" + sCusCode, index.ToString());
                        break;

                }

                // 处理列属性
                string pFlag = "";
                string nFlag = "";
                string mFlag = "";
                string iFlag = "";
                string aFlag = "";
                string lFlag = "";
                if (sAttr.Trim() == "")
                {
                    lFlag = "o"; //other column
                }
                else
                {
                    if (sAttr.ToUpper().IndexOf("P") != -1)
                    {
                        pFlag = "p";
                    }
                    if (sAttr.ToUpper().IndexOf("A") != -1)
                    {
                        aFlag = "a";
                    }
                    if (sAttr.ToUpper().IndexOf("M") != -1)
                    {
                        mFlag = "m";
                    }
                    if (sAttr.ToUpper().IndexOf("N") != -1)
                    {
                        nFlag = "n";
                    }
                    if (sAttr.ToUpper().IndexOf("I") != -1)
                    {
                        iFlag = "i";
                    }
                    if (sAttr.ToUpper().IndexOf("L") != -1)
                    {
                        lFlag = "l";
                    }
                }

                SpreadCommon.Gp_Sp_Collection(ss1, index, pFlag, nFlag, mFlag, iFlag, aFlag, lFlag, (Collection)Sc["pColumn"], (Collection)Sc["nColumn"], (Collection)Sc["mColumn"], (Collection)Sc["iColumn"], (Collection)Sc["aColumn"], (Collection)Sc["lColumn"]);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("初始化列：p_SetSc 错误 : " + "列名" + sColName + ";" + ex.Message), "", "");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sColName"></param>
        /// <param name="sType"></param>
        /// <param name="sLenth"></param>
        /// <param name="sAttr"></param>
        /// <param name="sComCode"></param>
        /// <param name="sJoin"></param>
        /// <param name="sCusCode"></param>
        /// <param name="ScSeq"></param>
        /// <param name="iHeaderRow"></param>
        /// <param name="HAlign"></param>
        protected void p_SetSc(string sColName, string sType, string sLenth, string sAttr, string sComCode,
            string sJoin, string sCusCode, int ScSeq, int iHeaderRow, string HAlign)
        {
            Collection Sc;
            FarPoint.Win.Spread.FpSpread ss1;
            Sc = (Collection)Proc_Sc[ScSeq];
            ss1 = (FarPoint.Win.Spread.FpSpread)Sc["Spread"];
            sColName = sColName.Trim();

            // 供PopupSheet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["CHTitle"]).Add(sColName); //Column Header Title
                ((Collection)Sc["ColType"]).Add(sType); //Column Type
                ((Collection)Sc["ColLength"]).Add(sLenth); //Column Length
                ((Collection)Sc["Filter"]).Add(sJoin);
                ((Collection)Sc["CustQuery"]).Add(sCusCode);
                ((Collection)Sc["ComCode"]).Add(sComCode);
                ((Collection)Sc["ColAttr"]).Add(sAttr);
            }

            // 供DataSet用 JIA
            if (iHeaderRow == 0)
            {
                ((Collection)Sc["ColumnCaption"]).Add(sColName); //Column Header Title
            }

            FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.NumberCellType ncell = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.CheckBoxCellType ccell = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            FarPoint.Win.Spread.CellType.DateTimeCellType dcell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            FarPoint.Win.Spread.CellType.ComboBoxCellType ocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType omcell = new FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType();
            FarPoint.Win.Spread.CellType.TextCellType pcell = new FarPoint.Win.Spread.CellType.TextCellType();
            pcell.PasswordChar = '*';

            int index = 0;
            ss1.Sheets[0].ColumnHeader.RowCount = iHeaderRow + 1;
            int row = System.Convert.ToInt32(ss1.Sheets[0].ColumnHeader.RowCount - 1);
            try
            {
                FarPoint.Win.Spread.SheetView with_1 = ss1.ActiveSheet;
                with_1.ColumnCount++;
                index = with_1.ColumnCount - 1;
              //  with_1.Columns.Get(index).Width = 50;

                if (ss_default_width[index] > 0)
                    with_1.Columns.Get(index).Width = ss_default_width[index];
                else
                    with_1.Columns.Get(index).Width = 50;

                with_1.ColumnHeader.Cells.Get(row, index).Value = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Text = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).Tag = sColName.Trim();
                with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.PowderBlue;
               // with_1.ColumnHeader.Cells.Get(row, index).BackColor = Color.Blue;
                with_1.ColumnHeader.Cells.Get(row, index).ForeColor = Color.Black;

                with_1.Columns.Get(index).ForeColor = System.Drawing.Color.Black;
                with_1.Columns.Get(index).Tag = sType.Trim().ToUpper();

            //    with_1.Columns[index].Border = new FarPoint.Win.LineBorder(Color.White,1);//20131225

                // 设置列类型，列长度，对齐方式及下拉框的选项初始化
                //P-----password
                //E-----edit
                //N-----number
                //ON----combox,not editble
                //OE----combox,editble
                //C-----checkbox
                //D-----date
                //T-----time
                //DT----datetime
                //COMR,ETCR,PGMR,APLR,ETCN
                switch (sType.Trim().ToUpper())
                {
                    case "P":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "20" : sLenth.Trim());
                        tcell.Multiline = false;
                        with_1.Columns.Get(index).CellType = pcell;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "E":

                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        tcell.Multiline = false;                     
                        with_1.Columns.Get(index).CellType = tcell;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "N":
                        int precision;
                        int Scale;
                        if (sLenth.IndexOf(",") != -1)
                        {
                            Scale = (int.Parse(sLenth.Substring(0, sLenth.IndexOf(",")))) - int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                            precision = int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                        }
                        else
                        {
                            Scale = int.Parse(sLenth);
                            precision = 0;
                        }

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ncell;

                        ncell.DecimalPlaces = precision;
                        ncell.MaximumValue = System.Convert.ToDouble((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9')))));
                        ncell.MinimumValue = System.Convert.ToDouble(-((long.Parse((string)("9".PadLeft(Scale, '9'))) > 9999999999) ? 9999999999 : (long.Parse((string)("9".PadLeft(Scale, '9'))))));
                        ncell.Separator = ",";
                        ncell.ShowSeparator = true;
                        break;

                    case "ON":
                    case "OE":
                        DataTable dt;
                        CdQuery cdq;
                        string ssql;

                        if (sType.Trim().ToUpper() == "ON")
                        {
                            ocell.Editable = false;
                            cdq = new CdQuery(sComCode, sJoin);
                            dt = cdq.CreateDataTable(true);
                            ssql = cdq.sQuery.Replace("ORDER BY CD", "");
                        }
                        else
                        {
                            ocell.Editable = true;
                            dt = new Query(sCusCode + " " + sJoin).CreateDataTable(true);
                            ssql = sCusCode + "@" + sJoin;
                            ocell.AutoCompleteMode = AutoCompleteMode.Suggest;
                            ocell.AutoCompleteSource = AutoCompleteSource.ListItems;
                            ocell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());
                        }
                        ocell.MaxDrop = 30;

                        if (dt != null)
                        {
                            int c = dt.Rows.Count;
                            string[] items = new string[c - 1 + 1];
                            string[] values = new string[c - 1 + 1];
                            if (dt.Columns.Count == 2)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][1].ToString());
                                }
                            }
                            else if (dt.Columns.Count == 1)
                            {
                                for (int i = 0; i <= c - 1; i++)
                                {
                                    items[i] = (string)(dt.Rows[i][0].ToString());
                                    values[i] = (string)(dt.Rows[i][0].ToString());
                                }
                            }
                            ocell.Items = items;
                            ocell.ItemData = values;
                            ocell.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
                        }
                        with_1.Columns.Get(index).CellType = ocell;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        break;

                    case "C":

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = ccell;
                        break;
                    case "D":
                        dcell.DateSeparator = "-";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate;
                        dcell.EditorValue = FarPoint.Win.Spread.CellType.DateTimeEditorValue.String;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "T":
                        dcell.TimeSeparator = ":";
                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.TimeOnly;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;
                    case "DT":

                        dcell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDateWithTime;

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = dcell;
                        break;


                    case "COMR":
                    case "COMN":
                    case "ETCR":
                    case "ETCN":
                        tcell.MaxLength = System.Convert.ToInt32(sLenth.Trim() == "" ? "200" : sLenth.Trim());

                        if (HAlign.ToUpper() == "R")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                        else if (HAlign.ToUpper() == "M")
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                        else
                            with_1.Columns.Get(index).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;


                        with_1.Columns.Get(index).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                        with_1.Columns.Get(index).CellType = tcell;

                        //with_1.ColumnHeader.Cells.Get(iHeaderRow, index).ForeColor = Color.PowderBlue;

                        //add collection
                        ((Collection)Sc["fColumn"]).Add(index, index.ToString());
                        ((Collection)Sc["fcode"]).Add(sComCode.Trim().ToUpper() + "@" + sJoin.Trim() + "@" + sCusCode, index.ToString());
                        break;

                }

                // 处理列属性
                string pFlag = "";
                string nFlag = "";
                string mFlag = "";
                string iFlag = "";
                string aFlag = "";
                string lFlag = "";
                if (sAttr.Trim() == "")
                {
                    lFlag = "o"; //other column
                }
                else
                {
                    if (sAttr.ToUpper().IndexOf("P") != -1)
                    {
                        pFlag = "p";
                    }
                    if (sAttr.ToUpper().IndexOf("A") != -1)
                    {
                        aFlag = "a";
                    }
                    if (sAttr.ToUpper().IndexOf("M") != -1)
                    {
                        mFlag = "m";
                    }
                    if (sAttr.ToUpper().IndexOf("N") != -1)
                    {
                        nFlag = "n";
                    }
                    if (sAttr.ToUpper().IndexOf("I") != -1)
                    {
                        iFlag = "i";
                    }
                    if (sAttr.ToUpper().IndexOf("L") != -1)
                    {
                        lFlag = "l";
                    }
                }

                SpreadCommon.Gp_Sp_Collection(ss1, index, pFlag, nFlag, mFlag, iFlag, aFlag, lFlag, (Collection)Sc["pColumn"], (Collection)Sc["nColumn"], (Collection)Sc["mColumn"], (Collection)Sc["iColumn"], (Collection)Sc["aColumn"], (Collection)Sc["lColumn"]);


            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("初始化列：p_SetSc 错误 : " + "列名" + sColName + ";" + ex.Message), "", "");
            }
        }

        protected void p_SetMc(string sname, Control Ctrl, string sAttr, string sComboComText, string sComboxJoin, string sComboCusText, int McSeq, string sLenth)
        {
            Ctrl.Tag = sname.Trim();
            p_SetMc(Ctrl, sAttr, sComboComText, sComboxJoin, sComboCusText, McSeq, sLenth);
        }

        /// ///////////////////////20130228
        protected void p_SetMc(string sname, TextBox Ctrl, string sAttr, string sLenth, string sComboComText, string sComboxJoin, string sComboCusText, int McSeq, bool iMcRecord)
        {
            p_SetMc(sname, Ctrl, sAttr, sLenth, sComboComText, sComboxJoin, sComboCusText, McSeq);
           // MasterCommon.iMcRecord = iMcRecord;
            MasterCommon.iMcRecord = false;//20130320
        }
        /////////////////////////////20130228

        protected void p_SetMc(Control Ctrl, string sAttr, string sComboComText, string sComboxJoin, string sComboCusText, int McSeq, string sLenth)
        {

            string pFlag = "";
            string rFlag = "";
            string nFlag = "";
            string mFlag = "";
            string iFlag = "";
            string aFlag = "";
            string lFlag = "";


            tabindex_count++;
            Ctrl.TabIndex = tabindex_count;
            Ctrl.Tag = Ctrl.Name;//0815

            try
            {
                if (Ctrl is FarPoint.Win.Spread.FpSpread)
                {
                }
                else if (Ctrl is CeriUDate)
                {
                    ((CeriUDate)Ctrl).maskedTextBox1.MouseDoubleClick += new MouseEventHandler(CeriUDateDbClick);  
                }
                else if (Ctrl is MaskedDate)
                {
                    MaskedDate dtpTemp = (MaskedDate)Ctrl;
                    dtpTemp.MouseDoubleClick += new MouseEventHandler(maskedDateMouseDoubleClick);
                    switch (sLenth)
                    {
                        //日期+时间
                        case "19":
                            dtpTemp.Mask = "0000-00-00 90:00:00";
                            break;
                        //日期+小时+分钟
                        case "16":
                            dtpTemp.Mask = "0000-00-00 90:00";
                            break;
                        //日期
                        case "10":
                            dtpTemp.Mask = "0000-00-00";
                            break;
                        //时间
                        case "8":
                            dtpTemp.Mask = "90:00";
                            break;
                        case "7"://0116
                            dtpTemp.Mask = "0000-00";
                            break;
                        case "4":
                            dtpTemp.Mask = "0000";
                            break;//0116
                        default:
                            dtpTemp.Mask = "0000-00-00 90:00:00";
                            break;

                    }
                }           

                else if (Ctrl is TextBox)
                {
                    TextBox txtTemp = (TextBox)Ctrl;
                }
                else if (Ctrl is ComboBox)
                {
                    ComboBox cboTemp = (ComboBox)Ctrl;

                    if (sComboComText.Trim().Length != 0 && sComboCusText.Trim().Length != 0)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("P_SETMC错误 控件<" + ctrl.Tag + ">不能同时取公共代码和自定义语句", "W", "");
                        return;
                    }
                    else if (sComboComText.Trim().Length != 0)
                    {
                        cboTemp.DropDownStyle = ComboBoxStyle.DropDownList;
                        cboTemp.RightToLeft = RightToLeft.No;
                        Query qu = new CdQuery(sComboComText, sComboxJoin);
                        DataTable dt = qu.CreateDataTable(true);
                        cboTemp.DataSource = dt;
                        cboTemp.DisplayMember = dt.Columns[0].ToString();
                        cboTemp.ValueMember = dt.Columns[1].ToString();
                        cboTemp.SelectedIndex = 0;

                    }
                    else if (sComboCusText.Trim().Length != 0)
                    {
                        cboTemp.DropDownStyle = ComboBoxStyle.DropDown;
                        cboTemp.RightToLeft = RightToLeft.No;

                        DataTable dt = new Query(sComboCusText.Trim() + " " + sComboxJoin.Trim()).CreateDataTable(true);
                        cboTemp.DataSource = dt;
                        if (dt.Columns.Count > 1)
                        {
                            cboTemp.DisplayMember = dt.Columns[0].ToString();
                            cboTemp.ValueMember = dt.Columns[1].ToString();
                        }
                        else
                        {
                            cboTemp.DisplayMember = dt.Columns[0].ToString();
                            cboTemp.ValueMember = dt.Columns[0].ToString();
                        }
                        cboTemp.SelectedValue = "";
                        cboTemp.AutoCompleteMode = AutoCompleteMode.Suggest;
                        cboTemp.AutoCompleteSource = AutoCompleteSource.ListItems;
                    }

                }
                else if (Ctrl is DateTimePicker) //设置日期时间空间
                {
                    DateTimePicker dtpTemp = (DateTimePicker)Ctrl;
                    switch (sLenth)
                    {
                        //日期+时间   
                        case "19":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                            break;
                        //光有日期
                        case "10":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "yyyy-MM-dd";
                            break;
                        //光有时间
                        case "8":
                            dtpTemp.Format = DateTimePickerFormat.Custom;
                            dtpTemp.CustomFormat = "HH:mm:ss";
                            break;
                    }

                }
                else if (Ctrl is NumericUpDown)
                {
                    if (sLenth == "")
                    {
                    }
                    else
                    {
                        NumericUpDown nudTemp = (NumericUpDown)Ctrl;
                        int precision;
                        int Scale;
                        if (sLenth.IndexOf(",") != -1)
                        {
                            Scale = (int.Parse(sLenth.Substring(0, sLenth.IndexOf(",")))) - int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                            precision = int.Parse(sLenth.Substring(sLenth.IndexOf(",") + 2 - 1));
                        }
                        else
                        {
                            Scale = int.Parse(sLenth);
                            precision = 0;
                        }
                        nudTemp.DecimalPlaces = precision;
                        nudTemp.Maximum = long.Parse((string)("9".PadLeft(Scale, '9')));
                        nudTemp.Minimum = System.Convert.ToDecimal(-long.Parse((string)("9".PadLeft(Scale, '9'))));
                    }
                }

                // 默认为r
                if (sAttr.Trim() == "")
                {
                    rFlag = "r";
                }
                else
                {
                    if (sAttr.ToUpper().IndexOf("P") != -1)
                    {
                        pFlag = "p";
                    }
                    if (sAttr.ToUpper().IndexOf("A") != -1)
                    {
                        aFlag = "a";
                    }
                    if (sAttr.ToUpper().IndexOf("M") != -1)
                    {
                        mFlag = "m";
                    }
                    if (sAttr.ToUpper().IndexOf("N") != -1)
                    {
                        nFlag = "n";
                    }
                    if (sAttr.ToUpper().IndexOf("I") != -1)
                    {
                        iFlag = "i";
                    }
                    if (sAttr.ToUpper().IndexOf("L") != -1)
                    {
                        lFlag = "l";
                    }
                    if (sAttr.ToUpper().IndexOf("R") != -1 && !(Ctrl is MixComboBox))
                    {
                        rFlag = "r";
                    }
                }

                // 处理该控件的集插入
                MasterCommon.Gp_Ms_Collection(Ctrl, pFlag, nFlag, mFlag, iFlag, rFlag, aFlag, lFlag,
                    (Collection)((Collection)Proc_Mc[McSeq])["pControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["nControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["mControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["iControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["rControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["aControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["lControl"],
                    (Collection)((Collection)Proc_Mc[McSeq])["npControl"]);

            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay((string)("p_SetMc Error : " + Ctrl.Name + ex.Message), "", "");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sColName"></param>
        /// <param name="sType"></param>
        /// <param name="sLenth"></param>
        /// <param name="sAttr"></param>
        /// <param name="sComCode"></param>
        /// <param name="sJoin"></param>
        /// <param name="sCusCode"></param>
        /// <param name="ScSeq"></param>
        /// <param name="iHeaderRow"></param>
        /// <param name="HAlign"></param>
        /// <param name="iRecord"></param>
        protected void p_SetSc(string sColName, string sType, string sLenth, string sAttr, string sComCode,
           string sJoin, string sCusCode, int ScSeq, int iHeaderRow, string HAlign, bool iRecord)
        {
            p_SetSc(sColName, sType, sLenth, sAttr, sComCode, sJoin, sCusCode, ScSeq, iHeaderRow, HAlign);
            // .iRecord = iRecord;
            SpreadCommon.iRecord = false;//20130320
            //SpreadCommon.iRecord = iRecord;

        }

        #endregion

        private void FORMBASE_Deactivate(object sender, EventArgs e)
        {
            //Pre_Toolbar_St = Toolbar_St;
            //Pre_FormName = this.Name;
            //Pre_sAuthority = sAuthority;
            //Pre_FormType = FormType;
        }
    }

}