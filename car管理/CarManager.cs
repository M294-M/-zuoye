using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class CarManager
    {
        //定义属性，路径和JSON
        //定义车辆的方法
        private string Path { get; } = "./car.json";//定义成私有类型，属性的赋值器直接赋值
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,//保证在序列化是中文不变
        };
        public void Add() {

            Console.WriteLine("请输入车牌号：");
            string Card = Console.ReadLine();
            Console.WriteLine("请输入车类型：");
            string Type = Console.ReadLine();
            Console.WriteLine("请输入时租费：");
            double Price = double.Parse(Console.ReadLine());

            List<ProjectClass> list = new();
            //判断文件是否存在，存在时读取，反序列化，
            if (File.Exists(Path))
            {
                var json = File.ReadAllText(Path);
                //不再使用字典，字典存储反序列化后得到的数据（dynamic）是json格式的数据，建立一个新类，使用对象
                list = JsonSerializer.Deserialize<List<ProjectClass>>(json);
                if (list.Exists(item => item.Card == Card))
                {
                    Console.WriteLine("车牌号已存在，重新输入");
                    return;
                }

            }

            var PC = new ProjectClass(list.Count + 1, Card, Type, true, Price);
            list.Add(PC);
            string resStr = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(Path, resStr);
            Console.WriteLine("新增成功");
        }

        public void SearchAll()
        {
            //同样判断文件是否存在
            //存在读取，反序列化，遍历输出

            if (!File.Exists(Path))
            {
                Console.WriteLine("车辆不存在，请先添加");
                return;
            }
            List<ProjectClass> list = new();
            var json = File.ReadAllText(Path);
            //不再使用字典，字典存储反序列化后得到的数据（dynamic）是json格式的数据，建立一个新类，使用对象
            list = JsonSerializer.Deserialize<List<ProjectClass>>(json);
            foreach (var item in list)
            {
                string statusStr = item.Status ? "空闲" : "已出租";//将true false 转成中文
                Console.WriteLine($"id : {item.Id} -- 车牌 : {item.Card} -- 类型 : {item.Type} -- 状态 : {statusStr} -- 时租费 : {item.Price} ");
            }


        }

        public void SearchOne(int id) {
            if (!File.Exists(Path))
            {
                Console.WriteLine("车辆不存在，请先添加");
                return;
            }
            List<ProjectClass> list = new();
            var json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<ProjectClass>>(json);
            var listopt = list.Find(item => item.Id == id);
            if (listopt == null)
            {
                Console.WriteLine("没有车辆，请先添加");
                return;
            }

            string statusStr = listopt.Status ? "空闲" : "已出租";//将true false 转成中文
            Console.WriteLine($"id : {listopt.Id} -- 车牌 : {listopt.Card} -- 类型 : {listopt.Type} -- 状态 : {statusStr} -- 时租费 : {listopt.Price} ");



        }

        public void Searchfree()
        {
            if (!File.Exists(Path))
            {
                Console.WriteLine("车辆不存在，请先添加");
                return;
            }
            List<ProjectClass> list = new();
            var json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<ProjectClass>>(json);
            var allcar = list.FindAll(item => item.Status);
            if (allcar.Count == 0)
            {
                Console.WriteLine("无空闲车辆，请先添加");
                return; 
            }
            foreach (var item in allcar)
            {
                Console.WriteLine($"id : {item.Id} -- 车牌 : {item.Card} -- 类型 : {item.Type} -- 时租费 : {item.Price} ");
            }
        }
        // 根据id修改车辆状态 方法
        // 返回多个值 元组  第一个是提示信息，第二个是成功与否的状态
        public (string, bool) UpdateStatus(int id)
        {
            // 不存在====》没有车辆信息，请先添加
            if (!File.Exists(this.Path)) return ("暂无车辆！！！", false);
            // 判断文件是否存在===存在，读取文件，反序列化 ===》根据id查找车辆对象===》找不到则提示
            string jsonStr = File.ReadAllText(this.Path);
            List<ProjectClass> cars = JsonSerializer.Deserialize<List<ProjectClass>>(jsonStr);
            // 使用列表的Find 实现查找
            ProjectClass carObj = cars.Find(item => item.Id == id);
            if (carObj == null) return ("没有对应ID的车辆！！！", false);
            if (!carObj.Status) return ("该车辆已被租出！！！", false);
            // 修改车辆状态
            carObj.Status = false;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);
            return ("租车成功！！！", true);
        }

        // 修改状态并获取 时租费
        public double UpAndGetInfo(int id)
        {
            // 读文件---》 反序列化 ---》车辆列表 ---》根据id查找---》修改状态 并获取数据返回
            string jsonStr = File.ReadAllText(this.Path);
            List<ProjectClass> cars = JsonSerializer.Deserialize<List<ProjectClass>>(jsonStr);

            ProjectClass carObj = cars.Find(item => item.Id == id);

            // 修改车辆状态
            carObj.Status = true;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);

            return carObj.Price;
        }


    }
}
