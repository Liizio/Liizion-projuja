using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class Program
    {
        class Vehicle
        {
            public string Name { get; set; }
            public int Speed { get; set; }
            public int Tyres { get; set; }

            public void PrintData()
            {
                Console.WriteLine("Vehicle data:");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Speed: " + Speed);
                Console.WriteLine("Tyres: " + Tyres);
            }

        }
        static void Main(string[] args)
        {
            do
            {
                Vehicle vehicle1 = new Vehicle();
                Console.WriteLine("enter name: ");
                vehicle1.Name = (Console.ReadLine());
                Console.WriteLine("enter speed: ");
                vehicle1.Speed = int.Parse(Console.ReadLine());
                Console.WriteLine("enter amount of tyres: ");
                vehicle1.Tyres = int.Parse(Console.ReadLine());
                vehicle1.PrintData();

            } while (true);
        }
    }
}
