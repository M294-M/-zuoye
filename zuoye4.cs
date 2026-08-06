namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1   计算100以内偶数的和
            //方法1
            //int i = 1;
            //int sum = 0;
            //for (;i<=100 ;i++ ) 
            //{
            //    if (i % 2 == 0) 

            //   {
            //        sum += i;

            //    }

            //}
            //Console.WriteLine(sum);
            //方法2
            //int sum = 0;
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);

            //作业2   显示出1000-2000年中所有的闰年，并以每行四个数的形式输出

            //for (int i = 1000; i <= 2000; i++)
            //{
            //    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
            //    {
            //        for (int j = 1; j <= 4; j++)
            //        {
            //            Console.Write($"{i}  ");

            //        }

            //    }
            //    Console.WriteLine();

            //    }

            //作业3   输出一个倒三角形
            //for (int i = 9; i >=1 ; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    { Console.Write("*"); }
            //    Console.WriteLine();
            //}
            //

            //作业4
            //int n = 1;
            //double sum = 0.0;
            //double sum1 = 0.0;
            //for (; n <= 100; n++)
            //{
            //    if (n % 2 != 0)
            //     sum += 1.0/n;
            //    else sum1 -= 1.0/n;

            //}
            //Console.WriteLine($"{sum+sum1}");


            //作业5   求10以内所有数字的阶乘的和
            //int sum = 0;
            //int n = 1;
            //for (int j = 1; j <= 10; j++)
            //{
            //    n *= j;
            //    sum+= n; 


            //}
            //Console.WriteLine(sum);

            //作业6    篮球从5米高的地方掉下来，每次弹起的高度是原来的30%，经过几次弹起，篮球的高度小于0.1米。
            //double  i = 5.0;
            //int count = 0;
            //while(true)
            //{
            //    i = i * 0.3;
            //    count++;
            //    if(i<0.1)
            //    { break; }

            //}
            //Console.WriteLine(count);

            //作业7    有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //double  sum = 0;
            //int c = 1;
            //for (int i = 1; i <= 64; i++)
            //{
            //    sum += c;
            //    c = c * 2;

            //}  

            //    Console.WriteLine($"重量{sum*0.00001}kg");
            //作业8   某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5%，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？

            //double  i = 50000;
            //int count = 0;
            //while (i >= 5000)
            //{
            //    i = i - i * 0.05;
            //    count++;

            //}
            //Console.WriteLine(count);

            //作业9   猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            //int n = 1;
            //for (int i = 1; i <= 6; i++)
            //{  
            //    n = (n + 1) * 2;
            //}
            //Console.WriteLine(n);

            //作业10  有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
            //double h = 10;
            //double sum = 10;
            //for (int i = 0; i <= 9; i++)
            //{
            //    h /= 2;
            //    sum += h * 2;            
            //}
            //Console.WriteLine($"{sum}");















        }
    }
}
