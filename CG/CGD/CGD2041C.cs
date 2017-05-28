using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using FarPoint.Win.Spread.CellType;
using System.Xml.Xsl;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.SuperEdit;
using ADODB;
using System.Data;
using System;
using Microsoft.VisualBasic;
using System.Drawing;
using FarPoint.Win.Spread.DrawingSpace;
using FarPoint.Win.Spread.DrawingSpace.Internal;
using FarPoint;
using System.Collections.Generic;
using FarPoint.Win.Text;
using FarPoint.Win.Spread.UndoRedo;
using FarPoint.Win.Spread.Design;
using FarPoint.Win;
using CommonClass;
namespace CG
{
    public partial class CGD2041C : CommonClass.FORMBASE
    {
        public CGD2041C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        string sWgtLenFlag;
        string sQuery;
        bool bCheck;
        string sLoopChk;

        const int SS1_STLGRD = 2; //钢种
        const int SS2_PLATE_NO = 1; //PLATE NO
        const int SS2_PROC_CD = 6; //进程代码
        const int SS2_PROD_CD = 2; //PRODUCT STATUS
        const int SS2_SMP_FLAG = 16; //实绩标记
        const int SS2_SMP_LOC = 17; //位置
        const int SS2_SMP_LEN = 18; //长度
        const int SS2_SMP_NO = 19; //试样号
        const int SS2_STDSPEC = 20; //标准号
        const int SS2_BEF_STDSPEC = 21; //BEFORE 标准号
        const int SS2_USER_ID = 28; //USER ID
        const int SS2_BEF_SMP_FLAG = 29; //BEFORE 实绩标记
        const int SS2_BEF_SMP_LOC = 30; //BEFORE 位置
        const int SS2_BEF_SMP_LEN = 31; //BEFORE 长度
        const int SS2_BEF_SMP_NO = 32; //BEFORE 试样号
        const int SS2_CHG_SMP_NO = 33; //改判时试样号
        const int SS2_CHG_STDSPEC = 34; //改判时适用标准

        protected override void p_SubFormInit()
        {
            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("查询号", txt_charge_no, "P", "", "", "", "", imcseq);
            p_SetMc("生产时间", SDT_PROD_DATE, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("生产时间(结束)", TXT_PROD_CD, "P", "", "", "", "", imcseq);

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("板坯号", txt_SLAB_NO, "PN", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("板坯号", "E", "", "L", "", "", "", iscseq, iheadrow); //0
            p_SetSc("批号", "E", "", "L", "", "", "", iscseq, iheadrow); //1
            p_SetSc("钢种", "E", "", "L", "", "", "", iscseq, iheadrow); //2
            p_SetSc("试样号", "E", "", "L", "", "", "", iscseq, iheadrow); //3
            p_SetSc("取样状态", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow); //5
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow); //6
            p_SetSc("长度", "N", "6", "L", "", "", "", iscseq, iheadrow); //7
            p_SetSc("重量", "N", "6,3", "L", "", "", "", iscseq, iheadrow); //8
            p_SetSc("订单号", "E", "18", "L", "", "", "", iscseq, iheadrow); //9
            p_SetSc("订单序列号", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("厚度", "N", "6", "L", "", "", "", iscseq, iheadrow); //11
            p_SetSc("宽度", "N", "6", "L", "", "", "", iscseq, iheadrow); //12
            p_SetSc("产品代码", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("剪切时间", "DT", "", "L", "", "", "", iscseq, iheadrow); //14


            iheadrow = 0;
            p_spanSpread("板坯尺寸", 5, 7, iscseq, iheadrow, 1);
            p_spanSpread("产品尺寸", 11, 12, iscseq, iheadrow, 1);


            p_ScIni(ss2, Sc2, 0, false, false);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("取样状态", "C", "", "", "", "", "", iscseq, iheadrow); //0
            p_SetSc("钢板", "E", "18", "PIL", "", "", "", iscseq, iheadrow); //1
            p_SetSc("产品代码", "E", "18", "IL", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("批号", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("喷印号", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("分段号", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("进程代码", "E", "18", "L", "", "", "", iscseq, iheadrow, "M"); //6
            p_SetSc("厚度", "N", "6,1", "L", "", "", "", iscseq, iheadrow); //7
            p_SetSc("宽度", "N", "6,1", "L", "", "", "", iscseq, iheadrow); //8
            p_SetSc("长度", "N", "6,1", "L", "", "", "", iscseq, iheadrow); //9
            p_SetSc("重量", "N", "8,3", "L", "", "", "", iscseq, iheadrow); //10
            p_SetSc("订单标记", "E", "18", "L", "", "", "", iscseq, iheadrow); //11
            p_SetSc("订单号", "E", "18", "L", "", "", "", iscseq, iheadrow); //12
            p_SetSc("订单系列号", "E", "18", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("指示标记", "E", "18", "L", "", "", "", iscseq, iheadrow, "M"); //14
            p_SetSc("指示长度", "N", "6", "L", "", "", "", iscseq, iheadrow); //15
            p_SetSc("实绩标记", "E", "1", "I", "", "", "", iscseq, iheadrow, "M"); //16  I
            p_SetSc("位置", "ETCN", "1", "I", "CD", "", "SELECT CD 代码, CD_SHORT_NAME 代码简称, CD_NAME 代码名称, CD_SHORT_ENG 代码英文简称, CD_FULL_ENG 代码英文名称 FROM NISCO.ZP_CD  WHERE CD_MANA_NO = 'Q0021'  ORDER BY CD ASC ", iscseq, iheadrow, "M"); //17            I
            p_SetSc("长度", "N", "3", "I", "", "", "", iscseq, iheadrow); //18              I
            p_SetSc("试样号", "E", "14", "I", "", "", "", iscseq, iheadrow); //19       I
            p_SetSc("适用标准", "E", "18", "L", "", "", "", iscseq, iheadrow); //20
            p_SetSc("改判前标准", "E", "18", "L", "", "", "", iscseq, iheadrow); //21
            p_SetSc("上表缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //22
            p_SetSc("下表缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //23
            p_SetSc("改判缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //24
            p_SetSc("探伤缺陷", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("客户名称", "E", "200", "L", "", "", "", iscseq, iheadrow); //26
            p_SetSc("生产日期", "E", "30", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("upd_emp_cd", "E", "18", "IL", "", "", "", iscseq, iheadrow); //28
            p_SetSc("实绩标记", "E", "18", "L", "", "", "", iscseq, iheadrow); //29
            p_SetSc("位置", "N", "18", "L", "", "", "", iscseq, iheadrow); //30
            p_SetSc("长度", "N", "18", "L", "", "", "", iscseq, iheadrow); //31
            p_SetSc("试样号", "E", "18", "L", "", "", "", iscseq, iheadrow); //32
            p_SetSc("改判时试样号", "E", "18", "IL", "", "", "", iscseq, iheadrow); //33
            p_SetSc("改判时适用标准", "E", "18", "IL", "", "", "", iscseq, iheadrow); //34
            p_SetSc("订单特殊要求", "E", "100", "L", "", "", "", iscseq, iheadrow); //35

            iheadrow = 0;
            p_spanSpread("试样信息", 14, 19, iscseq, iheadrow, 1);
            p_spanSpread("缺陷原因", 22, 25, iscseq, iheadrow, 1);
            p_spanSpread("OLD SAMPLE INFORMATION", 29, 32, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss2, SS2_USER_ID, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, SS2_BEF_SMP_FLAG, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, SS2_BEF_SMP_LOC, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, SS2_BEF_SMP_LEN, true);
            SpreadCommon.Gp_Sp_ColHidden(ss2, SS2_BEF_SMP_NO, true);
        }


        private void Cmd_Set_Save_Clk()
        {
            int intRow;
            int intCol;
            int intCount;
            string strQuery = "";
            string strQuery_H = "";
            string strQuery_L = "";

            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            strQuery = "  SELECT CHK                                                                    ";
            strQuery = strQuery + "         ,MATA_NO                                                    ";
            strQuery = strQuery + "         ,PROD_CD                                                    ";
            strQuery = strQuery + "         ,LOT_NO                                                     ";
            strQuery = strQuery + "         ,MARK_DATA10                                                ";
            strQuery = strQuery + "         ,MOCUT_NO                                                   ";
            strQuery = strQuery + "         ,PROC_CD                                                    ";
            strQuery = strQuery + "         ,THK                                                        ";
            strQuery = strQuery + "         ,WID                                                        ";
            strQuery = strQuery + "         ,LEN                                                        ";
            strQuery = strQuery + "         ,WGT                                                        ";
            strQuery = strQuery + "         ,ORD_FL                                                     ";
            strQuery = strQuery + "         ,ORD_NO                                                     ";
            strQuery = strQuery + "         ,ORD_ITEM                                                   ";
            strQuery = strQuery + "         ,SMP_FL                                                     ";
            strQuery = strQuery + "         ,SMP_LEN                                                    ";
            strQuery = strQuery + "         ,ACT_SMP_FL                                                 ";
            strQuery = strQuery + "         ,SMP_LOC                                                    ";
            strQuery = strQuery + "         ,ACT_SMP_LEN                                                ";
            strQuery = strQuery + "         ,SMP_NO                                                     ";
            strQuery = strQuery + "         ,STD_SPEC                                                   ";
            strQuery = strQuery + "         ,BEF_STDSPEC                                                ";
            //strQuery = strQuery & "         ,DEFECT                                                     " & vbCrLf
            strQuery = strQuery + "         ,INSP_T_FLAW                                                ";
            strQuery = strQuery + "         ,INSP_B_FLAW                                                ";
            strQuery = strQuery + "         ,INSP_B_DEP_FLAW2                                           ";
            strQuery = strQuery + "         ,INSP_T_DEP_FLAW2                                           ";
            strQuery = strQuery + "         ,CUST_NAME                                                  ";
            strQuery = strQuery + "         ,PROD_DATE                                                  ";
            strQuery = strQuery + "         ,UPD_EMP_CD                                                 ";
            strQuery = strQuery + "         ,BEF_ACT_SMP_FL                                             ";
            strQuery = strQuery + "         ,BEF_SMP_LOC                                                ";
            strQuery = strQuery + "         ,BEF_ACT_SMP_LEN                                            ";
            strQuery = strQuery + "         ,BEF_SMP_NO                                                 ";
            strQuery = strQuery + "         ,''                                                         ";
            strQuery = strQuery + "         ,''                                                         ";
            strQuery = strQuery + "         ,SPECIAL_OPR_REQ                                            ";
            strQuery = strQuery + " FROM (                                                              ";

            strQuery = strQuery + "  SELECT 0                                          CHK              ";
            strQuery = strQuery + "         ,A.PLATE_NO                                MATA_NO          ";
            strQuery = strQuery + "         ,A.PROD_CD                                 PROD_CD          ";
            strQuery = strQuery + "         ,A.OUT_SHEET_NO                            LOT_NO           ";
            strQuery = strQuery + "         ,(SELECT N.MARK_DATA10 FROM EP_PLATE_INS3 N WHERE N.SLAB_NO = A.SLAB_NO AND ROWNUM =1)  MARK_DATA10          ";
            strQuery = strQuery + "         ,A.TRNS_CMPY_CD                            MOCUT_NO         ";
            strQuery = strQuery + "         ,A.PROC_CD                                 PROC_CD          ";
            strQuery = strQuery + "         ,A.THK                                     THK              ";
            strQuery = strQuery + "         ,A.WID                                     WID              ";
            strQuery = strQuery + "         ,A.LEN                                     LEN              ";
            strQuery = strQuery + "         ,A.WGT                                     WGT              ";
            strQuery = strQuery + "         ,A.ORD_FL                                  ORD_FL           ";
            strQuery = strQuery + "         ,A.ORD_NO                                  ORD_NO           ";
            strQuery = strQuery + "         ,A.ORD_ITEM                                ORD_ITEM         ";
            strQuery = strQuery + "         ,A.SMP_FL                                  SMP_FL           ";
            strQuery = strQuery + "         ,DECODE(A.SMP_FL,'N',0,A.SMP_LEN)          SMP_LEN          ";
            strQuery = strQuery + "         ,A.ACT_SMP_FL                              ACT_SMP_FL       ";
            strQuery = strQuery + "         ,A.SMP_LOC                                 SMP_LOC          ";
            strQuery = strQuery + "         ,A.ACT_SMP_LEN                             ACT_SMP_LEN      ";
            strQuery = strQuery + "         ,A.SMP_NO                                  SMP_NO           ";
            strQuery = strQuery + "         ,A.APLY_STDSPEC                            STD_SPEC         ";
            strQuery = strQuery + "         ,A.BEF_APLY_STDSPEC                        BEF_STDSPEC      ";
            //strQuery = strQuery & "         ,GF_INSPPLATE_DEFECT_M(A.PLATE_NO)         DEFECT           " & vbCrLf
            strQuery = strQuery + "         ,GF_COMNNAMEFIND('G0002',I.INSP_T_FLAW)    INSP_T_FLAW      ";
            strQuery = strQuery + "         ,GF_COMNNAMEFIND('G0002',I.INSP_T_FLAW)    INSP_B_FLAW      ";
            strQuery = strQuery + "         ,GF_COMNNAMEFIND('G0002',I.INSP_T_FLAW)    INSP_B_DEP_FLAW2 ";
            strQuery = strQuery + "         ,GF_COMNNAMEFIND('G0002',I.INSP_T_FLAW)    INSP_T_DEP_FLAW2 ";
            strQuery = strQuery + "         ,GF_CUSTNAMEFIND(A.CUST_CD)                CUST_NAME        ";
            strQuery = strQuery + "         ,A.PROD_DATE                               PROD_DATE        ";
            strQuery = strQuery + "         ,A.UPD_EMP_CD                              UPD_EMP_CD       ";
            strQuery = strQuery + "         ,A.ACT_SMP_FL                              BEF_ACT_SMP_FL   ";
            strQuery = strQuery + "         ,A.SMP_LOC                                 BEF_SMP_LOC      ";
            strQuery = strQuery + "         ,A.ACT_SMP_LEN                             BEF_ACT_SMP_LEN  ";
            strQuery = strQuery + "         ,A.SMP_NO                                  BEF_SMP_NO       ";
            strQuery = strQuery + "         ,B.SPECIAL_OPR_REQ                         SPECIAL_OPR_REQ  ";
            strQuery = strQuery + "   FROM  GP_PLATE A,GP_INSPPLATE  I,BP_ORDER_ITEM  B                 ";
            strQuery = strQuery + "   WHERE (A.REC_STS          =     '2')     AND                      ";
            strQuery = strQuery + "         (A.PRC_LINE        <=     '2')     AND                      ";
            strQuery = strQuery + "         (A.PROD_CD          =     'PP')    AND                      ";
            strQuery = strQuery + "         (A.PLT              =     'C3')    AND                      ";
            strQuery = strQuery + "         (NVL(A.HTM_METH1,'H')   = 'H' )    AND                      ";
            strQuery = strQuery + "         A.PLATE_NO          =     I.MAT_NO(+)    AND                ";
            strQuery = strQuery + "         A.ORD_NO                =   B.ORD_NO    AND                 ";
            strQuery = strQuery + "         A.ORD_ITEM              =   B.ORD_ITEM  AND                 ";

            strQuery_H = strQuery;

            intCount = 0;

            {
                for (intRow = 1; intRow <= ss1.ActiveSheet.RowCount; intRow++)
                {

                    if (ss1.ActiveSheet.RowHeader.Cells[intRow - 1, 0].Text == "选择")
                    {

                        intCol = 0;

                        if (intCount == 0)
                        {
                            if (TXT_PROD_CD.Text == "SL")
                            {
                                intCol = 0;
                            }
                            else
                            {
                                intCol = 1;
                            }
                            txt_charge_no.Text = ss1.ActiveSheet.Cells[intRow - 1, intCol].Text;
                            intCol = 0;
                            strQuery_L = strQuery_H + " ( A.PLATE_NO  LIKE  '" + ss1.ActiveSheet.Cells[intRow - 1, intCol].Text + "'|| '%'  )) ";
                        }
                        else
                        {
                            strQuery_L = strQuery_L + "  UNION ALL " + strQuery_H;
                            strQuery_L = strQuery_L + " ( A.PLATE_NO  LIKE  '" + ss1.ActiveSheet.Cells[intRow - 1, intCol].Text + "'|| '%'  )) ";
                        }
                        intCount = intCount + 1;

                    }
                }

            }

            strQuery_L = strQuery_L + "    ORDER BY MATA_NO                                              ";

            sLoopChk = "**";
            if (intCount > 0)
            {
                if (SpreadCommon.Gf_Sp_Display(GeneralCommon.M_CN1, ss2, strQuery_L, (Collection)Sc2["pColumn"], false))
                {
                    Sample_No_Edit();
                    sLoopChk = "";
                    ss2_set_check();
                }
            }
            sLoopChk = "";

        }

        private void CGD2041C_Load(object sender, EventArgs e)
        {

            base.sSvrPgmPkgName = "CGD2041NC";

            Form_Define();

            SDT_PROD_DATE.RawDate = Gf_DTSet("D", "");

            opt_Product2.Checked = true;
            opt_Product2.ForeColor = Color.Red;

            bCheck = false;


        }

        public override bool Form_Cls()
        {

            string sProd_cd;
            sProd_cd = TXT_PROD_CD.Text;
            TextClear();
            bCheck = false;
            base.Form_Cls();
            TXT_PROD_CD.Text = sProd_cd;
            return true;

        }



        public void TextClear()
        {
            txt_SMP_NO.Text = "";
            txt_SMP_LEN.Text = "";
            txt_SMP_LOC.Text = "";
            txt_SMP_LOC_NAME.Text = "";
            txt_CHG_SMP_NO.Text = "";
            txt_CHG_STDSPEC.Text = "";

        }

        public override void Form_Ref()
        {

            ////p_Ref框架会调用此方法，此处注掉，如有需要再开启
            //if (SpreadCommon.Gf_Sp_ProceExist(ss2, true))
            //    return;

            if (txt_charge_no.Text.Trim() == "" & SDT_PROD_DATE.RawDate == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请输入查询号还是生产开始日期！！！", "I", "提示");
                return;
            }

            if (p_Ref(1, 1, true, false))
            {
                TextClear();
                bCheck = false;
            }
            ss2.ActiveSheet.RowCount = 0;
        }

        public override void Form_Pro()
        {
            int intRow;
            int iDR;
            int iChgCnt;
            int iCnt;
            string sSpec;
            string sStdspec;
            string sBefStdspec;
            string sCharge_no;

            iCnt = 0;
            iChgCnt = 0;

            {
                for (iDR = 1; iDR <= ss2.ActiveSheet.RowCount; iDR++)
                {
                    if (ss2.ActiveSheet.Cells[iDR - 1, SS2_PROC_CD].Text != "XAC" & ss2.ActiveSheet.Cells[iDR - 1, SS2_PROC_CD].Text != "XAF")
                    {

                        sStdspec = ss2.ActiveSheet.Cells[iDR - 1, SS2_STDSPEC].Text;
                        sBefStdspec = ss2.ActiveSheet.Cells[iDR - 1, SS2_BEF_STDSPEC].Text;

                        if (sBefStdspec != "" & sStdspec != sBefStdspec & (ExpoCheck(sBefStdspec) & !ExpoCheck(sStdspec)))
                        {
                            iChgCnt = iChgCnt + 1;
                            break; // TODO: might not be correct. Was : Exit For
                        }

                    }
                }

                for (iDR = 1; iDR <= ss2.ActiveSheet.RowCount; iDR++)
                {
                    if (ss1.ActiveSheet.RowHeader.Cells[iDR - 1, 0].Text == "修改")
                    {
                        sSpec = ss2.ActiveSheet.Cells[iDR - 1, SS2_STDSPEC].Text;
                        if (txt_CHG_SMP_NO.Text == "" | txt_CHG_STDSPEC.Text == "")
                        {
                            if (ExpoCheck(sSpec))
                            {
                                GeneralCommon.Gp_MsgBoxDisplay("必须输入(" + txt_CHG_SMP_NO.Tag + "与" + txt_CHG_STDSPEC.Tag + ")", "I", "提示");
                                return;
                            }
                        }

                        if (iChgCnt == 0)
                        {
                            ss2.ActiveSheet.Cells[iDR - 1, SS2_CHG_SMP_NO].Text = txt_CHG_SMP_NO.Text;
                            ss2.ActiveSheet.Cells[iDR - 1, SS2_CHG_STDSPEC].Text = txt_CHG_STDSPEC.Text;
                            iChgCnt = 1;
                        }
                    }
                }
            }

            if (p_Pro(2, 2, true, false))
            {
                sCharge_no = txt_charge_no.Text;
                txt_charge_no.Text = "";
                Form_Ref();
                txt_charge_no.Text = sCharge_no;
            }

        }

        private void SDT_PROD_DATE_Clk()
        {
            SDT_PROD_DATE.RawDate = Gf_DTSet("", "D");
        }

        private void ss1_DblClk(int col, int row)
        {
            int intRow;
            string sLot_no;
            string sSelect;

            if (ss1.ActiveSheet.RowCount <= 0)
                return;
            if (SpreadCommon.Gf_Sp_ProceExist(ss2, true))
                return;

            {
                for (intRow = 1; intRow <= ss1.ActiveSheet.RowCount; intRow++)
                {
                    ss1.ActiveSheet.RowHeader.Cells[intRow - 1, 0].Text = "";
                    SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, intRow - 1, intRow - 1, Color.Black, Color.White);
                }

                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "选择";
                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, ColorTranslator.FromHtml("#80ffff"));

                ss2.ActiveSheet.RowCount = 0;
                txt_SLAB_NO.Text = ss1.ActiveSheet.Cells[row, 0].Text;
                sLot_no = ss1.ActiveSheet.Cells[row, 1].Text; ;

                sLoopChk = "**";
                if (p_Ref(2, 2, true, false))
                {
                    TextClear();
                    Sample_No_Edit();
                    if (TXT_PROD_CD.Text == "SL")
                    {
                        txt_charge_no.Text = ss1.ActiveSheet.Cells[row, 0].Text;
                    }
                    else
                    {
                        txt_charge_no.Text = ss1.ActiveSheet.Cells[row, 1].Text;
                    }
                    bCheck = true;
                }
                sLoopChk = "";
                for (intRow = 1; intRow <= ss1.ActiveSheet.RowCount; intRow++)
                {
                    sSelect = ss1.ActiveSheet.RowHeader.Cells[intRow - 1, 0].Text;
                    if (sLot_no == ss1.ActiveSheet.Cells[intRow - 1, 1].Text & sLot_no.Length == 14 & sSelect == "")
                    {
                        ss1_Clk(0, intRow - 1);
                    }
                }
            }

        }

        private void Sample_No_Edit()
        {

            int intRow;
            string sPlateNo;
            string sStdspec;
            string sBefStdspec;
            string sSmpFl;
            string sSmpNo;
            string sProdCd;
            string sSmp_No;

            if (ss2.ActiveSheet.RowCount <= 0)
                return;

            {
                for (intRow = 1; intRow <= ss2.ActiveSheet.RowCount; intRow++)
                {

                    sStdspec = ss2.ActiveSheet.Cells[intRow - 1, SS2_STDSPEC].Text;
                    sBefStdspec = ss2.ActiveSheet.Cells[intRow - 1, SS2_BEF_STDSPEC].Text;
                    sPlateNo = ss2.ActiveSheet.Cells[intRow - 1, SS2_PLATE_NO].Text;
                    sSmpFl = ss2.ActiveSheet.Cells[intRow - 1, SS2_SMP_FLAG].Text;
                    sSmpNo = ss2.ActiveSheet.Cells[intRow - 1, SS2_SMP_NO].Text;
                    sProdCd = ss2.ActiveSheet.Cells[intRow - 1, SS2_PROD_CD].Text;

                    if (sProdCd == "PP")
                    {
                        sSmp_No = "00";
                    }
                    else
                    {
                        sSmp_No = "99";
                    }

                    if (txt_SMP_NO.Text == "")
                    {
                        if (sSmpFl != "" & sSmpNo.Substring(sSmpNo.Length - 2, 2) != sSmp_No)
                        {
                            txt_SMP_NO.Text = sSmpNo;
                        }
                        else
                        {
                            if ((txt_SMP_NO.Text.Length != 14 & sProdCd == "PP") | (txt_SMP_NO.Text.Length != 12 & sProdCd == "HC"))
                            {
                                txt_SMP_NO.Text = sPlateNo;
                            }
                        }
                    }

                    if (ExpoCheck(sBefStdspec) | ExpoCheck(sStdspec))
                    {
                        if (sSmpFl != "" & sSmpNo != txt_SMP_NO.Text)
                        {
                            //                        txt_CHG_SMP_NO.Text = sSmpNo
                            txt_CHG_STDSPEC.Text = sStdspec;
                        }
                        else
                        {
                            if (sBefStdspec != "" & sStdspec != sBefStdspec)
                            {
                                txt_CHG_STDSPEC.Text = sStdspec;
                            }
                        }

                        if (sProdCd == "PP")
                        {
                            txt_CHG_SMP_NO.Text = txt_SMP_NO.Text.Substring(0, 12) + sSmp_No;
                        }
                        else
                        {
                            txt_CHG_SMP_NO.Text = txt_SMP_NO.Text.Substring(0, 10) + sSmp_No;
                        }
                    }
                }
            }
        }

        private void ss1_Clk(int col, int row)
        {
            long PRE;
            int iDR;
            string sSpec;
            long iSelCnt;
            string sCharNo;

            

            if (ss1.ActiveSheet.RowCount <= 0)
                return;

            sSpec = ss1.ActiveSheet.Cells[row, SS1_STLGRD].Text;
            sCharNo = ss1.ActiveSheet.Cells[row, 0].Text.Substring(0, 8);

            iSelCnt = 0;
            for (iDR = 1; iDR <= ss1.ActiveSheet.RowCount; iDR++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iDR - 1, 0].Text == "选择")
                {
                    //            ss1.Col = 1
                    //            If sCharNo <> Left(Trim(ss1.Text), 8) Then
                    //                Call Gp_MsgBoxDisplay("不一样炉号")
                    //                Exit Sub
                    //            End If
                    if (sSpec != ss1.ActiveSheet.Cells[iDR - 1, SS1_STLGRD].Text)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("钢种不一致，请确认", "I", "提示");
                        return;
                    }
                    iSelCnt = iSelCnt + 1;
                }
            }

            sLoopChk = "**";

            if (ss1.ActiveSheet.RowHeader.Cells[row, 0].Text != "选择")
            {
                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "选择";
                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, ColorTranslator.FromHtml("#80ffff"));
            }
            else
            {
                if (SpreadCommon.Gf_Sp_ProceExist(ss2, true))
                    return;

                ss1.ActiveSheet.RowHeader.Cells[row, 0].Text = "";
                SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, row, row, Color.Black, Color.White);

                if (iSelCnt < 2)
                {
                    ss2.ActiveSheet.RowCount = 0;
                }
                else
                {
                    Cmd_Set_Save_Clk();
                }

            }

            iSelCnt = 0;
            for (iDR = 1; iDR <= ss1.ActiveSheet.RowCount; iDR++)
            {
                if (ss1.ActiveSheet.RowHeader.Cells[iDR - 1, 0].Text == "选择")
                {
                    iSelCnt = iSelCnt + 1;
                }
            }

            if (iSelCnt == 0)
                TextClear();
            sLoopChk = "";

        }

        private void ss2_ButtonClk(int col, int row)
        {

            string strSmpNO;
            string sSmpFlag;
            string sSmpLoc;
            string lSmpLen;
            string sSmpNo;
            string sStdspec;
            string sBefStdspec;
            string sSmpFl;
            string sProdCd;
            string sSmp_No;
            int iDR;

            if (ss2.ActiveSheet.RowCount <= 0 | sLoopChk.Trim() != "")
                return;

            sSmpFl = "";

            {
                if (ss2.ActiveSheet.Cells[row, SS2_PROC_CD].Text.Substring(0, 1) == "X")
                {
                    return;
                }

                sLoopChk = "**";


                if (ss2.ActiveSheet.Cells[row, col].Text == "True")
                {
                    //            For iDr = 1 To .MaxRows
                    //                .Row = iDr

                    if (ss2.ActiveSheet.Cells[row, SS2_PROC_CD].Text != "X")
                    {
                        ss2.ActiveSheet.Cells[row, 0].Value = 1;

                        if (txt_SMP_LOC.Text.Length == 1)
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_LOC].Text = txt_SMP_LOC.Text;
                        }
                        if (txt_SMP_LEN.Text.Length > 0)
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_LEN].Text = txt_SMP_LEN.Text;
                        }

                        sStdspec = ss2.ActiveSheet.Cells[row, SS2_STDSPEC].Text;
                        sBefStdspec = ss2.ActiveSheet.Cells[row, SS2_BEF_STDSPEC].Text;
                        sProdCd = ss2.ActiveSheet.Cells[row, SS2_PROD_CD].Text;

                        if (sProdCd == "PP")
                        {
                            sSmp_No = "00";
                        }
                        else
                        {
                            sSmp_No = "99";
                        }

                        if (sBefStdspec != "" & sStdspec != sBefStdspec & (ExpoCheck(sBefStdspec) & !ExpoCheck(sStdspec)))
                        {
                            if ((txt_CHG_SMP_NO.Text.Length == 14 & sProdCd == "PP") | (txt_CHG_SMP_NO.Text.Length == 12 & sProdCd == "HC"))
                            {
                                ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text = txt_CHG_SMP_NO.Text;
                            }
                        }
                        else
                        {
                            if ((txt_SMP_NO.Text.Length == 14 & sProdCd == "PP") | (txt_SMP_NO.Text.Length == 12 & sProdCd == "HC"))
                            {
                                ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text = txt_SMP_NO.Text;
                            }
                        }

                        //                    .Row = iDr
                        ss2.ActiveSheet.RowHeader.Cells[row, 0].Text = "修改";
                        ss2.ActiveSheet.Cells[row, SS2_USER_ID].Text = GeneralCommon.sUserID;
                        strSmpNO = ss2.ActiveSheet.Cells[row, SS2_PLATE_NO].Text;

                        if (strSmpNO == ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text)
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = "Y";
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Red;
                        }
                        else
                        {
                            if (sSmpFl == "P" & strSmpNO != txt_SMP_NO.Text & (ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text.Substring(12, 2) == "00" | ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text.Substring(12, 2) == "99"))
                            {
                                ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = sSmpFl;
                                ss2.ActiveSheet.Cells[row, SS2_SMP_LEN].Text = "0";

                                // ss2.Col = SS2_SMP_FLAG;
                                // ss2.Col2 = SS2_SMP_NO;
                                // ss2.ROW = ROW;
                                // ss2.Row2 = ROW;
                                // //                            .Row = iDr:             .Row2 = iDr

                                // ss2.BlockMode = true;
                                // ss2.Lock = true;
                                // ss2.BlockMode = false;
                                // sSmpFl = "";
                            }

                            if (ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text != "P")
                            {
                                ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = "N";
                                ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Black;
                                ss2.ActiveSheet.Cells[row, SS2_SMP_LEN].Text = "0";
                            }
                            else
                            {
                                ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Red;
                            }
                        }

                        if (strSmpNO == txt_SMP_NO.Text & (ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text.Substring(12, 2) == "00" | ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text.Substring(12, 2) == "99"))
                        {
                            sSmpFl = "P";
                        }
                    }
                    //            Next iDr
                }
                else
                {
                    for (iDR = 1; iDR <= ss2.ActiveSheet.RowCount; iDR++)
                    {
                        ss2.ActiveSheet.Cells[iDR - 1, 0].Value = 0;

                        ss2.ActiveSheet.RowHeader.Cells[iDR - 1, 0].Text = "";
                        sSmpFlag = ss2.ActiveSheet.Cells[iDR - 1, SS2_BEF_SMP_FLAG].Text;
                        sSmpLoc = ss2.ActiveSheet.Cells[iDR - 1, SS2_BEF_SMP_LOC].Text;
                        lSmpLen =ss2.ActiveSheet.Cells[iDR - 1, SS2_BEF_SMP_LEN].Text;
                        sSmpNo = ss2.ActiveSheet.Cells[iDR - 1, SS2_BEF_SMP_NO].Text;

                        ss2.ActiveSheet.Cells[iDR - 1, SS2_SMP_FLAG].Text = sSmpFlag;
                        ss2.ActiveSheet.Cells[iDR - 1, SS2_SMP_LOC].Text = sSmpLoc;
                        ss2.ActiveSheet.Cells[iDR - 1, SS2_SMP_LEN].Text = lSmpLen;
                        ss2.ActiveSheet.Cells[iDR - 1, SS2_SMP_NO].Text = sSmpNo;
                    }
                }
            }
            sLoopChk = "";


        }


        private void ss2_EditMode(int col, int row)
        {
            int intCheck;
            string strSmpNO;
            string strOrginSmpNO;
            string sSmpNo;

            if (ss2.ActiveSheet.RowCount <= 0)
                return;

            if (row >= 0)
            {
                ss2.ActiveSheet.RowHeader.Cells[row, 0].Text = "修改";

                if (ss2.ActiveSheet.Cells[row, 0].Text != "True")
                {
                    ss2.ActiveSheet.Cells[row, 0].Value = 1;
                    
                    //return;
                }

                if (col == SS2_SMP_FLAG)
                {
                    ss2.ActiveSheet.Cells[row, col].Text = ss2.ActiveSheet.Cells[row, col].Text.ToUpper();
                    strSmpNO = ss2.ActiveSheet.Cells[row, SS2_PLATE_NO].Text.ToUpper();
                    if (strSmpNO == ss2.ActiveSheet.Cells[row, SS2_SMP_NO].Text)
                    {
                        //ss2.Col = SS2_SMP_FLAG;
                        //ss2.Text = "Y" Modified By YangMeng At 2006.06.01
                        ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Red;
                    }
                    else
                    {
                        if (ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text != "P")
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = "N";
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Black;
                            ss2.ActiveSheet.Cells[row, SS2_SMP_LEN].Text = "0";
                        }
                    }
                }
                else if (col == SS2_SMP_LOC)
                {
                    ss2.ActiveSheet.Cells[row, col].Text = ss2.ActiveSheet.Cells[row, col].Text.ToUpper();
                    switch (ss2.ActiveSheet.Cells[row, col].Text)
                    {
                        case "M":
                        case "B":
                        case "T":
                            break;
                        default:
                            ss2.ActiveSheet.Cells[row, col].Text = "T";
                            break;
                    }
                }
                else if (col == SS2_SMP_NO)
                {
                    strSmpNO = ss2.ActiveSheet.Cells[row, SS2_PLATE_NO].Text;
                    //Or Left(ss2.Text, 8) <> Left(strSmpNO, 8) Then 'Modified By YangMeng At 2007.03.29
                    if (ss2.ActiveSheet.Cells[row, col].Text.Length != strSmpNO.Length)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("试样号错误", "I", "提示");
                        sSmpNo = ss2.ActiveSheet.Cells[row, SS2_BEF_SMP_NO].Text;
                        ss2.ActiveSheet.Cells[row, col].Text = sSmpNo;
                    }

                    if (strSmpNO == ss2.ActiveSheet.Cells[row, col].Text)
                    {
                        ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = "Y";
                        ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Red;
                    }
                    else
                    {
                        if (ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text != "P")
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].Text = "N";
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Black;
                            ss2.ActiveSheet.Cells[row, SS2_SMP_LEN].Text = "0";
                        }
                        else
                        {
                            ss2.ActiveSheet.Cells[row, SS2_SMP_FLAG].ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        public bool ExpoCheck(string sSpec) {


            sQuery = "SELECT  Gf_Expo_Smp_Check('" + sSpec + "')";
            sQuery = sQuery + "       FROM  DUAL ";

            int iCnt;

            iCnt = 0;


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return false;


            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF) {
                    //RltValue = true;
                    while (!AdoRs.EOF) {
                        iCnt = Convert.ToInt32(AdoRs.Fields[0].Value);
                        AdoRs.MoveNext();
                    }
                }

                //关闭对象要注意不可以是在整个查询中，会影响其它数据读取 韩超

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                if (iCnt > 0) {
                    return true;
                } else {
                    return false;
                }

                return false;
            } catch (Exception ex) {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return false;
            }

        }

        private void txt_SMP_LOC_Chg()
        {
            txt_SMP_LOC.Text = txt_SMP_LOC.Text.ToUpper();
            switch (txt_SMP_LOC.Text)
            {
                case "M":
                    txt_SMP_LOC_NAME.Text = "中部";
                    break;
                case "T":
                    txt_SMP_LOC_NAME.Text = "头部";
                    break;
                case "B":
                    txt_SMP_LOC_NAME.Text = "尾部";
                    break;
                default:
                    txt_SMP_LOC_NAME.Text = "";
                    txt_SMP_LOC.Text = "";
                    break;
            }
        }

        private void ss2_set_check()
        {
            int intRow;
            string strSmpNO;

            if (ss2.ActiveSheet.RowCount <= 0)
                return;

            for (intRow = 1; intRow <= ss2.ActiveSheet.RowCount; intRow++)
            {
                if (ss2.ActiveSheet.Cells[intRow - 1, SS2_PROC_CD].Text != "X")
                {
                    ss2.ActiveSheet.Cells[intRow - 1, 0].Value = 1;
                }
            }
        }

        private void txt_SMP_NO_Chg()
        {
            int iDR;
            if (ss2.ActiveSheet.RowCount <= 0)
                return;

            if (txt_SMP_NO.Text.Length == 14)
            {
                if (txt_CHG_SMP_NO.Text != "")
                {
                    txt_CHG_SMP_NO.Text = txt_SMP_NO.Text.Substring(0, 12) + "00";
                }
            }

            for (iDR = 1; iDR <= ss2.ActiveSheet.RowCount; iDR++)
            {
                ss2.ActiveSheet.Cells[iDR - 1, 0].Value = 0;
            }
        }

        private void opt_Product_Click()
        {
            if (opt_Product1.Checked)
            {
                TXT_PROD_CD.Text = "SL";
                opt_Product1.ForeColor = Color.Red;
                opt_Product2.ForeColor = Color.Black;
            }
            else
            {
                TXT_PROD_CD.Text = "LO";
                opt_Product2.ForeColor = Color.Red;
                opt_Product1.ForeColor = Color.Black;
            }
        }


        #region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            sDTChk = "M";
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 10));
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 16));
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 19));
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 8))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {

            if (DTCheck == "D")
            {
                DTCheck = "D";
            }
            else
            {
                DTCheck = "S";
            }
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        public void lockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = true;
            }
        }

        #endregion

        private void Cmd_Set_Save_Click(object sender, EventArgs e)
        {
            Cmd_Set_Save_Clk();
        }

        private void SDT_PROD_DATE_Click(object sender, EventArgs e)
        {
            SDT_PROD_DATE_Clk();
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (!e.RowHeader) return;
            ss1_Clk(e.Column, e.Row);
        }

        private void ss2_ButtonClicked(object sender, EditorNotifyEventArgs e)
        {
            ss2_ButtonClk(e.Column, e.Row);
        }

        private void ss2_EditChange(object sender, EditorNotifyEventArgs e)
        {
            ss2_EditMode(e.Column, e.Row);
        }

        private void txt_SMP_NO_TextChanged(object sender, EventArgs e)
        {
            txt_SMP_NO_Chg();
        }

        private void txt_SMP_LOC_TextChanged(object sender, EventArgs e)
        {
            txt_SMP_LOC_Chg();
        }

        private void opt_Product1_TextChanged(object sender, EventArgs e)
        {
            opt_Product_Click();
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (e.Column != SS2_SMP_FLAG && e.Column != SS2_SMP_LOC && e.Column != SS2_SMP_LEN && e.Column != SS2_SMP_NO) return;
            ss2_EditMode(e.Column, e.Row);
        }


    }
}
