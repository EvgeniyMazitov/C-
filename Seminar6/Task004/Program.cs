/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void Fibonacci(int number)
{
    int newDigit = 1;
    int oldDigit = 0;
    int result = 0;
    Console.Write($"{oldDigit} ");
    Console.Write($"{newDigit} ");
    for (int i = 0; i < number - 2; i++)
    {
        result = oldDigit + newDigit;
        oldDigit = newDigit;
        newDigit = result;
        Console.Write($"{newDigit} ");
    }
}

int number1 = GetNumber("Введите число");
Fibonacci(number1);