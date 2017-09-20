using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predkość_średnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int testy = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testy; i++)
            {
                string A = Console.ReadLine();
                string[] B = A.Split(' ');

                int V1 = Int32.Parse(B[0]);
                int V2 = Int32.Parse(B[1]);

                Console.WriteLine(2*V1*V2/(V1+V2));
            }
        }
    }
}
