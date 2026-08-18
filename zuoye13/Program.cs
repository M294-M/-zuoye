using System.Text.Json;

namespace BookManger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        // 根据输入的书名删除 
                        Console.WriteLine("请输入要删除的图书名");
                        string bookname=Console.ReadLine();
                        var resbook2 = BM.RemoveBook(bookname);
                        Console.WriteLine(resbook2);

                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        // 根据输入的书名 修改图书
                        Console.WriteLine("请输入要编辑的书名");
                        string bookname3= Console.ReadLine();
                        Console.WriteLine("请输入书名");
                        string bookName3 = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author3 = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark3 = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price3 = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic1 = new()
                        {
                            ["name"] = bookName3,
                            ["author"] = author3,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark3,
                            ["price"] = price3
                        };
                        
                        var res3 = BM.EditBook(bookDic1,bookName3);
                        Console.WriteLine(res3);


                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var resList = BM.SearchBook();
                        // 结果list长度是够为0
                        if (resList.Count==0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else
                        {
                            foreach(var item in resList)
                            {
                                Console.WriteLine($"书名：{item["name"]} - 作者：{item["author"]} - 标签：{item["mark"]} - 价格：{item["price"]}");
                            }
                        }
                            break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入查询的书名");
                        string searchBookName = Console.ReadLine();
                        var resBook = BM.SearchBook(searchBookName);
                        if(resBook.Count ==0) Console.WriteLine("没找到对应的数据，请先添加");
                        else Console.WriteLine($"书名：{resBook["name"]} - 作者：{resBook["author"]} - 标签：{resBook["mark"]} - 价格：{resBook["price"]}");
                        break;
                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }

            }
        }
    }
}
