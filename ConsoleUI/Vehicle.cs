using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "Standard Make";
        public string Model { get; set; } = "Standard Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"We also have this {GetType().Name} available for a test drive in VR!\n" +
                $"");
        }
    }
}
