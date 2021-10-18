
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            // Implicit conversion 
            short b = 79;   
            int a = b;     //implicit 
            Console.WriteLine("Value of a is :" + a);

            byte x1 = 50;
            short x2 = x1;  // byte value converted to short 
            int x3 = x2;    // short value converted to int 
            long x4 = x3;   // int value converted to long
            float x5 = x4;  // long value converted to float
            Console.WriteLine("Value of x5 is :" +x3);
            // Explicit conversion
            int p = 40;
            byte q = (byte)p;
            Console.WriteLine("Value of q is :" +q);

            string s = "100";
            int n = int.Parse(s);
            Console.WriteLine("Value of n is :" + n);
            Console.WriteLine("Ended");
            Console.ReadLine();
        }
    }
}
