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
    public partial class WGE4030C : CommonClass.FORMBASE
    {
        public WGE4030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        TextBox yard = new TextBox();//查询条件
        protected override void p_SubFormInit()
        {
            int imcseq;
            imcseq = 1;
            p_McIni(Mc1, false);
            p_SetMc("库类型", yard, "P", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, true);
            int iheadrow;
            iheadrow = 0;
            int iscseq;
            iscseq = 1;

            p_SetSc("垛层", "E", "", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("钢板号", "E", "", "L", "", "", "", iscseq, iheadrow);//1            
            p_SetSc("钢种名称", "E", "", "L", "", "", "", iscseq, iheadrow);//2
            p_SetSc("产品代码", "E", "", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("订单号||订单序列号", "E", "", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("发货日期", "DT", "", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("标准号", "E", "", "LA", "", "", "", iscseq, iheadrow);//6
            p_SetSc("客户代码", "E", "", "LA", "", "", "", iscseq, iheadrow);//7
        }

        private void WGE40100C_Load(object sender, EventArgs e)
        {
            Form_Define();
            setControlBackColor();
            com_yard_type.Enabled = false;
            com_zone_type.Enabled = false;

            this.pan_show_window.VerticalScroll.Visible = true;
            this.pan_show_window.HorizontalScroll.Visible = true;
            int xx = this.pan_show_window.Width;
            int yy = this.pan_show_window.Height;          

           
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
            
        }

        private void setButtonFlat(object[,] stdYardRecords)
        {
            if (stdYardRecords == null) return;//20131010
            if (stdYardRecords == null) return;
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
              
                //bt.MouseClick += new MouseEventHandler(bt_MouseClick);
                bt.MouseClick += new MouseEventHandler(bt_MouseClick);
                bt.Visible = true;
                this.pl.Controls.Add(bt);
                ////////////////////////////////////////////////////////////
            }
        }

        object[,] yardDetailData = null;
        private void bt_MouseClick(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            yard.Text = bt.Text;
            //yard.Text = "P3C0211";
            p_Ref(1, 1, true, false);

            string sqlYardDetail = "SELECT A.BED_SEQ,A.PLATE_NO,A.YARD_ADDR, B.STLGRD, B.THK, B.WID, B.LEN, B.WGT, B.PROD_GRD, B.ORD_NO || B.ORD_ITEM, B.SHP_DATE, B.SHP_TIME, B.APLY_STDSPEC, B.CUST_CD FROM NISCO.GP_PLATEYARD A, NISCO.GP_PLATE B WHERE A.YARD_ADDR = '" + yard.Text + "' AND A.PLATE_NO = B.PLATE_NO AND B.PROD_CD = 'PP' AND B.PLT = 'C2' ORDER BY A.BED_SEQ";
            yardDetailData = plSqlReturn(sqlYardDetail);
            if (yardDetailData != null)
            {
                setDetailGri();
            }
        }

        public override bool Form_Cls()
        {
            if (base.Form_Cls())
            {
                ss1_Sheet1.Rows.Count = 0;
                this.pan_show_window.Controls.Clear();
                setClearControl();
                return true;
            }
            return false;
        }


        private void setDetailGri()
        {
            if (yardDetailData == null)
            {
                return;
            }
            this.panel1.Controls.Clear();
            double temp = 0;//最大长度
            int countSlab = 0;//垛位号中板坯块数。
            countSlab = yardDetailData.Length / 14;
            int lineSpLength2 = 0;
            int lineSpLength1 = 0;
            for (int i = 0; i < countSlab; i++)
            {
                if (temp < double.Parse(yardDetailData[i, 6].ToString()))
                {
                    temp = double.Parse(yardDetailData[i, 6].ToString());
                }
            }

            ///////////////////////////
            ShapeContainer canvas = new ShapeContainer();
            canvas.Parent = this.panel1;
            LineShape lineShape1 = new LineShape();
            LineShape lineShape2 = new LineShape();


            lineShape1.Parent = canvas;
            lineShape2.Parent = canvas;

            lineShape1.StartPoint = new System.Drawing.Point(16, this.panel1.Height - 16);
            lineShape1.EndPoint = new System.Drawing.Point(this.panel1.Width - 16, this.panel1.Height - 16);
            lineShape1.BorderColor = Color.DarkRed;
            lineShape1.Tag = "LINE";
            lineShape1.Visible = true;


            lineShape2.StartPoint = new System.Drawing.Point(16, this.panel1.Height - 16);
            lineShape2.EndPoint = new System.Drawing.Point(16, 16);
            lineShape2.BorderColor = Color.DarkRed;
            lineShape2.Tag = "LINE";
            lineShape2.Visible = true;
            ///////////////////////////

            lineSpLength2 = lineShape2.Y1 - lineShape2.Y2;
            lineSpLength1 = lineShape1.X2 - lineShape1.X1;

            int lbLocation_X = lineShape1.X2 - 25;
            int lbLocation_Y = lineShape1.Y2 + 1;

            Label lb = new Label();
            lb.Width = 50;
            lb.Height = 16;
            lb.BorderStyle = BorderStyle.None;
            lb.Tag = "NNN";
            lb.Text = temp.ToString();
            lb.Location = new Point(lbLocation_X, lbLocation_Y);
            lb.Visible = true;
            this.panel1.Controls.Add(lb);

            int middlelbLocation_X = lineShape1.X2 / 2 + 4;
            int middlelbLocation_Y = lineShape1.Y2 + 1;

            Label lbMiddle = new Label();
            lbMiddle.Width = 50;
            lbMiddle.Height = 16;
            lbMiddle.BorderStyle = BorderStyle.None;
            lbMiddle.Tag = "NNN";
            lbMiddle.Text = (temp / 2).ToString();
            lbMiddle.Location = new Point(middlelbLocation_X, middlelbLocation_Y);
            lbMiddle.Visible = true;
            this.panel1.Controls.Add(lbMiddle);

            int serSize = 0;
            serSize = int.Parse(lineSpLength2.ToString()) / countSlab;

            for (int i = 0; i < countSlab; i++)
            {
                Label lbN = new Label();
                lbN.Top = this.panel1.Height - 16 - serSize * (i + 1);
                lbN.Left = 16;
                lbN.Height = serSize;
                lbN.Width = System.Convert.ToInt32((double.Parse(yardDetailData[i, 6].ToString()) / temp) * lineSpLength1);
                lbN.Tag = "N";

                lbN.BorderStyle = BorderStyle.FixedSingle;

                if (i % 2 == 0)
                {
                    lbN.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(95)), System.Convert.ToInt32((byte)(158)), System.Convert.ToInt32((byte)(180)));
                }
                else
                {
                    lbN.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(170)), System.Convert.ToInt32((byte)(220)), System.Convert.ToInt32((byte)(230)));
                }
                lbN.Visible = true;
                this.panel1.Controls.Add(lbN);


                Label lbNN = new Label();
                lbNN.Top = lbN.Top;
                lbNN.Left = 0;
                lbNN.Height = lbN.Height;
                lbNN.Width = lbN.Width;
                lbNN.Tag = "NN";

                if (i == 0 || (i + 1) % 10 == 0 || i == countSlab - 1)
                {
                    lbNN.Text = (i + 1).ToString();
                    lbNN.Visible = true;
                }
                else
                {
                    lbNN.Visible = false;
                }
                this.panel1.Controls.Add(lbNN);
            }
        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            setDetailGri();
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

        private void setClearControl()
        {
            txt_yard_knd.Text = "";
            com_prod_type.Text = "";
            com_yard_type.Text = "";
            com_zone_type.Text = "";
        }
        /// <summary>
        /// 查询之前，验证查询条件是否为空
        /// </summary>
        /// <returns></returns>
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

        //private void txt_yard_knd_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
        //    {
        //        string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDYARD WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
        //        this.com_yard_type.Enabled = true;
        //        GeneralCommon.Gf_ComboAdd(com_yard_type, sql);
        //    }
        //}


        //private void com_prod_type_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
        //    {
        //        string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDYARD WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
        //        this.com_yard_type.Enabled = true;
        //        GeneralCommon.Gf_ComboAdd(com_yard_type, sql);
        //    }
        //}

        //private void com_yard_type_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "" && this.com_yard_type.Text != "")
        //    {
        //        string sql = "SELECT DISTINCT ZONE_TYPE FROM FP_STDYARD WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "' AND YARD_TYPE='" + com_yard_type.Text.Trim() + "'";
        //        this.com_zone_type.Enabled = true;
        //        GeneralCommon.Gf_ComboAdd(com_zone_type, sql);
        //    }
        //}

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





    }
}
