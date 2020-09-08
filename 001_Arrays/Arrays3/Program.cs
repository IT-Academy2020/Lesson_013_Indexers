using System;

// Зубчасті масиви (Jagged Array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };


            // У зовнішньому циклі виконується прохід по всіх вкладених масивах.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // У внутрішньому циклі виконується звернення до кожного елементу вкладеного масиву.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
