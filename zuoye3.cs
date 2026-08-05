using System.ComponentModel;
using System.Security.Principal;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1
            //账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            //        Console.WriteLine("输入账号：");
            //      string  account=Console .ReadLine();
            //        Console.WriteLine("输入密码：");
            //        string passward = Console.ReadLine();
            //        //string account0 = "admin";
            //        //string  passward0 = "123456";
            //        if (account == "admin")
            //        { 
            //            if (passward == "123456")
            //            {
            //                Console.WriteLine("登入成功");
            //            }
            //            else
            //            {
            //                Console.WriteLine("密码错误");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("账号错误");
            //        }



            //作业2
            //选择菜单（add/edit/del）执行操作（练习多分支和switch）：提示用户选择菜单（add/edit/del），判断输入的是add，就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
            //Console.WriteLine("选择菜单 add/edit/del");
            //string type = Console.ReadLine();
            //string res = type switch
            //{
            //    "add" => "新增成功",
            //    "edit" => "编辑成功",
            //    "del" => "删除成功",
            //    _ => "输入错误"
            //};
            //Console.WriteLine(res);



            //作业3
            //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP/USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            //Console.WriteLine("输入类型 VIP/USER");
            //string type=Console .ReadLine();
            //Console.WriteLine("输入消费金额");
            //int money=int .Parse(Console.ReadLine());
            //if (type == "VIP")
            //{
            //    if (money >= 1000) Console.WriteLine($"消费金额：{money * 0.9}");
            //    else Console.WriteLine($"消费金额：{money}");
            //}
            //else
            //{
            //    if (money >= 2000) Console.WriteLine($"消费金额：{money * 9.5}");
            //    else Console.WriteLine($"消费金额：{money}");

            //}


            //作业4
            //通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
            //Console.WriteLine("输入月份：");
            //int month=int .Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 3: 
            //    case 4: 
            //    case 5: Console.WriteLine("春");break;
            //    case 6: 
            //    case 7: 
            //    case 8: Console.WriteLine("夏");break;
            //    case 9: 
            //    case 10: 
            //    case 11: Console.WriteLine("秋");break;
            //    case 12: 
            //    case 1: 
            //    case 2: Console.WriteLine("冬");break;
            //    default : Console.WriteLine("月份错误");break;
            //}


            //作业5
            //快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
            //Console.WriteLine("输入快递重量：");
            //double weight=double .Parse(Console.ReadLine());
            //string w = weight switch
            //{ 
            //<=1=>"快递费10元",
            //<=5=>"快递费20元",
            //>5=>"快递费50元",
            //};
            //Console.WriteLine(w);



            //作业6
            //会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。

            //Console.WriteLine("输入会员等级：");
            //int n=int.Parse(Console.ReadLine());
            //string m = n switch
            //{
            //5=>"终身免运费",
            //4=> "每月可领优惠券",
            //3=> "购物打9折",
            //_=> "没有福利",
            //};
            //Console.WriteLine(m);


            //作业7
            //自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。

            //Console.WriteLine("输入商品编号整数：");
            //int n=int.Parse(Console.ReadLine());
            //string m = n switch
            //{
            //1=>"已购买可乐",
            //2=>"已购买雪碧",
            //3=>"已购买矿泉水",
            //_=>"无此商品",

            //};
            //Console.WriteLine(m);


            //作业8
            //速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
            //Console.WriteLine("输入当前速度：");
            //int n=int.Parse(Console.ReadLine());
            //if(n>0&&n<=30) Console.WriteLine("低速通过");
            //else if(n>30&&n<=60) Console.WriteLine("中速通过");
            //else if(n>60&&n<=100) Console.WriteLine("高速通过");
            //else if(n>100&&n<=120) Console.WriteLine("超速通过");
            //else Console.WriteLine("输入错误");

            //Console.WriteLine("输入当前速度：");
            //int n = int.Parse(Console.ReadLine());
            //string m = n switch
            //{
            //    <=30 => "低速通过",
            //    <=60 => "中速通过",
            //    <=100 => "高速通过",
            //    <=120 => "超速通过",
            //    _ => "输入错误",


            //};
            //Console.WriteLine(m);


        }
    }
}
