﻿using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }


        public bool HasTrunk { get; set; } = true;


        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }
    }
}
