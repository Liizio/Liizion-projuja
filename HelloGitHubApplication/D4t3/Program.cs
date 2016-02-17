using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4t3
{
    class Program
    {
        class Radio
        {
            private readonly int MaxVol = 9;
            private readonly int MinVol = 0;

            private readonly float MaxFreq = 26000;
            private readonly float MinFreq = 2000;

            private int vol;

            private float freq;

            private bool power;
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
                        Console.WriteLine("Too much volume, returning to maximum value");
                        vol = MaxVol;
                    }
                    else if (value < MinVol)
                    {
                        Console.WriteLine("Now that is just stupid, returning to zero");
                        vol = MinVol;
                    }
                }
            }

            public int Freq
            {
                get
                {
                    return Freq;
                }

                set
                {
                    if (MinFreq <= value && MaxFreq >= value) freq = value;
                    else if (value > MaxFreq)
                    {
                        Console.WriteLine("Too high frequency, returning to maximum value");
                        freq = MaxFreq;
                    }
                    else if (value < MinFreq)
                    {
                        Console.WriteLine("Too low frequency, returning to minimum value");
                        freq = MinFreq;
                    }
                }
            }

            public bool Power
            {
                get
                {
                    return Power;
                }

                set
                {
                    value = power;
                }
            }

        }
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Power = true;
            do
            {
                Console.Write("1. Print data\n2. Swith power\n3. Change volume\n4. Change frequency");
                int caseSwitch = 1;
                Console.WriteLine("Choose option: ");
                caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        if (radio.Power == true) Console.WriteLine("Power is on");
                        else if (radio.Power == false) Console.WriteLine("Power is off");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            } while (true);
        }
    }
}
