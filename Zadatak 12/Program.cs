using System;

namespace Zadatak_12

//    Napišite funkciju koja kao parametar prima jedan cijeli broj, te vraća
//sumu brojeva od 1 do primljenog broja.

{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Unesite cijeli broj");
            int cijeliBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma brojeva između broja 1 i unesenog broja je" + " " + sumaBrojeva(cijeliBroj, x));
        }

        static int sumaBrojeva(int cijeliBroj, int x)

        {
            int y = 0;

            for (int i = x; i <= cijeliBroj; i++)

            {
                y += i;
            }

            {
                int w = y + cijeliBroj;      
            }

            return y;
                
               


           
                 

            
          

        }
    }
}
