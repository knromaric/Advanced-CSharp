using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BooksRepository().GetBooks();

            #region linq query operator
            //var bookcheaps = from b in books
            //                 where b.Price < 10
            //                 orderby b.Title descending
            //                 select b.Title;
            #endregion


            #region linq extensions methods
            var booksCheaperThan10 = books
                                        .Where(b => b.Price < 10)
                                        .OrderBy(b => b.Title)
                                        .Select(b => b.Title);

            var aspBook = books.SingleOrDefault(b => b.Title == "as.NET MVC");
            var books1 = books.Skip(2).Take(3);
            Console.WriteLine(books.Count());
            Console.WriteLine(books.Max(b=>b.Price));
            Console.WriteLine(books.Sum(b=>b.Price));


            #endregion


            foreach (var book in books1)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
