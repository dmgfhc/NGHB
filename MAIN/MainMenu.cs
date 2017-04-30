using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;
using CommonClass;
using System.Data.OleDb;
using System.Net;
using System.Reflection;
using System.IO.IsolatedStorage;
using System.IO;
//using Microsoft.VisualBasic;

namespace MAIN
{
    /// <summary>
    /// ������ 
    /// </summary>
    public partial class MainMenu : Form
    {

        private System.Windows.Forms.ContextMenu contextMenu1;
        internal System.Windows.Forms.MenuItem menuItem1;
        internal System.Windows.Forms.MenuItem menuItem2;
        internal System.Windows.Forms.MenuItem menuItem3;
        internal System.Windows.Forms.MenuItem menuItem4;
        internal System.Windows.Forms.MenuItem menuItem5;
        internal System.Windows.Forms.MenuItem menuItem6;
        internal System.Windows.Forms.MenuItem menuItem7;
        internal System.Windows.Forms.MenuItem menuItem8;
        internal System.Windows.Forms.MenuItem menuItem9;
        internal System.Windows.Forms.MenuItem menuItem10;
        internal System.Windows.Forms.MenuItem menuItem11;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;

        string LocalIP;

        private string sExeName;
        //execute file name 

        private string sExeDesc;
        //execute file desc

        private Color COLOR_DEFAULT_BACK = Color.White;

        private static string sExePath;

        private const string ProcessesName = "LGJHY";


        /// <summary>
        /// �������ʼ��
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            Main();
        }

        private void Main()
        {
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();

            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click); //������
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click); //������
           // this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click); //������
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click); //����
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click); //��½
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click); //ע��
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click); //��ԭ
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click); //�ر�

            //WaitSet("��ʼ���˵��� !");

            //// Initialize contextMenu1 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {  this.menuItem11, this.menuItem10,
                this.menuItem9,this.menuItem1, 
                this.menuItem2, this.menuItem3, this.menuItem4,
                this.menuItem5, this.menuItem6, this.menuItem7, this.menuItem8});

            this.menuItem11.Index = 0;
            this.menuItem11.Text ="-";// cmd_a.Text;
            this.menuItem11.Enabled = false;

            this.menuItem10.Index = 1;
            this.menuItem10.Text = cmd_d.Text;// cmd_d.Text;
            this.menuItem10.Enabled = false;

            this.menuItem9.Index = 2;
            this.menuItem9.Text = "";// cmd_f.Text;
            this.menuItem9.Enabled = false;


            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";// cmd_f.Text;
            this.menuItem1.Enabled = false;

            this.menuItem2.Index = 4;
            this.menuItem2.Text = cmd_z.Text;
            this.menuItem2.Enabled = false;

            this.menuItem3.Index = 5;
            this.menuItem3.Text = "-";

            this.menuItem4.Index = 6;
            this.menuItem4.Text = "��½(&I)";

            this.menuItem5.Index = 7;
            this.menuItem5.Text = cmd_btn8.Text;
            this.menuItem5.Enabled = false;

            this.menuItem6.Index = 8;
            this.menuItem6.Text = "-";

            this.menuItem7.Index = 9;
            this.menuItem7.Text = "��ԭ(&R)";
            this.menuItem7.Enabled = false;

            this.menuItem8.Index = 10;
            this.menuItem8.Text = "�ر�(&X)";

            // Set up how the form should be displayed. 
            //WaitSet("������ʾ���� !");
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1024, 768);

            // Create the NotifyIcon. 
            //WaitSet("����ϵͳͼ�� !");
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear 
            // in the systray for this application. 
            this.NotifyIcon1.Icon = this.Icon;

            // The ContextMenu property sets the menu that will 
            // appear when the systray icon is right clicked. 
            this.NotifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed, 
            // in a tooltip, when the mouse hovers over the systray icon. 
            this.NotifyIcon1.Text = "�컯��ϵͳ";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.DoubleClick += new EventHandler(NotifyIcon1_DoubleClick);
            //WaitSet("����ϵͳ�¼� !");
        }

        void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MainMenu_Load(object sender, System.EventArgs e)
        {
             GeneralCommon.Gp_LogTxt("Main MainMenu_Load 00");
            try
            {
                if (MainMenu_Check())
                {
                    Process myProcess = new Process();
                    myProcess = Process.GetProcessById(Process.GetCurrentProcess().Id);
                    myProcess.Kill();
                    return;
                }
                 GeneralCommon.Gp_LogTxt("Main GetLocalIP 00");
                GetLocalIP();
                string myPro = null;
                string Paths = null;
                myPro = Process.GetCurrentProcess().ProcessName;
                Paths = System.IO.Directory.GetCurrentDirectory();

                System.IO.File.Copy(Paths + "\\" + "Download.exe", Paths + "\\" + "Upload.exe", true);
                sExePath = Paths + "\\";
                if (GeneralCommon.GF_DbConnect())
                {
                     GeneralCommon.Gp_LogTxt("Main Form_Define 00");
                    Form_Define();
                    GeneralCommon.bPassCheck = false;
                    this.KeyPreview = true;
                    fg1.Visible = false;
                    log_display();
                    GeneralCommon.Gp_FormCenter(this);

                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("���������쳣�����������", "W", "���ݿ����Ӵ���");
                    Chk_Net();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("�������������� " + ex.Message);
                this.Close();
            }

        }


        /// <summary>
        /// ������Ψһ�Լ��
        /// </summary>       
        private bool MainMenu_Check()
        {
            try
            {
                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).GetLowerBound(0) > 0)
                {
                    //*  ����*/ Process[] proces = null;
                    // proces = Process.GetProcessesByName(ProcessesName);
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

        //--------------------------------------------------------------------------------------- 
        // 1.ID : GetLocalIP 
        // 2.Input Value : 
        // 3.Return Value : 
        // 4.Create Date : 2007.11.25 by �Ͻ��� 
        // 5.Modify Date : 2007.11.25 
        // 6.Comment : ��ñ���IP 
        //--------------------------------------------------------------------------------------- 
        /// <summary>
        /// ��ñ���IP 
        /// </summary> 
        private void GetLocalIP()
        {
            string localname = null;

            try
            {
                localname = Dns.GetHostName().ToUpper();

                //�õ�������Ϣ 
                IPHostEntry ipinfo = new IPHostEntry();
                ipinfo = Dns.GetHostEntry(localname);

                //ȡ��IPAddress[] 
                IPAddress[] ipAddr = null;
                ipAddr = ipinfo.AddressList;
                int i = 0;

                for (i = 0; i <= ipAddr.Length - 1; i++)
                {
                    LocalIP = ipAddr[i].ToString();

                    if ((LocalIP.Contains("202.202.12")))
                    {
                        //��ȡ��˾����IP 
                        break; // TODO: might not be correct. Was : Exit For 
                    }

                }
            }
            catch //(Exception ex)
            {
                LocalIP = "";
            }
        }

        /// <summary>
        /// ���嶨��
        /// </summary>     
        private void Form_Define()
        {
            try
            {

                if (MainMenu_Check())
                {
                    GeneralCommon.Gp_MsgBoxDisplay("�����Ѿ�������!������Ļ���½�ϵͳ������ͼ�껹ԭϵͳ!", "W");
                    this.Close();
                    return;
                }

                GeneralCommon.bPassCheck = false;
                Picture1.Visible = true;
                Picture2.Visible = false;

                lblscript.Visible = false;

                // set exe name to tag property 
                cmd_z.Tag = "Z.exe";
                cmd_f.Tag = "F.exe";
                cmd_a.Tag = "A.exe";
                cmd_d.Tag = "D.exe";

                if (GeneralCommon.GF_DbConnect() == false)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("�������ӵ����ݿ������!!! ", "W");
                    this.Close();
                }

                this.KeyPreview = true;


                Application.DoEvents();
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(ex.Message);
                this.Close();
            }
        }


        /// <summary>
        /// ��ȡҪ��ʾ�Ĺ�����Ϣ
        /// </summary> 
        private void log_display()
        {
            try
            {
                fg1.Cols.Fixed = 0;
                DataSet ds = new CommonClass.ProcQuery("LOG_FIND", new ArrayList()).CreateDataSet(false);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    fg1.DataSource = ds.Tables[0];
                }

                fg1.Cols.Fixed = 0;
            }
            catch //(System.Exception e)
            {

            }
        }



        private void Picture1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Picture1.Visible = false;
            Picture2.Visible = true;
        }

        private void Picture2_MouseLeave(object sender, System.EventArgs e)
        {
            Picture1.Visible = true;
            Picture2.Visible = false;
        }
        //�����¼��ť
        private void Picture2_Click(object sender, System.EventArgs e)
        {

            Login Login = new Login();

            Login.ShowDialog();


            if (GeneralCommon.bPassCheck)
            {
                Picture1.Visible = false;
                Picture2.Visible = false;

                cmd_z.Visible = true;
              //  cmd_f.Visible = true;
                //cmd_a.Visible = true;
                cmd_d.Visible = true;
                cmd_btn8.Visible = true;

                cmd_z.BackColor = COLOR_DEFAULT_BACK;
                cmd_f.BackColor = COLOR_DEFAULT_BACK;
                    
                cmd_a.BackColor = COLOR_DEFAULT_BACK;
                cmd_d.BackColor = COLOR_DEFAULT_BACK;
                cmd_btn8.BackColor = COLOR_DEFAULT_BACK;

                lblscript.Visible = true;

                menuItem1.Visible = true;
                menuItem2.Visible = true;
                menuItem3.Visible = true;
                menuItem4.Visible = true;
                menuItem5.Visible = true;

                menuItem6.Visible = true;
                menuItem7.Visible = true;
                menuItem8.Visible = true;
                //menuItem9.Visible = true;
                menuItem10.Visible = true;
                menuItem11.Visible = true;

                menuItem1.Enabled = true;
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem4.Enabled = true;
                menuItem5.Enabled = true;

                menuItem6.Enabled = true;
                menuItem7.Enabled = true;
                menuItem8.Enabled = true;
                menuItem9.Enabled = true;
                menuItem10.Enabled = true;
                menuItem11.Enabled = true;

                NotifyIcon1.Icon = this.Icon;
                fg1.Visible = true;


                Chk_Authority();
                Set_CilentTime();
            }
            PictureBox1.Visible = true;
        }
        /// <summary>
        /// ���Ȩ��
        /// </summary> 
        private void Chk_Authority()
        {
            ArrayList TempParamAry = new ArrayList();
            TempParamAry.Add(GeneralCommon.sUserID);
            CommonClass.ProcQuery TempProcQuery = new CommonClass.ProcQuery("PKG_MAIN.P_AUTHORITY", TempParamAry);
            DataSet ds = TempProcQuery.CreateDataSet();

            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "0")
                    {
                        cmd_f.Enabled = false;
                        menuItem1.Enabled = false;
                    }
                    if (ds.Tables[0].Rows[0].ItemArray[1].ToString() == "0")
                    {
                        cmd_z.Enabled = false;
                        menuItem9.Enabled = false;
                    }
                    if (ds.Tables[0].Rows[0].ItemArray[2].ToString() == "0")
                    {
                        cmd_a.Enabled = false;
                        menuItem11.Enabled = false;
                    }
                    if (ds.Tables[0].Rows[0].ItemArray[3].ToString() == "0")
                    {
                        cmd_d.Enabled = false;
                        menuItem10.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay("��ȡȨ�޴���!" + ex.ToString());
                return;
            }
        }

        private void Chk_Net()  //����
        {
            #region
            //Dim p As Process = New Process()
            //p.StartInfo.FileName = "cmd.exe "
            //p.StartInfo.UseShellExecute = False
            //p.StartInfo.RedirectStandardInput = True
            //p.StartInfo.RedirectStandardOutput = True
            //p.StartInfo.RedirectStandardError = True
            //p.StartInfo.CreateNoWindow = True

            //p.Start()
            //p.StandardInput.WriteLine("ipconfig /all ")
            //p.StandardInput.WriteLine("exit ")
            //Dim ipconfig As String = p.StandardOutput.ReadToEnd()

            //Dim lastmaohao As Integer = ipconfig.LastIndexOf(":")
            //ipconfig = ipconfig.Substring(0, lastmaohao - 1)
            //Dim dns_al As New ArrayList()        'DNS ���� 
            //Dim gate As String() = Regex.Split(ipconfig, "Default Gateway ")

            //If gate.Length < 2 Then
            //    Call GeneralCommon.Gp_MsgBoxDisplay("��������δ��ã����飡", "W", "������")
            //    Exit Sub
            //End If

            //Dim ipadr As String() = New String(gate.Length - 2) {}        '�������� 
            //Try
            //    For i As Integer = 1 To gate.Length - 1
            //        If gate(i).Length > 20 Then  '�Ƿ������� 
            //            gate(i) = gate(i).Substring(20)
            //        End If

            //        If Regex.IsMatch(gate(i).Substring(0, 1), "\d") Then        '�Ƿ������� 
            //            ipadr(i - 1) = gate(i).Substring(0, 15).Trim()
            //        End If

            //        If gate(i).Contains("DNS Servers") Then
            //            Dim dnsmsg As String = gate(i).Substring(gate(i).IndexOf("DNS Servers") + 35) '//ȡ��DNS����                   
            //            Dim dnsss As String() = Regex.Split(dnsmsg.Trim(), "[\r\r\n]")
            //            For Each ddns As String In dnsss      '��ȡDNS 
            //                If ddns.Trim().Length > 0 Then
            //                    dns_al.Add(ddns.Trim())
            //                End If
            //            Next
            //        End If
            //    Next
            //Catch exe As Exception
            //    Call GeneralCommon.Gp_MsgBoxDisplay("��ȡ����������Ϣ����" + exe.Message, "I", "������")
            //End Try
            //'#Region "//�������" 
            //Dim outline As String = ""
            //Try
            //    For m As Integer = 0 To ipadr.Length - 1
            //        If ipadr(m) Is Nothing Then
            //            Continue For
            //        End If

            //        p.Start()
            //        p.StandardInput.WriteLine("ping 172.18.60.34")
            //        p.StandardInput.WriteLine("exit")
            //        outline = p.StandardOutput.ReadToEnd()
            //        If outline.Contains("TTL") Then
            //            '  "//��IP�����ӵ�������" 
            //            p.Start()
            //            p.StandardInput.WriteLine("ping nqis.nisco.cn")
            //            p.StandardInput.WriteLine("exit")
            //            outline = p.StandardOutput.ReadToEnd()

            //            If Not outline.Contains("172.") Then
            //                p.Start()
            //                p.StandardInput.WriteLine("ipconfig /registerdns")
            //                p.StandardInput.WriteLine("ping " + "nqis.nisco.cn")
            //                p.StandardInput.WriteLine("exit ")
            //                outline = p.StandardOutput.ReadToEnd()
            //                If Not outline.Contains("172.") Then
            //                    If dns_al.Count < 1 Then                                'û��DNS�Ļ�����ʾ���ã� 
            //                        Call GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ172.18.248.246��", "I", "������")
            //                        Exit For
            //                    Else
            //                        '���DNS����״̬�� 
            //                        Dim dnsflag As Boolean = False                '��ʾ���Ƿ�����ȷ��DNS 
            //                        p.Start()
            //                        For Each gateway As String In dns_al
            //                            p.StandardInput.WriteLine("ping " + gateway)
            //                            If gateway = "172.18.248.246" Then
            //                                dnsflag = True
            //                            End If
            //                        Next
            //                        p.StandardInput.WriteLine("exit")
            //                        outline = p.StandardOutput.ReadToEnd()

            //                        If Not outline.Contains("TTL") Then
            //                            Call GeneralCommon.Gp_MsgBoxDisplay("DNS�����������쳣��", "W", "������")
            //                        End If

            //                        If Not dnsflag Then             'û����ȷ��DNS���� 
            //                            Call GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ172.18.248.246��", "I", "������")
            //                            Exit For
            //                        End If
            //                    End If
            //                Else
            //                    Call GeneralCommon.Gp_MsgBoxDisplay("�����������޸��������ԣ�", "I", "������")
            //                    Exit For
            //                End If
            //            Else
            //                Call GeneralCommon.Gp_MsgBoxDisplay("��������������", "I", "������")
            //                Exit For
            //            End If
            //        Else
            //            'IPҲ�޷����ӵ������� 
            //            '#Region "//��鱾�������Ƿ����" 
            //            Dim localname As String = Dns.GetHostName().ToUpper()
            //            Dim ipInfo As IPHostEntry = Dns.GetHostEntry(localname)
            //            Dim ipAddr As IPAddress() = ipInfo.AddressList

            //            p.Start()
            //            For Each eipaddr As IPAddress In ipAddr
            //                p.StandardInput.WriteLine("ping " + eipaddr.ToString())
            //            Next
            //            p.StandardInput.WriteLine("exit")
            //            outline = p.StandardOutput.ReadToEnd()

            //            If Not outline.Contains("TTL") Then
            //                Call GeneralCommon.Gp_MsgBoxDisplay("������������", "W", "������")
            //                Exit For
            //            End If
            //            ' #End Region 
            //            '   #Region "//��鱾�������Ƿ�����" 
            //            p.Start()
            //            p.StandardInput.WriteLine("ping " + ipadr(m))
            //            p.StandardInput.WriteLine("exit")
            //            outline = p.StandardOutput.ReadToEnd()

            //            If Not outline.Contains("TTL") Then
            //                '�������ӵ��������� 
            //                Call GeneralCommon.Gp_MsgBoxDisplay("�������ӵ�����" + ipadr(m), "W", "������")
            //                Exit For
            //            Else
            //                '�����ӵ��������أ��������Ӳ�����������˵���������ͷ��������������⡣ 
            //                Call GeneralCommon.Gp_MsgBoxDisplay("���������ϣ�����ϵ��Ϣ��˾3999��" + ipadr(m), "W", "������")
            //                Exit For
            //            End If
            //        End If
            //    Next
            //Catch exx As Exception
            //    Call GeneralCommon.Gp_MsgBoxDisplay("����������" + exx.Message, "W", "������")
            //    Exit Sub
            //End Try
            //'#End Region 

            //'���κ���������
            //If ipadr(0) Is Nothing Then
            //    p.Start()
            //    p.StandardInput.WriteLine("ping 172.18.60.34")
            //    p.StandardInput.WriteLine("exit")
            //    outline = p.StandardOutput.ReadToEnd()
            //    If outline.Contains("TTL") Then
            //        ' "//��IP�����ӵ�������" 
            //        p.Start()
            //        p.StandardInput.WriteLine("ping nqis.nisco.cn")
            //        p.StandardInput.WriteLine("exit")
            //        outline = p.StandardOutput.ReadToEnd()

            //        If Not outline.Contains("172.") Then
            //            p.Start()
            //            p.StandardInput.WriteLine("ipconfig /registerdns")
            //            p.StandardInput.WriteLine("ping " + "nqis.nisco.cn")
            //            p.StandardInput.WriteLine("exit ")
            //            outline = p.StandardOutput.ReadToEnd()
            //            If Not outline.Contains("172.") Then
            //                If dns_al.Count < 1 Then                                'û��DNS�Ļ�����ʾ���ã� 
            //                    Call GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ172.18.248.246��", "I", "������")
            //                    Exit Sub
            //                Else
            //                    '���DNS����״̬�� 
            //                    Dim dnsflag As Boolean = False                                '��ʾ���Ƿ�����ȷ��DNS 
            //                    p.Start()
            //                    For Each gateway As String In dns_al
            //                        p.StandardInput.WriteLine("ping " + gateway)
            //                        If gateway = "172.18.248.246" Then
            //                            dnsflag = True
            //                        End If
            //                    Next
            //                    p.StandardInput.WriteLine("exit")
            //                    outline = p.StandardOutput.ReadToEnd()

            //                    If Not outline.Contains("TTL") Then
            //                        Call GeneralCommon.Gp_MsgBoxDisplay("DNS�����������쳣��", "W", "������")
            //                        Exit Sub
            //                    Else
            //                        If dnsflag Then
            //                            Call GeneralCommon.Gp_MsgBoxDisplay("DNS����������������", "I", "������")
            //                            Exit Sub
            //                        Else
            //                            'û����ȷ��DNS���� 
            //                            Call GeneralCommon.Gp_MsgBoxDisplay("������DNS��������ַΪ172.18.248.246��", "W", "������")
            //                            Exit Sub
            //                        End If
            //                    End If
            //                End If
            //            Else
            //                Exit Sub
            //            End If
            //        Else
            //            Call GeneralCommon.Gp_MsgBoxDisplay("��������������", "I", "������")
            //            Exit Sub
            //        End If
            //    Else
            //        'IPҲ�޷����ӵ������� 
            //        '#Region "//��鱾�������Ƿ����" 
            //        Dim localname As String = Dns.GetHostName().ToUpper()
            //        Dim ipInfo As IPHostEntry = Dns.GetHostEntry(localname)
            //        Dim ipAddr As IPAddress() = ipInfo.AddressList

            //        p.Start()
            //        For Each eipaddr As IPAddress In ipAddr
            //            p.StandardInput.WriteLine("ping " + eipaddr.ToString())
            //        Next
            //        p.StandardInput.WriteLine("exit")
            //        outline = p.StandardOutput.ReadToEnd()

            //        If Not outline.Contains("TTL") Then
            //            Call GeneralCommon.Gp_MsgBoxDisplay("������������", "W", "������")
            //            Exit Sub
            //        End If

            //        Call GeneralCommon.Gp_MsgBoxDisplay("���鱾�����أ�", "W", "������")

            //    End If
            //End If
            #endregion
        }

        //==============================================================================================
        // Procedure Name : cmd_RunExe_click
        // Description    : Click Run button
        //==============================================================================================
        private void cmd_RunExe_click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.MenuItem)
            {
                System.Windows.Forms.MenuItem btn = (System.Windows.Forms.MenuItem)sender;
                sExeDesc = btn.Text.ToString();
            }
            else
            {
                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                sExeDesc = btn.Text.ToString();
            }
            sExeName = Get_Exe_Name(sExeDesc);

            if (ExeRun_File(sExeName, sExeDesc))
            {
                try
                {
                    GeneralCommon.Gp_LogTxt("Main Process.Start 00");
                    Process.Start(sExePath + sExeName, " " + GeneralCommon.sUserID + " " + GeneralCommon.sPassWord);
                    GeneralCommon.Gp_LogTxt("Main Process.Start 02");
                }
                catch (Exception ex)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("�ӳ�����ش���  " + ex.Message);

                }

                this.Hide();
                menuItem7.Enabled = true;
                Application.DoEvents();
            }
        }

        //==============================================================================================
        //Procedure Name : cmd_RunExe_click
        // Description    : Click Run button
        //==============================================================================================
        private string Get_Exe_Name(string sString)
        {
            string sTemp = "";

            switch (sString)
            {
                case "����":   //cmd_z.Text.ToString()
                    sTemp = cmd_z.Tag.ToString();
                    break;
                case "����ʵ����":
                    sTemp = cmd_f.Tag.ToString();
                    break;
                case "��������վ":
                    sTemp = cmd_d.Tag.ToString();
                    break;
                case "ԭ����":
                    sTemp = cmd_a.Tag.ToString();
                    break;
                default:
                    break;
            }

            return sTemp;
        }

        /// <summary>
        /// ����ļ��Ƿ����
        /// </summary> 
        private bool ExeRun_File(string WinId, string Form_Caption)
        {
            bool functionReturnValue = false;
            //long lHandle = 0;
            //* ����*/ bool exists = false;
            // exists = System.IO.Directory.Exists(sExePath);


            try
            {
                functionReturnValue = System.IO.Directory.Exists(sExePath);
                System.Windows.Forms.Cursor.Current = Cursors.Default;

                Application.DoEvents();
            }
            catch (Exception ex)
            {

                GeneralCommon.Gp_MsgBoxDisplay("������ڼ����� " + ex.Message);

                System.Windows.Forms.Cursor.Current = Cursors.Default;

                Application.DoEvents();
            }

            return functionReturnValue;
        }

        private void cmd_a_Click(object sender, EventArgs e)
        {
            cmd_RunExe_click(sender, e);
        }
        private void cmd_d_Click(object sender, EventArgs e)
        {
            cmd_RunExe_click(sender, e);
        }

        private void cmd_f_Click(object sender, EventArgs e)
        {
            cmd_RunExe_click(sender, e);
        }

        private void cmd_z_Click(object sender, EventArgs e)
        {
            cmd_RunExe_click(sender, e);
        }


        //==============================================================================================
        // Procedure Name : cmd_btn8_Click
        // Description    : clikc log-out buttom
        //==============================================================================================
        private void cmd_btn8_Click(object sender, EventArgs e)
        {
            cmd_z.Visible = false;
            cmd_f.Visible = false;
            //cmd_a.Visible = false;
            cmd_d.Visible = false;
            cmd_btn8.Visible = false;

            cmd_z.Enabled = true;
            cmd_f.Enabled = true;
           // cmd_a.Enabled = true;
            cmd_d.Enabled = true;
            cmd_btn8.Enabled = true;

            menuItem1.Visible = false;
            menuItem2.Visible = false;
            menuItem3.Visible = false;
            menuItem4.Visible = false;
            menuItem5.Visible = false;
            menuItem6.Visible = false;
            menuItem7.Visible = false;
            menuItem8.Visible = false;
            menuItem9.Visible = false;
           menuItem10.Visible = false;
           menuItem11.Visible = false;

            GeneralCommon.bPassCheck = false;
            GeneralCommon.sUserID = "";
            Picture1.Visible = true;
            Picture2.Visible = false;

            lblscript.Visible = false;

            NotifyIcon1.Icon = this.Icon;
            fg1.Visible = false;
            string ssss = Process.GetCurrentProcess().ProcessName;
            // if (Process.GetProcessesByName("F.exe").GetLowerBound(0) > 0)
            // {
            //*  ����*/ Process[] proces = null;
            // proces = Process.GetProcessesByName(ProcessesName);
            foreach (Process pro in Process.GetProcesses())
            {
                if (pro.ProcessName == "F")
                {
                    pro.Kill();
                    pro.Dispose();
                }
                else if (pro.ProcessName == "Z")
                {
                    pro.Kill();
                    pro.Dispose();
                }
                else if (pro.ProcessName == "D")
                {
                    pro.Kill();
                    pro.Dispose();
                }
                else if (pro.ProcessName == "A")
                {
                    pro.Kill();
                    pro.Dispose();
                }

            }

            // }


            Microsoft.Win32.Registry.LocalMachine.SetValue(@"SOFTWARE\" + GeneralCommon.RegLocation + @"\AUTHORITY\sUserID" + GeneralCommon.sUserID, "");
            Microsoft.Win32.Registry.LocalMachine.SetValue(@"SOFTWARE\" + GeneralCommon.RegLocation + @"\AUTHORITY\sUsername" + GeneralCommon.sUsername, "");

            PictureBox1.Visible = false;
        }

        private void lblscript_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GeneralCommon.bPassCheck == false)
            {
                return;
            }
            if (fg1.Visible == true)
            {
                fg1.Visible = false;
            }
            else
            {
                log_display();
                fg1.Visible = true;
            }
        }



        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.menuItem7.Enabled = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��ȷ���˳�ʵ����ϵͳ��", "�˳�", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void menuItem9_Click(object sender, System.EventArgs e)//����ʵ����
        {
            cmd_RunExe_click(sender, e);
        }
        private void menuItem10_Click(object sender, System.EventArgs e)//��������վ��
        {
            cmd_RunExe_click(sender, e);
        }
        private void menuItem11_Click(object sender, System.EventArgs e)//ԭ��ʵ����
        {
            cmd_RunExe_click(sender, e);
        }
        private void menuItem2_Click(object sender, System.EventArgs e)  //����
        {
            cmd_RunExe_click(sender, e);
        }
        private void menuItem4_Click(object sender, System.EventArgs e)  //��½
        {
            Picture2_Click(sender, e);
        }
        private void menuItem5_Click(object sender, System.EventArgs e)  //ע��
        {
            cmd_btn8_Click(sender, e);
            this.Show();
        }
        private void menuItem7_Click(object sender, System.EventArgs e)  //��ԭ
        {
            this.Show();
        }
        private void menuItem8_Click(object sender, System.EventArgs e)  //�˳�
        {
            if (MessageBox.Show("��ȷ���˳�ʵ����ϵͳ��", "�˳�", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Process pro in Process.GetProcesses())
                {
                    if (pro.ProcessName == "F")
                    {
                        pro.Kill();
                        pro.Dispose();
                    }
                    else if (pro.ProcessName == "Z")
                    {
                        pro.Kill();
                        pro.Dispose();
                    }
                    else if (pro.ProcessName == "D")
                    {
                        pro.Kill();
                        pro.Dispose();
                    }
                    else if (pro.ProcessName == "A")
                    {
                        pro.Kill();
                        pro.Dispose();
                    }

                }
                this.Dispose();
            }
        }


        //ͬ���ͻ���ʱ��
        private void Set_CilentTime()
        {

            try
            {
                string sQuery = "select to_char(sysdate,'yyyy-MM-DD HH24:MI:SS') from dual";
                DateTime DT_temp = Convert.ToDateTime(GeneralCommon.Gf_CodeFind(sQuery));
                GeneralCommon.SetDate(DT_temp);
            }
            catch
            {

            }

        }

      
       





    }
}