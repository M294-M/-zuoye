using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp8;

namespace WinFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            string author = textBox2.Text;
            double price = double.Parse(textBox3.Text);
            string label = textBox4.Text;
           Add bookAdd= new Add(bookname, author, price, label);
            flowLayoutPanel1.Controls.Add(bookAdd);

        }
    }
}
