using System; 
using System.Data; 
using System.Web; 
using System.Xml;

namespace DownLoad
{
    /// <summary> 
    /// 类名:xml操作类 
    /// 作者:虫 
    /// 时间:2008.8.31 
    /// </summary> 
    public class XML_Operate
    {
        private XmlDocument XmlDoc;

        public XML_Operate()
        {

        }

        /// <summary> 
        /// 加载xml文件 
        /// </summary> 
        /// <param name="path">xml文件的物理路径 </param> 
        private void LoadXml(string path, string node_root)
        {
            XmlDoc = new XmlDocument();
            //判断xml文件是否存在 
            if (!System.IO.File.Exists(path))
            {
                //创建xml 声明节点 
                XmlNode Xmlnode = XmlDoc.CreateNode(System.Xml.XmlNodeType.XmlDeclaration, "", "");
                //添加上述创建和 xml声明节点 
                XmlDoc.AppendChild(Xmlnode);
                //创建xml dbGuest 元素（根节点） 
                XmlElement Xmlelem = XmlDoc.CreateElement("", node_root, "");
                XmlDoc.AppendChild(Xmlelem);
                try
                {
                    XmlDoc.Save(path);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                XmlDoc.Load(path);
            }
            else
            {
                //加载xml文件 
                XmlDoc.Load(path);
            }
        }

        /// <summary> 
        /// 添加xml子节点 
        /// </summary> 
        /// <param name="path">xml文件的物理路径 </param> 
        /// <param name="node_root">根节点名称 </param> 
        /// <param name="node_name">添加的子节点名称 </param> 
        /// <param name="node_text">子节点文本 </param> 
        public void addElement(string path, string node_root, string node_name, string node_text, string att_name, string att_value)
        {
            LoadXml(path, node_root);

            XmlNodeList nodeList = XmlDoc.SelectSingleNode(node_root).ChildNodes;//获取bookstore节点的所有子节点 
            //判断是否有节点,有节点就遍历所有子节点,看看有没有重复节点,没节点就添加一个新节点 
            if (nodeList.Count > 0)
            {
                foreach (XmlNode xn in nodeList)//遍历所有子节点 
                {
                    XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
                    if (xe.GetAttribute(att_name) != att_value)
                    {
                        XmlNode XmldocSelect = XmlDoc.SelectSingleNode(node_root);  //选中根节点 
                        XmlElement son_node = XmlDoc.CreateElement(node_name);    //添加子节点 
                        son_node.SetAttribute(att_name, att_value);    //设置属性 
                        son_node.InnerText = node_text;    //添加节点文本 
                        XmldocSelect.AppendChild(son_node);      //添加子节点 
                        XmlDoc.Save(path);          //保存xml文件 
                        break;
                    }
                }

            }
            else
            {
                XmlNode XmldocSelect = XmlDoc.SelectSingleNode(node_root);  //选中根节点 
                XmlElement son_node = XmlDoc.CreateElement(node_name);    //添加子节点 
                son_node.SetAttribute(att_name, att_value);    //设置属性 
                son_node.InnerText = node_text;    //添加节点文本 
                XmldocSelect.AppendChild(son_node);      //添加子节点 
                XmlDoc.Save(path);          //保存xml文件 
            }
        }

        /// <summary> 
        /// 修改节点的内容 
        /// </summary> 
        /// <param name="path">xml文件的物理路径 </param> 
        /// <param name="node_root">根节点名称 </param> 
        /// <param name="new_text">节点的新内容 </param> 
        /// <param name="att_name">节点的属性名 </param> 
        /// <param name="att_value">节点的属性值 </param> 
        public void UpdateElement(string path, string node_root, string new_text, string att_name, string att_value)
        {
            LoadXml(path, node_root);
            XmlNodeList nodeList = XmlDoc.SelectSingleNode(node_root).ChildNodes;//获取bookstore节点的所有子节点 
            foreach (XmlNode Xn in nodeList)//遍历所有子节点 
            {
                XmlElement Xe = (XmlElement)Xn;//将子节点类型转换为XmlElement类型 
                if (Xe.GetAttribute(att_name) == att_value)
                {
                    Xe.InnerText = new_text;    //内容赋值 
                    XmlDoc.Save(path);//保存 
                    break;
                }
            }

        }

        /// <summary> 
        /// 删除节点 
        /// </summary> 
        /// <param name="path">xml文件的物理路径 </param> 
        /// <param name="node_root">根节点名称 </param> 
        /// <param name="att_name">节点的属性名 </param> 
        /// <param name="att_value">节点的属性值 </param> 
        public void deleteNode(string path, string node_root, string att_name, string att_value)
        {

            LoadXml(path, node_root);

            XmlNodeList nodeList = XmlDoc.SelectSingleNode(node_root).ChildNodes;
            XmlNode root = XmlDoc.SelectSingleNode(node_root);

            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;

                if (xe.GetAttribute(att_name) == att_value)
                {
                    //xe.RemoveAttribute("name");//删除name属性 
                    xe.RemoveAll();//删除该节点的全部内容 
                    root.RemoveChild(xe);
                    XmlDoc.Save(path);//保存 
                    break;
                }

            }
        }

        public string  GetElementValue(string path, string node_root, string att_name)
        {

            LoadXml(path, node_root);

            XmlNodeList nodeList = XmlDoc.SelectSingleNode(node_root).ChildNodes;
            XmlNode root = XmlDoc.SelectSingleNode(node_root);

            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;

                return xe.GetAttribute(att_name);
               
            }
            return "";
        }
    }

}
