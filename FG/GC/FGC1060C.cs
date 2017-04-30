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
///-- 程序名            淬火实绩查询界面                                
///-- 程序ID            FGC1060C    
///-- 版本              1.0                                                   
///-- 文档号                                                         
///-- 设计              李超                                                    
///-- 代码              李超                                                     
///-- 代码日期          2015.10.12                                                
///-- 处理描述          淬火实绩查询界面                                                                          
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
    public partial class FGC1060C : CommonClass.FORMBASE
    {
        public FGC1060C()
        {
            InitializeComponent();
        }


        Collection Mc1 = new Collection();
        //Collection Mc2 = new Collection();
        Collection Sc1 = new Collection();



        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("物料号", TXT_MAT_NO, "P", "", "", "", "", imcseq);
            p_SetMc("产线", txt_prc_line, "P", "", "", "", "", imcseq);
            p_SetMc("生产开始时间", SDT_PROD_DATE_FR, "PN", "", "", "", "", imcseq);
            p_SetMc("生产结束时间", SDT_PROD_DATE_TO, "PN", "", "", "", "", imcseq);
            p_SetMc("班次", CBO_SHIFT, "P", "", "", "", "", imcseq);
            p_SetMc("班别", CBO_GROUP, "P", "", "", "", "", imcseq);
            




            //p_McIni(Mc2, false);
            //imcseq = 2;
            //p_SetMc("生产时间", TXT_DISCHARGE_TIME, "", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, true, false);
            iheadrow = 0;
            iscseq = 1;

            p_SetSc("生产厂", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//0
            p_SetSc("物料号", "E", "14", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("标准号", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//2
            p_SetSc("坯料钢种", "E", "40", "L", "", "", "", iscseq, iheadrow, "L");//3
            p_SetSc("厚度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//4
            p_SetSc("宽度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//5
            p_SetSc("长度", "E", "10", "L", "", "", "", iscseq, iheadrow, "R");//6
            p_SetSc("热处理方法", "E", "4", "L", "", "", "", iscseq, iheadrow, "M");//7
            p_SetSc("淬火开始时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//8
            p_SetSc("淬火结束时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M");//9
            p_SetSc("返红温度", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//10
            p_SetSc("水温", "N", "4", "L", "", "", "", iscseq, iheadrow, "R");//11
            p_SetSc("辊速（m/s）", "N", "4,2", "L", "", "", "", iscseq, iheadrow, "R");//12
            p_SetSc("摆动次数", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//13
            p_SetSc("流量_1_1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//14
            p_SetSc("流量_1_2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//15
            p_SetSc("水比_1_1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//16
            p_SetSc("水比_1_2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//17
            p_SetSc("集管2中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//18
            p_SetSc("集管3中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//19
            p_SetSc("集管4中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//20
            p_SetSc("集管5中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//21
            p_SetSc("集管6中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//22
            p_SetSc("集管7中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//23
            p_SetSc("集管8中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//24
            p_SetSc("集管9中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//25
            p_SetSc("集管10中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//26
            p_SetSc("集管11中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//27
            p_SetSc("集管12中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//28
            p_SetSc("集管13中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//29
            p_SetSc("集管14中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//30
            p_SetSc("集管15中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//31
            p_SetSc("集管16中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//32
            p_SetSc("集管17中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//33
            p_SetSc("集管18中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//34
            p_SetSc("集管19中部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//35
            p_SetSc("集管2下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//36
            p_SetSc("集管3下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//37
            p_SetSc("集管4下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//38
            p_SetSc("集管5下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//39
            p_SetSc("集管6下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//40
            p_SetSc("集管7下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//41
            p_SetSc("集管8下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//42
            p_SetSc("集管9下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//43
            p_SetSc("集管10下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//44
            p_SetSc("集管11下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//45
            p_SetSc("集管12下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//46
            p_SetSc("集管13下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//47
            p_SetSc("集管14下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//48
            p_SetSc("集管15下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//49
            p_SetSc("集管16下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//50
            p_SetSc("集管17下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//51
            p_SetSc("集管18下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//52
            p_SetSc("集管19下流量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//53
            p_SetSc("集管2边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//54
            p_SetSc("集管3边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//55
            p_SetSc("集管4边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//56
            p_SetSc("集管5边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//57
            p_SetSc("集管6边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//58
            p_SetSc("集管7边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//59
            p_SetSc("集管8边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//60
            p_SetSc("集管9边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//61
            p_SetSc("集管10边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//62
            p_SetSc("集管11边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//63
            p_SetSc("集管12边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//64
            p_SetSc("集管13边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//65
            p_SetSc("集管14边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//66
            p_SetSc("集管15边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//67
            p_SetSc("集管16边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//68
            p_SetSc("集管17边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//69
            p_SetSc("集管18边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//70
            p_SetSc("集管19边部流量", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//71
            p_SetSc("集管2下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//72
            p_SetSc("集管3下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//73
            p_SetSc("集管4下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//74
            p_SetSc("集管5下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//75
            p_SetSc("集管6下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//76
            p_SetSc("集管7下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//77
            p_SetSc("集管8下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//78
            p_SetSc("集管9下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//79
            p_SetSc("集管10下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//80
            p_SetSc("集管11下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//81
            p_SetSc("集管12下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//82
            p_SetSc("集管13下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//83
            p_SetSc("集管14下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//84
            p_SetSc("集管15下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//85
            p_SetSc("集管16下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//86
            p_SetSc("集管17下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//87
            p_SetSc("集管18下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//88
            p_SetSc("集管19下流量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow, "R");//89
            p_SetSc("班次", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//90
            p_SetSc("班别", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//91
            p_SetSc("作业人员", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//92


             }

        private void FGC1060C_Load(object sender, EventArgs e)
        {
            Form_Define();
            txt_prc_line.Text = "1";
        }

        public override bool Form_Cls()
        {
            base.Form_Cls();
            return true;
        }

      }
   }

#endregion