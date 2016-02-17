using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Program
    {
        class Elevator
        {
            private readonly int MaxFloor = 5;
            private readonly int MinFloor = 1;

            private int floor;
            public int Floor
            {
                get
                {
                    return floor;
                }

                set
                {
                    if (MinFloor <= value && MaxFloor >= value) floor = value;
                    else if (value > MaxFloor)
                    {
                        Console.WriteLine("No such floor exists, taking you to the top floor");
                        floor = MaxFloor;
                    }
                    else if (value < MinFloor)
                    {
                        Console.WriteLine("No such floor exists, taking you to the first floor");
                        floor = MinFloor;
                    }
                }
            }
            static void Main(string[] args)
            {
                Elevator elevator = new Elevator();
                elevator.Floor = 1;
                do
                {
                    Console.WriteLine("You are on floor number " + elevator.Floor);
                    Console.WriteLine("Enter new floor:  ");
                    elevator.Floor = int.Parse(Console.ReadLine());
                } while (true);


            }
        }
    }
}
