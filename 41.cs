using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N (> 0): ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            for (int i = 1; i <= N; i++)
            {
                int sum = 0;
                Console.WriteLine($"Квадрат числа {i}:");

                for (int j = 1; j <= 2 * i - 1; j += 2)
                {
                    sum += j;
                    Console.WriteLine($"Добавлено {j}, текущая сумма: {sum}");
                }

                Console.WriteLine($"Результат: {i}^2 = {sum}\n");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число больше 0.");
        }
    }
}
