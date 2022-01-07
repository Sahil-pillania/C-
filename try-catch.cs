using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class try_catch
    {
        static void Main(string[] args)
        {

            try
            {
                
                int[] a = { 5, 10 };
                int b = 5;
                int x = a[2] / b - a[1];
                Console.WriteLine(x);
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
            finally
            {
                Console.WriteLine("This is finally block and will run everytime.");
            }
            Console.ReadLine();
        }
    }
}

