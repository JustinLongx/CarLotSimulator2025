using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator2025
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"{noise}");
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"{noise}");
        }

        //method to diplay all cars
        public void DisplayCarInfo() 
        { 
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Engine noise: {EngineNoise}, Honk noise: {HonkNoise}. Is this vehicle driveable? {IsDrivable}"); 
        }

        //Constructor with parameters
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable) 
        { 
            Make = make; 
            Model = model; 
            Year = year; 
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;

        }

        //Parameterless constructor
        public Car() { }
    }
}
