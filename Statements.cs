using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Statements
    {
        static void Main(string[] args)
        {

            // if statement
            bool style = true;
            if (style)
            {
                Console.WriteLine("Yes style present");
            }
            // if-else statement
            int a = 5;
            int b = 6;
            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("b is greater");
            }

            // Switch statement

            int z = 4;

            switch (z)
            {
                case 1: Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                case 3:
                    Console.WriteLine("Value is 3");
                    break;
                case 4:
                    Console.WriteLine("Value is 4");
                    break;
                default: Console.WriteLine("Undefined value");
                    break;
            }


            
            Console.ReadLine();
        }
    }
}
