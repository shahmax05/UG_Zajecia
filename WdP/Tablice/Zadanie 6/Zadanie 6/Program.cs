using System;

namespace ImionaUnikalne
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stworzenie tablicy tekstów z powtórzeniami (celowo dodałem duplikaty)
            string[] imiona = { "Piotr", "Anna", "Jan", "Piotr", "Leszek", "Anna", "Ola" };

            Console.WriteLine("Unikalne imiona w tablicy:");

            // 2. Główna pętla for, która przechodzi przez każde imię po kolei
            for (int i = 0; i < imiona.Length; i++)
            {
                // Zmienna pomocnicza (flaga) zakładająca, że imię jest unikalne
                bool czyBylWczesniej = false;

                // 3. Wewnętrzna pętla for sprawdzająca TYLKO wcześniejsze pozycje w tablicy (od 0 do i)
                for (int j = 0; j < i; j++)
                {
                    // Jeśli obecne imię [i] jest takie samo jak któreś z wcześniejszych [j]
                    if (imiona[i] == imiona[j])
                    {
                        czyBylWczesniej = true; // Zaznaczamy, że to duplikat
                        break; // Przerywamy wewnętrzną pętlę, bo już wiemy, że to duplikat
                    }
                }

                // 4. Jeśli po sprawdzeniu wcześniejszych pozycji flaga nadal wynosi false -> wypisujemy
                if (czyBylWczesniej == false)
                {
                    Console.WriteLine(imiona[i]);
                }
            }
        }
    }
}