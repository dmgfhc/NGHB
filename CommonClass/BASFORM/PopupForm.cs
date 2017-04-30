using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CommonClass
{
	public partial class PopupForm
	{
		public PopupForm()
		{
			InitializeComponent();
		}
		
		private Collection m_Sc;
		public Collection Sc
		{
			get
			{
				return m_Sc;
			}
			set
			{
				m_Sc = value;
			}
		}
		
		private Collection m_Rec;
		public Collection Record
		{
			get
			{
				return m_Rec;
			}
			set
			{
				m_Rec = value;
			}
		}
		
		private Collection m_Master = new Collection();
		
		#region Function Model
		
		public void Form_Pro()
		{
			MasterCommon mc = new MasterCommon();
			if (mc.Gf_Ms_Process(GeneralCommon.M_CN1, m_Master, "1111"))
			{
				
			}
		}
		
		#endregion
		
		#region  Get Configuration
		private void GetConfig()
		{
			Collection pControl = new Collection(); //Master Primary Key Collection
			Collection nControl = new Collection(); //Master Necessary Collection
			Collection mControl = new Collection(); //Master Maxlength check Collection
			Collection iControl = new Collection(); //Master Insert Collection
			Collection lControl = new Collection(); //Master Lock Collection
			m_Master.Add(pControl, "pControl", null, null);
			m_Master.Add(nControl, "nControl", null, null);
			m_Master.Add(mControl, "mControl", null, null);
			m_Master.Add(iControl, "iControl", null, null);
			m_Master.Add(lControl, "lControl", null, null);
			
			if (Sc != null)
			{
				m_Master.Add(Sc["P-M"], "P-M", null, null);
			}
			
		}
		
		#endregion
		
		#region Create UI
		private void CreateUI()
		{
			if (m_Rec != null)
			{
				//Create FlowLayout
				TableLayoutPanel dtp = new TableLayoutPanel();
				dtp.RowCount = ((Collection )Sc["CHTitle"]).Count;
				dtp.ColumnCount = 1;
				dtp.Dock = DockStyle.Fill;
				for (int i = 1; i <=( (Collection )Sc["CHTitle"]).Count; i++)
				{
					TableLayoutPanel ctl = CreateField(i);
					dtp.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, (float)100.0 / ((Collection)Sc["CHTitle"]).Count));                   
					dtp.Controls.Add(ctl, 0, i - 1);
					ctl.Dock = DockStyle.Fill;
				}
				this.SplitContainer1.Panel1.Controls.Add(dtp);
				
			}
		}
		
		private TableLayoutPanel CreateField(int colIndex)
		{
			//Create TableLayoutPanel
			TableLayoutPanel tlp = new TableLayoutPanel();
			tlp.ColumnCount = 2;
			tlp.RowCount = 1;
			tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0F));
			tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0F));
			tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
			
			//Create Label
			Label lbl = new Label();
			lbl.BorderStyle = BorderStyle.Fixed3D;
			lbl.TextAlign = ContentAlignment.MiddleRight;
			lbl.Text = (string) ((Collection )Sc["CHTitle"])[colIndex];
			
			tlp.Controls.Add(lbl, 0, 0);
			lbl.Dock = System.Windows.Forms.DockStyle.Fill;
			
			string sType = ((string) ((Collection )Sc["ColType"])[colIndex]).ToUpper();
			object ctl=null;
			switch (sType)
			{
				case "E": //'TextEdit,Password
				case "P":
                    TextBox ctl_t = new TextBox();
					if (sType == "P")
					{
						ctl_t.PasswordChar = '*';
					}
                    if (((Collection)Sc["ColLength"])[colIndex] == "") ctl_t.MaxLength = 200;
                    else ctl_t.MaxLength = (int)((Collection)Sc["ColLength"])[colIndex];
                    //ctl_t.MaxLength = ги((Collection)Sc["ColLength"])[colIndex] == "" ? 200 : ((Collection)Sc["ColLength"])[colIndex]));
                    tlp.Controls.Add(ctl_t, 1, 0);
                    ctl_t.Dock = DockStyle.Fill;
                    ctl_t.Text = (string)Record[colIndex];
                    ctl = ctl_t;
					break;
				case "N": //'NumberEdit
					ctl = new System.Windows.Forms.MaskedTextBox();
                    MaskedTextBox ctl_m = new MaskedTextBox();
					string[] Ass_1 = new string[3];
                    Ass_1 = ((Collection)Sc["ColLength"])[colIndex].ToString().Split(',');
                    ctl_m.Mask = " ".PadLeft(int.Parse(Ass_1[0])).Trim() + "." + " ".PadLeft(int.Parse(Ass_1[1])).Trim();
                    tlp.Controls.Add(ctl_m, 1, 0);
                    ctl_m.Dock = DockStyle.Fill;
                    ctl_m.Text = (string)Record[colIndex];
                    ctl = ctl_m;
					break;
				case "ON":
				case "OE":
					//'Combox not editable ''Combox Editable
					ctl = new ComboBox();
                    ComboBox ctl_c = new ComboBox();
                    string[] splitCom =((Collection)Sc["ComCode"])[colIndex].ToString().Split(';');
                    string[] splitProc = ((Collection)Sc["Filter"])[colIndex].ToString().Split(';');
                    string[] splitCus = ((Collection)Sc["CustQuery"])[colIndex].ToString().Split(';');
					DataSet ds=null;
					if (splitCom[0].Trim() != "")
					{
                        ds = new CdQuery(splitCom[0].Trim(), "").CreateDataSet(true);
                        ctl_c.DataSource = ds;
					}
					else if (splitProc[0].Trim() != "")
					{
						ds = new ProcQuery(splitProc[0].Trim(), new ArrayList()).CreateDataSet(true);
                        ctl_c.DataSource = ds;
					}
					else if (splitCus[0].Trim() != "")
					{
						ds = new Query(splitCus[0].Trim()).CreateDataSet(true);
                        ctl_c.DataSource = ds;
					}
                    ctl_c.DataSource = ds.Tables[0].DefaultView;
                    ctl_c.DisplayMember = ds.Tables[0].Columns[0].ToString();
                    ctl_c.ValueMember = ds.Tables[0].Columns[1].ToString();
                    ctl_c.SelectedValue = "";
					if (sType == "ON")
					{
                        ctl_c.DropDownStyle = ComboBoxStyle.DropDownList;
					}
					else
					{
                        ctl_c.DropDownStyle = ComboBoxStyle.DropDown;
					}

                    tlp.Controls.Add(ctl_c, 1, 0);
                    ctl_c.Dock = DockStyle.Fill;
                    ctl_c.Text = (string)Record[colIndex];
                    ctl = ctl_c;
					break;
				case "C": //'Checkbox
                    CheckBox ctl_c2 = new CheckBox();
                    tlp.Controls.Add(ctl_c2, 1, 0);
                    ctl_c2.Dock = DockStyle.Fill;
                    ctl_c2.Text =(string) Record[colIndex];
                    ctl = ctl_c2;
					break;
				case "D": //'Date ,Time
				case "T":
                    DateTimePicker ctl_d = new DateTimePicker();
                    ctl_d.Format = DateTimePickerFormat.Custom;
					if (sType == "D")
					{
                        ctl_d.CustomFormat = "yyyy-MM-dd";
					}
					else
					{
                        ctl_d.CustomFormat = "HH:mm:ss";
					}
                    tlp.Controls.Add(ctl_d, 1, 0);
                    ctl_d.Dock = DockStyle.Fill;
                    ctl_d.Text = (string)Record[colIndex];
                    ctl = ctl_d;
					break;
				case "COMR": //'TextEdit with F4 Event return Common code and name
					ctl = new F4COMR();
                    F4COMR ctl_f = new F4COMR();
                    ctl_f.sKey = ((Collection)Sc["ComCode"])[colIndex].ToString();
                    ctl_f.sJoin = ((Collection)Sc["Filter"])[colIndex].ToString();
                    ctl_f.sMax = 20;
                    tlp.Controls.Add(ctl_f, 1, 0);
                    ctl_f.Dock = DockStyle.Fill;
                    ctl_f.Text = (string)Record[colIndex];
                    ctl = ctl_f;
					break;
				case "COMN": //'TextEdit with F4 Event return Common code only
                    F4COMN ctl_f2 = new F4COMN();
                    ctl_f2.sKey = ((Collection)Sc["ComCode"])[colIndex].ToString();
                    ctl_f2.sJoin = ((Collection)Sc["Filter"])[colIndex].ToString();
                    tlp.Controls.Add(ctl_f2, 1, 0);
                    ctl_f2.Dock = DockStyle.Fill;
                    ctl_f2.Text = (string)Record[colIndex];
                    ctl = ctl_f2;
					break;
				case "ETCR": //'TextEdit with F4 Event return code and name
					break;
					
				case "ETCN": //'TextEdit with F4 Event return code only
                    F4ETCN ctl_f3 = new F4ETCN();
                    ctl_f3.sJoin = ((Collection)Sc["Filter"])[colIndex].ToString();
					string[] Ass = new string[3];
                    Ass = (((Collection)Sc["CustQuery"])[colIndex]).ToString().Split(';');
                    ctl_f3.sSqletc = Ass[0];
                    ctl_f3.sFcontrol = Ass[1];
                    tlp.Controls.Add(ctl_f3, 1, 0);
                    ctl_f3.Dock = DockStyle.Fill;
                    ctl_f3.Text = (string)Record[colIndex];
                    ctl = ctl_f3;
					break;
			}
			string sAttr = (string) (((Collection)Sc["ColAttr"])[colIndex].ToString().ToUpper());
			if (sAttr.IndexOf("P") > -1)
			{
                ((Collection)m_Master["pControl"]).Add(ctl);
			}
			else if (sAttr.IndexOf("N") > -1)
			{
				((Collection)m_Master["nControl"]).Add(ctl);
			}
			else if (sAttr.IndexOf("M") > -1)
			{
				((Collection)m_Master["mControl"]).Add(ctl);
			}
			else if (sAttr.IndexOf("I") > -1)
			{
				((Collection)m_Master["iControl"]).Add(ctl);
			}
			else if (sAttr.IndexOf("L") > -1)
			{
				((Collection)m_Master["lControl"]).Add(ctl);
			}
			
			return tlp;
		}
		
		#endregion
		
		#region Form Event
		public void PopupForm_Activated(object sender, System.EventArgs e)
		{
			
		}
		
		public void PopupForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
			else
			{
				Form_Pro();
				this.Close();
			}
		}
		
		public void PopupForm_Load(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Cursor cur;
			cur = System.Windows.Forms.Cursor.Current;
			System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
			
			GetConfig();
			CreateUI();
			
			System.Windows.Forms.Cursor.Current = cur;
		}
		#endregion
		
	}
}
