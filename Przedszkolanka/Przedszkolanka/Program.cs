using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przedszkolanka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int cukierki = 1;

            int ile = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < ile; i++)
            {
                string pomocnicza = Console.ReadLine();
                string[] pomocnicza1 = pomocnicza.Split(' ');
                n1 = int.Parse(pomocnicza1[0]);
                n2 = int.Parse(pomocnicza1[1]);

                while (true)
                {
                    if ((cukierki % n1 == 0) && (cukierki % n2 == 0)) break;
                    else
                    {
                        cukierki++;
                    }
                }

                Console.WriteLine(cukierki);
                cukierki = 1;
            }
        }
    }
}
