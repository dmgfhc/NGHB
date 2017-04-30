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
//-- System Name       中板轧钢作业
//-- Sub_System Name   板坯库管理
//-- Program Name      库详细情况查询
//-- Program ID        CGA2061C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.03.01
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER         DATE         EDITOR       DESCRIPTION
//   1.00     2017.03.01       韩超        库详细情况查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGA2061C : CommonClass.FORMBASE
    {
        public CGA2061C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();

        //const int SPD_PLAN_PROD_WGT = 33,
                 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始时间",sdt_in_plt_date, "PN", "", "", "", "", imcseq);
            p_SetMc("结束时间",sdt_out_plt_date, "PN", "", "", "", "", imcseq);
            p_SetMc(txt_act_stlgrd, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk, "P", "", "", "", imcseq, "");
            p_SetMc(txt_thk_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid, "P", "", "", "", imcseq, "");
            p_SetMc(txt_wid_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len, "P", "", "", "", imcseq, "");
            p_SetMc(txt_len_to, "P", "", "", "", imcseq, "");
            p_SetMc(txt_plt, "P", "", "", "", imcseq, "");
            p_SetMc(txt_plt_name, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cur_inv_code, "P", "", "", "", imcseq, "");
            p_SetMc(txt_cur_inv, "P", "", "", "", imcseq, "");
            p_SetMc(txt_InPltCo, "P", "", "", "", imcseq, "");
            p_SetMc(txt_heatno, "P", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//0 
            p_SetSc("外来板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("母板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("炼钢厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("板坯理重", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("来库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10

            p_SetSc("板坯浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("入库日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("炼钢计划供轧钢厂", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("车辆", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14

            p_SetSc("供货商代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("供货商名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("是否二切", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("卸车人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//18

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 5, 7, iscseq, iheadrow, 1);


            p_ScIni(ss2, Sc2, 0, true, true);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("外来板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("母板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("工厂", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("来库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9

            p_SetSc("板坯浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("入库日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("去库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("离开日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("供货商代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("供货商名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("车辆号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            
            iheadrow = 0;
            p_spanSpread("板坯尺寸", 5, 7, iscseq, iheadrow, 1);


            p_ScIni(ss3, Sc3, 0, true, true);
            iheadrow = 1;
            iscseq = 3;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("外来板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("母板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("工厂", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("使用原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("板坯浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("入库日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("切割日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("使用日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("供货商代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("供货商名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 5, 7, iscseq, iheadrow, 1);



            p_ScIni(ss4, Sc4, 0, true, true);
            iheadrow = 1;
            iscseq = 4;

            p_SetSc("板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("外来板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("母板坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("工厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("现在状态", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("切断", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("板坯浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("入库日期", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13

            p_SetSc("供货商代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("供货商名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("订单材/余材代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("定尺区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("缓冷时间", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//21
           

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("订单规格", 17, 19, iscseq, iheadrow, 1);

            p_ScIni(ss5, Sc5, 0, true, true);
            iheadrow = 1;
            iscseq = 5;

            p_SetSc("物料号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//0 
            p_SetSc("移拨码单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("起始库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("目标库", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("装车人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("装车时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("车号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//6
            p_SetSc("在途时间（小时）", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("厚", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("宽", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("长", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("板坯重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("钢种名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("是否接坯", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("订单材/余材代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("切割指示", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("生产工厂", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("生产日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("后续工厂", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("成品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//22

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 8, 10, iscseq, iheadrow, 1);

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 16, true);
            //SpreadCommon.Gp_Sp_ColHidden(ss1, 17, true);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2061NC";
            Form_Define();
       //     base.sAuthority = "1111";
        }
        #endregion

        #region 重写查询
        public override void Form_Ref()
        {

            if (0 == tabControl1.SelectedIndex)
            {

                p_Ref(1, 1, true, true);
                
            }
            else if (1 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 2, true, true);
                
            }
            else if (2 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 3, true, true);
                
            }
            else if (3 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 4, true, true);
                
            }
            else if (4 == tabControl1.SelectedIndex)
            {
                p_Ref(1, 5, true, true);
                
            }
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            //txt_cur_inv.Text = "ZB";
            //txt_thk.Text = "SL";
            return true;

        }
        #endregion


    }
}