using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region divide by zero exception
            //try
            //{
            //    var calculator = new Calculator();
            //    var reusult = calculator.Divide(5, 0);


            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero...");
            //}

            //catch (ArithmeticException ex)
            //{

            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occured.");
            //}

            #endregion

            #region finally block
            //StreamReader streamReader =null; 
            //try
            //{
            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //    throw new Exception("oops");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Sorry, unexpected error occured....");
            //}
            //finally
            //{
            //    if(streamReader != null)
            //        streamReader.Dispose();
            //}
            #endregion

            #region Using statement

            //try
            //{
            //    using(var streamReader = new StreamReader(@"c:\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Sorry, an unexpected error occured...");
            //}

            #endregion

            #region Custom exception demo
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("rom");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion



        }
    }
}
