/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
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

int Power(int a, int b)
{
    if (b == 1 || b == 0)
        return a;
    else
        return a = a * Power(a, b - 1);
}

int a = GetNumber("Введите число a:");
int b = GetNumber("Введите число b:");

Console.WriteLine($"{a}в степени {b} равно {Power(a, b)}");