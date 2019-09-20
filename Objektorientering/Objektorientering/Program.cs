using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Createing car, stand by");

            Car c;
            c = new Car();

            c.RegistrationNumber = "ABC123";
            c.HorsePower = 170;
            c.Color = "Black";

            Console.WriteLine("Car created successfully");
            Console.ReadLine();

            Console.WriteLine("We have a {0} car with registration {1} abd {2} horsepower",
            c.Color,
            c.RegistrationNumber,
            c.HorsePower);


        }
    }

    class Car
    {
        public String RegistrationNumber { get; set; }
        public string Color { get; set; }     
        public int HorsePower { get; set; } 
    }
}
