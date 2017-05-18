using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
//using FarPoint.PluginCalendar;
//using InDate;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
//using FarPoint.CalcEngine;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
//using FarPoint.Excel;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
//using FarPoint.PluginCalendar.WinForms;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;
using System.Reflection;


//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       Prototype Project
//-- Sub_System Name   Prototype
//-- Program Name      MainMenu Type
//-- Program ID        MainMenu
//-- Document No
//-- Designer
//-- Coder
//-- Date
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER   DATE     EDITOR       DESCRIPTION
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------


namespace CG
{
	public class MainMenu : System.Windows.Forms.Form
	{
		
		#region Default Instance
		
		private static MainMenu defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static MainMenu Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new MainMenu();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion

        public string Toolbar_St;
        internal System.Windows.Forms.MenuItem MenuItem8;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private MenuItem menuItem12;
        private MenuItem menuItem21;
        private MenuItem menuItem23;
        private MenuItem CGB2010C;
        private MenuItem CGB2020C;
        private MenuItem WGB1030C;
        private MenuItem WGB1040C;
        private MenuItem WGB1050C;
        private MenuItem WGC1010C;
        private MenuItem WGC1020C;
        private MenuItem WGC2060C;
        private MenuItem WGC2010C;
        private MenuItem WGC2020C;
        private MenuItem WGC2030C;
        private MenuItem WGC2051C;
        private MenuItem WGC2040C;
        private MenuItem WGC1030C;
        private MenuItem WGC2050C;
        private MenuItem WGC3020C;
        private MenuItem WGC3030C;
        private MenuItem WGC3010C;
        private MenuItem WGF1010C;
        private MenuItem WGF1020C;
        private MenuItem WGF1030C;
        private MenuItem WGF1040C;
        private MenuItem WGF1050C;
        private MenuItem WGF1080C;
        private MenuItem WGE2020C;
        private MenuItem WGT1010C;
        private MenuItem WGT1020C;
        private MenuItem WGT2010C;
        private MenuItem WGE2010C;
        private MenuItem WGE1010C;
        private MenuItem WGE1020C;
        private MenuItem menuItem3;
        private MenuItem WGC2035C;
        private StatusBarPanel statusBarPanel5;
        private MenuItem menuItem4;
        private MenuItem menuItem7;
        private MenuItem menuItem24;
        private MenuItem menuItem6;
        private MenuItem menuItem25;
        private MenuItem WGT1050C;
        private MenuItem WGT1060C;
        private MenuItem WGC2070C;
        private MenuItem menuItem27;
        private MenuItem CGA2010C;
        private MenuItem CGA2020C;
        private MenuItem CGA2080C;
        private MenuItem menuItem33;
        private MenuItem menuItem26;
        private MenuItem WGT1030C;
        private MenuItem menuItem34;
        private MenuItem menuItem35;
        private MenuItem menuItem37;
        private MenuItem menuItem36;
        private MenuItem menuItem43;
        private MenuItem menuItem44;
        private MenuItem WGF1070C;
        private MenuItem WGT1070C;
        private MenuItem WGC2052C;
        private MenuItem menuItem46;
        private MenuItem CGA2011C;
        private MenuItem CGA2030C;
        private MenuItem CGA2060C;
        private MenuItem CGA2061C;
        private MenuItem CGA2081C;
        private MenuItem CGA2090C;
        private MenuItem CGA2070C;
        private MenuItem CGA2100C;
        private MenuItem CGA2110C;
        private MenuItem CGA2120C;
        private MenuItem CGA3000C;
        private MenuItem CGC2000C;
        private MenuItem CGC2010C;
        private MenuItem CGC2020C;
        private MenuItem CGC2060C;
        private MenuItem CGD2050C;
        private MenuItem CGD2041C;
        private MenuItem CGD2042C;
        //private MenuItem menuItem4;
        //private MenuItem menuItem7;
		///'''fdfdsfdsfds
		//Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		//Active Form ToolBar Setting
		public string sAuthority; //Active Form Authority Setting
		
		#region  Windows 窗体设计器生成的代码
		
		public MainMenu()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
            try
            {
                InitializeComponent();
            }
            catch (Exception EX){}
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
		}
		
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.Timer tme_current;
		public System.Windows.Forms.ImageList ImageList0;
		public System.Windows.Forms.ContextMenu ContextMenu1;
		public System.Windows.Forms.ContextMenu ContextMenu2;
		public System.Windows.Forms.StatusBar StatusBar1;
		public System.Windows.Forms.ContextMenu ContextMenu3;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem Mnu_Horiz;
		internal System.Windows.Forms.MenuItem Mnu_Vertical;
		internal System.Windows.Forms.MenuItem Mnu_Control;
		internal System.Windows.Forms.MenuItem MenuItem19;
		internal System.Windows.Forms.MenuItem MenuItem18;
		internal System.Windows.Forms.MenuItem MenuItem16;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem13;
		internal System.Windows.Forms.MenuItem MenuItem38;
		internal System.Windows.Forms.MenuItem MenuItem39;
		internal System.Windows.Forms.MenuItem MenuItem40;
		internal System.Windows.Forms.MenuItem MenuItem41;
		internal System.Windows.Forms.MenuItem MenuItem42;
		internal System.Windows.Forms.MenuItem Mnu_Save;
		internal System.Windows.Forms.MenuItem Mnu_Clear;
		internal System.Windows.Forms.MenuItem Mnu_Windows;
		internal System.Windows.Forms.MenuItem Mnu_Refer;
		internal System.Windows.Forms.MenuItem Mnu_Delete;
		internal System.Windows.Forms.MenuItem Mnu_RowIns;
		internal System.Windows.Forms.MenuItem Mnu_RowDel;
		internal System.Windows.Forms.MenuItem Mnu_RowCan;
		internal System.Windows.Forms.MenuItem Mnu_Copy;
		internal System.Windows.Forms.MenuItem Mnu_ScreenCopy;
		internal System.Windows.Forms.MenuItem Mnu_MasterCopy;
		internal System.Windows.Forms.MenuItem Mnu_SheetCopy;
		internal System.Windows.Forms.MenuItem Mnu_Paste;
		internal System.Windows.Forms.MenuItem Mnu_ScreenPaste;
		internal System.Windows.Forms.MenuItem Mnu_MasterPaste;
		internal System.Windows.Forms.MenuItem Mnu_SheetPaste;
		internal System.Windows.Forms.MenuItem Mnu_Excel;
		internal System.Windows.Forms.MenuItem Mnu_Print;
		internal System.Windows.Forms.MenuItem Mnu_Exit;
		internal System.Windows.Forms.MenuItem Mnu_Cascade;
		public System.Windows.Forms.MenuItem Mnu_FrozenCancel;
		public System.Windows.Forms.MenuItem Mnu_ColumnSort;
		public System.Windows.Forms.MenuItem Mnu_FrozenSetting;
		public System.Windows.Forms.MenuItem Mnu_Acopy;
		public System.Windows.Forms.MenuItem Mnu_Mcopy;
		public System.Windows.Forms.MenuItem Mnu_Scopy;
		public System.Windows.Forms.MenuItem Mnu_Apaste;
		public System.Windows.Forms.MenuItem Mnu_Mpaste;
		public System.Windows.Forms.MenuItem Mnu_Spaste;
		public System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		public System.Windows.Forms.StatusBarPanel StatusBarPanel1;
		public System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		public System.Windows.Forms.ToolBar MenuTool;
		public System.Windows.Forms.ToolBarButton Btn_Clear;
		public System.Windows.Forms.ToolBarButton Btn_Refer;
		internal System.Windows.Forms.ToolBarButton Sep1;
		public System.Windows.Forms.ToolBarButton Btn_Save;
		public System.Windows.Forms.ToolBarButton Btn_Delete;
		internal System.Windows.Forms.ToolBarButton Sep2;
		public System.Windows.Forms.ToolBarButton Btn_RowIns;
		public System.Windows.Forms.ToolBarButton Btn_RowDel;
		public System.Windows.Forms.ToolBarButton Btn_RowCan;
		internal System.Windows.Forms.ToolBarButton Sep3;
		public System.Windows.Forms.ToolBarButton Btn_Copy;
		public System.Windows.Forms.ToolBarButton Btn_Paste;
		internal System.Windows.Forms.ToolBarButton Sep4;
		public System.Windows.Forms.ToolBarButton Btn_Excel;
		public System.Windows.Forms.ToolBarButton Btn_Print;
		internal System.Windows.Forms.ToolBarButton Sep5;
		public System.Windows.Forms.ToolBarButton Btn_Exit;
		internal System.Windows.Forms.MenuItem MenuItem17;
		internal System.Windows.Forms.MenuItem MenuItem20;
		internal System.Windows.Forms.MainMenu MainMenu2;
		internal System.Windows.Forms.MenuItem MenuItem22;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem5;
		public System.Windows.Forms.ImageList ImageList2;
		public System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Mnu_Acopy = new System.Windows.Forms.MenuItem();
            this.Mnu_Mcopy = new System.Windows.Forms.MenuItem();
            this.Mnu_Scopy = new System.Windows.Forms.MenuItem();
            this.ContextMenu2 = new System.Windows.Forms.ContextMenu();
            this.Mnu_Apaste = new System.Windows.Forms.MenuItem();
            this.Mnu_Mpaste = new System.Windows.Forms.MenuItem();
            this.Mnu_Spaste = new System.Windows.Forms.MenuItem();
            this.ImageList0 = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.CGA2010C = new System.Windows.Forms.MenuItem();
            this.CGA2011C = new System.Windows.Forms.MenuItem();
            this.CGA2020C = new System.Windows.Forms.MenuItem();
            this.CGA2030C = new System.Windows.Forms.MenuItem();
            this.CGA2060C = new System.Windows.Forms.MenuItem();
            this.CGA2061C = new System.Windows.Forms.MenuItem();
            this.CGA2080C = new System.Windows.Forms.MenuItem();
            this.CGA2081C = new System.Windows.Forms.MenuItem();
            this.CGA2090C = new System.Windows.Forms.MenuItem();
            this.CGA2070C = new System.Windows.Forms.MenuItem();
            this.CGA2100C = new System.Windows.Forms.MenuItem();
            this.CGA2110C = new System.Windows.Forms.MenuItem();
            this.CGA2120C = new System.Windows.Forms.MenuItem();
            this.CGA3000C = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.CGB2010C = new System.Windows.Forms.MenuItem();
            this.CGB2020C = new System.Windows.Forms.MenuItem();
            this.CGC2000C = new System.Windows.Forms.MenuItem();
            this.CGC2010C = new System.Windows.Forms.MenuItem();
            this.CGC2020C = new System.Windows.Forms.MenuItem();
            this.CGC2060C = new System.Windows.Forms.MenuItem();
            this.WGB1030C = new System.Windows.Forms.MenuItem();
            this.WGB1040C = new System.Windows.Forms.MenuItem();
            this.WGB1050C = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.CGD2050C = new System.Windows.Forms.MenuItem();
            this.CGD2041C = new System.Windows.Forms.MenuItem();
            this.WGC1010C = new System.Windows.Forms.MenuItem();
            this.WGC1020C = new System.Windows.Forms.MenuItem();
            this.WGC1030C = new System.Windows.Forms.MenuItem();
            this.WGC2010C = new System.Windows.Forms.MenuItem();
            this.WGC2020C = new System.Windows.Forms.MenuItem();
            this.WGC2030C = new System.Windows.Forms.MenuItem();
            this.WGC2040C = new System.Windows.Forms.MenuItem();
            this.WGC2050C = new System.Windows.Forms.MenuItem();
            this.WGC2051C = new System.Windows.Forms.MenuItem();
            this.WGC2052C = new System.Windows.Forms.MenuItem();
            this.WGC2060C = new System.Windows.Forms.MenuItem();
            this.WGC2070C = new System.Windows.Forms.MenuItem();
            this.WGC3010C = new System.Windows.Forms.MenuItem();
            this.WGC3020C = new System.Windows.Forms.MenuItem();
            this.WGC3030C = new System.Windows.Forms.MenuItem();
            this.menuItem46 = new System.Windows.Forms.MenuItem();
            this.WGC2035C = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.WGF1010C = new System.Windows.Forms.MenuItem();
            this.WGF1020C = new System.Windows.Forms.MenuItem();
            this.WGF1030C = new System.Windows.Forms.MenuItem();
            this.WGF1040C = new System.Windows.Forms.MenuItem();
            this.WGF1050C = new System.Windows.Forms.MenuItem();
            this.WGF1070C = new System.Windows.Forms.MenuItem();
            this.WGF1080C = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.WGE1010C = new System.Windows.Forms.MenuItem();
            this.WGE1020C = new System.Windows.Forms.MenuItem();
            this.WGE2010C = new System.Windows.Forms.MenuItem();
            this.WGE2020C = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.WGT1010C = new System.Windows.Forms.MenuItem();
            this.WGT1020C = new System.Windows.Forms.MenuItem();
            this.WGT1030C = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.WGT1050C = new System.Windows.Forms.MenuItem();
            this.WGT1060C = new System.Windows.Forms.MenuItem();
            this.WGT1070C = new System.Windows.Forms.MenuItem();
            this.WGT2010C = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem43 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem44 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.Mnu_Control = new System.Windows.Forms.MenuItem();
            this.Mnu_Clear = new System.Windows.Forms.MenuItem();
            this.Mnu_Refer = new System.Windows.Forms.MenuItem();
            this.MenuItem38 = new System.Windows.Forms.MenuItem();
            this.Mnu_Save = new System.Windows.Forms.MenuItem();
            this.Mnu_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem39 = new System.Windows.Forms.MenuItem();
            this.Mnu_RowIns = new System.Windows.Forms.MenuItem();
            this.Mnu_RowDel = new System.Windows.Forms.MenuItem();
            this.Mnu_RowCan = new System.Windows.Forms.MenuItem();
            this.MenuItem40 = new System.Windows.Forms.MenuItem();
            this.Mnu_Copy = new System.Windows.Forms.MenuItem();
            this.Mnu_ScreenCopy = new System.Windows.Forms.MenuItem();
            this.Mnu_MasterCopy = new System.Windows.Forms.MenuItem();
            this.Mnu_SheetCopy = new System.Windows.Forms.MenuItem();
            this.Mnu_Paste = new System.Windows.Forms.MenuItem();
            this.Mnu_ScreenPaste = new System.Windows.Forms.MenuItem();
            this.Mnu_MasterPaste = new System.Windows.Forms.MenuItem();
            this.Mnu_SheetPaste = new System.Windows.Forms.MenuItem();
            this.MenuItem41 = new System.Windows.Forms.MenuItem();
            this.Mnu_Excel = new System.Windows.Forms.MenuItem();
            this.Mnu_Print = new System.Windows.Forms.MenuItem();
            this.MenuItem42 = new System.Windows.Forms.MenuItem();
            this.Mnu_Exit = new System.Windows.Forms.MenuItem();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem17 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem20 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.Mnu_Windows = new System.Windows.Forms.MenuItem();
            this.Mnu_Horiz = new System.Windows.Forms.MenuItem();
            this.Mnu_Vertical = new System.Windows.Forms.MenuItem();
            this.Mnu_Cascade = new System.Windows.Forms.MenuItem();
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
            this.tme_current = new System.Windows.Forms.Timer(this.components);
            this.ContextMenu3 = new System.Windows.Forms.ContextMenu();
            this.Mnu_ColumnSort = new System.Windows.Forms.MenuItem();
            this.MenuItem11 = new System.Windows.Forms.MenuItem();
            this.Mnu_FrozenSetting = new System.Windows.Forms.MenuItem();
            this.Mnu_FrozenCancel = new System.Windows.Forms.MenuItem();
            this.MenuItem13 = new System.Windows.Forms.MenuItem();
            this.MenuItem14 = new System.Windows.Forms.MenuItem();
            this.MenuItem15 = new System.Windows.Forms.MenuItem();
            this.MenuItem16 = new System.Windows.Forms.MenuItem();
            this.MenuItem18 = new System.Windows.Forms.MenuItem();
            this.MenuItem19 = new System.Windows.Forms.MenuItem();
            this.MenuTool = new System.Windows.Forms.ToolBar();
            this.Btn_Clear = new System.Windows.Forms.ToolBarButton();
            this.Btn_Refer = new System.Windows.Forms.ToolBarButton();
            this.Sep1 = new System.Windows.Forms.ToolBarButton();
            this.Btn_Save = new System.Windows.Forms.ToolBarButton();
            this.Btn_Delete = new System.Windows.Forms.ToolBarButton();
            this.Sep2 = new System.Windows.Forms.ToolBarButton();
            this.Btn_RowIns = new System.Windows.Forms.ToolBarButton();
            this.Btn_RowDel = new System.Windows.Forms.ToolBarButton();
            this.Btn_RowCan = new System.Windows.Forms.ToolBarButton();
            this.Sep3 = new System.Windows.Forms.ToolBarButton();
            this.Btn_Copy = new System.Windows.Forms.ToolBarButton();
            this.Btn_Paste = new System.Windows.Forms.ToolBarButton();
            this.Sep4 = new System.Windows.Forms.ToolBarButton();
            this.Btn_Excel = new System.Windows.Forms.ToolBarButton();
            this.Btn_Print = new System.Windows.Forms.ToolBarButton();
            this.Sep5 = new System.Windows.Forms.ToolBarButton();
            this.Btn_Exit = new System.Windows.Forms.ToolBarButton();
            this.MainMenu2 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem22 = new System.Windows.Forms.MenuItem();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CGD2042C = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_Acopy,
            this.Mnu_Mcopy,
            this.Mnu_Scopy});
            // 
            // Mnu_Acopy
            // 
            this.Mnu_Acopy.Index = 0;
            resources.ApplyResources(this.Mnu_Acopy, "Mnu_Acopy");
            this.Mnu_Acopy.Click += new System.EventHandler(this.Mnu_Acopy_Click);
            // 
            // Mnu_Mcopy
            // 
            this.Mnu_Mcopy.Index = 1;
            resources.ApplyResources(this.Mnu_Mcopy, "Mnu_Mcopy");
            this.Mnu_Mcopy.Click += new System.EventHandler(this.Mnu_Mcopy_Click);
            // 
            // Mnu_Scopy
            // 
            this.Mnu_Scopy.Index = 2;
            resources.ApplyResources(this.Mnu_Scopy, "Mnu_Scopy");
            this.Mnu_Scopy.Click += new System.EventHandler(this.Mnu_Scopy_Click);
            // 
            // ContextMenu2
            // 
            this.ContextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_Apaste,
            this.Mnu_Mpaste,
            this.Mnu_Spaste});
            // 
            // Mnu_Apaste
            // 
            this.Mnu_Apaste.Index = 0;
            resources.ApplyResources(this.Mnu_Apaste, "Mnu_Apaste");
            this.Mnu_Apaste.Click += new System.EventHandler(this.Mnu_Apaste_Click);
            // 
            // Mnu_Mpaste
            // 
            this.Mnu_Mpaste.Index = 1;
            resources.ApplyResources(this.Mnu_Mpaste, "Mnu_Mpaste");
            this.Mnu_Mpaste.Click += new System.EventHandler(this.Mnu_Mpaste_Click);
            // 
            // Mnu_Spaste
            // 
            this.Mnu_Spaste.Index = 2;
            resources.ApplyResources(this.Mnu_Spaste, "Mnu_Spaste");
            this.Mnu_Spaste.Click += new System.EventHandler(this.Mnu_Spaste_Click);
            // 
            // ImageList0
            // 
            this.ImageList0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList0.ImageStream")));
            this.ImageList0.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList0.Images.SetKeyName(0, "M1_2.gif");
            this.ImageList0.Images.SetKeyName(1, "M2_2.gif");
            this.ImageList0.Images.SetKeyName(2, "M3_2.gif");
            this.ImageList0.Images.SetKeyName(3, "M4_2.gif");
            this.ImageList0.Images.SetKeyName(4, "M5_2.gif");
            this.ImageList0.Images.SetKeyName(5, "M6_2.gif");
            this.ImageList0.Images.SetKeyName(6, "M7_2.gif");
            this.ImageList0.Images.SetKeyName(7, "M8_2.gif");
            this.ImageList0.Images.SetKeyName(8, "M9_2.gif");
            this.ImageList0.Images.SetKeyName(9, "M10_2.gif");
            this.ImageList0.Images.SetKeyName(10, "M11_2.gif");
            this.ImageList0.Images.SetKeyName(11, "M12_2.gif");
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem27,
            this.menuItem9,
            this.menuItem10,
            this.menuItem12,
            this.menuItem21,
            this.menuItem23,
            this.Mnu_Control,
            this.MenuItem1,
            this.Mnu_Windows});
            resources.ApplyResources(this.MainMenu1, "MainMenu1");
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 0;
            this.menuItem27.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGA2010C,
            this.CGA2011C,
            this.CGA2020C,
            this.CGA2030C,
            this.CGA2060C,
            this.CGA2061C,
            this.CGA2080C,
            this.CGA2081C,
            this.CGA2090C,
            this.CGA2070C,
            this.CGA2100C,
            this.CGA2110C,
            this.CGA2120C,
            this.CGA3000C});
            resources.ApplyResources(this.menuItem27, "menuItem27");
            // 
            // CGA2010C
            // 
            this.CGA2010C.Index = 0;
            resources.ApplyResources(this.CGA2010C, "CGA2010C");
            this.CGA2010C.Click += new System.EventHandler(this.CGA2010C_Click);
            // 
            // CGA2011C
            // 
            this.CGA2011C.Index = 1;
            resources.ApplyResources(this.CGA2011C, "CGA2011C");
            this.CGA2011C.Click += new System.EventHandler(this.CGA2011C_Click);
            // 
            // CGA2020C
            // 
            this.CGA2020C.Index = 2;
            resources.ApplyResources(this.CGA2020C, "CGA2020C");
            this.CGA2020C.Click += new System.EventHandler(this.CGA2020C_Click);
            // 
            // CGA2030C
            // 
            this.CGA2030C.Index = 3;
            resources.ApplyResources(this.CGA2030C, "CGA2030C");
            this.CGA2030C.Click += new System.EventHandler(this.CGA2030C_Click);
            // 
            // CGA2060C
            // 
            this.CGA2060C.Index = 4;
            resources.ApplyResources(this.CGA2060C, "CGA2060C");
            this.CGA2060C.Click += new System.EventHandler(this.CGA2060C_Click);
            // 
            // CGA2061C
            // 
            this.CGA2061C.Index = 5;
            resources.ApplyResources(this.CGA2061C, "CGA2061C");
            this.CGA2061C.Click += new System.EventHandler(this.CGA2061C_Click);
            // 
            // CGA2080C
            // 
            this.CGA2080C.Index = 6;
            resources.ApplyResources(this.CGA2080C, "CGA2080C");
            this.CGA2080C.Click += new System.EventHandler(this.CGA2080C_Click);
            // 
            // CGA2081C
            // 
            this.CGA2081C.Index = 7;
            resources.ApplyResources(this.CGA2081C, "CGA2081C");
            this.CGA2081C.Click += new System.EventHandler(this.CGA2081C_Click);
            // 
            // CGA2090C
            // 
            this.CGA2090C.Index = 8;
            resources.ApplyResources(this.CGA2090C, "CGA2090C");
            this.CGA2090C.Click += new System.EventHandler(this.CGA2090C_Click);
            // 
            // CGA2070C
            // 
            this.CGA2070C.Index = 9;
            resources.ApplyResources(this.CGA2070C, "CGA2070C");
            this.CGA2070C.Click += new System.EventHandler(this.CGA2070C_Click);
            // 
            // CGA2100C
            // 
            this.CGA2100C.Index = 10;
            resources.ApplyResources(this.CGA2100C, "CGA2100C");
            this.CGA2100C.Click += new System.EventHandler(this.CGA2100C_Click);
            // 
            // CGA2110C
            // 
            this.CGA2110C.Index = 11;
            resources.ApplyResources(this.CGA2110C, "CGA2110C");
            this.CGA2110C.Click += new System.EventHandler(this.CGA2110C_Click);
            // 
            // CGA2120C
            // 
            this.CGA2120C.Index = 12;
            resources.ApplyResources(this.CGA2120C, "CGA2120C");
            this.CGA2120C.Click += new System.EventHandler(this.CGA2120C_Click);
            // 
            // CGA3000C
            // 
            this.CGA3000C.Index = 13;
            resources.ApplyResources(this.CGA3000C, "CGA3000C");
            this.CGA3000C.Click += new System.EventHandler(this.CGA3000C_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGB2010C,
            this.CGB2020C,
            this.CGC2000C,
            this.CGC2010C,
            this.CGC2020C,
            this.CGC2060C,
            this.WGB1030C,
            this.WGB1040C,
            this.WGB1050C,
            this.menuItem7});
            resources.ApplyResources(this.menuItem9, "menuItem9");
            // 
            // CGB2010C
            // 
            this.CGB2010C.Index = 0;
            resources.ApplyResources(this.CGB2010C, "CGB2010C");
            this.CGB2010C.Click += new System.EventHandler(this.CGB2010C_Click);
            // 
            // CGB2020C
            // 
            this.CGB2020C.Index = 1;
            resources.ApplyResources(this.CGB2020C, "CGB2020C");
            this.CGB2020C.Click += new System.EventHandler(this.CGB2020C_Click);
            // 
            // CGC2000C
            // 
            this.CGC2000C.Index = 2;
            resources.ApplyResources(this.CGC2000C, "CGC2000C");
            this.CGC2000C.Click += new System.EventHandler(this.CGC2000C_Click);
            // 
            // CGC2010C
            // 
            this.CGC2010C.Index = 3;
            resources.ApplyResources(this.CGC2010C, "CGC2010C");
            this.CGC2010C.Click += new System.EventHandler(this.CGC2010C_Click);
            // 
            // CGC2020C
            // 
            this.CGC2020C.Index = 4;
            resources.ApplyResources(this.CGC2020C, "CGC2020C");
            this.CGC2020C.Click += new System.EventHandler(this.CGC2020C_Click);
            // 
            // CGC2060C
            // 
            this.CGC2060C.Index = 5;
            resources.ApplyResources(this.CGC2060C, "CGC2060C");
            this.CGC2060C.Click += new System.EventHandler(this.CGC2060C_Click);
            // 
            // WGB1030C
            // 
            this.WGB1030C.Index = 6;
            resources.ApplyResources(this.WGB1030C, "WGB1030C");
            // 
            // WGB1040C
            // 
            this.WGB1040C.Index = 7;
            resources.ApplyResources(this.WGB1040C, "WGB1040C");
            this.WGB1040C.Click += new System.EventHandler(this.WGB1040C_Click);
            // 
            // WGB1050C
            // 
            this.WGB1050C.Index = 8;
            resources.ApplyResources(this.WGB1050C, "WGB1050C");
            this.WGB1050C.Click += new System.EventHandler(this.WGB1050C_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 9;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGD2050C,
            this.CGD2041C,
            this.CGD2042C,
            this.WGC1010C,
            this.WGC1020C,
            this.WGC1030C,
            this.WGC2010C,
            this.WGC2020C,
            this.WGC2030C,
            this.WGC2040C,
            this.WGC2050C,
            this.WGC2051C,
            this.WGC2052C,
            this.WGC2060C,
            this.WGC2070C,
            this.WGC3010C,
            this.WGC3020C,
            this.WGC3030C,
            this.menuItem46,
            this.WGC2035C});
            resources.ApplyResources(this.menuItem10, "menuItem10");
            // 
            // CGD2050C
            // 
            this.CGD2050C.Index = 0;
            resources.ApplyResources(this.CGD2050C, "CGD2050C");
            this.CGD2050C.Click += new System.EventHandler(this.CGD2050C_Click);
            // 
            // CGD2041C
            // 
            this.CGD2041C.Index = 1;
            resources.ApplyResources(this.CGD2041C, "CGD2041C");
            this.CGD2041C.Click += new System.EventHandler(this.CGD2041C_Click);
            // 
            // WGC1010C
            // 
            this.WGC1010C.Index = 3;
            resources.ApplyResources(this.WGC1010C, "WGC1010C");
            this.WGC1010C.Click += new System.EventHandler(this.WGC1010C_Click);
            // 
            // WGC1020C
            // 
            this.WGC1020C.Index = 4;
            resources.ApplyResources(this.WGC1020C, "WGC1020C");
            this.WGC1020C.Click += new System.EventHandler(this.WGC1020C_Click);
            // 
            // WGC1030C
            // 
            this.WGC1030C.Index = 5;
            resources.ApplyResources(this.WGC1030C, "WGC1030C");
            this.WGC1030C.Click += new System.EventHandler(this.WGC1030C_Click);
            // 
            // WGC2010C
            // 
            this.WGC2010C.Index = 6;
            resources.ApplyResources(this.WGC2010C, "WGC2010C");
            this.WGC2010C.Click += new System.EventHandler(this.WGC2010C_Click);
            // 
            // WGC2020C
            // 
            this.WGC2020C.Index = 7;
            resources.ApplyResources(this.WGC2020C, "WGC2020C");
            this.WGC2020C.Click += new System.EventHandler(this.WGC2020C_Click);
            // 
            // WGC2030C
            // 
            this.WGC2030C.Index = 8;
            resources.ApplyResources(this.WGC2030C, "WGC2030C");
            this.WGC2030C.Click += new System.EventHandler(this.WGC2030C_Click);
            // 
            // WGC2040C
            // 
            this.WGC2040C.Index = 9;
            resources.ApplyResources(this.WGC2040C, "WGC2040C");
            this.WGC2040C.Click += new System.EventHandler(this.WGC2040C_Click);
            // 
            // WGC2050C
            // 
            this.WGC2050C.Index = 10;
            resources.ApplyResources(this.WGC2050C, "WGC2050C");
            this.WGC2050C.Click += new System.EventHandler(this.WGC2050C_Click);
            // 
            // WGC2051C
            // 
            this.WGC2051C.Index = 11;
            resources.ApplyResources(this.WGC2051C, "WGC2051C");
            this.WGC2051C.Click += new System.EventHandler(this.WGC2051C_Click);
            // 
            // WGC2052C
            // 
            this.WGC2052C.Index = 12;
            resources.ApplyResources(this.WGC2052C, "WGC2052C");
            this.WGC2052C.Click += new System.EventHandler(this.WGC2052C_Click);
            // 
            // WGC2060C
            // 
            this.WGC2060C.Index = 13;
            resources.ApplyResources(this.WGC2060C, "WGC2060C");
            this.WGC2060C.Click += new System.EventHandler(this.WGC2060C_Click);
            // 
            // WGC2070C
            // 
            this.WGC2070C.Index = 14;
            resources.ApplyResources(this.WGC2070C, "WGC2070C");
            this.WGC2070C.Click += new System.EventHandler(this.WGC2070C_Click);
            // 
            // WGC3010C
            // 
            this.WGC3010C.Index = 15;
            resources.ApplyResources(this.WGC3010C, "WGC3010C");
            this.WGC3010C.Click += new System.EventHandler(this.WGC3010C_Click);
            // 
            // WGC3020C
            // 
            this.WGC3020C.Index = 16;
            resources.ApplyResources(this.WGC3020C, "WGC3020C");
            this.WGC3020C.Click += new System.EventHandler(this.WGC3020C_Click);
            // 
            // WGC3030C
            // 
            this.WGC3030C.Index = 17;
            resources.ApplyResources(this.WGC3030C, "WGC3030C");
            this.WGC3030C.Click += new System.EventHandler(this.WGC3030C_Click);
            // 
            // menuItem46
            // 
            this.menuItem46.Index = 18;
            resources.ApplyResources(this.menuItem46, "menuItem46");
            this.menuItem46.Click += new System.EventHandler(this.menuItem46_Click);
            // 
            // WGC2035C
            // 
            this.WGC2035C.Index = 19;
            resources.ApplyResources(this.WGC2035C, "WGC2035C");
            this.WGC2035C.Click += new System.EventHandler(this.WGC2035C_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WGF1010C,
            this.WGF1020C,
            this.WGF1030C,
            this.WGF1040C,
            this.WGF1050C,
            this.WGF1070C,
            this.WGF1080C,
            this.menuItem24});
            resources.ApplyResources(this.menuItem12, "menuItem12");
            // 
            // WGF1010C
            // 
            this.WGF1010C.Index = 0;
            resources.ApplyResources(this.WGF1010C, "WGF1010C");
            this.WGF1010C.Click += new System.EventHandler(this.WGF1010C_Click);
            // 
            // WGF1020C
            // 
            this.WGF1020C.Index = 1;
            resources.ApplyResources(this.WGF1020C, "WGF1020C");
            this.WGF1020C.Click += new System.EventHandler(this.WGF1020C_Click);
            // 
            // WGF1030C
            // 
            this.WGF1030C.Index = 2;
            resources.ApplyResources(this.WGF1030C, "WGF1030C");
            this.WGF1030C.Click += new System.EventHandler(this.WGF1030C_Click);
            // 
            // WGF1040C
            // 
            this.WGF1040C.Index = 3;
            resources.ApplyResources(this.WGF1040C, "WGF1040C");
            this.WGF1040C.Click += new System.EventHandler(this.WGF1040C_Click);
            // 
            // WGF1050C
            // 
            this.WGF1050C.Index = 4;
            resources.ApplyResources(this.WGF1050C, "WGF1050C");
            this.WGF1050C.Click += new System.EventHandler(this.WGF1050C_Click);
            // 
            // WGF1070C
            // 
            this.WGF1070C.Index = 5;
            resources.ApplyResources(this.WGF1070C, "WGF1070C");
            this.WGF1070C.Click += new System.EventHandler(this.WGF1070C_Click);
            // 
            // WGF1080C
            // 
            this.WGF1080C.Index = 6;
            resources.ApplyResources(this.WGF1080C, "WGF1080C");
            this.WGF1080C.Click += new System.EventHandler(this.WGF1080C_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 7;
            resources.ApplyResources(this.menuItem24, "menuItem24");
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 4;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WGE1010C,
            this.WGE1020C,
            this.WGE2010C,
            this.WGE2020C,
            this.menuItem3,
            this.menuItem4,
            this.menuItem6});
            resources.ApplyResources(this.menuItem21, "menuItem21");
            // 
            // WGE1010C
            // 
            this.WGE1010C.Index = 0;
            resources.ApplyResources(this.WGE1010C, "WGE1010C");
            this.WGE1010C.Click += new System.EventHandler(this.WGE1010C_Click);
            // 
            // WGE1020C
            // 
            this.WGE1020C.Index = 1;
            resources.ApplyResources(this.WGE1020C, "WGE1020C");
            this.WGE1020C.Click += new System.EventHandler(this.WGE1020C_Click);
            // 
            // WGE2010C
            // 
            this.WGE2010C.Index = 2;
            resources.ApplyResources(this.WGE2010C, "WGE2010C");
            this.WGE2010C.Click += new System.EventHandler(this.WGE2010C_Click);
            // 
            // WGE2020C
            // 
            this.WGE2020C.Index = 3;
            resources.ApplyResources(this.WGE2020C, "WGE2020C");
            this.WGE2020C.Click += new System.EventHandler(this.WGE2020C_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 5;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 6;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click_1);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 5;
            this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WGT1010C,
            this.WGT1020C,
            this.WGT1030C,
            this.menuItem26,
            this.WGT1050C,
            this.WGT1060C,
            this.WGT1070C,
            this.WGT2010C,
            this.menuItem34,
            this.menuItem43,
            this.menuItem35,
            this.menuItem33,
            this.menuItem25,
            this.menuItem44,
            this.menuItem37,
            this.menuItem36});
            resources.ApplyResources(this.menuItem23, "menuItem23");
            // 
            // WGT1010C
            // 
            this.WGT1010C.Index = 0;
            resources.ApplyResources(this.WGT1010C, "WGT1010C");
            this.WGT1010C.Click += new System.EventHandler(this.WGT1010C_Click);
            // 
            // WGT1020C
            // 
            this.WGT1020C.Index = 1;
            resources.ApplyResources(this.WGT1020C, "WGT1020C");
            this.WGT1020C.Click += new System.EventHandler(this.WGT1020C_Click);
            // 
            // WGT1030C
            // 
            this.WGT1030C.Index = 2;
            resources.ApplyResources(this.WGT1030C, "WGT1030C");
            this.WGT1030C.Click += new System.EventHandler(this.WGT1030C_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 3;
            resources.ApplyResources(this.menuItem26, "menuItem26");
            this.menuItem26.Click += new System.EventHandler(this.WGT1040C_Click);
            // 
            // WGT1050C
            // 
            this.WGT1050C.Index = 4;
            resources.ApplyResources(this.WGT1050C, "WGT1050C");
            this.WGT1050C.Click += new System.EventHandler(this.WGT1050C_Click);
            // 
            // WGT1060C
            // 
            this.WGT1060C.Index = 5;
            resources.ApplyResources(this.WGT1060C, "WGT1060C");
            this.WGT1060C.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // WGT1070C
            // 
            this.WGT1070C.Index = 6;
            resources.ApplyResources(this.WGT1070C, "WGT1070C");
            this.WGT1070C.Click += new System.EventHandler(this.WGT1070C_Click);
            // 
            // WGT2010C
            // 
            this.WGT2010C.Index = 7;
            resources.ApplyResources(this.WGT2010C, "WGT2010C");
            this.WGT2010C.Click += new System.EventHandler(this.WGT2010C_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 8;
            resources.ApplyResources(this.menuItem34, "menuItem34");
            this.menuItem34.Click += new System.EventHandler(this.WGT2011C_Click);
            // 
            // menuItem43
            // 
            this.menuItem43.Index = 9;
            resources.ApplyResources(this.menuItem43, "menuItem43");
            this.menuItem43.Click += new System.EventHandler(this.menuItem43_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 10;
            resources.ApplyResources(this.menuItem35, "menuItem35");
            this.menuItem35.Click += new System.EventHandler(this.WGT2020C_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 11;
            resources.ApplyResources(this.menuItem33, "menuItem33");
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 12;
            resources.ApplyResources(this.menuItem25, "menuItem25");
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem44
            // 
            this.menuItem44.Index = 13;
            resources.ApplyResources(this.menuItem44, "menuItem44");
            this.menuItem44.Click += new System.EventHandler(this.WGT2040C_Click);
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 14;
            resources.ApplyResources(this.menuItem37, "menuItem37");
            this.menuItem37.Click += new System.EventHandler(this.WGT3010C_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 15;
            resources.ApplyResources(this.menuItem36, "menuItem36");
            this.menuItem36.Click += new System.EventHandler(this.WGT3020C_Click);
            // 
            // Mnu_Control
            // 
            this.Mnu_Control.Index = 6;
            this.Mnu_Control.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_Clear,
            this.Mnu_Refer,
            this.MenuItem38,
            this.Mnu_Save,
            this.Mnu_Delete,
            this.MenuItem39,
            this.Mnu_RowIns,
            this.Mnu_RowDel,
            this.Mnu_RowCan,
            this.MenuItem40,
            this.Mnu_Copy,
            this.Mnu_Paste,
            this.MenuItem41,
            this.Mnu_Excel,
            this.Mnu_Print,
            this.MenuItem42,
            this.Mnu_Exit});
            resources.ApplyResources(this.Mnu_Control, "Mnu_Control");
            // 
            // Mnu_Clear
            // 
            this.Mnu_Clear.Index = 0;
            resources.ApplyResources(this.Mnu_Clear, "Mnu_Clear");
            this.Mnu_Clear.Click += new System.EventHandler(this.Mnu_Clear_Click);
            // 
            // Mnu_Refer
            // 
            this.Mnu_Refer.Index = 1;
            resources.ApplyResources(this.Mnu_Refer, "Mnu_Refer");
            this.Mnu_Refer.Click += new System.EventHandler(this.Mnu_Refer_Click);
            // 
            // MenuItem38
            // 
            this.MenuItem38.Index = 2;
            resources.ApplyResources(this.MenuItem38, "MenuItem38");
            // 
            // Mnu_Save
            // 
            this.Mnu_Save.Index = 3;
            resources.ApplyResources(this.Mnu_Save, "Mnu_Save");
            this.Mnu_Save.Click += new System.EventHandler(this.Mnu_Save_Click);
            // 
            // Mnu_Delete
            // 
            this.Mnu_Delete.Index = 4;
            resources.ApplyResources(this.Mnu_Delete, "Mnu_Delete");
            this.Mnu_Delete.Click += new System.EventHandler(this.Mnu_Delete_Click);
            // 
            // MenuItem39
            // 
            this.MenuItem39.Index = 5;
            resources.ApplyResources(this.MenuItem39, "MenuItem39");
            // 
            // Mnu_RowIns
            // 
            this.Mnu_RowIns.Index = 6;
            resources.ApplyResources(this.Mnu_RowIns, "Mnu_RowIns");
            this.Mnu_RowIns.Click += new System.EventHandler(this.Mnu_RowIns_Click);
            // 
            // Mnu_RowDel
            // 
            this.Mnu_RowDel.Index = 7;
            resources.ApplyResources(this.Mnu_RowDel, "Mnu_RowDel");
            this.Mnu_RowDel.Click += new System.EventHandler(this.Mnu_RowDel_Click);
            // 
            // Mnu_RowCan
            // 
            this.Mnu_RowCan.Index = 8;
            resources.ApplyResources(this.Mnu_RowCan, "Mnu_RowCan");
            this.Mnu_RowCan.Click += new System.EventHandler(this.Mnu_RowCan_Click);
            // 
            // MenuItem40
            // 
            this.MenuItem40.Index = 9;
            resources.ApplyResources(this.MenuItem40, "MenuItem40");
            // 
            // Mnu_Copy
            // 
            this.Mnu_Copy.Index = 10;
            this.Mnu_Copy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_ScreenCopy,
            this.Mnu_MasterCopy,
            this.Mnu_SheetCopy});
            resources.ApplyResources(this.Mnu_Copy, "Mnu_Copy");
            // 
            // Mnu_ScreenCopy
            // 
            this.Mnu_ScreenCopy.Index = 0;
            resources.ApplyResources(this.Mnu_ScreenCopy, "Mnu_ScreenCopy");
            // 
            // Mnu_MasterCopy
            // 
            this.Mnu_MasterCopy.Index = 1;
            resources.ApplyResources(this.Mnu_MasterCopy, "Mnu_MasterCopy");
            // 
            // Mnu_SheetCopy
            // 
            this.Mnu_SheetCopy.Index = 2;
            resources.ApplyResources(this.Mnu_SheetCopy, "Mnu_SheetCopy");
            // 
            // Mnu_Paste
            // 
            this.Mnu_Paste.Index = 11;
            this.Mnu_Paste.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_ScreenPaste,
            this.Mnu_MasterPaste,
            this.Mnu_SheetPaste});
            resources.ApplyResources(this.Mnu_Paste, "Mnu_Paste");
            // 
            // Mnu_ScreenPaste
            // 
            this.Mnu_ScreenPaste.Index = 0;
            resources.ApplyResources(this.Mnu_ScreenPaste, "Mnu_ScreenPaste");
            // 
            // Mnu_MasterPaste
            // 
            this.Mnu_MasterPaste.Index = 1;
            resources.ApplyResources(this.Mnu_MasterPaste, "Mnu_MasterPaste");
            // 
            // Mnu_SheetPaste
            // 
            this.Mnu_SheetPaste.Index = 2;
            resources.ApplyResources(this.Mnu_SheetPaste, "Mnu_SheetPaste");
            // 
            // MenuItem41
            // 
            this.MenuItem41.Index = 12;
            resources.ApplyResources(this.MenuItem41, "MenuItem41");
            // 
            // Mnu_Excel
            // 
            this.Mnu_Excel.Index = 13;
            resources.ApplyResources(this.Mnu_Excel, "Mnu_Excel");
            this.Mnu_Excel.Click += new System.EventHandler(this.Mnu_Excel_Click);
            // 
            // Mnu_Print
            // 
            this.Mnu_Print.Index = 14;
            resources.ApplyResources(this.Mnu_Print, "Mnu_Print");
            this.Mnu_Print.Click += new System.EventHandler(this.Mnu_Print_Click);
            // 
            // MenuItem42
            // 
            this.MenuItem42.Index = 15;
            resources.ApplyResources(this.MenuItem42, "MenuItem42");
            // 
            // Mnu_Exit
            // 
            this.Mnu_Exit.Index = 16;
            resources.ApplyResources(this.Mnu_Exit, "Mnu_Exit");
            this.Mnu_Exit.Click += new System.EventHandler(this.Mnu_Exit_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 7;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem17,
            this.MenuItem2,
            this.MenuItem20,
            this.MenuItem5});
            resources.ApplyResources(this.MenuItem1, "MenuItem1");
            // 
            // MenuItem17
            // 
            this.MenuItem17.Index = 0;
            resources.ApplyResources(this.MenuItem17, "MenuItem17");
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            resources.ApplyResources(this.MenuItem2, "MenuItem2");
            // 
            // MenuItem20
            // 
            this.MenuItem20.Index = 2;
            resources.ApplyResources(this.MenuItem20, "MenuItem20");
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 3;
            resources.ApplyResources(this.MenuItem5, "MenuItem5");
            // 
            // Mnu_Windows
            // 
            this.Mnu_Windows.Index = 8;
            this.Mnu_Windows.MdiList = true;
            this.Mnu_Windows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_Horiz,
            this.Mnu_Vertical,
            this.Mnu_Cascade});
            resources.ApplyResources(this.Mnu_Windows, "Mnu_Windows");
            this.Mnu_Windows.Click += new System.EventHandler(this.MenuItem9_Click);
            // 
            // Mnu_Horiz
            // 
            this.Mnu_Horiz.Index = 0;
            resources.ApplyResources(this.Mnu_Horiz, "Mnu_Horiz");
            this.Mnu_Horiz.Click += new System.EventHandler(this.Mnu_Horiz_Click);
            // 
            // Mnu_Vertical
            // 
            this.Mnu_Vertical.Index = 1;
            resources.ApplyResources(this.Mnu_Vertical, "Mnu_Vertical");
            this.Mnu_Vertical.Click += new System.EventHandler(this.Mnu_Horiz_Click);
            // 
            // Mnu_Cascade
            // 
            this.Mnu_Cascade.Index = 2;
            resources.ApplyResources(this.Mnu_Cascade, "Mnu_Cascade");
            this.Mnu_Cascade.Click += new System.EventHandler(this.Mnu_Horiz_Click);
            // 
            // StatusBar1
            // 
            resources.ApplyResources(this.StatusBar1, "StatusBar1");
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel1,
            this.StatusBarPanel2,
            this.StatusBarPanel3,
            this.StatusBarPanel4,
            this.statusBarPanel5});
            this.StatusBar1.ShowPanels = true;
            // 
            // StatusBarPanel1
            // 
            resources.ApplyResources(this.StatusBarPanel1, "StatusBarPanel1");
            // 
            // StatusBarPanel2
            // 
            resources.ApplyResources(this.StatusBarPanel2, "StatusBarPanel2");
            // 
            // StatusBarPanel3
            // 
            resources.ApplyResources(this.StatusBarPanel3, "StatusBarPanel3");
            // 
            // StatusBarPanel4
            // 
            resources.ApplyResources(this.StatusBarPanel4, "StatusBarPanel4");
            this.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            // 
            // statusBarPanel5
            // 
            resources.ApplyResources(this.statusBarPanel5, "statusBarPanel5");
            // 
            // tme_current
            // 
            this.tme_current.Enabled = true;
            this.tme_current.Interval = 1000;
            this.tme_current.Tick += new System.EventHandler(this.tme_current_Tick);
            // 
            // ContextMenu3
            // 
            this.ContextMenu3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Mnu_ColumnSort,
            this.MenuItem11,
            this.Mnu_FrozenSetting,
            this.Mnu_FrozenCancel});
            // 
            // Mnu_ColumnSort
            // 
            this.Mnu_ColumnSort.Index = 0;
            resources.ApplyResources(this.Mnu_ColumnSort, "Mnu_ColumnSort");
            this.Mnu_ColumnSort.Click += new System.EventHandler(this.Mnu_ColumnSort_Click);
            // 
            // MenuItem11
            // 
            this.MenuItem11.Index = 1;
            resources.ApplyResources(this.MenuItem11, "MenuItem11");
            // 
            // Mnu_FrozenSetting
            // 
            this.Mnu_FrozenSetting.Index = 2;
            resources.ApplyResources(this.Mnu_FrozenSetting, "Mnu_FrozenSetting");
            this.Mnu_FrozenSetting.Click += new System.EventHandler(this.Mnu_FrozenSetting_Click);
            // 
            // Mnu_FrozenCancel
            // 
            this.Mnu_FrozenCancel.Index = 3;
            resources.ApplyResources(this.Mnu_FrozenCancel, "Mnu_FrozenCancel");
            this.Mnu_FrozenCancel.Click += new System.EventHandler(this.Mnu_FrozenCancel_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Index = -1;
            resources.ApplyResources(this.MenuItem13, "MenuItem13");
            // 
            // MenuItem14
            // 
            this.MenuItem14.Index = -1;
            resources.ApplyResources(this.MenuItem14, "MenuItem14");
            // 
            // MenuItem15
            // 
            this.MenuItem15.Index = -1;
            resources.ApplyResources(this.MenuItem15, "MenuItem15");
            // 
            // MenuItem16
            // 
            this.MenuItem16.Index = -1;
            resources.ApplyResources(this.MenuItem16, "MenuItem16");
            // 
            // MenuItem18
            // 
            this.MenuItem18.Index = -1;
            resources.ApplyResources(this.MenuItem18, "MenuItem18");
            // 
            // MenuItem19
            // 
            this.MenuItem19.Index = -1;
            resources.ApplyResources(this.MenuItem19, "MenuItem19");
            // 
            // MenuTool
            // 
            resources.ApplyResources(this.MenuTool, "MenuTool");
            this.MenuTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuTool.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.Btn_Clear,
            this.Btn_Refer,
            this.Sep1,
            this.Btn_Save,
            this.Btn_Delete,
            this.Sep2,
            this.Btn_RowIns,
            this.Btn_RowDel,
            this.Btn_RowCan,
            this.Sep3,
            this.Btn_Copy,
            this.Btn_Paste,
            this.Sep4,
            this.Btn_Excel,
            this.Btn_Print,
            this.Sep5,
            this.Btn_Exit});
            this.MenuTool.ImageList = this.ImageList0;
            this.MenuTool.Name = "MenuTool";
            this.MenuTool.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.MenuTool_ButtonClick);
            // 
            // Btn_Clear
            // 
            resources.ApplyResources(this.Btn_Clear, "Btn_Clear");
            this.Btn_Clear.Name = "Btn_Clear";
            // 
            // Btn_Refer
            // 
            resources.ApplyResources(this.Btn_Refer, "Btn_Refer");
            this.Btn_Refer.Name = "Btn_Refer";
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Btn_Save
            // 
            resources.ApplyResources(this.Btn_Save, "Btn_Save");
            this.Btn_Save.Name = "Btn_Save";
            // 
            // Btn_Delete
            // 
            resources.ApplyResources(this.Btn_Delete, "Btn_Delete");
            this.Btn_Delete.Name = "Btn_Delete";
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Btn_RowIns
            // 
            resources.ApplyResources(this.Btn_RowIns, "Btn_RowIns");
            this.Btn_RowIns.Name = "Btn_RowIns";
            // 
            // Btn_RowDel
            // 
            resources.ApplyResources(this.Btn_RowDel, "Btn_RowDel");
            this.Btn_RowDel.Name = "Btn_RowDel";
            // 
            // Btn_RowCan
            // 
            resources.ApplyResources(this.Btn_RowCan, "Btn_RowCan");
            this.Btn_RowCan.Name = "Btn_RowCan";
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.DropDownMenu = this.ContextMenu1;
            resources.ApplyResources(this.Btn_Copy, "Btn_Copy");
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            // 
            // Btn_Paste
            // 
            this.Btn_Paste.DropDownMenu = this.ContextMenu2;
            resources.ApplyResources(this.Btn_Paste, "Btn_Paste");
            this.Btn_Paste.Name = "Btn_Paste";
            this.Btn_Paste.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            // 
            // Sep4
            // 
            this.Sep4.Name = "Sep4";
            this.Sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Btn_Excel
            // 
            resources.ApplyResources(this.Btn_Excel, "Btn_Excel");
            this.Btn_Excel.Name = "Btn_Excel";
            // 
            // Btn_Print
            // 
            resources.ApplyResources(this.Btn_Print, "Btn_Print");
            this.Btn_Print.Name = "Btn_Print";
            // 
            // Sep5
            // 
            this.Sep5.Name = "Sep5";
            this.Sep5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Btn_Exit
            // 
            resources.ApplyResources(this.Btn_Exit, "Btn_Exit");
            this.Btn_Exit.Name = "Btn_Exit";
            // 
            // MainMenu2
            // 
            this.MainMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem22});
            resources.ApplyResources(this.MainMenu2, "MainMenu2");
            // 
            // MenuItem22
            // 
            this.MenuItem22.Index = 0;
            resources.ApplyResources(this.MenuItem22, "MenuItem22");
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "M1_2.gif");
            this.ImageList2.Images.SetKeyName(1, "M2_2.gif");
            this.ImageList2.Images.SetKeyName(2, "M3_2.gif");
            this.ImageList2.Images.SetKeyName(3, "M4_2.gif");
            this.ImageList2.Images.SetKeyName(4, "M5_2.gif");
            this.ImageList2.Images.SetKeyName(5, "M6_2.gif");
            this.ImageList2.Images.SetKeyName(6, "M7_2.gif");
            this.ImageList2.Images.SetKeyName(7, "M8_2.gif");
            this.ImageList2.Images.SetKeyName(8, "M9_2.gif");
            this.ImageList2.Images.SetKeyName(9, "M10_2.gif");
            this.ImageList2.Images.SetKeyName(10, "M11_2.gif");
            this.ImageList2.Images.SetKeyName(11, "M12_2.gif");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "M1_1.gif");
            this.ImageList1.Images.SetKeyName(1, "M2_1.gif");
            this.ImageList1.Images.SetKeyName(2, "M3_1.gif");
            this.ImageList1.Images.SetKeyName(3, "M4_1.gif");
            this.ImageList1.Images.SetKeyName(4, "M5_1.gif");
            this.ImageList1.Images.SetKeyName(5, "M6_1.gif");
            this.ImageList1.Images.SetKeyName(6, "M7_1.gif");
            this.ImageList1.Images.SetKeyName(7, "M8_1.gif");
            this.ImageList1.Images.SetKeyName(8, "M9_1.gif");
            this.ImageList1.Images.SetKeyName(9, "M10_1.gif");
            this.ImageList1.Images.SetKeyName(10, "M11_1.gif");
            this.ImageList1.Images.SetKeyName(11, "M12_1.gif");
            // 
            // CGD2042C
            // 
            this.CGD2042C.Index = 2;
            resources.ApplyResources(this.CGD2042C, "CGD2042C");
            this.CGD2042C.Click += new System.EventHandler(this.CGD2042C_Click);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MenuTool);
            this.Controls.Add(this.StatusBar1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Menu = this.MainMenu1;
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainMenu_Closing);
            this.Closed += new System.EventHandler(this.MainMenu_Closed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenu_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		#region Main Form Load/Close
		
		private void MainMenu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
		}
		
		private void MainMenu_Load(object sender, System.EventArgs e)
		{
			
			string Active_YN;
			string separators = " ";
			string commands = Microsoft.VisualBasic.Interaction.Command();
			string[] args = commands.Split(separators.ToCharArray());

            //GeneralCommon.sUserID = args[0];
            //GeneralCommon.sUsername = args[1];

			CommonClass.Login Login = new CommonClass.Login();
			
			// checking program is running
            //try
            //{
            //    if ((System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length - 1) > 0)
            //    {
            //        GeneralCommon.Gp_MsgBoxDisplay("Upload Program already running ... !!! " + "\r\n" + "\r\n" + "Program will terminate !!!", "W", "");
            //        this.Close();
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay(ex.Message, "", "");
            //}
			
			/* 启动时，不弹出登录窗口
			if ((args.Length - 1) < 1)
			{
				Login.ShowDialog();
				if (GeneralCommon.bPassCheck == false)
				{
					this.Dispose();
					return;
				}
			}
			else
			{
				if (GeneralCommon.GF_DbConnect() == false)
				{
					this.Dispose();
					return;
				}
				
				GeneralCommon.sUserID = args[0];
				GeneralCommon.sUsername = args[1];			
				
			}*/

            GeneralCommon.sUserID = "X000006";
            GeneralCommon.sUsername = "耿朝雷";
			//If Not GeneralCommon.Gp_GetGravity() Then
			//    Me.Dispose()
			//    Exit Sub
			//End If
			string sQuery;
			sQuery = "SELECT EMP_NAME FROM ZP_EMPLOYEE WHERE EMP_ID = \'" + GeneralCommon.sUserID + "\'";
			GeneralCommon.sUsername = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			sQuery = "SELECT DEPT FROM ZP_EMPLOYEE WHERE EMP_ID = \'" + GeneralCommon.sUserID + "\'";
			GeneralCommon.sDeptid = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			sQuery = "SELECT PKG_ABZ_SHIFT.F_SHIFT(\'" + GeneralCommon.sDeptid + "\'," + "NULL,\'" + GeneralCommon.sUserID + "\') FROM DUAL";
			GeneralCommon.sShift = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			sQuery = "SELECT PKG_ABZ_SHIFT.F_GROUP(\'" + GeneralCommon.sDeptid + "\'," + "NULL,\'" + GeneralCommon.sUserID + "\') FROM DUAL";
			GeneralCommon.sShiftGroup = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			//
			//B0025 部门编码
			//
			sQuery = "SELECT CD_NAME FROM ZP_CD WHERE CD_MANA_NO = \'Z0002\' AND CD = \'" + GeneralCommon.sDeptid + "\'";
			GeneralCommon.sDeptname = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery);
			
			this.StatusBar1.Panels[1].Text = GeneralCommon.sDeptname + " " + GeneralCommon.sUserID + " " + GeneralCommon.sUsername;
			this.Text += Application.ProductName + " Ver." + Interaction.GetSetting("NGMES", "VERSION", Application.ProductName + ".exe", "1.0.0");
			
			GeneralCommon.MDIMain = this;
            GeneralCommon.MDIToolBar = this.MenuTool;
            GeneralCommon.ImageList0 = this.ImageList0;
            GeneralCommon.ImageList1 = this.ImageList1;
            GeneralCommon.ImageList2 = this.ImageList2;
            GeneralCommon.GStatusBar = this.StatusBar1;
			GeneralCommon.Gp_DateSetting();
            //GeneralCommon.Gp_FormMenuSetting(this, "Start", Toolbar_St, "");
            GeneralCommon.Gp_FormMenuSetting("Start", Toolbar_St, "");

            ////更改状态栏显示服务器类型：正式环境、测试环境 BEGIN 2012-11-28 耿朝雷
            System.Drawing.Size CRT_SIZE = SystemInformation.PrimaryMonitorSize;

            int crt_wth = CRT_SIZE.Width;
            double x_wth = crt_wth * 0.52;
            StatusBar1.Panels[0].Width = (int)x_wth;

            x_wth = crt_wth * 0.18;
            StatusBar1.Panels[1].Width = (int)x_wth;

            x_wth = crt_wth * 0.15;
            StatusBar1.Panels[2].Width = (int)x_wth;

            x_wth = crt_wth * 0.07;
            StatusBar1.Panels[3].Width = (int)x_wth;

            x_wth = crt_wth * 0.09;
            StatusBar1.Panels[4].Width = (int)x_wth;


            string[] contr_a = GeneralCommon.connstr.Split(';');
            string[] ser_titel = contr_a[2].Split('=');
            if (ser_titel[1].ToUpper() != "ORA9")
            {
                StatusBar1.Panels[4].Text = "测试环境";
            }
            else
            {
                StatusBar1.Panels[4].Text = "正式环境";
            }
            //GeneralCommon.Gp_MsgBoxDisplay(StatusBar1.Panels.
            ////更改状态栏显示服务器类型：正式环境、测试环境 END 2012-11-28 耿朝雷


			this.KeyPreview = true;
			
		}
		
		private void MainMenu_Closed(object sender, System.EventArgs e)
		{
			
			Form CurrentForm;
			bool FormLD;
			
			foreach (Form tempLoopVar_CurrentForm in this.MdiChildren)
			{
				CurrentForm = tempLoopVar_CurrentForm;
				if (CurrentForm.Name != this.Name)
				{
					CurrentForm.Dispose();
				}
			}
			
			//If e.Cancel = False Then SaveSetting("CSG", "EXE-FILE", "C.exe", "")
			
		}
		
		private void MainMenu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			Form CurrentForm;
			bool FormLD;
			
			FormLD = false;
			
			foreach (Form tempLoopVar_CurrentForm in this.MdiChildren)
			{
				CurrentForm = tempLoopVar_CurrentForm;
				if (CurrentForm.Name != this.Name)
				{
					FormLD = true;
					break;
				}
			}
			
			if (FormLD)
			{
				
				if (! GeneralCommon.Gf_MessConfirm("存在没有结束的界面 还是结束吗..?", "Q", this.Text))
				{
					e.Cancel = true;
				}
				
			}
			
		}
		
		#endregion
		
		#region MenuToolButton Control
		
		private void MenuTool_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			
			SpreadCommon SpreadCommon = new SpreadCommon();
			
			Form  frmActive;
			
			frmActive = this.ActiveMdiChild;
			
			try
			{
				
				StatusBar1.Panels[0].Text = " Message : ";
				
				if (frmActive == null)
				{
					
					if (MenuTool.Buttons.IndexOf(e.Button) == 16)
					{
						if (Constants.vbYes == Interaction.MsgBox("终止 " + this.Text + " 吗 ?", Constants.vbQuestion | Constants.vbYesNo, this.Text))
						{
							this.Close();
						}
					}
					
					return;
					
				}
				
				//If TypeOf frmActive.ActiveControl Is AxFPSpread.AxvaSpread Then
				//    Call SpreadCommon.Gp_Sp_EventMark(frmActive.ActiveControl)
				//End If
				
				switch (MenuTool.Buttons.IndexOf(e.Button))
				{
					case 0: //Clear
						if (MenuTool.Buttons[0].Tag == "F")
						{
							return;
						}
						Mnu_Clear_Click("", e);
						break;
					case 1: //Refer
						if (MenuTool.Buttons[1].Tag == "F")
						{
							return;
						}
						Mnu_Refer_Click("", e);
						break;
					case 3: //Save
						if (MenuTool.Buttons[3].Tag == "F")
						{
							return;
						}
						Mnu_Save_Click("", e);
						break;
					case 4: //Delete
						if (MenuTool.Buttons[4].Tag == "F")
						{
							return;
						}
						Mnu_Delete_Click("", e);
						break;
					case 6: //RowIns
						if (MenuTool.Buttons[6].Tag == "F")
						{
							return;
						}
						Mnu_RowIns_Click("", e);
						break;
					case 7: //RowDel
						if (MenuTool.Buttons[7].Tag == "F")
						{
							return;
						}
						Mnu_RowDel_Click("", e);
						break;
					case 8: //RowCan
						if (MenuTool.Buttons[8].Tag == "F")
						{
							return;
						}
						Mnu_RowCan_Click("", e);
						break;
					case 13: //Excel
						if (MenuTool.Buttons[13].Tag == "F")
						{
							return;
						}
						Mnu_Excel_Click("", e);
						break;
					case 14: //Print
						if (MenuTool.Buttons[14].Tag == "F")
						{
							return;
						}
						Mnu_Print_Click("", e);
						break;
					case 16: //Exit
						if (MenuTool.Buttons[16].Tag == "F")
						{
							return;
						}
                        ((FORMBASE)frmActive).Form_Exit();
						break;
						
				}
				
			}
			catch (Exception ex)
			{
				GeneralCommon.Gp_MsgBoxDisplay((string) (" Error : " + ex.Message), "", "");
			}
			
		}

        //private void Mnu_Clear_Click(string p, string p_2)
        //{
        //    throw new NotImplementedException();
        //}
		
		#endregion
		
		#region Screen, Master, Spread  Copy And Paste Process
		
		private void Mnu_Acopy_Click(System.Object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
			((FORMBASE)frmActive).Form_Cpy();
			StatusBar1.Panels[0].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Acopy", "");
            GeneralCommon.Gp_FormMenuSetting("", "Acopy", "");
			
		}
		
		private void Mnu_Mcopy_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
			((FORMBASE)frmActive).Master_Cpy();
			StatusBar1.Panels[0].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Mcopy", "");
            GeneralCommon.Gp_FormMenuSetting( "", "Mcopy", "");
			
		}
		
		private void Mnu_Scopy_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Cpy();
			StatusBar1.Panels[0].Text = " Message : ";
            //GeneralCommon.Gp_FormMenuSetting(this, "", "Scopy", "");
            GeneralCommon.Gp_FormMenuSetting( "", "Scopy", "");
            
			
		}
		
		private void Mnu_Apaste_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Pst();
			
		}
		
		private void Mnu_Mpaste_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Master_Pst();
			
		}
		
		private void Mnu_Spaste_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Pst();
			
		}
		
		#endregion
		
		#region Spread Cloumn Sort/ColsFrozenSetting/ColsFrozenCancel
		
		private void Mnu_ColumnSort_Click(object sender, System.EventArgs e)
		{
			
            //object frmActive;
			
            //try
            //{
				
            //    if (Spread_ColSort.Active_Spread == null)
            //    {
            //        return;
            //    }
				
            //    frmActive = this.ActiveMdiChild;
            //    ((FORMBASE)frmActive).Spread_ColumnsSort();
            //    StatusBar1.Panels[0].Text = " Message : ";
				
            //}
            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay((string) (" ColumnSort Error : " + ex.Message), "", "");
            //}
			
		}
		
		private void Mnu_FrozenSetting_Click(object sender, System.EventArgs e)
		{
			
            //object frmActive;
			
            //try
            //{
				
            //    if (Spread_ColSort.Active_Spread == null)
            //    {
            //        return;
            //    }
				
            //    frmActive = this.ActiveMdiChild;
            //    ((FORMBASE)frmActive).Spread_Frozens_Setting();
            //    StatusBar1.Panels[0].Text = " Message : ";
				
            //}
            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay((string) (" FrozenSetting Error : " + ex.Message), "", "");
            //}
			
		}
		
		private void Mnu_FrozenCancel_Click(object sender, System.EventArgs e)
		{
			
            //object frmActive;
			
            //try
            //{
				
            //    if (Spread_ColSort.Active_Spread == null)
            //    {
            //        return;
            //    }
				
            //    frmActive = this.ActiveMdiChild;
            //    ((FORMBASE)frmActive).Spread_Frozens_Cancel();
            //    StatusBar1.Panels[0].Text = " Message : ";
				
            //}
            //catch (Exception ex)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay((string) (" FrozenCancel Error : " + ex.Message), "", "");
            //}
			
		}
		
		#endregion
		
		#region Windows Menu Click
		
		private void Mnu_Clear_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Cls();
			
		}
		
		private void Mnu_Refer_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Ref();
			
		}
		
		private void Mnu_Save_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Pro();
			
		}
		
		private void Mnu_Delete_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Del();
			
		}
		
		private void Mnu_RowIns_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Ins();
			
		}
		
		private void Mnu_RowDel_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Del();
			
		}
		
		private void Mnu_RowCan_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Can();
			
		}
		
		private void Mnu_Excel_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Spread_Exc();
			
		}
		
		private void Mnu_Print_Click(object sender, System.EventArgs e)
		{
			
			object frmActive;
			
			frmActive = this.ActiveMdiChild;
            ((FORMBASE)frmActive).Form_Pri();
			
		}
		
		private void Mnu_Exit_Click(System.Object sender, System.EventArgs e)
		{
			
			Application.Exit();
			
		}
		
		private void Mnu_Horiz_Click(System.Object sender, System.EventArgs e)
		{
			
			if (((MenuItem) sender).Index == 0) //Mnu_Horiz
			{
				this.LayoutMdi(MdiLayout.TileHorizontal);
			} //Mnu_Vertical
			else if (((MenuItem) sender).Index == 1)
			{
				this.LayoutMdi(MdiLayout.TileVertical);
			} //Mnu_Cascade
			else if (((MenuItem) sender).Index == 2)
			{
				this.LayoutMdi(MdiLayout.Cascade);
			}
			
		}
		
		#endregion
		
		#region Form Execute
		
		private void MenuItem9_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		#endregion
		
		#region Etc...
		
		private void tme_current_Tick(System.Object sender, System.EventArgs e)
		{
			StatusBar1.Panels[2].Text = Strings.Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
		}
		
		#endregion

		
		#region MENU CLICK

        #region //轧钢作业管理菜单
        private void WGB1010C_Click(object sender, EventArgs e)
        {

        }

        private void WGB1020C_Click(object sender, EventArgs e)
        {

        }



        private void WGB1040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGB1040C"))
            {
                WGB1040C WGB1040C = new WGB1040C();
                WGB1040C.MdiParent = this;
                WGB1040C.Show();
                WGB1040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGB1050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGB1050C"))
            {
                WGB1050C WGB1050C = new WGB1050C();
                WGB1050C.MdiParent = this;
                WGB1050C.Show();
                WGB1050C.WindowState = FormWindowState.Maximized;

            }
        }


        private void menuItem7_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGB1060C"))
            {
                WGB1060C WGB1060C = new WGB1060C();
                WGB1060C.MdiParent = this;
                WGB1060C.Show();
                WGB1060C.WindowState = FormWindowState.Maximized;

            }
        }
        #endregion

        #region //精整作业管理菜单
        private void WGC1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC1010C"))
            {
                WGC1010C WGC1010C = new WGC1010C();
                WGC1010C.MdiParent = this;
                WGC1010C.Show();
                WGC1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC1020C"))
            {
                WGC1020C WGC1020C = new WGC1020C();
                WGC1020C.MdiParent = this;
                WGC1020C.Show();
                WGC1020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC1030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC1030C"))
            {
                WGC1030C WGC1030C = new WGC1030C();
                WGC1030C.MdiParent = this;
                WGC1030C.Show();
                WGC1030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2010C"))
            {
                WGC2010C WGC2010C = new WGC2010C();
                WGC2010C.MdiParent = this;
                WGC2010C.Show();
                WGC2010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2020C"))
            {
                WGC2020C WGC2020C = new WGC2020C();
                WGC2020C.MdiParent = this;
                WGC2020C.Show();
                WGC2020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2030C"))
            {
                WGC2030C WGC2030C = new WGC2030C();
                WGC2030C.MdiParent = this;
                WGC2030C.Show();
                WGC2030C.WindowState = FormWindowState.Maximized;

            }
        }
        private void WGC2035C_Click(object sender, EventArgs e)
        {
            WGC2035C WGC2035C = new WGC2035C();
            WGC2035C.MdiParent = this;
            WGC2035C.Show();
            WGC2035C.WindowState = FormWindowState.Maximized;
        }

        private void WGC2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2040C"))
            {
                WGC2040C WGC2040C = new WGC2040C();
                WGC2040C.MdiParent = this;
                WGC2040C.Show();
                WGC2040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2050C"))
            {
                WGC2050C WGC2050C = new WGC2050C();
                WGC2050C.MdiParent = this;
                WGC2050C.Show();
                WGC2050C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2051C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2051C"))
            {
                WGC2051C WGC2051C = new WGC2051C();
                WGC2051C.MdiParent = this;
                WGC2051C.Show();
                WGC2051C.WindowState = FormWindowState.Maximized;
            }
        }
        private void WGC2052C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2052C"))
            {
                WGC2052C WGC2052C = new WGC2052C();
                WGC2052C.MdiParent = this;
                WGC2052C.Show();
                WGC2052C.WindowState = FormWindowState.Maximized;
            }
        }

        private void WGC2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2060C"))
            {
                WGC2060C WGC2060C = new WGC2060C();
                WGC2060C.MdiParent = this;
                WGC2060C.Show();
                WGC2060C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC2070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC2070C"))
            {
                WGC2070C WGC2070C = new WGC2070C();
                WGC2070C.MdiParent = this;
                WGC2070C.Show();
                WGC2070C.WindowState = FormWindowState.Maximized;

            }

        }

        private void WGC3010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC3010C"))
            {
                WGC3010C WGC3010C = new WGC3010C();
                WGC3010C.MdiParent = this;
                WGC3010C.Show();
                WGC3010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC3020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC3020C"))
            {
                WGC3020C WGC3020C = new WGC3020C();
                WGC3020C.MdiParent = this;
                WGC3020C.Show();
                WGC3020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGC3030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC3030C"))
            {
                WGC3030C WGC3030C = new WGC3030C();
                WGC3030C.MdiParent = this;
                WGC3030C.Show();
                WGC3030C.WindowState = FormWindowState.Maximized;

            }
        }

        

   
        #endregion
       
        #region //轧辊管理菜单
        private void WGF1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1010C"))
            {
                WGF1010C WGF1010C = new WGF1010C();
                WGF1010C.MdiParent = this;
                WGF1010C.Show();
                WGF1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGF1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1020C"))
            {
                WGF1020C WGF1020C = new WGF1020C();
                WGF1020C.MdiParent = this;
                WGF1020C.Show();
                WGF1020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGF1030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1030C"))
            {
                WGF1030C WGF1030C = new WGF1030C();
                WGF1030C.MdiParent = this;
                WGF1030C.Show();
                WGF1030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGF1040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1040C"))
            {
                WGF1040C WGF1040C = new WGF1040C();
                WGF1040C.MdiParent = this;
                WGF1040C.Show();
                WGF1040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGF1050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1050C"))
            {
                WGF1050C WGF1050C = new WGF1050C();
                WGF1050C.MdiParent = this;
                WGF1050C.Show();
                WGF1050C.WindowState = FormWindowState.Maximized;

            }
        }
        private void WGF1070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1070C"))
            {
                WGF1070C WGF1070C = new WGF1070C();
                WGF1070C.MdiParent = this;
                WGF1070C.Show();
                WGF1070C.WindowState = FormWindowState.Maximized;

            }
        }
        private void WGF1080C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1080C"))
            {
                WGF1080C WGF1080C = new WGF1080C();
                WGF1080C.MdiParent = this;
                WGF1080C.Show();
                WGF1080C.WindowState = FormWindowState.Maximized;

            }
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGF1060C"))
            {
                WGF1060C WGF1060C = new WGF1060C();
                WGF1060C.MdiParent = this;
                WGF1060C.Show();
                WGF1060C.WindowState = FormWindowState.Maximized;

            }
        }
        #endregion

        #region //库管理菜单
        private void WGE1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE1010C"))
            {
                WGE1010C WGE1010C = new WGE1010C();
                WGE1010C.MdiParent = this;
                WGE1010C.Show();
                WGE1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGE1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE1020C"))
            {
                WGE1020C WGE1020C = new WGE1020C();
                WGE1020C.MdiParent = this;
                WGE1020C.Show();
                WGE1020C.WindowState = FormWindowState.Maximized;
            }
        }

        private void WGE2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE2010C"))
            {
                WGE2010C WGE2010C = new WGE2010C();
                WGE2010C.MdiParent = this;
                WGE2010C.Show();
                WGE2010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGE2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE2020C"))
            {
                WGE2020C WGE2020C = new WGE2020C();
                WGE2020C.MdiParent = this;
                WGE2020C.Show();
                WGE2020C.WindowState = FormWindowState.Maximized;

            }
        }
        private void WGE2030C_Click(object sender, EventArgs e)
        {
            //if (!GeneralCommon.Gf_IsFormLoad("WGE2030C"))
            //{
            //    WGE2030C WGE2030C = new WGE2030C();
            //    WGE2030C.MdiParent = this;
            //    WGE2030C.Show();
            //    WGE2030C.WindowState = FormWindowState.Maximized;

            //}
        }
        #endregion

        #region //统计分析管理菜单
        private void WGT1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1010C"))
            {
                WGT1010C WGT1010C = new WGT1010C();
                WGT1010C.MdiParent = this;
                WGT1010C.Show();
                WGT1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1020C"))
            {
                WGT1020C WGT1020C = new WGT1020C();
                WGT1020C.MdiParent = this;
                WGT1020C.Show();
                WGT1020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT1040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1040C"))
            {
                WGT1040C WGT1040C = new WGT1040C();
                WGT1040C.MdiParent = this;
                WGT1040C.Show();
                WGT1040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT1030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1030C"))
            {
                WGT1030C WGT1030C = new WGT1030C();
                WGT1030C.MdiParent = this;
                WGT1030C.Show();
                WGT1030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT1050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1050C"))
            {
                WGT1050C WGT1050C = new WGT1050C();
                WGT1050C.MdiParent = this;
                WGT1050C.Show();
                WGT1050C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2010C"))
            {
                WGT2010C WGT2010C = new WGT2010C();
                WGT2010C.MdiParent = this;
                WGT2010C.Show();
                WGT2010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT2011C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2011C"))
            {
                WGT2011C WGT2011C = new WGT2011C();
                WGT2011C.MdiParent = this;
                WGT2011C.Show();
                WGT2011C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2020C"))
            {
                WGT2020C WGT2020C = new WGT2020C();
                WGT2020C.MdiParent = this;
                WGT2020C.Show();
                WGT2020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2040C"))
            {
                WGT2040C WGT2040C = new WGT2040C();
                WGT2040C.MdiParent = this;
                WGT2040C.Show();
                WGT2040C.WindowState = FormWindowState.Maximized;

            }

        }

        private void WGT3010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT3010C"))
            {
                WGT3010C WGT3010C = new WGT3010C();
                WGT3010C.MdiParent = this;
                WGT3010C.Show();
                WGT3010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void WGT3020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT3020C"))
            {
                WGT3020C WGT3020C = new WGT3020C();
                WGT3020C.MdiParent = this;
                WGT3020C.Show();
                WGT3020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE3010C"))
            {
                WGE3010C WGE3010C = new WGE3010C();
                WGE3010C.MdiParent = this;
                WGE3010C.Show();
                WGE3010C.WindowState = FormWindowState.Maximized;

            }
        }
        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE4030C"))
            {
                WGE4030C WGE4030C = new WGE4030C();
                WGE4030C.MdiParent = this;
                WGE4030C.Show();
                WGE4030C.WindowState = FormWindowState.Maximized;

            }
        }
        #endregion

        private void menuItem6_Click(object sender, EventArgs e)
        {
            //if (!GeneralCommon.Gf_IsFormLoad("WGE4020C"))
            //{
            //    WGE4020C WGE4020C = new WGE4020C();
            //    WGE4020C.MdiParent = this;
            //    WGE4020C.Show();
            //    WGE4020C.WindowState = FormWindowState.Maximized;

            //}
        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGE4040C"))
            {
                WGE4040C WGE4040C = new WGE4040C();
                WGE4040C.MdiParent = this;
                WGE4040C.Show();
                WGE4040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void menuItem43_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2012C"))
            {
                WGT2012C WGT2012C = new WGT2012C();
                WGT2012C.MdiParent = this;
                WGT2012C.Show();
                WGT2012C.WindowState = FormWindowState.Maximized;

            }
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2030C"))
            {
                WGT2030C WGT2030C = new WGT2030C();
                WGT2030C.MdiParent = this;
                WGT2030C.Show();
                WGT2030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void menuItem26_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1060C"))
            {
                WGT1060C WGT1060C = new WGT1060C();
                WGT1060C.MdiParent = this;
                WGT1060C.Show();
                WGT1060C.WindowState = FormWindowState.Maximized;

            }

        }

        private void WGT1070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT1070C"))
            {
                WGT1070C WGT1070C = new WGT1070C();
                WGT1070C.MdiParent = this;
                WGT1070C.Show();
                WGT1070C.WindowState = FormWindowState.Maximized;

            }

        }

        private void menuItem29_Click(object sender, EventArgs e)
        {

        }
        private void menuItem30_Click(object sender, EventArgs e)
        {

        }
        private void menuItem31_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGA1040C"))
            {
                WGA1040C WGA1040C = new WGA1040C();
                WGA1040C.MdiParent = this;
                WGA1040C.Show();
                WGA1040C.WindowState = FormWindowState.Maximized;
            }
        }
        private void menuItem32_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGA1050C"))
            {
                WGA1050C WGA1050C = new WGA1050C();
                WGA1050C.MdiParent = this;
                WGA1050C.Show();
                WGA1050C.WindowState = FormWindowState.Maximized;
            }
        }


        private void menuItem33_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2021C"))
            {
                WGT2021C WGT2021C = new WGT2021C();
                WGT2021C.MdiParent = this;
                WGT2021C.Show();
                WGT2021C.WindowState = FormWindowState.Maximized;
            }
        }

        private void menuItem45_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGA1031C"))
            {
                WGA1031C WGA1031C = new WGA1031C();
                WGA1031C.MdiParent = this;
                WGA1031C.Show();
                WGA1031C.WindowState = FormWindowState.Maximized;
            }
        }

        private void WGA1011C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGA1011C"))
            {
                WGA1011C WGA1011C = new WGA1011C();
                WGA1011C.MdiParent = this;
                WGA1011C.Show();
                WGA1011C.WindowState = FormWindowState.Maximized;
            }
        }

        //板坯库管理
        private void CGA2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2010C"))
            {
                CGA2010C CGA2010C = new CGA2010C();
                CGA2010C.MdiParent = this;
                CGA2010C.Show();
                CGA2010C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2011C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2011C"))
            {
                CGA2030C CGA2011C = new CGA2030C();
                CGA2011C.MdiParent = this;
                CGA2011C.Show();
                CGA2011C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2020C"))
            {
                CGA2020C CGA2020C = new CGA2020C();
                CGA2020C.MdiParent = this;
                CGA2020C.Show();
                CGA2020C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGA2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2030C"))
            {
                CGA2030C CGA2030C = new CGA2030C();
                CGA2030C.MdiParent = this;
                CGA2030C.Show();
                CGA2030C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2060C"))
            {
                CGA2060C CGA2060C = new CGA2060C();
                CGA2060C.MdiParent = this;
                CGA2060C.Show();
                CGA2060C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2061C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2061C"))
            {
                CGA2061C CGA2061C = new CGA2061C();
                CGA2061C.MdiParent = this;
                CGA2061C.Show();
                CGA2061C.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        private void menuItem46_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGC3031C"))
            {
                WGC3031C WGC3031C = new WGC3031C();
                WGC3031C.MdiParent = this;
                WGC3031C.Show();
                WGC3031C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2080C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2080C"))
            {
                CGA2080C CGA2080C = new CGA2080C();
                CGA2080C.MdiParent = this;
                CGA2080C.Show();
                CGA2080C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2081C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2081C"))
            {
                CGA2081C CGA2081C = new CGA2081C();
                CGA2081C.MdiParent = this;
                CGA2081C.Show();
                CGA2081C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGA2070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2070C"))
            {
                CGA2070C CGA2070C = new CGA2070C();
                CGA2070C.MdiParent = this;
                CGA2070C.Show();
                CGA2070C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2100C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2100C"))
            {
                CGA2100C CGA2100C = new CGA2100C();
                CGA2100C.MdiParent = this;
                CGA2100C.Show();
                CGA2100C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2110C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2110C"))
            {
                CGA2110C CGA2110C = new CGA2110C();
                CGA2110C.MdiParent = this;
                CGA2110C.Show();
                CGA2110C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2120C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2120C"))
            {
                CGA2120C CGA2120C = new CGA2120C();
                CGA2120C.MdiParent = this;
                CGA2120C.Show();
                CGA2120C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA3000C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA3000C"))
            {
                CGA3000C CGA3000C = new CGA3000C();
                CGA3000C.MdiParent = this;
                CGA3000C.Show();
                CGA3000C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGA2090C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGA2090C"))
            {
                CGA2090C CGA2090C = new CGA2090C();
                CGA2090C.MdiParent = this;
                CGA2090C.Show();
                CGA2090C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGB2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGB2010C"))
            {
                CGB2010C CGB2010C = new CGB2010C();
                CGB2010C.MdiParent = this;
                CGB2010C.Show();
                CGB2010C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGB2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGB2020C"))
            {
                CGB2020C CGB2020C = new CGB2020C();
                CGB2020C.MdiParent = this;
                CGB2020C.Show();
                CGB2020C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGC2000C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2000C"))
            {
                CGC2000C CGC2000C = new CGC2000C();
                CGC2000C.MdiParent = this;
                CGC2000C.Show();
                CGC2000C.WindowState = FormWindowState.Maximized;
            }
        }


        private void CGC2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2010C"))
            {
                CGC2010C CGC2010C = new CGC2010C();
                CGC2010C.MdiParent = this;
                CGC2010C.Show();
                CGC2010C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGC2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2020C"))
            {
                CGC2020C CGC2020C = new CGC2020C();
                CGC2020C.MdiParent = this;
                CGC2020C.Show();
                CGC2020C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGC2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2060C"))
            {
                CGC2060C CGC2060C = new CGC2060C();
                CGC2060C.MdiParent = this;
                CGC2060C.Show();
                CGC2060C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2050C"))
            {
                CGD2050C CGD2050C = new CGD2050C();
                CGD2050C.MdiParent = this;
                CGD2050C.Show();
                CGD2050C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2041C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2041C"))
            {
                CGD2041C CGD2041C = new CGD2041C();
                CGD2041C.MdiParent = this;
                CGD2041C.Show();
                CGD2041C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2042C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2042C"))
            {
                CGD2042C CGD2042C = new CGD2042C();
                CGD2042C.MdiParent = this;
                CGD2042C.Show();
                CGD2042C.WindowState = FormWindowState.Maximized;
            }

        }

        

     
    }
	
	
	
}
