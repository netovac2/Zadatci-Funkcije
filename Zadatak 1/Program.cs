using System;

namespace Zadatak_1

    //Napišite funkciju koja vraća kvadrat proslijeđenog joj cijelog broja.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');
            Console.WriteLine("Kvadrat broja je" + " " + Kvadrat(a));


        }

        static int Kvadrat(int a)
        {
            int b = a * a;
            return b;
        }
    }
}
