using System.Xml;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //车库管理系统
            //输入界面提示词（放在一个静态类中调用）
            //实例化3个类，车辆类，用户类，租借记录类
            //while循环进行功能，然后调用方法实现功能
           
           CarManager CM=new CarManager();
            UserManager UM=new UserManager();
            RentReturnClass RR=new RentReturnClass();
            string num = "";
           
            while (num != "0")
            {
                Tips();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("添加车辆");
                        CM.Add();
                        break;
                    case "2":
                        Console.WriteLine("查询所有车辆");
                        CM.SearchAll();
                        break;
                    case "3":
                        Console.WriteLine("查询一辆车");
                        Console.WriteLine("输入要查询车辆的ID");
                        int carid=int.Parse(Console.ReadLine());
                        CM.SearchOne(carid);
                        break;
                    case "4":
                        Console.WriteLine("查询所有空闲的车辆");
                        CM.Searchfree();
                        break;
                    case "5":
                        Console.WriteLine("新增客户");
                        UM.Useradd();

                        break;
                    case "6":
                        Console.WriteLine("查询所有用户信息");
                        UM.Searchuserall();
                        break;
                    case "7":
                        Console.WriteLine("查找某个用户");
                        Console.WriteLine("输入要查找用户的ID");
                        int userid=int.Parse(Console.ReadLine());
                        UM.Searchone(userid);
                        break;
                    case "8":
                        Console.WriteLine("租车");
                        RR.RentCar();
                        break;
                    case "9":
                        Console.WriteLine("还车");
                        RR.ReturnCar();
                        break;
                    case "10":
                        Console.WriteLine("查找所有租车记录");
                        RR.SearchAll();
                        break;
                    case "0":
                        Console.WriteLine("退出系统");
                        break;
                    default:
                        Console.WriteLine("输入有误");
                        break;













                }




            }

        }
        static void Tips()
        {
            Console.WriteLine("==欢迎来到租车系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：换车");
            Console.WriteLine("10：查看所有租车记录"); 
        
        
        }


    }
}
