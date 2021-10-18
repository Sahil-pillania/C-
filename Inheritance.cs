
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace App
{
    class item1
    {

        public void Company()    // Base class
        {
            Console.WriteLine("This is base class!");
        }
    }
    class car:item1            // Derived class
    {
        public void Model()
        {
            Console.WriteLine("Car Model is : Harrier");
        }
    }
    class Inheritance
    {
        static void Main()
        {
            item1 One = new item1();   // initializing objects
            car Tata = new car();

            One.Company();           // invoking methods of classes using objects
            Tata.Company();
            Tata.Model();

            Console.ReadLine();
        }
    }
}
