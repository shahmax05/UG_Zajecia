using System;
// 1. Utwórz projekt o nazwie LiczbaPierwsza
namespace LiczbaPierwsza 
    class Program
    {
        // 2. Zadeklaruj statyczną funkcję sprawdzLiczbePierwsza jako procedurę
        static void sprawdzLiczbePierwsza()
        {
        // 3. W ciele funkcji pobierz od użytkownika liczbę. 
        //Sprawdź czy liczba równa się 2, jeżeli tak to wypisz w konsoli "Liczba {0} jest liczbą pierwszą" 
        //jeżeli różnica z dzielenia liczby przez 2 wynosi 0 wypisz "Liczba {0} nie jest liczbą pierwszą".
        Console.WriteLine("Podaj liczbe:");

            int liczba = int.Parse(Console.ReadLine());

            if (liczba == 2)
            {
                Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
            }
            else if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
            }
        // 4. Jeżeli dwa poprzednie warunki nie są spełnione, najpierw zadeklaruj zmienną lpierwsza z wartością true.
        // Następnie wykonaj pętlę od 3 wykonująca się do pierwiastka z podanej liczby z inkrementacją co 2.
        //Jeżeli reszta z dzielenia liczby przez inkrementację jest równa 0 - ustaw wartość zmiennej lpierwsza na false
        // następnie wypisz "Liczba {0} nie jest liczbą pierwszą" i zakończ instrukcją break.
        else
        {
            bool lpierwsza = true;

                for (int i = 3; i <= Math.Sqrt(liczba); i += 2)
                {
                    if (liczba % i == 0)
                    {
                        lpierwsza = false;
                        Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
                        break;
                    }
                }

            // 5. Nadal w tej samej sekcji else lecz poza pętlą napisz warunek
            // jeżeli zmienna lpierwsza jest ustawiona na true wypisz "Liczba {0} jest liczbą pierwszą"
            if (lpierwsza == true)
                {
                    Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                }
            }
        }

    // 6. W metodzie Main wywołaj stworzoną funkcję.
    static void Main(string[] args)
        {
            string odpowiedz;

            do
            {
                sprawdzLiczbePierwsza();
                Console.WriteLine("Czy chcesz sprawdzić kolejną liczbe (tak/nie):");
                odpowiedz = Console.ReadLine();

            } while (odpowiedz != null && (odpowiedz.ToLower() == "tak");
        }
    }
} 