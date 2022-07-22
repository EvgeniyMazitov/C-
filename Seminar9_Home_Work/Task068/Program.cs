/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int m = GetNumber("Введите неотрицательное целое число m:");
int n = GetNumber("Введите неотрицательное целое число n:");

Console.Write($"{AkkermanFunction(m, n)}");