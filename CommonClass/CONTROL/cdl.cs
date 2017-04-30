using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CommonClass
{
	public partial class cdl
	{
		
		public override string Text
		{
			
			get
			{
				string xx = dtp.Text.Trim();
				string fmt = dtp.CustomFormat;
				switch (fmt.Length)
				{
					case 19:
						return xx.Substring(0, 4) + xx.Substring(5, 2) + xx.Substring(8, 2) + xx.Substring(11, 2) + xx.Substring(14, 2) + xx.Substring(17, 2);
					case 10:
						return xx.Substring(0, 4) + xx.Substring(5, 2) + xx.Substring(8, 2);
					case 8:
						return xx.Substring(0, 2) + xx.Substring(3, 2) + xx.Substring(6, 2);
				}
                return "";
			}
			
			set
			{
				string fmt = dtp.CustomFormat;
				
				switch (fmt.Length)
				{
					case 19:
						if (value == "")
						{
							dtp.Text = "";
						}
						else
						{
							dtp.Text = (string) (value.Substring(0, 4) + "-" + value.Substring(4, 2) + "-" + value.Substring(6, 2) + " " + value.Substring(8, 2) + ":" + value.Substring(10, 2) + ":" + value.Substring(12, 2));
						}
						break;
						
					case 10:
						if (value == "")
						{
							dtp.Text = "";
						}
						else
						{
							dtp.Text = (string) (value.Substring(0, 4) + "-" + value.Substring(4, 2) + "-" + value.Substring(6, 2) + " ");
						}
						break;
						
					case 8:
						if (value == "")
						{
							dtp.Text = "";
						}
						else
						{
							dtp.Text = (string) (value.Substring(0, 2) + ":" + value.Substring(2, 2) + ":" + value.Substring(4, 2) + " ");
						}
						break;
						
				}
				
			}
		}
	}
	
}
