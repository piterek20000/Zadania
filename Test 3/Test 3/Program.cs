using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        List<int> dane = new List<int>();

        int liczba;
        int pointer = 0;
        int pomocnicza;
        int count = 0;

        do
        {
            if (dane.Count == 0)
            {
                liczba = Int32.Parse(Console.ReadLine());
                dane.Add(liczba);
            }

            else
            {
                liczba = Int32.Parse(Console.ReadLine());
                dane.Add(liczba);

                pomocnicza = dane[pointer];

                if (liczba == 42 && pomocnicza != 42)
                {
                    count++;
                    pointer++;
                }

                else
                {
                    pointer++;
                }
            }

        } while (count < 3);

        foreach (var item in dane)
        {
            Console.WriteLine(item);
        }
    }
}