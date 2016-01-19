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

            //t6
            /*
            int matka;
            float maara;
            float maksu;
            const float kulutus = 0.0702f;
            const float hinta = 1.595f;
            Console.WriteLine("Please enter length of drive in kilometres: ");
            matka = int.Parse(Console.ReadLine());
            maara = matka * kulutus;
            maksu = maara * hinta;
            Console.WriteLine(maara + " liters of gasoline will be used, it will cost you " + maksu + " euros.");
            */

            //t7
            /*do
            {
                int vuosi;
                Console.WriteLine("Please enter year: ");
                vuosi = int.Parse(Console.ReadLine());
                if (vuosi % 4 != 0 || (vuosi % 100 == 0 && vuosi % 400 != 0))
                {
                    Console.WriteLine("Year isn't a leap year");
                }
                else Console.WriteLine("Year is a leap year");
            } while (true);
            */
            //t8

            /*do
            {
                int luku1, luku2, luku3;
                Console.Write("Please enter the first number: ");
                luku1 = int.Parse(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                luku2 = int.Parse(Console.ReadLine());
                Console.Write("Please enter the third number: ");
                luku3 = int.Parse(Console.ReadLine());
                if (luku1 > luku2 && luku1 > luku3) Console.WriteLine("Suurin luku on " + luku1);
                else if (luku2 > luku1 && luku2 > luku3) Console.WriteLine("Suurin luku on " + luku2);
                else if (luku3 > luku1 && luku3 > luku2) Console.WriteLine("Suurin luku on " + luku3);
            } while (true);*/

            //t9

            /*do
            {
                int luku, luku2;
                luku2 = 0;
                luku = 1;
                while (luku != 0)
                {
                    Console.WriteLine("Enter a number: ");
                    luku = int.Parse(Console.ReadLine());
                    luku2 = luku2 + luku;
                }

                Console.WriteLine("The sum of numbers is " + luku2);
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

            //t11

            /*
            int rivi, oksat;
            Console.WriteLine("Please enter number of rows: ");
            rivi = int.Parse(Console.ReadLine());
            oksat = 1;

            for (int i = 0; i < rivi; i++)
            {
                Console.WriteLine("*");
                for (int o = 0; o < oksat; o++) {
                    Console.Write("*");
                }
                oksat++;
            }
            */

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

            //t13

            const int numValues = 5;
            int[] numbers = new int[numValues];
            for (int i = 0; i < numValues; i++)
            {
                Console.Write("Enter score: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            


            //t14

            /*
            int arvo, nolla, yksi, kaksi, kolme, nelja, viisi;
            nolla = 0;
            yksi = 0;
            kaksi = 0;
            kolme = 0;
            nelja = 0;
            viisi = 0;
            arvo = 0;
            while (arvo != 10)
            {
                Console.Write("Please enter score 0, 1, 2, 3, 4 or 5: ");
                arvo = int.Parse(Console.ReadLine());
                switch (arvo)
                {
                    case 0:
                        nolla++;
                        break;
                    case 1:
                        yksi++;
                        break;
                    case 2:
                        kaksi++;
                        break;
                    case 3:
                        kolme++;
                        break;
                    case 4:
                        nelja++;
                        break;
                    case 5:
                        viisi++;
                        break;

                }
            }
                Console.WriteLine("Scores:");
                Console.Write("0: ");
                while(nolla > 0)
                {
                    Console.Write("*");
                nolla--;
                }
            Console.WriteLine();
                Console.Write("1: ");
                while (yksi > 0)
                {
                    Console.Write("*");
                    yksi--;
                }
            Console.WriteLine();
            Console.Write("2: ");
            while (kaksi > 0)
            {
                Console.Write("*");
                kaksi--;
            }
            Console.WriteLine();
            Console.Write("3: ");
            while (kolme > 0)
            {
                Console.Write("*");
                kolme--;
            }
            Console.WriteLine();
            Console.Write("4: ");
            while (nelja > 0)
            {
                Console.Write("*");
                nelja--;
            }
            Console.WriteLine();
            Console.Write("5: ");
            while (viisi > 0)
            {
                Console.Write("*");
                viisi--;
            }
            */

            //t16
            /*
            Random rnd = new Random();
            int luku = rnd.Next(0, 100);
            int arvaus = 101;
            int maara = 0;
            while (arvaus != luku)
            {
                Console.WriteLine("Try to guess my number, puny human: ");
                arvaus = int.Parse(Console.ReadLine());
                if (arvaus > luku)
                {
                    Console.WriteLine("your number is too big");
                }
                else if (arvaus < luku)
                {
                    Console.WriteLine("your number is too small");
                }
                maara++;
            }
            Console.WriteLine("Congratulations, it only took you " + maara + " tries to guess my number! You are truly a superior being.");
            */


        }


    }
}