/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.Write(message);
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

int SumInterval(int m, int n)
{
    if (n == m)
        return m;
    else
        return n = SumInterval(m, n - 1) + n;
}

int m = GetNumber("Введите число M:");
int n = GetNumber("Введите число N:");

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {SumInterval(m, n)}");