using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaOlioprojekti
{
    class Program
    {

        static void Main(string[] args)
        {
            //t1
            /*int luku;
            do
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                if (luku == 1) Console.WriteLine("yksi");
                else if (luku == 2) Console.WriteLine("kaksi");
                else if (luku == 3) Console.WriteLine("kolme");
                else Console.WriteLine("Joku muu luku");
            } while (luku != 0);*/

            //t2
            /*int piste;
            Console.Write("Anna pistemäärä > ");
            piste = int.Parse(Console.ReadLine());
            if (piste >= 0 && piste <= 1) Console.WriteLine("Koulunumero on 0");
            else if (piste >= 2 && piste <= 3) Console.WriteLine("Koulunumero on 1");
            else if(piste >= 4 && piste <= 5) Console.WriteLine("Koulunumero on 2");
            else if (piste >= 6 && piste <= 7) Console.WriteLine("Koulunumero on 3");
            else if (piste >= 8 && piste <= 9) Console.WriteLine("Koulunumero on 4");
            else if (piste >= 10 && piste <= 12) Console.WriteLine("Koulunumero on 0");*/

            //t3
            /*int luku, luku2, luku3, summa;
            float keski;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());
            summa = luku + luku2 + luku3;
            Console.WriteLine("Summa: " + summa);
            keski = (luku + luku2 + luku3) / 3;
            Console.WriteLine("keskiarvo: " + keski);
            */

            //t4
            /*int age = 1;
            do
            {
                Console.Write("Please enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("Minor");
                }
                else if (18 <= age && age < 65)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Senior");
                }

            } while(age != 0);
            */

            //t5
            /*int second = 0;
            int hours = 0;
            int minute = 0;
            do
            {
                Console.Write("Please enter seconds: ");
                second = int.Parse(Console.ReadLine());
                while (second >= 3600)
                {
                    second = second - 3600;
                    hours++;
                };
                while (second >= 60)
                {
                    second = second - 60;
                    minute++;
                };
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minute);
                Console.WriteLine("Seconds: " + second);
                second = 0;
                minute = 0;
                hours = 0;
            } while (true);
            */

            //t10

            /*const int numValues = 9;
            int[] numbers = new int[numValues] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i=0; i < numValues; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/

            //t12
            /*
            const int numValues = 5;
            int[] numbers = new int[numValues];
            for (int i=0; i<numValues; i++)
            {
                Console.Write("Sir, please enter a number..: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Sir, ...");
            for (int i = numValues - 1; 1 >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
            */

            //t12
            /*
            const int numValues = 5;
            int[] numbers = new int[numValues] { 8, 10, 2, 6, 3 };

            Array.Sort(numbers);

            int sum = 0;
            for (int i=1; i<numbers.Length - 1; i++)
            {
                sum += numbers[i];
                Console.WriteLine(numbers[i]);
            }
            Console.Write(sum);
            */



            Console.ReadLine();