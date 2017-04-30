using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CommonClass
{
    public partial class F4COMN : TextBox
    {
        public F4COMN()
        {
            InitializeComponent();
        }

        private string sKeyName = "CD_MANA_NO";      
        private string sKeyValue = "";        //存储sKey属性 
        private string sJoin = "";        // 存储sjoin属性 
        private string sCusSql="";// 增加类似sc的自定义Sql语句
        private string sPrcoCode="";//增加调用存储过程名
        private string sWitch="MS";

        private string sOrderBy = "";
        private string sBackTableName = "TZ_CD";
        private ArrayList sContrl = new ArrayList();
        private ArrayList sColName = new ArrayList();
        private ArrayList sBackName = new ArrayList();
        private ArrayList siCol = new ArrayList();
        private ArrayList sCtlAttr = new ArrayList();

        private bool BeforeKeyPress = false;
        private bool AfterKeyPress = false;
        #region sKeyName
        public virtual string KeyName
        {
            get { return sKeyName; }
            set { sKeyName = value; }
        }
        #endregion

        #region sKeyValue
        public virtual string Get_Key()
        {
            return sKeyValue;
        }
        public virtual string Key
        {
            //属性sKey,用来确定该文本框内容在数据库中的代码 
            get { return sKeyValue; }
            set { sKeyValue = value; }
        }

        #endregion

        #region sJoin
        public virtual string Get_Join()
        {
            return sJoin;
        }

        public virtual string Join
        {
            get { return sJoin; }
            set { sJoin = value; }
        }
         #endregion

        #region sCusSql
        public virtual string Get_CusSql()
        {
            return sCusSql;
        }

        public virtual string CusSql
        {
            get { return sCusSql; }
            set { sCusSql = value; }
        }
        #endregion

        #region sPrcoCode
        public virtual string Get_PrcoCode()
        {
            return sPrcoCode;
        }
        public virtual string PrcoCode
        {
            get { return sPrcoCode; }
            set { sPrcoCode = value; }
        }
        #endregion

        #region sWitch
        public virtual string Get_Witch()
        {
            //属性sKey,用来确定该文本框内容在数据库中的代码 
            return sWitch;
            //set { Witch = value; }
        }
        public virtual void Set_Witch2Cus()
        {
            //属性sKey,用来确定该文本框内容在数据库中的代码 
            sWitch = "CUS";
        }

        public virtual void Set_Witch2MS()
        {
            sWitch = "MS";
        }

        #endregion

        #region sOrderBy
        public virtual string Get_OrderBy()
        {
            return sOrderBy;
        }
        public virtual string OrderBy
        {
            get { return sOrderBy; }
            set { sOrderBy = value; }
        }
        #endregion

        #region sBackTableName
        public virtual string BackTableName
        {
            get { return sBackTableName; }
            set { sBackTableName = value; }
        }
        #endregion

        #region sContrl
        public virtual ArrayList Contrl
        {
            get { return sContrl; }
            set { sContrl = value; }
        }
        #endregion

        #region sColName
        public virtual ArrayList ColName
        {
            get { return sColName; }
            set { sColName = value; }
        }
        #endregion

        #region sBackName
        public virtual ArrayList BackName
        {
            get { return sBackName; }
            set { sBackName = value; }
        }
        #endregion       

        #region siCol
        public virtual ArrayList iCol
        {
            get { return siCol; }
            set { siCol = value; }
        }
         #endregion

        #region sCtlAttr
        public virtual ArrayList CtlAttr
        {
            get { return sCtlAttr; }
            set { sCtlAttr = value; }
        }
         #endregion              

        #region Allow KeyPress Event
        public bool Allow_BeforeKeyPress
        {
            get { return BeforeKeyPress; }
            set { BeforeKeyPress = value; }
        }
        public bool Allow_AfterKeyPress
        {
            get { return AfterKeyPress; }
            set { AfterKeyPress = value; }
        }
        #endregion

        #region Define delegate
        //Define Event Before KeyPress
        public delegate void BeforeSubEventHandler(object sender, KeyEventArgs e);
        public event BeforeSubEventHandler BeforeSubEditorInvok;

        //Define Event After KeyPress
        public delegate void AfterSubEventHandler(object sender, KeyEventArgs e);
        public event AfterSubEventHandler AfterSubEditorInvok;
        #endregion

        private void F4_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(BeforeKeyPress)            
                BeforeSubEditorInvok(sender, e);

            if (e.KeyCode == Keys.F4)
            {
                GeneralCommon.DD_New.sKeyName = sKeyName.Trim();
                GeneralCommon.DD_New.sKey = sKeyValue.Trim();          
                GeneralCommon.DD_New.sJoin = sJoin.Trim();
                GeneralCommon.DD_New.sWitch = sWitch.Trim();
                GeneralCommon.DD_New.sOrderBy = sOrderBy.Trim();
                GeneralCommon.DD_New.sCusCode = sCusSql.Trim();
                GeneralCommon.DD_New.sPrcoCode = sPrcoCode.Trim();
               
                GeneralCommon.DD_New.sBackTableName = sBackTableName.Trim();
                GeneralCommon.DD_New.sBackName = sBackName;
                GeneralCommon.DD_New.sContrl = sContrl;
                GeneralCommon.DD_New.sCtlAttr = sCtlAttr;
                GeneralCommon.DD_New.siCol = siCol;
                GeneralCommon.DD_New.sColName = sColName;
      
                DataDicCommon_New.Gf_Common_DD(e.KeyCode);

                if (GeneralCommon.OleDbConn .State != 0)
                {
                    GeneralCommon.OleDbConn .Close();
                }         
                
            }
            this.Select();
            if(AfterKeyPress)           
                AfterSubEditorInvok(sender, e);
            
        }
    }
}
