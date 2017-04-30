using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommonClass
{
	public partial class tEditor : FarPoint.Win.Spread.CellType.ISubEditor
	{
		public tEditor()
		{
			InitializeComponent();
		}
		
		public delegate void CloseUpEventHandler(object sender, System.EventArgs e);
		public CloseUpEventHandler CloseUpEvent;

        public event CloseUpEventHandler CloseUp
        {
            add
            {
                CloseUpEvent = (CloseUpEventHandler)System.Delegate.Combine(CloseUpEvent, value);
            }
            remove
            {
                CloseUpEvent = (CloseUpEventHandler)System.Delegate.Remove(CloseUpEvent, value);
            }
        }
		
		public delegate void ValueChangedEventHandler(object sender, System.EventArgs e);
		public ValueChangedEventHandler ValueChangedEvent;

        public event ValueChangedEventHandler ValueChanged
        {
            add
            {
                ValueChangedEvent = (ValueChangedEventHandler)System.Delegate.Combine(ValueChangedEvent, value);
            }
            remove
            {
                ValueChangedEvent = (ValueChangedEventHandler)System.Delegate.Remove(ValueChangedEvent, value);
            }
        }
		
		public string colName = "";
		public void OK_Clicked(object sender, EventArgs e)
		{
			if (ValueChangedEvent != null)
				ValueChangedEvent(this, EventArgs.Empty);
			if (CloseUpEvent != null)
				CloseUpEvent(this, EventArgs.Empty);
		}
		
		public void Close_Clicked(object sender, EventArgs e)
		{
			if (CloseUpEvent != null)
				CloseUpEvent(this, EventArgs.Empty);
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			txt.Text = "";
		}
		
		public void txt_TextChanged(object sender, EventArgs e)
		{
			//Text = colName & ": " & txt.Text
		}
		
		public System.Drawing.Point GetLocation(System.Drawing.Rectangle rect)
		{
			Point pt = new Point(0);
			Size sz = GetPreferredSize();
			pt.Y = System.Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Height / 2) - (sz.Height / 2));
			pt.X = System.Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width / 2) - (sz.Width / 2));
			return pt;
		}
		
		public System.Drawing.Size GetPreferredSize()
		{
			return new Size(367, 249);
		}
		
		public System.Windows.Forms.Control GetSubEditorControl()
		{
			return this;
		}
		
		public object GetValue()
		{
			string sValue = "";
			foreach (string text in txt.Lines)
			{
				sValue += (string) (text + " ");
			}
			sValue.Trim();
			return sValue;
		}
		
		public void SetValue(object value)
		{
			txt.Text = value.ToString();
		}


        #region ISubEditor ≥…‘±

        event EventHandler FarPoint.Win.Spread.CellType.ISubEditor.CloseUp
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        event EventHandler FarPoint.Win.Spread.CellType.ISubEditor.ValueChanged
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
}
