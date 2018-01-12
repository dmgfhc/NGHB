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

///-------------------------------------------------------------------------------
///-- 程序头注释 ++++++++++++++++++++++++++++++++++++++++++++++++++++++  
///-------------------------------------------------------------------------------
///-- 系统名            宽厚板生产管制系统                                              
///-- 子系统名          作业指示管理                                                 
///-- 程序名            精整作业指示查询界面                                
///-- 程序ID            WKB1030C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              李骞                                                    
///-- 代码              李骞                                                     
///-- 代码日期          2012.11.26                                                
///-- 处理描述          精整作业指示查询                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2012.11.26        李骞                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CK
{
    public partial class WKA1030C : CommonClass.FORMBASE
    {
        public WKA1030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Mc4 = new Collection();
        Collection Mc5 = new Collection();
        Collection Mc6 = new Collection(); 
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();
        Collection Sc6= new Collection();

        public const int SS1_URGNT_FL = 18;//紧急订单
        public const int SS1_IMP_CONT = 19;//重点订单

        public const int SS2_PLATE_STATUS = 39;//钢板状态

        public const int SS2_CON_STYLE = 40; //配置形状
        public const int SS2_X_COORDINATE = 41; //X坐标
        public const int SS2_Y_COORDINATE = 42; //Y坐标
        public const int SS2_OVER_FL = 19;//超量排产
        public const int SS2_ORDER_FL =18;//订单材/余材
        public const int SS2_TRIM_FL = 26;//切边

        public const int SS2_ORD_WID = 6;//宽度
        public const int SS2_ORD_LEN = 8;//长度


       

        int iCool_wid = 4700,
            iCool_len = 0,
            iCool_len1 = 0,
            iCool_len2 = 0,
            iLine_s = 0,
            iGas_thk = 50;

        string sOrd_size, sLabelText;

        bool bChange_fl, buttonMoveFlag = false;

        ArrayList lbl = new ArrayList();
        ArrayList lLine = new ArrayList();

         #region 界面初始化

        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc("轧制时间", udt_prod_date_from, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", udt_prod_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "1", "", "", "", imcseq);
            p_SetMc("板坯号", txt_slab_no, "P", "10", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 17, true, false);
            iheadrow = 1;
            iscseq = 1;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("产品类型", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("轧制代码", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//3
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("轧制标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("订单厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("目标厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("厚度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("厚度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("订单数量", "N", "3", "L", "", "", "", iscseq, iheadrow,"M");//13
            p_SetSc("母板数量", "N", "3", "L", "", "", "", iscseq, iheadrow,"M");//14
            p_SetSc("轧制订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("轧制结束时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("紧急订单", "E", " ", "", "", "", "", 1, 1, "M");//18
            p_SetSc("重点订单", "E", " ", "", "", "", "", 1, 1, "M");//19



            iheadrow = 0;
            p_spanSpread("轧制实绩", 5, 7, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc2, 21, true, false);
            iheadrow = 0;
            imcseq = 2;
            iscseq = 2;
            p_McIni(Mc2, false);
            p_SetMc(txt_slab_num, "P", "", "", "", imcseq, "");  // 板坯号

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow,"M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("轧制异常", "E", "50", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("订单宽度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//7
            //p_SetSc("宽度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("订单长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//10  订单长度
            p_SetSc("订单长度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//11  订单长度上下限
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("是否紧急订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("试样备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("尺寸备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("打包备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("订单材", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//19
            p_SetSc("超量排产", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("订单标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);//22 订单标准号
            p_SetSc("牌号", "E", "30", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("标识次数", "N", "1", "L", "", "", "", iscseq, iheadrow);//24 标识次数
            p_SetSc("客户名称", "E", "80", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//26
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow,"M");//27
            p_SetSc("探伤", "E", "4", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("喷涂交货", "E", "4", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("是否在线淬火", "E", "20", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("取样长度", "E", "20", "L", "", "", "", iscseq, iheadrow);//32
            p_SetSc("订取样频次", "N", "4", "L", "", "", "", iscseq, iheadrow);//33 订取样频次
            p_SetSc("认证标识", "E", "5", "L", "", "", "", iscseq, iheadrow);//34
            p_SetSc("加喷内容", "E", "30", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("侧喷加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("冲印加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//37
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//38
            p_SetSc("生产备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//39
            p_SetSc("钢板状态", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//40
            p_SetSc("配置形状", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//41
            p_SetSc("X坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//42
            p_SetSc("Y坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//43
            

            


            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("板坯号", txt_slab_no, "P", "10", "", "", "", imcseq);
            p_SetMc("轧制时间", udt_prod_date_from, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", udt_prod_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "1", "", "", "", imcseq);
           

            p_ScIni(ss1, Sc3, 17, true, false);
            iheadrow = 1;
            iscseq = 3;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("产品类型", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("轧制标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("订单厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("目标厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("厚度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("厚度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("订单数量", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("母板数量", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("轧制订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("轧制结束时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("紧急订单", "E", " ", "", "", "", "", 1, 1, "M");//18
            p_SetSc("重点订单", "E", " ", "", "", "", "", 1, 1, "M");//19

            iheadrow = 0;
            p_spanSpread("轧制实绩", 5, 7, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc4, 21, true, false);
            iheadrow = 0;
            imcseq = 4;
            iscseq = 4;
            p_McIni(Mc4, false);
            p_SetMc(txt_slab_num, "P", "", "", "", imcseq, "");  // 板坯号

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("轧制异常", "E", "50", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("订单宽度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//7
            //p_SetSc("宽度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//42
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("订单长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//8订单长度
            p_SetSc("订单长度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//9  订单长度上下限
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("是否紧急订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("试样备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("尺寸备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("打包备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("订单材", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("超量排产", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//19
            p_SetSc("订单标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);//20 订单标准号
            p_SetSc("牌号", "E", "30", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("标识次数", "N", "1", "L", "", "", "", iscseq, iheadrow);//43 标识次数
            p_SetSc("客户名称", "E", "80", "L", "", "", "", iscseq, iheadrow);//22
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//23
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//24
            p_SetSc("探伤", "E", "4", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("喷涂交货", "E", "4", "L", "", "", "", iscseq, iheadrow);//26
            p_SetSc("是否在线淬火", "E", "20", "L", "", "", "", iscseq, iheadrow);//27
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("取样长度", "E", "20", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("订取样频次", "N", "4", "L", "", "", "", iscseq, iheadrow);//30 订取样频次
            p_SetSc("认证标识", "E", "5", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("加喷内容", "E", "30", "L", "", "", "", iscseq, iheadrow);//32
            p_SetSc("侧喷加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//33
            p_SetSc("冲印加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//34
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("生产备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("钢板状态", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("配置形状", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("X坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//39
            p_SetSc("Y坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//40



            p_McIni(Mc5, false);
            imcseq = 5;
            p_SetMc("板坯号", txt_slab_no, "P", "10", "", "", "", imcseq);
            p_SetMc("轧制时间", udt_prod_date_from, "P", "", "", "", "", imcseq);
            p_SetMc("轧制时间", udt_prod_date_to, "P", "", "", "", "", imcseq);
            p_SetMc("班次", cbo_shift, "P", "1", "", "", "", imcseq);
            

            p_ScIni(ss1, Sc5, 17, true, false);
            iheadrow = 1;
            iscseq = 5;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("数据来源", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("产品类型", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("轧制代码", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//3
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "M");//4
            p_SetSc("轧制标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//7
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("订单厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("目标厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//10
            p_SetSc("厚度下限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//11
            p_SetSc("厚度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("订单数量", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//13
            p_SetSc("母板数量", "N", "3", "L", "", "", "", iscseq, iheadrow, "M");//14
            p_SetSc("轧制订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//15
            p_SetSc("轧制结束时间", "DT", "19", "L", "", "", "", iscseq, iheadrow);//16
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow);//17
            p_SetSc("紧急订单", "E", " ", "", "", "", "", 1, 1, "M");//18
            p_SetSc("重点订单", "E", " ", "", "", "", "", 1, 1, "M");//19
  

            iheadrow = 0;
            p_spanSpread("轧制实绩", 5, 7, iscseq, iheadrow, 1);

            p_ScIni(ss2, Sc6, 21, true, false);
            iheadrow = 0;
            imcseq = 6;
            iscseq = 6;
            p_McIni(Mc6, false);
            p_SetMc(txt_slab_num, "P", "", "", "", imcseq, "");  // 板坯号

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);//0
            p_SetSc("母板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//1
            p_SetSc("钢板顺序", "E", "2", "L", "", "", "", iscseq, iheadrow, "M");//2
            p_SetSc("产品分类", "E", "10", "L", "", "", "", iscseq, iheadrow);//3
            p_SetSc("轧制异常", "E", "50", "L", "", "", "", iscseq, iheadrow);//4
            p_SetSc("厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//5
            p_SetSc("宽度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//6
            p_SetSc("订单宽度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//7
           // p_SetSc("宽度上限", "N", "6,2", "L", "", "", "", iscseq, iheadrow);//8
            p_SetSc("长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//9
            p_SetSc("订单长度", "N", "8,1", "L", "", "", "", iscseq, iheadrow);//10 订单长度
            p_SetSc("订单长度上下限", "E", "30", "L", "", "", "", iscseq, iheadrow);//11  订单长度上下限
            p_SetSc("重量", "N", "15,3", "L", "", "", "", iscseq, iheadrow);//12
            p_SetSc("订单号", "E", "14", "L", "", "", "", iscseq, iheadrow);//13
            p_SetSc("是否紧急订单", "E", "14", "L", "", "", "", iscseq, iheadrow);//14
            p_SetSc("试样备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//15
            p_SetSc("尺寸备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//16
            p_SetSc("打包备注", "E", "100", "L", "", "", "", iscseq, iheadrow, "M");//17
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M");//18
            p_SetSc("订单材", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//19
            p_SetSc("超量排产", "E", "", "L", "", "", "", iscseq, iheadrow, "M");//20
            p_SetSc("标准", "E", "30", "L", "", "", "", iscseq, iheadrow);//21
            p_SetSc("订单标准号", "E", "30", "L", "", "", "", iscseq, iheadrow);//22 订单标准号
            p_SetSc("牌号", "E", "30", "L", "", "", "", iscseq, iheadrow);//23
            p_SetSc("标识次数", "N", "1", "L", "", "", "", iscseq, iheadrow);//24 标识次数
            p_SetSc("客户名称", "E", "80", "L", "", "", "", iscseq, iheadrow);//25
            p_SetSc("定尺", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//26
            p_SetSc("切边", "E", "10", "L", "", "", "", iscseq, iheadrow, "M");//27
            p_SetSc("探伤", "E", "4", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("喷涂交货", "E", "4", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("是否在线淬火", "E", "20", "L", "", "", "", iscseq, iheadrow);//30
            p_SetSc("热处理", "E", "20", "L", "", "", "", iscseq, iheadrow);//28
            p_SetSc("取样长度", "E", "20", "L", "", "", "", iscseq, iheadrow);//29
            p_SetSc("订取样频次", "N", "4", "L", "", "", "", iscseq, iheadrow);//30 订取样频次
            p_SetSc("认证标识", "E", "5", "L", "", "", "", iscseq, iheadrow);//31
            p_SetSc("加喷内容", "E", "30", "L", "", "", "", iscseq, iheadrow);//32
            p_SetSc("侧喷加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//33
            p_SetSc("冲印加喷", "E", "30", "L", "", "", "", iscseq, iheadrow);//34
            p_SetSc("订单备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//35
            p_SetSc("生产备注", "E", "400", "L", "", "", "", iscseq, iheadrow);//36
            p_SetSc("钢板状态", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//37
            p_SetSc("配置形状", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");//38
            p_SetSc("X坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//39
            p_SetSc("Y坐标", "N", "8", "L", "", "", "", iscseq, iheadrow);//40
        }
        private void WKA1030C_Load(object sender, EventArgs e)
        {
            string sQuery;

            Form_Define();

            ss1.ActiveSheet.LockBackColor = Color.Empty;
            ss2.ActiveSheet.LockBackColor = Color.Empty;

            sQuery = "SELECT MAXI FROM EP_SLABDESIGN WHERE PLT = 'C2' AND APLY_ITEM = 'SLABDESIGN008' AND PRC_LINE = '1'";
            iCool_len1 = Convert.ToInt32(GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, sQuery));

            //Select Gas Cutting Length (Thk > 50, Multi Row Design)
            sQuery = "SELECT MAXI FROM EP_SLABDESIGN WHERE PLT = 'C2' AND APLY_ITEM = 'SLABDESIGN021' AND PRC_LINE = '1'";
            iCool_len2 = Convert.ToInt32(GeneralCommon.Gf_FloatFind(GeneralCommon.M_CN1, sQuery));
            iCool_len = iCool_len1;
            iLine_s = Convert.ToInt32((Convert.ToDouble(pan_posi.Size.Width) / Convert.ToDouble(iCool_len)) * Convert.ToDouble(iCool_len2));
        }

        protected override void ss_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            // 重写单元格双击事件
            base.ss_CellDoubleClick(sender, e);

            // 取板坯号
            txt_slab_num.Text = ss1.ActiveSheet.Cells[e.Row, 0].Text;
            // 按轧制实绩查询
            if (rdo_fp_slab_des.Checked)
            {
                p_Ref(2, 2, true, true);
                lbl_create(e.Row);
            }
            // 按订单材查询
            else if (rdo_ord_fl.Checked)
            {
                p_Ref(4, 4, true, true);
                lbl_create(e.Row);
            }
            // 按炼钢计划查询
            else
            {
                p_Ref(6, 6, true, true);
            }

            string sBlockSeq ;
            string sSeq ;
            string sRec_sts;

            for (int lRow = 0; lRow <= ss2.ActiveSheet.RowCount - 1; lRow++)
            {
                // 如果母板顺序和钢板顺序为00,则为轧件
                if (ss2.ActiveSheet.Cells[lRow, 1].Text == "00" && ss2.ActiveSheet.Cells[lRow, 2].Text == "00") {

                    SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Black, label5.BackColor);
                    ss2.ActiveSheet.Cells[lRow, 3].Text = "轧件";
                }
                // 如果母板顺序为00,钢板顺序不为00,则为母板
                else if (ss2.ActiveSheet.Cells[lRow, 2].Text == "00" && ss2.ActiveSheet.Cells[lRow, 1].Text == "01")
                {
                    SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Black, label6.BackColor);
                    ss2.ActiveSheet.Cells[lRow, 3].Text = "母板" + ss2.ActiveSheet.Cells[lRow, 1].Text;
                }
                // 否则为钢板
                else
                {
                    SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Black, label7.BackColor);
                    ss2.ActiveSheet.Cells[lRow, 3].Text = "钢板";
                    if (ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "2" || ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "3")
                        SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Black, label8.BackColor);
                    if (ss2.ActiveSheet.Cells[lRow, SS2_OVER_FL].Text == "超量" || ss2.ActiveSheet.Cells[lRow, SS2_ORDER_FL].Text == "余材")
                    {
                        if (ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "2" || ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "3")
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Red, label8.BackColor);
                        }
                        else
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Red, label7.BackColor);
                        }
                    }

                    if (ss2.ActiveSheet.Cells[lRow, SS2_TRIM_FL].Text != "Y")
                    {
                        if (ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "2" || ss2.ActiveSheet.Cells[lRow, SS2_PLATE_STATUS].Text == "3")
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Brown, label8.BackColor);
                        }
                        else
                        {
                            SpreadCommon.Gp_Sp_RowColor(ss2, lRow, Color.Brown, label7.BackColor);
                        }
                    }
                }

            }
        }

        // 重写查询
        public override void Form_Ref()
        {
            if (rdo_fp_slab_des.Checked)
            {
                p_Ref(1, 1, true, true);

                if (ss1_Sheet1.RowCount == 0)
                {
                    return;
                }
                for (int i = 0; i < ss1_Sheet1.RowCount; i++)
                {
                    ss1_Sheet1.Rows.Get(i).BackColor = Color.White;

                    //紧急订单
                    if (ss1_Sheet1.Cells[i, SS1_URGNT_FL].Text == "Y")
                    {
                        ss1_Sheet1.Rows.Get(i).BackColor = Color.Green;
                    }
                    //重点订单
                    if (ss1_Sheet1.Cells[i, SS1_IMP_CONT].Text == "Y")
                    {
                        ss1_Sheet1.Rows.Get(i).BackColor = Color.Orange;
                    }
                }
            }
            // 按订单材查询
            else if (rdo_ord_fl.Checked)
            {
                p_Ref(3, 3, true, true);
            }
            // 按炼钢计划查询
            else
            {
                p_Ref(5, 5, true, true);
            }
        }

            // 重写导出方法
        public override void Spread_Exc()
        {
            // 选择明细导出
            if (this.chk_detail.Checked)
                SpreadCommon.Gp_Sp_Excel(ss2);
            else
                SpreadCommon.Gp_Sp_Excel(ss1);
        }

        // 选轧制实绩查询
        private void rdo_fp_slab_des_Click(object sender, EventArgs e)
        {
            if (rdo_fp_slab_des.Checked == true)
            {
                rdo_fp_slab_des.ForeColor = System.Drawing.Color.Red;
                rdo_ord_fl.ForeColor = System.Drawing.Color.Black;
                rdo_ep_slab_des.ForeColor = System.Drawing.Color.Black;
                txt_spd_cd.Text = "M";

            }
        }
        // 选订单材查询
        private void rdo_ord_fl_Click(object sender, EventArgs e)
        {
            if (rdo_ord_fl.Checked == true)
            {
                rdo_ord_fl.ForeColor = System.Drawing.Color.Red;
                rdo_fp_slab_des.ForeColor = System.Drawing.Color.Black;
                rdo_ep_slab_des.ForeColor = System.Drawing.Color.Black;
                txt_spd_cd.Text = "D";

            }
        }
        // 选炼钢计划查询
        private void rdo_ep_slab_des_Click(object sender, EventArgs e)
        {
            if (rdo_ep_slab_des.Checked == true)
            {
                rdo_ep_slab_des.ForeColor = System.Drawing.Color.Red;
                rdo_fp_slab_des.ForeColor = System.Drawing.Color.Black;
                rdo_ord_fl.ForeColor = System.Drawing.Color.Black;
                txt_spd_cd.Text = "L";

            }
        }

        private void lbl_create(int iActiveRow)
        {
            int iRwid,
                iRlen,
                size_wid,
                size_len,
                x_s,
                y_s;

            string sOrd_size, sPosi_Type, splate_sql;

            //Line Clear
            Line_Delete();

            //inti Plate Information
            foreach (object Ctrl in lbl)
            {
                Label Ctr = (Label)Ctrl;
                this.pan_posi.Controls.Remove(Ctr);
            }

            for (int i = lbl.Count - 1; i >= 0; i--)
            {
                lbl.RemoveAt(i);
            }

            for (int i = 0; i <= ss2.ActiveSheet.RowCount - 1; i++)
            {
                if (ss2.ActiveSheet.GetText(i, 2) != "00")
                {
                    Label Pb = new Label();

                    size_wid = Convert.ToInt32(ss2.ActiveSheet.GetValue(i, SS2_ORD_WID) == "" ? "0" : ss2.ActiveSheet.GetValue(i, SS2_ORD_WID));
                    size_len = Convert.ToInt32(ss2.ActiveSheet.GetValue(i, SS2_ORD_LEN) == "" ? "0" : ss2.ActiveSheet.GetValue(i, SS2_ORD_LEN));

                    sPosi_Type = ss2.ActiveSheet.GetText(i, SS2_CON_STYLE);

                    splate_sql = ss2.ActiveSheet.GetText(i, 2); //钢板顺序

                    x_s = Convert.ToInt32(ss2.ActiveSheet.GetValue(i, 14) == "" ? "0" : ss2.ActiveSheet.GetValue(i, SS2_X_COORDINATE));
                    y_s = Convert.ToInt32(ss2.ActiveSheet.GetValue(i, 15) == "" ? "0" : ss2.ActiveSheet.GetValue(i, SS2_Y_COORDINATE));

                    sOrd_size = Convert.ToString(size_wid) + " X " + Convert.ToString(size_len) + "(" + splate_sql + ")";

                    //Size Convert
                    iRwid = Convert.ToInt32((Convert.ToDouble(pan_posi.Size.Height) / Convert.ToDouble(iCool_wid)) * (sPosi_Type.Equals("L") ? Convert.ToDouble(size_wid) : Convert.ToDouble(size_len)));
                    iRlen = Convert.ToInt32((Convert.ToDouble(pan_posi.Size.Width) / Convert.ToDouble(iCool_len)) * (sPosi_Type.Equals("L") ? Convert.ToDouble(size_len) : Convert.ToDouble(size_wid)));

                    //Position Convert
                    x_s = Convert.ToInt32((Convert.ToDouble(pan_posi.Size.Width) / Convert.ToDouble(iCool_len)) * Convert.ToDouble(x_s));
                    y_s = Convert.ToInt32((Convert.ToDouble(pan_posi.Size.Height) / Convert.ToDouble(iCool_wid)) * Convert.ToDouble(y_s));

                    Pb.Text = sOrd_size;
                    

                    Pb.AutoSize = false;
                    Pb.Size = new System.Drawing.Size(iRlen, iRwid);  //(width, height)
                    Pb.Location = new Point(x_s, y_s);

                    Pb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Pb.BackColor = System.Drawing.Color.LightSteelBlue;
                    Pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    Pb.Font = new System.Drawing.Font("宋体", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    Pb.ForeColor = System.Drawing.Color.Black;
                    Pb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbUp);
                    Pb.MouseHover += new System.EventHandler(this.PbHover);
                    Pb.MouseLeave += new System.EventHandler(this.PbLeave);

                    this.pan_posi.Controls.Add(Pb);
                    lbl.Add(Pb);

                    Pb.BringToFront();
                }
            }

            //Line Create (Gas Cutting Flag)
            if (ss1.ActiveSheet.GetText(iActiveRow, 3) != "1" ||
                Convert.ToDouble(ss1.ActiveSheet.GetValue(iActiveRow, 16) == "" ? "0" : ss1.ActiveSheet.GetValue(iActiveRow, 16)) > iGas_thk)
            {
                Line_Create();
            }
        }

        private void PbUp(object sender, MouseEventArgs e)
        {
            sLabelText = ((Label)sender).Name;

            if (buttonMoveFlag)
                buttonMoveFlag = false;
        }

        private ToolTip ToolTip;

        private void PbHover(object sender, EventArgs e)
        {
            string sMouseHoverText;
            ToolTip = new ToolTip();

            sMouseHoverText = ((Label)sender).Name;

            foreach (object Ctrl in lbl)
            {
                Label Ctr = (Label)Ctrl;

                if (Ctr.Name.Equals(sMouseHoverText))
                    ToolTip.SetToolTip(Ctr, Convert.ToString(Ctr.Tag));
            }
        }

        private void PbLeave(object sender, EventArgs e)
        {
            string sMouseHoverText;
            ToolTip = new ToolTip();

            sMouseHoverText = ((Label)sender).Name;

            foreach (object Ctrl in lbl)
            {
                Label Ctr = (Label)Ctrl;

                if (Ctr.Name.Equals(sMouseHoverText))
                    ToolTip.Hide(Ctr);
            }
        }

        private void Line_Delete()
        {
            if (lLine.Count > 0)
            {
                foreach (object Ctrl in lLine)
                {
                    Label Ctr = (Label)Ctrl;
                    this.pan_posi.Controls.Remove(Ctr);
                }

                for (int i = lLine.Count - 1; i >= 0; i--)
                {
                    lLine.RemoveAt(i);
                }
            }
        }

        private void Line_Create()
        {
            Label PLine = new Label();

            lLine.Add(PLine);

            PLine.AutoSize = false;
            PLine.Size = new System.Drawing.Size(1, pan_posi.Height);  //(width, height)
            PLine.Location = new Point(iLine_s, 0);

            PLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PLine.BackColor = System.Drawing.Color.Red;
            PLine.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pan_posi.Controls.Add(PLine);
            PLine.BringToFront();
        }
        #endregion
    }
}
