
using System;
using System.Collections.Generic;
using System.Linq;


namespace App
{
    struct Rectangle
    {
        int a;   // variable 1
        int b;   // variable 2
        public Rectangle(int x, int y)    // Constructor
        {
            a = x;
            b = y;
        }
        public int Area()     //  Method
        {
            return (a * b);
        }
        public void Display()
        {
            Console.WriteLine("Area is: " + Area());
        }
            
    }
    class StructuresUsingMethods
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(15, 25);
            R1.Display();    // invoking Display method
            
            Console.ReadLine();
        }
    }
}
