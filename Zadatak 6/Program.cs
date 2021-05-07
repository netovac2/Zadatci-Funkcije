using System;

namespace Zadatak_6

//    Napišite funkciju maksimum koja vraća veći od tri proslijeđena
//broja.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            int drugiBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite treći broj");
            int treciBroj = int.Parse(Console.ReadLine());


            Console.WriteLine('\n');
            Console.WriteLine("Najveći broj je" + " " + najveciBroj(prviBroj, drugiBroj, treciBroj));

        }

        static int najveciBroj (int prviBroj, int drugiBroj, int treciBroj)
        {
            return Math.Max(prviBroj, Math.Max(drugiBroj, treciBroj));
        }
    }
}
