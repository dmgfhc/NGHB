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
    public partial class F4COMW : UserControl
    {
        public F4COMW()
        {
            InitializeComponent();
        }

        private string sKeyValue = "";
        //存储sKey属性
        private string sMaxlen = "";
        //存储max属性
        private string Join = "";
        // 存储sjoin属性
        private bool bChecked = true;

        private string CusCode;// 增加类似sc的自定义Sql语句
        private string PrcoCode;//增加调用存储过程名
        private ArrayList parameters=new ArrayList();//;//调用存储过程参数
        //add by nanjianxing at 20090309 13:30
        public string sCusCode
        {
            get { return CusCode; }
            set { CusCode = value; }
        }

        public string sPrcoCode
        {
            get { return PrcoCode; }
            set { PrcoCode = value; }
        }

        public ArrayList sParameters
        {
            get { return parameters; }
            set { parameters = value; }
        }
        // Define the property.

        #region "查询"
        public string sKey
        {
            get { return sKeyValue; }
            set { sKeyValue = value; }
        }

        public string sJoin
        {
            get { return Join; }
            set { Join = value; }
        }

        public string sMax
        {
            get { return sMaxlen; }
            set
            {
                sMaxlen = value;
                CD.MaxLength = Convert.ToInt32(value==""?"9999":value);
            }
        }

        public override string Text
        {
            get { return CD.Text; }
            set { CD.Text = value; }
        }

        public bool Checked
        {
            get { return bChecked; }
            set { bChecked = value; }
        }

        #endregion
        public delegate void MyEventHandler(object sender, KeyEventArgs e);
        public event MyEventHandler BeforeSubEditorInvok;
        public virtual void CD_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            BeforeSubEditorInvok(sender, e);
            if (Checked)
            {
                if (e.KeyCode == Keys.F4)
                {
                    GeneralCommon.DD.sWitch = "MS";
                    GeneralCommon.DD.sKey = this.sKey;
                    GeneralCommon.DD.nameType = "2";
                    GeneralCommon.rControl.Add(CD);
                    GeneralCommon.rControl.Add(CD_NAME);
                    GeneralCommon.DD.sJoin = sJoin.Trim();

                    GeneralCommon.DD.sCusCode = sCusCode.Trim();
                    GeneralCommon.DD.sPrcoCode = sPrcoCode.Trim();
                    GeneralCommon.DD.sParameters = sParameters;
                    DataDicCommon.Gf_Common_DD(GeneralCommon.OleDbConn, e.KeyCode);
                }
                else
                {
                    if (CD.Text.Trim().Length == Convert.ToInt32(this.sMax))
                    {
                        CD_NAME.Text = DataDicCommon.Gf_CommNameFind(GeneralCommon.OleDbConn, this.sKey, CD.Text.Trim().ToUpper(), "2");
                    }
                    else
                    {
                        CD_NAME.Text = "";
                    }
                }
                if (GeneralCommon.OleDbConn.State != 0)
                {
                    GeneralCommon.OleDbConn.Close();
                }
            }
        }
    }
}
