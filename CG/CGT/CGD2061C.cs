using System.Collections;
//using FarPoint.PluginCalendar;
//using InDate;
//using FarPoint.CalcEngine;
//using FarPoint.Excel;[
using System;
using System.IO;
using Microsoft.VisualBasic;
//using FarPoint.PluginCalendar.WinForms;
using CommonClass;
//using Microsoft.Office.Interop.Excel;
//using Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Net;
using System.Text;
using FarPoint.Win.Spread;
using System.Drawing;


//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   轧钢作业
//-- Program Name      探伤实绩查询_CGD2061C
//-- Program ID        CGD2061C
//-- Document No       Q-00-0010(Specification)
//-- Designer          韩超
//-- Coder             韩超
//-- Date              2017.12.29
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER           DATE                 EDITOR            DESCRIPTION
//   1.0         2017.12.29             韩超              探伤实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
namespace CG
{
    public partial class CGD2061C : CommonClass.FORMBASE
    {
        public CGD2061C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        public const string Ex_File_Name = "CGD2063C";

        const int SS1_STDSPEC = 0;
        const int SS1_LOC = 1;
        const int SS1_PLATE_NO = 2;
        const int SS1_OUT_SHEET_NO = 4;
        const int SS1_PROD_SIZE = 5;
        const int SS1_CNT = 6;
        const int SS1_BEF_APLY_STDSPEC = 7;
        const int SS1_STDSPEC_UPD_FL1 = 8;
        const int SS1_STDSPEC_UPD_FL2 = 9;
        const int SS1_UST_LEN = 10;
        const int SS1_PLATE_CUT_REASON = 11;
        const int SS1_UST_DEC = 12;
        const int SS1_PROD_GRD = 13;
        const int SS1_SURF_GRD = 14;
        const int SS1_OLD_WGT = 15;
        const int SS1_WGT = 16;
        const int SS1_UST_MACHINE_NO = 17;
        const int SS1_UST_HEAD_KIND = 18;
        const int SS1_UST_METHOD = 19;
        const int SS1_UST_STATESCOPE = 20;
        const int SS1_UST_FL = 21;
        const int SS1_UST_END_DATE = 22;
        const int SS1_EMP_CD = 23;
        const int SS1_UST_MAN = 24;
        const int SS1_PROD_DATE = 25;
        const int SS1_REMARK = 26;
        const int SS1_SHIFT = 27;
        const int SS1_GROUP_CD = 28;
        const int SS1_BED_PILE_DATE = 29;
        const int SS1_SEQ_PLACE = 30;
        const int SS1_ORD = 31;
        const int SS1_THK = 33;
        const int SS1_PRC_LINE = 34;
        const int SS1_STLGRD_CD = 35;
        const int SS1_STLGRD = 36;
        const int SS1_PROC_CD = 37;
        const int SS1_CUST_CD = 38;
        const int SS1_SIZE = 39;
        const int SS1_URGNT_FL = 44;
        //紧急订单绿色标记 2012-08-16  by  LiQian
        const int SS1_IMP_CONT = 53;

        const int SS1_ORD_REPORT = 55;
        const int SS1_STD_FLAG = 56; //牌号
        const int SS1_APLY_STDPEC = 57; //标准号

        //ftp同步下载文件功能设置
        static private string path = @"ftp://" + "191.168.160.11" + @"/nisco_develop/vb_exe/";    //目标路径
        static private string ftpip = "191.168.160.11";    //ftp IP地址
        static private string username = "l3";   //ftp用户名
        static private string password = "l3devl";   //ftp密码

        #region 界面初始化

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;

            p_SetMc("开始日期", SDT_PROD_DATE_FROM, "PN", "", "", "", "", imcseq);//0
            p_SetMc("结束日期", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);//1
            p_SetMc("", TXT_UST_STAND_NO, "P", "", "", "", "", imcseq);//2
            p_SetMc("", CBO_SHIFT, "P", "", "", "", "", imcseq);//3
            p_SetMc("", CBO_UST_DEC, "P", "", "", "", "", imcseq);//4
            p_SetMc("", SDB_UST_THK, "P", "", "", "", "", imcseq);//5
            p_SetMc("", SDB_UST_THK_TO, "P", "", "", "", "", imcseq);//6
            p_SetMc("", SDB_UST_WID, "P", "", "", "", "", imcseq);//7
            p_SetMc("", SDB_UST_WID_TO, "P", "", "", "", "", imcseq);//8
            p_SetMc("", SDB_UST_LEN, "P", "", "", "", "", imcseq);//9
            p_SetMc("", SDB_UST_LEN_TO, "P", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_STDSPEC, "P", "", "", "", "", imcseq);//11
            p_SetMc("", TXT_MAT_NO, "P", "", "", "", "", imcseq);//12
            p_SetMc("", TXT_CO_CD, "P", "", "", "", "", imcseq);//13
            p_SetMc("", txt_f_addr, "P", "", "", "", "", imcseq);//14
            //p_SetMc("", SDB_WGT, "P", "", "", "", "", imcseq);//15
            p_SetMc("", CBO_EMP, "P", "", "", "", "", imcseq);//15
            p_SetMc("", CBO_SURFGRD, "P", "", "", "", "", imcseq);//16
           

            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("钢板号", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("坯料类别", "E", "60", "IL", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("轧批号", "E", "20", "IL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("规格尺寸(mm)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("块数", "E", "1", "IL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("改判标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("改判原因1", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//8
            p_SetSc("改判原因2", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//9
            p_SetSc("剪前长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("反剪原因", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("结论", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("原始重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("实绩重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("仪器型号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("探头", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("探头方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("探伤灵敏度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("检查标准", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//21
            p_SetSc("探伤日", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("探伤人员", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("录入人员", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//24
            p_SetSc("生产时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L");//26
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//27
            p_SetSc("班别", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//28
            p_SetSc("入库日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("切割场地", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//31
            p_SetSc("原始订单号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//32
            p_SetSc("铸坯厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("连铸机号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("铸坯钢种代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("铸坯钢种名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//36
            p_SetSc("进程状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("客户名称", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//38
            p_SetSc("定尺区分", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("堆冷时间（小时）", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("经RH", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("异常坯", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("炉座号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("在炉时间", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("出炉温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("板坯切割时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("精轧结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//49
            p_SetSc("轧制班别", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//50
            p_SetSc("加热段驻段时间", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//51
            p_SetSc("均热段驻段时间", "E", "10", "L", "", "", "", iscseq, iheadrow, "L");//52
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("订单探伤要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//54
           
            //iheadrow = 0;
            //p_spanSpread("作业指示/实绩", 31, 33, iscseq, iheadrow, 1);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2061NC";
            
            Form_Define();

            downftp(path, "USTSIGNS", System.Windows.Forms.Application.StartupPath + "\\report\\");

            downftp(path, "USTSIGNS", System.Windows.Forms.Application.StartupPath + "\\");

            SSCommand1.Enabled = true;

            SDT_PROD_DATE_FROM.RawDate = DateTime.Now.ToString("yyyyMMdd");
            SDT_PROD_DATE_TO.RawDate = DateTime.Now.ToString("yyyyMMdd");

        }
        #endregion

        public override void Form_Ref()
        {
            int iCount;
            //    Dim bCount          As Integer
            double dMillCal_Wgt;
            string simpcont;
            //    Dim ord_no As String
            //    Dim std_flag As String

            p_Ref(1,1,true,true);

            if (ss1.ActiveSheet.RowCount == 0)
            {
                return;
            }

            SDB_WGT.NumValue = 0;

            dMillCal_Wgt = 0;
           
                
                for (iCount = 1; iCount <= ss1.ActiveSheet.RowCount; iCount++)
                {
                    if (ss1.ActiveSheet.Cells[iCount - 1, SS1_WGT].Text == "0")
                    {
                        dMillCal_Wgt = dMillCal_Wgt +  convertX(ss1.ActiveSheet.Cells[iCount - 1, SS1_OLD_WGT].Text);
                    }
                    else
                    {
                        dMillCal_Wgt = dMillCal_Wgt + convertX(ss1.ActiveSheet.Cells[iCount - 1, SS1_OLD_WGT].Text);
                    }

                    //紧急订单绿色标记 2012-08-16  by  LiQian
                    if (ss1.ActiveSheet.Cells[iCount - 1, SS1_URGNT_FL].Text == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_STDSPEC, SS1_STDSPEC, iCount-1, iCount-1, Color.Green,Color.White);
                    }

                    simpcont = ss1.ActiveSheet.Cells[iCount - 1, SS1_IMP_CONT].Text;

                    if (simpcont == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, SS1_PLATE_NO, SS1_PLATE_NO, iCount-1, iCount-1, SSP4.BackColor,Color.White);
                        Gp_Sp_BlockColor(ss1, SS1_IMP_CONT, SS1_IMP_CONT, iCount-1, iCount-1, SSP4.BackColor,Color.White);
                    } 
                }
            
            SDB_WGT.NumValue = dMillCal_Wgt;
           
        }
        ///探伤报告
        private void SSCommand1_Click(object sender, EventArgs e)
        {
            //if (this.TXT_UST_STAND_NO.Text == "")
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("检查标准必须输入...!", "W", "提示");
            //    return;
            //}
            if (ss1.ActiveSheet.RowCount == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("没有数据不可导出探伤报告...!", "W", "提示");
                return;
            }

            string modelName = "UST0003.xls";
            Gp_CopyModel(modelName);
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

            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.get_Item(1);

            string sDate;
            sDate = SDT_PROD_DATE_FROM.RawDate;
            int COUNT;
            string cellMerge;
            string cellBold;
            Microsoft.Office.Interop.Excel.Range range;

            //如果用户没有选择时间，则自动获取当前系统时间
            if (sDate == "" || sDate.Length < 8)
            {
                sDate = DateTime.Now.ToString("yyyyMMdd");
            }
            //写入日期
            appExcel.Cells[6, 5] = sDate.Substring(0, 4) + "年" + sDate.Substring(4, 2) + "月" + sDate.Substring(6, 2) + "日";
            appExcel.Cells[7, 5] = sDate.Substring(0, 4) + sDate.Substring(4, 2) + sDate.Substring(6, 2);

            //EXCEL检测单位中文
            appExcel.Cells[6, 2] = cbx_plt.Text;
            //EXCEL检测单位英文
            if (cbx_plt.Text == "中板厂")
            {
                appExcel.Cells[7, 2] = "Medium Plate Plant";
            }
            else if (cbx_plt.Text == "中厚板卷厂")
            {
                appExcel.Cells[7, 2] = "Plate/coil Plant";
            }
            else if (cbx_plt.Text == "宽厚板厂")
            {
                appExcel.Cells[7, 2] = "Heavy Plate Plant";
            }
            //报告编号
            //appExcel.Cells[6, 6] = "JL321106/B";
            //appExcel.Cells[7, 6] = "JL321106/B";
            //仪器型号
            appExcel.Cells[8, 2] = cbx_ins.Text;
            //探头型号
            appExcel.Cells[8, 4] = cbx_probe.Text;
            //晶片尺寸
            appExcel.Cells[8, 6] = cbx_chip.Text;
            //探头频率
            appExcel.Cells[8, 8] = cbx_rate.Text;
            //探头焦距
            appExcel.Cells[9, 2] = cbx_focus.Text;
            //试块型号
            appExcel.Cells[9, 4] = cbx_type.Text;
            //试块尺寸
            appExcel.Cells[9, 6] = cbx_size.Text;
            //耦合剂
            appExcel.Cells[9, 8] = txt_couplant.Text;
            //耦合方式
            appExcel.Cells[10, 2] = cbx_style.Text;
            //检测方法
            appExcel.Cells[10, 4] = cbx_test.Text;
            //检测比例
            appExcel.Cells[10, 6] = cbx_scale.Text;
            //扫查方向
            appExcel.Cells[10, 8] = cbx_direction.Text;
            //灵敏度
            appExcel.Cells[11, 2] = txt_sens.Text;
            //表面补偿
            appExcel.Cells[11, 4] = txt_comp.Text;
            //检测标准
            appExcel.Cells[11, 6] = TXT_UST_STAND_REPORT.Text;
            //验收级别
            appExcel.Cells[11, 8] = TXT_UST_GRADE.Text;
            //签发员
            appExcel.Cells[7, 10] = cbx_sign.Text;
            //等级
            appExcel.Cells[7, 11] = cbx_level.Text;

            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                COUNT = i + 19 + 1;

                appExcel.Cells[COUNT, 1] = i + 1;//序号
                appExcel.Cells[COUNT, 2] = ss1.ActiveSheet.Cells[i, SS1_PLATE_NO].Text;//产品编号 钢板号
                appExcel.Cells[COUNT, 3] = ss1.ActiveSheet.Cells[i, SS1_PROD_SIZE].Text;//规格
                appExcel.Cells[COUNT, 4] = ss1.ActiveSheet.Cells[i, SS1_APLY_STDPEC].Text;//牌号
                appExcel.Cells[COUNT, 5] = TXT_UST_GRADE.Text;//评定结果
                appExcel.Cells[COUNT, 6] = cbx_result.Text;//检查结论
                appExcel.Cells[COUNT, 7] = ss1.ActiveSheet.Cells[i, SS1_EMP_CD].Text;//检测员

                //合并单元格
                range = worksheet.Range[worksheet.Cells[COUNT, 7], worksheet.Cells[COUNT, 8]];

                //range.ClearContents(); //先把Range内容清除，合并才不会出错
                range.MergeCells = true;

                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                range = worksheet.Range[worksheet.Cells[COUNT, 1], worksheet.Cells[COUNT, 8]];

                //边框设定
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;//设置边框
                range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;//设置粗细

            }
            appExcel.Visible = true;
            // appExcel.Quit();//从内存中退出
            appExcel = null;
        }

        private void Gp_CopyModel(string FileName)
        {
            string currentPath = System.Windows.Forms.Application.StartupPath;//E:\包含源码\最新\NGHB\BDM\bin\Debug
            string currentModelPath = currentPath + "\\model";//E:\包含源码\最新\NGHB\BDM\bin\Debug\model
            string filePath = currentModelPath + "\\" + FileName;//E:\包含源码\最新\NGHB\BDM\bin\Debug\model\vv.txt
            string currentReportPath = currentPath + "\\report";//E:\包含源码\最新\NGHB\BDM\bin\Debug\report

            if (File.Exists(filePath))//判断文件是否存在
            {
                string destPath = Path.Combine(currentReportPath, Path.GetFileName(filePath));//E:\包含源码\最新\NGHB\BDM\bin\Debug\report\vv.txt
                System.IO.File.Delete(destPath);//E:\包含源码\最新\NGHB\BDM\bin\Debug\report\vv.txt
                System.IO.File.Copy(filePath, destPath);
            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("没有该文件，请检查输入的文件名...!", "W", "警告");
                return;
            }
        }

        /// <summary>  
        /// 单个文件下载方法  
        /// </summary>  
        /// <param name="adss">保存文件的本地路径</param>  
        /// <param name="ftpadss">下载文件的FTP路径</param>  
        public void download(string adss, string ftpadss)
        {
            //FileMode常数确定如何打开或创建文件,指定操作系统应创建新文件。  
            //FileMode.Create如果文件已存在，它将被改写  
            
            FileStream outputStream = new FileStream(adss, FileMode.Create);
            FtpWebRequest downRequest = (FtpWebRequest)WebRequest.Create(new Uri(ftpadss));

            //设置要发送到 FTP 服务器的命令  
            downRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            downRequest.UseBinary = true;
            downRequest.Credentials = new NetworkCredential(username, password);
            downRequest.UsePassive = true;

            FtpWebResponse response = (FtpWebResponse)downRequest.GetResponse();
            Stream ftpStream = response.GetResponseStream();
            long cl = response.ContentLength;
            int bufferSize = 2048;
            int readCount;
            byte[] buffer = new byte[bufferSize];
            readCount = ftpStream.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                outputStream.Write(buffer, 0, readCount);
                readCount = ftpStream.Read(buffer, 0, bufferSize);
            }
            ftpStream.Close();
            outputStream.Close();
            response.Close();
        }

        /// </summary>  
        /// <param name="ftpads">FTP地址路径</param>  
        /// <param name="name">我们所选择的文件或者文件夹名字</param>  
        /// <param name="type">要发送到FTP服务器的命令</param>  
        /// <returns></returns>  
        public string[] ftp(string ftpads, string name, string type)
        {
            WebResponse webresp = null;
            StreamReader ftpFileListReader = null;
            FtpWebRequest ftpRequest = null;
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(new Uri(ftpads + name));
                ftpRequest.Method = type;

                ftpRequest.UseBinary = true;
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.UsePassive = true;

                webresp = ftpRequest.GetResponse();
                ftpFileListReader = new StreamReader(webresp.GetResponseStream(), Encoding.Default);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            StringBuilder str = new StringBuilder();
            string line = ftpFileListReader.ReadLine();
            while (line != null)
            {
                str.Append(line);
                str.Append("\n");
                line = ftpFileListReader.ReadLine();
            }
            string[] fen = str.ToString().Split('\n');
            return fen;
        }

        /// <summary>  
        /// 下载方法 
        /// </summary>  
        /// <param name="ftpads">FTP路径</param>  
        /// <param name="name">需要下载文件路径</param>  
        /// <param name="Myads">保存的本地路径</param>  
        public void downftp(string ftpads, string name, string Myads)
        {
            string downloadDir = Myads;
            //string ftpdir = ftpads + name;

            string[] fileNames = { "hlm.png", "ydr.png", "zk.png" };

            bool flag = false;

            string picPath = downloadDir + "USTSIGNS\\";

            if (!Directory.Exists(downloadDir + "USTSIGNS"))
            {
                Directory.CreateDirectory(downloadDir + "USTSIGNS");
            }

            foreach (string fileName in fileNames)
            {
                if (!File.Exists(picPath + fileName))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return;
            }

            string[] onlyname = ftp(ftpads, name, WebRequestMethods.Ftp.ListDirectory);

            foreach (string onlynames in onlyname)
            {
                if (onlynames == "" || onlynames == " ")
                {
                    break;
                }
                else
                {   
                    download(downloadDir + onlynames, ftpads + onlynames);   
                }
            }
        }

        private void SSCommand2_Click(object sender, EventArgs e)
        {
            try
            {
                string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板导出Excel文件夹";
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
            string sourceExcelName = System.Windows.Forms.Application.StartupPath + "\\model" + "\\CGD2063C.xls";

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
            sDate1 = SDT_PROD_DATE_FROM.RawDate;
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
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_UST_DEC].Text;//结论
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_ORD].Text;//订单号
                        appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE].Text;//定尺区分
                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text);
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
                        appExcel.Cells[k, 1] = this.ss1.ActiveSheet.Cells[j, SS1_LOC].Text;//货位
                        appExcel.Cells[k, 2] = this.ss1.ActiveSheet.Cells[j, SS1_STDSPEC].Text;//品种
                        appExcel.Cells[k, 3] = this.ss1.ActiveSheet.Cells[j, SS1_PROC_CD].Text;//进程状态
                        appExcel.Cells[k, 4] = this.ss1.ActiveSheet.Cells[j, SS1_PLATE_NO].Text;//钢板号
                        appExcel.Cells[k, 5] = this.ss1.ActiveSheet.Cells[j, SS1_PROD_SIZE].Text;//规格尺寸
                        appExcel.Cells[k, 6] = this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text;//重量
                        appExcel.Cells[k, 7] = this.ss1.ActiveSheet.Cells[j, SS1_UST_DEC].Text;//结论
                        appExcel.Cells[k, 8] = this.ss1.ActiveSheet.Cells[j, SS1_CUST_CD].Text;//客户名称
                        appExcel.Cells[k, 9] = this.ss1.ActiveSheet.Cells[j, SS1_ORD].Text;//订单号
                        appExcel.Cells[k, 10] = this.ss1.ActiveSheet.Cells[j, SS1_SIZE].Text;//定尺区分

                        Weight = Weight + Convert.ToDouble(this.ss1.ActiveSheet.Cells[j, SS1_WGT].Text);

                        k = k + 1;
                    }

                    appExcel.Cells[sRow1, 3] = Weight.ToString();
                    appExcel.Cells[sRow3, 3] = sPage_Num.ToString();
                }
            }

        }

        # region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }
            if (iDateCheck == "")
            {
                return false;
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate);
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 6))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {

            if (DTCheck == "D")
            {
                DTCheck = "D";
            }
            else
            {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        //解锁指定列
        public void unlockColumn(FpSpread e, int[] columns)
        {
            FarPoint.Win.Spread.SheetView with_1 = e.ActiveSheet;

            foreach (int i in columns)
            {
                with_1.Columns[i].Locked = false;

            }
        }

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion

    }
}
