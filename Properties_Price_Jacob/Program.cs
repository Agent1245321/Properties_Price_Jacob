using System;
using Properties_Price_Jacob;

namespace Properties_Price_Jacob
{
    class Program
    {
        
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Initializes 2 new Car objects car1 and car2
            Car car1 = new Car();
            Car car2 = new Car();

            // Assigns the make and model to the two objects
            car1.Make = "ford";
            car1.Model = "f150";
            car2.Make = "Toyota";
            car2.Model = "Prius";

            // Writes to the console
            Console.WriteLine($"Your first car was made by {car1.Make} and is a {car1.Model}");
            Console.WriteLine($"Your second car was made by {car2.Make} and is a {car2.Model}");
        }
    }
}
