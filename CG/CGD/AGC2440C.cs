using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CG
{
    public partial class AGC2440C : CommonClass.FORMBASE
    {
        public AGC2440C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("日期", dtp_DATE_FR, "P", "", "", "", "", imcseq); //0
            p_SetMc("日期", dtp_DATE_TO, "P", "", "", "", "", imcseq); //1
            p_SetMc("时间", dtp_TIME_FR, "P", "8", "", "", "", imcseq); //2
            p_SetMc("时间", dtp_TIME_TO, "P", "8", "", "", "", imcseq); //3
            p_SetMc("", txt_HEAT, "P", "", "", "", "", imcseq); //4
            p_SetMc("工厂", txt_PLT, "PN", "", "", "", "", imcseq); //5
            p_SetMc("钢板号", txt_PLATE_NO, "P", "", "", "", "", imcseq); //6
            p_SetMc("标准号", txt_STDSPEC, "P", "", "", "", "", imcseq); //7
            p_SetMc("轧批号", txt_OUT_SHEET_NO, "P", "", "", "", "", imcseq); //8
            p_SetMc("厚度", txt_THK_FR, "P", "", "", "", "", imcseq); //9
            p_SetMc("厚度", txt_THK_TO, "P", "", "", "", "", imcseq); //10
            p_SetMc("热处理工厂", txt_HTM_PLT, "P", "", "", "", "", imcseq); //11
            p_SetMc("产线", txt_LINE, "P", "", "", "", "", imcseq); //12

            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("取样号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //0
            p_SetSc("轧制批号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("钢板号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("分段号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("进程状态", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //4
            p_SetSc("工厂", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("标准号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("标准/客户", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("规格", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //8
            p_SetSc("吨位", "E", "", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("上限", "N", "4,2", "L", "", "", "", iscseq, iheadrow, "R"); //10
            p_SetSc("下限", "N", "4,2", "L", "", "", "", iscseq, iheadrow, "R"); //11
            p_SetSc("取样方式", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //12
            p_SetSc("取样吨位", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //13
            p_SetSc("订单号", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("拉伸", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("追加拉伸", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("高温拉伸", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("追加高温拉伸", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("冷弯", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //19
            p_SetSc("追加冷弯", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //20
            p_SetSc("冲击", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //21
            p_SetSc("追加冲击", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //22
            p_SetSc("时效冲击", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //23
            p_SetSc("追加时效冲击", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //24
            p_SetSc("落锤", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("金相(夹杂、硬度、成分、ON)", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("硬度", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("追加硬度", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //28
            p_SetSc("成份", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //29
            p_SetSc("做普", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //30
            p_SetSc("Z向", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //31
            p_SetSc("订单备注", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //32
            p_SetSc("订单特殊要求", "E", "", "L", "", "", "", iscseq, iheadrow, "L"); //33
            iheadrow = 0;
            p_spanSpread("厚度公差", 11, 12, iscseq, iheadrow, 1);
            p_spanSpread("委托项目", 15, 31, iscseq, iheadrow, 1);
        }

        private void AGC2440C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "AGC2440NC";
            Form_Define();
            if (opt_HTM_PLT0.Checked)
            {
                SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            }
            txt_HTM_PLT.Text = "1";
            opt_HTM_PLT1.Checked = true;
            txt_HEAT.Text = "0";
            txt_DH_FL.Checked = false;
        }
        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);
        }

        public override bool Form_Cls()
        {
             base.Form_Cls();
             txt_HTM_PLT.Text = "1";
             opt_HTM_PLT1.Checked = true;
             txt_HEAT.Text = "0";
             txt_DH_FL.Checked = false;
             return true;
        }

        private void opt_HTM_PLT1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_HTM_PLT1.Checked)
            {
                txt_HTM_PLT.Text = "1";
            }
            else
            {
                txt_HTM_PLT.Text = "0";

            }
        }

        private void txt_DH_FL_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_DH_FL.Checked)
            {
                txt_HEAT.Text = "1";
            }
            else
            {
                txt_HEAT.Text = "0";
            }
        } 
    }
}
