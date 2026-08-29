using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //给多选框allbox绑定选中改变事件
            allbox.CheckStateChanged += allcheck;
            //遍历panel1中的所有控件,为所有子控件绑定状态改变事件
            foreach (Control ctrl in panel1.Controls)
            {
                (ctrl as CheckBox).CheckStateChanged += itemcheck;
            }
        }
        private void itemcheck(object sender, EventArgs e)
        {
            
        }

       
        
        private void allcheck(object sender, EventArgs e)
        {
            //判断allbox是否被选中
            bool isChecked = allbox.CheckState == CheckState.Checked ?true:false;
            if (allbox.CheckState != CheckState.Indeterminate)
            {
                foreach (Control ctrl in panel1.Controls)
                {
                    (ctrl as CheckBox).Checked = isChecked;
                
                }
            }
        }
    }
}
