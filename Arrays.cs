using System;


namespace App
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // int[] array1;   // declaration
            // array1 ={1, 3, 5, 6};  // Initialization

            int[] array1 = { 1, 3, 5, 6 };

            foreach(int s in array1)
            {
            Console.WriteLine("Data in array is : " +s);

            }
            int x = array1.Length;    // length of array
            Console.WriteLine("Length of array is : " +x);

            Console.ReadLine();
        }
    }
}
