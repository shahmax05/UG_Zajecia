using System;

namespace ZadaniePetla
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}