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
using Microsoft.Office.Interop.Excel;
using System.IO;

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            热处理实绩查询(装炉时间)界面                               
///-- 程序ID            FGC1020C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              李超                                                    
///-- 代码              李超                                                     
///-- 代码日期          2014.08.14                                                
///-- 处理描述          热处理实绩查询(装炉时间)界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.08.14        李超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGC1020C : CommonClass.FORMBASE
    {
        public FGC1020C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

        const int COL_IN_TIME = 40,
                  COL_OUT_TIME = 41,
                  SPD_USER = 38,
                  SPD_PLATE_NO = 0,
                  SPD_PLATE_CNT = 5,
                  SPD_PLATE_WGT = 11;
                  



        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("产线", TXT_PRC_LINE, "PN", "", "", "", "", imcseq);
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "PN", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("方式", TXT_PROD_CD, "P", "", "", "", "", imcseq);
            p_SetMc("工厂", TXT_PLT, "P", "", "", "", "", imcseq);
            p_SetMc("炉座号", cbo_PrcLine, "P", "", "", "", "", imcseq);
            p_SetMc("热处理厂", TXT_HTM_PLT, "P", "", "", "", "", imcseq);




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 1;
            iscseq = 1;

            p_SetSc("物料号", "E", "14", "PIL", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("首件标识", "C", "1", "I", "", "", "", iscseq, iheadrow, "M");
            p_SetSc("顺序", "E", "10", "PIL", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("生产厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("客户交货期", "D", "8", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("进程代码", "E", "5", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("钢种", "E", "40", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//7
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//8
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow, "R");//9
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("装炉日期", "D", "", "I", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("装炉时间", "T", "", "NI", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("热处理方法", "E", "10", "NI", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("炉座号", "E", "1", "I", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("装钢温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("测量长度", "N", "8,1", "I", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("装炉班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("装炉班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("装炉人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("装炉人员姓名", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("出炉日期", "D", "", "NI", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("出炉时间", "T", "", "NI", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("加热炉段时间", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("均热炉段时间", "N", "9", "I", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("炉内停留时间", "N", "5", "I", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("工艺升温速率", "N", "4,2", "", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("设定温度", "N", "4", "AI", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("平均温度(计算)", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("加热温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("入炉速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("工艺速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("出炉速度", "N", "5,2", "I", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("出炉班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("出炉班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("出炉人员", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("出炉人员姓名", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//36
            p_SetSc("更新人员", "E", "14", "IL", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("更新人员姓名", "E", "14", "L", "", "", "", iscseq, iheadrow, "R");//38
            p_SetSc("进入时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "R");//39
            p_SetSc("离开时间", "DT", "", "I", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("进入温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("离开温度", "N", "4", "I", "", "", "", iscseq, iheadrow, "R");//42
            p_SetSc("头部水量", "N", "6,4", "I", "", "", "", iscseq, iheadrow, "R");//43
            p_SetSc("尾部水量", "N", "6,4", "I", "", "", "", iscseq, iheadrow, "R");//44
            p_SetSc("轧批号", "E", "14", "", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("返红温度", "E", "14", "", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("水温", "E", "14", "", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("辊速（m/s）", "E", "14", "", "", "", "", iscseq, iheadrow, "R");//48
            p_SetSc("钢板摆动次数", "E", "14", "", "", "", "", iscseq, iheadrow, "R");//49

            iheadrow = 0;
            p_spanSpread("产品", 8, 11, iscseq, iheadrow, 1);
            p_spanSpread("产品", 40, 45, iscseq, iheadrow, 1);

            SpreadCommon.Gp_Sp_ColHidden(ss1, 2, true);


        }

        private void rdo_mat_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "SL";
            rdo_mat.ForeColor = System.Drawing.Color.Red;
            rdo_out.ForeColor = System.Drawing.Color.Black;
        }

        private void rdo_out_Click(object sender, EventArgs e)
        {
            TXT_PROD_CD.Text = "LO";
            rdo_out.ForeColor = System.Drawing.Color.Red;
            rdo_mat.ForeColor = System.Drawing.Color.Black;
        }

        private void FGC1020C_Load(object sender, EventArgs e)
        {
            Form_Define();
            rdo_mat.Checked = true;
            rdo_mat.ForeColor = System.Drawing.Color.Red;
            if (rdo_mat.Checked == true)
            {
                TXT_PROD_CD.Text = "SL";
            }

        }

        public override void Form_Ref()
        {
            p_Ref(1, 1, true, true);

            double Plate_Wgt = 0;
            double Plate_Cnt = 0;
            string sValue = "";


for (int i = 0; i < ss1.ActiveSheet.RowCount; i++)
            {

	Plate_Cnt = Plate_Cnt +1;
	
	 //计算 重量 累计
                sValue = ss1.ActiveSheet.Cells[i, SPD_PLATE_WGT].Text;
                if (sValue == "")
                {

                }
                else
                {
                    Plate_Wgt = double.Parse(sValue) + Plate_Wgt;
                }


	if (ss1.ActiveSheet.RowCount == i + 1)
                {
 		    ss1.ActiveSheet.Rows.Add(ss1.ActiveSheet.RowCount, 1);
		    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PLATE_NO].Text = "轧制块数";
            ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PLATE_CNT].Text = (Plate_Cnt).ToString(); //累计轧制块数
		    ss1.ActiveSheet.Cells[ss1.ActiveSheet.RowCount - 1, SPD_PLATE_WGT].Text = (Plate_Wgt).ToString(); //累计轧制重量
		    break;
		 }
		  SpreadCommon.Gp_Sp_ActiveCell(ss1, 1, ss1.ActiveSheet.RowCount - 1);
	
		}


        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            rdo_mat.Checked = true;
            TXT_PLT.Text = "C2";
            return true;
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
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
            //if (ss1.ActiveSheet.RowHeader.Cells.Get(e.Row, 0).Text == "增加" && ss1.ActiveSheet.ActiveCell.Column.Tag.ToString() == "DT")
            //{
                // 第四列双击时间显示
                if (e.Column == COL_IN_TIME)
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, COL_IN_TIME].Text = TimeStr;
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SPD_USER].Text = GeneralCommon.sUserID;
                // 第五列双击时间显示
                if (e.Column == COL_OUT_TIME)
                    ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, COL_OUT_TIME].Text = TimeStr;
                ss1.ActiveSheet.Cells[ss1.ActiveSheet.ActiveRowIndex, SPD_USER].Text = GeneralCommon.sUserID;
            //}

        }



        private void rdo_out_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_mat_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

#endregion