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
            p_SetMc("钢板号", TXT_PLATE_NO, "PI ", "", "", "", "", imcseq);//0
            p_SetMc("生产日期", SDT_PROD_DATE_FROM, "P", "", "", "", "", imcseq);//1
            p_SetMc("生产日期", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);//2
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);//3
            p_SetMc("", TXT_PROC_FLAG, "RL", "", "", "", "", imcseq);//4
            p_SetMc("", TXT_APLY_ENDUSE_CD, "RL", "", "", "", "", imcseq);//5
            p_SetMc("", TXT_STLGRD, "RL", "", "", "", "", imcseq);//6
            p_SetMc("", TXT_KIND_NO, "R", "", "", "", "", imcseq);//7
            p_SetMc("", TXT_UST_HEAD, "R", "", "", "", "", imcseq);//8
            p_SetMc("", TXT_UST_METHOD, "R", "", "", "", "", imcseq);//9
            p_SetMc("", TXT_UST_PREC, "R", "", "", "", "", imcseq);//10
            p_SetMc("", TXT_UST_STAND_NO, "NIR", "", "", "", "", imcseq);//11
            p_SetMc("", TXT_UST_GRADE, "IR", "", "", "", "", imcseq);//12
            p_SetMc("", SDB_THK, "NIR", "", "", "", "", imcseq);//13
            p_SetMc("", SDB_INSP_THK_MX, "RL", "", "", "", "", imcseq);//14
            p_SetMc("", SDB_INSP_THK_MN, "RL", "", "", "", "", imcseq);//15
            p_SetMc("", SDB_WID, "NIR", "", "", "", "", imcseq);//16
            p_SetMc("", SDB_INSP_WID_MX, "RL", "", "", "", "", imcseq);//17
            p_SetMc("", SDB_INSP_WID_MN, "RL", "", "", "", "", imcseq);//18
            p_SetMc("", SDB_LEN, "NIR", "", "", "", "", imcseq);//19
            p_SetMc("", SDB_INSP_LEN_MX, "RL", "", "", "", "", imcseq);//20
            p_SetMc("", SDB_INSP_LEN_MN, "RL", "", "", "", "", imcseq);//21
            p_SetMc("", SDB_WGT, "NIR", "", "", "", "", imcseq);//22
            p_SetMc("", SDB_PWGT_MX, "RL", "", "", "", "", imcseq);//23
            p_SetMc("", SDB_PWGT_MN, "RL", "", "", "", "", imcseq);//24
            p_SetMc("", SDB_THK_ORG, "RL", "", "", "", "", imcseq);//25
            p_SetMc("", SDB_WID_ORG, "IRL", "", "", "", "", imcseq);//26
            p_SetMc("", SDB_LEN_ORG, "IRL", "", "", "", "", imcseq);//27
            p_SetMc("", SDB_WGT_ORG, "IRL", "", "", "", "", imcseq);//28
            p_SetMc("", SDB_ORD_THK, "RL", "", "", "", "", imcseq);//29
            p_SetMc("", SDB_ORD_WID, "RL", "", "", "", "", imcseq);//30
            p_SetMc("", SDB_ORD_LEN, "RL", "", "", "", "", imcseq);//31
            p_SetMc("", SDB_WGT_ORD, "RL", "", "", "", "", imcseq);//32
            p_SetMc("", TXT_UST_GRD, "NIR", "", "", "", "", imcseq);//33
            p_SetMc("", TXT_PRD_GRD, "NIR", "", "", "", "", imcseq);//34
            p_SetMc("", TXT_INSP_MAN, "NIR", "", "", "", "", imcseq);//35
            p_SetMc("", TXT_INSP_OCCR_TIME, "NIR", "", "", "", "", imcseq);//36
            p_SetMc("", TXT_ADD_THK, "IR", "", "", "", "", imcseq);//37
            p_SetMc("", TXT_LOC, "IR", "", "", "", "", imcseq);//38
            p_SetMc("", TXT_REMARK, "IR", "", "", "", "", imcseq);//39
            p_SetMc("", txt_stdspec, "IR", "", "", "", "", imcseq);//40
            p_SetMc("", txt_stdspec_chg, "I", "", "", "", "", imcseq);//41
            p_SetMc("", TXT_REASON_FL0, "IR", "", "", "", "", imcseq);//42
            p_SetMc("", TXT_REASON_FL1, "IR", "", "", "", "", imcseq);//43
            p_SetMc("", TXT_REASON_FL2, "IR", "", "", "", "", imcseq);//44
            p_SetMc("", TXT_ADDR0, "R", "", "", "", "", imcseq);//45
            p_SetMc("", TXT_ADDR1, "R", "", "", "", "", imcseq);//46
            p_SetMc("", TXT_ADDR2, "R", "", "", "", "", imcseq);//47
            p_SetMc("", txt_Scrap_code, "I", "", "", "", "", imcseq);//48
            p_SetMc("", txt_Scrap_name, "L", "", "", "", "", imcseq);//49
            p_SetMc("", TXT_NEXT_PROC, "IRL", "", "", "", "", imcseq);//50
            p_SetMc("", TXT_INSP_MAN1, "NIR", "", "", "", "", imcseq);//51
            p_SetMc("", TXT_INSP_MAN2, "IR", "", "", "", "", imcseq);//52
            p_SetMc("", TXT_EQPM, "NI", "", "", "", "", imcseq);//53

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("扎批号", "E", "60", "L", "", "", "", iscseq, iheadrow,"L");//1
            p_SetSc("分段号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("规格尺寸(mm)", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("返剪宽度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("返剪长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("返剪重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("合格", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("探伤日期", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("改判标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("改判原因1", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("改判原因2", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("返剪原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("仪器型号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//16
            p_SetSc("探头", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("探伤方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("探伤灵敏度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//19
            p_SetSc("检查标准", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("探伤人员", "E", "7", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("垛位号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//22

        }
        private void CGD2060C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGD2060NC";
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
            TXT_PRD_GRD.Text = Convert.ToString(LISTB_SURF_GRD13.SelectedItem).Substring(0, 1);
            //点击等级1~3时取消等级4~7的选择
            LISTB_SURF_GRD47.SetSelected(0, false);
        }

        private void LISTB_SURF_GRD47_Click(object sender, EventArgs e)
        {
            TXT_PRD_GRD.Text = Convert.ToString(LISTB_SURF_GRD47.SelectedItem).Substring(0, 1);
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
