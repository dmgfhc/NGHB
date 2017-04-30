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
//-- Program Name      轧辊装配实绩管理界面
//-- Program ID        WGF1030C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.12.13
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER       DATE          EDITOR         DESCRIPTION
//-- 1.00    2012.12.13       李超        轧辊装配实绩管理
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------


namespace CG
{
    public partial class WGF1030C : CommonClass.FORMBASE
    {
        public WGF1030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        int flag = 0;
        int porFlag = 0;

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号",CMB_ROLL_ID, "PNIR", "", "","","", imcseq);                                          // 轧辊号
            p_SetMc(CMB_ROLL_TOP_BOT, "NIR", "", "", "", imcseq, "");                                             // 轧辊位置
            p_SetMc(TXT_PLT, "NRI", "", "", "", imcseq, "");                                                      // 工厂
            p_SetMc(CMB_SHIFT, "NRI", "", "", "", imcseq, "");                                                    // 班次
            p_SetMc("班别",CMB_GROUP, "NRI", "", "", "","", imcseq);                                              // 班别
            p_SetMc(TXT_ROLL_IN_EMP, "NRI", "", "", "", imcseq, "");                                              // 作业人员
            p_SetMc("装辊时间",TXT_MILL_STA_TIME, "NRI", "", "", "","", imcseq);                                  // 装辊时间
            p_SetMc("辊身直径",NMB_ROLL_SHLD_DIA, "NRI", "", "", "","", imcseq);                                  // 辊身直径
            p_SetMc(NMB_ROLL_NECK_DIA, "RI", "", "", "", imcseq, "");                                             // 辊颈直径
            p_SetMc("轧辊单位",TXT_ROLL_UNIT, "RI", "", "", "", "", imcseq);                                      // 轧辊单位
            p_SetMc(TXT_ROLL_MATERIAL, "RL", "", "", "", imcseq, "");                                             // 轧辊材质
            p_SetMc(TXT_ROLL_CURVE, "RL", "", "", "", imcseq, "");                                               // 辊型曲线
            p_SetMc(NMB_D_DIA, "RL", "", "", "", imcseq, "");                                                    // 头部辊径
            p_SetMc(NMB_W_DIA, "RL", "", "", "", imcseq, "");                                                    // 尾部辊径

            p_SetMc(CMB_WK_CHOCK, "RI", "", "", "", imcseq, "");                                                  // 工作侧轴承座号
            p_SetMc(CMB_WK_BEARING1, "R", "", "", "", imcseq, "");                                               // 轴承1
            p_SetMc(CMB_WK_BEARING2, "R", "", "", "", imcseq, "");                                               // 轴承2
            p_SetMc(CMB_WK_BEARING3, "R", "", "", "", imcseq, "");                                               // 轴承3
            p_SetMc(CMB_WK_BEARING4, "R", "", "", "", imcseq, "");                                               // 轴承4
            p_SetMc(CMB_DS_CHOCK, "RI", "", "", "", imcseq, "");                                                  // 驱动侧轴承座号
            p_SetMc(CMB_DS_BEARING1, "R", "", "", "", imcseq, "");                                               // 轴承1
            p_SetMc(CMB_DS_BEARING2, "R", "", "", "", imcseq, "");                                               // 轴承2
            p_SetMc(CMB_DS_BEARING3, "R", "", "", "", imcseq, "");                                               // 轴承3
            p_SetMc(CMB_DS_BEARING4, "R", "", "", "", imcseq, "");                                               // 轴承4

            p_SetMc("配辊号",CMB_PIAR_ROLL_ID, "NRI", "", "", "","", imcseq);                                     // 配棍号
            p_SetMc("辊身直径",NMB_ROLL_SHLD_DIA1, "NRI", "", "", "", "",imcseq);                                 // 辊身直径
            p_SetMc(NMB_ROLL_NECK_DIA1, "RI", "", "", "", imcseq, "");                                            // 辊颈直径
            p_SetMc(NMB_MILL_SPD_RATE, "RI", "", "", "", imcseq, "");                                             // 调速比
            p_SetMc(TXT_ROLL_MATERIAL1, "RL", "", "", "", imcseq, "");                                            // 轧辊材质
            p_SetMc(TXT_ROLL_CURVE1, "RL", "", "", "", imcseq, "");                                              // 辊型曲线
            p_SetMc(NMB_D_DIA1, "RL", "", "", "", imcseq, "");                                                    // 头部辊径
            p_SetMc(NMB_W_DIA1, "RL", "", "", "", imcseq, "");                                                    // 尾部辊径

            p_SetMc(CMB_PIAR_WK_CHOCK, "RI", "", "", "", imcseq, "");                                             // 工作侧轴承座号
            p_SetMc(CMB_PIAR_WK_BEARING1, "R", "", "", "", imcseq, "");                                          // 轴承1
            p_SetMc(CMB_PIAR_WK_BEARING2, "R", "", "", "", imcseq, "");                                          // 轴承2
            p_SetMc(CMB_PIAR_WK_BEARING3, "R", "", "", "", imcseq, "");                                          // 轴承3
            p_SetMc(CMB_PIAR_WK_BEARING4, "R", "", "", "", imcseq, "");                                          // 轴承4
            p_SetMc(CMB_PIAR_DS_CHOCK, "RI", "", "", "", imcseq, "");                                             // 驱动侧轴承座号
            p_SetMc(CMB_PIAR_DS_BEARING1, "R", "", "", "", imcseq, "");                                          // 轴承1
            p_SetMc(CMB_PIAR_DS_BEARING2, "R", "", "", "", imcseq, "");                                          // 轴承2
            p_SetMc(CMB_PIAR_DS_BEARING3, "R", "", "", "", imcseq, "");                                          // 轴承3
            p_SetMc(CMB_PIAR_DS_BEARING4, "R", "", "", "", imcseq, "");                                          // 轴承4

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("轧辊号",CMB_ROLL_ID, "PR", "", "", "","", imcseq);                                           // 轧辊号
            p_SetMc(NMB_ROLL_SHLD_DIA, "R", "", "", "", imcseq, "");                                              // 辊身直径                              
            p_SetMc(TXT_ROLL_MATERIAL, "R", "", "", "", imcseq, "");                                              // 轧辊材质
            p_SetMc(TXT_ROLL_CURVE, "R", "", "", "", imcseq, "");                                                 // 辊型曲线
            p_SetMc(NMB_D_DIA, "RL", "", "", "", imcseq, "");                                                    // 头部辊径
            p_SetMc(NMB_W_DIA, "RL", "", "", "", imcseq, "");                                                    // 尾部辊径
            p_SetMc(CMB_WK_CHOCK, "R", "", "", "", imcseq, "");                                                   // 工作侧轴承座号
            p_SetMc(CMB_DS_CHOCK, "R", "", "", "", imcseq, "");                                                   // 驱动侧轴承座号 

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("配辊号",CMB_PIAR_ROLL_ID, "PR", "", "", "", "",imcseq);                                      // 配棍号
            p_SetMc(NMB_ROLL_SHLD_DIA1, "R", "", "", "", imcseq, "");                                             // 辊身直径
            p_SetMc(TXT_ROLL_MATERIAL1, "R", "", "", "", imcseq, "");                                             // 轧辊材质
            p_SetMc(TXT_ROLL_CURVE1, "R", "", "", "", imcseq, "");                                                // 辊型曲线
            p_SetMc(NMB_D_DIA1, "RL", "", "", "", imcseq, "");                                                    // 头部辊径
            p_SetMc(NMB_W_DIA1, "RL", "", "", "", imcseq, "");                                                    // 尾部辊径
            p_SetMc(CMB_PIAR_WK_CHOCK, "R", "", "", "", imcseq, "");                                              // 工作侧轴承座号
            p_SetMc(CMB_PIAR_DS_CHOCK, "R", "", "", "", imcseq, "");                                              // 驱动侧轴承座号

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "WGF1030C";
            Form_Define();
            string sql = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <>'DL'  ORDER BY ROLL_NO ";               // 加载轧辊状态不等于报废的轧辊信息
            GeneralCommon.Gf_ComboAdd(this.CMB_ROLL_ID, sql);

            string sql1 = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <>'DL' ORDER BY ROLL_NO ";               // 加载配棍状态不等于报废的配辊信息        
            GeneralCommon.Gf_ComboAdd(this.CMB_PIAR_ROLL_ID, sql1);

            string sql2 = "SELECT CHOCK_ID FROM GP_CHOCKW WHERE STATUS<>'DL' OR STATUS IS NULL ORDER BY CHOCK_ID "; // 加载轧辊工作侧轴承座号信息。      
            GeneralCommon.Gf_ComboAdd(this.CMB_WK_CHOCK, sql2);

            string sql3 = "SELECT CHOCK_ID FROM GP_CHOCKW WHERE STATUS<>'DL' OR STATUS IS NULL ORDER BY CHOCK_ID "; // 加载轧辊驱动侧轴承座号信息。      
            GeneralCommon.Gf_ComboAdd(this.CMB_DS_CHOCK, sql3);

            string sql4 = "SELECT CHOCK_ID FROM GP_CHOCKW WHERE STATUS<>'DL' OR STATUS IS NULL ORDER BY CHOCK_ID "; // 加载配辊工作侧轴承座号信息。      
            GeneralCommon.Gf_ComboAdd(this.CMB_PIAR_WK_CHOCK, sql4);

            string sql5 = "SELECT CHOCK_ID FROM GP_CHOCKW WHERE STATUS<>'DL' OR STATUS IS NULL ORDER BY CHOCK_ID "; // 加载配辊驱动侧轴承座号信息。      
            GeneralCommon.Gf_ComboAdd(this.CMB_PIAR_DS_CHOCK, sql5);

            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;                                                         // 加载作业人员  
            TXT_PLT.Text = "C2";                                                                            // 加载工厂  
            CMB_SHIFT.Text = GeneralCommon.sShift;                                                                // 加载班次  
        //    base.sAuthority = "1111";
        }
        
        public override void Form_Ref()
        {
            flag = 1;                                                                                              // 区分查询
            p_Ref(1, 0, true, false);                                                                              // 调用第一个查询  
        }

        public override void Form_Pro()
        {
            if (TXT_MILL_STA_TIME.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("装辊时间不能为填空", "W", "提示");
                return; 
            }

            if (CMB_ROLL_ID.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入轧辊号", "W", "提示");
                return;
            }

            if (CMB_ROLL_TOP_BOT.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请正确输入轧辊位置", "W", "提示");
                return;
            }


            //if (CMB_ROLL_ID.Text.Substring(2, 1) == "1")                                                           // 判断轧辊号第2位等于1的时候
            //{
            //    if (CMB_ROLL_TOP_BOT.Text.Substring(0, 1) != "O" && CMB_ROLL_TOP_BOT.Text.Substring(0, 1) != "D")  // 轧辊位置不等于"O" 和"D" 的时候
            //    {

            //        GeneralCommon.Gp_MsgBoxDisplay("请正确输入轧辊位置 ", "W", "提示");                        
            //        return;

            //    }
            //}
            //else                                                                                                   // 否则轧辊号第2位不等于1的时候
            //{
            //    if (CMB_ROLL_TOP_BOT.Text.Substring(0, 1) != "T" && CMB_ROLL_TOP_BOT.Text.Substring(0, 1) != "B")  // 轧辊位置不等于"T" 和"B" 的时候
            //    {

            //        GeneralCommon.Gp_MsgBoxDisplay("请正确输入轧辊位置 ", "W", "提示");
            //        return;

            //    }
 
            //}
            porFlag = 1;   
            p_pro(1, 0, true, false);
        }

        
        public override bool Form_Cls()
        {
            flag = 0;
            porFlag = 0;
            CMB_ROLL_TOP_BOT.Text = "";
            base.Form_Cls();
            TXT_ROLL_IN_EMP.Text = GeneralCommon.sUserID;                                                          // 作业人员  
            TXT_PLT.Text = "C2";                                                                             // 工厂  
            CMB_SHIFT.Text = GeneralCommon.sShift;                                                                 // 班次  
            CMB_PIAR_ROLL_ID.Text = "";
            return true;
        }

        private void CMB_ROLL_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1) return;                                                                                 // 判断变量等于1的时候跳出，否则不等于1的时候调用第二个查询
            if (porFlag == 1) return;
            p_Ref(2, 0, true, false);
            CMB_ROLL_ID.Enabled = true;
        }

        private void CMB_PIAR_ROLL_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1) return;                                                                                 // 判断变量等于1的时候跳出，否则不等于1的时候调用第三个查询
            if (porFlag == 1) return;
            p_Ref(3, 0, true, false);                                                                  
            CMB_PIAR_ROLL_ID.Enabled = true;
        }

        #endregion

    }
}
