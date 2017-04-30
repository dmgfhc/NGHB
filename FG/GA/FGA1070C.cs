using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;
namespace FG
{
    public partial class FGA1070C : CommonClass.FORMBASE
    {
        public FGA1070C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

       // TextBox TXT_PROD_CD = new TextBox();
        TextBox txt_prod_cd = new TextBox(); 
       // TextBox txt_SLAB_NO = new TextBox();
        TextBox txt_slab_no = new TextBox();
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
            p_SetSc("取样状态", "E", "", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("长度", "N", "6", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("重量", "N", "6,3", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("订单号", "E", "18", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("订单序列号", "E", "", "L", "", "", "", iscseq, iheadrow,"M");//8
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("产品代码", "E", "", "L", "", "", "", iscseq, iheadrow,"M");//11
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
            p_SetSc("位置", "ETCN", "1", "LI", "CD", "", "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称, CD_SHORT_ENG 代码英文简称, CD_FULL_ENG 代码英文名称 FROM NISCO.ZP_CD  WHERE CD_MANA_NO = 'Q0021'  ORDER BY CD ASC ", iscseq, iheadrow, "M");//14            I
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

        private void FGA1070C_Load(object sender, EventArgs e)
        {
            Form_Define();
            txt_prod_cd.Text = "PP";
            opt_Product1.ForeColor = Color.Red;
            opt_Product1.Checked = true;
            //   base.sAuthority = "1111";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_prod_cd.Text = "PP";
            opt_Product1.ForeColor = Color.Red;
            txt_SMP_NO.Text = "";
            txt_SMP_LEN.Text = "";
            txt_SMP_LOC.Text = "";
            txt_SMP_LOC_NAME.Text = "";
            txt_CHG_SMP_NO.Text = "";
            txt_CHG_STDSPEC.Text = "";
            list.Clear();
            isMax = false;
            return true;
        }

        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            FarPoint.Win.Spread.FpSpread spread = (FarPoint.Win.Spread.FpSpread)sender;

            if (e.ColumnHeader||e.RowHeader) return;
            if (spread.Name == "ss1")//点击的是第一个Spread
            {
                list.Clear();//0801
                

                if (ss1.ActiveSheet.RowCount < 0) return;//Spread1无数据，返回。
                //txt_slab_no.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text.Trim();//设置txt_SLAB_NO控件的值。用于Spread2的查询
                txt_slab_no.Text = "''"+ss1.ActiveSheet.Cells[e.Row, 0].Text.Trim()+"''";//设置txt_SLAB_NO控件的值。用于Spread2的查询
                p_Ref(2, 2, true, false);//Spread2的查询
                isMax = false;
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
                    list.Add(spread.ActiveSheet.Cells[e.Row, 0].Text);//0801
                }
                else
                {
                    ss1.ActiveSheet.Rows.Get(e.Row).BackColor = Color.White;
                    ss1.ActiveSheet.Cells[e.Row, 0].BackColor = Color.White;
                    ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                    txt_charge_no.Text = "";
                    ss2.ActiveSheet.RowCount = 0;
                    list.Remove(spread.ActiveSheet.Cells[e.Row, 0].Text);//0801
                }
                if (ss2_Sheet1.RowCount == 0) return;//假如Spread2无数据，返回。
                else
                {
                    txt_SMP_NO.Text = "";
                    rowCount = 0;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)//遍历Spread2，进程代码不以“X”开头，可以修改数据。
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//
                        {
                            ss2_Sheet1.Cells[i, 0].Locked = false;  //可以修改。不锁定
                            ss2_Sheet1.Cells[i, 13].Locked = false;
                            ss2_Sheet1.Cells[i, 14].Locked = false;
                            ss2_Sheet1.Cells[i, 15].Locked = false;
                            ss2_Sheet1.Cells[i, 16].Locked = false;

                            ss2_Sheet1.Cells[i, 0].BackColor = Color.FromArgb(255, 255, 255, 192);//颜色为黄色。
                            ss2_Sheet1.Cells[i, 13].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, 14].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, 15].BackColor = Color.FromArgb(255, 255, 255, 192);
                            ss2_Sheet1.Cells[i, 16].BackColor = Color.FromArgb(255, 255, 255, 192);
                            rowCount++;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[i, 0].BackColor = Color.White;//以“X”开头，设定背景色为白色。不可修改数据。
                            ss2_Sheet1.Cells[i, 13].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, 14].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, 15].BackColor = Color.White;
                            ss2_Sheet1.Cells[i, 16].BackColor = Color.White;
                        }
                    }

                    ArrayRecords = new object[rowCount, 4];//定义数组，存储Spread2的初始数据，用于点击Spread2的Checkbox按钮时，恢复数据。
                    int currentCountSeq = 0;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//不以“X”开头的数据才可以存储。
                        {
                            ArrayRecords[currentCountSeq, 0] = ss2_Sheet1.Cells[i, 13].Text;
                            ArrayRecords[currentCountSeq, 1] = ss2_Sheet1.Cells[i, 14].Text;
                            ArrayRecords[currentCountSeq, 2] = ss2_Sheet1.Cells[i, 15].Text;
                            ArrayRecords[currentCountSeq++, 3] = ss2_Sheet1.Cells[i, 16].Text;
                        }
                    }

                    //for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。默认取Spread2的第一条不以“X”开头的板坯号为式样号。
                    //{
                    //    if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                    //    {
                    //        txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                    //        SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                    //        break;
                    //    }
                    //}
                    bool isChoseed = false;
                    for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
                    {
                        if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X")&&ss2_Sheet1.Cells[i,13].Text == "Y")
                        {
                            txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                            SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                            isChoseed = true;
                            break;
                        }
                    }
                    if (!isChoseed)
                    {
                        for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
                        {
                            if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X") && (ss2_Sheet1.Cells[i, 11].Text.ToUpper() == "Y" || ss2_Sheet1.Cells[i,11].Text.ToUpper() == "P"))
                            {
                                txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                                SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                                isChoseed = true;
                                break;
                            }
                        }
                    }
                    if (!isChoseed)
                    {
                        for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
                        {
                            if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                            {
                                txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                                SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                                break;
                            }
                        }
                    }

                    ////////////////////////////////////////////////
                    ////////////////////////////////////////////////
                    Sample_No_Edit();
                    ////////////////////////////////////////////////
                    ////////////////////////////////////////////////


                    txt_SMP_LEN.Text = "";
                    txt_SMP_LOC.Text = "";
                    txt_SMP_LOC_NAME.Text = "";
                }
            }
            else//双击的为Spread2，假如双击的不以“X”开头，并且点击的列数为13,14,15，16.那么根据规则自动将数据填充。
            {
                if (ss2_Sheet1.ActiveColumnIndex == 13 || ss2_Sheet1.ActiveColumnIndex == 14 || ss2_Sheet1.ActiveColumnIndex == 15 || ss2_Sheet1.ActiveColumnIndex == 16)
                {
                    if (!ss2_Sheet1.Cells[e.Row, 3].Text.Trim().StartsWith("X"))
                    {
                        if (ss2_Sheet1.Cells[e.Row, 13].Text == "Y") return;////20131104ydk
                        ss2_Sheet1.Cells[e.Row, 0].Text = "True";
                        ss2_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss2_Sheet1.Cells[e.Row, 16].Text = SMP_NO;
                        if (SMP_NO == ss2_Sheet1.Cells[e.Row, 1].Text)//式样号与板坯号相同，那么“实绩标记”为红色Y。
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "Y";
                            ss2_Sheet1.Cells[e.Row, 13].ForeColor = Color.Red;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "N";
                        }
                        if (ss2_Sheet1.Cells[e.Row, 13].Text == "Y")//“实绩标记”为红色Y，才可将“试样长度”赋值给第15列“长度”
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = txt_SMP_LEN.Text;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = "0";//否则默认为“0”
                        }
                        if (this.txt_SMP_LOC.Text != "")
                        {
                            ss2_Sheet1.Cells[e.Row, 14].Text = txt_SMP_LOC.Text;//“取样位置”不为空时，方可将“取样位置”赋值给Spread2的第14列。
                        }
                    }
                }

            }
        }

        public override void Form_Ref()//Spread1的查询。
        {
            if (!(sdt_prod_date.RawDate != "" || txt_charge_no.Text != ""))
            {
                GeneralCommon.Gp_MsgBoxDisplay("生产时间或者查询号必须输入...!","I","提示");
                return;
            }
            if (p_Ref(1, 1, true, true))
            {
                ss2_Sheet1.RowCount = 0;
            }
        }
        //“取样位置”只可输入：“B”“M”“T”“Y”“”。
        private void txt_SMP_LOC_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_SMP_LOC.Text == "B" || txt_SMP_LOC.Text == "M" || txt_SMP_LOC.Text == "T" || txt_SMP_LOC.Text == "Y" || txt_SMP_LOC.Text == ""))
            {
                txt_SMP_LOC.Text = "";
            }
        }

        string SMP_NO = "";//式样号。

        //“多行设定”按钮。
        private void Cmd_Set_Save_Click(object sender, EventArgs e)
        {
            ///////20140219
            if (this.txt_SMP_NO.Text != "" && this.txt_SMP_NO.Text.Length == 14)
            {
                if (list.Count != 0)
                {
                    if (txt_SMP_NO.Text.StartsWith(list[0].ToString().Substring(0,8)))
                        SMP_NO = txt_SMP_NO.Text;
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("式样号与选定的钢板不匹配...!!","W","警告");
                        txt_SMP_NO.Text = "";
                        return;
                    }
                }
            }
            ///////20140219
            //if(ss2_Sheet1.RowCount == 0)return;
            if (ss2_Sheet1.RowCount == 0)
            {
                setMaxCount();
                return;
            }//0802
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                {
                    ss2_Sheet1.RowHeader.Cells[i, 0].Text = "修改";
                    ss2_Sheet1.Cells[i, 16].Text = SMP_NO;//
                    ss2_Sheet1.Cells[i, 0].Text = "1";

                    if (ss2_Sheet1.Cells[i, 1].Text == ss2_Sheet1.Cells[i, 16].Text)
                    {
                        ss2_Sheet1.Cells[i, 13].Text = "Y";
                        ss2_Sheet1.Cells[i, 13].ForeColor = Color.Red;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, 13].Text = "N";
                    }

                    if (ss2_Sheet1.Cells[i, 13].Text == "Y")
                    {
                        ss2_Sheet1.Cells[i, 15].Text = txt_SMP_LEN.Text;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, 15].Text = "0";
                    }
                    if (this.txt_SMP_LOC.Text != "")
                    {
                        ss2_Sheet1.Cells[i, 14].Text = txt_SMP_LOC.Text;
                    }
                }
            }
        }



        object[,] ArrayRecordsNew = null;
        Boolean isMax = false;
        public void setMaxCount()
        {
            
            if (list.Count == 0) return;
            list.Sort();
            txt_charge_no.Text = list[0];
            ///////////////20130805begin
            //ss2_Sheet1.RowCount = setSpreadRowCount();
            //int signCount = 0;
            //List<object> listMax = new List<object>();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    object[,] ArrayRecordsNNN = Gf_ArrayPlReturn("{call WGC3020C.P_SREFER1 ( '" + list[i] + "')}");
            //    signCount = ArrayRecordsNNN.Length / 28;
            //    for (int j = 0; j < signCount; j++)
            //    {
            //        for (int k = 0; k < 28; k++)
            //        {
            //            listMax.Add(ArrayRecordsNNN[j, k]);                  
            //        }
            //    }
            //}


            //for (int i = 0; i < listMax.Count / 28; i++)
            //{
            //    for (int j = 0; j < 28;j++)
            //    {
            //        ss2_Sheet1.Cells[i, j].Text = listMax[i * 28 + j].ToString();
            //    }
            //}
            ///////////20130805end
            //StringBuilder sb = new StringBuilder();
            //if (list.Count == 1) sb.Append("('").Append(list[0]).Append("')");
            //else
            //{
            //    for (int ii = 0; ii < list.Count; ii++)
            //    {
            //        if (ii == 0) sb.Append("('").Append(list[ii]);

            //        else if (ii == list.Count - 1) sb.Append(list[ii]).Append("')");

            //        else sb.Append("','").Append(list[ii]);
            //    }
            //}
            string inputPlSql = "";
            if (list.Count == 1) inputPlSql = "''" + list[0].Trim() + "''";
              // inputPlSql = "''1320005105'',''1320005107''";
           
            else
            {
                for (int ii = 0; ii < list.Count; ii++)
                {
                    if (ii == 0) inputPlSql = "''" + list[0].Trim();
                    else inputPlSql += "'',''" + list[ii].Trim();
                    if (ii == list.Count - 1) inputPlSql += "''";
                    
                    
                    

                }
            }
            object[,] ArrayRecordsNNN = Gf_ArrayPlReturn("{call FGA1070C.P_SREFER1 ( '" + inputPlSql + "')}");
            ss2_Sheet1.RowCount = ArrayRecordsNNN.GetLength(0);
            for (int i = 0; i < ArrayRecordsNNN.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayRecordsNNN.GetLength(1); j++)
                {
                    ss2_Sheet1.Cells[i, j].Text = ArrayRecordsNNN[i, j].ToString();
                }
            }

            //////////////////////////////////////////
            txt_SMP_NO.Text = "";
            rowCount = 0;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)//遍历Spread2，进程代码不以“X”开头，可以修改数据。
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//
                {
                    ss2_Sheet1.Cells[i, 0].Locked = false;  //可以修改。不锁定
                    ss2_Sheet1.Cells[i, 13].Locked = false;
                    ss2_Sheet1.Cells[i, 14].Locked = false;
                    ss2_Sheet1.Cells[i, 15].Locked = false;
                    ss2_Sheet1.Cells[i, 16].Locked = false;

                    ss2_Sheet1.Cells[i, 0].BackColor = Color.FromArgb(255, 255, 255, 192);//颜色为黄色。
                    ss2_Sheet1.Cells[i, 13].BackColor = Color.FromArgb(255, 255, 255, 192);
                    ss2_Sheet1.Cells[i, 14].BackColor = Color.FromArgb(255, 255, 255, 192);
                    ss2_Sheet1.Cells[i, 15].BackColor = Color.FromArgb(255, 255, 255, 192);
                    ss2_Sheet1.Cells[i, 16].BackColor = Color.FromArgb(255, 255, 255, 192);
                    rowCount++;
                }
                else
                {
                    ss2_Sheet1.Cells[i, 0].BackColor = Color.White;//以“X”开头，设定背景色为白色。不可修改数据。
                    ss2_Sheet1.Cells[i, 13].BackColor = Color.White;
                    ss2_Sheet1.Cells[i, 14].BackColor = Color.White;
                    ss2_Sheet1.Cells[i, 15].BackColor = Color.White;
                    ss2_Sheet1.Cells[i, 16].BackColor = Color.White;
                }
            }

            ArrayRecordsNew = new object[rowCount, 4];//定义数组，存储Spread2的初始数据，用于点击Spread2的Checkbox按钮时，恢复数据。
            int currentCountSeq = 0;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))//不以“X”开头的数据才可以存储。
                {
                    ArrayRecordsNew[currentCountSeq, 0] = ss2_Sheet1.Cells[i, 13].Text;
                    ArrayRecordsNew[currentCountSeq, 1] = ss2_Sheet1.Cells[i, 14].Text;
                    ArrayRecordsNew[currentCountSeq, 2] = ss2_Sheet1.Cells[i, 15].Text;
                    ArrayRecordsNew[currentCountSeq++, 3] = ss2_Sheet1.Cells[i, 16].Text;
                }
            }

          
            bool isChoseed = false;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X") && ss2_Sheet1.Cells[i, 13].Text == "Y")
                {
                    txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                    SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                    isChoseed = true;
                    break;
                }
            }
            if (!isChoseed)
            {
                for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
                {
                    if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X") && (ss2_Sheet1.Cells[i, 11].Text.ToUpper() == "Y" || ss2_Sheet1.Cells[i, 11].Text.ToUpper() == "P"))
                    {
                        txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                        SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                        isChoseed = true;
                        break;
                    }
                }
            }
            if (!isChoseed)
            {
                for (int i = 0; i < ss2_Sheet1.RowCount; i++)//取得式样号。
                {
                    if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                    {
                        txt_SMP_NO.Text = ss2_Sheet1.Cells[i, 1].Text;
                        SMP_NO = ss2_Sheet1.Cells[i, 1].Text;//将式样号赋值给全局变量SMP_NO。
                        break;
                    }
                }
            }

          
            Sample_No_Edit();
          


            txt_SMP_LEN.Text = "";
            //txt_SMP_LOC.Text = "";
            //txt_SMP_LOC_NAME.Text = "";
            //////////////////////////////////////////

            /////////////////////////////////////////////
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                {
                    ss2_Sheet1.RowHeader.Cells[i, 0].Text = "修改";
                    ss2_Sheet1.Cells[i, 16].Text = SMP_NO;//
                    ss2_Sheet1.Cells[i, 0].Text = "1";

                    if (ss2_Sheet1.Cells[i, 1].Text == ss2_Sheet1.Cells[i, 16].Text)
                    {
                        ss2_Sheet1.Cells[i, 13].Text = "Y";
                        ss2_Sheet1.Cells[i, 13].ForeColor = Color.Red;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, 13].Text = "N";
                    }

                    if (ss2_Sheet1.Cells[i, 13].Text == "Y")
                    {
                        ss2_Sheet1.Cells[i, 15].Text = txt_SMP_LEN.Text;
                    }
                    else
                    {
                        ss2_Sheet1.Cells[i, 15].Text = "0";
                    }
                    if (this.txt_SMP_LOC.Text != "")
                    {
                        ss2_Sheet1.Cells[i, 14].Text = txt_SMP_LOC.Text;
                    }
                }
            }
            /////////////////////////////////////////////
            isMax = true;





























        }

        private int setSpreadRowCount()
        {
            int SpreadRowCount = 0;
            ADODB.Recordset AdoRs;
            for (int i = 0; i < list.Count; i++)
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return 0;
                    }
                }
                AdoRs = new ADODB.Recordset();

                string sQuery = "{call FGA1070C.P_SREFER1 ( '" + list[i] + "')}";
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (AdoRs.BOF || AdoRs.EOF)
                {
                    AdoRs.Close();
                    AdoRs = null;
                    if (GeneralCommon.M_CN1.State != 0)
                    {
                        GeneralCommon.M_CN1.Close();
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    SpreadRowCount += AdoRs.RecordCount;
                }
                AdoRs.Close();
                AdoRs = null;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
            }
            return SpreadRowCount;
 
        }



        object[,] ArrayRecords = null;
        int rowCount = 0;

        private void ss2_EnterCell(object sender, FarPoint.Win.Spread.EnterCellEventArgs e)
        {
          
        }

        //Spread2的Cell离开事件，用于校验手工输入的Spread2的第13，14，15，16列的内容是否符合规范。
        private void ss2_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            if (ss2_Sheet1.ActiveColumnIndex == 16 && ss2_Sheet1.Cells[e.Row, 16].Text.Length != 14)
            {
                GeneralCommon.Gp_MsgBoxDisplay("试样号错误", "W", "警告");
                ss2_Sheet1.Cells[e.Row, 16].Text = SMP_NO;
            }
            if (ss2_Sheet1.ActiveColumnIndex == 14 && (ss2_Sheet1.Cells[e.Row, 14].Text != "T") && (ss2_Sheet1.Cells[e.Row, 14].Text != "Y") && (ss2_Sheet1.Cells[e.Row, 14].Text != "B") && (ss2_Sheet1.Cells[e.Row, 14].Text != "M") && (ss2_Sheet1.Cells[e.Row, 14].Text != ""))
            {
                ss2_Sheet1.Cells[e.Row, 14].Text = "T";
            }
            if (ss2_Sheet1.ActiveColumnIndex == 13 && (ss2_Sheet1.Cells[e.Row, 13].Text != "Y") && (ss2_Sheet1.Cells[e.Row, 13].Text != "N") && (ss2_Sheet1.Cells[e.Row, 14].Text != "P"))
            {
                if (ss2_Sheet1.Cells[e.Row, 1].Text != SMP_NO)
                    ss2_Sheet1.Cells[e.Row, 14].Text = "N";
            }
        }

        //保存事件
        public override void Form_Pro()
        {
            if (ss2_Sheet1.RowCount == 0) return;
            //for (int i = 0; i < ss1_Sheet1.RowCount; i++)
            //{
            //    if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "选择" && ss1_Sheet1.Cells[i, 2].Text == "取样结束")
            //    {
            //        GeneralCommon.Gp_MsgBoxDisplay(ss1_Sheet1.Cells[i, 0].Text + "已经取样完成，不能再次取样...!!", "W", "警告");
            //        return;
            //    }
            //}
            string sStdspec = "";
            string sBefStdspec = "";
            string sSpec = "";
            int iChgCnt = 0;
            if (ss2_Sheet1.RowCount < 0) return;
            for (int i = 0; i < ss2_Sheet1.RowCount;i++ )
            {
                if (ss2_Sheet1.Cells[i, 3].Text != "XAC" && ss2_Sheet1.Cells[i, 3].Text != "XAF")
                {
                    sStdspec = ss2_Sheet1.Cells[i, 17].Text;
                    sBefStdspec = ss2_Sheet1.Cells[i, 18].Text;
                    if(sBefStdspec != "" && sStdspec != sBefStdspec && (ExpoCheck(sBefStdspec) && !(ExpoCheck(sStdspec))))
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
                    if(txt_CHG_SMP_NO.Text ==""||txt_CHG_STDSPEC.Text =="")
                    {
                        if(ExpoCheck(sSpec))
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("改判试样号，改判时标准必须输入...!","I","提示");
                            return;
                        }
                    }
                    if(iChgCnt == 0)
                    {
                         ss2_Sheet1.Cells[i,26].Text = txt_CHG_SMP_NO.Text;
                         ss2_Sheet1.Cells[i, 27].Text = txt_CHG_STDSPEC.Text;
                        iChgCnt = 1;
                    }
                }
            }
            if (base.p_Pro(2, 2, true, true))
            {
                p_Ref(1, 1, true, false);
                ss2_Sheet1.RowCount = 0;
            }
            list.Clear();
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
            int flag = int.Parse( AdoRs.Fields[0].Value.ToString());
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

            if (isMax)
            {
                if (e.Column == 0 && !ss2_Sheet1.Cells[e.Row, 3].Text.Trim().StartsWith("X"))
                {
                    if (ss2_Sheet1.Cells[e.Row, 0].Text == "True")
                    {
                        ss2_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss2_Sheet1.Cells[e.Row, 16].Text = SMP_NO;
                        if (SMP_NO == ss2_Sheet1.Cells[e.Row, 1].Text)
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "Y";
                            ss2_Sheet1.Cells[e.Row, 13].ForeColor = Color.Red;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "N";
                        }
                        if (ss2_Sheet1.Cells[e.Row, 13].Text == "Y")
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = txt_SMP_LEN.Text;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = "0";
                        }
                        if (this.txt_SMP_LOC.Text != "")
                        {
                            ss2_Sheet1.Cells[e.Row, 14].Text = txt_SMP_LOC.Text;
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
                                ss2_Sheet1.Cells[i, 13].Text = ArrayRecordsNew[currentCountSeq1, 0].ToString();
                                ss2_Sheet1.Cells[i, 14].Text = ArrayRecordsNew[currentCountSeq1, 1].ToString();
                                ss2_Sheet1.Cells[i, 15].Text = ArrayRecordsNew[currentCountSeq1, 2].ToString();
                                ss2_Sheet1.Cells[i, 16].Text = ArrayRecordsNew[currentCountSeq1++, 3].ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                if (e.Column == 0 && !ss2_Sheet1.Cells[e.Row, 3].Text.Trim().StartsWith("X"))
                {
                    if (ss2_Sheet1.Cells[e.Row, 0].Text == "True")
                    {
                        ss2_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                        ss2_Sheet1.Cells[e.Row, 16].Text = SMP_NO;
                        if (SMP_NO == ss2_Sheet1.Cells[e.Row, 1].Text)
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "Y";
                            ss2_Sheet1.Cells[e.Row, 13].ForeColor = Color.Red;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 13].Text = "N";
                        }
                        if (ss2_Sheet1.Cells[e.Row, 13].Text == "Y")
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = txt_SMP_LEN.Text;
                        }
                        else
                        {
                            ss2_Sheet1.Cells[e.Row, 15].Text = "0";
                        }
                        if (this.txt_SMP_LOC.Text != "")
                        {
                            ss2_Sheet1.Cells[e.Row, 14].Text = txt_SMP_LOC.Text;
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
                                ss2_Sheet1.Cells[i, 13].Text = ArrayRecords[currentCountSeq1, 0].ToString();
                                ss2_Sheet1.Cells[i, 14].Text = ArrayRecords[currentCountSeq1, 1].ToString();
                                ss2_Sheet1.Cells[i, 15].Text = ArrayRecords[currentCountSeq1, 2].ToString();
                                ss2_Sheet1.Cells[i, 16].Text = ArrayRecords[currentCountSeq1++, 3].ToString();
                            }
                        }
                    }
                }
            }

            




        }
            
        



        public void Sample_No_Edit()
        {
            string sPlateNo = "";
            string sStdspec = "";
            string sBefStdspec = "";
            string sSmpFl = "";
            string sSmpNo = "";
            string sProdCd = "";
            string sSmp_No = "";
            if (ss2_Sheet1.RowCount < 0) return;
            for (int i = 0; i < ss2_Sheet1.RowCount; i++)
            {
                if (!ss2_Sheet1.Cells[i, 3].Text.Trim().StartsWith("X"))
                {
                    sStdspec = ss2_Sheet1.Cells[i, 17].Text;
                    sBefStdspec = ss2_Sheet1.Cells[i, 18].Text;
                    sPlateNo = ss2_Sheet1.Cells[i, 1].Text;
                    sSmpFl = ss2_Sheet1.Cells[i, 13].Text;
                    sSmpNo = ss2_Sheet1.Cells[i, 16].Text;
                    sProdCd = ss2_Sheet1.Cells[i, 2].Text;       
                    if(sProdCd == "PP")
                    {
                        sSmp_No = "00";
                    }
                    else
                    {
                        sSmp_No = "99";
                    }
                    if (ExpoCheck(sBefStdspec) || ExpoCheck(sStdspec))
                    {
                        if(sSmpFl != "" && sSmpNo != txt_SMP_NO.Text)
                        {
                            txt_CHG_STDSPEC.Text = sStdspec;
                        }
                        else
                        {
                            if(sBefStdspec != "" && sStdspec != sBefStdspec)
                            {
                                txt_CHG_STDSPEC.Text = sStdspec;
                            }
                        }
                        if(sProdCd == "PP")
                        {
                            txt_CHG_SMP_NO.Text = txt_SMP_NO.Text.Substring(0,12) + sSmp_No;
                        }
                        else
                        {
                            txt_CHG_SMP_NO.Text = txt_SMP_NO.Text.Substring(0,10) + sSmp_No;
                        }
                    }
                }
            }           
        }

        //public bool ExpoCheck(string str)
        //{
        //    bool isExpoCheck = false;
        //    string sQuery = " SELECT  Gf_Expo_Smp_Check(' " + str + " ') FROM  DUAL ";
        //    double flag = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1,sQuery);
        //    int sFlag = System.Convert.ToInt32(flag);
        //    if(sFlag>0)
        //    {
        //        isExpoCheck = true;
        //    }
        //    return isExpoCheck;
        //}
        private void ss2_EditModeOn(object sender, EventArgs e)
        {
            
        }

        private void ss2_EditorFocused(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
          
        }

        private void ss2_Enter(object sender, EventArgs e)
        {

        }


        List<string> list = new List<string>();
        protected override void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            //base.ss_CellClickEvent(sender, e);   

            FarPoint.Win.Spread.FpSpread spread = (FarPoint.Win.Spread.FpSpread)sender;
            if (e.ColumnHeader) return;
            if(spread.Name == "ss1")
            {
                if (spread.ActiveSheet.RowCount < 0) return;
                if (e.RowHeader)
                {
                    if (list.Count > 0)
                    {
                        if (spread.ActiveSheet.Cells[e.Row, 0].Text.Substring(0,8)!=list[0].Substring(0,8))
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("请选择同炉的钢板进行取样...!!","W","警告");
                            return;
                        }
                    }
                    ss2_Sheet1.RowCount = 0;
                    isMax = true;
                    if (spread.ActiveSheet.RowHeader.Cells[e.Row, 0].Text == "")
                    {
                        ss1.ActiveSheet.Rows.Get(e.Row).BackColor = Color.GreenYellow;
                        ss1.ActiveSheet.Cells[e.Row, 0].BackColor = Color.GreenYellow;
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "选择";
                        list.Add(spread.ActiveSheet.Cells[e.Row, 0].Text);
                    }
                    else
                    {
                        ss1.ActiveSheet.Rows.Get(e.Row).BackColor = Color.White;
                        ss1.ActiveSheet.Cells[e.Row, 0].BackColor = Color.White;
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
                        list.Remove(spread.ActiveSheet.Cells[e.Row, 0].Text);
                    }
 
                }
            }
        }


        private static object[,] Gf_ArrayPlReturn(string sQuery)
        {
            object[,] ArrayRecords = null;
            int RsRowCount = 0;
            int RsColCount = 0;
            ADODB.Recordset AdoRs;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return null;
                    }
                }
                AdoRs = new ADODB.Recordset();
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (AdoRs.BOF || AdoRs.EOF)
                {
                    //GeneralCommon.Gp_MsgBoxDisplay("没有数据...!", "I", "提示");
                    AdoRs.Close();
                    AdoRs = null;
                    if (GeneralCommon.M_CN1.State != 0)
                    {
                        GeneralCommon.M_CN1.Close();
                    }
                    Cursor.Current = Cursors.Default;
                    return null;
                }
                RsRowCount = AdoRs.RecordCount;
                RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }
                AdoRs.Close();
                AdoRs = null;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return ArrayRecords;
            }
            catch (Exception ex)
            {
                AdoRs = null;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_ArrayPlReturn Error : " + ex.Message), "W", " 警告");
                return null;
            }
        }


       
        


    }
}
