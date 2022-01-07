﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                string input = Console.ReadLine();
                int data = int.Parse(input);
                //byte data = byte.Parse("a");
                Console.WriteLine(data);
                int[] a = { 5, 10 };
                int b = 5;
            }

 
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("We got indexOutOfRangeException error.");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);

                Console.WriteLine("At least provide one Argument!");
            }

           
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);

                Console.WriteLine("Entered value in not a number!");
            }

         
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);

                Console.WriteLine("Data is out of Range!");
            }
            catch (Exception ex)

            {
                Console.WriteLine("We are in parent exception class.");
                Console.WriteLine("Error is : " + ex);
            }
            
            Console.ReadLine();
        }
    }
}

