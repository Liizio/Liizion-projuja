using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace D7T3
{
    [Serializable]
    class Show
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public double Time_s { get; set; }
        public double Time_e { get; set; }
        public string Info { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
            Show news = new Show { Name = "Yhdeksan uutiset", Channel = "TV1", Time_s = 21.00, Time_e = 21.15, Info = "uutisia lahelta ja kaukaa" };

            Show heman = new Show { Name = "He-Man and the Masters of the Universe", Channel = "Sub", Time_s = 18.00, Time_e = 19.00, Info = "Skeletor virittaa mopoa" };

            List<Show> shows = new List<Show>();
            shows.Add(heman);
            shows.Add(news);


            Stream writeMultipleStream = new FileStream("MyShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
 
            formatter.Serialize(writeMultipleStream, shows);

            writeMultipleStream.Close();


            Stream openStream = new FileStream("MyShows.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            List<Show> readPersons = (List<Show>)formatter.Deserialize(openStream);

            openStream.Close();

            foreach (Show p in readPersons)
            {
                Console.WriteLine("Name: " + p.Name + " Channel: " + p.Channel + " Running time: " + p.Time_s + " - " + p.Time_e + " Info: " + p.Info);
            }

        }
    }
}
