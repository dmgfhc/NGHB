using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public class VirtualControl
	{
		
		
		protected string m_Content = "";
		
		public VirtualControl()
		{
			
		}
		
		public VirtualControl(string Value)
		{
			m_Content = Value;
		}
		
		public string Text
		{
			get
			{
				return m_Content;
			}
			set
			{
				m_Content = value;
			}
		}
		
		public string Value
		{
			get
			{
				return m_Content;
			}
			set
			{
				m_Content = value;
			}
		}
		
		public string Tag
		{
			get
			{
				return m_Content;
			}
			set
			{
				m_Content = value;
			}
		}
		
		public bool Enabled
		{
			get
			{
				return true;
			}
			set
			{
				
			}
		}
		
		public void Focus()
		{
			
		}
	}
	
}
