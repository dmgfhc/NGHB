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

namespace CK
{
    public partial class WKB1030C : CommonClass.FORMBASE
    {
        public WKB1030C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();


        #region 界面初始化
        protected override void p_SubFormInit()
        {        
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("发生日期", SDT_PROD_DATE_FROM, "PN", "","", "", "", imcseq);//1
            p_SetMc("发生日期", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);//2
            p_SetMc("班次", CBO_SHIFT_REF, "P", "", "", "", "", imcseq);//3
            p_SetMc("工序", f4ETCR1, "P", "", "", "", "", imcseq);//4
            p_SetMc("种类", CBO_SCRAP_CD, "RN", "", "", "", "", imcseq);//5
            p_SetMc("种类2", TXT_SCRAP_CD, "P", "", "", "", "", imcseq);//6
            p_SetMc("废钢总量", SDB_TOT_WGT, "R", "", "", "", "", imcseq);//7
            p_SetMc("标记", txt_Flag, "P", "", "", "", "", imcseq);//8
            p_SetMc("查询废钢号", TXT_MAT_NO, "P", "", "", "", "", imcseq);//9

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("发生时间", "D", "", "R", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("班次", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("班别", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("工序代码", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("工序名", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("轧制钢种", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//5
            p_SetSc("废钢种类", "E", "", "R", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("废钢号", "E", "", "R", "", "", "", iscseq, iheadrow);//7
            p_SetSc("废钢重量", "E", "", "R", "", "", "", iscseq, iheadrow);//8
            p_SetSc("原因", "E", "", "R", "", "", "", iscseq, iheadrow);//9
            p_SetSc("原因描述", "E", "", "R", "", "", "", iscseq, iheadrow);//10
            p_SetSc("结束时间", "D", "", "R", "", "", "", iscseq, iheadrow);//11
            p_SetSc("去向", "E", "", "R", "", "", "", iscseq, iheadrow);//12
            p_SetSc("剁位", "E", "", "R", "", "", "", iscseq, iheadrow);//13

            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("工厂代码", CBO_PLT, "PNIR", "", "", "", "", imcseq);//1               
            p_SetMc("工序代码", f4ETCR2, "PNIR", "", "", "", "", imcseq);//2         
          //  p_SetMc("工序名称", TXT_PRC_INPUT_NAME, "N", "", "", "", "", imcseq);//3    
            p_SetMc("CBO_LINE", CBO_LINE, "PNIR", "", "", "", "", imcseq);//4              
            p_SetMc("发生日期", TXT_OCCR_TIME, "PNIR", "", "", "", "", imcseq);//5         
            p_SetMc("班次", CBO_SHIFT, "PNIR", "", "", "", "", imcseq);//6             
            p_SetMc("班别", CBO_GROUP, "PIR", "", "", "", "", imcseq);//7             
          //  p_SetMc("种类", CBO_SCRAP_INPUT, "PNIR", "", "", "", "", imcseq);//8       
            p_SetMc("种类", TXT_SCRAP_INPUT, "PNIR", "", "", "", "", imcseq);//9       
            p_SetMc("废钢号", TXT_SCRAP_NO, "PIR", "", "", "", "", imcseq);//10         
            p_SetMc("原因代码", f4ETCR3, "PNIR", "", "", "", "", imcseq);//11             
          //  p_SetMc("原因名称", txt_main_res_cd, "N", "", "", "", "", imcseq);//12      
            p_SetMc("废钢重量", SDB_SCRAP_WGT, "NIR", "", "", "", "", imcseq);//13        
            p_SetMc("增减量", cbo_ths_d_mat_var, "I", "", "", "", "", imcseq);//14    
            p_SetMc("增减量数据", sdb_ths_d_mat_var, "I", "", "", "", "", imcseq);//15    
            p_SetMc("用户ID", txt_UserId, "I", "", "", "", "", imcseq);//16           
            p_SetMc("结束时间", TXT_END_TIME, "I", "", "", "", "", imcseq);//17         
            p_SetMc("去向", TXT_END_CD, "I", "", "", "", "", imcseq);//18              
          
        }

        private void WKB1030C_Load(object sender, EventArgs e)
        {
            Form_Define();
            txt_UserId.Text = GeneralCommon.sUserID;
            CBO_LINE.Text = "1";
            txt_Flag.Text = "C2";
            CBO_PLT.Text = "C2";
           
        }
        //自定义查询方法
        public override void Form_Ref()
        {
            //base.Form_Ref();
            p_Ref(1,1,true,true);
        }
        //自定义清空方法
        public override bool Form_Cls()
    {
        base.Form_Cls();
        txt_Flag.Text = "C2";
        CBO_LINE.Text = "1";
        CBO_PLT.Text = "C2";
        if (CBO_SCRAP_INPUT.Text.Length >= 2)
        {
            TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text.Substring(0, 2);
        }
        else
        {
            TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text;
        }

        this.TXT_SCRAP_NO.Enabled = true;
        this.CBO_PLT.Enabled = true;
        this.f4ETCR2.Enabled = true;
        this.CBO_LINE.Enabled = true;
        this.TXT_OCCR_TIME.Enabled = true;
        this.CBO_SHIFT.Enabled = true;
        this.CBO_GROUP.Enabled = true;
        this.TXT_SCRAP_INPUT.Enabled = true;
        this.TXT_SCRAP_NO.Enabled = true;
        this.f4ETCR3.Enabled = true;
     
        return true;
       
    }
        //控件字符截取
        private void CBO_END_CD_TextChanged(object sender, EventArgs e)
        {
            if (CBO_END_CD.Text.Length >= 2)
            {
                TXT_END_CD.Text = CBO_END_CD.Text.Substring(0, 2);
            }
            else
            {
                TXT_END_CD.Text = CBO_END_CD.Text;

            }
        }
        //控件字符截取
        private void CBO_SCRAP_CD_TextChanged(object sender, EventArgs e)
        {
            if (CBO_SCRAP_CD.Text.Length >= 2)
            {
                TXT_SCRAP_CD.Text = CBO_SCRAP_CD.Text.Substring(0,2);
            }
            else
            {
                TXT_SCRAP_CD.Text = CBO_SCRAP_CD.Text;
            }
        }

        
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
           //表单中有数据才可以读取数据，执行查询操作
            if (ss1.Sheets[0].Rows.Count > 0)
            {
                TXT_OCCR_TIME.RawDate = ss1.ActiveSheet.Cells[e.Row, 0].Text;
                CBO_SHIFT.Text = ss1.ActiveSheet.Cells[e.Row, 1].Text;
                CBO_GROUP.Text = ss1.ActiveSheet.Cells[e.Row, 2].Text;
                f4ETCR2.Text = ss1.ActiveSheet.Cells[e.Row, 3].Text;
                TXT_SCRAP_INPUT.Text = ss1.ActiveSheet.Cells[e.Row, 6].Text.Substring(0, 2);
                CBO_SCRAP_INPUT.Text = ss1.ActiveSheet.Cells[e.Row, 6].Text;
                TXT_SCRAP_NO.Text = ss1.ActiveSheet.Cells[e.Row, 7].Text;
                SDB_SCRAP_WGT.Text = ss1.ActiveSheet.Cells[e.Row, 8].Text;
                f4ETCR3.Text = ss1.ActiveSheet.Cells[e.Row, 9].Text;
                txt_main_res_cd.Text = ss1.ActiveSheet.Cells[e.Row, 10].Text;
                TXT_END_TIME.RawDate = ss1.ActiveSheet.Cells[e.Row, 11].Text;
                CBO_END_CD.Text = ss1.ActiveSheet.Cells[e.Row, 12].Text;
                CBO_LINE.Text = "1";
                txt_Flag.Text = "C2";
                CBO_PLT.Text = "C2";
            

                base.p_Ref(2, 0, false, true);
                TXT_END_TIME.Enabled = true;
                this.f4ETCR2.Enabled = true;
                this.f4ETCR3.Enabled = true;
            }

        }
        public override void Form_Pro()
        {
            p_pro(2, 0, true, false);
        }

        public override void Form_Del()
        {
            TXT_END_TIME.Enabled = false;
            this.f4ETCR2.Enabled = false;
            this.f4ETCR3.Enabled = false;
            p_del(2, 0, true);
            p_Ref(1, 1, true, true);
        }

        #endregion       

        private void CBO_SCRAP_INPUT_TextChanged(object sender, EventArgs e)
        {
            if (CBO_SCRAP_INPUT.Text.Length >= 2)
            {
                TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text.Substring(0, 2);
            }
            else
            {
                TXT_SCRAP_INPUT.Text = CBO_SCRAP_INPUT.Text;
            }
        }
    
    }
}
