using System;

// Абстрактний клас Array.

// Всі масиви є похідними від класу Array.

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
