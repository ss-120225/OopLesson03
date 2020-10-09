using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6章
            ////整数の例
            //var numbers =
            //    new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24, };

            ////var strings = numbers.Select(x => x.ToString("0000")).ToList.Foreach(s => Console.Write(s + " "));
            ////var strings = numbers.Select(x => x.ToString("0000")).ToArray();
            ////var strings = numbers.Distinct().ToArray();
            ////foreach (var item in strings)
            ////{
            ////    Console.Write(item + " ");
            ////}
            ////numbers.Select(n => n.ToString("0000")).ToList().ForEach(n => Console.Write(n + " "));

            //Console.WriteLine();
            //var sortedNumbers = numbers.OrderBy(n => n);
            //foreach (var nums in sortedNumbers)
            //{
            //    Console.Write(nums + " ");
            //}

            ////文字列の例
            //Console.WriteLine("\n\n-----------------");
            //var words = new List<string>
            //{ 
            //   "Microsoft",
            //   "Apple",
            //   "Google",
            //   "Oracle",
            //   "Facebook",
            //};

            //var lower = words.Select(x => x.ToLower()).ToArray();

            ////Bookオブジェクトの例
            //Console.Write("\n\n-----------------");
            //var books = Books.GetBooks();
            ////タイトルのみのリスト
            //Console.WriteLine("");
            //var titles = books.Select(x => x.Title).ToList();
            //foreach (var item in titles)
            //{
            //    Console.Write(item + " " );
            //}

            //Console.WriteLine();
            ////ページ数の多い順に並べ替え BEST3ならTake(3)
            //books.OrderByDescending(x => x.Pages).ToList().ForEach(s => Console.WriteLine($"{ s.Title} {s.Pages}頁"));

            //Console.WriteLine();
            ////金額の高い順に並べ替え
            //books.OrderByDescending(x => x.Price).ToList().ForEach(s => Console.WriteLine($"{ s.Title} {s.Price}円"));
            #endregion

            #region 6.1
            //var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };

            //// 6.1演習問題
            //Console.WriteLine("-----6.1-----");
            //Console.WriteLine($"最大値：{numbers.Max(n => n)}");
            //Console.WriteLine();

            //// 6.2演習問題
            //Console.WriteLine("-----6.2-----");
            //numbers.Skip(numbers.Length - 2).ToList().ForEach(x => Console.WriteLine(x));            
            ////for (int i = numbers.Length - 1; i > numbers.Length - 3 ; i--)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}
            //Console.WriteLine();

            //// 6.3演習問題
            //Console.WriteLine("-----6.3-----");
            //numbers.Select(x => x.ToString("000")).ToList().ForEach(x => Console.Write(x + " "));            
            //Console.WriteLine();

            //// 6.4演習問題
            //Console.WriteLine("-----6.4-----");
            //numbers.OrderBy(x => x).Take(3).ToList().ForEach(s => Console.WriteLine(s));            
            //Console.WriteLine();

            //// 6.5演習問題
            //Console.WriteLine("-----6.5-----");
            //Console.WriteLine(numbers.Where(x => x >= 10).Distinct().Count());
            //Console.WriteLine();
            #endregion

            var books = new List<Book> {
         new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
         new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
         new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
         new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
         new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
         new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
         new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //演習問題6.2.1
            Console.WriteLine("-----6.2.1-----");
            var target = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            if(target != null)
                Console.WriteLine($"ページ数：{target.Pages}\n価格：{target.Price}");

            Console.WriteLine();

            //演習問題6.2.2
            Console.WriteLine("-----6.2.2-----");
            var count = books.Count(b=>b.Title.Contains("C#"));
            Console.WriteLine(count);
            Console.WriteLine();

            //演習問題6.2.3
            Console.WriteLine("-----6.2.3-----");
            var avg = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            Console.WriteLine($"平均ページ：{avg}");
            Console.WriteLine();

            //演習問題6.2.4
            Console.WriteLine("-----6.2.4-----");
            var title = books.FirstOrDefault(x => x.Price >= 4000);
            if(title != null)
                Console.WriteLine(title.Title);
            Console.WriteLine();

            //演習問題6.2.5
            Console.WriteLine("-----6.2.5-----");
            var max = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            Console.WriteLine(max);
            Console.WriteLine();

            //演習問題6.2.6
            Console.WriteLine("-----6.2.6-----");
            var asc = books.Where(x => x.Pages >= 400).OrderByDescending(s => s.Price);
            foreach (var item in asc)
            {
                Console.WriteLine($"{item.Title}   {item.Price}");
            }
            Console.WriteLine();

            //演習問題6.2.7
            Console.WriteLine("-----6.2.7-----");
            var tar = books.Where(s => s.Title.Contains("C#") && s.Pages <= 500);
            foreach (var item in tar)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();

        }
    }
}
