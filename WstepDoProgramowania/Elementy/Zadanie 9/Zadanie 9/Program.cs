using System;

namespace Oszczednosci
{
    class Program
    {
        // Metoda obliczająca stopę procentową (zwraca float)
        static float StopaProcentowa(decimal saldo)
        {
            if (saldo < 0)
            {
                return 3.213f;
            }
            else if (saldo < 1000m)
            {
                return 0.5f;
            }
            else if (saldo < 5000m)
            {
                return 1.621f;
            }
            else
            {
                return 2.475f;
            }
        }

        // Metoda obliczająca zaktualizowane saldo na następny rok (zwraca decimal)
        static decimal AktulaizacjaSaldaRocznego(decimal saldo)
        {
            // StopaProcentowa zwraca wartość w procentach (np. 0.5), więc musimy podzielić ją przez 100.
            // Rzutujemy też wynik dzielenia z powrotem na 'decimal', aby był zgodny z typem zmiennej 'saldo'.
            decimal stopaJakoUlamek = (decimal)(StopaProcentowa(saldo) / 100f);

            // Dla salda ujemnego (np. -100) odsetki wyjdą ujemne (-100 * 0.03213 = -3.213).
            // Kiedy dodamy je do salda (-100 + (-3.213)), saldo stanie się prawidłowo "bardziej ujemne".
            decimal noweSaldo = saldo + (saldo * stopaJakoUlamek);

            return noweSaldo;
        }

        // Metoda obliczająca ile lat potrwa dobicie do oczekiwanego salda (zwraca int, używa while)
        static int IleLatPrzedOczekiwanymSaldem(decimal saldo, decimal oczekiwaneSaldo)
        {
            int liczbaLat = 0;

            while (saldo < oczekiwaneSaldo)
            {
                saldo = AktulaizacjaSaldaRocznego(saldo);
                liczbaLat++;
            }

            return liczbaLat;
        }

        // Punkt wejściowy programu
        static void Main(string[] args)
        {
            // Litera 'm' na końcu liczby oznacza, że to typ 'decimal'
            decimal saldoPoczatkowe = 200.75m;

            // Wywołanie przygotowanych funkcji dla wartości 200.75
            float odsetki = StopaProcentowa(saldoPoczatkowe);
            decimal noweSaldo = AktulaizacjaSaldaRocznego(saldoPoczatkowe);

            Console.WriteLine($"Saldo początkowe: {saldoPoczatkowe}");
            Console.WriteLine($"Stopa procentowa: {odsetki}%");
            Console.WriteLine($"Saldo po roku: {noweSaldo}");

            // Opcjonalnie: przetestowanie trzeciej metody (np. czekamy aż uzbiera się 1000)
            // Console.WriteLine($"Lata do osiągnięcia 1000: {IleLatPrzedOczekiwanymSaldem(saldoPoczatkowe, 1000m)}");
        }
    }
}