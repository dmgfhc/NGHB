using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonClass;
using System.Collections;
using Microsoft.VisualBasic;

namespace CG
{
    public partial class WGE3010C : CommonClass.FORMBASE
    {
        public WGE3010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        protected override void p_SubFormInit()
        {
            int imcseq;
            imcseq = 1;
            p_McIni(Mc1, false);
            p_SetMc("库类型", txt_yard_knd, "PN", "", "", "", "", imcseq);
            p_SetMc("库种类", com_prod_type, "PN", "", "", "", "", imcseq);          
            p_SetMc("跨号", com_yard_type, "PN", "", "", "", "", imcseq);
            p_SetMc("区号", com_zone_type, "P", "", "", "", "", imcseq);

            p_ScIni(ss1, Sc1, 0, true, true);
            int iheadrow;
            iheadrow = 0;
            int iscseq;
            iscseq = 1;

            p_SetSc("库代码", "E", "2", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("库种类", "E", "", "PIL", "", "", "", iscseq, iheadrow, "M");//1            
            p_SetSc("跨号", "E", "", "PIL", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("区号", "E", "", "PIL", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("区位", "E", "3", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("区位宽度", "N", "8", "I", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("区位长度", "N", "8", "I", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("当前库容(t)", "N", "8", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("最大库容(t)", "N", "8", "I", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("录入人员", "E", "7", "ILA", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("录入人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("录入时间", "DT", "15", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("修改人员", "E", "7", "ILA", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("修改人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("修改时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//14
        }

        private void WGE4010C_Load(object sender, EventArgs e)
        {
            Form_Define();
            this.com_yard_type.Enabled = false;
            this.com_zone_type.Enabled = false;
      //      base.sAuthority = "1111";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            this.textBox1.Text = "";
            this.com_zone_type.Text = "";
            return true;
        }

        public override void Form_Pro()
        {
            if (ss1_Sheet1.RowCount < 0) return;
            for (int i = 0; i < ss1_Sheet1.RowCount; i++)
            {
                if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "修改")
                {
                    if (ss1_Sheet1.Cells[i, 8].Text == "0" || ss1_Sheet1.Cells[i, 6].Text == "0" || ss1_Sheet1.Cells[i, 5].Text == "0"||ss1_Sheet1.Cells[i, 5].Text == "" || ss1_Sheet1.Cells[i, 6].Text == "" || ss1_Sheet1.Cells[i, 8].Text == "")
                    {
                        ss1_Sheet1.Cells[i, 5].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 6].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 8].BackColor = Color.Pink;
                        if (ss1_Sheet1.Cells[i, 5].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区宽度不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 5].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区宽度不能为0...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 6].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区的长度不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 6].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区的长度不能为0...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 8].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区最大库容不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 8].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区最大库容不能为0...!!", "W", "警告");
                            return;
                        }
                        return;
                    }
                    ss1_Sheet1.Cells[i, 12].Text = GeneralCommon.sUserID;
                }
                else if (ss1_Sheet1.RowHeader.Cells[i, 0].Text == "增加")
                {
                    if (ss1_Sheet1.Cells[i, 8].Text == "0" || ss1_Sheet1.Cells[i, 6].Text == "0" || ss1_Sheet1.Cells[i, 5].Text == "0" || ss1_Sheet1.Cells[i, 0].Text == "" || ss1_Sheet1.Cells[i, 1].Text == "" || ss1_Sheet1.Cells[i, 2].Text == "" || ss1_Sheet1.Cells[i, 3].Text == "" || ss1_Sheet1.Cells[i, 5].Text == "" || ss1_Sheet1.Cells[i, 6].Text == "" || ss1_Sheet1.Cells[i, 8].Text == "")
                    {
                        ss1_Sheet1.Cells[i, 0].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 1].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 2].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 3].BackColor = Color.Pink;
                      //ss1_Sheet1.Cells[i, 4].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 5].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 6].BackColor = Color.Pink;
                        ss1_Sheet1.Cells[i, 8].BackColor = Color.Pink;
                        if (ss1_Sheet1.Cells[i, 0].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("库代码不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 1].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("库种类不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 2].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("跨号不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 3].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("区号不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 5].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区宽度不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 5].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区宽度不能为0...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 6].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区的长度不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 6].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区的长度不能为0...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 8].Text == "")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区最大库容不能为空...!!", "W", "警告");
                            return;
                        }
                        if (ss1_Sheet1.Cells[i, 8].Text == "0")
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("该区最大库容不能为空0...!!", "W", "警告");
                            return;
                        }
                        return;
                    }
                    ss1_Sheet1.Cells[i, 9].Text = GeneralCommon.sUserID;
                }
            }
            p_Pro(1, 1, true, false);
        }

        public override void Spread_Ins()
        {
            Color color;
            color = System.Drawing.Color.FromArgb(System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(255)), System.Convert.ToInt32((byte)(192)));
            base.Spread_Ins();
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 0].Locked = false;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 1].Locked = false;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 2].Locked = false;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 3].Locked = false;

            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 0].BackColor = color;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 1].BackColor = color;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 2].BackColor = color;
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 3].BackColor = color;

            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 0].Text = txt_yard_knd.Text.Trim();
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 1].Text = com_prod_type.Text.Trim();
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 2].Text = com_yard_type.Text.Trim();
            ss1_Sheet1.Cells[ss1_Sheet1.ActiveRowIndex, 3].Text = com_zone_type.Text.Trim();
        }

        private void com_prod_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
            {
                string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
                this.com_yard_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_yard_type,sql);
            }
        }

        private void txt_yard_knd_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "")
            {
                string sql = "SELECT DISTINCT YARD_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "'";
                this.com_yard_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_yard_type, sql);
            }
        }

        private void com_yard_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txt_yard_knd.Text != "" && this.com_prod_type.Text != "" && this.com_yard_type.Text!="")
            {
                string sql = "SELECT DISTINCT ZONE_TYPE FROM FP_STDAREA WHERE YARD_KND='" + txt_yard_knd.Text.Trim() + "'  AND PROD_TYPE='" + com_prod_type.Text.Trim() + "' AND YARD_TYPE='" + com_yard_type.Text.Trim() + "'";
                this.com_zone_type.Enabled = true;
                GeneralCommon.Gf_ComboAdd(com_zone_type, sql);
            }
        }

      






      
    }
}
