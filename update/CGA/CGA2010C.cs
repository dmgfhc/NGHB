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
    public partial class CGA2010C : CommonClass.FORMBASE
    {
        public CGA2010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        protected override void p_SubFormInit()
        {
            p_McIni(Mc1,false);
            p_SetMc("板坯号", txt_slab_no, "P", "", "", "", "", 1);//0
            p_SetMc("起始垛位号", txt_f_addr, "P", "", "", "", "", 1);//1
            p_SetMc("目的垛位号", txt_t_addr, "P", "", "", "", "", 1);//2
            p_SetMc("连铸机号", cbo_ccm_line, "P", "", "", "", "", 1);//3
            p_SetMc("当前库", CBO_CUR_INV, "PN", "", "", "", "", 1);//4

            p_ScIni(ss1, Sc1, 14, false, true);
            p_SetSc("垛层", "N", "2", "IL", "", "", "", 1, 0);//0
            p_SetSc("板坯号", "E", "10", "I", "", "", "", 1, 0, "M");//1
            p_SetSc("板坯类型", "E", "", "L", "", "", "", 1, 0, "M");//2
            p_SetSc("垛位号", "E", "", "IL", "", "", "", 1, 0, "M");//3
            p_SetSc("钢种", "E", "", "L", "", "", "", 1, 0);//4
            p_SetSc("厚度", "N", "8", "L", "", "", "", 1, 0, "M");//5
            p_SetSc("宽度", "N", "8", "L", "", "", "", 1, 0, "M");//6
            p_SetSc("长度", "N", "8", "L", "", "", "", 1, 0, "M");//7
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 1, 0, "M");//8
            p_SetSc("产品等级", "E", "", "L", "", "", "", 1, 0, "M");//9
            p_SetSc("订单号", "E", "", "L", "", "", "", 1, 0, "M");//10
            p_SetSc("发货日期", "D", "", "L", "", "", "", 1, 0, "M");//11
            p_SetSc("发货时间", "T", "", "L", "", "", "", 1, 0, "M");//12
            p_SetSc("是否修磨", "C", "", "L", "", "", "", 1, 0, "M");//13
            p_SetSc("作业人员", "E", "", "IL", "", "", "", 1, 0);//14
            p_SetSc("P", "E", "", "IL", "", "", "", 1, 0, "M");//15

            p_ScIni(ss2, Sc2, 14, false, true);
            p_SetSc("垛层", "N", "2", "IL", "", "", "", 2, 0);//0
            p_SetSc("板坯号", "E", "10", "I", "", "", "", 2, 0, "M");//1
            p_SetSc("板坯类型", "E", "", "L", "", "", "", 2, 0, "M");//2
            p_SetSc("垛位号", "E", "", "IL", "", "", "", 2, 0, "M");//3
            p_SetSc("钢种", "E", "", "L", "", "", "", 2, 0);//4
            p_SetSc("厚度", "N", "8", "L", "", "", "", 2, 0, "M");//5
            p_SetSc("宽度", "N", "8", "L", "", "", "", 2, 0, "M");//6
            p_SetSc("长度", "N", "8", "L", "", "", "", 2, 0, "M");//7
            p_SetSc("重量", "N", "8,3", "L", "", "", "", 2, 0, "M");//8
            p_SetSc("产品等级", "E", "", "L", "", "", "", 2, 0, "M");//9
            p_SetSc("订单号", "E", "", "L", "", "", "", 2, 0, "M");//10
            p_SetSc("发货日期", "D", "", "L", "", "", "", 2, 0, "M");//11
            p_SetSc("发货时间", "T", "", "L", "", "", "", 2, 0, "M");//12
            p_SetSc("是否修磨", "C", "", "L", "", "", "", 2, 0, "M");//13
            p_SetSc("作业人员", "E", "", "IL", "", "", "", 2, 0);//14
            p_SetSc("F-ADDR", "E", "", "IL", "", "", "", 2, 0, "M");//15
        }

        int proNum = 0;
        public override void Form_Ref()
        {
            string sFromLoc = "";
            string sToLoc = "";
            //if ((txt_f_addr.Text == "" || txt_t_addr.Text == "" )&& txt_slab_no.Text!="")
            //{
            //    GeneralCommon.Gp_MsgBoxDisplay("板坯号输入的情况下，起始垛位号以及目的垛位号必须输入", "W", "警告");
            //    return;
            //}
            if (txt_f_addr.Text != "" && txt_t_addr.Text != "") 
            {
                if (txt_slab_no.Text != "" && txt_slab_no.Text.Length != 10)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("板坯号长度必须为10位", "W", "警告");
                    return;
                }
            }
            if (txt_f_addr.Text != "" && txt_f_addr.Text != "S0A0101" && txt_f_addr.Text != "S0Q0101")
            {
                if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT LOCATION FROM FP_STDYARD WHERE LOCATION = '" + txt_f_addr.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay(txt_f_addr.Text + "垛位不正确...!!", "W", "警告");
                    return;
                }
            }

            if (txt_t_addr.Text != "" && txt_t_addr.Text != "S0A0101" && txt_t_addr.Text != "S0Q0101")
            {
                if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT LOCATION FROM FP_STDYARD WHERE LOCATION = '" + txt_t_addr.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay(txt_t_addr.Text + "垛位不正确...!!", "W", "警告");
                    return;
                }
            }

   

            if (opt_Left_Right.Checked)
            {
                sFromLoc = txt_f_addr.Text;
                sToLoc = txt_t_addr.Text;
            }
            else
            {
                sFromLoc = txt_t_addr.Text;
                sToLoc = txt_f_addr.Text;
            }
  
            if (sFromLoc != "" && sToLoc != "")
            {
                if (sFromLoc == sToLoc)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("起始垛位号和目的垛位号相同！请重新选择起始垛位号和目的垛位号！", "W", "");
                    return;
                }
                else if (sFromLoc != "S0A0101")
                {
                    if (txt_slab_no.Text != "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("不是在线板坯入库，板坯号和目的垛位号不能同时输入！", "W", "");
                        return;
                    }
                }
            }
           

 
            //if (txt_f_addr.Text == "S0A0101" || txt_f_addr.Text == "S0Q0101")
            //    SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            //else
            //    SpreadCommon.Gp_Sp_ColHidden(ss1, 0, false);

            //if (txt_t_addr.Text == "S0A0101" || txt_t_addr.Text == "S0Q0101")
            //    SpreadCommon.Gp_Sp_ColHidden(ss2, 0, true);
            //else
            //    SpreadCommon.Gp_Sp_ColHidden(ss2, 0, false);

            //if (p_Ref(1, 1, true, false))
            if(SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[1], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], false))
            {
                this.ss1.ActiveSheet.Rows.Add(0, 60 - this.ss1.ActiveSheet.Rows.Count);
                
                if ((sFromLoc == "S0A0101" || sFromLoc == "S0Q0101" || sFromLoc == "") && (txt_slab_no.Text!=""))
                {
                    for (int i = 0; i < this.ss1_Sheet1.RowCount;i++ )
                    {
                        if (this.ss1_Sheet1.Cells[i, 1].Text == txt_slab_no.Text)
                        {
                            this.ss1_Sheet1.RowHeader.Cells[i, 0].Text = "入库";
                            proNum = 1;
                            txt_slab_cnt.Text = "1";
                            this.ss1_Sheet1.Cells[i, 1].BackColor = Color.Red;
                            break;
                        }
                    }
                }
            }
            else
            {
                setSpread(ss1);
                ss1HaveRowCount = 60;
            }
            this.ss1.SetViewportTopRow(0, 43);

           // if (p_Ref(1, 2, true, false))
            if (SpreadCommon.Gf_Sp_Refer(GeneralCommon.M_CN1, (Collection)Proc_Sc[2], (Collection)Proc_Mc[1], (Collection)((Collection)Proc_Mc[1])["npControl"], (Collection)((Collection)Proc_Mc[1])["mControl"], false))
            {
                int temp = this.ss2.ActiveSheet.Rows.Count;
                this.ss2.ActiveSheet.Rows.Add(0, 60 - this.ss2.ActiveSheet.Rows.Count);
                if (txt_slab_no.Text != "")
                {
                    if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT YARD_ADDR FROM FP_SLABYARD WHERE SLAB_NO = '" + txt_slab_no.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                    {
                        this.ss2_Sheet1.RowHeader.Cells[59 - temp, 0].Text = "增加";
                        this.ss2_Sheet1.Cells[59 - temp, 0].Text = (temp + 1).ToString();
                        this.ss2_Sheet1.Cells[59 - temp, 1].Text = txt_slab_no.Text;
                        this.ss2_Sheet1.Cells[59 - temp, 1].BackColor = Color.Red;
                        this.ss2_Sheet1.Cells[59 - temp, 3].Text = sToLoc;
                        this.ss2_Sheet1.Cells[59 - temp, 15].Text = sFromLoc;
                        this.ss2_Sheet1.Cells[59 - temp, 14].Text = GeneralCommon.sUserID;
                        ssc_can.Enabled = true;
                    }
                    else
                    {
                        if (sToLoc == "")
                        {
                            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
                            {
                                if (this.ss2_Sheet1.Cells[i, 1].Text == txt_slab_no.Text)
                                {
                                    this.ss2_Sheet1.Cells[i, 1].BackColor = Color.Red;

                                }
                            }
                        }
                        if (sFromLoc == "S0A0101" || sFromLoc == "S0Q0101")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("板坯 " + txt_slab_no.Text + " 已经在库中，不需再做入库处理！", "W", "");
                            txt_slab_no.Text = "";
                        }
                    }

                }
            }
            else
            {
                ss2HaveRowCount = 60;
                setSpread(ss2);

                if (txt_slab_no.Text != "" && (sFromLoc == "S0A0101" || sFromLoc == "S0Q0101" || sFromLoc == ""))
                {
                    if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT YARD_ADDR FROM FP_SLABYARD WHERE SLAB_NO = '" + txt_slab_no.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                    {
                        this.ss2_Sheet1.RowHeader.Cells[59, 0].Text = "增加";
                        this.ss2_Sheet1.Cells[59, 0].Text = (1).ToString();
                        this.ss2_Sheet1.Cells[59, 1].Text = txt_slab_no.Text;
                        this.ss2_Sheet1.Cells[59, 1].BackColor = Color.Red;
                        this.ss2_Sheet1.Cells[59, 3].Text = sToLoc;
                        this.ss2_Sheet1.Cells[59, 15].Text = sFromLoc;
                        this.ss2_Sheet1.Cells[59, 14].Text = GeneralCommon.sUserID;
                        txt_slab_cnt.Text = "1";
                        ssc_can.Enabled = true;
                    }
                    else
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("板坯 " + txt_slab_no.Text + " 已经在库中，不需再做入库处理！", "W", "");
                        txt_slab_no.Text = "";
                        return;
                    }
                }

            }
            this.ss2.SetViewportTopRow(0, 43);

            for (int i = 0; i < this.ss1_Sheet1.RowCount;i++ )
            {
                if(this.ss1_Sheet1.Cells[i,1].Text == "")
                {
                    this.ss1_Sheet1.Cells[i, 1].Locked = true;
                    this.ss1_Sheet1.Cells[i, 1].BackColor = Color.White;
                }
            }
            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            {
                if (this.ss2_Sheet1.Cells[i, 1].Text == "")
                {
                    this.ss2_Sheet1.Cells[i, 1].Locked = true;
                    this.ss2_Sheet1.Cells[i, 1].BackColor = Color.White;
                }
            }

            ssc_move.Enabled = false;
            ssc_can.Enabled = false;
            txt_slab_cnt.Enabled = false;
            txt_p_row.Enabled = false;


            for(int i=0;i<this.ss1_Sheet1.RowCount;i++)
            {
                if(this.ss1_Sheet1.Cells[i,1].Text!="")
                {
                    ss1HaveRowCount = i;
                    break;
                }
            }
            for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            {
                if (this.ss2_Sheet1.Cells[i, 1].Text != "")
                {
                    ss2HaveRowCount = i;
                    break;
                }
            }




        }




        public override void Form_Pro()
        {

            string sFromLoc = "";

            if (proNum == 1)
            {
                bool isHave = false;
                for (int i = 0; i < this.ss1_Sheet1.RowCount; i++)
                {

                    if (this.ss1_Sheet1.Cells[i, 1].Text == txt_slab_no.Text)
                    {
                        isHave = true;
                        break;
                    }
                }
                if (!isHave)
                {
                    GeneralCommon.Gp_MsgBoxDisplay("板坯 " + txt_slab_no.Text + " 不在库中，请确认！", "W", "");
                    return;
                }
                p_Pro(1, 2, true, false);
            }

            if (proNum == 2)
            {
                p_Pro(1, 1, true, false);
            }
            if (proNum == 3)
            {
                p_Pro(1, 2, true, false);
            }

            if (proNum == 4)
            {
                p_Pro(1, 2, true, false);
            }
            if (proNum == 5)
            {
                p_Pro(1, 1, true, false);
            }
            //if ((ss1.Enabled && ssc_move.Enabled) || (ss2.Enabled && !ssc_move.Enabled))
            //{
            //    p_Pro(1, 1, true, false);
            //    for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            //    {
            //        this.ss2_Sheet1.RowHeader.Cells[i, 0].Text = "";
            //    }
            //}
            //if ((ss2.Enabled && ssc_move.Enabled) || (ss1.Enabled && !ssc_move.Enabled))
            //{
            //    bool isHave = false;
            //    for (int i = 0; i < this.ss1_Sheet1.RowCount; i++)
            //    {

            //        if (this.ss1_Sheet1.Cells[i, 1].Text == txt_slab_no.Text)
            //        {
            //            isHave = true;
            //            break;
            //        }
            //    }
            //    if (!isHave)
            //    {
            //        GeneralCommon.Gp_MsgBoxDisplay("板坯 " + txt_slab_no.Text + " 不在库中，请确认！", "W", "");
            //        return;
            //    }


            //    p_Pro(1, 2, true, false);
            //    for (int i = 0; i < this.ss2_Sheet1.RowCount; i++)
            //    {
            //        this.ss2_Sheet1.RowHeader.Cells[i, 0].Text = "";
            //    }
            //}
    
            if (opt_Left_Right.Checked)
                sFromLoc = txt_f_addr.Text;
            else
                sFromLoc = txt_t_addr.Text;
            if (sFromLoc == "S0A0101" || sFromLoc == "S0Q0101")
                GeneralCommon.GStatusBar.Panels[0].Text = "板坯成功入库！";
            else
                GeneralCommon.GStatusBar.Panels[0].Text = "您所选板坯的垛位成功变更！";
            txt_slab_no.Text = "";
            Form_Ref();

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            GeneralCommon.MDIToolBar.Refresh();

        }





        public override bool Form_Cls()
        {
            base.Form_Cls();
            //if (SpreadCommon.Gf_Sp_Cls((Collection)Proc_Sc[0]))
            //{
            //    if (SpreadCommon.Gf_Sp_Cls((Collection)Proc_Sc[0]))
            //    {
            //        txt_o_f_addr.Text = "";
            //        txt_o_f_addr_nm.Text = "";
            //        txt_o_t_addr.Text = "";
            //        txt_o_t_addr_nm.Text = "";
            //        txt_slab_cnt.Text = "";
            //        txt_p_row.Text = "";
            //        txt_location1.Text = "";
            //        txt_location2.Text = "";
            //        txt_location3.Text = "";

            //    }
            //}
            txt_o_f_addr.Text = "";
            txt_o_f_addr_nm.Text = "";
            txt_o_t_addr.Text = "";
            txt_o_t_addr_nm.Text = "";
            txt_slab_cnt.Text = "";
            txt_p_row.Text = "";
            txt_location1.Text = "";
            txt_location2.Text = "";
            txt_location3.Text = "";
            setSpread(ss1);
            setSpread(ss2);
            txt_f_addr.Focus();

            opt_Left_Right.ForeColor = Color.Red;
            opt_Right_Left.ForeColor = Color.Black;

            ss1.Enabled = true;
            ss2.Enabled = false;

            ssc_move.Enabled = false;
            ssc_can.Enabled = false;
            txt_slab_cnt.Enabled = false;
            txt_p_row.Enabled = false;
            txt_slab_cnt.Text = "";
            txt_p_row.Text = "";
            proNum = 0;
            return true;
        }

        protected override void form_Activated(object sender, EventArgs e)
        {
            base.form_Activated(sender, e);

            txt_o_f_addr.Text = txt_f_addr.Text;
            txt_o_f_addr_nm.Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "F0009", txt_f_addr.Text, 2);
            txt_o_t_addr.Text = txt_t_addr.Text;
            txt_o_t_addr_nm.Text = GeneralCommon.Gf_ComnNameFind(GeneralCommon.M_CN1, "F0009", txt_t_addr.Text, 2);

            GeneralCommon.ImageList0.Images[4] = GeneralCommon.ImageList2.Images[4];
            GeneralCommon.MDIToolBar.Buttons[6].Tag = "F";
            GeneralCommon.ImageList0.Images[5] = GeneralCommon.ImageList2.Images[5];
            GeneralCommon.MDIToolBar.Buttons[7].Tag = "F";
            GeneralCommon.ImageList0.Images[6] = GeneralCommon.ImageList2.Images[6];
            GeneralCommon.MDIToolBar.Buttons[8].Tag = "F";
            GeneralCommon.MDIToolBar.Refresh();
            this.ss1.SetViewportTopRow(0, 50);
            this.ss2.SetViewportTopRow(0, 50);
        }


        private void setSpread(FarPoint.Win.Spread.FpSpread oSpread)
        {
            oSpread.ActiveSheet.RowCount = 60;
        }

        private void txt_f_addr_TextChanged(object sender, EventArgs e)
        {
            if (txt_f_addr.Text != "")
            {
                if (txt_f_addr.Text.Length == 7 && txt_f_addr.Text != "S0A0101" && txt_f_addr.Text != "S0Q0101")
                {
                    if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT LOCATION FROM FP_STDYARD WHERE LOCATION = '" + txt_f_addr.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay(txt_f_addr.Text + "垛位不正确...!!", "W", "警告");
                        return;
                    }
                }
                cbo_ccm_line.Visible = false;
                if (txt_f_addr.Text == "S0A0101")
                {
                    cbo_ccm_line.Visible = true;
                }
                else if (txt_f_addr.Text != "S0A0101")
                {
                    cbo_ccm_line.Visible = false;
                }
            }
            else
                cbo_ccm_line.Visible = false;

        }

        private void txt_t_addr_TextChanged(object sender, EventArgs e)
        {
            if (txt_t_addr.Text != "")
            {
                if (txt_t_addr.Text.Length == 7 && txt_t_addr.Text != "S0A0101" && txt_t_addr.Text != "S0Q0101")
                {
                    if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT LOCATION FROM FP_STDYARD WHERE LOCATION = '" + txt_t_addr.Text + "' AND YARD_KND = '" + CBO_CUR_INV.Text + "'") == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay(txt_f_addr.Text + "垛位不正确...!!", "W", "警告");
                        return;
                    }
                    txt_slab_no.Text = "";
                }
            }
        }

        private void opt_Left_Right_Click(object sender, EventArgs e)
        {
            opt_Left_Right.ForeColor = Color.Red;
            opt_Right_Left.ForeColor = Color.Black;
            txt_slab_no.Text = "";
            Form_Ref();
            ss1.Enabled = true;
            ss2.Enabled = false;
        }

        private void opt_Right_Left_Click(object sender, EventArgs e)
        {
            opt_Left_Right.ForeColor = Color.Black;
            opt_Right_Left.ForeColor = Color.Red;
            txt_slab_no.Text = "";
            Form_Ref();
            ss1.Enabled = false;
            ss2.Enabled = true;
        }


        protected override void ss_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            base.ss_EditChange(sender, e);
            if (base.i_ScCurrSeq == 1)
                proNum = 2;
            else
                proNum = 3;
        }

        private void txt_location1_DoubleClick(object sender, EventArgs e)
        {
             txt_t_addr.Text = txt_location1.Text;
             Form_Ref();
        }

        private void txt_location2_DoubleClick(object sender, EventArgs e)
        {
            txt_t_addr.Text = txt_location2.Text;
            Form_Ref();
        }

        private void txt_location3_DoubleClick(object sender, EventArgs e)
        {
            txt_t_addr.Text = txt_location3.Text;
            Form_Ref();
        }

        private void txt_slab_no_TextChanged(object sender, EventArgs e)
        {
            if (txt_slab_no.Text != "" && txt_slab_no.Text.Length==10)
            {
                if (GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, "SELECT SLAB_NO FROM FP_SLAB WHERE SLAB_NO = '" + txt_slab_no.Text + "'") == "")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("该板坯不存在，板坯号无效", "W", "");
                    return;
                }
                //if (txt_t_addr.Text!="")
                //{
                //    txt_slab_no.Text = "";
                //}
            }

            //if(txt_f_addr.Text == "S0A0101")
            //{
            //     txt_t_addr.Text = "";
            //     txt_o_t_addr.Text = "";
            //     txt_o_t_addr_nm.Text = "";
            //}
        }

        private void cmd_Loc_Search_Click(object sender, EventArgs e)
        {
            if (txt_slab_no.Text =="")
            {
                GeneralCommon.Gp_MsgBoxDisplay("必须输入板坯号", "W", "错误提示");
                return;
            }
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "AFL2010P";
                GeneralCommon.M_CN1.BeginTrans();
                for (int i = 1; i <= 2; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg1", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg2", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg3", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));

                adoCmd.Parameters[0].Value = "SL";
                adoCmd.Parameters[1].Value = txt_slab_no.Text;
          

                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_msg1"].Value.ToString().StartsWith("NOT"))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("垛位查询失败，请确认", "W", "");
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();
                }
                else
                {

                    txt_location1.Text = adoCmd.Parameters["arg_e_msg1"].Value.ToString();
                    txt_location2.Text = adoCmd.Parameters["arg_e_msg2"].Value.ToString();
                    txt_location3.Text = adoCmd.Parameters["arg_e_msg3"].Value.ToString();
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                }    
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)(ex.Message), "W", "警告");
            }
        }

     

      
        private string Gp_LOC_Exec(string sAddrText, string cbocurText)
        {
           // string sQuery = "{call WGA1040C.P_LOC_TUN ('" + cbocurText + "','" + sAddrText + "',?)}";
            string ret_Result_ErrMsg;
            int ret_Result_ErrCode = 0;
            ADODB.Command adoCmd;
            try
            {
                if (GeneralCommon.M_CN1.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return "ERROR";
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                GeneralCommon.M_CN1.CursorLocation = ADODB.CursorLocationEnum.adUseServer;
                adoCmd = new ADODB.Command();
                adoCmd.ActiveConnection = GeneralCommon.M_CN1;
                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc;
                adoCmd.CommandText = "CGA2010NC.P_LOC_TUN";
                GeneralCommon.M_CN1.BeginTrans();

                for (int i = 1; i <= 2; i++)
                {
                    adoCmd.Parameters.Append(adoCmd.CreateParameter("", ADODB.DataTypeEnum.adVariant, ADODB.ParameterDirectionEnum.adParamInput, 0, null));
                }

                object value = null;
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, value));
                adoCmd.Parameters[0].Value = cbocurText;
                adoCmd.Parameters[1].Value = sAddrText;
                adoCmd.Execute(out value);

                if (adoCmd.Parameters["arg_e_msg"].Value.ToString()=="")
                {
                    GeneralCommon.M_CN1.CommitTrans();
                    GeneralCommon.M_CN1.Close();
                    adoCmd = null;
                    Cursor.Current = Cursors.Default;
                    return "";
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    adoCmd = null;
                    GeneralCommon.M_CN1.RollbackTrans();
                   // return "ERROR";
                }
                return  "ERROR";
            }
            catch (Exception ex)
            {
                adoCmd = null;
                GeneralCommon.M_CN1.RollbackTrans();
                Cursor.Current = Cursors.Default;
                GeneralCommon.Gp_MsgBoxDisplay((string)(ex.Message), "W", "警告");
                return ex.Message + "ERROR";
            }
        }

        private void label13_DoubleClick(object sender, EventArgs e)
        {
            if (txt_f_addr.Text != "")
            {
                if (GeneralCommon.Gf_MessConfirm("确定对垛位（" + txt_f_addr.Text + "）进行垛层调整吗？", "I", "系统提示信息"))
                {
                    string temp22 = Gp_LOC_Exec(txt_f_addr.Text, CBO_CUR_INV.Text);
                    if (temp22 == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("垛位调整完毕！", "W", "");
                        Form_Ref();
                    }
                    else
                        GeneralCommon.Gp_MsgBoxDisplay("垛位调整失败！" + temp22, "W", "");
                }
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            if (txt_t_addr.Text != "")
            {
                if (GeneralCommon.Gf_MessConfirm("确定对垛位（" + txt_t_addr.Text + "）进行垛层调整吗？", "I", "系统提示信息"))
                {
                    string temp222222 = Gp_LOC_Exec(txt_t_addr.Text, CBO_CUR_INV.Text);
                    if (temp222222 == "")
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("垛位调整完毕！", "W", "");
                        Form_Ref();
                    }
                    else
                        GeneralCommon.Gp_MsgBoxDisplay("垛位调整失败！" + temp222222, "W", "");
                }
            }
        }



        int ss1HaveRowCount = 0;
        int ss2HaveRowCount = 0;
        protected override void ss_CellClickEvent(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            //base.ss_CellClickEvent(sender, e);
            FarPoint.Win.Spread.FpSpread oSpread = (FarPoint.Win.Spread.FpSpread)sender;
            if(oSpread.Name == "ss1")
            {
                if (e.Row >= ss1HaveRowCount)
                {
                    
                  //  txt_p_row.Enabled = true;
                    txt_p_row.Text = e.Row + 1 + "";
                    txt_slab_cnt.Text = e.Row - ss1HaveRowCount + 1 + "";

                    for (int i = 0; i < this.ss1_Sheet1.RowCount;i++ )
                    {
                        //if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text != "")
                        if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text == "入库")
                        {
                            Form_Ref();
                            this.ss1_Sheet1.ActiveRowIndex = e.Row;
                            ssc_move_Click(ssc_move, new EventArgs());
                            break;
                        }
                       
                    }

                    ssc_move.Enabled = true;
                    ssc_can.Enabled = true;
                    txt_slab_cnt.Enabled = true;
                }
                else
                {
                    ssc_move.Enabled = false;
                    ssc_can.Enabled = false;
                    txt_slab_cnt.Enabled = false;
                    txt_p_row.Enabled = false;
                    txt_slab_cnt.Text = "";
                }
              //  this.ss1.SetViewportTopRow(0, this.ss1_Sheet1.ActiveRowIndex);

                ////////////////////////////////20140408
              //  txt_slab_no.Text = this.ss1_Sheet1.Cells[e.Row, 1].Text;
                ///////////////////////////////////20140408



            }
            else
            {
                if (e.Row >= ss2HaveRowCount)
                {
                    
                  //  txt_p_row.Enabled = true;
                    txt_p_row.Text = e.Row + 1 + "";
                    txt_slab_cnt.Text = e.Row - ss2HaveRowCount + 1 + "";

                    for (int i = 0; i < this.ss1_Sheet1.RowCount; i++)
                    {
                        if (this.ss1_Sheet1.RowHeader.Cells[i, 0].Text != "")
                        {
                            Form_Ref();

                            this.ss2_Sheet1.ActiveRowIndex = e.Row;
                            ssc_move_Click(ssc_move, new EventArgs());
                            break;
                        }
                    }
                    ssc_move.Enabled = true;
                    ssc_can.Enabled = true;
                    txt_slab_cnt.Enabled = true;

                }
                else
                {
                    ssc_move.Enabled = false;
                    ssc_can.Enabled = false;
                    txt_slab_cnt.Enabled = false;
                    txt_p_row.Enabled = false;
                    txt_slab_cnt.Text = "";
                }
               // this.ss1.SetViewportTopRow(0, this.ss2_Sheet1.ActiveRowIndex);
            }
           

        }

        private void ssc_move_Click(object sender, EventArgs e)
        {
            if (txt_f_addr.Text == "" || txt_t_addr.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("垛位必须输入...!!","W","");
                return;
            }
            if(txt_slab_cnt.Text == "")return;
            if (int.Parse(txt_slab_cnt.Text) <= 0) return;
            if(this.ss1.Enabled)
            {
                if ((this.ss1_Sheet1.ActiveRowIndex - ss1HaveRowCount + 1) < int.Parse(txt_slab_cnt.Text))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("输入的板坯数太大...!!","W","");
                    return;
                }

                for (int i = 0; i < int.Parse(txt_slab_cnt.Text);i++ )
                {

                    this.ss1_Sheet1.Cells[this.ss1_Sheet1.ActiveRowIndex - i, 1].BackColor = Color.Red;
                    this.ss1_Sheet1.RowHeader.Cells[this.ss1_Sheet1.ActiveRowIndex - i, 0].Text = ((txt_f_addr.Text == "S0A0101" || txt_f_addr.Text == "S0Q0101") ? "入库" : "倒垛");

                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 1].Text = this.ss1_Sheet1.Cells[this.ss1_Sheet1.ActiveRowIndex - i, 1].Text;
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 0].Text = 59 - ss2HaveRowCount + 2 + i + "";
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 3].Text = txt_t_addr.Text;
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 1].Locked = false;
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 1].BackColor = Color.Red;
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 14].Text = GeneralCommon.sUserID;
                    this.ss2_Sheet1.Cells[ss2HaveRowCount - 1 - i, 15].Text = txt_f_addr.Text;
                    this.ss2_Sheet1.RowHeader.Cells[ss2HaveRowCount - 1 - i, 0].Text = "增加";    
    
                }
                proNum = 4;
            }
            else
            {
                if ((this.ss2_Sheet1.ActiveRowIndex - ss2HaveRowCount + 1) < int.Parse(txt_slab_cnt.Text))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("输入的板坯数太大...!!", "W", "");
                    return;
                }

                for (int i = 0; i < int.Parse(txt_slab_cnt.Text); i++)
                {

                    this.ss2_Sheet1.Cells[this.ss2_Sheet1.ActiveRowIndex - i, 1].BackColor = Color.Red;
                    this.ss2_Sheet1.RowHeader.Cells[this.ss2_Sheet1.ActiveRowIndex - i, 0].Text = ((txt_t_addr.Text == "S0A0101" || txt_t_addr.Text == "S0Q0101") ? "入库" : "倒垛");

                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 1].Text = this.ss2_Sheet1.Cells[this.ss2_Sheet1.ActiveRowIndex - i, 1].Text;
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 0].Text = 59 - ss1HaveRowCount + 2 + i + "";
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 3].Text = txt_f_addr.Text;
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 1].Locked = false;
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 1].BackColor = Color.Red;
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 14].Text = GeneralCommon.sUserID;
                    this.ss1_Sheet1.Cells[ss1HaveRowCount - 1 - i, 15].Text = txt_t_addr.Text;
                    this.ss1_Sheet1.RowHeader.Cells[ss1HaveRowCount - 1 - i, 0].Text = "增加";

                }
                proNum = 5;
            }
            ssc_move.Enabled = false;
            txt_slab_cnt.Enabled = false;
        }

        private void ssc_can_Click(object sender, EventArgs e)
        {
            ssc_move.Enabled = false;
            ssc_can.Enabled = false;
            txt_slab_cnt.Enabled = false;
            txt_p_row.Enabled = false;
            txt_slab_cnt.Text = "";
            Form_Ref();
        }

        private void CGA2010C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGA2010NC";
            Form_Define();
            setSpread(ss1);
            setSpread(ss2);
            opt_Left_Right.Checked = true;

            opt_Left_Right.ForeColor = Color.Red;
            opt_Right_Left.ForeColor = Color.Black;

            ss1.Enabled = true;
            ss2.Enabled = false;

            ssc_move.Enabled = false;
            ssc_can.Enabled = false;
            txt_slab_cnt.Enabled = false;
            txt_p_row.Enabled = false;

            CBO_CUR_INV.Text = "ZB";
            text_cur_inv.Text = "中板";
        }

        private void CBO_CUR_INV_TextChanged(object sender, EventArgs e)
        {
            if (CBO_CUR_INV.Text == "")
            {
                txt_f_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0043' AND CD like 'S%'ORDER BY CD ASC";
                txt_t_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0043' AND CD like 'S%'ORDER BY CD ASC";
            }
            else
            {
                if (CBO_CUR_INV.Text.StartsWith("H"))
                {
                    txt_f_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0043' AND CD like 'S%'ORDER BY CD ASC";
                    txt_t_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0043' AND CD like 'S%'ORDER BY CD ASC";
                }
                else
                {
                    txt_f_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0009' AND CD like 'S%'ORDER BY CD ASC";
                    txt_t_addr.sSqletc = "SELECT CD " + "代码" + ", CD_SHORT_NAME " + "代码简称" + ",  CD_NAME       " + "代码名称" + ", CD_SHORT_ENG  " + "代码英文简称" + ", CD_FULL_ENG   " + "代码英文名称" + " FROM NISCO.ZP_CD WHERE CD_MANA_NO = 'F0009' AND CD like 'S%'ORDER BY CD ASC";
                }
            }

        }  
    }
}
