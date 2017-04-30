using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DownLoad
{
    public class Win32ApiCommon
    {
        [DllImport("kernel32", CallingConvention = CallingConvention.Cdecl)]

        // <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Cdecl)> 
        public static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);

        //<DllImport("kernel32.dll", CallingConvention:=CallingConvention.Cdecl)>
        [DllImport("kernel32", CallingConvention = CallingConvention.Cdecl)]
        public static extern long GetPrivateProfileString(string AppName, string KeyName, string keydefault, string ReturnString, long NumBytes, string FileName);

        //<DllImport("kernel32.dll", CallingConvention:=CallingConvention.Cdecl)> 
        [DllImport("kernel32", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        //<DllImport("user32.dll")>

        [DllImport("kernel32")]
        public extern static int FindWindow(string strClassName, string strWindowName);

        [DllImport("imm32.dll")]
        public static extern IntPtr ImmGetContext(IntPtr hwnd);

        [DllImport("imm32.dll")]
        public static extern bool ImmGetOpenStatus(IntPtr himc);

        [DllImport("imm32.dll")]
        public static extern bool ImmSetOpenStatus(IntPtr himc, bool b);

        [DllImport("imm32.dll")]
        public static extern bool ImmGetConversionStatus(IntPtr himc, ref int lpdw, ref int lpdw2);

        [DllImport("imm32.dll")]
        public static extern int ImmSimulateHotKey(IntPtr hwnd, int lngHotkey);

        public const int IME_CMODE_FULLSHAPE = 0x8;
        public const int IME_CHOTKEY_SHAPE_TOGGLE = 0x11;



        [DllImport("wininet.dll", EntryPoint = "InternetOpenA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int InternetOpen(string sAgent, int lAccessType, string sProxyName, string sProxyBypass, int lFlags);
        [DllImport("wininet.dll", EntryPoint = "InternetConnectA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int InternetConnect(int pub_lngInternetSession, string sServerName, short nServerPort, string sUsername, string sPassword, int lService, int lFlags, int lContext);
        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern short InternetReadFile(int hFile, IntPtr sBuffer, short lNumBytesToRead,  short lNumberOfBytesRead);
        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern short InternetWriteFile(int hFile, IntPtr sBuffer, short lNumBytesToWrite, ref short lNumberOfBytesWritten);
        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern short InternetCloseHandle(int hInet);
        [DllImport("wininet.dll", EntryPoint = "FtpGetFileA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool FtpGetFile(long hFtpSession, string lpszRemoteFile, string lpszNewFile, bool fFailIfExists, long dwFlagsAndAttributes, long dwFlags, long dwContext);
        [DllImport("wininet.dll", EntryPoint = "FtpOpenFileA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int FtpOpenFile(int hFtpSession, string lpszFileName, int fdwAccess, int dwFlags, int dwContext);
        [DllImport("wininet.dll", EntryPoint = "FtpSetCurrentDirectoryA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool FtpSetCurrentDirectory(int hFtpSession, string lpszDirectory);
        [DllImport("wininet.dll", EntryPoint = "FtpGetCurrentDirectoryA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
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
        [DllImport("wininet.dll", EntryPoint = "FtpFindFirstFileA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern long FtpFindFirstFile(long hFtpSession, string lpszSearchFile, WIN32_FIND_DATA lpFindFileData, long dwFlags, long dwContent); 
    

    }
}
