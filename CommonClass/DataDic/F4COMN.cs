using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CommonClass
{
	public class F4COMN : System.Windows.Forms.TextBox
	{
		
		
		private string sKeyValue = "";
		[Category("F4COMN 配置"), Description("代码管理号")]public string sKey
			{
			get
			{
				return sKeyValue;
			}
			set
			{
				sKeyValue = value;
			}
		}
		
		private string Join = "";
		[Category("F4COMN 配置"), Description("筛选条件")]public string sJoin
			{
			get
			{
				return Join;
			}
			set
			{
				Join = value;
			}
		}
		
		
		Collection rControl = new Collection();
		Collection fControl = new Collection();
		
		private void InitSetting()
		{
			
			rControl.Add(this, null, null, null);
			fControl.Add("CD", null, null, null);
		}
		
        /// <summary>
        /// F4点击事件。按下“F4”时，显示数据字典。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void F4EventProc(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F4)
			{
				DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
			}
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F4COMN_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if (e.KeyCode == Keys.F4)
            //{
                DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
            //}
        }

        /// <summary>
        /// 得到sql语句查询条件。
        /// </summary>
        /// <returns></returns>
		private string GetFilter()
		{
			string rtn;
			if (sJoin.Trim().Length > 0)
			{
				rtn = sJoin + " AND " + " CD_MANA_NO = \'" + sKey + "\' ";
			}
			else
			{
				rtn = " CD_MANA_NO = \'" + sKey + "\' ";
			}
			return rtn;
		}
		
        /// <summary>
        /// 调用Gf_CommonCodeSQL() 方法，利用BBB_CD表结构得到不带where条件的sql语句。
        /// </summary>
        /// <returns></returns>
		private string GetQuery()
		{
			return DataDicCommon.Gf_CommonCodeSQL();
		}
		
		
		#region  Windows 绐椾綋璁捐鍣ㄧ敓鎴愮殑浠ｇ爜
		
		public F4COMN()
		{

            //该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();

            //在 InitializeComponent() 调用之后添加任何初始化
			InitSetting();
		}

        //UserControl 重写 dispose 以清理组件列表。
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

        //Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
        //'注意: 以下过程是 Windows 窗体设计器所必需的
        //'可以使用 Windows 窗体设计器修改此过程。
        //'不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			base.KeyUp += new System.Windows.Forms.KeyEventHandler(F4EventProc);
            base.MouseDoubleClick += new MouseEventHandler(F4COMN_MouseDoubleClick);
		}
		
		#endregion
		
	}
	
	
	
}
