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

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            中板生产管制系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            轧钢生产线进程现状界面                                
///-- 程序ID            CKH2010C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2018.01.22                                                
///-- 处理描述          轧钢生产线进程现状界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2018.01.22        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKH2010C : CommonClass.FORMBASE
    {
        public CKH2010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();
        Collection Mc5 = new Collection();
        Collection Mc6 = new Collection(); 
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();
        Collection Sc6 = new Collection();
        Collection Sc7 = new Collection();
        Collection Sc8 = new Collection();

        


        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("", txt_INF_CNT1, "R", "", "", "", "", imcseq);//0
            p_SetMc("", TXT_SLAB_NO1, "R", "", "", "", "", imcseq);//1
            p_SetMc("", txt_SLAB_SIZE1, "R", "", "", "", "", imcseq);//2
            p_SetMc("", TXT_SLAB_NO2, "R", "", "", "", "", imcseq);//3
            p_SetMc("", txt_SLAB_SIZE2, "R", "", "", "", "", imcseq);//4
            p_SetMc("", TXT_SLAB_NO3, "R", "", "", "", "", imcseq);//5
            p_SetMc("", txt_SLAB_SIZE3, "R", "", "", "", "", imcseq);//6
            p_SetMc("", txt_MPLATE_NO, "R", "", "", "", "", imcseq);//7
            p_SetMc("", txt_MPLATE_LEN, "R", "", "", "", "", imcseq);//8
            p_SetMc("", txt_PLATE_NO, "R", "", "", "", "", imcseq);//9
            p_SetMc("", txt_UST_DEC, "R", "", "", "", "", imcseq);//10
            p_SetMc("", txt_ONC_CNT1, "R", "", "", "", "", imcseq);//11
            p_SetMc("", txt_ONC_CNT2, "R", "", "", "", "", imcseq);//12
            p_SetMc("", txt_MPLATE_NO_RST, "R", "", "", "", "", imcseq);//13
            p_SetMc("", txt_MPLATE_LEN_RST, "R", "", "", "", "", imcseq);//14
            p_SetMc("", txt_MPLATE_NO_L, "R", "", "", "", "", imcseq);//15
            p_SetMc("", txt_MPLATE_LEN_L, "R", "", "", "", "", imcseq);//16
            p_SetMc("", txt_MPLATE_NO_R, "R", "", "", "", "", imcseq);//17
            p_SetMc("", txt_MPLATE_LEN_R, "R", "", "", "", "", imcseq);//18
            p_SetMc("", txt_PLATE_NO_DS1, "R", "", "", "", "", imcseq);//19
            p_SetMc("", txt_PLATE_LEN_DS1, "R", "", "", "", "", imcseq);//20
            p_SetMc("", txt_SURF_GRD_DS1, "R", "", "", "", "", imcseq);//21
            p_SetMc("", txt_PLATE_NO_DS2, "R", "", "", "", "", imcseq);//22
            p_SetMc("", txt_PLATE_LEN_DS2, "R", "", "", "", "", imcseq);//23
            p_SetMc("", txt_SURF_GRD_DS2, "R", "", "", "", "", imcseq);//24
            p_SetMc("", txt_slabcnt1, "R", "", "", "", "", imcseq);//25
            p_SetMc("", txt_slabcnt2, "R", "", "", "", "", imcseq);//26

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("", CBO_RHF_LINE, "P", "", "", "", "", imcseq);//0
            p_SetMc("", CBO_CB_LINE, "P", "", "", "", "", imcseq);//1

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("布料方式", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//2

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 0;
            iscseq = 2;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("布料方式", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//2

            p_ScIni(ss3, Sc3, 0, false, false);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("布料方式", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//2

            p_ScIni(ss4, Sc4, 0, false, false);
            iheadrow = 0;
            iscseq = 4;
            p_SetSc("板坯号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("布料方式", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//2

            p_ScIni(ss5, Sc5, 0, false, false);
            iheadrow = 0;
            iscseq = 5;
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("上冷床时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3

            p_ScIni(ss6, Sc6, 0, false, false);
            iheadrow = 0;
            iscseq = 6;
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("上冷床时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3

            p_ScIni(ss7, Sc7, 0, false, false);
            iheadrow = 0;
            iscseq = 7;
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("上冷床时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3

            p_ScIni(ss8, Sc8, 0, false, false);
            iheadrow = 0;
            iscseq = 8;
            p_SetSc("母板号", "E", "12", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("厚 * 宽 * 长", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("上冷床时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//3
        }

        private void CKH2010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CKH2010NC";
            Form_Define();
            Form_Ref();
        }

        // 重写查询
        public override void Form_Ref()
        {
            if (p_Ref(1, 0, false, false))
            {
                p_Ref(0, 1, false, false);
                p_Ref(0, 2, false, false);
                p_Ref(0, 3, false, false);
                p_Ref(0, 4, false, false);
                p_Ref(0, 5, false, false);
                p_Ref(0, 6, false, false);
                p_Ref(0, 7, false, false);
                p_Ref(0, 8, false, false);
            }
            


            txt_ONC_CNT1.Text = (ss5.ActiveSheet.RowCount + ss6.ActiveSheet.RowCount).ToString();
            txt_INF_CNT1.Text = (ss1.ActiveSheet.RowCount + ss2.ActiveSheet.RowCount + ss3.ActiveSheet.RowCount + ss4.ActiveSheet.RowCount).ToString();

        }


        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            Form_Ref();
        }

        private void Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (Option1.Checked)
            {
                Timer1.Enabled = true;
            }
        }

        private void Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (Option2.Checked)
            {
                Timer1.Enabled = false;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Form_Ref();
        }

    }
}
