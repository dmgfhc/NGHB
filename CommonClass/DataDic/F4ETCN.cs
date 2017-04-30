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
	public class F4ETCN : System.Windows.Forms.TextBox
	{
		
		
		private string sQuery = "";
		[Category("F4ETCN2 配置"), Description("自定义SQL语句")]public string sSqletc
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
		
		private string sColumnId = "";
		[Category("F4ETCN2 配置"), Description("代码列对应的名称")]public string sFcontrol
			{
			get
			{
				return sColumnId;
			}
			set
			{
				sColumnId = value;
			}
		}
		
		private string Join = "";
		[Category("F4ETCN2 配置"), Description("筛选条件")]public string sJoin
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
			fControl.Add(sFcontrol, null, null, null);
		}
		
		private void F4EventProc(object sender, System.Windows.Forms.KeyEventArgs e)
			{
			if (e.KeyCode == Keys.F4)
			{
				if (rControl.Count < 1)
				{
					InitSetting();
				}
				DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
			}
		}

        private void F4ETCN_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if (e.KeyCode == Keys.F4)
            //{
                if (rControl.Count < 1)
                {
                    InitSetting();
                }
                DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
            //}
        }
		





        /// <summary>
        /// 得到sJoin属性的值。
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


        #region  组件设计器生成的代码

        public F4ETCN()
		{
			
		
			InitializeComponent();
		}
		
		/// <summary>
        /// 窗体关闭时，调用该方法，释放所有组建
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
			base.KeyUp += new System.Windows.Forms.KeyEventHandler(F4EventProc);
            base.MouseDoubleClick += new MouseEventHandler(F4ETCN_MouseDoubleClick);
		}
		
		#endregion
		
	}
	
	
}
