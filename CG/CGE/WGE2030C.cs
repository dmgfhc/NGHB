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
namespace CG
{
    public partial class WGE2030C : CommonClass.FORMBASE
    {
        public WGE2030C()
        {
            InitializeComponent();
        }
        Collection Mc1 = new Collection();
        #region 界面初始化
        protected override void p_SubFormInit()
        {
            p_McIni(Mc1, false);
            p_SetMc(CBO_CUR_INV, "P", "B0025", "", "", 1, "");
            p_SetMc(CBO_YARD_TYPE, "P", "", "", "", 1, "");
            p_SetMc(CBO_ZONE_TYPE, "P", "", "", "", 1, "");
           
         
        }
        public void Form_Load(object sender, System.EventArgs e)
        {

            //base.sSvrPgmPkgName = "pkg_ghf1c";
            Form_Define();
        }
        #endregion
        public override void Form_Ref()
        {
           string sQuery,SMESG,sCur_Inv,sArea,sAddr,sYard_Column,sPlate_No ;
   
            sCur_Inv = CBO_CUR_INV.Text;
            sPlate_No = "00000000000000";
            
            sAddr = "P" + CBO_YARD_TYPE.Text + CBO_ZONE_TYPE.Text;
            
           
            sQuery = "         SELECT MAX(YARD_ROW) FROM FP_STDYARD ";
            sQuery = sQuery + " WHERE LOCATION LIKE  '" + sAddr + "%' AND YARD_KND = '" + sCur_Inv + "' ";
            ss1.Sheets[0].RowCount = Int32.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery)) * 2;


           
            sQuery = "         SELECT MAX(YARD_COLUMN) FROM FP_STDYARD ";
            sQuery = sQuery + " WHERE LOCATION LIKE  '" + sAddr + "%' AND YARD_KND = '" + sCur_Inv + "' ";
            ss1.Sheets[0].ColumnCount = Int32.Parse(GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, sQuery));

          
            sQuery = "         SELECT LOCATION FROM FP_STDYARD ";
            sQuery = sQuery + " WHERE LOCATION LIKE  '" + sAddr + "%' AND YARD_KND = '" + sCur_Inv + "' ";
            sQuery = sQuery + " ORDER BY LOCATION ";

            //If Addr_Display(M_CN1, Proc_Sc("Sc"), sQuery, False) = False Then
            //    Exit Sub
            //End If

            sQuery = "         SELECT A.YARD_ADDR, '('||A.CNT||','||A.BED_SEQ||')', (SELECT LEN || ' X ' || WID FROM GP_PLATE WHERE PLATE_NO = B.PLATE_NO ) PLATE_SIZE  ";
            sQuery = sQuery + "  FROM GP_PLATEYARD B, ";
            sQuery = sQuery + "        (SELECT MAX(Y.YARD_KND) YARD_KND,YARD_ADDR YARD_ADDR,COUNT(*) CNT,MAX(BED_SEQ) BED_SEQ ";
            sQuery = sQuery + "           FROM GP_PLATEYARD Y  ";
            sQuery = sQuery + "          WHERE Y.YARD_KND  = '" + sCur_Inv + "' ";
            sQuery = sQuery + "            AND Y.YARD_ADDR  LIKE '" + sAddr + "%' ";
            sQuery = sQuery + "            AND Y.PLATE_NO IS NOT NULL ";
            sQuery = sQuery + "       GROUP BY Y.YARD_ADDR) A ";
            sQuery = sQuery + " WHERE B.YARD_KND = '" + sCur_Inv + "' ";
            sQuery = sQuery + " AND B.YARD_ADDR  LIKE '" + sAddr + "%' ";
            sQuery = sQuery + " AND B.YARD_ADDR = A.YARD_ADDR  ";
            sQuery = sQuery + " AND B.BED_SEQ   = A.BED_SEQ  ";
            sQuery = sQuery + " AND B.YARD_KND  = A.YARD_KND ";
            sQuery = sQuery + " ORDER BY A.YARD_ADDR";

            //If(Only_Display(GeneralCommon.M_CN1, Proc_Sc("Sc"), sQuery, False));
            //{
            //    sdb_plate_cnt.Text = GeneralCommon.Gf_CodeFind(GeneralCommon.M_CN1, 
            //                         "SELECT COUNT(*) FROM GP_PLATEYARD WHERE YARD_KND = '" + sCur_Inv + "' " + "AND YARD_ADDR LIKE '" 
            //                          + sAddr + "%' AND PLATE_NO IS NOT NULL ");}
            //GeneralCommon.Gp_FormMenuSetting(this, FormType, "RE", sAuthority);
            


        }

        private void WGE2030C_Load(object sender, EventArgs e)
        {

        }

    }
}
