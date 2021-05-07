using System;

namespace Zadatak_11

//    Napišite funkciju koja vraća istinu ako je proslijeđeni broj
//palindroman. (jednako se čita s lijeve i desne strane)

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            string broj = Console.ReadLine();

            char[] stringArry = broj.ToCharArray();
            Array.Reverse(stringArry);
            string broj2 = new string(stringArry);

            Console.WriteLine('\n');
            Console.WriteLine(palindrom(broj, broj2));

        }

        static bool palindrom(string broj, string broj2)
        {
            if (broj == broj2)
            {
                return true;
            }

            else
                return false;
                
            
        }
    }
}
