using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pragram3
{
    internal class Employee
    {

        private int EmpId;
        private string EmpName;
        private string Department;
        private double Salary;
        public int _EmpId
        {
            get { return EmpId; }
            set { this.EmpId = value; }

        }
        public string _EmpName
        {
            get { return EmpName; }
            set { this.EmpName = value; }
        }

        public string _Department
        {
            get { return Department; }
            set { this.Department = value; }
        }

        public double _Salary
        {
            get { return Salary; }
            set { this.Salary = value; }
        }

        public Employee(int _EmpId, string _EmpName, string _Department, double _Salary)
        {
            this._EmpId = _EmpId;
            this._EmpName = _EmpName;
            this._Department = _Department;
            this._Salary = _Salary;
        }
        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号 : {this._EmpId} -- 名字 : {this._EmpName} -- 部门 : {this._Department} -- 薪水 : {this._Salary} ");
        }

        public Employee() { }
        private string Path { get; } = "./emp.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public void Add()
        {
            //员工信息
            Console.WriteLine("请输入员工编号");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入员工姓名");
            string EmpName = Console.ReadLine();
            Console.WriteLine("请输入员工所属部门");
            string Department = Console.ReadLine();
            Console.WriteLine("请输入员工薪资");
            double Salary = double.Parse(Console.ReadLine());

            //if (!Regex.IsMatch(EmpId, @"^[1-9]\d*$"))
            //{
            //    Console.WriteLine("员工编号输入有误");
            //    return;
            //}
            //if (!Regex.IsMatch(Salary, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
            //{
            //    Console.WriteLine("薪资输入有误");
            //    return;
            //}

            List<Employee> list = new();
            if (File.Exists(this.Path))
            {
                string jsonStr = File.ReadAllText(this.Path);
                list = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
                if (list.Exists(item => item.EmpId == EmpId))
                {
                    Console.WriteLine("员工已存在，请勿重复添加！");
                    return;
                }
            }
                Employee userObj = new Employee(EmpId, EmpName, Department, Salary);
                list.Add(userObj);
                string resStr = JsonSerializer.Serialize(list, this.JsonOpt);
                File.WriteAllText(this.Path, resStr);
                Console.WriteLine("新增员工成功");




        }
        

         public void SearchAll()
        {
            List<Employee> list = new();
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂无员工信息，请先添加");
                return;
            }
            
            string jsonStr = File.ReadAllText(this.Path);
             list = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            if (list.Count == 0)
            {
                Console.WriteLine("暂无员工数据");
                return;
            }

            foreach (Employee item in list)
            {

                item.ShowEmpInfo();
            }

        }

        public void SearchOne()
        {
            Console.WriteLine("请输入员工ID：");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入员工新薪资");
            double Salary = double.Parse(Console.ReadLine());

            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂无员工信息，请先添加");
                return;
            }
            
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(jsonStr);

            Employee userObj = list.Find(item => item.EmpId == userId);
            if (userObj == null)
            {
                Console.WriteLine("暂无该员工信息，请先添加");
                return;
            }
            userObj.Salary= Salary;
            string resStr = JsonSerializer.Serialize(list, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);
            Console.WriteLine("修改成功");


        }

        public void Remove()
        {
            Console.WriteLine("请输入要删除员工的ID");
            string  Empid=(Console.ReadLine());
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有该员工信息");
                return;
            }
           
            var json = File.ReadAllText(Path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(json);
            var index = list.FindIndex(item => item.EmpId.ToString() == Empid);

            if (index == -1)
            {
                Console.WriteLine("没有该员工信息"); 
            }
            list.RemoveAt(index);
            File.WriteAllText(this.Path, JsonSerializer.Serialize(list, this.JsonOpt));
            Console.WriteLine("删除成功");
        }

        public void SearchFind()
        {
            Console.WriteLine("请输入薪资数值");
            double salary = double.Parse(Console.ReadLine());
            // 不存在====》
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有员工信息，请先添加");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ===遍历输出
            string jsonStr = File.ReadAllText(this.Path);
            List<Employee> Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            // 查找  Employees  中 _Salary 大于 salary
            List<Employee> ResEmployees = Employees.FindAll(item => item._Salary > salary);
            if (ResEmployees.Count == 0)
            {
                Console.WriteLine("无对应薪资条件的员工");
                return;
            }

            foreach (Employee item in ResEmployees)
            {

                Console.WriteLine($"员工编号 : {item._EmpId} -- 名字 : {item._EmpName} -- 部门 : {item._Department} -- 薪水 : {item._Salary} ");
            }

        }


    }
}
