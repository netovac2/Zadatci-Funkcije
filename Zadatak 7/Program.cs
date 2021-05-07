using System;

namespace Zadatak_7

//    Napišite funkciju paran koja vraća istinu ukoliko je proslijeđeni broj
//paran.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine('\n');
            Console.WriteLine("Uneseni broj" + " " + broj + " " + "je paran" + "." + '\n' + provjera(broj));
        }

        static bool provjera(int broj)
        {
            int broj2 = broj;
            {
                if (broj2 % 2 == 0)
                {
                    return true;
                }

                else
                    return false;

            }

            
        }

        
            
        }
    } 
