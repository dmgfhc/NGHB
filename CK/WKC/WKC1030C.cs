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
    public partial class WKC1030C : CommonClass.FORMBASE
    {
        public WKC1030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        System.Windows.Forms.TextBox TXT_USER = new System.Windows.Forms.TextBox();
        protected override void p_SubFormInit()
        {
            int imcseq;
            imcseq = 1;
            p_McIni(Mc1, true);
            p_SetMc("日期", txt_DATE, "PIN", "", "", "", "", 1);
            p_SetMc(CBO_SHIFT, "PIN", "", "", "", 1, "");
            p_SetMc(txt_commect0, "IR", "", "", "", 1, "");
            p_SetMc(txt_commect1, "IR", "", "", "", 1, "");
            p_SetMc(txt_commect2, "IR", "", "", "", 1, "");
            p_SetMc(txt_commect3, "IR", "", "", "", 1, "");
            p_SetMc(txt_commect4, "IR", "", "", "", 1, "");
            p_SetMc(TXT_USER, "I", "", "", "", 1, "");

            p_ScIni(ss1, Sc1, 24, false, false);

            p_SetSc("班别", "E", "10", "L", "", "", "", 1, 1,"M");//0
            p_SetSc("报告时间", "E", "", "IL", "", "", "", 1, 1,"M");//1
            p_SetSc("产品规格", "E", "", "L", "", "", "", 1, 1);//2
            p_SetSc("钢种", "E", "", "L", "", "", "", 1, 1);//3
            p_SetSc("原料规格", "E", "", "L", "", "", "", 1, 1);//4

            //p_SetSc("粗轧机", "E", "", "L", "", "", "", 1, 1);//5
            //p_SetSc("精轧机", "E", "", "L", "", "", "", 1, 1);//6
            p_SetSc("操作工", "E", "", "L", "", "", "", 1, 1);//5
            p_SetSc("计划", "N", "6", "I", "", "", "", 1, 1);//6
            p_SetSc("实际", "N", "6", "L", "", "", "", 1, 1);//7
            p_SetSc("计划", "N", "6", "I", "", "", "", 1, 1);//8

            p_SetSc("实际1", "N", "6", "L", "", "", "", 1, 1);//9
            p_SetSc("实际2", "N", "6", "L", "", "", "", 1, 1);//10
            p_SetSc("实际3", "N", "6", "L", "", "", "", 1, 1);//11 
            p_SetSc("实际4", "N", "6", "L", "", "", "", 1, 1);//12
            p_SetSc("小计", "N", "6", "L", "", "", "", 1, 1);//13

            p_SetSc("剪切块数", "N", "6", "L", "", "", "", 1, 1);//14 -----------20140418

            p_SetSc("回炉", "N", "6", "L", "", "", "", 1, 1);//15
            p_SetSc("轧损", "N", "6", "L", "", "", "", 1, 1);//16
            p_SetSc("轧废", "N", "6", "L", "", "", "", 1, 1);//17
            p_SetSc("原因", "E", "", "L", "", "", "", 1, 1);//18
            p_SetSc("起", "E", "", "L", "", "", "", 1, 1);//19

            p_SetSc("止", "E", "", "L", "", "", "", 1, 1);//20
            p_SetSc("小计", "N", "6", "L", "", "", "", 1, 1);//21
            p_SetSc("原因", "E", "", "L", "", "", "", 1, 1);//22
            p_SetSc("轧制时间", "D", "", "ILA", "", "", "", 1, 1,"M");//23
            p_SetSc("更新人员", "E", "", "ILA", "", "", "", 1, 1,"M");//24
         
            //p_spanSpread("压下工", 5, 6, 1, 0, 1);
            p_spanSpread("工作时间", 6, 7, 1, 0, 1);
            p_spanSpread("热轧块数", 8, 13, 1, 0, 1);
            p_spanSpread("未成品", 15, 18, 1, 0, 1);
            p_spanSpread("停机分析", 19, 22, 1, 0, 1);
          
        }

        private void WKC1030C_Load(object sender, EventArgs e)
        {
            
            Form_Define();
        
            txt_DATE.RawDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate-1,'YYYYMMDD') from dual");
            CBO_SHIFT.Text = "1";
            TXT_USER.Text = GeneralCommon.sUserID;
            if (GeneralCommon.Gf_Sc_Authority(base.sAuthority, "U"))
                Cmd_Edit.Enabled = true;
            else
                Cmd_Edit.Enabled = false;
            setSpread2ColumnAndRow();
            setMdiWindowsBar();
            ss2.ActiveSheet.GrayAreaBackColor = Color.Gray;   
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            setMdiWindowsBar();
            this.ss2_Sheet1.Rows.Count = 0;
            setSpread2ColumnAndRow();
            return true;
        }

        private void setMdiWindowsBar()
        {
            GeneralCommon.ImageList0.Images[3] = GeneralCommon.ImageList2.Images[3];
            GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";
            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            GeneralCommon.ImageList0.Images[9] = GeneralCommon.ImageList1.Images[9];
            GeneralCommon.MDIToolBar.Buttons[13].Tag = "T";
            GeneralCommon.MDIToolBar.Refresh();
        }

        private void setSpread2ColumnAndRow()
        {
            this.ss2_Sheet1.RowHeader.Visible = false;
            this.ss2.ActiveSheet.ColumnHeader.Visible = false;
            this.ss2_Sheet1.RowCount = 6;
            this.ss2_Sheet1.Columns.Count = 6;
            for (int i = 0; i < this.ss2_Sheet1.Columns.Count; i++)
            {
                this.ss2_Sheet1.Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                this.ss2_Sheet1.Columns[i].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                this.ss2_Sheet1.Columns[i].Resizable = false;
                this.ss2_Sheet1.Rows[i].Height = 22;
                this.ss2.ActiveSheet.Columns[i].Locked = true;
            }
            this.ss2_Sheet1.Columns[0].BackColor = Color.PowderBlue;
            this.ss2_Sheet1.Columns[1].BackColor = Color.PowderBlue;
            this.ss2_Sheet1.Rows[0].BackColor = Color.PowderBlue;
            this.ss2_Sheet1.Rows[1].BackColor = Color.PowderBlue;

            this.ss2_Sheet1.AddSpanCell(0, 0, 2, 2);
            this.ss2_Sheet1.Cells[0, 0].Text = "精轧机辊别";
            this.ss2_Sheet1.Columns[0].Width = 95;
            this.ss2_Sheet1.Columns[1].Width = 35;
            this.ss2_Sheet1.AddSpanCell(2, 0, 1, 2);
            this.ss2_Sheet1.Cells[2, 0].Text = "在用辊号";
            this.ss2_Sheet1.AddSpanCell(3, 0, 1, 2);
            this.ss2_Sheet1.Cells[3, 0].Text = "上班累计(KM)";
            this.ss2_Sheet1.AddSpanCell(4, 0, 2, 1);
            this.ss2_Sheet1.Cells[4, 0].Text = "实际利用能力";
            this.ss2_Sheet1.Cells[4, 1].Text = "本班";
            this.ss2_Sheet1.Cells[5, 1].Text = "累计";
            this.ss2_Sheet1.AddSpanCell(0, 2, 1, 2);
            this.ss2_Sheet1.Cells[0, 2].Text = "工作辊";
            this.ss2_Sheet1.Cells[1, 2].Text = "上";
            this.ss2_Sheet1.Cells[1, 3].Text = "下";
            this.ss2_Sheet1.AddSpanCell(0, 4, 1, 2);
            this.ss2_Sheet1.Cells[0, 4].Text = "支撑辊";
            this.ss2_Sheet1.Cells[1, 4].Text = "上";
            this.ss2_Sheet1.Cells[1, 5].Text = "下";

            

        }


        public override void Form_Ref()
        {
            //base.Form_Ref();
           
            if (p_Ref(1, 1, true, true))
            {
                this.ss1_Sheet1.Columns[1].BackColor = Color.White;
                this.ss1_Sheet1.Columns[23].BackColor = Color.White;
            }
            Ss2_Data_Refer("{CALL WKC1030C.SearchSpread2Data('" + this.txt_DATE.RawDate + "','" + this.CBO_SHIFT.Text + "'}");
            setMdiWindowsBar();

            CBO_SHIFT.Enabled = true;
            txt_DATE.Enabled = true;

        }

        
        private bool Ss2_Data_Refer(string sQuery)
        {
            bool isHaveData = false;  

            if (GeneralCommon.M_CN1.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return isHaveData;
                }
            }
         
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (AdoRs.EOF || AdoRs.BOF)
                {
                    AdoRs.Close();
                    GeneralCommon.M_CN1.Close();
                    return isHaveData;
                }
                while (!AdoRs.EOF)
                {
                    //this.ss2_Sheet1.Cells[2, 2].Text = AdoRs.Fields[32].Value.ToString() == "" ? "" : AdoRs.Fields[32].Value.ToString();
                    //this.ss2_Sheet1.Cells[3, 2].Text = AdoRs.Fields[15].Value.ToString() == "" ? "" : AdoRs.Fields[15].Value.ToString();
                    //this.ss2_Sheet1.Cells[4, 2].Text = AdoRs.Fields[16].Value.ToString() == "" ? "" : AdoRs.Fields[16].Value.ToString();
                    //this.ss2_Sheet1.Cells[5, 2].Text = AdoRs.Fields[17].Value.ToString() == "" ? "" : AdoRs.Fields[17].Value.ToString();

                    //this.ss2_Sheet1.Cells[2, 3].Text = AdoRs.Fields[33].Value.ToString() == "" ? "" : AdoRs.Fields[33].Value.ToString();
                    //this.ss2_Sheet1.Cells[3, 3].Text = AdoRs.Fields[15].Value.ToString() == "" ? "" : AdoRs.Fields[15].Value.ToString();
                    //this.ss2_Sheet1.Cells[4, 3].Text = AdoRs.Fields[16].Value.ToString() == "" ? "" : AdoRs.Fields[16].Value.ToString();
                    //this.ss2_Sheet1.Cells[5, 3].Text = AdoRs.Fields[17].Value.ToString() == "" ? "" : AdoRs.Fields[17].Value.ToString();

                    //this.ss2_Sheet1.Cells[2, 4].Text = AdoRs.Fields[34].Value.ToString() == "" ? "" : AdoRs.Fields[34].Value.ToString();
                    //this.ss2_Sheet1.Cells[3, 4].Text = AdoRs.Fields[20].Value.ToString() == "" ? "" : AdoRs.Fields[20].Value.ToString();
                    //this.ss2_Sheet1.Cells[4, 4].Text = AdoRs.Fields[21].Value.ToString() == "" ? "" : AdoRs.Fields[21].Value.ToString();
                    //this.ss2_Sheet1.Cells[5, 4].Text = AdoRs.Fields[22].Value.ToString() == "" ? "" : AdoRs.Fields[22].Value.ToString();

                    //this.ss2_Sheet1.Cells[2, 5].Text = AdoRs.Fields[35].Value.ToString() == "" ? "" : AdoRs.Fields[35].Value.ToString();
                    //this.ss2_Sheet1.Cells[3, 5].Text = AdoRs.Fields[20].Value.ToString() == "" ? "" : AdoRs.Fields[20].Value.ToString();
                    //this.ss2_Sheet1.Cells[4, 5].Text = AdoRs.Fields[21].Value.ToString() == "" ? "" : AdoRs.Fields[21].Value.ToString();
                    //this.ss2_Sheet1.Cells[5, 5].Text = AdoRs.Fields[22].Value.ToString() == "" ? "" : AdoRs.Fields[22].Value.ToString();


                    this.ss2_Sheet1.Cells[2, 2].Text = AdoRs.Fields[14].Value.ToString() == "" ? "" : AdoRs.Fields[14].Value.ToString();
                    this.ss2_Sheet1.Cells[3, 2].Text = AdoRs.Fields[6].Value.ToString() == "" ? "" : AdoRs.Fields[6].Value.ToString();
                    this.ss2_Sheet1.Cells[4, 2].Text = AdoRs.Fields[7].Value.ToString() == "" ? "" : AdoRs.Fields[7].Value.ToString();
                    this.ss2_Sheet1.Cells[5, 2].Text = AdoRs.Fields[8].Value.ToString() == "" ? "" : AdoRs.Fields[8].Value.ToString();

                    this.ss2_Sheet1.Cells[2, 3].Text = AdoRs.Fields[15].Value.ToString() == "" ? "" : AdoRs.Fields[15].Value.ToString();
                    this.ss2_Sheet1.Cells[3, 3].Text = AdoRs.Fields[6].Value.ToString() == "" ? "" : AdoRs.Fields[6].Value.ToString();
                    this.ss2_Sheet1.Cells[4, 3].Text = AdoRs.Fields[7].Value.ToString() == "" ? "" : AdoRs.Fields[7].Value.ToString();
                    this.ss2_Sheet1.Cells[5, 3].Text = AdoRs.Fields[8].Value.ToString() == "" ? "" : AdoRs.Fields[8].Value.ToString();

                    this.ss2_Sheet1.Cells[2, 4].Text = AdoRs.Fields[16].Value.ToString() == "" ? "" : AdoRs.Fields[16].Value.ToString();
                    this.ss2_Sheet1.Cells[3, 4].Text = AdoRs.Fields[11].Value.ToString() == "" ? "" : AdoRs.Fields[11].Value.ToString();
                    this.ss2_Sheet1.Cells[4, 4].Text = AdoRs.Fields[12].Value.ToString() == "" ? "" : AdoRs.Fields[12].Value.ToString();
                    this.ss2_Sheet1.Cells[5, 4].Text = AdoRs.Fields[13].Value.ToString() == "" ? "" : AdoRs.Fields[13].Value.ToString();

                    this.ss2_Sheet1.Cells[2, 5].Text = AdoRs.Fields[17].Value.ToString() == "" ? "" : AdoRs.Fields[17].Value.ToString();
                    this.ss2_Sheet1.Cells[3, 5].Text = AdoRs.Fields[11].Value.ToString() == "" ? "" : AdoRs.Fields[11].Value.ToString();
                    this.ss2_Sheet1.Cells[4, 5].Text = AdoRs.Fields[12].Value.ToString() == "" ? "" : AdoRs.Fields[12].Value.ToString();
                    this.ss2_Sheet1.Cells[5, 5].Text = AdoRs.Fields[13].Value.ToString() == "" ? "" : AdoRs.Fields[13].Value.ToString();



                    AdoRs.MoveNext();
                }
                isHaveData = true;
                AdoRs.Close();
                AdoRs = null;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
            catch (Exception ex)
            {
                AdoRs.Close();
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay("数据错误，请检查是否有异常数据...!!"+ex.Message, "W", "警告");
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
        }

        private void Cmd_Edit_Click(object sender, EventArgs e)
        {
            string sDate = txt_DATE.RawDate;
            string SHIFT = this.CBO_SHIFT.Text;
            string ret_Result_ErrMsg;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "WKC1030P";
                GeneralCommon.M_CN1.BeginTrans();
                adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));

                adoCmd.Parameters[0].Value = sDate;
                adoCmd.Parameters[1].Value = SHIFT;
                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "")
                {
                    ret_Result_ErrMsg = adoCmd.Parameters["arg_e_code"].Value.ToString();
                    GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrMsg);
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();
                }
                else
                {
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                    GeneralCommon.Gp_MsgBoxDisplay("数据更新成功！", "I", this.Text);
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)("WKC1030P Error : " + ex.Message), "W", "警告");
            }
        }

        public override void Form_Pro()
        {
            base.Form_Pro();
        }






        public override void Spread_Exc()
        {
            try
            {
                setExcel();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("导出数据错误...!!" + ex.Message, "W", "警告");
            }
        }

        private void setExcel()
        {
            if (this.CBO_SHIFT.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("班次代码不能为空...!!", "W", "警告");
                return;
            }
            if (this.txt_DATE.RawDate == "" || this.txt_DATE.RawDate.Length != 8)
            {
                GeneralCommon.Gp_MsgBoxDisplay("日期输入不正确...!!", "W", "警告");
                return;
            }
            if (this.ss1_Sheet1.RowCount <= 0) return;
            string modelName = "WKC1030C.xls";
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
            appExcel.Cells[2, 1] = "报表日期：" + this.txt_DATE.RawDate.Substring(0, 4) + "年" + this.txt_DATE.RawDate.Substring(4, 2) + "月" + this.txt_DATE.RawDate.Substring(6, 2) + "日";
            appExcel.Cells[2, 4] = "班次：" + this.CBO_SHIFT.Text;
            appExcel.Cells[2, 6] = "班别：" + this.ss1_Sheet1.Cells[0, 0].Text;

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                appExcel.Cells[6 + i, 1] = ss1.ActiveSheet.Cells[i, 1].Text;
                appExcel.Cells[6 + i, 2] = ss1.ActiveSheet.Cells[i, 2].Text;
                appExcel.Cells[6 + i, 3] = ss1.ActiveSheet.Cells[i, 3].Text;
                appExcel.Cells[6 + i, 4] = ss1.ActiveSheet.Cells[i, 4].Text;
                appExcel.Cells[6 + i, 5] = ss1.ActiveSheet.Cells[i, 5].Text;
                appExcel.Cells[6 + i, 6] = ss1.ActiveSheet.Cells[i, 6].Text;
                appExcel.Cells[6 + i, 7] = ss1.ActiveSheet.Cells[i, 7].Text;
                appExcel.Cells[6 + i, 8] = ss1.ActiveSheet.Cells[i, 8].Text;
                appExcel.Cells[6 + i, 9] = ss1.ActiveSheet.Cells[i, 9].Text;
                appExcel.Cells[6 + i, 10] = ss1.ActiveSheet.Cells[i, 10].Text;
                appExcel.Cells[6 + i, 11] = ss1.ActiveSheet.Cells[i, 11].Text;
                appExcel.Cells[6 + i, 12] = ss1.ActiveSheet.Cells[i, 12].Text;
                appExcel.Cells[6 + i, 13] = ss1.ActiveSheet.Cells[i, 13].Text;
                appExcel.Cells[6 + i, 14] = ss1.ActiveSheet.Cells[i, 14].Text;
                appExcel.Cells[6 + i, 15] = ss1.ActiveSheet.Cells[i, 15].Text;
                appExcel.Cells[6 + i, 16] = ss1.ActiveSheet.Cells[i, 16].Text;
                appExcel.Cells[6 + i, 17] = ss1.ActiveSheet.Cells[i, 17].Text;
                appExcel.Cells[6 + i, 18] = ss1.ActiveSheet.Cells[i, 18].Text;
                appExcel.Cells[6 + i, 19] = ss1.ActiveSheet.Cells[i, 19].Text;
                appExcel.Cells[6 + i, 20] = ss1.ActiveSheet.Cells[i, 20].Text;
                appExcel.Cells[6 + i, 21] = ss1.ActiveSheet.Cells[i, 21].Text;
                appExcel.Cells[6 + i, 22] = ss1.ActiveSheet.Cells[i, 22].Text;
            }
            appExcel.Cells[14, 1] = "合计";

            //appExcel.Cells[15, 2] = this.txt_commect0.Text;
            //appExcel.Cells[23, 2] = this.txt_commect1.Text;
            //appExcel.Cells[15, 15] = this.txt_commect2.Text;
            //appExcel.Cells[23, 15] = this.txt_commect3.Text;
            //appExcel.Cells[27, 15] = this.txt_commect4.Text;

            //appExcel.Cells[5, 24] = this.ss2_Sheet1.Cells[2, 2].Text;
            //appExcel.Cells[5, 25] = this.ss2_Sheet1.Cells[2, 3].Text;
            //appExcel.Cells[5, 26] = this.ss2_Sheet1.Cells[2, 4].Text;
            //appExcel.Cells[5, 27] = this.ss2_Sheet1.Cells[2, 5].Text;

            //appExcel.Cells[6, 24] = this.ss2_Sheet1.Cells[3, 2].Text;
            //appExcel.Cells[6, 25] = this.ss2_Sheet1.Cells[3, 3].Text;
            //appExcel.Cells[6, 26] = this.ss2_Sheet1.Cells[3, 4].Text;
            //appExcel.Cells[6, 27] = this.ss2_Sheet1.Cells[3, 5].Text;

            //appExcel.Cells[7, 24] = this.ss2_Sheet1.Cells[4, 2].Text;
            //appExcel.Cells[7, 25] = this.ss2_Sheet1.Cells[4, 3].Text;
            //appExcel.Cells[7, 26] = this.ss2_Sheet1.Cells[4, 4].Text;
            //appExcel.Cells[7, 27] = this.ss2_Sheet1.Cells[4, 5].Text;

            //appExcel.Cells[8, 24] = this.ss2_Sheet1.Cells[5, 2].Text; 
            //appExcel.Cells[8, 25] = this.ss2_Sheet1.Cells[5, 3].Text;
            //appExcel.Cells[8, 26] = this.ss2_Sheet1.Cells[5, 4].Text;
            //appExcel.Cells[8, 27] = this.ss2_Sheet1.Cells[5, 5].Text;       

            //appExcel.Cells[30, 24] = "制表日期: " + GeneralCommon.Gf_GetDateStr(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL")); 
            //appExcel.Cells[30, 20] = "制表人：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select emp_name from zp_employee where emp_id='" + GeneralCommon.sUserID + "'");


            appExcel.Cells[15, 2] = this.txt_commect0.Text;
            appExcel.Cells[23, 2] = this.txt_commect1.Text;
            appExcel.Cells[15, 16] = this.txt_commect2.Text;
            appExcel.Cells[23, 16] = this.txt_commect3.Text;
            appExcel.Cells[27, 16] = this.txt_commect4.Text;

            appExcel.Cells[5, 25] = this.ss2_Sheet1.Cells[2, 2].Text;
            appExcel.Cells[5, 26] = this.ss2_Sheet1.Cells[2, 3].Text;
            appExcel.Cells[5, 27] = this.ss2_Sheet1.Cells[2, 4].Text;
            appExcel.Cells[5, 28] = this.ss2_Sheet1.Cells[2, 5].Text;

            appExcel.Cells[6, 25] = this.ss2_Sheet1.Cells[3, 2].Text;
            appExcel.Cells[6, 26] = this.ss2_Sheet1.Cells[3, 3].Text;
            appExcel.Cells[6, 27] = this.ss2_Sheet1.Cells[3, 4].Text;
            appExcel.Cells[6, 28] = this.ss2_Sheet1.Cells[3, 5].Text;

            appExcel.Cells[7, 25] = this.ss2_Sheet1.Cells[4, 2].Text;
            appExcel.Cells[7, 26] = this.ss2_Sheet1.Cells[4, 3].Text;
            appExcel.Cells[7, 27] = this.ss2_Sheet1.Cells[4, 4].Text;
            appExcel.Cells[7, 28] = this.ss2_Sheet1.Cells[4, 5].Text;

            appExcel.Cells[8, 25] = this.ss2_Sheet1.Cells[5, 2].Text;
            appExcel.Cells[8, 26] = this.ss2_Sheet1.Cells[5, 3].Text;
            appExcel.Cells[8, 27] = this.ss2_Sheet1.Cells[5, 4].Text;
            appExcel.Cells[8, 28] = this.ss2_Sheet1.Cells[5, 5].Text;

            appExcel.Cells[30, 25] = "制表日期: " + GeneralCommon.Gf_GetDateStr(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL"));
            appExcel.Cells[30, 21] = "制表人：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select emp_name from zp_employee where emp_id='" + GeneralCommon.sUserID + "'");

            appExcel.Visible = true;
            appExcel = null;

        }






    }
}
