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
///-- 系统名            宽厚板生产管制系统                                              
///-- 子系统名          生产运行实绩管理                                                 
///-- 程序名            生产线公辅材料管理界面                                
///-- 程序ID            WKB1020C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.11.14                                                
///-- 处理描述          生产线公辅材料消耗实绩记录                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.11.14        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace WK
{
    public partial class WKB1020C : CommonClass.FORMBASE
    {
        public WKB1020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        // 定义列变量
        public const int SS1_OCCR_DATE = 1;
        public const int SS1_SHIFT = 2;

        #region 界面初始化
        protected override void p_SubFormInit()
        {
            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工序", cbo_prc, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "", "", "", "", imcseq);
            p_SetMc("发生时间", udt_prod_date_from, "P", "", "", "", "", imcseq);
            p_SetMc("发生时间", udt_prod_date_to, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 4, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("工序", "ETCN", "15", "PIR", "CD", "", "SELECT T.CD,T.CD_NAME FROM ZP_CD T WHERE T.CD_MANA_NO = 'C0002'", iscseq, iheadrow, "M");//0
            p_SetSc("发生时间", "D", "10", "PIR", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("班次", "E", "1", "PIR", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("班别", "E", "1", "R", "", "", "", iscseq, iheadrow,"M");//3
            p_SetSc("作业人员", "E", "7", "IRL", "", "", "", iscseq, iheadrow,"M");//4
            p_SetSc("公辅材料代码", "ETCR", "15", "PIR", "CD_MANA_NO", "5;6", "SELECT T.CD,T.CD_NAME FROM ZP_CD T WHERE T.CD_MANA_NO = 'F0014'", iscseq, iheadrow, "M");//5
            p_SetSc("公辅材料名称", "E", "50", "IRL", "", "", "", iscseq, iheadrow);//6
            p_SetSc("消耗量", "N", "15,2", "IR", "", "", "", iscseq, iheadrow);//7
        }

        private void WKB1020C_Load(object sender, EventArgs e)
        {
            Form_Define();
       //     base.sAuthority = "1111";
        }

        protected override void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            base.ss_CellDoubleClick(sender, e);

            // 重写双击事件
            // 声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDD') FROM DUAL";
            // 新建数据库连接
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            // 检查数据库连接状态
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            // 打开数据库连接
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            // 取得系统时间
            string TimeStr = AdoRs.Fields[0].Value.ToString();
            // 对取得系统时间做格式转换
            TimeStr = GeneralCommon.Gf_GetDateStr(TimeStr);
            // 点到活动单元格自动带出系统时间
            if (ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text == "增加" && ss1.ActiveSheet.ActiveCell.Column.Tag.ToString() == "D")
            {
                ss1.ActiveSheet.ActiveCell.Text = TimeStr;
            }
        }

        public override void Spread_Ins()
        {
            base.Spread_Ins();

            // 重写行新增方法
            // 声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDD') FROM DUAL";
            // 新建数据库连接
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            // 检查数据库连接状态
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            // 打开数据库连接
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            // 取得系统时间
            string TimeStr = AdoRs.Fields[0].Value.ToString();
            // 对取得系统时间做格式转换
            TimeStr = GeneralCommon.Gf_GetDateStr(TimeStr);

            // 新增行时第二列自动带出系统时间,第三列自动带出班次
            ss1.ActiveSheet.ActiveCell.Text = "";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OCCR_DATE].Text = TimeStr;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_SHIFT].Text = GeneralCommon.sShift;
        }

        public override bool Form_Cls()
        {
            // 重写清空
            if (base.Form_Cls())
            {
                cbo_prc.Text = "";
                cbo_shift.Text = "";
            }
            return true;
        }
        #endregion
    }
}
