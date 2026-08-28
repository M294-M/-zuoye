using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitTotal();//计算物价总和

        }
        //定义一个list存储单价，文本框，按钮，组成一个字典
        private List<Dictionary<string, Control>> conlist = new List<Dictionary<string, Control>>();
        private void InitTotal()
        {
            //初始化，添加单价，文本框，按钮
            conlist.Add(new Dictionary<string, Control> {
                ["price"]=label5,
                ["count"]= textBox1,
                ["add"] = button2,
                ["reduse"] = button1,
            });
            conlist.Add(new Dictionary<string, Control>
            {
                ["price"] = label6,
                ["count"] = textBox2,
                ["add"] = button4,
                ["reduse"] = button3
            });
            //初始统计数据
            restotal();
            //给文本框内容绑定事件
            //给add和reduse分别绑定点击事件
            conlist.ForEach(tb => tb["count"].TextChanged+=textchanged);
            conlist.ForEach(tb => tb["add"].Click += add);
            conlist.ForEach(tb => tb["reduse"].Click += reduse);
        }
        private void textchanged(object? sender, EventArgs e)
        {
            ////计算总和
            //int num = 0;//接受总和
            ////遍历conlist，计算总和
            //conlist.ForEach(tb =>
            //{

            //    if (string.IsNullOrEmpty(tb["count"].Text)) return;//如果文本框为空，则跳过
            //    else if (!Regex.IsMatch(tb["count"].Text, @"^[1-9]\d*$"))
            //    {
            //        tb["count"].Text = "0";
            //        (tb["count"] as TextBox).SelectionStart = 1;
            //    }//正则判断
            //    int price = int.Parse(tb["price"].Text);
            //    int count = int.Parse(tb["count"].Text);
            //    int total = price * count;
            //    num += total;
            //    label9.Text = num.ToString();
            //});
            restotal();
        }
        private void add(object? sender, EventArgs e)
        {
           Dictionary<string, Control> dic = conlist.Find(item => item["add"]==(sender as Button));
            if (string.IsNullOrEmpty(dic["count"].Text))
            { 
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart = 1; 
            }
            int n= int.Parse(dic["count"].Text);
            dic["count"].Text = (++n).ToString();




        }
        private void reduse(object? sender, EventArgs e)
        {
            Dictionary<string, Control> dic = conlist.Find(item => item["reduse"] == (sender as Button));
            if (string.IsNullOrEmpty(dic["count"].Text))
            {
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart = 1;
            }
            int n = int.Parse(dic["count"].Text);
            dic["count"].Text = (--n).ToString();

        }

        private void restotal() {

            //计算总和
            int num = 0;//接受总和
            //遍历conlist，计算总和
            conlist.ForEach(tb =>
            {

                if (string.IsNullOrEmpty(tb["count"].Text)) return;//如果文本框为空，则跳过
                else if (!Regex.IsMatch(tb["count"].Text, @"^[1-9]\d*$"))
                {
                    tb["count"].Text = "0";
                    (tb["count"] as TextBox).SelectionStart = 1;
                }//正则判断
                int price = int.Parse(tb["price"].Text);
                int count = int.Parse(tb["count"].Text);
                int total = price * count;
                num += total;
                label9.Text = num.ToString();
            });

        }
    }
}
