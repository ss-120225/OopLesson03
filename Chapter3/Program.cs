using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>
            //{
            //    12, 87, 94, 14, 50, 20, 40, 35, 76, 91, 31, 17, 48
            //};


            //numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            //var number = numbers.Exists(s => (s % 8 == 0) || (s % 9 == 0));

            //Console.WriteLine(number);

            //numbers.ForEach(s =>Console.WriteLine(s/2.0));

            //var number = numbers.Where(s => s >= 50);

            //foreach (var s in number)
            //{
            //    Console.WriteLine(s);
            //}

            //List<int> number = numbers.Select(s => s * 2).ToList();

            //foreach (var s in number)
            //{
            //    Console.WriteLine(s);
            //}

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            #region 3-2-1
            //var line = Console.ReadLine();
            //var check = names.FindIndex(n => n == line.ToString());
            //if (check != null)
            //    Console.WriteLine(check);
            //else
            //    Console.WriteLine(-1);

            ////do whileでの書き方
            //do
            //{
            //    var line = Console.ReadLine();
            //    if(string.IsNullOrEmpty(line))
            //    {
            //        break;
            //    }
            //    var index = names.FindIndex(s => s == line);
            //    Console.WriteLine(index);
            //} while (true);
            #endregion
            #region 3-2-2
            //var name = names.Count(x => x.Contains('o'));
            //Console.WriteLine(name);
            #endregion
            #region 3-2-3
            //var name = names.Where(x => x.Contains('o')).ToArray();

            //foreach (var s in name)
            //{
            //    Console.WriteLine(s);
            //}            
            #endregion
            #region 3-2-4
            //var name = names.Select(x => x).Where(x => x[0] == 'B');
            var name = names.Where(x => x.StartsWith("B")).Select(x => x.Length);
            foreach (var s in name)
            {                
                Console.WriteLine(s);
            }
            #endregion
        }
    }
}
