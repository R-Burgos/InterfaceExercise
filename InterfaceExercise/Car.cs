using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public bool Logo { get; set; }
        public bool LowGroundClearance { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mpg { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Origin { get; set; }
        public bool RunsOfGasoline { get; set; }
        public bool Trunk { get; set; }
        public int Validation { get; set; } = 1;
        public int Year { get; set; }
    }
}