using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in a starting number");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter in the end number");
            int b = Int32.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                sum += i ;
            }
            Console.WriteLine($"{sum}");

            Console.ReadLine();

        }
    }
}
