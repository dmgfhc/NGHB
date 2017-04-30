using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class MsgBox : Form
    {
        private static MsgBox singleton = null;
        public string messag = "";
        public static MsgBox Instance()
        {
            if (null == singleton)//在空的情况下，建立一个新的实例
                singleton = new MsgBox();                
            return singleton;
        }
         
         

        public MsgBox()
        {
            InitializeComponent();            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {                      
            this.Close();
            this.Dispose();
        }

        private void chk_timer_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timer.Checked)
            { timer1.Enabled = true; }
            else timer1.Enabled =false;;
        }
    }
}