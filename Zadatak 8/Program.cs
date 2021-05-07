using System;

namespace Zadatak_8

    //Napišite funkciju koja ispisuje tablicu množenja od 1 do zadanog broja.
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 1;
            Console.WriteLine("Unesite broj");
            int broj2 = int.Parse(Console.ReadLine());

            TablicaMnozenja(broj1, broj2);
        }

        static void TablicaMnozenja(int broj1, int broj2)
        {

            for (int i = broj1; i <= broj2; i++)

            {
                if (i == broj2)
                {
                    Console.Write(i * i);
                }

                else
                    Console.Write(i * i + ", ");
            }
        }
    }
}
