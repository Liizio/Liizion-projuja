using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Program
    {
        class Amp
        {
            private readonly int MaxVol = 100;
            private readonly int MinVol = 0;

            private int vol;
            public int Vol
            {
                get
                {
                    return vol;
                }

                set
                {
                    if (MinVol <= value && MaxVol >= value) vol = value;
                    else if (value > MaxVol)
                    {
                        Console.WriteLine("Neighbours complain about too loud Eurobeat, returning to maximum safe volume");
                        vol = MaxVol;
                    }
                    else if (value < MinVol)
                    {
                        Console.WriteLine("Now that is just stupid, returning to zero");
                        vol = MinVol;
                    }
                }
            }
            static void Main(string[] args)
            {
                Amp amp = new Amp();
                amp.Vol = 1;
                do
                {
                    Console.WriteLine("Amp is set on volume " + amp.Vol);
                    Console.WriteLine("Enter new volume:  ");
                    amp.Vol = int.Parse(Console.ReadLine());
                } while (true);


            }
        }
    }
}
