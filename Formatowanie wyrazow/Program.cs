using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazak_z_Spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = Console.ReadLine();
            string New_Word = "";

            int Count = 1;

            for (int i = 1; i < Word.Length; i++)
            {
                if (Word[i-1].Equals(Word[i]))
                {
                    Count++;
                    if (i == Word.Length-1)
                    {
                        if (Count > 2)
                        {
                            New_Word += string.Format("{0}{1}", Word[i - 1], Count);
                            Count = 1;
                        }
                        else if (Count == 2)
                        {
                            New_Word += string.Format("{0}{0}", Word[i - 1]);
                            Count = 1;
                        }
                        else
                        {
                            New_Word += Word[i - 1];
                        }
                    }
                }

                else
                {
                    if (Count>2)
                    {
                        New_Word += string.Format("{0}{1}", Word[i - 1], Count);
                        Count = 1;
                    }
                    else if (Count == 2)
                    {
                        New_Word += string.Format("{0}{0}",Word[i - 1]);
                        Count = 1;
                    }
                    else
                    {
                        New_Word += Word[i - 1];
                    }
                }
            }
            Console.WriteLine(New_Word);

            Console.ReadLine();
        }
    }
}
