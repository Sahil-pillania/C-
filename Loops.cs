using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Loops
    {
        static void Main(string[] args)
        {
            // for loop
            Console.WriteLine("For loop");
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("value of i is : " +i);
            }

            // while loop
            Console.WriteLine("While loop");
            int j = 0;
            while (j < 12)
            {
                Console.WriteLine("value of j in while loop is : " + j);
                j++;
            }

            // do-while loop

            Console.WriteLine("Do-While loop");
            int a = 0;

            do
            {
                Console.WriteLine("value of a in Do-while loop is : " + a);
                a++;
            }
            while (a<5);

            // for-each loop
            Console.WriteLine("for-each loop");
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int i in data)
            {
                if(data.Length == 0)
                {
                    goto end;
                }
                else
                {
                    Console.WriteLine("i is : " + i);

                }

                }

            // goto 
            end: Console.WriteLine("No data here...");
            




            Console.ReadLine();
        }
    }
}
