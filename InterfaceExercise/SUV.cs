using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool CargoHold { get; set; }
        public bool Logo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mpg { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public bool OffRoadCapability { get; set; }
        public string Origin { get; set; }
        public bool RunsOfGasoline { get; set; }
        public int Validation { get; set; } = 2;
        public int Year { get; set; }
    }
}