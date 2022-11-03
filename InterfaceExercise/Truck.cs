using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public string BedSize { get; set; }
        public bool CanTow { get; set; }
        public bool Logo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mpg { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Origin { get; set; }
        public bool RunsOfGasoline { get; set; }
        public int Year { get; set; }
    }
}
