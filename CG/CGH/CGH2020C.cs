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
///-- 系统名            宽厚板生产管制系统                                              
///-- 子系统名          生产运行实绩管理                                                 
///-- 程序名            生产线停机实绩管理界面                              
///-- 程序ID            CGH2020C    
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              韩超                                                    
///-- 代码              韩超                                                    
///-- 代码日期          2018.01.05                                               
///-- 处理描述          生产线停机记录
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2018.01.05        李骞                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGH2020C : CommonClass.FORMBASE
    {
        public CGH2020C()
        {
            InitializeComponent();

        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        // 定义列变量
        public const int SS1_OCCR_DATE_STR = 6;
        public const int SS1_OCCR_DATE_END = 7;
        //public const int SS1_SHIFT = 8;
        public const int SS1_DEL_RES_CD1 = 1;
        public const int SS1_MA_CD = 2;
        public const int SS1_USER_ID = 11;

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", CBO_PLT, "P", "", "", "", "", imcseq);//1   
            p_SetMc("工序", CBO_PRC, "P", "", "", "", "", imcseq);
            p_SetMc("发生时间", TXT_OCCR_TIME, "P", "", "", "", "", imcseq);
            p_SetMc("发生时间", TXT_OCCR_TIME_TO, "P", "", "", "", "", imcseq);
            p_SetMc("停机代码", TXT_DEL_RES_CD, "P", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);


            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("工厂代码", "E", "2", "PNI", "", "", "", iscseq, iheadrow, "L");//0
            p_SetSc("工序代码", "E", "2", "PNI", "", "", "", iscseq, iheadrow, "L");//1
            p_SetSc("机号", "E", "60", "PNI", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("发生时间", "D", "", "PI", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("停机代码", "E", "5", "PNI", "", "", "", iscseq, iheadrow, "L");//4
            p_SetSc("停机原因说明", "E", "80", "L", "", "", "", iscseq, iheadrow, "L");//5
            p_SetSc("停机开始时间", "E", "", "PNI", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("停机结束时间", "E", "", "I", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("影响时间（Min）", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("班次", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("作业人员", "E", "7", "I", "", "", "", iscseq, iheadrow, "L");//11
            p_SetSc("故障处理人员", "E", "60", "I", "", "", "", iscseq, iheadrow, "L");//12
            p_SetSc("责任单位", "E", "200", "I", "", "", "", iscseq, iheadrow, "L");//13
            p_SetSc("备注", "E", "200", "I", "", "", "", iscseq, iheadrow, "L");//14

            SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 12, true);
           
        }

        private void CGH2020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGH2020NC";
            Form_Define();

            FarPoint.Win.Spread.CellType.ComboBoxCellType cb4 = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            //cb4.ListWidth = 96;
            //cb4.Editable = true;
            //cb4.MaxDrop = 10;
            //cb4.MaxLength = 1;
            //添加选项代码
            string[] shiftList = new string[] { "1", "2", "3"};
            cb4.Items = shiftList;
            ss1.ActiveSheet.Columns[9].CellType = cb4;

            CBO_PLT.Text = "C3";

        }
        //override

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);

            if (ss1.ActiveSheet.RowCount <= 0) return;
            for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {
                string occr_date_str = ss1.ActiveSheet.Cells[i,SS1_OCCR_DATE_STR].Text;
                string occr_date_end = ss1.ActiveSheet.Cells[i,SS1_OCCR_DATE_END].Text;
                if (occr_date_str.Length > 3)
                {
                    ss1.ActiveSheet.Cells[i, SS1_OCCR_DATE_STR].Text = occr_date_str.Substring(0, 2) + ":" + occr_date_str.Substring(2);
                }
                if (occr_date_end.Length > 3)
                {
                    ss1.ActiveSheet.Cells[i, SS1_OCCR_DATE_END].Text = occr_date_end.Substring(0, 2) + ":" + occr_date_end.Substring(2);
                }

            }
        }

        public override void Form_Pro()
        {
            p_Pro(1, 1, true, true);
        }

        //private void ss1_CellClick(object sender, CellClickEventArgs e)
        //{
        //    if (ss1.Sheets[0].Rows.Count <= 0)
        //    {
        //        return;
        //    }

        //    //if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
        //    //{
        //    //   // ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
        //    //    isRefer = true;
        //    //    SpreadCommon.Gp_Sp_Cancel(GeneralCommon.M_CN1, (Collection)Proc_Sc[i_ScCurrSeq]);
        //    //    isRefer = false;
        //    //}
        //    //else

        //    if (TXT_DEL_RES_CD.Text != "" )
        //    {
        //        switch (e.Column)
        //        {
        //            case SS1_DEL_RES_CD1:
        //                ss1.ActiveSheet.Cells[e.Row, SS1_DEL_RES_CD1].Text = TXT_DEL_RES_CD.Text;
        //                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
        //                break;
                  
        //        }
        //    }
        //}
        protected void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ////base.ss_CellDoubleClick(sender, e);
            //// 重写行新增事件
            //// 声明变量
            //string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
            //// 新建数据库连接
            //ADODB.Recordset AdoRs = new ADODB.Recordset();
            //// 检查数据库连接状态
            //if (GeneralCommon.M_CN1.State == 0)
            //    if (GeneralCommon.GF_DbConnect() == false) return;
            //// 打开数据库连接
            //AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            //// 取得系统时间
            //string TimeStr = AdoRs.Fields[0].Value.ToString();
            //// 对取得系统时间做格式转换
            //TimeStr = GeneralCommon.Gf_GetDateStr(TimeStr);
            //// 点到活动单元格自动带出系统时间
            //if (ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text == "增加" && ss1.ActiveSheet.ActiveCell.Column.Tag.ToString() == "DT")
            //{
            //    // 第四列双击时间显示
            //    if (e.Column == SS1_OCCR_DATE_STR)
            //        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OCCR_DATE_STR].Text = TimeStr;
            //    // 第五列双击时间显示
            //    if (e.Column == SS1_OCCR_DATE_END)
            //        ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OCCR_DATE_END].Text = TimeStr;
            //}
            string TimeStr = DateTime.Now.ToString("HHmm");
            if (e.Column == SS1_OCCR_DATE_END)
            {
                ss1.ActiveSheet.Cells[e.Row, SS1_OCCR_DATE_END].Text = TimeStr.Substring(0, 2) + ":" + TimeStr.Substring(2);
                ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
            }
            

        }

        public override void Spread_Ins()
        {
            base.Spread_Ins();
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, 0].Text = "C3";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD1].Text = "CB";//GeneralCommon.sShift;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_MA_CD].Text = "1";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_USER_ID].Text = GeneralCommon.sUserID;
        }

        public override bool Form_Cls()
        {
            // 重写清空
            if (base.Form_Cls())
            {
                CBO_PRC.Text = "";
                CBO_SHIFT.Text = "";
                CBO_PLT.Text = "C3";
            }
            return true;
        }
        #endregion

       

    }
}
