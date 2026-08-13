using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1
            List<Dictionary<string, dynamic>> list = new() {
                        new Dictionary<string, dynamic>(){
                        ["name"] = "zs",
                        ["age"] = 29,
                        ["isMan"] = true,
                        ["isSingle"] = true,
                        ["salary"] = 4200
                        },
                        new Dictionary<string, dynamic>(){
                        ["name"] = "ls",
                        ["age"] = 20,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 3400
                        },
                        new Dictionary<string, dynamic>(){
                        ["name"] = "ww",
                        ["age"] = 19,
                        ["isMan"] = true,
                        ["isSingle"] = false,
                        ["salary"] = 6000
                        },
                        new Dictionary<string, dynamic>(){
                        ["name"] = "zl",
                        ["age"] = 14,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 2000
                        },
                        new Dictionary<string, dynamic>(){
                        ["name"] = "sq",
                        ["age"] = 35,
                        ["isMan"] = true,
                        ["isSingle"] = false,
                        ["salary"] = 7000
                        },
                        new Dictionary<string, dynamic>(){
                        ["name"] = "zb",
                        ["age"] = 27,
                        ["isMan"] = false,
                        ["isSingle"] = true,
                        ["salary"] = 2900
                        },
                        };
            // 作业1
            // Find: 要求查找年龄小于20的
            //var res = list.Find (item =>
            //{
            //    return item["age"] < 20;


            //});

            //Console.WriteLine($"{res["name"]}-{res["age"]}");



            // FindLast: 要求查找年龄大于25的
            //var res = list.FindLast(item =>
            //{

            //    return item["age"] > 25;

            //}
            //);
            //Console.WriteLine($"{res["name"]}-{res["age"]}");

            // FindAll: 找出性别男的
            //var res = list.FindAll(item=>{
            //    return item["isMan"] ;

            //});
            //Console.WriteLine(JsonSerializer.Serialize (res));


            // FindIndex: 找出薪水大于5000
            //var res = list.FindIndex(item=>{
            //    return item["salary"] > 5000;
            //});
            //Console.WriteLine(res);

            // FindLastIndex: 找出薪水小于3000

            //var res = list.FindLastIndex(item => item["salary"]<3000);
            //Console.WriteLine(res);
            // Exists: 判断是否有薪水大于5000
            //bool res = list.Exists(item => item["salary"] > 5000);
            //Console.WriteLine(res);

            // ForEach: 输出每个的 名字-年龄-薪水
            //list.ForEach(item=>{
            //    Console.WriteLine($"{item["name"]}-{item["age"]}-{item["salary"]}");

            //});

            // ConvertAll: 映射得到一个所以薪水的list
            //List<dynamic> newlist = list.ConvertAll(item=>{
            //    return item["salary"];

            //});
            //Console.WriteLine(string.Join(",",newlist));
            //TrueForAll: 判断是否都成年

            //var res = list.TrueForAll(item => item["age"]>18);
            //Console.WriteLine(res);

            //作业2    封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数

            Dictionary<char, int> Count(string s)
            {
                var result = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if (result.ContainsKey(c))
                        result[c]++;
                    else
                        result[c] = 1;
                }
                return result;
              
            }
            
            var n = Count("abbccdd");
                foreach (var item in n)
                {
                Console.WriteLine($"字符;{item.Key} 出现次数：{item.Value}");
                }










        }
    }
}
