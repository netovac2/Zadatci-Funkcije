using System;

namespace Zadatak_9

//Napišite funkciju koja ispisuje sumu znamenaka cijelog broja.

{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Unesite cijeli broj");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');
            sumaznamenaka(broj);

            
        }

        static void sumaznamenaka(int broj)
        {
            int suma = 0;
            int m;
            
            {
                while (broj > 0)
                {
                    m = broj % 10;
                    suma = suma + m;
                    broj = broj / 10;
                }

                Console.WriteLine("Suma znamenaka unesenog broja je" + " " + suma);
            }
        }



        
           


    }
}
