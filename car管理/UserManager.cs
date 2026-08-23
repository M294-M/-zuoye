using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class UserManager
    {
        private string Path { get; } = "./user.json";//定义成私有类型，属性的赋值器直接赋值
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,//保证在序列化是中文不变
        };
        public void Useradd()
        {
            Console.WriteLine("请输入客户姓名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入身份证号：");
            string userCardId = Console.ReadLine();
            Console.WriteLine("请输入性别：");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入手机号：");
            string telNum = Console.ReadLine();
            Console.WriteLine("请输入座右铭：");
            string motto = Console.ReadLine();
            List<User> list = new();
            if (File.Exists(Path))
            {
                
                var json = File.ReadAllText(Path);
                list = JsonSerializer.Deserialize<List<User>>(json);
                if (list.Exists(item => item.IdCard == userCardId))
                {
                    Console.WriteLine("用户已存在");
                    return;

                }
            }
                int id = list.Count == 0 ? 1 : list[list.Count - 1].Id + 1;//得到id
                string regTime = DateTime.Now.ToString();
                var userObj = new User(id, userName, userCardId, regTime, gender, telNum, motto);
                list.Add(userObj);
                string resStr = JsonSerializer.Serialize(list, this.JsonOpt);
                File.WriteAllText(this.Path, resStr);
                Console.WriteLine("新增客户成功");
            
        }

        public void Searchuserall()
        {
            if (!File.Exists(Path))
            {
                Console.WriteLine("用户不存在");
                return;
            }
            List<User> list = new();
            var json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<User>>(json);
            list.ForEach(item => Console.WriteLine($"ID: {item.Id} -- 姓名: {item.Name} -- 身份证: {item.IdCard} -- 性别: {item.Gender} -- 手机号: {item.PhoneNo} -- 座右铭: {item.Motto} "));



        }


        public bool Searchone(int id)
        {
            // 判断存储数据的文件是否存在
            // 文件不存在---提示
            if (!File.Exists(this.Path)) return false;

            // 文件存在===>读文件 ---> 反序列化 List<User>  list            
            string jsonStr = File.ReadAllText(this.Path);
            List<User> list = JsonSerializer.Deserialize<List<User>>(jsonStr);
            // 根据ID查找客户对象===》找不到 ----->提示
            User userObj = list.Find(item => item.Id == id);
            if (userObj == null) return false;
            return true;
        }




    }
}
