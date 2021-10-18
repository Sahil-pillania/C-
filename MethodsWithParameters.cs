using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Methods_with_parameters
    {
        static double addition(float a, float b, float c)
        {
            return (a + b + c);
        }
        static void Main(string[] args)
        {
            int a = 50;
            int b = 70;
            int c = 85;

            double z = addition(a, b, c);
            Console.WriteLine("Values of a+b+c is : "+z);
            Console.ReadLine();
        }
    }
}
