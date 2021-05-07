using System;

namespace Zadatak_10

//Napišite funkciju koja vraća obrnuti broj danog cijelog broja.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            string uneseniBroj = Console.ReadLine();

            Console.WriteLine('\n');
            Console.WriteLine(obrnutiBroj(uneseniBroj));
            
        }

        static string obrnutiBroj(string uneseniBroj)
        {
            char[] stringarry = uneseniBroj.ToCharArray();
            Array.Reverse(stringarry);
            string broj2 = new string(stringarry);

            return broj2;

        }

        

        


        
        }




        

    }


