using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace D7T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string istext;
            int isinteger;
            double isdouble;
            do
            {
                Console.WriteLine("Please enter a number: ");
                istext = Console.ReadLine();

                if (int.TryParse(istext, out isinteger))
                {
                    using (StreamWriter sw = File.AppendText("int.txt"))
                    {
                        sw.WriteLine(isinteger + "\n");
                    }
                }
                else if (double.TryParse(istext, out isdouble))
                {
                    using (StreamWriter sw = File.AppendText("double.txt"))
                    {
                        sw.WriteLine(isdouble + "\n");
                    }
                }
                else
                {
                    break;
                }
            } while (true);


        }
    }
}
