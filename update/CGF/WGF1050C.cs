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

namespace CG
{
    public partial class WGF1050C : CommonClass.FORMBASE
    {
        public WGF1050C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc(CMB_ROLL_ID, "PNIR", "", "", "", imcseq, "");                 // 轧辊号
            p_SetMc("工厂",TXT_PLT, "NIR", "", "", "","", imcseq);                // 工厂
            p_SetMc("班次",CMB_SHIFT, "NI", "", "", "", "",imcseq);               // 班次
            p_SetMc("班别",CMB_GROUP, "NI", "", "", "", "",imcseq);               // 班别
            p_SetMc(TXT_EMP_CD, "NI", "", "", "", imcseq, "");                    // 作业人员
            p_SetMc(TXT_UTP_ROLL_DISUSE_TIME, "IR", "", "", "", imcseq, "");      // 报废时间
            p_SetMc(NMB_D_DIA, "R", "", "", "", imcseq, "");                     // 辊径头部
            p_SetMc(NMB_W_DIA, "R", "", "", "", imcseq, "");                     // 辊径尾部
            p_SetMc(NMB_ROLL_DISUSE_DIA, "IR", "", "", "", imcseq, "");           // 报废辊身直径
            p_SetMc(NMB_ROLL_IN_AVE_HARD, "RL", "", "", "", imcseq, "");          // 平均硬度
            p_SetMc(TXT_ROLL_DISUSE_RES, "IR", "", "", "", imcseq, "");           // 报废原因
            p_SetMc(NMB_ROLL_USE_NUM, "IR", "", "", "", imcseq, "");              // 使用次数
            p_SetMc(NMB_TOT_MILL_WGT, "IR", "", "", "", imcseq, "");              // 轧制重量
            p_SetMc(NMB_TOT_MILL_LEN, "IR", "", "", "", imcseq, "");              // 轧制公里数
            p_SetMc(TXT_R_SHIFT, "RL", "", "", "", imcseq, "");                   // 班次
            p_SetMc(TXT_R_GROUP, "RL", "", "", "", imcseq, "");                   // 班别
            p_SetMc(TXT_R_IN_EMP, "RL", "", "", "", imcseq, "");                  // 作业人员


            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc(CMB_ROLL_ID, "PNRI", "", "", "", imcseq, "");                 // 轴承座号
            p_SetMc(CMB_SHIFT, "NI", "", "", "", imcseq, "");                     // 班次  
            p_SetMc(CMB_GROUP, "NI", "", "", "", imcseq, "");                     // 班别
            p_SetMc(TXT_EMP_CD, "NI", "", "", "", imcseq, "");                    // 作业人员
            p_SetMc(TXT_UTP_B_ROLL_DISUSE_TIME, "RI", "", "", "", imcseq, "");    // 报废时间
            p_SetMc(TXT_B_ROLL_DISUSE_RES, "RI", "", "", "", imcseq, "");         // 报废原因
            p_SetMc(TXT_B_SHIFT, "RL", "", "", "", imcseq, "");                   // 班次
            p_SetMc(TXT_B_GROUP, "RLL", "", "", "", imcseq, "");                  // 班别
            p_SetMc(TXT_B_IN_EMP, "RL", "", "", "", imcseq, "");                  // 作业人员

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc(CMB_ROLL_ID, "PNRI", "", "", "", imcseq, "");                 // 轴承号
            p_SetMc(CMB_SHIFT, "NI", "", "", "", imcseq, "");                     // 班次  
            p_SetMc(CMB_GROUP, "NI", "", "", "", imcseq, "");                     // 班别
            p_SetMc(TXT_EMP_CD, "NI", "", "", "", imcseq, "");                    // 作业人员
            p_SetMc(TXT_UTP_C_ROLL_DISUSE_TIME, "RI", "", "", "", imcseq, "");    // 报废时间
            p_SetMc(TXT_C_ROLL_DISUSE_RES, "RI", "", "", "", imcseq, "");         // 报废原因
            p_SetMc(TXT_C_SHIFT, "RL", "", "", "", imcseq, "");                   // 班次
            p_SetMc(TXT_C_GROUP, "RL", "", "", "", imcseq, "");                   // 班别
            p_SetMc(TXT_C_IN_EMP, "RL", "", "", "", imcseq, "");                  // 作业人员

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "WGF1050C";
            Form_Define();
            checkBox1.Checked = true;
            string sql = "SELECT ROLL_NO FROM GP_ROLLW  ORDER BY ROLL_NO ";
            GeneralCommon.Gf_ComboAdd(this.CMB_ROLL_ID, sql);                    
            TXT_EMP_CD.Text = GeneralCommon.sUserID;                              // 加载作业人员  
            TXT_PLT.Text = "C2";                                                  // 加载工厂  
            CMB_SHIFT.Text = GeneralCommon.sShift;                                // 加载班次  
            checkBox1.ForeColor = Color.Red;
        }
        #endregion


        public override void Form_Ref()
        {
            if (checkBox1.Checked)                                                 // 判断钩选中第一个复选框
            {           
                p_Ref(1, 0, true, false);                                          // 调用第一个查询
            }
            if (checkBox2.Checked)                                                 // 判断钩选中第二个复选框
            {
                p_Ref(2, 0, true, false);                                          // 调用第二个查询
            }
            if (checkBox3.Checked)                                                 // 判断钩选中第三个复选框
            {
                p_Ref(3, 0, true, false);                                          // 调用第三个查询
            }


            CMB_ROLL_ID.Enabled = true;


        }

        public override bool Form_Cls()
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.ForeColor = Color.Red;
            checkBox2.ForeColor = Color.Black;
            checkBox3.ForeColor = Color.Black;
            return base.Form_Cls();
        }

        public override void Form_Pro()
        {
            TXT_EMP_CD.Text = GeneralCommon.sUserID; 
            if (checkBox1.Checked)                                                 // 判断钩选中第一个复选框           
            {
                if (TXT_UTP_ROLL_DISUSE_TIME.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("报废时间不能为填空","W","提示");
                    return; 
                }
                p_pro(1, 0, true, false);                                          // 调用第一个保存
            }
            if (checkBox2.Checked)                                                 // 判断钩选中第二个复选框                                  
            {
                p_pro(2, 0, true, false);                                          // 调用第二个保存
            }
            if (checkBox3.Checked)                                                 // 判断钩选中第三个复选框                     
            {
                p_pro(3, 0, true, false);                                          // 调用第三个保存
            }

            
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.ForeColor = Color.Red;
            checkBox2.ForeColor = Color.Black;
            checkBox3.ForeColor = Color.Black;
            CMB_ROLL_ID.Text = "";
            label1.Text = "轧辊号";
            string sql = "SELECT ROLL_NO FROM GP_ROLLW ORDER BY ROLL_NO ";             // 查询没报废的轧辊号
            GeneralCommon.Gf_ComboAdd(this.CMB_ROLL_ID, sql);
            base.Form_Cls();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox2.ForeColor = Color.Red;
            checkBox1.ForeColor = Color.Black;
            checkBox3.ForeColor = Color.Black;

            CMB_ROLL_ID.Text = "";
            label1.Text = "轴承座号";
            string sql = "SELECT CHOCK_ID FROM GP_CHOCKW  ORDER BY CHOCK_ID  ";                          // 查询没报废的轴承座号 
            GeneralCommon.Gf_ComboAdd(this.CMB_ROLL_ID, sql);
            base.Form_Cls();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.ForeColor = Color.Red;
            checkBox1.ForeColor = Color.Black;
            checkBox2.ForeColor = Color.Black;
            CMB_ROLL_ID.Text = "";
            label1.Text = "轴承号";
            string sql = "SELECT BEARING_ID FROM GP_BEARINGW  ORDER BY BEARING_ID ";                    // 查询没报废的轴承号 
            GeneralCommon.Gf_ComboAdd(this.CMB_ROLL_ID, sql);
            base.Form_Cls();
        }
         
    

    }
}
