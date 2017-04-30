using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClass
{
    public class ColLetter
    {
        public static string BaseTrans(int iNum)
        {
            return Convert.ToString(64 + iNum);
        }
        //从第0行开始 
        public static string GenTrans(int i)
        {
            char[] list = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string sb = "";
            int j = 0;
            do
            {
                j = i % 26;
                sb.Insert(0, j.ToString());
                i = i / 26;
            }
            while (i == 0);
            return sb;
        }
    }
}
