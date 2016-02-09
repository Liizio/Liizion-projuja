using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6T2
{
    class Album
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public Dictionary<string, string> Songs = new Dictionary<string, string>();

        public void PrintData()
        {
            Console.WriteLine("Album data:");
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Songs:");
            foreach (KeyValuePair<string, String> kvp in Songs)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            Album mm = new Album { Artist = "Dire Straits", Title = "Making Movies"};
            mm.Songs.Add("1", "Tunnel of love");
            mm.Songs.Add("2", "Romeo and Juliet");
            mm.Songs.Add("3", "Skateaway");
            mm.Songs.Add("4", "Expresso love");
            mm.Songs.Add("5", "hand in hand");
            mm.Songs.Add("6", "Solid rock");
            mm.Songs.Add("7", "Les boys");

            mm.PrintData();
        }



    }
}
