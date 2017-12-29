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
            p_SetMc("", SDB_WGT, "P", "", "", "", "", imcseq);//15
            p_SetMc("", CBO_EMP, "P", "", "", "", "", imcseq);//16
            p_SetMc("", CBO_SURFGRD, "P", "", "", "", "", imcseq);//17
           

            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("探伤垛位", "E", "20", "L", "", "", "", iscseq, iheadrow);//1
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("进程代码", "E", "18", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("尺寸", "E", " ", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("块数", "N", "8", "L", "", "", "", iscseq, iheadrow, "M");//5         
            p_SetSc("改判标准号", "E", "14", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("改判原因", "E", "20", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("结论", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("产品等级", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("表面等级", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("仪器型号", "E", "50", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("探头", "E", "50", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("探伤方式", "E", "50", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("探伤灵敏度", "E", "30", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("检查标准", "E", " ", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("探伤时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("探伤班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("探伤人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("轧制时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("生产时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//20
            p_SetSc("备注", "E", " ", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("切割", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("矫直", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//23         
            p_SetSc("热处理", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("定尺区分", "E", " ", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("取样代码", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("库", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("垛位", "E", "10", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("入库时间", "DT", "14", "L", "", "", "", iscseq, iheadrow, "L");//29
            p_SetSc("缺陷", "E", "18", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("厚度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("宽度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("实绩重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow, "R");//34     
            p_SetSc("订单号", "E", " ", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("原始订单号", "E", " ", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("板坯厚度", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("连铸机号", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("板坯钢种代码", "E", "11", "L", "", "", "", iscseq, iheadrow, "M");//39
            p_SetSc("板坯钢种名称", "E", "11", "L", "", "", "", iscseq, iheadrow);//40
            p_SetSc("堆冷时间(小时)", "N", "8", "L", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("经RH", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("异常坯", "E", " ", "L", "", "", "", iscseq, iheadrow);//43
            p_SetSc("炉座号", "E", " ", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("在炉时间", "E", " ", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("出炉温度", "E", " ", "L", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("板坯切割时间", "DT", " ", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("矫直机号", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//48
            p_SetSc("矫直入口温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//49
            p_SetSc("矫直出口温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("订单探伤要求", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("钢板堆冷时间", "N", "5,1", "L", "", "", "", iscseq, iheadrow, "R");//52
            p_SetSc("轧制至探伤间隔", "N", "5,1", "L", "", "", "", iscseq, iheadrow, "R");//53
            p_SetSc("其它", "E", "140", "L", "", "", "", iscseq, iheadrow, "L");//54
            p_SetSc("标准号", "E", "18", "L", "", "", "", iscseq, iheadrow, "L");//55

            iheadrow = 0;
            p_spanSpread("作业指示/实绩", 31, 33, iscseq, iheadrow, 1);
        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            Form_Define();
            //ss1.ActiveSheet.RowCount = 205;
            //ss1.ActiveSheet.ColumnCount = 44;
            //for (int i = 0; i < 205; i++)
            //{
            //    for (int j = 0; j < 44; j++)
            //    {
            //        ss1.ActiveSheet.Cells[i, j].Text = "2";
            //    }
            //}

            downftp(path, "USTSIGNS", System.Windows.Forms.Application.StartupPath + "\\report\\");

            downftp(path, "USTSIGNS", System.Windows.Forms.Application.StartupPath + "\\");

            SSCommand1.Enabled = true;

        }
        #endregion

        public override void Form_Ref()
        {
            this.SDB_WGT.Text = "";
            double sumSlabWeight = 0;//实绩重量合计
            base.p_Ref(1, 1, true, true);
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                sumSlabWeight += (ss1.ActiveSheet.Cells[i, 34].Text == "" ? 0 : double.Parse(ss1.ActiveSheet.Cells[i, 34].Text));
                this.SDB_WGT.Text = sumSlabWeight.ToString();
            }
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

            string modelName = "UST0002.xls";
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
                appExcel.Cells[COUNT, 2] = ss1.ActiveSheet.Cells[i, 2].Text;//产品编号 钢板号
                appExcel.Cells[COUNT, 3] = ss1.ActiveSheet.Cells[i, 4].Text;//规格
                appExcel.Cells[COUNT, 4] = ss1.ActiveSheet.Cells[i, 55].Text;//牌号
                appExcel.Cells[COUNT, 5] = TXT_UST_GRADE.Text;//评定结果
                appExcel.Cells[COUNT, 6] = cbx_result.Text;//检查结论
                appExcel.Cells[COUNT, 7] = ss1.ActiveSheet.Cells[i, 18].Text;//检测员

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

        ///码堆报告














    }
}
