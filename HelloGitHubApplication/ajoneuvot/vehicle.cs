using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajoneuvot
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;

            tyres = new List<tyre>();

            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
            tyres.Add(new Tyre("Michelin", "X-Ice", "225/45R17"));
        }
    }

    public override string ToString()
    {
        string s = "Vehicle: " + Brand + ", " + Model;

        foreach(Tyre t in tyres)
        {
            s += "\n";
            s += t.ToString();
        }

        return s;
    }
    private List<Tyre> tyres;
}
