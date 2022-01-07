using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class finally_block
    {
        static void Main(string[] args)
        {
       
            // Try block: The code which may raise exception at runtime
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Divide Program. You Enter 2 number and we return result");
                Console.WriteLine("Enter 1st Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Divide : " + result.ToString());
                Console.ReadLine();
            }

            //Multiple Catch block to handle exception

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("You have Entered 0");
                Console.WriteLine("More Details about Error: \n\n" + dex.ToString() + "\n\n");
                
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("More Details about Error: \n\n" + fex.ToString() + "\n\n");
                
            }

            //Parent Exception: Catch all type of exception

            catch (Exception ex)
            {
                Console.WriteLine("Othe Exception raised" + ex.ToString() + "\n\n");
                
            }

            //Finally block: it always executes

            finally
            {
                Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                Console.ReadLine();
            }
        }
    }
}
