using System.Diagnostics;
using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Xml;
using System.IO;

namespace CommonClass
{
	public struct ColumnDic
	{
		public string sColumn; //Condition Key
		public string sType; //sJoin
		public string sLength; //sQuery
		public string sComCode; //sWhere
		public string sJoin; //Control, Spread Type
		public string sAttr;
		public string sCusCode; //Name Type
		public int iScSeq; //Data Select Status
		public int iMcSeq; //Spread Name
	}
	
	public class ReadConfig
	{
		
		
		XmlDocument xmlDoc = new XmlDocument();
		XmlElement xmlNode;
		XmlNodeList columnList;
		
		public List<ColumnDic> list = new List<ColumnDic>();
		public void setConfig(string sFile)
		{
			xmlDoc.Load(sFile);
			xmlNode = xmlDoc.DocumentElement;
			columnList = xmlNode.ChildNodes;
			columnList.GetEnumerator();
		}
		
		public int getColumns()
		{
			return xmlNode.ChildNodes.Count;
		}
		
		public void setColumn()
		{
			IEnumerator iColumn;
			
			iColumn = columnList.GetEnumerator();
			iColumn.Reset();
			
			while (iColumn.MoveNext())
			{
				XmlElement xmlNode;
                xmlNode = (XmlElement)iColumn.Current;
				ColumnDic dic = new ColumnDic();
			

				if (xmlNode.GetElementsByTagName("Column")[0].InnerText == "")
				{
					break;
				}
				else
				{
					dic.sColumn = xmlNode.GetElementsByTagName("Column")[0].InnerText;
				}
				
				dic.sType = xmlNode.GetElementsByTagName("Type")[0].InnerText;
				dic.sLength = xmlNode.GetElementsByTagName("Length")[0].InnerText;
				dic.sAttr = xmlNode.GetElementsByTagName("Attr")[0].InnerText;
				dic.sComCode = xmlNode.GetElementsByTagName("ComCode")[0].InnerText;
				dic.sJoin = xmlNode.GetElementsByTagName("Join")[0].InnerText;
				dic.sCusCode = xmlNode.GetElementsByTagName("CusCode")[0].InnerText;
				
				if (xmlNode.GetElementsByTagName("ScSeq")[0].InnerText == "")
				{
					dic.iScSeq = 1;
				}
				else
				{
					dic.iScSeq = int.Parse(xmlNode.GetElementsByTagName("ScSeq")[0].InnerText);
				}
				
				if (xmlNode.GetElementsByTagName("HeadRow")[0].InnerText == "")
				{
					dic.iMcSeq = 0;
				}
				else
				{
					dic.iMcSeq = int.Parse(xmlNode.GetElementsByTagName("HeadRow")[0].InnerText);
				}
				list.Add(dic);
			}
		}
	}
	
}
