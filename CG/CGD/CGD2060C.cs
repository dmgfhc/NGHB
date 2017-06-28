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

namespace CG
{
    public partial class CGD2060C : CommonClass.FORMBASE
    {
        public CGD2060C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Plate_No = 0;  //SS1钢板号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 18, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "PIL", "", "", "", iscseq, iheadrow);
            p_SetSc("实绩状态", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("探伤结束时间", "DT", "19", "I", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("代码", "E", "4", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("名称", "E", "80", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("代码", "E", "4", "IL", "", "", "", iscseq, iheadrow,"M");
            //11-15
            p_SetSc("名称", "E", "80", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("合格", "C", "1", "I", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("代码", "E", "10", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("数量", "N", "2", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("面积", "N", "8", "I", "", "", "", iscseq, iheadrow);
            //16-18
            p_SetSc("面积比", "N", "3", "I", "", "", "", iscseq, iheadrow);
            p_SetSc("紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("垛位", "E", "12", "L", "", "", "", iscseq, iheadrow, "M");  //20140606 ADD BY LICHAO FOR LITIQIN
            p_SetSc("备注", "E", "50", "L", "", "", "", iscseq, iheadrow);      
            p_SetSc("确认人员", "E", "7", "IL", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "5", "L", "", "", "", iscseq, iheadrow,"M");   //20140208 ADD BY LICHAO
            p_SetSc("热处理", "E", "10", "L", "", "", "", iscseq, iheadrow);     //20140208 ADD BY LICHAO

            iheadrow = 0;
            p_spanSpread("钢板规格", 3, 6, iscseq, iheadrow, 1);
            p_spanSpread("探伤指示", 8, 9, iscseq, iheadrow, 1);
            p_spanSpread("探伤实绩", 10, 12, iscseq, iheadrow, 1);
            p_spanSpread("探伤缺陷", 13, 16, iscseq, iheadrow, 1);

            p_McIni(Mc2, true);
            imcseq = 2;
            //0-5
            p_SetMc("钢板号", TXT_PLATE_NO_EDT, "PNRI", "", "", "", "", imcseq);
            p_SetMc("实绩状态", TXT_UST_HEAD, "R", "", "", "", "", imcseq);
            p_SetMc("仪器型号", TXT_EQPM, "NI", "", "", "", "", imcseq);
            p_SetMc("探伤指示标准", TXT_UST_STAND_NO, "RL", "", "", "", "", imcseq);
            p_SetMc("探伤实绩标准", TXT_UST_GRADE, "RNI", "4", "", "", "", imcseq);
            p_SetMc("探伤判定结果", TXT_UST_GRD, "RNI", "", "", "", "", imcseq);
            //6-10
            p_SetMc("等级判定", TXT_SURF_GRD, "RNI", "", "", "", "", imcseq);
            p_SetMc("订单用途", f4ETCR_ENDUSE_CD, "RNI", "3", "", "", "", imcseq);
            p_SetMc("改判厚度", SDB_THK, "RNI", "", "", "", "", imcseq);
            p_SetMc("改判宽度", SDB_WID, "RNI", "", "", "", "", imcseq);
            p_SetMc("改判长度", SDB_LEN, "RNI", "", "", "", "", imcseq);
            //11-15
            p_SetMc("改判重量", SDB_WGT, "R", "", "", "", "", imcseq);
            p_SetMc("实绩厚度", SDB_THK_ORG, "R", "", "", "", "", imcseq);
            p_SetMc("实绩宽度", SDB_WID_ORG, "R", "", "", "", "", imcseq);
            p_SetMc("实绩长度", SDB_LEN_ORG, "R", "", "", "", "", imcseq);
            p_SetMc("实绩重量", SDB_WGT_ORG, "R", "", "", "", "", imcseq);
            //16-20
            p_SetMc("订单厚度", SDB_ORD_THK, "R", "", "", "", "", imcseq);
            p_SetMc("订单宽度", SDB_ORD_WID, "R", "", "", "", "", imcseq);
            p_SetMc("订单长度", SDB_ORD_LEN, "R", "", "", "", "", imcseq);
            p_SetMc("订单重量", SDB_WGT_ORD, "R", "", "", "", "", imcseq);
            p_SetMc("上公差厚度", SDB_INSP_THK_MX, "R", "", "", "", "", imcseq);
            //21-25
            p_SetMc("上公差宽度", SDB_INSP_WID_MX, "R", "", "", "", "", imcseq);
            p_SetMc("上公差长度", SDB_INSP_LEN_MX, "R", "", "", "", "", imcseq);
            p_SetMc("下公差厚度", SDB_INSP_THK_MN, "R", "", "", "", "", imcseq);
            p_SetMc("下公差宽度", SDB_INSP_WID_MN, "R", "", "", "", "", imcseq);
            p_SetMc("下公差长度", SDB_INSP_LEN_MN, "R", "", "", "", "", imcseq);
            //26-30
            p_SetMc("判定结果厚度", TXT_INSP_THK_GRD, "R", "", "", "", "", imcseq);
            p_SetMc("判定结果宽度", TXT_INSP_WID_GRD, "R", "", "", "", "", imcseq);
            p_SetMc("判定结果长度", TXT_INSP_LEN_GRD, "R", "", "", "", "", imcseq);
            p_SetMc("原始标准号", txt_stdspec_name, "R", "", "", "", "", imcseq);
            p_SetMc("改判标准号", txt_stdspec, "I", "", "", "", "", imcseq);
            //31-35
            p_SetMc("改判原因", f4ETCR_CHG_GRD_RES, "RI", "3", "", "", "", imcseq);
            p_SetMc("责任单位", f4ETCR_CHG_GRD_DEP, "RI", "3", "", "", "", imcseq);
            p_SetMc("判废原因", txt_Scrap_code, "RI", "1", "", "", "", imcseq);
            p_SetMc("余材原因", f4ETCN_WOO_RSN, "RI", "2", "", "", "", imcseq);
            p_SetMc("厚度附加值", TXT_ADD_THK, "R", "", "", "", "", imcseq);
            p_SetMc("返剪原因", TXT_REASON_FL, "RI", "", "", "", "", imcseq);
            //36-40
            p_SetMc("垛位号", TXT_ADDR0, "I", "", "", "", "", imcseq);
            p_SetMc("备注", TXT_REMARK, "RI", "", "", "", "", imcseq);
            p_SetMc("探伤人员", TXT_INSP_MAN1, "NRI", "", "", "", "", imcseq);
            p_SetMc("探伤时间", TXT_INSP_OCCR_TIME, "NRI", "19", "", "", "", imcseq);
            p_SetMc("缺陷代码", TXT_REJ_CD, "RI", "1", "", "", "", imcseq);
            //41-43
            p_SetMc("缺陷数量", SDB_REJ_NUM, "RI", "2", "", "", "", imcseq);
            p_SetMc("缺陷面积", SDB_REJ_AREA, "RI", "8", "", "", "", imcseq);
            p_SetMc("缺陷面积比", SDB_REJ_AREA_RATE, "RI", "3", "", "", "", imcseq);   
       
        }
        private void WGC2040C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
        }
        #endregion

        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, false);
            if (TXT_PLATE_NO.Text.Trim().Length == 14)
            {
                TXT_PLATE_NO_EDT.Text = TXT_PLATE_NO.Text;
                base.p_Ref(2, 0, true, false);
            }
                
            return;
        }
        #endregion

        #region //保存
        public override void Form_Pro()
        {
            if (CHK_UST_COMF.Checked)
            {
                TXT_INSP_MAN1.Text = GeneralCommon.sUserID;
                base.p_pro(2, 0, true, false);
            }
            else
            {
                base.p_pro(1, 1, true, false);
            }

            return;
        }
        #endregion

        #region //列表选择（判定结果）

        private void LISTB_UST_DEC_Click(object sender, EventArgs e)
        {
            TXT_UST_GRD.Text = Convert.ToString(LISTB_UST_DEC.SelectedItem).Substring(0, 1);
        }
        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {

            string sRowLabel;

            if (ss1_Sheet1.RowCount == 0)
            {
                return;
            }

            //只有选择行表头才可进行操作
            if (e.Column > 0)
            {
                return;
            }

            sRowLabel = ss1_Sheet1.RowHeader.Rows[e.Row].Label;
            //取消前次操作
            if (sRowLabel == "修改")
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = "";
            }
            else
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = "修改";
            }

            //当单击表单时，按照单击行所对应钢板号查询钢板探伤详细信息
            TXT_PLATE_NO_EDT.Text = ss1_Sheet1.Cells[e.Row, iSs1_Plate_No].Text;
            base.p_Ref(2, 0, true, false);
            TXT_PLATE_NO.Enabled = true;
        }

        private void LISTB_SURF_GRD13_Click(object sender, EventArgs e)
        {
            TXT_SURF_GRD.Text = Convert.ToString(LISTB_SURF_GRD13.SelectedItem).Substring(0, 1);
            //点击等级1~3时取消等级4~7的选择
            LISTB_SURF_GRD47.SetSelected(0, false);
        }

        private void LISTB_SURF_GRD47_Click(object sender, EventArgs e)
        {
            TXT_SURF_GRD.Text = Convert.ToString(LISTB_SURF_GRD47.SelectedItem).Substring(0, 1);
            //点击等级4~7时取消等级1~3的选择
            LISTB_SURF_GRD13.SetSelected(0, false);
        }

        private void TXT_PLATE_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Strings.ChrW((int)Keys.Enter))
            {
                if (TXT_PLATE_NO.TextLength > 8)
                {
                    Form_Ref();
                }
            }
        }

    }
}
