using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator2025
{
    public class CarLot
    {
        //It should have at least one property: a List of cars

        // List to store cars
        public List<Car> Cars { get; set; } = new List<Car>();

        //Instanciate the a Carlot at the beginning of the program
        //and as you create a car add the car to the list.

        // Method to add a car to the list
        public void AddCar(Car car) 
        { 
            Cars.Add(car); 
        }

        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        public void DisplayAllCars() 
        {
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"Listing all cars in the lot:");
            Console.WriteLine("");
            foreach (var car in Cars) 
            { 
                car.DisplayCarInfo(); 
            } 
        }
    }
}
