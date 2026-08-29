using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Add : UserControl
    {
        public Add(string bookname, string author,double price,string label)
        {
            InitializeComponent();
            input1.Text = bookname;
            input2.Text = author;
            input3.Text = price.ToString();
            input4.Text = label;
        }
        public Add()
        {
            InitializeComponent();
        }
    }
}
