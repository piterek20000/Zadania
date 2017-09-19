using System;

public class Test
{
    public static void Main()
    {
        int testy;

        testy = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < testy; i++)
        {
            int n;

            n = Int32.Parse(Console.ReadLine());

            switch (n)
            {

                case 0:
                case 1: Console.WriteLine("0 1"); break;

                case 2: Console.WriteLine("0 2"); break;

                case 3: Console.WriteLine("0 6"); break;

                case 4: Console.WriteLine("2 4"); break;

                case 5:
                case 6:
                case 8: Console.WriteLine("2 0"); break;

                case 7: Console.WriteLine("4 0"); break;

                case 9: Console.WriteLine("8 0"); break;

                default:

                    Console.WriteLine("0 0"); break;

                    break;
            }
        }
    }
}