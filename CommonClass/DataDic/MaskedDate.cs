using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonClass
{
    public class MaskedDate : System.Windows.Forms.MaskedTextBox
    {
        private System.Windows.Forms.ToolTip toolTip1;
        public MaskedDate()
        {
            toolTip1 = new System.Windows.Forms.ToolTip();
            Mask = "0000-00-00 90:00:00";//0817
        }
        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
            if (!CheckDate(this.Text))
            {

                toolTip1.Show("请输入合法日期！", this, 1000);
                e.Cancel = true;
            }
        }
        private bool CheckDate(string myDate)
        {
            string curDate = myDate;
            myDate = myDate.Replace("-", "");
            myDate = myDate.Replace(":", "");
            myDate = myDate.Trim();
            if (myDate == "") return true;

            myDate = curDate;
            int maskLen = this.Mask.Length;

            if (myDate.Length < maskLen) return false;

            if (maskLen == 19)
            {
                if (myDate.Substring(0, 10).Contains(' ')) return false;
                if (myDate.Substring(11, 8).Contains(' ')) return false;
            }
            else if (maskLen == 16)
            {
                if (myDate.Substring(0, 10).Contains(' ')) return false;
                if (myDate.Substring(11, 5).Contains(' ')) return false;
            }
                //0116
            else if (maskLen == 4)
            {
                if ((myDate.Substring(0, 4).CompareTo("1753") >= 0 &&
                myDate.Substring(0, 4).CompareTo("9998") <= 0))
                    return true;
            }
                //0116
            else
            {
                if (myDate.Contains(' ')) return false;
            }
            if (maskLen >= 10 && (myDate.Substring(0, 4).CompareTo("1753") < 0 || myDate.Substring(0, 4).CompareTo("9998") > 0))
                return false;

            try
            {
                DateTime d = DateTime.Parse(myDate);
            }
            catch { return false; }
            return true;
        }
    }
}
