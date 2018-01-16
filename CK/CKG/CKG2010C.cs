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

///-------------------------------------------------------------------------------
///-- 程序头注释 +++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
///-------------------------------------------------------------------------------
///-- 系统名            中板生产管制系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            轧钢作业指示调整下达界面                              
///-- 程序ID            CKG2010C    
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              韩超                                                    
///-- 代码              韩超                                                    
///-- 代码日期          2018.01.12                                               
///-- 处理描述          指示调整
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2018.01.12        韩超                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CK
{
    public partial class CKG2010C : CommonClass.FORMBASE
    {
        public CKG2010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();

        const int SS1_PRC_STS = 4;
        const int SS1_SLAB_NO = 5;
        const int SS1_OVER_FL = 10;
        const int SS1_PROD_DATE = 19;
        const int SS1_ORD_NO = 23;
        const int SS1_HCR_FL = 28;
        const int SS1_RH = 43;
        //20130326 LICHAO
        const int SS1_L2_SEND = 51;
        const int SS1_ORD_CNT = 56;
        const int SS1_SLAB_EDT_SEQ = 58;
        const int SS1_URGNT_FL = 59;
        //紧急订单
        const int SS1_DATE = 70;
        //当前时间
        const int SS1_SMP_DOTE1 = 21;
        //可装炉时间
        const int SS3_MP_NO = 1;
        const int SS3_SLAB_EDT_SEQ = 7;
        const int SS3_MPLATE_EDT_SEQ = 8;

        string sSlab_Edt_Seq_Fr = "";
        string sSlab_Edt_Seq_To = "";
        string sSlab_Edt_Seq_Tg = "";

        string Mode = "";              // 

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLT, "PNR", "", "", "", imcseq, "");  //
            p_SetMc(SDB_SLAB_EDT_SEQ, "PR", "", "", "", imcseq, "");      // 

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc(SDB_SLAB_EDT_SEQ, "PR", "", "", "", imcseq, "");  //

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc(SDB_SLAB_EDT_SEQ, "PR", "", "", "", imcseq, "");  //
            p_SetMc(SDB_MPLATE_EDT_SEQ, "PR", "", "", "", imcseq, "");  //

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("轧制序号", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("辊期", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("辊期内板坯顺序", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("辊期内累计公里数", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("指示状态", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("钢板不平度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("测量长度1", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("钢板不平度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("测量长度2", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("板坯重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("板坯钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//15
            p_SetSc("低倍质量等级", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("处理详细内容", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//17
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");//18
            p_SetSc("浇铸时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("堆冷时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("可装炉时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("入库日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("订单号-序列", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("客户代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("欠量（上限）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("欠量（下限）", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("当前位置", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("HCR分类", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//28
            p_SetSc("加热炉座号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("出炉温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("宽度余量", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("目标厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("T1厚度比", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("目标宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("轧件长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("产品厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//36
            p_SetSc("产品宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("产品长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//38
            p_SetSc("设计成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//39
            p_SetSc("实设成材率", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("成材率差", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("板坯是否走真空", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("热处理方法", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//45
            p_SetSc("控轧代码", "E", "20", "L", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("控轧厚度比", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("控轧温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//48
            p_SetSc("终轧温度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//49
            p_SetSc("冷却率", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("是否下达", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//51
            p_SetSc("计划编制时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//52
            p_SetSc("是否定尺", "C", "", "L", "", "", "", iscseq, iheadrow, "M");//53
            p_SetSc("交货期开始", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//54
            p_SetSc("交货期结束", "D", "", "L", "", "", "", iscseq, iheadrow, "M");//55
            p_SetSc("订单数量", "N", "9", "L", "", "", "", iscseq, iheadrow, "M");//56
            p_SetSc("计划板坯长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//57
            p_SetSc("板坯编制号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//58
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//59
            p_SetSc("垛位号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//60
            p_SetSc("计划板坯缓冷时间", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "M");//61
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//62
            p_SetSc("客户代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//63
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//64
            p_SetSc("宽度差", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//65
            p_SetSc("订单备注", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//66
            p_SetSc("质量异议", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//67
            p_SetSc("超量排产标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//68
            p_SetSc("订单特殊要求", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//69
            p_SetSc("当前时间", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//70



            p_ScIni(ss3, Sc3, 0, false, false);
            iheadrow = 0;
            iscseq = 2;
            //0-5
            p_SetSc("剪切序列号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("母板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("冷床目标温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("切边代码", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("板坯编制号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//7
            p_SetSc("母板编制号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//8

            SpreadCommon.Gp_Sp_ColHidden(ss3, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss3, 8, true);

            p_ScIni(ss4, Sc4, 0, false, false);
            iheadrow = 0;
            iscseq = 3;
            //0-5
            p_SetSc("剪切序列号", "E", "60", "L", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("钢板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("厚度*宽度*长度", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("重量", "N", "9,3", "L", "", "", "", iscseq, iheadrow, "R");//3
            p_SetSc("UST", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("取样代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("取样长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R");//7

        }

        private void CKG2010C_Load(object sender, EventArgs e)
        {
            Form_Define();
            base.sSvrPgmPkgName = "CKG2010NC";
            TXT_PLT.Text = "C3";

            opt_from.Enabled = false;
            opt_to.Enabled = false;
            opt_target.Enabled = false;
            txt_search_slabno.Text = "检索板坯号";

            TXT_PLT.Text = "C3";
            opt_sent.Checked = false;
            opt_cancel.Checked = false;
            opt_move.Checked = false;
            opt_delete.Checked = false;
            opt_return.Checked = false;
            opt_from.Checked = false;
            opt_to.Checked = false;
            opt_target.Checked = false;
            opt_from.Enabled = false;
            opt_to.Enabled = false;
            opt_target.Enabled = false;
            opt_sent.ForeColor = Color.Black;
            opt_move.ForeColor = Color.Black;
            opt_delete.ForeColor = Color.Black;
            opt_return.ForeColor = Color.Black;
            opt_cancel.ForeColor = Color.Black;
            opt_from.ForeColor = Color.Black;
            opt_to.ForeColor = Color.Black;
            opt_target.ForeColor = Color.Black;
            txt_from.Text = "";
            from_y.Text = "";
            txt_to.Text = "";
            to_y.Text = "";
            txt_target.Text = "";
            target_y.Text = "";
            TXT_MPLATE_NO.Text = "";
            sSlab_Edt_Seq_Fr= "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";

        }

        private void cmd_abnormal_send_Click(object sender, EventArgs e)
        {
            if (txt_to.Text.Trim() != "")
            {
                if (GeneralCommon.Gf_MessConfirm("确定要强制下达到 '" + txt_to.Text + "' 的作业指示吗？", "Q", "指示下达确定"))
                {
                    if (Gp_Process_Exec("A") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("作业指示下达完毕 ！", "I", this.Text);
                        Form_Ref();
                    }
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请选择要强制下达的板坯号 ！", "I", this.Text);
                }
            }
        }



        public override void Form_Ref()
        {
            string sTemp;
            string sL2_Send;
            string sSlab_No;
            string sPrc_Sts;
            string sProd_Date;
            string sHcr_Fl;
            int iOrd_cnt;
            int iRow;
            int iCol;
            Color cBackColor;
            string sUrgnt_Fl;
            string sOVER_FL;

            string sSmpdote;
            string sDate;

            if (p_Ref(1, 1, false, false))
            {
                SpreadCommon.Gf_Sp_Cls(Sc3);
                SpreadCommon.Gf_Sp_Cls(Sc4);

                sSlab_Edt_Seq_Fr = "0";
                sSlab_Edt_Seq_To = "0";
                sSlab_Edt_Seq_Tg = "0";

            }

            for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
            {

                sSlab_No = ss1.ActiveSheet.Cells[iRow - 1, SS1_SLAB_NO].Text.Trim();
                sL2_Send = ss1.ActiveSheet.Cells[iRow - 1, SS1_L2_SEND].Text.Trim();
                sPrc_Sts = ss1.ActiveSheet.Cells[iRow - 1, SS1_PRC_STS].Text.Trim();
                iOrd_cnt = convertI(ss1.ActiveSheet.Cells[iRow - 1, SS1_ORD_CNT].Text.Trim());
                sProd_Date = ss1.ActiveSheet.Cells[iRow - 1, SS1_PROD_DATE].Text.Trim();
                sHcr_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_HCR_FL].Text.Trim();
                sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text.Trim();
                sOVER_FL = ss1.ActiveSheet.Cells[iRow - 1, SS1_OVER_FL].Text.Trim();

                sSmpdote = ss1.ActiveSheet.Cells[iRow - 1, SS1_SMP_DOTE1].Text.Trim();
                sDate = ss1.ActiveSheet.Cells[iRow - 1, SS1_DATE].Text.Trim();


                if (sPrc_Sts == "B")
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSPpdt.BackColor);


                }
                else
                {
                    if (sL2_Send == "Y")
                    {
                        Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSPsend.BackColor);
                    }
                }

                if (iOrd_cnt > 1)
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSOrd.BackColor);
                }

                cBackColor = ss1.ActiveSheet.Cells[iRow - 1, 0].BackColor;

                if (sProd_Date == "" && sHcr_Fl == "H")
                {

                    Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, Color.Red, cBackColor);
                }
                //紧急订单绿色显示 add by liqian 2012-08-16
                if (sUrgnt_Fl == "Y")
                {
                    Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, Color.Green, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_ORD_NO, SS1_ORD_NO, iRow - 1, iRow - 1, Color.Green, Color.White);
                    Gp_Sp_BlockColor(ss1, SS1_URGNT_FL, SS1_URGNT_FL, iRow - 1, iRow - 1, Color.Green, Color.White);
                }

                if (sOVER_FL != "")
                {
                    Gp_Sp_BlockColor(ss1, SS1_OVER_FL, SS1_OVER_FL, iRow - 1, iRow - 1, Color.Red, Color.White);
                }

                if (convertX(sDate) < convertX(sSmpdote))
                {
                    Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                }

            }
            ss1.ActiveSheet.SetActiveCell(ss1.ActiveSheet.RowCount - 1, 0);
        }

        public override void Form_Pro()
        {

            bool mResult;
            string sMsg;

            Mode = "";

            if (opt_move.Checked)
            {
                if (!((from_y.Text == "Y" & to_y.Text == "Y" & target_y.Text == "Y") || (from_y.Text == "" & to_y.Text == "" & target_y.Text == "")))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("已下达的指示和未下达的指示不能混在一起调整！", "I", "提示");
                    return;
                }
            }

            if (opt_sent.Checked)
            {

                Mode = "L";

                if (txt_to.Text != "")
                {
                    if (GeneralCommon.Gf_MessConfirm("确定要下达到 '" + txt_to.Text + "' 的作业指示吗？", "I", "指示下达确定"))
                    {
                        if (Gp_Process_Exec("") == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("作业指示下达完毕 ！", "I", "提示");
                            Form_Ref();
                        }
                    }

                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请选择目标板坯号 ！", "I", "提示");
                }

            }

            if (opt_cancel.Checked)
            {

                Mode = "C";

                if (txt_from.Text != "")
                {
                    if (GeneralCommon.Gf_MessConfirm("确定取消从'" + txt_from.Text + "'的作业指示吗？", "I", "指示取消确定"))
                    {
                        if (Gp_Process_Exec("") == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("取消指示完毕 ！", "I", "提示");
                            Form_Ref();
                        }
                    }
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请选择起始板坯号 ！", "I", "提示");
                }
            }

            if (opt_move.Checked)
            {

                Mode = "M";

                //顺序变更
                if (txt_from.Text != "" & txt_to.Text != "" & txt_target.Text != "")
                {
                    sMsg = "确定要把板坯从(" + txt_from.Text + ")->(" + txt_to.Text + ")" + "调整到板坯(" + txt_target.Text + ")后边吗？";
                }
                else
                {
                    sMsg = "必须输入起始板坯号、终止板坯号和目标板坯号！";
                    GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "提示");
                    return;
                }

                mResult = GeneralCommon.Gf_MessConfirm(sMsg, "I", "提示");

                if (mResult)
                {
                    if (Gp_Process_Exec("") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("作业指示调整完毕 ！", "I", "提示");
                        Form_Ref();
                    }
                }

            }

            if (opt_delete.Checked)
            {

                Mode = "X";

                if (txt_from.Text == "")
                {
                    sMsg = "必须输入起始板坯号！";
                    GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "提示");
                    return;
                }

                sMsg = "确定要删除选定板坯(" + txt_from.Text + ")" + ")吗？";

                if (txt_to.Text != "")
                {
                    sMsg = "确定要删除选定板坯(" + txt_from.Text + ")->(" + txt_to.Text + ")吗？";
                }

                mResult = GeneralCommon.Gf_MessConfirm(sMsg, "I", "提示");

                if (mResult)
                {
                    if (Gp_Process_Exec("") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("作业指示删除完毕 ！", "I", "提示");
                        Form_Ref();
                    }
                }
            }

            if (opt_return.Checked)
            {

                Mode = "B";

                if (txt_from.Text == "")
                {
                    sMsg = "必须输入起始板坯号！";
                    GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "提示");
                    return;
                }

                sMsg = "确定要返送选定板坯(" + txt_from.Text + ")" + ")吗？";

                if (txt_to.Text != "")
                {
                    sMsg = "确定要返送选定板坯(" + txt_from.Text + ")->(" + txt_to.Text + ")吗？";
                }

                mResult = GeneralCommon.Gf_MessConfirm(sMsg, "I", "提示");

                if (mResult)
                {
                    if (Gp_Process_Exec("") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("作业指示返送完毕 ！", "I", "提示");
                        Form_Ref();
                    }
                }
            }
        }

        private string Gp_Process_Exec(string Process_Type)
        {
            string sSlab_Seq_Fr ;
            string sSlab_Seq_To ;
            string sSlab_Seq_Tg ;

            sSlab_Seq_Fr = sSlab_Edt_Seq_Fr;
            sSlab_Seq_To = sSlab_Edt_Seq_To;
            sSlab_Seq_Tg = sSlab_Edt_Seq_Tg;

            string[] Para1 = new string[1];
            string[] Para2 = new string[3];
            string[] Para3 = new string[2];
            string[] Para4 = new string[2];
            string[] Para5 = new string[4];
            string[] Para6 = new string[6];
            string[] Para7 = new string[3];

            switch (Process_Type)
            {

                case "A":
                    Para1[0] = sSlab_Seq_To;
                    if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGG2046P", Para1))
                    {
                        return "";
                    }
                    else
                    {
                        return "作业指示强制下达失败";
                    }
                    break;
                case "R":
                    Para2[0] = "C3";
                    Para2[1] = "1";
                    Para2[2] = sSlab_Seq_Tg;
                    if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "BKG2050P", Para2))
                    {
                        return "";
                    }
                    else
                    {
                        return "辊期编制失败";
                    }
                    break;
                default:

                    switch (Mode)
                    {

                        case "L":
                            Para3[0] = "A";
                            Para3[1] = sSlab_Seq_To;
                            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGG2042P", Para3))
                            {
                                return "";
                            }
                            else
                            {
                                return "作业指示下达失败";
                            }
                            break;

                        case "C":
                            Para4[0] = sSlab_Seq_Fr;
                            Para4[1] = "M";
                            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGG2041P", Para3))
                            {
                                return "";
                            }
                            else
                            {
                                return "作业指示取消失败";
                            }
                            break;
                        case "M":
                            Para5[0] = "M";
                            Para5[1] = sSlab_Seq_Fr;
                            Para5[2] = sSlab_Seq_To;
                            Para5[3] = sSlab_Seq_Tg;
                            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGG2044P", Para5))
                            {
                                return "";
                            }
                            else
                            {
                                return "作业指示调整失败";
                            }
                            
                            break;

                        case "X":
                            Para6[0] = "X";
                            Para6[1] = "M";
                            Para6[2] = sSlab_Seq_Fr;
                            Para6[3] = sSlab_Seq_To;
                            Para6[4] = sSlab_Seq_Tg;
                            Para6[5] = GeneralCommon.sUserID;
                            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "AFZ1000P", Para6))
                            {
                                return "";
                            }
                            else
                            {
                                return "作业指示删除失败";
                            }
                            break;

                        case "B":
                            Para7[0] = "C3";
                            Para7[1] = sSlab_Seq_Fr;
                            Para7[2] = sSlab_Seq_To;
                            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "AFZ1301P", Para7))
                            {
                                return "";
                            }
                            else
                            {
                                return "作业指示返送失败";
                            }
                            break;

                    }
                    break;
            }
            return "数据错误";
        }

        private void rdo_send_Click(object sender, EventArgs e)
        {
            if (opt_sent.Checked == true)
            {
                opt_sent.ForeColor = System.Drawing.Color.Red;
                opt_cancel.ForeColor = System.Drawing.Color.Black;
                opt_move.ForeColor = System.Drawing.Color.Black;
                opt_delete.ForeColor = System.Drawing.Color.Black;
                opt_return.ForeColor = System.Drawing.Color.Black;
                rdo_from.Enabled = true;
                rdo_from.ForeColor = System.Drawing.Color.Black;
                rdo_to.Enabled = true;
                rdo_to.Checked = true;
                rdo_to.ForeColor = System.Drawing.Color.Red;
                rdo_target.Enabled = false;
            }
            else{ 
                opt_sent.ForeColor = System.Drawing.Color.Black; 
            }
            txt_from.Text = "";
            txt_to.Text = "";
            txt_target.Text = "";
    
            sSlab_Edt_Seq_Fr = "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";
        }
        private void rdo_from_Click(object sender, EventArgs e)
        {
            if (rdo_from.Checked == true)
            {
                rdo_from.ForeColor = System.Drawing.Color.Red;
                rdo_to.ForeColor = System.Drawing.Color.Black;
                rdo_target.ForeColor = System.Drawing.Color.Black;
            }
            else
                rdo_from.ForeColor = System.Drawing.Color.Black;
        }
        private void rdo_target_Click(object sender, EventArgs e)
        {
            if (rdo_target.Checked == true)
            {
                rdo_target.ForeColor = System.Drawing.Color.Red;
                rdo_from.ForeColor = System.Drawing.Color.Black;
                rdo_to.ForeColor = System.Drawing.Color.Black;
            }
            else
                rdo_target.ForeColor = System.Drawing.Color.Black;
        }
        private void rdo_to_Click(object sender, EventArgs e)
        {
            if (rdo_to.Checked == true)
            {
                rdo_to.ForeColor = System.Drawing.Color.Red;
                rdo_from.ForeColor = System.Drawing.Color.Black;
                rdo_target.ForeColor = System.Drawing.Color.Black;
            }
            else
                rdo_to.ForeColor = System.Drawing.Color.Black;
        }
        private void rdo_cancel_Click(object sender, EventArgs e)
        {
            if (opt_cancel.Checked == true)
            {
                opt_cancel.ForeColor = System.Drawing.Color.Red;
                opt_sent.ForeColor = System.Drawing.Color.Black;
                opt_move.ForeColor = System.Drawing.Color.Black;
                opt_delete.ForeColor = System.Drawing.Color.Black;
                opt_return.ForeColor = System.Drawing.Color.Black;
                rdo_from.Enabled = true;
                rdo_from.Checked = true;
                rdo_from.ForeColor = System.Drawing.Color.Red;
                rdo_to.Enabled = false;
                rdo_target.Enabled = false;
            }
            else
            {
                opt_cancel.ForeColor = System.Drawing.Color.Black;
            }
            txt_from.Text = "";
            txt_to.Text = "";
            txt_target.Text = "";
    
            sSlab_Edt_Seq_Fr = "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";
        }
        private void rdo_move_Click(object sender, EventArgs e)
        {
            if (opt_move.Checked == true)
            {
                opt_move.ForeColor = System.Drawing.Color.Red;
                opt_sent.ForeColor = System.Drawing.Color.Black;
                opt_cancel.ForeColor = System.Drawing.Color.Black;
                opt_delete.ForeColor = System.Drawing.Color.Black;
                opt_return.ForeColor = System.Drawing.Color.Black;
                rdo_from.Enabled = true;
                rdo_from.Checked = true;
                rdo_from.ForeColor = System.Drawing.Color.Red;
                rdo_to.Enabled = true;
                rdo_to.ForeColor = System.Drawing.Color.Black;
                rdo_target.Enabled = true;
            }
            else
            {
                opt_move.ForeColor = System.Drawing.Color.Black;
            }
            txt_from.Text = "";
            txt_to.Text = "";
            txt_target.Text = "";

            sSlab_Edt_Seq_Fr = "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";

        }
        private void rdo_delete_Click(object sender, EventArgs e)
        {
            if (opt_delete.Checked == true)
            {
                opt_delete.ForeColor = System.Drawing.Color.Red;
                opt_sent.ForeColor = System.Drawing.Color.Black;
                opt_cancel.ForeColor = System.Drawing.Color.Black;
                opt_move.ForeColor = System.Drawing.Color.Black;
                opt_return.ForeColor = System.Drawing.Color.Black;
                rdo_from.Enabled = true;
                rdo_from.Checked = true;
                rdo_from.ForeColor = System.Drawing.Color.Red;
                rdo_to.Enabled = true;
                rdo_to.ForeColor = System.Drawing.Color.Black;
                rdo_target.Enabled = false;
            }
            else
            {
                opt_delete.ForeColor = System.Drawing.Color.Black;
            }
            txt_from.Text = "";
            txt_to.Text = "";
            txt_target.Text = "";
    
            sSlab_Edt_Seq_Fr = "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";
        }
        private void rdo_return_Click(object sender, EventArgs e)
        {
            if (opt_return.Checked == true)
            {
                opt_return.ForeColor = System.Drawing.Color.Red;
                opt_sent.ForeColor = System.Drawing.Color.Black;
                opt_cancel.ForeColor = System.Drawing.Color.Black;
                opt_move.ForeColor = System.Drawing.Color.Black;
                opt_delete.ForeColor = System.Drawing.Color.Black;
                rdo_from.Enabled = true;
                rdo_from.Checked = true;
                rdo_to.Enabled = true;
                rdo_target.Enabled = false;
            }
            else
            {
                opt_return.ForeColor = System.Drawing.Color.Black;
            }
            txt_from.Text = "";
            txt_to.Text = "";
            txt_target.Text = "";
    
            sSlab_Edt_Seq_Fr = "0";
            sSlab_Edt_Seq_To = "0";
            sSlab_Edt_Seq_Tg = "0";
        }
        #endregion

        private void btn_roll_mana_Click(object sender, EventArgs e)
        {
            if (txt_target.Text.Trim() != "")
            {
                if (GeneralCommon.Gf_MessConfirm("确定从板坯（ '" + txt_to.Text + "'）进行辊期编制吗？", "Q", "辊期编制确定"))
                {
                    if (Gp_Process_Exec("R") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("辊期编制完毕 ！", "I", this.Text);
                        Form_Ref();
                    }
                }
            }
        }

        protected override void ss_CellClickEvent(object sender, CellClickEventArgs e)
        {
            base.ss_CellClickEvent(sender, e);
            if (e.ColumnHeader) return;
            if (e.RowHeader) return;
            string SE = "";
            int C, M;
            int iRow;
            int iCol;
            string SEND_SLAB = "";

            if (rdo_from.Checked)
            {
                txt_from.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
                sSlab_Edt_Seq_Fr = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_Edt_Seq].Text;
            }

            if (rdo_to.Checked)
            {
                txt_to.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
                sSlab_Edt_Seq_To = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_Edt_Seq].Text;
            }

            if (rdo_target.Checked)
            {
                txt_target.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
                sSlab_Edt_Seq_Tg = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_Edt_Seq].Text;
            }

            SE = ss1.ActiveSheet.Cells[e.Row, 15].Text;//13--15

            if (e.Column == iSs1_Slab_No)
            {

                txt_search_slabno.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_Edt_Seq].Text;

                if ((txt_search_slabno.Text).Trim().Length > 0)
                {
                    base.p_Ref(2, 2, true, false);
                }
            }
        }

        # region 公共方法

        public string substr(string x, int y, int z)
        {
            if (x != "")
            {
                return x.Substring(y, z);
            }
            return "";
        }

        public double convertX(string value)
        {
            if (value != "")
            {
                return Convert.ToDouble(value);
            }
            return 0;
        }

        public int convertI(string value)
        {
            if (value != "")
            {
                return Convert.ToInt32(value);
            }
            return 0;
        }

        public short convertS(string value)
        {
            if (value != "")
            {
                return Convert.ToInt16(value);
            }
            return 0;
        }

        //重写了框架的颜色方法，原来的框架在解锁方面有点问题，不方便在框架直接修改，所以重新写了一个
        public void Gp_Sp_BlockColor(FpSpread oSpread, int iCol1, int iCol2, int iRow1, int iRow2, Color fColor, Color bColor)
        {
            FarPoint.Win.Spread.SheetView with_1 = oSpread.ActiveSheet;
            for (int row = iRow1; row <= iRow2; row++)
            {
                for (int col = iCol1; col <= iCol2; col++)
                {
                    bool locked = with_1.Columns[col].Locked;
                    with_1.Columns[col].Locked = false;
                    with_1.Cells[row, col].Locked = false;
                    //我在这里加了一个颜色的判断，防止多个颜色的时候，颜色覆盖替换的问题，所以在赋值的时候，黑色字体和白色背景不会被传入进行修改
                    if (fColor != Color.Black)
                    {
                        with_1.Cells[row, col].ForeColor = fColor;
                    }
                    if (bColor != Color.White)
                    {
                        with_1.Cells[row, col].BackColor = bColor;
                    }
                    with_1.Cells[row, col].Locked = locked;
                    with_1.Columns[col].Locked = locked;
                }
            }
        }

        #endregion


    }
}
