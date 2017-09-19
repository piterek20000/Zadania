using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zliczanie_Liter
{
    class Program
    {
        static void Main(string[] args)
        {
            string zdanie = Console.ReadLine();

            //Tablica z szukanymi literami
            char[] Tablica_Liter =
            {
                 'a','b','c','d','e','f','g','h',
                 'i','j','k','l','m','n','o','p',
                 'q','r','s','t','u','v','w','x',
                 'y','z',
                 'A','B','C','D','E','F','G','H',
                 'I','J','K','L','M','N','O','P',
                 'Q','R','S','T','U','V','W','X',
                 'Y','Z'
            };

            //Tablica odpowiadająca ilości wystąpien poszczegulnych liter
            int[] Tablica_Wartosci = new int[Tablica_Liter.Length];

            Ile_Liter(zdanie, Tablica_Liter, Tablica_Wartosci);

            Ile_Razy(Tablica_Liter, Tablica_Wartosci);

            Console.ReadLine();

        }


        /// <summary>
        /// Metoda wyświetlająca ile razy wystąpiła poszczegulna litera
        /// </summary>
        /// <param name="Tablica_Liter">Tablica szukanych liter</param>
        /// <param name="Tablica_Wartosci">Tablica wystąpien danej litery</param>
        private static void Ile_Razy(char[] Tablica_Liter, int[] Tablica_Wartosci)
        {
            for (int i = 0; i < Tablica_Liter.Length; i++)
            {
                if(Tablica_Wartosci[i] != 0)
                Console.WriteLine("\n\t Litera: {0}, {1} razy.", Tablica_Liter[i], Tablica_Wartosci[i]);
            }
        }

        /// <summary>
        /// Metoda sprawdzająca ile razy wystąpił poszczegulny znak w zdaniu
        /// </summary>
        /// <param name="zdanie"></param>
        /// <param name="Tablica_Liter"></param>
        /// <param name="Tablica_Wartosci"></param>
        private static void Ile_Liter(string zdanie, char[] Tablica_Liter, int[] Tablica_Wartosci)
        {
            for (int i = 0; i < zdanie.Length; i++)
            {
                for (int j = 0; j < Tablica_Liter.Length; j++)
                {
                    if (zdanie[i].Equals(Tablica_Liter[j])) Tablica_Wartosci[j] += 1;
                }
            }
        }
    }
}
