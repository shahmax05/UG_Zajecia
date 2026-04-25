using System;

namespace ImionaStatystyki
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stworzenie tablicy z imionami
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek", "Ola", "Marek" };

            // 2. Utworzenie zmiennych pomocniczych
            int sumaZnakow = 0;
            // Inicjujemy pustym ciągiem znaków, aby mieć punkt odniesienia do pierwszego porównania
            string najdluzszeImie = "";

            // 3. Pętla for do przetwarzania danych
            for (int i = 0; i < imiona.Length; i++)
            {
                // Wypisanie imienia i jego długości
                Console.WriteLine($"{imiona[i]} - liczba znaków: {imiona[i].Length}");

                // Dodanie długości aktualnego imienia do całkowitej sumy
                sumaZnakow += imiona[i].Length;

                // Sprawdzenie, czy aktualne imię jest dłuższe od dotychczas zapamiętanego
                if (imiona[i].Length > najdluzszeImie.Length)
                {
                    // Jeśli tak, nadpisujemy zmienną nowym najdłuższym imieniem
                    najdluzszeImie = imiona[i];
                }
            }

            // 4. Wyświetlenie podsumowania po zakończeniu pętli
            Console.WriteLine("\n--- Podsumowanie ---");
            Console.WriteLine($"Suma wszystkich znaków: {sumaZnakow}");
            Console.WriteLine($"Najdłuższe imię to: {najdluzszeImie}");
        }
    }
}