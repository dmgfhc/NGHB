using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;


namespace CommonClass
{
	public class DataDicCommon
	{
		
		
		#region "使用DataDic窗体"
		
    ////     ''' <summary>
    ////''' 显示DataDic窗体，并把选择结果返回到非Spread的控件
    ////''' </summary>
    ////''' <param name="rControl">保存返回值的控件集合</param>
    ////''' <param name="fControl">每一个控件对应的字段名称</param>
    ////''' <param name="sQuery">查询语句</param>
    ////''' <param name="sProcName">存储过程名称</param>
    ////''' <param name="sFilter">筛选条件(存储过程时不需要)</param>
    ////''' <param name="iActiveColumn">DataDic窗体Where条件Spread默认活动列</param>
    ////''' <returns></returns>
    ////''' <remarks></remarks>
		public static void Gf_Master_DD(Collection rControl, Collection fControl, string sQuery, string sProcName, int iParaCount, string sFilter, int iActiveColumn)
			{
			DataDic dd = new DataDic();
            //dd.ShowDialog();
            //return;
			dd.IsSpreadCaller = false;
			dd.rControl = rControl;
			dd.fControl = fControl;
			dd.QuerySQL = sQuery.ToUpper();
			dd.ProcName = sProcName;
			dd.ParamCount = iParaCount;
			dd.sFilter = sFilter;
			dd.ActiveColumnIndex = iActiveColumn;
            try
            {
               // dd.Show();
                dd.ShowDialog();//20121231
            }
            catch { }
			
		}
		
    ////''' <summary>
    ////''' 显示DataDic窗体，并把选择结果返回到spreadObj控件
    ////''' </summary>
    ////''' <param name="spreadObj"></param>
    ////''' <param name="rControl">保存返回值的控件集合</param>
    ////''' <param name="fControl">每一个控件对应的字段名称</param>
    ////''' <param name="sQuery">查询语句</param>
    ////''' <param name="sProcName">存储过程名称</param>
    ////''' <param name="sFilter">筛选条件(存储过程时不需要)</param>
    ////''' <param name="iActiveColumn">DataDic窗体Where条件Spread默认活动列</param>
    ////''' <returns></returns>
    ////''' <remarks></remarks>
		public static void Gf_Spread_DD(Control spreadObj, Collection rControl, Collection fControl, string sQuery, string sProcName, int iParaCount, string sFilter, int iActiveColumn)
			{
			DataDic dd = new DataDic();
			dd.IsSpreadCaller = true;
			dd.SpreadObj = spreadObj;
			dd.rControl = rControl;
			dd.fControl = fControl;
			dd.QuerySQL = sQuery.ToUpper();
			dd.ProcName = sProcName;
			dd.ParamCount = iParaCount;
			dd.sFilter = sFilter;
			dd.ActiveColumnIndex = iActiveColumn;
            //dd.ShowDialog();
            //dd.Show();
            dd.ShowDialog();//20121231
		}

        ///1023
        public static void Gf_Spread_DD(Control spreadObj, Collection rControl, Collection fControl, string sQuery, string sProcName, int iParaCount, string sFilter, int iActiveColumn, string sAuthority, Collection Sc)
        {
            DataDic dd = new DataDic();
            dd.IsSpreadCaller = true;
            dd.SpreadObj = spreadObj;
            dd.rControl = rControl;
            dd.fControl = fControl;
            dd.QuerySQL = sQuery.ToUpper();
            dd.ProcName = sProcName;
            dd.ParamCount = iParaCount;
            dd.sFilter = sFilter;
            dd.ActiveColumnIndex = iActiveColumn;
            dd.sAuthority = sAuthority;
            dd.Sc = Sc;
            //dd.ShowDialog();
            //dd.Show();
            dd.ShowDialog();//20121231
        }
        ///1023
		#endregion

		//未用
		public static string Gf_CDLengthFind(ADODB.Connection Conn, string cd_mana_no)
		{
			
			string sQuery;
			
			sQuery = "SELECT CD_LEN  FROM ZP_CD_MASTER WHERE APLY_ITEM = \'" + cd_mana_no + "\' ";
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
        //结束

		/// <summary>
		/// 根据传入的参数，得到sql语句，调用Gf_CodeFind（）
        /// 方法，得到CD_SHORT_NAME或CD_NAME或CD_SHORT_ENG或CD_FULL_ENG的值。
		/// </summary>
		/// <param name="Conn"></param>
		/// <param name="Cd_Mana_No"></param>
		/// <param name="Code"></param>
		/// <param name="nameType"></param>
		/// <returns></returns>
		public static string Gf_CommNameFind(ADODB.Connection Conn, string Cd_Mana_No, string Code, string nameType)
			{
			string sQuery;
			
			switch (nameType)
			{
				
				case "1": //Short Name
					sQuery = "SELECT CD_SHORT_NAME FROM ZP_CD WHERE CD_MANA_NO = \'" + Cd_Mana_No + "\' AND CD = \'" + Code + "\' ";
					break;
				case "2": //Full Name
					sQuery = "SELECT CD_NAME       FROM ZP_CD WHERE CD_MANA_NO = \'" + Cd_Mana_No + "\' AND CD = \'" + Code + "\' ";
					break;
				case "3": //Short Eng Name
					sQuery = "SELECT CD_SHORT_ENG  FROM ZP_CD WHERE CD_MANA_NO = \'" + Cd_Mana_No + "\' AND CD = \'" + Code + "\' ";
					break;
				case "4": //Full Eng Name
					sQuery = "SELECT CD_FULL_ENG   FROM ZP_CD WHERE CD_MANA_NO = \'" + Cd_Mana_No + "\' AND CD = \'" + Code + "\' ";
					break;
				default: //Full Name
					sQuery = "SELECT CD_NAME       FROM ZP_CD WHERE CD_MANA_NO = \'" + Cd_Mana_No + "\' AND CD = \'" + Code + "\' ";
					break;
					
			}
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
		
        /// <summary>
        /// 根据传入的参数，得到sql语句，调用Gf_CodeFind（）方法，得到EMP_NAME的值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
		public static string Gf_EmpNameFind(ADODB.Connection Conn, string Code)
		{
			
			string sQuery;
			
			sQuery = "SELECT EMP_NAME FROM ZP_EMPLOYEE WHERE EMP_ID = \'" + Code + "\' ";
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
		
        /// <summary>
        /// 根据传入的参数，得到sql语句，调用Gf_CodeFind（）方法，得到PGM_NAME的值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
		public static string Gf_PgmNameFind(ADODB.Connection Conn, string Code)
		{
			
			string sQuery;


            sQuery = "SELECT PGMNAME FROM ZP_PGMID WHERE PGMID = \'" + Code + "\' ";
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
		
        /// <summary>
        /// 根据传入的参数，得到sql语句，调用Gf_CodeFind（）方法，得到CUST_NM的值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        /// 未用
		public static string Gf_CustNameFind(ADODB.Connection Conn, string Code)
		{
			
			string sQuery;
			
			
			sQuery = "SELECT CUST_NM FROM TB_OC030 WHERE CUST_CD = \'" + Code + "\' ";
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
        //结束
		
		~DataDicCommon()
		{
            //base.Finalize();
		}
		
        /// <summary>
        /// 根据传入的参数，得到sql语句，调用Gf_CodeFind（）方法，得到APLY_ITEM_NAME的值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Apply_Item"></param>
        /// <returns></returns>
        /// 未用
		public static string Gf_ApplyNameFind(ADODB.Connection Conn, string Apply_Item)
		{
			
			string sQuery;
			
			
			sQuery = "SELECT APLY_ITEM_NAME  FROM TZ_APLY_ITEM WHERE APLY_ITEM = \'" + Apply_Item + "\' ";
			
			return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
		}
        //结束
		
        /// <summary>
        /// 得到不带where条件的sql语句。
        /// </summary>
        /// <returns></returns>
		public static string Gf_CommonCodeSQL()
		{
			string returnValue;
			
			returnValue = "  SELECT CD 代码, CD_NAME 代码名称,CD_SHORT_NAME 代码简称,   ";
            returnValue += "        CD_SHORT_ENG 代码英文简称,  CD_FULL_ENG 代码英文名称 ";
			returnValue += "   FROM ZP_CD ";
			
			return returnValue;
		}
		
		public static void Gf_CommonCode_DD_SP(Control oSpread, int code_col, int name_col, string cd_mana_no, string sFilter)
			{
			
			Collection rControl = new Collection();
			rControl.Add(code_col, null, null, null);
			
			
			
			Collection fControl = new Collection();
			fControl.Add("CD", null, null, null);
			if (name_col > -1)
			{
				rControl.Add(name_col, null, null, null);
				fControl.Add("CD_NAME", null, null, null);
			}
			
			
			string sJoin = " CD_MANA_NO = \'" + cd_mana_no + "\' ";
			
			if ((sFilter != null)&& sFilter.Trim().Length > 0)
			{
				sJoin += (string) (" AND " + sFilter);
			}
			DataDicCommon.Gf_Spread_DD(oSpread, rControl, fControl, DataDicCommon.Gf_CommonCodeSQL(), "", 0, sJoin, code_col);
			
		}


        /////////1023
        public static void Gf_CommonCode_DD_SP(Control oSpread, int code_col, int name_col, string cd_mana_no, string sFilter, string sAuthority, Collection Sc)
        {

            Collection rControl = new Collection();
            rControl.Add(code_col, null, null, null);



            Collection fControl = new Collection();
            fControl.Add("CD", null, null, null);
            if (name_col > -1)
            {
                rControl.Add(name_col, null, null, null);
                fControl.Add("CD_NAME", null, null, null);
            }


            string sJoin = " CD_MANA_NO = \'" + cd_mana_no + "\' ";

            if ((sFilter != null) && sFilter.Trim().Length > 0)
            {
                sJoin += (string)(" AND " + sFilter);
            }
            DataDicCommon.Gf_Spread_DD(oSpread, rControl, fControl, DataDicCommon.Gf_CommonCodeSQL(), "", 0, sJoin, code_col, sAuthority, Sc);

        }
        //////////1023
    //     '---------------------------------------------------------------------------------------
    //'   1.ID           :  Gf_EtcCommon_DD_SP
    //'   2.Input  Value :  ospread,rc,fc,sql,sfilter
    //'   3.Return Value : 
    //'   4.Create Date  :  2008.12 modify by ashen
    //'   5.Modify Date  :
    //'   6.Comment      :  显示数据字典窗体，rc为spread列集合，fc为字段名集合
    //'---------------------------------------------------------------------------------------
		
		public static void Gf_EtcCommon_DD_SP(Control oSpread, Collection rc, Collection fc, string sQuery, string sFilter)
		{
			
			string col = rc[1].ToString();
			
			DataDicCommon.Gf_Spread_DD(oSpread, rc, fc, sQuery, "", 0, sFilter, int.Parse(col));
			
		}

        //1023
        public static void Gf_EtcCommon_DD_SP(Control oSpread, Collection rc, Collection fc, string sQuery, string sFilter, string sAuthority, Collection Sc)
        {

            string col = rc[1].ToString();

            DataDicCommon.Gf_Spread_DD(oSpread, rc, fc, sQuery, "", 0, sFilter, int.Parse(col), sAuthority, Sc);

        }
        //1023

		public static void Gf_EtcCommon_DD_SP(Control oSpread, int code_col, int name_col, string code_field, string name_field, string sQuery, string sFilter)
			{
			
			Collection rControl = new Collection();
			rControl.Add(code_col, null, null, null);
			if (name_col > -1)
			{
				rControl.Add(name_col, null, null, null);
			}
			
			Collection fControl = new Collection();
			fControl.Add(code_field, null, null, null);
			fControl.Add(name_field, null, null, null);
			
			DataDicCommon.Gf_Spread_DD(oSpread, rControl, fControl, sQuery, "", 0, sFilter, 1);
			
		}
	}
	
	
	
	
}
