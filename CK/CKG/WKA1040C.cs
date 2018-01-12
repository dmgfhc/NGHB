using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CommonClass;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace CK
{
    public partial class WKA1040C : CommonClass.FORMBASE
    {
        public WKA1040C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        System.Windows.Forms.TextBox CBO_PLT = new System.Windows.Forms.TextBox();//工厂
        System.Windows.Forms.TextBox CBO_LINE = new System.Windows.Forms.TextBox();//机号
        System.Windows.Forms.TextBox udFmDate = new System.Windows.Forms.TextBox();//
        System.Windows.Forms.TextBox udToDate = new System.Windows.Forms.TextBox();//

        protected override void p_SubFormInit()
        {
            p_McIni(Mc1, false);

            p_SetMc("用户ID", txt_Slab_no, "P", "", "", "", "", 1);
            p_SetMc("工厂", CBO_PLT, "P", "", "", "", "", 1);
            p_SetMc("机号", CBO_LINE, "P", "", "", "", "", 1);
            p_SetMc("开始日期", udFmDate, "P", "", "", "", "", 1);
            p_SetMc("结束日期", udToDate, "P", "", "", "", "", 1);

            p_ScIni(ss1, Sc1, 0, true, true);

            p_SetSc("板坯号", "E", "", "IL", "", "", "", 1, 0);//0
            p_SetSc("用户交货期", "D", "", "L", "", "", "", 1, 0);//1
            p_SetSc("是否替代轧制", "E", "5", "L", "", "", "", 1, 0, "L");//2
            p_SetSc("表面客户要求", "E", "50", "L", "", "", "", 1, 0, "L");//3
            p_SetSc("配置形状", "E", "", "L", "", "", "", 1, 0);//4
            p_SetSc("修磨指示", "E", "", "L", "", "", "", 1, 0, "M");//5
            p_SetSc("修磨实绩", "E", "", "L", "", "", "", 1, 0, "M");//6
            p_SetSc("坯料生产时间", "DT", "", "L", "", "", "", 1, 0, "M");//7
            p_SetSc("冶炼钢种", "E", "", "L", "", "", "", 1, 0);//8
            p_SetSc("板坯钢种", "E", "", "L", "", "", "", 1, 0);//9
            p_SetSc("轧制钢种", "E", "", "L", "", "", "", 1, 0);//10     

            p_SetSc("订单标准", "E", "", "L", "", "", "", 1, 0);//11
            p_SetSc("坯厚", "N", "6,2", "L", "", "", "", 1, 0, "M");//12
            p_SetSc("坯宽", "N", "6,2", "L", "", "", "", 1, 0, "M");//13
            p_SetSc("计划坯长", "N", "8,1", "L", "", "", "", 1, 0, "R");//14       
            p_SetSc("实际坯长", "N", "8,1", "L", "", "", "", 1, 0, "R");//15   

            p_SetSc("实际重量", "N", "6,3", "L", "", "", "", 1, 0, "R");//16         
            p_SetSc("坯理重量", "N", "6,3", "L", "", "", "", 1, 0, "R");//17        
            p_SetSc("轧制方式", "E", "", "L", "", "", "", 1, 0);//18
            p_SetSc("坯料堆放位置", "E", "", "L", "", "", "", 1, 0);//19        
            p_SetSc("成品厚度", "N", "6,2", "L", "", "", "", 1, 0, "R");//20

            p_SetSc("成品宽度", "N", "6", "L", "", "", "", 1, 0, "R");//21     
            p_SetSc("子板长度", "N", "6", "L", "", "", "", 1, 0, "R");//22        
            p_SetSc("成品计划长度", "N", "6", "L", "", "", "", 1, 0, "R");//23
            p_SetSc("轧件长度", "N", "8,1", "L", "", "", "", 1, 0, "R");//24 
            p_SetSc("设计成材率(%)", "N", "6,2", "L", "", "", "", 1, 0, "R");//25

            p_SetSc("理论成材率(%)", "N", "6,2", "L", "", "", "", 1, 0, "R");//26
            p_SetSc("下料目标厚度", "N", "6,2", "L", "", "", "", 1, 0, "R");//27
            p_SetSc("目标宽度", "N", "6,2", "L", "", "", "", 1, 0, "R");//28


            p_SetSc("目标堆冷时间", "E", "30", "L", "", "", "", 1, 0, "M");//29
            p_SetSc("目标装炉温度", "E", "30", "L", "", "", "", 1, 0, "M");//30
            p_SetSc("下限在炉时间", "E", "30", "L", "", "", "", 1, 0, "M");//31
            p_SetSc("上限在炉时间", "E", "30", "L", "", "", "", 1, 0, "M");//32
            p_SetSc("目标出炉温度", "E", "30", "L", "", "", "", 1, 0, "M");//33
            p_SetSc("出炉温度偏差", "E", "30", "L", "", "", "", 1, 0, "M");//34
            p_SetSc("下限均热时间", "E", "30", "L", "", "", "", 1, 0, "M");//35
            p_SetSc("均热+三加时间", "E", "30", "L", "", "", "", 1, 0, "M");//36
            p_SetSc("目标钢温均匀性", "E", "30", "L", "", "", "", 1, 0, "M");//37

            p_SetSc("厚度公差上限", "N", "6,2", "L", "", "", "", 1, 0, "R");//38        
            p_SetSc("厚度公差下限", "N", "6,2", "L", "", "", "", 1, 0, "R");//39  
            p_SetSc("船号(加喷)", "E", "", "L", "", "", "", 1, 0);//40

            p_SetSc("定尺区分", "E", "", "L", "", "", "", 1, 0, "M");//41        
            p_SetSc("客户要求号", "E", "", "L", "", "", "", 1, 0);//42
            p_SetSc("客户名称", "E", "", "L", "", "", "", 1, 0);//43
            p_SetSc("不平度(mm/M)", "E", "", "L", "", "", "", 1, 0, "M");//44        
            p_SetSc("是否切边", "E", "", "L", "", "", "", 1, 0, "M");//45

            p_SetSc("探伤区分", "E", "", "L", "", "", "", 1, 0, "M");//46
            p_SetSc("是否走真空", "E", "1", "L", "", "", "", 1, 0, "M");//47
            p_SetSc("热处理方法", "E", "20", "L", "", "", "", 1, 0, "R");//48
            p_SetSc("取样号", "E", "", "L", "", "", "", 1, 0);//49
            p_SetSc("备注", "E", "", "L", "", "", "", 1, 0);//50
            p_SetSc("INS_DATE", "E", "", "LA", "", "", "", 1, 0);//51
            p_SetSc("是否超量排产", "E", "", "L", "", "", "", 1, 0, "M");//52
            p_SetSc("超量钢板数量", "E", "", "L", "", "", "", 1, 0, "M");//53
            p_SetSc("超量钢板重量", "E", "", "L", "", "", "", 1, 0, "M");//54
            p_SetSc("头尾坯标记", "E", "", "L", "", "", "", 1, 0, "M");//55
        }

        private void WKA1040C_Load(object sender, EventArgs e)
        {
            Form_Define();
            udFmDate.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(sysdate,'YYYYMMDD') FROM DUAL");
            udToDate.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(sysdate,'YYYYMMDD') FROM DUAL");
            CBO_PLT.Text = "C1";
            CBO_LINE.Text = "1";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            udFmDate.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(sysdate,'YYYYMMDD') FROM DUAL");
            udToDate.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(sysdate,'YYYYMMDD') FROM DUAL");
            CBO_PLT.Text = "C1";
            CBO_LINE.Text = "1";
            return true;
        }

        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            object[] inputTextPLT = new object[1];
            inputTextPLT[0] = CBO_PLT.Text.Trim();
            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1040P", inputTextPLT))
            {
                GeneralCommon.Gp_MsgBoxDisplay("更新成功...!!", "I", "提示");
            }
        }


        private void setExcel()
        {
            if (this.ss1_Sheet1.RowCount <= 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("没有数据，无法导出数据到Excel", "W", "警告");
                return;
            }

            string modelName = "WKA1040C.xls";
            GeneralCommon.Gp_CopyModel(modelName);
            string fileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + "report" + "\\" + modelName;
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(fileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            Microsoft.Office.Interop.Excel.Range range = null;
            Worksheet worksheet1 = null;
            worksheet1 = (Worksheet)workbook.Sheets[1];
            appExcel.Cells[2, 1] = udFmDate.Text.Substring(0, 4) + "年" + udFmDate.Text.Substring(4, 2) + "月" + udFmDate.Text.Substring(6, 2) + "日";
            appExcel.Cells[2, 2] = "编号QRBJ0203";

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[4 + i, 1] = (i + 1).ToString();
                appExcel.Cells[4 + i, 2] = ss1.ActiveSheet.Cells[i, 0].Text;  //板坯号
                appExcel.Cells[4 + i, 3] = ss1.ActiveSheet.Cells[i, 5].Text;  //修磨指示
                appExcel.Cells[4 + i, 4] = ss1.ActiveSheet.Cells[i, 6].Text;  //修磨实绩
                appExcel.Cells[4 + i, 5] = ss1.ActiveSheet.Cells[i, 1].Text;  //用户交货期
                appExcel.Cells[4 + i, 6] = ss1.ActiveSheet.Cells[i, 2].Text;  //是否替代轧制
                appExcel.Cells[4 + i, 7] = ss1.ActiveSheet.Cells[i, 3].Text;  //表面客户要求
                appExcel.Cells[4 + i, 8] = ss1.ActiveSheet.Cells[i, 4].Text;  //配置形状
                appExcel.Cells[4 + i, 9] = ss1.ActiveSheet.Cells[i, 7].Text;  //坯料生产时间
                appExcel.Cells[4 + i, 10] = ss1.ActiveSheet.Cells[i, 9].Text;  //板坯钢种
                appExcel.Cells[4 + i, 11] = ss1.ActiveSheet.Cells[i, 10].Text;  //轧制钢种
                appExcel.Cells[4 + i, 12] = ss1.ActiveSheet.Cells[i, 11].Text;  //订单标准
                appExcel.Cells[4 + i, 13] = ss1.ActiveSheet.Cells[i, 12].Text;  //坯厚
                appExcel.Cells[4 + i, 14] = ss1.ActiveSheet.Cells[i, 13].Text;  //坯宽
                appExcel.Cells[4 + i, 15] = ss1.ActiveSheet.Cells[i, 14].Text;  //计划坯长
                appExcel.Cells[4 + i, 16] = ss1.ActiveSheet.Cells[i, 15].Text;//实际坯长
                appExcel.Cells[4 + i, 17] = ss1.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[4 + i, 18] = ss1.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[4 + i, 19] = ss1.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[4 + i, 20] = ss1.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[4 + i, 21] = ss1.ActiveSheet.Cells[i, 20].Text;

                appExcel.Cells[4 + i, 22] = ss1.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[4 + i, 23] = ss1.ActiveSheet.Cells[i, 22].Text;
                appExcel.Cells[4 + i, 24] = ss1.ActiveSheet.Cells[i, 23].Text;
                appExcel.Cells[4 + i, 25] = ss1.ActiveSheet.Cells[i, 24].Text;
                appExcel.Cells[4 + i, 26] = ss1.ActiveSheet.Cells[i, 25].Text;

                appExcel.Cells[4 + i, 27] = ss1.ActiveSheet.Cells[i, 26].Text;
                appExcel.Cells[4 + i, 28] = ss1.ActiveSheet.Cells[i, 27].Text;
                appExcel.Cells[4 + i, 29] = ss1.ActiveSheet.Cells[i, 28].Text;
                appExcel.Cells[4 + i, 30] = ss1.ActiveSheet.Cells[i, 38].Text;
                appExcel.Cells[4 + i, 31] = ss1.ActiveSheet.Cells[i, 39].Text;
                appExcel.Cells[4 + i, 32] = ss1.ActiveSheet.Cells[i, 40].Text;

                appExcel.Cells[4 + i, 33] = ss1.ActiveSheet.Cells[i, 41].Text;
                appExcel.Cells[4 + i, 34] = ss1.ActiveSheet.Cells[i, 42].Text;
                appExcel.Cells[4 + i, 35] = ss1.ActiveSheet.Cells[i, 43].Text;
                appExcel.Cells[4 + i, 36] = ss1.ActiveSheet.Cells[i, 44].Text;
                appExcel.Cells[4 + i, 37] = ss1.ActiveSheet.Cells[i, 45].Text;

                appExcel.Cells[4 + i, 38] = ss1.ActiveSheet.Cells[i, 46].Text;
                appExcel.Cells[4 + i, 39] = ss1.ActiveSheet.Cells[i, 47].Text;
                appExcel.Cells[4 + i, 40] = ss1.ActiveSheet.Cells[i, 48].Text;
                appExcel.Cells[4 + i, 41] = ss1.ActiveSheet.Cells[i, 49].Text;
                appExcel.Cells[4 + i, 42] = ss1.ActiveSheet.Cells[i, 50].Text;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A" + (4 + i), "AK" + (4 + i));
                range.Borders.LineStyle = 1;

            }
            appExcel.Visible = true;
            appExcel = null;
        }



        public override void Spread_Exc()
        {
            try
            {
                setExcel();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("导出数据错误...!!", "W", "警告");
            }
        }








    }
}
