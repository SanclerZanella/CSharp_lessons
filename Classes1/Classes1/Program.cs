using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a car object (instance) using the Default no argument constructor
            Car c1 = new Car();
            c1.Make = "BMW";
            c1.Model = "X5";
            c1.Colour = "Black";
            c1.EngineSize = 3;
            c1.NumberOfGears = 5;
            c1.RegNum = "222D456";
            c1.IsRunning = true;

            Console.WriteLine(c1.Make);
            Console.WriteLine(c1.Model);
            Console.WriteLine(c1.Colour);
            Console.WriteLine(c1.EngineSize);
            Console.WriteLine(c1.NumberOfGears);
            Console.WriteLine(c1.RegNum);

            c1.Honk();
            c1.StartEngine();

            Console.WriteLine("\n");

            // Create a car object (instance) using the overloaded constructor
            Car c2 = new Car("Honda", "Shuttle", "Red", 1.5, 5, "222D123", false);

            c2.Honk();
            c2.StartEngine();
            c2.Drive();

            for(int i = 0; i < 4; i++)
            {
                c2.ShiftUp();
            }
            c2.ShiftUp();

            c2.StopEngine();
            c2.StopEngine();
            c2.StartEngine();

            Console.WriteLine("\n");

            // Create a car object (instance) using the two values constructor
            Car c3 = new Car("Cadillac", "Escalade");
            c3.Colour = "Purple";
            c3.EngineSize = 6;
            c3.NumberOfGears = 2;
            c3.RegNum = "CA";
            c3.IsRunning = true;

            Console.WriteLine(c3.Colour);
            Console.WriteLine($"{c3.EngineSize}l");
            Console.WriteLine(c3.NumberOfGears);
            Console.WriteLine(c3.RegNum);
            Console.WriteLine(c3.IsRunning);

            c3.Honk();
            c3.StartEngine();

            Console.WriteLine("\n");

            Car c4 = new Car();
            Console.WriteLine("\nc4's Property values:");

            string mk = null;
            Console.WriteLine($"mk's value is: {mk}");

            Console.WriteLine(c4.Make);
            Console.WriteLine(c4.Model);
            Console.WriteLine(c4.Colour);
            Console.WriteLine(c4.EngineSize);
            Console.WriteLine(c4.NumberOfGears);
            Console.WriteLine(c4.RegNum);

            int[] nums = new int[6];
            nums[0] = 1;

            Car[] cars = new Car[4];
            cars[0] = c1;
            cars[1] = c2;
            cars[2] = c3;
            cars[3] = c4;

            Console.WriteLine("Make the first car honk:");
            cars[0].Honk();

            foreach(Car c in cars)
            {
                Console.Write($"Listen!! The {c.Make} {c.Model} is about to honk.");
                c.Honk();
            }

        }
    }

    //  [Access Modifier] [class keyword] [identifier]

    public class Car
    {

        //  Properties (Atributes)

        public string Make { get; set; }         // Use capital letter when naming properties.
        public string Model { get; set; }
        public string Colour { get; set; }
        public double EngineSize { get; set; } 
        public int NumberOfGears { get; set; }
        public string RegNum { get; set; }
        public bool IsRunning { get; set; }
        public int maxGear { get; set; }
        public int currentGear { get; set; }

        //  Constructor's

        public Car()    // Default no argument constructor.
        {
            Console.WriteLine("Object created using the default no argument constructor");
        }

        public Car(string make, string model, string colour, double engineSize, int numberOfGears, string regNum, bool isRunning)
        {
            Make = make;
            Model = model;
            Colour = colour;
            EngineSize = engineSize;
            NumberOfGears = numberOfGears;
            RegNum = regNum;
            IsRunning = isRunning;

            Console.WriteLine("Object created using the overloaded constructor");

            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Colour: {Colour}");
            Console.WriteLine($"Engine Size: {EngineSize}");
            Console.WriteLine($"Number of Gears: {NumberOfGears}");
            Console.WriteLine($"Registration Number: {RegNum}");
            Console.WriteLine($"Status: {IsRunning}");

        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;

            Console.WriteLine("Object created using the two Atributes constructor");

            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");

        }



        // Behaviours (Methods)

        public void Honk()
        {
            Console.WriteLine("BEEP BEEP");
        }

        public void StartEngine()
        {

            if (this.IsRunning)
            {
                Console.WriteLine("Jeez man you'll burn out the starter!!!");
            }
            else
            {
                Console.WriteLine("Engine Started");
                IsRunning = true;
            }

        }
        public void StopEngine()
        {

            if (this.IsRunning)
            {
                Console.WriteLine("Engine Started");
                IsRunning = false;
            }
            else
            {
                Console.WriteLine("Engine was not running!");
            }

        }

        public void Drive()
        {

            currentGear = 1;
            Console.WriteLine($"Now we are driving slowly, in {1}st gear!!!");

        }

        public void ShiftUp()
        {

            if(currentGear < 5)
            {
                currentGear++;
                Console.WriteLine($"Now we are driving, in {this.currentGear}st/nd/rd gear!!!");
            }
            else
            {
                Console.WriteLine("Stop grinding my gears!!!");
            }

        }

        public void ShiftDown()
        {

            currentGear--;
            Console.WriteLine($"Now we are driving, in {this.currentGear}st/nd/rd gear!!!");

        }


    }
    
}
