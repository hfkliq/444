using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N (> 0): ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Ошибка: число должно быть больше 0.");
            return;
        }

        int reversedNumber = 0;
        while (N > 0)
        {
            int digit = N % 10; // Получаем последнюю цифру числа
            reversedNumber = reversedNumber * 10 + digit; // Добавляем её в перевёрнутое число
            N /= 10; // Убираем последнюю цифру из числа
        }

        Console.WriteLine("Число, прочитанное справа налево: " + reversedNumber);
    }
}
