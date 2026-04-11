using System;

namespace Trojkat
{
    class Program
    {
        static bool CzyTrojkat(double a, double b, double c) =>
            a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);

        static bool CzySkalenny(double a, double b, double c) =>
            CzyTrojkat(a, b, c) && a != b && a != c && b != c;

        static bool CzyRownoramienny(double a, double b, double c) =>
            CzyTrojkat(a, b, c) && (a == b || a == c || b == c);

        static bool CzyRownoboczny(double a, double b, double c) =>
            CzyTrojkat(a, b, c) && a == b && b == c;

        static void Main()
        {
            Console.Write("Podaj bok a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj bok b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Podaj bok c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("\nRezultat:");

            if (CzyTrojkat(a, b, c))
            {
                Console.WriteLine("Z podanych boków można zbudować trójkąt.");
                Console.WriteLine($"Równoboczny: {CzyRownoboczny(a, b, c)}");
                Console.WriteLine($"Równoramiennynoboczny): {CzyRownoramienny(a, b, c)}");
                Console.WriteLine($"Skalenny (różnoboczny): {CzySkalenny(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Z podanych boków NIE można zbudować trójkąta.");
            }
        }
    }
}