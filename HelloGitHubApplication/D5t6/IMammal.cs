using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5t6
{
    abstract class IMammal
    {
        public int Age { get; set; }

        abstract public void Move(int amount);
        /*
        {
            Console.WriteLine("Mammal is moving " + amount + " steps");
        }
        */
    }
}
