using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
//using FarPoint.PluginCalendar;
//using InDate;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
//using FarPoint.CalcEngine;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
//using FarPoint.Excel;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
//using FarPoint.PluginCalendar.WinForms;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   轧辊管理
//-- Program Name      轧辊入库管理界面
//-- Program ID        CGF2010C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.07.24
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR       DESCRIPTION
//-- 1.00    2017.07.24       韩超        轧辊入库管理
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGF2010C : CommonClass.FORMBASE
    {
        public CGF2010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号",CBO_ROLL_NO, "PNIR", "", "", "","", imcseq);//0
            p_SetMc("工厂代码", CBO_PLT, "NIR", "", "", "", "", imcseq);//1
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq);//2
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq);//3
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq);//4
            p_SetMc("入库时间", UTP_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq);//5
            p_SetMc("轧辊标识号", TXT_ROLL_NO, "NIR", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_ROLL_MAKER, "IR", "", "", "", "", imcseq);//7
            p_SetMc("入库辊径", SDB_ROLL_DIA, "NIR", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_ROLL_DIA_Y, "RL", "", "", "", "", imcseq);//9
            p_SetMc("", SDB_ROLL_SHLD_DIA, "IR", "", "", "", "", imcseq);//10
            p_SetMc("", SDB_ROLL_NECK_DIA, "IR", "", "", "", "", imcseq);//11
            p_SetMc("轧辊重量", SDB_ROLL_WGT, "NIR", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_ROLL_IN_W_HARD, "IR", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_ROLL_W_DIA2, "IR", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_ROLL_IN_C_HARD, "IR", "", "", "", "", imcseq);//15
            p_SetMc("", SDB_ROLL_IN_D_HARD, "IR", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_ROLL_D_DIA2, "IR", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_ROLL_IN_AVE_HARD, "RL", "", "", "", "", imcseq);//18
            p_SetMc("", TXT_ROLL_MATERIAL, "IR", "", "", "", "", imcseq);//19
            p_SetMc("", TXT_MAKER_NO, "IR", "", "", "", "", imcseq);//20
            p_SetMc("", TXT_R_SHIFT, "RL", "", "", "", "", imcseq);//21
            p_SetMc("", TXT_R_GROUP, "RL", "", "", "", "", imcseq);//22
            p_SetMc("", TXT_R_IN_EMP, "RL", "", "", "", "", imcseq);//23
            p_SetMc("", TXT_LOC, "IR", "", "", "", "", imcseq);//24
            p_SetMc("", txt_sec_treat_mtd, "IR", "", "", "", "", imcseq);//25
            p_SetMc("", txt_ISSUETALLYNO, "IR", "", "", "", "", imcseq);//26
            p_SetMc("料号", txt_MTRLNO, "NIR", "", "", "", "", imcseq);//27
            p_SetMc("", txt_ROLL_PRICE, "IR", "", "", "", "", imcseq);//28
            p_SetMc("限位辊径", txt_PLAN_DIA, "NIR", "", "", "", "", imcseq);//29

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq);//0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq);//1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq);//2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq);//3
            p_SetMc("入库时间", UTP_B_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq);//4
            p_SetMc("", UTP_B_ROLL_USE_TIME, "IR", "", "", "", "", imcseq);//5
            p_SetMc("轴承座标识号", TXT_CHOCK_NO, "NIR", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_B_ROLL_MAKER, "IR", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_B_IN_DIA, "IR", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_B_OUT_DIA, "IR", "", "", "", "", imcseq);//9
            p_SetMc("", TXT_B_ROLL_MATERIAL, "IR", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_B_SHIFT, "RL", "", "", "", "", imcseq);//11
            p_SetMc("", TXT_B_GROUP, "RL", "", "", "", "", imcseq);//12
            p_SetMc("", TXT_B_IN_EMP, "RL", "", "", "", "", imcseq);//13

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq);//0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq);//1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq);//2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq);//3
            p_SetMc("入库时间", UTP_C_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq);//4
            p_SetMc("轴承标识号", TXT_BEAR_NO, "NIR", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_C_ROLL_MAKER, "IR", "", "", "", "", imcseq);//6
            p_SetMc("", SDB_C_IN_DIA, "IR", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_C_OUT_DIA, "IR", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_C_ROLL_WID, "IR", "", "", "", "", imcseq);//9
            p_SetMc("", TXT_C_SHIFT, "RL", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_C_GROUP, "RL", "", "", "", "", imcseq);//11
            p_SetMc("", TXT_C_IN_EMP, "RL", "", "", "", "", imcseq);//12

            p_McIni(Mc4, true);
            imcseq = 4;
            p_SetMc("轧辊号", CBO_ROLL_NO, "PNIR", "", "", "", "", imcseq);//0
            p_SetMc("班次", CBO_SHIFT, "NI", "", "", "", "", imcseq);//1
            p_SetMc("", CBO_GROUP, "I", "", "", "", "", imcseq);//2
            p_SetMc("作业人员", TXT_ROLL_IN_EMP, "NI", "", "", "", "", imcseq);//3
            p_SetMc("入库时间", UTP_P_ROLL_IN_TIME, "NIR", "", "", "", "", imcseq);//4
            p_SetMc("护板标识号", TXT_PLANK_NO, "NIR", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_P_ROLL_MAKER, "IR", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_P_SHIFT, "RL", "", "", "", "", imcseq);//7
            p_SetMc("", TXT_P_GROUP, "RL", "", "", "", "", imcseq);//8
            p_SetMc("", TXT_P_IN_EMP, "RL", "", "", "", "", imcseq);//9
          
        }


        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGF2010C";
            Form_Define();
     //       base.sAuthority = "1111";

            CBO_SHIFT.Text = "1";

            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;

            //轧辊号栏显示轧辊号
            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <> 'DL' ORDER BY ROLL_NO";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_NO, sQuery);
            TXT_PLT.Text = "C2";
            
            
        }
        #endregion

        public override void Form_Ref()
        {
            //检查班次输入的有效性
            if (CBO_SHIFT.Text != "1" && CBO_SHIFT.Text != "2" && CBO_SHIFT.Text != "3")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入有效的班次", "", "");
                return;
            }
            if (CBO_ROLL_NO.Text.Substring(0, 1) != "R")
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧辊号首位应为R,请正确输入轧辊号！", "", "");
                return;
            }
            p_Ref(1, 0, true, true);
            CBO_ROLL_NO.Enabled = true;

        }

        //重写清空，作业人员显示，轧辊号显示
        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                //string sQuery = "";
                //sQuery = "SELECT ROLL_NO FROM GP_ROLL WHERE ROLL_STATUS <>'DL' ORDER BY ROLL_NO";
                //GeneralCommon.Gf_ComboAdd(CMB_ROLL_NO, sQuery);
                TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;
                CBO_ROLL_NO.Text = "";
                CBO_GROUP.Text = "";
            }
            return true;
        }

        public override void Form_Pro()
        {

            string ss = UTP_ROLL_IN_TIME.Text;
            ss = ss.Replace(":", "");
            ss = ss.Replace("-", "");
            ss = ss.Replace(" ", "").Trim();

            //检查轧辊录入规范
            if (CBO_ROLL_NO.Text.Substring(0, 1) != "R")
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧辊号首位应为R,请正确输入轧辊号！", "", "");
                return;
            }

            //检查轧辊入库时间
            if (GeneralCommon.Gf_DateTime_Chk(ss) == false)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请正确输入轧辊入库时间 ！", "", "");
                return;
            }

            //领料单号和单价必输入
            //if (txt_ISSUETALLYNO.Text == "" && txt_ROLL_PRICE.Text == "")
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("领料单号和单价不能同时为空！", "", "");
            //    return;
            //}


            //轧辊重量必须输入
            if (NMB_ROLL_WGT.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧辊重量不能为空！", "", "");
                return;
            }
            

            p_pro(1, 0, true, true);
           
        }

        public override void Form_Del()
        {
            //重写删除，轧辊不能删除
            p_del(1,1,true);
            string c1 = "";
            string cbo = CBO_ROLL_NO.Text;
            c1 = cbo.Substring(0,1);
            if (c1 == "R")
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧辊不能删除！", "", "系统提示信息");
            }
        }

    }
}
