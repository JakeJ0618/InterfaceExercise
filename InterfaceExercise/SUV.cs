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
        public bool HasCargo { get; set; }
        public bool FourWheelDrive { get; set; }
        public bool HasSteeringWheel { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public bool HasRadio { get ; set ; }
        public bool CanDrive { get ; set ; }
        public string Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string CompName { get ; set ; }
        public string Motto { get ; set ; }
    }
}
