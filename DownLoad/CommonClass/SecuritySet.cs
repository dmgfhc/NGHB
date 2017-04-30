using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace DownLoad
{
    public class SecuritySet
    {
        public static string Filename = "SEC.INI";
        public static string sPath;
        //public string sFile1;
        protected INIAccess oIni = new INIAccess();
        private DESCryptoServiceProvider mCSP = new DESCryptoServiceProvider();
        public static string sFile = string.Empty;

        public string DESMain()
        {
            string iniProvider = "";
            string iniServerName = "";
            string iniUserName = "";
            string iniPassWord = "";
            string iniConnectString = "";
            sPath = System.IO.Directory.GetCurrentDirectory();

            iniServerName = oIni.INIRead(sFile, "SecuritySet", "iniServerName");
            iniUserName = oIni.INIRead(sFile, "SecuritySet", "iniUserName");
            iniProvider = oIni.INIRead(sFile, "SecuritySet", "iniProvider");
            iniPassWord = PwdTrans(oIni.INIRead(sFile, "SecuritySet", "iniPassWord"), "S");

            if (KeyGen("Key") && KeyGen("IV"))
            {
                iniConnectString = "Provider=" + iniProvider + ";User ID=" + iniUserName + "/" + iniPassWord + "" +
                                    ";Data Source=" + iniServerName + ";Persist Security Info=True";
                iniConnectString = EncryptString(iniConnectString);
                return "";
            }

            // Dim cstream As CryptoStream.
            oIni.INIWrite(sFile, "SecuritySet", "iniConnectString", iniConnectString.Trim());
            return iniConnectString;
        }

        //public bool DESMain()
        //{
        //    string iniProvider = "";
        //    string iniServerName = "";
        //    string iniUserName = "";
        //    string iniPassWord = "";
        //    string iniConnectString = "";
        //    // CryptoStream cstream;

        //    sPath = System.IO.Directory.GetCurrentDirectory();
        //    sFile = sPath + @"\" + Filename;
        //    iniServerName = oIni.INIRead(sFile, "SecuritySet", "iniServerName");
        //    iniUserName = oIni.INIRead(sFile, "SecuritySet", "iniUserName");
        //    iniProvider = oIni.INIRead(sFile, "SecuritySet", "iniProvider");
        //    iniPassWord = PwdTrans(oIni.INIRead(sFile, "SecuritySet", "iniPassWord"), "S");

        //    //if ( KeyGen("Key") && KeyGen("IV") ) {
        //    //    iniPassWord = EncryptString(iniPassWord)
        //    //}
        //    //oIni.INIWrite(sFile, "SecuritySet", "iniPassWord", iniPassWord.Trim)
        //    //iniPassWord2 = DecryptString(oIni.INIRead(sFile, "SecuritySet", "iniPassWord"))

        //    //iniPassWord
        //    if (KeyGen("Key") && KeyGen("IV"))
        //    {
        //        iniConnectString = "Provider=" + iniProvider + ";User ID=" + iniUserName + "/" + iniPassWord + "" + ";Data Source=" + iniServerName + ";Persist Security Info=true";
        //        iniConnectString = EncryptString(iniConnectString);
        //    }
        //    oIni.INIWrite(sFile, "SecuritySet", "iniConnectString", iniConnectString.Trim());
        //    return true;
        //}

        public bool  KeyGen(string KeyType)
        {
            if (KeyType == "Key")
            {
                mCSP.GenerateKey();
                return true;
            }
            else if (KeyType == "IV")
            {
                mCSP.GenerateIV();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PwdTrans(string value, string type)
        {
            int i, MyInt;
            string tPwd = "";
            string iPwd = "", e;

            if (type == "T")
            {
                for (i = 0; i < value.Length - 1; i++)
                {
                    e = value.Substring(i, 1);
                    MyInt = Convert.ToInt32(Convert.ToChar(value.Substring(i, 1)));
                    //MyInt = Asc(value.Substring(i, 1));
                    iPwd = Convert.ToString(Convert.ToChar(MyInt - 5 - i));
                    //iPwd = Chr(MyInt - 5 - i);
                    tPwd = tPwd + iPwd;
                }

                return tPwd;
            }
            else if (type == "S")
            {
                for (i = 0; i < value.Length; i++)
                {
                    e = value.Substring(i, 1);
                    MyInt = Convert.ToInt32(Convert.ToChar(value.Substring(i, 1)));
                    //MyInt = Asc(value.Substring(i, 1));
                    iPwd = Convert.ToString(Convert.ToChar(MyInt + 5 + i));
                    tPwd = tPwd + iPwd;
                }

                return tPwd;
            }
            else
            {
                return "";
            }
        }

        public string EncryptString(string Value)
        {
            ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);
            MemoryStream ms = new MemoryStream();
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(Value);

            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();

            return Convert.ToBase64String(ms.ToArray());
        }

        public string DecryptString(string Value)
        {
            ICryptoTransform ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            byte[] byt = Convert.FromBase64String(Value);

            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();
            return System.Text.Encoding.UTF8.GetString(ms.ToArray());
        }

        public bool GetFilePath(string sPath)
        {
            sFile = sPath;
            return true;
        }

        public string Md5HashString(string InputString)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string MD5 = "";
            byte[] dataToHash = new System.Text.ASCIIEncoding().GetBytes(InputString);
            //byte[] hashvalue = CType(System.Security.Cryptography.CryptoConfig.CreateFromName("MD5"), System.Security.Cryptography.HashAlgorithm).ComputeHash(dataToHash);

            //byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl)); (将字符串型转为md5的byte[]型)
            byte[] hashvalue = md5.ComputeHash(dataToHash);

            // 选择16位字符的加密结果
            for (int i = 0; i <= 7; i++)
            {
                MD5 += Convert.ToString((Convert.ToChar(hashvalue[i])));
                MD5 = MD5.ToLower();
            }

            return MD5;
        }
    }

    public class INIAccess
    {
        // 声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, string retVal, int size, string filePath);

        //[DllImport("kernel32")]
        //private static extern int WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public string INIRead(string INIpath, string sectionName, string keyName, string defaultValue)
        {
            Int32 n;
            string sData = new string(' ', 1024);

            n = GetPrivateProfileString(sectionName, keyName, defaultValue, sData, sData.Length, INIpath);

            if (n > 0)
            {
                // INIRead = sData.Substring(0,n);
                return sData.Substring(0, n);
            }
            else
            {
                return "";
            }
        }

#region "INIRead Overloads"

        public string INIRead(string INIpath, string sectionName, string keyName)
        {
            return INIRead(INIpath, sectionName, keyName, "");
        }

        public string INIRead(string INIpath, string sectionName)
        {
            return INIRead(INIpath, sectionName, null, "");
        }

        public string INIRead(string INIpath)
        {
            return INIRead(INIpath, "", "", "");
        }
        
#endregion

        public bool  INIWrite(string INIPath, string sectionName, string keyName, string theValue)
        {
            return WritePrivateProfileString(sectionName, keyName, theValue, INIPath);
         //   return "";
        }

        public bool INIDelete(string INIPath, string sectionName, string keyName)
        {
            return WritePrivateProfileString(sectionName, keyName, null, INIPath);
           // return "";
        }

        public bool INIDelete(string INIPath, string sectionName)
        {
            return WritePrivateProfileString(sectionName, null, null, INIPath);
          //  return "";
        }

        public string sdGetIniInfo(string KeyName)
        {
            //SecuritySet SS = new SecuritySet();
            string theValue = INIRead(SecuritySet.sFile, "SecuritySet", KeyName);
            return theValue;
        }

        public bool   INIWriteYN()
        {
          //  SecuritySet SS = new SecuritySet();
            StreamReader iniRead = new StreamReader(SecuritySet.sFile);
            string iniStr = iniRead.ReadToEnd();

            if (iniStr.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long GetAllSection(string[] SectionArry, string IniFile)
        {
            //'   读取ini文件中的所有项目名   
            //'   IniFile   -   ini文件名   
            //'   SectionArry()   -   存储返回的项目   
            //'   函数返回数组的最大下标值?   (数组最小下标值为0)   
            //'   若没有找到任何值则函数返回   -1   

            string S;
            //  int i = 0;
            int Max = 0;
            int temp2 = -1;
            // GetAllSection = -1;
            //  S = new string(' ',1024);
            StringBuilder temp_s = new StringBuilder(1024);
            GetPrivateProfileString("0", "0", "", temp_s, 1024, IniFile);
            S = temp_s.ToString();
            SectionArry = S.Split(new char[] { '0' });
            Max = SectionArry.GetUpperBound(0) - 2;
            if (Max >= 0)
            {
                string[] temp = new string[Max];
                Array.Copy(SectionArry, temp, SectionArry.Length);
                SectionArry = temp;
                //   ReDim Preserve SectionArry(Max);
            }
            temp2 = Max;
            return temp2;
            //int Max = 0;

            //// GetAllSection = -1;
            //string S = new string(' ', 1024);
            //GetPrivateProfileString("", "", "", S, 1024, IniFile);
            //SectionArry = S.Split(new char[] { ' ' });

            ////Max = UBound(SectionArry) - 2;
            //Max = SectionArry.Length - 2;

            //if (Max >= 0)
            //{

            //}

            //return Max;
            ////if (Max >= 0)
            ////{
            ////    string[] a = new string(Max);
            ////    a
            ////}

            ////GetAllSection = Max;
        }
    }
}
