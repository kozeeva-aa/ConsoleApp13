// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//алгоритм поиска Nго простого числа (к примеру 2, 3, 5, 7 где 2 это 1ое число 3 - второе и т.д., т.е. если N = 4 то на выходе должно быть 7)


using System;

class Program
{
    // Метод для проверки, является ли число простым
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i * i <= num; i++) //
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Введите порядковый номер простого числа: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int count = 0; // Счетчик найденных простых чисел
            int number = 2; // Первое простое число

            // Поиск простого числа по порядковому номеру
            while (true)
            {
                if (IsPrime(number)) // Проверяем, является ли текущее число простым
                {
                    count++; // Увеличиваем счетчик найденных простых чисел
                    if (count == n) // Если найдено n простых чисел
                    {
                        Console.WriteLine("простое число #" + n + " = " + number);
                        break; 
                    }
                }
                number++; 
            }
        }
        else
        {
            Console.WriteLine("Введите число больше нуля.");

        }
    }
}


   






