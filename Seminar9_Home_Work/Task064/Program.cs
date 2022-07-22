/*
Задача 64: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

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

string Interval(int m, int n)
{
    if(n == m)
        return m.ToString();
    else
        return Interval(m,n-1) + ", "+ n;
}

int m = GetNumber("Введите число M:");
int n = GetNumber("Введите число N:");

Console.Write($"{Interval(m,n)}");