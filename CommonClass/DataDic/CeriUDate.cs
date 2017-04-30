using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class CeriUDate : UserControl
    {
        private int DateTimePicker_wth = 18;
        public CeriUDate()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.Width = 118;
            this.Height = 21;
            this.dateTimePicker1.Width = DateTimePicker_wth;
            this.maskedTextBox1.Width = this.Width - DateTimePicker_wth;
            this.maskedTextBox1.Height = 21;
            this.maskedTextBox1.Left = 0;
            this.maskedTextBox1.Top = 0;

            this.dateTimePicker1.Height = 21;
            this.dateTimePicker1.Top = 0;
            dateTimePicker1.Left = this.maskedTextBox1.Width;
        }

        private bool CheckDate(string myDate)
        {
            if (myDate == "    -  -") return true;
            if (myDate.Contains(" ")) return false;
            if (myDate.Substring(0, 4).CompareTo("1753") < 0 || myDate.Substring(0, 4).CompareTo("9998") > 0)
                return false;
         
            try
            {
                DateTime d = DateTime.Parse(myDate);
            }
            catch { return false; }
            return true;
        }

        

        public override Color BackColor
        {
            set
            {
                this.maskedTextBox1.BackColor = value;
            }
        }

        public string RawDate
        {
            get
            {
                string myDateStr = maskedTextBox1.Text;
                if (myDateStr == "    -  -") return "";
                myDateStr = myDateStr.Substring(0, 4) + myDateStr.Substring(5, 2) + myDateStr.Substring(8, 2);
                return myDateStr;
            }
            set
            {
                this.maskedTextBox1.Text = value;
                if (!CheckDate(maskedTextBox1.Text)) maskedTextBox1.Text = "";
                if (CheckDate(maskedTextBox1.Text) && maskedTextBox1.Text!="    -  -")
                    this.dateTimePicker1.Text = this.maskedTextBox1.Text;
            }
        }

        private void CeriUDate_SizeChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Width = DateTimePicker_wth;
            this.maskedTextBox1.Width = this.Width - DateTimePicker_wth;
            this.maskedTextBox1.Height = 21;
            this.maskedTextBox1.Left = 0;
            this.maskedTextBox1.Top = 0;

            this.dateTimePicker1.Height = 21;
            this.dateTimePicker1.Top = 0;
            dateTimePicker1.Left = this.maskedTextBox1.Width;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            this.maskedTextBox1.Text = dateTimePicker1.Text.Trim().Substring(0, 4) + dateTimePicker1.Text.Trim().Substring(5, 2) + dateTimePicker1.Text.Trim().Substring(8, 2);
        }

        private void CeriUDate_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Width = DateTimePicker_wth;
            this.maskedTextBox1.Width = this.Width - DateTimePicker_wth;
            this.maskedTextBox1.Height = 21;
            this.maskedTextBox1.Left = 0;
            this.maskedTextBox1.Top = 0;

            this.dateTimePicker1.Height = 21;
            this.dateTimePicker1.Top = 0;
            dateTimePicker1.Left = this.maskedTextBox1.Width;
        }

        public void ReSized(int myWidth)
        {
            this.Width = myWidth;
            this.Height = 21;

            this.dateTimePicker1.Width = 18;
            this.dateTimePicker1.Height = 21;

            this.maskedTextBox1.Width = myWidth - this.dateTimePicker1.Width;
            this.maskedTextBox1.Height = 21;

            this.maskedTextBox1.Top = 0;
            this.maskedTextBox1.Left = 0;

            this.dateTimePicker1.Top = 0;
            this.dateTimePicker1.Left = this.maskedTextBox1.Width;            
        }       

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(!CheckDate(this.maskedTextBox1.Text))
            {
                toolTip1.Show("请输入合法日期！", maskedTextBox1, 1000);
                e.Cancel = true;
            }
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (CheckDate(maskedTextBox1.Text) && maskedTextBox1.Text!="    -  -")
            {
                this.dateTimePicker1.Text = maskedTextBox1.Text;
            }
        }

      

        

      
    }
}
