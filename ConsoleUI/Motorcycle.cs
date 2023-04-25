using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() 
        {
        }

        public bool IsTwoStroke { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("\n" +
                "Can't go wrong with a bike, we have that available to drive if you'd like\n" +
                " ");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"If you'd like to ride this {GetType().Name}, first click {GetType().BaseType.Name} and then \n" +
                $"select VR tour");
            Console.WriteLine();
        }
    }
}
