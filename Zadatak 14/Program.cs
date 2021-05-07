using System;

namespace Zadatak_14

//Napišite funkciju koja vraća n faktorijela

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj n");
            int brojN = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');
            Console.WriteLine(Faktorijela(brojN));
        }

        static long Faktorijela(int brojN)
        {
            if (brojN == 0)
            {
                return 1;
            }
            return brojN * Faktorijela(brojN - 1);
        }
    }
}
