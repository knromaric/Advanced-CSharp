using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Demo
{
    class App
    {
        static void Main(string[] args)
        {
             
            var number = new Nullable<int>();
            Console.WriteLine("has Value : "+ number.HasValue);
            Console.WriteLine("value : " + number.GetValueOrDefault());
        }
    }
}
