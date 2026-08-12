namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1
            //Func<double ,double> area = (r) =>
            // {
            //     double money = 0;
            //     money = (2 * Math.PI * r) * 200;
            //     return money;

            // };
            // Console.WriteLine("输入半径r");
            // double m=double.Parse(Console.ReadLine());
            // Console.WriteLine(area(m));
            // double n = area(m)/2;
            // Console.WriteLine(n);

            //作业2  计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。

            //Func<string, char, int> count = (arr, i) =>
            //{
            //    int n = 0;
            //    foreach (char c in arr)
            //    {

            //        if (c == i)
            //            n++;

            //    };
            //    return n;

            //};
            //string arr = "qwerysssssqqqqwwweee";
            //int res = count(arr, 's');
            //Console.WriteLine(res);

            //作业3  . 计算一个整型数组中，最小值第一次出现的下标。
            //int[] arr = [10, 20, 5, 30, 50, 6, 7];

            //List<int> list = arr.ToList();
            //int a = 0;
            //int b=0;
            //for (int i = 0; i < list.Count-1; i++)
            //{

            //    if (list[i] > list[i+1])
            //    {
            //        a = list.IndexOf(i+1);
            //        b = i+1;
            //    }

            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //作业4 判断一个字符串是否为回文，返回布尔值类型。
            //string str = "abcdcba";
            //List<char> list = str.ToList();
            //bool m(List<char> list)
            //{

            //    for (int j = 0; j < list.Count - 1; j++)
            //    {
            //        if (list[j] == list[list.Count - j-1])
            //        {
            //            return true;
            //        }

            //    }
            //    return false;
            //}
            //Console.WriteLine(m(list));


            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0-100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！

            var guessnum = (int n) =>
            {
               
                //int count = 1;
                var random = new Random();
                var x = random.Next(0, 100);
                for (int i = 1; i <= 4; i++)
                {
                    if (n == x)
                    {
                        Console.WriteLine("WIN");
                        break;
                    }
                    else if (n > x) Console.WriteLine("偏大");
                    else if (n < x) Console.WriteLine("偏小");
                    Console.WriteLine("数字");
                    n = int.Parse(Console.ReadLine());
                    //count++;
                    if (i == 4)
                    {
                        Console.WriteLine("game over");
                        break;
                    }

                }

            };
            Console.WriteLine("数字");
            int m = int.Parse(Console.ReadLine());
            guessnum(m);



        }
    }
}
