using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            #region lambda basics
            // lambda expression: args => expression 
            // () => ...
            // x => ... 
            // (x, y, y) => ...

            //const int factor = 5;
            //Func<int, int> multiplier = (x) => x * factor;

            //Console.WriteLine(multiplier(5));

            #endregion

            #region works with list of books
            var books = new BookRepository().GetBooks();

            var findBooks = books.FindAll(b => b.Price > 5);
            foreach (var book in findBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }
            #endregion

        }

    }
}
