using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int testy;

            testy = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testy; i++)
            {
                int a, b;
                string A = Console.ReadLine();
                string[] B = A.Split(' ');

                a = Int32.Parse(B[0]);
                b = Int32.Parse(B[1]);

                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }

                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
