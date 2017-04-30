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
        // Description : ��ȡ�����ļ���Ϣ 
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
        // Description : �������и����ļ� 
        //============================================================================================== 
        private bool DownLoad_File(ArrayList WinId)
        {
            //return true;
            bool functionReturnValue = false;
            if (MainMenu_Check())
            {
                if (MessageBox.Show("�����ҳ����������У��Ƿ�Ҫ�رգ��ر�ǰ�뱣�浱ǰ�������ⶪʧ���ݡ�", "������ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                    GeneralCommon.Gp_MsgBoxDisplay("FTP��������Ϣ������...!!", "W");
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
                Label1.Text = "��������У�����ر�";

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
                            GeneralCommon.Gp_MsgBoxDisplay("�����ļ����� : " +ftp.strReply);
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

                GeneralCommon.Gp_MsgBoxDisplay("�����ļ� Error : " + ex.Message);

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
                    Label1.Text = "���������ӳ�ʱ������";
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
                Label1.Text = "�Ѵ򿪹������ҳ���";
                this.Refresh();
                if (MessageBox.Show("�����ҳ����������У��Ƿ�Ҫ�رգ��ر�ǰ�뱣�浱ǰ���������ⶪʧ���ݡ�", "������ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                Label1.Text = "�����Ѿ������°汾���������";
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
                GeneralCommon.Gp_MsgBoxDisplay("���������쳣�����������", "W", "DataBase Connection");
                Chk_Net();
                this.Dispose();
            }


        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //����
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
            ////DNS ���� 
            //string[] gate = Regex.Split(ipconfig, "Default Gateway ");

            //if (gate.Length < 2)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("��������δ��ã����飡", "W", "������");
            //    return;
            //}

            //string[] ipadr = new string[gate.Length - 1];
            ////�������� 
            //try
            //{
            //    for (int i = 1; i <= gate.Length - 1; i++)
            //    {
            //        if (gate[i].Length > 20)
            //        {
            //            //�Ƿ������� 
            //            gate[i] = gate[i].Substring(20);
            //        }

            //        if (Regex.IsMatch(gate[i].Substring(0, 1), "\\d"))
            //        {
            //            //�Ƿ������� 
            //            ipadr[i - 1] = gate[i].Substring(0, 15).Trim();
            //        }

            //        if (gate[i].Contains("DNS Servers"))
            //        {
            //            string dnsmsg = gate[i].Substring(gate[i].IndexOf("DNS Servers") + 35);
            //            ////ȡ��DNS���� 
            //            string[] dnsss = Regex.Split(dnsmsg.Trim(), "[\\r\\r\\n]");
            //            foreach (string ddns in dnsss)
            //            {
            //                //��ȡDNS 
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
            //    GeneralCommon.Gp_MsgBoxDisplay("��ȡ����������Ϣ����" + exe.Message, "I", "������");
            //}
            ////#Region "//�������" 
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
            //            // "//��IP�����ӵ�������" 
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
            //                        //û��DNS�Ļ�����ʾ���ã� 
            //                        GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ192.168.100.9��", "I", "������");
            //                        break; // TODO: might not be correct. Was : Exit For 
            //                    }
            //                    else
            //                    {
            //                        //���DNS����״̬�� 
            //                        bool dnsflag = false;
            //                        //��ʾ���Ƿ�����ȷ��DNS 
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
            //                            GeneralCommon.Gp_MsgBoxDisplay("DNS�����������쳣��", "W", "������");
            //                        }

            //                        if (!dnsflag)
            //                        {
            //                            //û����ȷ��DNS���� 
            //                            GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ192.168.100.9��", "I", "������");
            //                            break; // TODO: might not be correct. Was : Exit For 
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    GeneralCommon.Gp_MsgBoxDisplay("�����������޸��������ԣ�", "I", "������");
            //                    break; // TODO: might not be correct. Was : Exit For 
            //                }
            //            }
            //            else
            //            {
            //                GeneralCommon.Gp_MsgBoxDisplay("��������������", "I", "������");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //        }
            //        else
            //        {
            //            //IPҲ�޷����ӵ������� 
            //            //#Region "//��鱾�������Ƿ����" 
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
            //                GeneralCommon.Gp_MsgBoxDisplay("������������", "W", "������");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //            // #End Region 
            //            // #Region "//��鱾�������Ƿ�����" 
            //            p.Start();
            //            p.StandardInput.WriteLine("ping " + ipadr[m]);
            //            p.StandardInput.WriteLine("exit");
            //            outline = p.StandardOutput.ReadToEnd();

            //            if (!outline.Contains("TTL"))
            //            {
            //                //�������ӵ��������� 
            //                GeneralCommon.Gp_MsgBoxDisplay("�������ӵ�����" + ipadr[m], "W", "������");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //            else
            //            {
            //                //�����ӵ��������أ��������Ӳ�����������˵���������ͷ��������������⡣ 
            //                GeneralCommon.Gp_MsgBoxDisplay("���ϣ�����ϵ��Ϣ����" + ipadr[m], "W", "������");
            //                break; // TODO: might not be correct. Was : Exit For 
            //            }
            //        }
            //    }
            //}
            //catch (Exception exx)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("����������" + exx.Message, "W", "������");
            //    return;
            //}
            ////#End Region 

            ////���κ��������� 
            //if (ipadr[0] == null)
            //{
            //    p.Start();
            //    p.StandardInput.WriteLine("ping 192.168.100.54");
            //    p.StandardInput.WriteLine("exit");
            //    outline = p.StandardOutput.ReadToEnd();
            //    if (outline.Contains("TTL"))
            //    {
            //        // "//��IP�����ӵ�������" 
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
            //                    //û��DNS�Ļ�����ʾ���ã� 
            //                    GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ192.168.100.9��", "I", "������");
            //                    return;
            //                }
            //                else
            //                {
            //                    //���DNS����״̬�� 
            //                    bool dnsflag = false;
            //                    //��ʾ���Ƿ�����ȷ��DNS 
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
            //                        GeneralCommon.Gp_MsgBoxDisplay("DNS�����������쳣��", "W", "������");
            //                        return;
            //                    }
            //                    else
            //                    {
            //                        if (dnsflag)
            //                        {
            //                            GeneralCommon.Gp_MsgBoxDisplay("DNS����������������", "I", "������");
            //                            return;
            //                        }
            //                        else
            //                        {
            //                            //û����ȷ��DNS���� 
            //                            GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ192.168.100.9��", "W", "������");
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
            //            GeneralCommon.Gp_MsgBoxDisplay("��������������", "I", "������");
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        //IPҲ�޷����ӵ������� 
            //        //#Region "//��鱾�������Ƿ����" 
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
            //            GeneralCommon.Gp_MsgBoxDisplay("������������", "W", "������");
            //            return;
            //        }


            //        GeneralCommon.Gp_MsgBoxDisplay("���鱾�����أ�", "W", "������");
            //    }

            //}
        }

    }
}