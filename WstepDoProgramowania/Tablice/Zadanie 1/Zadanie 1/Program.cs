using System;

namespace Imiona
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracja i inicjalizacja tablicy tekstów (string)
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek" };

            // Pętla for iterująca od indeksu 0 do końca tablicy
            for (int i = 0; i < imiona.Length; i++)
            {
                // Wypisanie w konsoli: (indeks + 1) oraz elementu tablicy
                Console.WriteLine($"{i + 1}. {imiona[i]}");
            }
        }
    }
}