using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

//Namespace Mathx

namespace CommonClass
{
	public class FormatValidate
	{
		
		
		
		// Methods
		public FormatValidate()
		{
		}
		public static bool IsFloat(string strText)
		{
			string pattern = "^(-?\\d+)(\\.\\d+)?$";
			return System.Text.RegularExpressions.Regex.IsMatch(strText, pattern);
		}
		public static bool IsInteger(string strText)
		{
			string pattern = "^-?\\d+$";
			return System.Text.RegularExpressions.Regex.IsMatch(strText, pattern);
		}
		public static bool IsNagativeFloat(string strText)
		{
			string pattern = "^(-(([0-9]+\\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*)))$";
			return Regex.IsMatch(strText, pattern);
		}
		
		public static bool IsNagativeInteger(string strText)
		{
			string pattern = "^-[0-9]*[1-9][0-9]*$";
			return Regex.IsMatch(strText, pattern);
		}
		
		public static bool IsPositiveFloat(string strText)
		{
			string pattern = "^(([0-9]+\\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*))$";
			return Regex.IsMatch(strText, pattern);
		}
		public static bool IsPositiveInteger(string strText)
		{
			string pattern = "^[0-9]*[1-9][0-9]*$";
			return Regex.IsMatch(strText, pattern);
		}
	}
	
	//End Namespace
}
