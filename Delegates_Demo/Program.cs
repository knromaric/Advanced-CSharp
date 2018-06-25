using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor pp = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            filterHandler += RemoveRedEye;
            pp.Process("photo.jpg", filterHandler);


        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing red eyes...");
        }

    }
}
