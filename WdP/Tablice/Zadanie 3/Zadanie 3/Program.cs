using System;

namespace ImionaSzukaj
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stworzenie tablicy z imionami
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek", "Ola", "Marek" };

            // 2. Pobranie imienia od użytkownika
            Console.Write("Wpisz imię, którego szukasz: ");
            string szukaneImie = Console.ReadLine();

            // Zmienna pomocnicza do śledzenia, czy znaleziono imię
            bool czyZnaleziono = false;

            // 3. Pętla for przeszukująca tablicę
            for (int i = 0; i < imiona.Length; i++)
            {
                // Porównujemy wpisane imię z obecnym elementem tablicy
                // (Wielkość liter ma tu znaczenie: "anna" to nie to samo co "Anna")
                if (imiona[i] == szukaneImie)
                {
                    czyZnaleziono = true;
                    // Wypisujemy pozycję (dodajemy 1 do indeksu, aby numeracja była od 1 do 6, a nie od 0)
                    Console.WriteLine($"Znaleziono imię '{szukaneImie}'. Znajduje się ono na pozycji nr {i + 1} (indeks: {i}).");

                    // Skoro już znaleźliśmy imię, nie ma sensu przeszukiwać reszty tablicy
                    break;
                }
            }

            // 4. Jeśli po zakończeniu pętli zmienna nadal wynosi false, wypisujemy komunikat
            if (czyZnaleziono == false)
            {
                Console.WriteLine($"Niestety, nie znaleziono imienia '{szukaneImie}' w tablicy.");
            }
        }
    }
}