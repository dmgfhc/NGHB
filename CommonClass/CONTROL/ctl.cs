using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public partial class ctl
	{
		
		public override string Text
		{
			get
			{
				return txt.Text;
			}
			set
			{
				txt.Text = value;
			}
		}
	}
	
}
