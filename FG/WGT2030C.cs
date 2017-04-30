using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;

namespace WG
{
    public partial class WGT2030C : CommonClass.FORMBASE
    {
        public WGT2030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_JIT_FLAG = 46 ; 
        const int SPD_CUR_TRIM_FL = 15;//是否切边
        const int SPD_CUR_TRIM_H_FL = 17;//是否切头
        const int SPD_CUR_TRIM_T_FL = 20;//是否切尾
        const int SPD_CUR_TRIM_SMP1_FL = 22;//是否取样一次
        const int SPD_CUR_TRIM_SMP2_FL = 24;//是否取样二次
        const int SPD_URGNT_FL = 43;//紧急订单
        const int SPD_GROUP_CD = 27;//班别
        const int SPD_SHIFT_CD = 26;//班次


        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;

            p_SetMc("作业日期开始", sdt_wrk_date_fr, "PN", "", "", "", "", 1);//0
            p_SetMc("作业日期结束", sdt_wrk_date_to, "PN", "", "", "", "", 1);//1
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", 1);//2
            p_SetMc("班别", cbo_group, "P", "", "", "", "", 1);//3
            p_SetMc("物料号", txt_mat_no, "P", "", "", "", "", 1);//4   
            p_SetMc("切割工厂", ACT_CUT_PLT, "P", "", "", "", "", 1);//5
            p_SetMc("生产工厂", ACT_PRODUCE_PLT, "P", "", "", "", "", 1);//6     

            p_ScIni(ss1, Sc1, 26, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("计划切割时间", "D", "", "L", "", "", "", 1, 1, "M");//0
            p_SetSc("实绩切割时间", "DT", "", "I", "", "", "", 1, 1, "M");//1
            p_SetSc("物料号", "E", "", "PI", "", "", "", 1, 1, "M");//2
            p_SetSc("顺序", "N", "6", "PI", "", "", "", 1, 1, "M");//3
            p_SetSc("切割工厂", "E", " ", "L", "", "", "", 1, 1, "M");//4
            p_SetSc("是否剖分", "E", " ", "AL", "", "", "", 1, 1, "M");//5
            

            p_SetSc("进程代码", "E", "", "L", "", "", "", 1, 1, "M");//6
            p_SetSc("轧制标准", "E", "", "L", "", "", "", 1, 1);//7
            p_SetSc("标准号", "E", "", "L", "", "", "", 1, 1);//8
            p_SetSc("厚度", "N", "6,2 ", "L", "", "", "", 1, 1);//9
            p_SetSc("宽度", "N", "8", "L", "", "", "", 1, 1);//10

            p_SetSc("长度", "N", "8", "L", "", "", "", 1, 1);//11
            p_SetSc("重量", "N", "6,3", "L", "", "", "", 1, 1);//12
            p_SetSc("表面等级", "E", "", "L", "", "", "", 1, 1, "M");//13
            p_SetSc("产品等级", "E", "", "L", "", "", "", 1, 1, "M");//14
            p_SetSc("是否切边", "ETCN", "5", "I", "CD_NAME", "", "SELECT CD_NAME FROM ZP_CD WHERE CD_MANA_NO = 'WG008'", 1, 1);//15

            p_SetSc("切边日期", "DT", " ", "AI", "", "", "", 1, 1, "M");//16
            p_SetSc("是否切头", "ETCN", "5", "I", "CD_NAME", "", "SELECT CD_NAME FROM ZP_CD WHERE CD_MANA_NO = 'WG009'", 1, 1);//17
            p_SetSc("切头日期", "DT", "", "AI", "", "", "", 1, 1, "M");//18
            p_SetSc("是否切尾", "C", "", "AI", "", "", "", 1, 1);//19
            p_SetSc("切尾日期", "DT", " ", "AI", "", "", "", 1, 1, "M");//20

            p_SetSc("是否取样一次", "C", " ", "AI", "", "", "", 1, 1, "M");//21
            p_SetSc("取样一次日期", "DT", " ", "AI", "", "", "", 1, 1, "M");//22         
            p_SetSc("是否取样二次", "C", " ", "AI", "", "", "", 1, 1, "M");//23
            p_SetSc("取样二次日期", "DT", " ", "AI", "", "", "", 1, 1);//24
            p_SetSc("是否二次切割", "E", " ", "L", "", "", "", 1, 1);//25  --是否二次切割
            p_SetSc("班次", "ON", "", "I", "", "", " ", 1, 1, "M");//26

            p_SetSc("班别", "ON", " ", "I", "", "", "", 1, 1, "M");//27
            p_SetSc("修改人员", "E", "", "IL", "", "", "", 1, 1, "M");//28
            p_SetSc("修改人员", "E", "", "L", "", "", "", 1, 1, "M");//29
            p_SetSc("操作人员", "E", "", "L", "", "", "", 1, 1, "M");//30
            p_SetSc("操作人员", "E", "", "L", "", "", "", 1, 1, "M");//31

            p_SetSc("垛位", "E", "", "L", "", "", "", 1, 1 ,"M");//32
            p_SetSc("缺陷", "E", "", "L", "", "", "", 1, 1, "M");//33
            p_SetSc("探伤", "E", "", "L", "", "", "", 1, 1, "M");//34     
            p_SetSc("切割", "E", " ", "L", "", "", "", 1, 1, "M");//35
            p_SetSc("矫直", "E", "", "L", "", "", "", 1, 1, "M");//36

            p_SetSc("抛丸", "E", " ", "L", "", "", "", 1, 1, "M");//37
            p_SetSc("热处理", "E", "", "L", "", "", "", 1, 1, "M");//38
            p_SetSc("客户", "E", "", "L", "", "", "", 1, 1);//39
            p_SetSc("入库时间", "DT", "8", "L", "", "", "", 1, 1, "R");//40
            p_SetSc("库", "E", " ", "L", "", "", "", 1, 1, "M");//41

            p_SetSc("定尺", "C", " ", "L", "", "", "", 1, 1);//42
            p_SetSc("紧急订单", "E", " ", "L", "", "", "", 1, 1, "M");//43
            p_SetSc("订单材/余材代码", "E", " ", "L", "", "", "", 1, 1, "M");//44
            p_SetSc("其它", "E", "200", "L", "", "", "", 1, 1, "L");//45
            p_SetSc("定制配送", "E", " ", "L", "", "", "", 1, 1, "M");//46
            p_SetSc("原始订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//47
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//48


       
            iheadrow = 0;
            p_spanSpread("产品", 8, 11, 1, 0, 1);
            p_spanSpread("作业指示/实绩", 33, 37, 1, 0, 1);


            FarPoint.Win.Spread.CellType.ComboBoxCellType ocellNew = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            FarPoint.Win.Spread.CellType.ComboBoxCellType ocellNew1 = new FarPoint.Win.Spread.CellType.ComboBoxCellType();

            ocellNew.Items = new string[4]{ "", "1", "2","3" };
            ocellNew.ItemData = new string[4] { "", "1", "2", "3" };
            ocellNew.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
            this.ss1_Sheet1.Columns.Get(SPD_SHIFT_CD).CellType = ocellNew;

            ocellNew1.Items = new string[5] { "", "A", "B", "C", "D" };
            ocellNew1.ItemData = new string[5] { "", "A", "B", "C", "D" };
            ocellNew1.EditorValue = FarPoint.Win.Spread.CellType.EditorValue.ItemData;
            this.ss1_Sheet1.Columns.Get(SPD_GROUP_CD).CellType = ocellNew1;

        }

        private void WGT2030C_Load(object sender, EventArgs e)
        {
            Form_Define();
        }

        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            base.ss_CellDoubleClick(sender, e);
            string inputTime = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL");
            if (e.Column == 1)
            {
                this.ss1_Sheet1.Cells[e.Row, e.Column].Text = inputTime.Substring(0, 4) + "-" + inputTime.Substring(4, 2) + "-" + inputTime.Substring(6, 2) + " " + inputTime.Substring(8, 2) + ":" + inputTime.Substring(10, 2) + ":" + inputTime.Substring(12, 2);
                this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
            }
            if (e.Column == SPD_CUR_TRIM_FL || e.Column == SPD_CUR_TRIM_H_FL || e.Column == SPD_CUR_TRIM_T_FL || e.Column == SPD_CUR_TRIM_SMP1_FL || e.Column == SPD_CUR_TRIM_SMP2_FL)
            {
                if (this.ss1_Sheet1.Cells[e.Row, e.Column - 1].Value.ToString().ToUpper() == "0")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("\"" + this.ss1_Sheet1.ColumnHeader.Cells[0, e.Column - 1].Text + "\"" + "必须点击后，才可输入日期", "W", "警告");
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.ss1_Sheet1.Cells[e.Row, e.Column].Text = inputTime.Substring(0, 4) + "-" + inputTime.Substring(4, 2) + "-" + inputTime.Substring(6, 2) + " " + inputTime.Substring(8, 2) + ":" + inputTime.Substring(10, 2) + ":" + inputTime.Substring(12, 2);
                    this.ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                }
            }
        }

        protected override void ss_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column == SPD_CUR_TRIM_FL || e.Column == SPD_CUR_TRIM_H_FL || e.Column == SPD_CUR_TRIM_T_FL || e.Column == SPD_CUR_TRIM_SMP1_FL || e.Column == SPD_CUR_TRIM_SMP2_FL)
            {
                if (this.ss1_Sheet1.Cells[e.Row, e.Column - 1].Value.ToString().ToUpper() == "0")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("\"" + this.ss1_Sheet1.ColumnHeader.Cells[0, e.Column - 1].Text + "\"" + "必须点击后，才可输入日期", "W", "警告");
                    this.ss1_Sheet1.Cells[e.Row, e.Column].Text = "";
                    return;
                }
            }
            base.ss_EditChange(sender, e);
        }

        public override void Form_Ref()
        {
            base.Form_Ref();
            for (int i = 0; i < ss1_Sheet1.RowCount;i++ )
            {
                if (ss1_Sheet1.Cells[i, SPD_URGNT_FL].Text == "Y")
                    this.ss1_Sheet1.Rows[i].ForeColor = Color.Red;

                //定制配送钢板，褐色显示
                if (ss1_Sheet1.Cells[i, SPD_JIT_FLAG].Text == "Y")
                {
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.Brown;
                }
            }            
        }


       



    }
}
