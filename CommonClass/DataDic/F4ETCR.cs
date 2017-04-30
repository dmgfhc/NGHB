using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Windows.Forms;

namespace CommonClass
{
	public class F4ETCR : System.Windows.Forms.TextBox
	{		
		private List<BControlFiledSetting> m_CFS = new List<BControlFiledSetting>();
		[Category("F4ETCR2 配置"), Description("设置控件和列名的对应"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]public List<BControlFiledSetting> CustomSetting
			{
			get
			{
				return m_CFS;
			}
			set
			{
				m_CFS = value;
			}
		}
		
		private string sQuery = "";
		[Category("F4ETCR2 配置"), Description("自定义SQL语句")]public string sSqletc
			{
			get
			{
				return sQuery;
			}
			set
			{
				sQuery = value;
			}
		}
		
		private string sWhere = "";
		[Category("F4ETCR2 配置"), Description("筛选条件")]public string sJoin
			{
			get
			{
				return sWhere;
			}
			set
			{
				sWhere = value;
			}
		}
		
		Collection rControl = new Collection();
		Collection fControl = new Collection();
		
		private Control m_IC;
        [Category("F4ETCR2 配置"), Description("供用户输入的控件")]
        public Control InputControl
			{
			get
			{
				return m_IC;
			}
			set
			{
				m_IC = value;
				if (m_IC != null)
				{
                    m_IC.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyUpEventProc);
                    m_IC.MouseDoubleClick += new MouseEventHandler(MouseDoublePorc);
				}
			}
		}

        private void MouseDoublePorc(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            while (rControl.Count > 0)
                rControl.Remove(1);

            while (fControl.Count > 0)
                fControl.Remove(1);

            foreach (BControlFiledSetting obj in CustomSetting)
            {
                rControl.Add(obj.TargetControl, null, null, null);
                fControl.Add(obj.ColumnID, null, null, null);
            }
            DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
            //if (e.KeyCode == Keys.F4)
            //{
            //    DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
            //}
            //else
            //{
            //    for (int i = 2; i <= rControl.Count; i++)
            //    {
            //        ((Control)rControl[i]).Text = "";
            //    }
            //    string sSql = GetQuery().ToUpper();
            //    if (sSql.Contains("WHERE"))
            //        sSql += " AND " + fControl[1] + " ='" + ((Control)rControl[1]).Text + "'";
            //    else
            //        sSql += " where " + fControl[1] + "='" + ((Control)rControl[1]).Text + "'";
            //    ADODB.Recordset AdoRs = new ADODB.Recordset();
            //    if (GeneralCommon.M_CN1.State == 0)
            //        if (GeneralCommon.GF_DbConnect() == false) return;
            //    AdoRs.Open(sSql, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            //    if (AdoRs.RecordCount == 1)
            //    {
            //        for (int i = 2; i <= rControl.Count; i++)
            //        {
            //            ((Control)rControl[i]).Text = AdoRs.Fields[i - 1].Value.ToString();
            //        }
            //    }
            //    AdoRs = null;
            //    GeneralCommon.M_CN1.Close();
            //}
        }

        /// <summary>
        /// F4点击事件。按下“F4”时，显示数据字典。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyUpEventProc(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            while (rControl.Count > 0)
                rControl.Remove(1);

            while (fControl.Count > 0)
                fControl.Remove(1);

            foreach (BControlFiledSetting obj in CustomSetting)
            {
                rControl.Add(obj.TargetControl, null, null, null);
                fControl.Add(obj.ColumnID, null, null, null);
            }
			if (e.KeyCode == Keys.F4)
			{
				DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
			}
            else
            {               
                for (int i = 2; i <= rControl.Count; i++)
                {
                    ((Control)rControl[i]).Text = "";
                }
                string sSql = GetQuery().ToUpper();
                //if (sSql.Contains("WHERE"))
                //    sSql += " AND " + fControl[1] + " ='" + ((Control)rControl[1]).Text + "'";

                //if (sSql.Contains("WHERE"))
                //{
                //    if (sSql.Contains("ORDER"))
                //    {
                //        int pointBegin = sSql.IndexOf("ORDER");
                //        int sqlCount = sSql.Length;
                //        string sqlBegin = sSql.Substring(0, pointBegin);
                //        string sqlEnd = sSql.Substring(pointBegin, sqlCount - pointBegin);
                //        string sqlAdd = " AND " + fControl[1] + " ='" + ((Control)rControl[1]).Text + "'";
                //        sSql = sqlBegin + "  " + sqlAdd + " " + sqlEnd;
                //    }
                //    else
                //    {
                //        sSql += " AND " + fControl[1] + " ='" + ((Control)rControl[1]).Text + "'";
                //    }

                //}
                /////20130108
              int lengthss = ((Control)rControl[1]).Text.Trim().Length;

                if (this.MaxLength != 32767)
                {
                    if (lengthss != this.MaxLength) return;
                }

                //// /////20130108
                if (sSql.Contains("WHERE"))
                {
                    int pointBegin = sSql.IndexOf("WHERE");
                    int sqlCount = sSql.Length;
                    string sqlBegin = sSql.Substring(0, pointBegin + 5);
                    string sqlEnd = " AND " + sSql.Substring(pointBegin + 5, sqlCount - pointBegin - 5);
                    string sqlAdd = "  " + fControl[1] + " ='" + ((Control)rControl[1]).Text + "'";
                    sSql = sqlBegin + "  " + sqlAdd + " " + sqlEnd;
                }
                else
                    sSql += " where " + fControl[1] + "='" + ((Control)rControl[1]).Text + "'";
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                if (GeneralCommon.M_CN1.State == 0)
                    if (GeneralCommon.GF_DbConnect() == false) return;
                AdoRs.Open(sSql, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (AdoRs.RecordCount ==1)
                {
                    for (int i = 2; i <= rControl.Count; i++)
                    {
                        ((Control)rControl[i]).Text = AdoRs.Fields[i-1].Value.ToString();
                    }
                }
                AdoRs = null;
                GeneralCommon.M_CN1.Close();
            }
			
		}
		
        /// <summary>
        /// 得到sJoin属性值。
        /// </summary>
        /// <returns></returns>
		private string GetFilter()
		{
			return sJoin;
		}
		
        /// <summary>
        /// 得到sSqletc属性值。
        /// </summary>
        /// <returns></returns>
		private string GetQuery()
		{
			return sSqletc;
        }

        #region  " 组件设计器生成的代码 "

        public F4ETCR()
		{			
			InitializeComponent();			
		}
		
		/// <summary>
        /// 窗体关闭时，调用该方法，关闭所有组建。
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private System.ComponentModel.Container components = null;
		
		
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		
		#endregion
		
		
	}
	
	public class BControlFiledSetting
	{
		
		private Control m_ctl;
		public Control TargetControl
		{
			get
			{
				return m_ctl;
			}
			set
			{
				m_ctl = value;
			}
		}
		
		private string m_name;
		public string ColumnID
		{
			get
			{
				return m_name;
			}
			set
			{
				m_name = value;
			}
		}
	}
	
}
