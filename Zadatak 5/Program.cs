using System;

namespace Zadatak_5

//    Napišite funkciju minimum koja vraća manji od dva proslijeđena
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

            Console.WriteLine('\n');
            Console.WriteLine("Manji broj je" + " " + manjiBroj(prviBroj, drugiBroj));
        }

        static int manjiBroj(int prviBroj, int drugiBroj)
        {
            return Math.Min(prviBroj, drugiBroj);
        }

        
        

  
    }
}
