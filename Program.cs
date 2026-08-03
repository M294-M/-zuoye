using System.Threading.Channels;

namespace ConsoleApp2
{
    internal   class Program
    {
         static void Main(string[] args)
        {


            Program1.job(args);//调用第二个类
            Main1 (args);//调用方法2

            //作业1
            //Console.WriteLine("输入数字1");
            //Console.WriteLine("输入数字2");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"和是：{num1 + num2}");



            //作业2
            //Console.WriteLine("当地华氏温度：");
            //double c = double.Parse(Console.ReadLine());
            //double c0 = 5 / 9.0 * (c - 32);
            //Console.WriteLine($"{c}华氏度");
            //double res = Math.Round(c0, 3);
            //Console.WriteLine($"{res}摄氏度");


            //作业3
            Console.WriteLine("输入第一个整型数字：");
            Console.WriteLine("输入第二个整型数字：");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3;
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine($"交换后：{num1}");
            Console.WriteLine($"交换后：{num2}");


            //作业四
            //Console.WriteLine("输入时间：");
            //double t =double.Parse(Console.ReadLine());
            //double h = t / 36;
            //double res = Math.Round(h, 2);
            //double m = t % 36;
            //Console.WriteLine($"天数：{res}天");
            //Console.WriteLine($"小时数：{m}小时");
        }
        static void Main1(string[] args)
        { 
            //作业2
            Console.WriteLine("当地华氏温度：");
            double c = double.Parse(Console.ReadLine());
            double c0 = 5 / 9.0 * (c - 32);
            Console.WriteLine($"{c}华氏度");
            double res = Math.Round(c0, 3);
            Console.WriteLine($"{res}摄氏度");
           
        }
        

    }
    public class Program1
    {
        public static void job(string[] args)
        {
            //作业1
            Console.WriteLine("输入数字1");
            Console.WriteLine("输入数字2");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"和是：{num1 + num2}");
        }
    }
}
