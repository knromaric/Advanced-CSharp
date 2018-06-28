using System.Threading.Tasks;
using System;

namespace Async_Await_Demo
{
    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await Task.Run(() =>
            {
                CountToFifty();
            });

            //this will not execute until CountToFifty has completed
            Console.WriteLine("Counting to 50 is completed");   
        } 

        private static void CountToFifty()
        {
            for (int counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("BG THREAD: "+ counter);
            }

        }
    }
} 
