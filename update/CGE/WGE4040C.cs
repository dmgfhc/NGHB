using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;
//using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;
using Microsoft.VisualBasic.PowerPacks;
using Microsoft.VisualBasic.PowerPacks.Printing;

namespace CG
{
    public partial class WGE4040C : CommonClass.FORMBASE
    {
        public WGE4040C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        TextBox txt_location = new TextBox();
        Button BBTT = new Button();

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("库类型", txt_yard_knd, "PN", "", "", "", "", imcseq);//0
            p_SetMc("库种类", com_prod_type, "PN", "", "", "", "", imcseq);//1
            p_SetMc("跨号", com_yard_type, "PN", "", "", "", "", imcseq);//2
            p_SetMc("区号", com_zone_type, "PN", "", "", "", "", imcseq);//3

            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("库类型", "E", "", "AL", "", "", "", iscseq, iheadrow);//0
            p_SetSc("库号", "E", "", "AL", "", "", "", iscseq, iheadrow);//1
            p_SetSc("区号", "E", "", "AL", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("行号", "E", "", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("列号", "E", "", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("垛位号", "E", "", "L", "", "", "", iscseq, iheadrow);//5  
            p_SetSc("最大堆放数量", "E", "", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("库位代码", "E", "", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("垛位类型", "E", "", "AL", "", "", "", iscseq, iheadrow);//8

            p_SetSc("垛位坐标_X", "E", "", "AL", "", "", "", iscseq, iheadrow);//9   
            p_SetSc("垛位坐标_Y", "E", "", "AL", "", "", "", iscseq, iheadrow);//10    
            p_SetSc("垛位宽度", "E", "", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("垛位长度", "E", "", "L", "", "", "", iscseq, iheadrow);//12   
        }

        private void WGE40200C_Load(object sender, EventArgs e)
        {
            Form_Define();
            setControlBackColor();
            com_yard_type.Enabled = false;
            com_zone_type.Enabled = false;

            this.pan_show_window.VerticalScroll.Visible = true;
            this.pan_show_window.HorizontalScroll.Visible = true;
            int XX = this.pan_show_window.Height;
            int yy = this.pan_show_window.Width;
            delocation.Enabled = false;
            this.updatelocation.Enabled = false;
        }


        object[,] stdYardRecords = null;//得到FP_STDYARD表中区的信息（垛位等信息）
        object[,] stdAreaRecords = null;
        public override void Form_Ref()
        {
            if (!refInputCheck()) return;
            this.pan_show_window.Controls.Clear();
            this.pl.Controls.Clear();
            string sQuery = "SELECT * FROM FP_STDYARD WHERE YARD_KND ='" + txt_yard_knd.Text + "' AND PROD_TYPE = '" + com_prod_type.Text.Trim() + "' AND YARD_TYPE = '" + com_yard_type.Text.Trim() + "' AND ZONE_TYPE = '" + com_zone_type.Text.Trim() + "' ORDER BY YARD_ROW,YARD_COLUMN ";
            stdYardRecords = plSqlReturn(sQuery);
            sQuery = "SELECT * FROM FP_STDAREA WHERE YARD_KND ='" + txt_yard_knd.Text + "' AND PROD_TYPE = '" + com_prod_type.Text.Trim() + "' AND YARD_TYPE = '" + com_yard_type.Text.Trim() + "' AND ZONE_TYPE = '" + com_zone_type.Text.Trim() + "'";
            stdAreaRecords = plSqlReturn(sQuery);
            //if (stdYardRecords == null)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("FP_STDYARD表中没有该区信息...!!", "W", "警告");
            //    return;
            //}
            //if (stdAreaRecords == null)
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("FP_STDAREA表中没有该区信息...!!", "W", "警告");
            //    return;
            //}
            setPanelSize();
            setButtonFlat(stdYardRecords);
            if (base.p_Ref(1, 1, true, false))
            {
                delocation.Enabled = true;
                this.updatelocation.Enabled = true;

                txt_yard_knd.Enabled = false;
                textBox1.Enabled = false;
                com_prod_type.Enabled = false;
                com_yard_type.Enabled = false;
                com_zone_type.Enabled = false;

            }

        }

        /// <summary>
        /// 设定panel的长和宽
        /// </summary>
        Panel pl = new Panel();
        double actLength = 0;
        double actWidth = 0;
        private void setPanelSize()
        {
            actLength = System.Convert.ToDouble(stdAreaRecords[0, 6].ToString());//区的实际长度
            actWidth = System.Convert.ToDouble(stdAreaRecords[0, 5].ToString());//区的实际宽度
            double panelLength = System.Convert.ToDouble(stdAreaRecords[0, 6].ToString());
            double panelWidth = System.Convert.ToDouble(stdAreaRecords[0, 5].ToString());
            int newPanelHeight = System.Convert.ToInt32(this.pan_show_window.Height * panelWidth / 40);
            int newPanelWidth = System.Convert.ToInt32(newPanelHeight * panelLength / panelWidth);


            pl.Width = newPanelWidth;
            pl.Height = newPanelHeight;
            pl.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(170)), System.Convert.ToInt32((byte)(220)), System.Convert.ToInt32((byte)(230)));
            pl.Top = 0;
            pl.Left = 0;
            this.pan_show_window.Controls.Add(pl);
            pl.BorderStyle = BorderStyle.Fixed3D;
            this.pan_show_window.Refresh();


            this.stdzone.Visible = true;
            this.HeiAndWid.Visible = true;
            stdzone.Text = stdAreaRecords[0, 4].ToString() + "的宽*长";
            HeiAndWid.Text = actWidth.ToString() + "*" + actLength.ToString();


        }

        private void setButtonFlat(object[,] stdYardRecords)
        {
            if (stdYardRecords == null) return;//20131010
            int recordCount = stdYardRecords.Length / 14;
            for (int i = 0; i < recordCount; i++)
            {
                Button bt = new Button();
                bt.AutoSize = false;
                bt.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(255)));
                bt.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(95)), System.Convert.ToInt32((byte)(158)), System.Convert.ToInt32((byte)(180)));
                bt.FlatStyle = FlatStyle.Flat;
                bt.Tag = "O";

                //if (stdYardRecords[i, 8].ToString().ToUpper() == "L")
                //{
                //    bt.Top = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 10].ToString()) / actWidth * this.pl.Height))).ToString());
                //    bt.Left = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 9].ToString()) / actLength * this.pl.Width))).ToString());
                //    bt.Height = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 11].ToString()) / actWidth * this.pl.Height))).ToString());
                //    bt.Width = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 12].ToString()) / actLength * this.pl.Width))).ToString());
                //}
                //else
                //{
                //    bt.Top = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 10].ToString()) / actWidth * this.pl.Height))).ToString());
                //    bt.Left = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 9].ToString()) / actLength * this.pl.Width))).ToString());
                //    bt.Height = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 12].ToString()) / actWidth * this.pl.Height))).ToString());
                //    bt.Width = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 11].ToString()) / actLength * this.pl.Width))).ToString());
                //}
                //if (stdYardRecords[i, 8].ToString().ToUpper() == "L")
                if (stdYardRecords[i, 9].ToString().ToUpper() == "L")
                {
                    bt.Top = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 11].ToString()) / actWidth * this.pl.Height))).ToString());
                    bt.Left = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 10].ToString()) / actLength * this.pl.Width))).ToString());
                    bt.Height = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 12].ToString()) / actWidth * this.pl.Height))).ToString());
                    bt.Width = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 13].ToString()) / actLength * this.pl.Width))).ToString());
                }
                else
                {
                    bt.Top = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 11].ToString()) / actWidth * this.pl.Height))).ToString());
                    bt.Left = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 10].ToString()) / actLength * this.pl.Width))).ToString());
                    bt.Height = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 13].ToString()) / actWidth * this.pl.Height))).ToString());
                    bt.Width = int.Parse((Math.Round((double.Parse(stdYardRecords[i, 12].ToString()) / actLength * this.pl.Width))).ToString());
                }


                bt.Text = stdYardRecords[i, 5].ToString();

                bt.TextAlign = ContentAlignment.MiddleCenter;
              
                bt.MouseClick += new MouseEventHandler(bt_MouseClick);

                bt.Visible = true;
                this.pl.Controls.Add(bt);
            
            }
        }




        object[,] recordArray = null;
        private void bt_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.pl.Controls.Count; i++)
            {
                if (this.pl.Controls[i].Tag == "N")
                {
                    this.pl.Controls.Remove(this.pl.Controls[i]);
                    break;
                }
            }

            delocation.Enabled = true;
            this.updatelocation.Enabled = true;

            this.pan_show_window.Refresh();
            this.pl.Refresh();
            Button bt = (Button)sender;
            string btText = bt.Text.Trim();
            txt_location.Text = btText;
            this.txt_yard_row.Text = "";
            this.txt_yard_column.Text = "";
            // this.txt_location.Text = "";
            this.txt_max_cnt.Text = "";
            this.txt_location_type.Text = "";
            this.txt_location_x.Text = "";
            this.txt_location_y.Text = "";
            this.txt_location_wid.Text = "";
            this.txt_location_len.Text = "";
            string sQuery = "select * from FP_STDYARD where LOCATION = '" + btText + "' and YARD_KND = '" + txt_yard_knd.Text + "'";
            recordArray = plSqlReturn(sQuery);
            this.txt_yard_row.Text = recordArray[0, 3].ToString();
            this.txt_yard_column.Text = recordArray[0, 4].ToString();
            //  this.txt_location.Text = recordArray[0, 5].ToString();
            this.txt_max_cnt.Text = recordArray[0, 6].ToString();
            //this.txt_location_type.Text = recordArray[0, 8].ToString();
            //this.txt_location_x.Text = recordArray[0, 9].ToString();
            //this.txt_location_y.Text = recordArray[0, 10].ToString();
            //this.txt_location_wid.Text = recordArray[0, 11].ToString();
            //this.txt_location_len.Text = recordArray[0, 12].ToString();

            this.txt_location_type.Text = recordArray[0, 9].ToString();
            this.txt_location_x.Text = recordArray[0, 10].ToString();
            this.txt_location_y.Text = recordArray[0, 11].ToString();
            this.txt_location_wid.Text = recordArray[0, 12].ToString();
            this.txt_location_len.Text = recordArray[0, 13].ToString();

            for (int i = 0; i < this.pl.Controls.Count;i++ )
            {
                Button tempBt = (Button)this.pl.Controls[i];
                tempBt.Tag = "O";
            }


            BBTT = bt;
            bt.Tag = "update";
            ctrl = bt;
            bt.MouseMove += new MouseEventHandler(lb_MouseMove);
            bt.MouseDown += new MouseEventHandler(lbNew_MouseDown);
            bt.MouseUp += new MouseEventHandler(lb_MouseUp);

        }



        Color color = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(192)));
        /// <summary>
        /// 设定查询条件背景色
        /// </summary>
        private void setControlBackColor()
        {
            txt_yard_knd.BackColor = color;
            com_prod_type.BackColor = color;
            com_yard_type.BackColor = color;
            com_zone_type.BackColor = color;
        }


        private bool refInputCheck()
        {
            bool isCheck = false;
            if (txt_yard_knd.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("库代码不能为空...!!", "W", "警告");
                return isCheck;
            }
            if (com_prod_type.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("库类型不能为空...!!", "W", "警告");
                return isCheck;
            }
            if (com_yard_type.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("跨号不能为空...!!", "W", "警告");
                return isCheck;
            }
            if (com_zone_type.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("区号不能为空...!!", "W", "警告");
                return isCheck;
            }
            isCheck = true;
            return isCheck;
        }


        private void txt_yard_row_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < this.pl.Controls.Count; i++)
            {
                if (this.pl.Controls[i].Tag == "N")
                {
                    this.pl.Controls.Remove(this.pl.Controls[i]);
                    break;
                }
            }
            if (txt_yard_row.Text != "" && txt_yard_column.Text != "" && txt_max_cnt.Text != "" && txt_location_type.Text != "" && txt_location_x.Text != "" && txt_location_y.Text != "" && txt_location_wid.Text != "" && txt_location_len.Text != "")
            {
                if ((double.Parse(txt_location_x.Text) + double.Parse(txt_location_len.Text)) > actLength || (double.Parse(txt_location_y.Text) + double.Parse(txt_location_wid.Text)) > actLength)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("在此坐标上(" + txt_location_x.Text + "," + txt_location_y.Text + ")新增加的垛位超过了该区的长度...!!", "W", "警告");
                    txt_location_wid.Text = "";
                    txt_location_len.Text = "";
                    txt_location_x.Text = "";
                    txt_location_y.Text = "";
                    return;
                }

                Button bt = new Button();
                bt.AutoSize = false;
                bt.ForeColor = Color.Red;
                bt.BackColor = Color.Orange;
                bt.FlatStyle = FlatStyle.Flat;
                bt.Tag = "N";
                bt.AllowDrop = true;
                ctrl = bt;

                bt.MouseMove += new MouseEventHandler(lb_MouseMove);
                bt.MouseDown += new MouseEventHandler(lbNew_MouseDown);
                bt.MouseUp += new MouseEventHandler(lb_MouseUp);

                if (txt_location_type.Text.ToUpper() == "L")
                {
                    bt.Top = int.Parse((Math.Round((double.Parse(txt_location_y.Text) / actWidth * this.pl.Height))).ToString());
                    bt.Left = int.Parse((Math.Round((double.Parse(txt_location_x.Text) / actLength * this.pl.Width))).ToString());
                    bt.Height = int.Parse((Math.Round((double.Parse(txt_location_wid.Text) / actWidth * this.pl.Height))).ToString());
                    bt.Width = int.Parse((Math.Round((double.Parse(txt_location_len.Text) / actLength * this.pl.Width))).ToString());
                }
                else
                {
                    bt.Top = int.Parse((Math.Round((double.Parse(txt_location_y.Text) / actWidth * this.pl.Height))).ToString());
                    bt.Left = int.Parse((Math.Round((double.Parse(txt_location_x.Text) / actLength * this.pl.Width))).ToString());
                    bt.Height = int.Parse((Math.Round((double.Parse(txt_location_len.Text) / actWidth * this.pl.Height))).ToString());
                    bt.Width = int.Parse((Math.Round((double.Parse(txt_location_wid.Text) / actLength * this.pl.Width))).ToString());
                }

                bt.Text = this.com_prod_type.Text.ToUpper() + this.com_yard_type.Text.ToUpper() + this.com_zone_type.Text.ToUpper() + this.txt_yard_row.Text.ToUpper() + this.txt_yard_column.Text.ToUpper();
                bt.TextAlign = ContentAlignment.MiddleCenter;
                bt.Visible = true;
                this.pl.Controls.Add(bt);
                this.delocation.Enabled = false;
                this.updatelocation.Enabled = false;
            }
        }


        bool IsMoving = false;

        Point pCtrlLastCoordinate = new Point(0, 0);

        Point pCursorOffset = new Point(0, 0);

        Point pCursorLastCoordinate = new Point(0, 0);

        private Control ctrl = null;

        private ScrollableControl Containe = null;

        private void lbNew_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.pl == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                IsMoving = true;

                pCtrlLastCoordinate.X = ctrl.Left;
                pCtrlLastCoordinate.Y = ctrl.Top;
                pCursorLastCoordinate.X = Cursor.Position.X;
                pCursorLastCoordinate.Y = Cursor.Position.Y;
            }
        }


        private void lb_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.pl == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                if (this.IsMoving)
                {
                    Point pCursor = new Point(Cursor.Position.X, Cursor.Position.Y);
                    pCursorOffset.X = pCursor.X - pCursorLastCoordinate.X;
                    pCursorOffset.Y = pCursor.Y - pCursorLastCoordinate.Y;
                    ctrl.Left = pCtrlLastCoordinate.X + pCursorOffset.X;
                    ctrl.Top = pCtrlLastCoordinate.Y + pCursorOffset.Y;

                    this.txt_location_y.Text = Math.Round((double.Parse(ctrl.Top.ToString()) / this.pl.Height) * actWidth).ToString();
                    this.txt_location_x.Text = Math.Round((double.Parse(ctrl.Left.ToString()) / this.pl.Width) * actLength).ToString();
                }
            }
        }

        int labelTop = 0;
        int labeoLeft = 0;
        private void lb_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.pl == null)
            {
                return;
            }

            if (this.IsMoving)
            {
                if (pCursorOffset.X == 0 && pCursorOffset.Y == 0)
                {
                    return;
                }

                if ((pCtrlLastCoordinate.X + pCursorOffset.X + ctrl.Width) > 0)
                {
                    ctrl.Left = pCtrlLastCoordinate.X + pCursorOffset.X;
                }

                else
                {
                    ctrl.Left = 0;
                }

                if ((pCtrlLastCoordinate.Y + pCursorOffset.Y + ctrl.Height) > 0)
                {
                    ctrl.Top = pCtrlLastCoordinate.Y + pCursorOffset.Y;
                }

                else
                {
                    ctrl.Top = 0;
                }

                if (ctrl.Left < 0)
                {
                    ctrl.Left = 0;

                }
                if (ctrl.Top < 0)
                {
                    ctrl.Top = 0;
                }
                if (ctrl.Top + ctrl.Height > this.pl.Height)
                {
                    ctrl.Top = this.pl.Height - ctrl.Height;
                }

                if (ctrl.Left + ctrl.Width > this.pl.Width)
                {
                    ctrl.Left = this.pl.Width - ctrl.Width;
                }
                labelTop = ctrl.Top;
                labeoLeft = ctrl.Left;

                this.txt_location_y.Text = Math.Round((double.Parse(ctrl.Top.ToString()) / this.pl.Height) * actWidth).ToString();
                this.txt_location_x.Text = Math.Round((double.Parse(ctrl.Left.ToString()) / this.pl.Width) * actLength).ToString();

                pCursorOffset.X = 0;
                pCursorOffset.Y = 0;
                this.pl.Refresh();
            }
        }


        private void txt_yard_row_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
            if (tb.Text.Length > 1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            if (tb.SelectionLength != 0)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    e.Handled = false;
                }
            }
        }

        private void txt_max_cnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
            if (tb.Text.Length > 2)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            if (tb.SelectionLength != 0)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    e.Handled = false;
                }
            }
        }


        private void txt_location_type_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!(tb.Text == "L" || tb.Text == "W" || tb.Text == ""))
            {
                tb.Text = "";
                this.toolTip1.Active = true;
            }
            else
            {
                this.toolTip1.Active = false;
            }
        }

        public override bool Form_Cls()
        {
            txt_yard_knd.Text = "";
            txt_yard_knd.Enabled = true;
            com_prod_type.Text = "";
            com_prod_type.Enabled = true;
            com_yard_type.Text = "";
            com_zone_type.Text = "";
            textBox1.Text = "";
            ss1.ActiveSheet.Rows.Count = 0;
            pan_show_window.Controls.Clear();
            this.txt_yard_row.Text = "";
            this.txt_yard_column.Text = "";
            this.txt_max_cnt.Text = "";
            this.txt_location_type.Text = "";
            this.txt_location_x.Text = "";
            this.txt_location_y.Text = "";
            this.txt_location_wid.Text = "";
            this.txt_location_len.Text = "";
            delocation.Enabled = false;
            this.updatelocation.Enabled = false;


            this.stdzone.Visible = false;
            this.HeiAndWid.Visible = false;
            stdzone.Text = "";
            HeiAndWid.Text = "";



            return true;
        }

        private void txt_location_type_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_location_type.Text == "")
            {
                this.toolTip1.Show("请输入L或者W", txt_location_type);
            }
        }



        private void addlocation_Click(object sender, EventArgs e)
        {
            if (txt_yard_row.Text.Length != 2 || txt_yard_column.Text.Length != 2)
            {
                GeneralCommon.Gp_MsgBoxDisplay("行号或者列号必须为两位...!", "W", "警告");
                return;
            }

            if (this.pan_show_window.Controls.Count == 0)
            {
                GeneralCommon.Gp_MsgBoxDisplay("必须先查询,才可进行添加垛位的操作...!", "W", "警告");
                return;
            }
            bool isHaveNewBt = false;
            Button bt = null;
            for (int i = 0; i < this.pl.Controls.Count; i++)
            {
                if (this.pl.Controls[i].Tag == "N")
                {
                    isHaveNewBt = true;
                    bt = (Button)(this.pl.Controls[i]);
                    break;
                }
            }
            if (!isHaveNewBt)
            {
                GeneralCommon.Gp_MsgBoxDisplay("你没有添加新垛位，请先输入新垛位的参数...!", "W", "警告");
                Form_Ref();
                return;
            }
            else
            {
                if (IsTouch(bt))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("你添加的新垛位与现有垛位存在交叉，请重新输入新垛位的参数...!", "W", "警告");
                    return;
                }
            }

            //string newInformationYard = "";

            string locationNew = this.com_prod_type.Text.ToUpper() + this.com_yard_type.Text.ToUpper() + this.com_zone_type.Text.ToUpper() + this.txt_yard_row.Text.ToUpper() + this.txt_yard_column.Text.ToUpper();
            ////newInformationYard = " INSERT INTO FP_STDYARD (PROD_TYPE,YARD_TYPE,ZONE_TYPE,";
            ////newInformationYard += "YARD_ROW,YARD_COLUMN,LOCATION,MAX_CNT,YARD_KND,";
            ////newInformationYard += "LOCATION_TYPE,LOCATION_X,LOCATION_Y,LOCATION_WID,LOCATION_LEN)";
            ////newInformationYard += "VALUES(";
            ////newInformationYard += " '" + this.com_prod_type.Text + "'," + "'" + this.com_yard_type.Text + "',";
            ////newInformationYard += " '" + this.com_zone_type.Text + "'," + "'" + this.txt_yard_row.Text + "',";
            ////newInformationYard += " '" + this.txt_yard_column.Text + "'," + "'" + locationNew + "',";
            ////newInformationYard += " '" + this.txt_max_cnt.Text + "'," + "'" + this.txt_yard_knd.Text + "',";
            ////newInformationYard += " '" + this.txt_location_type.Text + "'," + "'" + this.txt_location_x.Text + "',";
            ////newInformationYard += " '" + this.txt_location_y.Text + "'," + "'" + this.txt_location_wid.Text + "',";
            ////newInformationYard += " '" + this.txt_location_len.Text + "')";


            //string YARD_AREANEW = com_yard_type.Text.Trim() + com_zone_type.Text.Trim();
            //string locationNew = this.com_prod_type.Text.ToUpper() + this.com_yard_type.Text.ToUpper() + this.com_zone_type.Text.ToUpper() + this.txt_yard_row.Text.ToUpper() + this.txt_yard_column.Text.ToUpper();
            //newInformationYard = " INSERT INTO FP_STDYARD (PROD_TYPE,YARD_TYPE,ZONE_TYPE,";
            //newInformationYard += "YARD_ROW,YARD_COLUMN,LOCATION,MAX_CNT,YARD_KND,";
            //newInformationYard += "LOCATION_TYPE,LOCATION_X,LOCATION_Y,LOCATION_WID,LOCATION_LEN,YARD_AREA)";
            //newInformationYard += "VALUES(";
            //newInformationYard += " '" + this.com_prod_type.Text + "'," + "'" + this.com_yard_type.Text + "',";
            //newInformationYard += " '" + this.com_zone_type.Text + "'," + "'" + this.txt_yard_row.Text + "',";
            //newInformationYard += " '" + this.txt_yard_column.Text + "'," + "'" + locationNew + "',";
            //newInformationYard += " '" + this.txt_max_cnt.Text + "'," + "'" + this.txt_yard_knd.Text + "',";
            //newInformationYard += " '" + this.txt_location_type.Text + "'," + "'" + this.txt_location_x.Text + "',";
            //newInformationYard += " '" + this.txt_location_y.Text + "'," + "'" + this.txt_location_wid.Text + "',";
            //newInformationYard += " '" + this.txt_location_len.Text +"' , '"+ YARD_AREANEW + "')";


            //if (processInsOrDel(newInformationYard, "新增垛位失败...!!"))
            //{
            //    GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + locationNew + "新增成功!";
            //    afterSuccessDelOrInsOrCls();
            //    Form_Ref();
            //}

            string YARD_AREANEW = com_yard_type.Text.Trim() + com_zone_type.Text.Trim();
            object[] inputPlSqlTestInsert = new object[15];
            inputPlSqlTestInsert[0] = "I";
            inputPlSqlTestInsert[1] = com_prod_type.Text.Trim();
            inputPlSqlTestInsert[2] = com_yard_type.Text.Trim();
            inputPlSqlTestInsert[3] = com_zone_type.Text.Trim();
            inputPlSqlTestInsert[4] = txt_yard_row.Text.Trim();
            inputPlSqlTestInsert[5] = txt_yard_column.Text.Trim();
            inputPlSqlTestInsert[6] = txt_max_cnt.Text.Trim();
            inputPlSqlTestInsert[7] = GeneralCommon.sUserID;
            inputPlSqlTestInsert[8] = txt_yard_knd.Text.Trim();
            inputPlSqlTestInsert[9] = YARD_AREANEW;
            inputPlSqlTestInsert[10] = txt_location_type.Text;
            inputPlSqlTestInsert[11] = txt_location_x.Text;
            inputPlSqlTestInsert[12] = txt_location_y.Text;
            inputPlSqlTestInsert[13] = txt_location_wid.Text;
            inputPlSqlTestInsert[14] = txt_location_len.Text;

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WGE4040P", inputPlSqlTestInsert))
            {
                GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + locationNew + "新增成功!";
                afterSuccessDelOrInsOrCls();
                Form_Ref();
            }
           


        }


        private bool IsTouch(Control c)
        {
            foreach (Control con in this.pl.Controls)
            {
                if (con.Tag != "N")
                {
                    if (c.Right >= con.Left && c.Left <= con.Right && c.Bottom >= con.Top && c.Top <= con.Bottom)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        object[,] recordArrayDetail = null;
        private void delocation_Click(object sender, EventArgs e)
        {
            if (txt_location.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("删除前请选定你要删除的垛位...!!", "W", "警告");
                return;
            }
            recordArrayDetail = null;
            string sqlDetail = "SELECT A.BED_SEQ,'',A.PLATE_NO,A.YARD_ADDR,B.STLGRD,GF_STLGRD_DETAIL(B.STLGRD), B.THK,B.WID,B.LEN,B.WGT,B.PROD_GRD,SUBSTR(B.BED_PILE_DATE,5,8),";
            sqlDetail += " B.ORD_NO || B.ORD_ITEM, B.SHP_DATE,B.SHP_TIME,'','' ";
            sqlDetail += " FROM NISCO.GP_PLATEYARD A,NISCO.GP_PLATE B ";
            sqlDetail += " WHERE A.YARD_ADDR = '" + txt_location.Text + "'";
            //sqlDetail += " WHERE A.YARD_ADDR = 'P3C0208'";

            sqlDetail += " AND A.PLATE_NO = B.PLATE_NO ";
            sqlDetail += " AND B.PROD_CD  = 'PP'";
            sqlDetail += " AND B.PLT      = 'C2'";
            sqlDetail += " ORDER BY A.BED_SEQ";
            recordArrayDetail = plSqlReturn(sqlDetail);
            if (recordArrayDetail == null)
            {
                if (GeneralCommon.Gf_MessConfirm("垛位号:" + txt_location.Text + "没有板坯信息" + Environment.NewLine + "可以删除,是否删除?", "I", "提示"))
                {
                    //string sqlDelete = "DELETE FROM FP_STDYARD WHERE LOCATION = '" + txt_location.Text + "' AND YARD_KND='" + txt_yard_knd.Text + "'";

                    //if (processInsOrDel(sqlDelete, "删除垛位失败...!!"))
                    //{
                    //    GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + txt_location.Text + "删除成功!";
                    //    afterSuccessDelOrInsOrCls();
                    //    Form_Ref();
                    //}
                    string YARD_AREANEW = com_yard_type.Text.Trim() + com_zone_type.Text.Trim();
                    object[] inputPlSqlTestInsert = new object[15];
                    inputPlSqlTestInsert[0] = "D";
                    inputPlSqlTestInsert[1] = com_prod_type.Text.Trim();
                    inputPlSqlTestInsert[2] = com_yard_type.Text.Trim();
                    inputPlSqlTestInsert[3] = com_zone_type.Text.Trim();
                    inputPlSqlTestInsert[4] = txt_yard_row.Text.Trim();
                    inputPlSqlTestInsert[5] = txt_yard_column.Text.Trim();
                    inputPlSqlTestInsert[6] = txt_max_cnt.Text.Trim();
                    inputPlSqlTestInsert[7] = GeneralCommon.sUserID;
                    inputPlSqlTestInsert[8] = txt_yard_knd.Text.Trim();
                    inputPlSqlTestInsert[9] = YARD_AREANEW;
                    inputPlSqlTestInsert[10] = txt_location_type.Text;
                    inputPlSqlTestInsert[11] = txt_location_x.Text;
                    inputPlSqlTestInsert[12] = txt_location_y.Text;
                    inputPlSqlTestInsert[13] = txt_location_wid.Text;
                    inputPlSqlTestInsert[14] = txt_location_len.Text;

                    if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WGE4040P", inputPlSqlTestInsert))
                    {
                        GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + txt_location.Text + "删除成功!";
                        afterSuccessDelOrInsOrCls();
                        Form_Ref();
                    }
                }
            }
            else
            {
                GeneralCommon.Gp_MsgBoxDisplay("该垛位上存在钢板信息,不可删除...!!", "W", "警告");
                return;
            }
        }

        private void afterSuccessDelOrInsOrCls()
        {
            txt_location.Text = "";
            this.txt_yard_row.Text = "";
            this.txt_yard_column.Text = "";
            this.txt_max_cnt.Text = "";
            this.txt_location_type.Text = "";
            this.txt_location_x.Text = "";
            this.txt_location_y.Text = "";
            this.txt_location_wid.Text = "";
            this.txt_location_len.Text = "";
        }

        private bool processInsOrDel(string sqlOuery, string information)
        {
            bool isSucess = false;
            try
            {
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                if (GeneralCommon.M_CN1.State == 0)
                    if (GeneralCommon.GF_DbConnect() == false) return isSucess;
                AdoRs.Open(sqlOuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                isSucess = true;
                return isSucess;
            }
            catch (Exception ex)
            {
                GeneralCommon.Gp_MsgBoxDisplay(information + Environment.NewLine + ex.Message, "W", "警告");
                return isSucess;
            }
        }

        private void txt_yard_knd_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
            {
                string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
                this.com_yard_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_yard_type, sql);
            }
        }

        private void com_prod_type_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
            {
                string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
                this.com_yard_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_yard_type, sql);
            }
        }

        private void com_yard_type_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "" && this.com_yard_type.Text != "")
            {
                string sql = "SELECT DISTINCT ZONE_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "' AND YARD_TYPE='" + com_yard_type.Text.Trim() + "'";
                this.com_zone_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_zone_type, sql);
            }
        }

        private object[,] plSqlReturn(string sQuery)
        {
            object[,] ArrayRecords = null;
            int RsRowCount = 0;
            int RsColCount = 0;
            ADODB.Recordset AdoRs;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return null;
                    }
                }
                AdoRs = new ADODB.Recordset();
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (AdoRs.BOF || AdoRs.EOF)
                {
                    // GeneralCommon.Gp_MsgBoxDisplay("没有数据...!", "I", "提示");
                    AdoRs.Close();
                    AdoRs = null;
                    if (GeneralCommon.M_CN1.State != 0)
                    {
                        GeneralCommon.M_CN1.Close();
                    }
                    Cursor.Current = Cursors.Default;
                    return null;
                }
                RsRowCount = AdoRs.RecordCount;
                RsColCount = AdoRs.Fields.Count;
                ArrayRecords = new object[RsRowCount, RsColCount];
                int i = 0;
                while (!AdoRs.EOF)
                {
                    for (int j = 0; j < AdoRs.Fields.Count; j++)
                    {
                        ArrayRecords[i, j] = AdoRs.Fields[j].Value;
                    }
                    i++;
                    AdoRs.MoveNext();
                }
                AdoRs.Close();
                AdoRs = null;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return ArrayRecords;
            }
            catch (Exception ex)
            {
                AdoRs = null;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return null;
            }
        }

        private void updatelocation_Click(object sender, EventArgs e)
        {
            Boolean isHaveNewBt = false;

           
            for (int i = 0; i < this.pl.Controls.Count; i++)
            {
                if (this.pl.Controls[i].Tag == "N")
                {
                    isHaveNewBt = true;
                    break;
                }
            }

            if (!this.checkBox1.Checked)//20131227
            {
                if (isHaveNewBt)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("页面上存在将要新增加的垛位,此时不可进行修改垛位的操作...!!", "W", "警告");
                    return;
                }
                else
                {
                    if (IsTouchUpdate(BBTT))
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("你修改的垛位与现有垛位存在交叉，请重新拖动该垛位...!", "W", "警告");
                        Form_Ref();
                        return;
                    }
                }
            }//20131227




            //string newUpdateformationYard = "";

            string locationNew = this.com_prod_type.Text.ToUpper() + this.com_yard_type.Text.ToUpper() + this.com_zone_type.Text.ToUpper() + this.txt_yard_row.Text.ToUpper() + this.txt_yard_column.Text.ToUpper();
            //newUpdateformationYard = " UPDATE FP_STDYARD SET LOCATION_X = " + txt_location_x.Text + ",LOCATION_Y =" + txt_location_y.Text;
            //newUpdateformationYard += "WHERE PROD_TYPE = '" + com_prod_type.Text + "'AND";
            //newUpdateformationYard += " YARD_TYPE = '" + com_yard_type.Text + "'AND";
            //newUpdateformationYard += " ZONE_TYPE = '" + com_zone_type.Text + "'AND";
            //newUpdateformationYard += " YARD_ROW = " + txt_yard_row.Text + "AND";
            //newUpdateformationYard += " YARD_COLUMN = " + txt_yard_column.Text + "AND";
            //newUpdateformationYard += " YARD_KND = '" + txt_yard_knd.Text+"'";
          


            //if (processInsOrDel(newUpdateformationYard, "修改垛位失败...!!"))
            //{
            //    GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + locationNew + "修改成功!";
            //    afterSuccessDelOrInsOrCls();
            //    Form_Ref();
            //}

            string YARD_AREANEW = com_yard_type.Text.Trim() + com_zone_type.Text.Trim();
            object[] inputPlSqlTestInsert = new object[15];
            inputPlSqlTestInsert[0] = "U";
            inputPlSqlTestInsert[1] = com_prod_type.Text.Trim();
            inputPlSqlTestInsert[2] = com_yard_type.Text.Trim();
            inputPlSqlTestInsert[3] = com_zone_type.Text.Trim();
            inputPlSqlTestInsert[4] = txt_yard_row.Text.Trim();
            inputPlSqlTestInsert[5] = txt_yard_column.Text.Trim();
            inputPlSqlTestInsert[6] = txt_max_cnt.Text.Trim();
            inputPlSqlTestInsert[7] = GeneralCommon.sUserID;
            inputPlSqlTestInsert[8] = txt_yard_knd.Text.Trim();
            inputPlSqlTestInsert[9] = YARD_AREANEW;
            inputPlSqlTestInsert[10] = txt_location_type.Text;
            inputPlSqlTestInsert[11] = txt_location_x.Text;
            inputPlSqlTestInsert[12] = txt_location_y.Text;
            inputPlSqlTestInsert[13] = txt_location_wid.Text;
            inputPlSqlTestInsert[14] = txt_location_len.Text;

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WGE4040P", inputPlSqlTestInsert))
            {
                GeneralCommon.GStatusBar.Panels[0].Text = "垛位号：" + locationNew + "修改成功!";
                afterSuccessDelOrInsOrCls();
                Form_Ref();
            }
        }



        private bool IsTouchUpdate(Control c)
        {
            foreach (Control con in this.pl.Controls)
            {
                if (con.Tag != "update")
                {
                    if (c.Right >= con.Left && c.Left <= con.Right && c.Bottom >= con.Top && c.Top <= con.Bottom)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) this.updatelocation.Enabled = true;
            else this.updatelocation.Enabled = false;
        }





    }
}
