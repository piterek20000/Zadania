using System;

public class Test
{
    public static void Main()
    {
        int[,] koncówki =
                {
                { 0,0,0,0},
                { 1,1,1,1},
                { 6,2,4,8},
                { 1,3,9,7},
                { 6,4,6,4},
                { 5,5,5,5},
                { 6,6,6,6},
                { 1,7,9,3},
                { 6,8,4,2},
                { 1,9,1,9}
                };

        ulong podstawa, wykładnik;
        int ilosc_przypadkow;

        ilosc_przypadkow = Int32.Parse(Console.ReadLine());

        int[] wyniki = new int[ilosc_przypadkow];

        for (int i = 0; i < ilosc_przypadkow; i++)
        {
            string WczytanyWiersz = Console.ReadLine();
            string[] pomocnicza = WczytanyWiersz.Split(' ');

            podstawa = ulong.Parse(pomocnicza[0]);
            wykładnik = ulong.Parse(pomocnicza[1]);

            wyniki[i] = koncówki[podstawa % 10, wykładnik % 4];
        }

        foreach (var item in wyniki)
        {
            Console.WriteLine(item);
        }
    }
}