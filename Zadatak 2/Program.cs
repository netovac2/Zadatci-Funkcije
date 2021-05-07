using System;

namespace Zadatak_2

    //Napišite funkciju koja ispisuje sve brojeve od 1 do zadanog broja.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            int UneseniBroj = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');
            Ispis(UneseniBroj);
        }

        static void Ispis(int UneseniBroj)

        {
            for (int i = 1; i <= UneseniBroj; i++)
            {
                if (i == UneseniBroj)
                {
                    Console.WriteLine(UneseniBroj + " ");
                }

                else

                {
                    Console.Write(i + "," + " ");
                }
            }
        }
        
        

        
            

        


    }
}
