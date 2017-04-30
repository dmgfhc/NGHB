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
    public partial class F4COMR : UserControl
    {
        public F4COMR()
        {
            InitializeComponent();
        }
       
        private string sKeyName = "CD_MANA_NO";      
        private string sKeyValue = "";        //存储sKey属性 
        private string sJoin = "";        // 存储sjoin属性 
        private string sCusSql = "";// 增加类似sc的自定义Sql语句
        private string sPrcoCode = "";//增加调用存储过程名
        private string sWitch = "MS";
        private int sMaxLength = 9999;
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

        #region sMaxLength
        public virtual int Get_MaxLength()
        {
            return sMaxLength;
        }
        public virtual int MaxLength
        {
            //属性sKey,用来确定该文本框内容在数据库中的代码 
            get { return sMaxLength; }
            set { sMaxLength = value<1?9999:value; }
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


        public override string Text
        {
            get { return CD.Text; }
            set { CD.Text = value; }
        }

        //public virtual string KeyName
        //{
        //    get { return sKeyName; }
        //    set { sKeyName = value; }
        //}
        ////public virtual string Restrict
        ////{
        ////    get { return sRestrict; }
        ////    set { sRestrict = value; }
        ////}
        //public virtual ArrayList Contrl
        //{
        //    get { return sContrl; }
        //    set { sContrl = value; }
        //}
        //public virtual ArrayList BackName
        //{
        //    get { return sBackName; }
        //    set { sBackName = value; }
        //}
        //public virtual ArrayList ColName
        //{
        //    get { return sColName; }
        //    set { sColName = value; }
        //}
        //public virtual ArrayList iCol
        //{
        //    get { return siCol; }
        //    set { siCol = value; }
        //}
        //public virtual ArrayList CtlAttr
        //{
        //    get { return sCtlAttr; }
        //    set { sCtlAttr = value; }
        //}

        //public virtual string BackTableName
        //{
        //    get { return sBackTableName; }
        //    set { sBackTableName = value; }
        //}
        //#region Del Witch
        //public virtual string Get_Witch()
        //{
        //    //属性sKey,用来确定该文本框内容在数据库中的代码 
        //    return sWitch;
        //    //set { Witch = value; }
        //}
        //public virtual void Set_Witch2Cus()
        //{
        //    //属性sKey,用来确定该文本框内容在数据库中的代码 
        //    sWitch = "CUS";
        //}

        //public virtual void Set_Witch2Def()
        //{
        //    sWitch = "MS";
        //}

        //#endregion

        //#region // Define the property.
        //public virtual string Get_Key()
        //{
        //    return sKeyValue;
        //}
        //public virtual string Key
        //{
        //    //属性sKey,用来确定该文本框内容在数据库中的代码 
        //    get { return sKeyValue; }
        //    set { sKeyValue = value; }
        //}

        //#endregion

       

        //public virtual string Get_Join()
        //{
        //    return sJoin;
        //}

        //public virtual string Join
        //{
        //    get { return sJoin; }
        //    set { sJoin = value; }
        //}

        ////add by nanjianxing at 20090309 13:30
        //public virtual string Get_CusSql()
        //{
        //    return sCusSql;
        //}
        //public virtual string CusSql
        //{
        //    get { return sCusSql; }
        //    set { sCusSql = value; }
        //}

        //public virtual string Get_OrderBy()
        //{
        //    return sOrderBy;
        //}
        //public virtual string OrderBy
        //{
        //    // get { return CusCode; }
        //    set { sOrderBy = value; }
        //}

        //public virtual string Get_PrcoCode()
        //{
        //    return sPrcoCode;
        //}
        //public virtual string PrcoCode
        //{
        //    get { return sPrcoCode; }
        //    set { sPrcoCode = value; }
        //}

        ////public virtual ArrayList Get_Parameters()
        ////{
        ////    return sParameters;
        ////}
        ////public virtual ArrayList Parameters
        ////{
        ////    get { return sParameters; }
        ////    set { sParameters = value; }
        ////}
      
        ////public virtual ArrayList Get_Args_Out()
        ////{
        ////    return sArgs_Out;
        ////}
        ////public virtual ArrayList Args_Out
        ////{
        ////    //  get { return parameters; }
        ////    set { sArgs_Out = value; }
        ////}

        private void CD_KeyUp(object sender, KeyEventArgs e)
        {
            if (BeforeKeyPress)                   
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
                if (sContrl.Count == 0)
                {
                    DataDicCommon_New.Gp_DD_Collection(this , this.CD, "pirb", "cd", "代码", 1);
                    DataDicCommon_New.Gp_DD_Collection(this, this.CD_NAME, "irb", "cd_name", "代码名称", 2);
                    
                }
                GeneralCommon.DD_New.sContrl = sContrl;
                GeneralCommon.DD_New.sCtlAttr = sCtlAttr;
                GeneralCommon.DD_New.siCol = siCol;
                GeneralCommon.DD_New.sColName = sColName;
            
                DataDicCommon_New.Gf_Common_DD(e.KeyCode);
              
            }
            else
            {
                if (CD.Text.Trim().Length == sMaxLength)
                {
                    DataDicCommon_New.Gp_F4Find(this);
                }
                else
                {
                    CD_NAME.Text = "";
                }
            }
            if (GeneralCommon.OleDbConn .State != ConnectionState.Closed)
            {
                GeneralCommon.OleDbConn.Close();
            }
            this.CD.Select();
            if (AfterKeyPress)               
                AfterSubEditorInvok(sender, e);
        }
    }
}
