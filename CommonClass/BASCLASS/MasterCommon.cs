using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CommonClass
{
    public class MasterCommon
    {

        public bool iMcRecord;//前台Mc是否记录操作 20130228
       /// <summary>
       /// 根据传入的squery，执行squery中对应的后台程序，执行成功返回true，否则返回false。
       /// </summary>
       /// <param name="Conn"></param>
       /// <param name="sQuery"></param>
       /// <returns></returns>
        public bool Gf_Ms_ExecQuery(ADODB.Connection Conn, string sQuery,Collection Mc)
        {
            bool returnValue = false; ;

            int ret_Result_ErrCode;
            string ret_Result_ErrMsg;
            ADODB.Command adoCmd;
            
            object[,] vParam = new object[3, 5];

            //Return Error Code Parameter
            vParam[1, 1] = "arg_e_code";
            vParam[1, 2] = ADODB.DataTypeEnum.adInteger;//规定 Field, Parameter 或 Property 对象的数据类型：
            //一个四字节的有符号整数 (DBTYPE_I4)。
            vParam[1, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            vParam[1, 4] = 1;

            //Return Error Messsage Parameter
            vParam[2, 1] = "arg_e_msg";
            vParam[2, 2] = ADODB.DataTypeEnum.adVarChar;
            
            vParam[2, 3] = ADODB.ParameterDirectionEnum.adParamOutput;
            vParam[2, 4] = 256;

            //////20130228
             string sQuery1 = "";
            string typeOper = "";
            ////// //////20130228

            try
            {
                //Db Connection Check
                if (Conn.State == 0)
                {
                    if (GeneralCommon.GF_DbConnect() == false)
                    {
                        return false;
                    }                   
                }

                //Ado Setting
               
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseServer;

                adoCmd = new ADODB.Command();

                adoCmd.CommandType = ADODB.CommandTypeEnum.adCmdText;
                
                adoCmd.ActiveConnection = Conn;
                adoCmd.CommandText = sQuery;// paras_all[0] + "}";
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_code", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamOutput, 1, null));
                adoCmd.Parameters.Append(adoCmd.CreateParameter("arg_e_msg", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamOutput, 256, null));
                Conn.BeginTrans();

                ///////////////////////////////20130228
                sQuery1 = sQuery.Replace("'", "");
                int typeNum = sQuery1.IndexOf(",");
                typeOper = sQuery1.Substring(typeNum - 1, 1);

                ///////////////////////////////20130228

                object result1 = null;
                object result2 = null;

                adoCmd.Execute(out result1);

                //Process Error Check
                if (adoCmd.Parameters["arg_e_code"].Value.ToString() != "0")
                {
                    Conn.RollbackTrans();
                    ret_Result_ErrCode = System.Convert.ToInt32(adoCmd.Parameters["arg_e_code"].Value);
                    ret_Result_ErrMsg = (string)(adoCmd.Parameters["arg_e_msg"].Value);

                    ////////////////////20130228
                    if (iMcRecord)
                    {
                        Gf_Mc_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Mc["P-M"]), typeOper, sQuery1, "1", "", ret_Result_ErrMsg);
                    }
                    ////////////////////20130228

                    GeneralCommon.sErrMessg = (string)("Error Code : " + ret_Result_ErrCode + "\r\n" + "Error Mesg : " + ret_Result_ErrMsg);

                    adoCmd = null;
                    returnValue = false;
                    return returnValue;

                }
                /////////////////20130228
                else
                {
                    if (iMcRecord)
                    {
                        Gf_Mc_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Mc["P-M"]), typeOper, sQuery1, "0", "", "");
                    }
                }
                ///////////////////20130228
                Conn.CommitTrans();
                adoCmd = null;
                returnValue = true;
            }
            catch (Exception ex)
            {
                Conn.RollbackTrans();
                ///////////20130228
                if (iMcRecord)
                {
                    Gf_Mc_InsertRecord(GeneralCommon.getIPAddress(), GeneralCommon.sUserID, (string)(Mc["P-M"]), typeOper, sQuery1, "1", "", ex.Message);
                }
                ///////////20130228
                adoCmd = null;
                returnValue = false;
               // GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_ExecQuery Error : " + sQuery + " " + ex.Message), "", "");
                GeneralCommon.sErrMessg = ("Gf_Ms_ExecQuery Error : " + ex.Message);//解决报错两次问题1114
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 向表中插入操作记录。20130228
        /// </summary>
        /// <param name="IP_ADDRESS"></param>
        /// <param name="USERID"></param>
        /// <param name="PGMID"></param>
        /// <param name="OP_TYPE"></param>
        /// <param name="OP_CONTENT"></param>
        /// <param name="OP_RLT"></param>
        /// <param name="INS_TIME"></param>
        /// <param name="ERR_DESC"></param>
        public void Gf_Mc_InsertRecord(string IP_ADDRESS, string USERID, string PGMID, string OP_TYPE, string OP_CONTENT, string OP_RLT, string INS_TIME, string ERR_DESC)
        {
            try
            {
                string SQL = "insert into ZP_LOG (IP_ADDRESS,USERID,PGMID,OP_TYPE,OP_CONTENT,OP_RLT,ERR_DESC) values (" + "\'" + IP_ADDRESS + "\'," + "\'" + USERID + "\'," + "\'" + PGMID + "\'," + "\'" + OP_TYPE + "\'," + "\'" + OP_CONTENT + "\'," + "\'" + OP_RLT + "\'," + "\'" + ERR_DESC + "\'" + ")";
                ADODB.Recordset AdoRs = new ADODB.Recordset();
                if (GeneralCommon.M_CN1.State == 0)
                    if (GeneralCommon.GF_DbConnect() == false) return;
                AdoRs.Open(SQL, GeneralCommon.M_CN1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                // GeneralCommon.Gf_ExecSql(GeneralCommon.M_CN1, SQL);
            }
            catch
            {

            }
        }

        /// <summary>
        /// 函数生成字符串sQuery，sQuery用于Gf_Ms_ExecQuery，Gf_Ms_Display函数，实现增删改查。
        /// </summary>
        /// <param name="ProcedureName"></param>
        /// <param name="iType"></param>
        /// <param name="Retcol"></param>
        /// <returns></returns>
        public string Gf_Ms_MakeQuery(string ProcedureName, string iType, Collection Retcol)
        {
            string returnValue;

            long iTemp_Int;
            double dTemp_Flo;
            string sQuery = "";
            string sTemp;
            object Ctrl;

            try
            {
                //Refer Or OneRow is No iType
                if (iType == "R" || iType == "O")
                {
                    sQuery = "{call " + ProcedureName + " ( ";
                }
                else
                {
                    sQuery = "{call " + ProcedureName + " ( \'" + iType + "\',";
                }

                if (Retcol != null)
                {

                    foreach (object tempLoopVar_Ctrl in Retcol)
                    {
                        Ctrl = tempLoopVar_Ctrl;
                        if (Ctrl is CheckBox)
                        {

                            if (((CheckBox)Ctrl).Checked == true)
                            {
                                sQuery += "\'1\',";
                            }
                            else
                            {
                                sQuery += "\'0\',";
                            }

                        }

                       
                        else if (Ctrl is MaskedDate)
                        {
                            MaskedDate dtp = (MaskedDate)Ctrl;
                            string cur_dateStr = dtp.Text;
                            cur_dateStr = cur_dateStr.Replace('-', ' ');
                            cur_dateStr = cur_dateStr.Replace(':', ' ');
                            cur_dateStr = cur_dateStr.Trim();
                            cur_dateStr = cur_dateStr.Replace(" ","");
                            if ((dtp.Text != ""))
                            {
                                sQuery += "\'" + cur_dateStr + "\',";
                            }
                            else
                            {
                                sQuery += "\'\',";
                            }
                        }
                      
                        else if (Ctrl is RadioButton)
                        {

                            if (((RadioButton)Ctrl).Checked == true)
                            {
                                sQuery += "\'1\',";
                            }
                            else
                            {
                                sQuery += "\'0\',";
                            }

                        }
                      
                        else if (Ctrl is ComboBox)
                        {
                            try
                            {
                                sQuery += "\'" + (((ComboBox)Ctrl).SelectedValue.ToString().Trim()) + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + Strings.Trim((string)((ComboBox)Ctrl).Text) + "\',";
                            }
                        }
                        else if (Ctrl is DateTimePicker)
                        {
                            DateTimePicker dtp = (DateTimePicker)Ctrl;
                            if ((dtp.ShowCheckBox == true && dtp.Checked == true) || dtp.ShowCheckBox == false)
                            {
                                string fmt = dtp.CustomFormat;
                                if (fmt.Length == 19)
                                {
                                    //yyyy-MM-dd HH:mm:ss
                                    sQuery += "\'" + ((DateTimePicker)Ctrl).Text.Trim().Substring(0, 4) + ((DateTimePicker)Ctrl).Text.Trim().Substring(5, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(8, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(11, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(14, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(17, 2) + "\',";
                                }
                                else if (fmt.Length == 10)
                                {
                                    //yyyy-MM-dd
                                    sQuery += "\'" + ((DateTimePicker)Ctrl).Text.Trim().Substring(0, 4) + ((DateTimePicker)Ctrl).Text.Trim().Substring(5, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(8, 2) + "\',";
                                }
                                else if (fmt.Length == 8)
                                {
                                    //HH:mm:ss
                                    sQuery += "\'" +((DateTimePicker)Ctrl).Text.Trim().Substring(0, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(3, 2) + ((DateTimePicker)Ctrl).Text.Trim().Substring(6, 2) + "\',";

                                }
                                else
                                {
                                    sQuery += "\'\',";
                                }
                            }
                            else
                            {
                                sQuery += "\'\',";
                            }
                        }
                        else if (Ctrl is  F4COMR)
                        {
                            try
                            {
                                sQuery += "\'" + ((F4COMR)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else if (Ctrl is  F4COMN)
                        {
                            try
                            {
                                sQuery += "\'" + ((F4COMN)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else if (Ctrl is F4ETCR)
                        {
                            try
                            {
                                sQuery += "\'" + ((F4ETCR)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else if (Ctrl is F4ETCN)
                        {
                            try
                            {
                                sQuery += "\'" + ((F4ETCN)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else if (Ctrl is NumericUpDown)
                        {
                            try
                            {
                                sQuery += "\'" +((NumericUpDown)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else if (Ctrl is NumBox)
                        {
                            try
                            {
                                sQuery += "\'" + ((NumBox)Ctrl).NumValue.ToString().Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }      

                        
                        else if (Ctrl is CeriUDate)
                        {
                            try
                            {
                                sQuery += "\'" + ((CeriUDate)Ctrl).RawDate.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }


                        else if (Ctrl is MixComboBox)
                        {
                            try
                            {
                                sQuery += "\'" + ((MixComboBox)Ctrl).MixComboBoxValue.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }


                        else if (Ctrl is Label)
                        {
                            try
                            {
                                sQuery += "\'" + ((Label)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }

                        else if (Ctrl is Control)
                        {
                            try
                            {
                                sQuery += "\'" + ((Control)Ctrl).Text.Trim() + "\',";
                            }
                            catch (Exception)
                            {
                                sQuery += "\'" + "" + "\',";
                            }
                        }
                        else
                        {
                            sTemp = ((TextBox)Ctrl).Text;
                            if (sTemp == "")
                                sQuery += "\'" + "" + "\',";
                            else
                            {
                                sTemp = Strings.Replace(sTemp, "\'", "\'\'", 1, -1, 0);
                                sQuery += "\'" + sTemp.Trim() + "\',";
                            }
                        }

                    }
                }

                //Refer Or OneRow is Last String Delete (Not Use Return Parameter)
                if (iType == "R" || iType == "O")
                {
                    sQuery = (string)(sQuery.Substring(0, sQuery.Length - 1) + ")}");
                }
                else
                {
                    sQuery += "?,?)}";
                }

                returnValue = sQuery;
                Debug.WriteLine(sQuery);

            }
            catch (Exception ex)
            {
                returnValue = "FAIL";
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_MakeQuery Error : " + sQuery + " " + ex.Message), "", "");
            }

            return returnValue;
        }

      
        /// <summary>
        /// 将lControl集合中的控件的Enabled按Tf的值反向激活。
        /// </summary>
        /// <param name="lControl"></param>
        /// <param name="Tf"></param>
        public void Gp_Ms_ControlLock(Collection lControl, bool Tf)
        {

            int iCount;

            for (iCount = 1; iCount <= lControl.Count; iCount++)
            {
                ((Control)lControl[iCount]).Enabled = !Tf;
            }

        }

        /// <summary>
        /// 将nControl集合中的BackColor置成Color.FromArgb(255, 255, 255, 192)。
        /// </summary>
        /// <param name="nControl"></param>
        public void Gp_Ms_NeceColor(Collection nControl)
        {

            int iCount;

            for (iCount = 1; iCount <= nControl.Count; iCount++)
            {

                if ((Control)nControl[iCount] is DateTimePicker)
                    ((DateTimePicker)nControl[iCount]).CalendarMonthBackground = Color.FromArgb(255, 255, 255, 192);
                else if ((Control)nControl[iCount] is MixComboBox)
                {
                    ((MixComboBox)nControl[iCount]).textBox1.BackColor = Color.FromArgb(255, 255, 255, 192);
                    ((MixComboBox)nControl[iCount]).comboBox1.BackColor = Color.FromArgb(255, 255, 255, 192);
                }
                else if ((Control)nControl[iCount] is F4COMR)//1112
                {
                    ((F4COMR)nControl[iCount]).CD.BackColor = Color.FromArgb(255, 255, 255, 192);
                    ((F4COMR)nControl[iCount]).CD_NAME.BackColor = Color.FromArgb(255, 255, 255, 192);
                }
                else
                    ((Control)nControl[iCount]).BackColor = Color.FromArgb(255, 255, 255, 192);
            }

        }

       
        /// <summary>
        /// 根据控件oBjectName的pctl等的值分别将oBjectName加入到pControl等集合中
        /// </summary>
        /// <param name="oBjectName"></param>
        /// <param name="pctl"></param>
        /// <param name="nctl"></param>
        /// <param name="mctl"></param>
        /// <param name="ictl"></param>
        /// <param name="rctl"></param>
        /// <param name="actl"></param>
        /// <param name="lctl"></param>
        /// <param name="pControl"></param>
        /// <param name="nControl"></param>
        /// <param name="mControl"></param>
        /// <param name="iControl"></param>
        /// <param name="rControl"></param>
        /// <param name="aControl"></param>
        /// <param name="lControl"></param>
        public void Gp_Ms_Collection(object oBjectName, string pctl, string nctl, string mctl, string ictl, string rctl, string actl, string lctl, Collection pControl, Collection nControl, Collection mControl, Collection iControl, Collection rControl, Collection aControl, Collection lControl)
        {

            if (pctl.Trim().ToLower() == "p") //Primary Key Control
            {
                pControl.Add(oBjectName, null, null, null);
            }

            if (nctl.Trim().ToLower() == "n") //Necessary Control
            {
                nControl.Add(oBjectName, null, null, null);
            }

            if (mctl.Trim().ToLower() == "m") //Maxlength check Control
            {
                mControl.Add(oBjectName, null, null, null);
            }

            if (ictl.Trim().ToLower() == "i") //Insert Control
            {
                iControl.Add(oBjectName, null, null, null);
            }

            if (rctl.Trim().ToLower() == "r") //Refer Control
            {
                rControl.Add(oBjectName, null, null, null);
            }

            if (actl.Trim().ToLower() == "a") //Master -> Spread Control
            {
                aControl.Add(oBjectName, null, null, null);
            }

            if (lctl.Trim().ToLower() == "l") //Lock Control
            {
                lControl.Add(oBjectName, null, null, null);
            }

        }


       
        /// <summary>
        /// 根据控件oBjectName的pctl等的值分别将oBjectName加入到pControl等集合中。
        /// </summary>
        /// <param name="oBjectName"></param>
        /// <param name="pctl"></param>
        /// <param name="nctl"></param>
        /// <param name="mctl"></param>
        /// <param name="ictl"></param>
        /// <param name="rctl"></param>
        /// <param name="actl"></param>
        /// <param name="lctl"></param>
        /// <param name="pControl"></param>
        /// <param name="nControl"></param>
        /// <param name="mControl"></param>
        /// <param name="iControl"></param>
        /// <param name="rControl"></param>
        /// <param name="aControl"></param>
        /// <param name="lControl"></param>
        /// <param name="npControl"></param>
        public void Gp_Ms_Collection(object oBjectName, string pctl, string nctl, string mctl, string ictl, 
            string rctl, string actl, string lctl, Collection pControl, Collection nControl, Collection mControl,
            Collection iControl, Collection rControl, Collection aControl, Collection lControl, Collection npControl)
        {

            if (pctl.Trim().ToLower() == "p") //Primary Key Control
            {
                pControl.Add(oBjectName, null, null, null);
            }

            if (nctl.Trim().ToLower() == "n") //Necessary Control
            {
                nControl.Add(oBjectName, null, null, null);
            }

            if (nctl.Trim().ToLower() == "n" && pctl.Trim().ToLower() == "p") //Necessary Control&&Primary Key Control
            {
                npControl.Add(oBjectName, null, null, null);
            }
            if (mctl.Trim().ToLower() == "m") //Maxlength check Control
            {
                mControl.Add(oBjectName, null, null, null);
            }

            if (ictl.Trim().ToLower() == "i") //Insert Control
            {
                iControl.Add(oBjectName, null, null, null);
            }

            if (rctl.Trim().ToLower() == "r") //Refer Control
            {
                rControl.Add(oBjectName, null, null, null);
            }

            if (actl.Trim().ToLower() == "a") //Master -> Spread Control
            {
                aControl.Add(oBjectName, null, null, null);
            }

            if (lctl.Trim().ToLower() == "l") //Lock Control
            {
                lControl.Add(oBjectName, null, null, null);
            }

        }


        /// <summary>
        /// 将MC集合中控件的值清空。清空时，根据不同的控件属性进行。
        /// </summary>
        /// <param name="Mc"></param>
        public void Gp_Ms_Cls(Collection Mc)
        {

            object Ct;

            foreach (object tempLoopVar_Ct in Mc)
            {
                Ct = tempLoopVar_Ct;

                if (Ct is CheckBox) //CHECK BOX
                {   
                    ((CheckBox)Ct).Checked = false;

                }
              
                else if (Ct is CeriUDate) //AxCSTextLib.AxsitxEdit
                {
                    
                    ((CeriUDate)Ct).RawDate = "";
                }
             

                
                else if (Ct is MaskedDate) //AxCSTextLib.AxsitxEdit
                {
                   
                    ((MaskedDate)Ct).Text = "";
                }
              

                else if (Ct is RadioButton) //OPTION
                {
                    ((RadioButton)Ct).Checked = false;
                }
                else if (Ct is DateTimePicker)
                {
                    ((DateTimePicker)Ct).ResetText();
                   
                }
                else if (Ct is ComboBox) //COMBO BOX
                {
                   
                    if (((ComboBox)Ct).DropDownStyle == ComboBoxStyle.DropDownList)
                    {
                        ((ComboBox)Ct).SelectedIndex = 0;
                    }
                    else
                    {
                        //((ComboBox)Ct).SelectedValue = "";
                        ((ComboBox)Ct).SelectedIndex = -1;//1211清空   combox清空
                    }

                  
                }
                else if (Ct is F4COMR)
                {
                    ((F4COMR)Ct).Text = "";
                    ((F4COMR)Ct).CD_NAME.Text = "";
                }
                ////////////////////////20130516BEGIN
                else if (Ct is F4ETCR)
                {
                    try
                    {
                        F4ETCR f4 = (F4ETCR)Ct;
                        f4.Text = "";
                        List<BControlFiledSetting> bControlFiledSetting = (List<BControlFiledSetting>)f4.CustomSetting;
                        bControlFiledSetting[1].TargetControl.Text = "";
                    }catch(Exception EX){}
                }
                //////////////////////20130516END
                else if (Ct is TextBox) //TEXT
                {
                    ((TextBox)Ct).Text = "";
                }
                else if (Ct is MixComboBox) //MixComboBox
                {
                    ((MixComboBox)Ct).textBox1.Text = "";
                    ((MixComboBox)Ct).comboBox1.Items.Clear();
                }
                else if (Ct is NumBox) //NumBox
                {
                    ((NumBox)Ct).NumValue = 0;
                }
                else if (Ct is NumericUpDown)
                {
                    //20090818,张哲修改
                    //NumbericUpDown的Tag值是M的时候,值清空后为最大值
                    //Modified by ZZ@20090820
                    //Ct.Value = 0
                    if (((NumericUpDown)Ct).Tag != null)
                    {
                        if (((NumericUpDown)Ct).Tag.ToString().ToUpper() == "M")
                        {
                            ((NumericUpDown)Ct).Value = ((NumericUpDown)Ct).Maximum;
                        }
                        else
                        {
                            ((NumericUpDown)Ct).Value = 0;
                        }
                    }
                }
                
                else if (Ct is Label) //NumBox
                {
                    ((Label)Ct).Text = "";
                }
                  
                else
                {
                    ((NumericUpDown)Ct).Text = "";
                }

            }

        }

       
        /// <summary>
        /// 将MC["rControl"]的值赋值于Mc["cControl"]，实现复制功能。
        /// </summary>
        /// <param name="Mc"></param>
        /// <returns></returns>
        public bool Gf_Ms_Copy(Collection Mc)
        {
            bool returnValue;

            int iCount;

            //cControl Clear
            for (iCount = 1; iCount <= ((Collection)Mc["cControl"]).Count; iCount++)
            {
                ((Collection)Mc["cControl"]).Remove(1);
            }

            try
            {
                //rControl Collection Value --> cControl Collection Copy
                for (iCount = 1; iCount <= ((Collection)Mc["rControl"]).Count; iCount++)
                {

                    if (((Collection)Mc["rControl"])[iCount] is CheckBox)
                    {
                        ((Collection)Mc["cControl"]).Add(((CheckBox)((Collection)Mc["rControl"])[iCount]).Checked);

                    }
                    else if (((Collection)Mc["rControl"])[iCount] is RadioButton)
                    {
                        ((Collection)Mc["cControl"]).Add(((RadioButton)((Collection)Mc["rControl"])[iCount]).Checked);

                    }
                    else if (((Collection)Mc["rControl"])[iCount] is ComboBox)
                    {
                        if (((ComboBox)((Collection)Mc["rControl"])[iCount]).DropDownStyle == ComboBoxStyle.DropDownList)
                        {
                            ((Collection)Mc["cControl"]).Add(((ComboBox)((Collection)Mc["rControl"])[iCount]).SelectedIndex);
                        }
                        else
                        {
                            ((Collection)Mc["cControl"]).Add(((ComboBox)((Collection)Mc["rControl"])[iCount]).Text);
                        }

                    }
                    else
                    {
                        ((Collection)Mc["cControl"]).Add(((TextBox)((Collection)Mc["rControl"])[iCount]).Text);
                    }

                }

                returnValue = true;

            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_Copy Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

       
        /// <summary>
        /// 判断当前的Mc是否能够进行粘贴动作。
        /// </summary>
        /// <param name="Mc"></param>
        /// <param name="Sc"></param>
        /// <returns></returns>
        public bool Gf_Ms_FormPaste(Collection Mc, Collection Sc)
        {
            bool returnValue = false;

            SpreadCommon SpreadCommon = new SpreadCommon();

            int iCount;

            try
            {

                //pControl(1) is Enabled=Ture Exit Function (Refer Not Status)
                if (((Control)((Collection)Mc["pControl"])[1]).Enabled == true)//
                {
                    return false ;
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_FormPaste Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

       
        /// <summary>
        /// 判断当前的Mc是否能够进行粘贴动作。
        /// </summary>
        /// <param name="Mc"></param>
        /// <param name="Sc"></param>
        /// <returns></returns>
        public bool Gf_Ms_Paste(ADODB.Connection Conn, Collection Mc, Collection Sc)
        {
            bool returnValue = false;

            int iCount;

            try
            {

                //pControl(1) is Enabled=Ture Exit Function
                if (((Control)((Collection)Mc["pControl"])[1]).Enabled == true)
                {
                    return false;
                }             
            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_Paste Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

       
        /// <summary>
        /// 检查Retcol集合中是否有控件的值为空
        /// </summary>
        /// <param name="Retcol"></param>
        /// <returns></returns>
        public string Gf_Ms_NeceCheck(Collection Retcol)
        {
            string returnValue;

            int II;
            int i;

            for (II = 1; II <= Retcol.Count; II++)
            {
                if (Retcol[II] is CheckBox) //CHECK BOX
                {
                    if (((CheckBox)Retcol[II]).Checked == false)
                    {
                        returnValue = ((CheckBox)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }

                }
                else if (Retcol[II] is RadioButton) //OPTION
                {
                    if (((RadioButton)Retcol[II]).Checked == false)
                    {
                        returnValue = ((RadioButton)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                else if (Retcol[II] is ComboBox) //COMBO BOX
                {
                    if (((ComboBox)Retcol[II]).DropDownStyle == ComboBoxStyle.Simple)
                    {
                        if (((ComboBox)Retcol[II]).SelectedIndex == 0 || ((ComboBox)Retcol[II]).SelectedIndex == -1)
                        {
                            returnValue = ((ComboBox)Retcol[II]).Tag.ToString();
                            return returnValue;
                        }
                    }
                    else
                    {
                        if (((ComboBox)Retcol[II]).Text == "")
                        {
                            returnValue = ((ComboBox)Retcol[II]).Tag.ToString();
                            return returnValue;
                        }
                    }
                }

                else if (Retcol[II] is DateTimePicker) 
                {
                    if(((DateTimePicker)Retcol[II]).Text == "")
                    {
                        returnValue = ((DateTimePicker)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }

                   
                else if (Retcol[II] is CeriUDate)
                {
                    if (((CeriUDate)Retcol[II]).RawDate == "")
                    {
                        returnValue = ((CeriUDate)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }

                ///20121121
                else if (Retcol[II] is F4COMR)
                {
                    if (((F4COMR)Retcol[II]).CD.Text == "")
                    {
                        returnValue = ((F4COMR)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                else if (Retcol[II] is F4COMN)
                {
                    if (((F4COMN)Retcol[II]).Text == "")
                    {
                        returnValue = ((F4COMN)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                else if (Retcol[II] is F4ETCN)
                {
                    if (((F4ETCN)Retcol[II]).Text == "")
                    {
                        returnValue = ((F4ETCN)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                else if (Retcol[II] is F4ETCR)
                {
                    if (((F4ETCR)Retcol[II]).Text == "")
                    {
                        returnValue = ((F4ETCR)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                ///20121121
                
            
                else if (Retcol[II] is MaskedDate)
                {
                    MaskedDate cur_MaskedDate = (MaskedDate)Retcol[II];
                    string cur_dateStr = cur_MaskedDate.Text;
                    cur_dateStr = cur_dateStr.Replace("-", "");
                    cur_dateStr = cur_dateStr.Replace(":", "");
                    cur_dateStr = cur_dateStr.Trim();
                    if (cur_dateStr == "")
                    {
                        returnValue = cur_MaskedDate.Tag.ToString();
                        return returnValue;
                    }
                }
               
                else if (Retcol[II] is MixComboBox)
                {
                    if (((MixComboBox)Retcol[II]).MixComboBoxValue == "")
                    {
                        returnValue = ((MixComboBox)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }
                else
                {
                    if (((TextBox)Retcol[II]).Text == "")
                    {
                        returnValue = ((TextBox)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }
                }

            }

            returnValue = "OK";

            return returnValue;
        }

       
        /// <summary>
        /// 检查Retcol集合中设置MaxLength属性的值是否有足够的长度。
        /// </summary>
        /// <param name="Retcol"></param>
        /// <returns></returns>
        public string Gf_Ms_NeceCheck2(Collection Retcol)
        {
            string returnValue = "";

            int II;
            int i;

            for (II = 1; II <= Retcol.Count; II++)
            {

                if (Retcol[II] is CheckBox) //CHECK BOX
                {
                    if (((CheckBox)Retcol[II]).Checked == false)
                    {
                        returnValue = ((CheckBox)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }

                }
                else if (Retcol[II] is RadioButton) //OPTION
                {
                    if (((RadioButton)Retcol[II]).Checked == false)
                    {
                        returnValue = ((RadioButton)Retcol[II]).Tag.ToString();
                        return returnValue;
                    }

                }
                else if (Retcol[II] is ComboBox) //COMBO BOX
                {
                    if (((ComboBox)Retcol[II]).DropDownStyle == ComboBoxStyle.Simple)
                    {
                        if (((ComboBox)Retcol[II]).SelectedIndex == 0)
                        {
                            returnValue = ((ComboBox)Retcol[II]).Tag.ToString();
                            return returnValue;
                        }
                    }
                    else
                    {
                        if (((ComboBox)Retcol[II]).Text == "")
                        {
                            returnValue = ((ComboBox)Retcol[II]).Tag.ToString();
                            return returnValue;
                        }
                    }



                }
                else
                {
                    if (Strings.Trim((string)(((TextBox)Retcol[II]).Text)).Length != ((TextBox)Retcol[II]).MaxLength)
                    {
                        returnValue = ((TextBox)Retcol[II]).Tag.ToString() + " = " + ((TextBox)Retcol[II]).MaxLength.ToString().Trim() + " ";
                        return returnValue;
                    }
                }
            }

            returnValue = "OK";

            return returnValue;
        }

        
        /// <summary>
        /// 根据传入的MC进行查询
        /// 1必输项的检查
        /// 2个别控件的长度检查
        /// 3生成查询语句
        /// 4调用Gf_Ms_Display ，显示处理
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Mc"></param>
        /// <param name="npCheckControl"></param>
        /// <param name="mCheckControl"></param>
        /// <param name="MsgChk"></param>
        /// <returns></returns>
        public bool Gf_Ms_Refer(ADODB.Connection Conn, Collection Mc, Collection npCheckControl, Collection mCheckControl, bool MsgChk)
        {
            bool returnValue;

            string sQuery;
            string sMsg;

            try
            {

                if (Mc != null)
                {
                    if (npCheckControl != null)
                    {
                        sMsg = Gf_Ms_NeceCheck(npCheckControl);
                        if (sMsg != "OK")
                        {
                            sMsg = "必须输入 " + sMsg + " ...!!!";
                            GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "");
                            returnValue = false;
                            return returnValue;
                        }
                    }

                    if (mCheckControl != null)
                    {
                        sMsg = Gf_Ms_NeceCheck2(mCheckControl);
                        if (sMsg != "OK")
                        {
                            sMsg = "输入的项目必须符合 " + sMsg + " 的长度...!!!";
                            GeneralCommon.Gp_MsgBoxDisplay(sMsg, "I", "");
                            returnValue = false;
                            return returnValue;
                        }
                    }

                }

                //Make Query
                sQuery = Gf_Ms_MakeQuery((string)(Mc["P-R"]), "R", (Collection)Mc["pControl"]);

                if (sQuery == "FAIL")
                {
                    returnValue = false;
                    return returnValue;
                }

                //Query Excete and Display
                if (Gf_Ms_Display(Conn, sQuery, (Collection)Mc["rControl"], (Collection)Mc["lControl"])== "OK")
                {
                    //GeneralCommon.MDIMain.StatusBar1.Panels(0).Text = " 提示信息 : Data inquiry completed";
                    GeneralCommon.GStatusBar.Panels[0].Text = " Message : Data inquiry completed";
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                    if (MsgChk)
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("无法找到该资料...!!!", "I", "");
                    }
                }

            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Failed on data inquiry : " + ex.Message), "", "");
            }

            return returnValue;
        }

     
        /// <summary>
        /// 根据传入的sql语句，进行查询，将查询结果写入Retcol每个控件中。
        /// 写入时根据Retcol中各控件的属性进行赋值。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="sQuery"></param>
        /// <param name="Retcol"></param>
        /// <param name="Lockcon"></param>
        /// <returns></returns>
        public string Gf_Ms_Display(ADODB.Connection Conn, string sQuery, Collection Retcol, Collection Lockcon)
        {
            string returnValue="";

            int iCount;
            //Dim Atext As Object
            ADODB.Recordset AdoRs;

            AdoRs = new ADODB.Recordset();

            if (Conn.State == 0)
            {
                if (GeneralCommon.GF_DbConnect() == false)
                {
                    return "FAIL";
                }
              
            }

            try
            {
                AdoRs.Open(sQuery, Conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (!AdoRs.BOF && !AdoRs.EOF)
                {
                    while (!AdoRs.EOF)
                    {
                        for (iCount = 1; iCount <= Retcol.Count; iCount++)
                        {

                            if (Retcol[iCount] is CheckBox) //CHECK BOX
                            {
                                //((CheckBox)Retcol[iCount]).Checked = (Information.VarType(AdoRs.Fields[iCount - 1].Value) == Constants.vbNull) ? "0" : (AdoRs.Fields[iCount - 1].Value);
                                CheckBox ct = (CheckBox)Retcol[iCount];
                                if (AdoRs.Fields[iCount] == null)
                                    ct.Checked = false;
                                else
                                    ct.Checked = Convert.ToBoolean(AdoRs.Fields[iCount].Value);
                            }
                            else if (Retcol[iCount] is RadioButton) //OPTION
                            {
                               
                                RadioButton ct = (RadioButton)Retcol[iCount];
                                if (AdoRs.Fields[iCount] == null)
                                    ct.Checked = false;
                                else
                                    ct.Checked = Convert.ToBoolean(AdoRs.Fields[iCount].Value);
                            }
                            else if (Retcol[iCount] is ComboBox) //COMBO BOX
                            {
                                if (((ComboBox)Retcol[iCount]).DropDownStyle == ComboBoxStyle.DropDownList)
                                {
                                    if (Information.VarType(AdoRs.Fields[iCount - 1].Value) == Constants.vbNull)
                                    {                                     
                                        ((ComboBox)Retcol[iCount]).Text = " ";
                                    }
                                    else
                                    {
                                       
                                        ((ComboBox)Retcol[iCount]).SelectedValue = AdoRs.Fields[iCount - 1].Value;
                                    }
                                }
                                else
                                {
                                    if (Information.VarType(AdoRs.Fields[iCount - 1].Value) == Constants.vbNull)
                                    {
                                        ((Control)Retcol[iCount]).Text = "";
                                    }
                                    else
                                    {
                                        ((Control)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString();
                                    }
                                }
                            }
                            else if (Retcol[iCount] is DateTimePicker)
                            {
                                if (Information.VarType(AdoRs.Fields[iCount - 1].Value) == Constants.vbNull)
                                {
                                    ((DateTimePicker)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    string ss;
                                    ss = (string)(AdoRs.Fields[iCount - 1].Value);
                                    DateTimePicker dtp = (DateTimePicker)Retcol[iCount];
                                    string fmt = dtp.CustomFormat;
                                    if (fmt.Length == 19)
                                    {
                                        //yyyy-MM-dd HH:mm:ss
                                        dtp.Text = (string)(ss.Substring(0, 4) + "-" + ss.Substring(4, 2) + "-" + ss.Substring(6, 2) + " " + ss.Substring(8, 2) + ":" + ss.Substring(10, 2) + ":" + ss.Substring(12, 2));
                                    }
                                    else if (fmt.Length == 10)
                                    {
                                        //yyyy-MM-dd
                                        dtp.Text = (string)(ss.Substring(0, 4) + "-" + ss.Substring(4, 2) + "-" + ss.Substring(6, 2) + " ");
                                    }
                                    else if (fmt.Length == 8)
                                    {
                                        //HH:mm:ss
                                        dtp.Text = (string)(ss.Substring(0, 2) + ":" + ss.Substring(2, 2) + ":" + ss.Substring(4, 2) + " ");
                                    }
                                    
                                }
                            }
                            else if (Retcol[iCount] is F4COMN)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((F4COMN)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((F4COMN)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                            else if (Retcol[iCount] is F4COMR)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((F4COMR)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((F4COMR)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                            else if (Retcol[iCount] is F4ETCN)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((F4ETCN)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((F4ETCN)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                            else if (Retcol[iCount] is F4ETCR)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((F4ETCR)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((F4ETCR)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                           
                            else if (Retcol[iCount] is NumericUpDown)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((NumericUpDown)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((NumericUpDown)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }                         

                            else if (Retcol[iCount] is CeriUDate)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((CeriUDate)Retcol[iCount]).RawDate = "";
                                }
                                else
                                {
                                    ((CeriUDate)Retcol[iCount]).RawDate = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                       
                            else if (Retcol[iCount] is MaskedDate)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((MaskedDate)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    MaskedDate curCeriUDate = (MaskedDate)Retcol[iCount];
                                    string TimeStr = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                    try
                                    {
                                        curCeriUDate.Text = TimeStr;
                                    }
                                    catch { ((MaskedDate)Retcol[iCount]).Text = ""; }
                                }
                            }

                            else if (Retcol[iCount] is Label)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((Label)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((Label)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                       

                            else if (Retcol[iCount] is NumBox)
                            {
                                try
                                {
                                    ((NumBox)Retcol[iCount]).NumValue = double.Parse(AdoRs.Fields[iCount - 1].Value.ToString().Trim());
                                }
                                catch { ((NumBox)Retcol[iCount]).NumValue = 0; }
                            }
                            else if (Retcol[iCount] is Control)
                            {
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((Control)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((Control)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }
                            }
                            else
                            {
                                //Atext = AdoRs.Fields(iCount - 1).Value
                                if (AdoRs.Fields[iCount - 1].Value == null)
                                {
                                    ((TextBox)Retcol[iCount]).Text = "";
                                }
                                else
                                {
                                    ((TextBox)Retcol[iCount]).Text = AdoRs.Fields[iCount - 1].Value.ToString().Trim();
                                }

                            }

                        }

                        AdoRs.MoveNext();

                    }
                }
                else
                {
                    AdoRs = null;
                    returnValue = "";
                    return returnValue;
                }

                Gp_Ms_ControlLock(Lockcon, true);
                AdoRs = null;
                returnValue = "OK";

            }
            catch (Exception ex)
            {
                AdoRs = null;
                returnValue = "FAIL";
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_Display Error : " + ex.Message), "", "");
                if (Information.Err().Number == 438 || Information.Err().Number == -2147467259)
                {
                    Conn.Close();
                }

            }
            Conn.Close();
            return returnValue;
        }

        /// <summary>
        /// 对Mc进行删除操作。
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Mc"></param>
        /// <returns></returns>
        public bool Gf_Ms_Del(ADODB.Connection Conn, Collection Mc)
        {
            bool returnValue;

            int iCount;
            string sQuery;
            //Dim sMessg As String

            returnValue = true;

            try
            {
                //pControl Enabled=true is Not Delete
                for (iCount = 1; iCount <= ((Collection)Mc["pControl"]).Count; iCount++)
                {
                    if (((Control)((Collection)Mc["pControl"])[iCount]).Enabled == true)// 
                    {
                        GeneralCommon.Gp_MsgBoxDisplay("首先要查询资料...!!!", "I", "");
                        returnValue = false;
                        return returnValue;
                    }
                }

                //delete Confirm Message
                if (!GeneralCommon.Gf_MessConfirm("确实删除吗...???", "Q", ""))
                {
                    returnValue = false;
                    return returnValue;
                }

                //Delete Make Query
                sQuery = Gf_Ms_MakeQuery((string)(Mc["P-M"]), "D", (Collection)Mc["iControl"]);

                if (sQuery == "FAIL")
                {
                    returnValue = false;
                    return returnValue;
                }

                //Query Process
                if (Gf_Ms_ExecQuery(Conn, sQuery,Mc))
                {
                    Gp_Ms_ControlLock((Collection)Mc["pControl"], false);                 
                    GeneralCommon.GStatusBar.Panels[0].Text = " Message : 删除资料完成...!!!";
                    returnValue = true;
                }
                else
                {
                    returnValue = false;                 
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");
                }

            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_Del Error : " + ex.Message), "", "");
            }
            return returnValue;
        }

        /// <summary>
        /// 根据Mc的控件enable属性进行判断是进行插入还是修改动作。
        /// 
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Mc"></param>
        /// <param name="sAuthority"></param>
        /// <returns></returns>
        public bool Gf_Ms_Process(ADODB.Connection Conn, Collection Mc, string sAuthority)
        {
            bool returnValue = false;
            string sQuery;
            string sMessg;

            try
            {
                //Necessarily Check
                sMessg = Gf_Ms_NeceCheck((Collection)Mc["nControl"]);

                if (sMessg.Trim() != "OK")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("必须输入 " + sMessg.Trim() + " ...!!!", "I", "");
                    returnValue = false;
                    return returnValue;
                }

                //Maxlength Check
                sMessg = Gf_Ms_NeceCheck2((Collection)Mc["mControl"]);

                if (sMessg.Trim() != "OK")
                {
                    GeneralCommon.Gp_MsgBoxDisplay("输入的项目必须符合 " + sMessg.Trim() + " 的长度...!!!", "I", "");
                    returnValue = false;
                    return returnValue;
                }

                if (((Collection)Mc["pControl"]).Count > 0 && ((Control)((Collection)Mc["pControl"])[1]).Enabled == true)
                {

                    //Insert Make Query
                    sQuery = Gf_Ms_MakeQuery((string)(Mc["P-M"]), "I", (Collection)Mc["iControl"]);

                    if (sQuery == "FAIL")
                    {
                        returnValue = false;
                        return returnValue;
                    }

                    if (Gf_Ms_ExecQuery(Conn, sQuery, Mc))
                    {

                        sQuery = Gf_Ms_MakeQuery((string)(Mc["P-R"]), "R", (Collection)Mc["pControl"]);

                        if (sQuery == "FAIL")
                        {
                            returnValue = false;
                            return returnValue;
                        }

                        Gf_Ms_Display(Conn, sQuery, (Collection)Mc["rControl"], (Collection)Mc["lControl"]);
                        Gp_Ms_ControlLock((Collection)Mc["pControl"], true);
                        returnValue = true;
                        GeneralCommon.GStatusBar.Panels[0].Text = " Message : 输入资料完成...!!!";
                    }
                    else
                    {
                        returnValue = false;
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");
                    }

                }
                else
                {

                    if (sAuthority.Substring(2, 1) == "0")
                    {
                        return true;
                    }

                    sQuery = Gf_Ms_MakeQuery((string)(Mc["P-M"]), "U", (Collection)Mc["iControl"]);
                    if (sQuery == "FAIL")
                    {
                        return false;
                    }

                    if (Gf_Ms_ExecQuery(Conn, sQuery,Mc))
                    {
                        sQuery = Gf_Ms_MakeQuery((string)(Mc["P-R"]), "R", (Collection)Mc["pControl"]);

                        if (sQuery == "FAIL")
                        {
                            return false;
                        }

                        Gf_Ms_Display(Conn, sQuery, (Collection)Mc["rControl"], (Collection)Mc["lControl"]);
                        Gp_Ms_ControlLock((Collection)Mc["pControl"], true);
                        returnValue = true;
                        GeneralCommon.GStatusBar.Panels[0].Text = " Message : 资料修改完成...!!!";
                    }
                    else
                    {
                        returnValue = false;
                        GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");
                    }

                }

            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Failed in data processing : " + ex.Message), "", "");
            }

            return returnValue;
        }

        ///// <summary>
        ///// 根据Mc控件的属性判断状态是否能够进行删除，能够进行就删除返回true，否则返回false。
        ///// </summary>
        ///// <param name="Conn"></param>
        ///// <param name="Sc"></param>
        ///// <param name="Mc"></param>
        ///// <returns></returns>
        //public bool Gf_Ms_AllDel(ADODB.Connection Conn, Collection Sc, Collection Mc)
        //{
        //    bool returnValue = false;

        //    SpreadCommon SpreadCommon = new SpreadCommon();

        //    string sQuery;

        //    int iCount;
        //    int iProcessCount;

        //    iProcessCount = 0;

        //    try
        //    {

        //        if (Mc != null)
        //        {
        //            //PK Lock Check
        //            for (iCount = 1; iCount <= ((Collection)Mc["pControl"]).Count; iCount++)
        //            {

        //                if (((Control)((Collection)Mc["pControl"])[iCount]).Enabled)
        //                {
        //                    GeneralCommon.Gp_MsgBoxDisplay("首先要查询资料...!!!", "I", "");
        //                    returnValue = false;
        //                    return returnValue;
        //                }

        //            }

        //        }

        //        //Delete Check Confirm
        //        if (GeneralCommon.Gf_MessConfirm("确实删除吗...???", "Q", "") == false)
        //        {
        //            ////// returnValue = true;源代码是返回true 2012-8-16 15:59注释  耿朝雷
        //            return false;
        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        returnValue = false;
        //        GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_AllDel Error : " + ex.Message), "", "");
        //    }

        //    return returnValue;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="Sc"></param>
        /// <param name="Mc"></param>
        /// <returns></returns>
        public bool Gf_Ms_AllDel(ADODB.Connection Conn, Collection Sc, Collection Mc)
        {
            bool returnValue = false;

            SpreadCommon SpreadCommon = new SpreadCommon();

            string sQuery;
            //Dim sMesg As String
            //Dim sErrorID As String
            //Dim sDel_MSG As String

            int iCount;
            int iProcessCount;

            iProcessCount = 0;

            try
            {

                if (Mc != null)
                {
                    //PK Lock Check
                    for (iCount = 1; iCount <= ((Collection)Mc["pControl"]).Count; iCount++)
                    {

                        if (((Control)((Collection)Mc["pControl"])[iCount]).Enabled)
                        {
                            GeneralCommon.Gp_MsgBoxDisplay("首先要查询资料...!!!", "I", "");
                            returnValue = false;
                            return returnValue;
                        }

                    }

                }
                ////////////////20120910 耿朝雷修改 start
                //Delete Check Confirm
                if (GeneralCommon.Gf_MessConfirm("确实删除吗...???", "Q", "") == false)
                {
                    ////// returnValue = true;源代码是返回true 2012-8-16 15:59注释  耿朝雷
                    return false;
                }

                sQuery = Gf_Ms_MakeQuery((string)(Mc["P-M"]), "D", (Collection)Mc["iControl"]);

                if (sQuery == "FAIL")
                {
                    return false;
                }

                //sMessg = Gf_Ms_Display(Conn, sQuery, Mc.Item("rControl"), Mc.Item("lControl"))

                //Query Process
                if (Gf_Ms_ExecQuery(Conn, sQuery,Mc))
                {
                    Gp_Ms_ControlLock((Collection)Mc["pControl"], false);
                    //GeneralCommon.MDIMain.StatusBar1.Panels(0).Text = " Message : 删除资料完成...!!!";
                    GeneralCommon.GStatusBar.Panels[0].Text = " Message : 删除资料完成...!!!";
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                    //20090828,ashen,修改
                    //去掉该句的注释
                    GeneralCommon.Gp_MsgBoxDisplay(GeneralCommon.sErrMessg, "", "");
                }
                ////////////////20120910 耿朝雷修改 end

            }
            catch (Exception ex)
            {
                returnValue = false;
                GeneralCommon.Gp_MsgBoxDisplay((string)("Gf_Ms_AllDel Error : " + ex.Message), "", "");
            }

            return returnValue;
        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="ObjectName"></param>
      /// <param name="sAuthority"></param>
      /// <param name="Locked"></param>
        public void Gf_Ms_Locked(Control ObjectName, string sAuthority, bool Locked)
        {

            try
            {
                if (sAuthority.Substring(2, 1) == "0")
                {
                    ObjectName.Enabled = false;
                    ObjectName.EnabledChanged += new System.EventHandler(Gf_Ms_EnableChangedF);
                }
                else
                {
                    if (Locked)
                    {
                        ObjectName.EnabledChanged += new System.EventHandler(Gf_Ms_EnableChangedT);
                    }
                }
            }
            catch (Exception)
            {
                ObjectName.EnabledChanged += new System.EventHandler(Gf_Ms_EnableChangedF);
            }

        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void Gf_Ms_EnableChangedF(object sender, System.EventArgs e)
        {

            if (((Control)sender).Enabled == true)
            {
                ((Control)sender).Enabled = false;
            }

        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Gf_Ms_EnableChangedT(object sender, System.EventArgs e)
        {

            if (((Control)sender).Enabled == false)
            {
                ((Control)sender).Enabled = true;
            }
        }

    }

}
