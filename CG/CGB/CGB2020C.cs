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
///-- 系统名            中板轧钢作业管理系统                                              
///-- 子系统名          轧钢作业管理                                                 
///-- 程序名            加热炉出炉实绩管理                                
///-- 程序ID            CGB2020C    
///-- 版本              1.1                                                   
///-- 文档号                                                         
///-- 设计              韩超                                                    
///-- 代码              韩超                                                     
///-- 代码日期          2017.04.25                                                
///-- 处理描述          加热炉实绩管理                                                                          
///-------------------------------------------------------------------------------
///-- 更新历史  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++     
///-------------------------------------------------------------------------------
///-- 版本      日期              修改人         修改内容                             
///   1.1       2017.04.25        韩超                                                                                                                          
///-------------------------------------------------------------------------------
///-- 程序头注释结束++++++++++++++++++++++++++++++++++++++++++++++++++++++
///-------------------------------------------------------------------------------

namespace CG
{
    public partial class CGB2020C : CommonClass.FORMBASE
    {
        public CGB2020C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Mc2 = new Collection();
        Collection Mc3 = new Collection();
        Collection Sc1 = new Collection();
        Collection Sc2 = new Collection();
        Collection Sc3 = new Collection();
        Collection Sc4 = new Collection();
        Collection Sc5 = new Collection();

        //超交货期用红色显示

        const int SS1_STDSPEC = 8;
        const int SS1_UST_FL = 14;
        const int SS1_DEL_TO_DATE = 23;
        const int SS1_URGNT_FL = 24;
        const int SS1_OVER_FL = 1;
        //超量标记

        const int SS2_SLAB_NO = 0;
        const int SS2_STDSPEC = 9;
        const int SS2_UST_FL = 16;
        const int SS2_DEL_TO_DATE = 26;
        const int SS2_URGNT_FL = 27;
        const int SS2_FLAG_FL = 28;
        const int SS2_EXPORT_FL = 29;
        const int SS2_OVER_FL = 1;
        //超量标记
        const int SS2_DUILENG = 17;

        const int SS3_SLAB_NO = 0;
        const int SS3_STDSPEC = 9;
        const int SS3_UST_FL = 16;
        const int SS3_DEL_TO_DATE = 26;
        const int SS3_URGNT_FL = 27;
        const int SS3_FLAG_FL = 28;
        const int SS3_EXPORT_FL = 29;
        const int SS3_OVER_FL = 1;
        //超量标记
        const int SS3_DUILENG = 17;

        const int SS5_SLAB_NO = 0;
        const int SS5_STDSPEC = 9;
        const int SS5_UST_FL = 16;
        const int SS5_DEL_TO_DATE = 26;
        const int SS5_URGNT_FL = 27;
        const int SS5_FLAG_FL = 28;
        const int SS5_EXPORT_FL = 29;
        const int SS5_OVER_FL = 1;
        //超量标记
        const int SS5_DUILENG = 17;



        protected override void p_SubFormInit()
        {

            int imcseq;
            p_McIni(Mc1, true);
            imcseq = 1;
            p_SetMc("板坯号", txt_SlabNo, "PNIR", "", "", "", "", imcseq); //0
            p_SetMc("板坯规格", TXT_SLAB_SIZE, "RL", "", "", "", "", imcseq); //1
            p_SetMc("出炉取消", TXT_DIS_UNDIS_IND, "NI", "", "", "", "", imcseq); //2
            p_SetMc("出炉时间", TXT_DISCHARGE_TIME, "NIR", "", "", "", "", imcseq); //3
            p_SetMc("温度", SDB_EXP_TEMP, "IR", "", "", "", "", imcseq); //4
            p_SetMc("温度均匀性", SDB_PDT_UNI_TEMP, "IR", "", "", "", "", imcseq); //5
            p_SetMc("预热区TOP温度", SDB_PRE_TOP_SLAB_TEMP, "IR", "", "", "", "", imcseq); //6
            p_SetMc("预热区BOT温度", SDB_PRE_BOT_SLAB_TEMP, "IR", "", "", "", "", imcseq); //7
            p_SetMc("预热区驻留时间", SDB_PRE_ZONE_TIME, "IR", "", "", "", "", imcseq); //8
            p_SetMc("一号加热区TOP温度", SDB_HT_TOP_SLAB_TEMP, "IR", "", "", "", "", imcseq); //9
            p_SetMc("一号加热区BOT温度", SDB_HT_BOT_SLAB_TEMP, "IR", "", "", "", "", imcseq); //10
            p_SetMc("一号加热区驻留时间", SDB_HT_ZONE_TIME, "IR", "", "", "", "", imcseq); //11
            p_SetMc("二号加热区TOP温度", SDB_HT_TOP_SLAB_TEMP2, "IR", "", "", "", "", imcseq); //12
            p_SetMc("二号加热区BOT温度", SDB_HT_BOT_SLAB_TEMP2, "IR", "", "", "", "", imcseq); //13
            p_SetMc("二号加热区驻留时间", SDB_HT_ZONE_TIME2, "IR", "", "", "", "", imcseq); //14
            p_SetMc("均热区TOP温度", SDB_SOK_HOT_SLAB_TEMP, "IR", "", "", "", "", imcseq); //15
            p_SetMc("均热区BOT温度", SDB_SOK_BOT_SLAB_TEMP, "IR", "", "", "", "", imcseq); //16
            p_SetMc("均热区驻留时间", SDB_SOK_ZONE_TIME, "IR", "", "", "", "", imcseq); //17
            p_SetMc("班次", TXT_SHIFT, "I", "", "", "", "", imcseq); //18
            p_SetMc("班别", TXT_GROUP, "I", "", "", "", "", imcseq); //19
            p_SetMc("用户", TXT_EMP, "I", "", "", "", "", imcseq); //20



            p_McIni(Mc2, true);
            imcseq = 2;
            p_SetMc("板坯号", txt_SlabNo, "PNIR", "", "", "", "", imcseq);
            p_SetMc("缺号时间", TXT_REJ_OCCR_TIME, "NIR", "", "", "", "", imcseq);
            p_SetMc("缺号代码", TXT_REASON_CD, "NIR", "", "", "", "", imcseq);
            p_SetMc("缺号板坯确定", TXT_COMFRM, "NIR", "", "", "", "", imcseq);
            p_SetMc("缺号班次", TXT_REJ_SHIFT, "IR", "", "", "", "", imcseq);
            p_SetMc("缺号班别", TXT_REJ_GROUP, "IR", "", "", "", "", imcseq);
            p_SetMc("作业人员", TXT_REJ_EMP, "IR", "", "", "", "", imcseq);

            p_McIni(Mc3, false);
            imcseq = 3;
            p_SetMc("出炉状态开始时间", txt_RstFormDate, "PNI", "", "", "", "", imcseq);
            p_SetMc("出炉状态结束时间", txt_RstToDate, "PNI", "", "", "", "", imcseq);

            int iheadrow;
            int iscseq;
            p_ScIni(ss1, Sc1, 0, false, true);
            iheadrow = 0;
            iscseq = 1;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //8
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("装炉时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M"); //10
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //11
            p_SetSc("产品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("定尺类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("是否探伤", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //14
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "L"); //15
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //16
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("堆冷时间(h)", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //20
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("交货期开始", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("交货期结束", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //24

            p_ScIni(ss2, Sc2, 0, false, true);
            iheadrow = 0;
            iscseq = 2;

            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("装炉时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //12
            p_SetSc("产品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("T1厚度比", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //14
            p_SetSc("定尺类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("是否探伤", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("堆冷时间(h)", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //23
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("交货期开始", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("交货期结束", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //28
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //30
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //31
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //32
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //33

            p_ScIni(ss3, Sc3, 0, false, true);
            iheadrow = 0;
            iscseq = 3;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("装炉时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //12
            p_SetSc("产品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("T1厚度比", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //14
            p_SetSc("定尺类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("是否探伤", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("堆冷时间(h)", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //23
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("交货期开始", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("交货期结束", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //28
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //30
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //31
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //32
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //33

            p_ScIni(ss4, Sc4, 0, false, true);
            iheadrow = 0;
            iscseq = 4;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("加热炉号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("产品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //11
            p_SetSc("装炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "M"); //12
            p_SetSc("出炉时间", "DT", "", "L", "", "", "", iscseq, iheadrow, "R"); //13
            p_SetSc("在炉时间(m)", "E", "", "L", "", "", "", iscseq, iheadrow, "R"); //14
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //15
            p_SetSc("出炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //16
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //18
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("轧批号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //23
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //25

            p_ScIni(ss5, Sc5, 0, false, true);
            iheadrow = 0;
            iscseq = 5;
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //0
            p_SetSc("超量标记", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //1
            p_SetSc("坯料类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //2
            p_SetSc("锁定原因", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //3
            p_SetSc("轧批号", "E", "20", "L", "", "", "", iscseq, iheadrow, "M"); //4
            p_SetSc("布料方式", "E", "10", "L", "", "", "", iscseq, iheadrow, "M"); //5
            p_SetSc("原始坯料钢种", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //6
            p_SetSc("板坯钢种", "E", "25", "L", "", "", "", iscseq, iheadrow, "L"); //7
            p_SetSc("异钢种替代", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //8
            p_SetSc("标准号", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //9
            p_SetSc("板坯规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "L"); //10
            p_SetSc("装炉时间", "DT", "60", "L", "", "", "", iscseq, iheadrow, "M"); //11
            p_SetSc("装炉温度", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //12
            p_SetSc("产品规格", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //13
            p_SetSc("T1厚度比", "E", "60", "L", "", "", "", iscseq, iheadrow, "R"); //14
            p_SetSc("定尺类别", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //15
            p_SetSc("是否探伤", "E", "12", "L", "", "", "", iscseq, iheadrow, "L"); //16
            p_SetSc("堆冷标识", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //17
            p_SetSc("订单号", "E", "11", "L", "", "", "", iscseq, iheadrow, "L"); //18
            p_SetSc("序列号", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //19
            p_SetSc("班次", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //20
            p_SetSc("班别", "E", "2", "L", "", "", "", iscseq, iheadrow, "M"); //21
            p_SetSc("作业人员", "E", "8", "L", "", "", "", iscseq, iheadrow, "M"); //22
            p_SetSc("堆冷时间(h)", "E", "10", "L", "", "", "", iscseq, iheadrow, "R"); //23
            p_SetSc("铸机号", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //24
            p_SetSc("交货期开始", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //25
            p_SetSc("交货期结束", "E", "", "L", "", "", "", iscseq, iheadrow, "M"); //26
            p_SetSc("是否紧急订单", "E", "1", "L", "", "", "", iscseq, iheadrow, "M"); //27
            p_SetSc("是否定制配送", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //28
            p_SetSc("是否出口订单", "E", "60", "L", "", "", "", iscseq, iheadrow, "M"); //29
            p_SetSc("试样备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //30
            p_SetSc("尺寸备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //31
            p_SetSc("打包备注", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //32
            p_SetSc("表面客户要求", "E", "200", "L", "", "", "", iscseq, iheadrow, "M"); //33
        }

        private void CGB2020C_Load(object sender, EventArgs e)
        {
            base.sSvrPgmPkgName = "CGB2020NC";
            Form_Define();
            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_EMP.Text = GeneralCommon.sUserID;
            opt_EntCan0.Checked = true;
            opt_ORDER0.Checked = true;
            tab1.SelectedIndex = 0;

            unlockSpread(ss1);
            unlockSpread(ss2);
            unlockSpread(ss3);
            unlockSpread(ss4);
            unlockSpread(ss5);

            Form_Ref();

        }
        //opt_EntCan事件
        private void opt_EntCan_Clk()
        {
            if (opt_EntCan0.Checked)
            {
                TXT_DIS_UNDIS_IND.Text = "1";
                opt_EntCan0.ForeColor = Color.Red; //Red color
                opt_EntCan1.ForeColor = Color.Black; //Black color
            }
            else
            {
                TXT_DIS_UNDIS_IND.Text = "2";
                opt_EntCan1.ForeColor = Color.Red; //Red color
                opt_EntCan0.ForeColor = Color.Black; //Black color
            }
        }

        private void opt_EntCan0_TextChanged(object sender, EventArgs e)
        {
            opt_EntCan_Clk();
        }

        private void opt_ORDER_Clk()
        {
            if (opt_ORDER0.Checked)
            {
                TXT_COMFRM.Text = "1";
                opt_ORDER0.ForeColor = Color.Red; //Red color
                opt_ORDER1.ForeColor = Color.Black; //Black color
            }
            else
            {
                TXT_COMFRM.Text = "2";
                opt_ORDER1.ForeColor = Color.Red; //Red color
                opt_ORDER0.ForeColor = Color.Black; //Black color
            }
        }

        private void opt_ORDER0_CheckedChanged(object sender, EventArgs e)
        {
            opt_ORDER_Clk();
        }

        private void sChk1_Clk()
        {
            if (!sChk1.Checked)
            {
                if (!sChk2.Checked)
                {
                    sChk1.Checked = true;
                    sChk1.ForeColor = Color.Red;
                }
                //return; //20170426
            }

            txt_EntCan.Text = "1";

            sChk2.Checked = false;
            sChk2.ForeColor = Color.Black;
            sChk1.ForeColor = Color.Red;
            sf3.Enabled = false;
            sf2.Enabled = true;

            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_EMP.Text = GeneralCommon.sUserID;
            opt_EntCan0.Checked = true;
        }

        private void sChk1_CheckedChanged(object sender, EventArgs e)
        {
            sChk1_Clk();
        }

        private void sChk2_Clk()
        {
            if (!sChk2.Checked)
            {
                if (!sChk1.Checked)
                {
                    sChk2.Checked = true;
                    sChk2.ForeColor = Color.Red;
                }
            }
            txt_EntCan.Text = "2";

            sChk1.Checked = false;
            sChk1.ForeColor = Color.Black;
            sChk2.ForeColor = Color.Red;
            sf2.Enabled = false;
            sf3.Enabled = true;

            opt_ORDER0.Checked = true;
            TXT_REJ_SHIFT.Text = Gf_ShiftSet3("");
            TXT_REJ_GROUP.Text = Gf_GroupSet(TXT_REJ_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_REJ_EMP.Text = GeneralCommon.sUserID;
            TXT_REJ_OCCR_TIME_DblClk();
        }

        private void sChk2_CheckedChanged(object sender, EventArgs e)
        {
            sChk2_Clk();
        }

        private void ss1_Clk(int col, int row)
        {
            if (ss1.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss1.ActiveSheet.Cells[row, 0].Value.ToString();
                    TXT_SLAB_SIZE.Text = ss1.ActiveSheet.Cells[row, 9].Value.ToString();
                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
        }

        private void ss1_DblClk(int col, int row)
        {
            if (ss1.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss1.ActiveSheet.Cells[row, 0].Value.ToString();
                    TXT_SLAB_SIZE.Text = ss1.ActiveSheet.Cells[row, 9].Value.ToString();
                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
        }

        private void ss2_Clk(int col, int row)
        {
            if (ss2.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss2.ActiveSheet.Cells[row, 0].Value.ToString();
                    TXT_SLAB_SIZE.Text = ss2.ActiveSheet.Cells[row, 10].Value.ToString();
                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
        }

        private void ss2_DblClk(int col, int row)
        {
            if (ss2.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss2.ActiveSheet.Cells[row, 0].Value.ToString();
                    //9
                    TXT_SLAB_SIZE.Text = ss2.ActiveSheet.Cells[row, 10].Value.ToString();

                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
            long iRow;
            if (ss2.ActiveSheet.RowCount > 0)
            {
                //显示CGB2021C
                CGB2021C CGB2021C = new CGB2021C();
                CGB2021C.MdiParent = GeneralCommon.MDIMain;
                CGB2021C.Show();
                CGB2021C.txt_SLAB_NO.Text = ss2.ActiveSheet.Cells[row, 0].Value.ToString();
                CGB2021C.Form_Ref();
            }
        }

        private void ss3_Clk(int col, int row)
        {
            if (ss3.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss3.ActiveSheet.Cells[row, 0].Value.ToString();
                    TXT_SLAB_SIZE.Text = ss3.ActiveSheet.Cells[row, 10].Value.ToString();
                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
        }

        private void ss3_DblClk(int col, int row)
        {
            if (ss3.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss3.ActiveSheet.Cells[row, 0].Value.ToString();
                    //9
                    TXT_SLAB_SIZE.Text = ss3.ActiveSheet.Cells[row, 10].Value.ToString();

                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
            long iRow;
            if (ss3.ActiveSheet.RowCount > 0)
            {
                //显示CGB2021C
                CGB2021C CGB2021C = new CGB2021C();
                CGB2021C.MdiParent = GeneralCommon.MDIMain;
                CGB2021C.Show();
                CGB2021C.txt_SLAB_NO.Text = ss3.ActiveSheet.Cells[row, 0].Value.ToString();
                CGB2021C.Form_Ref();
            }
        }

        private void ss5_Clk(int col, int row)
        {
            if (ss5.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss5.ActiveSheet.Cells[row, 0].Value.ToString();
                    TXT_SLAB_SIZE.Text = ss5.ActiveSheet.Cells[row, 10].Value.ToString();
                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
        }

        private void ss5_DblClk(int col, int row)
        {
            if (ss5.ActiveSheet.RowCount > 0)
            {
                if (sChk1.Checked & opt_EntCan0.Checked)
                {
                    txt_SlabNo.Text = ss5.ActiveSheet.Cells[row, 0].Value.ToString();
                    //9
                    TXT_SLAB_SIZE.Text = ss5.ActiveSheet.Cells[row, 10].Value.ToString();

                    //TXT_DISCHARGE_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                    //TXT_REJ_OCCR_TIME.RawData = Gf_DTSet(M_CN1, , "X")
                }
                else if (sChk2.Checked) { }
            }
            long iRow;
            if (ss5.ActiveSheet.RowCount > 0)
            {
                //显示CGB2021C
                CGB2021C CGB2021C = new CGB2021C();
                CGB2021C.MdiParent = GeneralCommon.MDIMain;
                CGB2021C.Show();
                CGB2021C.txt_SLAB_NO.Text = ss5.ActiveSheet.Cells[row, 0].Value.ToString();
                CGB2021C.Form_Ref();
                CGB2021C.WindowState = FormWindowState.Minimized;
            }
        }

        private void ss4_Clk(int col, int row)
        {
            if (ss4.ActiveSheet.RowCount > 0)
            {
                if (sChk2.Checked | opt_EntCan1.Checked)
                {
                    txt_SlabNo.Text = ss4.ActiveSheet.Cells[row, 0].Value.ToString();
                    if (sChk2.Checked)
                    {
                        if (!p_Ref(2, 0, true, false))
                        {
                            TXT_REJ_OCCR_TIME.Text = Gf_DTSet("", "X");
                            TXT_REASON_CD.Text = "";
                        }
                    }
                    else
                    {
                        p_Ref(1, 0, true, false);
                    }
                }
            }
        }

        private void ss4_DblClk(int col, int row)
        {
            if (ss4.ActiveSheet.RowCount > 0)
            {
                if (sChk2.Checked | opt_EntCan1.Checked)
                {
                    txt_SlabNo.Text = ss4.ActiveSheet.Cells[row, 0].Value.ToString();
                    if (sChk2.Checked)
                    {
                        if (!p_Ref(2, 0, true, false))
                        {
                            TXT_REJ_OCCR_TIME.Text = Gf_DTSet("", "X");
                            TXT_REASON_CD.Text = "";
                        }
                    }
                    else
                    {
                        p_Ref(1, 0, true, false);
                    }
                }
            }
        }

        private void ss1_CellClick(object sender, CellClickEventArgs e)
        {
            ss1_Clk(e.Column,e.Row);
        }

        private void ss1_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss1_DblClk(e.Column, e.Row);
        }

        private void ss2_CellClick(object sender, CellClickEventArgs e)
        {
            ss2_Clk(e.Column, e.Row);
        }

        private void ss2_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss2_DblClk(e.Column, e.Row);
        }

        private void ss3_CellClick(object sender, CellClickEventArgs e)
        {
            ss3_Clk(e.Column, e.Row);
        }

        private void ss3_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss3_DblClk(e.Column, e.Row);
        }

        private void ss5_CellClick(object sender, CellClickEventArgs e)
        {
            ss5_Clk(e.Column, e.Row);
        }

        private void ss5_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss5_DblClk(e.Column, e.Row);
        }

        private void ss4_CellClick(object sender, CellClickEventArgs e)
        {
            ss4_Clk(e.Column, e.Row);
        }

        private void ss4_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            ss4_DblClk(e.Column, e.Row);
        }

        private void tab1_Clk()
        {
            if (tab1.SelectedIndex == 4)
            {
                TXT_SHIFT.Text = Gf_ShiftSet3("");
                if (TXT_SHIFT.Text == "1")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "000001";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "075959";
                }
                else if (TXT_SHIFT.Text == "2")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "080000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "155959";
                }
                else if (TXT_SHIFT.Text == "3")
                {
                    txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "160000";
                    txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 8) + "235959";
                }
            }
            Form_Ref();
        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab1_Clk();
        }

        //EXCEL导出表单
        public override void Spread_Exc()
        {
            if (0 == tab1.SelectedIndex)
            {
                if (ss1_Sheet1.RowCount <= 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_Excel(ss1);
            }
            if (1 == tab1.SelectedIndex)
            {
                if (ss2_Sheet1.RowCount <= 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_Excel(ss2);
            }
            if (2 == tab1.SelectedIndex)
            {
                if (ss3_Sheet1.RowCount <= 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_Excel(ss3);
            }
            if (3 == tab1.SelectedIndex)
            {
                if (ss5_Sheet1.RowCount <= 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_Excel(ss5);
            }
            if (4 == tab1.SelectedIndex)
            {
                if (ss4_Sheet1.RowCount <= 0)
                {
                    return;
                }
                SpreadCommon.Gp_Sp_Excel(ss4);
            }
        }


        public override bool Form_Cls()
        {
            base.Form_Cls();

            opt_EntCan0.Checked = false;
            opt_EntCan0.ForeColor = Color.Black;
            opt_EntCan1.Checked = false;
            opt_EntCan1.ForeColor = Color.Black;
            TXT_DIS_UNDIS_IND.Text = "";
            opt_ORDER0.Checked = false;
            opt_ORDER0.ForeColor = Color.Black;
            opt_ORDER1.Checked = false;
            opt_ORDER1.ForeColor = Color.Black;

            return true;
        }


        public override void Form_Ref()
        {
            int iRow;
            int iCol;
            string sCurDate;
            string sDel_To_Date;
            string sUrgnt_Fl;
            string sUst_Fl;
            string sFlag;
            string sexport;
            string sOver_Fl;

            string sFlag1;
            string sExport1;

            string sFlag2;
            string sExport2;

            sCurDate = DateTime.Now.ToString("yyyyMM");

            if (tab1.SelectedIndex == 0)
            {
                p_Ref(0, 1, true, false);
                ss1_Clk(0, 0);
                //        End If
                //超交货期用红色显示 add by liqian 2012-06-11
                {
                    for (iRow = 1; iRow <= ss1.ActiveSheet.RowCount; iRow++)
                    {
                        sDel_To_Date = ss1.ActiveSheet.Cells[iRow - 1, SS1_DEL_TO_DATE].Value.ToString().Substring(0, 6);
                        sUrgnt_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_URGNT_FL].Value.ToString();
                        if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate))
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        //紧急订单绿色显示 add by liqian 2012-08-15
                        if (sUrgnt_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                        }
                        //是否探伤 add by liqian 2013-04-08
                        sUst_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_UST_FL].Value.ToString();
                        if (sUst_Fl == "是")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_UST_FL, SS1_UST_FL, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                            SpreadCommon.Gp_Sp_BlockColor(ss1, SS1_STDSPEC, SS1_STDSPEC, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                        }
                        //是否超量 add by Lee 2015-03-30
                        sOver_Fl = ss1.ActiveSheet.Cells[iRow - 1, SS1_OVER_FL].Value.ToString();
                        if (sOver_Fl == "*")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss1, 0, ss1.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, SSP2.BackColor, Color.White);
                        }
                    }
                }
            }
            else if (tab1.SelectedIndex == 1)
            {
                p_Ref(0, 2, true, false);
                if (ss2.ActiveSheet.RowCount <= 0) return;
                //        If ss2.Text <> "" Then
                ss2_Clk(0, 0);
                //        End If
                //超交货期用红色显示 add by liqian 2012-06-11
                {
                    for (iRow = 1; iRow <= ss2.ActiveSheet.RowCount; iRow++)
                    {
                        sDel_To_Date = ss2.ActiveSheet.Cells[iRow - 1, SS2_DEL_TO_DATE].Value.ToString().Substring(0, 6);
                        sUrgnt_Fl = ss2.ActiveSheet.Cells[iRow - 1, SS2_URGNT_FL].Value.ToString();

                        if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate))
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        //紧急订单绿色显示 add by liqian 2012-08-15
                        if (sUrgnt_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                        }
                        //是否探伤 add by liqian 2013-04-08
                        sUst_Fl = ss2.ActiveSheet.Cells[iRow - 1, SS2_UST_FL].Value.ToString();
                        if (sUst_Fl == "是")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_UST_FL, SS2_UST_FL, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_STDSPEC, SS2_STDSPEC, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                        }
                        //是否定制配送
                        sFlag = ss2.ActiveSheet.Cells[iRow - 1, SS2_FLAG_FL].Value.ToString();
                        if (sFlag == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        //是否出口订单
                        sexport = ss2.ActiveSheet.Cells[iRow - 1, SS2_EXPORT_FL].Value.ToString();
                        if (sexport == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, SS2_SLAB_NO, SS2_SLAB_NO, iRow - 1, iRow - 1, SSP1.BackColor, Color.White);
                        }
                        //是否超量 add by Lee 2015-03-30
                        sOver_Fl = ss2.ActiveSheet.Cells[iRow - 1, SS2_DUILENG].Value.ToString();
                        if (sOver_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss2, 0, ss2.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP2.BackColor);
                        }
                    }
                }
            }
            else if (tab1.SelectedIndex == 2)
            {
                p_Ref(0, 3, true, false);
                if (ss3.ActiveSheet.RowCount <= 0) return;

                //        If ss3.Text <> "" Then
                ss3_Clk(1, 1);
                //        End If
                //超交货期用红色显示 add by liqian 2012-06-11
                {
                    for (iRow = 1; iRow <= ss3.ActiveSheet.RowCount; iRow++)
                    {
                        sDel_To_Date = ss3.ActiveSheet.Cells[iRow - 1, SS3_DEL_TO_DATE].Value.ToString().Substring(0, 6);
                        sUrgnt_Fl = ss3.ActiveSheet.Cells[iRow - 1, SS3_URGNT_FL].Value.ToString();

                        if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate))
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, 0, ss3.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        //紧急订单绿色显示 add by liqian 2012-08-15
                        if (sUrgnt_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, 0, ss3.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                        }
                        //是否探伤 add by liqian 2013-04-08
                        sUst_Fl = ss3.ActiveSheet.Cells[iRow - 1, SS3_UST_FL].Value.ToString();
                        if (sUst_Fl == "是")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, SS3_UST_FL, SS3_UST_FL, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                            SpreadCommon.Gp_Sp_BlockColor(ss3, SS3_STDSPEC, SS3_STDSPEC, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                        }
                        //是否定制配送
                        sFlag = ss3.ActiveSheet.Cells[iRow - 1, SS3_FLAG_FL].Value.ToString();
                        if (sFlag == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, SS3_SLAB_NO, SS3_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        //是否出口订单
                        sexport = ss3.ActiveSheet.Cells[iRow - 1, SS3_EXPORT_FL].Value.ToString();
                        if (sexport == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, SS3_SLAB_NO, SS3_SLAB_NO, iRow - 1, iRow - 1, SSP1.BackColor, Color.White);
                        }
                        //是否超量 add by Lee 2015-03-30
                        sOver_Fl = ss3.ActiveSheet.Cells[iRow - 1, SS3_DUILENG].Value.ToString();
                        if (sOver_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss3, 0, ss3.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP2.BackColor);
                        }
                    }
                }
            }
            else if (tab1.SelectedIndex == 3)
            {
                p_Ref(0, 5, true, false);
                if (ss5.ActiveSheet.RowCount <= 0) return;
                //        If ss5.Text <> "" Then
                ss5_Clk(1, 1);
                //        End If
                //超交货期用红色显示 add by liqian 2012-06-11
                {
                    for (iRow = 1; iRow <= ss5.ActiveSheet.RowCount; iRow++)
                    {
                        sDel_To_Date = ss5.ActiveSheet.Cells[iRow - 1, SS5_DEL_TO_DATE].Value.ToString().Substring(0, 6);
                        sUrgnt_Fl = ss5.ActiveSheet.Cells[iRow - 1, SS5_URGNT_FL].Value.ToString();

                        if (Convert.ToDouble(sDel_To_Date) < Convert.ToDouble(sCurDate))
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, 0, ss5.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Red, Color.White);
                        }
                        //紧急订单绿色显示 add by liqian 2012-08-15
                        if (sUrgnt_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, 0, ss5.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Green, Color.White);
                        }
                        //是否探伤 add by liqian 2013-04-08
                        sUst_Fl = ss5.ActiveSheet.Cells[iRow - 1, SS5_UST_FL].Value.ToString();
                        if (sUst_Fl == "是")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, SS5_UST_FL, SS5_UST_FL, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                            SpreadCommon.Gp_Sp_BlockColor(ss5, SS5_STDSPEC, SS5_STDSPEC, iRow - 1, iRow - 1, Color.Fuchsia, Color.White);
                        }
                        //是否定制配送
                        sFlag = ss5.ActiveSheet.Cells[iRow - 1, SS5_FLAG_FL].Value.ToString();
                        if (sFlag == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, SS5_SLAB_NO, SS5_SLAB_NO, iRow - 1, iRow - 1, SSP4.BackColor, Color.White);
                        }
                        //是否出口订单
                        sexport = ss5.ActiveSheet.Cells[iRow - 1, SS5_EXPORT_FL].Value.ToString();
                        if (sexport == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, SS5_SLAB_NO, SS5_SLAB_NO, iRow - 1, iRow - 1, SSP1.BackColor, Color.White);
                        }
                        //是否超量 add by Lee 2015-03-30
                        sOver_Fl = ss5.ActiveSheet.Cells[iRow - 1, SS5_DUILENG].Value.ToString();
                        if (sOver_Fl == "Y")
                        {
                            SpreadCommon.Gp_Sp_BlockColor(ss5, 0, ss5.ActiveSheet.ColumnCount - 1, iRow - 1, iRow - 1, Color.Black, SSP2.BackColor);
                        }
                    }
                }
            }
            else if (tab1.SelectedIndex == 4)
            {
                p_Ref(3, 4, true, false);
            }
        }


        public override void Form_Pro()
        {

            string SMESG;
            if (sChk2.Checked)
            {
                if (!Gp_DateCheck(TXT_REJ_OCCR_TIME.Text, ""))
                {
                    SMESG = " 请正确输入缺号时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
                if (TXT_REASON_NAME.Text == "")
                {
                    SMESG = " 请正确选择缺号代码 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }
            else if (sChk1.Checked)
            {
                if (!Gp_DateCheck(TXT_DISCHARGE_TIME.Text, ""))
                {
                    SMESG = " 请正确输入出炉时间 ！";
                    GeneralCommon.Gp_MsgBoxDisplay(SMESG, "I", "");
                    return;
                }
            }

            if (txt_EntCan.Text == "1")
            {
                if (!p_Pro(1, 0, true, true))
                    return;
            }
            else if (txt_EntCan.Text == "2")
            {
                if (!p_Pro(2, 0, true, true)) return;
            }

            if (tab1.SelectedIndex == 0)
            {
                p_Ref(0, 1, true, false);
                ss1_Clk(0, 0);
            }
            else if (tab1.SelectedIndex == 1)
            {
                p_Ref(0, 2, true, false);
                ss2_Clk(0, 0);
            }
            else if (tab1.SelectedIndex == 2)
            {
                p_Ref(0, 3, true, false);
                ss2_Clk(0, 0);
            }
            else if (tab1.SelectedIndex == 3)
            {
                p_Ref(0, 5, true, false);
                ss5_Clk(0, 0);
            }
            else if (tab1.SelectedIndex == 4)
            {
                p_Ref(3, 4, true, false);
            }

            TXT_DISCHARGE_TIME.Text = "";
            TXT_REJ_OCCR_TIME.Text = "";
            ///ADDED BY GUOLI AT 20080326 避免保存后班次 班别 作业人员被清空''''
            TXT_SHIFT.Text = Gf_ShiftSet3("");
            TXT_GROUP.Text = Gf_GroupSet(TXT_SHIFT.Text.Trim(), Gf_DTSet("", "X"));
            TXT_EMP.Text = GeneralCommon.sUserID;
            ///'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        }

        private void TXT_REJ_OCCR_TIME_DblClk()
        {
            TXT_REJ_OCCR_TIME.Text = Gf_DTSet("", "X");
        }

        private void TXT_REJ_OCCR_TIME_DoubleClick(object sender, EventArgs e)
        {
            TXT_REJ_OCCR_TIME_DblClk();
        }

        private void txt_RstFormDate_DblClk()
        {
            txt_RstFormDate.Text = Gf_DTSet("", "X").Substring(0, 12);
            txt_RstToDate.Text = Gf_DTSet("", "X").Substring(0, 12);
        }

        private void txt_RstFormDate_DoubleClick(object sender, EventArgs e)
        {
            txt_RstFormDate_DblClk();
        }

        #region 公共方法

        public bool Gp_DateCheck(string DateCheck, string sDTChk)
        {
            sDTChk = "M";
            string iDateCheck;
            string iDateMatch;
            string iDate;
            System.DateTime iCheck;

            if (sDTChk == "M")
            {
                iDateCheck = DateCheck;
            }
            else
            {
                iDateCheck = DateCheck.Replace("-", "");
                iDateCheck = iDateCheck.Replace(" ", "");
                iDateCheck = iDateCheck.Replace(":", "");
            }

            if (Convert.ToInt32(iDateCheck.Substring(0, 4)) > 2020 | Convert.ToInt32(iDateCheck.Substring(0, 4)) < 2000)
            {
                return false;
            }

            switch (iDateCheck.Length)
            {
                case 8:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 10));
                    break;
                case 12:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 16));
                    break;
                case 14:
                    iDate = iDateCheck.Substring(0, 4) + "-" + iDateCheck.Substring(4, 2) + "-" + iDateCheck.Substring(6, 2) + " " + iDateCheck.Substring(8, 2) + ":" + iDateCheck.Substring(10, 2) + ":" + iDateCheck.Substring(12, 2);
                    iCheck = Convert.ToDateTime(iDate.Substring(1, 19));
                    break;
                default:
                    return false;
                    break;
            }

            iDateMatch = iCheck.ToString("yyyyMM");

            if (iDateMatch != iDateCheck.Substring(0, 8))
            {
                return false;
            }
            return true;
        }

        public string Gf_ShiftSet3(string WKDATE)
        {


            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";
            string Shift_HH = "0";
            string sQuery;
            sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MI') FROM DUAL";
            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                if (WKDATE != "")
                {
                    return WKDATE;
                }
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            Shift_HH = "";
                        }
                        else
                        {
                            Shift_HH = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                GeneralCommon.M_CN1.Close();
                AdoRs = null;

                if (Convert.ToInt32(Shift_HH) < 800)
                {
                    return "1";
                }
                else if (Convert.ToInt32(Shift_HH) < 1600)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "0";
            }
        }

        public string Gf_GroupSet(string shift, string setDate)
        {

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "";

            string sQuery;
            string group = "0";
            sQuery = "SELECT Gf_Groupset('C3'," + shift + ",SUBSTR('" + setDate + "',1,8)) FROM DUAL";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            group = "";
                        }
                        else
                        {
                            group = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return group;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "";
            }
        }

        //日期格式
        public string Gf_DTSet(string DTCheck, string DTFlag)
        {
            DTCheck = "S";
            DTFlag = "C";

            string sQuery = "";
            int sQuery_Len = 0;
            string time = "";

            switch (DTCheck)
            {
                case "S":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MISS') FROM DUAL";
                    sQuery_Len = 14;
                    break;
                case "I":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24MI') FROM DUAL";
                    sQuery_Len = 12;
                    break;
                case "H":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDDHH24') FROM DUAL";
                    sQuery_Len = 10;
                    break;
                case "D":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMMDD') FROM DUAL";
                    sQuery_Len = 8;
                    break;
                case "T":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'HH24MISS') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "M":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYYMM') FROM DUAL";
                    sQuery_Len = 6;
                    break;
                case "Y":
                    sQuery = "SELECT TO_CHAR(SYSDATE,'YYYY') FROM DUAL";
                    sQuery_Len = 4;
                    break;
            }

            if (DTFlag == "C")
            {
                if (DTCheck == "T")
                {
                    return DateTime.Now.ToString("HHmmss");
                }
                return (DateTime.Now.ToString("yyyyMMddHHmmss")).Substring(0, sQuery_Len);
            }

            if (GeneralCommon.M_CN1.State == 0)
                if (!GeneralCommon.GF_DbConnect()) return "00000000000000";

            ADODB.Recordset AdoRs = new ADODB.Recordset();
            try
            {
                AdoRs.Open(sQuery, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    //RltValue = true;
                    while (!AdoRs.EOF)
                    {
                        if (AdoRs.Fields[0].Value.ToString() == "")
                        {
                            time = "";
                        }
                        else
                        {
                            time = AdoRs.Fields[0].Value.ToString();
                        }
                        AdoRs.MoveNext();
                    }
                }
                else
                {
                    time = "00000000000000";

                }

                GeneralCommon.M_CN1.Close();

                AdoRs = null;

                return time;
            }
            catch (Exception ex)
            {
                if (GeneralCommon.M_CN1.State != 0) GeneralCommon.M_CN1.Close();
                AdoRs = null;
                return "00000000000000";
            }
        }

        //unlock spread L column
        public void unlockSpread(FpSpread e)
        {
            int columnCount = e.Sheets[0].ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                e.ActiveSheet.Columns[i].Locked = false;
            }
        }

        #endregion

    }
}
