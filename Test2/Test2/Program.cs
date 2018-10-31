using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is a basic menu system");
            Console.WriteLine("Please enter in a number from 1 to 4, for a task");
            Console.WriteLine("1 for Option 1");
            Console.WriteLine("2 for Option 2");
            Console.WriteLine("3 for Option 3");
            Console.WriteLine("4 to exit application");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Option 1");
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    break;
                case 3:
                    Console.WriteLine("Option 3");
                    break;
                case 4:
                    Console.WriteLine("Exit application");
                    break;
            }

            Console.ReadLine();


        }
    }
}
