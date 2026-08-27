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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            initQDJC();//密码强度检测
            initQFWFG();//千分位分割
            InitToUpper();//转大写
        }
        private void InitToUpper()
        {
            //绑定内容改变事件
            textBox3.TextChanged += TextBox3_TextChanged;
        }

        private void TextBox3_TextChanged(object? sender, EventArgs e)
        {
            //将文本框中的内容转换为大写
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void initQFWFG()
        {
            //数字.tostring("#,#")//千分位分割
            //绑定内容改变事件
            textBox2.TextChanged += TextBox2_TextChanged;
        }
        private void TextBox2_TextChanged(object? sender, EventArgs e)
        {

            //注意文本框中的数据不能为空，正则将非数字的内容替换为空
            //获取文本框中的内容强转为int类型，然后再使用tostring("#,#")方法进行千分位分割
            //最后光标要放在末尾
            string text = Regex.Replace((sender as TextBox).Text, @"[^\d]", "");//将非数字的内容替换为空
            int res=int.Parse(text);
            (sender as TextBox).Text = res.ToString("#,#");
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;



        }

        //定义一个变量用来记录密码强度
        private void initQDJC()
        {
            //绑定内容改变事件
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            //使用正则校验密码只有数字密码强度弱，有大小写字母强度中，有大小写字母和数字强度强
            int num = 0;
            TextBox tb = sender as TextBox;
            if (Regex.IsMatch(tb.Text, @"\d")) num++;//只有数字
             if (Regex.IsMatch(tb.Text, @"[a-z]")) num++;//只有字母
             if (Regex.IsMatch(tb.Text, @"[A-Z]")) num++;
            
            if (num == 1)
            {
                label2.Text = "密码强度弱";
                label2.ForeColor = Color.Red;

            }
            else if (num == 2)
            {
                label2.Text = "密码强度中";
                label2.ForeColor = Color.Orange;
            }
            else if (num == 3)
            {
                label2.Text = "密码强度强";
                label2.ForeColor = Color.Green;

            }
            else
            {
                label2.Text = "密码错误";
                label2.ForeColor = Color.Red;
            }
        }

        
    }
}
