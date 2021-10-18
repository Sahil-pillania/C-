using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace App
{
    struct item
    {
        public string name;
        public string model;
        public int speed;
        public double price;
    }

    class Structures
    {
        static void Main(string[] args)
        {
            item car;   // create an item
            // Assigning value to the item
            car.name = "Mahindra";
            car.model = "XUV700";
            car.speed = 205;
            car.price = 2300000;

            // Display item details
            Console.WriteLine("Car name : " +car.name);
            Console.WriteLine("Car model : " +car.model);
            Console.WriteLine("Car speed : " +car.speed);
            Console.WriteLine("Car price : " +car.price);
            Console.ReadLine();
        }
    }
}
