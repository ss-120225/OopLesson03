using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
             var dates = new YearMonth[] 
            {
            new YearMonth(1999, 5),
            new YearMonth(1999, 3),
            new YearMonth(1999, 10),
            new YearMonth(1999, 8),
            new YearMonth(1999, 12),
            };

            foreach (var x in dates)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine("");

            Console.WriteLine("--- 4.2.3 ---");
            Console.WriteLine(Is21CenturyYear(dates));
            Console.WriteLine("");

            Console.WriteLine("--- 4.2.4 ---");
            if (Is21CenturyYear(dates) == null)
                Console.WriteLine("21世紀のデータはありません。");
            else
                Console.WriteLine($"{Is21CenturyYear(dates)}は21世紀です。");
            Console.WriteLine("");

            //var s = dates == null ? "21世紀のデータはありません。" : dates.ToString();
            //Console.WriteLine(s);

            Console.WriteLine("--- 4.2.5 ---");
            Exercise2_5(dates);
            Console.WriteLine("");

        }

        private static YearMonth Is21CenturyYear(YearMonth[] years)
        {
            foreach (var item in years)
            {
                if (item.Is21Century)
                    return item;
            }
            return null;
        }

        // 4.2.5
        private static void Exercise2_5(YearMonth[] myCollection)
        {
            var array = myCollection.Select(m => m.AddOneMonth()).ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
