using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.1
            //Console.WriteLine("--- 5.1 ---");
            //Console.WriteLine("文字列１");
            //var str1 = Console.ReadLine();
            //Console.WriteLine("文字列２");
            //var str2 = Console.ReadLine();
            //if (String.Compare(str1, str2, true) == 0)
            //    Console.WriteLine("一致している");
            //else
            //    Console.WriteLine("一致していない");
            //Console.WriteLine("");
            #endregion
            #region 5.2
            //Console.WriteLine("--- 5.2 ---");
            //Console.WriteLine("数値文字列:");
            //var str1 = Console.ReadLine();
            //int num1;
            //Console.WriteLine("数値文字列:");
            //var str2 = Console.ReadLine();
            //int num2;
            //int.TryParse(str1, out num1);
            //int.TryParse(str2, out num2);
            //Console.WriteLine(num1.ToString("#,0"));
            //Console.WriteLine(num2.ToString("#,0"));
            //Console.WriteLine("");
            #endregion
            #region 5.3
            Console.WriteLine("--- 5.3 ---");
            //string text = "Jackdaws love my big sphinx of quartz";
            //5.3.1
            //Console.WriteLine(text.Count(x => x == ' '));

            // 5.3.2
            //var replace = text.Replace("big", "small");
            //Console.WriteLine(replace);

            //5.3.3
            //Console.WriteLine(text.Split(' ').Count());            

            //5.3.4
            //var texts = text.Split(' ').Where(s => s.Length <= 4);
            //foreach (var item in texts)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine());

            //5.3.5
            //var texts = text.Split(' ').ToArray();
            //string s1 = "";
            //foreach (var item in texts)
            //{
            //    s1 += item + " ";
            //}
            //Console.WriteLine(s1);
            #endregion
            #region 5.4
            //5.4
            string str = "NoveList=谷崎潤一郎;BestWork=春琴;Born=1886";
            foreach (var item in str.Split(';'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
            }
            #endregion
        }
        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "NoveList":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "";
            }
        }
    }
}
