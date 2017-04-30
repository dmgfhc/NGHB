using Microsoft.Win32;

namespace DownLoad
{
    public class RegKey
    {
       //  读取指定名称的注册表的值 
        
        public static string GetRegistData(string mdir,string name) 
        {
            try
            {
                string registData;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
                RegistryKey aimdir = software.OpenSubKey(mdir, true);
                registData = aimdir.GetValue(name).ToString();
                return registData;
            }
            catch  { return ""; }
        }
       
        //  以上是读取的注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下的mdir目录中名称为name的注册表值； 

        //  向注册表中写数据 
        public static bool WTRegedit(string mdir, string name, string tovalue) 
        {
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
                RegistryKey aimdir = software.CreateSubKey(mdir);
                aimdir.SetValue(name, tovalue);
                return true;
            }
            catch { return false; }
        }       
        //  以上是在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下新建mdir目录并在此目录下创建名称为name值为tovalue的注册表项； 

        // .删除注册表中指定的注册表项 
        public static bool DeleteRegist(string mdir, string name) 
        {
            try
            {
                string[] aimnames;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
                RegistryKey aimdir = software.OpenSubKey(mdir, true);
                aimnames = aimdir.GetSubKeyNames();
                foreach (string aimKey in aimnames)
                {
                    if (aimKey == name)
                        aimdir.DeleteSubKeyTree(name);
                }
                return true;
            }
            catch { return false; }
        }
        //以上是在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下mdir目录中删除名称为name注册表项； 

        //判断指定注册表项是否存在 
        public static bool IsRegeditExit(string mdir, string name) 
        {
            try
            {
                bool _exit = false;
                string[] subkeyNames;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
                RegistryKey aimdir = software.OpenSubKey(mdir, true);
                subkeyNames = aimdir.GetSubKeyNames();
                foreach (string keyName in subkeyNames)
                {
                    if (keyName == name)
                    {
                        _exit = true;
                        return _exit;
                    }
                }
                return _exit;
            }
            catch { return false; }
        
        }
        //以上是在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下mdir目录中判断名称为name注册表项是否存在，这一方法在删除注册表时已经存在，在新建一注册表项时也应有相应判断； 




    }

}