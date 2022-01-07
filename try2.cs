using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class try2
    {
        class MyProgram
        {
            static void Main(string[] args)
            {
                int val = 10;
                try
                {
                    int i;
                    for (i = -1; i < 3; ++i)
                        val = (val / i);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("0");
                    Console.Write("Arithmetic error occured.");
                }
                Console.WriteLine(val);
                Console.ReadLine();
            }
        }
    }
}
