using System;

public class Test
{
    public static void Main()
    {

        int n;

        n = Int32.Parse(Console.ReadLine());

        int[] testy = new Int32[n];

        for (int i = 0; i < n; i++)
        {
            int liczba;

            int count = 0;

            liczba = Int32.Parse(Console.ReadLine());

            if (liczba == 1) testy[i] = 0;

            else
            {
                for (int j = 2; j < liczba; j++)
                {
                    if (liczba % j == 0) count++;
                }

                if (count > 0)
                {
                    testy[i] = 0;
                }
                else
                {
                    testy[i] = 1;
                }
            }
        }

        foreach (var item in testy)
        {
            Console.WriteLine((item == 1) ? "TAK" : "NIE");
        }

        Console.ReadLine();
    }
}