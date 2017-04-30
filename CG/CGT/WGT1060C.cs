using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;

namespace CG
{
    public partial class WGT1060C : CommonClass.FORMBASE
    {
        public WGT1060C()
        {
            InitializeComponent();
        }

        public const int iSs1_Emp_Cd = 18;  //SS1钢板号

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;

            p_SetMc("开始时间", dtp_DATE_FR, "P", "", "", "", "", 1);//1
            p_SetMc("结束时间", dtp_DATE_TO, "P", "", "", "", "", 1);//2
            p_SetMc("钢板号", txt_PLATE_NO, "P", "", "", "", "", 1);//3
            p_SetMc("标准号", txt_STDSPEC, "P", "", "", "", "", 1);//3
            p_SetMc("轧批号", txt_OUT_SHEET_NO, "P", "", "", "", "", 1);//3
            p_SetMc("最小厚度", txt_THK_FR, "P", "", "", "", "", 1);//3
            p_SetMc("最大厚度", txt_THK_TO, "P", "", "", "", "", 1);//3


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("取样号", "E", "", "L", "", "", "", 1, 1, "M");//0            
            p_SetSc("轧制批号", "E", "", "L", "", "", "", 1, 1, "M");//1
            p_SetSc("钢板号", "E", "", "I", "", "", "", 1, 1, "M");//2 
            p_SetSc("分段号", "E", " ", "L", "", "", "", 1, 1, "M");//3
            p_SetSc("进程状态", "E", " ", "L", "", "", "", 1, 1, "M");//4
            p_SetSc("工厂", "E", "", "L", "", "", "", 1, 1, "M");//5
            p_SetSc("标准号", "E", " ", "L", "", "", "", 1, 1, "M");//6
            p_SetSc("标准/客户", "E", " ", "L", "", "", "", 1, 1, "M");//7
            p_SetSc("规格", "E", " ", "L", "", "", "", 1, 1, "M");//8
            p_SetSc("吨位", "E", " ", "L", "", "", "", 1, 1, "M");//9
            p_SetSc("上限", "E", " ", "L", "", "", "", 1, 1, "M");//10
            p_SetSc("下限", "E", " ", "L", "", "", "", 1, 1, "M");//11
            p_SetSc("取样方式", "E", " ", "L", "", "", "", 1, 1, "M");//12
            p_SetSc("取样吨位", "E", " ", "L", "", "", "", 1, 1, "M");//13
            p_SetSc("订单号", "E", " ", "L", "", "", "", 1, 1, "M");//14
            p_SetSc("拉伸", "E", " ", "L", "", "", "", 1, 1, "M");//15
            p_SetSc("追加拉伸", "E", " ", "L", "", "", "", 1, 1, "M");//16
            p_SetSc("高温拉伸", "E", " ", "L", "", "", "", 1, 1, "M");//17
            p_SetSc("追加高温拉伸", "E", " ", "IL", "", "", "", 1, 1, "M");//18
            p_SetSc("冷弯", "E", " ", "L", "", "", "", 1, 1, "M");//19
            p_SetSc("追加冷弯", "E", " ", "L", "", "", "", 1, 1, "M");//20
            p_SetSc("冲击", "E", " ", "L", "", "", "", 1, 1, "M");//21
            p_SetSc("追加冲击", "E", " ", "L", "", "", "", 1, 1, "M");//22
            p_SetSc("时效冲击", "E", " ", "L", "", "", "", 1, 1, "M");//23
            p_SetSc("追加时效冲击", "E", " ", "L", "", "", "", 1, 1, "M");//24
            p_SetSc("落锤", "E", " ", "L", "", "", "", 1, 1, "M");//25
            p_SetSc("金相（夹杂，硬度，成分，ON）", "E", " ", "L", "", "", "", 1, 1, "M");//26
            p_SetSc("硬度", "E", " ", "L", "", "", "", 1, 1, "M");//27
            p_SetSc("追加硬度", "E", " ", "L", "", "", "", 1, 1, "M");//28
            p_SetSc("成分", "E", " ", "L", "", "", "", 1, 1, "M");//29
            p_SetSc("做普", "E", " ", "L", "", "", "", 1, 1, "M");//30
            p_SetSc("Z向", "E", " ", "L", "", "", "", 1, 1, "M");//31
            p_SetSc("追加Z向", "E", " ", "L", "", "", "", 1, 1, "M");//32
            p_SetSc("断口", "E", " ", "L", "", "", "", 1, 1, "M");//33
            p_SetSc("订单备注", "E", " ", "L", "", "", "", 1, 1, "M");//34

            p_spanSpread("厚度公差", 10, 11, 1, 0, 1);
            p_spanSpread("委托项目", 15, 33, 1, 0, 1);

           // SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true); //隐藏用户列     
        }

        private void WGT1060C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

        //private void ss1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        //{
        //    if (e.ColumnHeader) return;
        //    if (ss1_Sheet1.RowCount == 0)
        //    {
        //        return;
        //    }
        //    ss1_Sheet1.Cells[e.Row, iSs1_Emp_Cd].Text = GeneralCommon.sUserID;
        //    return;
        //}

     

        


       



    }
}
