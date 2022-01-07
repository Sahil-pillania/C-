using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class try3
 
    {
        static void Main(string[] args)
        {
            int index = 6;
            int[] arr = new int[5];
            try
            {
                arr[index] = 100;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds occurred");
            }
            Console.WriteLine("Program execution continued after Exception Handling");
            Console.ReadLine();
        }
    }
}

