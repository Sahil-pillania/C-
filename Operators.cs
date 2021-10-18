
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Operators
    {
        static void Main(string[] args)
        {
            // Operator types:
            // 1. Arithmetic
            // 2. Relational 
            // 3. Logical
            // 4. Assignment
            // 5. Increment and decrement
            // 6. Conditional
            // 7. Bitwise
            


            // 1. Arithmetic

            int a = 50;
            int b = 10;
            Console.WriteLine("Aritmetic operators");
            Console.WriteLine("Value of a+b is : "+ (a + b));
            Console.WriteLine("Value of a-b is : "+ (a - b));
            Console.WriteLine("Value of a*b is : "+ (a * b));
            Console.WriteLine("Value of a/b is : "+ (a / b));
            Console.WriteLine("Value of a%b is : "+ (a % b));

            // 2. Relational
            Console.WriteLine("Relational operators");
            Console.WriteLine("Value of a and b is : " +a+"  " +b);
            Console.WriteLine("a<b : " + (a<b));
            Console.WriteLine("a<=b : " + (a<=b));
            Console.WriteLine("a>b : " + (a>b));
            Console.WriteLine("a>=b : " + (a>=b));
            Console.WriteLine("a=b : " + (a==b));

            // 3. Comparison 
            Console.WriteLine("Comparison operators");
            Console.WriteLine("True && True is : " +(true && true));
            Console.WriteLine("True || false is : " +(true || false));
            Console.WriteLine("!True is : " +(!true));
            Console.WriteLine("True ^ True is : " +(true ^ true));

            //4. Assignment
            Console.WriteLine("Assignment operators");

            // a+=3;
            // a-=3;
            // a*=4;
            // a/=4;
            int c = 6;
            Console.WriteLine("Value of c+=3 : " +(c+=3));
            Console.WriteLine("Value of c-=3 : " +(c-=3));
            Console.WriteLine("Value of c*=3 : " +(c*=3));
            Console.WriteLine("Value of c/=3 : " +(c/=3));

            // 5. Increment and decrement
            Console.WriteLine("Increment and decrement operators");
            float m = 5;

            Console.WriteLine("Value of m++ is : " + (m++)); // incremented from 5 to 6
            Console.WriteLine("Value of ++m is : " + (++m)); // finally incremented from 6 to 7


            // 6. Conditional 
            Console.WriteLine("Conditional operators");

            int e = 10;
            int f = 12;
            int x = ((e<f) ? e : f );
            Console.WriteLine("(e<f) ? e : f ) : " + ((e<f)?e:f));

            Console.ReadLine();
        }
    }
}
