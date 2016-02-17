using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5t6
{
    class Program
    {
        static void Main(string[] args)
        {
            Human mammal = new Human();
            mammal.Move(10);

            for (int i=0; i<50; i++)
            {
                mammal.GetOlder();
            }

            Console.ReadLine();
        }
    }
}
