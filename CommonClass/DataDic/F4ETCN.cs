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
		[Category("F4ETCN2 ����"), Description("�Զ���SQL���")]public string sSqletc
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
		[Category("F4ETCN2 ����"), Description("�����ж�Ӧ������")]public string sFcontrol
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
		[Category("F4ETCN2 ����"), Description("ɸѡ����")]public string sJoin
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
        /// �õ�sJoin���Ե�ֵ��
        /// </summary>
        /// <returns></returns>
		private string GetFilter()
		{
			return sJoin;
		}
		
        /// <summary>
        /// �õ�sSqletc����ֵ��
        /// </summary>
        /// <returns></returns>
		private string GetQuery()
		{
			return sSqletc;
        }


        #region  �����������ɵĴ���

        public F4ETCN()
		{
			
		
			InitializeComponent();
		}
		
		/// <summary>
        /// ����ر�ʱ�����ø÷������ͷ������齨
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
