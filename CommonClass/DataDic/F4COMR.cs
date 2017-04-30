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
	public class F4COMR : System.Windows.Forms.UserControl
	{


        //'ί������ �������Ϊһ���ַ���
		public delegate void DelegateTextChanged(object sender, System.EventArgs e);

        //'�����¼�
		private DelegateTextChanged TextChangedEvent;
		new public event DelegateTextChanged TextChanged
		{
			add
			{
				TextChangedEvent = (DelegateTextChanged) System.Delegate.Combine(TextChangedEvent, value);
			}
			remove
			{
				TextChangedEvent = (DelegateTextChanged) System.Delegate.Remove(TextChangedEvent, value);
			}
		}


        private int sMaxlen; //�洢max����  
		private string sKeyValue = "";
		[Category("F4COMR ����"), Description("��������")]public string sKey
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
        [Category("F4COMR ����"), Description("��������")]
        public string sJoin
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
		
		public int sMax
		{
			get
			{
				return sMaxlen;
			}
			set
			{
				sMaxlen = value;
				CD.MaxLength = value;
			}
		}
		
		public override string Text
		{
			get
			{
				return CD.Text;
			}
			set
			{
				CD.Text = value;
			}
		}
		
		private void InitSetting()
		{
			
			rControl.Add(CD, null, null, null);
			rControl.Add(CD_NAME, null, null, null);
			fControl.Add("CD", null, null, null);
			fControl.Add("CD_NAME", null, null, null);
		}
		
        /// <summary>
        /// ����sJoin���Եĳ��ȵõ�where������
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
		
        /// <summary>
        /// F4COMR�ؼ�KeyUp�¼���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void CD_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F4)
			{
				DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
			}
			else
			{
				//If Len(Trim(CD.Text)) = CInt(Me.sMax) Then
				//    CD_NAME.Text = DataDicCommon.Gf_CommNameFind(GeneralCommon.M_CN1, Me.sKey, Trim(CD.Text).ToUpper, 2)
				//Else
				//    CD_NAME.Text = ""
				//End If
				
				ChangeCDNameText();
				
			}
			
		}


        /// <summary>
        /// F4COMR�ؼ����ݸı��¼���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F4COMR_SizeChanged(object sender, EventArgs e)
        {
            //this.CD.Width =36;
            //this.CD_NAME.Width = this.Width - 36;
            //this.CD.Height = 22;
            //this.CD.Left = 0;
            //this.CD.Top = 0;
            //this.CD_NAME.Height = 22;
            //this.CD_NAME.Top = 0;
            //CD_NAME.Left = this.CD.Width;
            this.CD.Width = this.Width / 3 ;
            this.CD_NAME.Width = this.Width - this.CD.Width;
            this.CD.Height = 22;
            this.CD.Left = 0;
            this.CD.Top = 0;
            this.CD_NAME.Height = 22;
            this.CD_NAME.Top = 0;
            CD_NAME.Left = this.CD.Width;
            this.Height = 22;
        }



        private void CD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataDicCommon.Gf_Master_DD(rControl, fControl, GetQuery(), "", 0, GetFilter(), 1);
        }
		
		internal void OnTextChange(object sender, System.EventArgs e)
		{
			ChangeCDNameText();
			if (TextChangedEvent != null)
				TextChangedEvent(sender, new System.EventArgs());
			
		}
		
        //'����CD_Name��Text���ԣߣ�Zhouchao
        //'20090428�޸�
		private void ChangeCDNameText()
		{
            CD_NAME.Text = DataDicCommon.Gf_CommNameFind(GeneralCommon.M_CN1, this.sKey, (string)(CD.Text.Trim().ToUpper()), "2");
			
            //if (CD.Text.Trim().Length == this.sMax)
            //{
            //    CD_NAME.Text = DataDicCommon.Gf_CommNameFind(GeneralCommon.M_CN1, this.sKey, (string) (CD.Text.Trim().ToUpper()), "2");
            //}
            //else
            //{
            //    CD_NAME.Text = "";
            //}

        }



        #region  " Windows ������������ɵĴ��� "

        public F4COMR()
		{
			
			
			InitializeComponent();
			
			
			InitSetting();
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
		
		
		internal System.Windows.Forms.TextBox CD;
		public System.Windows.Forms.TextBox CD_NAME;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.CD = new System.Windows.Forms.TextBox();
            this.CD_NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CD
            // 
            this.CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CD.Font = new System.Drawing.Font("����", 9.75F);
            this.CD.Location = new System.Drawing.Point(0, 0);
            this.CD.Name = "CD";
            this.CD.Size = new System.Drawing.Size(36, 22);
            this.CD.TabIndex = 0;
            this.CD.TextChanged += new System.EventHandler(this.OnTextChange);
            this.CD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CD_KeyUp);
            this.CD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CD_MouseDoubleClick);
            // 
            // CD_NAME
            // 
            this.CD_NAME.BackColor = System.Drawing.SystemColors.Window;
            this.CD_NAME.Enabled = false;
            this.CD_NAME.Font = new System.Drawing.Font("����", 9.75F);
            this.CD_NAME.Location = new System.Drawing.Point(36, 0);
            this.CD_NAME.Name = "CD_NAME";
            this.CD_NAME.Size = new System.Drawing.Size(121, 22);
            this.CD_NAME.TabIndex = 0;
            // 
            // F4COMR
            // 
            this.Controls.Add(this.CD);
            this.Controls.Add(this.CD_NAME);
            this.Name = "F4COMR";
            this.Size = new System.Drawing.Size(161, 24);
            this.SizeChanged += new System.EventHandler(this.F4COMR_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion

       

       
		
	}
	
}
