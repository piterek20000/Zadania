using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_pewnego_koła
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, d;
            double pi = 3.141592654;

            string A = Console.ReadLine();
            string[] B = A.Split(' ');

            r = double.Parse(B[0]);
            d = double.Parse(B[1]);

            r *= r;
            d *= d;

            Console.WriteLine((r - d / 4) * pi);
        }
    }
}
