using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form3 : Form
    {
        private List<string> namelist = ["红色","橙色","黄色","绿色","蓝色","青色","紫色"];
        private List<Color> colorlist = [Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Cyan, Color.Purple];
        private int index = 0;
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(namelist.ToArray());
            comboBox1.SelectedIndexChanged += change;
        }
        private void change(object sender, EventArgs e)
        {
            index=namelist.FindIndex(item => item == (sender as ComboBox).Text);
            //index =(sender as ComboBox).SelectedIndex;
         //index = comboBox1.SelectedIndex;
            colorlist.Find(item => item == colorlist[index]);
            this.BackColor = colorlist[index];
        }
    }
}
