using System.Net.Http.Headers;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("输入年龄：");
            //int age=int.Parse (Console.ReadLine());
            //bool res = age > 16 && age < 22;
            //Console.WriteLine(res);

            //Console.WriteLine("输入年龄：");
            //int age = int.Parse(Console.ReadLine());
            //bool res = !(age < 16 || age > 22);
            //Console.WriteLine(res);



            //Console.WriteLine("输入资产：");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("输入颜值：");
            //double yz = double .Parse(Console.ReadLine());
            //bool res = money > 300 || yz > 9.5;
            //Console.WriteLine(res);



            //Console.WriteLine("输入年份：");
            //int year=int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0||year%400==0)
            //{

            //    Console.WriteLine($"闰年：{year}");
            //}
            //else
            //{
            //    Console.WriteLine($"不是闰年：{year}");

            //}

            //Console.WriteLine("输入成绩：");
            //int score=int .Parse(Console.ReadLine());
            //if (score < 60)
            //{
            //    Console.WriteLine("不及格");
            //}
            //else if (score < 80)
            //{
            //    Console.WriteLine("及格");

            //}
            //else if (score < 90)
            //{
            //    Console.WriteLine("良好");
            //}
            //else if (score <= 100) { Console.WriteLine("优秀"); }
            //else {
            //    Console.WriteLine("重新输入：");

            //}

            //Console.WriteLine("输入1——7");
            //int day=int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: Console.WriteLine("星期六"); break;
            //    case 7: Console.WriteLine("星期天"); break;
            //    default: Console.WriteLine("输入错误");break;
            //}
            //穿透写法

            //Console.WriteLine("输入1——7");
            //int day=int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6:
            //    case 7: Console.WriteLine("周末"); break;
            //    default: Console.WriteLine("输入错误");break;
            //}




            //Console.WriteLine("输入分数");
            //int score = int.Parse(Console.ReadLine());
            //int n = score / 10;
            ////Console.WriteLine(n);
            //switch (n)
            //{
            //    case 1: Console.WriteLine($"{score}等级是F级");break;
            //    case 2: Console.WriteLine($"{score}等级是F级");break;
            //    case 3: Console.WriteLine($"{score}等级是F级");break;
            //    case 4: Console.WriteLine($"{score}等级是F级");break;
            //    case 5: Console.WriteLine($"{score}等级是F级");break;
            //    case 6: Console.WriteLine($"{score}等级是D级");break;
            //    case 7: Console.WriteLine($"{score}等级是C级");break;
            //    case 8: Console.WriteLine($"{score}等级是B级");break;
            //    case 9: Console.WriteLine($"{score}等级是A级");break;
            //    case 10: Console.WriteLine($"{score}等级是A级");break;
            //        default: Console.WriteLine("输入错误");break;

            //}
            //穿透
            //Console.WriteLine("输入分数");
            //int score = int.Parse(Console.ReadLine());
            //int n = score / 10;
            ////Console.WriteLine(n);
            //switch (n)
            //{
            //    case 1: 
            //    case 2: 
            //    case 3:
            //    case 4: 
            //    case 5: 
            //    case 6: Console.WriteLine($"{score}等级是D级");break;
            //    case 7: Console.WriteLine($"{score}等级是C级");break;
            //    case 8: Console.WriteLine($"{score}等级是B级");break;
            //    case 9: Console.WriteLine($"{score}等级是A级");break;
            //    case 10: Console.WriteLine($"{score}等级是A级");break;
            //        default: Console.WriteLine("输入错误");break;

            //}
            //switch简写

            //Console.WriteLine("输入成绩：");
            //int score=int .Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    string res = score switch
            //    {
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"                };
            //    Console.WriteLine(res );

            //}
            //else {
            //    Console.WriteLine("输入有误");

            //}

            //三元判断是否成年
            // Console.WriteLine( "输入年龄：");
            // int age=int.Parse( Console.ReadLine() );
            //string a=( age >= 18 ? "成年了" : "未成年");
            // Console.WriteLine(a);

            //三元判断闰年
            //Console.WriteLine("输入年份：");
            //int year=int .Parse(Console.ReadLine());
            //string a = year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? "闰年" : "平年";
            //Console.WriteLine(a);
            //案例
            //案例1奇数偶数判断
            //Console.WriteLine("输入一个数字");
            //int n = int.Parse(Console.ReadLine());
            //if (n%2==0) Console.WriteLine($"{n}是偶数");
            //else Console.WriteLine($"{n}是奇数");
            //三元
            //string s=n%2==0?"偶数":"奇数";
            //Console.WriteLine(s);


            //案例2是否在线
            //int n = 2;
            //Console.WriteLine(n == 1 ? "在线" : "离线");

            //案例3文件大小单位不同（1024以下kb/以上MB）
            //Console.WriteLine("输入大小");
            //int m =int .Parse(Console.ReadLine());
            //if (m >= 1024) Console.WriteLine($"{m/1024}MB");
            //else Console.WriteLine($"{m}KB");
            //三元
            //string res=m>=1024?(m/1024+"MB"):(m + "KB");
            //Console.WriteLine(res);
            //案例4数学运算计算器
            //Console.WriteLine("请输入第一个数字");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入运算符(+ - * /)");
            //string opt = Console.ReadLine();

            //switch (opt)
            //{
            //    case "+":
            //        Console.WriteLine($"n1{opt}n2 = {n1 + n2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"n1{opt}n2 = {n1 - n2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"n1{opt}n2 = {n1 * n2}");
            //        break;
            //    case "/":
            //        if (n2 == 0) Console.WriteLine("除数不能为0");
            //        else Console.WriteLine($"n1{opt}n2 = {n1 / n2}");
            //        break;
            //    default:
            //        Console.WriteLine("输入运算符有误");
            //        break;
            //}
            //案例5不同血型不同性格
            //Console.WriteLine("请输入你的血型");
            //string s = Console.ReadLine();
            //string res = s switch
            //{
            //    "A" => "细心稳重",
            //    "B" => "乐观自由",
            //    "AB" => "思维多变",
            //    "O" => "热情外向",
            //    _ => "输入有误"
            //};
            //Console.WriteLine(res);





        }
    }
}