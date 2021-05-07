using System;

namespace Zadatak_13

    //Napišite funkciju koja vraća sumu parnih brojeva između 100 i 200.

{
    class Program
    {
        static void Main(string[] args)

        {
            int prviBroj = 100;
            int drugiBroj = 200;

            Console.WriteLine(SumaParnihBrojeva(prviBroj, drugiBroj));
        }

        static int SumaParnihBrojeva(int prviBroj, int drugiBroj)
        {
            int rezultat = 0;
            for (int i = prviBroj; i <= drugiBroj; i++)
           
            {
                if (i % 2 == 0)
                {
                    rezultat += i;
                }

                else
                    rezultat += 0;

                
            }

            return
                    rezultat;
        }
    }
}
