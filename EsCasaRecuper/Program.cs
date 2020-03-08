using System;

namespace EsCasaRecuper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero positivo. ");
            int a = int.Parse(Console.ReadLine());
            if(a <= 0)
            {
                Console.WriteLine("Il numero non è positivo.");
            }
            else
            {
                if (a % 2 == 0)
                {
                    for (int i = 0; i <= a; i++)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                else
                {
                    for (int i = 0; i <= a; i++)
                    {
                        Console.WriteLine($"{i}") ;

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
