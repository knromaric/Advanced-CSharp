using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    public class BooksRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="ADO.net step by step", Price=5},
                new Book() {Title="ASP.NET MVC", Price=9.99f},
                new Book() {Title="ASP.NET WEB API", Price=12},
                new Book() {Title="C# advanced topics", Price=7},
                new Book() {Title="C# advanced topics", Price=9},
            };
        }
    }
}
