using System;

namespace Zadatak_3

//    Napišite funkciju koja kao parametar prima dva cijela broja, te ispisuje
//sve brojeve od manjeg do većeg.

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
            Console.WriteLine("Niz između prvog i drugog broja");

            Ispis(prviBroj, drugiBroj);



        }

        static void Ispis(int prviBroj, int drugiBroj)
        {
            if (prviBroj < drugiBroj)
            {
                for (int i = prviBroj; i <= drugiBroj; i++)

                {
                    if (i == drugiBroj)
                    {
                        Console.Write(i);
                    }

                    else
                        Console.Write(i + ",");
                }
            }

            else
                for (int i = drugiBroj; i <= prviBroj; i++)

                {
                    if (i == prviBroj)
                    {
                        Console.Write(i);
                    }

                    else
                        Console.Write(i + ",");
                }
           
        }
    }
}
