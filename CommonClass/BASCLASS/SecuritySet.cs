using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

//---------------------------------------------------------------------------------------
//   1.ID           : SecuritySet
//   2.Input  Value :
//   3.Return Value :
//   4.Create Date  : 2005.12.06  Write By ChenXiao
//   5.Modify Date  :
//   6.Comment      : 安全性设置类
//                                     1.INIRead 用三种读取方式读取配置文件，并返回相应Key的value
//                                     3.INIWrite 写入配置文件，无返回值
//                                     4.INIDelete 两种删除方式:根据段删除;根据段和关键字段删除
//---------------------------------------------------------------------------------------
namespace CommonClass
{
	public class SecuritySet
	{
		
		
		public static string Filename = "SEC.INI";
		public static string sPath; //= "C:\WGPRJ\"
		public static string sFile; //= sPath & Filename
		protected INIAccess oIni = new INIAccess();
		private DESCryptoServiceProvider mCSP = new DESCryptoServiceProvider();
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : DESCryptString
		//   2.Input  Value :
		//   3.Return Value : Boolean
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : DES主程序,采用DES双向加密，私钥方式,目前提供两种方式,另外提供可重写的DESCryptString,
		//                    该程序目前只针对GeneralCommon里的数据库联接字符串操作，如果有其它需要请重写
		//                    1.对数据库连接语句进行加密
		//                    2.只对密码部分进行加密
		//---------------------------------------------------------------------------------------
		public void DESMain()
		{
			string iniProvider = "";
			string iniServerName = "";
			string iniUserName = "";
			string iniPassWord = "";
			string iniConnectString = "";
			//Dim cstream As CryptoStream
			
			sPath = System.IO.Directory.GetCurrentDirectory();
			sFile = sPath + "\\" + Filename;
			iniServerName = oIni.INIRead(sFile, "SecuritySet", "iniServerName");
			iniUserName = oIni.INIRead(sFile, "SecuritySet", "iniUserName");
			iniProvider = oIni.INIRead(sFile, "SecuritySet", "iniProvider");
			iniPassWord = PwdTrans(oIni.INIRead(sFile, "SecuritySet", "iniPassWord"), "S");
			
			//If KeyGen("Key") And KeyGen("IV") Then
			//    iniPassWord = EncryptString(iniPassWord)
			//End If
			//oIni.INIWrite(sFile, "SecuritySet", "iniPassWord", iniPassWord.Trim)
			//iniPassWord2 = DecryptString(oIni.INIRead(sFile, "SecuritySet", "iniPassWord"))
			
			//iniPassWord
			if (KeyGen("Key") && KeyGen("IV"))
			{
				iniConnectString = "Provider=" + iniProvider + ";User ID=" + iniUserName + "/" + iniPassWord + "" + ";Data Source=" + iniServerName + ";Persist Security Info=True";
				iniConnectString = EncryptString(iniConnectString);
			}
			oIni.INIWrite(sFile, "SecuritySet", "iniConnectString", iniConnectString.Trim());
		}
		
		//Public Overloads Function DESMain(ByVal iniPassWord As String) As String
		//    If KeyGen("Key") And KeyGen("IV") Then
		//        iniPassWord = EncryptString(iniPassWord)
		//    End If
		//    oIni.INIWrite(sPath, "SecuritySet", "iniPassWord", iniPassWord.Trim)
		//End Function
		
		public bool KeyGen(string KeyType)
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
		
		//Public Overridable Sub DESCryptString()
		
		//End Sub
		public string PwdTrans(string value, string type)
		{
			int i;
			int MyInt;
			string tPwd = "";
			string iPwd = "";
			string e;
			if (type == "T")
			{
				for (i = 0; i <= value.Length - 1; i++)
				{
					e = value.Substring(i, 1);
					MyInt = Strings.Asc(value.Substring(i, 1));
					iPwd = Strings.Chr(MyInt - 5 - i).ToString();
					tPwd = tPwd + iPwd;
				}
				return tPwd;
			}
			else if (type == "S")
			{
				for (i = 0; i <= value.Length - 1; i++)
				{
					e = value.Substring(i, 1);
					MyInt = Strings.Asc(value.Substring(i, 1));
					iPwd = Strings.Chr(MyInt + 5 + i).ToString();
					tPwd = tPwd + iPwd;
				}
				return tPwd;
			}
			else
			{
				return "";
			}
		}
		//---------------------------------------------------------------------------------------
		//   1.ID           : EncryptString
		//   2.Input  Value : 需要加密的字符串
		//   3.Return Value : Boolean
		//   4.Create Date  : 2005.12.11  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 接受值并对其进行加密,然后返回该值
		//---------------------------------------------------------------------------------------
		public string EncryptString(string Value)
		{
			ICryptoTransform ct;
			MemoryStream ms;
			CryptoStream cs;
			byte[] byt;
			
			ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);
			
			byt = System.Text.Encoding.UTF8.GetBytes(Value);
			
			ms = new MemoryStream();
			cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
			cs.Write(byt, 0, byt.Length);
			cs.FlushFinalBlock();
			
			cs.Close();
			
			return Convert.ToBase64String(ms.ToArray());
		}
		//---------------------------------------------------------------------------------------
		//   1.ID           : DecryptString
		//   2.Input  Value : 需要解密的字符串
		//   3.Return Value : Boolean
		//   4.Create Date  : 2005.12.11  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 接受值并对其进行解密,然后返回该值
		//---------------------------------------------------------------------------------------
		public string DecryptString(string Value)
		{
			ICryptoTransform ct;
			MemoryStream ms;
			CryptoStream cs;
			byte[] byt;
			
			ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
			
			byt = Convert.FromBase64String(Value);
			
			ms = new MemoryStream();
			cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
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
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : Md5hash_String
		//   2.Input  Value : 需要加密的字符串
		//   3.Return Value : Boolean
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : MD5加密，单向加密，针对客户的密码进行加密然后保存
		//---------------------------------------------------------------------------------------
		public string Md5HashString(string InputString)
		{
			string code = "";
			string MD5 = "";
			byte[] dataToHash = (new System.Text.ASCIIEncoding()).GetBytes(InputString);
			byte[] hashvalue = ((System.Security.Cryptography.HashAlgorithm) (System.Security.Cryptography.CryptoConfig.CreateFromName("MD5"))).ComputeHash(dataToHash);
			int i;
			for (i = 0; i <= 7; i++) //选择16位字符的加密结果
			{
				MD5 += Conversion.Hex(hashvalue[i]).ToLower();
			}
			return MD5;
		}
		
	}
	//---------------------------------------------------------------------------------------
	//   1.ID           : INIAccess
	//   2.Input  Value :
	//   3.Return Value :
	//   4.Create Date  : 2005.12.06  Write By ChenXiao
	//   5.Modify Date  :
	//   6.Comment      : 配置文件的读写类,提供以下三个基本函数:
	//                                     1.INIRead 用三种读取方式读取配置文件，并返回相应Key的value
	//                                     3.INIWrite 写入配置文件，无返回值
	//                                     4.INIDelete 两种删除方式:根据段删除;根据段和关键字段删除
	//---------------------------------------------------------------------------------------
	public class INIAccess
	{
		
		
		[DllImport("kernel32",EntryPoint="GetPrivateProfileStringW", ExactSpelling=true, CharSet=CharSet.Unicode, SetLastError=true)]
		private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, string lpReturnedString, int nSize, string lpFileName);
		[DllImport("kernel32",EntryPoint="WritePrivateProfileStringW", ExactSpelling=true, CharSet=CharSet.Unicode, SetLastError=true)]
		private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : INIRead
		//   2.Input  Value : INIpath 文件路径
		//                    sectionName 段名称在配置文件中以[****]的形式显示,标示关键字所属段
		//                    keyName 关键字名,即等式左边字段名称
		//                    defaultValue 默认值,一般不用
		//   3.Return Value :
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 配置文件的读取
		//---------------------------------------------------------------------------------------
		public string INIRead(string INIpath, string sectionName, string keyName, string defaultValue)
		{
			string returnValue;
			
			int n;
			string sData;
			sData = Strings.Space(1024);
			n = System.Convert.ToInt32(GetPrivateProfileString(sectionName, keyName, defaultValue, sData, sData.Length, INIpath));
            // INI文件中的一个字段名;lpAppName 下的一个键名，也就是里面具体的变量名;如果没有其前两个参数值，则将此值赋给变量
            //完整的INI文件路径名;接收INI文件中的值的CString对象，即接收缓冲区;接收缓冲区的大小
			if (n > 0)
			{
				returnValue = sData.Substring(0, n);
			}
			else
			{
				returnValue = "";
			}
			
			return returnValue;
		}
		
		#region INIRead Overloads
		
		public string INIRead(string INIpath, string sectionName, string keyName)
		{
			return INIRead(INIpath, sectionName, keyName, "");
		}
		
		public string INIRead(string INIpath, string sectionName)
		{
			return INIRead(INIpath, sectionName, "", "");
		}
		
		public string INIRead(string INIpath)
		{
			return INIRead(INIpath, "", "", "");
		}
		
		#endregion
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : INIWrite
		//   2.Input  Value : INIpath 文件路径
		//                    sectionName 段名称在配置文件中以[****]的形式显示,标示关键字所属段
		//                    keyName 关键字名,即等式左边字段名称
		//                    theValue 写入值
		//   3.Return Value :
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 配置文件的写入
		//---------------------------------------------------------------------------------------
		public void INIWrite(string INIPath, string sectionName, string keyName, string theValue)
		{
			WritePrivateProfileString(sectionName, keyName, theValue, INIPath);
		}
		
		#region INIDelete Overloads
		//---------------------------------------------------------------------------------------
		//   1.ID           : INIDelete
		//   2.Input  Value : INIpath 文件路径
		//                    sectionName 段名称在配置文件中以[****]的形式显示,标示关键字所属段
		//                    keyName 关键字名,即等式左边字段名称
		//                    theValue 写入值
		//   3.Return Value :
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 配置文件的写入
		//---------------------------------------------------------------------------------------
		public void INIDelete(string INIPath, string sectionName, string keyName)
		{
			WritePrivateProfileString(sectionName, keyName, "", INIPath);
		}
		
		public void INIDelete(string INIPath, string sectionName)
		{
			WritePrivateProfileString(sectionName, "", "", INIPath);
		}
		#endregion
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : sdGetIniInfo
		//   2.Input  Value : keyName 关键字名,即等式左边字段名称
		//                    theValue 写入值
		//   3.Return Value :
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 获取配置文件信息,此函数专门为读取数据库连接字符
		//---------------------------------------------------------------------------------------
		public string sdGetIniInfo(string KeyName)
		{
			string theValue;
			theValue = INIRead(SecuritySet.sFile, "SecuritySet", KeyName);
			return theValue;
		}
		//---------------------------------------------------------------------------------------
		//   1.ID           : INIWriteYN
		//   2.Input  Value :
		//   3.Return Value : 是否标志
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : 判断配置文件是否已经写入
		//---------------------------------------------------------------------------------------
		public bool INIWriteYN()
		{
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
			long returnValue;
			//   读取ini文件中的所有项目名
			//   IniFile   -   ini文件名
			//   SectionArry()   -   存储返回的项目
			//   函数返回数组的最大下标值?   (数组最小下标值为0)
			//   若没有找到任何值则函数返回   -1
			
			string S;
			int i = 0;
			int Max = 0;
			
			returnValue = -1;
			S = Strings.Space(1024);
			GetPrivateProfileString("0", "0", "", S, 1024, IniFile);			
			
            SectionArry = S.Split('\0');
			Max = System.Convert.ToInt32((SectionArry.Length - 1) - 2);
			if (Max >= 0)
			{
				Array.Resize(ref SectionArry, Max + 1);
			}
			returnValue = Max;
			
			return returnValue;
		}
		
	}
	
	
}
