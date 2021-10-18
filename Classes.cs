using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace App
{
    class Rectangle1
    {
        public int length, width;       // Declaration of variables

        public void GetData(int x, int y)   //method
        {
            length = x;
            width = y;
        }

        public int Area()            // Another method
        {
            int area = length * width;
            return (area);
        }
    }
    class Classes                     // class with main method
    {
        static void Main(string[] args)
        {
            int area1;          // Local variable
            int area2;          // Local variable

            Rectangle1 R1 = new Rectangle1();    // Creating objects
            Rectangle1 R2 = new Rectangle1();    // Creating objects

            R1.length = 15;   // Accessing variables
            R1.width = 25;    // Accessing variables
            area1 = R1.length * R1.width;

            R2.GetData(20, 10); // Accessing variables
            area2 = R2.Area();

            Console.WriteLine("Area 1 = "+area1);
            Console.WriteLine("Area 2 = "+area2);


            Console.ReadLine();
        }
    }
}
