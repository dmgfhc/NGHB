using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public partial class cnl
	{
		
		public override string Text
		{
			get
			{
				return nud.Value.ToString();
			}
			set
			{
				if (value == "")
				{
					nud.Value = 0;
				}
				else
				{
					nud.Value = decimal.Parse(value);
				}
			}
		}
	}
	
}
