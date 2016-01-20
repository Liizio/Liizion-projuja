using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliointia
{
    class Car
    {
        public Car(string model, int cc)
        {
            this.model = model;
            this.cc = cc;
        }

        public int EngineSize
        {
            get { return cc; }
        }

        public string Modelproperty
        {
            get { return model; }
            set {
                if (value == "omega" || value == "rekord")
                {
                    model = value;
                }
                else
                {
                    model = "unknown";
                }
                model = value; }
        }
        //private members
        private string model;
        private readonly int cc;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car opel = new Car("omega", 2997);
            Car opel2 = new Car("ascona", 2397);
            Car opel3 = new Car("GT", 1897);
            Car toyota = new Car("Trueno", 1559);

            Console.WriteLine("the model is: " + opel.Modelproperty);
            Console.WriteLine("the engine size is: " + opel.EngineSize);
            Console.WriteLine("the model is: " + opel3.Modelproperty);
            Console.WriteLine("the engine size is: " + opel3.EngineSize);
            Console.ReadLine();
        }
    }
}
