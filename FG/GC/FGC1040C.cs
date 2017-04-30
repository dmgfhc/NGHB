using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;
using Microsoft.Office.Interop.Excel;
using System.IO;

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            热处理实绩查询(装炉时间)界面                               
///-- 程序ID            FGC1020C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              李超                                                    
///-- 代码              李超                                                     
///-- 代码日期          2014.08.14                                                
///-- 处理描述          热处理实绩查询(装炉时间)界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.08.14        李超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1040C : CommonClass.FORMBASE
    {
        public FGC1040C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int SPD_LOC = 12,
                  SPD_STDSPEC = 8,
                  SPD_PROC_CD = 7,
                  SPD_PLATE_NO = 0,
                  SPD_PROD_SIZE = 10,
                  SPD_WGT = 11,
                  SPD_S = 13,
                  SPD_CUST_CD = 21,
                  SPD_STDSPEC_UPD_FL1 = 20;

        public const string Ex_File_Name = "FGC1040C";


        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("产线", TXT_PRC_LINE, "PN", "", "", "", "", imcseq);
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "PN", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("号", TXT_PROD_CD, "P", "", "", "", "", imcseq);
            p_SetMc("工序", TXT_PRC, "P", "", "", "", "", imcseq);
            p_SetMc("库", TXT_CUR, "P", "", "", "", "", imcseq);
            p_SetMc("垛位", TXT_LOC, "P", "", "", "", "", imcseq);
            p_SetMc("入库时间", SDT_CUR_IN, "P", "", "", "", "", imcseq);
            p_SetMc("入库时间", SDT_CUR_OUT, "P", "", "", "", "", imcseq);



            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("物料号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("轧批号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("矫直时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("矫直序号", "E", "5", "PIL", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("矫直种类", "E", "3", "IL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("产线别", "E", "1", "IL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("机座号", "E", "1", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("进程代码", "E", "5", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("尺寸规格(mm)", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("定尺区分", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("入口辊缝", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("出口辊缝", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("倾斜度", "N", "3", "AI", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("矫直速度", "N", "8,4", "I", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("矫直温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("道次数", "E", "10", "I", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("订单号", "E", "15", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("客户名称", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("入库日期", "D", "", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("作业人员", "E", "10", "IL", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("热处理指示/实绩", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("探伤指示/实绩", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("产品等级", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("表面等级", "E", "2", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("不平度", "N", "2", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("缺陷", "E", "20", "L", "", "", "", iscseq, iheadrow, "R");//32
            

            //SpreadCommon.Gp_Sp_ColHidden(ss1, 1, true);


             }


        private void SSCommand2_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢宽厚板导出Excel文件夹";
                string targetExcelName = currentReportPath + "\\" + Ex_File_Name + ".xls";
                resetExcelName(currentReportPath, targetExcelName);
                int rowCount = ss1.ActiveSheet.RowCount;
                setExcelText(targetExcelName, rowCount);
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.ToString(), "W", "警告");
            }
        }

        private void resetExcelName(string currentReportPath, string targetExcelName)
        {
            if (!Directory.Exists(currentReportPath))
            {
                Directory.CreateDirectory(currentReportPath);
            }
            string sourceExcelName = System.Windows.Forms.Application.StartupPath  + "\\FGC1040C.xls";

            if (File.Exists(targetExcelName))
            {
                File.Delete(targetExcelName);
            }
            File.Copy(sourceExcelName, targetExcelName);
        }

        private void setExcelText(string targetExcelName, int rowCount)
        {
            Microsoft.Office.Interop.Excel.Application appExcel = null;
            appExcel = new Microsoft.Office.Interop.Excel.Application();
            appExcel.DisplayAlerts = true;
            appExcel.AlertBeforeOverwriting = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = appExcel.Workbooks.Open(targetExcelName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            string sShift;
            string sDate1;
            string sDate2;
            string sDate;
            int sPage_Num = 30;
            int sPage_X = 32;
            int sPage;
            int sLastPage;
            double Weight;
            int sRow1;
            int sRow2;
            int sRow3;
            sDate1 = SDT_PROD_DATE_FR.RawDate;
            sDate2 = SDT_PROD_DATE_TO.RawDate;
            sDate = "日期：";

            if (sDate1 != "" && sDate2 != "")
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日" + " - " + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日";
            }

            if (sDate1 != "" && sDate2 == "")
            {
                sDate = "日期：" + sDate1.Substring(0, 4) + "年" + sDate1.Substring(4, 2) + "月" + sDate1.Substring(6, 2) + "日";
            }



            sShift = "";
            if (CBO_SHIFT.Text == "1")
            {
                sShift = "大夜班";
            }
            else if (CBO_SHIFT.Text == "2")
            {
                sShift = "白班";
            }
            else if (CBO_SHIFT.Text == "3")
            {
                sShift = "小夜班";
            }

            //堆码员
            string codeName = "select EMP_NAME from zp_employee t where t.emp_id =" + "'" + GeneralCommon.sUserID + "'";
            appExcel.Cells[2, 5] = "码堆员：" + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, codeName);
            //班次
            appExcel.Cells[2, 3] = "班次：" + sShift;
            sPage = Convert.ToInt32(rowCount / sPage_Num) + 1;
            sLastPage = rowCount - Convert.ToInt32(rowCount / sPage_Num) * sPage_Num;
            sPage = sPage - 1;
            //日期
            appExcel.Cells[2, 1] = sDate;
            for (int i = 0; i <= sPage; i++)
            {
                int k = 4 + i * sPage_X;
                sRow1 = 35 + sPage_X * i;
                sRow3 = 34 + sPage_X * i;
                Weight = 0;
                if (i == sPage)
                {
                    sRow2 = sPage_Num * i + sLastPage;

                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SPD_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SPD_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SPD_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SPD_PROD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SPD_S].Text;//定尺区分
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SPD_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC_UPD_FL1].Text;//订单号
                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text);
                        k = k + 1;
                    }
                    appExcel.Cells[sRow1, 3] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sLastPage.ToString();
                    appExcel.Visible = true;
                    //  appExcel.Quit();//从内存中退出
                    appExcel = null;
                    return;
                }
                else
                {
                    sRow2 = sPage_Num * i + sPage_Num;
                    for (int j = sPage_Num * i; j < sRow2; j++)
                    {
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SPD_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SPD_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SPD_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SPD_PROD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SPD_S].Text;//定尺区分
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SPD_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SPD_STDSPEC_UPD_FL1].Text;//订单号

                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SPD_WGT].Text);

                        k = k + 1;
                    }

                    appExcel.Cells[sRow1, 3] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sPage_Num.ToString();
                }
            }



        }

        private void FGC1040C_Load(object sender, EventArgs e)
        {
            Form_Define();
            rdo_mat.Checked = true;
            rdo_hcl.Checked = true;
            if (rdo_mat.Checked == true)
            {
                TXT_PROD_CD.Text = "SL";
            };
            if (rdo_hcl.Checked == true)
            {
                TXT_PRC.Text = "H";
            };
            //TXT_PROD_CD.Text = "SL";
            TXT_PRC_LINE.Text = "1";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();

            if (rdo_mat.Checked == true)
            {
                TXT_PROD_CD.Text = "SL";
            };
            if (rdo_out.Checked == true)
            {
                TXT_PROD_CD.Text = "LO";
            }
            if (rdo_hcl.Checked == true)
            {
                TXT_PRC.Text = "H";
            };
            if (rdo_ccl.Checked == true)
            {
                TXT_PRC.Text = "F";
            }

            TXT_PRC_LINE.Text = "1";
            return true;
        }

        private void rdo_mat_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "SL";
            rdo_mat.ForeColor = System.Drawing.Color.Red;
            rdo_out.ForeColor = System.Drawing.Color.Black;
        }

        private void rdo_hcl_Click(object sender, EventArgs e)
        {
            TXT_PRC.Text = "H";
            rdo_hcl.ForeColor = System.Drawing.Color.Red;
            rdo_ccl.ForeColor = System.Drawing.Color.Black;
        }

        private void rdo_out_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "LO";
            rdo_out.ForeColor = System.Drawing.Color.Red;
            rdo_mat.ForeColor = System.Drawing.Color.Black;
        }

        private void rdo_ccl_Click(object sender, EventArgs e)
        {
            TXT_PRC.Text = "F";
            rdo_ccl.ForeColor = System.Drawing.Color.Red;
            rdo_hcl.ForeColor = System.Drawing.Color.Black;
        }
     }

  }
   

#endregion