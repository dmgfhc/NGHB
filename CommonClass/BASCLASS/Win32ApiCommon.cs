using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;



namespace CommonClass
{
	public class Win32ApiClass
	{
        //¹¢³¯À×201208011617start
        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();
        //¹¢³¯À×201208011617end

        //[DllImport("kernel32.dll", CallingConvention = CallingConvention.Cdecl)]static public  extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32.dll")]
        static public extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);
		
		[DllImport("kernel32.dll")]static public  extern long GetPrivateProfileString(string AppName, string KeyName, string keydefault, string ReturnString, long NumBytes, string FileName);
		
		[DllImport("kernel32.dll")]static public  extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
		
		[DllImport("user32.dll")]public static  extern int FindWindow(string strClassName, string strWindowName);
		
		[DllImport("wininet.dll",EntryPoint="InternetOpenA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int InternetOpen(string sAgent, int lAccessType, string sProxyName, string sProxyBypass, int lFlags);
		[DllImport("wininet.dll",EntryPoint="InternetConnectA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int InternetConnect(int pub_lngInternetSession, string sServerName, short nServerPort, string sUsername, string sPassword, int lService, int lFlags, int lContext);
		[DllImport("wininet.dll", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern short InternetReadFile(int hFile, IntPtr sBuffer, short lNumBytesToRead, ref short lNumberOfBytesRead);
		[DllImport("wininet.dll", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern short InternetWriteFile(int hFile, IntPtr sBuffer, short lNumBytesToWrite, ref short lNumberOfBytesWritten);
		[DllImport("wininet.dll", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern short InternetCloseHandle(int hInet);
		
		[DllImport("wininet.dll",EntryPoint="FtpOpenFileA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int FtpOpenFile(int hFtpSession, string lpszFileName, int fdwAccess, int dwFlags, int dwContext);
		[DllImport("wininet.dll",EntryPoint="FtpSetCurrentDirectoryA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern bool FtpSetCurrentDirectory(int hFtpSession, string lpszDirectory);
		[DllImport("wininet.dll",EntryPoint="FtpGetCurrentDirectoryA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int FtpGetCurrentDirectory(int hFtpSession, string lpszCurrentDirectory, ref int lpdwCurrentDirectory);
		
		public struct FILETIME
		{
			public long dwLowDateTime;
			public long dwHighDateTime;
		}
		
		public struct WIN32_FIND_DATA
		{
			public long dwFileAttributes;
			public FILETIME ftCreationTime;
			public FILETIME ftLastAccessTime;
			public FILETIME ftLastWriteTime;
			public long nFileSizeHigh;
			public long nFileSizeLow;
			public long dwReserved0;
			public long dwReserved1;
			public string cFileName;
			public string cAlternate;
		}
		
		[DllImport("wininet.dll",EntryPoint="FtpFindFirstFileA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
			public static extern long FtpFindFirstFile(long hFtpSession, string lpszSearchFile, WIN32_FIND_DATA lpFindFileData, long dwFlags, long dwContent);
	}
	
}
