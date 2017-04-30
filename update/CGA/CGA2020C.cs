using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using Microsoft.VisualBasic;

namespace CG
{
    public partial class CGA2020C : CommonClass.FORMBASE
    {
        public CGA2020C()
        {
            InitializeComponent();
        }
        int rib_prev;
        string opt_prev;
        Color nColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(192)));
        Color insColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(105)), System.Convert.ToInt32((byte)(155)), System.Convert.ToInt32((byte)(192)));
        Color tColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(155)), System.Convert.ToInt32((byte)(192)));
        private void CGA2020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2020C";
            Form_Define();
            setButtonBackColor();
            rib_prev = 1;
            opt_prev = "B";
            opt_area1.Enabled = true;
            //opt_area1.ForeColor = Color.Red;
            this.ss1_Sheet1.RowHeader.Visible = false;
            this.ss1_Sheet1.ColumnHeader.Visible = false;
            this.ss1_Sheet1.RowCount = 0;
            this.ss1_Sheet1.ColumnCount = 0;


            button5.Enabled = true;
            rib_area1.Enabled = true;
            rib_area2.Enabled = true;
            rib_area3.Enabled = true;
            rib_area4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            opt_area1.Checked = true;
        }

        public override bool Form_Cls()
        {
            sdb_slab_cnt.Text = "";
            //return base.Form_Cls();
            setButtonBackColor();
            rib_area1.BackColor = tColor;
            rib_area2.BackColor = nColor;
            rib_area3.BackColor = nColor;
            rib_area4.BackColor = nColor;
            rib_prev = 1;
            opt_prev = "B";
            opt_area1.Checked = true;

            this.ss1_Sheet1.RowHeader.Visible = false;
            this.ss1_Sheet1.ColumnHeader.Visible = false;
            this.ss1_Sheet1.RowCount = 0;
            this.ss1_Sheet1.ColumnCount = 0;
            return false;
        }

        private void setButtonBackColor()
        {
            button5.BackColor = insColor;
            button6.BackColor = insColor;
            button7.BackColor = insColor;
            rib_area1.BackColor = tColor;
            rib_area2.BackColor = nColor;
            rib_area3.BackColor = nColor;
            rib_area4.BackColor = nColor;
        }

        private void rib_area1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "1库")
            {
                rib_area1.BackColor = tColor;
                rib_area2.BackColor = nColor;
                rib_area3.BackColor = nColor;
                rib_area4.BackColor = nColor;
                rib_prev = 1;
                opt_prev = "B";
                opt_area1.Checked = true;
            }
            else if (bt.Text == "2库")
            {
                rib_area1.BackColor = nColor;
                rib_area2.BackColor = tColor;
                rib_area3.BackColor = nColor;
                rib_area4.BackColor = nColor;
                rib_prev = 2;
                opt_prev = "C";
                opt_area2.Checked = true;
            }
            else if (bt.Text == "3库")
            {
                rib_area1.BackColor = nColor;
                rib_area2.BackColor = nColor;
                rib_area3.BackColor = tColor;
                rib_area4.BackColor = nColor;
                rib_prev = 3;
                opt_prev = "D";
                opt_area3.Checked = true;
            }
            else
            {
                rib_area1.BackColor = nColor;
                rib_area2.BackColor = nColor;
                rib_area3.BackColor = nColor;
                rib_area4.BackColor = tColor;
                rib_prev = 4;
                opt_prev = "J";
                opt_area4.Checked = true;

            }
            this.ss1_Sheet1.RowCount = 0;
            sdb_slab_cnt.Text = "";
        }

        private void opt_area1_Click(object sender, EventArgs e)
        {
            RadioButton RB = (RadioButton)sender;
            opt_prev = RB.Text;
        }

        public override void Form_Ref()
        {
            this.ss1_Sheet1.RowCount = 0;
            this.ss1_Sheet1.ColumnCount = 0;
        
            //base.Form_Ref();
            this.ss1_Sheet1.RowCount = 2*(int)GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT MAX(YARD_ROW) FROM FP_STDYARD  WHERE PROD_TYPE = 'S' AND YARD_TYPE = '" + rib_prev + "' AND ZONE_TYPE = '" + opt_prev + "' AND YARD_KND = 'ZB' ");
            this.ss1_Sheet1.ColumnCount = (int)GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT MAX(YARD_COLUMN) FROM FP_STDYARD  WHERE PROD_TYPE = 'S' AND YARD_TYPE = '" + rib_prev + "' AND ZONE_TYPE = '" + opt_prev + "' AND YARD_KND = 'ZB' ");
            setSpreadColumnAndRow();
            if (!Addr_Display()) return;
            if (Only_Display())
            {

                sdb_slab_cnt.Text = GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, "SELECT COUNT(*) FROM FP_SLABYARD WHERE SUBSTR(YARD_ADDR,2,2) = '" + rib_prev + opt_prev + "' AND NVL(SLAB_NO,' ') <> ' ' AND YARD_KND = 'ZB'").ToString();
            }
            else
            {
                sdb_slab_cnt.Text = "0";
            }
        }

        private void setSpreadColumnAndRow()
        {
            for (int i = 0; i < this.ss1_Sheet1.RowCount;i++ )
            {
                this.ss1_Sheet1.Rows.Get(i).Height = 28;
                this.ss1_Sheet1.Rows.Get(i).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                this.ss1_Sheet1.Rows.Get(i).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                this.ss1_Sheet1.Rows.Get(i).Locked = true;
                if (i % 2 == 1)
                {
                    this.ss1_Sheet1.Rows.Get(i).BackColor = nColor;//System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(155)), System.Convert.ToInt32((byte)(155)), System.Convert.ToInt32((byte)(255)));
                }
            }
            for (int i = 0; i < this.ss1_Sheet1.ColumnCount; i++)
            {
                this.ss1_Sheet1.Columns.Get(i).Width = 100;
            }
        }

        private bool Addr_Display()
        {  
            bool isHaveData = false;

            if (GeneralCommon.M_CN1.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return isHaveData;
                }
            }
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                string sQuery1 = " SELECT LOCATION FROM FP_STDYARD  WHERE PROD_TYPE = 'S' AND YARD_TYPE = '" + rib_prev + "' AND ZONE_TYPE = '" + opt_prev + "' AND YARD_KND = 'ZB' ";
                AdoRs.Open(sQuery1, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (AdoRs.EOF || AdoRs.BOF)
                {
                    AdoRs.Close();
                    GeneralCommon.M_CN1.Close();
                    this.ss1_Sheet1.RowCount = 0;
                    this.ss1_Sheet1.ColumnCount = 0;
                    return isHaveData;
                }
                while (!AdoRs.EOF)
                {
                    string temp = AdoRs.Fields[0].Value.ToString();
                    int rowIndex = int.Parse(temp.Substring(3,2));
                    int columnIndex = int.Parse(temp.Substring(5, 2));
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 2, columnIndex - 1].Text = temp;
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 2, columnIndex - 1].Tag = temp;
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 1, columnIndex - 1].Tag = temp;
                    AdoRs.MoveNext();
                }
                isHaveData = true;
                AdoRs.Close();
                AdoRs = null;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
            catch (Exception ex)
            {
                AdoRs.Close();
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay("数据错误，请检查是否有异常数据...!!" + ex.Message, "W", "警告");
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
        }

        private bool Only_Display()
        {
            string sQuery2 = "";
            sQuery2 = "         SELECT C.ADDR, '('||C.CNT||')', D.LEN, D.WID, D.ORD_NO  ";
            sQuery2 = sQuery2 + "  FROM (SELECT YARD_ADDR ADDR, COUNT(*) CNT  ";
            sQuery2 = sQuery2 + "          FROM FP_SLABYARD  ";
            sQuery2 = sQuery2 + "         WHERE NVL(SLAB_NO,' ') <> ' '  ";
            sQuery2 = sQuery2 + "           AND SUBSTR(YARD_ADDR,2,2) = '" + rib_prev + opt_prev + "'AND YARD_KND = 'ZB'  ";
            sQuery2 = sQuery2 + "         GROUP BY YARD_ADDR) C,  ";
            sQuery2 = sQuery2 + "        (SELECT A.LEN LEN, A.WID WID, B.YARD_ADDR ADDR, A.ORD_NO ORD_NO ";
            sQuery2 = sQuery2 + "           FROM FP_SLAB A, FP_SLABYARD B  ";
            sQuery2 = sQuery2 + "          WHERE A.SLAB_NO IN  ";
            sQuery2 = sQuery2 + "                         (SELECT SLAB_NO  FROM FP_SLABYARD  ";
            sQuery2 = sQuery2 + "                           WHERE YARD_ADDR||BED_SEQ IN  ";
            sQuery2 = sQuery2 + "                                                   (SELECT YARD_ADDR||MAX(BED_SEQ)  ";
            sQuery2 = sQuery2 + "                                                      FROM FP_SLABYARD  ";
            sQuery2 = sQuery2 + "                                                     WHERE NVL(SLAB_NO,' ') <> ' '  ";
            sQuery2 = sQuery2 + "                                                       AND SUBSTR(YARD_ADDR,2,2) = '" + rib_prev + opt_prev + "' AND YARD_KND = 'ZB' ";
            sQuery2 = sQuery2 + "                                                     GROUP BY YARD_ADDR ))  ";
            sQuery2 = sQuery2 + "            AND A.SLAB_NO = B.SLAB_NO) D  ";
            sQuery2 = sQuery2 + " WHERE C.ADDR = D.ADDR  ";
            sQuery2 = sQuery2 + " ORDER BY C.ADDR  ";

            bool isHaveData = false;

            if (GeneralCommon.M_CN1.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return isHaveData;
                }
            }
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery2, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (AdoRs.EOF || AdoRs.BOF)
                {
                    AdoRs.Close();
                    GeneralCommon.M_CN1.Close();
                    //this.ss1_Sheet1.RowCount = 0;
                    //this.ss1_Sheet1.ColumnCount = 0;
                    return isHaveData;
                }
                while (!AdoRs.EOF)
                {
                    string temp = AdoRs.Fields[0].Value.ToString();
                    int rowIndex = int.Parse(temp.Substring(3, 2));
                    int columnIndex = int.Parse(temp.Substring(5, 2));
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 2, columnIndex - 1].Text = "";
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 2, columnIndex - 1].Text = temp + AdoRs.Fields[1].Value.ToString();
                    this.ss1_Sheet1.Cells[rowIndex * 2 - 1, columnIndex - 1].Text = (int)double.Parse(AdoRs.Fields[2].Value.ToString()) + " X " + (int)double.Parse(AdoRs.Fields[3].Value.ToString());

                    AdoRs.MoveNext();
                }
                isHaveData = true;
                AdoRs.Close();
                AdoRs = null;

                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
            catch (Exception ex)
            {
                AdoRs.Close();
                AdoRs = null;
                GeneralCommon.Gp_MsgBoxDisplay("数据错误，请检查是否有异常数据...!!" + ex.Message, "W", "警告");
                Cursor.Current = Cursors.Default;
                if (GeneralCommon.M_CN1.State != 0)
                {
                    GeneralCommon.M_CN1.Close();
                }
                return isHaveData;
            }
        }

        private void ss1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            Gf_IsFormLoad("CGA2010C");
            CGA2010C CGA2010C = new CGA2010C();
            CGA2010C.MdiParent = GeneralCommon.MDIMain;
            CGA2010C.Show();
            CGA2010C.txt_f_addr.Text = this.ss1_Sheet1.Cells[e.Row, e.Column].Tag.ToString();
            CGA2010C.Form_Ref();
            CGA2010C.WindowState = FormWindowState.Maximized;

        }

        public  void Gf_IsFormLoad(string sFormID)
        {
            if (!(GeneralCommon.MDIMain.MdiChildren == null))
            {
                foreach (Form frm in GeneralCommon.MDIMain.MdiChildren)
                {
                    if ("CGA2010C" == frm.Name)
                    {
                        frm.Close();
                    }
                }
            }
        }

        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);

            GeneralCommon.ImageList0.Images[2] = GeneralCommon.ImageList2.Images[2];
            GeneralCommon.MDIToolBar.Buttons[4].Tag = "F";

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";

            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";

            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";



            GeneralCommon.ImageList0.Images[7] = GeneralCommon.ImageList2.Images[7];
            GeneralCommon.MDIToolBar.Buttons[10].Tag = "F";
            //GeneralCommon.MDIToolBar.Buttons[10].Visible = false;
            GeneralCommon.ImageList0.Images[8] = GeneralCommon.ImageList2.Images[8];
            //GeneralCommon.MDIToolBar.Buttons[11].Visible = false;
            GeneralCommon.MDIToolBar.Buttons[11].Tag = "F";

            GeneralCommon.MDIToolBar.Refresh();

            button5.Enabled = true;
            rib_area1.Enabled = true;
            rib_area2.Enabled = true;
            rib_area3.Enabled = true;
            rib_area4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

    }
}
