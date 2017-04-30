using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;

namespace WG
{
    public partial class WGC3333C : CommonClass.FORMBASE
    {
        public WGC3333C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
     
        TextBox txt_prod_cd = new TextBox();
        TextBox txt_slab_no = new TextBox();
        int actionFlag = 13;
        int actionLoc = 14;
        int actionLen = 15;
        int actionSamNo = 16;
        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("查询号", txt_charge_no, "P", "", "", "", "", imcseq);
            p_SetMc("生产时间", sdt_prod_date, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "8", "", "", "", imcseq);
            p_SetMc("班别", cbo_group, "P", "8", "", "", "", imcseq);
            p_SetMc("生产时间(结束)", txt_prod_cd, "P", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("钢种", "E", "", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("取样状态", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow);//
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);//
            p_SetSc("长度", "N", "6", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("重量", "N", "6,3", "L", "", "", "", iscseq, iheadrow);//
            p_SetSc("订单号", "E", "18", "L", "", "", "", iscseq, iheadrow);//
            p_SetSc("订单序列号", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow);//
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("产品代码", "AE", "", "L", "", "", "", iscseq, iheadrow, "M");//
            p_SetSc("剪切时间", "DT", "", "L", "", "", "", iscseq, iheadrow);//12

            iheadrow = 0;
            p_spanSpread("板坯尺寸", 3, 5, iscseq, iheadrow, 1);
            p_spanSpread("产品尺寸", 9, 10, iscseq, iheadrow, 1);


            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("板坯号", txt_slab_no, "P", "", "", "", "", imcseq);

            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("取样状态", "C", "", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("钢板/卷号", "E", "18", "PIL", "", "", "", iscseq, iheadrow);   //      PI
            p_SetSc("产品代码", "E", "18", "LI", "", "", "", iscseq, iheadrow, "M");//2       I
            p_SetSc("进程代码", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("厚度", "N", "6,1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6,1", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("长度", "N", "6,1", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("订单标记", "E", "18", "LA", "", "", "", iscseq, iheadrow);  //          A
            p_SetSc("订单号", "E", "18", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("订单系列号", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("指示标记", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("指示长度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("实绩标记", "E", "1", "LI", "", "", "", iscseq, iheadrow, "M");     //  I
            p_SetSc("位置", "ETCN", "1", "LI", "CD", "", "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称, CD_SHORT_ENG 代码英文简称, CD_FULL_ENG 代码英文名称 FROM NISCO.ZP_CD  WHERE CD_MANA_NO = 'Q0021'  ORDER BY CD ASC ", iscseq, iheadrow, "M");//            I
            p_SetSc("长度", "N", "3", "LI", "", "", "", iscseq, iheadrow);//15                 I
            p_SetSc("试样号", "E", "14", "LI", "", "", "", iscseq, iheadrow);      //       I
            p_SetSc("适用标准", "E", "18", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("改判前标准", "E", "18", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("客户名称", "E", "200", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("生产日期", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("upd_emp_cd", "E", "18", "LIA", "", "", "", iscseq, iheadrow);//         IA
            p_SetSc("实绩标记", "E", "18", "LA", "", "", "", iscseq, iheadrow);//              A
            p_SetSc("位置", "N", "18", "LA", "", "", "", iscseq, iheadrow);//                 A
            p_SetSc("长度", "N", "18", "LA", "", "", "", iscseq, iheadrow);//
            p_SetSc("试样号", "E", "18", "LA", "", "", "", iscseq, iheadrow);//25                A
            p_SetSc("改判时试样号", "E", "18", "LIA", "", "", "", iscseq, iheadrow);//        IA
            p_SetSc("改判时适用标准", "E", "18", "LIA", "", "", "", iscseq, iheadrow);//       IA

            iheadrow = 0;
            p_spanSpread("试样信息", 11, 16, iscseq, iheadrow, 1);
            p_spanSpread("板坯信息", 22, 25, iscseq, iheadrow, 1);


        }

        private void WGC3333C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "WGC3020C";
            Form_Define();
            txt_prod_cd.Text = "PP";
            opt_Product1.ForeColor = Color.Red;
            opt_Product1.Checked = true;
            base.sAuthority = "1111";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_prod_cd.Text = "PP";
            opt_Product1.ForeColor = Color.Red;
            txt_smp_no.Text = "";
            txt_smp_len.Text = "";
            txt_smp_loc.Text = "";
            txt_smp_loc_name.Text = "";
            txt_chg_smp_no.Text = "";
            txt_chg_stdspec.Text = "";
            return true;
        }

        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            FarPoint.Win.Spread.FpSpread spread = (FarPoint.Win.Spread.FpSpread)sender;

            if (e.ColumnHeader) return;
            if (spread.Name == "ss1")//点击的是第一个Spread
            {
                if (ss1.ActiveSheet.RowCount < 0) return;//Spread1无数据，返回。
                txt_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text.Trim();//设置txt_SLAB_NO控件的值。用于Spread2的查询
                p_Ref(2, 2, true, false);//Spread2的查询
                if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text == "")//点击Spread1用于查询Spread2
                {
                    for (int i = 0; i < ss1.ActiveSheet.Rows.Count; i++)
                    {
                        ss1.ActiveSheet.Rows.Get(i).BackColor = Color.White;
                        ss1.ActiveSheet.Cells[i, 0].BackColor = Color.White;
                        ss1.ActiveSheet.RowHeader.Cells[i, 0].Text = "";
                    }
                    ss1.ActiveSheet.Rows.Get(e.Row).BackColor = Color.GreenYellow;
                    ss1.ActiveSheet.Cells[e.Row, 0].BackColor = Color.GreenYellow;
                    txt_charge_no.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text;
                    ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "选择";
                }
                else
                {
                    ss1.ActiveSheet.Rows.Get(e.Row).BackColor = Color.White;
                    ss1.ActiveSheet.Cells[e.Row, 0].BackColor = Color.White;
                    ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                    txt_charge_no.Text = "";
                    ss2.ActiveSheet.RowCount = 0;
                }
                if (ss2_Sheet1.RowCount == 0) return;//假如Spread2无数据，返回。
                else
                {
                    txt_smp_no.Text = "";
                    rowCount = 0;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)//遍历Spread2，进程代码不以“X”开头，可以修改数据。
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//
                        {
                            ss2_Sheet1.Cells[i, 0].Locked = false;  //可以修改。不锁定
                            ss2_Sheet1.Cells[i, actionFlag].Locked = false;
                            ss2_Sheet1.Cells[i, actionLoc].Locked = false;
                            ss2_Sheet1.Cells[i, actionLen].Locked = false;
                            ss2_Sheet1.Cells[i, actionSamNo].Locked = false;

                            ss2_Sheet1.Cells[i, 0].BackColor = Color.FromArgb(255, 255, 255, 192);//颜色为黄色。
                            ss2_Sheet1.Cells[i, actionFlag].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, actionLoc].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, actionLen].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, actionSamNo].BackColor = Color.FromArgb(255, 255, 255, 192);
                            rowCount++;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[i, 0].BackColor = Color.White;//以“X”开头，设定背景色为白色。不可修改数据。
                            ss2_Sheet1.Cells[i, actionFlag].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, actionLoc].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, actionLen].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, actionSamNo].BackColor = Color.White;
                        }
                    }

                    ArrayRecords = new object[rowCount, 4];//定义数组，存储Spread2的初始数据，用于点击Spread2的Checkbox按钮时，恢复数据。
                    int currentCountSeq = 0;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//不以“X”开头的数据才可以存储。
                        {
                            ArrayRecords[currentCountSeq, 0] = ss2_Sheet1.Cells[i, actionFlag].Text;
                            ArrayRecords[currentCountSeq, 1] = ss2_Sheet1.Cells[i, actionLoc].Text;
                            ArrayRecords[currentCountSeq, 2] = ss2_Sheet1.Cells[i, actionLen].Text;
                            ArrayRecords[currentCountSeq++, 3] = ss2_Sheet1.Cells[i, actionSamNo].Text;
                        }
                    }

                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。默认取Spread2的第一条不以“X”开头的板坯号为式样号。
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                        {
                            txt_smp_no.Text = ss2_Sheet1.Cells[i, 1].Text;
                            SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                            break;
                        }
                    }
                    txt_smp_len.Text = "";
                    txt_smp_loc.Text = "";
                    txt_smp_loc_name.Text = "";
                }
            }
            else//双击的为Spread2，假如双击的不以“X”开头，并且点击的列数为13,14,15，16.那么根据规则自动将数据填充。
            {
                if (ss2_Sheet1.ActiveColumnIndex == actionFlag || ss2_Sheet1.ActiveColumnIndex == actionLoc || ss2_Sheet1.ActiveColumnIndex == actionLen || ss2_Sheet1.ActiveColumnIndex == 16)
                {
                    if (!ss2_Sheet1.Cells[e.Row, 3].Text.Trim().StartsWith("X"))
                    {
                        ss2_Sheet1.Cells[e.Row, 0].Text = "True";
                        ss2_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss2_Sheet1.Cells[e.Row, actionSamNo].Text = SMP_NO;
                        if (SMP_NO == ss2_Sheet1.Cells[e.Row, 1].Text)//式样号与板坯号相同，那么“实绩标记”为红色Y。
                        {
                            ss2_Sheet1.Cells[e.Row, actionFlag].Text = "Y";
                            ss2_Sheet1.Cells[e.Row, actionFlag].ForeColor = Color.Red;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, actionFlag].Text = "N";
                        }
                        if (ss2_Sheet1.Cells[e.Row, actionFlag].Text == "Y")//“实绩标记”为红色Y，才可将“试样长度”赋值给第15列“长度”
                        {
                            ss2_Sheet1.Cells[e.Row, actionLen].Text = txt_smp_len.Text;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, actionLen].Text = "0";//否则默认为“0”
                        }
                        if (this.txt_smp_loc.Text != "")
                        {
                            ss2_Sheet1.Cells[e.Row, actionLoc].Text = txt_smp_loc.Text;//“取样位置”不为空时，方可将“取样位置”赋值给Spread2的第14列。
                        }
                    }
                }

            }
        }

        public override void Form_Ref()//Spread1的查询。
        {
            if (!(sdt_prod_date.RawDate != "" || txt_charge_no.Text != ""))
            {
                GeneralCommon.Gp_MsgBoxDisplay("生产时间或者查询号必须输入...!", "I", "提示");
                return;
            }
            p_Ref(1, 1, true, true);
        }
        //“取样位置”只可输入：“B”“M”“T”“Y”“”。
        private void txt_SMP_LOC_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_smp_loc.Text == "B" || txt_smp_loc.Text == "M" || txt_smp_loc.Text == "T" || txt_smp_loc.Text == "Y" || txt_smp_loc.Text == ""))
            {
                txt_smp_loc.Text = "";
            }
        }

        string SMP_NO = "";//式样号。

        //“多行设定”按钮。
        private void Cmd_Set_Save_Click(object sender, EventArgs e)
        {
            if (ss2_Sheet1.RowCount == 0) return;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                {
                    ss2_Sheet1.RowHeader.Cells[i, 0].Text = "修改";
                    ss2_Sheet1.Cells[i, actionSamNo].Text = SMP_NO;//
                    ss2_Sheet1.Cells[i, 0].Text = "1";

                    if (ss2_Sheet1.Cells[i, 1].Text == ss2_Sheet1.Cells[i, actionSamNo].Text)
                    {
                        ss2_Sheet1.Cells[i, actionFlag].Text = "Y";
                        ss2_Sheet1.Cells[i, actionFlag].ForeColor = Color.Red;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, actionFlag].Text = "N";
                    }

                    if (ss2_Sheet1.Cells[i, actionFlag].Text == "Y")
                    {
                        ss2_Sheet1.Cells[i, actionLen].Text = txt_smp_len.Text;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, actionLen].Text = "0";
                    }
                    if (this.txt_smp_loc.Text != "")
                    {
                        ss2_Sheet1.Cells[i, actionLoc].Text = txt_smp_loc.Text;
                    }
                }
            }
        }

        object[,] ArrayRecords = null;
        int rowCount = 0;

        private void ss2_EnterCell(object sender, FarPoint.Win.Spread.EnterCellEventArgs e)
        {

        }

        //Spread2的Cell离开事件，用于校验手工输入的Spread2的第13，14，15，16列的内容是否符合规范。
        private void ss2_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            if (ss2_Sheet1.ActiveColumnIndex == actionSamNo && ss2_Sheet1.Cells[e.Row, actionSamNo].Text.Length != 14)
            {
                GeneralCommon.Gp_MsgBoxDisplay("试样号错误", "W", "警告");
                ss2_Sheet1.Cells[e.Row, actionSamNo].Text = SMP_NO;
            }
            if (ss2_Sheet1.ActiveColumnIndex == actionLoc && (ss2_Sheet1.Cells[e.Row, actionLoc].Text != "T") && (ss2_Sheet1.Cells[e.Row, actionLoc].Text != "Y") && (ss2_Sheet1.Cells[e.Row, actionLoc].Text != "B") && (ss2_Sheet1.Cells[e.Row, 14].Text != "M") && (ss2_Sheet1.Cells[e.Row, 14].Text != ""))
            {
                ss2_Sheet1.Cells[e.Row, 14].Text = "T";
            }
            if (ss2_Sheet1.ActiveColumnIndex == actionFlag && (ss2_Sheet1.Cells[e.Row, actionFlag].Text != "Y") && (ss2_Sheet1.Cells[e.Row, actionFlag].Text != "N") && (ss2_Sheet1.Cells[e.Row, actionLoc].Text != "P"))
            {
                if (ss2_Sheet1.Cells[e.Row, 1].Text != SMP_NO)
                    ss2_Sheet1.Cells[e.Row, actionLoc].Text = "N";
            }
        }

        //保存事件
        public override void Form_Pro()
        {
            string sStdspec = "";
            string sBefStdspec = "";
            string sSpec = "";
            int iChgCnt = 0;
            if (ss2_Sheet1.RowCount < 0) return;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (ss2_Sheet1.Cells[i, 3].Text != "XAC" && ss2_Sheet1.Cells[i, 3].Text != "XAF")
                {
                    sStdspec = ss2_Sheet1.Cells[i, 17].Text;
                    sBefStdspec = ss2_Sheet1.Cells[i, 18].Text;
                    if (sBefStdspec != "" && sStdspec != sBefStdspec && (ExpoCheck(sBefStdspec) && !(ExpoCheck(sStdspec))))
                    {
                        iChgCnt = iChgCnt + 1;
                    }
                }
            }

            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (ss2_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                {
                    sSpec = ss2_Sheet1.Cells[i, 18].Text;
                    if (txt_chg_smp_no.Text == "" || txt_chg_stdspec.Text == "")
                    {
                        if (ExpoCheck(sSpec))
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("改判试样号，改判时标准必须输入...!", "I", "提示");
                            return;
                        }
                    }
                    if (iChgCnt == 0)
                    {
                        ss2_Sheet1.Cells[i, 26].Text = txt_chg_smp_no.Text;
                        ss2_Sheet1.Cells[i, 27].Text = txt_chg_stdspec.Text;
                        iChgCnt = 1;
                    }
                }
            }
            if (base.p_Pro(2, 2, true, false))
            {
                p_Ref(1, 1, true, false);
            }
        }

        ////////
        private bool ExpoCheck(string sSpec)
        {
            bool ExpoCheck = false;
            string sqlStr = "SELECT Gf_Expo_Smp_Check('" + sSpec + "')FROM  DUAL ";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return false;
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            int flag = int.Parse(AdoRs.Fields[0].Value.ToString());
            if (flag > 0)
            {
                ExpoCheck = true;
            }
            return ExpoCheck;
        }

        private void opt_Product1_Click(object sender, EventArgs e)
        {
            opt_Product1.ForeColor = Color.Red;
            txt_prod_cd.Text = "PP";
            opt_Product.ForeColor = Color.Black;
        }

        private void opt_Product_Click(object sender, EventArgs e)
        {
            opt_Product1.ForeColor = Color.Black;
            txt_prod_cd.Text = "LP";
            opt_Product.ForeColor = Color.Red;
        }


        //Spread2的第一列checkbox单击事件，第一次点击时，将当前行数据按照规定赋值给Spread2的第13，14，15，16列。再次点击时，全部恢复初始值。
        private void ss2_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (ss2_Sheet1.RowCount < 0) return;
            if (e.Column == 0 && !ss2_Sheet1.Cells[e.Row, 3].Text.Trim().StartsWith("X"))
            {
                if (ss2_Sheet1.Cells[e.Row, 0].Text == "True")
                {
                    ss2_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                    ss2_Sheet1.Cells[e.Row, actionSamNo].Text = SMP_NO;
                    if (SMP_NO == ss2_Sheet1.Cells[e.Row, 1].Text)
                    {
                        ss2_Sheet1.Cells[e.Row, actionFlag].Text = "Y";
                        ss2_Sheet1.Cells[e.Row, actionFlag].ForeColor = Color.Red;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[e.Row, actionFlag].Text = "N";
                    }
                    if (ss2_Sheet1.Cells[e.Row, actionFlag].Text == "Y")
                    {
                        ss2_Sheet1.Cells[e.Row, actionLen].Text = txt_smp_len.Text;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[e.Row, actionLen].Text = "0";
                    }
                    if (this.txt_smp_loc.Text != "")
                    {
                        ss2_Sheet1.Cells[e.Row, actionLoc].Text = txt_smp_loc.Text;
                    }
                }
                else//再次点击时，全部恢复初始值。
                {
                    int currentCountSeq1 = 0;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                        {
                            ss2_Sheet1.Cells[i, 0].Text = "False";
                            ss2_Sheet1.RowHeader.Cells[i, 0].Text = "";
                            ss2_Sheet1.Cells[i, actionFlag].Text = ArrayRecords[currentCountSeq1, 0].ToString();
                            ss2_Sheet1.Cells[i, actionLoc].Text = ArrayRecords[currentCountSeq1, 1].ToString();
                            ss2_Sheet1.Cells[i, actionLen].Text = ArrayRecords[currentCountSeq1, 2].ToString();
                            ss2_Sheet1.Cells[i, actionSamNo].Text = ArrayRecords[currentCountSeq1++, 3].ToString();
                        }
                    }
                }
            }
        }

        private void ss2_EditModeOn(object sender, EventArgs e)
        {

        }

        private void ss2_EditorFocused(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {

        }

        private void ss2_Enter(object sender, EventArgs e)
        {

        }

       

      





    }
}
