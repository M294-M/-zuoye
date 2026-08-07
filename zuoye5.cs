namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业1   // 提示输入的 是price还是stock  排序类型 
            // 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            // 根据输入完成数据排序

            //            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘"},
            //        {"price", 299.99},
            //        {"code", "G001"},
            //        {"stock", 120}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标"},
            //        {"price", 89.50},
            //        {"code", "G002"},
            //        {"stock", 356}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器"},
            //        {"price", 1299.00},
            //        {"code", "G003"},
            //        {"stock", 48}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机"},
            //        {"price", 199.00},
            //        {"code", "G004"},
            //        {"stock", 85}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架"},
            //        {"price", 69.90},
            //        {"code", "G005"},
            //        {"stock", 210}
            //    }
            //};
            //            Console.WriteLine("请输入排序类型：price/stock");
            //            string n = Console.ReadLine();
            //            Console.WriteLine("请输入排序顺序： ASC/DSC");
            //            string m = Console.ReadLine();
            //            if (n == "price")
            //            {
            //                if (m == "ASC")
            //                {
            //                    for (int j = 0; j < goodsList.Count - 1; j++)
            //                    {
            //                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                            if (goodsList[i]["price"] > goodsList[i + 1]["price"])
            //                            {
            //                                dynamic tmp = 0;
            //                                tmp = goodsList[i];
            //                                goodsList[i] = goodsList[i + 1];
            //                                goodsList[i + 1] = tmp;

            //                            }
            //                    }
            //                    foreach (dynamic k in goodsList)
            //                        Console.WriteLine($"{k["name"]}--{k["price"]}");

            //                }
            //                else
            //                {
            //                    for (int j = 0; j < goodsList.Count - 1; j++)
            //                    {
            //                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                            if (goodsList[i]["price"] < goodsList[i + 1]["price"])
            //                            {
            //                                dynamic tmp = 0;
            //                                tmp = goodsList[i];
            //                                goodsList[i] = goodsList[i + 1];
            //                                goodsList[i + 1] = tmp;

            //                            }
            //                    }
            //                    foreach (dynamic k in goodsList)
            //                        Console.WriteLine($"{k["name"]}--{k["price"]}");




            //                }


            //            }
            //            else
            //            {
            //                if (m == "ASC")
            //                {
            //                    for (int j = 0; j < goodsList.Count - 1; j++)
            //                    {
            //                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                            if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
            //                            {
            //                                dynamic tmp = 0;
            //                                tmp = goodsList[i];
            //                                goodsList[i] = goodsList[i + 1];
            //                                goodsList[i + 1] = tmp;

            //                            }
            //                    }
            //                    foreach (dynamic k in goodsList)
            //                        Console.WriteLine($"{k["name"]}--{k["stock"]}");


            //                }
            //                else
            //                {
            //                    for (int j = 0; j < goodsList.Count - 1; j++)
            //                    {
            //                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                            if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
            //                            {
            //                                dynamic tmp = 0;
            //                                tmp = goodsList[i];
            //                                goodsList[i] = goodsList[i + 1];
            //                                goodsList[i + 1] = tmp;

            //                            }
            //                    }
            //                    foreach (dynamic k in goodsList)
            //                        Console.WriteLine($"{k["name"]}--{k["stock"]}");

            //                }

            //            }

            //作业2   通过歌曲查找歌手
            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"singerId", 1001},
        {"singerName", "周杰伦"},
        {"genre", "流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1002},
        {"singerName", "林俊杰"},
        {"genre", "华语流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1003},
        {"singerName", "邓紫棋"},
        {"genre", "流行、摇滚"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1004},
        {"singerName", "薛之谦"},
        {"genre", "抒情流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1005},
        {"singerName", "毛不易"},
        {"genre", "民谣流行"}
    }
};

            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"songId", 10001},
        {"singerId", 1001},
        {"songName", "青花瓷"},
        {"duration", 239}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 10002},
        {"singerId", 1001},
        {"songName", "发如雪"},
        {"duration", 253}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 10003},
        {"singerId", 1001},
        {"songName", "东风破"},
        {"duration", 215}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 1004},
        {"singerId", 3002},
        {"songName", "不为谁而作的歌"},
        {"duration", 296}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 1005},
        {"singerId", 1002},
        {"songName", "背对背拥抱"},
        {"duration", 262}
    }
};
            Console.WriteLine("输入歌曲名称：");
            string song = Console.ReadLine();
            int singerId = 0;
            foreach (Dictionary<string, dynamic> item in songList)
            {
                if (item["songName"] == song)
                    singerId = item["singerId"];
            
            }
            foreach (Dictionary<string, dynamic> item2 in singerList)
            {
                if (item2["singerId"] == singerId) {

                    Console.WriteLine(item2["singerName"]);
                
                };
                
            }

           // Console.WriteLine("singerName");
        }
    }
}
