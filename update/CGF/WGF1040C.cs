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
    public partial class WGF1040C : CommonClass.FORMBASE
    {
        public WGF1040C()
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
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧辊号",CBO_ROLL_ID, "PNIR", "", "", "","", imcseq);
            p_SetMc("工厂",TXT_PLT, "NIR", "", "", "","", imcseq);
            p_SetMc(CBO_SHIFT, "NI", "", "", "", imcseq, "");
            p_SetMc("班别",CBO_GROUP, "NI", "", "", "","", imcseq);
            p_SetMc(TXT_UPD_EMP, "NI", "", "", "", imcseq, "");

            p_SetMc("配辊号",TXT_PIAR_ROLL_ID, "NRI", "", "", "","", imcseq);
            p_SetMc(TXT_ROLL_UNIT, "RI", "", "", "", imcseq, "");
            p_SetMc("辊身直径",NMB_ROLL_SHLD_DIA, "NR", "", "", "","", imcseq);
            p_SetMc(NMB_ROLL_NECK_DIA, "RI", "", "", "", imcseq, "");
            p_SetMc(TXT_MILL_STA_TIME, "NRI", "", "", "", imcseq, "");
            p_SetMc(TXT_MILL_END_TIME, "NRI", "", "", "", imcseq, "");
            p_SetMc("卸辊时间",TXT_MILL_OUT_TIME, "NRI", "", "", "","", imcseq);
            p_SetMc(TXT_ROLL_MATERIAL, "R", "", "", "", imcseq, "");
            p_SetMc(TXT_SWIVE, "R", "", "", "", imcseq, "");
            p_SetMc(TXT_MAX_CHG_VALUE, "RI", "", "", "", imcseq, "");
            p_SetMc(CBO_PLATE_FACE, "RI", "", "", "", imcseq, "");
            p_SetMc(TXT_ROLL_MAX, "RI", "", "", "", imcseq, "");
            p_SetMc(TXT_ROLL_MIN, "RI", "", "", "", imcseq, "");
            p_SetMc(CBO_PLATE_THING, "RI", "", "", "", imcseq, "");
            p_SetMc("轧制重量",NMB_ROLL_MILL_WGT, "NRI", "", "", "","", imcseq);
            p_SetMc(NMB_TOT_MILL_WGT, "R", "", "", "", imcseq, "");
            p_SetMc("轧制板坯数",NMB_ROLL_MILL_CNT, "NRI", "", "", "","", imcseq);
            p_SetMc(NMB_TOT_MILL_CNT, "R", "", "", "", imcseq, "");
            p_SetMc("轧制公里数",NMB_ROLL_MILL_LEN, "NRI", "", "", "","", imcseq);
            p_SetMc(NMB_TOT_MILL_LEN, "R", "", "", "", imcseq, "");
            p_SetMc(NMB_MILL_SPD_RATE, "RI", "", "", "", imcseq, "");
            p_SetMc(NMB_ROLL_CROWN, "R", "", "", "", imcseq, "");
            p_SetMc(NMB_ROLL_USE_TM, "R", "", "", "", imcseq, "");
            p_SetMc(TXT_PIAR_SHIFT, "R", "", "", "", imcseq, "");
            p_SetMc(TXT_PIAR_GROUP, "R", "", "", "", imcseq, "");
            p_SetMc(TXT_PIAR_EMP, "R", "", "", "", imcseq, "");


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-21
            p_SetSc("轧辊号", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("轧辊单位", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("开轧使用时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("终轧使用时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//3
            p_SetSc("使用持续时间", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("卸辊时间", "DT", "14", "L", "", "", "", iscseq, iheadrow,"M");//5
            p_SetSc("辊身直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow,"R");//6
            p_SetSc("辊颈直径", "N", "7,3", "L", "", "", "", iscseq, iheadrow,"R");//7
            p_SetSc("轧制重量", "N", "7", "L", "", "", "", iscseq, iheadrow,"R");//8
            p_SetSc("轧制板坯数", "N", "6", "L", "", "", "", iscseq, iheadrow,"R");//9
            p_SetSc("轧制公里数", "N", "4", "L", "", "", "", iscseq, iheadrow,"R");//10
            p_SetSc("轧辊凸度", "N", "7,3", "L", "", "", "", iscseq, iheadrow,"R");//11
            p_SetSc("配辊号", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//12
            p_SetSc("SEQNO", "N", "3", "L", "", "", "", iscseq, iheadrow,"R");//13
            p_SetSc("SWIVE", "N", "4,2", "L", "", "", "", iscseq, iheadrow,"R");//14
            p_SetSc("道次最大调整量", "N", "5", "L", "", "", "", iscseq, iheadrow,"R");//15
            p_SetSc("板形情况", "E", "5", "L", "", "", "", iscseq, iheadrow,"L");//16
            p_SetSc("轧后辊温(℃)最大值", "N", "4,1", "L", "", "", "", iscseq, iheadrow,"R");//17
            p_SetSc("轧后辊温(℃)最小值", "N", "4,1", "L", "", "", "", iscseq, iheadrow,"R");//18
            p_SetSc("辊况", "E", "5", "L", "", "", "", iscseq, iheadrow,"L");//19
            p_SetSc("工作侧轴承座号", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//20
            p_SetSc("驱动侧轴承座号", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");//21

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGB2040C";
            Form_Define();
    //        base.sAuthority = "1111";

            //轧辊号栏显示轧辊号
            string sQuery = "";
            sQuery = "SELECT ROLL_NO FROM GP_ROLLW WHERE ROLL_STATUS <> 'DL' ORDER BY ROLL_NO";
            GeneralCommon.Gf_ComboAdd(CBO_ROLL_ID, sQuery);

            TXT_UPD_EMP.Text = GeneralCommon.sUserID;
            TXT_PLT.Text = "C2";
            CBO_SHIFT.Text = GeneralCommon.sShift;

        }
        #endregion

        private void CBO_ROLL_ID_TextChanged(object sender, EventArgs e)
        {
            if (CBO_ROLL_ID.Text.Length > 7)
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧辊号长度不能超过7位，请确认轧辊号 ！！！", "", "");
            }
        }
        public override void Form_Ref()
        {
            if (CBO_SHIFT.Text == "1" && CBO_SHIFT.Text == "2" && CBO_SHIFT.Text == "3")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入有效的班次", "", "");
                return;
            } 
            p_Ref(1, 1, true, true);

            TXT_UPD_EMP.Text = GeneralCommon.sUserID;      
           
        }
        public override void Form_Pro()
        {
            
            TXT_UPD_EMP.Text = GeneralCommon.sUserID;

            string ss = TXT_MILL_STA_TIME.Text;
            ss = ss.Replace(":", "");
            ss = ss.Replace("-", "");
            ss = ss.Replace(" ", "").Trim();

            //if (GeneralCommon.Gf_DateTime_Chk(ss) == false)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("请正确输入开始使用时间！", "", "");
            //    return;
            //}

            string ss1 = TXT_MILL_END_TIME.Text;
            ss1 = ss1.Replace(":", "");
            ss1 = ss1.Replace("-", "");
            ss1 = ss1.Replace(" ", "").Trim();

            if ( TXT_MILL_STA_TIME.Text != "" && TXT_MILL_END_TIME.Text != "")
            {
                //if (GeneralCommon.Gf_DateTime_Chk(ss1) == false)
                //{
                //    GeneralCommon.Gp_MsgBoxDisplay("请正确输入结束使用时间 ！", "", "");
                //    return;
                //}
                //检查结束使用时间的正确性
                if (double.Parse(ss) - double.Parse(ss1) > 0)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("结束使用时间应大于开始使用时间，请正确输入时间信息 ！", "", "");
                    return;
                }
            }

            string ss2 = TXT_MILL_OUT_TIME.Text;
            ss2 = ss2.Replace(":", "");
            ss2 = ss2.Replace("-", "");
            ss2 = ss2.Replace(" ", "").Trim();

            if (TXT_MILL_OUT_TIME.Text != "" && TXT_MILL_END_TIME.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请先输入结束使用时间 ！", "", "");
                return;
            }
            else if ( ss2 != "" && ss1 != "")
                {
                    //if (GeneralCommon.Gf_DateTime_Chk(ss2) == false)
                    //{
                    //    GeneralCommon.Gp_MsgBoxDisplay("请正确输入结束使用时间 ！", "", "");
                    //    return;
                    //}

                    if (double.Parse(ss1) - double.Parse(ss2) > 0)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("卸辊时间应大于结束使用时间，请正确输入时间信息！", "", "");
                        return;
                    }
                }


            //检查轧后辊温最大、最小值
            if (TXT_ROLL_MAX.NumValue > 999 || TXT_ROLL_MIN.NumValue > 999)
            {
                GeneralCommon.Gp_MsgBoxDisplay("轧后辊温最大值和最小值不得大于999 ！", "", "");
                return;
            }

            p_pro(1, 1, true, true);
            //p_Ref(1, 1, true, true);

        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                TXT_UPD_EMP.Text = GeneralCommon.sUserID;
                CBO_SHIFT.Text = GeneralCommon.sShift;
                TXT_PLT.Text = "C2";
                CBO_PLATE_FACE.Text = "";
            }
            return true;
        }

    }
}
