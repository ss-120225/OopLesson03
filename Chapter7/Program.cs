using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var employeeDict = new Dictionary<int, Employee>()
            //{
            //    {100,new Employee(100,"清水遼久") },
            //    {112,new Employee(112,"芹沢洋和") },
            //    {125,new Employee(125,"岩瀬奈央子") },
            //};

            //var emp = employeeDict.Where(x => x.Value.Id % 2 == 0);
            //foreach (var item in emp)
            //{
            //    Console.WriteLine(item.Value.Name);
            //}

            ////リスト
            //var employee = new List<Employee>()
            //{
            //    new Employee(100,"清水遼久"),
            //    new Employee(112,"芹沢洋和"),
            //    new Employee(125,"岩瀬奈央子"),
            //    new Employee(143,"山田太郎"),
            //    new Employee(148,"池田次郎"),
            //    new Employee(152,"高田三郎"),
            //    new Employee(155,"石川幸也"),
            //    new Employee(161,"中沢信也"),
            //};

            //// Idが偶数のみディクショナリに変換する
            //var employeeDict = employee.Where(x=>x.Id % 2 == 0).ToDictionary(emp => emp.Id);

            //foreach (KeyValuePair<int, Employee> item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value.Name}");
            //}
            #endregion
            #region
            ////ディクショナリ
            //var dict = new Dictionary<MonthDay, string>()
            //{
            //    {new MonthDay(3,5),"珊瑚の日" },
            //    {new MonthDay(8,4),"箸の日" },
            //    {new MonthDay(10,3),"登山の日" },
            //};

            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);
            #endregion
            #region
            //var lines = File.ReadAllLines("sample.txt");
            //var we = new WordsExtractor(lines);
            //foreach (var item in we.Extract())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion        

            //DuplicateKeySample();

            Console.WriteLine("*****7.1.1*****");
            string text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1_1(text);
        }

        static void Exercise1_1(string text)
        {
            //var dict = new Dictionary<char, int>();
            var dict = new SortedDictionary<char, int>();
            foreach (var item in text)
            {                
                var ch = char.ToUpper(item);

                if ('A' <= ch && ch <= 'Z')
                    if (dict.ContainsKey(ch))
                        dict[ch]++;
                    else
                        dict[ch] = 1;                       
            }
            
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            
        }
        #region
        //static public void DuplicateKeySample()
        //{
        //    Console.WriteLine("***************\n**辞書登録**\n***************");

        //    // ディクショナリの初期化
        //    var dict = new Dictionary<string, List<string>>();

        //    do
        //    {
        //        Console.Write("\n1. 登録　　2. 表示     3.終了\n数値を入力してください：");
        //        int.TryParse(Console.ReadLine(), out int flag);
        //        if (flag == 0)
        //            break;
        //        if (flag == 1)
        //        {
        //            // ディクショナリに追加
        //            Console.Write("Keyを入力:");
        //            var key = Console.ReadLine();
        //            Console.Write("Valueを入力:");
        //            var value = Console.ReadLine();
        //            if (dict.ContainsKey(key))
        //            {
        //                dict[key].Add(value);
        //            }
        //            else
        //            {
        //                dict[key] = new List<string> { value };
        //            }
        //            Console.WriteLine($"登録しました!");
        //        }
        //        else if (flag == 2)
        //        {
        //            if (dict.Count == 0)
        //            {
        //                Console.WriteLine("表示するものがありません\n");
        //                break;
        //            }
        //            foreach (var item in dict)
        //            {
        //                foreach (var term in item.Value)
        //                {
        //                    Console.WriteLine("{0} : {1}", item.Key, term);
        //                }
        //            }
        //        }
        //        else if( flag == 3)
        //        {
        //            break;
        //        }
        //    } while (true);
        //}
        #endregion
    }
}
