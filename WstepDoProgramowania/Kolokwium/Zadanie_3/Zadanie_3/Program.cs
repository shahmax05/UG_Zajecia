using System;
using System.Collections.Generic;

namespace Zadanie3_KatalogEliksirow
{
    // 1. INTERFEJS
    public interface Potion
    {
        void drink();
    }

    // 2. KLASY IMPLEMENTUJĄCE INTERFEJS
    public class ElixirOfIron : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Elixir of Iron! Czujesz się twardszy.");
        }
    }

    public class ElixirOfSorcery : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Elixir of Sorcery! Twoja moc magiczna rośnie.");
        }
    }

    // Zachowano oryginalną pisownię z diagramu (jedno 'r')
    public class CoruptionPotion : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Coruption Potion! Otacza Cię mroczna aura.");
        }
    }

    public class ManaPotion : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Mana Potion! Odzyskujesz punkty many.");
        }
    }

    public class ElixirOfWrath : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Elixir of Wrath! Wpadasz w szał bojowy.");
        }
    }

    public class HealingPotion : Potion
    {
        public void drink()
        {
            Console.WriteLine("Wypito: Healing Potion! Twoje rany się goją.");
        }
    }

    // 3. TYP WYLICZENIOWY (ENUM)
    // Uwaga: Metody valueOf() i values() z diagramu to standardowe metody wbudowane 
    // dla enumów w języku Java. W C# ich odpowiednikami są Enum.Parse() oraz Enum.GetValues().
    // Enum w C# nie może zawierać wprost deklaracji metod, więc pozostawiono same wartości.
    public enum PotionType
    {
        ELIXIROFSORCERY,
        CORUPTION,
        HEALING,
        MANA,
        ELIXIROFWRATH,
        ELIXIROFIRON
    }

    // 4. FABRYKA (Wzorzec Flyweight)
    public class PotionFactory
    {
        // Prywatne pole "potions" zdefiniowane na diagramie jako Map (w C# to Dictionary)
        private readonly Dictionary<PotionType, Potion> potions;

        public PotionFactory()
        {
            potions = new Dictionary<PotionType, Potion>();
        }

        public Potion createPotion(PotionType type)
        {
            // Jeżeli eliksir danego typu został już stworzony, zwróć go z pamięci
            if (potions.ContainsKey(type))
            {
                return potions[type];
            }

            // W przeciwnym razie stwórz nowy, zgodnie z typem
            Potion newPotion = null;
            switch (type)
            {
                case PotionType.ELIXIROFIRON: newPotion = new ElixirOfIron(); break;
                case PotionType.ELIXIROFSORCERY: newPotion = new ElixirOfSorcery(); break;
                case PotionType.CORUPTION: newPotion = new CoruptionPotion(); break;
                case PotionType.MANA: newPotion = new ManaPotion(); break;
                case PotionType.ELIXIROFWRATH: newPotion = new ElixirOfWrath(); break;
                case PotionType.HEALING: newPotion = new HealingPotion(); break;
            }

            // Dodaj do "mapy" i zwróć
            if (newPotion != null)
            {
                potions.Add(type, newPotion);
            }
            return newPotion;
        }
    }

    // 5. KLASA SKLEPU
    public class ItemShop
    {
        // Prywatne pola reprezentujące półki
        private List<Potion> bottomShelf;
        private List<Potion> topShelf;

        public ItemShop()
        {
            bottomShelf = new List<Potion>();
            topShelf = new List<Potion>();
        }

        // Metoda uzupełniająca półki z wykorzystaniem PotionFactory
        public void fillShelves()
        {
            PotionFactory factory = new PotionFactory();

            // Uzupełnienie górnej półki (np. rzadsze eliksiry)
            topShelf.Add(factory.createPotion(PotionType.ELIXIROFIRON));
            topShelf.Add(factory.createPotion(PotionType.ELIXIROFSORCERY));
            topShelf.Add(factory.createPotion(PotionType.ELIXIROFWRATH));

            // Uzupełnienie dolnej półki (np. podstawowe mikstury)
            bottomShelf.Add(factory.createPotion(PotionType.HEALING));
            bottomShelf.Add(factory.createPotion(PotionType.MANA));
            bottomShelf.Add(factory.createPotion(PotionType.CORUPTION));

            // Ponowne dodanie istniejącego typu, aby udowodnić działanie mapy w fabryce
            bottomShelf.Add(factory.createPotion(PotionType.HEALING));
        }

        public List<Potion> getTopShelf()
        {
            return topShelf;
        }

        public List<Potion> getBottomShelf()
        {
            return bottomShelf;
        }

        public void enumerate()
        {
            Console.WriteLine("=== GÓRNA PÓŁKA ===");
            foreach (var potion in topShelf)
            {
                Console.WriteLine($"- {potion.GetType().Name}");
            }

            Console.WriteLine("\n=== DOLNA PÓŁKA ===");
            foreach (var potion in bottomShelf)
            {
                Console.WriteLine($"- {potion.GetType().Name}");
            }
        }
    }

    // 6. GŁÓWNA KLASA APLIKACJI
    public class App
    {
        // W C# tradycyjnie jest to 'Main' z wielkiej litery, 
        // zachowuję jednak zbieżność argumentów i logikę testową.
        public static void Main(string[] args)
        {
            // Utworzenie obiektu sklepu (relacja <<create>>)
            ItemShop shop = new ItemShop();

            // Użycie metod sklepu
            shop.fillShelves();
            shop.enumerate();

            // Testowanie funkcjonalności drink() dla każdego elementu z górnej półki
            Console.WriteLine("\n=== TESTOWANIE ELIKSIRÓW (Picie z górnej półki) ===");
            foreach (var potion in shop.getTopShelf())
            {
                potion.drink();
            }

            // Zatrzymanie konsoli, aby wynik był widoczny
            Console.ReadLine();
        }
    }
}