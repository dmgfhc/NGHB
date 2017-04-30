using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CommonClass
{
	public class JOBHelper
	{
		public static string C_WAIT = "A";
		public static string C_PROCESS = "B";
		public static string C_END = "C";
		public static string C_CANCEL = "D";
		public static string C_HOLD = "H";
		
        //     '---------------------------------------------------------------------------------------
        //'   1.ID           : JOB_CHECK_JOB_DEP
        //'   2.Input  Value : token  token号码
        //'   3.Return Value : Boolean
        //'   4.Create Date  :  
        //'   5.Modify Date  :
        //'   6.Comment      : 判断操作时是否要刷新页面
        //'---------------------------------------------------------------------------------------
		public bool JOB_CHECK_JOB_DEP(JOBVALOBJ obj)
		{
			
			string[] Para = new string[2];
			Para[0] = obj.u_token;
			Array rtn3 = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.CHECK_JOB_DEP", 1, Para);

            rtn3.SetValue("a", 0);

            string x = rtn3.GetValue(0).ToString();
			
			if (rtn3 == null)
			{
				
			}
			else if (! (rtn3.GetValue(0).ToString() == "0"))
			{
				MessageBox.Show(rtn3.GetValue(0).ToString());
				return false;
			}
			return true;
		}
		
		public bool JOB_CHECK_JOB_DEP(Collection objs)
		{
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para = new string[2];
				Para[0] = obj.u_token;
				Array rtn3 = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.CHECK_JOB_DEP", 1, Para);
				if (rtn3 == null)
				{
				}
				else if (! (rtn3.GetValue(0).ToString() == "0"))
				{
					MessageBox.Show(rtn3.GetValue(0).ToString());
					return false;
				}
			}
			return true;
		}
		
		
        //---------------------------------------------------------------------------------------
        //'   1.ID           : JOB_INIT_JOB_DEP_TMP
        //'   2.Input  Value : token  token号码,plt 子系统代码+序号,progamId 功能ID，programseq 序号
        //'   3.Return Value : String  返回新的token 号
        //'   4.Create Date  :  
        //'   5.Modify Date  :
        //'   6.Comment      : 判断操作时是否要刷新页面
        //'---------------------------------------------------------------------------------------
		public bool JOB_INIT_JOB_DEP_TMP(JOBVALOBJ obj)
		{
			string[] Para = new string[6];
			Para[0] = obj.u_token;
			Para[1] = obj.u_plt;
			Para[2] = obj.u_progamId;
			Para[3] = obj.u_programseq.ToString();
			Para[4] = obj.u_userID;
			
			Array rtn = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.INIT_JOB_DEP_TMP", 1, Para);
			if (rtn == null)
			{
				
			}
			else if (! (rtn.GetValue(0).ToString() == "1"))
			{
				obj.u_token = rtn.GetValue(0).ToString();
				return true;
			}
			else if (rtn.GetValue(0).ToString() == "1")
			{
				MessageBox.Show("job初始化出错");
				return false;
			}
			return true;
		}
		
		
		public bool JOB_INIT_JOB_DEP_TMP(Collection objs)
		{
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para = new string[6];
				Para[0] = obj.u_token;
				Para[1] = obj.u_plt;
				Para[2] = obj.u_progamId;
				Para[3] = obj.u_programseq.ToString();
				Para[4] = obj.u_userID;
				Array rtn = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.INIT_JOB_DEP_TMP", 1, Para);
				if (rtn == null)
				{
					
				}
				else if (! (rtn.GetValue(0).ToString() == "1"))
				{
					obj.u_token = rtn.GetValue(0).ToString();
					// Return True
				}
				else if (rtn.GetValue(0).ToString() == "1")
				{
					MessageBox.Show("job初始化出错");
					return false;
				}
			}
			
			return true;
		}
		
        //'---------------------------------------------------------------------------------------
        //'   1.ID           : JOB_CHECK_SUB_STATES
        //'   2.Input  Value : plt 子系统代码+序号,progamId 功能ID
        //'   3.Return Value : Boolean  
        //'   4.Create Date  :  
        //'   5.Modify Date  :
        //'   6.Comment      : 判断其他操作是否在进行
        //'---------------------------------------------------------------------------------------
		public bool JOB_CHECK_SUB_STATES(JOBVALOBJ obj)
		{
			string[] Para = new string[3];
			Para[0] = obj.u_plt;
			Para[1] = obj.u_progamId;
			Array rtn = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.CHECK_SUB_STATES", 1, Para);
			
			
			if (rtn == null)
			{
				return false;
			}
			else if (! (rtn.GetValue(0).ToString() == "OK"))
			{
				MessageBox.Show(rtn.GetValue(0).ToString());
				return false;
			}
			else
			{
				return true;
			}
			
			return true;
			
		}
		
		
		public bool JOB_CHECK_SUB_STATES(Collection objs)
		{
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para = new string[3];
				Para[0] = obj.u_plt;
				Para[1] = obj.u_progamId;
				Array rtn = GeneralCommon.Gf_ExecProcedureRe(GeneralCommon.M_CN1, "PKG_JOB.CHECK_SUB_STATES", 1, Para);
				if (rtn == null)
				{
					return false;
				}
				else if (! (rtn.GetValue(0).ToString() == "OK"))
				{
					MessageBox.Show(rtn.GetValue(0).ToString());
					return false;
				}
				else
				{
					//Return True
				}
			}
			
			
			return true;
			
		}
		
		
		
		
    //      '---------------------------------------------------------------------------------------
    //'   1.ID           : JOB_START
    //'   2.Input  Value : plt 子系统代码+序号,progamId 功能ID,programseq 序号
    //'   3.Return Value : Boolean  
    //'   4.Create Date  :  
    //'   5.Modify Date  :
    //'   6.Comment      : 操作开始
    //'---------------------------------------------------------------------------------------
		
		public bool JOB_START(JOBVALOBJ obj)
		{
			
			string[] Para = new string[6];
			
			Para[0] = obj.u_plt;
			Para[1] = obj.u_progamId;
			Para[2] = obj.u_programseq.ToString();
			Para[3] = JOBHelper.C_PROCESS;
			Para[4] = obj.u_userID;
			if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_CHANGESTATE", Para))
				{
				return true;
				
			}
			else
			{
				return false;
				
			}
			
			
		}
		
		
		
		public bool JOB_START(Collection objs)
		{
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para = new string[6];
				
				Para[0] = obj.u_plt;
				Para[1] = obj.u_progamId;
				Para[2] = obj.u_programseq.ToString();
				Para[3] = JOBHelper.C_PROCESS;
				Para[4] = obj.u_userID;
				if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_CHANGESTATE", Para))
					{
					//Return True
					
				}
				else
				{
					return false;
					
				}
			}
			
			return true;
		}
		
		
    //     '---------------------------------------------------------------------------------------
    //'   1.ID           : JOB_END
    //'   2.Input  Value : plt 子系统代码+序号,progamId 功能ID,programseq 序号
    //'   3.Return Value : Boolean  
    //'   4.Create Date  :  
    //'   5.Modify Date  :
    //'   6.Comment      : 操作结束
    //'---------------------------------------------------------------------------------------
		
		public bool JOB_END(JOBVALOBJ obj)
		{
			
			string[] Para = new string[6];
			
			Para[0] = obj.u_plt;
			Para[1] = obj.u_progamId;
			Para[2] = obj.u_programseq.ToString();
			Para[3] = JOBHelper.C_END;
			Para[4] = obj.u_userID;
			if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_CHANGESTATE", Para))
				{
				return true;
				
			}
			else
			{
				return false;
				
			}
			
		}
		
		
		public bool JOB_END(Collection objs)
		{
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para = new string[6];
				
				Para[0] = obj.u_plt;
				Para[1] = obj.u_progamId;
				Para[2] = obj.u_programseq.ToString();
				Para[3] = JOBHelper.C_END;
				Para[4] = obj.u_userID;
				if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_CHANGESTATE", Para))
					{
					//Return True
					
				}
				else
				{
					return false;
					
				}
				
			}
			return true;
		}
		
		
		
    // '---------------------------------------------------------------------------------------
    //'   1.ID           : JOB_SYN_JOB_DEP_TMP
    //'   2.Input  Value : plt 子系统代码+序号,progamId 功能ID,programseq 序号
    //'   3.Return Value : Boolean  
    //'   4.Create Date  :  
    //'   5.Modify Date  :
    //'   6.Comment      : 操作结束后同步 临时表的数据
    //'---------------------------------------------------------------------------------------
		public bool JOB_SYN_JOB_DEP_TMP(JOBVALOBJ obj)
		{
			string[] Para4 = new string[5];
			Para4[0] = obj.u_token;
			Para4[1] = obj.u_plt;
			Para4[2] = obj.u_progamId;
			Para4[3] = obj.u_programseq.ToString();
			
			if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_SYN_JOB_DEP_TMP", Para4))
				{
				return true;
				
			}
			else
			{
				return false;
				
			}
			
			return true;
		}
		
		
		public bool JOB_SYN_JOB_DEP_TMP(Collection objs)
		{
			
			
			foreach (JOBVALOBJ obj in objs)
			{
				string[] Para4 = new string[5];
				Para4[0] = obj.u_token;
				Para4[1] = obj.u_plt;
				Para4[2] = obj.u_progamId;
				Para4[3] = obj.u_programseq.ToString();
				
				if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "PKG_JOB.P_SYN_JOB_DEP_TMP", Para4))
					{
					//Return True
					
				}
				else
				{
					return false;
					
				}
				
			}
			
			
			
			return true;
		}
		
		
		
	}
	
}
