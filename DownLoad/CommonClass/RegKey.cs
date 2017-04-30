using Microsoft.Win32;

namespace DownLoad
{
    public class RegKey
    {
       //  ��ȡָ�����Ƶ�ע����ֵ 
        
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
       
        //  �����Ƕ�ȡ��ע�����HKEY_LOCAL_MACHINE\SOFTWAREĿ¼�µ�mdirĿ¼������Ϊname��ע���ֵ�� 

        //  ��ע�����д���� 
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
        //  ��������ע�����HKEY_LOCAL_MACHINE\SOFTWAREĿ¼���½�mdirĿ¼���ڴ�Ŀ¼�´�������ΪnameֵΪtovalue��ע���� 

        // .ɾ��ע�����ָ����ע����� 
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
        //��������ע�����HKEY_LOCAL_MACHINE\SOFTWAREĿ¼��mdirĿ¼��ɾ������Ϊnameע���� 

        //�ж�ָ��ע������Ƿ���� 
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
        //��������ע�����HKEY_LOCAL_MACHINE\SOFTWAREĿ¼��mdirĿ¼���ж�����Ϊnameע������Ƿ���ڣ���һ������ɾ��ע���ʱ�Ѿ����ڣ����½�һע�����ʱҲӦ����Ӧ�жϣ� 




    }

}