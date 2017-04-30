using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public class JOBVALOBJ
	{
		
		private string token; //token号码
		private string plt; // plt 子系统代码+序号
		private string progamId; //progamId 功能ID
		private int programseq; //programseq 序号
		private string userId;
		
		
		public JOBVALOBJ(string plt, string progamId, int programseq, string uId, string token)
		{
			if (token.Equals(""))
			{
				this.token = "0";
			}
			else
			{
				this.token = token;
			}
			
			this.plt = plt;
			this.progamId = progamId;
			this.programseq = programseq;
			this.userId = uId;
		}
		
		public string u_token
		{
			get
			{
				// Gets the property value.
				return token;
			}
			set
			{
				// Sets the property value.
				token = value;
			}
		}
		
		
		public string u_plt
		{
			get
			{
				// Gets the property value.
				return plt;
			}
			set
			{
				// Sets the property value.
				plt = value;
			}
		}
		
		
		public string u_progamId
		{
			get
			{
				// Gets the property value.
				return progamId;
			}
			set
			{
				// Sets the property value.
				progamId = value;
			}
		}
		
		
		
		public int u_programseq
		{
			get
			{
				// Gets the property value.
				return programseq;
			}
			set
			{
				// Sets the property value.
				programseq = value;
			}
		}
		
		public string u_userID
		{
			get
			{
				// Gets the property value.
				return userId;
			}
			set
			{
				// Sets the property value.
				userId = value;
			}
		}
		
		
	}
	
}
