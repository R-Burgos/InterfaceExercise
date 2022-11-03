using System;

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

            Console.WriteLine("I have three different vehicles to present information on. Please choose 1-3");
            var userInput = Console.ReadLine();
            bool condition;

        }
    }
}
