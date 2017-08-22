using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CommonClass;

namespace CG
{
    public partial class LoadExcel : Form
    {
        public LoadExcel()
        {
            InitializeComponent();
        }

        string path = "";
        List<string> list = new List<string>();//定义list变量，存放获取到的路径
        string currentReportPath = System.Windows.Forms.Application.StartupPath + "\\南钢中板轧钢计划查询导出Excel文件夹";

        /// <summary>
        /// 打开选择EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile_Click(object sender, EventArgs e)
        {
            string openPath;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = currentReportPath;
            dialog.Description = "请选择EXCEL所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    GeneralCommon.Gp_MsgBoxDisplay("文件夹路径不能为空", "I", "提示");
                    return;
                }
                openPath = dialog.SelectedPath;
                open(openPath);
            }
        }

        public void open(string excelPath)
        {
            DirectoryInfo dir = new DirectoryInfo(excelPath);
            FileInfo[] fil = dir.GetFiles("*.xls");
            listBox1.Items.Clear();//清空所有值
            list.Clear();//清空集合中元素
            foreach (FileInfo f in fil)
            {
                list.Add(f.FullName);//添加文件的路径到列表
                listBox1.Items.Add(f.Name);
            }
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
                path = list[listBox1.SelectedIndex];
            }
            else
            {
                path = "";
            }
        }


        private void LoadExcel_Load(object sender, EventArgs e)
        {
            open(currentReportPath);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = list[listBox1.SelectedIndex];
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
