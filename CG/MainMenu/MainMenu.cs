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
        private StatusBarPanel statusBarPanel5;
        private MenuItem menuItem27;
        private MenuItem CGA2010C;
        private MenuItem CGA2020C;
        private MenuItem CGA2080C;
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
        private MenuItem AGC2430C;
        private MenuItem AGC2432C;
        private MenuItem AGC2440C;
        private MenuItem CGE2021C;
        private MenuItem CGC2070C;
        private MenuItem CGD2037C;
        private MenuItem CGC2071C;
        private MenuItem CGC2072C;
        private MenuItem CGD2081C;
        private MenuItem CGZ2031C;
        private MenuItem CGD2060C;
        private MenuItem CGC2050C;
        private MenuItem AGC2051C;
        private MenuItem CGE2020C;
        private MenuItem CGE2030C;
        private MenuItem CGE2040C;
        private MenuItem AGC3020C;
        private MenuItem CGF2010C;
        private MenuItem CGF2020C;
        private MenuItem CGF2030C;
        private MenuItem CGF2032C;
        private MenuItem CGF2031C;
        private MenuItem CGF2050C;
        private MenuItem CGF2051C;
        private MenuItem CGF2052C;
        private MenuItem CGF2060C;
        private MenuItem CGF2070C;
        private MenuItem CGF2040C;
        private MenuItem CGF2090C;
        private MenuItem menuItem28;
        private MenuItem CGG2040C;
        private MenuItem CKG2030C;
        private MenuItem CGD2070C;
        private MenuItem CGT2000C;
        private MenuItem CGT2010C;
        private MenuItem CGT2020C;
        private MenuItem CGT2040C;
        private MenuItem CGT2060C;
        private MenuItem CGT2050C;
        private MenuItem CGT2001C;
        private MenuItem CGD2061C;
        private MenuItem CGD2062C;
        private MenuItem CGT2100C;
        private MenuItem CGT2101C;
        private MenuItem CGT2102C;
        private MenuItem CGT2110C;
        private MenuItem menuItem29;
        private MenuItem CGH2020C;
        private MenuItem CGH2030C;
        private MenuItem CGT2200C;
        private MenuItem menuItem30;
        private MenuItem CGT2090C;
        private MenuItem CGD2080C;
        private MenuItem CGD2082C;
        private MenuItem CGC2021C;
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
            this.CGC2021C = new System.Windows.Forms.MenuItem();
            this.CGC2060C = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.CGD2080C = new System.Windows.Forms.MenuItem();
            this.CGD2050C = new System.Windows.Forms.MenuItem();
            this.CGD2041C = new System.Windows.Forms.MenuItem();
            this.AGC2430C = new System.Windows.Forms.MenuItem();
            this.AGC2432C = new System.Windows.Forms.MenuItem();
            this.AGC2440C = new System.Windows.Forms.MenuItem();
            this.CGE2021C = new System.Windows.Forms.MenuItem();
            this.CGC2070C = new System.Windows.Forms.MenuItem();
            this.CGD2037C = new System.Windows.Forms.MenuItem();
            this.CGC2071C = new System.Windows.Forms.MenuItem();
            this.CGC2072C = new System.Windows.Forms.MenuItem();
            this.CGD2081C = new System.Windows.Forms.MenuItem();
            this.CGD2082C = new System.Windows.Forms.MenuItem();
            this.CGZ2031C = new System.Windows.Forms.MenuItem();
            this.CGD2060C = new System.Windows.Forms.MenuItem();
            this.CGC2050C = new System.Windows.Forms.MenuItem();
            this.CGD2042C = new System.Windows.Forms.MenuItem();
            this.AGC2051C = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.CGE2020C = new System.Windows.Forms.MenuItem();
            this.CGE2030C = new System.Windows.Forms.MenuItem();
            this.CGE2040C = new System.Windows.Forms.MenuItem();
            this.AGC3020C = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.CGF2010C = new System.Windows.Forms.MenuItem();
            this.CGF2020C = new System.Windows.Forms.MenuItem();
            this.CGF2030C = new System.Windows.Forms.MenuItem();
            this.CGF2032C = new System.Windows.Forms.MenuItem();
            this.CGF2031C = new System.Windows.Forms.MenuItem();
            this.CGF2050C = new System.Windows.Forms.MenuItem();
            this.CGF2051C = new System.Windows.Forms.MenuItem();
            this.CGF2052C = new System.Windows.Forms.MenuItem();
            this.CGF2060C = new System.Windows.Forms.MenuItem();
            this.CGF2070C = new System.Windows.Forms.MenuItem();
            this.CGF2040C = new System.Windows.Forms.MenuItem();
            this.CGF2090C = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.CGG2040C = new System.Windows.Forms.MenuItem();
            this.CKG2030C = new System.Windows.Forms.MenuItem();
            this.CGD2070C = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.CGT2000C = new System.Windows.Forms.MenuItem();
            this.CGT2010C = new System.Windows.Forms.MenuItem();
            this.CGT2020C = new System.Windows.Forms.MenuItem();
            this.CGT2040C = new System.Windows.Forms.MenuItem();
            this.CGT2060C = new System.Windows.Forms.MenuItem();
            this.CGT2050C = new System.Windows.Forms.MenuItem();
            this.CGD2061C = new System.Windows.Forms.MenuItem();
            this.CGD2062C = new System.Windows.Forms.MenuItem();
            this.CGT2100C = new System.Windows.Forms.MenuItem();
            this.CGT2101C = new System.Windows.Forms.MenuItem();
            this.CGT2102C = new System.Windows.Forms.MenuItem();
            this.CGT2001C = new System.Windows.Forms.MenuItem();
            this.CGT2110C = new System.Windows.Forms.MenuItem();
            this.CGT2200C = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.CGH2020C = new System.Windows.Forms.MenuItem();
            this.CGH2030C = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.CGT2090C = new System.Windows.Forms.MenuItem();
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
            this.menuItem27,
            this.menuItem9,
            this.menuItem10,
            this.menuItem21,
            this.menuItem12,
            this.menuItem28,
            this.menuItem23,
            this.menuItem29,
            this.menuItem30,
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
            this.CGC2021C,
            this.CGC2060C});
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
            // CGC2021C
            // 
            this.CGC2021C.Index = 5;
            resources.ApplyResources(this.CGC2021C, "CGC2021C");
            this.CGC2021C.Click += new System.EventHandler(this.CGC2021C_Click);
            // 
            // CGC2060C
            // 
            this.CGC2060C.Index = 6;
            resources.ApplyResources(this.CGC2060C, "CGC2060C");
            this.CGC2060C.Click += new System.EventHandler(this.CGC2060C_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGD2080C,
            this.CGD2050C,
            this.CGD2041C,
            this.AGC2430C,
            this.AGC2432C,
            this.AGC2440C,
            this.CGE2021C,
            this.CGC2070C,
            this.CGD2037C,
            this.CGC2071C,
            this.CGC2072C,
            this.CGD2081C,
            this.CGD2082C,
            this.CGZ2031C,
            this.CGD2060C,
            this.CGC2050C,
            this.CGD2042C,
            this.AGC2051C});
            resources.ApplyResources(this.menuItem10, "menuItem10");
            // 
            // CGD2080C
            // 
            this.CGD2080C.Index = 0;
            resources.ApplyResources(this.CGD2080C, "CGD2080C");
            this.CGD2080C.Click += new System.EventHandler(this.CGD2080C_Click);
            // 
            // CGD2050C
            // 
            this.CGD2050C.Index = 1;
            resources.ApplyResources(this.CGD2050C, "CGD2050C");
            this.CGD2050C.Click += new System.EventHandler(this.CGD2050C_Click);
            // 
            // CGD2041C
            // 
            this.CGD2041C.Index = 2;
            resources.ApplyResources(this.CGD2041C, "CGD2041C");
            this.CGD2041C.Click += new System.EventHandler(this.CGD2041C_Click);
            // 
            // AGC2430C
            // 
            this.AGC2430C.Index = 3;
            resources.ApplyResources(this.AGC2430C, "AGC2430C");
            this.AGC2430C.Click += new System.EventHandler(this.AGC2430C_Click);
            // 
            // AGC2432C
            // 
            this.AGC2432C.Index = 4;
            resources.ApplyResources(this.AGC2432C, "AGC2432C");
            this.AGC2432C.Click += new System.EventHandler(this.AGC2432C_Click);
            // 
            // AGC2440C
            // 
            this.AGC2440C.Index = 5;
            resources.ApplyResources(this.AGC2440C, "AGC2440C");
            this.AGC2440C.Click += new System.EventHandler(this.AGC2440C_Click);
            // 
            // CGE2021C
            // 
            this.CGE2021C.Index = 6;
            resources.ApplyResources(this.CGE2021C, "CGE2021C");
            this.CGE2021C.Click += new System.EventHandler(this.CGE2021C_Click);
            // 
            // CGC2070C
            // 
            this.CGC2070C.Index = 7;
            resources.ApplyResources(this.CGC2070C, "CGC2070C");
            this.CGC2070C.Click += new System.EventHandler(this.CGC2070C_Click);
            // 
            // CGD2037C
            // 
            this.CGD2037C.Index = 8;
            resources.ApplyResources(this.CGD2037C, "CGD2037C");
            this.CGD2037C.Click += new System.EventHandler(this.CGD2037C_Click);
            // 
            // CGC2071C
            // 
            this.CGC2071C.Index = 9;
            resources.ApplyResources(this.CGC2071C, "CGC2071C");
            this.CGC2071C.Click += new System.EventHandler(this.CGC2071C_Click);
            // 
            // CGC2072C
            // 
            this.CGC2072C.Index = 10;
            resources.ApplyResources(this.CGC2072C, "CGC2072C");
            this.CGC2072C.Click += new System.EventHandler(this.CGC2072C_Click);
            // 
            // CGD2081C
            // 
            this.CGD2081C.Index = 11;
            resources.ApplyResources(this.CGD2081C, "CGD2081C");
            this.CGD2081C.Click += new System.EventHandler(this.CGD2081C_Click);
            // 
            // CGD2082C
            // 
            this.CGD2082C.Index = 12;
            resources.ApplyResources(this.CGD2082C, "CGD2082C");
            this.CGD2082C.Click += new System.EventHandler(this.CGD2082C_Click);
            // 
            // CGZ2031C
            // 
            this.CGZ2031C.Index = 13;
            resources.ApplyResources(this.CGZ2031C, "CGZ2031C");
            this.CGZ2031C.Click += new System.EventHandler(this.CGZ2031C_Click);
            // 
            // CGD2060C
            // 
            this.CGD2060C.Index = 14;
            resources.ApplyResources(this.CGD2060C, "CGD2060C");
            this.CGD2060C.Click += new System.EventHandler(this.CGD2060C_Click);
            // 
            // CGC2050C
            // 
            this.CGC2050C.Index = 15;
            resources.ApplyResources(this.CGC2050C, "CGC2050C");
            this.CGC2050C.Click += new System.EventHandler(this.CGC2050C_Click);
            // 
            // CGD2042C
            // 
            this.CGD2042C.Index = 16;
            resources.ApplyResources(this.CGD2042C, "CGD2042C");
            this.CGD2042C.Click += new System.EventHandler(this.CGD2042C_Click);
            // 
            // AGC2051C
            // 
            this.AGC2051C.Index = 17;
            resources.ApplyResources(this.AGC2051C, "AGC2051C");
            this.AGC2051C.Click += new System.EventHandler(this.AGC2051C_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 3;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGE2020C,
            this.CGE2030C,
            this.CGE2040C,
            this.AGC3020C});
            resources.ApplyResources(this.menuItem21, "menuItem21");
            // 
            // CGE2020C
            // 
            this.CGE2020C.Index = 0;
            resources.ApplyResources(this.CGE2020C, "CGE2020C");
            this.CGE2020C.Click += new System.EventHandler(this.CGE2020C_Click);
            // 
            // CGE2030C
            // 
            this.CGE2030C.Index = 1;
            resources.ApplyResources(this.CGE2030C, "CGE2030C");
            this.CGE2030C.Click += new System.EventHandler(this.CGE2030C_Click);
            // 
            // CGE2040C
            // 
            this.CGE2040C.Index = 2;
            resources.ApplyResources(this.CGE2040C, "CGE2040C");
            this.CGE2040C.Click += new System.EventHandler(this.CGE2040C_Click);
            // 
            // AGC3020C
            // 
            this.AGC3020C.Index = 3;
            resources.ApplyResources(this.AGC3020C, "AGC3020C");
            this.AGC3020C.Click += new System.EventHandler(this.AGC3020C_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGF2010C,
            this.CGF2020C,
            this.CGF2030C,
            this.CGF2032C,
            this.CGF2031C,
            this.CGF2050C,
            this.CGF2051C,
            this.CGF2052C,
            this.CGF2060C,
            this.CGF2070C,
            this.CGF2040C,
            this.CGF2090C});
            resources.ApplyResources(this.menuItem12, "menuItem12");
            // 
            // CGF2010C
            // 
            this.CGF2010C.Index = 0;
            resources.ApplyResources(this.CGF2010C, "CGF2010C");
            this.CGF2010C.Click += new System.EventHandler(this.CGF2010C_Click);
            // 
            // CGF2020C
            // 
            this.CGF2020C.Index = 1;
            resources.ApplyResources(this.CGF2020C, "CGF2020C");
            this.CGF2020C.Click += new System.EventHandler(this.CGF2020C_Click);
            // 
            // CGF2030C
            // 
            this.CGF2030C.Index = 2;
            resources.ApplyResources(this.CGF2030C, "CGF2030C");
            this.CGF2030C.Click += new System.EventHandler(this.CGF2030C_Click);
            // 
            // CGF2032C
            // 
            this.CGF2032C.Index = 3;
            resources.ApplyResources(this.CGF2032C, "CGF2032C");
            this.CGF2032C.Click += new System.EventHandler(this.CGF2032C_Click);
            // 
            // CGF2031C
            // 
            this.CGF2031C.Index = 4;
            resources.ApplyResources(this.CGF2031C, "CGF2031C");
            this.CGF2031C.Click += new System.EventHandler(this.CGF2031C_Click);
            // 
            // CGF2050C
            // 
            this.CGF2050C.Index = 5;
            resources.ApplyResources(this.CGF2050C, "CGF2050C");
            this.CGF2050C.Click += new System.EventHandler(this.CGF2050C_Click);
            // 
            // CGF2051C
            // 
            this.CGF2051C.Index = 6;
            resources.ApplyResources(this.CGF2051C, "CGF2051C");
            this.CGF2051C.Click += new System.EventHandler(this.CGF2051C_Click);
            // 
            // CGF2052C
            // 
            this.CGF2052C.Index = 7;
            resources.ApplyResources(this.CGF2052C, "CGF2052C");
            this.CGF2052C.Click += new System.EventHandler(this.CGF2052C_Click);
            // 
            // CGF2060C
            // 
            this.CGF2060C.Index = 8;
            resources.ApplyResources(this.CGF2060C, "CGF2060C");
            this.CGF2060C.Click += new System.EventHandler(this.CGF2060C_Click);
            // 
            // CGF2070C
            // 
            this.CGF2070C.Index = 9;
            resources.ApplyResources(this.CGF2070C, "CGF2070C");
            this.CGF2070C.Click += new System.EventHandler(this.CGF2070C_Click);
            // 
            // CGF2040C
            // 
            this.CGF2040C.Index = 10;
            resources.ApplyResources(this.CGF2040C, "CGF2040C");
            this.CGF2040C.Click += new System.EventHandler(this.CGF2040C_Click);
            // 
            // CGF2090C
            // 
            this.CGF2090C.Index = 11;
            resources.ApplyResources(this.CGF2090C, "CGF2090C");
            this.CGF2090C.Click += new System.EventHandler(this.CGF2090C_Click);
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 5;
            this.menuItem28.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGG2040C,
            this.CKG2030C,
            this.CGD2070C});
            resources.ApplyResources(this.menuItem28, "menuItem28");
            // 
            // CGG2040C
            // 
            this.CGG2040C.Index = 0;
            resources.ApplyResources(this.CGG2040C, "CGG2040C");
            this.CGG2040C.Click += new System.EventHandler(this.CGG2040C_Click);
            // 
            // CKG2030C
            // 
            this.CKG2030C.Index = 1;
            resources.ApplyResources(this.CKG2030C, "CKG2030C");
            this.CKG2030C.Click += new System.EventHandler(this.CKG2030C_Click);
            // 
            // CGD2070C
            // 
            this.CGD2070C.Index = 2;
            resources.ApplyResources(this.CGD2070C, "CGD2070C");
            this.CGD2070C.Click += new System.EventHandler(this.CGD2070C_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 6;
            this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGT2000C,
            this.CGT2010C,
            this.CGT2020C,
            this.CGT2040C,
            this.CGT2060C,
            this.CGT2050C,
            this.CGD2061C,
            this.CGD2062C,
            this.CGT2100C,
            this.CGT2101C,
            this.CGT2102C,
            this.CGT2001C,
            this.CGT2110C,
            this.CGT2200C});
            resources.ApplyResources(this.menuItem23, "menuItem23");
            // 
            // CGT2000C
            // 
            this.CGT2000C.Index = 0;
            resources.ApplyResources(this.CGT2000C, "CGT2000C");
            this.CGT2000C.Click += new System.EventHandler(this.CGT2000C_Click);
            // 
            // CGT2010C
            // 
            this.CGT2010C.Index = 1;
            resources.ApplyResources(this.CGT2010C, "CGT2010C");
            this.CGT2010C.Click += new System.EventHandler(this.CGT2010C_Click);
            // 
            // CGT2020C
            // 
            this.CGT2020C.Index = 2;
            resources.ApplyResources(this.CGT2020C, "CGT2020C");
            this.CGT2020C.Click += new System.EventHandler(this.CGT2020C_Click);
            // 
            // CGT2040C
            // 
            this.CGT2040C.Index = 3;
            resources.ApplyResources(this.CGT2040C, "CGT2040C");
            this.CGT2040C.Click += new System.EventHandler(this.CGT2040C_Click);
            // 
            // CGT2060C
            // 
            this.CGT2060C.Index = 4;
            resources.ApplyResources(this.CGT2060C, "CGT2060C");
            this.CGT2060C.Click += new System.EventHandler(this.CGT2060C_Click);
            // 
            // CGT2050C
            // 
            this.CGT2050C.Index = 5;
            resources.ApplyResources(this.CGT2050C, "CGT2050C");
            this.CGT2050C.Click += new System.EventHandler(this.CGT2050C_Click);
            // 
            // CGD2061C
            // 
            this.CGD2061C.Index = 6;
            resources.ApplyResources(this.CGD2061C, "CGD2061C");
            this.CGD2061C.Click += new System.EventHandler(this.CGD2061C_Click);
            // 
            // CGD2062C
            // 
            this.CGD2062C.Index = 7;
            resources.ApplyResources(this.CGD2062C, "CGD2062C");
            this.CGD2062C.Click += new System.EventHandler(this.CGD2062C_Click);
            // 
            // CGT2100C
            // 
            this.CGT2100C.Index = 8;
            resources.ApplyResources(this.CGT2100C, "CGT2100C");
            this.CGT2100C.Click += new System.EventHandler(this.CGT2100C_Click);
            // 
            // CGT2101C
            // 
            this.CGT2101C.Index = 9;
            resources.ApplyResources(this.CGT2101C, "CGT2101C");
            this.CGT2101C.Click += new System.EventHandler(this.CGT2101C_Click);
            // 
            // CGT2102C
            // 
            this.CGT2102C.Index = 10;
            resources.ApplyResources(this.CGT2102C, "CGT2102C");
            this.CGT2102C.Click += new System.EventHandler(this.CGT2102C_Click);
            // 
            // CGT2001C
            // 
            this.CGT2001C.Index = 11;
            resources.ApplyResources(this.CGT2001C, "CGT2001C");
            this.CGT2001C.Click += new System.EventHandler(this.CGT2001C_Click);
            // 
            // CGT2110C
            // 
            this.CGT2110C.Index = 12;
            resources.ApplyResources(this.CGT2110C, "CGT2110C");
            this.CGT2110C.Click += new System.EventHandler(this.CGT2110C_Click);
            // 
            // CGT2200C
            // 
            this.CGT2200C.Index = 13;
            resources.ApplyResources(this.CGT2200C, "CGT2200C");
            this.CGT2200C.Click += new System.EventHandler(this.CGT2200C_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 7;
            this.menuItem29.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGH2020C,
            this.CGH2030C});
            resources.ApplyResources(this.menuItem29, "menuItem29");
            // 
            // CGH2020C
            // 
            this.CGH2020C.Index = 0;
            resources.ApplyResources(this.CGH2020C, "CGH2020C");
            this.CGH2020C.Click += new System.EventHandler(this.CGH2020C_Click);
            // 
            // CGH2030C
            // 
            this.CGH2030C.Index = 1;
            resources.ApplyResources(this.CGH2030C, "CGH2030C");
            this.CGH2030C.Click += new System.EventHandler(this.CGH2030C_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 8;
            this.menuItem30.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CGT2090C});
            resources.ApplyResources(this.menuItem30, "menuItem30");
            // 
            // CGT2090C
            // 
            this.CGT2090C.Index = 0;
            resources.ApplyResources(this.CGT2090C, "CGT2090C");
            this.CGT2090C.Click += new System.EventHandler(this.CGT2090C_Click);
            // 
            // Mnu_Control
            // 
            this.Mnu_Control.Index = 9;
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
            this.MenuItem1.Index = 10;
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
            this.Mnu_Windows.Index = 11;
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

        private void AGC2430C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("AGC2430C"))
            {
                AGC2430C AGC2430C = new AGC2430C();
                AGC2430C.MdiParent = this;
                AGC2430C.Show();
                AGC2430C.WindowState = FormWindowState.Maximized;
            }

        }

        private void AGC2432C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("AGC2432C"))
            {
                AGC2432C AGC2432C = new AGC2432C();
                AGC2432C.MdiParent = this;
                AGC2432C.Show();
                AGC2432C.WindowState = FormWindowState.Maximized;
            }
        }

        private void AGC2440C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("AGC2440C"))
            {
                AGC2440C AGC2440C = new AGC2440C();
                AGC2440C.MdiParent = this;
                AGC2440C.Show();
                AGC2440C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGE2021C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGE2021C"))
            {
                CGE2021C CGE2021C = new CGE2021C();
                CGE2021C.MdiParent = this;
                CGE2021C.Show();
                CGE2021C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGC2070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2070C"))
            {
                CGC2070C CGC2070C = new CGC2070C();
                CGC2070C.MdiParent = this;
                CGC2070C.Show();
                CGC2070C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2037C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2037C"))
            {
                CGD2037C CGD2037C = new CGD2037C();
                CGD2037C.MdiParent = this;
                CGD2037C.Show();
                CGD2037C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGC2071C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2071C"))
            {
                CGC2071C CGC2071C = new CGC2071C();
                CGC2071C.MdiParent = this;
                CGC2071C.Show();
                CGC2071C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGC2072C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2072C"))
            {
                CGC2072C CGC2072C = new CGC2072C();
                CGC2072C.MdiParent = this;
                CGC2072C.Show();
                CGC2072C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2081C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2081C"))
            {
                CGD2081C CGD2081C = new CGD2081C();
                CGD2081C.MdiParent = this;
                CGD2081C.Show();
                CGD2081C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGZ2031C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGZ2031C"))
            {
                CGZ2031C CGZ2031C = new CGZ2031C();
                CGZ2031C.MdiParent = this;
                CGZ2031C.Show();
                CGZ2031C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2060C"))
            {
                CGD2060C CGD2060C = new CGD2060C();
                CGD2060C.MdiParent = this;
                CGD2060C.Show();
                CGD2060C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGC2050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2050C"))
            {
                CGC2050C CGC2050C = new CGC2050C();
                CGC2050C.MdiParent = this;
                CGC2050C.Show();
                CGC2050C.WindowState = FormWindowState.Maximized;
            }
        }

        private void AGC2051C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("AGC2051C"))
            {
                AGC2051C AGC2051C = new AGC2051C();
                AGC2051C.MdiParent = this;
                AGC2051C.Show();
                AGC2051C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGE2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGE2020C"))
            {
                CGE2020C CGE2020C = new CGE2020C();
                CGE2020C.MdiParent = this;
                CGE2020C.Show();
                CGE2020C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGE2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGE2030C"))
            {
                CGE2030C CGE2030C = new CGE2030C();
                CGE2030C.MdiParent = this;
                CGE2030C.Show();
                CGE2030C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGE2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGE2040C"))
            {
                CGE2040C CGE2040C = new CGE2040C();
                CGE2040C.MdiParent = this;
                CGE2040C.Show();
                CGE2040C.WindowState = FormWindowState.Maximized;
            }
        }

        private void AGC3020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("AGC3020C"))
            {
                AGC3020C AGC3020C = new AGC3020C();
                AGC3020C.MdiParent = this;
                AGC3020C.Show();
                AGC3020C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2010C"))
            {
                CGF2010C CGF2010C = new CGF2010C();
                CGF2010C.MdiParent = this;
                CGF2010C.Show();
                CGF2010C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2020C"))
            {
                CGF2020C CGF2020C = new CGF2020C();
                CGF2020C.MdiParent = this;
                CGF2020C.Show();
                CGF2020C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGF2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2030C"))
            {
                CGF2030C CGF2030C = new CGF2030C();
                CGF2030C.MdiParent = this;
                CGF2030C.Show();
                CGF2030C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2032C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2032C"))
            {
                CGF2032C CGF2032C = new CGF2032C();
                CGF2032C.MdiParent = this;
                CGF2032C.Show();
                CGF2032C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2031C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2031C"))
            {
                CGF2031C CGF2031C = new CGF2031C();
                CGF2031C.MdiParent = this;
                CGF2031C.Show();
                CGF2031C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2050C"))
            {
                CGF2050C CGF2050C = new CGF2050C();
                CGF2050C.MdiParent = this;
                CGF2050C.Show();
                CGF2050C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2051C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2051C"))
            {
                CGF2051C CGF2051C = new CGF2051C();
                CGF2051C.MdiParent = this;
                CGF2051C.Show();
                CGF2051C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGF2052C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2052C"))
            {
                CGF2052C CGF2052C = new CGF2052C();
                CGF2052C.MdiParent = this;
                CGF2052C.Show();
                CGF2052C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2060C"))
            {
                CGF2060C CGF2060C = new CGF2060C();
                CGF2060C.MdiParent = this;
                CGF2060C.Show();
                CGF2060C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2070C"))
            {
                CGF2070C CGF2070C = new CGF2070C();
                CGF2070C.MdiParent = this;
                CGF2070C.Show();
                CGF2070C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGF2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2040C"))
            {
                CGF2040C CGF2040C = new CGF2040C();
                CGF2040C.MdiParent = this;
                CGF2040C.Show();
                CGF2040C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGF2090C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGF2090C"))
            {
                CGF2090C CGF2090C = new CGF2090C();
                CGF2090C.MdiParent = this;
                CGF2090C.Show();
                CGF2090C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGG2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGG2040C"))
            {
                CGG2040C CGG2040C = new CGG2040C();
                CGG2040C.MdiParent = this;
                CGG2040C.Show();
                CGG2040C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CKG2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CKG2030C"))
            {
                CKG2030C CKG2030C = new CKG2030C();
                CKG2030C.MdiParent = this;
                CKG2030C.Show();
                CKG2030C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGD2070C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2070C"))
            {
                CGD2070C CGD2070C = new CGD2070C();
                CGD2070C.MdiParent = this;
                CGD2070C.Show();
                CGD2070C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2000C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2000C"))
            {
                CGT2000C CGT2000C = new CGT2000C();
                CGT2000C.MdiParent = this;
                CGT2000C.Show();
                CGT2000C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2010C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2010C"))
            {
                CGT2010C CGT2010C = new CGT2010C();
                CGT2010C.MdiParent = this;
                CGT2010C.Show();
                CGT2010C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2020C"))
            {
                CGT2020C CGT2020C = new CGT2020C();
                CGT2020C.MdiParent = this;
                CGT2020C.Show();
                CGT2020C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2040C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2040C"))
            {
                CGT2040C CGT2040C = new CGT2040C();
                CGT2040C.MdiParent = this;
                CGT2040C.Show();
                CGT2040C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2060C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2060C"))
            {
                CGT2060C CGT2060C = new CGT2060C();
                CGT2060C.MdiParent = this;
                CGT2060C.Show();
                CGT2060C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2050C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2050C"))
            {
                CGT2050C CGT2050C = new CGT2050C();
                CGT2050C.MdiParent = this;
                CGT2050C.Show();
                CGT2050C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2001C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2001C"))
            {
                CGT2001C CGT2001C = new CGT2001C();
                CGT2001C.MdiParent = this;
                CGT2001C.Show();
                CGT2001C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2061C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2061C"))
            {
                CGD2061C CGD2061C = new CGD2061C();
                CGD2061C.MdiParent = this;
                CGD2061C.Show();
                CGD2061C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGD2062C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2062C"))
            {
                CGD2062C CGD2062C = new CGD2062C();
                CGD2062C.MdiParent = this;
                CGD2062C.Show();
                CGD2062C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2100C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2100C"))
            {
                CGT2100C CGT2100C = new CGT2100C();
                CGT2100C.MdiParent = this;
                CGT2100C.Show();
                CGT2100C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2101C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2101C"))
            {
                CGT2101C CGT2101C = new CGT2101C();
                CGT2101C.MdiParent = this;
                CGT2101C.Show();
                CGT2101C.WindowState = FormWindowState.Maximized;
            }


        }

        private void CGT2102C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2102C"))
            {
                CGT2102C CGT2102C = new CGT2102C();
                CGT2102C.MdiParent = this;
                CGT2102C.Show();
                CGT2102C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2110C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2110C"))
            {
                CGT2110C CGT2110C = new CGT2110C();
                CGT2110C.MdiParent = this;
                CGT2110C.Show();
                CGT2110C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGH2020C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGH2020C"))
            {
                CGH2020C CGH2020C = new CGH2020C();
                CGH2020C.MdiParent = this;
                CGH2020C.Show();
                CGH2020C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGH2030C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGH2030C"))
            {
                CGH2030C CGH2030C = new CGH2030C();
                CGH2030C.MdiParent = this;
                CGH2030C.Show();
                CGH2030C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGT2200C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2200C"))
            {
                CGT2200C CGT2200C = new CGT2200C();
                CGT2200C.MdiParent = this;
                CGT2200C.Show();
                CGT2200C.WindowState = FormWindowState.Maximized;
            }

        }

        private void CGT2090C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGT2090C"))
            {
                CGT2090C CGT2090C = new CGT2090C();
                CGT2090C.MdiParent = this;
                CGT2090C.Show();
                CGT2090C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2080C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2080C"))
            {
                CGD2080C CGD2080C = new CGD2080C();
                CGD2080C.MdiParent = this;
                CGD2080C.Show();
                CGD2080C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGD2082C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGD2082C"))
            {
                CGD2082C CGD2082C = new CGD2082C();
                CGD2082C.MdiParent = this;
                CGD2082C.Show();
                CGD2082C.WindowState = FormWindowState.Maximized;
            }
        }

        private void CGC2021C_Click(object sender, EventArgs e)
        {
            if (!GeneralCommon.Gf_IsFormLoad("CGC2021C"))
            {
                CGC2021C CGC2021C = new CGC2021C();
                CGC2021C.MdiParent = this;
                CGC2021C.Show();
                CGC2021C.WindowState = FormWindowState.Maximized;
            }
        }

     
    }
	
	
	
}
