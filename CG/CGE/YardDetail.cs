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
    public partial class YardDetail : CommonClass.FORMBASE
    {
        public YardDetail()
        {
            InitializeComponent();
            this.Width = 965;
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        TextBox yard = new TextBox();//查询条件
        public string yardValue;
        public string checkCod;
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

        private void YardDetail_Load(object sender, EventArgs e)
        {
            Form_Define();
            Form_Ref();
            setPanelValue();
            setDetailGri();
        }

        public override void Form_Ref()
        {
            //yard.Text = yardValue;
            yard.Text = "P3C0211";
            p_Ref(1,1,true,false);
        }

        object[,] yardDetailData = null;
        private void setPanelValue()
        {
            this.yardno.Text = yardValue;//垛位号

            if (checkCod.Substring(1,1)== "1")//块数
            {
                string sqlYardCount = "SELECT COUNT(*) FROM  NISCO.GP_PLATEYARD A,  NISCO.GP_PLATE B  WHERE  A.YARD_ADDR='"+ yard.Text +"'  AND  A.PLATE_NO = B.PLATE_NO AND B.PROD_CD = 'PP' AND B.PLT = 'C1' ORDER BY A.BED_SEQ";
                yardCount.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sqlYardCount);
                label6.Visible = true;
                yardCount.Visible = true;
            }

            if (checkCod.Substring(0, 1) == "1")//垛位宽*长
            {
                string sqlYardWidLen = "SELECT A.LOCATION_WID,A.LOCATION_LEN FROM FP_STDYARD A WHERE A.LOCATION = '" + yardValue + "'";
                object[,] yardWidLenSet = plSqlReturn(sqlYardWidLen);
                this.yardWidLen.Text = yardWidLenSet[0, 0].ToString() + "*" + yardWidLenSet[0, 1].ToString();
                label3.Visible = true;
                yardWidLen.Visible = true;
            }

            string sqlYardDetail = "SELECT A.BED_SEQ,A.PLATE_NO,A.YARD_ADDR, B.STLGRD, B.THK, B.WID, B.LEN, B.WGT, B.PROD_GRD, B.ORD_NO || B.ORD_ITEM, B.SHP_DATE, B.SHP_TIME, B.APLY_STDSPEC, B.CUST_CD FROM NISCO.GP_PLATEYARD A, NISCO.GP_PLATE B WHERE A.YARD_ADDR = '" + yard.Text + "' AND A.PLATE_NO = B.PLATE_NO AND B.PROD_CD = 'PP' AND B.PLT = 'C1' ORDER BY A.BED_SEQ";
            yardDetailData = plSqlReturn(sqlYardDetail);
            if (yardDetailData == null)
            {
                GeneralCommon.Gp_MsgBoxDisplay("该区没有钢板信息...!!", "W", "警告");
                return;
            }

            if (checkCod.Substring(2, 1) == "1")
            {
                float yardHei = 0;
                for (int i = 0; i < yardDetailData.Length / 14;i++)
                {
                    yardHei += float.Parse(yardDetailData[i, 4].ToString());
                }
                this.yardHeight.Text = yardHei.ToString();
                label4.Visible = true;
                yardHeight.Visible = true;
            }

            if (checkCod.Substring(3, 1) == "1")
            {
                float yardWei = 0;
                for (int i = 0; i < yardDetailData.Length / 14; i++)
                {
                     yardWei += float.Parse(yardDetailData[i, 7].ToString());
                }  
                 this.yardWeight.Text = yardWei.ToString();
                 label2.Visible = true;
                 yardWeight.Visible = true;
            }

            if (checkCod.Substring(4, 1) == "1")
            {
                ss1_Sheet1.Columns.Get(6).Visible = true;
            }

            if (checkCod.Substring(5, 1) == "1")
            {
                ss1_Sheet1.Columns.Get(7).Visible = true;
            }
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
                    lbN.BackColor = Color.Gray;
                }
                else
                {
                    lbN.BackColor = Color.CornflowerBlue;
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

        private void panel1_Resize(object sender, EventArgs e)
        {
            setDetailGri();
        }

       


    }
}
