using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");

            string name = GetName();

            Greeting(name);
        }

        static string GetName()
        {
            string name = Console.ReadLine();

            return name;
        }

        static void Greeting(string name)
        {
            Console.WriteLine($"Hi {name}, Welcome to DDLETB!");
        }

    }
}
