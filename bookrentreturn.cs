using AntdUI;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp10.book
{
    public partial class BookShow : Form
    {
        private Mysql MySql { get; set; }
        public BookShow()
        {
            InitializeComponent();
            MySql = new Mysql("test");
            ShowData();
            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            //获取点击的行数据
            System.Data.DataRow Book = e.Record as System.Data.DataRow;
            int clickCol = e.ColumnIndex;
            if (clickCol == 6)
            {
                DialogResult res = MessageBox.Show("编辑还是删除?\n是=编辑\n否=删除", "编辑删除", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    //跳转到编辑页面
                    BookAddAndEdit BE = new BookAddAndEdit("编辑", Book["id"].ToString());
                    BE.Show();
                    this.Hide();
                    BE.FormClosing += BE_FormClosing;

                }
                else if (res == DialogResult.No)
                {
                    //执行删除操作
                    string sql = "delete from book where id=@id";
                    MySql.ConAndHandler(sql, (cmd) =>
                    {
                        cmd.Parameters.AddWithValue("@id", Book["id"]);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("删除成功");
                            ShowData();
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                    });

                }
            }
            else if (clickCol == 7)
            {
                string state = Book["is_borrow"].ToString();
                string tipText = state == "2" ? "确认要借书吗？" : "确认要还书吗？";

                DialogResult res = MessageBox.Show(tipText, "借还操作", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int bookId = Convert.ToInt32(Book["id"]);
                    BorrowReturn(bookId, state);
                    ShowData();
                }
            }
        }
            private void BorrowReturn(int bookId, string isBorrow)
        {
            int newState = isBorrow == "2" ? 1 : 2;
            string sql = "update book set is_borrow=@is_borrow where id=@id";
            MySql.ConAndHandler(sql, cmd =>
            {
                
                cmd.Parameters.AddWithValue("@is_borrow", newState);
                cmd.Parameters.AddWithValue("@id", bookId);
               int n= cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    
                    MessageBox.Show(newState == 1 ? "借书成功" : "还书成功");
                }
                else
                {
                    
                    MessageBox.Show("操作失败，未匹配到图书记录");
                }
            });
            
        }




        

        private void BE_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
            ShowData();
        }

        private void ShowData()
        {
            string sql = "SELECT * FROM book";
            MySql.ConAndHandler(sql, (cmd) =>
            {
                //展示数据需要调用配置器
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                table1.DataSource = dt;
                SetColumn();
            });

        }
        private void SetColumn()//设置表格列
        {
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection()
            {
               new AntdUI.Column("id","编号"){ Render=(object val,object cel,int index)=>index+1},

               new AntdUI.Column("name","书名"),
               new AntdUI.Column("author","作者"),
               new AntdUI.Column("price","价格"),
               new AntdUI.Column("label","标签"),
               new AntdUI.Column("is_borrow","借")
               { Render=(object val,object cel,int index)=>val.ToString()=="1"?"已借阅":"在书架"},


            };
            var HandelCol = new AntdUI.Column("handel", "操作");
            HandelCol.Render = (object val, object cel, int index) => "编辑|删除";
            table1.Columns.Add(HandelCol);
            var rentreturn = new AntdUI.Column("rentreturn", "借还");
            rentreturn.Render = (object val, object cel, int index) =>
            {
                DataRow row = cel as DataRow;
                if (row == null) return "";
                string borrow = row["is_borrow"].ToString();
                return borrow == "1" ? "还书" : "借书";
            };
            table1.Columns.Add(rentreturn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAddAndEdit BA = new BookAddAndEdit("新增");
            BA.Show();
            this.Hide();
            BA.FormClosing += BA_FormClosing;
        }

        private void BA_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
            ShowData();
        }
    }
}
