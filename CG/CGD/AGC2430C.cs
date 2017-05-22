using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;
//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       中板轧钢作业
//-- Sub_System Name   轧钢作业
//-- Program Name      钢板取样委托管理画面
//-- Program ID        AGC2430C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.05.22
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER           DATE                 EDITOR            DESCRIPTION
//   1.0         2017.05.22             韩超            钢板取样委托管理
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class AGC2430C : CommonClass.FORMBASE
    {
        public AGC2430C()
        {
            InitializeComponent();
            curDate = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDD') from dual");
        }
        string curDate = "";
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("开始日期", dtp_prod_fr, "PN", "", "", "", "", imcseq);//0
            p_SetMc("结束日期", dtp_prod_to, "PN", "", "", "", "", imcseq);//1
            p_SetMc("工厂", txt_plt, "PN", "8", "", "", "", imcseq);//2
            p_SetMc("产线", txt_line, "P", "8", "", "", "", imcseq);//3
            p_SetMc("委托单号", txt_smp_sent_no, "P", "", "", "", "", imcseq);//4
            p_SetMc("已处理对象", txt_check, "P", "", "", "", "", imcseq);//5
            p_SetMc("热处理", txt_DH_FL, "P", "", "", "", "", imcseq);//6
            p_SetMc("试样号", txt_smp_no, "P", "", "", "", "", imcseq);//7
            p_SetMc("复样", txt_smp_fl, "P", "", "", "", "", imcseq);//8
            p_SetMc("热处理方式", txt_HTM_METH, "P", "", "", "", "", imcseq);//9
            p_SetMc("出口", Txt_OutOrder, "P", "", "", "", "", imcseq);//10

            p_ScIni(ss1, Sc1, 26, false, true);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("选择", "C", "", "I", "", "", "", iscseq, iheadrow);//0
            p_SetSc("委托单号", "E", "", "IL", "", "", "", iscseq, iheadrow);//1
            p_SetSc("试样号", "E", "", "PIL", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("订单号(代表样)", "E", "", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("钢种", "E", "", "IL", "", "", "", iscseq, iheadrow);//4
            p_SetSc("订单备注", "E", "", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("合同交货结束时间", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("规格", "E", "", "IL", "", "", "", iscseq, iheadrow);//7
            p_SetSc("试样数量（件）", "N", "6", "I", "", "", "", iscseq, iheadrow);//8

            p_SetSc("拉伸", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("高温拉伸", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("冷弯", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("冲击温度", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("落锤温度", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("时效温度", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("夹杂", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("金相", "C", "", "I", "", "", "", iscseq, iheadrow);//16
            p_SetSc("硬度", "E", "", "IL", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("成分", "C", "", "IL", "", "", "", iscseq, iheadrow);//18
            p_SetSc("ON", "C", "", "IL", "", "", "", iscseq, iheadrow);//19
            p_SetSc("H", "C", "", "I", "", "", "", iscseq, iheadrow);//20
            p_SetSc("做普", "C", "", "IL", "", "", "", iscseq, iheadrow);//21
            p_SetSc("Z向", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("HIC ", "C", "", "IL", "", "", "", iscseq, iheadrow);//23
            p_SetSc("断口 ", "C", "", "IL", "", "", "", iscseq, iheadrow);//24
            p_SetSc(" ", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//25////////////////
            p_SetSc("备注", "E", "", "IL", "", "", "", iscseq, iheadrow);//26
            p_SetSc("要求完成时间", "E", "", "I", "", "", "", iscseq, iheadrow);//27
            p_SetSc("委托人id", "E", "", "IL", "", "", "", iscseq, iheadrow);//28  A
            p_SetSc("委托人", "E", "", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("录入日期", "E", "", "LA", "", "", "", iscseq, iheadrow);//30   A
            p_SetSc("录入时间", "E", "", "LA", "", "", "", iscseq, iheadrow);//31   A
            p_SetSc("工厂", "E", "", "ILA", "", "", "", iscseq, iheadrow);//32/////////////////////////    A
            p_SetSc("C", "E", "", "ILA", "", "", "", iscseq, iheadrow);//33//////////////////////////   A
            p_SetSc("紧急订单", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("订单特殊要求", "E", "300", "L", "", "", "", iscseq, iheadrow, "L");//35
            p_SetSc("是否有QAB船板", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//36
            p_SetSc("是否做PWHT", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//37
           
            iheadrow = 0;
            p_spanSpread("委托项目", 9, 24, iscseq, iheadrow, 1);
           
        }

        
        private void AGC2430C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "AGC2430NC";
            Form_Define();
        //    base.sAuthority = "1111";
            txt_plt.Text = "C3";
            this.dtp_prod_fr.RawDate = curDate;//取当前时间
            this.dtp_prod_to.RawDate = curDate;  
        
            txt_smp_fl.Checked = false;
            txt_check.Checked = false;
            subButtonHide();//设置画面形式。
            txt_smp_sent_no.Text = "";
            TXT_CUT_PLT.Text = "";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            txt_smp_fl.Checked = false;
            txt_check.Checked = false;
            subButtonHide();
            txt_smp_sent_no.Text = "";
            TXT_CUT_PLT.Text = "";
            txt_plt.Text = "C3";
            dtp_prod_fr.RawDate = curDate;
            dtp_prod_to.RawDate = curDate;
            return true;
        }

        public override void Form_Ref()
        {
            p_Ref(1,1,true,true);
            if (ss1_Sheet1.RowCount <= 0) return;
            for (int i = 0; i < ss1_Sheet1.RowCount;i++)//紧急订单，设置当前行的颜色。
            {
                if(ss1_Sheet1.Cells[i,34].Text == "Y")
                {
                    ss1.ActiveSheet.Rows.Get(i).BackColor = Color.GreenYellow;
                }
            }
            subButtonHide();
            TXT_CUT_PLT.Text = ss1_Sheet1.Cells[0, 32].Text;
            reSetToolbarImages();//重置Toolbar的画面。
        }

        //设置画面形式。
        private void subButtonHide()
        {
            if (txt_check.Checked)
            {           
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F"; cmdReport.Visible = true;
                GeneralCommon.MDIToolBar.Refresh();
                CmdSEND.Visible = true;
                label6.Visible = true;
                txt_smp_sent_no.Visible = true;
                label2.Visible = false;
                dtp_end_date.Visible = false;
                label8.Visible = false;
                SpreadCommon.Gp_Sp_ColHidden(ss1,1,false);
                for (int i = 0; i < ss1_Sheet1.RowCount;i++)
                {
                    ss1_Sheet1.Rows.Get(i).Locked = true;
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.White;
                }
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
                GeneralCommon.MDIToolBar.Refresh();
                cmdReport.Visible = false;
                CmdSEND.Visible = false;
                label6.Visible = false;
                txt_smp_sent_no.Visible = false;
                label2.Visible = true;
                dtp_end_date.Visible = true;
                label8.Visible = true;
                SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);
            }
        }

        //protected override void form_Activated(object sender, EventArgs e)
        //{
        //    base.form_Activated(sender, e);

        //    if (txt_check.Checked)
        //    {
        //        GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
        //        GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
        //    }
        //    else
        //    {
        //        GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
        //        GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
        //        GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
        //        GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
        //    }
        //}

        //重置Toolbar的画面。
        private void reSetToolbarImages()
        {
            if (txt_check.Checked)
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            }
            else
            {
                GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
                GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
                GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
                GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            }
            GeneralCommon.MDIToolBar.Refresh();
        }

        //点击“复样”选择按钮，进行查询
        private void txt_smp_fl_Click(object sender, EventArgs e)
        {
            Form_Ref();
        }

        //点击“已处理对象”选择按钮，进行查询
        private void txt_check_Click(object sender, EventArgs e)
        {
            subButtonHide();
            Form_Ref();
            txt_smp_sent_no.Text = "";
        }

        //Spread单元格双击事件。
        protected override void ss_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
           // base.ss_CellDoubleClick(sender, e);
            if (e.ColumnHeader) return;
            if (e.RowHeader) return;
            if (txt_check.Checked)
            {
                txt_smp_sent_no.Text = ss1_Sheet1.Cells[e.Row, 1].Text;
                TXT_CUT_PLT.Text = ss1_Sheet1.Cells[e.Row, 32].Text;
            }           
        }

        object[,] ArrayRecords;//存储从后台得到的数据，保存在二维数组中。
        string curDateExcel = "";
        ArrayList list = null;//定义一个集合，保存向后台传入的值。

        //“打印委托单”点击事件，1、打印委托单；2、式样号信息更新。
        private void cmdReport_Click(object sender, EventArgs e)
        {
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_smp_sent_no.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入委托单号，再打印！", "W", "提示");
                return;
            }
            ArrayRecords = null;
            string sQuery = "";
            sQuery = "SELECT    '',A.SMP_NO,A.STDSPEC ,A.THK  ,A.SMP_CNT ,A.TENCIL_FL  ,A.HGT_TENCIL_FL, A.Bend_Fl,A.Impact_TEMP  ,A.Drop_Wgt_TEMP";
            sQuery = sQuery + " ,A.Tim_Imact_TEMP    ,DECODE(A.Non_Metal_Fl,'1','Y','') ,DECODE(A.MACRO_FL,1,'Y','') ,A.Hardness_Fl,DECODE(A.Chem_Fl,1,'Y','')   ,DECODE(A.Ton_Fl,1,'Y','')   ,DECODE(A.Std_Smp_Fl,1,'Y','')";
            sQuery = sQuery + " ,A.Photo_Fl  ,SUBSTR(A.Text,1,48), A.WRK_DATE     ,A.UPD_EMP      ,gf_empnamefind(A.UPD_EMP)   ,A.UPD_DATE";
            sQuery = sQuery + " ,A.UPD_TIME  ,DECODE (B.PRC,'DH','热处理'||B.PRC_LINE , GF_COMNNAMEFIND('C0001',B.SMP_CUT_PLT) )   ,'1'";
            sQuery = sQuery + " ,GF_COMNNAMEFIND('Q0089',C.YP_TYPE_CD), GF_COMNNAMEFIND('Q0089',C.A_YP_TYPE_CD), GF_COMNNAMEFIND('Q0089',C.HGT_YP_TYPE_CD), GF_COMNNAMEFIND('Q0089',C.A_HGT_YP_TYPE_CD)";
            sQuery = sQuery + " ,GF_COMNNAMEFIND('Q0008',C.IMPACT_KND), GF_COMNNAMEFIND('Q0008',C.A_IMPACT_KND), GF_COMNNAMEFIND('Q0008',C.TIM_IMPACT_KND), GF_COMNNAMEFIND('Q0008',C.A_TIM_IMPACT_KND)";
            sQuery = sQuery + " ,GF_COMNNAMEFIND('Q0057',C.IMPACT_SIZE_CD), GF_COMNNAMEFIND('Q0057',C.A_IMPACT_SIZE_CD), GF_COMNNAMEFIND('Q0057',C.TIM_IMPACT_SIZE_CD), GF_COMNNAMEFIND('Q0057',C.A_TIM_IMPACT_SIZE_CD)";
            sQuery = sQuery + " , DECODE(A.HIC_Fl,1,'Y',''), GF_COMNNAMEFIND('Q0090',C.HIC_STD_CD), C.HIC_SVT_KND, DECODE(A.H_FL,1,'Y',''),DECODE(A.MECH_FRACT,1,'Y','')";
            sQuery = sQuery + " FROM   Qp_Smp_Send A,QP_TEST_HEAD B,QP_QLTY_MATR C";
            sQuery = sQuery + " WHERE  A.SMP_NO      = B.SMP_NO";
            sQuery = sQuery + "   AND  A.SMP_SEND_NO = '" + txt_smp_sent_no.Text + "'";
            sQuery = sQuery + "   AND  B.ORD_NO = C.ORD_NO";
            sQuery = sQuery + "   AND  B.ORD_ITEM = C.ORD_ITEM";
            sQuery = sQuery + "   AND C.KND = (SELECT  MAX(KND) FROM  NISCO.QP_QLTY_MATR ";
            sQuery = sQuery + " WHERE ORD_NO = B.ORD_NO AND ORD_ITEM = B.ORD_ITEM AND KND IN('1','2'))";
            sQuery = sQuery + " ORDER BY A.STDSPEC,A.THK ,A.SMP_NO";
            curDateExcel = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "select to_char(sysdate,'YYYYMMDDHH24MISS') from dual");
            ArrayRecords = plSqlReturn(sQuery);//二维数组ArrayRecords的赋值，保存后台传来的结果。
            SAMPLE_SEND_PRINT(ArrayRecords);//打印委托单。
            string plsqlPackageName = "AGC2430NC.P_SMODIFY1";
            string informationText = "提示信息：式样号信息已更新...!!!";
            list = new ArrayList();//初始集合。
            list.Add(txt_smp_sent_no.Text);//集合中添加值。
            PRINT_Click2(plsqlPackageName, list, informationText);//式样号信息更新
        }

        
        private void PRINT_Click2(string plsqlPackageName, ArrayList list, string informationText)
        {
            GeneralCommon.GStatusBar.Panels[0].Text = "提示信息：操作未能成功...!!";
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
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
                adoCmd.CommandText = plsqlPackageName;
                GeneralCommon.M_CN1.BeginTrans();
                for (int i = 1; i <= list.Count; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    adoCmd.Parameters[i].Value = list[i].ToString() == "" ? "" : list[i].ToString();
                }

                adoCmd.Execute(out value);
                if (plsqlPackageName == "AQC1060P")
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "YY")
                    {
                        ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                    {
                        ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "W", "警告");
            }
        }








       
        int RsRowCount = 0;//定义后台共有多少条记录返回。
        int RsColCount = 0;

        //传入SQL语句，得到该SQL语句执行的结果并返回。
        private object[,] plSqlReturn(string sQuery)
        {
            object[,] ArrayRecords = null;
            RsRowCount = 0;
            RsColCount = 0;
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
                    GeneralCommon.Gp_MsgBoxDisplay("没有数据...!", "I", "提示");
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
                return null;
            }
        }

        //打印委托单。
        private void SAMPLE_SEND_PRINT(object[,] ArrayRecords)
        { 
            if (TXT_CUT_PLT.Text == "")
            {
                if (txt_DH_FL.Checked)
                {
                    TXT_CUT_PLT.Text = "热处理" + txt_line.Text;
                }
                else
                {
                    TXT_CUT_PLT.Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "C0001", txt_plt.Text,1);
                }
            }

            if (null == ArrayRecords)//假如数组为空，返回
            {
                GeneralCommon.Gp_MsgBoxDisplay("该委托单号没有数据...!","I","提示");
                return;
            }

            object[,] ArrayRecordInputExcel = null;//定义一个二维数组，存储写入Excel表格数据。
            ArrayRecordInputExcel = new object[RsRowCount,23];//初始化二维数组，列共有21，行根据后台传入的多少条记录赋值。

            //从ArrayRecords二维数组中选取需要的数据，传入ArrayRecordInputExcel二维数组中
            for (int i = 0; i < RsRowCount;i++)
            {
                ArrayRecordInputExcel[i, 0] = i + 1;
                ArrayRecordInputExcel[i, 1] = ArrayRecords[i, 1];
                ArrayRecordInputExcel[i, 2] = ArrayRecords[i, 2];
                ArrayRecordInputExcel[i, 3] = ArrayRecords[i, 3];
                ArrayRecordInputExcel[i, 4] = ArrayRecords[i, 4];
                ArrayRecordInputExcel[i, 5] = ArrayRecords[i, 5];
                ArrayRecordInputExcel[i, 6] = ArrayRecords[i, 6];
                ArrayRecordInputExcel[i, 7] = ArrayRecords[i, 7];
                ArrayRecordInputExcel[i, 8] = ArrayRecords[i, 8];
                ArrayRecordInputExcel[i, 9] = ArrayRecords[i, 9];
                ArrayRecordInputExcel[i, 10] = ArrayRecords[i, 10];
                ArrayRecordInputExcel[i, 11] = ArrayRecords[i, 11];
                ArrayRecordInputExcel[i, 12] = ArrayRecords[i, 12];
                ArrayRecordInputExcel[i, 13] = ArrayRecords[i, 13];
                ArrayRecordInputExcel[i, 14] = ArrayRecords[i, 14];
                ArrayRecordInputExcel[i, 15] = ArrayRecords[i, 15];
                ArrayRecordInputExcel[i, 16] = ArrayRecords[i, 41];//H
                ArrayRecordInputExcel[i, 17] = ArrayRecords[i, 16];
                ArrayRecordInputExcel[i, 18] = ArrayRecords[i, 17];
                ArrayRecordInputExcel[i, 19] = ArrayRecords[i, 38];
                ArrayRecordInputExcel[i, 20] = ArrayRecords[i, 42];
                ArrayRecordInputExcel[i, 21] = ArrayRecords[i, 18];

                if (ArrayRecords[i, 26].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "屈服类型：" + ArrayRecords[i, 26].ToString();
                }
                else if (ArrayRecords[i, 27].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加屈服类型：" + ArrayRecords[i, 27].ToString();
                }
                else if (ArrayRecords[i, 28].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "高温屈服类型：" + ArrayRecords[i, 28].ToString();
                }
                else if (ArrayRecords[i, 29].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加高温屈服类型：" + ArrayRecords[i, 29].ToString();
                }
                else if (ArrayRecords[i, 30].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "冲击开槽：" + ArrayRecords[i, 30].ToString();
                }
                else if (ArrayRecords[i, 31].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加冲击开槽：" + ArrayRecords[i, 31].ToString();
                }
                else if (ArrayRecords[i, 32].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "时效冲击开槽：" + ArrayRecords[i, 32].ToString();
                }
                else if (ArrayRecords[i, 33].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加时效冲击开槽：" + ArrayRecords[i, 33].ToString();
                }
                else if (ArrayRecords[i, 34].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "冲击尺寸：" + ArrayRecords[i, 34].ToString();
                }
                else if (ArrayRecords[i, 35].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加冲击尺寸：" + ArrayRecords[i, 35].ToString();
                }
                else if (ArrayRecords[i, 36].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "时效冲击尺寸：" + ArrayRecords[i, 36].ToString();
                }
                else if (ArrayRecords[i, 37].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "追加时效冲击尺寸：" + ArrayRecords[i, 37].ToString();
                }
                else if (ArrayRecords[i, 39].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "HIC试验标准：" + ArrayRecords[i, 39].ToString();
                }
                else if (ArrayRecords[i, 40].ToString() != "")
                {
                    ArrayRecordInputExcel[i, 22] = "溶液类型：" + ArrayRecords[i, 40].ToString();
                }
                else
                {
                    ArrayRecordInputExcel[i, 22] = "";
                }
            }

            string dateInputExcel = curDateExcel.Substring(0, 4) + "-" + curDateExcel.Substring(4, 2) + "-" + curDateExcel.Substring(6, 2) + " " + curDateExcel.Substring(8, 2) + ":" + curDateExcel.Substring(10, 2) + ":" + curDateExcel.Substring(12, 2);
            string modelName = "AGC2430C.xls";
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

            appExcel.Cells[3, 1] = "委托单号：" + txt_smp_sent_no.Text;
            appExcel.Cells[4, 1] = "委托单位：" + TXT_CUT_PLT.Text;
            string excelDate = curDate.Substring(0, 4) + "年" + curDate.Substring(4, 2) + "月" + curDate.Substring(6, 2) + "日";
            appExcel.Cells[4, 2] = excelDate;
           
            for (int i = 0; i < RsRowCount;i++)
            {
                appExcel.Cells[7 + i, 1] = ArrayRecordInputExcel[i, 0].ToString();
                appExcel.Cells[7 + i, 2] = ArrayRecordInputExcel[i, 1].ToString();
                appExcel.Cells[7 + i, 3] = ArrayRecordInputExcel[i, 2].ToString();
                appExcel.Cells[7 + i, 4] = ArrayRecordInputExcel[i, 3].ToString();
                appExcel.Cells[7 + i, 5] = ArrayRecordInputExcel[i, 4].ToString();
                appExcel.Cells[7 + i, 6] = ArrayRecordInputExcel[i, 5].ToString();
                appExcel.Cells[7 + i, 7] = ArrayRecordInputExcel[i, 6].ToString();
                appExcel.Cells[7 + i, 8] = ArrayRecordInputExcel[i, 7].ToString();
                appExcel.Cells[7 + i, 9] = ArrayRecordInputExcel[i, 8].ToString();
                appExcel.Cells[7 + i, 10] = ArrayRecordInputExcel[i, 9].ToString();
                appExcel.Cells[7 + i, 11] = ArrayRecordInputExcel[i, 10].ToString();
                appExcel.Cells[7 + i, 12] = ArrayRecordInputExcel[i, 11].ToString();
                appExcel.Cells[7 + i, 13] = ArrayRecordInputExcel[i, 12].ToString();
                appExcel.Cells[7 + i, 14] = ArrayRecordInputExcel[i, 13].ToString();
                appExcel.Cells[7 + i, 15] = ArrayRecordInputExcel[i, 14].ToString();
                appExcel.Cells[7 + i, 16] = ArrayRecordInputExcel[i, 15].ToString();
                appExcel.Cells[7 + i, 17] = ArrayRecordInputExcel[i, 16].ToString();
                appExcel.Cells[7 + i, 18] = ArrayRecordInputExcel[i, 17].ToString();
                appExcel.Cells[7 + i, 19] = ArrayRecordInputExcel[i, 18].ToString();
                appExcel.Cells[7 + i, 20] = ArrayRecordInputExcel[i, 19].ToString();
                appExcel.Cells[7 + i, 21] = ArrayRecordInputExcel[i, 20].ToString();
                appExcel.Cells[7 + i, 22] = ArrayRecordInputExcel[i, 21].ToString();
                appExcel.Cells[7 + i, 23] = ArrayRecordInputExcel[i, 22].ToString();
                range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A" + (7 + i), "W" + (7 + i));
                range.Borders.LineStyle = 1;
            }

            appExcel.Cells[7 + RsRowCount, 2] = "委托人：" + GeneralCommon.sUsername;
            appExcel.Cells[7 + RsRowCount, 4] = "委托时间：" + dateInputExcel;
            appExcel.Cells[7 + RsRowCount, 9] = "送样人：";
            appExcel.Cells[7 + RsRowCount, 14] = "送样时间：";
            workbook.PrintOut();
            appExcel.Visible = true;
            ////appExcel.Quit();//从内存中退出
            appExcel = null;  
        }

        //式样号信息更新或者委托信息发送。
        private void PRINT_Click(string plsqlPackageName, ArrayList list,string informationText)
        {
            GeneralCommon.GStatusBar.Panels[0].Text = "提示信息：操作未能成功...!!";
            string ret_Result_ErrMsg;
            //int ret_Result_ErrCode = 0;
            string ret_Result_ErrCode;
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
                adoCmd.CommandText = plsqlPackageName;
                GeneralCommon.M_CN1.BeginTrans(); 
                for (int i = 1; i <= list.Count; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    adoCmd.Parameters[i].Value = list[i].ToString() == "" ? "" : list[i].ToString();
                }

                adoCmd.Execute(out value);
                if (plsqlPackageName == "AQC1060P")
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "YY")
                    {
                        //ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrCode = (string)(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                    {
                        //ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrCode = (string)(adoCmd.Parameters["arg_e_code"].Value);
                        ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                        GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "W", this.Text);
                        Cursor.Current = Cursors.Default;
                        adoCmd = null;
                        GeneralCommon.M_CN1.RollbackTrans();
                    }
                    else
                    {
                        GeneralCommon.M_CN1.CommitTrans();
                        GeneralCommon.M_CN1.Close();
                        GeneralCommon.GStatusBar.Panels[0].Text = informationText;
                        adoCmd = null;
                        Cursor.Current = Cursors.Default;
                    }
                }
             }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "W", "警告");
            }
        }

        //委托信息发送事件。
        private void CmdSEND_Click(object sender, EventArgs e)
        {
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_smp_sent_no.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入委托单号，再发送委托信息...！", "W", "警告");
                return;
            }
            string plsqlPackageName = "AQC1060P";
            string informationText = "提示信息：委托信息已成功发送...!!!";
            list = new ArrayList();
            list.Add(txt_smp_sent_no.Text);
            list.Add("");
            PRINT_Click(plsqlPackageName, list, informationText);
        }

        //spread的ButtonClicked事件，用于第一列checkbox的点击。
        private void ss1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (ss1_Sheet1.Cells[e.Row, 0].Text == "True" && e.Column == 0)
            {
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "修改";
                ss1_Sheet1.Cells[e.Row, 28].Text = GeneralCommon.sUserID;
                ss1_Sheet1.Cells[e.Row, 29].Text = GeneralCommon.sUsername;
            }
            else if (e.Column == 0)
            {        
                ss1_Sheet1.RowHeader.Cells[e.Row, 0].Text = "";
                //string sQuery = "{call WGC3030C.P_SONEROW ( '" + ss1_Sheet1.Cells[e.Row, 2].Text.Trim() + "')}";
                //SpreadCommon.Gp_Sp_OneRowDisplay(GeneralCommon.M_CN1, sQuery, ss1, e.Row);
            }
        }

        protected override void ss_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            //base.ss_EditChange(sender, e);//覆盖源代码事件。请勿删除
        }

        protected override void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            //base.ss_CellClickEvent(sender, e);//覆盖源代码事件。请勿删除
        }

        //Spread的LeaveCell事件，假如当前行第一列checkbox的状态不为选择状态，执行行刷新。
        private void ss1_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
            if (ss1_Sheet1.Cells[e.Row, 0].Text != "True")
            {
                //string sQuery = "{call WGC3030C.P_SONEROW ( '" + ss1_Sheet1.Cells[e.Row, 2].Text.Trim() + "')}";
                //SpreadCommon.Gp_Sp_OneRowDisplay(GeneralCommon.M_CN1, sQuery, ss1, e.Row);
            }

        }

        //Spread保存事件。
        public override void Form_Pro()
        {
            int checkTrueCount = 0;
            if (ss1_Sheet1.RowCount <= 0) return;
            if (txt_check.Checked)
            {
                bool isDelete = false;
                for (int i = 0; i < ss1_Sheet1.RowCount;i++)
                {
                    if(ss1_Sheet1.RowHeader.Cells[i,0].Text == "删除")
                    {
                        isDelete = true;
                        break;
                    }
                }
                if (isDelete)
                {
                    if (GeneralCommon.Gf_MessConfirm("确定删除状态为【删除】的数据吗?", "I", "提示"))
                    {
                        base.p_Pro(1, 1, true, false);
                        reSetToolbarImages();
                    }
                    else
                    { 
                    }
                }
                
            }
            else
            {
                string sQuery = "";
                sQuery = "SELECT Gf_SMP_SEND_NO('"+txt_plt.Text.Trim()+"') FROM DUAL";
                string sampleNo = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
                if (sampleNo == "") return;

                for (int i = 0; i < ss1_Sheet1.RowCount; i++)
                {
                    if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                    {
                        checkTrueCount++;
                        ss1_Sheet1.Cells[i, 1].Text = sampleNo;
                        if (ss1_Sheet1.Cells[i, 27].Text == "")
                        {
                            ss1_Sheet1.Cells[i, 27].Text = dtp_end_date.RawDate;
                        }
                    }
                }
                if (checkTrueCount > 24)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("一张委托单不能超过24个试样...!!", "W", "警告");
                    return;
                }
                base.p_Pro(1, 1, true, false);
                reSetToolbarImages();
            }
        }

        private void Chc_OutOrder_Chk()
        {
            if (Chc_OutOrder.Checked == true)
            {
                Txt_OutOrder.Text = "1";
            }
            else
            {
                Txt_OutOrder.Text = "0";
            }
        }

        private void Chc_OutOrder_CheckedChanged(object sender, EventArgs e)
        {
            Chc_OutOrder_Chk();
        }


    }
}
