using System;

namespace ImionaFiltr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stworzenie tablicy z imionami
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek", "Ola", "Marek" };

            // Pętla for iterująca po wszystkich elementach tablicy
            for (int i = 0; i < imiona.Length; i++)
            {
                // Właściwość .Length dla typu string zwraca liczbę znaków w tekście.
                // Sprawdzamy, czy imię pod obecnym indeksem ma więcej niż 3 znaki.
                if (imiona[i].Length > 3)
                {
                    // Wypisanie przefiltrowanego imienia wraz z jego długością
                    Console.WriteLine($"{imiona[i]} - liczba znaków: {imiona[i].Length}");
                }
            }
        }
    }
}