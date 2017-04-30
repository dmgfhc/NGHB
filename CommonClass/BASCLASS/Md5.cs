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

namespace CommonClass
{
	public class MD5
	{
		[DllImport("kernel32",EntryPoint="CreateToolhelp32Snapshot", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int CreateToolhelpSnapshot(int lFlags, int lProcessID);
		[DllImport("kernel32",EntryPoint="Process32First", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int ProcessFirst(int hSnapShot, ref PROCESSENTRY32 uProcess);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int CloseHandle(int hObject);
		
		[DllImport("PSAPI.DLL", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetModuleFileNameExA(int hProcess, int hModule, string ModuleName, int nSize);
		[DllImport("PSAPI.DLL", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int EnumProcessModules(int hProcess, ref int lphModule, int cb, ref int cbNeeded);
		private const short PROCESS_VM_READ = 16;
		private const short PROCESS_QUERY_INFORMATION = 1024;
		
		private const short TH32CS_SNAPPROCESS = 0x2;
		private const short TH32CS_SNAPheaplist = 0x1;
		private const short TH32CS_SNAPthread = 0x4;
		private const short TH32CS_SNAPmodule = 0x8;
		private const float TH32CS_SNAPall = TH32CS_SNAPPROCESS + TH32CS_SNAPheaplist + TH32CS_SNAPthread + TH32CS_SNAPmodule;
		private const short MAX_PATH = 260;
		
		public struct PROCESSENTRY32
		{
            public int dwSize;
            public int cntUsage;
            public int th32ProcessID;
            public int th32DefaultHeapID;
            public int th32ModuleID;
            public int cntThreads;
            public int th32ParentProcessID;
            public int pcPriClassBase;
            public int dwFlags;
		}
		
		
		//The GetCurrentProcess function returns a pseudohandle for the
		//current process.
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetCurrentProcess();
		
		private static FileStream fs;
		private static string Filename;
		private static string sPath;
		private static string sFile;
		private static MD5CryptoServiceProvider mMd5 = new MD5CryptoServiceProvider();
		
		public static string Md5HashFile(string FilePath)
		{
			fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
			byte[] md5byte = mMd5.ComputeHash(fs);
			string Md5string = "";
			for (int k = 0; k <= md5byte.Length - 1; k++)
			{
				Md5string = Md5string + md5byte[k].ToString("x2");
			}
			return Md5string;
		}
		
		public static string Md5HashFile(Process Process)
		{
			string path;
			path = ListProcess(Process);
			fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			byte[] md5byte = mMd5.ComputeHash(fs);
			string Md5string = "";
			for (int k = 0; k <= md5byte.Length - 1; k++)
			{
				Md5string = Md5string + md5byte[k].ToString("x2");
			}
			return Md5string;
		}
		
		//---------------------------------------------------------------------------------------
		//   1.ID           : Md5hash_String
		//   2.Input  Value : 需要加密的字符串
		//   3.Return Value : String
		//   4.Create Date  : 2005.12.06  Write By ChenXiao
		//   5.Modify Date  :
		//   6.Comment      : MD5加密，单向加密
		//---------------------------------------------------------------------------------------
		public static string Md5Main(string InputString)
		{
			string code = "";
			string MD5 = "";
			byte[] dataToHash = (new System.Text.ASCIIEncoding()).GetBytes(InputString);
			byte[] hashvalue = ((System.Security.Cryptography.HashAlgorithm) (System.Security.Cryptography.CryptoConfig.CreateFromName("MD5"))).ComputeHash(dataToHash);
			for (int k = 0; k <= hashvalue.Length - 1; k++)
			{
				MD5 = MD5 + hashvalue[k].ToString("x2");
			}
			return MD5;
		}
		public static string Md5Main(Process Process)
		{
			string path;
			path = ListProcess(Process);
			string code = "";
			string MD5 = "";
			byte[] dataToHash = (new System.Text.ASCIIEncoding()).GetBytes(path);
			byte[] hashvalue = ((System.Security.Cryptography.HashAlgorithm) (System.Security.Cryptography.CryptoConfig.CreateFromName("MD5"))).ComputeHash(dataToHash);
			for (int k = 0; k <= hashvalue.Length - 1; k++)
			{
				MD5 = MD5 + hashvalue[k].ToString("x2");
			}
			return MD5;
		}
		//根据进程返回执行文件绝对路径
		public static string ListProcess(Process process)
		{
			long theloop;
			PROCESSENTRY32 proc= new PROCESSENTRY32();
			int snap;
			int lngHwndProcess;
			int[] lngModules = new int[201];
			int lngCBSize2=0;
			int lngReturn;
			string strModuleName;
			string strProcessName;
			snap = System.Convert.ToInt32(CreateToolhelpSnapshot(System.Convert.ToInt32(TH32CS_SNAPall), 0));
			proc.dwSize = Strings.Len(proc);
			theloop = ProcessFirst(snap, ref proc);

            lngHwndProcess = System.Convert.ToInt32(OpenProcess(System.Convert.ToInt32(PROCESS_QUERY_INFORMATION), 0, process.Id));//PROCESS_QUERY_INFORMATION Or PROCESS_VM_READ
			lngReturn = System.Convert.ToInt32(EnumProcessModules(lngHwndProcess, ref lngModules[1], 200, ref lngCBSize2));
			strModuleName = Strings.Space(System.Convert.ToInt32(MAX_PATH));
			lngReturn = System.Convert.ToInt32(GetModuleFileNameExA(lngHwndProcess, lngModules[1], strModuleName, 500));
			strProcessName = strModuleName.Substring(0, lngReturn);
			
			CloseHandle(snap);
			return strProcessName;
			
		}
	}
	
}
