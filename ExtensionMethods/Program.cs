using System.Collections.Generic;
using System.Linq;


namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "this is supposed to be a very long blog post blah blah blah.....";
            var shortenedPost = post.Shorten(5);
            System.Console.WriteLine(shortenedPost);


            IEnumerable<int> numbers = new List<int>() { 1,4,6,34,67};
            var max = numbers.Max();
            System.Console.WriteLine(max);
            
        }
    }
}
