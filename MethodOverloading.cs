using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class MethodOverloading
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Volume of cube is : " +volume(10));
            Console.WriteLine("Volume of cylinder is : " + volume(2.5F,8));
            Console.WriteLine("Volume of box is : " + volume(100L, 75,15));
            Console.ReadLine();
        }
        static int volume(int x)          // cube
        {
            return (x * x * x);
        }
        static double volume (float r, int h)   // cylinder
        {
            return (3.14 * r * r * h);
        }
        static long volume (long l, int b, int h)    // box
        {
            return (l * b * h);
        }
    }

}
