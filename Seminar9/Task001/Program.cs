/*
Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

/*
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

int PrintN(int start, int n)
{
    if (start == n)
    {
        return n;
    }
    else
    {
        Console.Write($"{start}, ");
        return PrintN(start + 1, n);
    }
}

int n = GetNumber("Введите число N:");
int start = GetNumber("Введите с какого числа начинается вывод:");

Console.Write(PrintN(start, n));
*/

string recursion(int n)
{
    if(n == 1)
        return "1";
    else
        return recursion(n - 1) + ", "+ n;
}

Console.Write($"{recursion(5)}");