using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //多控件用一个函数事件处理
            //初始化两个下拉框的数据
            //绑定内容改变事件
            comboBox1.Items.AddRange(["升序", "降序"]);
            comboBox2.Items.AddRange(["升序", "降序"]);
            comboBox1.TextChanged += cb_textchange;
            comboBox2.TextChanged += cb_textchange;

        }
        private void cb_textchange(object sender, EventArgs e)
        {
            //先判断是哪一个下拉框
            if ((sender as ComboBox) == comboBox1)
            {
                //再判断是升序还是降序
                if (comboBox1.Text == "升序")
                {
                    MessageBox.Show("价格升序");
                }
                else if (comboBox1.Text == "降序")
                {
                    MessageBox.Show("价格降序");
                }
            }
            else
            {
                if (comboBox2.Text == "升序")
                {
                    MessageBox.Show("时间升序");
                }
                else if (comboBox2.Text == "降序")
                {
                    MessageBox.Show("时间降序");
                }
            }
        }
    }
}
