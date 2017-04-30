using System;
using System.Net;
using System.IO;
using System.Text;
using System.Net.Sockets;

namespace CommonClass
{
     /// <summary>
     /// FTP Client
     /// </summary>
     public class FTPClient
     {
      #region ���캯��
      /// <summary>
      /// ȱʡ���캯��
      /// </summary>
      public FTPClient()
      {
           strRemoteHost  = "";
           strRemotePath  = "";
           strRemoteUser  = "";
           strRemotePass  = "";
           strRemotePort  = 21;
           bConnected     = false;
      }
         
      /// <summary>
      /// ���캯��
      /// </summary>
      /// <param name="remoteHost"></param>
      /// <param name="remotePath"></param>
      /// <param name="remoteUser"></param>
      /// <param name="remotePass"></param>
      /// <param name="remotePort"></param>
      public FTPClient( string remoteHost, string remotePath, string remoteUser, string remotePass, int remotePort )
      {
           strRemoteHost  = remoteHost;
           strRemotePath  = remotePath;
           strRemoteUser  = remoteUser;
           strRemotePass  = remotePass;
           strRemotePort  = remotePort;
        
           Connect();
      }
      #endregion
        
      #region ��½
      /// <summary>
      /// FTP������IP��ַ
      /// </summary>
      private string strRemoteHost;
      public string RemoteHost
      {
           get
           {
            return strRemoteHost;
           }
           set
           {
            strRemoteHost = value;
           }
      }
      /// <summary>
      /// FTP�������˿�
      /// </summary>
      private int strRemotePort;
      public int RemotePort
      {
           get
           {
            return strRemotePort;
           }
           set
           {
            strRemotePort = value;
           }
      }
      /// <summary>
      /// ��ǰ������Ŀ¼
      /// </summary>
      private string strRemotePath;
      public string RemotePath
      {
           get
           {
            return strRemotePath;
           }
           set
           {
            strRemotePath = value;
           }
      }
      /// <summary>
      /// ��¼�û��˺�
      /// </summary>
      private string strRemoteUser;
      public string RemoteUser
      {
           set
           {
            strRemoteUser = value;
           }
      }
      /// <summary>
      /// �û���¼����
      /// </summary>
      private string strRemotePass;
      public string RemotePass
      {
           set
           {
            strRemotePass = value;
           }
      }

      /// <summary>
      /// �Ƿ��¼
      /// </summary>
      private Boolean bConnected;
      public bool Connected
      {
           get
           {
            return bConnected;
           }
      }
      #endregion

      #region ����
      /// <summary>
      /// �������� 
      /// </summary>
      public void Connect()
      {
           socketControl = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
           IPEndPoint ep = new IPEndPoint(IPAddress.Parse(RemoteHost), strRemotePort);

         //  timer1.Enabled = true;
           // ����
           try
           {
                socketControl.Connect(ep);
           }
           catch(Exception)
           {
                throw new IOException("Couldn't connect to remote server");
           }

           // ��ȡӦ����
           ReadReply();
           if(iReplyCode != 220)
           {
                DisConnect();
                throw new IOException(strReply.Substring(4));
           }

           // ��½
           SendCommand("USER "+strRemoteUser);
           //ReadReply();
           if( !(iReplyCode == 331 || iReplyCode == 230) )
           {
                CloseSocketConnect();//�ر�����
                throw new IOException(strReply.Substring(4));
           }
           if( iReplyCode != 230 )
           {              
                SendCommand("PASS "+strRemotePass);
                if( !(iReplyCode == 230 || iReplyCode == 202) )
                {
                     CloseSocketConnect();//�ر�����
                     throw new IOException(strReply.Substring(4));
                }
           }
           bConnected = true;
          
           // �л���Ŀ¼
           ChDir(strRemotePath);
      }
        

      /// <summary>
      /// �ر�����
      /// </summary>
      public void DisConnect()
      {
           if( socketControl != null )
           {
                SendCommand("QUIT");
           }
           CloseSocketConnect();
          buffer=null;
      }
    
      #endregion

      #region ����ģʽ

      /// <summary>
      /// ����ģʽ:���������͡�ASCII����
      /// </summary>
      public enum TransferType {Binary,ASCII};

      /// <summary>
      /// ���ô���ģʽ
      /// </summary>
      /// <param name="ttType">����ģʽ</param>
      public void SetTransferType(TransferType ttType)
      {
           if(ttType == TransferType.Binary)
           {
                SendCommand("TYPE I");//binary���ʹ���
           }
           else
           {
                SendCommand("TYPE A");//ASCII���ʹ���
           }
           if (iReplyCode != 200)
           {
                throw new IOException(strReply.Substring(4));
           }
           else
           {
                trType = ttType;
           }
      }


      /// <summary>
      /// ��ô���ģʽ
      /// </summary>
      /// <returns>����ģʽ</returns>
      public TransferType GetTransferType()
      {
           return trType;
      }
        
      #endregion

      #region �ļ�����
      /// <summary>
      /// ����ļ��б�
      /// </summary>
      /// <param name="strMask">�ļ�����ƥ���ַ���</param>
      /// <returns></returns>
      public string[] Dir(string strMask)
      {
       // ��������
           if(!bConnected)
           {
            Connect();
           }

           //���������������ӵ�socket
           Socket socketData = CreateDataSocket();
           
           //��������
           SendCommand("NLST " + strMask);

           //����Ӧ�����
           if(!(iReplyCode == 150 || iReplyCode == 125 || iReplyCode == 226))
           {
            throw new IOException(strReply.Substring(4));
           }

           //��ý��
           strMsg = "";
           while(true)
           {
            int iBytes = socketData.Receive(buffer, buffer.Length, 0);
            strMsg += ASCII.GetString(buffer, 0, iBytes);
            if(iBytes < buffer.Length)
            {
             break;
            }
           }
           char[] seperator = {'\n'};
           if (strMsg.Contains("\r"))
               strMsg = strMsg.Replace("\r","");
             
           string[] strsFileList = strMsg.Split(seperator);
           socketData.Close();//����socket�ر�ʱҲ���з�����
           if(iReplyCode != 226)
           {
            ReadReply();
            if(iReplyCode != 226)
            {
             throw new IOException(strReply.Substring(4));
            }
           }
           return strsFileList;
      }
        

      /// <summary>
      /// ��ȡ�ļ���С
      /// </summary>
      /// <param name="strFileName">�ļ���</param>
      /// <returns>�ļ���С</returns>
      private long GetFileSize(string strFileName)
      {
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("SIZE " + Path.GetFileName(strFileName));
           long lSize=0;
           if(iReplyCode == 213)
           {
            lSize = Int64.Parse(strReply.Substring(4));
           }
           else
           {
            throw new IOException(strReply.Substring(4));
           }
           return lSize;
      }


      /// <summary>
      /// ɾ��
      /// </summary>
      /// <param name="strFileName">��ɾ���ļ���</param>
      public void Delete(string strFileName)
      {
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("DELE "+strFileName);
           if(iReplyCode != 250)
           {
            throw new IOException(strReply.Substring(4));
           }
      }


         /// <summary>
      /// ������(������ļ����������ļ�����,�����������ļ�)
      /// </summary>
      /// <param name="strOldFileName">���ļ���</param>
      /// <param name="strNewFileName">���ļ���</param>
      public void Rename(string strOldFileName,string strNewFileName)
      {
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("RNFR "+strOldFileName);
           if(iReplyCode != 350)
           {
            throw new IOException(strReply.Substring(4));
           }
           //  ������ļ�����ԭ���ļ�����,������ԭ���ļ�
           SendCommand("RNTO "+strNewFileName);
           if(iReplyCode != 250)
           {
            throw new IOException(strReply.Substring(4));
           }
      }
      #endregion

      #region �ϴ�������
      /// <summary>
      /// ����һ���ļ�
      /// </summary>
      /// <param name="strFileNameMask">�ļ�����ƥ���ַ���</param>
      /// <param name="strFolder">����Ŀ¼(������\����)</param>
      public bool Get(string strFileNameMask,string strFolder)
      {
          try
          {
              if (!bConnected)
              {
                  Connect();
              }
              string[] strFiles = Dir(strFileNameMask);
              foreach (string strFile in strFiles)
              {
                  if (!strFile.Equals(""))//һ����˵strFiles�����һ��Ԫ�ؿ����ǿ��ַ���
                  {
                      if (strFile.Contains("."))
                          Get(strFile, strFolder, strFile);
                  }
              }
              return true;
          }
          catch
          { return false; }
      }
        

      /// <summary>
      /// ����һ���ļ�
      /// </summary>
      /// <param name="strRemoteFileName">Ҫ���ص��ļ���</param>
      /// <param name="strFolder">����Ŀ¼(������\����)</param>
      /// <param name="strLocalFileName">�����ڱ���ʱ���ļ���</param>
      public bool Get(string strRemoteFileName,string strFolder,string strLocalFileName)
      {
          try
          {
              if (!bConnected)
              {
                  Connect();
              }
              SetTransferType(TransferType.Binary);
              if (strLocalFileName.Equals(""))
              {
                  strLocalFileName = strRemoteFileName;
              }
              if (!File.Exists(strFolder+strLocalFileName))
              {
                  Stream st = File.Create(strFolder+strLocalFileName);
                  st.Close();
              }
              if (strLocalFileName.Contains("\r"))
                  strLocalFileName = strLocalFileName.Remove(strLocalFileName.Length - 1);
              FileStream output = new FileStream(strFolder + "\\" + strLocalFileName, FileMode.Create);
              Socket socketData = CreateDataSocket();
              
              SendCommand("RETR " + strRemoteFileName);
              if (!(iReplyCode == 150 || iReplyCode == 125
              || iReplyCode == 226 || iReplyCode == 250))
              {
                  throw new IOException(strReply.Substring(4));
              }
              while (true)
              {
                  int iBytes = socketData.Receive(buffer, buffer.Length, 0);
                 // System.Threading.Thread.Sleep(100);
                  output.Write(buffer, 0, iBytes);
                  if (iBytes <= 0)
                  {
                      break;
                  }
              }
              output.Close();
              if (socketData.Connected)
              {
                  socketData.Close();
              }
              if (!(iReplyCode == 226 || iReplyCode == 250))
              {
                  ReadReply();
                  if (!(iReplyCode == 226 || iReplyCode == 250))
                  {
                      throw new IOException(strReply.Substring(4));
                  }
              }
              return true;
          }
          catch
          { return false; }
      }
        

      /// <summary>
      /// �ϴ�һ���ļ�
      /// </summary>
      /// <param name="strFolder">����Ŀ¼(������\����)</param>
      /// <param name="strFileNameMask">�ļ���ƥ���ַ�(���԰���*��?)</param>
      public void Put(string strFolder,string strFileNameMask)
      {
           string[] strFiles = Directory.GetFiles(strFolder,strFileNameMask);
           foreach(string strFile in strFiles)
           {
            //strFile���������ļ���(����·��)
            Put(strFile);
           }
      }
        

      /// <summary>
      /// �ϴ�һ���ļ�
      /// </summary>
      /// <param name="strFileName">�����ļ���</param>
      public bool Put(string strFileName)
      {
           if(!bConnected)
           {
            Connect();
           }
           Socket socketData = CreateDataSocket();
           SendCommand("STOR "+Path.GetFileName(strFileName));
           if( !(iReplyCode == 125 || iReplyCode == 150) )
           {
            throw new IOException(strReply.Substring(4));
           }
           FileStream input = new 
           FileStream(strFileName,FileMode.Open);
           int iBytes = 0;
           while ((iBytes = input.Read(buffer,0,buffer.Length)) > 0)
           {
            socketData.Send(buffer, iBytes, 0);
           }
           input.Close();
           if (socketData.Connected)
           {
            socketData.Close();
           }
           if(!(iReplyCode == 226 || iReplyCode == 250))
           {
            ReadReply();
            if(!(iReplyCode == 226 || iReplyCode == 250))
            {
             throw new IOException(strReply.Substring(4));
            }
           }
           return true;
      }


      //public bool Put(string strFileName)
      //{
      //    if (!bConnected)
      //    {
      //        Connect();
      //    }
      //    Socket socketData = CreateDataSocket();
      //    SendCommand("STOR " + Path.GetFileName(strFileName));
      //    if (!(iReplyCode == 125 || iReplyCode == 150))
      //    {
      //        throw new IOException(strReply.Substring(4));
      //    }
      //    FileStream input = new
      //    FileStream(strFileName, FileMode.Open);
      //    int iBytes = 0;
      //    while ((iBytes = input.Read(buffer, 0, buffer.Length)) > 0)
      //    {
      //        socketData.Send(buffer, iBytes, 0);
      //    }
      //    input.Close();
      //    if (socketData.Connected)
      //    {
      //        socketData.Close();
      //    }
      //    if (!(iReplyCode == 226 || iReplyCode == 250))
      //    {
      //        ReadReply();
      //        if (!(iReplyCode == 226 || iReplyCode == 250))
      //        {
      //            throw new IOException(strReply.Substring(4));
      //        }
      //    }
      //    return true;
      //}

        
      #endregion

      #region Ŀ¼����
      /// <summary>
      /// ����Ŀ¼
      /// </summary>
      /// <param name="strDirName">Ŀ¼��</param>
      public void MkDir(string strDirName)
      {
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("MKD "+strDirName);
           if(iReplyCode != 257)
           {
            throw new IOException(strReply.Substring(4));
           }
      }
        
     
      /// <summary>
      /// ɾ��Ŀ¼
      /// </summary>
      /// <param name="strDirName">Ŀ¼��</param>
      public void RmDir(string strDirName)
      {
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("RMD "+strDirName);
           if(iReplyCode != 250)
           {
            throw new IOException(strReply.Substring(4));
           }
      }
        
     
      /// <summary>
      /// �ı�Ŀ¼
      /// </summary>
      /// <param name="strDirName">�µĹ���Ŀ¼��</param>
      public void ChDir(string strDirName)
      {
           if(strDirName.Equals(".") || strDirName.Equals(""))
           {
            return;
           }
           if(!bConnected)
           {
            Connect();
           }
           SendCommand("CWD "+strDirName);
           if(iReplyCode != 250)
           {
            throw new IOException(strReply.Substring(4));
           }
           this.strRemotePath = strDirName;
      }
        
      #endregion

      #region �ڲ�����
      /// <summary>
      /// ���������ص�Ӧ����Ϣ(����Ӧ����)
      /// </summary>
      private string strMsg;
      /// <summary>
      /// ���������ص�Ӧ����Ϣ(����Ӧ����)
      /// </summary>
      public string strReply;
      /// <summary>
      /// ���������ص�Ӧ����
      /// </summary>
      private int iReplyCode;
      /// <summary>
      /// ���п������ӵ�socket
      /// </summary>
      private Socket socketControl;
      /// <summary>
      /// ����ģʽ
      /// </summary>
      private TransferType trType;
      /// <summary>
      /// ���պͷ������ݵĻ�����
      /// </summary>
      private static int BLOCK_SIZE = 512;
      Byte[] buffer = new Byte[BLOCK_SIZE];
      /// <summary>
      /// ���뷽ʽ
      /// </summary>
      Encoding ASCII = Encoding.ASCII;
      #endregion

      #region �ڲ�����
      /// <summary>
      /// ��һ��Ӧ���ַ�����¼��strReply��strMsg
      /// Ӧ�����¼��iReplyCode
      /// </summary>
      private void ReadReply()
      {
          strMsg = "";
          strReply = ReadLine();
          iReplyCode = 000;
          if(strReply.Length>0)

          iReplyCode = Int32.Parse(strReply.Substring(0, 3));
      }

      /// <summary>
      /// ���������������ӵ�socket
      /// </summary>
      /// <returns>��������socket</returns>
      private Socket CreateDataSocket()
      {
          SendCommand("PASV");
          if (iReplyCode != 227)
          {
              throw new IOException(strReply.Substring(4));
          }
          int index1 = strReply.IndexOf('(');
          int index2 = strReply.IndexOf(')');
          string ipData =
           strReply.Substring(index1 + 1, index2 - index1 - 1);
          int[] parts = new int[6];
          int len = ipData.Length;
          int partCount = 0;
          string buf = "";
          for (int i = 0; i < len && partCount <= 6; i++)
          {
              char ch = Char.Parse(ipData.Substring(i, 1));
              if (Char.IsDigit(ch))
                  buf += ch;
              else if (ch != ',')
              {
                  throw new IOException("Malformed PASV strReply: " +
                   strReply);
              }
              if (ch == ',' || i + 1 == len)
              {
                  try
                  {
                      parts[partCount++] = Int32.Parse(buf);
                      buf = "";
                  }
                  catch (Exception)
                  {
                      throw new IOException("Malformed PASV strReply: " +
                       strReply);
                  }
              }
          }
          string ipAddress = parts[0] + "." + parts[1] + "." +
           parts[2] + "." + parts[3];
          int port = (parts[4] << 8) + parts[5];
          Socket s = new
           Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          IPEndPoint ep = new
           IPEndPoint(IPAddress.Parse(ipAddress), port);
          try
          {
              s.Connect(ep);
          }
          catch (Exception)
          {
              throw new IOException("Can't connect to remote server");
          }
          return s;
      }


      /// <summary>
      /// �ر�socket����(���ڵ�¼��ǰ)
      /// </summary>
      private void CloseSocketConnect()
      {
          if (socketControl != null)
          {
              socketControl.Close();
              socketControl = null;
          }
          bConnected = false;
      }

      /// <summary>
      /// ��ȡSocket���ص������ַ���
      /// </summary>
      /// <returns>����Ӧ������ַ�����</returns>
      private string ReadLine()
      {
       //   int msecs_passed = 0;		// #######################################
          strMsg = "000 error";
          //while (socketControl.Available < 1)
          //{
          //    System.Threading.Thread.Sleep(50);
          //    msecs_passed += 50;
          //    // this code is just a fail safe option 
          //    // so the code doesn't hang if there is 
          //    // no data comming.
          //    if (msecs_passed > 10000)
          //    {
          //        DisConnect();
          //        throw new Exception("000 Timed out waiting on server to respond.");
          //    }
          //}
          while (true )
          {
              strMsg = "";
              int iBytes = socketControl.Receive(buffer, buffer.Length, 0);
              System.Threading.Thread.Sleep(100);
              
              strMsg += ASCII.GetString(buffer, 0, iBytes);
              if (iBytes < buffer.Length)
              {
                  break;
              }
          }
          char[] seperator = { '\n' };
          string[] mess = strMsg.Split(seperator);
          if (strMsg.Length > 2)
          {
              strMsg = mess[mess.Length - 2];
              //seperator[0]��10,���з�����13��0��ɵ�,�ָ���10������û���ַ���,
              //��Ҳ�����Ϊ���ַ���������(Ҳ�����һ��)�ַ�������,
              //�������һ��mess��û�õĿ��ַ���
              //��Ϊʲô��ֱ��ȡmess[0],��Ϊֻ�����һ���ַ���Ӧ��������Ϣ֮���пո�
          }
          else
          {
              strMsg = mess[0];
          }
          if (strMsg.Length>4)
          if (!strMsg.Substring(3, 1).Equals(" "))//�����ַ�����ȷ������Ӧ����(��220��ͷ,�����һ�ո�,�ٽ��ʺ��ַ���)
          {
              return ReadLine();
          }
          return strMsg;
      }


      /// <summary>
      /// ���������ȡӦ��������һ��Ӧ���ַ���
      /// </summary>
      /// <param name="strCommand">����</param>
      private void SendCommand(String strCommand)
      {
          Byte[] cmdBytes =
            //   Encoding.UTF8.GetBytes((strCommand + "\r\n").ToCharArray());
          Encoding.GetEncoding("gb2312").GetBytes(strCommand + "\r\n");
          socketControl.Send(cmdBytes, cmdBytes.Length, 0);
          System.Threading.Thread.Sleep(100);
              
         // socketControl.Send(cmdBytes);
          ReadReply();
      }

  #endregion           
       
}
}


