using System;
using Properties_Price_Jacob;

namespace Properties_Price_Jacob
{
    class Program
    {
        /// <summary>
        /// Documentaion Documentation Documentaion Documentation Documentaion Documentation Documentaion Documentation
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Documentaion Documentation
            Car car1 = new Car();
            Car car2 = new Car();

            // Documentaion Documentation

            car1.Make = "ford";
            car1.Model = "f150";
            car2.Make = "Toyota";
            car2.Model = "Prius";

            // Documentaion Documentation
            Console.WriteLine($"Your first car was made by {car1.Make} and is a {car1.Model}");
            Console.WriteLine($"Your second car was made by {car2.Make} and is a {car2.Model}");
        }
    }
}
