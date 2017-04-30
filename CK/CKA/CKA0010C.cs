using System.Windows.Forms;
using FarPoint.Win.Spread;
using System;
using Microsoft.VisualBasic;
using CommonClass;

namespace CK
{
	public partial class CKA0010C
	{
        public CKA0010C()
		{
			InitializeComponent();
		}
		
		
		
		Collection Mc1 = new Collection();
		Collection Sc1 = new Collection();
       

		
		#region 界面初始化
		protected override void p_SubFormInit()
		{
            int iheadrow;
            int imcseq;
            int iscseq;
            imcseq = 1;
            
            if (DesignMode == true)
            {
            }

			p_McIni(Mc1, false);
            p_SetMc("用户ID", txt_EmpId1, "PIR", "", "", "", "", imcseq);
            p_SetMc("用户姓名", txt_EmpId2, "PIR", "", "", "", "", imcseq);
            p_SetMc(cmb_dept1, "pr", "Z0002", "", "", 1, "");
			
			p_ScIni(ss1, Sc1, 14, true, true);
			iheadrow = 0;			
			iscseq = 1;
			//0-11
            p_SetSc("用户ID", "E", "22", "PIN", "", "", "", iscseq, iheadrow);//0
			p_SetSc("用户姓名", "E", "22", "IN", "", "", "", iscseq, iheadrow);//1
            p_SetSc("部门", "ON", "3", "IN", "Z0002", "", "", iscseq, iheadrow);//2
			p_SetSc("作业区", "ON", "3", "IA", "B2001", "", "", iscseq, iheadrow);//3
			p_SetSc("办公电话", "E", "20", "I", "", "", "", iscseq, iheadrow);//4
			p_SetSc("移动电话", "E", "20", "I", "", "", "", iscseq, iheadrow);//5
			p_SetSc("宅电", "E", "20", "I", "", "", "", iscseq, iheadrow);//6
			p_SetSc("E_MAIL", "E", "50", "I", "", "", "", iscseq, iheadrow);//7
			//p_SetSc("密码", "P", "10", "IN", "", "", "", iscseq, iheadrow);//8
            p_SetSc("密码", "P", "10", "IA", "", "", "", iscseq, iheadrow);//8
            p_SetSc("是否管理者", "C", "1", "I", "", "", "", iscseq, iheadrow);//9;
            p_SetSc("PDA用户", "C", "1", "I", "", "", "", iscseq, iheadrow);//10;

            p_SetSc("密码重置", "C", "1", "I", "", "", "", iscseq, iheadrow);//11;

			p_SetSc("录入日期", "D", "8", "RL", "", "", "", iscseq, iheadrow);//12
			p_SetSc("录入时间", "T", "6", "RL", "", "", "", iscseq, iheadrow);//13
			p_SetSc("录入人员", "E", "7", "IL", "", "", "", iscseq, iheadrow);//14

            //iheadrow = 0;
            //p_spanSpread("用户信息", 0, 1, iscseq, iheadrow, -1);
            //p_spanSpread("部门信息", 2, 3, iscseq, iheadrow, -1);
            //p_spanSpread("电话信息", 4, 6, iscseq, iheadrow, -1);
            //p_spanSpread("E_MAIL", 7, 7, iscseq, iheadrow, 2);
            //p_spanSpread("密码", 8, 8, iscseq, iheadrow, 2);
            //p_spanSpread("是否管理者", 9, 9, iscseq, iheadrow, 2);
            //p_spanSpread("录入日期及时间", 10, 12, iscseq, iheadrow, 1);

            
		}
		
		public void Form_Load(object sender, System.EventArgs e)
		{
            //sSvrPgmPkgName = "PKG_WZA0010C";          
			Form_Define();
           // sAuthority = "1111";
		}

      
		
		#endregion
	
	}
}
