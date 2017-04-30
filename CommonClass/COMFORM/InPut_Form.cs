using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class InPut_Form : Form
    {


        public string sReturnVal = "";
        public InPut_Form()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            sReturnVal = rtx.Text;            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_ok_Click(sender, EventArgs.Empty);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
