using System;

namespace ZadanieWhile
{
    class Program
    {
        static void SprawdzIWypisz(int liczba)
        {
            if (liczba % 3 == 0 && liczba % 2 != 0)
            {
                Console.WriteLine(liczba);
            }
        }

        static void Main(string[] args)
        {
            int i = 100;

            while (i >= 1)
            {
                SprawdzIWypisz(i);
                i--;
            }
        }
    }
}