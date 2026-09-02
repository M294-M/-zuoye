using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;
using WinFormsApp9.book;


//using WinFormsApp9.book;

namespace WinFormsApp9.book
{
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }
        private string editid;
        public BookEdit(string id)
        {
            InitializeComponent();
            editid= id;
            // 根据id查找数据
            //MessageBox.Show(id); 
            // 回显  ====> 根据id 查找到 对应的书籍数据 ==> 显示在界面中(界面使用UCBook)
            //  编辑按钮, 修改
            control1.SendData += EditBook;
        }
        
        public void EditBook(Bookinfo intbook)
        {
            List<Bookinfo> books = new();
            string jsonstr;
            if (File.Exists("./book.json"))
            {
                //读文件，反序列化
                jsonstr = File.ReadAllText("./book.json");
                books = JsonSerializer.Deserialize<List<Bookinfo>>(jsonstr);
            }
           Bookinfo bookid= books.Find(item => item.Id == editid);
            if (bookid == null)
            {
                MessageBox.Show("不存在");
                this.Close();
                return;
            
            }
           
                           
                bookid.Name = intbook.Name;
                bookid.Author = intbook.Author;
                bookid.Price = intbook.Price;
                bookid.BookLabel = intbook.BookLabel;
                bookid.IsBorrow = intbook.IsBorrow; 
           
            jsonstr = JsonSerializer.Serialize(books,
                new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
            File.WriteAllText("./book.json",jsonstr);
            MessageBox.Show("编辑成功");
            this.Close();
        }
    }
}
