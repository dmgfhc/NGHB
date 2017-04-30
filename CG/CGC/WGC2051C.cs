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
///-- 系统名               宽厚板轧钢作业管理系统                                              
///-- 子系统名             精整作业管理                                                 
///-- 程序名               钢板分板实绩管理界面                                
///-- 程序ID               WGC2051C    
///-- 版本                 1.1                                                   
///-- 文档号                                                         
///-- 设计                 李骞                                                    
///-- 代码                 李骞                                                     
///-- 代码日期             2013.01.15                                                
///-- 处理描述             钢板分板实绩管理界面                                                                         
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2013.01.15        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGC2051C : CommonClass.FORMBASE
    {
        public WGC2051C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();

        public const int iSs1_Div_Date = 3;  //SS1切割时间
        public const int iSs1_User_Id = 18;  //SS1切割时间
        public const int iSs2_Plate_No = 0;  //SS2钢板号
        public const int iSs2_Plan_Date = 21;  //SS2计划时间
        public const int iSs2_Plan_cut_cnt = 5; // SS2切割块数

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_PLATE_NO, "P", "", "", "", imcseq, "");  // 物料号
            p_SetMc(txt_plan_date, "P", "", "", "", imcseq, ""); // 计划时间
            p_SetMc(cbo_div_cnt, "P", "", "", "", imcseq, "");   // 分板数
            p_SetMc(txt_plan_cut_cnt, "P", "", "", "", imcseq, "");   // 计划切割块数
            p_SetMc(txt_Plt_direction, "P", "", "", "", imcseq, "");//分板方向


            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);
            p_SetMc("当前库", f4ETCR_CUR_INV, "PN", "", "", "", "", imcseq);
            p_SetMc("垛位号", TXT_LOC, "P", "", "", "", "", imcseq);
            p_SetMc("钢板号", TXT_PLATE_NO, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_FR, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_PROD_DATE_TO, "P", "", "", "", "", imcseq);
            p_SetMc("标准号", F4ETCN_STDSPEC_R, "P", "", "", "", "", imcseq);
    
            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, iSs1_User_Id, true, false);
            iheadrow = 1;
            iscseq = 1;
            //0-5
            p_SetSc("钢板号", "E", "14", "IRL", "", "", "", iscseq, iheadrow);
            p_SetSc("计划时间", "E", "14", "ANI", "", "", "", iscseq, iheadrow);
            p_SetSc("计划切割时间", "D", "10", "R", "", "", "", iscseq, iheadrow);
            p_SetSc("分板时间", "DT", "19", "NI", "", "", "", iscseq, iheadrow);
            p_SetSc("厚度", "N", "6,2", "NIL", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "NI", "", "", "", iscseq, iheadrow);
            //6-10
            p_SetSc("长度", "N", "8", "NI", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "N", "", "", "", iscseq, iheadrow);
            p_SetSc("标准号", "E", "30", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("尾板", "C", "1", "IRL", "", "", "", iscseq, iheadrow);
            p_SetSc("切边", "C", "1", "IR", "", "", "", iscseq, iheadrow);
            //11-15
            p_SetSc("取样一", "C", "1", "IR", "", "", "", iscseq, iheadrow);
            p_SetSc("取样二", "C", "1", "IR", "", "", "", iscseq, iheadrow);
            p_SetSc("UST", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("切割", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            //16-21
            p_SetSc("热处理", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("备注", "E", "200", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("操作人员", "E", "7", "IRL", "", "", "", iscseq, iheadrow);
            p_SetSc("母钢板", "E", "14", "IRL", "", "", "", iscseq, iheadrow);
            iheadrow = 0;
            p_spanSpread("作业指示", 11, 15, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 0, true, false);
            iheadrow = 1;
            iscseq = 2;
            //0-7
            p_SetSc("钢板号", "E", "14", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("钢板状态", "E", "1", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("工厂", "E", "2", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("产品代码", "E", "2", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("切割时间", "D", "10", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("块数", "E", "10", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("厚度", "N", "6,2", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("宽度", "N", "6", "RL", "", "", "", iscseq, iheadrow);
            //8-12
            p_SetSc("长度", "N", "8,1", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("重量", "N", "15,3", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("切边", "E", "20", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("定尺", "E", "30", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("标准号", "E", "30", "RL", "", "", "", iscseq, iheadrow);
            //13-17
            p_SetSc("UST", "E", "20", "RL", "", "", "", iscseq, iheadrow);           
            p_SetSc("切割", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("矫直", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("热处理", "E", "20", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("备注", "E", "200", "RL", "", "", "", iscseq, iheadrow);
            //18-21
            p_SetSc("库", "E", "2", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("垛位", "E", "10", "RL", "", "", "", iscseq, iheadrow);
            p_SetSc("是否紧急订单", "E", "20", "RL", "", "", "", iscseq, iheadrow,"M");
            p_SetSc("计划时间", "E", "14", "RL", "", "", "", iscseq, iheadrow, "M");
            iheadrow = 0;
            p_spanSpread("作业指示", 13, 17, iscseq, iheadrow, 1);
            p_spanSpread("计划", 4, 5, iscseq, iheadrow, 1);
        }

        private void WGC2051C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "PKG_AGC2030C_LQ";
            Form_Define();
         //   base.sAuthority = "1111";
            f4ETCR_PLT.Text = "C2";
            f4ETCR_CUR_INV.Text = "HB";
            cbo_div_cnt.Text = "2";
            SDT_PROD_DATE_FR.RawDate = DateTime.Now.Date.ToString();
            if (cbo_direction.Text == "宽度方向")
            {
                txt_Plt_direction.Text = "1";
            }
            else if (cbo_direction.Text == "长度方向")
            {
                txt_Plt_direction.Text = "2";
            }
            else
            {
                txt_Plt_direction.Text = "0";
            }
        }

        // 重写查询
        public override void Form_Ref()
        {
            ss1_Sheet1.RowCount = 0;
            p_Ref(2, 2, true, false);
        }

        public override void Spread_Ins()
        {
            if (base.i_ScCurrSeq == 1)
            {
                base.Spread_Ins();
            }
    
        }//Spread_Can

        public override void Spread_Can()
        {
            ss1_Sheet1.RowCount = 0;
        }//

        #endregion

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss2_Sheet1.RowCount == 0)
            {
                return;
            }

            // 取板坯号
            TXT_PLATE_NO.Text = ss2.ActiveSheet.Cells[e.Row, iSs2_Plate_No].Text;
            txt_plan_date.Text = ss2.ActiveSheet.Cells[e.Row, iSs2_Plan_Date].Text;
            txt_plan_cut_cnt.Text = ss2.ActiveSheet.Cells[e.Row, iSs2_Plan_cut_cnt].Text;
            // 按分板数查询
            p_Ref(1, 1, true, false);
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            string TimeStr;

            //base.ss_CellDoubleClick(sender, e)

            if (e.Column != iSs1_Div_Date)
            {
                return;
            }

            //重写双击事件
            //声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
            // 新建数据库连接
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            // 检查数据库连接状态
            if (GeneralCommon.M_CN1.State == 0)
                if (GeneralCommon.GF_DbConnect() == false) return;
            // 打开数据库连接
            AdoRs.Open(sqlStr, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
            // 取得系统时间
            TimeStr = AdoRs.Fields[0].Value.ToString();
            // 对取得系统时间做格式转换
            TimeStr = GeneralCommon.Gf_GetDateStr(TimeStr);
            // 点到活动单元格自动带出系统时间

            ss1.ActiveSheet.Cells.Get(e.Row, iSs1_Div_Date).Text = TimeStr;
            ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text = "修改";
            ss1.ActiveSheet.Cells.Get(e.Row, iSs1_User_Id).Text = GeneralCommon.sUserID;

            //base.i_ScCurrSeq = 1;
        }

        private void BTN_DIV_Click(object sender, EventArgs e)
        {
            p_Ref(1, 1, true, false);
            return;
        }
        public override bool Form_Cls()
        {
            base.Form_Cls();
            f4ETCR_PLT.Text = "C2";
            f4ETCR_CUR_INV.Text = "HB";
            TXT_PLT.Text = "宽厚板厂";
            return true;
            if (cbo_direction.Text == "宽度方向")
            {
                txt_Plt_direction.Text = "1";
            }
            else if (cbo_direction.Text == "长度方向")
            {
                txt_Plt_direction.Text = "2";
            }
            else
            {
                txt_Plt_direction.Text = "0";
            }
        }

        private void cbo_direction_TextChanged(object sender, EventArgs e)
        {
            if (cbo_direction.Text == "宽度方向")
            {
                txt_Plt_direction.Text = "1";
            }
            else if (cbo_direction.Text == "长度方向")
            {
                txt_Plt_direction.Text = "2";
            }
            else
            {
                txt_Plt_direction.Text = "0";
            }
        } 

    }
}
