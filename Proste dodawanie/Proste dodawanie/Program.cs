using System;

public class Test
{
    public static void Main()
    {
        int testy;

        testy = Int32.Parse(Console.ReadLine());

        int[] wyniki = new int[testy];

        for (int i = 0; i < testy; i++)
        {
            int suma = 0;

            int cyfr;

            cyfr = Int32.Parse(Console.ReadLine());

            string pomocna = Console.ReadLine();

            string[] wierszLiczb = pomocna.Split(' ');

            foreach (var item in wierszLiczb)
            {
                suma += Int32.Parse(item);
            }

            wyniki[i] = suma;
        }

        foreach (var item in wyniki)
        {
            Console.WriteLine(item);
        }
    }
}