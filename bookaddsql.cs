using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp9
{
    public partial class bookaddsql : Form
    {
        private string ConnStr = "server=127.0.0.1;port=3306;database=test;uid=root;password=root;charset=utf8";
        public bookaddsql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn=new MySqlConnection(ConnStr))
            {
                conn.Open();
                
                string sql = "insert into book(name,author,price,`label`,is_borrow) values(@name,@author,@price,@label,@is_borrow)";

                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                     comm.Parameters.AddWithValue("@name", input1.Text);
                     comm.Parameters.AddWithValue("@author", input2.Text);
                     comm.Parameters.AddWithValue("@price", double.Parse(input3.Text));
                     comm.Parameters.AddWithValue("@label", input4.Text);
                     comm.Parameters.AddWithValue("@is_borrow", "2");
                    int row = comm.ExecuteNonQuery();
                }
            }
        }
    }
}
