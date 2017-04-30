using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public partial class ccl
	{
		
		public override string Text
		{
			get
			{
				if (cbo.DropDownStyle == System.Windows.Forms.ComboBoxStyle.DropDownList)
				{
					if (Information.IsDBNull(this.cbo.SelectedValue))
					{
						return "";
					}
					else
					{
						return this.cbo.SelectedValue.ToString();
					}
                   
				}
				else if (cbo.DropDownStyle == System.Windows.Forms.ComboBoxStyle.DropDown)
				{
					return this.cbo.Text;
				}
                return "";
			}
			set
			{
				if (cbo.DropDownStyle == System.Windows.Forms.ComboBoxStyle.DropDownList)
				{
					this.cbo.SelectedValue = value;
				}
				else if (cbo.DropDownStyle == System.Windows.Forms.ComboBoxStyle.DropDown)
				{
					this.cbo.Text = value;
				}
				
			}
			//Get
			//    Return Me.cbo.SelectedValue
			//End Get
			//Set(ByVal Value As String)
			//    Me.cbo.SelectedValue = Value
			//End Set
		}
	}
	
}
