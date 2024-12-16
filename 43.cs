using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов (N > 1): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine("Ошибка: N должно быть больше 1.");
            return;
        }

        Console.WriteLine("Введите {0} целых чисел через пробел:", n);
        string[] input = Console.ReadLine().Split();

        if (input.Length != n)
        {
            Console.WriteLine("Ошибка: количество введенных чисел не соответствует N.");
            return;
        }

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        List<int> result = new List<int>();

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                result.Add(numbers[i]);
            }
        }

        Console.WriteLine("Элементы, которые меньше своего левого соседа: {0}", string.Join(", ", result));
        Console.WriteLine("Количество таких элементов: {0}", result.Count);
    }
}
