using System;
using System.Collections.Generic;
using System.Reflection;
using InterfaceExercise;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces - I will do my best.

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE
            //Creatively display and organize their values

            var car1 = new Car() 
            {  
                Logo = true, 
                LowGroundClearance = true,
                Make = "Toyota",
                Model = "Camry",
                Mpg = 35, 
                NumberOfDoors = 4, 
                NumberOfWheels = 4, 
                Origin = "Japan", 
                RunsOfGasoline = true, 
                Trunk = true, 
                Year = 2022
            };
            
            var suv1 = new SUV() 
            {
                CargoHold = true,
                Logo = true,  
                Make = "Ford",
                Model = "Bronco",
                Mpg = 22, 
                NumberOfDoors = 4, 
                NumberOfWheels = 4,
                OffRoadCapability = true,
                Origin = "United States of America",
                RunsOfGasoline = true,
                Year = 2021

            };
            
            var truck1 = new Truck() 
            {
                BedSize = "98.4\"",
                CanTow = true,
                Logo = true,
                Make = "Chevrolet",
                Model = "Silverado 1500",
                Mpg = 23,
                NumberOfDoors = 2,
                NumberOfWheels = 4, 
                Origin = "United States of America",
                RunsOfGasoline = true,
                Year = 2020
            };

            var vehiclesList = new List<IVehicle>();
            vehiclesList.Add(car1);
            vehiclesList.Add(suv1);
            vehiclesList.Add(truck1);  

            Console.WriteLine("     Please reveiw the following vehicles.");
            Console.WriteLine("X-------------------------------------------------X\n");

            for (int i = 0; i < vehiclesList.Count; i++)
            {
                if (vehiclesList[i].Validation == 1)
                {
                    //IVehicle
                    Console.WriteLine($"This is a {vehiclesList[i].Year} {vehiclesList[i].Make} {vehiclesList[i].Model}");
                    Console.WriteLine($"It is {vehiclesList[i].RunsOfGasoline} that this vehicle gets {vehiclesList[i].Mpg}MPG.");
                    Console.WriteLine($"It has {vehiclesList[i].NumberOfDoors} doors and {vehiclesList[i].NumberOfWheels} wheels.");
                    //Car Class
                    Console.WriteLine($"It is {car1.Trunk} that this vehicle has a trunk.");
                    Console.WriteLine($"It is also {car1.LowGroundClearance} that this vehicle has low ground clearance.");
                    //ICompany
                    Console.WriteLine($"It is {car1.Logo} that this vehicle was made in {car1.Origin}.");
                    
                    Console.WriteLine("X-------------------------------------------------X\n");
                }
                if (vehiclesList[i].Validation == 2)
                {
                    //IVehicle
                    Console.WriteLine($"This is a {vehiclesList[i].Year} {vehiclesList[i].Make} {vehiclesList[i].Model}");
                    Console.WriteLine($"It is {vehiclesList[i].RunsOfGasoline} that this vehicle gets {vehiclesList[i].Mpg}MPG.");
                    Console.WriteLine($"It has {vehiclesList[i].NumberOfDoors} doors and {vehiclesList[i].NumberOfWheels} wheels.");
                    //SUV Class
                    Console.WriteLine($"It is {suv1.CargoHold} that this vehicle has cargo space.");
                    Console.WriteLine($"It is {suv1.OffRoadCapability} that this vehicle is off-road capable.");
                    //ICompany
                    Console.WriteLine($"It is {suv1.Logo} that this vehicle was made in {suv1.Origin}.");
                   
                    Console.WriteLine("X-------------------------------------------------X\n");
                }
                if (vehiclesList[i].Validation == 3)
                {
                    //IVehicle
                    Console.WriteLine($"This is a {vehiclesList[i].Year} {vehiclesList[i].Make} {vehiclesList[i].Model}");
                    Console.WriteLine($"It is {vehiclesList[i].RunsOfGasoline} that this vehicle gets {vehiclesList[i].Mpg}MPG.");
                    Console.WriteLine($"It has {vehiclesList[i].NumberOfDoors} doors and {vehiclesList[i].NumberOfWheels} wheels.");
                    //Truck Class
                    Console.WriteLine($"It is {truck1.CanTow} this vehicle can tow.");
                    Console.WriteLine($"This vehicle's bed size is {truck1.BedSize}.");
                    //ICompany
                    Console.WriteLine($"It is {truck1.Logo} that this vehicle was made in {truck1.Origin}.");
                   
                    Console.WriteLine("X-------------------------------------------------X\n");
                }
            }



        }
    }
}
