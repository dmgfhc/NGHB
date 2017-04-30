using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;


namespace CommonClass
{
	public class BaseManu
	{
		
		public string tableName = "";
		public string item = "";
		
		private bool Locked = false;
		private int manuNO = 0;
		private string getSql = "";
		private string getFlagSql = "";
		public BaseManu()
		{
			
		}
		
		public BaseManu(string Item)
		{
			this.tableName = "TX_MANU_NO";
			this.item = Item;
			getSql = "SELECT SEQ FROM " + tableName + " WHERE ITEM=\'" + Item + "\'";
			getFlagSql = "SELECT FLAG FROM " + tableName + " WHERE ITEM=\'" + Item + "\'";
		}
		
		public BaseManu(string TableName, string Item)
		{
			this.tableName = TableName;
			this.item = Item;
			getSql = "SELECT SEQ FROM " + TableName + " WHERE ITEM=\'" + Item + "\'";
			getFlagSql = "SELECT FLAG FROM " + TableName + " WHERE ITEM=\'" + Item + "\'";
		}
		public int sManuNo
		{
			get
			{
				try
				{
					manuNO = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, getSql));
				}
				catch (Exception)
				{
					
				}
				return manuNO;
			}
			set
			{
				manuNO = value;
			}
		}
		
		public int GetManu()
		{
			if (IsLocked())
			{
				GeneralCommon.Gp_MsgBoxDisplay("当前自编号正在使用中,请稍后再试!", "", "");
				return -1;
			}
			else
			{
				this.Lock();
				try
				{
					manuNO = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, getSql));
				}
				catch (Exception)
				{
					
				}
				return manuNO;
			}
			
		}
		public void SetManu(int ManuNO)
		{
			this.manuNO = ManuNO;
			string sqlstr = "UPDATE " + tableName + " SET SEQ=\'" + this.manuNO.ToString() + " \' WHERE  ITEM=\'" + item + "\'";
			if (ExecSql(sqlstr))
			{
				this.UnLock();
			}
		}
		private bool IsLocked()
		{
			//Locked = CBool(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, getFlagSql))
			return false;
//			if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, getFlagSql) == "1")
//			{
//				Locked = true;
//				}
//				else
//				{
//					Locked = false;
//					}
//					return Locked;
				}
				private void Lock()
				{
					string sqlstr = "UPDATE " + tableName + " SET FLAG=\'1\' WHERE  ITEM=\'" + item + "\'";
					ExecSql(sqlstr);
					
				}
				
				private void UnLock()
				{
					string sqlstr = "UPDATE " + tableName + " SET FLAG=\'0\' WHERE  ITEM=\'" + item + "\'";
					ExecSql(sqlstr);
				}
				
				public static bool ExecSql(string sql)
				{
					try
					{
						ADODB.Connection Conn = GeneralCommon.M_CN1;
						//Db Connection Check
						if (Conn.State == 0)
						{
							if (GeneralCommon.GF_DbConnect() == false)
							{
								return false;
							}
						}
						
						object null_object = null;
						Conn.Execute(sql, out null_object, -1);
						return true;
					}
					catch (Exception ex)
					{
						GeneralCommon.Gp_MsgBoxDisplay((string) ("ExecSql Error : " + ex.Message), "", "");
						return false;
					}
					
					
				}
				
				
				
			}
			
		}
