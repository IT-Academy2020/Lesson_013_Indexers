﻿using System;

// Масиви (одновимірний масив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array = new int[5];
            
            array = new int[5] { 1, 2, 3, 4, 5 };

            array = new int[] { 1, 2, 3, 4, 5 };

            // Вивід на екран значень елементів масиву.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
