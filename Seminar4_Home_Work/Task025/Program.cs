/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int Multi(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

int a = GetNumber("Введите основание (число для возведения в степень): ");
int b = GetNumber("Введите показатель степени (число, в степень которого будет возводиться основание): ");
int result = Multi(a, b);

Console.WriteLine($"{a} в степени {b} = {result}");