using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Specialized;
//using System.Data.OracleClient;
using System.Net;

namespace DownLoad
{
    public class GeneralCommon
    {
         
        public static OleDbConnection OleDbConn = new OleDbConnection();
        public static OleDbDataAdapter OleDbAdp;
        public static OleDbCommand OleDbCmd = new OleDbCommand();
        public static OleDbConnection OleDbConn_Log = new OleDbConnection();
       
        public static string sUserID = string.Empty;
      

       // public static string FileName = "SEC.INI";


        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <return>bool</return>    
        public static bool GF_DbConnect()
        {
            try
            {
                //  OleDbConnection Conn = new OleDbConnection();
                string Filename = "SEC.ini";
                string iniConnectString = string.Empty;
                string sPath = System.IO.Directory.GetCurrentDirectory();
                string sFile = sPath + "\\" + Filename;
                SecuritySet Security = new SecuritySet();
                IniFiles ini = new IniFiles(sFile);
                string conn = string.Empty;
                INIAccess iniacc = new INIAccess();
                //string strConn = string.Empty;

                if (OleDbConn.State != System.Data.ConnectionState.Open)
                {
                    OleDbConn.Close();

                }
                if (OleDbConn_Log.State != ConnectionState.Closed)
                {
                    OleDbConn_Log.Close();
                }

                OleDbConn.Dispose();
                OleDbConn_Log.Dispose();

                //Security.DESMain();
                NameValueCollection values = new NameValueCollection();
                ini.ReadSectionValues("SecuritySet", values);

                string iniServerName = values["iniServerName"];
                string iniUserName = values["iniUserName"];
                string iniProvider = values["iniProvider"];
                //Security.PwdTrans(values["iniPassWord"], "S");
                string iniPassWord = Security.PwdTrans(values["iniPassWord"], "S");

                if (Security.KeyGen("Key") && Security.KeyGen("IV"))
                {
                    iniConnectString = "Provider=" + iniProvider + ";User ID=" + iniUserName + "/" + iniPassWord + "" +
                                        ";Data Source=" + iniServerName + ";Persist Security Info=True";

                    iniConnectString = Security.EncryptString(iniConnectString);
                }

                conn = Security.DecryptString(iniConnectString);
                iniacc.INIWrite(sFile, "SecuritySet", "iniConnectString", iniConnectString.Trim());

                if (conn != string.Empty)
                {
                    OleDbConn.ConnectionString = conn;
                    OleDbConn_Log.ConnectionString = conn;
                }
                else
                {
                    return false;
                }
                // OleDbConn.ConnectionString = conn;
                if (OleDbConn != null)
                {
                    if (OleDbConn.State != ConnectionState.Closed)
                    {
                        OleDbConn.Close();
                    }
                }

                if (OleDbConn_Log != null)
                {
                    if (OleDbConn_Log.State != ConnectionState.Closed)
                    {
                        OleDbConn_Log.Close();
                    }
                }
                //OleDbConn.ConnectionString = strConn;
                //Conn.ConnectionString = strConn;

                try
                {
                    // Conn.Open();
                    OleDbConn.Open();// = Conn;
                    OleDbConn_Log.Open();
                }
                catch
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Gp_MsgBoxDisplay("服务器链接有错误...!!!" + ex.Message, "W", "DataBase Connection");
                return false;
            }
        }      

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="sMsg">信息内容</param>        
        //---------------------------------------------------------------------------------------
        //   1.ID           : Gp_MsgBoxDisplay
        //   2.Input  Value : sMsg String, {sIcon String}, {sTitle String}
        //   3.Return Value :
        //   4.Create Date  :  
        //   5.Modify Date  :
        //   6.Comment      : Message Box Only Display
        //---------------------------------------------------------------------------------------
        public static void Gp_MsgBoxDisplay(string sMsg)
        {
            Gp_MsgBoxDisplay(sMsg, "", "");
        }
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <param name="sIcon">显示图标.Q:问号;W:惊叹号;I:信息</param>
        public static void Gp_MsgBoxDisplay(string sMsg, string sIcon)
        {
            Gp_MsgBoxDisplay(sMsg, sIcon, "");
        }
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <param name="sIcon">显示图标.Q:问号;W:惊叹号;I:信息</param>
        /// <param name="sTitle">标题名</param>        
        public static void Gp_MsgBoxDisplay(string sMsg, string sIcon, string sTitle)
        {
            MessageBoxIcon sStyle;
            switch (sIcon)
            {
                case "Q":
                    { sStyle = MessageBoxIcon.Question; break; }
                case "W":
                    { sStyle = MessageBoxIcon.Warning; break; }
                case "I":
                    { sStyle = MessageBoxIcon.Information; break; }
                default:
                    { sStyle = MessageBoxIcon.Error; break; }
            }
            if (sTitle.Trim() == "")
            {
                sTitle = "提示";
            }

            MessageBox.Show(sMsg, sTitle, MessageBoxButtons.OK, sStyle);
        }

        /// <summary>
        /// 查找代码
        /// </summary>
        /// <param name="sQuery">查询语句</param>   
        /// <return>string</return>
        public static string Gf_CodeFind(string sQuery)
        {
            string functionReturnValue = "";
            try
            {
                if (GF_DbConnect() == false)
                { return ""; }
                GeneralCommon.Gp_LogData(sQuery);
                OleDbCommand oc = new OleDbCommand(sQuery, OleDbConn);
                functionReturnValue = oc.ExecuteScalar().ToString();
                return functionReturnValue;
            }
            catch (Exception ex)
            {
                Gp_MsgBoxDisplay("Gf_CodeFind Error : " + ex.Message);
                return "";
            }
        }

        /// <summary>
        /// 窗体剧中
        /// </summary>
        /// <param name="Fm">窗体</param>              
         public static void Gp_FormCenter(Form Fm)
        {
            Fm.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Fm.Width) / 2;
            Fm.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Fm.Height) / 2;
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="ReferSql">调用存储过程语句</param>      
        /// <return>DataTable</return>
        //---------------------------------------------------------------------------------------
        //   1.ID           : Gp_MsgBoxDisplay
        //   2.Input  Value : sMsg String, {sIcon String}, {sTitle String}
        //   3.Return Value :
        //   4.Create Date  :  
        //   5.Modify Date  :
        //   6.Comment      : Message Box Only Display
        //---------------------------------------------------------------------------------------
        public static DataTable Gf_ExecProc2Ref(string ReferSql)
        {
            DataTable DataTab_temp = new DataTable();
            if (GeneralCommon.OleDbConn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                    return DataTab_temp;
            }

            try
            {
                GeneralCommon.Gp_LogData(ReferSql);
                OleDbDataAdapter OleDA = new OleDbDataAdapter(ReferSql, OleDbConn);
                OleDA.Fill(DataTab_temp);
                return DataTab_temp;
            }
            catch (Exception ex)
            {
                Gp_MsgBoxDisplay("Gf_ExecProc2Ref Error : " + ex.Message);
                return DataTab_temp;
            }

            finally
            {
                if (GeneralCommon.OleDbConn.State != 0)
                {
                    GeneralCommon.OleDbConn.Close();
                }
            }
        }
      

       
        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="sLOG_data">信息内容</param>         
        /// <return>bool</return>
        public static bool Gp_LogData(string sLOG_data)
        {
            return Gp_Log(null, null, sLOG_data, "FLogData", string.IsNullOrEmpty(GeneralCommon.sUserID) ? "SYSTEM" : GeneralCommon.sUserID);
        }
        public static bool Gp_Log(string sLOG_MSG, string sLOG_data, string sLOG_TYPE)
        {
            return Gp_Log(null, sLOG_MSG, sLOG_data, sLOG_TYPE, GeneralCommon.sUserID);
        }
        public static bool Gp_Log(string sLOG_INFO, string sLOG_MSG, string sLOG_data, string sLOG_TYPE)
        {
            return Gp_Log(sLOG_INFO, sLOG_MSG, sLOG_data, sLOG_TYPE, GeneralCommon.sUserID);
        }
        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="sLOG_INFO">信息</param>         
        /// <param name="sLOG_MSG">日志信息</param>  
        /// <param name="sLOG_data">信息内容</param>       
        /// <param name="sLOG_TYPE">信息类型</param>       
        /// <param name="sINS_EMP">插入人</param>       
        /// <return>bool</return>
        public static bool Gp_Log(string sLOG_INFO, string sLOG_MSG, string sLOG_data, string sLOG_TYPE, string sINS_EMP)
        {
            bool functionReturnValue = false;

            //Db Connection Check 
            if (GeneralCommon.OleDbConn_Log.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                    return false;
            }

            //  OleDbTransaction OleTra;
            //  OleTra = OleDbConn.BeginTransaction();
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                OleDbCommand OleDC = new OleDbCommand("PKG_Z_LOG.SET_LOG", OleDbConn_Log);
                OleDC.CommandType = CommandType.StoredProcedure;

                OleDC.Parameters.Add(new OleDbParameter("sLOG_INFO", string.IsNullOrEmpty(sLOG_INFO) ? "" : sLOG_INFO));//.Replace("'", "''")));
                OleDC.Parameters.Add(new OleDbParameter("sLOG_MSG", string.IsNullOrEmpty(sLOG_MSG) ? "" : sLOG_MSG));//.Replace("'", "''")));
                OleDC.Parameters.Add(new OleDbParameter("sLOG_data", string.IsNullOrEmpty(sLOG_data) ? "" : sLOG_data));//.Replace("'", "''") ));
                OleDC.Parameters.Add(new OleDbParameter("sLOG_TYPE", string.IsNullOrEmpty(sLOG_TYPE) ? "" : sLOG_TYPE));
                OleDC.Parameters.Add(new OleDbParameter("sINS_EMP", string.IsNullOrEmpty(sINS_EMP) ? string.IsNullOrEmpty(GeneralCommon.sUserID) ? "SYSTEM" : GeneralCommon.sUserID : sINS_EMP));
                OleDC.Parameters.Add(new OleDbParameter("sIP", Gf_GetIP()));
                //Ceate Input Parameter 
                //for (int iCount = 0; iCount < 5; iCount++)
                //{
                //    OleDC.Parameters.Add(sLOG_INFO);//new OleDbParameter("", OleDbType.Variant));
                //    OleDC.Parameters[iCount].Value = Para_Info[iCount];
                //    //  OleDC.Parameters[iCount].Size = 2000;
                //    // OleDC.Parameters.Add(Para_Info[iCount]);
                //}

                // OleDC.Parameters.Add("e_code", OleDbType.Integer).Direction = ParameterDirection.Output;
                // OleDC.Parameters.Add("e_msg", OleDbType.Variant).Direction = ParameterDirection.Output;
                //   OleDC.Transaction = OleTra;
                OleDC.ExecuteNonQuery();



                //Process Error Check 
                //if (OleDC.Parameters["e_code"].Value.ToString() != "0")
                //{
                //    OleTra.Rollback();
                //    sErrMessg = "Gf_ExecProc2Modify Error Code : " + Proce_Name + " " + OleDC.Parameters["e_code"].Value.ToString() + "\r" + "Error Mesg : " + OleDC.Parameters["e_msg"].Value.ToString();
                //    Gp_MsgBoxDisplay(sErrMessg);
                //    functionReturnValue = false;
                //}
                //else
                //{
                //    OleTra.Commit();
                //    functionReturnValue = true;
                //}
                //Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                // OleTra.Rollback();
                functionReturnValue = false;
                Cursor.Current = Cursors.Default;
                Gp_MsgBoxDisplay("日志记录错误 : " + sLOG_data + " " + ex.Message);
            }
            //finally

            return functionReturnValue;

        }



        public static string Gf_GetIP()
        {
            string sReturn = "0.0.0.0";
            try
            {
                // string localname = Dns.GetHostName().ToUpper();
                //得到主机信息 
                IPHostEntry ipInfo = Dns.GetHostEntry(Dns.GetHostName().ToUpper());
                //取得IPAddress[] 
                IPAddress[] ipAddr = ipInfo.AddressList;


                for (int i = 0; i < ipAddr.Length; i++)
                {
                    IPAddress ip = ipAddr[i];
                    sReturn = ip.ToString();
                    if (ip.ToString().Contains("10.2."))
                    {
                        ;
                        break;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return sReturn;
        }


        public static bool Gp_LogTxt(string sLOG_INFO)
        {
          //  return true;
            bool bResult = false;
            System.IO.FileStream FS = null;
            System.IO.StreamWriter SW = null;
            try
            {
                //新建文件流
                FS = new System.IO.FileStream(Application.StartupPath + "/Log.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);
                //建立文件对应的输入流
                SW = new System.IO.StreamWriter(FS);
                //向输入流中写入信息
                SW.Write(string.Format("{0}\t{1}\n", DateTime.Now.ToString(), sLOG_INFO) + SW.NewLine);
               

                bResult = true;
            }
            catch
            {
                bResult = false;
            }
            finally
            {
                if (SW != null)
                {
                    SW.Close();
                }
                if (FS != null)
                {
                    FS.Close();
                }
            }
            return bResult;

        }

    }
}