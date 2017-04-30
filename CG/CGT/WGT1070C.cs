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
    public partial class WGT1070C : CommonClass.FORMBASE
    {
        public WGT1070C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        public const int SS1_ORD_CNT        =   23;//订单数量
        public const int SS1_URGNT_FL       =   24;//紧急订单
        public const int SS1_IMP_CONT       =   25;//重点订单
        //public const int SS1_PILECOOL       =   24;//堆冷标识
        public const int SS1_DEL_TO_DATE    =   22;//客户交货期
        public const int sHtm_Meth          =   12;//热处理指示

        int SS1_COLUM_COUNT;

        string sCurDate = System.DateTime.Now.ToShortDateString().Replace("-","").Substring(0,6); 

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;

            p_SetMc("板坯号", txt_Slab_No, "P", "", "", "", "", 1);//0
            p_SetMc("切割时间开始", sdt_wrk_date_fr, "P", "", "", "", "", 1);//1
            p_SetMc("切割时间结束", sdt_wrk_date_to, "P", "", "", "", "", 1);//2
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", 1);//3
            
            
            p_SetMc("标准号", txt_Std_No, "P", "", "", "", "", 1);//4  
            
            p_SetMc("切割指示", ACT_CUT_PLT, "P", "", "", "", "", 1);//5
            p_SetMc("母板厚开始", text_Mp_Thick, "P", "", "", "", "", 1);//6  
            p_SetMc("母板厚结束", text_Mp_Thick_To, "P", "", "", "", "", 1);//7
            p_SetMc("母板宽开始", txt_Mp_Wide, "P", "", "", "", "", 1);//8
            p_SetMc("母板宽结束", txt_Mp_Wide_To, "P", "", "", "", "", 1);//9
            p_SetMc("母板长开始", txt_Mp_Long, "P", "", "", "", "", 1);//10
            p_SetMc("母板长结束", txt_Mp_Long_To, "P", "", "", "", "", 1);//11
            p_SetMc("母板状态", cbo_Mp_Res, "P", "", "", "", "", 1);//12
            p_SetMc("母板状态", txt_Mill_NO, "", "", "", "", "", 1);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", 1);
            p_SetMc("切边", CBO_TRIM, "P", "", "", "", "", 1);

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("母板号", "E", "", "", "", "", "", 1, 1, "M");//0
            p_SetSc("订单号", "E", " ", "", "", "", "", 1, 1, "M");//1
            p_SetSc("订单序列", "E", " ", "", "", "", "", 1, 1, "M");//2
            p_SetSc("切边", "E", " ", "", "", "", "", 1, 1, "M");//28
            p_SetSc("订单规格", "E", " ", "", "", "", "", 1, 1, "M");//3
            p_SetSc("母板状态", "E", "", "", "", "", "", 1, 1, "M");//4
            p_SetSc("标准号", "E", " ", "", "", "", "", 1, 1, "R");//5
            p_SetSc("轧制时间", "DT", " ", "", "", "", "", 1, 1, "M");//6
            p_SetSc("抛送ERP时间", "DT", "", "", "", "", "", 1, 1, "M");//7
            p_SetSc("探伤", "E", " ", "", "", "", "", 1, 1, "M");//8
            p_SetSc("切割", "E", " ", "", "", "", "", 1, 1, "M");//9
            p_SetSc("抛丸", "E", " ", "", "", "", "", 1, 1, "M");//10
            p_SetSc("热处理方法1", "E", " ", "", "", "", "", 1, 1, "M");//11
            p_SetSc("热处理方法2", "E", " ", "", "", "", "", 1, 1, "M");//12
            p_SetSc("厚", "N", "6,2", "", "", "", "", 1, 1, "M");//13
            p_SetSc("宽", "N", "6,2", "", "", "", "", 1, 1, "M");//14
            p_SetSc("长", "N", "8,1", "", "", "", "", 1, 1, "M");//15
            p_SetSc("重量", "N", "15,3", "", "", "", "", 1, 1, "M");//16
            p_SetSc("剪切块数", "E", " ", "", "", "", "", 1, 1, "M");//17 20140113
            p_SetSc("成材率", "E", " ", "", "", "", "", 1, 1, "M");//18 20140113
            p_SetSc("垛位", "E", " ", "", "", "", "", 1, 1, "M");//19
            p_SetSc("开始时间", "D", " ", "", "", "", "", 1, 1, "M");//20
            p_SetSc("结束时间", "D", " ", "", "", "", "", 1, 1, "M");//21
            p_SetSc("订单数量", "E", " ", "", "", "", "", 1, 1, "M");//22
            p_SetSc("紧急订单", "E", " ", "", "", "", "", 1, 1, "M");//23
            p_SetSc("重点订单", "E", " ", "", "", "", "", 1, 1, "M");//24
            p_SetSc("是否轧废", "E", " ", "", "", "", "", 1, 1, "M");//25
            p_SetSc("余材代码", "E", " ", "", "", "", "", 1, 1, "M");//26
            p_SetSc("配置形状", "E", " ", "", "", "", "", 1, 1, "M");//27
            p_spanSpread("作业指示", 9, 13, 1, 0, 1);
            p_spanSpread("母板实绩", 14, 19, 1, 0, 1);
            p_spanSpread("客户交货期", 21, 22, 1, 0, 1);

        //    SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true); //隐藏用户列     
        }

        private void WGT1070C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

        public override void Form_Ref()
        {
            base.Form_Ref();
            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }
            SS1_COLUM_COUNT = ss1_Sheet1.ColumnCount -1;
            string aaa = ss1_Sheet1.Cells[0, 0].Text;
            for (int i = 0; i < ss1_Sheet1.RowCount; i++)
            {
                ss1_Sheet1.Rows.Get(i).BackColor = Color.White;
                //一坯多订单
                if (Convert.ToInt32(ss1_Sheet1.Cells[i,SS1_ORD_CNT].Text) > 1)
                {
                   // SpreadCommon.Gp_Sp_BlockColor(ss1,0,SS1_COLUM_COUNT,i,i,ss1_Sheet1.Cells[i,SS1_ORD_CNT].ForeColor,Color.Fuchsia);
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.Fuchsia;
                }
                //当月以前交货订单
                if (Convert.ToInt32(ss1_Sheet1.Cells[i, SS1_DEL_TO_DATE].Text.Replace("-", "").Substring(0, 6)) < Convert.ToInt32(sCurDate))
                 {
                     ss1_Sheet1.Rows.Get(i).ForeColor = Color.Red;
                 }
                //紧急订单
                if (ss1_Sheet1.Cells[i,SS1_URGNT_FL].Text == "Y")
                {

                    ss1_Sheet1.Rows.Get(i).BackColor = Color.Green;
                }
                //热处理指示
                if (ss1_Sheet1.Cells[i,sHtm_Meth].Text!="")
                {
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.Blue;
                }
                //重点订单
                if (ss1_Sheet1.Cells[i,SS1_IMP_CONT].Text == "Y")
                {
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.Orange;
                }

                //if (ss1_Sheet1.Cells[i,SS1_PILECOOL])
            }
        }



        public override bool Form_Cls()
        {
            return base.Form_Cls();
        }

        public override void Form_Pro()
        {
            base.Form_Pro();
        }

    }
}
