using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-DONE
            

            //Create 3 classes called Car , Truck , & SUV-DONE

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.- DONE
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; } - DONE
                 */

            //In each of your car, truck, and suv classes- DONE

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            var car1 = new Car() 
            { 
                Year = "2023", 
                Make = "Chevy", 
                Model = "Corvette", 
                CompName = "LAPD", 
                HasRadio = true, 
                CanDrive = true, 
                HasSteeringWheel = true, 
                IsConvertible = true, 
                HasTrunk = true, 
                Motto = "We're gonna catch you this time!", NumberOfWheels = 4
            };

            var truck1 = new Truck() 
            { 
                Year = "2005", 
                Make = "Toyota", 
                Model = "Tacoma", 
                CanDrive = true, 
                HasSteeringWheel = true, 
                HasRadio = true, 
                LiftedBody = false,
                NumberOfWheels=4, 
                ShrekEarMirrors = true, 
                CompName = "General Landscaping Co", 
                Motto = "Our truck doesn't work very well but we do."
            };

            var suv1 = new SUV() 
            { 
                Year = "2015", 
                Make = "Ford", 
                Model = "Explorer", 
                CanDrive = true, 
                HasSteeringWheel = true,
                FourWheelDrive = true, 
                HasCargo = true, 
                HasRadio = true, 
                NumberOfWheels = 4, 
                CompName = "FBI",
                Motto = "What you gone do when we comin for you." 
            };

            vehicles.Add(car1);
            vehicles.Add(suv1);
            vehicles.Add(truck1);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                Console.WriteLine($"Has Stereo?: {vehicle.HasRadio}, Number of wheels {vehicle.NumberOfWheels}");
            }
        }
    }
}
