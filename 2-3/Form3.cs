using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form3 : Form
    {
        private int maxLength = 10; // 设置最大长度为10
        public Form3()
        {
            InitializeComponent();
            initlimitlength();//限制最大长度
            InitFilterList(); // 列表框数据过滤
        }
       private string[] numarr = ["111", "222", "333", "1122", "2233", "3344"];
        private void InitFilterList()
        {
            //初始化，添加初始值到列表框中方法 addrange()
            //string[] numarr = ["111","222","333","1122","2233","3344"];在查找时会用到定义在类中
            listBox1.Items.AddRange(numarr);
            //给文本框绑定内容改变事件
            textBox2.TextChanged += TextBox2_TextChanged_Filter;

        }
        private void TextBox2_TextChanged_Filter(object? sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            //获取文本框中的内容，使用字符串方法在列表框中进行查找
            string text = tb.Text;
            List<string> reslist=numarr.ToList().FindAll(item => item.Contains(text));//查找列表框中包含文本框内容的项
            //先清空列表框的内容不然不包含的项还会显示
            listBox1.Items.Clear();
            //将查找结果添加到列表框中
            listBox1.Items.AddRange(reslist.ToArray());//转为数组

        }


        private void initlimitlength()
        {
           textBox1.TextChanged += TextBox1_TextChanged;

        }
        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            TextBox tb= sender as TextBox;
            if (tb.Text.Length >= maxLength)
            {
                tb.Text = tb.Text.Substring(0, maxLength);
                label2.Visible = true;
                tb.SelectionStart = maxLength; // 设置光标位置在文本末尾
            }
            else
            { label2.Visible = false; }
        }
    }
}
