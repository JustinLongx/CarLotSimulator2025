using System.Reflection;

namespace CarLotSimulator2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO
            CarLot carLot = new CarLot();



            //Now that the Car class is created we can instanciate 3 new cars
            Car Car1 = new Car();
            Car Car2 = new Car();
            Car Car3 = new Car();
            //Set the properties for each of the cars
            Car1.Year = 2025;
            Car1.Make = "Toyota";
            Car1.Model = "4Runner";
            Car1.EngineNoise = "Vroom";
            Car1.HonkNoise = "Beep, Beep";
            Car1.IsDrivable = true;

            Car2.Year = 2020;
            Car2.Make = "Dodge";
            Car2.Model = "2500";
            Car2.EngineNoise = ("Chugha Chugha");
            Car2.HonkNoise = ("Honk, Honk");
            Car1.IsDrivable = true;

            Car3.Year = 2050;
            Car3.Make = "SpaceX";
            Car3.Model = "Mars-Roamer";
            Car3.EngineNoise = ("RUMBLE, RUMBLE");
            Car3.HonkNoise = ("Pew, Pew");
            Car1.IsDrivable = false;


            //Call each of the methods for each car
            Car1.MakeEngineNoise("Vroom");
            Car1.MakeHonkNoise("Beep, Beep");

            Car2.MakeEngineNoise("Chugha Chugha");
            Car2.MakeHonkNoise("Honk, Honk");

            Car3.MakeEngineNoise("RUMBLE, RUMBLE");
            Car3.MakeHonkNoise("Pew, Pew");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car myCar1 = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022
            };

            Car myCar2 = new Car();
            myCar2.Make = "Toyota";
            myCar2.Model = "Camry";
            myCar2.Year = 2050;

            Car myCar3 = new Car("VW", "Beetle", 1969, "Vreem", "Beeeeep", true);



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            // Add the cars to the CarLot
            carLot.AddCar(Car1); 
            carLot.AddCar(Car2); 
            carLot.AddCar(Car3);

            carLot.DisplayAllCars();
            Console.ReadKey();
        }
    }
}
