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

//-------------------------------------------------------------------------------
//-- PROGRAM HEADER  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- System Name       宽厚板轧钢作业
//-- Sub_System Name   统计分析管理
//-- Program Name      DQ/ACC实绩查询界面
//-- Program ID        WGT1040C
//-- Document No       Q-00-0010(Specification)
//-- Designer          李 超
//-- Coder             李 超
//-- Date              2012.11.21
//-- Description
//-------------------------------------------------------------------------------
//-- UPDATE HISTORY  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------
//-- VER        DATE         EDITOR        DESCRIPTION
//-- 1.00    2012.11.21       李超        DQ/ACC实绩查询
//-------------------------------------------------------------------------------
//-- DECLARATION     ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-------------------------------------------------------------------------------

namespace CG
{
    public partial class WGT1040C : CommonClass.FORMBASE
    {
        public WGT1040C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        Collection Sc1 = new Collection();

        #region 界面初始化

        protected override void p_SubFormInit()
        {

            int iheadrow;
            int imcseq;
            int iscseq;
            p_McIni(Mc1, false);
            imcseq = 1;
            p_SetMc(TXT_SLAB_NO, "P", "", "", "", imcseq, "");
            p_SetMc("生产时间",SDT_DATE_FROM, "P", "", "", "","",imcseq);
            p_SetMc("生产时间",SDT_DATE_TO, "P", "", "", "","",imcseq);
            p_SetMc(CBO_SHIFT, "P", "", "", "", imcseq, "");
            p_SetMc(CBO_GROUP, "P", "", "", "", imcseq, "");
            


            p_ScIni(ss1, Sc1, 0, true, true);
            iheadrow = 0;
            iscseq = 1;

            //0-21
            p_SetSc("板坯号", "E", "10", "L", "", "", "", iscseq, iheadrow);				//1                          
            p_SetSc("数据来源", "E", "5", "L", "", "", "", iscseq, iheadrow, "M");		    //2                          
            p_SetSc("板坯钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");        //3                          
            p_SetSc("标准号", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");
            p_SetSc("轧制钢种", "E", "30", "L", "", "", "", iscseq, iheadrow, "L");        //4                          
            p_SetSc("轧件长度", "N", "9", "L", "", "", "", iscseq, iheadrow);			  //5                          
            p_SetSc("轧件宽度", "N", "8", "L", "", "", "", iscseq, iheadrow);				      //6                          
            p_SetSc("轧件厚度", "N", "6,2", "L", "", "", "", iscseq, iheadrow);				    //7                          
            p_SetSc("是否投用", "N", "1", "L", "", "", "", iscseq, iheadrow);				      //8                          
            p_SetSc("开冷时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);			      //9                          
            p_SetSc("终冷时间", "DT", "14", "L", "", "", "", iscseq, iheadrow);		        //10                         
            p_SetSc("水温实际值", "N", "7", "L", "", "", "", iscseq, iheadrow);		        //11                         
            p_SetSc("水压实际值", "N", "5,3", "L", "", "", "", iscseq, iheadrow);		      //12                         
            p_SetSc("头部遮蔽系数", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	      //13                         
            p_SetSc("尾部遮蔽系数", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	      //14                         
            p_SetSc("头部遮蔽长度", "N", "4,2", "L", "", "", "", iscseq, iheadrow);	      //15                         
            p_SetSc("尾部遮蔽长度", "N", "4,2", "L", "", "", "", iscseq, iheadrow);			  //16
            p_SetSc("终轧温度计算值", "N", "4", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("终轧温度测量值", "N", "4", "L", "", "", "", iscseq, iheadrow); 
            p_SetSc("入口钢板上表面温度", "N", "4", "L", "", "", "", iscseq, iheadrow);	  //17                         
            p_SetSc("入口钢板下表面温度", "N", "4", "L", "", "", "", iscseq, iheadrow);	  //18                         
            p_SetSc("出口钢板上表面温度", "N", "4", "L", "", "", "", iscseq, iheadrow);	  //19                         
            p_SetSc("出口钢板下表面温度", "N", "4", "L", "", "", "", iscseq, iheadrow);	  //20                         
            p_SetSc("目标返红温度", "N", "4", "L", "", "", "", iscseq, iheadrow, "R"); 	  //21                         
            p_SetSc("返红钢板表面平均温度", "N", "4", "L", "", "", "", iscseq, iheadrow);	//22                         
            p_SetSc("实际冷却速度", "N", "5,2", "L", "", "", "", iscseq, iheadrow);					//23                         
            p_SetSc("侧喷开闭状态", "E", "20", "L", "", "", "", iscseq, iheadrow);					//24                         
            p_SetSc("钢板运行速度", "N", "3,2", "L", "", "", "", iscseq, iheadrow);				  //25                         
            p_SetSc("钢板运行加速度", "N", "5,4", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("缺陷", "E", "50", "L", "", "", "", iscseq, iheadrow);
            p_SetSc("一阶段终冷温度", "N", "7", "L", "", "", "", iscseq, iheadrow);				//26                         
            p_SetSc("一阶段冷却速率", "N", "7", "L", "", "", "", iscseq, iheadrow);				//27                         
            p_SetSc("二阶段冷却速率", "N", "7", "L", "", "", "", iscseq, iheadrow);				//28                         
            p_SetSc("终轧弛豫时间", "N", "4", "L", "", "", "", iscseq, iheadrow);				  //29                         
            p_SetSc("操作模式", "N", "1", "L", "", "", "", iscseq, iheadrow);				      //30                         
            p_SetSc("通过模式", "N", "1", "L", "", "", "", iscseq, iheadrow);				      //31                         
            p_SetSc("冷却方法", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");		      //32                         
            p_SetSc("冷却模式", "E", "1", "L", "", "", "", iscseq, iheadrow, "M");		      //33                         
            p_SetSc("DQ上水量1", "N", "6,2", "L", "", "", "", iscseq, iheadrow);		    		//34              DQ上水量1  
            p_SetSc("DQ上水量2", "N", "6,2", "L", "", "", "", iscseq, iheadrow);		      	//35              DQ上水量2  
            p_SetSc("DQ上水量3", "N", "6,2", "L", "", "", "", iscseq, iheadrow);		      	//36              DQ上水量3  
            p_SetSc("DQ上水量4", "N", "6,2", "L", "", "", "", iscseq, iheadrow);		        //37              DQ上水量4  
            p_SetSc("DQ水量比1", "N", "3,2", "L", "", "", "", iscseq, iheadrow);		        //38              DQ水量比1  
            p_SetSc("DQ水量比2", "N", "3,2", "L", "", "", "", iscseq, iheadrow);		        //39              DQ水量比2  
            p_SetSc("DQ水量比3", "N", "3,2", "L", "", "", "", iscseq, iheadrow);		        //40              DQ水量比3  
            p_SetSc("DQ水量比4", "N", "3,2", "L", "", "", "", iscseq, iheadrow);		        //41              DQ水量比4  
            p_SetSc("ACC上水量1", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //42              ACC上水量1 
            p_SetSc("ACC上水量2", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //43              ACC上水量2 
            p_SetSc("ACC上水量3", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //44              ACC上水量3 
            p_SetSc("ACC上水量4", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //45              ACC上水量4 
            p_SetSc("ACC上水量5", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //46              ACC上水量5 
            p_SetSc("ACC上水量6", "N", "5,2", "L", "", "", "", iscseq, iheadrow);			 //47              ACC上水量6 
            p_SetSc("ACC上水量7", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //48              ACC上水量7 
            p_SetSc("ACC上水量8", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //49              ACC上水量8 
            p_SetSc("ACC上水量9", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //50              ACC上水量9 
            p_SetSc("ACC上水量10", "N", "5,2", "L", "", "", "", iscseq, iheadrow);         //51              ACC上水量10
            p_SetSc("ACC水量比1", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //52              ACC水量比1 
            p_SetSc("ACC水量比2", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //53              ACC水量比2 
            p_SetSc("ACC水量比3", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //54              ACC水量比3 
            p_SetSc("ACC水量比4", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //55              ACC水量比4 
            p_SetSc("ACC水量比5", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //56              ACC水量比5 
            p_SetSc("ACC水量比6", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //57              ACC水量比6 
            p_SetSc("ACC水量比7", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //58              ACC水量比7 
            p_SetSc("ACC水量比8", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //59              ACC水量比8 
            p_SetSc("ACC水量比9", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //60              ACC水量比9 
            p_SetSc("ACC水量比10", "N", "5,2", "L", "", "", "", iscseq, iheadrow);	        //61              ACC水量比10

        }

        public void Form_Load(object sender, System.EventArgs e)
        {
            //base.sSvrPgmPkgName = "WGC2012C";
            Form_Define();
        }
        #endregion

    }
}
