using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace CommonClass
{
    public partial class FlexGrid_User :C1.Win.C1FlexGrid.C1FlexGrid 
    {
         // FlexGrid_User oFlex = new FlexGrid_User();
         private bool _bEnableCellChange=true;
        public FlexGrid_User()
        {  
            InitializeComponent();         
            
        }

        public FlexGrid_User(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public virtual bool EnableCellChange
        {
            get { return _bEnableCellChange; }
            set { _bEnableCellChange = value; }
        }

        private bool _bIsLogRef = true;
        private bool _bIsLogPro = true;

        //是否记录查询SQL
        public virtual bool IsLogRef
        {
            get { return _bIsLogRef; }
            set { _bIsLogRef = value; }
        }

        //是否记录保存SQL
        public virtual bool IsLogPro
        {
            get { return _bIsLogPro; }
            set { _bIsLogPro = value; }
        }


        public delegate void CalculateExceptionHandler(object sender, CalculateExceptionEventArgs arg);


    
        



     


      
      
    }

    public class CalculateExceptionEventArgs : EventArgs
    {
        // Fields
        private Exception a;
        private Control b;

        // Methods
        public CalculateExceptionEventArgs(Exception ex, Control ctrl)
        {
            this.a = ex;
            this.b = ctrl;
        }

        // Properties
        public Control Control
        {
            get
            {
                return this.b;
            }
        }

        public Exception Exception
        {
            get
            {
                return this.a;
            }
        }
    }




 


    
}
