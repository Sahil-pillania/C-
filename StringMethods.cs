using System;

using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace App
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string s1 = "My name is Sahil Pillania";     //Assigning string literals
            Console.WriteLine(s1);

            // Coping strings
            string s2 = s1;     //assigning
             s2 = string.Copy(s1);
            Console.WriteLine("String s2 after coping is : " +s2);

            // Concatination
            string s3 = string.Concat(s1,s2);
            Console.WriteLine("String s3 after Concatination is : " +s3);

            // Reading from the keyboard
            Console.WriteLine("Enter your string:");
            string s4 = Console.ReadLine();
            Console.WriteLine("String s4 after reading is : " +s4);

            // ToString Method
            int num = 12345;
            string numstr = num.ToString();
            Console.WriteLine("String is : " +numstr);



            Console.ReadLine();
        }
    }
}
