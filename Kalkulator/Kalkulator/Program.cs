using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool k = true;
            while (k)
            {
                string A = Console.ReadLine();
                string[] B = A.Split(' ');

                int a = Int32.Parse(B[1]);
                int b = Int32.Parse(B[2]);

                switch (B[0])
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    case "%":
                        Console.WriteLine(a % b);
                        break;

                    default: k = false;
                        break;
                }

            }
        }
    }
}
