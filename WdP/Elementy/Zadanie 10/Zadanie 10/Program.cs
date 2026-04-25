using System;

namespace Fibonacci
{
    class Program
    {
        // Metoda iteracyjna (korzystająca z pętli)
        static uint Iteracja(uint n)
        {
            if (n < 2)
            {
                return n;
            }

            uint fib = 1;
            uint pop = 1;
            uint tmp;
            uint i = 3;

            while (i <= n)
            {
                tmp = pop;
                pop = fib;
                fib = tmp + pop;
                i++;
            }

            return fib;
        }

        // Metoda rekurencyjna (funkcja wywołuje samą siebie)
        static uint Rekurencja(uint n)
        {
            if (n < 2)
            {
                return n;
            }

            return Rekurencja(n - 1) + Rekurencja(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj n (który wyraz ciągu Fibonacciego obliczyć): ");

            // Pobranie wartości n od użytkownika w typie uint (liczba całkowita bez znaku)
            uint n = uint.Parse(Console.ReadLine());

            // Zgodnie z instrukcją wywołanie wypisywania wyników
            Console.WriteLine("Fib({0}) (metoda iteracyjna) = {1}", n, Iteracja(n));
            Console.WriteLine("Fib({0}) (metoda rekurencyjna) = {1}", n, Rekurencja(n));
        }
    }
}