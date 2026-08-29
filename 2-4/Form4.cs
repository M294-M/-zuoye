using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form4 : Form
    {
        private Dictionary<string, dynamic> prodic = new();
        public Form4()
        {
            InitializeComponent();
            //初始化字典， 加入多个此形式的键值对，["省份"]=["城市","城市",....]
            prodic.Add("广东省", new List<string> { "广州", "深圳", "珠海" });
            prodic.Add("广西省", new List<string> { "南宁", "柳州", "桂林" });
            pbox.Items.AddRange(prodic.Keys.ToArray());
            pbox.SelectedIndexChanged += Change;


        }
        private void Change(object sender, EventArgs e)
        {
            //获取省份下拉框的选中项
            string province = (sender as ComboBox).Text;
            //清空城市下拉框的内容
            cbox.Items.Clear();
            //根据省份获取城市列表
            List<string> citylist = prodic[province];
            //将城市列表添加到城市下拉框中
            cbox.Items.AddRange(citylist.ToArray());
        }
    }
}
