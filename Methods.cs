using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Methods
    {
        static void Main(string[] args)
        {
            double b = square(2.5F);
            Console.WriteLine("Square of 2.5 is : "+b);
            Console.ReadLine();
        }
        static double square(float a)
        {
            return (a * a);
        }
    }
}
