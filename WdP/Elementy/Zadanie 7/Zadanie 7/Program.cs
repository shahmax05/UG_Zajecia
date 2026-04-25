using System;
// Napisz program wyświetlajacy w porzadku malejacym liczby od 100 do 1 podzielne przez 3 ale niepodzielne przez 2.
// Zadanie wykonaj za pomoca petli do...while (W pętli wywołaj przygotowaną metodę sprawdzającą i wypisującą liczbę).
namespace ZadanieDoWhile
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

            do
            {
                SprawdzIWypisz(i);
                i--;
            } while (i >= 1);
        }
    }
}