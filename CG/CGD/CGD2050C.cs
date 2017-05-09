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
///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            钢板表面判定管理                                
///-- 程序ID            WGC3010C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2013.01.06                                                
///-- 处理描述          钢板表面判定管理                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.01.06        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace CG
{
    public partial class CGD2050C : CommonClass.FORMBASE
    {
        public CGD2050C()
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
            //p_SetMc("工厂", f4ETCR_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_TO_DATE, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("标准号",txt_stdspec_chg_ref , "P", "", "", "", "", imcseq);
            p_SetMc("当前库", f4ETCR_CUR_INV, "PN", "", "", "", "", imcseq);
            p_SetMc("厚度", SDB_THK_REF, "P", "", "", "", "", imcseq);
            p_SetMc("宽度", SDB_WID_REF, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 21, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("进程状态", "E", "3", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "8", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板不平度1", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("测量长度1", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板不平度2", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("测量长度2", "E", "30", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("产品等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("表面等级", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("取样代码", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("试样号", "E", "14", "L", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("生产时间", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("检查人员", "E", "7", "L", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("入库时间", "D", "10", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("库", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");
            //16-21
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("探伤", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("其他", "E", "200", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow,"L");
            p_SetSc("抛丸指示", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//72
            p_SetSc("订单特殊要求", "E", "300", "L", "", "", "", iscseq, iheadrow, "L");//73

            iheadrow = 0;
            p_spanSpread("钢板规格", 2, 5, iscseq, iheadrow, 1);
            p_spanSpread("作业指示/实绩", 17, 21, iscseq, iheadrow, 1);

            p_McIni(Mc2, true);
            imcseq = 2;
            //0-5
            //p_SetMc("工厂", f4ETCR_PLT, "PNR", "", "", "", "", imcseq);
            p_SetMc("钢板号", TXT_PLATE_NO_EDT, "PNIR", "", "", "", "", imcseq);
            p_SetMc("进程代码", TXT_PROC_CD, "R", "", "", "", "", imcseq);
            p_SetMc("Mn含量", TXT_Mn, "R", "", "", "", "", imcseq);
            p_SetMc("下表主要缺陷代码", f4ETCR_B_FLAW_CD, "IR", "3", "", "", "", imcseq);
          //  p_SetMc("下表主要缺陷名称", TXT_B_FLAW_NAME, "L", "", "", "", "", imcseq);
            //6-10
            p_SetMc("下表小缺陷1代码", f4ETCR_B_FLAW_CD1, "IR", "3", "", "", "", imcseq);
          //  p_SetMc("下表小缺陷1名称", TXT_B_FLAW_NAME1, "L", "", "", "", "", imcseq);
            p_SetMc("上表主要缺陷代码", f4ETCR_T_FLAW_CD, "IR", "3", "", "", "", imcseq);
         //   p_SetMc("上表主要缺陷名称", TXT_T_FLAW_NAME, "L", "", "", "", "", imcseq);
            p_SetMc("上表小缺陷1代码", f4ETCR_T_FLAW_CD1, "IR", "3", "", "", "", imcseq);
            //11-15
         //   p_SetMc("上表小缺陷1名称", TXT_T_FLAW_NAME1, "L", "", "", "", "", imcseq);
            p_SetMc("上表面判定", TXT_T_GRID_GRD, "IR", "", "", "", "", imcseq);
            p_SetMc("上表面面积比", SDB_T_GRID_YRD, "IR", "", "", "", "", imcseq);
            p_SetMc("上表面深度", SDB_T_GRID_DEEP, "IR", "", "", "", "", imcseq);
            p_SetMc("下表面判定", TXT_B_GRID_GRD, "IR", "", "", "", "", imcseq);
            //16-20
            p_SetMc("下表面面积比", SDB_B_GRID_YRD, "IR", "", "", "", "", imcseq);
            p_SetMc("下表面深度", SDB_B_GRID_DEEP, "IR", "", "", "", "", imcseq);
            p_SetMc("修磨时间", MDATE_GRID_DATE, "IR", "", "", "", "", imcseq);
            p_SetMc("厚度", SDB_THK, "RNI", "", "", "", "", imcseq);
            p_SetMc("宽度", SDB_WID, "RNI", "", "", "", "", imcseq);
            //21-25
            p_SetMc("长度", SDB_LEN, "RNI", "", "", "", "", imcseq);
            p_SetMc("重量", SDB_WGT, "R", "", "", "", "", imcseq);
            p_SetMc("订单厚度", SDB_ORD_THK, "R", "", "", "", "", imcseq);
            p_SetMc("订单宽度", SDB_ORD_WID, "R", "", "", "", "", imcseq);
            p_SetMc("订单长度", SDB_ORD_LEN, "R", "", "", "", "", imcseq);
            //26-30
            p_SetMc("订单重量", SDB_WGT_ORD, "R", "", "", "", "", imcseq);
            p_SetMc("上公差厚度", SDB_THK_MAX, "R", "", "", "", "", imcseq);
            p_SetMc("上公差宽度", SDB_WID_MAX, "R", "", "", "", "", imcseq);
            p_SetMc("上公差长度", SDB_LEN_MAX, "R", "", "", "", "", imcseq);
            p_SetMc("下公差厚度", SDB_THK_MIN, "R", "", "", "", "", imcseq);
            //31-35
            p_SetMc("下公差宽度", SDB_WID_MIN, "R", "", "", "", "", imcseq);
            p_SetMc("下公差长度", SDB_LEN_MIN, "R", "", "", "", "", imcseq);
            p_SetMc("厚度判定", TXT_INSP_THK_GRD, "R", "", "", "", "", imcseq);
            p_SetMc("宽度判定", TXT_INSP_WID_GRD, "R", "", "", "", "", imcseq);
            p_SetMc("长度判定", TXT_INSP_LEN_GRD, "R", "", "", "", "", imcseq);
            //36-40
            p_SetMc("定尺", TXT_SIZE_KND, "IR", "", "", "", "", imcseq);
            p_SetMc("切割指示", TXT_GAS_FL, "IR", "", "", "", "", imcseq);
            p_SetMc("切割实绩", TXT_GAS_RSLT, "R", "", "", "", "", imcseq);
            p_SetMc("矫直指示", TXT_CL_FL, "IR", "", "", "", "", imcseq);
            p_SetMc("矫直实绩", TXT_CL_RSLT, "R", "", "", "", "", imcseq);
            //41-45
            p_SetMc("备注", TXT_REMARK, "IR", "", "", "", "", imcseq);
            p_SetMc("判定等级", TXT_SURF_GRD, "RNI", "", "", "", "", imcseq);
            p_SetMc("判废原因", f4ETCR_SCRAP, "RI", "", "", "", "", imcseq);
            p_SetMc("原始标准号", TXT_ORG_STDSPEC, "R", "", "", "", "", imcseq);
            p_SetMc("改判标准号", TEXT_STDSPEC, "I", "", "", "", "", imcseq);
            //46-50F4ETCN_STDSPEC
            p_SetMc("改判原因", f4ETCR_CHG_GRD_RES, "RI", "3", "", "", "", imcseq);
            p_SetMc("责任单位", f4ETCR_CHG_GRD_DEP, "RI", "3", "", "", "", imcseq);
            p_SetMc("余材原因", f4ETCN_WOO_RSN, "RI", "2", "", "", "", imcseq);
            p_SetMc("订单用途", f4ETCR_ENDUSE_CD, "RI", "3", "", "", "", imcseq);
            p_SetMc("检查人员", TXT_EMP_CD, "NRI", "", "", "", "", imcseq);
            p_SetMc("检查时间", MDATE_INSP_DATE, "RI", "", "", "", "", imcseq);
            p_SetMc("同板差", SDB_TONGBAN, "R", "", "", "", "", imcseq);
            p_SetMc("留样指示", TXT_SMP_FL, "IR", "", "", "", "", imcseq);
            p_SetMc("不平度1", TXT_WAVE, "R", "", "", "", "", imcseq);
            p_SetMc("不平度2", TXT_WAVE1, "R", "", "", "", "", imcseq);
            p_SetMc("表面客户要求", TXT_SURFACE_REQUESTS, "R", "", "", "", "", imcseq);

           // p_SetMc("是否修磨", checkBox1,"I", "", "", "", "", imcseq);
          

        }
        private void WGC3010C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
            f4ETCR_CUR_INV.Text = "HB";
            TXT_T_GRID_GRD.Enabled = false;
            SDB_T_GRID_YRD.Enabled = false;
            SDB_T_GRID_DEEP.Enabled = false;
            TXT_B_GRID_GRD.Enabled = false;
            SDB_B_GRID_YRD.Enabled = false;
            SDB_B_GRID_DEEP.Enabled = false;
            MDATE_GRID_DATE.Enabled = false;
            LISTB_T_GRID_GRD.Enabled= false;
            LISTB_B_GRID_GRD.Enabled = false;
            MDATE_GRID_DATE.Enabled = false;

            label41.Visible = false;


        }
        #endregion

        #region //查询
        public override void Form_Ref()
        {
            base.p_Ref(1, 1, true, true);
            if (TXT_PLATE_NO.Text != "")
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
            f4ETCR_PLT.Text = "C2";
            TXT_EMP_CD.Text = GeneralCommon.sUserID;

            //确保修磨时间已经输入
            if (MDATE_GRID_DATE.Text == "    -  -     :  :" && CHK_CL_FL.Checked == true)
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入修磨时间", "I", "");

                return;
            }

            if (TXT_SURF_GRD.Text == "1")
            {
                if (CHK_CL_FL.Checked == true)
                {
                    if (TXT_T_GRID_GRD.Text == "N" || TXT_B_GRID_GRD.Text == "N")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("修磨不合格不允许判定正品！", "I", "");
                        return;
                    }
                }
            }

            base.p_pro(2, 0, true, false);

            return;
        }
        #endregion

        #region //列表选择（判定结果）
        private void LISTB_T_GRID_GRD_Click(object sender, EventArgs e)
        {
            TXT_T_GRID_GRD.Text = Convert.ToString(LISTB_T_GRID_GRD.SelectedItem).Substring(0, 1);
        }

        private void LISTB_B_GRID_GRD_Click(object sender, EventArgs e)
        {
            TXT_B_GRID_GRD.Text = Convert.ToString(LISTB_B_GRID_GRD.SelectedItem).Substring(0, 1);
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





        #endregion

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1_Sheet1.RowCount == 0)
            {
                return;

            }

            //在点击单元格的时候，先将以下F4控件项置为空 
            TXT_B_FLAW_NAME.Text = "";
            TXT_B_FLAW_NAME1.Text = "";
            TXT_T_FLAW_NAME.Text = "";
            TXT_T_FLAW_NAME1.Text = "";
            TXT_SCRAP.Text = "";
            TXT_CHG_GRD_RES.Text = "";
            TXT_ENDUSE_CD.Text = "";
            f4ETCR_B_FLAW_CD.Text = "";
            f4ETCR_B_FLAW_CD1.Text = "";
            f4ETCR_T_FLAW_CD.Text = "";
            f4ETCR_T_FLAW_CD1.Text = "";
            f4ETCR_SCRAP.Text = "";
            f4ETCR_CHG_GRD_RES.Text = "";

            //当单击表单时，按照单击行所对应钢板号查询钢板探伤详细信息
            TXT_PLATE_NO_EDT.Text = ss1_Sheet1.Cells[e.Row, iSs1_Plate_No].Text;
            base.p_Ref(2, 0, true, false);
            f4ETCR_PLT.Enabled = true;
            TXT_PLATE_NO.Enabled = true;

            //为了解决用户修改公共代码导致查询文本数据不能同步变化的问题，
            //以下程序，判断F4项是否存在公共代码，如果存在则调用Gf_CodeFind函数使用相应的SQL对第二项的值，进行查询
            //再将对应的值存在F4控件的第二项中
            if (f4ETCR_B_FLAW_CD.Text != "")
                TXT_B_FLAW_NAME.Text =
                    GeneralCommon.Gf_CodeFind
                (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_B_FLAW_CD.Text + "'");

            if (f4ETCR_B_FLAW_CD1.Text != "")
                TXT_B_FLAW_NAME1.Text =
                    GeneralCommon.Gf_CodeFind
                (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_B_FLAW_CD1.Text + "'");

            if (f4ETCR_T_FLAW_CD.Text != "")
                TXT_T_FLAW_NAME.Text =
                GeneralCommon.Gf_CodeFind
            (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_T_FLAW_CD.Text + "'");

            if (f4ETCR_T_FLAW_CD1.Text != "")
                TXT_T_FLAW_NAME1.Text =
           GeneralCommon.Gf_CodeFind
       (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_T_FLAW_CD1.Text + "'");


            if (f4ETCR_SCRAP.Text != "")
                TXT_SCRAP.Text =
           GeneralCommon.Gf_CodeFind
       (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0017' AND T.CD =" + "'" + f4ETCR_SCRAP.Text + "'");

            if (f4ETCR_CHG_GRD_RES.Text != "")
                TXT_CHG_GRD_RES.Text =
           GeneralCommon.Gf_CodeFind
       (GeneralCommon.M_CN1, "SELECT CD_SHORT_NAME FROM ZP_CD T WHERE CD_MANA_NO = 'G0002' AND T.CD =" + "'" + f4ETCR_CHG_GRD_RES.Text + "'");

        }

        #region //精整指示处理
        private void CHK_GAS_FL_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_GAS_FL.Checked)
            {
                TXT_GAS_FL.Text = "Y";
            }
            else
            {
                TXT_GAS_FL.Text = "";
            }
        }

        private void CHK_CL_FL_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_CL_FL.Checked)
            {
                TXT_CL_FL.Text = "Y";
            }
            else
            {
                TXT_CL_FL.Text = "";
            }
        }
        //留样指示
        private void CHK_SMP_FL_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_SMP_FL.Checked)
            {
                TXT_SMP_FL.Text = "Y";
            }
            else
            {
                TXT_SMP_FL.Text = "";
            }
        }

        #endregion

        private void TEXT_STDSPEC_DoubleClick(object sender, EventArgs e)
        {
            Collection rControl = new Collection();
            Collection fControl = new Collection();
            rControl.Add((TextBox)sender, null, null, null);
            fControl.Add("CD_SHORT_NAME", null, null, null);
            DataDicCommon.Gf_Master_DD(rControl, fControl, "SELECT CD_SHORT_NAME AS 标准代号, CD_NAME AS 标准中文名 FROM ZP_CD WHERE CD_MANA_NO = 'G0035'", "", 0, "", 1);



        }

        private void TEXT_STDSPEC_KeyUp(object sender, KeyEventArgs e)
        {
            Collection rControl = new Collection();
            Collection fControl = new Collection();
            if (e.KeyCode == Keys.F4)
            {
                rControl.Add((TextBox)sender, null, null, null);
                fControl.Add("STDSPEC", null, null, null);
                DataDicCommon.Gf_Master_DD(rControl, fControl, "SELECT T.STDSPEC AS 标准号,T.STDSPEC_YY AS 发布年度,STDSPEC_CHR_CD FROM NISCO.QP_STD_HEAD T WHERE NVL(T.STDSPEC_CHR_CD,'Y') <>'N' ORDER BY STDSPEC ASC ", "", 0, "", 1);
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
//以下事件用于将F4控件代码小写转换成大写
        private void f4ETCR_B_FLAW_CD_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_B_FLAW_CD.Text = f4ETCR_B_FLAW_CD.Text.ToUpper();
            f4ETCR_B_FLAW_CD.SelectionStart = f4ETCR_B_FLAW_CD.Text.Length;
        }
        private void f4ETCR_B_FLAW_CD1_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_B_FLAW_CD1.Text = f4ETCR_B_FLAW_CD1.Text.ToUpper();
            f4ETCR_B_FLAW_CD1.SelectionStart = f4ETCR_B_FLAW_CD1.Text.Length;

        }

        private void f4ETCR_T_FLAW_CD_KeyUp(object sender, KeyEventArgs e)
        {

            f4ETCR_T_FLAW_CD.Text = f4ETCR_T_FLAW_CD.Text.ToUpper();
            f4ETCR_T_FLAW_CD.SelectionStart = f4ETCR_T_FLAW_CD.Text.Length;
        }


        private void f4ETCR_T_FLAW_CD1_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_T_FLAW_CD1.Text = f4ETCR_T_FLAW_CD1.Text.ToUpper();
            f4ETCR_T_FLAW_CD1.SelectionStart = f4ETCR_T_FLAW_CD1.Text.Length;
        }

        private void f4ETCN_WOO_RSN_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCN_WOO_RSN.Text = f4ETCN_WOO_RSN.Text.ToUpper();
            f4ETCN_WOO_RSN.SelectionStart = f4ETCN_WOO_RSN.Text.Length;
        }

        private void f4ETCR_SCRAP_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_SCRAP.Text = f4ETCR_SCRAP.Text.ToUpper();
            f4ETCR_SCRAP.SelectionStart = f4ETCR_SCRAP.Text.Length;
        }

        private void f4ETCR_CHG_GRD_RES_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_CHG_GRD_RES.Text = f4ETCR_CHG_GRD_RES.Text.ToUpper();
            f4ETCR_CHG_GRD_RES.SelectionStart = f4ETCR_CHG_GRD_RES.Text.Length;
        }

        private void f4ETCR_ENDUSE_CD_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_ENDUSE_CD.Text = f4ETCR_ENDUSE_CD.Text.ToUpper();
            f4ETCR_ENDUSE_CD.SelectionStart = f4ETCR_ENDUSE_CD.Text.Length;
        }

        private void f4ETCR_CHG_GRD_DEP_KeyUp(object sender, KeyEventArgs e)
        {
            f4ETCR_CHG_GRD_DEP.Text = f4ETCR_CHG_GRD_DEP.Text.ToUpper();
            f4ETCR_CHG_GRD_DEP.SelectionStart = f4ETCR_CHG_GRD_DEP.Text.Length;
        }

        private void TXT_SMP_FL_TextChanged(object sender, EventArgs e)
        {
            if (TXT_SMP_FL.Text == "Y")
            {
                label41.Visible = true;
                label41.ForeColor = Color.Red;

             }
            else
            {
                label41.Visible = false;
            }
        }

        

       

      

      



        

    }
}
