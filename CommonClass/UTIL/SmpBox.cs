using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace CommonClass
{
	public class SmpBox
	{
		
		
		private string boxNO = "";
		private string boxType = "";
		private string getSql = "";
		public string trustdeedNo = "";
		
		
		public SmpBox()
		{
		}
		
		public SmpBox(string BoxType)
		{
			this.trustdeedNo = trustdeedNo;
			this.boxType = BoxType;
			getSql = "select smp_box_no from (  select  *  from TF_SMP_BOX order by dbms_random.value ) where(rownum = 1 And box_type =\'" + BoxType + "\' And box_place = \'1\' And usable=\'1\')";
		}
		
		
		public string GetRandNO(string TrustdeedNo)
		{
			boxNO = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, getSql);
			if (boxNO == "")
			{
				GeneralCommon.Gp_MsgBoxDisplay("该种类试样盒为空,请添加试样盒!", "", "");
				throw (new Exception());
				return "";
			}
			//更新样盒所处位置
			SetBoxPlace("2", boxNO, boxType);
			
			//更新样盒所装试样的委托单号
			string sqlstr = "UPDATE TF_SMP_BOX SET trustdeed_no =\'" + TrustdeedNo + "\'  WHERE  smp_box_no=\'" + boxNO + "\' And box_type =\'" + boxType + "\'";
			BaseManu.ExecSql(sqlstr);
			return boxNO;
		}
		
		public static void SetBoxPlace(string bPlace, string bNo, string bType)
		{
			string sqlstr = "UPDATE TF_SMP_BOX SET box_place = \'" + bPlace + "\' WHERE  smp_box_no=\'" + bNo + "\' And box_type =\'" + bType + "\'";
			BaseManu.ExecSql(sqlstr);
		}
	}
	
}
