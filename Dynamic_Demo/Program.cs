using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            dynamic b = 5;
            var c = a+b;

            int i = 5;
            dynamic d = i;
            long l = d;
            #region using Reflection
            //object obj = "ROMARIC";
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);
            #endregion
        }
    }
}
