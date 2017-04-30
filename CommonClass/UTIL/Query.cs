using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Data.OleDb;
using CommonClass;

namespace CommonClass
{
	public class Query
	{
		
		
		
		protected string queryString;
		
		public Query()
		{
			
		}
		
		public Query(string Qurey)
		{
			queryString = Qurey;
		}
		
		public virtual string sQuery
		{
			get
			{
				return queryString;
			}
			set
			{
				queryString = value;
			}
		}
		
		public DataSet CreateDataSet(bool bAddNullRow)
		{
			DataSet ds = new DataSet();
			OleDbConnection conn=null;
			try
			{
				//Db Connection Check
				if (GeneralCommon.M_CN1.State == 0)
				{
					if (GeneralCommon.GF_DbConnect() == false)
					{
						return ds;
					}
				}
				conn = new OleDbConnection(GeneralCommon.M_CN1.ConnectionString);
				OleDbCommand cmd = new OleDbCommand(sQuery, conn);
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(ds);
				if (bAddNullRow)
				{
					DataRow dr = ds.Tables[0].NewRow();
					ds.Tables[0].Rows.InsertAt(dr, 0);
				}
				return ds;
				
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Query Error : " + ex.Message), "", "");
				if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
				{
					GeneralCommon.M_CN1.Close();
					conn.Close();
					conn = null;
				}
				return ds;
			}
			finally
			{
				if (conn.State != 0)
				{
					conn.Close();
					conn = null;
				}
				
				if (GeneralCommon.M_CN1.State != 0)
				{
					GeneralCommon.M_CN1.Close();
				}
			}
		}
		
		public DataTable CreateDataTable(bool bAddNullRow)
		{
			DataTable dt = new DataTable();
			OleDbConnection conn=null;
			try
			{
				//Db Connection Check
				if (GeneralCommon.M_CN1.State == 0)
				{
					if (GeneralCommon.GF_DbConnect() == false)
					{
						return dt;
					}
				}
				conn = new OleDbConnection(GeneralCommon.M_CN1.ConnectionString);
				OleDbCommand cmd = new OleDbCommand(sQuery, conn);
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				da.Fill(dt);
				if (bAddNullRow)
				{
					DataRow dr = dt.NewRow();
					dt.Rows.InsertAt(dr, 0);
				}
				return dt;
				
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) ("Query Error : " + ex.Message), "", "");
				if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
				{
					GeneralCommon.M_CN1.Close();
					conn.Close();
					conn = null;
				}
				return dt;
			}
			finally
			{
				if (conn.State != 0)
				{
					conn.Close();
					conn = null;
				}
				
				if (GeneralCommon.M_CN1.State != 0)
				{
					GeneralCommon.M_CN1.Close();
				}
			}
		}
		
	}
	
	
	public class CdQuery : Query
	{
		
		
		string sManaNo = "";
		string sJoin = "";
		
		
		public CdQuery(string manaNo, string Joins)
		{
			sManaNo = manaNo;
			sJoin = Joins;
		}
		
		public override string sQuery
		{
			get
			{
				queryString = "Select cd_name ,cd  from ZP_CD where cd_mana_no=\'" + sManaNo.Trim().ToUpper() + "\' AND APLY_STD=\'1\'" + (sJoin.Trim() == "" ? "" : " AND " + sJoin.Trim()) + " ORDER BY CD";
				return queryString;
			}
			set
			{
				queryString = value;
			}
		}
		
	}
	
	
	public class ProcQuery : Query
	{
		
		public string sProcName = "";
		public string sParams = "";
		public ArrayList cParameters = new ArrayList();
		
		public ProcQuery(string procName, System.Collections.ICollection parameters)
		{
			sProcName = (string) ((procName.Contains(".")) ? procName : "pkg_dataBind." + procName);
			cParameters.AddRange(parameters);
			foreach (string s in cParameters)
			{
				sParams += "\'" + s + "\',";
			}
			sParams = sParams.TrimEnd(",".ToCharArray());
		}
		
		public override string sQuery
		{
			get
			{
				queryString = "{call " + sProcName + "(" + sParams + ")}";
				return queryString;
			}
			set
			{
				queryString = value;
			}
		}
	}
	
}
