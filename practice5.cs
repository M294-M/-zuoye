namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习
            //Dictionary<string, dynamic> dic = new() 
            //{ 
            //    ["name"] = "张三",
            //    ["age"] = 12
            //};
            //add增加键值对
            //dic.Add("height",180);
            //Console.WriteLine(dic.Count);
            //foreach (dynamic obj in dic) { Console.WriteLine(obj); }

            //ContainsKey / ContainsValue  判断键或值是否存在
            //Console.WriteLine(dic.ContainsKey("name")); // True
            //Console.WriteLine(dic.ContainsKey("gender")); // False
            //Console.WriteLine(dic.ContainsValue("张三")); // True
            //Console.WriteLine(dic.ContainsValue("李四")); // False

            //Remove通过指定的键将键值对从字典中删除
            //dic.Remove ("height");
            //foreach (var item in dic) { Console.WriteLine(item); }

            // Keys获取字典中所有键的集合
            //var dicKyes = dic.Keys;  
            ////Console.WriteLine(dicKyes);
            ////string[] keyArr = dicKyes.ToArray(); // 将键集合转为数组
            ////foreach (string key in keyArr) Console.WriteLine(key);
            //List<string> keylist = dicKyes.ToList(); // 将键集合转为list集
            //foreach (string key in keylist) Console.WriteLine(key);

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    for (int j = ints.Count-1 ; j >i; j--)
            //    {
            //        if (ints[i] == ints[j])
            //        {
            //            ints.RemoveAt(j);
            //            //j--;
            //        }


            //    }




            //}
            //foreach (int n in ints) Console.WriteLine(n);

            //思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            //for (int i = 0; i < ints.Count; i++)
            //{while (true)
            //    {
            //        int index = ints.LastIndexOf(ints[i]);
            //        if (ints.LastIndexOf(ints[i]) != i)
            //        {
            //            ints.RemoveAt(index );

            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}foreach (int n in ints) Console.WriteLine(n);

            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            //Dictionary<int, dynamic> tmpdic = new();
            //foreach (int n in ints)
            //{

            //    tmpdic[n] = "m";


            //}
            //List<int> ints2 = tmpdic.Keys.ToList();
            //foreach (int a in ints2) Console.WriteLine(a);
            //思路4：创建一个新的List，遍历原本的List，原本List中的每一个元素，放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加

            //List<int > newlist = new();
            //foreach (int n in ints)
            //{
            //    if (!newlist.Contains(n))
            //    {
            //        newlist.Add(n);

            //    }

            //}foreach (int m in newlist) Console.WriteLine( m);

            // 概念：让每相邻的两个元素比较大小，如果不满足顺序，就交换他俩的位置

            //List<int> ints  = [5,3,4,6,7,8,9,1,2];
            //for (int j = 0; j < ints.Count-1; j++)//j<ints.count-1是因为最后的1不用再运行
            //{
            //    for (int i = 0; i < ints.Count - 1-j; i++)//减少运行次数
            //        if (ints[i] > ints[i + 1])
            //        {
            //            int tmp = 0;
            //            tmp = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = tmp;

            //        }
            //}
            //foreach (int n in ints) Console.WriteLine(n);

            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"name", "机械键盘"},
        {"price", 299.99},
        {"code", "G001"},
        {"stock", 120}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "无线鼠标"},
        {"price", 89.50},
        {"code", "G002"},
        {"stock", 356}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "27寸显示器"},
        {"price", 1299.00},
        {"code", "G003"},
        {"stock", 48}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "电竞耳机"},
        {"price", 199.00},
        {"code", "G004"},
        {"stock", 85}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "电脑支架"},
        {"price", 69.90},
        {"code", "G005"},
        {"stock", 210}
    }
};
            Console.WriteLine("请输入排序类型：price/stock");
            string n = Console.ReadLine();
            Console.WriteLine("请输入排序顺序： ASC/DSC");
            string m=Console .ReadLine();
            if (n == "price")
            {
                if (m == "ASC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                            if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                            {
                                dynamic tmp = 0;
                                tmp = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tmp;

                            }
                    }
                    foreach (dynamic k in goodsList)
                        Console.WriteLine($"{k["name"]}--{k["price"]}");

                }
                else {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                            if (goodsList[i]["price"] < goodsList[i + 1]["price"])
                            {
                                dynamic tmp = 0;
                                tmp = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tmp;

                            }
                    }
                    foreach (dynamic k in goodsList)
                        Console.WriteLine($"{k["name"]}--{k["price"]}");




                }


            }
            else
            {
                if (m == "ASC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                            if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
                            {
                                dynamic tmp = 0;
                                tmp = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tmp;

                            }
                    }
                    foreach (dynamic k in goodsList)
                        Console.WriteLine($"{k["name"]}--{k["stock"]}");


                }
                else {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                            if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
                            {
                                dynamic tmp = 0;
                                tmp = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tmp;

                            }
                    }
                    foreach (dynamic k in goodsList)
                        Console.WriteLine($"{k["name"]}--{k["stock"]}");

                }

            }




        }
    }
}
