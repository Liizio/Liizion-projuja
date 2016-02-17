using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6t1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("121294-556c", "Pekka", "Heikkinen", 40, 78, 180));
            persons.Add(new Person("011294-526c", "Eero", "Tervainen", 42, 90, 170));
            persons.Add(new Person("120694-526d", "Arska", "Erkkinen", , 120, 195));
            persons.Add(new Person("128994-556c", "Eino", "Heikkinen", 56, 70, 165));

            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.ToString());
            }

            persons.Sort((x, y) => x.Age.CompareTo(y.Age));
            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }

            string SSN = "011294-526c";

            Person found = persons.Find(x => x.SSN == SSN);

            if (found != null)
            {
                Console.WriteLine("Person with SSN " + SSN + " Found!");
            }

            else
            {
                Console.WriteLine("Person not Found!");
            }

            /*
            foreach (Person somebody in persons)
            {
                if (somebody.SSN == SSN)
                {
                    Console.WriteLine("Person with SSN " + SSN + " Found!");
                    break;
                }
            }*/
        }
    }
}
