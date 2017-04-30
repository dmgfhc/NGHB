using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;


namespace DownLoad
{
    public partial class DownLoadMain : Form
    {
        

        public string sServerIP;
        //SERVER IP 
        public string sServerID;
        //SERVER ID 
        public string sServerPWD;
        //SERVER PASSWORD 
        public string sServerPATH;
        //SERVER PATH 
        public int sServerPORT;
        //SERVER PORT 
        public double FILE_SIZE;
        //FILE SIZE 
         
        public static string sExePath;

        private const string ProcessesName = "LGJHY";
        private const string RegLocation = "WKLGJHY";

        public DownLoadMain()
        {
            InitializeComponent();
        }

        private void DownLoadMain_Load(object sender, System.EventArgs e)
        {           
            try
            {
                GeneralCommon.Gp_LogTxt("DownLoad DownLoadMain_Load 00");
                sExePath = System.IO.Directory.GetCurrentDirectory() + "\\";              
                this.KeyPreview = true;
                GeneralCommon.Gp_FormCenter(this);               

                // Sets the timer interval to 5 seconds. 
                Timer_Conut.Interval = 1000;
                Timer_Conut.Start();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_LogData("DownLoadMain_Load "+ex.Message);                
            }

        }
        
      
        //============================================================================================== 
        // Procedure Name : Server_Info 
        // Description : get server info from BZA_SERVINF table 
        //============================================================================================== 
        private bool Server_Info()
        {
            bool functionReturnValue = false;

            string sQuery = "{call PKG_MAIN.P_SERVER ()}";
            try
            {
                DataTable DT_temp = GeneralCommon.Gf_ExecProc2Ref(sQuery);
                if (DT_temp.Rows.Count > 0)
                {                    
                    sServerIP = DT_temp.Rows[0][0].ToString().Trim();                   
                    sServerID = DT_temp.Rows[0][1].ToString().Trim();
                    sServerPWD = DT_temp.Rows[0][2].ToString().Trim();
                    sServerPATH = DT_temp.Rows[0][3].ToString().Trim();
                    sServerPORT = Convert.ToInt32(DT_temp.Rows[0][4].ToString().Trim());
                    functionReturnValue = true;
                }
            }
            catch
            {

            }
            return functionReturnValue;

        }

        //============================================================================================== 
        // Procedure Name : GetFileInfo 
        // Description : 获取所有文件信息 
        //============================================================================================== 
        private ArrayList GetFileInfo()
        {
            ArrayList functionReturnValue = new ArrayList();
            string sQuery = "{call PKG_MAIN.P_GETFILEINFO()} ";
            try
            {
                DataTable DT_temp = GeneralCommon.Gf_ExecProc2Ref(sQuery);
                if (DT_temp.Rows.Count > 0)
                {
                    for (int i = 0; i < DT_temp.Rows.Count; i++)
                        functionReturnValue.Add(DT_temp.Rows[i][0].ToString().Trim());
                }
            }
            catch
            {

            }
            return functionReturnValue;

        }

        //============================================================================================== 
        // Procedure Name : DownLoad_File 
        // Description : 下载所有更新文件 
        //============================================================================================== 
        private bool DownLoad_File(ArrayList WinId)
        {
            //return true;
            bool functionReturnValue = false;
            if (MainMenu_Check())
            {
                if (MessageBox.Show("检验室程序正在运行，是否要关闭？关闭前请保存当前操作以免丢失数据。", "更新提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Process[] myProcess = null;
                    myProcess = Process.GetProcessesByName(ProcessesName);
                    foreach (Process myPro in myProcess)
                    {                       
                            myPro.Kill();                      
                    }
                }
                else
                {
                    return true; ;
                }
            }

            if (WinId == null)
                return true;


           


            string sQuery = null;
            int i = 0;
            string Client_Ver = null;
            string Server_Ver = null;

       
            FILE_SIZE = 0;

          

            functionReturnValue = false;

            try
            {
                //check ftp server info 
                if (string.IsNullOrEmpty(sServerIP) | string.IsNullOrEmpty(sServerID) | string.IsNullOrEmpty(sServerPWD) | string.IsNullOrEmpty(sServerPATH)) //
                {
                    GeneralCommon.Gp_MsgBoxDisplay("FTP服务器信息不存在...!!", "W");
                    return false;
                }

                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();

                //check download folder 
                if (!System.IO.Directory.Exists(sExePath))
                {
                    System.IO.Directory.CreateDirectory(sExePath);
                }
             

                this.pic_Close.Visible = false;
                Label1.Visible = true;
                Label1.Text = "程序更新中，请勿关闭";

                for (i = 0; i < WinId.Count; i++)
                {

                    //Server Version 
                    sQuery = "{call PKG_MAIN.P_FIND_VER('" + WinId[i] + "')}";
                    Server_Ver = GeneralCommon.Gf_CodeFind(sQuery);
 
                    //Client Version 
                    Client_Ver = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\"+RegLocation+@"\VERSION\").GetValue(WinId[i].ToString(), "0.0.0").ToString();// Interaction.GetSetting("CYEDM", "VERSION", WinId[i], "0.0.0");

                    if (Server_Ver != Client_Ver | !System.IO.File.Exists(sExePath + WinId[i]))
                    {

                        //Client File Delete 
                        if (System.IO.File.Exists(sExePath + WinId[i]))
                        {
                            System.IO.File.Delete(sExePath + WinId[i]);
                        }
                        int point = WinId[i].ToString().LastIndexOf(@"\");
                        string spath = sExePath;
                        string sysname = "";
                        if (point > 0)
                        {
                            spath = sExePath + WinId[i].ToString().Substring(0, point);
                            if (System.IO.Directory.Exists(spath) == false)
                            {

                                System.IO.Directory.CreateDirectory(spath);// FileSystem.MkDir(spath);
                            }
                            sysname = WinId[i].ToString().Substring(point + 1);
                        }
                        FTPClient ftp = new FTPClient(sServerIP, sServerPATH, sServerID, sServerPWD, sServerPORT);
                        if (ftp.Get(WinId[i].ToString(), sExePath, WinId[i].ToString()))
                        {
                            Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\" + RegLocation + @"\VERSION\").SetValue(WinId[i].ToString(), Server_Ver);
                        }
                        else
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("下载文件出错 : " +ftp.strReply);
                            GeneralCommon.Gp_LogData(WinId[i].ToString()+ " " + ftp.strReply);
                        }

                    }
                }

                PrgDown.Visible = false;
                pic_Close.Visible = true;

                Label1.Visible = false;
                functionReturnValue = true;
                Cursor.Current = Cursors.Default;

                Application.DoEvents();
            }
            catch (Exception ex)
            {
                PrgDown.Visible = false;

                GeneralCommon.Gp_MsgBoxDisplay("下载文件 Error : " + ex.Message);

                Cursor.Current = Cursors.Default;

                Application.DoEvents();
            }

            return functionReturnValue;
        }

        private bool UpdateInfo(ArrayList WinId)
        {
            try
            {

                if (WinId == null || WinId.Count == 0)
                {
                    return false;
                }
                string sQuery = "";
                string Server_Ver = "";               
                string Client_Ver = null;
                if (Server_Info() == false)
                {
                    Label1.Visible = true;
                    Label1.Text = "服务器连接超时，请检查";
                    return false;
                }
                else
                {
                    for (int i = 0; i < WinId.Count; i++)
                    {
                        sQuery = "{call PKG_MAIN.P_FIND_VER('" + WinId[i] + "')}";
                        Server_Ver = GeneralCommon.Gf_CodeFind(sQuery);

                        //Client Version 
                        Client_Ver = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\" + RegLocation + @"\VERSION\").GetValue(WinId[i].ToString(), "0.0.0").ToString();

                        if (Server_Ver != Client_Ver | !System.IO.File.Exists(sExePath + WinId[i]))
                        {                          
                            return true;
                        }
                    }
                  
                     return true;
                   
                }
            }
            catch //(System.Exception e)
            {
                return false;
            }
        }
    
        private void ExeMain()
        {
             GeneralCommon.Gp_LogTxt("Download Start00");
            if (MainMenu_Check())
            {
                Label1.Visible = true;
                Label1.Text = "已打开过检验室程序";
                this.Refresh();
                if (MessageBox.Show("检验室程序正在运行，是否要关闭？关闭前请保存当前操作，以免丢失数据。", "更新提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Process[] myProcess = null;
                    myProcess = Process.GetProcessesByName(ProcessesName);
                    foreach (Process myPro in myProcess)
                    {                       
                        myPro.Kill();                      
                    }
                }

            }
            if (UpdateInfo(GetFileInfo()) == true)
            {
                GeneralCommon.Gp_LogTxt("Download DownLoad_File00");
                DownLoad_File(GetFileInfo());              
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "程序已经是最新版本，无须更新";
                this.Refresh();              
            }
           GeneralCommon.Gp_LogTxt("Download Process.Start00");
            Process.Start(sExePath + ProcessesName + ".exe");
            this.Dispose();
        }


        //============================================================================================== 
        // Procedure Name : MainMenu_Check 
        // Description : main 
        //============================================================================================== 
        private bool MainMenu_Check()
        {
            //return false;
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(ProcessesName).Length > 0)
                {                   
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.Message);
                return false;
            }
        }

        private void Timer_Conut_Tick(object sender, EventArgs e)
        {
            Timer_Conut.Stop();
            if (GeneralCommon.GF_DbConnect() == true)
            {
                ExeMain();
            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("网络连接异常，进入检测程序", "W", "DataBase Connection");
                Chk_Net();
                this.Dispose();
            }


        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //待改
        private void Chk_Net()
        {
            return;
            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe ";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true;

            //p.Start();
            //p.StandardInput.WriteLine("ipconfig /all ");
            //p.StandardInput.WriteLine("exit ");
            //string ipconfig = p.StandardOutput.ReadToEnd();

            //int lastmaohao = ipconfig.LastIndexOf(":");
            //ipconfig = ipconfig.Substring(0, lastmaohao - 1);
            //ArrayList dns_al = new ArrayList();
            ////DNS 数组 
            //string[] gate = Regex.Split(ipconfig, "Default Gateway ");

            //if (gate.Length < 2)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("本地网线未插好！请检查！", "W", "网络检测");
            //    return;
            //}

            //string[] ipadr = new string[gate.Length - 1];
            ////网关数组 
            //try
            //{
            //    for (int i = 1; i <= gate.Length - 1; i++)
            //    {
            //        if (gate[i].Length > 20)
            //        {
            //            //是否有配置 
            //            gate[i] = gate[i].Substring(20);
            //        }

            //        if (Regex.IsMatch(gate[i].Substring(0, 1), "\\d"))
            //        {
            //            //是否有网关 
            //            ipadr[i - 1] = gate[i].Substring(0, 15).Trim();
            //        }

            //        if (gate[i].Contains("DNS Servers"))
            //        {
            //            string dnsmsg = gate[i].Substring(gate[i].IndexOf("DNS Servers") + 35);
            //            ////取出DNS配置 
            //            string[] dnsss = Regex.Split(dnsmsg.Trim(), "[\\r\\r\\n]");
            //            foreach (string ddns in dnsss)
            //            {
            //                //获取DNS 
            //                if (ddns.Trim().Length > 0)
            //                {
            //                    dns_al.Add(ddns.Trim());
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception exe)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("获取网络配置信息出错！" + exe.Message, "I", "网络检测");
            //}
            ////#Region "//检测网络" 
            //string outline = "";
            //try
            //{
            //    for (int m = 0; m <= ipadr.Length - 1; m++)
            //    {
            //        if (ipadr[m] == null)
            //        {
            //            continue;
            //        }

            //        p.Start();
            //        p.StandardInput.WriteLine("ping 192.168.100.54");
            //        p.StandardInput.WriteLine("exit");
            //        outline = p.StandardOutput.ReadToEnd();
            //        if (outline.Contains("TTL"))
            //        {
            //            // "//用IP能连接到服务器" 
            //            p.Start();
            //            p.StandardInput.WriteLine("ping 192.168.100.9");
            //            p.StandardInput.WriteLine("exit");
            //            outline = p.StandardOutput.ReadToEnd();

            //            if (!outline.Contains("192."))
            //            {
            //                p.Start();
            //                p.StandardInput.WriteLine("ipconfig /registerdns");
            //                p.StandardInput.WriteLine("ping " + "192.168.100.9");
            //                p.StandardInput.WriteLine("exit ");
            //                outline = p.StandardOutput.ReadToEnd();
            //                if (!outline.Contains("192."))
            //                {
            //                    if (dns_al.Count < 1)
            //                    {
            //                        //没有DNS的话，提示设置！ 
            //                        GeneralCommon.Gp_MsgBoxDisplay("请设置DNS服务器地址为192.168.100.9！", "I", "网络检测");
            //                        break; // TODO: might not be correct. Was : Exit For 
            //                    }
            //                    else
            //                    {
            //                        //检测DNS连接状态。 
            //                        bool dnsflag = false;
            //                        //标示，是否有正确的DNS 
            //                        p.Start();
            //                        foreach (string gateway in dns_al)
            //                        {
            //                            p.StandardInput.WriteLine("ping " + gateway);
            //                            if (gateway == "192.168.100.9")
            //                            {
            //                                dnsflag = true;
            //                            }
            //                        }
            //                        p.StandardInput.WriteLine("exit");
            //                        outline = p.StandardOutput.ReadToEnd();

            //                        if (!outline.Contains("TTL"))
            //                        {
            //                            GeneralCommon.Gp_MsgBoxDisplay("DNS服务器连接异常！", "W", "网络检测");
            //                        }

            //                        if (!dnsflag)
            //                        {
            //                            //没有正确的DNS设置 
            //                            GeneralCommon.Gp_MsgBoxDisplay("请设置DNS服务器地址为192.168.100.9！", "I", "网络检测");
            //                            break; // TODO: might not be correct. Was : Exit For 
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    GeneralCommon.Gp_MsgBoxDisplay("网络连接已修复，请重试！", "I", "网络检测");
            //                    break; // TODO: might not be correct. Was : Exit For 
            //                }
            //            }
            //            else
            //            {
            //                GeneralCommon.Gp_MsgBoxDisplay("网络连接正常！", "I", "网络检测");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //        }
            //        else
            //        {
            //            //IP也无法连接到服务器 
            //            //#Region "//检查本机网卡是否完好" 
            //            string localname = Dns.GetHostName().ToUpper();
            //            IPHostEntry ipInfo = Dns.GetHostEntry(localname);
            //            IPAddress[] ipAddr = ipInfo.AddressList;

            //            p.Start();
            //            foreach (IPAddress eipaddr in ipAddr)
            //            {
            //                p.StandardInput.WriteLine("ping " + eipaddr.ToString());
            //            }
            //            p.StandardInput.WriteLine("exit");
            //            outline = p.StandardOutput.ReadToEnd();

            //            if (!outline.Contains("TTL"))
            //            {
            //                GeneralCommon.Gp_MsgBoxDisplay("本机网卡错误", "W", "网络检测");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //            // #End Region 
            //            // #Region "//检查本地网关是否正常" 
            //            p.Start();
            //            p.StandardInput.WriteLine("ping " + ipadr[m]);
            //            p.StandardInput.WriteLine("exit");
            //            outline = p.StandardOutput.ReadToEnd();

            //            if (!outline.Contains("TTL"))
            //            {
            //                //不能连接到本地网关 
            //                GeneralCommon.Gp_MsgBoxDisplay("不能连接到网关" + ipadr[m], "W", "网络检测");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //            else
            //            {
            //                //能连接到本地网关，但是连接不到服务器。说明本地网和服务器连接有问题。 
            //                GeneralCommon.Gp_MsgBoxDisplay("故障，请联系信息化！" + ipadr[m], "W", "网络检测");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //        }
            //    }
            //}
            //catch (Exception exx)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("检测网络错误！" + exx.Message, "W", "网络检测");
            //    return;
            //}
            ////#End Region 

            ////无任何网关配置 
            //if (ipadr[0] == null)
            //{
            //    p.Start();
            //    p.StandardInput.WriteLine("ping 192.168.100.54");
            //    p.StandardInput.WriteLine("exit");
            //    outline = p.StandardOutput.ReadToEnd();
            //    if (outline.Contains("TTL"))
            //    {
            //        // "//用IP能连接到服务器" 
            //        p.Start();
            //        p.StandardInput.WriteLine("ping 192.168.100.9");
            //        p.StandardInput.WriteLine("exit");
            //        outline = p.StandardOutput.ReadToEnd();

            //        if (!outline.Contains("192."))
            //        {
            //            p.Start();
            //            p.StandardInput.WriteLine("ipconfig /registerdns");
            //            p.StandardInput.WriteLine("ping " + "192.168.100.9");
            //            p.StandardInput.WriteLine("exit ");
            //            outline = p.StandardOutput.ReadToEnd();
            //            if (!outline.Contains("192."))
            //            {
            //                if (dns_al.Count < 1)
            //                {
            //                    //没有DNS的话，提示设置！ 
            //                    GeneralCommon.Gp_MsgBoxDisplay("请设置DNS服务器地址为192.168.100.9！", "I", "网络检测");
            //                    return;
            //                }
            //                else
            //                {
            //                    //检测DNS连接状态。 
            //                    bool dnsflag = false;
            //                    //标示，是否有正确的DNS 
            //                    p.Start();
            //                    foreach (string gateway in dns_al)
            //                    {
            //                        p.StandardInput.WriteLine("ping " + gateway);
            //                        if (gateway == "192.168.100.9")
            //                        {
            //                            dnsflag = true;
            //                        }
            //                    }
            //                    p.StandardInput.WriteLine("exit");
            //                    outline = p.StandardOutput.ReadToEnd();

            //                    if (!outline.Contains("TTL"))
            //                    {
            //                        GeneralCommon.Gp_MsgBoxDisplay("DNS服务器连接异常！", "W", "网络检测");
            //                        return;
            //                    }
            //                    else
            //                    {
            //                        if (dnsflag)
            //                        {
            //                            GeneralCommon.Gp_MsgBoxDisplay("DNS服务器连接正常！", "I", "网络检测");
            //                            return;
            //                        }
            //                        else
            //                        {
            //                            //没有正确的DNS设置 
            //                            GeneralCommon.Gp_MsgBoxDisplay("请设置DNS服务器地址为192.168.100.9！", "W", "网络检测");
            //                            return;
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            GeneralCommon.Gp_MsgBoxDisplay("网络连接正常！", "I", "网络检测");
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        //IP也无法连接到服务器 
            //        //#Region "//检查本机网卡是否完好" 
            //        string localname = Dns.GetHostName().ToUpper();
            //        IPHostEntry ipInfo = Dns.GetHostEntry(localname);
            //        IPAddress[] ipAddr = ipInfo.AddressList;

            //        p.Start();
            //        foreach (IPAddress eipaddr in ipAddr)
            //        {
            //            p.StandardInput.WriteLine("ping " + eipaddr.ToString());
            //        }
            //        p.StandardInput.WriteLine("exit");
            //        outline = p.StandardOutput.ReadToEnd();

            //        if (!outline.Contains("TTL"))
            //        {
            //            GeneralCommon.Gp_MsgBoxDisplay("本机网卡错误", "W", "网络检测");
            //            return;
            //        }


            //        GeneralCommon.Gp_MsgBoxDisplay("请检查本地网关！", "W", "网络检测");
            //    }

            //}
        }

    }
}