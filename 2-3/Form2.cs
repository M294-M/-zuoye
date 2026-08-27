using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        private Label tipslabel;
        public Form2()
        {
            InitializeComponent();
            initdelate();//限制删除
            initbigsmall();//控件的放大和缩小
            inittips();//鼠标移入出现提示

        }
        private void inittips()
        {
          //button1.MouseEnter += Button1_MouseEnter;//绑定
          //  button1.MouseLeave += Button1_MouseLeave;
            //用代码定义一个label
            tipslabel=new Label();  
            tipslabel.Text = "鼠标移入";//设置提示文本
            tipslabel.Name = "tipslabel";//设置提示文本的名称

            Point tl=tipslabel.Location;
            tl.X=button1.Location.X + button1.Width + 10;
            tl.Y = button1.Location.Y;
            tipslabel.Location = tl;
            button1.MouseEnter += Button1_MouseEnter;//绑定
            button1.MouseLeave += Button1_MouseLeave;


        }
        private void Button1_MouseEnter(object? sender, EventArgs e)
        {
            this.Controls.Add(tipslabel);
        }
        private void Button1_MouseLeave(object? sender, EventArgs e)
        {
            this.Controls.Remove(tipslabel);
        }



        private void initbigsmall()
        {
            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;
        }

        private void Panel1_MouseEnter(object? sender, EventArgs e)
        {
            panel1.Size = new Size(200, 200);
        }
        private void Panel1_MouseLeave(object? sender, EventArgs e)
        {
            panel1.Size = new Size(100, 100);
        }
        private void initdelate()
        {
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back||e.KeyCode==Keys.Delete)
            {
                e.SuppressKeyPress= true;//keyeventargs的属性,抑制内容输入
                //e.Handled = true; // keypress事件的属性,抑制内容输入
            }
        }
    }
}
