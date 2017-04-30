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
		[Category("F4COMN ����"), Description("��������")]public string sKey
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
		[Category("F4COMN ����"), Description("ɸѡ����")]public string sJoin
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
        /// F4����¼������¡�F4��ʱ����ʾ�����ֵ䡣
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
        /// �õ�sql����ѯ������
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
        /// ����Gf_CommonCodeSQL() ����������BBB_CD��ṹ�õ�����where������sql��䡣
        /// </summary>
        /// <returns></returns>
		private string GetQuery()
		{
			return DataDicCommon.Gf_CommonCodeSQL();
		}
		
		
		#region  Windows 窗体设计器生成的代码
		
		public F4COMN()
		{

            //�õ����� Windows ���������������ġ�
			InitializeComponent();

            //�� InitializeComponent() ����֮������κγ�ʼ��
			InitSetting();
		}

        //UserControl ��д dispose ����������б�
        /// <summary>
        /// ����ر�ʱ�����ø÷������ر������齨��
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

        //Windows ����������������
		private System.ComponentModel.Container components = null;
		
        //'ע��: ���¹����� Windows ����������������
        //'����ʹ�� Windows ����������޸Ĵ˹��̡�
        //'��Ҫʹ�ô���༭���޸�����
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			base.KeyUp += new System.Windows.Forms.KeyEventHandler(F4EventProc);
            base.MouseDoubleClick += new MouseEventHandler(F4COMN_MouseDoubleClick);
		}
		
		#endregion
		
	}
	
	
	
}
