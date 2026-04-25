using System;

namespace ImionaSortowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stworzenie tablicy tekstów o nazwie imiona
            string[] imiona = { "Piotr", "Anna", "Jan", "Leszek", "Ola", "Marek" };

            Console.WriteLine("--- Przed sortowaniem ---");

            // 2. Wypisanie zawartości tablicy przed sortowaniem przy pomocy pętli for
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine(imiona[i]);
            }

            // 3. Wykorzystanie metody Array.Sort(), aby posortować tablicę alfabetycznie
            Array.Sort(imiona);

            Console.WriteLine("\n--- Po sortowaniu ---");

            // 4. Wypisanie zawartości tablicy po sortowaniu przy pomocy pętli for
            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine(imiona[i]);
            }
        }
    }
}