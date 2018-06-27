using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null;


            #region value of a nullable
            //Console.WriteLine("GetValueOrDefault() : " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue : " + date.HasValue);
            //Console.WriteLine("Value : " + date.Value);
            #endregion

            #region Null coalescing operator
            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;
            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);
            #endregion



        }
    }
}
