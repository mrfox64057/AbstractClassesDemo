﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car() 
        {
        }

        public bool FourSeats { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("\n" +
                "Nice, cars are our specialty. We have that available to drive!\n" +
                "");
        }
    }


}
