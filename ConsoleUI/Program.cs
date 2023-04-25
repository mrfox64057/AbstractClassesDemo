using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();


            //*Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle(use explicit typing) but use constuctors from derived classes


           // * Set the properties with object initializer syntax

            var car1 = new Car()
            {
                FourSeats = true,
                Year = 1990,
                Make = " Buick",
                Model = " Reatta"  
            };

            var bike1 = new Motorcycle()
            {
                IsTwoStroke = true,
                Year = 1973,
                Make = " Yamaha",
                Model = " LB50IC Zippy"            
            };

            Vehicle car2 = new Car()
            {
                FourSeats = false,
                Year = 1993,
                Make = " Toyota",
                Model = " MR2"             
            };
            Console.WriteLine();

            Vehicle bike2 = new Motorcycle()
            {
                IsTwoStroke = false,
                Year = 2023,
                Make = " Honda ",
                Model = " Super Cub "
                
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(bike1);
            vehicles.Add(car2 );
            vehicles.Add(bike2);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"{vehicle.Year}{vehicle.Make}{vehicle.Model}");
                vehicle.DriveAbstract();
                //Console.WriteLine();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }
           // Call each of the drive methods for one car and one motorcycle

            #endregion
           Console.ReadLine();
        }
    }
}
