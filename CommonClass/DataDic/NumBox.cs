using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonClass
{
    public class NumBox : System.Windows.Forms.TextBox
    {

        private string cur_text = "";
        private bool curShowZero = false;
        public NumBox()
        {            
            Scale = 0;
            ShowZero = true;
            NumValue = 0;
            this.Text = getValueStrZero(NumValue);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;


        }

        private string getValueStrZero(double value)
        {
            if (value == 0 && !myShowZero) return "";
            string rltStr = "";
            rltStr = Math.Round(value, Scale).ToString();
            if (Scale == 0) return rltStr;
            else
            {
               // rltStr = Math.Round(value, Scale).ToString();
                int valueLen = rltStr.Length;
                int pointPos = rltStr.IndexOf(".");
                if (pointPos == -1)
                {
                    rltStr += ".";
                    for (int i = 0; i < Scale; i++)
                    {
                        rltStr += "0";
                    }
                }
                else
                    for (int i = 0; i < Scale - (valueLen - pointPos - 1); i++)
                    {
                        rltStr += "0";
                    }
                return rltStr;
            }
        }
        private bool myShowZero = false;
        public bool ShowZero
        {
            get
            {
                return myShowZero;
            }
            set
            {
                myShowZero = value;
                this.Text = getValueStrZero(myNumValue);
            }
        }
        
        private int myScale = 0;
        public int Scale
        {
            get
            {
                return myScale;
            }
            set
            {
                myScale = value;
                this.Text = getValueStrZero(myNumValue);
            }
        }
        private double myNumValue = 0;
        public double NumValue
        {
            get
            {
                return myNumValue;
            }
            set
            {
                myNumValue = value;
                this.Text = getValueStrZero(value);
            }
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
            cur_text = this.Text;
        }

        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseClick(e);            
            curShowZero = myShowZero;
            myShowZero = true;
            this.Text = getValueStrZero(myNumValue);
            this.SelectionStart = 0;
            this.SelectionLength = this.Text.Length;
            //this.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            myShowZero = curShowZero;
            this.Text = getValueStrZero(myNumValue);
            //this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '.' && !cur_text.Contains(".")) ||e.KeyChar == '\b')
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;   
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            double cur_val = 0;
            if (Text == null)
                cur_val = 0;
            else
            {
                try
                {
                    cur_val = double.Parse(Text);
                }
                catch { cur_val = 0; }
            }
            if (DesignMode)
                this.Text = getValueStrZero(cur_val);
            myNumValue = cur_val;
        }       
    }
     
}
