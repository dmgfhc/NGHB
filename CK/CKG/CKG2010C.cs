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
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Slab_No = 5;        //SS1板坯号
        public const int iSs1_Slab_Edt_Seq = 45;  //SS1板坯编制号
        public const int PRC_STS_Color = 4;       //板坯状态
        public const int L2_SEND_Color = 42;      //指示状态
        public const int iSs1_DEL_DATE = 46; //交货期
        public const int iSs1_ORD_KND = 14; //订单种类

        string Mode = "";              // 操作类型:L 发送,C 取消,M 调整,X 删除,B 返送,A 强制下达,R 辊期编制
        string sSlab_Edt_Seq_Fr ;      // 起始板坯号
        string sSlab_Edt_Seq_To ;      // 调整到板坯号
        string sSlab_Edt_Seq_Tg ;      // 目标板坯号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(txt_search_slabno, "PR", "", "", "", imcseq, "");  // 轧制序号
            p_SetMc(txt_from, "R", "", "", "", imcseq, "");      // 起始板坯号
            p_SetMc(txt_to, "R", "", "", "", imcseq, "");        // 终止板坯号
            p_SetMc(txt_target, "R", "", "", "", imcseq, "");    // 目标板坯号

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc(txt_search_slabno, "PR", "", "", "", imcseq, "");  // 轧制序号

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, false);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("轧制序号", "E", "10", "RL", "", "", "", iscseq, iheadrow, "R");//0
            p_SetSc("辊期", "E", "5", "RL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("辊期内板坯顺序", "E", "10", "RL", "", "", "", iscseq, iheadrow, "R");//2
            p_SetSc("辊期内累计公里数", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);//3
            p_SetSc("板坯状态", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("板坯号", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("坯料生产时间", "D", "15", "RL", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("堆冷时间", "D", "15", "RL", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("可装炉时间", "D", "15", "RL", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("头尾坯标记", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("坯料冶炼钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("低倍质量等级", "E", "30", "RL", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("处理详细内容", "E", "50", "RL", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("轧制钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow);//13
            p_SetSc("订单种类", "E", "8", "RL", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("订单号", "E", "11", "RL", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("订单序列", "E", "8", "RL", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("产品钢种", "E", "30", "RL", "", "", "", iscseq, iheadrow);//17
            p_SetSc("坯料规格", "E", "20", "RL", "", "", "", iscseq, iheadrow);//18
            p_SetSc("板坯重量", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);//19
            p_SetSc("当前位置", "E", "20", "RL", "", "", "", iscseq, iheadrow);//20
            p_SetSc("铸机号", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");//21
            p_SetSc("HCR分类", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//22
            p_SetSc("产品类型", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("出炉温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//24
            p_SetSc("轧制代码", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//25
            p_SetSc("目标厚度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);//26
            p_SetSc("目标宽度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);//27
            p_SetSc("轧件长度", "N", "8,1", "RL", "", "", "", iscseq, iheadrow);//28
            p_SetSc("设计成材率", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//29
            p_SetSc("欠量（上限）", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//30
            p_SetSc("欠量（下限）", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//31
            p_SetSc("UST", "E", "20", "RL", "", "", "", iscseq, iheadrow, "M");//32
            p_SetSc("坯料是否走真空", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");//33
            p_SetSc("热处理方法", "E", "50", "RL", "", "", "", iscseq, iheadrow, "M");//34
            p_SetSc("控轧代码", "E", "20", "RL", "", "", "", iscseq, iheadrow, "M");//35
            p_SetSc("控轧厚度比", "N", "3", "RL", "", "", "", iscseq, iheadrow);//36
            p_SetSc("控轧温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//37
            p_SetSc("终轧温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//38
            p_SetSc("冷却方式", "E", "20", "RL", "", "", "", iscseq, iheadrow);//39
            p_SetSc("开冷温度", "N", "4", "RL", "", "", "", iscseq, iheadrow);//40
            p_SetSc("冷却率", "N", "3", "RL", "", "", "", iscseq, iheadrow);//41
            p_SetSc("指示状态", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");//42
            p_SetSc("进程状态", "E", "3", "RL", "", "", "", iscseq, iheadrow, "M");//43
            p_SetSc("编制时间", "DT", "19", "RL", "", "", "", iscseq, iheadrow, "M");//44
            p_SetSc("板坯编制号", "E", "8", "RL", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("交货期", "D", "8", "RL", "", "", "", iscseq, iheadrow, "M");//46
            p_SetSc("计划板坯缓冷时间", "N", "4", "RL", "", "", "", iscseq, iheadrow, "M");//47
            
            
            p_ScIni(ss2, Sc2, 18, false, false);
            iheadrow = 0;
            iscseq = 2;
            //0-5
            p_SetSc("钢板号", "E", "14", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("产品类型", "E", "2", "RL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("厚度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("长度", "N", "15", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("订单号", "E", "14", "RL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("订单材", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("标准", "E", "30", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("订单用途", "E", "10", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("客户名称", "E", "80", "RL", "", "", "", iscseq, iheadrow,"L");
            //11-15
            p_SetSc("定尺", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("切边", "E", "10", "RL", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("探伤", "E", "4", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("热处理", "E", "10", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("加喷内容", "E", "30", "RL", "", "", "", iscseq, iheadrow);
            //16-17
            p_SetSc("备注", "E", "400", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板状态", "E", "1", "RL", "", "", "", iscseq, iheadrow, "M");


        }
        private void WKA1010C_Load(object sender, EventArgs e)
        {
            Form_Define();
            // 设置板坯号调整初始不可用
            opt_sent.Checked = true;
            rdo_from.Enabled = false;
            rdo_to.Enabled = false;
            rdo_target.Enabled = false;
        }

        public override void Form_Ref()
        {

            int XX = int.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL"));
            //20131115
            // 重写单元格双击事件
            base.p_Ref(1, 1, true, false);

            for (int lRow = 0; lRow <= ss1.ActiveSheet.RowCount - 1; lRow++)
            {
                if (ss1.ActiveSheet.Cells[lRow, PRC_STS_Color].Text == "B")
                {
                    if(ss1.ActiveSheet.Cells[lRow,iSs1_ORD_KND].Text == "实际订单")
                    {
                       
                        if (ss1.ActiveSheet.Cells[lRow, iSs1_DEL_DATE].Text != ""&&int.Parse(ss1.ActiveSheet.Cells[lRow, iSs1_DEL_DATE].Text.Replace("-", "")) < XX)
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Red, SSPpdt.BackColor);
                        }
                        
                    }
                    else
                    {
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, SSPpdt.BackColor);
                    }
                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, SSPpdt.BackColor);
                }
                else
                {
                    if (ss1.ActiveSheet.Cells[lRow, L2_SEND_Color].Text == "Y")
                    {
                        if (ss1.ActiveSheet.Cells[lRow, iSs1_ORD_KND].Text == "实际订单")
                        {
                           
                                if (ss1.ActiveSheet.Cells[lRow, iSs1_DEL_DATE].Text != ""&&int.Parse(ss1.ActiveSheet.Cells[lRow, iSs1_DEL_DATE].Text.Replace("-", "")) < XX)
                                {
                                    SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Red, SSPsend.BackColor);
                                }

                        }
                        else
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, SSPsend.BackColor);
                        }
                        SpreadCommon.Gp_Sp_RowColor(ss1, lRow, Color.Black, SSPsend.BackColor);
                    }
                }
            }
        }

        public override void Form_Pro()
        {

            string sRtn_Msg = "";              // 操作类型:L 发送,C 取消,M 调整,X 删除,B 返送,A 强制下达,R 辊期编制

            //指示发送
            if (opt_sent.Checked)
            {

                Mode = "L";

                if (txt_to.Text != "")
                {
                    if (GeneralCommon.Gf_MessConfirm("确定要下达到 '" + txt_to.Text + "' 的作业指示吗？", "Q", "指示下达确定"))
                    {
                        sRtn_Msg = Gp_Process_Exec(Mode);
                        if (sRtn_Msg == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("作业指示下达完毕 ！", "I", this.Text);
                            Form_Ref();
                        }
                        else
                        {
                            GeneralCommon.Gp_MsgBoxDisplay(sRtn_Msg, "I", this.Text);
                        }
                    }
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请选择目标板坯号 ！", "I", this.Text);
                }
            }

            //指示取消
            if (opt_cancel.Checked)
            {

                Mode = "C";

                if (txt_from.Text != "")
                {
                    if (GeneralCommon.Gf_MessConfirm("确定取消从 '" + txt_from.Text + "' 的作业指示吗？", "Q", "指示取消确定"))
                    {

                        sRtn_Msg = Gp_Process_Exec(Mode);
                        if (sRtn_Msg == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("取消指示完毕 ！", "I", this.Text);
                            Form_Ref();
                        }
                        else
                        {
                            GeneralCommon.Gp_MsgBoxDisplay(sRtn_Msg, "I", this.Text);
                        }
                    }
                }
                else
                {
                    GeneralCommon.Gp_MsgBoxDisplay("请选择目标板坯号 ！", "I", this.Text);
                }
            }

            //指示调整
            if (opt_move.Checked)
            {

                Mode = "M";
                string sMsg = "";
                sMsg = "确定要把板坯从(" + txt_from.Text + ")->(" + txt_to.Text + ")" + "调整到板坯(" + txt_target.Text + ")后边吗？ ";

                if (txt_from.Text != "")
                {

                    if (txt_from.Text != "" && txt_to.Text != "" && txt_target.Text != "")
                    {
                        GeneralCommon.Gf_MessConfirm(sMsg, "Q", "");
                    }
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("必须输入起始、终止和目标板坯号！", "I", this.Text);
                    }
                    sMsg = sMsg + "调整后相应的作业指示将被取消！";
                    if (GeneralCommon.Gf_MessConfirm(sMsg, "Q", ""))
                    {

                        sRtn_Msg = Gp_Process_Exec(Mode);
                        if (sRtn_Msg == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("作业指示调整完毕 ！", "I", this.Text);
                            Form_Ref();
                        }
                        else
                        {
                            GeneralCommon.Gp_MsgBoxDisplay(sRtn_Msg, "I", this.Text);
                        }
                    }
                }
            }

            //指示删除
            if (opt_delete.Checked)
            {

                Mode = "X";

                if (txt_from.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("必须输入起始板坯号！", "I", this.Text);
                }
                if (txt_to.Text != "")
                {
                    if (GeneralCommon.Gf_MessConfirm("确定要删除选定板坯(" + txt_from.Text + ")->(" + txt_to.Text + ")吗？", "Q", ""))
                    {

                        sRtn_Msg = Gp_Process_Exec(Mode);
                        if (sRtn_Msg == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("作业指示删除完毕 ！", "I", this.Text);
                            Form_Ref();
                        }
                        else
                        {
                            GeneralCommon.Gp_MsgBoxDisplay(sRtn_Msg, "I", this.Text);
                        }
                    }
                }
            }

            //指示返送
            if (opt_return.Checked)
            {

                Mode = "B";
                if (txt_from.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("必须输入起始板坯号！", "I", this.Text);
                    return;
                }
                if (txt_to.Text == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("必须输入终止板坯号！", "I", this.Text);
                    return;
                }
                if (GeneralCommon.Gf_MessConfirm("确定要返送选定板坯(" + txt_from.Text + ")->(" + txt_to.Text + ")吗？", "Q", ""))
                {
                    sRtn_Msg = Gp_Process_Exec(Mode);
                    if (sRtn_Msg == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("作业指示返送完毕 ！", "I", this.Text);
                        Form_Ref();
                    }
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay(sRtn_Msg, "I", this.Text);
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

            string[] Para1 = new string[2];
            string[] Para2 = new string[3];
            string[] Para3 = new string[4];
            string[] Para4 = new string[4];
            string[] Para5 = new string[3];
            string[] Para6 = new string[2];
            string[] Para7 = new string[3];

            // 发送
            Para1[0] = "A";
            Para1[1] = sSlab_Seq_To;
            if (Process_Type == "L") {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1010P", Para1))
                {
                    return "";
                }
                else
                {
                    return "作业指示下达失败";
                }
            }

            // 取消
            Para2[0] = sSlab_Seq_Fr;
            Para2[1] = "M";
            if (Process_Type == "C")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1011P", Para2))
                {
                    return "";
                }
                else
                {
                    return "作业指示取消失败";
                }
            }

            // 调整
            Para3[0] = "M";
            Para3[1] = sSlab_Seq_Fr;
            Para3[2] = sSlab_Seq_To;
            Para3[3] = sSlab_Seq_Tg;
            if (Process_Type == "M")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1012P", Para3))
                {
                    return "";
                }
                else
                {
                    return "作业指示调整失败";
                }
            }

            // 删除
            Para4[0] = sSlab_Seq_Fr;
            Para4[1] = sSlab_Seq_To;
            Para4[2] = "A";
            Para4[3] = "M";
            if (Process_Type == "X")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1013P", Para4))
                {
                    return "";
                }
                else
                {
                    return "作业指示删除失败";
                }
            }

            // 返送
            Para5[0] = "C2";
            Para5[1] = sSlab_Seq_Fr;
            Para5[2] = sSlab_Seq_To;
            if (Process_Type == "B")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "AFZ1300P", Para5))
                {
                    return "";
                }
                else
                {
                    return "作业指示返送失败";
                }
            }

            // 作业指示强制下达
            if (sSlab_Seq_Fr == "") 
            {
                sSlab_Seq_Fr = sSlab_Seq_To;
            }
            Para6[0] = sSlab_Seq_Fr;
            Para6[1] = sSlab_Seq_To;
            if (Process_Type == "A")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA1015P", Para6))
                {
                    return "";
                }
                else
                {
                    return "作业指示强制下达失败";
                }
            }

            // 辊期编制
            if (Process_Type == "R")
            {
                if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKA0000P", Para7))
                {
                    return "";
                }
                else
                {
                    return "辊期编制失败";
                }
            }
            else {
                return "";
            }            
            return "";
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

        private void btn_abnormal_send_Click(object sender, EventArgs e)
        {
            if (txt_to.Text.Trim() != "")
            {
                if (GeneralCommon.Gf_MessConfirm("确定要强制下达到 '" + txt_to.Text + "' 的作业指示吗？", "Q", "指示下达确定"))
                {
                    if (Gp_Process_Exec("A") == "")  {
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

    }
}
