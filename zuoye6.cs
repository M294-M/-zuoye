using System.Text.RegularExpressions;
using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1   提取一句话中所有的中文姓名
            //string str = "hello, I am 刘德华,your name is 黎明?";
            //var name = @"[\u4e00-\u9fa5]{2,}";
            //var name1 = Regex.Matches(str, name);
            //foreach (var arg in name1) Console.WriteLine(arg);

            //作业2  替换所有多余空格

            //string str = "abc  dd  ee  ff  gg  HH  h j k";
            //var rule = @"[A-Za-z]";            
            //var arr=Regex.Matches(str,rule);
            //foreach (var item in arr) Console.Write(item);


            //作业3  身份证号码 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //var reg = @"([1-9]\d{5})(\d{4})(\d{2})(\d{2})(\d{3})([0-9Xx])";
            //var reg1 = Regex.Matches(str, reg);
            //foreach( Match reg2 in reg1)
            //{
            //    Console.WriteLine(reg2);
            //    Console.WriteLine($" 出生年是 {reg2.Groups[2].Value}");
            //    Console.WriteLine($" 出生月是 {reg2.Groups[3].Value}");
            //    Console.WriteLine($" 出生日是 {reg2.Groups[4].Value}");


            //}

            //作业4  密码强度检测：强中弱（字母、数字、特殊符号）
            // 请输入密码（字母、数字、特殊符号）
            //密码中可以有数字,字母,特殊符号;长度要求8~15
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强
            //验证密码长度是否符合,并输出密码强度
            Console.WriteLine("请输入密码：");
           string num=Console .ReadLine();
            if (num.Length < 8 || num.Length > 15)
                Console.WriteLine("密码长度错误，重新输入");
            else
            {
                int count = 0;
                var reg = @"\d";
                if (Regex.IsMatch(num, reg)) {
                    //Console.WriteLine("密码中有数字");
                    count++;
                }
                var reg1 = @"[a-zA-Z]";
                if (Regex.IsMatch(num, reg1))
                {
                   // Console.WriteLine("密码中有字母");
                    count++;
                }
                var reg2 = @"[^a-zA-Z0-9]";
                if (Regex.IsMatch(num, reg2))
                {
                   // Console.WriteLine("密码中有特殊符号");
                    count++;
                }
                if(count==1) Console.WriteLine("密码强度弱");
                if(count==2) Console.WriteLine("密码强度中");
                if(count==3) Console.WriteLine("密码强度强");


            }


        }
    }
}
