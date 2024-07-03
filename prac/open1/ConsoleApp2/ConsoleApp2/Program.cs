/*
=>Create a Vehicle class with properties for vehicle type (car, bike, truck) and speed.

=>Create a Car class that inherits from Vehicle and adds properties for number of doors and engine type.

=>Create a Bike class that inherits from Vehicle and adds properties for number of gears and type of brakes.

=>Write a program that creates an array of Vehicle objects and casts them to Car and Bike objects. 
Use type casting to access the specific properties of each vehicle.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car{VehicleType = "Car",speed = 123, door=2, engine="abc"},
                new Bike{VehicleType = "bike", speed = 122, gears = 5, typeBreak = "ass"}
            };

            List<Vehicle> list = new List<Vehicle>();

        }
    }
}
