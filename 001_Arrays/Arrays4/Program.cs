using System;

// Неявнотипізовані масиви.

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // Масив Int32.
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());


            // Масив Doubles.
            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());


            // Не компілюється. (Несумісні типи)
            // var array3 = new [] { 1, "string" };

            // Delay.
            Console.ReadKey();
        }
    }
}
