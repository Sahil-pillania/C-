
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program1
    {
        public Program1()
        {
            Console.WriteLine("I am a constructor!");
        }

        private static void Main(string[] args)
        {
            int var1 = 123;          //variable 1
            float var2 = 23.5F;      //variable 2
            string var3;
            var3 = "Sahil";      //variable 3
           
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.ReadLine();
            
        }
    }
}  
