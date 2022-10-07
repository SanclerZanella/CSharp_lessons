using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Default;

            Fruit f1 = new Fruit();
            f1.Name = "Apple";
            f1.Colour = "Green";
            f1.Shape = "Apple shape";
            f1.Weight = 0.2d;
            f1.Price = 1;

            Console.WriteLine(f1.Name);

            f1.ShowFruitDetails();
        }

    }

    public class Fruit
    {

        // Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Shape { get; set; }
        public double Weight { get; set; }
        private decimal _Price { get; set; }
        public decimal Price 
        { 
            get { return _Price; }
            set { _Price = value; }
        }

        // Methods
        public void ShowFruitDetails()
        {

            string price = Price.ToString("C", new CultureInfo("en-IE"));
            Console.WriteLine($"Name: {this.Name}\nPrice: €{this.Price}");

        }

    }
}
