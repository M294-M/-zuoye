using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookManager
{
    internal class BookManager
    {
    
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        // 新增数据：强制要求 ==> 将list写入文件中
        List<Dictionary<string, dynamic>> bookList = new();
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {

            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)

            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            //List<Dictionary<string, dynamic>> bookList = new();

            if (File.Exists(path)) {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            }
            bool isexit = bookList.Exists(item => item["name"].ToString() == bookDic["name"]); 
            if (isexit) return "用户已经存在!!!";

            else  bookList.Add(bookDic); 
            
            //序列化
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            // 写入文件
            File.WriteAllText(path, jsonStr);

            return "新增数据成功!!!";
        }
        // 编辑数据
        public string EditBook(Dictionary<string, dynamic> bookDic)
        {
            // 编辑的逻辑处理
            return "ok";
        }
        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            return "ok";
        }
        // 查询单个数据
        public string SearchBook(string bookname) // 返回值根据情况修改
        {
            if (File.Exists(path))
            {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
          bookList=JsonSerializer.Deserialize<List<Dictionary<string,dynamic>>>(json);
            }
            var res = bookList.Find(item => item["name"].ToString() == bookname );
            if (res == null) return "图书名错误";
            
                return $"查询成功，name{res["name"]}-author{res["author"]}-mark{res["mark"]}-price{res["price"]}";
            
        }
        // 根据图书名称查询suoyou 图书数据：强制要求
        public string getallbook() // 返回值根据情况修改
        {
            if (File.Exists(path))
            {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            }
            if (bookList == null || bookList.Count == 0) { 
                    return "当前无数据，请先添加数据";
            
            }
            //Console.WriteLine($"查询到{bookList.Count}本书");
            StringBuilder n=new StringBuilder();
            n.AppendLine($"查询到{bookList.Count}本书");
            int index = 1;
            foreach (var book in bookList)
            {
                n.AppendLine($"第{index}本");
                n.AppendLine($"{book["name"]}");
                n.AppendLine($"{book["mark"]}");
                n.AppendLine($"{book["price"]}");
                index++;

            }
            return n.ToString();
        }

        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}
