using System;

namespace Typygeneryczne_zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shuffle<int> tabInt = new Shuffle<int>(5);

            for (int i = 0; i < tabInt.tab.Length; i++)
            {
                tabInt.tab[i] = i;
                Console.WriteLine(tabInt.tab[i]);
            }
            Console.WriteLine();
            tabInt.ArrayShuffle(tabInt.tab);
            
        }
    }
}
