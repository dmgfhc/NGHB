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
using WG;


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


namespace FG
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
        private MenuItem menuItem12;
        private MenuItem menuItem24;
        private StatusBarPanel statusBarPanel5;
        private MenuItem menuItem7;
        private MenuItem FKA1010C;
        private MenuItem FGA1010C;
        private MenuItem FGA1020C;
        private MenuItem FGA1030C;
        private MenuItem FGA1040C;
        private MenuItem FGA1050C;
        private MenuItem FGA1060C;
        private MenuItem WGC2050C;
        private MenuItem WGC2040C;
        private MenuItem WGC3010C;
        private MenuItem WGC3030C;
        private MenuItem FGC1010C;
        private MenuItem FGC1020C;
        private MenuItem FGC1030C;
        private MenuItem FGC1040C;
        private MenuItem FGC1050C;
        private MenuItem WGT2030C;
        private MenuItem WGT2020C;
        private MenuItem FGC1080C;
        private MenuItem menuItem3;
        private MenuItem WGE1010C;
        private MenuItem WGE1020C;
        private MenuItem menuItem4;
        private MenuItem FGA1080C;
        private MenuItem menuItem6;
        private MenuItem FGA1090C;
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
			InitializeComponent();
			
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
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.FKA1010C = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.FGA1010C = new System.Windows.Forms.MenuItem();
            this.FGA1020C = new System.Windows.Forms.MenuItem();
            this.FGA1030C = new System.Windows.Forms.MenuItem();
            this.FGA1040C = new System.Windows.Forms.MenuItem();
            this.FGA1050C = new System.Windows.Forms.MenuItem();
            this.FGA1060C = new System.Windows.Forms.MenuItem();
            this.WGC2040C = new System.Windows.Forms.MenuItem();
            this.WGC2050C = new System.Windows.Forms.MenuItem();
            this.WGC3010C = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.WGC3030C = new System.Windows.Forms.MenuItem();
            this.FGA1080C = new System.Windows.Forms.MenuItem();
            this.FGA1090C = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.FGC1010C = new System.Windows.Forms.MenuItem();
            this.FGC1020C = new System.Windows.Forms.MenuItem();
            this.FGC1030C = new System.Windows.Forms.MenuItem();
            this.FGC1040C = new System.Windows.Forms.MenuItem();
            this.FGC1050C = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.WGT2020C = new System.Windows.Forms.MenuItem();
            this.WGT2030C = new System.Windows.Forms.MenuItem();
            this.FGC1080C = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.WGE1010C = new System.Windows.Forms.MenuItem();
            this.WGE1020C = new System.Windows.Forms.MenuItem();
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
            this.menuItem12,
            this.menuItem24,
            this.menuItem7,
            this.menuItem3,
            this.Mnu_Control,
            this.MenuItem1,
            this.Mnu_Windows});
            resources.ApplyResources(this.MainMenu1, "MainMenu1");
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FKA1010C});
            resources.ApplyResources(this.menuItem12, "menuItem12");
            // 
            // FKA1010C
            // 
            this.FKA1010C.Index = 0;
            resources.ApplyResources(this.FKA1010C, "FKA1010C");
            this.FKA1010C.Click += new System.EventHandler(this.FKA1010C_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 1;
            this.menuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FGA1010C,
            this.FGA1020C,
            this.FGA1030C,
            this.FGA1040C,
            this.FGA1050C,
            this.FGA1060C,
            this.WGC2040C,
            this.WGC2050C,
            this.WGC3010C,
            this.menuItem4,
            this.WGC3030C,
            this.FGA1080C,
            this.FGA1090C});
            resources.ApplyResources(this.menuItem24, "menuItem24");
            // 
            // FGA1010C
            // 
            this.FGA1010C.Index = 0;
            resources.ApplyResources(this.FGA1010C, "FGA1010C");
            this.FGA1010C.Click += new System.EventHandler(this.FGA1010C_Click);
            // 
            // FGA1020C
            // 
            this.FGA1020C.Index = 1;
            resources.ApplyResources(this.FGA1020C, "FGA1020C");
            this.FGA1020C.Click += new System.EventHandler(this.FGA1020C_Click);
            // 
            // FGA1030C
            // 
            this.FGA1030C.Index = 2;
            resources.ApplyResources(this.FGA1030C, "FGA1030C");
            this.FGA1030C.Click += new System.EventHandler(this.FGA1030C_Click);
            // 
            // FGA1040C
            // 
            this.FGA1040C.Index = 3;
            resources.ApplyResources(this.FGA1040C, "FGA1040C");
            this.FGA1040C.Click += new System.EventHandler(this.FGA1040C_Click);
            // 
            // FGA1050C
            // 
            this.FGA1050C.Index = 4;
            resources.ApplyResources(this.FGA1050C, "FGA1050C");
            this.FGA1050C.Click += new System.EventHandler(this.FGA1050C_Click);
            // 
            // FGA1060C
            // 
            this.FGA1060C.Index = 5;
            resources.ApplyResources(this.FGA1060C, "FGA1060C");
            this.FGA1060C.Click += new System.EventHandler(this.FGA1060C_Click);
            // 
            // WGC2040C
            // 
            this.WGC2040C.Index = 6;
            resources.ApplyResources(this.WGC2040C, "WGC2040C");
            this.WGC2040C.Click += new System.EventHandler(this.WGC2040C_Click);
            // 
            // WGC2050C
            // 
            this.WGC2050C.Index = 7;
            resources.ApplyResources(this.WGC2050C, "WGC2050C");
            this.WGC2050C.Click += new System.EventHandler(this.WGC2050C_Click);
            // 
            // WGC3010C
            // 
            this.WGC3010C.Index = 8;
            resources.ApplyResources(this.WGC3010C, "WGC3010C");
            this.WGC3010C.Click += new System.EventHandler(this.WGC3010C_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 9;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // WGC3030C
            // 
            this.WGC3030C.Index = 10;
            resources.ApplyResources(this.WGC3030C, "WGC3030C");
            this.WGC3030C.Click += new System.EventHandler(this.WGC3030C_Click);
            // 
            // FGA1080C
            // 
            this.FGA1080C.Index = 11;
            resources.ApplyResources(this.FGA1080C, "FGA1080C");
            this.FGA1080C.Click += new System.EventHandler(this.FGA1080C_Click);
            // 
            // FGA1090C
            // 
            this.FGA1090C.Index = 12;
            resources.ApplyResources(this.FGA1090C, "FGA1090C");
            this.FGA1090C.Click += new System.EventHandler(this.FGA1090C_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FGC1010C,
            this.FGC1020C,
            this.FGC1030C,
            this.FGC1040C,
            this.FGC1050C,
            this.menuItem6,
            this.WGT2020C,
            this.WGT2030C,
            this.FGC1080C});
            resources.ApplyResources(this.menuItem7, "menuItem7");
            // 
            // FGC1010C
            // 
            this.FGC1010C.Index = 0;
            resources.ApplyResources(this.FGC1010C, "FGC1010C");
            this.FGC1010C.Click += new System.EventHandler(this.FGC1010C_Click);
            // 
            // FGC1020C
            // 
            this.FGC1020C.Index = 1;
            resources.ApplyResources(this.FGC1020C, "FGC1020C");
            this.FGC1020C.Click += new System.EventHandler(this.FGC1020C_Click);
            // 
            // FGC1030C
            // 
            this.FGC1030C.Index = 2;
            resources.ApplyResources(this.FGC1030C, "FGC1030C");
            this.FGC1030C.Click += new System.EventHandler(this.FGC1030C_Click);
            // 
            // FGC1040C
            // 
            this.FGC1040C.Index = 3;
            resources.ApplyResources(this.FGC1040C, "FGC1040C");
            this.FGC1040C.Click += new System.EventHandler(this.FGC1040C_Click);
            // 
            // FGC1050C
            // 
            this.FGC1050C.Index = 4;
            resources.ApplyResources(this.FGC1050C, "FGC1050C");
            this.FGC1050C.Click += new System.EventHandler(this.FGC1050C_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // WGT2020C
            // 
            this.WGT2020C.Index = 6;
            resources.ApplyResources(this.WGT2020C, "WGT2020C");
            this.WGT2020C.Click += new System.EventHandler(this.WGT2020C_Click);
            // 
            // WGT2030C
            // 
            this.WGT2030C.Index = 7;
            resources.ApplyResources(this.WGT2030C, "WGT2030C");
            this.WGT2030C.Click += new System.EventHandler(this.WGT2030C_Click);
            // 
            // FGC1080C
            // 
            this.FGC1080C.Index = 8;
            resources.ApplyResources(this.FGC1080C, "FGC1080C");
            this.FGC1080C.Click += new System.EventHandler(this.FGC1080C_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WGE1010C,
            this.WGE1020C});
            resources.ApplyResources(this.menuItem3, "menuItem3");
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
            // Mnu_Control
            // 
            this.Mnu_Control.Index = 4;
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
            this.MenuItem1.Index = 5;
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
            this.Mnu_Windows.Index = 6;
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
            this.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.StatusBarPanel4, "StatusBarPanel4");
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

        //private void WGC3020C_Click(object sender, EventArgs e)
        //{
        //    if (!GeneralCommon.Gf_IsFormLoad("WGC3020C"))
        //    {
        //        FGA1070C WGC3020C = new FGA1070C();
        //        WGC3020C.MdiParent = this;
        //        WGC3020C.Show();
        //        WGC3020C.WindowState = FormWindowState.Maximized;

        //    }
        //}

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

        private void FGA1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1010C"))
            {
                FGA1010C FGA1010C = new FGA1010C();
                FGA1010C.MdiParent = this;
                FGA1010C.Show();
                FGA1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1020C"))
            {
                FGA1020C FGA1020C = new FGA1020C();
                FGA1020C.MdiParent = this;
                FGA1020C.Show();
                FGA1020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1030C"))
            {
                FGA1030C FGA1030C = new FGA1030C();
                FGA1030C.MdiParent = this;
                FGA1030C.Show();
                FGA1030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGC1050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1050C"))
            {
                FGC1050C FGC1050C = new FGC1050C();
                FGC1050C.MdiParent = this;
                FGC1050C.Show();
                FGC1050C.WindowState = FormWindowState.Maximized;

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

        private void WGT2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("WGT2030C"))
            {
                WGT2030C WGT2030C = new WGT2030C();
                WGT2030C.MdiParent = this;
                WGT2030C.Show();
                WGT2030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGC1080C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1080C"))
            {
                FGC1080C FGC1080C = new FGC1080C();
                FGC1080C.MdiParent = this;
                FGC1080C.Show();
                FGC1080C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGC1040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1040C"))
            {
                FGC1040C FGC1040C = new FGC1040C();
                FGC1040C.MdiParent = this;
                FGC1040C.Show();
                FGC1040C.WindowState = FormWindowState.Maximized;

            }

        }

        private void FGC1030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1030C"))
            {
                FGC1030C FGC1030C = new FGC1030C();
                FGC1030C.MdiParent = this;
                FGC1030C.Show();
                FGC1030C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGC1020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1020C"))
            {
                FGC1020C FGC1020C = new FGC1020C();
                FGC1020C.MdiParent = this;
                FGC1020C.Show();
                FGC1020C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGC1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1010C"))
            {
                FGC1010C FGC1010C = new FGC1010C();
                FGC1010C.MdiParent = this;
                FGC1010C.Show();
                FGC1010C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1040C"))
            {
                FGA1040C FGA1040C = new FGA1040C();
                FGA1040C.MdiParent = this;
                FGA1040C.Show();
                FGA1040C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1050C"))
            {
                FGA1050C FGA1050C = new FGA1050C();
                FGA1050C.MdiParent = this;
                FGA1050C.Show();
                FGA1050C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1060C"))
            {
                FGA1060C FGA1060C = new FGA1060C();
                FGA1060C.MdiParent = this;
                FGA1060C.Show();
                FGA1060C.WindowState = FormWindowState.Maximized;

            }
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

        private void FKA1010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FKA1010C"))
            {
                FKA1010C FKA1010C = new FKA1010C();
                FKA1010C.MdiParent = this;
                FKA1010C.Show();
                FKA1010C.WindowState = FormWindowState.Maximized;

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

        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1070C"))
            {
                FGA1070C FGA1070C = new FGA1070C();
                FGA1070C.MdiParent = this;
                FGA1070C.Show();
                FGA1070C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1080C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGA1080C"))
            {
                FGA1080C FGA1080C = new FGA1080C();
                FGA1080C.MdiParent = this;
                FGA1080C.Show();
                FGA1080C.WindowState = FormWindowState.Maximized;

            }


        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("FGC1060C"))
            {
                FGC1060C FGC1060C = new FGC1060C();
                FGC1060C.MdiParent = this;
                FGC1060C.Show();
                FGC1060C.WindowState = FormWindowState.Maximized;

            }
        }

        private void FGA1090C_Click(object sender, EventArgs e)
        {
            FGA1090C FGA1090C = new FGA1090C();
            FGA1090C.MdiParent = this;
            FGA1090C.Show();
            FGA1090C.WindowState = FormWindowState.Maximized;
        }


      
		
		#region MENU CLICK

      
		#endregion

       

     
        

       

     

      

      

        

   


       

        




       
       

       


       

        

       

        































    }
	
	
	
}
