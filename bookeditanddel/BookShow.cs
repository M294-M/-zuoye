using AntdUI;
using AntdUI.In;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp9.book
{
    public partial class BookShow : Form
    {
        public BookShow()
        {
            InitializeComponent();
            showBook();
            //LoadBookList();
        }
        private void showBook()
        {
            string JsonStr = File.ReadAllText("./book.json");
            List<Bookinfo> books = JsonSerializer.Deserialize<List<Bookinfo>>(JsonStr);
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
        new AntdUI.Column("Id", "编号")
        {
            Render = (object val,object cel,int index ) =>index.ToString()

        },
        new AntdUI.Column("Name", "书名"),
        new AntdUI.Column("Author", "作者"),
        new AntdUI.Column("Price", "价格"),
        new AntdUI.Column("BookLabel", "标签"),
        new AntdUI.Column("IsBorrow", "是否借阅"){
            // val 单元的值, cel: 行数据, index 行号
            Render = (object val,object cel,int index) =>
            {
                return (bool)val?"已借阅":"书架中";
            }
        },
    };

            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            // 绑定事件
            table1.CellClick += Table1_CellClick;

        }

        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            Bookinfo book = (e.Record as Bookinfo);
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex.ToString() == "6")
            {
                // 删除
                string path = Path.Combine(Application.StartupPath, "book.json");
                List<Bookinfo> books = new List<Bookinfo>();
                if (File.Exists(path))
                {
                    string jsonStr = File.ReadAllText(path);
                    books = JsonSerializer.Deserialize<List<Bookinfo>>(jsonStr) ?? new List<Bookinfo>();
                }
                //根据Id移除
                books.RemoveAll(b => b.Id == book.Id);

                string writeJson = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, writeJson);

                MessageBox.Show("删除成功");
                showBook(); 
                return;
                
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                // 编辑
                new BookEdit(book.Id).Show();
            }
        }

        

        
    }
}
