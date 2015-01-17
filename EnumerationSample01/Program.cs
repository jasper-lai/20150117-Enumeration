using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            // High-level way of iterating through the characters in the word “beer”:
            foreach (char c in "beer")
                Console.WriteLine(c);

            // Low-level way of iterating through the same characters:
            using (var enumerator = "beer".GetEnumerator())
                while (enumerator.MoveNext())
                {
                    var element = enumerator.Current;
                    Console.WriteLine(element);
                }

            Console.ReadLine();

            ////Output:
            //b
            //e
            //e
            //r
            //b
            //e
            //e
            //r

        }
    }
}
