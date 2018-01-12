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
///-- 程序ID            WKB1010C    
///-- 版本              1.1                                                   
///-- 文档号                                                            
///-- 设计              李骞                                                    
///-- 代码              李骞                                                    
///-- 代码日期          2012.11.12                                               
///-- 处理描述          生产线停机记录
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.11.14        李骞                                             
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CK
{
    public partial class WKB1010C : CommonClass.FORMBASE
    {
        public WKB1010C()
        {
            InitializeComponent();

        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        // 定义列变量
        public const int SS1_OCCR_DATE_STR = 6;
        public const int SS1_OCCR_DATE_END = 7;
        public const int SS1_SHIFT = 9;
        public const int SS1_DEL_RES_CD1 = 1;
        public const int SS1_DEL_RES_CD2 = 2;
        public const int SS1_DEL_RES_CD3 = 3;
        public const int SS1_DEL_RES_CD4 = 4;
        public const int SS1_DEL_RES_REASON = 5;

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
        //    p_SetMc("停机代码", txt_del_res_cd1, "P", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 11, true, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("工序代码", "ETCN", "15", "PNIR", "CD", "", "SELECT T.CD,T.CD_NAME FROM ZP_CD T WHERE T.CD_MANA_NO = 'C0002'", iscseq, iheadrow, "M");//0
            p_SetSc("停机代码一级", "ETCR", "10", "NIR", "CD_MANA_NO", "1", "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = 'WG003'", iscseq, iheadrow);//1
            p_SetSc("停机代码二级", "E", "10", "NIR", "", "", "", iscseq, iheadrow);//2
            p_SetSc("停机代码三级", "ETCR", "15", "NIR", "CD_MANA_NO", "3", "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = 'WG005'", iscseq, iheadrow, "M");//3
            p_SetSc("停机代码四级", "ETCR", "15", "NIR", "CD_MANA_NO", "4", "SELECT T.cd,T.cd_short_name,T.cd_name FROM zp_cd T WHERE T.cd_mana_no = 'WG007'", iscseq, iheadrow, "M");//4
            p_SetSc("停机原因说明", "E", "50", "LR", "", "", "", iscseq, iheadrow);//5
            p_SetSc("停机开始时间", "DT", "19", "PNIR", "", "", "", iscseq, iheadrow, "M");//6
            p_SetSc("停机结束时间", "DT", "19", "IR", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("影响时间(Min)", "N", "6,1", "IR", "", "", "", iscseq, iheadrow);//8
            p_SetSc("班次", "E", "1", "NIR", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("班别", "E", "1", "LR", "", "", "", iscseq, iheadrow, "M");//10
            p_SetSc("作业人员", "E", "7", "IRL", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("责任单位", "E", "20", "NIR", "", "", "", iscseq, iheadrow);//12
            p_SetSc("备注", "E", "200", "IR", "", "", "", iscseq, iheadrow);//13
        }

        private void WKB1010C_Load(object sender, EventArgs e)
        {
            Form_Define();
        //    base.sAuthority = "1111";
        }
        //override

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            if (ss1.Sheets[0].Rows.Count <= 0)
            {
                return;
            }

            //if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
            //{
            //   // ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
            //    isRefer = true;
            //    SpreadCommon.Gp_Sp_Cancel(GeneralCommon.M_CN1, (Collection)Proc_Sc[i_ScCurrSeq]);
            //    isRefer = false;
            //}
            //else

            if (txt_del_res_cd1.Text != "" && txt_del_res_cd2.Text != "")
            {
                switch (e.Column)
                {
                    case SS1_DEL_RES_CD1:
                        ss1.ActiveSheet.Cells[e.Row, SS1_DEL_RES_CD1].Text = txt_del_res_cd1.Text;
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                        break;
                    case SS1_DEL_RES_CD2:
                        ss1.ActiveSheet.Cells[e.Row, SS1_DEL_RES_CD2].Text = txt_del_res_cd2.Text;
                        ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";
                        break;
                }
            }
        }
        protected void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            //base.ss_CellDoubleClick(sender, e);
            // 重写行新增事件
            // 声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDDHH24MISS') FROM DUAL";
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
            if (ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text == "增加" && ss1.ActiveSheet.ActiveCell.Column.Tag.ToString() == "DT")
            {
                // 第四列双击时间显示
                if (e.Column == SS1_OCCR_DATE_STR)
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OCCR_DATE_STR].Text = TimeStr;
                // 第五列双击时间显示
                if (e.Column == SS1_OCCR_DATE_END)
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_OCCR_DATE_END].Text = TimeStr;
            }
        }

        public override void Spread_Ins()
        {
            base.Spread_Ins();
            // 重写行新增方法
            // 声明变量
            string sqlStr = "select to_char(sysdate,'YYYYMMDD') FROM DUAL";
            // 工序代码轧机
            string sPrc = "CB";
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
            // 新增行时第一列自动带出工序代码,第七列自动带出班次
            ss1.ActiveSheet.ActiveCell.Text = cbo_prc.Text;//sPrc;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_SHIFT].Text = cbo_shift.Text;//GeneralCommon.sShift;
            //ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD].Text = txt_del_res_cd.Text;
            //ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_REASON].Text = txt_del_res_reson.Text; 
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD1].Text = txt_del_res_cd1.Text;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD2].Text = txt_del_res_cd2.Text;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD3].Text = txt_del_res_cd3.Text;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_CD4].Text = txt_del_res_cd4.Text;
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SS1_DEL_RES_REASON].Text = txt_del_res_reson.Text;
        }

        // 更新数据
        private void btn_cmd_edit_Click(object sender, EventArgs e)
        {
            // 班次必须输入
            if (cbo_shift.Text == "")
            {
                GeneralCommon.Gp_MsgBoxDisplay("请选择班次!!!", "I", this.Text);
                return;
            }
            // 参数定义
            string[] Para = new string[2];
            // 发生时间
            Para[0] = udt_prod_date_from.RawDate;
            // 班次
            Para[1] = cbo_shift.Text;
            // 调用存储过程
            if (GeneralCommon.Gf_ExecProcedure(GeneralCommon.M_CN1, "WKB1010C.P_CAL_DELAY", Para))
            {
                GeneralCommon.Gp_MsgBoxDisplay("更新数据成功..!!", "I", this.Text);
                // 更新完成后清空查询结果
                //this.Form_Cls();
                this.Form_Ref();
            }
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

        private void txt_del_res_cd1_TextChanged(object sender, EventArgs e)
        {
            txt_del_res_cd2.sSqletc = "SELECT cd,cd_short_name,cd_name FROM zp_cd t WHERE t.cd_mana_no = 'WG004'AND SUBSTR(t.cd,0,1) = " + txt_del_res_cd1.Text;
            if (txt_del_res_cd1.Text != "")
            {
                txt_del_res_cd2.Enabled = true;
                txt_del_res_cd.Text = txt_del_res_cd1.Text + txt_del_res_cd2.Text + txt_del_res_cd3.Text + txt_del_res_cd4.Text;
                string sQuery1 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG003' AND cd =" + "'" + txt_del_res_cd1.Text + "'";
                txt_del_res_reson.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery1);
            }
            else
            {
                txt_del_res_cd2.Text = "";
                txt_del_res_cd3.Text = "";
                txt_del_res_cd4.Text = "";
                txt_del_res_cd2.Enabled = false;
                //txt_del_res_cd3.Enabled = false;
                //txt_del_res_cd4.Enabled = false;

            }
            
        }

        private void txt_del_res_cd2_TextChanged(object sender, EventArgs e)
        {
            if (txt_del_res_cd2.Text != "")
            {
                //txt_del_res_cd3.Enabled = true;
                txt_del_res_cd.Text = txt_del_res_cd1.Text + txt_del_res_cd2.Text + txt_del_res_cd3.Text + txt_del_res_cd4.Text;
                string sQuery1 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG003' AND cd =" + "'" + txt_del_res_cd1.Text + "'";
                string sQuery2 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG004' AND cd =" + "'" + txt_del_res_cd2.Text + "'";
                txt_del_res_reson.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery1) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery2);


            }
            else
            {
                txt_del_res_cd3.Text = "";
                txt_del_res_cd4.Text = "";
                //txt_del_res_cd3.Enabled = false;
                //txt_del_res_cd4.Enabled = false;
            }
        }

        private void txt_del_res_cd3_TextChanged(object sender, EventArgs e)
        {
            if (txt_del_res_cd3.Text != "")
            {
               // txt_del_res_cd4.Enabled = true;
                txt_del_res_cd.Text = txt_del_res_cd1.Text + txt_del_res_cd2.Text + txt_del_res_cd3.Text + txt_del_res_cd4.Text;
                string sQuery1 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG003' AND cd =" + "'" + txt_del_res_cd1.Text + "'";
                string sQuery2 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG004' AND cd =" + "'" + txt_del_res_cd2.Text + "'";
                string sQuery3 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG005' AND cd =" + "'" + txt_del_res_cd3.Text + "'";
                txt_del_res_reson.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery1) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery2) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery3);
            }
            else
            {
                txt_del_res_cd4.Text = "";
                //txt_del_res_cd4.Enabled = false;
            }
        }

        private void txt_del_res_cd4_TextChanged(object sender, EventArgs e)
        {
            txt_del_res_cd.Text = txt_del_res_cd1.Text + txt_del_res_cd2.Text + txt_del_res_cd3.Text  + txt_del_res_cd4.Text ;
            string sQuery1 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG003' AND cd =" + "'" + txt_del_res_cd1.Text + "'";
            string sQuery2 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG004' AND cd =" + "'" + txt_del_res_cd2.Text + "'";
            string sQuery3 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG005' AND cd =" + "'" + txt_del_res_cd3.Text + "'";
            string sQuery4 = "SELECT cd_short_name FROM zp_cd WHERE cd_mana_no = 'WG007' AND cd =" + "'" + txt_del_res_cd4.Text + "'" ;
            txt_del_res_reson.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery1) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery2) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery3) + GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery4);
        }

    }
}
