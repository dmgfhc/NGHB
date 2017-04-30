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
    public partial class WGC1010C : CommonClass.FORMBASE
    {
        public WGC1010C()
        {
            InitializeComponent();
        }

        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        public const int iSs1_Plate_No = 0;  //SS1钢板号
        public const int iSs1_Prod_Cd = 1;   //SS1产品代码
        public const int iSs1_Sche_Fl = 10;  //SS1计划状态
        public const int iSs1_Upd_Emp = 14;  //SS1更新人员
        public const int iSs1_Sche_Sts = 15; //SS1指示操作

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("生产日期", sdt_date_fr, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", sdt_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("轧制号", txt_slab_no, "P", "10", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 14, true, true);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("母板号", "E", "14", "PNI", "", "", "", iscseq, iheadrow);      
            p_SetSc("产品代码", "E", "2", "NI", "", "", "", iscseq, iheadrow,"M");  
            p_SetSc("厚度", "N", "6,2", "", "", "", "", iscseq, iheadrow);          
            p_SetSc("宽度", "N", "6", "", "", "", "", iscseq, iheadrow);            
            p_SetSc("长度", "N", "8", "", "", "", "", iscseq, iheadrow);            
            p_SetSc("重量", "N", "15,3", "", "", "", "", iscseq, iheadrow);         
            //6-10
            p_SetSc("标准号", "E", "30", "", "", "", "", iscseq, iheadrow);         
            p_SetSc("钢板数量", "N", "3", "", "", "", "", iscseq, iheadrow);        
            p_SetSc("生产日期", "DT", "19", "", "", "", "", iscseq, iheadrow, "L");  
            p_SetSc("班次", "E", "1", "", "", "", "", iscseq, iheadrow, "M");       
            p_SetSc("计划状态", "E", "1", "", "", "", "", iscseq, iheadrow, "M");  
            //11-15
            p_SetSc("上冷床温度", "N", "4", "", "", "", "", iscseq, iheadrow);     
            p_SetSc("上冷床时间", "DT", "19", "", "", "", "", iscseq, iheadrow);    
            p_SetSc("是否紧急订单", "E", "1", "", "", "", "", iscseq, iheadrow);   
            p_SetSc("作业人员", "E", "7", "NI", "", "", "", iscseq, iheadrow);    
            p_SetSc("指示操作", "E", "1", "NI", "", "", "", iscseq, iheadrow,"M");

            iheadrow = 0;
            p_spanSpread("冷床信息", 11, 12, iscseq, iheadrow, 1);


        }
        private void WGC1010C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_LIQIAN_TEST";
            Form_Define();
          //  base.sAuthority = "1111";     
        }
        #endregion

        //#region //保存
        //public override void Form_Pro()
        //{
        //    base.p_pro(1, 1, true, false);
        //    return;
        //}
        //#endregion

        #region //表单单击操作
        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            string sRowLabel;
            string sScheFl;  //计划状态( Y:已下达 N:未下达)
            string sScheSts; //接口标识（A:下达   D:取消）
            if (e.ColumnHeader) return;

            //只有选择行表头才可进行操作
            if (e.Column != 0)
            {
                return;
            }

            sRowLabel = ss1_Sheet1.RowHeader.Rows[e.Row].Label;
            //取消前次操作
            if (sRowLabel == "修改")
            {
                ss1_Sheet1.RowHeader.Rows[e.Row].Label = "";
                ss1_Sheet1.Cells[e.Row, iSs1_Sche_Sts].Text = "";
                return;
            }
            //初始化指示操作标识
            if (sche_sent.Checked)
            {
                sScheFl = "Y";                
                sScheSts = "A";
            }
            else
            {
                sScheFl = "N";
                sScheSts = "D";
            }
            //检查指示操作有效性
            if (sScheFl == ss1_Sheet1.Cells[e.Row, iSs1_Sche_Fl].Text)
            {
                GeneralCommon.Gp_MsgBoxDisplay("指示已下达", "I", this.Text);
                return;
            }
            //指示操作
            ss1_Sheet1.RowHeader.Rows[e.Row].Label = "修改";
            ss1_Sheet1.Cells[e.Row, iSs1_Sche_Sts].Text = sScheSts;
            ss1_Sheet1.Cells[e.Row, iSs1_Upd_Emp].Text = GeneralCommon.sUserID;
        }
        #endregion
    }
}
