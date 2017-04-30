using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;


public class MD5
{
    [DllImport("kernel32", EntryPoint = "CreateToolhelp32Snapshot", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int CreateToolhelpSnapshot(int lFlags, int lProcessID);
   // [DllImport("kernel32", EntryPoint = "Process32First", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
   // private static extern int ProcessFirst(int hSnapShot, ref PROCESSENTRY32 uProcess);
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int CloseHandle(int hObject);
    [DllImport("PSAPI.DLL", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int GetModuleFileNameExA(int hProcess, int hModule, string ModuleName, int nSize);
    [DllImport("PSAPI.DLL", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int EnumProcessModules(int hProcess, ref int lphModule, int cb, ref int cbNeeded);


    private const short PROCESS_VM_READ = 16;
    private const short PROCESS_QUERY_INFORMATION = 1024;

    private const short TH32CS_SNAPPROCESS = 0x2;
    private const short TH32CS_SNAPheaplist = 0x1;
    private const short TH32CS_SNAPthread = 0x4;
    private const short TH32CS_SNAPmodule = 0x8;
    private const int  TH32CS_SNAPall = TH32CS_SNAPPROCESS + TH32CS_SNAPheaplist + TH32CS_SNAPthread + TH32CS_SNAPmodule;
    private const short MAX_PATH = 260;


    //private struct PROCESSENTRY32
    //{
    //    public int dwSize;
    //    public int cntUsage;
    //    public int th32ProcessID;
    //    public int th32DefaultHeapID;
    //    public int th32ModuleID;
    //    public int cntThreads;
    //    public int th32ParentProcessID;
    //    public int pcPriClassBase;
    //    public int dwFlags;
    //}
    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int GetCurrentProcess();


    //The GetCurrentProcess function returns a pseudohandle for the 
    //current process. 

    private static FileStream fs;
  //  private static string Filename;
   // private static string sPath;
   // private static string sFile;
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
        string path = null;
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
    // 1.ID : Md5hash_String 
    // 2.Input Value : 需要加密的字符串 
    // 3.Return Value : String 
    // 4.Create Date : 2005.12.06 Write By ChenXiao 
    // 5.Modify Date : 
    // 6.Comment : MD5加密，单向加密 
    //--------------------------------------------------------------------------------------- 
    public static string Md5Main(string InputString)
    {
       // string code = "";
        string MD5 = "";
        byte[] dataToHash = (new System.Text.ASCIIEncoding()).GetBytes(InputString);
        byte[] hashvalue = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(dataToHash);
        for (int k = 0; k <= hashvalue.Length - 1; k++)
        {
            MD5 = MD5 + hashvalue[k].ToString("x2");
        }
        return MD5;
    }
    public static string Md5Main(Process Process)
    {
        string path = null;
        path = ListProcess(Process);
        //string code = "";
        string MD5 = "";
        byte[] dataToHash = (new System.Text.ASCIIEncoding()).GetBytes(path);
        byte[] hashvalue = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(dataToHash);
        for (int k = 0; k <= hashvalue.Length - 1; k++)
        {
            MD5 = MD5 + hashvalue[k].ToString("x2");
        }
        return MD5;
    }
    //根据进程返回执行文件绝对路径 
    public static string ListProcess(Process process)
    {
        //long theloop = 0;
        //PROCESSENTRY32 proc = default(PROCESSENTRY32);
        //int snap = 0;
        //int lngHwndProcess = 0;
        //int[] lngModules = new int[201];
        //int lngCBSize2 = 0;
        //int lngReturn = 0;
        //string strModuleName = null;
        //string strProcessName = null;
        //snap = CreateToolhelpSnapshot(TH32CS_SNAPall, 0);
        //proc.dwSize = proc.ToString().Length.;
        //theloop = ProcessFirst(snap, proc);

        //lngHwndProcess = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, 0, process.Id);
        //lngReturn = EnumProcessModules(lngHwndProcess, lngModules(1), 200, lngCBSize2);
        //strModuleName = Strings.Space(MAX_PATH);
        //lngReturn = GetModuleFileNameExA(lngHwndProcess, lngModules(1), strModuleName, 500);
        //strProcessName = Strings.Left(strModuleName, lngReturn);

        //CloseHandle(snap);

        //return strProcessName;
        return "";
    }
}