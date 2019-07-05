using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojkat_Menu
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.Title = "Proste menu";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>Proste Menu<<<");
                Console.WriteLine("1 - Rysowanie trojkata");
                Console.WriteLine("2 - Schodki");
                Console.WriteLine("3- Kwadrat/Prostokat");
                Console.WriteLine("4- wyjscie");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); RysowanieTrojkata(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); Schodki(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); Prostokat(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D4:
                        Environment.Exit(0); break;
                    default: break;


                }
            }






        }

        //*******************************************

        static void RysowanieTrojkata()
        {
            int num, i, j, k;
            Console.Write("enter the level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write("-");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        //******************************

        static void Schodki()
        {

            //schodki
            Console.WriteLine("Podaj wysokosc: ");
            int val = Convert.ToInt32(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.ReadKey();
        }

        //******************************


        static void Prostokat()
        {
            Console.Write("Podaj wysokosc ");
            int wysokosc = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj szerokosc ");
            int szerokosc = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= wysokosc; i++)
            {
                for (int j = 1; j <= szerokosc; j++)
                {
                    if ((i == 1 || i == wysokosc) || (j == 1 || j == szerokosc))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
