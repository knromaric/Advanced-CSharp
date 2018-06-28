using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region creating a Thread
            //Thread t = new Thread(WriteX);

            //t.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("O");

            //}    
            #endregion

            #region ThreadPool (background/foreground)Thread
            //Thread t = new Thread(Count);// FOREGROUND THREAD
            //t.Start();

            //Task task = Task.Run(() => // background thread
            //{
            //    for(int i = 0; i<8; i++)
            //    {
            //        Thread.Sleep(500);
            //        Console.WriteLine(" - BG - ");
            //    }
            //});
            #endregion

            #region ASYNC/AWAIT
            var demoAsync = new AsyncAwaitDemo();
            demoAsync.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("working on the main thread....");
            }
            #endregion
        }

        private static void Count()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("FG");
            }
        }

        public static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }           
        }
    }
} 
