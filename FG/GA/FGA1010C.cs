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
///-- 系统名            宽厚板热处理                                              
///-- 子系统名                                                            
///-- 程序名            抛丸实绩查询及修改界面                                
///-- 程序ID            FGA1010C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2014.07.23                                                
///-- 处理描述          抛丸实绩查询及修改界面                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2014.07.23        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------
///

namespace FG
{
    public partial class FGA1010C : CommonClass.FORMBASE
    {
        public FGA1010C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();

    //    public const int iSs1_Slab_No = 0;  //SS1板坯号

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("工厂", f4ETCR_PLT, "PN", "", "", "", "", imcseq);
            p_SetMc("机号", cbo_PrcLine, "PN", "", "", "", "", imcseq);
            p_SetMc("抛丸", txt_SB, "P", "", "", "", "", imcseq);
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("生产日期", SDT_SCH_DATE, "P", "", "", "", "", imcseq);
            p_SetMc("物料号或者轧坯号", TXT_PROD_CD, "P", "", "", "", "", imcseq);
    

            p_McIni(Mc2, false);
            imcseq = 2;
            p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

           int iheadrow;
           int iscseq;
           p_ScIni(ss1, Sc1, 0, true, true);
           iheadrow = 1;
           iscseq = 1;


            p_SetSc("物料号", "E", "60", "PI", "", "", "", iscseq, iheadrow,"M");//0
            p_SetSc("抛丸代码", "E", "2", "I", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("清洁度%", "N", "3", "I", "", "", "", iscseq, iheadrow,"R");//2
            p_SetSc("行进速度", "N", "4", "I", "", "", "", iscseq, iheadrow,"R");//3
            p_SetSc("面积", "N", "4", "I", "", "", "", iscseq, iheadrow,"R");//4
            p_SetSc("作业日期", "DT", "", "I", "", "", "", iscseq, iheadrow, "M");//5   
            p_SetSc("班次", "E", "60", "I", "", "", "", iscseq, iheadrow,"M");//6
            p_SetSc("班别", "E", "60", "I", "", "", "", iscseq, iheadrow,"M");//7
            p_SetSc("作业人", "E", "60", "I", "", "", "", iscseq, iheadrow,"M");//8
            p_SetSc("下次热处理", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//10
            p_SetSc("厚度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//11
            p_SetSc("宽度", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//12
            p_SetSc("长度", "E", "60", "L", "", "", "", iscseq, iheadrow,"M");//13
            p_SetSc("重量", "E", "60", "L", "", "", "", iscseq, iheadrow, "L");//14
            p_SetSc("货位", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("探伤", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("取样", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("EDT_SEQ", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("SEQ_NO", "E", "60", "I", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("PLT", "E", "60", "I", "", "", "", iscseq, iheadrow);//20
            p_SetSc("PRC_LINE", "E", "60", "I", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("备注", "E", "500", "L", "", "", "", iscseq, iheadrow, "L");//22
            p_SetSc("轧坯号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("紧急订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M");//24

            iheadrow = 0;
            p_spanSpread("产品", 11, 14, iscseq, iheadrow, 1);
          //  SpreadCommon.Gp_Sp_ColHidden(ss1, 0, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 6, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 7, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 18, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 19, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 20, true);
            SpreadCommon.Gp_Sp_ColHidden(ss1, 21, true);
            

        }
      private void FGA1010C_Load(object sender, EventArgs e)
        {
            //base.sSvrPgmPkgName = "FGA1010C";

            Form_Define();
            TXT_EMP.Text = GeneralCommon.sUserID;
            TXT_PLT.Enabled = false;
            f4ETCR_PLT.Enabled = false;
            TXT_PLT.Text = "宽厚板厂";
            f4ETCR_PLT.Text = "C2";
            
    //     //   base.sAuthority = "1111";
    //        txt_upd_emp.Text = GeneralCommon.sUserID;
            
            
        }
        #endregion

      private void ss1_CellClick(object sender, CellClickEventArgs e)
      {
          if (ss1.Sheets[0].Rows.Count <= 0)
          {
              return;
          }


          if (TXT_DISCHARGE_TIME.Text.Substring(0, 1) != "2")
          {
              GeneralCommon.Gp_MsgBoxDisplay("请输入作业日期", "I", "");
              return;
          }

          if (txt_RsltSb.Text == "")
          {
              GeneralCommon.Gp_MsgBoxDisplay("请输入抛丸", "I", "");
              return;
          }

          if (ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text.Trim() == "修改")
          {
              ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "";
          //    ss1.ActiveSheet.Cells[e.Row, 0].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 1].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 2].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 3].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 4].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 5].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 6].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 7].Text = "";
              ss1.ActiveSheet.Cells[e.Row, 8].Text = "";
          }
          else
          {
             // ss1.ActiveSheet.Cells[e.Row, 0].Text = cbo_PrcLine.Text;

              if (txt_RsltSb.Text != "")
              {
                  ss1.ActiveSheet.Cells[e.Row, 1].Text = txt_RsltSb.Text;
              }

              if (txt_SHOT_BLAST_CLEA.Text != "")
              {
                  ss1.ActiveSheet.Cells[e.Row, 2].Text = txt_SHOT_BLAST_CLEA.Text;
              }

              if (TXT_SPEED.Text != "")
              {
                  ss1.ActiveSheet.Cells[e.Row, 3].Text = TXT_SPEED.Text;
              }

              if (TXT_SHOT_BLAST_AREA.Text != "")
              {
                  ss1.ActiveSheet.Cells[e.Row, 4].Text = TXT_SHOT_BLAST_AREA.Text;
              }
              ss1.ActiveSheet.Cells[e.Row, 5].Text = TXT_DISCHARGE_TIME.Text;
              ss1.ActiveSheet.Cells[e.Row, 6].Text = TXT_SHIFT.Text;
              ss1.ActiveSheet.Cells[e.Row, 7].Text = TXT_GROUP.Text;
              ss1.ActiveSheet.Cells[e.Row, 8].Text = GeneralCommon.sUserID;
              ss1.ActiveSheet.RowHeader.Cells[e.Row, 0].Text = "修改";

          }
      }

      private void OPT_SLAB_Click(object sender, EventArgs e)
      {
          if (OPT_SLAB.Checked == true)
          {
              TXT_PROD_CD.Text = "LO";
          }
          else
          {
              TXT_PROD_CD.Text = "SL";
          }
      }

      private void opt_Mat_Click(object sender, EventArgs e)
      {
          if (OPT_Mat.Checked == true)
          {
              TXT_PROD_CD.Text = "SL";
          }
          else
          {
              TXT_PROD_CD.Text = "LO";
          }
      }

      public override bool Form_Cls()
      {
           base.Form_Cls();
           TXT_PROD_CD.Text = "SL";
           OPT_Mat.Checked = true;
           TXT_PLT.Enabled = false;
           f4ETCR_PLT.Enabled = false;
           TXT_PLT.Text = "宽厚板厂";
           f4ETCR_PLT.Text = "C2";
           return true;
      }

    //    // 重写查询
    //    public override void Form_Ref()
    //    {

    //        //查询轧制信息
    //        p_Ref(2, 1, true, true);          

    //    }

    //    private void ss1_CellClick(object sender, CellClickEventArgs e)
    //    {
    //        if (ss1.ActiveSheet.RowCount == 0)
    //        {
    //            return;
    //        }

    //        //只有选择行表头才可进行操作
    //        if (e.Column > 0 & e.Row < 1)
    //        {
    //            return;
    //        }

    //        txt_Status.Text = ss1.ActiveSheet.Cells[e.Row, iSs1_Slab_No].Text;
    //        base.p_Ref(1,0, true, true);
    //    }
    }
}
