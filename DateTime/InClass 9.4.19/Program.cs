using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_9._4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            DateTime future = today.AddDays(27);

            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(future);

            var difference = future - today;

            Console.WriteLine(difference.Days);

            Console.ReadKey();
        }
    }
}
