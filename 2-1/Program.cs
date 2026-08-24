namespace pragram3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num = "";// 输入的操作编号
            Employee EP = new Employee();
            while (num != "6")
            {
                Tips();  // 提示界面
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("1：新增员工");
                        EP.Add();
                        break;
                    case "2":
                        Console.WriteLine("2：查看全部员工");
                        EP.SearchAll();
                        break;
                    case "3":
                        Console.WriteLine("3：根据编号调整薪资");
                        EP.SearchOne();
                        break;
                    case "4":
                        Console.WriteLine("4：根据编号删除员工");
                        EP.Remove();
                        
                        break;
                    case "5":
                        Console.WriteLine("5：根据薪资条件筛选员工");
                        EP.SearchFind();
                        break;
                    case "6":
                        Console.WriteLine("6：退出系统");
                        break;
                    default:
                        Console.WriteLine("输入有误，请重新输入");
                        break;




                }





            }


        }
        static void Tips()
        {
            // 提示界面
            Console.WriteLine("==员工薪资管理控制台系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("1：新增员工");
            Console.WriteLine("2：查看全部员工");
            Console.WriteLine("3：根据编号调整薪资");
            Console.WriteLine("4：根据编号删除员工");
            Console.WriteLine("5：根据薪资条件筛选员工");
            Console.WriteLine("6：退出系统");
           
            
        }
    }
}
