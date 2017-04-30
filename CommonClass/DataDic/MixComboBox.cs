using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class MixComboBox : UserControl
    {
        public MixComboBox()
        {
            InitializeComponent();
        }

        private void MixComboBox_SizeChanged(object sender, EventArgs e)
        {
            this.Height = 28;
            this.textBox1.Height = 28;
            this.comboBox1.Height = 28;


            int user_contr_wth = 0;
            user_contr_wth = this.Width - this.Width / 6;
            this.textBox1.Width = user_contr_wth / 3 * 2;
            this.textBox1.Left = 0;
            this.comboBox1.Width = user_contr_wth / 3;
            this.comboBox1.Left = this.textBox1.Width;
        }

        private string sSqlValue = "";
        [Category("SQL 配置"), Description("自定义SQL查询语句")]
        public string sSql
        {
            get
            {
                return sSqlValue;
            }
            set
            {
                sSqlValue = value;
            }
        }

        public string MixComboBoxValue
        {
            get
            {
                try
                {
                    if (this.comboBox1.SelectedIndex == 0)
                        return "";
                    else
                        return this.comboBox1.SelectedItem.ToString();
                }
                catch { return ""; }
            }
        }

        private string GetQuery()
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
                    sqlRlt = "SELECT " + s_flds_arr[1] + sqlRlt.Substring(from_pos, sqlRlt.Length - from_pos) + " AND "
                        + s_flds_arr[0] + " LIKE '" + this.textBox1.Text + "%'";
                }
                else
                {
                    sqlRlt = "SELECT " + s_flds_arr[1] + sqlRlt.Substring(from_pos, sqlRlt.Length - from_pos) +
                        " WHERE " + s_flds_arr[0] + " LIKE  '" + this.textBox1.Text + "%'";
                }
            }
            catch { GeneralCommon.Gp_MsgBoxDisplay("自定义SQL语句有问题:" + sSql, "", ""); }

            return sqlRlt;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.comboBox1.Items.Clear();
                this.comboBox1.Text = "";
            }
            else
            {

                this.comboBox1.Text = "";
                string sql = GetQuery();
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                if (GeneralCommon.M_CN1.State == 0)
                    if (GeneralCommon.GF_DbConnect() == false) return;
                AdoRs.Open(sql, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                this.comboBox1.Items.Clear();
                while (!AdoRs.EOF)
                {
                    this.comboBox1.Items.Add(AdoRs.Fields[0].Value);
                    AdoRs.MoveNext();
                }
            }
            

        }

       
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.textBox1.Text == "")
        //        this.comboBox1.Text = "";
        //    else 
        //    {
        //        this.comboBox1.Text = "";
  
        //    }
        //}
      

    }
}
