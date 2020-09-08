using System;

namespace Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        // Індексатор. 
        public string this[int index]
        {
            get    // Аксесор.
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
            set    // Мутатор.
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Спроба запису за межами масиву.");
            }
        }
    }
}
