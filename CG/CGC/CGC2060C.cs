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
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            矫直作业实绩查询及修改界面                               
///-- 程序ID            CGC2060C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.05.05                                                
///-- 处理描述          矫直作业实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.05.05        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGC2060C : CommonClass.FORMBASE
    {
        public CGC2060C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();

        string CUT_SEQ;

        const int SS1_URGNT_FL = 19; //紧急订单绿色标记显示 add by liqian 2012-08-16
        const int SS1_IMP_CONT = 20;
        const int SS1_PILECOOL = 21;
        const int SS1_FLAG = 22;
        const int SS1_EXPORT = 23;
        const int SS1_SLAB_NO = 0;

        const int SS2_DUILENG = 12;
        const int SS2_MPLATE_NO = 0;


        protected override void p_SubFormInit() {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("轧件号", txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间", txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
            //p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
            //p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
            //p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
            //p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
            //p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
            //p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_MOTHER_PLATE_LEN6, "IR", "", "", "", imcseq, ""); //39
            p_SetMc(SDB_MOTHER_SCH_LEN6, "R", "", "", "", imcseq, ""); //40
            p_SetMc(txt_Shift, "IR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_Group, "IR", "", "", "", imcseq, ""); //42
            p_SetMc(txt_Emp, "IR", "", "", "", imcseq, ""); //43
            p_SetMc(txt_pdt_inf, "R", "", "", "", imcseq, ""); //44
            p_SetMc(TXT_SEQ, "R", "", "", "", imcseq, ""); //45

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("切割实绩开始时间", txt_RstFormDate, "PN", "", "", "", "", imcseq);
            p_SetMc("切割实绩结束时间", txt_RstToDate, "PN", "", "", "", "", imcseq);

            p_McIni(Mc3, true);
            imcseq = 3;
            p_SetMc("轧件号", txt_RollingNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc(txt_RollingSize, "R", "", "", "", imcseq, ""); //1
            p_SetMc(txt_Stlgrd, "R", "", "", "", imcseq, ""); //2
            p_SetMc(txt_HotLevTmp, "R", "", "", "", imcseq, ""); //3
            p_SetMc("切割时间", txt_CutDate, "NIR", "", "", "", "", imcseq); //4
            p_SetMc(txt_CutYN1, "IL", "", "", "", imcseq, ""); //5
            p_SetMc(txt_Thk1, "RL", "", "", "", imcseq, ""); //6
            p_SetMc(txt_Wid1, "RL", "", "", "", imcseq, ""); //7
           // p_SetMc(TXT_MOTHER_PLATE1, "", "", "", "", imcseq, ""); //8
            p_SetMc(SDB_MOTHER_PLATE_LEN1, "IR", "", "", "", imcseq, ""); //9
            p_SetMc(SDB_MOTHER_SCH_LEN1, "R", "", "", "", imcseq, ""); //10
            p_SetMc(txt_CutYN2, "IL", "", "", "", imcseq, ""); //11
            p_SetMc(txt_Thk2, "RL", "", "", "", imcseq, ""); //12
            p_SetMc(txt_Wid2, "RL", "", "", "", imcseq, ""); //13
           // p_SetMc(TXT_MOTHER_PLATE2, "", "", "", "", imcseq, ""); //14
            p_SetMc(SDB_MOTHER_PLATE_LEN2, "IR", "", "", "", imcseq, ""); //15
            p_SetMc(SDB_MOTHER_SCH_LEN2, "R", "", "", "", imcseq, ""); //16
            p_SetMc(txt_CutYN3, "IL", "", "", "", imcseq, ""); //17
            p_SetMc(txt_Thk3, "RL", "", "", "", imcseq, ""); //18
            p_SetMc(txt_Wid3, "RL", "", "", "", imcseq, ""); //19
           // p_SetMc(TXT_MOTHER_PLATE3, "", "", "", "", imcseq, ""); //20
            p_SetMc(SDB_MOTHER_PLATE_LEN3, "IR", "", "", "", imcseq, ""); //21
            p_SetMc(SDB_MOTHER_SCH_LEN3, "R", "", "", "", imcseq, ""); //22
            p_SetMc(txt_CutYN4, "IL", "", "", "", imcseq, ""); //23
            p_SetMc(txt_Thk4, "RL", "", "", "", imcseq, ""); //24
            p_SetMc(txt_Wid4, "RL", "", "", "", imcseq, ""); //25
           // p_SetMc(TXT_MOTHER_PLATE4, "", "", "", "", imcseq, ""); //26
            p_SetMc(SDB_MOTHER_PLATE_LEN4, "IR", "", "", "", imcseq, ""); //27
            p_SetMc(SDB_MOTHER_SCH_LEN4, "R", "", "", "", imcseq, ""); //28
            p_SetMc(txt_CutYN5, "IL", "", "", "", imcseq, ""); //29
            p_SetMc(txt_Thk5, "RL", "", "", "", imcseq, ""); //30
            p_SetMc(txt_Wid5, "RL", "", "", "", imcseq, ""); //31
           // p_SetMc(TXT_MOTHER_PLATE5, "", "", "", "", imcseq, ""); //32
            p_SetMc(SDB_MOTHER_PLATE_LEN5, "IR", "", "", "", imcseq, ""); //33
            p_SetMc(SDB_MOTHER_SCH_LEN5, "R", "", "", "", imcseq, ""); //34
            p_SetMc(txt_CutYN6, "IL", "", "", "", imcseq, ""); //35
            p_SetMc(txt_Thk6, "RL", "", "", "", imcseq, ""); //36
            p_SetMc(txt_Wid6, "RL", "", "", "", imcseq, ""); //37
           // p_SetMc(TXT_MOTHER_PLATE6, "", "", "", "", imcseq, ""); //38
            p_SetMc(SDB_MOTHER_PLATE_LEN6, "IR", "", "", "", imcseq, ""); //39
            p_SetMc(SDB_MOTHER_SCH_LEN6, "R", "", "", "", imcseq, ""); //40
            p_SetMc(txt_Shift, "IR", "", "", "", imcseq, ""); //41
            p_SetMc(txt_Group, "IR", "", "", "", imcseq, ""); //42
            p_SetMc(txt_Emp, "IR", "", "", "", imcseq, ""); //43


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("轧件号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //1
            p_SetSc("取样方式", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("取样长度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //7
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("母板块数", "E", "9", "L", "", "", "", iscseq, iheadrow, "R"); //9
            p_SetSc("母板切割长度1", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("母板切割长度2", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("母板切割长度3", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //12
            p_SetSc("母板切割长度4", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //13
            p_SetSc("母板切割长度5", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("母板切割长度6", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("UST", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("定尺", "E", "20", "L", "", "", "", iscseq, iheadrow, "L"); //17
            p_SetSc("订单长度范围", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("重点订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //24
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //25
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //26
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //27
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "L"); //28

            iheadrow = 0;
            p_spanSpread("轧件后尺寸", 5, 7, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 1;
            iscseq = 2;

            p_SetSc("母板号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("分段号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //2
            p_SetSc("钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //3
            p_SetSc("厚度", "N", "9,2", "L", "", "", "", iscseq, iheadrow, "R"); //4
            p_SetSc("宽度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //5
            p_SetSc("长度", "N", "9", "L", "", "", "", iscseq, iheadrow, "R"); //6
            p_SetSc("母板切割日期", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //7
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //9
            p_SetSc("作业人", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("经RH", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12


            iheadrow = 0;
            p_spanSpread("母板尺寸", 4, 6, iscseq, iheadrow, 1);

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("订单号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("厚度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //1
            p_SetSc("宽度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //2
            p_SetSc("长度", "E", "20", "L", "", "", "", iscseq, iheadrow, "R"); //3
            p_SetSc("定尺", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("标准号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L"); //5

            CUT_SEQ = "SELECT NVL(SEQ_NO,0) FROM NISCO.GP_MP_IDX WHERE PLT='C3'";

        }

        private void Check1_Clk()
        {
            if (SDB_MOTHER_PLATE_LEN1.Text == "0") { Check1.Checked = false; }
            if (Check1.Checked)
            {
                txt_CutYN1.Text = "Y";
            }
            else
            {
                txt_CutYN1.Text = "";
            }
        }

        private void Check2_Clk()
        {
            if (SDB_MOTHER_PLATE_LEN2.Text == "0") { Check2.Checked = false; }
            if (Check2.Checked)
            {
                txt_CutYN2.Text = "Y";
            }
            else
            {
                txt_CutYN2.Text = "";
            }
        }

        private void Check3_Clk()
        {

            if (SDB_MOTHER_PLATE_LEN3.Text == "0") { Check3.Checked = false; }
            if (Check3.Checked)
            {
                txt_CutYN3.Text = "Y";
            }
            else
            {
                txt_CutYN3.Text = "";
            }
        }

        private void Check4_Clk()
        {
            if (SDB_MOTHER_PLATE_LEN4.Text == "0") { Check4.Checked = false; }
            if (Check4.Checked)
            {
                txt_CutYN4.Text = "Y";
            }
            else
            {
                txt_CutYN4.Text = "";
            }
        }

        private void Check5_Clk()
        {
            if (SDB_MOTHER_PLATE_LEN5.Text == "0") { Check5.Checked = false; }
            if (Check5.Checked)
            {
                txt_CutYN5.Text = "Y";
            }
            else
            {
                txt_CutYN5.Text = "";
            }
        }

        private void Check6_Clk()
        {
            if (SDB_MOTHER_PLATE_LEN6.Text == "0") { Check6.Checked = false; }
            if (Check6.Checked)
            {
                txt_CutYN6.Text = "Y";
            }
            else
            {
                txt_CutYN6.Text = "";
            }
        }

        private void cmd_Pass_Clk()
        {

            long CNT;
            string SMESG;
            if (txt_CutDate.Text != "" && txt_CutDate.Text.Substring(0, 1) != "2")
            {
                SMESG = " 请输入切割时间...！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }

            CNT = 0;
            if (Check1.Checked)
            {
                CNT = CNT + 1;
            }

            if (Check2.Checked)
            {
                CNT = CNT + 1;
            }

            if (Check3.Checked)
            {
                CNT = CNT + 1;
            }

            if (Check4.Checked)
            {
                CNT = CNT + 1;
            }

            if (Check5.Checked)
            {
                CNT = CNT + 1;
            }

            if (Check6.Checked)
            {
                CNT = CNT + 1;
            }

            if (CNT > 1)
            {
                SMESG = "一个以上母板不能空过.......！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                return;
            }
            else
            {
                Form_Pro();
            }

            txt_CutDate.Text = "";
        }

        private void cmd_scrap_Clk() {

            if (!GeneralCommon.Gf_MessConfirm("您确定要对母板号" + txt_RollingNo.Text + "做废钢处理吗？", "Q", "废钢指示确定")) {
                return;
            }

            string[] Para1 = new string[5];

            Para1[0] = txt_RollingNo.Text.Trim();
            Para1[1] = txt_Shift.Text.Trim();
            Para1[2] = txt_Group.Text.Trim();
            Para1[3] = GeneralCommon.sUserID;
            Para1[4] = TXT_CB.Text.Trim();

            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "CGC2060NC.P_SCRAP", Para1)) {

                GeneralCommon.Gp_MsgBoxDisplay("废钢处理成功=> " + txt_RollingNo.Text, "I", "系统提示信息");

            } else {
                GeneralCommon.Gp_MsgBoxDisplay("实绩处理失败，请确认" + txt_RollingNo.Text, "I", "系统提示信息");
            }

            txt_CutDate.Text = "";

        }


        //vb上发现本条代码已经移出，暂时不考虑实现，如果后期要实现，请查询CGC2060C VB画面
        // private void cmd_Seq_Clk() {

        // }

        private void CGC2060C_Load(object sender, EventArgs e) {
            base.sSvrPgmPkgName = "CGC2060NC";

            Form_Define();

            Tab1.SelectedIndex = 0;

            Form_Ref();

            unlockSpread(ss1);
            unlockSpread(ss2);
            unlockSpread(ss3);

            txt_Shift.Text = Gf_ShiftSet3("");
            txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
            txt_Emp.Text = GeneralCommon.sUserID;

            if (base.sAuthority.Substring(0, 3) == "111") {
                cmd_Pass.Enabled = true;
                    //cmd_Seq.Enabled = True
                cmd_scrap.Enabled = true;

            } else {
                cmd_Pass.Enabled = false;
                    //cmd_Seq.Enabled = False
                cmd_scrap.Enabled = false;
            }

            lockSpread(ss1);
            lockSpread(ss2);
            lockSpread(ss3);

        }



        public override void Form_Ref()
        {
            int iRow;
            int iCol;
            string sUrgnt_Fl;
            string simpcont;
            string PILECOOL;
            string sFlag;
            string sexport;

            string sDuileng;

            if (Tab1.SelectedIndex == 0)
            {
                p_Ref(0, 1, true, false);
                //        TXT_SEQ = Gf_FloatFind(M_CN1, CUT_SEQ)
                ss1_DblClk(0, 0);

                unlockSpread(ss1);

                //紧急订单绿色显示 add by liqian 2012-08-16
                {
                    for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                    {
                        sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Text.ToString().Trim();
                        simpcont = ss1.ActiveSheet.Cells[iRow - 1, SS1_IMP_CONT].Text.ToString().Trim();
                        PILECOOL = ss1.ActiveSheet.Cells[iRow - 1, SS1_PILECOOL].Text.ToString().Trim();
                        sFlag = ss1.ActiveSheet.Cells[iRow - 1, SS1_FLAG].Text.ToString().Trim();
                        sexport = ss1.ActiveSheet.Cells[iRow - 1, SS1_EXPORT].Text.ToString().Trim();

                        if (sUrgnt_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);

                        }
                        if (simpcont == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        if (PILECOOL == "Y" & simpcont != "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, Color.Yellow);

                        }

                        //是否定制配送

                        if (sFlag == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, SSP5.BackColor, Color.White);

                        }
                        //是否出口订单
                        if (sexport == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_SLAB_NO, SS1_SLAB_NO, iRow - 1, iRow - 1, SSP6.BackColor, Color.White);
                        }
                    }
                }

                lockSpread(ss1);
                unlockSpread(ss2);

                {
                    for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++)
                    {
                        sDuileng = ss2.ActiveSheet.Cells[iRow - 1, SS2_DUILENG].Text.ToString().Trim(); ;

                        if (sDuileng == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_MPLATE_NO, SS2_MPLATE_NO, iRow - 1, iRow - 1, SSPanel1.BackColor, Color.White);
                        }
                    }
                }
                lockSpread(ss2);

            }
            else if (Tab1.SelectedIndex == 1)
            {
                p_Ref(2, 2, true, false);
                //        TXT_SEQ = Gf_FloatFind(M_CN1, CUT_SEQ)

            }


        }

        public override void Form_Pro()
        {

            string SMESG;

            if (!Gp_DateCheck(txt_CutDate.Text, ""))
            {
                SMESG = " 请正确输入切割时间 ！";
                GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");

                return;
            }

            p_Pro(1, 0, true, true);

            Form_Ref();

            txt_Shift.Text = Gf_ShiftSet3("");
            txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
            txt_Emp.Text = GeneralCommon.sUserID;

            txt_CutDate.Text = "";

        }

        private void SDB_MOTHER_PLATE_LEN1_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN1.NumValue > 0)
            {
                Check1.Checked = true;
                txt_CutYN1.Text = "Y";
            }
            else
            {
                Check1.Checked = false;
                txt_CutYN1.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN1_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN1.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN1.Text = SDB_MOTHER_SCH_LEN1.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN1.Text = "";
            }
        }


        private void SDB_MOTHER_PLATE_LEN2_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN2.NumValue > 0)
            {
                Check2.Checked = true;
                txt_CutYN2.Text = "Y";
            }
            else
            {
                Check2.Checked = false;
                txt_CutYN2.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN2_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN2.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN2.Text = SDB_MOTHER_SCH_LEN2.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN2.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN3_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN3.NumValue > 0)
            {
                Check3.Checked = true;
                txt_CutYN3.Text = "Y";
            }
            else
            {
                Check3.Checked = false;
                txt_CutYN3.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN3_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN3.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN3.Text = SDB_MOTHER_SCH_LEN3.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN3.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN4_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN4.NumValue > 0)
            {
                Check4.Checked = true;
                txt_CutYN4.Text = "Y";
            }
            else
            {
                Check4.Checked = false;
                txt_CutYN4.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN4_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN4.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN4.Text = SDB_MOTHER_SCH_LEN4.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN4.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN5_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN5.NumValue > 0)
            {
                Check5.Checked = true;
                txt_CutYN5.Text = "Y";
            }
            else
            {
                Check5.Checked = false;
                txt_CutYN5.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN5_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN5.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN5.Text = SDB_MOTHER_SCH_LEN5.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN5.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN6_Chg()
        {
            if (SDB_MOTHER_PLATE_LEN6.NumValue > 0)
            {
                Check6.Checked = true;
                txt_CutYN6.Text = "Y";
            }
            else
            {
                Check6.Checked = false;
                txt_CutYN6.Text = "";
            }
        }

        private void SDB_MOTHER_PLATE_LEN6_DblClk()
        {
            if (SDB_MOTHER_PLATE_LEN6.NumValue == 0)
            {
                SDB_MOTHER_PLATE_LEN6.Text = SDB_MOTHER_SCH_LEN6.Text;
            }
            else
            {
                SDB_MOTHER_PLATE_LEN6.Text = "";
            }
        }

        private void ss1_DblClk(int col, int row) {
            if (ss1.ActiveSheet.RowCount > 0) {
                txt_RollingNo.Text = ss1.ActiveSheet.Cells[row, 0].Text;

                if (txt_RollingNo.Text.Trim() != "") {

                    p_Ref(1, 0,true,false);
                    p_Ref(1, 3, true, false);

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN1.Text) < 500) {
                        txt_Thk1.Text = "";
                        txt_Wid1.Text = "";
                        Check1.Checked = false;
                    } else {
                        Check1.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN2.Text) < 500) {
                        txt_Thk2.Text = "";
                        txt_Wid2.Text = "";
                        Check2.Checked = false;
                    } else {
                        Check2.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN3.Text) < 500) {
                        txt_Thk3.Text = "";
                        txt_Wid3.Text = "";
                        Check3.Checked = false;
                    } else {
                        Check3.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN4.Text) < 500) {
                        txt_Thk4.Text = "";
                        txt_Wid4.Text = "";
                        Check4.Checked = false;
                    } else {
                        Check4.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN5.Text) < 500) {
                        txt_Thk5.Text = "";
                        txt_Wid5.Text = "";
                        Check5.Checked = false;
                    } else {
                        Check5.Checked = true;
                    }

                    if (Convert.ToDouble(SDB_MOTHER_PLATE_LEN6.Text) < 500) {
                        txt_Thk6.Text = "";
                        txt_Wid6.Text = "";
                        Check6.Checked = false;
                    } else {
                        Check6.Checked = true;
                    }

                    txt_CutDate.Text = "";
                }

                txt_Shift.Text = Gf_ShiftSet3("");
                txt_Group.Text = Gf_GroupSet(txt_Shift.Text.Trim(), Gf_DTSet("", "X"));
                txt_Emp.Text = GeneralCommon.sUserID;

                //txt_CutDate.RawData = Gf_DTSet(M_CN1, , "X")

            }
        }


        private void ss2_DblClk(int col, int row)
        {
            if (ss2.ActiveSheet.RowCount > 0)
            {
                txt_RollingNo.Text = ss2.ActiveSheet.Cells[row, 0].Text; ;
                if (txt_RollingNo.Text.Trim() != "")
                {
                    p_Ref(3, 0, true, false);
                }
            }
        }

        private void tab1_Clk()
        {
            if (Tab1.SelectedIndex == 1)
            {
                txt_Shift.Text = Gf_ShiftSet3("");
                if (txt_Shift.Text == "1")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "000001";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081459";
                }
                else if (txt_Shift.Text == "2")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "081500";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "155959";
                }
                else if (txt_Shift.Text == "3")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "160000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "235959";
                }
            }
        }

        private void txt_CutDate_Clk()
        {
            txt_CutDate.Text = Gf_DTSet("", "X");
        }

        private void txt_RstFormDate_DblClk()
        {
            txt_RstFormDate.Text = Gf_DTSet("", "X");
            txt_RstToDate.Text = Gf_DTSet("", "X");
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
            DTCheck = "S";
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

        private void Check1_CheckedChanged(object sender, EventArgs e)
        {
            Check1_Clk();
        }

        private void Check2_CheckedChanged(object sender, EventArgs e)
        {
            Check2_Clk();
        }

        private void Check3_CheckedChanged(object sender, EventArgs e)
        {
            Check3_Clk();
        }

        private void Check4_CheckedChanged(object sender, EventArgs e)
        {
            Check4_Clk();
        }

        private void Check5_CheckedChanged(object sender, EventArgs e)
        {
            Check5_Clk();
        }

        private void Check6_CheckedChanged(object sender, EventArgs e)
        {
            Check6_Clk();
        }

        private void cmd_Pass_Click(object sender, EventArgs e)
        {
            cmd_Pass_Clk();
        }

        private void cmd_scrap_Click(object sender, EventArgs e)
        {
            cmd_scrap_Clk();
        }

        private void SDB_MOTHER_PLATE_LEN1_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN1_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN1_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN1_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN2_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN2_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN2_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN2_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN3_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN3_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN3_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN3_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN4_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN4_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN4_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN4_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN5_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN5_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN5_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN5_DblClk();
        }

        private void SDB_MOTHER_PLATE_LEN6_TextChanged(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN6_Chg();
        }

        private void SDB_MOTHER_PLATE_LEN6_DoubleClick(object sender, EventArgs e)
        {
            SDB_MOTHER_PLATE_LEN6_DblClk();
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

        private void Tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab1_Clk();
        }

        private void txt_CutDate_Click(object sender, EventArgs e)
        {
            txt_CutDate_Clk();
        }

        private void txt_RstFormDate_DoubleClick(object sender, EventArgs e)
        {
            txt_RstFormDate_DblClk();
        }




    }
}
