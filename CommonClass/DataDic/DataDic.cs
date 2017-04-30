using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;



/// <summary>
/// 数据字典的窗体
/// </summary>
/// <remarks></remarks>
namespace CommonClass
{
	public class DataDic : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public DataDic()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
		}
        //////////////1023
        public string sAuthority;
        public Collection Sc;
        //private SpreadCommon SpreadCommon = new SpreadCommon();

        ///////////////1023
		
		//窗体重写 dispose 以清理组件列表。
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.Panel pnl_button;
		internal System.Windows.Forms.Panel pnl_condition;
		internal System.Windows.Forms.Panel pnl_result;
		internal FarPoint.Win.Spread.FpSpread ssWhere;
		internal FarPoint.Win.Spread.FpSpread ssResult;
		internal FarPoint.Win.Spread.SheetView ssResult_Sheet1;
		internal System.Windows.Forms.Button cmd_refresh;
		internal System.Windows.Forms.Button cmd_close;
		internal System.Windows.Forms.Button cmd_selection;
		internal FarPoint.Win.Spread.SheetView ssWhere_Sheet1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataDic));
            this.pnl_button = new System.Windows.Forms.Panel();
            this.cmd_close = new System.Windows.Forms.Button();
            this.cmd_selection = new System.Windows.Forms.Button();
            this.cmd_refresh = new System.Windows.Forms.Button();
            this.pnl_condition = new System.Windows.Forms.Panel();
            this.ssWhere = new FarPoint.Win.Spread.FpSpread();
            this.ssWhere_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_result = new System.Windows.Forms.Panel();
            this.ssResult = new FarPoint.Win.Spread.FpSpread();
            this.ssResult_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_button.SuspendLayout();
            this.pnl_condition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere_Sheet1)).BeginInit();
            this.pnl_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssResult_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_button
            // 
            this.pnl_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_button.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_button.Controls.Add(this.cmd_close);
            this.pnl_button.Controls.Add(this.cmd_selection);
            this.pnl_button.Controls.Add(this.cmd_refresh);
            this.pnl_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_button.Location = new System.Drawing.Point(4, 4);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(336, 44);
            this.pnl_button.TabIndex = 1;
            // 
            // cmd_close
            // 
            this.cmd_close.Location = new System.Drawing.Point(221, 3);
            this.cmd_close.Name = "cmd_close";
            this.cmd_close.Size = new System.Drawing.Size(104, 32);
            this.cmd_close.TabIndex = 5;
            this.cmd_close.Text = "关闭";
            this.cmd_close.UseVisualStyleBackColor = true;
            this.cmd_close.Click += new System.EventHandler(this.cmd_close_ClickEvent);
            // 
            // cmd_selection
            // 
            this.cmd_selection.Location = new System.Drawing.Point(113, 3);
            this.cmd_selection.Name = "cmd_selection";
            this.cmd_selection.Size = new System.Drawing.Size(104, 32);
            this.cmd_selection.TabIndex = 4;
            this.cmd_selection.Text = "选择";
            this.cmd_selection.UseVisualStyleBackColor = true;
            this.cmd_selection.Click += new System.EventHandler(this.cmd_selection_ClickEvent);
            // 
            // cmd_refresh
            // 
            this.cmd_refresh.Location = new System.Drawing.Point(6, 3);
            this.cmd_refresh.Name = "cmd_refresh";
            this.cmd_refresh.Size = new System.Drawing.Size(104, 32);
            this.cmd_refresh.TabIndex = 3;
            this.cmd_refresh.Text = "刷新";
            this.cmd_refresh.UseVisualStyleBackColor = true;
            this.cmd_refresh.Click += new System.EventHandler(this.cmd_refresh_ClickEvent);
            // 
            // pnl_condition
            // 
            this.pnl_condition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_condition.Controls.Add(this.ssWhere);
            this.pnl_condition.Location = new System.Drawing.Point(4, 52);
            this.pnl_condition.Name = "pnl_condition";
            this.pnl_condition.Size = new System.Drawing.Size(336, 76);
            this.pnl_condition.TabIndex = 0;
            // 
            // ssWhere
            // 
            this.ssWhere.AccessibleDescription = "";
            this.ssWhere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssWhere.Location = new System.Drawing.Point(0, 0);
            this.ssWhere.Name = "ssWhere";
            this.ssWhere.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssWhere_Sheet1});
            this.ssWhere.Size = new System.Drawing.Size(332, 72);
            this.ssWhere.TabIndex = 1;
            this.ssWhere.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.ssWhere_ColWidthChange);
            this.ssWhere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ssWhere_KeyDownEvent);
            this.ssWhere.SetActiveViewport(0, -1, -1);
            // 
            // ssWhere_Sheet1
            // 
            this.ssWhere_Sheet1.Reset();
            this.ssWhere_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssWhere_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssWhere_Sheet1.ColumnCount = 0;
            this.ssWhere_Sheet1.RowCount = 0;
            this.ssWhere_Sheet1.ActiveColumnIndex = -1;
            this.ssWhere_Sheet1.ActiveRowIndex = -1;
            this.ssWhere_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pnl_result
            // 
            this.pnl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_result.Controls.Add(this.ssResult);
            this.pnl_result.Location = new System.Drawing.Point(4, 132);
            this.pnl_result.Name = "pnl_result";
            this.pnl_result.Size = new System.Drawing.Size(336, 364);
            this.pnl_result.TabIndex = 2;
            // 
            // ssResult
            // 
            this.ssResult.AccessibleDescription = "";
            this.ssResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssResult.Location = new System.Drawing.Point(0, 0);
            this.ssResult.Name = "ssResult";
            this.ssResult.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssResult_Sheet1});
            this.ssResult.Size = new System.Drawing.Size(332, 360);
            this.ssResult.TabIndex = 0;
            this.ssResult.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.ssResult_ColWidthChange);
            this.ssResult.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.ssResult_CellDoubleClick);
            this.ssResult.DoubleClick += new System.EventHandler(this.ssResult_DblClick);
            this.ssResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ssResult_KeyUpEvent);
            this.ssResult.SetActiveViewport(0, -1, -1);
            // 
            // ssResult_Sheet1
            // 
            this.ssResult_Sheet1.Reset();
            this.ssResult_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.ssResult_Sheet1.ColumnCount = 0;
            this.ssResult_Sheet1.RowCount = 0;
            this.ssResult_Sheet1.ActiveColumnIndex = -1;
            this.ssResult_Sheet1.ActiveRowIndex = -1;
            this.ssResult_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // DataDic
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(344, 498);
            this.Controls.Add(this.pnl_result);
            this.Controls.Add(this.pnl_condition);
            this.Controls.Add(this.pnl_button);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DataDic";
            this.Text = "数据字典";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.DataDic_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DataDic_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataDic_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataDic_FormClosed);
            this.Load += new System.EventHandler(this.DataDic_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataDic_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataDic_KeyUp);
            this.Resize += new System.EventHandler(this.DataDic_Resize);
            this.pnl_button.ResumeLayout(false);
            this.pnl_condition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssWhere_Sheet1)).EndInit();
            this.pnl_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssResult_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		#region  窗体的接口
		
		/// <summary>
		/// 调用者是否是Spread
		/// </summary>
		/// <remarks></remarks>
		private bool m_isSpreadCaller;
		public bool IsSpreadCaller
		{
			get
			{
				return m_isSpreadCaller;
			}
			set
			{
				m_isSpreadCaller = value;
			}
		}
		
		/// <summary>
		/// 用于窗体打开后设置where条件的Spread活动列
		/// </summary>
		/// <remarks></remarks>
		private int m_ActiveColumnIndex = 1;
		public int ActiveColumnIndex
		{
			get
			{
				return m_ActiveColumnIndex;
			}
			set
			{
				m_ActiveColumnIndex = value;
			}
		}
		
		/// <summary>
		/// 输入源，也是保存选择结果的目的地
		/// 调用者是Spread时：输入列的集合
		/// 调用者是Master时:输入控件的集和
		/// </summary>
		/// <remarks></remarks>
		private Collection m_rControl = new Collection();
		public Collection rControl
		{
			get
			{
				return m_rControl;
			}
			set
			{
				m_rControl = value;
			}
		}
		
		/// <summary>
		/// 结果集中对应rControl的列的名字，用于拼Where语句
		/// </summary>
		/// <remarks></remarks>
		private Collection m_fControl = new Collection();
		public Collection fControl
		{
			get
			{
				return m_fControl;
			}
			set
			{
				m_fControl = value;
			}
		}
		
		/// <summary>
		/// 调用者是Spread时需要指明SpreadObj
		/// </summary>
		/// <remarks></remarks>
		private Control m_SpreadObj;
		public Control SpreadObj
		{
			get
			{
				return m_SpreadObj;
			}
			set
			{
				m_SpreadObj = value;
			}
		}
		
		/// <summary>
		/// 用于产生Result中结果集的Select语句
		/// </summary>
		/// <remarks></remarks>
		private string m_sQuery = "";
		public string QuerySQL
		{
			get
			{
				return m_sQuery;
			}
			set
			{
				m_sQuery = value;
			}
		}
		
		/// <summary>
		/// 用于产生Result中结果集的存储过程名称
		/// 存储过程的参数从rControl中获得
		/// </summary>
		/// <remarks></remarks>
		private string m_sProc = "";
		public string ProcName
		{
			get
			{
				return m_sProc;
			}
			set
			{
				m_sProc = value;
			}
		}
		
		int m_paramCount;
		public int ParamCount
		{
			get
			{
				return m_paramCount;
			}
			set
			{
				m_paramCount = value;
			}
		}
		
		/// <summary>
		/// 过滤条件
		/// 对QuerySQL:筛选条件
		/// 对Procedure:最开始的参数
		/// </summary>
		/// <remarks></remarks>
		private string m_sFilter = "";
		public string sFilter
		{
			get
			{
				return m_sFilter;
			}
			set
			{
				m_sFilter = value;
			}
		}
		
		#endregion
		
		#region Form Start and Close. .
		
        /// <summary>
        /// DataDic窗体加载事件。
        ///1设置页面的位置信息。
        ///2调用ComposeWhereSQL（），生成完整where语句。
        ///3 调用ssResult_Init（），ssWhere_Init（）函数，初始化窗体，将sql语句传到数据库执行，并将结果返回到窗体中。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void DataDic_Load(object sender, System.EventArgs e)
		{
			
			GeneralCommon.Gp_FormLoc_Get(this, "ETC");
			
			
			if (ProcName.CompareTo("") > 0)
			{
				Gf_DD_ReSelctDisp(GeneralCommon.M_CN1, "{call " + ProcName + "(" + ComposeProcParam() + ")}", false);
			}
			else
			{
				ComposeWhereSQL();
				Gf_DD_ReSelctDisp(GeneralCommon.M_CN1, QuerySQL + " " + ComposeWhereSQL(), false);
			}
			
			
			this.KeyPreview = true;

            this.DataDic_Activated(sender, e);
			
		}

        /// <summary>
        /// 释放DataDic用到的资源。
        /// </summary>
        private void Dispose_Contrls()
        {          
            //this.IsSpreadCaller = null;
            this.rControl = null;
            this.fControl = null;
            this.QuerySQL = null;
            this.ProcName = null;
            //this.ParamCount = null;
            this.sFilter = null;
            //this.ActiveColumnIndex = null;
        }
		
        /// <summary>
        /// DataDic窗体激活事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void DataDic_Activated(object sender, System.EventArgs e)
		{
			
			string sList = "";
			int iColCount;
			SpreadCommon SpreadCommon = new SpreadCommon();
			SpreadCommon.Gp_Sp_ColGet(ssWhere, this.Name, GeneralCommon.DD.DataDicType);
			SpreadCommon.Gp_Sp_ColGet(ssResult, this.Name, GeneralCommon.DD.DataDicType);
			try
			{
				
				if (! IsSpreadCaller) //Master Control F4 Call
				{
					
					for (iColCount = 0; iColCount <= rControl.Count - 1; iColCount++)
					{
						
						ssWhere.Sheets[0].Cells[0, iColCount].Text = (string) (((Control)rControl[iColCount + 1]).Text);
						
					}
					
				}
				else //SpreadSheet F4 Call
				{
                    FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)SpreadObj;
					for (iColCount = 0; iColCount <= rControl.Count - 1; iColCount++)
					{
						
						ssWhere.Sheets[0].Cells.Get(0, iColCount).Text = ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iColCount + 1])).Text;
						
					}
					
				}
				
				
				this.BackColor = GeneralCommon.VbFormBKColor;
			}
			catch (Exception)
			{
				//GeneralCommon.Gp_MsgBoxDisplay(ex.Message)
			}
			
			
		}
		
        /// <summary>
        /// DataDic控件KeyDown事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void DataDic_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Escape) //ESC Key
			{
				this.Close();
			}
			
		}
		
        /// <summary>
        /// DataDic控件KeyUp事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void DataDic_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Escape) //ESC Key
			{
				this.Close();
			}
			
		}
		
        /// <summary>
        /// DataDic窗体尺寸发生变化时，调整窗体上各控件的尺寸。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void DataDic_Resize(object sender, System.EventArgs e)
		{
			
			//Panel Width Setting
			if (this.Width - pnl_button.Left > 1)
			{
				pnl_button.Width = this.Width - 16;
			}
			
			if (this.Width - pnl_condition.Left > 1)
			{
				pnl_condition.Width = this.Width - 16;
			}
			
			if (this.Width - pnl_result.Left > 1)
			{
				pnl_result.Width = this.Width - 16;
			}
			
			//Panel Height Setting
			if (this.Height - 120 > 1)
			{
				pnl_result.Height = this.Height - 168;
			}
			
			//Spread Width Setting (ssWhere)
			if (this.Width - ssWhere.Left > 1)
			{
				ssWhere.Width = this.Width - 28;
			}
			
			//Spread Width Setting (ssResult)
			if (this.Width - ssResult.Left > 1)
			{
				ssResult.Width = this.Width - 28;
			}
			
			if (pnl_result.Height - 100 > 1)
			{
				ssResult.Height = pnl_result.Height - 12;
			}
			
		}

		/// <summary>
        /// 关闭DataDic窗体前，保存DataDic窗体上两个spread的各列的宽度。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DataDic_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//20091028,hux,Add
			//增加窗口位置的判断，窗口不在显示器内不记录位置
			if (this.Top > 0 && this.Left > 0)
			{
				GeneralCommon.Gp_FormLoc_Set(this, "ETC");
			}
			SpreadCommon SpreadCommon = new SpreadCommon();
			SpreadCommon.Gp_Sp_ColSet(ssWhere, this.Name, GeneralCommon.DD.DataDicType);
			SpreadCommon.Gp_Sp_ColSet(ssResult, this.Name, GeneralCommon.DD.DataDicType);
		}
		
		#endregion
		
		#region Spread Setting..
		
		/// <summary>
		/// WhereSpread的初始化设置
		/// </summary>
		/// <remarks></remarks>
		public void ssWhere_Init(int colCount)
		{
			
			if (ssWhere.ActiveSheet.ColumnCount != colCount)
			{
				ssWhere.Sheets[0].RowCount = 1;
				ssWhere.Sheets[0].ColumnCount = colCount;

                ////////////20130320
                FontFamily myFontFamily = new FontFamily("宋体"); //采用哪种字体
                Font myFont = new Font(myFontFamily, (float)9.75, FontStyle.Regular);
                ////////////20130320

				foreach (FarPoint.Win.Spread.Column c in ssWhere.ActiveSheet.Columns)
				{
					c.CellType = new FarPoint.Win.Spread.CellType.TextCellType();
                    ///////////////////////////////////////////////////////////////20130320
                    c.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                    c.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                    c.Font = myFont;
                    /////////////////////////////////////////////////////////////////20130320
					c.Width = 80;
				}
				
				ssWhere.Height = 15;
                ////////////20130320
                ssWhere.ActiveSheet.Rows.Default.Height = float.Parse("21");
                ///////////20130320
				ssWhere.Sheets[0].ColumnHeader.Rows.Get(0).Height = 20;
				
				ssWhere.Sheets[0].RowCount = 1;
				ssWhere.Sheets[0].RowHeader.Cells.Get(0, 0).Text = "Value";
				ssWhere.Sheets[0].ActiveColumnIndex = ActiveColumnIndex;
			}
			
			
			
		}
		
		/// <summary>
		/// ResultSpread的初始化设置
		/// </summary>
		/// <remarks></remarks>
		public void ssResult_Init(int colCount)
		{
			
			if (ssResult.ActiveSheet.ColumnCount != colCount)
			{
				ssResult.Sheets[0].RowCount = 0;
				ssResult.Sheets[0].ColumnCount = colCount;
                ////////////20130320
                FontFamily myFontFamily = new FontFamily("宋体"); //采用哪种字体
                Font myFont = new Font(myFontFamily, (float)9.75, FontStyle.Regular);
                ////////////20130320
				
				foreach (FarPoint.Win.Spread.Column c in ssResult.ActiveSheet.Columns)
				{
					c.CellType = new FarPoint.Win.Spread.CellType.TextCellType();
                    ///////////////////20130320
                    c.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                    c.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                    c.Font = myFont;
                    ///////////////////20130320
					c.Width = 80;
				}
				
				ssResult.Height = 15;
                ////////////20130320
                ssResult.ActiveSheet.Rows.Default.Height = float.Parse("21");
                ///////////20130320
				ssResult.Sheets[0].ColumnHeader.Rows.Get(0).Height = 20;
				
			}
			
		}
		
		#endregion
		
		#region General Purpos function
		
		private void SetControlValue(object ctl, string value)
		{
			
			if (ctl is CheckBox)
			{
				((CheckBox)ctl).Checked =bool.Parse( value);
			}
			else
			{
				((Control)ctl).Text = value;
			}
		}
		
		private string GetControlValue(object ctl)
		{
			return ((Control)ctl).Text;
		}
		//*********************************************************************************************
		//修改说明
		//修改时间：2009-7-9
		//修改人：耿朝雷
		//修改原因：原代码不能显示列类型为"ON", "OM", "OE"的值
		//修改前代码：
		//Private Sub ReturnSelectedResultRow()
		
		//    Dim iColCount As Integer
		
		//    With ssResult
		
		//        If Not IsSpreadCaller Then      'Control F4 Call
		
		//            For iColCount = 0 To rControl.Count - 1
		//                SetControlValue(rControl.Item(iColCount + 1), _
		//                     .ActiveSheet.Cells.Get(.ActiveSheet.ActiveRowIndex, iColCount).Text)
		
		//            Next iColCount
		
		//        Else
		//            Dim ss As FarPoint.Win.Spread.FpSpread = SpreadObj
		//            For iColCount = 0 To rControl.Count - 1
		//                ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, _
		//                        rControl.Item(iColCount + 1)).Text = _
		//                         .ActiveSheet.Cells.Get(.ActiveSheet.ActiveRowIndex, iColCount).Text
		
		//            Next iColCount
		
		//        End If
		
		
		//    End With
		
		//End Sub
		//*************************************************************************************************
		private void ReturnSelectedResultRow()
		{
			
			int iColCount;
			
			
			if (! IsSpreadCaller) //Control F4 Call
			{
				
				for (iColCount = 0; iColCount <= rControl.Count - 1; iColCount++)
				{
                    try
                    {
                        SetControlValue(rControl[iColCount + 1], ssResult.ActiveSheet.Cells.Get(ssResult.ActiveSheet.ActiveRowIndex, iColCount).Text);
                    }
                    catch (Exception ex) { string xx = ex.Message; }	
				}
				
			}
			else
			{
                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)SpreadObj;
				for (iColCount = 0; iColCount <= rControl.Count - 1; iColCount++)
				{
					int COL_I = System.Convert.ToInt32(rControl[iColCount + 1]);
					switch (ss.ActiveSheet.Columns[COL_I].Tag.ToString().Trim())
					{
						case "ON":
						case "OM":
						case "OE":
							ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iColCount + 1])).Tag = ssResult.ActiveSheet.Cells.Get(ssResult.ActiveSheet.ActiveRowIndex, iColCount).Text;
							ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iColCount + 1])).Value = ssResult.ActiveSheet.Cells.Get(ssResult.ActiveSheet.ActiveRowIndex, iColCount).Text;
							break;
						default:
							ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iColCount + 1])).Text = ssResult.ActiveSheet.Cells.Get(ssResult.ActiveSheet.ActiveRowIndex, iColCount).Text;
							break;
					}
					
				}

                ///1023
                if (GeneralCommon.Gf_Sc_Authority(sAuthority, "U"))
                {
                    if (ss.ActiveSheet.RowHeader.Cells.Get(ss.ActiveSheet.ActiveRowIndex, 0).Text.Trim() != "增加")
                    {
                        ss.ActiveSheet.RowHeader.Cells.Get(ss.ActiveSheet.ActiveRowIndex, 0).Text = "修改";
                        ss.Refresh();
                        int colID = System.Convert.ToInt32(Sc["authority"].ToString());
                        if (colID > 0)
                        {
                            ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, colID).Text = GeneralCommon.sUserID;
                        }
                    }
                }

                ///1023
				
			}
			
			
			
		}
		
        /// <summary>
        /// 得到sql语句完整的where条件。
        /// </summary>
        /// <returns></returns>
		private string ReComposeWhereSQL()
		{
			string sWhere = "";
			int iCollCnt;
			
			sWhere = "   WHERE ";
			for (iCollCnt = 1; iCollCnt <= fControl.Count; iCollCnt++)
			{
				
				sWhere += " " + fControl[iCollCnt] + " LIKE \'" + Strings.Trim(ssWhere.ActiveSheet.Cells.Get(ssWhere.ActiveSheet.ActiveRowIndex, iCollCnt - 1).Text) + "%\' AND";
				
			}
			
			//Join
			if (sFilter == "")
			{
				sWhere += " 1=1";
			}
			else
			{
				sWhere += (string) (" " + sFilter);
			}
			
			return sWhere;
		}
		
		private string ReComposeProcParam()
		{
			string sParam = "";
			int iCollCnt;
			
			sParam = " ";
			for (iCollCnt = 1; iCollCnt <= ParamCount; iCollCnt++)
			{
				
				sParam += " \'" + Strings.Trim(ssWhere.ActiveSheet.Cells.Get(0, iCollCnt - 1).Text) + "\',";
				
			}
			
			//'去掉最后的逗号
			sParam = sParam.Substring(0, sParam.Length - 1);
			
			return sParam;
		}
		
        /// <summary>
        /// 组成完整where条件。
        /// </summary>
        /// <returns></returns>
		private string ComposeWhereSQL()
		{
			string sWhere = "";
			string sWhere1 = "";
			int iCollCnt;
			
			if (QuerySQL.Contains("WHERE"))
			{
				sWhere1 = QuerySQL.Substring(System.Convert.ToInt32(QuerySQL.IndexOf("WHERE") + 5));
				sFilter = (string) ((sFilter == "" ? sFilter : sFilter + " AND") + sWhere1);
				QuerySQL = QuerySQL.Substring(0, QuerySQL.IndexOf("WHERE"));
			}
			else
			{
				sWhere = "WHERE ";
			}
			
			if (IsSpreadCaller)
			{

                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)SpreadObj;
				
				//----------------------------------修改按F4时根据列值拼写where 条件
				for (iCollCnt = 1; iCollCnt <= fControl.Count; iCollCnt++)
				{
					string colName = (string) (fControl[iCollCnt]);
					if (colName.IndexOf(":") != -1)
					{
						string[] colNames = colName.Split(":".ToCharArray());
						sWhere += " " + colNames[0] + " LIKE \'" + Strings.Trim(ss.ActiveSheet.Cells.Get(0, int.Parse(colNames[1])).Text) + "%\' AND";
						
					}
					else
					{
						//sWhere += " " + fControl[iCollCnt] + " LIKE \'" + Strings.Trim(ss.ActiveSheet.Cells.Get(ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iCollCnt])).Text) + "%\' AND";


                        string cur_cell_type = "";
                        string cur_cell_str = "";

                        try
                        {
                            cur_cell_type = ss.ActiveSheet.Columns[System.Convert.ToInt32(rControl[iCollCnt])].CellType.ToString();
                        }
                        catch { }

                        if (cur_cell_type == "ComboBoxCellType")
                            try
                            {
                                cur_cell_str = ss.ActiveSheet.Cells[ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iCollCnt])].Value.ToString();
                            }
                            catch { }
                        else
                            cur_cell_str = ss.ActiveSheet.Cells[ss.ActiveSheet.ActiveRowIndex, System.Convert.ToInt32(rControl[iCollCnt])].Text;

                        sWhere += " " + fControl[iCollCnt] + " LIKE \'" + cur_cell_str + "%\' AND";



					}
					
					//--------------------------------修改完成
					
				}
			}
			else
			{
				for (iCollCnt = 1; iCollCnt <= fControl.Count; iCollCnt++)
				{
					
					sWhere += " nvl(" + fControl[iCollCnt] + ",' ') LIKE \'" + Strings.Trim((string) (((Control)rControl[iCollCnt]).Text)) + "%\' AND";
					
				}
			}
			
			
			
			
			//Join
			if (sFilter == "")
			{
				sWhere += " 1=1";
			}
			else
			{
				sWhere += (string) (" " + sFilter);
			}
			
			return sWhere;
		}
		
		private string ComposeProcParam()
		{
			string sParam = "";
			int iCollCnt;
			
			sParam = " ";
			if (IsSpreadCaller)
			{
                FarPoint.Win.Spread.FpSpread ss = (FarPoint.Win.Spread.FpSpread)SpreadObj;
				for (iCollCnt = 1; iCollCnt <= fControl.Count; iCollCnt++)
				{
					
					sParam += " " + Strings.Trim(ss.ActiveSheet.Cells.Get(0, iCollCnt - 1).Text) + "\',";
					
				}
				
			}
			else
			{
				
				for (iCollCnt = 1; iCollCnt <= ParamCount; iCollCnt++)
				{
					
					sParam += " \'" + Strings.Trim((string) (((Control)rControl[iCollCnt]).Text)) + "\',";
					
				}
			}
			
			
			//'去掉最后的逗号
			sParam = sParam.Substring(0, sParam.Length - 1);
			
			//加上Filter
			if (sFilter.CompareTo("") > 0)
			{
				sParam = sFilter + "," + sParam;
			}
			
			return sParam;
		}
		
		#endregion
		
		#region Button Click...
		
		/// <summary>
        /// DataDic窗体refresh事件。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void cmd_refresh_ClickEvent(object sender, System.EventArgs e)
		{
			
			if (ProcName.CompareTo("")>0)
			{
				Gf_DD_ReSelctDisp(GeneralCommon.M_CN1, "{call " + ProcName + "(" + ReComposeProcParam() + ")}", false);
			}
			else
			{
				Gf_DD_ReSelctDisp(GeneralCommon.M_CN1, QuerySQL + ReComposeWhereSQL(), false);
			}
			
			
		}
		
		/// <summary>
        /// DataDic窗体selection事件。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public virtual void cmd_selection_ClickEvent(object sender, System.EventArgs e)
		{
			
			
			if (ssResult.ActiveSheet.RowCount > 0)
			{
				
				ReturnSelectedResultRow();
                this.Dispose();
				
			}
			
			
		}
		
		/// <summary>
        /// DataDic窗体close事件。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmd_close_ClickEvent(object sender, System.EventArgs e)
		{
            this.Dispose();
		}
		
		#endregion
		
		#region Spread Event..
		
        /// <summary>
        /// DataDic窗体ssResult对象的CellDoubleClick事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ssResult_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
            ////////////////////////0407
            if (e.ColumnHeader)
            {
                ssResult.ActiveSheet.AutoSortColumn(e.Column);
                return;
            }
            /////////////////////////0407
			if (ssResult.ActiveSheet.ActiveRowIndex >= 0)
			{

                try
                {
                    ReturnSelectedResultRow();
                    this.DataDic_Closing(sender, null);
                    this.Dispose(); 
                }
                catch (Exception ex)
                {
                    string xx = ex.Message;
                }	
			}			
		}

        private void Close_this()
        {
            this.Close();
        }

        /// <summary>
        /// DataDic窗体ssResult对象的ColWidthChange事件。用于保持ssResult对象与ssWhere对象列的宽度的一致。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ssResult_ColWidthChange(System.Object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
		{
			
			int iCol;
			
			for (iCol = 0; iCol <= ssResult.Sheets[0].ColumnCount - 1; iCol++)
			{
				ssWhere.Sheets[0].Columns.Get(iCol).Width = ssResult.Sheets[0].Columns.Get(iCol).Width;
				
			}
			
		}
		
        /// <summary>
        /// DataDic窗体ssResult对象的DblClick事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public virtual void ssResult_DblClick(System.Object sender, System.EventArgs e)
		{
			if (ssResult.ActiveSheet.ActiveRowIndex >= 0)
			{				
				ReturnSelectedResultRow();				
				this.Close();				
			}			
		}

       
		/// <summary>
        /// DataDic窗体ssResult对象的KeyUpEvent事件。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ssResult_KeyUpEvent(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{			
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				
				ReturnSelectedResultRow();
				
				this.Close();
				
			}
			
		}
		
        /// <summary>
        /// DataDic窗体ssWhere对象的ColWidthChange事件。用于保持ssResult对象与ssWhere对象列的宽度的一致。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ssWhere_ColWidthChange(System.Object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
		{
			
			int iCol;
			
			for (iCol = 0; iCol <= ssWhere.ActiveSheet.ColumnCount - 1; iCol++)
			{
				ssResult.Sheets[0].Columns.Get(iCol).Width = ssWhere.Sheets[0].Columns.Get(iCol).Width;
			}
			
		}
		
        /// <summary>
        /// DataDic窗体ssWhere对象的KeyDownEvent事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ssWhere_KeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				System.EventArgs x;
				x = new System.EventArgs();
				cmd_refresh_ClickEvent(this.cmd_refresh, x);
			}
		}
		
		#endregion
		
		#region Spread ReDisplay...
		
        /// <summary>
        /// 调用ssResult_Init（），ssWhere_Init（）函数，初始化窗体，将sql语句传到数据库执行，并将结果返回到窗体中。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="sQuery"></param>
        /// <param name="MsgChk"></param>
        /// <returns></returns>
		public bool Gf_DD_ReSelctDisp(ADODB.Connection Conn, string sQuery, bool MsgChk)
		{
			bool returnValue=false;
			
			int iRowCount;
			int iColcount;
			ADODB.Recordset AdoRs;
			object[,] ArrayRecords;
			
			//Db Connection Check
			if (Conn.State == 0)
			{
				if (GeneralCommon.GF_DbConnect() == false)
				{
					return returnValue;
				}
			}
			
			try
			{
				
				AdoRs = new ADODB.Recordset();
				//Ado Execute
				AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset,ADODB.LockTypeEnum.adLockReadOnly, -1);
				
				ssResult_Init(AdoRs.Fields.Count);
				ssWhere_Init(AdoRs.Fields.Count);
				
				//'根据结果集设置结果显示Spread的列头标题
				for (iColcount = 0; iColcount <= ssResult.Sheets[0].ColumnCount - 1; iColcount++)
				{
					
					if (Information.VarType(AdoRs.Fields[iColcount].Name) == Constants.vbNull)
					{
						ssResult.Sheets[0].ColumnHeader.Cells.Get(0, iColcount).Text = "";
						ssWhere.Sheets[0].ColumnHeader.Cells.Get(0, iColcount).Text = "";
						
					}
					else
					{
						ssResult.Sheets[0].ColumnHeader.Cells.Get(0, iColcount).Text = Strings.Trim(AdoRs.Fields[iColcount].Name);
						ssWhere.Sheets[0].ColumnHeader.Cells.Get(0, iColcount).Text = Strings.Trim(AdoRs.Fields[iColcount].Name);
						
					}
					
				}
				
				if (AdoRs.BOF || AdoRs.EOF)
				{
					
					if (MsgChk)
					{
						GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I", "");
					}
					
					returnValue = false;
					AdoRs.Close();
					AdoRs = null;
					return returnValue;
					
				}
				
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				
				returnValue = true;
                int RsRowCount = AdoRs.RecordCount;
                int RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    AdoRs.MoveNext();
                    i++;
                }
                
                //ArrayRecords =  AdoRs.GetRows();
				
				AdoRs.Close();
				AdoRs = null;
				
				if ((ArrayRecords.Length - 1) >= 0)
				{

                    ssResult.Sheets[0].RowCount = RsRowCount;// System.Convert.ToInt32(Information.UBound(ArrayRecords, 2) + 1);
					
					for (iRowCount = 0; iRowCount <= ssResult.Sheets[0].RowCount - 1; iRowCount++)
					{
						
						for (iColcount = 0; iColcount <= ssResult.Sheets[0].ColumnCount - 1; iColcount++)
						{

                            if (ArrayRecords[iRowCount,iColcount]==null)//if (Information.VarType(ArrayRecords[iColcount, iRowCount]) == Constants.vbNull)
							{
								ssResult.Sheets[0].Cells[iRowCount, iColcount].Text = "";
							}
							else
							{
                                ssResult.Sheets[0].Cells[iRowCount, iColcount].Text = ArrayRecords[iRowCount, iColcount].ToString();
							}
							
						}
						
					}
					
				}
				
				ssWhere.Sheets[0].ActiveColumnIndex = ActiveColumnIndex;
				
				System.Windows.Forms.Cursor.Current = Cursors.Default;
				
				if (GeneralCommon.M_CN1.State != 0)
				{
					GeneralCommon.M_CN1.Close();
				}
				
			}
			catch (Exception ex)
			{
				AdoRs = null;
				if (GeneralCommon.M_CN1.State != 0)
				{
					GeneralCommon.M_CN1.Close();
				}
				returnValue = false;
				GeneralCommon.Gp_MsgBoxDisplay((string) ("DD_Display Error : " + ex.Message), "", "");
				System.Windows.Forms.Cursor.Current = Cursors.Default;
			}
			
			return returnValue;
		}
		
		#endregion

        /// <summary>
        /// DataDic窗体FormClosing事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataDic_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataDic_Closing(sender, e);
        }

        /// <summary>
        /// DataDic窗体FormClosing事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataDic_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
		
	}
	
}
