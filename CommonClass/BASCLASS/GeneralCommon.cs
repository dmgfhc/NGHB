using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace CommonClass
{
    public partial class GeneralCommon
    {
        public GeneralCommon()
        {
            VbFormBKColor = Color.FromArgb(255, 224, 224, 224);

        }

        public static ADODB.Connection M_CN1 = new ADODB.Connection(); //ADO Connection
        public static ADODB.Recordset AdoRs = new ADODB.Recordset(); //ADO Record Set
        public static ADODB.Command AdoCmd = new ADODB.Command(); //ADO Command

        public static System.Windows.Forms.Form MDIMain;

        public static System.Windows.Forms.ToolBar MDIToolBar;
        public static ImageList ImageList0;
        public static ImageList ImageList1;
        public static ImageList ImageList2;
        public static StatusBar GStatusBar;

        public static string sCraneID;
        public static string sUsername; //User Name
        public static string sUserID; //User Id
        public static string sPassWord; //User Password
        //-----------------------------------------------------------------------
        //----新加
        //-----------------------------------------------------------------------
        public static string sDeptname; //User department
        public static string sDeptid; //User department id
        public static string sShift; //班别(白？夜)
        public static string sShiftGroup; //班组(甲、乙)
        //-----------------------------------------------------------------------

        public static bool bCheck; //Check
        public static bool bPassCheck; //Password Check
        public static string sErrMessg; //Error Message

        public static int iDupCnt; //Duplicate exclusion Count
        public static int iSumCnt; //Sum Column Count

        public static Form cur_Frm;//0802

      //  public static string FileName = "STEELPIA.INI"; //INI File Name
        public static string FileName = System.Environment.CurrentDirectory + "\\STEELPIA.INI"; //INI File Name
        public static Color VbFormBKColor;
        public static bool Has_Check_Main_Version;

        public struct DataDic
        {

            public string sKey; //Condition Key
            public string sJoin; //sJoin
            public string sQuery; //sQuery
            public string sWhere; //sWhere
            public string sWitch; //Control, Spread Type
            public string nameType; //Name Type
            public string DicRefType; //DataDic Refer Type
            public string DataDicType; //DataDic Type
            public bool sSelect; //Data Select Status
            public object sPname; //Spread Name

        }

        public static Collection rControl = new Collection(); //Control (Code, Name)
        public static Collection fControl = new Collection(); //Fields
        public static Collection nmControl = new Collection(); //Name of the code
        public static Collection rlControl = new Collection();
        public static Collection flControl = new Collection();
        public static Collection nmlControl = new Collection();
        public static bool Active_Login; //Re-Login Form Active
        public static string Login_Caption = "MES 用户登录"; //Re-Login Form Caption

        public static DataDic DD;

        //20100112 hux Add
        public static string connstr=""; //加入全局变量存储数据连接字符串
       
       
       /// <summary>
        /// 进行数据库连接，成功返回true，失败返回false。
       /// </summary>
       /// <returns></returns>
        public static bool GF_DbConnect()
        {
            bool returnValue = false;
            //SecuritySet Security = new SecuritySet();
            //INIAccess oIni = new INIAccess();
            try
            {
                if (M_CN1.State == 0)
                {
                    if (connstr == "")
                    {
                        //Security.DESMain();
                        //M_CN1.ConnectionString = Security.DecryptString(oIni.sdGetIniInfo("iniConnectString"));
                        M_CN1.ConnectionString = "Provider=MSDAORA.1;User ID=nisco/nisco01;Data Source=ora9;Persist Security Info=True";


                         //M_CN1.ConnectionString = getConStr(Application.StartupPath + "\\server_config.txt");
                        //   M_CN1.ConnectionString = "Provider=MSDAORA.1;User ID=nisco/nisco01;Data Source=orcl;Persist Security Info=True";
                        //M_CN1.ConnectionString = "Provider=MSDAORA.1;User ID=wkzbmes/wkzbmes;Data Source=ora9;Persist Security Info=True";
                        //M_CN1.ConnectionString = "Provider=OraOLEDB.Oracle.1;Password=doc318;Persist Security Info=True;User ID=main;Data Source=mybtser"
                        connstr = M_CN1.ConnectionString;
                    }
                    else
                    {
                        M_CN1.ConnectionString = connstr;
                    }
                    M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                    M_CN1.CommandTimeout = 10;
                    M_CN1.ConnectionTimeout = 1;
                    M_CN1.Open(connstr, "", "", -1);
                    returnValue = true;
                }

            }
            catch (Exception ex)
            {
                Gp_MsgBoxDisplay((string)("服务器链接有错误...!!!" + ex.Message), "W", "DataBase Connection");
                returnValue = false;
            }

            return returnValue;
        }

        //public static string getConStr(string appPath)
        //{
        //    string rlt = "";
        //    StreamReader sr = new StreamReader(appPath);
        //    rlt = sr.ReadLine();
        //    sr.Close();
        //    string[] rlt_arr = rlt.Split(';');
        //    string sDataSource = rlt_arr[0].Split('=')[1].Trim();
        //    string SUserID = rlt_arr[1].Split('=')[1].Trim();
        //    string SPassWord = rlt_arr[2].Split('=')[1].Trim();

        //    rlt = "Provider=MSDAORA.1;User ID=" + SUserID + "/" + SPassWord + ";Data Source=" + sDataSource + ";Persist Security Info=True";
        //    return rlt;
        //}
        //public static string getConStr(string appPath)
        //{
        //    string rlt = "";
        //    StreamReader sr = new StreamReader(appPath);
        //    rlt = sr.ReadLine();
        //    sr.Close();
        //    if (isPlainCode(rlt) == "1")
        //        Encrypt(rlt, appPath);
        //    else
        //        rlt = Decipher(rlt);
        //    return rlt;
        //}
        public static string getConStr(string appPath)
        {
            string rlt = "";
            StreamReader sr = new StreamReader(appPath);
            rlt = sr.ReadLine();
            sr.Close();
            if (isPlainCode(rlt) == "0")
                rlt = Decipher(rlt);
            else
                Encrypt(rlt, appPath);

            string[] rlt_arr = rlt.Split(';');
            string sDataSource = rlt_arr[0].Split('=')[1].Trim();
            string SUserID = rlt_arr[1].Split('=')[1].Trim();
            string SPassWord = rlt_arr[2].Split('=')[1].Trim();

            rlt = "Provider=MSDAORA.1;User ID=" + SUserID + "/" + SPassWord + ";Data Source=" + sDataSource + ";Persist Security Info=True";
            return rlt;
        }

        private static string isPlainCode(string conn_str)
        {
            string[] conn_str_arr = new string[100];
            conn_str_arr = conn_str.Split(';');
            if (conn_str_arr.Length == 0) return "0";
            try
            {
                if (conn_str_arr[0].Split('=')[0].ToLower() == "data source"
                    && conn_str_arr[1].Split('=')[0].ToLower() == "user"
                    && conn_str_arr[2].Split('=')[0].ToLower() == "password")
                    return "1";
                else
                    return "0";
            }
            catch(Exception ex){return "0";}
        }


        //加密
        private static string Encrypt(string conn_str, string appPath)
        {
            string rlt = "";
            for (int i = 0; i < conn_str.Length; i++)
            {
                rlt += ((int)Convert.ToChar(conn_str.Substring(i, 1)) + 5).ToString().PadLeft(3, '0');
            }
            StreamWriter sw = new StreamWriter(appPath);
            sw.Write(rlt);
            sw.Close();
            return rlt;
        }


        //解密
        private static string Decipher(string conn_str)
        {
            string rlt = "";
            for (int i = 0; i < conn_str.Length; i++)
            {
                rlt += Convert.ToChar(int.Parse(conn_str.Substring(i, 3)) - 5).ToString();
                i = i + 2;
            }
            return rlt;
        }



      
        /// <summary>
        /// 获得本机局域网IP地址 
        /// </summary>
        /// <returns></returns>
        public static string getIPAddress()
        {
            System.Net.IPAddress addr;
            addr = new System.Net.IPAddress(System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].Address);
            return addr.ToString();
        }

        /// <summary>
        /// 根据传入的Cd_Mana_No及Code在公共代码表中找出对应的名称
        /// nameType=1 CD_SHORT_NAME
        /// nameType=2 CD_NAME
        /// nameType=3 CD_FULL_ENG
        /// default CD_NAME
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Cd_Mana_No"></param>
        /// <param name="Code"></param>
        /// <param name="nameType"></param>
        /// <returns></returns>
        public static string Gf_ComnNameFind(ADODB.Connection Conn, string Cd_Mana_No, string Code, int nameType)
        {
            string rlt = "";
            string sQuery;
            ADODB.Recordset AdoRs;
            try
            {
            }
            catch (Exception ex)
            {
            }
            //Db Connection Check
            if (Conn.State == 0)
                if (GF_DbConnect() == false) return "FAIL";

            AdoRs = new ADODB.Recordset();

            switch (nameType)
            {

                case 1:        //Short Name
                    sQuery = "SELECT CD_SHORT_NAME FROM ZP_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                    break;
                case 2:       //Full Name
                    sQuery = "SELECT CD_NAME       FROM ZP_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                    break;
                case 3:        //Short Eng Name
                    sQuery = "SELECT CD_SHORT_ENG  FROM ZP_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                    break;
                case 4:        //Full Eng Name
                    sQuery = "SELECT CD_FULL_ENG   FROM ZP_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                    break;
                default:       //Full Name
                    sQuery = "SELECT CD_NAME       FROM ZP_CD WHERE CD_MANA_NO = '" + Cd_Mana_No + "' AND CD = '" + Code + "' ";
                    break;

            }
            rlt = Gf_CodeFind(Conn, sQuery);

            return rlt;
        }

       /// <summary>
       /// 向Combox控件中加载从sql语句得到的结果。
       /// </summary>
       /// <param name="Cbo"></param>
       /// <param name="sQuery"></param>
       /// <returns></returns>
        public static bool Gf_ComboAdd(ComboBox Cbo, string sQuery)
        {
            bool RltValue = false;
            if (M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return false;

            try
            {
                Cbo.Items.Clear();
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                AdoRs.Open(sQuery, M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);//执行sql语句。

                if (Cbo.DropDownStyle == ComboBoxStyle.Simple) Cbo.Items.Add(" ");
                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    RltValue = true;

                    while (!AdoRs.EOF)
                    {
                        if (Cbo.DropDownStyle == ComboBoxStyle.Simple)
                        {
                            if (AdoRs.Fields[0].Value != null)
                            {
                                Cbo.Items.Add(AdoRs.Fields[1].Value.ToString() + AdoRs.Fields[1].Value.ToString());
                            }
                        }
                        else
                        {
                            if (AdoRs.Fields[0].Value != null)
                            {
                                Cbo.Items.Add(AdoRs.Fields[0].Value);
                            }
                        }
                        AdoRs.MoveNext();
                    }
                }
            }
            catch (Exception ex)
            {
                if (M_CN1.State != 0) M_CN1.Close();
                AdoRs = null;
                RltValue = false;
                Gp_MsgBoxDisplay("Gf_ComboAdd Error : " + ex.Message, "", "");
            }

            AdoRs = null;
            if (M_CN1.State != 0) M_CN1.Close();
            return RltValue;
        }
       
      
        /// <summary>
        /// 将字符串转换成日期或时间格式
        /// </summary>
        /// <param name="DateStr"></param>
        /// <returns></returns>
        public static string Gf_GetDateStr(string DateStr)
        {
            string rltStr = "";
            if (DateStr.Length == 14)//年月日时分秒
            {
                rltStr = DateStr.Substring(0, 4) + "-" + DateStr.Substring(4, 2) + "-" + DateStr.Substring(6, 2) + " "
                    + DateStr.Substring(8, 2) + ":" + DateStr.Substring(10, 2) + ":" + DateStr.Substring(12, 2);
            }
            else if (DateStr.Length == 8)//年月日
            {
                rltStr = DateStr.Substring(0, 4) + "-" + DateStr.Substring(4, 2) + "-" + DateStr.Substring(6, 2) + " ";
            }
            else if (DateStr.Length == 6)//时分秒
            {
                rltStr = DateStr.Substring(0, 2) + ":" + DateStr.Substring(2, 2) + ":" + DateStr.Substring(4, 2);
            }

            return rltStr;
        }

        public static void Close_Pro(string pro_name)
        {
            bool result = true;
            bool find = false;
            while (result)
            {
                string tempName = "";
                int begpos;
                int endpos;
                find = false;

                foreach (System.Diagnostics.Process thisproc in (System.Diagnostics.Process.GetProcesses()))
                {
                    tempName = thisproc.ToString();
                    begpos = System.Convert.ToInt32(tempName.IndexOf("(") + 1);
                    endpos = tempName.IndexOf(")");
                    tempName = tempName.Substring(begpos, endpos - begpos);

                    if (tempName == pro_name)
                    {
                        try
                        {
                            thisproc.Kill();
                        }
                        catch (Exception)
                        {

                        }

                        find = true;
                    }
                }

                if (!find)
                {
                    result = false;
                }

            }
        }
       
        /// <summary>
        /// 显示一个消息框，等待用户点击某个按钮，然后返回指示被点击按钮的值
        /// 弹出待Yse和No按钮的对话框，供用户选择。
        /// </summary>
        /// <param name="sMsg"></param>
        /// <param name="sIcon"></param>
        /// <param name="sTitle"></param>
        /// <returns></returns>
        public static bool Gf_MessConfirm(string sMsg, string sIcon, string sTitle)
        {
            bool returnValue;

            Microsoft.VisualBasic.MsgBoxStyle sStyle; 
            MsgBoxResult iRet;

            //Message Box Style Selection
            switch (sIcon)
            {
                case "Q"://问题类型
                    sStyle = MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2;//  Constants.vbYesNo + Constants.vbQuestion + Constants.vbDefaultButton2;
                    break;
                case "W"://警告类型
                    sStyle = MsgBoxStyle.YesNo | MsgBoxStyle.Exclamation | MsgBoxStyle.DefaultButton2;
                    break;
                                                          
                case "I"://消息类型
                    sStyle = MsgBoxStyle.YesNo | MsgBoxStyle.Information | MsgBoxStyle.DefaultButton2;
                    break;
                                                          
                default:
                    sStyle = MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.DefaultButton2;
                    break;
                                                           
            }

            if (sTitle.TrimEnd() == "")
            {
                sTitle = "提示";
            }

            iRet = Interaction.MsgBox(sMsg, sStyle, sTitle);
            
            

            if (iRet == MsgBoxResult.Yes)//假如选择了“yes”按钮，返回true。
            {
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }

        
        // 弹出对话框，向终端用户显示必要的信息
        //sMsg:向终端用户显示的信息
        //sIcon：显示的图标
        //sTitle：显示的标题
        public static void Gp_MsgBoxDisplay(string sMsg, string sIcon, string sTitle)
        {

            Microsoft.VisualBasic.MsgBoxStyle sStyle;

            //Message Box Style Selection
            switch (sIcon)
            {
                case "Q":
                    sStyle = MsgBoxStyle.OkOnly | MsgBoxStyle.Question;
                    break;
                case "W":
                    sStyle = MsgBoxStyle.OkOnly | MsgBoxStyle.Exclamation;
                    break;
                case "I":
                    sStyle = MsgBoxStyle.OkOnly | MsgBoxStyle.Information;
                    break;
                default:
                    sStyle = MsgBoxStyle.OkOnly | MsgBoxStyle.Critical;
                    break;
            }

            if (sTitle.TrimEnd() == "")
            {
                sTitle = "提示";
            }

            Interaction.MsgBox(sMsg, sStyle, sTitle);

        }

        /// <summary>
        /// 报表模板的复制功能。
        /// FileName：报表的名称。
        /// </summary>
        /// <param name="FileName"></param>
        public static void Gp_CopyModel(string FileName)
        {
            string currentPath = Application.StartupPath;//E:\包含源码\最新\NGHB\BDM\bin\Debug
            string currentModelPath = currentPath + "\\model";//E:\包含源码\最新\NGHB\BDM\bin\Debug\model
            string filePath = currentModelPath + "\\" + FileName;//E:\包含源码\最新\NGHB\BDM\bin\Debug\model\vv.txt
            string currentReportPath = currentPath + "\\report";//E:\包含源码\最新\NGHB\BDM\bin\Debug\report
            //if (Directory.Exists(currentModelPath) == false)//判断目录是否存在
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("没有model文件夹","W","警告");
            //    return;
            //}
            try
            {
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
            catch
            {

            }
        }

        /// <summary>
        /// 自定义sql语句，返回一个double类型的值
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="sQuery"></param>
        /// <returns></returns>
        public static double Gf_FloatFind(ADODB.Connection Conn, string sQuery)
        {
            double returnValue = 0;

            ADODB.Recordset AdoRs;

            try
            {
                //Db Connection Check
                if (Conn.State == 0)
                {
                    if (GF_DbConnect() == false)
                    {
                        returnValue = 0;
                        return returnValue;
                    }
                    
                }

                AdoRs = new ADODB.Recordset();

                //Ado Execute
                AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                        if (Information.VarType(AdoRs.Fields[0].Value) == Constants.vbNull)
                        {
                            returnValue = 0;
                        }
                        else
                        {
                            returnValue = double.Parse(AdoRs.Fields[0].Value.ToString());
                        }
                }
                else
                {
                    returnValue = 0;
                }

                AdoRs.Close();
                AdoRs = null;

                if (Conn.State != 0)
                {
                    Conn.Close();
                }


            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = 0;
                Gp_MsgBoxDisplay((string)("Gf_FloatFind Error : " + ex.Message), "", "");

                if (Conn.State != 0)
                {
                    Conn.Close();
                }

            }

            return returnValue;
        }

       ///////////////////////////////////////////1022
        /// <summary>
        /// 页面按钮的权限。
        /// </summary>
        /// <param name="sPgmID"></param>
        /// <returns></returns>
        public static string Gf_Pgm_Authoritybtn(string sPgmID)
        {
            string returnValue = "";
            string sQuery;
            try
            {
                sQuery = "SELECT PKG_ABZ_AUTHORITY.p_authority_btn(\'" + GeneralCommon.sUserID + "\',";
                sQuery += " \'" + sPgmID + "\') FROM DUAL";
                returnValue = Gf_CodeFind(M_CN1, sQuery);
            }
            catch (Exception ex)
            {
                returnValue = "0";
                Gp_MsgBoxDisplay((string)("Gf_Pgm_Authority Error : " + ex.Message), "", "");
            }

            return returnValue;
        }


        //////////////////////20130509
        /// <summary>
        /// 传入一个sql语句，返回一个二位数组
        /// </summary>
        /// <param name="sQuery"></param>
        /// <returns></returns>
        private static object[,] Gf_ArrayPlReturn(string sQuery)
        {
            object[,] ArrayRecords = null;
            int RsRowCount = 0;
            int RsColCount = 0;
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
                    //GeneralCommon.Gp_MsgBoxDisplay("没有数据...!", "I", "提示");
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
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_ArrayPlReturn Error : " + ex.Message), "W", " 警告");
                return null;
            }
        }
        //////////////////////20130509


        /////////////////////////////////////////1022
        /// <summary>
        /// 根据传入的select语句返回一个字符型的值
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="sQuery"></param>
        /// <returns></returns>
        public static string Gf_CodeFind(ADODB.Connection Conn, string sQuery)
        {
            string returnValue="";
            ADODB.Recordset AdoRs;
            try
            {
                if (Conn.State == 0)
                {
                    if (GF_DbConnect() == false)
                    {
                        returnValue = "FAIL";
                        return returnValue;
                    }
                }

                AdoRs = new ADODB.Recordset();

                //Ado Execute
                AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly,1);
                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    if (!AdoRs.EOF)
                    {
                        if (Information.VarType(AdoRs.Fields[0].Value) == Constants.vbNull)
                        {
                            returnValue = "";
                        }
                        else
                        {
                            returnValue = AdoRs.Fields[0].Value.ToString();
                        }
                    }
                }
                else
                {
                    returnValue = "";
                }

                AdoRs.Close();
                AdoRs = null;
                if (Conn.State != 0)
                {
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = "";
                Gp_MsgBoxDisplay((string)("Gf_CodeFind Error : " + ex.Message), "", "");
                if (Conn.State != 0)
                {
                    Conn.Close();
                }

            }
            return returnValue;
        }
      
        
        /// <summary>
        /// 窗体居中.
        /// </summary>
        /// <param name="Fm"></param>
        public static void Gp_FormCenter(System.Windows.Forms.Form Fm)
        {

            Fm.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Fm.Width) / 2;
            Fm.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Fm.Height) / 2;

        }

       
        /// <summary>
        /// 页面打开时，从文件STEELPIA.INI读取页面的位置信息。
        /// </summary>
        /// <param name="oForm"></param>
        /// <param name="fType"></param>
        public static void Gp_FormLoc_Get(Form oForm, string fType)
        {

            Win32ApiClass Win32ApiClass = new Win32ApiClass();

            string sEcname;
            string sKey;

            sEcname = oForm.Name + fType;

            sKey = "TOP";
            oForm.Top = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, oForm.Top, FileName);

            sKey = "LEFT";
            oForm.Left = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, oForm.Left, FileName);

            sKey = "HEIGHT";
            oForm.Height = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, oForm.Height, FileName);

            sKey = "WIDTH";
            oForm.Width = Win32ApiClass.GetPrivateProfileInt(sEcname, sKey, oForm.Width, FileName);

        }

        
        /// <summary>
        /// 关闭页面时，将当前页面位置信息（TOP，LEFT，HEIGHT，WIDTH）写入文件STEELPIA.INI。
        /// </summary>
        /// <param name="oForm"></param>
        /// <param name="fType"></param>
        public static void Gp_FormLoc_Set(Form oForm, string fType)
        {

            SpreadCommon SpreadCommon = new SpreadCommon();
            Win32ApiClass Win32ApiClass = new Win32ApiClass();

            string sEcname;
            string sKey;
            string sValue;

            sEcname = oForm.Name + fType;

            sKey = "TOP";

            sValue = oForm.Top.ToString();
            Win32ApiClass.WritePrivateProfileString(sEcname, sKey, sValue, GeneralCommon.FileName);

            sKey = "LEFT";

            sValue = oForm.Left.ToString();
            Win32ApiClass.WritePrivateProfileString(sEcname, sKey, sValue, GeneralCommon.FileName);

            sKey = "HEIGHT";

            sValue = oForm.Height.ToString();
            Win32ApiClass.WritePrivateProfileString(sEcname, sKey, sValue, GeneralCommon.FileName);

            sKey = "WIDTH";

            sValue = oForm.Width.ToString();
            Win32ApiClass.WritePrivateProfileString(sEcname, sKey, sValue, GeneralCommon.FileName);

        }

       
        /// <summary>
        /// 根据程序代码读取权限：查询，插入，修改，删除。其中使用了本类的UserID变量
        /// </summary>
        /// <param name="sPgmID"></param>
        /// <returns></returns>
        public static string Gf_Pgm_Authority(string sPgmID)
        {
            string returnValue;

            string sQuery;
            string sSec_Authority;
            string sPgm_Authority;

            try
            {

                //'Program ID Check
                sQuery = "SELECT PGM_SECURITY FROM BBC_PGMINF WHERE PGM_ID = \'" + sPgmID + "\'";
                sSec_Authority = Gf_CodeFind(M_CN1, sQuery);

                //'Authority Check
                sQuery = "SELECT PKG_ABZ_AUTHORITY.P_AUTHORITY(\'" + GeneralCommon.sUserID + "\',";
                sQuery += " \'" + sPgmID + "\') FROM DUAL";
                sPgm_Authority = Gf_CodeFind(M_CN1, sQuery);

                if (sSec_Authority == "1") //Inquiry Security Check
                {
                    if (sPgm_Authority.Trim() != "")
                    {
                        returnValue = sPgm_Authority.Trim();
                    }
                    else
                    {
                        returnValue = "0000";
                    }
                }
                else
                {
                    if (sPgm_Authority.Trim() != "") //Default Inquiry Authority
                    {
                        returnValue = "1" + sPgm_Authority.Trim().Substring(sPgm_Authority.Trim().Length - 3, 3); //Authority Check
                    }
                    else
                    {
                        returnValue = "1000"; //Only Inquiry Possible
                    }
                }

            }
            catch (Exception ex)
            {
                returnValue = "FAIL";
                Gp_MsgBoxDisplay((string)("Gf_Pgm_Authority Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

        
        /// <summary>
        /// 根据当前画面的权限，处理MC的权限。
        /// </summary>
        /// <param name="sAuthority"></param>
        /// <param name="Mc"></param>
        /// <param name="Sc"></param>
        /// <returns></returns>
        public static bool Gf_Mc_Authority(string sAuthority, Collection Mc, Collection Sc)
        {
            bool returnValue=false;

            int iCount;
            bool sProcess;

            try
            {

                //FormType "Master", "Hdetail", "PopMaster"
                switch (sAuthority.Substring(1, 3)) //Insert, Update, Delete
                {

                    case "000": //No Authority
                        returnValue = false;
                        break;

                    case "001": //Delete Authority

                        sProcess = false;

                        if (Sc != null)
                        {

                            for (iCount = 1; iCount <= ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].RowCount; iCount++)
                            {
                                ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].ActiveColumnIndex = 0;

                                ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].ActiveRowIndex = iCount;
                                if (((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "增加" ||
                                    ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "删除")
                                {
                                    sProcess = true;
                                    break;
                                }
                            }

                        }

                        if (sProcess)
                        {
                            return true;
                        }
                        

                        if (((Control)((Collection)Mc["pControl"])[1]).Enabled)
                        {
                            Gp_MsgBoxDisplay("没有对该界面的输入权限...!!!", "I", "");
                            returnValue = false;
                        }
                        else
                        {
                            returnValue = true;
                        }
                        break;

                    case "010": //Update Authority

                        if (((Control)((Collection)Mc["pControl"])[1]).Enabled)
                        {
                            Gp_MsgBoxDisplay("没有对该界面的输入权限..!!!", "I", "");
                            returnValue = false;
                        }
                        else
                        {
                            returnValue = true;
                        }
                        break;

                    case "011": //Update, Delete Authority

                        if (((Control)((Collection)Mc["pControl"])[1]).Enabled)
                        {
                            Gp_MsgBoxDisplay("没有对该界面的输入权限..!!!", "I", "");
                            returnValue = false;
                        }
                        else
                        {
                            returnValue = true;
                        }
                        break;

                    case "100": //Insert Authority

                        if (((Control)((Collection)Mc["pControl"])[1]).Enabled == false)
                        {

                            sProcess = false;

                            if (Sc != null)
                            {

                                for (iCount = 1; iCount <= ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].RowCount; iCount++)
                                {                                 
                                    if (((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "增加" ||
                                     ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "删除")
                                    {
                                        sProcess = true;
                                        break;
                                    }
                                }

                            }

                            if (sProcess)
                            {
                                return true;
                            }                          

                            Gp_MsgBoxDisplay("没有对改界面的修改权限?..!!!", "I", "");
                            returnValue = false;
                        }
                        else
                        {
                            returnValue = true;
                        }
                        break;

                    case "101": //Insert, Delete Authority

                        sProcess = false;

                        if (Sc != null)
                        {
                            for (iCount = 1; iCount <= ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].RowCount; iCount++)
                            {
                                if (((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "增加" ||
                                    ((FarPoint.Win.Spread.FpSpread)Sc["Spread"]).Sheets[0].GetText(iCount, 0) == "删除")
                                {
                                    sProcess = true;
                                    break;
                                }
                            }
                        }

                        if (sProcess)
                        {
                            return true;
                        }                       

                        if (((Control)((Collection)Mc["pControl"])[1]).Enabled == false)
                        {
                            Gp_MsgBoxDisplay("没有对改界面的修改权限...!!!!!!", "I", "");
                            returnValue = false;
                        }
                        else
                        {
                            returnValue = true;
                        }
                        break;

                    case "110": //Insert, Update Authority
                        returnValue = true;
                        break;

                    case "111": //Insert, Update, Delete Authority
                        returnValue = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                Gp_MsgBoxDisplay((string)("Gf_Mc_Authority Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

        
        /// <summary>
        /// 根据当前画面的权限，处理当前画面Sc的权限
        /// </summary>
        /// <param name="sAuthority"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public static bool Gf_Sc_Authority(string sAuthority, string iType)
        {
            bool returnValue;

            //FormType "Sheet", "Hsheet", "PopSheet", "Hdetail"
            if (iType == "I")
            {

                //Insert Authority Check
                if (sAuthority.Substring(1, 1) == "0")
                {
                    returnValue = false;
                }
                else
                {
                    returnValue = true;
                }

            }
            else
            {
                //Update Authority Check
                if (sAuthority.Substring(2, 1) == "0")
                {
                    returnValue = false;
                }
                else
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }

        
        /// <summary>
        /// 判断当前画面是否已经加载。
        /// </summary>
        /// <param name="sFormID"></param>
        /// <returns></returns>
        public static bool Gf_IsFormLode(string sFormID)
        {

            if (!(MDIMain.MdiChildren == null))
            {
                foreach (Form frm in MDIMain.MdiChildren)
                {
                    if (sFormID == frm.Name)
                    {
                        frm.Select();
                        return true;
                    }
                }
            }
            return false;
        }

       
        /// <summary>
        ///  判断当前画面是否已经加载。
        /// </summary>
        /// <param name="sFormID"></param>
        /// <returns></returns>
        public static bool Gf_IsFormLoad(string sFormID)
        {

            if (!(MDIMain.MdiChildren == null))
            {
                foreach (Form frm in MDIMain.MdiChildren)
                {
                    if (sFormID == frm.Name)
                    {
                        frm.Select();
                        return true;
                    }
                }
            }
            return false;
        }

     
        public static void GetAllControls(Control control, Form frm)
        {
            if (control is Splitter)
                Win32ApiClass.WritePrivateProfileString(frm.Name, control.Name, ((Splitter)control).SplitPosition.ToString(), GeneralCommon.FileName);
            
            foreach (Control con in control.Controls)
            {               
                if (con.Controls.Count > 0)
                {
                    GetAllControls(con, frm);
                }
            }
        }

        public static void SetSplitPos(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                GetAllControls(c, frm);
            }              
        }

        public static bool Gf_IsFormLodeN(string sFormID)
        {
            foreach (Form frm in Application.OpenForms)
                {
                    if (sFormID == frm.Name)
                    {
                        frm.Activate();
                        return true;
                    }
                }
            return false;
        }

        
       
        /// <summary>
        /// 自定义调用后台程序
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Proce_Name"></param>
        /// <param name="Para_Info"></param>
        /// <returns></returns>
        public static bool Gf_ExecProcedure(ADODB.Connection Conn, string Proce_Name, params object[] Para_Info)
        {
            bool returnValue=false;

            //Dim sQuery As String
            int iCount;
            object[,] OutParam = new object[3, 5];
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode;

            ADODB.Command adoCmd;

            try
            {

                //Db Connection Check
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return returnValue;
                    }
                }

                Cursor.Current = Cursors.WaitCursor;

                //Ado Setting
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();

                Conn.BeginTrans();

                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = Proce_Name;

                //Ceate Input Parameter
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                //Input Parameters Value Setting
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters[iCount].Value = Para_Info[iCount];
                }
                object value = null;
                
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                adoCmd.Execute(out value);

                //Process Error Check
                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                {
                   
                    ret_Result_ErrCode =int.Parse( adoCmd.Parameters["arg_e_code"].Value.ToString());
                    ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);
                    Conn.RollbackTrans();//1123
                    sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                    Gp_MsgBoxDisplay(sErrMessg, "", "");
                    returnValue = false;
                }
                else
                {
                    Conn.CommitTrans();
                    returnValue = true;
                }

                adoCmd = null;
                Cursor.Current = Cursors.Default;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                Conn.RollbackTrans();
                returnValue = false;
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

        
        /// <summary>
        /// 自定义调用后台程序
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Proce_Name"></param>
        /// <param name="Para_Info"></param>
        /// <returns></returns>
        public static bool Gf_ExecProcedureQ(ADODB.Connection Conn, string Proce_Name, params object[] Para_Info)
        {
            bool returnValue=false;

            //Dim sQuery As String
            int iCount;
            object[,] OutParam = new object[3, 5];
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
            string ret_Result_ErrCodeQ;

            ADODB.Command adoCmd;

            //Return Error Code Parameter
            OutParam[1, 1] = "arg_e_code";
            OutParam[1, 2] = ADODB.DataTypeEnum.adVarChar;
            OutParam[1, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            OutParam[1, 4] = 256;

            //Return Error Messsage Parameter
            OutParam[2, 1] = "arg_e_msg";
            OutParam[2, 2] = ADODB.DataTypeEnum.adVarChar;
            OutParam[2, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            OutParam[2, 4] = 256;

            try
            {

                //Db Connection Check
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return returnValue;
                    }
                }

                Cursor.Current = Cursors.WaitCursor;

                //Ado Setting
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();

                Conn.BeginTrans();

                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = Proce_Name;

                //Ceate Input Parameter
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                //Input Parameters Value Setting
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters[iCount].Value = Para_Info[iCount];
                }
                object value = null;
               
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));

                adoCmd.Execute(out value);

                //Process Error Check
                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                {
                    
                    ret_Result_ErrCodeQ = (string)(adoCmd.Parameters["arg_e_code"].Value);
                    ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);
                    Conn.RollbackTrans();
                    sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                    Gp_MsgBoxDisplay(sErrMessg, "", "");
                    returnValue = false;
                }
                else
                {
                    Conn.CommitTrans();
                    returnValue = true;
                }

                adoCmd = null;
                Cursor.Current = Cursors.Default;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                Conn.RollbackTrans();
                returnValue = false;
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

        
        /// <summary>
        ///  执行传入的sql语句，成功返回true，失败返回false。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="sQuery"></param>
        /// <returns></returns>
        public static bool Gf_ExecSql(ADODB.Connection Conn, string sQuery)
        {
            bool returnValue=false;

            //Dim iCount As Integer
            object[,] OutParam = new object[3, 5];

            ADODB.Command adoCmd;

            try
            {

                //Db Connection Check
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return returnValue;
                    }
                }

                Cursor.Current = Cursors.WaitCursor;

                //Ado Setting
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();

                Conn.BeginTrans();

                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandText = sQuery;

                object null_object = null;
                object null_object2 = null;
                adoCmd.Execute(out null_object, ref null_object2, -1);
                Conn.CommitTrans();
                adoCmd = null;
                Cursor.Current = Cursors.Default;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
            }
            catch (Exception ex)
            {
                adoCmd = null;
                Conn.RollbackTrans();
                returnValue = false;
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                Gp_MsgBoxDisplay((string)("Gf_ExecProcedure Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

       
        /// <summary>
        /// 调用后台程序，获取后台程序返回的一个或多个值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Proce_Name"></param>
        /// <param name="OutPut_Cnt"></param>
        /// <param name="Para_Info"></param>
        /// <returns></returns>
        public static Array Gf_ExecProcedureRe(ADODB.Connection Conn, string Proce_Name, int OutPut_Cnt, params object[] Para_Info)
        {
            Array returnValue=null;

            //Dim sQuery As String
            int iCount;
            object[] ReturnArry;
            object[,] OutParam = new object[3, 5];
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode;

            ADODB.Command adoCmd;

            //Error Code, Message Return
            ReturnArry = new object[OutPut_Cnt - 1 + 1];

            //Return Error Code Parameter
            OutParam[1, 1] = "arg_e_code";
            OutParam[1, 2] = ADODB.DataTypeEnum.adInteger;
            OutParam[1, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            OutParam[1, 4] = 1;

            //Return Error Messsage Parameter
            OutParam[2, 1] = "arg_e_msg";
            OutParam[2, 2] = ADODB.DataTypeEnum.adVarChar;
            OutParam[2, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            OutParam[2, 4] = 256;

            try
            {

                //Db Connection Check
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return returnValue;
                    }
                }

                Cursor.Current = Cursors.WaitCursor;

                //Ado Setting
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                Conn.BeginTrans();


                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = Proce_Name;

                //Ceate Input Parameter
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                //Input Parameters Value Setting
                for (iCount = 0; iCount <= Para_Info.Length - 1; iCount++)
                {
                    adoCmd.Parameters[iCount].Value = Para_Info[iCount];
                }

                //Error Code, Message Return
                object value = null;
               
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                //Ceate Input Parameter
                for (iCount = 2; iCount <= OutPut_Cnt + 1; iCount++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter(iCount.ToString(), ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamOutput, 0, null));
                }


                adoCmd.Execute(out value);

                //Process Error Check
                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                {
                    ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                    ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);
                    Conn.RollbackTrans();

                    sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);
                    Gp_MsgBoxDisplay(sErrMessg, "", "");
                    ReturnArry = null;

                }
                else
                {
                    for (iCount = 2; iCount <= OutPut_Cnt + 1; iCount++)
                    {
                        ReturnArry[iCount - 2] = adoCmd.Parameters[iCount.ToString()].Value;
                    }
                    Conn.CommitTrans();

                }

                adoCmd = null;
                returnValue = ReturnArry;
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }

            }
            catch (Exception ex)
            {
                adoCmd = null;
                Conn.RollbackTrans();
                returnValue = ReturnArry;
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                Gp_MsgBoxDisplay((string)("Gf_ExecProcedureRe Error : " + ex.Message), "", "");
            }

            return returnValue;
        }
         

        /// <summary>
        /// 根据传入的权限对当前窗体设置工具栏的状态。
        /// </summary>
        /// <param name="FormType"></param>
        /// <param name="ButtonType"></param>
        /// <param name="sAuthority"></param>
        /// <returns></returns>
        public static bool Gp_FormMenuSetting(string FormType, string ButtonType, string sAuthority)
        {

            if (cur_Frm != null)
                if (cur_Frm.MdiParent == null) return true;
            //0801耿朝雷 16:17start
            switch (FormType)
            {
                case "Start":
                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";
                    MDIToolBar.Buttons[14].Enabled = true;

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";
                    MDIToolBar.Buttons[16].Enabled = true;

                    ImageList0.Images[0] = ImageList2.Images[0];
                    MDIToolBar.Buttons[0].Tag = "F";
                    //MDIToolBar.Buttons[0].Enabled = false;


                    ImageList0.Images[1] = ImageList2.Images[1];
                    MDIToolBar.Buttons[1].Tag = "F";
                    //MDIToolBar.Buttons[1].Enabled = false;

                    ImageList0.Images[2] = ImageList2.Images[2];
                    MDIToolBar.Buttons[3].Tag = "F";
                    //MDIToolBar.Buttons[3].Enabled = false;

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";
                    //MDIToolBar.Buttons[4].Enabled = false;

                    ImageList0.Images[4] = ImageList2.Images[4];
                    MDIToolBar.Buttons[6].Tag = "F";
                    //MDIToolBar.Buttons[6].Enabled = true;

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";
                    //MDIToolBar.Buttons[7].Enabled = true;

                    ImageList0.Images[6] = ImageList2.Images[6];
                    MDIToolBar.Buttons[8].Tag = "F";
                    //MDIToolBar.Buttons[8].Enabled = true;

                    ImageList0.Images[7] = ImageList2.Images[7];
                    MDIToolBar.Buttons[10].Tag = "F";
                    //MDIToolBar.Buttons[10].Enabled = true;

                    ImageList0.Images[8] = ImageList2.Images[8];
                    MDIToolBar.Buttons[11].Tag = "F";
                    //MDIToolBar.Buttons[11].Enabled = true;

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";
                    //MDIToolBar.Buttons[13].Enabled = true;

                   

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste
                    break;
                case "Master":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList1.Images[2];
                    MDIToolBar.Buttons[3].Tag = "T";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList2.Images[4];
                    MDIToolBar.Buttons[6].Tag = "F";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList2.Images[6];
                    MDIToolBar.Buttons[8].Tag = "F";

                    ImageList0.Images[7] = ImageList1.Images[7];
                    MDIToolBar.Buttons[10].Tag = "T";

                    ImageList0.Images[8] = ImageList1.Images[8];
                    MDIToolBar.Buttons[11].Tag = "T";

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = true; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "Hsheet":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList1.Images[2];
                    MDIToolBar.Buttons[3].Tag = "T";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList1.Images[4];
                    MDIToolBar.Buttons[6].Tag = "T";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList1.Images[6];
                    MDIToolBar.Buttons[8].Tag = "T";

                    ImageList0.Images[7] = ImageList1.Images[7];
                    MDIToolBar.Buttons[10].Tag = "T";

                    ImageList0.Images[8] = ImageList1.Images[8];
                    MDIToolBar.Buttons[11].Tag = "T";

                    ImageList0.Images[9] = ImageList1.Images[9];
                    MDIToolBar.Buttons[13].Tag = "T";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = true; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "Sheet":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList1.Images[2];
                    MDIToolBar.Buttons[3].Tag = "T";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList1.Images[4];
                    MDIToolBar.Buttons[6].Tag = "T";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList1.Images[6];
                    MDIToolBar.Buttons[8].Tag = "T";

                    ImageList0.Images[7] = ImageList1.Images[7];
                    MDIToolBar.Buttons[10].Tag = "T";

                    ImageList0.Images[8] = ImageList1.Images[8];
                    MDIToolBar.Buttons[11].Tag = "T";

                    ImageList0.Images[9] = ImageList1.Images[9];
                    MDIToolBar.Buttons[13].Tag = "T";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = true; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "PopSheet":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList2.Images[2];
                    MDIToolBar.Buttons[3].Tag = "F";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList2.Images[4];
                    MDIToolBar.Buttons[6].Tag = "F";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList2.Images[6];
                    MDIToolBar.Buttons[8].Tag = "F";

                    ImageList0.Images[7] = ImageList2.Images[7];
                    MDIToolBar.Buttons[10].Tag = "F";

                    ImageList0.Images[8] = ImageList2.Images[8];
                    MDIToolBar.Buttons[11].Tag = "F";

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "Hdetail":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList1.Images[2];
                    MDIToolBar.Buttons[3].Tag = "T";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList1.Images[4];
                    MDIToolBar.Buttons[6].Tag = "T";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList1.Images[6];
                    MDIToolBar.Buttons[8].Tag = "T";

                    ImageList0.Images[7] = ImageList1.Images[7];
                    MDIToolBar.Buttons[10].Tag = "T";

                    ImageList0.Images[8] = ImageList1.Images[8];
                    MDIToolBar.Buttons[11].Tag = "T";

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = true; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = true; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = true; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "ReferNoPr":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList2.Images[2];
                    MDIToolBar.Buttons[3].Tag = "F";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList2.Images[4];
                    MDIToolBar.Buttons[6].Tag = "F";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList2.Images[6];
                    MDIToolBar.Buttons[8].Tag = "F";

                    ImageList0.Images[7] = ImageList2.Images[7];
                    MDIToolBar.Buttons[10].Tag = "F";

                    ImageList0.Images[8] = ImageList2.Images[8];
                    MDIToolBar.Buttons[11].Tag = "F";

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";

                    ImageList0.Images[10] = ImageList2.Images[10];
                    MDIToolBar.Buttons[14].Tag = "F";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = true; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = true; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = true; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;

                case "ReferPr":
                    ImageList0.Images[0] = ImageList1.Images[0];
                    MDIToolBar.Buttons[0].Tag = "T";

                    ImageList0.Images[1] = ImageList1.Images[1];
                    MDIToolBar.Buttons[1].Tag = "T";

                    ImageList0.Images[2] = ImageList2.Images[2];
                    MDIToolBar.Buttons[3].Tag = "F";

                    ImageList0.Images[3] = ImageList2.Images[3];
                    MDIToolBar.Buttons[4].Tag = "F";

                    ImageList0.Images[4] = ImageList2.Images[4];
                    MDIToolBar.Buttons[6].Tag = "F";

                    ImageList0.Images[5] = ImageList2.Images[5];
                    MDIToolBar.Buttons[7].Tag = "F";

                    ImageList0.Images[6] = ImageList2.Images[6];
                    MDIToolBar.Buttons[8].Tag = "F";

                    ImageList0.Images[7] = ImageList2.Images[7];
                    MDIToolBar.Buttons[10].Tag = "F";

                    ImageList0.Images[8] = ImageList2.Images[8];
                    MDIToolBar.Buttons[11].Tag = "F";

                    ImageList0.Images[9] = ImageList2.Images[9];
                    MDIToolBar.Buttons[13].Tag = "F";

                    ImageList0.Images[10] = ImageList1.Images[10];
                    MDIToolBar.Buttons[14].Tag = "T";

                    ImageList0.Images[11] = ImageList1.Images[11];
                    MDIToolBar.Buttons[16].Tag = "T";

                    //					 'Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = true; //; //  'All Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = true; //  'Master Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = true; //  'Spread Copy

                    //                        'Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false; //  'All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false; //  'Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false; //  'Spread Paste

                    break;


            }

            if (cur_Frm != null)
                ((FORMBASE)cur_Frm).Toolbar_St = ButtonType;
           

            MDIToolBar.Wrappable = true;

          
            switch (ButtonType)
            {
                case "SE":
                    switch (FormType)
                    {
                        case "Master":
                            ImageList0.Images[3] = ImageList1.Images[3];//     'Delete;
                            MDIToolBar.Buttons[4].Tag = "T"; break;
                        case "Sheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//     'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";//
                            ImageList0.Images[5] = ImageList1.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";//
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";//
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "Hsheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//     'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";//
                            ImageList0.Images[5] = ImageList1.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";//
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";//
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "PopSheet":
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "Hdetail":
                            ImageList0.Images[3] = ImageList1.Images[3];//Delete
                            MDIToolBar.Buttons[4].Tag = "T";
                            ImageList0.Images[4] = ImageList1.Images[4];//Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList1.Images[5];//Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";
                            ImageList0.Images[6] = ImageList1.Images[6];//Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList1.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "ReferNoPr":
                            ImageList0.Images[9] = ImageList1.Images[9];    //'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            ImageList0.Images[10] = ImageList2.Images[10];//   'Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;
                        case "ReferPr":
                            ImageList0.Images[9] = ImageList1.Images[9];//   'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            ImageList0.Images[10] = ImageList2.Images[10];//  'Print
                            MDIToolBar.Buttons[14].Tag = "T";
                            break;

                    } break;

                case "RE":
                    switch (FormType)
                    {
                        case "Master":
                            ImageList0.Images[3] = ImageList1.Images[3];//     'Delete;
                            MDIToolBar.Buttons[4].Tag = "T"; break;
                        case "Sheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//     'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";//
                            ImageList0.Images[5] = ImageList1.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";//
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";//
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "Hsheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//     'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";//
                            ImageList0.Images[5] = ImageList1.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";//
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";//
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "PopSheet":
                            ImageList0.Images[9] = ImageList1.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "Hdetail":
                            ImageList0.Images[3] = ImageList1.Images[3];//Delete
                            MDIToolBar.Buttons[4].Tag = "T";
                            ImageList0.Images[4] = ImageList1.Images[4];//Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList1.Images[5];//Row Delete
                            MDIToolBar.Buttons[7].Tag = "T";
                            ImageList0.Images[6] = ImageList1.Images[6];//Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList1.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            break;
                        case "ReferNoPr":
                            ImageList0.Images[9] = ImageList1.Images[9];    //'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            ImageList0.Images[10] = ImageList2.Images[10];//   'Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;
                        case "ReferPr":
                            ImageList0.Images[9] = ImageList1.Images[9];//   'Excel
                            MDIToolBar.Buttons[13].Tag = "T";
                            ImageList0.Images[10] = ImageList2.Images[10];//  'Print
                            MDIToolBar.Buttons[14].Tag = "T";
                            break;

                    } break;

                case "FS":
                    switch (FormType)
                    {
                        case "Master":
                            ImageList0.Images[3] = ImageList2.Images[3];//    'Delete
                            MDIToolBar.Buttons[4].Tag = "F";
                            break;
                        case "Sheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//   'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "Hsheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//   'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "Hdetail":
                            ImageList0.Images[3] = ImageList2.Images[3];//Delete
                            MDIToolBar.Buttons[4].Tag = "F";
                            ImageList0.Images[4] = ImageList1.Images[4];//Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "ReferNoPr":

                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            ImageList0.Images[10] = ImageList2.Images[10];//Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;

                        case "ReferPr":

                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            ImageList0.Images[10] = ImageList2.Images[10];//Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;
                    } break;

                case "CLS":
                    switch (FormType)
                    {
                        case "Master":
                            ImageList0.Images[3] = ImageList2.Images[3];//    'Delete
                            MDIToolBar.Buttons[4].Tag = "F";
                            break;
                        case "Sheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//   'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "Hsheet":
                            ImageList0.Images[4] = ImageList1.Images[4];//   'Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//     'Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//     'Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//     'Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "Hdetail":
                            ImageList0.Images[3] = ImageList2.Images[3];//Delete
                            MDIToolBar.Buttons[4].Tag = "F";
                            ImageList0.Images[4] = ImageList1.Images[4];//Row Insert
                            MDIToolBar.Buttons[6].Tag = "T";
                            ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                            MDIToolBar.Buttons[7].Tag = "F";
                            ImageList0.Images[6] = ImageList1.Images[6];//Row Cancel
                            MDIToolBar.Buttons[8].Tag = "T";
                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            break;
                        case "ReferNoPr":

                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            ImageList0.Images[10] = ImageList2.Images[10];//Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;

                        case "ReferPr":

                            ImageList0.Images[9] = ImageList2.Images[9];//Excel
                            MDIToolBar.Buttons[13].Tag = "F";
                            ImageList0.Images[10] = ImageList2.Images[10];//Print
                            MDIToolBar.Buttons[14].Tag = "F";
                            break;
                    } break;

                case "Acopy":

                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = true;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "Mcopy":

                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = true;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "Scopy":

                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = true;//Spread Paste
                    break;
            }




            //'Autority Inquiry Check
            //            If (substring(sAuthority, 1, 1) == "0" )
            if (sAuthority == "" || sAuthority==null)
            {
                MDIToolBar.Refresh();
                return true;
            }



            if (sAuthority.Substring(0, 1) == "0")
            {
                ImageList0.Images[1] = ImageList2.Images[1];//     'Refer
                MDIToolBar.Buttons[1].Tag = "F";
            }


            switch (sAuthority.Substring(1, 3))// 'Insert, Update, Delete
            {
                case "000":// 'No Authority

                    ImageList0.Images[2] = ImageList2.Images[2];//Save
                    MDIToolBar.Buttons[3].Tag = "F";
                    ImageList0.Images[3] = ImageList2.Images[3];//Delete
                    MDIToolBar.Buttons[4].Tag = "F";
                    ImageList0.Images[4] = ImageList2.Images[4];//Row Insert
                    MDIToolBar.Buttons[6].Tag = "F";
                    ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                    MDIToolBar.Buttons[7].Tag = "F";
                    ImageList0.Images[6] = ImageList2.Images[6];//Row Cancel
                    MDIToolBar.Buttons[8].Tag = "F";
                    ImageList0.Images[7] = ImageList2.Images[7];//Copy
                    MDIToolBar.Buttons[10].Tag = "F";
                    ImageList0.Images[8] = ImageList2.Images[8];//Paste
                    MDIToolBar.Buttons[11].Tag = "F";


                    //                    ;//Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false;//All Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false;//Master Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false;//Spread Coopy

                    //                    ;//Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "001":// ;//Delete Authority

                    ImageList0.Images[4] = ImageList2.Images[4];//Row Insert
                    MDIToolBar.Buttons[6].Tag = "F";


                    //                    ;//Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false;//All Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false;//Master Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false;//Spread Coopy


                    //                    ;//Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "010":        //;//Update Authority

                    ImageList0.Images[3] = ImageList2.Images[3];//Delete
                    MDIToolBar.Buttons[4].Tag = "F";
                    ImageList0.Images[4] = ImageList2.Images[4];//Row Insert
                    MDIToolBar.Buttons[6].Tag = "F";
                    ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                    MDIToolBar.Buttons[7].Tag = "F";

                    //                    ;//Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false;//All Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false;//Master Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false;//Spread Coopy

                    //                    ;//Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "011":// ;//Update, Delete Authority

                    ImageList0.Images[4] = ImageList2.Images[4];//Row Insert
                    MDIToolBar.Buttons[6].Tag = "F";

                    //                    ;//Copy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[0].Enabled = false;//All Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[1].Enabled = false;//Master Coopy
                    MDIToolBar.Buttons[10].DropDownMenu.MenuItems[2].Enabled = false;//Spread Coopy

                    //                    ;//Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[0].Enabled = false;//All Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[1].Enabled = false;//Master Paste
                    MDIToolBar.Buttons[11].DropDownMenu.MenuItems[2].Enabled = false;//Spread Paste
                    break;

                case "100":// ;//Insert Authority

                    ImageList0.Images[3] = ImageList2.Images[3];//Delete
                    MDIToolBar.Buttons[4].Tag = "F";
                    ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                    MDIToolBar.Buttons[7].Tag = "F";
                    break;

                case "101":// ;//Insert, Delete Authority
                    break;

                case "110":// ;//Insert, Update Authority

                    ImageList0.Images[3] = ImageList2.Images[3];//Delete
                    MDIToolBar.Buttons[4].Tag = "F";
                    ImageList0.Images[5] = ImageList2.Images[5];//Row Delete
                    MDIToolBar.Buttons[7].Tag = "F";
                    break;

                case "111":// ;//Insert, Update, Delete Authority
                    break;
            }
            MDIToolBar.Refresh();
            return true;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="Fm"></param>
       /// <param name="FormType"></param>
       /// <param name="ButtonType"></param>
       /// <param name="sAuthority"></param>
       /// <returns></returns>
        public static bool Gp_FormMenuSetting(Form Fm, string FormType, string ButtonType, string sAuthority)
        {

            return true;
        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="FormType"></param>
      /// <param name="ButtonType"></param>
      /// <param name="sAuthority"></param>
        public static void Gp_MenuStatus(string FormType, string ButtonType, string sAuthority)
        {


        }

        
        /// <summary>
        /// 检查传入的字符串是否是合法的日期格式。
        /// </summary>
        /// <param name="DateTime"></param>
        /// <returns></returns>
        public static bool Gf_DateTime_Chk(string DateTime)
        {
            bool returnValue;

            try
            {
                switch (DateTime.Length)
                {
                    case 8: //Date
                        returnValue = Information.IsDate(DateTime.Substring(0, 4) + "-" + DateTime.Substring(4, 2) + "-" + DateTime.Substring(6, 2));
                       
                        break;

                    case 12: //Date, Time:Min
                        returnValue = Information.IsDate(DateTime.Substring(0, 4) + "-" + DateTime.Substring(4, 2) + "-" + DateTime.Substring(6, 2));

                        if (returnValue)
                        {
                            if (int.Parse(DateTime.Substring(8, 2)) > 0 && int.Parse(DateTime.Substring(8, 2)) < 24)
                            {

                                if (int.Parse(DateTime.Substring(10, 2)) > 0 && int.Parse(DateTime.Substring(10, 2)) < 60)
                                {
                                }
                                else
                                {
                                    returnValue = false;
                                }
                            }
                            else
                            {
                                returnValue = false;
                            }
                        }
                        break;

                    case 14: //Date, Time:Min:Sec
                        returnValue = Information.IsDate(DateTime.Substring(0, 4) + "-" + DateTime.Substring(4, 2) + "-" + DateTime.Substring(6, 2));

                        if (returnValue)
                        {

                            if (int.Parse(DateTime.Substring(8, 2)) > 0 && int.Parse(DateTime.Substring(8, 2)) < 24)
                            {

                                if (int.Parse(DateTime.Substring(10, 2)) > 0 && int.Parse(DateTime.Substring(10, 2)) < 60)
                                {
                                    if (int.Parse(DateTime.Substring(12, 2)) > 0 && int.Parse(DateTime.Substring(12, 2)) < 60)
                                    {
                                    }
                                    else
                                    {
                                        returnValue = false;
                                    }
                                }
                                else
                                {
                                    returnValue = false;
                                }
                            }
                            else
                            {
                                returnValue = false;
                            }
                        }
                        break;

                    default:

                        returnValue = false;
                        break;

                }

            }
            catch (Exception ex)
            {
                returnValue = false;
                Gp_MsgBoxDisplay((string)("Gf_DateTime_Chk Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

       
        /// <summary>
        /// 将日期格式及时间格式写入注册表。
        /// </summary>
        public static void Gp_DateSetting()
        {
            
            Interaction.SaveSetting("HKCU\\Control Panel\\international", "sShortDate", "REG_SZ", "yyyy-MM-dd");
            Interaction.SaveSetting("HKCU\\Control Panel\\international", "sTimeFormat", "REG_SZ", "HH:mm:ss");

        }
       

        /// <summary>
        /// 根据传入的sql语句，打开一个数据集。调用该函数后，请自行关闭GeneralCommon中的M_CN1
        /// </summary>
        /// <param name="sSql"></param>
        /// <param name="Conn"></param>
        /// <param name="AdoRs"></param>
        /// <returns></returns>
        public static bool Gp_OpenRecordset(string sSql, ADODB.Connection Conn, ADODB.Recordset AdoRs)
        {
            bool returnValue=false;
            bool b_Ok;
            b_Ok = true;

            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return false;
                }
            }
            try
            {
                AdoRs.Open(sSql, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenKeyset,ADODB.LockTypeEnum.adLockReadOnly, -1);

                //if (Conn.State != 0)
                //{
                //    Conn.Close();
                //}
            }
            catch (Exception ex)
            {
                b_Ok = false;
                Gp_MsgBoxDisplay((string)("Gp_OpenRecordset Error : " + ex.Message), "", "");

                if (Conn.State != 0)
                {
                    Conn.Close();
                }
            }

            return b_Ok;
        }

       

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sReportNameLog"></param>
       /// <param name="sBillNo"></param>
       /// <returns></returns>
        public static string GF_GetPrintLog(string sReportNameLog, string sBillNo)
        {
            ADODB.Recordset AdoRs;
            string sQuery;
            string sReturn="";

            if (sReportNameLog == "" || sBillNo == "")
            {
                return "";
            }
            try
            {
                AdoRs = new ADODB.Recordset();
                sQuery = "Select Print_Datetime,to_char(Print_Num) From TZ_PrintLog WHERE Report_Name=\'" + sReportNameLog + "\' and Bill_No=\'" + sBillNo + "\'";
                //Ado Execute
                if (!GeneralCommon.Gp_OpenRecordset(sQuery, GeneralCommon.M_CN1, AdoRs))
                {
                    return "";
                }

                if (AdoRs.BOF || AdoRs.EOF)
                {
                    AdoRs.Close();
                    AdoRs = null;
                    return "";
                }

                while (!AdoRs.EOF)
                {
                    if (sReturn == "")
                    {
                        sReturn = (string)(AdoRs.Fields[0].Value + " " + AdoRs.Fields[1].Value + "份");
                    }
                    else
                    {
                        sReturn = sReturn + ";" + AdoRs.Fields[0].Value + " " + AdoRs.Fields[1].Value + "份";
                    }

                    AdoRs.MoveNext();
                }

                AdoRs.Close();
                AdoRs = null;
                return sReturn;
            }
            catch (Exception ex)
            {
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Open Data Thk Group  : " + ex.ToString()), "", "");
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();//0809 耿朝雷
            }
            if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();//0809 耿朝雷
            return sReturn;
        }

         #region Create by wangyong
        
        /// <summary>
        /// 根据传入的combox，利用它的tag作为CD_MANA_NO，利用它的Text作为CD_NAME，从BBB_CD查询相应的cd，并将cd作为结果返回。
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static string Gf_ComboCdFind(ComboBox Ctrl)
        {
            string sql = "SELECT CD FROM ZP_CD WHERE CD_MANA_NO=\'" + Ctrl.Tag + "\'AND CD_NAME=\'" + Ctrl.Text + "\'";
            return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sql);
        }

        /// <summary>
        /// 利用manu_no作为CD_MANA_NO，利用cd_name作为CD_NAME，从BBB_CD查询相应的cd，并将cd作为结果返回。
        /// </summary>
        /// <param name="manu_no"></param>
        /// <param name="cd_name"></param>
        /// <returns></returns>
        public static string Gf_ComboCdFind(string manu_no, string cd_name)
        {
            string sql = "SELECT CD FROM ZP_CD WHERE CD_MANA_NO=\'" + manu_no + "\'AND CD_NAME=\'" + cd_name + "\'";
            return GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sql);
        }

        /// <summary>
        /// 如果传入的spread的当前行的行头没有“增加”“删除”“修改”，那么在当前行头添加“修改”标示。
        /// 当前行就是传入的iRow。
        /// </summary>
        /// <param name="ss"></param>
        /// <param name="iRow"></param>

        public static void Gf_RowUpdate(FarPoint.Win.Spread.FpSpread ss, int iRow)
        {
            FarPoint.Win.Spread.SheetView with_1 = ss.ActiveSheet;
            switch (with_1.RowHeader.Cells[iRow, 0].Text)
            {
                case "增加":
                case "删除":
                case "修改":
                    break;
                default:
                    with_1.RowHeader.Cells[iRow, 0].Text = "修改";
                    break;
            }
        }

         #endregion
    }
}
